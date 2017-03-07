namespace MFM.Lbg.Orcs {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"MFM.Lbg.Schemas.DistibutedWorkItems", typeof(global::MFM.Lbg.Schemas.DistibutedWorkItems))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"MFM.Lbg.Schemas.VFM_MPCITypedProcedure_dbo+biz_Beacon_Fetch_Property_MatchResponse", typeof(global::MFM.Lbg.Schemas.VFM_MPCITypedProcedure_dbo.biz_Beacon_Fetch_Property_MatchResponse))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"MFM.Lbg.Schemas.VFM_MPCITypedProcedure_dbo+biz_create_safe_visit", typeof(global::MFM.Lbg.Schemas.VFM_MPCITypedProcedure_dbo.biz_create_safe_visit))]
    public sealed class x_to_new_visit : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s10 s13 s3 s4 s5 s2 s6 s1 s0 s8 s9 s11 s12 s7 userCSharp userVB"" version=""1.0"" xmlns:s2=""http://MFMSharedResources/Types/Helpdesk/v1/MSurveySet"" xmlns:s13=""http://MFMSharedResources/Types/Helpdesk/v1/Address"" xmlns:s3=""http://MFMSharedResources/Types/Helpdesk/v1/IssuedWork"" xmlns:s4=""http://MFMSharedResources/Types/Helpdesk/v1/MSurveyQuestion"" xmlns:s5=""http://MFMSharedResources/Types/Helpdesk/v1/Customer"" xmlns:ns0=""http://schemas.microsoft.com/Sql/2008/05/TypedProcedures/dbo"" xmlns:ns3=""http://schemas.microsoft.com/Sql/2008/05/ProceduresResultSets/dbo/biz_Beacon_Fetch_Property_Match"" xmlns:s6=""http://MFMSharedResources/Types/Helpdesk/v1/Vendor"" xmlns:s1=""http://schemas.microsoft.com/BizTalk/2003/aggschema"" xmlns:s0=""http://MFM.Lbg.Schemas.DistibutedWorkItems"" xmlns:s8=""http://MFMSharedResources/Types/Helpdesk/v1/MSurvey"" xmlns:s9=""http://MFMSharedResources/Types/Helpdesk/v1/Workitem"" xmlns:s10=""http://MFMSharedResources/Types/Helpdesk/v1/Location"" xmlns:ns4=""http://schemas.microsoft.com/Sql/2008/05/ProceduresResultSets/dbo/biz_create_safe_visit"" xmlns:s11=""http://MFMSharedResources/Types/Helpdesk/v1/Service"" xmlns:s12=""http://MFMSharedResources/Types/Helpdesk/v1/MRouting"" xmlns:s7=""http://MFMSharedResources/Types/Helpdesk/v1/Person"" xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"" xmlns:userVB=""http://schemas.microsoft.com/BizTalk/2003/userVB"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s1:Root"" />
  </xsl:template>
  <xsl:template match=""/s1:Root"">
    <xsl:variable name=""var:v3"" select=""userCSharp:StringConcat(string(InputMessagePart_0/s0:DistributedWorkItems/s3:IssuedWork/s9:Workitem/s9:ContactFirstname/text()))"" />
    <xsl:variable name=""var:v4"" select=""userCSharp:LogicalEq(string(InputMessagePart_0/s0:DistributedWorkItems/s3:IssuedWork/s9:Workitem/s9:ContactPhone/text()) , &quot;&quot;)"" />
    <xsl:variable name=""var:v6"" select=""string(InputMessagePart_0/s0:DistributedWorkItems/s3:IssuedWork/s9:Workitem/s9:ContactPhone/text())"" />
    <xsl:variable name=""var:v7"" select=""userCSharp:LogicalNe($var:v6 , &quot;&quot;)"" />
    <xsl:variable name=""var:v8"" select=""string(InputMessagePart_0/s0:DistributedWorkItems/s3:IssuedWork/s9:Workitem/s9:ContactPhone/@xsi:nil) = 'true'"" />
    <xsl:variable name=""var:v9"" select=""userCSharp:LogicalNot(string($var:v8))"" />
    <xsl:variable name=""var:v10"" select=""userCSharp:LogicalAnd(string($var:v7) , string($var:v9))"" />
    <xsl:variable name=""var:v13"" select=""userCSharp:LogicalEq(string(InputMessagePart_0/s0:DistributedWorkItems/s3:IssuedWork/s9:Workitem/s9:Stage/text()) , &quot;Allocated&quot;)"" />
    <xsl:variable name=""var:v14"" select=""userCSharp:LogicalEq(string(InputMessagePart_0/s0:DistributedWorkItems/s3:IssuedWork/s9:Workitem/s9:WorkType/text()) , &quot;RW&quot;)"" />
    <xsl:variable name=""var:v15"" select=""userCSharp:LogicalAnd(string($var:v13) , string($var:v14))"" />
    <xsl:variable name=""var:v16"" select=""userCSharp:StringConcat(&quot;5&quot;)"" />
    <xsl:variable name=""var:v22"" select=""string(InputMessagePart_0/s0:DistributedWorkItems/s3:IssuedWork/s9:Workitem/s9:VendorCompleteBy/text())"" />
    <xsl:variable name=""var:v24"" select=""string(InputMessagePart_0/s0:DistributedWorkItems/s3:IssuedWork/s9:Workitem/s5:Customer/Name/text())"" />
    <xsl:variable name=""var:v25"" select=""string(InputMessagePart_0/s0:DistributedWorkItems/s3:IssuedWork/s9:Workitem/s5:Customer/Division/text())"" />
    <xsl:variable name=""var:v26"" select=""string(InputMessagePart_0/s0:DistributedWorkItems/s3:IssuedWork/s9:Workitem/s10:Location/s13:Address/siteAddress1/text())"" />
    <xsl:variable name=""var:v27"" select=""string(InputMessagePart_0/s0:DistributedWorkItems/s3:IssuedWork/s9:Workitem/s10:Location/s13:Address/siteAddress2/text())"" />
    <xsl:variable name=""var:v28"" select=""string(InputMessagePart_0/s0:DistributedWorkItems/s3:IssuedWork/s9:Workitem/s10:Location/s13:Address/siteAddress3/text())"" />
    <xsl:variable name=""var:v29"" select=""string(InputMessagePart_0/s0:DistributedWorkItems/s3:IssuedWork/s9:Workitem/s10:Location/s13:Address/siteCity/text())"" />
    <xsl:variable name=""var:v30"" select=""string(InputMessagePart_0/s0:DistributedWorkItems/s3:IssuedWork/s9:Workitem/s10:Location/s13:Address/sitePostCode/text())"" />
    <xsl:variable name=""var:v31"" select=""string(InputMessagePart_0/s0:DistributedWorkItems/s3:IssuedWork/s9:Workitem/s10:Location/linkMitiePropertyCode/text())"" />
    <xsl:variable name=""var:v32"" select=""string(InputMessagePart_0/s0:DistributedWorkItems/s3:IssuedWork/s9:Workitem/s10:Location/linkClientPropertyCode/text())"" />
    <xsl:variable name=""var:v33"" select=""string(InputMessagePart_0/s0:DistributedWorkItems/s3:IssuedWork/s9:Workitem/s11:BundleItem/BundleItemName/text())"" />
    <xsl:variable name=""var:v34"" select=""string(InputMessagePart_0/s0:DistributedWorkItems/s3:IssuedWork/s9:Workitem/s9:Service/s11:ServiceDetail/Detailname/text())"" />
    <xsl:variable name=""var:v35"" select=""string(InputMessagePart_0/s0:DistributedWorkItems/s3:IssuedWork/s9:Workitem/s9:ProblemNote/text())"" />
    <xsl:variable name=""var:v36"" select=""string(InputMessagePart_0/s0:DistributedWorkItems/s3:IssuedWork/s9:Workitem/s9:SLA/text())"" />
    <xsl:variable name=""var:v37"" select=""string(InputMessagePart_0/s0:DistributedWorkItems/s3:IssuedWork/s9:Workitem/s9:ContactMobile/text())"" />
    <xsl:variable name=""var:v39"" select=""userCSharp:StringConcat(string(InputMessagePart_0/s0:DistributedWorkItems/s3:IssuedWork/s9:Workitem/s9:Helpdesk/s9:CreatedByUser/s7:User/LogonName/text()) , &quot; (&quot; , &quot;VisionFM&quot; , &quot;)&quot;)"" />
    <xsl:variable name=""var:v40"" select=""userCSharp:DateCurrentDateTime()"" />
    <xsl:variable name=""var:v41"" select=""userCSharp:StringConcat(&quot;VisionFM&quot;)"" />
    <xsl:variable name=""var:v42"" select=""string(InputMessagePart_0/s0:DistributedWorkItems/s3:IssuedWork/s9:Workitem/s9:WorkType/text())"" />
    <xsl:variable name=""var:v43"" select=""userCSharp:LogicalEq($var:v42 , &quot;RW&quot;)"" />
    <xsl:variable name=""var:v44"" select=""userCSharp:StringConcat(&quot;True&quot;)"" />
    <xsl:variable name=""var:v46"" select=""userCSharp:StringLeft(string(InputMessagePart_0/s0:DistributedWorkItems/s3:IssuedWork/s9:Workitem/s9:TargetSystem/text()) , &quot;3&quot;)"" />
    <xsl:variable name=""var:v47"" select=""userCSharp:LogicalEq(string($var:v46) , &quot;MPC&quot;)"" />
    <xsl:variable name=""var:v48"" select=""userCSharp:LogicalAnd(string($var:v47) , string($var:v43))"" />
    <xsl:variable name=""var:v56"" select=""userCSharp:StringConcat(&quot;False&quot;)"" />
    <ns0:biz_create_safe_visit>
      <xsl:if test=""InputMessagePart_1/ns0:biz_Beacon_Fetch_Property_MatchResponse/ns0:StoredProcedureResultSet0/ns3:StoredProcedureResultSet0/ns3:cardnumber"">
        <xsl:variable name=""var:v1"" select=""string(InputMessagePart_1/ns0:biz_Beacon_Fetch_Property_MatchResponse/ns0:StoredProcedureResultSet0/ns3:StoredProcedureResultSet0/ns3:cardnumber/@xsi:nil) = 'true'"" />
        <xsl:if test=""string($var:v1)='true'"">
          <ns0:CardNumber>
            <xsl:attribute name=""xsi:nil"">
              <xsl:value-of select=""'true'"" />
            </xsl:attribute>
          </ns0:CardNumber>
        </xsl:if>
        <xsl:if test=""string($var:v1)='false'"">
          <ns0:CardNumber>
            <xsl:value-of select=""InputMessagePart_1/ns0:biz_Beacon_Fetch_Property_MatchResponse/ns0:StoredProcedureResultSet0/ns3:StoredProcedureResultSet0/ns3:cardnumber/text()"" />
          </ns0:CardNumber>
        </xsl:if>
      </xsl:if>
      <xsl:if test=""InputMessagePart_0/s0:DistributedWorkItems/s3:IssuedWork/s9:Workitem/s9:OpenedDate"">
        <xsl:variable name=""var:v2"" select=""string(InputMessagePart_0/s0:DistributedWorkItems/s3:IssuedWork/s9:Workitem/s9:OpenedDate/@xsi:nil) = 'true'"" />
        <xsl:if test=""string($var:v2)='true'"">
          <ns0:DateCalledIn>
            <xsl:attribute name=""xsi:nil"">
              <xsl:value-of select=""'true'"" />
            </xsl:attribute>
          </ns0:DateCalledIn>
        </xsl:if>
        <xsl:if test=""string($var:v2)='false'"">
          <ns0:DateCalledIn>
            <xsl:value-of select=""InputMessagePart_0/s0:DistributedWorkItems/s3:IssuedWork/s9:Workitem/s9:OpenedDate/text()"" />
          </ns0:DateCalledIn>
        </xsl:if>
      </xsl:if>
      <xsl:if test=""InputMessagePart_0/s0:DistributedWorkItems/s3:IssuedWork/s9:Workitem/s9:VendorAttendBy"">
        <ns0:DateConfirmed>
          <xsl:value-of select=""InputMessagePart_0/s0:DistributedWorkItems/s3:IssuedWork/s9:Workitem/s9:VendorAttendBy/text()"" />
        </ns0:DateConfirmed>
      </xsl:if>
      <ns0:CalledInBy>
        <xsl:value-of select=""$var:v3"" />
      </ns0:CalledInBy>
      <xsl:if test=""string($var:v4)='true'"">
        <xsl:variable name=""var:v5"" select=""InputMessagePart_0/s0:DistributedWorkItems/s3:IssuedWork/s9:Workitem/s9:ContactMobile/text()"" />
        <ns0:CalledInTelephone>
          <xsl:value-of select=""$var:v5"" />
        </ns0:CalledInTelephone>
      </xsl:if>
      <xsl:if test=""string($var:v10)='true'"">
        <xsl:variable name=""var:v11"" select=""InputMessagePart_0/s0:DistributedWorkItems/s3:IssuedWork/s9:Workitem/s9:ContactPhone/text()"" />
        <ns0:CalledInTelephone>
          <xsl:value-of select=""$var:v11"" />
        </ns0:CalledInTelephone>
      </xsl:if>
      <xsl:variable name=""var:v12"" select=""string(InputMessagePart_0/s0:DistributedWorkItems/s3:IssuedWork/s9:Workitem/s9:HelpdeskReference/@xsi:nil) = 'true'"" />
      <xsl:if test=""string($var:v12)='true'"">
        <ns0:CustomerReference>
          <xsl:attribute name=""xsi:nil"">
            <xsl:value-of select=""'true'"" />
          </xsl:attribute>
        </ns0:CustomerReference>
      </xsl:if>
      <xsl:if test=""string($var:v12)='false'"">
        <ns0:CustomerReference>
          <xsl:value-of select=""InputMessagePart_0/s0:DistributedWorkItems/s3:IssuedWork/s9:Workitem/s9:HelpdeskReference/text()"" />
        </ns0:CustomerReference>
      </xsl:if>
      <xsl:if test=""string($var:v15)='true'"">
        <xsl:variable name=""var:v17"" select=""string($var:v16)"" />
        <ns0:VisitTypeRef>
          <xsl:value-of select=""$var:v17"" />
        </ns0:VisitTypeRef>
      </xsl:if>
      <xsl:variable name=""var:v18"" select=""userVB:MyServiceCodeInt(string(InputMessagePart_0/s0:DistributedWorkItems/s3:IssuedWork/s9:Workitem/s9:Service/s11:ServiceDetail/statutory/text()))"" />
      <ns0:ServiceTypeRef>
        <xsl:value-of select=""$var:v18"" />
      </ns0:ServiceTypeRef>
      <xsl:if test=""InputMessagePart_1/ns0:biz_Beacon_Fetch_Property_MatchResponse/ns0:StoredProcedureResultSet0/ns3:StoredProcedureResultSet0/ns3:Technician"">
        <xsl:variable name=""var:v19"" select=""string(InputMessagePart_1/ns0:biz_Beacon_Fetch_Property_MatchResponse/ns0:StoredProcedureResultSet0/ns3:StoredProcedureResultSet0/ns3:Technician/@xsi:nil) = 'true'"" />
        <xsl:if test=""string($var:v19)='true'"">
          <ns0:TechnicianRef>
            <xsl:attribute name=""xsi:nil"">
              <xsl:value-of select=""'true'"" />
            </xsl:attribute>
          </ns0:TechnicianRef>
        </xsl:if>
        <xsl:if test=""string($var:v19)='false'"">
          <ns0:TechnicianRef>
            <xsl:value-of select=""InputMessagePart_1/ns0:biz_Beacon_Fetch_Property_MatchResponse/ns0:StoredProcedureResultSet0/ns3:StoredProcedureResultSet0/ns3:Technician/text()"" />
          </ns0:TechnicianRef>
        </xsl:if>
      </xsl:if>
      <xsl:variable name=""var:v20"" select=""userVB:FixMyDate(string(InputMessagePart_0/s0:DistributedWorkItems/s3:IssuedWork/s9:Workitem/s9:VendorCompleteBy/text()))"" />
      <xsl:variable name=""var:v21"" select=""userCSharp:StringConcat(string(InputMessagePart_0/s0:DistributedWorkItems/s3:IssuedWork/s9:Workitem/s5:Customer/Name/text()) , &quot; (&quot; , string(InputMessagePart_0/s0:DistributedWorkItems/s3:IssuedWork/s9:Workitem/s5:Customer/Division/text()) , &quot;), &quot; , string(InputMessagePart_0/s0:DistributedWorkItems/s3:IssuedWork/s9:Workitem/s10:Location/s13:Address/siteAddress1/text()) , &quot; &quot; , string(InputMessagePart_0/s0:DistributedWorkItems/s3:IssuedWork/s9:Workitem/s10:Location/s13:Address/siteAddress2/text()) , &quot; &quot; , string(InputMessagePart_0/s0:DistributedWorkItems/s3:IssuedWork/s9:Workitem/s10:Location/s13:Address/siteAddress3/text()) , &quot; &quot; , string(InputMessagePart_0/s0:DistributedWorkItems/s3:IssuedWork/s9:Workitem/s10:Location/s13:Address/siteCity/text()) , &quot; &quot; , string(InputMessagePart_0/s0:DistributedWorkItems/s3:IssuedWork/s9:Workitem/s10:Location/s13:Address/sitePostCode/text()) , &quot;, LBG Property: &quot; , string(InputMessagePart_0/s0:DistributedWorkItems/s3:IssuedWork/s9:Workitem/s10:Location/linkMitiePropertyCode/text()) , &quot;,Unit: &quot; , string(InputMessagePart_0/s0:DistributedWorkItems/s3:IssuedWork/s9:Workitem/s10:Location/linkClientPropertyCode/text()) , &quot;, Issue: &quot; , string(InputMessagePart_0/s0:DistributedWorkItems/s3:IssuedWork/s9:Workitem/s11:BundleItem/BundleItemName/text()) , &quot; &quot; , string(InputMessagePart_0/s0:DistributedWorkItems/s3:IssuedWork/s9:Workitem/s9:Service/s11:ServiceDetail/Detailname/text()) , &quot;, Comment: &quot; , string(InputMessagePart_0/s0:DistributedWorkItems/s3:IssuedWork/s9:Workitem/s9:ProblemNote/text()) , &quot;, Helpdesk SLA: &quot; , string(InputMessagePart_0/s0:DistributedWorkItems/s3:IssuedWork/s9:Workitem/s9:SLA/text()) , &quot;, To be Completed By:&quot; , string($var:v20) , &quot;, Mobile: &quot; , string(InputMessagePart_0/s0:DistributedWorkItems/s3:IssuedWork/s9:Workitem/s9:ContactMobile/text()) , &quot;, Telephone:&quot; , $var:v6)"" />
      <ns0:CallOutDetails>
        <xsl:value-of select=""$var:v21"" />
      </ns0:CallOutDetails>
      <xsl:variable name=""var:v23"" select=""userVB:FixMyDate($var:v22)"" />
      <xsl:variable name=""var:v38"" select=""userCSharp:StringConcat($var:v24 , &quot; (&quot; , $var:v25 , &quot;), &quot; , $var:v26 , &quot; &quot; , $var:v27 , &quot; &quot; , $var:v28 , &quot; &quot; , $var:v29 , &quot; &quot; , $var:v30 , &quot;, LBG Property: &quot; , $var:v31 , &quot;,Unit: &quot; , $var:v32 , &quot;, Issue: &quot; , $var:v33 , &quot; &quot; , $var:v34 , &quot;, Comment: &quot; , $var:v35 , &quot;, Helpdesk SLA: &quot; , $var:v36 , &quot;, To be Completed By:&quot; , string($var:v23) , &quot;, Mobile: &quot; , $var:v37 , &quot;, Telephone:&quot; , $var:v6)"" />
      <ns0:PostCallOutDetails>
        <xsl:value-of select=""$var:v38"" />
      </ns0:PostCallOutDetails>
      <ns0:InputBy>
        <xsl:value-of select=""$var:v39"" />
      </ns0:InputBy>
      <ns0:DateLastModified>
        <xsl:value-of select=""$var:v40"" />
      </ns0:DateLastModified>
      <ns0:LastModifiedBy>
        <xsl:value-of select=""$var:v41"" />
      </ns0:LastModifiedBy>
      <xsl:if test=""string($var:v43)='true'"">
        <xsl:variable name=""var:v45"" select=""string($var:v44)"" />
        <ns0:Callout>
          <xsl:value-of select=""$var:v45"" />
        </ns0:Callout>
      </xsl:if>
      <xsl:if test=""string($var:v48)='true'"">
        <xsl:variable name=""var:v49"" select=""string($var:v44)"" />
        <ns0:Chargeable>
          <xsl:value-of select=""$var:v49"" />
        </ns0:Chargeable>
      </xsl:if>
      <xsl:if test=""InputMessagePart_0/s0:DistributedWorkItems/s3:IssuedWork/s9:Workitem/s10:Location/s13:Address/sitePostCode"">
        <xsl:variable name=""var:v50"" select=""string(InputMessagePart_0/s0:DistributedWorkItems/s3:IssuedWork/s9:Workitem/s10:Location/s13:Address/sitePostCode/@xsi:nil) = 'true'"" />
        <xsl:if test=""string($var:v50)='true'"">
          <ns0:Postcode>
            <xsl:attribute name=""xsi:nil"">
              <xsl:value-of select=""'true'"" />
            </xsl:attribute>
          </ns0:Postcode>
        </xsl:if>
        <xsl:if test=""string($var:v50)='false'"">
          <ns0:Postcode>
            <xsl:value-of select=""InputMessagePart_0/s0:DistributedWorkItems/s3:IssuedWork/s9:Workitem/s10:Location/s13:Address/sitePostCode/text()"" />
          </ns0:Postcode>
        </xsl:if>
      </xsl:if>
      <xsl:if test=""InputMessagePart_0/s0:DistributedWorkItems/s3:IssuedWork/s9:Workitem/s10:Location/s13:Address/siteAddress1"">
        <ns0:Address1>
          <xsl:value-of select=""InputMessagePart_0/s0:DistributedWorkItems/s3:IssuedWork/s9:Workitem/s10:Location/s13:Address/siteAddress1/text()"" />
        </ns0:Address1>
      </xsl:if>
      <xsl:if test=""InputMessagePart_0/s0:DistributedWorkItems/s3:IssuedWork/s9:Workitem/s10:Location/s13:Address/siteAddress2"">
        <xsl:variable name=""var:v51"" select=""string(InputMessagePart_0/s0:DistributedWorkItems/s3:IssuedWork/s9:Workitem/s10:Location/s13:Address/siteAddress2/@xsi:nil) = 'true'"" />
        <xsl:if test=""string($var:v51)='true'"">
          <ns0:Address2>
            <xsl:attribute name=""xsi:nil"">
              <xsl:value-of select=""'true'"" />
            </xsl:attribute>
          </ns0:Address2>
        </xsl:if>
        <xsl:if test=""string($var:v51)='false'"">
          <ns0:Address2>
            <xsl:value-of select=""InputMessagePart_0/s0:DistributedWorkItems/s3:IssuedWork/s9:Workitem/s10:Location/s13:Address/siteAddress2/text()"" />
          </ns0:Address2>
        </xsl:if>
      </xsl:if>
      <xsl:if test=""InputMessagePart_0/s0:DistributedWorkItems/s3:IssuedWork/s9:Workitem/s10:Location/s13:Address/siteCity"">
        <xsl:variable name=""var:v52"" select=""string(InputMessagePart_0/s0:DistributedWorkItems/s3:IssuedWork/s9:Workitem/s10:Location/s13:Address/siteCity/@xsi:nil) = 'true'"" />
        <xsl:if test=""string($var:v52)='true'"">
          <ns0:Address3>
            <xsl:attribute name=""xsi:nil"">
              <xsl:value-of select=""'true'"" />
            </xsl:attribute>
          </ns0:Address3>
        </xsl:if>
        <xsl:if test=""string($var:v52)='false'"">
          <ns0:Address3>
            <xsl:value-of select=""InputMessagePart_0/s0:DistributedWorkItems/s3:IssuedWork/s9:Workitem/s10:Location/s13:Address/siteCity/text()"" />
          </ns0:Address3>
        </xsl:if>
      </xsl:if>
      <xsl:if test=""InputMessagePart_0/s0:DistributedWorkItems/s3:IssuedWork/s9:Workitem/s10:Location/s13:Address/siteSiteID"">
        <xsl:variable name=""var:v53"" select=""string(InputMessagePart_0/s0:DistributedWorkItems/s3:IssuedWork/s9:Workitem/s10:Location/s13:Address/siteSiteID/@xsi:nil) = 'true'"" />
        <xsl:if test=""string($var:v53)='true'"">
          <ns0:CustomerReference2>
            <xsl:attribute name=""xsi:nil"">
              <xsl:value-of select=""'true'"" />
            </xsl:attribute>
          </ns0:CustomerReference2>
        </xsl:if>
        <xsl:if test=""string($var:v53)='false'"">
          <ns0:CustomerReference2>
            <xsl:value-of select=""InputMessagePart_0/s0:DistributedWorkItems/s3:IssuedWork/s9:Workitem/s10:Location/s13:Address/siteSiteID/text()"" />
          </ns0:CustomerReference2>
        </xsl:if>
      </xsl:if>
      <xsl:variable name=""var:v54"" select=""userVB:FixMyDate($var:v22)"" />
      <xsl:variable name=""var:v55"" select=""userCSharp:StringConcat($var:v24 , &quot; (&quot; , $var:v25 , &quot;), &quot; , $var:v26 , &quot; &quot; , $var:v27 , &quot; &quot; , $var:v28 , &quot; &quot; , $var:v29 , &quot; &quot; , $var:v30 , &quot;, LBG Property: &quot; , $var:v31 , &quot;,Unit: &quot; , $var:v32 , &quot;, Issue: &quot; , $var:v33 , &quot; &quot; , $var:v34 , &quot;, Comment: &quot; , $var:v35 , &quot;, Helpdesk SLA: &quot; , $var:v36 , &quot;, To be Completed By:&quot; , string($var:v54) , &quot;, Mobile: &quot; , $var:v37 , &quot;, Telephone:&quot; , $var:v6)"" />
      <ns0:OriginalCalloutDetails>
        <xsl:value-of select=""$var:v55"" />
      </ns0:OriginalCalloutDetails>
      <xsl:if test=""string($var:v43)='true'"">
        <xsl:variable name=""var:v57"" select=""string($var:v56)"" />
        <ns0:Routine>
          <xsl:value-of select=""$var:v57"" />
        </ns0:Routine>
      </xsl:if>
    </ns0:biz_create_safe_visit>
  </xsl:template>
  <msxsl:script language=""VB"" implements-prefix=""userVB""><![CDATA[
Public Function MyServiceCodeInt(ByVal param1 As String) As String
	Return System.Convert.ToInt32(param1)
End Function


Public Function FixMyDate(ByVal param1 As String) As String
	Return param1.ToString()
End Function



]]></msxsl:script>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp""><![CDATA[
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


public bool LogicalAnd(string param0, string param1)
{
	return ValToBool(param0) && ValToBool(param1);
	return false;
}


public string StringConcat(string param0)
{
   return param0;
}


public bool LogicalNe(string val1, string val2)
{
	bool ret = false;
	double d1 = 0;
	double d2 = 0;
	if (IsNumeric(val1, ref d1) && IsNumeric(val2, ref d2))
	{
		ret = d1 != d2;
	}
	else
	{
		ret = String.Compare(val1, val2, StringComparison.Ordinal) != 0;
	}
	return ret;
}


public bool LogicalNot(string val)
{
	return !ValToBool(val);
}


public string StringLeft(string str, string count)
{
	string retval = """";
	double d = 0;
	if (str != null && IsNumeric(count, ref d))
	{
		int i = (int) d;
		if (i > 0)
		{ 
			if (i <= str.Length)
			{
				retval = str.Substring(0, i);
			}
			else
			{
				retval = str;
			}
		}
	}
	return retval;
}


public string StringConcat(string param0, string param1, string param2, string param3, string param4, string param5, string param6, string param7, string param8, string param9, string param10, string param11, string param12, string param13, string param14, string param15, string param16, string param17, string param18, string param19, string param20, string param21, string param22, string param23, string param24, string param25, string param26, string param27, string param28, string param29, string param30)
{
   return param0 + param1 + param2 + param3 + param4 + param5 + param6 + param7 + param8 + param9 + param10 + param11 + param12 + param13 + param14 + param15 + param16 + param17 + param18 + param19 + param20 + param21 + param22 + param23 + param24 + param25 + param26 + param27 + param28 + param29 + param30;
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
        
        private const string _strSrcSchemasList0 = @"MFM.Lbg.Schemas.DistibutedWorkItems";
        
        private const global::MFM.Lbg.Schemas.DistibutedWorkItems _srcSchemaTypeReference0 = null;
        
        private const string _strSrcSchemasList1 = @"MFM.Lbg.Schemas.VFM_MPCITypedProcedure_dbo+biz_Beacon_Fetch_Property_MatchResponse";
        
        private const global::MFM.Lbg.Schemas.VFM_MPCITypedProcedure_dbo.biz_Beacon_Fetch_Property_MatchResponse _srcSchemaTypeReference1 = null;
        
        private const string _strTrgSchemasList0 = @"MFM.Lbg.Schemas.VFM_MPCITypedProcedure_dbo+biz_create_safe_visit";
        
        private const global::MFM.Lbg.Schemas.VFM_MPCITypedProcedure_dbo.biz_create_safe_visit _trgSchemaTypeReference0 = null;
        
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
                string[] _SrcSchemas = new string [2];
                _SrcSchemas[0] = @"MFM.Lbg.Schemas.DistibutedWorkItems";
                _SrcSchemas[1] = @"MFM.Lbg.Schemas.VFM_MPCITypedProcedure_dbo+biz_Beacon_Fetch_Property_MatchResponse";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"MFM.Lbg.Schemas.VFM_MPCITypedProcedure_dbo+biz_create_safe_visit";
                return _TrgSchemas;
            }
        }
    }
}
