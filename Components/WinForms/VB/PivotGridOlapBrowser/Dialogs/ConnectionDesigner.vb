Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraPivotGrid.Data
Imports DevExpress.Utils
Imports System.IO
Imports DevExpress.XtraPivotGrid
Imports DevExpress.XtraEditors

Namespace PivotGridOlapBrowser.Dialogs
	Partial Public Class ConnectionDesigner
		Inherits XtraForm
		Private Shared sampleFileName_Renamed As String
		Private Shared Function GetNorthwindFileName() As String
			Return "Data\Northwind.cub"
		End Function

		Private ReadOnly metaGetter As AdomdMetaGetter
		Private ReadOnly connections As ExistingConnections

		Public Sub New()
			InitializeComponent()
			Me.metaGetter = New AdomdMetaGetter()
			UpdateControls()
			buttonSample.Visible = Not String.IsNullOrEmpty(SampleFileName)
			Me.connections = New ExistingConnections()
			Me.connections.FillList(existingList, False)
			If existingList.Items.Count > 0 Then
				chkExisting.Checked = True
				existingList.Focus()
				existingList.SelectedIndex = 0
			Else
				chkNew.Checked = True
				radioServer.Focus()
				ShowHideConnections(False)
			End If
		End Sub
		Private Sub ShowHideConnections(ByVal show As Boolean)
			If chkExisting.Enabled = show Then
				Return
			End If
			chkExisting.Enabled = show
			existingList.Visible = show
			Dim sign As Integer = If(show, +1, -1)
			For Each control As Control In Controls
				If control Is existingList OrElse TypeOf control Is SimpleButton Then
					Continue For
				End If
				If control.Top > existingList.Top Then
					control.Top += sign * (existingList.Height + 16)
				End If
			Next control
			Height += sign * (existingList.Height + 16)
		End Sub

		Public ReadOnly Property ConnectionString() As String
			Get
				If chkNew.Checked Then
					Return "Provider=msolap;Data Source=" & editServer.Text & ";Initial Catalog=" & CStr(listCatalog.EditValue) & ";Cube Name=" & CStr(listCube.EditValue)
				Else
					Return CStr(existingList.SelectedItem)
				End If
			End Get
		End Property
		Public Shared ReadOnly Property SampleConnectionString() As String
			Get
				If String.IsNullOrEmpty(SampleFileName) Then
					Return Nothing
				End If
				Return "Provider=msolap;Data Source=" & SampleFileName & ";Initial Catalog=Northwind;Cube Name=Northwind"
			End Get
		End Property
		Protected Shared ReadOnly Property SampleFileName() As String
			Get
				If String.IsNullOrEmpty(sampleFileName_Renamed) Then
					sampleFileName_Renamed = Path.GetFullPath(FilesHelper.FindingFileName(Application.StartupPath, GetNorthwindFileName()))
                    If File.Exists(sampleFileName_Renamed) Then
                        Try
                            File.SetAttributes(sampleFileName_Renamed, FileAttributes.Normal)
                        Catch
                        End Try
                    End If
				End If
				Return sampleFileName_Renamed
			End Get
		End Property

		Protected Overrides Sub OnClosing(ByVal e As CancelEventArgs)
			MyBase.OnClosing(e)
			Me.metaGetter.Dispose()
		End Sub

		Private Sub radioButton_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles radioFile.CheckedChanged, radioServer.CheckedChanged
			UpdateControls()
		End Sub

		Private wasServer As Boolean = True
		Private serverName, fileName As String
		Private Sub UpdateControls()
			If wasServer Then
				serverName = editServer.Text
			Else
				fileName = editServer.Text
			End If

			Dim useServer As Boolean = radioServer.Checked
			editServer.Properties.Buttons(0).Visible = Not useServer
			editServer.Text = If(useServer, serverName, fileName)
			labelServer.Text = If(useServer, "Server", "File")
			listCatalog.Enabled = useServer
			labelCatalog.Enabled = useServer
			listCube.Enabled = useServer
			labelCube.Enabled = useServer
			wasServer = useServer
		End Sub

		Private Sub editServer_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles editServer.ButtonClick
			Using dialog As New OpenFileDialog()
				dialog.Filter = "Cube files (*.cub)|*.cub"
				If dialog.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
					OpenCubeFile(dialog.FileName)
				End If
			End Using
		End Sub

		Private Function OpenCubeFile(ByVal fileName As String) As Boolean
			Return OpenCubeFile(fileName, True)
		End Function
		Private Function OpenCubeFile(ByVal fileName As String, ByVal showBalloons As Boolean) As Boolean
			Try
				editServer.Text = fileName
				metaGetter.ConnectionString = "Provider=msolap;Data Source=" & editServer.Text
				If (Not metaGetter.Connected) Then
					If showBalloons Then
						ShowBalloon("Invalid cube file.", "Error", editServer)
					End If
					Return False
				End If
				Dim catalogs As List(Of String) = metaGetter.GetCatalogs()
				If catalogs Is Nothing OrElse catalogs.Count = 0 Then
					If showBalloons Then
						ShowBalloon("There is no catalogs in the cube file.", "Error", editServer)
					End If
					Return False
				End If
				listCatalog.EditValue = catalogs(0)
				Dim cubes As List(Of String) = metaGetter.GetCubes(catalogs(0))
				If cubes Is Nothing OrElse cubes.Count = 0 Then
					If showBalloons Then
						ShowBalloon("There is no cubes in the cube file.", "Error", editServer)
					End If
					Return False
				End If
				listCube.EditValue = cubes(0)
				Return True
			Finally
				metaGetter.Connected = False
			End Try
		End Function

		Private Sub ShowBalloon(ByVal text As String, ByVal caption As String, ByVal control As Control)
			Dim eShow As ToolTipControllerShowEventArgs = toolTipController1.CreateShowArgs()
			eShow.ToolTip = text
			eShow.Title = caption
			eShow.IconType = ToolTipIconType.Error
			eShow.IconSize = ToolTipIconSize.Small
			toolTipController1.ShowHint(eShow, control)
		End Sub

		Private Sub listCatalog_QueryPopUp(ByVal sender As Object, ByVal e As CancelEventArgs) Handles listCatalog.QueryPopUp
			If (Not String.IsNullOrEmpty(editServer.Text)) Then
				metaGetter.ConnectionString = "Provider=msolap;Data Source=" & editServer.Text
				If (Not metaGetter.Connected) Then
					ShowBalloon("Couldn't connect to the server.", "Error", editServer)
				End If
				Dim catalogs As List(Of String) = metaGetter.GetCatalogs()
				If catalogs IsNot Nothing Then
					listCatalog.Properties.Items.Clear()
					listCatalog.Properties.Items.AddRange(catalogs)
					e.Cancel = False
				Else
					e.Cancel = True
				End If
			Else
				e.Cancel = True
			End If
		End Sub

		Private Sub listCube_QueryPopUp(ByVal sender As Object, ByVal e As CancelEventArgs) Handles listCube.QueryPopUp
			If (Not String.IsNullOrEmpty(editServer.Text)) Then
				metaGetter.ConnectionString = "Provider=msolap;Data Source=" & editServer.Text
				If (Not metaGetter.Connected) Then
					ShowBalloon("Couldn't connect to the server.", "Error", editServer)
					e.Cancel = True
					Return
				End If
				Dim catalogName As String = Nothing
				If (Not String.IsNullOrEmpty(CStr(listCatalog.EditValue))) Then
					catalogName = CStr(listCatalog.EditValue)
					metaGetter.ConnectionString &= ";Initial Catalog=" & catalogName
				End If
				If (Not metaGetter.Connected) Then
					ShowBalloon("Couldn't connect to the """ & catalogName & """ database.", "Error", listCatalog)
					e.Cancel = True
					Return
				End If
				Dim cubes As List(Of String) = metaGetter.GetCubes(catalogName)
				If cubes IsNot Nothing Then
					listCube.Properties.Items.Clear()
					If cubes.Count = 0 Then
						ShowBalloon("There are no cubes in the """ & catalogName & """ database.", "Error", listCube)
						e.Cancel = True
						Return
					End If
					listCube.Properties.Items.AddRange(cubes)
					e.Cancel = False
				Else
					e.Cancel = True
				End If
			Else
				e.Cancel = True
			End If
		End Sub

		Private Sub simpleButton1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles buttonSample.Click
			radioFile.Checked = True
			If OpenCubeFile(sampleFileName_Renamed) Then
				DialogResult = System.Windows.Forms.DialogResult.OK
			End If
		End Sub

		Private Sub buttonOK_Click(ByVal sender As Object, ByVal e As EventArgs) Handles buttonOK.Click
			If chkNew.Checked Then
				If radioServer.Checked Then
					ConnectToServer()
				Else
					ConnectToCubeFile()
				End If
			Else
				If String.IsNullOrEmpty(CStr(existingList.SelectedItem)) Then
					ShowBalloon("Please select connection string.", "Error", existingList)
					Return
				End If
				DialogResult = System.Windows.Forms.DialogResult.OK
			End If
		End Sub

		Private Sub ConnectToCubeFile()
			If String.IsNullOrEmpty(editServer.Text) OrElse String.IsNullOrEmpty(TryCast(listCatalog.EditValue, String)) OrElse String.IsNullOrEmpty(TryCast(listCube.EditValue, String)) Then
				Return
			End If
			AddConnectionString()
			DialogResult = System.Windows.Forms.DialogResult.OK
		End Sub
		Private Sub ConnectToServer()
			Dim server As String = If(radioServer.Checked, "server", "cube file")
			If String.IsNullOrEmpty(editServer.Text) Then
				ShowBalloon("Please specify the " & server & ".", "Error", editServer)
				Return
			End If
			metaGetter.ConnectionString = "Provider=msolap;Data Source=" & editServer.Text
			If (Not metaGetter.Connected) Then
				ShowBalloon("Couldn't connect to the " & server & ". Please check that it is correct.", "Error", editServer)
				Return
			End If
			Dim catalogName As String = CStr(listCatalog.EditValue)
			If (Not String.IsNullOrEmpty(catalogName)) Then
				metaGetter.ConnectionString &= ";Initial Catalog=" & catalogName
			Else
				ShowBalloon("Please specify the database name.", "Error", listCatalog)
				Return
			End If
			If (Not metaGetter.Connected) Then
				ShowBalloon("Couldn't connect to the """ & catalogName & """ database. Please check that it is correct.", "Error", listCatalog)
				Return
			End If
			Dim cubes As List(Of String) = metaGetter.GetCubes(catalogName)
			If cubes IsNot Nothing Then
				Dim cubeName As String = CStr(listCube.EditValue)
				If String.IsNullOrEmpty(cubeName) Then
					ShowBalloon("Please specify the cube name.", "Error", listCube)
					Return
				End If
				If (Not cubes.Contains(cubeName)) Then
					ShowBalloon("Couldn't connect to the """ & cubeName & """ cube. Please check that it is correct.", "Error", listCube)
					Return
				End If
			End If
			AddConnectionString()
			DialogResult = System.Windows.Forms.DialogResult.OK
		End Sub
		Private Sub AddConnectionString()
			Me.connections.Add(existingList, ConnectionString)
			ShowHideConnections(True)
		End Sub
		Private Sub listCatalog_SelectedValueChanged(ByVal sender As Object, ByVal e As EventArgs)
			listCube.EditValue = ""
		End Sub
		Private Sub editServer_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles editServer.EditValueChanged
			chkNew.Checked = True
		End Sub
		Private Sub listCatalog_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles listCatalog.EditValueChanged
			chkNew.Checked = True
		End Sub
		Private Sub listCube_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles listCube.EditValueChanged
			chkNew.Checked = True
		End Sub
		Private Sub radioServer_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles radioServer.EditValueChanged
			chkNew.Checked = True
		End Sub
	End Class

	Friend Class ExistingConnections
		Private fileName_Renamed As String
		Private ReadOnly Property FileName() As String
			Get
				If String.IsNullOrEmpty(fileName_Renamed) Then
					Const csFile As String = "connection_strings.txt"
					Using fs As FileStream = Me.GetType().Assembly.GetFiles()(0)
						Dim dir As String = Path.GetDirectoryName(fs.Name)
						fileName_Renamed = Path.Combine(dir, csFile)
					End Using
				End If
				Return fileName_Renamed
			End Get
		End Property

		Public Sub FillList(ByVal listBox As ListBoxControl, ByVal clearingRequired As Boolean)
			Dim list As List(Of String) = Load()
			If clearingRequired Then
				listBox.Items.Clear()
			End If
			listBox.Items.AddRange(list.ToArray())
		End Sub
		Public Sub Add(ByVal listBox As ListBoxControl, ByVal connectionString As String)
			If Add(connectionString) Then
				listBox.Items.Add(connectionString)
			End If
		End Sub
		Protected Function Add(ByVal connectionString As String) As Boolean
			Dim list As List(Of String) = Load()
			Dim notContains As Boolean = Not list.Contains(connectionString)
			If notContains Then
				list.Add(connectionString)
				Save(list)
			End If
			Return notContains
		End Function

		Private Function Load() As List(Of String)
			Dim list As New List(Of String)()
			If (Not File.Exists(FileName)) Then
				Return list
			End If
			Using reader As New StreamReader(FileName)
				Do While Not reader.EndOfStream
					Dim line As String = reader.ReadLine()
					list.Add(line)
				Loop
			End Using
			Return list
		End Function
		Private Sub Save(ByVal list As List(Of String))
			Using writer As New StreamWriter(FileName, False)
				For Each str As String In list
					writer.WriteLine(str)
				Next str
			End Using
		End Sub
	End Class
End Namespace

