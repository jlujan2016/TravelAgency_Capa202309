gx.evt.autoSkip=!1;gx.define("general.security.notauthorized",!1,function(){this.ServerClass="general.security.notauthorized";this.PackageName="GeneXus.Programs";this.ServerFullClass="general.security.notauthorized.aspx";this.setObjectType("web");this.hasEnterEvent=!1;this.skipOnEnter=!1;this.autoRefresh=!0;this.fullAjax=!0;this.supportAjaxEvents=!0;this.ajaxSecurityToken=!0;this.DSO="TravelAgency_Capa202309";this.SetStandaloneVars=function(){this.GxObject=gx.fn.getControlValue("vGXOBJECT")};this.e13082_client=function(){return this.executeServerEvent("ENTER",!0,null,!1,!1)};this.e14082_client=function(){return this.executeServerEvent("CANCEL",!0,null,!1,!1)};this.GXValidFnc=[];var n=this.GXValidFnc;this.GXCtrlIds=[3,6,12,15];this.GXLastCtrlId=15;n[3]={id:3,fld:"TABLE1",grid:0};n[6]={id:6,fld:"TITLETEXT",format:0,grid:0,ctrltype:"textblock"};n[12]={id:12,fld:"TABLE2",grid:0};n[15]={id:15,fld:"TABLE3",grid:0};this.GxObject="";this.Events={e13082_client:["ENTER",!0],e14082_client:["CANCEL",!0]};this.EvtParms.REFRESH=[[],[]];this.EvtParms.ENTER=[[],[]];this.setVCMap("GxObject","vGXOBJECT",0,"svchar",256,0);this.Initialize();this.setComponent({id:"HEADERBC",GXClass:null,Prefix:"W0002",lvl:1})});gx.wi(function(){gx.createParentObj(this.general.security.notauthorized)})