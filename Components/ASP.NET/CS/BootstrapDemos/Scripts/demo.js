/// <reference path="jquery-3.1.1.min.js" />
/// <reference path="URI.js" />
(function() {
    var dxBootstrapDemo = {};
    dxBootstrapDemo.themeCookieKey = "DXBSCurrentTheme";

    dxBootstrapDemo.initialize = function() {
        activateDemoCode();
        initPageNav();
        if(window.top !== window)
            ASPxClientUtils.AttachEventToElement(window.top, 'popstate', dxBootstrapDemo.onHistoryPopState);
    };

    dxBootstrapDemo.setTheme = function(theme) {
        if(!(theme && theme.length))
            return;
        
        $(window.top.document.body).fadeOut(200, function() {
            var containerLinkElement = $(window.top.document).find('[id$="containerLink"]');
            containerLinkElement.attr("href", "../Content/container.css");
            var containerThemeLinkElement = $(window.top.document).find('[id$="themeContainerLink"]');
            containerThemeLinkElement.attr("href", "../Content/" + theme + "/container.css");

            var themeLinkElement = $(window.document).find('[id$="themeLink"]');
            themeLinkElement.attr("href", "../Content/" + theme + "/bootstrap.min.css");
            var themeSiteLinkElement = $(window.document).find('[id$="themeSiteLink"]');
            themeSiteLinkElement.attr("href", "../Content/" + theme + "/site.css");

            $(window.top.document.body).fadeIn(300);
        });
        this.setCookie(this.themeCookieKey, theme);
    };
    dxBootstrapDemo.setResolution = function(resolution) {
        if(!resolution) return;
        if(window == window.top)
            document.location = URI(document.location.href).addQuery("resolution", resolution).toString();
        else if(resolution === "Default")
            window.top.document.location = URI(window.top.document.location.href).removeQuery("resolution").toString();
        else {
            dxBootstrapDemo.setFrameResolution(resolution);
            var url = URI(window.top.document.location.href).setQuery("resolution", resolution).toString();
            window.top.history.pushState({ resolution: resolution }, resolution, url);
        }
    };
    dxBootstrapDemo.onHistoryPopState = function(evt) {
        if(!window || window.top === window) return;
        var resolution = URI(window.top.document.location.href).query(true)["resolution"];
        if(resolution)
            dxBootstrapDemo.setFrameResolution(resolution)
    };
    dxBootstrapDemo.setFrameResolution = function(resolution) {
        var demoContainer = $(window.top.document).find(".demoContainer");
        demoContainer.removeClass("TabletLandscape TabletPortrait MobileLandscape MobilePortrait").addClass(resolution);
        dxBootstrapDemo.updateNodesWithResolution(BSDemoTree.GetRootNode(), resolution);
    };
    dxBootstrapDemo.updateNodesWithResolution = function(parent, resolution) {
        var count = parent.GetNodeCount();
        for(var i = 0; i < count; i++) {
            var node = parent.GetNode(i);
            var navigateUrl = node.GetNavigateUrl();
            node.SetNavigateUrl(URI(navigateUrl).setQuery("resolution", resolution));
            dxBootstrapDemo.updateNodesWithResolution(node, resolution);
        }
    };

    dxBootstrapDemo.onKeyDown = function(evt, demoWindow) {
        if(!demoWindow || evt.keyCode !== 116) return;

        demoWindow.location.reload();
        evt.returnValue = false;
    };

    dxBootstrapDemo.onTopMenuItemClick = function(s, e) {
        var item = e.item;
        switch(item.parent.name) {
            case "Themes":
                dxBootstrapDemo.setTheme(item.name);
                break;
            case "Resolution":
                dxBootstrapDemo.setResolution(item.name);
                break;
            default:
                break;
        }
    }
    dxBootstrapDemo.onTopMenuInit = function(s, e) {
        if(window == window.top)
            return;
        var resolution = URI(window.top.location.href).query(true)["resolution"];
        if(!resolution)
            return;
        var resItem = s.GetItemByName("Resolution");
        var itemCount = resItem.GetItemCount();
        for(var i = 0; i < itemCount; i++) {
            var item = resItem.GetItem(i);
            if(item.name === resolution)
                item.SetChecked(true);
            else
                item.SetChecked(false);
        }
    }

    dxBootstrapDemo.setCookie = function(name, value) {
        var date = new Date();
        date.setTime(date.getTime() + (365 * 24 * 60 * 60 * 1000));
        document.cookie = name + '=' + value + '; expires=' + date.toGMTString() + '; path=/';
    }
    dxBootstrapDemo.getCookie = function(name) {
        var value = document.cookie.match('(^|;) ?' + name + '=([^;]*)(;|$)');
        return value ? value[2] : null;
    }

    var dbCreateTimer = -1,
        dbCreateProgressTimer = -1,
        dbCreateContainer = null,
        dbCreator = {};

    dbCreator.onCreateDbButtonClick = function(s, e) {
        dbCreateContainer = s.GetMainElement().parentNode;
        $(dbCreateContainer).find(".message").text("Creating Database...");
        s.SetVisible(false);
        progressBar.SetVisible(true);
        
        createDbCallback.PerformCallback("create");
        dbCreateProgressTimer = window.setInterval(function() {
            createDbCallback.PerformCallback("getRecordCount");
        }.bind(dxBootstrapDemo.dbCreator), 1000);
    };
    dbCreator.onCallbackComplete = function(s, e) { 
        if(e.parameter == "create") {
            window.clearTimeout(dbCreateTimer);
            if(eval(e.result)) {
                window.clearInterval(dbCreateProgressTimer);
                document.location.reload();
            } else
                dbCreateTimer = window.setTimeout(function() { createDbCallback.PerformCallback("create") }, 1000);
        }
        else if (e.parameter == "getRecordCount") {
            progressBar.SetValue(Math.round(e.result));
        }
    };
    dbCreator.onCallbackError = function(s, e) {
        e.handled = true;
        window.clearInterval(this.progressTimer);
        alert(e.message);
        document.location.reload();
    };
    dxBootstrapDemo.dbCreator = dbCreator;

    function activateDemoCode() {
        $(".code").each(function() {
            $code = $(this);
            var $buttons = $code.find("button[data-code]");
            var $pres = $code.find("pre[data-code]");
            $buttons.each(function() {
                var codeType = $(this).attr("data-code");
                $(this).click(function() {
                    $buttons.each(function() {
                        $(this).toggleClass("active", $(this).attr("data-code") === codeType);
                    });
                    $pres.each(function() {
                        $(this).toggleClass("hidden", $(this).attr("data-code") !== codeType);
                    });
                });
            });
            new Clipboard($code.find(".btn-copy").get(0), {
                text: function() {
                    return $pres.filter(function() { return !$(this).hasClass("hidden") }).text();
                }
            });
        });
    }

    function initPageNav() {
        var $headers = $("#page-wrapper > div > div > h2");
        var $navParent = $("#page-navigation");
        if(!$navParent.length || $headers.length < 2)
            return;
        var $ul = $('<ul class="nav nav-pills nav-stacked"></ul>').appendTo($navParent);
        $headers.each(function() {
            var title = $(this).text();
            var id = title.toLowerCase().replace(/\s/g, "-").replace(/\,/g, "");
            $('<li></li>').append($('<a href="#' + id + '">' + title + '</a>')).appendTo($ul);
        });
        $('body').scrollspy({ target: '#page-navigation', offset: 80 });
    }

    $(document).ready(function() {
        dxBootstrapDemo.initialize();
        $('.qrcode').qrcode({ width: 128, height: 128, text: "<%# DemoUtils.QRCodeImageUrl %>" });
    });
    hljs.initHighlightingOnLoad();

    window.dxBootstrapDemo = dxBootstrapDemo;
})();