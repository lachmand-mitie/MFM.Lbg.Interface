namespace MFM.Lbg.Maps {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"MFM.Lbg.Schemas.biz_Get_Questions_TypedProcedure_dbo+biz_Get_QuestionsResponse", typeof(global::MFM.Lbg.Schemas.biz_Get_Questions_TypedProcedure_dbo.biz_Get_QuestionsResponse))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"MFM.SharedResources.MSurvey", typeof(global::MFM.SharedResources.MSurvey))]
    public sealed class m_To_SurveyNode : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 s1 userCSharp"" version=""1.0"" xmlns:ns1=""http://MFMSharedResources/Types/Helpdesk/v1/MSurvey"" xmlns:s0=""http://schemas.microsoft.com/Sql/2008/05/ProceduresResultSets/dbo/biz_Get_Questions"" xmlns:ns0=""http://MFMSharedResources/Types/Helpdesk/v1/MSurveySet"" xmlns:s1=""http://schemas.microsoft.com/Sql/2008/05/TypedProcedures/dbo"" xmlns:ns2=""http://MFMSharedResources/Types/Helpdesk/v1/MSurveyQuestion"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s1:biz_Get_QuestionsResponse"" />
  </xsl:template>
  <xsl:template match=""/s1:biz_Get_QuestionsResponse"">
    <xsl:variable name=""var:v1"" select=""userCSharp:StringConcat(&quot;1&quot;)"" />
    <xsl:variable name=""var:v2"" select=""s1:StoredProcedureResultSet0/s0:StoredProcedureResultSet0[number($var:v1)]/s0:Case_CaseId/text()"" />
    <ns1:Survey>
      <ParentId>
        <xsl:value-of select=""$var:v2"" />
      </ParentId>
      <ns0:SurveySet>
        <SetName>
          <xsl:value-of select=""$var:v1"" />
        </SetName>
        <xsl:for-each select=""s1:StoredProcedureResultSet0"">
          <xsl:for-each select=""s0:StoredProcedureResultSet0"">
            <xsl:variable name=""var:v3"" select=""s0:ques_order"" />
            <xsl:variable name=""var:v4"" select=""s0:ques_text"" />
            <xsl:variable name=""var:v5"" select=""s0:resu_Text"" />
            <xsl:variable name=""var:v6"" select=""s0:resu_Value"" />
            <xsl:variable name=""var:v7"" select=""s0:resu_comment"" />
            <ns2:Question>
              <Order>
                <xsl:value-of select=""$var:v3"" />
              </Order>
              <QuestionAsked>
                <xsl:value-of select=""$var:v4"" />
              </QuestionAsked>
              <AnswerText>
                <xsl:value-of select=""$var:v5"" />
              </AnswerText>
              <AnswerValue>
                <xsl:value-of select=""$var:v6"" />
              </AnswerValue>
              <AnswerComment>
                <xsl:value-of select=""$var:v7"" />
              </AnswerComment>
            </ns2:Question>
          </xsl:for-each>
        </xsl:for-each>
      </ns0:SurveySet>
      <xsl:if test=""s1:StoredProcedureResultSet0"">
        <xsl:value-of select=""s1:StoredProcedureResultSet0/text()"" />
      </xsl:if>
    </ns1:Survey>
  </xsl:template>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp""><![CDATA[
public string StringConcat(string param0)
{
   return param0;
}



]]></msxsl:script>
</xsl:stylesheet>";
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"MFM.Lbg.Schemas.biz_Get_Questions_TypedProcedure_dbo+biz_Get_QuestionsResponse";
        
        private const global::MFM.Lbg.Schemas.biz_Get_Questions_TypedProcedure_dbo.biz_Get_QuestionsResponse _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"MFM.SharedResources.MSurvey";
        
        private const global::MFM.SharedResources.MSurvey _trgSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"MFM.Lbg.Schemas.biz_Get_Questions_TypedProcedure_dbo+biz_Get_QuestionsResponse";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"MFM.SharedResources.MSurvey";
                return _TrgSchemas;
            }
        }
    }
}
