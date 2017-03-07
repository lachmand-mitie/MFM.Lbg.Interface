namespace MFM.Lbg.Orcs {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"MFM.Lbg.Schemas.MTFMWOINService+SyncMTFMWOIN", typeof(global::MFM.Lbg.Schemas.MTFMWOINService.SyncMTFMWOIN))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"MFM.Lbg.Schemas.TFMAlertAddress", typeof(global::MFM.Lbg.Schemas.TFMAlertAddress))]
    public sealed class map_to_emailto : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0"" version=""1.0"" xmlns:ns0=""http://MFM.Lbg.Schemas.TFMAlertAddress"" xmlns:s0=""http://www.ibm.com/maximo"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:SyncMTFMWOIN"" />
  </xsl:template>
  <xsl:template match=""/s0:SyncMTFMWOIN"">
    <ns0:TFMAlertAddress>
      <xsl:if test=""s0:MTFMWOINSet/s0:WORKORDER/s0:SITEID"">
        <EmailAddress>
          <xsl:value-of select=""s0:MTFMWOINSet/s0:WORKORDER/s0:SITEID/text()"" />
        </EmailAddress>
      </xsl:if>
      <xsl:if test=""s0:MTFMWOINSet/s0:WORKORDER/s0:MTFMCLIENTREF"">
        <HelpdeskRef>
          <xsl:value-of select=""s0:MTFMWOINSet/s0:WORKORDER/s0:MTFMCLIENTREF/text()"" />
        </HelpdeskRef>
      </xsl:if>
    </ns0:TFMAlertAddress>
  </xsl:template>
</xsl:stylesheet>";
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"MFM.Lbg.Schemas.MTFMWOINService+SyncMTFMWOIN";
        
        private const global::MFM.Lbg.Schemas.MTFMWOINService.SyncMTFMWOIN _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"MFM.Lbg.Schemas.TFMAlertAddress";
        
        private const global::MFM.Lbg.Schemas.TFMAlertAddress _trgSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"MFM.Lbg.Schemas.MTFMWOINService+SyncMTFMWOIN";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"MFM.Lbg.Schemas.TFMAlertAddress";
                return _TrgSchemas;
            }
        }
    }
}
