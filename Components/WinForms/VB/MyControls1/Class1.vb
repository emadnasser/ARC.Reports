Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors.Registrator
Imports DevExpress.XtraEditors.ViewInfo
Imports DevExpress.XtraEditors.Drawing

<UserRepositoryItem("RegisterMyColorEdit")> _
Public Class RepositoryItemMyColorEdit
    Inherits RepositoryItemImageComboBox
    Private _useSystemColors As Boolean
    Shared Sub New()
        RegisterMyColorEdit()
    End Sub

    Public Sub New()
        Me._useSystemColors = True
        InitColorItems()
    End Sub

    Public Shared Sub RegisterMyColorEdit()
        Dim img As Image = CType(Bitmap.FromStream(System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream("DevExpress.CustomEditors.MyColorEdit.bmp")), Bitmap)
        EditorRegistrationInfo.Default.Editors.Add(New EditorClassInfo("MyColorEdit", GetType(MyColorEdit), GetType(RepositoryItemMyColorEdit), GetType(ImageComboBoxEditViewInfo), New ImageComboBoxEditPainter(), True, img, GetType(DevExpress.Accessibility.PopupEditAccessible)))
    End Sub

    Public Overrides ReadOnly Property EditorTypeName() As String
        Get
            Return "MyColorEdit"
        End Get
    End Property

    Public Overrides Sub Assign(ByVal item As RepositoryItem)
        BeginUpdate()
        Try
            MyBase.Assign(item)
            Dim source As RepositoryItemMyColorEdit = CType(item, RepositoryItemMyColorEdit)
            If source Is Nothing Then Exit Sub
            Me._useSystemColors = source.UseSystemColors
        Finally
            EndUpdate()
        End Try
    End Sub

    <Browsable(False), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)> _
    Public Overloads ReadOnly Property Items() As ImageComboBoxItemCollection
        Get
            Return MyBase.Items
        End Get
    End Property

    <DefaultValue(True)> _
    Public Property UseSystemColors() As Boolean
        Get
            Return _useSystemColors
        End Get
        Set(ByVal Value As Boolean)
            If _useSystemColors <> Value Then
                _useSystemColors = Value
                InitColorItems()
                OnPropertiesChanged()
            End If
        End Set
    End Property

    Private SysColor As String = "System Color"
    Protected Sub InitColorItems()
        Dim colors As Array = System.Enum.GetValues(GetType(KnownColor))
        Dim imageCount As Integer = 0

        Dim side As Integer = 16
        Dim offset As Integer = 2
        Dim il As New ImageList()
        il.ImageSize = New Size(side, side)

        Dim r As New Rectangle(offset, offset, side - offset * 2, side - offset * 2)

        BeginUpdate()
        Try
            Items.Clear()
            SmallImages = il
            Dim i As Integer

            For i = 0 To colors.Length - 1
                Dim c As Color = Color.FromKnownColor(colors.GetValue(i))
                Dim s As String = colors.GetValue(i).ToString() + IIf(c.IsSystemColor, " (System)", "")

                If Not (c.IsSystemColor And Not UseSystemColors) Then
                    Dim im As New Bitmap(side, side)
                    Dim g As Graphics = Graphics.FromImage(im)
                    g.FillRectangle(New SolidBrush(c), r)
                    g.DrawRectangle(Pens.Black, r)
                    il.Images.Add(im)
                    g.Dispose()
                    Items.Add(New ImageComboBoxItem(s, c, imageCount))
                    imageCount += 1
                Else
                    If i = 0 Then
                        Dim im As New Bitmap(side, side)
                        Dim g As Graphics = Graphics.FromImage(im)
                        g.FillRectangle(New SolidBrush(SystemColors.Control), r)
                        g.DrawString("S", New Font("Tahoma", 8, FontStyle.Bold), New SolidBrush(Color.Black), New RectangleF(r.X, r.Y, r.Width, r.Height))
                        g.DrawRectangle(Pens.Black, r)
                        il.Images.Add(im)
                        s = SysColor
                        g.Dispose()
                        Items.Add(New ImageComboBoxItem(s, SystemColors.Control, imageCount))
                        imageCount += 1
                    End If
                End If
            Next
        Finally
            CancelUpdate()
        End Try
    End Sub
End Class
<ToolboxBitmap(GetType(MyColorEdit), "MyColorEdit.bmp")> _
Public Class MyColorEdit
    Inherits ImageComboBoxEdit
    Shared Sub New()
        RepositoryItemMyColorEdit.RegisterMyColorEdit()
    End Sub

    Public Sub New()
        ctrl = Nothing
    End Sub

    Public Overrides ReadOnly Property EditorTypeName() As String
        Get
            Return "MyColorEdit"
        End Get
    End Property

    <DesignerSerializationVisibility(DesignerSerializationVisibility.Content)> _
    Public Shadows ReadOnly Property Properties() As RepositoryItemMyColorEdit
        Get
            Return CType(MyBase.Properties, RepositoryItemMyColorEdit)
        End Get
    End Property

    <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)> _
    Public Property MyColor() As Color
        Get
            If TypeOf EditValue Is Color Then Return CType(EditValue, Color)
            Return Color.Empty
        End Get
        Set(ByVal Value As Color)
            EditValue = Value
        End Set
    End Property

    Private ctrl As Control
    Public Property Control() As Control
        Get
            Return ctrl
        End Get
        Set(ByVal Value As Control)
            ctrl = Value
            If Not ctrl Is Nothing Then
                AddHandler ctrl.BackColorChanged, New EventHandler(AddressOf OnCtrlColorChanged)
                MyColor = ctrl.BackColor
            End If
        End Set
    End Property

    Sub OnCtrlColorChanged(ByVal sender As Object, ByVal e As EventArgs)
        If Not ctrl Is Nothing Then MyColor = ctrl.BackColor
    End Sub

    Protected Overrides Sub OnEditValueChanged()
        MyBase.OnEditValueChanged()
        If Not ctrl Is Nothing Then
            Try
                ctrl.BackColor = MyColor
            Catch
            End Try
        End If
    End Sub
End Class
