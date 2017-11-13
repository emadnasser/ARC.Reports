Imports Microsoft.VisualBasic
Imports System.Collections.Generic
Imports System.IO
Imports System.Windows.Forms
Imports DevExpress.XtraBars.Docking2010.Views
Imports DevExpress.XtraBars.Helpers
Imports DevExpress.XtraSplashScreen

Namespace DevExpress.XtraBars.Demos.DockingDemo
	Partial Public Class frmMain
		Inherits DevExpress.XtraEditors.XtraForm
		Private fileStreams As List(Of Stream)
        Public Sub New()
            DevExpress.Utils.About.UAlgo.Default.DoEventObject(DevExpress.Utils.About.UAlgo.kDemo, DevExpress.Utils.About.UAlgo.pWinForms, Me) 'DEMO_REMOVE
            InitializeComponent()
            Icon = DevExpress.Utils.ResourceImageHelper.CreateIconFromResourcesEx("Resources.AppIcon.ico", GetType(frmMain).Assembly)
        End Sub
		Private Sub frmMain_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
			Me.fileStreams = Program.CreateResourceStreams()
			ucSolutionExplorer.InitTreeView(treeView1)
			SkinHelper.InitSkinPopupMenu(iPaintStyle)
			BeginInvoke(New MethodInvoker(AddressOf InitDemo))
        End Sub
        Private Sub barManager1_Merge(ByVal sender As Object, ByVal e As BarManagerMergeEventArgs) Handles barManager.Merge
            barManager.Bars("Edit").Merge(e.ChildManager.Bars("Edit"))
        End Sub
        Private Sub barManager1_UnMerge(ByVal sender As Object, ByVal e As BarManagerMergeEventArgs) Handles barManager.UnMerge
            barManager.Bars("Edit").UnMerge()
        End Sub
        Private Sub InitDemo()
            AddNewDocument("File.cs")
            DevExpress.Demos.ClassViewer.AddClassInfo(treeView1, Me.GetType(), New Object() {Me, New ucSolutionExplorer()})
            SplashScreenManager.HideImage(1000, Me)
        End Sub
        Private fileIndex As Integer = 0
        Private Sub AddNewDocument(ByVal fileName As String)
            fileStreams(fileIndex).Seek(0, SeekOrigin.Begin)
            AddNewDocument(fileName, fileStreams(fileIndex))
            fileIndex = (fileIndex + 1) Mod 3
        End Sub
        Private Sub AddNewDocument(ByVal fileName As String, ByVal content As Stream)
            tabbedView.BeginUpdate()
            Dim control As ucCodeEditor = New ucCodeEditor()
            control.Name = fileName
            control.Text = fileName
            Dim document As BaseDocument = tabbedView.AddDocument(control)
            document.Image = fileTypeImages.Images(10)
            document.Footer = Directory.GetCurrentDirectory()
            control.LoadCode(content)
            tabbedView.EndUpdate()
            tabbedView.Controller.Activate(document)
        End Sub
        Private Sub repositoryItemComboBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles repositoryItemComboBox1.KeyDown
            If e.KeyCode = Keys.Enter AndAlso eFind.EditValue IsNot Nothing Then
                repositoryItemComboBox1.Items.Add(eFind.EditValue.ToString())
            End If
        End Sub
        Private projectIndex As Integer = 0
        Private Sub iNewItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles iFile.ItemClick, iProject.ItemClick, iBlankSolution.ItemClick, iNewProject.ItemClick, iNew.ItemClick
            projectIndex += 1
            AddNewDocument(String.Format("File{0}.cs", projectIndex))
        End Sub
        Private Sub iAbout_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles iAbout.ItemClick
            BarManager.About()
        End Sub
        Private Sub iSolutionExplorer_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles iSolutionExplorer.ItemClick
			dockPanel1.Show()
		End Sub
		Private Sub iProperties_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles iProperties.ItemClick
			dockPanel2.Show()
		End Sub
		Private Sub iTaskList_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles iTaskList.ItemClick
			dockPanel3.Show()
		End Sub
		Private Sub iFindResults_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles iFindResults.ItemClick
			dockPanel4.Show()
		End Sub
		Private Sub iOutput_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles iOutput.ItemClick
			dockPanel5.Show()
		End Sub
		Private Sub iToolbox_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles iToolbox.ItemClick
			dockPanel6.Show()
		End Sub
		Private Sub solutionExplorer_PropertiesItemClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles solutionExplorer.PropertiesItemClick
			dockPanel2.Show()
		End Sub
		Private Sub solutionExplorer_TreeViewItemClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles solutionExplorer.TreeViewItemClick
			Dim treeView As DevExpress.XtraTreeList.TreeList = TryCast(sender, DevExpress.XtraTreeList.TreeList)
			Dim fileName As String = treeView.FocusedNode.GetDisplayText(0).Replace(".cs", String.Empty)
			For Each document As BaseDocument In tabbedView.Documents
				If document.Caption = (fileName & ".cs") Then
					tabbedView.Controller.Activate(document)
					Return
				End If
			Next document
			Using stream As Stream = Program.GetDocumentStream(fileName)
				If stream IsNot Nothing Then
					AddNewDocument(fileName & ".cs", stream)
				End If
			End Using
		End Sub
		Private Sub iSaveLayout_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles iSaveLayout.ItemClick
			Using dlg As SaveFileDialog = New SaveFileDialog()
				dlg.Filter = "XML files (*.xml)|*.xml"
				dlg.Title = "Save Layout"
				If dlg.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
					Refresh(True)
					barManager.SaveToXml(dlg.FileName)
					Refresh(False)
				End If
			End Using
		End Sub
		Private Sub iLoadLayout_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles iLoadLayout.ItemClick
			Using dlg As OpenFileDialog = New OpenFileDialog()
				dlg.Filter = "XML files (*.xml)|*.xml|All files|*.*"
				dlg.Title = "Restore Layout"
				If dlg.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
					Refresh(True)
					Try
						barManager.RestoreFromXml(dlg.FileName)
						SkinHelper.InitSkinPopupMenu(iPaintStyle)
					Catch
					End Try
					Refresh(False)
				End If
			End Using
		End Sub
		Private currentCursor As Cursor
        Private Overloads Sub Refresh(ByVal isWait As Boolean)
            If isWait Then
                currentCursor = Cursor.Current
                Cursor.Current = Cursors.WaitCursor
            Else
                Cursor.Current = currentCursor
            End If
            Me.Refresh()
        End Sub
        Private Sub iExit_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles iExit.ItemClick
            Me.Close()
        End Sub
    End Class
End Namespace
