gx.evt.autoSkip=!1;gx.define("customergeneral",!0,function(n){this.ServerClass="customergeneral";this.PackageName="GeneXus.Programs";this.ServerFullClass="customergeneral.aspx";this.setObjectType("web");this.setCmpContext(n);this.ReadonlyForm=!0;this.hasEnterEvent=!1;this.skipOnEnter=!1;this.autoRefresh=!0;this.fullAjax=!0;this.supportAjaxEvents=!0;this.ajaxSecurityToken=!0;this.DSO="TravelAgency_Capa202309";this.SetStandaloneVars=function(){};this.Valid_Customerid=function(){return this.validCliEvt("Valid_Customerid",0,function(){try{var n=gx.util.balloon.getNew("CUSTOMERID");this.AnyError=0}catch(t){}try{return n==null?!0:n.show()}catch(t){}return!0})};this.e110b1_client=function(){return this.clearMessages(),this.call("customer.aspx",["UPD",this.A1CustomerId],null,["Mode","CustomerId"]),this.refreshOutputs([]),this.OnClientEventEnd(),gx.$.Deferred().resolve()};this.e120b1_client=function(){return this.clearMessages(),this.call("customer.aspx",["DLT",this.A1CustomerId],null,["Mode","CustomerId"]),this.refreshOutputs([]),this.OnClientEventEnd(),gx.$.Deferred().resolve()};this.e150b2_client=function(){return this.executeServerEvent("ENTER",!0,null,!1,!1)};this.e160b2_client=function(){return this.executeServerEvent("CANCEL",!0,null,!1,!1)};this.GXValidFnc=[];var t=this.GXValidFnc;this.GXCtrlIds=[2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48];this.GXLastCtrlId=48;t[2]={id:2,fld:"",grid:0};t[3]={id:3,fld:"MAINTABLE",grid:0};t[4]={id:4,fld:"",grid:0};t[5]={id:5,fld:"",grid:0};t[6]={id:6,fld:"",grid:0};t[7]={id:7,fld:"",grid:0};t[8]={id:8,fld:"BTNUPDATE",grid:0,evt:"e110b1_client"};t[9]={id:9,fld:"",grid:0};t[10]={id:10,fld:"BTNDELETE",grid:0,evt:"e120b1_client"};t[11]={id:11,fld:"",grid:0};t[12]={id:12,fld:"",grid:0};t[13]={id:13,fld:"ATTRIBUTESTABLE",grid:0};t[14]={id:14,fld:"",grid:0};t[15]={id:15,fld:"",grid:0};t[16]={id:16,fld:"",grid:0};t[17]={id:17,fld:"",grid:0};t[18]={id:18,lvl:0,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:1,grid:0,gxgrid:null,fnc:this.Valid_Customerid,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"CUSTOMERID",fmt:0,gxz:"Z1CustomerId",gxold:"O1CustomerId",gxvar:"A1CustomerId",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A1CustomerId=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z1CustomerId=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("CUSTOMERID",gx.O.A1CustomerId,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A1CustomerId=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("CUSTOMERID",",")},nac:gx.falseFn};this.declareDomainHdlr(18,function(){});t[19]={id:19,fld:"",grid:0};t[20]={id:20,fld:"",grid:0};t[21]={id:21,fld:"",grid:0};t[22]={id:22,fld:"",grid:0};t[23]={id:23,lvl:0,type:"svchar",len:40,dec:0,sign:!1,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"CUSTOMERNAME",fmt:0,gxz:"Z2CustomerName",gxold:"O2CustomerName",gxvar:"A2CustomerName",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A2CustomerName=n)},v2z:function(n){n!==undefined&&(gx.O.Z2CustomerName=n)},v2c:function(){gx.fn.setControlValue("CUSTOMERNAME",gx.O.A2CustomerName,0)},c2v:function(){this.val()!==undefined&&(gx.O.A2CustomerName=this.val())},val:function(){return gx.fn.getControlValue("CUSTOMERNAME")},nac:gx.falseFn};t[24]={id:24,fld:"",grid:0};t[25]={id:25,fld:"",grid:0};t[26]={id:26,fld:"",grid:0};t[27]={id:27,fld:"",grid:0};t[28]={id:28,lvl:0,type:"svchar",len:40,dec:0,sign:!1,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"CUSTOMERLASTNAME",fmt:0,gxz:"Z3CustomerLastName",gxold:"O3CustomerLastName",gxvar:"A3CustomerLastName",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A3CustomerLastName=n)},v2z:function(n){n!==undefined&&(gx.O.Z3CustomerLastName=n)},v2c:function(){gx.fn.setControlValue("CUSTOMERLASTNAME",gx.O.A3CustomerLastName,0)},c2v:function(){this.val()!==undefined&&(gx.O.A3CustomerLastName=this.val())},val:function(){return gx.fn.getControlValue("CUSTOMERLASTNAME")},nac:gx.falseFn};t[29]={id:29,fld:"",grid:0};t[30]={id:30,fld:"",grid:0};t[31]={id:31,fld:"",grid:0};t[32]={id:32,fld:"",grid:0};t[33]={id:33,lvl:0,type:"svchar",len:1024,dec:0,sign:!1,ro:1,multiline:!0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"CUSTOMERADDRESS",fmt:0,gxz:"Z4CustomerAddress",gxold:"O4CustomerAddress",gxvar:"A4CustomerAddress",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A4CustomerAddress=n)},v2z:function(n){n!==undefined&&(gx.O.Z4CustomerAddress=n)},v2c:function(){gx.fn.setControlValue("CUSTOMERADDRESS",gx.O.A4CustomerAddress,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A4CustomerAddress=this.val())},val:function(){return gx.fn.getControlValue("CUSTOMERADDRESS")},nac:gx.falseFn};this.declareDomainHdlr(33,function(){gx.fn.setCtrlProperty("CUSTOMERADDRESS","Link",gx.fn.getCtrlProperty("CUSTOMERADDRESS","Enabled")?"":"http://maps.google.com/maps?q="+encodeURIComponent(this.A4CustomerAddress))});t[34]={id:34,fld:"",grid:0};t[35]={id:35,fld:"",grid:0};t[36]={id:36,fld:"",grid:0};t[37]={id:37,fld:"",grid:0};t[38]={id:38,lvl:0,type:"char",len:20,dec:0,sign:!1,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"CUSTOMERPHONE",fmt:0,gxz:"Z5CustomerPhone",gxold:"O5CustomerPhone",gxvar:"A5CustomerPhone",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A5CustomerPhone=n)},v2z:function(n){n!==undefined&&(gx.O.Z5CustomerPhone=n)},v2c:function(){gx.fn.setControlValue("CUSTOMERPHONE",gx.O.A5CustomerPhone,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A5CustomerPhone=this.val())},val:function(){return gx.fn.getControlValue("CUSTOMERPHONE")},nac:gx.falseFn};this.declareDomainHdlr(38,function(){});t[39]={id:39,fld:"",grid:0};t[40]={id:40,fld:"",grid:0};t[41]={id:41,fld:"",grid:0};t[42]={id:42,fld:"",grid:0};t[43]={id:43,lvl:0,type:"svchar",len:100,dec:0,sign:!1,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"CUSTOMEREMAIL",fmt:0,gxz:"Z6CustomerEmail",gxold:"O6CustomerEmail",gxvar:"A6CustomerEmail",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A6CustomerEmail=n)},v2z:function(n){n!==undefined&&(gx.O.Z6CustomerEmail=n)},v2c:function(){gx.fn.setControlValue("CUSTOMEREMAIL",gx.O.A6CustomerEmail,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A6CustomerEmail=this.val())},val:function(){return gx.fn.getControlValue("CUSTOMEREMAIL")},nac:gx.falseFn};this.declareDomainHdlr(43,function(){gx.fn.setCtrlProperty("CUSTOMEREMAIL","Link",gx.fn.getCtrlProperty("CUSTOMEREMAIL","Enabled")?"":"mailto:"+this.A6CustomerEmail)});t[44]={id:44,fld:"",grid:0};t[45]={id:45,fld:"",grid:0};t[46]={id:46,fld:"",grid:0};t[47]={id:47,fld:"",grid:0};t[48]={id:48,lvl:0,type:"date",len:8,dec:0,sign:!1,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"CUSTOMERADDEDDATE",fmt:0,gxz:"Z16CustomerAddedDate",gxold:"O16CustomerAddedDate",gxvar:"A16CustomerAddedDate",dp:{f:0,st:!1,wn:!1,mf:!1,pic:"99/99/99",dec:0},ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A16CustomerAddedDate=gx.fn.toDatetimeValue(n))},v2z:function(n){n!==undefined&&(gx.O.Z16CustomerAddedDate=gx.fn.toDatetimeValue(n))},v2c:function(){gx.fn.setControlValue("CUSTOMERADDEDDATE",gx.O.A16CustomerAddedDate,0)},c2v:function(){this.val()!==undefined&&(gx.O.A16CustomerAddedDate=gx.fn.toDatetimeValue(this.val()))},val:function(){return gx.fn.getControlValue("CUSTOMERADDEDDATE")},nac:gx.falseFn};this.A1CustomerId=0;this.Z1CustomerId=0;this.O1CustomerId=0;this.A2CustomerName="";this.Z2CustomerName="";this.O2CustomerName="";this.A3CustomerLastName="";this.Z3CustomerLastName="";this.O3CustomerLastName="";this.A4CustomerAddress="";this.Z4CustomerAddress="";this.O4CustomerAddress="";this.A5CustomerPhone="";this.Z5CustomerPhone="";this.O5CustomerPhone="";this.A6CustomerEmail="";this.Z6CustomerEmail="";this.O6CustomerEmail="";this.A16CustomerAddedDate=gx.date.nullDate();this.Z16CustomerAddedDate=gx.date.nullDate();this.O16CustomerAddedDate=gx.date.nullDate();this.A1CustomerId=0;this.A2CustomerName="";this.A3CustomerLastName="";this.A4CustomerAddress="";this.A5CustomerPhone="";this.A6CustomerEmail="";this.A16CustomerAddedDate=gx.date.nullDate();this.Events={e150b2_client:["ENTER",!0],e160b2_client:["CANCEL",!0],e110b1_client:["'DOUPDATE'",!1],e120b1_client:["'DODELETE'",!1]};this.EvtParms.REFRESH=[[{av:"A1CustomerId",fld:"CUSTOMERID",pic:"ZZZ9"}],[]];this.EvtParms["'DOUPDATE'"]=[[{av:"A1CustomerId",fld:"CUSTOMERID",pic:"ZZZ9"}],[]];this.EvtParms["'DODELETE'"]=[[{av:"A1CustomerId",fld:"CUSTOMERID",pic:"ZZZ9"}],[]];this.EvtParms.ENTER=[[],[]];this.EvtParms.VALID_CUSTOMERID=[[],[]];this.Initialize()})