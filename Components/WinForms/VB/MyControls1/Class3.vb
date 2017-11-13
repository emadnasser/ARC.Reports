Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors.Registrator

<UserRepositoryItem("RegisterMyRadioGroup")> _
Public Class RepositoryItemMyRadioGroup
    Inherits RepositoryItemRadioGroup
    Shared Sub New()
        RegisterMyRadioGroup()
    End Sub

    Public Sub New()
    End Sub

    Public Shared Sub RegisterMyRadioGroup()
        Dim img As Image = CType(Bitmap.FromStream(System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream("DevExpress.CustomEditors.MyRadioGroup.bmp")), Bitmap)
        EditorRegistrationInfo.Default.Editors.Add(New EditorClassInfo("MyRadioGroup", GetType(MyRadioGroup), GetType(RepositoryItemMyRadioGroup), GetType(DevExpress.XtraEditors.ViewInfo.RadioGroupViewInfo), New DevExpress.XtraEditors.Drawing.RadioGroupPainter(), True, img, GetType(DevExpress.Accessibility.PopupEditAccessible)))
    End Sub

    Public Overrides ReadOnly Property EditorTypeName() As String
        Get
            Return "MyRadioGroup"
        End Get
    End Property
    '-------------------------
    Protected Overrides Function CreateItemCollection() As RadioGroupItemCollection
        Return New MyRadioGroupItemCollection()
    End Function

    <DesignerSerializationVisibility(DesignerSerializationVisibility.Content)> _
    Public Shadows ReadOnly Property Items() As MyRadioGroupItemCollection
        Get
            Return CType(MyBase.Items, MyRadioGroupItemCollection)
        End Get
    End Property
    '-------------------------
End Class
<ToolboxBitmap(GetType(MyRadioGroup), "MyRadioGroup.bmp")> _
Public Class MyRadioGroup
    Inherits DevExpress.XtraEditors.RadioGroup
    Shared Sub New()
        RepositoryItemMyRadioGroup.RegisterMyRadioGroup()
    End Sub

    Public Sub New()
    End Sub

    Public Overrides ReadOnly Property EditorTypeName() As String
        Get
            Return "MyRadioGroup"
        End Get
    End Property

    <DesignerSerializationVisibility(DesignerSerializationVisibility.Content)> _
          Public Shadows ReadOnly Property Properties() As RepositoryItemMyRadioGroup
        Get
            Return CType(MyBase.Properties, RepositoryItemMyRadioGroup)
        End Get
    End Property
End Class

<TypeConverter(GetType(DevExpress.Utils.Design.UniversalTypeConverter))> _
Public Class MyRadioGroupItem
    Inherits RadioGroupItem
    Private _myBoolProperty As Boolean
    Public Sub New(ByVal value As Object, ByVal description As String, ByVal myBoolProperty As Boolean)
        MyBase.New(value, description)
        Me._myBoolProperty = myBoolProperty
    End Sub

    Public Sub New()
        MyBoolProperty = True
    End Sub

    <DefaultValue(True)> _
    Public Property MyBoolProperty() As Boolean
        Get
            Return _myBoolProperty
        End Get
        Set(ByVal Value As Boolean)
            _myBoolProperty = Value
            ItemChanged()
        End Set
    End Property

    Public Overrides Function Clone() As Object
        Return New MyRadioGroupItem(Value, Description, MyBoolProperty)
    End Function
End Class

Public Class MyRadioGroupItemCollection
    Inherits DevExpress.XtraEditors.Controls.RadioGroupItemCollection
    Public Shadows Property Item(ByVal index As Integer) As MyRadioGroupItem
        Get
            Return CType(List(index), MyRadioGroupItem)
        End Get
        Set(ByVal Value As MyRadioGroupItem)
            List(index) = Value
        End Set
    End Property
End Class
