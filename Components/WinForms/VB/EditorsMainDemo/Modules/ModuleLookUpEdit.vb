Imports System.Collections
Imports System.ComponentModel
Imports DevExpress.XtraEditors
Imports DevExpress.Utils.Text
Imports DevExpress.Tutorials

Namespace DevExpress.XtraEditors.Demos
	Partial Public Class ModuleLookUpEdit
		Inherits TutorialControl

		Public Sub New()
			InitializeComponent()
			InitData()
			InitArrayData()
            InitLookUp()
            InitValues()
            TutorialInfo.WhatsThisCodeFile = "VB\EditorsMainDemo\Modules\ModuleLookUpEdit.vb;VB\EditorsMainDemo\Modules\LookUpProperties.vb"
			TutorialInfo.WhatsThisXMLFile = "lookupedit.xml"
		End Sub

		Protected Overrides ReadOnly Property AllowCenterControls() As Boolean
			Get
				Return False
			End Get
		End Property
		Private properties As LookUpProperties = Nothing

		Private Sub ModuleLookUpEdit_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
			ControlUtils.CenterControlInParent(lookUpEdit1)
			ControlUtils.CenterControlInParent(lookUpEdit2)
			ControlUtils.CenterControlInParent(lookUpEdit3)
			ControlUtils.CenterControlInParent(lookUpEdit4)
			notePanel1.Text = "This sample demonstrates how to use a DataView as a data source for a Lookup editor."
			notePanel2.Text = "This sample demonstrates how to bind a class inherited from Collection Base within a Lookup edit."
			notePanel3.Text = "This sample demonstrates how to use an ArrayList-based object as a data source within a Lookup editor."
			notePanel4.Text = "This sample illustrates how to use the Properties.GetNotInListValue event of the Lookup Edit. Use it to display virtual data within an unbound column of your control."
            notePanel1.Visible = True
		End Sub

		Private ReadOnly Property CurrentEdit() As LookUpEdit
			Get
				Select Case xtraTabControl1.SelectedTabPageIndex
					Case 1
						Return lookUpEdit2
					Case 2
						Return lookUpEdit3
					Case 3
						Return lookUpEdit4
				End Select
				Return lookUpEdit1
			End Get
		End Property


		Private Sub InitValues()
			If properties Is Nothing Then
				properties = New LookUpProperties(CurrentEdit)
				properties.Dock = DockStyle.Fill
				xtraTabPage5.Controls.Add(properties)
			Else
				properties.InitLookUp(CurrentEdit)
			End If
		End Sub

		'<lookUpEdit1>
		'<dataNavigator1>
		Private dvMain, dvProducts As DataView

		Private Sub InitData()
			Dim DBFileName As String = DevExpress.Utils.FilesHelper.FindingFileName(Application.StartupPath, "Data\nwind.mdb")
			If DBFileName <> "" Then
				Dim ds As New DataSet()
				Dim con As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & DBFileName

				Dim dbAdapter As New System.Data.OleDb.OleDbDataAdapter("SELECT * FROM [Order Details]", con)
				dbAdapter.Fill(ds, "Order Details")
				dbAdapter = New System.Data.OleDb.OleDbDataAdapter("SELECT * FROM Products", con)
				dbAdapter.Fill(ds, "Products")
				Dim dvm As New DataViewManager(ds)

				dvMain = dvm.CreateDataView(ds.Tables("Order Details"))
				dvProducts = dvm.CreateDataView(ds.Tables("Products"))
			End If
		End Sub
		'</dataNavigator1>
		' </lookUpEdit1>

		' <lookUpEdit3>
		Private records() As Record = Nothing
		Private Sub InitArrayData()
			records = New Record(TutorialHelper.Countries.Length - 1){}
			For i As Integer = 0 To TutorialHelper.Countries.Length - 1
				records(i) = New Record(StringPainter.Default.RemoveFormat(TutorialHelper.Countries(i)))
			Next i
		End Sub
		' </lookUpEdit3>

		Private Sub InitLookUp()
			'data binding
			' <lookUpEdit1>
			lookUpEdit1.DataBindings.Add("EditValue", dvMain, "ProductID")
			lookUpEdit1.Properties.DataSource = dvProducts
			' </lookUpEdit1>
			'<dataNavigator1>
			dataNavigator1.DataSource = dvMain
			'</dataNavigator1>
			'simple binding
			' <lookUpEdit2>
			lookUpEdit2.Properties.DataSource = ContactList.GetContacts()
			lookUpEdit2.EditValue = "2"
			' </lookUpEdit2>
			'array list
			' <lookUpEdit3>
			lookUpEdit3.Properties.ValueMember = "Country"
			lookUpEdit3.Properties.DisplayMember = "Country"
			lookUpEdit3.Properties.DataSource = records
			lookUpEdit3.Properties.PopulateColumns()
			lookUpEdit3.EditValue = records(0).Country
			' </lookUpEdit3>
			'not in list
			' <lookUpEdit4>
			lookUpEdit4.Properties.DataSource = records
			lookUpEdit4.EditValue = records(0).Country
			AddHandler lookUpEdit4.Properties.GetNotInListValue, AddressOf GetNotInListValue
			' </lookUpEdit4>
		End Sub

		' <lookUpEdit4>
		Private Sub GetNotInListValue(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.GetNotInListValueEventArgs)
			e.Value = (e.RecordIndex + 1).ToString() & "."
		End Sub
		' </lookUpEdit4>

		Private Sub xtraTabControl1_SelectedPageChanged(ByVal sender As Object, ByVal e As DevExpress.XtraTab.TabPageChangedEventArgs) Handles xtraTabControl1.SelectedPageChanged
			InitValues()
		End Sub
	End Class
End Namespace

