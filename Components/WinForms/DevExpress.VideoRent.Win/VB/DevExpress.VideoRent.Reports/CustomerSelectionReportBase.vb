Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraReports.Parameters
Imports DevExpress.XtraEditors
Imports DevExpress.Xpo

Namespace DevExpress.VideoRent.Reports
	Partial Public Class CustomerSelectionReportBase
		Inherits ReportBase
		Private Const customerListParameterName As String = "customerListParameter"
        Private Shared _FindEditorParameterName As String
        Private Const separatorChar As Char = ";"c
		Private separatorString As String = New String(New Char() { separatorChar, " "c })
		Private isParameterInitialized As Boolean = False

		Public Sub New()
			InitializeComponent()
			Dim customerListParameter As New Parameter()
			customerListParameter.Name = customerListParameterName
			customerListParameter.Type = GetType(String)
			customerListParameter.Description = "Customers:"
			Parameters.Add(customerListParameter)
		End Sub

		Protected Overrides Sub OnParametersRequestBeforeShow(ByVal e As ParametersRequestEventArgs)
			MyBase.OnParametersRequestBeforeShow(e)

			For Each info As ParameterInfo In e.ParametersInformation
				If info.Parameter.Name = customerListParameterName Then
					info.Editor = CreateCheckedComboBoxEdit()
				End If
			Next info
			If (Not isParameterInitialized) AndAlso ((Not Object.Equals(xpCollectionCustomers.Session, Nothing))) Then
				Const customerLimit As Integer = 5
				Dim isFirstIteration As Boolean = True
				Dim customerCount As Integer = 0
				Dim customers As String = String.Empty
				For Each customer As Customer In xpCollectionCustomers
					If (Not isFirstIteration) Then
						customers &= separatorString
					Else
						isFirstIteration = False
					End If
					customers &= customer.FullNameLastSorting
                    If TypeOf Me Is CustomerFilmRentsListReport Then
                        customerCount = customerCount + 1
                        If customerCount = customerLimit - 1 Then
                            Exit For
                        End If
                    End If
				Next customer
				Parameters(customerListParameterName).Value = customers
				isParameterInitialized = True
				FilterString = GetFilterString()
			End If
		End Sub
		Private Function CreateCheckedComboBoxEdit() As CheckedComboBoxEdit
			Dim checkedComboBoxEdit As New CheckedComboBoxEdit()
			checkedComboBoxEdit.Properties.DataSource = xpCollectionCustomers
			checkedComboBoxEdit.Properties.DisplayMember = "FullNameLastSorting"
			checkedComboBoxEdit.Properties.SeparatorChar = separatorChar
			If Object.Equals(checkedComboBoxEdit.Properties.PopupControl, Nothing) Then
				Dim metodInfo As System.Reflection.MethodInfo = GetType(CheckedComboBoxEdit).GetMethod("CreatePopupCheckListControl", System.Reflection.BindingFlags.NonPublic Or System.Reflection.BindingFlags.Instance)
				checkedComboBoxEdit.Properties.PopupControl = TryCast(metodInfo.Invoke(checkedComboBoxEdit, Nothing), PopupContainerControl)
			End If
			checkedComboBoxEdit.Properties.PopupFormMinSize = New System.Drawing.Size(180, 390)
			checkedComboBoxEdit.Properties.PopupFormSize = checkedComboBoxEdit.Properties.PopupFormMinSize
			Return checkedComboBoxEdit
		End Function
		Protected Overrides Sub OnParametersRequestSubmit(ByVal e As ParametersRequestEventArgs)
			MyBase.OnParametersRequestSubmit(e)

			Dim editor As CheckedComboBoxEdit = FindEditor(customerListParameterName)
			If AreAllItemsChecked(editor) Then
				FilterString = String.Empty
				Return
			End If
			FilterString = GetFilterString()
		End Sub
        Private Function FindEditor(ByVal parameterName As String) As CheckedComboBoxEdit
            _FindEditorParameterName = parameterName
            Dim info As ParameterInfo = ReportPrintTool.ParametersInfo.Find(AddressOf GetInfo)
            Dim editor As CheckedComboBoxEdit = DirectCast(info.Editor, CheckedComboBoxEdit)
            Return editor
        End Function

        Private Shared Function GetInfo(ByVal info As ParameterInfo) As Boolean
            Return info.Parameter.Name = _FindEditorParameterName
        End Function

		Private Function GetFilterString() As String
			Dim value As String = TryCast(Parameters(customerListParameterName).Value, String)
			If String.IsNullOrEmpty(value) Then
				Return String.Empty
			End If
			Dim values() As String = value.Split(New String() { separatorString }, StringSplitOptions.None)
			If Object.Equals(values, Nothing) OrElse values.Length = 0 Then
				Return String.Empty
			End If
			Dim isFirstIteration As Boolean = True
			Dim filterBuffer As String = String.Empty
			For Each name As String In values
				If (Not isFirstIteration) Then
					filterBuffer &= " Or "
				End If
				Dim result As String = name.Replace("'", "''")
				filterBuffer &= String.Format("[FullNameLastSorting] = '{0}'", result)
				isFirstIteration = False
			Next name
			Return filterBuffer
		End Function
		Private Function AreAllItemsChecked(ByVal editor As CheckedComboBoxEdit) As Boolean
			If editor.Properties.Items.Count = 0 Then
				Return False
			End If
			For Each item As DevExpress.XtraEditors.Controls.CheckedListBoxItem In editor.Properties.Items
				If item.CheckState = System.Windows.Forms.CheckState.Unchecked Then
					Return False
				End If
			Next item
			Return True
		End Function
		Private Sub xpCollectionCustomers_ResolveSession(ByVal sender As Object, ByVal e As DevExpress.Xpo.ResolveSessionEventArgs) Handles xpCollectionCustomers.ResolveSession
			e.Session = Session
		End Sub
	End Class
End Namespace
