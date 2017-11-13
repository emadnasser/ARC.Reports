Imports System
Imports System.Collections.Generic
Imports DevExpress.XtraRichEdit.API.Native
Imports DevExpress.XtraRichEdit
Imports DevExpress.Xpf.Core
Imports System.Windows
Imports DevExpress.Office.Utils
Imports DevExpress.Office.Layout

Namespace RichEditDemo
    Partial Public Class HyperlinkClickHandling
        Inherits RichEditDemoModule

        Private Shared products As List(Of String) = CreateProducts()
        Private Shared managers As List(Of String) = CreateManagers()
        Private Shared contactInfos As List(Of String) = CreateContactInfos()
        Private Shared Function CreateProducts() As List(Of String)
            Dim result As New List(Of String)()
            result.Add("DXScheduler™")
            result.Add("DXRichEdit™")
            result.Add("DXSpellChecker™")
            result.Add("DXGrid™")
            result.Add("DXPivotGrid™")
            result.Add("DXBars™")
            result.Add("DXCharts™")
            result.Add("DXLayoutControl™")
            result.Add("DXNavBar™")
            result.Add("DXEditors™")
            result.Add("DXPrinting™")
            result.Add("DXCarousel™")
            result.Add("DXThemes™")
            Return result
        End Function
        Private Shared Function CreateManagers() As List(Of String)
            Dim result As New List(Of String)()
            result.Add("Mark M Leininger")
            result.Add("Caroline R Geraghty")
            result.Add("Dorothy M Salas")
            result.Add("Pete M Smith")
            result.Add("Lena D Carroll")
            result.Add("Shauna T Tuggle")
            result.Add("Mary R Spencer")
            result.Add("David G Rucker")
            result.Add("Barry D Phillips")
            result.Add("Ronald R Ross")
            result.Add("Nellie J Burdette")
            Return result
        End Function
        Private Shared Function CreateContactInfos() As List(Of String)
            Dim result As New List(Of String)()
            result.Add("Mark.M.Leininger@dodgit.com, 773-384-2677")
            result.Add("Caroline.R.Geraghty@mailinator.com, 703-968-3712")
            result.Add("Dorothy.M.Salas@trashymail.com, 541-995-3154")
            result.Add("Pete.M.Smith@spambob.com, 954-568-0573")
            result.Add("Lena.D.Carroll@spambob.com, 772-663-2034")
            result.Add("Shauna.T.Tuggle@mailinator.com, 812-463-8021")
            result.Add("Mary.R.Spencer@dodgit.com, 510-819-1801")
            result.Add("David.G.Rucker@spambob.com, 423-550-7308")
            result.Add("Barry.D.Phillips@mailinator.com, 831-308-3866")
            result.Add("Ronald.R.Ross@dodgit.com, 847-242-3792")
            result.Add("Nellie.J.Burdette@pookmail.com, 937-777-5277")
            Return result
        End Function

        Private Delegate Function CreateControlDelegate() As PopupControlBase
        Private hyperlinkMappings As Dictionary(Of String, CreateControlDelegate)
        Private activeWindow As FloatingContainer

        Public Sub New()
            InitializeComponent()
            Me.richEdit.Options.Hyperlinks.ModifierKeys = System.Windows.Forms.Keys.None
            RtfLoadHelper.Load("HyperlinkClickHandling.rtf", richEdit)
            ribbonControl1.SelectedPage = pageHome
            Me.hyperlinkMappings = CreateHyperlinkMappings()
            AddHandler GotFocus, AddressOf HyperlinkClickHandling_GotFocus
            SubscribeRichEditEvents()
        End Sub

        Private Sub HyperlinkClickHandling_GotFocus(ByVal sender As Object, ByVal e As RoutedEventArgs)
            If Me.activeWindow IsNot Nothing Then
                Me.activeWindow.IsOpen = False
                Me.activeWindow = Nothing
            End If
        End Sub
        Private Function CreateHyperlinkMappings() As Dictionary(Of String, CreateControlDelegate)
            Dim result As New Dictionary(Of String, CreateControlDelegate)()
            Dim hyperlinks As HyperlinkCollection = Me.richEdit.Document.Hyperlinks
            result.Add("OpenSelectProductForm", AddressOf CreateSelectProductControl)
            result.Add("OpenSelectAmountForm", AddressOf CreateSelectAmountControl)
            result.Add("OpenSelectDateForm", AddressOf CreateSelectDateControl)
            result.Add("OpenSelectManagerForm", AddressOf CreateSelectManagerControl)
            Return result
        End Function
        Private Function CreateSelectProductControl() As PopupControlBase
            Dim result As New SelectProductControl(products)
            AddHandler result.Commit, AddressOf OnProductControlCommit
            Return result
        End Function
        Private Sub OnProductControlCommit(ByVal sender As Object, ByVal e As EventArgs)
            Dim control As SelectProductControl = DirectCast(sender, SelectProductControl)
            Dim value As String = DirectCast(control.EditValue, String)
            ReplaceRange(value, control.Range)
        End Sub
        Private Function CreateSelectDateControl() As PopupControlBase
            Dim result As New SelectDateControl()
            AddHandler result.Commit, AddressOf OnSelectDateControlCommit
            Return result
        End Function
        Private Sub OnSelectDateControlCommit(ByVal sender As Object, ByVal e As EventArgs)
            Dim control As SelectDateControl = DirectCast(sender, SelectDateControl)
            Dim value As String = DirectCast(control.EditValue, Date).ToString("MMMM, dd yyyy")
            ReplaceRange(value, control.Range)
        End Sub
        Private Function CreateSelectAmountControl() As PopupControlBase
            Dim result As New SelectAmountControl()
            AddHandler result.Commit, AddressOf OnSelectAmountControlCommit
            Return result
        End Function
        Private Sub OnSelectAmountControlCommit(ByVal sender As Object, ByVal e As EventArgs)
            Dim control As SelectAmountControl = DirectCast(sender, SelectAmountControl)
            Dim value As String = DirectCast(control.EditValue, Decimal).ToString("$0.00")
            ReplaceRange(value, control.Range)
        End Sub
        Private Function CreateSelectManagerControl() As PopupControlBase
            Dim result As New SelectManagerControl(managers, contactInfos)
            AddHandler result.Commit, AddressOf OnSelectManagerControl
            Return result
        End Function
        Private Sub OnSelectManagerControl(ByVal sender As Object, ByVal e As EventArgs)
            Dim control As SelectManagerControl = DirectCast(sender, SelectManagerControl)
            Dim value As String = DirectCast(control.EditValue, String)
            ReplaceRange(value, control.Range)
        End Sub
        Private Sub SubscribeRichEditEvents()
            AddHandler richEdit.HyperlinkClick, AddressOf OnHyperlinkClick
        End Sub
        Private Sub OnHyperlinkClick(ByVal sender As Object, ByVal e As HyperlinkClickEventArgs)
            If e.ModifierKeys <> Me.richEdit.Options.Hyperlinks.ModifierKeys Then
                Return
            End If
            Dim createControl As CreateControlDelegate = Nothing
            If Not hyperlinkMappings.TryGetValue(e.Hyperlink.NavigateUri, createControl) Then
                Return
            End If
            If Me.activeWindow IsNot Nothing Then
                Me.activeWindow.IsOpen = False
                Me.activeWindow = Nothing
            End If
            Dim control As PopupControlBase = createControl()
            control.Range = e.Hyperlink.Range
            Dim container As FloatingContainer = FloatingContainerFactory.Create(FloatingMode.Window)
            control.OwnerWindow = container
            container.Content = control
            container.Owner = Me.richEdit
            AddHandler container.Hidden, Sub(obj, args) DirectCast(Me.richEdit, ILogicalOwner).RemoveChild(CType(obj, FloatingContainer))
            DirectCast(Me.richEdit, ILogicalOwner).AddChild(container)
            container.SizeToContent = SizeToContent.WidthAndHeight
            container.ContainerStartupLocation = WindowStartupLocation.Manual
            container.FloatLocation = GetWindowLocation()
            container.IsOpen = True
            Me.activeWindow = container
            control.Focus()
            e.Handled = True
        End Sub
        Private Sub container_Hidden(ByVal sender As Object, ByVal e As RoutedEventArgs)
            Dim container As FloatingContainer = TryCast(sender, FloatingContainer)
            DirectCast(Me.richEdit, ILogicalOwner).RemoveChild(container)
        End Sub
        Private Function GetWindowLocation() As Point
            Dim position As DocumentPosition = Me.richEdit.Document.CaretPosition
            Dim rect As System.Drawing.Rectangle = Me.richEdit.GetBoundsFromPosition(position)
            Dim richViewBounds As System.Drawing.Rectangle = GetRichEditViewBounds()
            Dim location As New System.Drawing.Point(rect.Right - richViewBounds.X, rect.Bottom - richViewBounds.Y)
            Dim localPoint As System.Drawing.Point = Units.DocumentsToPixels(location, Me.richEdit.DpiX, Me.richEdit.DpiY)
            Return New Point(localPoint.X, localPoint.Y)
        End Function
        Private Function GetRichEditViewBounds() As System.Drawing.Rectangle
            Dim documentLayoutUnitConverter As DocumentLayoutUnitConverter = New DocumentLayoutUnitDocumentConverter(Me.richEdit.DpiX, Me.richEdit.DpiY)
            Return documentLayoutUnitConverter.LayoutUnitsToDocuments(richEdit.ViewBounds)
        End Function
        Private Function GetHyperlinkIndex(ByVal hyperlink As Hyperlink) As Integer
            Dim hyperlinks As HyperlinkCollection = Me.richEdit.Document.Hyperlinks
            Dim count As Integer = hyperlinks.Count
            For i As Integer = 0 To count - 1
                If hyperlinks(i) Is hyperlink Then
                    Return i
                End If
            Next i
            Return -1
        End Function
        Private Sub ReplaceRange(ByVal value As String, ByVal range As DocumentRange)
            Dim document As Document = Me.richEdit.Document
            document.BeginUpdate()
            Try
                document.Replace(range, value)
            Finally
                document.EndUpdate()
            End Try
        End Sub
    End Class
End Namespace
