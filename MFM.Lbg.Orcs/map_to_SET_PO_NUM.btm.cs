namespace MFM.Lbg.Orcs {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"MFM.Lbg.Schemas.ORDERS05_ZMM158ORDERS", typeof(global::MFM.Lbg.Schemas.ORDERS05_ZMM158ORDERS))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"MFM.Lbg.Schemas.VFM_POTypedProcedure_dbo1+biz_PO_Set_PO_Number", typeof(global::MFM.Lbg.Schemas.VFM_POTypedProcedure_dbo1.biz_PO_Set_PO_Number))]
    public sealed class map_to_SET_PO_NUM : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var userVB"" version=""1.0"" xmlns:ns0=""http://schemas.microsoft.com/Sql/2008/05/TypedProcedures/dbo"" xmlns:userVB=""http://schemas.microsoft.com/BizTalk/2003/userVB"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/ZMM158ORDERS"" />
  </xsl:template>
  <xsl:template match=""/ZMM158ORDERS"">
    <ns0:biz_PO_Set_PO_Number>
      <xsl:variable name=""var:v1"" select=""userVB:MyConcat(string(IDOC/E1EDKA1/IHREZ/text()))"" />
      <ns0:POREF>
        <xsl:value-of select=""$var:v1"" />
      </ns0:POREF>
      <xsl:if test=""IDOC/E1EDK01/BELNR"">
        <ns0:PONUM>
          <xsl:value-of select=""IDOC/E1EDK01/BELNR/text()"" />
        </ns0:PONUM>
      </xsl:if>
    </ns0:biz_PO_Set_PO_Number>
  </xsl:template>
  <msxsl:script language=""VB"" implements-prefix=""userVB""><![CDATA[
Public Function MyConcat(ByVal POREF As String) As Integer
	Return System.Convert.ToInt64(POREF)
End Function



]]></msxsl:script>
</xsl:stylesheet>";
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"MFM.Lbg.Schemas.ORDERS05_ZMM158ORDERS";
        
        private const global::MFM.Lbg.Schemas.ORDERS05_ZMM158ORDERS _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"MFM.Lbg.Schemas.VFM_POTypedProcedure_dbo1+biz_PO_Set_PO_Number";
        
        private const global::MFM.Lbg.Schemas.VFM_POTypedProcedure_dbo1.biz_PO_Set_PO_Number _trgSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"MFM.Lbg.Schemas.ORDERS05_ZMM158ORDERS";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"MFM.Lbg.Schemas.VFM_POTypedProcedure_dbo1+biz_PO_Set_PO_Number";
                return _TrgSchemas;
            }
        }
    }
}
