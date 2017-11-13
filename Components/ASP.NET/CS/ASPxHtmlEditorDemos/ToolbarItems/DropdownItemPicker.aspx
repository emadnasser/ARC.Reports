<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="DropdownItemPicker.aspx.cs"
    Inherits="ToolbarItems_DropdownItemPicker" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
    <%--start highlighted block--%>
    <script type="text/javascript">
    // <![CDATA[
        function OnCommandExecute(s, e) {
            var value = e.parameter;
            switch (e.commandName) {
                case "InsertSmiley":
                    InsertSmiley(value);
                    break;
                case "InsertSpecialSymbol":
                    InsertSpecialSymbol(value);
                    break;
            }
        }
        function InsertSmiley(value) {
            var selection = HtmlEditor.GetSelection();
            var valueInfo = value.split("#");
            selection.SetHtml("<img style='margin-bottom:-2px;' src='../Content/Smilies/" + valueInfo[0] + ".png' alt='" + valueInfo[2] + "' title='" + valueInfo[1] + "' />");
        }
        function InsertSpecialSymbol(symbol) {
            var selection = HtmlEditor.GetSelection();
            selection.SetHtml(symbol);
        }
    // ]]> 
    </script>
    <%--end highlighted block--%>
    <dx:ASPxHtmlEditor ID="DemoHtmlEditor" runat="server" Height="350px" ClientInstanceName="HtmlEditor">
        <ClientSideEvents CustomCommand="OnCommandExecute" />
        <Toolbars>
            <dx:HtmlEditorToolbar>
                <Items>
                    <dx:ToolbarUndoButton>
                    </dx:ToolbarUndoButton>
                    <dx:ToolbarRedoButton>
                    </dx:ToolbarRedoButton>
                    <dx:ToolbarBoldButton BeginGroup="true">
                    </dx:ToolbarBoldButton>
                    <dx:ToolbarItalicButton>
                    </dx:ToolbarItalicButton>
                    <dx:ToolbarUnderlineButton>
                    </dx:ToolbarUnderlineButton>
                    <dx:ToolbarStrikethroughButton>
                    </dx:ToolbarStrikethroughButton>
                    <dx:ToolbarDropDownItemPicker BeginGroup="True" CommandName="InsertSmiley" SelectedItemIndex="0"
                        ImagePosition="Left" ToolTip="Insert Smiley" ColumnCount="4" ItemHeight="24"
                        ItemWidth="24" ClickMode="ExecuteSelectedItemAction">
                        <Items>
                            <dx:ToolbarItemPickerItem Image-Url="~/Content/Smilies/11.png" Value="11#Smile#:)"
                                ToolTip="Smile">
                            </dx:ToolbarItemPickerItem>
                            <dx:ToolbarItemPickerItem Image-Url="~/Content/Smilies/1.png" Value="1#Angry#:@"
                                ToolTip="Angry">
                            </dx:ToolbarItemPickerItem>
                            <dx:ToolbarItemPickerItem Image-Url="~/Content/Smilies/2.png" Value="2#Embarrassed#:$"
                                ToolTip="Embarrassed">
                            </dx:ToolbarItemPickerItem>
                            <dx:ToolbarItemPickerItem Image-Url="~/Content/Smilies/3.png" Value="3#Cool#H" ToolTip="Cool">
                            </dx:ToolbarItemPickerItem>
                            <dx:ToolbarItemPickerItem Image-Url="~/Content/Smilies/4.png" Value="4#Crying#:'("
                                ToolTip="Crying">
                            </dx:ToolbarItemPickerItem>
                            <dx:ToolbarItemPickerItem Image-Url="~/Content/Smilies/5.png" Value="5#Unsatisfied#=/"
                                ToolTip="Unsatisfied">
                            </dx:ToolbarItemPickerItem>
                            <dx:ToolbarItemPickerItem Image-Url="~/Content/Smilies/6.png" Value="6#Scared#6"
                                ToolTip="Scared">
                            </dx:ToolbarItemPickerItem>
                            <dx:ToolbarItemPickerItem Image-Url="~/Content/Smilies/7.png" Value="7#Angel#A" ToolTip="Angel">
                            </dx:ToolbarItemPickerItem>
                            <dx:ToolbarItemPickerItem Image-Url="~/Content/Smilies/8.png" Value="8#Big Smile#:D"
                                ToolTip="Big Smile">
                            </dx:ToolbarItemPickerItem>
                            <dx:ToolbarItemPickerItem Image-Url="~/Content/Smilies/9.png" Value="9#Kisses#:*"
                                ToolTip="Kisses">
                            </dx:ToolbarItemPickerItem>
                            <dx:ToolbarItemPickerItem Image-Url="~/Content/Smilies/10.png" Value="10#Sleep#|-)"
                                ToolTip="Sleep">
                            </dx:ToolbarItemPickerItem>
                            <dx:ToolbarItemPickerItem Image-Url="~/Content/Smilies/12.png" Value="12#Sad#:("
                                ToolTip="Sad">
                            </dx:ToolbarItemPickerItem>
                            <dx:ToolbarItemPickerItem Image-Url="~/Content/Smilies/13.png" Value="13#Surprise#:O"
                                ToolTip="Surprise">
                            </dx:ToolbarItemPickerItem>
                            <dx:ToolbarItemPickerItem Image-Url="~/Content/Smilies/14.png" Value="14#Stick out tongue#:P"
                                ToolTip="Stick out tongue">
                            </dx:ToolbarItemPickerItem>
                            <dx:ToolbarItemPickerItem Image-Url="~/Content/Smilies/15.png" Value="15#Huh?#:^"
                                ToolTip="Huh?">
                            </dx:ToolbarItemPickerItem>
                            <dx:ToolbarItemPickerItem Image-Url="~/Content/Smilies/16.png" Value="16#Wink#;)"
                                ToolTip="Wink">
                            </dx:ToolbarItemPickerItem>
                        </Items>
                    </dx:ToolbarDropDownItemPicker>
                    <dx:ToolbarDropDownItemPicker CommandName="InsertSpecialSymbol" ClickMode="ShowDropDown"
                        ColumnCount="6" ToolTip="Insert Special Symbol" ItemHeight="34" ItemWidth="34">
                        <Image Width="16px" Height="16px">
                        </Image>
                        <Items>
                            <dx:ToolbarItemPickerItem Value="&alpha;" Text="&alpha;" ToolTip="Greek small letter alpha">
                            </dx:ToolbarItemPickerItem>
                            <dx:ToolbarItemPickerItem Value="&beta;" Text="&beta;" ToolTip="Greek small letter beta">
                            </dx:ToolbarItemPickerItem>
                            <dx:ToolbarItemPickerItem Value="&pi;" Text="&pi;" ToolTip="Greek small letter pi">
                            </dx:ToolbarItemPickerItem>
                            <dx:ToolbarItemPickerItem Value="&rho;" Text="&rho;" ToolTip="Greek small letter rho">
                            </dx:ToolbarItemPickerItem>
                            <dx:ToolbarItemPickerItem Value="&phi;" Text="&phi;" ToolTip="Greek small letter phi">
                            </dx:ToolbarItemPickerItem>
                            <dx:ToolbarItemPickerItem Value="&Omega;" Text="&Omega;" ToolTip="Omega sign">
                            </dx:ToolbarItemPickerItem>
                            <dx:ToolbarItemPickerItem Value="&pound;" Text="&pound;" ToolTip="Pound">
                            </dx:ToolbarItemPickerItem>
                            <dx:ToolbarItemPickerItem Value="&cent;" Text="&cent;" ToolTip="Cent">
                            </dx:ToolbarItemPickerItem>
                            <dx:ToolbarItemPickerItem Value="&yen;" Text="&yen;" ToolTip="Yen">
                            </dx:ToolbarItemPickerItem>
                            <dx:ToolbarItemPickerItem Value="&euro;" Text="&euro;" ToolTip="Euro">
                            </dx:ToolbarItemPickerItem>
                            <dx:ToolbarItemPickerItem Value="&fnof;" Text="&fnof;" ToolTip="Latin small f with hook">
                            </dx:ToolbarItemPickerItem>
                            <dx:ToolbarItemPickerItem Value="&alefsym;" Text="&alefsym;" ToolTip="Alef symbol">
                            </dx:ToolbarItemPickerItem>
                            <dx:ToolbarItemPickerItem Value="&copy;" Text="&copy;" ToolTip="Copyright sign">
                            </dx:ToolbarItemPickerItem>
                            <dx:ToolbarItemPickerItem Value="&reg;" Text="&reg;" ToolTip="Registered sign">
                            </dx:ToolbarItemPickerItem>
                            <dx:ToolbarItemPickerItem Value="&trade;" Text="&trade;" ToolTip="Trademark sign">
                            </dx:ToolbarItemPickerItem>
                            <dx:ToolbarItemPickerItem Value="&deg;" Text="&deg;" ToolTip="Degree sign">
                            </dx:ToolbarItemPickerItem>
                            <dx:ToolbarItemPickerItem Value="&mdash;" Text="&mdash;" ToolTip="Em dash">
                            </dx:ToolbarItemPickerItem>
                            <dx:ToolbarItemPickerItem Value="&plusmn;" Text="&plusmn;" ToolTip="Plus-minus sign">
                            </dx:ToolbarItemPickerItem>
                            <dx:ToolbarItemPickerItem Value="&frac14;" Text="&frac14;" ToolTip="Common fraction one quarter">
                            </dx:ToolbarItemPickerItem>
                            <dx:ToolbarItemPickerItem Value="&frac12;" Text="&frac12;" ToolTip="Common fraction one half">
                            </dx:ToolbarItemPickerItem>
                            <dx:ToolbarItemPickerItem Value="&frac34;" Text="&frac34;" ToolTip="Common fraction three quarters">
                            </dx:ToolbarItemPickerItem>
                            <dx:ToolbarItemPickerItem Value="&sum;" Text="&sum;" ToolTip="N-ary summation">
                            </dx:ToolbarItemPickerItem>
                            <dx:ToolbarItemPickerItem Value="&radic;" Text="&radic;" ToolTip="Square root">
                            </dx:ToolbarItemPickerItem>
                            <dx:ToolbarItemPickerItem Value="&infin;" Text="&infin;" ToolTip="Infinity">
                            </dx:ToolbarItemPickerItem>
                        </Items>
                    </dx:ToolbarDropDownItemPicker>
                </Items>
            </dx:HtmlEditorToolbar>
        </Toolbars>
        <StylesEditors>
            <DropDownItemPickerItemStyle Font-Size="20px">
            </DropDownItemPickerItemStyle>
        </StylesEditors>
    </dx:ASPxHtmlEditor>
</asp:Content>
