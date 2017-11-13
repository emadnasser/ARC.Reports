Namespace DevExpress.XtraGrid.Demos
    Partial Public Class ConditionsEditor
        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing Then
                If components IsNot Nothing Then
                    components.Dispose()
                End If
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(ConditionsEditor))
            Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
            Me.sbRemove = New DevExpress.XtraEditors.SimpleButton()
            Me.panelControl3 = New DevExpress.XtraEditors.PanelControl()
            Me.sbAdd = New DevExpress.XtraEditors.SimpleButton()
            Me.panelControl2 = New DevExpress.XtraEditors.PanelControl()
            Me.FormatItemList = New DevExpress.XtraEditors.ListBoxControl()
            Me.splitter1 = New DevExpress.XtraEditors.SplitterControl()
            Me.conditionsItem1 = New DevExpress.XtraGrid.Demos.ConditionsItem()
            CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl1.SuspendLayout()
            CType(Me.panelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.panelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl2.SuspendLayout()
            CType(Me.FormatItemList, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' panelControl1
            ' 
            Me.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.panelControl1.Controls.Add(Me.sbRemove)
            Me.panelControl1.Controls.Add(Me.panelControl3)
            Me.panelControl1.Controls.Add(Me.sbAdd)
            resources.ApplyResources(Me.panelControl1, "panelControl1")
            Me.panelControl1.Name = "panelControl1"
            ' 
            ' sbRemove
            ' 
            resources.ApplyResources(Me.sbRemove, "sbRemove")
            Me.sbRemove.Name = "sbRemove"
            ' 
            ' panelControl3
            ' 
            Me.panelControl3.Appearance.BackColor = (CType(resources.GetObject("panelControl3.Appearance.BackColor"), System.Drawing.Color))
            Me.panelControl3.Appearance.Options.UseBackColor = True
            Me.panelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            resources.ApplyResources(Me.panelControl3, "panelControl3")
            Me.panelControl3.Name = "panelControl3"
            ' 
            ' sbAdd
            ' 
            resources.ApplyResources(Me.sbAdd, "sbAdd")
            Me.sbAdd.Name = "sbAdd"
            ' 
            ' panelControl2
            ' 
            Me.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.panelControl2.Controls.Add(Me.conditionsItem1)
            resources.ApplyResources(Me.panelControl2, "panelControl2")
            Me.panelControl2.Name = "panelControl2"
            ' 
            ' FormatItemList
            ' 
            resources.ApplyResources(Me.FormatItemList, "FormatItemList")
            Me.FormatItemList.ItemHeight = 16
            Me.FormatItemList.Name = "FormatItemList"
            ' 
            ' splitter1
            ' 
            resources.ApplyResources(Me.splitter1, "splitter1")
            Me.splitter1.Name = "splitter1"
            Me.splitter1.TabStop = False
            ' 
            ' conditionsItem1
            ' 
            Me.conditionsItem1.BackColor = System.Drawing.Color.Transparent
            resources.ApplyResources(Me.conditionsItem1, "conditionsItem1")
            Me.conditionsItem1.Name = "conditionsItem1"
            ' 
            ' ConditionsEditor
            ' 
            resources.ApplyResources(Me, "$this")
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.panelControl2)
            Me.Controls.Add(Me.splitter1)
            Me.Controls.Add(Me.FormatItemList)
            Me.Controls.Add(Me.panelControl1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
            Me.KeyPreview = True
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "ConditionsEditor"
            Me.ShowInTaskbar = False
            CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl1.ResumeLayout(False)
            CType(Me.panelControl3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.panelControl2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl2.ResumeLayout(False)
            CType(Me.FormatItemList, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region
        Private panelControl1 As DevExpress.XtraEditors.PanelControl
        Private panelControl2 As DevExpress.XtraEditors.PanelControl
        Private WithEvents sbAdd As DevExpress.XtraEditors.SimpleButton
        Private WithEvents sbRemove As DevExpress.XtraEditors.SimpleButton
        Private splitter1 As DevExpress.XtraEditors.SplitterControl
        Private components As System.ComponentModel.Container = Nothing
        Private WithEvents FormatItemList As DevExpress.XtraEditors.ListBoxControl
        Private panelControl3 As DevExpress.XtraEditors.PanelControl
        Private WithEvents conditionsItem1 As ConditionsItem
    End Class
End Namespace
