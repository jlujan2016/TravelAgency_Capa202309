System.register(["./p-364478bb.system.js"],(function(e){"use strict";var t,i,n,s,o;return{setters:[function(e){t=e.r;i=e.c;n=e.h;s=e.H;o=e.g}],execute:function(){var r=':host(:not([hidden])){display:contents}:host(:is(:not([modal]),[modal="false"])) .mask{pointer-events:none}.window{pointer-events:all}.mask{display:-ms-flexbox;display:flex;position:fixed;inset:0;z-index:var(--ch-window-mask-z-index, 1000)}:host(:is([x-align="outside-start"],[x-align="inside-start"])) .mask{-ms-flex-pack:start;justify-content:flex-start}:host([x-align=center]) .mask{-ms-flex-pack:center;justify-content:center}:host(:is([x-align="outside-end"],[x-align="inside-end"])) .mask{-ms-flex-pack:end;justify-content:flex-end}:host(:is([y-align="outside-start"],[y-align="inside-start"])) .mask{-ms-flex-align:start;align-items:flex-start}:host([y-align=center]) .mask{-ms-flex-align:center;align-items:center}:host(:is([y-align="outside-end"],[y-align="inside-end"])) .mask{-ms-flex-align:end;align-items:flex-end}.window{display:-ms-flexbox;display:flex;-ms-flex-direction:column;flex-direction:column;-webkit-transform:translate(var(--ch-window-x-outside, 0px), var(--ch-window-y-outside, 0px)) translate(var(--ch-window-x-drag, 0px), var(--ch-window-y-drag, 0px));transform:translate(var(--ch-window-x-outside, 0px), var(--ch-window-y-outside, 0px)) translate(var(--ch-window-x-drag, 0px), var(--ch-window-y-drag, 0px))}:host([x-align=outside-start]) .window{--ch-window-x-outside:-100%}:host([x-align=outside-end]) .window{--ch-window-x-outside:100%}:host([y-align=outside-start]) .window{--ch-window-y-outside:-100%}:host([y-align=outside-end]) .window{--ch-window-y-outside:100%}';var a=e("ch_window",function(){function e(e){var n=this;t(this,e);this.windowOpened=i(this,"windowOpened",7);this.windowClosed=i(this,"windowClosed",7);this.xAlign="center";this.yAlign="center";this.hidden=true;this.modal=true;this.caption="";this.allowDrag="no";this.isContainerCssOverride=false;this.validCssAligns=["outside-start","inside-start","center","inside-end","outside-end"];this.draggedX=0;this.draggedY=0;this.mousemoveHandler=function(e){var t=n.draggedX+e.clientX-n.dragStartX;var i=n.draggedY+e.clientY-n.dragStartY;n.window.style.setProperty("--ch-window-x-drag",t+"px");n.window.style.setProperty("--ch-window-y-drag",i+"px")};this.mouseupHandler=function(){document.removeEventListener("mousemove",n.mousemoveHandler);n.draggedX=parseInt(n.window.style.getPropertyValue("--ch-window-x-drag"));n.draggedY=parseInt(n.window.style.getPropertyValue("--ch-window-y-drag"))};this.maskClickHandler=function(e){e.stopPropagation()};this.updatePosition=function(){if(!n.isContainerCssOverride&&n.container&&n.mask){var e=n.container.getBoundingClientRect();n.mask.style.setProperty("inset-inline-start",e.left+"px");n.mask.style.setProperty("inset-block-start",e.top+"px");n.mask.style.width=e.width+"px";n.mask.style.height=e.height+"px"}else if(n.isContainerCssOverride||!n.container){n.mask.style.removeProperty("inset-inline-start");n.mask.style.removeProperty("inset-block-start");n.mask.style.removeProperty("width");n.mask.style.removeProperty("height")}}}e.prototype.componentWillLoad=function(){this.containerResizeObserver=new ResizeObserver(this.updatePosition);this.containerResizeObserverHandler(this.container);this.watchCSSAlign()};e.prototype.containerHandler=function(e,t){this.containerResizeObserverHandler(e,t);this.updatePosition()};e.prototype.hiddenHandler=function(){if(this.hidden){this.resetDrag();this.windowClosed.emit()}else{this.updatePosition();this.windowOpened.emit()}};e.prototype.windowResizeHandler=function(){this.watchCSSAlign()};e.prototype.documentClickHandler=function(e){if(this.closeOnOutsideClick&&!e.composedPath().includes(this.window)){this.hidden=true}};e.prototype.documentKeyDownHandler=function(e){if(!this.hidden&&this.closeOnEscape&&e.key==="Escape"){this.hidden=true}};e.prototype.windowScrollHandler=function(){if(this.container){this.updatePosition()}};e.prototype.mousedownHandler=function(e){if(this.isDraggable(e.composedPath())){this.dragStartX=e.clientX;this.dragStartY=e.clientY;document.addEventListener("mousemove",this.mousemoveHandler,{passive:true});document.addEventListener("mouseup",this.mouseupHandler,{once:true})}};e.prototype.windowCloseClickedHandler=function(){this.hidden=true};e.prototype.resetDrag=function(){this.dragStartX=undefined;this.dragStartY=undefined;this.draggedX=0;this.draggedY=0;this.window.style.removeProperty("--ch-window-x-drag");this.window.style.removeProperty("--ch-window-y-drag")};e.prototype.isDraggable=function(e){return this.allowDrag!=="no"&&(this.allowDrag==="header"&&e.includes(this.header)||this.allowDrag==="box"&&e.includes(this.window))};e.prototype.watchCSSAlign=function(){var e=getComputedStyle(this.el);var t=e.getPropertyValue("--ch-window-container").trim();var i=e.getPropertyValue("--ch-window-x-align").trim();var n=e.getPropertyValue("--ch-window-y-align").trim();this.isContainerCssOverride=t.includes("window")?true:false;if(this.validCssAligns.includes(i)){this.xAlign=i}if(this.validCssAligns.includes(n)){this.yAlign=n}};e.prototype.containerResizeObserverHandler=function(e,t){if(e){this.containerResizeObserver.observe(e)}if(t){this.containerResizeObserver.unobserve(t)}};e.prototype.render=function(){var e=this;return n(s,null,n("div",{class:"mask",part:"mask",ref:function(t){return e.mask=t},onClick:this.maskClickHandler},n("section",{class:"window",part:"window",ref:function(t){return e.window=t}},n("header",{part:"header",ref:function(t){return e.header=t}},n("slot",{name:"header"},n("span",{part:"caption"},this.caption),n("ch-window-close",{part:"close",title:this.closeTooltip},this.closeText))),n("main",{part:"main"},n("slot",null)),n("footer",{part:"footer"},n("slot",{name:"footer"})))))};Object.defineProperty(e.prototype,"el",{get:function(){return o(this)},enumerable:false,configurable:true});Object.defineProperty(e,"watchers",{get:function(){return{container:["containerHandler"],hidden:["hiddenHandler"]}},enumerable:false,configurable:true});return e}());a.style=r;var d="";var l=e("ch_window_close",function(){function e(e){var n=this;t(this,e);this.windowCloseClicked=i(this,"windowCloseClicked",7);this.handleClick=function(e){e.stopPropagation();n.windowCloseClicked.emit()}}e.prototype.render=function(){return n(s,{role:"button",tabindex:"0",disabled:this.disabled,onClick:this.handleClick})};return e}());l.style=d}}}));