gx.evt.autoSkip=!1;gx.define("category",!1,function(){this.ServerClass="category";this.PackageName="GeneXus.Programs";this.ServerFullClass="category.aspx";this.setObjectType("trn");this.hasEnterEvent=!0;this.skipOnEnter=!1;this.fullAjax=!0;this.supportAjaxEvents=!0;this.ajaxSecurityToken=!0;this.DSO="TravelAgency_Capa202309";this.SetStandaloneVars=function(){};this.Valid_Categoryid=function(){return this.validSrvEvt("Valid_Categoryid",0).then(function(n){return n}.closure(this))};this.e11044_client=function(){return this.executeServerEvent("ENTER",!0,null,!1,!1)};this.e12044_client=function(){return this.executeServerEvent("CANCEL",!0,null,!1,!1)};this.GXValidFnc=[];var n=this.GXValidFnc;this.GXCtrlIds=[2,3,4,5,6,7,8,9,10,11,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48];this.GXLastCtrlId=48;n[2]={id:2,fld:"",grid:0};n[3]={id:3,fld:"MAINTABLE",grid:0};n[4]={id:4,fld:"",grid:0};n[5]={id:5,fld:"",grid:0};n[6]={id:6,fld:"TITLECONTAINER",grid:0};n[7]={id:7,fld:"",grid:0};n[8]={id:8,fld:"",grid:0};n[9]={id:9,fld:"TITLE",format:0,grid:0,ctrltype:"textblock"};n[10]={id:10,fld:"",grid:0};n[11]={id:11,fld:"",grid:0};n[13]={id:13,fld:"",grid:0};n[14]={id:14,fld:"",grid:0};n[15]={id:15,fld:"FORMCONTAINER",grid:0};n[16]={id:16,fld:"",grid:0};n[17]={id:17,fld:"TOOLBARCELL",grid:0};n[18]={id:18,fld:"",grid:0};n[19]={id:19,fld:"",grid:0};n[20]={id:20,fld:"",grid:0};n[21]={id:21,fld:"BTN_FIRST",grid:0,evt:"e13044_client",std:"FIRST"};n[22]={id:22,fld:"",grid:0};n[23]={id:23,fld:"BTN_PREVIOUS",grid:0,evt:"e14044_client",std:"PREVIOUS"};n[24]={id:24,fld:"",grid:0};n[25]={id:25,fld:"BTN_NEXT",grid:0,evt:"e15044_client",std:"NEXT"};n[26]={id:26,fld:"",grid:0};n[27]={id:27,fld:"BTN_LAST",grid:0,evt:"e16044_client",std:"LAST"};n[28]={id:28,fld:"",grid:0};n[29]={id:29,fld:"BTN_SELECT",grid:0,evt:"e17044_client",std:"SELECT"};n[30]={id:30,fld:"",grid:0};n[31]={id:31,fld:"",grid:0};n[32]={id:32,fld:"",grid:0};n[33]={id:33,fld:"",grid:0};n[34]={id:34,lvl:0,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:0,grid:0,gxgrid:null,fnc:this.Valid_Categoryid,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"CATEGORYID",fmt:0,gxz:"Z11CategoryId",gxold:"O11CategoryId",gxvar:"A11CategoryId",ucs:[],op:[39],ip:[39,34],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A11CategoryId=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z11CategoryId=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("CATEGORYID",gx.O.A11CategoryId,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A11CategoryId=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("CATEGORYID",",")},nac:gx.falseFn};this.declareDomainHdlr(34,function(){});n[35]={id:35,fld:"",grid:0};n[36]={id:36,fld:"",grid:0};n[37]={id:37,fld:"",grid:0};n[38]={id:38,fld:"",grid:0};n[39]={id:39,lvl:0,type:"svchar",len:40,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"CATEGORYNAME",fmt:0,gxz:"Z12CategoryName",gxold:"O12CategoryName",gxvar:"A12CategoryName",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A12CategoryName=n)},v2z:function(n){n!==undefined&&(gx.O.Z12CategoryName=n)},v2c:function(){gx.fn.setControlValue("CATEGORYNAME",gx.O.A12CategoryName,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A12CategoryName=this.val())},val:function(){return gx.fn.getControlValue("CATEGORYNAME")},nac:gx.falseFn};this.declareDomainHdlr(39,function(){});n[40]={id:40,fld:"",grid:0};n[41]={id:41,fld:"",grid:0};n[42]={id:42,fld:"",grid:0};n[43]={id:43,fld:"",grid:0};n[44]={id:44,fld:"BTN_ENTER",grid:0,evt:"e11044_client",std:"ENTER"};n[45]={id:45,fld:"",grid:0};n[46]={id:46,fld:"BTN_CANCEL",grid:0,evt:"e12044_client"};n[47]={id:47,fld:"",grid:0};n[48]={id:48,fld:"BTN_DELETE",grid:0,evt:"e18044_client",std:"DELETE"};this.A11CategoryId=0;this.Z11CategoryId=0;this.O11CategoryId=0;this.A12CategoryName="";this.Z12CategoryName="";this.O12CategoryName="";this.A11CategoryId=0;this.A12CategoryName="";this.Events={e11044_client:["ENTER",!0],e12044_client:["CANCEL",!0]};this.EvtParms.ENTER=[[{postForm:!0}],[]];this.EvtParms.REFRESH=[[],[]];this.EvtParms.VALID_CATEGORYID=[[{av:"A11CategoryId",fld:"CATEGORYID",pic:"ZZZ9"},{av:"Gx_mode",fld:"vMODE",pic:"@!"}],[{av:"A12CategoryName",fld:"CATEGORYNAME",pic:""},{av:"Gx_mode",fld:"vMODE",pic:"@!"},{av:"Z11CategoryId"},{av:"Z12CategoryName"},{ctrl:"BTN_DELETE",prop:"Enabled"},{ctrl:"BTN_ENTER",prop:"Enabled"}]];this.EnterCtrl=["BTN_ENTER"];this.Initialize()});gx.wi(function(){gx.createParentObj(this.category)})