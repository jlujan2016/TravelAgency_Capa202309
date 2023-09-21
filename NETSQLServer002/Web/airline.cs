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
   public class airline : GXDataArea
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
            Form.Meta.addItem("description", "Airline", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         if ( ! context.isAjaxRequest( ) )
         {
            GX_FocusControl = edtAirlineId_Internalname;
            AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         }
         wbErr = false;
         context.SetDefaultTheme("TravelAgency_Capa202309", true);
         if ( ! context.IsLocalStorageSupported( ) )
         {
            context.PushCurrentUrl();
         }
      }

      public airline( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("TravelAgency_Capa202309", true);
      }

      public airline( IGxContext context )
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
         GxWebStd.gx_label_ctrl( context, lblTitle_Internalname, "Airline", "", "", lblTitle_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "heading-01", 0, "", 1, 1, 0, 0, "HLP_Airline.htm");
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
         GxWebStd.gx_button_ctrl( context, bttBtn_first_Internalname, "", "", bttBtn_first_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_first_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"EFIRST."+"'", TempTags, "", context.GetButtonType( ), "HLP_Airline.htm");
         GxWebStd.gx_div_end( context, "start", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "start", "top", "", "", "div");
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 23,'',false,'',0)\"";
         ClassString = "Button button-auxiliary ico__arrow-prev";
         StyleString = "";
         GxWebStd.gx_button_ctrl( context, bttBtn_previous_Internalname, "", "", bttBtn_previous_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_previous_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"EPREVIOUS."+"'", TempTags, "", context.GetButtonType( ), "HLP_Airline.htm");
         GxWebStd.gx_div_end( context, "start", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "start", "top", "", "", "div");
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 25,'',false,'',0)\"";
         ClassString = "Button button-auxiliary ico__arrow-next";
         StyleString = "";
         GxWebStd.gx_button_ctrl( context, bttBtn_next_Internalname, "", "", bttBtn_next_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_next_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ENEXT."+"'", TempTags, "", context.GetButtonType( ), "HLP_Airline.htm");
         GxWebStd.gx_div_end( context, "start", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "start", "top", "", "", "div");
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 27,'',false,'',0)\"";
         ClassString = "Button button-auxiliary ico__arrow-last";
         StyleString = "";
         GxWebStd.gx_button_ctrl( context, bttBtn_last_Internalname, "", "", bttBtn_last_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_last_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ELAST."+"'", TempTags, "", context.GetButtonType( ), "HLP_Airline.htm");
         GxWebStd.gx_div_end( context, "start", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "start", "top", "", "", "div");
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 29,'',false,'',0)\"";
         ClassString = "Button button-secondary";
         StyleString = "";
         GxWebStd.gx_button_ctrl( context, bttBtn_select_Internalname, "", "Select", bttBtn_select_Jsonclick, 4, "Select", "", StyleString, ClassString, bttBtn_select_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ESELECT."+"'", TempTags, "gx.popup.openPrompt('"+"gx00c0.aspx"+"',["+"{Ctrl:gx.dom.el('"+"AIRLINEID"+"'), id:'"+"AIRLINEID"+"'"+",IOType:'out',isKey:true,isLastKey:true}"+"],"+"null"+","+"'', false"+","+"true"+");"+"return false;", 2, "HLP_Airline.htm");
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
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "start", "top", ""+" data-gx-for=\""+edtAirlineId_Internalname+"\"", "", "div");
         /* Attribute/Variable Label */
         GxWebStd.gx_label_element( context, edtAirlineId_Internalname, "Id", "col-sm-3 AttributeLabel", 1, true, "");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "start", "top", "", "", "div");
         /* Single line edit */
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 34,'',false,'',0)\"";
         GxWebStd.gx_single_line_edit( context, edtAirlineId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A38AirlineId), 4, 0, ".", "")), StringUtil.LTrim( ((edtAirlineId_Enabled!=0) ? context.localUtil.Format( (decimal)(A38AirlineId), "ZZZ9") : context.localUtil.Format( (decimal)(A38AirlineId), "ZZZ9"))), " dir=\"ltr\" inputmode=\"numeric\" pattern=\"[0-9]*\""+TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(this,34);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtAirlineId_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtAirlineId_Enabled, 0, "text", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 0, -1, 0, true, "Id", "end", false, "", "HLP_Airline.htm");
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
         GxWebStd.gx_label_element( context, edtAirlineName_Internalname, "Name", "col-sm-3 AttributeLabel", 1, true, "");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "start", "top", "", "", "div");
         /* Single line edit */
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 39,'',false,'',0)\"";
         GxWebStd.gx_single_line_edit( context, edtAirlineName_Internalname, A39AirlineName, StringUtil.RTrim( context.localUtil.Format( A39AirlineName, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,39);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtAirlineName_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtAirlineName_Enabled, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 0, -1, -1, true, "Name", "start", true, "", "HLP_Airline.htm");
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
         GxWebStd.gx_label_element( context, edtAirlineDiscountPercentage_Internalname, "Discount Percentage", "col-sm-3 AttributeLabel", 1, true, "");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "start", "top", "", "", "div");
         /* Single line edit */
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 44,'',false,'',0)\"";
         GxWebStd.gx_single_line_edit( context, edtAirlineDiscountPercentage_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A40AirlineDiscountPercentage), 4, 0, ".", "")), StringUtil.LTrim( ((edtAirlineDiscountPercentage_Enabled!=0) ? context.localUtil.Format( (decimal)(A40AirlineDiscountPercentage), "ZZZ9") : context.localUtil.Format( (decimal)(A40AirlineDiscountPercentage), "ZZZ9"))), " dir=\"ltr\" inputmode=\"numeric\" pattern=\"[0-9]*\""+TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(this,44);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtAirlineDiscountPercentage_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtAirlineDiscountPercentage_Enabled, 0, "text", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 0, -1, 0, true, "Percentage", "end", false, "", "HLP_Airline.htm");
         GxWebStd.gx_div_end( context, "start", "top", "div");
         GxWebStd.gx_div_end( context, "start", "top", "div");
         GxWebStd.gx_div_end( context, "start", "top", "div");
         GxWebStd.gx_div_end( context, "start", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "start", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 form__cell", "start", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "start", "top", ""+" data-gx-for=\""+edtAirlineFlightMostExpensiveId_Internalname+"\"", "", "div");
         /* Attribute/Variable Label */
         GxWebStd.gx_label_element( context, edtAirlineFlightMostExpensiveId_Internalname, "Expensive Id", "col-sm-3 AttributeLabel", 1, true, "");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "start", "top", "", "", "div");
         /* Single line edit */
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 49,'',false,'',0)\"";
         GxWebStd.gx_single_line_edit( context, edtAirlineFlightMostExpensiveId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A47AirlineFlightMostExpensiveId), 4, 0, ".", "")), StringUtil.LTrim( ((edtAirlineFlightMostExpensiveId_Enabled!=0) ? context.localUtil.Format( (decimal)(A47AirlineFlightMostExpensiveId), "ZZZ9") : context.localUtil.Format( (decimal)(A47AirlineFlightMostExpensiveId), "ZZZ9"))), " dir=\"ltr\" inputmode=\"numeric\" pattern=\"[0-9]*\""+TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(this,49);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtAirlineFlightMostExpensiveId_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtAirlineFlightMostExpensiveId_Enabled, 0, "text", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 0, -1, 0, true, "Id", "end", false, "", "HLP_Airline.htm");
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
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 54,'',false,'',0)\"";
         ClassString = "Button button-primary";
         StyleString = "";
         GxWebStd.gx_button_ctrl( context, bttBtn_enter_Internalname, "", "Confirm", bttBtn_enter_Jsonclick, 5, "Confirm", "", StyleString, ClassString, bttBtn_enter_Visible, bttBtn_enter_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EENTER."+"'", TempTags, "", context.GetButtonType( ), "HLP_Airline.htm");
         GxWebStd.gx_div_end( context, "start", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "start", "top", "", "", "div");
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 56,'',false,'',0)\"";
         ClassString = "Button button-tertiary";
         StyleString = "";
         GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "", "Cancel", bttBtn_cancel_Jsonclick, 1, "Cancel", "", StyleString, ClassString, bttBtn_cancel_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_Airline.htm");
         GxWebStd.gx_div_end( context, "start", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "start", "top", "", "", "div");
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 58,'',false,'',0)\"";
         ClassString = "Button button-tertiary";
         StyleString = "";
         GxWebStd.gx_button_ctrl( context, bttBtn_delete_Internalname, "", "Delete", bttBtn_delete_Jsonclick, 5, "Delete", "", StyleString, ClassString, bttBtn_delete_Visible, bttBtn_delete_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EDELETE."+"'", TempTags, "", context.GetButtonType( ), "HLP_Airline.htm");
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
            Z38AirlineId = (short)(Math.Round(context.localUtil.CToN( cgiGet( "Z38AirlineId"), ".", ","), 18, MidpointRounding.ToEven));
            Z39AirlineName = cgiGet( "Z39AirlineName");
            Z40AirlineDiscountPercentage = (short)(Math.Round(context.localUtil.CToN( cgiGet( "Z40AirlineDiscountPercentage"), ".", ","), 18, MidpointRounding.ToEven));
            Z47AirlineFlightMostExpensiveId = (short)(Math.Round(context.localUtil.CToN( cgiGet( "Z47AirlineFlightMostExpensiveId"), ".", ","), 18, MidpointRounding.ToEven));
            IsConfirmed = (short)(Math.Round(context.localUtil.CToN( cgiGet( "IsConfirmed"), ".", ","), 18, MidpointRounding.ToEven));
            IsModified = (short)(Math.Round(context.localUtil.CToN( cgiGet( "IsModified"), ".", ","), 18, MidpointRounding.ToEven));
            Gx_mode = cgiGet( "Mode");
            /* Read variables values. */
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
            A39AirlineName = cgiGet( edtAirlineName_Internalname);
            AssignAttri("", false, "A39AirlineName", A39AirlineName);
            if ( ( ( context.localUtil.CToN( cgiGet( edtAirlineDiscountPercentage_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtAirlineDiscountPercentage_Internalname), ".", ",") > Convert.ToDecimal( 9999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "AIRLINEDISCOUNTPERCENTAGE");
               AnyError = 1;
               GX_FocusControl = edtAirlineDiscountPercentage_Internalname;
               AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               A40AirlineDiscountPercentage = 0;
               AssignAttri("", false, "A40AirlineDiscountPercentage", StringUtil.LTrimStr( (decimal)(A40AirlineDiscountPercentage), 4, 0));
            }
            else
            {
               A40AirlineDiscountPercentage = (short)(Math.Round(context.localUtil.CToN( cgiGet( edtAirlineDiscountPercentage_Internalname), ".", ","), 18, MidpointRounding.ToEven));
               AssignAttri("", false, "A40AirlineDiscountPercentage", StringUtil.LTrimStr( (decimal)(A40AirlineDiscountPercentage), 4, 0));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtAirlineFlightMostExpensiveId_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtAirlineFlightMostExpensiveId_Internalname), ".", ",") > Convert.ToDecimal( 9999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "AIRLINEFLIGHTMOSTEXPENSIVEID");
               AnyError = 1;
               GX_FocusControl = edtAirlineFlightMostExpensiveId_Internalname;
               AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               A47AirlineFlightMostExpensiveId = 0;
               AssignAttri("", false, "A47AirlineFlightMostExpensiveId", StringUtil.LTrimStr( (decimal)(A47AirlineFlightMostExpensiveId), 4, 0));
            }
            else
            {
               A47AirlineFlightMostExpensiveId = (short)(Math.Round(context.localUtil.CToN( cgiGet( edtAirlineFlightMostExpensiveId_Internalname), ".", ","), 18, MidpointRounding.ToEven));
               AssignAttri("", false, "A47AirlineFlightMostExpensiveId", StringUtil.LTrimStr( (decimal)(A47AirlineFlightMostExpensiveId), 4, 0));
            }
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
               A38AirlineId = (short)(Math.Round(NumberUtil.Val( GetPar( "AirlineId"), "."), 18, MidpointRounding.ToEven));
               n38AirlineId = false;
               AssignAttri("", false, "A38AirlineId", StringUtil.LTrimStr( (decimal)(A38AirlineId), 4, 0));
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
               InitAll0912( ) ;
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
         DisableAttributes0912( ) ;
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

      protected void ResetCaption090( )
      {
      }

      protected void ZM0912( short GX_JID )
      {
         if ( ( GX_JID == 1 ) || ( GX_JID == 0 ) )
         {
            if ( ! IsIns( ) )
            {
               Z39AirlineName = T00093_A39AirlineName[0];
               Z40AirlineDiscountPercentage = T00093_A40AirlineDiscountPercentage[0];
               Z47AirlineFlightMostExpensiveId = T00093_A47AirlineFlightMostExpensiveId[0];
            }
            else
            {
               Z39AirlineName = A39AirlineName;
               Z40AirlineDiscountPercentage = A40AirlineDiscountPercentage;
               Z47AirlineFlightMostExpensiveId = A47AirlineFlightMostExpensiveId;
            }
         }
         if ( GX_JID == -1 )
         {
            Z38AirlineId = A38AirlineId;
            Z39AirlineName = A39AirlineName;
            Z40AirlineDiscountPercentage = A40AirlineDiscountPercentage;
            Z47AirlineFlightMostExpensiveId = A47AirlineFlightMostExpensiveId;
         }
      }

      protected void standaloneNotModal( )
      {
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

      protected void Load0912( )
      {
         /* Using cursor T00094 */
         pr_default.execute(2, new Object[] {n38AirlineId, A38AirlineId});
         if ( (pr_default.getStatus(2) != 101) )
         {
            RcdFound12 = 1;
            A39AirlineName = T00094_A39AirlineName[0];
            AssignAttri("", false, "A39AirlineName", A39AirlineName);
            A40AirlineDiscountPercentage = T00094_A40AirlineDiscountPercentage[0];
            AssignAttri("", false, "A40AirlineDiscountPercentage", StringUtil.LTrimStr( (decimal)(A40AirlineDiscountPercentage), 4, 0));
            A47AirlineFlightMostExpensiveId = T00094_A47AirlineFlightMostExpensiveId[0];
            AssignAttri("", false, "A47AirlineFlightMostExpensiveId", StringUtil.LTrimStr( (decimal)(A47AirlineFlightMostExpensiveId), 4, 0));
            ZM0912( -1) ;
         }
         pr_default.close(2);
         OnLoadActions0912( ) ;
      }

      protected void OnLoadActions0912( )
      {
      }

      protected void CheckExtendedTable0912( )
      {
         nIsDirty_12 = 0;
         Gx_BScreen = 1;
         standaloneModal( ) ;
      }

      protected void CloseExtendedTableCursors0912( )
      {
      }

      protected void enableDisable( )
      {
      }

      protected void GetKey0912( )
      {
         /* Using cursor T00095 */
         pr_default.execute(3, new Object[] {n38AirlineId, A38AirlineId});
         if ( (pr_default.getStatus(3) != 101) )
         {
            RcdFound12 = 1;
         }
         else
         {
            RcdFound12 = 0;
         }
         pr_default.close(3);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T00093 */
         pr_default.execute(1, new Object[] {n38AirlineId, A38AirlineId});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM0912( 1) ;
            RcdFound12 = 1;
            A38AirlineId = T00093_A38AirlineId[0];
            n38AirlineId = T00093_n38AirlineId[0];
            AssignAttri("", false, "A38AirlineId", StringUtil.LTrimStr( (decimal)(A38AirlineId), 4, 0));
            A39AirlineName = T00093_A39AirlineName[0];
            AssignAttri("", false, "A39AirlineName", A39AirlineName);
            A40AirlineDiscountPercentage = T00093_A40AirlineDiscountPercentage[0];
            AssignAttri("", false, "A40AirlineDiscountPercentage", StringUtil.LTrimStr( (decimal)(A40AirlineDiscountPercentage), 4, 0));
            A47AirlineFlightMostExpensiveId = T00093_A47AirlineFlightMostExpensiveId[0];
            AssignAttri("", false, "A47AirlineFlightMostExpensiveId", StringUtil.LTrimStr( (decimal)(A47AirlineFlightMostExpensiveId), 4, 0));
            Z38AirlineId = A38AirlineId;
            sMode12 = Gx_mode;
            Gx_mode = "DSP";
            AssignAttri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Load0912( ) ;
            if ( AnyError == 1 )
            {
               RcdFound12 = 0;
               InitializeNonKey0912( ) ;
            }
            Gx_mode = sMode12;
            AssignAttri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            RcdFound12 = 0;
            InitializeNonKey0912( ) ;
            sMode12 = Gx_mode;
            Gx_mode = "DSP";
            AssignAttri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Gx_mode = sMode12;
            AssignAttri("", false, "Gx_mode", Gx_mode);
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey0912( ) ;
         if ( RcdFound12 == 0 )
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
         RcdFound12 = 0;
         /* Using cursor T00096 */
         pr_default.execute(4, new Object[] {n38AirlineId, A38AirlineId});
         if ( (pr_default.getStatus(4) != 101) )
         {
            while ( (pr_default.getStatus(4) != 101) && ( ( T00096_A38AirlineId[0] < A38AirlineId ) ) )
            {
               pr_default.readNext(4);
            }
            if ( (pr_default.getStatus(4) != 101) && ( ( T00096_A38AirlineId[0] > A38AirlineId ) ) )
            {
               A38AirlineId = T00096_A38AirlineId[0];
               n38AirlineId = T00096_n38AirlineId[0];
               AssignAttri("", false, "A38AirlineId", StringUtil.LTrimStr( (decimal)(A38AirlineId), 4, 0));
               RcdFound12 = 1;
            }
         }
         pr_default.close(4);
      }

      protected void move_previous( )
      {
         RcdFound12 = 0;
         /* Using cursor T00097 */
         pr_default.execute(5, new Object[] {n38AirlineId, A38AirlineId});
         if ( (pr_default.getStatus(5) != 101) )
         {
            while ( (pr_default.getStatus(5) != 101) && ( ( T00097_A38AirlineId[0] > A38AirlineId ) ) )
            {
               pr_default.readNext(5);
            }
            if ( (pr_default.getStatus(5) != 101) && ( ( T00097_A38AirlineId[0] < A38AirlineId ) ) )
            {
               A38AirlineId = T00097_A38AirlineId[0];
               n38AirlineId = T00097_n38AirlineId[0];
               AssignAttri("", false, "A38AirlineId", StringUtil.LTrimStr( (decimal)(A38AirlineId), 4, 0));
               RcdFound12 = 1;
            }
         }
         pr_default.close(5);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1;
         GetKey0912( ) ;
         if ( IsIns( ) )
         {
            /* Insert record */
            GX_FocusControl = edtAirlineId_Internalname;
            AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
            Insert0912( ) ;
            if ( AnyError == 1 )
            {
               GX_FocusControl = "";
               AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( RcdFound12 == 1 )
            {
               if ( A38AirlineId != Z38AirlineId )
               {
                  A38AirlineId = Z38AirlineId;
                  n38AirlineId = false;
                  AssignAttri("", false, "A38AirlineId", StringUtil.LTrimStr( (decimal)(A38AirlineId), 4, 0));
                  GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd", ""), "CandidateKeyNotFound", 1, "AIRLINEID");
                  AnyError = 1;
                  GX_FocusControl = edtAirlineId_Internalname;
                  AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else if ( IsDlt( ) )
               {
                  delete( ) ;
                  AfterTrn( ) ;
                  GX_FocusControl = edtAirlineId_Internalname;
                  AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else
               {
                  Gx_mode = "UPD";
                  AssignAttri("", false, "Gx_mode", Gx_mode);
                  /* Update record */
                  Update0912( ) ;
                  GX_FocusControl = edtAirlineId_Internalname;
                  AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
               }
            }
            else
            {
               if ( A38AirlineId != Z38AirlineId )
               {
                  Gx_mode = "INS";
                  AssignAttri("", false, "Gx_mode", Gx_mode);
                  /* Insert record */
                  GX_FocusControl = edtAirlineId_Internalname;
                  AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
                  Insert0912( ) ;
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
                     GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, "AIRLINEID");
                     AnyError = 1;
                     GX_FocusControl = edtAirlineId_Internalname;
                     AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
                  }
                  else
                  {
                     Gx_mode = "INS";
                     AssignAttri("", false, "Gx_mode", Gx_mode);
                     /* Insert record */
                     GX_FocusControl = edtAirlineId_Internalname;
                     AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
                     Insert0912( ) ;
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
         if ( A38AirlineId != Z38AirlineId )
         {
            A38AirlineId = Z38AirlineId;
            n38AirlineId = false;
            AssignAttri("", false, "A38AirlineId", StringUtil.LTrimStr( (decimal)(A38AirlineId), 4, 0));
            GX_msglist.addItem(context.GetMessage( "GXM_getbeforedlt", ""), 1, "AIRLINEID");
            AnyError = 1;
            GX_FocusControl = edtAirlineId_Internalname;
            AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         }
         else
         {
            delete( ) ;
            AfterTrn( ) ;
            GX_FocusControl = edtAirlineId_Internalname;
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
         if ( RcdFound12 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_keynfound", ""), "PrimaryKeyNotFound", 1, "AIRLINEID");
            AnyError = 1;
            GX_FocusControl = edtAirlineId_Internalname;
            AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         }
         GX_FocusControl = edtAirlineName_Internalname;
         AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_first( )
      {
         nKeyPressed = 2;
         IsConfirmed = 0;
         AssignAttri("", false, "IsConfirmed", StringUtil.LTrimStr( (decimal)(IsConfirmed), 4, 0));
         ScanStart0912( ) ;
         if ( RcdFound12 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            Gx_mode = "UPD";
            AssignAttri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtAirlineName_Internalname;
         AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         ScanEnd0912( ) ;
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
         if ( RcdFound12 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            Gx_mode = "UPD";
            AssignAttri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtAirlineName_Internalname;
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
         if ( RcdFound12 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            Gx_mode = "UPD";
            AssignAttri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtAirlineName_Internalname;
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
         ScanStart0912( ) ;
         if ( RcdFound12 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            while ( RcdFound12 != 0 )
            {
               ScanNext0912( ) ;
            }
            Gx_mode = "UPD";
            AssignAttri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtAirlineName_Internalname;
         AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         ScanEnd0912( ) ;
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_select( )
      {
         getEqualNoModal( ) ;
      }

      protected void CheckOptimisticConcurrency0912( )
      {
         if ( ! IsIns( ) )
         {
            /* Using cursor T00092 */
            pr_default.execute(0, new Object[] {n38AirlineId, A38AirlineId});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Airline"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            if ( (pr_default.getStatus(0) == 101) || ( StringUtil.StrCmp(Z39AirlineName, T00092_A39AirlineName[0]) != 0 ) || ( Z40AirlineDiscountPercentage != T00092_A40AirlineDiscountPercentage[0] ) || ( Z47AirlineFlightMostExpensiveId != T00092_A47AirlineFlightMostExpensiveId[0] ) )
            {
               if ( StringUtil.StrCmp(Z39AirlineName, T00092_A39AirlineName[0]) != 0 )
               {
                  GXUtil.WriteLog("airline:[seudo value changed for attri]"+"AirlineName");
                  GXUtil.WriteLogRaw("Old: ",Z39AirlineName);
                  GXUtil.WriteLogRaw("Current: ",T00092_A39AirlineName[0]);
               }
               if ( Z40AirlineDiscountPercentage != T00092_A40AirlineDiscountPercentage[0] )
               {
                  GXUtil.WriteLog("airline:[seudo value changed for attri]"+"AirlineDiscountPercentage");
                  GXUtil.WriteLogRaw("Old: ",Z40AirlineDiscountPercentage);
                  GXUtil.WriteLogRaw("Current: ",T00092_A40AirlineDiscountPercentage[0]);
               }
               if ( Z47AirlineFlightMostExpensiveId != T00092_A47AirlineFlightMostExpensiveId[0] )
               {
                  GXUtil.WriteLog("airline:[seudo value changed for attri]"+"AirlineFlightMostExpensiveId");
                  GXUtil.WriteLogRaw("Old: ",Z47AirlineFlightMostExpensiveId);
                  GXUtil.WriteLogRaw("Current: ",T00092_A47AirlineFlightMostExpensiveId[0]);
               }
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"Airline"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert0912( )
      {
         BeforeValidate0912( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0912( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM0912( 0) ;
            CheckOptimisticConcurrency0912( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0912( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert0912( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T00098 */
                     pr_default.execute(6, new Object[] {A39AirlineName, A40AirlineDiscountPercentage, A47AirlineFlightMostExpensiveId});
                     A38AirlineId = T00098_A38AirlineId[0];
                     n38AirlineId = T00098_n38AirlineId[0];
                     AssignAttri("", false, "A38AirlineId", StringUtil.LTrimStr( (decimal)(A38AirlineId), 4, 0));
                     pr_default.close(6);
                     pr_default.SmartCacheProvider.SetUpdated("Airline");
                     if ( AnyError == 0 )
                     {
                        /* Start of After( Insert) rules */
                        /* End of After( Insert) rules */
                        if ( AnyError == 0 )
                        {
                           /* Save values for previous() function. */
                           endTrnMsgTxt = context.GetMessage( "GXM_sucadded", "");
                           endTrnMsgCod = "SuccessfullyAdded";
                           ResetCaption090( ) ;
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
               Load0912( ) ;
            }
            EndLevel0912( ) ;
         }
         CloseExtendedTableCursors0912( ) ;
      }

      protected void Update0912( )
      {
         BeforeValidate0912( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0912( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0912( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0912( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate0912( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T00099 */
                     pr_default.execute(7, new Object[] {A39AirlineName, A40AirlineDiscountPercentage, A47AirlineFlightMostExpensiveId, n38AirlineId, A38AirlineId});
                     pr_default.close(7);
                     pr_default.SmartCacheProvider.SetUpdated("Airline");
                     if ( (pr_default.getStatus(7) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Airline"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate0912( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           getByPrimaryKey( ) ;
                           endTrnMsgTxt = context.GetMessage( "GXM_sucupdated", "");
                           endTrnMsgCod = "SuccessfullyUpdated";
                           ResetCaption090( ) ;
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
            EndLevel0912( ) ;
         }
         CloseExtendedTableCursors0912( ) ;
      }

      protected void DeferredUpdate0912( )
      {
      }

      protected void delete( )
      {
         Gx_mode = "DLT";
         AssignAttri("", false, "Gx_mode", Gx_mode);
         BeforeValidate0912( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0912( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls0912( ) ;
            AfterConfirm0912( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete0912( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T000910 */
                  pr_default.execute(8, new Object[] {n38AirlineId, A38AirlineId});
                  pr_default.close(8);
                  pr_default.SmartCacheProvider.SetUpdated("Airline");
                  if ( AnyError == 0 )
                  {
                     /* Start of After( delete) rules */
                     /* End of After( delete) rules */
                     if ( AnyError == 0 )
                     {
                        move_next( ) ;
                        if ( RcdFound12 == 0 )
                        {
                           InitAll0912( ) ;
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
                        ResetCaption090( ) ;
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
         sMode12 = Gx_mode;
         Gx_mode = "DLT";
         AssignAttri("", false, "Gx_mode", Gx_mode);
         EndLevel0912( ) ;
         Gx_mode = sMode12;
         AssignAttri("", false, "Gx_mode", Gx_mode);
      }

      protected void OnDeleteControls0912( )
      {
         standaloneModal( ) ;
         /* No delete mode formulas found. */
         if ( AnyError == 0 )
         {
            /* Using cursor T000911 */
            pr_default.execute(9, new Object[] {n38AirlineId, A38AirlineId});
            if ( (pr_default.getStatus(9) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"Flight"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_default.close(9);
         }
      }

      protected void EndLevel0912( )
      {
         if ( ! IsIns( ) )
         {
            pr_default.close(0);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete0912( ) ;
         }
         if ( AnyError == 0 )
         {
            pr_default.close(1);
            context.CommitDataStores("airline",pr_default);
            if ( AnyError == 0 )
            {
               ConfirmValues090( ) ;
            }
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1;
         }
         else
         {
            pr_default.close(1);
            context.RollbackDataStores("airline",pr_default);
         }
         IsModified = 0;
         if ( AnyError != 0 )
         {
            context.wjLoc = "";
            context.nUserReturn = 0;
         }
      }

      public void ScanStart0912( )
      {
         /* Using cursor T000912 */
         pr_default.execute(10);
         RcdFound12 = 0;
         if ( (pr_default.getStatus(10) != 101) )
         {
            RcdFound12 = 1;
            A38AirlineId = T000912_A38AirlineId[0];
            n38AirlineId = T000912_n38AirlineId[0];
            AssignAttri("", false, "A38AirlineId", StringUtil.LTrimStr( (decimal)(A38AirlineId), 4, 0));
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext0912( )
      {
         /* Scan next routine */
         pr_default.readNext(10);
         RcdFound12 = 0;
         if ( (pr_default.getStatus(10) != 101) )
         {
            RcdFound12 = 1;
            A38AirlineId = T000912_A38AirlineId[0];
            n38AirlineId = T000912_n38AirlineId[0];
            AssignAttri("", false, "A38AirlineId", StringUtil.LTrimStr( (decimal)(A38AirlineId), 4, 0));
         }
      }

      protected void ScanEnd0912( )
      {
         pr_default.close(10);
      }

      protected void AfterConfirm0912( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert0912( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate0912( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete0912( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete0912( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate0912( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes0912( )
      {
         edtAirlineId_Enabled = 0;
         AssignProp("", false, edtAirlineId_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtAirlineId_Enabled), 5, 0), true);
         edtAirlineName_Enabled = 0;
         AssignProp("", false, edtAirlineName_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtAirlineName_Enabled), 5, 0), true);
         edtAirlineDiscountPercentage_Enabled = 0;
         AssignProp("", false, edtAirlineDiscountPercentage_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtAirlineDiscountPercentage_Enabled), 5, 0), true);
         edtAirlineFlightMostExpensiveId_Enabled = 0;
         AssignProp("", false, edtAirlineFlightMostExpensiveId_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtAirlineFlightMostExpensiveId_Enabled), 5, 0), true);
      }

      protected void send_integrity_lvl_hashes0912( )
      {
      }

      protected void assign_properties_default( )
      {
      }

      protected void ConfirmValues090( )
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("airline.aspx") +"\">") ;
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
         GxWebStd.gx_hidden_field( context, "Z38AirlineId", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z38AirlineId), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z39AirlineName", Z39AirlineName);
         GxWebStd.gx_hidden_field( context, "Z40AirlineDiscountPercentage", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z40AirlineDiscountPercentage), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z47AirlineFlightMostExpensiveId", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z47AirlineFlightMostExpensiveId), 4, 0, ".", "")));
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
         return formatLink("airline.aspx")  ;
      }

      public override string GetPgmname( )
      {
         return "Airline" ;
      }

      public override string GetPgmdesc( )
      {
         return "Airline" ;
      }

      protected void InitializeNonKey0912( )
      {
         A39AirlineName = "";
         AssignAttri("", false, "A39AirlineName", A39AirlineName);
         A40AirlineDiscountPercentage = 0;
         AssignAttri("", false, "A40AirlineDiscountPercentage", StringUtil.LTrimStr( (decimal)(A40AirlineDiscountPercentage), 4, 0));
         A47AirlineFlightMostExpensiveId = 0;
         AssignAttri("", false, "A47AirlineFlightMostExpensiveId", StringUtil.LTrimStr( (decimal)(A47AirlineFlightMostExpensiveId), 4, 0));
         Z39AirlineName = "";
         Z40AirlineDiscountPercentage = 0;
         Z47AirlineFlightMostExpensiveId = 0;
      }

      protected void InitAll0912( )
      {
         A38AirlineId = 0;
         n38AirlineId = false;
         AssignAttri("", false, "A38AirlineId", StringUtil.LTrimStr( (decimal)(A38AirlineId), 4, 0));
         InitializeNonKey0912( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((string)Form.Jscriptsrc.Item(idxLst))), "?202392111354820", true, true);
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
         context.AddJavascriptSource("airline.js", "?202392111354821", false, true);
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
         edtAirlineId_Internalname = "AIRLINEID";
         edtAirlineName_Internalname = "AIRLINENAME";
         edtAirlineDiscountPercentage_Internalname = "AIRLINEDISCOUNTPERCENTAGE";
         edtAirlineFlightMostExpensiveId_Internalname = "AIRLINEFLIGHTMOSTEXPENSIVEID";
         divFormcontainer_Internalname = "FORMCONTAINER";
         bttBtn_enter_Internalname = "BTN_ENTER";
         bttBtn_cancel_Internalname = "BTN_CANCEL";
         bttBtn_delete_Internalname = "BTN_DELETE";
         divMaintable_Internalname = "MAINTABLE";
         Form.Internalname = "FORM";
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
         Form.Caption = "Airline";
         bttBtn_delete_Enabled = 1;
         bttBtn_delete_Visible = 1;
         bttBtn_cancel_Visible = 1;
         bttBtn_enter_Enabled = 1;
         bttBtn_enter_Visible = 1;
         edtAirlineFlightMostExpensiveId_Jsonclick = "";
         edtAirlineFlightMostExpensiveId_Enabled = 1;
         edtAirlineDiscountPercentage_Jsonclick = "";
         edtAirlineDiscountPercentage_Enabled = 1;
         edtAirlineName_Jsonclick = "";
         edtAirlineName_Enabled = 1;
         edtAirlineId_Jsonclick = "";
         edtAirlineId_Enabled = 1;
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
         GX_FocusControl = edtAirlineName_Internalname;
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

      public void Valid_Airlineid( )
      {
         n38AirlineId = false;
         context.wbHandled = 1;
         AfterKeyLoadScreen( ) ;
         Draw( ) ;
         send_integrity_footer_hashes( ) ;
         dynload_actions( ) ;
         /*  Sending validation outputs */
         AssignAttri("", false, "A39AirlineName", A39AirlineName);
         AssignAttri("", false, "A40AirlineDiscountPercentage", StringUtil.LTrim( StringUtil.NToC( (decimal)(A40AirlineDiscountPercentage), 4, 0, ".", "")));
         AssignAttri("", false, "A47AirlineFlightMostExpensiveId", StringUtil.LTrim( StringUtil.NToC( (decimal)(A47AirlineFlightMostExpensiveId), 4, 0, ".", "")));
         AssignAttri("", false, "Gx_mode", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "Z38AirlineId", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z38AirlineId), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z39AirlineName", Z39AirlineName);
         GxWebStd.gx_hidden_field( context, "Z40AirlineDiscountPercentage", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z40AirlineDiscountPercentage), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z47AirlineFlightMostExpensiveId", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z47AirlineFlightMostExpensiveId), 4, 0, ".", "")));
         AssignProp("", false, bttBtn_delete_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(bttBtn_delete_Enabled), 5, 0), true);
         AssignProp("", false, bttBtn_enter_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(bttBtn_enter_Enabled), 5, 0), true);
         SendCloseFormHiddens( ) ;
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
         setEventMetadata("VALID_AIRLINEID","{handler:'Valid_Airlineid',iparms:[{av:'A38AirlineId',fld:'AIRLINEID',pic:'ZZZ9'},{av:'Gx_mode',fld:'vMODE',pic:'@!'}]");
         setEventMetadata("VALID_AIRLINEID",",oparms:[{av:'A39AirlineName',fld:'AIRLINENAME',pic:''},{av:'A40AirlineDiscountPercentage',fld:'AIRLINEDISCOUNTPERCENTAGE',pic:'ZZZ9'},{av:'A47AirlineFlightMostExpensiveId',fld:'AIRLINEFLIGHTMOSTEXPENSIVEID',pic:'ZZZ9'},{av:'Gx_mode',fld:'vMODE',pic:'@!'},{av:'Z38AirlineId'},{av:'Z39AirlineName'},{av:'Z40AirlineDiscountPercentage'},{av:'Z47AirlineFlightMostExpensiveId'},{ctrl:'BTN_DELETE',prop:'Enabled'},{ctrl:'BTN_ENTER',prop:'Enabled'}]}");
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
      }

      public override void initialize( )
      {
         sPrefix = "";
         Z39AirlineName = "";
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
         A39AirlineName = "";
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
         T00094_A38AirlineId = new short[1] ;
         T00094_n38AirlineId = new bool[] {false} ;
         T00094_A39AirlineName = new string[] {""} ;
         T00094_A40AirlineDiscountPercentage = new short[1] ;
         T00094_A47AirlineFlightMostExpensiveId = new short[1] ;
         T00095_A38AirlineId = new short[1] ;
         T00095_n38AirlineId = new bool[] {false} ;
         T00093_A38AirlineId = new short[1] ;
         T00093_n38AirlineId = new bool[] {false} ;
         T00093_A39AirlineName = new string[] {""} ;
         T00093_A40AirlineDiscountPercentage = new short[1] ;
         T00093_A47AirlineFlightMostExpensiveId = new short[1] ;
         sMode12 = "";
         T00096_A38AirlineId = new short[1] ;
         T00096_n38AirlineId = new bool[] {false} ;
         T00097_A38AirlineId = new short[1] ;
         T00097_n38AirlineId = new bool[] {false} ;
         T00092_A38AirlineId = new short[1] ;
         T00092_n38AirlineId = new bool[] {false} ;
         T00092_A39AirlineName = new string[] {""} ;
         T00092_A40AirlineDiscountPercentage = new short[1] ;
         T00092_A47AirlineFlightMostExpensiveId = new short[1] ;
         T00098_A38AirlineId = new short[1] ;
         T00098_n38AirlineId = new bool[] {false} ;
         T000911_A19FlightId = new short[1] ;
         T000912_A38AirlineId = new short[1] ;
         T000912_n38AirlineId = new bool[] {false} ;
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         ZZ39AirlineName = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.airline__default(),
            new Object[][] {
                new Object[] {
               T00092_A38AirlineId, T00092_A39AirlineName, T00092_A40AirlineDiscountPercentage, T00092_A47AirlineFlightMostExpensiveId
               }
               , new Object[] {
               T00093_A38AirlineId, T00093_A39AirlineName, T00093_A40AirlineDiscountPercentage, T00093_A47AirlineFlightMostExpensiveId
               }
               , new Object[] {
               T00094_A38AirlineId, T00094_A39AirlineName, T00094_A40AirlineDiscountPercentage, T00094_A47AirlineFlightMostExpensiveId
               }
               , new Object[] {
               T00095_A38AirlineId
               }
               , new Object[] {
               T00096_A38AirlineId
               }
               , new Object[] {
               T00097_A38AirlineId
               }
               , new Object[] {
               T00098_A38AirlineId
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000911_A19FlightId
               }
               , new Object[] {
               T000912_A38AirlineId
               }
            }
         );
      }

      private short Z38AirlineId ;
      private short Z40AirlineDiscountPercentage ;
      private short Z47AirlineFlightMostExpensiveId ;
      private short GxWebError ;
      private short gxcookieaux ;
      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short initialized ;
      private short A38AirlineId ;
      private short A40AirlineDiscountPercentage ;
      private short A47AirlineFlightMostExpensiveId ;
      private short GX_JID ;
      private short RcdFound12 ;
      private short nIsDirty_12 ;
      private short Gx_BScreen ;
      private short gxajaxcallmode ;
      private short ZZ38AirlineId ;
      private short ZZ40AirlineDiscountPercentage ;
      private short ZZ47AirlineFlightMostExpensiveId ;
      private int trnEnded ;
      private int bttBtn_first_Visible ;
      private int bttBtn_previous_Visible ;
      private int bttBtn_next_Visible ;
      private int bttBtn_last_Visible ;
      private int bttBtn_select_Visible ;
      private int edtAirlineId_Enabled ;
      private int edtAirlineName_Enabled ;
      private int edtAirlineDiscountPercentage_Enabled ;
      private int edtAirlineFlightMostExpensiveId_Enabled ;
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
      private string edtAirlineId_Internalname ;
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
      private string edtAirlineId_Jsonclick ;
      private string edtAirlineName_Internalname ;
      private string edtAirlineName_Jsonclick ;
      private string edtAirlineDiscountPercentage_Internalname ;
      private string edtAirlineDiscountPercentage_Jsonclick ;
      private string edtAirlineFlightMostExpensiveId_Internalname ;
      private string edtAirlineFlightMostExpensiveId_Jsonclick ;
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
      private string sMode12 ;
      private string sDynURL ;
      private string FormProcess ;
      private string bodyStyle ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool wbErr ;
      private bool n38AirlineId ;
      private string Z39AirlineName ;
      private string A39AirlineName ;
      private string ZZ39AirlineName ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private short[] T00094_A38AirlineId ;
      private bool[] T00094_n38AirlineId ;
      private string[] T00094_A39AirlineName ;
      private short[] T00094_A40AirlineDiscountPercentage ;
      private short[] T00094_A47AirlineFlightMostExpensiveId ;
      private short[] T00095_A38AirlineId ;
      private bool[] T00095_n38AirlineId ;
      private short[] T00093_A38AirlineId ;
      private bool[] T00093_n38AirlineId ;
      private string[] T00093_A39AirlineName ;
      private short[] T00093_A40AirlineDiscountPercentage ;
      private short[] T00093_A47AirlineFlightMostExpensiveId ;
      private short[] T00096_A38AirlineId ;
      private bool[] T00096_n38AirlineId ;
      private short[] T00097_A38AirlineId ;
      private bool[] T00097_n38AirlineId ;
      private short[] T00092_A38AirlineId ;
      private bool[] T00092_n38AirlineId ;
      private string[] T00092_A39AirlineName ;
      private short[] T00092_A40AirlineDiscountPercentage ;
      private short[] T00092_A47AirlineFlightMostExpensiveId ;
      private short[] T00098_A38AirlineId ;
      private bool[] T00098_n38AirlineId ;
      private short[] T000911_A19FlightId ;
      private short[] T000912_A38AirlineId ;
      private bool[] T000912_n38AirlineId ;
      private GXWebForm Form ;
   }

   public class airline__default : DataStoreHelperBase, IDataStoreHelper
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
         ,new UpdateCursor(def[7])
         ,new UpdateCursor(def[8])
         ,new ForEachCursor(def[9])
         ,new ForEachCursor(def[10])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmT00094;
          prmT00094 = new Object[] {
          new ParDef("@AirlineId",GXType.Int16,4,0){Nullable=true}
          };
          Object[] prmT00095;
          prmT00095 = new Object[] {
          new ParDef("@AirlineId",GXType.Int16,4,0){Nullable=true}
          };
          Object[] prmT00093;
          prmT00093 = new Object[] {
          new ParDef("@AirlineId",GXType.Int16,4,0){Nullable=true}
          };
          Object[] prmT00096;
          prmT00096 = new Object[] {
          new ParDef("@AirlineId",GXType.Int16,4,0){Nullable=true}
          };
          Object[] prmT00097;
          prmT00097 = new Object[] {
          new ParDef("@AirlineId",GXType.Int16,4,0){Nullable=true}
          };
          Object[] prmT00092;
          prmT00092 = new Object[] {
          new ParDef("@AirlineId",GXType.Int16,4,0){Nullable=true}
          };
          Object[] prmT00098;
          prmT00098 = new Object[] {
          new ParDef("@AirlineName",GXType.NVarChar,40,0) ,
          new ParDef("@AirlineDiscountPercentage",GXType.Int16,4,0) ,
          new ParDef("@AirlineFlightMostExpensiveId",GXType.Int16,4,0)
          };
          Object[] prmT00099;
          prmT00099 = new Object[] {
          new ParDef("@AirlineName",GXType.NVarChar,40,0) ,
          new ParDef("@AirlineDiscountPercentage",GXType.Int16,4,0) ,
          new ParDef("@AirlineFlightMostExpensiveId",GXType.Int16,4,0) ,
          new ParDef("@AirlineId",GXType.Int16,4,0){Nullable=true}
          };
          Object[] prmT000910;
          prmT000910 = new Object[] {
          new ParDef("@AirlineId",GXType.Int16,4,0){Nullable=true}
          };
          Object[] prmT000911;
          prmT000911 = new Object[] {
          new ParDef("@AirlineId",GXType.Int16,4,0){Nullable=true}
          };
          Object[] prmT000912;
          prmT000912 = new Object[] {
          };
          def= new CursorDef[] {
              new CursorDef("T00092", "SELECT [AirlineId], [AirlineName], [AirlineDiscountPercentage], [AirlineFlightMostExpensiveId] FROM [Airline] WITH (UPDLOCK) WHERE [AirlineId] = @AirlineId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00092,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T00093", "SELECT [AirlineId], [AirlineName], [AirlineDiscountPercentage], [AirlineFlightMostExpensiveId] FROM [Airline] WHERE [AirlineId] = @AirlineId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00093,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T00094", "SELECT TM1.[AirlineId], TM1.[AirlineName], TM1.[AirlineDiscountPercentage], TM1.[AirlineFlightMostExpensiveId] FROM [Airline] TM1 WHERE TM1.[AirlineId] = @AirlineId ORDER BY TM1.[AirlineId]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT00094,100, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T00095", "SELECT [AirlineId] FROM [Airline] WHERE [AirlineId] = @AirlineId  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT00095,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T00096", "SELECT TOP 1 [AirlineId] FROM [Airline] WHERE ( [AirlineId] > @AirlineId) ORDER BY [AirlineId]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT00096,1, GxCacheFrequency.OFF ,true,true )
             ,new CursorDef("T00097", "SELECT TOP 1 [AirlineId] FROM [Airline] WHERE ( [AirlineId] < @AirlineId) ORDER BY [AirlineId] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT00097,1, GxCacheFrequency.OFF ,true,true )
             ,new CursorDef("T00098", "INSERT INTO [Airline]([AirlineName], [AirlineDiscountPercentage], [AirlineFlightMostExpensiveId]) VALUES(@AirlineName, @AirlineDiscountPercentage, @AirlineFlightMostExpensiveId); SELECT SCOPE_IDENTITY()",true, GxErrorMask.GX_NOMASK, false, this,prmT00098,1, GxCacheFrequency.OFF ,true,true )
             ,new CursorDef("T00099", "UPDATE [Airline] SET [AirlineName]=@AirlineName, [AirlineDiscountPercentage]=@AirlineDiscountPercentage, [AirlineFlightMostExpensiveId]=@AirlineFlightMostExpensiveId  WHERE [AirlineId] = @AirlineId", GxErrorMask.GX_NOMASK,prmT00099)
             ,new CursorDef("T000910", "DELETE FROM [Airline]  WHERE [AirlineId] = @AirlineId", GxErrorMask.GX_NOMASK,prmT000910)
             ,new CursorDef("T000911", "SELECT TOP 1 [FlightId] FROM [Flight] WHERE [AirlineId] = @AirlineId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000911,1, GxCacheFrequency.OFF ,true,true )
             ,new CursorDef("T000912", "SELECT [AirlineId] FROM [Airline] ORDER BY [AirlineId]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000912,100, GxCacheFrequency.OFF ,true,false )
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
                ((string[]) buf[1])[0] = rslt.getVarchar(2);
                ((short[]) buf[2])[0] = rslt.getShort(3);
                ((short[]) buf[3])[0] = rslt.getShort(4);
                return;
             case 1 :
                ((short[]) buf[0])[0] = rslt.getShort(1);
                ((string[]) buf[1])[0] = rslt.getVarchar(2);
                ((short[]) buf[2])[0] = rslt.getShort(3);
                ((short[]) buf[3])[0] = rslt.getShort(4);
                return;
             case 2 :
                ((short[]) buf[0])[0] = rslt.getShort(1);
                ((string[]) buf[1])[0] = rslt.getVarchar(2);
                ((short[]) buf[2])[0] = rslt.getShort(3);
                ((short[]) buf[3])[0] = rslt.getShort(4);
                return;
             case 3 :
                ((short[]) buf[0])[0] = rslt.getShort(1);
                return;
             case 4 :
                ((short[]) buf[0])[0] = rslt.getShort(1);
                return;
             case 5 :
                ((short[]) buf[0])[0] = rslt.getShort(1);
                return;
             case 6 :
                ((short[]) buf[0])[0] = rslt.getShort(1);
                return;
             case 9 :
                ((short[]) buf[0])[0] = rslt.getShort(1);
                return;
             case 10 :
                ((short[]) buf[0])[0] = rslt.getShort(1);
                return;
       }
    }

 }

}
