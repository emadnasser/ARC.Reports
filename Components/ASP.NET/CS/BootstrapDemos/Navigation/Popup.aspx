<%@ Page Title="" Language="C#" MasterPageFile="~/Shared/DemoLayout.master" AutoEventWireup="true" CodeFile="Popup.aspx.cs" Inherits="Navigation_Popup" %>
<asp:Content ID="PageTitleHolder" ContentPlaceHolderID="PageTitle" runat="server">
    Bootstrap Popup Dialog Demo | DevExpress Bootstrap controls for ASP.NET
</asp:Content>
<asp:Content ID="PageHeaderHolder" ContentPlaceHolderID="PageHeader" runat="server">
    DevExpress Bootstrap Popup
</asp:Content>
<asp:Content ID="ContentHolder" ContentPlaceHolderID="Content" runat="server">
    <div class="col-md-9">
        <demo:DemoItem runat="server" Title="Default Popup Control">
            <Description>
                <p>The Popup Control is used to display overlaping temporary windows that appear separately from an application's main window, and are typically used to display quick reference information. By default, the Popup controls display a header with a <strong>Close</strong> button and the popup body with the specified content.</p>
            </Description>
            <Example>
                <div id="default-popup-control-1" class="popup-target popup-target-sm"></div>
                <dx:BootstrapPopupControl runat="server" ID="PopupControl1" ShowOnPageLoad="true" PopupElementID="default-popup-control-1" 
                    PopupHorizontalAlign="Center" PopupVerticalAlign="Middle" Width="500px" CloseAction="CloseButton">
                    <ContentCollection>
                        <dx:PopupControlContentControl>
                            <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris sit amet metus vel nisi blandit tincidunt vel efficitur purus. Nunc nec turpis tempus, accumsan orci auctor, imperdiet mauris. Fusce id purus magna.</p>
                        </dx:PopupControlContentControl>
                    </ContentCollection>
                </dx:BootstrapPopupControl>
            </Example>
            <CodeASPX>&lt;dx:BootstrapPopupControl runat="server" ID="PopupControl1" ShowOnPageLoad="true" 
    PopupHorizontalAlign="Center" PopupVerticalAlign="Middle" CloseAction="CloseButton"&gt;
    &lt;ContentCollection&gt;
        &lt;dx:PopupControlContentControl&gt;
            &lt;p&gt;Lorem ipsum dolor sit amet...&lt;/p&gt;
        &lt;/dx:PopupControlContentControl&gt;
    &lt;/ContentCollection&gt;
&lt;/dx:BootstrapPopupControl></CodeASPX>
        </demo:DemoItem>
        <demo:DemoItem runat="server" Title="Header And Footer">
            <Description>
                <p>To specify whether or not to display the Popup Control’s header and footer, use the <strong>ShowHeader</strong> and <strong>ShowFooter</strong> properties. To specify the header and footer text, set the <strong>HeaderText</strong> and <strong>FooterText</strong> respectively.</p>
            </Description>
            <Example>
                <div id="default-popup-control-2" class="popup-target"></div>
                <dx:BootstrapPopupControl runat="server" ID="PopupControl2" ShowOnPageLoad="true" PopupElementID="default-popup-control-2" 
                    PopupHorizontalAlign="Center" PopupVerticalAlign="Middle" Width="500px" CloseAction="CloseButton" ShowFooter="true" ShowHeader="true" 
                    HeaderText="Header text" FooterText="Footer text">
                    <ContentCollection>
                        <dx:PopupControlContentControl>
                            <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris sit amet metus vel nisi blandit tincidunt vel efficitur purus. Nunc nec turpis tempus, accumsan orci auctor, imperdiet mauris. Fusce id purus magna.</p>
                        </dx:PopupControlContentControl>
                    </ContentCollection>
                </dx:BootstrapPopupControl>
            </Example>
            <CodeASPX>&lt;dx:BootstrapPopupControl runat="server" ID="PopupControl2" ShowOnPageLoad="true"
    PopupHorizontalAlign="Center" PopupVerticalAlign="Middle" CloseAction="CloseButton" ShowFooter="true" ShowHeader="true" HeaderText="Header text" FooterText="Footer text"&gt;
    &lt;ContentCollection&gt;
        &lt;dx:PopupControlContentControl&gt;
            ...
        &lt;/dx:PopupControlContentControl&gt;
    &lt;/ContentCollection&gt;
&lt;/dx:BootstrapPopupControl&gt;</CodeASPX>
        </demo:DemoItem>
        <demo:DemoItem runat="server" Title="Dragging">
            <Description>
                <p>The Popup Control can be dragged within the bounds of the client browser's window. To enable this functionality, set the <strong>AllowDragging</strong> property to <strong>true</strong>.</p>
            </Description>
            <Example>
                <div id="default-popup-control-3" class="popup-target popup-target-sm"></div>
                <dx:BootstrapPopupControl runat="server" ID="PopupControl3" ShowOnPageLoad="true" PopupElementID="default-popup-control-3" 
                    PopupHorizontalAlign="Center" PopupVerticalAlign="Middle" Width="500px" CloseAction="CloseButton" AllowDragging="true">
                    <ContentCollection>
                        <dx:PopupControlContentControl>
                            <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris sit amet metus vel nisi blandit tincidunt vel efficitur purus. Nunc nec turpis tempus, accumsan orci auctor, imperdiet mauris. Fusce id purus magna.</p>
                        </dx:PopupControlContentControl>
                    </ContentCollection>
                </dx:BootstrapPopupControl>
            </Example>
            <CodeASPX>&lt;dx:BootstrapPopupControl runat="server" ID="PopupControl3" ShowOnPageLoad="true" 
    PopupHorizontalAlign="Center" PopupVerticalAlign="Middle" CloseAction="CloseButton" AllowDragging="true"&gt;
    &lt;ContentCollection&gt;
        &lt;dx:PopupControlContentControl&gt;
            ...
        &lt;/dx:PopupControlContentControl&gt;
    &lt;/ContentCollection&gt;
&lt;/dx:BootstrapPopupControl></CodeASPX>
        </demo:DemoItem>
        <demo:DemoItem runat="server" Title="Resizing">
            <Description>
                <p>The Popup Control supports resizing. To enable this feature, set the <strong>AllowResize</strong> property to <strong>true</strong>. A popup window's size limits can be specified via the <strong>MinHeight</strong>, <strong>MinWidth</strong>, <strong>MaxHeight</strong>, and <strong>MaxWidth</strong> properties.</p>
            </Description>
            <Example>
                <div id="default-popup-control-4" class="popup-target popup-target-sm"></div>
                <dx:BootstrapPopupControl runat="server" ID="PopupControl4" ShowOnPageLoad="true" PopupElementID="default-popup-control-4" 
                    PopupHorizontalAlign="Center" PopupVerticalAlign="Middle" Width="500px" CloseAction="CloseButton" AllowResize="true">
                    <ContentCollection>
                        <dx:PopupControlContentControl>
                            <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris sit amet metus vel nisi blandit tincidunt vel efficitur purus. Nunc nec turpis tempus, accumsan orci auctor, imperdiet mauris. Fusce id purus magna.</p>
                        </dx:PopupControlContentControl>
                    </ContentCollection>
                </dx:BootstrapPopupControl>
            </Example>
            <CodeASPX>&lt;dx:BootstrapPopupControl runat="server" ID="PopupControl4" ShowOnPageLoad="true" PopupElementID="default-popup-control-4" 
    PopupHorizontalAlign="Center" PopupVerticalAlign="Middle" CloseAction="CloseButton" AllowResize="true"&gt;
    &lt;ContentCollection&gt;
        &lt;dx:PopupControlContentControl&gt;
            ...
        &lt;/dx:PopupControlContentControl&gt;
    &lt;/ContentCollection&gt;
&lt;/dx:BootstrapPopupControl&gt;</CodeASPX>
        </demo:DemoItem>
        <demo:DemoItem runat="server" Title="Modal Mode">
            <Description>
                <p>In the modal mode, when the popup window is displayed, the Popup Control prohibits interactions with the parent page. To enable the modal mode, set the <strong>Modal</strong> property to <strong>true</strong>. </p>
            </Description>
            <Example>
                <div id="default-popup-control-5" class="popup-target popup-target-sm"></div>
                <dx:BootstrapPopupControl runat="server" ID="PopupControl5" PopupElementID="default-popup-control-5" 
                    PopupHorizontalAlign="WindowCenter" PopupVerticalAlign="WindowCenter" Width="500px" CloseAction="CloseButton" Modal="true">
                    <ContentCollection>
                        <dx:PopupControlContentControl>
                            <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris sit amet metus vel nisi blandit tincidunt vel efficitur purus. Nunc nec turpis tempus, accumsan orci auctor, imperdiet mauris. Fusce id purus magna.</p>
                        </dx:PopupControlContentControl>
                    </ContentCollection>
                </dx:BootstrapPopupControl>
            </Example>
            <CodeASPX>&lt;dx:BootstrapPopupControl runat="server" ID="PopupControl5" ShowOnPageLoad="true" PopupElementID="default-popup-control-4" 
    PopupHorizontalAlign="WindowCenter" PopupVerticalAlign="WindowCenter" CloseAction="CloseButton" Modal="true"&gt;
    &lt;ContentCollection&gt;
        &lt;dx:PopupControlContentControl&gt;
            ...
        &lt;/dx:PopupControlContentControl&gt;
    &lt;/ContentCollection&gt;
&lt;/dx:BootstrapPopupControl&gt;</CodeASPX>
        </demo:DemoItem>
        <demo:DemoItem runat="server" Title="Animation Types">
            <Description>
                <p>The Popup Control can be displayed and closed with one of two available animations: <strong>Fade</strong> and <strong>Slide</strong>. To specify the animation type for these actions, specify the <strong>PopupAnimationType</strong> and <strong>CloseAnimationType</strong> properties.</p>
            </Description>
            <Example>
                <div class="row popup-target-group">
                    <div class="col-md-6 text-center">
                        <div id="default-popup-control-6" class="popup-target popup-target-sm">
                            <h5>Fade animation</h5>
                        </div>
                    </div>
                    <div class="col-md-6 text-center">
                        <div id="default-popup-control-7" class="popup-target popup-target-sm">
                            <h5>Slide animation</h5>
                        </div>
                    </div>
                </div>
                <dx:BootstrapPopupControl runat="server" ID="BootstrapPopupControl5" PopupElementID="default-popup-control-6" PopupAnimationType="Fade" CloseAnimationType="Fade">
                    <ContentCollection>
                        <dx:PopupControlContentControl>
                            <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris sit amet metus vel nisi blandit tincidunt vel efficitur purus.</p>
                        </dx:PopupControlContentControl>
                    </ContentCollection>
                </dx:BootstrapPopupControl>
                <dx:BootstrapPopupControl runat="server" ID="PopupControl6" PopupElementID="default-popup-control-7" PopupAnimationType="Slide" CloseAnimationType="Slide">
                    <ContentCollection>
                        <dx:PopupControlContentControl>
                            <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris sit amet metus vel nisi blandit tincidunt vel efficitur purus.</p>
                        </dx:PopupControlContentControl>
                    </ContentCollection>
                </dx:BootstrapPopupControl>
            </Example>
            <CodeASPX>&lt;dx:BootstrapPopupControl runat="server" ID="PopupControl6" PopupAnimationType="Fade" CloseAnimationType="Fade"&gt;
    ...
&lt;/dx:BootstrapPopupControl&gt;
&lt;dx:BootstrapPopupControl runat="server" PopupAnimationType="Slide" CloseAnimationType="Slide"&gt;
    ...
&lt;/dx:BootstrapPopupControl&gt;</CodeASPX>
        </demo:DemoItem>
    </div>
    <div class="col-md-3">
        <div class="affix page-nav" id="page-navigation">
        </div>
    </div>
</asp:Content>
