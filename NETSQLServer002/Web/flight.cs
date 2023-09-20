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
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_12") == 0 )
         {
            A19FlightId = (short)(Math.Round(NumberUtil.Val( GetPar( "FlightId"), "."), 18, MidpointRounding.ToEven));
            AssignAttri("", false, "A19FlightId", StringUtil.LTrimStr( (decimal)(A19FlightId), 4, 0));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxLoad_12( A19FlightId) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_6") == 0 )
         {
            A25FlightArrivalAirportId = (short)(Math.Round(NumberUtil.Val( GetPar( "FlightArrivalAirportId"), "."), 18, MidpointRounding.ToEven));
            AssignAttri("", false, "A25FlightArrivalAirportId", StringUtil.LTrimStr( (decimal)(A25FlightArrivalAirportId), 4, 0));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxLoad_6( A25FlightArrivalAirportId) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_8") == 0 )
         {
            A31FlightArrivalCountryId = (short)(Math.Round(NumberUtil.Val( GetPar( "FlightArrivalCountryId"), "."), 18, MidpointRounding.ToEven));
            AssignAttri("", false, "A31FlightArrivalCountryId", StringUtil.LTrimStr( (decimal)(A31FlightArrivalCountryId), 4, 0));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxLoad_8( A31FlightArrivalCountryId) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_9") == 0 )
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
            gxLoad_9( A31FlightArrivalCountryId, A33FlightArrivalCityId) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_7") == 0 )
         {
            A24FlightDepartureAirportId = (short)(Math.Round(NumberUtil.Val( GetPar( "FlightDepartureAirportId"), "."), 18, MidpointRounding.ToEven));
            AssignAttri("", false, "A24FlightDepartureAirportId", StringUtil.LTrimStr( (decimal)(A24FlightDepartureAirportId), 4, 0));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxLoad_7( A24FlightDepartureAirportId) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_10") == 0 )
         {
            A27FlightDepartureCountryId = (short)(Math.Round(NumberUtil.Val( GetPar( "FlightDepartureCountryId"), "."), 18, MidpointRounding.ToEven));
            AssignAttri("", false, "A27FlightDepartureCountryId", StringUtil.LTrimStr( (decimal)(A27FlightDepartureCountryId), 4, 0));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxLoad_10( A27FlightDepartureCountryId) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_11") == 0 )
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
            gxLoad_11( A27FlightDepartureCountryId, A29FlightDepartureCityId) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_5") == 0 )
         {
            A38AirlineId = (short)(Math.Round(NumberUtil.Val( GetPar( "AirlineId"), "."), 18, MidpointRounding.ToEven));
            n38AirlineId = false;
            AssignAttri("", false, "A38AirlineId", StringUtil.LTrimStr( (decimal)(A38AirlineId), 4, 0));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxLoad_5( A38AirlineId) ;
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
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxNewRow_"+"Gridflight_seat") == 0 )
         {
            gxnrGridflight_seat_newrow_invoke( ) ;
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

      protected void gxnrGridflight_seat_newrow_invoke( )
      {
         nRC_GXsfl_138 = (int)(Math.Round(NumberUtil.Val( GetPar( "nRC_GXsfl_138"), "."), 18, MidpointRounding.ToEven));
         nGXsfl_138_idx = (int)(Math.Round(NumberUtil.Val( GetPar( "nGXsfl_138_idx"), "."), 18, MidpointRounding.ToEven));
         sGXsfl_138_idx = GetPar( "sGXsfl_138_idx");
         Gx_mode = GetPar( "Mode");
         setAjaxCallMode();
         if ( ! IsValidAjaxCall( true) )
         {
            GxWebError = 1;
            return  ;
         }
         gxnrGridflight_seat_newrow( ) ;
         /* End function gxnrGridflight_seat_newrow_invoke */
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
         cmbFlightSeatChar = new GXCombobox();
         cmbFlightSeatLocation = new GXCombobox();
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
         GxWebStd.gx_button_ctrl( context, bttBtn_select_Internalname, "", "Select", bttBtn_select_Jsonclick, 4, "Select", "", StyleString, ClassString, bttBtn_select_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ESELECT."+"'", TempTags, "gx.popup.openPrompt('"+"gx0090.aspx"+"',["+"{Ctrl:gx.dom.el('"+"FLIGHTID"+"'), id:'"+"FLIGHTID"+"'"+",IOType:'out',isKey:true,isLastKey:true}"+"],"+"null"+","+"'', false"+","+"true"+");"+"return false;", 2, "HLP_Flight.htm");
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
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "start", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 form__cell", "start", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "start", "top", ""+" data-gx-for=\""+edtFlightPrice_Internalname+"\"", "", "div");
         /* Attribute/Variable Label */
         GxWebStd.gx_label_element( context, edtFlightPrice_Internalname, "Price", "col-sm-3 AttributeLabel", 1, true, "");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "start", "top", "", "", "div");
         /* Single line edit */
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 99,'',false,'',0)\"";
         GxWebStd.gx_single_line_edit( context, edtFlightPrice_Internalname, StringUtil.LTrim( StringUtil.NToC( A35FlightPrice, 7, 2, ".", "")), StringUtil.LTrim( ((edtFlightPrice_Enabled!=0) ? context.localUtil.Format( A35FlightPrice, "ZZZ9.99") : context.localUtil.Format( A35FlightPrice, "ZZZ9.99"))), TempTags+" onchange=\""+"gx.num.valid_decimal( this, ',','.','2');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_decimal( this, ',','.','2');"+";gx.evt.onblur(this,99);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtFlightPrice_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtFlightPrice_Enabled, 0, "text", "", 7, "chr", 1, "row", 7, 0, 0, 0, 0, -1, 0, true, "Price", "end", false, "", "HLP_Flight.htm");
         GxWebStd.gx_div_end( context, "start", "top", "div");
         GxWebStd.gx_div_end( context, "start", "top", "div");
         GxWebStd.gx_div_end( context, "start", "top", "div");
         GxWebStd.gx_div_end( context, "start", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "start", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 form__cell", "start", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "start", "top", ""+" data-gx-for=\""+edtFlightDiscountPercentaje_Internalname+"\"", "", "div");
         /* Attribute/Variable Label */
         GxWebStd.gx_label_element( context, edtFlightDiscountPercentaje_Internalname, "Discount Percentaje", "col-sm-3 AttributeLabel", 1, true, "");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "start", "top", "", "", "div");
         /* Single line edit */
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 104,'',false,'',0)\"";
         GxWebStd.gx_single_line_edit( context, edtFlightDiscountPercentaje_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A36FlightDiscountPercentaje), 4, 0, ".", "")), StringUtil.LTrim( ((edtFlightDiscountPercentaje_Enabled!=0) ? context.localUtil.Format( (decimal)(A36FlightDiscountPercentaje), "ZZZ9") : context.localUtil.Format( (decimal)(A36FlightDiscountPercentaje), "ZZZ9"))), " dir=\"ltr\" inputmode=\"numeric\" pattern=\"[0-9]*\""+TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(this,104);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtFlightDiscountPercentaje_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtFlightDiscountPercentaje_Enabled, 0, "text", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 0, -1, 0, true, "Percentage", "end", false, "", "HLP_Flight.htm");
         GxWebStd.gx_div_end( context, "start", "top", "div");
         GxWebStd.gx_div_end( context, "start", "top", "div");
         GxWebStd.gx_div_end( context, "start", "top", "div");
         GxWebStd.gx_div_end( context, "start", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "start", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 form__cell", "start", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "start", "top", ""+" data-gx-for=\""+edtAirlineId_Internalname+"\"", "", "div");
         /* Attribute/Variable Label */
         GxWebStd.gx_label_element( context, edtAirlineId_Internalname, "Airline Id", "col-sm-3 AttributeLabel", 1, true, "");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "start", "top", "", "", "div");
         /* Single line edit */
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 109,'',false,'',0)\"";
         GxWebStd.gx_single_line_edit( context, edtAirlineId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A38AirlineId), 4, 0, ".", "")), StringUtil.LTrim( ((edtAirlineId_Enabled!=0) ? context.localUtil.Format( (decimal)(A38AirlineId), "ZZZ9") : context.localUtil.Format( (decimal)(A38AirlineId), "ZZZ9"))), " dir=\"ltr\" inputmode=\"numeric\" pattern=\"[0-9]*\""+TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(this,109);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtAirlineId_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtAirlineId_Enabled, 0, "text", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 0, -1, 0, true, "Id", "end", false, "", "HLP_Flight.htm");
         /* Static images/pictures */
         ClassString = "gx-prompt Image" + " " + ((StringUtil.StrCmp(imgprompt_38_gximage, "")==0) ? "" : "GX_Image_"+imgprompt_38_gximage+"_Class");
         StyleString = "";
         sImgUrl = (string)(context.GetImagePath( "prompt.gif", "", context.GetTheme( )));
         GxWebStd.gx_bitmap( context, imgprompt_38_Internalname, sImgUrl, imgprompt_38_Link, "", "", context.GetTheme( ), imgprompt_38_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "", "", "", "", "", 1, false, false, context.GetImageSrcSet( sImgUrl), "HLP_Flight.htm");
         GxWebStd.gx_div_end( context, "start", "top", "div");
         GxWebStd.gx_div_end( context, "start", "top", "div");
         GxWebStd.gx_div_end( context, "start", "top", "div");
         GxWebStd.gx_div_end( context, "start", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "start", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 form__cell", "start", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "start", "top", ""+" data-gx-for=\""+edtAirlineName_Internalname+"\"", "", "div");
         /* Attribute/Variable Label */
         GxWebStd.gx_label_element( context, edtAirlineName_Internalname, "Airline Name", "col-sm-3 AttributeLabel", 1, true, "");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "start", "top", "", "", "div");
         /* Single line edit */
         GxWebStd.gx_single_line_edit( context, edtAirlineName_Internalname, A39AirlineName, StringUtil.RTrim( context.localUtil.Format( A39AirlineName, "")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtAirlineName_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtAirlineName_Enabled, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 0, -1, -1, true, "Name", "start", true, "", "HLP_Flight.htm");
         GxWebStd.gx_div_end( context, "start", "top", "div");
         GxWebStd.gx_div_end( context, "start", "top", "div");
         GxWebStd.gx_div_end( context, "start", "top", "div");
         GxWebStd.gx_div_end( context, "start", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "start", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 form__cell", "start", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "start", "top", ""+" data-gx-for=\""+edtAirlineDiscountPercentage_Internalname+"\"", "", "div");
         /* Attribute/Variable Label */
         GxWebStd.gx_label_element( context, edtAirlineDiscountPercentage_Internalname, "Airline Discount Percentage", "col-sm-3 AttributeLabel", 1, true, "");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "start", "top", "", "", "div");
         /* Single line edit */
         GxWebStd.gx_single_line_edit( context, edtAirlineDiscountPercentage_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A40AirlineDiscountPercentage), 4, 0, ".", "")), StringUtil.LTrim( ((edtAirlineDiscountPercentage_Enabled!=0) ? context.localUtil.Format( (decimal)(A40AirlineDiscountPercentage), "ZZZ9") : context.localUtil.Format( (decimal)(A40AirlineDiscountPercentage), "ZZZ9"))), " dir=\"ltr\" inputmode=\"numeric\" pattern=\"[0-9]*\""+"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtAirlineDiscountPercentage_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtAirlineDiscountPercentage_Enabled, 0, "text", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 0, -1, 0, true, "Percentage", "end", false, "", "HLP_Flight.htm");
         GxWebStd.gx_div_end( context, "start", "top", "div");
         GxWebStd.gx_div_end( context, "start", "top", "div");
         GxWebStd.gx_div_end( context, "start", "top", "div");
         GxWebStd.gx_div_end( context, "start", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "start", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 form__cell", "start", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "start", "top", ""+" data-gx-for=\""+edtFlightFinalPrice_Internalname+"\"", "", "div");
         /* Attribute/Variable Label */
         GxWebStd.gx_label_element( context, edtFlightFinalPrice_Internalname, "Final Price", "col-sm-3 AttributeLabel", 1, true, "");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "start", "top", "", "", "div");
         /* Single line edit */
         GxWebStd.gx_single_line_edit( context, edtFlightFinalPrice_Internalname, StringUtil.LTrim( StringUtil.NToC( A37FlightFinalPrice, 7, 2, ".", "")), StringUtil.LTrim( ((edtFlightFinalPrice_Enabled!=0) ? context.localUtil.Format( A37FlightFinalPrice, "ZZZ9.99") : context.localUtil.Format( A37FlightFinalPrice, "ZZZ9.99"))), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtFlightFinalPrice_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtFlightFinalPrice_Enabled, 0, "text", "", 7, "chr", 1, "row", 7, 0, 0, 0, 0, -1, 0, true, "Price", "end", false, "", "HLP_Flight.htm");
         GxWebStd.gx_div_end( context, "start", "top", "div");
         GxWebStd.gx_div_end( context, "start", "top", "div");
         GxWebStd.gx_div_end( context, "start", "top", "div");
         GxWebStd.gx_div_end( context, "start", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "start", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 form__cell", "start", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "start", "top", ""+" data-gx-for=\""+edtFlightCapacity_Internalname+"\"", "", "div");
         /* Attribute/Variable Label */
         GxWebStd.gx_label_element( context, edtFlightCapacity_Internalname, "Capacity", "col-sm-3 AttributeLabel", 1, true, "");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "start", "top", "", "", "div");
         /* Single line edit */
         GxWebStd.gx_single_line_edit( context, edtFlightCapacity_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A45FlightCapacity), 4, 0, ".", "")), StringUtil.LTrim( ((edtFlightCapacity_Enabled!=0) ? context.localUtil.Format( (decimal)(A45FlightCapacity), "ZZZ9") : context.localUtil.Format( (decimal)(A45FlightCapacity), "ZZZ9"))), " dir=\"ltr\" inputmode=\"numeric\" pattern=\"[0-9]*\""+"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtFlightCapacity_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtFlightCapacity_Enabled, 0, "text", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 0, -1, 0, true, "", "end", false, "", "HLP_Flight.htm");
         GxWebStd.gx_div_end( context, "start", "top", "div");
         GxWebStd.gx_div_end( context, "start", "top", "div");
         GxWebStd.gx_div_end( context, "start", "top", "div");
         GxWebStd.gx_div_end( context, "start", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "start", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "start", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, divSeattable_Internalname, 1, 0, "px", 0, "px", "form__table-level", "start", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "start", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 form__cell", "start", "top", "", "", "div");
         /* Text block */
         GxWebStd.gx_label_ctrl( context, lblTitleseat_Internalname, "Seat", "", "", lblTitleseat_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "heading-04", 0, "", 1, 1, 0, 0, "HLP_Flight.htm");
         GxWebStd.gx_div_end( context, "start", "top", "div");
         GxWebStd.gx_div_end( context, "start", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "start", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "start", "top", "", "", "div");
         gxdraw_Gridflight_seat( ) ;
         GxWebStd.gx_div_end( context, "start", "top", "div");
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
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 146,'',false,'',0)\"";
         ClassString = "Button button-primary";
         StyleString = "";
         GxWebStd.gx_button_ctrl( context, bttBtn_enter_Internalname, "", "Confirm", bttBtn_enter_Jsonclick, 5, "Confirm", "", StyleString, ClassString, bttBtn_enter_Visible, bttBtn_enter_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EENTER."+"'", TempTags, "", context.GetButtonType( ), "HLP_Flight.htm");
         GxWebStd.gx_div_end( context, "start", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "start", "top", "", "", "div");
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 148,'',false,'',0)\"";
         ClassString = "Button button-tertiary";
         StyleString = "";
         GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "", "Cancel", bttBtn_cancel_Jsonclick, 1, "Cancel", "", StyleString, ClassString, bttBtn_cancel_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_Flight.htm");
         GxWebStd.gx_div_end( context, "start", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "start", "top", "", "", "div");
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 150,'',false,'',0)\"";
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

      protected void gxdraw_Gridflight_seat( )
      {
         /*  Grid Control  */
         StartGridControl138( ) ;
         nGXsfl_138_idx = 0;
         if ( ( nKeyPressed == 1 ) && ( AnyError == 0 ) )
         {
            /* Enter key processing. */
            nBlankRcdCount11 = 5;
            if ( ! IsIns( ) )
            {
               /* Display confirmed (stored) records */
               nRcdExists_11 = 1;
               ScanStart0811( ) ;
               while ( RcdFound11 != 0 )
               {
                  init_level_properties11( ) ;
                  getByPrimaryKey0811( ) ;
                  AddRow0811( ) ;
                  ScanNext0811( ) ;
               }
               ScanEnd0811( ) ;
               nBlankRcdCount11 = 5;
            }
         }
         else if ( ( nKeyPressed == 3 ) || ( nKeyPressed == 4 ) || ( ( nKeyPressed == 1 ) && ( AnyError != 0 ) ) )
         {
            /* Button check  or addlines. */
            standaloneNotModal0811( ) ;
            standaloneModal0811( ) ;
            sMode11 = Gx_mode;
            while ( nGXsfl_138_idx < nRC_GXsfl_138 )
            {
               bGXsfl_138_Refreshing = true;
               ReadRow0811( ) ;
               edtFlightSeatId_Enabled = (int)(Math.Round(context.localUtil.CToN( cgiGet( "FLIGHTSEATID_"+sGXsfl_138_idx+"Enabled"), ".", ","), 18, MidpointRounding.ToEven));
               AssignProp("", false, edtFlightSeatId_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtFlightSeatId_Enabled), 5, 0), !bGXsfl_138_Refreshing);
               cmbFlightSeatChar.Enabled = (int)(Math.Round(context.localUtil.CToN( cgiGet( "FLIGHTSEATCHAR_"+sGXsfl_138_idx+"Enabled"), ".", ","), 18, MidpointRounding.ToEven));
               AssignProp("", false, cmbFlightSeatChar_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(cmbFlightSeatChar.Enabled), 5, 0), !bGXsfl_138_Refreshing);
               cmbFlightSeatLocation.Enabled = (int)(Math.Round(context.localUtil.CToN( cgiGet( "FLIGHTSEATLOCATION_"+sGXsfl_138_idx+"Enabled"), ".", ","), 18, MidpointRounding.ToEven));
               AssignProp("", false, cmbFlightSeatLocation_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(cmbFlightSeatLocation.Enabled), 5, 0), !bGXsfl_138_Refreshing);
               if ( ( nRcdExists_11 == 0 ) && ! IsIns( ) )
               {
                  Gx_mode = "INS";
                  AssignAttri("", false, "Gx_mode", Gx_mode);
                  standaloneModal0811( ) ;
               }
               SendRow0811( ) ;
               bGXsfl_138_Refreshing = false;
            }
            Gx_mode = sMode11;
            AssignAttri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            /* Get or get-alike key processing. */
            nBlankRcdCount11 = 5;
            nRcdExists_11 = 1;
            if ( ! IsIns( ) )
            {
               ScanStart0811( ) ;
               while ( RcdFound11 != 0 )
               {
                  sGXsfl_138_idx = StringUtil.PadL( StringUtil.LTrimStr( (decimal)(nGXsfl_138_idx+1), 4, 0), 4, "0");
                  SubsflControlProps_13811( ) ;
                  init_level_properties11( ) ;
                  standaloneNotModal0811( ) ;
                  getByPrimaryKey0811( ) ;
                  standaloneModal0811( ) ;
                  AddRow0811( ) ;
                  ScanNext0811( ) ;
               }
               ScanEnd0811( ) ;
            }
         }
         /* Initialize fields for 'new' records and send them. */
         sMode11 = Gx_mode;
         Gx_mode = "INS";
         AssignAttri("", false, "Gx_mode", Gx_mode);
         sGXsfl_138_idx = StringUtil.PadL( StringUtil.LTrimStr( (decimal)(nGXsfl_138_idx+1), 4, 0), 4, "0");
         SubsflControlProps_13811( ) ;
         InitAll0811( ) ;
         init_level_properties11( ) ;
         nRcdExists_11 = 0;
         nIsMod_11 = 0;
         nRcdDeleted_11 = 0;
         nBlankRcdCount11 = (short)(nBlankRcdUsr11+nBlankRcdCount11);
         fRowAdded = 0;
         while ( nBlankRcdCount11 > 0 )
         {
            standaloneNotModal0811( ) ;
            standaloneModal0811( ) ;
            AddRow0811( ) ;
            if ( ( nKeyPressed == 4 ) && ( fRowAdded == 0 ) )
            {
               fRowAdded = 1;
               GX_FocusControl = edtFlightSeatId_Internalname;
               AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
            }
            nBlankRcdCount11 = (short)(nBlankRcdCount11-1);
         }
         Gx_mode = sMode11;
         AssignAttri("", false, "Gx_mode", Gx_mode);
         sStyleString = "";
         context.WriteHtmlText( "<div id=\""+"Gridflight_seatContainer"+"Div\" "+sStyleString+">"+"</div>") ;
         context.httpAjaxContext.ajax_rsp_assign_grid("_"+"Gridflight_seat", Gridflight_seatContainer, subGridflight_seat_Internalname);
         if ( ! context.isAjaxRequest( ) && ! context.isSpaRequest( ) )
         {
            GxWebStd.gx_hidden_field( context, "Gridflight_seatContainerData", Gridflight_seatContainer.ToJavascriptSource());
         }
         if ( context.isAjaxRequest( ) || context.isSpaRequest( ) )
         {
            GxWebStd.gx_hidden_field( context, "Gridflight_seatContainerData"+"V", Gridflight_seatContainer.GridValuesHidden());
         }
         else
         {
            context.WriteHtmlText( "<input type=\"hidden\" "+"name=\""+"Gridflight_seatContainerData"+"V"+"\" value='"+Gridflight_seatContainer.GridValuesHidden()+"'/>") ;
         }
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
            Z35FlightPrice = context.localUtil.CToN( cgiGet( "Z35FlightPrice"), ".", ",");
            Z36FlightDiscountPercentaje = (short)(Math.Round(context.localUtil.CToN( cgiGet( "Z36FlightDiscountPercentaje"), ".", ","), 18, MidpointRounding.ToEven));
            Z38AirlineId = (short)(Math.Round(context.localUtil.CToN( cgiGet( "Z38AirlineId"), ".", ","), 18, MidpointRounding.ToEven));
            n38AirlineId = ((0==A38AirlineId) ? true : false);
            Z25FlightArrivalAirportId = (short)(Math.Round(context.localUtil.CToN( cgiGet( "Z25FlightArrivalAirportId"), ".", ","), 18, MidpointRounding.ToEven));
            Z24FlightDepartureAirportId = (short)(Math.Round(context.localUtil.CToN( cgiGet( "Z24FlightDepartureAirportId"), ".", ","), 18, MidpointRounding.ToEven));
            IsConfirmed = (short)(Math.Round(context.localUtil.CToN( cgiGet( "IsConfirmed"), ".", ","), 18, MidpointRounding.ToEven));
            IsModified = (short)(Math.Round(context.localUtil.CToN( cgiGet( "IsModified"), ".", ","), 18, MidpointRounding.ToEven));
            Gx_mode = cgiGet( "Mode");
            nRC_GXsfl_138 = (int)(Math.Round(context.localUtil.CToN( cgiGet( "nRC_GXsfl_138"), ".", ","), 18, MidpointRounding.ToEven));
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
            if ( ( ( context.localUtil.CToN( cgiGet( edtFlightPrice_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtFlightPrice_Internalname), ".", ",") > 9999.99m ) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "FLIGHTPRICE");
               AnyError = 1;
               GX_FocusControl = edtFlightPrice_Internalname;
               AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               A35FlightPrice = 0;
               AssignAttri("", false, "A35FlightPrice", StringUtil.LTrimStr( A35FlightPrice, 7, 2));
            }
            else
            {
               A35FlightPrice = context.localUtil.CToN( cgiGet( edtFlightPrice_Internalname), ".", ",");
               AssignAttri("", false, "A35FlightPrice", StringUtil.LTrimStr( A35FlightPrice, 7, 2));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtFlightDiscountPercentaje_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtFlightDiscountPercentaje_Internalname), ".", ",") > Convert.ToDecimal( 9999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "FLIGHTDISCOUNTPERCENTAJE");
               AnyError = 1;
               GX_FocusControl = edtFlightDiscountPercentaje_Internalname;
               AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               A36FlightDiscountPercentaje = 0;
               AssignAttri("", false, "A36FlightDiscountPercentaje", StringUtil.LTrimStr( (decimal)(A36FlightDiscountPercentaje), 4, 0));
            }
            else
            {
               A36FlightDiscountPercentaje = (short)(Math.Round(context.localUtil.CToN( cgiGet( edtFlightDiscountPercentaje_Internalname), ".", ","), 18, MidpointRounding.ToEven));
               AssignAttri("", false, "A36FlightDiscountPercentaje", StringUtil.LTrimStr( (decimal)(A36FlightDiscountPercentaje), 4, 0));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtAirlineId_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtAirlineId_Internalname), ".", ",") > Convert.ToDecimal( 9999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "AIRLINEID");
               AnyError = 1;
               GX_FocusControl = edtAirlineId_Internalname;
               AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               A38AirlineId = 0;
               n38AirlineId = false;
               AssignAttri("", false, "A38AirlineId", StringUtil.LTrimStr( (decimal)(A38AirlineId), 4, 0));
            }
            else
            {
               A38AirlineId = (short)(Math.Round(context.localUtil.CToN( cgiGet( edtAirlineId_Internalname), ".", ","), 18, MidpointRounding.ToEven));
               n38AirlineId = false;
               AssignAttri("", false, "A38AirlineId", StringUtil.LTrimStr( (decimal)(A38AirlineId), 4, 0));
            }
            n38AirlineId = ((0==A38AirlineId) ? true : false);
            A39AirlineName = cgiGet( edtAirlineName_Internalname);
            AssignAttri("", false, "A39AirlineName", A39AirlineName);
            A40AirlineDiscountPercentage = (short)(Math.Round(context.localUtil.CToN( cgiGet( edtAirlineDiscountPercentage_Internalname), ".", ","), 18, MidpointRounding.ToEven));
            AssignAttri("", false, "A40AirlineDiscountPercentage", StringUtil.LTrimStr( (decimal)(A40AirlineDiscountPercentage), 4, 0));
            A37FlightFinalPrice = context.localUtil.CToN( cgiGet( edtFlightFinalPrice_Internalname), ".", ",");
            AssignAttri("", false, "A37FlightFinalPrice", StringUtil.LTrimStr( A37FlightFinalPrice, 7, 2));
            A45FlightCapacity = (short)(Math.Round(context.localUtil.CToN( cgiGet( edtFlightCapacity_Internalname), ".", ","), 18, MidpointRounding.ToEven));
            n45FlightCapacity = false;
            AssignAttri("", false, "A45FlightCapacity", StringUtil.LTrimStr( (decimal)(A45FlightCapacity), 4, 0));
            /* Read subfile selected row values. */
            /* Read hidden variables. */
            GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
            /* Check if conditions changed and reset current page numbers */
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
                        sEvtType = StringUtil.Right( sEvt, 4);
                        sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-4));
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
               InitAll089( ) ;
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
         DisableAttributes089( ) ;
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

      protected void CONFIRM_0811( )
      {
         nGXsfl_138_idx = 0;
         while ( nGXsfl_138_idx < nRC_GXsfl_138 )
         {
            ReadRow0811( ) ;
            if ( ( nRcdExists_11 != 0 ) || ( nIsMod_11 != 0 ) )
            {
               GetKey0811( ) ;
               if ( ( nRcdExists_11 == 0 ) && ( nRcdDeleted_11 == 0 ) )
               {
                  if ( RcdFound11 == 0 )
                  {
                     Gx_mode = "INS";
                     AssignAttri("", false, "Gx_mode", Gx_mode);
                     BeforeValidate0811( ) ;
                     if ( AnyError == 0 )
                     {
                        CheckExtendedTable0811( ) ;
                        CloseExtendedTableCursors0811( ) ;
                        if ( AnyError == 0 )
                        {
                           IsConfirmed = 1;
                           AssignAttri("", false, "IsConfirmed", StringUtil.LTrimStr( (decimal)(IsConfirmed), 4, 0));
                        }
                     }
                  }
                  else
                  {
                     GXCCtl = "FLIGHTSEATID_" + sGXsfl_138_idx;
                     GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, GXCCtl);
                     AnyError = 1;
                     GX_FocusControl = edtFlightSeatId_Internalname;
                     AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
                  }
               }
               else
               {
                  if ( RcdFound11 != 0 )
                  {
                     if ( nRcdDeleted_11 != 0 )
                     {
                        Gx_mode = "DLT";
                        AssignAttri("", false, "Gx_mode", Gx_mode);
                        getByPrimaryKey0811( ) ;
                        Load0811( ) ;
                        BeforeValidate0811( ) ;
                        if ( AnyError == 0 )
                        {
                           OnDeleteControls0811( ) ;
                        }
                     }
                     else
                     {
                        if ( nIsMod_11 != 0 )
                        {
                           Gx_mode = "UPD";
                           AssignAttri("", false, "Gx_mode", Gx_mode);
                           BeforeValidate0811( ) ;
                           if ( AnyError == 0 )
                           {
                              CheckExtendedTable0811( ) ;
                              CloseExtendedTableCursors0811( ) ;
                              if ( AnyError == 0 )
                              {
                                 IsConfirmed = 1;
                                 AssignAttri("", false, "IsConfirmed", StringUtil.LTrimStr( (decimal)(IsConfirmed), 4, 0));
                              }
                           }
                        }
                     }
                  }
                  else
                  {
                     if ( nRcdDeleted_11 == 0 )
                     {
                        GXCCtl = "FLIGHTSEATID_" + sGXsfl_138_idx;
                        GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, GXCCtl);
                        AnyError = 1;
                        GX_FocusControl = edtFlightSeatId_Internalname;
                        AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
                     }
                  }
               }
            }
            ChangePostValue( edtFlightSeatId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A42FlightSeatId), 4, 0, ".", ""))) ;
            ChangePostValue( cmbFlightSeatChar_Internalname, StringUtil.RTrim( A44FlightSeatChar)) ;
            ChangePostValue( cmbFlightSeatLocation_Internalname, StringUtil.RTrim( A43FlightSeatLocation)) ;
            ChangePostValue( "ZT_"+"Z42FlightSeatId_"+sGXsfl_138_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z42FlightSeatId), 4, 0, ".", ""))) ;
            ChangePostValue( "ZT_"+"Z44FlightSeatChar_"+sGXsfl_138_idx, StringUtil.RTrim( Z44FlightSeatChar)) ;
            ChangePostValue( "ZT_"+"Z43FlightSeatLocation_"+sGXsfl_138_idx, StringUtil.RTrim( Z43FlightSeatLocation)) ;
            ChangePostValue( "nRcdDeleted_11_"+sGXsfl_138_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_11), 4, 0, ".", ""))) ;
            ChangePostValue( "nRcdExists_11_"+sGXsfl_138_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdExists_11), 4, 0, ".", ""))) ;
            ChangePostValue( "nIsMod_11_"+sGXsfl_138_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nIsMod_11), 4, 0, ".", ""))) ;
            if ( nIsMod_11 != 0 )
            {
               ChangePostValue( "FLIGHTSEATID_"+sGXsfl_138_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtFlightSeatId_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "FLIGHTSEATCHAR_"+sGXsfl_138_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(cmbFlightSeatChar.Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "FLIGHTSEATLOCATION_"+sGXsfl_138_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(cmbFlightSeatLocation.Enabled), 5, 0, ".", ""))) ;
            }
         }
         /* Start of After( level) rules */
         /* Using cursor T00085 */
         pr_default.execute(2, new Object[] {A19FlightId});
         if ( (pr_default.getStatus(2) != 101) )
         {
            A45FlightCapacity = T00085_A45FlightCapacity[0];
            n45FlightCapacity = T00085_n45FlightCapacity[0];
            AssignAttri("", false, "A45FlightCapacity", StringUtil.LTrimStr( (decimal)(A45FlightCapacity), 4, 0));
         }
         else
         {
            A45FlightCapacity = 0;
            n45FlightCapacity = false;
            AssignAttri("", false, "A45FlightCapacity", StringUtil.LTrimStr( (decimal)(A45FlightCapacity), 4, 0));
         }
         /* End of After( level) rules */
      }

      protected void ResetCaption080( )
      {
      }

      protected void ZM089( short GX_JID )
      {
         if ( ( GX_JID == 4 ) || ( GX_JID == 0 ) )
         {
            if ( ! IsIns( ) )
            {
               Z35FlightPrice = T00087_A35FlightPrice[0];
               Z36FlightDiscountPercentaje = T00087_A36FlightDiscountPercentaje[0];
               Z38AirlineId = T00087_A38AirlineId[0];
               Z25FlightArrivalAirportId = T00087_A25FlightArrivalAirportId[0];
               Z24FlightDepartureAirportId = T00087_A24FlightDepartureAirportId[0];
            }
            else
            {
               Z35FlightPrice = A35FlightPrice;
               Z36FlightDiscountPercentaje = A36FlightDiscountPercentaje;
               Z38AirlineId = A38AirlineId;
               Z25FlightArrivalAirportId = A25FlightArrivalAirportId;
               Z24FlightDepartureAirportId = A24FlightDepartureAirportId;
            }
         }
         if ( GX_JID == -4 )
         {
            Z19FlightId = A19FlightId;
            Z35FlightPrice = A35FlightPrice;
            Z36FlightDiscountPercentaje = A36FlightDiscountPercentaje;
            Z38AirlineId = A38AirlineId;
            Z25FlightArrivalAirportId = A25FlightArrivalAirportId;
            Z24FlightDepartureAirportId = A24FlightDepartureAirportId;
            Z45FlightCapacity = A45FlightCapacity;
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
            Z39AirlineName = A39AirlineName;
            Z40AirlineDiscountPercentage = A40AirlineDiscountPercentage;
         }
      }

      protected void standaloneNotModal( )
      {
         imgprompt_25_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx0070.aspx"+"',["+"{Ctrl:gx.dom.el('"+"FLIGHTARRIVALAIRPORTID"+"'), id:'"+"FLIGHTARRIVALAIRPORTID"+"'"+",IOType:'out'}"+"],"+"null"+","+"'', false"+","+"false"+");");
         imgprompt_24_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx0070.aspx"+"',["+"{Ctrl:gx.dom.el('"+"FLIGHTDEPARTUREAIRPORTID"+"'), id:'"+"FLIGHTDEPARTUREAIRPORTID"+"'"+",IOType:'out'}"+"],"+"null"+","+"'', false"+","+"false"+");");
         imgprompt_38_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx0080.aspx"+"',["+"{Ctrl:gx.dom.el('"+"AIRLINEID"+"'), id:'"+"AIRLINEID"+"'"+",IOType:'out'}"+"],"+"null"+","+"'', false"+","+"false"+");");
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

      protected void Load089( )
      {
         /* Using cursor T000816 */
         pr_default.execute(12, new Object[] {A19FlightId});
         if ( (pr_default.getStatus(12) != 101) )
         {
            RcdFound9 = 1;
            A26FlightArrivalAirportName = T000816_A26FlightArrivalAirportName[0];
            AssignAttri("", false, "A26FlightArrivalAirportName", A26FlightArrivalAirportName);
            A32FlightArrivalCountryName = T000816_A32FlightArrivalCountryName[0];
            AssignAttri("", false, "A32FlightArrivalCountryName", A32FlightArrivalCountryName);
            A34FlightArrivalCityName = T000816_A34FlightArrivalCityName[0];
            AssignAttri("", false, "A34FlightArrivalCityName", A34FlightArrivalCityName);
            A23FlightDepartureAirportName = T000816_A23FlightDepartureAirportName[0];
            AssignAttri("", false, "A23FlightDepartureAirportName", A23FlightDepartureAirportName);
            A28FlightDepartureCountryName = T000816_A28FlightDepartureCountryName[0];
            AssignAttri("", false, "A28FlightDepartureCountryName", A28FlightDepartureCountryName);
            A30FlightDepartureCityName = T000816_A30FlightDepartureCityName[0];
            AssignAttri("", false, "A30FlightDepartureCityName", A30FlightDepartureCityName);
            A35FlightPrice = T000816_A35FlightPrice[0];
            AssignAttri("", false, "A35FlightPrice", StringUtil.LTrimStr( A35FlightPrice, 7, 2));
            A36FlightDiscountPercentaje = T000816_A36FlightDiscountPercentaje[0];
            AssignAttri("", false, "A36FlightDiscountPercentaje", StringUtil.LTrimStr( (decimal)(A36FlightDiscountPercentaje), 4, 0));
            A39AirlineName = T000816_A39AirlineName[0];
            AssignAttri("", false, "A39AirlineName", A39AirlineName);
            A40AirlineDiscountPercentage = T000816_A40AirlineDiscountPercentage[0];
            AssignAttri("", false, "A40AirlineDiscountPercentage", StringUtil.LTrimStr( (decimal)(A40AirlineDiscountPercentage), 4, 0));
            A38AirlineId = T000816_A38AirlineId[0];
            n38AirlineId = T000816_n38AirlineId[0];
            AssignAttri("", false, "A38AirlineId", StringUtil.LTrimStr( (decimal)(A38AirlineId), 4, 0));
            A25FlightArrivalAirportId = T000816_A25FlightArrivalAirportId[0];
            AssignAttri("", false, "A25FlightArrivalAirportId", StringUtil.LTrimStr( (decimal)(A25FlightArrivalAirportId), 4, 0));
            A24FlightDepartureAirportId = T000816_A24FlightDepartureAirportId[0];
            AssignAttri("", false, "A24FlightDepartureAirportId", StringUtil.LTrimStr( (decimal)(A24FlightDepartureAirportId), 4, 0));
            A31FlightArrivalCountryId = T000816_A31FlightArrivalCountryId[0];
            AssignAttri("", false, "A31FlightArrivalCountryId", StringUtil.LTrimStr( (decimal)(A31FlightArrivalCountryId), 4, 0));
            A33FlightArrivalCityId = T000816_A33FlightArrivalCityId[0];
            AssignAttri("", false, "A33FlightArrivalCityId", StringUtil.LTrimStr( (decimal)(A33FlightArrivalCityId), 4, 0));
            A27FlightDepartureCountryId = T000816_A27FlightDepartureCountryId[0];
            AssignAttri("", false, "A27FlightDepartureCountryId", StringUtil.LTrimStr( (decimal)(A27FlightDepartureCountryId), 4, 0));
            A29FlightDepartureCityId = T000816_A29FlightDepartureCityId[0];
            AssignAttri("", false, "A29FlightDepartureCityId", StringUtil.LTrimStr( (decimal)(A29FlightDepartureCityId), 4, 0));
            A45FlightCapacity = T000816_A45FlightCapacity[0];
            n45FlightCapacity = T000816_n45FlightCapacity[0];
            AssignAttri("", false, "A45FlightCapacity", StringUtil.LTrimStr( (decimal)(A45FlightCapacity), 4, 0));
            ZM089( -4) ;
         }
         pr_default.close(12);
         OnLoadActions089( ) ;
      }

      protected void OnLoadActions089( )
      {
         if ( A40AirlineDiscountPercentage >= A36FlightDiscountPercentaje )
         {
            A37FlightFinalPrice = (decimal)(A35FlightPrice*(1-A40AirlineDiscountPercentage/ (decimal)(100)));
            AssignAttri("", false, "A37FlightFinalPrice", StringUtil.LTrimStr( A37FlightFinalPrice, 7, 2));
         }
         else
         {
            A37FlightFinalPrice = (decimal)(A35FlightPrice*(1-A36FlightDiscountPercentaje/ (decimal)(100)));
            AssignAttri("", false, "A37FlightFinalPrice", StringUtil.LTrimStr( A37FlightFinalPrice, 7, 2));
         }
      }

      protected void CheckExtendedTable089( )
      {
         nIsDirty_9 = 0;
         Gx_BScreen = 1;
         standaloneModal( ) ;
         /* Using cursor T00085 */
         pr_default.execute(2, new Object[] {A19FlightId});
         if ( (pr_default.getStatus(2) != 101) )
         {
            A45FlightCapacity = T00085_A45FlightCapacity[0];
            n45FlightCapacity = T00085_n45FlightCapacity[0];
            AssignAttri("", false, "A45FlightCapacity", StringUtil.LTrimStr( (decimal)(A45FlightCapacity), 4, 0));
         }
         else
         {
            nIsDirty_9 = 1;
            A45FlightCapacity = 0;
            n45FlightCapacity = false;
            AssignAttri("", false, "A45FlightCapacity", StringUtil.LTrimStr( (decimal)(A45FlightCapacity), 4, 0));
         }
         pr_default.close(2);
         /* Using cursor T00089 */
         pr_default.execute(6, new Object[] {A25FlightArrivalAirportId});
         if ( (pr_default.getStatus(6) == 101) )
         {
            GX_msglist.addItem("No matching 'Flight Arrival Airport'.", "ForeignKeyNotFound", 1, "FLIGHTARRIVALAIRPORTID");
            AnyError = 1;
            GX_FocusControl = edtFlightArrivalAirportId_Internalname;
            AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A26FlightArrivalAirportName = T00089_A26FlightArrivalAirportName[0];
         AssignAttri("", false, "A26FlightArrivalAirportName", A26FlightArrivalAirportName);
         A31FlightArrivalCountryId = T00089_A31FlightArrivalCountryId[0];
         AssignAttri("", false, "A31FlightArrivalCountryId", StringUtil.LTrimStr( (decimal)(A31FlightArrivalCountryId), 4, 0));
         A33FlightArrivalCityId = T00089_A33FlightArrivalCityId[0];
         AssignAttri("", false, "A33FlightArrivalCityId", StringUtil.LTrimStr( (decimal)(A33FlightArrivalCityId), 4, 0));
         pr_default.close(6);
         /* Using cursor T000811 */
         pr_default.execute(8, new Object[] {A31FlightArrivalCountryId});
         if ( (pr_default.getStatus(8) == 101) )
         {
            GX_msglist.addItem("No matching 'Flight Arrival Airport'.", "ForeignKeyNotFound", 1, "FLIGHTARRIVALCOUNTRYID");
            AnyError = 1;
         }
         A32FlightArrivalCountryName = T000811_A32FlightArrivalCountryName[0];
         AssignAttri("", false, "A32FlightArrivalCountryName", A32FlightArrivalCountryName);
         pr_default.close(8);
         /* Using cursor T000812 */
         pr_default.execute(9, new Object[] {A31FlightArrivalCountryId, A33FlightArrivalCityId});
         if ( (pr_default.getStatus(9) == 101) )
         {
            GX_msglist.addItem("No matching 'Flight Arrival Airport'.", "ForeignKeyNotFound", 1, "FLIGHTARRIVALCITYID");
            AnyError = 1;
         }
         A34FlightArrivalCityName = T000812_A34FlightArrivalCityName[0];
         AssignAttri("", false, "A34FlightArrivalCityName", A34FlightArrivalCityName);
         pr_default.close(9);
         /* Using cursor T000810 */
         pr_default.execute(7, new Object[] {A24FlightDepartureAirportId});
         if ( (pr_default.getStatus(7) == 101) )
         {
            GX_msglist.addItem("No matching 'Flight Departure Airport'.", "ForeignKeyNotFound", 1, "FLIGHTDEPARTUREAIRPORTID");
            AnyError = 1;
            GX_FocusControl = edtFlightDepartureAirportId_Internalname;
            AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A23FlightDepartureAirportName = T000810_A23FlightDepartureAirportName[0];
         AssignAttri("", false, "A23FlightDepartureAirportName", A23FlightDepartureAirportName);
         A27FlightDepartureCountryId = T000810_A27FlightDepartureCountryId[0];
         AssignAttri("", false, "A27FlightDepartureCountryId", StringUtil.LTrimStr( (decimal)(A27FlightDepartureCountryId), 4, 0));
         A29FlightDepartureCityId = T000810_A29FlightDepartureCityId[0];
         AssignAttri("", false, "A29FlightDepartureCityId", StringUtil.LTrimStr( (decimal)(A29FlightDepartureCityId), 4, 0));
         pr_default.close(7);
         /* Using cursor T000813 */
         pr_default.execute(10, new Object[] {A27FlightDepartureCountryId});
         if ( (pr_default.getStatus(10) == 101) )
         {
            GX_msglist.addItem("No matching 'Flight Departure Airport'.", "ForeignKeyNotFound", 1, "FLIGHTDEPARTURECOUNTRYID");
            AnyError = 1;
         }
         A28FlightDepartureCountryName = T000813_A28FlightDepartureCountryName[0];
         AssignAttri("", false, "A28FlightDepartureCountryName", A28FlightDepartureCountryName);
         pr_default.close(10);
         /* Using cursor T000814 */
         pr_default.execute(11, new Object[] {A27FlightDepartureCountryId, A29FlightDepartureCityId});
         if ( (pr_default.getStatus(11) == 101) )
         {
            GX_msglist.addItem("No matching 'Flight Departure Airport'.", "ForeignKeyNotFound", 1, "FLIGHTDEPARTURECITYID");
            AnyError = 1;
         }
         A30FlightDepartureCityName = T000814_A30FlightDepartureCityName[0];
         AssignAttri("", false, "A30FlightDepartureCityName", A30FlightDepartureCityName);
         pr_default.close(11);
         /* Using cursor T00088 */
         pr_default.execute(5, new Object[] {n38AirlineId, A38AirlineId});
         if ( (pr_default.getStatus(5) == 101) )
         {
            if ( ! ( (0==A38AirlineId) ) )
            {
               GX_msglist.addItem("No matching 'Airline'.", "ForeignKeyNotFound", 1, "AIRLINEID");
               AnyError = 1;
               GX_FocusControl = edtAirlineId_Internalname;
               AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         A39AirlineName = T00088_A39AirlineName[0];
         AssignAttri("", false, "A39AirlineName", A39AirlineName);
         A40AirlineDiscountPercentage = T00088_A40AirlineDiscountPercentage[0];
         AssignAttri("", false, "A40AirlineDiscountPercentage", StringUtil.LTrimStr( (decimal)(A40AirlineDiscountPercentage), 4, 0));
         pr_default.close(5);
         if ( A40AirlineDiscountPercentage >= A36FlightDiscountPercentaje )
         {
            nIsDirty_9 = 1;
            A37FlightFinalPrice = (decimal)(A35FlightPrice*(1-A40AirlineDiscountPercentage/ (decimal)(100)));
            AssignAttri("", false, "A37FlightFinalPrice", StringUtil.LTrimStr( A37FlightFinalPrice, 7, 2));
         }
         else
         {
            nIsDirty_9 = 1;
            A37FlightFinalPrice = (decimal)(A35FlightPrice*(1-A36FlightDiscountPercentaje/ (decimal)(100)));
            AssignAttri("", false, "A37FlightFinalPrice", StringUtil.LTrimStr( A37FlightFinalPrice, 7, 2));
         }
      }

      protected void CloseExtendedTableCursors089( )
      {
         pr_default.close(2);
         pr_default.close(6);
         pr_default.close(8);
         pr_default.close(9);
         pr_default.close(7);
         pr_default.close(10);
         pr_default.close(11);
         pr_default.close(5);
      }

      protected void enableDisable( )
      {
      }

      protected void gxLoad_12( short A19FlightId )
      {
         /* Using cursor T000818 */
         pr_default.execute(13, new Object[] {A19FlightId});
         if ( (pr_default.getStatus(13) != 101) )
         {
            A45FlightCapacity = T000818_A45FlightCapacity[0];
            n45FlightCapacity = T000818_n45FlightCapacity[0];
            AssignAttri("", false, "A45FlightCapacity", StringUtil.LTrimStr( (decimal)(A45FlightCapacity), 4, 0));
         }
         else
         {
            A45FlightCapacity = 0;
            n45FlightCapacity = false;
            AssignAttri("", false, "A45FlightCapacity", StringUtil.LTrimStr( (decimal)(A45FlightCapacity), 4, 0));
         }
         GxWebStd.set_html_headers( context, 0, "", "");
         AddString( "[[") ;
         AddString( "\""+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A45FlightCapacity), 4, 0, ".", "")))+"\"") ;
         AddString( "]") ;
         if ( (pr_default.getStatus(13) == 101) )
         {
            AddString( ",") ;
            AddString( "101") ;
         }
         AddString( "]") ;
         pr_default.close(13);
      }

      protected void gxLoad_6( short A25FlightArrivalAirportId )
      {
         /* Using cursor T000819 */
         pr_default.execute(14, new Object[] {A25FlightArrivalAirportId});
         if ( (pr_default.getStatus(14) == 101) )
         {
            GX_msglist.addItem("No matching 'Flight Arrival Airport'.", "ForeignKeyNotFound", 1, "FLIGHTARRIVALAIRPORTID");
            AnyError = 1;
            GX_FocusControl = edtFlightArrivalAirportId_Internalname;
            AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A26FlightArrivalAirportName = T000819_A26FlightArrivalAirportName[0];
         AssignAttri("", false, "A26FlightArrivalAirportName", A26FlightArrivalAirportName);
         A31FlightArrivalCountryId = T000819_A31FlightArrivalCountryId[0];
         AssignAttri("", false, "A31FlightArrivalCountryId", StringUtil.LTrimStr( (decimal)(A31FlightArrivalCountryId), 4, 0));
         A33FlightArrivalCityId = T000819_A33FlightArrivalCityId[0];
         AssignAttri("", false, "A33FlightArrivalCityId", StringUtil.LTrimStr( (decimal)(A33FlightArrivalCityId), 4, 0));
         GxWebStd.set_html_headers( context, 0, "", "");
         AddString( "[[") ;
         AddString( "\""+GXUtil.EncodeJSConstant( A26FlightArrivalAirportName)+"\""+","+"\""+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A31FlightArrivalCountryId), 4, 0, ".", "")))+"\""+","+"\""+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A33FlightArrivalCityId), 4, 0, ".", "")))+"\"") ;
         AddString( "]") ;
         if ( (pr_default.getStatus(14) == 101) )
         {
            AddString( ",") ;
            AddString( "101") ;
         }
         AddString( "]") ;
         pr_default.close(14);
      }

      protected void gxLoad_8( short A31FlightArrivalCountryId )
      {
         /* Using cursor T000820 */
         pr_default.execute(15, new Object[] {A31FlightArrivalCountryId});
         if ( (pr_default.getStatus(15) == 101) )
         {
            GX_msglist.addItem("No matching 'Flight Arrival Airport'.", "ForeignKeyNotFound", 1, "FLIGHTARRIVALCOUNTRYID");
            AnyError = 1;
         }
         A32FlightArrivalCountryName = T000820_A32FlightArrivalCountryName[0];
         AssignAttri("", false, "A32FlightArrivalCountryName", A32FlightArrivalCountryName);
         GxWebStd.set_html_headers( context, 0, "", "");
         AddString( "[[") ;
         AddString( "\""+GXUtil.EncodeJSConstant( A32FlightArrivalCountryName)+"\"") ;
         AddString( "]") ;
         if ( (pr_default.getStatus(15) == 101) )
         {
            AddString( ",") ;
            AddString( "101") ;
         }
         AddString( "]") ;
         pr_default.close(15);
      }

      protected void gxLoad_9( short A31FlightArrivalCountryId ,
                               short A33FlightArrivalCityId )
      {
         /* Using cursor T000821 */
         pr_default.execute(16, new Object[] {A31FlightArrivalCountryId, A33FlightArrivalCityId});
         if ( (pr_default.getStatus(16) == 101) )
         {
            GX_msglist.addItem("No matching 'Flight Arrival Airport'.", "ForeignKeyNotFound", 1, "FLIGHTARRIVALCITYID");
            AnyError = 1;
         }
         A34FlightArrivalCityName = T000821_A34FlightArrivalCityName[0];
         AssignAttri("", false, "A34FlightArrivalCityName", A34FlightArrivalCityName);
         GxWebStd.set_html_headers( context, 0, "", "");
         AddString( "[[") ;
         AddString( "\""+GXUtil.EncodeJSConstant( A34FlightArrivalCityName)+"\"") ;
         AddString( "]") ;
         if ( (pr_default.getStatus(16) == 101) )
         {
            AddString( ",") ;
            AddString( "101") ;
         }
         AddString( "]") ;
         pr_default.close(16);
      }

      protected void gxLoad_7( short A24FlightDepartureAirportId )
      {
         /* Using cursor T000822 */
         pr_default.execute(17, new Object[] {A24FlightDepartureAirportId});
         if ( (pr_default.getStatus(17) == 101) )
         {
            GX_msglist.addItem("No matching 'Flight Departure Airport'.", "ForeignKeyNotFound", 1, "FLIGHTDEPARTUREAIRPORTID");
            AnyError = 1;
            GX_FocusControl = edtFlightDepartureAirportId_Internalname;
            AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A23FlightDepartureAirportName = T000822_A23FlightDepartureAirportName[0];
         AssignAttri("", false, "A23FlightDepartureAirportName", A23FlightDepartureAirportName);
         A27FlightDepartureCountryId = T000822_A27FlightDepartureCountryId[0];
         AssignAttri("", false, "A27FlightDepartureCountryId", StringUtil.LTrimStr( (decimal)(A27FlightDepartureCountryId), 4, 0));
         A29FlightDepartureCityId = T000822_A29FlightDepartureCityId[0];
         AssignAttri("", false, "A29FlightDepartureCityId", StringUtil.LTrimStr( (decimal)(A29FlightDepartureCityId), 4, 0));
         GxWebStd.set_html_headers( context, 0, "", "");
         AddString( "[[") ;
         AddString( "\""+GXUtil.EncodeJSConstant( A23FlightDepartureAirportName)+"\""+","+"\""+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A27FlightDepartureCountryId), 4, 0, ".", "")))+"\""+","+"\""+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A29FlightDepartureCityId), 4, 0, ".", "")))+"\"") ;
         AddString( "]") ;
         if ( (pr_default.getStatus(17) == 101) )
         {
            AddString( ",") ;
            AddString( "101") ;
         }
         AddString( "]") ;
         pr_default.close(17);
      }

      protected void gxLoad_10( short A27FlightDepartureCountryId )
      {
         /* Using cursor T000823 */
         pr_default.execute(18, new Object[] {A27FlightDepartureCountryId});
         if ( (pr_default.getStatus(18) == 101) )
         {
            GX_msglist.addItem("No matching 'Flight Departure Airport'.", "ForeignKeyNotFound", 1, "FLIGHTDEPARTURECOUNTRYID");
            AnyError = 1;
         }
         A28FlightDepartureCountryName = T000823_A28FlightDepartureCountryName[0];
         AssignAttri("", false, "A28FlightDepartureCountryName", A28FlightDepartureCountryName);
         GxWebStd.set_html_headers( context, 0, "", "");
         AddString( "[[") ;
         AddString( "\""+GXUtil.EncodeJSConstant( A28FlightDepartureCountryName)+"\"") ;
         AddString( "]") ;
         if ( (pr_default.getStatus(18) == 101) )
         {
            AddString( ",") ;
            AddString( "101") ;
         }
         AddString( "]") ;
         pr_default.close(18);
      }

      protected void gxLoad_11( short A27FlightDepartureCountryId ,
                                short A29FlightDepartureCityId )
      {
         /* Using cursor T000824 */
         pr_default.execute(19, new Object[] {A27FlightDepartureCountryId, A29FlightDepartureCityId});
         if ( (pr_default.getStatus(19) == 101) )
         {
            GX_msglist.addItem("No matching 'Flight Departure Airport'.", "ForeignKeyNotFound", 1, "FLIGHTDEPARTURECITYID");
            AnyError = 1;
         }
         A30FlightDepartureCityName = T000824_A30FlightDepartureCityName[0];
         AssignAttri("", false, "A30FlightDepartureCityName", A30FlightDepartureCityName);
         GxWebStd.set_html_headers( context, 0, "", "");
         AddString( "[[") ;
         AddString( "\""+GXUtil.EncodeJSConstant( A30FlightDepartureCityName)+"\"") ;
         AddString( "]") ;
         if ( (pr_default.getStatus(19) == 101) )
         {
            AddString( ",") ;
            AddString( "101") ;
         }
         AddString( "]") ;
         pr_default.close(19);
      }

      protected void gxLoad_5( short A38AirlineId )
      {
         /* Using cursor T000825 */
         pr_default.execute(20, new Object[] {n38AirlineId, A38AirlineId});
         if ( (pr_default.getStatus(20) == 101) )
         {
            if ( ! ( (0==A38AirlineId) ) )
            {
               GX_msglist.addItem("No matching 'Airline'.", "ForeignKeyNotFound", 1, "AIRLINEID");
               AnyError = 1;
               GX_FocusControl = edtAirlineId_Internalname;
               AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         A39AirlineName = T000825_A39AirlineName[0];
         AssignAttri("", false, "A39AirlineName", A39AirlineName);
         A40AirlineDiscountPercentage = T000825_A40AirlineDiscountPercentage[0];
         AssignAttri("", false, "A40AirlineDiscountPercentage", StringUtil.LTrimStr( (decimal)(A40AirlineDiscountPercentage), 4, 0));
         GxWebStd.set_html_headers( context, 0, "", "");
         AddString( "[[") ;
         AddString( "\""+GXUtil.EncodeJSConstant( A39AirlineName)+"\""+","+"\""+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A40AirlineDiscountPercentage), 4, 0, ".", "")))+"\"") ;
         AddString( "]") ;
         if ( (pr_default.getStatus(20) == 101) )
         {
            AddString( ",") ;
            AddString( "101") ;
         }
         AddString( "]") ;
         pr_default.close(20);
      }

      protected void GetKey089( )
      {
         /* Using cursor T000826 */
         pr_default.execute(21, new Object[] {A19FlightId});
         if ( (pr_default.getStatus(21) != 101) )
         {
            RcdFound9 = 1;
         }
         else
         {
            RcdFound9 = 0;
         }
         pr_default.close(21);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T00087 */
         pr_default.execute(4, new Object[] {A19FlightId});
         if ( (pr_default.getStatus(4) != 101) )
         {
            ZM089( 4) ;
            RcdFound9 = 1;
            A19FlightId = T00087_A19FlightId[0];
            AssignAttri("", false, "A19FlightId", StringUtil.LTrimStr( (decimal)(A19FlightId), 4, 0));
            A35FlightPrice = T00087_A35FlightPrice[0];
            AssignAttri("", false, "A35FlightPrice", StringUtil.LTrimStr( A35FlightPrice, 7, 2));
            A36FlightDiscountPercentaje = T00087_A36FlightDiscountPercentaje[0];
            AssignAttri("", false, "A36FlightDiscountPercentaje", StringUtil.LTrimStr( (decimal)(A36FlightDiscountPercentaje), 4, 0));
            A38AirlineId = T00087_A38AirlineId[0];
            n38AirlineId = T00087_n38AirlineId[0];
            AssignAttri("", false, "A38AirlineId", StringUtil.LTrimStr( (decimal)(A38AirlineId), 4, 0));
            A25FlightArrivalAirportId = T00087_A25FlightArrivalAirportId[0];
            AssignAttri("", false, "A25FlightArrivalAirportId", StringUtil.LTrimStr( (decimal)(A25FlightArrivalAirportId), 4, 0));
            A24FlightDepartureAirportId = T00087_A24FlightDepartureAirportId[0];
            AssignAttri("", false, "A24FlightDepartureAirportId", StringUtil.LTrimStr( (decimal)(A24FlightDepartureAirportId), 4, 0));
            Z19FlightId = A19FlightId;
            sMode9 = Gx_mode;
            Gx_mode = "DSP";
            AssignAttri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Load089( ) ;
            if ( AnyError == 1 )
            {
               RcdFound9 = 0;
               InitializeNonKey089( ) ;
            }
            Gx_mode = sMode9;
            AssignAttri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            RcdFound9 = 0;
            InitializeNonKey089( ) ;
            sMode9 = Gx_mode;
            Gx_mode = "DSP";
            AssignAttri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Gx_mode = sMode9;
            AssignAttri("", false, "Gx_mode", Gx_mode);
         }
         pr_default.close(4);
      }

      protected void getEqualNoModal( )
      {
         GetKey089( ) ;
         if ( RcdFound9 == 0 )
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
         RcdFound9 = 0;
         /* Using cursor T000827 */
         pr_default.execute(22, new Object[] {A19FlightId});
         if ( (pr_default.getStatus(22) != 101) )
         {
            while ( (pr_default.getStatus(22) != 101) && ( ( T000827_A19FlightId[0] < A19FlightId ) ) )
            {
               pr_default.readNext(22);
            }
            if ( (pr_default.getStatus(22) != 101) && ( ( T000827_A19FlightId[0] > A19FlightId ) ) )
            {
               A19FlightId = T000827_A19FlightId[0];
               AssignAttri("", false, "A19FlightId", StringUtil.LTrimStr( (decimal)(A19FlightId), 4, 0));
               RcdFound9 = 1;
            }
         }
         pr_default.close(22);
      }

      protected void move_previous( )
      {
         RcdFound9 = 0;
         /* Using cursor T000828 */
         pr_default.execute(23, new Object[] {A19FlightId});
         if ( (pr_default.getStatus(23) != 101) )
         {
            while ( (pr_default.getStatus(23) != 101) && ( ( T000828_A19FlightId[0] > A19FlightId ) ) )
            {
               pr_default.readNext(23);
            }
            if ( (pr_default.getStatus(23) != 101) && ( ( T000828_A19FlightId[0] < A19FlightId ) ) )
            {
               A19FlightId = T000828_A19FlightId[0];
               AssignAttri("", false, "A19FlightId", StringUtil.LTrimStr( (decimal)(A19FlightId), 4, 0));
               RcdFound9 = 1;
            }
         }
         pr_default.close(23);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1;
         GetKey089( ) ;
         if ( IsIns( ) )
         {
            /* Insert record */
            GX_FocusControl = edtFlightId_Internalname;
            AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
            Insert089( ) ;
            if ( AnyError == 1 )
            {
               GX_FocusControl = "";
               AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( RcdFound9 == 1 )
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
                  Update089( ) ;
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
                  Insert089( ) ;
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
                     Insert089( ) ;
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
         if ( RcdFound9 == 0 )
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
         ScanStart089( ) ;
         if ( RcdFound9 == 0 )
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
         ScanEnd089( ) ;
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
         if ( RcdFound9 == 0 )
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
         if ( RcdFound9 == 0 )
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
         ScanStart089( ) ;
         if ( RcdFound9 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            while ( RcdFound9 != 0 )
            {
               ScanNext089( ) ;
            }
            Gx_mode = "UPD";
            AssignAttri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtFlightArrivalAirportId_Internalname;
         AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         ScanEnd089( ) ;
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_select( )
      {
         getEqualNoModal( ) ;
      }

      protected void CheckOptimisticConcurrency089( )
      {
         if ( ! IsIns( ) )
         {
            /* Using cursor T00086 */
            pr_default.execute(3, new Object[] {A19FlightId});
            if ( (pr_default.getStatus(3) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Flight"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            if ( (pr_default.getStatus(3) == 101) || ( Z35FlightPrice != T00086_A35FlightPrice[0] ) || ( Z36FlightDiscountPercentaje != T00086_A36FlightDiscountPercentaje[0] ) || ( Z38AirlineId != T00086_A38AirlineId[0] ) || ( Z25FlightArrivalAirportId != T00086_A25FlightArrivalAirportId[0] ) || ( Z24FlightDepartureAirportId != T00086_A24FlightDepartureAirportId[0] ) )
            {
               if ( Z35FlightPrice != T00086_A35FlightPrice[0] )
               {
                  GXUtil.WriteLog("flight:[seudo value changed for attri]"+"FlightPrice");
                  GXUtil.WriteLogRaw("Old: ",Z35FlightPrice);
                  GXUtil.WriteLogRaw("Current: ",T00086_A35FlightPrice[0]);
               }
               if ( Z36FlightDiscountPercentaje != T00086_A36FlightDiscountPercentaje[0] )
               {
                  GXUtil.WriteLog("flight:[seudo value changed for attri]"+"FlightDiscountPercentaje");
                  GXUtil.WriteLogRaw("Old: ",Z36FlightDiscountPercentaje);
                  GXUtil.WriteLogRaw("Current: ",T00086_A36FlightDiscountPercentaje[0]);
               }
               if ( Z38AirlineId != T00086_A38AirlineId[0] )
               {
                  GXUtil.WriteLog("flight:[seudo value changed for attri]"+"AirlineId");
                  GXUtil.WriteLogRaw("Old: ",Z38AirlineId);
                  GXUtil.WriteLogRaw("Current: ",T00086_A38AirlineId[0]);
               }
               if ( Z25FlightArrivalAirportId != T00086_A25FlightArrivalAirportId[0] )
               {
                  GXUtil.WriteLog("flight:[seudo value changed for attri]"+"FlightArrivalAirportId");
                  GXUtil.WriteLogRaw("Old: ",Z25FlightArrivalAirportId);
                  GXUtil.WriteLogRaw("Current: ",T00086_A25FlightArrivalAirportId[0]);
               }
               if ( Z24FlightDepartureAirportId != T00086_A24FlightDepartureAirportId[0] )
               {
                  GXUtil.WriteLog("flight:[seudo value changed for attri]"+"FlightDepartureAirportId");
                  GXUtil.WriteLogRaw("Old: ",Z24FlightDepartureAirportId);
                  GXUtil.WriteLogRaw("Current: ",T00086_A24FlightDepartureAirportId[0]);
               }
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"Flight"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert089( )
      {
         BeforeValidate089( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable089( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM089( 0) ;
            CheckOptimisticConcurrency089( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm089( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert089( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000829 */
                     pr_default.execute(24, new Object[] {A35FlightPrice, A36FlightDiscountPercentaje, n38AirlineId, A38AirlineId, A25FlightArrivalAirportId, A24FlightDepartureAirportId});
                     A19FlightId = T000829_A19FlightId[0];
                     AssignAttri("", false, "A19FlightId", StringUtil.LTrimStr( (decimal)(A19FlightId), 4, 0));
                     pr_default.close(24);
                     pr_default.SmartCacheProvider.SetUpdated("Flight");
                     if ( AnyError == 0 )
                     {
                        /* Start of After( Insert) rules */
                        /* End of After( Insert) rules */
                        if ( AnyError == 0 )
                        {
                           ProcessLevel089( ) ;
                           if ( AnyError == 0 )
                           {
                              /* Save values for previous() function. */
                              endTrnMsgTxt = context.GetMessage( "GXM_sucadded", "");
                              endTrnMsgCod = "SuccessfullyAdded";
                              ResetCaption080( ) ;
                           }
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
               Load089( ) ;
            }
            EndLevel089( ) ;
         }
         CloseExtendedTableCursors089( ) ;
      }

      protected void Update089( )
      {
         BeforeValidate089( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable089( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency089( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm089( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate089( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000830 */
                     pr_default.execute(25, new Object[] {A35FlightPrice, A36FlightDiscountPercentaje, n38AirlineId, A38AirlineId, A25FlightArrivalAirportId, A24FlightDepartureAirportId, A19FlightId});
                     pr_default.close(25);
                     pr_default.SmartCacheProvider.SetUpdated("Flight");
                     if ( (pr_default.getStatus(25) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Flight"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate089( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           ProcessLevel089( ) ;
                           if ( AnyError == 0 )
                           {
                              getByPrimaryKey( ) ;
                              endTrnMsgTxt = context.GetMessage( "GXM_sucupdated", "");
                              endTrnMsgCod = "SuccessfullyUpdated";
                              ResetCaption080( ) ;
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
            }
            EndLevel089( ) ;
         }
         CloseExtendedTableCursors089( ) ;
      }

      protected void DeferredUpdate089( )
      {
      }

      protected void delete( )
      {
         Gx_mode = "DLT";
         AssignAttri("", false, "Gx_mode", Gx_mode);
         BeforeValidate089( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency089( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls089( ) ;
            AfterConfirm089( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete089( ) ;
               if ( AnyError == 0 )
               {
                  ScanStart0811( ) ;
                  while ( RcdFound11 != 0 )
                  {
                     getByPrimaryKey0811( ) ;
                     Delete0811( ) ;
                     ScanNext0811( ) ;
                  }
                  ScanEnd0811( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000831 */
                     pr_default.execute(26, new Object[] {A19FlightId});
                     pr_default.close(26);
                     pr_default.SmartCacheProvider.SetUpdated("Flight");
                     if ( AnyError == 0 )
                     {
                        /* Start of After( delete) rules */
                        /* End of After( delete) rules */
                        if ( AnyError == 0 )
                        {
                           move_next( ) ;
                           if ( RcdFound9 == 0 )
                           {
                              InitAll089( ) ;
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
                           ResetCaption080( ) ;
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
         }
         sMode9 = Gx_mode;
         Gx_mode = "DLT";
         AssignAttri("", false, "Gx_mode", Gx_mode);
         EndLevel089( ) ;
         Gx_mode = sMode9;
         AssignAttri("", false, "Gx_mode", Gx_mode);
      }

      protected void OnDeleteControls089( )
      {
         standaloneModal( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            /* Using cursor T000833 */
            pr_default.execute(27, new Object[] {A19FlightId});
            if ( (pr_default.getStatus(27) != 101) )
            {
               A45FlightCapacity = T000833_A45FlightCapacity[0];
               n45FlightCapacity = T000833_n45FlightCapacity[0];
               AssignAttri("", false, "A45FlightCapacity", StringUtil.LTrimStr( (decimal)(A45FlightCapacity), 4, 0));
            }
            else
            {
               A45FlightCapacity = 0;
               n45FlightCapacity = false;
               AssignAttri("", false, "A45FlightCapacity", StringUtil.LTrimStr( (decimal)(A45FlightCapacity), 4, 0));
            }
            pr_default.close(27);
            /* Using cursor T000834 */
            pr_default.execute(28, new Object[] {A25FlightArrivalAirportId});
            A26FlightArrivalAirportName = T000834_A26FlightArrivalAirportName[0];
            AssignAttri("", false, "A26FlightArrivalAirportName", A26FlightArrivalAirportName);
            A31FlightArrivalCountryId = T000834_A31FlightArrivalCountryId[0];
            AssignAttri("", false, "A31FlightArrivalCountryId", StringUtil.LTrimStr( (decimal)(A31FlightArrivalCountryId), 4, 0));
            A33FlightArrivalCityId = T000834_A33FlightArrivalCityId[0];
            AssignAttri("", false, "A33FlightArrivalCityId", StringUtil.LTrimStr( (decimal)(A33FlightArrivalCityId), 4, 0));
            pr_default.close(28);
            /* Using cursor T000835 */
            pr_default.execute(29, new Object[] {A31FlightArrivalCountryId});
            A32FlightArrivalCountryName = T000835_A32FlightArrivalCountryName[0];
            AssignAttri("", false, "A32FlightArrivalCountryName", A32FlightArrivalCountryName);
            pr_default.close(29);
            /* Using cursor T000836 */
            pr_default.execute(30, new Object[] {A31FlightArrivalCountryId, A33FlightArrivalCityId});
            A34FlightArrivalCityName = T000836_A34FlightArrivalCityName[0];
            AssignAttri("", false, "A34FlightArrivalCityName", A34FlightArrivalCityName);
            pr_default.close(30);
            /* Using cursor T000837 */
            pr_default.execute(31, new Object[] {A24FlightDepartureAirportId});
            A23FlightDepartureAirportName = T000837_A23FlightDepartureAirportName[0];
            AssignAttri("", false, "A23FlightDepartureAirportName", A23FlightDepartureAirportName);
            A27FlightDepartureCountryId = T000837_A27FlightDepartureCountryId[0];
            AssignAttri("", false, "A27FlightDepartureCountryId", StringUtil.LTrimStr( (decimal)(A27FlightDepartureCountryId), 4, 0));
            A29FlightDepartureCityId = T000837_A29FlightDepartureCityId[0];
            AssignAttri("", false, "A29FlightDepartureCityId", StringUtil.LTrimStr( (decimal)(A29FlightDepartureCityId), 4, 0));
            pr_default.close(31);
            /* Using cursor T000838 */
            pr_default.execute(32, new Object[] {A27FlightDepartureCountryId});
            A28FlightDepartureCountryName = T000838_A28FlightDepartureCountryName[0];
            AssignAttri("", false, "A28FlightDepartureCountryName", A28FlightDepartureCountryName);
            pr_default.close(32);
            /* Using cursor T000839 */
            pr_default.execute(33, new Object[] {A27FlightDepartureCountryId, A29FlightDepartureCityId});
            A30FlightDepartureCityName = T000839_A30FlightDepartureCityName[0];
            AssignAttri("", false, "A30FlightDepartureCityName", A30FlightDepartureCityName);
            pr_default.close(33);
            /* Using cursor T000840 */
            pr_default.execute(34, new Object[] {n38AirlineId, A38AirlineId});
            A39AirlineName = T000840_A39AirlineName[0];
            AssignAttri("", false, "A39AirlineName", A39AirlineName);
            A40AirlineDiscountPercentage = T000840_A40AirlineDiscountPercentage[0];
            AssignAttri("", false, "A40AirlineDiscountPercentage", StringUtil.LTrimStr( (decimal)(A40AirlineDiscountPercentage), 4, 0));
            pr_default.close(34);
            if ( A40AirlineDiscountPercentage >= A36FlightDiscountPercentaje )
            {
               A37FlightFinalPrice = (decimal)(A35FlightPrice*(1-A40AirlineDiscountPercentage/ (decimal)(100)));
               AssignAttri("", false, "A37FlightFinalPrice", StringUtil.LTrimStr( A37FlightFinalPrice, 7, 2));
            }
            else
            {
               A37FlightFinalPrice = (decimal)(A35FlightPrice*(1-A36FlightDiscountPercentaje/ (decimal)(100)));
               AssignAttri("", false, "A37FlightFinalPrice", StringUtil.LTrimStr( A37FlightFinalPrice, 7, 2));
            }
         }
      }

      protected void ProcessNestedLevel0811( )
      {
         nGXsfl_138_idx = 0;
         while ( nGXsfl_138_idx < nRC_GXsfl_138 )
         {
            ReadRow0811( ) ;
            if ( ( nRcdExists_11 != 0 ) || ( nIsMod_11 != 0 ) )
            {
               standaloneNotModal0811( ) ;
               GetKey0811( ) ;
               if ( ( nRcdExists_11 == 0 ) && ( nRcdDeleted_11 == 0 ) )
               {
                  Gx_mode = "INS";
                  AssignAttri("", false, "Gx_mode", Gx_mode);
                  Insert0811( ) ;
               }
               else
               {
                  if ( RcdFound11 != 0 )
                  {
                     if ( ( nRcdDeleted_11 != 0 ) && ( nRcdExists_11 != 0 ) )
                     {
                        Gx_mode = "DLT";
                        AssignAttri("", false, "Gx_mode", Gx_mode);
                        Delete0811( ) ;
                     }
                     else
                     {
                        if ( nRcdExists_11 != 0 )
                        {
                           Gx_mode = "UPD";
                           AssignAttri("", false, "Gx_mode", Gx_mode);
                           Update0811( ) ;
                        }
                     }
                  }
                  else
                  {
                     if ( nRcdDeleted_11 == 0 )
                     {
                        GXCCtl = "FLIGHTSEATID_" + sGXsfl_138_idx;
                        GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, GXCCtl);
                        AnyError = 1;
                        GX_FocusControl = edtFlightSeatId_Internalname;
                        AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
                     }
                  }
               }
            }
            ChangePostValue( edtFlightSeatId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A42FlightSeatId), 4, 0, ".", ""))) ;
            ChangePostValue( cmbFlightSeatChar_Internalname, StringUtil.RTrim( A44FlightSeatChar)) ;
            ChangePostValue( cmbFlightSeatLocation_Internalname, StringUtil.RTrim( A43FlightSeatLocation)) ;
            ChangePostValue( "ZT_"+"Z42FlightSeatId_"+sGXsfl_138_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z42FlightSeatId), 4, 0, ".", ""))) ;
            ChangePostValue( "ZT_"+"Z44FlightSeatChar_"+sGXsfl_138_idx, StringUtil.RTrim( Z44FlightSeatChar)) ;
            ChangePostValue( "ZT_"+"Z43FlightSeatLocation_"+sGXsfl_138_idx, StringUtil.RTrim( Z43FlightSeatLocation)) ;
            ChangePostValue( "nRcdDeleted_11_"+sGXsfl_138_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_11), 4, 0, ".", ""))) ;
            ChangePostValue( "nRcdExists_11_"+sGXsfl_138_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdExists_11), 4, 0, ".", ""))) ;
            ChangePostValue( "nIsMod_11_"+sGXsfl_138_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nIsMod_11), 4, 0, ".", ""))) ;
            if ( nIsMod_11 != 0 )
            {
               ChangePostValue( "FLIGHTSEATID_"+sGXsfl_138_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtFlightSeatId_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "FLIGHTSEATCHAR_"+sGXsfl_138_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(cmbFlightSeatChar.Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "FLIGHTSEATLOCATION_"+sGXsfl_138_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(cmbFlightSeatLocation.Enabled), 5, 0, ".", ""))) ;
            }
         }
         /* Start of After( level) rules */
         /* Using cursor T000833 */
         pr_default.execute(27, new Object[] {A19FlightId});
         if ( (pr_default.getStatus(27) != 101) )
         {
            A45FlightCapacity = T000833_A45FlightCapacity[0];
            n45FlightCapacity = T000833_n45FlightCapacity[0];
            AssignAttri("", false, "A45FlightCapacity", StringUtil.LTrimStr( (decimal)(A45FlightCapacity), 4, 0));
         }
         else
         {
            A45FlightCapacity = 0;
            n45FlightCapacity = false;
            AssignAttri("", false, "A45FlightCapacity", StringUtil.LTrimStr( (decimal)(A45FlightCapacity), 4, 0));
         }
         /* End of After( level) rules */
         InitAll0811( ) ;
         if ( AnyError != 0 )
         {
         }
         nRcdExists_11 = 0;
         nIsMod_11 = 0;
         nRcdDeleted_11 = 0;
      }

      protected void ProcessLevel089( )
      {
         /* Save parent mode. */
         sMode9 = Gx_mode;
         ProcessNestedLevel0811( ) ;
         if ( AnyError != 0 )
         {
         }
         /* Restore parent mode. */
         Gx_mode = sMode9;
         AssignAttri("", false, "Gx_mode", Gx_mode);
         /* ' Update level parameters */
      }

      protected void EndLevel089( )
      {
         if ( ! IsIns( ) )
         {
            pr_default.close(3);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete089( ) ;
         }
         if ( AnyError == 0 )
         {
            pr_default.close(4);
            pr_default.close(1);
            pr_default.close(0);
            pr_default.close(34);
            pr_default.close(28);
            pr_default.close(31);
            pr_default.close(29);
            pr_default.close(30);
            pr_default.close(32);
            pr_default.close(33);
            pr_default.close(27);
            context.CommitDataStores("flight",pr_default);
            if ( AnyError == 0 )
            {
               ConfirmValues080( ) ;
            }
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1;
         }
         else
         {
            pr_default.close(4);
            pr_default.close(1);
            pr_default.close(0);
            pr_default.close(34);
            pr_default.close(28);
            pr_default.close(31);
            pr_default.close(29);
            pr_default.close(30);
            pr_default.close(32);
            pr_default.close(33);
            pr_default.close(27);
            context.RollbackDataStores("flight",pr_default);
         }
         IsModified = 0;
         if ( AnyError != 0 )
         {
            context.wjLoc = "";
            context.nUserReturn = 0;
         }
      }

      public void ScanStart089( )
      {
         /* Using cursor T000841 */
         pr_default.execute(35);
         RcdFound9 = 0;
         if ( (pr_default.getStatus(35) != 101) )
         {
            RcdFound9 = 1;
            A19FlightId = T000841_A19FlightId[0];
            AssignAttri("", false, "A19FlightId", StringUtil.LTrimStr( (decimal)(A19FlightId), 4, 0));
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext089( )
      {
         /* Scan next routine */
         pr_default.readNext(35);
         RcdFound9 = 0;
         if ( (pr_default.getStatus(35) != 101) )
         {
            RcdFound9 = 1;
            A19FlightId = T000841_A19FlightId[0];
            AssignAttri("", false, "A19FlightId", StringUtil.LTrimStr( (decimal)(A19FlightId), 4, 0));
         }
      }

      protected void ScanEnd089( )
      {
         pr_default.close(35);
      }

      protected void AfterConfirm089( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert089( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate089( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete089( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete089( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate089( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes089( )
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
         edtFlightPrice_Enabled = 0;
         AssignProp("", false, edtFlightPrice_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtFlightPrice_Enabled), 5, 0), true);
         edtFlightDiscountPercentaje_Enabled = 0;
         AssignProp("", false, edtFlightDiscountPercentaje_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtFlightDiscountPercentaje_Enabled), 5, 0), true);
         edtAirlineId_Enabled = 0;
         AssignProp("", false, edtAirlineId_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtAirlineId_Enabled), 5, 0), true);
         edtAirlineName_Enabled = 0;
         AssignProp("", false, edtAirlineName_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtAirlineName_Enabled), 5, 0), true);
         edtAirlineDiscountPercentage_Enabled = 0;
         AssignProp("", false, edtAirlineDiscountPercentage_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtAirlineDiscountPercentage_Enabled), 5, 0), true);
         edtFlightFinalPrice_Enabled = 0;
         AssignProp("", false, edtFlightFinalPrice_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtFlightFinalPrice_Enabled), 5, 0), true);
         edtFlightCapacity_Enabled = 0;
         AssignProp("", false, edtFlightCapacity_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtFlightCapacity_Enabled), 5, 0), true);
      }

      protected void ZM0811( short GX_JID )
      {
         if ( ( GX_JID == 13 ) || ( GX_JID == 0 ) )
         {
            if ( ! IsIns( ) )
            {
               Z43FlightSeatLocation = T00083_A43FlightSeatLocation[0];
            }
            else
            {
               Z43FlightSeatLocation = A43FlightSeatLocation;
            }
         }
         if ( GX_JID == -13 )
         {
            Z19FlightId = A19FlightId;
            Z42FlightSeatId = A42FlightSeatId;
            Z44FlightSeatChar = A44FlightSeatChar;
            Z43FlightSeatLocation = A43FlightSeatLocation;
         }
      }

      protected void standaloneNotModal0811( )
      {
      }

      protected void standaloneModal0811( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            edtFlightSeatId_Enabled = 0;
            AssignProp("", false, edtFlightSeatId_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtFlightSeatId_Enabled), 5, 0), !bGXsfl_138_Refreshing);
         }
         else
         {
            edtFlightSeatId_Enabled = 1;
            AssignProp("", false, edtFlightSeatId_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtFlightSeatId_Enabled), 5, 0), !bGXsfl_138_Refreshing);
         }
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            cmbFlightSeatChar.Enabled = 0;
            AssignProp("", false, cmbFlightSeatChar_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(cmbFlightSeatChar.Enabled), 5, 0), !bGXsfl_138_Refreshing);
         }
         else
         {
            cmbFlightSeatChar.Enabled = 1;
            AssignProp("", false, cmbFlightSeatChar_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(cmbFlightSeatChar.Enabled), 5, 0), !bGXsfl_138_Refreshing);
         }
      }

      protected void Load0811( )
      {
         /* Using cursor T000842 */
         pr_default.execute(36, new Object[] {A19FlightId, A42FlightSeatId, A44FlightSeatChar});
         if ( (pr_default.getStatus(36) != 101) )
         {
            RcdFound11 = 1;
            A43FlightSeatLocation = T000842_A43FlightSeatLocation[0];
            ZM0811( -13) ;
         }
         pr_default.close(36);
         OnLoadActions0811( ) ;
      }

      protected void OnLoadActions0811( )
      {
      }

      protected void CheckExtendedTable0811( )
      {
         nIsDirty_11 = 0;
         Gx_BScreen = 1;
         standaloneModal0811( ) ;
         if ( ! ( ( StringUtil.StrCmp(A44FlightSeatChar, "A") == 0 ) || ( StringUtil.StrCmp(A44FlightSeatChar, "B") == 0 ) || ( StringUtil.StrCmp(A44FlightSeatChar, "C") == 0 ) || ( StringUtil.StrCmp(A44FlightSeatChar, "D") == 0 ) || ( StringUtil.StrCmp(A44FlightSeatChar, "E") == 0 ) || ( StringUtil.StrCmp(A44FlightSeatChar, "F") == 0 ) ) )
         {
            GXCCtl = "FLIGHTSEATCHAR_" + sGXsfl_138_idx;
            GX_msglist.addItem("Field Flight Seat Char is out of range", "OutOfRange", 1, GXCCtl);
            AnyError = 1;
            GX_FocusControl = cmbFlightSeatChar_Internalname;
            AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( ! ( ( StringUtil.StrCmp(A43FlightSeatLocation, "W") == 0 ) || ( StringUtil.StrCmp(A43FlightSeatLocation, "M") == 0 ) || ( StringUtil.StrCmp(A43FlightSeatLocation, "A") == 0 ) ) )
         {
            GXCCtl = "FLIGHTSEATLOCATION_" + sGXsfl_138_idx;
            GX_msglist.addItem("Field Flight Seat Location is out of range", "OutOfRange", 1, GXCCtl);
            AnyError = 1;
            GX_FocusControl = cmbFlightSeatLocation_Internalname;
            AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         }
      }

      protected void CloseExtendedTableCursors0811( )
      {
      }

      protected void enableDisable0811( )
      {
      }

      protected void GetKey0811( )
      {
         /* Using cursor T000843 */
         pr_default.execute(37, new Object[] {A19FlightId, A42FlightSeatId, A44FlightSeatChar});
         if ( (pr_default.getStatus(37) != 101) )
         {
            RcdFound11 = 1;
         }
         else
         {
            RcdFound11 = 0;
         }
         pr_default.close(37);
      }

      protected void getByPrimaryKey0811( )
      {
         /* Using cursor T00083 */
         pr_default.execute(1, new Object[] {A19FlightId, A42FlightSeatId, A44FlightSeatChar});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM0811( 13) ;
            RcdFound11 = 1;
            InitializeNonKey0811( ) ;
            A42FlightSeatId = T00083_A42FlightSeatId[0];
            A44FlightSeatChar = T00083_A44FlightSeatChar[0];
            A43FlightSeatLocation = T00083_A43FlightSeatLocation[0];
            Z19FlightId = A19FlightId;
            Z42FlightSeatId = A42FlightSeatId;
            Z44FlightSeatChar = A44FlightSeatChar;
            sMode11 = Gx_mode;
            Gx_mode = "DSP";
            AssignAttri("", false, "Gx_mode", Gx_mode);
            standaloneModal0811( ) ;
            Load0811( ) ;
            Gx_mode = sMode11;
            AssignAttri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            RcdFound11 = 0;
            InitializeNonKey0811( ) ;
            sMode11 = Gx_mode;
            Gx_mode = "DSP";
            AssignAttri("", false, "Gx_mode", Gx_mode);
            standaloneModal0811( ) ;
            Gx_mode = sMode11;
            AssignAttri("", false, "Gx_mode", Gx_mode);
         }
         if ( IsDsp( ) || IsDlt( ) )
         {
            DisableAttributes0811( ) ;
         }
         pr_default.close(1);
      }

      protected void CheckOptimisticConcurrency0811( )
      {
         if ( ! IsIns( ) )
         {
            /* Using cursor T00082 */
            pr_default.execute(0, new Object[] {A19FlightId, A42FlightSeatId, A44FlightSeatChar});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"FlightSeat"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            if ( (pr_default.getStatus(0) == 101) || ( StringUtil.StrCmp(Z43FlightSeatLocation, T00082_A43FlightSeatLocation[0]) != 0 ) )
            {
               if ( StringUtil.StrCmp(Z43FlightSeatLocation, T00082_A43FlightSeatLocation[0]) != 0 )
               {
                  GXUtil.WriteLog("flight:[seudo value changed for attri]"+"FlightSeatLocation");
                  GXUtil.WriteLogRaw("Old: ",Z43FlightSeatLocation);
                  GXUtil.WriteLogRaw("Current: ",T00082_A43FlightSeatLocation[0]);
               }
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"FlightSeat"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert0811( )
      {
         BeforeValidate0811( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0811( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM0811( 0) ;
            CheckOptimisticConcurrency0811( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0811( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert0811( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000844 */
                     pr_default.execute(38, new Object[] {A19FlightId, A42FlightSeatId, A44FlightSeatChar, A43FlightSeatLocation});
                     pr_default.close(38);
                     pr_default.SmartCacheProvider.SetUpdated("FlightSeat");
                     if ( (pr_default.getStatus(38) == 1) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, "");
                        AnyError = 1;
                     }
                     if ( AnyError == 0 )
                     {
                        /* Start of After( Insert) rules */
                        /* End of After( Insert) rules */
                        if ( AnyError == 0 )
                        {
                           /* Save values for previous() function. */
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
               Load0811( ) ;
            }
            EndLevel0811( ) ;
         }
         CloseExtendedTableCursors0811( ) ;
      }

      protected void Update0811( )
      {
         BeforeValidate0811( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0811( ) ;
         }
         if ( ( nIsMod_11 != 0 ) || ( nIsDirty_11 != 0 ) )
         {
            if ( AnyError == 0 )
            {
               CheckOptimisticConcurrency0811( ) ;
               if ( AnyError == 0 )
               {
                  AfterConfirm0811( ) ;
                  if ( AnyError == 0 )
                  {
                     BeforeUpdate0811( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Using cursor T000845 */
                        pr_default.execute(39, new Object[] {A43FlightSeatLocation, A19FlightId, A42FlightSeatId, A44FlightSeatChar});
                        pr_default.close(39);
                        pr_default.SmartCacheProvider.SetUpdated("FlightSeat");
                        if ( (pr_default.getStatus(39) == 103) )
                        {
                           GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"FlightSeat"}), "RecordIsLocked", 1, "");
                           AnyError = 1;
                        }
                        DeferredUpdate0811( ) ;
                        if ( AnyError == 0 )
                        {
                           /* Start of After( update) rules */
                           /* End of After( update) rules */
                           if ( AnyError == 0 )
                           {
                              getByPrimaryKey0811( ) ;
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
               EndLevel0811( ) ;
            }
         }
         CloseExtendedTableCursors0811( ) ;
      }

      protected void DeferredUpdate0811( )
      {
      }

      protected void Delete0811( )
      {
         Gx_mode = "DLT";
         AssignAttri("", false, "Gx_mode", Gx_mode);
         BeforeValidate0811( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0811( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls0811( ) ;
            AfterConfirm0811( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete0811( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T000846 */
                  pr_default.execute(40, new Object[] {A19FlightId, A42FlightSeatId, A44FlightSeatChar});
                  pr_default.close(40);
                  pr_default.SmartCacheProvider.SetUpdated("FlightSeat");
                  if ( AnyError == 0 )
                  {
                     /* Start of After( delete) rules */
                     /* End of After( delete) rules */
                  }
                  else
                  {
                     GX_msglist.addItem(context.GetMessage( "GXM_unexp", ""), 1, "");
                     AnyError = 1;
                  }
               }
            }
         }
         sMode11 = Gx_mode;
         Gx_mode = "DLT";
         AssignAttri("", false, "Gx_mode", Gx_mode);
         EndLevel0811( ) ;
         Gx_mode = sMode11;
         AssignAttri("", false, "Gx_mode", Gx_mode);
      }

      protected void OnDeleteControls0811( )
      {
         standaloneModal0811( ) ;
         /* No delete mode formulas found. */
      }

      protected void EndLevel0811( )
      {
         if ( ! IsIns( ) )
         {
            pr_default.close(0);
         }
         if ( AnyError != 0 )
         {
            context.wjLoc = "";
            context.nUserReturn = 0;
         }
      }

      public void ScanStart0811( )
      {
         /* Scan By routine */
         /* Using cursor T000847 */
         pr_default.execute(41, new Object[] {A19FlightId});
         RcdFound11 = 0;
         if ( (pr_default.getStatus(41) != 101) )
         {
            RcdFound11 = 1;
            A42FlightSeatId = T000847_A42FlightSeatId[0];
            A44FlightSeatChar = T000847_A44FlightSeatChar[0];
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext0811( )
      {
         /* Scan next routine */
         pr_default.readNext(41);
         RcdFound11 = 0;
         if ( (pr_default.getStatus(41) != 101) )
         {
            RcdFound11 = 1;
            A42FlightSeatId = T000847_A42FlightSeatId[0];
            A44FlightSeatChar = T000847_A44FlightSeatChar[0];
         }
      }

      protected void ScanEnd0811( )
      {
         pr_default.close(41);
      }

      protected void AfterConfirm0811( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert0811( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate0811( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete0811( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete0811( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate0811( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes0811( )
      {
         edtFlightSeatId_Enabled = 0;
         AssignProp("", false, edtFlightSeatId_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtFlightSeatId_Enabled), 5, 0), !bGXsfl_138_Refreshing);
         cmbFlightSeatChar.Enabled = 0;
         AssignProp("", false, cmbFlightSeatChar_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(cmbFlightSeatChar.Enabled), 5, 0), !bGXsfl_138_Refreshing);
         cmbFlightSeatLocation.Enabled = 0;
         AssignProp("", false, cmbFlightSeatLocation_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(cmbFlightSeatLocation.Enabled), 5, 0), !bGXsfl_138_Refreshing);
      }

      protected void send_integrity_lvl_hashes0811( )
      {
      }

      protected void send_integrity_lvl_hashes089( )
      {
      }

      protected void SubsflControlProps_13811( )
      {
         edtFlightSeatId_Internalname = "FLIGHTSEATID_"+sGXsfl_138_idx;
         cmbFlightSeatChar_Internalname = "FLIGHTSEATCHAR_"+sGXsfl_138_idx;
         cmbFlightSeatLocation_Internalname = "FLIGHTSEATLOCATION_"+sGXsfl_138_idx;
      }

      protected void SubsflControlProps_fel_13811( )
      {
         edtFlightSeatId_Internalname = "FLIGHTSEATID_"+sGXsfl_138_fel_idx;
         cmbFlightSeatChar_Internalname = "FLIGHTSEATCHAR_"+sGXsfl_138_fel_idx;
         cmbFlightSeatLocation_Internalname = "FLIGHTSEATLOCATION_"+sGXsfl_138_fel_idx;
      }

      protected void AddRow0811( )
      {
         nGXsfl_138_idx = (int)(nGXsfl_138_idx+1);
         sGXsfl_138_idx = StringUtil.PadL( StringUtil.LTrimStr( (decimal)(nGXsfl_138_idx), 4, 0), 4, "0");
         SubsflControlProps_13811( ) ;
         SendRow0811( ) ;
      }

      protected void SendRow0811( )
      {
         Gridflight_seatRow = GXWebRow.GetNew(context);
         if ( subGridflight_seat_Backcolorstyle == 0 )
         {
            /* None style subfile background logic. */
            subGridflight_seat_Backstyle = 0;
            if ( StringUtil.StrCmp(subGridflight_seat_Class, "") != 0 )
            {
               subGridflight_seat_Linesclass = subGridflight_seat_Class+"Odd";
            }
         }
         else if ( subGridflight_seat_Backcolorstyle == 1 )
         {
            /* Uniform style subfile background logic. */
            subGridflight_seat_Backstyle = 0;
            subGridflight_seat_Backcolor = subGridflight_seat_Allbackcolor;
            if ( StringUtil.StrCmp(subGridflight_seat_Class, "") != 0 )
            {
               subGridflight_seat_Linesclass = subGridflight_seat_Class+"Uniform";
            }
         }
         else if ( subGridflight_seat_Backcolorstyle == 2 )
         {
            /* Header style subfile background logic. */
            subGridflight_seat_Backstyle = 1;
            if ( StringUtil.StrCmp(subGridflight_seat_Class, "") != 0 )
            {
               subGridflight_seat_Linesclass = subGridflight_seat_Class+"Odd";
            }
            subGridflight_seat_Backcolor = (int)(0x0);
         }
         else if ( subGridflight_seat_Backcolorstyle == 3 )
         {
            /* Report style subfile background logic. */
            subGridflight_seat_Backstyle = 1;
            if ( ((int)((nGXsfl_138_idx) % (2))) == 0 )
            {
               subGridflight_seat_Backcolor = (int)(0x0);
               if ( StringUtil.StrCmp(subGridflight_seat_Class, "") != 0 )
               {
                  subGridflight_seat_Linesclass = subGridflight_seat_Class+"Even";
               }
            }
            else
            {
               subGridflight_seat_Backcolor = (int)(0x0);
               if ( StringUtil.StrCmp(subGridflight_seat_Class, "") != 0 )
               {
                  subGridflight_seat_Linesclass = subGridflight_seat_Class+"Odd";
               }
            }
         }
         /* Subfile cell */
         /* Single line edit */
         TempTags = " data-gxoch1=\"gx.fn.setControlValue('nIsMod_11_" + sGXsfl_138_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 139,'',false,'" + sGXsfl_138_idx + "',138)\"";
         ROClassString = "Attribute";
         Gridflight_seatRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(string)edtFlightSeatId_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A42FlightSeatId), 4, 0, ".", "")),StringUtil.LTrim( context.localUtil.Format( (decimal)(A42FlightSeatId), "ZZZ9"))," dir=\"ltr\" inputmode=\"numeric\" pattern=\"[0-9]*\""+TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(this,139);\"",(string)"'"+""+"'"+",false,"+"'"+""+"'",(string)"",(string)"",(string)"",(string)"",(string)edtFlightSeatId_Jsonclick,(short)0,(string)"Attribute",(string)"",(string)ROClassString,(string)"",(string)"",(short)-1,(int)edtFlightSeatId_Enabled,(short)1,(string)"text",(string)"1",(short)0,(string)"px",(short)17,(string)"px",(short)4,(short)0,(short)0,(short)138,(short)0,(short)-1,(short)0,(bool)true,(string)"Id",(string)"end",(bool)false,(string)""});
         /* Subfile cell */
         TempTags = " data-gxoch1=\"gx.fn.setControlValue('nIsMod_11_" + sGXsfl_138_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 140,'',false,'" + sGXsfl_138_idx + "',138)\"";
         GXCCtl = "FLIGHTSEATCHAR_" + sGXsfl_138_idx;
         cmbFlightSeatChar.Name = GXCCtl;
         cmbFlightSeatChar.WebTags = "";
         cmbFlightSeatChar.addItem("A", "A", 0);
         cmbFlightSeatChar.addItem("B", "B", 0);
         cmbFlightSeatChar.addItem("C", "C", 0);
         cmbFlightSeatChar.addItem("D", "D", 0);
         cmbFlightSeatChar.addItem("E", "E", 0);
         cmbFlightSeatChar.addItem("F", "F", 0);
         if ( cmbFlightSeatChar.ItemCount > 0 )
         {
            A44FlightSeatChar = cmbFlightSeatChar.getValidValue(A44FlightSeatChar);
         }
         /* ComboBox */
         Gridflight_seatRow.AddColumnProperties("combobox", 2, isAjaxCallMode( ), new Object[] {(GXCombobox)cmbFlightSeatChar,(string)cmbFlightSeatChar_Internalname,StringUtil.RTrim( A44FlightSeatChar),(short)1,(string)cmbFlightSeatChar_Jsonclick,(short)0,(string)"'"+""+"'"+",false,"+"'"+""+"'",(string)"char",(string)"",(short)-1,cmbFlightSeatChar.Enabled,(short)1,(short)0,(short)0,(string)"px",(short)0,(string)"px",(string)"",(string)"Attribute",(string)"",(string)"",TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,140);\"",(string)"",(bool)true,(short)0});
         cmbFlightSeatChar.CurrentValue = StringUtil.RTrim( A44FlightSeatChar);
         AssignProp("", false, cmbFlightSeatChar_Internalname, "Values", (string)(cmbFlightSeatChar.ToJavascriptSource()), !bGXsfl_138_Refreshing);
         /* Subfile cell */
         TempTags = " data-gxoch1=\"gx.fn.setControlValue('nIsMod_11_" + sGXsfl_138_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 141,'',false,'" + sGXsfl_138_idx + "',138)\"";
         if ( ( cmbFlightSeatLocation.ItemCount == 0 ) && isAjaxCallMode( ) )
         {
            GXCCtl = "FLIGHTSEATLOCATION_" + sGXsfl_138_idx;
            cmbFlightSeatLocation.Name = GXCCtl;
            cmbFlightSeatLocation.WebTags = "";
            cmbFlightSeatLocation.addItem("W", "Windows", 0);
            cmbFlightSeatLocation.addItem("M", "Middle", 0);
            cmbFlightSeatLocation.addItem("A", "Aisle", 0);
            if ( cmbFlightSeatLocation.ItemCount > 0 )
            {
               A43FlightSeatLocation = cmbFlightSeatLocation.getValidValue(A43FlightSeatLocation);
            }
         }
         /* ComboBox */
         Gridflight_seatRow.AddColumnProperties("combobox", 2, isAjaxCallMode( ), new Object[] {(GXCombobox)cmbFlightSeatLocation,(string)cmbFlightSeatLocation_Internalname,StringUtil.RTrim( A43FlightSeatLocation),(short)1,(string)cmbFlightSeatLocation_Jsonclick,(short)0,(string)"'"+""+"'"+",false,"+"'"+""+"'",(string)"char",(string)"",(short)-1,cmbFlightSeatLocation.Enabled,(short)0,(short)0,(short)0,(string)"px",(short)0,(string)"px",(string)"",(string)"Attribute",(string)"",(string)"",TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,141);\"",(string)"",(bool)true,(short)0});
         cmbFlightSeatLocation.CurrentValue = StringUtil.RTrim( A43FlightSeatLocation);
         AssignProp("", false, cmbFlightSeatLocation_Internalname, "Values", (string)(cmbFlightSeatLocation.ToJavascriptSource()), !bGXsfl_138_Refreshing);
         ajax_sending_grid_row(Gridflight_seatRow);
         send_integrity_lvl_hashes0811( ) ;
         GXCCtl = "Z42FlightSeatId_" + sGXsfl_138_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z42FlightSeatId), 4, 0, ".", "")));
         GXCCtl = "Z44FlightSeatChar_" + sGXsfl_138_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.RTrim( Z44FlightSeatChar));
         GXCCtl = "Z43FlightSeatLocation_" + sGXsfl_138_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.RTrim( Z43FlightSeatLocation));
         GXCCtl = "nRcdDeleted_11_" + sGXsfl_138_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_11), 4, 0, ".", "")));
         GXCCtl = "nRcdExists_11_" + sGXsfl_138_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdExists_11), 4, 0, ".", "")));
         GXCCtl = "nIsMod_11_" + sGXsfl_138_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nIsMod_11), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "FLIGHTSEATID_"+sGXsfl_138_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtFlightSeatId_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "FLIGHTSEATCHAR_"+sGXsfl_138_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(cmbFlightSeatChar.Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "FLIGHTSEATLOCATION_"+sGXsfl_138_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(cmbFlightSeatLocation.Enabled), 5, 0, ".", "")));
         ajax_sending_grid_row(null);
         Gridflight_seatContainer.AddRow(Gridflight_seatRow);
      }

      protected void ReadRow0811( )
      {
         nGXsfl_138_idx = (int)(nGXsfl_138_idx+1);
         sGXsfl_138_idx = StringUtil.PadL( StringUtil.LTrimStr( (decimal)(nGXsfl_138_idx), 4, 0), 4, "0");
         SubsflControlProps_13811( ) ;
         edtFlightSeatId_Enabled = (int)(Math.Round(context.localUtil.CToN( cgiGet( "FLIGHTSEATID_"+sGXsfl_138_idx+"Enabled"), ".", ","), 18, MidpointRounding.ToEven));
         cmbFlightSeatChar.Enabled = (int)(Math.Round(context.localUtil.CToN( cgiGet( "FLIGHTSEATCHAR_"+sGXsfl_138_idx+"Enabled"), ".", ","), 18, MidpointRounding.ToEven));
         cmbFlightSeatLocation.Enabled = (int)(Math.Round(context.localUtil.CToN( cgiGet( "FLIGHTSEATLOCATION_"+sGXsfl_138_idx+"Enabled"), ".", ","), 18, MidpointRounding.ToEven));
         if ( ( ( context.localUtil.CToN( cgiGet( edtFlightSeatId_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtFlightSeatId_Internalname), ".", ",") > Convert.ToDecimal( 9999 )) ) )
         {
            GXCCtl = "FLIGHTSEATID_" + sGXsfl_138_idx;
            GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, GXCCtl);
            AnyError = 1;
            GX_FocusControl = edtFlightSeatId_Internalname;
            wbErr = true;
            A42FlightSeatId = 0;
         }
         else
         {
            A42FlightSeatId = (short)(Math.Round(context.localUtil.CToN( cgiGet( edtFlightSeatId_Internalname), ".", ","), 18, MidpointRounding.ToEven));
         }
         cmbFlightSeatChar.Name = cmbFlightSeatChar_Internalname;
         cmbFlightSeatChar.CurrentValue = cgiGet( cmbFlightSeatChar_Internalname);
         A44FlightSeatChar = cgiGet( cmbFlightSeatChar_Internalname);
         cmbFlightSeatLocation.Name = cmbFlightSeatLocation_Internalname;
         cmbFlightSeatLocation.CurrentValue = cgiGet( cmbFlightSeatLocation_Internalname);
         A43FlightSeatLocation = cgiGet( cmbFlightSeatLocation_Internalname);
         GXCCtl = "Z42FlightSeatId_" + sGXsfl_138_idx;
         Z42FlightSeatId = (short)(Math.Round(context.localUtil.CToN( cgiGet( GXCCtl), ".", ","), 18, MidpointRounding.ToEven));
         GXCCtl = "Z44FlightSeatChar_" + sGXsfl_138_idx;
         Z44FlightSeatChar = cgiGet( GXCCtl);
         GXCCtl = "Z43FlightSeatLocation_" + sGXsfl_138_idx;
         Z43FlightSeatLocation = cgiGet( GXCCtl);
         GXCCtl = "nRcdDeleted_11_" + sGXsfl_138_idx;
         nRcdDeleted_11 = (short)(Math.Round(context.localUtil.CToN( cgiGet( GXCCtl), ".", ","), 18, MidpointRounding.ToEven));
         GXCCtl = "nRcdExists_11_" + sGXsfl_138_idx;
         nRcdExists_11 = (short)(Math.Round(context.localUtil.CToN( cgiGet( GXCCtl), ".", ","), 18, MidpointRounding.ToEven));
         GXCCtl = "nIsMod_11_" + sGXsfl_138_idx;
         nIsMod_11 = (short)(Math.Round(context.localUtil.CToN( cgiGet( GXCCtl), ".", ","), 18, MidpointRounding.ToEven));
      }

      protected void assign_properties_default( )
      {
         defcmbFlightSeatChar_Enabled = cmbFlightSeatChar.Enabled;
         defedtFlightSeatId_Enabled = edtFlightSeatId_Enabled;
      }

      protected void ConfirmValues080( )
      {
         nGXsfl_138_idx = 0;
         sGXsfl_138_idx = StringUtil.PadL( StringUtil.LTrimStr( (decimal)(nGXsfl_138_idx), 4, 0), 4, "0");
         SubsflControlProps_13811( ) ;
         while ( nGXsfl_138_idx < nRC_GXsfl_138 )
         {
            nGXsfl_138_idx = (int)(nGXsfl_138_idx+1);
            sGXsfl_138_idx = StringUtil.PadL( StringUtil.LTrimStr( (decimal)(nGXsfl_138_idx), 4, 0), 4, "0");
            SubsflControlProps_13811( ) ;
            ChangePostValue( "Z42FlightSeatId_"+sGXsfl_138_idx, cgiGet( "ZT_"+"Z42FlightSeatId_"+sGXsfl_138_idx)) ;
            DeletePostValue( "ZT_"+"Z42FlightSeatId_"+sGXsfl_138_idx) ;
            ChangePostValue( "Z44FlightSeatChar_"+sGXsfl_138_idx, cgiGet( "ZT_"+"Z44FlightSeatChar_"+sGXsfl_138_idx)) ;
            DeletePostValue( "ZT_"+"Z44FlightSeatChar_"+sGXsfl_138_idx) ;
            ChangePostValue( "Z43FlightSeatLocation_"+sGXsfl_138_idx, cgiGet( "ZT_"+"Z43FlightSeatLocation_"+sGXsfl_138_idx)) ;
            DeletePostValue( "ZT_"+"Z43FlightSeatLocation_"+sGXsfl_138_idx) ;
         }
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
         GxWebStd.gx_hidden_field( context, "Z35FlightPrice", StringUtil.LTrim( StringUtil.NToC( Z35FlightPrice, 7, 2, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z36FlightDiscountPercentaje", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z36FlightDiscountPercentaje), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z38AirlineId", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z38AirlineId), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z25FlightArrivalAirportId", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z25FlightArrivalAirportId), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z24FlightDepartureAirportId", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z24FlightDepartureAirportId), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "IsConfirmed", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsConfirmed), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "IsModified", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsModified), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Mode", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "nRC_GXsfl_138", StringUtil.LTrim( StringUtil.NToC( (decimal)(nGXsfl_138_idx), 8, 0, ".", "")));
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

      protected void InitializeNonKey089( )
      {
         A37FlightFinalPrice = 0;
         AssignAttri("", false, "A37FlightFinalPrice", StringUtil.LTrimStr( A37FlightFinalPrice, 7, 2));
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
         A35FlightPrice = 0;
         AssignAttri("", false, "A35FlightPrice", StringUtil.LTrimStr( A35FlightPrice, 7, 2));
         A36FlightDiscountPercentaje = 0;
         AssignAttri("", false, "A36FlightDiscountPercentaje", StringUtil.LTrimStr( (decimal)(A36FlightDiscountPercentaje), 4, 0));
         A38AirlineId = 0;
         n38AirlineId = false;
         AssignAttri("", false, "A38AirlineId", StringUtil.LTrimStr( (decimal)(A38AirlineId), 4, 0));
         n38AirlineId = ((0==A38AirlineId) ? true : false);
         A39AirlineName = "";
         AssignAttri("", false, "A39AirlineName", A39AirlineName);
         A40AirlineDiscountPercentage = 0;
         AssignAttri("", false, "A40AirlineDiscountPercentage", StringUtil.LTrimStr( (decimal)(A40AirlineDiscountPercentage), 4, 0));
         A45FlightCapacity = 0;
         n45FlightCapacity = false;
         AssignAttri("", false, "A45FlightCapacity", StringUtil.LTrimStr( (decimal)(A45FlightCapacity), 4, 0));
         Z35FlightPrice = 0;
         Z36FlightDiscountPercentaje = 0;
         Z38AirlineId = 0;
         Z25FlightArrivalAirportId = 0;
         Z24FlightDepartureAirportId = 0;
      }

      protected void InitAll089( )
      {
         A19FlightId = 0;
         AssignAttri("", false, "A19FlightId", StringUtil.LTrimStr( (decimal)(A19FlightId), 4, 0));
         InitializeNonKey089( ) ;
      }

      protected void StandaloneModalInsert( )
      {
      }

      protected void InitializeNonKey0811( )
      {
         A43FlightSeatLocation = "";
         Z43FlightSeatLocation = "";
      }

      protected void InitAll0811( )
      {
         A42FlightSeatId = 0;
         A44FlightSeatChar = "";
         InitializeNonKey0811( ) ;
      }

      protected void StandaloneModalInsert0811( )
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
            context.AddJavascriptSource(StringUtil.RTrim( ((string)Form.Jscriptsrc.Item(idxLst))), "?202392016271271", true, true);
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
         context.AddJavascriptSource("flight.js", "?202392016271271", false, true);
         /* End function include_jscripts */
      }

      protected void init_level_properties11( )
      {
         cmbFlightSeatChar.Enabled = defcmbFlightSeatChar_Enabled;
         AssignProp("", false, cmbFlightSeatChar_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(cmbFlightSeatChar.Enabled), 5, 0), !bGXsfl_138_Refreshing);
         edtFlightSeatId_Enabled = defedtFlightSeatId_Enabled;
         AssignProp("", false, edtFlightSeatId_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtFlightSeatId_Enabled), 5, 0), !bGXsfl_138_Refreshing);
      }

      protected void StartGridControl138( )
      {
         Gridflight_seatContainer.AddObjectProperty("GridName", "Gridflight_seat");
         Gridflight_seatContainer.AddObjectProperty("Header", subGridflight_seat_Header);
         Gridflight_seatContainer.AddObjectProperty("Class", "Grid");
         Gridflight_seatContainer.AddObjectProperty("Cellpadding", StringUtil.LTrim( StringUtil.NToC( (decimal)(1), 4, 0, ".", "")));
         Gridflight_seatContainer.AddObjectProperty("Cellspacing", StringUtil.LTrim( StringUtil.NToC( (decimal)(2), 4, 0, ".", "")));
         Gridflight_seatContainer.AddObjectProperty("Backcolorstyle", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridflight_seat_Backcolorstyle), 1, 0, ".", "")));
         Gridflight_seatContainer.AddObjectProperty("CmpContext", "");
         Gridflight_seatContainer.AddObjectProperty("InMasterPage", "false");
         Gridflight_seatColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
         Gridflight_seatColumn.AddObjectProperty("Value", GXUtil.ValueEncode( StringUtil.LTrim( StringUtil.NToC( (decimal)(A42FlightSeatId), 4, 0, ".", ""))));
         Gridflight_seatColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtFlightSeatId_Enabled), 5, 0, ".", "")));
         Gridflight_seatContainer.AddColumnProperties(Gridflight_seatColumn);
         Gridflight_seatColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
         Gridflight_seatColumn.AddObjectProperty("Value", GXUtil.ValueEncode( StringUtil.RTrim( A44FlightSeatChar)));
         Gridflight_seatColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(cmbFlightSeatChar.Enabled), 5, 0, ".", "")));
         Gridflight_seatContainer.AddColumnProperties(Gridflight_seatColumn);
         Gridflight_seatColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
         Gridflight_seatColumn.AddObjectProperty("Value", GXUtil.ValueEncode( StringUtil.RTrim( A43FlightSeatLocation)));
         Gridflight_seatColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(cmbFlightSeatLocation.Enabled), 5, 0, ".", "")));
         Gridflight_seatContainer.AddColumnProperties(Gridflight_seatColumn);
         Gridflight_seatContainer.AddObjectProperty("Selectedindex", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridflight_seat_Selectedindex), 4, 0, ".", "")));
         Gridflight_seatContainer.AddObjectProperty("Allowselection", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridflight_seat_Allowselection), 1, 0, ".", "")));
         Gridflight_seatContainer.AddObjectProperty("Selectioncolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridflight_seat_Selectioncolor), 9, 0, ".", "")));
         Gridflight_seatContainer.AddObjectProperty("Allowhover", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridflight_seat_Allowhovering), 1, 0, ".", "")));
         Gridflight_seatContainer.AddObjectProperty("Hovercolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridflight_seat_Hoveringcolor), 9, 0, ".", "")));
         Gridflight_seatContainer.AddObjectProperty("Allowcollapsing", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridflight_seat_Allowcollapsing), 1, 0, ".", "")));
         Gridflight_seatContainer.AddObjectProperty("Collapsed", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridflight_seat_Collapsed), 1, 0, ".", "")));
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
         edtFlightPrice_Internalname = "FLIGHTPRICE";
         edtFlightDiscountPercentaje_Internalname = "FLIGHTDISCOUNTPERCENTAJE";
         edtAirlineId_Internalname = "AIRLINEID";
         edtAirlineName_Internalname = "AIRLINENAME";
         edtAirlineDiscountPercentage_Internalname = "AIRLINEDISCOUNTPERCENTAGE";
         edtFlightFinalPrice_Internalname = "FLIGHTFINALPRICE";
         edtFlightCapacity_Internalname = "FLIGHTCAPACITY";
         lblTitleseat_Internalname = "TITLESEAT";
         edtFlightSeatId_Internalname = "FLIGHTSEATID";
         cmbFlightSeatChar_Internalname = "FLIGHTSEATCHAR";
         cmbFlightSeatLocation_Internalname = "FLIGHTSEATLOCATION";
         divSeattable_Internalname = "SEATTABLE";
         divFormcontainer_Internalname = "FORMCONTAINER";
         bttBtn_enter_Internalname = "BTN_ENTER";
         bttBtn_cancel_Internalname = "BTN_CANCEL";
         bttBtn_delete_Internalname = "BTN_DELETE";
         divMaintable_Internalname = "MAINTABLE";
         Form.Internalname = "FORM";
         imgprompt_25_Internalname = "PROMPT_25";
         imgprompt_24_Internalname = "PROMPT_24";
         imgprompt_38_Internalname = "PROMPT_38";
         subGridflight_seat_Internalname = "GRIDFLIGHT_SEAT";
      }

      public override void initialize_properties( )
      {
         context.SetDefaultTheme("TravelAgency_Capa202309", true);
         if ( context.isSpaRequest( ) )
         {
            disableJsOutput();
         }
         init_default_properties( ) ;
         subGridflight_seat_Allowcollapsing = 0;
         subGridflight_seat_Allowselection = 0;
         subGridflight_seat_Header = "";
         Form.Headerrawhtml = "";
         Form.Background = "";
         Form.Textcolor = 0;
         Form.Backcolor = (int)(0xFFFFFF);
         Form.Caption = "Flight";
         cmbFlightSeatLocation_Jsonclick = "";
         cmbFlightSeatChar_Jsonclick = "";
         edtFlightSeatId_Jsonclick = "";
         subGridflight_seat_Class = "Grid";
         subGridflight_seat_Backcolorstyle = 0;
         cmbFlightSeatLocation.Enabled = 1;
         cmbFlightSeatChar.Enabled = 1;
         edtFlightSeatId_Enabled = 1;
         bttBtn_delete_Enabled = 1;
         bttBtn_delete_Visible = 1;
         bttBtn_cancel_Visible = 1;
         bttBtn_enter_Enabled = 1;
         bttBtn_enter_Visible = 1;
         edtFlightCapacity_Jsonclick = "";
         edtFlightCapacity_Enabled = 0;
         edtFlightFinalPrice_Jsonclick = "";
         edtFlightFinalPrice_Enabled = 0;
         edtAirlineDiscountPercentage_Jsonclick = "";
         edtAirlineDiscountPercentage_Enabled = 0;
         edtAirlineName_Jsonclick = "";
         edtAirlineName_Enabled = 0;
         imgprompt_38_Visible = 1;
         imgprompt_38_Link = "";
         edtAirlineId_Jsonclick = "";
         edtAirlineId_Enabled = 1;
         edtFlightDiscountPercentaje_Jsonclick = "";
         edtFlightDiscountPercentaje_Enabled = 1;
         edtFlightPrice_Jsonclick = "";
         edtFlightPrice_Enabled = 1;
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

      protected void gxnrGridflight_seat_newrow( )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         Gx_mode = "INS";
         AssignAttri("", false, "Gx_mode", Gx_mode);
         SubsflControlProps_13811( ) ;
         while ( nGXsfl_138_idx <= nRC_GXsfl_138 )
         {
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            standaloneNotModal0811( ) ;
            standaloneModal0811( ) ;
            init_web_controls( ) ;
            dynload_actions( ) ;
            SendRow0811( ) ;
            nGXsfl_138_idx = (int)(nGXsfl_138_idx+1);
            sGXsfl_138_idx = StringUtil.PadL( StringUtil.LTrimStr( (decimal)(nGXsfl_138_idx), 4, 0), 4, "0");
            SubsflControlProps_13811( ) ;
         }
         AddString( context.httpAjaxContext.getJSONContainerResponse( Gridflight_seatContainer)) ;
         /* End function gxnrGridflight_seat_newrow */
      }

      protected void init_web_controls( )
      {
         GXCCtl = "FLIGHTSEATCHAR_" + sGXsfl_138_idx;
         cmbFlightSeatChar.Name = GXCCtl;
         cmbFlightSeatChar.WebTags = "";
         cmbFlightSeatChar.addItem("A", "A", 0);
         cmbFlightSeatChar.addItem("B", "B", 0);
         cmbFlightSeatChar.addItem("C", "C", 0);
         cmbFlightSeatChar.addItem("D", "D", 0);
         cmbFlightSeatChar.addItem("E", "E", 0);
         cmbFlightSeatChar.addItem("F", "F", 0);
         if ( cmbFlightSeatChar.ItemCount > 0 )
         {
            A44FlightSeatChar = cmbFlightSeatChar.getValidValue(A44FlightSeatChar);
         }
         GXCCtl = "FLIGHTSEATLOCATION_" + sGXsfl_138_idx;
         cmbFlightSeatLocation.Name = GXCCtl;
         cmbFlightSeatLocation.WebTags = "";
         cmbFlightSeatLocation.addItem("W", "Windows", 0);
         cmbFlightSeatLocation.addItem("M", "Middle", 0);
         cmbFlightSeatLocation.addItem("A", "Aisle", 0);
         if ( cmbFlightSeatLocation.ItemCount > 0 )
         {
            A43FlightSeatLocation = cmbFlightSeatLocation.getValidValue(A43FlightSeatLocation);
         }
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
         /* Using cursor T000833 */
         pr_default.execute(27, new Object[] {A19FlightId});
         if ( (pr_default.getStatus(27) != 101) )
         {
            A45FlightCapacity = T000833_A45FlightCapacity[0];
            n45FlightCapacity = T000833_n45FlightCapacity[0];
         }
         else
         {
            A45FlightCapacity = 0;
            n45FlightCapacity = false;
         }
         pr_default.close(27);
         dynload_actions( ) ;
         /*  Sending validation outputs */
         AssignAttri("", false, "A25FlightArrivalAirportId", StringUtil.LTrim( StringUtil.NToC( (decimal)(A25FlightArrivalAirportId), 4, 0, ".", "")));
         AssignAttri("", false, "A24FlightDepartureAirportId", StringUtil.LTrim( StringUtil.NToC( (decimal)(A24FlightDepartureAirportId), 4, 0, ".", "")));
         AssignAttri("", false, "A35FlightPrice", StringUtil.LTrim( StringUtil.NToC( A35FlightPrice, 7, 2, ".", "")));
         AssignAttri("", false, "A36FlightDiscountPercentaje", StringUtil.LTrim( StringUtil.NToC( (decimal)(A36FlightDiscountPercentaje), 4, 0, ".", "")));
         AssignAttri("", false, "A38AirlineId", StringUtil.LTrim( StringUtil.NToC( (decimal)(A38AirlineId), 4, 0, ".", "")));
         AssignAttri("", false, "A45FlightCapacity", StringUtil.LTrim( StringUtil.NToC( (decimal)(A45FlightCapacity), 4, 0, ".", "")));
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
         AssignAttri("", false, "A39AirlineName", A39AirlineName);
         AssignAttri("", false, "A40AirlineDiscountPercentage", StringUtil.LTrim( StringUtil.NToC( (decimal)(A40AirlineDiscountPercentage), 4, 0, ".", "")));
         AssignAttri("", false, "A37FlightFinalPrice", StringUtil.LTrim( StringUtil.NToC( A37FlightFinalPrice, 7, 2, ".", "")));
         AssignAttri("", false, "Gx_mode", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "Z19FlightId", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z19FlightId), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z25FlightArrivalAirportId", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z25FlightArrivalAirportId), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z24FlightDepartureAirportId", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z24FlightDepartureAirportId), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z35FlightPrice", StringUtil.LTrim( StringUtil.NToC( Z35FlightPrice, 7, 2, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z36FlightDiscountPercentaje", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z36FlightDiscountPercentaje), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z38AirlineId", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z38AirlineId), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z45FlightCapacity", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z45FlightCapacity), 4, 0, ".", "")));
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
         GxWebStd.gx_hidden_field( context, "Z39AirlineName", Z39AirlineName);
         GxWebStd.gx_hidden_field( context, "Z40AirlineDiscountPercentage", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z40AirlineDiscountPercentage), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z37FlightFinalPrice", StringUtil.LTrim( StringUtil.NToC( Z37FlightFinalPrice, 7, 2, ".", "")));
         AssignProp("", false, bttBtn_delete_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(bttBtn_delete_Enabled), 5, 0), true);
         AssignProp("", false, bttBtn_enter_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(bttBtn_enter_Enabled), 5, 0), true);
         SendCloseFormHiddens( ) ;
      }

      public void Valid_Flightarrivalairportid( )
      {
         /* Using cursor T000834 */
         pr_default.execute(28, new Object[] {A25FlightArrivalAirportId});
         if ( (pr_default.getStatus(28) == 101) )
         {
            GX_msglist.addItem("No matching 'Flight Arrival Airport'.", "ForeignKeyNotFound", 1, "FLIGHTARRIVALAIRPORTID");
            AnyError = 1;
            GX_FocusControl = edtFlightArrivalAirportId_Internalname;
         }
         A26FlightArrivalAirportName = T000834_A26FlightArrivalAirportName[0];
         A31FlightArrivalCountryId = T000834_A31FlightArrivalCountryId[0];
         A33FlightArrivalCityId = T000834_A33FlightArrivalCityId[0];
         pr_default.close(28);
         /* Using cursor T000835 */
         pr_default.execute(29, new Object[] {A31FlightArrivalCountryId});
         if ( (pr_default.getStatus(29) == 101) )
         {
            GX_msglist.addItem("No matching 'Flight Arrival Airport'.", "ForeignKeyNotFound", 1, "FLIGHTARRIVALCOUNTRYID");
            AnyError = 1;
         }
         A32FlightArrivalCountryName = T000835_A32FlightArrivalCountryName[0];
         pr_default.close(29);
         /* Using cursor T000836 */
         pr_default.execute(30, new Object[] {A31FlightArrivalCountryId, A33FlightArrivalCityId});
         if ( (pr_default.getStatus(30) == 101) )
         {
            GX_msglist.addItem("No matching 'Flight Arrival Airport'.", "ForeignKeyNotFound", 1, "FLIGHTARRIVALCITYID");
            AnyError = 1;
         }
         A34FlightArrivalCityName = T000836_A34FlightArrivalCityName[0];
         pr_default.close(30);
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
         /* Using cursor T000837 */
         pr_default.execute(31, new Object[] {A24FlightDepartureAirportId});
         if ( (pr_default.getStatus(31) == 101) )
         {
            GX_msglist.addItem("No matching 'Flight Departure Airport'.", "ForeignKeyNotFound", 1, "FLIGHTDEPARTUREAIRPORTID");
            AnyError = 1;
            GX_FocusControl = edtFlightDepartureAirportId_Internalname;
         }
         A23FlightDepartureAirportName = T000837_A23FlightDepartureAirportName[0];
         A27FlightDepartureCountryId = T000837_A27FlightDepartureCountryId[0];
         A29FlightDepartureCityId = T000837_A29FlightDepartureCityId[0];
         pr_default.close(31);
         /* Using cursor T000838 */
         pr_default.execute(32, new Object[] {A27FlightDepartureCountryId});
         if ( (pr_default.getStatus(32) == 101) )
         {
            GX_msglist.addItem("No matching 'Flight Departure Airport'.", "ForeignKeyNotFound", 1, "FLIGHTDEPARTURECOUNTRYID");
            AnyError = 1;
         }
         A28FlightDepartureCountryName = T000838_A28FlightDepartureCountryName[0];
         pr_default.close(32);
         /* Using cursor T000839 */
         pr_default.execute(33, new Object[] {A27FlightDepartureCountryId, A29FlightDepartureCityId});
         if ( (pr_default.getStatus(33) == 101) )
         {
            GX_msglist.addItem("No matching 'Flight Departure Airport'.", "ForeignKeyNotFound", 1, "FLIGHTDEPARTURECITYID");
            AnyError = 1;
         }
         A30FlightDepartureCityName = T000839_A30FlightDepartureCityName[0];
         pr_default.close(33);
         dynload_actions( ) ;
         /*  Sending validation outputs */
         AssignAttri("", false, "A23FlightDepartureAirportName", A23FlightDepartureAirportName);
         AssignAttri("", false, "A27FlightDepartureCountryId", StringUtil.LTrim( StringUtil.NToC( (decimal)(A27FlightDepartureCountryId), 4, 0, ".", "")));
         AssignAttri("", false, "A29FlightDepartureCityId", StringUtil.LTrim( StringUtil.NToC( (decimal)(A29FlightDepartureCityId), 4, 0, ".", "")));
         AssignAttri("", false, "A28FlightDepartureCountryName", A28FlightDepartureCountryName);
         AssignAttri("", false, "A30FlightDepartureCityName", A30FlightDepartureCityName);
      }

      public void Valid_Airlineid( )
      {
         n38AirlineId = false;
         /* Using cursor T000840 */
         pr_default.execute(34, new Object[] {n38AirlineId, A38AirlineId});
         if ( (pr_default.getStatus(34) == 101) )
         {
            if ( ! ( (0==A38AirlineId) ) )
            {
               GX_msglist.addItem("No matching 'Airline'.", "ForeignKeyNotFound", 1, "AIRLINEID");
               AnyError = 1;
               GX_FocusControl = edtAirlineId_Internalname;
            }
         }
         A39AirlineName = T000840_A39AirlineName[0];
         A40AirlineDiscountPercentage = T000840_A40AirlineDiscountPercentage[0];
         pr_default.close(34);
         if ( A40AirlineDiscountPercentage >= A36FlightDiscountPercentaje )
         {
            A37FlightFinalPrice = (decimal)(A35FlightPrice*(1-A40AirlineDiscountPercentage/ (decimal)(100)));
         }
         else
         {
            A37FlightFinalPrice = (decimal)(A35FlightPrice*(1-A36FlightDiscountPercentaje/ (decimal)(100)));
         }
         dynload_actions( ) ;
         /*  Sending validation outputs */
         AssignAttri("", false, "A39AirlineName", A39AirlineName);
         AssignAttri("", false, "A40AirlineDiscountPercentage", StringUtil.LTrim( StringUtil.NToC( (decimal)(A40AirlineDiscountPercentage), 4, 0, ".", "")));
         AssignAttri("", false, "A37FlightFinalPrice", StringUtil.LTrim( StringUtil.NToC( A37FlightFinalPrice, 7, 2, ".", "")));
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
         setEventMetadata("VALID_FLIGHTID",",oparms:[{av:'A25FlightArrivalAirportId',fld:'FLIGHTARRIVALAIRPORTID',pic:'ZZZ9'},{av:'A24FlightDepartureAirportId',fld:'FLIGHTDEPARTUREAIRPORTID',pic:'ZZZ9'},{av:'A35FlightPrice',fld:'FLIGHTPRICE',pic:'ZZZ9.99'},{av:'A36FlightDiscountPercentaje',fld:'FLIGHTDISCOUNTPERCENTAJE',pic:'ZZZ9'},{av:'A38AirlineId',fld:'AIRLINEID',pic:'ZZZ9'},{av:'A45FlightCapacity',fld:'FLIGHTCAPACITY',pic:'ZZZ9'},{av:'A26FlightArrivalAirportName',fld:'FLIGHTARRIVALAIRPORTNAME',pic:''},{av:'A31FlightArrivalCountryId',fld:'FLIGHTARRIVALCOUNTRYID',pic:'ZZZ9'},{av:'A33FlightArrivalCityId',fld:'FLIGHTARRIVALCITYID',pic:'ZZZ9'},{av:'A32FlightArrivalCountryName',fld:'FLIGHTARRIVALCOUNTRYNAME',pic:''},{av:'A34FlightArrivalCityName',fld:'FLIGHTARRIVALCITYNAME',pic:''},{av:'A23FlightDepartureAirportName',fld:'FLIGHTDEPARTUREAIRPORTNAME',pic:''},{av:'A27FlightDepartureCountryId',fld:'FLIGHTDEPARTURECOUNTRYID',pic:'ZZZ9'},{av:'A29FlightDepartureCityId',fld:'FLIGHTDEPARTURECITYID',pic:'ZZZ9'},{av:'A28FlightDepartureCountryName',fld:'FLIGHTDEPARTURECOUNTRYNAME',pic:''},{av:'A30FlightDepartureCityName',fld:'FLIGHTDEPARTURECITYNAME',pic:''},{av:'A39AirlineName',fld:'AIRLINENAME',pic:''},{av:'A40AirlineDiscountPercentage',fld:'AIRLINEDISCOUNTPERCENTAGE',pic:'ZZZ9'},{av:'A37FlightFinalPrice',fld:'FLIGHTFINALPRICE',pic:'ZZZ9.99'},{av:'Gx_mode',fld:'vMODE',pic:'@!'},{av:'Z19FlightId'},{av:'Z25FlightArrivalAirportId'},{av:'Z24FlightDepartureAirportId'},{av:'Z35FlightPrice'},{av:'Z36FlightDiscountPercentaje'},{av:'Z38AirlineId'},{av:'Z45FlightCapacity'},{av:'Z26FlightArrivalAirportName'},{av:'Z31FlightArrivalCountryId'},{av:'Z33FlightArrivalCityId'},{av:'Z32FlightArrivalCountryName'},{av:'Z34FlightArrivalCityName'},{av:'Z23FlightDepartureAirportName'},{av:'Z27FlightDepartureCountryId'},{av:'Z29FlightDepartureCityId'},{av:'Z28FlightDepartureCountryName'},{av:'Z30FlightDepartureCityName'},{av:'Z39AirlineName'},{av:'Z40AirlineDiscountPercentage'},{av:'Z37FlightFinalPrice'},{ctrl:'BTN_DELETE',prop:'Enabled'},{ctrl:'BTN_ENTER',prop:'Enabled'}]}");
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
         setEventMetadata("VALID_FLIGHTPRICE","{handler:'Valid_Flightprice',iparms:[]");
         setEventMetadata("VALID_FLIGHTPRICE",",oparms:[]}");
         setEventMetadata("VALID_FLIGHTDISCOUNTPERCENTAJE","{handler:'Valid_Flightdiscountpercentaje',iparms:[]");
         setEventMetadata("VALID_FLIGHTDISCOUNTPERCENTAJE",",oparms:[]}");
         setEventMetadata("VALID_AIRLINEID","{handler:'Valid_Airlineid',iparms:[{av:'A38AirlineId',fld:'AIRLINEID',pic:'ZZZ9'},{av:'A35FlightPrice',fld:'FLIGHTPRICE',pic:'ZZZ9.99'},{av:'A40AirlineDiscountPercentage',fld:'AIRLINEDISCOUNTPERCENTAGE',pic:'ZZZ9'},{av:'A36FlightDiscountPercentaje',fld:'FLIGHTDISCOUNTPERCENTAJE',pic:'ZZZ9'},{av:'A39AirlineName',fld:'AIRLINENAME',pic:''},{av:'A37FlightFinalPrice',fld:'FLIGHTFINALPRICE',pic:'ZZZ9.99'}]");
         setEventMetadata("VALID_AIRLINEID",",oparms:[{av:'A39AirlineName',fld:'AIRLINENAME',pic:''},{av:'A40AirlineDiscountPercentage',fld:'AIRLINEDISCOUNTPERCENTAGE',pic:'ZZZ9'},{av:'A37FlightFinalPrice',fld:'FLIGHTFINALPRICE',pic:'ZZZ9.99'}]}");
         setEventMetadata("VALID_AIRLINEDISCOUNTPERCENTAGE","{handler:'Valid_Airlinediscountpercentage',iparms:[]");
         setEventMetadata("VALID_AIRLINEDISCOUNTPERCENTAGE",",oparms:[]}");
         setEventMetadata("VALID_FLIGHTSEATID","{handler:'Valid_Flightseatid',iparms:[]");
         setEventMetadata("VALID_FLIGHTSEATID",",oparms:[]}");
         setEventMetadata("VALID_FLIGHTSEATCHAR","{handler:'Valid_Flightseatchar',iparms:[]");
         setEventMetadata("VALID_FLIGHTSEATCHAR",",oparms:[]}");
         setEventMetadata("VALID_FLIGHTSEATLOCATION","{handler:'Valid_Flightseatlocation',iparms:[]");
         setEventMetadata("VALID_FLIGHTSEATLOCATION",",oparms:[]}");
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
         pr_default.close(4);
         pr_default.close(34);
         pr_default.close(28);
         pr_default.close(31);
         pr_default.close(29);
         pr_default.close(30);
         pr_default.close(32);
         pr_default.close(33);
         pr_default.close(27);
      }

      public override void initialize( )
      {
         sPrefix = "";
         Z44FlightSeatChar = "";
         Z43FlightSeatLocation = "";
         scmdbuf = "";
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         GXKey = "";
         PreviousTooltip = "";
         PreviousCaption = "";
         Form = new GXWebForm();
         GX_FocusControl = "";
         Gx_mode = "";
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
         imgprompt_38_gximage = "";
         A39AirlineName = "";
         lblTitleseat_Jsonclick = "";
         bttBtn_enter_Jsonclick = "";
         bttBtn_cancel_Jsonclick = "";
         bttBtn_delete_Jsonclick = "";
         Gridflight_seatContainer = new GXWebGrid( context);
         sMode11 = "";
         sStyleString = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         endTrnMsgTxt = "";
         endTrnMsgCod = "";
         GXCCtl = "";
         A44FlightSeatChar = "";
         A43FlightSeatLocation = "";
         T00085_A45FlightCapacity = new short[1] ;
         T00085_n45FlightCapacity = new bool[] {false} ;
         Z26FlightArrivalAirportName = "";
         Z32FlightArrivalCountryName = "";
         Z34FlightArrivalCityName = "";
         Z23FlightDepartureAirportName = "";
         Z28FlightDepartureCountryName = "";
         Z30FlightDepartureCityName = "";
         Z39AirlineName = "";
         T000816_A19FlightId = new short[1] ;
         T000816_A26FlightArrivalAirportName = new string[] {""} ;
         T000816_A32FlightArrivalCountryName = new string[] {""} ;
         T000816_A34FlightArrivalCityName = new string[] {""} ;
         T000816_A23FlightDepartureAirportName = new string[] {""} ;
         T000816_A28FlightDepartureCountryName = new string[] {""} ;
         T000816_A30FlightDepartureCityName = new string[] {""} ;
         T000816_A35FlightPrice = new decimal[1] ;
         T000816_A36FlightDiscountPercentaje = new short[1] ;
         T000816_A39AirlineName = new string[] {""} ;
         T000816_A40AirlineDiscountPercentage = new short[1] ;
         T000816_A38AirlineId = new short[1] ;
         T000816_n38AirlineId = new bool[] {false} ;
         T000816_A25FlightArrivalAirportId = new short[1] ;
         T000816_A24FlightDepartureAirportId = new short[1] ;
         T000816_A31FlightArrivalCountryId = new short[1] ;
         T000816_A33FlightArrivalCityId = new short[1] ;
         T000816_A27FlightDepartureCountryId = new short[1] ;
         T000816_A29FlightDepartureCityId = new short[1] ;
         T000816_A45FlightCapacity = new short[1] ;
         T000816_n45FlightCapacity = new bool[] {false} ;
         T00089_A26FlightArrivalAirportName = new string[] {""} ;
         T00089_A31FlightArrivalCountryId = new short[1] ;
         T00089_A33FlightArrivalCityId = new short[1] ;
         T000811_A32FlightArrivalCountryName = new string[] {""} ;
         T000812_A34FlightArrivalCityName = new string[] {""} ;
         T000810_A23FlightDepartureAirportName = new string[] {""} ;
         T000810_A27FlightDepartureCountryId = new short[1] ;
         T000810_A29FlightDepartureCityId = new short[1] ;
         T000813_A28FlightDepartureCountryName = new string[] {""} ;
         T000814_A30FlightDepartureCityName = new string[] {""} ;
         T00088_A39AirlineName = new string[] {""} ;
         T00088_A40AirlineDiscountPercentage = new short[1] ;
         T000818_A45FlightCapacity = new short[1] ;
         T000818_n45FlightCapacity = new bool[] {false} ;
         T000819_A26FlightArrivalAirportName = new string[] {""} ;
         T000819_A31FlightArrivalCountryId = new short[1] ;
         T000819_A33FlightArrivalCityId = new short[1] ;
         T000820_A32FlightArrivalCountryName = new string[] {""} ;
         T000821_A34FlightArrivalCityName = new string[] {""} ;
         T000822_A23FlightDepartureAirportName = new string[] {""} ;
         T000822_A27FlightDepartureCountryId = new short[1] ;
         T000822_A29FlightDepartureCityId = new short[1] ;
         T000823_A28FlightDepartureCountryName = new string[] {""} ;
         T000824_A30FlightDepartureCityName = new string[] {""} ;
         T000825_A39AirlineName = new string[] {""} ;
         T000825_A40AirlineDiscountPercentage = new short[1] ;
         T000826_A19FlightId = new short[1] ;
         T00087_A19FlightId = new short[1] ;
         T00087_A35FlightPrice = new decimal[1] ;
         T00087_A36FlightDiscountPercentaje = new short[1] ;
         T00087_A38AirlineId = new short[1] ;
         T00087_n38AirlineId = new bool[] {false} ;
         T00087_A25FlightArrivalAirportId = new short[1] ;
         T00087_A24FlightDepartureAirportId = new short[1] ;
         sMode9 = "";
         T000827_A19FlightId = new short[1] ;
         T000828_A19FlightId = new short[1] ;
         T00086_A19FlightId = new short[1] ;
         T00086_A35FlightPrice = new decimal[1] ;
         T00086_A36FlightDiscountPercentaje = new short[1] ;
         T00086_A38AirlineId = new short[1] ;
         T00086_n38AirlineId = new bool[] {false} ;
         T00086_A25FlightArrivalAirportId = new short[1] ;
         T00086_A24FlightDepartureAirportId = new short[1] ;
         T000829_A19FlightId = new short[1] ;
         T000833_A45FlightCapacity = new short[1] ;
         T000833_n45FlightCapacity = new bool[] {false} ;
         T000834_A26FlightArrivalAirportName = new string[] {""} ;
         T000834_A31FlightArrivalCountryId = new short[1] ;
         T000834_A33FlightArrivalCityId = new short[1] ;
         T000835_A32FlightArrivalCountryName = new string[] {""} ;
         T000836_A34FlightArrivalCityName = new string[] {""} ;
         T000837_A23FlightDepartureAirportName = new string[] {""} ;
         T000837_A27FlightDepartureCountryId = new short[1] ;
         T000837_A29FlightDepartureCityId = new short[1] ;
         T000838_A28FlightDepartureCountryName = new string[] {""} ;
         T000839_A30FlightDepartureCityName = new string[] {""} ;
         T000840_A39AirlineName = new string[] {""} ;
         T000840_A40AirlineDiscountPercentage = new short[1] ;
         T000841_A19FlightId = new short[1] ;
         T000842_A19FlightId = new short[1] ;
         T000842_A42FlightSeatId = new short[1] ;
         T000842_A44FlightSeatChar = new string[] {""} ;
         T000842_A43FlightSeatLocation = new string[] {""} ;
         T000843_A19FlightId = new short[1] ;
         T000843_A42FlightSeatId = new short[1] ;
         T000843_A44FlightSeatChar = new string[] {""} ;
         T00083_A19FlightId = new short[1] ;
         T00083_A42FlightSeatId = new short[1] ;
         T00083_A44FlightSeatChar = new string[] {""} ;
         T00083_A43FlightSeatLocation = new string[] {""} ;
         T00082_A19FlightId = new short[1] ;
         T00082_A42FlightSeatId = new short[1] ;
         T00082_A44FlightSeatChar = new string[] {""} ;
         T00082_A43FlightSeatLocation = new string[] {""} ;
         T000847_A19FlightId = new short[1] ;
         T000847_A42FlightSeatId = new short[1] ;
         T000847_A44FlightSeatChar = new string[] {""} ;
         Gridflight_seatRow = new GXWebRow();
         subGridflight_seat_Linesclass = "";
         ROClassString = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         Gridflight_seatColumn = new GXWebColumn();
         ZZ26FlightArrivalAirportName = "";
         ZZ32FlightArrivalCountryName = "";
         ZZ34FlightArrivalCityName = "";
         ZZ23FlightDepartureAirportName = "";
         ZZ28FlightDepartureCountryName = "";
         ZZ30FlightDepartureCityName = "";
         ZZ39AirlineName = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.flight__default(),
            new Object[][] {
                new Object[] {
               T00082_A19FlightId, T00082_A42FlightSeatId, T00082_A44FlightSeatChar, T00082_A43FlightSeatLocation
               }
               , new Object[] {
               T00083_A19FlightId, T00083_A42FlightSeatId, T00083_A44FlightSeatChar, T00083_A43FlightSeatLocation
               }
               , new Object[] {
               T00085_A45FlightCapacity, T00085_n45FlightCapacity
               }
               , new Object[] {
               T00086_A19FlightId, T00086_A35FlightPrice, T00086_A36FlightDiscountPercentaje, T00086_A38AirlineId, T00086_n38AirlineId, T00086_A25FlightArrivalAirportId, T00086_A24FlightDepartureAirportId
               }
               , new Object[] {
               T00087_A19FlightId, T00087_A35FlightPrice, T00087_A36FlightDiscountPercentaje, T00087_A38AirlineId, T00087_n38AirlineId, T00087_A25FlightArrivalAirportId, T00087_A24FlightDepartureAirportId
               }
               , new Object[] {
               T00088_A39AirlineName, T00088_A40AirlineDiscountPercentage
               }
               , new Object[] {
               T00089_A26FlightArrivalAirportName, T00089_A31FlightArrivalCountryId, T00089_A33FlightArrivalCityId
               }
               , new Object[] {
               T000810_A23FlightDepartureAirportName, T000810_A27FlightDepartureCountryId, T000810_A29FlightDepartureCityId
               }
               , new Object[] {
               T000811_A32FlightArrivalCountryName
               }
               , new Object[] {
               T000812_A34FlightArrivalCityName
               }
               , new Object[] {
               T000813_A28FlightDepartureCountryName
               }
               , new Object[] {
               T000814_A30FlightDepartureCityName
               }
               , new Object[] {
               T000816_A19FlightId, T000816_A26FlightArrivalAirportName, T000816_A32FlightArrivalCountryName, T000816_A34FlightArrivalCityName, T000816_A23FlightDepartureAirportName, T000816_A28FlightDepartureCountryName, T000816_A30FlightDepartureCityName, T000816_A35FlightPrice, T000816_A36FlightDiscountPercentaje, T000816_A39AirlineName,
               T000816_A40AirlineDiscountPercentage, T000816_A38AirlineId, T000816_n38AirlineId, T000816_A25FlightArrivalAirportId, T000816_A24FlightDepartureAirportId, T000816_A31FlightArrivalCountryId, T000816_A33FlightArrivalCityId, T000816_A27FlightDepartureCountryId, T000816_A29FlightDepartureCityId, T000816_A45FlightCapacity,
               T000816_n45FlightCapacity
               }
               , new Object[] {
               T000818_A45FlightCapacity, T000818_n45FlightCapacity
               }
               , new Object[] {
               T000819_A26FlightArrivalAirportName, T000819_A31FlightArrivalCountryId, T000819_A33FlightArrivalCityId
               }
               , new Object[] {
               T000820_A32FlightArrivalCountryName
               }
               , new Object[] {
               T000821_A34FlightArrivalCityName
               }
               , new Object[] {
               T000822_A23FlightDepartureAirportName, T000822_A27FlightDepartureCountryId, T000822_A29FlightDepartureCityId
               }
               , new Object[] {
               T000823_A28FlightDepartureCountryName
               }
               , new Object[] {
               T000824_A30FlightDepartureCityName
               }
               , new Object[] {
               T000825_A39AirlineName, T000825_A40AirlineDiscountPercentage
               }
               , new Object[] {
               T000826_A19FlightId
               }
               , new Object[] {
               T000827_A19FlightId
               }
               , new Object[] {
               T000828_A19FlightId
               }
               , new Object[] {
               T000829_A19FlightId
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000833_A45FlightCapacity, T000833_n45FlightCapacity
               }
               , new Object[] {
               T000834_A26FlightArrivalAirportName, T000834_A31FlightArrivalCountryId, T000834_A33FlightArrivalCityId
               }
               , new Object[] {
               T000835_A32FlightArrivalCountryName
               }
               , new Object[] {
               T000836_A34FlightArrivalCityName
               }
               , new Object[] {
               T000837_A23FlightDepartureAirportName, T000837_A27FlightDepartureCountryId, T000837_A29FlightDepartureCityId
               }
               , new Object[] {
               T000838_A28FlightDepartureCountryName
               }
               , new Object[] {
               T000839_A30FlightDepartureCityName
               }
               , new Object[] {
               T000840_A39AirlineName, T000840_A40AirlineDiscountPercentage
               }
               , new Object[] {
               T000841_A19FlightId
               }
               , new Object[] {
               T000842_A19FlightId, T000842_A42FlightSeatId, T000842_A44FlightSeatChar, T000842_A43FlightSeatLocation
               }
               , new Object[] {
               T000843_A19FlightId, T000843_A42FlightSeatId, T000843_A44FlightSeatChar
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000847_A19FlightId, T000847_A42FlightSeatId, T000847_A44FlightSeatChar
               }
            }
         );
      }

      private short Z19FlightId ;
      private short Z36FlightDiscountPercentaje ;
      private short Z38AirlineId ;
      private short Z25FlightArrivalAirportId ;
      private short Z24FlightDepartureAirportId ;
      private short Z42FlightSeatId ;
      private short nRcdDeleted_11 ;
      private short nRcdExists_11 ;
      private short nIsMod_11 ;
      private short GxWebError ;
      private short A19FlightId ;
      private short A25FlightArrivalAirportId ;
      private short A31FlightArrivalCountryId ;
      private short A33FlightArrivalCityId ;
      private short A24FlightDepartureAirportId ;
      private short A27FlightDepartureCountryId ;
      private short A29FlightDepartureCityId ;
      private short A38AirlineId ;
      private short gxcookieaux ;
      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short initialized ;
      private short A36FlightDiscountPercentaje ;
      private short A40AirlineDiscountPercentage ;
      private short A45FlightCapacity ;
      private short nBlankRcdCount11 ;
      private short RcdFound11 ;
      private short nBlankRcdUsr11 ;
      private short A42FlightSeatId ;
      private short GX_JID ;
      private short Z45FlightCapacity ;
      private short Z31FlightArrivalCountryId ;
      private short Z33FlightArrivalCityId ;
      private short Z27FlightDepartureCountryId ;
      private short Z29FlightDepartureCityId ;
      private short Z40AirlineDiscountPercentage ;
      private short RcdFound9 ;
      private short nIsDirty_9 ;
      private short Gx_BScreen ;
      private short nIsDirty_11 ;
      private short subGridflight_seat_Backcolorstyle ;
      private short subGridflight_seat_Backstyle ;
      private short gxajaxcallmode ;
      private short subGridflight_seat_Allowselection ;
      private short subGridflight_seat_Allowhovering ;
      private short subGridflight_seat_Allowcollapsing ;
      private short subGridflight_seat_Collapsed ;
      private short ZZ19FlightId ;
      private short ZZ25FlightArrivalAirportId ;
      private short ZZ24FlightDepartureAirportId ;
      private short ZZ36FlightDiscountPercentaje ;
      private short ZZ38AirlineId ;
      private short ZZ45FlightCapacity ;
      private short ZZ31FlightArrivalCountryId ;
      private short ZZ33FlightArrivalCityId ;
      private short ZZ27FlightDepartureCountryId ;
      private short ZZ29FlightDepartureCityId ;
      private short ZZ40AirlineDiscountPercentage ;
      private int nRC_GXsfl_138 ;
      private int nGXsfl_138_idx=1 ;
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
      private int edtFlightPrice_Enabled ;
      private int edtFlightDiscountPercentaje_Enabled ;
      private int edtAirlineId_Enabled ;
      private int imgprompt_38_Visible ;
      private int edtAirlineName_Enabled ;
      private int edtAirlineDiscountPercentage_Enabled ;
      private int edtFlightFinalPrice_Enabled ;
      private int edtFlightCapacity_Enabled ;
      private int bttBtn_enter_Visible ;
      private int bttBtn_enter_Enabled ;
      private int bttBtn_cancel_Visible ;
      private int bttBtn_delete_Visible ;
      private int bttBtn_delete_Enabled ;
      private int edtFlightSeatId_Enabled ;
      private int fRowAdded ;
      private int subGridflight_seat_Backcolor ;
      private int subGridflight_seat_Allbackcolor ;
      private int defcmbFlightSeatChar_Enabled ;
      private int defedtFlightSeatId_Enabled ;
      private int idxLst ;
      private int subGridflight_seat_Selectedindex ;
      private int subGridflight_seat_Selectioncolor ;
      private int subGridflight_seat_Hoveringcolor ;
      private long GRIDFLIGHT_SEAT_nFirstRecordOnPage ;
      private decimal Z35FlightPrice ;
      private decimal A35FlightPrice ;
      private decimal A37FlightFinalPrice ;
      private decimal Z37FlightFinalPrice ;
      private decimal ZZ35FlightPrice ;
      private decimal ZZ37FlightFinalPrice ;
      private string sPrefix ;
      private string Z44FlightSeatChar ;
      private string Z43FlightSeatLocation ;
      private string scmdbuf ;
      private string gxfirstwebparm ;
      private string gxfirstwebparm_bkp ;
      private string GXKey ;
      private string PreviousTooltip ;
      private string PreviousCaption ;
      private string GX_FocusControl ;
      private string edtFlightId_Internalname ;
      private string sGXsfl_138_idx="0001" ;
      private string Gx_mode ;
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
      private string edtFlightPrice_Internalname ;
      private string edtFlightPrice_Jsonclick ;
      private string edtFlightDiscountPercentaje_Internalname ;
      private string edtFlightDiscountPercentaje_Jsonclick ;
      private string edtAirlineId_Internalname ;
      private string edtAirlineId_Jsonclick ;
      private string imgprompt_38_gximage ;
      private string imgprompt_38_Internalname ;
      private string imgprompt_38_Link ;
      private string edtAirlineName_Internalname ;
      private string edtAirlineName_Jsonclick ;
      private string edtAirlineDiscountPercentage_Internalname ;
      private string edtAirlineDiscountPercentage_Jsonclick ;
      private string edtFlightFinalPrice_Internalname ;
      private string edtFlightFinalPrice_Jsonclick ;
      private string edtFlightCapacity_Internalname ;
      private string edtFlightCapacity_Jsonclick ;
      private string divSeattable_Internalname ;
      private string lblTitleseat_Internalname ;
      private string lblTitleseat_Jsonclick ;
      private string bttBtn_enter_Internalname ;
      private string bttBtn_enter_Jsonclick ;
      private string bttBtn_cancel_Internalname ;
      private string bttBtn_cancel_Jsonclick ;
      private string bttBtn_delete_Internalname ;
      private string bttBtn_delete_Jsonclick ;
      private string sMode11 ;
      private string edtFlightSeatId_Internalname ;
      private string cmbFlightSeatChar_Internalname ;
      private string cmbFlightSeatLocation_Internalname ;
      private string sStyleString ;
      private string subGridflight_seat_Internalname ;
      private string sEvt ;
      private string EvtGridId ;
      private string EvtRowId ;
      private string sEvtType ;
      private string endTrnMsgTxt ;
      private string endTrnMsgCod ;
      private string GXCCtl ;
      private string A44FlightSeatChar ;
      private string A43FlightSeatLocation ;
      private string sMode9 ;
      private string sGXsfl_138_fel_idx="0001" ;
      private string subGridflight_seat_Class ;
      private string subGridflight_seat_Linesclass ;
      private string ROClassString ;
      private string edtFlightSeatId_Jsonclick ;
      private string cmbFlightSeatChar_Jsonclick ;
      private string cmbFlightSeatLocation_Jsonclick ;
      private string sDynURL ;
      private string FormProcess ;
      private string bodyStyle ;
      private string subGridflight_seat_Header ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool n38AirlineId ;
      private bool wbErr ;
      private bool bGXsfl_138_Refreshing=false ;
      private bool n45FlightCapacity ;
      private string A26FlightArrivalAirportName ;
      private string A32FlightArrivalCountryName ;
      private string A34FlightArrivalCityName ;
      private string A23FlightDepartureAirportName ;
      private string A28FlightDepartureCountryName ;
      private string A30FlightDepartureCityName ;
      private string A39AirlineName ;
      private string Z26FlightArrivalAirportName ;
      private string Z32FlightArrivalCountryName ;
      private string Z34FlightArrivalCityName ;
      private string Z23FlightDepartureAirportName ;
      private string Z28FlightDepartureCountryName ;
      private string Z30FlightDepartureCityName ;
      private string Z39AirlineName ;
      private string ZZ26FlightArrivalAirportName ;
      private string ZZ32FlightArrivalCountryName ;
      private string ZZ34FlightArrivalCityName ;
      private string ZZ23FlightDepartureAirportName ;
      private string ZZ28FlightDepartureCountryName ;
      private string ZZ30FlightDepartureCityName ;
      private string ZZ39AirlineName ;
      private GXWebGrid Gridflight_seatContainer ;
      private GXWebRow Gridflight_seatRow ;
      private GXWebColumn Gridflight_seatColumn ;
      private IGxDataStore dsDefault ;
      private GXCombobox cmbFlightSeatChar ;
      private GXCombobox cmbFlightSeatLocation ;
      private IDataStoreProvider pr_default ;
      private short[] T00085_A45FlightCapacity ;
      private bool[] T00085_n45FlightCapacity ;
      private short[] T000816_A19FlightId ;
      private string[] T000816_A26FlightArrivalAirportName ;
      private string[] T000816_A32FlightArrivalCountryName ;
      private string[] T000816_A34FlightArrivalCityName ;
      private string[] T000816_A23FlightDepartureAirportName ;
      private string[] T000816_A28FlightDepartureCountryName ;
      private string[] T000816_A30FlightDepartureCityName ;
      private decimal[] T000816_A35FlightPrice ;
      private short[] T000816_A36FlightDiscountPercentaje ;
      private string[] T000816_A39AirlineName ;
      private short[] T000816_A40AirlineDiscountPercentage ;
      private short[] T000816_A38AirlineId ;
      private bool[] T000816_n38AirlineId ;
      private short[] T000816_A25FlightArrivalAirportId ;
      private short[] T000816_A24FlightDepartureAirportId ;
      private short[] T000816_A31FlightArrivalCountryId ;
      private short[] T000816_A33FlightArrivalCityId ;
      private short[] T000816_A27FlightDepartureCountryId ;
      private short[] T000816_A29FlightDepartureCityId ;
      private short[] T000816_A45FlightCapacity ;
      private bool[] T000816_n45FlightCapacity ;
      private string[] T00089_A26FlightArrivalAirportName ;
      private short[] T00089_A31FlightArrivalCountryId ;
      private short[] T00089_A33FlightArrivalCityId ;
      private string[] T000811_A32FlightArrivalCountryName ;
      private string[] T000812_A34FlightArrivalCityName ;
      private string[] T000810_A23FlightDepartureAirportName ;
      private short[] T000810_A27FlightDepartureCountryId ;
      private short[] T000810_A29FlightDepartureCityId ;
      private string[] T000813_A28FlightDepartureCountryName ;
      private string[] T000814_A30FlightDepartureCityName ;
      private string[] T00088_A39AirlineName ;
      private short[] T00088_A40AirlineDiscountPercentage ;
      private short[] T000818_A45FlightCapacity ;
      private bool[] T000818_n45FlightCapacity ;
      private string[] T000819_A26FlightArrivalAirportName ;
      private short[] T000819_A31FlightArrivalCountryId ;
      private short[] T000819_A33FlightArrivalCityId ;
      private string[] T000820_A32FlightArrivalCountryName ;
      private string[] T000821_A34FlightArrivalCityName ;
      private string[] T000822_A23FlightDepartureAirportName ;
      private short[] T000822_A27FlightDepartureCountryId ;
      private short[] T000822_A29FlightDepartureCityId ;
      private string[] T000823_A28FlightDepartureCountryName ;
      private string[] T000824_A30FlightDepartureCityName ;
      private string[] T000825_A39AirlineName ;
      private short[] T000825_A40AirlineDiscountPercentage ;
      private short[] T000826_A19FlightId ;
      private short[] T00087_A19FlightId ;
      private decimal[] T00087_A35FlightPrice ;
      private short[] T00087_A36FlightDiscountPercentaje ;
      private short[] T00087_A38AirlineId ;
      private bool[] T00087_n38AirlineId ;
      private short[] T00087_A25FlightArrivalAirportId ;
      private short[] T00087_A24FlightDepartureAirportId ;
      private short[] T000827_A19FlightId ;
      private short[] T000828_A19FlightId ;
      private short[] T00086_A19FlightId ;
      private decimal[] T00086_A35FlightPrice ;
      private short[] T00086_A36FlightDiscountPercentaje ;
      private short[] T00086_A38AirlineId ;
      private bool[] T00086_n38AirlineId ;
      private short[] T00086_A25FlightArrivalAirportId ;
      private short[] T00086_A24FlightDepartureAirportId ;
      private short[] T000829_A19FlightId ;
      private short[] T000833_A45FlightCapacity ;
      private bool[] T000833_n45FlightCapacity ;
      private string[] T000834_A26FlightArrivalAirportName ;
      private short[] T000834_A31FlightArrivalCountryId ;
      private short[] T000834_A33FlightArrivalCityId ;
      private string[] T000835_A32FlightArrivalCountryName ;
      private string[] T000836_A34FlightArrivalCityName ;
      private string[] T000837_A23FlightDepartureAirportName ;
      private short[] T000837_A27FlightDepartureCountryId ;
      private short[] T000837_A29FlightDepartureCityId ;
      private string[] T000838_A28FlightDepartureCountryName ;
      private string[] T000839_A30FlightDepartureCityName ;
      private string[] T000840_A39AirlineName ;
      private short[] T000840_A40AirlineDiscountPercentage ;
      private short[] T000841_A19FlightId ;
      private short[] T000842_A19FlightId ;
      private short[] T000842_A42FlightSeatId ;
      private string[] T000842_A44FlightSeatChar ;
      private string[] T000842_A43FlightSeatLocation ;
      private short[] T000843_A19FlightId ;
      private short[] T000843_A42FlightSeatId ;
      private string[] T000843_A44FlightSeatChar ;
      private short[] T00083_A19FlightId ;
      private short[] T00083_A42FlightSeatId ;
      private string[] T00083_A44FlightSeatChar ;
      private string[] T00083_A43FlightSeatLocation ;
      private short[] T00082_A19FlightId ;
      private short[] T00082_A42FlightSeatId ;
      private string[] T00082_A44FlightSeatChar ;
      private string[] T00082_A43FlightSeatLocation ;
      private short[] T000847_A19FlightId ;
      private short[] T000847_A42FlightSeatId ;
      private string[] T000847_A44FlightSeatChar ;
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
         ,new ForEachCursor(def[19])
         ,new ForEachCursor(def[20])
         ,new ForEachCursor(def[21])
         ,new ForEachCursor(def[22])
         ,new ForEachCursor(def[23])
         ,new ForEachCursor(def[24])
         ,new UpdateCursor(def[25])
         ,new UpdateCursor(def[26])
         ,new ForEachCursor(def[27])
         ,new ForEachCursor(def[28])
         ,new ForEachCursor(def[29])
         ,new ForEachCursor(def[30])
         ,new ForEachCursor(def[31])
         ,new ForEachCursor(def[32])
         ,new ForEachCursor(def[33])
         ,new ForEachCursor(def[34])
         ,new ForEachCursor(def[35])
         ,new ForEachCursor(def[36])
         ,new ForEachCursor(def[37])
         ,new UpdateCursor(def[38])
         ,new UpdateCursor(def[39])
         ,new UpdateCursor(def[40])
         ,new ForEachCursor(def[41])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmT000816;
          prmT000816 = new Object[] {
          new ParDef("@FlightId",GXType.Int16,4,0)
          };
          Object[] prmT00085;
          prmT00085 = new Object[] {
          new ParDef("@FlightId",GXType.Int16,4,0)
          };
          Object[] prmT00089;
          prmT00089 = new Object[] {
          new ParDef("@FlightArrivalAirportId",GXType.Int16,4,0)
          };
          Object[] prmT000811;
          prmT000811 = new Object[] {
          new ParDef("@FlightArrivalCountryId",GXType.Int16,4,0)
          };
          Object[] prmT000812;
          prmT000812 = new Object[] {
          new ParDef("@FlightArrivalCountryId",GXType.Int16,4,0) ,
          new ParDef("@FlightArrivalCityId",GXType.Int16,4,0)
          };
          Object[] prmT000810;
          prmT000810 = new Object[] {
          new ParDef("@FlightDepartureAirportId",GXType.Int16,4,0)
          };
          Object[] prmT000813;
          prmT000813 = new Object[] {
          new ParDef("@FlightDepartureCountryId",GXType.Int16,4,0)
          };
          Object[] prmT000814;
          prmT000814 = new Object[] {
          new ParDef("@FlightDepartureCountryId",GXType.Int16,4,0) ,
          new ParDef("@FlightDepartureCityId",GXType.Int16,4,0)
          };
          Object[] prmT00088;
          prmT00088 = new Object[] {
          new ParDef("@AirlineId",GXType.Int16,4,0){Nullable=true}
          };
          Object[] prmT000818;
          prmT000818 = new Object[] {
          new ParDef("@FlightId",GXType.Int16,4,0)
          };
          Object[] prmT000819;
          prmT000819 = new Object[] {
          new ParDef("@FlightArrivalAirportId",GXType.Int16,4,0)
          };
          Object[] prmT000820;
          prmT000820 = new Object[] {
          new ParDef("@FlightArrivalCountryId",GXType.Int16,4,0)
          };
          Object[] prmT000821;
          prmT000821 = new Object[] {
          new ParDef("@FlightArrivalCountryId",GXType.Int16,4,0) ,
          new ParDef("@FlightArrivalCityId",GXType.Int16,4,0)
          };
          Object[] prmT000822;
          prmT000822 = new Object[] {
          new ParDef("@FlightDepartureAirportId",GXType.Int16,4,0)
          };
          Object[] prmT000823;
          prmT000823 = new Object[] {
          new ParDef("@FlightDepartureCountryId",GXType.Int16,4,0)
          };
          Object[] prmT000824;
          prmT000824 = new Object[] {
          new ParDef("@FlightDepartureCountryId",GXType.Int16,4,0) ,
          new ParDef("@FlightDepartureCityId",GXType.Int16,4,0)
          };
          Object[] prmT000825;
          prmT000825 = new Object[] {
          new ParDef("@AirlineId",GXType.Int16,4,0){Nullable=true}
          };
          Object[] prmT000826;
          prmT000826 = new Object[] {
          new ParDef("@FlightId",GXType.Int16,4,0)
          };
          Object[] prmT00087;
          prmT00087 = new Object[] {
          new ParDef("@FlightId",GXType.Int16,4,0)
          };
          Object[] prmT000827;
          prmT000827 = new Object[] {
          new ParDef("@FlightId",GXType.Int16,4,0)
          };
          Object[] prmT000828;
          prmT000828 = new Object[] {
          new ParDef("@FlightId",GXType.Int16,4,0)
          };
          Object[] prmT00086;
          prmT00086 = new Object[] {
          new ParDef("@FlightId",GXType.Int16,4,0)
          };
          Object[] prmT000829;
          prmT000829 = new Object[] {
          new ParDef("@FlightPrice",GXType.Decimal,7,2) ,
          new ParDef("@FlightDiscountPercentaje",GXType.Int16,4,0) ,
          new ParDef("@AirlineId",GXType.Int16,4,0){Nullable=true} ,
          new ParDef("@FlightArrivalAirportId",GXType.Int16,4,0) ,
          new ParDef("@FlightDepartureAirportId",GXType.Int16,4,0)
          };
          Object[] prmT000830;
          prmT000830 = new Object[] {
          new ParDef("@FlightPrice",GXType.Decimal,7,2) ,
          new ParDef("@FlightDiscountPercentaje",GXType.Int16,4,0) ,
          new ParDef("@AirlineId",GXType.Int16,4,0){Nullable=true} ,
          new ParDef("@FlightArrivalAirportId",GXType.Int16,4,0) ,
          new ParDef("@FlightDepartureAirportId",GXType.Int16,4,0) ,
          new ParDef("@FlightId",GXType.Int16,4,0)
          };
          Object[] prmT000831;
          prmT000831 = new Object[] {
          new ParDef("@FlightId",GXType.Int16,4,0)
          };
          Object[] prmT000841;
          prmT000841 = new Object[] {
          };
          Object[] prmT000842;
          prmT000842 = new Object[] {
          new ParDef("@FlightId",GXType.Int16,4,0) ,
          new ParDef("@FlightSeatId",GXType.Int16,4,0) ,
          new ParDef("@FlightSeatChar",GXType.NChar,1,0)
          };
          Object[] prmT000843;
          prmT000843 = new Object[] {
          new ParDef("@FlightId",GXType.Int16,4,0) ,
          new ParDef("@FlightSeatId",GXType.Int16,4,0) ,
          new ParDef("@FlightSeatChar",GXType.NChar,1,0)
          };
          Object[] prmT00083;
          prmT00083 = new Object[] {
          new ParDef("@FlightId",GXType.Int16,4,0) ,
          new ParDef("@FlightSeatId",GXType.Int16,4,0) ,
          new ParDef("@FlightSeatChar",GXType.NChar,1,0)
          };
          Object[] prmT00082;
          prmT00082 = new Object[] {
          new ParDef("@FlightId",GXType.Int16,4,0) ,
          new ParDef("@FlightSeatId",GXType.Int16,4,0) ,
          new ParDef("@FlightSeatChar",GXType.NChar,1,0)
          };
          Object[] prmT000844;
          prmT000844 = new Object[] {
          new ParDef("@FlightId",GXType.Int16,4,0) ,
          new ParDef("@FlightSeatId",GXType.Int16,4,0) ,
          new ParDef("@FlightSeatChar",GXType.NChar,1,0) ,
          new ParDef("@FlightSeatLocation",GXType.NChar,1,0)
          };
          Object[] prmT000845;
          prmT000845 = new Object[] {
          new ParDef("@FlightSeatLocation",GXType.NChar,1,0) ,
          new ParDef("@FlightId",GXType.Int16,4,0) ,
          new ParDef("@FlightSeatId",GXType.Int16,4,0) ,
          new ParDef("@FlightSeatChar",GXType.NChar,1,0)
          };
          Object[] prmT000846;
          prmT000846 = new Object[] {
          new ParDef("@FlightId",GXType.Int16,4,0) ,
          new ParDef("@FlightSeatId",GXType.Int16,4,0) ,
          new ParDef("@FlightSeatChar",GXType.NChar,1,0)
          };
          Object[] prmT000847;
          prmT000847 = new Object[] {
          new ParDef("@FlightId",GXType.Int16,4,0)
          };
          Object[] prmT000833;
          prmT000833 = new Object[] {
          new ParDef("@FlightId",GXType.Int16,4,0)
          };
          Object[] prmT000834;
          prmT000834 = new Object[] {
          new ParDef("@FlightArrivalAirportId",GXType.Int16,4,0)
          };
          Object[] prmT000835;
          prmT000835 = new Object[] {
          new ParDef("@FlightArrivalCountryId",GXType.Int16,4,0)
          };
          Object[] prmT000836;
          prmT000836 = new Object[] {
          new ParDef("@FlightArrivalCountryId",GXType.Int16,4,0) ,
          new ParDef("@FlightArrivalCityId",GXType.Int16,4,0)
          };
          Object[] prmT000837;
          prmT000837 = new Object[] {
          new ParDef("@FlightDepartureAirportId",GXType.Int16,4,0)
          };
          Object[] prmT000838;
          prmT000838 = new Object[] {
          new ParDef("@FlightDepartureCountryId",GXType.Int16,4,0)
          };
          Object[] prmT000839;
          prmT000839 = new Object[] {
          new ParDef("@FlightDepartureCountryId",GXType.Int16,4,0) ,
          new ParDef("@FlightDepartureCityId",GXType.Int16,4,0)
          };
          Object[] prmT000840;
          prmT000840 = new Object[] {
          new ParDef("@AirlineId",GXType.Int16,4,0){Nullable=true}
          };
          def= new CursorDef[] {
              new CursorDef("T00082", "SELECT [FlightId], [FlightSeatId], [FlightSeatChar], [FlightSeatLocation] FROM [FlightSeat] WITH (UPDLOCK) WHERE [FlightId] = @FlightId AND [FlightSeatId] = @FlightSeatId AND [FlightSeatChar] = @FlightSeatChar ",true, GxErrorMask.GX_NOMASK, false, this,prmT00082,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T00083", "SELECT [FlightId], [FlightSeatId], [FlightSeatChar], [FlightSeatLocation] FROM [FlightSeat] WHERE [FlightId] = @FlightId AND [FlightSeatId] = @FlightSeatId AND [FlightSeatChar] = @FlightSeatChar ",true, GxErrorMask.GX_NOMASK, false, this,prmT00083,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T00085", "SELECT COALESCE( T1.[FlightCapacity], 0) AS FlightCapacity FROM (SELECT COUNT(*) AS FlightCapacity, [FlightId] FROM [FlightSeat] WITH (UPDLOCK) WHERE [FlightSeatLocation] = 'W' GROUP BY [FlightId] ) T1 WHERE T1.[FlightId] = @FlightId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00085,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T00086", "SELECT [FlightId], [FlightPrice], [FlightDiscountPercentaje], [AirlineId], [FlightArrivalAirportId] AS FlightArrivalAirportId, [FlightDepartureAirportId] AS FlightDepartureAirportId FROM [Flight] WITH (UPDLOCK) WHERE [FlightId] = @FlightId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00086,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T00087", "SELECT [FlightId], [FlightPrice], [FlightDiscountPercentaje], [AirlineId], [FlightArrivalAirportId] AS FlightArrivalAirportId, [FlightDepartureAirportId] AS FlightDepartureAirportId FROM [Flight] WHERE [FlightId] = @FlightId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00087,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T00088", "SELECT [AirlineName], [AirlineDiscountPercentage] FROM [Airline] WHERE [AirlineId] = @AirlineId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00088,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T00089", "SELECT [AirportName] AS FlightArrivalAirportName, [CountryId] AS FlightArrivalCountryId, [CityId] AS FlightArrivalCityId FROM [Airport] WHERE [AirportId] = @FlightArrivalAirportId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00089,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T000810", "SELECT [AirportName] AS FlightDepartureAirportName, [CountryId] AS FlightDepartureCountryId, [CityId] AS FlightDepartureCityId FROM [Airport] WHERE [AirportId] = @FlightDepartureAirportId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000810,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T000811", "SELECT [CountryName] AS FlightArrivalCountryName FROM [Country] WHERE [CountryId] = @FlightArrivalCountryId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000811,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T000812", "SELECT [CityName] AS FlightArrivalCityName FROM [CountryCity] WHERE [CountryId] = @FlightArrivalCountryId AND [CityId] = @FlightArrivalCityId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000812,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T000813", "SELECT [CountryName] AS FlightDepartureCountryName FROM [Country] WHERE [CountryId] = @FlightDepartureCountryId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000813,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T000814", "SELECT [CityName] AS FlightDepartureCityName FROM [CountryCity] WHERE [CountryId] = @FlightDepartureCountryId AND [CityId] = @FlightDepartureCityId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000814,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T000816", "SELECT TM1.[FlightId], T3.[AirportName] AS FlightArrivalAirportName, T4.[CountryName] AS FlightArrivalCountryName, T5.[CityName] AS FlightArrivalCityName, T6.[AirportName] AS FlightDepartureAirportName, T7.[CountryName] AS FlightDepartureCountryName, T8.[CityName] AS FlightDepartureCityName, TM1.[FlightPrice], TM1.[FlightDiscountPercentaje], T9.[AirlineName], T9.[AirlineDiscountPercentage], TM1.[AirlineId], TM1.[FlightArrivalAirportId] AS FlightArrivalAirportId, TM1.[FlightDepartureAirportId] AS FlightDepartureAirportId, T3.[CountryId] AS FlightArrivalCountryId, T3.[CityId] AS FlightArrivalCityId, T6.[CountryId] AS FlightDepartureCountryId, T6.[CityId] AS FlightDepartureCityId, COALESCE( T2.[FlightCapacity], 0) AS FlightCapacity FROM (((((((([Flight] TM1 LEFT JOIN (SELECT COUNT(*) AS FlightCapacity, [FlightId] FROM [FlightSeat] WHERE [FlightSeatLocation] = 'W' GROUP BY [FlightId] ) T2 ON T2.[FlightId] = TM1.[FlightId]) INNER JOIN [Airport] T3 ON T3.[AirportId] = TM1.[FlightArrivalAirportId]) INNER JOIN [Country] T4 ON T4.[CountryId] = T3.[CountryId]) INNER JOIN [CountryCity] T5 ON T5.[CountryId] = T3.[CountryId] AND T5.[CityId] = T3.[CityId]) INNER JOIN [Airport] T6 ON T6.[AirportId] = TM1.[FlightDepartureAirportId]) INNER JOIN [Country] T7 ON T7.[CountryId] = T6.[CountryId]) INNER JOIN [CountryCity] T8 ON T8.[CountryId] = T6.[CountryId] AND T8.[CityId] = T6.[CityId]) LEFT JOIN [Airline] T9 ON T9.[AirlineId] = TM1.[AirlineId]) WHERE TM1.[FlightId] = @FlightId ORDER BY TM1.[FlightId]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000816,100, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T000818", "SELECT COALESCE( T1.[FlightCapacity], 0) AS FlightCapacity FROM (SELECT COUNT(*) AS FlightCapacity, [FlightId] FROM [FlightSeat] WITH (UPDLOCK) WHERE [FlightSeatLocation] = 'W' GROUP BY [FlightId] ) T1 WHERE T1.[FlightId] = @FlightId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000818,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T000819", "SELECT [AirportName] AS FlightArrivalAirportName, [CountryId] AS FlightArrivalCountryId, [CityId] AS FlightArrivalCityId FROM [Airport] WHERE [AirportId] = @FlightArrivalAirportId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000819,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T000820", "SELECT [CountryName] AS FlightArrivalCountryName FROM [Country] WHERE [CountryId] = @FlightArrivalCountryId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000820,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T000821", "SELECT [CityName] AS FlightArrivalCityName FROM [CountryCity] WHERE [CountryId] = @FlightArrivalCountryId AND [CityId] = @FlightArrivalCityId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000821,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T000822", "SELECT [AirportName] AS FlightDepartureAirportName, [CountryId] AS FlightDepartureCountryId, [CityId] AS FlightDepartureCityId FROM [Airport] WHERE [AirportId] = @FlightDepartureAirportId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000822,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T000823", "SELECT [CountryName] AS FlightDepartureCountryName FROM [Country] WHERE [CountryId] = @FlightDepartureCountryId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000823,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T000824", "SELECT [CityName] AS FlightDepartureCityName FROM [CountryCity] WHERE [CountryId] = @FlightDepartureCountryId AND [CityId] = @FlightDepartureCityId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000824,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T000825", "SELECT [AirlineName], [AirlineDiscountPercentage] FROM [Airline] WHERE [AirlineId] = @AirlineId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000825,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T000826", "SELECT [FlightId] FROM [Flight] WHERE [FlightId] = @FlightId  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000826,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T000827", "SELECT TOP 1 [FlightId] FROM [Flight] WHERE ( [FlightId] > @FlightId) ORDER BY [FlightId]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000827,1, GxCacheFrequency.OFF ,true,true )
             ,new CursorDef("T000828", "SELECT TOP 1 [FlightId] FROM [Flight] WHERE ( [FlightId] < @FlightId) ORDER BY [FlightId] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000828,1, GxCacheFrequency.OFF ,true,true )
             ,new CursorDef("T000829", "INSERT INTO [Flight]([FlightPrice], [FlightDiscountPercentaje], [AirlineId], [FlightArrivalAirportId], [FlightDepartureAirportId]) VALUES(@FlightPrice, @FlightDiscountPercentaje, @AirlineId, @FlightArrivalAirportId, @FlightDepartureAirportId); SELECT SCOPE_IDENTITY()",true, GxErrorMask.GX_NOMASK, false, this,prmT000829,1, GxCacheFrequency.OFF ,true,true )
             ,new CursorDef("T000830", "UPDATE [Flight] SET [FlightPrice]=@FlightPrice, [FlightDiscountPercentaje]=@FlightDiscountPercentaje, [AirlineId]=@AirlineId, [FlightArrivalAirportId]=@FlightArrivalAirportId, [FlightDepartureAirportId]=@FlightDepartureAirportId  WHERE [FlightId] = @FlightId", GxErrorMask.GX_NOMASK,prmT000830)
             ,new CursorDef("T000831", "DELETE FROM [Flight]  WHERE [FlightId] = @FlightId", GxErrorMask.GX_NOMASK,prmT000831)
             ,new CursorDef("T000833", "SELECT COALESCE( T1.[FlightCapacity], 0) AS FlightCapacity FROM (SELECT COUNT(*) AS FlightCapacity, [FlightId] FROM [FlightSeat] WITH (UPDLOCK) WHERE [FlightSeatLocation] = 'W' GROUP BY [FlightId] ) T1 WHERE T1.[FlightId] = @FlightId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000833,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T000834", "SELECT [AirportName] AS FlightArrivalAirportName, [CountryId] AS FlightArrivalCountryId, [CityId] AS FlightArrivalCityId FROM [Airport] WHERE [AirportId] = @FlightArrivalAirportId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000834,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T000835", "SELECT [CountryName] AS FlightArrivalCountryName FROM [Country] WHERE [CountryId] = @FlightArrivalCountryId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000835,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T000836", "SELECT [CityName] AS FlightArrivalCityName FROM [CountryCity] WHERE [CountryId] = @FlightArrivalCountryId AND [CityId] = @FlightArrivalCityId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000836,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T000837", "SELECT [AirportName] AS FlightDepartureAirportName, [CountryId] AS FlightDepartureCountryId, [CityId] AS FlightDepartureCityId FROM [Airport] WHERE [AirportId] = @FlightDepartureAirportId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000837,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T000838", "SELECT [CountryName] AS FlightDepartureCountryName FROM [Country] WHERE [CountryId] = @FlightDepartureCountryId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000838,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T000839", "SELECT [CityName] AS FlightDepartureCityName FROM [CountryCity] WHERE [CountryId] = @FlightDepartureCountryId AND [CityId] = @FlightDepartureCityId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000839,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T000840", "SELECT [AirlineName], [AirlineDiscountPercentage] FROM [Airline] WHERE [AirlineId] = @AirlineId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000840,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T000841", "SELECT [FlightId] FROM [Flight] ORDER BY [FlightId]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000841,100, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T000842", "SELECT [FlightId], [FlightSeatId], [FlightSeatChar], [FlightSeatLocation] FROM [FlightSeat] WHERE [FlightId] = @FlightId and [FlightSeatId] = @FlightSeatId and [FlightSeatChar] = @FlightSeatChar ORDER BY [FlightId], [FlightSeatId], [FlightSeatChar] ",true, GxErrorMask.GX_NOMASK, false, this,prmT000842,11, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T000843", "SELECT [FlightId], [FlightSeatId], [FlightSeatChar] FROM [FlightSeat] WHERE [FlightId] = @FlightId AND [FlightSeatId] = @FlightSeatId AND [FlightSeatChar] = @FlightSeatChar ",true, GxErrorMask.GX_NOMASK, false, this,prmT000843,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T000844", "INSERT INTO [FlightSeat]([FlightId], [FlightSeatId], [FlightSeatChar], [FlightSeatLocation]) VALUES(@FlightId, @FlightSeatId, @FlightSeatChar, @FlightSeatLocation)", GxErrorMask.GX_NOMASK,prmT000844)
             ,new CursorDef("T000845", "UPDATE [FlightSeat] SET [FlightSeatLocation]=@FlightSeatLocation  WHERE [FlightId] = @FlightId AND [FlightSeatId] = @FlightSeatId AND [FlightSeatChar] = @FlightSeatChar", GxErrorMask.GX_NOMASK,prmT000845)
             ,new CursorDef("T000846", "DELETE FROM [FlightSeat]  WHERE [FlightId] = @FlightId AND [FlightSeatId] = @FlightSeatId AND [FlightSeatChar] = @FlightSeatChar", GxErrorMask.GX_NOMASK,prmT000846)
             ,new CursorDef("T000847", "SELECT [FlightId], [FlightSeatId], [FlightSeatChar] FROM [FlightSeat] WHERE [FlightId] = @FlightId ORDER BY [FlightId], [FlightSeatId], [FlightSeatChar] ",true, GxErrorMask.GX_NOMASK, false, this,prmT000847,11, GxCacheFrequency.OFF ,true,false )
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
                ((string[]) buf[2])[0] = rslt.getString(3, 1);
                ((string[]) buf[3])[0] = rslt.getString(4, 1);
                return;
             case 1 :
                ((short[]) buf[0])[0] = rslt.getShort(1);
                ((short[]) buf[1])[0] = rslt.getShort(2);
                ((string[]) buf[2])[0] = rslt.getString(3, 1);
                ((string[]) buf[3])[0] = rslt.getString(4, 1);
                return;
             case 2 :
                ((short[]) buf[0])[0] = rslt.getShort(1);
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                return;
             case 3 :
                ((short[]) buf[0])[0] = rslt.getShort(1);
                ((decimal[]) buf[1])[0] = rslt.getDecimal(2);
                ((short[]) buf[2])[0] = rslt.getShort(3);
                ((short[]) buf[3])[0] = rslt.getShort(4);
                ((bool[]) buf[4])[0] = rslt.wasNull(4);
                ((short[]) buf[5])[0] = rslt.getShort(5);
                ((short[]) buf[6])[0] = rslt.getShort(6);
                return;
             case 4 :
                ((short[]) buf[0])[0] = rslt.getShort(1);
                ((decimal[]) buf[1])[0] = rslt.getDecimal(2);
                ((short[]) buf[2])[0] = rslt.getShort(3);
                ((short[]) buf[3])[0] = rslt.getShort(4);
                ((bool[]) buf[4])[0] = rslt.wasNull(4);
                ((short[]) buf[5])[0] = rslt.getShort(5);
                ((short[]) buf[6])[0] = rslt.getShort(6);
                return;
             case 5 :
                ((string[]) buf[0])[0] = rslt.getVarchar(1);
                ((short[]) buf[1])[0] = rslt.getShort(2);
                return;
             case 6 :
                ((string[]) buf[0])[0] = rslt.getVarchar(1);
                ((short[]) buf[1])[0] = rslt.getShort(2);
                ((short[]) buf[2])[0] = rslt.getShort(3);
                return;
             case 7 :
                ((string[]) buf[0])[0] = rslt.getVarchar(1);
                ((short[]) buf[1])[0] = rslt.getShort(2);
                ((short[]) buf[2])[0] = rslt.getShort(3);
                return;
             case 8 :
                ((string[]) buf[0])[0] = rslt.getVarchar(1);
                return;
             case 9 :
                ((string[]) buf[0])[0] = rslt.getVarchar(1);
                return;
             case 10 :
                ((string[]) buf[0])[0] = rslt.getVarchar(1);
                return;
             case 11 :
                ((string[]) buf[0])[0] = rslt.getVarchar(1);
                return;
             case 12 :
                ((short[]) buf[0])[0] = rslt.getShort(1);
                ((string[]) buf[1])[0] = rslt.getVarchar(2);
                ((string[]) buf[2])[0] = rslt.getVarchar(3);
                ((string[]) buf[3])[0] = rslt.getVarchar(4);
                ((string[]) buf[4])[0] = rslt.getVarchar(5);
                ((string[]) buf[5])[0] = rslt.getVarchar(6);
                ((string[]) buf[6])[0] = rslt.getVarchar(7);
                ((decimal[]) buf[7])[0] = rslt.getDecimal(8);
                ((short[]) buf[8])[0] = rslt.getShort(9);
                ((string[]) buf[9])[0] = rslt.getVarchar(10);
                ((short[]) buf[10])[0] = rslt.getShort(11);
                ((short[]) buf[11])[0] = rslt.getShort(12);
                ((bool[]) buf[12])[0] = rslt.wasNull(12);
                ((short[]) buf[13])[0] = rslt.getShort(13);
                ((short[]) buf[14])[0] = rslt.getShort(14);
                ((short[]) buf[15])[0] = rslt.getShort(15);
                ((short[]) buf[16])[0] = rslt.getShort(16);
                ((short[]) buf[17])[0] = rslt.getShort(17);
                ((short[]) buf[18])[0] = rslt.getShort(18);
                ((short[]) buf[19])[0] = rslt.getShort(19);
                ((bool[]) buf[20])[0] = rslt.wasNull(19);
                return;
             case 13 :
                ((short[]) buf[0])[0] = rslt.getShort(1);
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                return;
             case 14 :
                ((string[]) buf[0])[0] = rslt.getVarchar(1);
                ((short[]) buf[1])[0] = rslt.getShort(2);
                ((short[]) buf[2])[0] = rslt.getShort(3);
                return;
             case 15 :
                ((string[]) buf[0])[0] = rslt.getVarchar(1);
                return;
             case 16 :
                ((string[]) buf[0])[0] = rslt.getVarchar(1);
                return;
             case 17 :
                ((string[]) buf[0])[0] = rslt.getVarchar(1);
                ((short[]) buf[1])[0] = rslt.getShort(2);
                ((short[]) buf[2])[0] = rslt.getShort(3);
                return;
             case 18 :
                ((string[]) buf[0])[0] = rslt.getVarchar(1);
                return;
             case 19 :
                ((string[]) buf[0])[0] = rslt.getVarchar(1);
                return;
             case 20 :
                ((string[]) buf[0])[0] = rslt.getVarchar(1);
                ((short[]) buf[1])[0] = rslt.getShort(2);
                return;
             case 21 :
                ((short[]) buf[0])[0] = rslt.getShort(1);
                return;
             case 22 :
                ((short[]) buf[0])[0] = rslt.getShort(1);
                return;
             case 23 :
                ((short[]) buf[0])[0] = rslt.getShort(1);
                return;
             case 24 :
                ((short[]) buf[0])[0] = rslt.getShort(1);
                return;
             case 27 :
                ((short[]) buf[0])[0] = rslt.getShort(1);
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                return;
             case 28 :
                ((string[]) buf[0])[0] = rslt.getVarchar(1);
                ((short[]) buf[1])[0] = rslt.getShort(2);
                ((short[]) buf[2])[0] = rslt.getShort(3);
                return;
             case 29 :
                ((string[]) buf[0])[0] = rslt.getVarchar(1);
                return;
       }
       getresults30( cursor, rslt, buf) ;
    }

    public void getresults30( int cursor ,
                              IFieldGetter rslt ,
                              Object[] buf )
    {
       switch ( cursor )
       {
             case 30 :
                ((string[]) buf[0])[0] = rslt.getVarchar(1);
                return;
             case 31 :
                ((string[]) buf[0])[0] = rslt.getVarchar(1);
                ((short[]) buf[1])[0] = rslt.getShort(2);
                ((short[]) buf[2])[0] = rslt.getShort(3);
                return;
             case 32 :
                ((string[]) buf[0])[0] = rslt.getVarchar(1);
                return;
             case 33 :
                ((string[]) buf[0])[0] = rslt.getVarchar(1);
                return;
             case 34 :
                ((string[]) buf[0])[0] = rslt.getVarchar(1);
                ((short[]) buf[1])[0] = rslt.getShort(2);
                return;
             case 35 :
                ((short[]) buf[0])[0] = rslt.getShort(1);
                return;
             case 36 :
                ((short[]) buf[0])[0] = rslt.getShort(1);
                ((short[]) buf[1])[0] = rslt.getShort(2);
                ((string[]) buf[2])[0] = rslt.getString(3, 1);
                ((string[]) buf[3])[0] = rslt.getString(4, 1);
                return;
             case 37 :
                ((short[]) buf[0])[0] = rslt.getShort(1);
                ((short[]) buf[1])[0] = rslt.getShort(2);
                ((string[]) buf[2])[0] = rslt.getString(3, 1);
                return;
             case 41 :
                ((short[]) buf[0])[0] = rslt.getShort(1);
                ((short[]) buf[1])[0] = rslt.getShort(2);
                ((string[]) buf[2])[0] = rslt.getString(3, 1);
                return;
       }
    }

 }

}
