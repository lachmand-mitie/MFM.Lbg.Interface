namespace MFM.Lbg.Orcs {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"MFM.Lbg.Schemas.ImportFeed_TypedProcedure_dbo+biz_import_standard_feed", typeof(global::MFM.Lbg.Schemas.ImportFeed_TypedProcedure_dbo.biz_import_standard_feed))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"MFM.Lbg.Schemas.MFMFeedFF", typeof(global::MFM.Lbg.Schemas.MFMFeedFF))]
    public sealed class x_to_Rejected_feeds : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 s2 s1"" version=""1.0"" xmlns:ns0=""http://MFM.Lbg.Schemas.MFMFeedFF"" xmlns:s2=""http://schemas.microsoft.com/Sql/2008/05/TypedProcedures/dbo"" xmlns:s1=""http://schemas.microsoft.com/Sql/2008/05/Types/TableTypes/dbo"" xmlns:s0=""http://schemas.microsoft.com/Sql/2008/05/ProceduresResultSets/dbo/biz_import_standard_feed"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s2:biz_import_standard_feed"" />
  </xsl:template>
  <xsl:template match=""/s2:biz_import_standard_feed"">
    <ns0:MFMFeed_FF>
      <xsl:for-each select=""s2:tabin"">
        <xsl:for-each select=""s1:biz_Standard_Feed"">
          <MFMFeed_FF_Record>
            <xsl:if test=""s1:v1"">
              <Feed>
                <xsl:value-of select=""s1:v1/text()"" />
              </Feed>
            </xsl:if>
            <xsl:if test=""s1:v2"">
              <CostCentre>
                <xsl:value-of select=""s1:v2/text()"" />
              </CostCentre>
            </xsl:if>
            <xsl:if test=""s1:v3"">
              <Property>
                <xsl:value-of select=""s1:v3/text()"" />
              </Property>
            </xsl:if>
            <xsl:if test=""s1:m1"">
              <Val1>
                <xsl:value-of select=""s1:m1/text()"" />
              </Val1>
            </xsl:if>
            <xsl:if test=""s1:m2"">
              <Val2>
                <xsl:value-of select=""s1:m2/text()"" />
              </Val2>
            </xsl:if>
            <xsl:if test=""s1:d1"">
              <Date>
                <xsl:value-of select=""s1:d1/text()"" />
              </Date>
            </xsl:if>
          </MFMFeed_FF_Record>
        </xsl:for-each>
      </xsl:for-each>
    </ns0:MFMFeed_FF>
  </xsl:template>
</xsl:stylesheet>";
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"MFM.Lbg.Schemas.ImportFeed_TypedProcedure_dbo+biz_import_standard_feed";
        
        private const global::MFM.Lbg.Schemas.ImportFeed_TypedProcedure_dbo.biz_import_standard_feed _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"MFM.Lbg.Schemas.MFMFeedFF";
        
        private const global::MFM.Lbg.Schemas.MFMFeedFF _trgSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"MFM.Lbg.Schemas.ImportFeed_TypedProcedure_dbo+biz_import_standard_feed";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"MFM.Lbg.Schemas.MFMFeedFF";
                return _TrgSchemas;
            }
        }
    }
}
