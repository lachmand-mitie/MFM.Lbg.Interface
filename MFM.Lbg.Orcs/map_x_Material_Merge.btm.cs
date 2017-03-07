namespace MFM.Lbg.Orcs {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"MFM.Lbg.Schemas.MATMAS04", typeof(global::MFM.Lbg.Schemas.MATMAS04))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"MFM.Lbg.Schemas.SAPM_TypedProcedure_dbo+Merge_Material", typeof(global::MFM.Lbg.Schemas.SAPM_TypedProcedure_dbo.Merge_Material))]
    public sealed class map_x_Material_Merge : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var userVB"" version=""1.0"" xmlns:ns4=""http://schemas.microsoft.com/Sql/2008/05/ProceduresResultSets/dbo/Merge_Material"" xmlns:ns5=""http://schemas.microsoft.com/Sql/2008/05/ProceduresResultSets/dbo/Merge_Pricing"" xmlns:ns0=""http://schemas.microsoft.com/Sql/2008/05/TypedProcedures/dbo"" xmlns:ns3=""http://schemas.microsoft.com/Sql/2008/05/Types/TableTypes/dbo"" xmlns:userVB=""http://schemas.microsoft.com/BizTalk/2003/userVB"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/MATMAS04"" />
  </xsl:template>
  <xsl:template match=""/MATMAS04"">
    <ns0:Merge_Material>
      <ns0:materials>
        <xsl:for-each select=""IDOC/E1MARAM"">
          <xsl:for-each select=""E1MAKTM"">
            <ns3:biz_udtt_material_import>
              <xsl:if test=""../MSGFN"">
                <ns3:MSGFN>
                  <xsl:value-of select=""../MSGFN/text()"" />
                </ns3:MSGFN>
              </xsl:if>
              <xsl:if test=""../MATNR"">
                <ns3:MATNR>
                  <xsl:value-of select=""../MATNR/text()"" />
                </ns3:MATNR>
              </xsl:if>
              <xsl:if test=""../ERSDA"">
                <ns3:ERSDA>
                  <xsl:value-of select=""../ERSDA/text()"" />
                </ns3:ERSDA>
              </xsl:if>
              <xsl:if test=""../ERNAM"">
                <ns3:ERNAM>
                  <xsl:value-of select=""../ERNAM/text()"" />
                </ns3:ERNAM>
              </xsl:if>
              <xsl:if test=""../LAEDA"">
                <ns3:LAEDA>
                  <xsl:value-of select=""../LAEDA/text()"" />
                </ns3:LAEDA>
              </xsl:if>
              <xsl:if test=""../AENAM"">
                <ns3:AENAM>
                  <xsl:value-of select=""../AENAM/text()"" />
                </ns3:AENAM>
              </xsl:if>
              <xsl:if test=""../PSTAT"">
                <ns3:PSTAT>
                  <xsl:value-of select=""../PSTAT/text()"" />
                </ns3:PSTAT>
              </xsl:if>
              <xsl:if test=""../MTART"">
                <ns3:MTART>
                  <xsl:value-of select=""../MTART/text()"" />
                </ns3:MTART>
              </xsl:if>
              <xsl:if test=""../MBRSH"">
                <ns3:MBRSH>
                  <xsl:value-of select=""../MBRSH/text()"" />
                </ns3:MBRSH>
              </xsl:if>
              <xsl:if test=""../MATKL"">
                <ns3:MATKL>
                  <xsl:value-of select=""../MATKL/text()"" />
                </ns3:MATKL>
              </xsl:if>
              <xsl:if test=""../BISMT"">
                <ns3:BISMT>
                  <xsl:value-of select=""../BISMT/text()"" />
                </ns3:BISMT>
              </xsl:if>
              <xsl:if test=""../MEINS"">
                <ns3:MEINS>
                  <xsl:value-of select=""../MEINS/text()"" />
                </ns3:MEINS>
              </xsl:if>
              <xsl:if test=""../BLANZ"">
                <ns3:BLANZ>
                  <xsl:value-of select=""../BLANZ/text()"" />
                </ns3:BLANZ>
              </xsl:if>
              <xsl:if test=""../BRGEW"">
                <ns3:BRGEW>
                  <xsl:value-of select=""../BRGEW/text()"" />
                </ns3:BRGEW>
              </xsl:if>
              <xsl:if test=""../NTGEW"">
                <ns3:NTGEW>
                  <xsl:value-of select=""../NTGEW/text()"" />
                </ns3:NTGEW>
              </xsl:if>
              <xsl:if test=""../GEWEI"">
                <ns3:GEWEI>
                  <xsl:value-of select=""../GEWEI/text()"" />
                </ns3:GEWEI>
              </xsl:if>
              <xsl:if test=""../VOLUM"">
                <ns3:VOLUM>
                  <xsl:value-of select=""../VOLUM/text()"" />
                </ns3:VOLUM>
              </xsl:if>
              <xsl:if test=""../WESCH"">
                <ns3:WESCH>
                  <xsl:value-of select=""../WESCH/text()"" />
                </ns3:WESCH>
              </xsl:if>
              <xsl:if test=""../LAENG"">
                <ns3:LAENG>
                  <xsl:value-of select=""../LAENG/text()"" />
                </ns3:LAENG>
              </xsl:if>
              <xsl:if test=""../BREIT"">
                <ns3:BREIT>
                  <xsl:value-of select=""../BREIT/text()"" />
                </ns3:BREIT>
              </xsl:if>
              <xsl:if test=""../HOEHE"">
                <ns3:HOEHE>
                  <xsl:value-of select=""../HOEHE/text()"" />
                </ns3:HOEHE>
              </xsl:if>
              <xsl:if test=""../ERGEW"">
                <ns3:ERGEW>
                  <xsl:value-of select=""../ERGEW/text()"" />
                </ns3:ERGEW>
              </xsl:if>
              <xsl:if test=""../ERVOL"">
                <ns3:ERVOL>
                  <xsl:value-of select=""../ERVOL/text()"" />
                </ns3:ERVOL>
              </xsl:if>
              <xsl:if test=""../GEWTO"">
                <ns3:GEWTO>
                  <xsl:value-of select=""../GEWTO/text()"" />
                </ns3:GEWTO>
              </xsl:if>
              <xsl:if test=""../VOLTO"">
                <ns3:FUELG>
                  <xsl:value-of select=""../VOLTO/text()"" />
                </ns3:FUELG>
              </xsl:if>
              <xsl:if test=""../STFAK"">
                <ns3:STFAK>
                  <xsl:value-of select=""../STFAK/text()"" />
                </ns3:STFAK>
              </xsl:if>
              <xsl:if test=""../MHDRZ"">
                <ns3:MHDRZ>
                  <xsl:value-of select=""../MHDRZ/text()"" />
                </ns3:MHDRZ>
              </xsl:if>
              <xsl:if test=""../MHDHB"">
                <ns3:MHDHB>
                  <xsl:value-of select=""../MHDHB/text()"" />
                </ns3:MHDHB>
              </xsl:if>
              <xsl:if test=""../MHDLP"">
                <ns3:MHDLP>
                  <xsl:value-of select=""../MHDLP/text()"" />
                </ns3:MHDLP>
              </xsl:if>
              <xsl:if test=""../VPSTA"">
                <ns3:VPSTA>
                  <xsl:value-of select=""../VPSTA/text()"" />
                </ns3:VPSTA>
              </xsl:if>
              <xsl:if test=""../MSTDE"">
                <ns3:MSTDE>
                  <xsl:value-of select=""../MSTDE/text()"" />
                </ns3:MSTDE>
              </xsl:if>
              <xsl:if test=""../MSTDV"">
                <ns3:MSTDV>
                  <xsl:value-of select=""../MSTDV/text()"" />
                </ns3:MSTDV>
              </xsl:if>
              <xsl:if test=""../MTPOS_MARA"">
                <ns3:MTPOS_MARA>
                  <xsl:value-of select=""../MTPOS_MARA/text()"" />
                </ns3:MTPOS_MARA>
              </xsl:if>
              <xsl:if test=""../GEWTO_NEW"">
                <ns3:GEWTO_NEW>
                  <xsl:value-of select=""../GEWTO_NEW/text()"" />
                </ns3:GEWTO_NEW>
              </xsl:if>
              <xsl:if test=""../VOLTO_NEW"">
                <ns3:VOLTO_NEW>
                  <xsl:value-of select=""../VOLTO_NEW/text()"" />
                </ns3:VOLTO_NEW>
              </xsl:if>
              <xsl:if test=""SPRAS"">
                <ns3:SPRAS>
                  <xsl:value-of select=""SPRAS/text()"" />
                </ns3:SPRAS>
              </xsl:if>
              <xsl:if test=""MAKTX"">
                <ns3:MAKTX>
                  <xsl:value-of select=""MAKTX/text()"" />
                </ns3:MAKTX>
              </xsl:if>
              <xsl:if test=""../E1MARCM/WERKS"">
                <ns3:WERKS>
                  <xsl:value-of select=""../E1MARCM/WERKS/text()"" />
                </ns3:WERKS>
              </xsl:if>
              <xsl:if test=""../E1MARCM/LVORM"">
                <ns3:PERKZ>
                  <xsl:value-of select=""../E1MARCM/LVORM/text()"" />
                </ns3:PERKZ>
              </xsl:if>
              <xsl:variable name=""var:v1"" select=""userVB:GetMatIdocNum(string(../../EDI_DC40/DOCNUM/text()))"" />
              <ns3:LTINC>
                <xsl:value-of select=""$var:v1"" />
              </ns3:LTINC>
              <xsl:value-of select=""../text()"" />
            </ns3:biz_udtt_material_import>
          </xsl:for-each>
        </xsl:for-each>
        <xsl:value-of select=""./text()"" />
      </ns0:materials>
    </ns0:Merge_Material>
  </xsl:template>
  <msxsl:script language=""VB"" implements-prefix=""userVB""><![CDATA[
Public Function GetMatIdocNum(ByVal param1 As String) As String
	Return System.Convert.ToInt64(param1).tostring
End Function



]]></msxsl:script>
</xsl:stylesheet>";
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"MFM.Lbg.Schemas.MATMAS04";
        
        private const global::MFM.Lbg.Schemas.MATMAS04 _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"MFM.Lbg.Schemas.SAPM_TypedProcedure_dbo+Merge_Material";
        
        private const global::MFM.Lbg.Schemas.SAPM_TypedProcedure_dbo.Merge_Material _trgSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"MFM.Lbg.Schemas.MATMAS04";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"MFM.Lbg.Schemas.SAPM_TypedProcedure_dbo+Merge_Material";
                return _TrgSchemas;
            }
        }
    }
}
