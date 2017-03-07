namespace MFM.Lbg.Orcs {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"MFM.Lbg.Schemas.MiAMIWOQueryResponse", typeof(global::MFM.Lbg.Schemas.MiAMIWOQueryResponse))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"MTFM.Maximo.RR.RRMIAMIWORKORDERService+PublishRRMIAMIWORKORDER", typeof(global::MTFM.Maximo.RR.RRMIAMIWORKORDERService.PublishRRMIAMIWORKORDER))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"MTFM.Maximo.RR.RRMIAMI_RRMIAMIWOUPDATEIFACE_www_ibm_com_maximo+UpdateRRMIAMIWOUPDATE", typeof(global::MTFM.Maximo.RR.RRMIAMI_RRMIAMIWOUPDATEIFACE_www_ibm_com_maximo.UpdateRRMIAMIWOUPDATE))]
    public sealed class x_to_miami_exists_ref_upd : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0"" version=""1.0"" xmlns:s0=""http://schemas.microsoft.com/BizTalk/2003/aggschema"" xmlns:ns0=""http://www.ibm.com/maximo"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:Root"" />
  </xsl:template>
  <xsl:template match=""/s0:Root"">
    <ns0:UpdateRRMIAMIWOUPDATE>
      <ns0:RRMIAMIWOUPDATESet>
        <ns0:WORKORDER>
          <xsl:attribute name=""action"">
            <xsl:text>Change</xsl:text>
          </xsl:attribute>
          <ns0:MTFMWONUM>
            <xsl:value-of select=""InputMessagePart_0/MiAMIWOQueryResponseV1/MTFMCLIENTREF/text()"" />
          </ns0:MTFMWONUM>
          <xsl:for-each select=""InputMessagePart_1/ns0:PublishRRMIAMIWORKORDER/ns0:RRMIAMIWORKORDERSet/ns0:WORKORDER"">
            <xsl:for-each select=""ns0:SITEID"">
              <ns0:SITEID>
                <xsl:value-of select=""./text()"" />
              </ns0:SITEID>
            </xsl:for-each>
          </xsl:for-each>
          <xsl:for-each select=""InputMessagePart_1/ns0:PublishRRMIAMIWORKORDER/ns0:RRMIAMIWORKORDERSet/ns0:WORKORDER"">
            <xsl:for-each select=""ns0:WONUM"">
              <ns0:WONUM>
                <xsl:value-of select=""./text()"" />
              </ns0:WONUM>
            </xsl:for-each>
          </xsl:for-each>
        </ns0:WORKORDER>
      </ns0:RRMIAMIWOUPDATESet>
    </ns0:UpdateRRMIAMIWOUPDATE>
  </xsl:template>
</xsl:stylesheet>";
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"MFM.Lbg.Schemas.MiAMIWOQueryResponse";
        
        private const global::MFM.Lbg.Schemas.MiAMIWOQueryResponse _srcSchemaTypeReference0 = null;
        
        private const string _strSrcSchemasList1 = @"MTFM.Maximo.RR.RRMIAMIWORKORDERService+PublishRRMIAMIWORKORDER";
        
        private const global::MTFM.Maximo.RR.RRMIAMIWORKORDERService.PublishRRMIAMIWORKORDER _srcSchemaTypeReference1 = null;
        
        private const string _strTrgSchemasList0 = @"MTFM.Maximo.RR.RRMIAMI_RRMIAMIWOUPDATEIFACE_www_ibm_com_maximo+UpdateRRMIAMIWOUPDATE";
        
        private const global::MTFM.Maximo.RR.RRMIAMI_RRMIAMIWOUPDATEIFACE_www_ibm_com_maximo.UpdateRRMIAMIWOUPDATE _trgSchemaTypeReference0 = null;
        
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
                string[] _SrcSchemas = new string [2];
                _SrcSchemas[0] = @"MFM.Lbg.Schemas.MiAMIWOQueryResponse";
                _SrcSchemas[1] = @"MTFM.Maximo.RR.RRMIAMIWORKORDERService+PublishRRMIAMIWORKORDER";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"MTFM.Maximo.RR.RRMIAMI_RRMIAMIWOUPDATEIFACE_www_ibm_com_maximo+UpdateRRMIAMIWOUPDATE";
                return _TrgSchemas;
            }
        }
    }
}
