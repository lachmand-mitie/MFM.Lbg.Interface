namespace MFM.Lbg.Orcs {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"MFM.Lbg.Schemas.MFMFeedFF", typeof(global::MFM.Lbg.Schemas.MFMFeedFF))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"MFM.Lbg.Schemas.Import_Feed2_TypedProcedure_dbo+biz_Process_Feed_Wrapper", typeof(global::MFM.Lbg.Schemas.Import_Feed2_TypedProcedure_dbo.biz_Process_Feed_Wrapper))]
    public sealed class x_to_biz_Process_Feed_Wrapper : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0"" version=""1.0"" xmlns:s0=""http://MFM.Lbg.Schemas.MFMFeedFF"" xmlns:ns3=""http://schemas.microsoft.com/Sql/2008/05/ProceduresResultSets/dbo/biz_Process_Feed_Wrapper"" xmlns:ns0=""http://schemas.microsoft.com/Sql/2008/05/TypedProcedures/dbo"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:MFMFeed_FF"" />
  </xsl:template>
  <xsl:template match=""/s0:MFMFeed_FF"">
    <ns0:biz_Process_Feed_Wrapper>
      <xsl:value-of select=""./text()"" />
    </ns0:biz_Process_Feed_Wrapper>
  </xsl:template>
</xsl:stylesheet>";
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"MFM.Lbg.Schemas.MFMFeedFF";
        
        private const global::MFM.Lbg.Schemas.MFMFeedFF _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"MFM.Lbg.Schemas.Import_Feed2_TypedProcedure_dbo+biz_Process_Feed_Wrapper";
        
        private const global::MFM.Lbg.Schemas.Import_Feed2_TypedProcedure_dbo.biz_Process_Feed_Wrapper _trgSchemaTypeReference0 = null;
        
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
                _TrgSchemas[0] = @"MFM.Lbg.Schemas.Import_Feed2_TypedProcedure_dbo+biz_Process_Feed_Wrapper";
                return _TrgSchemas;
            }
        }
    }
}
