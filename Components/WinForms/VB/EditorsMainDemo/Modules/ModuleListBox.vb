Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports DevExpress.Tutorials
Imports System.Windows.Forms
' <imageListBoxControlSample>
Imports DevExpress.XtraEditors
' </imageListBoxControlSample>

Namespace DevExpress.XtraEditors.Demos
	Partial Public Class ModuleListBox
		Inherits TutorialControl

		Public Sub New()
			InitializeComponent()
            InitListBox()
            InitValues()
            TutorialInfo.WhatsThisCodeFile = "VB\EditorsMainDemo\Modules\ModuleListBox.vb;VB\EditorsMainDemo\Modules\ListBoxProperties.vb"
			TutorialInfo.WhatsThisXMLFile = "listbox.xml"
        End Sub
        Private scaleFactor As SizeF = New SizeF(1.0F, 1.0F)
        Protected Overrides Sub ScaleControl(factor As SizeF, specified As BoundsSpecified)
            MyBase.ScaleControl(factor, specified)
            Me.scaleFactor = factor
        End Sub

		Protected Overrides ReadOnly Property AllowCenterControls() As Boolean
			Get
				Return False
			End Get
		End Property
		Private properties As ListBoxProperties = Nothing

        Private ReadOnly Property CurrentListBox() As BaseListBoxControl
            Get
                Select Case xtraTabControl1.SelectedTabPageIndex
                    Case 1
                        Return checkedListBoxControlSample
                    Case 2
                        Return imageListBoxControlSample
                End Select
                Return listBoxControlSample
            End Get
        End Property


		Private Sub InitValues()
			If properties Is Nothing Then
				properties = New ListBoxProperties(CurrentListBox)
				TurnSearch(True)
				AddHandler properties.SearchControlPropertyChanged, AddressOf properties_SearchControlPropertyChanged
				properties.Dock = DockStyle.Fill
				xtraTabPage5.Controls.Add(properties)
			Else
				properties.InitListBox(CurrentListBox)
			End If
		End Sub

		Private Sub properties_SearchControlPropertyChanged(ByVal sender As Object, ByVal e As PropertyChangedEventArgs)
			Dim args As PropertyValueChangedEventArgs = TryCast(e, PropertyValueChangedEventArgs)
			Select Case args.PropertyName
				Case "AllowAutoApply"
					' <ceAllowAutoApply>
					searchControlSample.Properties.AllowAutoApply = CBool(args.Value)
					' </ceAllowAutoApply>
					Return
				Case "ShowSearchButton"
					' <ceShowSearchButton>
					searchControlSample.Properties.ShowSearchButton = CBool(args.Value)
					' </ceShowSearchButton>
					Return
				Case "ShowClearButton"
					' <ceShowClearButton>
					searchControlSample.Properties.ShowClearButton = CBool(args.Value)
					' </ceShowClearButton>
					Return
                Case "ShowMRUButton"
                    ' <ceShowMRUButton>
                    searchControlSample.Properties.ShowMRUButton = CBool(args.Value)
                    ' </ceShowMRUButton>
                    Return
                Case "FindDelay"
                    ' <tbFindDelay>
                    searchControlSample.Properties.FindDelay = CInt(Fix(args.Value))
                    ' </tbFindDelay>
                    Return
                Case "FilterCondition"
                    ' <cbFilterCondition>
                    searchControlSample.Properties.FilterCondition = CType(args.Value, DevExpress.Data.Filtering.FilterCondition)
                    ' </cbFilterCondition>
                    Return
                Case "ShowDefaultButtonsMode"
                    ' <cbShowDefaultButtonsMode>
                    searchControlSample.Properties.ShowDefaultButtonsMode = CType(args.Value, Repository.ShowDefaultButtonsMode)
                    ' <cbShowDefaultButtonsMode>
                Case "TurnSearch"
                    splitContainerControl.PanelVisibility = If(CBool(args.Value), SplitPanelVisibility.Both, SplitPanelVisibility.Panel2)
                    ' <searchControlSample>
                    TurnSearch(CBool(args.Value))
                    ' </searchControlSample>
                    Return
            End Select
		End Sub
		' <searchControlSample>
		Private Sub TurnSearch(ByVal allowSearch As Boolean)
			Dim listBoxControl As ListBoxControl = TryCast(CurrentListBox, ListBoxControl)
			If allowSearch AndAlso listBoxControl IsNot Nothing Then
				searchControlSample.Client = listBoxControl
			Else
				searchControlSample.Client = Nothing
			End If
		End Sub
		' </searchControlSample>        

		Private Sub InitListBox()
			listBoxControlSample.DataSource = TutorialHelper.Countries
			'
			' <checkedListBoxControlSample>
			checkedListBoxControlSample.DataSource = GetData()
			If checkedListBoxControlSample.DataSource IsNot Nothing Then
				checkedListBoxControlSample.DisplayMember = "ProductName"
				checkedListBoxControlSample.ValueMember = "Discontinued"
				Dim i As Integer = 0
				Do While checkedListBoxControlSample.GetItem(i) IsNot Nothing
					checkedListBoxControlSample.SetItemCheckState(i, (If(True.Equals(checkedListBoxControlSample.GetItemValue(i)), CheckState.Unchecked, CheckState.Checked)))
					i += 1
				Loop
			End If
			' </checkedListBoxControlSample>
            '
            Dim imageSize As Size = New Size(Convert.ToInt32(25 * scaleFactor.Width), Convert.ToInt32(16 * scaleFactor.Height))
            DevExpress.Tutorials.TutorialHelper.InitFont(imageListBoxControlSample, imageSize)
			imageListBoxControlSample.SelectedIndex = 0
		End Sub

		' <checkedListBoxControlSample>
		Private Function GetData() As DataTable
			Dim DBFileName As String = DevExpress.Utils.FilesHelper.FindingFileName(Application.StartupPath, "Data\nwind.mdb")
			If DBFileName <> "" Then
				Dim ds As New DataSet()
				Dim con As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & DBFileName

				Dim dbAdapter As New System.Data.OleDb.OleDbDataAdapter("SELECT * FROM Products", con)
				dbAdapter.Fill(ds, "Products")
				Return ds.Tables("Products")
			End If
			Return Nothing
		End Function
		' </checkedListBoxControlSample>


		Private Sub xtraTabControl1_SelectedPageChanged(ByVal sender As Object, ByVal e As DevExpress.XtraTab.TabPageChangedEventArgs) Handles xtraTabControl1.SelectedPageChanged
			InitValues()
		End Sub

		' <ceCustomDraw>
		Private Sub checkedListBoxControlSample_DrawItem(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.ListBoxDrawItemEventArgs) Handles checkedListBoxControlSample.DrawItem
			If Not ceCustomDraw.Checked Then
				Return
			End If
			If checkedListBoxControlSample.GetItemChecked(e.Index) Then
				Return
			End If
			e.Appearance.Font = New Font(e.Appearance.Font, FontStyle.Strikeout)
		End Sub

		Private Sub ceCustomDraw_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ceCustomDraw.CheckedChanged
			checkedListBoxControlSample.Refresh()
		End Sub
		' </ceCustomDraw>

		' <imageListBoxControlSample>
		Private Sub imageListBoxControlSample_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles imageListBoxControlSample.SelectedIndexChanged
			Dim ilb As ImageListBoxControl = TryCast(sender, ImageListBoxControl)
			Dim fontName As Object = ilb.SelectedValue
			lbSample.Visible = fontName IsNot Nothing
			If fontName Is Nothing Then
				Return
			End If
			lbSample.Font = New Font(fontName.ToString(), 12)
		End Sub
		' </imageListBoxControlSample>

		' <seInvert>
		Private Sub seInvert_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles seInvert.Click
			checkedListBoxControlSample.BeginUpdate()
			Try
				Dim i As Integer = 0
				Do While checkedListBoxControlSample.GetItem(i) IsNot Nothing
					checkedListBoxControlSample.SetItemCheckState(i, (If(checkedListBoxControlSample.GetItemChecked(i), CheckState.Unchecked, CheckState.Checked)))
					i += 1
				Loop
			Finally
				checkedListBoxControlSample.EndUpdate()
			End Try
		End Sub
		' </seInvert>
	End Class
End Namespace

