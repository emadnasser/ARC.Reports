<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.master" CodeFile="CommandsAPI.aspx.cs" Inherits="API_CommandsAPI" %>
<asp:Content runat="server" ContentPlaceHolderID="CustomHeadHolder">
    <script type="text/javascript">
        <%--start highlighted block--%>
        var steps = [
            function () { DemoRichEdit.commands.insertText.execute("Hello! This is new RichEdit API") },
            function () { DemoRichEdit.selection.selectAll() },
            function () { DemoRichEdit.commands.delete.execute() },
            function () { DemoRichEdit.commands.insertText.execute("Now you can do more.") },
            function () { DemoRichEdit.commands.insertParagraph.execute() },
            function () { DemoRichEdit.commands.insertText.execute("You can ") },
            function () { DemoRichEdit.commands.changeFontFormatting.execute({ bold: true, foreColor: "#789" }) },
            function () { DemoRichEdit.commands.insertText.execute("format text...") },
            function () { DemoRichEdit.commands.insertParagraph.execute() },
            function () { DemoRichEdit.commands.insertText.execute("and whole paragraphs") },
            function () { DemoRichEdit.commands.toggleParagraphAlignmentCenter.execute(true) },
            function () { DemoRichEdit.commands.insertParagraph.execute() },
            function () { DemoRichEdit.commands.toggleParagraphAlignmentCenter.execute(false) },
            function () { DemoRichEdit.commands.insertHeader.execute() },
            function () { DemoRichEdit.commands.insertText.execute("Insert headers...") },
            function () { DemoRichEdit.commands.closeHeaderFooter.execute() },
            function () { DemoRichEdit.selection.goToDocumentEnd() },
            function () { DemoRichEdit.commands.insertParagraph.execute() },
            function () { DemoRichEdit.commands.toggleBulletedList.execute() },
            function () { DemoRichEdit.commands.insertText.execute("and numbering lists ") },
            function () { DemoRichEdit.commands.insertParagraph.execute() },
            function () { DemoRichEdit.commands.toggleBulletedList.execute() },
            function () { DemoRichEdit.commands.insertTable.execute(2, 3) },
            function () { DemoRichEdit.commands.insertText.execute("and tables ") },
            function () { DemoRichEdit.selection.goToDocumentEnd() },
            function () { DemoRichEdit.commands.insertText.execute("and fields: ") },
            function () { DemoRichEdit.commands.createDateField.execute() },
            function () { DemoRichEdit.selection.selectAll() },
            function () { DemoRichEdit.commands.delete.execute() },
            function () { DemoRichEdit.commands.insertText.execute("Become a UI Superhero") },
            function () { DemoRichEdit.commands.insertParagraph.execute() },
            function () { DemoRichEdit.commands.insertPicture.execute("../Content/ui.png") },
        ];
        <%--end highlighted block--%>
        var currentStep = 0,
            currentTimer = -1;
        function startDemo() {
            var nextStep = function () {
                var step = steps[currentStep++];
                if (step) {
                    DXLogger.executeAndLog(step);
                    currentTimer = setTimeout(nextStep, 500);
                }
            };
            nextStep();
        }
        function restartDemo() {
            clearTimeout(currentTimer);
            currentStep = 0;
            DXLogger.executeAndLog(function () { DemoRichEdit.commands.fileNew.execute() });
        }
    </script>
</asp:Content>
<asp:Content ID="Content" ContentPlaceHolderID="ContentHolder" runat="server">
    <div style="padding-bottom: 10px; text-align: right">
        <dx:ASPxButton runat="server" ID="ASPxButton1" AutoPostBack="false" Text="Restart Demonstration">
            <ClientSideEvents Click="restartDemo" />
            <Image iconid="actions_refresh_16x16">
            </Image>
        </dx:ASPxButton>
    </div>
    <dx:ASPxRichEdit ID="DemoRichEdit" runat="server" ClientInstanceName="DemoRichEdit" Width="100%" ShowConfirmOnLosingChanges="false" RibbonMode="OneLineRibbon">
        <ClientSideEvents EndCallback="startDemo" Init="startDemo" />
    </dx:ASPxRichEdit>
    <textarea id="Logger" readonly="readonly" class="Logger"></textarea>
</asp:Content>
