namespace MFM.Lbg.Orcs {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"MFM.Lbg.Schemas.VFM_SOTypedProcedure_dbo+biz_SO_Get_HeaderResponse", typeof(global::MFM.Lbg.Schemas.VFM_SOTypedProcedure_dbo.biz_SO_Get_HeaderResponse))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"MFM.Lbg.Schemas.VFM_SOTypedProcedure_dbo+biz_SO_Get_DataSetResponse", typeof(global::MFM.Lbg.Schemas.VFM_SOTypedProcedure_dbo.biz_SO_Get_DataSetResponse))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"MFM.Lbg.Schemas.ORDERS_Z139ORDERS", typeof(global::MFM.Lbg.Schemas.ORDERS_Z139ORDERS))]
    public sealed class map_to_Z139ORDERS : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s2 s1 s3 s0"" version=""1.0"" xmlns:s2=""http://schemas.microsoft.com/Sql/2008/05/ProceduresResultSets/dbo/biz_SO_Get_Header"" xmlns:s1=""http://schemas.microsoft.com/BizTalk/2003/aggschema"" xmlns:s3=""http://schemas.microsoft.com/Sql/2008/05/ProceduresResultSets/dbo/biz_SO_Get_DataSet"" xmlns:s0=""http://schemas.microsoft.com/Sql/2008/05/TypedProcedures/dbo"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s1:Root"" />
  </xsl:template>
  <xsl:template match=""/s1:Root"">
    <Z139ORDERS>
      <IDOC>
        <EDI_DC40>
          <TABNAM>
            <xsl:text>EDI_DC40</xsl:text>
          </TABNAM>
          <IDOCTYP>
            <xsl:text>ORDERS05</xsl:text>
          </IDOCTYP>
          <CIMTYP>
            <xsl:text>Z139ORDERS</xsl:text>
          </CIMTYP>
        </EDI_DC40>
      </IDOC>
    </Z139ORDERS>
  </xsl:template>
</xsl:stylesheet>";
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"MFM.Lbg.Schemas.VFM_SOTypedProcedure_dbo+biz_SO_Get_HeaderResponse";
        
        private const global::MFM.Lbg.Schemas.VFM_SOTypedProcedure_dbo.biz_SO_Get_HeaderResponse _srcSchemaTypeReference0 = null;
        
        private const string _strSrcSchemasList1 = @"MFM.Lbg.Schemas.VFM_SOTypedProcedure_dbo+biz_SO_Get_DataSetResponse";
        
        private const global::MFM.Lbg.Schemas.VFM_SOTypedProcedure_dbo.biz_SO_Get_DataSetResponse _srcSchemaTypeReference1 = null;
        
        private const string _strTrgSchemasList0 = @"MFM.Lbg.Schemas.ORDERS_Z139ORDERS";
        
        private const global::MFM.Lbg.Schemas.ORDERS_Z139ORDERS _trgSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"MFM.Lbg.Schemas.VFM_SOTypedProcedure_dbo+biz_SO_Get_HeaderResponse";
                _SrcSchemas[1] = @"MFM.Lbg.Schemas.VFM_SOTypedProcedure_dbo+biz_SO_Get_DataSetResponse";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"MFM.Lbg.Schemas.ORDERS_Z139ORDERS";
                return _TrgSchemas;
            }
        }
    }
}
