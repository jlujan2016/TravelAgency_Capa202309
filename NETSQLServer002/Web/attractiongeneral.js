gx.evt.autoSkip=!1;gx.define("attractiongeneral",!0,function(n){this.ServerClass="attractiongeneral";this.PackageName="GeneXus.Programs";this.ServerFullClass="attractiongeneral.aspx";this.setObjectType("web");this.setCmpContext(n);this.ReadonlyForm=!0;this.hasEnterEvent=!1;this.skipOnEnter=!1;this.autoRefresh=!0;this.fullAjax=!0;this.supportAjaxEvents=!0;this.ajaxSecurityToken=!0;this.DSO="TravelAgency_Capa202309";this.SetStandaloneVars=function(){};this.Valid_Attractionid=function(){return this.validCliEvt("Valid_Attractionid",0,function(){try{var n=gx.util.balloon.getNew("ATTRACTIONID");this.AnyError=0}catch(t){}try{return n==null?!0:n.show()}catch(t){}return!0})};this.Valid_Countryid=function(){return this.validCliEvt("Valid_Countryid",0,function(){try{var n=gx.util.balloon.getNew("COUNTRYID");this.AnyError=0}catch(t){}try{return n==null?!0:n.show()}catch(t){}return!0})};this.Valid_Cityid=function(){return this.validCliEvt("Valid_Cityid",0,function(){try{var n=gx.util.balloon.getNew("CITYID");this.AnyError=0}catch(t){}try{return n==null?!0:n.show()}catch(t){}return!0})};this.Valid_Categoryid=function(){return this.validCliEvt("Valid_Categoryid",0,function(){try{var n=gx.util.balloon.getNew("CATEGORYID");this.AnyError=0}catch(t){}try{return n==null?!0:n.show()}catch(t){}return!0})};this.Valid_Supplierid=function(){return this.validCliEvt("Valid_Supplierid",0,function(){try{var n=gx.util.balloon.getNew("SUPPLIERID");this.AnyError=0}catch(t){}try{return n==null?!0:n.show()}catch(t){}return!0})};this.e110i1_client=function(){return this.clearMessages(),this.call("attraction.aspx",["UPD",this.A7AttractionId],null,["Mode","AttractionId"]),this.refreshOutputs([]),this.OnClientEventEnd(),gx.$.Deferred().resolve()};this.e120i1_client=function(){return this.clearMessages(),this.call("attraction.aspx",["DLT",this.A7AttractionId],null,["Mode","AttractionId"]),this.refreshOutputs([]),this.OnClientEventEnd(),gx.$.Deferred().resolve()};this.e150i2_client=function(){return this.executeServerEvent("ENTER",!0,null,!1,!1)};this.e160i2_client=function(){return this.executeServerEvent("CANCEL",!0,null,!1,!1)};this.GXValidFnc=[];var t=this.GXValidFnc;this.GXCtrlIds=[2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,52,53,54,55,56,57,58,59,60,61,62,63,64,65,66,67,68,69,70,71,72,73,74];this.GXLastCtrlId=74;t[2]={id:2,fld:"",grid:0};t[3]={id:3,fld:"MAINTABLE",grid:0};t[4]={id:4,fld:"",grid:0};t[5]={id:5,fld:"",grid:0};t[6]={id:6,fld:"",grid:0};t[7]={id:7,fld:"",grid:0};t[8]={id:8,fld:"BTNUPDATE",grid:0,evt:"e110i1_client"};t[9]={id:9,fld:"",grid:0};t[10]={id:10,fld:"BTNDELETE",grid:0,evt:"e120i1_client"};t[11]={id:11,fld:"",grid:0};t[12]={id:12,fld:"",grid:0};t[13]={id:13,fld:"ATTRIBUTESTABLE",grid:0};t[14]={id:14,fld:"",grid:0};t[15]={id:15,fld:"",grid:0};t[16]={id:16,fld:"",grid:0};t[17]={id:17,fld:"",grid:0};t[18]={id:18,lvl:0,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:1,grid:0,gxgrid:null,fnc:this.Valid_Attractionid,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"ATTRACTIONID",fmt:0,gxz:"Z7AttractionId",gxold:"O7AttractionId",gxvar:"A7AttractionId",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A7AttractionId=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z7AttractionId=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("ATTRACTIONID",gx.O.A7AttractionId,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A7AttractionId=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("ATTRACTIONID",",")},nac:gx.falseFn};this.declareDomainHdlr(18,function(){});t[19]={id:19,fld:"",grid:0};t[20]={id:20,fld:"",grid:0};t[21]={id:21,fld:"",grid:0};t[22]={id:22,fld:"",grid:0};t[23]={id:23,lvl:0,type:"svchar",len:40,dec:0,sign:!1,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"ATTRACTIONNAME",fmt:0,gxz:"Z8AttractionName",gxold:"O8AttractionName",gxvar:"A8AttractionName",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A8AttractionName=n)},v2z:function(n){n!==undefined&&(gx.O.Z8AttractionName=n)},v2c:function(){gx.fn.setControlValue("ATTRACTIONNAME",gx.O.A8AttractionName,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A8AttractionName=this.val())},val:function(){return gx.fn.getControlValue("ATTRACTIONNAME")},nac:gx.falseFn};this.declareDomainHdlr(23,function(){});t[24]={id:24,fld:"",grid:0};t[25]={id:25,fld:"",grid:0};t[26]={id:26,fld:"",grid:0};t[27]={id:27,fld:"",grid:0};t[28]={id:28,lvl:0,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:1,grid:0,gxgrid:null,fnc:this.Valid_Countryid,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"COUNTRYID",fmt:0,gxz:"Z9CountryId",gxold:"O9CountryId",gxvar:"A9CountryId",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A9CountryId=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z9CountryId=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("COUNTRYID",gx.O.A9CountryId,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A9CountryId=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("COUNTRYID",",")},nac:gx.falseFn};this.declareDomainHdlr(28,function(){});t[29]={id:29,fld:"",grid:0};t[30]={id:30,fld:"",grid:0};t[31]={id:31,fld:"",grid:0};t[32]={id:32,fld:"",grid:0};t[33]={id:33,lvl:0,type:"svchar",len:40,dec:0,sign:!1,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"COUNTRYNAME",fmt:0,gxz:"Z10CountryName",gxold:"O10CountryName",gxvar:"A10CountryName",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A10CountryName=n)},v2z:function(n){n!==undefined&&(gx.O.Z10CountryName=n)},v2c:function(){gx.fn.setControlValue("COUNTRYNAME",gx.O.A10CountryName,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A10CountryName=this.val())},val:function(){return gx.fn.getControlValue("COUNTRYNAME")},nac:gx.falseFn};this.declareDomainHdlr(33,function(){});t[34]={id:34,fld:"",grid:0};t[35]={id:35,fld:"",grid:0};t[36]={id:36,fld:"",grid:0};t[37]={id:37,fld:"",grid:0};t[38]={id:38,lvl:0,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:1,grid:0,gxgrid:null,fnc:this.Valid_Cityid,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"CITYID",fmt:0,gxz:"Z14CityId",gxold:"O14CityId",gxvar:"A14CityId",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A14CityId=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z14CityId=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("CITYID",gx.O.A14CityId,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A14CityId=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("CITYID",",")},nac:gx.falseFn};this.declareDomainHdlr(38,function(){});t[39]={id:39,fld:"",grid:0};t[40]={id:40,fld:"",grid:0};t[41]={id:41,fld:"",grid:0};t[42]={id:42,fld:"",grid:0};t[43]={id:43,lvl:0,type:"svchar",len:40,dec:0,sign:!1,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"CITYNAME",fmt:0,gxz:"Z15CityName",gxold:"O15CityName",gxvar:"A15CityName",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A15CityName=n)},v2z:function(n){n!==undefined&&(gx.O.Z15CityName=n)},v2c:function(){gx.fn.setControlValue("CITYNAME",gx.O.A15CityName,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A15CityName=this.val())},val:function(){return gx.fn.getControlValue("CITYNAME")},nac:gx.falseFn};this.declareDomainHdlr(43,function(){});t[44]={id:44,fld:"",grid:0};t[45]={id:45,fld:"",grid:0};t[46]={id:46,fld:"",grid:0};t[47]={id:47,fld:"",grid:0};t[48]={id:48,lvl:0,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:1,grid:0,gxgrid:null,fnc:this.Valid_Categoryid,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"CATEGORYID",fmt:0,gxz:"Z11CategoryId",gxold:"O11CategoryId",gxvar:"A11CategoryId",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A11CategoryId=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z11CategoryId=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("CATEGORYID",gx.O.A11CategoryId,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A11CategoryId=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("CATEGORYID",",")},nac:gx.falseFn};this.declareDomainHdlr(48,function(){});t[49]={id:49,fld:"",grid:0};t[50]={id:50,fld:"",grid:0};t[51]={id:51,fld:"",grid:0};t[52]={id:52,fld:"",grid:0};t[53]={id:53,lvl:0,type:"svchar",len:40,dec:0,sign:!1,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"CATEGORYNAME",fmt:0,gxz:"Z12CategoryName",gxold:"O12CategoryName",gxvar:"A12CategoryName",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A12CategoryName=n)},v2z:function(n){n!==undefined&&(gx.O.Z12CategoryName=n)},v2c:function(){gx.fn.setControlValue("CATEGORYNAME",gx.O.A12CategoryName,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A12CategoryName=this.val())},val:function(){return gx.fn.getControlValue("CATEGORYNAME")},nac:gx.falseFn};this.declareDomainHdlr(53,function(){});t[54]={id:54,fld:"",grid:0};t[55]={id:55,fld:"",grid:0};t[56]={id:56,fld:"",grid:0};t[57]={id:57,fld:"",grid:0};t[58]={id:58,lvl:0,type:"svchar",len:1024,dec:0,sign:!1,ro:1,multiline:!0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"ATTRACTIONADDRESS",fmt:0,gxz:"Z18AttractionAddress",gxold:"O18AttractionAddress",gxvar:"A18AttractionAddress",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A18AttractionAddress=n)},v2z:function(n){n!==undefined&&(gx.O.Z18AttractionAddress=n)},v2c:function(){gx.fn.setControlValue("ATTRACTIONADDRESS",gx.O.A18AttractionAddress,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A18AttractionAddress=this.val())},val:function(){return gx.fn.getControlValue("ATTRACTIONADDRESS")},nac:gx.falseFn};this.declareDomainHdlr(58,function(){gx.fn.setCtrlProperty("ATTRACTIONADDRESS","Link",gx.fn.getCtrlProperty("ATTRACTIONADDRESS","Enabled")?"":"http://maps.google.com/maps?q="+encodeURIComponent(this.A18AttractionAddress))});t[59]={id:59,fld:"",grid:0};t[60]={id:60,fld:"",grid:0};t[61]={id:61,fld:"",grid:0};t[62]={id:62,fld:"",grid:0};t[63]={id:63,lvl:0,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:1,grid:0,gxgrid:null,fnc:this.Valid_Supplierid,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"SUPPLIERID",fmt:0,gxz:"Z48SupplierId",gxold:"O48SupplierId",gxvar:"A48SupplierId",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A48SupplierId=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z48SupplierId=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("SUPPLIERID",gx.O.A48SupplierId,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A48SupplierId=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("SUPPLIERID",",")},nac:gx.falseFn};this.declareDomainHdlr(63,function(){});t[64]={id:64,fld:"",grid:0};t[65]={id:65,fld:"",grid:0};t[66]={id:66,fld:"",grid:0};t[67]={id:67,fld:"",grid:0};t[68]={id:68,lvl:0,type:"svchar",len:40,dec:0,sign:!1,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"SUPPLIERNAME",fmt:0,gxz:"Z49SupplierName",gxold:"O49SupplierName",gxvar:"A49SupplierName",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A49SupplierName=n)},v2z:function(n){n!==undefined&&(gx.O.Z49SupplierName=n)},v2c:function(){gx.fn.setControlValue("SUPPLIERNAME",gx.O.A49SupplierName,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A49SupplierName=this.val())},val:function(){return gx.fn.getControlValue("SUPPLIERNAME")},nac:gx.falseFn};this.declareDomainHdlr(68,function(){});t[69]={id:69,fld:"",grid:0};t[70]={id:70,fld:"IMAGESTABLE",grid:0};t[71]={id:71,fld:"",grid:0};t[72]={id:72,fld:"",grid:0};t[73]={id:73,fld:"",grid:0};t[74]={id:74,lvl:0,type:"bits",len:1024,dec:0,sign:!1,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"ATTRACTIONPHOTO",fmt:0,gxz:"Z13AttractionPhoto",gxold:"O13AttractionPhoto",gxvar:"A13AttractionPhoto",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A13AttractionPhoto=n)},v2z:function(n){n!==undefined&&(gx.O.Z13AttractionPhoto=n)},v2c:function(){gx.fn.setMultimediaValue("ATTRACTIONPHOTO",gx.O.A13AttractionPhoto,gx.O.A40000AttractionPhoto_GXI)},c2v:function(){gx.O.A40000AttractionPhoto_GXI=this.val_GXI();this.val()!==undefined&&(gx.O.A13AttractionPhoto=this.val())},val:function(){return gx.fn.getBlobValue("ATTRACTIONPHOTO")},val_GXI:function(){return gx.fn.getControlValue("ATTRACTIONPHOTO_GXI")},gxvar_GXI:"A40000AttractionPhoto_GXI",nac:gx.falseFn};this.A7AttractionId=0;this.Z7AttractionId=0;this.O7AttractionId=0;this.A8AttractionName="";this.Z8AttractionName="";this.O8AttractionName="";this.A9CountryId=0;this.Z9CountryId=0;this.O9CountryId=0;this.A10CountryName="";this.Z10CountryName="";this.O10CountryName="";this.A14CityId=0;this.Z14CityId=0;this.O14CityId=0;this.A15CityName="";this.Z15CityName="";this.O15CityName="";this.A11CategoryId=0;this.Z11CategoryId=0;this.O11CategoryId=0;this.A12CategoryName="";this.Z12CategoryName="";this.O12CategoryName="";this.A18AttractionAddress="";this.Z18AttractionAddress="";this.O18AttractionAddress="";this.A48SupplierId=0;this.Z48SupplierId=0;this.O48SupplierId=0;this.A49SupplierName="";this.Z49SupplierName="";this.O49SupplierName="";this.A40000AttractionPhoto_GXI="";this.A13AttractionPhoto="";this.Z13AttractionPhoto="";this.O13AttractionPhoto="";this.A7AttractionId=0;this.A8AttractionName="";this.A9CountryId=0;this.A10CountryName="";this.A14CityId=0;this.A15CityName="";this.A11CategoryId=0;this.A12CategoryName="";this.A18AttractionAddress="";this.A48SupplierId=0;this.A49SupplierName="";this.A13AttractionPhoto="";this.A40000AttractionPhoto_GXI="";this.Events={e150i2_client:["ENTER",!0],e160i2_client:["CANCEL",!0],e110i1_client:["'DOUPDATE'",!1],e120i1_client:["'DODELETE'",!1]};this.EvtParms.REFRESH=[[{av:"A7AttractionId",fld:"ATTRACTIONID",pic:"ZZZ9"},{av:"A9CountryId",fld:"COUNTRYID",pic:"ZZZ9"}],[]];this.EvtParms["'DOUPDATE'"]=[[{av:"A7AttractionId",fld:"ATTRACTIONID",pic:"ZZZ9"}],[]];this.EvtParms["'DODELETE'"]=[[{av:"A7AttractionId",fld:"ATTRACTIONID",pic:"ZZZ9"}],[]];this.EvtParms.ENTER=[[],[]];this.EvtParms.VALID_ATTRACTIONID=[[],[]];this.EvtParms.VALID_COUNTRYID=[[],[]];this.EvtParms.VALID_CITYID=[[],[]];this.EvtParms.VALID_CATEGORYID=[[],[]];this.EvtParms.VALID_SUPPLIERID=[[],[]];this.Initialize()})