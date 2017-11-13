<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="DynamicSheetGeneration.aspx.cs" Inherits="ApplicationScenarios_DynamicSheetGeneration" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" Runat="Server">
     <dx:ASPxFormLayout ID="DemoOptions" runat="server" Width="100%" CssClass="OptionsBottomMargin">
        <Items>
            <dx:LayoutGroup ColCount="3" Caption="Report parameters">
                <Items>
                    <dx:LayoutItem Caption="Loan amount">
                        <LayoutItemNestedControlCollection>
                            <dx:LayoutItemNestedControlContainer>
                                <dx:ASPxSpinEdit ID="LoanAmount" runat="server" DecimalPlaces="2" DisplayFormatString="{0:C}" MinValue="1" MaxValue="2147483647" AllowNull="false"
                                        Increment="0.1" LargeIncrement="1">
                                    <SpinButtons ShowLargeIncrementButtons="true" />
                                </dx:ASPxSpinEdit>
                            </dx:LayoutItemNestedControlContainer>
                        </LayoutItemNestedControlCollection>
                    </dx:LayoutItem>
                    <dx:LayoutItem Caption="Annual interest rate">
                        <LayoutItemNestedControlCollection>
                            <dx:LayoutItemNestedControlContainer>
                                <dx:ASPxSpinEdit ID="AnnualInterestRate" runat="server" DecimalPlaces="3" DisplayFormatString="{0:P}" MinValue="0" MaxValue="1" AllowNull="false"
                                    Increment="0.1">
                                </dx:ASPxSpinEdit>
                            </dx:LayoutItemNestedControlContainer>
                        </LayoutItemNestedControlCollection>
                    </dx:LayoutItem>
                    <dx:EmptyLayoutItem />
                    <dx:LayoutItem Caption="Loan period in years">
                        <LayoutItemNestedControlCollection>
                            <dx:LayoutItemNestedControlContainer>
                                <dx:ASPxSpinEdit ID="LoanPeriodInYears" runat="server" MinValue="0" MaxValue="12" AllowNull="false">
                                </dx:ASPxSpinEdit>
                            </dx:LayoutItemNestedControlContainer>
                        </LayoutItemNestedControlCollection>
                    </dx:LayoutItem>
                    <dx:LayoutItem Caption="Number of payments per year">
                        <LayoutItemNestedControlCollection>
                            <dx:LayoutItemNestedControlContainer>
                                <dx:ASPxSpinEdit ID="NumberOfPayments" runat="server" MinValue="1" MaxValue="12" AllowNull="false">
                                </dx:ASPxSpinEdit>
                            </dx:LayoutItemNestedControlContainer>
                        </LayoutItemNestedControlCollection>
                    </dx:LayoutItem>
                    <dx:LayoutItem Caption=" ">
                        <LayoutItemNestedControlCollection>
                            <dx:LayoutItemNestedControlContainer>
                                <dx:ASPxButton ID="Apply" runat="server" Text="Apply" Width="100px" AutoPostBack="false">
                                    <ClientSideEvents Click="OnApplyReportParameters" />
                                </dx:ASPxButton>
                            </dx:LayoutItemNestedControlContainer>
                        </LayoutItemNestedControlCollection>
                    </dx:LayoutItem>
                    <dx:LayoutItem Caption="Start date of loan">
                        <LayoutItemNestedControlCollection>
                            <dx:LayoutItemNestedControlContainer>
                                <dx:ASPxDateEdit ID="StartDate" runat="server" AllowNull="false" />
                            </dx:LayoutItemNestedControlContainer>
                        </LayoutItemNestedControlCollection>
                    </dx:LayoutItem>
                    <dx:LayoutItem Caption="Optional extra payments">
                        <LayoutItemNestedControlCollection>
                            <dx:LayoutItemNestedControlContainer>
                                <dx:ASPxSpinEdit ID="OptionalExtraPayments" runat="server" DecimalPlaces="2" DisplayFormatString="{0:C}"
                                    MinValue="0" LargeIncrement="1" Increment="0.1" AllowNull="false">
                                    <SpinButtons ShowLargeIncrementButtons="true"/>
                                </dx:ASPxSpinEdit>
                            </dx:LayoutItemNestedControlContainer>
                        </LayoutItemNestedControlCollection>
                    </dx:LayoutItem>
                </Items>
            </dx:LayoutGroup>
        </Items>
        <Styles LayoutGroupBox-Caption-Font-Size="12" />
    </dx:ASPxFormLayout>
    <dx:ASPxSpreadsheet ID="Spreadsheet" ClientInstanceName="spreadsheet" runat="server" Width="100%" Height="700px" ActiveTabIndex="0" ShowConfirmOnLosingChanges="false">
    </dx:ASPxSpreadsheet>
</asp:Content>
<asp:Content ID="CssAndScript" ContentPlaceHolderID="CustomHeadHolder" runat="server">
<script type="text/javascript">
    function OnApplyReportParameters(s, e) {
        if(!spreadsheet.InCallback())
            spreadsheet.PerformDocumentCallback();
    }
</script>
</asp:Content>
