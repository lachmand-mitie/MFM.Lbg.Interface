namespace MFM.Lbg.Orcs {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"MFM.Lbg.Schemas.MFMWorkItemUpdate", typeof(global::MFM.Lbg.Schemas.MFMWorkItemUpdate))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"MFM.Lbg.Schemas.VFM_UPDTypedProcedure_dbo+Biz_Import_Case_Update", typeof(global::MFM.Lbg.Schemas.VFM_UPDTypedProcedure_dbo.Biz_Import_Case_Update))]
    public sealed class map_to_biz_import_case_update : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0"" version=""1.0"" xmlns:ns3=""http://schemas.microsoft.com/Sql/2008/05/ProceduresResultSets/dbo/Biz_Import_Case_Note"" xmlns:s0=""http://MFM.Lbg.Schemas.MFMWorkItemUpdate"" xmlns:ns4=""http://schemas.microsoft.com/Sql/2008/05/ProceduresResultSets/dbo/Biz_Import_Case_Update"" xmlns:ns0=""http://schemas.microsoft.com/Sql/2008/05/TypedProcedures/dbo"" xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:MFMWorkItemUpdate"" />
  </xsl:template>
  <xsl:template match=""/s0:MFMWorkItemUpdate"">
    <ns0:Biz_Import_Case_Update>
      <xsl:variable name=""var:v1"" select=""string(SourceSystem/@xsi:nil) = 'true'"" />
      <xsl:if test=""string($var:v1)='true'"">
        <ns0:sourcesystem>
          <xsl:attribute name=""xsi:nil"">
            <xsl:value-of select=""'true'"" />
          </xsl:attribute>
        </ns0:sourcesystem>
      </xsl:if>
      <xsl:if test=""string($var:v1)='false'"">
        <ns0:sourcesystem>
          <xsl:value-of select=""SourceSystem/text()"" />
        </ns0:sourcesystem>
      </xsl:if>
      <xsl:variable name=""var:v2"" select=""string(SourceSystemMessageId/@xsi:nil) = 'true'"" />
      <xsl:if test=""string($var:v2)='true'"">
        <ns0:sourcesystemmessageid>
          <xsl:attribute name=""xsi:nil"">
            <xsl:value-of select=""'true'"" />
          </xsl:attribute>
        </ns0:sourcesystemmessageid>
      </xsl:if>
      <xsl:if test=""string($var:v2)='false'"">
        <ns0:sourcesystemmessageid>
          <xsl:value-of select=""SourceSystemMessageId/text()"" />
        </ns0:sourcesystemmessageid>
      </xsl:if>
      <xsl:variable name=""var:v3"" select=""string(SourceSystemMessageTs/@xsi:nil) = 'true'"" />
      <xsl:if test=""string($var:v3)='true'"">
        <ns0:sourcesystemmessagets>
          <xsl:attribute name=""xsi:nil"">
            <xsl:value-of select=""'true'"" />
          </xsl:attribute>
        </ns0:sourcesystemmessagets>
      </xsl:if>
      <xsl:if test=""string($var:v3)='false'"">
        <ns0:sourcesystemmessagets>
          <xsl:value-of select=""SourceSystemMessageTs/text()"" />
        </ns0:sourcesystemmessagets>
      </xsl:if>
      <xsl:variable name=""var:v4"" select=""string(BizTalkMessageId/@xsi:nil) = 'true'"" />
      <xsl:if test=""string($var:v4)='true'"">
        <ns0:biztalkmessageid>
          <xsl:attribute name=""xsi:nil"">
            <xsl:value-of select=""'true'"" />
          </xsl:attribute>
        </ns0:biztalkmessageid>
      </xsl:if>
      <xsl:if test=""string($var:v4)='false'"">
        <ns0:biztalkmessageid>
          <xsl:value-of select=""BizTalkMessageId/text()"" />
        </ns0:biztalkmessageid>
      </xsl:if>
      <xsl:variable name=""var:v5"" select=""string(BizTalkMessageTs/@xsi:nil) = 'true'"" />
      <xsl:if test=""string($var:v5)='true'"">
        <ns0:biztalkmessagets>
          <xsl:attribute name=""xsi:nil"">
            <xsl:value-of select=""'true'"" />
          </xsl:attribute>
        </ns0:biztalkmessagets>
      </xsl:if>
      <xsl:if test=""string($var:v5)='false'"">
        <ns0:biztalkmessagets>
          <xsl:value-of select=""BizTalkMessageTs/text()"" />
        </ns0:biztalkmessagets>
      </xsl:if>
      <xsl:variable name=""var:v6"" select=""string(WI_WorkType/@xsi:nil) = 'true'"" />
      <xsl:if test=""string($var:v6)='true'"">
        <ns0:worktype>
          <xsl:attribute name=""xsi:nil"">
            <xsl:value-of select=""'true'"" />
          </xsl:attribute>
        </ns0:worktype>
      </xsl:if>
      <xsl:if test=""string($var:v6)='false'"">
        <ns0:worktype>
          <xsl:value-of select=""WI_WorkType/text()"" />
        </ns0:worktype>
      </xsl:if>
      <xsl:variable name=""var:v7"" select=""string(WI_UpdateTs/@xsi:nil) = 'true'"" />
      <xsl:if test=""string($var:v7)='true'"">
        <ns0:updatets>
          <xsl:attribute name=""xsi:nil"">
            <xsl:value-of select=""'true'"" />
          </xsl:attribute>
        </ns0:updatets>
      </xsl:if>
      <xsl:if test=""string($var:v7)='false'"">
        <ns0:updatets>
          <xsl:value-of select=""WI_UpdateTs/text()"" />
        </ns0:updatets>
      </xsl:if>
      <xsl:variable name=""var:v8"" select=""string(WI_SourceRef/@xsi:nil) = 'true'"" />
      <xsl:if test=""string($var:v8)='true'"">
        <ns0:sourceref>
          <xsl:attribute name=""xsi:nil"">
            <xsl:value-of select=""'true'"" />
          </xsl:attribute>
        </ns0:sourceref>
      </xsl:if>
      <xsl:if test=""string($var:v8)='false'"">
        <ns0:sourceref>
          <xsl:value-of select=""WI_SourceRef/text()"" />
        </ns0:sourceref>
      </xsl:if>
      <xsl:variable name=""var:v9"" select=""string(WI_DestinationRef/@xsi:nil) = 'true'"" />
      <xsl:if test=""string($var:v9)='true'"">
        <ns0:destinationref>
          <xsl:attribute name=""xsi:nil"">
            <xsl:value-of select=""'true'"" />
          </xsl:attribute>
        </ns0:destinationref>
      </xsl:if>
      <xsl:if test=""string($var:v9)='false'"">
        <ns0:destinationref>
          <xsl:value-of select=""WI_DestinationRef/text()"" />
        </ns0:destinationref>
      </xsl:if>
      <xsl:if test=""WI_ServiceLevel1"">
        <xsl:variable name=""var:v10"" select=""string(WI_ServiceLevel1/@xsi:nil) = 'true'"" />
        <xsl:if test=""string($var:v10)='true'"">
          <ns0:servicelevel1>
            <xsl:attribute name=""xsi:nil"">
              <xsl:value-of select=""'true'"" />
            </xsl:attribute>
          </ns0:servicelevel1>
        </xsl:if>
        <xsl:if test=""string($var:v10)='false'"">
          <ns0:servicelevel1>
            <xsl:value-of select=""WI_ServiceLevel1/text()"" />
          </ns0:servicelevel1>
        </xsl:if>
      </xsl:if>
      <xsl:if test=""WI_ServiceLevel2"">
        <xsl:variable name=""var:v11"" select=""string(WI_ServiceLevel2/@xsi:nil) = 'true'"" />
        <xsl:if test=""string($var:v11)='true'"">
          <ns0:servicelevel2>
            <xsl:attribute name=""xsi:nil"">
              <xsl:value-of select=""'true'"" />
            </xsl:attribute>
          </ns0:servicelevel2>
        </xsl:if>
        <xsl:if test=""string($var:v11)='false'"">
          <ns0:servicelevel2>
            <xsl:value-of select=""WI_ServiceLevel2/text()"" />
          </ns0:servicelevel2>
        </xsl:if>
      </xsl:if>
      <xsl:if test=""WI_ServiceLevel3"">
        <xsl:variable name=""var:v12"" select=""string(WI_ServiceLevel3/@xsi:nil) = 'true'"" />
        <xsl:if test=""string($var:v12)='true'"">
          <ns0:servicelevel3>
            <xsl:attribute name=""xsi:nil"">
              <xsl:value-of select=""'true'"" />
            </xsl:attribute>
          </ns0:servicelevel3>
        </xsl:if>
        <xsl:if test=""string($var:v12)='false'"">
          <ns0:servicelevel3>
            <xsl:value-of select=""WI_ServiceLevel3/text()"" />
          </ns0:servicelevel3>
        </xsl:if>
      </xsl:if>
      <xsl:if test=""WI_AssetRef"">
        <xsl:variable name=""var:v13"" select=""string(WI_AssetRef/@xsi:nil) = 'true'"" />
        <xsl:if test=""string($var:v13)='true'"">
          <ns0:assetref>
            <xsl:attribute name=""xsi:nil"">
              <xsl:value-of select=""'true'"" />
            </xsl:attribute>
          </ns0:assetref>
        </xsl:if>
        <xsl:if test=""string($var:v13)='false'"">
          <ns0:assetref>
            <xsl:value-of select=""WI_AssetRef/text()"" />
          </ns0:assetref>
        </xsl:if>
      </xsl:if>
      <xsl:if test=""WI_LocationLevel1"">
        <xsl:variable name=""var:v14"" select=""string(WI_LocationLevel1/@xsi:nil) = 'true'"" />
        <xsl:if test=""string($var:v14)='true'"">
          <ns0:locationlevel1>
            <xsl:attribute name=""xsi:nil"">
              <xsl:value-of select=""'true'"" />
            </xsl:attribute>
          </ns0:locationlevel1>
        </xsl:if>
        <xsl:if test=""string($var:v14)='false'"">
          <ns0:locationlevel1>
            <xsl:value-of select=""WI_LocationLevel1/text()"" />
          </ns0:locationlevel1>
        </xsl:if>
      </xsl:if>
      <xsl:if test=""WI_LocationLevel2"">
        <xsl:variable name=""var:v15"" select=""string(WI_LocationLevel2/@xsi:nil) = 'true'"" />
        <xsl:if test=""string($var:v15)='true'"">
          <ns0:locationlevel2>
            <xsl:attribute name=""xsi:nil"">
              <xsl:value-of select=""'true'"" />
            </xsl:attribute>
          </ns0:locationlevel2>
        </xsl:if>
        <xsl:if test=""string($var:v15)='false'"">
          <ns0:locationlevel2>
            <xsl:value-of select=""WI_LocationLevel2/text()"" />
          </ns0:locationlevel2>
        </xsl:if>
      </xsl:if>
      <xsl:if test=""WI_LocationLevel3"">
        <xsl:variable name=""var:v16"" select=""string(WI_LocationLevel3/@xsi:nil) = 'true'"" />
        <xsl:if test=""string($var:v16)='true'"">
          <ns0:locationlevel3>
            <xsl:attribute name=""xsi:nil"">
              <xsl:value-of select=""'true'"" />
            </xsl:attribute>
          </ns0:locationlevel3>
        </xsl:if>
        <xsl:if test=""string($var:v16)='false'"">
          <ns0:locationlevel3>
            <xsl:value-of select=""WI_LocationLevel3/text()"" />
          </ns0:locationlevel3>
        </xsl:if>
      </xsl:if>
      <xsl:if test=""WI_LocationLevel4"">
        <xsl:variable name=""var:v17"" select=""string(WI_LocationLevel4/@xsi:nil) = 'true'"" />
        <xsl:if test=""string($var:v17)='true'"">
          <ns0:locationlevel4>
            <xsl:attribute name=""xsi:nil"">
              <xsl:value-of select=""'true'"" />
            </xsl:attribute>
          </ns0:locationlevel4>
        </xsl:if>
        <xsl:if test=""string($var:v17)='false'"">
          <ns0:locationlevel4>
            <xsl:value-of select=""WI_LocationLevel4/text()"" />
          </ns0:locationlevel4>
        </xsl:if>
      </xsl:if>
      <xsl:if test=""WI_Status"">
        <xsl:variable name=""var:v18"" select=""string(WI_Status/@xsi:nil) = 'true'"" />
        <xsl:if test=""string($var:v18)='true'"">
          <ns0:status>
            <xsl:attribute name=""xsi:nil"">
              <xsl:value-of select=""'true'"" />
            </xsl:attribute>
          </ns0:status>
        </xsl:if>
        <xsl:if test=""string($var:v18)='false'"">
          <ns0:status>
            <xsl:value-of select=""WI_Status/text()"" />
          </ns0:status>
        </xsl:if>
      </xsl:if>
      <xsl:if test=""WI_StatusChangeTS"">
        <xsl:variable name=""var:v19"" select=""string(WI_StatusChangeTS/@xsi:nil) = 'true'"" />
        <xsl:if test=""string($var:v19)='true'"">
          <ns0:statuschangets>
            <xsl:attribute name=""xsi:nil"">
              <xsl:value-of select=""'true'"" />
            </xsl:attribute>
          </ns0:statuschangets>
        </xsl:if>
        <xsl:if test=""string($var:v19)='false'"">
          <ns0:statuschangets>
            <xsl:value-of select=""WI_StatusChangeTS/text()"" />
          </ns0:statuschangets>
        </xsl:if>
      </xsl:if>
      <xsl:if test=""WI_StatusNote"">
        <xsl:variable name=""var:v20"" select=""string(WI_StatusNote/@xsi:nil) = 'true'"" />
        <xsl:if test=""string($var:v20)='true'"">
          <ns0:statusnote>
            <xsl:attribute name=""xsi:nil"">
              <xsl:value-of select=""'true'"" />
            </xsl:attribute>
          </ns0:statusnote>
        </xsl:if>
        <xsl:if test=""string($var:v20)='false'"">
          <ns0:statusnote>
            <xsl:value-of select=""WI_StatusNote/text()"" />
          </ns0:statusnote>
        </xsl:if>
      </xsl:if>
      <xsl:if test=""WI_Priority"">
        <xsl:variable name=""var:v21"" select=""string(WI_Priority/@xsi:nil) = 'true'"" />
        <xsl:if test=""string($var:v21)='true'"">
          <ns0:priority>
            <xsl:attribute name=""xsi:nil"">
              <xsl:value-of select=""'true'"" />
            </xsl:attribute>
          </ns0:priority>
        </xsl:if>
        <xsl:if test=""string($var:v21)='false'"">
          <ns0:priority>
            <xsl:value-of select=""WI_Priority/text()"" />
          </ns0:priority>
        </xsl:if>
      </xsl:if>
      <xsl:if test=""WI_KpiStartTs"">
        <xsl:variable name=""var:v22"" select=""string(WI_KpiStartTs/@xsi:nil) = 'true'"" />
        <xsl:if test=""string($var:v22)='true'"">
          <ns0:kpistart>
            <xsl:attribute name=""xsi:nil"">
              <xsl:value-of select=""'true'"" />
            </xsl:attribute>
          </ns0:kpistart>
        </xsl:if>
        <xsl:if test=""string($var:v22)='false'"">
          <ns0:kpistart>
            <xsl:value-of select=""WI_KpiStartTs/text()"" />
          </ns0:kpistart>
        </xsl:if>
      </xsl:if>
      <xsl:if test=""WI_KpiAttendTs"">
        <xsl:variable name=""var:v23"" select=""string(WI_KpiAttendTs/@xsi:nil) = 'true'"" />
        <xsl:if test=""string($var:v23)='true'"">
          <ns0:kpiattend>
            <xsl:attribute name=""xsi:nil"">
              <xsl:value-of select=""'true'"" />
            </xsl:attribute>
          </ns0:kpiattend>
        </xsl:if>
        <xsl:if test=""string($var:v23)='false'"">
          <ns0:kpiattend>
            <xsl:value-of select=""WI_KpiAttendTs/text()"" />
          </ns0:kpiattend>
        </xsl:if>
      </xsl:if>
      <xsl:if test=""WI_KpiCompleteTs"">
        <xsl:variable name=""var:v24"" select=""string(WI_KpiCompleteTs/@xsi:nil) = 'true'"" />
        <xsl:if test=""string($var:v24)='true'"">
          <ns0:kpicomplete>
            <xsl:attribute name=""xsi:nil"">
              <xsl:value-of select=""'true'"" />
            </xsl:attribute>
          </ns0:kpicomplete>
        </xsl:if>
        <xsl:if test=""string($var:v24)='false'"">
          <ns0:kpicomplete>
            <xsl:value-of select=""WI_KpiCompleteTs/text()"" />
          </ns0:kpicomplete>
        </xsl:if>
      </xsl:if>
      <xsl:if test=""WI_KpiConfirmTs"">
        <xsl:variable name=""var:v25"" select=""string(WI_KpiConfirmTs/@xsi:nil) = 'true'"" />
        <xsl:if test=""string($var:v25)='true'"">
          <ns0:kpiconfirm>
            <xsl:attribute name=""xsi:nil"">
              <xsl:value-of select=""'true'"" />
            </xsl:attribute>
          </ns0:kpiconfirm>
        </xsl:if>
        <xsl:if test=""string($var:v25)='false'"">
          <ns0:kpiconfirm>
            <xsl:value-of select=""WI_KpiConfirmTs/text()"" />
          </ns0:kpiconfirm>
        </xsl:if>
      </xsl:if>
      <xsl:if test=""WI_ActualStartTs"">
        <xsl:variable name=""var:v26"" select=""string(WI_ActualStartTs/@xsi:nil) = 'true'"" />
        <xsl:if test=""string($var:v26)='true'"">
          <ns0:actstart>
            <xsl:attribute name=""xsi:nil"">
              <xsl:value-of select=""'true'"" />
            </xsl:attribute>
          </ns0:actstart>
        </xsl:if>
        <xsl:if test=""string($var:v26)='false'"">
          <ns0:actstart>
            <xsl:value-of select=""WI_ActualStartTs/text()"" />
          </ns0:actstart>
        </xsl:if>
      </xsl:if>
      <xsl:if test=""WI_ActualAttendTs"">
        <xsl:variable name=""var:v27"" select=""string(WI_ActualAttendTs/@xsi:nil) = 'true'"" />
        <xsl:if test=""string($var:v27)='true'"">
          <ns0:actattend>
            <xsl:attribute name=""xsi:nil"">
              <xsl:value-of select=""'true'"" />
            </xsl:attribute>
          </ns0:actattend>
        </xsl:if>
        <xsl:if test=""string($var:v27)='false'"">
          <ns0:actattend>
            <xsl:value-of select=""WI_ActualAttendTs/text()"" />
          </ns0:actattend>
        </xsl:if>
      </xsl:if>
      <xsl:if test=""WI_ActualCompleteTs"">
        <xsl:variable name=""var:v28"" select=""string(WI_ActualCompleteTs/@xsi:nil) = 'true'"" />
        <xsl:if test=""string($var:v28)='true'"">
          <ns0:actcomplete>
            <xsl:attribute name=""xsi:nil"">
              <xsl:value-of select=""'true'"" />
            </xsl:attribute>
          </ns0:actcomplete>
        </xsl:if>
        <xsl:if test=""string($var:v28)='false'"">
          <ns0:actcomplete>
            <xsl:value-of select=""WI_ActualCompleteTs/text()"" />
          </ns0:actcomplete>
        </xsl:if>
      </xsl:if>
      <xsl:if test=""WI_ActualConfirmTs"">
        <xsl:variable name=""var:v29"" select=""string(WI_ActualConfirmTs/@xsi:nil) = 'true'"" />
        <xsl:if test=""string($var:v29)='true'"">
          <ns0:actconfirm>
            <xsl:attribute name=""xsi:nil"">
              <xsl:value-of select=""'true'"" />
            </xsl:attribute>
          </ns0:actconfirm>
        </xsl:if>
        <xsl:if test=""string($var:v29)='false'"">
          <ns0:actconfirm>
            <xsl:value-of select=""WI_ActualConfirmTs/text()"" />
          </ns0:actconfirm>
        </xsl:if>
      </xsl:if>
      <ns0:notes>
        <xsl:attribute name=""xsi:nil"">
          <xsl:value-of select=""'true'"" />
        </xsl:attribute>
      </ns0:notes>
      <xsl:if test=""Meta_RF01"">
        <xsl:variable name=""var:v30"" select=""string(Meta_RF01/@xsi:nil) = 'true'"" />
        <xsl:if test=""string($var:v30)='true'"">
          <ns0:metarf01>
            <xsl:attribute name=""xsi:nil"">
              <xsl:value-of select=""'true'"" />
            </xsl:attribute>
          </ns0:metarf01>
        </xsl:if>
        <xsl:if test=""string($var:v30)='false'"">
          <ns0:metarf01>
            <xsl:value-of select=""Meta_RF01/text()"" />
          </ns0:metarf01>
        </xsl:if>
      </xsl:if>
      <xsl:if test=""Meta_RF02"">
        <xsl:variable name=""var:v31"" select=""string(Meta_RF02/@xsi:nil) = 'true'"" />
        <xsl:if test=""string($var:v31)='true'"">
          <ns0:metarf02>
            <xsl:attribute name=""xsi:nil"">
              <xsl:value-of select=""'true'"" />
            </xsl:attribute>
          </ns0:metarf02>
        </xsl:if>
        <xsl:if test=""string($var:v31)='false'"">
          <ns0:metarf02>
            <xsl:value-of select=""Meta_RF02/text()"" />
          </ns0:metarf02>
        </xsl:if>
      </xsl:if>
      <xsl:if test=""Meta_RF03"">
        <xsl:variable name=""var:v32"" select=""string(Meta_RF03/@xsi:nil) = 'true'"" />
        <xsl:if test=""string($var:v32)='true'"">
          <ns0:metarf03>
            <xsl:attribute name=""xsi:nil"">
              <xsl:value-of select=""'true'"" />
            </xsl:attribute>
          </ns0:metarf03>
        </xsl:if>
        <xsl:if test=""string($var:v32)='false'"">
          <ns0:metarf03>
            <xsl:value-of select=""Meta_RF03/text()"" />
          </ns0:metarf03>
        </xsl:if>
      </xsl:if>
      <xsl:if test=""Meta_RF04"">
        <xsl:variable name=""var:v33"" select=""string(Meta_RF04/@xsi:nil) = 'true'"" />
        <xsl:if test=""string($var:v33)='true'"">
          <ns0:metarf04>
            <xsl:attribute name=""xsi:nil"">
              <xsl:value-of select=""'true'"" />
            </xsl:attribute>
          </ns0:metarf04>
        </xsl:if>
        <xsl:if test=""string($var:v33)='false'"">
          <ns0:metarf04>
            <xsl:value-of select=""Meta_RF04/text()"" />
          </ns0:metarf04>
        </xsl:if>
      </xsl:if>
      <xsl:if test=""Meta_RF05"">
        <xsl:variable name=""var:v34"" select=""string(Meta_RF05/@xsi:nil) = 'true'"" />
        <xsl:if test=""string($var:v34)='true'"">
          <ns0:metarf05>
            <xsl:attribute name=""xsi:nil"">
              <xsl:value-of select=""'true'"" />
            </xsl:attribute>
          </ns0:metarf05>
        </xsl:if>
        <xsl:if test=""string($var:v34)='false'"">
          <ns0:metarf05>
            <xsl:value-of select=""Meta_RF05/text()"" />
          </ns0:metarf05>
        </xsl:if>
      </xsl:if>
      <xsl:if test=""Meta_RF06"">
        <xsl:variable name=""var:v35"" select=""string(Meta_RF06/@xsi:nil) = 'true'"" />
        <xsl:if test=""string($var:v35)='true'"">
          <ns0:metarf06>
            <xsl:attribute name=""xsi:nil"">
              <xsl:value-of select=""'true'"" />
            </xsl:attribute>
          </ns0:metarf06>
        </xsl:if>
        <xsl:if test=""string($var:v35)='false'"">
          <ns0:metarf06>
            <xsl:value-of select=""Meta_RF06/text()"" />
          </ns0:metarf06>
        </xsl:if>
      </xsl:if>
      <xsl:if test=""Meta_RF07"">
        <xsl:variable name=""var:v36"" select=""string(Meta_RF07/@xsi:nil) = 'true'"" />
        <xsl:if test=""string($var:v36)='true'"">
          <ns0:metarf07>
            <xsl:attribute name=""xsi:nil"">
              <xsl:value-of select=""'true'"" />
            </xsl:attribute>
          </ns0:metarf07>
        </xsl:if>
        <xsl:if test=""string($var:v36)='false'"">
          <ns0:metarf07>
            <xsl:value-of select=""Meta_RF07/text()"" />
          </ns0:metarf07>
        </xsl:if>
      </xsl:if>
      <xsl:if test=""Meta_RF08"">
        <xsl:variable name=""var:v37"" select=""string(Meta_RF08/@xsi:nil) = 'true'"" />
        <xsl:if test=""string($var:v37)='true'"">
          <ns0:metarf08>
            <xsl:attribute name=""xsi:nil"">
              <xsl:value-of select=""'true'"" />
            </xsl:attribute>
          </ns0:metarf08>
        </xsl:if>
        <xsl:if test=""string($var:v37)='false'"">
          <ns0:metarf08>
            <xsl:value-of select=""Meta_RF08/text()"" />
          </ns0:metarf08>
        </xsl:if>
      </xsl:if>
      <xsl:if test=""Meta_RF09"">
        <xsl:variable name=""var:v38"" select=""string(Meta_RF09/@xsi:nil) = 'true'"" />
        <xsl:if test=""string($var:v38)='true'"">
          <ns0:metarf09>
            <xsl:attribute name=""xsi:nil"">
              <xsl:value-of select=""'true'"" />
            </xsl:attribute>
          </ns0:metarf09>
        </xsl:if>
        <xsl:if test=""string($var:v38)='false'"">
          <ns0:metarf09>
            <xsl:value-of select=""Meta_RF09/text()"" />
          </ns0:metarf09>
        </xsl:if>
      </xsl:if>
      <xsl:if test=""Meta_RF10"">
        <xsl:variable name=""var:v39"" select=""string(Meta_RF10/@xsi:nil) = 'true'"" />
        <xsl:if test=""string($var:v39)='true'"">
          <ns0:metarf10>
            <xsl:attribute name=""xsi:nil"">
              <xsl:value-of select=""'true'"" />
            </xsl:attribute>
          </ns0:metarf10>
        </xsl:if>
        <xsl:if test=""string($var:v39)='false'"">
          <ns0:metarf10>
            <xsl:value-of select=""Meta_RF10/text()"" />
          </ns0:metarf10>
        </xsl:if>
      </xsl:if>
      <xsl:if test=""Meta_RF11"">
        <xsl:variable name=""var:v40"" select=""string(Meta_RF11/@xsi:nil) = 'true'"" />
        <xsl:if test=""string($var:v40)='true'"">
          <ns0:metarf11>
            <xsl:attribute name=""xsi:nil"">
              <xsl:value-of select=""'true'"" />
            </xsl:attribute>
          </ns0:metarf11>
        </xsl:if>
        <xsl:if test=""string($var:v40)='false'"">
          <ns0:metarf11>
            <xsl:value-of select=""Meta_RF11/text()"" />
          </ns0:metarf11>
        </xsl:if>
      </xsl:if>
      <xsl:if test=""Meta_RF12"">
        <xsl:variable name=""var:v41"" select=""string(Meta_RF12/@xsi:nil) = 'true'"" />
        <xsl:if test=""string($var:v41)='true'"">
          <ns0:metarf12>
            <xsl:attribute name=""xsi:nil"">
              <xsl:value-of select=""'true'"" />
            </xsl:attribute>
          </ns0:metarf12>
        </xsl:if>
        <xsl:if test=""string($var:v41)='false'"">
          <ns0:metarf12>
            <xsl:value-of select=""Meta_RF12/text()"" />
          </ns0:metarf12>
        </xsl:if>
      </xsl:if>
      <xsl:if test=""Meta_RF13"">
        <xsl:variable name=""var:v42"" select=""string(Meta_RF13/@xsi:nil) = 'true'"" />
        <xsl:if test=""string($var:v42)='true'"">
          <ns0:metarf13>
            <xsl:attribute name=""xsi:nil"">
              <xsl:value-of select=""'true'"" />
            </xsl:attribute>
          </ns0:metarf13>
        </xsl:if>
        <xsl:if test=""string($var:v42)='false'"">
          <ns0:metarf13>
            <xsl:value-of select=""Meta_RF13/text()"" />
          </ns0:metarf13>
        </xsl:if>
      </xsl:if>
      <xsl:if test=""Meta_RF14"">
        <xsl:variable name=""var:v43"" select=""string(Meta_RF14/@xsi:nil) = 'true'"" />
        <xsl:if test=""string($var:v43)='true'"">
          <ns0:metarf14>
            <xsl:attribute name=""xsi:nil"">
              <xsl:value-of select=""'true'"" />
            </xsl:attribute>
          </ns0:metarf14>
        </xsl:if>
        <xsl:if test=""string($var:v43)='false'"">
          <ns0:metarf14>
            <xsl:value-of select=""Meta_RF14/text()"" />
          </ns0:metarf14>
        </xsl:if>
      </xsl:if>
      <xsl:if test=""Meta_RF15"">
        <xsl:variable name=""var:v44"" select=""string(Meta_RF15/@xsi:nil) = 'true'"" />
        <xsl:if test=""string($var:v44)='true'"">
          <ns0:metarf15>
            <xsl:attribute name=""xsi:nil"">
              <xsl:value-of select=""'true'"" />
            </xsl:attribute>
          </ns0:metarf15>
        </xsl:if>
        <xsl:if test=""string($var:v44)='false'"">
          <ns0:metarf15>
            <xsl:value-of select=""Meta_RF15/text()"" />
          </ns0:metarf15>
        </xsl:if>
      </xsl:if>
      <ns0:metarf21>
        <xsl:value-of select=""Meta_RF21/text()"" />
      </ns0:metarf21>
      <xsl:value-of select=""./text()"" />
    </ns0:Biz_Import_Case_Update>
  </xsl:template>
</xsl:stylesheet>";
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"MFM.Lbg.Schemas.MFMWorkItemUpdate";
        
        private const global::MFM.Lbg.Schemas.MFMWorkItemUpdate _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"MFM.Lbg.Schemas.VFM_UPDTypedProcedure_dbo+Biz_Import_Case_Update";
        
        private const global::MFM.Lbg.Schemas.VFM_UPDTypedProcedure_dbo.Biz_Import_Case_Update _trgSchemaTypeReference0 = null;
        
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
                _TrgSchemas[0] = @"MFM.Lbg.Schemas.VFM_UPDTypedProcedure_dbo+Biz_Import_Case_Update";
                return _TrgSchemas;
            }
        }
    }
}
