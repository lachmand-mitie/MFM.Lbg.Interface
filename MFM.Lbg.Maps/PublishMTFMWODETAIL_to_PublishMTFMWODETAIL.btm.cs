namespace MFM.Lbg.Maps {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"MFM.Lbg.Schemas.MTFMWODETAILService+PublishMTFMWODETAIL", typeof(global::MFM.Lbg.Schemas.MTFMWODETAILService.PublishMTFMWODETAIL))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"MFM.Lbg.Schemas.MTFMWODETAILService+PublishMTFMWODETAIL", typeof(global::MFM.Lbg.Schemas.MTFMWODETAILService.PublishMTFMWODETAIL))]
    public sealed class PublishMTFMWODETAIL_to_PublishMTFMWODETAIL : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var userCSharp"" version=""1.0"" xmlns:ns0=""http://www.ibm.com/maximo"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/ns0:PublishMTFMWODETAIL"" />
  </xsl:template>
  <xsl:template match=""/ns0:PublishMTFMWODETAIL"">
    <ns0:PublishMTFMWODETAIL>
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
      <xsl:if test=""@event"">
        <xsl:attribute name=""event"">
          <xsl:value-of select=""@event"" />
        </xsl:attribute>
      </xsl:if>
      <ns0:MTFMWODETAILSet>
        <xsl:for-each select=""ns0:MTFMWODETAILSet/ns0:WORKORDER"">
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
            <xsl:for-each select=""ns0:ACTFINISH"">
              <ns0:ACTFINISH>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:ACTFINISH>
            </xsl:for-each>
            <xsl:for-each select=""ns0:ACTINTLABCOST"">
              <ns0:ACTINTLABCOST>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:ACTINTLABCOST>
            </xsl:for-each>
            <xsl:for-each select=""ns0:ACTINTLABHRS"">
              <ns0:ACTINTLABHRS>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:ACTINTLABHRS>
            </xsl:for-each>
            <xsl:for-each select=""ns0:ACTLABCOST"">
              <ns0:ACTLABCOST>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:ACTLABCOST>
            </xsl:for-each>
            <xsl:for-each select=""ns0:ACTLABHRS"">
              <ns0:ACTLABHRS>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:ACTLABHRS>
            </xsl:for-each>
            <xsl:for-each select=""ns0:ACTMATCOST"">
              <ns0:ACTMATCOST>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:ACTMATCOST>
            </xsl:for-each>
            <xsl:for-each select=""ns0:ACTOUTLABCOST"">
              <ns0:ACTOUTLABCOST>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:ACTOUTLABCOST>
            </xsl:for-each>
            <xsl:for-each select=""ns0:ACTOUTLABHRS"">
              <ns0:ACTOUTLABHRS>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:ACTOUTLABHRS>
            </xsl:for-each>
            <xsl:for-each select=""ns0:ACTSERVCOST"">
              <ns0:ACTSERVCOST>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:ACTSERVCOST>
            </xsl:for-each>
            <xsl:for-each select=""ns0:ACTSTART"">
              <ns0:ACTSTART>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:ACTSTART>
            </xsl:for-each>
            <xsl:for-each select=""ns0:ACTTOOLCOST"">
              <ns0:ACTTOOLCOST>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:ACTTOOLCOST>
            </xsl:for-each>
            <xsl:for-each select=""ns0:ASSETLOCPRIORITY"">
              <ns0:ASSETLOCPRIORITY>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:ASSETLOCPRIORITY>
            </xsl:for-each>
            <xsl:for-each select=""ns0:ASSETNUM"">
              <ns0:ASSETNUM>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:ASSETNUM>
            </xsl:for-each>
            <xsl:for-each select=""ns0:ASSIGNEDOWNERGROUP"">
              <ns0:ASSIGNEDOWNERGROUP>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:ASSIGNEDOWNERGROUP>
            </xsl:for-each>
            <xsl:for-each select=""ns0:AVAILSTATUSDATE"">
              <ns0:AVAILSTATUSDATE>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:AVAILSTATUSDATE>
            </xsl:for-each>
            <xsl:for-each select=""ns0:BACKOUTPLAN"">
              <ns0:BACKOUTPLAN>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:BACKOUTPLAN>
            </xsl:for-each>
            <xsl:for-each select=""ns0:CALCCALENDAR"">
              <ns0:CALCCALENDAR>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:CALCCALENDAR>
            </xsl:for-each>
            <xsl:for-each select=""ns0:CALCORGID"">
              <ns0:CALCORGID>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:CALCORGID>
            </xsl:for-each>
            <xsl:for-each select=""ns0:CALCPRIORITY"">
              <ns0:CALCPRIORITY>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:CALCPRIORITY>
            </xsl:for-each>
            <xsl:for-each select=""ns0:CALCSHIFT"">
              <ns0:CALCSHIFT>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:CALCSHIFT>
            </xsl:for-each>
            <xsl:for-each select=""ns0:CALENDAR"">
              <ns0:CALENDAR>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:CALENDAR>
            </xsl:for-each>
            <xsl:for-each select=""ns0:CHANGEBY"">
              <ns0:CHANGEBY>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:CHANGEBY>
            </xsl:for-each>
            <xsl:for-each select=""ns0:CHANGEDATE"">
              <ns0:CHANGEDATE>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:CHANGEDATE>
            </xsl:for-each>
            <xsl:for-each select=""ns0:CHARGEABLE"">
              <ns0:CHARGEABLE>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:CHARGEABLE>
            </xsl:for-each>
            <xsl:for-each select=""ns0:CHARGESTORE"">
              <ns0:CHARGESTORE>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:CHARGESTORE>
            </xsl:for-each>
            <xsl:for-each select=""ns0:CINUM"">
              <ns0:CINUM>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:CINUM>
            </xsl:for-each>
            <xsl:for-each select=""ns0:CLASSSTRUCTUREID"">
              <ns0:CLASSSTRUCTUREID>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:CLASSSTRUCTUREID>
            </xsl:for-each>
            <xsl:for-each select=""ns0:CLIENTPO"">
              <ns0:CLIENTPO>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:CLIENTPO>
            </xsl:for-each>
            <xsl:for-each select=""ns0:CLIENTREF"">
              <ns0:CLIENTREF>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:CLIENTREF>
            </xsl:for-each>
            <xsl:for-each select=""ns0:COMMODITY"">
              <ns0:COMMODITY>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:COMMODITY>
            </xsl:for-each>
            <xsl:for-each select=""ns0:COMMODITYGROUP"">
              <ns0:COMMODITYGROUP>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:COMMODITYGROUP>
            </xsl:for-each>
            <xsl:for-each select=""ns0:CONTRACT"">
              <ns0:CONTRACT>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:CONTRACT>
            </xsl:for-each>
            <xsl:for-each select=""ns0:CREWID"">
              <ns0:CREWID>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:CREWID>
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
            <xsl:for-each select=""ns0:DIRISSUEMTLSTATUS"">
              <ns0:DIRISSUEMTLSTATUS>
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
              </ns0:DIRISSUEMTLSTATUS>
            </xsl:for-each>
            <xsl:for-each select=""ns0:DISABLED"">
              <ns0:DISABLED>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:DISABLED>
            </xsl:for-each>
            <xsl:for-each select=""ns0:DOWNTIME"">
              <ns0:DOWNTIME>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:DOWNTIME>
            </xsl:for-each>
            <xsl:for-each select=""ns0:ENVIRONMENT"">
              <ns0:ENVIRONMENT>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:ENVIRONMENT>
            </xsl:for-each>
            <xsl:for-each select=""ns0:ESTATAPPRINTLABCOST"">
              <ns0:ESTATAPPRINTLABCOST>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:ESTATAPPRINTLABCOST>
            </xsl:for-each>
            <xsl:for-each select=""ns0:ESTATAPPRINTLABHRS"">
              <ns0:ESTATAPPRINTLABHRS>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:ESTATAPPRINTLABHRS>
            </xsl:for-each>
            <xsl:for-each select=""ns0:ESTATAPPRLABCOST"">
              <ns0:ESTATAPPRLABCOST>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:ESTATAPPRLABCOST>
            </xsl:for-each>
            <xsl:for-each select=""ns0:ESTATAPPRLABHRS"">
              <ns0:ESTATAPPRLABHRS>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:ESTATAPPRLABHRS>
            </xsl:for-each>
            <xsl:for-each select=""ns0:ESTATAPPRMATCOST"">
              <ns0:ESTATAPPRMATCOST>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:ESTATAPPRMATCOST>
            </xsl:for-each>
            <xsl:for-each select=""ns0:ESTATAPPROUTLABCOST"">
              <ns0:ESTATAPPROUTLABCOST>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:ESTATAPPROUTLABCOST>
            </xsl:for-each>
            <xsl:for-each select=""ns0:ESTATAPPROUTLABHRS"">
              <ns0:ESTATAPPROUTLABHRS>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:ESTATAPPROUTLABHRS>
            </xsl:for-each>
            <xsl:for-each select=""ns0:ESTATAPPRSERVCOST"">
              <ns0:ESTATAPPRSERVCOST>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:ESTATAPPRSERVCOST>
            </xsl:for-each>
            <xsl:for-each select=""ns0:ESTATAPPRTOOLCOST"">
              <ns0:ESTATAPPRTOOLCOST>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:ESTATAPPRTOOLCOST>
            </xsl:for-each>
            <xsl:for-each select=""ns0:ESTDUR"">
              <ns0:ESTDUR>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:ESTDUR>
            </xsl:for-each>
            <xsl:for-each select=""ns0:ESTINTLABCOST"">
              <ns0:ESTINTLABCOST>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:ESTINTLABCOST>
            </xsl:for-each>
            <xsl:for-each select=""ns0:ESTINTLABHRS"">
              <ns0:ESTINTLABHRS>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:ESTINTLABHRS>
            </xsl:for-each>
            <xsl:for-each select=""ns0:ESTLABCOST"">
              <ns0:ESTLABCOST>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:ESTLABCOST>
            </xsl:for-each>
            <xsl:for-each select=""ns0:ESTLABHRS"">
              <ns0:ESTLABHRS>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:ESTLABHRS>
            </xsl:for-each>
            <xsl:for-each select=""ns0:ESTMATCOST"">
              <ns0:ESTMATCOST>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:ESTMATCOST>
            </xsl:for-each>
            <xsl:for-each select=""ns0:ESTOUTLABCOST"">
              <ns0:ESTOUTLABCOST>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:ESTOUTLABCOST>
            </xsl:for-each>
            <xsl:for-each select=""ns0:ESTOUTLABHRS"">
              <ns0:ESTOUTLABHRS>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:ESTOUTLABHRS>
            </xsl:for-each>
            <xsl:for-each select=""ns0:ESTSERVCOST"">
              <ns0:ESTSERVCOST>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:ESTSERVCOST>
            </xsl:for-each>
            <xsl:for-each select=""ns0:ESTTOOLCOST"">
              <ns0:ESTTOOLCOST>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:ESTTOOLCOST>
            </xsl:for-each>
            <xsl:for-each select=""ns0:EXTERNALREFID"">
              <ns0:EXTERNALREFID>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:EXTERNALREFID>
            </xsl:for-each>
            <xsl:for-each select=""ns0:FAILDATE"">
              <ns0:FAILDATE>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:FAILDATE>
            </xsl:for-each>
            <xsl:for-each select=""ns0:FAILURECODE"">
              <ns0:FAILURECODE>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:FAILURECODE>
            </xsl:for-each>
            <xsl:for-each select=""ns0:FCPROJECTID"">
              <ns0:FCPROJECTID>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:FCPROJECTID>
            </xsl:for-each>
            <xsl:for-each select=""ns0:FCTASKID"">
              <ns0:FCTASKID>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:FCTASKID>
            </xsl:for-each>
            <xsl:for-each select=""ns0:FINCNTRLID"">
              <ns0:FINCNTRLID>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:FINCNTRLID>
            </xsl:for-each>
            <xsl:for-each select=""ns0:FIRSTAPPRSTATUS"">
              <ns0:FIRSTAPPRSTATUS>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:FIRSTAPPRSTATUS>
            </xsl:for-each>
            <xsl:for-each select=""ns0:FLOWACTION"">
              <ns0:FLOWACTION>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:FLOWACTION>
            </xsl:for-each>
            <xsl:for-each select=""ns0:FLOWACTIONASSIST"">
              <ns0:FLOWACTIONASSIST>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:FLOWACTIONASSIST>
            </xsl:for-each>
            <xsl:for-each select=""ns0:FLOWCONTROLLED"">
              <ns0:FLOWCONTROLLED>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:FLOWCONTROLLED>
            </xsl:for-each>
            <xsl:for-each select=""ns0:FNLCONSTRAINT"">
              <ns0:FNLCONSTRAINT>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:FNLCONSTRAINT>
            </xsl:for-each>
            <xsl:for-each select=""ns0:GENERATEDFORPO"">
              <ns0:GENERATEDFORPO>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:GENERATEDFORPO>
            </xsl:for-each>
            <xsl:for-each select=""ns0:GENFORPOLINEID"">
              <ns0:GENFORPOLINEID>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:GENFORPOLINEID>
            </xsl:for-each>
            <xsl:for-each select=""ns0:GENFORPOREVISION"">
              <ns0:GENFORPOREVISION>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:GENFORPOREVISION>
            </xsl:for-each>
            <xsl:for-each select=""ns0:GLACCOUNT"">
              <ns0:GLACCOUNT>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:if test=""ns0:VALUE"">
                  <ns0:VALUE>
                    <xsl:value-of select=""ns0:VALUE/text()"" />
                  </ns0:VALUE>
                </xsl:if>
                <xsl:for-each select=""ns0:GLCOMP"">
                  <ns0:GLCOMP>
                    <xsl:attribute name=""glorder"">
                      <xsl:value-of select=""@glorder"" />
                    </xsl:attribute>
                    <xsl:value-of select=""./text()"" />
                  </ns0:GLCOMP>
                </xsl:for-each>
                <xsl:value-of select=""./text()"" />
              </ns0:GLACCOUNT>
            </xsl:for-each>
            <xsl:for-each select=""ns0:HASCHILDREN"">
              <ns0:HASCHILDREN>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:HASCHILDREN>
            </xsl:for-each>
            <xsl:for-each select=""ns0:HASFOLLOWUPWORK"">
              <ns0:HASFOLLOWUPWORK>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:HASFOLLOWUPWORK>
            </xsl:for-each>
            <xsl:for-each select=""ns0:HISTORYFLAG"">
              <ns0:HISTORYFLAG>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:HISTORYFLAG>
            </xsl:for-each>
            <xsl:for-each select=""ns0:IGNOREDIAVAIL"">
              <ns0:IGNOREDIAVAIL>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:IGNOREDIAVAIL>
            </xsl:for-each>
            <xsl:for-each select=""ns0:IGNORESRMAVAIL"">
              <ns0:IGNORESRMAVAIL>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:IGNORESRMAVAIL>
            </xsl:for-each>
            <xsl:for-each select=""ns0:INCTASKSINSCHED"">
              <ns0:INCTASKSINSCHED>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:INCTASKSINSCHED>
            </xsl:for-each>
            <xsl:for-each select=""ns0:INSPECTOR"">
              <ns0:INSPECTOR>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:INSPECTOR>
            </xsl:for-each>
            <xsl:for-each select=""ns0:INTERRUPTIBLE"">
              <ns0:INTERRUPTIBLE>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:INTERRUPTIBLE>
            </xsl:for-each>
            <xsl:for-each select=""ns0:ISTASK"">
              <ns0:ISTASK>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:ISTASK>
            </xsl:for-each>
            <xsl:for-each select=""ns0:JOBTASKID"">
              <ns0:JOBTASKID>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:JOBTASKID>
            </xsl:for-each>
            <xsl:for-each select=""ns0:JPNUM"">
              <ns0:JPNUM>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:JPNUM>
            </xsl:for-each>
            <xsl:for-each select=""ns0:JUSTIFYPRIORITY"">
              <ns0:JUSTIFYPRIORITY>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:JUSTIFYPRIORITY>
            </xsl:for-each>
            <xsl:for-each select=""ns0:KIRONAERROR"">
              <ns0:KIRONAERROR>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:KIRONAERROR>
            </xsl:for-each>
            <xsl:for-each select=""ns0:KIRONAQUEUED"">
              <ns0:KIRONAQUEUED>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:KIRONAQUEUED>
            </xsl:for-each>
            <xsl:for-each select=""ns0:LASTCOPYLINKDATE"">
              <ns0:LASTCOPYLINKDATE>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:LASTCOPYLINKDATE>
            </xsl:for-each>
            <xsl:for-each select=""ns0:LAUNCHENTRYNAME"">
              <ns0:LAUNCHENTRYNAME>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:LAUNCHENTRYNAME>
            </xsl:for-each>
            <xsl:for-each select=""ns0:LEAD"">
              <ns0:LEAD>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:LEAD>
            </xsl:for-each>
            <xsl:for-each select=""ns0:LOCATION"">
              <ns0:LOCATION>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:LOCATION>
            </xsl:for-each>
            <xsl:for-each select=""ns0:MEASUREDATE"">
              <ns0:MEASUREDATE>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:MEASUREDATE>
            </xsl:for-each>
            <xsl:for-each select=""ns0:MEASUREMENTVALUE"">
              <ns0:MEASUREMENTVALUE>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:MEASUREMENTVALUE>
            </xsl:for-each>
            <xsl:for-each select=""ns0:MTFMAWNCLIENT"">
              <ns0:MTFMAWNCLIENT>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:MTFMAWNCLIENT>
            </xsl:for-each>
            <xsl:for-each select=""ns0:MTFMAWNCONT"">
              <ns0:MTFMAWNCONT>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:MTFMAWNCONT>
            </xsl:for-each>
            <xsl:for-each select=""ns0:MTFMAWNPHONE"">
              <ns0:MTFMAWNPHONE>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:MTFMAWNPHONE>
            </xsl:for-each>
            <xsl:for-each select=""ns0:MTFMBLDGCLASS1"">
              <ns0:MTFMBLDGCLASS1>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:MTFMBLDGCLASS1>
            </xsl:for-each>
            <xsl:for-each select=""ns0:MTFMBLDGCLASS2"">
              <ns0:MTFMBLDGCLASS2>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:MTFMBLDGCLASS2>
            </xsl:for-each>
            <xsl:for-each select=""ns0:MTFMCLIENTCHREF"">
              <ns0:MTFMCLIENTCHREF>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:MTFMCLIENTCHREF>
            </xsl:for-each>
            <xsl:for-each select=""ns0:MTFMCLIENTID"">
              <ns0:MTFMCLIENTID>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:MTFMCLIENTID>
            </xsl:for-each>
            <xsl:for-each select=""ns0:MTFMCLIENTPO"">
              <ns0:MTFMCLIENTPO>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:MTFMCLIENTPO>
            </xsl:for-each>
            <xsl:for-each select=""ns0:MTFMCLIENTREF"">
              <ns0:MTFMCLIENTREF>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:MTFMCLIENTREF>
            </xsl:for-each>
            <xsl:for-each select=""ns0:MTFMCLIENTSITEREF"">
              <ns0:MTFMCLIENTSITEREF>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:MTFMCLIENTSITEREF>
            </xsl:for-each>
            <xsl:for-each select=""ns0:MTFMCONTACTEMAIL"">
              <ns0:MTFMCONTACTEMAIL>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:MTFMCONTACTEMAIL>
            </xsl:for-each>
            <xsl:for-each select=""ns0:MTFMJPTYPE"">
              <ns0:MTFMJPTYPE>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:MTFMJPTYPE>
            </xsl:for-each>
            <xsl:for-each select=""ns0:MTFMLOCDEFCL"">
              <ns0:MTFMLOCDEFCL>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:MTFMLOCDEFCL>
            </xsl:for-each>
            <xsl:for-each select=""ns0:MTFMSENDTOVIS"">
              <ns0:MTFMSENDTOVIS>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:MTFMSENDTOVIS>
            </xsl:for-each>
            <xsl:for-each select=""ns0:MTFM_CHRG"">
              <ns0:MTFM_CHRG>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:MTFM_CHRG>
            </xsl:for-each>
            <xsl:for-each select=""ns0:MTFM_HASMITEVS"">
              <ns0:MTFM_HASMITEVS>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:MTFM_HASMITEVS>
            </xsl:for-each>
            <xsl:for-each select=""ns0:MTFM_REASON"">
              <ns0:MTFM_REASON>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:MTFM_REASON>
            </xsl:for-each>
            <xsl:for-each select=""ns0:NEWCHILDCLASS"">
              <ns0:NEWCHILDCLASS>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:NEWCHILDCLASS>
            </xsl:for-each>
            <xsl:for-each select=""ns0:NP_STATUSMEMO"">
              <ns0:NP_STATUSMEMO>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:NP_STATUSMEMO>
            </xsl:for-each>
            <xsl:for-each select=""ns0:OBSERVATION"">
              <ns0:OBSERVATION>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:OBSERVATION>
            </xsl:for-each>
            <xsl:for-each select=""ns0:ONBEHALFOF"">
              <ns0:ONBEHALFOF>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:ONBEHALFOF>
            </xsl:for-each>
            <xsl:for-each select=""ns0:ORAPROJECT"">
              <ns0:ORAPROJECT>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:ORAPROJECT>
            </xsl:for-each>
            <xsl:for-each select=""ns0:ORGID"">
              <ns0:ORGID>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:ORGID>
            </xsl:for-each>
            <xsl:for-each select=""ns0:ORIGRECORDCLASS"">
              <ns0:ORIGRECORDCLASS>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:ORIGRECORDCLASS>
            </xsl:for-each>
            <xsl:for-each select=""ns0:ORIGRECORDID"">
              <ns0:ORIGRECORDID>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:ORIGRECORDID>
            </xsl:for-each>
            <xsl:for-each select=""ns0:OUTLABCOST"">
              <ns0:OUTLABCOST>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:OUTLABCOST>
            </xsl:for-each>
            <xsl:for-each select=""ns0:OUTMATCOST"">
              <ns0:OUTMATCOST>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:OUTMATCOST>
            </xsl:for-each>
            <xsl:for-each select=""ns0:OUTTOOLCOST"">
              <ns0:OUTTOOLCOST>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:OUTTOOLCOST>
            </xsl:for-each>
            <xsl:for-each select=""ns0:OWNER"">
              <ns0:OWNER>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:OWNER>
            </xsl:for-each>
            <xsl:for-each select=""ns0:OWNERGROUP"">
              <ns0:OWNERGROUP>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:OWNERGROUP>
            </xsl:for-each>
            <xsl:for-each select=""ns0:OWNERSYSID"">
              <ns0:OWNERSYSID>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:OWNERSYSID>
            </xsl:for-each>
            <xsl:for-each select=""ns0:PARENT"">
              <ns0:PARENT>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:PARENT>
            </xsl:for-each>
            <xsl:for-each select=""ns0:PARENTCHGSSTATUS"">
              <ns0:PARENTCHGSSTATUS>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:PARENTCHGSSTATUS>
            </xsl:for-each>
            <xsl:for-each select=""ns0:PERSONGROUP"">
              <ns0:PERSONGROUP>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:PERSONGROUP>
            </xsl:for-each>
            <xsl:for-each select=""ns0:PHONE"">
              <ns0:PHONE>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:PHONE>
            </xsl:for-each>
            <xsl:for-each select=""ns0:PLUSCFREQUENCY"">
              <ns0:PLUSCFREQUENCY>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:PLUSCFREQUENCY>
            </xsl:for-each>
            <xsl:for-each select=""ns0:PLUSCFREQUNIT"">
              <ns0:PLUSCFREQUNIT>
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
              </ns0:PLUSCFREQUNIT>
            </xsl:for-each>
            <xsl:for-each select=""ns0:PLUSCISMOBILE"">
              <ns0:PLUSCISMOBILE>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:PLUSCISMOBILE>
            </xsl:for-each>
            <xsl:for-each select=""ns0:PLUSCJPREVNUM"">
              <ns0:PLUSCJPREVNUM>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:PLUSCJPREVNUM>
            </xsl:for-each>
            <xsl:for-each select=""ns0:PLUSCLOOP"">
              <ns0:PLUSCLOOP>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:PLUSCLOOP>
            </xsl:for-each>
            <xsl:for-each select=""ns0:PLUSCNEXTDATE"">
              <ns0:PLUSCNEXTDATE>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:PLUSCNEXTDATE>
            </xsl:for-each>
            <xsl:for-each select=""ns0:PLUSCOVERDUEDATE"">
              <ns0:PLUSCOVERDUEDATE>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:PLUSCOVERDUEDATE>
            </xsl:for-each>
            <xsl:for-each select=""ns0:PLUSCPHYLOC"">
              <ns0:PLUSCPHYLOC>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:PLUSCPHYLOC>
            </xsl:for-each>
            <xsl:for-each select=""ns0:PMDUEDATE"">
              <ns0:PMDUEDATE>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:PMDUEDATE>
            </xsl:for-each>
            <xsl:for-each select=""ns0:PMEXTDATE"">
              <ns0:PMEXTDATE>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:PMEXTDATE>
            </xsl:for-each>
            <xsl:for-each select=""ns0:PMNEXTDUEDATE"">
              <ns0:PMNEXTDUEDATE>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:PMNEXTDUEDATE>
            </xsl:for-each>
            <xsl:for-each select=""ns0:PMNUM"">
              <ns0:PMNUM>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:PMNUM>
            </xsl:for-each>
            <xsl:for-each select=""ns0:POINTNUM"">
              <ns0:POINTNUM>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:POINTNUM>
            </xsl:for-each>
            <xsl:for-each select=""ns0:PROBLEMCODE"">
              <ns0:PROBLEMCODE>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:PROBLEMCODE>
            </xsl:for-each>
            <xsl:for-each select=""ns0:REASONFORCHANGE"">
              <ns0:REASONFORCHANGE>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:REASONFORCHANGE>
            </xsl:for-each>
            <xsl:for-each select=""ns0:REMDUR"">
              <ns0:REMDUR>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:REMDUR>
            </xsl:for-each>
            <xsl:for-each select=""ns0:REPAIRFACILITY"">
              <ns0:REPAIRFACILITY>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:REPAIRFACILITY>
            </xsl:for-each>
            <xsl:for-each select=""ns0:REPFACSITEID"">
              <ns0:REPFACSITEID>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:REPFACSITEID>
            </xsl:for-each>
            <xsl:for-each select=""ns0:REPORTDATE"">
              <ns0:REPORTDATE>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:REPORTDATE>
            </xsl:for-each>
            <xsl:for-each select=""ns0:REPORTEDBY"">
              <ns0:REPORTEDBY>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:REPORTEDBY>
            </xsl:for-each>
            <xsl:for-each select=""ns0:RESPONDBY"">
              <ns0:RESPONDBY>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:RESPONDBY>
            </xsl:for-each>
            <xsl:for-each select=""ns0:RISK"">
              <ns0:RISK>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:RISK>
            </xsl:for-each>
            <xsl:for-each select=""ns0:ROUTE"">
              <ns0:ROUTE>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:ROUTE>
            </xsl:for-each>
            <xsl:for-each select=""ns0:ROUTESTOPID"">
              <ns0:ROUTESTOPID>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:ROUTESTOPID>
            </xsl:for-each>
            <xsl:for-each select=""ns0:SCHEDFINISH"">
              <ns0:SCHEDFINISH>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:SCHEDFINISH>
            </xsl:for-each>
            <xsl:for-each select=""ns0:SCHEDSTART"">
              <ns0:SCHEDSTART>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:SCHEDSTART>
            </xsl:for-each>
            <xsl:for-each select=""ns0:SENDERSYSID"">
              <ns0:SENDERSYSID>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:SENDERSYSID>
            </xsl:for-each>
            <xsl:for-each select=""ns0:SENTTOKIRONA"">
              <ns0:SENTTOKIRONA>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:SENTTOKIRONA>
            </xsl:for-each>
            <xsl:for-each select=""ns0:SENTTOKIRONADATE"">
              <ns0:SENTTOKIRONADATE>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:SENTTOKIRONADATE>
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
            <xsl:for-each select=""ns0:SNECONSTRAINT"">
              <ns0:SNECONSTRAINT>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:SNECONSTRAINT>
            </xsl:for-each>
            <xsl:for-each select=""ns0:SOURCESYSID"">
              <ns0:SOURCESYSID>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:SOURCESYSID>
            </xsl:for-each>
            <xsl:for-each select=""ns0:STATUS"">
              <ns0:STATUS>
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
              </ns0:STATUS>
            </xsl:for-each>
            <xsl:for-each select=""ns0:STATUSDATE"">
              <ns0:STATUSDATE>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:STATUSDATE>
            </xsl:for-each>
            <xsl:for-each select=""ns0:STATUSIFACE"">
              <ns0:STATUSIFACE>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:STATUSIFACE>
            </xsl:for-each>
            <xsl:for-each select=""ns0:STOREROOMMTLSTATUS"">
              <ns0:STOREROOMMTLSTATUS>
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
              </ns0:STOREROOMMTLSTATUS>
            </xsl:for-each>
            <xsl:for-each select=""ns0:SUPERVISOR"">
              <ns0:SUPERVISOR>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:SUPERVISOR>
            </xsl:for-each>
            <xsl:for-each select=""ns0:SUSPENDFLOW"">
              <ns0:SUSPENDFLOW>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:SUSPENDFLOW>
            </xsl:for-each>
            <xsl:for-each select=""ns0:TARGCOMPDATE"">
              <ns0:TARGCOMPDATE>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:TARGCOMPDATE>
            </xsl:for-each>
            <xsl:for-each select=""ns0:TARGETDESC"">
              <ns0:TARGETDESC>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:TARGETDESC>
            </xsl:for-each>
            <xsl:for-each select=""ns0:TARGSTARTDATE"">
              <ns0:TARGSTARTDATE>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:TARGSTARTDATE>
            </xsl:for-each>
            <xsl:for-each select=""ns0:TASKID"">
              <ns0:TASKID>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:TASKID>
            </xsl:for-each>
            <xsl:for-each select=""ns0:VENDOR"">
              <ns0:VENDOR>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:VENDOR>
            </xsl:for-each>
            <xsl:for-each select=""ns0:VERIFICATION"">
              <ns0:VERIFICATION>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:VERIFICATION>
            </xsl:for-each>
            <xsl:for-each select=""ns0:WHOMISCHANGEFOR"">
              <ns0:WHOMISCHANGEFOR>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:WHOMISCHANGEFOR>
            </xsl:for-each>
            <xsl:for-each select=""ns0:WOACCEPTSCHARGES"">
              <ns0:WOACCEPTSCHARGES>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:WOACCEPTSCHARGES>
            </xsl:for-each>
            <xsl:for-each select=""ns0:WOCLASS"">
              <ns0:WOCLASS>
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
              </ns0:WOCLASS>
            </xsl:for-each>
            <xsl:for-each select=""ns0:WOEQ1"">
              <ns0:WOEQ1>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:WOEQ1>
            </xsl:for-each>
            <xsl:for-each select=""ns0:WOEQ10"">
              <ns0:WOEQ10>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:WOEQ10>
            </xsl:for-each>
            <xsl:for-each select=""ns0:WOEQ11"">
              <ns0:WOEQ11>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:WOEQ11>
            </xsl:for-each>
            <xsl:for-each select=""ns0:WOEQ12"">
              <ns0:WOEQ12>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:WOEQ12>
            </xsl:for-each>
            <xsl:for-each select=""ns0:WOEQ13"">
              <ns0:WOEQ13>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:WOEQ13>
            </xsl:for-each>
            <xsl:for-each select=""ns0:WOEQ14"">
              <ns0:WOEQ14>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:WOEQ14>
            </xsl:for-each>
            <xsl:for-each select=""ns0:WOEQ2"">
              <ns0:WOEQ2>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:WOEQ2>
            </xsl:for-each>
            <xsl:for-each select=""ns0:WOEQ3"">
              <ns0:WOEQ3>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:WOEQ3>
            </xsl:for-each>
            <xsl:for-each select=""ns0:WOEQ4"">
              <ns0:WOEQ4>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:WOEQ4>
            </xsl:for-each>
            <xsl:for-each select=""ns0:WOEQ5"">
              <ns0:WOEQ5>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:WOEQ5>
            </xsl:for-each>
            <xsl:for-each select=""ns0:WOEQ6"">
              <ns0:WOEQ6>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:WOEQ6>
            </xsl:for-each>
            <xsl:for-each select=""ns0:WOEQ7"">
              <ns0:WOEQ7>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:WOEQ7>
            </xsl:for-each>
            <xsl:for-each select=""ns0:WOEQ8"">
              <ns0:WOEQ8>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:WOEQ8>
            </xsl:for-each>
            <xsl:for-each select=""ns0:WOEQ9"">
              <ns0:WOEQ9>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:WOEQ9>
            </xsl:for-each>
            <xsl:for-each select=""ns0:WOGROUP"">
              <ns0:WOGROUP>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:WOGROUP>
            </xsl:for-each>
            <xsl:for-each select=""ns0:WOISSWAP"">
              <ns0:WOISSWAP>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:WOISSWAP>
            </xsl:for-each>
            <xsl:for-each select=""ns0:WOJO1"">
              <ns0:WOJO1>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:WOJO1>
            </xsl:for-each>
            <xsl:for-each select=""ns0:WOJO2"">
              <ns0:WOJO2>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:WOJO2>
            </xsl:for-each>
            <xsl:for-each select=""ns0:WOJO3"">
              <ns0:WOJO3>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:WOJO3>
            </xsl:for-each>
            <xsl:for-each select=""ns0:WOJO4"">
              <ns0:WOJO4>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:WOJO4>
            </xsl:for-each>
            <xsl:for-each select=""ns0:WOJO5"">
              <ns0:WOJO5>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:WOJO5>
            </xsl:for-each>
            <xsl:for-each select=""ns0:WOJO6"">
              <ns0:WOJO6>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:WOJO6>
            </xsl:for-each>
            <xsl:for-each select=""ns0:WOJO7"">
              <ns0:WOJO7>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:WOJO7>
            </xsl:for-each>
            <xsl:for-each select=""ns0:WOJO8"">
              <ns0:WOJO8>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:WOJO8>
            </xsl:for-each>
            <xsl:for-each select=""ns0:WOJP1"">
              <ns0:WOJP1>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:WOJP1>
            </xsl:for-each>
            <xsl:for-each select=""ns0:WOJP2"">
              <ns0:WOJP2>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:WOJP2>
            </xsl:for-each>
            <xsl:for-each select=""ns0:WOJP3"">
              <ns0:WOJP3>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:WOJP3>
            </xsl:for-each>
            <xsl:for-each select=""ns0:WOJP4"">
              <ns0:WOJP4>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:WOJP4>
            </xsl:for-each>
            <xsl:for-each select=""ns0:WOJP5"">
              <ns0:WOJP5>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:WOJP5>
            </xsl:for-each>
            <xsl:for-each select=""ns0:WOL1"">
              <ns0:WOL1>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:WOL1>
            </xsl:for-each>
            <xsl:for-each select=""ns0:WOL2"">
              <ns0:WOL2>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:WOL2>
            </xsl:for-each>
            <xsl:for-each select=""ns0:WOL3"">
              <ns0:WOL3>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:WOL3>
            </xsl:for-each>
            <xsl:for-each select=""ns0:WOL4"">
              <ns0:WOL4>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:WOL4>
            </xsl:for-each>
            <xsl:for-each select=""ns0:WOLABLNK"">
              <ns0:WOLABLNK>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:WOLABLNK>
            </xsl:for-each>
            <xsl:for-each select=""ns0:WOLO1"">
              <ns0:WOLO1>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:WOLO1>
            </xsl:for-each>
            <xsl:for-each select=""ns0:WOLO10"">
              <ns0:WOLO10>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:WOLO10>
            </xsl:for-each>
            <xsl:for-each select=""ns0:WOLO2"">
              <xsl:variable name=""var:v1"" select=""userCSharp:LogicalEq(string(./text()) , &quot;1TEAM&quot;)"" />
              <xsl:variable name=""var:v2"" select=""userCSharp:LogicalNot(string($var:v1))"" />
              <xsl:variable name=""var:v3"" select=""string(./text())"" />
              <xsl:variable name=""var:v4"" select=""userCSharp:LogicalEq($var:v3 , &quot;MIREQUEST&quot;)"" />
              <xsl:variable name=""var:v5"" select=""userCSharp:LogicalNot(string($var:v4))"" />
              <xsl:variable name=""var:v6"" select=""userCSharp:LogicalAnd(string($var:v2) , string($var:v5))"" />
              <ns0:WOLO2>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:if test=""string($var:v6)='true'"">
                  <xsl:variable name=""var:v7"" select=""&quot;VISIONFM&quot;"" />
                  <xsl:value-of select=""$var:v7"" />
                </xsl:if>
              </ns0:WOLO2>
            </xsl:for-each>
            <xsl:for-each select=""ns0:WOLO3"">
              <ns0:WOLO3>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:WOLO3>
            </xsl:for-each>
            <xsl:for-each select=""ns0:WOLO4"">
              <ns0:WOLO4>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:WOLO4>
            </xsl:for-each>
            <xsl:for-each select=""ns0:WOLO5"">
              <ns0:WOLO5>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:WOLO5>
            </xsl:for-each>
            <xsl:for-each select=""ns0:WOLO6"">
              <ns0:WOLO6>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:WOLO6>
            </xsl:for-each>
            <xsl:for-each select=""ns0:WOLO7"">
              <ns0:WOLO7>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:WOLO7>
            </xsl:for-each>
            <xsl:for-each select=""ns0:WOLO8"">
              <ns0:WOLO8>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:WOLO8>
            </xsl:for-each>
            <xsl:for-each select=""ns0:WOLO9"">
              <ns0:WOLO9>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:WOLO9>
            </xsl:for-each>
            <xsl:for-each select=""ns0:WONUM"">
              <ns0:WONUM>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:WONUM>
            </xsl:for-each>
            <xsl:for-each select=""ns0:WOPRIORITY"">
              <ns0:WOPRIORITY>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:WOPRIORITY>
            </xsl:for-each>
            <xsl:for-each select=""ns0:WORKLOCATION"">
              <ns0:WORKLOCATION>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:WORKLOCATION>
            </xsl:for-each>
            <xsl:for-each select=""ns0:WORKORDERID"">
              <ns0:WORKORDERID>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:WORKORDERID>
            </xsl:for-each>
            <xsl:for-each select=""ns0:WORKPACKMTLSTATUS"">
              <ns0:WORKPACKMTLSTATUS>
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
              </ns0:WORKPACKMTLSTATUS>
            </xsl:for-each>
            <xsl:for-each select=""ns0:WORKTYPE"">
              <ns0:WORKTYPE>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:WORKTYPE>
            </xsl:for-each>
            <xsl:for-each select=""ns0:WORTS1"">
              <ns0:WORTS1>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:WORTS1>
            </xsl:for-each>
            <xsl:for-each select=""ns0:WORTS2"">
              <ns0:WORTS2>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:WORTS2>
            </xsl:for-each>
            <xsl:for-each select=""ns0:WORTS3"">
              <ns0:WORTS3>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:WORTS3>
            </xsl:for-each>
            <xsl:for-each select=""ns0:WORTS4"">
              <ns0:WORTS4>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:WORTS4>
            </xsl:for-each>
            <xsl:for-each select=""ns0:WORTS5"">
              <ns0:WORTS5>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:WORTS5>
            </xsl:for-each>
            <xsl:for-each select=""ns0:WOSEQUENCE"">
              <ns0:WOSEQUENCE>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:WOSEQUENCE>
            </xsl:for-each>
            <xsl:for-each select=""ns0:WPLABOR"">
              <ns0:WPLABOR>
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
                <xsl:for-each select=""ns0:CONTRACTNUM"">
                  <ns0:CONTRACTNUM>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:CONTRACTNUM>
                </xsl:for-each>
                <xsl:for-each select=""ns0:CRAFT"">
                  <ns0:CRAFT>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:CRAFT>
                </xsl:for-each>
                <xsl:for-each select=""ns0:LABORCODE"">
                  <ns0:LABORCODE>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:LABORCODE>
                </xsl:for-each>
                <xsl:for-each select=""ns0:LABORHRS"">
                  <ns0:LABORHRS>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:LABORHRS>
                </xsl:for-each>
                <xsl:for-each select=""ns0:ORGID"">
                  <ns0:ORGID>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:ORGID>
                </xsl:for-each>
                <xsl:for-each select=""ns0:QUANTITY"">
                  <ns0:QUANTITY>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:QUANTITY>
                </xsl:for-each>
                <xsl:for-each select=""ns0:RATE"">
                  <ns0:RATE>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:RATE>
                </xsl:for-each>
                <xsl:for-each select=""ns0:RATEHASCHANGED"">
                  <ns0:RATEHASCHANGED>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:RATEHASCHANGED>
                </xsl:for-each>
                <xsl:for-each select=""ns0:SKILLLEVEL"">
                  <ns0:SKILLLEVEL>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:SKILLLEVEL>
                </xsl:for-each>
                <xsl:for-each select=""ns0:VENDOR"">
                  <ns0:VENDOR>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:VENDOR>
                </xsl:for-each>
                <xsl:for-each select=""ns0:WPL1"">
                  <ns0:WPL1>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:WPL1>
                </xsl:for-each>
                <xsl:for-each select=""ns0:WPL2"">
                  <ns0:WPL2>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:WPL2>
                </xsl:for-each>
                <xsl:for-each select=""ns0:WPL3"">
                  <ns0:WPL3>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:WPL3>
                </xsl:for-each>
                <xsl:for-each select=""ns0:WPL4"">
                  <ns0:WPL4>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:WPL4>
                </xsl:for-each>
                <xsl:for-each select=""ns0:WPL5"">
                  <ns0:WPL5>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:WPL5>
                </xsl:for-each>
                <xsl:for-each select=""ns0:WPL6"">
                  <ns0:WPL6>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:WPL6>
                </xsl:for-each>
                <xsl:for-each select=""ns0:WPL7"">
                  <ns0:WPL7>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:WPL7>
                </xsl:for-each>
                <xsl:for-each select=""ns0:WPL8"">
                  <ns0:WPL8>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:WPL8>
                </xsl:for-each>
                <xsl:for-each select=""ns0:WPL9"">
                  <ns0:WPL9>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:WPL9>
                </xsl:for-each>
                <xsl:for-each select=""ns0:WPLABORID"">
                  <ns0:WPLABORID>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:WPLABORID>
                </xsl:for-each>
                <xsl:for-each select=""ns0:WPLABORUID"">
                  <ns0:WPLABORUID>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:WPLABORUID>
                </xsl:for-each>
                <xsl:value-of select=""./text()"" />
              </ns0:WPLABOR>
            </xsl:for-each>
            <xsl:for-each select=""ns0:WPMATERIAL"">
              <ns0:WPMATERIAL>
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
                <xsl:for-each select=""ns0:CATALOGCODE"">
                  <ns0:CATALOGCODE>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:CATALOGCODE>
                </xsl:for-each>
                <xsl:for-each select=""ns0:CONDITIONCODE"">
                  <ns0:CONDITIONCODE>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:CONDITIONCODE>
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
                <xsl:for-each select=""ns0:DIRECTREQ"">
                  <ns0:DIRECTREQ>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:DIRECTREQ>
                </xsl:for-each>
                <xsl:for-each select=""ns0:HOURS"">
                  <ns0:HOURS>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:HOURS>
                </xsl:for-each>
                <xsl:for-each select=""ns0:ISSUETO"">
                  <ns0:ISSUETO>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:ISSUETO>
                </xsl:for-each>
                <xsl:for-each select=""ns0:ITEMNUM"">
                  <ns0:ITEMNUM>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:ITEMNUM>
                </xsl:for-each>
                <xsl:for-each select=""ns0:ITEMQTY"">
                  <ns0:ITEMQTY>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:ITEMQTY>
                </xsl:for-each>
                <xsl:for-each select=""ns0:ITEMSETID"">
                  <ns0:ITEMSETID>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:ITEMSETID>
                </xsl:for-each>
                <xsl:for-each select=""ns0:LINECOST"">
                  <ns0:LINECOST>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:LINECOST>
                </xsl:for-each>
                <xsl:for-each select=""ns0:LINETYPE"">
                  <ns0:LINETYPE>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:LINETYPE>
                </xsl:for-each>
                <xsl:for-each select=""ns0:LOCATION"">
                  <ns0:LOCATION>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:LOCATION>
                </xsl:for-each>
                <xsl:for-each select=""ns0:MANUFACTURER"">
                  <ns0:MANUFACTURER>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:MANUFACTURER>
                </xsl:for-each>
                <xsl:for-each select=""ns0:MKTPLCITEM"">
                  <ns0:MKTPLCITEM>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:MKTPLCITEM>
                </xsl:for-each>
                <xsl:for-each select=""ns0:MODELNUM"">
                  <ns0:MODELNUM>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:MODELNUM>
                </xsl:for-each>
                <xsl:for-each select=""ns0:ORDERUNIT"">
                  <ns0:ORDERUNIT>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:ORDERUNIT>
                </xsl:for-each>
                <xsl:for-each select=""ns0:ORGID"">
                  <ns0:ORGID>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:ORGID>
                </xsl:for-each>
                <xsl:for-each select=""ns0:PR"">
                  <ns0:PR>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:PR>
                </xsl:for-each>
                <xsl:for-each select=""ns0:PRLINENUM"">
                  <ns0:PRLINENUM>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:PRLINENUM>
                </xsl:for-each>
                <xsl:for-each select=""ns0:RATE"">
                  <ns0:RATE>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:RATE>
                </xsl:for-each>
                <xsl:for-each select=""ns0:RATEHASCHANGED"">
                  <ns0:RATEHASCHANGED>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:RATEHASCHANGED>
                </xsl:for-each>
                <xsl:for-each select=""ns0:REQUESTBY"">
                  <ns0:REQUESTBY>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:REQUESTBY>
                </xsl:for-each>
                <xsl:for-each select=""ns0:REQUESTNUM"">
                  <ns0:REQUESTNUM>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:REQUESTNUM>
                </xsl:for-each>
                <xsl:for-each select=""ns0:REQUIREDATE"">
                  <ns0:REQUIREDATE>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:REQUIREDATE>
                </xsl:for-each>
                <xsl:for-each select=""ns0:RESTYPE"">
                  <ns0:RESTYPE>
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
                  </ns0:RESTYPE>
                </xsl:for-each>
                <xsl:for-each select=""ns0:STORELOCSITE"">
                  <ns0:STORELOCSITE>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:STORELOCSITE>
                </xsl:for-each>
                <xsl:for-each select=""ns0:UNITCOST"">
                  <ns0:UNITCOST>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:UNITCOST>
                </xsl:for-each>
                <xsl:for-each select=""ns0:UNITCOSTHASCHANGED"">
                  <ns0:UNITCOSTHASCHANGED>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:UNITCOSTHASCHANGED>
                </xsl:for-each>
                <xsl:for-each select=""ns0:VENDOR"">
                  <ns0:VENDOR>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:VENDOR>
                </xsl:for-each>
                <xsl:for-each select=""ns0:VENDORPACKCODE"">
                  <ns0:VENDORPACKCODE>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:VENDORPACKCODE>
                </xsl:for-each>
                <xsl:for-each select=""ns0:VENDORPACKQUANTITY"">
                  <ns0:VENDORPACKQUANTITY>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:VENDORPACKQUANTITY>
                </xsl:for-each>
                <xsl:for-each select=""ns0:VENDORUNITCOST"">
                  <ns0:VENDORUNITCOST>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:VENDORUNITCOST>
                </xsl:for-each>
                <xsl:for-each select=""ns0:VENDORWAREHOUSE"">
                  <ns0:VENDORWAREHOUSE>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:VENDORWAREHOUSE>
                </xsl:for-each>
                <xsl:for-each select=""ns0:WPITEMID"">
                  <ns0:WPITEMID>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:WPITEMID>
                </xsl:for-each>
                <xsl:for-each select=""ns0:WPM1"">
                  <ns0:WPM1>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:WPM1>
                </xsl:for-each>
                <xsl:for-each select=""ns0:WPM2"">
                  <ns0:WPM2>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:WPM2>
                </xsl:for-each>
                <xsl:for-each select=""ns0:WPM3"">
                  <ns0:WPM3>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:WPM3>
                </xsl:for-each>
                <xsl:for-each select=""ns0:WPM4"">
                  <ns0:WPM4>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:WPM4>
                </xsl:for-each>
                <xsl:for-each select=""ns0:WPM5"">
                  <ns0:WPM5>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:WPM5>
                </xsl:for-each>
                <xsl:for-each select=""ns0:WPM6"">
                  <ns0:WPM6>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:WPM6>
                </xsl:for-each>
                <xsl:value-of select=""./text()"" />
              </ns0:WPMATERIAL>
            </xsl:for-each>
            <xsl:for-each select=""ns0:WPTOOL"">
              <ns0:WPTOOL>
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
                <xsl:for-each select=""ns0:CATALOGCODE"">
                  <ns0:CATALOGCODE>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:CATALOGCODE>
                </xsl:for-each>
                <xsl:for-each select=""ns0:CONDITIONCODE"">
                  <ns0:CONDITIONCODE>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:CONDITIONCODE>
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
                <xsl:for-each select=""ns0:DIRECTREQ"">
                  <ns0:DIRECTREQ>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:DIRECTREQ>
                </xsl:for-each>
                <xsl:for-each select=""ns0:HOURS"">
                  <ns0:HOURS>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:HOURS>
                </xsl:for-each>
                <xsl:for-each select=""ns0:ISSUETO"">
                  <ns0:ISSUETO>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:ISSUETO>
                </xsl:for-each>
                <xsl:for-each select=""ns0:ITEMNUM"">
                  <ns0:ITEMNUM>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:ITEMNUM>
                </xsl:for-each>
                <xsl:for-each select=""ns0:ITEMQTY"">
                  <ns0:ITEMQTY>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:ITEMQTY>
                </xsl:for-each>
                <xsl:for-each select=""ns0:ITEMSETID"">
                  <ns0:ITEMSETID>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:ITEMSETID>
                </xsl:for-each>
                <xsl:for-each select=""ns0:LINECOST"">
                  <ns0:LINECOST>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:LINECOST>
                </xsl:for-each>
                <xsl:for-each select=""ns0:LINETYPE"">
                  <ns0:LINETYPE>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:LINETYPE>
                </xsl:for-each>
                <xsl:for-each select=""ns0:LOCATION"">
                  <ns0:LOCATION>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:LOCATION>
                </xsl:for-each>
                <xsl:for-each select=""ns0:MANUFACTURER"">
                  <ns0:MANUFACTURER>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:MANUFACTURER>
                </xsl:for-each>
                <xsl:for-each select=""ns0:MKTPLCITEM"">
                  <ns0:MKTPLCITEM>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:MKTPLCITEM>
                </xsl:for-each>
                <xsl:for-each select=""ns0:MODELNUM"">
                  <ns0:MODELNUM>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:MODELNUM>
                </xsl:for-each>
                <xsl:for-each select=""ns0:ORDERUNIT"">
                  <ns0:ORDERUNIT>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:ORDERUNIT>
                </xsl:for-each>
                <xsl:for-each select=""ns0:ORGID"">
                  <ns0:ORGID>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:ORGID>
                </xsl:for-each>
                <xsl:for-each select=""ns0:PR"">
                  <ns0:PR>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:PR>
                </xsl:for-each>
                <xsl:for-each select=""ns0:PRLINENUM"">
                  <ns0:PRLINENUM>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:PRLINENUM>
                </xsl:for-each>
                <xsl:for-each select=""ns0:RATE"">
                  <ns0:RATE>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:RATE>
                </xsl:for-each>
                <xsl:for-each select=""ns0:RATEHASCHANGED"">
                  <ns0:RATEHASCHANGED>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:RATEHASCHANGED>
                </xsl:for-each>
                <xsl:for-each select=""ns0:REQUESTBY"">
                  <ns0:REQUESTBY>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:REQUESTBY>
                </xsl:for-each>
                <xsl:for-each select=""ns0:REQUESTNUM"">
                  <ns0:REQUESTNUM>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:REQUESTNUM>
                </xsl:for-each>
                <xsl:for-each select=""ns0:REQUIREDATE"">
                  <ns0:REQUIREDATE>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:REQUIREDATE>
                </xsl:for-each>
                <xsl:for-each select=""ns0:RESTYPE"">
                  <ns0:RESTYPE>
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
                  </ns0:RESTYPE>
                </xsl:for-each>
                <xsl:for-each select=""ns0:STORELOCSITE"">
                  <ns0:STORELOCSITE>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:STORELOCSITE>
                </xsl:for-each>
                <xsl:for-each select=""ns0:UNITCOST"">
                  <ns0:UNITCOST>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:UNITCOST>
                </xsl:for-each>
                <xsl:for-each select=""ns0:UNITCOSTHASCHANGED"">
                  <ns0:UNITCOSTHASCHANGED>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:UNITCOSTHASCHANGED>
                </xsl:for-each>
                <xsl:for-each select=""ns0:VENDOR"">
                  <ns0:VENDOR>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:VENDOR>
                </xsl:for-each>
                <xsl:for-each select=""ns0:VENDORPACKCODE"">
                  <ns0:VENDORPACKCODE>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:VENDORPACKCODE>
                </xsl:for-each>
                <xsl:for-each select=""ns0:VENDORPACKQUANTITY"">
                  <ns0:VENDORPACKQUANTITY>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:VENDORPACKQUANTITY>
                </xsl:for-each>
                <xsl:for-each select=""ns0:VENDORUNITCOST"">
                  <ns0:VENDORUNITCOST>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:VENDORUNITCOST>
                </xsl:for-each>
                <xsl:for-each select=""ns0:VENDORWAREHOUSE"">
                  <ns0:VENDORWAREHOUSE>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:VENDORWAREHOUSE>
                </xsl:for-each>
                <xsl:for-each select=""ns0:WPITEMID"">
                  <ns0:WPITEMID>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:WPITEMID>
                </xsl:for-each>
                <xsl:for-each select=""ns0:WPM1"">
                  <ns0:WPM1>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:WPM1>
                </xsl:for-each>
                <xsl:for-each select=""ns0:WPM2"">
                  <ns0:WPM2>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:WPM2>
                </xsl:for-each>
                <xsl:for-each select=""ns0:WPM3"">
                  <ns0:WPM3>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:WPM3>
                </xsl:for-each>
                <xsl:for-each select=""ns0:WPM4"">
                  <ns0:WPM4>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:WPM4>
                </xsl:for-each>
                <xsl:for-each select=""ns0:WPM5"">
                  <ns0:WPM5>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:WPM5>
                </xsl:for-each>
                <xsl:for-each select=""ns0:WPM6"">
                  <ns0:WPM6>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:WPM6>
                </xsl:for-each>
                <xsl:value-of select=""./text()"" />
              </ns0:WPTOOL>
            </xsl:for-each>
            <xsl:for-each select=""ns0:WPSERVICE"">
              <ns0:WPSERVICE>
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
                <xsl:for-each select=""ns0:CATALOGCODE"">
                  <ns0:CATALOGCODE>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:CATALOGCODE>
                </xsl:for-each>
                <xsl:for-each select=""ns0:CONDITIONCODE"">
                  <ns0:CONDITIONCODE>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:CONDITIONCODE>
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
                <xsl:for-each select=""ns0:DIRECTREQ"">
                  <ns0:DIRECTREQ>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:DIRECTREQ>
                </xsl:for-each>
                <xsl:for-each select=""ns0:HOURS"">
                  <ns0:HOURS>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:HOURS>
                </xsl:for-each>
                <xsl:for-each select=""ns0:ISSUETO"">
                  <ns0:ISSUETO>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:ISSUETO>
                </xsl:for-each>
                <xsl:for-each select=""ns0:ITEMNUM"">
                  <ns0:ITEMNUM>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:ITEMNUM>
                </xsl:for-each>
                <xsl:for-each select=""ns0:ITEMQTY"">
                  <ns0:ITEMQTY>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:ITEMQTY>
                </xsl:for-each>
                <xsl:for-each select=""ns0:ITEMSETID"">
                  <ns0:ITEMSETID>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:ITEMSETID>
                </xsl:for-each>
                <xsl:for-each select=""ns0:LINECOST"">
                  <ns0:LINECOST>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:LINECOST>
                </xsl:for-each>
                <xsl:for-each select=""ns0:LINETYPE"">
                  <ns0:LINETYPE>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:LINETYPE>
                </xsl:for-each>
                <xsl:for-each select=""ns0:LOCATION"">
                  <ns0:LOCATION>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:LOCATION>
                </xsl:for-each>
                <xsl:for-each select=""ns0:MANUFACTURER"">
                  <ns0:MANUFACTURER>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:MANUFACTURER>
                </xsl:for-each>
                <xsl:for-each select=""ns0:MKTPLCITEM"">
                  <ns0:MKTPLCITEM>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:MKTPLCITEM>
                </xsl:for-each>
                <xsl:for-each select=""ns0:MODELNUM"">
                  <ns0:MODELNUM>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:MODELNUM>
                </xsl:for-each>
                <xsl:for-each select=""ns0:ORDERUNIT"">
                  <ns0:ORDERUNIT>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:ORDERUNIT>
                </xsl:for-each>
                <xsl:for-each select=""ns0:ORGID"">
                  <ns0:ORGID>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:ORGID>
                </xsl:for-each>
                <xsl:for-each select=""ns0:PR"">
                  <ns0:PR>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:PR>
                </xsl:for-each>
                <xsl:for-each select=""ns0:PRLINENUM"">
                  <ns0:PRLINENUM>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:PRLINENUM>
                </xsl:for-each>
                <xsl:for-each select=""ns0:RATE"">
                  <ns0:RATE>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:RATE>
                </xsl:for-each>
                <xsl:for-each select=""ns0:RATEHASCHANGED"">
                  <ns0:RATEHASCHANGED>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:RATEHASCHANGED>
                </xsl:for-each>
                <xsl:for-each select=""ns0:REQUESTBY"">
                  <ns0:REQUESTBY>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:REQUESTBY>
                </xsl:for-each>
                <xsl:for-each select=""ns0:REQUESTNUM"">
                  <ns0:REQUESTNUM>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:REQUESTNUM>
                </xsl:for-each>
                <xsl:for-each select=""ns0:REQUIREDATE"">
                  <ns0:REQUIREDATE>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:REQUIREDATE>
                </xsl:for-each>
                <xsl:for-each select=""ns0:RESTYPE"">
                  <ns0:RESTYPE>
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
                  </ns0:RESTYPE>
                </xsl:for-each>
                <xsl:for-each select=""ns0:STORELOCSITE"">
                  <ns0:STORELOCSITE>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:STORELOCSITE>
                </xsl:for-each>
                <xsl:for-each select=""ns0:UNITCOST"">
                  <ns0:UNITCOST>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:UNITCOST>
                </xsl:for-each>
                <xsl:for-each select=""ns0:UNITCOSTHASCHANGED"">
                  <ns0:UNITCOSTHASCHANGED>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:UNITCOSTHASCHANGED>
                </xsl:for-each>
                <xsl:for-each select=""ns0:VENDOR"">
                  <ns0:VENDOR>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:VENDOR>
                </xsl:for-each>
                <xsl:for-each select=""ns0:VENDORPACKCODE"">
                  <ns0:VENDORPACKCODE>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:VENDORPACKCODE>
                </xsl:for-each>
                <xsl:for-each select=""ns0:VENDORPACKQUANTITY"">
                  <ns0:VENDORPACKQUANTITY>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:VENDORPACKQUANTITY>
                </xsl:for-each>
                <xsl:for-each select=""ns0:VENDORUNITCOST"">
                  <ns0:VENDORUNITCOST>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:VENDORUNITCOST>
                </xsl:for-each>
                <xsl:for-each select=""ns0:VENDORWAREHOUSE"">
                  <ns0:VENDORWAREHOUSE>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:VENDORWAREHOUSE>
                </xsl:for-each>
                <xsl:for-each select=""ns0:WPITEMID"">
                  <ns0:WPITEMID>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:WPITEMID>
                </xsl:for-each>
                <xsl:for-each select=""ns0:WPM1"">
                  <ns0:WPM1>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:WPM1>
                </xsl:for-each>
                <xsl:for-each select=""ns0:WPM2"">
                  <ns0:WPM2>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:WPM2>
                </xsl:for-each>
                <xsl:for-each select=""ns0:WPM3"">
                  <ns0:WPM3>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:WPM3>
                </xsl:for-each>
                <xsl:for-each select=""ns0:WPM4"">
                  <ns0:WPM4>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:WPM4>
                </xsl:for-each>
                <xsl:for-each select=""ns0:WPM5"">
                  <ns0:WPM5>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:WPM5>
                </xsl:for-each>
                <xsl:for-each select=""ns0:WPM6"">
                  <ns0:WPM6>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:WPM6>
                </xsl:for-each>
                <xsl:value-of select=""./text()"" />
              </ns0:WPSERVICE>
            </xsl:for-each>
            <xsl:for-each select=""ns0:INVRESERVE"">
              <ns0:INVRESERVE>
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
                <xsl:for-each select=""ns0:ACTUALQTY"">
                  <ns0:ACTUALQTY>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:ACTUALQTY>
                </xsl:for-each>
                <xsl:for-each select=""ns0:ASSETNUM"">
                  <ns0:ASSETNUM>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:ASSETNUM>
                </xsl:for-each>
                <xsl:for-each select=""ns0:CONDITIONCODE"">
                  <ns0:CONDITIONCODE>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:CONDITIONCODE>
                </xsl:for-each>
                <xsl:for-each select=""ns0:DELLOCATION"">
                  <ns0:DELLOCATION>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:DELLOCATION>
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
                <xsl:for-each select=""ns0:DIRECTREQ"">
                  <ns0:DIRECTREQ>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:DIRECTREQ>
                </xsl:for-each>
                <xsl:for-each select=""ns0:EXTERNALREFID"">
                  <ns0:EXTERNALREFID>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:EXTERNALREFID>
                </xsl:for-each>
                <xsl:for-each select=""ns0:FINCNTRLID"">
                  <ns0:FINCNTRLID>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:FINCNTRLID>
                </xsl:for-each>
                <xsl:for-each select=""ns0:GLACCOUNT"">
                  <ns0:GLACCOUNT>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:if test=""ns0:VALUE"">
                      <ns0:VALUE>
                        <xsl:value-of select=""ns0:VALUE/text()"" />
                      </ns0:VALUE>
                    </xsl:if>
                    <xsl:for-each select=""ns0:GLCOMP"">
                      <ns0:GLCOMP>
                        <xsl:attribute name=""glorder"">
                          <xsl:value-of select=""@glorder"" />
                        </xsl:attribute>
                        <xsl:value-of select=""./text()"" />
                      </ns0:GLCOMP>
                    </xsl:for-each>
                    <xsl:value-of select=""./text()"" />
                  </ns0:GLACCOUNT>
                </xsl:for-each>
                <xsl:for-each select=""ns0:HARDBACKORDER"">
                  <ns0:HARDBACKORDER>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:HARDBACKORDER>
                </xsl:for-each>
                <xsl:for-each select=""ns0:INITFLAG"">
                  <ns0:INITFLAG>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:INITFLAG>
                </xsl:for-each>
                <xsl:for-each select=""ns0:INVRESERVEID"">
                  <ns0:INVRESERVEID>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:INVRESERVEID>
                </xsl:for-each>
                <xsl:for-each select=""ns0:ISSUETO"">
                  <ns0:ISSUETO>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:ISSUETO>
                </xsl:for-each>
                <xsl:for-each select=""ns0:ITEMNUM"">
                  <ns0:ITEMNUM>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:ITEMNUM>
                </xsl:for-each>
                <xsl:for-each select=""ns0:ITEMSETID"">
                  <ns0:ITEMSETID>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:ITEMSETID>
                </xsl:for-each>
                <xsl:for-each select=""ns0:LOCATION"">
                  <ns0:LOCATION>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:LOCATION>
                </xsl:for-each>
                <xsl:for-each select=""ns0:MRLINENUM"">
                  <ns0:MRLINENUM>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:MRLINENUM>
                </xsl:for-each>
                <xsl:for-each select=""ns0:MRNUM"">
                  <ns0:MRNUM>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:MRNUM>
                </xsl:for-each>
                <xsl:for-each select=""ns0:OPLOCATION"">
                  <ns0:OPLOCATION>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:OPLOCATION>
                </xsl:for-each>
                <xsl:for-each select=""ns0:ORGID"">
                  <ns0:ORGID>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:ORGID>
                </xsl:for-each>
                <xsl:for-each select=""ns0:OWNERSYSID"">
                  <ns0:OWNERSYSID>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:OWNERSYSID>
                </xsl:for-each>
                <xsl:for-each select=""ns0:PENDINGQTY"">
                  <ns0:PENDINGQTY>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:PENDINGQTY>
                </xsl:for-each>
                <xsl:for-each select=""ns0:POLINEID"">
                  <ns0:POLINEID>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:POLINEID>
                </xsl:for-each>
                <xsl:for-each select=""ns0:POLINENUM"">
                  <ns0:POLINENUM>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:POLINENUM>
                </xsl:for-each>
                <xsl:for-each select=""ns0:PONUM"">
                  <ns0:PONUM>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:PONUM>
                </xsl:for-each>
                <xsl:for-each select=""ns0:POREVISIONNUM"">
                  <ns0:POREVISIONNUM>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:POREVISIONNUM>
                </xsl:for-each>
                <xsl:for-each select=""ns0:REQUESTEDBY"">
                  <ns0:REQUESTEDBY>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:REQUESTEDBY>
                </xsl:for-each>
                <xsl:for-each select=""ns0:REQUESTEDDATE"">
                  <ns0:REQUESTEDDATE>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:REQUESTEDDATE>
                </xsl:for-each>
                <xsl:for-each select=""ns0:REQUESTNUM"">
                  <ns0:REQUESTNUM>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:REQUESTNUM>
                </xsl:for-each>
                <xsl:for-each select=""ns0:REQUIREDDATE"">
                  <ns0:REQUIREDDATE>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:REQUIREDDATE>
                </xsl:for-each>
                <xsl:for-each select=""ns0:RESERVEDQTY"">
                  <ns0:RESERVEDQTY>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:RESERVEDQTY>
                </xsl:for-each>
                <xsl:for-each select=""ns0:RESTYPE"">
                  <ns0:RESTYPE>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:RESTYPE>
                </xsl:for-each>
                <xsl:for-each select=""ns0:SENDERSYSID"">
                  <ns0:SENDERSYSID>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:SENDERSYSID>
                </xsl:for-each>
                <xsl:for-each select=""ns0:SHIPPEDQTY"">
                  <ns0:SHIPPEDQTY>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:SHIPPEDQTY>
                </xsl:for-each>
                <xsl:for-each select=""ns0:SOURCESYSID"">
                  <ns0:SOURCESYSID>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:SOURCESYSID>
                </xsl:for-each>
                <xsl:for-each select=""ns0:STAGEDQTY"">
                  <ns0:STAGEDQTY>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:STAGEDQTY>
                </xsl:for-each>
                <xsl:for-each select=""ns0:STORELOCSITEID"">
                  <ns0:STORELOCSITEID>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:STORELOCSITEID>
                </xsl:for-each>
                <xsl:for-each select=""ns0:TOSTORELOC"">
                  <ns0:TOSTORELOC>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:TOSTORELOC>
                </xsl:for-each>
                <xsl:value-of select=""./text()"" />
              </ns0:INVRESERVE>
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
                <xsl:for-each select=""ns0:CLIENTVIEWABLE"">
                  <ns0:CLIENTVIEWABLE>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:CLIENTVIEWABLE>
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
                <ns0:DESCRIPTION_LONGDESCRIPTION>
                  <xsl:if test=""ns0:DESCRIPTION_LONGDESCRIPTION/@changed"">
                    <xsl:attribute name=""changed"">
                      <xsl:value-of select=""ns0:DESCRIPTION_LONGDESCRIPTION/@changed"" />
                    </xsl:attribute>
                  </xsl:if>
                  <xsl:value-of select=""ns0:DESCRIPTION_LONGDESCRIPTION/text()"" />
                </ns0:DESCRIPTION_LONGDESCRIPTION>
                <xsl:for-each select=""ns0:EMAIL_ADDRESS"">
                  <ns0:EMAIL_ADDRESS>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:EMAIL_ADDRESS>
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
                <xsl:for-each select=""ns0:M2SMS_PWD"">
                  <ns0:M2SMS_PWD>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:M2SMS_PWD>
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
                <xsl:for-each select=""ns0:ORGID"">
                  <ns0:ORGID>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:ORGID>
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
                <xsl:for-each select=""ns0:WORKLOGID"">
                  <ns0:WORKLOGID>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:WORKLOGID>
                </xsl:for-each>
                <xsl:value-of select=""./text()"" />
              </ns0:WORKLOG>
            </xsl:for-each>
            <xsl:for-each select=""ns0:MTFM_WOMITEVS"">
              <ns0:MTFM_WOMITEVS>
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
                <xsl:for-each select=""ns0:EVTDATE"">
                  <ns0:EVTDATE>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:EVTDATE>
                </xsl:for-each>
                <xsl:for-each select=""ns0:MITEVT"">
                  <ns0:MITEVT>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:MITEVT>
                </xsl:for-each>
                <xsl:for-each select=""ns0:MTFM_WOMITEVSID"">
                  <ns0:MTFM_WOMITEVSID>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:MTFM_WOMITEVSID>
                </xsl:for-each>
                <xsl:for-each select=""ns0:NOTES"">
                  <ns0:NOTES>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:NOTES>
                </xsl:for-each>
                <xsl:for-each select=""ns0:NOTES_LONGDESCRIPTION"">
                  <ns0:NOTES_LONGDESCRIPTION>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:NOTES_LONGDESCRIPTION>
                </xsl:for-each>
                <xsl:value-of select=""./text()"" />
              </ns0:MTFM_WOMITEVS>
            </xsl:for-each>
            <xsl:for-each select=""ns0:LOCATIONS"">
              <ns0:LOCATIONS>
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
                <xsl:for-each select=""ns0:ASSIGNEDOWNERGROUP"">
                  <ns0:ASSIGNEDOWNERGROUP>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:ASSIGNEDOWNERGROUP>
                </xsl:for-each>
                <xsl:for-each select=""ns0:AUTOWOGEN"">
                  <ns0:AUTOWOGEN>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:AUTOWOGEN>
                </xsl:for-each>
                <xsl:for-each select=""ns0:BILLTOADDRESSCODE"">
                  <ns0:BILLTOADDRESSCODE>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:BILLTOADDRESSCODE>
                </xsl:for-each>
                <xsl:for-each select=""ns0:BILLTOLABORCODE"">
                  <ns0:BILLTOLABORCODE>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:BILLTOLABORCODE>
                </xsl:for-each>
                <xsl:for-each select=""ns0:CHANGEBY"">
                  <ns0:CHANGEBY>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:CHANGEBY>
                </xsl:for-each>
                <xsl:for-each select=""ns0:CHANGEDATE"">
                  <ns0:CHANGEDATE>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:CHANGEDATE>
                </xsl:for-each>
                <xsl:for-each select=""ns0:CLASSSTRUCTUREID"">
                  <ns0:CLASSSTRUCTUREID>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:CLASSSTRUCTUREID>
                </xsl:for-each>
                <xsl:for-each select=""ns0:CLIENTLOCREF"">
                  <ns0:CLIENTLOCREF>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:CLIENTLOCREF>
                </xsl:for-each>
                <xsl:for-each select=""ns0:CONTRACTNO"">
                  <ns0:CONTRACTNO>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:CONTRACTNO>
                </xsl:for-each>
                <xsl:for-each select=""ns0:CONTROLACC"">
                  <ns0:CONTROLACC>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:if test=""ns0:VALUE"">
                      <ns0:VALUE>
                        <xsl:value-of select=""ns0:VALUE/text()"" />
                      </ns0:VALUE>
                    </xsl:if>
                    <xsl:for-each select=""ns0:GLCOMP"">
                      <ns0:GLCOMP>
                        <xsl:attribute name=""glorder"">
                          <xsl:value-of select=""@glorder"" />
                        </xsl:attribute>
                        <xsl:value-of select=""./text()"" />
                      </ns0:GLCOMP>
                    </xsl:for-each>
                    <xsl:value-of select=""./text()"" />
                  </ns0:CONTROLACC>
                </xsl:for-each>
                <xsl:for-each select=""ns0:CURVARACC"">
                  <ns0:CURVARACC>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:if test=""ns0:VALUE"">
                      <ns0:VALUE>
                        <xsl:value-of select=""ns0:VALUE/text()"" />
                      </ns0:VALUE>
                    </xsl:if>
                    <xsl:for-each select=""ns0:GLCOMP"">
                      <ns0:GLCOMP>
                        <xsl:attribute name=""glorder"">
                          <xsl:value-of select=""@glorder"" />
                        </xsl:attribute>
                        <xsl:value-of select=""./text()"" />
                      </ns0:GLCOMP>
                    </xsl:for-each>
                    <xsl:value-of select=""./text()"" />
                  </ns0:CURVARACC>
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
                <xsl:for-each select=""ns0:DISABLED"">
                  <ns0:DISABLED>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:DISABLED>
                </xsl:for-each>
                <xsl:for-each select=""ns0:EXTERNALREFID"">
                  <ns0:EXTERNALREFID>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:EXTERNALREFID>
                </xsl:for-each>
                <xsl:for-each select=""ns0:GISPARAM1"">
                  <ns0:GISPARAM1>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:GISPARAM1>
                </xsl:for-each>
                <xsl:for-each select=""ns0:GISPARAM2"">
                  <ns0:GISPARAM2>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:GISPARAM2>
                </xsl:for-each>
                <xsl:for-each select=""ns0:GISPARAM3"">
                  <ns0:GISPARAM3>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:GISPARAM3>
                </xsl:for-each>
                <xsl:for-each select=""ns0:GLACCOUNT"">
                  <ns0:GLACCOUNT>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:if test=""ns0:VALUE"">
                      <ns0:VALUE>
                        <xsl:value-of select=""ns0:VALUE/text()"" />
                      </ns0:VALUE>
                    </xsl:if>
                    <xsl:for-each select=""ns0:GLCOMP"">
                      <ns0:GLCOMP>
                        <xsl:attribute name=""glorder"">
                          <xsl:value-of select=""@glorder"" />
                        </xsl:attribute>
                        <xsl:value-of select=""./text()"" />
                      </ns0:GLCOMP>
                    </xsl:for-each>
                    <xsl:value-of select=""./text()"" />
                  </ns0:GLACCOUNT>
                </xsl:for-each>
                <xsl:for-each select=""ns0:INTLABREC"">
                  <ns0:INTLABREC>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:if test=""ns0:VALUE"">
                      <ns0:VALUE>
                        <xsl:value-of select=""ns0:VALUE/text()"" />
                      </ns0:VALUE>
                    </xsl:if>
                    <xsl:for-each select=""ns0:GLCOMP"">
                      <ns0:GLCOMP>
                        <xsl:attribute name=""glorder"">
                          <xsl:value-of select=""@glorder"" />
                        </xsl:attribute>
                        <xsl:value-of select=""./text()"" />
                      </ns0:GLCOMP>
                    </xsl:for-each>
                    <xsl:value-of select=""./text()"" />
                  </ns0:INTLABREC>
                </xsl:for-each>
                <xsl:for-each select=""ns0:INVCOSTADJACC"">
                  <ns0:INVCOSTADJACC>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:if test=""ns0:VALUE"">
                      <ns0:VALUE>
                        <xsl:value-of select=""ns0:VALUE/text()"" />
                      </ns0:VALUE>
                    </xsl:if>
                    <xsl:for-each select=""ns0:GLCOMP"">
                      <ns0:GLCOMP>
                        <xsl:attribute name=""glorder"">
                          <xsl:value-of select=""@glorder"" />
                        </xsl:attribute>
                        <xsl:value-of select=""./text()"" />
                      </ns0:GLCOMP>
                    </xsl:for-each>
                    <xsl:value-of select=""./text()"" />
                  </ns0:INVCOSTADJACC>
                </xsl:for-each>
                <xsl:for-each select=""ns0:INVOICEVARACC"">
                  <ns0:INVOICEVARACC>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:if test=""ns0:VALUE"">
                      <ns0:VALUE>
                        <xsl:value-of select=""ns0:VALUE/text()"" />
                      </ns0:VALUE>
                    </xsl:if>
                    <xsl:for-each select=""ns0:GLCOMP"">
                      <ns0:GLCOMP>
                        <xsl:attribute name=""glorder"">
                          <xsl:value-of select=""@glorder"" />
                        </xsl:attribute>
                        <xsl:value-of select=""./text()"" />
                      </ns0:GLCOMP>
                    </xsl:for-each>
                    <xsl:value-of select=""./text()"" />
                  </ns0:INVOICEVARACC>
                </xsl:for-each>
                <xsl:for-each select=""ns0:INVOWNER"">
                  <ns0:INVOWNER>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:INVOWNER>
                </xsl:for-each>
                <xsl:for-each select=""ns0:ISDEFAULT"">
                  <ns0:ISDEFAULT>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:ISDEFAULT>
                </xsl:for-each>
                <xsl:for-each select=""ns0:ISREPAIRFACILITY"">
                  <ns0:ISREPAIRFACILITY>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:ISREPAIRFACILITY>
                </xsl:for-each>
                <xsl:for-each select=""ns0:LOCATION"">
                  <ns0:LOCATION>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:LOCATION>
                </xsl:for-each>
                <xsl:for-each select=""ns0:LOCATIONSID"">
                  <ns0:LOCATIONSID>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:LOCATIONSID>
                </xsl:for-each>
                <xsl:for-each select=""ns0:LOCATTRIBUTE1"">
                  <ns0:LOCATTRIBUTE1>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:LOCATTRIBUTE1>
                </xsl:for-each>
                <xsl:for-each select=""ns0:LOCATTRIBUTE10"">
                  <ns0:LOCATTRIBUTE10>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:LOCATTRIBUTE10>
                </xsl:for-each>
                <xsl:for-each select=""ns0:LOCATTRIBUTE11"">
                  <ns0:LOCATTRIBUTE11>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:LOCATTRIBUTE11>
                </xsl:for-each>
                <xsl:for-each select=""ns0:LOCATTRIBUTE2"">
                  <ns0:LOCATTRIBUTE2>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:LOCATTRIBUTE2>
                </xsl:for-each>
                <xsl:for-each select=""ns0:LOCATTRIBUTE3"">
                  <ns0:LOCATTRIBUTE3>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:LOCATTRIBUTE3>
                </xsl:for-each>
                <xsl:for-each select=""ns0:LOCATTRIBUTE4"">
                  <ns0:LOCATTRIBUTE4>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:LOCATTRIBUTE4>
                </xsl:for-each>
                <xsl:for-each select=""ns0:LOCATTRIBUTE5"">
                  <ns0:LOCATTRIBUTE5>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:LOCATTRIBUTE5>
                </xsl:for-each>
                <xsl:for-each select=""ns0:LOCATTRIBUTE6"">
                  <ns0:LOCATTRIBUTE6>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:LOCATTRIBUTE6>
                </xsl:for-each>
                <xsl:for-each select=""ns0:LOCATTRIBUTE7"">
                  <ns0:LOCATTRIBUTE7>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:LOCATTRIBUTE7>
                </xsl:for-each>
                <xsl:for-each select=""ns0:LOCATTRIBUTE8"">
                  <ns0:LOCATTRIBUTE8>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:LOCATTRIBUTE8>
                </xsl:for-each>
                <xsl:for-each select=""ns0:LOCATTRIBUTE9"">
                  <ns0:LOCATTRIBUTE9>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:LOCATTRIBUTE9>
                </xsl:for-each>
                <xsl:for-each select=""ns0:LOCOWNER"">
                  <ns0:LOCOWNER>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:LOCOWNER>
                </xsl:for-each>
                <xsl:for-each select=""ns0:MTFMBLDGCLASS1"">
                  <ns0:MTFMBLDGCLASS1>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:MTFMBLDGCLASS1>
                </xsl:for-each>
                <xsl:for-each select=""ns0:MTFMBLDGCLASS2"">
                  <ns0:MTFMBLDGCLASS2>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:MTFMBLDGCLASS2>
                </xsl:for-each>
                <xsl:for-each select=""ns0:MTFMCLIENTACC"">
                  <ns0:MTFMCLIENTACC>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:MTFMCLIENTACC>
                </xsl:for-each>
                <xsl:for-each select=""ns0:MTFMCLNAME"">
                  <ns0:MTFMCLNAME>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:MTFMCLNAME>
                </xsl:for-each>
                <xsl:for-each select=""ns0:MTFMCLPHONE"">
                  <ns0:MTFMCLPHONE>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:MTFMCLPHONE>
                </xsl:for-each>
                <xsl:for-each select=""ns0:MTFMCONTNUM"">
                  <ns0:MTFMCONTNUM>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:MTFMCONTNUM>
                </xsl:for-each>
                <xsl:for-each select=""ns0:MTFMLOCLVL"">
                  <ns0:MTFMLOCLVL>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:MTFMLOCLVL>
                </xsl:for-each>
                <xsl:for-each select=""ns0:MTFMLOCPOS"">
                  <ns0:MTFMLOCPOS>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:MTFMLOCPOS>
                </xsl:for-each>
                <xsl:for-each select=""ns0:MTFMPMJOB"">
                  <ns0:MTFMPMJOB>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:MTFMPMJOB>
                </xsl:for-each>
                <xsl:for-each select=""ns0:MTFMPORTFOLIO"">
                  <ns0:MTFMPORTFOLIO>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:MTFMPORTFOLIO>
                </xsl:for-each>
                <xsl:for-each select=""ns0:MTFMSOURCESYS"">
                  <ns0:MTFMSOURCESYS>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:MTFMSOURCESYS>
                </xsl:for-each>
                <xsl:for-each select=""ns0:MTFMSUPER"">
                  <ns0:MTFMSUPER>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:MTFMSUPER>
                </xsl:for-each>
                <xsl:for-each select=""ns0:MTFM_PMBPN"">
                  <ns0:MTFM_PMBPN>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:MTFM_PMBPN>
                </xsl:for-each>
                <xsl:for-each select=""ns0:MTFM_RWBPN"">
                  <ns0:MTFM_RWBPN>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:MTFM_RWBPN>
                </xsl:for-each>
                <xsl:for-each select=""ns0:OLDCONTROLACC"">
                  <ns0:OLDCONTROLACC>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:if test=""ns0:VALUE"">
                      <ns0:VALUE>
                        <xsl:value-of select=""ns0:VALUE/text()"" />
                      </ns0:VALUE>
                    </xsl:if>
                    <xsl:for-each select=""ns0:GLCOMP"">
                      <ns0:GLCOMP>
                        <xsl:attribute name=""glorder"">
                          <xsl:value-of select=""@glorder"" />
                        </xsl:attribute>
                        <xsl:value-of select=""./text()"" />
                      </ns0:GLCOMP>
                    </xsl:for-each>
                    <xsl:value-of select=""./text()"" />
                  </ns0:OLDCONTROLACC>
                </xsl:for-each>
                <xsl:for-each select=""ns0:OLDINVCOSTADJACC"">
                  <ns0:OLDINVCOSTADJACC>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:if test=""ns0:VALUE"">
                      <ns0:VALUE>
                        <xsl:value-of select=""ns0:VALUE/text()"" />
                      </ns0:VALUE>
                    </xsl:if>
                    <xsl:for-each select=""ns0:GLCOMP"">
                      <ns0:GLCOMP>
                        <xsl:attribute name=""glorder"">
                          <xsl:value-of select=""@glorder"" />
                        </xsl:attribute>
                        <xsl:value-of select=""./text()"" />
                      </ns0:GLCOMP>
                    </xsl:for-each>
                    <xsl:value-of select=""./text()"" />
                  </ns0:OLDINVCOSTADJACC>
                </xsl:for-each>
                <xsl:for-each select=""ns0:OLDSHRINKAGEACC"">
                  <ns0:OLDSHRINKAGEACC>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:if test=""ns0:VALUE"">
                      <ns0:VALUE>
                        <xsl:value-of select=""ns0:VALUE/text()"" />
                      </ns0:VALUE>
                    </xsl:if>
                    <xsl:for-each select=""ns0:GLCOMP"">
                      <ns0:GLCOMP>
                        <xsl:attribute name=""glorder"">
                          <xsl:value-of select=""@glorder"" />
                        </xsl:attribute>
                        <xsl:value-of select=""./text()"" />
                      </ns0:GLCOMP>
                    </xsl:for-each>
                    <xsl:value-of select=""./text()"" />
                  </ns0:OLDSHRINKAGEACC>
                </xsl:for-each>
                <xsl:for-each select=""ns0:ORGID"">
                  <ns0:ORGID>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:ORGID>
                </xsl:for-each>
                <xsl:for-each select=""ns0:OWNER"">
                  <ns0:OWNER>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:OWNER>
                </xsl:for-each>
                <xsl:for-each select=""ns0:OWNERGROUP"">
                  <ns0:OWNERGROUP>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:OWNERGROUP>
                </xsl:for-each>
                <xsl:for-each select=""ns0:OWNERSYSID"">
                  <ns0:OWNERSYSID>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:OWNERSYSID>
                </xsl:for-each>
                <xsl:for-each select=""ns0:PLUSCDUEDATE"">
                  <ns0:PLUSCDUEDATE>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:PLUSCDUEDATE>
                </xsl:for-each>
                <xsl:for-each select=""ns0:PLUSCLOOP"">
                  <ns0:PLUSCLOOP>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:PLUSCLOOP>
                </xsl:for-each>
                <xsl:for-each select=""ns0:PLUSCPMEXTDATE"">
                  <ns0:PLUSCPMEXTDATE>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:PLUSCPMEXTDATE>
                </xsl:for-each>
                <xsl:for-each select=""ns0:PURCHVARACC"">
                  <ns0:PURCHVARACC>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:if test=""ns0:VALUE"">
                      <ns0:VALUE>
                        <xsl:value-of select=""ns0:VALUE/text()"" />
                      </ns0:VALUE>
                    </xsl:if>
                    <xsl:for-each select=""ns0:GLCOMP"">
                      <ns0:GLCOMP>
                        <xsl:attribute name=""glorder"">
                          <xsl:value-of select=""@glorder"" />
                        </xsl:attribute>
                        <xsl:value-of select=""./text()"" />
                      </ns0:GLCOMP>
                    </xsl:for-each>
                    <xsl:value-of select=""./text()"" />
                  </ns0:PURCHVARACC>
                </xsl:for-each>
                <xsl:for-each select=""ns0:RECEIPTVARACC"">
                  <ns0:RECEIPTVARACC>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:if test=""ns0:VALUE"">
                      <ns0:VALUE>
                        <xsl:value-of select=""ns0:VALUE/text()"" />
                      </ns0:VALUE>
                    </xsl:if>
                    <xsl:for-each select=""ns0:GLCOMP"">
                      <ns0:GLCOMP>
                        <xsl:attribute name=""glorder"">
                          <xsl:value-of select=""@glorder"" />
                        </xsl:attribute>
                        <xsl:value-of select=""./text()"" />
                      </ns0:GLCOMP>
                    </xsl:for-each>
                    <xsl:value-of select=""./text()"" />
                  </ns0:RECEIPTVARACC>
                </xsl:for-each>
                <xsl:for-each select=""ns0:SENDERSYSID"">
                  <ns0:SENDERSYSID>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:SENDERSYSID>
                </xsl:for-each>
                <xsl:for-each select=""ns0:SERVICEADDRESSCODE"">
                  <ns0:SERVICEADDRESSCODE>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:SERVICEADDRESSCODE>
                </xsl:for-each>
                <xsl:for-each select=""ns0:SHIPTOADDRESSCODE"">
                  <ns0:SHIPTOADDRESSCODE>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:SHIPTOADDRESSCODE>
                </xsl:for-each>
                <xsl:for-each select=""ns0:SHIPTOLABORCODE"">
                  <ns0:SHIPTOLABORCODE>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:SHIPTOLABORCODE>
                </xsl:for-each>
                <xsl:for-each select=""ns0:SHRINKAGEACC"">
                  <ns0:SHRINKAGEACC>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:if test=""ns0:VALUE"">
                      <ns0:VALUE>
                        <xsl:value-of select=""ns0:VALUE/text()"" />
                      </ns0:VALUE>
                    </xsl:if>
                    <xsl:for-each select=""ns0:GLCOMP"">
                      <ns0:GLCOMP>
                        <xsl:attribute name=""glorder"">
                          <xsl:value-of select=""@glorder"" />
                        </xsl:attribute>
                        <xsl:value-of select=""./text()"" />
                      </ns0:GLCOMP>
                    </xsl:for-each>
                    <xsl:value-of select=""./text()"" />
                  </ns0:SHRINKAGEACC>
                </xsl:for-each>
                <xsl:for-each select=""ns0:SOURCESYSID"">
                  <ns0:SOURCESYSID>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:SOURCESYSID>
                </xsl:for-each>
                <xsl:for-each select=""ns0:STATUS"">
                  <ns0:STATUS>
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
                  </ns0:STATUS>
                </xsl:for-each>
                <xsl:for-each select=""ns0:STATUSDATE"">
                  <ns0:STATUSDATE>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:STATUSDATE>
                </xsl:for-each>
                <xsl:for-each select=""ns0:SUBOWNER"">
                  <ns0:SUBOWNER>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:SUBOWNER>
                </xsl:for-each>
                <xsl:for-each select=""ns0:SUBOWNER2"">
                  <ns0:SUBOWNER2>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:SUBOWNER2>
                </xsl:for-each>
                <xsl:for-each select=""ns0:TOOLCONTROLACC"">
                  <ns0:TOOLCONTROLACC>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:if test=""ns0:VALUE"">
                      <ns0:VALUE>
                        <xsl:value-of select=""ns0:VALUE/text()"" />
                      </ns0:VALUE>
                    </xsl:if>
                    <xsl:for-each select=""ns0:GLCOMP"">
                      <ns0:GLCOMP>
                        <xsl:attribute name=""glorder"">
                          <xsl:value-of select=""@glorder"" />
                        </xsl:attribute>
                        <xsl:value-of select=""./text()"" />
                      </ns0:GLCOMP>
                    </xsl:for-each>
                    <xsl:value-of select=""./text()"" />
                  </ns0:TOOLCONTROLACC>
                </xsl:for-each>
                <xsl:for-each select=""ns0:TYPE"">
                  <ns0:TYPE>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:TYPE>
                </xsl:for-each>
                <xsl:for-each select=""ns0:USEINPOPR"">
                  <ns0:USEINPOPR>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:USEINPOPR>
                </xsl:for-each>
                <xsl:value-of select=""./text()"" />
              </ns0:LOCATIONS>
            </xsl:for-each>
            <xsl:for-each select=""ns0:PM"">
              <ns0:PM>
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
                <xsl:for-each select=""ns0:ADJNEXTDUE"">
                  <ns0:ADJNEXTDUE>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:ADJNEXTDUE>
                </xsl:for-each>
                <xsl:for-each select=""ns0:ALERTLEAD"">
                  <ns0:ALERTLEAD>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:ALERTLEAD>
                </xsl:for-each>
                <xsl:for-each select=""ns0:ASSETFEATUREID"">
                  <ns0:ASSETFEATUREID>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:ASSETFEATUREID>
                </xsl:for-each>
                <xsl:for-each select=""ns0:ASSETNUM"">
                  <ns0:ASSETNUM>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:ASSETNUM>
                </xsl:for-each>
                <xsl:for-each select=""ns0:ASSIGNEDOWNERGROUP"">
                  <ns0:ASSIGNEDOWNERGROUP>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:ASSIGNEDOWNERGROUP>
                </xsl:for-each>
                <xsl:for-each select=""ns0:BASEMEASUREUNITID"">
                  <ns0:BASEMEASUREUNITID>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:BASEMEASUREUNITID>
                </xsl:for-each>
                <xsl:for-each select=""ns0:BASEMEASUREUNITUID"">
                  <ns0:BASEMEASUREUNITUID>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:BASEMEASUREUNITUID>
                </xsl:for-each>
                <xsl:for-each select=""ns0:CALENDAR"">
                  <ns0:CALENDAR>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:CALENDAR>
                </xsl:for-each>
                <xsl:for-each select=""ns0:CHANGEBY"">
                  <ns0:CHANGEBY>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:CHANGEBY>
                </xsl:for-each>
                <xsl:for-each select=""ns0:CHANGEDATE"">
                  <ns0:CHANGEDATE>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:CHANGEDATE>
                </xsl:for-each>
                <xsl:for-each select=""ns0:CHARGEABLE"">
                  <ns0:CHARGEABLE>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:CHARGEABLE>
                </xsl:for-each>
                <xsl:for-each select=""ns0:CLASSSTRUCTUREID"">
                  <ns0:CLASSSTRUCTUREID>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:CLASSSTRUCTUREID>
                </xsl:for-each>
                <xsl:for-each select=""ns0:CREWID"">
                  <ns0:CREWID>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:CREWID>
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
                <xsl:for-each select=""ns0:DOWNTIME"">
                  <ns0:DOWNTIME>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:DOWNTIME>
                </xsl:for-each>
                <xsl:for-each select=""ns0:ENDASSETFEATUREID"">
                  <ns0:ENDASSETFEATUREID>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:ENDASSETFEATUREID>
                </xsl:for-each>
                <xsl:for-each select=""ns0:ENDBASEMEASURE"">
                  <ns0:ENDBASEMEASURE>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:ENDBASEMEASURE>
                </xsl:for-each>
                <xsl:for-each select=""ns0:ENDMEASURE"">
                  <ns0:ENDMEASURE>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:ENDMEASURE>
                </xsl:for-each>
                <xsl:for-each select=""ns0:ENDMEASUREUNITID"">
                  <ns0:ENDMEASUREUNITID>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:ENDMEASUREUNITID>
                </xsl:for-each>
                <xsl:for-each select=""ns0:ENDMEASUREUNITUID"">
                  <ns0:ENDMEASUREUNITUID>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:ENDMEASUREUNITUID>
                </xsl:for-each>
                <xsl:for-each select=""ns0:ENDOFFSET"">
                  <ns0:ENDOFFSET>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:ENDOFFSET>
                </xsl:for-each>
                <xsl:for-each select=""ns0:ENDOFFSETUNITID"">
                  <ns0:ENDOFFSETUNITID>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:ENDOFFSETUNITID>
                </xsl:for-each>
                <xsl:for-each select=""ns0:ENDOFFSETUNITUID"">
                  <ns0:ENDOFFSETUNITUID>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:ENDOFFSETUNITUID>
                </xsl:for-each>
                <xsl:for-each select=""ns0:ENDYOFFSET"">
                  <ns0:ENDYOFFSET>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:ENDYOFFSET>
                </xsl:for-each>
                <xsl:for-each select=""ns0:ENDYOFFSETREF"">
                  <ns0:ENDYOFFSETREF>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:ENDYOFFSETREF>
                </xsl:for-each>
                <xsl:for-each select=""ns0:ENDZOFFSET"">
                  <ns0:ENDZOFFSET>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:ENDZOFFSET>
                </xsl:for-each>
                <xsl:for-each select=""ns0:ENDZOFFSETREF"">
                  <ns0:ENDZOFFSETREF>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:ENDZOFFSETREF>
                </xsl:for-each>
                <xsl:for-each select=""ns0:EXTDATE"">
                  <ns0:EXTDATE>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:EXTDATE>
                </xsl:for-each>
                <xsl:for-each select=""ns0:FIRSTDATE"">
                  <ns0:FIRSTDATE>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:FIRSTDATE>
                </xsl:for-each>
                <xsl:for-each select=""ns0:FNCONOFFSET"">
                  <ns0:FNCONOFFSET>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:FNCONOFFSET>
                </xsl:for-each>
                <xsl:for-each select=""ns0:FREQUENCY"">
                  <ns0:FREQUENCY>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:FREQUENCY>
                </xsl:for-each>
                <xsl:for-each select=""ns0:FREQUNIT"">
                  <ns0:FREQUNIT>
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
                  </ns0:FREQUNIT>
                </xsl:for-each>
                <xsl:for-each select=""ns0:FRIDAY"">
                  <ns0:FRIDAY>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:FRIDAY>
                </xsl:for-each>
                <xsl:for-each select=""ns0:GLACCOUNT"">
                  <ns0:GLACCOUNT>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:if test=""ns0:VALUE"">
                      <ns0:VALUE>
                        <xsl:value-of select=""ns0:VALUE/text()"" />
                      </ns0:VALUE>
                    </xsl:if>
                    <xsl:for-each select=""ns0:GLCOMP"">
                      <ns0:GLCOMP>
                        <xsl:attribute name=""glorder"">
                          <xsl:value-of select=""@glorder"" />
                        </xsl:attribute>
                        <xsl:value-of select=""./text()"" />
                      </ns0:GLCOMP>
                    </xsl:for-each>
                    <xsl:value-of select=""./text()"" />
                  </ns0:GLACCOUNT>
                </xsl:for-each>
                <xsl:for-each select=""ns0:HASCHILDREN"">
                  <ns0:HASCHILDREN>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:HASCHILDREN>
                </xsl:for-each>
                <xsl:for-each select=""ns0:INCLFORECAST"">
                  <ns0:INCLFORECAST>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:INCLFORECAST>
                </xsl:for-each>
                <xsl:for-each select=""ns0:INTERRUPTIBLE"">
                  <ns0:INTERRUPTIBLE>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:INTERRUPTIBLE>
                </xsl:for-each>
                <xsl:for-each select=""ns0:JPNUM"">
                  <ns0:JPNUM>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:JPNUM>
                </xsl:for-each>
                <xsl:for-each select=""ns0:JPSEQINUSE"">
                  <ns0:JPSEQINUSE>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:JPSEQINUSE>
                </xsl:for-each>
                <xsl:for-each select=""ns0:LASTCOMPDATE"">
                  <ns0:LASTCOMPDATE>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:LASTCOMPDATE>
                </xsl:for-each>
                <xsl:for-each select=""ns0:LASTSTARTDATE"">
                  <ns0:LASTSTARTDATE>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:LASTSTARTDATE>
                </xsl:for-each>
                <xsl:for-each select=""ns0:LEAD"">
                  <ns0:LEAD>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:LEAD>
                </xsl:for-each>
                <xsl:for-each select=""ns0:LEADTIME"">
                  <ns0:LEADTIME>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:LEADTIME>
                </xsl:for-each>
                <xsl:for-each select=""ns0:LOCATION"">
                  <ns0:LOCATION>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:LOCATION>
                </xsl:for-each>
                <xsl:for-each select=""ns0:LOCKFORECAST"">
                  <ns0:LOCKFORECAST>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:LOCKFORECAST>
                </xsl:for-each>
                <xsl:for-each select=""ns0:LTDPMCOUNTER"">
                  <ns0:LTDPMCOUNTER>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:LTDPMCOUNTER>
                </xsl:for-each>
                <xsl:for-each select=""ns0:MASTERPM"">
                  <ns0:MASTERPM>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:MASTERPM>
                </xsl:for-each>
                <xsl:for-each select=""ns0:MONDAY"">
                  <ns0:MONDAY>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:MONDAY>
                </xsl:for-each>
                <xsl:for-each select=""ns0:MTFMLOCALMAINT"">
                  <ns0:MTFMLOCALMAINT>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:MTFMLOCALMAINT>
                </xsl:for-each>
                <xsl:for-each select=""ns0:MTFMTEST"">
                  <ns0:MTFMTEST>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:MTFMTEST>
                </xsl:for-each>
                <xsl:for-each select=""ns0:MTFM_CHRG"">
                  <ns0:MTFM_CHRG>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:MTFM_CHRG>
                </xsl:for-each>
                <xsl:for-each select=""ns0:NEXTDATE"">
                  <ns0:NEXTDATE>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:NEXTDATE>
                </xsl:for-each>
                <xsl:for-each select=""ns0:ORGID"">
                  <ns0:ORGID>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:ORGID>
                </xsl:for-each>
                <xsl:for-each select=""ns0:OVERRIDEMASTERUPD"">
                  <ns0:OVERRIDEMASTERUPD>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:OVERRIDEMASTERUPD>
                </xsl:for-each>
                <xsl:for-each select=""ns0:OWNER"">
                  <ns0:OWNER>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:OWNER>
                </xsl:for-each>
                <xsl:for-each select=""ns0:OWNERGROUP"">
                  <ns0:OWNERGROUP>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:OWNERGROUP>
                </xsl:for-each>
                <xsl:for-each select=""ns0:PARENT"">
                  <ns0:PARENT>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:PARENT>
                </xsl:for-each>
                <xsl:for-each select=""ns0:PARENTCHGSSTATUS"">
                  <ns0:PARENTCHGSSTATUS>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:PARENTCHGSSTATUS>
                </xsl:for-each>
                <xsl:for-each select=""ns0:PERSONGROUP"">
                  <ns0:PERSONGROUP>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:PERSONGROUP>
                </xsl:for-each>
                <xsl:for-each select=""ns0:PLUSCDUEDATE"">
                  <ns0:PLUSCDUEDATE>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:PLUSCDUEDATE>
                </xsl:for-each>
                <xsl:for-each select=""ns0:PMACTMETER"">
                  <ns0:PMACTMETER>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:PMACTMETER>
                </xsl:for-each>
                <xsl:for-each select=""ns0:PMASSETWOGEN"">
                  <ns0:PMASSETWOGEN>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:PMASSETWOGEN>
                </xsl:for-each>
                <xsl:for-each select=""ns0:PMCOUNTER"">
                  <ns0:PMCOUNTER>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:PMCOUNTER>
                </xsl:for-each>
                <xsl:for-each select=""ns0:PMEQ1"">
                  <ns0:PMEQ1>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:PMEQ1>
                </xsl:for-each>
                <xsl:for-each select=""ns0:PMEQ2"">
                  <ns0:PMEQ2>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:PMEQ2>
                </xsl:for-each>
                <xsl:for-each select=""ns0:PMEQ3"">
                  <ns0:PMEQ3>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:PMEQ3>
                </xsl:for-each>
                <xsl:for-each select=""ns0:PMNUM"">
                  <ns0:PMNUM>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:PMNUM>
                </xsl:for-each>
                <xsl:for-each select=""ns0:PMUID"">
                  <ns0:PMUID>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:PMUID>
                </xsl:for-each>
                <xsl:for-each select=""ns0:PRIORITY"">
                  <ns0:PRIORITY>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:PRIORITY>
                </xsl:for-each>
                <xsl:for-each select=""ns0:REFORECAST"">
                  <ns0:REFORECAST>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:REFORECAST>
                </xsl:for-each>
                <xsl:for-each select=""ns0:ROUTE"">
                  <ns0:ROUTE>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:ROUTE>
                </xsl:for-each>
                <xsl:for-each select=""ns0:SATURDAY"">
                  <ns0:SATURDAY>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:SATURDAY>
                </xsl:for-each>
                <xsl:for-each select=""ns0:SCHEDEARLY"">
                  <ns0:SCHEDEARLY>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:SCHEDEARLY>
                </xsl:for-each>
                <xsl:for-each select=""ns0:STARTASSETFEATUREID"">
                  <ns0:STARTASSETFEATUREID>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:STARTASSETFEATUREID>
                </xsl:for-each>
                <xsl:for-each select=""ns0:STARTBASEMEASURE"">
                  <ns0:STARTBASEMEASURE>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:STARTBASEMEASURE>
                </xsl:for-each>
                <xsl:for-each select=""ns0:STARTMEASURE"">
                  <ns0:STARTMEASURE>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:STARTMEASURE>
                </xsl:for-each>
                <xsl:for-each select=""ns0:STARTMEASUREUNITID"">
                  <ns0:STARTMEASUREUNITID>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:STARTMEASUREUNITID>
                </xsl:for-each>
                <xsl:for-each select=""ns0:STARTMEASUREUNITUID"">
                  <ns0:STARTMEASUREUNITUID>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:STARTMEASUREUNITUID>
                </xsl:for-each>
                <xsl:for-each select=""ns0:STARTOFFSET"">
                  <ns0:STARTOFFSET>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:STARTOFFSET>
                </xsl:for-each>
                <xsl:for-each select=""ns0:STARTOFFSETUNITID"">
                  <ns0:STARTOFFSETUNITID>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:STARTOFFSETUNITID>
                </xsl:for-each>
                <xsl:for-each select=""ns0:STARTOFFSETUNITUID"">
                  <ns0:STARTOFFSETUNITUID>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:STARTOFFSETUNITUID>
                </xsl:for-each>
                <xsl:for-each select=""ns0:STARTYOFFSET"">
                  <ns0:STARTYOFFSET>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:STARTYOFFSET>
                </xsl:for-each>
                <xsl:for-each select=""ns0:STARTYOFFSETREF"">
                  <ns0:STARTYOFFSETREF>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:STARTYOFFSETREF>
                </xsl:for-each>
                <xsl:for-each select=""ns0:STARTZOFFSET"">
                  <ns0:STARTZOFFSET>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:STARTZOFFSET>
                </xsl:for-each>
                <xsl:for-each select=""ns0:STARTZOFFSETREF"">
                  <ns0:STARTZOFFSETREF>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:STARTZOFFSETREF>
                </xsl:for-each>
                <xsl:for-each select=""ns0:STATUS"">
                  <ns0:STATUS>
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
                  </ns0:STATUS>
                </xsl:for-each>
                <xsl:for-each select=""ns0:STCONOFFSET"">
                  <ns0:STCONOFFSET>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:STCONOFFSET>
                </xsl:for-each>
                <xsl:for-each select=""ns0:STORELOC"">
                  <ns0:STORELOC>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:STORELOC>
                </xsl:for-each>
                <xsl:for-each select=""ns0:STORELOCSITE"">
                  <ns0:STORELOCSITE>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:STORELOCSITE>
                </xsl:for-each>
                <xsl:for-each select=""ns0:SUNDAY"">
                  <ns0:SUNDAY>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:SUNDAY>
                </xsl:for-each>
                <xsl:for-each select=""ns0:SUPERVISOR"">
                  <ns0:SUPERVISOR>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:SUPERVISOR>
                </xsl:for-each>
                <xsl:for-each select=""ns0:TARGSTARTTIME"">
                  <ns0:TARGSTARTTIME>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:TARGSTARTTIME>
                </xsl:for-each>
                <xsl:for-each select=""ns0:THURSDAY"">
                  <ns0:THURSDAY>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:THURSDAY>
                </xsl:for-each>
                <xsl:for-each select=""ns0:TUESDAY"">
                  <ns0:TUESDAY>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:TUESDAY>
                </xsl:for-each>
                <xsl:for-each select=""ns0:USEFREQUENCY"">
                  <ns0:USEFREQUENCY>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:USEFREQUENCY>
                </xsl:for-each>
                <xsl:for-each select=""ns0:USETARGETDATE"">
                  <ns0:USETARGETDATE>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:USETARGETDATE>
                </xsl:for-each>
                <xsl:for-each select=""ns0:WEDNESDAY"">
                  <ns0:WEDNESDAY>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:WEDNESDAY>
                </xsl:for-each>
                <xsl:for-each select=""ns0:WORKTYPE"">
                  <ns0:WORKTYPE>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:WORKTYPE>
                </xsl:for-each>
                <xsl:for-each select=""ns0:WOSEQUENCE"">
                  <ns0:WOSEQUENCE>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:WOSEQUENCE>
                </xsl:for-each>
                <xsl:for-each select=""ns0:WOSTATUS"">
                  <ns0:WOSTATUS>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:WOSTATUS>
                </xsl:for-each>
                <xsl:value-of select=""./text()"" />
              </ns0:PM>
            </xsl:for-each>
            <xsl:for-each select=""ns0:JOBPLAN"">
              <ns0:JOBPLAN>
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
                <xsl:for-each select=""ns0:ASSIGNEDOWNERGROUP"">
                  <ns0:ASSIGNEDOWNERGROUP>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:ASSIGNEDOWNERGROUP>
                </xsl:for-each>
                <xsl:for-each select=""ns0:CALENDAR"">
                  <ns0:CALENDAR>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:CALENDAR>
                </xsl:for-each>
                <xsl:for-each select=""ns0:CLASSSTRUCTUREID"">
                  <ns0:CLASSSTRUCTUREID>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:CLASSSTRUCTUREID>
                </xsl:for-each>
                <xsl:for-each select=""ns0:CREWID"">
                  <ns0:CREWID>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:CREWID>
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
                <xsl:for-each select=""ns0:DOWNTIME"">
                  <ns0:DOWNTIME>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:DOWNTIME>
                </xsl:for-each>
                <xsl:for-each select=""ns0:FLOWACTION"">
                  <ns0:FLOWACTION>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:FLOWACTION>
                </xsl:for-each>
                <xsl:for-each select=""ns0:FLOWACTIONASSIST"">
                  <ns0:FLOWACTIONASSIST>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:FLOWACTIONASSIST>
                </xsl:for-each>
                <xsl:for-each select=""ns0:FLOWCONTROLLED"">
                  <ns0:FLOWCONTROLLED>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:FLOWCONTROLLED>
                </xsl:for-each>
                <xsl:for-each select=""ns0:FNCONOFFSET"">
                  <ns0:FNCONOFFSET>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:FNCONOFFSET>
                </xsl:for-each>
                <xsl:for-each select=""ns0:INCTASKSINSCHED"">
                  <ns0:INCTASKSINSCHED>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:INCTASKSINSCHED>
                </xsl:for-each>
                <xsl:for-each select=""ns0:INTERRUPTIBLE"">
                  <ns0:INTERRUPTIBLE>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:INTERRUPTIBLE>
                </xsl:for-each>
                <xsl:for-each select=""ns0:JOBPLANID"">
                  <ns0:JOBPLANID>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:JOBPLANID>
                </xsl:for-each>
                <xsl:for-each select=""ns0:JPDURATION"">
                  <ns0:JPDURATION>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:JPDURATION>
                </xsl:for-each>
                <xsl:for-each select=""ns0:JPNUM"">
                  <ns0:JPNUM>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:JPNUM>
                </xsl:for-each>
                <xsl:for-each select=""ns0:LABORCODE"">
                  <ns0:LABORCODE>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:LABORCODE>
                </xsl:for-each>
                <xsl:for-each select=""ns0:LAUNCHENTRYNAME"">
                  <ns0:LAUNCHENTRYNAME>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:LAUNCHENTRYNAME>
                </xsl:for-each>
                <xsl:for-each select=""ns0:MTFMCERTRQD"">
                  <ns0:MTFMCERTRQD>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:MTFMCERTRQD>
                </xsl:for-each>
                <xsl:for-each select=""ns0:MTFMJPTYPE"">
                  <ns0:MTFMJPTYPE>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:MTFMJPTYPE>
                </xsl:for-each>
                <xsl:for-each select=""ns0:ORGID"">
                  <ns0:ORGID>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:ORGID>
                </xsl:for-each>
                <xsl:for-each select=""ns0:OWNER"">
                  <ns0:OWNER>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:OWNER>
                </xsl:for-each>
                <xsl:for-each select=""ns0:OWNERGROUP"">
                  <ns0:OWNERGROUP>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:OWNERGROUP>
                </xsl:for-each>
                <xsl:for-each select=""ns0:PERSONGROUP"">
                  <ns0:PERSONGROUP>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:PERSONGROUP>
                </xsl:for-each>
                <xsl:for-each select=""ns0:PLUSCCHANGEBY"">
                  <ns0:PLUSCCHANGEBY>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:PLUSCCHANGEBY>
                </xsl:for-each>
                <xsl:for-each select=""ns0:PLUSCCHANGEDATE"">
                  <ns0:PLUSCCHANGEDATE>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:PLUSCCHANGEDATE>
                </xsl:for-each>
                <xsl:for-each select=""ns0:PLUSCREVCOM"">
                  <ns0:PLUSCREVCOM>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:PLUSCREVCOM>
                </xsl:for-each>
                <xsl:for-each select=""ns0:PLUSCREVNUM"">
                  <ns0:PLUSCREVNUM>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:PLUSCREVNUM>
                </xsl:for-each>
                <xsl:for-each select=""ns0:PLUSCSTATUSDATE"">
                  <ns0:PLUSCSTATUSDATE>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:PLUSCSTATUSDATE>
                </xsl:for-each>
                <xsl:for-each select=""ns0:PRIORITY"">
                  <ns0:PRIORITY>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:PRIORITY>
                </xsl:for-each>
                <xsl:for-each select=""ns0:STATUS"">
                  <ns0:STATUS>
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
                  </ns0:STATUS>
                </xsl:for-each>
                <xsl:for-each select=""ns0:STCONOFFSET"">
                  <ns0:STCONOFFSET>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:STCONOFFSET>
                </xsl:for-each>
                <xsl:for-each select=""ns0:SUPERVISOR"">
                  <ns0:SUPERVISOR>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:SUPERVISOR>
                </xsl:for-each>
                <xsl:for-each select=""ns0:SUSPENDFLOW"">
                  <ns0:SUSPENDFLOW>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:SUSPENDFLOW>
                </xsl:for-each>
                <xsl:for-each select=""ns0:TEMPLATETYPE"">
                  <ns0:TEMPLATETYPE>
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
                  </ns0:TEMPLATETYPE>
                </xsl:for-each>
                <xsl:value-of select=""./text()"" />
              </ns0:JOBPLAN>
            </xsl:for-each>
            <xsl:for-each select=""ns0:ASSET"">
              <ns0:ASSET>
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
                <xsl:for-each select=""ns0:ANCESTOR"">
                  <ns0:ANCESTOR>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:ANCESTOR>
                </xsl:for-each>
                <xsl:for-each select=""ns0:ASSETID"">
                  <ns0:ASSETID>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:ASSETID>
                </xsl:for-each>
                <xsl:for-each select=""ns0:ASSETNUM"">
                  <ns0:ASSETNUM>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:ASSETNUM>
                </xsl:for-each>
                <xsl:for-each select=""ns0:ASSETTAG"">
                  <ns0:ASSETTAG>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:ASSETTAG>
                </xsl:for-each>
                <xsl:for-each select=""ns0:ASSETTYPE"">
                  <ns0:ASSETTYPE>
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
                  </ns0:ASSETTYPE>
                </xsl:for-each>
                <xsl:for-each select=""ns0:ASSETUID"">
                  <ns0:ASSETUID>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:ASSETUID>
                </xsl:for-each>
                <xsl:for-each select=""ns0:AUTOWOGEN"">
                  <ns0:AUTOWOGEN>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:AUTOWOGEN>
                </xsl:for-each>
                <xsl:for-each select=""ns0:BINNUM"">
                  <ns0:BINNUM>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:BINNUM>
                </xsl:for-each>
                <xsl:for-each select=""ns0:BUDGETCOST"">
                  <ns0:BUDGETCOST>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:BUDGETCOST>
                </xsl:for-each>
                <xsl:for-each select=""ns0:CALNUM"">
                  <ns0:CALNUM>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:CALNUM>
                </xsl:for-each>
                <xsl:for-each select=""ns0:CHANGEBY"">
                  <ns0:CHANGEBY>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:CHANGEBY>
                </xsl:for-each>
                <xsl:for-each select=""ns0:CHANGEDATE"">
                  <ns0:CHANGEDATE>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:CHANGEDATE>
                </xsl:for-each>
                <xsl:for-each select=""ns0:CHILDREN"">
                  <ns0:CHILDREN>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:CHILDREN>
                </xsl:for-each>
                <xsl:for-each select=""ns0:CLASSSTRUCTUREID"">
                  <ns0:CLASSSTRUCTUREID>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:CLASSSTRUCTUREID>
                </xsl:for-each>
                <xsl:for-each select=""ns0:CONDITIONCODE"">
                  <ns0:CONDITIONCODE>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:CONDITIONCODE>
                </xsl:for-each>
                <xsl:for-each select=""ns0:DEFAULTREPFAC"">
                  <ns0:DEFAULTREPFAC>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:DEFAULTREPFAC>
                </xsl:for-each>
                <xsl:for-each select=""ns0:DEFAULTREPFACSITEID"">
                  <ns0:DEFAULTREPFACSITEID>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:DEFAULTREPFACSITEID>
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
                <xsl:for-each select=""ns0:DIRECTION"">
                  <ns0:DIRECTION>
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
                  </ns0:DIRECTION>
                </xsl:for-each>
                <xsl:for-each select=""ns0:DISABLED"">
                  <ns0:DISABLED>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:DISABLED>
                </xsl:for-each>
                <xsl:for-each select=""ns0:ENDDESCRIPTION"">
                  <ns0:ENDDESCRIPTION>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:ENDDESCRIPTION>
                </xsl:for-each>
                <xsl:for-each select=""ns0:ENDMEASURE"">
                  <ns0:ENDMEASURE>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:ENDMEASURE>
                </xsl:for-each>
                <xsl:for-each select=""ns0:EQ1"">
                  <ns0:EQ1>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:EQ1>
                </xsl:for-each>
                <xsl:for-each select=""ns0:EQ10"">
                  <ns0:EQ10>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:EQ10>
                </xsl:for-each>
                <xsl:for-each select=""ns0:EQ11"">
                  <ns0:EQ11>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:EQ11>
                </xsl:for-each>
                <xsl:for-each select=""ns0:EQ12"">
                  <ns0:EQ12>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:EQ12>
                </xsl:for-each>
                <xsl:for-each select=""ns0:EQ2"">
                  <ns0:EQ2>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:EQ2>
                </xsl:for-each>
                <xsl:for-each select=""ns0:EQ23"">
                  <ns0:EQ23>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:EQ23>
                </xsl:for-each>
                <xsl:for-each select=""ns0:EQ24"">
                  <ns0:EQ24>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:EQ24>
                </xsl:for-each>
                <xsl:for-each select=""ns0:EQ3"">
                  <ns0:EQ3>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:EQ3>
                </xsl:for-each>
                <xsl:for-each select=""ns0:EQ4"">
                  <ns0:EQ4>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:EQ4>
                </xsl:for-each>
                <xsl:for-each select=""ns0:EQ5"">
                  <ns0:EQ5>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:EQ5>
                </xsl:for-each>
                <xsl:for-each select=""ns0:EQ6"">
                  <ns0:EQ6>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:EQ6>
                </xsl:for-each>
                <xsl:for-each select=""ns0:EQ7"">
                  <ns0:EQ7>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:EQ7>
                </xsl:for-each>
                <xsl:for-each select=""ns0:EQ8"">
                  <ns0:EQ8>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:EQ8>
                </xsl:for-each>
                <xsl:for-each select=""ns0:EQ9"">
                  <ns0:EQ9>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:EQ9>
                </xsl:for-each>
                <xsl:for-each select=""ns0:EXTERNALREFID"">
                  <ns0:EXTERNALREFID>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:EXTERNALREFID>
                </xsl:for-each>
                <xsl:for-each select=""ns0:FAILURECODE"">
                  <ns0:FAILURECODE>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:FAILURECODE>
                </xsl:for-each>
                <xsl:for-each select=""ns0:GLACCOUNT"">
                  <ns0:GLACCOUNT>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:if test=""ns0:VALUE"">
                      <ns0:VALUE>
                        <xsl:value-of select=""ns0:VALUE/text()"" />
                      </ns0:VALUE>
                    </xsl:if>
                    <xsl:for-each select=""ns0:GLCOMP"">
                      <ns0:GLCOMP>
                        <xsl:attribute name=""glorder"">
                          <xsl:value-of select=""@glorder"" />
                        </xsl:attribute>
                        <xsl:value-of select=""./text()"" />
                      </ns0:GLCOMP>
                    </xsl:for-each>
                    <xsl:value-of select=""./text()"" />
                  </ns0:GLACCOUNT>
                </xsl:for-each>
                <xsl:for-each select=""ns0:GROUPNAME"">
                  <ns0:GROUPNAME>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:GROUPNAME>
                </xsl:for-each>
                <xsl:for-each select=""ns0:INSTALLDATE"">
                  <ns0:INSTALLDATE>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:INSTALLDATE>
                </xsl:for-each>
                <xsl:for-each select=""ns0:INVCOST"">
                  <ns0:INVCOST>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:INVCOST>
                </xsl:for-each>
                <xsl:for-each select=""ns0:ISCALIBRATION"">
                  <ns0:ISCALIBRATION>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:ISCALIBRATION>
                </xsl:for-each>
                <xsl:for-each select=""ns0:ISLINEAR"">
                  <ns0:ISLINEAR>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:ISLINEAR>
                </xsl:for-each>
                <xsl:for-each select=""ns0:ISRUNNING"">
                  <ns0:ISRUNNING>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:ISRUNNING>
                </xsl:for-each>
                <xsl:for-each select=""ns0:ITEMNUM"">
                  <ns0:ITEMNUM>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:ITEMNUM>
                </xsl:for-each>
                <xsl:for-each select=""ns0:ITEMSETID"">
                  <ns0:ITEMSETID>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:ITEMSETID>
                </xsl:for-each>
                <xsl:for-each select=""ns0:ITEMTYPE"">
                  <ns0:ITEMTYPE>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:ITEMTYPE>
                </xsl:for-each>
                <xsl:for-each select=""ns0:LOCATION"">
                  <ns0:LOCATION>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:LOCATION>
                </xsl:for-each>
                <xsl:for-each select=""ns0:LRM"">
                  <ns0:LRM>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:LRM>
                </xsl:for-each>
                <xsl:for-each select=""ns0:MAINTHIERCHY"">
                  <ns0:MAINTHIERCHY>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:MAINTHIERCHY>
                </xsl:for-each>
                <xsl:for-each select=""ns0:MANUFACTURER"">
                  <ns0:MANUFACTURER>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:MANUFACTURER>
                </xsl:for-each>
                <xsl:for-each select=""ns0:MOVED"">
                  <ns0:MOVED>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:MOVED>
                </xsl:for-each>
                <xsl:for-each select=""ns0:MTFMASSCOND"">
                  <ns0:MTFMASSCOND>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:MTFMASSCOND>
                </xsl:for-each>
                <xsl:for-each select=""ns0:MTFMASSTLOCAL"">
                  <ns0:MTFMASSTLOCAL>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:MTFMASSTLOCAL>
                </xsl:for-each>
                <xsl:for-each select=""ns0:MTFMASSTLVL"">
                  <ns0:MTFMASSTLVL>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:MTFMASSTLVL>
                </xsl:for-each>
                <xsl:for-each select=""ns0:MTFMASSTPOS"">
                  <ns0:MTFMASSTPOS>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:MTFMASSTPOS>
                </xsl:for-each>
                <xsl:for-each select=""ns0:MTFMCLIENTREF"">
                  <ns0:MTFMCLIENTREF>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:MTFMCLIENTREF>
                </xsl:for-each>
                <xsl:for-each select=""ns0:MTFMSOURCESYS"">
                  <ns0:MTFMSOURCESYS>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:MTFMSOURCESYS>
                </xsl:for-each>
                <xsl:for-each select=""ns0:MTFMSRCNO"">
                  <ns0:MTFMSRCNO>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:MTFMSRCNO>
                </xsl:for-each>
                <xsl:for-each select=""ns0:ORGID"">
                  <ns0:ORGID>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:ORGID>
                </xsl:for-each>
                <xsl:for-each select=""ns0:OWNERSYSID"">
                  <ns0:OWNERSYSID>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:OWNERSYSID>
                </xsl:for-each>
                <xsl:for-each select=""ns0:PARENT"">
                  <ns0:PARENT>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:PARENT>
                </xsl:for-each>
                <xsl:for-each select=""ns0:PLUSCASSETDEPT"">
                  <ns0:PLUSCASSETDEPT>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:PLUSCASSETDEPT>
                </xsl:for-each>
                <xsl:for-each select=""ns0:PLUSCCLASS"">
                  <ns0:PLUSCCLASS>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:PLUSCCLASS>
                </xsl:for-each>
                <xsl:for-each select=""ns0:PLUSCDUEDATE"">
                  <ns0:PLUSCDUEDATE>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:PLUSCDUEDATE>
                </xsl:for-each>
                <xsl:for-each select=""ns0:PLUSCISCONDESC"">
                  <ns0:PLUSCISCONDESC>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:PLUSCISCONDESC>
                </xsl:for-each>
                <xsl:for-each select=""ns0:PLUSCISCONTAM"">
                  <ns0:PLUSCISCONTAM>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:PLUSCISCONTAM>
                </xsl:for-each>
                <xsl:for-each select=""ns0:PLUSCISINHOUSECAL"">
                  <ns0:PLUSCISINHOUSECAL>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:PLUSCISINHOUSECAL>
                </xsl:for-each>
                <xsl:for-each select=""ns0:PLUSCISMTE"">
                  <ns0:PLUSCISMTE>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:PLUSCISMTE>
                </xsl:for-each>
                <xsl:for-each select=""ns0:PLUSCISMTECLASS"">
                  <ns0:PLUSCISMTECLASS>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:PLUSCISMTECLASS>
                </xsl:for-each>
                <xsl:for-each select=""ns0:PLUSCLOOPNUM"">
                  <ns0:PLUSCLOOPNUM>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:PLUSCLOOPNUM>
                </xsl:for-each>
                <xsl:for-each select=""ns0:PLUSCLPLOC"">
                  <ns0:PLUSCLPLOC>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:PLUSCLPLOC>
                </xsl:for-each>
                <xsl:for-each select=""ns0:PLUSCMODELNUM"">
                  <ns0:PLUSCMODELNUM>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:PLUSCMODELNUM>
                </xsl:for-each>
                <xsl:for-each select=""ns0:PLUSCOPRGEEU"">
                  <ns0:PLUSCOPRGEEU>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:PLUSCOPRGEEU>
                </xsl:for-each>
                <xsl:for-each select=""ns0:PLUSCOPRGEFROM"">
                  <ns0:PLUSCOPRGEFROM>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:PLUSCOPRGEFROM>
                </xsl:for-each>
                <xsl:for-each select=""ns0:PLUSCOPRGETO"">
                  <ns0:PLUSCOPRGETO>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:PLUSCOPRGETO>
                </xsl:for-each>
                <xsl:for-each select=""ns0:PLUSCPHYLOC"">
                  <ns0:PLUSCPHYLOC>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:PLUSCPHYLOC>
                </xsl:for-each>
                <xsl:for-each select=""ns0:PLUSCPMEXTDATE"">
                  <ns0:PLUSCPMEXTDATE>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:PLUSCPMEXTDATE>
                </xsl:for-each>
                <xsl:for-each select=""ns0:PLUSCSOLUTION"">
                  <ns0:PLUSCSOLUTION>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:PLUSCSOLUTION>
                </xsl:for-each>
                <xsl:for-each select=""ns0:PLUSCSUMDIR"">
                  <ns0:PLUSCSUMDIR>
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
                  </ns0:PLUSCSUMDIR>
                </xsl:for-each>
                <xsl:for-each select=""ns0:PLUSCSUMEU"">
                  <ns0:PLUSCSUMEU>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:PLUSCSUMEU>
                </xsl:for-each>
                <xsl:for-each select=""ns0:PLUSCSUMREAD"">
                  <ns0:PLUSCSUMREAD>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:PLUSCSUMREAD>
                </xsl:for-each>
                <xsl:for-each select=""ns0:PLUSCSUMSPAN"">
                  <ns0:PLUSCSUMSPAN>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:PLUSCSUMSPAN>
                </xsl:for-each>
                <xsl:for-each select=""ns0:PLUSCSUMURV"">
                  <ns0:PLUSCSUMURV>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:PLUSCSUMURV>
                </xsl:for-each>
                <xsl:for-each select=""ns0:PLUSCVENDOR"">
                  <ns0:PLUSCVENDOR>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:PLUSCVENDOR>
                </xsl:for-each>
                <xsl:for-each select=""ns0:PRIORITY"">
                  <ns0:PRIORITY>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:PRIORITY>
                </xsl:for-each>
                <xsl:for-each select=""ns0:PURCHASEPRICE"">
                  <ns0:PURCHASEPRICE>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:PURCHASEPRICE>
                </xsl:for-each>
                <xsl:for-each select=""ns0:REPLACECOST"">
                  <ns0:REPLACECOST>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:REPLACECOST>
                </xsl:for-each>
                <xsl:for-each select=""ns0:RETURNEDTOVENDOR"">
                  <ns0:RETURNEDTOVENDOR>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:RETURNEDTOVENDOR>
                </xsl:for-each>
                <xsl:for-each select=""ns0:ROTSUSPACCT"">
                  <ns0:ROTSUSPACCT>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:if test=""ns0:VALUE"">
                      <ns0:VALUE>
                        <xsl:value-of select=""ns0:VALUE/text()"" />
                      </ns0:VALUE>
                    </xsl:if>
                    <xsl:for-each select=""ns0:GLCOMP"">
                      <ns0:GLCOMP>
                        <xsl:attribute name=""glorder"">
                          <xsl:value-of select=""@glorder"" />
                        </xsl:attribute>
                        <xsl:value-of select=""./text()"" />
                      </ns0:GLCOMP>
                    </xsl:for-each>
                    <xsl:value-of select=""./text()"" />
                  </ns0:ROTSUSPACCT>
                </xsl:for-each>
                <xsl:for-each select=""ns0:SENDERSYSID"">
                  <ns0:SENDERSYSID>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:SENDERSYSID>
                </xsl:for-each>
                <xsl:for-each select=""ns0:SERIALNUM"">
                  <ns0:SERIALNUM>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:SERIALNUM>
                </xsl:for-each>
                <xsl:for-each select=""ns0:SHIFTNUM"">
                  <ns0:SHIFTNUM>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:SHIFTNUM>
                </xsl:for-each>
                <xsl:for-each select=""ns0:SOURCESYSID"">
                  <ns0:SOURCESYSID>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:SOURCESYSID>
                </xsl:for-each>
                <xsl:for-each select=""ns0:STARTDESCRIPTION"">
                  <ns0:STARTDESCRIPTION>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:STARTDESCRIPTION>
                </xsl:for-each>
                <xsl:for-each select=""ns0:STARTMEASURE"">
                  <ns0:STARTMEASURE>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:STARTMEASURE>
                </xsl:for-each>
                <xsl:for-each select=""ns0:STATUS"">
                  <ns0:STATUS>
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
                  </ns0:STATUS>
                </xsl:for-each>
                <xsl:for-each select=""ns0:STATUSDATE"">
                  <ns0:STATUSDATE>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:STATUSDATE>
                </xsl:for-each>
                <xsl:for-each select=""ns0:TEMPLATEID"">
                  <ns0:TEMPLATEID>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:TEMPLATEID>
                </xsl:for-each>
                <xsl:for-each select=""ns0:TLOAMHASH"">
                  <ns0:TLOAMHASH>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:TLOAMHASH>
                </xsl:for-each>
                <xsl:for-each select=""ns0:TLOAMPARTITION"">
                  <ns0:TLOAMPARTITION>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:TLOAMPARTITION>
                </xsl:for-each>
                <xsl:for-each select=""ns0:TOOLCONTROLACCOUNT"">
                  <ns0:TOOLCONTROLACCOUNT>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:if test=""ns0:VALUE"">
                      <ns0:VALUE>
                        <xsl:value-of select=""ns0:VALUE/text()"" />
                      </ns0:VALUE>
                    </xsl:if>
                    <xsl:for-each select=""ns0:GLCOMP"">
                      <ns0:GLCOMP>
                        <xsl:attribute name=""glorder"">
                          <xsl:value-of select=""@glorder"" />
                        </xsl:attribute>
                        <xsl:value-of select=""./text()"" />
                      </ns0:GLCOMP>
                    </xsl:for-each>
                    <xsl:value-of select=""./text()"" />
                  </ns0:TOOLCONTROLACCOUNT>
                </xsl:for-each>
                <xsl:for-each select=""ns0:TOOLRATE"">
                  <ns0:TOOLRATE>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:TOOLRATE>
                </xsl:for-each>
                <xsl:for-each select=""ns0:TOTALCOST"">
                  <ns0:TOTALCOST>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:TOTALCOST>
                </xsl:for-each>
                <xsl:for-each select=""ns0:TOTDOWNTIME"">
                  <ns0:TOTDOWNTIME>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:TOTDOWNTIME>
                </xsl:for-each>
                <xsl:for-each select=""ns0:TOTUNCHARGEDCOST"">
                  <ns0:TOTUNCHARGEDCOST>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:TOTUNCHARGEDCOST>
                </xsl:for-each>
                <xsl:for-each select=""ns0:UNCHARGEDCOST"">
                  <ns0:UNCHARGEDCOST>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:UNCHARGEDCOST>
                </xsl:for-each>
                <xsl:for-each select=""ns0:USAGE"">
                  <ns0:USAGE>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:USAGE>
                </xsl:for-each>
                <xsl:for-each select=""ns0:VENDOR"">
                  <ns0:VENDOR>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:VENDOR>
                </xsl:for-each>
                <xsl:for-each select=""ns0:WARRANTYEXPDATE"">
                  <ns0:WARRANTYEXPDATE>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:WARRANTYEXPDATE>
                </xsl:for-each>
                <xsl:for-each select=""ns0:YTDCOST"">
                  <ns0:YTDCOST>
                    <xsl:if test=""@changed"">
                      <xsl:attribute name=""changed"">
                        <xsl:value-of select=""@changed"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </ns0:YTDCOST>
                </xsl:for-each>
                <xsl:value-of select=""./text()"" />
              </ns0:ASSET>
            </xsl:for-each>
            <xsl:value-of select=""./text()"" />
          </ns0:WORKORDER>
        </xsl:for-each>
        <xsl:value-of select=""ns0:MTFMWODETAILSet/text()"" />
      </ns0:MTFMWODETAILSet>
    </ns0:PublishMTFMWODETAIL>
  </xsl:template>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp""><![CDATA[
public bool LogicalEq(string val1, string val2)
{
	bool ret = false;
	double d1 = 0;
	double d2 = 0;
	if (IsNumeric(val1, ref d1) && IsNumeric(val2, ref d2))
	{
		ret = d1 == d2;
	}
	else
	{
		ret = String.Compare(val1, val2, StringComparison.Ordinal) == 0;
	}
	return ret;
}


public bool LogicalNot(string val)
{
	return !ValToBool(val);
}


public bool LogicalAnd(string param0, string param1)
{
	return ValToBool(param0) && ValToBool(param1);
	return false;
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

public bool ValToBool(string val)
{
	if (val != null)
	{
		if (string.Compare(val, bool.TrueString, StringComparison.OrdinalIgnoreCase) == 0)
		{
			return true;
		}
		if (string.Compare(val, bool.FalseString, StringComparison.OrdinalIgnoreCase) == 0)
		{
			return false;
		}
		val = val.Trim();
		if (string.Compare(val, bool.TrueString, StringComparison.OrdinalIgnoreCase) == 0)
		{
			return true;
		}
		if (string.Compare(val, bool.FalseString, StringComparison.OrdinalIgnoreCase) == 0)
		{
			return false;
		}
		double d = 0;
		if (IsNumeric(val, ref d))
		{
			return (d > 0);
		}
	}
	return false;
}


]]></msxsl:script>
</xsl:stylesheet>";
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"MFM.Lbg.Schemas.MTFMWODETAILService+PublishMTFMWODETAIL";
        
        private const global::MFM.Lbg.Schemas.MTFMWODETAILService.PublishMTFMWODETAIL _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"MFM.Lbg.Schemas.MTFMWODETAILService+PublishMTFMWODETAIL";
        
        private const global::MFM.Lbg.Schemas.MTFMWODETAILService.PublishMTFMWODETAIL _trgSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"MFM.Lbg.Schemas.MTFMWODETAILService+PublishMTFMWODETAIL";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"MFM.Lbg.Schemas.MTFMWODETAILService+PublishMTFMWODETAIL";
                return _TrgSchemas;
            }
        }
    }
}
