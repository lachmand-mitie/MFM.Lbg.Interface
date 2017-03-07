namespace MFM.Lbg.Orcs {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"MFM.Lbg.Schemas.VfmDummyStarter", typeof(global::MFM.Lbg.Schemas.VfmDummyStarter))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"MFM.Lbg.Schemas.ORDERS_Z139ORDERS", typeof(global::MFM.Lbg.Schemas.ORDERS_Z139ORDERS))]
    public sealed class map_x_To_Z139ORDERS : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 userCSharp ScriptNS0 ScriptNS1"" version=""1.0"" xmlns:s0=""http://MFM.Lbg.Schemas.VfmDummyStarter"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"" xmlns:ScriptNS0=""http://schemas.microsoft.com/BizTalk/2003/ScriptNS0"" xmlns:ScriptNS1=""http://schemas.microsoft.com/BizTalk/2003/ScriptNS1"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:VfmDummyStarter"" />
  </xsl:template>
  <xsl:template match=""/s0:VfmDummyStarter"">
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
          <RCVPOR>
            <xsl:text>SAPED2</xsl:text>
          </RCVPOR>
          <RCVPRN>
            <xsl:text>ED2CLNT121</xsl:text>
          </RCVPRN>
        </EDI_DC40>
        <E1EDK01>
          <xsl:attribute name=""SEGMENT"">
            <xsl:text>E1EDK01</xsl:text>
          </xsl:attribute>
          <ACTION>
            <xsl:text>000</xsl:text>
          </ACTION>
          <CURCY>
            <xsl:text>GBP</xsl:text>
          </CURCY>
          <WKURS>
            <xsl:text>1.00000</xsl:text>
          </WKURS>
          <BSART>
            <xsl:text>ZOR</xsl:text>
          </BSART>
        </E1EDK01>
        <xsl:for-each select=""Payload/E1EDK14"">
          <E1EDK14>
            <xsl:attribute name=""SEGMENT"">
              <xsl:text>E1EDK14</xsl:text>
            </xsl:attribute>
            <QUALF>
              <xsl:value-of select=""QUALF/text()"" />
            </QUALF>
            <ORGID>
              <xsl:value-of select=""ORGID/text()"" />
            </ORGID>
            <xsl:value-of select=""./text()"" />
          </E1EDK14>
        </xsl:for-each>
        <xsl:for-each select=""Payload/E1EDK03"">
          <E1EDK03>
            <xsl:attribute name=""SEGMENT"">
              <xsl:text>E1EDK03</xsl:text>
            </xsl:attribute>
            <IDDAT>
              <xsl:value-of select=""IDDAT/text()"" />
            </IDDAT>
            <DATUM>
              <xsl:value-of select=""DATUM/text()"" />
            </DATUM>
            <xsl:value-of select=""./text()"" />
          </E1EDK03>
        </xsl:for-each>
        <xsl:for-each select=""Payload/E1EDKA1"">
          <E1EDKA1>
            <xsl:attribute name=""SEGMENT"">
              <xsl:text>E1EDKA1</xsl:text>
            </xsl:attribute>
            <PARVW>
              <xsl:value-of select=""PARVW/text()"" />
            </PARVW>
            <xsl:if test=""PARTN"">
              <PARTN>
                <xsl:value-of select=""PARTN/text()"" />
              </PARTN>
            </xsl:if>
            <xsl:if test=""IHREZ"">
              <IHREZ>
                <xsl:value-of select=""IHREZ/text()"" />
              </IHREZ>
            </xsl:if>
            <xsl:if test=""BNAME"">
              <BNAME>
                <xsl:value-of select=""BNAME/text()"" />
              </BNAME>
            </xsl:if>
            <xsl:value-of select=""./text()"" />
          </E1EDKA1>
        </xsl:for-each>
        <E1EDK02>
          <xsl:attribute name=""SEGMENT"">
            <xsl:text>E1EDK02</xsl:text>
          </xsl:attribute>
          <QUALF>
            <xsl:text>001</xsl:text>
          </QUALF>
          <BELNR>
            <xsl:text>LBG TEST</xsl:text>
          </BELNR>
        </E1EDK02>
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
        <xsl:for-each select=""Payload/E1EDKT1"">
          <E1EDKT1>
            <xsl:attribute name=""SEGMENT"">
              <xsl:text>E1EDKT1</xsl:text>
            </xsl:attribute>
            <TDID>
              <xsl:value-of select=""TDID/text()"" />
            </TDID>
            <xsl:for-each select=""E1EDKT2"">
              <E1EDKT2>
                <xsl:attribute name=""SEGMENT"">
                  <xsl:text>E1EDKT2</xsl:text>
                </xsl:attribute>
                <TDLINE>
                  <xsl:value-of select=""TDLINE/text()"" />
                </TDLINE>
                <TDFORMAT>
                  <xsl:value-of select=""TDFORMAT/text()"" />
                </TDFORMAT>
                <xsl:value-of select=""./text()"" />
              </E1EDKT2>
            </xsl:for-each>
            <xsl:value-of select=""./text()"" />
          </E1EDKT1>
        </xsl:for-each>
        <xsl:for-each select=""Payload/ITEM"">
          <xsl:variable name=""var:v5"" select=""TEXTP1"" />
          <xsl:variable name=""var:v6"" select=""TEXTP2"" />
          <xsl:variable name=""var:v7"" select=""TEXTP3"" />
          <xsl:variable name=""var:v8"" select=""TEXTP4"" />
          <E1EDP01>
            <xsl:attribute name=""SEGMENT"">
              <xsl:text>E1EDP01</xsl:text>
            </xsl:attribute>
            <POSEX>
              <xsl:value-of select=""NUM/text()"" />
            </POSEX>
            <MENGE>
              <xsl:value-of select=""QUANTITY/text()"" />
            </MENGE>
            <MATNR_EXTERNAL>
              <xsl:value-of select=""MATERIAL/text()"" />
            </MATNR_EXTERNAL>
            <Z1EDP139WBS>
              <xsl:attribute name=""SEGMENT"">
                <xsl:text>Z1EDP139WBS</xsl:text>
              </xsl:attribute>
              <WBS_POSID>
                <xsl:value-of select=""WBS/text()"" />
              </WBS_POSID>
              <CONDITION_TYPE>
                <xsl:value-of select=""CONDITION/text()"" />
              </CONDITION_TYPE>
              <PRICE>
                <xsl:value-of select=""PRICE/text()"" />
              </PRICE>
            </Z1EDP139WBS>
            <E1EDP19>
              <xsl:attribute name=""SEGMENT"">
                <xsl:text>E1EDP19</xsl:text>
              </xsl:attribute>
              <QUALF>
                <xsl:value-of select=""KTEXTQUALF/text()"" />
              </QUALF>
              <KTEXT>
                <xsl:value-of select=""KTEXT/text()"" />
              </KTEXT>
            </E1EDP19>
            <E1EDPT1>
              <xsl:attribute name=""SEGMENT"">
                <xsl:text>E1EDPT1</xsl:text>
              </xsl:attribute>
              <TDID>
                <xsl:value-of select=""TEXTID/text()"" />
              </TDID>
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
                  <xsl:value-of select=""$var:v5"" />
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
                  <xsl:value-of select=""$var:v6"" />
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
                  <xsl:value-of select=""$var:v7"" />
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
                  <xsl:value-of select=""$var:v8"" />
                </TDLINE>
                <TDFORMAT>
                  <xsl:text>*</xsl:text>
                </TDFORMAT>
              </E1EDPT2>
            </E1EDPT1>
          </E1EDP01>
        </xsl:for-each>
      </IDOC>
    </Z139ORDERS>
    <xsl:variable name=""var:v9"" select=""ScriptNS1:DBLookupShutdown()"" />
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
        
        private const string _strSrcSchemasList0 = @"MFM.Lbg.Schemas.VfmDummyStarter";
        
        private const global::MFM.Lbg.Schemas.VfmDummyStarter _srcSchemaTypeReference0 = null;
        
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
                string[] _SrcSchemas = new string [1];
                _SrcSchemas[0] = @"MFM.Lbg.Schemas.VfmDummyStarter";
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
