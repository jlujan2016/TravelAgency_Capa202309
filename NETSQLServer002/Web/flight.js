gx.evt.autoSkip=!1;gx.define("flight",!1,function(){this.ServerClass="flight";this.PackageName="GeneXus.Programs";this.ServerFullClass="flight.aspx";this.setObjectType("trn");this.hasEnterEvent=!0;this.skipOnEnter=!1;this.fullAjax=!0;this.supportAjaxEvents=!0;this.ajaxSecurityToken=!0;this.DSO="TravelAgency_Capa202309";this.SetStandaloneVars=function(){};this.Valid_Flightid=function(){return this.validSrvEvt("Valid_Flightid",0).then(function(n){return n}.closure(this))};this.Valid_Flightarrivalairportid=function(){return this.validSrvEvt("Valid_Flightarrivalairportid",0).then(function(n){return n}.closure(this))};this.Valid_Flightarrivalcountryid=function(){return this.validCliEvt("Valid_Flightarrivalcountryid",0,function(){try{var n=gx.util.balloon.getNew("FLIGHTARRIVALCOUNTRYID");this.AnyError=0}catch(t){}try{return n==null?!0:n.show()}catch(t){}return!0})};this.Valid_Flightarrivalcityid=function(){return this.validCliEvt("Valid_Flightarrivalcityid",0,function(){try{var n=gx.util.balloon.getNew("FLIGHTARRIVALCITYID");this.AnyError=0}catch(t){}try{return n==null?!0:n.show()}catch(t){}return!0})};this.Valid_Flightdepartureairportid=function(){return this.validSrvEvt("Valid_Flightdepartureairportid",0).then(function(n){return n}.closure(this))};this.Valid_Flightdeparturecountryid=function(){return this.validCliEvt("Valid_Flightdeparturecountryid",0,function(){try{var n=gx.util.balloon.getNew("FLIGHTDEPARTURECOUNTRYID");this.AnyError=0}catch(t){}try{return n==null?!0:n.show()}catch(t){}return!0})};this.Valid_Flightdeparturecityid=function(){return this.validCliEvt("Valid_Flightdeparturecityid",0,function(){try{var n=gx.util.balloon.getNew("FLIGHTDEPARTURECITYID");this.AnyError=0}catch(t){}try{return n==null?!0:n.show()}catch(t){}return!0})};this.e11056_client=function(){return this.executeServerEvent("ENTER",!0,null,!1,!1)};this.e12056_client=function(){return this.executeServerEvent("CANCEL",!0,null,!1,!1)};this.GXValidFnc=[];var n=this.GXValidFnc;this.GXCtrlIds=[2,3,4,5,6,7,8,9,10,11,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,52,53,54,55,56,57,58,59,60,61,62,63,64,65,66,67,68,69,70,71,72,73,74,75,76,77,78,79,80,81,82,83,84,85,86,87,88,89,90,91,92,93,94,95,96,97,98,99,100,101,102,103,104,105];this.GXLastCtrlId=105;n[2]={id:2,fld:"",grid:0};n[3]={id:3,fld:"MAINTABLE",grid:0};n[4]={id:4,fld:"",grid:0};n[5]={id:5,fld:"",grid:0};n[6]={id:6,fld:"TITLECONTAINER",grid:0};n[7]={id:7,fld:"",grid:0};n[8]={id:8,fld:"",grid:0};n[9]={id:9,fld:"TITLE",format:0,grid:0,ctrltype:"textblock"};n[10]={id:10,fld:"",grid:0};n[11]={id:11,fld:"",grid:0};n[13]={id:13,fld:"",grid:0};n[14]={id:14,fld:"",grid:0};n[15]={id:15,fld:"FORMCONTAINER",grid:0};n[16]={id:16,fld:"",grid:0};n[17]={id:17,fld:"TOOLBARCELL",grid:0};n[18]={id:18,fld:"",grid:0};n[19]={id:19,fld:"",grid:0};n[20]={id:20,fld:"",grid:0};n[21]={id:21,fld:"BTN_FIRST",grid:0,evt:"e13056_client",std:"FIRST"};n[22]={id:22,fld:"",grid:0};n[23]={id:23,fld:"BTN_PREVIOUS",grid:0,evt:"e14056_client",std:"PREVIOUS"};n[24]={id:24,fld:"",grid:0};n[25]={id:25,fld:"BTN_NEXT",grid:0,evt:"e15056_client",std:"NEXT"};n[26]={id:26,fld:"",grid:0};n[27]={id:27,fld:"BTN_LAST",grid:0,evt:"e16056_client",std:"LAST"};n[28]={id:28,fld:"",grid:0};n[29]={id:29,fld:"BTN_SELECT",grid:0,evt:"e17056_client",std:"SELECT"};n[30]={id:30,fld:"",grid:0};n[31]={id:31,fld:"",grid:0};n[32]={id:32,fld:"",grid:0};n[33]={id:33,fld:"",grid:0};n[34]={id:34,lvl:0,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:0,grid:0,gxgrid:null,fnc:this.Valid_Flightid,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"FLIGHTID",fmt:0,gxz:"Z19FlightId",gxold:"O19FlightId",gxvar:"A19FlightId",ucs:[],op:[69,39],ip:[69,39,34],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A19FlightId=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z19FlightId=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("FLIGHTID",gx.O.A19FlightId,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A19FlightId=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("FLIGHTID",",")},nac:gx.falseFn};this.declareDomainHdlr(34,function(){});n[35]={id:35,fld:"",grid:0};n[36]={id:36,fld:"",grid:0};n[37]={id:37,fld:"",grid:0};n[38]={id:38,fld:"",grid:0};n[39]={id:39,lvl:0,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:0,grid:0,gxgrid:null,fnc:this.Valid_Flightarrivalairportid,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"FLIGHTARRIVALAIRPORTID",fmt:0,gxz:"Z25FlightArrivalAirportId",gxold:"O25FlightArrivalAirportId",gxvar:"A25FlightArrivalAirportId",ucs:[],op:[64,54,59,49,44],ip:[64,54,44,59,49,39],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A25FlightArrivalAirportId=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z25FlightArrivalAirportId=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("FLIGHTARRIVALAIRPORTID",gx.O.A25FlightArrivalAirportId,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A25FlightArrivalAirportId=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("FLIGHTARRIVALAIRPORTID",",")},nac:gx.falseFn};this.declareDomainHdlr(39,function(){});n[40]={id:40,fld:"",grid:0};n[41]={id:41,fld:"",grid:0};n[42]={id:42,fld:"",grid:0};n[43]={id:43,fld:"",grid:0};n[44]={id:44,lvl:0,type:"svchar",len:40,dec:0,sign:!1,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"FLIGHTARRIVALAIRPORTNAME",fmt:0,gxz:"Z26FlightArrivalAirportName",gxold:"O26FlightArrivalAirportName",gxvar:"A26FlightArrivalAirportName",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A26FlightArrivalAirportName=n)},v2z:function(n){n!==undefined&&(gx.O.Z26FlightArrivalAirportName=n)},v2c:function(){gx.fn.setControlValue("FLIGHTARRIVALAIRPORTNAME",gx.O.A26FlightArrivalAirportName,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A26FlightArrivalAirportName=this.val())},val:function(){return gx.fn.getControlValue("FLIGHTARRIVALAIRPORTNAME")},nac:gx.falseFn};this.declareDomainHdlr(44,function(){});n[45]={id:45,fld:"",grid:0};n[46]={id:46,fld:"",grid:0};n[47]={id:47,fld:"",grid:0};n[48]={id:48,fld:"",grid:0};n[49]={id:49,lvl:0,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:1,grid:0,gxgrid:null,fnc:this.Valid_Flightarrivalcountryid,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"FLIGHTARRIVALCOUNTRYID",fmt:0,gxz:"Z31FlightArrivalCountryId",gxold:"O31FlightArrivalCountryId",gxvar:"A31FlightArrivalCountryId",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A31FlightArrivalCountryId=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z31FlightArrivalCountryId=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("FLIGHTARRIVALCOUNTRYID",gx.O.A31FlightArrivalCountryId,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A31FlightArrivalCountryId=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("FLIGHTARRIVALCOUNTRYID",",")},nac:gx.falseFn};this.declareDomainHdlr(49,function(){});n[50]={id:50,fld:"",grid:0};n[51]={id:51,fld:"",grid:0};n[52]={id:52,fld:"",grid:0};n[53]={id:53,fld:"",grid:0};n[54]={id:54,lvl:0,type:"svchar",len:40,dec:0,sign:!1,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"FLIGHTARRIVALCOUNTRYNAME",fmt:0,gxz:"Z32FlightArrivalCountryName",gxold:"O32FlightArrivalCountryName",gxvar:"A32FlightArrivalCountryName",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A32FlightArrivalCountryName=n)},v2z:function(n){n!==undefined&&(gx.O.Z32FlightArrivalCountryName=n)},v2c:function(){gx.fn.setControlValue("FLIGHTARRIVALCOUNTRYNAME",gx.O.A32FlightArrivalCountryName,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A32FlightArrivalCountryName=this.val())},val:function(){return gx.fn.getControlValue("FLIGHTARRIVALCOUNTRYNAME")},nac:gx.falseFn};this.declareDomainHdlr(54,function(){});n[55]={id:55,fld:"",grid:0};n[56]={id:56,fld:"",grid:0};n[57]={id:57,fld:"",grid:0};n[58]={id:58,fld:"",grid:0};n[59]={id:59,lvl:0,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:1,grid:0,gxgrid:null,fnc:this.Valid_Flightarrivalcityid,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"FLIGHTARRIVALCITYID",fmt:0,gxz:"Z33FlightArrivalCityId",gxold:"O33FlightArrivalCityId",gxvar:"A33FlightArrivalCityId",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A33FlightArrivalCityId=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z33FlightArrivalCityId=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("FLIGHTARRIVALCITYID",gx.O.A33FlightArrivalCityId,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A33FlightArrivalCityId=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("FLIGHTARRIVALCITYID",",")},nac:gx.falseFn};this.declareDomainHdlr(59,function(){});n[60]={id:60,fld:"",grid:0};n[61]={id:61,fld:"",grid:0};n[62]={id:62,fld:"",grid:0};n[63]={id:63,fld:"",grid:0};n[64]={id:64,lvl:0,type:"svchar",len:40,dec:0,sign:!1,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"FLIGHTARRIVALCITYNAME",fmt:0,gxz:"Z34FlightArrivalCityName",gxold:"O34FlightArrivalCityName",gxvar:"A34FlightArrivalCityName",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A34FlightArrivalCityName=n)},v2z:function(n){n!==undefined&&(gx.O.Z34FlightArrivalCityName=n)},v2c:function(){gx.fn.setControlValue("FLIGHTARRIVALCITYNAME",gx.O.A34FlightArrivalCityName,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A34FlightArrivalCityName=this.val())},val:function(){return gx.fn.getControlValue("FLIGHTARRIVALCITYNAME")},nac:gx.falseFn};this.declareDomainHdlr(64,function(){});n[65]={id:65,fld:"",grid:0};n[66]={id:66,fld:"",grid:0};n[67]={id:67,fld:"",grid:0};n[68]={id:68,fld:"",grid:0};n[69]={id:69,lvl:0,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:0,grid:0,gxgrid:null,fnc:this.Valid_Flightdepartureairportid,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"FLIGHTDEPARTUREAIRPORTID",fmt:0,gxz:"Z24FlightDepartureAirportId",gxold:"O24FlightDepartureAirportId",gxvar:"A24FlightDepartureAirportId",ucs:[],op:[94,84,89,79,74],ip:[94,84,74,89,79,69],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A24FlightDepartureAirportId=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z24FlightDepartureAirportId=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("FLIGHTDEPARTUREAIRPORTID",gx.O.A24FlightDepartureAirportId,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A24FlightDepartureAirportId=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("FLIGHTDEPARTUREAIRPORTID",",")},nac:gx.falseFn};this.declareDomainHdlr(69,function(){});n[70]={id:70,fld:"",grid:0};n[71]={id:71,fld:"",grid:0};n[72]={id:72,fld:"",grid:0};n[73]={id:73,fld:"",grid:0};n[74]={id:74,lvl:0,type:"svchar",len:40,dec:0,sign:!1,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"FLIGHTDEPARTUREAIRPORTNAME",fmt:0,gxz:"Z23FlightDepartureAirportName",gxold:"O23FlightDepartureAirportName",gxvar:"A23FlightDepartureAirportName",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A23FlightDepartureAirportName=n)},v2z:function(n){n!==undefined&&(gx.O.Z23FlightDepartureAirportName=n)},v2c:function(){gx.fn.setControlValue("FLIGHTDEPARTUREAIRPORTNAME",gx.O.A23FlightDepartureAirportName,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A23FlightDepartureAirportName=this.val())},val:function(){return gx.fn.getControlValue("FLIGHTDEPARTUREAIRPORTNAME")},nac:gx.falseFn};this.declareDomainHdlr(74,function(){});n[75]={id:75,fld:"",grid:0};n[76]={id:76,fld:"",grid:0};n[77]={id:77,fld:"",grid:0};n[78]={id:78,fld:"",grid:0};n[79]={id:79,lvl:0,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:1,grid:0,gxgrid:null,fnc:this.Valid_Flightdeparturecountryid,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"FLIGHTDEPARTURECOUNTRYID",fmt:0,gxz:"Z27FlightDepartureCountryId",gxold:"O27FlightDepartureCountryId",gxvar:"A27FlightDepartureCountryId",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A27FlightDepartureCountryId=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z27FlightDepartureCountryId=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("FLIGHTDEPARTURECOUNTRYID",gx.O.A27FlightDepartureCountryId,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A27FlightDepartureCountryId=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("FLIGHTDEPARTURECOUNTRYID",",")},nac:gx.falseFn};this.declareDomainHdlr(79,function(){});n[80]={id:80,fld:"",grid:0};n[81]={id:81,fld:"",grid:0};n[82]={id:82,fld:"",grid:0};n[83]={id:83,fld:"",grid:0};n[84]={id:84,lvl:0,type:"svchar",len:40,dec:0,sign:!1,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"FLIGHTDEPARTURECOUNTRYNAME",fmt:0,gxz:"Z28FlightDepartureCountryName",gxold:"O28FlightDepartureCountryName",gxvar:"A28FlightDepartureCountryName",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A28FlightDepartureCountryName=n)},v2z:function(n){n!==undefined&&(gx.O.Z28FlightDepartureCountryName=n)},v2c:function(){gx.fn.setControlValue("FLIGHTDEPARTURECOUNTRYNAME",gx.O.A28FlightDepartureCountryName,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A28FlightDepartureCountryName=this.val())},val:function(){return gx.fn.getControlValue("FLIGHTDEPARTURECOUNTRYNAME")},nac:gx.falseFn};this.declareDomainHdlr(84,function(){});n[85]={id:85,fld:"",grid:0};n[86]={id:86,fld:"",grid:0};n[87]={id:87,fld:"",grid:0};n[88]={id:88,fld:"",grid:0};n[89]={id:89,lvl:0,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:1,grid:0,gxgrid:null,fnc:this.Valid_Flightdeparturecityid,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"FLIGHTDEPARTURECITYID",fmt:0,gxz:"Z29FlightDepartureCityId",gxold:"O29FlightDepartureCityId",gxvar:"A29FlightDepartureCityId",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A29FlightDepartureCityId=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z29FlightDepartureCityId=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("FLIGHTDEPARTURECITYID",gx.O.A29FlightDepartureCityId,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A29FlightDepartureCityId=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("FLIGHTDEPARTURECITYID",",")},nac:gx.falseFn};this.declareDomainHdlr(89,function(){});n[90]={id:90,fld:"",grid:0};n[91]={id:91,fld:"",grid:0};n[92]={id:92,fld:"",grid:0};n[93]={id:93,fld:"",grid:0};n[94]={id:94,lvl:0,type:"svchar",len:40,dec:0,sign:!1,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"FLIGHTDEPARTURECITYNAME",fmt:0,gxz:"Z30FlightDepartureCityName",gxold:"O30FlightDepartureCityName",gxvar:"A30FlightDepartureCityName",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A30FlightDepartureCityName=n)},v2z:function(n){n!==undefined&&(gx.O.Z30FlightDepartureCityName=n)},v2c:function(){gx.fn.setControlValue("FLIGHTDEPARTURECITYNAME",gx.O.A30FlightDepartureCityName,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A30FlightDepartureCityName=this.val())},val:function(){return gx.fn.getControlValue("FLIGHTDEPARTURECITYNAME")},nac:gx.falseFn};this.declareDomainHdlr(94,function(){});n[95]={id:95,fld:"",grid:0};n[96]={id:96,fld:"",grid:0};n[97]={id:97,fld:"",grid:0};n[98]={id:98,fld:"",grid:0};n[99]={id:99,fld:"BTN_ENTER",grid:0,evt:"e11056_client",std:"ENTER"};n[100]={id:100,fld:"",grid:0};n[101]={id:101,fld:"BTN_CANCEL",grid:0,evt:"e12056_client"};n[102]={id:102,fld:"",grid:0};n[103]={id:103,fld:"BTN_DELETE",grid:0,evt:"e18056_client",std:"DELETE"};n[104]={id:104,fld:"PROMPT_25",grid:6};n[105]={id:105,fld:"PROMPT_24",grid:6};this.A19FlightId=0;this.Z19FlightId=0;this.O19FlightId=0;this.A25FlightArrivalAirportId=0;this.Z25FlightArrivalAirportId=0;this.O25FlightArrivalAirportId=0;this.A26FlightArrivalAirportName="";this.Z26FlightArrivalAirportName="";this.O26FlightArrivalAirportName="";this.A31FlightArrivalCountryId=0;this.Z31FlightArrivalCountryId=0;this.O31FlightArrivalCountryId=0;this.A32FlightArrivalCountryName="";this.Z32FlightArrivalCountryName="";this.O32FlightArrivalCountryName="";this.A33FlightArrivalCityId=0;this.Z33FlightArrivalCityId=0;this.O33FlightArrivalCityId=0;this.A34FlightArrivalCityName="";this.Z34FlightArrivalCityName="";this.O34FlightArrivalCityName="";this.A24FlightDepartureAirportId=0;this.Z24FlightDepartureAirportId=0;this.O24FlightDepartureAirportId=0;this.A23FlightDepartureAirportName="";this.Z23FlightDepartureAirportName="";this.O23FlightDepartureAirportName="";this.A27FlightDepartureCountryId=0;this.Z27FlightDepartureCountryId=0;this.O27FlightDepartureCountryId=0;this.A28FlightDepartureCountryName="";this.Z28FlightDepartureCountryName="";this.O28FlightDepartureCountryName="";this.A29FlightDepartureCityId=0;this.Z29FlightDepartureCityId=0;this.O29FlightDepartureCityId=0;this.A30FlightDepartureCityName="";this.Z30FlightDepartureCityName="";this.O30FlightDepartureCityName="";this.A19FlightId=0;this.A25FlightArrivalAirportId=0;this.A26FlightArrivalAirportName="";this.A31FlightArrivalCountryId=0;this.A32FlightArrivalCountryName="";this.A33FlightArrivalCityId=0;this.A34FlightArrivalCityName="";this.A24FlightDepartureAirportId=0;this.A23FlightDepartureAirportName="";this.A27FlightDepartureCountryId=0;this.A28FlightDepartureCountryName="";this.A29FlightDepartureCityId=0;this.A30FlightDepartureCityName="";this.Events={e11056_client:["ENTER",!0],e12056_client:["CANCEL",!0]};this.EvtParms.ENTER=[[{postForm:!0}],[]];this.EvtParms.REFRESH=[[],[]];this.EvtParms.VALID_FLIGHTID=[[{av:"A19FlightId",fld:"FLIGHTID",pic:"ZZZ9"},{av:"Gx_mode",fld:"vMODE",pic:"@!"}],[{av:"A25FlightArrivalAirportId",fld:"FLIGHTARRIVALAIRPORTID",pic:"ZZZ9"},{av:"A24FlightDepartureAirportId",fld:"FLIGHTDEPARTUREAIRPORTID",pic:"ZZZ9"},{av:"A26FlightArrivalAirportName",fld:"FLIGHTARRIVALAIRPORTNAME",pic:""},{av:"A31FlightArrivalCountryId",fld:"FLIGHTARRIVALCOUNTRYID",pic:"ZZZ9"},{av:"A33FlightArrivalCityId",fld:"FLIGHTARRIVALCITYID",pic:"ZZZ9"},{av:"A32FlightArrivalCountryName",fld:"FLIGHTARRIVALCOUNTRYNAME",pic:""},{av:"A34FlightArrivalCityName",fld:"FLIGHTARRIVALCITYNAME",pic:""},{av:"A23FlightDepartureAirportName",fld:"FLIGHTDEPARTUREAIRPORTNAME",pic:""},{av:"A27FlightDepartureCountryId",fld:"FLIGHTDEPARTURECOUNTRYID",pic:"ZZZ9"},{av:"A29FlightDepartureCityId",fld:"FLIGHTDEPARTURECITYID",pic:"ZZZ9"},{av:"A28FlightDepartureCountryName",fld:"FLIGHTDEPARTURECOUNTRYNAME",pic:""},{av:"A30FlightDepartureCityName",fld:"FLIGHTDEPARTURECITYNAME",pic:""},{av:"Gx_mode",fld:"vMODE",pic:"@!"},{av:"Z19FlightId"},{av:"Z25FlightArrivalAirportId"},{av:"Z24FlightDepartureAirportId"},{av:"Z26FlightArrivalAirportName"},{av:"Z31FlightArrivalCountryId"},{av:"Z33FlightArrivalCityId"},{av:"Z32FlightArrivalCountryName"},{av:"Z34FlightArrivalCityName"},{av:"Z23FlightDepartureAirportName"},{av:"Z27FlightDepartureCountryId"},{av:"Z29FlightDepartureCityId"},{av:"Z28FlightDepartureCountryName"},{av:"Z30FlightDepartureCityName"},{ctrl:"BTN_DELETE",prop:"Enabled"},{ctrl:"BTN_ENTER",prop:"Enabled"}]];this.EvtParms.VALID_FLIGHTARRIVALAIRPORTID=[[{av:"A25FlightArrivalAirportId",fld:"FLIGHTARRIVALAIRPORTID",pic:"ZZZ9"},{av:"A31FlightArrivalCountryId",fld:"FLIGHTARRIVALCOUNTRYID",pic:"ZZZ9"},{av:"A33FlightArrivalCityId",fld:"FLIGHTARRIVALCITYID",pic:"ZZZ9"},{av:"A26FlightArrivalAirportName",fld:"FLIGHTARRIVALAIRPORTNAME",pic:""},{av:"A32FlightArrivalCountryName",fld:"FLIGHTARRIVALCOUNTRYNAME",pic:""},{av:"A34FlightArrivalCityName",fld:"FLIGHTARRIVALCITYNAME",pic:""}],[{av:"A26FlightArrivalAirportName",fld:"FLIGHTARRIVALAIRPORTNAME",pic:""},{av:"A31FlightArrivalCountryId",fld:"FLIGHTARRIVALCOUNTRYID",pic:"ZZZ9"},{av:"A33FlightArrivalCityId",fld:"FLIGHTARRIVALCITYID",pic:"ZZZ9"},{av:"A32FlightArrivalCountryName",fld:"FLIGHTARRIVALCOUNTRYNAME",pic:""},{av:"A34FlightArrivalCityName",fld:"FLIGHTARRIVALCITYNAME",pic:""}]];this.EvtParms.VALID_FLIGHTARRIVALCOUNTRYID=[[],[]];this.EvtParms.VALID_FLIGHTARRIVALCITYID=[[],[]];this.EvtParms.VALID_FLIGHTDEPARTUREAIRPORTID=[[{av:"A24FlightDepartureAirportId",fld:"FLIGHTDEPARTUREAIRPORTID",pic:"ZZZ9"},{av:"A27FlightDepartureCountryId",fld:"FLIGHTDEPARTURECOUNTRYID",pic:"ZZZ9"},{av:"A29FlightDepartureCityId",fld:"FLIGHTDEPARTURECITYID",pic:"ZZZ9"},{av:"A23FlightDepartureAirportName",fld:"FLIGHTDEPARTUREAIRPORTNAME",pic:""},{av:"A28FlightDepartureCountryName",fld:"FLIGHTDEPARTURECOUNTRYNAME",pic:""},{av:"A30FlightDepartureCityName",fld:"FLIGHTDEPARTURECITYNAME",pic:""}],[{av:"A23FlightDepartureAirportName",fld:"FLIGHTDEPARTUREAIRPORTNAME",pic:""},{av:"A27FlightDepartureCountryId",fld:"FLIGHTDEPARTURECOUNTRYID",pic:"ZZZ9"},{av:"A29FlightDepartureCityId",fld:"FLIGHTDEPARTURECITYID",pic:"ZZZ9"},{av:"A28FlightDepartureCountryName",fld:"FLIGHTDEPARTURECOUNTRYNAME",pic:""},{av:"A30FlightDepartureCityName",fld:"FLIGHTDEPARTURECITYNAME",pic:""}]];this.EvtParms.VALID_FLIGHTDEPARTURECOUNTRYID=[[],[]];this.EvtParms.VALID_FLIGHTDEPARTURECITYID=[[],[]];this.setPrompt("PROMPT_25",[39]);this.setPrompt("PROMPT_24",[69]);this.EnterCtrl=["BTN_ENTER"];this.Initialize()});gx.wi(function(){gx.createParentObj(this.flight)})