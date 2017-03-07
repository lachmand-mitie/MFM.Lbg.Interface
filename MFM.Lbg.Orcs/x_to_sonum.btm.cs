namespace MFM.Lbg.Orcs {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"MFM.Lbg.Schemas.INVOIC02", typeof(global::MFM.Lbg.Schemas.INVOIC02))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"MFM.Lbg.Schemas.VFM_SOTypedProcedure_dbo+biz_SO_Set_SO_Number", typeof(global::MFM.Lbg.Schemas.VFM_SOTypedProcedure_dbo.biz_SO_Set_SO_Number))]
    public sealed class x_to_sonum : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var userCSharp"" version=""1.0"" xmlns:ns3=""http://schemas.microsoft.com/Sql/2008/05/ProceduresResultSets/dbo/biz_SO_Get_DataSet"" xmlns:ns0=""http://schemas.microsoft.com/Sql/2008/05/TypedProcedures/dbo"" xmlns:ns4=""http://schemas.microsoft.com/Sql/2008/05/ProceduresResultSets/dbo/biz_SO_Get_Header"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/INVOIC02"" />
  </xsl:template>
  <xsl:template match=""/INVOIC02"">
    <ns0:biz_SO_Set_SO_Number>
      <xsl:for-each select=""IDOC/E1EDK02"">
        <xsl:variable name=""var:v1"" select=""userCSharp:LogicalEq(string(QUALF/text()) , &quot;001&quot;)"" />
        <xsl:if test=""string($var:v1)='true'"">
          <xsl:variable name=""var:v2"" select=""BELNR/text()"" />
          <ns0:SOREF>
            <xsl:value-of select=""$var:v2"" />
          </ns0:SOREF>
        </xsl:if>
      </xsl:for-each>
      <xsl:if test=""IDOC/E1EDK01/BELNR"">
        <ns0:SONUM>
          <xsl:value-of select=""IDOC/E1EDK01/BELNR/text()"" />
        </ns0:SONUM>
      </xsl:if>
      <xsl:value-of select=""IDOC/text()"" />
    </ns0:biz_SO_Set_SO_Number>
  </xsl:template>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp""><![CDATA[
public bool LogicalEq(string val1, string val2)
{
	bool ret = false;
	double d1 = 0;
	double d2 = 0;
	if (IsNumeric(val1, ref d1) && IsNumeric(val2, ref d2))
	{
		ret = d1 == d2;
	}
	else
	{
		ret = String.Compare(val1, val2, StringComparison.Ordinal) == 0;
	}
	return ret;
}


public bool IsNumeric(string val)
{
	if (val == null)
	{
		return false;
	}
	double d = 0;
	return Double.TryParse(val, System.Globalization.NumberStyles.AllowThousands | System.Globalization.NumberStyles.Float, System.Globalization.CultureInfo.InvariantCulture, out d);
}

public bool IsNumeric(string val, ref double d)
{
	if (val == null)
	{
		return false;
	}
	return Double.TryParse(val, System.Globalization.NumberStyles.AllowThousands | System.Globalization.NumberStyles.Float, System.Globalization.CultureInfo.InvariantCulture, out d);
}


]]></msxsl:script>
</xsl:stylesheet>";
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"MFM.Lbg.Schemas.INVOIC02";
        
        private const global::MFM.Lbg.Schemas.INVOIC02 _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"MFM.Lbg.Schemas.VFM_SOTypedProcedure_dbo+biz_SO_Set_SO_Number";
        
        private const global::MFM.Lbg.Schemas.VFM_SOTypedProcedure_dbo.biz_SO_Set_SO_Number _trgSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"MFM.Lbg.Schemas.INVOIC02";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"MFM.Lbg.Schemas.VFM_SOTypedProcedure_dbo+biz_SO_Set_SO_Number";
                return _TrgSchemas;
            }
        }
    }
}
