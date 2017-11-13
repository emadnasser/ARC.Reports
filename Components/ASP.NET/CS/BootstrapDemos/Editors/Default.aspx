<%@ Page Title="" Language="C#" MasterPageFile="~/Shared/DemoLayout.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="Editors_Overview" %>
<asp:Content ID="PageTitleHolder" ContentPlaceHolderID="PageTitle" runat="server">
    DevExpress Bootstrap Editors for ASP.NET
</asp:Content>
<asp:Content ID="PageHeaderHolder" ContentPlaceHolderID="PageHeader" runat="server">
    DevExpress Bootstrap Editors
</asp:Content>
<asp:Content ID="ContentHolder" ContentPlaceHolderID="Content" runat="server">
    <h2>Editors Overview</h2>
    <p>DevExpress Bootstrap Data Editors are a powerful collection of data edit and multi-purpose server controls rendered using Bootstrap CSS classes. These controls can function in bound and unbound modes, both as standalone data editors and within container controls such as the DevExpress Bootstrap Grid View.</p>
    <div class="panel overview-form">
        <div class="panel-body">
            <div class="form-group">
                <label class="control-label">TextBox</label>
                <dx:BootstrapTextBox ID="TextBox1" runat="server" Text="123456" DisplayFormatString="[ 00 - 00 - 00 ]">
                </dx:BootstrapTextBox>
            </div>
            <div class="form-group">
                <label class="control-label">ButtonEdit</label>
                <dx:BootstrapButtonEdit ID="ButtonEdit1" Text="Andy McKee - Rylynn" Caption="" runat="server">
                    <ClearButton DisplayMode="OnHover" />
                    <Buttons>
                        <dx:BootstrapEditButton />
                    </Buttons>
                </dx:BootstrapButtonEdit>
            </div>
            <div class="form-group">
                <label class="control-label">ComboBox</label>
                <dx:BootstrapComboBox ID="ComboBox1" Caption="" runat="server" NullText="Select item...">
                    <Items>
                        <dx:BootstrapListEditItem Value="Ana Trujillo" />
                        <dx:BootstrapListEditItem Value="Giovanni Rovelli" />
                        <dx:BootstrapListEditItem Value="Jaime Yorres" />
                        <dx:BootstrapListEditItem Value="John Steel" Selected="false" />
                    </Items>
                </dx:BootstrapComboBox>
            </div>
            <div class="form-group">
                <label class="control-label">DateEdit</label>
                <dx:BootstrapDateEdit runat="server" ID="DateEdit1" Caption="">
                </dx:BootstrapDateEdit>
            </div>
            <div class="form-group">
                <label class="control-label">SpinEdit</label>
                <dx:BootstrapSpinEdit runat="server" ID="SpinEdit1" Caption="" SpinButtons-ShowLargeIncrementButtons="true"
                    Increment="100" LargeIncrement="1000" Number="100" NumberType="Integer" MinValue="0" MaxValue="10000">
                </dx:BootstrapSpinEdit>
            </div>
            <div class="form-group">
                <label class="control-label">Memo</label>
                <dx:BootstrapMemo runat="server" ID="Memo1" Caption="" Text="Confections - Desserts, candies, and sweet breads.">
                </dx:BootstrapMemo>
            </div>
            <div class="form-group">
                <label class="control-label">CheckBox</label>
                <dx:BootstrapCheckBox runat="server" ID="CheckBox1" Text="Click to change state"></dx:BootstrapCheckBox>
            </div>
            <div class="form-group">
                <label class="control-label">RadioButton</label>
                <dx:BootstrapRadioButton runat="server" ID="RadioButton1" Text="Click to change state"></dx:BootstrapRadioButton>
            </div>
            <div class="form-group">
                <label class="control-label">ProgressBar</label>
                <dx:BootstrapProgressBar runat="server" ID="ProgressBar1" Position="60" Striped="true" Animated="true"></dx:BootstrapProgressBar>                
            </div>
            <dx:BootstrapButton ID="Button1" runat="server" Text="Submit" AutoPostBack="true">
            </dx:BootstrapButton>
        </div>
    </div>
    <p>To simplify constructing responsive layouts of any complexity with our data editors, the DevExpress Bootstrap Controls suite provides the Form Layout control.</p>
    <p>Our data editors provide a powerful and seamless built-in mechanism for data validation both on the client and server. The validation mechanism supports multiple ways to define the validation logic and to indicate validation failures.</p>
</asp:Content>
