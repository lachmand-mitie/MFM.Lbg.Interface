namespace MFM.Lbg.Orcs {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"MFM.Lbg.Schemas.BeaconXslIndexer", typeof(global::MFM.Lbg.Schemas.BeaconXslIndexer))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"MTFM.Maximo.RR.RRMIAMI_RRMIAMIWOUPDATEIFACE_www_ibm_com_maximo+UpdateRRMIAMIWOUPDATE", typeof(global::MTFM.Maximo.RR.RRMIAMI_RRMIAMIWOUPDATEIFACE_www_ibm_com_maximo.UpdateRRMIAMIWOUPDATE))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"MTFM.Maximo.RR.RRMIAMI_RRMIAMIWOUPDATEIFACE_www_ibm_com_maximo+UpdateRRMIAMIWOUPDATE", typeof(global::MTFM.Maximo.RR.RRMIAMI_RRMIAMIWOUPDATEIFACE_www_ibm_com_maximo.UpdateRRMIAMIWOUPDATE))]
    public sealed class x_to_rr_worklog_only : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0"" version=""1.0"" xmlns:s0=""http://schemas.microsoft.com/BizTalk/2003/aggschema"" xmlns:ns0=""http://www.ibm.com/maximo"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:Root"" />
  </xsl:template>
  <xsl:template match=""/s0:Root"">
    <ns0:UpdateRRMIAMIWOUPDATE>
      <ns0:RRMIAMIWOUPDATESet>
        <xsl:for-each select=""InputMessagePart_1/ns0:UpdateRRMIAMIWOUPDATE/ns0:RRMIAMIWOUPDATESet/ns0:WORKORDER"">
          <xsl:variable name=""var:v1"" select=""../../../../InputMessagePart_0/BeaconXslIndexerV1/PathIndex/text()"" />
          <xsl:variable name=""var:v2"" select=""./ns0:WORKLOG[number($var:v1)]/@action"" />
          <xsl:variable name=""var:v3"" select=""./ns0:WORKLOG[number($var:v1)]/ns0:CLASS[1]/text()"" />
          <xsl:variable name=""var:v4"" select=""./ns0:WORKLOG[number($var:v1)]/ns0:CREATEBY[1]/text()"" />
          <xsl:variable name=""var:v5"" select=""./ns0:WORKLOG[number($var:v1)]/ns0:CREATEDATE[1]/text()"" />
          <xsl:variable name=""var:v6"" select=""./ns0:WORKLOG[number($var:v1)]/ns0:DESCRIPTION[1]/text()"" />
          <xsl:variable name=""var:v7"" select=""./ns0:WORKLOG[number($var:v1)]/ns0:DESCRIPTION_LONGDESCRIPTION[1]/text()"" />
          <xsl:variable name=""var:v8"" select=""./ns0:WORKLOG[number($var:v1)]/ns0:LOGTYPE[1]/text()"" />
          <xsl:variable name=""var:v9"" select=""./ns0:WORKLOG[number($var:v1)]/ns0:MODIFYBY[1]/text()"" />
          <xsl:variable name=""var:v10"" select=""./ns0:WORKLOG[number($var:v1)]/ns0:MODIFYDATE[1]/text()"" />
          <xsl:variable name=""var:v11"" select=""./ns0:WORKLOG[number($var:v1)]/ns0:RECORDKEY[1]/text()"" />
          <xsl:variable name=""var:v12"" select=""./ns0:WORKLOG[number($var:v1)]/text()"" />
          <ns0:WORKORDER>
            <xsl:if test=""@transLanguage"">
              <xsl:attribute name=""transLanguage"">
                <xsl:value-of select=""@transLanguage"" />
              </xsl:attribute>
            </xsl:if>
            <xsl:if test=""@action"">
              <xsl:attribute name=""action"">
                <xsl:value-of select=""@action"" />
              </xsl:attribute>
            </xsl:if>
            <xsl:if test=""@relationship"">
              <xsl:attribute name=""relationship"">
                <xsl:value-of select=""@relationship"" />
              </xsl:attribute>
            </xsl:if>
            <xsl:if test=""@deleteForInsert"">
              <xsl:attribute name=""deleteForInsert"">
                <xsl:value-of select=""@deleteForInsert"" />
              </xsl:attribute>
            </xsl:if>
            <xsl:if test=""ns0:MAXINTERRORMSG"">
              <ns0:MAXINTERRORMSG>
                <xsl:value-of select=""ns0:MAXINTERRORMSG/text()"" />
              </ns0:MAXINTERRORMSG>
            </xsl:if>
            <xsl:for-each select=""ns0:MTFMWONUM"">
              <ns0:MTFMWONUM>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:MTFMWONUM>
            </xsl:for-each>
            <xsl:for-each select=""ns0:SITEID"">
              <ns0:SITEID>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:SITEID>
            </xsl:for-each>
            <xsl:for-each select=""ns0:WONUM"">
              <ns0:WONUM>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:WONUM>
            </xsl:for-each>
            <ns0:WORKLOG>
              <xsl:attribute name=""action"">
                <xsl:value-of select=""$var:v2"" />
              </xsl:attribute>
              <ns0:CLASS>
                <xsl:value-of select=""$var:v3"" />
              </ns0:CLASS>
              <ns0:CREATEBY>
                <xsl:value-of select=""$var:v4"" />
              </ns0:CREATEBY>
              <ns0:CREATEDATE>
                <xsl:value-of select=""$var:v5"" />
              </ns0:CREATEDATE>
              <ns0:DESCRIPTION>
                <xsl:value-of select=""$var:v6"" />
              </ns0:DESCRIPTION>
              <ns0:DESCRIPTION_LONGDESCRIPTION>
                <xsl:value-of select=""$var:v7"" />
              </ns0:DESCRIPTION_LONGDESCRIPTION>
              <ns0:LOGTYPE>
                <xsl:value-of select=""$var:v8"" />
              </ns0:LOGTYPE>
              <ns0:MODIFYBY>
                <xsl:value-of select=""$var:v9"" />
              </ns0:MODIFYBY>
              <ns0:MODIFYDATE>
                <xsl:value-of select=""$var:v10"" />
              </ns0:MODIFYDATE>
              <ns0:RECORDKEY>
                <xsl:value-of select=""$var:v11"" />
              </ns0:RECORDKEY>
              <xsl:value-of select=""$var:v12"" />
            </ns0:WORKLOG>
          </ns0:WORKORDER>
        </xsl:for-each>
      </ns0:RRMIAMIWOUPDATESet>
    </ns0:UpdateRRMIAMIWOUPDATE>
  </xsl:template>
</xsl:stylesheet>";
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"MFM.Lbg.Schemas.BeaconXslIndexer";
        
        private const global::MFM.Lbg.Schemas.BeaconXslIndexer _srcSchemaTypeReference0 = null;
        
        private const string _strSrcSchemasList1 = @"MTFM.Maximo.RR.RRMIAMI_RRMIAMIWOUPDATEIFACE_www_ibm_com_maximo+UpdateRRMIAMIWOUPDATE";
        
        private const global::MTFM.Maximo.RR.RRMIAMI_RRMIAMIWOUPDATEIFACE_www_ibm_com_maximo.UpdateRRMIAMIWOUPDATE _srcSchemaTypeReference1 = null;
        
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
                _SrcSchemas[0] = @"MFM.Lbg.Schemas.BeaconXslIndexer";
                _SrcSchemas[1] = @"MTFM.Maximo.RR.RRMIAMI_RRMIAMIWOUPDATEIFACE_www_ibm_com_maximo+UpdateRRMIAMIWOUPDATE";
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
