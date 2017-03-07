namespace MFM.Lbg.Orcs {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"MFM.Lbg.Schemas.VFM_SOTypedProcedure_dbo+biz_SO_Get_HeaderResponse", typeof(global::MFM.Lbg.Schemas.VFM_SOTypedProcedure_dbo.biz_SO_Get_HeaderResponse))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"MFM.Lbg.Schemas.VFM_SOTypedProcedure_dbo+biz_SO_Get_DataSetResponse", typeof(global::MFM.Lbg.Schemas.VFM_SOTypedProcedure_dbo.biz_SO_Get_DataSetResponse))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"MFM.Lbg.Schemas.ORDERS_Z139ORDERS", typeof(global::MFM.Lbg.Schemas.ORDERS_Z139ORDERS))]
    public sealed class map_to_Z139ORDERS_R : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s2 s1 s3 s0 userCSharp ScriptNS0 ScriptNS1"" version=""1.0"" xmlns:s2=""http://schemas.microsoft.com/Sql/2008/05/ProceduresResultSets/dbo/biz_SO_Get_Header"" xmlns:s1=""http://schemas.microsoft.com/BizTalk/2003/aggschema"" xmlns:s3=""http://schemas.microsoft.com/Sql/2008/05/ProceduresResultSets/dbo/biz_SO_Get_DataSet"" xmlns:s0=""http://schemas.microsoft.com/Sql/2008/05/TypedProcedures/dbo"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"" xmlns:ScriptNS0=""http://schemas.microsoft.com/BizTalk/2003/ScriptNS0"" xmlns:ScriptNS1=""http://schemas.microsoft.com/BizTalk/2003/ScriptNS1"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s1:Root"" />
  </xsl:template>
  <xsl:template match=""/s1:Root"">
    <xsl:variable name=""var:v1"" select=""userCSharp:StringConcat(&quot;&quot;)"" />
    <Z139ORDERS>
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
            <xsl:text>ORDERS05</xsl:text>
          </IDOCTYP>
          <CIMTYP>
            <xsl:text>ORDERS.ORDERS05.Z139ORDERS</xsl:text>
          </CIMTYP>
          <SNDPOR>
            <xsl:value-of select=""$var:v1"" />
          </SNDPOR>
          <SNDPRT>
            <xsl:text>LS</xsl:text>
          </SNDPRT>
          <xsl:variable name=""var:v2"" select=""ScriptNS0:editLookupConnectionString()"" />
          <xsl:variable name=""var:v3"" select=""ScriptNS1:DBLookup(0 , &quot;SNDPRN&quot; , string($var:v2) , &quot;dbo.SAP_Edi&quot; , &quot;Element&quot;)"" />
          <xsl:variable name=""var:v4"" select=""ScriptNS1:DBValueExtract(string($var:v3) , &quot;Value&quot;)"" />
          <SNDPRN>
            <xsl:value-of select=""$var:v4"" />
          </SNDPRN>
          <xsl:variable name=""var:v5"" select=""ScriptNS0:editLookupConnectionString()"" />
          <xsl:variable name=""var:v6"" select=""ScriptNS1:DBLookup(1 , &quot;RCVPOR&quot; , string($var:v5) , &quot;dbo.SAP_Edi&quot; , &quot;Element&quot;)"" />
          <xsl:variable name=""var:v7"" select=""ScriptNS1:DBValueExtract(string($var:v6) , &quot;Value&quot;)"" />
          <RCVPOR>
            <xsl:value-of select=""$var:v7"" />
          </RCVPOR>
          <xsl:variable name=""var:v8"" select=""ScriptNS0:editLookupConnectionString()"" />
          <xsl:variable name=""var:v9"" select=""ScriptNS1:DBLookup(2 , &quot;RCVPRN&quot; , string($var:v8) , &quot;dbo.SAP_Edi&quot; , &quot;Element&quot;)"" />
          <xsl:variable name=""var:v10"" select=""ScriptNS1:DBValueExtract(string($var:v9) , &quot;Value&quot;)"" />
          <RCVPRN>
            <xsl:value-of select=""$var:v10"" />
          </RCVPRN>
        </EDI_DC40>
        <xsl:for-each select=""InputMessagePart_0/s0:biz_SO_Get_HeaderResponse/s0:StoredProcedureResultSet0"">
          <xsl:for-each select=""s2:StoredProcedureResultSet0"">
            <E1EDK01>
              <xsl:attribute name=""SEGMENT"">
                <xsl:text>E1EDK01</xsl:text>
              </xsl:attribute>
              <xsl:if test=""s2:K01_ACTION"">
                <ACTION>
                  <xsl:value-of select=""s2:K01_ACTION/text()"" />
                </ACTION>
              </xsl:if>
              <xsl:if test=""s2:K01_CURCY"">
                <CURCY>
                  <xsl:value-of select=""s2:K01_CURCY/text()"" />
                </CURCY>
              </xsl:if>
              <xsl:if test=""s2:K01_WKURS"">
                <WKURS>
                  <xsl:value-of select=""s2:K01_WKURS/text()"" />
                </WKURS>
              </xsl:if>
              <xsl:if test=""s2:K01_BSART"">
                <BSART>
                  <xsl:value-of select=""s2:K01_BSART/text()"" />
                </BSART>
              </xsl:if>
            </E1EDK01>
          </xsl:for-each>
        </xsl:for-each>
        <xsl:for-each select=""InputMessagePart_0/s0:biz_SO_Get_HeaderResponse/s0:StoredProcedureResultSet0"">
          <xsl:for-each select=""s2:StoredProcedureResultSet0"">
            <xsl:variable name=""var:v11"" select=""s2:K14_Q6"" />
            <xsl:variable name=""var:v12"" select=""s2:K14_Val6"" />
            <xsl:variable name=""var:v13"" select=""s2:K14_Q7"" />
            <xsl:variable name=""var:v14"" select=""s2:K14_Val7"" />
            <xsl:variable name=""var:v15"" select=""s2:K14_Q8"" />
            <xsl:variable name=""var:v16"" select=""s2:K14_Val8"" />
            <xsl:variable name=""var:v17"" select=""s2:K14_Q11"" />
            <xsl:variable name=""var:v18"" select=""s2:K14_Val11"" />
            <xsl:variable name=""var:v19"" select=""s2:K14_Q12"" />
            <xsl:variable name=""var:v20"" select=""s2:K14_Val12"" />
            <xsl:variable name=""var:v21"" select=""s2:K14_Q16"" />
            <xsl:variable name=""var:v22"" select=""s2:K14_Val16"" />
            <E1EDK14>
              <xsl:attribute name=""SEGMENT"">
                <xsl:text>E1EDK14</xsl:text>
              </xsl:attribute>
              <QUALF>
                <xsl:value-of select=""$var:v11"" />
              </QUALF>
              <ORGID>
                <xsl:value-of select=""$var:v12"" />
              </ORGID>
            </E1EDK14>
            <E1EDK14>
              <xsl:attribute name=""SEGMENT"">
                <xsl:text>E1EDK14</xsl:text>
              </xsl:attribute>
              <QUALF>
                <xsl:value-of select=""$var:v13"" />
              </QUALF>
              <ORGID>
                <xsl:value-of select=""$var:v14"" />
              </ORGID>
            </E1EDK14>
            <E1EDK14>
              <xsl:attribute name=""SEGMENT"">
                <xsl:text>E1EDK14</xsl:text>
              </xsl:attribute>
              <QUALF>
                <xsl:value-of select=""$var:v15"" />
              </QUALF>
              <ORGID>
                <xsl:value-of select=""$var:v16"" />
              </ORGID>
            </E1EDK14>
            <E1EDK14>
              <xsl:attribute name=""SEGMENT"">
                <xsl:text>E1EDK14</xsl:text>
              </xsl:attribute>
              <QUALF>
                <xsl:value-of select=""$var:v17"" />
              </QUALF>
              <ORGID>
                <xsl:value-of select=""$var:v18"" />
              </ORGID>
            </E1EDK14>
            <E1EDK14>
              <xsl:attribute name=""SEGMENT"">
                <xsl:text>E1EDK14</xsl:text>
              </xsl:attribute>
              <QUALF>
                <xsl:value-of select=""$var:v19"" />
              </QUALF>
              <ORGID>
                <xsl:value-of select=""$var:v20"" />
              </ORGID>
            </E1EDK14>
            <E1EDK14>
              <xsl:attribute name=""SEGMENT"">
                <xsl:text>E1EDK14</xsl:text>
              </xsl:attribute>
              <QUALF>
                <xsl:value-of select=""$var:v21"" />
              </QUALF>
              <ORGID>
                <xsl:value-of select=""$var:v22"" />
              </ORGID>
            </E1EDK14>
          </xsl:for-each>
        </xsl:for-each>
        <xsl:for-each select=""InputMessagePart_0/s0:biz_SO_Get_HeaderResponse/s0:StoredProcedureResultSet0"">
          <xsl:for-each select=""s2:StoredProcedureResultSet0"">
            <xsl:variable name=""var:v23"" select=""s2:K03_I002"" />
            <xsl:variable name=""var:v24"" select=""s2:K03_I016"" />
            <xsl:variable name=""var:v25"" select=""s2:K03_I027"" />
            <E1EDK03>
              <xsl:attribute name=""SEGMENT"">
                <xsl:text>E1EDK03</xsl:text>
              </xsl:attribute>
              <IDDAT>
                <xsl:value-of select=""$var:v23"" />
              </IDDAT>
              <xsl:if test=""s2:K03_Val"">
                <DATUM>
                  <xsl:value-of select=""s2:K03_Val/text()"" />
                </DATUM>
              </xsl:if>
            </E1EDK03>
            <E1EDK03>
              <xsl:attribute name=""SEGMENT"">
                <xsl:text>E1EDK03</xsl:text>
              </xsl:attribute>
              <IDDAT>
                <xsl:value-of select=""$var:v24"" />
              </IDDAT>
              <xsl:if test=""s2:K03_Val"">
                <DATUM>
                  <xsl:value-of select=""s2:K03_Val/text()"" />
                </DATUM>
              </xsl:if>
            </E1EDK03>
            <E1EDK03>
              <xsl:attribute name=""SEGMENT"">
                <xsl:text>E1EDK03</xsl:text>
              </xsl:attribute>
              <IDDAT>
                <xsl:value-of select=""$var:v25"" />
              </IDDAT>
              <xsl:if test=""s2:K03_Val"">
                <DATUM>
                  <xsl:value-of select=""s2:K03_Val/text()"" />
                </DATUM>
              </xsl:if>
            </E1EDK03>
          </xsl:for-each>
        </xsl:for-each>
        <xsl:for-each select=""InputMessagePart_0/s0:biz_SO_Get_HeaderResponse/s0:StoredProcedureResultSet0"">
          <xsl:for-each select=""s2:StoredProcedureResultSet0"">
            <xsl:variable name=""var:v26"" select=""userCSharp:StringConcat(&quot;&quot;)"" />
            <xsl:variable name=""var:v27"" select=""s2:KA1_1_PARVW"" />
            <xsl:variable name=""var:v28"" select=""s2:KA1_1_PARTN"" />
            <xsl:variable name=""var:v29"" select=""s2:KA1_1_IHREZ"" />
            <xsl:variable name=""var:v30"" select=""s2:KA1_1_BNAME"" />
            <xsl:variable name=""var:v31"" select=""s2:KA1_2_PARVW"" />
            <xsl:variable name=""var:v32"" select=""s2:KA1_2_PARTN"" />
            <xsl:variable name=""var:v33"" select=""$var:v26"" />
            <xsl:variable name=""var:v34"" select=""s2:KA1_3_PARVW"" />
            <xsl:variable name=""var:v35"" select=""s2:KA1_3_PARTN"" />
            <xsl:variable name=""var:v36"" select=""s2:KA1_4_PARVW"" />
            <xsl:variable name=""var:v37"" select=""s2:KA1_4_PARTN"" />
            <E1EDKA1>
              <xsl:attribute name=""SEGMENT"">
                <xsl:text>E1EDKA1</xsl:text>
              </xsl:attribute>
              <PARVW>
                <xsl:value-of select=""$var:v27"" />
              </PARVW>
              <PARTN>
                <xsl:value-of select=""$var:v28"" />
              </PARTN>
              <IHREZ>
                <xsl:value-of select=""$var:v29"" />
              </IHREZ>
              <BNAME>
                <xsl:value-of select=""$var:v30"" />
              </BNAME>
            </E1EDKA1>
            <E1EDKA1>
              <xsl:attribute name=""SEGMENT"">
                <xsl:text>E1EDKA1</xsl:text>
              </xsl:attribute>
              <PARVW>
                <xsl:value-of select=""$var:v31"" />
              </PARVW>
              <PARTN>
                <xsl:value-of select=""$var:v32"" />
              </PARTN>
              <IHREZ>
                <xsl:value-of select=""$var:v33"" />
              </IHREZ>
              <BNAME>
                <xsl:value-of select=""$var:v33"" />
              </BNAME>
            </E1EDKA1>
            <E1EDKA1>
              <xsl:attribute name=""SEGMENT"">
                <xsl:text>E1EDKA1</xsl:text>
              </xsl:attribute>
              <PARVW>
                <xsl:value-of select=""$var:v34"" />
              </PARVW>
              <PARTN>
                <xsl:value-of select=""$var:v35"" />
              </PARTN>
              <IHREZ>
                <xsl:value-of select=""$var:v33"" />
              </IHREZ>
              <BNAME>
                <xsl:value-of select=""$var:v33"" />
              </BNAME>
            </E1EDKA1>
            <E1EDKA1>
              <xsl:attribute name=""SEGMENT"">
                <xsl:text>E1EDKA1</xsl:text>
              </xsl:attribute>
              <PARVW>
                <xsl:value-of select=""$var:v36"" />
              </PARVW>
              <PARTN>
                <xsl:value-of select=""$var:v37"" />
              </PARTN>
              <IHREZ>
                <xsl:value-of select=""$var:v33"" />
              </IHREZ>
              <BNAME>
                <xsl:value-of select=""$var:v33"" />
              </BNAME>
            </E1EDKA1>
          </xsl:for-each>
        </xsl:for-each>
        <xsl:for-each select=""InputMessagePart_0/s0:biz_SO_Get_HeaderResponse/s0:StoredProcedureResultSet0"">
          <xsl:for-each select=""s2:StoredProcedureResultSet0"">
            <E1EDK02>
              <xsl:attribute name=""SEGMENT"">
                <xsl:text>E1EDK02</xsl:text>
              </xsl:attribute>
              <QUALF>
                <xsl:text>001</xsl:text>
              </QUALF>
              <xsl:if test=""s2:SOREF"">
                <BELNR>
                  <xsl:value-of select=""s2:SOREF/text()"" />
                </BELNR>
              </xsl:if>
            </E1EDK02>
          </xsl:for-each>
        </xsl:for-each>
        <E1EDK35>
          <xsl:attribute name=""SEGMENT"">
            <xsl:text>E1EDK35</xsl:text>
          </xsl:attribute>
          <QUALZ>
            <xsl:text>001</xsl:text>
          </QUALZ>
          <CUSADD>
            <xsl:text>01</xsl:text>
          </CUSADD>
        </E1EDK35>
        <xsl:for-each select=""InputMessagePart_0/s0:biz_SO_Get_HeaderResponse/s0:StoredProcedureResultSet0"">
          <xsl:for-each select=""s2:StoredProcedureResultSet0"">
            <xsl:variable name=""var:v38"" select=""userCSharp:StringConcat(&quot;Z001&quot;)"" />
            <xsl:variable name=""var:v39"" select=""s2:KT1_TDID"" />
            <xsl:variable name=""var:v40"" select=""s2:KT2_1_TDLINE"" />
            <xsl:variable name=""var:v41"" select=""s2:KT2_2_TDLINE"" />
            <xsl:variable name=""var:v42"" select=""s2:KT2_3_TDLINE"" />
            <xsl:variable name=""var:v43"" select=""$var:v38"" />
            <E1EDKT1>
              <xsl:attribute name=""SEGMENT"">
                <xsl:text>E1EDKT1</xsl:text>
              </xsl:attribute>
              <TDID>
                <xsl:value-of select=""$var:v39"" />
              </TDID>
              <E1EDKT2>
                <xsl:attribute name=""SEGMENT"">
                  <xsl:text>E1EDKT2</xsl:text>
                </xsl:attribute>
                <TDLINE>
                  <xsl:value-of select=""$var:v40"" />
                </TDLINE>
                <TDFORMAT>
                  <xsl:text>*</xsl:text>
                </TDFORMAT>
              </E1EDKT2>
              <E1EDKT2>
                <xsl:attribute name=""SEGMENT"">
                  <xsl:text>E1EDKT2</xsl:text>
                </xsl:attribute>
                <TDLINE>
                  <xsl:value-of select=""$var:v41"" />
                </TDLINE>
                <TDFORMAT>
                  <xsl:text>*</xsl:text>
                </TDFORMAT>
              </E1EDKT2>
              <E1EDKT2>
                <xsl:attribute name=""SEGMENT"">
                  <xsl:text>E1EDKT2</xsl:text>
                </xsl:attribute>
                <TDLINE>
                  <xsl:value-of select=""$var:v42"" />
                </TDLINE>
                <TDFORMAT>
                  <xsl:text>*</xsl:text>
                </TDFORMAT>
              </E1EDKT2>
            </E1EDKT1>
            <E1EDKT1>
              <xsl:attribute name=""SEGMENT"">
                <xsl:text>E1EDKT1</xsl:text>
              </xsl:attribute>
              <TDID>
                <xsl:value-of select=""$var:v43"" />
              </TDID>
              <E1EDKT2>
                <xsl:attribute name=""SEGMENT"">
                  <xsl:text>E1EDKT2</xsl:text>
                </xsl:attribute>
                <TDLINE>
                  <xsl:value-of select=""$var:v40"" />
                </TDLINE>
                <TDFORMAT>
                  <xsl:text>*</xsl:text>
                </TDFORMAT>
              </E1EDKT2>
              <E1EDKT2>
                <xsl:attribute name=""SEGMENT"">
                  <xsl:text>E1EDKT2</xsl:text>
                </xsl:attribute>
                <TDLINE>
                  <xsl:value-of select=""$var:v41"" />
                </TDLINE>
                <TDFORMAT>
                  <xsl:text>*</xsl:text>
                </TDFORMAT>
              </E1EDKT2>
              <E1EDKT2>
                <xsl:attribute name=""SEGMENT"">
                  <xsl:text>E1EDKT2</xsl:text>
                </xsl:attribute>
                <TDLINE>
                  <xsl:value-of select=""$var:v42"" />
                </TDLINE>
                <TDFORMAT>
                  <xsl:text>*</xsl:text>
                </TDFORMAT>
              </E1EDKT2>
            </E1EDKT1>
          </xsl:for-each>
        </xsl:for-each>
        <xsl:for-each select=""InputMessagePart_1/s0:biz_SO_Get_DataSetResponse/s0:StoredProcedureResultSet0"">
          <xsl:for-each select=""s3:StoredProcedureResultSet0"">
            <xsl:variable name=""var:v44"" select=""s3:ITEM_TXT_1"" />
            <xsl:variable name=""var:v45"" select=""s3:ITEM_TXT_2"" />
            <xsl:variable name=""var:v46"" select=""s3:ITEM_TXT_3"" />
            <xsl:variable name=""var:v47"" select=""s3:E1EDPT2_TDLINE"" />
            <E1EDP01>
              <xsl:attribute name=""SEGMENT"">
                <xsl:text>E1EDP01</xsl:text>
              </xsl:attribute>
              <xsl:if test=""s3:POSEX"">
                <POSEX>
                  <xsl:value-of select=""s3:POSEX/text()"" />
                </POSEX>
              </xsl:if>
              <xsl:if test=""s3:MENGE"">
                <MENGE>
                  <xsl:value-of select=""s3:MENGE/text()"" />
                </MENGE>
              </xsl:if>
              <xsl:if test=""s3:MATNR_EXTERNAL"">
                <MATNR_EXTERNAL>
                  <xsl:value-of select=""s3:MATNR_EXTERNAL/text()"" />
                </MATNR_EXTERNAL>
              </xsl:if>
              <Z1EDP139WBS>
                <xsl:attribute name=""SEGMENT"">
                  <xsl:text>Z1EDP139WBS</xsl:text>
                </xsl:attribute>
                <xsl:if test=""s3:WBS_POSID"">
                  <WBS_POSID>
                    <xsl:value-of select=""s3:WBS_POSID/text()"" />
                  </WBS_POSID>
                </xsl:if>
                <xsl:if test=""s3:CONDITION_TYPE"">
                  <CONDITION_TYPE>
                    <xsl:value-of select=""s3:CONDITION_TYPE/text()"" />
                  </CONDITION_TYPE>
                </xsl:if>
                <xsl:if test=""s3:PRICE"">
                  <PRICE>
                    <xsl:value-of select=""s3:PRICE/text()"" />
                  </PRICE>
                </xsl:if>
              </Z1EDP139WBS>
              <E1EDP19>
                <xsl:attribute name=""SEGMENT"">
                  <xsl:text>E1EDP19</xsl:text>
                </xsl:attribute>
                <xsl:if test=""s3:E1EDP19_QUALF_002"">
                  <QUALF>
                    <xsl:value-of select=""s3:E1EDP19_QUALF_002/text()"" />
                  </QUALF>
                </xsl:if>
                <xsl:if test=""s3:KTEXT"">
                  <KTEXT>
                    <xsl:value-of select=""s3:KTEXT/text()"" />
                  </KTEXT>
                </xsl:if>
              </E1EDP19>
              <E1EDPT1>
                <xsl:attribute name=""SEGMENT"">
                  <xsl:text>E1EDPT1</xsl:text>
                </xsl:attribute>
                <xsl:if test=""s3:TDID"">
                  <TDID>
                    <xsl:value-of select=""s3:TDID/text()"" />
                  </TDID>
                </xsl:if>
                <TSSPRAS>
                  <xsl:text>E</xsl:text>
                </TSSPRAS>
                <TSSPRAS_ISO>
                  <xsl:text>EN</xsl:text>
                </TSSPRAS_ISO>
                <E1EDPT2>
                  <xsl:attribute name=""SEGMENT"">
                    <xsl:text>E1EDPT2</xsl:text>
                  </xsl:attribute>
                  <TDLINE>
                    <xsl:value-of select=""$var:v44"" />
                  </TDLINE>
                  <TDFORMAT>
                    <xsl:text>*</xsl:text>
                  </TDFORMAT>
                </E1EDPT2>
                <E1EDPT2>
                  <xsl:attribute name=""SEGMENT"">
                    <xsl:text>E1EDPT2</xsl:text>
                  </xsl:attribute>
                  <TDLINE>
                    <xsl:value-of select=""$var:v45"" />
                  </TDLINE>
                  <TDFORMAT>
                    <xsl:text>*</xsl:text>
                  </TDFORMAT>
                </E1EDPT2>
                <E1EDPT2>
                  <xsl:attribute name=""SEGMENT"">
                    <xsl:text>E1EDPT2</xsl:text>
                  </xsl:attribute>
                  <TDLINE>
                    <xsl:value-of select=""$var:v46"" />
                  </TDLINE>
                  <TDFORMAT>
                    <xsl:text>*</xsl:text>
                  </TDFORMAT>
                </E1EDPT2>
                <E1EDPT2>
                  <xsl:attribute name=""SEGMENT"">
                    <xsl:text>E1EDPT2</xsl:text>
                  </xsl:attribute>
                  <TDLINE>
                    <xsl:value-of select=""$var:v47"" />
                  </TDLINE>
                  <TDFORMAT>
                    <xsl:text>*</xsl:text>
                  </TDFORMAT>
                </E1EDPT2>
              </E1EDPT1>
              <xsl:value-of select=""./text()"" />
            </E1EDP01>
          </xsl:for-each>
        </xsl:for-each>
      </IDOC>
    </Z139ORDERS>
    <xsl:variable name=""var:v48"" select=""ScriptNS1:DBLookupShutdown()"" />
  </xsl:template>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp""><![CDATA[
public string StringConcat(string param0)
{
   return param0;
}



]]></msxsl:script>
</xsl:stylesheet>";
        
        private const string _strArgList = @"<ExtensionObjects>
  <ExtensionObject Namespace=""http://schemas.microsoft.com/BizTalk/2003/ScriptNS0"" AssemblyName=""MFM.Lbg.Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=b52a4a519c43e251"" ClassName=""MFM.Lbg.Helper.Misc"" />
  <ExtensionObject Namespace=""http://schemas.microsoft.com/BizTalk/2003/ScriptNS1"" AssemblyName=""Microsoft.BizTalk.BaseFunctoids, Version=3.0.1.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35"" ClassName=""Microsoft.BizTalk.BaseFunctoids.FunctoidScripts"" />
</ExtensionObjects>";
        
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
