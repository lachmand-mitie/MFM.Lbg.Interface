namespace MFM.Lbg.Orcs {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"MFM.Lbg.Schemas.DistibutedWorkItems", typeof(global::MFM.Lbg.Schemas.DistibutedWorkItems))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"MFM.Lbg.Orcs.GenItems.MTFMVISIONFM_MTFMVISIONLOCQUERY_www_ibm_com_maximo+QueryMXVISIONLOCQUERYResponse", typeof(global::MFM.Lbg.Orcs.GenItems.MTFMVISIONFM_MTFMVISIONLOCQUERY_www_ibm_com_maximo.QueryMXVISIONLOCQUERYResponse))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"MFM.Lbg.Schemas.DistibutedWorkItems", typeof(global::MFM.Lbg.Schemas.DistibutedWorkItems))]
    public sealed class x_to_WO_F : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s1 s0 userCSharp"" version=""1.0"" xmlns:ns6=""http://MFMSharedResources/Types/Helpdesk/v1/MSurveySet"" xmlns:ns1=""http://MFMSharedResources/Types/Helpdesk/v1/IssuedWork"" xmlns:ns7=""http://MFMSharedResources/Types/Helpdesk/v1/MSurveyQuestion"" xmlns:ns10=""http://MFMSharedResources/Types/Helpdesk/v1/Customer"" xmlns:ns2=""http://MFMSharedResources/Types/Helpdesk/v1/Vendor"" xmlns:s1=""http://schemas.microsoft.com/BizTalk/2003/aggschema"" xmlns:ns0=""http://MFM.Lbg.Schemas.DistibutedWorkItems"" xmlns:ns4=""http://MFMSharedResources/Types/Helpdesk/v1/Person"" xmlns:ns11=""http://MFMSharedResources/Types/Helpdesk/v1/MSurvey"" xmlns:ns9=""http://MFMSharedResources/Types/Helpdesk/v1/Workitem"" xmlns:s0=""http://www.ibm.com/maximo"" xmlns:ns5=""http://MFMSharedResources/Types/Helpdesk/v1/Location"" xmlns:ns12=""http://MFMSharedResources/Types/Helpdesk/v1/Service"" xmlns:ns3=""http://MFMSharedResources/Types/Helpdesk/v1/MRouting"" xmlns:ns8=""http://MFMSharedResources/Types/Helpdesk/v1/Address"" xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s1:Root"" />
  </xsl:template>
  <xsl:template match=""/s1:Root"">
    <ns0:DistributedWorkItems>
      <ns1:IssuedWork>
        <ns3:MRoute>
          <CustomerName>
            <xsl:value-of select=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns3:MRoute/CustomerName/text()"" />
          </CustomerName>
          <VendorName>
            <xsl:value-of select=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns3:MRoute/VendorName/text()"" />
          </VendorName>
          <VendorDivision>
            <xsl:value-of select=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns3:MRoute/VendorDivision/text()"" />
          </VendorDivision>
          <ContractName>
            <xsl:value-of select=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns3:MRoute/ContractName/text()"" />
          </ContractName>
          <InterfaceIdentifier>
            <xsl:value-of select=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns3:MRoute/InterfaceIdentifier/text()"" />
          </InterfaceIdentifier>
          <ServiceLineType>
            <xsl:value-of select=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns3:MRoute/ServiceLineType/text()"" />
          </ServiceLineType>
          <BizTalkCBR>
            <xsl:value-of select=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns3:MRoute/BizTalkCBR/text()"" />
          </BizTalkCBR>
          <xsl:variable name=""var:v1"" select=""string(InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns3:MRoute/InterfaceEnabled/@xsi:nil) = 'true'"" />
          <xsl:if test=""string($var:v1)='true'"">
            <InterfaceEnabled>
              <xsl:attribute name=""xsi:nil"">
                <xsl:value-of select=""'true'"" />
              </xsl:attribute>
            </InterfaceEnabled>
          </xsl:if>
          <xsl:if test=""string($var:v1)='false'"">
            <InterfaceEnabled>
              <xsl:value-of select=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns3:MRoute/InterfaceEnabled/text()"" />
            </InterfaceEnabled>
          </xsl:if>
          <xsl:variable name=""var:v2"" select=""string(InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns3:MRoute/SAPEnabled/@xsi:nil) = 'true'"" />
          <xsl:if test=""string($var:v2)='true'"">
            <SAPEnabled>
              <xsl:attribute name=""xsi:nil"">
                <xsl:value-of select=""'true'"" />
              </xsl:attribute>
            </SAPEnabled>
          </xsl:if>
          <xsl:if test=""string($var:v2)='false'"">
            <SAPEnabled>
              <xsl:value-of select=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns3:MRoute/SAPEnabled/text()"" />
            </SAPEnabled>
          </xsl:if>
        </ns3:MRoute>
        <ns2:Vendor>
          <xsl:if test=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns2:Vendor/@vendorDivisionid"">
            <xsl:attribute name=""vendorDivisionid"">
              <xsl:value-of select=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns2:Vendor/@vendorDivisionid"" />
            </xsl:attribute>
          </xsl:if>
          <vendorid>
            <xsl:value-of select=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns2:Vendor/vendorid/text()"" />
          </vendorid>
          <vendorDivisionname>
            <xsl:value-of select=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns2:Vendor/vendorDivisionname/text()"" />
          </vendorDivisionname>
          <vendorName>
            <xsl:value-of select=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns2:Vendor/vendorName/text()"" />
          </vendorName>
          <ns5:Location>
            <xsl:if test=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns2:Vendor/ns5:Location/@linkid"">
              <xsl:attribute name=""linkid"">
                <xsl:value-of select=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns2:Vendor/ns5:Location/@linkid"" />
              </xsl:attribute>
            </xsl:if>
            <xsl:if test=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns2:Vendor/ns5:Location/linkcompany"">
              <linkcompany>
                <xsl:value-of select=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns2:Vendor/ns5:Location/linkcompany/text()"" />
              </linkcompany>
            </xsl:if>
            <xsl:if test=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns2:Vendor/ns5:Location/linkperson"">
              <xsl:variable name=""var:v3"" select=""string(InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns2:Vendor/ns5:Location/linkperson/@xsi:nil) = 'true'"" />
              <xsl:if test=""string($var:v3)='true'"">
                <linkperson>
                  <xsl:attribute name=""xsi:nil"">
                    <xsl:value-of select=""'true'"" />
                  </xsl:attribute>
                </linkperson>
              </xsl:if>
              <xsl:if test=""string($var:v3)='false'"">
                <linkperson>
                  <xsl:value-of select=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns2:Vendor/ns5:Location/linkperson/text()"" />
                </linkperson>
              </xsl:if>
            </xsl:if>
            <xsl:if test=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns2:Vendor/ns5:Location/linktype"">
              <xsl:variable name=""var:v4"" select=""string(InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns2:Vendor/ns5:Location/linktype/@xsi:nil) = 'true'"" />
              <xsl:if test=""string($var:v4)='true'"">
                <linktype>
                  <xsl:attribute name=""xsi:nil"">
                    <xsl:value-of select=""'true'"" />
                  </xsl:attribute>
                </linktype>
              </xsl:if>
              <xsl:if test=""string($var:v4)='false'"">
                <linktype>
                  <xsl:value-of select=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns2:Vendor/ns5:Location/linktype/text()"" />
                </linktype>
              </xsl:if>
            </xsl:if>
            <xsl:if test=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns2:Vendor/ns5:Location/linkdivisionid"">
              <xsl:variable name=""var:v5"" select=""string(InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns2:Vendor/ns5:Location/linkdivisionid/@xsi:nil) = 'true'"" />
              <xsl:if test=""string($var:v5)='true'"">
                <linkdivisionid>
                  <xsl:attribute name=""xsi:nil"">
                    <xsl:value-of select=""'true'"" />
                  </xsl:attribute>
                </linkdivisionid>
              </xsl:if>
              <xsl:if test=""string($var:v5)='false'"">
                <linkdivisionid>
                  <xsl:value-of select=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns2:Vendor/ns5:Location/linkdivisionid/text()"" />
                </linkdivisionid>
              </xsl:if>
            </xsl:if>
            <xsl:if test=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns2:Vendor/ns5:Location/linkregionid"">
              <xsl:variable name=""var:v6"" select=""string(InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns2:Vendor/ns5:Location/linkregionid/@xsi:nil) = 'true'"" />
              <xsl:if test=""string($var:v6)='true'"">
                <linkregionid>
                  <xsl:attribute name=""xsi:nil"">
                    <xsl:value-of select=""'true'"" />
                  </xsl:attribute>
                </linkregionid>
              </xsl:if>
              <xsl:if test=""string($var:v6)='false'"">
                <linkregionid>
                  <xsl:value-of select=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns2:Vendor/ns5:Location/linkregionid/text()"" />
                </linkregionid>
              </xsl:if>
            </xsl:if>
            <xsl:if test=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns2:Vendor/ns5:Location/linkcampusid"">
              <xsl:variable name=""var:v7"" select=""string(InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns2:Vendor/ns5:Location/linkcampusid/@xsi:nil) = 'true'"" />
              <xsl:if test=""string($var:v7)='true'"">
                <linkcampusid>
                  <xsl:attribute name=""xsi:nil"">
                    <xsl:value-of select=""'true'"" />
                  </xsl:attribute>
                </linkcampusid>
              </xsl:if>
              <xsl:if test=""string($var:v7)='false'"">
                <linkcampusid>
                  <xsl:value-of select=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns2:Vendor/ns5:Location/linkcampusid/text()"" />
                </linkcampusid>
              </xsl:if>
            </xsl:if>
            <xsl:if test=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns2:Vendor/ns5:Location/linkareaid"">
              <xsl:variable name=""var:v8"" select=""string(InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns2:Vendor/ns5:Location/linkareaid/@xsi:nil) = 'true'"" />
              <xsl:if test=""string($var:v8)='true'"">
                <linkareaid>
                  <xsl:attribute name=""xsi:nil"">
                    <xsl:value-of select=""'true'"" />
                  </xsl:attribute>
                </linkareaid>
              </xsl:if>
              <xsl:if test=""string($var:v8)='false'"">
                <linkareaid>
                  <xsl:value-of select=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns2:Vendor/ns5:Location/linkareaid/text()"" />
                </linkareaid>
              </xsl:if>
            </xsl:if>
            <xsl:if test=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns2:Vendor/ns5:Location/linkstart"">
              <xsl:variable name=""var:v9"" select=""string(InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns2:Vendor/ns5:Location/linkstart/@xsi:nil) = 'true'"" />
              <xsl:if test=""string($var:v9)='true'"">
                <linkstart>
                  <xsl:attribute name=""xsi:nil"">
                    <xsl:value-of select=""'true'"" />
                  </xsl:attribute>
                </linkstart>
              </xsl:if>
              <xsl:if test=""string($var:v9)='false'"">
                <linkstart>
                  <xsl:value-of select=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns2:Vendor/ns5:Location/linkstart/text()"" />
                </linkstart>
              </xsl:if>
            </xsl:if>
            <xsl:if test=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns2:Vendor/ns5:Location/linkend"">
              <xsl:variable name=""var:v10"" select=""string(InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns2:Vendor/ns5:Location/linkend/@xsi:nil) = 'true'"" />
              <xsl:if test=""string($var:v10)='true'"">
                <linkend>
                  <xsl:attribute name=""xsi:nil"">
                    <xsl:value-of select=""'true'"" />
                  </xsl:attribute>
                </linkend>
              </xsl:if>
              <xsl:if test=""string($var:v10)='false'"">
                <linkend>
                  <xsl:value-of select=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns2:Vendor/ns5:Location/linkend/text()"" />
                </linkend>
              </xsl:if>
            </xsl:if>
            <xsl:if test=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns2:Vendor/ns5:Location/linkcn"">
              <xsl:variable name=""var:v11"" select=""string(InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns2:Vendor/ns5:Location/linkcn/@xsi:nil) = 'true'"" />
              <xsl:if test=""string($var:v11)='true'"">
                <linkcn>
                  <xsl:attribute name=""xsi:nil"">
                    <xsl:value-of select=""'true'"" />
                  </xsl:attribute>
                </linkcn>
              </xsl:if>
              <xsl:if test=""string($var:v11)='false'"">
                <linkcn>
                  <xsl:value-of select=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns2:Vendor/ns5:Location/linkcn/text()"" />
                </linkcn>
              </xsl:if>
            </xsl:if>
            <xsl:if test=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns2:Vendor/ns5:Location/linkpropertyid"">
              <xsl:variable name=""var:v12"" select=""string(InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns2:Vendor/ns5:Location/linkpropertyid/@xsi:nil) = 'true'"" />
              <xsl:if test=""string($var:v12)='true'"">
                <linkpropertyid>
                  <xsl:attribute name=""xsi:nil"">
                    <xsl:value-of select=""'true'"" />
                  </xsl:attribute>
                </linkpropertyid>
              </xsl:if>
              <xsl:if test=""string($var:v12)='false'"">
                <linkpropertyid>
                  <xsl:value-of select=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns2:Vendor/ns5:Location/linkpropertyid/text()"" />
                </linkpropertyid>
              </xsl:if>
            </xsl:if>
            <xsl:if test=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns2:Vendor/ns5:Location/linkMitiePropertyCode"">
              <xsl:variable name=""var:v13"" select=""string(InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns2:Vendor/ns5:Location/linkMitiePropertyCode/@xsi:nil) = 'true'"" />
              <xsl:if test=""string($var:v13)='true'"">
                <linkMitiePropertyCode>
                  <xsl:attribute name=""xsi:nil"">
                    <xsl:value-of select=""'true'"" />
                  </xsl:attribute>
                </linkMitiePropertyCode>
              </xsl:if>
              <xsl:if test=""string($var:v13)='false'"">
                <linkMitiePropertyCode>
                  <xsl:value-of select=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns2:Vendor/ns5:Location/linkMitiePropertyCode/text()"" />
                </linkMitiePropertyCode>
              </xsl:if>
            </xsl:if>
            <xsl:if test=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns2:Vendor/ns5:Location/linkClientPropertyCode"">
              <xsl:variable name=""var:v14"" select=""string(InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns2:Vendor/ns5:Location/linkClientPropertyCode/@xsi:nil) = 'true'"" />
              <xsl:if test=""string($var:v14)='true'"">
                <linkClientPropertyCode>
                  <xsl:attribute name=""xsi:nil"">
                    <xsl:value-of select=""'true'"" />
                  </xsl:attribute>
                </linkClientPropertyCode>
              </xsl:if>
              <xsl:if test=""string($var:v14)='false'"">
                <linkClientPropertyCode>
                  <xsl:value-of select=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns2:Vendor/ns5:Location/linkClientPropertyCode/text()"" />
                </linkClientPropertyCode>
              </xsl:if>
            </xsl:if>
            <xsl:if test=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns2:Vendor/ns5:Location/linkRegionName"">
              <xsl:variable name=""var:v15"" select=""string(InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns2:Vendor/ns5:Location/linkRegionName/@xsi:nil) = 'true'"" />
              <xsl:if test=""string($var:v15)='true'"">
                <linkRegionName>
                  <xsl:attribute name=""xsi:nil"">
                    <xsl:value-of select=""'true'"" />
                  </xsl:attribute>
                </linkRegionName>
              </xsl:if>
              <xsl:if test=""string($var:v15)='false'"">
                <linkRegionName>
                  <xsl:value-of select=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns2:Vendor/ns5:Location/linkRegionName/text()"" />
                </linkRegionName>
              </xsl:if>
            </xsl:if>
            <xsl:for-each select=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns2:Vendor/ns5:Location/ns8:Address"">
              <ns8:Address>
                <xsl:if test=""@siteid"">
                  <xsl:attribute name=""siteid"">
                    <xsl:value-of select=""@siteid"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:if test=""siteAddress1"">
                  <siteAddress1>
                    <xsl:value-of select=""siteAddress1/text()"" />
                  </siteAddress1>
                </xsl:if>
                <xsl:if test=""siteAddress2"">
                  <xsl:variable name=""var:v16"" select=""string(siteAddress2/@xsi:nil) = 'true'"" />
                  <xsl:if test=""string($var:v16)='true'"">
                    <siteAddress2>
                      <xsl:attribute name=""xsi:nil"">
                        <xsl:value-of select=""'true'"" />
                      </xsl:attribute>
                    </siteAddress2>
                  </xsl:if>
                  <xsl:if test=""string($var:v16)='false'"">
                    <siteAddress2>
                      <xsl:value-of select=""siteAddress2/text()"" />
                    </siteAddress2>
                  </xsl:if>
                </xsl:if>
                <xsl:if test=""siteAddress3"">
                  <xsl:variable name=""var:v17"" select=""string(siteAddress3/@xsi:nil) = 'true'"" />
                  <xsl:if test=""string($var:v17)='true'"">
                    <siteAddress3>
                      <xsl:attribute name=""xsi:nil"">
                        <xsl:value-of select=""'true'"" />
                      </xsl:attribute>
                    </siteAddress3>
                  </xsl:if>
                  <xsl:if test=""string($var:v17)='false'"">
                    <siteAddress3>
                      <xsl:value-of select=""siteAddress3/text()"" />
                    </siteAddress3>
                  </xsl:if>
                </xsl:if>
                <xsl:if test=""siteAddress4"">
                  <xsl:variable name=""var:v18"" select=""string(siteAddress4/@xsi:nil) = 'true'"" />
                  <xsl:if test=""string($var:v18)='true'"">
                    <siteAddress4>
                      <xsl:attribute name=""xsi:nil"">
                        <xsl:value-of select=""'true'"" />
                      </xsl:attribute>
                    </siteAddress4>
                  </xsl:if>
                  <xsl:if test=""string($var:v18)='false'"">
                    <siteAddress4>
                      <xsl:value-of select=""siteAddress4/text()"" />
                    </siteAddress4>
                  </xsl:if>
                </xsl:if>
                <xsl:if test=""siteAddress5"">
                  <xsl:variable name=""var:v19"" select=""string(siteAddress5/@xsi:nil) = 'true'"" />
                  <xsl:if test=""string($var:v19)='true'"">
                    <siteAddress5>
                      <xsl:attribute name=""xsi:nil"">
                        <xsl:value-of select=""'true'"" />
                      </xsl:attribute>
                    </siteAddress5>
                  </xsl:if>
                  <xsl:if test=""string($var:v19)='false'"">
                    <siteAddress5>
                      <xsl:value-of select=""siteAddress5/text()"" />
                    </siteAddress5>
                  </xsl:if>
                </xsl:if>
                <xsl:if test=""siteCity"">
                  <xsl:variable name=""var:v20"" select=""string(siteCity/@xsi:nil) = 'true'"" />
                  <xsl:if test=""string($var:v20)='true'"">
                    <siteCity>
                      <xsl:attribute name=""xsi:nil"">
                        <xsl:value-of select=""'true'"" />
                      </xsl:attribute>
                    </siteCity>
                  </xsl:if>
                  <xsl:if test=""string($var:v20)='false'"">
                    <siteCity>
                      <xsl:value-of select=""siteCity/text()"" />
                    </siteCity>
                  </xsl:if>
                </xsl:if>
                <xsl:if test=""siteState"">
                  <xsl:variable name=""var:v21"" select=""string(siteState/@xsi:nil) = 'true'"" />
                  <xsl:if test=""string($var:v21)='true'"">
                    <siteState>
                      <xsl:attribute name=""xsi:nil"">
                        <xsl:value-of select=""'true'"" />
                      </xsl:attribute>
                    </siteState>
                  </xsl:if>
                  <xsl:if test=""string($var:v21)='false'"">
                    <siteState>
                      <xsl:value-of select=""siteState/text()"" />
                    </siteState>
                  </xsl:if>
                </xsl:if>
                <xsl:if test=""siteCountry"">
                  <xsl:variable name=""var:v22"" select=""string(siteCountry/@xsi:nil) = 'true'"" />
                  <xsl:if test=""string($var:v22)='true'"">
                    <siteCountry>
                      <xsl:attribute name=""xsi:nil"">
                        <xsl:value-of select=""'true'"" />
                      </xsl:attribute>
                    </siteCountry>
                  </xsl:if>
                  <xsl:if test=""string($var:v22)='false'"">
                    <siteCountry>
                      <xsl:value-of select=""siteCountry/text()"" />
                    </siteCountry>
                  </xsl:if>
                </xsl:if>
                <xsl:if test=""sitePostCode"">
                  <xsl:variable name=""var:v23"" select=""string(sitePostCode/@xsi:nil) = 'true'"" />
                  <xsl:if test=""string($var:v23)='true'"">
                    <sitePostCode>
                      <xsl:attribute name=""xsi:nil"">
                        <xsl:value-of select=""'true'"" />
                      </xsl:attribute>
                    </sitePostCode>
                  </xsl:if>
                  <xsl:if test=""string($var:v23)='false'"">
                    <sitePostCode>
                      <xsl:value-of select=""sitePostCode/text()"" />
                    </sitePostCode>
                  </xsl:if>
                </xsl:if>
                <xsl:if test=""siteSiteName"">
                  <xsl:variable name=""var:v24"" select=""string(siteSiteName/@xsi:nil) = 'true'"" />
                  <xsl:if test=""string($var:v24)='true'"">
                    <siteSiteName>
                      <xsl:attribute name=""xsi:nil"">
                        <xsl:value-of select=""'true'"" />
                      </xsl:attribute>
                    </siteSiteName>
                  </xsl:if>
                  <xsl:if test=""string($var:v24)='false'"">
                    <siteSiteName>
                      <xsl:value-of select=""siteSiteName/text()"" />
                    </siteSiteName>
                  </xsl:if>
                </xsl:if>
                <xsl:if test=""siteSiteID"">
                  <xsl:variable name=""var:v25"" select=""string(siteSiteID/@xsi:nil) = 'true'"" />
                  <xsl:if test=""string($var:v25)='true'"">
                    <siteSiteID>
                      <xsl:attribute name=""xsi:nil"">
                        <xsl:value-of select=""'true'"" />
                      </xsl:attribute>
                    </siteSiteID>
                  </xsl:if>
                  <xsl:if test=""string($var:v25)='false'"">
                    <siteSiteID>
                      <xsl:value-of select=""siteSiteID/text()"" />
                    </siteSiteID>
                  </xsl:if>
                </xsl:if>
                <xsl:if test=""siteSecondaryClientSiteID"">
                  <xsl:variable name=""var:v26"" select=""string(siteSecondaryClientSiteID/@xsi:nil) = 'true'"" />
                  <xsl:if test=""string($var:v26)='true'"">
                    <siteSecondaryClientSiteID>
                      <xsl:attribute name=""xsi:nil"">
                        <xsl:value-of select=""'true'"" />
                      </xsl:attribute>
                    </siteSecondaryClientSiteID>
                  </xsl:if>
                  <xsl:if test=""string($var:v26)='false'"">
                    <siteSecondaryClientSiteID>
                      <xsl:value-of select=""siteSecondaryClientSiteID/text()"" />
                    </siteSecondaryClientSiteID>
                  </xsl:if>
                </xsl:if>
                <xsl:if test=""siteDivisionid"">
                  <xsl:variable name=""var:v27"" select=""string(siteDivisionid/@xsi:nil) = 'true'"" />
                  <xsl:if test=""string($var:v27)='true'"">
                    <siteDivisionid>
                      <xsl:attribute name=""xsi:nil"">
                        <xsl:value-of select=""'true'"" />
                      </xsl:attribute>
                    </siteDivisionid>
                  </xsl:if>
                  <xsl:if test=""string($var:v27)='false'"">
                    <siteDivisionid>
                      <xsl:value-of select=""siteDivisionid/text()"" />
                    </siteDivisionid>
                  </xsl:if>
                </xsl:if>
                <xsl:if test=""siteRegionid"">
                  <xsl:variable name=""var:v28"" select=""string(siteRegionid/@xsi:nil) = 'true'"" />
                  <xsl:if test=""string($var:v28)='true'"">
                    <siteRegionid>
                      <xsl:attribute name=""xsi:nil"">
                        <xsl:value-of select=""'true'"" />
                      </xsl:attribute>
                    </siteRegionid>
                  </xsl:if>
                  <xsl:if test=""string($var:v28)='false'"">
                    <siteRegionid>
                      <xsl:value-of select=""siteRegionid/text()"" />
                    </siteRegionid>
                  </xsl:if>
                </xsl:if>
                <xsl:if test=""siteLatitude"">
                  <xsl:variable name=""var:v29"" select=""string(siteLatitude/@xsi:nil) = 'true'"" />
                  <xsl:if test=""string($var:v29)='true'"">
                    <siteLatitude>
                      <xsl:attribute name=""xsi:nil"">
                        <xsl:value-of select=""'true'"" />
                      </xsl:attribute>
                    </siteLatitude>
                  </xsl:if>
                  <xsl:if test=""string($var:v29)='false'"">
                    <siteLatitude>
                      <xsl:value-of select=""siteLatitude/text()"" />
                    </siteLatitude>
                  </xsl:if>
                </xsl:if>
                <xsl:if test=""siteLongitude"">
                  <xsl:variable name=""var:v30"" select=""string(siteLongitude/@xsi:nil) = 'true'"" />
                  <xsl:if test=""string($var:v30)='true'"">
                    <siteLongitude>
                      <xsl:attribute name=""xsi:nil"">
                        <xsl:value-of select=""'true'"" />
                      </xsl:attribute>
                    </siteLongitude>
                  </xsl:if>
                  <xsl:if test=""string($var:v30)='false'"">
                    <siteLongitude>
                      <xsl:value-of select=""siteLongitude/text()"" />
                    </siteLongitude>
                  </xsl:if>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns8:Address>
            </xsl:for-each>
          </ns5:Location>
          <xsl:for-each select=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns2:Vendor/ns4:Person"">
            <ns4:Person>
              <xsl:if test=""@Id"">
                <xsl:attribute name=""Id"">
                  <xsl:value-of select=""@Id"" />
                </xsl:attribute>
              </xsl:if>
              <xsl:if test=""CompanyId"">
                <CompanyId>
                  <xsl:value-of select=""CompanyId/text()"" />
                </CompanyId>
              </xsl:if>
              <xsl:if test=""AddressId"">
                <xsl:variable name=""var:v31"" select=""string(AddressId/@xsi:nil) = 'true'"" />
                <xsl:if test=""string($var:v31)='true'"">
                  <AddressId>
                    <xsl:attribute name=""xsi:nil"">
                      <xsl:value-of select=""'true'"" />
                    </xsl:attribute>
                  </AddressId>
                </xsl:if>
                <xsl:if test=""string($var:v31)='false'"">
                  <AddressId>
                    <xsl:value-of select=""AddressId/text()"" />
                  </AddressId>
                </xsl:if>
              </xsl:if>
              <xsl:if test=""UserId"">
                <xsl:variable name=""var:v32"" select=""string(UserId/@xsi:nil) = 'true'"" />
                <xsl:if test=""string($var:v32)='true'"">
                  <UserId>
                    <xsl:attribute name=""xsi:nil"">
                      <xsl:value-of select=""'true'"" />
                    </xsl:attribute>
                  </UserId>
                </xsl:if>
                <xsl:if test=""string($var:v32)='false'"">
                  <UserId>
                    <xsl:value-of select=""UserId/text()"" />
                  </UserId>
                </xsl:if>
              </xsl:if>
              <xsl:if test=""Salutation"">
                <xsl:variable name=""var:v33"" select=""string(Salutation/@xsi:nil) = 'true'"" />
                <xsl:if test=""string($var:v33)='true'"">
                  <Salutation>
                    <xsl:attribute name=""xsi:nil"">
                      <xsl:value-of select=""'true'"" />
                    </xsl:attribute>
                  </Salutation>
                </xsl:if>
                <xsl:if test=""string($var:v33)='false'"">
                  <Salutation>
                    <xsl:value-of select=""Salutation/text()"" />
                  </Salutation>
                </xsl:if>
              </xsl:if>
              <xsl:if test=""FirstName"">
                <xsl:variable name=""var:v34"" select=""string(FirstName/@xsi:nil) = 'true'"" />
                <xsl:if test=""string($var:v34)='true'"">
                  <FirstName>
                    <xsl:attribute name=""xsi:nil"">
                      <xsl:value-of select=""'true'"" />
                    </xsl:attribute>
                  </FirstName>
                </xsl:if>
                <xsl:if test=""string($var:v34)='false'"">
                  <FirstName>
                    <xsl:value-of select=""FirstName/text()"" />
                  </FirstName>
                </xsl:if>
              </xsl:if>
              <xsl:if test=""LastName"">
                <xsl:variable name=""var:v35"" select=""string(LastName/@xsi:nil) = 'true'"" />
                <xsl:if test=""string($var:v35)='true'"">
                  <LastName>
                    <xsl:attribute name=""xsi:nil"">
                      <xsl:value-of select=""'true'"" />
                    </xsl:attribute>
                  </LastName>
                </xsl:if>
                <xsl:if test=""string($var:v35)='false'"">
                  <LastName>
                    <xsl:value-of select=""LastName/text()"" />
                  </LastName>
                </xsl:if>
              </xsl:if>
              <xsl:if test=""MiddleName"">
                <xsl:variable name=""var:v36"" select=""string(MiddleName/@xsi:nil) = 'true'"" />
                <xsl:if test=""string($var:v36)='true'"">
                  <MiddleName>
                    <xsl:attribute name=""xsi:nil"">
                      <xsl:value-of select=""'true'"" />
                    </xsl:attribute>
                  </MiddleName>
                </xsl:if>
                <xsl:if test=""string($var:v36)='false'"">
                  <MiddleName>
                    <xsl:value-of select=""MiddleName/text()"" />
                  </MiddleName>
                </xsl:if>
              </xsl:if>
              <xsl:if test=""suffix"">
                <xsl:variable name=""var:v37"" select=""string(suffix/@xsi:nil) = 'true'"" />
                <xsl:if test=""string($var:v37)='true'"">
                  <suffix>
                    <xsl:attribute name=""xsi:nil"">
                      <xsl:value-of select=""'true'"" />
                    </xsl:attribute>
                  </suffix>
                </xsl:if>
                <xsl:if test=""string($var:v37)='false'"">
                  <suffix>
                    <xsl:value-of select=""suffix/text()"" />
                  </suffix>
                </xsl:if>
              </xsl:if>
              <xsl:if test=""gender"">
                <xsl:variable name=""var:v38"" select=""string(gender/@xsi:nil) = 'true'"" />
                <xsl:if test=""string($var:v38)='true'"">
                  <gender>
                    <xsl:attribute name=""xsi:nil"">
                      <xsl:value-of select=""'true'"" />
                    </xsl:attribute>
                  </gender>
                </xsl:if>
                <xsl:if test=""string($var:v38)='false'"">
                  <gender>
                    <xsl:value-of select=""gender/text()"" />
                  </gender>
                </xsl:if>
              </xsl:if>
              <xsl:if test=""title"">
                <xsl:variable name=""var:v39"" select=""string(title/@xsi:nil) = 'true'"" />
                <xsl:if test=""string($var:v39)='true'"">
                  <title>
                    <xsl:attribute name=""xsi:nil"">
                      <xsl:value-of select=""'true'"" />
                    </xsl:attribute>
                  </title>
                </xsl:if>
                <xsl:if test=""string($var:v39)='false'"">
                  <title>
                    <xsl:value-of select=""title/text()"" />
                  </title>
                </xsl:if>
              </xsl:if>
              <xsl:if test=""department"">
                <xsl:variable name=""var:v40"" select=""string(department/@xsi:nil) = 'true'"" />
                <xsl:if test=""string($var:v40)='true'"">
                  <department>
                    <xsl:attribute name=""xsi:nil"">
                      <xsl:value-of select=""'true'"" />
                    </xsl:attribute>
                  </department>
                </xsl:if>
                <xsl:if test=""string($var:v40)='false'"">
                  <department>
                    <xsl:value-of select=""department/text()"" />
                  </department>
                </xsl:if>
              </xsl:if>
              <xsl:if test=""locationid"">
                <xsl:variable name=""var:v41"" select=""string(locationid/@xsi:nil) = 'true'"" />
                <xsl:if test=""string($var:v41)='true'"">
                  <locationid>
                    <xsl:attribute name=""xsi:nil"">
                      <xsl:value-of select=""'true'"" />
                    </xsl:attribute>
                  </locationid>
                </xsl:if>
                <xsl:if test=""string($var:v41)='false'"">
                  <locationid>
                    <xsl:value-of select=""locationid/text()"" />
                  </locationid>
                </xsl:if>
              </xsl:if>
              <xsl:if test=""contactmethod"">
                <xsl:variable name=""var:v42"" select=""string(contactmethod/@xsi:nil) = 'true'"" />
                <xsl:if test=""string($var:v42)='true'"">
                  <contactmethod>
                    <xsl:attribute name=""xsi:nil"">
                      <xsl:value-of select=""'true'"" />
                    </xsl:attribute>
                  </contactmethod>
                </xsl:if>
                <xsl:if test=""string($var:v42)='false'"">
                  <contactmethod>
                    <xsl:value-of select=""contactmethod/text()"" />
                  </contactmethod>
                </xsl:if>
              </xsl:if>
              <xsl:if test=""PhoneNumber"">
                <xsl:variable name=""var:v43"" select=""string(PhoneNumber/@xsi:nil) = 'true'"" />
                <xsl:if test=""string($var:v43)='true'"">
                  <PhoneNumber>
                    <xsl:attribute name=""xsi:nil"">
                      <xsl:value-of select=""'true'"" />
                    </xsl:attribute>
                  </PhoneNumber>
                </xsl:if>
                <xsl:if test=""string($var:v43)='false'"">
                  <PhoneNumber>
                    <xsl:value-of select=""PhoneNumber/text()"" />
                  </PhoneNumber>
                </xsl:if>
              </xsl:if>
              <xsl:if test=""EmailAddress"">
                <xsl:variable name=""var:v44"" select=""string(EmailAddress/@xsi:nil) = 'true'"" />
                <xsl:if test=""string($var:v44)='true'"">
                  <EmailAddress>
                    <xsl:attribute name=""xsi:nil"">
                      <xsl:value-of select=""'true'"" />
                    </xsl:attribute>
                  </EmailAddress>
                </xsl:if>
                <xsl:if test=""string($var:v44)='false'"">
                  <EmailAddress>
                    <xsl:value-of select=""EmailAddress/text()"" />
                  </EmailAddress>
                </xsl:if>
              </xsl:if>
              <xsl:if test=""FaxNumber"">
                <xsl:variable name=""var:v45"" select=""string(FaxNumber/@xsi:nil) = 'true'"" />
                <xsl:if test=""string($var:v45)='true'"">
                  <FaxNumber>
                    <xsl:attribute name=""xsi:nil"">
                      <xsl:value-of select=""'true'"" />
                    </xsl:attribute>
                  </FaxNumber>
                </xsl:if>
                <xsl:if test=""string($var:v45)='false'"">
                  <FaxNumber>
                    <xsl:value-of select=""FaxNumber/text()"" />
                  </FaxNumber>
                </xsl:if>
              </xsl:if>
            </ns4:Person>
          </xsl:for-each>
          <xsl:value-of select=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns2:Vendor/text()"" />
        </ns2:Vendor>
        <ns9:Workitem>
          <ns9:HelpdeskId>
            <xsl:value-of select=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:HelpdeskId/text()"" />
          </ns9:HelpdeskId>
          <ns9:CompanyId>
            <xsl:value-of select=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:CompanyId/text()"" />
          </ns9:CompanyId>
          <xsl:if test=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:PersonId"">
            <xsl:variable name=""var:v46"" select=""string(InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:PersonId/@xsi:nil) = 'true'"" />
            <xsl:if test=""string($var:v46)='true'"">
              <ns9:PersonId>
                <xsl:attribute name=""xsi:nil"">
                  <xsl:value-of select=""'true'"" />
                </xsl:attribute>
              </ns9:PersonId>
            </xsl:if>
            <xsl:if test=""string($var:v46)='false'"">
              <ns9:PersonId>
                <xsl:value-of select=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:PersonId/text()"" />
              </ns9:PersonId>
            </xsl:if>
          </xsl:if>
          <xsl:if test=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:AssignedId"">
            <xsl:variable name=""var:v47"" select=""string(InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:AssignedId/@xsi:nil) = 'true'"" />
            <xsl:if test=""string($var:v47)='true'"">
              <ns9:AssignedId>
                <xsl:attribute name=""xsi:nil"">
                  <xsl:value-of select=""'true'"" />
                </xsl:attribute>
              </ns9:AssignedId>
            </xsl:if>
            <xsl:if test=""string($var:v47)='false'"">
              <ns9:AssignedId>
                <xsl:value-of select=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:AssignedId/text()"" />
              </ns9:AssignedId>
            </xsl:if>
          </xsl:if>
          <xsl:if test=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:ChannelId"">
            <xsl:variable name=""var:v48"" select=""string(InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:ChannelId/@xsi:nil) = 'true'"" />
            <xsl:if test=""string($var:v48)='true'"">
              <ns9:ChannelId>
                <xsl:attribute name=""xsi:nil"">
                  <xsl:value-of select=""'true'"" />
                </xsl:attribute>
              </ns9:ChannelId>
            </xsl:if>
            <xsl:if test=""string($var:v48)='false'"">
              <ns9:ChannelId>
                <xsl:value-of select=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:ChannelId/text()"" />
              </ns9:ChannelId>
            </xsl:if>
          </xsl:if>
          <xsl:if test=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:CustomerRef"">
            <xsl:variable name=""var:v49"" select=""string(InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:CustomerRef/@xsi:nil) = 'true'"" />
            <xsl:if test=""string($var:v49)='true'"">
              <ns9:CustomerRef>
                <xsl:attribute name=""xsi:nil"">
                  <xsl:value-of select=""'true'"" />
                </xsl:attribute>
              </ns9:CustomerRef>
            </xsl:if>
            <xsl:if test=""string($var:v49)='false'"">
              <ns9:CustomerRef>
                <xsl:value-of select=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:CustomerRef/text()"" />
              </ns9:CustomerRef>
            </xsl:if>
          </xsl:if>
          <xsl:if test=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:Source"">
            <xsl:variable name=""var:v50"" select=""string(InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:Source/@xsi:nil) = 'true'"" />
            <xsl:if test=""string($var:v50)='true'"">
              <ns9:Source>
                <xsl:attribute name=""xsi:nil"">
                  <xsl:value-of select=""'true'"" />
                </xsl:attribute>
              </ns9:Source>
            </xsl:if>
            <xsl:if test=""string($var:v50)='false'"">
              <ns9:Source>
                <xsl:value-of select=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:Source/text()"" />
              </ns9:Source>
            </xsl:if>
          </xsl:if>
          <xsl:if test=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:SolutionType"">
            <xsl:variable name=""var:v51"" select=""string(InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:SolutionType/@xsi:nil) = 'true'"" />
            <xsl:if test=""string($var:v51)='true'"">
              <ns9:SolutionType>
                <xsl:attribute name=""xsi:nil"">
                  <xsl:value-of select=""'true'"" />
                </xsl:attribute>
              </ns9:SolutionType>
            </xsl:if>
            <xsl:if test=""string($var:v51)='false'"">
              <ns9:SolutionType>
                <xsl:value-of select=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:SolutionType/text()"" />
              </ns9:SolutionType>
            </xsl:if>
          </xsl:if>
          <xsl:if test=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:ProblemNote"">
            <xsl:variable name=""var:v52"" select=""string(InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:ProblemNote/@xsi:nil) = 'true'"" />
            <xsl:if test=""string($var:v52)='true'"">
              <ns9:ProblemNote>
                <xsl:attribute name=""xsi:nil"">
                  <xsl:value-of select=""'true'"" />
                </xsl:attribute>
              </ns9:ProblemNote>
            </xsl:if>
            <xsl:if test=""string($var:v52)='false'"">
              <ns9:ProblemNote>
                <xsl:value-of select=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:ProblemNote/text()"" />
              </ns9:ProblemNote>
            </xsl:if>
          </xsl:if>
          <xsl:if test=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:SolutionNote"">
            <xsl:variable name=""var:v53"" select=""string(InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:SolutionNote/@xsi:nil) = 'true'"" />
            <xsl:if test=""string($var:v53)='true'"">
              <ns9:SolutionNote>
                <xsl:attribute name=""xsi:nil"">
                  <xsl:value-of select=""'true'"" />
                </xsl:attribute>
              </ns9:SolutionNote>
            </xsl:if>
            <xsl:if test=""string($var:v53)='false'"">
              <ns9:SolutionNote>
                <xsl:value-of select=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:SolutionNote/text()"" />
              </ns9:SolutionNote>
            </xsl:if>
          </xsl:if>
          <xsl:if test=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:OpenedDate"">
            <xsl:variable name=""var:v54"" select=""string(InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:OpenedDate/@xsi:nil) = 'true'"" />
            <xsl:if test=""string($var:v54)='true'"">
              <ns9:OpenedDate>
                <xsl:attribute name=""xsi:nil"">
                  <xsl:value-of select=""'true'"" />
                </xsl:attribute>
              </ns9:OpenedDate>
            </xsl:if>
            <xsl:if test=""string($var:v54)='false'"">
              <ns9:OpenedDate>
                <xsl:value-of select=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:OpenedDate/text()"" />
              </ns9:OpenedDate>
            </xsl:if>
          </xsl:if>
          <xsl:if test=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:OpenedBy"">
            <xsl:variable name=""var:v55"" select=""string(InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:OpenedBy/@xsi:nil) = 'true'"" />
            <xsl:if test=""string($var:v55)='true'"">
              <ns9:OpenedBy>
                <xsl:attribute name=""xsi:nil"">
                  <xsl:value-of select=""'true'"" />
                </xsl:attribute>
              </ns9:OpenedBy>
            </xsl:if>
            <xsl:if test=""string($var:v55)='false'"">
              <ns9:OpenedBy>
                <xsl:value-of select=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:OpenedBy/text()"" />
              </ns9:OpenedBy>
            </xsl:if>
          </xsl:if>
          <xsl:if test=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:ClosedBy"">
            <xsl:variable name=""var:v56"" select=""string(InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:ClosedBy/@xsi:nil) = 'true'"" />
            <xsl:if test=""string($var:v56)='true'"">
              <ns9:ClosedBy>
                <xsl:attribute name=""xsi:nil"">
                  <xsl:value-of select=""'true'"" />
                </xsl:attribute>
              </ns9:ClosedBy>
            </xsl:if>
            <xsl:if test=""string($var:v56)='false'"">
              <ns9:ClosedBy>
                <xsl:value-of select=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:ClosedBy/text()"" />
              </ns9:ClosedBy>
            </xsl:if>
          </xsl:if>
          <xsl:if test=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:Status"">
            <xsl:variable name=""var:v57"" select=""string(InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:Status/@xsi:nil) = 'true'"" />
            <xsl:if test=""string($var:v57)='true'"">
              <ns9:Status>
                <xsl:attribute name=""xsi:nil"">
                  <xsl:value-of select=""'true'"" />
                </xsl:attribute>
              </ns9:Status>
            </xsl:if>
            <xsl:if test=""string($var:v57)='false'"">
              <ns9:Status>
                <xsl:value-of select=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:Status/text()"" />
              </ns9:Status>
            </xsl:if>
          </xsl:if>
          <xsl:if test=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:Stage"">
            <xsl:variable name=""var:v58"" select=""string(InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:Stage/@xsi:nil) = 'true'"" />
            <xsl:if test=""string($var:v58)='true'"">
              <ns9:Stage>
                <xsl:attribute name=""xsi:nil"">
                  <xsl:value-of select=""'true'"" />
                </xsl:attribute>
              </ns9:Stage>
            </xsl:if>
            <xsl:if test=""string($var:v58)='false'"">
              <ns9:Stage>
                <xsl:value-of select=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:Stage/text()"" />
              </ns9:Stage>
            </xsl:if>
          </xsl:if>
          <xsl:if test=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:CreatedBy"">
            <xsl:variable name=""var:v59"" select=""string(InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:CreatedBy/@xsi:nil) = 'true'"" />
            <xsl:if test=""string($var:v59)='true'"">
              <ns9:CreatedBy>
                <xsl:attribute name=""xsi:nil"">
                  <xsl:value-of select=""'true'"" />
                </xsl:attribute>
              </ns9:CreatedBy>
            </xsl:if>
            <xsl:if test=""string($var:v59)='false'"">
              <ns9:CreatedBy>
                <xsl:value-of select=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:CreatedBy/text()"" />
              </ns9:CreatedBy>
            </xsl:if>
          </xsl:if>
          <xsl:if test=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:CreatedDate"">
            <xsl:variable name=""var:v60"" select=""string(InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:CreatedDate/@xsi:nil) = 'true'"" />
            <xsl:if test=""string($var:v60)='true'"">
              <ns9:CreatedDate>
                <xsl:attribute name=""xsi:nil"">
                  <xsl:value-of select=""'true'"" />
                </xsl:attribute>
              </ns9:CreatedDate>
            </xsl:if>
            <xsl:if test=""string($var:v60)='false'"">
              <ns9:CreatedDate>
                <xsl:value-of select=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:CreatedDate/text()"" />
              </ns9:CreatedDate>
            </xsl:if>
          </xsl:if>
          <xsl:if test=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:UpdatedId"">
            <xsl:variable name=""var:v61"" select=""string(InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:UpdatedId/@xsi:nil) = 'true'"" />
            <xsl:if test=""string($var:v61)='true'"">
              <ns9:UpdatedId>
                <xsl:attribute name=""xsi:nil"">
                  <xsl:value-of select=""'true'"" />
                </xsl:attribute>
              </ns9:UpdatedId>
            </xsl:if>
            <xsl:if test=""string($var:v61)='false'"">
              <ns9:UpdatedId>
                <xsl:value-of select=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:UpdatedId/text()"" />
              </ns9:UpdatedId>
            </xsl:if>
          </xsl:if>
          <xsl:if test=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:UpdatedDate"">
            <xsl:variable name=""var:v62"" select=""string(InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:UpdatedDate/@xsi:nil) = 'true'"" />
            <xsl:if test=""string($var:v62)='true'"">
              <ns9:UpdatedDate>
                <xsl:attribute name=""xsi:nil"">
                  <xsl:value-of select=""'true'"" />
                </xsl:attribute>
              </ns9:UpdatedDate>
            </xsl:if>
            <xsl:if test=""string($var:v62)='false'"">
              <ns9:UpdatedDate>
                <xsl:value-of select=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:UpdatedDate/text()"" />
              </ns9:UpdatedDate>
            </xsl:if>
          </xsl:if>
          <xsl:variable name=""var:v63"" select=""string(InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:HelpdeskReference/@xsi:nil) = 'true'"" />
          <xsl:if test=""string($var:v63)='true'"">
            <ns9:HelpdeskReference>
              <xsl:attribute name=""xsi:nil"">
                <xsl:value-of select=""'true'"" />
              </xsl:attribute>
            </ns9:HelpdeskReference>
          </xsl:if>
          <xsl:if test=""string($var:v63)='false'"">
            <ns9:HelpdeskReference>
              <xsl:value-of select=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:HelpdeskReference/text()"" />
            </ns9:HelpdeskReference>
          </xsl:if>
          <xsl:if test=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:WorkflowId"">
            <xsl:variable name=""var:v64"" select=""string(InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:WorkflowId/@xsi:nil) = 'true'"" />
            <xsl:if test=""string($var:v64)='true'"">
              <ns9:WorkflowId>
                <xsl:attribute name=""xsi:nil"">
                  <xsl:value-of select=""'true'"" />
                </xsl:attribute>
              </ns9:WorkflowId>
            </xsl:if>
            <xsl:if test=""string($var:v64)='false'"">
              <ns9:WorkflowId>
                <xsl:value-of select=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:WorkflowId/text()"" />
              </ns9:WorkflowId>
            </xsl:if>
          </xsl:if>
          <xsl:if test=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:SLA"">
            <xsl:variable name=""var:v65"" select=""string(InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:SLA/@xsi:nil) = 'true'"" />
            <xsl:if test=""string($var:v65)='true'"">
              <ns9:SLA>
                <xsl:attribute name=""xsi:nil"">
                  <xsl:value-of select=""'true'"" />
                </xsl:attribute>
              </ns9:SLA>
            </xsl:if>
            <xsl:if test=""string($var:v65)='false'"">
              <ns9:SLA>
                <xsl:value-of select=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:SLA/text()"" />
              </ns9:SLA>
            </xsl:if>
          </xsl:if>
          <xsl:if test=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:CustomerPurchaseOrderNo"">
            <xsl:variable name=""var:v66"" select=""string(InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:CustomerPurchaseOrderNo/@xsi:nil) = 'true'"" />
            <xsl:if test=""string($var:v66)='true'"">
              <ns9:CustomerPurchaseOrderNo>
                <xsl:attribute name=""xsi:nil"">
                  <xsl:value-of select=""'true'"" />
                </xsl:attribute>
              </ns9:CustomerPurchaseOrderNo>
            </xsl:if>
            <xsl:if test=""string($var:v66)='false'"">
              <ns9:CustomerPurchaseOrderNo>
                <xsl:value-of select=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:CustomerPurchaseOrderNo/text()"" />
              </ns9:CustomerPurchaseOrderNo>
            </xsl:if>
          </xsl:if>
          <xsl:if test=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:WorkType"">
            <xsl:variable name=""var:v67"" select=""string(InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:WorkType/@xsi:nil) = 'true'"" />
            <xsl:if test=""string($var:v67)='true'"">
              <ns9:WorkType>
                <xsl:attribute name=""xsi:nil"">
                  <xsl:value-of select=""'true'"" />
                </xsl:attribute>
              </ns9:WorkType>
            </xsl:if>
            <xsl:if test=""string($var:v67)='false'"">
              <ns9:WorkType>
                <xsl:value-of select=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:WorkType/text()"" />
              </ns9:WorkType>
            </xsl:if>
          </xsl:if>
          <xsl:if test=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:ChargeableValue"">
            <xsl:variable name=""var:v68"" select=""string(InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:ChargeableValue/@xsi:nil) = 'true'"" />
            <xsl:if test=""string($var:v68)='true'"">
              <ns9:ChargeableValue>
                <xsl:attribute name=""xsi:nil"">
                  <xsl:value-of select=""'true'"" />
                </xsl:attribute>
              </ns9:ChargeableValue>
            </xsl:if>
            <xsl:if test=""string($var:v68)='false'"">
              <ns9:ChargeableValue>
                <xsl:value-of select=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:ChargeableValue/text()"" />
              </ns9:ChargeableValue>
            </xsl:if>
          </xsl:if>
          <xsl:if test=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:VendorAcknowledgeBy"">
            <xsl:variable name=""var:v69"" select=""string(InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:VendorAcknowledgeBy/@xsi:nil) = 'true'"" />
            <xsl:if test=""string($var:v69)='true'"">
              <ns9:VendorAcknowledgeBy>
                <xsl:attribute name=""xsi:nil"">
                  <xsl:value-of select=""'true'"" />
                </xsl:attribute>
              </ns9:VendorAcknowledgeBy>
            </xsl:if>
            <xsl:if test=""string($var:v69)='false'"">
              <ns9:VendorAcknowledgeBy>
                <xsl:value-of select=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:VendorAcknowledgeBy/text()"" />
              </ns9:VendorAcknowledgeBy>
            </xsl:if>
          </xsl:if>
          <xsl:if test=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:VendorAllocateBy"">
            <xsl:variable name=""var:v70"" select=""string(InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:VendorAllocateBy/@xsi:nil) = 'true'"" />
            <xsl:if test=""string($var:v70)='true'"">
              <ns9:VendorAllocateBy>
                <xsl:attribute name=""xsi:nil"">
                  <xsl:value-of select=""'true'"" />
                </xsl:attribute>
              </ns9:VendorAllocateBy>
            </xsl:if>
            <xsl:if test=""string($var:v70)='false'"">
              <ns9:VendorAllocateBy>
                <xsl:value-of select=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:VendorAllocateBy/text()"" />
              </ns9:VendorAllocateBy>
            </xsl:if>
          </xsl:if>
          <xsl:if test=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:VendorAttendBy"">
            <ns9:VendorAttendBy>
              <xsl:value-of select=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:VendorAttendBy/text()"" />
            </ns9:VendorAttendBy>
          </xsl:if>
          <xsl:if test=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:VendorCompleteBy"">
            <ns9:VendorCompleteBy>
              <xsl:value-of select=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:VendorCompleteBy/text()"" />
            </ns9:VendorCompleteBy>
          </xsl:if>
          <xsl:if test=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:CustomerVerifyBy"">
            <xsl:variable name=""var:v71"" select=""string(InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:CustomerVerifyBy/@xsi:nil) = 'true'"" />
            <xsl:if test=""string($var:v71)='true'"">
              <ns9:CustomerVerifyBy>
                <xsl:attribute name=""xsi:nil"">
                  <xsl:value-of select=""'true'"" />
                </xsl:attribute>
              </ns9:CustomerVerifyBy>
            </xsl:if>
            <xsl:if test=""string($var:v71)='false'"">
              <ns9:CustomerVerifyBy>
                <xsl:value-of select=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:CustomerVerifyBy/text()"" />
              </ns9:CustomerVerifyBy>
            </xsl:if>
          </xsl:if>
          <xsl:if test=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:ContractBundleId"">
            <ns9:ContractBundleId>
              <xsl:value-of select=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:ContractBundleId/text()"" />
            </ns9:ContractBundleId>
          </xsl:if>
          <xsl:for-each select=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:CustomerDivision"">
            <ns9:CustomerDivision>
              <xsl:if test=""@CustomerDivisionId"">
                <xsl:attribute name=""CustomerDivisionId"">
                  <xsl:value-of select=""@CustomerDivisionId"" />
                </xsl:attribute>
              </xsl:if>
              <ns9:CustomerDivisionName>
                <xsl:value-of select=""ns9:CustomerDivisionName/text()"" />
              </ns9:CustomerDivisionName>
              <xsl:value-of select=""./text()"" />
            </ns9:CustomerDivision>
          </xsl:for-each>
          <xsl:if test=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:ServiceStreamId"">
            <ns9:ServiceStreamId>
              <xsl:value-of select=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:ServiceStreamId/text()"" />
            </ns9:ServiceStreamId>
          </xsl:if>
          <xsl:if test=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:ServiceTypeId"">
            <ns9:ServiceTypeId>
              <xsl:value-of select=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:ServiceTypeId/text()"" />
            </ns9:ServiceTypeId>
          </xsl:if>
          <xsl:if test=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:ServiceDetailId"">
            <ns9:ServiceDetailId>
              <xsl:value-of select=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:ServiceDetailId/text()"" />
            </ns9:ServiceDetailId>
          </xsl:if>
          <xsl:if test=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:VendorAcknowledgeSlaOverridden"">
            <xsl:variable name=""var:v72"" select=""string(InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:VendorAcknowledgeSlaOverridden/@xsi:nil) = 'true'"" />
            <xsl:if test=""string($var:v72)='true'"">
              <ns9:VendorAcknowledgeSlaOverridden>
                <xsl:attribute name=""xsi:nil"">
                  <xsl:value-of select=""'true'"" />
                </xsl:attribute>
              </ns9:VendorAcknowledgeSlaOverridden>
            </xsl:if>
            <xsl:if test=""string($var:v72)='false'"">
              <ns9:VendorAcknowledgeSlaOverridden>
                <xsl:value-of select=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:VendorAcknowledgeSlaOverridden/text()"" />
              </ns9:VendorAcknowledgeSlaOverridden>
            </xsl:if>
          </xsl:if>
          <xsl:if test=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:VendorAllocateSlaOverridden"">
            <xsl:variable name=""var:v73"" select=""string(InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:VendorAllocateSlaOverridden/@xsi:nil) = 'true'"" />
            <xsl:if test=""string($var:v73)='true'"">
              <ns9:VendorAllocateSlaOverridden>
                <xsl:attribute name=""xsi:nil"">
                  <xsl:value-of select=""'true'"" />
                </xsl:attribute>
              </ns9:VendorAllocateSlaOverridden>
            </xsl:if>
            <xsl:if test=""string($var:v73)='false'"">
              <ns9:VendorAllocateSlaOverridden>
                <xsl:value-of select=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:VendorAllocateSlaOverridden/text()"" />
              </ns9:VendorAllocateSlaOverridden>
            </xsl:if>
          </xsl:if>
          <xsl:if test=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:VendorAttendSlaOverridden"">
            <xsl:variable name=""var:v74"" select=""string(InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:VendorAttendSlaOverridden/@xsi:nil) = 'true'"" />
            <xsl:if test=""string($var:v74)='true'"">
              <ns9:VendorAttendSlaOverridden>
                <xsl:attribute name=""xsi:nil"">
                  <xsl:value-of select=""'true'"" />
                </xsl:attribute>
              </ns9:VendorAttendSlaOverridden>
            </xsl:if>
            <xsl:if test=""string($var:v74)='false'"">
              <ns9:VendorAttendSlaOverridden>
                <xsl:value-of select=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:VendorAttendSlaOverridden/text()"" />
              </ns9:VendorAttendSlaOverridden>
            </xsl:if>
          </xsl:if>
          <xsl:if test=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:CustomerVerifySlaOverridden"">
            <xsl:variable name=""var:v75"" select=""string(InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:CustomerVerifySlaOverridden/@xsi:nil) = 'true'"" />
            <xsl:if test=""string($var:v75)='true'"">
              <ns9:CustomerVerifySlaOverridden>
                <xsl:attribute name=""xsi:nil"">
                  <xsl:value-of select=""'true'"" />
                </xsl:attribute>
              </ns9:CustomerVerifySlaOverridden>
            </xsl:if>
            <xsl:if test=""string($var:v75)='false'"">
              <ns9:CustomerVerifySlaOverridden>
                <xsl:value-of select=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:CustomerVerifySlaOverridden/text()"" />
              </ns9:CustomerVerifySlaOverridden>
            </xsl:if>
          </xsl:if>
          <xsl:if test=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:VendorCompleteSlaOverridden"">
            <xsl:variable name=""var:v76"" select=""string(InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:VendorCompleteSlaOverridden/@xsi:nil) = 'true'"" />
            <xsl:if test=""string($var:v76)='true'"">
              <ns9:VendorCompleteSlaOverridden>
                <xsl:attribute name=""xsi:nil"">
                  <xsl:value-of select=""'true'"" />
                </xsl:attribute>
              </ns9:VendorCompleteSlaOverridden>
            </xsl:if>
            <xsl:if test=""string($var:v76)='false'"">
              <ns9:VendorCompleteSlaOverridden>
                <xsl:value-of select=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:VendorCompleteSlaOverridden/text()"" />
              </ns9:VendorCompleteSlaOverridden>
            </xsl:if>
          </xsl:if>
          <xsl:if test=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:ContactFirstname"">
            <xsl:variable name=""var:v77"" select=""string(InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:ContactFirstname/@xsi:nil) = 'true'"" />
            <xsl:if test=""string($var:v77)='true'"">
              <ns9:ContactFirstname>
                <xsl:attribute name=""xsi:nil"">
                  <xsl:value-of select=""'true'"" />
                </xsl:attribute>
              </ns9:ContactFirstname>
            </xsl:if>
            <xsl:if test=""string($var:v77)='false'"">
              <ns9:ContactFirstname>
                <xsl:value-of select=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:ContactFirstname/text()"" />
              </ns9:ContactFirstname>
            </xsl:if>
          </xsl:if>
          <xsl:if test=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:ContactSurname"">
            <xsl:variable name=""var:v78"" select=""string(InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:ContactSurname/@xsi:nil) = 'true'"" />
            <xsl:if test=""string($var:v78)='true'"">
              <ns9:ContactSurname>
                <xsl:attribute name=""xsi:nil"">
                  <xsl:value-of select=""'true'"" />
                </xsl:attribute>
              </ns9:ContactSurname>
            </xsl:if>
            <xsl:if test=""string($var:v78)='false'"">
              <ns9:ContactSurname>
                <xsl:value-of select=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:ContactSurname/text()"" />
              </ns9:ContactSurname>
            </xsl:if>
          </xsl:if>
          <xsl:if test=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:ContactPhone"">
            <xsl:variable name=""var:v79"" select=""string(InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:ContactPhone/@xsi:nil) = 'true'"" />
            <xsl:if test=""string($var:v79)='true'"">
              <ns9:ContactPhone>
                <xsl:attribute name=""xsi:nil"">
                  <xsl:value-of select=""'true'"" />
                </xsl:attribute>
              </ns9:ContactPhone>
            </xsl:if>
            <xsl:if test=""string($var:v79)='false'"">
              <ns9:ContactPhone>
                <xsl:value-of select=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:ContactPhone/text()"" />
              </ns9:ContactPhone>
            </xsl:if>
          </xsl:if>
          <xsl:if test=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:ContactMobile"">
            <xsl:variable name=""var:v80"" select=""string(InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:ContactMobile/@xsi:nil) = 'true'"" />
            <xsl:if test=""string($var:v80)='true'"">
              <ns9:ContactMobile>
                <xsl:attribute name=""xsi:nil"">
                  <xsl:value-of select=""'true'"" />
                </xsl:attribute>
              </ns9:ContactMobile>
            </xsl:if>
            <xsl:if test=""string($var:v80)='false'"">
              <ns9:ContactMobile>
                <xsl:value-of select=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:ContactMobile/text()"" />
              </ns9:ContactMobile>
            </xsl:if>
          </xsl:if>
          <xsl:if test=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:ContactEmail"">
            <xsl:variable name=""var:v81"" select=""string(InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:ContactEmail/@xsi:nil) = 'true'"" />
            <xsl:if test=""string($var:v81)='true'"">
              <ns9:ContactEmail>
                <xsl:attribute name=""xsi:nil"">
                  <xsl:value-of select=""'true'"" />
                </xsl:attribute>
              </ns9:ContactEmail>
            </xsl:if>
            <xsl:if test=""string($var:v81)='false'"">
              <ns9:ContactEmail>
                <xsl:value-of select=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:ContactEmail/text()"" />
              </ns9:ContactEmail>
            </xsl:if>
          </xsl:if>
          <xsl:if test=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:ContactPosition"">
            <xsl:variable name=""var:v82"" select=""string(InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:ContactPosition/@xsi:nil) = 'true'"" />
            <xsl:if test=""string($var:v82)='true'"">
              <ns9:ContactPosition>
                <xsl:attribute name=""xsi:nil"">
                  <xsl:value-of select=""'true'"" />
                </xsl:attribute>
              </ns9:ContactPosition>
            </xsl:if>
            <xsl:if test=""string($var:v82)='false'"">
              <ns9:ContactPosition>
                <xsl:value-of select=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:ContactPosition/text()"" />
              </ns9:ContactPosition>
            </xsl:if>
          </xsl:if>
          <xsl:if test=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:SiteId"">
            <ns9:SiteId>
              <xsl:value-of select=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:SiteId/text()"" />
            </ns9:SiteId>
          </xsl:if>
          <xsl:if test=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:objectid"">
            <xsl:variable name=""var:v83"" select=""string(InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:objectid/@xsi:nil) = 'true'"" />
            <xsl:if test=""string($var:v83)='true'"">
              <ns9:objectid>
                <xsl:attribute name=""xsi:nil"">
                  <xsl:value-of select=""'true'"" />
                </xsl:attribute>
              </ns9:objectid>
            </xsl:if>
            <xsl:if test=""string($var:v83)='false'"">
              <ns9:objectid>
                <xsl:value-of select=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:objectid/text()"" />
              </ns9:objectid>
            </xsl:if>
          </xsl:if>
          <xsl:if test=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:BudgetValue"">
            <xsl:variable name=""var:v84"" select=""string(InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:BudgetValue/@xsi:nil) = 'true'"" />
            <xsl:if test=""string($var:v84)='true'"">
              <ns9:BudgetValue>
                <xsl:attribute name=""xsi:nil"">
                  <xsl:value-of select=""'true'"" />
                </xsl:attribute>
              </ns9:BudgetValue>
            </xsl:if>
            <xsl:if test=""string($var:v84)='false'"">
              <ns9:BudgetValue>
                <xsl:value-of select=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:BudgetValue/text()"" />
              </ns9:BudgetValue>
            </xsl:if>
          </xsl:if>
          <xsl:if test=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:PlacedOnHoldTS"">
            <xsl:variable name=""var:v85"" select=""string(InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:PlacedOnHoldTS/@xsi:nil) = 'true'"" />
            <xsl:if test=""string($var:v85)='true'"">
              <ns9:PlacedOnHoldTS>
                <xsl:attribute name=""xsi:nil"">
                  <xsl:value-of select=""'true'"" />
                </xsl:attribute>
              </ns9:PlacedOnHoldTS>
            </xsl:if>
            <xsl:if test=""string($var:v85)='false'"">
              <ns9:PlacedOnHoldTS>
                <xsl:value-of select=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:PlacedOnHoldTS/text()"" />
              </ns9:PlacedOnHoldTS>
            </xsl:if>
          </xsl:if>
          <xsl:if test=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:authoriserid"">
            <xsl:variable name=""var:v86"" select=""string(InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:authoriserid/@xsi:nil) = 'true'"" />
            <xsl:if test=""string($var:v86)='true'"">
              <ns9:authoriserid>
                <xsl:attribute name=""xsi:nil"">
                  <xsl:value-of select=""'true'"" />
                </xsl:attribute>
              </ns9:authoriserid>
            </xsl:if>
            <xsl:if test=""string($var:v86)='false'"">
              <ns9:authoriserid>
                <xsl:value-of select=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:authoriserid/text()"" />
              </ns9:authoriserid>
            </xsl:if>
          </xsl:if>
          <xsl:if test=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:preauthoriserid"">
            <xsl:variable name=""var:v87"" select=""string(InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:preauthoriserid/@xsi:nil) = 'true'"" />
            <xsl:if test=""string($var:v87)='true'"">
              <ns9:preauthoriserid>
                <xsl:attribute name=""xsi:nil"">
                  <xsl:value-of select=""'true'"" />
                </xsl:attribute>
              </ns9:preauthoriserid>
            </xsl:if>
            <xsl:if test=""string($var:v87)='false'"">
              <ns9:preauthoriserid>
                <xsl:value-of select=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:preauthoriserid/text()"" />
              </ns9:preauthoriserid>
            </xsl:if>
          </xsl:if>
          <xsl:if test=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:secondaryauthoriserid"">
            <xsl:variable name=""var:v88"" select=""string(InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:secondaryauthoriserid/@xsi:nil) = 'true'"" />
            <xsl:if test=""string($var:v88)='true'"">
              <ns9:secondaryauthoriserid>
                <xsl:attribute name=""xsi:nil"">
                  <xsl:value-of select=""'true'"" />
                </xsl:attribute>
              </ns9:secondaryauthoriserid>
            </xsl:if>
            <xsl:if test=""string($var:v88)='false'"">
              <ns9:secondaryauthoriserid>
                <xsl:value-of select=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:secondaryauthoriserid/text()"" />
              </ns9:secondaryauthoriserid>
            </xsl:if>
          </xsl:if>
          <xsl:if test=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:notauthorisedbyid"">
            <xsl:variable name=""var:v89"" select=""string(InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:notauthorisedbyid/@xsi:nil) = 'true'"" />
            <xsl:if test=""string($var:v89)='true'"">
              <ns9:notauthorisedbyid>
                <xsl:attribute name=""xsi:nil"">
                  <xsl:value-of select=""'true'"" />
                </xsl:attribute>
              </ns9:notauthorisedbyid>
            </xsl:if>
            <xsl:if test=""string($var:v89)='false'"">
              <ns9:notauthorisedbyid>
                <xsl:value-of select=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:notauthorisedbyid/text()"" />
              </ns9:notauthorisedbyid>
            </xsl:if>
          </xsl:if>
          <xsl:if test=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:authorised"">
            <xsl:variable name=""var:v90"" select=""string(InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:authorised/@xsi:nil) = 'true'"" />
            <xsl:if test=""string($var:v90)='true'"">
              <ns9:authorised>
                <xsl:attribute name=""xsi:nil"">
                  <xsl:value-of select=""'true'"" />
                </xsl:attribute>
              </ns9:authorised>
            </xsl:if>
            <xsl:if test=""string($var:v90)='false'"">
              <ns9:authorised>
                <xsl:value-of select=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:authorised/text()"" />
              </ns9:authorised>
            </xsl:if>
          </xsl:if>
          <xsl:if test=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:preauthorised"">
            <xsl:variable name=""var:v91"" select=""string(InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:preauthorised/@xsi:nil) = 'true'"" />
            <xsl:if test=""string($var:v91)='true'"">
              <ns9:preauthorised>
                <xsl:attribute name=""xsi:nil"">
                  <xsl:value-of select=""'true'"" />
                </xsl:attribute>
              </ns9:preauthorised>
            </xsl:if>
            <xsl:if test=""string($var:v91)='false'"">
              <ns9:preauthorised>
                <xsl:value-of select=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:preauthorised/text()"" />
              </ns9:preauthorised>
            </xsl:if>
          </xsl:if>
          <xsl:if test=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:secondaryauthorised"">
            <xsl:variable name=""var:v92"" select=""string(InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:secondaryauthorised/@xsi:nil) = 'true'"" />
            <xsl:if test=""string($var:v92)='true'"">
              <ns9:secondaryauthorised>
                <xsl:attribute name=""xsi:nil"">
                  <xsl:value-of select=""'true'"" />
                </xsl:attribute>
              </ns9:secondaryauthorised>
            </xsl:if>
            <xsl:if test=""string($var:v92)='false'"">
              <ns9:secondaryauthorised>
                <xsl:value-of select=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:secondaryauthorised/text()"" />
              </ns9:secondaryauthorised>
            </xsl:if>
          </xsl:if>
          <xsl:if test=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:VendorId"">
            <xsl:variable name=""var:v93"" select=""string(InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:VendorId/@xsi:nil) = 'true'"" />
            <xsl:if test=""string($var:v93)='true'"">
              <ns9:VendorId>
                <xsl:attribute name=""xsi:nil"">
                  <xsl:value-of select=""'true'"" />
                </xsl:attribute>
              </ns9:VendorId>
            </xsl:if>
            <xsl:if test=""string($var:v93)='false'"">
              <ns9:VendorId>
                <xsl:value-of select=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:VendorId/text()"" />
              </ns9:VendorId>
            </xsl:if>
          </xsl:if>
          <xsl:if test=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:VendorDivisionId"">
            <xsl:variable name=""var:v94"" select=""string(InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:VendorDivisionId/@xsi:nil) = 'true'"" />
            <xsl:if test=""string($var:v94)='true'"">
              <ns9:VendorDivisionId>
                <xsl:attribute name=""xsi:nil"">
                  <xsl:value-of select=""'true'"" />
                </xsl:attribute>
              </ns9:VendorDivisionId>
            </xsl:if>
            <xsl:if test=""string($var:v94)='false'"">
              <ns9:VendorDivisionId>
                <xsl:value-of select=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:VendorDivisionId/text()"" />
              </ns9:VendorDivisionId>
            </xsl:if>
          </xsl:if>
          <xsl:if test=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:VendorLinkId"">
            <xsl:variable name=""var:v95"" select=""string(InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:VendorLinkId/@xsi:nil) = 'true'"" />
            <xsl:if test=""string($var:v95)='true'"">
              <ns9:VendorLinkId>
                <xsl:attribute name=""xsi:nil"">
                  <xsl:value-of select=""'true'"" />
                </xsl:attribute>
              </ns9:VendorLinkId>
            </xsl:if>
            <xsl:if test=""string($var:v95)='false'"">
              <ns9:VendorLinkId>
                <xsl:value-of select=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:VendorLinkId/text()"" />
              </ns9:VendorLinkId>
            </xsl:if>
          </xsl:if>
          <xsl:if test=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:VendorContactId"">
            <xsl:variable name=""var:v96"" select=""string(InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:VendorContactId/@xsi:nil) = 'true'"" />
            <xsl:if test=""string($var:v96)='true'"">
              <ns9:VendorContactId>
                <xsl:attribute name=""xsi:nil"">
                  <xsl:value-of select=""'true'"" />
                </xsl:attribute>
              </ns9:VendorContactId>
            </xsl:if>
            <xsl:if test=""string($var:v96)='false'"">
              <ns9:VendorContactId>
                <xsl:value-of select=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:VendorContactId/text()"" />
              </ns9:VendorContactId>
            </xsl:if>
          </xsl:if>
          <xsl:if test=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:UnauthorisedPerson"">
            <xsl:variable name=""var:v97"" select=""string(InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:UnauthorisedPerson/@xsi:nil) = 'true'"" />
            <xsl:if test=""string($var:v97)='true'"">
              <ns9:UnauthorisedPerson>
                <xsl:attribute name=""xsi:nil"">
                  <xsl:value-of select=""'true'"" />
                </xsl:attribute>
              </ns9:UnauthorisedPerson>
            </xsl:if>
            <xsl:if test=""string($var:v97)='false'"">
              <ns9:UnauthorisedPerson>
                <xsl:value-of select=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:UnauthorisedPerson/text()"" />
              </ns9:UnauthorisedPerson>
            </xsl:if>
          </xsl:if>
          <xsl:if test=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:VendorAttendedTS"">
            <xsl:variable name=""var:v98"" select=""string(InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:VendorAttendedTS/@xsi:nil) = 'true'"" />
            <xsl:if test=""string($var:v98)='true'"">
              <ns9:VendorAttendedTS>
                <xsl:attribute name=""xsi:nil"">
                  <xsl:value-of select=""'true'"" />
                </xsl:attribute>
              </ns9:VendorAttendedTS>
            </xsl:if>
            <xsl:if test=""string($var:v98)='false'"">
              <ns9:VendorAttendedTS>
                <xsl:value-of select=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:VendorAttendedTS/text()"" />
              </ns9:VendorAttendedTS>
            </xsl:if>
          </xsl:if>
          <xsl:if test=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:VendorAttendee"">
            <xsl:variable name=""var:v99"" select=""string(InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:VendorAttendee/@xsi:nil) = 'true'"" />
            <xsl:if test=""string($var:v99)='true'"">
              <ns9:VendorAttendee>
                <xsl:attribute name=""xsi:nil"">
                  <xsl:value-of select=""'true'"" />
                </xsl:attribute>
              </ns9:VendorAttendee>
            </xsl:if>
            <xsl:if test=""string($var:v99)='false'"">
              <ns9:VendorAttendee>
                <xsl:value-of select=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:VendorAttendee/text()"" />
              </ns9:VendorAttendee>
            </xsl:if>
          </xsl:if>
          <xsl:if test=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:QuoteValue"">
            <xsl:variable name=""var:v100"" select=""string(InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:QuoteValue/@xsi:nil) = 'true'"" />
            <xsl:if test=""string($var:v100)='true'"">
              <ns9:QuoteValue>
                <xsl:attribute name=""xsi:nil"">
                  <xsl:value-of select=""'true'"" />
                </xsl:attribute>
              </ns9:QuoteValue>
            </xsl:if>
            <xsl:if test=""string($var:v100)='false'"">
              <ns9:QuoteValue>
                <xsl:value-of select=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:QuoteValue/text()"" />
              </ns9:QuoteValue>
            </xsl:if>
          </xsl:if>
          <xsl:if test=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:CustomerVerifedBy"">
            <xsl:variable name=""var:v101"" select=""string(InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:CustomerVerifedBy/@xsi:nil) = 'true'"" />
            <xsl:if test=""string($var:v101)='true'"">
              <ns9:CustomerVerifedBy>
                <xsl:attribute name=""xsi:nil"">
                  <xsl:value-of select=""'true'"" />
                </xsl:attribute>
              </ns9:CustomerVerifedBy>
            </xsl:if>
            <xsl:if test=""string($var:v101)='false'"">
              <ns9:CustomerVerifedBy>
                <xsl:value-of select=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:CustomerVerifedBy/text()"" />
              </ns9:CustomerVerifedBy>
            </xsl:if>
          </xsl:if>
          <xsl:if test=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:CustomerVerifiedTS"">
            <xsl:variable name=""var:v102"" select=""string(InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:CustomerVerifiedTS/@xsi:nil) = 'true'"" />
            <xsl:if test=""string($var:v102)='true'"">
              <ns9:CustomerVerifiedTS>
                <xsl:attribute name=""xsi:nil"">
                  <xsl:value-of select=""'true'"" />
                </xsl:attribute>
              </ns9:CustomerVerifiedTS>
            </xsl:if>
            <xsl:if test=""string($var:v102)='false'"">
              <ns9:CustomerVerifiedTS>
                <xsl:value-of select=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:CustomerVerifiedTS/text()"" />
              </ns9:CustomerVerifiedTS>
            </xsl:if>
          </xsl:if>
          <xsl:if test=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:timecompleted"">
            <xsl:variable name=""var:v103"" select=""string(InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:timecompleted/@xsi:nil) = 'true'"" />
            <xsl:if test=""string($var:v103)='true'"">
              <ns9:timecompleted>
                <xsl:attribute name=""xsi:nil"">
                  <xsl:value-of select=""'true'"" />
                </xsl:attribute>
              </ns9:timecompleted>
            </xsl:if>
            <xsl:if test=""string($var:v103)='false'"">
              <ns9:timecompleted>
                <xsl:value-of select=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:timecompleted/text()"" />
              </ns9:timecompleted>
            </xsl:if>
          </xsl:if>
          <xsl:if test=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:timeallocated"">
            <xsl:variable name=""var:v104"" select=""string(InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:timeallocated/@xsi:nil) = 'true'"" />
            <xsl:if test=""string($var:v104)='true'"">
              <ns9:timeallocated>
                <xsl:attribute name=""xsi:nil"">
                  <xsl:value-of select=""'true'"" />
                </xsl:attribute>
              </ns9:timeallocated>
            </xsl:if>
            <xsl:if test=""string($var:v104)='false'"">
              <ns9:timeallocated>
                <xsl:value-of select=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:timeallocated/text()"" />
              </ns9:timeallocated>
            </xsl:if>
          </xsl:if>
          <xsl:if test=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:timeacknowledged"">
            <xsl:variable name=""var:v105"" select=""string(InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:timeacknowledged/@xsi:nil) = 'true'"" />
            <xsl:if test=""string($var:v105)='true'"">
              <ns9:timeacknowledged>
                <xsl:attribute name=""xsi:nil"">
                  <xsl:value-of select=""'true'"" />
                </xsl:attribute>
              </ns9:timeacknowledged>
            </xsl:if>
            <xsl:if test=""string($var:v105)='false'"">
              <ns9:timeacknowledged>
                <xsl:value-of select=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:timeacknowledged/text()"" />
              </ns9:timeacknowledged>
            </xsl:if>
          </xsl:if>
          <xsl:if test=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:LinkToHelpdeskCaseId"">
            <xsl:variable name=""var:v106"" select=""string(InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:LinkToHelpdeskCaseId/@xsi:nil) = 'true'"" />
            <xsl:if test=""string($var:v106)='true'"">
              <ns9:LinkToHelpdeskCaseId>
                <xsl:attribute name=""xsi:nil"">
                  <xsl:value-of select=""'true'"" />
                </xsl:attribute>
              </ns9:LinkToHelpdeskCaseId>
            </xsl:if>
            <xsl:if test=""string($var:v106)='false'"">
              <ns9:LinkToHelpdeskCaseId>
                <xsl:value-of select=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:LinkToHelpdeskCaseId/text()"" />
              </ns9:LinkToHelpdeskCaseId>
            </xsl:if>
          </xsl:if>
          <xsl:if test=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:QuoteNumber"">
            <xsl:variable name=""var:v107"" select=""string(InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:QuoteNumber/@xsi:nil) = 'true'"" />
            <xsl:if test=""string($var:v107)='true'"">
              <ns9:QuoteNumber>
                <xsl:attribute name=""xsi:nil"">
                  <xsl:value-of select=""'true'"" />
                </xsl:attribute>
              </ns9:QuoteNumber>
            </xsl:if>
            <xsl:if test=""string($var:v107)='false'"">
              <ns9:QuoteNumber>
                <xsl:value-of select=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:QuoteNumber/text()"" />
              </ns9:QuoteNumber>
            </xsl:if>
          </xsl:if>
          <xsl:if test=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:QuoteDate"">
            <xsl:variable name=""var:v108"" select=""string(InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:QuoteDate/@xsi:nil) = 'true'"" />
            <xsl:if test=""string($var:v108)='true'"">
              <ns9:QuoteDate>
                <xsl:attribute name=""xsi:nil"">
                  <xsl:value-of select=""'true'"" />
                </xsl:attribute>
              </ns9:QuoteDate>
            </xsl:if>
            <xsl:if test=""string($var:v108)='false'"">
              <ns9:QuoteDate>
                <xsl:value-of select=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:QuoteDate/text()"" />
              </ns9:QuoteDate>
            </xsl:if>
          </xsl:if>
          <xsl:if test=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:AuthoriseValueBanding"">
            <xsl:variable name=""var:v109"" select=""string(InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:AuthoriseValueBanding/@xsi:nil) = 'true'"" />
            <xsl:if test=""string($var:v109)='true'"">
              <ns9:AuthoriseValueBanding>
                <xsl:attribute name=""xsi:nil"">
                  <xsl:value-of select=""'true'"" />
                </xsl:attribute>
              </ns9:AuthoriseValueBanding>
            </xsl:if>
            <xsl:if test=""string($var:v109)='false'"">
              <ns9:AuthoriseValueBanding>
                <xsl:value-of select=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:AuthoriseValueBanding/text()"" />
              </ns9:AuthoriseValueBanding>
            </xsl:if>
          </xsl:if>
          <xsl:if test=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:AuthorisedValue"">
            <xsl:variable name=""var:v110"" select=""string(InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:AuthorisedValue/@xsi:nil) = 'true'"" />
            <xsl:if test=""string($var:v110)='true'"">
              <ns9:AuthorisedValue>
                <xsl:attribute name=""xsi:nil"">
                  <xsl:value-of select=""'true'"" />
                </xsl:attribute>
              </ns9:AuthorisedValue>
            </xsl:if>
            <xsl:if test=""string($var:v110)='false'"">
              <ns9:AuthorisedValue>
                <xsl:value-of select=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:AuthorisedValue/text()"" />
              </ns9:AuthorisedValue>
            </xsl:if>
          </xsl:if>
          <xsl:if test=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:externallyupdated"">
            <xsl:variable name=""var:v111"" select=""string(InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:externallyupdated/@xsi:nil) = 'true'"" />
            <xsl:if test=""string($var:v111)='true'"">
              <ns9:externallyupdated>
                <xsl:attribute name=""xsi:nil"">
                  <xsl:value-of select=""'true'"" />
                </xsl:attribute>
              </ns9:externallyupdated>
            </xsl:if>
            <xsl:if test=""string($var:v111)='false'"">
              <ns9:externallyupdated>
                <xsl:value-of select=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:externallyupdated/text()"" />
              </ns9:externallyupdated>
            </xsl:if>
          </xsl:if>
          <xsl:if test=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:cancelledbyid"">
            <xsl:variable name=""var:v112"" select=""string(InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:cancelledbyid/@xsi:nil) = 'true'"" />
            <xsl:if test=""string($var:v112)='true'"">
              <ns9:cancelledbyid>
                <xsl:attribute name=""xsi:nil"">
                  <xsl:value-of select=""'true'"" />
                </xsl:attribute>
              </ns9:cancelledbyid>
            </xsl:if>
            <xsl:if test=""string($var:v112)='false'"">
              <ns9:cancelledbyid>
                <xsl:value-of select=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:cancelledbyid/text()"" />
              </ns9:cancelledbyid>
            </xsl:if>
          </xsl:if>
          <xsl:if test=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:finalcallcost"">
            <xsl:variable name=""var:v113"" select=""string(InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:finalcallcost/@xsi:nil) = 'true'"" />
            <xsl:if test=""string($var:v113)='true'"">
              <ns9:finalcallcost>
                <xsl:attribute name=""xsi:nil"">
                  <xsl:value-of select=""'true'"" />
                </xsl:attribute>
              </ns9:finalcallcost>
            </xsl:if>
            <xsl:if test=""string($var:v113)='false'"">
              <ns9:finalcallcost>
                <xsl:value-of select=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:finalcallcost/text()"" />
              </ns9:finalcallcost>
            </xsl:if>
          </xsl:if>
          <xsl:if test=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:targetattendby"">
            <xsl:variable name=""var:v114"" select=""string(InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:targetattendby/@xsi:nil) = 'true'"" />
            <xsl:if test=""string($var:v114)='true'"">
              <ns9:targetattendby>
                <xsl:attribute name=""xsi:nil"">
                  <xsl:value-of select=""'true'"" />
                </xsl:attribute>
              </ns9:targetattendby>
            </xsl:if>
            <xsl:if test=""string($var:v114)='false'"">
              <ns9:targetattendby>
                <xsl:value-of select=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:targetattendby/text()"" />
              </ns9:targetattendby>
            </xsl:if>
          </xsl:if>
          <xsl:if test=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:person_instigatorcomms"">
            <xsl:variable name=""var:v115"" select=""string(InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:person_instigatorcomms/@xsi:nil) = 'true'"" />
            <xsl:if test=""string($var:v115)='true'"">
              <ns9:person_instigatorcomms>
                <xsl:attribute name=""xsi:nil"">
                  <xsl:value-of select=""'true'"" />
                </xsl:attribute>
              </ns9:person_instigatorcomms>
            </xsl:if>
            <xsl:if test=""string($var:v115)='false'"">
              <ns9:person_instigatorcomms>
                <xsl:value-of select=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:person_instigatorcomms/text()"" />
              </ns9:person_instigatorcomms>
            </xsl:if>
          </xsl:if>
          <xsl:if test=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:contact_instigatorcomms"">
            <xsl:variable name=""var:v116"" select=""string(InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:contact_instigatorcomms/@xsi:nil) = 'true'"" />
            <xsl:if test=""string($var:v116)='true'"">
              <ns9:contact_instigatorcomms>
                <xsl:attribute name=""xsi:nil"">
                  <xsl:value-of select=""'true'"" />
                </xsl:attribute>
              </ns9:contact_instigatorcomms>
            </xsl:if>
            <xsl:if test=""string($var:v116)='false'"">
              <ns9:contact_instigatorcomms>
                <xsl:value-of select=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:contact_instigatorcomms/text()"" />
              </ns9:contact_instigatorcomms>
            </xsl:if>
          </xsl:if>
          <xsl:if test=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:VendorReference"">
            <xsl:variable name=""var:v117"" select=""string(InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:VendorReference/@xsi:nil) = 'true'"" />
            <xsl:if test=""string($var:v117)='true'"">
              <ns9:VendorReference>
                <xsl:attribute name=""xsi:nil"">
                  <xsl:value-of select=""'true'"" />
                </xsl:attribute>
              </ns9:VendorReference>
            </xsl:if>
            <xsl:if test=""string($var:v117)='false'"">
              <ns9:VendorReference>
                <xsl:value-of select=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:VendorReference/text()"" />
              </ns9:VendorReference>
            </xsl:if>
          </xsl:if>
          <xsl:if test=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:OracleId"">
            <xsl:variable name=""var:v118"" select=""string(InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:OracleId/@xsi:nil) = 'true'"" />
            <xsl:if test=""string($var:v118)='true'"">
              <ns9:OracleId>
                <xsl:attribute name=""xsi:nil"">
                  <xsl:value-of select=""'true'"" />
                </xsl:attribute>
              </ns9:OracleId>
            </xsl:if>
            <xsl:if test=""string($var:v118)='false'"">
              <ns9:OracleId>
                <xsl:value-of select=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:OracleId/text()"" />
              </ns9:OracleId>
            </xsl:if>
          </xsl:if>
          <xsl:if test=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:CostCode"">
            <xsl:variable name=""var:v119"" select=""string(InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:CostCode/@xsi:nil) = 'true'"" />
            <xsl:if test=""string($var:v119)='true'"">
              <ns9:CostCode>
                <xsl:attribute name=""xsi:nil"">
                  <xsl:value-of select=""'true'"" />
                </xsl:attribute>
              </ns9:CostCode>
            </xsl:if>
            <xsl:if test=""string($var:v119)='false'"">
              <ns9:CostCode>
                <xsl:value-of select=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:CostCode/text()"" />
              </ns9:CostCode>
            </xsl:if>
          </xsl:if>
          <xsl:if test=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:BillingDivisionId"">
            <xsl:variable name=""var:v120"" select=""string(InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:BillingDivisionId/@xsi:nil) = 'true'"" />
            <xsl:if test=""string($var:v120)='true'"">
              <ns9:BillingDivisionId>
                <xsl:attribute name=""xsi:nil"">
                  <xsl:value-of select=""'true'"" />
                </xsl:attribute>
              </ns9:BillingDivisionId>
            </xsl:if>
            <xsl:if test=""string($var:v120)='false'"">
              <ns9:BillingDivisionId>
                <xsl:value-of select=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:BillingDivisionId/text()"" />
              </ns9:BillingDivisionId>
            </xsl:if>
          </xsl:if>
          <xsl:if test=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:BillingRegionId"">
            <xsl:variable name=""var:v121"" select=""string(InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:BillingRegionId/@xsi:nil) = 'true'"" />
            <xsl:if test=""string($var:v121)='true'"">
              <ns9:BillingRegionId>
                <xsl:attribute name=""xsi:nil"">
                  <xsl:value-of select=""'true'"" />
                </xsl:attribute>
              </ns9:BillingRegionId>
            </xsl:if>
            <xsl:if test=""string($var:v121)='false'"">
              <ns9:BillingRegionId>
                <xsl:value-of select=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:BillingRegionId/text()"" />
              </ns9:BillingRegionId>
            </xsl:if>
          </xsl:if>
          <xsl:if test=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:EndDate"">
            <xsl:variable name=""var:v122"" select=""string(InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:EndDate/@xsi:nil) = 'true'"" />
            <xsl:if test=""string($var:v122)='true'"">
              <ns9:EndDate>
                <xsl:attribute name=""xsi:nil"">
                  <xsl:value-of select=""'true'"" />
                </xsl:attribute>
              </ns9:EndDate>
            </xsl:if>
            <xsl:if test=""string($var:v122)='false'"">
              <ns9:EndDate>
                <xsl:value-of select=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:EndDate/text()"" />
              </ns9:EndDate>
            </xsl:if>
          </xsl:if>
          <xsl:if test=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:AssetId"">
            <xsl:variable name=""var:v123"" select=""string(InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:AssetId/@xsi:nil) = 'true'"" />
            <xsl:if test=""string($var:v123)='true'"">
              <ns9:AssetId>
                <xsl:attribute name=""xsi:nil"">
                  <xsl:value-of select=""'true'"" />
                </xsl:attribute>
              </ns9:AssetId>
            </xsl:if>
            <xsl:if test=""string($var:v123)='false'"">
              <ns9:AssetId>
                <xsl:value-of select=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:AssetId/text()"" />
              </ns9:AssetId>
            </xsl:if>
          </xsl:if>
          <xsl:if test=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:LocationBundleItemId"">
            <xsl:variable name=""var:v124"" select=""string(InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:LocationBundleItemId/@xsi:nil) = 'true'"" />
            <xsl:if test=""string($var:v124)='true'"">
              <ns9:LocationBundleItemId>
                <xsl:attribute name=""xsi:nil"">
                  <xsl:value-of select=""'true'"" />
                </xsl:attribute>
              </ns9:LocationBundleItemId>
            </xsl:if>
            <xsl:if test=""string($var:v124)='false'"">
              <ns9:LocationBundleItemId>
                <xsl:value-of select=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:LocationBundleItemId/text()"" />
              </ns9:LocationBundleItemId>
            </xsl:if>
          </xsl:if>
          <xsl:if test=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:fixdateonceagreed"">
            <xsl:variable name=""var:v125"" select=""string(InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:fixdateonceagreed/@xsi:nil) = 'true'"" />
            <xsl:if test=""string($var:v125)='true'"">
              <ns9:fixdateonceagreed>
                <xsl:attribute name=""xsi:nil"">
                  <xsl:value-of select=""'true'"" />
                </xsl:attribute>
              </ns9:fixdateonceagreed>
            </xsl:if>
            <xsl:if test=""string($var:v125)='false'"">
              <ns9:fixdateonceagreed>
                <xsl:value-of select=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:fixdateonceagreed/text()"" />
              </ns9:fixdateonceagreed>
            </xsl:if>
          </xsl:if>
          <xsl:if test=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:ScheduledDate"">
            <xsl:variable name=""var:v126"" select=""string(InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:ScheduledDate/@xsi:nil) = 'true'"" />
            <xsl:if test=""string($var:v126)='true'"">
              <ns9:ScheduledDate>
                <xsl:attribute name=""xsi:nil"">
                  <xsl:value-of select=""'true'"" />
                </xsl:attribute>
              </ns9:ScheduledDate>
            </xsl:if>
            <xsl:if test=""string($var:v126)='false'"">
              <ns9:ScheduledDate>
                <xsl:value-of select=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:ScheduledDate/text()"" />
              </ns9:ScheduledDate>
            </xsl:if>
          </xsl:if>
          <xsl:if test=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:FollowUpNote"">
            <xsl:variable name=""var:v127"" select=""string(InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:FollowUpNote/@xsi:nil) = 'true'"" />
            <xsl:if test=""string($var:v127)='true'"">
              <ns9:FollowUpNote>
                <xsl:attribute name=""xsi:nil"">
                  <xsl:value-of select=""'true'"" />
                </xsl:attribute>
              </ns9:FollowUpNote>
            </xsl:if>
            <xsl:if test=""string($var:v127)='false'"">
              <ns9:FollowUpNote>
                <xsl:value-of select=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:FollowUpNote/text()"" />
              </ns9:FollowUpNote>
            </xsl:if>
          </xsl:if>
          <xsl:if test=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:MasterHelpeskCaseId"">
            <xsl:variable name=""var:v128"" select=""string(InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:MasterHelpeskCaseId/@xsi:nil) = 'true'"" />
            <xsl:if test=""string($var:v128)='true'"">
              <ns9:MasterHelpeskCaseId>
                <xsl:attribute name=""xsi:nil"">
                  <xsl:value-of select=""'true'"" />
                </xsl:attribute>
              </ns9:MasterHelpeskCaseId>
            </xsl:if>
            <xsl:if test=""string($var:v128)='false'"">
              <ns9:MasterHelpeskCaseId>
                <xsl:value-of select=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:MasterHelpeskCaseId/text()"" />
              </ns9:MasterHelpeskCaseId>
            </xsl:if>
          </xsl:if>
          <xsl:if test=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:NextMilestone"">
            <xsl:variable name=""var:v129"" select=""string(InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:NextMilestone/@xsi:nil) = 'true'"" />
            <xsl:if test=""string($var:v129)='true'"">
              <ns9:NextMilestone>
                <xsl:attribute name=""xsi:nil"">
                  <xsl:value-of select=""'true'"" />
                </xsl:attribute>
              </ns9:NextMilestone>
            </xsl:if>
            <xsl:if test=""string($var:v129)='false'"">
              <ns9:NextMilestone>
                <xsl:value-of select=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:NextMilestone/text()"" />
              </ns9:NextMilestone>
            </xsl:if>
          </xsl:if>
          <xsl:if test=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:NextMilestoneTS"">
            <xsl:variable name=""var:v130"" select=""string(InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:NextMilestoneTS/@xsi:nil) = 'true'"" />
            <xsl:if test=""string($var:v130)='true'"">
              <ns9:NextMilestoneTS>
                <xsl:attribute name=""xsi:nil"">
                  <xsl:value-of select=""'true'"" />
                </xsl:attribute>
              </ns9:NextMilestoneTS>
            </xsl:if>
            <xsl:if test=""string($var:v130)='false'"">
              <ns9:NextMilestoneTS>
                <xsl:value-of select=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:NextMilestoneTS/text()"" />
              </ns9:NextMilestoneTS>
            </xsl:if>
          </xsl:if>
          <xsl:if test=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:NextMilestoneWarningTS"">
            <xsl:variable name=""var:v131"" select=""string(InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:NextMilestoneWarningTS/@xsi:nil) = 'true'"" />
            <xsl:if test=""string($var:v131)='true'"">
              <ns9:NextMilestoneWarningTS>
                <xsl:attribute name=""xsi:nil"">
                  <xsl:value-of select=""'true'"" />
                </xsl:attribute>
              </ns9:NextMilestoneWarningTS>
            </xsl:if>
            <xsl:if test=""string($var:v131)='false'"">
              <ns9:NextMilestoneWarningTS>
                <xsl:value-of select=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:NextMilestoneWarningTS/text()"" />
              </ns9:NextMilestoneWarningTS>
            </xsl:if>
          </xsl:if>
          <xsl:if test=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:TargetSystemId"">
            <xsl:variable name=""var:v132"" select=""string(InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:TargetSystemId/@xsi:nil) = 'true'"" />
            <xsl:if test=""string($var:v132)='true'"">
              <ns9:TargetSystemId>
                <xsl:attribute name=""xsi:nil"">
                  <xsl:value-of select=""'true'"" />
                </xsl:attribute>
              </ns9:TargetSystemId>
            </xsl:if>
            <xsl:if test=""string($var:v132)='false'"">
              <ns9:TargetSystemId>
                <xsl:value-of select=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:TargetSystemId/text()"" />
              </ns9:TargetSystemId>
            </xsl:if>
          </xsl:if>
          <xsl:if test=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:TargetSystem"">
            <ns9:TargetSystem>
              <xsl:value-of select=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:TargetSystem/text()"" />
            </ns9:TargetSystem>
          </xsl:if>
          <xsl:if test=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:RejectionNote"">
            <xsl:variable name=""var:v133"" select=""string(InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:RejectionNote/@xsi:nil) = 'true'"" />
            <xsl:if test=""string($var:v133)='true'"">
              <ns9:RejectionNote>
                <xsl:attribute name=""xsi:nil"">
                  <xsl:value-of select=""'true'"" />
                </xsl:attribute>
              </ns9:RejectionNote>
            </xsl:if>
            <xsl:if test=""string($var:v133)='false'"">
              <ns9:RejectionNote>
                <xsl:value-of select=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:RejectionNote/text()"" />
              </ns9:RejectionNote>
            </xsl:if>
          </xsl:if>
          <xsl:if test=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:POnumber"">
            <xsl:variable name=""var:v134"" select=""string(InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:POnumber/@xsi:nil) = 'true'"" />
            <xsl:if test=""string($var:v134)='true'"">
              <ns9:POnumber>
                <xsl:attribute name=""xsi:nil"">
                  <xsl:value-of select=""'true'"" />
                </xsl:attribute>
              </ns9:POnumber>
            </xsl:if>
            <xsl:if test=""string($var:v134)='false'"">
              <ns9:POnumber>
                <xsl:value-of select=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:POnumber/text()"" />
              </ns9:POnumber>
            </xsl:if>
          </xsl:if>
          <xsl:if test=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:SOnumber"">
            <xsl:variable name=""var:v135"" select=""string(InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:SOnumber/@xsi:nil) = 'true'"" />
            <xsl:if test=""string($var:v135)='true'"">
              <ns9:SOnumber>
                <xsl:attribute name=""xsi:nil"">
                  <xsl:value-of select=""'true'"" />
                </xsl:attribute>
              </ns9:SOnumber>
            </xsl:if>
            <xsl:if test=""string($var:v135)='false'"">
              <ns9:SOnumber>
                <xsl:value-of select=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:SOnumber/text()"" />
              </ns9:SOnumber>
            </xsl:if>
          </xsl:if>
          <xsl:if test=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:CustomerCostCentre"">
            <xsl:variable name=""var:v136"" select=""string(InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:CustomerCostCentre/@xsi:nil) = 'true'"" />
            <xsl:if test=""string($var:v136)='true'"">
              <ns9:CustomerCostCentre>
                <xsl:attribute name=""xsi:nil"">
                  <xsl:value-of select=""'true'"" />
                </xsl:attribute>
              </ns9:CustomerCostCentre>
            </xsl:if>
            <xsl:if test=""string($var:v136)='false'"">
              <ns9:CustomerCostCentre>
                <xsl:value-of select=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:CustomerCostCentre/text()"" />
              </ns9:CustomerCostCentre>
            </xsl:if>
          </xsl:if>
          <xsl:if test=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:CustomerQuestions"">
            <xsl:variable name=""var:v137"" select=""string(InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:CustomerQuestions/@xsi:nil) = 'true'"" />
            <xsl:if test=""string($var:v137)='true'"">
              <ns9:CustomerQuestions>
                <xsl:attribute name=""xsi:nil"">
                  <xsl:value-of select=""'true'"" />
                </xsl:attribute>
              </ns9:CustomerQuestions>
            </xsl:if>
            <xsl:if test=""string($var:v137)='false'"">
              <ns9:CustomerQuestions>
                <xsl:value-of select=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:CustomerQuestions/text()"" />
              </ns9:CustomerQuestions>
            </xsl:if>
          </xsl:if>
          <xsl:for-each select=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns10:Customer"">
            <ns10:Customer>
              <xsl:if test=""@Id"">
                <xsl:attribute name=""Id"">
                  <xsl:value-of select=""@Id"" />
                </xsl:attribute>
              </xsl:if>
              <Name>
                <xsl:value-of select=""Name/text()"" />
              </Name>
              <xsl:variable name=""var:v138"" select=""string(CustomerType/@xsi:nil) = 'true'"" />
              <xsl:if test=""string($var:v138)='true'"">
                <CustomerType>
                  <xsl:attribute name=""xsi:nil"">
                    <xsl:value-of select=""'true'"" />
                  </xsl:attribute>
                </CustomerType>
              </xsl:if>
              <xsl:if test=""string($var:v138)='false'"">
                <CustomerType>
                  <xsl:value-of select=""CustomerType/text()"" />
                </CustomerType>
              </xsl:if>
              <xsl:variable name=""var:v139"" select=""string(PersonId/@xsi:nil) = 'true'"" />
              <xsl:if test=""string($var:v139)='true'"">
                <PersonId>
                  <xsl:attribute name=""xsi:nil"">
                    <xsl:value-of select=""'true'"" />
                  </xsl:attribute>
                </PersonId>
              </xsl:if>
              <xsl:if test=""string($var:v139)='false'"">
                <PersonId>
                  <xsl:value-of select=""PersonId/text()"" />
                </PersonId>
              </xsl:if>
              <xsl:variable name=""var:v140"" select=""string(AddressId/@xsi:nil) = 'true'"" />
              <xsl:if test=""string($var:v140)='true'"">
                <AddressId>
                  <xsl:attribute name=""xsi:nil"">
                    <xsl:value-of select=""'true'"" />
                  </xsl:attribute>
                </AddressId>
              </xsl:if>
              <xsl:if test=""string($var:v140)='false'"">
                <AddressId>
                  <xsl:value-of select=""AddressId/text()"" />
                </AddressId>
              </xsl:if>
              <xsl:if test=""Division"">
                <xsl:variable name=""var:v141"" select=""string(Division/@xsi:nil) = 'true'"" />
                <xsl:if test=""string($var:v141)='true'"">
                  <Division>
                    <xsl:attribute name=""xsi:nil"">
                      <xsl:value-of select=""'true'"" />
                    </xsl:attribute>
                  </Division>
                </xsl:if>
                <xsl:if test=""string($var:v141)='false'"">
                  <Division>
                    <xsl:value-of select=""Division/text()"" />
                  </Division>
                </xsl:if>
              </xsl:if>
              <xsl:value-of select=""./text()"" />
            </ns10:Customer>
          </xsl:for-each>
          <xsl:for-each select=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns4:Person"">
            <ns4:Person>
              <xsl:if test=""@Id"">
                <xsl:attribute name=""Id"">
                  <xsl:value-of select=""@Id"" />
                </xsl:attribute>
              </xsl:if>
              <xsl:if test=""CompanyId"">
                <CompanyId>
                  <xsl:value-of select=""CompanyId/text()"" />
                </CompanyId>
              </xsl:if>
              <xsl:if test=""AddressId"">
                <xsl:variable name=""var:v142"" select=""string(AddressId/@xsi:nil) = 'true'"" />
                <xsl:if test=""string($var:v142)='true'"">
                  <AddressId>
                    <xsl:attribute name=""xsi:nil"">
                      <xsl:value-of select=""'true'"" />
                    </xsl:attribute>
                  </AddressId>
                </xsl:if>
                <xsl:if test=""string($var:v142)='false'"">
                  <AddressId>
                    <xsl:value-of select=""AddressId/text()"" />
                  </AddressId>
                </xsl:if>
              </xsl:if>
              <xsl:if test=""UserId"">
                <xsl:variable name=""var:v143"" select=""string(UserId/@xsi:nil) = 'true'"" />
                <xsl:if test=""string($var:v143)='true'"">
                  <UserId>
                    <xsl:attribute name=""xsi:nil"">
                      <xsl:value-of select=""'true'"" />
                    </xsl:attribute>
                  </UserId>
                </xsl:if>
                <xsl:if test=""string($var:v143)='false'"">
                  <UserId>
                    <xsl:value-of select=""UserId/text()"" />
                  </UserId>
                </xsl:if>
              </xsl:if>
              <xsl:if test=""Salutation"">
                <xsl:variable name=""var:v144"" select=""string(Salutation/@xsi:nil) = 'true'"" />
                <xsl:if test=""string($var:v144)='true'"">
                  <Salutation>
                    <xsl:attribute name=""xsi:nil"">
                      <xsl:value-of select=""'true'"" />
                    </xsl:attribute>
                  </Salutation>
                </xsl:if>
                <xsl:if test=""string($var:v144)='false'"">
                  <Salutation>
                    <xsl:value-of select=""Salutation/text()"" />
                  </Salutation>
                </xsl:if>
              </xsl:if>
              <xsl:if test=""FirstName"">
                <xsl:variable name=""var:v145"" select=""string(FirstName/@xsi:nil) = 'true'"" />
                <xsl:if test=""string($var:v145)='true'"">
                  <FirstName>
                    <xsl:attribute name=""xsi:nil"">
                      <xsl:value-of select=""'true'"" />
                    </xsl:attribute>
                  </FirstName>
                </xsl:if>
                <xsl:if test=""string($var:v145)='false'"">
                  <FirstName>
                    <xsl:value-of select=""FirstName/text()"" />
                  </FirstName>
                </xsl:if>
              </xsl:if>
              <xsl:if test=""LastName"">
                <xsl:variable name=""var:v146"" select=""string(LastName/@xsi:nil) = 'true'"" />
                <xsl:if test=""string($var:v146)='true'"">
                  <LastName>
                    <xsl:attribute name=""xsi:nil"">
                      <xsl:value-of select=""'true'"" />
                    </xsl:attribute>
                  </LastName>
                </xsl:if>
                <xsl:if test=""string($var:v146)='false'"">
                  <LastName>
                    <xsl:value-of select=""LastName/text()"" />
                  </LastName>
                </xsl:if>
              </xsl:if>
              <xsl:if test=""MiddleName"">
                <xsl:variable name=""var:v147"" select=""string(MiddleName/@xsi:nil) = 'true'"" />
                <xsl:if test=""string($var:v147)='true'"">
                  <MiddleName>
                    <xsl:attribute name=""xsi:nil"">
                      <xsl:value-of select=""'true'"" />
                    </xsl:attribute>
                  </MiddleName>
                </xsl:if>
                <xsl:if test=""string($var:v147)='false'"">
                  <MiddleName>
                    <xsl:value-of select=""MiddleName/text()"" />
                  </MiddleName>
                </xsl:if>
              </xsl:if>
              <xsl:if test=""suffix"">
                <xsl:variable name=""var:v148"" select=""string(suffix/@xsi:nil) = 'true'"" />
                <xsl:if test=""string($var:v148)='true'"">
                  <suffix>
                    <xsl:attribute name=""xsi:nil"">
                      <xsl:value-of select=""'true'"" />
                    </xsl:attribute>
                  </suffix>
                </xsl:if>
                <xsl:if test=""string($var:v148)='false'"">
                  <suffix>
                    <xsl:value-of select=""suffix/text()"" />
                  </suffix>
                </xsl:if>
              </xsl:if>
              <xsl:if test=""gender"">
                <xsl:variable name=""var:v149"" select=""string(gender/@xsi:nil) = 'true'"" />
                <xsl:if test=""string($var:v149)='true'"">
                  <gender>
                    <xsl:attribute name=""xsi:nil"">
                      <xsl:value-of select=""'true'"" />
                    </xsl:attribute>
                  </gender>
                </xsl:if>
                <xsl:if test=""string($var:v149)='false'"">
                  <gender>
                    <xsl:value-of select=""gender/text()"" />
                  </gender>
                </xsl:if>
              </xsl:if>
              <xsl:if test=""title"">
                <xsl:variable name=""var:v150"" select=""string(title/@xsi:nil) = 'true'"" />
                <xsl:if test=""string($var:v150)='true'"">
                  <title>
                    <xsl:attribute name=""xsi:nil"">
                      <xsl:value-of select=""'true'"" />
                    </xsl:attribute>
                  </title>
                </xsl:if>
                <xsl:if test=""string($var:v150)='false'"">
                  <title>
                    <xsl:value-of select=""title/text()"" />
                  </title>
                </xsl:if>
              </xsl:if>
              <xsl:if test=""department"">
                <xsl:variable name=""var:v151"" select=""string(department/@xsi:nil) = 'true'"" />
                <xsl:if test=""string($var:v151)='true'"">
                  <department>
                    <xsl:attribute name=""xsi:nil"">
                      <xsl:value-of select=""'true'"" />
                    </xsl:attribute>
                  </department>
                </xsl:if>
                <xsl:if test=""string($var:v151)='false'"">
                  <department>
                    <xsl:value-of select=""department/text()"" />
                  </department>
                </xsl:if>
              </xsl:if>
              <xsl:if test=""locationid"">
                <xsl:variable name=""var:v152"" select=""string(locationid/@xsi:nil) = 'true'"" />
                <xsl:if test=""string($var:v152)='true'"">
                  <locationid>
                    <xsl:attribute name=""xsi:nil"">
                      <xsl:value-of select=""'true'"" />
                    </xsl:attribute>
                  </locationid>
                </xsl:if>
                <xsl:if test=""string($var:v152)='false'"">
                  <locationid>
                    <xsl:value-of select=""locationid/text()"" />
                  </locationid>
                </xsl:if>
              </xsl:if>
              <xsl:if test=""contactmethod"">
                <xsl:variable name=""var:v153"" select=""string(contactmethod/@xsi:nil) = 'true'"" />
                <xsl:if test=""string($var:v153)='true'"">
                  <contactmethod>
                    <xsl:attribute name=""xsi:nil"">
                      <xsl:value-of select=""'true'"" />
                    </xsl:attribute>
                  </contactmethod>
                </xsl:if>
                <xsl:if test=""string($var:v153)='false'"">
                  <contactmethod>
                    <xsl:value-of select=""contactmethod/text()"" />
                  </contactmethod>
                </xsl:if>
              </xsl:if>
              <xsl:if test=""PhoneNumber"">
                <xsl:variable name=""var:v154"" select=""string(PhoneNumber/@xsi:nil) = 'true'"" />
                <xsl:if test=""string($var:v154)='true'"">
                  <PhoneNumber>
                    <xsl:attribute name=""xsi:nil"">
                      <xsl:value-of select=""'true'"" />
                    </xsl:attribute>
                  </PhoneNumber>
                </xsl:if>
                <xsl:if test=""string($var:v154)='false'"">
                  <PhoneNumber>
                    <xsl:value-of select=""PhoneNumber/text()"" />
                  </PhoneNumber>
                </xsl:if>
              </xsl:if>
              <xsl:if test=""EmailAddress"">
                <xsl:variable name=""var:v155"" select=""string(EmailAddress/@xsi:nil) = 'true'"" />
                <xsl:if test=""string($var:v155)='true'"">
                  <EmailAddress>
                    <xsl:attribute name=""xsi:nil"">
                      <xsl:value-of select=""'true'"" />
                    </xsl:attribute>
                  </EmailAddress>
                </xsl:if>
                <xsl:if test=""string($var:v155)='false'"">
                  <EmailAddress>
                    <xsl:value-of select=""EmailAddress/text()"" />
                  </EmailAddress>
                </xsl:if>
              </xsl:if>
              <xsl:if test=""FaxNumber"">
                <xsl:variable name=""var:v156"" select=""string(FaxNumber/@xsi:nil) = 'true'"" />
                <xsl:if test=""string($var:v156)='true'"">
                  <FaxNumber>
                    <xsl:attribute name=""xsi:nil"">
                      <xsl:value-of select=""'true'"" />
                    </xsl:attribute>
                  </FaxNumber>
                </xsl:if>
                <xsl:if test=""string($var:v156)='false'"">
                  <FaxNumber>
                    <xsl:value-of select=""FaxNumber/text()"" />
                  </FaxNumber>
                </xsl:if>
              </xsl:if>
              <xsl:value-of select=""./text()"" />
            </ns4:Person>
          </xsl:for-each>
          <xsl:for-each select=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns5:Location"">
            <xsl:variable name=""var:v178"" select=""userCSharp:LogicalGt(string(../../../../../InputMessagePart_1/s0:QueryMXVISIONLOCQUERYResponse/@rsCount) , &quot;0&quot;)"" />
            <xsl:variable name=""var:v180"" select=""string(../../../../../InputMessagePart_1/s0:QueryMXVISIONLOCQUERYResponse/@rsCount)"" />
            <xsl:variable name=""var:v181"" select=""userCSharp:LogicalEq($var:v180 , &quot;0&quot;)"" />
            <xsl:variable name=""var:v182"" select=""userCSharp:StringConcat(&quot;&quot;)"" />
            <ns5:Location>
              <xsl:if test=""@linkid"">
                <xsl:attribute name=""linkid"">
                  <xsl:value-of select=""@linkid"" />
                </xsl:attribute>
              </xsl:if>
              <xsl:if test=""linkcompany"">
                <linkcompany>
                  <xsl:value-of select=""linkcompany/text()"" />
                </linkcompany>
              </xsl:if>
              <xsl:if test=""linkperson"">
                <xsl:variable name=""var:v157"" select=""string(linkperson/@xsi:nil) = 'true'"" />
                <xsl:if test=""string($var:v157)='true'"">
                  <linkperson>
                    <xsl:attribute name=""xsi:nil"">
                      <xsl:value-of select=""'true'"" />
                    </xsl:attribute>
                  </linkperson>
                </xsl:if>
                <xsl:if test=""string($var:v157)='false'"">
                  <linkperson>
                    <xsl:value-of select=""linkperson/text()"" />
                  </linkperson>
                </xsl:if>
              </xsl:if>
              <xsl:if test=""linktype"">
                <xsl:variable name=""var:v158"" select=""string(linktype/@xsi:nil) = 'true'"" />
                <xsl:if test=""string($var:v158)='true'"">
                  <linktype>
                    <xsl:attribute name=""xsi:nil"">
                      <xsl:value-of select=""'true'"" />
                    </xsl:attribute>
                  </linktype>
                </xsl:if>
                <xsl:if test=""string($var:v158)='false'"">
                  <linktype>
                    <xsl:value-of select=""linktype/text()"" />
                  </linktype>
                </xsl:if>
              </xsl:if>
              <xsl:if test=""linkdivisionid"">
                <xsl:variable name=""var:v159"" select=""string(linkdivisionid/@xsi:nil) = 'true'"" />
                <xsl:if test=""string($var:v159)='true'"">
                  <linkdivisionid>
                    <xsl:attribute name=""xsi:nil"">
                      <xsl:value-of select=""'true'"" />
                    </xsl:attribute>
                  </linkdivisionid>
                </xsl:if>
                <xsl:if test=""string($var:v159)='false'"">
                  <linkdivisionid>
                    <xsl:value-of select=""linkdivisionid/text()"" />
                  </linkdivisionid>
                </xsl:if>
              </xsl:if>
              <xsl:if test=""linkregionid"">
                <xsl:variable name=""var:v160"" select=""string(linkregionid/@xsi:nil) = 'true'"" />
                <xsl:if test=""string($var:v160)='true'"">
                  <linkregionid>
                    <xsl:attribute name=""xsi:nil"">
                      <xsl:value-of select=""'true'"" />
                    </xsl:attribute>
                  </linkregionid>
                </xsl:if>
                <xsl:if test=""string($var:v160)='false'"">
                  <linkregionid>
                    <xsl:value-of select=""linkregionid/text()"" />
                  </linkregionid>
                </xsl:if>
              </xsl:if>
              <xsl:if test=""linkcampusid"">
                <xsl:variable name=""var:v161"" select=""string(linkcampusid/@xsi:nil) = 'true'"" />
                <xsl:if test=""string($var:v161)='true'"">
                  <linkcampusid>
                    <xsl:attribute name=""xsi:nil"">
                      <xsl:value-of select=""'true'"" />
                    </xsl:attribute>
                  </linkcampusid>
                </xsl:if>
                <xsl:if test=""string($var:v161)='false'"">
                  <linkcampusid>
                    <xsl:value-of select=""linkcampusid/text()"" />
                  </linkcampusid>
                </xsl:if>
              </xsl:if>
              <xsl:if test=""linkareaid"">
                <xsl:variable name=""var:v162"" select=""string(linkareaid/@xsi:nil) = 'true'"" />
                <xsl:if test=""string($var:v162)='true'"">
                  <linkareaid>
                    <xsl:attribute name=""xsi:nil"">
                      <xsl:value-of select=""'true'"" />
                    </xsl:attribute>
                  </linkareaid>
                </xsl:if>
                <xsl:if test=""string($var:v162)='false'"">
                  <linkareaid>
                    <xsl:value-of select=""linkareaid/text()"" />
                  </linkareaid>
                </xsl:if>
              </xsl:if>
              <xsl:if test=""linkstart"">
                <xsl:variable name=""var:v163"" select=""string(linkstart/@xsi:nil) = 'true'"" />
                <xsl:if test=""string($var:v163)='true'"">
                  <linkstart>
                    <xsl:attribute name=""xsi:nil"">
                      <xsl:value-of select=""'true'"" />
                    </xsl:attribute>
                  </linkstart>
                </xsl:if>
                <xsl:if test=""string($var:v163)='false'"">
                  <linkstart>
                    <xsl:value-of select=""linkstart/text()"" />
                  </linkstart>
                </xsl:if>
              </xsl:if>
              <xsl:if test=""linkend"">
                <xsl:variable name=""var:v164"" select=""string(linkend/@xsi:nil) = 'true'"" />
                <xsl:if test=""string($var:v164)='true'"">
                  <linkend>
                    <xsl:attribute name=""xsi:nil"">
                      <xsl:value-of select=""'true'"" />
                    </xsl:attribute>
                  </linkend>
                </xsl:if>
                <xsl:if test=""string($var:v164)='false'"">
                  <linkend>
                    <xsl:value-of select=""linkend/text()"" />
                  </linkend>
                </xsl:if>
              </xsl:if>
              <xsl:if test=""linkcn"">
                <xsl:variable name=""var:v165"" select=""string(linkcn/@xsi:nil) = 'true'"" />
                <xsl:if test=""string($var:v165)='true'"">
                  <linkcn>
                    <xsl:attribute name=""xsi:nil"">
                      <xsl:value-of select=""'true'"" />
                    </xsl:attribute>
                  </linkcn>
                </xsl:if>
                <xsl:if test=""string($var:v165)='false'"">
                  <linkcn>
                    <xsl:value-of select=""linkcn/text()"" />
                  </linkcn>
                </xsl:if>
              </xsl:if>
              <xsl:if test=""linkpropertyid"">
                <xsl:variable name=""var:v166"" select=""string(linkpropertyid/@xsi:nil) = 'true'"" />
                <xsl:if test=""string($var:v166)='true'"">
                  <linkpropertyid>
                    <xsl:attribute name=""xsi:nil"">
                      <xsl:value-of select=""'true'"" />
                    </xsl:attribute>
                  </linkpropertyid>
                </xsl:if>
                <xsl:if test=""string($var:v166)='false'"">
                  <linkpropertyid>
                    <xsl:value-of select=""linkpropertyid/text()"" />
                  </linkpropertyid>
                </xsl:if>
              </xsl:if>
              <xsl:if test=""linkMitiePropertyCode"">
                <xsl:variable name=""var:v167"" select=""string(linkMitiePropertyCode/@xsi:nil) = 'true'"" />
                <xsl:if test=""string($var:v167)='true'"">
                  <linkMitiePropertyCode>
                    <xsl:attribute name=""xsi:nil"">
                      <xsl:value-of select=""'true'"" />
                    </xsl:attribute>
                  </linkMitiePropertyCode>
                </xsl:if>
                <xsl:if test=""string($var:v167)='false'"">
                  <linkMitiePropertyCode>
                    <xsl:value-of select=""linkMitiePropertyCode/text()"" />
                  </linkMitiePropertyCode>
                </xsl:if>
              </xsl:if>
              <xsl:if test=""linkClientPropertyCode"">
                <xsl:variable name=""var:v168"" select=""string(linkClientPropertyCode/@xsi:nil) = 'true'"" />
                <xsl:if test=""string($var:v168)='true'"">
                  <linkClientPropertyCode>
                    <xsl:attribute name=""xsi:nil"">
                      <xsl:value-of select=""'true'"" />
                    </xsl:attribute>
                  </linkClientPropertyCode>
                </xsl:if>
                <xsl:if test=""string($var:v168)='false'"">
                  <linkClientPropertyCode>
                    <xsl:value-of select=""linkClientPropertyCode/text()"" />
                  </linkClientPropertyCode>
                </xsl:if>
              </xsl:if>
              <xsl:if test=""linkRegionName"">
                <xsl:variable name=""var:v169"" select=""string(linkRegionName/@xsi:nil) = 'true'"" />
                <xsl:if test=""string($var:v169)='true'"">
                  <linkRegionName>
                    <xsl:attribute name=""xsi:nil"">
                      <xsl:value-of select=""'true'"" />
                    </xsl:attribute>
                  </linkRegionName>
                </xsl:if>
                <xsl:if test=""string($var:v169)='false'"">
                  <linkRegionName>
                    <xsl:value-of select=""linkRegionName/text()"" />
                  </linkRegionName>
                </xsl:if>
              </xsl:if>
              <ns8:Address>
                <xsl:if test=""ns8:Address/@siteid"">
                  <xsl:attribute name=""siteid"">
                    <xsl:value-of select=""ns8:Address/@siteid"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:if test=""ns8:Address/siteAddress1"">
                  <siteAddress1>
                    <xsl:value-of select=""ns8:Address/siteAddress1/text()"" />
                  </siteAddress1>
                </xsl:if>
                <xsl:if test=""ns8:Address/siteAddress2"">
                  <xsl:variable name=""var:v170"" select=""string(ns8:Address/siteAddress2/@xsi:nil) = 'true'"" />
                  <xsl:if test=""string($var:v170)='true'"">
                    <siteAddress2>
                      <xsl:attribute name=""xsi:nil"">
                        <xsl:value-of select=""'true'"" />
                      </xsl:attribute>
                    </siteAddress2>
                  </xsl:if>
                  <xsl:if test=""string($var:v170)='false'"">
                    <siteAddress2>
                      <xsl:value-of select=""ns8:Address/siteAddress2/text()"" />
                    </siteAddress2>
                  </xsl:if>
                </xsl:if>
                <xsl:if test=""ns8:Address/siteAddress3"">
                  <xsl:variable name=""var:v171"" select=""string(ns8:Address/siteAddress3/@xsi:nil) = 'true'"" />
                  <xsl:if test=""string($var:v171)='true'"">
                    <siteAddress3>
                      <xsl:attribute name=""xsi:nil"">
                        <xsl:value-of select=""'true'"" />
                      </xsl:attribute>
                    </siteAddress3>
                  </xsl:if>
                  <xsl:if test=""string($var:v171)='false'"">
                    <siteAddress3>
                      <xsl:value-of select=""ns8:Address/siteAddress3/text()"" />
                    </siteAddress3>
                  </xsl:if>
                </xsl:if>
                <xsl:if test=""ns8:Address/siteAddress4"">
                  <xsl:variable name=""var:v172"" select=""string(ns8:Address/siteAddress4/@xsi:nil) = 'true'"" />
                  <xsl:if test=""string($var:v172)='true'"">
                    <siteAddress4>
                      <xsl:attribute name=""xsi:nil"">
                        <xsl:value-of select=""'true'"" />
                      </xsl:attribute>
                    </siteAddress4>
                  </xsl:if>
                  <xsl:if test=""string($var:v172)='false'"">
                    <siteAddress4>
                      <xsl:value-of select=""ns8:Address/siteAddress4/text()"" />
                    </siteAddress4>
                  </xsl:if>
                </xsl:if>
                <xsl:if test=""ns8:Address/siteAddress5"">
                  <xsl:variable name=""var:v173"" select=""string(ns8:Address/siteAddress5/@xsi:nil) = 'true'"" />
                  <xsl:if test=""string($var:v173)='true'"">
                    <siteAddress5>
                      <xsl:attribute name=""xsi:nil"">
                        <xsl:value-of select=""'true'"" />
                      </xsl:attribute>
                    </siteAddress5>
                  </xsl:if>
                  <xsl:if test=""string($var:v173)='false'"">
                    <siteAddress5>
                      <xsl:value-of select=""ns8:Address/siteAddress5/text()"" />
                    </siteAddress5>
                  </xsl:if>
                </xsl:if>
                <xsl:if test=""ns8:Address/siteCity"">
                  <xsl:variable name=""var:v174"" select=""string(ns8:Address/siteCity/@xsi:nil) = 'true'"" />
                  <xsl:if test=""string($var:v174)='true'"">
                    <siteCity>
                      <xsl:attribute name=""xsi:nil"">
                        <xsl:value-of select=""'true'"" />
                      </xsl:attribute>
                    </siteCity>
                  </xsl:if>
                  <xsl:if test=""string($var:v174)='false'"">
                    <siteCity>
                      <xsl:value-of select=""ns8:Address/siteCity/text()"" />
                    </siteCity>
                  </xsl:if>
                </xsl:if>
                <xsl:if test=""ns8:Address/siteState"">
                  <xsl:variable name=""var:v175"" select=""string(ns8:Address/siteState/@xsi:nil) = 'true'"" />
                  <xsl:if test=""string($var:v175)='true'"">
                    <siteState>
                      <xsl:attribute name=""xsi:nil"">
                        <xsl:value-of select=""'true'"" />
                      </xsl:attribute>
                    </siteState>
                  </xsl:if>
                  <xsl:if test=""string($var:v175)='false'"">
                    <siteState>
                      <xsl:value-of select=""ns8:Address/siteState/text()"" />
                    </siteState>
                  </xsl:if>
                </xsl:if>
                <xsl:if test=""ns8:Address/siteCountry"">
                  <xsl:variable name=""var:v176"" select=""string(ns8:Address/siteCountry/@xsi:nil) = 'true'"" />
                  <xsl:if test=""string($var:v176)='true'"">
                    <siteCountry>
                      <xsl:attribute name=""xsi:nil"">
                        <xsl:value-of select=""'true'"" />
                      </xsl:attribute>
                    </siteCountry>
                  </xsl:if>
                  <xsl:if test=""string($var:v176)='false'"">
                    <siteCountry>
                      <xsl:value-of select=""ns8:Address/siteCountry/text()"" />
                    </siteCountry>
                  </xsl:if>
                </xsl:if>
                <xsl:if test=""ns8:Address/sitePostCode"">
                  <xsl:variable name=""var:v177"" select=""string(ns8:Address/sitePostCode/@xsi:nil) = 'true'"" />
                  <xsl:if test=""string($var:v177)='true'"">
                    <sitePostCode>
                      <xsl:attribute name=""xsi:nil"">
                        <xsl:value-of select=""'true'"" />
                      </xsl:attribute>
                    </sitePostCode>
                  </xsl:if>
                  <xsl:if test=""string($var:v177)='false'"">
                    <sitePostCode>
                      <xsl:value-of select=""ns8:Address/sitePostCode/text()"" />
                    </sitePostCode>
                  </xsl:if>
                </xsl:if>
                <xsl:if test=""string($var:v178)='true'"">
                  <xsl:variable name=""var:v179"" select=""../../../../../InputMessagePart_1/s0:QueryMXVISIONLOCQUERYResponse/s0:MXVISIONLOCQUERYSet/s0:LOCATIONS/s0:SITEID/text()"" />
                  <siteSiteName>
                    <xsl:value-of select=""$var:v179"" />
                  </siteSiteName>
                </xsl:if>
                <xsl:if test=""string($var:v181)='true'"">
                  <xsl:variable name=""var:v183"" select=""string($var:v182)"" />
                  <siteSiteName>
                    <xsl:value-of select=""$var:v183"" />
                  </siteSiteName>
                </xsl:if>
                <xsl:if test=""ns8:Address/siteSiteID"">
                  <xsl:variable name=""var:v184"" select=""string(ns8:Address/siteSiteID/@xsi:nil) = 'true'"" />
                  <xsl:if test=""string($var:v184)='true'"">
                    <siteSiteID>
                      <xsl:attribute name=""xsi:nil"">
                        <xsl:value-of select=""'true'"" />
                      </xsl:attribute>
                    </siteSiteID>
                  </xsl:if>
                  <xsl:if test=""string($var:v184)='false'"">
                    <siteSiteID>
                      <xsl:value-of select=""ns8:Address/siteSiteID/text()"" />
                    </siteSiteID>
                  </xsl:if>
                </xsl:if>
                <xsl:if test=""../../../../../InputMessagePart_1/s0:QueryMXVISIONLOCQUERYResponse/s0:MXVISIONLOCQUERYSet/s0:LOCATIONS/s0:LOCATION"">
                  <siteSecondaryClientSiteID>
                    <xsl:value-of select=""../../../../../InputMessagePart_1/s0:QueryMXVISIONLOCQUERYResponse/s0:MXVISIONLOCQUERYSet/s0:LOCATIONS/s0:LOCATION/text()"" />
                  </siteSecondaryClientSiteID>
                </xsl:if>
                <xsl:if test=""ns8:Address/siteDivisionid"">
                  <xsl:variable name=""var:v185"" select=""string(ns8:Address/siteDivisionid/@xsi:nil) = 'true'"" />
                  <xsl:if test=""string($var:v185)='true'"">
                    <siteDivisionid>
                      <xsl:attribute name=""xsi:nil"">
                        <xsl:value-of select=""'true'"" />
                      </xsl:attribute>
                    </siteDivisionid>
                  </xsl:if>
                  <xsl:if test=""string($var:v185)='false'"">
                    <siteDivisionid>
                      <xsl:value-of select=""ns8:Address/siteDivisionid/text()"" />
                    </siteDivisionid>
                  </xsl:if>
                </xsl:if>
                <xsl:if test=""ns8:Address/siteRegionid"">
                  <xsl:variable name=""var:v186"" select=""string(ns8:Address/siteRegionid/@xsi:nil) = 'true'"" />
                  <xsl:if test=""string($var:v186)='true'"">
                    <siteRegionid>
                      <xsl:attribute name=""xsi:nil"">
                        <xsl:value-of select=""'true'"" />
                      </xsl:attribute>
                    </siteRegionid>
                  </xsl:if>
                  <xsl:if test=""string($var:v186)='false'"">
                    <siteRegionid>
                      <xsl:value-of select=""ns8:Address/siteRegionid/text()"" />
                    </siteRegionid>
                  </xsl:if>
                </xsl:if>
                <xsl:if test=""ns8:Address/siteLatitude"">
                  <xsl:variable name=""var:v187"" select=""string(ns8:Address/siteLatitude/@xsi:nil) = 'true'"" />
                  <xsl:if test=""string($var:v187)='true'"">
                    <siteLatitude>
                      <xsl:attribute name=""xsi:nil"">
                        <xsl:value-of select=""'true'"" />
                      </xsl:attribute>
                    </siteLatitude>
                  </xsl:if>
                  <xsl:if test=""string($var:v187)='false'"">
                    <siteLatitude>
                      <xsl:value-of select=""ns8:Address/siteLatitude/text()"" />
                    </siteLatitude>
                  </xsl:if>
                </xsl:if>
                <xsl:if test=""../../../../../InputMessagePart_1/s0:QueryMXVISIONLOCQUERYResponse/s0:MXVISIONLOCQUERYSet/s0:LOCATIONS/s0:ORGID"">
                  <siteLongitude>
                    <xsl:value-of select=""../../../../../InputMessagePart_1/s0:QueryMXVISIONLOCQUERYResponse/s0:MXVISIONLOCQUERYSet/s0:LOCATIONS/s0:ORGID/text()"" />
                  </siteLongitude>
                </xsl:if>
                <xsl:value-of select=""ns8:Address/text()"" />
              </ns8:Address>
              <xsl:value-of select=""./text()"" />
            </ns5:Location>
          </xsl:for-each>
          <xsl:for-each select=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns12:MService"">
            <ns12:MService>
              <xsl:if test=""CategoryName_1"">
                <CategoryName_1>
                  <xsl:value-of select=""CategoryName_1/text()"" />
                </CategoryName_1>
              </xsl:if>
              <xsl:if test=""CategoryName_2"">
                <CategoryName_2>
                  <xsl:value-of select=""CategoryName_2/text()"" />
                </CategoryName_2>
              </xsl:if>
              <xsl:if test=""CatgeoryName_3"">
                <CatgeoryName_3>
                  <xsl:value-of select=""CatgeoryName_3/text()"" />
                </CatgeoryName_3>
              </xsl:if>
              <xsl:if test=""CategoryFrequency_3"">
                <CategoryFrequency_3>
                  <xsl:value-of select=""CategoryFrequency_3/text()"" />
                </CategoryFrequency_3>
              </xsl:if>
              <xsl:if test=""CategoryId_1"">
                <CategoryId_1>
                  <xsl:value-of select=""CategoryId_1/text()"" />
                </CategoryId_1>
              </xsl:if>
              <xsl:if test=""CategoryId_2"">
                <CategoryId_2>
                  <xsl:value-of select=""CategoryId_2/text()"" />
                </CategoryId_2>
              </xsl:if>
              <xsl:if test=""CategoryId_3"">
                <CategoryId_3>
                  <xsl:value-of select=""CategoryId_3/text()"" />
                </CategoryId_3>
              </xsl:if>
              <xsl:if test=""CategoryType_3"">
                <CategoryType_3>
                  <xsl:value-of select=""CategoryType_3/text()"" />
                </CategoryType_3>
              </xsl:if>
              <xsl:if test=""VendorCode"">
                <VendorCode>
                  <xsl:value-of select=""VendorCode/text()"" />
                </VendorCode>
              </xsl:if>
              <xsl:if test=""VendorServiceLine"">
                <VendorServiceLine>
                  <xsl:value-of select=""VendorServiceLine/text()"" />
                </VendorServiceLine>
              </xsl:if>
            </ns12:MService>
          </xsl:for-each>
          <xsl:for-each select=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:Service"">
            <ns9:Service>
              <ns12:ServiceStream>
                <xsl:if test=""ns12:ServiceStream/@StreamId"">
                  <xsl:attribute name=""StreamId"">
                    <xsl:value-of select=""ns12:ServiceStream/@StreamId"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:if test=""ns12:ServiceStream/Streamname"">
                  <Streamname>
                    <xsl:value-of select=""ns12:ServiceStream/Streamname/text()"" />
                  </Streamname>
                </xsl:if>
                <xsl:if test=""ns12:ServiceStream/Streamprioritycategory"">
                  <xsl:variable name=""var:v188"" select=""string(ns12:ServiceStream/Streamprioritycategory/@xsi:nil) = 'true'"" />
                  <xsl:if test=""string($var:v188)='true'"">
                    <Streamprioritycategory>
                      <xsl:attribute name=""xsi:nil"">
                        <xsl:value-of select=""'true'"" />
                      </xsl:attribute>
                    </Streamprioritycategory>
                  </xsl:if>
                  <xsl:if test=""string($var:v188)='false'"">
                    <Streamprioritycategory>
                      <xsl:value-of select=""ns12:ServiceStream/Streamprioritycategory/text()"" />
                    </Streamprioritycategory>
                  </xsl:if>
                </xsl:if>
                <xsl:value-of select=""ns12:ServiceStream/text()"" />
              </ns12:ServiceStream>
              <ns12:ServiceType>
                <xsl:if test=""ns12:ServiceType/@TypeId"">
                  <xsl:attribute name=""TypeId"">
                    <xsl:value-of select=""ns12:ServiceType/@TypeId"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:if test=""ns12:ServiceType/Typename"">
                  <Typename>
                    <xsl:value-of select=""ns12:ServiceType/Typename/text()"" />
                  </Typename>
                </xsl:if>
                <xsl:if test=""ns12:ServiceType/servicestreamid"">
                  <servicestreamid>
                    <xsl:value-of select=""ns12:ServiceType/servicestreamid/text()"" />
                  </servicestreamid>
                </xsl:if>
                <xsl:if test=""ns12:ServiceType/Typeprioritycategory"">
                  <xsl:variable name=""var:v189"" select=""string(ns12:ServiceType/Typeprioritycategory/@xsi:nil) = 'true'"" />
                  <xsl:if test=""string($var:v189)='true'"">
                    <Typeprioritycategory>
                      <xsl:attribute name=""xsi:nil"">
                        <xsl:value-of select=""'true'"" />
                      </xsl:attribute>
                    </Typeprioritycategory>
                  </xsl:if>
                  <xsl:if test=""string($var:v189)='false'"">
                    <Typeprioritycategory>
                      <xsl:value-of select=""ns12:ServiceType/Typeprioritycategory/text()"" />
                    </Typeprioritycategory>
                  </xsl:if>
                </xsl:if>
                <xsl:value-of select=""ns12:ServiceType/text()"" />
              </ns12:ServiceType>
              <ns12:ServiceDetail>
                <xsl:if test=""ns12:ServiceDetail/@DetailId"">
                  <xsl:attribute name=""DetailId"">
                    <xsl:value-of select=""ns12:ServiceDetail/@DetailId"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:if test=""ns12:ServiceDetail/Detailname"">
                  <Detailname>
                    <xsl:value-of select=""ns12:ServiceDetail/Detailname/text()"" />
                  </Detailname>
                </xsl:if>
                <xsl:if test=""ns12:ServiceDetail/servicetypeid"">
                  <servicetypeid>
                    <xsl:value-of select=""ns12:ServiceDetail/servicetypeid/text()"" />
                  </servicetypeid>
                </xsl:if>
                <xsl:if test=""ns12:ServiceDetail/Detailprioritycategory"">
                  <xsl:variable name=""var:v190"" select=""string(ns12:ServiceDetail/Detailprioritycategory/@xsi:nil) = 'true'"" />
                  <xsl:if test=""string($var:v190)='true'"">
                    <Detailprioritycategory>
                      <xsl:attribute name=""xsi:nil"">
                        <xsl:value-of select=""'true'"" />
                      </xsl:attribute>
                    </Detailprioritycategory>
                  </xsl:if>
                  <xsl:if test=""string($var:v190)='false'"">
                    <Detailprioritycategory>
                      <xsl:value-of select=""ns12:ServiceDetail/Detailprioritycategory/text()"" />
                    </Detailprioritycategory>
                  </xsl:if>
                </xsl:if>
                <xsl:if test=""ns12:ServiceDetail/statutory"">
                  <xsl:variable name=""var:v191"" select=""string(ns12:ServiceDetail/statutory/@xsi:nil) = 'true'"" />
                  <xsl:if test=""string($var:v191)='true'"">
                    <statutory>
                      <xsl:attribute name=""xsi:nil"">
                        <xsl:value-of select=""'true'"" />
                      </xsl:attribute>
                    </statutory>
                  </xsl:if>
                  <xsl:if test=""string($var:v191)='false'"">
                    <statutory>
                      <xsl:value-of select=""ns12:ServiceDetail/statutory/text()"" />
                    </statutory>
                  </xsl:if>
                </xsl:if>
                <xsl:if test=""ns12:ServiceDetail/categoryid"">
                  <xsl:variable name=""var:v192"" select=""string(ns12:ServiceDetail/categoryid/@xsi:nil) = 'true'"" />
                  <xsl:if test=""string($var:v192)='true'"">
                    <categoryid>
                      <xsl:attribute name=""xsi:nil"">
                        <xsl:value-of select=""'true'"" />
                      </xsl:attribute>
                    </categoryid>
                  </xsl:if>
                  <xsl:if test=""string($var:v192)='false'"">
                    <categoryid>
                      <xsl:value-of select=""ns12:ServiceDetail/categoryid/text()"" />
                    </categoryid>
                  </xsl:if>
                </xsl:if>
                <xsl:if test=""ns12:ServiceDetail/description"">
                  <xsl:variable name=""var:v193"" select=""string(ns12:ServiceDetail/description/@xsi:nil) = 'true'"" />
                  <xsl:if test=""string($var:v193)='true'"">
                    <description>
                      <xsl:attribute name=""xsi:nil"">
                        <xsl:value-of select=""'true'"" />
                      </xsl:attribute>
                    </description>
                  </xsl:if>
                  <xsl:if test=""string($var:v193)='false'"">
                    <description>
                      <xsl:value-of select=""ns12:ServiceDetail/description/text()"" />
                    </description>
                  </xsl:if>
                </xsl:if>
                <xsl:value-of select=""ns12:ServiceDetail/text()"" />
              </ns12:ServiceDetail>
              <xsl:value-of select=""./text()"" />
            </ns9:Service>
          </xsl:for-each>
          <xsl:for-each select=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns9:Helpdesk"">
            <ns9:Helpdesk>
              <ns9:CreatedByUser>
                <ns4:User>
                  <xsl:if test=""ns9:CreatedByUser/ns4:User/@UserId"">
                    <xsl:attribute name=""UserId"">
                      <xsl:value-of select=""ns9:CreatedByUser/ns4:User/@UserId"" />
                    </xsl:attribute>
                  </xsl:if>
                  <xsl:if test=""ns9:CreatedByUser/ns4:User/LogonName"">
                    <LogonName>
                      <xsl:value-of select=""ns9:CreatedByUser/ns4:User/LogonName/text()"" />
                    </LogonName>
                  </xsl:if>
                  <xsl:if test=""ns9:CreatedByUser/ns4:User/Phone"">
                    <xsl:variable name=""var:v194"" select=""string(ns9:CreatedByUser/ns4:User/Phone/@xsi:nil) = 'true'"" />
                    <xsl:if test=""string($var:v194)='true'"">
                      <Phone>
                        <xsl:attribute name=""xsi:nil"">
                          <xsl:value-of select=""'true'"" />
                        </xsl:attribute>
                      </Phone>
                    </xsl:if>
                    <xsl:if test=""string($var:v194)='false'"">
                      <Phone>
                        <xsl:value-of select=""ns9:CreatedByUser/ns4:User/Phone/text()"" />
                      </Phone>
                    </xsl:if>
                  </xsl:if>
                  <xsl:if test=""ns9:CreatedByUser/ns4:User/EmailAddress"">
                    <xsl:variable name=""var:v195"" select=""string(ns9:CreatedByUser/ns4:User/EmailAddress/@xsi:nil) = 'true'"" />
                    <xsl:if test=""string($var:v195)='true'"">
                      <EmailAddress>
                        <xsl:attribute name=""xsi:nil"">
                          <xsl:value-of select=""'true'"" />
                        </xsl:attribute>
                      </EmailAddress>
                    </xsl:if>
                    <xsl:if test=""string($var:v195)='false'"">
                      <EmailAddress>
                        <xsl:value-of select=""ns9:CreatedByUser/ns4:User/EmailAddress/text()"" />
                      </EmailAddress>
                    </xsl:if>
                  </xsl:if>
                  <xsl:value-of select=""ns9:CreatedByUser/ns4:User/text()"" />
                </ns4:User>
                <xsl:value-of select=""ns9:CreatedByUser/text()"" />
              </ns9:CreatedByUser>
              <ns9:UpdatedByUser>
                <ns4:User>
                  <xsl:if test=""ns9:UpdatedByUser/ns4:User/@UserId"">
                    <xsl:attribute name=""UserId"">
                      <xsl:value-of select=""ns9:UpdatedByUser/ns4:User/@UserId"" />
                    </xsl:attribute>
                  </xsl:if>
                  <xsl:if test=""ns9:UpdatedByUser/ns4:User/LogonName"">
                    <LogonName>
                      <xsl:value-of select=""ns9:UpdatedByUser/ns4:User/LogonName/text()"" />
                    </LogonName>
                  </xsl:if>
                  <xsl:if test=""ns9:UpdatedByUser/ns4:User/Phone"">
                    <xsl:variable name=""var:v196"" select=""string(ns9:UpdatedByUser/ns4:User/Phone/@xsi:nil) = 'true'"" />
                    <xsl:if test=""string($var:v196)='true'"">
                      <Phone>
                        <xsl:attribute name=""xsi:nil"">
                          <xsl:value-of select=""'true'"" />
                        </xsl:attribute>
                      </Phone>
                    </xsl:if>
                    <xsl:if test=""string($var:v196)='false'"">
                      <Phone>
                        <xsl:value-of select=""ns9:UpdatedByUser/ns4:User/Phone/text()"" />
                      </Phone>
                    </xsl:if>
                  </xsl:if>
                  <xsl:if test=""ns9:UpdatedByUser/ns4:User/EmailAddress"">
                    <xsl:variable name=""var:v197"" select=""string(ns9:UpdatedByUser/ns4:User/EmailAddress/@xsi:nil) = 'true'"" />
                    <xsl:if test=""string($var:v197)='true'"">
                      <EmailAddress>
                        <xsl:attribute name=""xsi:nil"">
                          <xsl:value-of select=""'true'"" />
                        </xsl:attribute>
                      </EmailAddress>
                    </xsl:if>
                    <xsl:if test=""string($var:v197)='false'"">
                      <EmailAddress>
                        <xsl:value-of select=""ns9:UpdatedByUser/ns4:User/EmailAddress/text()"" />
                      </EmailAddress>
                    </xsl:if>
                  </xsl:if>
                  <xsl:value-of select=""ns9:UpdatedByUser/ns4:User/text()"" />
                </ns4:User>
                <xsl:value-of select=""ns9:UpdatedByUser/text()"" />
              </ns9:UpdatedByUser>
              <ns9:AuthorisedByPerson>
                <ns4:Person>
                  <xsl:if test=""ns9:AuthorisedByPerson/ns4:Person/@Id"">
                    <xsl:attribute name=""Id"">
                      <xsl:value-of select=""ns9:AuthorisedByPerson/ns4:Person/@Id"" />
                    </xsl:attribute>
                  </xsl:if>
                  <xsl:if test=""ns9:AuthorisedByPerson/ns4:Person/CompanyId"">
                    <CompanyId>
                      <xsl:value-of select=""ns9:AuthorisedByPerson/ns4:Person/CompanyId/text()"" />
                    </CompanyId>
                  </xsl:if>
                  <xsl:if test=""ns9:AuthorisedByPerson/ns4:Person/AddressId"">
                    <xsl:variable name=""var:v198"" select=""string(ns9:AuthorisedByPerson/ns4:Person/AddressId/@xsi:nil) = 'true'"" />
                    <xsl:if test=""string($var:v198)='true'"">
                      <AddressId>
                        <xsl:attribute name=""xsi:nil"">
                          <xsl:value-of select=""'true'"" />
                        </xsl:attribute>
                      </AddressId>
                    </xsl:if>
                    <xsl:if test=""string($var:v198)='false'"">
                      <AddressId>
                        <xsl:value-of select=""ns9:AuthorisedByPerson/ns4:Person/AddressId/text()"" />
                      </AddressId>
                    </xsl:if>
                  </xsl:if>
                  <xsl:if test=""ns9:AuthorisedByPerson/ns4:Person/UserId"">
                    <xsl:variable name=""var:v199"" select=""string(ns9:AuthorisedByPerson/ns4:Person/UserId/@xsi:nil) = 'true'"" />
                    <xsl:if test=""string($var:v199)='true'"">
                      <UserId>
                        <xsl:attribute name=""xsi:nil"">
                          <xsl:value-of select=""'true'"" />
                        </xsl:attribute>
                      </UserId>
                    </xsl:if>
                    <xsl:if test=""string($var:v199)='false'"">
                      <UserId>
                        <xsl:value-of select=""ns9:AuthorisedByPerson/ns4:Person/UserId/text()"" />
                      </UserId>
                    </xsl:if>
                  </xsl:if>
                  <xsl:if test=""ns9:AuthorisedByPerson/ns4:Person/Salutation"">
                    <xsl:variable name=""var:v200"" select=""string(ns9:AuthorisedByPerson/ns4:Person/Salutation/@xsi:nil) = 'true'"" />
                    <xsl:if test=""string($var:v200)='true'"">
                      <Salutation>
                        <xsl:attribute name=""xsi:nil"">
                          <xsl:value-of select=""'true'"" />
                        </xsl:attribute>
                      </Salutation>
                    </xsl:if>
                    <xsl:if test=""string($var:v200)='false'"">
                      <Salutation>
                        <xsl:value-of select=""ns9:AuthorisedByPerson/ns4:Person/Salutation/text()"" />
                      </Salutation>
                    </xsl:if>
                  </xsl:if>
                  <xsl:if test=""ns9:AuthorisedByPerson/ns4:Person/FirstName"">
                    <xsl:variable name=""var:v201"" select=""string(ns9:AuthorisedByPerson/ns4:Person/FirstName/@xsi:nil) = 'true'"" />
                    <xsl:if test=""string($var:v201)='true'"">
                      <FirstName>
                        <xsl:attribute name=""xsi:nil"">
                          <xsl:value-of select=""'true'"" />
                        </xsl:attribute>
                      </FirstName>
                    </xsl:if>
                    <xsl:if test=""string($var:v201)='false'"">
                      <FirstName>
                        <xsl:value-of select=""ns9:AuthorisedByPerson/ns4:Person/FirstName/text()"" />
                      </FirstName>
                    </xsl:if>
                  </xsl:if>
                  <xsl:if test=""ns9:AuthorisedByPerson/ns4:Person/LastName"">
                    <xsl:variable name=""var:v202"" select=""string(ns9:AuthorisedByPerson/ns4:Person/LastName/@xsi:nil) = 'true'"" />
                    <xsl:if test=""string($var:v202)='true'"">
                      <LastName>
                        <xsl:attribute name=""xsi:nil"">
                          <xsl:value-of select=""'true'"" />
                        </xsl:attribute>
                      </LastName>
                    </xsl:if>
                    <xsl:if test=""string($var:v202)='false'"">
                      <LastName>
                        <xsl:value-of select=""ns9:AuthorisedByPerson/ns4:Person/LastName/text()"" />
                      </LastName>
                    </xsl:if>
                  </xsl:if>
                  <xsl:if test=""ns9:AuthorisedByPerson/ns4:Person/MiddleName"">
                    <xsl:variable name=""var:v203"" select=""string(ns9:AuthorisedByPerson/ns4:Person/MiddleName/@xsi:nil) = 'true'"" />
                    <xsl:if test=""string($var:v203)='true'"">
                      <MiddleName>
                        <xsl:attribute name=""xsi:nil"">
                          <xsl:value-of select=""'true'"" />
                        </xsl:attribute>
                      </MiddleName>
                    </xsl:if>
                    <xsl:if test=""string($var:v203)='false'"">
                      <MiddleName>
                        <xsl:value-of select=""ns9:AuthorisedByPerson/ns4:Person/MiddleName/text()"" />
                      </MiddleName>
                    </xsl:if>
                  </xsl:if>
                  <xsl:if test=""ns9:AuthorisedByPerson/ns4:Person/suffix"">
                    <xsl:variable name=""var:v204"" select=""string(ns9:AuthorisedByPerson/ns4:Person/suffix/@xsi:nil) = 'true'"" />
                    <xsl:if test=""string($var:v204)='true'"">
                      <suffix>
                        <xsl:attribute name=""xsi:nil"">
                          <xsl:value-of select=""'true'"" />
                        </xsl:attribute>
                      </suffix>
                    </xsl:if>
                    <xsl:if test=""string($var:v204)='false'"">
                      <suffix>
                        <xsl:value-of select=""ns9:AuthorisedByPerson/ns4:Person/suffix/text()"" />
                      </suffix>
                    </xsl:if>
                  </xsl:if>
                  <xsl:if test=""ns9:AuthorisedByPerson/ns4:Person/gender"">
                    <xsl:variable name=""var:v205"" select=""string(ns9:AuthorisedByPerson/ns4:Person/gender/@xsi:nil) = 'true'"" />
                    <xsl:if test=""string($var:v205)='true'"">
                      <gender>
                        <xsl:attribute name=""xsi:nil"">
                          <xsl:value-of select=""'true'"" />
                        </xsl:attribute>
                      </gender>
                    </xsl:if>
                    <xsl:if test=""string($var:v205)='false'"">
                      <gender>
                        <xsl:value-of select=""ns9:AuthorisedByPerson/ns4:Person/gender/text()"" />
                      </gender>
                    </xsl:if>
                  </xsl:if>
                  <xsl:if test=""ns9:AuthorisedByPerson/ns4:Person/title"">
                    <xsl:variable name=""var:v206"" select=""string(ns9:AuthorisedByPerson/ns4:Person/title/@xsi:nil) = 'true'"" />
                    <xsl:if test=""string($var:v206)='true'"">
                      <title>
                        <xsl:attribute name=""xsi:nil"">
                          <xsl:value-of select=""'true'"" />
                        </xsl:attribute>
                      </title>
                    </xsl:if>
                    <xsl:if test=""string($var:v206)='false'"">
                      <title>
                        <xsl:value-of select=""ns9:AuthorisedByPerson/ns4:Person/title/text()"" />
                      </title>
                    </xsl:if>
                  </xsl:if>
                  <xsl:if test=""ns9:AuthorisedByPerson/ns4:Person/department"">
                    <xsl:variable name=""var:v207"" select=""string(ns9:AuthorisedByPerson/ns4:Person/department/@xsi:nil) = 'true'"" />
                    <xsl:if test=""string($var:v207)='true'"">
                      <department>
                        <xsl:attribute name=""xsi:nil"">
                          <xsl:value-of select=""'true'"" />
                        </xsl:attribute>
                      </department>
                    </xsl:if>
                    <xsl:if test=""string($var:v207)='false'"">
                      <department>
                        <xsl:value-of select=""ns9:AuthorisedByPerson/ns4:Person/department/text()"" />
                      </department>
                    </xsl:if>
                  </xsl:if>
                  <xsl:if test=""ns9:AuthorisedByPerson/ns4:Person/locationid"">
                    <xsl:variable name=""var:v208"" select=""string(ns9:AuthorisedByPerson/ns4:Person/locationid/@xsi:nil) = 'true'"" />
                    <xsl:if test=""string($var:v208)='true'"">
                      <locationid>
                        <xsl:attribute name=""xsi:nil"">
                          <xsl:value-of select=""'true'"" />
                        </xsl:attribute>
                      </locationid>
                    </xsl:if>
                    <xsl:if test=""string($var:v208)='false'"">
                      <locationid>
                        <xsl:value-of select=""ns9:AuthorisedByPerson/ns4:Person/locationid/text()"" />
                      </locationid>
                    </xsl:if>
                  </xsl:if>
                  <xsl:if test=""ns9:AuthorisedByPerson/ns4:Person/contactmethod"">
                    <xsl:variable name=""var:v209"" select=""string(ns9:AuthorisedByPerson/ns4:Person/contactmethod/@xsi:nil) = 'true'"" />
                    <xsl:if test=""string($var:v209)='true'"">
                      <contactmethod>
                        <xsl:attribute name=""xsi:nil"">
                          <xsl:value-of select=""'true'"" />
                        </xsl:attribute>
                      </contactmethod>
                    </xsl:if>
                    <xsl:if test=""string($var:v209)='false'"">
                      <contactmethod>
                        <xsl:value-of select=""ns9:AuthorisedByPerson/ns4:Person/contactmethod/text()"" />
                      </contactmethod>
                    </xsl:if>
                  </xsl:if>
                  <xsl:if test=""ns9:AuthorisedByPerson/ns4:Person/PhoneNumber"">
                    <xsl:variable name=""var:v210"" select=""string(ns9:AuthorisedByPerson/ns4:Person/PhoneNumber/@xsi:nil) = 'true'"" />
                    <xsl:if test=""string($var:v210)='true'"">
                      <PhoneNumber>
                        <xsl:attribute name=""xsi:nil"">
                          <xsl:value-of select=""'true'"" />
                        </xsl:attribute>
                      </PhoneNumber>
                    </xsl:if>
                    <xsl:if test=""string($var:v210)='false'"">
                      <PhoneNumber>
                        <xsl:value-of select=""ns9:AuthorisedByPerson/ns4:Person/PhoneNumber/text()"" />
                      </PhoneNumber>
                    </xsl:if>
                  </xsl:if>
                  <xsl:if test=""ns9:AuthorisedByPerson/ns4:Person/EmailAddress"">
                    <xsl:variable name=""var:v211"" select=""string(ns9:AuthorisedByPerson/ns4:Person/EmailAddress/@xsi:nil) = 'true'"" />
                    <xsl:if test=""string($var:v211)='true'"">
                      <EmailAddress>
                        <xsl:attribute name=""xsi:nil"">
                          <xsl:value-of select=""'true'"" />
                        </xsl:attribute>
                      </EmailAddress>
                    </xsl:if>
                    <xsl:if test=""string($var:v211)='false'"">
                      <EmailAddress>
                        <xsl:value-of select=""ns9:AuthorisedByPerson/ns4:Person/EmailAddress/text()"" />
                      </EmailAddress>
                    </xsl:if>
                  </xsl:if>
                  <xsl:if test=""ns9:AuthorisedByPerson/ns4:Person/FaxNumber"">
                    <xsl:variable name=""var:v212"" select=""string(ns9:AuthorisedByPerson/ns4:Person/FaxNumber/@xsi:nil) = 'true'"" />
                    <xsl:if test=""string($var:v212)='true'"">
                      <FaxNumber>
                        <xsl:attribute name=""xsi:nil"">
                          <xsl:value-of select=""'true'"" />
                        </xsl:attribute>
                      </FaxNumber>
                    </xsl:if>
                    <xsl:if test=""string($var:v212)='false'"">
                      <FaxNumber>
                        <xsl:value-of select=""ns9:AuthorisedByPerson/ns4:Person/FaxNumber/text()"" />
                      </FaxNumber>
                    </xsl:if>
                  </xsl:if>
                  <xsl:value-of select=""ns9:AuthorisedByPerson/ns4:Person/text()"" />
                </ns4:Person>
                <xsl:value-of select=""ns9:AuthorisedByPerson/text()"" />
              </ns9:AuthorisedByPerson>
              <ns9:PreAuthorisedByPerson>
                <ns4:Person>
                  <xsl:if test=""ns9:PreAuthorisedByPerson/ns4:Person/@Id"">
                    <xsl:attribute name=""Id"">
                      <xsl:value-of select=""ns9:PreAuthorisedByPerson/ns4:Person/@Id"" />
                    </xsl:attribute>
                  </xsl:if>
                  <xsl:if test=""ns9:PreAuthorisedByPerson/ns4:Person/CompanyId"">
                    <CompanyId>
                      <xsl:value-of select=""ns9:PreAuthorisedByPerson/ns4:Person/CompanyId/text()"" />
                    </CompanyId>
                  </xsl:if>
                  <xsl:if test=""ns9:PreAuthorisedByPerson/ns4:Person/AddressId"">
                    <xsl:variable name=""var:v213"" select=""string(ns9:PreAuthorisedByPerson/ns4:Person/AddressId/@xsi:nil) = 'true'"" />
                    <xsl:if test=""string($var:v213)='true'"">
                      <AddressId>
                        <xsl:attribute name=""xsi:nil"">
                          <xsl:value-of select=""'true'"" />
                        </xsl:attribute>
                      </AddressId>
                    </xsl:if>
                    <xsl:if test=""string($var:v213)='false'"">
                      <AddressId>
                        <xsl:value-of select=""ns9:PreAuthorisedByPerson/ns4:Person/AddressId/text()"" />
                      </AddressId>
                    </xsl:if>
                  </xsl:if>
                  <xsl:if test=""ns9:PreAuthorisedByPerson/ns4:Person/UserId"">
                    <xsl:variable name=""var:v214"" select=""string(ns9:PreAuthorisedByPerson/ns4:Person/UserId/@xsi:nil) = 'true'"" />
                    <xsl:if test=""string($var:v214)='true'"">
                      <UserId>
                        <xsl:attribute name=""xsi:nil"">
                          <xsl:value-of select=""'true'"" />
                        </xsl:attribute>
                      </UserId>
                    </xsl:if>
                    <xsl:if test=""string($var:v214)='false'"">
                      <UserId>
                        <xsl:value-of select=""ns9:PreAuthorisedByPerson/ns4:Person/UserId/text()"" />
                      </UserId>
                    </xsl:if>
                  </xsl:if>
                  <xsl:if test=""ns9:PreAuthorisedByPerson/ns4:Person/Salutation"">
                    <xsl:variable name=""var:v215"" select=""string(ns9:PreAuthorisedByPerson/ns4:Person/Salutation/@xsi:nil) = 'true'"" />
                    <xsl:if test=""string($var:v215)='true'"">
                      <Salutation>
                        <xsl:attribute name=""xsi:nil"">
                          <xsl:value-of select=""'true'"" />
                        </xsl:attribute>
                      </Salutation>
                    </xsl:if>
                    <xsl:if test=""string($var:v215)='false'"">
                      <Salutation>
                        <xsl:value-of select=""ns9:PreAuthorisedByPerson/ns4:Person/Salutation/text()"" />
                      </Salutation>
                    </xsl:if>
                  </xsl:if>
                  <xsl:if test=""ns9:PreAuthorisedByPerson/ns4:Person/FirstName"">
                    <xsl:variable name=""var:v216"" select=""string(ns9:PreAuthorisedByPerson/ns4:Person/FirstName/@xsi:nil) = 'true'"" />
                    <xsl:if test=""string($var:v216)='true'"">
                      <FirstName>
                        <xsl:attribute name=""xsi:nil"">
                          <xsl:value-of select=""'true'"" />
                        </xsl:attribute>
                      </FirstName>
                    </xsl:if>
                    <xsl:if test=""string($var:v216)='false'"">
                      <FirstName>
                        <xsl:value-of select=""ns9:PreAuthorisedByPerson/ns4:Person/FirstName/text()"" />
                      </FirstName>
                    </xsl:if>
                  </xsl:if>
                  <xsl:if test=""ns9:PreAuthorisedByPerson/ns4:Person/LastName"">
                    <xsl:variable name=""var:v217"" select=""string(ns9:PreAuthorisedByPerson/ns4:Person/LastName/@xsi:nil) = 'true'"" />
                    <xsl:if test=""string($var:v217)='true'"">
                      <LastName>
                        <xsl:attribute name=""xsi:nil"">
                          <xsl:value-of select=""'true'"" />
                        </xsl:attribute>
                      </LastName>
                    </xsl:if>
                    <xsl:if test=""string($var:v217)='false'"">
                      <LastName>
                        <xsl:value-of select=""ns9:PreAuthorisedByPerson/ns4:Person/LastName/text()"" />
                      </LastName>
                    </xsl:if>
                  </xsl:if>
                  <xsl:if test=""ns9:PreAuthorisedByPerson/ns4:Person/MiddleName"">
                    <xsl:variable name=""var:v218"" select=""string(ns9:PreAuthorisedByPerson/ns4:Person/MiddleName/@xsi:nil) = 'true'"" />
                    <xsl:if test=""string($var:v218)='true'"">
                      <MiddleName>
                        <xsl:attribute name=""xsi:nil"">
                          <xsl:value-of select=""'true'"" />
                        </xsl:attribute>
                      </MiddleName>
                    </xsl:if>
                    <xsl:if test=""string($var:v218)='false'"">
                      <MiddleName>
                        <xsl:value-of select=""ns9:PreAuthorisedByPerson/ns4:Person/MiddleName/text()"" />
                      </MiddleName>
                    </xsl:if>
                  </xsl:if>
                  <xsl:if test=""ns9:PreAuthorisedByPerson/ns4:Person/suffix"">
                    <xsl:variable name=""var:v219"" select=""string(ns9:PreAuthorisedByPerson/ns4:Person/suffix/@xsi:nil) = 'true'"" />
                    <xsl:if test=""string($var:v219)='true'"">
                      <suffix>
                        <xsl:attribute name=""xsi:nil"">
                          <xsl:value-of select=""'true'"" />
                        </xsl:attribute>
                      </suffix>
                    </xsl:if>
                    <xsl:if test=""string($var:v219)='false'"">
                      <suffix>
                        <xsl:value-of select=""ns9:PreAuthorisedByPerson/ns4:Person/suffix/text()"" />
                      </suffix>
                    </xsl:if>
                  </xsl:if>
                  <xsl:if test=""ns9:PreAuthorisedByPerson/ns4:Person/gender"">
                    <xsl:variable name=""var:v220"" select=""string(ns9:PreAuthorisedByPerson/ns4:Person/gender/@xsi:nil) = 'true'"" />
                    <xsl:if test=""string($var:v220)='true'"">
                      <gender>
                        <xsl:attribute name=""xsi:nil"">
                          <xsl:value-of select=""'true'"" />
                        </xsl:attribute>
                      </gender>
                    </xsl:if>
                    <xsl:if test=""string($var:v220)='false'"">
                      <gender>
                        <xsl:value-of select=""ns9:PreAuthorisedByPerson/ns4:Person/gender/text()"" />
                      </gender>
                    </xsl:if>
                  </xsl:if>
                  <xsl:if test=""ns9:PreAuthorisedByPerson/ns4:Person/title"">
                    <xsl:variable name=""var:v221"" select=""string(ns9:PreAuthorisedByPerson/ns4:Person/title/@xsi:nil) = 'true'"" />
                    <xsl:if test=""string($var:v221)='true'"">
                      <title>
                        <xsl:attribute name=""xsi:nil"">
                          <xsl:value-of select=""'true'"" />
                        </xsl:attribute>
                      </title>
                    </xsl:if>
                    <xsl:if test=""string($var:v221)='false'"">
                      <title>
                        <xsl:value-of select=""ns9:PreAuthorisedByPerson/ns4:Person/title/text()"" />
                      </title>
                    </xsl:if>
                  </xsl:if>
                  <xsl:if test=""ns9:PreAuthorisedByPerson/ns4:Person/department"">
                    <xsl:variable name=""var:v222"" select=""string(ns9:PreAuthorisedByPerson/ns4:Person/department/@xsi:nil) = 'true'"" />
                    <xsl:if test=""string($var:v222)='true'"">
                      <department>
                        <xsl:attribute name=""xsi:nil"">
                          <xsl:value-of select=""'true'"" />
                        </xsl:attribute>
                      </department>
                    </xsl:if>
                    <xsl:if test=""string($var:v222)='false'"">
                      <department>
                        <xsl:value-of select=""ns9:PreAuthorisedByPerson/ns4:Person/department/text()"" />
                      </department>
                    </xsl:if>
                  </xsl:if>
                  <xsl:if test=""ns9:PreAuthorisedByPerson/ns4:Person/locationid"">
                    <xsl:variable name=""var:v223"" select=""string(ns9:PreAuthorisedByPerson/ns4:Person/locationid/@xsi:nil) = 'true'"" />
                    <xsl:if test=""string($var:v223)='true'"">
                      <locationid>
                        <xsl:attribute name=""xsi:nil"">
                          <xsl:value-of select=""'true'"" />
                        </xsl:attribute>
                      </locationid>
                    </xsl:if>
                    <xsl:if test=""string($var:v223)='false'"">
                      <locationid>
                        <xsl:value-of select=""ns9:PreAuthorisedByPerson/ns4:Person/locationid/text()"" />
                      </locationid>
                    </xsl:if>
                  </xsl:if>
                  <xsl:if test=""ns9:PreAuthorisedByPerson/ns4:Person/contactmethod"">
                    <xsl:variable name=""var:v224"" select=""string(ns9:PreAuthorisedByPerson/ns4:Person/contactmethod/@xsi:nil) = 'true'"" />
                    <xsl:if test=""string($var:v224)='true'"">
                      <contactmethod>
                        <xsl:attribute name=""xsi:nil"">
                          <xsl:value-of select=""'true'"" />
                        </xsl:attribute>
                      </contactmethod>
                    </xsl:if>
                    <xsl:if test=""string($var:v224)='false'"">
                      <contactmethod>
                        <xsl:value-of select=""ns9:PreAuthorisedByPerson/ns4:Person/contactmethod/text()"" />
                      </contactmethod>
                    </xsl:if>
                  </xsl:if>
                  <xsl:if test=""ns9:PreAuthorisedByPerson/ns4:Person/PhoneNumber"">
                    <xsl:variable name=""var:v225"" select=""string(ns9:PreAuthorisedByPerson/ns4:Person/PhoneNumber/@xsi:nil) = 'true'"" />
                    <xsl:if test=""string($var:v225)='true'"">
                      <PhoneNumber>
                        <xsl:attribute name=""xsi:nil"">
                          <xsl:value-of select=""'true'"" />
                        </xsl:attribute>
                      </PhoneNumber>
                    </xsl:if>
                    <xsl:if test=""string($var:v225)='false'"">
                      <PhoneNumber>
                        <xsl:value-of select=""ns9:PreAuthorisedByPerson/ns4:Person/PhoneNumber/text()"" />
                      </PhoneNumber>
                    </xsl:if>
                  </xsl:if>
                  <xsl:if test=""ns9:PreAuthorisedByPerson/ns4:Person/EmailAddress"">
                    <xsl:variable name=""var:v226"" select=""string(ns9:PreAuthorisedByPerson/ns4:Person/EmailAddress/@xsi:nil) = 'true'"" />
                    <xsl:if test=""string($var:v226)='true'"">
                      <EmailAddress>
                        <xsl:attribute name=""xsi:nil"">
                          <xsl:value-of select=""'true'"" />
                        </xsl:attribute>
                      </EmailAddress>
                    </xsl:if>
                    <xsl:if test=""string($var:v226)='false'"">
                      <EmailAddress>
                        <xsl:value-of select=""ns9:PreAuthorisedByPerson/ns4:Person/EmailAddress/text()"" />
                      </EmailAddress>
                    </xsl:if>
                  </xsl:if>
                  <xsl:if test=""ns9:PreAuthorisedByPerson/ns4:Person/FaxNumber"">
                    <xsl:variable name=""var:v227"" select=""string(ns9:PreAuthorisedByPerson/ns4:Person/FaxNumber/@xsi:nil) = 'true'"" />
                    <xsl:if test=""string($var:v227)='true'"">
                      <FaxNumber>
                        <xsl:attribute name=""xsi:nil"">
                          <xsl:value-of select=""'true'"" />
                        </xsl:attribute>
                      </FaxNumber>
                    </xsl:if>
                    <xsl:if test=""string($var:v227)='false'"">
                      <FaxNumber>
                        <xsl:value-of select=""ns9:PreAuthorisedByPerson/ns4:Person/FaxNumber/text()"" />
                      </FaxNumber>
                    </xsl:if>
                  </xsl:if>
                  <xsl:value-of select=""ns9:PreAuthorisedByPerson/ns4:Person/text()"" />
                </ns4:Person>
                <xsl:value-of select=""ns9:PreAuthorisedByPerson/text()"" />
              </ns9:PreAuthorisedByPerson>
              <ns9:SecondaryAuthorisedByPerson>
                <ns4:Person>
                  <xsl:if test=""ns9:SecondaryAuthorisedByPerson/ns4:Person/@Id"">
                    <xsl:attribute name=""Id"">
                      <xsl:value-of select=""ns9:SecondaryAuthorisedByPerson/ns4:Person/@Id"" />
                    </xsl:attribute>
                  </xsl:if>
                  <xsl:if test=""ns9:SecondaryAuthorisedByPerson/ns4:Person/CompanyId"">
                    <CompanyId>
                      <xsl:value-of select=""ns9:SecondaryAuthorisedByPerson/ns4:Person/CompanyId/text()"" />
                    </CompanyId>
                  </xsl:if>
                  <xsl:if test=""ns9:SecondaryAuthorisedByPerson/ns4:Person/AddressId"">
                    <xsl:variable name=""var:v228"" select=""string(ns9:SecondaryAuthorisedByPerson/ns4:Person/AddressId/@xsi:nil) = 'true'"" />
                    <xsl:if test=""string($var:v228)='true'"">
                      <AddressId>
                        <xsl:attribute name=""xsi:nil"">
                          <xsl:value-of select=""'true'"" />
                        </xsl:attribute>
                      </AddressId>
                    </xsl:if>
                    <xsl:if test=""string($var:v228)='false'"">
                      <AddressId>
                        <xsl:value-of select=""ns9:SecondaryAuthorisedByPerson/ns4:Person/AddressId/text()"" />
                      </AddressId>
                    </xsl:if>
                  </xsl:if>
                  <xsl:if test=""ns9:SecondaryAuthorisedByPerson/ns4:Person/UserId"">
                    <xsl:variable name=""var:v229"" select=""string(ns9:SecondaryAuthorisedByPerson/ns4:Person/UserId/@xsi:nil) = 'true'"" />
                    <xsl:if test=""string($var:v229)='true'"">
                      <UserId>
                        <xsl:attribute name=""xsi:nil"">
                          <xsl:value-of select=""'true'"" />
                        </xsl:attribute>
                      </UserId>
                    </xsl:if>
                    <xsl:if test=""string($var:v229)='false'"">
                      <UserId>
                        <xsl:value-of select=""ns9:SecondaryAuthorisedByPerson/ns4:Person/UserId/text()"" />
                      </UserId>
                    </xsl:if>
                  </xsl:if>
                  <xsl:if test=""ns9:SecondaryAuthorisedByPerson/ns4:Person/Salutation"">
                    <xsl:variable name=""var:v230"" select=""string(ns9:SecondaryAuthorisedByPerson/ns4:Person/Salutation/@xsi:nil) = 'true'"" />
                    <xsl:if test=""string($var:v230)='true'"">
                      <Salutation>
                        <xsl:attribute name=""xsi:nil"">
                          <xsl:value-of select=""'true'"" />
                        </xsl:attribute>
                      </Salutation>
                    </xsl:if>
                    <xsl:if test=""string($var:v230)='false'"">
                      <Salutation>
                        <xsl:value-of select=""ns9:SecondaryAuthorisedByPerson/ns4:Person/Salutation/text()"" />
                      </Salutation>
                    </xsl:if>
                  </xsl:if>
                  <xsl:if test=""ns9:SecondaryAuthorisedByPerson/ns4:Person/FirstName"">
                    <xsl:variable name=""var:v231"" select=""string(ns9:SecondaryAuthorisedByPerson/ns4:Person/FirstName/@xsi:nil) = 'true'"" />
                    <xsl:if test=""string($var:v231)='true'"">
                      <FirstName>
                        <xsl:attribute name=""xsi:nil"">
                          <xsl:value-of select=""'true'"" />
                        </xsl:attribute>
                      </FirstName>
                    </xsl:if>
                    <xsl:if test=""string($var:v231)='false'"">
                      <FirstName>
                        <xsl:value-of select=""ns9:SecondaryAuthorisedByPerson/ns4:Person/FirstName/text()"" />
                      </FirstName>
                    </xsl:if>
                  </xsl:if>
                  <xsl:if test=""ns9:SecondaryAuthorisedByPerson/ns4:Person/LastName"">
                    <xsl:variable name=""var:v232"" select=""string(ns9:SecondaryAuthorisedByPerson/ns4:Person/LastName/@xsi:nil) = 'true'"" />
                    <xsl:if test=""string($var:v232)='true'"">
                      <LastName>
                        <xsl:attribute name=""xsi:nil"">
                          <xsl:value-of select=""'true'"" />
                        </xsl:attribute>
                      </LastName>
                    </xsl:if>
                    <xsl:if test=""string($var:v232)='false'"">
                      <LastName>
                        <xsl:value-of select=""ns9:SecondaryAuthorisedByPerson/ns4:Person/LastName/text()"" />
                      </LastName>
                    </xsl:if>
                  </xsl:if>
                  <xsl:if test=""ns9:SecondaryAuthorisedByPerson/ns4:Person/MiddleName"">
                    <xsl:variable name=""var:v233"" select=""string(ns9:SecondaryAuthorisedByPerson/ns4:Person/MiddleName/@xsi:nil) = 'true'"" />
                    <xsl:if test=""string($var:v233)='true'"">
                      <MiddleName>
                        <xsl:attribute name=""xsi:nil"">
                          <xsl:value-of select=""'true'"" />
                        </xsl:attribute>
                      </MiddleName>
                    </xsl:if>
                    <xsl:if test=""string($var:v233)='false'"">
                      <MiddleName>
                        <xsl:value-of select=""ns9:SecondaryAuthorisedByPerson/ns4:Person/MiddleName/text()"" />
                      </MiddleName>
                    </xsl:if>
                  </xsl:if>
                  <xsl:if test=""ns9:SecondaryAuthorisedByPerson/ns4:Person/suffix"">
                    <xsl:variable name=""var:v234"" select=""string(ns9:SecondaryAuthorisedByPerson/ns4:Person/suffix/@xsi:nil) = 'true'"" />
                    <xsl:if test=""string($var:v234)='true'"">
                      <suffix>
                        <xsl:attribute name=""xsi:nil"">
                          <xsl:value-of select=""'true'"" />
                        </xsl:attribute>
                      </suffix>
                    </xsl:if>
                    <xsl:if test=""string($var:v234)='false'"">
                      <suffix>
                        <xsl:value-of select=""ns9:SecondaryAuthorisedByPerson/ns4:Person/suffix/text()"" />
                      </suffix>
                    </xsl:if>
                  </xsl:if>
                  <xsl:if test=""ns9:SecondaryAuthorisedByPerson/ns4:Person/gender"">
                    <xsl:variable name=""var:v235"" select=""string(ns9:SecondaryAuthorisedByPerson/ns4:Person/gender/@xsi:nil) = 'true'"" />
                    <xsl:if test=""string($var:v235)='true'"">
                      <gender>
                        <xsl:attribute name=""xsi:nil"">
                          <xsl:value-of select=""'true'"" />
                        </xsl:attribute>
                      </gender>
                    </xsl:if>
                    <xsl:if test=""string($var:v235)='false'"">
                      <gender>
                        <xsl:value-of select=""ns9:SecondaryAuthorisedByPerson/ns4:Person/gender/text()"" />
                      </gender>
                    </xsl:if>
                  </xsl:if>
                  <xsl:if test=""ns9:SecondaryAuthorisedByPerson/ns4:Person/title"">
                    <xsl:variable name=""var:v236"" select=""string(ns9:SecondaryAuthorisedByPerson/ns4:Person/title/@xsi:nil) = 'true'"" />
                    <xsl:if test=""string($var:v236)='true'"">
                      <title>
                        <xsl:attribute name=""xsi:nil"">
                          <xsl:value-of select=""'true'"" />
                        </xsl:attribute>
                      </title>
                    </xsl:if>
                    <xsl:if test=""string($var:v236)='false'"">
                      <title>
                        <xsl:value-of select=""ns9:SecondaryAuthorisedByPerson/ns4:Person/title/text()"" />
                      </title>
                    </xsl:if>
                  </xsl:if>
                  <xsl:if test=""ns9:SecondaryAuthorisedByPerson/ns4:Person/department"">
                    <xsl:variable name=""var:v237"" select=""string(ns9:SecondaryAuthorisedByPerson/ns4:Person/department/@xsi:nil) = 'true'"" />
                    <xsl:if test=""string($var:v237)='true'"">
                      <department>
                        <xsl:attribute name=""xsi:nil"">
                          <xsl:value-of select=""'true'"" />
                        </xsl:attribute>
                      </department>
                    </xsl:if>
                    <xsl:if test=""string($var:v237)='false'"">
                      <department>
                        <xsl:value-of select=""ns9:SecondaryAuthorisedByPerson/ns4:Person/department/text()"" />
                      </department>
                    </xsl:if>
                  </xsl:if>
                  <xsl:if test=""ns9:SecondaryAuthorisedByPerson/ns4:Person/locationid"">
                    <xsl:variable name=""var:v238"" select=""string(ns9:SecondaryAuthorisedByPerson/ns4:Person/locationid/@xsi:nil) = 'true'"" />
                    <xsl:if test=""string($var:v238)='true'"">
                      <locationid>
                        <xsl:attribute name=""xsi:nil"">
                          <xsl:value-of select=""'true'"" />
                        </xsl:attribute>
                      </locationid>
                    </xsl:if>
                    <xsl:if test=""string($var:v238)='false'"">
                      <locationid>
                        <xsl:value-of select=""ns9:SecondaryAuthorisedByPerson/ns4:Person/locationid/text()"" />
                      </locationid>
                    </xsl:if>
                  </xsl:if>
                  <xsl:if test=""ns9:SecondaryAuthorisedByPerson/ns4:Person/contactmethod"">
                    <xsl:variable name=""var:v239"" select=""string(ns9:SecondaryAuthorisedByPerson/ns4:Person/contactmethod/@xsi:nil) = 'true'"" />
                    <xsl:if test=""string($var:v239)='true'"">
                      <contactmethod>
                        <xsl:attribute name=""xsi:nil"">
                          <xsl:value-of select=""'true'"" />
                        </xsl:attribute>
                      </contactmethod>
                    </xsl:if>
                    <xsl:if test=""string($var:v239)='false'"">
                      <contactmethod>
                        <xsl:value-of select=""ns9:SecondaryAuthorisedByPerson/ns4:Person/contactmethod/text()"" />
                      </contactmethod>
                    </xsl:if>
                  </xsl:if>
                  <xsl:if test=""ns9:SecondaryAuthorisedByPerson/ns4:Person/PhoneNumber"">
                    <xsl:variable name=""var:v240"" select=""string(ns9:SecondaryAuthorisedByPerson/ns4:Person/PhoneNumber/@xsi:nil) = 'true'"" />
                    <xsl:if test=""string($var:v240)='true'"">
                      <PhoneNumber>
                        <xsl:attribute name=""xsi:nil"">
                          <xsl:value-of select=""'true'"" />
                        </xsl:attribute>
                      </PhoneNumber>
                    </xsl:if>
                    <xsl:if test=""string($var:v240)='false'"">
                      <PhoneNumber>
                        <xsl:value-of select=""ns9:SecondaryAuthorisedByPerson/ns4:Person/PhoneNumber/text()"" />
                      </PhoneNumber>
                    </xsl:if>
                  </xsl:if>
                  <xsl:if test=""ns9:SecondaryAuthorisedByPerson/ns4:Person/EmailAddress"">
                    <xsl:variable name=""var:v241"" select=""string(ns9:SecondaryAuthorisedByPerson/ns4:Person/EmailAddress/@xsi:nil) = 'true'"" />
                    <xsl:if test=""string($var:v241)='true'"">
                      <EmailAddress>
                        <xsl:attribute name=""xsi:nil"">
                          <xsl:value-of select=""'true'"" />
                        </xsl:attribute>
                      </EmailAddress>
                    </xsl:if>
                    <xsl:if test=""string($var:v241)='false'"">
                      <EmailAddress>
                        <xsl:value-of select=""ns9:SecondaryAuthorisedByPerson/ns4:Person/EmailAddress/text()"" />
                      </EmailAddress>
                    </xsl:if>
                  </xsl:if>
                  <xsl:if test=""ns9:SecondaryAuthorisedByPerson/ns4:Person/FaxNumber"">
                    <xsl:variable name=""var:v242"" select=""string(ns9:SecondaryAuthorisedByPerson/ns4:Person/FaxNumber/@xsi:nil) = 'true'"" />
                    <xsl:if test=""string($var:v242)='true'"">
                      <FaxNumber>
                        <xsl:attribute name=""xsi:nil"">
                          <xsl:value-of select=""'true'"" />
                        </xsl:attribute>
                      </FaxNumber>
                    </xsl:if>
                    <xsl:if test=""string($var:v242)='false'"">
                      <FaxNumber>
                        <xsl:value-of select=""ns9:SecondaryAuthorisedByPerson/ns4:Person/FaxNumber/text()"" />
                      </FaxNumber>
                    </xsl:if>
                  </xsl:if>
                  <xsl:value-of select=""ns9:SecondaryAuthorisedByPerson/ns4:Person/text()"" />
                </ns4:Person>
                <xsl:value-of select=""ns9:SecondaryAuthorisedByPerson/text()"" />
              </ns9:SecondaryAuthorisedByPerson>
              <ns9:NotAuthorisedByPerson>
                <ns4:Person>
                  <xsl:if test=""ns9:NotAuthorisedByPerson/ns4:Person/@Id"">
                    <xsl:attribute name=""Id"">
                      <xsl:value-of select=""ns9:NotAuthorisedByPerson/ns4:Person/@Id"" />
                    </xsl:attribute>
                  </xsl:if>
                  <xsl:if test=""ns9:NotAuthorisedByPerson/ns4:Person/CompanyId"">
                    <CompanyId>
                      <xsl:value-of select=""ns9:NotAuthorisedByPerson/ns4:Person/CompanyId/text()"" />
                    </CompanyId>
                  </xsl:if>
                  <xsl:if test=""ns9:NotAuthorisedByPerson/ns4:Person/AddressId"">
                    <xsl:variable name=""var:v243"" select=""string(ns9:NotAuthorisedByPerson/ns4:Person/AddressId/@xsi:nil) = 'true'"" />
                    <xsl:if test=""string($var:v243)='true'"">
                      <AddressId>
                        <xsl:attribute name=""xsi:nil"">
                          <xsl:value-of select=""'true'"" />
                        </xsl:attribute>
                      </AddressId>
                    </xsl:if>
                    <xsl:if test=""string($var:v243)='false'"">
                      <AddressId>
                        <xsl:value-of select=""ns9:NotAuthorisedByPerson/ns4:Person/AddressId/text()"" />
                      </AddressId>
                    </xsl:if>
                  </xsl:if>
                  <xsl:if test=""ns9:NotAuthorisedByPerson/ns4:Person/UserId"">
                    <xsl:variable name=""var:v244"" select=""string(ns9:NotAuthorisedByPerson/ns4:Person/UserId/@xsi:nil) = 'true'"" />
                    <xsl:if test=""string($var:v244)='true'"">
                      <UserId>
                        <xsl:attribute name=""xsi:nil"">
                          <xsl:value-of select=""'true'"" />
                        </xsl:attribute>
                      </UserId>
                    </xsl:if>
                    <xsl:if test=""string($var:v244)='false'"">
                      <UserId>
                        <xsl:value-of select=""ns9:NotAuthorisedByPerson/ns4:Person/UserId/text()"" />
                      </UserId>
                    </xsl:if>
                  </xsl:if>
                  <xsl:if test=""ns9:NotAuthorisedByPerson/ns4:Person/Salutation"">
                    <xsl:variable name=""var:v245"" select=""string(ns9:NotAuthorisedByPerson/ns4:Person/Salutation/@xsi:nil) = 'true'"" />
                    <xsl:if test=""string($var:v245)='true'"">
                      <Salutation>
                        <xsl:attribute name=""xsi:nil"">
                          <xsl:value-of select=""'true'"" />
                        </xsl:attribute>
                      </Salutation>
                    </xsl:if>
                    <xsl:if test=""string($var:v245)='false'"">
                      <Salutation>
                        <xsl:value-of select=""ns9:NotAuthorisedByPerson/ns4:Person/Salutation/text()"" />
                      </Salutation>
                    </xsl:if>
                  </xsl:if>
                  <xsl:if test=""ns9:NotAuthorisedByPerson/ns4:Person/FirstName"">
                    <xsl:variable name=""var:v246"" select=""string(ns9:NotAuthorisedByPerson/ns4:Person/FirstName/@xsi:nil) = 'true'"" />
                    <xsl:if test=""string($var:v246)='true'"">
                      <FirstName>
                        <xsl:attribute name=""xsi:nil"">
                          <xsl:value-of select=""'true'"" />
                        </xsl:attribute>
                      </FirstName>
                    </xsl:if>
                    <xsl:if test=""string($var:v246)='false'"">
                      <FirstName>
                        <xsl:value-of select=""ns9:NotAuthorisedByPerson/ns4:Person/FirstName/text()"" />
                      </FirstName>
                    </xsl:if>
                  </xsl:if>
                  <xsl:if test=""ns9:NotAuthorisedByPerson/ns4:Person/LastName"">
                    <xsl:variable name=""var:v247"" select=""string(ns9:NotAuthorisedByPerson/ns4:Person/LastName/@xsi:nil) = 'true'"" />
                    <xsl:if test=""string($var:v247)='true'"">
                      <LastName>
                        <xsl:attribute name=""xsi:nil"">
                          <xsl:value-of select=""'true'"" />
                        </xsl:attribute>
                      </LastName>
                    </xsl:if>
                    <xsl:if test=""string($var:v247)='false'"">
                      <LastName>
                        <xsl:value-of select=""ns9:NotAuthorisedByPerson/ns4:Person/LastName/text()"" />
                      </LastName>
                    </xsl:if>
                  </xsl:if>
                  <xsl:if test=""ns9:NotAuthorisedByPerson/ns4:Person/MiddleName"">
                    <xsl:variable name=""var:v248"" select=""string(ns9:NotAuthorisedByPerson/ns4:Person/MiddleName/@xsi:nil) = 'true'"" />
                    <xsl:if test=""string($var:v248)='true'"">
                      <MiddleName>
                        <xsl:attribute name=""xsi:nil"">
                          <xsl:value-of select=""'true'"" />
                        </xsl:attribute>
                      </MiddleName>
                    </xsl:if>
                    <xsl:if test=""string($var:v248)='false'"">
                      <MiddleName>
                        <xsl:value-of select=""ns9:NotAuthorisedByPerson/ns4:Person/MiddleName/text()"" />
                      </MiddleName>
                    </xsl:if>
                  </xsl:if>
                  <xsl:if test=""ns9:NotAuthorisedByPerson/ns4:Person/suffix"">
                    <xsl:variable name=""var:v249"" select=""string(ns9:NotAuthorisedByPerson/ns4:Person/suffix/@xsi:nil) = 'true'"" />
                    <xsl:if test=""string($var:v249)='true'"">
                      <suffix>
                        <xsl:attribute name=""xsi:nil"">
                          <xsl:value-of select=""'true'"" />
                        </xsl:attribute>
                      </suffix>
                    </xsl:if>
                    <xsl:if test=""string($var:v249)='false'"">
                      <suffix>
                        <xsl:value-of select=""ns9:NotAuthorisedByPerson/ns4:Person/suffix/text()"" />
                      </suffix>
                    </xsl:if>
                  </xsl:if>
                  <xsl:if test=""ns9:NotAuthorisedByPerson/ns4:Person/gender"">
                    <xsl:variable name=""var:v250"" select=""string(ns9:NotAuthorisedByPerson/ns4:Person/gender/@xsi:nil) = 'true'"" />
                    <xsl:if test=""string($var:v250)='true'"">
                      <gender>
                        <xsl:attribute name=""xsi:nil"">
                          <xsl:value-of select=""'true'"" />
                        </xsl:attribute>
                      </gender>
                    </xsl:if>
                    <xsl:if test=""string($var:v250)='false'"">
                      <gender>
                        <xsl:value-of select=""ns9:NotAuthorisedByPerson/ns4:Person/gender/text()"" />
                      </gender>
                    </xsl:if>
                  </xsl:if>
                  <xsl:if test=""ns9:NotAuthorisedByPerson/ns4:Person/title"">
                    <xsl:variable name=""var:v251"" select=""string(ns9:NotAuthorisedByPerson/ns4:Person/title/@xsi:nil) = 'true'"" />
                    <xsl:if test=""string($var:v251)='true'"">
                      <title>
                        <xsl:attribute name=""xsi:nil"">
                          <xsl:value-of select=""'true'"" />
                        </xsl:attribute>
                      </title>
                    </xsl:if>
                    <xsl:if test=""string($var:v251)='false'"">
                      <title>
                        <xsl:value-of select=""ns9:NotAuthorisedByPerson/ns4:Person/title/text()"" />
                      </title>
                    </xsl:if>
                  </xsl:if>
                  <xsl:if test=""ns9:NotAuthorisedByPerson/ns4:Person/department"">
                    <xsl:variable name=""var:v252"" select=""string(ns9:NotAuthorisedByPerson/ns4:Person/department/@xsi:nil) = 'true'"" />
                    <xsl:if test=""string($var:v252)='true'"">
                      <department>
                        <xsl:attribute name=""xsi:nil"">
                          <xsl:value-of select=""'true'"" />
                        </xsl:attribute>
                      </department>
                    </xsl:if>
                    <xsl:if test=""string($var:v252)='false'"">
                      <department>
                        <xsl:value-of select=""ns9:NotAuthorisedByPerson/ns4:Person/department/text()"" />
                      </department>
                    </xsl:if>
                  </xsl:if>
                  <xsl:if test=""ns9:NotAuthorisedByPerson/ns4:Person/locationid"">
                    <xsl:variable name=""var:v253"" select=""string(ns9:NotAuthorisedByPerson/ns4:Person/locationid/@xsi:nil) = 'true'"" />
                    <xsl:if test=""string($var:v253)='true'"">
                      <locationid>
                        <xsl:attribute name=""xsi:nil"">
                          <xsl:value-of select=""'true'"" />
                        </xsl:attribute>
                      </locationid>
                    </xsl:if>
                    <xsl:if test=""string($var:v253)='false'"">
                      <locationid>
                        <xsl:value-of select=""ns9:NotAuthorisedByPerson/ns4:Person/locationid/text()"" />
                      </locationid>
                    </xsl:if>
                  </xsl:if>
                  <xsl:if test=""ns9:NotAuthorisedByPerson/ns4:Person/contactmethod"">
                    <xsl:variable name=""var:v254"" select=""string(ns9:NotAuthorisedByPerson/ns4:Person/contactmethod/@xsi:nil) = 'true'"" />
                    <xsl:if test=""string($var:v254)='true'"">
                      <contactmethod>
                        <xsl:attribute name=""xsi:nil"">
                          <xsl:value-of select=""'true'"" />
                        </xsl:attribute>
                      </contactmethod>
                    </xsl:if>
                    <xsl:if test=""string($var:v254)='false'"">
                      <contactmethod>
                        <xsl:value-of select=""ns9:NotAuthorisedByPerson/ns4:Person/contactmethod/text()"" />
                      </contactmethod>
                    </xsl:if>
                  </xsl:if>
                  <xsl:if test=""ns9:NotAuthorisedByPerson/ns4:Person/PhoneNumber"">
                    <xsl:variable name=""var:v255"" select=""string(ns9:NotAuthorisedByPerson/ns4:Person/PhoneNumber/@xsi:nil) = 'true'"" />
                    <xsl:if test=""string($var:v255)='true'"">
                      <PhoneNumber>
                        <xsl:attribute name=""xsi:nil"">
                          <xsl:value-of select=""'true'"" />
                        </xsl:attribute>
                      </PhoneNumber>
                    </xsl:if>
                    <xsl:if test=""string($var:v255)='false'"">
                      <PhoneNumber>
                        <xsl:value-of select=""ns9:NotAuthorisedByPerson/ns4:Person/PhoneNumber/text()"" />
                      </PhoneNumber>
                    </xsl:if>
                  </xsl:if>
                  <xsl:if test=""ns9:NotAuthorisedByPerson/ns4:Person/EmailAddress"">
                    <xsl:variable name=""var:v256"" select=""string(ns9:NotAuthorisedByPerson/ns4:Person/EmailAddress/@xsi:nil) = 'true'"" />
                    <xsl:if test=""string($var:v256)='true'"">
                      <EmailAddress>
                        <xsl:attribute name=""xsi:nil"">
                          <xsl:value-of select=""'true'"" />
                        </xsl:attribute>
                      </EmailAddress>
                    </xsl:if>
                    <xsl:if test=""string($var:v256)='false'"">
                      <EmailAddress>
                        <xsl:value-of select=""ns9:NotAuthorisedByPerson/ns4:Person/EmailAddress/text()"" />
                      </EmailAddress>
                    </xsl:if>
                  </xsl:if>
                  <xsl:if test=""ns9:NotAuthorisedByPerson/ns4:Person/FaxNumber"">
                    <xsl:variable name=""var:v257"" select=""string(ns9:NotAuthorisedByPerson/ns4:Person/FaxNumber/@xsi:nil) = 'true'"" />
                    <xsl:if test=""string($var:v257)='true'"">
                      <FaxNumber>
                        <xsl:attribute name=""xsi:nil"">
                          <xsl:value-of select=""'true'"" />
                        </xsl:attribute>
                      </FaxNumber>
                    </xsl:if>
                    <xsl:if test=""string($var:v257)='false'"">
                      <FaxNumber>
                        <xsl:value-of select=""ns9:NotAuthorisedByPerson/ns4:Person/FaxNumber/text()"" />
                      </FaxNumber>
                    </xsl:if>
                  </xsl:if>
                  <xsl:value-of select=""ns9:NotAuthorisedByPerson/ns4:Person/text()"" />
                </ns4:Person>
                <xsl:value-of select=""ns9:NotAuthorisedByPerson/text()"" />
              </ns9:NotAuthorisedByPerson>
              <xsl:value-of select=""./text()"" />
            </ns9:Helpdesk>
          </xsl:for-each>
          <xsl:for-each select=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns12:WorkPackage"">
            <ns12:WorkPackage>
              <xsl:if test=""WorkPackageId"">
                <WorkPackageId>
                  <xsl:value-of select=""WorkPackageId/text()"" />
                </WorkPackageId>
              </xsl:if>
              <xsl:if test=""WorkPackageName"">
                <WorkPackageName>
                  <xsl:value-of select=""WorkPackageName/text()"" />
                </WorkPackageName>
              </xsl:if>
              <xsl:value-of select=""./text()"" />
            </ns12:WorkPackage>
          </xsl:for-each>
          <xsl:for-each select=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns12:WorkPackageBundle"">
            <ns12:WorkPackageBundle>
              <xsl:if test=""WorkPackageBundleId"">
                <WorkPackageBundleId>
                  <xsl:value-of select=""WorkPackageBundleId/text()"" />
                </WorkPackageBundleId>
              </xsl:if>
              <xsl:if test=""WorkPackageBundleName"">
                <WorkPackageBundleName>
                  <xsl:value-of select=""WorkPackageBundleName/text()"" />
                </WorkPackageBundleName>
              </xsl:if>
              <xsl:if test=""WorkPackageBundleType"">
                <WorkPackageBundleType>
                  <xsl:value-of select=""WorkPackageBundleType/text()"" />
                </WorkPackageBundleType>
              </xsl:if>
              <xsl:value-of select=""./text()"" />
            </ns12:WorkPackageBundle>
          </xsl:for-each>
          <xsl:for-each select=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns12:BundleItem"">
            <ns12:BundleItem>
              <xsl:if test=""BundleItemId"">
                <BundleItemId>
                  <xsl:value-of select=""BundleItemId/text()"" />
                </BundleItemId>
              </xsl:if>
              <xsl:if test=""BundleItemName"">
                <BundleItemName>
                  <xsl:value-of select=""BundleItemName/text()"" />
                </BundleItemName>
              </xsl:if>
              <xsl:if test=""BundleType"">
                <BundleType>
                  <xsl:value-of select=""BundleType/text()"" />
                </BundleType>
              </xsl:if>
              <xsl:if test=""BundleDescription"">
                <BundleDescription>
                  <xsl:value-of select=""BundleDescription/text()"" />
                </BundleDescription>
              </xsl:if>
              <xsl:if test=""BundleBudget"">
                <BundleBudget>
                  <xsl:value-of select=""BundleBudget/text()"" />
                </BundleBudget>
              </xsl:if>
              <xsl:if test=""BundlePreApprovedAmount"">
                <BundlePreApprovedAmount>
                  <xsl:value-of select=""BundlePreApprovedAmount/text()"" />
                </BundlePreApprovedAmount>
              </xsl:if>
              <xsl:value-of select=""./text()"" />
            </ns12:BundleItem>
          </xsl:for-each>
          <xsl:for-each select=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/ns11:Survey"">
            <ns11:Survey>
              <ParentId>
                <xsl:value-of select=""ParentId/text()"" />
              </ParentId>
              <xsl:for-each select=""ns6:SurveySet"">
                <ns6:SurveySet>
                  <SetName>
                    <xsl:value-of select=""SetName/text()"" />
                  </SetName>
                  <xsl:for-each select=""ns7:Question"">
                    <ns7:Question>
                      <Order>
                        <xsl:value-of select=""Order/text()"" />
                      </Order>
                      <QuestionAsked>
                        <xsl:value-of select=""QuestionAsked/text()"" />
                      </QuestionAsked>
                      <AnswerText>
                        <xsl:value-of select=""AnswerText/text()"" />
                      </AnswerText>
                      <AnswerValue>
                        <xsl:value-of select=""AnswerValue/text()"" />
                      </AnswerValue>
                      <AnswerComment>
                        <xsl:value-of select=""AnswerComment/text()"" />
                      </AnswerComment>
                      <xsl:if test=""AnswerCombo"">
                        <AnswerCombo>
                          <xsl:value-of select=""AnswerCombo/text()"" />
                        </AnswerCombo>
                      </xsl:if>
                      <xsl:value-of select=""./text()"" />
                    </ns7:Question>
                  </xsl:for-each>
                </ns6:SurveySet>
              </xsl:for-each>
            </ns11:Survey>
          </xsl:for-each>
          <xsl:value-of select=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/ns9:Workitem/text()"" />
        </ns9:Workitem>
        <xsl:value-of select=""InputMessagePart_0/ns0:DistributedWorkItems/ns1:IssuedWork/text()"" />
      </ns1:IssuedWork>
      <xsl:value-of select=""InputMessagePart_0/ns0:DistributedWorkItems/text()"" />
    </ns0:DistributedWorkItems>
  </xsl:template>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp""><![CDATA[
public bool LogicalGt(string val1, string val2)
{
	bool ret = false;
	double d1 = 0;
	double d2 = 0;
	if (IsNumeric(val1, ref d1) && IsNumeric(val2, ref d2))
	{
		ret = d1 > d2;
	}
	else
	{
		ret = String.Compare(val1, val2, StringComparison.Ordinal) > 0;
	}
	return ret;
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


]]></msxsl:script>
</xsl:stylesheet>";
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"MFM.Lbg.Schemas.DistibutedWorkItems";
        
        private const global::MFM.Lbg.Schemas.DistibutedWorkItems _srcSchemaTypeReference0 = null;
        
        private const string _strSrcSchemasList1 = @"MFM.Lbg.Orcs.GenItems.MTFMVISIONFM_MTFMVISIONLOCQUERY_www_ibm_com_maximo+QueryMXVISIONLOCQUERYResponse";
        
        private const global::MFM.Lbg.Orcs.GenItems.MTFMVISIONFM_MTFMVISIONLOCQUERY_www_ibm_com_maximo.QueryMXVISIONLOCQUERYResponse _srcSchemaTypeReference1 = null;
        
        private const string _strTrgSchemasList0 = @"MFM.Lbg.Schemas.DistibutedWorkItems";
        
        private const global::MFM.Lbg.Schemas.DistibutedWorkItems _trgSchemaTypeReference0 = null;
        
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
                _SrcSchemas[1] = @"MFM.Lbg.Orcs.GenItems.MTFMVISIONFM_MTFMVISIONLOCQUERY_www_ibm_com_maximo+QueryMXVISIONLOCQUERYResponse";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"MFM.Lbg.Schemas.DistibutedWorkItems";
                return _TrgSchemas;
            }
        }
    }
}
