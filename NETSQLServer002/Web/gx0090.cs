using System;
using System.Collections;
using GeneXus.Utils;
using GeneXus.Resources;
using GeneXus.Application;
using GeneXus.Metadata;
using GeneXus.Cryptography;
using System.Data;
using GeneXus.Data;
using com.genexus;
using GeneXus.Data.ADO;
using GeneXus.Data.NTier;
using GeneXus.Data.NTier.ADO;
using GeneXus.WebControls;
using GeneXus.Http;
using GeneXus.XML;
using GeneXus.Search;
using GeneXus.Encryption;
using GeneXus.Http.Client;
using System.Xml.Serialization;
using System.Runtime.Serialization;
namespace GeneXus.Programs {
   public class gx0090 : GXDataArea
   {
      public gx0090( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("TravelAgency_Capa202309", true);
      }

      public gx0090( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void execute( out short aP0_pFlightId )
      {
         this.AV12pFlightId = 0 ;
         executePrivate();
         aP0_pFlightId=this.AV12pFlightId;
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      protected override void createObjects( )
      {
      }

      protected void INITWEB( )
      {
         initialize_properties( ) ;
         if ( nGotPars == 0 )
         {
            entryPointCalled = false;
            gxfirstwebparm = GetFirstPar( "pFlightId");
            gxfirstwebparm_bkp = gxfirstwebparm;
            gxfirstwebparm = DecryptAjaxCall( gxfirstwebparm);
            toggleJsOutput = isJsOutputEnabled( );
            if ( context.isSpaRequest( ) )
            {
               disableJsOutput();
            }
            if ( StringUtil.StrCmp(gxfirstwebparm, "dyncall") == 0 )
            {
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               dyncall( GetNextPar( )) ;
               return  ;
            }
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxEvt") == 0 )
            {
               setAjaxEventMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxfirstwebparm = GetFirstPar( "pFlightId");
            }
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxfullajaxEvt") == 0 )
            {
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxfirstwebparm = GetFirstPar( "pFlightId");
            }
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxNewRow_"+"Grid1") == 0 )
            {
               gxnrGrid1_newrow_invoke( ) ;
               return  ;
            }
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxGridRefresh_"+"Grid1") == 0 )
            {
               gxgrGrid1_refresh_invoke( ) ;
               return  ;
            }
            else
            {
               if ( ! IsValidAjaxCall( false) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxfirstwebparm = gxfirstwebparm_bkp;
            }
            if ( ! entryPointCalled && ! ( isAjaxCallMode( ) || isFullAjaxMode( ) ) )
            {
               AV12pFlightId = (short)(Math.Round(NumberUtil.Val( gxfirstwebparm, "."), 18, MidpointRounding.ToEven));
               AssignAttri("", false, "AV12pFlightId", StringUtil.LTrimStr( (decimal)(AV12pFlightId), 4, 0));
            }
            if ( toggleJsOutput )
            {
               if ( context.isSpaRequest( ) )
               {
                  enableJsOutput();
               }
            }
         }
         if ( ! context.IsLocalStorageSupported( ) )
         {
            context.PushCurrentUrl();
         }
      }

      protected void gxnrGrid1_newrow_invoke( )
      {
         nRC_GXsfl_74 = (int)(Math.Round(NumberUtil.Val( GetPar( "nRC_GXsfl_74"), "."), 18, MidpointRounding.ToEven));
         nGXsfl_74_idx = (int)(Math.Round(NumberUtil.Val( GetPar( "nGXsfl_74_idx"), "."), 18, MidpointRounding.ToEven));
         sGXsfl_74_idx = GetPar( "sGXsfl_74_idx");
         setAjaxCallMode();
         if ( ! IsValidAjaxCall( true) )
         {
            GxWebError = 1;
            return  ;
         }
         gxnrGrid1_newrow( ) ;
         /* End function gxnrGrid1_newrow_invoke */
      }

      protected void gxgrGrid1_refresh_invoke( )
      {
         subGrid1_Rows = (int)(Math.Round(NumberUtil.Val( GetPar( "subGrid1_Rows"), "."), 18, MidpointRounding.ToEven));
         AV6cFlightId = (short)(Math.Round(NumberUtil.Val( GetPar( "cFlightId"), "."), 18, MidpointRounding.ToEven));
         AV7cFlightArrivalAirportId = (short)(Math.Round(NumberUtil.Val( GetPar( "cFlightArrivalAirportId"), "."), 18, MidpointRounding.ToEven));
         AV8cFlightDepartureAirportId = (short)(Math.Round(NumberUtil.Val( GetPar( "cFlightDepartureAirportId"), "."), 18, MidpointRounding.ToEven));
         AV9cFlightPrice = NumberUtil.Val( GetPar( "cFlightPrice"), ".");
         AV10cAirlineId = (short)(Math.Round(NumberUtil.Val( GetPar( "cAirlineId"), "."), 18, MidpointRounding.ToEven));
         AV11cFlightDiscountPercentaje = (short)(Math.Round(NumberUtil.Val( GetPar( "cFlightDiscountPercentaje"), "."), 18, MidpointRounding.ToEven));
         setAjaxCallMode();
         if ( ! IsValidAjaxCall( true) )
         {
            GxWebError = 1;
            return  ;
         }
         gxgrGrid1_refresh( subGrid1_Rows, AV6cFlightId, AV7cFlightArrivalAirportId, AV8cFlightDepartureAirportId, AV9cFlightPrice, AV10cAirlineId, AV11cFlightDiscountPercentaje) ;
         AddString( context.getJSONResponse( )) ;
         /* End function gxgrGrid1_refresh_invoke */
      }

      public override void webExecute( )
      {
         if ( initialized == 0 )
         {
            createObjects();
            initialize();
         }
         INITWEB( ) ;
         if ( ! isAjaxCallMode( ) )
         {
            MasterPageObj = (GXMasterPage) ClassLoader.GetInstance("general.ui.masterprompt", "GeneXus.Programs.general.ui.masterprompt", new Object[] {context});
            MasterPageObj.setDataArea(this,true);
            ValidateSpaRequest();
            MasterPageObj.webExecute();
            if ( ( GxWebError == 0 ) && context.isAjaxRequest( ) )
            {
               enableOutput();
               if ( ! context.isAjaxRequest( ) )
               {
                  context.GX_webresponse.AppendHeader("Cache-Control", "no-store");
               }
               if ( ! context.WillRedirect( ) )
               {
                  AddString( context.getJSONResponse( )) ;
               }
               else
               {
                  if ( context.isAjaxRequest( ) )
                  {
                     disableOutput();
                  }
                  RenderHtmlHeaders( ) ;
                  context.Redirect( context.wjLoc );
                  context.DispatchAjaxCommands();
               }
            }
         }
         this.cleanup();
      }

      public override short ExecuteStartEvent( )
      {
         PA0M2( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START0M2( ) ;
         }
         return gxajaxcallmode ;
      }

      public override void RenderHtmlHeaders( )
      {
         GxWebStd.gx_html_headers( context, 0, "", "", Form.Meta, Form.Metaequiv, true);
      }

      public override void RenderHtmlOpenForm( )
      {
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         context.WriteHtmlText( "<title>") ;
         context.SendWebValue( Form.Caption) ;
         context.WriteHtmlTextNl( "</title>") ;
         if ( context.isSpaRequest( ) )
         {
            disableOutput();
         }
         if ( StringUtil.Len( sDynURL) > 0 )
         {
            context.WriteHtmlText( "<BASE href=\""+sDynURL+"\" />") ;
         }
         define_styles( ) ;
         if ( nGXWrapped != 1 )
         {
            MasterPageObj.master_styles();
         }
         CloseStyles();
         if ( ( ( context.GetBrowserType( ) == 1 ) || ( context.GetBrowserType( ) == 5 ) ) && ( StringUtil.StrCmp(context.GetBrowserVersion( ), "7.0") == 0 ) )
         {
            context.AddJavascriptSource("json2.js", "?"+context.GetBuildNumber( 1910300), false, true);
         }
         context.AddJavascriptSource("jquery.js", "?"+context.GetBuildNumber( 1910300), false, true);
         context.AddJavascriptSource("gxgral.js", "?"+context.GetBuildNumber( 1910300), false, true);
         context.AddJavascriptSource("gxcfg.js", "?"+GetCacheInvalidationToken( ), false, true);
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         context.WriteHtmlText( Form.Headerrawhtml) ;
         context.CloseHtmlHeader();
         if ( context.isSpaRequest( ) )
         {
            disableOutput();
         }
         FormProcess = " data-HasEnter=\"true\" data-Skiponenter=\"false\"";
         context.WriteHtmlText( "<body ") ;
         if ( StringUtil.StrCmp(context.GetLanguageProperty( "rtl"), "true") == 0 )
         {
            context.WriteHtmlText( " dir=\"rtl\" ") ;
         }
         bodyStyle = "" + "background-color:" + context.BuildHTMLColor( Form.Backcolor) + ";color:" + context.BuildHTMLColor( Form.Textcolor) + ";";
         if ( nGXWrapped == 0 )
         {
            bodyStyle += "-moz-opacity:0;opacity:0;";
         }
         if ( ! ( String.IsNullOrEmpty(StringUtil.RTrim( Form.Background)) ) )
         {
            bodyStyle += " background-image:url(" + context.convertURL( Form.Background) + ")";
         }
         context.WriteHtmlText( " "+"class=\"form-horizontal Form\""+" "+ "style='"+bodyStyle+"'") ;
         context.WriteHtmlText( FormProcess+">") ;
         context.skipLines(1);
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("gx0090.aspx", new object[] {UrlEncode(StringUtil.LTrimStr(AV12pFlightId,4,0))}, new string[] {"pFlightId"}) +"\">") ;
         GxWebStd.gx_hidden_field( context, "_EventName", "");
         GxWebStd.gx_hidden_field( context, "_EventGridId", "");
         GxWebStd.gx_hidden_field( context, "_EventRowId", "");
         context.WriteHtmlText( "<div style=\"height:0;overflow:hidden\"><input type=\"submit\" title=\"submit\"  disabled></div>") ;
         AssignProp("", false, "FORM", "Class", "form-horizontal Form", true);
         toggleJsOutput = isJsOutputEnabled( );
         if ( context.isSpaRequest( ) )
         {
            disableJsOutput();
         }
      }

      protected void send_integrity_footer_hashes( )
      {
         GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
      }

      protected void SendCloseFormHiddens( )
      {
         /* Send hidden variables. */
         GxWebStd.gx_hidden_field( context, "GXH_vCFLIGHTID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV6cFlightId), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCFLIGHTARRIVALAIRPORTID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV7cFlightArrivalAirportId), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCFLIGHTDEPARTUREAIRPORTID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV8cFlightDepartureAirportId), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCFLIGHTPRICE", StringUtil.LTrim( StringUtil.NToC( AV9cFlightPrice, 7, 2, ".", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCAIRLINEID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV10cAirlineId), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCFLIGHTDISCOUNTPERCENTAJE", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV11cFlightDiscountPercentaje), 4, 0, ".", "")));
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "nRC_GXsfl_74", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_GXsfl_74), 8, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vPFLIGHTID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV12pFlightId), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GRID1_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nFirstRecordOnPage), 15, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GRID1_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nEOF), 1, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "ADVANCEDCONTAINER_Class", StringUtil.RTrim( divAdvancedcontainer_Class));
         GxWebStd.gx_hidden_field( context, "BTNTOGGLE_Class", StringUtil.RTrim( bttBtntoggle_Class));
         GxWebStd.gx_hidden_field( context, "FLIGHTIDFILTERCONTAINER_Class", StringUtil.RTrim( divFlightidfiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "FLIGHTARRIVALAIRPORTIDFILTERCONTAINER_Class", StringUtil.RTrim( divFlightarrivalairportidfiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "FLIGHTDEPARTUREAIRPORTIDFILTERCONTAINER_Class", StringUtil.RTrim( divFlightdepartureairportidfiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "FLIGHTPRICEFILTERCONTAINER_Class", StringUtil.RTrim( divFlightpricefiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "AIRLINEIDFILTERCONTAINER_Class", StringUtil.RTrim( divAirlineidfiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "FLIGHTDISCOUNTPERCENTAJEFILTERCONTAINER_Class", StringUtil.RTrim( divFlightdiscountpercentajefiltercontainer_Class));
      }

      public override void RenderHtmlCloseForm( )
      {
         SendCloseFormHiddens( ) ;
         GxWebStd.gx_hidden_field( context, "GX_FocusControl", "notset");
         SendAjaxEncryptionKey();
         SendSecurityToken((string)(sPrefix));
         SendComponentObjects();
         SendServerCommands();
         SendState();
         if ( context.isSpaRequest( ) )
         {
            disableOutput();
         }
         context.WriteHtmlTextNl( "</form>") ;
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         include_jscripts( ) ;
      }

      public override void RenderHtmlContent( )
      {
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            context.WriteHtmlText( "<div") ;
            GxWebStd.ClassAttribute( context, "gx-ct-body"+" "+(String.IsNullOrEmpty(StringUtil.RTrim( Form.Class)) ? "form-horizontal Form" : Form.Class)+"-fx");
            context.WriteHtmlText( ">") ;
            WE0M2( ) ;
            context.WriteHtmlText( "</div>") ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT0M2( ) ;
      }

      public override bool HasEnterEvent( )
      {
         return true ;
      }

      public override GXWebForm GetForm( )
      {
         return Form ;
      }

      public override string GetSelfLink( )
      {
         return formatLink("gx0090.aspx", new object[] {UrlEncode(StringUtil.LTrimStr(AV12pFlightId,4,0))}, new string[] {"pFlightId"})  ;
      }

      public override string GetPgmname( )
      {
         return "Gx0090" ;
      }

      public override string GetPgmdesc( )
      {
         return "Selection List Flight" ;
      }

      protected void WB0M0( )
      {
         if ( context.isAjaxRequest( ) )
         {
            disableOutput();
         }
         if ( ! wbLoad )
         {
            if ( nGXWrapped == 1 )
            {
               RenderHtmlHeaders( ) ;
               RenderHtmlOpenForm( ) ;
            }
            GxWebStd.gx_msg_list( context, "", context.GX_msglist.DisplayMode, "", "", "", "false");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "Section", "start", "top", " "+"data-gx-base-lib=\"none\""+" "+"data-abstract-form"+" ", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divMain_Internalname, 1, 0, "px", 0, "px", "ContainerFluid PromptContainer", "start", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "start", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-3 PromptAdvancedBarCell", "start", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divAdvancedcontainer_Internalname, 1, 0, "px", 0, "px", divAdvancedcontainer_Class, "start", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "start", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "start", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divFlightidfiltercontainer_Internalname, 1, 0, "px", 0, "px", divFlightidfiltercontainer_Class, "start", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "start", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "start", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblflightidfilter_Internalname, "Flight Id", "", "", lblLblflightidfilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e110m1_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 0, 1, "HLP_Gx0090.htm");
            GxWebStd.gx_div_end( context, "start", "top", "div");
            GxWebStd.gx_div_end( context, "start", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "start", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "start", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "start", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCflightid_Internalname, "Flight Id", "col-sm-3 AttributeLabel", 0, true, "");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 16,'',false,'" + sGXsfl_74_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCflightid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV6cFlightId), 4, 0, ".", "")), StringUtil.LTrim( ((edtavCflightid_Enabled!=0) ? context.localUtil.Format( (decimal)(AV6cFlightId), "ZZZ9") : context.localUtil.Format( (decimal)(AV6cFlightId), "ZZZ9"))), " dir=\"ltr\" inputmode=\"numeric\" pattern=\"[0-9]*\""+TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(this,16);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCflightid_Jsonclick, 0, "Attribute", "", "", "", "", edtavCflightid_Visible, edtavCflightid_Enabled, 0, "text", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 0, -1, 0, true, "", "end", false, "", "HLP_Gx0090.htm");
            GxWebStd.gx_div_end( context, "start", "top", "div");
            GxWebStd.gx_div_end( context, "start", "top", "div");
            GxWebStd.gx_div_end( context, "start", "top", "div");
            GxWebStd.gx_div_end( context, "start", "top", "div");
            GxWebStd.gx_div_end( context, "start", "top", "div");
            GxWebStd.gx_div_end( context, "start", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "start", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "start", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divFlightarrivalairportidfiltercontainer_Internalname, 1, 0, "px", 0, "px", divFlightarrivalairportidfiltercontainer_Class, "start", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "start", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "start", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblflightarrivalairportidfilter_Internalname, "Flight Arrival Airport Id", "", "", lblLblflightarrivalairportidfilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e120m1_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 0, 1, "HLP_Gx0090.htm");
            GxWebStd.gx_div_end( context, "start", "top", "div");
            GxWebStd.gx_div_end( context, "start", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "start", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "start", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "start", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCflightarrivalairportid_Internalname, "Flight Arrival Airport Id", "col-sm-3 AttributeLabel", 0, true, "");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 26,'',false,'" + sGXsfl_74_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCflightarrivalairportid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV7cFlightArrivalAirportId), 4, 0, ".", "")), StringUtil.LTrim( ((edtavCflightarrivalairportid_Enabled!=0) ? context.localUtil.Format( (decimal)(AV7cFlightArrivalAirportId), "ZZZ9") : context.localUtil.Format( (decimal)(AV7cFlightArrivalAirportId), "ZZZ9"))), " dir=\"ltr\" inputmode=\"numeric\" pattern=\"[0-9]*\""+TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(this,26);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCflightarrivalairportid_Jsonclick, 0, "Attribute", "", "", "", "", edtavCflightarrivalairportid_Visible, edtavCflightarrivalairportid_Enabled, 0, "text", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 0, -1, 0, true, "", "end", false, "", "HLP_Gx0090.htm");
            GxWebStd.gx_div_end( context, "start", "top", "div");
            GxWebStd.gx_div_end( context, "start", "top", "div");
            GxWebStd.gx_div_end( context, "start", "top", "div");
            GxWebStd.gx_div_end( context, "start", "top", "div");
            GxWebStd.gx_div_end( context, "start", "top", "div");
            GxWebStd.gx_div_end( context, "start", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "start", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "start", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divFlightdepartureairportidfiltercontainer_Internalname, 1, 0, "px", 0, "px", divFlightdepartureairportidfiltercontainer_Class, "start", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "start", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "start", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblflightdepartureairportidfilter_Internalname, "Flight Departure Airport Id", "", "", lblLblflightdepartureairportidfilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e130m1_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 0, 1, "HLP_Gx0090.htm");
            GxWebStd.gx_div_end( context, "start", "top", "div");
            GxWebStd.gx_div_end( context, "start", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "start", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "start", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "start", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCflightdepartureairportid_Internalname, "Flight Departure Airport Id", "col-sm-3 AttributeLabel", 0, true, "");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 36,'',false,'" + sGXsfl_74_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCflightdepartureairportid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV8cFlightDepartureAirportId), 4, 0, ".", "")), StringUtil.LTrim( ((edtavCflightdepartureairportid_Enabled!=0) ? context.localUtil.Format( (decimal)(AV8cFlightDepartureAirportId), "ZZZ9") : context.localUtil.Format( (decimal)(AV8cFlightDepartureAirportId), "ZZZ9"))), " dir=\"ltr\" inputmode=\"numeric\" pattern=\"[0-9]*\""+TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(this,36);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCflightdepartureairportid_Jsonclick, 0, "Attribute", "", "", "", "", edtavCflightdepartureairportid_Visible, edtavCflightdepartureairportid_Enabled, 0, "text", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 0, -1, 0, true, "", "end", false, "", "HLP_Gx0090.htm");
            GxWebStd.gx_div_end( context, "start", "top", "div");
            GxWebStd.gx_div_end( context, "start", "top", "div");
            GxWebStd.gx_div_end( context, "start", "top", "div");
            GxWebStd.gx_div_end( context, "start", "top", "div");
            GxWebStd.gx_div_end( context, "start", "top", "div");
            GxWebStd.gx_div_end( context, "start", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "start", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "start", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divFlightpricefiltercontainer_Internalname, 1, 0, "px", 0, "px", divFlightpricefiltercontainer_Class, "start", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "start", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "start", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblflightpricefilter_Internalname, "Flight Price", "", "", lblLblflightpricefilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e140m1_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 0, 1, "HLP_Gx0090.htm");
            GxWebStd.gx_div_end( context, "start", "top", "div");
            GxWebStd.gx_div_end( context, "start", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "start", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "start", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "start", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCflightprice_Internalname, "Flight Price", "col-sm-3 AttributeLabel", 0, true, "");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 46,'',false,'" + sGXsfl_74_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCflightprice_Internalname, StringUtil.LTrim( StringUtil.NToC( AV9cFlightPrice, 7, 2, ".", "")), StringUtil.LTrim( ((edtavCflightprice_Enabled!=0) ? context.localUtil.Format( AV9cFlightPrice, "ZZZ9.99") : context.localUtil.Format( AV9cFlightPrice, "ZZZ9.99"))), TempTags+" onchange=\""+"gx.num.valid_decimal( this, ',','.','2');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_decimal( this, ',','.','2');"+";gx.evt.onblur(this,46);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCflightprice_Jsonclick, 0, "Attribute", "", "", "", "", edtavCflightprice_Visible, edtavCflightprice_Enabled, 0, "text", "", 7, "chr", 1, "row", 7, 0, 0, 0, 0, -1, 0, true, "", "end", false, "", "HLP_Gx0090.htm");
            GxWebStd.gx_div_end( context, "start", "top", "div");
            GxWebStd.gx_div_end( context, "start", "top", "div");
            GxWebStd.gx_div_end( context, "start", "top", "div");
            GxWebStd.gx_div_end( context, "start", "top", "div");
            GxWebStd.gx_div_end( context, "start", "top", "div");
            GxWebStd.gx_div_end( context, "start", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "start", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "start", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divAirlineidfiltercontainer_Internalname, 1, 0, "px", 0, "px", divAirlineidfiltercontainer_Class, "start", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "start", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "start", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblairlineidfilter_Internalname, "Airline Id", "", "", lblLblairlineidfilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e150m1_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 0, 1, "HLP_Gx0090.htm");
            GxWebStd.gx_div_end( context, "start", "top", "div");
            GxWebStd.gx_div_end( context, "start", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "start", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "start", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "start", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCairlineid_Internalname, "Airline Id", "col-sm-3 AttributeLabel", 0, true, "");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 56,'',false,'" + sGXsfl_74_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCairlineid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV10cAirlineId), 4, 0, ".", "")), StringUtil.LTrim( ((edtavCairlineid_Enabled!=0) ? context.localUtil.Format( (decimal)(AV10cAirlineId), "ZZZ9") : context.localUtil.Format( (decimal)(AV10cAirlineId), "ZZZ9"))), " dir=\"ltr\" inputmode=\"numeric\" pattern=\"[0-9]*\""+TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(this,56);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCairlineid_Jsonclick, 0, "Attribute", "", "", "", "", edtavCairlineid_Visible, edtavCairlineid_Enabled, 0, "text", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 0, -1, 0, true, "", "end", false, "", "HLP_Gx0090.htm");
            GxWebStd.gx_div_end( context, "start", "top", "div");
            GxWebStd.gx_div_end( context, "start", "top", "div");
            GxWebStd.gx_div_end( context, "start", "top", "div");
            GxWebStd.gx_div_end( context, "start", "top", "div");
            GxWebStd.gx_div_end( context, "start", "top", "div");
            GxWebStd.gx_div_end( context, "start", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "start", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "start", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divFlightdiscountpercentajefiltercontainer_Internalname, 1, 0, "px", 0, "px", divFlightdiscountpercentajefiltercontainer_Class, "start", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "start", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "start", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblflightdiscountpercentajefilter_Internalname, "Flight Discount Percentaje", "", "", lblLblflightdiscountpercentajefilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e160m1_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 0, 1, "HLP_Gx0090.htm");
            GxWebStd.gx_div_end( context, "start", "top", "div");
            GxWebStd.gx_div_end( context, "start", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "start", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "start", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "start", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCflightdiscountpercentaje_Internalname, "Flight Discount Percentaje", "col-sm-3 AttributeLabel", 0, true, "");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 66,'',false,'" + sGXsfl_74_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCflightdiscountpercentaje_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV11cFlightDiscountPercentaje), 4, 0, ".", "")), StringUtil.LTrim( ((edtavCflightdiscountpercentaje_Enabled!=0) ? context.localUtil.Format( (decimal)(AV11cFlightDiscountPercentaje), "ZZZ9") : context.localUtil.Format( (decimal)(AV11cFlightDiscountPercentaje), "ZZZ9"))), " dir=\"ltr\" inputmode=\"numeric\" pattern=\"[0-9]*\""+TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(this,66);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCflightdiscountpercentaje_Jsonclick, 0, "Attribute", "", "", "", "", edtavCflightdiscountpercentaje_Visible, edtavCflightdiscountpercentaje_Enabled, 0, "text", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 0, -1, 0, true, "", "end", false, "", "HLP_Gx0090.htm");
            GxWebStd.gx_div_end( context, "start", "top", "div");
            GxWebStd.gx_div_end( context, "start", "top", "div");
            GxWebStd.gx_div_end( context, "start", "top", "div");
            GxWebStd.gx_div_end( context, "start", "top", "div");
            GxWebStd.gx_div_end( context, "start", "top", "div");
            GxWebStd.gx_div_end( context, "start", "top", "div");
            GxWebStd.gx_div_end( context, "start", "top", "div");
            GxWebStd.gx_div_end( context, "start", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-9 WWGridCell", "start", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divGridtable_Internalname, 1, 0, "px", 0, "px", "Table", "start", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "start", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 hidden-sm hidden-md hidden-lg ToggleCell", "start", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 71,'',false,'',0)\"";
            ClassString = bttBtntoggle_Class;
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtntoggle_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(74), 2, 0)+","+"null"+");", "|||", bttBtntoggle_Jsonclick, 7, "|||", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"e170m1_client"+"'", TempTags, "", 2, "HLP_Gx0090.htm");
            GxWebStd.gx_div_end( context, "start", "top", "div");
            GxWebStd.gx_div_end( context, "start", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "start", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "start", "top", "", "", "div");
            /*  Grid Control  */
            Grid1Container.SetWrapped(nGXWrapped);
            StartGridControl74( ) ;
         }
         if ( wbEnd == 74 )
         {
            wbEnd = 0;
            nRC_GXsfl_74 = (int)(nGXsfl_74_idx-1);
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "</table>") ;
               context.WriteHtmlText( "</div>") ;
            }
            else
            {
               Grid1Container.AddObjectProperty("GRID1_nEOF", GRID1_nEOF);
               Grid1Container.AddObjectProperty("GRID1_nFirstRecordOnPage", GRID1_nFirstRecordOnPage);
               sStyleString = "";
               context.WriteHtmlText( "<div id=\""+"Grid1Container"+"Div\" "+sStyleString+">"+"</div>") ;
               context.httpAjaxContext.ajax_rsp_assign_grid("_"+"Grid1", Grid1Container, subGrid1_Internalname);
               if ( ! context.isAjaxRequest( ) && ! context.isSpaRequest( ) )
               {
                  GxWebStd.gx_hidden_field( context, "Grid1ContainerData", Grid1Container.ToJavascriptSource());
               }
               if ( context.isAjaxRequest( ) || context.isSpaRequest( ) )
               {
                  GxWebStd.gx_hidden_field( context, "Grid1ContainerData"+"V", Grid1Container.GridValuesHidden());
               }
               else
               {
                  context.WriteHtmlText( "<input type=\"hidden\" "+"name=\""+"Grid1ContainerData"+"V"+"\" value='"+Grid1Container.GridValuesHidden()+"'/>") ;
               }
            }
            GxWebStd.gx_div_end( context, "start", "top", "div");
            GxWebStd.gx_div_end( context, "start", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "start", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "start", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 84,'',false,'',0)\"";
            ClassString = "BtnCancel";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(74), 2, 0)+","+"null"+");", "Cancel", bttBtn_cancel_Jsonclick, 1, "Cancel", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_Gx0090.htm");
            GxWebStd.gx_div_end( context, "start", "top", "div");
            GxWebStd.gx_div_end( context, "start", "top", "div");
            GxWebStd.gx_div_end( context, "start", "top", "div");
            GxWebStd.gx_div_end( context, "start", "top", "div");
            GxWebStd.gx_div_end( context, "start", "top", "div");
            GxWebStd.gx_div_end( context, "start", "top", "div");
            GxWebStd.gx_div_end( context, "start", "top", "div");
         }
         if ( wbEnd == 74 )
         {
            wbEnd = 0;
            if ( isFullAjaxMode( ) )
            {
               if ( Grid1Container.GetWrapped() == 1 )
               {
                  context.WriteHtmlText( "</table>") ;
                  context.WriteHtmlText( "</div>") ;
               }
               else
               {
                  Grid1Container.AddObjectProperty("GRID1_nEOF", GRID1_nEOF);
                  Grid1Container.AddObjectProperty("GRID1_nFirstRecordOnPage", GRID1_nFirstRecordOnPage);
                  sStyleString = "";
                  context.WriteHtmlText( "<div id=\""+"Grid1Container"+"Div\" "+sStyleString+">"+"</div>") ;
                  context.httpAjaxContext.ajax_rsp_assign_grid("_"+"Grid1", Grid1Container, subGrid1_Internalname);
                  if ( ! context.isAjaxRequest( ) && ! context.isSpaRequest( ) )
                  {
                     GxWebStd.gx_hidden_field( context, "Grid1ContainerData", Grid1Container.ToJavascriptSource());
                  }
                  if ( context.isAjaxRequest( ) || context.isSpaRequest( ) )
                  {
                     GxWebStd.gx_hidden_field( context, "Grid1ContainerData"+"V", Grid1Container.GridValuesHidden());
                  }
                  else
                  {
                     context.WriteHtmlText( "<input type=\"hidden\" "+"name=\""+"Grid1ContainerData"+"V"+"\" value='"+Grid1Container.GridValuesHidden()+"'/>") ;
                  }
               }
            }
         }
         wbLoad = true;
      }

      protected void START0M2( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( ! context.isSpaRequest( ) )
         {
            if ( context.ExposeMetadata( ) )
            {
               Form.Meta.addItem("generator", "GeneXus .NET 18_0_4-174187", 0) ;
            }
            Form.Meta.addItem("description", "Selection List Flight", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false;
         STRUP0M0( ) ;
      }

      protected void WS0M2( )
      {
         START0M2( ) ;
         EVT0M2( ) ;
      }

      protected void EVT0M2( )
      {
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) && ! wbErr )
            {
               /* Read Web Panel buttons. */
               sEvt = cgiGet( "_EventName");
               EvtGridId = cgiGet( "_EventGridId");
               EvtRowId = cgiGet( "_EventRowId");
               if ( StringUtil.Len( sEvt) > 0 )
               {
                  sEvtType = StringUtil.Left( sEvt, 1);
                  sEvt = StringUtil.Right( sEvt, (short)(StringUtil.Len( sEvt)-1));
                  if ( StringUtil.StrCmp(sEvtType, "M") != 0 )
                  {
                     if ( StringUtil.StrCmp(sEvtType, "E") == 0 )
                     {
                        sEvtType = StringUtil.Right( sEvt, 1);
                        if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                        {
                           sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1));
                           if ( StringUtil.StrCmp(sEvt, "RFR") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* No code required for Cancel button. It is implemented as the Reset button. */
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LSCR") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                           }
                           else if ( StringUtil.StrCmp(sEvt, "GRID1PAGING") == 0 )
                           {
                              context.wbHandled = 1;
                              sEvt = cgiGet( "GRID1PAGING");
                              if ( StringUtil.StrCmp(sEvt, "FIRST") == 0 )
                              {
                                 subgrid1_firstpage( ) ;
                              }
                              else if ( StringUtil.StrCmp(sEvt, "PREV") == 0 )
                              {
                                 subgrid1_previouspage( ) ;
                              }
                              else if ( StringUtil.StrCmp(sEvt, "NEXT") == 0 )
                              {
                                 subgrid1_nextpage( ) ;
                              }
                              else if ( StringUtil.StrCmp(sEvt, "LAST") == 0 )
                              {
                                 subgrid1_lastpage( ) ;
                              }
                              dynload_actions( ) ;
                           }
                        }
                        else
                        {
                           sEvtType = StringUtil.Right( sEvt, 4);
                           sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-4));
                           if ( ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "START") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 4), "LOAD") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "ENTER") == 0 ) )
                           {
                              nGXsfl_74_idx = (int)(Math.Round(NumberUtil.Val( sEvtType, "."), 18, MidpointRounding.ToEven));
                              sGXsfl_74_idx = StringUtil.PadL( StringUtil.LTrimStr( (decimal)(nGXsfl_74_idx), 4, 0), 4, "0");
                              SubsflControlProps_742( ) ;
                              AV5LinkSelection = cgiGet( edtavLinkselection_Internalname);
                              AssignProp("", false, edtavLinkselection_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV5LinkSelection)) ? AV14Linkselection_GXI : context.convertURL( context.PathToRelativeUrl( AV5LinkSelection))), !bGXsfl_74_Refreshing);
                              AssignProp("", false, edtavLinkselection_Internalname, "SrcSet", context.GetImageSrcSet( AV5LinkSelection), true);
                              A19FlightId = (short)(Math.Round(context.localUtil.CToN( cgiGet( edtFlightId_Internalname), ".", ","), 18, MidpointRounding.ToEven));
                              A25FlightArrivalAirportId = (short)(Math.Round(context.localUtil.CToN( cgiGet( edtFlightArrivalAirportId_Internalname), ".", ","), 18, MidpointRounding.ToEven));
                              A24FlightDepartureAirportId = (short)(Math.Round(context.localUtil.CToN( cgiGet( edtFlightDepartureAirportId_Internalname), ".", ","), 18, MidpointRounding.ToEven));
                              A35FlightPrice = context.localUtil.CToN( cgiGet( edtFlightPrice_Internalname), ".", ",");
                              A38AirlineId = (short)(Math.Round(context.localUtil.CToN( cgiGet( edtAirlineId_Internalname), ".", ","), 18, MidpointRounding.ToEven));
                              n38AirlineId = false;
                              A36FlightDiscountPercentaje = (short)(Math.Round(context.localUtil.CToN( cgiGet( edtFlightDiscountPercentaje_Internalname), ".", ","), 18, MidpointRounding.ToEven));
                              sEvtType = StringUtil.Right( sEvt, 1);
                              if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                              {
                                 sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1));
                                 if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: Start */
                                    E180M2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: Load */
                                    E190M2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    if ( ! wbErr )
                                    {
                                       Rfr0gs = false;
                                       /* Set Refresh If Cflightid Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCFLIGHTID"), ".", ",") != Convert.ToDecimal( AV6cFlightId )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Cflightarrivalairportid Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCFLIGHTARRIVALAIRPORTID"), ".", ",") != Convert.ToDecimal( AV7cFlightArrivalAirportId )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Cflightdepartureairportid Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCFLIGHTDEPARTUREAIRPORTID"), ".", ",") != Convert.ToDecimal( AV8cFlightDepartureAirportId )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Cflightprice Changed */
                                       if ( context.localUtil.CToN( cgiGet( "GXH_vCFLIGHTPRICE"), ".", ",") != AV9cFlightPrice )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Cairlineid Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCAIRLINEID"), ".", ",") != Convert.ToDecimal( AV10cAirlineId )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Cflightdiscountpercentaje Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCFLIGHTDISCOUNTPERCENTAJE"), ".", ",") != Convert.ToDecimal( AV11cFlightDiscountPercentaje )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       if ( ! Rfr0gs )
                                       {
                                          /* Execute user event: Enter */
                                          E200M2 ();
                                       }
                                       dynload_actions( ) ;
                                    }
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "LSCR") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                 }
                              }
                              else
                              {
                              }
                           }
                        }
                     }
                     context.wbHandled = 1;
                  }
               }
            }
         }
      }

      protected void WE0M2( )
      {
         if ( ! GxWebStd.gx_redirect( context) )
         {
            Rfr0gs = true;
            Refresh( ) ;
            if ( ! GxWebStd.gx_redirect( context) )
            {
               if ( nGXWrapped == 1 )
               {
                  RenderHtmlCloseForm( ) ;
               }
            }
         }
      }

      protected void PA0M2( )
      {
         if ( nDonePA == 0 )
         {
            if ( String.IsNullOrEmpty(StringUtil.RTrim( context.GetCookie( "GX_SESSION_ID"))) )
            {
               gxcookieaux = context.SetCookie( "GX_SESSION_ID", Encrypt64( Crypto.GetEncryptionKey( ), Crypto.GetServerKey( )), "", (DateTime)(DateTime.MinValue), "", (short)(context.GetHttpSecure( )));
            }
            GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
            toggleJsOutput = isJsOutputEnabled( );
            if ( context.isSpaRequest( ) )
            {
               disableJsOutput();
            }
            init_web_controls( ) ;
            if ( toggleJsOutput )
            {
               if ( context.isSpaRequest( ) )
               {
                  enableJsOutput();
               }
            }
            nDonePA = 1;
         }
      }

      protected void dynload_actions( )
      {
         /* End function dynload_actions */
      }

      protected void gxnrGrid1_newrow( )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         SubsflControlProps_742( ) ;
         while ( nGXsfl_74_idx <= nRC_GXsfl_74 )
         {
            sendrow_742( ) ;
            nGXsfl_74_idx = ((subGrid1_Islastpage==1)&&(nGXsfl_74_idx+1>subGrid1_fnc_Recordsperpage( )) ? 1 : nGXsfl_74_idx+1);
            sGXsfl_74_idx = StringUtil.PadL( StringUtil.LTrimStr( (decimal)(nGXsfl_74_idx), 4, 0), 4, "0");
            SubsflControlProps_742( ) ;
         }
         AddString( context.httpAjaxContext.getJSONContainerResponse( Grid1Container)) ;
         /* End function gxnrGrid1_newrow */
      }

      protected void gxgrGrid1_refresh( int subGrid1_Rows ,
                                        short AV6cFlightId ,
                                        short AV7cFlightArrivalAirportId ,
                                        short AV8cFlightDepartureAirportId ,
                                        decimal AV9cFlightPrice ,
                                        short AV10cAirlineId ,
                                        short AV11cFlightDiscountPercentaje )
      {
         initialize_formulas( ) ;
         GxWebStd.set_html_headers( context, 0, "", "");
         GRID1_nCurrentRecord = 0;
         RF0M2( ) ;
         GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
         send_integrity_footer_hashes( ) ;
         GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
         /* End function gxgrGrid1_refresh */
      }

      protected void send_integrity_hashes( )
      {
         GxWebStd.gx_hidden_field( context, "gxhash_FLIGHTID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(A19FlightId), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "FLIGHTID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A19FlightId), 4, 0, ".", "")));
      }

      protected void clear_multi_value_controls( )
      {
         if ( context.isAjaxRequest( ) )
         {
            dynload_actions( ) ;
            before_start_formulas( ) ;
         }
      }

      protected void fix_multi_value_controls( )
      {
      }

      public void Refresh( )
      {
         send_integrity_hashes( ) ;
         RF0M2( ) ;
         if ( isFullAjaxMode( ) )
         {
            send_integrity_footer_hashes( ) ;
         }
      }

      protected void initialize_formulas( )
      {
         /* GeneXus formulas. */
      }

      protected void RF0M2( )
      {
         initialize_formulas( ) ;
         clear_multi_value_controls( ) ;
         if ( isAjaxCallMode( ) )
         {
            Grid1Container.ClearRows();
         }
         wbStart = 74;
         nGXsfl_74_idx = 1;
         sGXsfl_74_idx = StringUtil.PadL( StringUtil.LTrimStr( (decimal)(nGXsfl_74_idx), 4, 0), 4, "0");
         SubsflControlProps_742( ) ;
         bGXsfl_74_Refreshing = true;
         Grid1Container.AddObjectProperty("GridName", "Grid1");
         Grid1Container.AddObjectProperty("CmpContext", "");
         Grid1Container.AddObjectProperty("InMasterPage", "false");
         Grid1Container.AddObjectProperty("Class", "PromptGrid");
         Grid1Container.AddObjectProperty("Cellpadding", StringUtil.LTrim( StringUtil.NToC( (decimal)(1), 4, 0, ".", "")));
         Grid1Container.AddObjectProperty("Cellspacing", StringUtil.LTrim( StringUtil.NToC( (decimal)(2), 4, 0, ".", "")));
         Grid1Container.AddObjectProperty("Backcolorstyle", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Backcolorstyle), 1, 0, ".", "")));
         Grid1Container.PageSize = subGrid1_fnc_Recordsperpage( );
         gxdyncontrolsrefreshing = true;
         fix_multi_value_controls( ) ;
         gxdyncontrolsrefreshing = false;
         if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
         {
            SubsflControlProps_742( ) ;
            GXPagingFrom2 = (int)(GRID1_nFirstRecordOnPage);
            GXPagingTo2 = (int)(subGrid1_fnc_Recordsperpage( )+1);
            pr_default.dynParam(0, new Object[]{ new Object[]{
                                                 AV7cFlightArrivalAirportId ,
                                                 AV8cFlightDepartureAirportId ,
                                                 AV9cFlightPrice ,
                                                 AV10cAirlineId ,
                                                 AV11cFlightDiscountPercentaje ,
                                                 A25FlightArrivalAirportId ,
                                                 A24FlightDepartureAirportId ,
                                                 A35FlightPrice ,
                                                 A38AirlineId ,
                                                 A36FlightDiscountPercentaje ,
                                                 AV6cFlightId } ,
                                                 new int[]{
                                                 TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.DECIMAL, TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.DECIMAL, TypeConstants.SHORT, TypeConstants.BOOLEAN,
                                                 TypeConstants.SHORT, TypeConstants.SHORT
                                                 }
            });
            /* Using cursor H000M2 */
            pr_default.execute(0, new Object[] {AV6cFlightId, AV7cFlightArrivalAirportId, AV8cFlightDepartureAirportId, AV9cFlightPrice, AV10cAirlineId, AV11cFlightDiscountPercentaje, GXPagingFrom2, GXPagingTo2, GXPagingTo2});
            nGXsfl_74_idx = 1;
            sGXsfl_74_idx = StringUtil.PadL( StringUtil.LTrimStr( (decimal)(nGXsfl_74_idx), 4, 0), 4, "0");
            SubsflControlProps_742( ) ;
            while ( ( (pr_default.getStatus(0) != 101) ) && ( ( GRID1_nCurrentRecord < subGrid1_fnc_Recordsperpage( ) ) ) )
            {
               A36FlightDiscountPercentaje = H000M2_A36FlightDiscountPercentaje[0];
               A38AirlineId = H000M2_A38AirlineId[0];
               n38AirlineId = H000M2_n38AirlineId[0];
               A35FlightPrice = H000M2_A35FlightPrice[0];
               A24FlightDepartureAirportId = H000M2_A24FlightDepartureAirportId[0];
               A25FlightArrivalAirportId = H000M2_A25FlightArrivalAirportId[0];
               A19FlightId = H000M2_A19FlightId[0];
               /* Execute user event: Load */
               E190M2 ();
               pr_default.readNext(0);
            }
            GRID1_nEOF = (short)(((pr_default.getStatus(0) == 101) ? 1 : 0));
            GxWebStd.gx_hidden_field( context, "GRID1_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nEOF), 1, 0, ".", "")));
            pr_default.close(0);
            wbEnd = 74;
            WB0M0( ) ;
         }
         bGXsfl_74_Refreshing = true;
      }

      protected void send_integrity_lvl_hashes0M2( )
      {
         GxWebStd.gx_hidden_field( context, "gxhash_FLIGHTID"+"_"+sGXsfl_74_idx, GetSecureSignedToken( sGXsfl_74_idx, context.localUtil.Format( (decimal)(A19FlightId), "ZZZ9"), context));
      }

      protected int subGrid1_fnc_Pagecount( )
      {
         GRID1_nRecordCount = subGrid1_fnc_Recordcount( );
         if ( ((int)((GRID1_nRecordCount) % (subGrid1_fnc_Recordsperpage( )))) == 0 )
         {
            return (int)(NumberUtil.Int( (long)(Math.Round(GRID1_nRecordCount/ (decimal)(subGrid1_fnc_Recordsperpage( )), 18, MidpointRounding.ToEven)))) ;
         }
         return (int)(NumberUtil.Int( (long)(Math.Round(GRID1_nRecordCount/ (decimal)(subGrid1_fnc_Recordsperpage( )), 18, MidpointRounding.ToEven)))+1) ;
      }

      protected int subGrid1_fnc_Recordcount( )
      {
         pr_default.dynParam(1, new Object[]{ new Object[]{
                                              AV7cFlightArrivalAirportId ,
                                              AV8cFlightDepartureAirportId ,
                                              AV9cFlightPrice ,
                                              AV10cAirlineId ,
                                              AV11cFlightDiscountPercentaje ,
                                              A25FlightArrivalAirportId ,
                                              A24FlightDepartureAirportId ,
                                              A35FlightPrice ,
                                              A38AirlineId ,
                                              A36FlightDiscountPercentaje ,
                                              AV6cFlightId } ,
                                              new int[]{
                                              TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.DECIMAL, TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.DECIMAL, TypeConstants.SHORT, TypeConstants.BOOLEAN,
                                              TypeConstants.SHORT, TypeConstants.SHORT
                                              }
         });
         /* Using cursor H000M3 */
         pr_default.execute(1, new Object[] {AV6cFlightId, AV7cFlightArrivalAirportId, AV8cFlightDepartureAirportId, AV9cFlightPrice, AV10cAirlineId, AV11cFlightDiscountPercentaje});
         GRID1_nRecordCount = H000M3_AGRID1_nRecordCount[0];
         pr_default.close(1);
         return (int)(GRID1_nRecordCount) ;
      }

      protected int subGrid1_fnc_Recordsperpage( )
      {
         return (int)(10*1) ;
      }

      protected int subGrid1_fnc_Currentpage( )
      {
         return (int)(NumberUtil.Int( (long)(Math.Round(GRID1_nFirstRecordOnPage/ (decimal)(subGrid1_fnc_Recordsperpage( )), 18, MidpointRounding.ToEven)))+1) ;
      }

      protected short subgrid1_firstpage( )
      {
         GRID1_nFirstRecordOnPage = 0;
         GxWebStd.gx_hidden_field( context, "GRID1_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nFirstRecordOnPage), 15, 0, ".", "")));
         if ( isFullAjaxMode( ) )
         {
            gxgrGrid1_refresh( subGrid1_Rows, AV6cFlightId, AV7cFlightArrivalAirportId, AV8cFlightDepartureAirportId, AV9cFlightPrice, AV10cAirlineId, AV11cFlightDiscountPercentaje) ;
         }
         send_integrity_footer_hashes( ) ;
         return 0 ;
      }

      protected short subgrid1_nextpage( )
      {
         GRID1_nRecordCount = subGrid1_fnc_Recordcount( );
         if ( ( GRID1_nRecordCount >= subGrid1_fnc_Recordsperpage( ) ) && ( GRID1_nEOF == 0 ) )
         {
            GRID1_nFirstRecordOnPage = (long)(GRID1_nFirstRecordOnPage+subGrid1_fnc_Recordsperpage( ));
         }
         else
         {
            return 2 ;
         }
         GxWebStd.gx_hidden_field( context, "GRID1_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nFirstRecordOnPage), 15, 0, ".", "")));
         Grid1Container.AddObjectProperty("GRID1_nFirstRecordOnPage", GRID1_nFirstRecordOnPage);
         if ( isFullAjaxMode( ) )
         {
            gxgrGrid1_refresh( subGrid1_Rows, AV6cFlightId, AV7cFlightArrivalAirportId, AV8cFlightDepartureAirportId, AV9cFlightPrice, AV10cAirlineId, AV11cFlightDiscountPercentaje) ;
         }
         send_integrity_footer_hashes( ) ;
         return (short)(((GRID1_nEOF==0) ? 0 : 2)) ;
      }

      protected short subgrid1_previouspage( )
      {
         if ( GRID1_nFirstRecordOnPage >= subGrid1_fnc_Recordsperpage( ) )
         {
            GRID1_nFirstRecordOnPage = (long)(GRID1_nFirstRecordOnPage-subGrid1_fnc_Recordsperpage( ));
         }
         else
         {
            return 2 ;
         }
         GxWebStd.gx_hidden_field( context, "GRID1_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nFirstRecordOnPage), 15, 0, ".", "")));
         if ( isFullAjaxMode( ) )
         {
            gxgrGrid1_refresh( subGrid1_Rows, AV6cFlightId, AV7cFlightArrivalAirportId, AV8cFlightDepartureAirportId, AV9cFlightPrice, AV10cAirlineId, AV11cFlightDiscountPercentaje) ;
         }
         send_integrity_footer_hashes( ) ;
         return 0 ;
      }

      protected short subgrid1_lastpage( )
      {
         GRID1_nRecordCount = subGrid1_fnc_Recordcount( );
         if ( GRID1_nRecordCount > subGrid1_fnc_Recordsperpage( ) )
         {
            if ( ((int)((GRID1_nRecordCount) % (subGrid1_fnc_Recordsperpage( )))) == 0 )
            {
               GRID1_nFirstRecordOnPage = (long)(GRID1_nRecordCount-subGrid1_fnc_Recordsperpage( ));
            }
            else
            {
               GRID1_nFirstRecordOnPage = (long)(GRID1_nRecordCount-((int)((GRID1_nRecordCount) % (subGrid1_fnc_Recordsperpage( )))));
            }
         }
         else
         {
            GRID1_nFirstRecordOnPage = 0;
         }
         GxWebStd.gx_hidden_field( context, "GRID1_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nFirstRecordOnPage), 15, 0, ".", "")));
         if ( isFullAjaxMode( ) )
         {
            gxgrGrid1_refresh( subGrid1_Rows, AV6cFlightId, AV7cFlightArrivalAirportId, AV8cFlightDepartureAirportId, AV9cFlightPrice, AV10cAirlineId, AV11cFlightDiscountPercentaje) ;
         }
         send_integrity_footer_hashes( ) ;
         return 0 ;
      }

      protected int subgrid1_gotopage( int nPageNo )
      {
         if ( nPageNo > 0 )
         {
            GRID1_nFirstRecordOnPage = (long)(subGrid1_fnc_Recordsperpage( )*(nPageNo-1));
         }
         else
         {
            GRID1_nFirstRecordOnPage = 0;
         }
         GxWebStd.gx_hidden_field( context, "GRID1_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nFirstRecordOnPage), 15, 0, ".", "")));
         if ( isFullAjaxMode( ) )
         {
            gxgrGrid1_refresh( subGrid1_Rows, AV6cFlightId, AV7cFlightArrivalAirportId, AV8cFlightDepartureAirportId, AV9cFlightPrice, AV10cAirlineId, AV11cFlightDiscountPercentaje) ;
         }
         send_integrity_footer_hashes( ) ;
         return (int)(0) ;
      }

      protected void before_start_formulas( )
      {
         fix_multi_value_controls( ) ;
      }

      protected void STRUP0M0( )
      {
         /* Before Start, stand alone formulas. */
         before_start_formulas( ) ;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E180M2 ();
         context.wbGlbDoneStart = 1;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            /* Read saved values. */
            nRC_GXsfl_74 = (int)(Math.Round(context.localUtil.CToN( cgiGet( "nRC_GXsfl_74"), ".", ","), 18, MidpointRounding.ToEven));
            GRID1_nFirstRecordOnPage = (long)(Math.Round(context.localUtil.CToN( cgiGet( "GRID1_nFirstRecordOnPage"), ".", ","), 18, MidpointRounding.ToEven));
            GRID1_nEOF = (short)(Math.Round(context.localUtil.CToN( cgiGet( "GRID1_nEOF"), ".", ","), 18, MidpointRounding.ToEven));
            /* Read variables values. */
            if ( ( ( context.localUtil.CToN( cgiGet( edtavCflightid_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavCflightid_Internalname), ".", ",") > Convert.ToDecimal( 9999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vCFLIGHTID");
               GX_FocusControl = edtavCflightid_Internalname;
               AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV6cFlightId = 0;
               AssignAttri("", false, "AV6cFlightId", StringUtil.LTrimStr( (decimal)(AV6cFlightId), 4, 0));
            }
            else
            {
               AV6cFlightId = (short)(Math.Round(context.localUtil.CToN( cgiGet( edtavCflightid_Internalname), ".", ","), 18, MidpointRounding.ToEven));
               AssignAttri("", false, "AV6cFlightId", StringUtil.LTrimStr( (decimal)(AV6cFlightId), 4, 0));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavCflightarrivalairportid_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavCflightarrivalairportid_Internalname), ".", ",") > Convert.ToDecimal( 9999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vCFLIGHTARRIVALAIRPORTID");
               GX_FocusControl = edtavCflightarrivalairportid_Internalname;
               AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV7cFlightArrivalAirportId = 0;
               AssignAttri("", false, "AV7cFlightArrivalAirportId", StringUtil.LTrimStr( (decimal)(AV7cFlightArrivalAirportId), 4, 0));
            }
            else
            {
               AV7cFlightArrivalAirportId = (short)(Math.Round(context.localUtil.CToN( cgiGet( edtavCflightarrivalairportid_Internalname), ".", ","), 18, MidpointRounding.ToEven));
               AssignAttri("", false, "AV7cFlightArrivalAirportId", StringUtil.LTrimStr( (decimal)(AV7cFlightArrivalAirportId), 4, 0));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavCflightdepartureairportid_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavCflightdepartureairportid_Internalname), ".", ",") > Convert.ToDecimal( 9999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vCFLIGHTDEPARTUREAIRPORTID");
               GX_FocusControl = edtavCflightdepartureairportid_Internalname;
               AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV8cFlightDepartureAirportId = 0;
               AssignAttri("", false, "AV8cFlightDepartureAirportId", StringUtil.LTrimStr( (decimal)(AV8cFlightDepartureAirportId), 4, 0));
            }
            else
            {
               AV8cFlightDepartureAirportId = (short)(Math.Round(context.localUtil.CToN( cgiGet( edtavCflightdepartureairportid_Internalname), ".", ","), 18, MidpointRounding.ToEven));
               AssignAttri("", false, "AV8cFlightDepartureAirportId", StringUtil.LTrimStr( (decimal)(AV8cFlightDepartureAirportId), 4, 0));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavCflightprice_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavCflightprice_Internalname), ".", ",") > 9999.99m ) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vCFLIGHTPRICE");
               GX_FocusControl = edtavCflightprice_Internalname;
               AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV9cFlightPrice = 0;
               AssignAttri("", false, "AV9cFlightPrice", StringUtil.LTrimStr( AV9cFlightPrice, 7, 2));
            }
            else
            {
               AV9cFlightPrice = context.localUtil.CToN( cgiGet( edtavCflightprice_Internalname), ".", ",");
               AssignAttri("", false, "AV9cFlightPrice", StringUtil.LTrimStr( AV9cFlightPrice, 7, 2));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavCairlineid_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavCairlineid_Internalname), ".", ",") > Convert.ToDecimal( 9999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vCAIRLINEID");
               GX_FocusControl = edtavCairlineid_Internalname;
               AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV10cAirlineId = 0;
               AssignAttri("", false, "AV10cAirlineId", StringUtil.LTrimStr( (decimal)(AV10cAirlineId), 4, 0));
            }
            else
            {
               AV10cAirlineId = (short)(Math.Round(context.localUtil.CToN( cgiGet( edtavCairlineid_Internalname), ".", ","), 18, MidpointRounding.ToEven));
               AssignAttri("", false, "AV10cAirlineId", StringUtil.LTrimStr( (decimal)(AV10cAirlineId), 4, 0));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavCflightdiscountpercentaje_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavCflightdiscountpercentaje_Internalname), ".", ",") > Convert.ToDecimal( 9999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vCFLIGHTDISCOUNTPERCENTAJE");
               GX_FocusControl = edtavCflightdiscountpercentaje_Internalname;
               AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV11cFlightDiscountPercentaje = 0;
               AssignAttri("", false, "AV11cFlightDiscountPercentaje", StringUtil.LTrimStr( (decimal)(AV11cFlightDiscountPercentaje), 4, 0));
            }
            else
            {
               AV11cFlightDiscountPercentaje = (short)(Math.Round(context.localUtil.CToN( cgiGet( edtavCflightdiscountpercentaje_Internalname), ".", ","), 18, MidpointRounding.ToEven));
               AssignAttri("", false, "AV11cFlightDiscountPercentaje", StringUtil.LTrimStr( (decimal)(AV11cFlightDiscountPercentaje), 4, 0));
            }
            /* Read subfile selected row values. */
            /* Read hidden variables. */
            GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
            /* Check if conditions changed and reset current page numbers */
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vCFLIGHTID"), ".", ",") != Convert.ToDecimal( AV6cFlightId )) )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vCFLIGHTARRIVALAIRPORTID"), ".", ",") != Convert.ToDecimal( AV7cFlightArrivalAirportId )) )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vCFLIGHTDEPARTUREAIRPORTID"), ".", ",") != Convert.ToDecimal( AV8cFlightDepartureAirportId )) )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( context.localUtil.CToN( cgiGet( "GXH_vCFLIGHTPRICE"), ".", ",") != AV9cFlightPrice )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vCAIRLINEID"), ".", ",") != Convert.ToDecimal( AV10cAirlineId )) )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vCFLIGHTDISCOUNTPERCENTAJE"), ".", ",") != Convert.ToDecimal( AV11cFlightDiscountPercentaje )) )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
         }
         else
         {
            dynload_actions( ) ;
         }
      }

      protected void GXStart( )
      {
         /* Execute user event: Start */
         E180M2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E180M2( )
      {
         /* Start Routine */
         returnInSub = false;
         Form.Caption = StringUtil.Format( "Selection List %1", "Flight", "", "", "", "", "", "", "", "");
         AssignProp("", false, "FORM", "Caption", Form.Caption, true);
         AV13ADVANCED_LABEL_TEMPLATE = "%1 <strong>%2</strong>";
      }

      private void E190M2( )
      {
         /* Load Routine */
         returnInSub = false;
         edtavLinkselection_gximage = "selectRow";
         AV5LinkSelection = context.GetImagePath( "3914535b-0c03-44c5-9538-906a99cdd2bc", "", context.GetTheme( ));
         AssignAttri("", false, edtavLinkselection_Internalname, AV5LinkSelection);
         AV14Linkselection_GXI = GXDbFile.PathToUrl( context.GetImagePath( "3914535b-0c03-44c5-9538-906a99cdd2bc", "", context.GetTheme( )));
         sendrow_742( ) ;
         GRID1_nCurrentRecord = (long)(GRID1_nCurrentRecord+1);
         if ( isFullAjaxMode( ) && ! bGXsfl_74_Refreshing )
         {
            DoAjaxLoad(74, Grid1Row);
         }
      }

      public void GXEnter( )
      {
         /* Execute user event: Enter */
         E200M2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E200M2( )
      {
         /* Enter Routine */
         returnInSub = false;
         AV12pFlightId = A19FlightId;
         AssignAttri("", false, "AV12pFlightId", StringUtil.LTrimStr( (decimal)(AV12pFlightId), 4, 0));
         context.setWebReturnParms(new Object[] {(short)AV12pFlightId});
         context.setWebReturnParmsMetadata(new Object[] {"AV12pFlightId"});
         context.wjLocDisableFrm = 1;
         context.nUserReturn = 1;
         returnInSub = true;
         if (true) return;
         /*  Sending Event outputs  */
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         AV12pFlightId = Convert.ToInt16(getParm(obj,0));
         AssignAttri("", false, "AV12pFlightId", StringUtil.LTrimStr( (decimal)(AV12pFlightId), 4, 0));
      }

      public override string getresponse( string sGXDynURL )
      {
         initialize_properties( ) ;
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         sDynURL = sGXDynURL;
         nGotPars = (short)(1);
         nGXWrapped = (short)(1);
         context.SetWrapped(true);
         PA0M2( ) ;
         WS0M2( ) ;
         WE0M2( ) ;
         this.cleanup();
         context.SetWrapped(false);
         context.GX_msglist = BackMsgLst;
         return "";
      }

      public void responsestatic( string sGXDynURL )
      {
      }

      protected void define_styles( )
      {
         AddThemeStyleSheetFile("", context.GetTheme( )+".css", "?"+GetCacheInvalidationToken( ));
         bool outputEnabled = isOutputEnabled( );
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         idxLst = 1;
         while ( idxLst <= Form.Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( ((string)Form.Jscriptsrc.Item(idxLst))), "?202392011562474", true, true);
            idxLst = (int)(idxLst+1);
         }
         if ( ! outputEnabled )
         {
            if ( context.isSpaRequest( ) )
            {
               disableOutput();
            }
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.eng.js", "?"+GetCacheInvalidationToken( ), false, true);
         context.AddJavascriptSource("gx0090.js", "?202392011562475", false, true);
         /* End function include_jscripts */
      }

      protected void SubsflControlProps_742( )
      {
         edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_74_idx;
         edtFlightId_Internalname = "FLIGHTID_"+sGXsfl_74_idx;
         edtFlightArrivalAirportId_Internalname = "FLIGHTARRIVALAIRPORTID_"+sGXsfl_74_idx;
         edtFlightDepartureAirportId_Internalname = "FLIGHTDEPARTUREAIRPORTID_"+sGXsfl_74_idx;
         edtFlightPrice_Internalname = "FLIGHTPRICE_"+sGXsfl_74_idx;
         edtAirlineId_Internalname = "AIRLINEID_"+sGXsfl_74_idx;
         edtFlightDiscountPercentaje_Internalname = "FLIGHTDISCOUNTPERCENTAJE_"+sGXsfl_74_idx;
      }

      protected void SubsflControlProps_fel_742( )
      {
         edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_74_fel_idx;
         edtFlightId_Internalname = "FLIGHTID_"+sGXsfl_74_fel_idx;
         edtFlightArrivalAirportId_Internalname = "FLIGHTARRIVALAIRPORTID_"+sGXsfl_74_fel_idx;
         edtFlightDepartureAirportId_Internalname = "FLIGHTDEPARTUREAIRPORTID_"+sGXsfl_74_fel_idx;
         edtFlightPrice_Internalname = "FLIGHTPRICE_"+sGXsfl_74_fel_idx;
         edtAirlineId_Internalname = "AIRLINEID_"+sGXsfl_74_fel_idx;
         edtFlightDiscountPercentaje_Internalname = "FLIGHTDISCOUNTPERCENTAJE_"+sGXsfl_74_fel_idx;
      }

      protected void sendrow_742( )
      {
         SubsflControlProps_742( ) ;
         WB0M0( ) ;
         if ( ( 10 * 1 == 0 ) || ( nGXsfl_74_idx <= subGrid1_fnc_Recordsperpage( ) * 1 ) )
         {
            Grid1Row = GXWebRow.GetNew(context,Grid1Container);
            if ( subGrid1_Backcolorstyle == 0 )
            {
               /* None style subfile background logic. */
               subGrid1_Backstyle = 0;
               if ( StringUtil.StrCmp(subGrid1_Class, "") != 0 )
               {
                  subGrid1_Linesclass = subGrid1_Class+"Odd";
               }
            }
            else if ( subGrid1_Backcolorstyle == 1 )
            {
               /* Uniform style subfile background logic. */
               subGrid1_Backstyle = 0;
               subGrid1_Backcolor = subGrid1_Allbackcolor;
               if ( StringUtil.StrCmp(subGrid1_Class, "") != 0 )
               {
                  subGrid1_Linesclass = subGrid1_Class+"Uniform";
               }
            }
            else if ( subGrid1_Backcolorstyle == 2 )
            {
               /* Header style subfile background logic. */
               subGrid1_Backstyle = 1;
               if ( StringUtil.StrCmp(subGrid1_Class, "") != 0 )
               {
                  subGrid1_Linesclass = subGrid1_Class+"Odd";
               }
               subGrid1_Backcolor = (int)(0x0);
            }
            else if ( subGrid1_Backcolorstyle == 3 )
            {
               /* Report style subfile background logic. */
               subGrid1_Backstyle = 1;
               if ( ((int)((nGXsfl_74_idx) % (2))) == 0 )
               {
                  subGrid1_Backcolor = (int)(0x0);
                  if ( StringUtil.StrCmp(subGrid1_Class, "") != 0 )
                  {
                     subGrid1_Linesclass = subGrid1_Class+"Even";
                  }
               }
               else
               {
                  subGrid1_Backcolor = (int)(0x0);
                  if ( StringUtil.StrCmp(subGrid1_Class, "") != 0 )
                  {
                     subGrid1_Linesclass = subGrid1_Class+"Odd";
                  }
               }
            }
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<tr ") ;
               context.WriteHtmlText( " class=\""+"PromptGrid"+"\" style=\""+""+"\"") ;
               context.WriteHtmlText( " gxrow=\""+sGXsfl_74_idx+"\">") ;
            }
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+""+"\">") ;
            }
            /* Static Bitmap Variable */
            edtavLinkselection_Link = "javascript:gx.popup.gxReturn(["+"'"+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A19FlightId), 4, 0, ".", "")))+"'"+"]);";
            AssignProp("", false, edtavLinkselection_Internalname, "Link", edtavLinkselection_Link, !bGXsfl_74_Refreshing);
            ClassString = "SelectionAttribute" + " " + ((StringUtil.StrCmp(edtavLinkselection_gximage, "")==0) ? "" : "GX_Image_"+edtavLinkselection_gximage+"_Class");
            StyleString = "";
            AV5LinkSelection_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV5LinkSelection))&&String.IsNullOrEmpty(StringUtil.RTrim( AV14Linkselection_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV5LinkSelection)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( AV5LinkSelection)) ? AV14Linkselection_GXI : context.PathToRelativeUrl( AV5LinkSelection));
            Grid1Row.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(string)edtavLinkselection_Internalname,(string)sImgUrl,(string)edtavLinkselection_Link,(string)"",(string)"",context.GetTheme( ),(short)-1,(short)1,(string)"",(string)"",(short)0,(short)-1,(short)0,(string)"px",(short)0,(string)"px",(short)0,(short)0,(short)0,(string)"",(string)"",(string)StyleString,(string)ClassString,(string)"WWActionColumn",(string)"",(string)"",(string)"",(string)"",(string)"",(string)"",(short)1,(bool)AV5LinkSelection_IsBlob,(bool)false,context.GetImageSrcSet( sImgUrl)});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"end"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            edtFlightId_Link = "javascript:gx.popup.gxReturn(["+"'"+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A19FlightId), 4, 0, ".", "")))+"'"+"]);";
            AssignProp("", false, edtFlightId_Internalname, "Link", edtFlightId_Link, !bGXsfl_74_Refreshing);
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(string)edtFlightId_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A19FlightId), 4, 0, ".", "")),StringUtil.LTrim( context.localUtil.Format( (decimal)(A19FlightId), "ZZZ9")),(string)" dir=\"ltr\" inputmode=\"numeric\" pattern=\"[0-9]*\""+"",(string)"'"+""+"'"+",false,"+"'"+""+"'",(string)edtFlightId_Link,(string)"",(string)"",(string)"",(string)edtFlightId_Jsonclick,(short)0,(string)"Attribute",(string)"",(string)ROClassString,(string)"WWColumn",(string)"",(short)-1,(short)0,(short)0,(string)"text",(string)"1",(short)0,(string)"px",(short)17,(string)"px",(short)4,(short)0,(short)0,(short)74,(short)0,(short)-1,(short)0,(bool)true,(string)"Id",(string)"end",(bool)false,(string)""});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"end"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(string)edtFlightArrivalAirportId_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A25FlightArrivalAirportId), 4, 0, ".", "")),StringUtil.LTrim( context.localUtil.Format( (decimal)(A25FlightArrivalAirportId), "ZZZ9")),(string)" dir=\"ltr\" inputmode=\"numeric\" pattern=\"[0-9]*\""+"",(string)"'"+""+"'"+",false,"+"'"+""+"'",(string)"",(string)"",(string)"",(string)"",(string)edtFlightArrivalAirportId_Jsonclick,(short)0,(string)"Attribute",(string)"",(string)ROClassString,(string)"WWColumn OptionalColumn",(string)"",(short)-1,(short)0,(short)0,(string)"text",(string)"1",(short)0,(string)"px",(short)17,(string)"px",(short)4,(short)0,(short)0,(short)74,(short)0,(short)-1,(short)0,(bool)true,(string)"Id",(string)"end",(bool)false,(string)""});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"end"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(string)edtFlightDepartureAirportId_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A24FlightDepartureAirportId), 4, 0, ".", "")),StringUtil.LTrim( context.localUtil.Format( (decimal)(A24FlightDepartureAirportId), "ZZZ9")),(string)" dir=\"ltr\" inputmode=\"numeric\" pattern=\"[0-9]*\""+"",(string)"'"+""+"'"+",false,"+"'"+""+"'",(string)"",(string)"",(string)"",(string)"",(string)edtFlightDepartureAirportId_Jsonclick,(short)0,(string)"Attribute",(string)"",(string)ROClassString,(string)"WWColumn OptionalColumn",(string)"",(short)-1,(short)0,(short)0,(string)"text",(string)"1",(short)0,(string)"px",(short)17,(string)"px",(short)4,(short)0,(short)0,(short)74,(short)0,(short)-1,(short)0,(bool)true,(string)"Id",(string)"end",(bool)false,(string)""});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"end"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(string)edtFlightPrice_Internalname,StringUtil.LTrim( StringUtil.NToC( A35FlightPrice, 7, 2, ".", "")),StringUtil.LTrim( context.localUtil.Format( A35FlightPrice, "ZZZ9.99")),(string)"",(string)"'"+""+"'"+",false,"+"'"+""+"'",(string)"",(string)"",(string)"",(string)"",(string)edtFlightPrice_Jsonclick,(short)0,(string)"Attribute",(string)"",(string)ROClassString,(string)"WWColumn OptionalColumn",(string)"",(short)-1,(short)0,(short)0,(string)"text",(string)"",(short)0,(string)"px",(short)17,(string)"px",(short)7,(short)0,(short)0,(short)74,(short)0,(short)-1,(short)0,(bool)true,(string)"Price",(string)"end",(bool)false,(string)""});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"end"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(string)edtAirlineId_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A38AirlineId), 4, 0, ".", "")),StringUtil.LTrim( context.localUtil.Format( (decimal)(A38AirlineId), "ZZZ9")),(string)" dir=\"ltr\" inputmode=\"numeric\" pattern=\"[0-9]*\""+"",(string)"'"+""+"'"+",false,"+"'"+""+"'",(string)"",(string)"",(string)"",(string)"",(string)edtAirlineId_Jsonclick,(short)0,(string)"Attribute",(string)"",(string)ROClassString,(string)"WWColumn OptionalColumn",(string)"",(short)-1,(short)0,(short)0,(string)"text",(string)"1",(short)0,(string)"px",(short)17,(string)"px",(short)4,(short)0,(short)0,(short)74,(short)0,(short)-1,(short)0,(bool)true,(string)"Id",(string)"end",(bool)false,(string)""});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"end"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(string)edtFlightDiscountPercentaje_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A36FlightDiscountPercentaje), 4, 0, ".", "")),StringUtil.LTrim( context.localUtil.Format( (decimal)(A36FlightDiscountPercentaje), "ZZZ9")),(string)" dir=\"ltr\" inputmode=\"numeric\" pattern=\"[0-9]*\""+"",(string)"'"+""+"'"+",false,"+"'"+""+"'",(string)"",(string)"",(string)"",(string)"",(string)edtFlightDiscountPercentaje_Jsonclick,(short)0,(string)"Attribute",(string)"",(string)ROClassString,(string)"WWColumn OptionalColumn",(string)"",(short)-1,(short)0,(short)0,(string)"text",(string)"1",(short)0,(string)"px",(short)17,(string)"px",(short)4,(short)0,(short)0,(short)74,(short)0,(short)-1,(short)0,(bool)true,(string)"Percentage",(string)"end",(bool)false,(string)""});
            send_integrity_lvl_hashes0M2( ) ;
            Grid1Container.AddRow(Grid1Row);
            nGXsfl_74_idx = ((subGrid1_Islastpage==1)&&(nGXsfl_74_idx+1>subGrid1_fnc_Recordsperpage( )) ? 1 : nGXsfl_74_idx+1);
            sGXsfl_74_idx = StringUtil.PadL( StringUtil.LTrimStr( (decimal)(nGXsfl_74_idx), 4, 0), 4, "0");
            SubsflControlProps_742( ) ;
         }
         /* End function sendrow_742 */
      }

      protected void init_web_controls( )
      {
         /* End function init_web_controls */
      }

      protected void StartGridControl74( )
      {
         if ( Grid1Container.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<div id=\""+"Grid1Container"+"DivS\" data-gxgridid=\"74\">") ;
            sStyleString = "";
            GxWebStd.gx_table_start( context, subGrid1_Internalname, subGrid1_Internalname, "", "PromptGrid", 0, "", "", 1, 2, sStyleString, "", "", 0);
            /* Subfile titles */
            context.WriteHtmlText( "<tr") ;
            context.WriteHtmlTextNl( ">") ;
            if ( subGrid1_Backcolorstyle == 0 )
            {
               subGrid1_Titlebackstyle = 0;
               if ( StringUtil.Len( subGrid1_Class) > 0 )
               {
                  subGrid1_Linesclass = subGrid1_Class+"Title";
               }
            }
            else
            {
               subGrid1_Titlebackstyle = 1;
               if ( subGrid1_Backcolorstyle == 1 )
               {
                  subGrid1_Titlebackcolor = subGrid1_Allbackcolor;
                  if ( StringUtil.Len( subGrid1_Class) > 0 )
                  {
                     subGrid1_Linesclass = subGrid1_Class+"UniformTitle";
                  }
               }
               else
               {
                  if ( StringUtil.Len( subGrid1_Class) > 0 )
                  {
                     subGrid1_Linesclass = subGrid1_Class+"Title";
                  }
               }
            }
            context.WriteHtmlText( "<th align=\""+""+"\" "+" nowrap=\"nowrap\" "+" class=\""+"SelectionAttribute"+" "+((StringUtil.StrCmp(edtavLinkselection_gximage, "")==0) ? "" : "GX_Image_"+edtavLinkselection_gximage+"_Class")+"\" "+" style=\""+""+""+"\" "+">") ;
            context.SendWebValue( "") ;
            context.WriteHtmlTextNl( "</th>") ;
            context.WriteHtmlText( "<th align=\""+"end"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
            context.SendWebValue( "Id") ;
            context.WriteHtmlTextNl( "</th>") ;
            context.WriteHtmlText( "<th align=\""+"end"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
            context.SendWebValue( "Airport Id") ;
            context.WriteHtmlTextNl( "</th>") ;
            context.WriteHtmlText( "<th align=\""+"end"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
            context.SendWebValue( "Airport Id") ;
            context.WriteHtmlTextNl( "</th>") ;
            context.WriteHtmlText( "<th align=\""+"end"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
            context.SendWebValue( "Price") ;
            context.WriteHtmlTextNl( "</th>") ;
            context.WriteHtmlText( "<th align=\""+"end"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
            context.SendWebValue( "Airline Id") ;
            context.WriteHtmlTextNl( "</th>") ;
            context.WriteHtmlText( "<th align=\""+"end"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
            context.SendWebValue( "Discount Percentaje") ;
            context.WriteHtmlTextNl( "</th>") ;
            context.WriteHtmlTextNl( "</tr>") ;
            Grid1Container.AddObjectProperty("GridName", "Grid1");
         }
         else
         {
            if ( isAjaxCallMode( ) )
            {
               Grid1Container = new GXWebGrid( context);
            }
            else
            {
               Grid1Container.Clear();
            }
            Grid1Container.SetWrapped(nGXWrapped);
            Grid1Container.AddObjectProperty("GridName", "Grid1");
            Grid1Container.AddObjectProperty("Header", subGrid1_Header);
            Grid1Container.AddObjectProperty("Class", "PromptGrid");
            Grid1Container.AddObjectProperty("Cellpadding", StringUtil.LTrim( StringUtil.NToC( (decimal)(1), 4, 0, ".", "")));
            Grid1Container.AddObjectProperty("Cellspacing", StringUtil.LTrim( StringUtil.NToC( (decimal)(2), 4, 0, ".", "")));
            Grid1Container.AddObjectProperty("Backcolorstyle", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Backcolorstyle), 1, 0, ".", "")));
            Grid1Container.AddObjectProperty("CmpContext", "");
            Grid1Container.AddObjectProperty("InMasterPage", "false");
            Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
            Grid1Column.AddObjectProperty("Value", context.convertURL( AV5LinkSelection));
            Grid1Column.AddObjectProperty("Link", StringUtil.RTrim( edtavLinkselection_Link));
            Grid1Container.AddColumnProperties(Grid1Column);
            Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
            Grid1Column.AddObjectProperty("Value", GXUtil.ValueEncode( StringUtil.LTrim( StringUtil.NToC( (decimal)(A19FlightId), 4, 0, ".", ""))));
            Grid1Column.AddObjectProperty("Link", StringUtil.RTrim( edtFlightId_Link));
            Grid1Container.AddColumnProperties(Grid1Column);
            Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
            Grid1Column.AddObjectProperty("Value", GXUtil.ValueEncode( StringUtil.LTrim( StringUtil.NToC( (decimal)(A25FlightArrivalAirportId), 4, 0, ".", ""))));
            Grid1Container.AddColumnProperties(Grid1Column);
            Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
            Grid1Column.AddObjectProperty("Value", GXUtil.ValueEncode( StringUtil.LTrim( StringUtil.NToC( (decimal)(A24FlightDepartureAirportId), 4, 0, ".", ""))));
            Grid1Container.AddColumnProperties(Grid1Column);
            Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
            Grid1Column.AddObjectProperty("Value", GXUtil.ValueEncode( StringUtil.LTrim( StringUtil.NToC( A35FlightPrice, 7, 2, ".", ""))));
            Grid1Container.AddColumnProperties(Grid1Column);
            Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
            Grid1Column.AddObjectProperty("Value", GXUtil.ValueEncode( StringUtil.LTrim( StringUtil.NToC( (decimal)(A38AirlineId), 4, 0, ".", ""))));
            Grid1Container.AddColumnProperties(Grid1Column);
            Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
            Grid1Column.AddObjectProperty("Value", GXUtil.ValueEncode( StringUtil.LTrim( StringUtil.NToC( (decimal)(A36FlightDiscountPercentaje), 4, 0, ".", ""))));
            Grid1Container.AddColumnProperties(Grid1Column);
            Grid1Container.AddObjectProperty("Selectedindex", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Selectedindex), 4, 0, ".", "")));
            Grid1Container.AddObjectProperty("Allowselection", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Allowselection), 1, 0, ".", "")));
            Grid1Container.AddObjectProperty("Selectioncolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Selectioncolor), 9, 0, ".", "")));
            Grid1Container.AddObjectProperty("Allowhover", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Allowhovering), 1, 0, ".", "")));
            Grid1Container.AddObjectProperty("Hovercolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Hoveringcolor), 9, 0, ".", "")));
            Grid1Container.AddObjectProperty("Allowcollapsing", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Allowcollapsing), 1, 0, ".", "")));
            Grid1Container.AddObjectProperty("Collapsed", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Collapsed), 1, 0, ".", "")));
         }
      }

      protected void init_default_properties( )
      {
         lblLblflightidfilter_Internalname = "LBLFLIGHTIDFILTER";
         edtavCflightid_Internalname = "vCFLIGHTID";
         divFlightidfiltercontainer_Internalname = "FLIGHTIDFILTERCONTAINER";
         lblLblflightarrivalairportidfilter_Internalname = "LBLFLIGHTARRIVALAIRPORTIDFILTER";
         edtavCflightarrivalairportid_Internalname = "vCFLIGHTARRIVALAIRPORTID";
         divFlightarrivalairportidfiltercontainer_Internalname = "FLIGHTARRIVALAIRPORTIDFILTERCONTAINER";
         lblLblflightdepartureairportidfilter_Internalname = "LBLFLIGHTDEPARTUREAIRPORTIDFILTER";
         edtavCflightdepartureairportid_Internalname = "vCFLIGHTDEPARTUREAIRPORTID";
         divFlightdepartureairportidfiltercontainer_Internalname = "FLIGHTDEPARTUREAIRPORTIDFILTERCONTAINER";
         lblLblflightpricefilter_Internalname = "LBLFLIGHTPRICEFILTER";
         edtavCflightprice_Internalname = "vCFLIGHTPRICE";
         divFlightpricefiltercontainer_Internalname = "FLIGHTPRICEFILTERCONTAINER";
         lblLblairlineidfilter_Internalname = "LBLAIRLINEIDFILTER";
         edtavCairlineid_Internalname = "vCAIRLINEID";
         divAirlineidfiltercontainer_Internalname = "AIRLINEIDFILTERCONTAINER";
         lblLblflightdiscountpercentajefilter_Internalname = "LBLFLIGHTDISCOUNTPERCENTAJEFILTER";
         edtavCflightdiscountpercentaje_Internalname = "vCFLIGHTDISCOUNTPERCENTAJE";
         divFlightdiscountpercentajefiltercontainer_Internalname = "FLIGHTDISCOUNTPERCENTAJEFILTERCONTAINER";
         divAdvancedcontainer_Internalname = "ADVANCEDCONTAINER";
         bttBtntoggle_Internalname = "BTNTOGGLE";
         edtavLinkselection_Internalname = "vLINKSELECTION";
         edtFlightId_Internalname = "FLIGHTID";
         edtFlightArrivalAirportId_Internalname = "FLIGHTARRIVALAIRPORTID";
         edtFlightDepartureAirportId_Internalname = "FLIGHTDEPARTUREAIRPORTID";
         edtFlightPrice_Internalname = "FLIGHTPRICE";
         edtAirlineId_Internalname = "AIRLINEID";
         edtFlightDiscountPercentaje_Internalname = "FLIGHTDISCOUNTPERCENTAJE";
         bttBtn_cancel_Internalname = "BTN_CANCEL";
         divGridtable_Internalname = "GRIDTABLE";
         divMain_Internalname = "MAIN";
         Form.Internalname = "FORM";
         subGrid1_Internalname = "GRID1";
      }

      public override void initialize_properties( )
      {
         context.SetDefaultTheme("TravelAgency_Capa202309", true);
         if ( context.isSpaRequest( ) )
         {
            disableJsOutput();
         }
         init_default_properties( ) ;
         subGrid1_Allowcollapsing = 0;
         subGrid1_Allowselection = 0;
         subGrid1_Header = "";
         edtFlightDiscountPercentaje_Jsonclick = "";
         edtAirlineId_Jsonclick = "";
         edtFlightPrice_Jsonclick = "";
         edtFlightDepartureAirportId_Jsonclick = "";
         edtFlightArrivalAirportId_Jsonclick = "";
         edtFlightId_Jsonclick = "";
         edtFlightId_Link = "";
         edtavLinkselection_gximage = "";
         edtavLinkselection_Link = "";
         subGrid1_Class = "PromptGrid";
         subGrid1_Backcolorstyle = 0;
         edtavCflightdiscountpercentaje_Jsonclick = "";
         edtavCflightdiscountpercentaje_Enabled = 1;
         edtavCflightdiscountpercentaje_Visible = 1;
         edtavCairlineid_Jsonclick = "";
         edtavCairlineid_Enabled = 1;
         edtavCairlineid_Visible = 1;
         edtavCflightprice_Jsonclick = "";
         edtavCflightprice_Enabled = 1;
         edtavCflightprice_Visible = 1;
         edtavCflightdepartureairportid_Jsonclick = "";
         edtavCflightdepartureairportid_Enabled = 1;
         edtavCflightdepartureairportid_Visible = 1;
         edtavCflightarrivalairportid_Jsonclick = "";
         edtavCflightarrivalairportid_Enabled = 1;
         edtavCflightarrivalairportid_Visible = 1;
         edtavCflightid_Jsonclick = "";
         edtavCflightid_Enabled = 1;
         edtavCflightid_Visible = 1;
         divFlightdiscountpercentajefiltercontainer_Class = "AdvancedContainerItem";
         divAirlineidfiltercontainer_Class = "AdvancedContainerItem";
         divFlightpricefiltercontainer_Class = "AdvancedContainerItem";
         divFlightdepartureairportidfiltercontainer_Class = "AdvancedContainerItem";
         divFlightarrivalairportidfiltercontainer_Class = "AdvancedContainerItem";
         divFlightidfiltercontainer_Class = "AdvancedContainerItem";
         bttBtntoggle_Class = "BtnToggle";
         divAdvancedcontainer_Class = "AdvancedContainerVisible";
         Form.Headerrawhtml = "";
         Form.Background = "";
         Form.Textcolor = 0;
         Form.Backcolor = (int)(0xFFFFFF);
         Form.Caption = "Selection List Flight";
         subGrid1_Rows = 10;
         if ( context.isSpaRequest( ) )
         {
            enableJsOutput();
         }
      }

      public override bool SupportAjaxEvent( )
      {
         return true ;
      }

      public override void InitializeDynEvents( )
      {
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'GRID1_nFirstRecordOnPage'},{av:'GRID1_nEOF'},{av:'subGrid1_Rows',ctrl:'GRID1',prop:'Rows'},{av:'AV6cFlightId',fld:'vCFLIGHTID',pic:'ZZZ9'},{av:'AV7cFlightArrivalAirportId',fld:'vCFLIGHTARRIVALAIRPORTID',pic:'ZZZ9'},{av:'AV8cFlightDepartureAirportId',fld:'vCFLIGHTDEPARTUREAIRPORTID',pic:'ZZZ9'},{av:'AV9cFlightPrice',fld:'vCFLIGHTPRICE',pic:'ZZZ9.99'},{av:'AV10cAirlineId',fld:'vCAIRLINEID',pic:'ZZZ9'},{av:'AV11cFlightDiscountPercentaje',fld:'vCFLIGHTDISCOUNTPERCENTAJE',pic:'ZZZ9'}]");
         setEventMetadata("REFRESH",",oparms:[]}");
         setEventMetadata("'TOGGLE'","{handler:'E170M1',iparms:[{av:'divAdvancedcontainer_Class',ctrl:'ADVANCEDCONTAINER',prop:'Class'},{ctrl:'BTNTOGGLE',prop:'Class'}]");
         setEventMetadata("'TOGGLE'",",oparms:[{av:'divAdvancedcontainer_Class',ctrl:'ADVANCEDCONTAINER',prop:'Class'},{ctrl:'BTNTOGGLE',prop:'Class'}]}");
         setEventMetadata("LBLFLIGHTIDFILTER.CLICK","{handler:'E110M1',iparms:[{av:'divFlightidfiltercontainer_Class',ctrl:'FLIGHTIDFILTERCONTAINER',prop:'Class'}]");
         setEventMetadata("LBLFLIGHTIDFILTER.CLICK",",oparms:[{av:'divFlightidfiltercontainer_Class',ctrl:'FLIGHTIDFILTERCONTAINER',prop:'Class'},{av:'edtavCflightid_Visible',ctrl:'vCFLIGHTID',prop:'Visible'}]}");
         setEventMetadata("LBLFLIGHTARRIVALAIRPORTIDFILTER.CLICK","{handler:'E120M1',iparms:[{av:'divFlightarrivalairportidfiltercontainer_Class',ctrl:'FLIGHTARRIVALAIRPORTIDFILTERCONTAINER',prop:'Class'}]");
         setEventMetadata("LBLFLIGHTARRIVALAIRPORTIDFILTER.CLICK",",oparms:[{av:'divFlightarrivalairportidfiltercontainer_Class',ctrl:'FLIGHTARRIVALAIRPORTIDFILTERCONTAINER',prop:'Class'},{av:'edtavCflightarrivalairportid_Visible',ctrl:'vCFLIGHTARRIVALAIRPORTID',prop:'Visible'}]}");
         setEventMetadata("LBLFLIGHTDEPARTUREAIRPORTIDFILTER.CLICK","{handler:'E130M1',iparms:[{av:'divFlightdepartureairportidfiltercontainer_Class',ctrl:'FLIGHTDEPARTUREAIRPORTIDFILTERCONTAINER',prop:'Class'}]");
         setEventMetadata("LBLFLIGHTDEPARTUREAIRPORTIDFILTER.CLICK",",oparms:[{av:'divFlightdepartureairportidfiltercontainer_Class',ctrl:'FLIGHTDEPARTUREAIRPORTIDFILTERCONTAINER',prop:'Class'},{av:'edtavCflightdepartureairportid_Visible',ctrl:'vCFLIGHTDEPARTUREAIRPORTID',prop:'Visible'}]}");
         setEventMetadata("LBLFLIGHTPRICEFILTER.CLICK","{handler:'E140M1',iparms:[{av:'divFlightpricefiltercontainer_Class',ctrl:'FLIGHTPRICEFILTERCONTAINER',prop:'Class'}]");
         setEventMetadata("LBLFLIGHTPRICEFILTER.CLICK",",oparms:[{av:'divFlightpricefiltercontainer_Class',ctrl:'FLIGHTPRICEFILTERCONTAINER',prop:'Class'},{av:'edtavCflightprice_Visible',ctrl:'vCFLIGHTPRICE',prop:'Visible'}]}");
         setEventMetadata("LBLAIRLINEIDFILTER.CLICK","{handler:'E150M1',iparms:[{av:'divAirlineidfiltercontainer_Class',ctrl:'AIRLINEIDFILTERCONTAINER',prop:'Class'}]");
         setEventMetadata("LBLAIRLINEIDFILTER.CLICK",",oparms:[{av:'divAirlineidfiltercontainer_Class',ctrl:'AIRLINEIDFILTERCONTAINER',prop:'Class'},{av:'edtavCairlineid_Visible',ctrl:'vCAIRLINEID',prop:'Visible'}]}");
         setEventMetadata("LBLFLIGHTDISCOUNTPERCENTAJEFILTER.CLICK","{handler:'E160M1',iparms:[{av:'divFlightdiscountpercentajefiltercontainer_Class',ctrl:'FLIGHTDISCOUNTPERCENTAJEFILTERCONTAINER',prop:'Class'}]");
         setEventMetadata("LBLFLIGHTDISCOUNTPERCENTAJEFILTER.CLICK",",oparms:[{av:'divFlightdiscountpercentajefiltercontainer_Class',ctrl:'FLIGHTDISCOUNTPERCENTAJEFILTERCONTAINER',prop:'Class'},{av:'edtavCflightdiscountpercentaje_Visible',ctrl:'vCFLIGHTDISCOUNTPERCENTAJE',prop:'Visible'}]}");
         setEventMetadata("ENTER","{handler:'E200M2',iparms:[{av:'A19FlightId',fld:'FLIGHTID',pic:'ZZZ9',hsh:true}]");
         setEventMetadata("ENTER",",oparms:[{av:'AV12pFlightId',fld:'vPFLIGHTID',pic:'ZZZ9'}]}");
         setEventMetadata("GRID1_FIRSTPAGE","{handler:'subgrid1_firstpage',iparms:[{av:'GRID1_nFirstRecordOnPage'},{av:'GRID1_nEOF'},{av:'subGrid1_Rows',ctrl:'GRID1',prop:'Rows'},{av:'AV6cFlightId',fld:'vCFLIGHTID',pic:'ZZZ9'},{av:'AV7cFlightArrivalAirportId',fld:'vCFLIGHTARRIVALAIRPORTID',pic:'ZZZ9'},{av:'AV8cFlightDepartureAirportId',fld:'vCFLIGHTDEPARTUREAIRPORTID',pic:'ZZZ9'},{av:'AV9cFlightPrice',fld:'vCFLIGHTPRICE',pic:'ZZZ9.99'},{av:'AV10cAirlineId',fld:'vCAIRLINEID',pic:'ZZZ9'},{av:'AV11cFlightDiscountPercentaje',fld:'vCFLIGHTDISCOUNTPERCENTAJE',pic:'ZZZ9'}]");
         setEventMetadata("GRID1_FIRSTPAGE",",oparms:[]}");
         setEventMetadata("GRID1_PREVPAGE","{handler:'subgrid1_previouspage',iparms:[{av:'GRID1_nFirstRecordOnPage'},{av:'GRID1_nEOF'},{av:'subGrid1_Rows',ctrl:'GRID1',prop:'Rows'},{av:'AV6cFlightId',fld:'vCFLIGHTID',pic:'ZZZ9'},{av:'AV7cFlightArrivalAirportId',fld:'vCFLIGHTARRIVALAIRPORTID',pic:'ZZZ9'},{av:'AV8cFlightDepartureAirportId',fld:'vCFLIGHTDEPARTUREAIRPORTID',pic:'ZZZ9'},{av:'AV9cFlightPrice',fld:'vCFLIGHTPRICE',pic:'ZZZ9.99'},{av:'AV10cAirlineId',fld:'vCAIRLINEID',pic:'ZZZ9'},{av:'AV11cFlightDiscountPercentaje',fld:'vCFLIGHTDISCOUNTPERCENTAJE',pic:'ZZZ9'}]");
         setEventMetadata("GRID1_PREVPAGE",",oparms:[]}");
         setEventMetadata("GRID1_NEXTPAGE","{handler:'subgrid1_nextpage',iparms:[{av:'GRID1_nFirstRecordOnPage'},{av:'GRID1_nEOF'},{av:'subGrid1_Rows',ctrl:'GRID1',prop:'Rows'},{av:'AV6cFlightId',fld:'vCFLIGHTID',pic:'ZZZ9'},{av:'AV7cFlightArrivalAirportId',fld:'vCFLIGHTARRIVALAIRPORTID',pic:'ZZZ9'},{av:'AV8cFlightDepartureAirportId',fld:'vCFLIGHTDEPARTUREAIRPORTID',pic:'ZZZ9'},{av:'AV9cFlightPrice',fld:'vCFLIGHTPRICE',pic:'ZZZ9.99'},{av:'AV10cAirlineId',fld:'vCAIRLINEID',pic:'ZZZ9'},{av:'AV11cFlightDiscountPercentaje',fld:'vCFLIGHTDISCOUNTPERCENTAJE',pic:'ZZZ9'}]");
         setEventMetadata("GRID1_NEXTPAGE",",oparms:[]}");
         setEventMetadata("GRID1_LASTPAGE","{handler:'subgrid1_lastpage',iparms:[{av:'GRID1_nFirstRecordOnPage'},{av:'GRID1_nEOF'},{av:'subGrid1_Rows',ctrl:'GRID1',prop:'Rows'},{av:'AV6cFlightId',fld:'vCFLIGHTID',pic:'ZZZ9'},{av:'AV7cFlightArrivalAirportId',fld:'vCFLIGHTARRIVALAIRPORTID',pic:'ZZZ9'},{av:'AV8cFlightDepartureAirportId',fld:'vCFLIGHTDEPARTUREAIRPORTID',pic:'ZZZ9'},{av:'AV9cFlightPrice',fld:'vCFLIGHTPRICE',pic:'ZZZ9.99'},{av:'AV10cAirlineId',fld:'vCAIRLINEID',pic:'ZZZ9'},{av:'AV11cFlightDiscountPercentaje',fld:'vCFLIGHTDISCOUNTPERCENTAJE',pic:'ZZZ9'}]");
         setEventMetadata("GRID1_LASTPAGE",",oparms:[]}");
         setEventMetadata("NULL","{handler:'Valid_Flightdiscountpercentaje',iparms:[]");
         setEventMetadata("NULL",",oparms:[]}");
         return  ;
      }

      public override void cleanup( )
      {
         flushBuffer();
         CloseOpenCursors();
         if ( IsMain )
         {
            context.CloseConnections();
         }
      }

      protected void CloseOpenCursors( )
      {
      }

      public override void initialize( )
      {
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         GXKey = "";
         GX_FocusControl = "";
         Form = new GXWebForm();
         sPrefix = "";
         lblLblflightidfilter_Jsonclick = "";
         TempTags = "";
         lblLblflightarrivalairportidfilter_Jsonclick = "";
         lblLblflightdepartureairportidfilter_Jsonclick = "";
         lblLblflightpricefilter_Jsonclick = "";
         lblLblairlineidfilter_Jsonclick = "";
         lblLblflightdiscountpercentajefilter_Jsonclick = "";
         ClassString = "";
         StyleString = "";
         bttBtntoggle_Jsonclick = "";
         Grid1Container = new GXWebGrid( context);
         sStyleString = "";
         bttBtn_cancel_Jsonclick = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV5LinkSelection = "";
         AV14Linkselection_GXI = "";
         scmdbuf = "";
         H000M2_A36FlightDiscountPercentaje = new short[1] ;
         H000M2_A38AirlineId = new short[1] ;
         H000M2_n38AirlineId = new bool[] {false} ;
         H000M2_A35FlightPrice = new decimal[1] ;
         H000M2_A24FlightDepartureAirportId = new short[1] ;
         H000M2_A25FlightArrivalAirportId = new short[1] ;
         H000M2_A19FlightId = new short[1] ;
         H000M3_AGRID1_nRecordCount = new long[1] ;
         AV13ADVANCED_LABEL_TEMPLATE = "";
         Grid1Row = new GXWebRow();
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         subGrid1_Linesclass = "";
         sImgUrl = "";
         ROClassString = "";
         Grid1Column = new GXWebColumn();
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.gx0090__default(),
            new Object[][] {
                new Object[] {
               H000M2_A36FlightDiscountPercentaje, H000M2_A38AirlineId, H000M2_n38AirlineId, H000M2_A35FlightPrice, H000M2_A24FlightDepartureAirportId, H000M2_A25FlightArrivalAirportId, H000M2_A19FlightId
               }
               , new Object[] {
               H000M3_AGRID1_nRecordCount
               }
            }
         );
         /* GeneXus formulas. */
      }

      private short AV12pFlightId ;
      private short GRID1_nEOF ;
      private short nGotPars ;
      private short GxWebError ;
      private short AV6cFlightId ;
      private short AV7cFlightArrivalAirportId ;
      private short AV8cFlightDepartureAirportId ;
      private short AV10cAirlineId ;
      private short AV11cFlightDiscountPercentaje ;
      private short initialized ;
      private short gxajaxcallmode ;
      private short wbEnd ;
      private short wbStart ;
      private short A19FlightId ;
      private short A25FlightArrivalAirportId ;
      private short A24FlightDepartureAirportId ;
      private short A38AirlineId ;
      private short A36FlightDiscountPercentaje ;
      private short nDonePA ;
      private short gxcookieaux ;
      private short subGrid1_Backcolorstyle ;
      private short nGXWrapped ;
      private short subGrid1_Backstyle ;
      private short subGrid1_Titlebackstyle ;
      private short subGrid1_Allowselection ;
      private short subGrid1_Allowhovering ;
      private short subGrid1_Allowcollapsing ;
      private short subGrid1_Collapsed ;
      private int nRC_GXsfl_74 ;
      private int subGrid1_Rows ;
      private int nGXsfl_74_idx=1 ;
      private int edtavCflightid_Enabled ;
      private int edtavCflightid_Visible ;
      private int edtavCflightarrivalairportid_Enabled ;
      private int edtavCflightarrivalairportid_Visible ;
      private int edtavCflightdepartureairportid_Enabled ;
      private int edtavCflightdepartureairportid_Visible ;
      private int edtavCflightprice_Enabled ;
      private int edtavCflightprice_Visible ;
      private int edtavCairlineid_Enabled ;
      private int edtavCairlineid_Visible ;
      private int edtavCflightdiscountpercentaje_Enabled ;
      private int edtavCflightdiscountpercentaje_Visible ;
      private int subGrid1_Islastpage ;
      private int GXPagingFrom2 ;
      private int GXPagingTo2 ;
      private int idxLst ;
      private int subGrid1_Backcolor ;
      private int subGrid1_Allbackcolor ;
      private int subGrid1_Titlebackcolor ;
      private int subGrid1_Selectedindex ;
      private int subGrid1_Selectioncolor ;
      private int subGrid1_Hoveringcolor ;
      private long GRID1_nFirstRecordOnPage ;
      private long GRID1_nCurrentRecord ;
      private long GRID1_nRecordCount ;
      private decimal AV9cFlightPrice ;
      private decimal A35FlightPrice ;
      private string divAdvancedcontainer_Class ;
      private string bttBtntoggle_Class ;
      private string divFlightidfiltercontainer_Class ;
      private string divFlightarrivalairportidfiltercontainer_Class ;
      private string divFlightdepartureairportidfiltercontainer_Class ;
      private string divFlightpricefiltercontainer_Class ;
      private string divAirlineidfiltercontainer_Class ;
      private string divFlightdiscountpercentajefiltercontainer_Class ;
      private string gxfirstwebparm ;
      private string gxfirstwebparm_bkp ;
      private string sGXsfl_74_idx="0001" ;
      private string sDynURL ;
      private string FormProcess ;
      private string bodyStyle ;
      private string GXKey ;
      private string GX_FocusControl ;
      private string sPrefix ;
      private string divMain_Internalname ;
      private string divAdvancedcontainer_Internalname ;
      private string divFlightidfiltercontainer_Internalname ;
      private string lblLblflightidfilter_Internalname ;
      private string lblLblflightidfilter_Jsonclick ;
      private string edtavCflightid_Internalname ;
      private string TempTags ;
      private string edtavCflightid_Jsonclick ;
      private string divFlightarrivalairportidfiltercontainer_Internalname ;
      private string lblLblflightarrivalairportidfilter_Internalname ;
      private string lblLblflightarrivalairportidfilter_Jsonclick ;
      private string edtavCflightarrivalairportid_Internalname ;
      private string edtavCflightarrivalairportid_Jsonclick ;
      private string divFlightdepartureairportidfiltercontainer_Internalname ;
      private string lblLblflightdepartureairportidfilter_Internalname ;
      private string lblLblflightdepartureairportidfilter_Jsonclick ;
      private string edtavCflightdepartureairportid_Internalname ;
      private string edtavCflightdepartureairportid_Jsonclick ;
      private string divFlightpricefiltercontainer_Internalname ;
      private string lblLblflightpricefilter_Internalname ;
      private string lblLblflightpricefilter_Jsonclick ;
      private string edtavCflightprice_Internalname ;
      private string edtavCflightprice_Jsonclick ;
      private string divAirlineidfiltercontainer_Internalname ;
      private string lblLblairlineidfilter_Internalname ;
      private string lblLblairlineidfilter_Jsonclick ;
      private string edtavCairlineid_Internalname ;
      private string edtavCairlineid_Jsonclick ;
      private string divFlightdiscountpercentajefiltercontainer_Internalname ;
      private string lblLblflightdiscountpercentajefilter_Internalname ;
      private string lblLblflightdiscountpercentajefilter_Jsonclick ;
      private string edtavCflightdiscountpercentaje_Internalname ;
      private string edtavCflightdiscountpercentaje_Jsonclick ;
      private string divGridtable_Internalname ;
      private string ClassString ;
      private string StyleString ;
      private string bttBtntoggle_Internalname ;
      private string bttBtntoggle_Jsonclick ;
      private string sStyleString ;
      private string subGrid1_Internalname ;
      private string bttBtn_cancel_Internalname ;
      private string bttBtn_cancel_Jsonclick ;
      private string sEvt ;
      private string EvtGridId ;
      private string EvtRowId ;
      private string sEvtType ;
      private string edtavLinkselection_Internalname ;
      private string edtFlightId_Internalname ;
      private string edtFlightArrivalAirportId_Internalname ;
      private string edtFlightDepartureAirportId_Internalname ;
      private string edtFlightPrice_Internalname ;
      private string edtAirlineId_Internalname ;
      private string edtFlightDiscountPercentaje_Internalname ;
      private string scmdbuf ;
      private string AV13ADVANCED_LABEL_TEMPLATE ;
      private string edtavLinkselection_gximage ;
      private string sGXsfl_74_fel_idx="0001" ;
      private string subGrid1_Class ;
      private string subGrid1_Linesclass ;
      private string edtavLinkselection_Link ;
      private string sImgUrl ;
      private string ROClassString ;
      private string edtFlightId_Link ;
      private string edtFlightId_Jsonclick ;
      private string edtFlightArrivalAirportId_Jsonclick ;
      private string edtFlightDepartureAirportId_Jsonclick ;
      private string edtFlightPrice_Jsonclick ;
      private string edtAirlineId_Jsonclick ;
      private string edtFlightDiscountPercentaje_Jsonclick ;
      private string subGrid1_Header ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool bGXsfl_74_Refreshing=false ;
      private bool n38AirlineId ;
      private bool gxdyncontrolsrefreshing ;
      private bool returnInSub ;
      private bool AV5LinkSelection_IsBlob ;
      private string AV14Linkselection_GXI ;
      private string AV5LinkSelection ;
      private GXWebGrid Grid1Container ;
      private GXWebRow Grid1Row ;
      private GXWebColumn Grid1Column ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private short[] H000M2_A36FlightDiscountPercentaje ;
      private short[] H000M2_A38AirlineId ;
      private bool[] H000M2_n38AirlineId ;
      private decimal[] H000M2_A35FlightPrice ;
      private short[] H000M2_A24FlightDepartureAirportId ;
      private short[] H000M2_A25FlightArrivalAirportId ;
      private short[] H000M2_A19FlightId ;
      private long[] H000M3_AGRID1_nRecordCount ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private short aP0_pFlightId ;
      private GXWebForm Form ;
   }

   public class gx0090__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_H000M2( IGxContext context ,
                                             short AV7cFlightArrivalAirportId ,
                                             short AV8cFlightDepartureAirportId ,
                                             decimal AV9cFlightPrice ,
                                             short AV10cAirlineId ,
                                             short AV11cFlightDiscountPercentaje ,
                                             short A25FlightArrivalAirportId ,
                                             short A24FlightDepartureAirportId ,
                                             decimal A35FlightPrice ,
                                             short A38AirlineId ,
                                             short A36FlightDiscountPercentaje ,
                                             short AV6cFlightId )
      {
         System.Text.StringBuilder sWhereString = new System.Text.StringBuilder();
         string scmdbuf;
         short[] GXv_int1 = new short[9];
         Object[] GXv_Object2 = new Object[2];
         string sSelectString;
         string sFromString;
         string sOrderString;
         sSelectString = " [FlightDiscountPercentaje], [AirlineId], [FlightPrice], [FlightDepartureAirportId], [FlightArrivalAirportId], [FlightId]";
         sFromString = " FROM [Flight]";
         sOrderString = "";
         AddWhere(sWhereString, "([FlightId] >= @AV6cFlightId)");
         if ( ! (0==AV7cFlightArrivalAirportId) )
         {
            AddWhere(sWhereString, "([FlightArrivalAirportId] >= @AV7cFlightArrivalAirportId)");
         }
         else
         {
            GXv_int1[1] = 1;
         }
         if ( ! (0==AV8cFlightDepartureAirportId) )
         {
            AddWhere(sWhereString, "([FlightDepartureAirportId] >= @AV8cFlightDepartureAirportId)");
         }
         else
         {
            GXv_int1[2] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV9cFlightPrice) )
         {
            AddWhere(sWhereString, "([FlightPrice] >= @AV9cFlightPrice)");
         }
         else
         {
            GXv_int1[3] = 1;
         }
         if ( ! (0==AV10cAirlineId) )
         {
            AddWhere(sWhereString, "([AirlineId] >= @AV10cAirlineId)");
         }
         else
         {
            GXv_int1[4] = 1;
         }
         if ( ! (0==AV11cFlightDiscountPercentaje) )
         {
            AddWhere(sWhereString, "([FlightDiscountPercentaje] >= @AV11cFlightDiscountPercentaje)");
         }
         else
         {
            GXv_int1[5] = 1;
         }
         sOrderString += " ORDER BY [FlightId]";
         scmdbuf = "SELECT " + sSelectString + sFromString + sWhereString + sOrderString + "" + " OFFSET " + "@GXPagingFrom2" + " ROWS FETCH NEXT CAST((SELECT CASE WHEN " + "@GXPagingTo2" + " > 0 THEN " + "@GXPagingTo2" + " ELSE 1e9 END) AS INTEGER) ROWS ONLY";
         GXv_Object2[0] = scmdbuf;
         GXv_Object2[1] = GXv_int1;
         return GXv_Object2 ;
      }

      protected Object[] conditional_H000M3( IGxContext context ,
                                             short AV7cFlightArrivalAirportId ,
                                             short AV8cFlightDepartureAirportId ,
                                             decimal AV9cFlightPrice ,
                                             short AV10cAirlineId ,
                                             short AV11cFlightDiscountPercentaje ,
                                             short A25FlightArrivalAirportId ,
                                             short A24FlightDepartureAirportId ,
                                             decimal A35FlightPrice ,
                                             short A38AirlineId ,
                                             short A36FlightDiscountPercentaje ,
                                             short AV6cFlightId )
      {
         System.Text.StringBuilder sWhereString = new System.Text.StringBuilder();
         string scmdbuf;
         short[] GXv_int3 = new short[6];
         Object[] GXv_Object4 = new Object[2];
         scmdbuf = "SELECT COUNT(*) FROM [Flight]";
         AddWhere(sWhereString, "([FlightId] >= @AV6cFlightId)");
         if ( ! (0==AV7cFlightArrivalAirportId) )
         {
            AddWhere(sWhereString, "([FlightArrivalAirportId] >= @AV7cFlightArrivalAirportId)");
         }
         else
         {
            GXv_int3[1] = 1;
         }
         if ( ! (0==AV8cFlightDepartureAirportId) )
         {
            AddWhere(sWhereString, "([FlightDepartureAirportId] >= @AV8cFlightDepartureAirportId)");
         }
         else
         {
            GXv_int3[2] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV9cFlightPrice) )
         {
            AddWhere(sWhereString, "([FlightPrice] >= @AV9cFlightPrice)");
         }
         else
         {
            GXv_int3[3] = 1;
         }
         if ( ! (0==AV10cAirlineId) )
         {
            AddWhere(sWhereString, "([AirlineId] >= @AV10cAirlineId)");
         }
         else
         {
            GXv_int3[4] = 1;
         }
         if ( ! (0==AV11cFlightDiscountPercentaje) )
         {
            AddWhere(sWhereString, "([FlightDiscountPercentaje] >= @AV11cFlightDiscountPercentaje)");
         }
         else
         {
            GXv_int3[5] = 1;
         }
         scmdbuf += sWhereString;
         GXv_Object4[0] = scmdbuf;
         GXv_Object4[1] = GXv_int3;
         return GXv_Object4 ;
      }

      public override Object [] getDynamicStatement( int cursor ,
                                                     IGxContext context ,
                                                     Object [] dynConstraints )
      {
         switch ( cursor )
         {
               case 0 :
                     return conditional_H000M2(context, (short)dynConstraints[0] , (short)dynConstraints[1] , (decimal)dynConstraints[2] , (short)dynConstraints[3] , (short)dynConstraints[4] , (short)dynConstraints[5] , (short)dynConstraints[6] , (decimal)dynConstraints[7] , (short)dynConstraints[8] , (short)dynConstraints[9] , (short)dynConstraints[10] );
               case 1 :
                     return conditional_H000M3(context, (short)dynConstraints[0] , (short)dynConstraints[1] , (decimal)dynConstraints[2] , (short)dynConstraints[3] , (short)dynConstraints[4] , (short)dynConstraints[5] , (short)dynConstraints[6] , (decimal)dynConstraints[7] , (short)dynConstraints[8] , (short)dynConstraints[9] , (short)dynConstraints[10] );
         }
         return base.getDynamicStatement(cursor, context, dynConstraints);
      }

      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
         ,new ForEachCursor(def[1])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmH000M2;
          prmH000M2 = new Object[] {
          new ParDef("@AV6cFlightId",GXType.Int16,4,0) ,
          new ParDef("@AV7cFlightArrivalAirportId",GXType.Int16,4,0) ,
          new ParDef("@AV8cFlightDepartureAirportId",GXType.Int16,4,0) ,
          new ParDef("@AV9cFlightPrice",GXType.Decimal,7,2) ,
          new ParDef("@AV10cAirlineId",GXType.Int16,4,0) ,
          new ParDef("@AV11cFlightDiscountPercentaje",GXType.Int16,4,0) ,
          new ParDef("@GXPagingFrom2",GXType.Int32,9,0) ,
          new ParDef("@GXPagingTo2",GXType.Int32,9,0) ,
          new ParDef("@GXPagingTo2",GXType.Int32,9,0)
          };
          Object[] prmH000M3;
          prmH000M3 = new Object[] {
          new ParDef("@AV6cFlightId",GXType.Int16,4,0) ,
          new ParDef("@AV7cFlightArrivalAirportId",GXType.Int16,4,0) ,
          new ParDef("@AV8cFlightDepartureAirportId",GXType.Int16,4,0) ,
          new ParDef("@AV9cFlightPrice",GXType.Decimal,7,2) ,
          new ParDef("@AV10cAirlineId",GXType.Int16,4,0) ,
          new ParDef("@AV11cFlightDiscountPercentaje",GXType.Int16,4,0)
          };
          def= new CursorDef[] {
              new CursorDef("H000M2", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH000M2,11, GxCacheFrequency.OFF ,false,false )
             ,new CursorDef("H000M3", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH000M3,1, GxCacheFrequency.OFF ,false,false )
          };
       }
    }

    public void getResults( int cursor ,
                            IFieldGetter rslt ,
                            Object[] buf )
    {
       switch ( cursor )
       {
             case 0 :
                ((short[]) buf[0])[0] = rslt.getShort(1);
                ((short[]) buf[1])[0] = rslt.getShort(2);
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((decimal[]) buf[3])[0] = rslt.getDecimal(3);
                ((short[]) buf[4])[0] = rslt.getShort(4);
                ((short[]) buf[5])[0] = rslt.getShort(5);
                ((short[]) buf[6])[0] = rslt.getShort(6);
                return;
             case 1 :
                ((long[]) buf[0])[0] = rslt.getLong(1);
                return;
       }
    }

 }

}
