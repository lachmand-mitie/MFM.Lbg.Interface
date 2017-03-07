namespace MFM.Lbg.Orcs {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"MFM.Lbg.Schemas.INFREC01_ZMM229_INFREC", typeof(global::MFM.Lbg.Schemas.INFREC01_ZMM229_INFREC))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"MFM.Lbg.Schemas.SAPM_TypedProcedure_dbo+Merge_Pricing", typeof(global::MFM.Lbg.Schemas.SAPM_TypedProcedure_dbo.Merge_Pricing))]
    public sealed class map_x_to_Merge_pir : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var userVB"" version=""1.0"" xmlns:ns4=""http://schemas.microsoft.com/Sql/2008/05/ProceduresResultSets/dbo/Merge_Material"" xmlns:ns5=""http://schemas.microsoft.com/Sql/2008/05/ProceduresResultSets/dbo/Merge_Pricing"" xmlns:ns0=""http://schemas.microsoft.com/Sql/2008/05/TypedProcedures/dbo"" xmlns:ns3=""http://schemas.microsoft.com/Sql/2008/05/Types/TableTypes/dbo"" xmlns:userVB=""http://schemas.microsoft.com/BizTalk/2003/userVB"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/ZMM229_INFREC"" />
  </xsl:template>
  <xsl:template match=""/ZMM229_INFREC"">
    <ns0:Merge_Pricing>
      <ns0:pricing>
        <xsl:for-each select=""IDOC/E1EINAM/E1EINEM"">
          <ns3:biz_udtt_pricing_import>
            <xsl:if test=""../MSGFN"">
              <ns3:MSGFN>
                <xsl:value-of select=""../MSGFN/text()"" />
              </ns3:MSGFN>
            </xsl:if>
            <xsl:if test=""../INFNR"">
              <ns3:INFNR>
                <xsl:value-of select=""../INFNR/text()"" />
              </ns3:INFNR>
            </xsl:if>
            <xsl:if test=""../MATNR"">
              <ns3:MATNR>
                <xsl:value-of select=""../MATNR/text()"" />
              </ns3:MATNR>
            </xsl:if>
            <xsl:if test=""../LIFNR"">
              <ns3:LIFNR>
                <xsl:value-of select=""../LIFNR/text()"" />
              </ns3:LIFNR>
            </xsl:if>
            <xsl:if test=""../ERDAT"">
              <ns3:ERDAT>
                <xsl:value-of select=""../ERDAT/text()"" />
              </ns3:ERDAT>
            </xsl:if>
            <xsl:if test=""../ERNAM"">
              <ns3:ERNAM>
                <xsl:value-of select=""../ERNAM/text()"" />
              </ns3:ERNAM>
            </xsl:if>
            <xsl:if test=""../MEINS"">
              <ns3:MEINS>
                <xsl:value-of select=""../MEINS/text()"" />
              </ns3:MEINS>
            </xsl:if>
            <xsl:if test=""../UMREZ"">
              <ns3:UMREZ>
                <xsl:value-of select=""../UMREZ/text()"" />
              </ns3:UMREZ>
            </xsl:if>
            <xsl:if test=""../UMREN"">
              <ns3:UMREN>
                <xsl:value-of select=""../UMREN/text()"" />
              </ns3:UMREN>
            </xsl:if>
            <xsl:if test=""../IDNLF"">
              <ns3:IDNLF>
                <xsl:value-of select=""../IDNLF/text()"" />
              </ns3:IDNLF>
            </xsl:if>
            <xsl:if test=""../MAHN1"">
              <ns3:MAHN1>
                <xsl:value-of select=""../MAHN1/text()"" />
              </ns3:MAHN1>
            </xsl:if>
            <xsl:if test=""../MAHN2"">
              <ns3:MAHN2>
                <xsl:value-of select=""../MAHN2/text()"" />
              </ns3:MAHN2>
            </xsl:if>
            <xsl:if test=""../MAHN3"">
              <ns3:MAHN3>
                <xsl:value-of select=""../MAHN3/text()"" />
              </ns3:MAHN3>
            </xsl:if>
            <xsl:if test=""../URZDT"">
              <ns3:URZDT>
                <xsl:value-of select=""../URZDT/text()"" />
              </ns3:URZDT>
            </xsl:if>
            <xsl:if test=""../URZLA"">
              <ns3:URZLA>
                <xsl:value-of select=""../URZLA/text()"" />
              </ns3:URZLA>
            </xsl:if>
            <xsl:if test=""../LMEIN"">
              <ns3:LMEIN>
                <xsl:value-of select=""../LMEIN/text()"" />
              </ns3:LMEIN>
            </xsl:if>
            <xsl:if test=""../LTSSF"">
              <ns3:LTSSF>
                <xsl:value-of select=""../LTSSF/text()"" />
              </ns3:LTSSF>
            </xsl:if>
            <xsl:if test=""../LIFAB"">
              <ns3:LIFAB>
                <xsl:value-of select=""../LIFAB/text()"" />
              </ns3:LIFAB>
            </xsl:if>
            <xsl:if test=""../LIFBI"">
              <ns3:LIFBI>
                <xsl:value-of select=""../LIFBI/text()"" />
              </ns3:LIFBI>
            </xsl:if>
            <xsl:if test=""../ANZPU"">
              <ns3:ANZPU>
                <xsl:value-of select=""../ANZPU/text()"" />
              </ns3:ANZPU>
            </xsl:if>
            <xsl:if test=""../Z1ZMM229_EINA/MAKTX"">
              <ns3:MAKTX>
                <xsl:value-of select=""../Z1ZMM229_EINA/MAKTX/text()"" />
              </ns3:MAKTX>
            </xsl:if>
            <xsl:if test=""EKORG"">
              <ns3:EKORG>
                <xsl:value-of select=""EKORG/text()"" />
              </ns3:EKORG>
            </xsl:if>
            <xsl:if test=""ESOKZ"">
              <ns3:ESOKZ>
                <xsl:value-of select=""ESOKZ/text()"" />
              </ns3:ESOKZ>
            </xsl:if>
            <xsl:if test=""WAERS"">
              <ns3:WAERS>
                <xsl:value-of select=""WAERS/text()"" />
              </ns3:WAERS>
            </xsl:if>
            <xsl:if test=""MINBM"">
              <ns3:MINBM>
                <xsl:value-of select=""MINBM/text()"" />
              </ns3:MINBM>
            </xsl:if>
            <xsl:if test=""NORBM"">
              <ns3:NORBM>
                <xsl:value-of select=""NORBM/text()"" />
              </ns3:NORBM>
            </xsl:if>
            <xsl:if test=""APLFZ"">
              <ns3:APLFZ>
                <xsl:value-of select=""APLFZ/text()"" />
              </ns3:APLFZ>
            </xsl:if>
            <xsl:if test=""UEBTO"">
              <ns3:UEBTO>
                <xsl:value-of select=""UEBTO/text()"" />
              </ns3:UEBTO>
            </xsl:if>
            <xsl:if test=""UNTTO"">
              <ns3:UNTTO>
                <xsl:value-of select=""UNTTO/text()"" />
              </ns3:UNTTO>
            </xsl:if>
            <xsl:if test=""ANGDT"">
              <ns3:ANGDT>
                <xsl:value-of select=""ANGDT/text()"" />
              </ns3:ANGDT>
            </xsl:if>
            <xsl:if test=""NETPR"">
              <ns3:NETPR>
                <xsl:value-of select=""NETPR/text()"" />
              </ns3:NETPR>
            </xsl:if>
            <xsl:if test=""PEINH"">
              <ns3:PEINH>
                <xsl:value-of select=""PEINH/text()"" />
              </ns3:PEINH>
            </xsl:if>
            <xsl:if test=""BPRME"">
              <ns3:BPRME>
                <xsl:value-of select=""BPRME/text()"" />
              </ns3:BPRME>
            </xsl:if>
            <xsl:if test=""PRDAT"">
              <ns3:PRDAT>
                <xsl:value-of select=""PRDAT/text()"" />
              </ns3:PRDAT>
            </xsl:if>
            <xsl:if test=""BPUMZ"">
              <ns3:BPUMZ>
                <xsl:value-of select=""BPUMZ/text()"" />
              </ns3:BPUMZ>
            </xsl:if>
            <xsl:if test=""BPUMN"">
              <ns3:BPUMN>
                <xsl:value-of select=""BPUMN/text()"" />
              </ns3:BPUMN>
            </xsl:if>
            <xsl:if test=""EFFPR"">
              <ns3:EFFPR>
                <xsl:value-of select=""EFFPR/text()"" />
              </ns3:EFFPR>
            </xsl:if>
            <xsl:if test=""LOEKZ"">
              <ns3:MHDRZ>
                <xsl:value-of select=""LOEKZ/text()"" />
              </ns3:MHDRZ>
            </xsl:if>
            <xsl:variable name=""var:v1"" select=""userVB:GetPirIdocNum(string(../../EDI_DC40/DOCNUM/text()))"" />
            <ns3:BSTMA>
              <xsl:value-of select=""$var:v1"" />
            </ns3:BSTMA>
            <xsl:value-of select=""../text()"" />
          </ns3:biz_udtt_pricing_import>
        </xsl:for-each>
      </ns0:pricing>
      <xsl:value-of select=""./text()"" />
    </ns0:Merge_Pricing>
  </xsl:template>
  <msxsl:script language=""VB"" implements-prefix=""userVB""><![CDATA[
Public Function GetPirIdocNum(ByVal param1 As String) As String
	Return System.Convert.ToInt64(param1).tostring
End Function



]]></msxsl:script>
</xsl:stylesheet>";
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"MFM.Lbg.Schemas.INFREC01_ZMM229_INFREC";
        
        private const global::MFM.Lbg.Schemas.INFREC01_ZMM229_INFREC _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"MFM.Lbg.Schemas.SAPM_TypedProcedure_dbo+Merge_Pricing";
        
        private const global::MFM.Lbg.Schemas.SAPM_TypedProcedure_dbo.Merge_Pricing _trgSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"MFM.Lbg.Schemas.INFREC01_ZMM229_INFREC";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"MFM.Lbg.Schemas.SAPM_TypedProcedure_dbo+Merge_Pricing";
                return _TrgSchemas;
            }
        }
    }
}
