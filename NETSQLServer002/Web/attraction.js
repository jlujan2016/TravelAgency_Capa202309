gx.evt.autoSkip = false;
gx.define('attraction', false, function () {
   this.ServerClass =  "attraction" ;
   this.PackageName =  "GeneXus.Programs" ;
   this.ServerFullClass =  "attraction.aspx" ;
   this.setObjectType("trn");
   this.hasEnterEvent = true;
   this.skipOnEnter = false;
   this.fullAjax = true;
   this.supportAjaxEvents =  true ;
   this.ajaxSecurityToken =  true ;
   this.DSO =  "TravelAgency_Capa202309" ;
   this.SetStandaloneVars=function()
   {
      this.A40000AttractionPhoto_GXI=gx.fn.getControlValue("ATTRACTIONPHOTO_GXI") ;
   };
   this.Valid_Attractionid=function()
   {
      return this.validSrvEvt("Valid_Attractionid", 0).then((function (ret) {
      return ret;
      }).closure(this));
   }
   this.Valid_Countryid=function()
   {
      return this.validSrvEvt("Valid_Countryid", 0).then((function (ret) {
      return ret;
      }).closure(this));
   }
   this.Valid_Cityid=function()
   {
      return this.validSrvEvt("Valid_Cityid", 0).then((function (ret) {
      return ret;
      }).closure(this));
   }
   this.Valid_Categoryid=function()
   {
      return this.validSrvEvt("Valid_Categoryid", 0).then((function (ret) {
      return ret;
      }).closure(this));
   }
   this.e11022_client=function()
   {
      return this.executeServerEvent("ENTER", true, null, false, false);
   };
   this.e12022_client=function()
   {
      return this.executeServerEvent("CANCEL", true, null, false, false);
   };
   this.GXValidFnc = [];
   var GXValidFnc = this.GXValidFnc ;
   this.GXCtrlIds=[2,3,4,5,6,7,8,9,10,11,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,52,53,54,55,56,57,58,59,60,61,62,63,64,65,66,67,68,69,70,71,72,73,74,75,76,77,78,79,80,81,82,83,84,85,86];
   this.GXLastCtrlId =86;
   GXValidFnc[2]={ id: 2, fld:"",grid:0};
   GXValidFnc[3]={ id: 3, fld:"MAINTABLE",grid:0};
   GXValidFnc[4]={ id: 4, fld:"",grid:0};
   GXValidFnc[5]={ id: 5, fld:"",grid:0};
   GXValidFnc[6]={ id: 6, fld:"TITLECONTAINER",grid:0};
   GXValidFnc[7]={ id: 7, fld:"",grid:0};
   GXValidFnc[8]={ id: 8, fld:"",grid:0};
   GXValidFnc[9]={ id: 9, fld:"TITLE", format:0,grid:0, ctrltype: "textblock"};
   GXValidFnc[10]={ id: 10, fld:"",grid:0};
   GXValidFnc[11]={ id: 11, fld:"",grid:0};
   GXValidFnc[13]={ id: 13, fld:"",grid:0};
   GXValidFnc[14]={ id: 14, fld:"",grid:0};
   GXValidFnc[15]={ id: 15, fld:"FORMCONTAINER",grid:0};
   GXValidFnc[16]={ id: 16, fld:"",grid:0};
   GXValidFnc[17]={ id: 17, fld:"TOOLBARCELL",grid:0};
   GXValidFnc[18]={ id: 18, fld:"",grid:0};
   GXValidFnc[19]={ id: 19, fld:"",grid:0};
   GXValidFnc[20]={ id: 20, fld:"",grid:0};
   GXValidFnc[21]={ id: 21, fld:"BTN_FIRST",grid:0,evt:"e13022_client",std:"FIRST"};
   GXValidFnc[22]={ id: 22, fld:"",grid:0};
   GXValidFnc[23]={ id: 23, fld:"BTN_PREVIOUS",grid:0,evt:"e14022_client",std:"PREVIOUS"};
   GXValidFnc[24]={ id: 24, fld:"",grid:0};
   GXValidFnc[25]={ id: 25, fld:"BTN_NEXT",grid:0,evt:"e15022_client",std:"NEXT"};
   GXValidFnc[26]={ id: 26, fld:"",grid:0};
   GXValidFnc[27]={ id: 27, fld:"BTN_LAST",grid:0,evt:"e16022_client",std:"LAST"};
   GXValidFnc[28]={ id: 28, fld:"",grid:0};
   GXValidFnc[29]={ id: 29, fld:"BTN_SELECT",grid:0,evt:"e17022_client",std:"SELECT"};
   GXValidFnc[30]={ id: 30, fld:"",grid:0};
   GXValidFnc[31]={ id: 31, fld:"",grid:0};
   GXValidFnc[32]={ id: 32, fld:"",grid:0};
   GXValidFnc[33]={ id: 33, fld:"",grid:0};
   GXValidFnc[34]={ id:34 ,lvl:0,type:"int",len:4,dec:0,sign:false,pic:"ZZZ9",ro:0,grid:0,gxgrid:null,fnc:this.Valid_Attractionid,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"ATTRACTIONID",fmt:0,gxz:"Z7AttractionId",gxold:"O7AttractionId",gxvar:"A7AttractionId",ucs:[],op:[64,54,44,74,39],ip:[64,54,44,74,39,34],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A7AttractionId=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z7AttractionId=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("ATTRACTIONID",gx.O.A7AttractionId,0);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A7AttractionId=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("ATTRACTIONID",',')},nac:gx.falseFn};
   this.declareDomainHdlr( 34 , function() {
   });
   GXValidFnc[35]={ id: 35, fld:"",grid:0};
   GXValidFnc[36]={ id: 36, fld:"",grid:0};
   GXValidFnc[37]={ id: 37, fld:"",grid:0};
   GXValidFnc[38]={ id: 38, fld:"",grid:0};
   GXValidFnc[39]={ id:39 ,lvl:0,type:"svchar",len:40,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"ATTRACTIONNAME",fmt:0,gxz:"Z8AttractionName",gxold:"O8AttractionName",gxvar:"A8AttractionName",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A8AttractionName=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z8AttractionName=Value},v2c:function(){gx.fn.setControlValue("ATTRACTIONNAME",gx.O.A8AttractionName,0);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A8AttractionName=this.val()},val:function(){return gx.fn.getControlValue("ATTRACTIONNAME")},nac:gx.falseFn};
   this.declareDomainHdlr( 39 , function() {
   });
   GXValidFnc[40]={ id: 40, fld:"",grid:0};
   GXValidFnc[41]={ id: 41, fld:"",grid:0};
   GXValidFnc[42]={ id: 42, fld:"",grid:0};
   GXValidFnc[43]={ id: 43, fld:"",grid:0};
   GXValidFnc[44]={ id:44 ,lvl:0,type:"int",len:4,dec:0,sign:false,pic:"ZZZ9",ro:0,grid:0,gxgrid:null,fnc:this.Valid_Countryid,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"COUNTRYID",fmt:0,gxz:"Z9CountryId",gxold:"O9CountryId",gxvar:"A9CountryId",ucs:[],op:[49],ip:[49,44],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A9CountryId=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z9CountryId=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("COUNTRYID",gx.O.A9CountryId,0);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A9CountryId=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("COUNTRYID",',')},nac:gx.falseFn};
   this.declareDomainHdlr( 44 , function() {
   });
   GXValidFnc[45]={ id: 45, fld:"",grid:0};
   GXValidFnc[46]={ id: 46, fld:"",grid:0};
   GXValidFnc[47]={ id: 47, fld:"",grid:0};
   GXValidFnc[48]={ id: 48, fld:"",grid:0};
   GXValidFnc[49]={ id:49 ,lvl:0,type:"svchar",len:40,dec:0,sign:false,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"COUNTRYNAME",fmt:0,gxz:"Z10CountryName",gxold:"O10CountryName",gxvar:"A10CountryName",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A10CountryName=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z10CountryName=Value},v2c:function(){gx.fn.setControlValue("COUNTRYNAME",gx.O.A10CountryName,0);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A10CountryName=this.val()},val:function(){return gx.fn.getControlValue("COUNTRYNAME")},nac:gx.falseFn};
   this.declareDomainHdlr( 49 , function() {
   });
   GXValidFnc[50]={ id: 50, fld:"",grid:0};
   GXValidFnc[51]={ id: 51, fld:"",grid:0};
   GXValidFnc[52]={ id: 52, fld:"",grid:0};
   GXValidFnc[53]={ id: 53, fld:"",grid:0};
   GXValidFnc[54]={ id:54 ,lvl:0,type:"int",len:4,dec:0,sign:false,pic:"ZZZ9",ro:0,grid:0,gxgrid:null,fnc:this.Valid_Cityid,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"CITYID",fmt:0,gxz:"Z14CityId",gxold:"O14CityId",gxvar:"A14CityId",ucs:[],op:[59],ip:[59,54,44],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A14CityId=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z14CityId=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("CITYID",gx.O.A14CityId,0);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A14CityId=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("CITYID",',')},nac:gx.falseFn};
   this.declareDomainHdlr( 54 , function() {
   });
   GXValidFnc[55]={ id: 55, fld:"",grid:0};
   GXValidFnc[56]={ id: 56, fld:"",grid:0};
   GXValidFnc[57]={ id: 57, fld:"",grid:0};
   GXValidFnc[58]={ id: 58, fld:"",grid:0};
   GXValidFnc[59]={ id:59 ,lvl:0,type:"svchar",len:40,dec:0,sign:false,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"CITYNAME",fmt:0,gxz:"Z15CityName",gxold:"O15CityName",gxvar:"A15CityName",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A15CityName=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z15CityName=Value},v2c:function(){gx.fn.setControlValue("CITYNAME",gx.O.A15CityName,0);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A15CityName=this.val()},val:function(){return gx.fn.getControlValue("CITYNAME")},nac:gx.falseFn};
   this.declareDomainHdlr( 59 , function() {
   });
   GXValidFnc[60]={ id: 60, fld:"",grid:0};
   GXValidFnc[61]={ id: 61, fld:"",grid:0};
   GXValidFnc[62]={ id: 62, fld:"",grid:0};
   GXValidFnc[63]={ id: 63, fld:"",grid:0};
   GXValidFnc[64]={ id:64 ,lvl:0,type:"int",len:4,dec:0,sign:false,pic:"ZZZ9",ro:0,grid:0,gxgrid:null,fnc:this.Valid_Categoryid,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"CATEGORYID",fmt:0,gxz:"Z11CategoryId",gxold:"O11CategoryId",gxvar:"A11CategoryId",ucs:[],op:[69],ip:[69,64],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A11CategoryId=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z11CategoryId=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("CATEGORYID",gx.O.A11CategoryId,0);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A11CategoryId=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("CATEGORYID",',')},nac:gx.falseFn};
   this.declareDomainHdlr( 64 , function() {
   });
   GXValidFnc[65]={ id: 65, fld:"",grid:0};
   GXValidFnc[66]={ id: 66, fld:"",grid:0};
   GXValidFnc[67]={ id: 67, fld:"",grid:0};
   GXValidFnc[68]={ id: 68, fld:"",grid:0};
   GXValidFnc[69]={ id:69 ,lvl:0,type:"svchar",len:40,dec:0,sign:false,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"CATEGORYNAME",fmt:0,gxz:"Z12CategoryName",gxold:"O12CategoryName",gxvar:"A12CategoryName",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A12CategoryName=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z12CategoryName=Value},v2c:function(){gx.fn.setControlValue("CATEGORYNAME",gx.O.A12CategoryName,0);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A12CategoryName=this.val()},val:function(){return gx.fn.getControlValue("CATEGORYNAME")},nac:gx.falseFn};
   this.declareDomainHdlr( 69 , function() {
   });
   GXValidFnc[70]={ id: 70, fld:"",grid:0};
   GXValidFnc[71]={ id: 71, fld:"",grid:0};
   GXValidFnc[72]={ id: 72, fld:"",grid:0};
   GXValidFnc[73]={ id: 73, fld:"",grid:0};
   GXValidFnc[74]={ id:74 ,lvl:0,type:"bits",len:1024,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"ATTRACTIONPHOTO",fmt:0,gxz:"Z13AttractionPhoto",gxold:"O13AttractionPhoto",gxvar:"A13AttractionPhoto",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A13AttractionPhoto=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z13AttractionPhoto=Value},v2c:function(){gx.fn.setMultimediaValue("ATTRACTIONPHOTO",gx.O.A13AttractionPhoto,gx.O.A40000AttractionPhoto_GXI)},c2v:function(){gx.O.A40000AttractionPhoto_GXI=this.val_GXI();if(this.val()!==undefined)gx.O.A13AttractionPhoto=this.val()},val:function(){return gx.fn.getBlobValue("ATTRACTIONPHOTO")},val_GXI:function(){return gx.fn.getControlValue("ATTRACTIONPHOTO_GXI")}, gxvar_GXI:'A40000AttractionPhoto_GXI',nac:gx.falseFn};
   GXValidFnc[75]={ id: 75, fld:"",grid:0};
   GXValidFnc[76]={ id: 76, fld:"",grid:0};
   GXValidFnc[77]={ id: 77, fld:"",grid:0};
   GXValidFnc[78]={ id: 78, fld:"",grid:0};
   GXValidFnc[79]={ id: 79, fld:"BTN_ENTER",grid:0,evt:"e11022_client",std:"ENTER"};
   GXValidFnc[80]={ id: 80, fld:"",grid:0};
   GXValidFnc[81]={ id: 81, fld:"BTN_CANCEL",grid:0,evt:"e12022_client"};
   GXValidFnc[82]={ id: 82, fld:"",grid:0};
   GXValidFnc[83]={ id: 83, fld:"BTN_DELETE",grid:0,evt:"e18022_client",std:"DELETE"};
   GXValidFnc[84]={ id: 84, fld:"PROMPT_9",grid:2};
   GXValidFnc[85]={ id: 85, fld:"PROMPT_14",grid:2};
   GXValidFnc[86]={ id: 86, fld:"PROMPT_11",grid:2};
   this.A7AttractionId = 0 ;
   this.Z7AttractionId = 0 ;
   this.O7AttractionId = 0 ;
   this.A8AttractionName = "" ;
   this.Z8AttractionName = "" ;
   this.O8AttractionName = "" ;
   this.A9CountryId = 0 ;
   this.Z9CountryId = 0 ;
   this.O9CountryId = 0 ;
   this.A10CountryName = "" ;
   this.Z10CountryName = "" ;
   this.O10CountryName = "" ;
   this.A14CityId = 0 ;
   this.Z14CityId = 0 ;
   this.O14CityId = 0 ;
   this.A15CityName = "" ;
   this.Z15CityName = "" ;
   this.O15CityName = "" ;
   this.A11CategoryId = 0 ;
   this.Z11CategoryId = 0 ;
   this.O11CategoryId = 0 ;
   this.A12CategoryName = "" ;
   this.Z12CategoryName = "" ;
   this.O12CategoryName = "" ;
   this.A40000AttractionPhoto_GXI = "" ;
   this.A13AttractionPhoto = "" ;
   this.Z13AttractionPhoto = "" ;
   this.O13AttractionPhoto = "" ;
   this.A40000AttractionPhoto_GXI = "" ;
   this.A7AttractionId = 0 ;
   this.A8AttractionName = "" ;
   this.A9CountryId = 0 ;
   this.A10CountryName = "" ;
   this.A14CityId = 0 ;
   this.A15CityName = "" ;
   this.A11CategoryId = 0 ;
   this.A12CategoryName = "" ;
   this.A13AttractionPhoto = "" ;
   this.Events = {"e11022_client": ["ENTER", true] ,"e12022_client": ["CANCEL", true]};
   this.EvtParms["ENTER"] = [[{postForm:true}],[]];
   this.EvtParms["REFRESH"] = [[],[]];
   this.EvtParms["VALID_ATTRACTIONID"] = [[{av:'A7AttractionId',fld:'ATTRACTIONID',pic:'ZZZ9'},{av:'Gx_mode',fld:'vMODE',pic:'@!'}],[{av:'A8AttractionName',fld:'ATTRACTIONNAME',pic:''},{av:'A9CountryId',fld:'COUNTRYID',pic:'ZZZ9'},{av:'A14CityId',fld:'CITYID',pic:'ZZZ9'},{av:'A11CategoryId',fld:'CATEGORYID',pic:'ZZZ9'},{av:'A13AttractionPhoto',fld:'ATTRACTIONPHOTO',pic:''},{av:'A40000AttractionPhoto_GXI',fld:'ATTRACTIONPHOTO_GXI',pic:''},{av:'A10CountryName',fld:'COUNTRYNAME',pic:''},{av:'A15CityName',fld:'CITYNAME',pic:''},{av:'A12CategoryName',fld:'CATEGORYNAME',pic:''},{av:'Gx_mode',fld:'vMODE',pic:'@!'},{av:'Z7AttractionId'},{av:'Z8AttractionName'},{av:'Z9CountryId'},{av:'Z14CityId'},{av:'Z11CategoryId'},{av:'Z13AttractionPhoto'},{av:'Z40000AttractionPhoto_GXI'},{av:'Z10CountryName'},{av:'Z15CityName'},{av:'Z12CategoryName'},{ctrl:'BTN_DELETE',prop:'Enabled'},{ctrl:'BTN_ENTER',prop:'Enabled'}]];
   this.EvtParms["VALID_COUNTRYID"] = [[{av:'A9CountryId',fld:'COUNTRYID',pic:'ZZZ9'},{av:'A10CountryName',fld:'COUNTRYNAME',pic:''}],[{av:'A10CountryName',fld:'COUNTRYNAME',pic:''}]];
   this.EvtParms["VALID_CITYID"] = [[{av:'A9CountryId',fld:'COUNTRYID',pic:'ZZZ9'},{av:'A14CityId',fld:'CITYID',pic:'ZZZ9'},{av:'A15CityName',fld:'CITYNAME',pic:''}],[{av:'A15CityName',fld:'CITYNAME',pic:''}]];
   this.EvtParms["VALID_CATEGORYID"] = [[{av:'A11CategoryId',fld:'CATEGORYID',pic:'ZZZ9'},{av:'A12CategoryName',fld:'CATEGORYNAME',pic:''}],[{av:'A12CategoryName',fld:'CATEGORYNAME',pic:''}]];
   this.setPrompt("PROMPT_9", [44]);
   this.setPrompt("PROMPT_14", [54]);
   this.setPrompt("PROMPT_11", [64]);
   this.EnterCtrl = ["BTN_ENTER"];
   this.setVCMap("A40000AttractionPhoto_GXI", "ATTRACTIONPHOTO_GXI", 0, "svchar", 2048, 0);
   this.Initialize( );
});
gx.wi( function() { gx.createParentObj(this.attraction);});
