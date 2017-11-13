<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeFile="MultipleInvokerElements.aspx.cs" Inherits="PopupControl_MultipleInvokerElements" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
    <%--start highlighted block--%>
    <script type="text/javascript">
        var imagesInfo={
            img1: { src: "Images/InvokerElements/1_large.jpg",description: "image 1",width: "380",height: "252" },
            img2: { src: "Images/InvokerElements/2_large.jpg",description: "image 2",width: "380",height: "252" },
            img3: { src: "Images/InvokerElements/3_large.jpg",description: "image 3",width: "380",height: "252" },
            img4: { src: "Images/InvokerElements/4_large.jpg",description: "image 4",width: "380",height: "252" }
        };
        function popup_Popup(s, e) {
            var popupElement = s.GetCurrentPopupElement(); // popupElement is <img /> tag
            var info = imagesInfo[popupElement.id];
            var lowQualityImage = document.getElementById("lowQualityImage");
            var highQualityImage = document.createElement("IMG");
            var highQualityImageWrapper = document.getElementById("highQualityImageWrapper");
            highQualityImageWrapper.innerHTML = "";
            highQualityImageWrapper.appendChild(highQualityImage);
            highQualityImageWrapper.style.marginTop = "-" + info.height + "px";
            highQualityImageWrapper.style.width = info.width + "px";
            highQualityImageWrapper.style.height = info.height + "px";
            lowQualityImage.src = popupElement.src;
            lowQualityImage.width = info.width;
            lowQualityImage.height = info.height;
            lowQualityImage.alt = info.description;
            
            highQualityImage.width = info.width;
            highQualityImage.height = info.height;
            highQualityImage.src = info.src;
            highQualityImage.alt = info.description;
            s.UpdatePosition();
        }
    </script>
    <%--end highlighted block--%>
    <div class="imageContainer">
        <img id="img1" src="Images/InvokerElements/1.jpg" alt="image 1" />
        <img id="img2" src="Images/InvokerElements/2.jpg" alt="image 2" />
        <img id="img3" src="Images/InvokerElements/3.jpg" alt="image 3" />
        <img id="img4" src="Images/InvokerElements/4.jpg" alt="image 4" />
    </div>
    <span class="description">To invoke a popup window, move the mouse cursor over one of the thumbnail images.</span>
    <dx:ASPxPopupControl ID="popup" runat="server" ClientInstanceName="popup" PopupElementID="img1;img2;img3;img4"
        EnableViewState="false" ShowHeader="false" PopupAnimationType="None" PopupHorizontalAlign="Center"
        PopupVerticalAlign="Below" PopupAction="MouseOver" CloseAction="MouseOut" PopupVerticalOffset="10"
        AppearAfter="0" DisappearAfter="0" BackColor="#2A3333">
        <ContentCollection>
            <dx:PopupControlContentControl>
                <img id="lowQualityImage" src="Images/InvokerElements/1_large.jpg" alt="" />
                <div id="highQualityImageWrapper"></div>
            </dx:PopupControlContentControl>
        </ContentCollection>
        <ContentStyle BackColor="#2A3333" Paddings-Padding="8" />
        <Border BorderStyle="None" />
        <ClientSideEvents PopUp="popup_Popup" />
    </dx:ASPxPopupControl>
</asp:Content>
