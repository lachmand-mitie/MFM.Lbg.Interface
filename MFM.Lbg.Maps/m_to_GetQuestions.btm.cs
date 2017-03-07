namespace MFM.Lbg.Maps {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"MFM.Lbg.Schemas.DistibutedWorkItems", typeof(global::MFM.Lbg.Schemas.DistibutedWorkItems))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"MFM.Lbg.Schemas.biz_Get_Questions_TypedProcedure_dbo+biz_Get_Questions", typeof(global::MFM.Lbg.Schemas.biz_Get_Questions_TypedProcedure_dbo.biz_Get_Questions))]
    public sealed class m_to_GetQuestions : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s6 s0 s7 s10 s2 s1 s4 s11 s9 s5 s12 s3 s8"" version=""1.0"" xmlns:s5=""http://MFMSharedResources/Types/Helpdesk/v1/Location"" xmlns:ns3=""http://schemas.microsoft.com/Sql/2008/05/ProceduresResultSets/dbo/biz_Get_Questions"" xmlns:s0=""http://MFMSharedResources/Types/Helpdesk/v1/IssuedWork"" xmlns:s7=""http://MFMSharedResources/Types/Helpdesk/v1/MSurveyQuestion"" xmlns:s10=""http://MFMSharedResources/Types/Helpdesk/v1/Customer"" xmlns:ns0=""http://schemas.microsoft.com/Sql/2008/05/TypedProcedures/dbo"" xmlns:s2=""http://MFMSharedResources/Types/Helpdesk/v1/Vendor"" xmlns:s6=""http://MFMSharedResources/Types/Helpdesk/v1/MSurveySet"" xmlns:s1=""http://MFM.Lbg.Schemas.DistibutedWorkItems"" xmlns:s4=""http://MFMSharedResources/Types/Helpdesk/v1/Person"" xmlns:s11=""http://MFMSharedResources/Types/Helpdesk/v1/MSurvey"" xmlns:s9=""http://MFMSharedResources/Types/Helpdesk/v1/Workitem"" xmlns:s12=""http://MFMSharedResources/Types/Helpdesk/v1/Service"" xmlns:s3=""http://MFMSharedResources/Types/Helpdesk/v1/MRouting"" xmlns:s8=""http://MFMSharedResources/Types/Helpdesk/v1/Address"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s1:DistributedWorkItems"" />
  </xsl:template>
  <xsl:template match=""/s1:DistributedWorkItems"">
    <ns0:biz_Get_Questions>
      <ns0:caseid>
        <xsl:value-of select=""s0:IssuedWork/s9:Workitem/s9:HelpdeskId/text()"" />
      </ns0:caseid>
      <xsl:value-of select=""s0:IssuedWork/s9:Workitem/text()"" />
    </ns0:biz_Get_Questions>
  </xsl:template>
</xsl:stylesheet>";
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"MFM.Lbg.Schemas.DistibutedWorkItems";
        
        private const global::MFM.Lbg.Schemas.DistibutedWorkItems _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"MFM.Lbg.Schemas.biz_Get_Questions_TypedProcedure_dbo+biz_Get_Questions";
        
        private const global::MFM.Lbg.Schemas.biz_Get_Questions_TypedProcedure_dbo.biz_Get_Questions _trgSchemaTypeReference0 = null;
        
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
                _TrgSchemas[0] = @"MFM.Lbg.Schemas.biz_Get_Questions_TypedProcedure_dbo+biz_Get_Questions";
                return _TrgSchemas;
            }
        }
    }
}
