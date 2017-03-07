namespace MFM.Lbg.Orcs {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"MFM.Lbg.Schemas.MFMFeedFF", typeof(global::MFM.Lbg.Schemas.MFMFeedFF))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"MFM.Lbg.Schemas.ImportFeed_TypedProcedure_dbo+biz_import_standard_feed", typeof(global::MFM.Lbg.Schemas.ImportFeed_TypedProcedure_dbo.biz_import_standard_feed))]
    public sealed class x_to_feed : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0"" version=""1.0"" xmlns:ns4=""http://schemas.microsoft.com/Sql/2008/05/ProceduresResultSets/dbo/biz_import_standard_feed"" xmlns:s0=""http://MFM.Lbg.Schemas.MFMFeedFF"" xmlns:ns0=""http://schemas.microsoft.com/Sql/2008/05/TypedProcedures/dbo"" xmlns:ns3=""http://schemas.microsoft.com/Sql/2008/05/Types/TableTypes/dbo"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:MFMFeed_FF"" />
  </xsl:template>
  <xsl:template match=""/s0:MFMFeed_FF"">
    <ns0:biz_import_standard_feed>
      <ns0:tabin>
        <xsl:for-each select=""MFMFeed_FF_Record"">
          <ns3:biz_Standard_Feed>
            <ns3:v1>
              <xsl:value-of select=""Feed/text()"" />
            </ns3:v1>
            <ns3:v2>
              <xsl:value-of select=""CostCentre/text()"" />
            </ns3:v2>
            <ns3:v3>
              <xsl:value-of select=""Property/text()"" />
            </ns3:v3>
            <ns3:m1>
              <xsl:value-of select=""Val1/text()"" />
            </ns3:m1>
            <ns3:m2>
              <xsl:value-of select=""Val2/text()"" />
            </ns3:m2>
            <ns3:d1>
              <xsl:value-of select=""Date/text()"" />
            </ns3:d1>
            <xsl:value-of select=""./text()"" />
          </ns3:biz_Standard_Feed>
        </xsl:for-each>
      </ns0:tabin>
    </ns0:biz_import_standard_feed>
  </xsl:template>
</xsl:stylesheet>";
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"MFM.Lbg.Schemas.MFMFeedFF";
        
        private const global::MFM.Lbg.Schemas.MFMFeedFF _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"MFM.Lbg.Schemas.ImportFeed_TypedProcedure_dbo+biz_import_standard_feed";
        
        private const global::MFM.Lbg.Schemas.ImportFeed_TypedProcedure_dbo.biz_import_standard_feed _trgSchemaTypeReference0 = null;
        
        public override string XmlContent {
            get {
                return _strMap;
            }
        }
        
        public override string XsltArgumentListContent {
            get {
                return _strArgList;
            }
        }
        
        public override string[] SourceSchemas {
            get {
                string[] _SrcSchemas = new string [1];
                _SrcSchemas[0] = @"MFM.Lbg.Schemas.MFMFeedFF";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"MFM.Lbg.Schemas.ImportFeed_TypedProcedure_dbo+biz_import_standard_feed";
                return _TrgSchemas;
            }
        }
    }
}
