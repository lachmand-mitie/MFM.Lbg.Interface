namespace MFM.Lbg.Orcs {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"MFM.Lbg.Schemas.MFMWorkItemUpdate", typeof(global::MFM.Lbg.Schemas.MFMWorkItemUpdate))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"MSS.Notification.Service.MSSNotifyEmail", typeof(global::MSS.Notification.Service.MSSNotifyEmail))]
    public sealed class map_Update_To_Notify : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 userCSharp ScriptNS0"" version=""1.0"" xmlns:s0=""http://MFM.Lbg.Schemas.MFMWorkItemUpdate"" xmlns:ns0=""http://MSS.Notification.Service.NotifyEmail/v1"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"" xmlns:ScriptNS0=""http://schemas.microsoft.com/BizTalk/2003/ScriptNS0"" xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:MFMWorkItemUpdate"" />
  </xsl:template>
  <xsl:template match=""/s0:MFMWorkItemUpdate"">
    <xsl:variable name=""var:v1"" select=""userCSharp:StringConcat(&quot;MFM.Helpdesk.Distributor&quot;)"" />
    <xsl:variable name=""var:v2"" select=""userCSharp:DateCurrentDateTime()"" />
    <xsl:variable name=""var:v4"" select=""userCSharp:StringConcat(string(WI_DestinationRef/text()))"" />
    <xsl:variable name=""var:v5"" select=""userCSharp:StringConcat(string(WI_ServiceLevel1/text()))"" />
    <xsl:variable name=""var:v6"" select=""userCSharp:StringConcat(&quot;Beacon \\ Case: &quot; , string($var:v4) , &quot; \\ Customer &quot; , string($var:v5))"" />
    <xsl:variable name=""var:v8"" select=""userCSharp:StringConcat(&quot;TEAMSUPP&quot;)"" />
    <xsl:variable name=""var:v13"" select=""userCSharp:StringConcat(string(Meta_RF05/text()) , &quot; &quot; , string(WI_StatusNote/text()))"" />
    <ns0:MSSNotifyEmail>
      <ApplicationName>
        <xsl:value-of select=""$var:v1"" />
      </ApplicationName>
      <CreatedTs>
        <xsl:value-of select=""$var:v2"" />
      </CreatedTs>
      <SmtpHost>
        <xsl:text>mailrelay.mitie.com</xsl:text>
      </SmtpHost>
      <SmtpPort>
        <xsl:text>25</xsl:text>
      </SmtpPort>
      <Retry>
        <xsl:text>20</xsl:text>
      </Retry>
      <EmailMetaData>
        <xsl:variable name=""var:v3"" select=""ScriptNS0:GetVisionFMSupportMailbox()"" />
        <To>
          <xsl:value-of select=""$var:v3"" />
        </To>
        <From>
          <xsl:text>no.reply@mitie.com</xsl:text>
        </From>
        <xsl:variable name=""var:v7"" select=""ScriptNS0:AddEnvironmentToSubjet(string($var:v6))"" />
        <Subject>
          <xsl:value-of select=""$var:v7"" />
        </Subject>
        <HighImportance>
          <xsl:text>false</xsl:text>
        </HighImportance>
      </EmailMetaData>
      <EmailContentData>
        <BodyType>
          <xsl:text>html</xsl:text>
        </BodyType>
        <Transform>
          <xsl:text>true</xsl:text>
        </Transform>
        <xsl:variable name=""var:v9"" select=""ScriptNS0:XslPath(string($var:v8))"" />
        <PathToTransform>
          <xsl:value-of select=""$var:v9"" />
        </PathToTransform>
        <BodyEncoding>
          <xsl:text>UTF8</xsl:text>
        </BodyEncoding>
        <BodyNonRecurring>
          <xsl:if test=""Meta_RF01"">
            <P1>
              <xsl:value-of select=""Meta_RF01/text()"" />
            </P1>
          </xsl:if>
          <xsl:if test=""Meta_RF02"">
            <xsl:variable name=""var:v10"" select=""string(Meta_RF02/@xsi:nil) = 'true'"" />
            <xsl:if test=""string($var:v10)='true'"">
              <P2>
                <xsl:attribute name=""xsi:nil"">
                  <xsl:value-of select=""'true'"" />
                </xsl:attribute>
              </P2>
            </xsl:if>
            <xsl:if test=""string($var:v10)='false'"">
              <P2>
                <xsl:value-of select=""Meta_RF02/text()"" />
              </P2>
            </xsl:if>
          </xsl:if>
          <xsl:if test=""Meta_RF03"">
            <xsl:variable name=""var:v11"" select=""string(Meta_RF03/@xsi:nil) = 'true'"" />
            <xsl:if test=""string($var:v11)='true'"">
              <P3>
                <xsl:attribute name=""xsi:nil"">
                  <xsl:value-of select=""'true'"" />
                </xsl:attribute>
              </P3>
            </xsl:if>
            <xsl:if test=""string($var:v11)='false'"">
              <P3>
                <xsl:value-of select=""Meta_RF03/text()"" />
              </P3>
            </xsl:if>
          </xsl:if>
          <xsl:if test=""Meta_RF04"">
            <xsl:variable name=""var:v12"" select=""string(Meta_RF04/@xsi:nil) = 'true'"" />
            <xsl:if test=""string($var:v12)='true'"">
              <P4>
                <xsl:attribute name=""xsi:nil"">
                  <xsl:value-of select=""'true'"" />
                </xsl:attribute>
              </P4>
            </xsl:if>
            <xsl:if test=""string($var:v12)='false'"">
              <P4>
                <xsl:value-of select=""Meta_RF04/text()"" />
              </P4>
            </xsl:if>
          </xsl:if>
          <P5>
            <xsl:value-of select=""$var:v13"" />
          </P5>
        </BodyNonRecurring>
      </EmailContentData>
      <ErrorHandle>
        <SuspendTs>
          <xsl:value-of select=""$var:v2"" />
        </SuspendTs>
        <EmailDidError>
          <xsl:text>0</xsl:text>
        </EmailDidError>
      </ErrorHandle>
    </ns0:MSSNotifyEmail>
  </xsl:template>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp""><![CDATA[
public string StringConcat(string param0)
{
   return param0;
}


public string DateCurrentDateTime()
{
	DateTime dt = DateTime.Now;
	string curdate = dt.ToString(""yyyy-MM-dd"", System.Globalization.CultureInfo.InvariantCulture);
	string curtime = dt.ToString(""T"", System.Globalization.CultureInfo.InvariantCulture);
	string retval = curdate + ""T"" + curtime;
	return retval;
}


public string StringConcat(string param0, string param1, string param2, string param3)
{
   return param0 + param1 + param2 + param3;
}


public string StringConcat(string param0, string param1, string param2)
{
   return param0 + param1 + param2;
}



]]></msxsl:script>
</xsl:stylesheet>";
        
        private const string _strArgList = @"<ExtensionObjects>
  <ExtensionObject Namespace=""http://schemas.microsoft.com/BizTalk/2003/ScriptNS0"" AssemblyName=""MFM.Lbg.Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=b52a4a519c43e251"" ClassName=""MFM.Lbg.Helper.Misc"" />
</ExtensionObjects>";
        
        private const string _strSrcSchemasList0 = @"MFM.Lbg.Schemas.MFMWorkItemUpdate";
        
        private const global::MFM.Lbg.Schemas.MFMWorkItemUpdate _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"MSS.Notification.Service.MSSNotifyEmail";
        
        private const global::MSS.Notification.Service.MSSNotifyEmail _trgSchemaTypeReference0 = null;
        
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
                _TrgSchemas[0] = @"MSS.Notification.Service.MSSNotifyEmail";
                return _TrgSchemas;
            }
        }
    }
}
