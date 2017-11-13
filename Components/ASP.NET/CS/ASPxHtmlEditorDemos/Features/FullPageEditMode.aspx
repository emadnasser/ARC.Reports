<%@ Page Language="C#" AutoEventWireup="true" CodeFile="FullPageEditMode.aspx.cs"
    Inherits="Features_FullPageEditMode" MasterPageFile="~/Site.master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
    <script type="text/javascript">
        function onDemoHtmlEditorActiveTabChanged(s, e) {
            if (e.name === "HTML")
                s.ExecuteCommand(ASPxClientCommandConsts.FORMATDOCUMENT_COMMAND, null);
        }
    </script>
    <dx:ASPxHtmlEditor runat="server" ID="DemoHtmlEditor" ActiveView="Html">
        <ClientSideEvents ActiveTabChanged="onDemoHtmlEditorActiveTabChanged" />
        <Settings ShowTagInspector="true">
            <SettingsHtmlView EnableAutoCompletion="true" EnableTagAutoClosing="true" HighlightActiveLine="true"
                HighlightMatchingTags="true" ShowCollapseTagButtons="true" ShowLineNumbers="true" />
        </Settings>
        <SettingsHtmlEditing AllowedDocumentType="HTML5" AllowEditFullDocument="True" AllowFormElements="True"
            AllowHTML5MediaElements="True" AllowIFrames="True" AllowObjectAndEmbedElements="True"
            AllowScripts="True" AllowYouTubeVideoIFrames="True" EnablePasteOptions="True"
            EnterMode="BR" PasteMode="MergeFormatting" ResourcePathMode="RootRelative">
        </SettingsHtmlEditing>
        <Shortcuts>
            <dx:HtmlEditorShortcut ActionName="comment" Shortcut="Ctrl+K" ActionView="Html" />
            <dx:HtmlEditorShortcut ActionName="uncomment" Shortcut="Ctrl+Shift+K" ActionView="Html" />
        </Shortcuts>
    </dx:ASPxHtmlEditor>
</asp:Content>
