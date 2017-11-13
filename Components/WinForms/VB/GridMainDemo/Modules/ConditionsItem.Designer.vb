Namespace DevExpress.XtraGrid.Demos
    Partial Public Class ConditionsItem
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
            Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(ConditionsItem))
            Me.label1 = New System.Windows.Forms.Label()
            Me.icbCondition = New DevExpress.XtraEditors.ImageComboBoxEdit()
            Me.lbVal1 = New System.Windows.Forms.Label()
            Me.lbVal2 = New System.Windows.Forms.Label()
            Me.ceRow = New DevExpress.XtraEditors.CheckEdit()
            Me.label4 = New System.Windows.Forms.Label()
            Me.propertyGrid1 = New DevExpress.DXperience.Demos.XtraPropertyGrid()
            CType(Me.icbCondition.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ceRow.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' label1
            ' 
            resources.ApplyResources(Me.label1, "label1")
            Me.label1.Name = "label1"
            ' 
            ' icbCondition
            ' 
            resources.ApplyResources(Me.icbCondition, "icbCondition")
            Me.icbCondition.Name = "icbCondition"
            Me.icbCondition.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton((CType(resources.GetObject("icbCondition.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines)))})
            Me.icbCondition.Properties.DropDownRows = 10
            ' 
            ' lbVal1
            ' 
            resources.ApplyResources(Me.lbVal1, "lbVal1")
            Me.lbVal1.Name = "lbVal1"
            ' 
            ' lbVal2
            ' 
            resources.ApplyResources(Me.lbVal2, "lbVal2")
            Me.lbVal2.Name = "lbVal2"
            ' 
            ' ceRow
            ' 
            resources.ApplyResources(Me.ceRow, "ceRow")
            Me.ceRow.Name = "ceRow"
            Me.ceRow.Properties.Caption = resources.GetString("ceRow.Properties.Caption")
            ' 
            ' label4
            ' 
            resources.ApplyResources(Me.label4, "label4")
            Me.label4.Name = "label4"
            ' 
            ' propertyGrid1
            ' 
            resources.ApplyResources(Me.propertyGrid1, "propertyGrid1")
            Me.propertyGrid1.Name = "propertyGrid1"
            ' 
            ' ConditionsItem
            ' 
            resources.ApplyResources(Me, "$this")
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.propertyGrid1)
            Me.Controls.Add(Me.label4)
            Me.Controls.Add(Me.ceRow)
            Me.Controls.Add(Me.lbVal2)
            Me.Controls.Add(Me.lbVal1)
            Me.Controls.Add(Me.icbCondition)
            Me.Controls.Add(Me.label1)
            Me.Name = "ConditionsItem"
            CType(Me.icbCondition.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ceRow.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region
        Private label1 As System.Windows.Forms.Label
        Private WithEvents icbCondition As DevExpress.XtraEditors.ImageComboBoxEdit
        Private WithEvents ceRow As DevExpress.XtraEditors.CheckEdit
        Private label4 As System.Windows.Forms.Label
        Private propertyGrid1 As DevExpress.DXperience.Demos.XtraPropertyGrid
        Private lbVal1 As System.Windows.Forms.Label
        Private lbVal2 As System.Windows.Forms.Label
        Private components As System.ComponentModel.Container = Nothing
    End Class
End Namespace
