var __spreadArrays=this&&this.__spreadArrays||function(){for(var e=0,t=0,n=arguments.length;t<n;t++)e+=arguments[t].length;for(var r=Array(e),i=0,t=0;t<n;t++)for(var o=arguments[t],s=0,l=o.length;s<l;s++,i++)r[i]=o[s];return r};System.register(["./p-364478bb.system.js"],(function(e){"use strict";var t,n,r,i;return{setters:[function(e){t=e.r;n=e.c;r=e.h;i=e.H}],execute:function(){var o=":host{display:contents;--ch-window-mask-z-index:var(--ch-grid-settings-layer)}";var s=e("ch_grid_settings",function(){function e(e){t(this,e);this.settingsCloseClicked=n(this,"settingsCloseClicked",7);this.show=false}e.prototype.windowClosedHandler=function(e){e.stopPropagation();this.show=false;this.settingsCloseClicked.emit()};e.prototype.render=function(){return r(i,null,r("ch-window",{modal:true,container:this.grid,caption:"Options",closeText:"Close",closeOnOutsideClick:true,closeOnEscape:true,allowDrag:"header",hidden:!this.show,exportparts:"mask,window,header,caption,close,main,footer"},r("slot",null)))};return e}());s.style=o;var l=":host{display:-ms-flexbox;display:flex;-ms-flex-direction:column;flex-direction:column}ul{display:contents;list-style-type:none}";var c=e("ch_grid_settings_columns",function(){function e(e){var n=this;t(this,e);this.handleClick=function(e){var t=e.target;var r=n.columns.find((function(e){return e.columnId===t.name}));r.hidden=!t.checked;e.stopPropagation()}}e.prototype.render=function(){var e=this;var t=this.getColumnsSorted();return r("ul",null,t.map((function(t){return r("li",{part:"column"},r("label",{part:"column-label"},r("input",{part:!t.hidden?"column-visible column-visible-checked":"column-visible",type:"checkbox",checked:!t.hidden,disabled:!t.hideable,name:t.columnId,onClick:e.handleClick}),t.columnName))})))};e.prototype.getColumnsSorted=function(){return __spreadArrays(this.columns).sort((function(e,t){if(e.order<t.order){return-1}if(e.order>t.order){return 1}return 0}))};return e}());c.style=l}}}));