namespace MFM.Lbg.Maps {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"MFM.Lbg.Schemas.MFMWorkItemUpdate", typeof(global::MFM.Lbg.Schemas.MFMWorkItemUpdate))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"MFM.Lbg.Schemas.MFMWorkItemUpdate", typeof(global::MFM.Lbg.Schemas.MFMWorkItemUpdate))]
    public sealed class m_to_locationCheck : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var userCSharp ScriptNS0 ScriptNS1"" version=""1.0"" xmlns:ns0=""http://MFM.Lbg.Schemas.MFMWorkItemUpdate"" xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"" xmlns:ScriptNS0=""http://schemas.microsoft.com/BizTalk/2003/ScriptNS0"" xmlns:ScriptNS1=""http://schemas.microsoft.com/BizTalk/2003/ScriptNS1"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/ns0:MFMWorkItemUpdate"" />
  </xsl:template>
  <xsl:template match=""/ns0:MFMWorkItemUpdate"">
    <xsl:variable name=""var:v16"" select=""userCSharp:StringConcat(string(WI_LocationLevel3/text()) , &quot;-&quot; , string(WI_LocationLevel4/text()))"" />
    <ns0:MFMWorkItemUpdate>
      <xsl:variable name=""var:v1"" select=""string(SourceSystem/@xsi:nil) = 'true'"" />
      <xsl:if test=""string($var:v1)='true'"">
        <SourceSystem>
          <xsl:attribute name=""xsi:nil"">
            <xsl:value-of select=""'true'"" />
          </xsl:attribute>
        </SourceSystem>
      </xsl:if>
      <xsl:if test=""string($var:v1)='false'"">
        <SourceSystem>
          <xsl:value-of select=""SourceSystem/text()"" />
        </SourceSystem>
      </xsl:if>
      <xsl:variable name=""var:v2"" select=""string(SourceSystemMessageId/@xsi:nil) = 'true'"" />
      <xsl:if test=""string($var:v2)='true'"">
        <SourceSystemMessageId>
          <xsl:attribute name=""xsi:nil"">
            <xsl:value-of select=""'true'"" />
          </xsl:attribute>
        </SourceSystemMessageId>
      </xsl:if>
      <xsl:if test=""string($var:v2)='false'"">
        <SourceSystemMessageId>
          <xsl:value-of select=""SourceSystemMessageId/text()"" />
        </SourceSystemMessageId>
      </xsl:if>
      <xsl:variable name=""var:v3"" select=""string(SourceSystemMessageTs/@xsi:nil) = 'true'"" />
      <xsl:if test=""string($var:v3)='true'"">
        <SourceSystemMessageTs>
          <xsl:attribute name=""xsi:nil"">
            <xsl:value-of select=""'true'"" />
          </xsl:attribute>
        </SourceSystemMessageTs>
      </xsl:if>
      <xsl:if test=""string($var:v3)='false'"">
        <SourceSystemMessageTs>
          <xsl:value-of select=""SourceSystemMessageTs/text()"" />
        </SourceSystemMessageTs>
      </xsl:if>
      <xsl:variable name=""var:v4"" select=""string(BizTalkMessageId/@xsi:nil) = 'true'"" />
      <xsl:if test=""string($var:v4)='true'"">
        <BizTalkMessageId>
          <xsl:attribute name=""xsi:nil"">
            <xsl:value-of select=""'true'"" />
          </xsl:attribute>
        </BizTalkMessageId>
      </xsl:if>
      <xsl:if test=""string($var:v4)='false'"">
        <BizTalkMessageId>
          <xsl:value-of select=""BizTalkMessageId/text()"" />
        </BizTalkMessageId>
      </xsl:if>
      <xsl:variable name=""var:v5"" select=""string(BizTalkMessageTs/@xsi:nil) = 'true'"" />
      <xsl:if test=""string($var:v5)='true'"">
        <BizTalkMessageTs>
          <xsl:attribute name=""xsi:nil"">
            <xsl:value-of select=""'true'"" />
          </xsl:attribute>
        </BizTalkMessageTs>
      </xsl:if>
      <xsl:if test=""string($var:v5)='false'"">
        <BizTalkMessageTs>
          <xsl:value-of select=""BizTalkMessageTs/text()"" />
        </BizTalkMessageTs>
      </xsl:if>
      <xsl:variable name=""var:v6"" select=""string(WI_WorkType/@xsi:nil) = 'true'"" />
      <xsl:if test=""string($var:v6)='true'"">
        <WI_WorkType>
          <xsl:attribute name=""xsi:nil"">
            <xsl:value-of select=""'true'"" />
          </xsl:attribute>
        </WI_WorkType>
      </xsl:if>
      <xsl:if test=""string($var:v6)='false'"">
        <WI_WorkType>
          <xsl:value-of select=""WI_WorkType/text()"" />
        </WI_WorkType>
      </xsl:if>
      <xsl:variable name=""var:v7"" select=""string(WI_UpdateTs/@xsi:nil) = 'true'"" />
      <xsl:if test=""string($var:v7)='true'"">
        <WI_UpdateTs>
          <xsl:attribute name=""xsi:nil"">
            <xsl:value-of select=""'true'"" />
          </xsl:attribute>
        </WI_UpdateTs>
      </xsl:if>
      <xsl:if test=""string($var:v7)='false'"">
        <WI_UpdateTs>
          <xsl:value-of select=""WI_UpdateTs/text()"" />
        </WI_UpdateTs>
      </xsl:if>
      <xsl:variable name=""var:v8"" select=""string(WI_SourceRef/@xsi:nil) = 'true'"" />
      <xsl:if test=""string($var:v8)='true'"">
        <WI_SourceRef>
          <xsl:attribute name=""xsi:nil"">
            <xsl:value-of select=""'true'"" />
          </xsl:attribute>
        </WI_SourceRef>
      </xsl:if>
      <xsl:if test=""string($var:v8)='false'"">
        <WI_SourceRef>
          <xsl:value-of select=""WI_SourceRef/text()"" />
        </WI_SourceRef>
      </xsl:if>
      <xsl:variable name=""var:v9"" select=""string(WI_DestinationRef/@xsi:nil) = 'true'"" />
      <xsl:if test=""string($var:v9)='true'"">
        <WI_DestinationRef>
          <xsl:attribute name=""xsi:nil"">
            <xsl:value-of select=""'true'"" />
          </xsl:attribute>
        </WI_DestinationRef>
      </xsl:if>
      <xsl:if test=""string($var:v9)='false'"">
        <WI_DestinationRef>
          <xsl:value-of select=""WI_DestinationRef/text()"" />
        </WI_DestinationRef>
      </xsl:if>
      <xsl:if test=""WI_ServiceLevel1"">
        <xsl:variable name=""var:v10"" select=""string(WI_ServiceLevel1/@xsi:nil) = 'true'"" />
        <xsl:if test=""string($var:v10)='true'"">
          <WI_ServiceLevel1>
            <xsl:attribute name=""xsi:nil"">
              <xsl:value-of select=""'true'"" />
            </xsl:attribute>
          </WI_ServiceLevel1>
        </xsl:if>
        <xsl:if test=""string($var:v10)='false'"">
          <WI_ServiceLevel1>
            <xsl:value-of select=""WI_ServiceLevel1/text()"" />
          </WI_ServiceLevel1>
        </xsl:if>
      </xsl:if>
      <xsl:if test=""WI_ServiceLevel2"">
        <xsl:variable name=""var:v11"" select=""string(WI_ServiceLevel2/@xsi:nil) = 'true'"" />
        <xsl:if test=""string($var:v11)='true'"">
          <WI_ServiceLevel2>
            <xsl:attribute name=""xsi:nil"">
              <xsl:value-of select=""'true'"" />
            </xsl:attribute>
          </WI_ServiceLevel2>
        </xsl:if>
        <xsl:if test=""string($var:v11)='false'"">
          <WI_ServiceLevel2>
            <xsl:value-of select=""WI_ServiceLevel2/text()"" />
          </WI_ServiceLevel2>
        </xsl:if>
      </xsl:if>
      <xsl:if test=""WI_ServiceLevel3"">
        <xsl:variable name=""var:v12"" select=""string(WI_ServiceLevel3/@xsi:nil) = 'true'"" />
        <xsl:if test=""string($var:v12)='true'"">
          <WI_ServiceLevel3>
            <xsl:attribute name=""xsi:nil"">
              <xsl:value-of select=""'true'"" />
            </xsl:attribute>
          </WI_ServiceLevel3>
        </xsl:if>
        <xsl:if test=""string($var:v12)='false'"">
          <WI_ServiceLevel3>
            <xsl:value-of select=""WI_ServiceLevel3/text()"" />
          </WI_ServiceLevel3>
        </xsl:if>
      </xsl:if>
      <xsl:if test=""WI_AssetRef"">
        <xsl:variable name=""var:v13"" select=""string(WI_AssetRef/@xsi:nil) = 'true'"" />
        <xsl:if test=""string($var:v13)='true'"">
          <WI_AssetRef>
            <xsl:attribute name=""xsi:nil"">
              <xsl:value-of select=""'true'"" />
            </xsl:attribute>
          </WI_AssetRef>
        </xsl:if>
        <xsl:if test=""string($var:v13)='false'"">
          <WI_AssetRef>
            <xsl:value-of select=""WI_AssetRef/text()"" />
          </WI_AssetRef>
        </xsl:if>
      </xsl:if>
      <xsl:if test=""WI_LocationLevel1"">
        <xsl:variable name=""var:v14"" select=""string(WI_LocationLevel1/@xsi:nil) = 'true'"" />
        <xsl:if test=""string($var:v14)='true'"">
          <WI_LocationLevel1>
            <xsl:attribute name=""xsi:nil"">
              <xsl:value-of select=""'true'"" />
            </xsl:attribute>
          </WI_LocationLevel1>
        </xsl:if>
        <xsl:if test=""string($var:v14)='false'"">
          <WI_LocationLevel1>
            <xsl:value-of select=""WI_LocationLevel1/text()"" />
          </WI_LocationLevel1>
        </xsl:if>
      </xsl:if>
      <xsl:if test=""WI_LocationLevel2"">
        <xsl:variable name=""var:v15"" select=""string(WI_LocationLevel2/@xsi:nil) = 'true'"" />
        <xsl:if test=""string($var:v15)='true'"">
          <WI_LocationLevel2>
            <xsl:attribute name=""xsi:nil"">
              <xsl:value-of select=""'true'"" />
            </xsl:attribute>
          </WI_LocationLevel2>
        </xsl:if>
        <xsl:if test=""string($var:v15)='false'"">
          <WI_LocationLevel2>
            <xsl:value-of select=""WI_LocationLevel2/text()"" />
          </WI_LocationLevel2>
        </xsl:if>
      </xsl:if>
      <xsl:variable name=""var:v17"" select=""ScriptNS0:VisionFMLookupConnectionString()"" />
      <xsl:variable name=""var:v18"" select=""ScriptNS1:DBLookup(0 , string($var:v16) , string($var:v17) , &quot;[ops].[vMTFMAssetLocations]&quot; , &quot;Building&quot;)"" />
      <xsl:variable name=""var:v19"" select=""ScriptNS1:DBValueExtract(string($var:v18) , &quot;AdLi_AddressLinkId&quot;)"" />
      <xsl:variable name=""var:v20"" select=""userCSharp:LogicalIsNumeric(string($var:v19))"" />
      <xsl:if test=""string($var:v20)='true'"">
        <xsl:variable name=""var:v21"" select=""string(WI_LocationLevel3/text())"" />
        <xsl:variable name=""var:v22"" select=""string(WI_LocationLevel4/text())"" />
        <xsl:variable name=""var:v23"" select=""userCSharp:StringConcat($var:v21 , &quot;-&quot; , $var:v22)"" />
        <xsl:variable name=""var:v24"" select=""ScriptNS0:VisionFMLookupConnectionString()"" />
        <xsl:variable name=""var:v25"" select=""ScriptNS1:DBLookup(0 , string($var:v23) , string($var:v24) , &quot;[ops].[vMTFMAssetLocations]&quot; , &quot;Building&quot;)"" />
        <xsl:variable name=""var:v26"" select=""ScriptNS1:DBValueExtract(string($var:v25) , &quot;AdLi_AddressLinkId&quot;)"" />
        <WI_LocationLevel3>
          <xsl:value-of select=""$var:v26"" />
        </WI_LocationLevel3>
      </xsl:if>
      <xsl:variable name=""var:v27"" select=""userCSharp:LogicalIsNumeric(string($var:v19))"" />
      <xsl:variable name=""var:v28"" select=""userCSharp:LogicalNot(string($var:v27))"" />
      <xsl:if test=""string($var:v28)='true'"">
        <xsl:variable name=""var:v29"" select=""userCSharp:StringConcat(&quot;0&quot;)"" />
        <WI_LocationLevel3>
          <xsl:value-of select=""$var:v29"" />
        </WI_LocationLevel3>
      </xsl:if>
      <xsl:if test=""WI_Status"">
        <xsl:variable name=""var:v30"" select=""string(WI_Status/@xsi:nil) = 'true'"" />
        <xsl:if test=""string($var:v30)='true'"">
          <WI_Status>
            <xsl:attribute name=""xsi:nil"">
              <xsl:value-of select=""'true'"" />
            </xsl:attribute>
          </WI_Status>
        </xsl:if>
        <xsl:if test=""string($var:v30)='false'"">
          <WI_Status>
            <xsl:value-of select=""WI_Status/text()"" />
          </WI_Status>
        </xsl:if>
      </xsl:if>
      <xsl:if test=""WI_StatusChangeTS"">
        <xsl:variable name=""var:v31"" select=""string(WI_StatusChangeTS/@xsi:nil) = 'true'"" />
        <xsl:if test=""string($var:v31)='true'"">
          <WI_StatusChangeTS>
            <xsl:attribute name=""xsi:nil"">
              <xsl:value-of select=""'true'"" />
            </xsl:attribute>
          </WI_StatusChangeTS>
        </xsl:if>
        <xsl:if test=""string($var:v31)='false'"">
          <WI_StatusChangeTS>
            <xsl:value-of select=""WI_StatusChangeTS/text()"" />
          </WI_StatusChangeTS>
        </xsl:if>
      </xsl:if>
      <xsl:if test=""WI_StatusNote"">
        <xsl:variable name=""var:v32"" select=""string(WI_StatusNote/@xsi:nil) = 'true'"" />
        <xsl:if test=""string($var:v32)='true'"">
          <WI_StatusNote>
            <xsl:attribute name=""xsi:nil"">
              <xsl:value-of select=""'true'"" />
            </xsl:attribute>
          </WI_StatusNote>
        </xsl:if>
        <xsl:if test=""string($var:v32)='false'"">
          <WI_StatusNote>
            <xsl:value-of select=""WI_StatusNote/text()"" />
          </WI_StatusNote>
        </xsl:if>
      </xsl:if>
      <xsl:if test=""WI_Priority"">
        <xsl:variable name=""var:v33"" select=""string(WI_Priority/@xsi:nil) = 'true'"" />
        <xsl:if test=""string($var:v33)='true'"">
          <WI_Priority>
            <xsl:attribute name=""xsi:nil"">
              <xsl:value-of select=""'true'"" />
            </xsl:attribute>
          </WI_Priority>
        </xsl:if>
        <xsl:if test=""string($var:v33)='false'"">
          <WI_Priority>
            <xsl:value-of select=""WI_Priority/text()"" />
          </WI_Priority>
        </xsl:if>
      </xsl:if>
      <xsl:if test=""WI_KpiStartTs"">
        <xsl:variable name=""var:v34"" select=""string(WI_KpiStartTs/@xsi:nil) = 'true'"" />
        <xsl:if test=""string($var:v34)='true'"">
          <WI_KpiStartTs>
            <xsl:attribute name=""xsi:nil"">
              <xsl:value-of select=""'true'"" />
            </xsl:attribute>
          </WI_KpiStartTs>
        </xsl:if>
        <xsl:if test=""string($var:v34)='false'"">
          <WI_KpiStartTs>
            <xsl:value-of select=""WI_KpiStartTs/text()"" />
          </WI_KpiStartTs>
        </xsl:if>
      </xsl:if>
      <xsl:if test=""WI_KpiAttendTs"">
        <xsl:variable name=""var:v35"" select=""string(WI_KpiAttendTs/@xsi:nil) = 'true'"" />
        <xsl:if test=""string($var:v35)='true'"">
          <WI_KpiAttendTs>
            <xsl:attribute name=""xsi:nil"">
              <xsl:value-of select=""'true'"" />
            </xsl:attribute>
          </WI_KpiAttendTs>
        </xsl:if>
        <xsl:if test=""string($var:v35)='false'"">
          <WI_KpiAttendTs>
            <xsl:value-of select=""WI_KpiAttendTs/text()"" />
          </WI_KpiAttendTs>
        </xsl:if>
      </xsl:if>
      <xsl:if test=""WI_KpiCompleteTs"">
        <xsl:variable name=""var:v36"" select=""string(WI_KpiCompleteTs/@xsi:nil) = 'true'"" />
        <xsl:if test=""string($var:v36)='true'"">
          <WI_KpiCompleteTs>
            <xsl:attribute name=""xsi:nil"">
              <xsl:value-of select=""'true'"" />
            </xsl:attribute>
          </WI_KpiCompleteTs>
        </xsl:if>
        <xsl:if test=""string($var:v36)='false'"">
          <WI_KpiCompleteTs>
            <xsl:value-of select=""WI_KpiCompleteTs/text()"" />
          </WI_KpiCompleteTs>
        </xsl:if>
      </xsl:if>
      <xsl:if test=""WI_KpiConfirmTs"">
        <xsl:variable name=""var:v37"" select=""string(WI_KpiConfirmTs/@xsi:nil) = 'true'"" />
        <xsl:if test=""string($var:v37)='true'"">
          <WI_KpiConfirmTs>
            <xsl:attribute name=""xsi:nil"">
              <xsl:value-of select=""'true'"" />
            </xsl:attribute>
          </WI_KpiConfirmTs>
        </xsl:if>
        <xsl:if test=""string($var:v37)='false'"">
          <WI_KpiConfirmTs>
            <xsl:value-of select=""WI_KpiConfirmTs/text()"" />
          </WI_KpiConfirmTs>
        </xsl:if>
      </xsl:if>
      <xsl:if test=""WI_ActualStartTs"">
        <xsl:variable name=""var:v38"" select=""string(WI_ActualStartTs/@xsi:nil) = 'true'"" />
        <xsl:if test=""string($var:v38)='true'"">
          <WI_ActualStartTs>
            <xsl:attribute name=""xsi:nil"">
              <xsl:value-of select=""'true'"" />
            </xsl:attribute>
          </WI_ActualStartTs>
        </xsl:if>
        <xsl:if test=""string($var:v38)='false'"">
          <WI_ActualStartTs>
            <xsl:value-of select=""WI_ActualStartTs/text()"" />
          </WI_ActualStartTs>
        </xsl:if>
      </xsl:if>
      <xsl:if test=""WI_ActualAttendTs"">
        <xsl:variable name=""var:v39"" select=""string(WI_ActualAttendTs/@xsi:nil) = 'true'"" />
        <xsl:if test=""string($var:v39)='true'"">
          <WI_ActualAttendTs>
            <xsl:attribute name=""xsi:nil"">
              <xsl:value-of select=""'true'"" />
            </xsl:attribute>
          </WI_ActualAttendTs>
        </xsl:if>
        <xsl:if test=""string($var:v39)='false'"">
          <WI_ActualAttendTs>
            <xsl:value-of select=""WI_ActualAttendTs/text()"" />
          </WI_ActualAttendTs>
        </xsl:if>
      </xsl:if>
      <xsl:if test=""WI_ActualCompleteTs"">
        <xsl:variable name=""var:v40"" select=""string(WI_ActualCompleteTs/@xsi:nil) = 'true'"" />
        <xsl:if test=""string($var:v40)='true'"">
          <WI_ActualCompleteTs>
            <xsl:attribute name=""xsi:nil"">
              <xsl:value-of select=""'true'"" />
            </xsl:attribute>
          </WI_ActualCompleteTs>
        </xsl:if>
        <xsl:if test=""string($var:v40)='false'"">
          <WI_ActualCompleteTs>
            <xsl:value-of select=""WI_ActualCompleteTs/text()"" />
          </WI_ActualCompleteTs>
        </xsl:if>
      </xsl:if>
      <xsl:if test=""WI_ActualConfirmTs"">
        <xsl:variable name=""var:v41"" select=""string(WI_ActualConfirmTs/@xsi:nil) = 'true'"" />
        <xsl:if test=""string($var:v41)='true'"">
          <WI_ActualConfirmTs>
            <xsl:attribute name=""xsi:nil"">
              <xsl:value-of select=""'true'"" />
            </xsl:attribute>
          </WI_ActualConfirmTs>
        </xsl:if>
        <xsl:if test=""string($var:v41)='false'"">
          <WI_ActualConfirmTs>
            <xsl:value-of select=""WI_ActualConfirmTs/text()"" />
          </WI_ActualConfirmTs>
        </xsl:if>
      </xsl:if>
      <xsl:if test=""Meta_RF01"">
        <xsl:variable name=""var:v42"" select=""string(Meta_RF01/@xsi:nil) = 'true'"" />
        <xsl:if test=""string($var:v42)='true'"">
          <Meta_RF01>
            <xsl:attribute name=""xsi:nil"">
              <xsl:value-of select=""'true'"" />
            </xsl:attribute>
          </Meta_RF01>
        </xsl:if>
        <xsl:if test=""string($var:v42)='false'"">
          <Meta_RF01>
            <xsl:value-of select=""Meta_RF01/text()"" />
          </Meta_RF01>
        </xsl:if>
      </xsl:if>
      <xsl:if test=""Meta_RF02"">
        <xsl:variable name=""var:v43"" select=""string(Meta_RF02/@xsi:nil) = 'true'"" />
        <xsl:if test=""string($var:v43)='true'"">
          <Meta_RF02>
            <xsl:attribute name=""xsi:nil"">
              <xsl:value-of select=""'true'"" />
            </xsl:attribute>
          </Meta_RF02>
        </xsl:if>
        <xsl:if test=""string($var:v43)='false'"">
          <Meta_RF02>
            <xsl:value-of select=""Meta_RF02/text()"" />
          </Meta_RF02>
        </xsl:if>
      </xsl:if>
      <xsl:if test=""Meta_RF03"">
        <xsl:variable name=""var:v44"" select=""string(Meta_RF03/@xsi:nil) = 'true'"" />
        <xsl:if test=""string($var:v44)='true'"">
          <Meta_RF03>
            <xsl:attribute name=""xsi:nil"">
              <xsl:value-of select=""'true'"" />
            </xsl:attribute>
          </Meta_RF03>
        </xsl:if>
        <xsl:if test=""string($var:v44)='false'"">
          <Meta_RF03>
            <xsl:value-of select=""Meta_RF03/text()"" />
          </Meta_RF03>
        </xsl:if>
      </xsl:if>
      <xsl:if test=""Meta_RF04"">
        <xsl:variable name=""var:v45"" select=""string(Meta_RF04/@xsi:nil) = 'true'"" />
        <xsl:if test=""string($var:v45)='true'"">
          <Meta_RF04>
            <xsl:attribute name=""xsi:nil"">
              <xsl:value-of select=""'true'"" />
            </xsl:attribute>
          </Meta_RF04>
        </xsl:if>
        <xsl:if test=""string($var:v45)='false'"">
          <Meta_RF04>
            <xsl:value-of select=""Meta_RF04/text()"" />
          </Meta_RF04>
        </xsl:if>
      </xsl:if>
      <xsl:if test=""Meta_RF05"">
        <xsl:variable name=""var:v46"" select=""string(Meta_RF05/@xsi:nil) = 'true'"" />
        <xsl:if test=""string($var:v46)='true'"">
          <Meta_RF05>
            <xsl:attribute name=""xsi:nil"">
              <xsl:value-of select=""'true'"" />
            </xsl:attribute>
          </Meta_RF05>
        </xsl:if>
        <xsl:if test=""string($var:v46)='false'"">
          <Meta_RF05>
            <xsl:value-of select=""Meta_RF05/text()"" />
          </Meta_RF05>
        </xsl:if>
      </xsl:if>
      <xsl:if test=""Meta_RF06"">
        <xsl:variable name=""var:v47"" select=""string(Meta_RF06/@xsi:nil) = 'true'"" />
        <xsl:if test=""string($var:v47)='true'"">
          <Meta_RF06>
            <xsl:attribute name=""xsi:nil"">
              <xsl:value-of select=""'true'"" />
            </xsl:attribute>
          </Meta_RF06>
        </xsl:if>
        <xsl:if test=""string($var:v47)='false'"">
          <Meta_RF06>
            <xsl:value-of select=""Meta_RF06/text()"" />
          </Meta_RF06>
        </xsl:if>
      </xsl:if>
      <xsl:if test=""Meta_RF07"">
        <xsl:variable name=""var:v48"" select=""string(Meta_RF07/@xsi:nil) = 'true'"" />
        <xsl:if test=""string($var:v48)='true'"">
          <Meta_RF07>
            <xsl:attribute name=""xsi:nil"">
              <xsl:value-of select=""'true'"" />
            </xsl:attribute>
          </Meta_RF07>
        </xsl:if>
        <xsl:if test=""string($var:v48)='false'"">
          <Meta_RF07>
            <xsl:value-of select=""Meta_RF07/text()"" />
          </Meta_RF07>
        </xsl:if>
      </xsl:if>
      <xsl:if test=""Meta_RF08"">
        <xsl:variable name=""var:v49"" select=""string(Meta_RF08/@xsi:nil) = 'true'"" />
        <xsl:if test=""string($var:v49)='true'"">
          <Meta_RF08>
            <xsl:attribute name=""xsi:nil"">
              <xsl:value-of select=""'true'"" />
            </xsl:attribute>
          </Meta_RF08>
        </xsl:if>
        <xsl:if test=""string($var:v49)='false'"">
          <Meta_RF08>
            <xsl:value-of select=""Meta_RF08/text()"" />
          </Meta_RF08>
        </xsl:if>
      </xsl:if>
      <xsl:if test=""Meta_RF09"">
        <xsl:variable name=""var:v50"" select=""string(Meta_RF09/@xsi:nil) = 'true'"" />
        <xsl:if test=""string($var:v50)='true'"">
          <Meta_RF09>
            <xsl:attribute name=""xsi:nil"">
              <xsl:value-of select=""'true'"" />
            </xsl:attribute>
          </Meta_RF09>
        </xsl:if>
        <xsl:if test=""string($var:v50)='false'"">
          <Meta_RF09>
            <xsl:value-of select=""Meta_RF09/text()"" />
          </Meta_RF09>
        </xsl:if>
      </xsl:if>
      <xsl:if test=""Meta_RF10"">
        <xsl:variable name=""var:v51"" select=""string(Meta_RF10/@xsi:nil) = 'true'"" />
        <xsl:if test=""string($var:v51)='true'"">
          <Meta_RF10>
            <xsl:attribute name=""xsi:nil"">
              <xsl:value-of select=""'true'"" />
            </xsl:attribute>
          </Meta_RF10>
        </xsl:if>
        <xsl:if test=""string($var:v51)='false'"">
          <Meta_RF10>
            <xsl:value-of select=""Meta_RF10/text()"" />
          </Meta_RF10>
        </xsl:if>
      </xsl:if>
      <xsl:if test=""Meta_RF11"">
        <xsl:variable name=""var:v52"" select=""string(Meta_RF11/@xsi:nil) = 'true'"" />
        <xsl:if test=""string($var:v52)='true'"">
          <Meta_RF11>
            <xsl:attribute name=""xsi:nil"">
              <xsl:value-of select=""'true'"" />
            </xsl:attribute>
          </Meta_RF11>
        </xsl:if>
        <xsl:if test=""string($var:v52)='false'"">
          <Meta_RF11>
            <xsl:value-of select=""Meta_RF11/text()"" />
          </Meta_RF11>
        </xsl:if>
      </xsl:if>
      <xsl:if test=""Meta_RF12"">
        <xsl:variable name=""var:v53"" select=""string(Meta_RF12/@xsi:nil) = 'true'"" />
        <xsl:if test=""string($var:v53)='true'"">
          <Meta_RF12>
            <xsl:attribute name=""xsi:nil"">
              <xsl:value-of select=""'true'"" />
            </xsl:attribute>
          </Meta_RF12>
        </xsl:if>
        <xsl:if test=""string($var:v53)='false'"">
          <Meta_RF12>
            <xsl:value-of select=""Meta_RF12/text()"" />
          </Meta_RF12>
        </xsl:if>
      </xsl:if>
      <xsl:if test=""Meta_RF13"">
        <xsl:variable name=""var:v54"" select=""string(Meta_RF13/@xsi:nil) = 'true'"" />
        <xsl:if test=""string($var:v54)='true'"">
          <Meta_RF13>
            <xsl:attribute name=""xsi:nil"">
              <xsl:value-of select=""'true'"" />
            </xsl:attribute>
          </Meta_RF13>
        </xsl:if>
        <xsl:if test=""string($var:v54)='false'"">
          <Meta_RF13>
            <xsl:value-of select=""Meta_RF13/text()"" />
          </Meta_RF13>
        </xsl:if>
      </xsl:if>
      <xsl:if test=""Meta_RF14"">
        <xsl:variable name=""var:v55"" select=""string(Meta_RF14/@xsi:nil) = 'true'"" />
        <xsl:if test=""string($var:v55)='true'"">
          <Meta_RF14>
            <xsl:attribute name=""xsi:nil"">
              <xsl:value-of select=""'true'"" />
            </xsl:attribute>
          </Meta_RF14>
        </xsl:if>
        <xsl:if test=""string($var:v55)='false'"">
          <Meta_RF14>
            <xsl:value-of select=""Meta_RF14/text()"" />
          </Meta_RF14>
        </xsl:if>
      </xsl:if>
      <xsl:if test=""Meta_RF15"">
        <xsl:variable name=""var:v56"" select=""string(Meta_RF15/@xsi:nil) = 'true'"" />
        <xsl:if test=""string($var:v56)='true'"">
          <Meta_RF15>
            <xsl:attribute name=""xsi:nil"">
              <xsl:value-of select=""'true'"" />
            </xsl:attribute>
          </Meta_RF15>
        </xsl:if>
        <xsl:if test=""string($var:v56)='false'"">
          <Meta_RF15>
            <xsl:value-of select=""Meta_RF15/text()"" />
          </Meta_RF15>
        </xsl:if>
      </xsl:if>
      <xsl:variable name=""var:v57"" select=""string(Meta_RF21/@xsi:nil) = 'true'"" />
      <xsl:if test=""string($var:v57)='true'"">
        <Meta_RF21>
          <xsl:attribute name=""xsi:nil"">
            <xsl:value-of select=""'true'"" />
          </xsl:attribute>
        </Meta_RF21>
      </xsl:if>
      <xsl:if test=""string($var:v57)='false'"">
        <Meta_RF21>
          <xsl:value-of select=""Meta_RF21/text()"" />
        </Meta_RF21>
      </xsl:if>
      <xsl:for-each select=""WI_ServiceNotes"">
        <WI_ServiceNotes>
          <xsl:for-each select=""WI_Note"">
            <WI_Note>
              <xsl:if test=""WI_Noteid"">
                <WI_Noteid>
                  <xsl:value-of select=""WI_Noteid/text()"" />
                </WI_Noteid>
              </xsl:if>
              <xsl:if test=""WI_NoteText"">
                <WI_NoteText>
                  <xsl:value-of select=""WI_NoteText/text()"" />
                </WI_NoteText>
              </xsl:if>
              <xsl:if test=""WI_CreatedBy"">
                <xsl:variable name=""var:v58"" select=""string(WI_CreatedBy/@xsi:nil) = 'true'"" />
                <xsl:if test=""string($var:v58)='true'"">
                  <WI_CreatedBy>
                    <xsl:attribute name=""xsi:nil"">
                      <xsl:value-of select=""'true'"" />
                    </xsl:attribute>
                  </WI_CreatedBy>
                </xsl:if>
                <xsl:if test=""string($var:v58)='false'"">
                  <WI_CreatedBy>
                    <xsl:value-of select=""WI_CreatedBy/text()"" />
                  </WI_CreatedBy>
                </xsl:if>
              </xsl:if>
              <xsl:if test=""WI_NoteTS"">
                <WI_NoteTS>
                  <xsl:value-of select=""WI_NoteTS/text()"" />
                </WI_NoteTS>
              </xsl:if>
              <xsl:if test=""WI_ClientViewable"">
                <WI_ClientViewable>
                  <xsl:value-of select=""WI_ClientViewable/text()"" />
                </WI_ClientViewable>
              </xsl:if>
              <xsl:if test=""WI_ActionRequired"">
                <WI_ActionRequired>
                  <xsl:value-of select=""WI_ActionRequired/text()"" />
                </WI_ActionRequired>
              </xsl:if>
              <xsl:if test=""WI_Ignore"">
                <WI_Ignore>
                  <xsl:value-of select=""WI_Ignore/text()"" />
                </WI_Ignore>
              </xsl:if>
              <xsl:value-of select=""./text()"" />
            </WI_Note>
          </xsl:for-each>
          <xsl:value-of select=""./text()"" />
        </WI_ServiceNotes>
      </xsl:for-each>
      <xsl:for-each select=""WI_MitigationNotes"">
        <WI_MitigationNotes>
          <xsl:for-each select=""WI_MitEvnt"">
            <WI_MitEvnt>
              <xsl:if test=""WI_Noteid"">
                <WI_Noteid>
                  <xsl:value-of select=""WI_Noteid/text()"" />
                </WI_Noteid>
              </xsl:if>
              <xsl:if test=""WI_NoteText"">
                <WI_NoteText>
                  <xsl:value-of select=""WI_NoteText/text()"" />
                </WI_NoteText>
              </xsl:if>
              <xsl:if test=""WI_CreatedBy"">
                <WI_CreatedBy>
                  <xsl:value-of select=""WI_CreatedBy/text()"" />
                </WI_CreatedBy>
              </xsl:if>
              <xsl:if test=""WI_NoteTS"">
                <WI_NoteTS>
                  <xsl:value-of select=""WI_NoteTS/text()"" />
                </WI_NoteTS>
              </xsl:if>
              <xsl:if test=""WI_ClientViewable"">
                <WI_ClientViewable>
                  <xsl:value-of select=""WI_ClientViewable/text()"" />
                </WI_ClientViewable>
              </xsl:if>
              <xsl:if test=""WI_ActionRequired"">
                <WI_ActionRequired>
                  <xsl:value-of select=""WI_ActionRequired/text()"" />
                </WI_ActionRequired>
              </xsl:if>
              <xsl:if test=""WI_Mitigation"">
                <WI_Mitigation>
                  <xsl:value-of select=""WI_Mitigation/text()"" />
                </WI_Mitigation>
              </xsl:if>
              <xsl:value-of select=""./text()"" />
            </WI_MitEvnt>
          </xsl:for-each>
          <xsl:value-of select=""./text()"" />
        </WI_MitigationNotes>
      </xsl:for-each>
    </ns0:MFMWorkItemUpdate>
    <xsl:variable name=""var:v59"" select=""ScriptNS1:DBLookupShutdown()"" />
  </xsl:template>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp""><![CDATA[
public string StringConcat(string param0, string param1, string param2)
{
   return param0 + param1 + param2;
}


public bool LogicalIsNumeric(string val)
{
	return IsNumeric(val);
}


public bool LogicalNot(string val)
{
	return !ValToBool(val);
}


public string StringConcat(string param0)
{
   return param0;
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
        
        private const string _strArgList = @"<ExtensionObjects>
  <ExtensionObject Namespace=""http://schemas.microsoft.com/BizTalk/2003/ScriptNS0"" AssemblyName=""MFM.Lbg.Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=b52a4a519c43e251"" ClassName=""MFM.Lbg.Helper.Misc"" />
  <ExtensionObject Namespace=""http://schemas.microsoft.com/BizTalk/2003/ScriptNS1"" AssemblyName=""Microsoft.BizTalk.BaseFunctoids, Version=3.0.1.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35"" ClassName=""Microsoft.BizTalk.BaseFunctoids.FunctoidScripts"" />
</ExtensionObjects>";
        
        private const string _strSrcSchemasList0 = @"MFM.Lbg.Schemas.MFMWorkItemUpdate";
        
        private const global::MFM.Lbg.Schemas.MFMWorkItemUpdate _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"MFM.Lbg.Schemas.MFMWorkItemUpdate";
        
        private const global::MFM.Lbg.Schemas.MFMWorkItemUpdate _trgSchemaTypeReference0 = null;
        
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
                _TrgSchemas[0] = @"MFM.Lbg.Schemas.MFMWorkItemUpdate";
                return _TrgSchemas;
            }
        }
    }
}
