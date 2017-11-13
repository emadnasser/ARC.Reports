<%@ Control Language="C#" AutoEventWireup="true" CodeFile="EvaluationEditForm.ascx.cs" Inherits="UserControls_EditForms_EvaluationEditForm" %>
<dx:ASPxPopupControl ID="EvaluationEditPopup" ClientInstanceName="evaluationEditPopup" runat="server" ShowCloseButton="false" PopupHorizontalAlign="WindowCenter" CloseOnEscape="true"
    PopupVerticalAlign="WindowCenter" CloseAction="None" OnWindowCallback="EvaluationEditPopup_WindowCallback" Modal="true" CssClass="evalEditFormPopup">
    <ClientSideEvents EndCallback="DevAV.EvaluationEditPopup_EndCallback" />
    <ContentCollection>
        <dx:PopupControlContentControl runat="server">
            <dx:ASPxFormLayout ID="ASPxFormLayout1" runat="server">
                <SettingsItemCaptions Location="Top"/>
                <Styles>
                    <LayoutGroup CssClass="group"></LayoutGroup>
                </Styles>
                <Items>
                    <dx:LayoutItem Caption="Subject">
                        <LayoutItemNestedControlCollection>
                            <dx:LayoutItemNestedControlContainer runat="server">
                                <dx:ASPxTextBox ID="EvaluationSubjectTextBox" ClientInstanceName="evaluationSubjectTextBox" runat="server" Width="500px" MaxLength="50">
                                    <ValidationSettings ErrorDisplayMode="ImageWithTooltip">
                                        <RequiredField IsRequired="true" ErrorText="Subject is required" />
                                    </ValidationSettings>
                                </dx:ASPxTextBox>
                            </dx:LayoutItemNestedControlContainer>
                        </LayoutItemNestedControlCollection>
                    </dx:LayoutItem>
                    <dx:LayoutItem Caption="Evaluation">
                        <LayoutItemNestedControlCollection>
                            <dx:LayoutItemNestedControlContainer runat="server">
                                <dx:ASPxMemo ID="EvaluationMemo" runat="server" Width="100%" Height="200px" MaxLength="500">
                                </dx:ASPxMemo>
                            </dx:LayoutItemNestedControlContainer>
                        </LayoutItemNestedControlCollection>
                    </dx:LayoutItem>
                </Items>
            </dx:ASPxFormLayout>
            <div class="buttonsContainer">
                <dx:ASPxButton ID="EvaluationSaveButton" runat="server" AutoPostBack="false" UseSubmitBehavior="False" Text="Save" Width="100px">
                    <ClientSideEvents Click="DevAV.EvaluationSaveButton_Click" />
                </dx:ASPxButton>
                <dx:ASPxButton ID="EvaluationCancelButton" runat="server" AutoPostBack="False" UseSubmitBehavior="False" Text="Cancel" Width="100px">
                    <ClientSideEvents Click="DevAV.EvaluationCancelButton_Click" />
                </dx:ASPxButton>
            </div>
            <div style="clear: both">
            </div>
        </dx:PopupControlContentControl>
    </ContentCollection>
</dx:ASPxPopupControl>
