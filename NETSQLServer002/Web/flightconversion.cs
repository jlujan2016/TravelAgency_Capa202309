using System;
using System.Collections;
using GeneXus.Utils;
using GeneXus.Resources;
using GeneXus.Application;
using GeneXus.Metadata;
using GeneXus.Cryptography;
using GeneXus.Reorg;
using System.Threading;
using GeneXus.Programs;
using System.Data;
using GeneXus.Data;
using com.genexus;
using GeneXus.Data.ADO;
using GeneXus.Data.NTier;
using GeneXus.Data.NTier.ADO;
using GeneXus.WebControls;
using GeneXus.Http;
using GeneXus.Procedure;
using GeneXus.XML;
using GeneXus.Search;
using GeneXus.Encryption;
using GeneXus.Http.Client;
using System.Xml.Serialization;
namespace GeneXus.Programs {
   public class flightconversion : GXProcedure
   {
      public flightconversion( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("TravelAgency_Capa202309", false);
      }

      public flightconversion( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void execute( )
      {
         initialize();
         executePrivate();
      }

      public void executeSubmit( )
      {
         flightconversion objflightconversion;
         objflightconversion = new flightconversion();
         objflightconversion.context.SetSubmitInitialConfig(context);
         objflightconversion.initialize();
         Submit( executePrivateCatch,objflightconversion);
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((flightconversion)stateInfo).executePrivate();
         }
         catch ( Exception e )
         {
            GXUtil.SaveToEventLog( "Design", e);
            throw;
         }
      }

      void executePrivate( )
      {
         /* GeneXus formulas */
         /* Output device settings */
         cmdBuffer=" SET IDENTITY_INSERT [GXA0006] ON "
         ;
         RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
         RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
         RGZ.ExecuteStmt() ;
         RGZ.Drop();
         /* Using cursor FLIGHTCONV2 */
         pr_default.execute(0);
         while ( (pr_default.getStatus(0) != 101) )
         {
            A25FlightArrivalAirportId = FLIGHTCONV2_A25FlightArrivalAirportId[0];
            A19FlightId = FLIGHTCONV2_A19FlightId[0];
            /*
               INSERT RECORD ON TABLE GXA0006

            */
            AV2FlightId = A19FlightId;
            AV3FlightArrivalAirportId = A25FlightArrivalAirportId;
            if ( (0==A20AirportId) )
            {
               AV4FlightDepartureAirportId = 0;
            }
            else
            {
               AV4FlightDepartureAirportId = A20AirportId;
            }
            /* Using cursor FLIGHTCONV3 */
            pr_default.execute(1, new Object[] {AV2FlightId, AV3FlightArrivalAirportId, AV4FlightDepartureAirportId});
            pr_default.close(1);
            pr_default.SmartCacheProvider.SetUpdated("GXA0006");
            if ( (pr_default.getStatus(1) == 1) )
            {
               context.Gx_err = 1;
               Gx_emsg = (string)(GXResourceManager.GetMessage("GXM_noupdate"));
            }
            else
            {
               context.Gx_err = 0;
               Gx_emsg = "";
            }
            /* End Insert */
            pr_default.readNext(0);
         }
         pr_default.close(0);
         cmdBuffer=" SET IDENTITY_INSERT [GXA0006] OFF "
         ;
         RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
         RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
         RGZ.ExecuteStmt() ;
         RGZ.Drop();
         this.cleanup();
      }

      public override void cleanup( )
      {
         CloseOpenCursors();
         if ( IsMain )
         {
            context.CloseConnections();
         }
         ExitApp();
      }

      protected void CloseOpenCursors( )
      {
      }

      public override void initialize( )
      {
         cmdBuffer = "";
         scmdbuf = "";
         FLIGHTCONV2_A25FlightArrivalAirportId = new short[1] ;
         FLIGHTCONV2_A19FlightId = new short[1] ;
         Gx_emsg = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.flightconversion__default(),
            new Object[][] {
                new Object[] {
               FLIGHTCONV2_A25FlightArrivalAirportId, FLIGHTCONV2_A19FlightId
               }
               , new Object[] {
               }
            }
         );
         /* GeneXus formulas. */
      }

      private short A25FlightArrivalAirportId ;
      private short A19FlightId ;
      private short AV2FlightId ;
      private short AV3FlightArrivalAirportId ;
      private short A20AirportId ;
      private short AV4FlightDepartureAirportId ;
      private int GIGXA0006 ;
      private string cmdBuffer ;
      private string scmdbuf ;
      private string Gx_emsg ;
      private IGxDataStore dsDefault ;
      private GxCommand RGZ ;
      private IDataStoreProvider pr_default ;
      private short[] FLIGHTCONV2_A25FlightArrivalAirportId ;
      private short[] FLIGHTCONV2_A19FlightId ;
   }

   public class flightconversion__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
         ,new UpdateCursor(def[1])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmFLIGHTCONV2;
          prmFLIGHTCONV2 = new Object[] {
          };
          Object[] prmFLIGHTCONV3;
          prmFLIGHTCONV3 = new Object[] {
          new ParDef("@AV2FlightId",GXType.Int16,4,0) ,
          new ParDef("@AV3FlightArrivalAirportId",GXType.Int16,4,0) ,
          new ParDef("@AV4FlightDepartureAirportId",GXType.Int16,4,0)
          };
          def= new CursorDef[] {
              new CursorDef("FLIGHTCONV2", "SELECT [FlightArrivalAirportId], [FlightId] FROM [Flight] ORDER BY [FlightId] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmFLIGHTCONV2,100, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("FLIGHTCONV3", "INSERT INTO [GXA0006]([FlightId], [FlightArrivalAirportId], [FlightDepartureAirportId]) VALUES(@AV2FlightId, @AV3FlightArrivalAirportId, @AV4FlightDepartureAirportId)", GxErrorMask.GX_NOMASK,prmFLIGHTCONV3)
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
                return;
       }
    }

 }

}
