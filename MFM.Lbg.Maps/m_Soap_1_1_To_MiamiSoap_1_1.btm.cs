namespace MFM.Lbg.Maps {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"BTS.soap_envelope_1__1+Fault", typeof(global::BTS.soap_envelope_1__1.Fault))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"MFM.Lbg.Schemas.MiamiSoapError", typeof(global::MFM.Lbg.Schemas.MiamiSoapError))]
    public sealed class m_Soap_1_1_To_MiamiSoap_1_1 : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0"" version=""1.0"" xmlns:ns0=""MFM.Lbg.Schemas/Soap/Erros/Miami/1_1"" xmlns:s0=""http://schemas.xmlsoap.org/soap/envelope/"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:Fault"" />
  </xsl:template>
  <xsl:template match=""/s0:Fault"">
    <ns0:MiamiSoapErorr_1_1>
      <faultString>
        <xsl:value-of select=""faultstring/text()"" />
      </faultString>
    </ns0:MiamiSoapErorr_1_1>
  </xsl:template>
</xsl:stylesheet>";
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"BTS.soap_envelope_1__1+Fault";
        
        private const global::BTS.soap_envelope_1__1.Fault _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"MFM.Lbg.Schemas.MiamiSoapError";
        
        private const global::MFM.Lbg.Schemas.MiamiSoapError _trgSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"BTS.soap_envelope_1__1+Fault";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"MFM.Lbg.Schemas.MiamiSoapError";
                return _TrgSchemas;
            }
        }
    }
}
