namespace MFM.Lbg.Orcs {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"MFM.Lbg.Schemas.VFM_POTypedProcedure_dbo+biz_PO_Get_DataSetResponse", typeof(global::MFM.Lbg.Schemas.VFM_POTypedProcedure_dbo.biz_PO_Get_DataSetResponse))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"MFM.Lbg.Schemas.PORDCR102", typeof(global::MFM.Lbg.Schemas.PORDCR102))]
    public sealed class map_x_to_PORDCR102 : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s1 s0 ScriptNS0 ScriptNS1 userCSharp"" version=""1.0"" xmlns:s1=""http://schemas.microsoft.com/Sql/2008/05/TypedProcedures/dbo"" xmlns:s0=""http://schemas.microsoft.com/Sql/2008/05/ProceduresResultSets/dbo/biz_PO_Get_DataSet"" xmlns:ScriptNS0=""http://schemas.microsoft.com/BizTalk/2003/ScriptNS0"" xmlns:ScriptNS1=""http://schemas.microsoft.com/BizTalk/2003/ScriptNS1"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s1:biz_PO_Get_DataSetResponse"" />
  </xsl:template>
  <xsl:template match=""/s1:biz_PO_Get_DataSetResponse"">
    <xsl:variable name=""var:v10"" select=""s1:StoredProcedureResultSet0/s0:StoredProcedureResultSet0[1]/s0:PO_NUM/text()"" />
    <xsl:variable name=""var:v11"" select=""s1:StoredProcedureResultSet0/s0:StoredProcedureResultSet0[1]/s0:COMP_CODE/text()"" />
    <xsl:variable name=""var:v12"" select=""s1:StoredProcedureResultSet0/s0:StoredProcedureResultSet0[1]/s0:DOC_TYPE/text()"" />
    <xsl:variable name=""var:v13"" select=""s1:StoredProcedureResultSet0/s0:StoredProcedureResultSet0[1]/s0:VENDOR/text()"" />
    <xsl:variable name=""var:v14"" select=""s1:StoredProcedureResultSet0/s0:StoredProcedureResultSet0[1]/s0:PURCH_ORG/text()"" />
    <xsl:variable name=""var:v15"" select=""s1:StoredProcedureResultSet0/s0:StoredProcedureResultSet0[1]/s0:PUR_GROUP/text()"" />
    <xsl:variable name=""var:v16"" select=""s1:StoredProcedureResultSet0/s0:StoredProcedureResultSet0[1]/s0:DOC_DATE/text()"" />
    <xsl:variable name=""var:v17"" select=""s1:StoredProcedureResultSet0/s0:StoredProcedureResultSet0[1]/s0:POREF/text()"" />
    <PORDCR102>
      <IDOC>
        <xsl:attribute name=""BEGIN"">
          <xsl:text>1</xsl:text>
        </xsl:attribute>
        <EDI_DC40>
          <xsl:attribute name=""SEGMENT"">
            <xsl:text>EDI_DC40</xsl:text>
          </xsl:attribute>
          <TABNAM>
            <xsl:text>EDI_DC40</xsl:text>
          </TABNAM>
          <DIRECT>
            <xsl:text>2</xsl:text>
          </DIRECT>
          <IDOCTYP>
            <xsl:text>PORDCR102</xsl:text>
          </IDOCTYP>
          <CIMTYP>
            <xsl:text>PORDCR.PORDCR02</xsl:text>
          </CIMTYP>
          <MESTYP>
            <xsl:text>PORDCR1</xsl:text>
          </MESTYP>
          <SNDPRT>
            <xsl:text>LS</xsl:text>
          </SNDPRT>
          <xsl:variable name=""var:v1"" select=""ScriptNS0:editLookupConnectionString()"" />
          <xsl:variable name=""var:v2"" select=""ScriptNS1:DBLookup(0 , &quot;SNDPRN&quot; , string($var:v1) , &quot;dbo.Sap_Edi&quot; , &quot;Element&quot;)"" />
          <xsl:variable name=""var:v3"" select=""ScriptNS1:DBValueExtract(string($var:v2) , &quot;Value&quot;)"" />
          <SNDPRN>
            <xsl:value-of select=""$var:v3"" />
          </SNDPRN>
          <xsl:variable name=""var:v4"" select=""ScriptNS0:editLookupConnectionString()"" />
          <xsl:variable name=""var:v5"" select=""ScriptNS1:DBLookup(1 , &quot;RCVPOR&quot; , string($var:v4) , &quot;dbo.Sap_Edi&quot; , &quot;Element&quot;)"" />
          <xsl:variable name=""var:v6"" select=""ScriptNS1:DBValueExtract(string($var:v5) , &quot;Value&quot;)"" />
          <RCVPOR>
            <xsl:value-of select=""$var:v6"" />
          </RCVPOR>
          <RCVPRT>
            <xsl:text>LS</xsl:text>
          </RCVPRT>
          <xsl:variable name=""var:v7"" select=""ScriptNS0:editLookupConnectionString()"" />
          <xsl:variable name=""var:v8"" select=""ScriptNS1:DBLookup(2 , &quot;RCVPRN&quot; , string($var:v7) , &quot;dbo.Sap_Edi&quot; , &quot;Element&quot;)"" />
          <xsl:variable name=""var:v9"" select=""ScriptNS1:DBValueExtract(string($var:v8) , &quot;Value&quot;)"" />
          <RCVPRN>
            <xsl:value-of select=""$var:v9"" />
          </RCVPRN>
        </EDI_DC40>
        <E1PORDCR1>
          <xsl:attribute name=""SEGMENT"">
            <xsl:text>E1PORDCR1</xsl:text>
          </xsl:attribute>
          <E1BPMEPOHEADER>
            <xsl:attribute name=""SEGMENT"">
              <xsl:text>E1BPMEPOHEADER</xsl:text>
            </xsl:attribute>
            <PO_NUMBER>
              <xsl:value-of select=""$var:v10"" />
            </PO_NUMBER>
            <COMP_CODE>
              <xsl:value-of select=""$var:v11"" />
            </COMP_CODE>
            <DOC_TYPE>
              <xsl:value-of select=""$var:v12"" />
            </DOC_TYPE>
            <VENDOR>
              <xsl:value-of select=""$var:v13"" />
            </VENDOR>
            <PURCH_ORG>
              <xsl:value-of select=""$var:v14"" />
            </PURCH_ORG>
            <PUR_GROUP>
              <xsl:value-of select=""$var:v15"" />
            </PUR_GROUP>
            <DOC_DATE>
              <xsl:value-of select=""$var:v16"" />
            </DOC_DATE>
            <REF_1>
              <xsl:value-of select=""$var:v17"" />
            </REF_1>
          </E1BPMEPOHEADER>
          <E1BPMEPOHEADERX>
            <xsl:attribute name=""SEGMENT"">
              <xsl:text>E1BPMEPOHEADERX</xsl:text>
            </xsl:attribute>
            <PO_NUMBER>
              <xsl:text>X</xsl:text>
            </PO_NUMBER>
            <COMP_CODE>
              <xsl:text>X</xsl:text>
            </COMP_CODE>
            <DOC_TYPE>
              <xsl:text>X</xsl:text>
            </DOC_TYPE>
            <ITEM_INTVL>
              <xsl:text>X</xsl:text>
            </ITEM_INTVL>
            <VENDOR>
              <xsl:text>X</xsl:text>
            </VENDOR>
            <PURCH_ORG>
              <xsl:text>X</xsl:text>
            </PURCH_ORG>
            <PUR_GROUP>
              <xsl:text>X</xsl:text>
            </PUR_GROUP>
            <DOC_DATE>
              <xsl:text>X</xsl:text>
            </DOC_DATE>
            <REF_1>
              <xsl:text>X</xsl:text>
            </REF_1>
          </E1BPMEPOHEADERX>
          <xsl:for-each select=""s1:StoredProcedureResultSet0"">
            <xsl:for-each select=""s0:StoredProcedureResultSet0"">
              <E1BPMEPOITEM>
                <xsl:attribute name=""SEGMENT"">
                  <xsl:text>E1BPMEPOITEM</xsl:text>
                </xsl:attribute>
                <xsl:if test=""s0:PO_ITEM"">
                  <PO_ITEM>
                    <xsl:value-of select=""s0:PO_ITEM/text()"" />
                  </PO_ITEM>
                </xsl:if>
                <xsl:if test=""s0:SHORT_TEXT"">
                  <SHORT_TEXT>
                    <xsl:value-of select=""s0:SHORT_TEXT/text()"" />
                  </SHORT_TEXT>
                </xsl:if>
                <xsl:if test=""s0:MATERIAL"">
                  <MATERIAL>
                    <xsl:value-of select=""s0:MATERIAL/text()"" />
                  </MATERIAL>
                </xsl:if>
                <xsl:if test=""s0:PLANT"">
                  <PLANT>
                    <xsl:value-of select=""s0:PLANT/text()"" />
                  </PLANT>
                </xsl:if>
                <xsl:if test=""s0:QUANTITY"">
                  <QUANTITY>
                    <xsl:value-of select=""s0:QUANTITY/text()"" />
                  </QUANTITY>
                </xsl:if>
                <xsl:if test=""s0:NET_PRICE"">
                  <NET_PRICE>
                    <xsl:value-of select=""s0:NET_PRICE/text()"" />
                  </NET_PRICE>
                </xsl:if>
                <xsl:if test=""s0:EST_PRICE"">
                  <EST_PRICE>
                    <xsl:value-of select=""s0:EST_PRICE/text()"" />
                  </EST_PRICE>
                </xsl:if>
                <xsl:if test=""s0:ITEM_CAT"">
                  <ITEM_CAT>
                    <xsl:value-of select=""s0:ITEM_CAT/text()"" />
                  </ITEM_CAT>
                </xsl:if>
                <xsl:if test=""s0:ACCTASSCAT"">
                  <ACCTASSCAT>
                    <xsl:value-of select=""s0:ACCTASSCAT/text()"" />
                  </ACCTASSCAT>
                </xsl:if>
                <xsl:if test=""s0:IR_IND"">
                  <IR_IND>
                    <xsl:value-of select=""s0:IR_IND/text()"" />
                  </IR_IND>
                </xsl:if>
              </E1BPMEPOITEM>
            </xsl:for-each>
          </xsl:for-each>
          <xsl:for-each select=""s1:StoredProcedureResultSet0"">
            <xsl:for-each select=""s0:StoredProcedureResultSet0"">
              <E1BPMEPOITEMX>
                <xsl:attribute name=""SEGMENT"">
                  <xsl:text>E1BPMEPOITEMX</xsl:text>
                </xsl:attribute>
                <xsl:if test=""s0:PO_ITEM"">
                  <PO_ITEM>
                    <xsl:value-of select=""s0:PO_ITEM/text()"" />
                  </PO_ITEM>
                </xsl:if>
                <SHORT_TEXT>
                  <xsl:text>X</xsl:text>
                </SHORT_TEXT>
                <MATERIAL>
                  <xsl:text>X</xsl:text>
                </MATERIAL>
                <PLANT>
                  <xsl:text>X</xsl:text>
                </PLANT>
                <QUANTITY>
                  <xsl:text>X</xsl:text>
                </QUANTITY>
                <NET_PRICE>
                  <xsl:text>X</xsl:text>
                </NET_PRICE>
                <EST_PRICE>
                  <xsl:text>X</xsl:text>
                </EST_PRICE>
                <ITEM_CAT>
                  <xsl:text>X</xsl:text>
                </ITEM_CAT>
                <ACCTASSCAT>
                  <xsl:text>X</xsl:text>
                </ACCTASSCAT>
                <IR_IND>
                  <xsl:text>X</xsl:text>
                </IR_IND>
              </E1BPMEPOITEMX>
            </xsl:for-each>
          </xsl:for-each>
          <xsl:for-each select=""s1:StoredProcedureResultSet0"">
            <xsl:for-each select=""s0:StoredProcedureResultSet0"">
              <E1BPMEPOADDRDELIVERY>
                <xsl:attribute name=""SEGMENT"">
                  <xsl:text>E1BPMEPOADDRDELIVERY</xsl:text>
                </xsl:attribute>
                <xsl:if test=""s0:PO_ITEM"">
                  <PO_ITEM>
                    <xsl:value-of select=""s0:PO_ITEM/text()"" />
                  </PO_ITEM>
                </xsl:if>
                <xsl:if test=""s0:NAME"">
                  <NAME>
                    <xsl:value-of select=""s0:NAME/text()"" />
                  </NAME>
                </xsl:if>
                <xsl:if test=""s0:CITY"">
                  <CITY>
                    <xsl:value-of select=""s0:CITY/text()"" />
                  </CITY>
                </xsl:if>
                <xsl:if test=""s0:POSTL_COD1"">
                  <POSTL_COD1>
                    <xsl:value-of select=""s0:POSTL_COD1/text()"" />
                  </POSTL_COD1>
                </xsl:if>
                <xsl:if test=""s0:STR_SUPPL1"">
                  <STR_SUPPL1>
                    <xsl:value-of select=""s0:STR_SUPPL1/text()"" />
                  </STR_SUPPL1>
                </xsl:if>
                <xsl:if test=""s0:STR_SUPPL2"">
                  <STR_SUPPL2>
                    <xsl:value-of select=""s0:STR_SUPPL2/text()"" />
                  </STR_SUPPL2>
                </xsl:if>
                <xsl:if test=""s0:LOCATION"">
                  <LOCATION>
                    <xsl:value-of select=""s0:LOCATION/text()"" />
                  </LOCATION>
                </xsl:if>
                <xsl:if test=""s0:COUNTRY"">
                  <COUNTRY>
                    <xsl:value-of select=""s0:COUNTRY/text()"" />
                  </COUNTRY>
                </xsl:if>
              </E1BPMEPOADDRDELIVERY>
            </xsl:for-each>
          </xsl:for-each>
          <xsl:for-each select=""s1:StoredProcedureResultSet0"">
            <xsl:for-each select=""s0:StoredProcedureResultSet0"">
              <E1BPMEPOSCHEDULE>
                <xsl:attribute name=""SEGMENT"">
                  <xsl:text>E1BPMEPOSCHEDULE</xsl:text>
                </xsl:attribute>
                <xsl:if test=""s0:PO_ITEM"">
                  <PO_ITEM>
                    <xsl:value-of select=""s0:PO_ITEM/text()"" />
                  </PO_ITEM>
                </xsl:if>
                <xsl:if test=""s0:DELIVERY_DATE"">
                  <DELIVERY_DATE>
                    <xsl:value-of select=""s0:DELIVERY_DATE/text()"" />
                  </DELIVERY_DATE>
                </xsl:if>
                <xsl:if test=""s0:SCHEDQUANTITY"">
                  <QUANTITY>
                    <xsl:value-of select=""s0:SCHEDQUANTITY/text()"" />
                  </QUANTITY>
                </xsl:if>
              </E1BPMEPOSCHEDULE>
            </xsl:for-each>
          </xsl:for-each>
          <xsl:for-each select=""s1:StoredProcedureResultSet0"">
            <xsl:for-each select=""s0:StoredProcedureResultSet0"">
              <E1BPMEPOSCHEDULX>
                <xsl:attribute name=""SEGMENT"">
                  <xsl:text>E1BPMEPOSCHEDULX</xsl:text>
                </xsl:attribute>
                <xsl:if test=""s0:PO_ITEM"">
                  <PO_ITEM>
                    <xsl:value-of select=""s0:PO_ITEM/text()"" />
                  </PO_ITEM>
                </xsl:if>
                <xsl:if test=""s0:DELIVERY_DATE"">
                  <DELIVERY_DATE>
                    <xsl:value-of select=""s0:DELIVERY_DATE/text()"" />
                  </DELIVERY_DATE>
                </xsl:if>
                <xsl:if test=""s0:SCHEDQUANTITY"">
                  <QUANTITY>
                    <xsl:value-of select=""s0:SCHEDQUANTITY/text()"" />
                  </QUANTITY>
                </xsl:if>
              </E1BPMEPOSCHEDULX>
            </xsl:for-each>
          </xsl:for-each>
          <xsl:for-each select=""s1:StoredProcedureResultSet0"">
            <xsl:for-each select=""s0:StoredProcedureResultSet0"">
              <xsl:variable name=""var:v18"" select=""userCSharp:LogicalNe(string(s0:COSTCENTER/text()) , &quot;&quot;)"" />
              <xsl:variable name=""var:v20"" select=""userCSharp:LogicalNe(string(s0:WBS_ELEMENT/text()) , &quot;&quot;)"" />
              <E1BPMEPOACCOUNT>
                <xsl:attribute name=""SEGMENT"">
                  <xsl:text>E1BPMEPOACCOUNT</xsl:text>
                </xsl:attribute>
                <xsl:if test=""s0:PO_ITEM"">
                  <PO_ITEM>
                    <xsl:value-of select=""s0:PO_ITEM/text()"" />
                  </PO_ITEM>
                </xsl:if>
                <xsl:if test=""string($var:v18)='true'"">
                  <xsl:variable name=""var:v19"" select=""s0:COSTCENTER/text()"" />
                  <COSTCENTER>
                    <xsl:value-of select=""$var:v19"" />
                  </COSTCENTER>
                </xsl:if>
                <xsl:if test=""string($var:v20)='true'"">
                  <xsl:variable name=""var:v21"" select=""s0:WBS_ELEMENT/text()"" />
                  <WBS_ELEMENT>
                    <xsl:value-of select=""$var:v21"" />
                  </WBS_ELEMENT>
                </xsl:if>
              </E1BPMEPOACCOUNT>
            </xsl:for-each>
          </xsl:for-each>
          <xsl:for-each select=""s1:StoredProcedureResultSet0"">
            <xsl:for-each select=""s0:StoredProcedureResultSet0"">
              <xsl:variable name=""var:v22"" select=""string(s0:COSTCENTER/text())"" />
              <xsl:variable name=""var:v23"" select=""userCSharp:LogicalNe($var:v22 , &quot;&quot;)"" />
              <xsl:variable name=""var:v24"" select=""userCSharp:StringConcat(&quot;X&quot;)"" />
              <xsl:variable name=""var:v26"" select=""string(s0:WBS_ELEMENT/text())"" />
              <xsl:variable name=""var:v27"" select=""userCSharp:LogicalNe($var:v26 , &quot;&quot;)"" />
              <E1BPMEPOACCOUNTX>
                <xsl:attribute name=""SEGMENT"">
                  <xsl:text>E1BPMEPOACCOUNTX</xsl:text>
                </xsl:attribute>
                <xsl:if test=""s0:PO_ITEM"">
                  <PO_ITEM>
                    <xsl:value-of select=""s0:PO_ITEM/text()"" />
                  </PO_ITEM>
                </xsl:if>
                <xsl:if test=""string($var:v23)='true'"">
                  <xsl:variable name=""var:v25"" select=""string($var:v24)"" />
                  <COSTCENTER>
                    <xsl:value-of select=""$var:v25"" />
                  </COSTCENTER>
                </xsl:if>
                <xsl:if test=""string($var:v27)='true'"">
                  <xsl:variable name=""var:v28"" select=""string($var:v24)"" />
                  <WBS_ELEMENT>
                    <xsl:value-of select=""$var:v28"" />
                  </WBS_ELEMENT>
                </xsl:if>
              </E1BPMEPOACCOUNTX>
            </xsl:for-each>
          </xsl:for-each>
          <E1BPEKKOP>
            <xsl:attribute name=""SEGMENT"">
              <xsl:text>E1BPEKKOP</xsl:text>
            </xsl:attribute>
            <PARTNERDESC>
              <xsl:text>OA</xsl:text>
            </PARTNERDESC>
            <LANGU>
              <xsl:text>E</xsl:text>
            </LANGU>
            <BUSPARTNO>
              <xsl:value-of select=""$var:v13"" />
            </BUSPARTNO>
          </E1BPEKKOP>
        </E1PORDCR1>
      </IDOC>
    </PORDCR102>
    <xsl:variable name=""var:v29"" select=""ScriptNS1:DBLookupShutdown()"" />
  </xsl:template>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp""><![CDATA[
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


public string StringConcat(string param0)
{
   return param0;
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
        
        private const string _strSrcSchemasList0 = @"MFM.Lbg.Schemas.VFM_POTypedProcedure_dbo+biz_PO_Get_DataSetResponse";
        
        private const global::MFM.Lbg.Schemas.VFM_POTypedProcedure_dbo.biz_PO_Get_DataSetResponse _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"MFM.Lbg.Schemas.PORDCR102";
        
        private const global::MFM.Lbg.Schemas.PORDCR102 _trgSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"MFM.Lbg.Schemas.VFM_POTypedProcedure_dbo+biz_PO_Get_DataSetResponse";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"MFM.Lbg.Schemas.PORDCR102";
                return _TrgSchemas;
            }
        }
    }
}
