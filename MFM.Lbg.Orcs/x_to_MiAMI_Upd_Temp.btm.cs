namespace MFM.Lbg.Orcs {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"MFM.Lbg.Schemas.MTFMWOINService+SyncMTFMWOIN", typeof(global::MFM.Lbg.Schemas.MTFMWOINService.SyncMTFMWOIN))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"MFM.Lbg.Schemas.MTFMWOINService+SyncMTFMWOIN", typeof(global::MFM.Lbg.Schemas.MTFMWOINService.SyncMTFMWOIN))]
    public sealed class x_to_MiAMI_Upd_Temp : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var userCSharp"" version=""1.0"" xmlns:ns0=""http://www.ibm.com/maximo"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/ns0:SyncMTFMWOIN"" />
  </xsl:template>
  <xsl:template match=""/ns0:SyncMTFMWOIN"">
    <ns0:SyncMTFMWOIN>
      <ns0:MTFMWOINSet>
        <xsl:for-each select=""ns0:MTFMWOINSet/ns0:WORKORDER"">
          <xsl:variable name=""var:v1"" select=""userCSharp:StringConcat(&quot;temp&quot;)"" />
          <ns0:WORKORDER>
            <xsl:for-each select=""ns0:CLIENTREF"">
              <ns0:CLIENTREF>
                <xsl:value-of select=""./text()"" />
              </ns0:CLIENTREF>
            </xsl:for-each>
            <xsl:for-each select=""ns0:COMMODITY"">
              <ns0:COMMODITY>
                <xsl:value-of select=""./text()"" />
              </ns0:COMMODITY>
            </xsl:for-each>
            <xsl:for-each select=""ns0:COMMODITYGROUP"">
              <ns0:COMMODITYGROUP>
                <xsl:value-of select=""./text()"" />
              </ns0:COMMODITYGROUP>
            </xsl:for-each>
            <xsl:for-each select=""ns0:DESCRIPTION"">
              <ns0:DESCRIPTION>
                <xsl:value-of select=""./text()"" />
              </ns0:DESCRIPTION>
            </xsl:for-each>
            <xsl:for-each select=""ns0:DESCRIPTION_LONGDESCRIPTION"">
              <ns0:DESCRIPTION_LONGDESCRIPTION>
                <xsl:value-of select=""./text()"" />
              </ns0:DESCRIPTION_LONGDESCRIPTION>
            </xsl:for-each>
            <xsl:for-each select=""ns0:ISTASK"">
              <ns0:ISTASK>
                <xsl:value-of select=""./text()"" />
              </ns0:ISTASK>
            </xsl:for-each>
            <xsl:for-each select=""ns0:LOCATION"">
              <ns0:LOCATION>
                <xsl:value-of select=""./text()"" />
              </ns0:LOCATION>
            </xsl:for-each>
            <xsl:for-each select=""ns0:MTFMBLDGCLASS1"">
              <ns0:MTFMBLDGCLASS1>
                <xsl:value-of select=""./text()"" />
              </ns0:MTFMBLDGCLASS1>
            </xsl:for-each>
            <xsl:for-each select=""ns0:MTFMBLDGCLASS2"">
              <ns0:MTFMBLDGCLASS2>
                <xsl:value-of select=""./text()"" />
              </ns0:MTFMBLDGCLASS2>
            </xsl:for-each>
            <xsl:for-each select=""ns0:MTFMCLIENTREF"">
              <ns0:MTFMCLIENTREF>
                <xsl:value-of select=""./text()"" />
              </ns0:MTFMCLIENTREF>
            </xsl:for-each>
            <xsl:for-each select=""ns0:ONBEHALFOF"">
              <ns0:ONBEHALFOF>
                <xsl:value-of select=""./text()"" />
              </ns0:ONBEHALFOF>
            </xsl:for-each>
            <xsl:for-each select=""ns0:ORGID"">
              <ns0:ORGID>
                <xsl:value-of select=""./text()"" />
              </ns0:ORGID>
            </xsl:for-each>
            <xsl:for-each select=""ns0:PHONE"">
              <ns0:PHONE>
                <xsl:value-of select=""./text()"" />
              </ns0:PHONE>
            </xsl:for-each>
            <xsl:for-each select=""ns0:REPORTDATE"">
              <ns0:REPORTDATE>
                <xsl:value-of select=""./text()"" />
              </ns0:REPORTDATE>
            </xsl:for-each>
            <xsl:for-each select=""ns0:REPORTEDBY"">
              <ns0:REPORTEDBY>
                <xsl:value-of select=""./text()"" />
              </ns0:REPORTEDBY>
            </xsl:for-each>
            <xsl:for-each select=""ns0:SITEID"">
              <ns0:SITEID>
                <xsl:value-of select=""./text()"" />
              </ns0:SITEID>
            </xsl:for-each>
            <ns0:STATUS>
              <xsl:value-of select=""$var:v1"" />
            </ns0:STATUS>
            <xsl:for-each select=""ns0:TARGCOMPDATE"">
              <ns0:TARGCOMPDATE>
                <xsl:value-of select=""./text()"" />
              </ns0:TARGCOMPDATE>
            </xsl:for-each>
            <xsl:for-each select=""ns0:TARGSTARTDATE"">
              <ns0:TARGSTARTDATE>
                <xsl:value-of select=""./text()"" />
              </ns0:TARGSTARTDATE>
            </xsl:for-each>
            <xsl:for-each select=""ns0:WOCLASS"">
              <ns0:WOCLASS>
                <xsl:value-of select=""./text()"" />
              </ns0:WOCLASS>
            </xsl:for-each>
            <xsl:for-each select=""ns0:WOLO2"">
              <ns0:WOLO2>
                <xsl:value-of select=""./text()"" />
              </ns0:WOLO2>
            </xsl:for-each>
            <xsl:for-each select=""ns0:WOLO3"">
              <ns0:WOLO3>
                <xsl:value-of select=""./text()"" />
              </ns0:WOLO3>
            </xsl:for-each>
            <ns0:WONUM>
              <xsl:value-of select=""$var:v1"" />
            </ns0:WONUM>
            <xsl:for-each select=""ns0:WOPRIORITY"">
              <ns0:WOPRIORITY>
                <xsl:value-of select=""./text()"" />
              </ns0:WOPRIORITY>
            </xsl:for-each>
            <xsl:for-each select=""ns0:WORKTYPE"">
              <ns0:WORKTYPE>
                <xsl:value-of select=""./text()"" />
              </ns0:WORKTYPE>
            </xsl:for-each>
            <xsl:value-of select=""./text()"" />
          </ns0:WORKORDER>
        </xsl:for-each>
        <xsl:value-of select=""ns0:MTFMWOINSet/text()"" />
      </ns0:MTFMWOINSet>
      <xsl:value-of select=""./text()"" />
    </ns0:SyncMTFMWOIN>
  </xsl:template>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp""><![CDATA[
public string StringConcat(string param0)
{
   return param0;
}



]]></msxsl:script>
</xsl:stylesheet>";
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"MFM.Lbg.Schemas.MTFMWOINService+SyncMTFMWOIN";
        
        private const global::MFM.Lbg.Schemas.MTFMWOINService.SyncMTFMWOIN _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"MFM.Lbg.Schemas.MTFMWOINService+SyncMTFMWOIN";
        
        private const global::MFM.Lbg.Schemas.MTFMWOINService.SyncMTFMWOIN _trgSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"MFM.Lbg.Schemas.MTFMWOINService+SyncMTFMWOIN";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"MFM.Lbg.Schemas.MTFMWOINService+SyncMTFMWOIN";
                return _TrgSchemas;
            }
        }
    }
}
