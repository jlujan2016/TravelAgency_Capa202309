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
using GeneXus.Data.ADO;
using GeneXus.Data.NTier;
using GeneXus.Data.NTier.ADO;
using GeneXus.XML;
using GeneXus.Search;
using GeneXus.Encryption;
using GeneXus.Http.Client;
using System.Xml.Serialization;
namespace GeneXus.Programs {
   public class reorg : GXReorganization
   {
      public reorg( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("TravelAgency_Capa202309", false);
      }

      public reorg( IGxContext context )
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

      void executePrivate( )
      {
         if ( PreviousCheck() )
         {
            ExecuteReorganization( ) ;
         }
      }

      private void FirstActions( )
      {
         /* Load data into tables. */
      }

      public void ReorganizeAttraction( )
      {
         string cmdBuffer = "";
         /* Indices for table Attraction */
         cmdBuffer=" ALTER TABLE [Attraction] ADD [CountryId] smallint NOT NULL CONSTRAINT CountryIdAttraction_DEFAULT DEFAULT convert(int, 0) "
         ;
         RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
         RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
         RGZ.ExecuteStmt() ;
         RGZ.Drop();
         cmdBuffer=" ALTER TABLE [Attraction] DROP CONSTRAINT CountryIdAttraction_DEFAULT "
         ;
         RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
         RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
         RGZ.ExecuteStmt() ;
         RGZ.Drop();
         cmdBuffer=" SET IDENTITY_INSERT [Country] ON "
         ;
         RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
         RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
         RGZ.ExecuteStmt() ;
         RGZ.Drop();
         cmdBuffer=" INSERT INTO [Country] ([CountryId], [CountryName]) SELECT TOP 1 convert(int, 0), ' ' FROM [Attraction] WHERE NOT EXISTS (SELECT 1 FROM [Country] WHERE CountryId=convert(int, 0)) "
         ;
         RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
         RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
         RGZ.ExecuteStmt() ;
         RGZ.Drop();
         cmdBuffer=" SET IDENTITY_INSERT [Country] OFF "
         ;
         RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
         RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
         RGZ.ExecuteStmt() ;
         RGZ.Drop();
         try
         {
            cmdBuffer=" CREATE NONCLUSTERED INDEX [IATTRACTION1] ON [Attraction] ([CountryId] ) "
            ;
            RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
            RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
            RGZ.ExecuteStmt() ;
            RGZ.Drop();
         }
         catch
         {
            cmdBuffer=" DROP INDEX [IATTRACTION1] ON [Attraction] "
            ;
            RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
            RGZ.ErrorMask = GxErrorMask.GX_MASKNOTFOUND | GxErrorMask.GX_MASKLOOPLOCK;
            RGZ.ExecuteStmt() ;
            RGZ.Drop();
            cmdBuffer=" CREATE NONCLUSTERED INDEX [IATTRACTION1] ON [Attraction] ([CountryId] ) "
            ;
            RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
            RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
            RGZ.ExecuteStmt() ;
            RGZ.Drop();
         }
      }

      public void RIAttractionCountry( )
      {
         string cmdBuffer;
         try
         {
            cmdBuffer=" ALTER TABLE [Attraction] ADD CONSTRAINT [IATTRACTION1] FOREIGN KEY ([CountryId]) REFERENCES [Country] ([CountryId]) "
            ;
            RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
            RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
            RGZ.ExecuteStmt() ;
            RGZ.Drop();
         }
         catch
         {
            try
            {
               cmdBuffer=" ALTER TABLE [Attraction] DROP CONSTRAINT [IATTRACTION1] "
               ;
               RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
               RGZ.ErrorMask = GxErrorMask.GX_MASKNOTFOUND | GxErrorMask.GX_MASKLOOPLOCK;
               RGZ.ExecuteStmt() ;
               RGZ.Drop();
            }
            catch
            {
            }
            cmdBuffer=" ALTER TABLE [Attraction] ADD CONSTRAINT [IATTRACTION1] FOREIGN KEY ([CountryId]) REFERENCES [Country] ([CountryId]) "
            ;
            RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
            RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
            RGZ.ExecuteStmt() ;
            RGZ.Drop();
         }
      }

      private void TablesCount( )
      {
         if ( ! IsResumeMode( ) )
         {
            /* Using cursor P00012 */
            pr_default.execute(0);
            AttractionCount = P00012_AAttractionCount[0];
            pr_default.close(0);
            PrintRecordCount ( "Attraction" ,  AttractionCount );
         }
      }

      private bool PreviousCheck( )
      {
         if ( ! IsResumeMode( ) )
         {
            if ( GXUtil.DbmsVersion( context, "DEFAULT") < 10 )
            {
               SetCheckError ( GXResourceManager.GetMessage("GXM_bad_DBMS_version", new   object[]  {"2012"}) ) ;
               return false ;
            }
         }
         if ( ! MustRunCheck( ) )
         {
            return true ;
         }
         if ( GXUtil.IsSQLSERVER2005( context, "DEFAULT") )
         {
            /* Using cursor P00023 */
            pr_default.execute(1);
            while ( (pr_default.getStatus(1) != 101) )
            {
               sSchemaVar = P00023_AsSchemaVar[0];
               nsSchemaVar = P00023_nsSchemaVar[0];
               pr_default.readNext(1);
            }
            pr_default.close(1);
         }
         else
         {
            /* Using cursor P00034 */
            pr_default.execute(2);
            while ( (pr_default.getStatus(2) != 101) )
            {
               sSchemaVar = P00034_AsSchemaVar[0];
               nsSchemaVar = P00034_nsSchemaVar[0];
               pr_default.readNext(2);
            }
            pr_default.close(2);
         }
         if ( ColumnExist("Attraction",sSchemaVar,"CountryId") )
         {
            SetCheckError ( GXResourceManager.GetMessage("GXM_column_exist", new   object[]  {"CountryId", "Attraction"}) ) ;
            return false ;
         }
         return true ;
      }

      private bool ColumnExist( string sTableName ,
                                string sMySchemaName ,
                                string sMyColumnName )
      {
         bool result;
         result = false;
         /* Using cursor P00045 */
         pr_default.execute(3, new Object[] {sTableName, sMySchemaName, sMyColumnName});
         while ( (pr_default.getStatus(3) != 101) )
         {
            tablename = P00045_Atablename[0];
            ntablename = P00045_ntablename[0];
            schemaname = P00045_Aschemaname[0];
            nschemaname = P00045_nschemaname[0];
            columnname = P00045_Acolumnname[0];
            ncolumnname = P00045_ncolumnname[0];
            result = true;
            pr_default.readNext(3);
         }
         pr_default.close(3);
         return result ;
      }

      private void ExecuteOnlyTablesReorganization( )
      {
         ReorgExecute.RegisterBlockForSubmit( 1 ,  "ReorganizeAttraction" , new Object[]{ });
      }

      private void ExecuteOnlyRisReorganization( )
      {
         ReorgExecute.RegisterBlockForSubmit( 2 ,  "RIAttractionCountry" , new Object[]{ });
      }

      private void ExecuteTablesReorganization( )
      {
         ExecuteOnlyTablesReorganization( ) ;
         ExecuteOnlyRisReorganization( ) ;
         ReorgExecute.SubmitAll() ;
      }

      private void SetPrecedence( )
      {
         SetPrecedencetables( ) ;
         SetPrecedenceris( ) ;
      }

      private void SetPrecedencetables( )
      {
         GXReorganization.SetMsg( 1 ,  GXResourceManager.GetMessage("GXM_fileupdate", new   object[]  {"Attraction", ""}) );
      }

      private void SetPrecedenceris( )
      {
         GXReorganization.SetMsg( 2 ,  GXResourceManager.GetMessage("GXM_refintcrea", new   object[]  {"[IATTRACTION1]"}) );
         ReorgExecute.RegisterPrecedence( "RIAttractionCountry" ,  "ReorganizeAttraction" );
      }

      private void ExecuteReorganization( )
      {
         if ( ErrCode == 0 )
         {
            TablesCount( ) ;
            if ( ! PrintOnlyRecordCount( ) )
            {
               FirstActions( ) ;
               SetPrecedence( ) ;
               ExecuteTablesReorganization( ) ;
            }
         }
      }

      public void UtilsCleanup( )
      {
         this.cleanup();
      }

      public override void cleanup( )
      {
         CloseOpenCursors();
      }

      protected void CloseOpenCursors( )
      {
      }

      public override void initialize( )
      {
         scmdbuf = "";
         P00012_AAttractionCount = new int[1] ;
         sSchemaVar = "";
         nsSchemaVar = false;
         P00023_AsSchemaVar = new string[] {""} ;
         P00023_nsSchemaVar = new bool[] {false} ;
         P00034_AsSchemaVar = new string[] {""} ;
         P00034_nsSchemaVar = new bool[] {false} ;
         sTableName = "";
         sMySchemaName = "";
         sMyColumnName = "";
         tablename = "";
         ntablename = false;
         schemaname = "";
         nschemaname = false;
         columnname = "";
         ncolumnname = false;
         P00045_Atablename = new string[] {""} ;
         P00045_ntablename = new bool[] {false} ;
         P00045_Aschemaname = new string[] {""} ;
         P00045_nschemaname = new bool[] {false} ;
         P00045_Acolumnname = new string[] {""} ;
         P00045_ncolumnname = new bool[] {false} ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.reorg__default(),
            new Object[][] {
                new Object[] {
               P00012_AAttractionCount
               }
               , new Object[] {
               P00023_AsSchemaVar
               }
               , new Object[] {
               P00034_AsSchemaVar
               }
               , new Object[] {
               P00045_Atablename, P00045_Aschemaname, P00045_Acolumnname
               }
            }
         );
         /* GeneXus formulas. */
      }

      protected short ErrCode ;
      protected int AttractionCount ;
      protected string scmdbuf ;
      protected string sSchemaVar ;
      protected string sTableName ;
      protected string sMySchemaName ;
      protected string sMyColumnName ;
      protected bool nsSchemaVar ;
      protected bool ntablename ;
      protected bool nschemaname ;
      protected bool ncolumnname ;
      protected string tablename ;
      protected string schemaname ;
      protected string columnname ;
      protected IGxDataStore dsDefault ;
      protected GxCommand RGZ ;
      protected IDataStoreProvider pr_default ;
      protected int[] P00012_AAttractionCount ;
      protected string[] P00023_AsSchemaVar ;
      protected bool[] P00023_nsSchemaVar ;
      protected string[] P00034_AsSchemaVar ;
      protected bool[] P00034_nsSchemaVar ;
      protected string[] P00045_Atablename ;
      protected bool[] P00045_ntablename ;
      protected string[] P00045_Aschemaname ;
      protected bool[] P00045_nschemaname ;
      protected string[] P00045_Acolumnname ;
      protected bool[] P00045_ncolumnname ;
   }

   public class reorg__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
         ,new ForEachCursor(def[1])
         ,new ForEachCursor(def[2])
         ,new ForEachCursor(def[3])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmP00012;
          prmP00012 = new Object[] {
          };
          Object[] prmP00023;
          prmP00023 = new Object[] {
          };
          Object[] prmP00034;
          prmP00034 = new Object[] {
          };
          Object[] prmP00045;
          prmP00045 = new Object[] {
          new ParDef("@sTableName",GXType.Char,255,0) ,
          new ParDef("@sMySchemaName",GXType.Char,255,0) ,
          new ParDef("@sMyColumnName",GXType.Char,255,0)
          };
          def= new CursorDef[] {
              new CursorDef("P00012", "SELECT COUNT(*) FROM [Attraction] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00012,100, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("P00023", "SELECT SCHEMA_NAME() ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00023,100, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("P00034", "SELECT USER_NAME() ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00034,100, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("P00045", "SELECT TABLE_NAME, TABLE_SCHEMA, COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE (TABLE_NAME = @sTableName) AND (TABLE_SCHEMA = @sMySchemaName) AND (COLUMN_NAME = @sMyColumnName) ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00045,100, GxCacheFrequency.OFF ,true,false )
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
                ((int[]) buf[0])[0] = rslt.getInt(1);
                return;
             case 1 :
                ((string[]) buf[0])[0] = rslt.getString(1, 255);
                return;
             case 2 :
                ((string[]) buf[0])[0] = rslt.getString(1, 255);
                return;
             case 3 :
                ((string[]) buf[0])[0] = rslt.getVarchar(1);
                ((string[]) buf[1])[0] = rslt.getVarchar(2);
                ((string[]) buf[2])[0] = rslt.getVarchar(3);
                return;
       }
    }

 }

}
