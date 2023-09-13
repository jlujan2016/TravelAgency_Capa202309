gx.evt.autoSkip = false;
gx.define('country', false, function () {
   this.ServerClass =  "country" ;
   this.PackageName =  "GeneXus.Programs" ;
   this.ServerFullClass =  "country.aspx" ;
   this.setObjectType("trn");
   this.anyGridBaseTable = true;
   this.hasEnterEvent = true;
   this.skipOnEnter = false;
   this.fullAjax = true;
   this.supportAjaxEvents =  true ;
   this.ajaxSecurityToken =  true ;
   this.DSO =  "TravelAgency_Capa202309" ;
   this.SetStandaloneVars=function()
   {
   };
   this.Valid_Countryid=function()
   {
      return this.validSrvEvt("Valid_Countryid", 0).then((function (ret) {
      return ret;
      }).closure(this));
   }
   this.Valid_Cityid=function()
   {
      var currentRow = gx.fn.currentGridRowImpl(48);
      return this.validCliEvt("Valid_Cityid", 48, function () {
      try {
         if(  gx.fn.currentGridRowImpl(48) ===0) {
            return true;
         }
         var gxballoon = gx.util.balloon.getNew("CITYID", gx.fn.currentGridRowImpl(48));
         this.AnyError  = 0;
         this.sMode5 =  this.Gx_mode  ;
         this.Gx_mode =  gx.fn.getGridRowMode(5,48)  ;
         this.standaloneModal035( );
         this.standaloneNotModal035( );
         if ( gx.fn.gridDuplicateKey(49) )
         {
            gxballoon.setError(gx.text.format( gx.getMessage( "GXM_1004"), "City", "", "", "", "", "", "", "", ""));
            this.AnyError = gx.num.trunc( 1 ,0) ;
         }

      }
      catch(e){}
      try {
          this.Gx_mode =  this.sMode5  ;
          if (gxballoon == null) return true; return gxballoon.show();
      }
      catch(e){}
      return true ;
      });
   }
   this.standaloneModal035=function()
   {
      try {
         if ( gx.text.compare( this.Gx_mode , "INS" ) != 0 )
         {
            gx.fn.setCtrlProperty("CITYID","Enabled", 0 );
         }
         else
         {
            gx.fn.setCtrlProperty("CITYID","Enabled", 1 );
         }
      }
      catch(e){}
   }
   this.standaloneNotModal035=function()
   {
   }
   this.e11033_client=function()
   {
      return this.executeServerEvent("ENTER", true, null, false, false);
   };
   this.e12033_client=function()
   {
      return this.executeServerEvent("CANCEL", true, null, false, false);
   };
   this.GXValidFnc = [];
   var GXValidFnc = this.GXValidFnc ;
   this.GXCtrlIds=[2,3,4,5,6,7,8,9,10,11,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,49,50,51,52,53,54,55,56,57,58,59];
   this.GXLastCtrlId =59;
   this.Gridcountry_cityContainer = new gx.grid.grid(this, 5,"City",48,"Gridcountry_city","Gridcountry_city","Gridcountry_cityContainer",this.CmpContext,this.IsMasterPage,"country",[14],false,1,false,true,5,false,false,false,"",0,"px",0,"px","New row",true,false,false,null,null,false,"",false,[1,1,1,1],false,0,true,false);
   var Gridcountry_cityContainer = this.Gridcountry_cityContainer;
   Gridcountry_cityContainer.addSingleLineEdit(14,49,"CITYID","Id","","CityId","int",0,"px",4,4,"end",null,[],14,"CityId",true,0,false,false,"Attribute",0,"");
   Gridcountry_cityContainer.addSingleLineEdit(15,50,"CITYNAME","Name","","CityName","svchar",0,"px",40,40,"start",null,[],15,"CityName",true,0,false,false,"Attribute",0,"");
   this.Gridcountry_cityContainer.emptyText = "";
   this.setGrid(Gridcountry_cityContainer);
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
   GXValidFnc[21]={ id: 21, fld:"BTN_FIRST",grid:0,evt:"e13033_client",std:"FIRST"};
   GXValidFnc[22]={ id: 22, fld:"",grid:0};
   GXValidFnc[23]={ id: 23, fld:"BTN_PREVIOUS",grid:0,evt:"e14033_client",std:"PREVIOUS"};
   GXValidFnc[24]={ id: 24, fld:"",grid:0};
   GXValidFnc[25]={ id: 25, fld:"BTN_NEXT",grid:0,evt:"e15033_client",std:"NEXT"};
   GXValidFnc[26]={ id: 26, fld:"",grid:0};
   GXValidFnc[27]={ id: 27, fld:"BTN_LAST",grid:0,evt:"e16033_client",std:"LAST"};
   GXValidFnc[28]={ id: 28, fld:"",grid:0};
   GXValidFnc[29]={ id: 29, fld:"BTN_SELECT",grid:0,evt:"e17033_client",std:"SELECT"};
   GXValidFnc[30]={ id: 30, fld:"",grid:0};
   GXValidFnc[31]={ id: 31, fld:"",grid:0};
   GXValidFnc[32]={ id: 32, fld:"",grid:0};
   GXValidFnc[33]={ id: 33, fld:"",grid:0};
   GXValidFnc[34]={ id:34 ,lvl:0,type:"int",len:4,dec:0,sign:false,pic:"ZZZ9",ro:0,grid:0,gxgrid:null,fnc:this.Valid_Countryid,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.Gridcountry_cityContainer],fld:"COUNTRYID",fmt:0,gxz:"Z9CountryId",gxold:"O9CountryId",gxvar:"A9CountryId",ucs:[],op:[39],ip:[39,34],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A9CountryId=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z9CountryId=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("COUNTRYID",gx.O.A9CountryId,0);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A9CountryId=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("COUNTRYID",',')},nac:gx.falseFn};
   this.declareDomainHdlr( 34 , function() {
   });
   GXValidFnc[35]={ id: 35, fld:"",grid:0};
   GXValidFnc[36]={ id: 36, fld:"",grid:0};
   GXValidFnc[37]={ id: 37, fld:"",grid:0};
   GXValidFnc[38]={ id: 38, fld:"",grid:0};
   GXValidFnc[39]={ id:39 ,lvl:0,type:"svchar",len:40,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"COUNTRYNAME",fmt:0,gxz:"Z10CountryName",gxold:"O10CountryName",gxvar:"A10CountryName",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A10CountryName=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z10CountryName=Value},v2c:function(){gx.fn.setControlValue("COUNTRYNAME",gx.O.A10CountryName,0);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A10CountryName=this.val()},val:function(){return gx.fn.getControlValue("COUNTRYNAME")},nac:gx.falseFn};
   this.declareDomainHdlr( 39 , function() {
   });
   GXValidFnc[40]={ id: 40, fld:"",grid:0};
   GXValidFnc[41]={ id: 41, fld:"",grid:0};
   GXValidFnc[42]={ id: 42, fld:"CITYTABLE",grid:0};
   GXValidFnc[43]={ id: 43, fld:"",grid:0};
   GXValidFnc[44]={ id: 44, fld:"",grid:0};
   GXValidFnc[45]={ id: 45, fld:"TITLECITY", format:0,grid:0, ctrltype: "textblock"};
   GXValidFnc[46]={ id: 46, fld:"",grid:0};
   GXValidFnc[47]={ id: 47, fld:"",grid:0};
   GXValidFnc[49]={ id:49 ,lvl:5,type:"int",len:4,dec:0,sign:false,pic:"ZZZ9",ro:0,isacc:1,grid:48,gxgrid:this.Gridcountry_cityContainer,fnc:this.Valid_Cityid,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"CITYID",fmt:0,gxz:"Z14CityId",gxold:"O14CityId",gxvar:"A14CityId",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',v2v:function(Value){if(Value!==undefined)gx.O.A14CityId=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z14CityId=gx.num.intval(Value)},v2c:function(row){gx.fn.setGridControlValue("CITYID",row || gx.fn.currentGridRowImpl(48),gx.O.A14CityId,0);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(row){if(this.val(row)!==undefined)gx.O.A14CityId=gx.num.intval(this.val(row))},val:function(row){return gx.fn.getGridIntegerValue("CITYID",row || gx.fn.currentGridRowImpl(48),',')},nac:gx.falseFn};
   GXValidFnc[50]={ id:50 ,lvl:5,type:"svchar",len:40,dec:0,sign:false,ro:0,isacc:1,grid:48,gxgrid:this.Gridcountry_cityContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"CITYNAME",fmt:0,gxz:"Z15CityName",gxold:"O15CityName",gxvar:"A15CityName",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',autoCorrect:"1",v2v:function(Value){if(Value!==undefined)gx.O.A15CityName=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z15CityName=Value},v2c:function(row){gx.fn.setGridControlValue("CITYNAME",row || gx.fn.currentGridRowImpl(48),gx.O.A15CityName,0);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(row){if(this.val(row)!==undefined)gx.O.A15CityName=this.val(row)},val:function(row){return gx.fn.getGridControlValue("CITYNAME",row || gx.fn.currentGridRowImpl(48))},nac:gx.falseFn};
   GXValidFnc[51]={ id: 51, fld:"",grid:0};
   GXValidFnc[52]={ id: 52, fld:"",grid:0};
   GXValidFnc[53]={ id: 53, fld:"",grid:0};
   GXValidFnc[54]={ id: 54, fld:"",grid:0};
   GXValidFnc[55]={ id: 55, fld:"BTN_ENTER",grid:0,evt:"e11033_client",std:"ENTER"};
   GXValidFnc[56]={ id: 56, fld:"",grid:0};
   GXValidFnc[57]={ id: 57, fld:"BTN_CANCEL",grid:0,evt:"e12033_client"};
   GXValidFnc[58]={ id: 58, fld:"",grid:0};
   GXValidFnc[59]={ id: 59, fld:"BTN_DELETE",grid:0,evt:"e18033_client",std:"DELETE"};
   this.A9CountryId = 0 ;
   this.Z9CountryId = 0 ;
   this.O9CountryId = 0 ;
   this.A10CountryName = "" ;
   this.Z10CountryName = "" ;
   this.O10CountryName = "" ;
   this.Z14CityId = 0 ;
   this.O14CityId = 0 ;
   this.Z15CityName = "" ;
   this.O15CityName = "" ;
   this.A14CityId = 0 ;
   this.A15CityName = "" ;
   this.A9CountryId = 0 ;
   this.A10CountryName = "" ;
   this.Events = {"e11033_client": ["ENTER", true] ,"e12033_client": ["CANCEL", true]};
   this.EvtParms["ENTER"] = [[{postForm:true}],[]];
   this.EvtParms["REFRESH"] = [[],[]];
   this.EvtParms["VALID_COUNTRYID"] = [[{av:'A9CountryId',fld:'COUNTRYID',pic:'ZZZ9'},{av:'Gx_mode',fld:'vMODE',pic:'@!'}],[{av:'A10CountryName',fld:'COUNTRYNAME',pic:''},{av:'Gx_mode',fld:'vMODE',pic:'@!'},{av:'Z9CountryId'},{av:'Z10CountryName'},{ctrl:'BTN_DELETE',prop:'Enabled'},{ctrl:'BTN_ENTER',prop:'Enabled'}]];
   this.EvtParms["VALID_CITYID"] = [[],[]];
   this.EnterCtrl = ["BTN_ENTER"];
   Gridcountry_cityContainer.addPostingVar({rfrVar:"Gx_mode"});
   this.Initialize( );
});
gx.wi( function() { gx.createParentObj(this.country);});
