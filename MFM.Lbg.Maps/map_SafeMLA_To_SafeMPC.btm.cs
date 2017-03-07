namespace MFM.Lbg.Maps {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"MFM.Lbg.Schemas.SAFEUPDPOLLMLATypedPolling_biz_poll_visit_updates_MLA+TypedPollingResultSet0", typeof(global::MFM.Lbg.Schemas.SAFEUPDPOLLMLATypedPolling_biz_poll_visit_updates_MLA.TypedPollingResultSet0))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"MFM.Lbg.Schemas.SAFEUPDPOLLTypedPolling_biz_Poll_Visit_Updates_MPC+TypedPollingResultSet0", typeof(global::MFM.Lbg.Schemas.SAFEUPDPOLLTypedPolling_biz_Poll_Visit_Updates_MPC.TypedPollingResultSet0))]
    public sealed class map_SafeMLA_To_SafeMPC : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0"" version=""1.0"" xmlns:s0=""http://schemas.microsoft.com/Sql/2008/05/TypedPolling/biz_poll_visit_updates_MLA"" xmlns:ns0=""http://schemas.microsoft.com/Sql/2008/05/TypedPolling/biz_Poll_Visit_Updates_MPC"" xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:TypedPollingResultSet0"" />
  </xsl:template>
  <xsl:template match=""/s0:TypedPollingResultSet0"">
    <ns0:TypedPollingResultSet0>
      <xsl:if test=""s0:OutboundId"">
        <xsl:variable name=""var:v1"" select=""string(s0:OutboundId/@xsi:nil) = 'true'"" />
        <xsl:if test=""string($var:v1)='true'"">
          <ns0:OutboundId>
            <xsl:attribute name=""xsi:nil"">
              <xsl:value-of select=""'true'"" />
            </xsl:attribute>
          </ns0:OutboundId>
        </xsl:if>
        <xsl:if test=""string($var:v1)='false'"">
          <ns0:OutboundId>
            <xsl:value-of select=""s0:OutboundId/text()"" />
          </ns0:OutboundId>
        </xsl:if>
      </xsl:if>
      <xsl:if test=""s0:OutboundTs"">
        <xsl:variable name=""var:v2"" select=""string(s0:OutboundTs/@xsi:nil) = 'true'"" />
        <xsl:if test=""string($var:v2)='true'"">
          <ns0:OutboundTs>
            <xsl:attribute name=""xsi:nil"">
              <xsl:value-of select=""'true'"" />
            </xsl:attribute>
          </ns0:OutboundTs>
        </xsl:if>
        <xsl:if test=""string($var:v2)='false'"">
          <ns0:OutboundTs>
            <xsl:value-of select=""s0:OutboundTs/text()"" />
          </ns0:OutboundTs>
        </xsl:if>
      </xsl:if>
      <xsl:if test=""s0:VisitId"">
        <xsl:variable name=""var:v3"" select=""string(s0:VisitId/@xsi:nil) = 'true'"" />
        <xsl:if test=""string($var:v3)='true'"">
          <ns0:VisitId>
            <xsl:attribute name=""xsi:nil"">
              <xsl:value-of select=""'true'"" />
            </xsl:attribute>
          </ns0:VisitId>
        </xsl:if>
        <xsl:if test=""string($var:v3)='false'"">
          <ns0:VisitId>
            <xsl:value-of select=""s0:VisitId/text()"" />
          </ns0:VisitId>
        </xsl:if>
      </xsl:if>
      <xsl:if test=""s0:CustomerReference"">
        <xsl:variable name=""var:v4"" select=""string(s0:CustomerReference/@xsi:nil) = 'true'"" />
        <xsl:if test=""string($var:v4)='true'"">
          <ns0:CustomerReference>
            <xsl:attribute name=""xsi:nil"">
              <xsl:value-of select=""'true'"" />
            </xsl:attribute>
          </ns0:CustomerReference>
        </xsl:if>
        <xsl:if test=""string($var:v4)='false'"">
          <ns0:CustomerReference>
            <xsl:value-of select=""s0:CustomerReference/text()"" />
          </ns0:CustomerReference>
        </xsl:if>
      </xsl:if>
      <xsl:if test=""s0:DateInput"">
        <xsl:variable name=""var:v5"" select=""string(s0:DateInput/@xsi:nil) = 'true'"" />
        <xsl:if test=""string($var:v5)='true'"">
          <ns0:DateInput>
            <xsl:attribute name=""xsi:nil"">
              <xsl:value-of select=""'true'"" />
            </xsl:attribute>
          </ns0:DateInput>
        </xsl:if>
        <xsl:if test=""string($var:v5)='false'"">
          <ns0:DateInput>
            <xsl:value-of select=""s0:DateInput/text()"" />
          </ns0:DateInput>
        </xsl:if>
      </xsl:if>
      <xsl:if test=""s0:DateLastModified"">
        <xsl:variable name=""var:v6"" select=""string(s0:DateLastModified/@xsi:nil) = 'true'"" />
        <xsl:if test=""string($var:v6)='true'"">
          <ns0:DateLastModified>
            <xsl:attribute name=""xsi:nil"">
              <xsl:value-of select=""'true'"" />
            </xsl:attribute>
          </ns0:DateLastModified>
        </xsl:if>
        <xsl:if test=""string($var:v6)='false'"">
          <ns0:DateLastModified>
            <xsl:value-of select=""s0:DateLastModified/text()"" />
          </ns0:DateLastModified>
        </xsl:if>
      </xsl:if>
      <xsl:if test=""s0:DateCalledIn"">
        <xsl:variable name=""var:v7"" select=""string(s0:DateCalledIn/@xsi:nil) = 'true'"" />
        <xsl:if test=""string($var:v7)='true'"">
          <ns0:DateCalledIn>
            <xsl:attribute name=""xsi:nil"">
              <xsl:value-of select=""'true'"" />
            </xsl:attribute>
          </ns0:DateCalledIn>
        </xsl:if>
        <xsl:if test=""string($var:v7)='false'"">
          <ns0:DateCalledIn>
            <xsl:value-of select=""s0:DateCalledIn/text()"" />
          </ns0:DateCalledIn>
        </xsl:if>
      </xsl:if>
      <xsl:if test=""s0:DateConfirmed"">
        <xsl:variable name=""var:v8"" select=""string(s0:DateConfirmed/@xsi:nil) = 'true'"" />
        <xsl:if test=""string($var:v8)='true'"">
          <ns0:DateConfirmed>
            <xsl:attribute name=""xsi:nil"">
              <xsl:value-of select=""'true'"" />
            </xsl:attribute>
          </ns0:DateConfirmed>
        </xsl:if>
        <xsl:if test=""string($var:v8)='false'"">
          <ns0:DateConfirmed>
            <xsl:value-of select=""s0:DateConfirmed/text()"" />
          </ns0:DateConfirmed>
        </xsl:if>
      </xsl:if>
      <xsl:if test=""s0:DateServiceStart"">
        <xsl:variable name=""var:v9"" select=""string(s0:DateServiceStart/@xsi:nil) = 'true'"" />
        <xsl:if test=""string($var:v9)='true'"">
          <ns0:DateServiceStart>
            <xsl:attribute name=""xsi:nil"">
              <xsl:value-of select=""'true'"" />
            </xsl:attribute>
          </ns0:DateServiceStart>
        </xsl:if>
        <xsl:if test=""string($var:v9)='false'"">
          <ns0:DateServiceStart>
            <xsl:value-of select=""s0:DateServiceStart/text()"" />
          </ns0:DateServiceStart>
        </xsl:if>
      </xsl:if>
      <xsl:if test=""s0:DateServiceEnd"">
        <xsl:variable name=""var:v10"" select=""string(s0:DateServiceEnd/@xsi:nil) = 'true'"" />
        <xsl:if test=""string($var:v10)='true'"">
          <ns0:DateServiceEnd>
            <xsl:attribute name=""xsi:nil"">
              <xsl:value-of select=""'true'"" />
            </xsl:attribute>
          </ns0:DateServiceEnd>
        </xsl:if>
        <xsl:if test=""string($var:v10)='false'"">
          <ns0:DateServiceEnd>
            <xsl:value-of select=""s0:DateServiceEnd/text()"" />
          </ns0:DateServiceEnd>
        </xsl:if>
      </xsl:if>
      <xsl:if test=""s0:Deleted"">
        <xsl:variable name=""var:v11"" select=""string(s0:Deleted/@xsi:nil) = 'true'"" />
        <xsl:if test=""string($var:v11)='true'"">
          <ns0:Deleted>
            <xsl:attribute name=""xsi:nil"">
              <xsl:value-of select=""'true'"" />
            </xsl:attribute>
          </ns0:Deleted>
        </xsl:if>
        <xsl:if test=""string($var:v11)='false'"">
          <ns0:Deleted>
            <xsl:value-of select=""s0:Deleted/text()"" />
          </ns0:Deleted>
        </xsl:if>
      </xsl:if>
      <xsl:if test=""s0:CallOutDetails"">
        <xsl:variable name=""var:v12"" select=""string(s0:CallOutDetails/@xsi:nil) = 'true'"" />
        <xsl:if test=""string($var:v12)='true'"">
          <ns0:CallOutDetails>
            <xsl:attribute name=""xsi:nil"">
              <xsl:value-of select=""'true'"" />
            </xsl:attribute>
          </ns0:CallOutDetails>
        </xsl:if>
        <xsl:if test=""string($var:v12)='false'"">
          <ns0:CallOutDetails>
            <xsl:value-of select=""s0:CallOutDetails/text()"" />
          </ns0:CallOutDetails>
        </xsl:if>
      </xsl:if>
      <xsl:if test=""s0:PostCallOutDetails"">
        <xsl:variable name=""var:v13"" select=""string(s0:PostCallOutDetails/@xsi:nil) = 'true'"" />
        <xsl:if test=""string($var:v13)='true'"">
          <ns0:PostCallOutDetails>
            <xsl:attribute name=""xsi:nil"">
              <xsl:value-of select=""'true'"" />
            </xsl:attribute>
          </ns0:PostCallOutDetails>
        </xsl:if>
        <xsl:if test=""string($var:v13)='false'"">
          <ns0:PostCallOutDetails>
            <xsl:value-of select=""s0:PostCallOutDetails/text()"" />
          </ns0:PostCallOutDetails>
        </xsl:if>
      </xsl:if>
      <xsl:if test=""s0:VisitTypeRef"">
        <xsl:variable name=""var:v14"" select=""string(s0:VisitTypeRef/@xsi:nil) = 'true'"" />
        <xsl:if test=""string($var:v14)='true'"">
          <ns0:VisitTypeRef>
            <xsl:attribute name=""xsi:nil"">
              <xsl:value-of select=""'true'"" />
            </xsl:attribute>
          </ns0:VisitTypeRef>
        </xsl:if>
        <xsl:if test=""string($var:v14)='false'"">
          <ns0:VisitTypeRef>
            <xsl:value-of select=""s0:VisitTypeRef/text()"" />
          </ns0:VisitTypeRef>
        </xsl:if>
      </xsl:if>
      <xsl:if test=""s0:ServiceTypeRef"">
        <xsl:variable name=""var:v15"" select=""string(s0:ServiceTypeRef/@xsi:nil) = 'true'"" />
        <xsl:if test=""string($var:v15)='true'"">
          <ns0:ServiceTypeRef>
            <xsl:attribute name=""xsi:nil"">
              <xsl:value-of select=""'true'"" />
            </xsl:attribute>
          </ns0:ServiceTypeRef>
        </xsl:if>
        <xsl:if test=""string($var:v15)='false'"">
          <ns0:ServiceTypeRef>
            <xsl:value-of select=""s0:ServiceTypeRef/text()"" />
          </ns0:ServiceTypeRef>
        </xsl:if>
      </xsl:if>
      <xsl:if test=""s0:LastModifiedBy"">
        <xsl:variable name=""var:v16"" select=""string(s0:LastModifiedBy/@xsi:nil) = 'true'"" />
        <xsl:if test=""string($var:v16)='true'"">
          <ns0:LastModifiedBy>
            <xsl:attribute name=""xsi:nil"">
              <xsl:value-of select=""'true'"" />
            </xsl:attribute>
          </ns0:LastModifiedBy>
        </xsl:if>
        <xsl:if test=""string($var:v16)='false'"">
          <ns0:LastModifiedBy>
            <xsl:value-of select=""s0:LastModifiedBy/text()"" />
          </ns0:LastModifiedBy>
        </xsl:if>
      </xsl:if>
      <xsl:if test=""s0:Callout"">
        <xsl:variable name=""var:v17"" select=""string(s0:Callout/@xsi:nil) = 'true'"" />
        <xsl:if test=""string($var:v17)='true'"">
          <ns0:Callout>
            <xsl:attribute name=""xsi:nil"">
              <xsl:value-of select=""'true'"" />
            </xsl:attribute>
          </ns0:Callout>
        </xsl:if>
        <xsl:if test=""string($var:v17)='false'"">
          <ns0:Callout>
            <xsl:value-of select=""s0:Callout/text()"" />
          </ns0:Callout>
        </xsl:if>
      </xsl:if>
      <xsl:if test=""s0:Urgent"">
        <xsl:variable name=""var:v18"" select=""string(s0:Urgent/@xsi:nil) = 'true'"" />
        <xsl:if test=""string($var:v18)='true'"">
          <ns0:Urgent>
            <xsl:attribute name=""xsi:nil"">
              <xsl:value-of select=""'true'"" />
            </xsl:attribute>
          </ns0:Urgent>
        </xsl:if>
        <xsl:if test=""string($var:v18)='false'"">
          <ns0:Urgent>
            <xsl:value-of select=""s0:Urgent/text()"" />
          </ns0:Urgent>
        </xsl:if>
      </xsl:if>
      <xsl:if test=""s0:Chargeable"">
        <xsl:variable name=""var:v19"" select=""string(s0:Chargeable/@xsi:nil) = 'true'"" />
        <xsl:if test=""string($var:v19)='true'"">
          <ns0:Chargeable>
            <xsl:attribute name=""xsi:nil"">
              <xsl:value-of select=""'true'"" />
            </xsl:attribute>
          </ns0:Chargeable>
        </xsl:if>
        <xsl:if test=""string($var:v19)='false'"">
          <ns0:Chargeable>
            <xsl:value-of select=""s0:Chargeable/text()"" />
          </ns0:Chargeable>
        </xsl:if>
      </xsl:if>
      <xsl:if test=""s0:Routine"">
        <xsl:variable name=""var:v20"" select=""string(s0:Routine/@xsi:nil) = 'true'"" />
        <xsl:if test=""string($var:v20)='true'"">
          <ns0:Routine>
            <xsl:attribute name=""xsi:nil"">
              <xsl:value-of select=""'true'"" />
            </xsl:attribute>
          </ns0:Routine>
        </xsl:if>
        <xsl:if test=""string($var:v20)='false'"">
          <ns0:Routine>
            <xsl:value-of select=""s0:Routine/text()"" />
          </ns0:Routine>
        </xsl:if>
      </xsl:if>
      <xsl:if test=""s0:Address1"">
        <xsl:variable name=""var:v21"" select=""string(s0:Address1/@xsi:nil) = 'true'"" />
        <xsl:if test=""string($var:v21)='true'"">
          <ns0:Address1>
            <xsl:attribute name=""xsi:nil"">
              <xsl:value-of select=""'true'"" />
            </xsl:attribute>
          </ns0:Address1>
        </xsl:if>
        <xsl:if test=""string($var:v21)='false'"">
          <ns0:Address1>
            <xsl:value-of select=""s0:Address1/text()"" />
          </ns0:Address1>
        </xsl:if>
      </xsl:if>
      <xsl:if test=""s0:Address2"">
        <xsl:variable name=""var:v22"" select=""string(s0:Address2/@xsi:nil) = 'true'"" />
        <xsl:if test=""string($var:v22)='true'"">
          <ns0:Address2>
            <xsl:attribute name=""xsi:nil"">
              <xsl:value-of select=""'true'"" />
            </xsl:attribute>
          </ns0:Address2>
        </xsl:if>
        <xsl:if test=""string($var:v22)='false'"">
          <ns0:Address2>
            <xsl:value-of select=""s0:Address2/text()"" />
          </ns0:Address2>
        </xsl:if>
      </xsl:if>
      <xsl:if test=""s0:Address3"">
        <xsl:variable name=""var:v23"" select=""string(s0:Address3/@xsi:nil) = 'true'"" />
        <xsl:if test=""string($var:v23)='true'"">
          <ns0:Address3>
            <xsl:attribute name=""xsi:nil"">
              <xsl:value-of select=""'true'"" />
            </xsl:attribute>
          </ns0:Address3>
        </xsl:if>
        <xsl:if test=""string($var:v23)='false'"">
          <ns0:Address3>
            <xsl:value-of select=""s0:Address3/text()"" />
          </ns0:Address3>
        </xsl:if>
      </xsl:if>
      <xsl:if test=""s0:Postcode"">
        <xsl:variable name=""var:v24"" select=""string(s0:Postcode/@xsi:nil) = 'true'"" />
        <xsl:if test=""string($var:v24)='true'"">
          <ns0:Postcode>
            <xsl:attribute name=""xsi:nil"">
              <xsl:value-of select=""'true'"" />
            </xsl:attribute>
          </ns0:Postcode>
        </xsl:if>
        <xsl:if test=""string($var:v24)='false'"">
          <ns0:Postcode>
            <xsl:value-of select=""s0:Postcode/text()"" />
          </ns0:Postcode>
        </xsl:if>
      </xsl:if>
      <xsl:if test=""s0:CustomerReference2"">
        <xsl:variable name=""var:v25"" select=""string(s0:CustomerReference2/@xsi:nil) = 'true'"" />
        <xsl:if test=""string($var:v25)='true'"">
          <ns0:CustomerReference2>
            <xsl:attribute name=""xsi:nil"">
              <xsl:value-of select=""'true'"" />
            </xsl:attribute>
          </ns0:CustomerReference2>
        </xsl:if>
        <xsl:if test=""string($var:v25)='false'"">
          <ns0:CustomerReference2>
            <xsl:value-of select=""s0:CustomerReference2/text()"" />
          </ns0:CustomerReference2>
        </xsl:if>
      </xsl:if>
      <xsl:if test=""s0:OrderNumber"">
        <xsl:variable name=""var:v26"" select=""string(s0:OrderNumber/@xsi:nil) = 'true'"" />
        <xsl:if test=""string($var:v26)='true'"">
          <ns0:OrderNumber>
            <xsl:attribute name=""xsi:nil"">
              <xsl:value-of select=""'true'"" />
            </xsl:attribute>
          </ns0:OrderNumber>
        </xsl:if>
        <xsl:if test=""string($var:v26)='false'"">
          <ns0:OrderNumber>
            <xsl:value-of select=""s0:OrderNumber/text()"" />
          </ns0:OrderNumber>
        </xsl:if>
      </xsl:if>
      <xsl:if test=""s0:Queued"">
        <xsl:variable name=""var:v27"" select=""string(s0:Queued/@xsi:nil) = 'true'"" />
        <xsl:if test=""string($var:v27)='true'"">
          <ns0:Queued>
            <xsl:attribute name=""xsi:nil"">
              <xsl:value-of select=""'true'"" />
            </xsl:attribute>
          </ns0:Queued>
        </xsl:if>
        <xsl:if test=""string($var:v27)='false'"">
          <ns0:Queued>
            <xsl:value-of select=""s0:Queued/text()"" />
          </ns0:Queued>
        </xsl:if>
      </xsl:if>
      <xsl:if test=""s0:LastMessageTs"">
        <xsl:variable name=""var:v28"" select=""string(s0:LastMessageTs/@xsi:nil) = 'true'"" />
        <xsl:if test=""string($var:v28)='true'"">
          <ns0:LastMessageTs>
            <xsl:attribute name=""xsi:nil"">
              <xsl:value-of select=""'true'"" />
            </xsl:attribute>
          </ns0:LastMessageTs>
        </xsl:if>
        <xsl:if test=""string($var:v28)='false'"">
          <ns0:LastMessageTs>
            <xsl:value-of select=""s0:LastMessageTs/text()"" />
          </ns0:LastMessageTs>
        </xsl:if>
      </xsl:if>
      <xsl:if test=""s0:MessageCount"">
        <xsl:variable name=""var:v29"" select=""string(s0:MessageCount/@xsi:nil) = 'true'"" />
        <xsl:if test=""string($var:v29)='true'"">
          <ns0:MessageCount>
            <xsl:attribute name=""xsi:nil"">
              <xsl:value-of select=""'true'"" />
            </xsl:attribute>
          </ns0:MessageCount>
        </xsl:if>
        <xsl:if test=""string($var:v29)='false'"">
          <ns0:MessageCount>
            <xsl:value-of select=""s0:MessageCount/text()"" />
          </ns0:MessageCount>
        </xsl:if>
      </xsl:if>
      <xsl:if test=""s0:result"">
        <xsl:variable name=""var:v30"" select=""string(s0:result/@xsi:nil) = 'true'"" />
        <xsl:if test=""string($var:v30)='true'"">
          <ns0:result>
            <xsl:attribute name=""xsi:nil"">
              <xsl:value-of select=""'true'"" />
            </xsl:attribute>
          </ns0:result>
        </xsl:if>
        <xsl:if test=""string($var:v30)='false'"">
          <ns0:result>
            <xsl:value-of select=""s0:result/text()"" />
          </ns0:result>
        </xsl:if>
      </xsl:if>
      <xsl:if test=""s0:VisitTypeDesc"">
        <ns0:VisitTypeDesc>
          <xsl:value-of select=""s0:VisitTypeDesc/text()"" />
        </ns0:VisitTypeDesc>
      </xsl:if>
      <xsl:if test=""s0:Business"">
        <ns0:Business>
          <xsl:value-of select=""s0:Business/text()"" />
        </ns0:Business>
      </xsl:if>
    </ns0:TypedPollingResultSet0>
  </xsl:template>
</xsl:stylesheet>";
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"MFM.Lbg.Schemas.SAFEUPDPOLLMLATypedPolling_biz_poll_visit_updates_MLA+TypedPollingResultSet0";
        
        private const global::MFM.Lbg.Schemas.SAFEUPDPOLLMLATypedPolling_biz_poll_visit_updates_MLA.TypedPollingResultSet0 _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"MFM.Lbg.Schemas.SAFEUPDPOLLTypedPolling_biz_Poll_Visit_Updates_MPC+TypedPollingResultSet0";
        
        private const global::MFM.Lbg.Schemas.SAFEUPDPOLLTypedPolling_biz_Poll_Visit_Updates_MPC.TypedPollingResultSet0 _trgSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"MFM.Lbg.Schemas.SAFEUPDPOLLMLATypedPolling_biz_poll_visit_updates_MLA+TypedPollingResultSet0";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"MFM.Lbg.Schemas.SAFEUPDPOLLTypedPolling_biz_Poll_Visit_Updates_MPC+TypedPollingResultSet0";
                return _TrgSchemas;
            }
        }
    }
}
