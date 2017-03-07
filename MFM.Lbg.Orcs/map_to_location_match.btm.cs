namespace MFM.Lbg.Orcs {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"MFM.Lbg.Schemas.DistibutedWorkItems", typeof(global::MFM.Lbg.Schemas.DistibutedWorkItems))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"MFM.Lbg.Schemas.VFM_MPCITypedProcedure_dbo+biz_Beacon_Fetch_Property_Match", typeof(global::MFM.Lbg.Schemas.VFM_MPCITypedProcedure_dbo.biz_Beacon_Fetch_Property_Match))]
    public sealed class map_to_location_match : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s6 s0 s7 s10 s2 s1 s4 s11 s9 s5 s12 s3 s8"" version=""1.0"" xmlns:s6=""http://MFMSharedResources/Types/Helpdesk/v1/MSurveySet"" xmlns:s0=""http://MFMSharedResources/Types/Helpdesk/v1/IssuedWork"" xmlns:s7=""http://MFMSharedResources/Types/Helpdesk/v1/MSurveyQuestion"" xmlns:s10=""http://MFMSharedResources/Types/Helpdesk/v1/Customer"" xmlns:ns0=""http://schemas.microsoft.com/Sql/2008/05/TypedProcedures/dbo"" xmlns:ns3=""http://schemas.microsoft.com/Sql/2008/05/ProceduresResultSets/dbo/biz_Beacon_Fetch_Property_Match"" xmlns:s2=""http://MFMSharedResources/Types/Helpdesk/v1/Vendor"" xmlns:s1=""http://MFM.Lbg.Schemas.DistibutedWorkItems"" xmlns:s4=""http://MFMSharedResources/Types/Helpdesk/v1/Person"" xmlns:s11=""http://MFMSharedResources/Types/Helpdesk/v1/MSurvey"" xmlns:s9=""http://MFMSharedResources/Types/Helpdesk/v1/Workitem"" xmlns:s5=""http://MFMSharedResources/Types/Helpdesk/v1/Location"" xmlns:ns4=""http://schemas.microsoft.com/Sql/2008/05/ProceduresResultSets/dbo/biz_create_safe_visit"" xmlns:s12=""http://MFMSharedResources/Types/Helpdesk/v1/Service"" xmlns:s3=""http://MFMSharedResources/Types/Helpdesk/v1/MRouting"" xmlns:s8=""http://MFMSharedResources/Types/Helpdesk/v1/Address"" xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s1:DistributedWorkItems"" />
  </xsl:template>
  <xsl:template match=""/s1:DistributedWorkItems"">
    <ns0:biz_Beacon_Fetch_Property_Match>
      <xsl:if test=""s0:IssuedWork/s9:Workitem/s5:Location/linkMitiePropertyCode"">
        <xsl:variable name=""var:v1"" select=""string(s0:IssuedWork/s9:Workitem/s5:Location/linkMitiePropertyCode/@xsi:nil) = 'true'"" />
        <xsl:if test=""string($var:v1)='true'"">
          <ns0:propertyid>
            <xsl:attribute name=""xsi:nil"">
              <xsl:value-of select=""'true'"" />
            </xsl:attribute>
          </ns0:propertyid>
        </xsl:if>
        <xsl:if test=""string($var:v1)='false'"">
          <ns0:propertyid>
            <xsl:value-of select=""s0:IssuedWork/s9:Workitem/s5:Location/linkMitiePropertyCode/text()"" />
          </ns0:propertyid>
        </xsl:if>
      </xsl:if>
      <xsl:if test=""s0:IssuedWork/s9:Workitem/s12:MService/VendorCode"">
        <ns0:callout>
          <xsl:value-of select=""s0:IssuedWork/s9:Workitem/s12:MService/VendorCode/text()"" />
        </ns0:callout>
      </xsl:if>
      <xsl:if test=""s0:IssuedWork/s2:Vendor/s4:Person/EmailAddress"">
        <xsl:variable name=""var:v2"" select=""string(s0:IssuedWork/s2:Vendor/s4:Person/EmailAddress/@xsi:nil) = 'true'"" />
        <xsl:if test=""string($var:v2)='true'"">
          <ns0:notify>
            <xsl:attribute name=""xsi:nil"">
              <xsl:value-of select=""'true'"" />
            </xsl:attribute>
          </ns0:notify>
        </xsl:if>
        <xsl:if test=""string($var:v2)='false'"">
          <ns0:notify>
            <xsl:value-of select=""s0:IssuedWork/s2:Vendor/s4:Person/EmailAddress/text()"" />
          </ns0:notify>
        </xsl:if>
      </xsl:if>
    </ns0:biz_Beacon_Fetch_Property_Match>
  </xsl:template>
</xsl:stylesheet>";
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"MFM.Lbg.Schemas.DistibutedWorkItems";
        
        private const global::MFM.Lbg.Schemas.DistibutedWorkItems _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"MFM.Lbg.Schemas.VFM_MPCITypedProcedure_dbo+biz_Beacon_Fetch_Property_Match";
        
        private const global::MFM.Lbg.Schemas.VFM_MPCITypedProcedure_dbo.biz_Beacon_Fetch_Property_Match _trgSchemaTypeReference0 = null;
        
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
                _TrgSchemas[0] = @"MFM.Lbg.Schemas.VFM_MPCITypedProcedure_dbo+biz_Beacon_Fetch_Property_Match";
                return _TrgSchemas;
            }
        }
    }
}
