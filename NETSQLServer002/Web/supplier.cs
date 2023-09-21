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
   public class supplier : GXDataArea
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
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxNewRow_"+"Gridsupplier_attraction") == 0 )
         {
            gxnrGridsupplier_attraction_newrow_invoke( ) ;
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
            Form.Meta.addItem("description", "Supplier", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         if ( ! context.isAjaxRequest( ) )
         {
            GX_FocusControl = edtSupplierId_Internalname;
            AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         }
         wbErr = false;
         context.SetDefaultTheme("TravelAgency_Capa202309", true);
         if ( ! context.IsLocalStorageSupported( ) )
         {
            context.PushCurrentUrl();
         }
      }

      protected void gxnrGridsupplier_attraction_newrow_invoke( )
      {
         nRC_GXsfl_53 = (int)(Math.Round(NumberUtil.Val( GetPar( "nRC_GXsfl_53"), "."), 18, MidpointRounding.ToEven));
         nGXsfl_53_idx = (int)(Math.Round(NumberUtil.Val( GetPar( "nGXsfl_53_idx"), "."), 18, MidpointRounding.ToEven));
         sGXsfl_53_idx = GetPar( "sGXsfl_53_idx");
         Gx_mode = GetPar( "Mode");
         setAjaxCallMode();
         if ( ! IsValidAjaxCall( true) )
         {
            GxWebError = 1;
            return  ;
         }
         gxnrGridsupplier_attraction_newrow( ) ;
         /* End function gxnrGridsupplier_attraction_newrow_invoke */
      }

      public supplier( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("TravelAgency_Capa202309", true);
      }

      public supplier( IGxContext context )
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
         GxWebStd.gx_label_ctrl( context, lblTitle_Internalname, "Supplier", "", "", lblTitle_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "heading-01", 0, "", 1, 1, 0, 0, "HLP_Supplier.htm");
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
         GxWebStd.gx_button_ctrl( context, bttBtn_first_Internalname, "", "", bttBtn_first_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_first_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"EFIRST."+"'", TempTags, "", context.GetButtonType( ), "HLP_Supplier.htm");
         GxWebStd.gx_div_end( context, "start", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "start", "top", "", "", "div");
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 23,'',false,'',0)\"";
         ClassString = "Button button-auxiliary ico__arrow-prev";
         StyleString = "";
         GxWebStd.gx_button_ctrl( context, bttBtn_previous_Internalname, "", "", bttBtn_previous_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_previous_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"EPREVIOUS."+"'", TempTags, "", context.GetButtonType( ), "HLP_Supplier.htm");
         GxWebStd.gx_div_end( context, "start", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "start", "top", "", "", "div");
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 25,'',false,'',0)\"";
         ClassString = "Button button-auxiliary ico__arrow-next";
         StyleString = "";
         GxWebStd.gx_button_ctrl( context, bttBtn_next_Internalname, "", "", bttBtn_next_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_next_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ENEXT."+"'", TempTags, "", context.GetButtonType( ), "HLP_Supplier.htm");
         GxWebStd.gx_div_end( context, "start", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "start", "top", "", "", "div");
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 27,'',false,'',0)\"";
         ClassString = "Button button-auxiliary ico__arrow-last";
         StyleString = "";
         GxWebStd.gx_button_ctrl( context, bttBtn_last_Internalname, "", "", bttBtn_last_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_last_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ELAST."+"'", TempTags, "", context.GetButtonType( ), "HLP_Supplier.htm");
         GxWebStd.gx_div_end( context, "start", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "start", "top", "", "", "div");
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 29,'',false,'',0)\"";
         ClassString = "Button button-secondary";
         StyleString = "";
         GxWebStd.gx_button_ctrl( context, bttBtn_select_Internalname, "", "Select", bttBtn_select_Jsonclick, 4, "Select", "", StyleString, ClassString, bttBtn_select_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ESELECT."+"'", TempTags, "gx.popup.openPrompt('"+"gx00d0.aspx"+"',["+"{Ctrl:gx.dom.el('"+"SUPPLIERID"+"'), id:'"+"SUPPLIERID"+"'"+",IOType:'out',isKey:true,isLastKey:true}"+"],"+"null"+","+"'', false"+","+"true"+");"+"return false;", 2, "HLP_Supplier.htm");
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
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "start", "top", ""+" data-gx-for=\""+edtSupplierId_Internalname+"\"", "", "div");
         /* Attribute/Variable Label */
         GxWebStd.gx_label_element( context, edtSupplierId_Internalname, "Id", "col-sm-3 AttributeLabel", 1, true, "");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "start", "top", "", "", "div");
         /* Single line edit */
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 34,'',false,'',0)\"";
         GxWebStd.gx_single_line_edit( context, edtSupplierId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A48SupplierId), 4, 0, ".", "")), StringUtil.LTrim( ((edtSupplierId_Enabled!=0) ? context.localUtil.Format( (decimal)(A48SupplierId), "ZZZ9") : context.localUtil.Format( (decimal)(A48SupplierId), "ZZZ9"))), " dir=\"ltr\" inputmode=\"numeric\" pattern=\"[0-9]*\""+TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(this,34);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtSupplierId_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtSupplierId_Enabled, 0, "text", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 0, -1, 0, true, "Id", "end", false, "", "HLP_Supplier.htm");
         GxWebStd.gx_div_end( context, "start", "top", "div");
         GxWebStd.gx_div_end( context, "start", "top", "div");
         GxWebStd.gx_div_end( context, "start", "top", "div");
         GxWebStd.gx_div_end( context, "start", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "start", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 form__cell", "start", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "start", "top", ""+" data-gx-for=\""+edtSupplierName_Internalname+"\"", "", "div");
         /* Attribute/Variable Label */
         GxWebStd.gx_label_element( context, edtSupplierName_Internalname, "Name", "col-sm-3 AttributeLabel", 1, true, "");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "start", "top", "", "", "div");
         /* Single line edit */
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 39,'',false,'',0)\"";
         GxWebStd.gx_single_line_edit( context, edtSupplierName_Internalname, A49SupplierName, StringUtil.RTrim( context.localUtil.Format( A49SupplierName, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,39);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtSupplierName_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtSupplierName_Enabled, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 0, -1, -1, true, "Name", "start", true, "", "HLP_Supplier.htm");
         GxWebStd.gx_div_end( context, "start", "top", "div");
         GxWebStd.gx_div_end( context, "start", "top", "div");
         GxWebStd.gx_div_end( context, "start", "top", "div");
         GxWebStd.gx_div_end( context, "start", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "start", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 form__cell", "start", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "start", "top", ""+" data-gx-for=\""+edtSupplierAddress_Internalname+"\"", "", "div");
         /* Attribute/Variable Label */
         GxWebStd.gx_label_element( context, edtSupplierAddress_Internalname, "Address", "col-sm-3 AttributeLabel", 1, true, "");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "start", "top", "", "", "div");
         /* Multiple line edit */
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 44,'',false,'',0)\"";
         ClassString = "Attribute";
         StyleString = "";
         ClassString = "Attribute";
         StyleString = "";
         GxWebStd.gx_html_textarea( context, edtSupplierAddress_Internalname, A50SupplierAddress, "http://maps.google.com/maps?q="+GXUtil.UrlEncode( A50SupplierAddress), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,44);\"", 0, 1, edtSupplierAddress_Enabled, 0, 80, "chr", 10, "row", 0, StyleString, ClassString, "", "", "1024", -1, 0, "_blank", "", 0, true, "GeneXus\\Address", "'"+""+"'"+",false,"+"'"+""+"'", 0, "", "HLP_Supplier.htm");
         GxWebStd.gx_div_end( context, "start", "top", "div");
         GxWebStd.gx_div_end( context, "start", "top", "div");
         GxWebStd.gx_div_end( context, "start", "top", "div");
         GxWebStd.gx_div_end( context, "start", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "start", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "start", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, divAttractiontable_Internalname, 1, 0, "px", 0, "px", "form__table-level", "start", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "start", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 form__cell", "start", "top", "", "", "div");
         /* Text block */
         GxWebStd.gx_label_ctrl( context, lblTitleattraction_Internalname, "Attraction", "", "", lblTitleattraction_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "heading-04", 0, "", 1, 1, 0, 0, "HLP_Supplier.htm");
         GxWebStd.gx_div_end( context, "start", "top", "div");
         GxWebStd.gx_div_end( context, "start", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "start", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "start", "top", "", "", "div");
         gxdraw_Gridsupplier_attraction( ) ;
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
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 62,'',false,'',0)\"";
         ClassString = "Button button-primary";
         StyleString = "";
         GxWebStd.gx_button_ctrl( context, bttBtn_enter_Internalname, "", "Confirm", bttBtn_enter_Jsonclick, 5, "Confirm", "", StyleString, ClassString, bttBtn_enter_Visible, bttBtn_enter_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EENTER."+"'", TempTags, "", context.GetButtonType( ), "HLP_Supplier.htm");
         GxWebStd.gx_div_end( context, "start", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "start", "top", "", "", "div");
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 64,'',false,'',0)\"";
         ClassString = "Button button-tertiary";
         StyleString = "";
         GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "", "Cancel", bttBtn_cancel_Jsonclick, 1, "Cancel", "", StyleString, ClassString, bttBtn_cancel_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_Supplier.htm");
         GxWebStd.gx_div_end( context, "start", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "start", "top", "", "", "div");
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 66,'',false,'',0)\"";
         ClassString = "Button button-tertiary";
         StyleString = "";
         GxWebStd.gx_button_ctrl( context, bttBtn_delete_Internalname, "", "Delete", bttBtn_delete_Jsonclick, 5, "Delete", "", StyleString, ClassString, bttBtn_delete_Visible, bttBtn_delete_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EDELETE."+"'", TempTags, "", context.GetButtonType( ), "HLP_Supplier.htm");
         GxWebStd.gx_div_end( context, "start", "top", "div");
         GxWebStd.gx_div_end( context, "start", "top", "div");
         GxWebStd.gx_div_end( context, "end", "Middle", "div");
         GxWebStd.gx_div_end( context, "start", "top", "div");
         GxWebStd.gx_div_end( context, "start", "top", "div");
         GxWebStd.gx_div_end( context, "start", "top", "div");
      }

      protected void gxdraw_Gridsupplier_attraction( )
      {
         /*  Grid Control  */
         StartGridControl53( ) ;
         nGXsfl_53_idx = 0;
         if ( ( nKeyPressed == 1 ) && ( AnyError == 0 ) )
         {
            /* Enter key processing. */
            nBlankRcdCount2 = 5;
            if ( ! IsIns( ) )
            {
               /* Display confirmed (stored) records */
               nRcdExists_2 = 1;
               ScanStart0A2( ) ;
               while ( RcdFound2 != 0 )
               {
                  init_level_properties2( ) ;
                  getByPrimaryKey0A2( ) ;
                  AddRow0A2( ) ;
                  ScanNext0A2( ) ;
               }
               ScanEnd0A2( ) ;
               nBlankRcdCount2 = 5;
            }
         }
         else if ( ( nKeyPressed == 3 ) || ( nKeyPressed == 4 ) || ( ( nKeyPressed == 1 ) && ( AnyError != 0 ) ) )
         {
            /* Button check  or addlines. */
            standaloneNotModal0A2( ) ;
            standaloneModal0A2( ) ;
            sMode2 = Gx_mode;
            while ( nGXsfl_53_idx < nRC_GXsfl_53 )
            {
               bGXsfl_53_Refreshing = true;
               ReadRow0A2( ) ;
               edtAttractionId_Enabled = (int)(Math.Round(context.localUtil.CToN( cgiGet( "ATTRACTIONID_"+sGXsfl_53_idx+"Enabled"), ".", ","), 18, MidpointRounding.ToEven));
               AssignProp("", false, edtAttractionId_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtAttractionId_Enabled), 5, 0), !bGXsfl_53_Refreshing);
               edtAttractionName_Enabled = (int)(Math.Round(context.localUtil.CToN( cgiGet( "ATTRACTIONNAME_"+sGXsfl_53_idx+"Enabled"), ".", ","), 18, MidpointRounding.ToEven));
               AssignProp("", false, edtAttractionName_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtAttractionName_Enabled), 5, 0), !bGXsfl_53_Refreshing);
               edtAttractionPhoto_Enabled = (int)(Math.Round(context.localUtil.CToN( cgiGet( "ATTRACTIONPHOTO_"+sGXsfl_53_idx+"Enabled"), ".", ","), 18, MidpointRounding.ToEven));
               AssignProp("", false, edtAttractionPhoto_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtAttractionPhoto_Enabled), 5, 0), !bGXsfl_53_Refreshing);
               edtSupplierAttractionDate_Enabled = (int)(Math.Round(context.localUtil.CToN( cgiGet( "SUPPLIERATTRACTIONDATE_"+sGXsfl_53_idx+"Enabled"), ".", ","), 18, MidpointRounding.ToEven));
               AssignProp("", false, edtSupplierAttractionDate_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtSupplierAttractionDate_Enabled), 5, 0), !bGXsfl_53_Refreshing);
               if ( ( nRcdExists_2 == 0 ) && ! IsIns( ) )
               {
                  Gx_mode = "INS";
                  AssignAttri("", false, "Gx_mode", Gx_mode);
                  standaloneModal0A2( ) ;
               }
               SendRow0A2( ) ;
               bGXsfl_53_Refreshing = false;
            }
            Gx_mode = sMode2;
            AssignAttri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            /* Get or get-alike key processing. */
            nBlankRcdCount2 = 5;
            nRcdExists_2 = 1;
            if ( ! IsIns( ) )
            {
               ScanStart0A2( ) ;
               while ( RcdFound2 != 0 )
               {
                  sGXsfl_53_idx = StringUtil.PadL( StringUtil.LTrimStr( (decimal)(nGXsfl_53_idx+1), 4, 0), 4, "0");
                  SubsflControlProps_532( ) ;
                  init_level_properties2( ) ;
                  standaloneNotModal0A2( ) ;
                  getByPrimaryKey0A2( ) ;
                  standaloneModal0A2( ) ;
                  AddRow0A2( ) ;
                  ScanNext0A2( ) ;
               }
               ScanEnd0A2( ) ;
            }
         }
         /* Initialize fields for 'new' records and send them. */
         sMode2 = Gx_mode;
         Gx_mode = "INS";
         AssignAttri("", false, "Gx_mode", Gx_mode);
         sGXsfl_53_idx = StringUtil.PadL( StringUtil.LTrimStr( (decimal)(nGXsfl_53_idx+1), 4, 0), 4, "0");
         SubsflControlProps_532( ) ;
         InitAll0A2( ) ;
         init_level_properties2( ) ;
         nRcdExists_2 = 0;
         nIsMod_2 = 0;
         nRcdDeleted_2 = 0;
         nBlankRcdCount2 = (short)(nBlankRcdUsr2+nBlankRcdCount2);
         fRowAdded = 0;
         while ( nBlankRcdCount2 > 0 )
         {
            standaloneNotModal0A2( ) ;
            standaloneModal0A2( ) ;
            AddRow0A2( ) ;
            if ( ( nKeyPressed == 4 ) && ( fRowAdded == 0 ) )
            {
               fRowAdded = 1;
               GX_FocusControl = edtAttractionId_Internalname;
               AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
            }
            nBlankRcdCount2 = (short)(nBlankRcdCount2-1);
         }
         Gx_mode = sMode2;
         AssignAttri("", false, "Gx_mode", Gx_mode);
         sStyleString = "";
         context.WriteHtmlText( "<div id=\""+"Gridsupplier_attractionContainer"+"Div\" "+sStyleString+">"+"</div>") ;
         context.httpAjaxContext.ajax_rsp_assign_grid("_"+"Gridsupplier_attraction", Gridsupplier_attractionContainer, subGridsupplier_attraction_Internalname);
         if ( ! context.isAjaxRequest( ) && ! context.isSpaRequest( ) )
         {
            GxWebStd.gx_hidden_field( context, "Gridsupplier_attractionContainerData", Gridsupplier_attractionContainer.ToJavascriptSource());
         }
         if ( context.isAjaxRequest( ) || context.isSpaRequest( ) )
         {
            GxWebStd.gx_hidden_field( context, "Gridsupplier_attractionContainerData"+"V", Gridsupplier_attractionContainer.GridValuesHidden());
         }
         else
         {
            context.WriteHtmlText( "<input type=\"hidden\" "+"name=\""+"Gridsupplier_attractionContainerData"+"V"+"\" value='"+Gridsupplier_attractionContainer.GridValuesHidden()+"'/>") ;
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
            Z48SupplierId = (short)(Math.Round(context.localUtil.CToN( cgiGet( "Z48SupplierId"), ".", ","), 18, MidpointRounding.ToEven));
            Z49SupplierName = cgiGet( "Z49SupplierName");
            Z50SupplierAddress = cgiGet( "Z50SupplierAddress");
            IsConfirmed = (short)(Math.Round(context.localUtil.CToN( cgiGet( "IsConfirmed"), ".", ","), 18, MidpointRounding.ToEven));
            IsModified = (short)(Math.Round(context.localUtil.CToN( cgiGet( "IsModified"), ".", ","), 18, MidpointRounding.ToEven));
            Gx_mode = cgiGet( "Mode");
            nRC_GXsfl_53 = (int)(Math.Round(context.localUtil.CToN( cgiGet( "nRC_GXsfl_53"), ".", ","), 18, MidpointRounding.ToEven));
            A40000AttractionPhoto_GXI = cgiGet( "ATTRACTIONPHOTO_GXI");
            /* Read variables values. */
            if ( ( ( context.localUtil.CToN( cgiGet( edtSupplierId_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtSupplierId_Internalname), ".", ",") > Convert.ToDecimal( 9999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "SUPPLIERID");
               AnyError = 1;
               GX_FocusControl = edtSupplierId_Internalname;
               AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               A48SupplierId = 0;
               AssignAttri("", false, "A48SupplierId", StringUtil.LTrimStr( (decimal)(A48SupplierId), 4, 0));
            }
            else
            {
               A48SupplierId = (short)(Math.Round(context.localUtil.CToN( cgiGet( edtSupplierId_Internalname), ".", ","), 18, MidpointRounding.ToEven));
               AssignAttri("", false, "A48SupplierId", StringUtil.LTrimStr( (decimal)(A48SupplierId), 4, 0));
            }
            A49SupplierName = cgiGet( edtSupplierName_Internalname);
            AssignAttri("", false, "A49SupplierName", A49SupplierName);
            A50SupplierAddress = cgiGet( edtSupplierAddress_Internalname);
            AssignAttri("", false, "A50SupplierAddress", A50SupplierAddress);
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
               A48SupplierId = (short)(Math.Round(NumberUtil.Val( GetPar( "SupplierId"), "."), 18, MidpointRounding.ToEven));
               AssignAttri("", false, "A48SupplierId", StringUtil.LTrimStr( (decimal)(A48SupplierId), 4, 0));
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
               InitAll0A13( ) ;
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
         DisableAttributes0A13( ) ;
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

      protected void CONFIRM_0A2( )
      {
         nGXsfl_53_idx = 0;
         while ( nGXsfl_53_idx < nRC_GXsfl_53 )
         {
            ReadRow0A2( ) ;
            if ( ( nRcdExists_2 != 0 ) || ( nIsMod_2 != 0 ) )
            {
               GetKey0A2( ) ;
               if ( ( nRcdExists_2 == 0 ) && ( nRcdDeleted_2 == 0 ) )
               {
                  if ( RcdFound2 == 0 )
                  {
                     Gx_mode = "INS";
                     AssignAttri("", false, "Gx_mode", Gx_mode);
                     BeforeValidate0A2( ) ;
                     if ( AnyError == 0 )
                     {
                        CheckExtendedTable0A2( ) ;
                        CloseExtendedTableCursors0A2( ) ;
                        if ( AnyError == 0 )
                        {
                           IsConfirmed = 1;
                           AssignAttri("", false, "IsConfirmed", StringUtil.LTrimStr( (decimal)(IsConfirmed), 4, 0));
                        }
                     }
                  }
                  else
                  {
                     GXCCtl = "ATTRACTIONID_" + sGXsfl_53_idx;
                     GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, GXCCtl);
                     AnyError = 1;
                     GX_FocusControl = edtAttractionId_Internalname;
                     AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
                  }
               }
               else
               {
                  if ( RcdFound2 != 0 )
                  {
                     if ( nRcdDeleted_2 != 0 )
                     {
                        Gx_mode = "DLT";
                        AssignAttri("", false, "Gx_mode", Gx_mode);
                        getByPrimaryKey0A2( ) ;
                        Load0A2( ) ;
                        BeforeValidate0A2( ) ;
                        if ( AnyError == 0 )
                        {
                           OnDeleteControls0A2( ) ;
                        }
                     }
                     else
                     {
                        if ( nIsMod_2 != 0 )
                        {
                           Gx_mode = "UPD";
                           AssignAttri("", false, "Gx_mode", Gx_mode);
                           BeforeValidate0A2( ) ;
                           if ( AnyError == 0 )
                           {
                              CheckExtendedTable0A2( ) ;
                              CloseExtendedTableCursors0A2( ) ;
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
                     if ( nRcdDeleted_2 == 0 )
                     {
                        GXCCtl = "ATTRACTIONID_" + sGXsfl_53_idx;
                        GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, GXCCtl);
                        AnyError = 1;
                        GX_FocusControl = edtAttractionId_Internalname;
                        AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
                     }
                  }
               }
            }
            ChangePostValue( edtAttractionId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A7AttractionId), 4, 0, ".", ""))) ;
            ChangePostValue( edtAttractionName_Internalname, A8AttractionName) ;
            ChangePostValue( edtAttractionPhoto_Internalname, A13AttractionPhoto) ;
            ChangePostValue( edtSupplierAttractionDate_Internalname, context.localUtil.Format(A51SupplierAttractionDate, "99/99/99")) ;
            ChangePostValue( "ZT_"+"Z7AttractionId_"+sGXsfl_53_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z7AttractionId), 4, 0, ".", ""))) ;
            ChangePostValue( "ZT_"+"Z8AttractionName_"+sGXsfl_53_idx, Z8AttractionName) ;
            ChangePostValue( "ZT_"+"Z51SupplierAttractionDate_"+sGXsfl_53_idx, context.localUtil.DToC( Z51SupplierAttractionDate, 0, "/")) ;
            ChangePostValue( "nRcdDeleted_2_"+sGXsfl_53_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_2), 4, 0, ".", ""))) ;
            ChangePostValue( "nRcdExists_2_"+sGXsfl_53_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdExists_2), 4, 0, ".", ""))) ;
            ChangePostValue( "nIsMod_2_"+sGXsfl_53_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nIsMod_2), 4, 0, ".", ""))) ;
            if ( nIsMod_2 != 0 )
            {
               ChangePostValue( "ATTRACTIONID_"+sGXsfl_53_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtAttractionId_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "ATTRACTIONNAME_"+sGXsfl_53_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtAttractionName_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "ATTRACTIONPHOTO_"+sGXsfl_53_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtAttractionPhoto_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "SUPPLIERATTRACTIONDATE_"+sGXsfl_53_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtSupplierAttractionDate_Enabled), 5, 0, ".", ""))) ;
            }
         }
         /* Start of After( level) rules */
         /* End of After( level) rules */
      }

      protected void ResetCaption0A0( )
      {
      }

      protected void ZM0A13( short GX_JID )
      {
         if ( ( GX_JID == 2 ) || ( GX_JID == 0 ) )
         {
            if ( ! IsIns( ) )
            {
               Z49SupplierName = T000A5_A49SupplierName[0];
               Z50SupplierAddress = T000A5_A50SupplierAddress[0];
            }
            else
            {
               Z49SupplierName = A49SupplierName;
               Z50SupplierAddress = A50SupplierAddress;
            }
         }
         if ( GX_JID == -2 )
         {
            Z48SupplierId = A48SupplierId;
            Z49SupplierName = A49SupplierName;
            Z50SupplierAddress = A50SupplierAddress;
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

      protected void Load0A13( )
      {
         /* Using cursor T000A6 */
         pr_default.execute(4, new Object[] {A48SupplierId});
         if ( (pr_default.getStatus(4) != 101) )
         {
            RcdFound13 = 1;
            A49SupplierName = T000A6_A49SupplierName[0];
            AssignAttri("", false, "A49SupplierName", A49SupplierName);
            A50SupplierAddress = T000A6_A50SupplierAddress[0];
            AssignAttri("", false, "A50SupplierAddress", A50SupplierAddress);
            ZM0A13( -2) ;
         }
         pr_default.close(4);
         OnLoadActions0A13( ) ;
      }

      protected void OnLoadActions0A13( )
      {
      }

      protected void CheckExtendedTable0A13( )
      {
         nIsDirty_13 = 0;
         Gx_BScreen = 1;
         standaloneModal( ) ;
      }

      protected void CloseExtendedTableCursors0A13( )
      {
      }

      protected void enableDisable( )
      {
      }

      protected void GetKey0A13( )
      {
         /* Using cursor T000A7 */
         pr_default.execute(5, new Object[] {A48SupplierId});
         if ( (pr_default.getStatus(5) != 101) )
         {
            RcdFound13 = 1;
         }
         else
         {
            RcdFound13 = 0;
         }
         pr_default.close(5);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T000A5 */
         pr_default.execute(3, new Object[] {A48SupplierId});
         if ( (pr_default.getStatus(3) != 101) )
         {
            ZM0A13( 2) ;
            RcdFound13 = 1;
            A48SupplierId = T000A5_A48SupplierId[0];
            AssignAttri("", false, "A48SupplierId", StringUtil.LTrimStr( (decimal)(A48SupplierId), 4, 0));
            A49SupplierName = T000A5_A49SupplierName[0];
            AssignAttri("", false, "A49SupplierName", A49SupplierName);
            A50SupplierAddress = T000A5_A50SupplierAddress[0];
            AssignAttri("", false, "A50SupplierAddress", A50SupplierAddress);
            Z48SupplierId = A48SupplierId;
            sMode13 = Gx_mode;
            Gx_mode = "DSP";
            AssignAttri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Load0A13( ) ;
            if ( AnyError == 1 )
            {
               RcdFound13 = 0;
               InitializeNonKey0A13( ) ;
            }
            Gx_mode = sMode13;
            AssignAttri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            RcdFound13 = 0;
            InitializeNonKey0A13( ) ;
            sMode13 = Gx_mode;
            Gx_mode = "DSP";
            AssignAttri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Gx_mode = sMode13;
            AssignAttri("", false, "Gx_mode", Gx_mode);
         }
         pr_default.close(3);
      }

      protected void getEqualNoModal( )
      {
         GetKey0A13( ) ;
         if ( RcdFound13 == 0 )
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
         RcdFound13 = 0;
         /* Using cursor T000A8 */
         pr_default.execute(6, new Object[] {A48SupplierId});
         if ( (pr_default.getStatus(6) != 101) )
         {
            while ( (pr_default.getStatus(6) != 101) && ( ( T000A8_A48SupplierId[0] < A48SupplierId ) ) )
            {
               pr_default.readNext(6);
            }
            if ( (pr_default.getStatus(6) != 101) && ( ( T000A8_A48SupplierId[0] > A48SupplierId ) ) )
            {
               A48SupplierId = T000A8_A48SupplierId[0];
               AssignAttri("", false, "A48SupplierId", StringUtil.LTrimStr( (decimal)(A48SupplierId), 4, 0));
               RcdFound13 = 1;
            }
         }
         pr_default.close(6);
      }

      protected void move_previous( )
      {
         RcdFound13 = 0;
         /* Using cursor T000A9 */
         pr_default.execute(7, new Object[] {A48SupplierId});
         if ( (pr_default.getStatus(7) != 101) )
         {
            while ( (pr_default.getStatus(7) != 101) && ( ( T000A9_A48SupplierId[0] > A48SupplierId ) ) )
            {
               pr_default.readNext(7);
            }
            if ( (pr_default.getStatus(7) != 101) && ( ( T000A9_A48SupplierId[0] < A48SupplierId ) ) )
            {
               A48SupplierId = T000A9_A48SupplierId[0];
               AssignAttri("", false, "A48SupplierId", StringUtil.LTrimStr( (decimal)(A48SupplierId), 4, 0));
               RcdFound13 = 1;
            }
         }
         pr_default.close(7);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1;
         GetKey0A13( ) ;
         if ( IsIns( ) )
         {
            /* Insert record */
            GX_FocusControl = edtSupplierId_Internalname;
            AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
            Insert0A13( ) ;
            if ( AnyError == 1 )
            {
               GX_FocusControl = "";
               AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( RcdFound13 == 1 )
            {
               if ( A48SupplierId != Z48SupplierId )
               {
                  A48SupplierId = Z48SupplierId;
                  AssignAttri("", false, "A48SupplierId", StringUtil.LTrimStr( (decimal)(A48SupplierId), 4, 0));
                  GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd", ""), "CandidateKeyNotFound", 1, "SUPPLIERID");
                  AnyError = 1;
                  GX_FocusControl = edtSupplierId_Internalname;
                  AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else if ( IsDlt( ) )
               {
                  delete( ) ;
                  AfterTrn( ) ;
                  GX_FocusControl = edtSupplierId_Internalname;
                  AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else
               {
                  Gx_mode = "UPD";
                  AssignAttri("", false, "Gx_mode", Gx_mode);
                  /* Update record */
                  Update0A13( ) ;
                  GX_FocusControl = edtSupplierId_Internalname;
                  AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
               }
            }
            else
            {
               if ( A48SupplierId != Z48SupplierId )
               {
                  Gx_mode = "INS";
                  AssignAttri("", false, "Gx_mode", Gx_mode);
                  /* Insert record */
                  GX_FocusControl = edtSupplierId_Internalname;
                  AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
                  Insert0A13( ) ;
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
                     GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, "SUPPLIERID");
                     AnyError = 1;
                     GX_FocusControl = edtSupplierId_Internalname;
                     AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
                  }
                  else
                  {
                     Gx_mode = "INS";
                     AssignAttri("", false, "Gx_mode", Gx_mode);
                     /* Insert record */
                     GX_FocusControl = edtSupplierId_Internalname;
                     AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
                     Insert0A13( ) ;
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
         if ( A48SupplierId != Z48SupplierId )
         {
            A48SupplierId = Z48SupplierId;
            AssignAttri("", false, "A48SupplierId", StringUtil.LTrimStr( (decimal)(A48SupplierId), 4, 0));
            GX_msglist.addItem(context.GetMessage( "GXM_getbeforedlt", ""), 1, "SUPPLIERID");
            AnyError = 1;
            GX_FocusControl = edtSupplierId_Internalname;
            AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         }
         else
         {
            delete( ) ;
            AfterTrn( ) ;
            GX_FocusControl = edtSupplierId_Internalname;
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
         if ( RcdFound13 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_keynfound", ""), "PrimaryKeyNotFound", 1, "SUPPLIERID");
            AnyError = 1;
            GX_FocusControl = edtSupplierId_Internalname;
            AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         }
         GX_FocusControl = edtSupplierName_Internalname;
         AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_first( )
      {
         nKeyPressed = 2;
         IsConfirmed = 0;
         AssignAttri("", false, "IsConfirmed", StringUtil.LTrimStr( (decimal)(IsConfirmed), 4, 0));
         ScanStart0A13( ) ;
         if ( RcdFound13 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            Gx_mode = "UPD";
            AssignAttri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtSupplierName_Internalname;
         AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         ScanEnd0A13( ) ;
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
         if ( RcdFound13 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            Gx_mode = "UPD";
            AssignAttri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtSupplierName_Internalname;
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
         if ( RcdFound13 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            Gx_mode = "UPD";
            AssignAttri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtSupplierName_Internalname;
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
         ScanStart0A13( ) ;
         if ( RcdFound13 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            while ( RcdFound13 != 0 )
            {
               ScanNext0A13( ) ;
            }
            Gx_mode = "UPD";
            AssignAttri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtSupplierName_Internalname;
         AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         ScanEnd0A13( ) ;
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_select( )
      {
         getEqualNoModal( ) ;
      }

      protected void CheckOptimisticConcurrency0A13( )
      {
         if ( ! IsIns( ) )
         {
            /* Using cursor T000A4 */
            pr_default.execute(2, new Object[] {A48SupplierId});
            if ( (pr_default.getStatus(2) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Supplier"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            if ( (pr_default.getStatus(2) == 101) || ( StringUtil.StrCmp(Z49SupplierName, T000A4_A49SupplierName[0]) != 0 ) || ( StringUtil.StrCmp(Z50SupplierAddress, T000A4_A50SupplierAddress[0]) != 0 ) )
            {
               if ( StringUtil.StrCmp(Z49SupplierName, T000A4_A49SupplierName[0]) != 0 )
               {
                  GXUtil.WriteLog("supplier:[seudo value changed for attri]"+"SupplierName");
                  GXUtil.WriteLogRaw("Old: ",Z49SupplierName);
                  GXUtil.WriteLogRaw("Current: ",T000A4_A49SupplierName[0]);
               }
               if ( StringUtil.StrCmp(Z50SupplierAddress, T000A4_A50SupplierAddress[0]) != 0 )
               {
                  GXUtil.WriteLog("supplier:[seudo value changed for attri]"+"SupplierAddress");
                  GXUtil.WriteLogRaw("Old: ",Z50SupplierAddress);
                  GXUtil.WriteLogRaw("Current: ",T000A4_A50SupplierAddress[0]);
               }
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"Supplier"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert0A13( )
      {
         BeforeValidate0A13( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0A13( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM0A13( 0) ;
            CheckOptimisticConcurrency0A13( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0A13( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert0A13( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000A10 */
                     pr_default.execute(8, new Object[] {A49SupplierName, A50SupplierAddress});
                     A48SupplierId = T000A10_A48SupplierId[0];
                     AssignAttri("", false, "A48SupplierId", StringUtil.LTrimStr( (decimal)(A48SupplierId), 4, 0));
                     pr_default.close(8);
                     pr_default.SmartCacheProvider.SetUpdated("Supplier");
                     if ( AnyError == 0 )
                     {
                        /* Start of After( Insert) rules */
                        /* End of After( Insert) rules */
                        if ( AnyError == 0 )
                        {
                           ProcessLevel0A13( ) ;
                           if ( AnyError == 0 )
                           {
                              /* Save values for previous() function. */
                              endTrnMsgTxt = context.GetMessage( "GXM_sucadded", "");
                              endTrnMsgCod = "SuccessfullyAdded";
                              ResetCaption0A0( ) ;
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
               Load0A13( ) ;
            }
            EndLevel0A13( ) ;
         }
         CloseExtendedTableCursors0A13( ) ;
      }

      protected void Update0A13( )
      {
         BeforeValidate0A13( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0A13( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0A13( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0A13( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate0A13( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000A11 */
                     pr_default.execute(9, new Object[] {A49SupplierName, A50SupplierAddress, A48SupplierId});
                     pr_default.close(9);
                     pr_default.SmartCacheProvider.SetUpdated("Supplier");
                     if ( (pr_default.getStatus(9) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Supplier"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate0A13( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           ProcessLevel0A13( ) ;
                           if ( AnyError == 0 )
                           {
                              getByPrimaryKey( ) ;
                              endTrnMsgTxt = context.GetMessage( "GXM_sucupdated", "");
                              endTrnMsgCod = "SuccessfullyUpdated";
                              ResetCaption0A0( ) ;
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
            EndLevel0A13( ) ;
         }
         CloseExtendedTableCursors0A13( ) ;
      }

      protected void DeferredUpdate0A13( )
      {
      }

      protected void delete( )
      {
         Gx_mode = "DLT";
         AssignAttri("", false, "Gx_mode", Gx_mode);
         BeforeValidate0A13( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0A13( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls0A13( ) ;
            AfterConfirm0A13( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete0A13( ) ;
               if ( AnyError == 0 )
               {
                  ScanStart0A2( ) ;
                  while ( RcdFound2 != 0 )
                  {
                     getByPrimaryKey0A2( ) ;
                     Delete0A2( ) ;
                     ScanNext0A2( ) ;
                  }
                  ScanEnd0A2( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000A12 */
                     pr_default.execute(10, new Object[] {A48SupplierId});
                     pr_default.close(10);
                     pr_default.SmartCacheProvider.SetUpdated("Supplier");
                     if ( AnyError == 0 )
                     {
                        /* Start of After( delete) rules */
                        /* End of After( delete) rules */
                        if ( AnyError == 0 )
                        {
                           move_next( ) ;
                           if ( RcdFound13 == 0 )
                           {
                              InitAll0A13( ) ;
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
                           ResetCaption0A0( ) ;
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
         sMode13 = Gx_mode;
         Gx_mode = "DLT";
         AssignAttri("", false, "Gx_mode", Gx_mode);
         EndLevel0A13( ) ;
         Gx_mode = sMode13;
         AssignAttri("", false, "Gx_mode", Gx_mode);
      }

      protected void OnDeleteControls0A13( )
      {
         standaloneModal( ) ;
         /* No delete mode formulas found. */
      }

      protected void ProcessNestedLevel0A2( )
      {
         nGXsfl_53_idx = 0;
         while ( nGXsfl_53_idx < nRC_GXsfl_53 )
         {
            ReadRow0A2( ) ;
            if ( ( nRcdExists_2 != 0 ) || ( nIsMod_2 != 0 ) )
            {
               standaloneNotModal0A2( ) ;
               GetKey0A2( ) ;
               if ( ( nRcdExists_2 == 0 ) && ( nRcdDeleted_2 == 0 ) )
               {
                  Gx_mode = "INS";
                  AssignAttri("", false, "Gx_mode", Gx_mode);
                  Insert0A2( ) ;
               }
               else
               {
                  if ( RcdFound2 != 0 )
                  {
                     if ( ( nRcdDeleted_2 != 0 ) && ( nRcdExists_2 != 0 ) )
                     {
                        Gx_mode = "DLT";
                        AssignAttri("", false, "Gx_mode", Gx_mode);
                        Delete0A2( ) ;
                     }
                     else
                     {
                        if ( nRcdExists_2 != 0 )
                        {
                           Gx_mode = "UPD";
                           AssignAttri("", false, "Gx_mode", Gx_mode);
                           Update0A2( ) ;
                        }
                     }
                  }
                  else
                  {
                     if ( nRcdDeleted_2 == 0 )
                     {
                        GXCCtl = "ATTRACTIONID_" + sGXsfl_53_idx;
                        GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, GXCCtl);
                        AnyError = 1;
                        GX_FocusControl = edtAttractionId_Internalname;
                        AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
                     }
                  }
               }
            }
            ChangePostValue( edtAttractionId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A7AttractionId), 4, 0, ".", ""))) ;
            ChangePostValue( edtAttractionName_Internalname, A8AttractionName) ;
            ChangePostValue( edtAttractionPhoto_Internalname, A13AttractionPhoto) ;
            ChangePostValue( edtSupplierAttractionDate_Internalname, context.localUtil.Format(A51SupplierAttractionDate, "99/99/99")) ;
            ChangePostValue( "ZT_"+"Z7AttractionId_"+sGXsfl_53_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z7AttractionId), 4, 0, ".", ""))) ;
            ChangePostValue( "ZT_"+"Z8AttractionName_"+sGXsfl_53_idx, Z8AttractionName) ;
            ChangePostValue( "ZT_"+"Z51SupplierAttractionDate_"+sGXsfl_53_idx, context.localUtil.DToC( Z51SupplierAttractionDate, 0, "/")) ;
            ChangePostValue( "nRcdDeleted_2_"+sGXsfl_53_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_2), 4, 0, ".", ""))) ;
            ChangePostValue( "nRcdExists_2_"+sGXsfl_53_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdExists_2), 4, 0, ".", ""))) ;
            ChangePostValue( "nIsMod_2_"+sGXsfl_53_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nIsMod_2), 4, 0, ".", ""))) ;
            if ( nIsMod_2 != 0 )
            {
               ChangePostValue( "ATTRACTIONID_"+sGXsfl_53_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtAttractionId_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "ATTRACTIONNAME_"+sGXsfl_53_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtAttractionName_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "ATTRACTIONPHOTO_"+sGXsfl_53_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtAttractionPhoto_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "SUPPLIERATTRACTIONDATE_"+sGXsfl_53_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtSupplierAttractionDate_Enabled), 5, 0, ".", ""))) ;
            }
         }
         /* Start of After( level) rules */
         /* End of After( level) rules */
         InitAll0A2( ) ;
         if ( AnyError != 0 )
         {
         }
         nRcdExists_2 = 0;
         nIsMod_2 = 0;
         nRcdDeleted_2 = 0;
      }

      protected void ProcessLevel0A13( )
      {
         /* Save parent mode. */
         sMode13 = Gx_mode;
         ProcessNestedLevel0A2( ) ;
         if ( AnyError != 0 )
         {
         }
         /* Restore parent mode. */
         Gx_mode = sMode13;
         AssignAttri("", false, "Gx_mode", Gx_mode);
         /* ' Update level parameters */
      }

      protected void EndLevel0A13( )
      {
         if ( ! IsIns( ) )
         {
            pr_default.close(2);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete0A13( ) ;
         }
         if ( AnyError == 0 )
         {
            pr_default.close(3);
            pr_default.close(1);
            pr_default.close(0);
            context.CommitDataStores("supplier",pr_default);
            if ( AnyError == 0 )
            {
               ConfirmValues0A0( ) ;
            }
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1;
         }
         else
         {
            pr_default.close(3);
            pr_default.close(1);
            pr_default.close(0);
            context.RollbackDataStores("supplier",pr_default);
         }
         IsModified = 0;
         if ( AnyError != 0 )
         {
            context.wjLoc = "";
            context.nUserReturn = 0;
         }
      }

      public void ScanStart0A13( )
      {
         /* Using cursor T000A13 */
         pr_default.execute(11);
         RcdFound13 = 0;
         if ( (pr_default.getStatus(11) != 101) )
         {
            RcdFound13 = 1;
            A48SupplierId = T000A13_A48SupplierId[0];
            AssignAttri("", false, "A48SupplierId", StringUtil.LTrimStr( (decimal)(A48SupplierId), 4, 0));
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext0A13( )
      {
         /* Scan next routine */
         pr_default.readNext(11);
         RcdFound13 = 0;
         if ( (pr_default.getStatus(11) != 101) )
         {
            RcdFound13 = 1;
            A48SupplierId = T000A13_A48SupplierId[0];
            AssignAttri("", false, "A48SupplierId", StringUtil.LTrimStr( (decimal)(A48SupplierId), 4, 0));
         }
      }

      protected void ScanEnd0A13( )
      {
         pr_default.close(11);
      }

      protected void AfterConfirm0A13( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert0A13( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate0A13( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete0A13( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete0A13( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate0A13( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes0A13( )
      {
         edtSupplierId_Enabled = 0;
         AssignProp("", false, edtSupplierId_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtSupplierId_Enabled), 5, 0), true);
         edtSupplierName_Enabled = 0;
         AssignProp("", false, edtSupplierName_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtSupplierName_Enabled), 5, 0), true);
         edtSupplierAddress_Enabled = 0;
         AssignProp("", false, edtSupplierAddress_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtSupplierAddress_Enabled), 5, 0), true);
      }

      protected void ZM0A2( short GX_JID )
      {
         if ( ( GX_JID == 3 ) || ( GX_JID == 0 ) )
         {
            if ( ! IsIns( ) )
            {
               Z8AttractionName = T000A3_A8AttractionName[0];
               Z51SupplierAttractionDate = T000A3_A51SupplierAttractionDate[0];
            }
            else
            {
               Z8AttractionName = A8AttractionName;
               Z51SupplierAttractionDate = A51SupplierAttractionDate;
            }
         }
         if ( GX_JID == -3 )
         {
            Z7AttractionId = A7AttractionId;
            Z8AttractionName = A8AttractionName;
            Z13AttractionPhoto = A13AttractionPhoto;
            Z40000AttractionPhoto_GXI = A40000AttractionPhoto_GXI;
            Z51SupplierAttractionDate = A51SupplierAttractionDate;
         }
      }

      protected void standaloneNotModal0A2( )
      {
      }

      protected void standaloneModal0A2( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            edtAttractionId_Enabled = 0;
            AssignProp("", false, edtAttractionId_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtAttractionId_Enabled), 5, 0), !bGXsfl_53_Refreshing);
         }
         else
         {
            edtAttractionId_Enabled = 1;
            AssignProp("", false, edtAttractionId_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtAttractionId_Enabled), 5, 0), !bGXsfl_53_Refreshing);
         }
      }

      protected void Load0A2( )
      {
         /* Using cursor T000A14 */
         pr_default.execute(12, new Object[] {A7AttractionId});
         if ( (pr_default.getStatus(12) != 101) )
         {
            RcdFound2 = 1;
            A8AttractionName = T000A14_A8AttractionName[0];
            A40000AttractionPhoto_GXI = T000A14_A40000AttractionPhoto_GXI[0];
            AssignProp("", false, edtAttractionPhoto_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A13AttractionPhoto)) ? A40000AttractionPhoto_GXI : context.convertURL( context.PathToRelativeUrl( A13AttractionPhoto))), !bGXsfl_53_Refreshing);
            AssignProp("", false, edtAttractionPhoto_Internalname, "SrcSet", context.GetImageSrcSet( A13AttractionPhoto), true);
            A51SupplierAttractionDate = T000A14_A51SupplierAttractionDate[0];
            A13AttractionPhoto = T000A14_A13AttractionPhoto[0];
            AssignProp("", false, edtAttractionPhoto_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A13AttractionPhoto)) ? A40000AttractionPhoto_GXI : context.convertURL( context.PathToRelativeUrl( A13AttractionPhoto))), !bGXsfl_53_Refreshing);
            AssignProp("", false, edtAttractionPhoto_Internalname, "SrcSet", context.GetImageSrcSet( A13AttractionPhoto), true);
            ZM0A2( -3) ;
         }
         pr_default.close(12);
         OnLoadActions0A2( ) ;
      }

      protected void OnLoadActions0A2( )
      {
      }

      protected void CheckExtendedTable0A2( )
      {
         nIsDirty_2 = 0;
         Gx_BScreen = 1;
         standaloneModal0A2( ) ;
         /* Using cursor T000A15 */
         pr_default.execute(13, new Object[] {A8AttractionName, A7AttractionId});
         if ( (pr_default.getStatus(13) != 101) )
         {
            GXCCtl = "ATTRACTIONNAME_" + sGXsfl_53_idx;
            GX_msglist.addItem(context.GetMessage( "GXM_1004", new   object[]  {"Attraction Name"}), 1, GXCCtl);
            AnyError = 1;
            GX_FocusControl = edtAttractionName_Internalname;
            AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         }
         pr_default.close(13);
         if ( ! ( (DateTime.MinValue==A51SupplierAttractionDate) || ( DateTimeUtil.ResetTime ( A51SupplierAttractionDate ) >= DateTimeUtil.ResetTime ( context.localUtil.YMDToD( 1753, 1, 1) ) ) ) )
         {
            GXCCtl = "SUPPLIERATTRACTIONDATE_" + sGXsfl_53_idx;
            GX_msglist.addItem("Field Supplier Attraction Date is out of range", "OutOfRange", 1, GXCCtl);
            AnyError = 1;
            GX_FocusControl = edtSupplierAttractionDate_Internalname;
            AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         }
      }

      protected void CloseExtendedTableCursors0A2( )
      {
      }

      protected void enableDisable0A2( )
      {
      }

      protected void GetKey0A2( )
      {
         /* Using cursor T000A16 */
         pr_default.execute(14, new Object[] {A7AttractionId});
         if ( (pr_default.getStatus(14) != 101) )
         {
            RcdFound2 = 1;
         }
         else
         {
            RcdFound2 = 0;
         }
         pr_default.close(14);
      }

      protected void getByPrimaryKey0A2( )
      {
         /* Using cursor T000A3 */
         pr_default.execute(1, new Object[] {A7AttractionId});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM0A2( 3) ;
            RcdFound2 = 1;
            InitializeNonKey0A2( ) ;
            A7AttractionId = T000A3_A7AttractionId[0];
            A8AttractionName = T000A3_A8AttractionName[0];
            A40000AttractionPhoto_GXI = T000A3_A40000AttractionPhoto_GXI[0];
            AssignProp("", false, edtAttractionPhoto_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A13AttractionPhoto)) ? A40000AttractionPhoto_GXI : context.convertURL( context.PathToRelativeUrl( A13AttractionPhoto))), !bGXsfl_53_Refreshing);
            AssignProp("", false, edtAttractionPhoto_Internalname, "SrcSet", context.GetImageSrcSet( A13AttractionPhoto), true);
            A51SupplierAttractionDate = T000A3_A51SupplierAttractionDate[0];
            A13AttractionPhoto = T000A3_A13AttractionPhoto[0];
            AssignProp("", false, edtAttractionPhoto_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A13AttractionPhoto)) ? A40000AttractionPhoto_GXI : context.convertURL( context.PathToRelativeUrl( A13AttractionPhoto))), !bGXsfl_53_Refreshing);
            AssignProp("", false, edtAttractionPhoto_Internalname, "SrcSet", context.GetImageSrcSet( A13AttractionPhoto), true);
            Z7AttractionId = A7AttractionId;
            sMode2 = Gx_mode;
            Gx_mode = "DSP";
            AssignAttri("", false, "Gx_mode", Gx_mode);
            standaloneModal0A2( ) ;
            Load0A2( ) ;
            Gx_mode = sMode2;
            AssignAttri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            RcdFound2 = 0;
            InitializeNonKey0A2( ) ;
            sMode2 = Gx_mode;
            Gx_mode = "DSP";
            AssignAttri("", false, "Gx_mode", Gx_mode);
            standaloneModal0A2( ) ;
            Gx_mode = sMode2;
            AssignAttri("", false, "Gx_mode", Gx_mode);
         }
         if ( IsDsp( ) || IsDlt( ) )
         {
            DisableAttributes0A2( ) ;
         }
         pr_default.close(1);
      }

      protected void CheckOptimisticConcurrency0A2( )
      {
         if ( ! IsIns( ) )
         {
            /* Using cursor T000A2 */
            pr_default.execute(0, new Object[] {A7AttractionId});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Attraction"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            if ( (pr_default.getStatus(0) == 101) || ( StringUtil.StrCmp(Z8AttractionName, T000A2_A8AttractionName[0]) != 0 ) || ( DateTimeUtil.ResetTime ( Z51SupplierAttractionDate ) != DateTimeUtil.ResetTime ( T000A2_A51SupplierAttractionDate[0] ) ) )
            {
               if ( StringUtil.StrCmp(Z8AttractionName, T000A2_A8AttractionName[0]) != 0 )
               {
                  GXUtil.WriteLog("supplier:[seudo value changed for attri]"+"AttractionName");
                  GXUtil.WriteLogRaw("Old: ",Z8AttractionName);
                  GXUtil.WriteLogRaw("Current: ",T000A2_A8AttractionName[0]);
               }
               if ( DateTimeUtil.ResetTime ( Z51SupplierAttractionDate ) != DateTimeUtil.ResetTime ( T000A2_A51SupplierAttractionDate[0] ) )
               {
                  GXUtil.WriteLog("supplier:[seudo value changed for attri]"+"SupplierAttractionDate");
                  GXUtil.WriteLogRaw("Old: ",Z51SupplierAttractionDate);
                  GXUtil.WriteLogRaw("Current: ",T000A2_A51SupplierAttractionDate[0]);
               }
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"Attraction"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert0A2( )
      {
         BeforeValidate0A2( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0A2( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM0A2( 0) ;
            CheckOptimisticConcurrency0A2( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0A2( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert0A2( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000A17 */
                     pr_default.execute(15, new Object[] {A8AttractionName, A13AttractionPhoto, A40000AttractionPhoto_GXI, A51SupplierAttractionDate});
                     A7AttractionId = T000A17_A7AttractionId[0];
                     pr_default.close(15);
                     pr_default.SmartCacheProvider.SetUpdated("Attraction");
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
               Load0A2( ) ;
            }
            EndLevel0A2( ) ;
         }
         CloseExtendedTableCursors0A2( ) ;
      }

      protected void Update0A2( )
      {
         BeforeValidate0A2( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0A2( ) ;
         }
         if ( ( nIsMod_2 != 0 ) || ( nIsDirty_2 != 0 ) )
         {
            if ( AnyError == 0 )
            {
               CheckOptimisticConcurrency0A2( ) ;
               if ( AnyError == 0 )
               {
                  AfterConfirm0A2( ) ;
                  if ( AnyError == 0 )
                  {
                     BeforeUpdate0A2( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Using cursor T000A18 */
                        pr_default.execute(16, new Object[] {A8AttractionName, A51SupplierAttractionDate, A7AttractionId});
                        pr_default.close(16);
                        pr_default.SmartCacheProvider.SetUpdated("Attraction");
                        if ( (pr_default.getStatus(16) == 103) )
                        {
                           GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Attraction"}), "RecordIsLocked", 1, "");
                           AnyError = 1;
                        }
                        DeferredUpdate0A2( ) ;
                        if ( AnyError == 0 )
                        {
                           /* Start of After( update) rules */
                           /* End of After( update) rules */
                           if ( AnyError == 0 )
                           {
                              getByPrimaryKey0A2( ) ;
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
               EndLevel0A2( ) ;
            }
         }
         CloseExtendedTableCursors0A2( ) ;
      }

      protected void DeferredUpdate0A2( )
      {
         if ( AnyError == 0 )
         {
            /* Using cursor T000A19 */
            pr_default.execute(17, new Object[] {A13AttractionPhoto, A40000AttractionPhoto_GXI, A7AttractionId});
            pr_default.close(17);
            pr_default.SmartCacheProvider.SetUpdated("Attraction");
         }
      }

      protected void Delete0A2( )
      {
         Gx_mode = "DLT";
         AssignAttri("", false, "Gx_mode", Gx_mode);
         BeforeValidate0A2( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0A2( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls0A2( ) ;
            AfterConfirm0A2( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete0A2( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T000A20 */
                  pr_default.execute(18, new Object[] {A7AttractionId});
                  pr_default.close(18);
                  pr_default.SmartCacheProvider.SetUpdated("Attraction");
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
         sMode2 = Gx_mode;
         Gx_mode = "DLT";
         AssignAttri("", false, "Gx_mode", Gx_mode);
         EndLevel0A2( ) ;
         Gx_mode = sMode2;
         AssignAttri("", false, "Gx_mode", Gx_mode);
      }

      protected void OnDeleteControls0A2( )
      {
         standaloneModal0A2( ) ;
         /* No delete mode formulas found. */
      }

      protected void EndLevel0A2( )
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

      public void ScanStart0A2( )
      {
         /* Scan By routine */
         /* Using cursor T000A21 */
         pr_default.execute(19);
         RcdFound2 = 0;
         if ( (pr_default.getStatus(19) != 101) )
         {
            RcdFound2 = 1;
            A7AttractionId = T000A21_A7AttractionId[0];
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext0A2( )
      {
         /* Scan next routine */
         pr_default.readNext(19);
         RcdFound2 = 0;
         if ( (pr_default.getStatus(19) != 101) )
         {
            RcdFound2 = 1;
            A7AttractionId = T000A21_A7AttractionId[0];
         }
      }

      protected void ScanEnd0A2( )
      {
         pr_default.close(19);
      }

      protected void AfterConfirm0A2( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert0A2( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate0A2( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete0A2( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete0A2( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate0A2( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes0A2( )
      {
         edtAttractionId_Enabled = 0;
         AssignProp("", false, edtAttractionId_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtAttractionId_Enabled), 5, 0), !bGXsfl_53_Refreshing);
         edtAttractionName_Enabled = 0;
         AssignProp("", false, edtAttractionName_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtAttractionName_Enabled), 5, 0), !bGXsfl_53_Refreshing);
         edtAttractionPhoto_Enabled = 0;
         AssignProp("", false, edtAttractionPhoto_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtAttractionPhoto_Enabled), 5, 0), !bGXsfl_53_Refreshing);
         edtSupplierAttractionDate_Enabled = 0;
         AssignProp("", false, edtSupplierAttractionDate_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtSupplierAttractionDate_Enabled), 5, 0), !bGXsfl_53_Refreshing);
      }

      protected void send_integrity_lvl_hashes0A2( )
      {
      }

      protected void send_integrity_lvl_hashes0A13( )
      {
      }

      protected void SubsflControlProps_532( )
      {
         edtAttractionId_Internalname = "ATTRACTIONID_"+sGXsfl_53_idx;
         edtAttractionName_Internalname = "ATTRACTIONNAME_"+sGXsfl_53_idx;
         edtAttractionPhoto_Internalname = "ATTRACTIONPHOTO_"+sGXsfl_53_idx;
         edtSupplierAttractionDate_Internalname = "SUPPLIERATTRACTIONDATE_"+sGXsfl_53_idx;
      }

      protected void SubsflControlProps_fel_532( )
      {
         edtAttractionId_Internalname = "ATTRACTIONID_"+sGXsfl_53_fel_idx;
         edtAttractionName_Internalname = "ATTRACTIONNAME_"+sGXsfl_53_fel_idx;
         edtAttractionPhoto_Internalname = "ATTRACTIONPHOTO_"+sGXsfl_53_fel_idx;
         edtSupplierAttractionDate_Internalname = "SUPPLIERATTRACTIONDATE_"+sGXsfl_53_fel_idx;
      }

      protected void AddRow0A2( )
      {
         nGXsfl_53_idx = (int)(nGXsfl_53_idx+1);
         sGXsfl_53_idx = StringUtil.PadL( StringUtil.LTrimStr( (decimal)(nGXsfl_53_idx), 4, 0), 4, "0");
         SubsflControlProps_532( ) ;
         SendRow0A2( ) ;
      }

      protected void SendRow0A2( )
      {
         Gridsupplier_attractionRow = GXWebRow.GetNew(context);
         if ( subGridsupplier_attraction_Backcolorstyle == 0 )
         {
            /* None style subfile background logic. */
            subGridsupplier_attraction_Backstyle = 0;
            if ( StringUtil.StrCmp(subGridsupplier_attraction_Class, "") != 0 )
            {
               subGridsupplier_attraction_Linesclass = subGridsupplier_attraction_Class+"Odd";
            }
         }
         else if ( subGridsupplier_attraction_Backcolorstyle == 1 )
         {
            /* Uniform style subfile background logic. */
            subGridsupplier_attraction_Backstyle = 0;
            subGridsupplier_attraction_Backcolor = subGridsupplier_attraction_Allbackcolor;
            if ( StringUtil.StrCmp(subGridsupplier_attraction_Class, "") != 0 )
            {
               subGridsupplier_attraction_Linesclass = subGridsupplier_attraction_Class+"Uniform";
            }
         }
         else if ( subGridsupplier_attraction_Backcolorstyle == 2 )
         {
            /* Header style subfile background logic. */
            subGridsupplier_attraction_Backstyle = 1;
            if ( StringUtil.StrCmp(subGridsupplier_attraction_Class, "") != 0 )
            {
               subGridsupplier_attraction_Linesclass = subGridsupplier_attraction_Class+"Odd";
            }
            subGridsupplier_attraction_Backcolor = (int)(0x0);
         }
         else if ( subGridsupplier_attraction_Backcolorstyle == 3 )
         {
            /* Report style subfile background logic. */
            subGridsupplier_attraction_Backstyle = 1;
            if ( ((int)((nGXsfl_53_idx) % (2))) == 0 )
            {
               subGridsupplier_attraction_Backcolor = (int)(0x0);
               if ( StringUtil.StrCmp(subGridsupplier_attraction_Class, "") != 0 )
               {
                  subGridsupplier_attraction_Linesclass = subGridsupplier_attraction_Class+"Even";
               }
            }
            else
            {
               subGridsupplier_attraction_Backcolor = (int)(0x0);
               if ( StringUtil.StrCmp(subGridsupplier_attraction_Class, "") != 0 )
               {
                  subGridsupplier_attraction_Linesclass = subGridsupplier_attraction_Class+"Odd";
               }
            }
         }
         /* Subfile cell */
         /* Single line edit */
         TempTags = " data-gxoch1=\"gx.fn.setControlValue('nIsMod_2_" + sGXsfl_53_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 54,'',false,'" + sGXsfl_53_idx + "',53)\"";
         ROClassString = "Attribute";
         Gridsupplier_attractionRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(string)edtAttractionId_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A7AttractionId), 4, 0, ".", "")),StringUtil.LTrim( context.localUtil.Format( (decimal)(A7AttractionId), "ZZZ9"))," dir=\"ltr\" inputmode=\"numeric\" pattern=\"[0-9]*\""+TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(this,54);\"",(string)"'"+""+"'"+",false,"+"'"+""+"'",(string)"",(string)"",(string)"",(string)"",(string)edtAttractionId_Jsonclick,(short)0,(string)"Attribute",(string)"",(string)ROClassString,(string)"",(string)"",(short)-1,(int)edtAttractionId_Enabled,(short)1,(string)"text",(string)"1",(short)0,(string)"px",(short)17,(string)"px",(short)4,(short)0,(short)0,(short)53,(short)0,(short)-1,(short)0,(bool)true,(string)"Id",(string)"end",(bool)false,(string)""});
         /* Subfile cell */
         /* Single line edit */
         TempTags = " data-gxoch1=\"gx.fn.setControlValue('nIsMod_2_" + sGXsfl_53_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 55,'',false,'" + sGXsfl_53_idx + "',53)\"";
         ROClassString = "Attribute";
         Gridsupplier_attractionRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(string)edtAttractionName_Internalname,(string)A8AttractionName,(string)"",TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,55);\"",(string)"'"+""+"'"+",false,"+"'"+""+"'",(string)"",(string)"",(string)"",(string)"",(string)edtAttractionName_Jsonclick,(short)0,(string)"Attribute",(string)"",(string)ROClassString,(string)"",(string)"",(short)-1,(int)edtAttractionName_Enabled,(short)0,(string)"text",(string)"",(short)0,(string)"px",(short)17,(string)"px",(short)40,(short)0,(short)0,(short)53,(short)0,(short)-1,(short)-1,(bool)true,(string)"Name",(string)"start",(bool)true,(string)""});
         /* Subfile cell */
         /* Static Bitmap Variable */
         TempTags = " data-gxoch1=\"gx.fn.setControlValue('nIsMod_2_" + sGXsfl_53_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 56,'',false,'" + sGXsfl_53_idx + "',53)\"";
         ClassString = "ImageAttribute";
         StyleString = "";
         A13AttractionPhoto_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( A13AttractionPhoto))&&String.IsNullOrEmpty(StringUtil.RTrim( A40000AttractionPhoto_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( A13AttractionPhoto)));
         sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( A13AttractionPhoto)) ? A40000AttractionPhoto_GXI : context.PathToRelativeUrl( A13AttractionPhoto));
         Gridsupplier_attractionRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(string)edtAttractionPhoto_Internalname,(string)sImgUrl,(string)"",(string)"",(string)"",context.GetTheme( ),(short)-1,(int)edtAttractionPhoto_Enabled,(string)"",(string)"",(short)0,(short)-1,(short)0,(string)"px",(short)0,(string)"px",(short)0,(short)0,(short)0,(string)"",(string)"",(string)StyleString,(string)ClassString,(string)"",(string)"",(string)"",TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,56);\"",(string)"",(string)"",(string)"",(short)0,(bool)A13AttractionPhoto_IsBlob,(bool)true,context.GetImageSrcSet( sImgUrl)});
         AssignProp("", false, edtAttractionPhoto_Internalname, "URL", (String.IsNullOrEmpty(StringUtil.RTrim( A13AttractionPhoto)) ? A40000AttractionPhoto_GXI : context.PathToRelativeUrl( A13AttractionPhoto)), !bGXsfl_53_Refreshing);
         AssignProp("", false, edtAttractionPhoto_Internalname, "IsBlob", StringUtil.BoolToStr( A13AttractionPhoto_IsBlob), !bGXsfl_53_Refreshing);
         /* Subfile cell */
         /* Single line edit */
         TempTags = " data-gxoch1=\"gx.fn.setControlValue('nIsMod_2_" + sGXsfl_53_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 57,'',false,'" + sGXsfl_53_idx + "',53)\"";
         ROClassString = "Attribute";
         Gridsupplier_attractionRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(string)edtSupplierAttractionDate_Internalname,context.localUtil.Format(A51SupplierAttractionDate, "99/99/99"),context.localUtil.Format( A51SupplierAttractionDate, "99/99/99"),TempTags+" onchange=\""+"gx.date.valid_date(this, 8,'MDY',0,12,'eng',false,0);"+";gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.date.valid_date(this, 8,'MDY',0,12,'eng',false,0);"+";gx.evt.onblur(this,57);\"",(string)"'"+""+"'"+",false,"+"'"+""+"'",(string)"",(string)"",(string)"",(string)"",(string)edtSupplierAttractionDate_Jsonclick,(short)0,(string)"Attribute",(string)"",(string)ROClassString,(string)"",(string)"",(short)-1,(int)edtSupplierAttractionDate_Enabled,(short)0,(string)"text",(string)"",(short)0,(string)"px",(short)17,(string)"px",(short)8,(short)0,(short)0,(short)53,(short)0,(short)-1,(short)0,(bool)true,(string)"",(string)"end",(bool)false,(string)""});
         ajax_sending_grid_row(Gridsupplier_attractionRow);
         send_integrity_lvl_hashes0A2( ) ;
         GXCCtl = "Z7AttractionId_" + sGXsfl_53_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z7AttractionId), 4, 0, ".", "")));
         GXCCtl = "Z8AttractionName_" + sGXsfl_53_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, Z8AttractionName);
         GXCCtl = "Z51SupplierAttractionDate_" + sGXsfl_53_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, context.localUtil.DToC( Z51SupplierAttractionDate, 0, "/"));
         GXCCtl = "nRcdDeleted_2_" + sGXsfl_53_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_2), 4, 0, ".", "")));
         GXCCtl = "nRcdExists_2_" + sGXsfl_53_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdExists_2), 4, 0, ".", "")));
         GXCCtl = "nIsMod_2_" + sGXsfl_53_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nIsMod_2), 4, 0, ".", "")));
         GXCCtl = "ATTRACTIONPHOTO_" + sGXsfl_53_idx;
         GXCCtlgxBlob = GXCCtl + "_gxBlob";
         GxWebStd.gx_hidden_field( context, GXCCtlgxBlob, A13AttractionPhoto);
         GxWebStd.gx_hidden_field( context, "ATTRACTIONID_"+sGXsfl_53_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtAttractionId_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "ATTRACTIONNAME_"+sGXsfl_53_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtAttractionName_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "ATTRACTIONPHOTO_"+sGXsfl_53_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtAttractionPhoto_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "SUPPLIERATTRACTIONDATE_"+sGXsfl_53_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtSupplierAttractionDate_Enabled), 5, 0, ".", "")));
         ajax_sending_grid_row(null);
         Gridsupplier_attractionContainer.AddRow(Gridsupplier_attractionRow);
      }

      protected void ReadRow0A2( )
      {
         nGXsfl_53_idx = (int)(nGXsfl_53_idx+1);
         sGXsfl_53_idx = StringUtil.PadL( StringUtil.LTrimStr( (decimal)(nGXsfl_53_idx), 4, 0), 4, "0");
         SubsflControlProps_532( ) ;
         edtAttractionId_Enabled = (int)(Math.Round(context.localUtil.CToN( cgiGet( "ATTRACTIONID_"+sGXsfl_53_idx+"Enabled"), ".", ","), 18, MidpointRounding.ToEven));
         edtAttractionName_Enabled = (int)(Math.Round(context.localUtil.CToN( cgiGet( "ATTRACTIONNAME_"+sGXsfl_53_idx+"Enabled"), ".", ","), 18, MidpointRounding.ToEven));
         edtAttractionPhoto_Enabled = (int)(Math.Round(context.localUtil.CToN( cgiGet( "ATTRACTIONPHOTO_"+sGXsfl_53_idx+"Enabled"), ".", ","), 18, MidpointRounding.ToEven));
         edtSupplierAttractionDate_Enabled = (int)(Math.Round(context.localUtil.CToN( cgiGet( "SUPPLIERATTRACTIONDATE_"+sGXsfl_53_idx+"Enabled"), ".", ","), 18, MidpointRounding.ToEven));
         if ( ( ( context.localUtil.CToN( cgiGet( edtAttractionId_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtAttractionId_Internalname), ".", ",") > Convert.ToDecimal( 9999 )) ) )
         {
            GXCCtl = "ATTRACTIONID_" + sGXsfl_53_idx;
            GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, GXCCtl);
            AnyError = 1;
            GX_FocusControl = edtAttractionId_Internalname;
            wbErr = true;
            A7AttractionId = 0;
         }
         else
         {
            A7AttractionId = (short)(Math.Round(context.localUtil.CToN( cgiGet( edtAttractionId_Internalname), ".", ","), 18, MidpointRounding.ToEven));
         }
         A8AttractionName = cgiGet( edtAttractionName_Internalname);
         A13AttractionPhoto = cgiGet( edtAttractionPhoto_Internalname);
         if ( context.localUtil.VCDate( cgiGet( edtSupplierAttractionDate_Internalname), 1) == 0 )
         {
            GXCCtl = "SUPPLIERATTRACTIONDATE_" + sGXsfl_53_idx;
            GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"Supplier Attraction Date"}), 1, GXCCtl);
            AnyError = 1;
            GX_FocusControl = edtSupplierAttractionDate_Internalname;
            wbErr = true;
            A51SupplierAttractionDate = DateTime.MinValue;
         }
         else
         {
            A51SupplierAttractionDate = context.localUtil.CToD( cgiGet( edtSupplierAttractionDate_Internalname), 1);
         }
         GXCCtl = "Z7AttractionId_" + sGXsfl_53_idx;
         Z7AttractionId = (short)(Math.Round(context.localUtil.CToN( cgiGet( GXCCtl), ".", ","), 18, MidpointRounding.ToEven));
         GXCCtl = "Z8AttractionName_" + sGXsfl_53_idx;
         Z8AttractionName = cgiGet( GXCCtl);
         GXCCtl = "Z51SupplierAttractionDate_" + sGXsfl_53_idx;
         Z51SupplierAttractionDate = context.localUtil.CToD( cgiGet( GXCCtl), 0);
         GXCCtl = "nRcdDeleted_2_" + sGXsfl_53_idx;
         nRcdDeleted_2 = (short)(Math.Round(context.localUtil.CToN( cgiGet( GXCCtl), ".", ","), 18, MidpointRounding.ToEven));
         GXCCtl = "nRcdExists_2_" + sGXsfl_53_idx;
         nRcdExists_2 = (short)(Math.Round(context.localUtil.CToN( cgiGet( GXCCtl), ".", ","), 18, MidpointRounding.ToEven));
         GXCCtl = "nIsMod_2_" + sGXsfl_53_idx;
         nIsMod_2 = (short)(Math.Round(context.localUtil.CToN( cgiGet( GXCCtl), ".", ","), 18, MidpointRounding.ToEven));
         getMultimediaValue(edtAttractionPhoto_Internalname, ref  A13AttractionPhoto, ref  A40000AttractionPhoto_GXI);
      }

      protected void assign_properties_default( )
      {
         defedtAttractionId_Enabled = edtAttractionId_Enabled;
      }

      protected void ConfirmValues0A0( )
      {
         nGXsfl_53_idx = 0;
         sGXsfl_53_idx = StringUtil.PadL( StringUtil.LTrimStr( (decimal)(nGXsfl_53_idx), 4, 0), 4, "0");
         SubsflControlProps_532( ) ;
         while ( nGXsfl_53_idx < nRC_GXsfl_53 )
         {
            nGXsfl_53_idx = (int)(nGXsfl_53_idx+1);
            sGXsfl_53_idx = StringUtil.PadL( StringUtil.LTrimStr( (decimal)(nGXsfl_53_idx), 4, 0), 4, "0");
            SubsflControlProps_532( ) ;
            ChangePostValue( "Z7AttractionId_"+sGXsfl_53_idx, cgiGet( "ZT_"+"Z7AttractionId_"+sGXsfl_53_idx)) ;
            DeletePostValue( "ZT_"+"Z7AttractionId_"+sGXsfl_53_idx) ;
            ChangePostValue( "Z8AttractionName_"+sGXsfl_53_idx, cgiGet( "ZT_"+"Z8AttractionName_"+sGXsfl_53_idx)) ;
            DeletePostValue( "ZT_"+"Z8AttractionName_"+sGXsfl_53_idx) ;
            ChangePostValue( "Z51SupplierAttractionDate_"+sGXsfl_53_idx, cgiGet( "ZT_"+"Z51SupplierAttractionDate_"+sGXsfl_53_idx)) ;
            DeletePostValue( "ZT_"+"Z51SupplierAttractionDate_"+sGXsfl_53_idx) ;
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
         context.AddJavascriptSource("calendar.js", "?"+context.GetBuildNumber( 1910300), false, true);
         context.AddJavascriptSource("calendar-setup.js", "?"+context.GetBuildNumber( 1910300), false, true);
         context.AddJavascriptSource("calendar-en.js", "?"+context.GetBuildNumber( 1910300), false, true);
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("supplier.aspx") +"\">") ;
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
         GxWebStd.gx_hidden_field( context, "Z48SupplierId", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z48SupplierId), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z49SupplierName", Z49SupplierName);
         GxWebStd.gx_hidden_field( context, "Z50SupplierAddress", Z50SupplierAddress);
         GxWebStd.gx_hidden_field( context, "IsConfirmed", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsConfirmed), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "IsModified", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsModified), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Mode", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "nRC_GXsfl_53", StringUtil.LTrim( StringUtil.NToC( (decimal)(nGXsfl_53_idx), 8, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "ATTRACTIONPHOTO_GXI", A40000AttractionPhoto_GXI);
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
         return formatLink("supplier.aspx")  ;
      }

      public override string GetPgmname( )
      {
         return "Supplier" ;
      }

      public override string GetPgmdesc( )
      {
         return "Supplier" ;
      }

      protected void InitializeNonKey0A13( )
      {
         A49SupplierName = "";
         AssignAttri("", false, "A49SupplierName", A49SupplierName);
         A50SupplierAddress = "";
         AssignAttri("", false, "A50SupplierAddress", A50SupplierAddress);
         Z49SupplierName = "";
         Z50SupplierAddress = "";
      }

      protected void InitAll0A13( )
      {
         A48SupplierId = 0;
         AssignAttri("", false, "A48SupplierId", StringUtil.LTrimStr( (decimal)(A48SupplierId), 4, 0));
         InitializeNonKey0A13( ) ;
      }

      protected void StandaloneModalInsert( )
      {
      }

      protected void InitializeNonKey0A2( )
      {
         A8AttractionName = "";
         A13AttractionPhoto = "";
         AssignProp("", false, edtAttractionPhoto_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A13AttractionPhoto)) ? A40000AttractionPhoto_GXI : context.convertURL( context.PathToRelativeUrl( A13AttractionPhoto))), !bGXsfl_53_Refreshing);
         AssignProp("", false, edtAttractionPhoto_Internalname, "SrcSet", context.GetImageSrcSet( A13AttractionPhoto), true);
         A40000AttractionPhoto_GXI = "";
         AssignProp("", false, edtAttractionPhoto_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A13AttractionPhoto)) ? A40000AttractionPhoto_GXI : context.convertURL( context.PathToRelativeUrl( A13AttractionPhoto))), !bGXsfl_53_Refreshing);
         AssignProp("", false, edtAttractionPhoto_Internalname, "SrcSet", context.GetImageSrcSet( A13AttractionPhoto), true);
         A51SupplierAttractionDate = DateTime.MinValue;
         Z8AttractionName = "";
         Z51SupplierAttractionDate = DateTime.MinValue;
      }

      protected void InitAll0A2( )
      {
         A7AttractionId = 0;
         InitializeNonKey0A2( ) ;
      }

      protected void StandaloneModalInsert0A2( )
      {
      }

      protected void define_styles( )
      {
         AddStyleSheetFile("calendar-system.css", "");
         AddThemeStyleSheetFile("", context.GetTheme( )+".css", "?"+GetCacheInvalidationToken( ));
         bool outputEnabled = isOutputEnabled( );
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         idxLst = 1;
         while ( idxLst <= Form.Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( ((string)Form.Jscriptsrc.Item(idxLst))), "?202392115131875", true, true);
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
         context.AddJavascriptSource("supplier.js", "?202392115131875", false, true);
         /* End function include_jscripts */
      }

      protected void init_level_properties2( )
      {
         edtAttractionId_Enabled = defedtAttractionId_Enabled;
         AssignProp("", false, edtAttractionId_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtAttractionId_Enabled), 5, 0), !bGXsfl_53_Refreshing);
      }

      protected void StartGridControl53( )
      {
         Gridsupplier_attractionContainer.AddObjectProperty("GridName", "Gridsupplier_attraction");
         Gridsupplier_attractionContainer.AddObjectProperty("Header", subGridsupplier_attraction_Header);
         Gridsupplier_attractionContainer.AddObjectProperty("Class", "Grid");
         Gridsupplier_attractionContainer.AddObjectProperty("Cellpadding", StringUtil.LTrim( StringUtil.NToC( (decimal)(1), 4, 0, ".", "")));
         Gridsupplier_attractionContainer.AddObjectProperty("Cellspacing", StringUtil.LTrim( StringUtil.NToC( (decimal)(2), 4, 0, ".", "")));
         Gridsupplier_attractionContainer.AddObjectProperty("Backcolorstyle", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridsupplier_attraction_Backcolorstyle), 1, 0, ".", "")));
         Gridsupplier_attractionContainer.AddObjectProperty("CmpContext", "");
         Gridsupplier_attractionContainer.AddObjectProperty("InMasterPage", "false");
         Gridsupplier_attractionColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
         Gridsupplier_attractionColumn.AddObjectProperty("Value", GXUtil.ValueEncode( StringUtil.LTrim( StringUtil.NToC( (decimal)(A7AttractionId), 4, 0, ".", ""))));
         Gridsupplier_attractionColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtAttractionId_Enabled), 5, 0, ".", "")));
         Gridsupplier_attractionContainer.AddColumnProperties(Gridsupplier_attractionColumn);
         Gridsupplier_attractionColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
         Gridsupplier_attractionColumn.AddObjectProperty("Value", GXUtil.ValueEncode( A8AttractionName));
         Gridsupplier_attractionColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtAttractionName_Enabled), 5, 0, ".", "")));
         Gridsupplier_attractionContainer.AddColumnProperties(Gridsupplier_attractionColumn);
         Gridsupplier_attractionColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
         Gridsupplier_attractionColumn.AddObjectProperty("Value", context.convertURL( A13AttractionPhoto));
         Gridsupplier_attractionColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtAttractionPhoto_Enabled), 5, 0, ".", "")));
         Gridsupplier_attractionContainer.AddColumnProperties(Gridsupplier_attractionColumn);
         Gridsupplier_attractionColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
         Gridsupplier_attractionColumn.AddObjectProperty("Value", GXUtil.ValueEncode( context.localUtil.Format(A51SupplierAttractionDate, "99/99/99")));
         Gridsupplier_attractionColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtSupplierAttractionDate_Enabled), 5, 0, ".", "")));
         Gridsupplier_attractionContainer.AddColumnProperties(Gridsupplier_attractionColumn);
         Gridsupplier_attractionContainer.AddObjectProperty("Selectedindex", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridsupplier_attraction_Selectedindex), 4, 0, ".", "")));
         Gridsupplier_attractionContainer.AddObjectProperty("Allowselection", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridsupplier_attraction_Allowselection), 1, 0, ".", "")));
         Gridsupplier_attractionContainer.AddObjectProperty("Selectioncolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridsupplier_attraction_Selectioncolor), 9, 0, ".", "")));
         Gridsupplier_attractionContainer.AddObjectProperty("Allowhover", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridsupplier_attraction_Allowhovering), 1, 0, ".", "")));
         Gridsupplier_attractionContainer.AddObjectProperty("Hovercolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridsupplier_attraction_Hoveringcolor), 9, 0, ".", "")));
         Gridsupplier_attractionContainer.AddObjectProperty("Allowcollapsing", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridsupplier_attraction_Allowcollapsing), 1, 0, ".", "")));
         Gridsupplier_attractionContainer.AddObjectProperty("Collapsed", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridsupplier_attraction_Collapsed), 1, 0, ".", "")));
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
         edtSupplierId_Internalname = "SUPPLIERID";
         edtSupplierName_Internalname = "SUPPLIERNAME";
         edtSupplierAddress_Internalname = "SUPPLIERADDRESS";
         lblTitleattraction_Internalname = "TITLEATTRACTION";
         edtAttractionId_Internalname = "ATTRACTIONID";
         edtAttractionName_Internalname = "ATTRACTIONNAME";
         edtAttractionPhoto_Internalname = "ATTRACTIONPHOTO";
         edtSupplierAttractionDate_Internalname = "SUPPLIERATTRACTIONDATE";
         divAttractiontable_Internalname = "ATTRACTIONTABLE";
         divFormcontainer_Internalname = "FORMCONTAINER";
         bttBtn_enter_Internalname = "BTN_ENTER";
         bttBtn_cancel_Internalname = "BTN_CANCEL";
         bttBtn_delete_Internalname = "BTN_DELETE";
         divMaintable_Internalname = "MAINTABLE";
         Form.Internalname = "FORM";
         subGridsupplier_attraction_Internalname = "GRIDSUPPLIER_ATTRACTION";
      }

      public override void initialize_properties( )
      {
         context.SetDefaultTheme("TravelAgency_Capa202309", true);
         if ( context.isSpaRequest( ) )
         {
            disableJsOutput();
         }
         init_default_properties( ) ;
         subGridsupplier_attraction_Allowcollapsing = 0;
         subGridsupplier_attraction_Allowselection = 0;
         subGridsupplier_attraction_Header = "";
         Form.Headerrawhtml = "";
         Form.Background = "";
         Form.Textcolor = 0;
         Form.Backcolor = (int)(0xFFFFFF);
         Form.Caption = "Supplier";
         edtSupplierAttractionDate_Jsonclick = "";
         edtAttractionName_Jsonclick = "";
         edtAttractionId_Jsonclick = "";
         subGridsupplier_attraction_Class = "Grid";
         subGridsupplier_attraction_Backcolorstyle = 0;
         edtSupplierAttractionDate_Enabled = 1;
         edtAttractionPhoto_Enabled = 1;
         edtAttractionName_Enabled = 1;
         edtAttractionId_Enabled = 1;
         bttBtn_delete_Enabled = 1;
         bttBtn_delete_Visible = 1;
         bttBtn_cancel_Visible = 1;
         bttBtn_enter_Enabled = 1;
         bttBtn_enter_Visible = 1;
         edtSupplierAddress_Enabled = 1;
         edtSupplierName_Jsonclick = "";
         edtSupplierName_Enabled = 1;
         edtSupplierId_Jsonclick = "";
         edtSupplierId_Enabled = 1;
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

      protected void gxnrGridsupplier_attraction_newrow( )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         Gx_mode = "INS";
         AssignAttri("", false, "Gx_mode", Gx_mode);
         SubsflControlProps_532( ) ;
         while ( nGXsfl_53_idx <= nRC_GXsfl_53 )
         {
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            standaloneNotModal0A2( ) ;
            standaloneModal0A2( ) ;
            init_web_controls( ) ;
            dynload_actions( ) ;
            SendRow0A2( ) ;
            nGXsfl_53_idx = (int)(nGXsfl_53_idx+1);
            sGXsfl_53_idx = StringUtil.PadL( StringUtil.LTrimStr( (decimal)(nGXsfl_53_idx), 4, 0), 4, "0");
            SubsflControlProps_532( ) ;
         }
         AddString( context.httpAjaxContext.getJSONContainerResponse( Gridsupplier_attractionContainer)) ;
         /* End function gxnrGridsupplier_attraction_newrow */
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
         GX_FocusControl = edtSupplierName_Internalname;
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

      public void Valid_Supplierid( )
      {
         context.wbHandled = 1;
         AfterKeyLoadScreen( ) ;
         Draw( ) ;
         send_integrity_footer_hashes( ) ;
         dynload_actions( ) ;
         /*  Sending validation outputs */
         AssignAttri("", false, "A49SupplierName", A49SupplierName);
         AssignAttri("", false, "A50SupplierAddress", A50SupplierAddress);
         AssignAttri("", false, "Gx_mode", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "Z48SupplierId", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z48SupplierId), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z49SupplierName", Z49SupplierName);
         GxWebStd.gx_hidden_field( context, "Z50SupplierAddress", Z50SupplierAddress);
         AssignProp("", false, bttBtn_delete_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(bttBtn_delete_Enabled), 5, 0), true);
         AssignProp("", false, bttBtn_enter_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(bttBtn_enter_Enabled), 5, 0), true);
         SendCloseFormHiddens( ) ;
      }

      public void Valid_Attractionname( )
      {
         /* Using cursor T000A22 */
         pr_default.execute(20, new Object[] {A8AttractionName, A7AttractionId});
         if ( (pr_default.getStatus(20) != 101) )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_1004", new   object[]  {"Attraction Name"}), 1, "ATTRACTIONNAME");
            AnyError = 1;
            GX_FocusControl = edtAttractionName_Internalname;
         }
         pr_default.close(20);
         dynload_actions( ) ;
         /*  Sending validation outputs */
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
         setEventMetadata("VALID_SUPPLIERID","{handler:'Valid_Supplierid',iparms:[{av:'A48SupplierId',fld:'SUPPLIERID',pic:'ZZZ9'},{av:'Gx_mode',fld:'vMODE',pic:'@!'}]");
         setEventMetadata("VALID_SUPPLIERID",",oparms:[{av:'A49SupplierName',fld:'SUPPLIERNAME',pic:''},{av:'A50SupplierAddress',fld:'SUPPLIERADDRESS',pic:''},{av:'Gx_mode',fld:'vMODE',pic:'@!'},{av:'Z48SupplierId'},{av:'Z49SupplierName'},{av:'Z50SupplierAddress'},{ctrl:'BTN_DELETE',prop:'Enabled'},{ctrl:'BTN_ENTER',prop:'Enabled'}]}");
         setEventMetadata("VALID_ATTRACTIONID","{handler:'Valid_Attractionid',iparms:[]");
         setEventMetadata("VALID_ATTRACTIONID",",oparms:[]}");
         setEventMetadata("VALID_ATTRACTIONNAME","{handler:'Valid_Attractionname',iparms:[{av:'A8AttractionName',fld:'ATTRACTIONNAME',pic:''},{av:'A7AttractionId',fld:'ATTRACTIONID',pic:'ZZZ9'}]");
         setEventMetadata("VALID_ATTRACTIONNAME",",oparms:[]}");
         setEventMetadata("VALID_SUPPLIERATTRACTIONDATE","{handler:'Valid_Supplierattractiondate',iparms:[]");
         setEventMetadata("VALID_SUPPLIERATTRACTIONDATE",",oparms:[]}");
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
         pr_default.close(3);
      }

      public override void initialize( )
      {
         sPrefix = "";
         Z49SupplierName = "";
         Z50SupplierAddress = "";
         Z8AttractionName = "";
         Z51SupplierAttractionDate = DateTime.MinValue;
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
         A49SupplierName = "";
         A50SupplierAddress = "";
         lblTitleattraction_Jsonclick = "";
         bttBtn_enter_Jsonclick = "";
         bttBtn_cancel_Jsonclick = "";
         bttBtn_delete_Jsonclick = "";
         Gridsupplier_attractionContainer = new GXWebGrid( context);
         sMode2 = "";
         sStyleString = "";
         A40000AttractionPhoto_GXI = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         endTrnMsgTxt = "";
         endTrnMsgCod = "";
         GXCCtl = "";
         A8AttractionName = "";
         A13AttractionPhoto = "";
         A51SupplierAttractionDate = DateTime.MinValue;
         T000A6_A48SupplierId = new short[1] ;
         T000A6_A49SupplierName = new string[] {""} ;
         T000A6_A50SupplierAddress = new string[] {""} ;
         T000A7_A48SupplierId = new short[1] ;
         T000A5_A48SupplierId = new short[1] ;
         T000A5_A49SupplierName = new string[] {""} ;
         T000A5_A50SupplierAddress = new string[] {""} ;
         sMode13 = "";
         T000A8_A48SupplierId = new short[1] ;
         T000A9_A48SupplierId = new short[1] ;
         T000A4_A48SupplierId = new short[1] ;
         T000A4_A49SupplierName = new string[] {""} ;
         T000A4_A50SupplierAddress = new string[] {""} ;
         T000A10_A48SupplierId = new short[1] ;
         T000A13_A48SupplierId = new short[1] ;
         Z13AttractionPhoto = "";
         Z40000AttractionPhoto_GXI = "";
         T000A14_A7AttractionId = new short[1] ;
         T000A14_A8AttractionName = new string[] {""} ;
         T000A14_A40000AttractionPhoto_GXI = new string[] {""} ;
         T000A14_A51SupplierAttractionDate = new DateTime[] {DateTime.MinValue} ;
         T000A14_A13AttractionPhoto = new string[] {""} ;
         T000A15_A8AttractionName = new string[] {""} ;
         T000A16_A7AttractionId = new short[1] ;
         T000A3_A7AttractionId = new short[1] ;
         T000A3_A8AttractionName = new string[] {""} ;
         T000A3_A40000AttractionPhoto_GXI = new string[] {""} ;
         T000A3_A51SupplierAttractionDate = new DateTime[] {DateTime.MinValue} ;
         T000A3_A13AttractionPhoto = new string[] {""} ;
         T000A2_A7AttractionId = new short[1] ;
         T000A2_A8AttractionName = new string[] {""} ;
         T000A2_A40000AttractionPhoto_GXI = new string[] {""} ;
         T000A2_A51SupplierAttractionDate = new DateTime[] {DateTime.MinValue} ;
         T000A2_A13AttractionPhoto = new string[] {""} ;
         T000A17_A7AttractionId = new short[1] ;
         T000A21_A7AttractionId = new short[1] ;
         Gridsupplier_attractionRow = new GXWebRow();
         subGridsupplier_attraction_Linesclass = "";
         ROClassString = "";
         sImgUrl = "";
         GXCCtlgxBlob = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         Gridsupplier_attractionColumn = new GXWebColumn();
         ZZ49SupplierName = "";
         ZZ50SupplierAddress = "";
         T000A22_A8AttractionName = new string[] {""} ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.supplier__default(),
            new Object[][] {
                new Object[] {
               T000A2_A7AttractionId, T000A2_A8AttractionName, T000A2_A40000AttractionPhoto_GXI, T000A2_A51SupplierAttractionDate, T000A2_A13AttractionPhoto
               }
               , new Object[] {
               T000A3_A7AttractionId, T000A3_A8AttractionName, T000A3_A40000AttractionPhoto_GXI, T000A3_A51SupplierAttractionDate, T000A3_A13AttractionPhoto
               }
               , new Object[] {
               T000A4_A48SupplierId, T000A4_A49SupplierName, T000A4_A50SupplierAddress
               }
               , new Object[] {
               T000A5_A48SupplierId, T000A5_A49SupplierName, T000A5_A50SupplierAddress
               }
               , new Object[] {
               T000A6_A48SupplierId, T000A6_A49SupplierName, T000A6_A50SupplierAddress
               }
               , new Object[] {
               T000A7_A48SupplierId
               }
               , new Object[] {
               T000A8_A48SupplierId
               }
               , new Object[] {
               T000A9_A48SupplierId
               }
               , new Object[] {
               T000A10_A48SupplierId
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000A13_A48SupplierId
               }
               , new Object[] {
               T000A14_A7AttractionId, T000A14_A8AttractionName, T000A14_A40000AttractionPhoto_GXI, T000A14_A51SupplierAttractionDate, T000A14_A13AttractionPhoto
               }
               , new Object[] {
               T000A15_A8AttractionName
               }
               , new Object[] {
               T000A16_A7AttractionId
               }
               , new Object[] {
               T000A17_A7AttractionId
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000A21_A7AttractionId
               }
               , new Object[] {
               T000A22_A8AttractionName
               }
            }
         );
         Z48SupplierId = 0;
         A48SupplierId = 0;
      }

      private short Z48SupplierId ;
      private short Z7AttractionId ;
      private short nRcdDeleted_2 ;
      private short nRcdExists_2 ;
      private short nIsMod_2 ;
      private short GxWebError ;
      private short gxcookieaux ;
      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short initialized ;
      private short A48SupplierId ;
      private short nBlankRcdCount2 ;
      private short RcdFound2 ;
      private short nBlankRcdUsr2 ;
      private short A7AttractionId ;
      private short GX_JID ;
      private short RcdFound13 ;
      private short nIsDirty_13 ;
      private short Gx_BScreen ;
      private short nIsDirty_2 ;
      private short subGridsupplier_attraction_Backcolorstyle ;
      private short subGridsupplier_attraction_Backstyle ;
      private short gxajaxcallmode ;
      private short subGridsupplier_attraction_Allowselection ;
      private short subGridsupplier_attraction_Allowhovering ;
      private short subGridsupplier_attraction_Allowcollapsing ;
      private short subGridsupplier_attraction_Collapsed ;
      private short ZZ48SupplierId ;
      private int nRC_GXsfl_53 ;
      private int nGXsfl_53_idx=1 ;
      private int trnEnded ;
      private int bttBtn_first_Visible ;
      private int bttBtn_previous_Visible ;
      private int bttBtn_next_Visible ;
      private int bttBtn_last_Visible ;
      private int bttBtn_select_Visible ;
      private int edtSupplierId_Enabled ;
      private int edtSupplierName_Enabled ;
      private int edtSupplierAddress_Enabled ;
      private int bttBtn_enter_Visible ;
      private int bttBtn_enter_Enabled ;
      private int bttBtn_cancel_Visible ;
      private int bttBtn_delete_Visible ;
      private int bttBtn_delete_Enabled ;
      private int edtAttractionId_Enabled ;
      private int edtAttractionName_Enabled ;
      private int edtAttractionPhoto_Enabled ;
      private int edtSupplierAttractionDate_Enabled ;
      private int fRowAdded ;
      private int subGridsupplier_attraction_Backcolor ;
      private int subGridsupplier_attraction_Allbackcolor ;
      private int defedtAttractionId_Enabled ;
      private int idxLst ;
      private int subGridsupplier_attraction_Selectedindex ;
      private int subGridsupplier_attraction_Selectioncolor ;
      private int subGridsupplier_attraction_Hoveringcolor ;
      private long GRIDSUPPLIER_ATTRACTION_nFirstRecordOnPage ;
      private string sPrefix ;
      private string scmdbuf ;
      private string gxfirstwebparm ;
      private string gxfirstwebparm_bkp ;
      private string GXKey ;
      private string PreviousTooltip ;
      private string PreviousCaption ;
      private string GX_FocusControl ;
      private string edtSupplierId_Internalname ;
      private string sGXsfl_53_idx="0001" ;
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
      private string edtSupplierId_Jsonclick ;
      private string edtSupplierName_Internalname ;
      private string edtSupplierName_Jsonclick ;
      private string edtSupplierAddress_Internalname ;
      private string divAttractiontable_Internalname ;
      private string lblTitleattraction_Internalname ;
      private string lblTitleattraction_Jsonclick ;
      private string bttBtn_enter_Internalname ;
      private string bttBtn_enter_Jsonclick ;
      private string bttBtn_cancel_Internalname ;
      private string bttBtn_cancel_Jsonclick ;
      private string bttBtn_delete_Internalname ;
      private string bttBtn_delete_Jsonclick ;
      private string sMode2 ;
      private string edtAttractionId_Internalname ;
      private string edtAttractionName_Internalname ;
      private string edtAttractionPhoto_Internalname ;
      private string edtSupplierAttractionDate_Internalname ;
      private string sStyleString ;
      private string subGridsupplier_attraction_Internalname ;
      private string sEvt ;
      private string EvtGridId ;
      private string EvtRowId ;
      private string sEvtType ;
      private string endTrnMsgTxt ;
      private string endTrnMsgCod ;
      private string GXCCtl ;
      private string sMode13 ;
      private string sGXsfl_53_fel_idx="0001" ;
      private string subGridsupplier_attraction_Class ;
      private string subGridsupplier_attraction_Linesclass ;
      private string ROClassString ;
      private string edtAttractionId_Jsonclick ;
      private string edtAttractionName_Jsonclick ;
      private string sImgUrl ;
      private string edtSupplierAttractionDate_Jsonclick ;
      private string GXCCtlgxBlob ;
      private string sDynURL ;
      private string FormProcess ;
      private string bodyStyle ;
      private string subGridsupplier_attraction_Header ;
      private DateTime Z51SupplierAttractionDate ;
      private DateTime A51SupplierAttractionDate ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool wbErr ;
      private bool bGXsfl_53_Refreshing=false ;
      private bool A13AttractionPhoto_IsBlob ;
      private string Z49SupplierName ;
      private string Z50SupplierAddress ;
      private string Z8AttractionName ;
      private string A49SupplierName ;
      private string A50SupplierAddress ;
      private string A40000AttractionPhoto_GXI ;
      private string A8AttractionName ;
      private string Z40000AttractionPhoto_GXI ;
      private string ZZ49SupplierName ;
      private string ZZ50SupplierAddress ;
      private string A13AttractionPhoto ;
      private string Z13AttractionPhoto ;
      private GXWebGrid Gridsupplier_attractionContainer ;
      private GXWebRow Gridsupplier_attractionRow ;
      private GXWebColumn Gridsupplier_attractionColumn ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private short[] T000A6_A48SupplierId ;
      private string[] T000A6_A49SupplierName ;
      private string[] T000A6_A50SupplierAddress ;
      private short[] T000A7_A48SupplierId ;
      private short[] T000A5_A48SupplierId ;
      private string[] T000A5_A49SupplierName ;
      private string[] T000A5_A50SupplierAddress ;
      private short[] T000A8_A48SupplierId ;
      private short[] T000A9_A48SupplierId ;
      private short[] T000A4_A48SupplierId ;
      private string[] T000A4_A49SupplierName ;
      private string[] T000A4_A50SupplierAddress ;
      private short[] T000A10_A48SupplierId ;
      private short[] T000A13_A48SupplierId ;
      private short[] T000A14_A7AttractionId ;
      private string[] T000A14_A8AttractionName ;
      private string[] T000A14_A40000AttractionPhoto_GXI ;
      private DateTime[] T000A14_A51SupplierAttractionDate ;
      private string[] T000A14_A13AttractionPhoto ;
      private string[] T000A15_A8AttractionName ;
      private short[] T000A16_A7AttractionId ;
      private short[] T000A3_A7AttractionId ;
      private string[] T000A3_A8AttractionName ;
      private string[] T000A3_A40000AttractionPhoto_GXI ;
      private DateTime[] T000A3_A51SupplierAttractionDate ;
      private string[] T000A3_A13AttractionPhoto ;
      private short[] T000A2_A7AttractionId ;
      private string[] T000A2_A8AttractionName ;
      private string[] T000A2_A40000AttractionPhoto_GXI ;
      private DateTime[] T000A2_A51SupplierAttractionDate ;
      private string[] T000A2_A13AttractionPhoto ;
      private short[] T000A17_A7AttractionId ;
      private short[] T000A21_A7AttractionId ;
      private string[] T000A22_A8AttractionName ;
      private GXWebForm Form ;
   }

   public class supplier__default : DataStoreHelperBase, IDataStoreHelper
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
         ,new UpdateCursor(def[9])
         ,new UpdateCursor(def[10])
         ,new ForEachCursor(def[11])
         ,new ForEachCursor(def[12])
         ,new ForEachCursor(def[13])
         ,new ForEachCursor(def[14])
         ,new ForEachCursor(def[15])
         ,new UpdateCursor(def[16])
         ,new UpdateCursor(def[17])
         ,new UpdateCursor(def[18])
         ,new ForEachCursor(def[19])
         ,new ForEachCursor(def[20])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmT000A6;
          prmT000A6 = new Object[] {
          new ParDef("@SupplierId",GXType.Int16,4,0)
          };
          Object[] prmT000A7;
          prmT000A7 = new Object[] {
          new ParDef("@SupplierId",GXType.Int16,4,0)
          };
          Object[] prmT000A5;
          prmT000A5 = new Object[] {
          new ParDef("@SupplierId",GXType.Int16,4,0)
          };
          Object[] prmT000A8;
          prmT000A8 = new Object[] {
          new ParDef("@SupplierId",GXType.Int16,4,0)
          };
          Object[] prmT000A9;
          prmT000A9 = new Object[] {
          new ParDef("@SupplierId",GXType.Int16,4,0)
          };
          Object[] prmT000A4;
          prmT000A4 = new Object[] {
          new ParDef("@SupplierId",GXType.Int16,4,0)
          };
          Object[] prmT000A10;
          prmT000A10 = new Object[] {
          new ParDef("@SupplierName",GXType.NVarChar,40,0) ,
          new ParDef("@SupplierAddress",GXType.NVarChar,1024,0)
          };
          Object[] prmT000A11;
          prmT000A11 = new Object[] {
          new ParDef("@SupplierName",GXType.NVarChar,40,0) ,
          new ParDef("@SupplierAddress",GXType.NVarChar,1024,0) ,
          new ParDef("@SupplierId",GXType.Int16,4,0)
          };
          Object[] prmT000A12;
          prmT000A12 = new Object[] {
          new ParDef("@SupplierId",GXType.Int16,4,0)
          };
          Object[] prmT000A13;
          prmT000A13 = new Object[] {
          };
          Object[] prmT000A14;
          prmT000A14 = new Object[] {
          new ParDef("@AttractionId",GXType.Int16,4,0)
          };
          Object[] prmT000A15;
          prmT000A15 = new Object[] {
          new ParDef("@AttractionName",GXType.NVarChar,40,0) ,
          new ParDef("@AttractionId",GXType.Int16,4,0)
          };
          Object[] prmT000A16;
          prmT000A16 = new Object[] {
          new ParDef("@AttractionId",GXType.Int16,4,0)
          };
          Object[] prmT000A3;
          prmT000A3 = new Object[] {
          new ParDef("@AttractionId",GXType.Int16,4,0)
          };
          Object[] prmT000A2;
          prmT000A2 = new Object[] {
          new ParDef("@AttractionId",GXType.Int16,4,0)
          };
          Object[] prmT000A17;
          prmT000A17 = new Object[] {
          new ParDef("@AttractionName",GXType.NVarChar,40,0) ,
          new ParDef("@AttractionPhoto",GXType.Blob,1024,0){InDB=false} ,
          new ParDef("@AttractionPhoto_GXI",GXType.VarChar,2048,0){AddAtt=true, ImgIdx=1, Tbl="Attraction", Fld="AttractionPhoto"} ,
          new ParDef("@SupplierAttractionDate",GXType.Date,8,0)
          };
          Object[] prmT000A18;
          prmT000A18 = new Object[] {
          new ParDef("@AttractionName",GXType.NVarChar,40,0) ,
          new ParDef("@SupplierAttractionDate",GXType.Date,8,0) ,
          new ParDef("@AttractionId",GXType.Int16,4,0)
          };
          Object[] prmT000A19;
          prmT000A19 = new Object[] {
          new ParDef("@AttractionPhoto",GXType.Blob,1024,0){InDB=false} ,
          new ParDef("@AttractionPhoto_GXI",GXType.VarChar,2048,0){AddAtt=true, ImgIdx=0, Tbl="Attraction", Fld="AttractionPhoto"} ,
          new ParDef("@AttractionId",GXType.Int16,4,0)
          };
          Object[] prmT000A20;
          prmT000A20 = new Object[] {
          new ParDef("@AttractionId",GXType.Int16,4,0)
          };
          Object[] prmT000A21;
          prmT000A21 = new Object[] {
          };
          Object[] prmT000A22;
          prmT000A22 = new Object[] {
          new ParDef("@AttractionName",GXType.NVarChar,40,0) ,
          new ParDef("@AttractionId",GXType.Int16,4,0)
          };
          def= new CursorDef[] {
              new CursorDef("T000A2", "SELECT [AttractionId], [AttractionName], [AttractionPhoto_GXI], [SupplierAttractionDate], [AttractionPhoto] FROM [Attraction] WITH (UPDLOCK) WHERE [AttractionId] = @AttractionId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000A2,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T000A3", "SELECT [AttractionId], [AttractionName], [AttractionPhoto_GXI], [SupplierAttractionDate], [AttractionPhoto] FROM [Attraction] WHERE [AttractionId] = @AttractionId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000A3,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T000A4", "SELECT [SupplierId], [SupplierName], [SupplierAddress] FROM [Supplier] WITH (UPDLOCK) WHERE [SupplierId] = @SupplierId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000A4,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T000A5", "SELECT [SupplierId], [SupplierName], [SupplierAddress] FROM [Supplier] WHERE [SupplierId] = @SupplierId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000A5,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T000A6", "SELECT TM1.[SupplierId], TM1.[SupplierName], TM1.[SupplierAddress] FROM [Supplier] TM1 WHERE TM1.[SupplierId] = @SupplierId ORDER BY TM1.[SupplierId]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000A6,100, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T000A7", "SELECT [SupplierId] FROM [Supplier] WHERE [SupplierId] = @SupplierId  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000A7,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T000A8", "SELECT TOP 1 [SupplierId] FROM [Supplier] WHERE ( [SupplierId] > @SupplierId) ORDER BY [SupplierId]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000A8,1, GxCacheFrequency.OFF ,true,true )
             ,new CursorDef("T000A9", "SELECT TOP 1 [SupplierId] FROM [Supplier] WHERE ( [SupplierId] < @SupplierId) ORDER BY [SupplierId] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000A9,1, GxCacheFrequency.OFF ,true,true )
             ,new CursorDef("T000A10", "INSERT INTO [Supplier]([SupplierName], [SupplierAddress]) VALUES(@SupplierName, @SupplierAddress); SELECT SCOPE_IDENTITY()",true, GxErrorMask.GX_NOMASK, false, this,prmT000A10,1, GxCacheFrequency.OFF ,true,true )
             ,new CursorDef("T000A11", "UPDATE [Supplier] SET [SupplierName]=@SupplierName, [SupplierAddress]=@SupplierAddress  WHERE [SupplierId] = @SupplierId", GxErrorMask.GX_NOMASK,prmT000A11)
             ,new CursorDef("T000A12", "DELETE FROM [Supplier]  WHERE [SupplierId] = @SupplierId", GxErrorMask.GX_NOMASK,prmT000A12)
             ,new CursorDef("T000A13", "SELECT [SupplierId] FROM [Supplier] ORDER BY [SupplierId]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000A13,100, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T000A14", "SELECT [AttractionId], [AttractionName], [AttractionPhoto_GXI], [SupplierAttractionDate], [AttractionPhoto] FROM [Attraction] WHERE [AttractionId] = @AttractionId ORDER BY [AttractionId] ",true, GxErrorMask.GX_NOMASK, false, this,prmT000A14,11, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T000A15", "SELECT [AttractionName] FROM [Attraction] WHERE ([AttractionName] = @AttractionName) AND (Not ( [AttractionId] = @AttractionId)) ",true, GxErrorMask.GX_NOMASK, false, this,prmT000A15,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T000A16", "SELECT [AttractionId] FROM [Attraction] WHERE [AttractionId] = @AttractionId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000A16,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T000A17", "INSERT INTO [Attraction]([AttractionName], [AttractionPhoto], [AttractionPhoto_GXI], [SupplierAttractionDate], [CountryId], [CategoryId], [CityId], [AttractionAddress], [SupplierId]) VALUES(@AttractionName, @AttractionPhoto, @AttractionPhoto_GXI, @SupplierAttractionDate, convert(int, 0), convert(int, 0), convert(int, 0), '', convert(int, 0)); SELECT SCOPE_IDENTITY()",true, GxErrorMask.GX_NOMASK, false, this,prmT000A17,1, GxCacheFrequency.OFF ,true,true )
             ,new CursorDef("T000A18", "UPDATE [Attraction] SET [AttractionName]=@AttractionName, [SupplierAttractionDate]=@SupplierAttractionDate  WHERE [AttractionId] = @AttractionId", GxErrorMask.GX_NOMASK,prmT000A18)
             ,new CursorDef("T000A19", "UPDATE [Attraction] SET [AttractionPhoto]=@AttractionPhoto, [AttractionPhoto_GXI]=@AttractionPhoto_GXI  WHERE [AttractionId] = @AttractionId", GxErrorMask.GX_NOMASK,prmT000A19)
             ,new CursorDef("T000A20", "DELETE FROM [Attraction]  WHERE [AttractionId] = @AttractionId", GxErrorMask.GX_NOMASK,prmT000A20)
             ,new CursorDef("T000A21", "SELECT [AttractionId] FROM [Attraction] ORDER BY [AttractionId] ",true, GxErrorMask.GX_NOMASK, false, this,prmT000A21,11, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T000A22", "SELECT [AttractionName] FROM [Attraction] WHERE ([AttractionName] = @AttractionName) AND (Not ( [AttractionId] = @AttractionId)) ",true, GxErrorMask.GX_NOMASK, false, this,prmT000A22,1, GxCacheFrequency.OFF ,true,false )
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
                ((string[]) buf[2])[0] = rslt.getMultimediaUri(3);
                ((DateTime[]) buf[3])[0] = rslt.getGXDate(4);
                ((string[]) buf[4])[0] = rslt.getMultimediaFile(5, rslt.getVarchar(3));
                return;
             case 1 :
                ((short[]) buf[0])[0] = rslt.getShort(1);
                ((string[]) buf[1])[0] = rslt.getVarchar(2);
                ((string[]) buf[2])[0] = rslt.getMultimediaUri(3);
                ((DateTime[]) buf[3])[0] = rslt.getGXDate(4);
                ((string[]) buf[4])[0] = rslt.getMultimediaFile(5, rslt.getVarchar(3));
                return;
             case 2 :
                ((short[]) buf[0])[0] = rslt.getShort(1);
                ((string[]) buf[1])[0] = rslt.getVarchar(2);
                ((string[]) buf[2])[0] = rslt.getVarchar(3);
                return;
             case 3 :
                ((short[]) buf[0])[0] = rslt.getShort(1);
                ((string[]) buf[1])[0] = rslt.getVarchar(2);
                ((string[]) buf[2])[0] = rslt.getVarchar(3);
                return;
             case 4 :
                ((short[]) buf[0])[0] = rslt.getShort(1);
                ((string[]) buf[1])[0] = rslt.getVarchar(2);
                ((string[]) buf[2])[0] = rslt.getVarchar(3);
                return;
             case 5 :
                ((short[]) buf[0])[0] = rslt.getShort(1);
                return;
             case 6 :
                ((short[]) buf[0])[0] = rslt.getShort(1);
                return;
             case 7 :
                ((short[]) buf[0])[0] = rslt.getShort(1);
                return;
             case 8 :
                ((short[]) buf[0])[0] = rslt.getShort(1);
                return;
             case 11 :
                ((short[]) buf[0])[0] = rslt.getShort(1);
                return;
             case 12 :
                ((short[]) buf[0])[0] = rslt.getShort(1);
                ((string[]) buf[1])[0] = rslt.getVarchar(2);
                ((string[]) buf[2])[0] = rslt.getMultimediaUri(3);
                ((DateTime[]) buf[3])[0] = rslt.getGXDate(4);
                ((string[]) buf[4])[0] = rslt.getMultimediaFile(5, rslt.getVarchar(3));
                return;
             case 13 :
                ((string[]) buf[0])[0] = rslt.getVarchar(1);
                return;
             case 14 :
                ((short[]) buf[0])[0] = rslt.getShort(1);
                return;
             case 15 :
                ((short[]) buf[0])[0] = rslt.getShort(1);
                return;
             case 19 :
                ((short[]) buf[0])[0] = rslt.getShort(1);
                return;
             case 20 :
                ((string[]) buf[0])[0] = rslt.getVarchar(1);
                return;
       }
    }

 }

}
