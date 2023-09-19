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
   public class flight : GXDataArea
   {
      protected void INITENV( )
      {
         if ( GxWebError != 0 )
         {
            return  ;
         }
      }

      protected void INITTRN( )
      {
         initialize_properties( ) ;
         entryPointCalled = false;
         gxfirstwebparm = GetNextPar( );
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
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_2") == 0 )
         {
            A25FlightArrivalAirportId = (short)(Math.Round(NumberUtil.Val( GetPar( "FlightArrivalAirportId"), "."), 18, MidpointRounding.ToEven));
            AssignAttri("", false, "A25FlightArrivalAirportId", StringUtil.LTrimStr( (decimal)(A25FlightArrivalAirportId), 4, 0));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxLoad_2( A25FlightArrivalAirportId) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_4") == 0 )
         {
            A31FlightArrivalCountryId = (short)(Math.Round(NumberUtil.Val( GetPar( "FlightArrivalCountryId"), "."), 18, MidpointRounding.ToEven));
            AssignAttri("", false, "A31FlightArrivalCountryId", StringUtil.LTrimStr( (decimal)(A31FlightArrivalCountryId), 4, 0));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxLoad_4( A31FlightArrivalCountryId) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_5") == 0 )
         {
            A31FlightArrivalCountryId = (short)(Math.Round(NumberUtil.Val( GetPar( "FlightArrivalCountryId"), "."), 18, MidpointRounding.ToEven));
            AssignAttri("", false, "A31FlightArrivalCountryId", StringUtil.LTrimStr( (decimal)(A31FlightArrivalCountryId), 4, 0));
            A33FlightArrivalCityId = (short)(Math.Round(NumberUtil.Val( GetPar( "FlightArrivalCityId"), "."), 18, MidpointRounding.ToEven));
            AssignAttri("", false, "A33FlightArrivalCityId", StringUtil.LTrimStr( (decimal)(A33FlightArrivalCityId), 4, 0));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxLoad_5( A31FlightArrivalCountryId, A33FlightArrivalCityId) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_3") == 0 )
         {
            A24FlightDepartureAirportId = (short)(Math.Round(NumberUtil.Val( GetPar( "FlightDepartureAirportId"), "."), 18, MidpointRounding.ToEven));
            AssignAttri("", false, "A24FlightDepartureAirportId", StringUtil.LTrimStr( (decimal)(A24FlightDepartureAirportId), 4, 0));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxLoad_3( A24FlightDepartureAirportId) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_6") == 0 )
         {
            A27FlightDepartureCountryId = (short)(Math.Round(NumberUtil.Val( GetPar( "FlightDepartureCountryId"), "."), 18, MidpointRounding.ToEven));
            AssignAttri("", false, "A27FlightDepartureCountryId", StringUtil.LTrimStr( (decimal)(A27FlightDepartureCountryId), 4, 0));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxLoad_6( A27FlightDepartureCountryId) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_7") == 0 )
         {
            A27FlightDepartureCountryId = (short)(Math.Round(NumberUtil.Val( GetPar( "FlightDepartureCountryId"), "."), 18, MidpointRounding.ToEven));
            AssignAttri("", false, "A27FlightDepartureCountryId", StringUtil.LTrimStr( (decimal)(A27FlightDepartureCountryId), 4, 0));
            A29FlightDepartureCityId = (short)(Math.Round(NumberUtil.Val( GetPar( "FlightDepartureCityId"), "."), 18, MidpointRounding.ToEven));
            AssignAttri("", false, "A29FlightDepartureCityId", StringUtil.LTrimStr( (decimal)(A29FlightDepartureCityId), 4, 0));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxLoad_7( A27FlightDepartureCountryId, A29FlightDepartureCityId) ;
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
            gxfirstwebparm = GetNextPar( );
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxfullajaxEvt") == 0 )
         {
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxfirstwebparm = GetNextPar( );
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
         if ( toggleJsOutput )
         {
            if ( context.isSpaRequest( ) )
            {
               enableJsOutput();
            }
         }
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
         if ( ! context.isSpaRequest( ) )
         {
            if ( context.ExposeMetadata( ) )
            {
               Form.Meta.addItem("generator", "GeneXus .NET 18_0_4-174187", 0) ;
            }
            Form.Meta.addItem("description", "Flight", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         if ( ! context.isAjaxRequest( ) )
         {
            GX_FocusControl = edtFlightId_Internalname;
            AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         }
         wbErr = false;
         context.SetDefaultTheme("TravelAgency_Capa202309", true);
         if ( ! context.IsLocalStorageSupported( ) )
         {
            context.PushCurrentUrl();
         }
      }

      public flight( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("TravelAgency_Capa202309", true);
      }

      public flight( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void execute( )
      {
         executePrivate();
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      protected override void createObjects( )
      {
      }

      public override void webExecute( )
      {
         if ( initialized == 0 )
         {
            createObjects();
            initialize();
         }
         INITENV( ) ;
         INITTRN( ) ;
         if ( ( GxWebError == 0 ) && ! isAjaxCallMode( ) )
         {
            MasterPageObj = (GXMasterPage) ClassLoader.GetInstance("general.ui.masterunanimosidebar", "GeneXus.Programs.general.ui.masterunanimosidebar", new Object[] {context});
            MasterPageObj.setDataArea(this,false);
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

      protected void fix_multi_value_controls( )
      {
      }

      protected void Draw( )
      {
         if ( context.isAjaxRequest( ) )
         {
            disableOutput();
         }
         if ( ! GxWebStd.gx_redirect( context) )
         {
            disable_std_buttons( ) ;
            enableDisable( ) ;
            set_caption( ) ;
            /* Form start */
            DrawControls( ) ;
            fix_multi_value_controls( ) ;
         }
         /* Execute Exit event if defined. */
      }

      protected void DrawControls( )
      {
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "Section", "start", "top", " "+"data-gx-base-lib=\"none\""+" "+"data-abstract-form"+" ", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, divMaintable_Internalname, 1, 0, "px", 0, "px", "Table", "start", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "start", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "start", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, divTitlecontainer_Internalname, 1, 0, "px", 0, "px", "title-container", "start", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "start", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "start", "top", "", "", "div");
         /* Text block */
         GxWebStd.gx_label_ctrl( context, lblTitle_Internalname, "Flight", "", "", lblTitle_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "heading-01", 0, "", 1, 1, 0, 0, "HLP_Flight.htm");
         GxWebStd.gx_div_end( context, "start", "top", "div");
         GxWebStd.gx_div_end( context, "start", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "start", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "start", "top", "", "", "div");
         ClassString = "ErrorViewer";
         StyleString = "";
         GxWebStd.gx_msg_list( context, "", context.GX_msglist.DisplayMode, StyleString, ClassString, "", "false");
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
         GxWebStd.gx_div_start( context, divFormcontainer_Internalname, 1, 0, "px", 0, "px", "form-container", "start", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "start", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, divToolbarcell_Internalname, 1, 0, "px", 0, "px", "col-xs-12 col-sm-9 col-sm-offset-3 form__toolbar-cell", "start", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-action-group ActionGroup", "start", "top", " "+"data-gx-actiongroup-type=\"toolbar\""+" ", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "btn-group", "start", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "start", "top", "", "", "div");
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 21,'',false,'',0)\"";
         ClassString = "Button button-auxiliary ico__arrow-first";
         StyleString = "";
         GxWebStd.gx_button_ctrl( context, bttBtn_first_Internalname, "", "", bttBtn_first_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_first_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"EFIRST."+"'", TempTags, "", context.GetButtonType( ), "HLP_Flight.htm");
         GxWebStd.gx_div_end( context, "start", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "start", "top", "", "", "div");
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 23,'',false,'',0)\"";
         ClassString = "Button button-auxiliary ico__arrow-prev";
         StyleString = "";
         GxWebStd.gx_button_ctrl( context, bttBtn_previous_Internalname, "", "", bttBtn_previous_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_previous_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"EPREVIOUS."+"'", TempTags, "", context.GetButtonType( ), "HLP_Flight.htm");
         GxWebStd.gx_div_end( context, "start", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "start", "top", "", "", "div");
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 25,'',false,'',0)\"";
         ClassString = "Button button-auxiliary ico__arrow-next";
         StyleString = "";
         GxWebStd.gx_button_ctrl( context, bttBtn_next_Internalname, "", "", bttBtn_next_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_next_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ENEXT."+"'", TempTags, "", context.GetButtonType( ), "HLP_Flight.htm");
         GxWebStd.gx_div_end( context, "start", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "start", "top", "", "", "div");
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 27,'',false,'',0)\"";
         ClassString = "Button button-auxiliary ico__arrow-last";
         StyleString = "";
         GxWebStd.gx_button_ctrl( context, bttBtn_last_Internalname, "", "", bttBtn_last_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_last_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ELAST."+"'", TempTags, "", context.GetButtonType( ), "HLP_Flight.htm");
         GxWebStd.gx_div_end( context, "start", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "start", "top", "", "", "div");
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 29,'',false,'',0)\"";
         ClassString = "Button button-secondary";
         StyleString = "";
         GxWebStd.gx_button_ctrl( context, bttBtn_select_Internalname, "", "Select", bttBtn_select_Jsonclick, 4, "Select", "", StyleString, ClassString, bttBtn_select_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ESELECT."+"'", TempTags, "gx.popup.openPrompt('"+"gx0060.aspx"+"',["+"{Ctrl:gx.dom.el('"+"FLIGHTID"+"'), id:'"+"FLIGHTID"+"'"+",IOType:'out',isKey:true,isLastKey:true}"+"],"+"null"+","+"'', false"+","+"true"+");"+"return false;", 2, "HLP_Flight.htm");
         GxWebStd.gx_div_end( context, "start", "top", "div");
         GxWebStd.gx_div_end( context, "start", "top", "div");
         GxWebStd.gx_div_end( context, "start", "top", "div");
         GxWebStd.gx_div_end( context, "start", "top", "div");
         GxWebStd.gx_div_end( context, "start", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "start", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 form__cell-advanced", "start", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "start", "top", ""+" data-gx-for=\""+edtFlightId_Internalname+"\"", "", "div");
         /* Attribute/Variable Label */
         GxWebStd.gx_label_element( context, edtFlightId_Internalname, "Id", "col-sm-3 AttributeLabel", 1, true, "");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "start", "top", "", "", "div");
         /* Single line edit */
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 34,'',false,'',0)\"";
         GxWebStd.gx_single_line_edit( context, edtFlightId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A19FlightId), 4, 0, ".", "")), StringUtil.LTrim( ((edtFlightId_Enabled!=0) ? context.localUtil.Format( (decimal)(A19FlightId), "ZZZ9") : context.localUtil.Format( (decimal)(A19FlightId), "ZZZ9"))), " dir=\"ltr\" inputmode=\"numeric\" pattern=\"[0-9]*\""+TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(this,34);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtFlightId_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtFlightId_Enabled, 0, "text", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 0, -1, 0, true, "Id", "end", false, "", "HLP_Flight.htm");
         GxWebStd.gx_div_end( context, "start", "top", "div");
         GxWebStd.gx_div_end( context, "start", "top", "div");
         GxWebStd.gx_div_end( context, "start", "top", "div");
         GxWebStd.gx_div_end( context, "start", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "start", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 form__cell", "start", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "start", "top", ""+" data-gx-for=\""+edtFlightArrivalAirportId_Internalname+"\"", "", "div");
         /* Attribute/Variable Label */
         GxWebStd.gx_label_element( context, edtFlightArrivalAirportId_Internalname, "Airport Id", "col-sm-3 AttributeLabel", 1, true, "");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "start", "top", "", "", "div");
         /* Single line edit */
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 39,'',false,'',0)\"";
         GxWebStd.gx_single_line_edit( context, edtFlightArrivalAirportId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A25FlightArrivalAirportId), 4, 0, ".", "")), StringUtil.LTrim( ((edtFlightArrivalAirportId_Enabled!=0) ? context.localUtil.Format( (decimal)(A25FlightArrivalAirportId), "ZZZ9") : context.localUtil.Format( (decimal)(A25FlightArrivalAirportId), "ZZZ9"))), " dir=\"ltr\" inputmode=\"numeric\" pattern=\"[0-9]*\""+TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(this,39);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtFlightArrivalAirportId_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtFlightArrivalAirportId_Enabled, 0, "text", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 0, -1, 0, true, "Id", "end", false, "", "HLP_Flight.htm");
         /* Static images/pictures */
         ClassString = "gx-prompt Image" + " " + ((StringUtil.StrCmp(imgprompt_25_gximage, "")==0) ? "" : "GX_Image_"+imgprompt_25_gximage+"_Class");
         StyleString = "";
         sImgUrl = (string)(context.GetImagePath( "prompt.gif", "", context.GetTheme( )));
         GxWebStd.gx_bitmap( context, imgprompt_25_Internalname, sImgUrl, imgprompt_25_Link, "", "", context.GetTheme( ), imgprompt_25_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "", "", "", "", "", 1, false, false, context.GetImageSrcSet( sImgUrl), "HLP_Flight.htm");
         GxWebStd.gx_div_end( context, "start", "top", "div");
         GxWebStd.gx_div_end( context, "start", "top", "div");
         GxWebStd.gx_div_end( context, "start", "top", "div");
         GxWebStd.gx_div_end( context, "start", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "start", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 form__cell", "start", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "start", "top", ""+" data-gx-for=\""+edtFlightArrivalAirportName_Internalname+"\"", "", "div");
         /* Attribute/Variable Label */
         GxWebStd.gx_label_element( context, edtFlightArrivalAirportName_Internalname, "Airport Name", "col-sm-3 AttributeLabel", 1, true, "");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "start", "top", "", "", "div");
         /* Single line edit */
         GxWebStd.gx_single_line_edit( context, edtFlightArrivalAirportName_Internalname, A26FlightArrivalAirportName, StringUtil.RTrim( context.localUtil.Format( A26FlightArrivalAirportName, "")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtFlightArrivalAirportName_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtFlightArrivalAirportName_Enabled, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 0, -1, -1, true, "Name", "start", true, "", "HLP_Flight.htm");
         GxWebStd.gx_div_end( context, "start", "top", "div");
         GxWebStd.gx_div_end( context, "start", "top", "div");
         GxWebStd.gx_div_end( context, "start", "top", "div");
         GxWebStd.gx_div_end( context, "start", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "start", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 form__cell", "start", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "start", "top", ""+" data-gx-for=\""+edtFlightArrivalCountryId_Internalname+"\"", "", "div");
         /* Attribute/Variable Label */
         GxWebStd.gx_label_element( context, edtFlightArrivalCountryId_Internalname, "Country Id", "col-sm-3 AttributeLabel", 1, true, "");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "start", "top", "", "", "div");
         /* Single line edit */
         GxWebStd.gx_single_line_edit( context, edtFlightArrivalCountryId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A31FlightArrivalCountryId), 4, 0, ".", "")), StringUtil.LTrim( ((edtFlightArrivalCountryId_Enabled!=0) ? context.localUtil.Format( (decimal)(A31FlightArrivalCountryId), "ZZZ9") : context.localUtil.Format( (decimal)(A31FlightArrivalCountryId), "ZZZ9"))), " dir=\"ltr\" inputmode=\"numeric\" pattern=\"[0-9]*\""+"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtFlightArrivalCountryId_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtFlightArrivalCountryId_Enabled, 0, "text", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 0, -1, 0, true, "Id", "end", false, "", "HLP_Flight.htm");
         GxWebStd.gx_div_end( context, "start", "top", "div");
         GxWebStd.gx_div_end( context, "start", "top", "div");
         GxWebStd.gx_div_end( context, "start", "top", "div");
         GxWebStd.gx_div_end( context, "start", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "start", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 form__cell", "start", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "start", "top", ""+" data-gx-for=\""+edtFlightArrivalCountryName_Internalname+"\"", "", "div");
         /* Attribute/Variable Label */
         GxWebStd.gx_label_element( context, edtFlightArrivalCountryName_Internalname, "Country Name", "col-sm-3 AttributeLabel", 1, true, "");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "start", "top", "", "", "div");
         /* Single line edit */
         GxWebStd.gx_single_line_edit( context, edtFlightArrivalCountryName_Internalname, A32FlightArrivalCountryName, StringUtil.RTrim( context.localUtil.Format( A32FlightArrivalCountryName, "")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtFlightArrivalCountryName_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtFlightArrivalCountryName_Enabled, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 0, -1, -1, true, "Name", "start", true, "", "HLP_Flight.htm");
         GxWebStd.gx_div_end( context, "start", "top", "div");
         GxWebStd.gx_div_end( context, "start", "top", "div");
         GxWebStd.gx_div_end( context, "start", "top", "div");
         GxWebStd.gx_div_end( context, "start", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "start", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 form__cell", "start", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "start", "top", ""+" data-gx-for=\""+edtFlightArrivalCityId_Internalname+"\"", "", "div");
         /* Attribute/Variable Label */
         GxWebStd.gx_label_element( context, edtFlightArrivalCityId_Internalname, "City Id", "col-sm-3 AttributeLabel", 1, true, "");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "start", "top", "", "", "div");
         /* Single line edit */
         GxWebStd.gx_single_line_edit( context, edtFlightArrivalCityId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A33FlightArrivalCityId), 4, 0, ".", "")), StringUtil.LTrim( ((edtFlightArrivalCityId_Enabled!=0) ? context.localUtil.Format( (decimal)(A33FlightArrivalCityId), "ZZZ9") : context.localUtil.Format( (decimal)(A33FlightArrivalCityId), "ZZZ9"))), " dir=\"ltr\" inputmode=\"numeric\" pattern=\"[0-9]*\""+"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtFlightArrivalCityId_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtFlightArrivalCityId_Enabled, 0, "text", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 0, -1, 0, true, "Id", "end", false, "", "HLP_Flight.htm");
         GxWebStd.gx_div_end( context, "start", "top", "div");
         GxWebStd.gx_div_end( context, "start", "top", "div");
         GxWebStd.gx_div_end( context, "start", "top", "div");
         GxWebStd.gx_div_end( context, "start", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "start", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 form__cell", "start", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "start", "top", ""+" data-gx-for=\""+edtFlightArrivalCityName_Internalname+"\"", "", "div");
         /* Attribute/Variable Label */
         GxWebStd.gx_label_element( context, edtFlightArrivalCityName_Internalname, "City Name", "col-sm-3 AttributeLabel", 1, true, "");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "start", "top", "", "", "div");
         /* Single line edit */
         GxWebStd.gx_single_line_edit( context, edtFlightArrivalCityName_Internalname, A34FlightArrivalCityName, StringUtil.RTrim( context.localUtil.Format( A34FlightArrivalCityName, "")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtFlightArrivalCityName_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtFlightArrivalCityName_Enabled, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 0, -1, -1, true, "Name", "start", true, "", "HLP_Flight.htm");
         GxWebStd.gx_div_end( context, "start", "top", "div");
         GxWebStd.gx_div_end( context, "start", "top", "div");
         GxWebStd.gx_div_end( context, "start", "top", "div");
         GxWebStd.gx_div_end( context, "start", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "start", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 form__cell", "start", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "start", "top", ""+" data-gx-for=\""+edtFlightDepartureAirportId_Internalname+"\"", "", "div");
         /* Attribute/Variable Label */
         GxWebStd.gx_label_element( context, edtFlightDepartureAirportId_Internalname, "Airport Id", "col-sm-3 AttributeLabel", 1, true, "");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "start", "top", "", "", "div");
         /* Single line edit */
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 69,'',false,'',0)\"";
         GxWebStd.gx_single_line_edit( context, edtFlightDepartureAirportId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A24FlightDepartureAirportId), 4, 0, ".", "")), StringUtil.LTrim( ((edtFlightDepartureAirportId_Enabled!=0) ? context.localUtil.Format( (decimal)(A24FlightDepartureAirportId), "ZZZ9") : context.localUtil.Format( (decimal)(A24FlightDepartureAirportId), "ZZZ9"))), " dir=\"ltr\" inputmode=\"numeric\" pattern=\"[0-9]*\""+TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(this,69);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtFlightDepartureAirportId_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtFlightDepartureAirportId_Enabled, 0, "text", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 0, -1, 0, true, "Id", "end", false, "", "HLP_Flight.htm");
         /* Static images/pictures */
         ClassString = "gx-prompt Image" + " " + ((StringUtil.StrCmp(imgprompt_24_gximage, "")==0) ? "" : "GX_Image_"+imgprompt_24_gximage+"_Class");
         StyleString = "";
         sImgUrl = (string)(context.GetImagePath( "prompt.gif", "", context.GetTheme( )));
         GxWebStd.gx_bitmap( context, imgprompt_24_Internalname, sImgUrl, imgprompt_24_Link, "", "", context.GetTheme( ), imgprompt_24_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "", "", "", "", "", 1, false, false, context.GetImageSrcSet( sImgUrl), "HLP_Flight.htm");
         GxWebStd.gx_div_end( context, "start", "top", "div");
         GxWebStd.gx_div_end( context, "start", "top", "div");
         GxWebStd.gx_div_end( context, "start", "top", "div");
         GxWebStd.gx_div_end( context, "start", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "start", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 form__cell", "start", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "start", "top", ""+" data-gx-for=\""+edtFlightDepartureAirportName_Internalname+"\"", "", "div");
         /* Attribute/Variable Label */
         GxWebStd.gx_label_element( context, edtFlightDepartureAirportName_Internalname, "Airport Name", "col-sm-3 AttributeLabel", 1, true, "");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "start", "top", "", "", "div");
         /* Single line edit */
         GxWebStd.gx_single_line_edit( context, edtFlightDepartureAirportName_Internalname, A23FlightDepartureAirportName, StringUtil.RTrim( context.localUtil.Format( A23FlightDepartureAirportName, "")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtFlightDepartureAirportName_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtFlightDepartureAirportName_Enabled, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 0, -1, -1, true, "Name", "start", true, "", "HLP_Flight.htm");
         GxWebStd.gx_div_end( context, "start", "top", "div");
         GxWebStd.gx_div_end( context, "start", "top", "div");
         GxWebStd.gx_div_end( context, "start", "top", "div");
         GxWebStd.gx_div_end( context, "start", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "start", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 form__cell", "start", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "start", "top", ""+" data-gx-for=\""+edtFlightDepartureCountryId_Internalname+"\"", "", "div");
         /* Attribute/Variable Label */
         GxWebStd.gx_label_element( context, edtFlightDepartureCountryId_Internalname, "Deaperture Country Id", "col-sm-3 AttributeLabel", 1, true, "");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "start", "top", "", "", "div");
         /* Single line edit */
         GxWebStd.gx_single_line_edit( context, edtFlightDepartureCountryId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A27FlightDepartureCountryId), 4, 0, ".", "")), StringUtil.LTrim( ((edtFlightDepartureCountryId_Enabled!=0) ? context.localUtil.Format( (decimal)(A27FlightDepartureCountryId), "ZZZ9") : context.localUtil.Format( (decimal)(A27FlightDepartureCountryId), "ZZZ9"))), " dir=\"ltr\" inputmode=\"numeric\" pattern=\"[0-9]*\""+"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtFlightDepartureCountryId_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtFlightDepartureCountryId_Enabled, 0, "text", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 0, -1, 0, true, "Id", "end", false, "", "HLP_Flight.htm");
         GxWebStd.gx_div_end( context, "start", "top", "div");
         GxWebStd.gx_div_end( context, "start", "top", "div");
         GxWebStd.gx_div_end( context, "start", "top", "div");
         GxWebStd.gx_div_end( context, "start", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "start", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 form__cell", "start", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "start", "top", ""+" data-gx-for=\""+edtFlightDepartureCountryName_Internalname+"\"", "", "div");
         /* Attribute/Variable Label */
         GxWebStd.gx_label_element( context, edtFlightDepartureCountryName_Internalname, "Deaperture Country Name", "col-sm-3 AttributeLabel", 1, true, "");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "start", "top", "", "", "div");
         /* Single line edit */
         GxWebStd.gx_single_line_edit( context, edtFlightDepartureCountryName_Internalname, A28FlightDepartureCountryName, StringUtil.RTrim( context.localUtil.Format( A28FlightDepartureCountryName, "")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtFlightDepartureCountryName_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtFlightDepartureCountryName_Enabled, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 0, -1, -1, true, "Name", "start", true, "", "HLP_Flight.htm");
         GxWebStd.gx_div_end( context, "start", "top", "div");
         GxWebStd.gx_div_end( context, "start", "top", "div");
         GxWebStd.gx_div_end( context, "start", "top", "div");
         GxWebStd.gx_div_end( context, "start", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "start", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 form__cell", "start", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "start", "top", ""+" data-gx-for=\""+edtFlightDepartureCityId_Internalname+"\"", "", "div");
         /* Attribute/Variable Label */
         GxWebStd.gx_label_element( context, edtFlightDepartureCityId_Internalname, "Deaperture City Id", "col-sm-3 AttributeLabel", 1, true, "");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "start", "top", "", "", "div");
         /* Single line edit */
         GxWebStd.gx_single_line_edit( context, edtFlightDepartureCityId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A29FlightDepartureCityId), 4, 0, ".", "")), StringUtil.LTrim( ((edtFlightDepartureCityId_Enabled!=0) ? context.localUtil.Format( (decimal)(A29FlightDepartureCityId), "ZZZ9") : context.localUtil.Format( (decimal)(A29FlightDepartureCityId), "ZZZ9"))), " dir=\"ltr\" inputmode=\"numeric\" pattern=\"[0-9]*\""+"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtFlightDepartureCityId_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtFlightDepartureCityId_Enabled, 0, "text", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 0, -1, 0, true, "Id", "end", false, "", "HLP_Flight.htm");
         GxWebStd.gx_div_end( context, "start", "top", "div");
         GxWebStd.gx_div_end( context, "start", "top", "div");
         GxWebStd.gx_div_end( context, "start", "top", "div");
         GxWebStd.gx_div_end( context, "start", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "start", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 form__cell", "start", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "start", "top", ""+" data-gx-for=\""+edtFlightDepartureCityName_Internalname+"\"", "", "div");
         /* Attribute/Variable Label */
         GxWebStd.gx_label_element( context, edtFlightDepartureCityName_Internalname, "Deaperture City Name", "col-sm-3 AttributeLabel", 1, true, "");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "start", "top", "", "", "div");
         /* Single line edit */
         GxWebStd.gx_single_line_edit( context, edtFlightDepartureCityName_Internalname, A30FlightDepartureCityName, StringUtil.RTrim( context.localUtil.Format( A30FlightDepartureCityName, "")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtFlightDepartureCityName_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtFlightDepartureCityName_Enabled, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 0, -1, -1, true, "Name", "start", true, "", "HLP_Flight.htm");
         GxWebStd.gx_div_end( context, "start", "top", "div");
         GxWebStd.gx_div_end( context, "start", "top", "div");
         GxWebStd.gx_div_end( context, "start", "top", "div");
         GxWebStd.gx_div_end( context, "start", "top", "div");
         GxWebStd.gx_div_end( context, "start", "top", "div");
         GxWebStd.gx_div_end( context, "start", "top", "div");
         GxWebStd.gx_div_end( context, "start", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "start", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 form__actions--fixed", "end", "Middle", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-action-group", "start", "top", " "+"data-gx-actiongroup-type=\"toolbar\""+" ", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "start", "top", "", "", "div");
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 99,'',false,'',0)\"";
         ClassString = "Button button-primary";
         StyleString = "";
         GxWebStd.gx_button_ctrl( context, bttBtn_enter_Internalname, "", "Confirm", bttBtn_enter_Jsonclick, 5, "Confirm", "", StyleString, ClassString, bttBtn_enter_Visible, bttBtn_enter_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EENTER."+"'", TempTags, "", context.GetButtonType( ), "HLP_Flight.htm");
         GxWebStd.gx_div_end( context, "start", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "start", "top", "", "", "div");
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 101,'',false,'',0)\"";
         ClassString = "Button button-tertiary";
         StyleString = "";
         GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "", "Cancel", bttBtn_cancel_Jsonclick, 1, "Cancel", "", StyleString, ClassString, bttBtn_cancel_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_Flight.htm");
         GxWebStd.gx_div_end( context, "start", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "start", "top", "", "", "div");
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 103,'',false,'',0)\"";
         ClassString = "Button button-tertiary";
         StyleString = "";
         GxWebStd.gx_button_ctrl( context, bttBtn_delete_Internalname, "", "Delete", bttBtn_delete_Jsonclick, 5, "Delete", "", StyleString, ClassString, bttBtn_delete_Visible, bttBtn_delete_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EDELETE."+"'", TempTags, "", context.GetButtonType( ), "HLP_Flight.htm");
         GxWebStd.gx_div_end( context, "start", "top", "div");
         GxWebStd.gx_div_end( context, "start", "top", "div");
         GxWebStd.gx_div_end( context, "end", "Middle", "div");
         GxWebStd.gx_div_end( context, "start", "top", "div");
         GxWebStd.gx_div_end( context, "start", "top", "div");
         GxWebStd.gx_div_end( context, "start", "top", "div");
      }

      protected void UserMain( )
      {
         standaloneStartup( ) ;
      }

      protected void UserMainFullajax( )
      {
         INITENV( ) ;
         INITTRN( ) ;
         UserMain( ) ;
         Draw( ) ;
         SendCloseFormHiddens( ) ;
      }

      protected void standaloneStartup( )
      {
         standaloneStartupServer( ) ;
         disable_std_buttons( ) ;
         enableDisable( ) ;
         Process( ) ;
      }

      protected void standaloneStartupServer( )
      {
         context.wbGlbDoneStart = 1;
         assign_properties_default( ) ;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            /* Read saved values. */
            Z19FlightId = (short)(Math.Round(context.localUtil.CToN( cgiGet( "Z19FlightId"), ".", ","), 18, MidpointRounding.ToEven));
            Z25FlightArrivalAirportId = (short)(Math.Round(context.localUtil.CToN( cgiGet( "Z25FlightArrivalAirportId"), ".", ","), 18, MidpointRounding.ToEven));
            Z24FlightDepartureAirportId = (short)(Math.Round(context.localUtil.CToN( cgiGet( "Z24FlightDepartureAirportId"), ".", ","), 18, MidpointRounding.ToEven));
            IsConfirmed = (short)(Math.Round(context.localUtil.CToN( cgiGet( "IsConfirmed"), ".", ","), 18, MidpointRounding.ToEven));
            IsModified = (short)(Math.Round(context.localUtil.CToN( cgiGet( "IsModified"), ".", ","), 18, MidpointRounding.ToEven));
            Gx_mode = cgiGet( "Mode");
            /* Read variables values. */
            if ( ( ( context.localUtil.CToN( cgiGet( edtFlightId_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtFlightId_Internalname), ".", ",") > Convert.ToDecimal( 9999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "FLIGHTID");
               AnyError = 1;
               GX_FocusControl = edtFlightId_Internalname;
               AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               A19FlightId = 0;
               AssignAttri("", false, "A19FlightId", StringUtil.LTrimStr( (decimal)(A19FlightId), 4, 0));
            }
            else
            {
               A19FlightId = (short)(Math.Round(context.localUtil.CToN( cgiGet( edtFlightId_Internalname), ".", ","), 18, MidpointRounding.ToEven));
               AssignAttri("", false, "A19FlightId", StringUtil.LTrimStr( (decimal)(A19FlightId), 4, 0));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtFlightArrivalAirportId_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtFlightArrivalAirportId_Internalname), ".", ",") > Convert.ToDecimal( 9999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "FLIGHTARRIVALAIRPORTID");
               AnyError = 1;
               GX_FocusControl = edtFlightArrivalAirportId_Internalname;
               AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               A25FlightArrivalAirportId = 0;
               AssignAttri("", false, "A25FlightArrivalAirportId", StringUtil.LTrimStr( (decimal)(A25FlightArrivalAirportId), 4, 0));
            }
            else
            {
               A25FlightArrivalAirportId = (short)(Math.Round(context.localUtil.CToN( cgiGet( edtFlightArrivalAirportId_Internalname), ".", ","), 18, MidpointRounding.ToEven));
               AssignAttri("", false, "A25FlightArrivalAirportId", StringUtil.LTrimStr( (decimal)(A25FlightArrivalAirportId), 4, 0));
            }
            A26FlightArrivalAirportName = cgiGet( edtFlightArrivalAirportName_Internalname);
            AssignAttri("", false, "A26FlightArrivalAirportName", A26FlightArrivalAirportName);
            A31FlightArrivalCountryId = (short)(Math.Round(context.localUtil.CToN( cgiGet( edtFlightArrivalCountryId_Internalname), ".", ","), 18, MidpointRounding.ToEven));
            AssignAttri("", false, "A31FlightArrivalCountryId", StringUtil.LTrimStr( (decimal)(A31FlightArrivalCountryId), 4, 0));
            A32FlightArrivalCountryName = cgiGet( edtFlightArrivalCountryName_Internalname);
            AssignAttri("", false, "A32FlightArrivalCountryName", A32FlightArrivalCountryName);
            A33FlightArrivalCityId = (short)(Math.Round(context.localUtil.CToN( cgiGet( edtFlightArrivalCityId_Internalname), ".", ","), 18, MidpointRounding.ToEven));
            AssignAttri("", false, "A33FlightArrivalCityId", StringUtil.LTrimStr( (decimal)(A33FlightArrivalCityId), 4, 0));
            A34FlightArrivalCityName = cgiGet( edtFlightArrivalCityName_Internalname);
            AssignAttri("", false, "A34FlightArrivalCityName", A34FlightArrivalCityName);
            if ( ( ( context.localUtil.CToN( cgiGet( edtFlightDepartureAirportId_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtFlightDepartureAirportId_Internalname), ".", ",") > Convert.ToDecimal( 9999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "FLIGHTDEPARTUREAIRPORTID");
               AnyError = 1;
               GX_FocusControl = edtFlightDepartureAirportId_Internalname;
               AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               A24FlightDepartureAirportId = 0;
               AssignAttri("", false, "A24FlightDepartureAirportId", StringUtil.LTrimStr( (decimal)(A24FlightDepartureAirportId), 4, 0));
            }
            else
            {
               A24FlightDepartureAirportId = (short)(Math.Round(context.localUtil.CToN( cgiGet( edtFlightDepartureAirportId_Internalname), ".", ","), 18, MidpointRounding.ToEven));
               AssignAttri("", false, "A24FlightDepartureAirportId", StringUtil.LTrimStr( (decimal)(A24FlightDepartureAirportId), 4, 0));
            }
            A23FlightDepartureAirportName = cgiGet( edtFlightDepartureAirportName_Internalname);
            AssignAttri("", false, "A23FlightDepartureAirportName", A23FlightDepartureAirportName);
            A27FlightDepartureCountryId = (short)(Math.Round(context.localUtil.CToN( cgiGet( edtFlightDepartureCountryId_Internalname), ".", ","), 18, MidpointRounding.ToEven));
            AssignAttri("", false, "A27FlightDepartureCountryId", StringUtil.LTrimStr( (decimal)(A27FlightDepartureCountryId), 4, 0));
            A28FlightDepartureCountryName = cgiGet( edtFlightDepartureCountryName_Internalname);
            AssignAttri("", false, "A28FlightDepartureCountryName", A28FlightDepartureCountryName);
            A29FlightDepartureCityId = (short)(Math.Round(context.localUtil.CToN( cgiGet( edtFlightDepartureCityId_Internalname), ".", ","), 18, MidpointRounding.ToEven));
            AssignAttri("", false, "A29FlightDepartureCityId", StringUtil.LTrimStr( (decimal)(A29FlightDepartureCityId), 4, 0));
            A30FlightDepartureCityName = cgiGet( edtFlightDepartureCityName_Internalname);
            AssignAttri("", false, "A30FlightDepartureCityName", A30FlightDepartureCityName);
            /* Read subfile selected row values. */
            /* Read hidden variables. */
            GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
            standaloneNotModal( ) ;
         }
         else
         {
            standaloneNotModal( ) ;
            if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") == 0 )
            {
               Gx_mode = "DSP";
               AssignAttri("", false, "Gx_mode", Gx_mode);
               A19FlightId = (short)(Math.Round(NumberUtil.Val( GetPar( "FlightId"), "."), 18, MidpointRounding.ToEven));
               AssignAttri("", false, "A19FlightId", StringUtil.LTrimStr( (decimal)(A19FlightId), 4, 0));
               getEqualNoModal( ) ;
               Gx_mode = "DSP";
               AssignAttri("", false, "Gx_mode", Gx_mode);
               disable_std_buttons_dsp( ) ;
               standaloneModal( ) ;
            }
            else
            {
               Gx_mode = "INS";
               AssignAttri("", false, "Gx_mode", Gx_mode);
               standaloneModal( ) ;
            }
         }
      }

      protected void Process( )
      {
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read Transaction buttons. */
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
                        if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                        {
                           context.wbHandled = 1;
                           btn_enter( ) ;
                           /* No code required for Cancel button. It is implemented as the Reset button. */
                        }
                        else if ( StringUtil.StrCmp(sEvt, "FIRST") == 0 )
                        {
                           context.wbHandled = 1;
                           btn_first( ) ;
                        }
                        else if ( StringUtil.StrCmp(sEvt, "PREVIOUS") == 0 )
                        {
                           context.wbHandled = 1;
                           btn_previous( ) ;
                        }
                        else if ( StringUtil.StrCmp(sEvt, "NEXT") == 0 )
                        {
                           context.wbHandled = 1;
                           btn_next( ) ;
                        }
                        else if ( StringUtil.StrCmp(sEvt, "LAST") == 0 )
                        {
                           context.wbHandled = 1;
                           btn_last( ) ;
                        }
                        else if ( StringUtil.StrCmp(sEvt, "SELECT") == 0 )
                        {
                           context.wbHandled = 1;
                           btn_select( ) ;
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DELETE") == 0 )
                        {
                           context.wbHandled = 1;
                           btn_delete( ) ;
                        }
                        else if ( StringUtil.StrCmp(sEvt, "LSCR") == 0 )
                        {
                           context.wbHandled = 1;
                           AfterKeyLoadScreen( ) ;
                        }
                     }
                     else
                     {
                     }
                  }
                  context.wbHandled = 1;
               }
            }
         }
      }

      protected void AfterTrn( )
      {
         if ( trnEnded == 1 )
         {
            if ( ! String.IsNullOrEmpty(StringUtil.RTrim( endTrnMsgTxt)) )
            {
               GX_msglist.addItem(endTrnMsgTxt, endTrnMsgCod, 0, "", true);
            }
            trnEnded = 0;
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            if ( IsIns( )  )
            {
               /* Clear variables for new insertion. */
               InitAll056( ) ;
               standaloneNotModal( ) ;
               standaloneModal( ) ;
            }
         }
         endTrnMsgTxt = "";
      }

      public override string ToString( )
      {
         return "" ;
      }

      public GxContentInfo GetContentInfo( )
      {
         return (GxContentInfo)(null) ;
      }

      protected void disable_std_buttons( )
      {
         if ( IsIns( ) )
         {
            bttBtn_delete_Enabled = 0;
            AssignProp("", false, bttBtn_delete_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(bttBtn_delete_Enabled), 5, 0), true);
         }
      }

      protected void disable_std_buttons_dsp( )
      {
         bttBtn_delete_Visible = 0;
         AssignProp("", false, bttBtn_delete_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(bttBtn_delete_Visible), 5, 0), true);
         bttBtn_first_Visible = 0;
         AssignProp("", false, bttBtn_first_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(bttBtn_first_Visible), 5, 0), true);
         bttBtn_previous_Visible = 0;
         AssignProp("", false, bttBtn_previous_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(bttBtn_previous_Visible), 5, 0), true);
         bttBtn_next_Visible = 0;
         AssignProp("", false, bttBtn_next_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(bttBtn_next_Visible), 5, 0), true);
         bttBtn_last_Visible = 0;
         AssignProp("", false, bttBtn_last_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(bttBtn_last_Visible), 5, 0), true);
         bttBtn_select_Visible = 0;
         AssignProp("", false, bttBtn_select_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(bttBtn_select_Visible), 5, 0), true);
         bttBtn_delete_Visible = 0;
         AssignProp("", false, bttBtn_delete_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(bttBtn_delete_Visible), 5, 0), true);
         if ( IsDsp( ) )
         {
            bttBtn_enter_Visible = 0;
            AssignProp("", false, bttBtn_enter_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(bttBtn_enter_Visible), 5, 0), true);
         }
         DisableAttributes056( ) ;
      }

      protected void set_caption( )
      {
         if ( ( IsConfirmed == 1 ) && ( AnyError == 0 ) )
         {
            if ( IsDlt( ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_confdelete", ""), 0, "", true);
            }
            else
            {
               GX_msglist.addItem(context.GetMessage( "GXM_mustconfirm", ""), 0, "", true);
            }
         }
      }

      protected void ResetCaption050( )
      {
      }

      protected void ZM056( short GX_JID )
      {
         if ( ( GX_JID == 1 ) || ( GX_JID == 0 ) )
         {
            if ( ! IsIns( ) )
            {
               Z25FlightArrivalAirportId = T00053_A25FlightArrivalAirportId[0];
               Z24FlightDepartureAirportId = T00053_A24FlightDepartureAirportId[0];
            }
            else
            {
               Z25FlightArrivalAirportId = A25FlightArrivalAirportId;
               Z24FlightDepartureAirportId = A24FlightDepartureAirportId;
            }
         }
         if ( GX_JID == -1 )
         {
            Z19FlightId = A19FlightId;
            Z25FlightArrivalAirportId = A25FlightArrivalAirportId;
            Z24FlightDepartureAirportId = A24FlightDepartureAirportId;
            Z26FlightArrivalAirportName = A26FlightArrivalAirportName;
            Z31FlightArrivalCountryId = A31FlightArrivalCountryId;
            Z33FlightArrivalCityId = A33FlightArrivalCityId;
            Z32FlightArrivalCountryName = A32FlightArrivalCountryName;
            Z34FlightArrivalCityName = A34FlightArrivalCityName;
            Z23FlightDepartureAirportName = A23FlightDepartureAirportName;
            Z27FlightDepartureCountryId = A27FlightDepartureCountryId;
            Z29FlightDepartureCityId = A29FlightDepartureCityId;
            Z28FlightDepartureCountryName = A28FlightDepartureCountryName;
            Z30FlightDepartureCityName = A30FlightDepartureCityName;
         }
      }

      protected void standaloneNotModal( )
      {
         imgprompt_25_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx0070.aspx"+"',["+"{Ctrl:gx.dom.el('"+"FLIGHTARRIVALAIRPORTID"+"'), id:'"+"FLIGHTARRIVALAIRPORTID"+"'"+",IOType:'out'}"+"],"+"null"+","+"'', false"+","+"false"+");");
         imgprompt_24_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx0070.aspx"+"',["+"{Ctrl:gx.dom.el('"+"FLIGHTDEPARTUREAIRPORTID"+"'), id:'"+"FLIGHTDEPARTUREAIRPORTID"+"'"+",IOType:'out'}"+"],"+"null"+","+"'', false"+","+"false"+");");
      }

      protected void standaloneModal( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            bttBtn_delete_Enabled = 0;
            AssignProp("", false, bttBtn_delete_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(bttBtn_delete_Enabled), 5, 0), true);
         }
         else
         {
            bttBtn_delete_Enabled = 1;
            AssignProp("", false, bttBtn_delete_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(bttBtn_delete_Enabled), 5, 0), true);
         }
         if ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 )
         {
            bttBtn_enter_Enabled = 0;
            AssignProp("", false, bttBtn_enter_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(bttBtn_enter_Enabled), 5, 0), true);
         }
         else
         {
            bttBtn_enter_Enabled = 1;
            AssignProp("", false, bttBtn_enter_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(bttBtn_enter_Enabled), 5, 0), true);
         }
      }

      protected void Load056( )
      {
         /* Using cursor T000510 */
         pr_default.execute(8, new Object[] {A19FlightId});
         if ( (pr_default.getStatus(8) != 101) )
         {
            RcdFound6 = 1;
            A26FlightArrivalAirportName = T000510_A26FlightArrivalAirportName[0];
            AssignAttri("", false, "A26FlightArrivalAirportName", A26FlightArrivalAirportName);
            A32FlightArrivalCountryName = T000510_A32FlightArrivalCountryName[0];
            AssignAttri("", false, "A32FlightArrivalCountryName", A32FlightArrivalCountryName);
            A34FlightArrivalCityName = T000510_A34FlightArrivalCityName[0];
            AssignAttri("", false, "A34FlightArrivalCityName", A34FlightArrivalCityName);
            A23FlightDepartureAirportName = T000510_A23FlightDepartureAirportName[0];
            AssignAttri("", false, "A23FlightDepartureAirportName", A23FlightDepartureAirportName);
            A28FlightDepartureCountryName = T000510_A28FlightDepartureCountryName[0];
            AssignAttri("", false, "A28FlightDepartureCountryName", A28FlightDepartureCountryName);
            A30FlightDepartureCityName = T000510_A30FlightDepartureCityName[0];
            AssignAttri("", false, "A30FlightDepartureCityName", A30FlightDepartureCityName);
            A25FlightArrivalAirportId = T000510_A25FlightArrivalAirportId[0];
            AssignAttri("", false, "A25FlightArrivalAirportId", StringUtil.LTrimStr( (decimal)(A25FlightArrivalAirportId), 4, 0));
            A24FlightDepartureAirportId = T000510_A24FlightDepartureAirportId[0];
            AssignAttri("", false, "A24FlightDepartureAirportId", StringUtil.LTrimStr( (decimal)(A24FlightDepartureAirportId), 4, 0));
            A31FlightArrivalCountryId = T000510_A31FlightArrivalCountryId[0];
            AssignAttri("", false, "A31FlightArrivalCountryId", StringUtil.LTrimStr( (decimal)(A31FlightArrivalCountryId), 4, 0));
            A33FlightArrivalCityId = T000510_A33FlightArrivalCityId[0];
            AssignAttri("", false, "A33FlightArrivalCityId", StringUtil.LTrimStr( (decimal)(A33FlightArrivalCityId), 4, 0));
            A27FlightDepartureCountryId = T000510_A27FlightDepartureCountryId[0];
            AssignAttri("", false, "A27FlightDepartureCountryId", StringUtil.LTrimStr( (decimal)(A27FlightDepartureCountryId), 4, 0));
            A29FlightDepartureCityId = T000510_A29FlightDepartureCityId[0];
            AssignAttri("", false, "A29FlightDepartureCityId", StringUtil.LTrimStr( (decimal)(A29FlightDepartureCityId), 4, 0));
            ZM056( -1) ;
         }
         pr_default.close(8);
         OnLoadActions056( ) ;
      }

      protected void OnLoadActions056( )
      {
      }

      protected void CheckExtendedTable056( )
      {
         nIsDirty_6 = 0;
         Gx_BScreen = 1;
         standaloneModal( ) ;
         /* Using cursor T00054 */
         pr_default.execute(2, new Object[] {A25FlightArrivalAirportId});
         if ( (pr_default.getStatus(2) == 101) )
         {
            GX_msglist.addItem("No matching 'Flight Arrival Airport'.", "ForeignKeyNotFound", 1, "FLIGHTARRIVALAIRPORTID");
            AnyError = 1;
            GX_FocusControl = edtFlightArrivalAirportId_Internalname;
            AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A26FlightArrivalAirportName = T00054_A26FlightArrivalAirportName[0];
         AssignAttri("", false, "A26FlightArrivalAirportName", A26FlightArrivalAirportName);
         A31FlightArrivalCountryId = T00054_A31FlightArrivalCountryId[0];
         AssignAttri("", false, "A31FlightArrivalCountryId", StringUtil.LTrimStr( (decimal)(A31FlightArrivalCountryId), 4, 0));
         A33FlightArrivalCityId = T00054_A33FlightArrivalCityId[0];
         AssignAttri("", false, "A33FlightArrivalCityId", StringUtil.LTrimStr( (decimal)(A33FlightArrivalCityId), 4, 0));
         pr_default.close(2);
         /* Using cursor T00056 */
         pr_default.execute(4, new Object[] {A31FlightArrivalCountryId});
         if ( (pr_default.getStatus(4) == 101) )
         {
            GX_msglist.addItem("No matching 'Flight Arrival Airport'.", "ForeignKeyNotFound", 1, "FLIGHTARRIVALCOUNTRYID");
            AnyError = 1;
         }
         A32FlightArrivalCountryName = T00056_A32FlightArrivalCountryName[0];
         AssignAttri("", false, "A32FlightArrivalCountryName", A32FlightArrivalCountryName);
         pr_default.close(4);
         /* Using cursor T00057 */
         pr_default.execute(5, new Object[] {A31FlightArrivalCountryId, A33FlightArrivalCityId});
         if ( (pr_default.getStatus(5) == 101) )
         {
            GX_msglist.addItem("No matching 'Flight Arrival Airport'.", "ForeignKeyNotFound", 1, "FLIGHTARRIVALCITYID");
            AnyError = 1;
         }
         A34FlightArrivalCityName = T00057_A34FlightArrivalCityName[0];
         AssignAttri("", false, "A34FlightArrivalCityName", A34FlightArrivalCityName);
         pr_default.close(5);
         /* Using cursor T00055 */
         pr_default.execute(3, new Object[] {A24FlightDepartureAirportId});
         if ( (pr_default.getStatus(3) == 101) )
         {
            GX_msglist.addItem("No matching 'Flight Departure Airport'.", "ForeignKeyNotFound", 1, "FLIGHTDEPARTUREAIRPORTID");
            AnyError = 1;
            GX_FocusControl = edtFlightDepartureAirportId_Internalname;
            AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A23FlightDepartureAirportName = T00055_A23FlightDepartureAirportName[0];
         AssignAttri("", false, "A23FlightDepartureAirportName", A23FlightDepartureAirportName);
         A27FlightDepartureCountryId = T00055_A27FlightDepartureCountryId[0];
         AssignAttri("", false, "A27FlightDepartureCountryId", StringUtil.LTrimStr( (decimal)(A27FlightDepartureCountryId), 4, 0));
         A29FlightDepartureCityId = T00055_A29FlightDepartureCityId[0];
         AssignAttri("", false, "A29FlightDepartureCityId", StringUtil.LTrimStr( (decimal)(A29FlightDepartureCityId), 4, 0));
         pr_default.close(3);
         /* Using cursor T00058 */
         pr_default.execute(6, new Object[] {A27FlightDepartureCountryId});
         if ( (pr_default.getStatus(6) == 101) )
         {
            GX_msglist.addItem("No matching 'Flight Departure Airport'.", "ForeignKeyNotFound", 1, "FLIGHTDEPARTURECOUNTRYID");
            AnyError = 1;
         }
         A28FlightDepartureCountryName = T00058_A28FlightDepartureCountryName[0];
         AssignAttri("", false, "A28FlightDepartureCountryName", A28FlightDepartureCountryName);
         pr_default.close(6);
         /* Using cursor T00059 */
         pr_default.execute(7, new Object[] {A27FlightDepartureCountryId, A29FlightDepartureCityId});
         if ( (pr_default.getStatus(7) == 101) )
         {
            GX_msglist.addItem("No matching 'Flight Departure Airport'.", "ForeignKeyNotFound", 1, "FLIGHTDEPARTURECITYID");
            AnyError = 1;
         }
         A30FlightDepartureCityName = T00059_A30FlightDepartureCityName[0];
         AssignAttri("", false, "A30FlightDepartureCityName", A30FlightDepartureCityName);
         pr_default.close(7);
      }

      protected void CloseExtendedTableCursors056( )
      {
         pr_default.close(2);
         pr_default.close(4);
         pr_default.close(5);
         pr_default.close(3);
         pr_default.close(6);
         pr_default.close(7);
      }

      protected void enableDisable( )
      {
      }

      protected void gxLoad_2( short A25FlightArrivalAirportId )
      {
         /* Using cursor T000511 */
         pr_default.execute(9, new Object[] {A25FlightArrivalAirportId});
         if ( (pr_default.getStatus(9) == 101) )
         {
            GX_msglist.addItem("No matching 'Flight Arrival Airport'.", "ForeignKeyNotFound", 1, "FLIGHTARRIVALAIRPORTID");
            AnyError = 1;
            GX_FocusControl = edtFlightArrivalAirportId_Internalname;
            AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A26FlightArrivalAirportName = T000511_A26FlightArrivalAirportName[0];
         AssignAttri("", false, "A26FlightArrivalAirportName", A26FlightArrivalAirportName);
         A31FlightArrivalCountryId = T000511_A31FlightArrivalCountryId[0];
         AssignAttri("", false, "A31FlightArrivalCountryId", StringUtil.LTrimStr( (decimal)(A31FlightArrivalCountryId), 4, 0));
         A33FlightArrivalCityId = T000511_A33FlightArrivalCityId[0];
         AssignAttri("", false, "A33FlightArrivalCityId", StringUtil.LTrimStr( (decimal)(A33FlightArrivalCityId), 4, 0));
         GxWebStd.set_html_headers( context, 0, "", "");
         AddString( "[[") ;
         AddString( "\""+GXUtil.EncodeJSConstant( A26FlightArrivalAirportName)+"\""+","+"\""+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A31FlightArrivalCountryId), 4, 0, ".", "")))+"\""+","+"\""+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A33FlightArrivalCityId), 4, 0, ".", "")))+"\"") ;
         AddString( "]") ;
         if ( (pr_default.getStatus(9) == 101) )
         {
            AddString( ",") ;
            AddString( "101") ;
         }
         AddString( "]") ;
         pr_default.close(9);
      }

      protected void gxLoad_4( short A31FlightArrivalCountryId )
      {
         /* Using cursor T000512 */
         pr_default.execute(10, new Object[] {A31FlightArrivalCountryId});
         if ( (pr_default.getStatus(10) == 101) )
         {
            GX_msglist.addItem("No matching 'Flight Arrival Airport'.", "ForeignKeyNotFound", 1, "FLIGHTARRIVALCOUNTRYID");
            AnyError = 1;
         }
         A32FlightArrivalCountryName = T000512_A32FlightArrivalCountryName[0];
         AssignAttri("", false, "A32FlightArrivalCountryName", A32FlightArrivalCountryName);
         GxWebStd.set_html_headers( context, 0, "", "");
         AddString( "[[") ;
         AddString( "\""+GXUtil.EncodeJSConstant( A32FlightArrivalCountryName)+"\"") ;
         AddString( "]") ;
         if ( (pr_default.getStatus(10) == 101) )
         {
            AddString( ",") ;
            AddString( "101") ;
         }
         AddString( "]") ;
         pr_default.close(10);
      }

      protected void gxLoad_5( short A31FlightArrivalCountryId ,
                               short A33FlightArrivalCityId )
      {
         /* Using cursor T000513 */
         pr_default.execute(11, new Object[] {A31FlightArrivalCountryId, A33FlightArrivalCityId});
         if ( (pr_default.getStatus(11) == 101) )
         {
            GX_msglist.addItem("No matching 'Flight Arrival Airport'.", "ForeignKeyNotFound", 1, "FLIGHTARRIVALCITYID");
            AnyError = 1;
         }
         A34FlightArrivalCityName = T000513_A34FlightArrivalCityName[0];
         AssignAttri("", false, "A34FlightArrivalCityName", A34FlightArrivalCityName);
         GxWebStd.set_html_headers( context, 0, "", "");
         AddString( "[[") ;
         AddString( "\""+GXUtil.EncodeJSConstant( A34FlightArrivalCityName)+"\"") ;
         AddString( "]") ;
         if ( (pr_default.getStatus(11) == 101) )
         {
            AddString( ",") ;
            AddString( "101") ;
         }
         AddString( "]") ;
         pr_default.close(11);
      }

      protected void gxLoad_3( short A24FlightDepartureAirportId )
      {
         /* Using cursor T000514 */
         pr_default.execute(12, new Object[] {A24FlightDepartureAirportId});
         if ( (pr_default.getStatus(12) == 101) )
         {
            GX_msglist.addItem("No matching 'Flight Departure Airport'.", "ForeignKeyNotFound", 1, "FLIGHTDEPARTUREAIRPORTID");
            AnyError = 1;
            GX_FocusControl = edtFlightDepartureAirportId_Internalname;
            AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A23FlightDepartureAirportName = T000514_A23FlightDepartureAirportName[0];
         AssignAttri("", false, "A23FlightDepartureAirportName", A23FlightDepartureAirportName);
         A27FlightDepartureCountryId = T000514_A27FlightDepartureCountryId[0];
         AssignAttri("", false, "A27FlightDepartureCountryId", StringUtil.LTrimStr( (decimal)(A27FlightDepartureCountryId), 4, 0));
         A29FlightDepartureCityId = T000514_A29FlightDepartureCityId[0];
         AssignAttri("", false, "A29FlightDepartureCityId", StringUtil.LTrimStr( (decimal)(A29FlightDepartureCityId), 4, 0));
         GxWebStd.set_html_headers( context, 0, "", "");
         AddString( "[[") ;
         AddString( "\""+GXUtil.EncodeJSConstant( A23FlightDepartureAirportName)+"\""+","+"\""+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A27FlightDepartureCountryId), 4, 0, ".", "")))+"\""+","+"\""+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A29FlightDepartureCityId), 4, 0, ".", "")))+"\"") ;
         AddString( "]") ;
         if ( (pr_default.getStatus(12) == 101) )
         {
            AddString( ",") ;
            AddString( "101") ;
         }
         AddString( "]") ;
         pr_default.close(12);
      }

      protected void gxLoad_6( short A27FlightDepartureCountryId )
      {
         /* Using cursor T000515 */
         pr_default.execute(13, new Object[] {A27FlightDepartureCountryId});
         if ( (pr_default.getStatus(13) == 101) )
         {
            GX_msglist.addItem("No matching 'Flight Departure Airport'.", "ForeignKeyNotFound", 1, "FLIGHTDEPARTURECOUNTRYID");
            AnyError = 1;
         }
         A28FlightDepartureCountryName = T000515_A28FlightDepartureCountryName[0];
         AssignAttri("", false, "A28FlightDepartureCountryName", A28FlightDepartureCountryName);
         GxWebStd.set_html_headers( context, 0, "", "");
         AddString( "[[") ;
         AddString( "\""+GXUtil.EncodeJSConstant( A28FlightDepartureCountryName)+"\"") ;
         AddString( "]") ;
         if ( (pr_default.getStatus(13) == 101) )
         {
            AddString( ",") ;
            AddString( "101") ;
         }
         AddString( "]") ;
         pr_default.close(13);
      }

      protected void gxLoad_7( short A27FlightDepartureCountryId ,
                               short A29FlightDepartureCityId )
      {
         /* Using cursor T000516 */
         pr_default.execute(14, new Object[] {A27FlightDepartureCountryId, A29FlightDepartureCityId});
         if ( (pr_default.getStatus(14) == 101) )
         {
            GX_msglist.addItem("No matching 'Flight Departure Airport'.", "ForeignKeyNotFound", 1, "FLIGHTDEPARTURECITYID");
            AnyError = 1;
         }
         A30FlightDepartureCityName = T000516_A30FlightDepartureCityName[0];
         AssignAttri("", false, "A30FlightDepartureCityName", A30FlightDepartureCityName);
         GxWebStd.set_html_headers( context, 0, "", "");
         AddString( "[[") ;
         AddString( "\""+GXUtil.EncodeJSConstant( A30FlightDepartureCityName)+"\"") ;
         AddString( "]") ;
         if ( (pr_default.getStatus(14) == 101) )
         {
            AddString( ",") ;
            AddString( "101") ;
         }
         AddString( "]") ;
         pr_default.close(14);
      }

      protected void GetKey056( )
      {
         /* Using cursor T000517 */
         pr_default.execute(15, new Object[] {A19FlightId});
         if ( (pr_default.getStatus(15) != 101) )
         {
            RcdFound6 = 1;
         }
         else
         {
            RcdFound6 = 0;
         }
         pr_default.close(15);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T00053 */
         pr_default.execute(1, new Object[] {A19FlightId});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM056( 1) ;
            RcdFound6 = 1;
            A19FlightId = T00053_A19FlightId[0];
            AssignAttri("", false, "A19FlightId", StringUtil.LTrimStr( (decimal)(A19FlightId), 4, 0));
            A25FlightArrivalAirportId = T00053_A25FlightArrivalAirportId[0];
            AssignAttri("", false, "A25FlightArrivalAirportId", StringUtil.LTrimStr( (decimal)(A25FlightArrivalAirportId), 4, 0));
            A24FlightDepartureAirportId = T00053_A24FlightDepartureAirportId[0];
            AssignAttri("", false, "A24FlightDepartureAirportId", StringUtil.LTrimStr( (decimal)(A24FlightDepartureAirportId), 4, 0));
            Z19FlightId = A19FlightId;
            sMode6 = Gx_mode;
            Gx_mode = "DSP";
            AssignAttri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Load056( ) ;
            if ( AnyError == 1 )
            {
               RcdFound6 = 0;
               InitializeNonKey056( ) ;
            }
            Gx_mode = sMode6;
            AssignAttri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            RcdFound6 = 0;
            InitializeNonKey056( ) ;
            sMode6 = Gx_mode;
            Gx_mode = "DSP";
            AssignAttri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Gx_mode = sMode6;
            AssignAttri("", false, "Gx_mode", Gx_mode);
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey056( ) ;
         if ( RcdFound6 == 0 )
         {
            Gx_mode = "INS";
            AssignAttri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            Gx_mode = "UPD";
            AssignAttri("", false, "Gx_mode", Gx_mode);
         }
         getByPrimaryKey( ) ;
      }

      protected void move_next( )
      {
         RcdFound6 = 0;
         /* Using cursor T000518 */
         pr_default.execute(16, new Object[] {A19FlightId});
         if ( (pr_default.getStatus(16) != 101) )
         {
            while ( (pr_default.getStatus(16) != 101) && ( ( T000518_A19FlightId[0] < A19FlightId ) ) )
            {
               pr_default.readNext(16);
            }
            if ( (pr_default.getStatus(16) != 101) && ( ( T000518_A19FlightId[0] > A19FlightId ) ) )
            {
               A19FlightId = T000518_A19FlightId[0];
               AssignAttri("", false, "A19FlightId", StringUtil.LTrimStr( (decimal)(A19FlightId), 4, 0));
               RcdFound6 = 1;
            }
         }
         pr_default.close(16);
      }

      protected void move_previous( )
      {
         RcdFound6 = 0;
         /* Using cursor T000519 */
         pr_default.execute(17, new Object[] {A19FlightId});
         if ( (pr_default.getStatus(17) != 101) )
         {
            while ( (pr_default.getStatus(17) != 101) && ( ( T000519_A19FlightId[0] > A19FlightId ) ) )
            {
               pr_default.readNext(17);
            }
            if ( (pr_default.getStatus(17) != 101) && ( ( T000519_A19FlightId[0] < A19FlightId ) ) )
            {
               A19FlightId = T000519_A19FlightId[0];
               AssignAttri("", false, "A19FlightId", StringUtil.LTrimStr( (decimal)(A19FlightId), 4, 0));
               RcdFound6 = 1;
            }
         }
         pr_default.close(17);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1;
         GetKey056( ) ;
         if ( IsIns( ) )
         {
            /* Insert record */
            GX_FocusControl = edtFlightId_Internalname;
            AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
            Insert056( ) ;
            if ( AnyError == 1 )
            {
               GX_FocusControl = "";
               AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( RcdFound6 == 1 )
            {
               if ( A19FlightId != Z19FlightId )
               {
                  A19FlightId = Z19FlightId;
                  AssignAttri("", false, "A19FlightId", StringUtil.LTrimStr( (decimal)(A19FlightId), 4, 0));
                  GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd", ""), "CandidateKeyNotFound", 1, "FLIGHTID");
                  AnyError = 1;
                  GX_FocusControl = edtFlightId_Internalname;
                  AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else if ( IsDlt( ) )
               {
                  delete( ) ;
                  AfterTrn( ) ;
                  GX_FocusControl = edtFlightId_Internalname;
                  AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else
               {
                  Gx_mode = "UPD";
                  AssignAttri("", false, "Gx_mode", Gx_mode);
                  /* Update record */
                  Update056( ) ;
                  GX_FocusControl = edtFlightId_Internalname;
                  AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
               }
            }
            else
            {
               if ( A19FlightId != Z19FlightId )
               {
                  Gx_mode = "INS";
                  AssignAttri("", false, "Gx_mode", Gx_mode);
                  /* Insert record */
                  GX_FocusControl = edtFlightId_Internalname;
                  AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
                  Insert056( ) ;
                  if ( AnyError == 1 )
                  {
                     GX_FocusControl = "";
                     AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
                  }
               }
               else
               {
                  if ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )
                  {
                     GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, "FLIGHTID");
                     AnyError = 1;
                     GX_FocusControl = edtFlightId_Internalname;
                     AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
                  }
                  else
                  {
                     Gx_mode = "INS";
                     AssignAttri("", false, "Gx_mode", Gx_mode);
                     /* Insert record */
                     GX_FocusControl = edtFlightId_Internalname;
                     AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
                     Insert056( ) ;
                     if ( AnyError == 1 )
                     {
                        GX_FocusControl = "";
                        AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
                     }
                  }
               }
            }
         }
         AfterTrn( ) ;
      }

      protected void btn_delete( )
      {
         if ( A19FlightId != Z19FlightId )
         {
            A19FlightId = Z19FlightId;
            AssignAttri("", false, "A19FlightId", StringUtil.LTrimStr( (decimal)(A19FlightId), 4, 0));
            GX_msglist.addItem(context.GetMessage( "GXM_getbeforedlt", ""), 1, "FLIGHTID");
            AnyError = 1;
            GX_FocusControl = edtFlightId_Internalname;
            AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         }
         else
         {
            delete( ) ;
            AfterTrn( ) ;
            GX_FocusControl = edtFlightId_Internalname;
            AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError != 0 )
         {
            Gx_mode = "UPD";
            AssignAttri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            getByPrimaryKey( ) ;
         }
         CloseOpenCursors();
      }

      protected void btn_get( )
      {
         nKeyPressed = 2;
         IsConfirmed = 0;
         AssignAttri("", false, "IsConfirmed", StringUtil.LTrimStr( (decimal)(IsConfirmed), 4, 0));
         getEqualNoModal( ) ;
         if ( RcdFound6 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_keynfound", ""), "PrimaryKeyNotFound", 1, "FLIGHTID");
            AnyError = 1;
            GX_FocusControl = edtFlightId_Internalname;
            AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         }
         GX_FocusControl = edtFlightArrivalAirportId_Internalname;
         AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_first( )
      {
         nKeyPressed = 2;
         IsConfirmed = 0;
         AssignAttri("", false, "IsConfirmed", StringUtil.LTrimStr( (decimal)(IsConfirmed), 4, 0));
         ScanStart056( ) ;
         if ( RcdFound6 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            Gx_mode = "UPD";
            AssignAttri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtFlightArrivalAirportId_Internalname;
         AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         ScanEnd056( ) ;
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_previous( )
      {
         nKeyPressed = 2;
         IsConfirmed = 0;
         AssignAttri("", false, "IsConfirmed", StringUtil.LTrimStr( (decimal)(IsConfirmed), 4, 0));
         move_previous( ) ;
         if ( RcdFound6 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            Gx_mode = "UPD";
            AssignAttri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtFlightArrivalAirportId_Internalname;
         AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_next( )
      {
         nKeyPressed = 2;
         IsConfirmed = 0;
         AssignAttri("", false, "IsConfirmed", StringUtil.LTrimStr( (decimal)(IsConfirmed), 4, 0));
         move_next( ) ;
         if ( RcdFound6 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            Gx_mode = "UPD";
            AssignAttri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtFlightArrivalAirportId_Internalname;
         AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_last( )
      {
         nKeyPressed = 2;
         IsConfirmed = 0;
         AssignAttri("", false, "IsConfirmed", StringUtil.LTrimStr( (decimal)(IsConfirmed), 4, 0));
         ScanStart056( ) ;
         if ( RcdFound6 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            while ( RcdFound6 != 0 )
            {
               ScanNext056( ) ;
            }
            Gx_mode = "UPD";
            AssignAttri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtFlightArrivalAirportId_Internalname;
         AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         ScanEnd056( ) ;
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_select( )
      {
         getEqualNoModal( ) ;
      }

      protected void CheckOptimisticConcurrency056( )
      {
         if ( ! IsIns( ) )
         {
            /* Using cursor T00052 */
            pr_default.execute(0, new Object[] {A19FlightId});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Flight"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            if ( (pr_default.getStatus(0) == 101) || ( Z25FlightArrivalAirportId != T00052_A25FlightArrivalAirportId[0] ) || ( Z24FlightDepartureAirportId != T00052_A24FlightDepartureAirportId[0] ) )
            {
               if ( Z25FlightArrivalAirportId != T00052_A25FlightArrivalAirportId[0] )
               {
                  GXUtil.WriteLog("flight:[seudo value changed for attri]"+"FlightArrivalAirportId");
                  GXUtil.WriteLogRaw("Old: ",Z25FlightArrivalAirportId);
                  GXUtil.WriteLogRaw("Current: ",T00052_A25FlightArrivalAirportId[0]);
               }
               if ( Z24FlightDepartureAirportId != T00052_A24FlightDepartureAirportId[0] )
               {
                  GXUtil.WriteLog("flight:[seudo value changed for attri]"+"FlightDepartureAirportId");
                  GXUtil.WriteLogRaw("Old: ",Z24FlightDepartureAirportId);
                  GXUtil.WriteLogRaw("Current: ",T00052_A24FlightDepartureAirportId[0]);
               }
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"Flight"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert056( )
      {
         BeforeValidate056( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable056( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM056( 0) ;
            CheckOptimisticConcurrency056( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm056( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert056( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000520 */
                     pr_default.execute(18, new Object[] {A25FlightArrivalAirportId, A24FlightDepartureAirportId});
                     A19FlightId = T000520_A19FlightId[0];
                     AssignAttri("", false, "A19FlightId", StringUtil.LTrimStr( (decimal)(A19FlightId), 4, 0));
                     pr_default.close(18);
                     pr_default.SmartCacheProvider.SetUpdated("Flight");
                     if ( AnyError == 0 )
                     {
                        /* Start of After( Insert) rules */
                        /* End of After( Insert) rules */
                        if ( AnyError == 0 )
                        {
                           /* Save values for previous() function. */
                           endTrnMsgTxt = context.GetMessage( "GXM_sucadded", "");
                           endTrnMsgCod = "SuccessfullyAdded";
                           ResetCaption050( ) ;
                        }
                     }
                  }
                  else
                  {
                     GX_msglist.addItem(context.GetMessage( "GXM_unexp", ""), 1, "");
                     AnyError = 1;
                  }
               }
            }
            else
            {
               Load056( ) ;
            }
            EndLevel056( ) ;
         }
         CloseExtendedTableCursors056( ) ;
      }

      protected void Update056( )
      {
         BeforeValidate056( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable056( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency056( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm056( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate056( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000521 */
                     pr_default.execute(19, new Object[] {A25FlightArrivalAirportId, A24FlightDepartureAirportId, A19FlightId});
                     pr_default.close(19);
                     pr_default.SmartCacheProvider.SetUpdated("Flight");
                     if ( (pr_default.getStatus(19) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Flight"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate056( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           getByPrimaryKey( ) ;
                           endTrnMsgTxt = context.GetMessage( "GXM_sucupdated", "");
                           endTrnMsgCod = "SuccessfullyUpdated";
                           ResetCaption050( ) ;
                        }
                     }
                     else
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_unexp", ""), 1, "");
                        AnyError = 1;
                     }
                  }
               }
            }
            EndLevel056( ) ;
         }
         CloseExtendedTableCursors056( ) ;
      }

      protected void DeferredUpdate056( )
      {
      }

      protected void delete( )
      {
         Gx_mode = "DLT";
         AssignAttri("", false, "Gx_mode", Gx_mode);
         BeforeValidate056( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency056( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls056( ) ;
            AfterConfirm056( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete056( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T000522 */
                  pr_default.execute(20, new Object[] {A19FlightId});
                  pr_default.close(20);
                  pr_default.SmartCacheProvider.SetUpdated("Flight");
                  if ( AnyError == 0 )
                  {
                     /* Start of After( delete) rules */
                     /* End of After( delete) rules */
                     if ( AnyError == 0 )
                     {
                        move_next( ) ;
                        if ( RcdFound6 == 0 )
                        {
                           InitAll056( ) ;
                           Gx_mode = "INS";
                           AssignAttri("", false, "Gx_mode", Gx_mode);
                        }
                        else
                        {
                           getByPrimaryKey( ) ;
                           Gx_mode = "UPD";
                           AssignAttri("", false, "Gx_mode", Gx_mode);
                        }
                        endTrnMsgTxt = context.GetMessage( "GXM_sucdeleted", "");
                        endTrnMsgCod = "SuccessfullyDeleted";
                        ResetCaption050( ) ;
                     }
                  }
                  else
                  {
                     GX_msglist.addItem(context.GetMessage( "GXM_unexp", ""), 1, "");
                     AnyError = 1;
                  }
               }
            }
         }
         sMode6 = Gx_mode;
         Gx_mode = "DLT";
         AssignAttri("", false, "Gx_mode", Gx_mode);
         EndLevel056( ) ;
         Gx_mode = sMode6;
         AssignAttri("", false, "Gx_mode", Gx_mode);
      }

      protected void OnDeleteControls056( )
      {
         standaloneModal( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            /* Using cursor T000523 */
            pr_default.execute(21, new Object[] {A25FlightArrivalAirportId});
            A26FlightArrivalAirportName = T000523_A26FlightArrivalAirportName[0];
            AssignAttri("", false, "A26FlightArrivalAirportName", A26FlightArrivalAirportName);
            A31FlightArrivalCountryId = T000523_A31FlightArrivalCountryId[0];
            AssignAttri("", false, "A31FlightArrivalCountryId", StringUtil.LTrimStr( (decimal)(A31FlightArrivalCountryId), 4, 0));
            A33FlightArrivalCityId = T000523_A33FlightArrivalCityId[0];
            AssignAttri("", false, "A33FlightArrivalCityId", StringUtil.LTrimStr( (decimal)(A33FlightArrivalCityId), 4, 0));
            pr_default.close(21);
            /* Using cursor T000524 */
            pr_default.execute(22, new Object[] {A31FlightArrivalCountryId});
            A32FlightArrivalCountryName = T000524_A32FlightArrivalCountryName[0];
            AssignAttri("", false, "A32FlightArrivalCountryName", A32FlightArrivalCountryName);
            pr_default.close(22);
            /* Using cursor T000525 */
            pr_default.execute(23, new Object[] {A31FlightArrivalCountryId, A33FlightArrivalCityId});
            A34FlightArrivalCityName = T000525_A34FlightArrivalCityName[0];
            AssignAttri("", false, "A34FlightArrivalCityName", A34FlightArrivalCityName);
            pr_default.close(23);
            /* Using cursor T000526 */
            pr_default.execute(24, new Object[] {A24FlightDepartureAirportId});
            A23FlightDepartureAirportName = T000526_A23FlightDepartureAirportName[0];
            AssignAttri("", false, "A23FlightDepartureAirportName", A23FlightDepartureAirportName);
            A27FlightDepartureCountryId = T000526_A27FlightDepartureCountryId[0];
            AssignAttri("", false, "A27FlightDepartureCountryId", StringUtil.LTrimStr( (decimal)(A27FlightDepartureCountryId), 4, 0));
            A29FlightDepartureCityId = T000526_A29FlightDepartureCityId[0];
            AssignAttri("", false, "A29FlightDepartureCityId", StringUtil.LTrimStr( (decimal)(A29FlightDepartureCityId), 4, 0));
            pr_default.close(24);
            /* Using cursor T000527 */
            pr_default.execute(25, new Object[] {A27FlightDepartureCountryId});
            A28FlightDepartureCountryName = T000527_A28FlightDepartureCountryName[0];
            AssignAttri("", false, "A28FlightDepartureCountryName", A28FlightDepartureCountryName);
            pr_default.close(25);
            /* Using cursor T000528 */
            pr_default.execute(26, new Object[] {A27FlightDepartureCountryId, A29FlightDepartureCityId});
            A30FlightDepartureCityName = T000528_A30FlightDepartureCityName[0];
            AssignAttri("", false, "A30FlightDepartureCityName", A30FlightDepartureCityName);
            pr_default.close(26);
         }
      }

      protected void EndLevel056( )
      {
         if ( ! IsIns( ) )
         {
            pr_default.close(0);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete056( ) ;
         }
         if ( AnyError == 0 )
         {
            pr_default.close(1);
            pr_default.close(21);
            pr_default.close(24);
            pr_default.close(22);
            pr_default.close(23);
            pr_default.close(25);
            pr_default.close(26);
            context.CommitDataStores("flight",pr_default);
            if ( AnyError == 0 )
            {
               ConfirmValues050( ) ;
            }
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1;
         }
         else
         {
            pr_default.close(1);
            pr_default.close(21);
            pr_default.close(24);
            pr_default.close(22);
            pr_default.close(23);
            pr_default.close(25);
            pr_default.close(26);
            context.RollbackDataStores("flight",pr_default);
         }
         IsModified = 0;
         if ( AnyError != 0 )
         {
            context.wjLoc = "";
            context.nUserReturn = 0;
         }
      }

      public void ScanStart056( )
      {
         /* Using cursor T000529 */
         pr_default.execute(27);
         RcdFound6 = 0;
         if ( (pr_default.getStatus(27) != 101) )
         {
            RcdFound6 = 1;
            A19FlightId = T000529_A19FlightId[0];
            AssignAttri("", false, "A19FlightId", StringUtil.LTrimStr( (decimal)(A19FlightId), 4, 0));
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext056( )
      {
         /* Scan next routine */
         pr_default.readNext(27);
         RcdFound6 = 0;
         if ( (pr_default.getStatus(27) != 101) )
         {
            RcdFound6 = 1;
            A19FlightId = T000529_A19FlightId[0];
            AssignAttri("", false, "A19FlightId", StringUtil.LTrimStr( (decimal)(A19FlightId), 4, 0));
         }
      }

      protected void ScanEnd056( )
      {
         pr_default.close(27);
      }

      protected void AfterConfirm056( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert056( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate056( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete056( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete056( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate056( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes056( )
      {
         edtFlightId_Enabled = 0;
         AssignProp("", false, edtFlightId_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtFlightId_Enabled), 5, 0), true);
         edtFlightArrivalAirportId_Enabled = 0;
         AssignProp("", false, edtFlightArrivalAirportId_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtFlightArrivalAirportId_Enabled), 5, 0), true);
         edtFlightArrivalAirportName_Enabled = 0;
         AssignProp("", false, edtFlightArrivalAirportName_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtFlightArrivalAirportName_Enabled), 5, 0), true);
         edtFlightArrivalCountryId_Enabled = 0;
         AssignProp("", false, edtFlightArrivalCountryId_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtFlightArrivalCountryId_Enabled), 5, 0), true);
         edtFlightArrivalCountryName_Enabled = 0;
         AssignProp("", false, edtFlightArrivalCountryName_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtFlightArrivalCountryName_Enabled), 5, 0), true);
         edtFlightArrivalCityId_Enabled = 0;
         AssignProp("", false, edtFlightArrivalCityId_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtFlightArrivalCityId_Enabled), 5, 0), true);
         edtFlightArrivalCityName_Enabled = 0;
         AssignProp("", false, edtFlightArrivalCityName_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtFlightArrivalCityName_Enabled), 5, 0), true);
         edtFlightDepartureAirportId_Enabled = 0;
         AssignProp("", false, edtFlightDepartureAirportId_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtFlightDepartureAirportId_Enabled), 5, 0), true);
         edtFlightDepartureAirportName_Enabled = 0;
         AssignProp("", false, edtFlightDepartureAirportName_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtFlightDepartureAirportName_Enabled), 5, 0), true);
         edtFlightDepartureCountryId_Enabled = 0;
         AssignProp("", false, edtFlightDepartureCountryId_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtFlightDepartureCountryId_Enabled), 5, 0), true);
         edtFlightDepartureCountryName_Enabled = 0;
         AssignProp("", false, edtFlightDepartureCountryName_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtFlightDepartureCountryName_Enabled), 5, 0), true);
         edtFlightDepartureCityId_Enabled = 0;
         AssignProp("", false, edtFlightDepartureCityId_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtFlightDepartureCityId_Enabled), 5, 0), true);
         edtFlightDepartureCityName_Enabled = 0;
         AssignProp("", false, edtFlightDepartureCityName_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtFlightDepartureCityName_Enabled), 5, 0), true);
      }

      protected void send_integrity_lvl_hashes056( )
      {
      }

      protected void assign_properties_default( )
      {
      }

      protected void ConfirmValues050( )
      {
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
         MasterPageObj.master_styles();
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
         bodyStyle += "-moz-opacity:0;opacity:0;";
         if ( ! ( String.IsNullOrEmpty(StringUtil.RTrim( Form.Background)) ) )
         {
            bodyStyle += " background-image:url(" + context.convertURL( Form.Background) + ")";
         }
         context.WriteHtmlText( " "+"class=\"form-horizontal Form\""+" "+ "style='"+bodyStyle+"'") ;
         context.WriteHtmlText( FormProcess+">") ;
         context.skipLines(1);
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("flight.aspx") +"\">") ;
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
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "Z19FlightId", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z19FlightId), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z25FlightArrivalAirportId", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z25FlightArrivalAirportId), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z24FlightDepartureAirportId", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z24FlightDepartureAirportId), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "IsConfirmed", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsConfirmed), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "IsModified", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsModified), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Mode", StringUtil.RTrim( Gx_mode));
      }

      public override void RenderHtmlCloseForm( )
      {
         SendCloseFormHiddens( ) ;
         GxWebStd.gx_hidden_field( context, "GX_FocusControl", GX_FocusControl);
         SendAjaxEncryptionKey();
         SendSecurityToken(sPrefix);
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

      public override short ExecuteStartEvent( )
      {
         standaloneStartup( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         return gxajaxcallmode ;
      }

      public override void RenderHtmlContent( )
      {
         context.WriteHtmlText( "<div") ;
         GxWebStd.ClassAttribute( context, "gx-ct-body"+" "+(String.IsNullOrEmpty(StringUtil.RTrim( Form.Class)) ? "form-horizontal Form" : Form.Class)+"-fx");
         context.WriteHtmlText( ">") ;
         Draw( ) ;
         context.WriteHtmlText( "</div>") ;
      }

      public override void DispatchEvents( )
      {
         Process( ) ;
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
         return formatLink("flight.aspx")  ;
      }

      public override string GetPgmname( )
      {
         return "Flight" ;
      }

      public override string GetPgmdesc( )
      {
         return "Flight" ;
      }

      protected void InitializeNonKey056( )
      {
         A25FlightArrivalAirportId = 0;
         AssignAttri("", false, "A25FlightArrivalAirportId", StringUtil.LTrimStr( (decimal)(A25FlightArrivalAirportId), 4, 0));
         A26FlightArrivalAirportName = "";
         AssignAttri("", false, "A26FlightArrivalAirportName", A26FlightArrivalAirportName);
         A31FlightArrivalCountryId = 0;
         AssignAttri("", false, "A31FlightArrivalCountryId", StringUtil.LTrimStr( (decimal)(A31FlightArrivalCountryId), 4, 0));
         A32FlightArrivalCountryName = "";
         AssignAttri("", false, "A32FlightArrivalCountryName", A32FlightArrivalCountryName);
         A33FlightArrivalCityId = 0;
         AssignAttri("", false, "A33FlightArrivalCityId", StringUtil.LTrimStr( (decimal)(A33FlightArrivalCityId), 4, 0));
         A34FlightArrivalCityName = "";
         AssignAttri("", false, "A34FlightArrivalCityName", A34FlightArrivalCityName);
         A24FlightDepartureAirportId = 0;
         AssignAttri("", false, "A24FlightDepartureAirportId", StringUtil.LTrimStr( (decimal)(A24FlightDepartureAirportId), 4, 0));
         A23FlightDepartureAirportName = "";
         AssignAttri("", false, "A23FlightDepartureAirportName", A23FlightDepartureAirportName);
         A27FlightDepartureCountryId = 0;
         AssignAttri("", false, "A27FlightDepartureCountryId", StringUtil.LTrimStr( (decimal)(A27FlightDepartureCountryId), 4, 0));
         A28FlightDepartureCountryName = "";
         AssignAttri("", false, "A28FlightDepartureCountryName", A28FlightDepartureCountryName);
         A29FlightDepartureCityId = 0;
         AssignAttri("", false, "A29FlightDepartureCityId", StringUtil.LTrimStr( (decimal)(A29FlightDepartureCityId), 4, 0));
         A30FlightDepartureCityName = "";
         AssignAttri("", false, "A30FlightDepartureCityName", A30FlightDepartureCityName);
         Z25FlightArrivalAirportId = 0;
         Z24FlightDepartureAirportId = 0;
      }

      protected void InitAll056( )
      {
         A19FlightId = 0;
         AssignAttri("", false, "A19FlightId", StringUtil.LTrimStr( (decimal)(A19FlightId), 4, 0));
         InitializeNonKey056( ) ;
      }

      protected void StandaloneModalInsert( )
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
            context.AddJavascriptSource(StringUtil.RTrim( ((string)Form.Jscriptsrc.Item(idxLst))), "?202391916425973", true, true);
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
         context.AddJavascriptSource("flight.js", "?202391916425974", false, true);
         /* End function include_jscripts */
      }

      protected void init_default_properties( )
      {
         lblTitle_Internalname = "TITLE";
         divTitlecontainer_Internalname = "TITLECONTAINER";
         bttBtn_first_Internalname = "BTN_FIRST";
         bttBtn_previous_Internalname = "BTN_PREVIOUS";
         bttBtn_next_Internalname = "BTN_NEXT";
         bttBtn_last_Internalname = "BTN_LAST";
         bttBtn_select_Internalname = "BTN_SELECT";
         divToolbarcell_Internalname = "TOOLBARCELL";
         edtFlightId_Internalname = "FLIGHTID";
         edtFlightArrivalAirportId_Internalname = "FLIGHTARRIVALAIRPORTID";
         edtFlightArrivalAirportName_Internalname = "FLIGHTARRIVALAIRPORTNAME";
         edtFlightArrivalCountryId_Internalname = "FLIGHTARRIVALCOUNTRYID";
         edtFlightArrivalCountryName_Internalname = "FLIGHTARRIVALCOUNTRYNAME";
         edtFlightArrivalCityId_Internalname = "FLIGHTARRIVALCITYID";
         edtFlightArrivalCityName_Internalname = "FLIGHTARRIVALCITYNAME";
         edtFlightDepartureAirportId_Internalname = "FLIGHTDEPARTUREAIRPORTID";
         edtFlightDepartureAirportName_Internalname = "FLIGHTDEPARTUREAIRPORTNAME";
         edtFlightDepartureCountryId_Internalname = "FLIGHTDEPARTURECOUNTRYID";
         edtFlightDepartureCountryName_Internalname = "FLIGHTDEPARTURECOUNTRYNAME";
         edtFlightDepartureCityId_Internalname = "FLIGHTDEPARTURECITYID";
         edtFlightDepartureCityName_Internalname = "FLIGHTDEPARTURECITYNAME";
         divFormcontainer_Internalname = "FORMCONTAINER";
         bttBtn_enter_Internalname = "BTN_ENTER";
         bttBtn_cancel_Internalname = "BTN_CANCEL";
         bttBtn_delete_Internalname = "BTN_DELETE";
         divMaintable_Internalname = "MAINTABLE";
         Form.Internalname = "FORM";
         imgprompt_25_Internalname = "PROMPT_25";
         imgprompt_24_Internalname = "PROMPT_24";
      }

      public override void initialize_properties( )
      {
         context.SetDefaultTheme("TravelAgency_Capa202309", true);
         if ( context.isSpaRequest( ) )
         {
            disableJsOutput();
         }
         init_default_properties( ) ;
         Form.Headerrawhtml = "";
         Form.Background = "";
         Form.Textcolor = 0;
         Form.Backcolor = (int)(0xFFFFFF);
         Form.Caption = "Flight";
         bttBtn_delete_Enabled = 1;
         bttBtn_delete_Visible = 1;
         bttBtn_cancel_Visible = 1;
         bttBtn_enter_Enabled = 1;
         bttBtn_enter_Visible = 1;
         edtFlightDepartureCityName_Jsonclick = "";
         edtFlightDepartureCityName_Enabled = 0;
         edtFlightDepartureCityId_Jsonclick = "";
         edtFlightDepartureCityId_Enabled = 0;
         edtFlightDepartureCountryName_Jsonclick = "";
         edtFlightDepartureCountryName_Enabled = 0;
         edtFlightDepartureCountryId_Jsonclick = "";
         edtFlightDepartureCountryId_Enabled = 0;
         edtFlightDepartureAirportName_Jsonclick = "";
         edtFlightDepartureAirportName_Enabled = 0;
         imgprompt_24_Visible = 1;
         imgprompt_24_Link = "";
         edtFlightDepartureAirportId_Jsonclick = "";
         edtFlightDepartureAirportId_Enabled = 1;
         edtFlightArrivalCityName_Jsonclick = "";
         edtFlightArrivalCityName_Enabled = 0;
         edtFlightArrivalCityId_Jsonclick = "";
         edtFlightArrivalCityId_Enabled = 0;
         edtFlightArrivalCountryName_Jsonclick = "";
         edtFlightArrivalCountryName_Enabled = 0;
         edtFlightArrivalCountryId_Jsonclick = "";
         edtFlightArrivalCountryId_Enabled = 0;
         edtFlightArrivalAirportName_Jsonclick = "";
         edtFlightArrivalAirportName_Enabled = 0;
         imgprompt_25_Visible = 1;
         imgprompt_25_Link = "";
         edtFlightArrivalAirportId_Jsonclick = "";
         edtFlightArrivalAirportId_Enabled = 1;
         edtFlightId_Jsonclick = "";
         edtFlightId_Enabled = 1;
         bttBtn_select_Visible = 1;
         bttBtn_last_Visible = 1;
         bttBtn_next_Visible = 1;
         bttBtn_previous_Visible = 1;
         bttBtn_first_Visible = 1;
         context.GX_msglist.DisplayMode = 1;
         if ( context.isSpaRequest( ) )
         {
            enableJsOutput();
         }
      }

      protected void dynload_actions( )
      {
         /* End function dynload_actions */
      }

      protected void init_web_controls( )
      {
         /* End function init_web_controls */
      }

      protected void AfterKeyLoadScreen( )
      {
         IsConfirmed = 0;
         AssignAttri("", false, "IsConfirmed", StringUtil.LTrimStr( (decimal)(IsConfirmed), 4, 0));
         getEqualNoModal( ) ;
         GX_FocusControl = edtFlightArrivalAirportId_Internalname;
         AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         standaloneNotModal( ) ;
         standaloneModal( ) ;
         /* End function AfterKeyLoadScreen */
      }

      protected bool IsIns( )
      {
         return ((StringUtil.StrCmp(Gx_mode, "INS")==0) ? true : false) ;
      }

      protected bool IsDlt( )
      {
         return ((StringUtil.StrCmp(Gx_mode, "DLT")==0) ? true : false) ;
      }

      protected bool IsUpd( )
      {
         return ((StringUtil.StrCmp(Gx_mode, "UPD")==0) ? true : false) ;
      }

      protected bool IsDsp( )
      {
         return ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? true : false) ;
      }

      public void Valid_Flightid( )
      {
         context.wbHandled = 1;
         AfterKeyLoadScreen( ) ;
         Draw( ) ;
         send_integrity_footer_hashes( ) ;
         dynload_actions( ) ;
         /*  Sending validation outputs */
         AssignAttri("", false, "A25FlightArrivalAirportId", StringUtil.LTrim( StringUtil.NToC( (decimal)(A25FlightArrivalAirportId), 4, 0, ".", "")));
         AssignAttri("", false, "A24FlightDepartureAirportId", StringUtil.LTrim( StringUtil.NToC( (decimal)(A24FlightDepartureAirportId), 4, 0, ".", "")));
         AssignAttri("", false, "A26FlightArrivalAirportName", A26FlightArrivalAirportName);
         AssignAttri("", false, "A31FlightArrivalCountryId", StringUtil.LTrim( StringUtil.NToC( (decimal)(A31FlightArrivalCountryId), 4, 0, ".", "")));
         AssignAttri("", false, "A33FlightArrivalCityId", StringUtil.LTrim( StringUtil.NToC( (decimal)(A33FlightArrivalCityId), 4, 0, ".", "")));
         AssignAttri("", false, "A32FlightArrivalCountryName", A32FlightArrivalCountryName);
         AssignAttri("", false, "A34FlightArrivalCityName", A34FlightArrivalCityName);
         AssignAttri("", false, "A23FlightDepartureAirportName", A23FlightDepartureAirportName);
         AssignAttri("", false, "A27FlightDepartureCountryId", StringUtil.LTrim( StringUtil.NToC( (decimal)(A27FlightDepartureCountryId), 4, 0, ".", "")));
         AssignAttri("", false, "A29FlightDepartureCityId", StringUtil.LTrim( StringUtil.NToC( (decimal)(A29FlightDepartureCityId), 4, 0, ".", "")));
         AssignAttri("", false, "A28FlightDepartureCountryName", A28FlightDepartureCountryName);
         AssignAttri("", false, "A30FlightDepartureCityName", A30FlightDepartureCityName);
         AssignAttri("", false, "Gx_mode", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "Z19FlightId", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z19FlightId), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z25FlightArrivalAirportId", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z25FlightArrivalAirportId), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z24FlightDepartureAirportId", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z24FlightDepartureAirportId), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z26FlightArrivalAirportName", Z26FlightArrivalAirportName);
         GxWebStd.gx_hidden_field( context, "Z31FlightArrivalCountryId", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z31FlightArrivalCountryId), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z33FlightArrivalCityId", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z33FlightArrivalCityId), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z32FlightArrivalCountryName", Z32FlightArrivalCountryName);
         GxWebStd.gx_hidden_field( context, "Z34FlightArrivalCityName", Z34FlightArrivalCityName);
         GxWebStd.gx_hidden_field( context, "Z23FlightDepartureAirportName", Z23FlightDepartureAirportName);
         GxWebStd.gx_hidden_field( context, "Z27FlightDepartureCountryId", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z27FlightDepartureCountryId), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z29FlightDepartureCityId", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z29FlightDepartureCityId), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z28FlightDepartureCountryName", Z28FlightDepartureCountryName);
         GxWebStd.gx_hidden_field( context, "Z30FlightDepartureCityName", Z30FlightDepartureCityName);
         AssignProp("", false, bttBtn_delete_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(bttBtn_delete_Enabled), 5, 0), true);
         AssignProp("", false, bttBtn_enter_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(bttBtn_enter_Enabled), 5, 0), true);
         SendCloseFormHiddens( ) ;
      }

      public void Valid_Flightarrivalairportid( )
      {
         /* Using cursor T000523 */
         pr_default.execute(21, new Object[] {A25FlightArrivalAirportId});
         if ( (pr_default.getStatus(21) == 101) )
         {
            GX_msglist.addItem("No matching 'Flight Arrival Airport'.", "ForeignKeyNotFound", 1, "FLIGHTARRIVALAIRPORTID");
            AnyError = 1;
            GX_FocusControl = edtFlightArrivalAirportId_Internalname;
         }
         A26FlightArrivalAirportName = T000523_A26FlightArrivalAirportName[0];
         A31FlightArrivalCountryId = T000523_A31FlightArrivalCountryId[0];
         A33FlightArrivalCityId = T000523_A33FlightArrivalCityId[0];
         pr_default.close(21);
         /* Using cursor T000524 */
         pr_default.execute(22, new Object[] {A31FlightArrivalCountryId});
         if ( (pr_default.getStatus(22) == 101) )
         {
            GX_msglist.addItem("No matching 'Flight Arrival Airport'.", "ForeignKeyNotFound", 1, "FLIGHTARRIVALCOUNTRYID");
            AnyError = 1;
         }
         A32FlightArrivalCountryName = T000524_A32FlightArrivalCountryName[0];
         pr_default.close(22);
         /* Using cursor T000525 */
         pr_default.execute(23, new Object[] {A31FlightArrivalCountryId, A33FlightArrivalCityId});
         if ( (pr_default.getStatus(23) == 101) )
         {
            GX_msglist.addItem("No matching 'Flight Arrival Airport'.", "ForeignKeyNotFound", 1, "FLIGHTARRIVALCITYID");
            AnyError = 1;
         }
         A34FlightArrivalCityName = T000525_A34FlightArrivalCityName[0];
         pr_default.close(23);
         dynload_actions( ) ;
         /*  Sending validation outputs */
         AssignAttri("", false, "A26FlightArrivalAirportName", A26FlightArrivalAirportName);
         AssignAttri("", false, "A31FlightArrivalCountryId", StringUtil.LTrim( StringUtil.NToC( (decimal)(A31FlightArrivalCountryId), 4, 0, ".", "")));
         AssignAttri("", false, "A33FlightArrivalCityId", StringUtil.LTrim( StringUtil.NToC( (decimal)(A33FlightArrivalCityId), 4, 0, ".", "")));
         AssignAttri("", false, "A32FlightArrivalCountryName", A32FlightArrivalCountryName);
         AssignAttri("", false, "A34FlightArrivalCityName", A34FlightArrivalCityName);
      }

      public void Valid_Flightdepartureairportid( )
      {
         /* Using cursor T000526 */
         pr_default.execute(24, new Object[] {A24FlightDepartureAirportId});
         if ( (pr_default.getStatus(24) == 101) )
         {
            GX_msglist.addItem("No matching 'Flight Departure Airport'.", "ForeignKeyNotFound", 1, "FLIGHTDEPARTUREAIRPORTID");
            AnyError = 1;
            GX_FocusControl = edtFlightDepartureAirportId_Internalname;
         }
         A23FlightDepartureAirportName = T000526_A23FlightDepartureAirportName[0];
         A27FlightDepartureCountryId = T000526_A27FlightDepartureCountryId[0];
         A29FlightDepartureCityId = T000526_A29FlightDepartureCityId[0];
         pr_default.close(24);
         /* Using cursor T000527 */
         pr_default.execute(25, new Object[] {A27FlightDepartureCountryId});
         if ( (pr_default.getStatus(25) == 101) )
         {
            GX_msglist.addItem("No matching 'Flight Departure Airport'.", "ForeignKeyNotFound", 1, "FLIGHTDEPARTURECOUNTRYID");
            AnyError = 1;
         }
         A28FlightDepartureCountryName = T000527_A28FlightDepartureCountryName[0];
         pr_default.close(25);
         /* Using cursor T000528 */
         pr_default.execute(26, new Object[] {A27FlightDepartureCountryId, A29FlightDepartureCityId});
         if ( (pr_default.getStatus(26) == 101) )
         {
            GX_msglist.addItem("No matching 'Flight Departure Airport'.", "ForeignKeyNotFound", 1, "FLIGHTDEPARTURECITYID");
            AnyError = 1;
         }
         A30FlightDepartureCityName = T000528_A30FlightDepartureCityName[0];
         pr_default.close(26);
         dynload_actions( ) ;
         /*  Sending validation outputs */
         AssignAttri("", false, "A23FlightDepartureAirportName", A23FlightDepartureAirportName);
         AssignAttri("", false, "A27FlightDepartureCountryId", StringUtil.LTrim( StringUtil.NToC( (decimal)(A27FlightDepartureCountryId), 4, 0, ".", "")));
         AssignAttri("", false, "A29FlightDepartureCityId", StringUtil.LTrim( StringUtil.NToC( (decimal)(A29FlightDepartureCityId), 4, 0, ".", "")));
         AssignAttri("", false, "A28FlightDepartureCountryName", A28FlightDepartureCountryName);
         AssignAttri("", false, "A30FlightDepartureCityName", A30FlightDepartureCityName);
      }

      public override bool SupportAjaxEvent( )
      {
         return true ;
      }

      public override void InitializeDynEvents( )
      {
         setEventMetadata("ENTER","{handler:'UserMainFullajax',iparms:[{postForm:true}]");
         setEventMetadata("ENTER",",oparms:[]}");
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[]");
         setEventMetadata("REFRESH",",oparms:[]}");
         setEventMetadata("VALID_FLIGHTID","{handler:'Valid_Flightid',iparms:[{av:'A19FlightId',fld:'FLIGHTID',pic:'ZZZ9'},{av:'Gx_mode',fld:'vMODE',pic:'@!'}]");
         setEventMetadata("VALID_FLIGHTID",",oparms:[{av:'A25FlightArrivalAirportId',fld:'FLIGHTARRIVALAIRPORTID',pic:'ZZZ9'},{av:'A24FlightDepartureAirportId',fld:'FLIGHTDEPARTUREAIRPORTID',pic:'ZZZ9'},{av:'A26FlightArrivalAirportName',fld:'FLIGHTARRIVALAIRPORTNAME',pic:''},{av:'A31FlightArrivalCountryId',fld:'FLIGHTARRIVALCOUNTRYID',pic:'ZZZ9'},{av:'A33FlightArrivalCityId',fld:'FLIGHTARRIVALCITYID',pic:'ZZZ9'},{av:'A32FlightArrivalCountryName',fld:'FLIGHTARRIVALCOUNTRYNAME',pic:''},{av:'A34FlightArrivalCityName',fld:'FLIGHTARRIVALCITYNAME',pic:''},{av:'A23FlightDepartureAirportName',fld:'FLIGHTDEPARTUREAIRPORTNAME',pic:''},{av:'A27FlightDepartureCountryId',fld:'FLIGHTDEPARTURECOUNTRYID',pic:'ZZZ9'},{av:'A29FlightDepartureCityId',fld:'FLIGHTDEPARTURECITYID',pic:'ZZZ9'},{av:'A28FlightDepartureCountryName',fld:'FLIGHTDEPARTURECOUNTRYNAME',pic:''},{av:'A30FlightDepartureCityName',fld:'FLIGHTDEPARTURECITYNAME',pic:''},{av:'Gx_mode',fld:'vMODE',pic:'@!'},{av:'Z19FlightId'},{av:'Z25FlightArrivalAirportId'},{av:'Z24FlightDepartureAirportId'},{av:'Z26FlightArrivalAirportName'},{av:'Z31FlightArrivalCountryId'},{av:'Z33FlightArrivalCityId'},{av:'Z32FlightArrivalCountryName'},{av:'Z34FlightArrivalCityName'},{av:'Z23FlightDepartureAirportName'},{av:'Z27FlightDepartureCountryId'},{av:'Z29FlightDepartureCityId'},{av:'Z28FlightDepartureCountryName'},{av:'Z30FlightDepartureCityName'},{ctrl:'BTN_DELETE',prop:'Enabled'},{ctrl:'BTN_ENTER',prop:'Enabled'}]}");
         setEventMetadata("VALID_FLIGHTARRIVALAIRPORTID","{handler:'Valid_Flightarrivalairportid',iparms:[{av:'A25FlightArrivalAirportId',fld:'FLIGHTARRIVALAIRPORTID',pic:'ZZZ9'},{av:'A31FlightArrivalCountryId',fld:'FLIGHTARRIVALCOUNTRYID',pic:'ZZZ9'},{av:'A33FlightArrivalCityId',fld:'FLIGHTARRIVALCITYID',pic:'ZZZ9'},{av:'A26FlightArrivalAirportName',fld:'FLIGHTARRIVALAIRPORTNAME',pic:''},{av:'A32FlightArrivalCountryName',fld:'FLIGHTARRIVALCOUNTRYNAME',pic:''},{av:'A34FlightArrivalCityName',fld:'FLIGHTARRIVALCITYNAME',pic:''}]");
         setEventMetadata("VALID_FLIGHTARRIVALAIRPORTID",",oparms:[{av:'A26FlightArrivalAirportName',fld:'FLIGHTARRIVALAIRPORTNAME',pic:''},{av:'A31FlightArrivalCountryId',fld:'FLIGHTARRIVALCOUNTRYID',pic:'ZZZ9'},{av:'A33FlightArrivalCityId',fld:'FLIGHTARRIVALCITYID',pic:'ZZZ9'},{av:'A32FlightArrivalCountryName',fld:'FLIGHTARRIVALCOUNTRYNAME',pic:''},{av:'A34FlightArrivalCityName',fld:'FLIGHTARRIVALCITYNAME',pic:''}]}");
         setEventMetadata("VALID_FLIGHTARRIVALCOUNTRYID","{handler:'Valid_Flightarrivalcountryid',iparms:[]");
         setEventMetadata("VALID_FLIGHTARRIVALCOUNTRYID",",oparms:[]}");
         setEventMetadata("VALID_FLIGHTARRIVALCITYID","{handler:'Valid_Flightarrivalcityid',iparms:[]");
         setEventMetadata("VALID_FLIGHTARRIVALCITYID",",oparms:[]}");
         setEventMetadata("VALID_FLIGHTDEPARTUREAIRPORTID","{handler:'Valid_Flightdepartureairportid',iparms:[{av:'A24FlightDepartureAirportId',fld:'FLIGHTDEPARTUREAIRPORTID',pic:'ZZZ9'},{av:'A27FlightDepartureCountryId',fld:'FLIGHTDEPARTURECOUNTRYID',pic:'ZZZ9'},{av:'A29FlightDepartureCityId',fld:'FLIGHTDEPARTURECITYID',pic:'ZZZ9'},{av:'A23FlightDepartureAirportName',fld:'FLIGHTDEPARTUREAIRPORTNAME',pic:''},{av:'A28FlightDepartureCountryName',fld:'FLIGHTDEPARTURECOUNTRYNAME',pic:''},{av:'A30FlightDepartureCityName',fld:'FLIGHTDEPARTURECITYNAME',pic:''}]");
         setEventMetadata("VALID_FLIGHTDEPARTUREAIRPORTID",",oparms:[{av:'A23FlightDepartureAirportName',fld:'FLIGHTDEPARTUREAIRPORTNAME',pic:''},{av:'A27FlightDepartureCountryId',fld:'FLIGHTDEPARTURECOUNTRYID',pic:'ZZZ9'},{av:'A29FlightDepartureCityId',fld:'FLIGHTDEPARTURECITYID',pic:'ZZZ9'},{av:'A28FlightDepartureCountryName',fld:'FLIGHTDEPARTURECOUNTRYNAME',pic:''},{av:'A30FlightDepartureCityName',fld:'FLIGHTDEPARTURECITYNAME',pic:''}]}");
         setEventMetadata("VALID_FLIGHTDEPARTURECOUNTRYID","{handler:'Valid_Flightdeparturecountryid',iparms:[]");
         setEventMetadata("VALID_FLIGHTDEPARTURECOUNTRYID",",oparms:[]}");
         setEventMetadata("VALID_FLIGHTDEPARTURECITYID","{handler:'Valid_Flightdeparturecityid',iparms:[]");
         setEventMetadata("VALID_FLIGHTDEPARTURECITYID",",oparms:[]}");
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
         pr_default.close(1);
         pr_default.close(21);
         pr_default.close(24);
         pr_default.close(22);
         pr_default.close(23);
         pr_default.close(25);
         pr_default.close(26);
      }

      public override void initialize( )
      {
         sPrefix = "";
         scmdbuf = "";
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         GXKey = "";
         PreviousTooltip = "";
         PreviousCaption = "";
         Form = new GXWebForm();
         GX_FocusControl = "";
         lblTitle_Jsonclick = "";
         ClassString = "";
         StyleString = "";
         TempTags = "";
         bttBtn_first_Jsonclick = "";
         bttBtn_previous_Jsonclick = "";
         bttBtn_next_Jsonclick = "";
         bttBtn_last_Jsonclick = "";
         bttBtn_select_Jsonclick = "";
         imgprompt_25_gximage = "";
         sImgUrl = "";
         A26FlightArrivalAirportName = "";
         A32FlightArrivalCountryName = "";
         A34FlightArrivalCityName = "";
         imgprompt_24_gximage = "";
         A23FlightDepartureAirportName = "";
         A28FlightDepartureCountryName = "";
         A30FlightDepartureCityName = "";
         bttBtn_enter_Jsonclick = "";
         bttBtn_cancel_Jsonclick = "";
         bttBtn_delete_Jsonclick = "";
         Gx_mode = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         endTrnMsgTxt = "";
         endTrnMsgCod = "";
         Z26FlightArrivalAirportName = "";
         Z32FlightArrivalCountryName = "";
         Z34FlightArrivalCityName = "";
         Z23FlightDepartureAirportName = "";
         Z28FlightDepartureCountryName = "";
         Z30FlightDepartureCityName = "";
         T000510_A19FlightId = new short[1] ;
         T000510_A26FlightArrivalAirportName = new string[] {""} ;
         T000510_A32FlightArrivalCountryName = new string[] {""} ;
         T000510_A34FlightArrivalCityName = new string[] {""} ;
         T000510_A23FlightDepartureAirportName = new string[] {""} ;
         T000510_A28FlightDepartureCountryName = new string[] {""} ;
         T000510_A30FlightDepartureCityName = new string[] {""} ;
         T000510_A25FlightArrivalAirportId = new short[1] ;
         T000510_A24FlightDepartureAirportId = new short[1] ;
         T000510_A31FlightArrivalCountryId = new short[1] ;
         T000510_A33FlightArrivalCityId = new short[1] ;
         T000510_A27FlightDepartureCountryId = new short[1] ;
         T000510_A29FlightDepartureCityId = new short[1] ;
         T00054_A26FlightArrivalAirportName = new string[] {""} ;
         T00054_A31FlightArrivalCountryId = new short[1] ;
         T00054_A33FlightArrivalCityId = new short[1] ;
         T00056_A32FlightArrivalCountryName = new string[] {""} ;
         T00057_A34FlightArrivalCityName = new string[] {""} ;
         T00055_A23FlightDepartureAirportName = new string[] {""} ;
         T00055_A27FlightDepartureCountryId = new short[1] ;
         T00055_A29FlightDepartureCityId = new short[1] ;
         T00058_A28FlightDepartureCountryName = new string[] {""} ;
         T00059_A30FlightDepartureCityName = new string[] {""} ;
         T000511_A26FlightArrivalAirportName = new string[] {""} ;
         T000511_A31FlightArrivalCountryId = new short[1] ;
         T000511_A33FlightArrivalCityId = new short[1] ;
         T000512_A32FlightArrivalCountryName = new string[] {""} ;
         T000513_A34FlightArrivalCityName = new string[] {""} ;
         T000514_A23FlightDepartureAirportName = new string[] {""} ;
         T000514_A27FlightDepartureCountryId = new short[1] ;
         T000514_A29FlightDepartureCityId = new short[1] ;
         T000515_A28FlightDepartureCountryName = new string[] {""} ;
         T000516_A30FlightDepartureCityName = new string[] {""} ;
         T000517_A19FlightId = new short[1] ;
         T00053_A19FlightId = new short[1] ;
         T00053_A25FlightArrivalAirportId = new short[1] ;
         T00053_A24FlightDepartureAirportId = new short[1] ;
         sMode6 = "";
         T000518_A19FlightId = new short[1] ;
         T000519_A19FlightId = new short[1] ;
         T00052_A19FlightId = new short[1] ;
         T00052_A25FlightArrivalAirportId = new short[1] ;
         T00052_A24FlightDepartureAirportId = new short[1] ;
         T000520_A19FlightId = new short[1] ;
         T000523_A26FlightArrivalAirportName = new string[] {""} ;
         T000523_A31FlightArrivalCountryId = new short[1] ;
         T000523_A33FlightArrivalCityId = new short[1] ;
         T000524_A32FlightArrivalCountryName = new string[] {""} ;
         T000525_A34FlightArrivalCityName = new string[] {""} ;
         T000526_A23FlightDepartureAirportName = new string[] {""} ;
         T000526_A27FlightDepartureCountryId = new short[1] ;
         T000526_A29FlightDepartureCityId = new short[1] ;
         T000527_A28FlightDepartureCountryName = new string[] {""} ;
         T000528_A30FlightDepartureCityName = new string[] {""} ;
         T000529_A19FlightId = new short[1] ;
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         ZZ26FlightArrivalAirportName = "";
         ZZ32FlightArrivalCountryName = "";
         ZZ34FlightArrivalCityName = "";
         ZZ23FlightDepartureAirportName = "";
         ZZ28FlightDepartureCountryName = "";
         ZZ30FlightDepartureCityName = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.flight__default(),
            new Object[][] {
                new Object[] {
               T00052_A19FlightId, T00052_A25FlightArrivalAirportId, T00052_A24FlightDepartureAirportId
               }
               , new Object[] {
               T00053_A19FlightId, T00053_A25FlightArrivalAirportId, T00053_A24FlightDepartureAirportId
               }
               , new Object[] {
               T00054_A26FlightArrivalAirportName, T00054_A31FlightArrivalCountryId, T00054_A33FlightArrivalCityId
               }
               , new Object[] {
               T00055_A23FlightDepartureAirportName, T00055_A27FlightDepartureCountryId, T00055_A29FlightDepartureCityId
               }
               , new Object[] {
               T00056_A32FlightArrivalCountryName
               }
               , new Object[] {
               T00057_A34FlightArrivalCityName
               }
               , new Object[] {
               T00058_A28FlightDepartureCountryName
               }
               , new Object[] {
               T00059_A30FlightDepartureCityName
               }
               , new Object[] {
               T000510_A19FlightId, T000510_A26FlightArrivalAirportName, T000510_A32FlightArrivalCountryName, T000510_A34FlightArrivalCityName, T000510_A23FlightDepartureAirportName, T000510_A28FlightDepartureCountryName, T000510_A30FlightDepartureCityName, T000510_A25FlightArrivalAirportId, T000510_A24FlightDepartureAirportId, T000510_A31FlightArrivalCountryId,
               T000510_A33FlightArrivalCityId, T000510_A27FlightDepartureCountryId, T000510_A29FlightDepartureCityId
               }
               , new Object[] {
               T000511_A26FlightArrivalAirportName, T000511_A31FlightArrivalCountryId, T000511_A33FlightArrivalCityId
               }
               , new Object[] {
               T000512_A32FlightArrivalCountryName
               }
               , new Object[] {
               T000513_A34FlightArrivalCityName
               }
               , new Object[] {
               T000514_A23FlightDepartureAirportName, T000514_A27FlightDepartureCountryId, T000514_A29FlightDepartureCityId
               }
               , new Object[] {
               T000515_A28FlightDepartureCountryName
               }
               , new Object[] {
               T000516_A30FlightDepartureCityName
               }
               , new Object[] {
               T000517_A19FlightId
               }
               , new Object[] {
               T000518_A19FlightId
               }
               , new Object[] {
               T000519_A19FlightId
               }
               , new Object[] {
               T000520_A19FlightId
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000523_A26FlightArrivalAirportName, T000523_A31FlightArrivalCountryId, T000523_A33FlightArrivalCityId
               }
               , new Object[] {
               T000524_A32FlightArrivalCountryName
               }
               , new Object[] {
               T000525_A34FlightArrivalCityName
               }
               , new Object[] {
               T000526_A23FlightDepartureAirportName, T000526_A27FlightDepartureCountryId, T000526_A29FlightDepartureCityId
               }
               , new Object[] {
               T000527_A28FlightDepartureCountryName
               }
               , new Object[] {
               T000528_A30FlightDepartureCityName
               }
               , new Object[] {
               T000529_A19FlightId
               }
            }
         );
      }

      private short Z19FlightId ;
      private short Z25FlightArrivalAirportId ;
      private short Z24FlightDepartureAirportId ;
      private short GxWebError ;
      private short A25FlightArrivalAirportId ;
      private short A31FlightArrivalCountryId ;
      private short A33FlightArrivalCityId ;
      private short A24FlightDepartureAirportId ;
      private short A27FlightDepartureCountryId ;
      private short A29FlightDepartureCityId ;
      private short gxcookieaux ;
      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short initialized ;
      private short A19FlightId ;
      private short GX_JID ;
      private short Z31FlightArrivalCountryId ;
      private short Z33FlightArrivalCityId ;
      private short Z27FlightDepartureCountryId ;
      private short Z29FlightDepartureCityId ;
      private short RcdFound6 ;
      private short nIsDirty_6 ;
      private short Gx_BScreen ;
      private short gxajaxcallmode ;
      private short ZZ19FlightId ;
      private short ZZ25FlightArrivalAirportId ;
      private short ZZ24FlightDepartureAirportId ;
      private short ZZ31FlightArrivalCountryId ;
      private short ZZ33FlightArrivalCityId ;
      private short ZZ27FlightDepartureCountryId ;
      private short ZZ29FlightDepartureCityId ;
      private int trnEnded ;
      private int bttBtn_first_Visible ;
      private int bttBtn_previous_Visible ;
      private int bttBtn_next_Visible ;
      private int bttBtn_last_Visible ;
      private int bttBtn_select_Visible ;
      private int edtFlightId_Enabled ;
      private int edtFlightArrivalAirportId_Enabled ;
      private int imgprompt_25_Visible ;
      private int edtFlightArrivalAirportName_Enabled ;
      private int edtFlightArrivalCountryId_Enabled ;
      private int edtFlightArrivalCountryName_Enabled ;
      private int edtFlightArrivalCityId_Enabled ;
      private int edtFlightArrivalCityName_Enabled ;
      private int edtFlightDepartureAirportId_Enabled ;
      private int imgprompt_24_Visible ;
      private int edtFlightDepartureAirportName_Enabled ;
      private int edtFlightDepartureCountryId_Enabled ;
      private int edtFlightDepartureCountryName_Enabled ;
      private int edtFlightDepartureCityId_Enabled ;
      private int edtFlightDepartureCityName_Enabled ;
      private int bttBtn_enter_Visible ;
      private int bttBtn_enter_Enabled ;
      private int bttBtn_cancel_Visible ;
      private int bttBtn_delete_Visible ;
      private int bttBtn_delete_Enabled ;
      private int idxLst ;
      private string sPrefix ;
      private string scmdbuf ;
      private string gxfirstwebparm ;
      private string gxfirstwebparm_bkp ;
      private string GXKey ;
      private string PreviousTooltip ;
      private string PreviousCaption ;
      private string GX_FocusControl ;
      private string edtFlightId_Internalname ;
      private string divMaintable_Internalname ;
      private string divTitlecontainer_Internalname ;
      private string lblTitle_Internalname ;
      private string lblTitle_Jsonclick ;
      private string ClassString ;
      private string StyleString ;
      private string divFormcontainer_Internalname ;
      private string divToolbarcell_Internalname ;
      private string TempTags ;
      private string bttBtn_first_Internalname ;
      private string bttBtn_first_Jsonclick ;
      private string bttBtn_previous_Internalname ;
      private string bttBtn_previous_Jsonclick ;
      private string bttBtn_next_Internalname ;
      private string bttBtn_next_Jsonclick ;
      private string bttBtn_last_Internalname ;
      private string bttBtn_last_Jsonclick ;
      private string bttBtn_select_Internalname ;
      private string bttBtn_select_Jsonclick ;
      private string edtFlightId_Jsonclick ;
      private string edtFlightArrivalAirportId_Internalname ;
      private string edtFlightArrivalAirportId_Jsonclick ;
      private string imgprompt_25_gximage ;
      private string sImgUrl ;
      private string imgprompt_25_Internalname ;
      private string imgprompt_25_Link ;
      private string edtFlightArrivalAirportName_Internalname ;
      private string edtFlightArrivalAirportName_Jsonclick ;
      private string edtFlightArrivalCountryId_Internalname ;
      private string edtFlightArrivalCountryId_Jsonclick ;
      private string edtFlightArrivalCountryName_Internalname ;
      private string edtFlightArrivalCountryName_Jsonclick ;
      private string edtFlightArrivalCityId_Internalname ;
      private string edtFlightArrivalCityId_Jsonclick ;
      private string edtFlightArrivalCityName_Internalname ;
      private string edtFlightArrivalCityName_Jsonclick ;
      private string edtFlightDepartureAirportId_Internalname ;
      private string edtFlightDepartureAirportId_Jsonclick ;
      private string imgprompt_24_gximage ;
      private string imgprompt_24_Internalname ;
      private string imgprompt_24_Link ;
      private string edtFlightDepartureAirportName_Internalname ;
      private string edtFlightDepartureAirportName_Jsonclick ;
      private string edtFlightDepartureCountryId_Internalname ;
      private string edtFlightDepartureCountryId_Jsonclick ;
      private string edtFlightDepartureCountryName_Internalname ;
      private string edtFlightDepartureCountryName_Jsonclick ;
      private string edtFlightDepartureCityId_Internalname ;
      private string edtFlightDepartureCityId_Jsonclick ;
      private string edtFlightDepartureCityName_Internalname ;
      private string edtFlightDepartureCityName_Jsonclick ;
      private string bttBtn_enter_Internalname ;
      private string bttBtn_enter_Jsonclick ;
      private string bttBtn_cancel_Internalname ;
      private string bttBtn_cancel_Jsonclick ;
      private string bttBtn_delete_Internalname ;
      private string bttBtn_delete_Jsonclick ;
      private string Gx_mode ;
      private string sEvt ;
      private string EvtGridId ;
      private string EvtRowId ;
      private string sEvtType ;
      private string endTrnMsgTxt ;
      private string endTrnMsgCod ;
      private string sMode6 ;
      private string sDynURL ;
      private string FormProcess ;
      private string bodyStyle ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool wbErr ;
      private string A26FlightArrivalAirportName ;
      private string A32FlightArrivalCountryName ;
      private string A34FlightArrivalCityName ;
      private string A23FlightDepartureAirportName ;
      private string A28FlightDepartureCountryName ;
      private string A30FlightDepartureCityName ;
      private string Z26FlightArrivalAirportName ;
      private string Z32FlightArrivalCountryName ;
      private string Z34FlightArrivalCityName ;
      private string Z23FlightDepartureAirportName ;
      private string Z28FlightDepartureCountryName ;
      private string Z30FlightDepartureCityName ;
      private string ZZ26FlightArrivalAirportName ;
      private string ZZ32FlightArrivalCountryName ;
      private string ZZ34FlightArrivalCityName ;
      private string ZZ23FlightDepartureAirportName ;
      private string ZZ28FlightDepartureCountryName ;
      private string ZZ30FlightDepartureCityName ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private short[] T000510_A19FlightId ;
      private string[] T000510_A26FlightArrivalAirportName ;
      private string[] T000510_A32FlightArrivalCountryName ;
      private string[] T000510_A34FlightArrivalCityName ;
      private string[] T000510_A23FlightDepartureAirportName ;
      private string[] T000510_A28FlightDepartureCountryName ;
      private string[] T000510_A30FlightDepartureCityName ;
      private short[] T000510_A25FlightArrivalAirportId ;
      private short[] T000510_A24FlightDepartureAirportId ;
      private short[] T000510_A31FlightArrivalCountryId ;
      private short[] T000510_A33FlightArrivalCityId ;
      private short[] T000510_A27FlightDepartureCountryId ;
      private short[] T000510_A29FlightDepartureCityId ;
      private string[] T00054_A26FlightArrivalAirportName ;
      private short[] T00054_A31FlightArrivalCountryId ;
      private short[] T00054_A33FlightArrivalCityId ;
      private string[] T00056_A32FlightArrivalCountryName ;
      private string[] T00057_A34FlightArrivalCityName ;
      private string[] T00055_A23FlightDepartureAirportName ;
      private short[] T00055_A27FlightDepartureCountryId ;
      private short[] T00055_A29FlightDepartureCityId ;
      private string[] T00058_A28FlightDepartureCountryName ;
      private string[] T00059_A30FlightDepartureCityName ;
      private string[] T000511_A26FlightArrivalAirportName ;
      private short[] T000511_A31FlightArrivalCountryId ;
      private short[] T000511_A33FlightArrivalCityId ;
      private string[] T000512_A32FlightArrivalCountryName ;
      private string[] T000513_A34FlightArrivalCityName ;
      private string[] T000514_A23FlightDepartureAirportName ;
      private short[] T000514_A27FlightDepartureCountryId ;
      private short[] T000514_A29FlightDepartureCityId ;
      private string[] T000515_A28FlightDepartureCountryName ;
      private string[] T000516_A30FlightDepartureCityName ;
      private short[] T000517_A19FlightId ;
      private short[] T00053_A19FlightId ;
      private short[] T00053_A25FlightArrivalAirportId ;
      private short[] T00053_A24FlightDepartureAirportId ;
      private short[] T000518_A19FlightId ;
      private short[] T000519_A19FlightId ;
      private short[] T00052_A19FlightId ;
      private short[] T00052_A25FlightArrivalAirportId ;
      private short[] T00052_A24FlightDepartureAirportId ;
      private short[] T000520_A19FlightId ;
      private string[] T000523_A26FlightArrivalAirportName ;
      private short[] T000523_A31FlightArrivalCountryId ;
      private short[] T000523_A33FlightArrivalCityId ;
      private string[] T000524_A32FlightArrivalCountryName ;
      private string[] T000525_A34FlightArrivalCityName ;
      private string[] T000526_A23FlightDepartureAirportName ;
      private short[] T000526_A27FlightDepartureCountryId ;
      private short[] T000526_A29FlightDepartureCityId ;
      private string[] T000527_A28FlightDepartureCountryName ;
      private string[] T000528_A30FlightDepartureCityName ;
      private short[] T000529_A19FlightId ;
      private GXWebForm Form ;
   }

   public class flight__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
         ,new ForEachCursor(def[1])
         ,new ForEachCursor(def[2])
         ,new ForEachCursor(def[3])
         ,new ForEachCursor(def[4])
         ,new ForEachCursor(def[5])
         ,new ForEachCursor(def[6])
         ,new ForEachCursor(def[7])
         ,new ForEachCursor(def[8])
         ,new ForEachCursor(def[9])
         ,new ForEachCursor(def[10])
         ,new ForEachCursor(def[11])
         ,new ForEachCursor(def[12])
         ,new ForEachCursor(def[13])
         ,new ForEachCursor(def[14])
         ,new ForEachCursor(def[15])
         ,new ForEachCursor(def[16])
         ,new ForEachCursor(def[17])
         ,new ForEachCursor(def[18])
         ,new UpdateCursor(def[19])
         ,new UpdateCursor(def[20])
         ,new ForEachCursor(def[21])
         ,new ForEachCursor(def[22])
         ,new ForEachCursor(def[23])
         ,new ForEachCursor(def[24])
         ,new ForEachCursor(def[25])
         ,new ForEachCursor(def[26])
         ,new ForEachCursor(def[27])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmT000510;
          prmT000510 = new Object[] {
          new ParDef("@FlightId",GXType.Int16,4,0)
          };
          Object[] prmT00054;
          prmT00054 = new Object[] {
          new ParDef("@FlightArrivalAirportId",GXType.Int16,4,0)
          };
          Object[] prmT00056;
          prmT00056 = new Object[] {
          new ParDef("@FlightArrivalCountryId",GXType.Int16,4,0)
          };
          Object[] prmT00057;
          prmT00057 = new Object[] {
          new ParDef("@FlightArrivalCountryId",GXType.Int16,4,0) ,
          new ParDef("@FlightArrivalCityId",GXType.Int16,4,0)
          };
          Object[] prmT00055;
          prmT00055 = new Object[] {
          new ParDef("@FlightDepartureAirportId",GXType.Int16,4,0)
          };
          Object[] prmT00058;
          prmT00058 = new Object[] {
          new ParDef("@FlightDepartureCountryId",GXType.Int16,4,0)
          };
          Object[] prmT00059;
          prmT00059 = new Object[] {
          new ParDef("@FlightDepartureCountryId",GXType.Int16,4,0) ,
          new ParDef("@FlightDepartureCityId",GXType.Int16,4,0)
          };
          Object[] prmT000511;
          prmT000511 = new Object[] {
          new ParDef("@FlightArrivalAirportId",GXType.Int16,4,0)
          };
          Object[] prmT000512;
          prmT000512 = new Object[] {
          new ParDef("@FlightArrivalCountryId",GXType.Int16,4,0)
          };
          Object[] prmT000513;
          prmT000513 = new Object[] {
          new ParDef("@FlightArrivalCountryId",GXType.Int16,4,0) ,
          new ParDef("@FlightArrivalCityId",GXType.Int16,4,0)
          };
          Object[] prmT000514;
          prmT000514 = new Object[] {
          new ParDef("@FlightDepartureAirportId",GXType.Int16,4,0)
          };
          Object[] prmT000515;
          prmT000515 = new Object[] {
          new ParDef("@FlightDepartureCountryId",GXType.Int16,4,0)
          };
          Object[] prmT000516;
          prmT000516 = new Object[] {
          new ParDef("@FlightDepartureCountryId",GXType.Int16,4,0) ,
          new ParDef("@FlightDepartureCityId",GXType.Int16,4,0)
          };
          Object[] prmT000517;
          prmT000517 = new Object[] {
          new ParDef("@FlightId",GXType.Int16,4,0)
          };
          Object[] prmT00053;
          prmT00053 = new Object[] {
          new ParDef("@FlightId",GXType.Int16,4,0)
          };
          Object[] prmT000518;
          prmT000518 = new Object[] {
          new ParDef("@FlightId",GXType.Int16,4,0)
          };
          Object[] prmT000519;
          prmT000519 = new Object[] {
          new ParDef("@FlightId",GXType.Int16,4,0)
          };
          Object[] prmT00052;
          prmT00052 = new Object[] {
          new ParDef("@FlightId",GXType.Int16,4,0)
          };
          Object[] prmT000520;
          prmT000520 = new Object[] {
          new ParDef("@FlightArrivalAirportId",GXType.Int16,4,0) ,
          new ParDef("@FlightDepartureAirportId",GXType.Int16,4,0)
          };
          Object[] prmT000521;
          prmT000521 = new Object[] {
          new ParDef("@FlightArrivalAirportId",GXType.Int16,4,0) ,
          new ParDef("@FlightDepartureAirportId",GXType.Int16,4,0) ,
          new ParDef("@FlightId",GXType.Int16,4,0)
          };
          Object[] prmT000522;
          prmT000522 = new Object[] {
          new ParDef("@FlightId",GXType.Int16,4,0)
          };
          Object[] prmT000529;
          prmT000529 = new Object[] {
          };
          Object[] prmT000523;
          prmT000523 = new Object[] {
          new ParDef("@FlightArrivalAirportId",GXType.Int16,4,0)
          };
          Object[] prmT000524;
          prmT000524 = new Object[] {
          new ParDef("@FlightArrivalCountryId",GXType.Int16,4,0)
          };
          Object[] prmT000525;
          prmT000525 = new Object[] {
          new ParDef("@FlightArrivalCountryId",GXType.Int16,4,0) ,
          new ParDef("@FlightArrivalCityId",GXType.Int16,4,0)
          };
          Object[] prmT000526;
          prmT000526 = new Object[] {
          new ParDef("@FlightDepartureAirportId",GXType.Int16,4,0)
          };
          Object[] prmT000527;
          prmT000527 = new Object[] {
          new ParDef("@FlightDepartureCountryId",GXType.Int16,4,0)
          };
          Object[] prmT000528;
          prmT000528 = new Object[] {
          new ParDef("@FlightDepartureCountryId",GXType.Int16,4,0) ,
          new ParDef("@FlightDepartureCityId",GXType.Int16,4,0)
          };
          def= new CursorDef[] {
              new CursorDef("T00052", "SELECT [FlightId], [FlightArrivalAirportId] AS FlightArrivalAirportId, [FlightDepartureAirportId] AS FlightDepartureAirportId FROM [Flight] WITH (UPDLOCK) WHERE [FlightId] = @FlightId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00052,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T00053", "SELECT [FlightId], [FlightArrivalAirportId] AS FlightArrivalAirportId, [FlightDepartureAirportId] AS FlightDepartureAirportId FROM [Flight] WHERE [FlightId] = @FlightId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00053,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T00054", "SELECT [AirportName] AS FlightArrivalAirportName, [CountryId] AS FlightArrivalCountryId, [CityId] AS FlightArrivalCityId FROM [Airport] WHERE [AirportId] = @FlightArrivalAirportId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00054,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T00055", "SELECT [AirportName] AS FlightDepartureAirportName, [CountryId] AS FlightDepartureCountryId, [CityId] AS FlightDepartureCityId FROM [Airport] WHERE [AirportId] = @FlightDepartureAirportId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00055,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T00056", "SELECT [CountryName] AS FlightArrivalCountryName FROM [Country] WHERE [CountryId] = @FlightArrivalCountryId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00056,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T00057", "SELECT [CityName] AS FlightArrivalCityName FROM [CountryCity] WHERE [CountryId] = @FlightArrivalCountryId AND [CityId] = @FlightArrivalCityId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00057,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T00058", "SELECT [CountryName] AS FlightDepartureCountryName FROM [Country] WHERE [CountryId] = @FlightDepartureCountryId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00058,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T00059", "SELECT [CityName] AS FlightDepartureCityName FROM [CountryCity] WHERE [CountryId] = @FlightDepartureCountryId AND [CityId] = @FlightDepartureCityId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00059,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T000510", "SELECT TM1.[FlightId], T2.[AirportName] AS FlightArrivalAirportName, T3.[CountryName] AS FlightArrivalCountryName, T4.[CityName] AS FlightArrivalCityName, T5.[AirportName] AS FlightDepartureAirportName, T6.[CountryName] AS FlightDepartureCountryName, T7.[CityName] AS FlightDepartureCityName, TM1.[FlightArrivalAirportId] AS FlightArrivalAirportId, TM1.[FlightDepartureAirportId] AS FlightDepartureAirportId, T2.[CountryId] AS FlightArrivalCountryId, T2.[CityId] AS FlightArrivalCityId, T5.[CountryId] AS FlightDepartureCountryId, T5.[CityId] AS FlightDepartureCityId FROM (((((([Flight] TM1 INNER JOIN [Airport] T2 ON T2.[AirportId] = TM1.[FlightArrivalAirportId]) INNER JOIN [Country] T3 ON T3.[CountryId] = T2.[CountryId]) INNER JOIN [CountryCity] T4 ON T4.[CountryId] = T2.[CountryId] AND T4.[CityId] = T2.[CityId]) INNER JOIN [Airport] T5 ON T5.[AirportId] = TM1.[FlightDepartureAirportId]) INNER JOIN [Country] T6 ON T6.[CountryId] = T5.[CountryId]) INNER JOIN [CountryCity] T7 ON T7.[CountryId] = T5.[CountryId] AND T7.[CityId] = T5.[CityId]) WHERE TM1.[FlightId] = @FlightId ORDER BY TM1.[FlightId]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000510,100, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T000511", "SELECT [AirportName] AS FlightArrivalAirportName, [CountryId] AS FlightArrivalCountryId, [CityId] AS FlightArrivalCityId FROM [Airport] WHERE [AirportId] = @FlightArrivalAirportId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000511,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T000512", "SELECT [CountryName] AS FlightArrivalCountryName FROM [Country] WHERE [CountryId] = @FlightArrivalCountryId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000512,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T000513", "SELECT [CityName] AS FlightArrivalCityName FROM [CountryCity] WHERE [CountryId] = @FlightArrivalCountryId AND [CityId] = @FlightArrivalCityId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000513,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T000514", "SELECT [AirportName] AS FlightDepartureAirportName, [CountryId] AS FlightDepartureCountryId, [CityId] AS FlightDepartureCityId FROM [Airport] WHERE [AirportId] = @FlightDepartureAirportId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000514,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T000515", "SELECT [CountryName] AS FlightDepartureCountryName FROM [Country] WHERE [CountryId] = @FlightDepartureCountryId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000515,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T000516", "SELECT [CityName] AS FlightDepartureCityName FROM [CountryCity] WHERE [CountryId] = @FlightDepartureCountryId AND [CityId] = @FlightDepartureCityId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000516,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T000517", "SELECT [FlightId] FROM [Flight] WHERE [FlightId] = @FlightId  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000517,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T000518", "SELECT TOP 1 [FlightId] FROM [Flight] WHERE ( [FlightId] > @FlightId) ORDER BY [FlightId]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000518,1, GxCacheFrequency.OFF ,true,true )
             ,new CursorDef("T000519", "SELECT TOP 1 [FlightId] FROM [Flight] WHERE ( [FlightId] < @FlightId) ORDER BY [FlightId] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000519,1, GxCacheFrequency.OFF ,true,true )
             ,new CursorDef("T000520", "INSERT INTO [Flight]([FlightArrivalAirportId], [FlightDepartureAirportId]) VALUES(@FlightArrivalAirportId, @FlightDepartureAirportId); SELECT SCOPE_IDENTITY()",true, GxErrorMask.GX_NOMASK, false, this,prmT000520,1, GxCacheFrequency.OFF ,true,true )
             ,new CursorDef("T000521", "UPDATE [Flight] SET [FlightArrivalAirportId]=@FlightArrivalAirportId, [FlightDepartureAirportId]=@FlightDepartureAirportId  WHERE [FlightId] = @FlightId", GxErrorMask.GX_NOMASK,prmT000521)
             ,new CursorDef("T000522", "DELETE FROM [Flight]  WHERE [FlightId] = @FlightId", GxErrorMask.GX_NOMASK,prmT000522)
             ,new CursorDef("T000523", "SELECT [AirportName] AS FlightArrivalAirportName, [CountryId] AS FlightArrivalCountryId, [CityId] AS FlightArrivalCityId FROM [Airport] WHERE [AirportId] = @FlightArrivalAirportId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000523,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T000524", "SELECT [CountryName] AS FlightArrivalCountryName FROM [Country] WHERE [CountryId] = @FlightArrivalCountryId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000524,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T000525", "SELECT [CityName] AS FlightArrivalCityName FROM [CountryCity] WHERE [CountryId] = @FlightArrivalCountryId AND [CityId] = @FlightArrivalCityId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000525,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T000526", "SELECT [AirportName] AS FlightDepartureAirportName, [CountryId] AS FlightDepartureCountryId, [CityId] AS FlightDepartureCityId FROM [Airport] WHERE [AirportId] = @FlightDepartureAirportId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000526,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T000527", "SELECT [CountryName] AS FlightDepartureCountryName FROM [Country] WHERE [CountryId] = @FlightDepartureCountryId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000527,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T000528", "SELECT [CityName] AS FlightDepartureCityName FROM [CountryCity] WHERE [CountryId] = @FlightDepartureCountryId AND [CityId] = @FlightDepartureCityId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000528,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T000529", "SELECT [FlightId] FROM [Flight] ORDER BY [FlightId]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000529,100, GxCacheFrequency.OFF ,true,false )
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
                ((short[]) buf[2])[0] = rslt.getShort(3);
                return;
             case 1 :
                ((short[]) buf[0])[0] = rslt.getShort(1);
                ((short[]) buf[1])[0] = rslt.getShort(2);
                ((short[]) buf[2])[0] = rslt.getShort(3);
                return;
             case 2 :
                ((string[]) buf[0])[0] = rslt.getVarchar(1);
                ((short[]) buf[1])[0] = rslt.getShort(2);
                ((short[]) buf[2])[0] = rslt.getShort(3);
                return;
             case 3 :
                ((string[]) buf[0])[0] = rslt.getVarchar(1);
                ((short[]) buf[1])[0] = rslt.getShort(2);
                ((short[]) buf[2])[0] = rslt.getShort(3);
                return;
             case 4 :
                ((string[]) buf[0])[0] = rslt.getVarchar(1);
                return;
             case 5 :
                ((string[]) buf[0])[0] = rslt.getVarchar(1);
                return;
             case 6 :
                ((string[]) buf[0])[0] = rslt.getVarchar(1);
                return;
             case 7 :
                ((string[]) buf[0])[0] = rslt.getVarchar(1);
                return;
             case 8 :
                ((short[]) buf[0])[0] = rslt.getShort(1);
                ((string[]) buf[1])[0] = rslt.getVarchar(2);
                ((string[]) buf[2])[0] = rslt.getVarchar(3);
                ((string[]) buf[3])[0] = rslt.getVarchar(4);
                ((string[]) buf[4])[0] = rslt.getVarchar(5);
                ((string[]) buf[5])[0] = rslt.getVarchar(6);
                ((string[]) buf[6])[0] = rslt.getVarchar(7);
                ((short[]) buf[7])[0] = rslt.getShort(8);
                ((short[]) buf[8])[0] = rslt.getShort(9);
                ((short[]) buf[9])[0] = rslt.getShort(10);
                ((short[]) buf[10])[0] = rslt.getShort(11);
                ((short[]) buf[11])[0] = rslt.getShort(12);
                ((short[]) buf[12])[0] = rslt.getShort(13);
                return;
             case 9 :
                ((string[]) buf[0])[0] = rslt.getVarchar(1);
                ((short[]) buf[1])[0] = rslt.getShort(2);
                ((short[]) buf[2])[0] = rslt.getShort(3);
                return;
             case 10 :
                ((string[]) buf[0])[0] = rslt.getVarchar(1);
                return;
             case 11 :
                ((string[]) buf[0])[0] = rslt.getVarchar(1);
                return;
             case 12 :
                ((string[]) buf[0])[0] = rslt.getVarchar(1);
                ((short[]) buf[1])[0] = rslt.getShort(2);
                ((short[]) buf[2])[0] = rslt.getShort(3);
                return;
             case 13 :
                ((string[]) buf[0])[0] = rslt.getVarchar(1);
                return;
             case 14 :
                ((string[]) buf[0])[0] = rslt.getVarchar(1);
                return;
             case 15 :
                ((short[]) buf[0])[0] = rslt.getShort(1);
                return;
             case 16 :
                ((short[]) buf[0])[0] = rslt.getShort(1);
                return;
             case 17 :
                ((short[]) buf[0])[0] = rslt.getShort(1);
                return;
             case 18 :
                ((short[]) buf[0])[0] = rslt.getShort(1);
                return;
             case 21 :
                ((string[]) buf[0])[0] = rslt.getVarchar(1);
                ((short[]) buf[1])[0] = rslt.getShort(2);
                ((short[]) buf[2])[0] = rslt.getShort(3);
                return;
             case 22 :
                ((string[]) buf[0])[0] = rslt.getVarchar(1);
                return;
             case 23 :
                ((string[]) buf[0])[0] = rslt.getVarchar(1);
                return;
             case 24 :
                ((string[]) buf[0])[0] = rslt.getVarchar(1);
                ((short[]) buf[1])[0] = rslt.getShort(2);
                ((short[]) buf[2])[0] = rslt.getShort(3);
                return;
             case 25 :
                ((string[]) buf[0])[0] = rslt.getVarchar(1);
                return;
             case 26 :
                ((string[]) buf[0])[0] = rslt.getVarchar(1);
                return;
             case 27 :
                ((short[]) buf[0])[0] = rslt.getShort(1);
                return;
       }
    }

 }

}
