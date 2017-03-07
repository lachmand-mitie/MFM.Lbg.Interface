namespace MFM.Lbg.Orcs {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"MFM.Lbg.Schemas.DistibutedWorkItems", typeof(global::MFM.Lbg.Schemas.DistibutedWorkItems))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"MSS.Notification.Service.MSSNotifyEmail", typeof(global::MSS.Notification.Service.MSSNotifyEmail))]
    public sealed class Base_Email_Notification : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s6 s0 s7 s10 s2 s1 s4 s11 s9 s5 s12 s3 s8 userCSharp ScriptNS0"" version=""1.0"" xmlns:s5=""http://MFMSharedResources/Types/Helpdesk/v1/Location"" xmlns:s0=""http://MFMSharedResources/Types/Helpdesk/v1/IssuedWork"" xmlns:s7=""http://MFMSharedResources/Types/Helpdesk/v1/MSurveyQuestion"" xmlns:s10=""http://MFMSharedResources/Types/Helpdesk/v1/Customer"" xmlns:s2=""http://MFMSharedResources/Types/Helpdesk/v1/Vendor"" xmlns:s6=""http://MFMSharedResources/Types/Helpdesk/v1/MSurveySet"" xmlns:s1=""http://MFM.Lbg.Schemas.DistibutedWorkItems"" xmlns:s4=""http://MFMSharedResources/Types/Helpdesk/v1/Person"" xmlns:s11=""http://MFMSharedResources/Types/Helpdesk/v1/MSurvey"" xmlns:s9=""http://MFMSharedResources/Types/Helpdesk/v1/Workitem"" xmlns:ns0=""http://MSS.Notification.Service.NotifyEmail/v1"" xmlns:s12=""http://MFMSharedResources/Types/Helpdesk/v1/Service"" xmlns:s3=""http://MFMSharedResources/Types/Helpdesk/v1/MRouting"" xmlns:s8=""http://MFMSharedResources/Types/Helpdesk/v1/Address"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"" xmlns:ScriptNS0=""http://schemas.microsoft.com/BizTalk/2003/ScriptNS0"" xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s1:DistributedWorkItems"" />
  </xsl:template>
  <xsl:template match=""/s1:DistributedWorkItems"">
    <xsl:variable name=""var:v1"" select=""userCSharp:DateCurrentDateTime()"" />
    <xsl:variable name=""var:v3"" select=""userCSharp:StringConcat(&quot;&quot;)"" />
    <ns0:MSSNotifyEmail>
      <ApplicationName>
        <xsl:text>MFM.Helpdesk.Distributor</xsl:text>
      </ApplicationName>
      <CreatedTs>
        <xsl:value-of select=""$var:v1"" />
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
        <xsl:variable name=""var:v2"" select=""ScriptNS0:GetVisionFMSupportMailbox()"" />
        <To>
          <xsl:value-of select=""$var:v2"" />
        </To>
        <From>
          <xsl:text>no.reply@mitie.com</xsl:text>
        </From>
        <Subject>
          <xsl:text>tempvalue</xsl:text>
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
        <PathToTransform>
          <xsl:text>tempvalue</xsl:text>
        </PathToTransform>
        <BodyEncoding>
          <xsl:text>UTF8</xsl:text>
        </BodyEncoding>
        <BodyNonRecurring>
          <P1>
            <xsl:value-of select=""s0:IssuedWork/s3:MRoute/ContractName/text()"" />
          </P1>
          <P2>
            <xsl:value-of select=""$var:v3"" />
          </P2>
          <xsl:variable name=""var:v4"" select=""string(s0:IssuedWork/s9:Workitem/s9:HelpdeskReference/@xsi:nil) = 'true'"" />
          <xsl:if test=""string($var:v4)='true'"">
            <P3>
              <xsl:attribute name=""xsi:nil"">
                <xsl:value-of select=""'true'"" />
              </xsl:attribute>
            </P3>
          </xsl:if>
          <xsl:if test=""string($var:v4)='false'"">
            <P3>
              <xsl:value-of select=""s0:IssuedWork/s9:Workitem/s9:HelpdeskReference/text()"" />
            </P3>
          </xsl:if>
          <P4>
            <xsl:value-of select=""$var:v3"" />
          </P4>
          <P5>
            <xsl:value-of select=""$var:v3"" />
          </P5>
        </BodyNonRecurring>
      </EmailContentData>
      <ErrorHandle>
        <SuspendTs>
          <xsl:value-of select=""$var:v1"" />
        </SuspendTs>
        <EmailDidError>
          <xsl:text>0</xsl:text>
        </EmailDidError>
      </ErrorHandle>
      <xsl:value-of select=""./text()"" />
    </ns0:MSSNotifyEmail>
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



]]></msxsl:script>
</xsl:stylesheet>";
        
        private const string _strArgList = @"<ExtensionObjects>
  <ExtensionObject Namespace=""http://schemas.microsoft.com/BizTalk/2003/ScriptNS0"" AssemblyName=""MFM.Lbg.Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=b52a4a519c43e251"" ClassName=""MFM.Lbg.Helper.Misc"" />
</ExtensionObjects>";
        
        private const string _strSrcSchemasList0 = @"MFM.Lbg.Schemas.DistibutedWorkItems";
        
        private const global::MFM.Lbg.Schemas.DistibutedWorkItems _srcSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"MFM.Lbg.Schemas.DistibutedWorkItems";
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
