<%@ Page Title="" Language="C#" MasterPageFile="~/Shared/DemoLayout.master" AutoEventWireup="true" CodeFile="Validation.aspx.cs" Inherits="Editors_Validation" %>
<asp:Content ID="PageTitleHolder" ContentPlaceHolderID="PageTitle" runat="server">
    Bootstrap Editors Demo | DevExpress Bootstrap controls for ASP.NET
</asp:Content>
<asp:Content ID="PageHeaderHolder" ContentPlaceHolderID="PageHeader" runat="server">
    DevExpress Bootstrap Editors
</asp:Content>
<asp:Content ID="ContentHolder" ContentPlaceHolderID="Content" runat="server">
    <div class="col-md-9">
    <demo:DemoItem runat="server" Title="Validation">
        <Description>
            <p>The DevExpress Bootstrap editors provide a universal mechanism for performing data validation on both the client and server. You can access the validation settings of a data editor through the editor’s <strong>ValidationSettings</strong> property.</p>
            <p>You can provide the required validation logic by declaring that the editor is a required input field, or by specifying a regular expression to check user input.</p>
        </Description>
        <Example>
            <div class="form-group">
                <dx:BootstrapTextBox ID="TextBox1" NullText="Enter Name..." Caption="Name" runat="server">
                    <ValidationSettings ValidationGroup="Validation">
                        <RequiredField IsRequired="true" ErrorText="Name is required" />
                    </ValidationSettings>
                </dx:BootstrapTextBox>
            </div>
            <script type="text/javascript">
                function onBirthdayValidation(s, e) {
                    var birthday = e.value;
                    if(!birthday)
                        return;
                    var today = new Date();
                    var msecPerYear = 1000 * 60 * 60 * 24 * 365;
                    var years = (today.getTime() - birthday.getTime()) / msecPerYear;
                    if(years < 14) {
                        e.isValid = false;
                        e.errorText = "You should be at least 14 years old";
                    }
                }
            </script>
            <div class="form-group">
                <dx:BootstrapDateEdit ID="DateEdit1" NullText="Select Birthday..." Caption="Birthday" runat="server">
                    <ClientSideEvents Validation="onBirthdayValidation" />
                    <ValidationSettings ValidationGroup="Validation">
                        <RequiredField IsRequired="true" ErrorText="Birthday is required" />
                    </ValidationSettings>
                </dx:BootstrapDateEdit>
            </div>
            <div class="form-group">
                <dx:BootstrapComboBox ID="ComboBox1" DropDownStyle="DropDown" NullText="Select Occupation..." Caption="Occupation" runat="server">
                    <ClearButton DisplayMode="OnHover" />
                    <ValidationSettings ValidationGroup="Validation">
                        <RequiredField IsRequired="true" ErrorText="Occupation is required" />
                    </ValidationSettings>
                    <Items>
                        <dx:BootstrapListEditItem Value="Academic" />
                        <dx:BootstrapListEditItem Value="Administrative" />
                        <dx:BootstrapListEditItem Value="Art/Entertainment" />
                        <dx:BootstrapListEditItem Value="College Student" />
                        <dx:BootstrapListEditItem Value="Community & Social" />
                        <dx:BootstrapListEditItem Value="Computers" />
                        <dx:BootstrapListEditItem Value="Education" />
                        <dx:BootstrapListEditItem Value="Engineering" />
                        <dx:BootstrapListEditItem Value="Financial Services" />
                        <dx:BootstrapListEditItem Value="Government" />
                        <dx:BootstrapListEditItem Value="High School Student" />
                        <dx:BootstrapListEditItem Value="Law" />
                        <dx:BootstrapListEditItem Value="Managerial" />
                        <dx:BootstrapListEditItem Value="Manufacturing" />
                        <dx:BootstrapListEditItem Value="Medical/Health" />
                        <dx:BootstrapListEditItem Value="Military" />
                        <dx:BootstrapListEditItem Value="Non-government Organization" />
                        <dx:BootstrapListEditItem Value="Other Services" />
                        <dx:BootstrapListEditItem Value="Professional" />
                        <dx:BootstrapListEditItem Value="Retail" />
                        <dx:BootstrapListEditItem Value="Science & Research" />
                        <dx:BootstrapListEditItem Value="Sports" />
                        <dx:BootstrapListEditItem Value="Technical" />
                        <dx:BootstrapListEditItem Value="University Student" />
                        <dx:BootstrapListEditItem Value="Web Building" />
                    </Items>
                </dx:BootstrapComboBox>
            </div>
            <div class="form-group">
                <dx:BootstrapButtonEdit ID="ButtonEdit1" ClearButton-DisplayMode="OnHover" NullText="Enter E-mail..." Caption="E-mail" runat="server">
                    <ValidationSettings ValidationGroup="Validation">
                        <RequiredField IsRequired="true" ErrorText="E-mail is required" />
                        <RegularExpression ErrorText="Invalid e-mail" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" />
                    </ValidationSettings>
                    <Buttons>
                        <dx:BootstrapEditButton IconCssClass="glyphicon glyphicon-envelope" />
                    </Buttons>
                </dx:BootstrapButtonEdit>
            </div>
            <div class="form-group">
                <dx:BootstrapTextBox ID="TextBox2" NullText="Enter Phone Number..." Caption="Phone Number" runat="server">
                    <ValidationSettings ValidationGroup="Validation">
                        <RequiredField IsRequired="true" ErrorText="Phone Number is required" />
                        <RegularExpression ValidationExpression="\(?\b[0-9]{3}\)?[-. ]?[0-9]{3}[-. ]?[0-9]{4}\b" ErrorText="Please input missing digits" />
                    </ValidationSettings>
                    <MaskSettings Mask="+1 (999) 999-9999" IncludeLiterals="None" />
                </dx:BootstrapTextBox>
            </div>
            <dx:BootstrapButton ID="ButtonOK" runat="server" Text="OK" RenderOption="Primary">
                <ClientSideEvents Click="function(s, e) { e.processOnServer = ASPxClientEdit.ValidateGroup('Validation'); }" />
                <CssClasses Icon="glyphicon glyphicon-ok" />
            </dx:BootstrapButton>
            <dx:BootstrapButton ID="ButtonCancel" runat="server" Text="Cancel" RenderOption="Link" AutoPostBack="false">
                <ClientSideEvents Click="function(s, e) { ASPxClientEdit.ClearGroup('Validation'); }" />
            </dx:BootstrapButton>
        </Example>
        <CodeASPX>&lt;dx:BootstrapTextBox ID="TextBox1" NullText="Enter Name..." Caption="Name" runat="server"&gt;
    &lt;ValidationSettings ValidationGroup="Validation"&gt;
        &lt;RequiredField IsRequired="true" ErrorText="Name is required" /&gt;
    &lt;/ValidationSettings&gt;
&lt;/dx:BootstrapTextBox&gt;
&lt;dx:BootstrapDateEdit ID="DateEdit1" NullText="Select Birthday..." Caption="Birthday" runat="server"&gt;
    &lt;ClientSideEvents Validation="onBirthdayValidation" /&gt;
    &lt;ValidationSettings ValidationGroup="Validation"&gt;
        &lt;RequiredField IsRequired="true" ErrorText="Birthday is required" /&gt;
    &lt;/ValidationSettings&gt;
&lt;/dx:BootstrapDateEdit&gt;
&lt;dx:BootstrapComboBox ID="ComboBox1" DropDownStyle="DropDown" NullText="Select Occupation..." Caption="Occupation" runat="server"&gt;
    &lt;ClearButton DisplayMode="OnHover" /&gt;
    &lt;ValidationSettings ValidationGroup="Validation"&gt;
        &lt;RequiredField IsRequired="true" ErrorText="Occupation is required" /&gt;
    &lt;/ValidationSettings&gt;
    &lt;Items&gt;
        ...
    &lt;/Items&gt;
&lt;/dx:BootstrapComboBox&gt;
&lt;dx:BootstrapButtonEdit ID="ButtonEdit1" ClearButton-DisplayMode="OnHover" NullText="Enter E-mail..." Caption="E-mail" runat="server"&gt;
    &lt;ValidationSettings ValidationGroup="Validation"&gt;
        &lt;RequiredField IsRequired="true" ErrorText="E-mail is required" /&gt;
        &lt;RegularExpression ErrorText="Invalid e-mail" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" /&gt;
    &lt;/ValidationSettings&gt;
    &lt;Buttons&gt;
        &lt;dx:BootstrapEditButton IconCssClass="glyphicon glyphicon-envelope" /&gt;
    &lt;/Buttons&gt;
&lt;/dx:BootstrapButtonEdit&gt;
&lt;dx:BootstrapTextBox ID="TextBox2" NullText="Enter Phone Number..." Caption="Phone Number" runat="server"&gt;
    &lt;ValidationSettings ValidationGroup="Validation"&gt;
        &lt;RequiredField IsRequired="true" ErrorText="Phone Number is required" /&gt;
        &lt;RegularExpression ValidationExpression="\(?\b[0-9]{3}\)?[-. ]?[0-9]{3}[-. ]?[0-9]{4}\b" ErrorText="Please input missing digits" /&gt;
    &lt;/ValidationSettings&gt;
    &lt;MaskSettings Mask="+1 (999) 999-9999" IncludeLiterals="None" /&gt;
&lt;/dx:BootstrapTextBox&gt;
&lt;dx:BootstrapButton ID="ButtonOK" runat="server" Text="OK" RenderOption="Primary" ValidationGroup="Validation"&gt;
    &lt;ClientSideEvents Click="function(s, e) { e.processOnServer = ASPxClientEdit.ValidateGroup('Validation'); }" /&gt;
&lt;/dx:BootstrapButton&gt;
&lt;dx:BootstrapButton ID="ButtonCancel" runat="server" Text="Cancel" RenderOption="Link" AutoPostBack="false"&gt;
    &lt;ClientSideEvents Click="function(s, e) { ASPxClientEdit.ClearGroup('Validation'); }" /&gt;
&lt;/dx:BootstrapButton&gt;</CodeASPX>
        <CodeJS>function onBirthdayValidation(s, e) {
    var birthday = e.value;
    if(!birthday)
        return;
    var today = new Date();
    var msecPerYear = 1000 * 60 * 60 * 24 * 365;
    var years = (today.getTime() - birthday.getTime()) / msecPerYear;
    if(years &lt; 14) {
        e.isValid = false;
        e.errorText = "You should be at least 14 years old";
    }
}</CodeJS>
    </demo:DemoItem>
    <demo:DemoItem runat="server" Title="Custom Validation">
        <Description>
            <p>The DevExpress Bootstrap editors allow you to provide custom validation logic to an editor. To achieve this goal, handle the editor’s <strong>Validation</strong> event on the server side, client side, or both.</p>
        </Description>
        <Example>
            <script type="text/javascript">
                function onNameValidation(s, e) {
                    var name = e.value;
                    if(name == null)
                        return;
                    if(name.length < 2)
                        e.isValid = false;
                }
                function onAgeValidation(s, e) {
                    if(e.value == null || e.value == "")
                        return;
                    var age = Number(e.value);
                    if(isNaN(age) || age < 18)
                        e.isValid = false;
                }
                function onArrivalDateValidation(s, e) {
                    var selectedDate = s.date;
                    if(selectedDate == null || selectedDate == false)
                        return;
                    var currentDate = new Date();
                    if(currentDate.getFullYear() != selectedDate.getFullYear() || currentDate.getMonth() != selectedDate.getMonth())
                        e.isValid = false;
                }
            </script>
            <div class="form-group">
                <dx:BootstrapTextBox ID="NameTextBox" Caption="Name" EnableClientSideAPI="true" OnValidation="NameTextBox_Validation" runat="server">
                    <ClientSideEvents Validation="onNameValidation" />
                    <ValidationSettings ValidationGroup="CustomValidation" SetFocusOnError="true" ErrorText="Name must be at least two characters long">
                        <RequiredField IsRequired="true" ErrorText="Name is required" />
                    </ValidationSettings>
                </dx:BootstrapTextBox>
            </div>
            <div class="form-group">
                <dx:BootstrapTextBox ID="AgeTextBox" Caption="Age" EnableClientSideAPI="true" OnValidation="AgeTextBox_Validation" runat="server">
                    <ClientSideEvents Validation="onAgeValidation" />
                    <ValidationSettings ValidationGroup="CustomValidation" SetFocusOnError="true" ErrorText="Age must be greater than or equal 18"></ValidationSettings>
                </dx:BootstrapTextBox>
            </div>
            <div class="form-group">
                <dx:BootstrapDateEdit ID="ArrivalDateEdit" Caption="Arrival date" EnableClientSideAPI="true" OnValidation="ArrivalDateEdit_Validation" runat="server">
                    <ClientSideEvents Validation="onArrivalDateValidation" />
                    <ValidationSettings ValidationGroup="CustomValidation" SetFocusOnError="true" ErrorText="Arrival date is required and must belong to the current month">
                        <RequiredField IsRequired="true" ErrorText="" />
                    </ValidationSettings>
                </dx:BootstrapDateEdit>
            </div>
            <dx:BootstrapButton ID="OKButton" runat="server" Text="OK" RenderOption="Primary">
                <ClientSideEvents Click="function(s, e) { e.processOnServer = ASPxClientEdit.ValidateGroup('CustomValidation'); }" />
                <CssClasses Icon="glyphicon glyphicon-ok" />
            </dx:BootstrapButton>
            <dx:BootstrapButton ID="CancelButton" runat="server" Text="Cancel" RenderOption="Link" AutoPostBack="false">
                <ClientSideEvents Click="function(s, e) { ASPxClientEdit.ClearGroup('CustomValidation'); }" />
            </dx:BootstrapButton>
        </Example>
        <CodeASPX>&lt;dx:BootstrapTextBox ID="NameTextBox" Caption="Name" EnableClientSideAPI="true" OnValidation="NameTextBox_Validation" runat="server"&gt;
    &lt;ClientSideEvents Validation="onNameValidation" /&gt;
    &lt;ValidationSettings ValidationGroup="CustomValidation" SetFocusOnError="true" ErrorText="Name must be at least two characters long"&gt;
        &lt;RequiredField IsRequired="true" ErrorText="Name is required" /&gt;
    &lt;/ValidationSettings&gt;
&lt;/dx:BootstrapTextBox&gt;
&lt;dx:BootstrapTextBox ID="AgeTextBox" Caption="Age" EnableClientSideAPI="true" OnValidation="AgeTextBox_Validation" runat="server"&gt;
    &lt;ClientSideEvents Validation="onAgeValidation" /&gt;
    &lt;ValidationSettings ValidationGroup="CustomValidation" SetFocusOnError="true" ErrorText="Age must be greater than or equal 18"&gt;&lt;/ValidationSettings&gt;
&lt;/dx:BootstrapTextBox&gt;
&lt;dx:BootstrapDateEdit ID="ArrivalDateEdit" Caption="Arrival date" EnableClientSideAPI="true" OnValidation="ArrivalDateEdit_Validation" runat="server"&gt;
    &lt;ClientSideEvents Validation="onArrivalDateValidation" /&gt;
    &lt;ValidationSettings ValidationGroup="CustomValidation" SetFocusOnError="true" ErrorText="Arrival date is required and must belong to the current month"&gt;
        &lt;RequiredField IsRequired="true" ErrorText="" /&gt;
    &lt;/ValidationSettings&gt;
&lt;/dx:BootstrapDateEdit&gt;
&lt;dx:BootstrapButton ID="ButtonOK" runat="server" Text="OK" RenderOption="Primary" ValidationGroup="CustomValidation"&gt;
    &lt;ClientSideEvents Click="function(s, e) { e.processOnServer = ASPxClientEdit.ValidateGroup('CustomValidation'); }" /&gt;
&lt;/dx:BootstrapButton&gt;
&lt;dx:BootstrapButton ID="ButtonCancel" runat="server" Text="Cancel" RenderOption="Link" AutoPostBack="false"&gt;
    &lt;ClientSideEvents Click="function(s, e) { ASPxClientEdit.ClearGroup('CustomValidation'); }" /&gt;
&lt;/dx:BootstrapButton&gt;</CodeASPX>
        <CodeCS>protected void NameTextBox_Validation(object sender, DevExpress.Web.ValidationEventArgs e) {
    if((e.Value as string).Length &lt; 2)
        e.IsValid = false;
}
protected void AgeTextBox_Validation(object sender, DevExpress.Web.ValidationEventArgs e) {
    string strAge = Convert.ToString(e.Value);
    if(string.IsNullOrEmpty(strAge))
        return;
    strAge = strAge.TrimStart('0');
    if(strAge.Length == 0)
        return;
    int age = 0;
    if(!int.TryParse(strAge, out age) || age &lt; 18)
        e.IsValid = false;
}
protected void ArrivalDateEdit_Validation(object sender, DevExpress.Web.ValidationEventArgs e) {
    if(!(e.Value is DateTime))
        return;
    DateTime selectedDate = (DateTime)e.Value;
    DateTime currentDate = DateTime.Now;
    if(selectedDate.Year != currentDate.Year || selectedDate.Month != currentDate.Month)
        e.IsValid = false;
}</CodeCS>
        <CodeJS>function onNameValidation(s, e) {
    var name = e.value;
    if(name == null)
        return;
    if(name.length &lt; 2)
        e.isValid = false;
}
function onAgeValidation(s, e) {
    if(e.value == null || e.value == "")
        return;
    var age = Number(e.value);
    if(isNaN(age) || age &lt; 18)
        e.isValid = false;
}
function onArrivalDateValidation(s, e) {
    var selectedDate = s.date;
    if(selectedDate == null || selectedDate == false)
        return;
    var currentDate = new Date();
    if(currentDate.getFullYear() != selectedDate.getFullYear() || currentDate.getMonth() != selectedDate.getMonth())
        e.isValid = false;
}</CodeJS>
    </demo:DemoItem>
    </div>
    <div class="col-md-3">
        <div class="affix page-nav" id="page-navigation">
        </div>
    </div>
</asp:Content>
