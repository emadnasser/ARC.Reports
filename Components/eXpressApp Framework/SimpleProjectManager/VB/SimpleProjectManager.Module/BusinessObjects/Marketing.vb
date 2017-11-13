Imports System.ComponentModel
Imports DevExpress.ExpressApp.DC
Imports DevExpress.Persistent.Base
Imports DevExpress.ExpressApp.Filtering
Imports DevExpress.Persistent.Validation
Imports System.ComponentModel.DataAnnotations.Schema
Imports DevExpress.ExpressApp

<ImageName("BO_Customer"), NavigationItem("Marketing"), DefaultProperty("FullName")> _
Public Class Customer
    Public Const EmailRegularExpression As String = "^[A-Za-z0-9_\+-]+(\.[A-Za-z0-9_\+-]+)*@[A-Za-z0-9-]+(\.[A-Za-z0-9-]+)*\.([A-Za-z]{2,4})$"
    Public Sub New()
        Testimonials = New List(Of Testimonial)()
    End Sub
    Private privateId As Integer
    <Browsable(False)> _
    Public Property Id() As Integer
        Get
            Return privateId
        End Get
        Protected Set(ByVal value As Integer)
            privateId = value
        End Set
    End Property
    Public Property FirstName() As String
    Public Property LastName() As String
    <RuleRegularExpression(EmailRegularExpression, CustomMessageTemplate:="Invalid email format!")> _
    Public Property Email() As String
    Public Property Company() As String
    Public Property Occupation() As String
    <Aggregated> _
    Public Overridable Property Testimonials() As IList(Of Testimonial)

    <NotMapped, RuleRequiredField, SearchMemberOptions(SearchMemberMode.Exclude)> _
    Public ReadOnly Property FullName() As String
        Get
            Dim namePart As String = String.Format("{0} {1}", FirstName, LastName)
            Return If(Company IsNot Nothing, String.Format("{0} ({1})", namePart, Company), namePart)
        End Get
    End Property
    <ImageEditor(ListViewImageEditorCustomHeight:=75, DetailViewImageEditorFixedHeight:=150)> _
    Public Property Photo() As Byte()
End Class

<DefaultProperty("Customer"), ImageName("BO_Note"), NavigationItem("Marketing"), DefaultListViewOptions(MasterDetailMode.ListViewAndDetailView, True, NewItemRowPosition.Top)> _
Public Class Testimonial
    Public Sub New()
        CreatedOn = Date.Now
    End Sub
    Private privateId As Integer
    <Browsable(False)> _
    Public Property Id() As Integer
        Get
            Return privateId
        End Get
        Protected Set(ByVal value As Integer)
            privateId = value
        End Set
    End Property
    <FieldSize(FieldSizeAttribute.Unlimited), RuleRequiredField> _
    Public Property Quote() As String
    <FieldSize(512), RuleRequiredField(ResultType:=ValidationResultType.Warning)> _
    Public Property Highlight() As String
    Private privateCreatedOn As Date
    <VisibleInListView(False)> _
    Public Property CreatedOn() As Date
        Get
            Return privateCreatedOn
        End Get
        Friend Set(ByVal value As Date)
            privateCreatedOn = value
        End Set
    End Property
    Public Property Tags() As String
    <VisibleInListView(False)> _
    Public Property CaseStudyUrl() As String
    <RuleRequiredField> _
    Public Overridable Property Customer() As Customer
End Class

