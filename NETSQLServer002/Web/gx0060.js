gx.evt.autoSkip=!1;gx.define("gx0060",!1,function(){var n,t;this.ServerClass="gx0060";this.PackageName="GeneXus.Programs";this.ServerFullClass="gx0060.aspx";this.setObjectType("web");this.anyGridBaseTable=!0;this.hasEnterEvent=!0;this.skipOnEnter=!1;this.autoRefresh=!0;this.fullAjax=!0;this.supportAjaxEvents=!0;this.ajaxSecurityToken=!0;this.DSO="TravelAgency_Capa202309";this.SetStandaloneVars=function(){this.AV7pFlightId=gx.fn.getIntegerValue("vPFLIGHTID",",")};this.e140j1_client=function(){return this.clearMessages(),gx.text.compare(gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class"),"AdvancedContainer")==0?(gx.fn.setCtrlProperty("ADVANCEDCONTAINER","Class","AdvancedContainer AdvancedContainerVisible"),gx.fn.setCtrlProperty("BTNTOGGLE","Class",gx.fn.getCtrlProperty("BTNTOGGLE","Class")+" BtnToggleActive")):(gx.fn.setCtrlProperty("ADVANCEDCONTAINER","Class","AdvancedContainer"),gx.fn.setCtrlProperty("BTNTOGGLE","Class","BtnToggle")),this.refreshOutputs([{av:'gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")',ctrl:"ADVANCEDCONTAINER",prop:"Class"},{ctrl:"BTNTOGGLE",prop:"Class"}]),this.OnClientEventEnd(),gx.$.Deferred().resolve()};this.e110j1_client=function(){return this.clearMessages(),gx.text.compare(gx.fn.getCtrlProperty("FLIGHTIDFILTERCONTAINER","Class"),"AdvancedContainerItem")==0?(gx.fn.setCtrlProperty("FLIGHTIDFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCFLIGHTID","Visible",!0)):(gx.fn.setCtrlProperty("FLIGHTIDFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCFLIGHTID","Visible",!1)),this.refreshOutputs([{av:'gx.fn.getCtrlProperty("FLIGHTIDFILTERCONTAINER","Class")',ctrl:"FLIGHTIDFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCFLIGHTID","Visible")',ctrl:"vCFLIGHTID",prop:"Visible"}]),this.OnClientEventEnd(),gx.$.Deferred().resolve()};this.e120j1_client=function(){return this.clearMessages(),gx.text.compare(gx.fn.getCtrlProperty("FLIGHTARRIVALAIRPORTIDFILTERCONTAINER","Class"),"AdvancedContainerItem")==0?(gx.fn.setCtrlProperty("FLIGHTARRIVALAIRPORTIDFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCFLIGHTARRIVALAIRPORTID","Visible",!0)):(gx.fn.setCtrlProperty("FLIGHTARRIVALAIRPORTIDFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCFLIGHTARRIVALAIRPORTID","Visible",!1)),this.refreshOutputs([{av:'gx.fn.getCtrlProperty("FLIGHTARRIVALAIRPORTIDFILTERCONTAINER","Class")',ctrl:"FLIGHTARRIVALAIRPORTIDFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCFLIGHTARRIVALAIRPORTID","Visible")',ctrl:"vCFLIGHTARRIVALAIRPORTID",prop:"Visible"}]),this.OnClientEventEnd(),gx.$.Deferred().resolve()};this.e130j1_client=function(){return this.clearMessages(),gx.text.compare(gx.fn.getCtrlProperty("FLIGHTDEPARTUREAIRPORTIDFILTERCONTAINER","Class"),"AdvancedContainerItem")==0?(gx.fn.setCtrlProperty("FLIGHTDEPARTUREAIRPORTIDFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCFLIGHTDEPARTUREAIRPORTID","Visible",!0)):(gx.fn.setCtrlProperty("FLIGHTDEPARTUREAIRPORTIDFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCFLIGHTDEPARTUREAIRPORTID","Visible",!1)),this.refreshOutputs([{av:'gx.fn.getCtrlProperty("FLIGHTDEPARTUREAIRPORTIDFILTERCONTAINER","Class")',ctrl:"FLIGHTDEPARTUREAIRPORTIDFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCFLIGHTDEPARTUREAIRPORTID","Visible")',ctrl:"vCFLIGHTDEPARTUREAIRPORTID",prop:"Visible"}]),this.OnClientEventEnd(),gx.$.Deferred().resolve()};this.e170j2_client=function(){return this.executeServerEvent("ENTER",!0,arguments[0],!1,!1)};this.e180j1_client=function(){return this.executeServerEvent("CANCEL",!0,null,!1,!1)};this.GXValidFnc=[];n=this.GXValidFnc;this.GXCtrlIds=[2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,45,46,47,48,49,50,51];this.GXLastCtrlId=51;this.Grid1Container=new gx.grid.grid(this,2,"WbpLvl2",44,"Grid1","Grid1","Grid1Container",this.CmpContext,this.IsMasterPage,"gx0060",[],!1,1,!1,!0,10,!0,!1,!1,"",0,"px",0,"px","New row",!0,!1,!1,null,null,!1,"",!1,[1,1,1,1],!1,0,!0,!1);t=this.Grid1Container;t.addBitmap("&Linkselection","vLINKSELECTION",45,0,"px",17,"px",null,"","","SelectionAttribute","WWActionColumn");t.addSingleLineEdit(19,46,"FLIGHTID","Id","","FlightId","int",0,"px",4,4,"end",null,[],19,"FlightId",!0,0,!1,!1,"Attribute",0,"WWColumn");t.addSingleLineEdit(25,47,"FLIGHTARRIVALAIRPORTID","Airport Id","","FlightArrivalAirportId","int",0,"px",4,4,"end",null,[],25,"FlightArrivalAirportId",!0,0,!1,!1,"Attribute",0,"WWColumn OptionalColumn");t.addSingleLineEdit(24,48,"FLIGHTDEPARTUREAIRPORTID","Airport Id","","FlightDepartureAirportId","int",0,"px",4,4,"end",null,[],24,"FlightDepartureAirportId",!0,0,!1,!1,"Attribute",0,"WWColumn OptionalColumn");this.Grid1Container.emptyText="";this.setGrid(t);n[2]={id:2,fld:"",grid:0};n[3]={id:3,fld:"MAIN",grid:0};n[4]={id:4,fld:"",grid:0};n[5]={id:5,fld:"",grid:0};n[6]={id:6,fld:"ADVANCEDCONTAINER",grid:0};n[7]={id:7,fld:"",grid:0};n[8]={id:8,fld:"",grid:0};n[9]={id:9,fld:"FLIGHTIDFILTERCONTAINER",grid:0};n[10]={id:10,fld:"",grid:0};n[11]={id:11,fld:"",grid:0};n[12]={id:12,fld:"LBLFLIGHTIDFILTER",format:1,grid:0,evt:"e110j1_client",ctrltype:"textblock"};n[13]={id:13,fld:"",grid:0};n[14]={id:14,fld:"",grid:0};n[15]={id:15,fld:"",grid:0};n[16]={id:16,lvl:0,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.Grid1Container],fld:"vCFLIGHTID",fmt:0,gxz:"ZV6cFlightId",gxold:"OV6cFlightId",gxvar:"AV6cFlightId",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV6cFlightId=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.ZV6cFlightId=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("vCFLIGHTID",gx.O.AV6cFlightId,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV6cFlightId=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("vCFLIGHTID",",")},nac:gx.falseFn};n[17]={id:17,fld:"",grid:0};n[18]={id:18,fld:"",grid:0};n[19]={id:19,fld:"FLIGHTARRIVALAIRPORTIDFILTERCONTAINER",grid:0};n[20]={id:20,fld:"",grid:0};n[21]={id:21,fld:"",grid:0};n[22]={id:22,fld:"LBLFLIGHTARRIVALAIRPORTIDFILTER",format:1,grid:0,evt:"e120j1_client",ctrltype:"textblock"};n[23]={id:23,fld:"",grid:0};n[24]={id:24,fld:"",grid:0};n[25]={id:25,fld:"",grid:0};n[26]={id:26,lvl:0,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.Grid1Container],fld:"vCFLIGHTARRIVALAIRPORTID",fmt:0,gxz:"ZV11cFlightArrivalAirportId",gxold:"OV11cFlightArrivalAirportId",gxvar:"AV11cFlightArrivalAirportId",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV11cFlightArrivalAirportId=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.ZV11cFlightArrivalAirportId=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("vCFLIGHTARRIVALAIRPORTID",gx.O.AV11cFlightArrivalAirportId,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV11cFlightArrivalAirportId=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("vCFLIGHTARRIVALAIRPORTID",",")},nac:gx.falseFn};n[27]={id:27,fld:"",grid:0};n[28]={id:28,fld:"",grid:0};n[29]={id:29,fld:"FLIGHTDEPARTUREAIRPORTIDFILTERCONTAINER",grid:0};n[30]={id:30,fld:"",grid:0};n[31]={id:31,fld:"",grid:0};n[32]={id:32,fld:"LBLFLIGHTDEPARTUREAIRPORTIDFILTER",format:1,grid:0,evt:"e130j1_client",ctrltype:"textblock"};n[33]={id:33,fld:"",grid:0};n[34]={id:34,fld:"",grid:0};n[35]={id:35,fld:"",grid:0};n[36]={id:36,lvl:0,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.Grid1Container],fld:"vCFLIGHTDEPARTUREAIRPORTID",fmt:0,gxz:"ZV13cFlightDepartureAirportId",gxold:"OV13cFlightDepartureAirportId",gxvar:"AV13cFlightDepartureAirportId",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV13cFlightDepartureAirportId=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.ZV13cFlightDepartureAirportId=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("vCFLIGHTDEPARTUREAIRPORTID",gx.O.AV13cFlightDepartureAirportId,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV13cFlightDepartureAirportId=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("vCFLIGHTDEPARTUREAIRPORTID",",")},nac:gx.falseFn};n[37]={id:37,fld:"",grid:0};n[38]={id:38,fld:"GRIDTABLE",grid:0};n[39]={id:39,fld:"",grid:0};n[40]={id:40,fld:"",grid:0};n[41]={id:41,fld:"BTNTOGGLE",grid:0,evt:"e140j1_client"};n[42]={id:42,fld:"",grid:0};n[43]={id:43,fld:"",grid:0};n[45]={id:45,lvl:2,type:"bits",len:1024,dec:0,sign:!1,ro:1,isacc:0,grid:44,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vLINKSELECTION",fmt:0,gxz:"ZV5LinkSelection",gxold:"OV5LinkSelection",gxvar:"AV5LinkSelection",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.AV5LinkSelection=n)},v2z:function(n){n!==undefined&&(gx.O.ZV5LinkSelection=n)},v2c:function(n){gx.fn.setGridMultimediaValue("vLINKSELECTION",n||gx.fn.currentGridRowImpl(44),gx.O.AV5LinkSelection,gx.O.AV14Linkselection_GXI)},c2v:function(n){gx.O.AV14Linkselection_GXI=this.val_GXI();this.val(n)!==undefined&&(gx.O.AV5LinkSelection=this.val(n))},val:function(n){return gx.fn.getGridControlValue("vLINKSELECTION",n||gx.fn.currentGridRowImpl(44))},val_GXI:function(n){return gx.fn.getGridControlValue("vLINKSELECTION_GXI",n||gx.fn.currentGridRowImpl(44))},gxvar_GXI:"AV14Linkselection_GXI",nac:gx.falseFn};n[46]={id:46,lvl:2,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:1,isacc:0,grid:44,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"FLIGHTID",fmt:0,gxz:"Z19FlightId",gxold:"O19FlightId",gxvar:"A19FlightId",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.A19FlightId=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z19FlightId=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("FLIGHTID",n||gx.fn.currentGridRowImpl(44),gx.O.A19FlightId,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(n){this.val(n)!==undefined&&(gx.O.A19FlightId=gx.num.intval(this.val(n)))},val:function(n){return gx.fn.getGridIntegerValue("FLIGHTID",n||gx.fn.currentGridRowImpl(44),",")},nac:gx.falseFn};n[47]={id:47,lvl:2,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:1,isacc:0,grid:44,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"FLIGHTARRIVALAIRPORTID",fmt:0,gxz:"Z25FlightArrivalAirportId",gxold:"O25FlightArrivalAirportId",gxvar:"A25FlightArrivalAirportId",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.A25FlightArrivalAirportId=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z25FlightArrivalAirportId=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("FLIGHTARRIVALAIRPORTID",n||gx.fn.currentGridRowImpl(44),gx.O.A25FlightArrivalAirportId,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(n){this.val(n)!==undefined&&(gx.O.A25FlightArrivalAirportId=gx.num.intval(this.val(n)))},val:function(n){return gx.fn.getGridIntegerValue("FLIGHTARRIVALAIRPORTID",n||gx.fn.currentGridRowImpl(44),",")},nac:gx.falseFn};n[48]={id:48,lvl:2,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:1,isacc:0,grid:44,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"FLIGHTDEPARTUREAIRPORTID",fmt:0,gxz:"Z24FlightDepartureAirportId",gxold:"O24FlightDepartureAirportId",gxvar:"A24FlightDepartureAirportId",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.A24FlightDepartureAirportId=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z24FlightDepartureAirportId=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("FLIGHTDEPARTUREAIRPORTID",n||gx.fn.currentGridRowImpl(44),gx.O.A24FlightDepartureAirportId,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(n){this.val(n)!==undefined&&(gx.O.A24FlightDepartureAirportId=gx.num.intval(this.val(n)))},val:function(n){return gx.fn.getGridIntegerValue("FLIGHTDEPARTUREAIRPORTID",n||gx.fn.currentGridRowImpl(44),",")},nac:gx.falseFn};n[49]={id:49,fld:"",grid:0};n[50]={id:50,fld:"",grid:0};n[51]={id:51,fld:"BTN_CANCEL",grid:0,evt:"e180j1_client"};this.AV6cFlightId=0;this.ZV6cFlightId=0;this.OV6cFlightId=0;this.AV11cFlightArrivalAirportId=0;this.ZV11cFlightArrivalAirportId=0;this.OV11cFlightArrivalAirportId=0;this.AV13cFlightDepartureAirportId=0;this.ZV13cFlightDepartureAirportId=0;this.OV13cFlightDepartureAirportId=0;this.ZV5LinkSelection="";this.OV5LinkSelection="";this.Z19FlightId=0;this.O19FlightId=0;this.Z25FlightArrivalAirportId=0;this.O25FlightArrivalAirportId=0;this.Z24FlightDepartureAirportId=0;this.O24FlightDepartureAirportId=0;this.AV6cFlightId=0;this.AV11cFlightArrivalAirportId=0;this.AV13cFlightDepartureAirportId=0;this.AV7pFlightId=0;this.AV5LinkSelection="";this.A19FlightId=0;this.A25FlightArrivalAirportId=0;this.A24FlightDepartureAirportId=0;this.Events={e170j2_client:["ENTER",!0],e180j1_client:["CANCEL",!0],e140j1_client:["'TOGGLE'",!1],e110j1_client:["LBLFLIGHTIDFILTER.CLICK",!1],e120j1_client:["LBLFLIGHTARRIVALAIRPORTIDFILTER.CLICK",!1],e130j1_client:["LBLFLIGHTDEPARTUREAIRPORTIDFILTER.CLICK",!1]};this.EvtParms.REFRESH=[[{av:"GRID1_nFirstRecordOnPage"},{av:"GRID1_nEOF"},{ctrl:"GRID1",prop:"Rows"},{av:"AV6cFlightId",fld:"vCFLIGHTID",pic:"ZZZ9"},{av:"AV11cFlightArrivalAirportId",fld:"vCFLIGHTARRIVALAIRPORTID",pic:"ZZZ9"},{av:"AV13cFlightDepartureAirportId",fld:"vCFLIGHTDEPARTUREAIRPORTID",pic:"ZZZ9"}],[]];this.EvtParms["'TOGGLE'"]=[[{av:'gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")',ctrl:"ADVANCEDCONTAINER",prop:"Class"},{ctrl:"BTNTOGGLE",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")',ctrl:"ADVANCEDCONTAINER",prop:"Class"},{ctrl:"BTNTOGGLE",prop:"Class"}]];this.EvtParms["LBLFLIGHTIDFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("FLIGHTIDFILTERCONTAINER","Class")',ctrl:"FLIGHTIDFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("FLIGHTIDFILTERCONTAINER","Class")',ctrl:"FLIGHTIDFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCFLIGHTID","Visible")',ctrl:"vCFLIGHTID",prop:"Visible"}]];this.EvtParms["LBLFLIGHTARRIVALAIRPORTIDFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("FLIGHTARRIVALAIRPORTIDFILTERCONTAINER","Class")',ctrl:"FLIGHTARRIVALAIRPORTIDFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("FLIGHTARRIVALAIRPORTIDFILTERCONTAINER","Class")',ctrl:"FLIGHTARRIVALAIRPORTIDFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCFLIGHTARRIVALAIRPORTID","Visible")',ctrl:"vCFLIGHTARRIVALAIRPORTID",prop:"Visible"}]];this.EvtParms["LBLFLIGHTDEPARTUREAIRPORTIDFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("FLIGHTDEPARTUREAIRPORTIDFILTERCONTAINER","Class")',ctrl:"FLIGHTDEPARTUREAIRPORTIDFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("FLIGHTDEPARTUREAIRPORTIDFILTERCONTAINER","Class")',ctrl:"FLIGHTDEPARTUREAIRPORTIDFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCFLIGHTDEPARTUREAIRPORTID","Visible")',ctrl:"vCFLIGHTDEPARTUREAIRPORTID",prop:"Visible"}]];this.EvtParms.ENTER=[[{av:"A19FlightId",fld:"FLIGHTID",pic:"ZZZ9",hsh:!0}],[{av:"AV7pFlightId",fld:"vPFLIGHTID",pic:"ZZZ9"}]];this.EvtParms.GRID1_FIRSTPAGE=[[{av:"GRID1_nFirstRecordOnPage"},{av:"GRID1_nEOF"},{ctrl:"GRID1",prop:"Rows"},{av:"AV6cFlightId",fld:"vCFLIGHTID",pic:"ZZZ9"},{av:"AV11cFlightArrivalAirportId",fld:"vCFLIGHTARRIVALAIRPORTID",pic:"ZZZ9"},{av:"AV13cFlightDepartureAirportId",fld:"vCFLIGHTDEPARTUREAIRPORTID",pic:"ZZZ9"}],[]];this.EvtParms.GRID1_PREVPAGE=[[{av:"GRID1_nFirstRecordOnPage"},{av:"GRID1_nEOF"},{ctrl:"GRID1",prop:"Rows"},{av:"AV6cFlightId",fld:"vCFLIGHTID",pic:"ZZZ9"},{av:"AV11cFlightArrivalAirportId",fld:"vCFLIGHTARRIVALAIRPORTID",pic:"ZZZ9"},{av:"AV13cFlightDepartureAirportId",fld:"vCFLIGHTDEPARTUREAIRPORTID",pic:"ZZZ9"}],[]];this.EvtParms.GRID1_NEXTPAGE=[[{av:"GRID1_nFirstRecordOnPage"},{av:"GRID1_nEOF"},{ctrl:"GRID1",prop:"Rows"},{av:"AV6cFlightId",fld:"vCFLIGHTID",pic:"ZZZ9"},{av:"AV11cFlightArrivalAirportId",fld:"vCFLIGHTARRIVALAIRPORTID",pic:"ZZZ9"},{av:"AV13cFlightDepartureAirportId",fld:"vCFLIGHTDEPARTUREAIRPORTID",pic:"ZZZ9"}],[]];this.EvtParms.GRID1_LASTPAGE=[[{av:"GRID1_nFirstRecordOnPage"},{av:"GRID1_nEOF"},{ctrl:"GRID1",prop:"Rows"},{av:"AV6cFlightId",fld:"vCFLIGHTID",pic:"ZZZ9"},{av:"AV11cFlightArrivalAirportId",fld:"vCFLIGHTARRIVALAIRPORTID",pic:"ZZZ9"},{av:"AV13cFlightDepartureAirportId",fld:"vCFLIGHTDEPARTUREAIRPORTID",pic:"ZZZ9"}],[]];this.setVCMap("AV7pFlightId","vPFLIGHTID",0,"int",4,0);t.addRefreshingParm({rfrProp:"Rows",gxGrid:"Grid1"});t.addRefreshingVar(this.GXValidFnc[16]);t.addRefreshingVar(this.GXValidFnc[26]);t.addRefreshingVar(this.GXValidFnc[36]);t.addRefreshingParm(this.GXValidFnc[16]);t.addRefreshingParm(this.GXValidFnc[26]);t.addRefreshingParm(this.GXValidFnc[36]);this.Initialize()});gx.wi(function(){gx.createParentObj(this.gx0060)})