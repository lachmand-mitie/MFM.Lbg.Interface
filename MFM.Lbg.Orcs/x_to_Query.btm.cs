namespace MFM.Lbg.Orcs {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"MFM.Lbg.Schemas.DistibutedWorkItems", typeof(global::MFM.Lbg.Schemas.DistibutedWorkItems))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"MFM.Lbg.Orcs.GenItems.MTFMVISIONFM_MTFMVISIONLOCQUERY_www_ibm_com_maximo+QueryMXVISIONLOCQUERY", typeof(global::MFM.Lbg.Orcs.GenItems.MTFMVISIONFM_MTFMVISIONLOCQUERY_www_ibm_com_maximo.QueryMXVISIONLOCQUERY))]
    public sealed class x_to_Query : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s6 s0 s7 s10 s2 s1 s4 s11 s9 s5 s12 s3 s8"" version=""1.0"" xmlns:s6=""http://MFMSharedResources/Types/Helpdesk/v1/MSurveySet"" xmlns:s0=""http://MFMSharedResources/Types/Helpdesk/v1/IssuedWork"" xmlns:s7=""http://MFMSharedResources/Types/Helpdesk/v1/MSurveyQuestion"" xmlns:s10=""http://MFMSharedResources/Types/Helpdesk/v1/Customer"" xmlns:s2=""http://MFMSharedResources/Types/Helpdesk/v1/Vendor"" xmlns:s1=""http://MFM.Lbg.Schemas.DistibutedWorkItems"" xmlns:s12=""http://MFMSharedResources/Types/Helpdesk/v1/Service"" xmlns:s4=""http://MFMSharedResources/Types/Helpdesk/v1/Person"" xmlns:s11=""http://MFMSharedResources/Types/Helpdesk/v1/MSurvey"" xmlns:s9=""http://MFMSharedResources/Types/Helpdesk/v1/Workitem"" xmlns:s5=""http://MFMSharedResources/Types/Helpdesk/v1/Location"" xmlns:ns0=""http://www.ibm.com/maximo"" xmlns:s3=""http://MFMSharedResources/Types/Helpdesk/v1/MRouting"" xmlns:s8=""http://MFMSharedResources/Types/Helpdesk/v1/Address"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s1:DistributedWorkItems"" />
  </xsl:template>
  <xsl:template match=""/s1:DistributedWorkItems"">
    <ns0:QueryMXVISIONLOCQUERY>
      <xsl:attribute name=""uniqueResult"">
        <xsl:text>1</xsl:text>
      </xsl:attribute>
      <xsl:attribute name=""maxItems"">
        <xsl:text>1</xsl:text>
      </xsl:attribute>
      <xsl:attribute name=""rsStart"">
        <xsl:text>0</xsl:text>
      </xsl:attribute>
      <ns0:MXVISIONLOCQUERYQuery>
        <xsl:attribute name=""operandMode"">
          <xsl:text>AND</xsl:text>
        </xsl:attribute>
        <ns0:LOCATIONS>
          <xsl:for-each select=""s0:IssuedWork/s9:Workitem/s5:Location"">
            <xsl:for-each select=""s8:Address"">
              <ns0:MTFMBLDGCLASS1>
                <xsl:attribute name=""operator"">
                  <xsl:text>=</xsl:text>
                </xsl:attribute>
                <xsl:if test=""siteSiteID"">
                  <xsl:value-of select=""siteSiteID/text()"" />
                </xsl:if>
              </ns0:MTFMBLDGCLASS1>
            </xsl:for-each>
          </xsl:for-each>
          <xsl:for-each select=""s0:IssuedWork/s9:Workitem/s5:Location"">
            <ns0:MTFMBLDGCLASS2>
              <xsl:attribute name=""operator"">
                <xsl:text>=</xsl:text>
              </xsl:attribute>
              <xsl:if test=""linkpropertyid"">
                <xsl:value-of select=""linkpropertyid/text()"" />
              </xsl:if>
            </ns0:MTFMBLDGCLASS2>
          </xsl:for-each>
          <ns0:TYPE>
            <xsl:text>SERVICE</xsl:text>
          </ns0:TYPE>
        </ns0:LOCATIONS>
      </ns0:MXVISIONLOCQUERYQuery>
    </ns0:QueryMXVISIONLOCQUERY>
  </xsl:template>
</xsl:stylesheet>";
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"MFM.Lbg.Schemas.DistibutedWorkItems";
        
        private const global::MFM.Lbg.Schemas.DistibutedWorkItems _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"MFM.Lbg.Orcs.GenItems.MTFMVISIONFM_MTFMVISIONLOCQUERY_www_ibm_com_maximo+QueryMXVISIONLOCQUERY";
        
        private const global::MFM.Lbg.Orcs.GenItems.MTFMVISIONFM_MTFMVISIONLOCQUERY_www_ibm_com_maximo.QueryMXVISIONLOCQUERY _trgSchemaTypeReference0 = null;
        
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
                _TrgSchemas[0] = @"MFM.Lbg.Orcs.GenItems.MTFMVISIONFM_MTFMVISIONLOCQUERY_www_ibm_com_maximo+QueryMXVISIONLOCQUERY";
                return _TrgSchemas;
            }
        }
    }
}
