gx.evt.autoSkip=!1;gx.define("wwattraction",!1,function(){var n,t;this.ServerClass="wwattraction";this.PackageName="GeneXus.Programs";this.ServerFullClass="wwattraction.aspx";this.setObjectType("web");this.anyGridBaseTable=!0;this.hasEnterEvent=!1;this.skipOnEnter=!1;this.autoRefresh=!0;this.fullAjax=!0;this.supportAjaxEvents=!0;this.ajaxSecurityToken=!0;this.DSO="TravelAgency_Capa202309";this.SetStandaloneVars=function(){this.AV14ADVANCED_LABEL_TEMPLATE=gx.fn.getControlValue("vADVANCED_LABEL_TEMPLATE")};this.Valid_Countryid=function(){var n=gx.fn.currentGridRowImpl(25);return this.validCliEvt("Valid_Countryid",25,function(){try{if(gx.fn.currentGridRowImpl(25)===0)return!0;var n=gx.util.balloon.getNew("COUNTRYID",gx.fn.currentGridRowImpl(25));this.AnyError=0}catch(t){}try{return n==null?!0:n.show()}catch(t){}return!0})};this.Valid_Cityid=function(){var n=gx.fn.currentGridRowImpl(25);return this.validCliEvt("Valid_Cityid",25,function(){try{if(gx.fn.currentGridRowImpl(25)===0)return!0;var n=gx.util.balloon.getNew("CITYID",gx.fn.currentGridRowImpl(25));this.AnyError=0}catch(t){}try{return n==null?!0:n.show()}catch(t){}return!0})};this.Valid_Categoryid=function(){var n=gx.fn.currentGridRowImpl(25);return this.validCliEvt("Valid_Categoryid",25,function(){try{if(gx.fn.currentGridRowImpl(25)===0)return!0;var n=gx.util.balloon.getNew("CATEGORYID",gx.fn.currentGridRowImpl(25));this.AnyError=0}catch(t){}try{return n==null?!0:n.show()}catch(t){}return!0})};this.e110h1_client=function(){return this.clearMessages(),gx.text.compare(gx.fn.getCtrlProperty("FILTERSCONTAINER","Class"),"filters-container")==0?(gx.fn.setCtrlProperty("FILTERSCONTAINER","Class","filters-container filters-container--visible"),gx.fn.setCtrlProperty("GRIDCELL","Class","ww__grid-cell col-xs-12 col-sm-9 col-md-10"),gx.fn.setCtrlProperty("BTNTOGGLE","Class","ww__button-filters--hide"),gx.fn.setCtrlProperty("BTNTOGGLE","Caption","Hide Filters"),gx.fn.setCtrlProperty("BTNTOGGLE","Tooltiptext","Hide Filters")):(gx.fn.setCtrlProperty("FILTERSCONTAINER","Class","filters-container"),gx.fn.setCtrlProperty("GRIDCELL","Class","ww__grid-cell--expanded col-xs-12 col-sm-3 col-md-2"),gx.fn.setCtrlProperty("BTNTOGGLE","Class","ww__button-filters--show"),gx.fn.setCtrlProperty("BTNTOGGLE","Caption","Show Filters"),gx.fn.setCtrlProperty("BTNTOGGLE","Tooltiptext","Show Filters")),this.refreshOutputs([{av:'gx.fn.getCtrlProperty("FILTERSCONTAINER","Class")',ctrl:"FILTERSCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("GRIDCELL","Class")',ctrl:"GRIDCELL",prop:"Class"},{ctrl:"BTNTOGGLE",prop:"Class"},{ctrl:"BTNTOGGLE",prop:"Caption"},{ctrl:"BTNTOGGLE",prop:"Tooltiptext"}]),this.OnClientEventEnd(),gx.$.Deferred().resolve()};this.e150h1_client=function(){return this.clearMessages(),gx.text.compare(gx.fn.getCtrlProperty("COUNTRYNAMEFILTERCONTAINER","Class"),"filters-container__item")==0?(gx.fn.setCtrlProperty("COUNTRYNAMEFILTERCONTAINER","Class","filters-container__item filters-container__item--expanded"),gx.fn.setCtrlProperty("vCOUNTRYNAME","Visible",!0)):(gx.fn.setCtrlProperty("COUNTRYNAMEFILTERCONTAINER","Class","filters-container__item"),gx.fn.setCtrlProperty("vCOUNTRYNAME","Visible",!1)),this.refreshOutputs([{av:'gx.fn.getCtrlProperty("COUNTRYNAMEFILTERCONTAINER","Class")',ctrl:"COUNTRYNAMEFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCOUNTRYNAME","Visible")',ctrl:"vCOUNTRYNAME",prop:"Visible"}]),this.OnClientEventEnd(),gx.$.Deferred().resolve()};this.e160h2_client=function(){return this.executeServerEvent("ENTER",!0,arguments[0],!1,!1)};this.e170h2_client=function(){return this.executeServerEvent("CANCEL",!0,arguments[0],!1,!1)};this.GXValidFnc=[];n=this.GXValidFnc;this.GXCtrlIds=[2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,20,21,22,23,24,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,52,53,54,55,56];this.GXLastCtrlId=56;this.GridContainer=new gx.grid.grid(this,2,"WbpLvl2",25,"Grid","Grid","GridContainer",this.CmpContext,this.IsMasterPage,"wwattraction",[],!1,1,!1,!0,0,!0,!1,!1,"",0,"px",0,"px","New row",!0,!1,!1,null,null,!1,"",!1,[1,1,1,1],!1,0,!0,!1);t=this.GridContainer;t.addSingleLineEdit(7,26,"ATTRACTIONID","Id","","AttractionId","int",0,"px",4,4,"end",null,[],7,"AttractionId",!0,0,!1,!1,"Attribute",0,"column column-optional");t.addSingleLineEdit(8,27,"ATTRACTIONNAME","Name","","AttractionName","svchar",0,"px",40,40,"start",null,[],8,"AttractionName",!0,0,!1,!1,"attribute-description",0,"column");t.addSingleLineEdit(9,28,"COUNTRYID","Country Id","","CountryId","int",0,"px",4,4,"end",null,[],9,"CountryId",!0,0,!1,!1,"Attribute",0,"column column-optional");t.addSingleLineEdit(10,29,"COUNTRYNAME","Country Name","","CountryName","svchar",0,"px",40,40,"start",null,[],10,"CountryName",!0,0,!1,!1,"Attribute",0,"column column-optional");t.addSingleLineEdit(14,30,"CITYID","City Id","","CityId","int",0,"px",4,4,"end",null,[],14,"CityId",!0,0,!1,!1,"Attribute",0,"column column-optional");t.addSingleLineEdit(15,31,"CITYNAME","City Name","","CityName","svchar",0,"px",40,40,"start",null,[],15,"CityName",!0,0,!1,!1,"Attribute",0,"column column-optional");t.addSingleLineEdit(11,32,"CATEGORYID","Category Id","","CategoryId","int",0,"px",4,4,"end",null,[],11,"CategoryId",!0,0,!1,!1,"Attribute",0,"column column-optional");t.addSingleLineEdit(12,33,"CATEGORYNAME","Category Name","","CategoryName","svchar",0,"px",40,40,"start",null,[],12,"CategoryName",!0,0,!1,!1,"Attribute",0,"column column-optional");t.addBitmap(13,"ATTRACTIONPHOTO",34,0,"px",17,"px",null,"","Photo","ImageAttribute","column column-optional");t.addSingleLineEdit("Update",35,"vUPDATE","","","Update","char",0,"px",20,20,"start",null,[],"Update","Update",!0,0,!1,!1,"TextActionAttribute TextLikeLink",0,"WWTextActionColumn");t.addSingleLineEdit("Delete",36,"vDELETE","","","Delete","char",0,"px",20,20,"start",null,[],"Delete","Delete",!0,0,!1,!1,"TextActionAttribute TextLikeLink",0,"WWTextActionColumn");this.GridContainer.emptyText="";this.setGrid(t);n[2]={id:2,fld:"",grid:0};n[3]={id:3,fld:"MAINTABLE",grid:0};n[4]={id:4,fld:"",grid:0};n[5]={id:5,fld:"GRIDCELL",grid:0};n[6]={id:6,fld:"GRIDTABLE",grid:0};n[7]={id:7,fld:"",grid:0};n[8]={id:8,fld:"",grid:0};n[9]={id:9,fld:"TABLETOP",grid:0};n[10]={id:10,fld:"",grid:0};n[11]={id:11,fld:"TITLETEXT",format:0,grid:0,ctrltype:"textblock"};n[12]={id:12,fld:"",grid:0};n[13]={id:13,fld:"",grid:0};n[14]={id:14,lvl:0,type:"svchar",len:40,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vATTRACTIONNAME",fmt:0,gxz:"ZV11AttractionName",gxold:"OV11AttractionName",gxvar:"AV11AttractionName",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV11AttractionName=n)},v2z:function(n){n!==undefined&&(gx.O.ZV11AttractionName=n)},v2c:function(){gx.fn.setControlValue("vATTRACTIONNAME",gx.O.AV11AttractionName,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV11AttractionName=this.val())},val:function(){return gx.fn.getControlValue("vATTRACTIONNAME")},nac:gx.falseFn};n[15]={id:15,fld:"",grid:0};n[16]={id:16,fld:"BTNTOGGLE",grid:0,evt:"e110h1_client"};n[17]={id:17,fld:"",grid:0};n[18]={id:18,fld:"",grid:0};n[20]={id:20,fld:"",grid:0};n[21]={id:21,fld:"",grid:0};n[22]={id:22,fld:"GRIDCONTAINER",grid:0};n[23]={id:23,fld:"",grid:0};n[24]={id:24,fld:"",grid:0};n[26]={id:26,lvl:2,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:1,isacc:0,grid:25,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"ATTRACTIONID",fmt:0,gxz:"Z7AttractionId",gxold:"O7AttractionId",gxvar:"A7AttractionId",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.A7AttractionId=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z7AttractionId=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("ATTRACTIONID",n||gx.fn.currentGridRowImpl(25),gx.O.A7AttractionId,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(n){this.val(n)!==undefined&&(gx.O.A7AttractionId=gx.num.intval(this.val(n)))},val:function(n){return gx.fn.getGridIntegerValue("ATTRACTIONID",n||gx.fn.currentGridRowImpl(25),",")},nac:gx.falseFn};n[27]={id:27,lvl:2,type:"svchar",len:40,dec:0,sign:!1,ro:1,isacc:0,grid:25,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"ATTRACTIONNAME",fmt:0,gxz:"Z8AttractionName",gxold:"O8AttractionName",gxvar:"A8AttractionName",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",autoCorrect:"1",v2v:function(n){n!==undefined&&(gx.O.A8AttractionName=n)},v2z:function(n){n!==undefined&&(gx.O.Z8AttractionName=n)},v2c:function(n){gx.fn.setGridControlValue("ATTRACTIONNAME",n||gx.fn.currentGridRowImpl(25),gx.O.A8AttractionName,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(n){this.val(n)!==undefined&&(gx.O.A8AttractionName=this.val(n))},val:function(n){return gx.fn.getGridControlValue("ATTRACTIONNAME",n||gx.fn.currentGridRowImpl(25))},nac:gx.falseFn};n[28]={id:28,lvl:2,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:1,isacc:0,grid:25,gxgrid:this.GridContainer,fnc:this.Valid_Countryid,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"COUNTRYID",fmt:0,gxz:"Z9CountryId",gxold:"O9CountryId",gxvar:"A9CountryId",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.A9CountryId=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z9CountryId=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("COUNTRYID",n||gx.fn.currentGridRowImpl(25),gx.O.A9CountryId,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(n){this.val(n)!==undefined&&(gx.O.A9CountryId=gx.num.intval(this.val(n)))},val:function(n){return gx.fn.getGridIntegerValue("COUNTRYID",n||gx.fn.currentGridRowImpl(25),",")},nac:gx.falseFn};n[29]={id:29,lvl:2,type:"svchar",len:40,dec:0,sign:!1,ro:1,isacc:0,grid:25,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"COUNTRYNAME",fmt:0,gxz:"Z10CountryName",gxold:"O10CountryName",gxvar:"A10CountryName",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",autoCorrect:"1",v2v:function(n){n!==undefined&&(gx.O.A10CountryName=n)},v2z:function(n){n!==undefined&&(gx.O.Z10CountryName=n)},v2c:function(n){gx.fn.setGridControlValue("COUNTRYNAME",n||gx.fn.currentGridRowImpl(25),gx.O.A10CountryName,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(n){this.val(n)!==undefined&&(gx.O.A10CountryName=this.val(n))},val:function(n){return gx.fn.getGridControlValue("COUNTRYNAME",n||gx.fn.currentGridRowImpl(25))},nac:gx.falseFn};n[30]={id:30,lvl:2,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:1,isacc:0,grid:25,gxgrid:this.GridContainer,fnc:this.Valid_Cityid,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"CITYID",fmt:0,gxz:"Z14CityId",gxold:"O14CityId",gxvar:"A14CityId",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.A14CityId=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z14CityId=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("CITYID",n||gx.fn.currentGridRowImpl(25),gx.O.A14CityId,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(n){this.val(n)!==undefined&&(gx.O.A14CityId=gx.num.intval(this.val(n)))},val:function(n){return gx.fn.getGridIntegerValue("CITYID",n||gx.fn.currentGridRowImpl(25),",")},nac:gx.falseFn};n[31]={id:31,lvl:2,type:"svchar",len:40,dec:0,sign:!1,ro:1,isacc:0,grid:25,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"CITYNAME",fmt:0,gxz:"Z15CityName",gxold:"O15CityName",gxvar:"A15CityName",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",autoCorrect:"1",v2v:function(n){n!==undefined&&(gx.O.A15CityName=n)},v2z:function(n){n!==undefined&&(gx.O.Z15CityName=n)},v2c:function(n){gx.fn.setGridControlValue("CITYNAME",n||gx.fn.currentGridRowImpl(25),gx.O.A15CityName,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(n){this.val(n)!==undefined&&(gx.O.A15CityName=this.val(n))},val:function(n){return gx.fn.getGridControlValue("CITYNAME",n||gx.fn.currentGridRowImpl(25))},nac:gx.falseFn};n[32]={id:32,lvl:2,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:1,isacc:0,grid:25,gxgrid:this.GridContainer,fnc:this.Valid_Categoryid,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"CATEGORYID",fmt:0,gxz:"Z11CategoryId",gxold:"O11CategoryId",gxvar:"A11CategoryId",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.A11CategoryId=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z11CategoryId=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("CATEGORYID",n||gx.fn.currentGridRowImpl(25),gx.O.A11CategoryId,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(n){this.val(n)!==undefined&&(gx.O.A11CategoryId=gx.num.intval(this.val(n)))},val:function(n){return gx.fn.getGridIntegerValue("CATEGORYID",n||gx.fn.currentGridRowImpl(25),",")},nac:gx.falseFn};n[33]={id:33,lvl:2,type:"svchar",len:40,dec:0,sign:!1,ro:1,isacc:0,grid:25,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"CATEGORYNAME",fmt:0,gxz:"Z12CategoryName",gxold:"O12CategoryName",gxvar:"A12CategoryName",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",autoCorrect:"1",v2v:function(n){n!==undefined&&(gx.O.A12CategoryName=n)},v2z:function(n){n!==undefined&&(gx.O.Z12CategoryName=n)},v2c:function(n){gx.fn.setGridControlValue("CATEGORYNAME",n||gx.fn.currentGridRowImpl(25),gx.O.A12CategoryName,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(n){this.val(n)!==undefined&&(gx.O.A12CategoryName=this.val(n))},val:function(n){return gx.fn.getGridControlValue("CATEGORYNAME",n||gx.fn.currentGridRowImpl(25))},nac:gx.falseFn};n[34]={id:34,lvl:2,type:"bits",len:1024,dec:0,sign:!1,ro:1,isacc:0,grid:25,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"ATTRACTIONPHOTO",fmt:0,gxz:"Z13AttractionPhoto",gxold:"O13AttractionPhoto",gxvar:"A13AttractionPhoto",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.A13AttractionPhoto=n)},v2z:function(n){n!==undefined&&(gx.O.Z13AttractionPhoto=n)},v2c:function(n){gx.fn.setGridMultimediaValue("ATTRACTIONPHOTO",n||gx.fn.currentGridRowImpl(25),gx.O.A13AttractionPhoto,gx.O.A40000AttractionPhoto_GXI)},c2v:function(n){gx.O.A40000AttractionPhoto_GXI=this.val_GXI();this.val(n)!==undefined&&(gx.O.A13AttractionPhoto=this.val(n))},val:function(n){return gx.fn.getGridControlValue("ATTRACTIONPHOTO",n||gx.fn.currentGridRowImpl(25))},val_GXI:function(n){return gx.fn.getGridControlValue("ATTRACTIONPHOTO_GXI",n||gx.fn.currentGridRowImpl(25))},gxvar_GXI:"A40000AttractionPhoto_GXI",nac:gx.falseFn};n[35]={id:35,lvl:2,type:"char",len:20,dec:0,sign:!1,ro:1,isacc:0,grid:25,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vUPDATE",fmt:0,gxz:"ZV12Update",gxold:"OV12Update",gxvar:"AV12Update",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",autoCorrect:"1",v2v:function(n){n!==undefined&&(gx.O.AV12Update=n)},v2z:function(n){n!==undefined&&(gx.O.ZV12Update=n)},v2c:function(n){gx.fn.setGridControlValue("vUPDATE",n||gx.fn.currentGridRowImpl(25),gx.O.AV12Update,0)},c2v:function(n){this.val(n)!==undefined&&(gx.O.AV12Update=this.val(n))},val:function(n){return gx.fn.getGridControlValue("vUPDATE",n||gx.fn.currentGridRowImpl(25))},nac:gx.falseFn};n[36]={id:36,lvl:2,type:"char",len:20,dec:0,sign:!1,ro:1,isacc:0,grid:25,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDELETE",fmt:0,gxz:"ZV13Delete",gxold:"OV13Delete",gxvar:"AV13Delete",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",autoCorrect:"1",v2v:function(n){n!==undefined&&(gx.O.AV13Delete=n)},v2z:function(n){n!==undefined&&(gx.O.ZV13Delete=n)},v2c:function(n){gx.fn.setGridControlValue("vDELETE",n||gx.fn.currentGridRowImpl(25),gx.O.AV13Delete,0)},c2v:function(n){this.val(n)!==undefined&&(gx.O.AV13Delete=this.val(n))},val:function(n){return gx.fn.getGridControlValue("vDELETE",n||gx.fn.currentGridRowImpl(25))},nac:gx.falseFn};n[37]={id:37,fld:"",grid:0};n[38]={id:38,fld:"FILTERSCONTAINER",grid:0};n[39]={id:39,fld:"",grid:0};n[40]={id:40,fld:"",grid:0};n[41]={id:41,fld:"BTNTOGGLEONTABLE",grid:0,evt:"e110h1_client"};n[42]={id:42,fld:"",grid:0};n[43]={id:43,fld:"",grid:0};n[44]={id:44,fld:"",grid:0};n[45]={id:45,fld:"",grid:0};n[46]={id:46,lvl:0,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vORDEREDBY",fmt:0,gxz:"ZV16OrderedBy",gxold:"OV16OrderedBy",gxvar:"AV16OrderedBy",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"combo",v2v:function(n){n!==undefined&&(gx.O.AV16OrderedBy=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.ZV16OrderedBy=gx.num.intval(n))},v2c:function(){gx.fn.setComboBoxValue("vORDEREDBY",gx.O.AV16OrderedBy)},c2v:function(){this.val()!==undefined&&(gx.O.AV16OrderedBy=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("vORDEREDBY",",")},nac:gx.falseFn};n[47]={id:47,fld:"",grid:0};n[48]={id:48,fld:"",grid:0};n[49]={id:49,fld:"COUNTRYNAMEFILTERCONTAINER",grid:0,evt:"e150h1_client"};n[50]={id:50,fld:"",grid:0};n[51]={id:51,fld:"",grid:0};n[52]={id:52,fld:"LBLCOUNTRYNAMEFILTER",format:1,grid:0,ctrltype:"textblock"};n[53]={id:53,fld:"",grid:0};n[54]={id:54,fld:"",grid:0};n[55]={id:55,fld:"",grid:0};n[56]={id:56,lvl:0,type:"svchar",len:40,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vCOUNTRYNAME",fmt:0,gxz:"ZV15CountryName",gxold:"OV15CountryName",gxvar:"AV15CountryName",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV15CountryName=n)},v2z:function(n){n!==undefined&&(gx.O.ZV15CountryName=n)},v2c:function(){gx.fn.setControlValue("vCOUNTRYNAME",gx.O.AV15CountryName,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV15CountryName=this.val())},val:function(){return gx.fn.getControlValue("vCOUNTRYNAME")},nac:gx.falseFn};this.AV11AttractionName="";this.ZV11AttractionName="";this.OV11AttractionName="";this.Z7AttractionId=0;this.O7AttractionId=0;this.Z8AttractionName="";this.O8AttractionName="";this.Z9CountryId=0;this.O9CountryId=0;this.Z10CountryName="";this.O10CountryName="";this.Z14CityId=0;this.O14CityId=0;this.Z15CityName="";this.O15CityName="";this.Z11CategoryId=0;this.O11CategoryId=0;this.Z12CategoryName="";this.O12CategoryName="";this.Z13AttractionPhoto="";this.O13AttractionPhoto="";this.ZV12Update="";this.OV12Update="";this.ZV13Delete="";this.OV13Delete="";this.AV16OrderedBy=0;this.ZV16OrderedBy=0;this.OV16OrderedBy=0;this.AV15CountryName="";this.ZV15CountryName="";this.OV15CountryName="";this.AV11AttractionName="";this.AV16OrderedBy=0;this.AV15CountryName="";this.A40000AttractionPhoto_GXI="";this.A7AttractionId=0;this.A8AttractionName="";this.A9CountryId=0;this.A10CountryName="";this.A14CityId=0;this.A15CityName="";this.A11CategoryId=0;this.A12CategoryName="";this.A13AttractionPhoto="";this.AV12Update="";this.AV13Delete="";this.AV14ADVANCED_LABEL_TEMPLATE="";this.Events={e160h2_client:["ENTER",!0],e170h2_client:["CANCEL",!0],e110h1_client:["'TOGGLE'",!1],e150h1_client:["COUNTRYNAMEFILTERCONTAINER.CLICK",!1]};this.EvtParms.REFRESH=[[{av:"GRID_nFirstRecordOnPage"},{av:"GRID_nEOF"},{ctrl:"GRID",prop:"Rows"},{av:"AV11AttractionName",fld:"vATTRACTIONNAME",pic:""},{ctrl:"vORDEREDBY"},{av:"AV16OrderedBy",fld:"vORDEREDBY",pic:"ZZZ9"},{av:"AV12Update",fld:"vUPDATE",pic:""},{av:"AV13Delete",fld:"vDELETE",pic:""},{av:"AV15CountryName",fld:"vCOUNTRYNAME",pic:""},{av:"AV14ADVANCED_LABEL_TEMPLATE",fld:"vADVANCED_LABEL_TEMPLATE",pic:"",hsh:!0}],[{av:'gx.fn.getCtrlProperty("LBLCOUNTRYNAMEFILTER","Caption")',ctrl:"LBLCOUNTRYNAMEFILTER",prop:"Caption"}]];this.EvtParms["'TOGGLE'"]=[[{av:'gx.fn.getCtrlProperty("FILTERSCONTAINER","Class")',ctrl:"FILTERSCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("FILTERSCONTAINER","Class")',ctrl:"FILTERSCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("GRIDCELL","Class")',ctrl:"GRIDCELL",prop:"Class"},{ctrl:"BTNTOGGLE",prop:"Class"},{ctrl:"BTNTOGGLE",prop:"Caption"},{ctrl:"BTNTOGGLE",prop:"Tooltiptext"}]];this.EvtParms["COUNTRYNAMEFILTERCONTAINER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("COUNTRYNAMEFILTERCONTAINER","Class")',ctrl:"COUNTRYNAMEFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("COUNTRYNAMEFILTERCONTAINER","Class")',ctrl:"COUNTRYNAMEFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCOUNTRYNAME","Visible")',ctrl:"vCOUNTRYNAME",prop:"Visible"}]];this.EvtParms["GRID.LOAD"]=[[{av:"A7AttractionId",fld:"ATTRACTIONID",pic:"ZZZ9"},{av:"A9CountryId",fld:"COUNTRYID",pic:"ZZZ9"}],[{av:'gx.fn.getCtrlProperty("vUPDATE","Link")',ctrl:"vUPDATE",prop:"Link"},{av:'gx.fn.getCtrlProperty("vDELETE","Link")',ctrl:"vDELETE",prop:"Link"},{av:'gx.fn.getCtrlProperty("ATTRACTIONNAME","Link")',ctrl:"ATTRACTIONNAME",prop:"Link"},{av:'gx.fn.getCtrlProperty("COUNTRYNAME","Link")',ctrl:"COUNTRYNAME",prop:"Link"}]];this.EvtParms.ENTER=[[],[]];this.EvtParms.GRID_FIRSTPAGE=[[{av:"GRID_nFirstRecordOnPage"},{av:"GRID_nEOF"},{ctrl:"GRID",prop:"Rows"},{av:"AV11AttractionName",fld:"vATTRACTIONNAME",pic:""},{ctrl:"vORDEREDBY"},{av:"AV16OrderedBy",fld:"vORDEREDBY",pic:"ZZZ9"},{av:"AV12Update",fld:"vUPDATE",pic:""},{av:"AV13Delete",fld:"vDELETE",pic:""},{av:"AV15CountryName",fld:"vCOUNTRYNAME",pic:""},{av:"AV14ADVANCED_LABEL_TEMPLATE",fld:"vADVANCED_LABEL_TEMPLATE",pic:"",hsh:!0}],[{av:'gx.fn.getCtrlProperty("LBLCOUNTRYNAMEFILTER","Caption")',ctrl:"LBLCOUNTRYNAMEFILTER",prop:"Caption"}]];this.EvtParms.GRID_PREVPAGE=[[{av:"GRID_nFirstRecordOnPage"},{av:"GRID_nEOF"},{ctrl:"GRID",prop:"Rows"},{av:"AV11AttractionName",fld:"vATTRACTIONNAME",pic:""},{ctrl:"vORDEREDBY"},{av:"AV16OrderedBy",fld:"vORDEREDBY",pic:"ZZZ9"},{av:"AV12Update",fld:"vUPDATE",pic:""},{av:"AV13Delete",fld:"vDELETE",pic:""},{av:"AV15CountryName",fld:"vCOUNTRYNAME",pic:""},{av:"AV14ADVANCED_LABEL_TEMPLATE",fld:"vADVANCED_LABEL_TEMPLATE",pic:"",hsh:!0}],[{av:'gx.fn.getCtrlProperty("LBLCOUNTRYNAMEFILTER","Caption")',ctrl:"LBLCOUNTRYNAMEFILTER",prop:"Caption"}]];this.EvtParms.GRID_NEXTPAGE=[[{av:"GRID_nFirstRecordOnPage"},{av:"GRID_nEOF"},{ctrl:"GRID",prop:"Rows"},{av:"AV11AttractionName",fld:"vATTRACTIONNAME",pic:""},{ctrl:"vORDEREDBY"},{av:"AV16OrderedBy",fld:"vORDEREDBY",pic:"ZZZ9"},{av:"AV12Update",fld:"vUPDATE",pic:""},{av:"AV13Delete",fld:"vDELETE",pic:""},{av:"AV15CountryName",fld:"vCOUNTRYNAME",pic:""},{av:"AV14ADVANCED_LABEL_TEMPLATE",fld:"vADVANCED_LABEL_TEMPLATE",pic:"",hsh:!0}],[{av:'gx.fn.getCtrlProperty("LBLCOUNTRYNAMEFILTER","Caption")',ctrl:"LBLCOUNTRYNAMEFILTER",prop:"Caption"}]];this.EvtParms.GRID_LASTPAGE=[[{av:"GRID_nFirstRecordOnPage"},{av:"GRID_nEOF"},{ctrl:"GRID",prop:"Rows"},{av:"AV11AttractionName",fld:"vATTRACTIONNAME",pic:""},{ctrl:"vORDEREDBY"},{av:"AV16OrderedBy",fld:"vORDEREDBY",pic:"ZZZ9"},{av:"AV12Update",fld:"vUPDATE",pic:""},{av:"AV13Delete",fld:"vDELETE",pic:""},{av:"AV15CountryName",fld:"vCOUNTRYNAME",pic:""},{av:"AV14ADVANCED_LABEL_TEMPLATE",fld:"vADVANCED_LABEL_TEMPLATE",pic:"",hsh:!0}],[{av:'gx.fn.getCtrlProperty("LBLCOUNTRYNAMEFILTER","Caption")',ctrl:"LBLCOUNTRYNAMEFILTER",prop:"Caption"}]];this.EvtParms.VALID_COUNTRYID=[[],[]];this.EvtParms.VALID_CITYID=[[],[]];this.EvtParms.VALID_CATEGORYID=[[],[]];this.setVCMap("AV14ADVANCED_LABEL_TEMPLATE","vADVANCED_LABEL_TEMPLATE",0,"char",20,0);this.setVCMap("AV14ADVANCED_LABEL_TEMPLATE","vADVANCED_LABEL_TEMPLATE",0,"char",20,0);this.setVCMap("AV14ADVANCED_LABEL_TEMPLATE","vADVANCED_LABEL_TEMPLATE",0,"char",20,0);t.addRefreshingParm({rfrProp:"Rows",gxGrid:"Grid"});t.addRefreshingVar(this.GXValidFnc[14]);t.addRefreshingVar(this.GXValidFnc[46]);t.addRefreshingVar(this.GXValidFnc[56]);t.addRefreshingVar({rfrVar:"AV14ADVANCED_LABEL_TEMPLATE"});t.addRefreshingVar({rfrVar:"AV12Update",rfrProp:"Value",gxAttId:"Update"});t.addRefreshingVar({rfrVar:"AV13Delete",rfrProp:"Value",gxAttId:"Delete"});t.addRefreshingParm(this.GXValidFnc[14]);t.addRefreshingParm(this.GXValidFnc[46]);t.addRefreshingParm(this.GXValidFnc[56]);t.addRefreshingParm({rfrVar:"AV14ADVANCED_LABEL_TEMPLATE"});t.addRefreshingParm({rfrVar:"AV12Update",rfrProp:"Value",gxAttId:"Update"});t.addRefreshingParm({rfrVar:"AV13Delete",rfrProp:"Value",gxAttId:"Delete"});this.Initialize()});gx.wi(function(){gx.createParentObj(this.wwattraction)})