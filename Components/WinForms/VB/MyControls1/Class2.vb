Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports System.Reflection
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors.Registrator
Imports DevExpress.XtraEditors.Drawing
Imports DevExpress.XtraEditors.ViewInfo
Imports DevExpress.Utils

<UserRepositoryItem("RegisterMyFontEdit")> _
Public Class RepositoryItemMyFontEdit
    Inherits RepositoryItemImageComboBox
    Shared Sub New()
        RegisterMyFontEdit()
    End Sub

    Public Sub New()
        InitFontItems()
    End Sub

    Public Shared Sub RegisterMyFontEdit()
        Dim img As Image = CType(Bitmap.FromStream(System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream("DevExpress.CustomEditors.MyFontEdit.bmp")), Bitmap)
        EditorRegistrationInfo.Default.Editors.Add(New EditorClassInfo("MyFontEdit", GetType(MyFontEdit), GetType(RepositoryItemMyFontEdit), GetType(ImageComboBoxEditViewInfo), New ImageComboBoxEditPainter(), True, img, GetType(DevExpress.Accessibility.PopupEditAccessible)))
    End Sub

    Public Overrides ReadOnly Property EditorTypeName() As String
        Get
            Return "MyFontEdit"
        End Get
    End Property

    <Browsable(False), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)> _
          Public Overloads ReadOnly Property Items() As ImageComboBoxItemCollection
        Get
            Return MyBase.Items
        End Get
    End Property

    Private Sub AddDefaultButton(ByVal btn As EditorButton, ByVal keys As Keys)
        btn.IsLeft = True
        btn.Shortcut = New KeyShortcut(keys)
        btn.IsDefaultButton = True
        Buttons.Add(btn)
    End Sub

    Public Overrides Sub CreateDefaultButton()
        MyBase.CreateDefaultButton()
        AddDefaultButton(New EditorButton(ButtonPredefines.SpinRight), Keys.Add)
        AddDefaultButton(New EditorButton(ButtonPredefines.SpinLeft), Keys.Subtract)
    End Sub

    Protected Sub InitFontItems()
        Dim width As Integer = 20
        Dim height As Integer = 16
        Dim offset As Integer = 1

        Dim il As New ImageList()
        il.ImageSize = New Size(width, height)

        Dim r As New Rectangle(offset, offset, width - offset * 2, height - offset * 2)

        BeginUpdate()
        Try
            Items.Clear()
            SmallImages = il

            Dim i As Integer
            Dim j As Integer = 0
            For i = 0 To FontFamily.Families.Length - 1
                Try
                    Dim f As New Font(FontFamily.Families(i).Name, 8)
                    Dim s As String = FontFamily.Families(i).Name + ", " + f.Size.ToString()
                    Dim im As New Bitmap(width, height)
                    Dim g As Graphics = Graphics.FromImage(im)
                    g.FillRectangle(Brushes.White, r)
                    g.DrawString("abc", f, Brushes.Black, offset, offset)
                    g.DrawRectangle(Pens.Black, r)
                    il.Images.Add(im)
                    g.Dispose()
                    Items.Add(New ImageComboBoxItem(s, f, j))
                    j += 1
                Catch
                End Try
            Next
        Finally
            CancelUpdate()
        End Try
    End Sub
End Class
<ToolboxBitmap(GetType(MyFontEdit), "MyFontEdit.bmp")> _
Public Class MyFontEdit
    Inherits ImageComboBoxEdit
    Shared Sub New()
        RepositoryItemMyFontEdit.RegisterMyFontEdit()
    End Sub

    Public Sub New()
        ctrl = Nothing
    End Sub

    Public Overrides ReadOnly Property EditorTypeName() As String
        Get
            Return "MyFontEdit"
        End Get
    End Property

    <DesignerSerializationVisibility(DesignerSerializationVisibility.Content)> _
          Public Shadows ReadOnly Property Properties() As RepositoryItemMyFontEdit
        Get
            Return CType(MyBase.Properties, RepositoryItemMyFontEdit)
        End Get
    End Property

    <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)> _
    Public Property MyFont() As Font
        Get
            If TypeOf EditValue Is Font Then Return CType(EditValue, Font)
            Return Nothing
        End Get
        Set(ByVal Value As Font)
            If Not Value Is Nothing Then
                Dim item As ImageComboBoxItem
                For Each item In Properties.Items
                    If CType(item.Value, Font).Name = Value.Name Then
                        SetItem(item, Value)
                    End If
                Next
            End If
            EditValue = Value
        End Set
    End Property

    Private Sub SetItem(ByVal item As ImageComboBoxItem, ByVal fnt As Font)
        Properties.BeginUpdate()
        item.Value = fnt
        item.Description = fnt.Name + ", " + fnt.Size.ToString()
        Properties.EndUpdate()
        If InplaceType <> XtraEditors.Controls.InplaceType.Standalone Then
            Dim fe As RepositoryItemMyFontEdit = CType(Tag, RepositoryItemMyFontEdit)
            If fe Is Nothing Then Exit Sub
            fe.BeginUpdate()
            Try
                fe.Items.Assign(Properties.Items)
            Finally
                fe.CancelUpdate()
            End Try
        End If
    End Sub

    Private ctrl As Control
    Public Property Control() As Control
        Get
            Return ctrl
        End Get
        Set(ByVal Value As Control)
            ctrl = Value
            If Not ctrl Is Nothing Then
                AddHandler ctrl.FontChanged, New EventHandler(AddressOf OnCtrlFontChanged)
                MyFont = ctrl.Font
            End If
        End Set
    End Property

    Sub OnCtrlFontChanged(ByVal sender As Object, ByVal e As EventArgs)
        If Not ctrl Is Nothing Then MyFont = ctrl.Font
    End Sub

    Protected Overrides Sub OnEditValueChanged()
        MyBase.OnEditValueChanged()
        If Not ctrl Is Nothing Then
            Try
                ctrl.Font = MyFont
            Catch
            End Try
        End If
    End Sub

    Protected Overrides Sub OnClickButton(ByVal buttonInfo As EditorButtonObjectInfoArgs)
        MyBase.OnClickButton(buttonInfo)
        If SelectedIndex = -1 Then Exit Sub
        Dim myItem As ImageComboBoxItem = Properties.Items(SelectedIndex)
        Dim fnt As Font = CType(myItem.Value, Font)
        Dim newFont As Font = Nothing
        If buttonInfo.Button.Kind = ButtonPredefines.SpinLeft And fnt.Size > 5 Then
            newFont = New Font(fnt.FontFamily, fnt.Size - 1)
        End If
        If buttonInfo.Button.Kind = ButtonPredefines.SpinRight And fnt.Size < 50 Then
            newFont = New Font(fnt.FontFamily, fnt.Size + 1)
        End If
        If Not newFont Is Nothing Then
            SetItem(myItem, newFont)
            EditValue = newFont
            OnEditValueChanged()
        End If
    End Sub
End Class
