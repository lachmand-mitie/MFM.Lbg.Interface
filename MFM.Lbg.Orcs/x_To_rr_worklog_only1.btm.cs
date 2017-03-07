namespace MFM.Lbg.Orcs {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"MTFM.Maximo.RR.RRMIAMI_RRMIAMIWOUPDATEIFACE_www_ibm_com_maximo+UpdateRRMIAMIWOUPDATE", typeof(global::MTFM.Maximo.RR.RRMIAMI_RRMIAMIWOUPDATEIFACE_www_ibm_com_maximo.UpdateRRMIAMIWOUPDATE))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"MTFM.Maximo.RR.RRMIAMI_RRMIAMIWOUPDATEIFACE_www_ibm_com_maximo+UpdateRRMIAMIWOUPDATE", typeof(global::MTFM.Maximo.RR.RRMIAMI_RRMIAMIWOUPDATEIFACE_www_ibm_com_maximo.UpdateRRMIAMIWOUPDATE))]
    public sealed class x_To_rr_worklog_only1 : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var"" version=""1.0"" xmlns:ns0=""http://www.ibm.com/maximo"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/ns0:UpdateRRMIAMIWOUPDATE"" />
  </xsl:template>
  <xsl:template match=""/ns0:UpdateRRMIAMIWOUPDATE"">
    <ns0:UpdateRRMIAMIWOUPDATE>
      <xsl:if test=""@creationDateTime"">
        <xsl:attribute name=""creationDateTime"">
          <xsl:value-of select=""@creationDateTime"" />
        </xsl:attribute>
      </xsl:if>
      <xsl:if test=""@baseLanguage"">
        <xsl:attribute name=""baseLanguage"">
          <xsl:value-of select=""@baseLanguage"" />
        </xsl:attribute>
      </xsl:if>
      <xsl:if test=""@transLanguage"">
        <xsl:attribute name=""transLanguage"">
          <xsl:value-of select=""@transLanguage"" />
        </xsl:attribute>
      </xsl:if>
      <xsl:if test=""@messageID"">
        <xsl:attribute name=""messageID"">
          <xsl:value-of select=""@messageID"" />
        </xsl:attribute>
      </xsl:if>
      <xsl:if test=""@maximoVersion"">
        <xsl:attribute name=""maximoVersion"">
          <xsl:value-of select=""@maximoVersion"" />
        </xsl:attribute>
      </xsl:if>
      <ns0:RRMIAMIWOUPDATESet>
        <xsl:for-each select=""ns0:RRMIAMIWOUPDATESet/ns0:WORKORDER"">
          <ns0:WORKORDER>
            <xsl:if test=""@transLanguage"">
              <xsl:attribute name=""transLanguage"">
                <xsl:value-of select=""@transLanguage"" />
              </xsl:attribute>
            </xsl:if>
            <xsl:if test=""@action"">
              <xsl:attribute name=""action"">
                <xsl:value-of select=""@action"" />
              </xsl:attribute>
            </xsl:if>
            <xsl:if test=""@relationship"">
              <xsl:attribute name=""relationship"">
                <xsl:value-of select=""@relationship"" />
              </xsl:attribute>
            </xsl:if>
            <xsl:if test=""@deleteForInsert"">
              <xsl:attribute name=""deleteForInsert"">
                <xsl:value-of select=""@deleteForInsert"" />
              </xsl:attribute>
            </xsl:if>
            <xsl:if test=""ns0:MAXINTERRORMSG"">
              <ns0:MAXINTERRORMSG>
                <xsl:value-of select=""ns0:MAXINTERRORMSG/text()"" />
              </ns0:MAXINTERRORMSG>
            </xsl:if>
            <xsl:for-each select=""ns0:MTFMWONUM"">
              <ns0:MTFMWONUM>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:MTFMWONUM>
            </xsl:for-each>
            <xsl:for-each select=""ns0:SITEID"">
              <ns0:SITEID>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:SITEID>
            </xsl:for-each>
            <xsl:for-each select=""ns0:WONUM"">
              <ns0:WONUM>
                <xsl:value-of select=""./text()"" />
              </ns0:WONUM>
            </xsl:for-each>
            <xsl:for-each select=""ns0:WORKLOG"">
              <ns0:WORKLOG>
                <xsl:if test=""@action"">
                  <xsl:attribute name=""action"">
                    <xsl:value-of select=""@action"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:if test=""@relationship"">
                  <xsl:attribute name=""relationship"">
                    <xsl:value-of select=""@relationship"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:if test=""@deleteForInsert"">
                  <xsl:attribute name=""deleteForInsert"">
                    <xsl:value-of select=""@deleteForInsert"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:for-each select=""ns0:CLASS"">
                  <ns0:CLASS>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:CLASS>
                </xsl:for-each>
                <xsl:for-each select=""ns0:CREATEBY"">
                  <ns0:CREATEBY>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:CREATEBY>
                </xsl:for-each>
                <xsl:for-each select=""ns0:CREATEDATE"">
                  <ns0:CREATEDATE>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:CREATEDATE>
                </xsl:for-each>
                <xsl:for-each select=""ns0:DESCRIPTION"">
                  <ns0:DESCRIPTION>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:DESCRIPTION>
                </xsl:for-each>
                <xsl:for-each select=""ns0:DESCRIPTION_LONGDESCRIPTION"">
                  <ns0:DESCRIPTION_LONGDESCRIPTION>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:DESCRIPTION_LONGDESCRIPTION>
                </xsl:for-each>
                <xsl:for-each select=""ns0:LOGTYPE"">
                  <ns0:LOGTYPE>
                    <xsl:if test=""@maxvalue"">
                      <xsl:attribute name=""maxvalue"">
                        <xsl:value-of select=""@maxvalue"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:LOGTYPE>
                </xsl:for-each>
                <xsl:for-each select=""ns0:MODIFYBY"">
                  <ns0:MODIFYBY>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:MODIFYBY>
                </xsl:for-each>
                <xsl:for-each select=""ns0:MODIFYDATE"">
                  <ns0:MODIFYDATE>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:MODIFYDATE>
                </xsl:for-each>
                <xsl:for-each select=""ns0:RECORDKEY"">
                  <ns0:RECORDKEY>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:RECORDKEY>
                </xsl:for-each>
                <xsl:value-of select=""./text()"" />
              </ns0:WORKLOG>
            </xsl:for-each>
            <xsl:value-of select=""./text()"" />
          </ns0:WORKORDER>
        </xsl:for-each>
        <xsl:value-of select=""ns0:RRMIAMIWOUPDATESet/text()"" />
      </ns0:RRMIAMIWOUPDATESet>
    </ns0:UpdateRRMIAMIWOUPDATE>
  </xsl:template>
</xsl:stylesheet>";
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"MTFM.Maximo.RR.RRMIAMI_RRMIAMIWOUPDATEIFACE_www_ibm_com_maximo+UpdateRRMIAMIWOUPDATE";
        
        private const global::MTFM.Maximo.RR.RRMIAMI_RRMIAMIWOUPDATEIFACE_www_ibm_com_maximo.UpdateRRMIAMIWOUPDATE _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"MTFM.Maximo.RR.RRMIAMI_RRMIAMIWOUPDATEIFACE_www_ibm_com_maximo+UpdateRRMIAMIWOUPDATE";
        
        private const global::MTFM.Maximo.RR.RRMIAMI_RRMIAMIWOUPDATEIFACE_www_ibm_com_maximo.UpdateRRMIAMIWOUPDATE _trgSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"MTFM.Maximo.RR.RRMIAMI_RRMIAMIWOUPDATEIFACE_www_ibm_com_maximo+UpdateRRMIAMIWOUPDATE";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"MTFM.Maximo.RR.RRMIAMI_RRMIAMIWOUPDATEIFACE_www_ibm_com_maximo+UpdateRRMIAMIWOUPDATE";
                return _TrgSchemas;
            }
        }
    }
}
