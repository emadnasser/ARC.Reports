<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="ContextTabs.aspx.cs" Inherits="Ribbon_ContextTabs" %>
<asp:Content ContentPlaceHolderID="CustomHeadHolder" runat="server">
        <style type="text/css">
        .container {
            vertical-align: top;
            border-right: 1px solid #c8ccd1;
            border-bottom: 1px solid #c8ccd1;
            padding: 50px;
            background: url(Images/editor.png) no-repeat;
            text-align: center;
        }
        .EditorWindow,
        .EditorWindow .dxpc-contentWrapper {
            border: none!important;
        }
        .categoryItem {
            width: 40%;
            background: #F4F4F4;
        }
        .categoryItemChecked {
            background: #DBDBDB;
        }
        .hintItem {
            margin-bottom: 15px;
        }
    </style>
    <%--start highlighted block--%>
    <script type="text/javascript">
        function onWindowResize(s, e) {
            ribbon.AdjustControl();
        }
        function onCheckedChanged(active, categoryName) {
            ribbon.SetContextTabCategoryVisible(categoryName, active);            
        }
    </script>
    <%--end highlighted block--%>
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
    <div id="PopupPlaceHolder" style="height: 420px; margin-top: 10px;"></div>
    <dx:ASPxPopupControl ID="ASPxPopupControl" runat="server" ClientInstanceName="pc" ShowShadow="false" CssClass="EditorWindow"
        AllowResize="true" AllowDragging="false" CloseAction="None" ShowSizeGrip="True" PopupAction="None"
        ShowFooter="True" ShowHeader="false" PopupElementID="PopupPlaceHolder"
        PopupAlignCorrection="Disabled" PopupAnimationType="None" ShowOnPageLoad="true"
        MaxWidth="900px" MinWidth="300px" Width="809px" MaxHeight="1" MinHeight="1" Height="1"
        FooterText="" FooterStyle-HorizontalAlign="Right">
        <ContentStyle Paddings-Padding="0" >
<Paddings Padding="0px"></Paddings>
        </ContentStyle>
        <ClientSideEvents AfterResizing="onWindowResize" />
<FooterStyle HorizontalAlign="Right"></FooterStyle>
        <ContentCollection>
            <dx:PopupControlContentControl>
                <table id="editor" style="width:100%;">
                    <tr style="height: 1px">
                        <td>
                            <dx:ASPxRibbon ID="ASPxRibbon" runat="server" ClientInstanceName="ribbon" BackColor="White" Width="100%">
                                <Tabs>
                                    <dx:RibbonTab Name="Home" Text="Home" >
                                        <Groups>
                                            <dx:RibbonGroup Name="Clipboard" Text="Clipboard" ShowDialogBoxLauncher="true">
                                                <Image IconID="reports_report_32x32"></Image>
                                                <Items>
                                                    <dx:RibbonDropDownButtonItem Name="Paste" Text="Paste" Size="Large">
                                                        <Items>
                                                            <dx:RibbonDropDownButtonItem Name="Paste" Text="Paste">
                                                                <SmallImage IconID="actions_insert_16x16">
                                                                </SmallImage>
                                                            </dx:RibbonDropDownButtonItem>
                                                            <dx:RibbonDropDownButtonItem Name="Paste special" Text="Paste special">
                                                                <SmallImage IconID="actions_insert_16x16">
                                                                </SmallImage>
                                                            </dx:RibbonDropDownButtonItem>
                                                        </Items>
                                                        <LargeImage IconID="actions_insert_32x32">
                                                        </LargeImage>
                                                    </dx:RibbonDropDownButtonItem>
                                                    <dx:RibbonButtonItem Name="Cut" Text="Cut">
                                                        <SmallImage IconID="edit_cut_16x16">
                                                        </SmallImage>
                                                    </dx:RibbonButtonItem>
                                                    <dx:RibbonButtonItem Name="Copy" Text="Copy">
                                                        <SmallImage IconID="actions_merge_16x16">
                                                        </SmallImage>
                                                    </dx:RibbonButtonItem>
                                                    <dx:RibbonButtonItem Name="Clear" Text="Clear">
                                                        <SmallImage IconID="actions_clear_16x16">
                                                        </SmallImage>
                                                    </dx:RibbonButtonItem>
                                                </Items>
                                            </dx:RibbonGroup>
                                            <dx:RibbonGroup Name="Font" Text="Font" ShowDialogBoxLauncher="true">
                                                <Image IconID="alignment_contentautoarrange_32x32"></Image>
                                                <Items>
                                                    <dx:RibbonComboBoxItem Name="Font Family">
                                                        <PropertiesComboBox NullText="Font Family"></PropertiesComboBox>
                                                        <Items>
                                                            <dx:ListEditItem Text="Arial" Value="Arial" />
                                                            <dx:ListEditItem Text="Times New Roman" Value="Times New Roman" />
                                                            <dx:ListEditItem Text="Calibri" Value="Calibri" />
                                                            <dx:ListEditItem Text="Verdana" Value="Verdana" />
                                                        </Items>
                                                    </dx:RibbonComboBoxItem>
                                                    <dx:RibbonComboBoxItem Name="Font Size">
                                                        <PropertiesComboBox NullText="Font Size"></PropertiesComboBox>
                                                        <Items>
                                                            <dx:ListEditItem Text="10" Value="10" />
                                                            <dx:ListEditItem Text="11" Value="11" />
                                                            <dx:ListEditItem Text="12" Value="12" />
                                                            <dx:ListEditItem Text="14" Value="14" />
                                                            <dx:ListEditItem Text="16" Value="16" />
                                                            <dx:ListEditItem Text="18" Value="18" />
                                                        </Items>
                                                    </dx:RibbonComboBoxItem>
                                                    <dx:RibbonButtonItem Name="Increase Size">
                                                        <SmallImage IconID="format_fontsizeincrease_16x16">
                                                        </SmallImage>
                                                    </dx:RibbonButtonItem>
                                                    <dx:RibbonButtonItem Name="Decrease Size">
                                                        <SmallImage IconID="format_fontsizedecrease_16x16">
                                                        </SmallImage>
                                                    </dx:RibbonButtonItem>
                                                    <dx:RibbonButtonItem Name="Hidden Text">
                                                        <SmallImage IconID="format_hiddentext_16x16">
                                                        </SmallImage>
                                                    </dx:RibbonButtonItem>
                                                    <dx:RibbonToggleButtonItem Name="Bold">
                                                        <SmallImage IconID="format_bold_16x16">
                                                        </SmallImage>
                                                    </dx:RibbonToggleButtonItem>
                                                    <dx:RibbonToggleButtonItem Name="Italic">
                                                        <SmallImage IconID="format_italic_16x16">
                                                        </SmallImage>
                                                    </dx:RibbonToggleButtonItem>
                                                    <dx:RibbonToggleButtonItem Name="Underline">
                                                        <SmallImage IconID="format_underline_16x16">
                                                        </SmallImage>
                                                    </dx:RibbonToggleButtonItem>
                                                    <dx:RibbonToggleButtonItem Name="Strikeout">
                                                        <SmallImage IconID="format_strikeout_16x16">
                                                        </SmallImage>
                                                    </dx:RibbonToggleButtonItem>
                                                    <dx:RibbonToggleButtonItem Name="Subscript">
                                                        <SmallImage IconID="format_subscript_16x16">
                                                        </SmallImage>
                                                    </dx:RibbonToggleButtonItem>
                                                    <dx:RibbonToggleButtonItem Name="Superscript">
                                                        <SmallImage IconID="format_superscript_16x16">
                                                        </SmallImage>
                                                    </dx:RibbonToggleButtonItem>
                                                    <dx:RibbonColorButtonItem Name="Highlight Color">
                                                        <SmallImage IconID="format_highlightfield_16x16">
                                                        </SmallImage>
                                                    </dx:RibbonColorButtonItem>
                                                    <dx:RibbonColorButtonItem Name="Font Color">
                                                        <SmallImage IconID="format_changefontstyle_16x16">
                                                        </SmallImage>
                                                    </dx:RibbonColorButtonItem>                                                  
                                                </Items>
                                            </dx:RibbonGroup>
                                            <dx:RibbonGroup Name="Paragraph" Text="Paragraph" ShowDialogBoxLauncher="true">
                                                <Image IconID="format_showhidden_32x32"></Image>
                                                <Items>
                                                    <dx:RibbonButtonItem Name="Bullets">
                                                        <SmallImage IconID="format_listbullets_16x16">
                                                        </SmallImage>
                                                    </dx:RibbonButtonItem>
                                                    <dx:RibbonButtonItem Name="Numbering">
                                                        <SmallImage IconID="format_listnumbers_16x16">
                                                        </SmallImage>
                                                    </dx:RibbonButtonItem>
                                                    <dx:RibbonButtonItem Name="Multilevel List">
                                                        <SmallImage IconID="format_listmultilevel_16x16">
                                                        </SmallImage>
                                                    </dx:RibbonButtonItem>
                                                    <dx:RibbonButtonItem Name="Decrease Indent">
                                                        <SmallImage IconID="format_indentdecrease_16x16">
                                                        </SmallImage>
                                                    </dx:RibbonButtonItem>
                                                    <dx:RibbonButtonItem Name="Increase Indent">
                                                        <SmallImage IconID="format_indentincrease_16x16">
                                                        </SmallImage>
                                                    </dx:RibbonButtonItem>
                                                    <dx:RibbonButtonItem Name="Sort">
                                                        <SmallImage IconID="data_sortasc_16x16">
                                                        </SmallImage>
                                                    </dx:RibbonButtonItem>
                                                    <dx:RibbonButtonItem Name="Hidden Symbols">
                                                        <SmallImage IconID="format_showhidden_16x16">
                                                        </SmallImage>
                                                    </dx:RibbonButtonItem>
                                                    <dx:RibbonOptionButtonItem Name="Align Left" OptionGroupName="Align">
                                                        <SmallImage IconID="format_alignleft_16x16">
                                                        </SmallImage>
                                                    </dx:RibbonOptionButtonItem>
                                                    <dx:RibbonOptionButtonItem Name="Align Center" OptionGroupName="Align">
                                                        <SmallImage IconID="format_aligncenter_16x16">
                                                        </SmallImage>
                                                    </dx:RibbonOptionButtonItem>
                                                    <dx:RibbonOptionButtonItem Name="Align Right" OptionGroupName="Align">
                                                        <SmallImage IconID="format_alignright_16x16">
                                                        </SmallImage>
                                                    </dx:RibbonOptionButtonItem>
                                                    <dx:RibbonOptionButtonItem Name="Align Justify" OptionGroupName="Align">
                                                        <SmallImage IconID="format_alignjustify_16x16">
                                                        </SmallImage>
                                                    </dx:RibbonOptionButtonItem>
                                                    <dx:RibbonColorButtonItem Name="Shading">
                                                        <SmallImage IconID="format_pictureshapefillcolor_16x16">
                                                        </SmallImage>
                                                    </dx:RibbonColorButtonItem>
                                                </Items>
                                            </dx:RibbonGroup>
                                            <dx:RibbonGroup Name="Editing" Text="Editing" ShowDialogBoxLauncher="true">
                                                <Image IconID="edit_customization_32x32"></Image>
                                                <Items>
                                                    <dx:RibbonDropDownButtonItem Name="Find" Text="Find">
                                                        <Items>
                                                            <dx:RibbonDropDownButtonItem Name="Find" Text="Find">
                                                                <SmallImage IconID="find_find_16x16">
                                                                </SmallImage>
                                                            </dx:RibbonDropDownButtonItem>
                                                            <dx:RibbonDropDownButtonItem Name="Go To" Text="Go To">
                                                                <SmallImage IconID="arrows_next_16x16">
                                                                </SmallImage>
                                                            </dx:RibbonDropDownButtonItem>
                                                        </Items>
                                                        <SmallImage IconID="find_find_16x16">
                                                        </SmallImage>
                                                    </dx:RibbonDropDownButtonItem>
                                                    <dx:RibbonButtonItem Name="Replace" Text="Replace">
                                                        <SmallImage IconID="format_replace_16x16">
                                                        </SmallImage>
                                                    </dx:RibbonButtonItem>
                                                </Items>
                                            </dx:RibbonGroup>
                                        </Groups>
                                    </dx:RibbonTab>
                                    <dx:RibbonTab Name="Insert" Text="Insert">
                                        <Groups>
                                            <dx:RibbonGroup Name="Tables" Text="Tables" ShowDialogBoxLauncher="true">
                                                <Items>
                                                    <dx:RibbonDropDownButtonItem Name="Table" Size="Large" Text="Table">
                                                        <Items>
                                                            <dx:RibbonDropDownButtonItem Name="Insert Table" Text="Insert Table">
                                                                <SmallImage IconID="grid_cards_16x16">
                                                                </SmallImage>
                                                            </dx:RibbonDropDownButtonItem>
                                                            <dx:RibbonDropDownButtonItem Name="Draw Table" Text="Draw Table">
                                                                <SmallImage IconID="grid_customizegrid_16x16">
                                                                </SmallImage>
                                                            </dx:RibbonDropDownButtonItem>
                                                            <dx:RibbonDropDownButtonItem Name="Quick Table" Text="Quick Table">
                                                                <SmallImage IconID="grid_grid_16x16">
                                                                </SmallImage>
                                                            </dx:RibbonDropDownButtonItem>
                                                        </Items>
                                                        <LargeImage IconID="grid_cards_32x32">
                                                        </LargeImage>
                                                    </dx:RibbonDropDownButtonItem>
                                                </Items>
                                            </dx:RibbonGroup>
                                            <dx:RibbonGroup Name="Illustrations" Text="Illustrations" ShowDialogBoxLauncher="true">
                                                <Items>
                                                    <dx:RibbonButtonItem Name="Picture" Size="Large" Text="Picture">
                                                        <LargeImage IconID="content_image_32x32">
                                                        </LargeImage>
                                                    </dx:RibbonButtonItem>                                                   
                                                </Items>
                                            </dx:RibbonGroup>
                                            <dx:RibbonGroup Name="Charts" Text="Charts" ShowDialogBoxLauncher="true">
                                                <Items>
                                                    <dx:RibbonButtonItem Name="Bar">
                                                        <SmallImage IconID="chart_bar_16x16">
                                                        </SmallImage>
                                                    </dx:RibbonButtonItem>
                                                    <dx:RibbonButtonItem Name="Bubble">
                                                        <SmallImage IconID="chart_bubble_16x16">
                                                        </SmallImage>
                                                    </dx:RibbonButtonItem>
                                                    <dx:RibbonButtonItem Name="Chart">
                                                        <SmallImage IconID="chart_chart_16x16">
                                                        </SmallImage>
                                                    </dx:RibbonButtonItem>
                                                    <dx:RibbonButtonItem Name="Drill Down">
                                                        <SmallImage IconID="chart_drilldownonseries_chart_16x16">
                                                        </SmallImage>
                                                    </dx:RibbonButtonItem>
                                                    <dx:RibbonButtonItem Name="Full Stacked Bar">
                                                        <SmallImage IconID="chart_fullstackedbar_16x16">
                                                        </SmallImage>
                                                    </dx:RibbonButtonItem>
                                                    <dx:RibbonButtonItem Name="Full Stacked Line">
                                                        <SmallImage IconID="chart_fullstackedline_16x16">
                                                        </SmallImage>
                                                    </dx:RibbonButtonItem>
                                                    <dx:RibbonButtonItem Name="Pie Style Donut">
                                                        <SmallImage IconID="chart_piestyledonut_16x16">
                                                        </SmallImage>
                                                    </dx:RibbonButtonItem>
                                                    <dx:RibbonButtonItem Name="Chart Line">
                                                        <SmallImage IconID="chart_line_16x16">
                                                        </SmallImage>
                                                    </dx:RibbonButtonItem>
                                                    <dx:RibbonButtonItem Name="Candle Chart">
                                                        <SmallImage IconID="chart_openhighlowclosecandlestick_16x16">
                                                        </SmallImage>
                                                    </dx:RibbonButtonItem>
                                                    <dx:RibbonButtonItem Name="Stock Chart">
                                                        <SmallImage IconID="chart_openhighlowclosestock_16x16">
                                                        </SmallImage>
                                                    </dx:RibbonButtonItem>
                                                </Items>
                                            </dx:RibbonGroup>
                                            <dx:RibbonGroup Text="Gauges">
                                                <Image IconID="gauges_gaugestylethreeforthcircular_32x32"/>
                                                <Items>
                                                     <dx:RibbonGalleryBarItem Name="Gauges" MaxColumnCount="3" MaxTextWidth="80" AllowSelectItem="false">
                                                         <PropertiesDropDownGallery RowCount="3" ShowGroupText="false" />
                                                         <Groups>
                                                             <dx:RibbonGalleryGroup>
                                                                 <Items>
                                                                     <dx:RibbonGalleryItem Text="Full Circular" Value="Full Circular" ToolTip="Full Circular">
                                                                         <Image IconID="gauges_gaugestylefullcircular_32x32">
                                                                        </Image>
                                                                     </dx:RibbonGalleryItem>
                                                                     <dx:RibbonGalleryItem Text="Half Circular" Value="Half Circular" ToolTip="Half Circular">
                                                                         <Image IconID="gauges_gaugestylehalfcircular_32x32">
                                                                        </Image>
                                                                     </dx:RibbonGalleryItem>
                                                                     <dx:RibbonGalleryItem Text="Quarter Circular" Value="Quarter Circular" ToolTip="Quarter Circular">
                                                                         <Image IconID="gauges_gaugestyleleftquartercircular_32x32">
                                                                        </Image>
                                                                     </dx:RibbonGalleryItem>
                                                                     <dx:RibbonGalleryItem Text="Linear Horizontal" Value="Linear Horizontal" ToolTip="Linear Horizontal">
                                                                         <Image IconID="gauges_gaugestylelinearhorizontal_32x32">
                                                                        </Image>
                                                                     </dx:RibbonGalleryItem>
                                                                     <dx:RibbonGalleryItem Text="Linear Vertical" Value="Linear Vertical" ToolTip="Linear Vertical">
                                                                         <Image IconID="gauges_gaugestylelinearvertical_32x32">
                                                                        </Image>
                                                                     </dx:RibbonGalleryItem>
                                                                     <dx:RibbonGalleryItem Text="Right Quarter Circular" Value="Right Quarter Circular" ToolTip="Right Quarter Circular">
                                                                         <Image IconID="gauges_gaugestylerightquartercircular_32x32">
                                                                        </Image>
                                                                     </dx:RibbonGalleryItem>
                                                                     <dx:RibbonGalleryItem Text="Three Forth Circular" Value="Three Forth Circular" ToolTip="Three Forth Circular">
                                                                         <Image IconID="gauges_gaugestylethreeforthcircular_32x32">
                                                                        </Image>
                                                                     </dx:RibbonGalleryItem>
                                                                 </Items>
                                                             </dx:RibbonGalleryGroup>
                                                         </Groups>
                                                    </dx:RibbonGalleryBarItem>
                                                </Items>
                                            </dx:RibbonGroup>
                                        </Groups>
                                    </dx:RibbonTab>
                                    <dx:RibbonTab Name="View" Text="View">
                                        <Groups>
                                            <dx:RibbonGroup Name="Zoom" Text="Zoom" ShowDialogBoxLauncher="true">
                                                <Items>
                                                    <dx:RibbonButtonItem Name="Zoom" Size="Large" Text="Zoom">
                                                        <LargeImage IconID="zoom_zoom_32x32">
                                                        </LargeImage>
                                                    </dx:RibbonButtonItem>
                                                    <dx:RibbonButtonItem Name="Zoom In">
                                                        <SmallImage IconID="zoom_zoomin_16x16">
                                                        </SmallImage>
                                                    </dx:RibbonButtonItem>
                                                    <dx:RibbonButtonItem Name="Zoom Out">
                                                        <SmallImage IconID="zoom_zoomout_16x16">
                                                        </SmallImage>
                                                    </dx:RibbonButtonItem>
                                                </Items>
                                            </dx:RibbonGroup>
                                            <dx:RibbonGroup Name="Fullscreen" Text="Fullscreen" ShowDialogBoxLauncher="true">
                                                <Items>
                                                    <dx:RibbonButtonItem Size="Large" Name="FullScreen">
                                                        <LargeImage IconID="scheduling_snaptocells_32x32">
                                                        </LargeImage>
                                                    </dx:RibbonButtonItem>
                                                </Items>
                                            </dx:RibbonGroup>
                                            <dx:RibbonGroup Name="Settings" Text="Settings" ShowDialogBoxLauncher="true">
                                                <Items>
                                                    <dx:RibbonDropDownButtonItem Size="Large" DropDownMode="false">
                                                        <LargeImage IconID="setup_properties_32x32">
                                                        </LargeImage>
                                                        <Items>
                                                            <dx:RibbonDropDownToggleButtonItem Name="WordWrap" Text="Word Wrap">
                                                            </dx:RibbonDropDownToggleButtonItem>                                                        
                                                            <dx:RibbonDropDownToggleButtonItem Name="NonprintingCharacters" Text="Nonprinting Characters">
                                                            <SmallImage IconID="format_showhidden_16x16"></SmallImage>
                                                            </dx:RibbonDropDownToggleButtonItem>
                                                        </Items>
                                                    </dx:RibbonDropDownButtonItem>
                                                </Items>
                                            </dx:RibbonGroup>
                                        </Groups>
                                    </dx:RibbonTab>
                                </Tabs>
                                <ContextTabCategories>
                                    <dx:RibbonContextTabCategory Name="Picture tools" Color="#d31313" ClientVisible="true">
                                        <Tabs>
                                            <dx:RibbonTab Name="Format" Text="Format">
                                                <Groups>
                                                    <dx:RibbonGroup Text="Adjust">
                                                        <Items>
                                                            <dx:RibbonButtonItem Text="Fill background" Name="FillBackground" Size="Large">
                                                                <LargeImage IconID="format_fillbackground_32x32"></LargeImage>
                                                                <SmallImage IconID="format_fillbackground_16x16"></SmallImage>
                                                            </dx:RibbonButtonItem>
                                                            <dx:RibbonColorButtonItem Name="ImageBackgroundColor" Text="Color">
                                                                <SmallImage IconID="format_highlightfield_16x16">
                                                                </SmallImage>
                                                            </dx:RibbonColorButtonItem>
                                                        </Items>
                                                    </dx:RibbonGroup>
                                                    <dx:RibbonGroup Text="Arrage">
                                                        <Items>
                                                            <dx:RibbonGalleryDropDownItem Name="ImagePosition" Text="Position" Size="Large">
                                                                <PropertiesDropDownGallery ShowGroupText="false" ColumnCount="3" RowCount="3"/>
                                                                <LargeImage IconID="arrange_withtextwrapping_topcenter_32x32"></LargeImage>
                                                                <Groups>
                                                                    <dx:RibbonGalleryGroup>
                                                                        <Items>
                                                                            <dx:RibbonGalleryItem>
                                                                                <Image IconID="arrange_withtextwrapping_topleft_32x32"></Image>
                                                                            </dx:RibbonGalleryItem>
                                                                            <dx:RibbonGalleryItem>
                                                                                <Image IconID="arrange_withtextwrapping_topcenter_32x32"></Image>
                                                                            </dx:RibbonGalleryItem>
                                                                            <dx:RibbonGalleryItem>
                                                                                <Image IconID="arrange_withtextwrapping_topright_32x32"></Image>
                                                                            </dx:RibbonGalleryItem>
                                                                            <dx:RibbonGalleryItem>
                                                                                <Image IconID="arrange_withtextwrapping_centerleft_32x32"></Image>
                                                                            </dx:RibbonGalleryItem>
                                                                            <dx:RibbonGalleryItem>
                                                                                <Image IconID="arrange_withtextwrapping_centercenter_32x32"></Image>
                                                                            </dx:RibbonGalleryItem>
                                                                            <dx:RibbonGalleryItem>
                                                                                <Image IconID="arrange_withtextwrapping_centerright_32x32"></Image>
                                                                            </dx:RibbonGalleryItem>
                                                                            <dx:RibbonGalleryItem>
                                                                                <Image IconID="arrange_withtextwrapping_bottomleft_32x32"></Image>
                                                                            </dx:RibbonGalleryItem>
                                                                            <dx:RibbonGalleryItem>
                                                                                <Image IconID="arrange_withtextwrapping_bottomcenter_32x32"></Image>
                                                                            </dx:RibbonGalleryItem>
                                                                            <dx:RibbonGalleryItem>
                                                                                <Image IconID="arrange_withtextwrapping_bottomright_32x32"></Image>
                                                                            </dx:RibbonGalleryItem>
                                                                        </Items>
                                                                    </dx:RibbonGalleryGroup>
                                                                </Groups>
                                                            </dx:RibbonGalleryDropDownItem>
                                                            <dx:RibbonButtonItem Name="Bring forward" Text="Bring forward" Size="Small">
                                                                <SmallImage IconID="arrange_bringforward_16x16"></SmallImage>
                                                            </dx:RibbonButtonItem>
                                                            <dx:RibbonButtonItem Name="Send backward" Text="Send backward" Size="Small">
                                                                <SmallImage IconID="arrange_sendbackward_16x16"></SmallImage>
                                                            </dx:RibbonButtonItem>
                                                        </Items>
                                                    </dx:RibbonGroup>
                                                </Groups>
                                            </dx:RibbonTab>
                                        </Tabs>
                                    </dx:RibbonContextTabCategory>
                                    <dx:RibbonContextTabCategory Name="Table tools" Color="#17a300" ClientVisible="true">
                                        <Tabs>
                                            <dx:RibbonTab Text="Design">
                                                <Groups>
                                                     <dx:RibbonGroup Text="Arrage">
                                                         <Items>
                                                             <dx:RibbonCheckBoxItem Text="Header Row"></dx:RibbonCheckBoxItem>
                                                             <dx:RibbonCheckBoxItem Text="Total Row"></dx:RibbonCheckBoxItem>
                                                             <dx:RibbonCheckBoxItem Text="Banded Rows"></dx:RibbonCheckBoxItem>
                                                             <dx:RibbonCheckBoxItem Text="First Column"></dx:RibbonCheckBoxItem>
                                                             <dx:RibbonCheckBoxItem Text="Last Column"></dx:RibbonCheckBoxItem>
                                                             <dx:RibbonCheckBoxItem Text="Banded Columns"></dx:RibbonCheckBoxItem>
                                                         </Items>
                                                     </dx:RibbonGroup>
                                                    <dx:RibbonGroup Text="Styles">
                                                        <Items>
                                                            <dx:RibbonColorButtonItem Name="Shading" Text="Shading" Size="Large">
                                                                <LargeImage IconID="format_pictureshapefillcolor_32x32"></LargeImage>
                                                            </dx:RibbonColorButtonItem>
                                                        </Items>
                                                    </dx:RibbonGroup>
                                                </Groups>
                                            </dx:RibbonTab>
                                            <dx:RibbonTab Text="Layout">
                                                <Groups>
                                                    <dx:RibbonGroup Text="Table">
                                                        <Items>
                                                            <dx:RibbonDropDownButtonItem Name="Grid Select" Text="Select" Size="Large">
                                                                <LargeImage IconID="pdfviewer_selecttool_32x32"></LargeImage>
                                                                <SmallImage IconID="pdfviewer_selecttool_16x16"></SmallImage>
                                                                <Items>
                                                                    <dx:RibbonDropDownButtonItem Text="Select Cell"></dx:RibbonDropDownButtonItem>
                                                                    <dx:RibbonDropDownButtonItem Text="Select Row"></dx:RibbonDropDownButtonItem>
                                                                    <dx:RibbonDropDownButtonItem Text="Select Column"></dx:RibbonDropDownButtonItem>
                                                                    <dx:RibbonDropDownButtonItem Text="Select Table"></dx:RibbonDropDownButtonItem>
                                                                </Items>
                                                            </dx:RibbonDropDownButtonItem>
                                                            <dx:RibbonButtonItem Name="View Gridlines" Text="View Gridlines" Size="Large">
                                                                <LargeImage IconID="toolboxitems_table_32x32"></LargeImage>
                                                                <SmallImage IconID="toolboxitems_table_16x16"></SmallImage>
                                                            </dx:RibbonButtonItem>
                                                            <dx:RibbonButtonItem Name="Grid Properties" Text="Properties" Size="Large">
                                                                <LargeImage IconID="spreadsheet_format_32x32"></LargeImage>
                                                                <SmallImage IconID="spreadsheet_format_16x16"></SmallImage>
                                                            </dx:RibbonButtonItem>                                                            
                                                        </Items>
                                                    </dx:RibbonGroup>
                                                    <dx:RibbonGroup Text="Cell Size">
                                                        <Items>
                                                            <dx:RibbonButtonItem Name="AutoFit Grid" Text="AutoFit" Size="Large">
                                                                <LargeImage IconID="grid_autofittogrid_32x32"></LargeImage>
                                                                <SmallImage IconID="grid_autofittogrid_16x16"></SmallImage>
                                                            </dx:RibbonButtonItem>
                                                            <dx:RibbonSpinEditItem Name="Cell Height" Text="Height"></dx:RibbonSpinEditItem>
                                                            <dx:RibbonSpinEditItem Name="Cell Width" Text="Width"></dx:RibbonSpinEditItem>
                                                        </Items>
                                                    </dx:RibbonGroup>
                                                     <dx:RibbonGroup Text="Aligment">
                                                         <Image IconID="format_aligncenter_32x32"></Image>
                                                        <Items>
                                                            <dx:RibbonOptionButtonItem  Name="Align left" Size="Small" SubGroupName="GridAligment" OptionGroupName="GridAligment">
                                                                <SmallImage IconID="format_alignleft_16x16"></SmallImage>
                                                            </dx:RibbonOptionButtonItem>
                                                            <dx:RibbonOptionButtonItem  Name="Align center" Size="Small" SubGroupName="GridAligment" OptionGroupName="GridAligment">
                                                                <SmallImage IconID="format_aligncenter_16x16"></SmallImage>
                                                            </dx:RibbonOptionButtonItem>
                                                            <dx:RibbonOptionButtonItem  Name="Align right" Size="Small" SubGroupName="GridAligment" OptionGroupName="GridAligment">
                                                                <SmallImage IconID="format_alignright_16x16"></SmallImage>
                                                            </dx:RibbonOptionButtonItem>
                                                        </Items>
                                                    </dx:RibbonGroup>
                                                </Groups>
                                            </dx:RibbonTab>
                                        </Tabs>
                                    </dx:RibbonContextTabCategory>
                                </ContextTabCategories>
                            </dx:ASPxRibbon>
                        </td>
                    </tr>
                    <tr>
                        <td class="container" id="container">
                            <div class="hintItem">Click the 'Image' and 'Table' buttons in the client region to show/hide ribbon context tabs.</div>
                            <dx:ASPxButton ID="ASPxButton1" runat="server" EnableTheming="false" AutoPostBack="false" GroupName="G1" CssClass="categoryItem"
                                CheckedStyle-CssClass="categoryItemChecked" ToolTip="Image" Checked="true">
                                <Image IconID="content_image_32x32"></Image>
                                <ClientSideEvents CheckedChanged="function(s, e) { onCheckedChanged(s.GetChecked(), 'Picture tools'); }" />
                            </dx:ASPxButton>
                            <dx:ASPxButton ID="ASPxButton2" runat="server" EnableTheming="false" AutoPostBack="false" GroupName="G2" CssClass="categoryItem"
                                CheckedStyle-CssClass="categoryItemChecked" ToolTip="Table" Checked="true">
                                <Image IconID="grid_grid_32x32"></Image>
                                <ClientSideEvents CheckedChanged="function(s, e) { onCheckedChanged(s.GetChecked(), 'Table tools'); }" />
                            </dx:ASPxButton>
                        </td>
                    </tr>
                </table>
            </dx:PopupControlContentControl>
        </ContentCollection>
    </dx:ASPxPopupControl>
</asp:Content>
