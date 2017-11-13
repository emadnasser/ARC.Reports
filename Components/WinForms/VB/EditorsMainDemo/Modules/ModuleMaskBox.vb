Imports System.Collections
Imports System.ComponentModel
Imports DevExpress.Tutorials


Namespace DevExpress.XtraEditors.Demos
	Partial Public Class ModuleMaskBox
		Inherits TutorialControl

		Public Sub New()
            InitializeComponent()
            InitValues()
            TutorialInfo.WhatsThisCodeFile = "VB\EditorsMainDemo\Modules\MaskProperties.vb"
            TutorialInfo.WhatsThisXMLFile = "maskbox.xml"
		End Sub
		Protected Overrides ReadOnly Property AllowCenterControls() As Boolean
			Get
				Return False
			End Get
		End Property
		Private imageDescription() As String = { "Phone", "Date", "Long Time", "Short Time", "Extension", "Social Security", "Long Zip Code", "Short Zip Code" }
		Private properties As MaskProperties = Nothing
		Private activeEditor As DevExpress.XtraEditors.TextEdit = Nothing
        Private _font As Font = DevExpress.Utils.AppearanceObject.DefaultFont
        Private boldFont As New Font(DevExpress.Utils.AppearanceObject.DefaultFont, FontStyle.Bold)

        Private Sub ModuleMaskBox_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
            InitEditors()
            SelectObject(Nothing, EventArgs.Empty)
        End Sub


        Private Sub InitValues()
            If properties Is Nothing Then
                properties = New MaskProperties(activeEditor)
                properties.Dock = DockStyle.Fill
                AddHandler properties.PropertyValueChanged, AddressOf maskProperties_PropertyValueChanged
                xtraTabPage5.Controls.Add(properties)
            Else
                properties.InitMask(activeEditor)
            End If
        End Sub

        Private ReadOnly Property CurrentProperties() As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
            Get
                Return If(properties Is Nothing, Nothing, properties.ActiveProperties)
            End Get
        End Property

        Private Sub InitEditors()
            For i As Integer = 0 To xtcMain.TabPages.Count - 1
                For Each ctrl As Control In xtcMain.TabPages(i).Controls
                    Dim te As DevExpress.XtraEditors.TextEdit = TryCast(ctrl, DevExpress.XtraEditors.TextEdit)
                    If te IsNot Nothing Then
                        AddHandler te.Enter, AddressOf SelectObject
                        AddHandler te.EditValueChanged, AddressOf maskEditBox_ValueChanged
                        te.Properties.ValidateOnEnterKey = True
                        If te.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime Then
                            te.EditValue = Date.Now
                        End If
                    End If
                Next ctrl
            Next i
        End Sub

        Private Sub maskEditBox_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim te As DevExpress.XtraEditors.TextEdit = TryCast(sender, DevExpress.XtraEditors.TextEdit)
            If te IsNot Nothing AndAlso te.EditValue IsNot Nothing Then
                editValueBox.Text = te.EditValue.ToString()
            Else
                editValueBox.Text = ""
            End If
        End Sub

        Private Sub SelectObject(ByVal sender As Object, ByVal e As System.EventArgs)
            Dim te As DevExpress.XtraEditors.TextEdit = TryCast(sender, DevExpress.XtraEditors.TextEdit)
            editValueBox.Text = ""
            activeEditor = Nothing
            If te IsNot Nothing Then
                If te.EditValue IsNot Nothing Then
                    editValueBox.Text = te.EditValue.ToString()
                End If
                activeEditor = te
            End If
            InitValues()
            xtcMain.SelectedTabPage.Invalidate()
        End Sub


        Private Sub maskProperties_PropertyValueChanged(ByVal s As Object, ByVal e As EventArgs)
            editValueBox.Text = ""
            If activeEditor IsNot Nothing Then
                activeEditor.EditValue = ""
            End If
        End Sub

        Private Function ImageByString(ByVal s As String) As Image
            For i As Integer = 0 To imageDescription.Length - 1
                If s.IndexOf(imageDescription(i)) = 0 Then
                    Return imageList2.Images(i)
                End If
            Next i
            Return Nothing
        End Function

        Private Sub xtp_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles xtpNumeric.Paint, xtpDateTime.Paint, xtpRegEx.Paint, xtpSimple.Paint, xtpRegular.Paint
            For Each ctrl As Control In CType(sender, Control).Controls
                If TypeOf ctrl Is DevExpress.XtraEditors.TextEdit Then
                    Dim f As Font = If(CType(ctrl, DevExpress.XtraEditors.TextEdit).Properties Is CurrentProperties, boldFont, _font)
                    Dim controlTextColor As Color = DevExpress.LookAndFeel.LookAndFeelHelper.GetSystemColor(LookAndFeel.ActiveLookAndFeel, SystemColors.ControlText)
                    Using brush As New SolidBrush(controlTextColor)
                        e.Graphics.DrawString(ctrl.Tag.ToString(), f, brush, ctrl.Left, (ctrl.Top - f.Height - 2))
                    End Using
                    If ctrl.Tag IsNot Nothing Then
                        Dim image As Image = ImageByString(ctrl.Tag.ToString())
                        If image IsNot Nothing Then
                            e.Graphics.DrawImage(image, ctrl.Left - image.Width - 4, ctrl.Top + (ctrl.Height - image.Height) \ 2)
                        End If
                    End If
                End If
            Next ctrl
        End Sub
	End Class
End Namespace

