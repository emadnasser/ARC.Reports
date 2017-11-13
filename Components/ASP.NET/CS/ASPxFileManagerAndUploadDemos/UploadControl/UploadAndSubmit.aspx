<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="UploadAndSubmit.aspx.cs" Inherits="UploadControl_UploadAndSubmit" %>
<asp:Content ContentPlaceHolderID="CustomHeadHolder" runat="server">
    <style type="text/css">
        #dropZone {
            padding: 20px;
            margin: -20px;
        }
        .ResultFileName {
            text-overflow: ellipsis;
        }
        .contentFooter {
            clear: both;
            padding-top: 20px;
        }
    </style>
    <%--start highlighted block--%>
    <script type="text/javascript">
        var uploadInProgress = false,
            submitInitiated = false,
            uploadErrorOccurred = false;
            uploadedFiles = [];
        function onFileUploadComplete(s, e) {
            var callbackData = e.callbackData.split("|"),
                uploadedFileName = callbackData[0],
                isSubmissionExpired = callbackData[1] === "True";
            uploadedFiles.push(uploadedFileName);
            if(e.errorText.length > 0 || !e.isValid)
                uploadErrorOccurred = true;
            if(isSubmissionExpired && UploadedFilesTokenBox.GetText().length > 0) {
                var removedAfterTimeoutFiles = UploadedFilesTokenBox.GetTokenCollection().join("\n");
                alert("The following files have been removed from the server due to the defined 5 minute timeout: \n\n" + removedAfterTimeoutFiles);
                UploadedFilesTokenBox.ClearTokenCollection();
            }
        }
        function onFileUploadStart(s, e) {
            uploadInProgress = true;
            uploadErrorOccurred = false;
            UploadedFilesTokenBox.SetIsValid(true);
        }
        function onFilesUploadComplete(s, e) {
            uploadInProgress = false;
            for(var i = 0; i < uploadedFiles.length; i++)
                UploadedFilesTokenBox.AddToken(uploadedFiles[i]);
            updateTokenBoxVisibility();
            uploadedFiles = [];
            if(submitInitiated) {
                SubmitButton.SetEnabled(true);
                SubmitButton.DoClick();
            }
        }
        function onSubmitButtonInit(s, e) {
            s.SetEnabled(true);
        }
        function onSubmitButtonClick(s, e) {
            ASPxClientEdit.ValidateGroup();
            if(!formIsValid())
                e.processOnServer = false;
            else if(uploadInProgress) {
                s.SetEnabled(false);
                submitInitiated = true;
                e.processOnServer = false;
            }
        }
        function onTokenBoxValidation(s, e) {
            var isValid = DocumentsUploadControl.GetText().length > 0 || UploadedFilesTokenBox.GetText().length > 0;
            e.isValid = isValid;
            if(!isValid) {
                e.errorText = "No files have been uploaded. Upload at least one file.";
            }
        }
        function onTokenBoxValueChanged(s, e) {
            updateTokenBoxVisibility();
        }
        function updateTokenBoxVisibility() {
            var isTokenBoxVisible = UploadedFilesTokenBox.GetTokenCollection().length > 0;
            UploadedFilesTokenBox.SetVisible(isTokenBoxVisible);
        }
        function formIsValid() {
            return !ValidationSummary.IsVisible() && DescriptionTextBox.GetIsValid() && UploadedFilesTokenBox.GetIsValid() && !uploadErrorOccurred;
        }
    </script>
    <%--end highlighted block--%>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentHolder" runat="Server">
    <%--start highlighted block--%>
    <dx:ASPxHiddenField runat="server" ID="HiddenField" ClientInstanceName="HiddenField"></dx:ASPxHiddenField>
    <%--end highlighted block--%>
    <dx:ASPxFormLayout ID="FormLayout" runat="server" Width="800px" ColCount="2" UseDefaultPaddings="false">
        <Items>
            <dx:LayoutGroup ShowCaption="False" GroupBoxDecoration="None" Width="400px" UseDefaultPaddings="false" >
                <Items>
                    <dx:LayoutItem Caption="Description" CaptionSettings-Location="Top">
                        <LayoutItemNestedControlCollection>
                            <dx:LayoutItemNestedControlContainer>
                                <%--start highlighted block--%>
                                <dx:ASPxTextBox runat="server" ID="DescriptionTextBox" ClientInstanceName="DescriptionTextBox" NullText="Type some text..."
                                    Width="200px" EncodeHtml="true">
                                    <ValidationSettings Display="Dynamic" ErrorDisplayMode="Text" ErrorTextPosition="Bottom" ValidationGroup="DescriptionValidation">
                                        <RequiredField IsRequired="True" ErrorText="Description is required" />
                                    </ValidationSettings>
                                </dx:ASPxTextBox>
                                <%--end highlighted block--%>
                            </dx:LayoutItemNestedControlContainer>
                        </LayoutItemNestedControlCollection>
                    </dx:LayoutItem>
                    <dx:LayoutGroup Caption="Documents">
                        <Items>
                            <dx:LayoutItem ShowCaption="False">
                                <LayoutItemNestedControlCollection>
                                    <dx:LayoutItemNestedControlContainer>
                                        <div id="dropZone">
                                            <dx:ASPxUploadControl runat="server" ID="DocumentsUploadControl" ClientInstanceName="DocumentsUploadControl" Width="100%"
                                                AutoStartUpload="true" ShowProgressPanel="True" ShowTextBox="false" BrowseButton-Text="Add documents" FileUploadMode="OnPageLoad"
                                                OnFileUploadComplete="DocumentsUploadControl_FileUploadComplete">
                                                <AdvancedModeSettings
                                                    EnableMultiSelect="true" EnableDragAndDrop="true" ExternalDropZoneID="dropZone">
                                                </AdvancedModeSettings>
                                                <ValidationSettings
                                                    AllowedFileExtensions=".rtf, .pdf, .doc, .docx, .odt, .txt, .xls, .xlsx, .ods, .ppt, .pptx, .odp, .jpe, .jpeg, .jpg, .gif, .png"
                                                    MaxFileSize="4194304">
                                                </ValidationSettings>
                                                <ClientSideEvents
                                                    FileUploadComplete="onFileUploadComplete"
                                                    FilesUploadComplete="onFilesUploadComplete"
                                                    FilesUploadStart="onFileUploadStart" />
                                            </dx:ASPxUploadControl>
                                            <br />
                                            <%--start highlighted block--%>
                                            <dx:ASPxTokenBox runat="server" Width="100%" ID="UploadedFilesTokenBox" ClientInstanceName="UploadedFilesTokenBox"
                                                NullText="Select the documents to submit" AllowCustomTokens="false" ClientVisible="false">
                                                <ClientSideEvents Init="updateTokenBoxVisibility" ValueChanged="onTokenBoxValueChanged" Validation="onTokenBoxValidation" />
                                                <ValidationSettings EnableCustomValidation="true"></ValidationSettings>
                                            </dx:ASPxTokenBox>
                                            <%--end highlighted block--%>
                                            <br />
                                            <p class="Note">
                                                <dx:ASPxLabel ID="AllowedFileExtensionsLabel" runat="server" Text="Allowed file extensions: .jpg, .jpeg, .gif, .png." Font-Size="8pt">
                                                </dx:ASPxLabel>
                                                <br />
                                                <dx:ASPxLabel ID="MaxFileSizeLabel" runat="server" Text="Maximum file size: 4 MB." Font-Size="8pt">
                                                </dx:ASPxLabel>
                                            </p>
                                            <%--start highlighted block--%>
                                            <dx:ASPxValidationSummary runat="server" ID="ValidationSummary" ClientInstanceName="ValidationSummary"
                                                RenderMode="Table" Width="250px" ShowErrorAsLink="false">
                                            </dx:ASPxValidationSummary>
                                            <%--end highlighted block--%>
                                        </div>
                                    </dx:LayoutItemNestedControlContainer>
                                </LayoutItemNestedControlCollection>
                            </dx:LayoutItem>
                        </Items>
                    </dx:LayoutGroup>
                    <dx:LayoutItem ShowCaption="False" HorizontalAlign="Right">
                        <LayoutItemNestedControlCollection>
                            <dx:LayoutItemNestedControlContainer>
                                <%--start highlighted block--%>
                                <dx:ASPxButton runat="server" ID="SubmitButton" ClientInstanceName="SubmitButton" Text="Submit" AutoPostBack="False"
                                    OnClick="SubmitButton_Click" ValidateInvisibleEditors="true" ClientEnabled="false">
                                    <ClientSideEvents
                                        Init="onSubmitButtonInit" Click="onSubmitButtonClick" />
                                </dx:ASPxButton>
                                <%--end highlighted block--%>
                            </dx:LayoutItemNestedControlContainer>
                        </LayoutItemNestedControlCollection>
                    </dx:LayoutItem>
                </Items>
            </dx:LayoutGroup>
            <dx:LayoutGroup GroupBoxDecoration="None" ShowCaption="False" Name="ResultGroup" Visible="false" Width="400px" UseDefaultPaddings="false">
                <Items>
                    <dx:LayoutItem ShowCaption="False">
                        <LayoutItemNestedControlCollection>
                            <dx:LayoutItemNestedControlContainer>
                                <dx:ASPxRoundPanel ID="RoundPanel" runat="server" HeaderText="Uploaded files" Width="100%">
                                    <PanelCollection>
                                        <dx:PanelContent>
                                            <b>Description:</b>
                                            <dx:ASPxLabel runat="server" ID="DescriptionLabel"></dx:ASPxLabel>
                                            <br />
                                            <br />
                                            <dx:ASPxListBox ID="SubmittedFilesListBox" runat="server" Width="100%"  Height="150px">
                                                <ItemStyle CssClass="ResultFileName" />
                                                <Columns>
                                                    <dx:ListBoxColumn FieldName="OriginalFileName" />
                                                    <dx:ListBoxColumn FieldName="FileSize" Width="15%"/>
                                                </Columns>
                                            </dx:ASPxListBox>
                                        </dx:PanelContent>
                                    </PanelCollection>
                                </dx:ASPxRoundPanel>
                            </dx:LayoutItemNestedControlContainer>
                        </LayoutItemNestedControlCollection>
                    </dx:LayoutItem>
                </Items>
            </dx:LayoutGroup>
        </Items>
    </dx:ASPxFormLayout>
    <div class="contentFooter">
        <p class="Note">
            <b>Note</b>: All files uploaded to this demo will be automatically deleted in 5 minutes.
        </p>
    </div>
</asp:Content>
