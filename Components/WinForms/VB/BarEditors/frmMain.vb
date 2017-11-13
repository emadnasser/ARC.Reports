Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors.Repository

Namespace DevExpress.XtraBars.Demos.BarEditors
    ''' <summary>
    ''' Summary description for frmMain.
    ''' </summary>
    Partial Public Class frmMain
        Inherits System.Windows.Forms.Form
        Public Sub New()
            DevExpress.Utils.About.UAlgo.Default.DoEventObject(DevExpress.Utils.About.UAlgo.kDemo, DevExpress.Utils.About.UAlgo.pWinForms, Me) 'DEMO_REMOVE
            '
            ' Required for Windows Form Designer support
            '
            DBFileName = DevExpress.Utils.FilesHelper.FindingFileName(Application.StartupPath, "Data\Products.xml")
            InitializeComponent()
            If DBFileName <> "" Then
                Dim dataSet As DataSet = New DataSet()
                dataSet.ReadXml(DBFileName)
                dataView = dataSet.Tables(0).DefaultView
                gridControl1.DataSource = dataView
            End If
            Dim s As String() = New String() {"Beverages", "Condiments", "Confections", "Dairy Products", "Grains/Cereals", "Meat/Poultry", "Produce", "Seafood"}
            Dim i As Integer = 0
            Do While i < s.Length
                repositoryImageComboBox1.Items.Add(New ImageComboBoxItem(s(i), i + 1, i))
                i += 1
            Loop
            Dim ri As RepositoryItem = TryCast(repositoryImageComboBox1.Clone(), RepositoryItem)
            gridControl1.RepositoryItems.Add(ri)
            colCategoryID.ColumnEdit = ri
            SetFilter()
            ips_Init()
            InitSkins()
            '
            ' TODO: Add any constructor code after InitializeComponent call
            '
        End Sub
#Region "Skins"

        Private Sub InitSkins()
            barManager1.ForceInitialize()
            For Each cnt As DevExpress.Skins.SkinContainer In DevExpress.Skins.SkinManager.Default.Skins
                Dim item As BarButtonItem = New BarButtonItem(barManager1, skinMask & cnt.SkinName)
                iPaintStyle.AddItem(item)
                AddHandler item.ItemClick, AddressOf OnSkinClick
            Next cnt
        End Sub
        Private Sub OnSkinClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            Dim skinName As String = e.Item.Caption.Replace(skinMask, "")
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle(skinName)
            barManager1.GetController().PaintStyleName = "Skin"
            iPaintStyle.Hint = e.Item.Caption
            iPaintStyle.Caption = iPaintStyle.Hint
            iPaintStyle.Hint = iPaintStyle.Caption
            iPaintStyle.ImageIndex = -1
        End Sub
#End Region
        Private DBFileName As String
        Private dataView As DataView
        Private filter As String() = New String(2) {}
        Private skinMask As String = "Skin: "

        Private Sub SetFilter()
            If dataView Is Nothing Then
                Return
            End If
            Dim f As String = ""
            For Each s As String In filter
                If f <> "" AndAlso (Not s Is Nothing AndAlso s <> "") Then
                    f &= " AND "
                End If
                If s <> "" Then
                    f &= s
                End If
            Next s
            dataView.RowFilter = f
            If (f = "") Then
                iFilter.Caption = "No Filter"
            Else
                iFilter.Caption = "Filter: " & f
            End If
            iRecords.Caption = "Records: " & dataView.Count.ToString()
        End Sub

        Private Sub discontinued_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles discontinued.EditValueChanged
            If discontinued.EditValue Is Nothing Then
                filter(0) = ""
            Else
                filter(0) = "[Discontinued] = " & discontinued.EditValue.ToString()
            End If
            SetFilter()
        End Sub

        Private Sub lastOrder_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lastOrder.EditValueChanged
            If lastOrder.EditValue Is Nothing Or String.Empty.Equals(lastOrder.EditValue) Then
                filter(1) = ""
            Else
                filter(1) = "[LastOrder] < #" & StringDateToUFormat(lastOrder.EditValue.ToString()) & "#"
            End If
            SetFilter()
        End Sub

        Private Sub iClearFilter_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles iClearFilter.ItemClick
            discontinued.EditValue = Nothing
            lastOrder.EditValue = Nothing
            categories.EditValue = Nothing
        End Sub

        Private Sub categories_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles categories.EditValueChanged
            If categories.EditValue Is Nothing Then
                filter(2) = ""
            Else
                filter(2) = "[CategoryID] = " & categories.EditValue.ToString()
            End If
            SetFilter()
        End Sub

        Private Sub iExit_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles iExit.ItemClick
            Close()
        End Sub

        Private Sub iAbout_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles iAbout.ItemClick
            BarManager.About()
        End Sub

        Private Shared Function StringDateToUFormat(ByVal s As String) As String
            Try
                Return DateTime.Parse(s).ToString("d", System.Globalization.CultureInfo.InvariantCulture)
            Catch
                Return s
            End Try
        End Function

        Private Sub ips_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles ipsDefault.ItemClick, ipsWXP.ItemClick, ipsOXP.ItemClick, ipsO2K.ItemClick, ipsO3.ItemClick
            barManager1.GetController().PaintStyleName = e.Item.Description
            InitPaintStyle(e.Item)
            barManager1.GetController().ResetStyleDefaults()
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SetDefaultStyle()
        End Sub

        Private Sub InitPaintStyle(ByVal item As BarItem)
            If item Is Nothing Then
                Return
            End If
            iPaintStyle.ImageIndex = item.ImageIndex
            iPaintStyle.Caption = item.Caption
            iPaintStyle.Hint = item.Description
        End Sub

        Private Sub ips_Init()
            Dim item As BarItem = Nothing
            For i As Integer = 0 To barManager1.Items.Count - 1
                If barManager1.Items(i).Description = barManager1.GetController().PaintStyleName Then
                    item = barManager1.Items(i)
                End If
            Next i
            InitPaintStyle(item)
        End Sub
    End Class
End Namespace
