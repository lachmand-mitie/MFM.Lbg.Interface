namespace MFM.Lbg.Maps {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"MFM.Lbg.Schemas.MFMWorkItemUpdate", typeof(global::MFM.Lbg.Schemas.MFMWorkItemUpdate))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"MFM.Lbg.Schemas.Add_Asset_UdttTableType_ops+ArrayOfudtt_Asset", typeof(global::MFM.Lbg.Schemas.Add_Asset_UdttTableType_ops.ArrayOfudtt_Asset))]
    public sealed class m_to_NewUdttAsset : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 userCSharp ScriptNS0 ScriptNS1"" version=""1.0"" xmlns:s0=""http://MFM.Lbg.Schemas.MFMWorkItemUpdate"" xmlns:ns0=""http://schemas.microsoft.com/Sql/2008/05/Types/TableTypes/ops"" xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"" xmlns:ScriptNS0=""http://schemas.microsoft.com/BizTalk/2003/ScriptNS0"" xmlns:ScriptNS1=""http://schemas.microsoft.com/BizTalk/2003/ScriptNS1"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:MFMWorkItemUpdate"" />
  </xsl:template>
  <xsl:template match=""/s0:MFMWorkItemUpdate"">
    <xsl:variable name=""var:v1"" select=""userCSharp:DateCurrentDateTime()"" />
    <xsl:variable name=""var:v11"" select=""string(Meta_RF01/text())"" />
    <xsl:variable name=""var:v20"" select=""userCSharp:StringConcat(string(WI_LocationLevel3/text()) , &quot;-&quot; , string(WI_LocationLevel4/text()))"" />
    <xsl:variable name=""var:v31"" select=""string(WI_LocationLevel3/text())"" />
    <xsl:variable name=""var:v32"" select=""string(WI_LocationLevel4/text())"" />
    <xsl:variable name=""var:v33"" select=""userCSharp:StringConcat($var:v31 , &quot;-&quot; , $var:v32)"" />
    <xsl:variable name=""var:v41"" select=""userCSharp:StringConcat(&quot;INUSE&quot;)"" />
    <xsl:variable name=""var:v45"" select=""userCSharp:StringConcat(string(WI_SourceRef/text()) , &quot;-&quot; , string(WI_Status/text()) , &quot;-&quot; , $var:v31 , &quot;-&quot; , string(SourceSystemMessageId/text()))"" />
    <ns0:ArrayOfudtt_Asset>
      <ns0:udtt_Asset>
        <ns0:Asst_AssetID>
          <xsl:attribute name=""xsi:nil"">
            <xsl:value-of select=""'true'"" />
          </xsl:attribute>
        </ns0:Asst_AssetID>
        <ns0:Asst_CreatedBy>
          <xsl:text>13442</xsl:text>
        </ns0:Asst_CreatedBy>
        <ns0:Asst_CreatedDate>
          <xsl:value-of select=""$var:v1"" />
        </ns0:Asst_CreatedDate>
        <ns0:Asst_UpdatedBy>
          <xsl:text>13442</xsl:text>
        </ns0:Asst_UpdatedBy>
        <ns0:Asst_UpdatedDate>
          <xsl:value-of select=""$var:v1"" />
        </ns0:Asst_UpdatedDate>
        <ns0:Asst_TimeStamp>
          <xsl:value-of select=""$var:v1"" />
        </ns0:Asst_TimeStamp>
        <ns0:Asst_Deleted>
          <xsl:attribute name=""xsi:nil"">
            <xsl:value-of select=""'true'"" />
          </xsl:attribute>
        </ns0:Asst_Deleted>
        <xsl:variable name=""var:v2"" select=""ScriptNS0:VisionFMLookupConnectionString()"" />
        <xsl:variable name=""var:v3"" select=""ScriptNS1:DBLookup(0 , string(Meta_RF01/text()) , string($var:v2) , &quot;[ops].[vMTFMAssetTemplates]&quot; , &quot;AssetSubTypeTypeCode&quot;)"" />
        <xsl:variable name=""var:v4"" select=""ScriptNS1:DBValueExtract(string($var:v3) , &quot;AssetSubTypeName&quot;)"" />
        <xsl:variable name=""var:v5"" select=""userCSharp:LogicalNe(string($var:v4) , &quot;&quot;)"" />
        <xsl:if test=""string($var:v5)='true'"">
          <xsl:variable name=""var:v6"" select=""ScriptNS0:VisionFMLookupConnectionString()"" />
          <xsl:variable name=""var:v7"" select=""string(Meta_RF01/text())"" />
          <xsl:variable name=""var:v8"" select=""ScriptNS1:DBLookup(0 , $var:v7 , string($var:v6) , &quot;[ops].[vMTFMAssetTemplates]&quot; , &quot;AssetSubTypeTypeCode&quot;)"" />
          <xsl:variable name=""var:v9"" select=""ScriptNS1:DBValueExtract(string($var:v8) , &quot;AssetSubTypeName&quot;)"" />
          <ns0:asst_Description>
            <xsl:value-of select=""$var:v9"" />
          </ns0:asst_Description>
        </xsl:if>
        <xsl:variable name=""var:v10"" select=""ScriptNS0:VisionFMLookupConnectionString()"" />
        <xsl:variable name=""var:v12"" select=""ScriptNS1:DBLookup(0 , $var:v11 , string($var:v10) , &quot;[ops].[vMTFMAssetTemplates]&quot; , &quot;AssetSubTypeTypeCode&quot;)"" />
        <xsl:variable name=""var:v13"" select=""ScriptNS1:DBValueExtract(string($var:v12) , &quot;AssetSubTypeId&quot;)"" />
        <xsl:variable name=""var:v14"" select=""userCSharp:LogicalIsNumeric(string($var:v13))"" />
        <xsl:if test=""string($var:v14)='true'"">
          <xsl:variable name=""var:v15"" select=""ScriptNS0:VisionFMLookupConnectionString()"" />
          <xsl:variable name=""var:v16"" select=""ScriptNS1:DBLookup(0 , $var:v11 , string($var:v15) , &quot;[ops].[vMTFMAssetTemplates]&quot; , &quot;AssetSubTypeTypeCode&quot;)"" />
          <xsl:variable name=""var:v17"" select=""ScriptNS1:DBValueExtract(string($var:v16) , &quot;AssetSubTypeId&quot;)"" />
          <ns0:asst_SubType>
            <xsl:value-of select=""$var:v17"" />
          </ns0:asst_SubType>
        </xsl:if>
        <ns0:asst_Generic>
          <xsl:attribute name=""xsi:nil"">
            <xsl:value-of select=""'true'"" />
          </xsl:attribute>
        </ns0:asst_Generic>
        <xsl:if test=""WI_AssetRef"">
          <xsl:variable name=""var:v18"" select=""string(WI_AssetRef/@xsi:nil) = 'true'"" />
          <xsl:if test=""string($var:v18)='true'"">
            <ns0:asst_ForeignSysId>
              <xsl:attribute name=""xsi:nil"">
                <xsl:value-of select=""'true'"" />
              </xsl:attribute>
            </ns0:asst_ForeignSysId>
          </xsl:if>
          <xsl:if test=""string($var:v18)='false'"">
            <ns0:asst_ForeignSysId>
              <xsl:value-of select=""WI_AssetRef/text()"" />
            </ns0:asst_ForeignSysId>
          </xsl:if>
        </xsl:if>
        <xsl:variable name=""var:v19"" select=""string(SourceSystem/@xsi:nil) = 'true'"" />
        <xsl:if test=""string($var:v19)='true'"">
          <ns0:asst_ForeignSysName>
            <xsl:attribute name=""xsi:nil"">
              <xsl:value-of select=""'true'"" />
            </xsl:attribute>
          </ns0:asst_ForeignSysName>
        </xsl:if>
        <xsl:if test=""string($var:v19)='false'"">
          <ns0:asst_ForeignSysName>
            <xsl:value-of select=""SourceSystem/text()"" />
          </ns0:asst_ForeignSysName>
        </xsl:if>
        <ns0:asst_CampusId>
          <xsl:attribute name=""xsi:nil"">
            <xsl:value-of select=""'true'"" />
          </xsl:attribute>
        </ns0:asst_CampusId>
        <xsl:variable name=""var:v21"" select=""ScriptNS0:VisionFMLookupConnectionString()"" />
        <xsl:variable name=""var:v22"" select=""ScriptNS1:DBLookup(1 , string($var:v20) , string($var:v21) , &quot;[ops].[vMTFMAssetLocations]&quot; , &quot;Building&quot;)"" />
        <xsl:variable name=""var:v23"" select=""ScriptNS1:DBValueExtract(string($var:v22) , &quot;AdLi_AddressId&quot;)"" />
        <xsl:variable name=""var:v24"" select=""userCSharp:LogicalIsNumeric(string($var:v23))"" />
        <xsl:if test=""string($var:v24)='true'"">
          <xsl:variable name=""var:v25"" select=""string(WI_LocationLevel3/text())"" />
          <xsl:variable name=""var:v26"" select=""string(WI_LocationLevel4/text())"" />
          <xsl:variable name=""var:v27"" select=""userCSharp:StringConcat($var:v25 , &quot;-&quot; , $var:v26)"" />
          <xsl:variable name=""var:v28"" select=""ScriptNS0:VisionFMLookupConnectionString()"" />
          <xsl:variable name=""var:v29"" select=""ScriptNS1:DBLookup(1 , string($var:v27) , string($var:v28) , &quot;[ops].[vMTFMAssetLocations]&quot; , &quot;Building&quot;)"" />
          <xsl:variable name=""var:v30"" select=""ScriptNS1:DBValueExtract(string($var:v29) , &quot;AdLi_AddressId&quot;)"" />
          <ns0:asst_BuildingId>
            <xsl:value-of select=""$var:v30"" />
          </ns0:asst_BuildingId>
        </xsl:if>
        <ns0:asst_AreaId>
          <xsl:attribute name=""xsi:nil"">
            <xsl:value-of select=""'true'"" />
          </xsl:attribute>
        </ns0:asst_AreaId>
        <ns0:asst_RoomId>
          <xsl:attribute name=""xsi:nil"">
            <xsl:value-of select=""'true'"" />
          </xsl:attribute>
        </ns0:asst_RoomId>
        <xsl:variable name=""var:v34"" select=""ScriptNS0:VisionFMLookupConnectionString()"" />
        <xsl:variable name=""var:v35"" select=""ScriptNS1:DBLookup(1 , string($var:v33) , string($var:v34) , &quot;[ops].[vMTFMAssetLocations]&quot; , &quot;Building&quot;)"" />
        <xsl:variable name=""var:v36"" select=""ScriptNS1:DBValueExtract(string($var:v35) , &quot;AdLi_AddressLinkId&quot;)"" />
        <xsl:variable name=""var:v37"" select=""userCSharp:LogicalIsNumeric(string($var:v36))"" />
        <xsl:if test=""string($var:v37)='true'"">
          <xsl:variable name=""var:v38"" select=""ScriptNS0:VisionFMLookupConnectionString()"" />
          <xsl:variable name=""var:v39"" select=""ScriptNS1:DBLookup(1 , string($var:v33) , string($var:v38) , &quot;[ops].[vMTFMAssetLocations]&quot; , &quot;Building&quot;)"" />
          <xsl:variable name=""var:v40"" select=""ScriptNS1:DBValueExtract(string($var:v39) , &quot;AdLi_AddressLinkId&quot;)"" />
          <ns0:asst_LocationId>
            <xsl:value-of select=""$var:v40"" />
          </ns0:asst_LocationId>
        </xsl:if>
        <ns0:asst_Manufacturer>
          <xsl:attribute name=""xsi:nil"">
            <xsl:value-of select=""'true'"" />
          </xsl:attribute>
        </ns0:asst_Manufacturer>
        <ns0:asst_model_number>
          <xsl:attribute name=""xsi:nil"">
            <xsl:value-of select=""'true'"" />
          </xsl:attribute>
        </ns0:asst_model_number>
        <ns0:asst_serialnumber>
          <xsl:attribute name=""xsi:nil"">
            <xsl:value-of select=""'true'"" />
          </xsl:attribute>
        </ns0:asst_serialnumber>
        <ns0:asst_date_of_manufacture>
          <xsl:attribute name=""xsi:nil"">
            <xsl:value-of select=""'true'"" />
          </xsl:attribute>
        </ns0:asst_date_of_manufacture>
        <ns0:asst_date_of_aquisition>
          <xsl:attribute name=""xsi:nil"">
            <xsl:value-of select=""'true'"" />
          </xsl:attribute>
        </ns0:asst_date_of_aquisition>
        <ns0:asst_Tag>
          <xsl:attribute name=""xsi:nil"">
            <xsl:value-of select=""'true'"" />
          </xsl:attribute>
        </ns0:asst_Tag>
        <ns0:asst_warranty_period>
          <xsl:attribute name=""xsi:nil"">
            <xsl:value-of select=""'true'"" />
          </xsl:attribute>
        </ns0:asst_warranty_period>
        <ns0:asst_multiple>
          <xsl:attribute name=""xsi:nil"">
            <xsl:value-of select=""'true'"" />
          </xsl:attribute>
        </ns0:asst_multiple>
        <ns0:asst_status>
          <xsl:value-of select=""$var:v41"" />
        </ns0:asst_status>
        <ns0:asst_initialvalue>
          <xsl:attribute name=""xsi:nil"">
            <xsl:value-of select=""'true'"" />
          </xsl:attribute>
        </ns0:asst_initialvalue>
        <ns0:asst_depreciationlength>
          <xsl:attribute name=""xsi:nil"">
            <xsl:value-of select=""'true'"" />
          </xsl:attribute>
        </ns0:asst_depreciationlength>
        <ns0:asst_ParentAssetId>
          <xsl:attribute name=""xsi:nil"">
            <xsl:value-of select=""'true'"" />
          </xsl:attribute>
        </ns0:asst_ParentAssetId>
        <ns0:asst_ValuationDate>
          <xsl:attribute name=""xsi:nil"">
            <xsl:value-of select=""'true'"" />
          </xsl:attribute>
        </ns0:asst_ValuationDate>
        <ns0:asst_IndicativeLifeExpectancy>
          <xsl:attribute name=""xsi:nil"">
            <xsl:value-of select=""'true'"" />
          </xsl:attribute>
        </ns0:asst_IndicativeLifeExpectancy>
        <ns0:asst_IndicativeReplacementCost>
          <xsl:attribute name=""xsi:nil"">
            <xsl:value-of select=""'true'"" />
          </xsl:attribute>
        </ns0:asst_IndicativeReplacementCost>
        <ns0:asst_ActualLifeExpectancy>
          <xsl:attribute name=""xsi:nil"">
            <xsl:value-of select=""'true'"" />
          </xsl:attribute>
        </ns0:asst_ActualLifeExpectancy>
        <ns0:asst_LastSurveyedExpectancy>
          <xsl:attribute name=""xsi:nil"">
            <xsl:value-of select=""'true'"" />
          </xsl:attribute>
        </ns0:asst_LastSurveyedExpectancy>
        <ns0:asst_ConditionCode>
          <xsl:attribute name=""xsi:nil"">
            <xsl:value-of select=""'true'"" />
          </xsl:attribute>
        </ns0:asst_ConditionCode>
        <ns0:asst_PriorityCode>
          <xsl:attribute name=""xsi:nil"">
            <xsl:value-of select=""'true'"" />
          </xsl:attribute>
        </ns0:asst_PriorityCode>
        <ns0:asst_1DBarcode>
          <xsl:attribute name=""xsi:nil"">
            <xsl:value-of select=""'true'"" />
          </xsl:attribute>
        </ns0:asst_1DBarcode>
        <ns0:asst_RegNo>
          <xsl:attribute name=""xsi:nil"">
            <xsl:value-of select=""'true'"" />
          </xsl:attribute>
        </ns0:asst_RegNo>
        <ns0:asst_Survey>
          <xsl:attribute name=""xsi:nil"">
            <xsl:value-of select=""'true'"" />
          </xsl:attribute>
        </ns0:asst_Survey>
        <ns0:asst_Responsibility>
          <xsl:attribute name=""xsi:nil"">
            <xsl:value-of select=""'true'"" />
          </xsl:attribute>
        </ns0:asst_Responsibility>
        <ns0:asst_ClientPersonId>
          <xsl:attribute name=""xsi:nil"">
            <xsl:value-of select=""'true'"" />
          </xsl:attribute>
        </ns0:asst_ClientPersonId>
        <xsl:if test=""Meta_RF09"">
          <xsl:variable name=""var:v42"" select=""string(Meta_RF09/@xsi:nil) = 'true'"" />
          <xsl:if test=""string($var:v42)='true'"">
            <ns0:asst_SupplierCompanyId>
              <xsl:attribute name=""xsi:nil"">
                <xsl:value-of select=""'true'"" />
              </xsl:attribute>
            </ns0:asst_SupplierCompanyId>
          </xsl:if>
          <xsl:if test=""string($var:v42)='false'"">
            <ns0:asst_SupplierCompanyId>
              <xsl:value-of select=""Meta_RF09/text()"" />
            </ns0:asst_SupplierCompanyId>
          </xsl:if>
        </xsl:if>
        <xsl:if test=""Meta_RF10"">
          <xsl:variable name=""var:v43"" select=""string(Meta_RF10/@xsi:nil) = 'true'"" />
          <xsl:if test=""string($var:v43)='true'"">
            <ns0:asst_SupplierDivisionId>
              <xsl:attribute name=""xsi:nil"">
                <xsl:value-of select=""'true'"" />
              </xsl:attribute>
            </ns0:asst_SupplierDivisionId>
          </xsl:if>
          <xsl:if test=""string($var:v43)='false'"">
            <ns0:asst_SupplierDivisionId>
              <xsl:value-of select=""Meta_RF10/text()"" />
            </ns0:asst_SupplierDivisionId>
          </xsl:if>
        </xsl:if>
        <ns0:asst_EndDate>
          <xsl:attribute name=""xsi:nil"">
            <xsl:value-of select=""'true'"" />
          </xsl:attribute>
        </ns0:asst_EndDate>
        <xsl:if test=""Meta_RF11"">
          <xsl:variable name=""var:v44"" select=""string(Meta_RF11/@xsi:nil) = 'true'"" />
          <xsl:if test=""string($var:v44)='true'"">
            <ns0:asst_StartDate>
              <xsl:attribute name=""xsi:nil"">
                <xsl:value-of select=""'true'"" />
              </xsl:attribute>
            </ns0:asst_StartDate>
          </xsl:if>
          <xsl:if test=""string($var:v44)='false'"">
            <ns0:asst_StartDate>
              <xsl:value-of select=""Meta_RF11/text()"" />
            </ns0:asst_StartDate>
          </xsl:if>
        </xsl:if>
        <ns0:asst_RowGuid>
          <xsl:attribute name=""xsi:nil"">
            <xsl:value-of select=""'true'"" />
          </xsl:attribute>
        </ns0:asst_RowGuid>
        <ns0:asst_TrackingNote>
          <xsl:value-of select=""$var:v45"" />
        </ns0:asst_TrackingNote>
        <xsl:value-of select=""./text()"" />
      </ns0:udtt_Asset>
    </ns0:ArrayOfudtt_Asset>
    <xsl:variable name=""var:v46"" select=""ScriptNS1:DBLookupShutdown()"" />
  </xsl:template>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp""><![CDATA[
public string DateCurrentDateTime()
{
	DateTime dt = DateTime.Now;
	string curdate = dt.ToString(""yyyy-MM-dd"", System.Globalization.CultureInfo.InvariantCulture);
	string curtime = dt.ToString(""T"", System.Globalization.CultureInfo.InvariantCulture);
	string retval = curdate + ""T"" + curtime;
	return retval;
}


public string StringConcat(string param0)
{
   return param0;
}


public string StringConcat(string param0, string param1, string param2, string param3, string param4, string param5, string param6)
{
   return param0 + param1 + param2 + param3 + param4 + param5 + param6;
}


public string StringConcat(string param0, string param1, string param2)
{
   return param0 + param1 + param2;
}


public bool LogicalIsNumeric(string val)
{
	return IsNumeric(val);
}


public bool LogicalNe(string val1, string val2)
{
	bool ret = false;
	double d1 = 0;
	double d2 = 0;
	if (IsNumeric(val1, ref d1) && IsNumeric(val2, ref d2))
	{
		ret = d1 != d2;
	}
	else
	{
		ret = String.Compare(val1, val2, StringComparison.Ordinal) != 0;
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
        
        private const string _strArgList = @"<ExtensionObjects>
  <ExtensionObject Namespace=""http://schemas.microsoft.com/BizTalk/2003/ScriptNS0"" AssemblyName=""MFM.Lbg.Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=b52a4a519c43e251"" ClassName=""MFM.Lbg.Helper.Misc"" />
  <ExtensionObject Namespace=""http://schemas.microsoft.com/BizTalk/2003/ScriptNS1"" AssemblyName=""Microsoft.BizTalk.BaseFunctoids, Version=3.0.1.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35"" ClassName=""Microsoft.BizTalk.BaseFunctoids.FunctoidScripts"" />
</ExtensionObjects>";
        
        private const string _strSrcSchemasList0 = @"MFM.Lbg.Schemas.MFMWorkItemUpdate";
        
        private const global::MFM.Lbg.Schemas.MFMWorkItemUpdate _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"MFM.Lbg.Schemas.Add_Asset_UdttTableType_ops+ArrayOfudtt_Asset";
        
        private const global::MFM.Lbg.Schemas.Add_Asset_UdttTableType_ops.ArrayOfudtt_Asset _trgSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"MFM.Lbg.Schemas.MFMWorkItemUpdate";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"MFM.Lbg.Schemas.Add_Asset_UdttTableType_ops+ArrayOfudtt_Asset";
                return _TrgSchemas;
            }
        }
    }
}
