namespace MFM.Lbg.Maps {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"MFM.Lbg.Schemas.VFM_Extract_TypedProcedure_dbo+biz_Global_Fetch_Case_DataSetResponse", typeof(global::MFM.Lbg.Schemas.VFM_Extract_TypedProcedure_dbo.biz_Global_Fetch_Case_DataSetResponse))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"MFM.Lbg.Schemas.DistibutedWorkItems", typeof(global::MFM.Lbg.Schemas.DistibutedWorkItems))]
    public sealed class WorkItemExtract_To_DistributedWorkItems : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s1 s0 s2 s3"" version=""1.0"" xmlns:ns6=""http://MFMSharedResources/Types/Helpdesk/v1/MSurveySet"" xmlns:s0=""http://schemas.microsoft.com/Sql/2008/05/ProceduresResultSets/dbo/biz_Global_Reset_Case_Extract"" xmlns:ns1=""http://MFMSharedResources/Types/Helpdesk/v1/IssuedWork"" xmlns:ns7=""http://MFMSharedResources/Types/Helpdesk/v1/MSurveyQuestion"" xmlns:ns10=""http://MFMSharedResources/Types/Helpdesk/v1/Customer"" xmlns:s3=""http://schemas.microsoft.com/Sql/2008/05/TypedProcedures/dbo"" xmlns:s2=""http://schemas.microsoft.com/Sql/2008/05/ProceduresResultSets/dbo/biz_Global_Remove_Case_From_Queue"" xmlns:ns2=""http://MFMSharedResources/Types/Helpdesk/v1/Vendor"" xmlns:ns0=""http://MFM.Lbg.Schemas.DistibutedWorkItems"" xmlns:ns4=""http://MFMSharedResources/Types/Helpdesk/v1/Person"" xmlns:ns11=""http://MFMSharedResources/Types/Helpdesk/v1/MSurvey"" xmlns:ns9=""http://MFMSharedResources/Types/Helpdesk/v1/Workitem"" xmlns:ns5=""http://MFMSharedResources/Types/Helpdesk/v1/Location"" xmlns:s1=""http://schemas.microsoft.com/Sql/2008/05/ProceduresResultSets/dbo/biz_Global_Fetch_Case_DataSet"" xmlns:ns12=""http://MFMSharedResources/Types/Helpdesk/v1/Service"" xmlns:ns3=""http://MFMSharedResources/Types/Helpdesk/v1/MRouting"" xmlns:ns8=""http://MFMSharedResources/Types/Helpdesk/v1/Address"" xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s3:biz_Global_Fetch_Case_DataSetResponse"" />
  </xsl:template>
  <xsl:template match=""/s3:biz_Global_Fetch_Case_DataSetResponse"">
    <ns0:DistributedWorkItems>
      <ns1:IssuedWork>
        <xsl:for-each select=""s3:StoredProcedureResultSet0"">
          <xsl:for-each select=""s1:StoredProcedureResultSet0"">
            <ns3:MRoute>
              <xsl:if test=""s1:Comp_Name"">
                <CustomerName>
                  <xsl:value-of select=""s1:Comp_Name/text()"" />
                </CustomerName>
              </xsl:if>
              <xsl:if test=""s1:Vendor_Comp_Name"">
                <VendorName>
                  <xsl:value-of select=""s1:Vendor_Comp_Name/text()"" />
                </VendorName>
              </xsl:if>
              <xsl:if test=""s1:Vendor_cldv_divisionname"">
                <VendorDivision>
                  <xsl:value-of select=""s1:Vendor_cldv_divisionname/text()"" />
                </VendorDivision>
              </xsl:if>
              <ContractName>
                <xsl:value-of select=""s1:mr_suppliercontractname/text()"" />
              </ContractName>
              <InterfaceIdentifier>
                <xsl:value-of select=""s1:mr_interface/text()"" />
              </InterfaceIdentifier>
              <ServiceLineType>
                <xsl:value-of select=""s1:mr_areaclass/text()"" />
              </ServiceLineType>
              <BizTalkCBR>
                <xsl:value-of select=""s1:mr_beaconcbr/text()"" />
              </BizTalkCBR>
              <xsl:variable name=""var:v1"" select=""string(s1:mr_enabled/@xsi:nil) = 'true'"" />
              <xsl:if test=""string($var:v1)='true'"">
                <InterfaceEnabled>
                  <xsl:attribute name=""xsi:nil"">
                    <xsl:value-of select=""'true'"" />
                  </xsl:attribute>
                </InterfaceEnabled>
              </xsl:if>
              <xsl:if test=""string($var:v1)='false'"">
                <InterfaceEnabled>
                  <xsl:value-of select=""s1:mr_enabled/text()"" />
                </InterfaceEnabled>
              </xsl:if>
              <xsl:variable name=""var:v2"" select=""string(s1:mr_sapenabled/@xsi:nil) = 'true'"" />
              <xsl:if test=""string($var:v2)='true'"">
                <SAPEnabled>
                  <xsl:attribute name=""xsi:nil"">
                    <xsl:value-of select=""'true'"" />
                  </xsl:attribute>
                </SAPEnabled>
              </xsl:if>
              <xsl:if test=""string($var:v2)='false'"">
                <SAPEnabled>
                  <xsl:value-of select=""s1:mr_sapenabled/text()"" />
                </SAPEnabled>
              </xsl:if>
            </ns3:MRoute>
          </xsl:for-each>
        </xsl:for-each>
        <xsl:for-each select=""s3:StoredProcedureResultSet0"">
          <xsl:for-each select=""s1:StoredProcedureResultSet0"">
            <ns2:Vendor>
              <xsl:if test=""s1:Vendor_cldv_clientdivisionid"">
                <xsl:attribute name=""vendorDivisionid"">
                  <xsl:value-of select=""s1:Vendor_cldv_clientdivisionid/text()"" />
                </xsl:attribute>
              </xsl:if>
              <xsl:if test=""s1:Vendor_cldv_companyid"">
                <vendorid>
                  <xsl:value-of select=""s1:Vendor_cldv_companyid/text()"" />
                </vendorid>
              </xsl:if>
              <xsl:if test=""s1:Vendor_cldv_divisionname"">
                <vendorDivisionname>
                  <xsl:value-of select=""s1:Vendor_cldv_divisionname/text()"" />
                </vendorDivisionname>
              </xsl:if>
              <xsl:if test=""s1:Vendor_Comp_Name"">
                <vendorName>
                  <xsl:value-of select=""s1:Vendor_Comp_Name/text()"" />
                </vendorName>
              </xsl:if>
              <ns5:Location>
                <xsl:if test=""s1:vendor_AdLi_AddressLinkId"">
                  <xsl:attribute name=""linkid"">
                    <xsl:value-of select=""s1:vendor_AdLi_AddressLinkId/text()"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:if test=""s1:vendor_AdLi_CompanyID"">
                  <linkcompany>
                    <xsl:value-of select=""s1:vendor_AdLi_CompanyID/text()"" />
                  </linkcompany>
                </xsl:if>
                <xsl:if test=""s1:vendor_AdLi_PersonID"">
                  <xsl:variable name=""var:v3"" select=""string(s1:vendor_AdLi_PersonID/@xsi:nil) = 'true'"" />
                  <xsl:if test=""string($var:v3)='true'"">
                    <linkperson>
                      <xsl:attribute name=""xsi:nil"">
                        <xsl:value-of select=""'true'"" />
                      </xsl:attribute>
                    </linkperson>
                  </xsl:if>
                  <xsl:if test=""string($var:v3)='false'"">
                    <linkperson>
                      <xsl:value-of select=""s1:vendor_AdLi_PersonID/text()"" />
                    </linkperson>
                  </xsl:if>
                </xsl:if>
                <xsl:if test=""s1:vendor_AdLi_Type"">
                  <xsl:variable name=""var:v4"" select=""string(s1:vendor_AdLi_Type/@xsi:nil) = 'true'"" />
                  <xsl:if test=""string($var:v4)='true'"">
                    <linktype>
                      <xsl:attribute name=""xsi:nil"">
                        <xsl:value-of select=""'true'"" />
                      </xsl:attribute>
                    </linktype>
                  </xsl:if>
                  <xsl:if test=""string($var:v4)='false'"">
                    <linktype>
                      <xsl:value-of select=""s1:vendor_AdLi_Type/text()"" />
                    </linktype>
                  </xsl:if>
                </xsl:if>
                <xsl:if test=""s1:vendor_adli_clientdivisionid"">
                  <xsl:variable name=""var:v5"" select=""string(s1:vendor_adli_clientdivisionid/@xsi:nil) = 'true'"" />
                  <xsl:if test=""string($var:v5)='true'"">
                    <linkdivisionid>
                      <xsl:attribute name=""xsi:nil"">
                        <xsl:value-of select=""'true'"" />
                      </xsl:attribute>
                    </linkdivisionid>
                  </xsl:if>
                  <xsl:if test=""string($var:v5)='false'"">
                    <linkdivisionid>
                      <xsl:value-of select=""s1:vendor_adli_clientdivisionid/text()"" />
                    </linkdivisionid>
                  </xsl:if>
                </xsl:if>
                <xsl:if test=""s1:vendor_adli_clientregionid_x0009_"">
                  <xsl:variable name=""var:v6"" select=""string(s1:vendor_adli_clientregionid_x0009_/@xsi:nil) = 'true'"" />
                  <xsl:if test=""string($var:v6)='true'"">
                    <linkregionid>
                      <xsl:attribute name=""xsi:nil"">
                        <xsl:value-of select=""'true'"" />
                      </xsl:attribute>
                    </linkregionid>
                  </xsl:if>
                  <xsl:if test=""string($var:v6)='false'"">
                    <linkregionid>
                      <xsl:value-of select=""s1:vendor_adli_clientregionid_x0009_/text()"" />
                    </linkregionid>
                  </xsl:if>
                </xsl:if>
                <xsl:if test=""s1:vendor_adli_ClientPropertyId"">
                  <xsl:variable name=""var:v7"" select=""string(s1:vendor_adli_ClientPropertyId/@xsi:nil) = 'true'"" />
                  <xsl:if test=""string($var:v7)='true'"">
                    <linkpropertyid>
                      <xsl:attribute name=""xsi:nil"">
                        <xsl:value-of select=""'true'"" />
                      </xsl:attribute>
                    </linkpropertyid>
                  </xsl:if>
                  <xsl:if test=""string($var:v7)='false'"">
                    <linkpropertyid>
                      <xsl:value-of select=""s1:vendor_adli_ClientPropertyId/text()"" />
                    </linkpropertyid>
                  </xsl:if>
                </xsl:if>
                <xsl:if test=""s1:vendor_regionname"">
                  <xsl:variable name=""var:v8"" select=""string(s1:vendor_regionname/@xsi:nil) = 'true'"" />
                  <xsl:if test=""string($var:v8)='true'"">
                    <linkRegionName>
                      <xsl:attribute name=""xsi:nil"">
                        <xsl:value-of select=""'true'"" />
                      </xsl:attribute>
                    </linkRegionName>
                  </xsl:if>
                  <xsl:if test=""string($var:v8)='false'"">
                    <linkRegionName>
                      <xsl:value-of select=""s1:vendor_regionname/text()"" />
                    </linkRegionName>
                  </xsl:if>
                </xsl:if>
                <ns8:Address>
                  <xsl:if test=""s1:vendor_Addr_AddressId"">
                    <xsl:attribute name=""siteid"">
                      <xsl:value-of select=""s1:vendor_Addr_AddressId/text()"" />
                    </xsl:attribute>
                  </xsl:if>
                  <xsl:if test=""s1:vendor_Addr_Address1"">
                    <siteAddress1>
                      <xsl:value-of select=""s1:vendor_Addr_Address1/text()"" />
                    </siteAddress1>
                  </xsl:if>
                  <xsl:if test=""s1:vendor_Addr_Address2"">
                    <xsl:variable name=""var:v9"" select=""string(s1:vendor_Addr_Address2/@xsi:nil) = 'true'"" />
                    <xsl:if test=""string($var:v9)='true'"">
                      <siteAddress2>
                        <xsl:attribute name=""xsi:nil"">
                          <xsl:value-of select=""'true'"" />
                        </xsl:attribute>
                      </siteAddress2>
                    </xsl:if>
                    <xsl:if test=""string($var:v9)='false'"">
                      <siteAddress2>
                        <xsl:value-of select=""s1:vendor_Addr_Address2/text()"" />
                      </siteAddress2>
                    </xsl:if>
                  </xsl:if>
                  <xsl:if test=""s1:vendor_Addr_Address3"">
                    <xsl:variable name=""var:v10"" select=""string(s1:vendor_Addr_Address3/@xsi:nil) = 'true'"" />
                    <xsl:if test=""string($var:v10)='true'"">
                      <siteAddress3>
                        <xsl:attribute name=""xsi:nil"">
                          <xsl:value-of select=""'true'"" />
                        </xsl:attribute>
                      </siteAddress3>
                    </xsl:if>
                    <xsl:if test=""string($var:v10)='false'"">
                      <siteAddress3>
                        <xsl:value-of select=""s1:vendor_Addr_Address3/text()"" />
                      </siteAddress3>
                    </xsl:if>
                  </xsl:if>
                  <xsl:if test=""s1:vendor_Addr_Address4"">
                    <xsl:variable name=""var:v11"" select=""string(s1:vendor_Addr_Address4/@xsi:nil) = 'true'"" />
                    <xsl:if test=""string($var:v11)='true'"">
                      <siteAddress4>
                        <xsl:attribute name=""xsi:nil"">
                          <xsl:value-of select=""'true'"" />
                        </xsl:attribute>
                      </siteAddress4>
                    </xsl:if>
                    <xsl:if test=""string($var:v11)='false'"">
                      <siteAddress4>
                        <xsl:value-of select=""s1:vendor_Addr_Address4/text()"" />
                      </siteAddress4>
                    </xsl:if>
                  </xsl:if>
                  <xsl:if test=""s1:vendor_Addr_Address5"">
                    <xsl:variable name=""var:v12"" select=""string(s1:vendor_Addr_Address5/@xsi:nil) = 'true'"" />
                    <xsl:if test=""string($var:v12)='true'"">
                      <siteAddress5>
                        <xsl:attribute name=""xsi:nil"">
                          <xsl:value-of select=""'true'"" />
                        </xsl:attribute>
                      </siteAddress5>
                    </xsl:if>
                    <xsl:if test=""string($var:v12)='false'"">
                      <siteAddress5>
                        <xsl:value-of select=""s1:vendor_Addr_Address5/text()"" />
                      </siteAddress5>
                    </xsl:if>
                  </xsl:if>
                  <xsl:if test=""s1:vendor_Addr_City"">
                    <xsl:variable name=""var:v13"" select=""string(s1:vendor_Addr_City/@xsi:nil) = 'true'"" />
                    <xsl:if test=""string($var:v13)='true'"">
                      <siteCity>
                        <xsl:attribute name=""xsi:nil"">
                          <xsl:value-of select=""'true'"" />
                        </xsl:attribute>
                      </siteCity>
                    </xsl:if>
                    <xsl:if test=""string($var:v13)='false'"">
                      <siteCity>
                        <xsl:value-of select=""s1:vendor_Addr_City/text()"" />
                      </siteCity>
                    </xsl:if>
                  </xsl:if>
                  <xsl:if test=""s1:vendor_Addr_PostCode"">
                    <xsl:variable name=""var:v14"" select=""string(s1:vendor_Addr_PostCode/@xsi:nil) = 'true'"" />
                    <xsl:if test=""string($var:v14)='true'"">
                      <sitePostCode>
                        <xsl:attribute name=""xsi:nil"">
                          <xsl:value-of select=""'true'"" />
                        </xsl:attribute>
                      </sitePostCode>
                    </xsl:if>
                    <xsl:if test=""string($var:v14)='false'"">
                      <sitePostCode>
                        <xsl:value-of select=""s1:vendor_Addr_PostCode/text()"" />
                      </sitePostCode>
                    </xsl:if>
                  </xsl:if>
                  <xsl:if test=""s1:vendor_addr_SiteName"">
                    <xsl:variable name=""var:v15"" select=""string(s1:vendor_addr_SiteName/@xsi:nil) = 'true'"" />
                    <xsl:if test=""string($var:v15)='true'"">
                      <siteSiteName>
                        <xsl:attribute name=""xsi:nil"">
                          <xsl:value-of select=""'true'"" />
                        </xsl:attribute>
                      </siteSiteName>
                    </xsl:if>
                    <xsl:if test=""string($var:v15)='false'"">
                      <siteSiteName>
                        <xsl:value-of select=""s1:vendor_addr_SiteName/text()"" />
                      </siteSiteName>
                    </xsl:if>
                  </xsl:if>
                  <xsl:if test=""s1:vendor_addr_SiteID"">
                    <xsl:variable name=""var:v16"" select=""string(s1:vendor_addr_SiteID/@xsi:nil) = 'true'"" />
                    <xsl:if test=""string($var:v16)='true'"">
                      <siteSiteID>
                        <xsl:attribute name=""xsi:nil"">
                          <xsl:value-of select=""'true'"" />
                        </xsl:attribute>
                      </siteSiteID>
                    </xsl:if>
                    <xsl:if test=""string($var:v16)='false'"">
                      <siteSiteID>
                        <xsl:value-of select=""s1:vendor_addr_SiteID/text()"" />
                      </siteSiteID>
                    </xsl:if>
                  </xsl:if>
                  <xsl:if test=""s1:vendor_addr_SecondaryClientSiteID"">
                    <xsl:variable name=""var:v17"" select=""string(s1:vendor_addr_SecondaryClientSiteID/@xsi:nil) = 'true'"" />
                    <xsl:if test=""string($var:v17)='true'"">
                      <siteSecondaryClientSiteID>
                        <xsl:attribute name=""xsi:nil"">
                          <xsl:value-of select=""'true'"" />
                        </xsl:attribute>
                      </siteSecondaryClientSiteID>
                    </xsl:if>
                    <xsl:if test=""string($var:v17)='false'"">
                      <siteSecondaryClientSiteID>
                        <xsl:value-of select=""s1:vendor_addr_SecondaryClientSiteID/text()"" />
                      </siteSecondaryClientSiteID>
                    </xsl:if>
                  </xsl:if>
                  <xsl:if test=""s1:vendor_addr_clientdivisionid"">
                    <xsl:variable name=""var:v18"" select=""string(s1:vendor_addr_clientdivisionid/@xsi:nil) = 'true'"" />
                    <xsl:if test=""string($var:v18)='true'"">
                      <siteDivisionid>
                        <xsl:attribute name=""xsi:nil"">
                          <xsl:value-of select=""'true'"" />
                        </xsl:attribute>
                      </siteDivisionid>
                    </xsl:if>
                    <xsl:if test=""string($var:v18)='false'"">
                      <siteDivisionid>
                        <xsl:value-of select=""s1:vendor_addr_clientdivisionid/text()"" />
                      </siteDivisionid>
                    </xsl:if>
                  </xsl:if>
                  <xsl:if test=""s1:vendor_addr_clientregionid"">
                    <xsl:variable name=""var:v19"" select=""string(s1:vendor_addr_clientregionid/@xsi:nil) = 'true'"" />
                    <xsl:if test=""string($var:v19)='true'"">
                      <siteRegionid>
                        <xsl:attribute name=""xsi:nil"">
                          <xsl:value-of select=""'true'"" />
                        </xsl:attribute>
                      </siteRegionid>
                    </xsl:if>
                    <xsl:if test=""string($var:v19)='false'"">
                      <siteRegionid>
                        <xsl:value-of select=""s1:vendor_addr_clientregionid/text()"" />
                      </siteRegionid>
                    </xsl:if>
                  </xsl:if>
                  <xsl:if test=""s1:vendor_addr_latitude"">
                    <xsl:variable name=""var:v20"" select=""string(s1:vendor_addr_latitude/@xsi:nil) = 'true'"" />
                    <xsl:if test=""string($var:v20)='true'"">
                      <siteLatitude>
                        <xsl:attribute name=""xsi:nil"">
                          <xsl:value-of select=""'true'"" />
                        </xsl:attribute>
                      </siteLatitude>
                    </xsl:if>
                    <xsl:if test=""string($var:v20)='false'"">
                      <siteLatitude>
                        <xsl:value-of select=""s1:vendor_addr_latitude/text()"" />
                      </siteLatitude>
                    </xsl:if>
                  </xsl:if>
                  <xsl:if test=""s1:vendor_addr_longitude"">
                    <xsl:variable name=""var:v21"" select=""string(s1:vendor_addr_longitude/@xsi:nil) = 'true'"" />
                    <xsl:if test=""string($var:v21)='true'"">
                      <siteLongitude>
                        <xsl:attribute name=""xsi:nil"">
                          <xsl:value-of select=""'true'"" />
                        </xsl:attribute>
                      </siteLongitude>
                    </xsl:if>
                    <xsl:if test=""string($var:v21)='false'"">
                      <siteLongitude>
                        <xsl:value-of select=""s1:vendor_addr_longitude/text()"" />
                      </siteLongitude>
                    </xsl:if>
                  </xsl:if>
                </ns8:Address>
              </ns5:Location>
              <ns4:Person>
                <xsl:if test=""s1:vendor_firstname"">
                  <xsl:variable name=""var:v22"" select=""string(s1:vendor_firstname/@xsi:nil) = 'true'"" />
                  <xsl:if test=""string($var:v22)='true'"">
                    <FirstName>
                      <xsl:attribute name=""xsi:nil"">
                        <xsl:value-of select=""'true'"" />
                      </xsl:attribute>
                    </FirstName>
                  </xsl:if>
                  <xsl:if test=""string($var:v22)='false'"">
                    <FirstName>
                      <xsl:value-of select=""s1:vendor_firstname/text()"" />
                    </FirstName>
                  </xsl:if>
                </xsl:if>
                <xsl:if test=""s1:vendor_lastname"">
                  <xsl:variable name=""var:v23"" select=""string(s1:vendor_lastname/@xsi:nil) = 'true'"" />
                  <xsl:if test=""string($var:v23)='true'"">
                    <LastName>
                      <xsl:attribute name=""xsi:nil"">
                        <xsl:value-of select=""'true'"" />
                      </xsl:attribute>
                    </LastName>
                  </xsl:if>
                  <xsl:if test=""string($var:v23)='false'"">
                    <LastName>
                      <xsl:value-of select=""s1:vendor_lastname/text()"" />
                    </LastName>
                  </xsl:if>
                </xsl:if>
                <xsl:if test=""s1:vendor_phonenumber"">
                  <xsl:variable name=""var:v24"" select=""string(s1:vendor_phonenumber/@xsi:nil) = 'true'"" />
                  <xsl:if test=""string($var:v24)='true'"">
                    <PhoneNumber>
                      <xsl:attribute name=""xsi:nil"">
                        <xsl:value-of select=""'true'"" />
                      </xsl:attribute>
                    </PhoneNumber>
                  </xsl:if>
                  <xsl:if test=""string($var:v24)='false'"">
                    <PhoneNumber>
                      <xsl:value-of select=""s1:vendor_phonenumber/text()"" />
                    </PhoneNumber>
                  </xsl:if>
                </xsl:if>
                <xsl:if test=""s1:vendor_emailaddress"">
                  <xsl:variable name=""var:v25"" select=""string(s1:vendor_emailaddress/@xsi:nil) = 'true'"" />
                  <xsl:if test=""string($var:v25)='true'"">
                    <EmailAddress>
                      <xsl:attribute name=""xsi:nil"">
                        <xsl:value-of select=""'true'"" />
                      </xsl:attribute>
                    </EmailAddress>
                  </xsl:if>
                  <xsl:if test=""string($var:v25)='false'"">
                    <EmailAddress>
                      <xsl:value-of select=""s1:vendor_emailaddress/text()"" />
                    </EmailAddress>
                  </xsl:if>
                </xsl:if>
              </ns4:Person>
            </ns2:Vendor>
          </xsl:for-each>
        </xsl:for-each>
        <xsl:for-each select=""s3:StoredProcedureResultSet0"">
          <xsl:for-each select=""s1:StoredProcedureResultSet0"">
            <ns9:Workitem>
              <xsl:if test=""s1:Case_CaseId"">
                <ns9:HelpdeskId>
                  <xsl:value-of select=""s1:Case_CaseId/text()"" />
                </ns9:HelpdeskId>
              </xsl:if>
              <xsl:if test=""s1:Case_PrimaryCompanyId"">
                <ns9:CompanyId>
                  <xsl:value-of select=""s1:Case_PrimaryCompanyId/text()"" />
                </ns9:CompanyId>
              </xsl:if>
              <xsl:if test=""s1:Case_PrimaryPersonId"">
                <xsl:variable name=""var:v26"" select=""string(s1:Case_PrimaryPersonId/@xsi:nil) = 'true'"" />
                <xsl:if test=""string($var:v26)='true'"">
                  <ns9:PersonId>
                    <xsl:attribute name=""xsi:nil"">
                      <xsl:value-of select=""'true'"" />
                    </xsl:attribute>
                  </ns9:PersonId>
                </xsl:if>
                <xsl:if test=""string($var:v26)='false'"">
                  <ns9:PersonId>
                    <xsl:value-of select=""s1:Case_PrimaryPersonId/text()"" />
                  </ns9:PersonId>
                </xsl:if>
              </xsl:if>
              <xsl:if test=""s1:Case_AssignedUserId"">
                <xsl:variable name=""var:v27"" select=""string(s1:Case_AssignedUserId/@xsi:nil) = 'true'"" />
                <xsl:if test=""string($var:v27)='true'"">
                  <ns9:AssignedId>
                    <xsl:attribute name=""xsi:nil"">
                      <xsl:value-of select=""'true'"" />
                    </xsl:attribute>
                  </ns9:AssignedId>
                </xsl:if>
                <xsl:if test=""string($var:v27)='false'"">
                  <ns9:AssignedId>
                    <xsl:value-of select=""s1:Case_AssignedUserId/text()"" />
                  </ns9:AssignedId>
                </xsl:if>
              </xsl:if>
              <xsl:if test=""s1:Case_ChannelId"">
                <xsl:variable name=""var:v28"" select=""string(s1:Case_ChannelId/@xsi:nil) = 'true'"" />
                <xsl:if test=""string($var:v28)='true'"">
                  <ns9:ChannelId>
                    <xsl:attribute name=""xsi:nil"">
                      <xsl:value-of select=""'true'"" />
                    </xsl:attribute>
                  </ns9:ChannelId>
                </xsl:if>
                <xsl:if test=""string($var:v28)='false'"">
                  <ns9:ChannelId>
                    <xsl:value-of select=""s1:Case_ChannelId/text()"" />
                  </ns9:ChannelId>
                </xsl:if>
              </xsl:if>
              <xsl:if test=""s1:Case_CustomerRef"">
                <xsl:variable name=""var:v29"" select=""string(s1:Case_CustomerRef/@xsi:nil) = 'true'"" />
                <xsl:if test=""string($var:v29)='true'"">
                  <ns9:CustomerRef>
                    <xsl:attribute name=""xsi:nil"">
                      <xsl:value-of select=""'true'"" />
                    </xsl:attribute>
                  </ns9:CustomerRef>
                </xsl:if>
                <xsl:if test=""string($var:v29)='false'"">
                  <ns9:CustomerRef>
                    <xsl:value-of select=""s1:Case_CustomerRef/text()"" />
                  </ns9:CustomerRef>
                </xsl:if>
              </xsl:if>
              <xsl:if test=""s1:Case_Source"">
                <xsl:variable name=""var:v30"" select=""string(s1:Case_Source/@xsi:nil) = 'true'"" />
                <xsl:if test=""string($var:v30)='true'"">
                  <ns9:Source>
                    <xsl:attribute name=""xsi:nil"">
                      <xsl:value-of select=""'true'"" />
                    </xsl:attribute>
                  </ns9:Source>
                </xsl:if>
                <xsl:if test=""string($var:v30)='false'"">
                  <ns9:Source>
                    <xsl:value-of select=""s1:Case_Source/text()"" />
                  </ns9:Source>
                </xsl:if>
              </xsl:if>
              <xsl:if test=""s1:Case_SolutionType"">
                <xsl:variable name=""var:v31"" select=""string(s1:Case_SolutionType/@xsi:nil) = 'true'"" />
                <xsl:if test=""string($var:v31)='true'"">
                  <ns9:SolutionType>
                    <xsl:attribute name=""xsi:nil"">
                      <xsl:value-of select=""'true'"" />
                    </xsl:attribute>
                  </ns9:SolutionType>
                </xsl:if>
                <xsl:if test=""string($var:v31)='false'"">
                  <ns9:SolutionType>
                    <xsl:value-of select=""s1:Case_SolutionType/text()"" />
                  </ns9:SolutionType>
                </xsl:if>
              </xsl:if>
              <xsl:if test=""s1:Case_ProblemNote"">
                <xsl:variable name=""var:v32"" select=""string(s1:Case_ProblemNote/@xsi:nil) = 'true'"" />
                <xsl:if test=""string($var:v32)='true'"">
                  <ns9:ProblemNote>
                    <xsl:attribute name=""xsi:nil"">
                      <xsl:value-of select=""'true'"" />
                    </xsl:attribute>
                  </ns9:ProblemNote>
                </xsl:if>
                <xsl:if test=""string($var:v32)='false'"">
                  <ns9:ProblemNote>
                    <xsl:value-of select=""s1:Case_ProblemNote/text()"" />
                  </ns9:ProblemNote>
                </xsl:if>
              </xsl:if>
              <xsl:if test=""s1:Case_Opened"">
                <xsl:variable name=""var:v33"" select=""string(s1:Case_Opened/@xsi:nil) = 'true'"" />
                <xsl:if test=""string($var:v33)='true'"">
                  <ns9:OpenedDate>
                    <xsl:attribute name=""xsi:nil"">
                      <xsl:value-of select=""'true'"" />
                    </xsl:attribute>
                  </ns9:OpenedDate>
                </xsl:if>
                <xsl:if test=""string($var:v33)='false'"">
                  <ns9:OpenedDate>
                    <xsl:value-of select=""s1:Case_Opened/text()"" />
                  </ns9:OpenedDate>
                </xsl:if>
              </xsl:if>
              <xsl:if test=""s1:Case_OpenedBy"">
                <xsl:variable name=""var:v34"" select=""string(s1:Case_OpenedBy/@xsi:nil) = 'true'"" />
                <xsl:if test=""string($var:v34)='true'"">
                  <ns9:OpenedBy>
                    <xsl:attribute name=""xsi:nil"">
                      <xsl:value-of select=""'true'"" />
                    </xsl:attribute>
                  </ns9:OpenedBy>
                </xsl:if>
                <xsl:if test=""string($var:v34)='false'"">
                  <ns9:OpenedBy>
                    <xsl:value-of select=""s1:Case_OpenedBy/text()"" />
                  </ns9:OpenedBy>
                </xsl:if>
              </xsl:if>
              <xsl:if test=""s1:Case_ClosedBy"">
                <xsl:variable name=""var:v35"" select=""string(s1:Case_ClosedBy/@xsi:nil) = 'true'"" />
                <xsl:if test=""string($var:v35)='true'"">
                  <ns9:ClosedBy>
                    <xsl:attribute name=""xsi:nil"">
                      <xsl:value-of select=""'true'"" />
                    </xsl:attribute>
                  </ns9:ClosedBy>
                </xsl:if>
                <xsl:if test=""string($var:v35)='false'"">
                  <ns9:ClosedBy>
                    <xsl:value-of select=""s1:Case_ClosedBy/text()"" />
                  </ns9:ClosedBy>
                </xsl:if>
              </xsl:if>
              <xsl:if test=""s1:Case_Status"">
                <xsl:variable name=""var:v36"" select=""string(s1:Case_Status/@xsi:nil) = 'true'"" />
                <xsl:if test=""string($var:v36)='true'"">
                  <ns9:Status>
                    <xsl:attribute name=""xsi:nil"">
                      <xsl:value-of select=""'true'"" />
                    </xsl:attribute>
                  </ns9:Status>
                </xsl:if>
                <xsl:if test=""string($var:v36)='false'"">
                  <ns9:Status>
                    <xsl:value-of select=""s1:Case_Status/text()"" />
                  </ns9:Status>
                </xsl:if>
              </xsl:if>
              <xsl:if test=""s1:Case_Stage"">
                <xsl:variable name=""var:v37"" select=""string(s1:Case_Stage/@xsi:nil) = 'true'"" />
                <xsl:if test=""string($var:v37)='true'"">
                  <ns9:Stage>
                    <xsl:attribute name=""xsi:nil"">
                      <xsl:value-of select=""'true'"" />
                    </xsl:attribute>
                  </ns9:Stage>
                </xsl:if>
                <xsl:if test=""string($var:v37)='false'"">
                  <ns9:Stage>
                    <xsl:value-of select=""s1:Case_Stage/text()"" />
                  </ns9:Stage>
                </xsl:if>
              </xsl:if>
              <xsl:if test=""s1:Case_CreatedBy"">
                <xsl:variable name=""var:v38"" select=""string(s1:Case_CreatedBy/@xsi:nil) = 'true'"" />
                <xsl:if test=""string($var:v38)='true'"">
                  <ns9:CreatedBy>
                    <xsl:attribute name=""xsi:nil"">
                      <xsl:value-of select=""'true'"" />
                    </xsl:attribute>
                  </ns9:CreatedBy>
                </xsl:if>
                <xsl:if test=""string($var:v38)='false'"">
                  <ns9:CreatedBy>
                    <xsl:value-of select=""s1:Case_CreatedBy/text()"" />
                  </ns9:CreatedBy>
                </xsl:if>
              </xsl:if>
              <xsl:if test=""s1:Case_CreatedDate"">
                <xsl:variable name=""var:v39"" select=""string(s1:Case_CreatedDate/@xsi:nil) = 'true'"" />
                <xsl:if test=""string($var:v39)='true'"">
                  <ns9:CreatedDate>
                    <xsl:attribute name=""xsi:nil"">
                      <xsl:value-of select=""'true'"" />
                    </xsl:attribute>
                  </ns9:CreatedDate>
                </xsl:if>
                <xsl:if test=""string($var:v39)='false'"">
                  <ns9:CreatedDate>
                    <xsl:value-of select=""s1:Case_CreatedDate/text()"" />
                  </ns9:CreatedDate>
                </xsl:if>
              </xsl:if>
              <xsl:if test=""s1:Case_UpdatedBy"">
                <xsl:variable name=""var:v40"" select=""string(s1:Case_UpdatedBy/@xsi:nil) = 'true'"" />
                <xsl:if test=""string($var:v40)='true'"">
                  <ns9:UpdatedId>
                    <xsl:attribute name=""xsi:nil"">
                      <xsl:value-of select=""'true'"" />
                    </xsl:attribute>
                  </ns9:UpdatedId>
                </xsl:if>
                <xsl:if test=""string($var:v40)='false'"">
                  <ns9:UpdatedId>
                    <xsl:value-of select=""s1:Case_UpdatedBy/text()"" />
                  </ns9:UpdatedId>
                </xsl:if>
              </xsl:if>
              <xsl:if test=""s1:Case_UpdatedDate"">
                <xsl:variable name=""var:v41"" select=""string(s1:Case_UpdatedDate/@xsi:nil) = 'true'"" />
                <xsl:if test=""string($var:v41)='true'"">
                  <ns9:UpdatedDate>
                    <xsl:attribute name=""xsi:nil"">
                      <xsl:value-of select=""'true'"" />
                    </xsl:attribute>
                  </ns9:UpdatedDate>
                </xsl:if>
                <xsl:if test=""string($var:v41)='false'"">
                  <ns9:UpdatedDate>
                    <xsl:value-of select=""s1:Case_UpdatedDate/text()"" />
                  </ns9:UpdatedDate>
                </xsl:if>
              </xsl:if>
              <xsl:if test=""s1:Case_ReferenceId"">
                <xsl:variable name=""var:v42"" select=""string(s1:Case_ReferenceId/@xsi:nil) = 'true'"" />
                <xsl:if test=""string($var:v42)='true'"">
                  <ns9:HelpdeskReference>
                    <xsl:attribute name=""xsi:nil"">
                      <xsl:value-of select=""'true'"" />
                    </xsl:attribute>
                  </ns9:HelpdeskReference>
                </xsl:if>
                <xsl:if test=""string($var:v42)='false'"">
                  <ns9:HelpdeskReference>
                    <xsl:value-of select=""s1:Case_ReferenceId/text()"" />
                  </ns9:HelpdeskReference>
                </xsl:if>
              </xsl:if>
              <xsl:if test=""s1:Case_WorkflowId"">
                <xsl:variable name=""var:v43"" select=""string(s1:Case_WorkflowId/@xsi:nil) = 'true'"" />
                <xsl:if test=""string($var:v43)='true'"">
                  <ns9:WorkflowId>
                    <xsl:attribute name=""xsi:nil"">
                      <xsl:value-of select=""'true'"" />
                    </xsl:attribute>
                  </ns9:WorkflowId>
                </xsl:if>
                <xsl:if test=""string($var:v43)='false'"">
                  <ns9:WorkflowId>
                    <xsl:value-of select=""s1:Case_WorkflowId/text()"" />
                  </ns9:WorkflowId>
                </xsl:if>
              </xsl:if>
              <xsl:if test=""s1:Case_SLASeverity"">
                <xsl:variable name=""var:v44"" select=""string(s1:Case_SLASeverity/@xsi:nil) = 'true'"" />
                <xsl:if test=""string($var:v44)='true'"">
                  <ns9:SLA>
                    <xsl:attribute name=""xsi:nil"">
                      <xsl:value-of select=""'true'"" />
                    </xsl:attribute>
                  </ns9:SLA>
                </xsl:if>
                <xsl:if test=""string($var:v44)='false'"">
                  <ns9:SLA>
                    <xsl:value-of select=""s1:Case_SLASeverity/text()"" />
                  </ns9:SLA>
                </xsl:if>
              </xsl:if>
              <xsl:if test=""s1:case_CustOrderNo"">
                <xsl:variable name=""var:v45"" select=""string(s1:case_CustOrderNo/@xsi:nil) = 'true'"" />
                <xsl:if test=""string($var:v45)='true'"">
                  <ns9:CustomerPurchaseOrderNo>
                    <xsl:attribute name=""xsi:nil"">
                      <xsl:value-of select=""'true'"" />
                    </xsl:attribute>
                  </ns9:CustomerPurchaseOrderNo>
                </xsl:if>
                <xsl:if test=""string($var:v45)='false'"">
                  <ns9:CustomerPurchaseOrderNo>
                    <xsl:value-of select=""s1:case_CustOrderNo/text()"" />
                  </ns9:CustomerPurchaseOrderNo>
                </xsl:if>
              </xsl:if>
              <xsl:if test=""s1:case_CallType"">
                <xsl:variable name=""var:v46"" select=""string(s1:case_CallType/@xsi:nil) = 'true'"" />
                <xsl:if test=""string($var:v46)='true'"">
                  <ns9:WorkType>
                    <xsl:attribute name=""xsi:nil"">
                      <xsl:value-of select=""'true'"" />
                    </xsl:attribute>
                  </ns9:WorkType>
                </xsl:if>
                <xsl:if test=""string($var:v46)='false'"">
                  <ns9:WorkType>
                    <xsl:value-of select=""s1:case_CallType/text()"" />
                  </ns9:WorkType>
                </xsl:if>
              </xsl:if>
              <xsl:if test=""s1:case_chargeablevalue"">
                <xsl:variable name=""var:v47"" select=""string(s1:case_chargeablevalue/@xsi:nil) = 'true'"" />
                <xsl:if test=""string($var:v47)='true'"">
                  <ns9:ChargeableValue>
                    <xsl:attribute name=""xsi:nil"">
                      <xsl:value-of select=""'true'"" />
                    </xsl:attribute>
                  </ns9:ChargeableValue>
                </xsl:if>
                <xsl:if test=""string($var:v47)='false'"">
                  <ns9:ChargeableValue>
                    <xsl:value-of select=""s1:case_chargeablevalue/text()"" />
                  </ns9:ChargeableValue>
                </xsl:if>
              </xsl:if>
              <xsl:if test=""s1:case_cp_acknowledge"">
                <xsl:variable name=""var:v48"" select=""string(s1:case_cp_acknowledge/@xsi:nil) = 'true'"" />
                <xsl:if test=""string($var:v48)='true'"">
                  <ns9:VendorAcknowledgeBy>
                    <xsl:attribute name=""xsi:nil"">
                      <xsl:value-of select=""'true'"" />
                    </xsl:attribute>
                  </ns9:VendorAcknowledgeBy>
                </xsl:if>
                <xsl:if test=""string($var:v48)='false'"">
                  <ns9:VendorAcknowledgeBy>
                    <xsl:value-of select=""s1:case_cp_acknowledge/text()"" />
                  </ns9:VendorAcknowledgeBy>
                </xsl:if>
              </xsl:if>
              <xsl:if test=""s1:case_cp_allocate"">
                <xsl:variable name=""var:v49"" select=""string(s1:case_cp_allocate/@xsi:nil) = 'true'"" />
                <xsl:if test=""string($var:v49)='true'"">
                  <ns9:VendorAllocateBy>
                    <xsl:attribute name=""xsi:nil"">
                      <xsl:value-of select=""'true'"" />
                    </xsl:attribute>
                  </ns9:VendorAllocateBy>
                </xsl:if>
                <xsl:if test=""string($var:v49)='false'"">
                  <ns9:VendorAllocateBy>
                    <xsl:value-of select=""s1:case_cp_allocate/text()"" />
                  </ns9:VendorAllocateBy>
                </xsl:if>
              </xsl:if>
              <xsl:if test=""s1:case_cp_attend"">
                <ns9:VendorAttendBy>
                  <xsl:value-of select=""s1:case_cp_attend/text()"" />
                </ns9:VendorAttendBy>
              </xsl:if>
              <xsl:if test=""s1:case_cp_complete"">
                <ns9:VendorCompleteBy>
                  <xsl:value-of select=""s1:case_cp_complete/text()"" />
                </ns9:VendorCompleteBy>
              </xsl:if>
              <xsl:if test=""s1:case_cp_verify"">
                <xsl:variable name=""var:v50"" select=""string(s1:case_cp_verify/@xsi:nil) = 'true'"" />
                <xsl:if test=""string($var:v50)='true'"">
                  <ns9:CustomerVerifyBy>
                    <xsl:attribute name=""xsi:nil"">
                      <xsl:value-of select=""'true'"" />
                    </xsl:attribute>
                  </ns9:CustomerVerifyBy>
                </xsl:if>
                <xsl:if test=""string($var:v50)='false'"">
                  <ns9:CustomerVerifyBy>
                    <xsl:value-of select=""s1:case_cp_verify/text()"" />
                  </ns9:CustomerVerifyBy>
                </xsl:if>
              </xsl:if>
              <xsl:if test=""s1:case_BundleItemId"">
                <ns9:ContractBundleId>
                  <xsl:value-of select=""s1:case_BundleItemId/text()"" />
                </ns9:ContractBundleId>
              </xsl:if>
              <ns9:CustomerDivision>
                <xsl:if test=""s1:case_ClientDivisionId"">
                  <xsl:attribute name=""CustomerDivisionId"">
                    <xsl:value-of select=""s1:case_ClientDivisionId/text()"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:if test=""s1:Customer_Division_Name"">
                  <ns9:CustomerDivisionName>
                    <xsl:value-of select=""s1:Customer_Division_Name/text()"" />
                  </ns9:CustomerDivisionName>
                </xsl:if>
              </ns9:CustomerDivision>
              <xsl:if test=""s1:case_ServiceStreamId"">
                <ns9:ServiceStreamId>
                  <xsl:value-of select=""s1:case_ServiceStreamId/text()"" />
                </ns9:ServiceStreamId>
              </xsl:if>
              <xsl:if test=""s1:case_ServiceTypeId"">
                <ns9:ServiceTypeId>
                  <xsl:value-of select=""s1:case_ServiceTypeId/text()"" />
                </ns9:ServiceTypeId>
              </xsl:if>
              <xsl:if test=""s1:case_ServiceDetailId"">
                <ns9:ServiceDetailId>
                  <xsl:value-of select=""s1:case_ServiceDetailId/text()"" />
                </ns9:ServiceDetailId>
              </xsl:if>
              <xsl:if test=""s1:case_cp_acknowledge_overridden"">
                <xsl:variable name=""var:v51"" select=""string(s1:case_cp_acknowledge_overridden/@xsi:nil) = 'true'"" />
                <xsl:if test=""string($var:v51)='true'"">
                  <ns9:VendorAcknowledgeSlaOverridden>
                    <xsl:attribute name=""xsi:nil"">
                      <xsl:value-of select=""'true'"" />
                    </xsl:attribute>
                  </ns9:VendorAcknowledgeSlaOverridden>
                </xsl:if>
                <xsl:if test=""string($var:v51)='false'"">
                  <ns9:VendorAcknowledgeSlaOverridden>
                    <xsl:value-of select=""s1:case_cp_acknowledge_overridden/text()"" />
                  </ns9:VendorAcknowledgeSlaOverridden>
                </xsl:if>
              </xsl:if>
              <xsl:if test=""s1:case_cp_allocate_overridden"">
                <xsl:variable name=""var:v52"" select=""string(s1:case_cp_allocate_overridden/@xsi:nil) = 'true'"" />
                <xsl:if test=""string($var:v52)='true'"">
                  <ns9:VendorAllocateSlaOverridden>
                    <xsl:attribute name=""xsi:nil"">
                      <xsl:value-of select=""'true'"" />
                    </xsl:attribute>
                  </ns9:VendorAllocateSlaOverridden>
                </xsl:if>
                <xsl:if test=""string($var:v52)='false'"">
                  <ns9:VendorAllocateSlaOverridden>
                    <xsl:value-of select=""s1:case_cp_allocate_overridden/text()"" />
                  </ns9:VendorAllocateSlaOverridden>
                </xsl:if>
              </xsl:if>
              <xsl:if test=""s1:case_cp_attend_overridden"">
                <xsl:variable name=""var:v53"" select=""string(s1:case_cp_attend_overridden/@xsi:nil) = 'true'"" />
                <xsl:if test=""string($var:v53)='true'"">
                  <ns9:VendorAttendSlaOverridden>
                    <xsl:attribute name=""xsi:nil"">
                      <xsl:value-of select=""'true'"" />
                    </xsl:attribute>
                  </ns9:VendorAttendSlaOverridden>
                </xsl:if>
                <xsl:if test=""string($var:v53)='false'"">
                  <ns9:VendorAttendSlaOverridden>
                    <xsl:value-of select=""s1:case_cp_attend_overridden/text()"" />
                  </ns9:VendorAttendSlaOverridden>
                </xsl:if>
              </xsl:if>
              <xsl:if test=""s1:case_cp_verify_overridden"">
                <xsl:variable name=""var:v54"" select=""string(s1:case_cp_verify_overridden/@xsi:nil) = 'true'"" />
                <xsl:if test=""string($var:v54)='true'"">
                  <ns9:CustomerVerifySlaOverridden>
                    <xsl:attribute name=""xsi:nil"">
                      <xsl:value-of select=""'true'"" />
                    </xsl:attribute>
                  </ns9:CustomerVerifySlaOverridden>
                </xsl:if>
                <xsl:if test=""string($var:v54)='false'"">
                  <ns9:CustomerVerifySlaOverridden>
                    <xsl:value-of select=""s1:case_cp_verify_overridden/text()"" />
                  </ns9:CustomerVerifySlaOverridden>
                </xsl:if>
              </xsl:if>
              <xsl:if test=""s1:case_cp_complete_overridden"">
                <xsl:variable name=""var:v55"" select=""string(s1:case_cp_complete_overridden/@xsi:nil) = 'true'"" />
                <xsl:if test=""string($var:v55)='true'"">
                  <ns9:VendorCompleteSlaOverridden>
                    <xsl:attribute name=""xsi:nil"">
                      <xsl:value-of select=""'true'"" />
                    </xsl:attribute>
                  </ns9:VendorCompleteSlaOverridden>
                </xsl:if>
                <xsl:if test=""string($var:v55)='false'"">
                  <ns9:VendorCompleteSlaOverridden>
                    <xsl:value-of select=""s1:case_cp_complete_overridden/text()"" />
                  </ns9:VendorCompleteSlaOverridden>
                </xsl:if>
              </xsl:if>
              <xsl:if test=""s1:case_contactfirstname"">
                <xsl:variable name=""var:v56"" select=""string(s1:case_contactfirstname/@xsi:nil) = 'true'"" />
                <xsl:if test=""string($var:v56)='true'"">
                  <ns9:ContactFirstname>
                    <xsl:attribute name=""xsi:nil"">
                      <xsl:value-of select=""'true'"" />
                    </xsl:attribute>
                  </ns9:ContactFirstname>
                </xsl:if>
                <xsl:if test=""string($var:v56)='false'"">
                  <ns9:ContactFirstname>
                    <xsl:value-of select=""s1:case_contactfirstname/text()"" />
                  </ns9:ContactFirstname>
                </xsl:if>
              </xsl:if>
              <xsl:if test=""s1:case_contactname"">
                <xsl:variable name=""var:v57"" select=""string(s1:case_contactname/@xsi:nil) = 'true'"" />
                <xsl:if test=""string($var:v57)='true'"">
                  <ns9:ContactSurname>
                    <xsl:attribute name=""xsi:nil"">
                      <xsl:value-of select=""'true'"" />
                    </xsl:attribute>
                  </ns9:ContactSurname>
                </xsl:if>
                <xsl:if test=""string($var:v57)='false'"">
                  <ns9:ContactSurname>
                    <xsl:value-of select=""s1:case_contactname/text()"" />
                  </ns9:ContactSurname>
                </xsl:if>
              </xsl:if>
              <xsl:if test=""s1:case_contactphone"">
                <xsl:variable name=""var:v58"" select=""string(s1:case_contactphone/@xsi:nil) = 'true'"" />
                <xsl:if test=""string($var:v58)='true'"">
                  <ns9:ContactPhone>
                    <xsl:attribute name=""xsi:nil"">
                      <xsl:value-of select=""'true'"" />
                    </xsl:attribute>
                  </ns9:ContactPhone>
                </xsl:if>
                <xsl:if test=""string($var:v58)='false'"">
                  <ns9:ContactPhone>
                    <xsl:value-of select=""s1:case_contactphone/text()"" />
                  </ns9:ContactPhone>
                </xsl:if>
              </xsl:if>
              <xsl:if test=""s1:case_contactmobile"">
                <xsl:variable name=""var:v59"" select=""string(s1:case_contactmobile/@xsi:nil) = 'true'"" />
                <xsl:if test=""string($var:v59)='true'"">
                  <ns9:ContactMobile>
                    <xsl:attribute name=""xsi:nil"">
                      <xsl:value-of select=""'true'"" />
                    </xsl:attribute>
                  </ns9:ContactMobile>
                </xsl:if>
                <xsl:if test=""string($var:v59)='false'"">
                  <ns9:ContactMobile>
                    <xsl:value-of select=""s1:case_contactmobile/text()"" />
                  </ns9:ContactMobile>
                </xsl:if>
              </xsl:if>
              <xsl:if test=""s1:case_contactemail"">
                <xsl:variable name=""var:v60"" select=""string(s1:case_contactemail/@xsi:nil) = 'true'"" />
                <xsl:if test=""string($var:v60)='true'"">
                  <ns9:ContactEmail>
                    <xsl:attribute name=""xsi:nil"">
                      <xsl:value-of select=""'true'"" />
                    </xsl:attribute>
                  </ns9:ContactEmail>
                </xsl:if>
                <xsl:if test=""string($var:v60)='false'"">
                  <ns9:ContactEmail>
                    <xsl:value-of select=""s1:case_contactemail/text()"" />
                  </ns9:ContactEmail>
                </xsl:if>
              </xsl:if>
              <xsl:if test=""s1:case_contactposition"">
                <xsl:variable name=""var:v61"" select=""string(s1:case_contactposition/@xsi:nil) = 'true'"" />
                <xsl:if test=""string($var:v61)='true'"">
                  <ns9:ContactPosition>
                    <xsl:attribute name=""xsi:nil"">
                      <xsl:value-of select=""'true'"" />
                    </xsl:attribute>
                  </ns9:ContactPosition>
                </xsl:if>
                <xsl:if test=""string($var:v61)='false'"">
                  <ns9:ContactPosition>
                    <xsl:value-of select=""s1:case_contactposition/text()"" />
                  </ns9:ContactPosition>
                </xsl:if>
              </xsl:if>
              <xsl:if test=""s1:case_locationid"">
                <ns9:SiteId>
                  <xsl:value-of select=""s1:case_locationid/text()"" />
                </ns9:SiteId>
              </xsl:if>
              <xsl:if test=""s1:case_objectid"">
                <xsl:variable name=""var:v62"" select=""string(s1:case_objectid/@xsi:nil) = 'true'"" />
                <xsl:if test=""string($var:v62)='true'"">
                  <ns9:objectid>
                    <xsl:attribute name=""xsi:nil"">
                      <xsl:value-of select=""'true'"" />
                    </xsl:attribute>
                  </ns9:objectid>
                </xsl:if>
                <xsl:if test=""string($var:v62)='false'"">
                  <ns9:objectid>
                    <xsl:value-of select=""s1:case_objectid/text()"" />
                  </ns9:objectid>
                </xsl:if>
              </xsl:if>
              <xsl:if test=""s1:case_jobfinancialsbudget"">
                <xsl:variable name=""var:v63"" select=""string(s1:case_jobfinancialsbudget/@xsi:nil) = 'true'"" />
                <xsl:if test=""string($var:v63)='true'"">
                  <ns9:BudgetValue>
                    <xsl:attribute name=""xsi:nil"">
                      <xsl:value-of select=""'true'"" />
                    </xsl:attribute>
                  </ns9:BudgetValue>
                </xsl:if>
                <xsl:if test=""string($var:v63)='false'"">
                  <ns9:BudgetValue>
                    <xsl:value-of select=""s1:case_jobfinancialsbudget/text()"" />
                  </ns9:BudgetValue>
                </xsl:if>
              </xsl:if>
              <xsl:if test=""s1:case_onhold_datetime"">
                <xsl:variable name=""var:v64"" select=""string(s1:case_onhold_datetime/@xsi:nil) = 'true'"" />
                <xsl:if test=""string($var:v64)='true'"">
                  <ns9:PlacedOnHoldTS>
                    <xsl:attribute name=""xsi:nil"">
                      <xsl:value-of select=""'true'"" />
                    </xsl:attribute>
                  </ns9:PlacedOnHoldTS>
                </xsl:if>
                <xsl:if test=""string($var:v64)='false'"">
                  <ns9:PlacedOnHoldTS>
                    <xsl:value-of select=""s1:case_onhold_datetime/text()"" />
                  </ns9:PlacedOnHoldTS>
                </xsl:if>
              </xsl:if>
              <xsl:if test=""s1:case_authoriserid"">
                <xsl:variable name=""var:v65"" select=""string(s1:case_authoriserid/@xsi:nil) = 'true'"" />
                <xsl:if test=""string($var:v65)='true'"">
                  <ns9:authoriserid>
                    <xsl:attribute name=""xsi:nil"">
                      <xsl:value-of select=""'true'"" />
                    </xsl:attribute>
                  </ns9:authoriserid>
                </xsl:if>
                <xsl:if test=""string($var:v65)='false'"">
                  <ns9:authoriserid>
                    <xsl:value-of select=""s1:case_authoriserid/text()"" />
                  </ns9:authoriserid>
                </xsl:if>
              </xsl:if>
              <xsl:if test=""s1:case_preauthoriserid"">
                <xsl:variable name=""var:v66"" select=""string(s1:case_preauthoriserid/@xsi:nil) = 'true'"" />
                <xsl:if test=""string($var:v66)='true'"">
                  <ns9:preauthoriserid>
                    <xsl:attribute name=""xsi:nil"">
                      <xsl:value-of select=""'true'"" />
                    </xsl:attribute>
                  </ns9:preauthoriserid>
                </xsl:if>
                <xsl:if test=""string($var:v66)='false'"">
                  <ns9:preauthoriserid>
                    <xsl:value-of select=""s1:case_preauthoriserid/text()"" />
                  </ns9:preauthoriserid>
                </xsl:if>
              </xsl:if>
              <xsl:if test=""s1:case_secondaryauthoriserid"">
                <xsl:variable name=""var:v67"" select=""string(s1:case_secondaryauthoriserid/@xsi:nil) = 'true'"" />
                <xsl:if test=""string($var:v67)='true'"">
                  <ns9:secondaryauthoriserid>
                    <xsl:attribute name=""xsi:nil"">
                      <xsl:value-of select=""'true'"" />
                    </xsl:attribute>
                  </ns9:secondaryauthoriserid>
                </xsl:if>
                <xsl:if test=""string($var:v67)='false'"">
                  <ns9:secondaryauthoriserid>
                    <xsl:value-of select=""s1:case_secondaryauthoriserid/text()"" />
                  </ns9:secondaryauthoriserid>
                </xsl:if>
              </xsl:if>
              <xsl:if test=""s1:case_notauthorisedbyid"">
                <xsl:variable name=""var:v68"" select=""string(s1:case_notauthorisedbyid/@xsi:nil) = 'true'"" />
                <xsl:if test=""string($var:v68)='true'"">
                  <ns9:notauthorisedbyid>
                    <xsl:attribute name=""xsi:nil"">
                      <xsl:value-of select=""'true'"" />
                    </xsl:attribute>
                  </ns9:notauthorisedbyid>
                </xsl:if>
                <xsl:if test=""string($var:v68)='false'"">
                  <ns9:notauthorisedbyid>
                    <xsl:value-of select=""s1:case_notauthorisedbyid/text()"" />
                  </ns9:notauthorisedbyid>
                </xsl:if>
              </xsl:if>
              <xsl:if test=""s1:case_authorised"">
                <xsl:variable name=""var:v69"" select=""string(s1:case_authorised/@xsi:nil) = 'true'"" />
                <xsl:if test=""string($var:v69)='true'"">
                  <ns9:authorised>
                    <xsl:attribute name=""xsi:nil"">
                      <xsl:value-of select=""'true'"" />
                    </xsl:attribute>
                  </ns9:authorised>
                </xsl:if>
                <xsl:if test=""string($var:v69)='false'"">
                  <ns9:authorised>
                    <xsl:value-of select=""s1:case_authorised/text()"" />
                  </ns9:authorised>
                </xsl:if>
              </xsl:if>
              <xsl:if test=""s1:case_preauthorised"">
                <xsl:variable name=""var:v70"" select=""string(s1:case_preauthorised/@xsi:nil) = 'true'"" />
                <xsl:if test=""string($var:v70)='true'"">
                  <ns9:preauthorised>
                    <xsl:attribute name=""xsi:nil"">
                      <xsl:value-of select=""'true'"" />
                    </xsl:attribute>
                  </ns9:preauthorised>
                </xsl:if>
                <xsl:if test=""string($var:v70)='false'"">
                  <ns9:preauthorised>
                    <xsl:value-of select=""s1:case_preauthorised/text()"" />
                  </ns9:preauthorised>
                </xsl:if>
              </xsl:if>
              <xsl:if test=""s1:case_secondaryauthorised"">
                <xsl:variable name=""var:v71"" select=""string(s1:case_secondaryauthorised/@xsi:nil) = 'true'"" />
                <xsl:if test=""string($var:v71)='true'"">
                  <ns9:secondaryauthorised>
                    <xsl:attribute name=""xsi:nil"">
                      <xsl:value-of select=""'true'"" />
                    </xsl:attribute>
                  </ns9:secondaryauthorised>
                </xsl:if>
                <xsl:if test=""string($var:v71)='false'"">
                  <ns9:secondaryauthorised>
                    <xsl:value-of select=""s1:case_secondaryauthorised/text()"" />
                  </ns9:secondaryauthorised>
                </xsl:if>
              </xsl:if>
              <xsl:if test=""s1:case_ProviderCompanyId"">
                <xsl:variable name=""var:v72"" select=""string(s1:case_ProviderCompanyId/@xsi:nil) = 'true'"" />
                <xsl:if test=""string($var:v72)='true'"">
                  <ns9:VendorId>
                    <xsl:attribute name=""xsi:nil"">
                      <xsl:value-of select=""'true'"" />
                    </xsl:attribute>
                  </ns9:VendorId>
                </xsl:if>
                <xsl:if test=""string($var:v72)='false'"">
                  <ns9:VendorId>
                    <xsl:value-of select=""s1:case_ProviderCompanyId/text()"" />
                  </ns9:VendorId>
                </xsl:if>
              </xsl:if>
              <xsl:if test=""s1:case_providerdivisionid"">
                <xsl:variable name=""var:v73"" select=""string(s1:case_providerdivisionid/@xsi:nil) = 'true'"" />
                <xsl:if test=""string($var:v73)='true'"">
                  <ns9:VendorDivisionId>
                    <xsl:attribute name=""xsi:nil"">
                      <xsl:value-of select=""'true'"" />
                    </xsl:attribute>
                  </ns9:VendorDivisionId>
                </xsl:if>
                <xsl:if test=""string($var:v73)='false'"">
                  <ns9:VendorDivisionId>
                    <xsl:value-of select=""s1:case_providerdivisionid/text()"" />
                  </ns9:VendorDivisionId>
                </xsl:if>
              </xsl:if>
              <xsl:if test=""s1:case_ProviderLocationId"">
                <xsl:variable name=""var:v74"" select=""string(s1:case_ProviderLocationId/@xsi:nil) = 'true'"" />
                <xsl:if test=""string($var:v74)='true'"">
                  <ns9:VendorLinkId>
                    <xsl:attribute name=""xsi:nil"">
                      <xsl:value-of select=""'true'"" />
                    </xsl:attribute>
                  </ns9:VendorLinkId>
                </xsl:if>
                <xsl:if test=""string($var:v74)='false'"">
                  <ns9:VendorLinkId>
                    <xsl:value-of select=""s1:case_ProviderLocationId/text()"" />
                  </ns9:VendorLinkId>
                </xsl:if>
              </xsl:if>
              <xsl:if test=""s1:case_ProviderPersonId"">
                <xsl:variable name=""var:v75"" select=""string(s1:case_ProviderPersonId/@xsi:nil) = 'true'"" />
                <xsl:if test=""string($var:v75)='true'"">
                  <ns9:VendorContactId>
                    <xsl:attribute name=""xsi:nil"">
                      <xsl:value-of select=""'true'"" />
                    </xsl:attribute>
                  </ns9:VendorContactId>
                </xsl:if>
                <xsl:if test=""string($var:v75)='false'"">
                  <ns9:VendorContactId>
                    <xsl:value-of select=""s1:case_ProviderPersonId/text()"" />
                  </ns9:VendorContactId>
                </xsl:if>
              </xsl:if>
              <xsl:if test=""s1:case_UnauthorisedPerson"">
                <xsl:variable name=""var:v76"" select=""string(s1:case_UnauthorisedPerson/@xsi:nil) = 'true'"" />
                <xsl:if test=""string($var:v76)='true'"">
                  <ns9:UnauthorisedPerson>
                    <xsl:attribute name=""xsi:nil"">
                      <xsl:value-of select=""'true'"" />
                    </xsl:attribute>
                  </ns9:UnauthorisedPerson>
                </xsl:if>
                <xsl:if test=""string($var:v76)='false'"">
                  <ns9:UnauthorisedPerson>
                    <xsl:value-of select=""s1:case_UnauthorisedPerson/text()"" />
                  </ns9:UnauthorisedPerson>
                </xsl:if>
              </xsl:if>
              <xsl:if test=""s1:case_timeattended"">
                <xsl:variable name=""var:v77"" select=""string(s1:case_timeattended/@xsi:nil) = 'true'"" />
                <xsl:if test=""string($var:v77)='true'"">
                  <ns9:VendorAttendedTS>
                    <xsl:attribute name=""xsi:nil"">
                      <xsl:value-of select=""'true'"" />
                    </xsl:attribute>
                  </ns9:VendorAttendedTS>
                </xsl:if>
                <xsl:if test=""string($var:v77)='false'"">
                  <ns9:VendorAttendedTS>
                    <xsl:value-of select=""s1:case_timeattended/text()"" />
                  </ns9:VendorAttendedTS>
                </xsl:if>
              </xsl:if>
              <xsl:if test=""s1:case_personattended"">
                <xsl:variable name=""var:v78"" select=""string(s1:case_personattended/@xsi:nil) = 'true'"" />
                <xsl:if test=""string($var:v78)='true'"">
                  <ns9:VendorAttendee>
                    <xsl:attribute name=""xsi:nil"">
                      <xsl:value-of select=""'true'"" />
                    </xsl:attribute>
                  </ns9:VendorAttendee>
                </xsl:if>
                <xsl:if test=""string($var:v78)='false'"">
                  <ns9:VendorAttendee>
                    <xsl:value-of select=""s1:case_personattended/text()"" />
                  </ns9:VendorAttendee>
                </xsl:if>
              </xsl:if>
              <xsl:if test=""s1:case_quotevalue"">
                <xsl:variable name=""var:v79"" select=""string(s1:case_quotevalue/@xsi:nil) = 'true'"" />
                <xsl:if test=""string($var:v79)='true'"">
                  <ns9:QuoteValue>
                    <xsl:attribute name=""xsi:nil"">
                      <xsl:value-of select=""'true'"" />
                    </xsl:attribute>
                  </ns9:QuoteValue>
                </xsl:if>
                <xsl:if test=""string($var:v79)='false'"">
                  <ns9:QuoteValue>
                    <xsl:value-of select=""s1:case_quotevalue/text()"" />
                  </ns9:QuoteValue>
                </xsl:if>
              </xsl:if>
              <xsl:if test=""s1:case_personverified"">
                <xsl:variable name=""var:v80"" select=""string(s1:case_personverified/@xsi:nil) = 'true'"" />
                <xsl:if test=""string($var:v80)='true'"">
                  <ns9:CustomerVerifedBy>
                    <xsl:attribute name=""xsi:nil"">
                      <xsl:value-of select=""'true'"" />
                    </xsl:attribute>
                  </ns9:CustomerVerifedBy>
                </xsl:if>
                <xsl:if test=""string($var:v80)='false'"">
                  <ns9:CustomerVerifedBy>
                    <xsl:value-of select=""s1:case_personverified/text()"" />
                  </ns9:CustomerVerifedBy>
                </xsl:if>
              </xsl:if>
              <xsl:if test=""s1:case_timeverified"">
                <xsl:variable name=""var:v81"" select=""string(s1:case_timeverified/@xsi:nil) = 'true'"" />
                <xsl:if test=""string($var:v81)='true'"">
                  <ns9:CustomerVerifiedTS>
                    <xsl:attribute name=""xsi:nil"">
                      <xsl:value-of select=""'true'"" />
                    </xsl:attribute>
                  </ns9:CustomerVerifiedTS>
                </xsl:if>
                <xsl:if test=""string($var:v81)='false'"">
                  <ns9:CustomerVerifiedTS>
                    <xsl:value-of select=""s1:case_timeverified/text()"" />
                  </ns9:CustomerVerifiedTS>
                </xsl:if>
              </xsl:if>
              <xsl:if test=""s1:case_timecompleted"">
                <xsl:variable name=""var:v82"" select=""string(s1:case_timecompleted/@xsi:nil) = 'true'"" />
                <xsl:if test=""string($var:v82)='true'"">
                  <ns9:timecompleted>
                    <xsl:attribute name=""xsi:nil"">
                      <xsl:value-of select=""'true'"" />
                    </xsl:attribute>
                  </ns9:timecompleted>
                </xsl:if>
                <xsl:if test=""string($var:v82)='false'"">
                  <ns9:timecompleted>
                    <xsl:value-of select=""s1:case_timecompleted/text()"" />
                  </ns9:timecompleted>
                </xsl:if>
              </xsl:if>
              <xsl:if test=""s1:case_timeallocated"">
                <xsl:variable name=""var:v83"" select=""string(s1:case_timeallocated/@xsi:nil) = 'true'"" />
                <xsl:if test=""string($var:v83)='true'"">
                  <ns9:timeallocated>
                    <xsl:attribute name=""xsi:nil"">
                      <xsl:value-of select=""'true'"" />
                    </xsl:attribute>
                  </ns9:timeallocated>
                </xsl:if>
                <xsl:if test=""string($var:v83)='false'"">
                  <ns9:timeallocated>
                    <xsl:value-of select=""s1:case_timeallocated/text()"" />
                  </ns9:timeallocated>
                </xsl:if>
              </xsl:if>
              <xsl:if test=""s1:case_timeacknowledged"">
                <xsl:variable name=""var:v84"" select=""string(s1:case_timeacknowledged/@xsi:nil) = 'true'"" />
                <xsl:if test=""string($var:v84)='true'"">
                  <ns9:timeacknowledged>
                    <xsl:attribute name=""xsi:nil"">
                      <xsl:value-of select=""'true'"" />
                    </xsl:attribute>
                  </ns9:timeacknowledged>
                </xsl:if>
                <xsl:if test=""string($var:v84)='false'"">
                  <ns9:timeacknowledged>
                    <xsl:value-of select=""s1:case_timeacknowledged/text()"" />
                  </ns9:timeacknowledged>
                </xsl:if>
              </xsl:if>
              <xsl:if test=""s1:case_linkedcaseid"">
                <xsl:variable name=""var:v85"" select=""string(s1:case_linkedcaseid/@xsi:nil) = 'true'"" />
                <xsl:if test=""string($var:v85)='true'"">
                  <ns9:LinkToHelpdeskCaseId>
                    <xsl:attribute name=""xsi:nil"">
                      <xsl:value-of select=""'true'"" />
                    </xsl:attribute>
                  </ns9:LinkToHelpdeskCaseId>
                </xsl:if>
                <xsl:if test=""string($var:v85)='false'"">
                  <ns9:LinkToHelpdeskCaseId>
                    <xsl:value-of select=""s1:case_linkedcaseid/text()"" />
                  </ns9:LinkToHelpdeskCaseId>
                </xsl:if>
              </xsl:if>
              <xsl:if test=""s1:case_quoterefno"">
                <xsl:variable name=""var:v86"" select=""string(s1:case_quoterefno/@xsi:nil) = 'true'"" />
                <xsl:if test=""string($var:v86)='true'"">
                  <ns9:QuoteNumber>
                    <xsl:attribute name=""xsi:nil"">
                      <xsl:value-of select=""'true'"" />
                    </xsl:attribute>
                  </ns9:QuoteNumber>
                </xsl:if>
                <xsl:if test=""string($var:v86)='false'"">
                  <ns9:QuoteNumber>
                    <xsl:value-of select=""s1:case_quoterefno/text()"" />
                  </ns9:QuoteNumber>
                </xsl:if>
              </xsl:if>
              <xsl:if test=""s1:case_quotedate"">
                <xsl:variable name=""var:v87"" select=""string(s1:case_quotedate/@xsi:nil) = 'true'"" />
                <xsl:if test=""string($var:v87)='true'"">
                  <ns9:QuoteDate>
                    <xsl:attribute name=""xsi:nil"">
                      <xsl:value-of select=""'true'"" />
                    </xsl:attribute>
                  </ns9:QuoteDate>
                </xsl:if>
                <xsl:if test=""string($var:v87)='false'"">
                  <ns9:QuoteDate>
                    <xsl:value-of select=""s1:case_quotedate/text()"" />
                  </ns9:QuoteDate>
                </xsl:if>
              </xsl:if>
              <xsl:if test=""s1:case_authorisedamount_CID"">
                <xsl:variable name=""var:v88"" select=""string(s1:case_authorisedamount_CID/@xsi:nil) = 'true'"" />
                <xsl:if test=""string($var:v88)='true'"">
                  <ns9:AuthoriseValueBanding>
                    <xsl:attribute name=""xsi:nil"">
                      <xsl:value-of select=""'true'"" />
                    </xsl:attribute>
                  </ns9:AuthoriseValueBanding>
                </xsl:if>
                <xsl:if test=""string($var:v88)='false'"">
                  <ns9:AuthoriseValueBanding>
                    <xsl:value-of select=""s1:case_authorisedamount_CID/text()"" />
                  </ns9:AuthoriseValueBanding>
                </xsl:if>
              </xsl:if>
              <xsl:if test=""s1:case_authorisedamount"">
                <xsl:variable name=""var:v89"" select=""string(s1:case_authorisedamount/@xsi:nil) = 'true'"" />
                <xsl:if test=""string($var:v89)='true'"">
                  <ns9:AuthorisedValue>
                    <xsl:attribute name=""xsi:nil"">
                      <xsl:value-of select=""'true'"" />
                    </xsl:attribute>
                  </ns9:AuthorisedValue>
                </xsl:if>
                <xsl:if test=""string($var:v89)='false'"">
                  <ns9:AuthorisedValue>
                    <xsl:value-of select=""s1:case_authorisedamount/text()"" />
                  </ns9:AuthorisedValue>
                </xsl:if>
              </xsl:if>
              <xsl:if test=""s1:case_externallyupdated"">
                <xsl:variable name=""var:v90"" select=""string(s1:case_externallyupdated/@xsi:nil) = 'true'"" />
                <xsl:if test=""string($var:v90)='true'"">
                  <ns9:externallyupdated>
                    <xsl:attribute name=""xsi:nil"">
                      <xsl:value-of select=""'true'"" />
                    </xsl:attribute>
                  </ns9:externallyupdated>
                </xsl:if>
                <xsl:if test=""string($var:v90)='false'"">
                  <ns9:externallyupdated>
                    <xsl:value-of select=""s1:case_externallyupdated/text()"" />
                  </ns9:externallyupdated>
                </xsl:if>
              </xsl:if>
              <xsl:if test=""s1:case_cancelledbyid"">
                <xsl:variable name=""var:v91"" select=""string(s1:case_cancelledbyid/@xsi:nil) = 'true'"" />
                <xsl:if test=""string($var:v91)='true'"">
                  <ns9:cancelledbyid>
                    <xsl:attribute name=""xsi:nil"">
                      <xsl:value-of select=""'true'"" />
                    </xsl:attribute>
                  </ns9:cancelledbyid>
                </xsl:if>
                <xsl:if test=""string($var:v91)='false'"">
                  <ns9:cancelledbyid>
                    <xsl:value-of select=""s1:case_cancelledbyid/text()"" />
                  </ns9:cancelledbyid>
                </xsl:if>
              </xsl:if>
              <xsl:if test=""s1:case_finalcallcost"">
                <xsl:variable name=""var:v92"" select=""string(s1:case_finalcallcost/@xsi:nil) = 'true'"" />
                <xsl:if test=""string($var:v92)='true'"">
                  <ns9:finalcallcost>
                    <xsl:attribute name=""xsi:nil"">
                      <xsl:value-of select=""'true'"" />
                    </xsl:attribute>
                  </ns9:finalcallcost>
                </xsl:if>
                <xsl:if test=""string($var:v92)='false'"">
                  <ns9:finalcallcost>
                    <xsl:value-of select=""s1:case_finalcallcost/text()"" />
                  </ns9:finalcallcost>
                </xsl:if>
              </xsl:if>
              <xsl:if test=""s1:case_targetattendby"">
                <xsl:variable name=""var:v93"" select=""string(s1:case_targetattendby/@xsi:nil) = 'true'"" />
                <xsl:if test=""string($var:v93)='true'"">
                  <ns9:targetattendby>
                    <xsl:attribute name=""xsi:nil"">
                      <xsl:value-of select=""'true'"" />
                    </xsl:attribute>
                  </ns9:targetattendby>
                </xsl:if>
                <xsl:if test=""string($var:v93)='false'"">
                  <ns9:targetattendby>
                    <xsl:value-of select=""s1:case_targetattendby/text()"" />
                  </ns9:targetattendby>
                </xsl:if>
              </xsl:if>
              <xsl:if test=""s1:case_person_instigatorcomms"">
                <xsl:variable name=""var:v94"" select=""string(s1:case_person_instigatorcomms/@xsi:nil) = 'true'"" />
                <xsl:if test=""string($var:v94)='true'"">
                  <ns9:person_instigatorcomms>
                    <xsl:attribute name=""xsi:nil"">
                      <xsl:value-of select=""'true'"" />
                    </xsl:attribute>
                  </ns9:person_instigatorcomms>
                </xsl:if>
                <xsl:if test=""string($var:v94)='false'"">
                  <ns9:person_instigatorcomms>
                    <xsl:value-of select=""s1:case_person_instigatorcomms/text()"" />
                  </ns9:person_instigatorcomms>
                </xsl:if>
              </xsl:if>
              <xsl:if test=""s1:case_contact_instigatorcomms"">
                <xsl:variable name=""var:v95"" select=""string(s1:case_contact_instigatorcomms/@xsi:nil) = 'true'"" />
                <xsl:if test=""string($var:v95)='true'"">
                  <ns9:contact_instigatorcomms>
                    <xsl:attribute name=""xsi:nil"">
                      <xsl:value-of select=""'true'"" />
                    </xsl:attribute>
                  </ns9:contact_instigatorcomms>
                </xsl:if>
                <xsl:if test=""string($var:v95)='false'"">
                  <ns9:contact_instigatorcomms>
                    <xsl:value-of select=""s1:case_contact_instigatorcomms/text()"" />
                  </ns9:contact_instigatorcomms>
                </xsl:if>
              </xsl:if>
              <xsl:if test=""s1:case_MaximoId"">
                <xsl:variable name=""var:v96"" select=""string(s1:case_MaximoId/@xsi:nil) = 'true'"" />
                <xsl:if test=""string($var:v96)='true'"">
                  <ns9:VendorReference>
                    <xsl:attribute name=""xsi:nil"">
                      <xsl:value-of select=""'true'"" />
                    </xsl:attribute>
                  </ns9:VendorReference>
                </xsl:if>
                <xsl:if test=""string($var:v96)='false'"">
                  <ns9:VendorReference>
                    <xsl:value-of select=""s1:case_MaximoId/text()"" />
                  </ns9:VendorReference>
                </xsl:if>
              </xsl:if>
              <xsl:if test=""s1:case_OracleId"">
                <xsl:variable name=""var:v97"" select=""string(s1:case_OracleId/@xsi:nil) = 'true'"" />
                <xsl:if test=""string($var:v97)='true'"">
                  <ns9:OracleId>
                    <xsl:attribute name=""xsi:nil"">
                      <xsl:value-of select=""'true'"" />
                    </xsl:attribute>
                  </ns9:OracleId>
                </xsl:if>
                <xsl:if test=""string($var:v97)='false'"">
                  <ns9:OracleId>
                    <xsl:value-of select=""s1:case_OracleId/text()"" />
                  </ns9:OracleId>
                </xsl:if>
              </xsl:if>
              <xsl:if test=""s1:case_costcode"">
                <xsl:variable name=""var:v98"" select=""string(s1:case_costcode/@xsi:nil) = 'true'"" />
                <xsl:if test=""string($var:v98)='true'"">
                  <ns9:CostCode>
                    <xsl:attribute name=""xsi:nil"">
                      <xsl:value-of select=""'true'"" />
                    </xsl:attribute>
                  </ns9:CostCode>
                </xsl:if>
                <xsl:if test=""string($var:v98)='false'"">
                  <ns9:CostCode>
                    <xsl:value-of select=""s1:case_costcode/text()"" />
                  </ns9:CostCode>
                </xsl:if>
              </xsl:if>
              <xsl:if test=""s1:case_chargingdivision"">
                <xsl:variable name=""var:v99"" select=""string(s1:case_chargingdivision/@xsi:nil) = 'true'"" />
                <xsl:if test=""string($var:v99)='true'"">
                  <ns9:BillingDivisionId>
                    <xsl:attribute name=""xsi:nil"">
                      <xsl:value-of select=""'true'"" />
                    </xsl:attribute>
                  </ns9:BillingDivisionId>
                </xsl:if>
                <xsl:if test=""string($var:v99)='false'"">
                  <ns9:BillingDivisionId>
                    <xsl:value-of select=""s1:case_chargingdivision/text()"" />
                  </ns9:BillingDivisionId>
                </xsl:if>
              </xsl:if>
              <xsl:if test=""s1:case_chargingregion"">
                <xsl:variable name=""var:v100"" select=""string(s1:case_chargingregion/@xsi:nil) = 'true'"" />
                <xsl:if test=""string($var:v100)='true'"">
                  <ns9:BillingRegionId>
                    <xsl:attribute name=""xsi:nil"">
                      <xsl:value-of select=""'true'"" />
                    </xsl:attribute>
                  </ns9:BillingRegionId>
                </xsl:if>
                <xsl:if test=""string($var:v100)='false'"">
                  <ns9:BillingRegionId>
                    <xsl:value-of select=""s1:case_chargingregion/text()"" />
                  </ns9:BillingRegionId>
                </xsl:if>
              </xsl:if>
              <xsl:if test=""s1:case_EndDate"">
                <xsl:variable name=""var:v101"" select=""string(s1:case_EndDate/@xsi:nil) = 'true'"" />
                <xsl:if test=""string($var:v101)='true'"">
                  <ns9:EndDate>
                    <xsl:attribute name=""xsi:nil"">
                      <xsl:value-of select=""'true'"" />
                    </xsl:attribute>
                  </ns9:EndDate>
                </xsl:if>
                <xsl:if test=""string($var:v101)='false'"">
                  <ns9:EndDate>
                    <xsl:value-of select=""s1:case_EndDate/text()"" />
                  </ns9:EndDate>
                </xsl:if>
              </xsl:if>
              <xsl:if test=""s1:case_assetid"">
                <xsl:variable name=""var:v102"" select=""string(s1:case_assetid/@xsi:nil) = 'true'"" />
                <xsl:if test=""string($var:v102)='true'"">
                  <ns9:AssetId>
                    <xsl:attribute name=""xsi:nil"">
                      <xsl:value-of select=""'true'"" />
                    </xsl:attribute>
                  </ns9:AssetId>
                </xsl:if>
                <xsl:if test=""string($var:v102)='false'"">
                  <ns9:AssetId>
                    <xsl:value-of select=""s1:case_assetid/text()"" />
                  </ns9:AssetId>
                </xsl:if>
              </xsl:if>
              <xsl:if test=""s1:case_LocationBundleItemId"">
                <xsl:variable name=""var:v103"" select=""string(s1:case_LocationBundleItemId/@xsi:nil) = 'true'"" />
                <xsl:if test=""string($var:v103)='true'"">
                  <ns9:LocationBundleItemId>
                    <xsl:attribute name=""xsi:nil"">
                      <xsl:value-of select=""'true'"" />
                    </xsl:attribute>
                  </ns9:LocationBundleItemId>
                </xsl:if>
                <xsl:if test=""string($var:v103)='false'"">
                  <ns9:LocationBundleItemId>
                    <xsl:value-of select=""s1:case_LocationBundleItemId/text()"" />
                  </ns9:LocationBundleItemId>
                </xsl:if>
              </xsl:if>
              <xsl:if test=""s1:case_fixdateonceagreed"">
                <xsl:variable name=""var:v104"" select=""string(s1:case_fixdateonceagreed/@xsi:nil) = 'true'"" />
                <xsl:if test=""string($var:v104)='true'"">
                  <ns9:fixdateonceagreed>
                    <xsl:attribute name=""xsi:nil"">
                      <xsl:value-of select=""'true'"" />
                    </xsl:attribute>
                  </ns9:fixdateonceagreed>
                </xsl:if>
                <xsl:if test=""string($var:v104)='false'"">
                  <ns9:fixdateonceagreed>
                    <xsl:value-of select=""s1:case_fixdateonceagreed/text()"" />
                  </ns9:fixdateonceagreed>
                </xsl:if>
              </xsl:if>
              <xsl:if test=""s1:case_ScheduledDate"">
                <xsl:variable name=""var:v105"" select=""string(s1:case_ScheduledDate/@xsi:nil) = 'true'"" />
                <xsl:if test=""string($var:v105)='true'"">
                  <ns9:ScheduledDate>
                    <xsl:attribute name=""xsi:nil"">
                      <xsl:value-of select=""'true'"" />
                    </xsl:attribute>
                  </ns9:ScheduledDate>
                </xsl:if>
                <xsl:if test=""string($var:v105)='false'"">
                  <ns9:ScheduledDate>
                    <xsl:value-of select=""s1:case_ScheduledDate/text()"" />
                  </ns9:ScheduledDate>
                </xsl:if>
              </xsl:if>
              <xsl:if test=""s1:case_followonreason"">
                <xsl:variable name=""var:v106"" select=""string(s1:case_followonreason/@xsi:nil) = 'true'"" />
                <xsl:if test=""string($var:v106)='true'"">
                  <ns9:FollowUpNote>
                    <xsl:attribute name=""xsi:nil"">
                      <xsl:value-of select=""'true'"" />
                    </xsl:attribute>
                  </ns9:FollowUpNote>
                </xsl:if>
                <xsl:if test=""string($var:v106)='false'"">
                  <ns9:FollowUpNote>
                    <xsl:value-of select=""s1:case_followonreason/text()"" />
                  </ns9:FollowUpNote>
                </xsl:if>
              </xsl:if>
              <xsl:if test=""s1:case_primarycaseid"">
                <xsl:variable name=""var:v107"" select=""string(s1:case_primarycaseid/@xsi:nil) = 'true'"" />
                <xsl:if test=""string($var:v107)='true'"">
                  <ns9:MasterHelpeskCaseId>
                    <xsl:attribute name=""xsi:nil"">
                      <xsl:value-of select=""'true'"" />
                    </xsl:attribute>
                  </ns9:MasterHelpeskCaseId>
                </xsl:if>
                <xsl:if test=""string($var:v107)='false'"">
                  <ns9:MasterHelpeskCaseId>
                    <xsl:value-of select=""s1:case_primarycaseid/text()"" />
                  </ns9:MasterHelpeskCaseId>
                </xsl:if>
              </xsl:if>
              <xsl:if test=""s1:case_comp_NextMilestone"">
                <xsl:variable name=""var:v108"" select=""string(s1:case_comp_NextMilestone/@xsi:nil) = 'true'"" />
                <xsl:if test=""string($var:v108)='true'"">
                  <ns9:NextMilestone>
                    <xsl:attribute name=""xsi:nil"">
                      <xsl:value-of select=""'true'"" />
                    </xsl:attribute>
                  </ns9:NextMilestone>
                </xsl:if>
                <xsl:if test=""string($var:v108)='false'"">
                  <ns9:NextMilestone>
                    <xsl:value-of select=""s1:case_comp_NextMilestone/text()"" />
                  </ns9:NextMilestone>
                </xsl:if>
              </xsl:if>
              <xsl:if test=""s1:case_comp_NextMilestoneDate"">
                <xsl:variable name=""var:v109"" select=""string(s1:case_comp_NextMilestoneDate/@xsi:nil) = 'true'"" />
                <xsl:if test=""string($var:v109)='true'"">
                  <ns9:NextMilestoneTS>
                    <xsl:attribute name=""xsi:nil"">
                      <xsl:value-of select=""'true'"" />
                    </xsl:attribute>
                  </ns9:NextMilestoneTS>
                </xsl:if>
                <xsl:if test=""string($var:v109)='false'"">
                  <ns9:NextMilestoneTS>
                    <xsl:value-of select=""s1:case_comp_NextMilestoneDate/text()"" />
                  </ns9:NextMilestoneTS>
                </xsl:if>
              </xsl:if>
              <xsl:if test=""s1:case_comp_NextMilestoneAmberDate"">
                <xsl:variable name=""var:v110"" select=""string(s1:case_comp_NextMilestoneAmberDate/@xsi:nil) = 'true'"" />
                <xsl:if test=""string($var:v110)='true'"">
                  <ns9:NextMilestoneWarningTS>
                    <xsl:attribute name=""xsi:nil"">
                      <xsl:value-of select=""'true'"" />
                    </xsl:attribute>
                  </ns9:NextMilestoneWarningTS>
                </xsl:if>
                <xsl:if test=""string($var:v110)='false'"">
                  <ns9:NextMilestoneWarningTS>
                    <xsl:value-of select=""s1:case_comp_NextMilestoneAmberDate/text()"" />
                  </ns9:NextMilestoneWarningTS>
                </xsl:if>
              </xsl:if>
              <xsl:if test=""s1:case_foreignsysid"">
                <xsl:variable name=""var:v111"" select=""string(s1:case_foreignsysid/@xsi:nil) = 'true'"" />
                <xsl:if test=""string($var:v111)='true'"">
                  <ns9:TargetSystemId>
                    <xsl:attribute name=""xsi:nil"">
                      <xsl:value-of select=""'true'"" />
                    </xsl:attribute>
                  </ns9:TargetSystemId>
                </xsl:if>
                <xsl:if test=""string($var:v111)='false'"">
                  <ns9:TargetSystemId>
                    <xsl:value-of select=""s1:case_foreignsysid/text()"" />
                  </ns9:TargetSystemId>
                </xsl:if>
              </xsl:if>
              <xsl:if test=""s1:case_foreignsysname"">
                <ns9:TargetSystem>
                  <xsl:value-of select=""s1:case_foreignsysname/text()"" />
                </ns9:TargetSystem>
              </xsl:if>
              <xsl:if test=""s1:case_rejectionreason"">
                <xsl:variable name=""var:v112"" select=""string(s1:case_rejectionreason/@xsi:nil) = 'true'"" />
                <xsl:if test=""string($var:v112)='true'"">
                  <ns9:RejectionNote>
                    <xsl:attribute name=""xsi:nil"">
                      <xsl:value-of select=""'true'"" />
                    </xsl:attribute>
                  </ns9:RejectionNote>
                </xsl:if>
                <xsl:if test=""string($var:v112)='false'"">
                  <ns9:RejectionNote>
                    <xsl:value-of select=""s1:case_rejectionreason/text()"" />
                  </ns9:RejectionNote>
                </xsl:if>
              </xsl:if>
              <xsl:if test=""s1:case_CustomerCostCentre"">
                <xsl:variable name=""var:v113"" select=""string(s1:case_CustomerCostCentre/@xsi:nil) = 'true'"" />
                <xsl:if test=""string($var:v113)='true'"">
                  <ns9:CustomerCostCentre>
                    <xsl:attribute name=""xsi:nil"">
                      <xsl:value-of select=""'true'"" />
                    </xsl:attribute>
                  </ns9:CustomerCostCentre>
                </xsl:if>
                <xsl:if test=""string($var:v113)='false'"">
                  <ns9:CustomerCostCentre>
                    <xsl:value-of select=""s1:case_CustomerCostCentre/text()"" />
                  </ns9:CustomerCostCentre>
                </xsl:if>
              </xsl:if>
              <xsl:if test=""s1:Case_QuestionSet"">
                <xsl:variable name=""var:v114"" select=""string(s1:Case_QuestionSet/@xsi:nil) = 'true'"" />
                <xsl:if test=""string($var:v114)='true'"">
                  <ns9:CustomerQuestions>
                    <xsl:attribute name=""xsi:nil"">
                      <xsl:value-of select=""'true'"" />
                    </xsl:attribute>
                  </ns9:CustomerQuestions>
                </xsl:if>
                <xsl:if test=""string($var:v114)='false'"">
                  <ns9:CustomerQuestions>
                    <xsl:value-of select=""s1:Case_QuestionSet/text()"" />
                  </ns9:CustomerQuestions>
                </xsl:if>
              </xsl:if>
              <ns10:Customer>
                <xsl:if test=""s1:Comp_CompanyId"">
                  <xsl:attribute name=""Id"">
                    <xsl:value-of select=""s1:Comp_CompanyId/text()"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:if test=""s1:Comp_Name"">
                  <Name>
                    <xsl:value-of select=""s1:Comp_Name/text()"" />
                  </Name>
                </xsl:if>
                <xsl:if test=""s1:Comp_Type"">
                  <xsl:variable name=""var:v115"" select=""string(s1:Comp_Type/@xsi:nil) = 'true'"" />
                  <xsl:if test=""string($var:v115)='true'"">
                    <CustomerType>
                      <xsl:attribute name=""xsi:nil"">
                        <xsl:value-of select=""'true'"" />
                      </xsl:attribute>
                    </CustomerType>
                  </xsl:if>
                  <xsl:if test=""string($var:v115)='false'"">
                    <CustomerType>
                      <xsl:value-of select=""s1:Comp_Type/text()"" />
                    </CustomerType>
                  </xsl:if>
                </xsl:if>
                <xsl:if test=""s1:Comp_PrimaryPersonId"">
                  <xsl:variable name=""var:v116"" select=""string(s1:Comp_PrimaryPersonId/@xsi:nil) = 'true'"" />
                  <xsl:if test=""string($var:v116)='true'"">
                    <PersonId>
                      <xsl:attribute name=""xsi:nil"">
                        <xsl:value-of select=""'true'"" />
                      </xsl:attribute>
                    </PersonId>
                  </xsl:if>
                  <xsl:if test=""string($var:v116)='false'"">
                    <PersonId>
                      <xsl:value-of select=""s1:Comp_PrimaryPersonId/text()"" />
                    </PersonId>
                  </xsl:if>
                </xsl:if>
                <xsl:if test=""s1:Comp_PrimaryAddressId"">
                  <xsl:variable name=""var:v117"" select=""string(s1:Comp_PrimaryAddressId/@xsi:nil) = 'true'"" />
                  <xsl:if test=""string($var:v117)='true'"">
                    <AddressId>
                      <xsl:attribute name=""xsi:nil"">
                        <xsl:value-of select=""'true'"" />
                      </xsl:attribute>
                    </AddressId>
                  </xsl:if>
                  <xsl:if test=""string($var:v117)='false'"">
                    <AddressId>
                      <xsl:value-of select=""s1:Comp_PrimaryAddressId/text()"" />
                    </AddressId>
                  </xsl:if>
                </xsl:if>
                <xsl:if test=""s1:Customer_Division_Name"">
                  <xsl:variable name=""var:v118"" select=""string(s1:Customer_Division_Name/@xsi:nil) = 'true'"" />
                  <xsl:if test=""string($var:v118)='true'"">
                    <Division>
                      <xsl:attribute name=""xsi:nil"">
                        <xsl:value-of select=""'true'"" />
                      </xsl:attribute>
                    </Division>
                  </xsl:if>
                  <xsl:if test=""string($var:v118)='false'"">
                    <Division>
                      <xsl:value-of select=""s1:Customer_Division_Name/text()"" />
                    </Division>
                  </xsl:if>
                </xsl:if>
              </ns10:Customer>
              <ns4:Person>
                <xsl:if test=""s1:Pers_PersonId"">
                  <xsl:attribute name=""Id"">
                    <xsl:value-of select=""s1:Pers_PersonId/text()"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:if test=""s1:Pers_CompanyId"">
                  <CompanyId>
                    <xsl:value-of select=""s1:Pers_CompanyId/text()"" />
                  </CompanyId>
                </xsl:if>
                <xsl:if test=""s1:Pers_PrimaryAddressId"">
                  <xsl:variable name=""var:v119"" select=""string(s1:Pers_PrimaryAddressId/@xsi:nil) = 'true'"" />
                  <xsl:if test=""string($var:v119)='true'"">
                    <AddressId>
                      <xsl:attribute name=""xsi:nil"">
                        <xsl:value-of select=""'true'"" />
                      </xsl:attribute>
                    </AddressId>
                  </xsl:if>
                  <xsl:if test=""string($var:v119)='false'"">
                    <AddressId>
                      <xsl:value-of select=""s1:Pers_PrimaryAddressId/text()"" />
                    </AddressId>
                  </xsl:if>
                </xsl:if>
                <xsl:if test=""s1:Pers_PrimaryUserId"">
                  <xsl:variable name=""var:v120"" select=""string(s1:Pers_PrimaryUserId/@xsi:nil) = 'true'"" />
                  <xsl:if test=""string($var:v120)='true'"">
                    <UserId>
                      <xsl:attribute name=""xsi:nil"">
                        <xsl:value-of select=""'true'"" />
                      </xsl:attribute>
                    </UserId>
                  </xsl:if>
                  <xsl:if test=""string($var:v120)='false'"">
                    <UserId>
                      <xsl:value-of select=""s1:Pers_PrimaryUserId/text()"" />
                    </UserId>
                  </xsl:if>
                </xsl:if>
                <xsl:if test=""s1:Pers_Salutation"">
                  <xsl:variable name=""var:v121"" select=""string(s1:Pers_Salutation/@xsi:nil) = 'true'"" />
                  <xsl:if test=""string($var:v121)='true'"">
                    <Salutation>
                      <xsl:attribute name=""xsi:nil"">
                        <xsl:value-of select=""'true'"" />
                      </xsl:attribute>
                    </Salutation>
                  </xsl:if>
                  <xsl:if test=""string($var:v121)='false'"">
                    <Salutation>
                      <xsl:value-of select=""s1:Pers_Salutation/text()"" />
                    </Salutation>
                  </xsl:if>
                </xsl:if>
                <xsl:if test=""s1:Pers_FirstName"">
                  <xsl:variable name=""var:v122"" select=""string(s1:Pers_FirstName/@xsi:nil) = 'true'"" />
                  <xsl:if test=""string($var:v122)='true'"">
                    <FirstName>
                      <xsl:attribute name=""xsi:nil"">
                        <xsl:value-of select=""'true'"" />
                      </xsl:attribute>
                    </FirstName>
                  </xsl:if>
                  <xsl:if test=""string($var:v122)='false'"">
                    <FirstName>
                      <xsl:value-of select=""s1:Pers_FirstName/text()"" />
                    </FirstName>
                  </xsl:if>
                </xsl:if>
                <xsl:if test=""s1:Pers_LastName"">
                  <xsl:variable name=""var:v123"" select=""string(s1:Pers_LastName/@xsi:nil) = 'true'"" />
                  <xsl:if test=""string($var:v123)='true'"">
                    <LastName>
                      <xsl:attribute name=""xsi:nil"">
                        <xsl:value-of select=""'true'"" />
                      </xsl:attribute>
                    </LastName>
                  </xsl:if>
                  <xsl:if test=""string($var:v123)='false'"">
                    <LastName>
                      <xsl:value-of select=""s1:Pers_LastName/text()"" />
                    </LastName>
                  </xsl:if>
                </xsl:if>
                <xsl:if test=""s1:Pers_MiddleName"">
                  <xsl:variable name=""var:v124"" select=""string(s1:Pers_MiddleName/@xsi:nil) = 'true'"" />
                  <xsl:if test=""string($var:v124)='true'"">
                    <MiddleName>
                      <xsl:attribute name=""xsi:nil"">
                        <xsl:value-of select=""'true'"" />
                      </xsl:attribute>
                    </MiddleName>
                  </xsl:if>
                  <xsl:if test=""string($var:v124)='false'"">
                    <MiddleName>
                      <xsl:value-of select=""s1:Pers_MiddleName/text()"" />
                    </MiddleName>
                  </xsl:if>
                </xsl:if>
                <xsl:if test=""s1:Pers_Suffix"">
                  <xsl:variable name=""var:v125"" select=""string(s1:Pers_Suffix/@xsi:nil) = 'true'"" />
                  <xsl:if test=""string($var:v125)='true'"">
                    <suffix>
                      <xsl:attribute name=""xsi:nil"">
                        <xsl:value-of select=""'true'"" />
                      </xsl:attribute>
                    </suffix>
                  </xsl:if>
                  <xsl:if test=""string($var:v125)='false'"">
                    <suffix>
                      <xsl:value-of select=""s1:Pers_Suffix/text()"" />
                    </suffix>
                  </xsl:if>
                </xsl:if>
                <xsl:if test=""s1:Pers_Gender"">
                  <xsl:variable name=""var:v126"" select=""string(s1:Pers_Gender/@xsi:nil) = 'true'"" />
                  <xsl:if test=""string($var:v126)='true'"">
                    <gender>
                      <xsl:attribute name=""xsi:nil"">
                        <xsl:value-of select=""'true'"" />
                      </xsl:attribute>
                    </gender>
                  </xsl:if>
                  <xsl:if test=""string($var:v126)='false'"">
                    <gender>
                      <xsl:value-of select=""s1:Pers_Gender/text()"" />
                    </gender>
                  </xsl:if>
                </xsl:if>
                <xsl:if test=""s1:Pers_Title"">
                  <xsl:variable name=""var:v127"" select=""string(s1:Pers_Title/@xsi:nil) = 'true'"" />
                  <xsl:if test=""string($var:v127)='true'"">
                    <title>
                      <xsl:attribute name=""xsi:nil"">
                        <xsl:value-of select=""'true'"" />
                      </xsl:attribute>
                    </title>
                  </xsl:if>
                  <xsl:if test=""string($var:v127)='false'"">
                    <title>
                      <xsl:value-of select=""s1:Pers_Title/text()"" />
                    </title>
                  </xsl:if>
                </xsl:if>
                <xsl:if test=""s1:Pers_Department"">
                  <xsl:variable name=""var:v128"" select=""string(s1:Pers_Department/@xsi:nil) = 'true'"" />
                  <xsl:if test=""string($var:v128)='true'"">
                    <department>
                      <xsl:attribute name=""xsi:nil"">
                        <xsl:value-of select=""'true'"" />
                      </xsl:attribute>
                    </department>
                  </xsl:if>
                  <xsl:if test=""string($var:v128)='false'"">
                    <department>
                      <xsl:value-of select=""s1:Pers_Department/text()"" />
                    </department>
                  </xsl:if>
                </xsl:if>
                <xsl:if test=""s1:pers_primarylocationid"">
                  <xsl:variable name=""var:v129"" select=""string(s1:pers_primarylocationid/@xsi:nil) = 'true'"" />
                  <xsl:if test=""string($var:v129)='true'"">
                    <locationid>
                      <xsl:attribute name=""xsi:nil"">
                        <xsl:value-of select=""'true'"" />
                      </xsl:attribute>
                    </locationid>
                  </xsl:if>
                  <xsl:if test=""string($var:v129)='false'"">
                    <locationid>
                      <xsl:value-of select=""s1:pers_primarylocationid/text()"" />
                    </locationid>
                  </xsl:if>
                </xsl:if>
                <xsl:if test=""s1:pers_preferredcontactmethod"">
                  <xsl:variable name=""var:v130"" select=""string(s1:pers_preferredcontactmethod/@xsi:nil) = 'true'"" />
                  <xsl:if test=""string($var:v130)='true'"">
                    <contactmethod>
                      <xsl:attribute name=""xsi:nil"">
                        <xsl:value-of select=""'true'"" />
                      </xsl:attribute>
                    </contactmethod>
                  </xsl:if>
                  <xsl:if test=""string($var:v130)='false'"">
                    <contactmethod>
                      <xsl:value-of select=""s1:pers_preferredcontactmethod/text()"" />
                    </contactmethod>
                  </xsl:if>
                </xsl:if>
                <xsl:if test=""s1:Pers_PhoneNumber"">
                  <xsl:variable name=""var:v131"" select=""string(s1:Pers_PhoneNumber/@xsi:nil) = 'true'"" />
                  <xsl:if test=""string($var:v131)='true'"">
                    <PhoneNumber>
                      <xsl:attribute name=""xsi:nil"">
                        <xsl:value-of select=""'true'"" />
                      </xsl:attribute>
                    </PhoneNumber>
                  </xsl:if>
                  <xsl:if test=""string($var:v131)='false'"">
                    <PhoneNumber>
                      <xsl:value-of select=""s1:Pers_PhoneNumber/text()"" />
                    </PhoneNumber>
                  </xsl:if>
                </xsl:if>
                <xsl:if test=""s1:Pers_EmailAddress"">
                  <xsl:variable name=""var:v132"" select=""string(s1:Pers_EmailAddress/@xsi:nil) = 'true'"" />
                  <xsl:if test=""string($var:v132)='true'"">
                    <EmailAddress>
                      <xsl:attribute name=""xsi:nil"">
                        <xsl:value-of select=""'true'"" />
                      </xsl:attribute>
                    </EmailAddress>
                  </xsl:if>
                  <xsl:if test=""string($var:v132)='false'"">
                    <EmailAddress>
                      <xsl:value-of select=""s1:Pers_EmailAddress/text()"" />
                    </EmailAddress>
                  </xsl:if>
                </xsl:if>
                <xsl:if test=""s1:Pers_FaxNumber"">
                  <xsl:variable name=""var:v133"" select=""string(s1:Pers_FaxNumber/@xsi:nil) = 'true'"" />
                  <xsl:if test=""string($var:v133)='true'"">
                    <FaxNumber>
                      <xsl:attribute name=""xsi:nil"">
                        <xsl:value-of select=""'true'"" />
                      </xsl:attribute>
                    </FaxNumber>
                  </xsl:if>
                  <xsl:if test=""string($var:v133)='false'"">
                    <FaxNumber>
                      <xsl:value-of select=""s1:Pers_FaxNumber/text()"" />
                    </FaxNumber>
                  </xsl:if>
                </xsl:if>
              </ns4:Person>
              <ns5:Location>
                <xsl:if test=""s1:AdLi_AddressLinkId"">
                  <xsl:attribute name=""linkid"">
                    <xsl:value-of select=""s1:AdLi_AddressLinkId/text()"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:if test=""s1:AdLi_CompanyID"">
                  <linkcompany>
                    <xsl:value-of select=""s1:AdLi_CompanyID/text()"" />
                  </linkcompany>
                </xsl:if>
                <xsl:if test=""s1:AdLi_PersonID"">
                  <xsl:variable name=""var:v134"" select=""string(s1:AdLi_PersonID/@xsi:nil) = 'true'"" />
                  <xsl:if test=""string($var:v134)='true'"">
                    <linkperson>
                      <xsl:attribute name=""xsi:nil"">
                        <xsl:value-of select=""'true'"" />
                      </xsl:attribute>
                    </linkperson>
                  </xsl:if>
                  <xsl:if test=""string($var:v134)='false'"">
                    <linkperson>
                      <xsl:value-of select=""s1:AdLi_PersonID/text()"" />
                    </linkperson>
                  </xsl:if>
                </xsl:if>
                <xsl:if test=""s1:AdLi_Type"">
                  <xsl:variable name=""var:v135"" select=""string(s1:AdLi_Type/@xsi:nil) = 'true'"" />
                  <xsl:if test=""string($var:v135)='true'"">
                    <linktype>
                      <xsl:attribute name=""xsi:nil"">
                        <xsl:value-of select=""'true'"" />
                      </xsl:attribute>
                    </linktype>
                  </xsl:if>
                  <xsl:if test=""string($var:v135)='false'"">
                    <linktype>
                      <xsl:value-of select=""s1:AdLi_Type/text()"" />
                    </linktype>
                  </xsl:if>
                </xsl:if>
                <xsl:if test=""s1:adli_clientdivisionid"">
                  <xsl:variable name=""var:v136"" select=""string(s1:adli_clientdivisionid/@xsi:nil) = 'true'"" />
                  <xsl:if test=""string($var:v136)='true'"">
                    <linkdivisionid>
                      <xsl:attribute name=""xsi:nil"">
                        <xsl:value-of select=""'true'"" />
                      </xsl:attribute>
                    </linkdivisionid>
                  </xsl:if>
                  <xsl:if test=""string($var:v136)='false'"">
                    <linkdivisionid>
                      <xsl:value-of select=""s1:adli_clientdivisionid/text()"" />
                    </linkdivisionid>
                  </xsl:if>
                </xsl:if>
                <xsl:if test=""s1:adli_clientregionid"">
                  <xsl:variable name=""var:v137"" select=""string(s1:adli_clientregionid/@xsi:nil) = 'true'"" />
                  <xsl:if test=""string($var:v137)='true'"">
                    <linkregionid>
                      <xsl:attribute name=""xsi:nil"">
                        <xsl:value-of select=""'true'"" />
                      </xsl:attribute>
                    </linkregionid>
                  </xsl:if>
                  <xsl:if test=""string($var:v137)='false'"">
                    <linkregionid>
                      <xsl:value-of select=""s1:adli_clientregionid/text()"" />
                    </linkregionid>
                  </xsl:if>
                </xsl:if>
                <xsl:if test=""s1:adli_AreaId"">
                  <xsl:variable name=""var:v138"" select=""string(s1:adli_AreaId/@xsi:nil) = 'true'"" />
                  <xsl:if test=""string($var:v138)='true'"">
                    <linkareaid>
                      <xsl:attribute name=""xsi:nil"">
                        <xsl:value-of select=""'true'"" />
                      </xsl:attribute>
                    </linkareaid>
                  </xsl:if>
                  <xsl:if test=""string($var:v138)='false'"">
                    <linkareaid>
                      <xsl:value-of select=""s1:adli_AreaId/text()"" />
                    </linkareaid>
                  </xsl:if>
                </xsl:if>
                <xsl:if test=""s1:adli_startdate"">
                  <xsl:variable name=""var:v139"" select=""string(s1:adli_startdate/@xsi:nil) = 'true'"" />
                  <xsl:if test=""string($var:v139)='true'"">
                    <linkstart>
                      <xsl:attribute name=""xsi:nil"">
                        <xsl:value-of select=""'true'"" />
                      </xsl:attribute>
                    </linkstart>
                  </xsl:if>
                  <xsl:if test=""string($var:v139)='false'"">
                    <linkstart>
                      <xsl:value-of select=""s1:adli_startdate/text()"" />
                    </linkstart>
                  </xsl:if>
                </xsl:if>
                <xsl:if test=""s1:adli_enddate"">
                  <xsl:variable name=""var:v140"" select=""string(s1:adli_enddate/@xsi:nil) = 'true'"" />
                  <xsl:if test=""string($var:v140)='true'"">
                    <linkend>
                      <xsl:attribute name=""xsi:nil"">
                        <xsl:value-of select=""'true'"" />
                      </xsl:attribute>
                    </linkend>
                  </xsl:if>
                  <xsl:if test=""string($var:v140)='false'"">
                    <linkend>
                      <xsl:value-of select=""s1:adli_enddate/text()"" />
                    </linkend>
                  </xsl:if>
                </xsl:if>
                <xsl:if test=""s1:adli_KnownAs"">
                  <xsl:variable name=""var:v141"" select=""string(s1:adli_KnownAs/@xsi:nil) = 'true'"" />
                  <xsl:if test=""string($var:v141)='true'"">
                    <linkcn>
                      <xsl:attribute name=""xsi:nil"">
                        <xsl:value-of select=""'true'"" />
                      </xsl:attribute>
                    </linkcn>
                  </xsl:if>
                  <xsl:if test=""string($var:v141)='false'"">
                    <linkcn>
                      <xsl:value-of select=""s1:adli_KnownAs/text()"" />
                    </linkcn>
                  </xsl:if>
                </xsl:if>
                <xsl:if test=""s1:adli_ClientPropertyId"">
                  <xsl:variable name=""var:v142"" select=""string(s1:adli_ClientPropertyId/@xsi:nil) = 'true'"" />
                  <xsl:if test=""string($var:v142)='true'"">
                    <linkpropertyid>
                      <xsl:attribute name=""xsi:nil"">
                        <xsl:value-of select=""'true'"" />
                      </xsl:attribute>
                    </linkpropertyid>
                  </xsl:if>
                  <xsl:if test=""string($var:v142)='false'"">
                    <linkpropertyid>
                      <xsl:value-of select=""s1:adli_ClientPropertyId/text()"" />
                    </linkpropertyid>
                  </xsl:if>
                </xsl:if>
                <xsl:if test=""s1:addr_SiteID"">
                  <xsl:variable name=""var:v143"" select=""string(s1:addr_SiteID/@xsi:nil) = 'true'"" />
                  <xsl:if test=""string($var:v143)='true'"">
                    <linkMitiePropertyCode>
                      <xsl:attribute name=""xsi:nil"">
                        <xsl:value-of select=""'true'"" />
                      </xsl:attribute>
                    </linkMitiePropertyCode>
                  </xsl:if>
                  <xsl:if test=""string($var:v143)='false'"">
                    <linkMitiePropertyCode>
                      <xsl:value-of select=""s1:addr_SiteID/text()"" />
                    </linkMitiePropertyCode>
                  </xsl:if>
                </xsl:if>
                <xsl:if test=""s1:adli_CustomerSiteCode"">
                  <xsl:variable name=""var:v144"" select=""string(s1:adli_CustomerSiteCode/@xsi:nil) = 'true'"" />
                  <xsl:if test=""string($var:v144)='true'"">
                    <linkClientPropertyCode>
                      <xsl:attribute name=""xsi:nil"">
                        <xsl:value-of select=""'true'"" />
                      </xsl:attribute>
                    </linkClientPropertyCode>
                  </xsl:if>
                  <xsl:if test=""string($var:v144)='false'"">
                    <linkClientPropertyCode>
                      <xsl:value-of select=""s1:adli_CustomerSiteCode/text()"" />
                    </linkClientPropertyCode>
                  </xsl:if>
                </xsl:if>
                <xsl:if test=""s1:Customer_Region_Name"">
                  <xsl:variable name=""var:v145"" select=""string(s1:Customer_Region_Name/@xsi:nil) = 'true'"" />
                  <xsl:if test=""string($var:v145)='true'"">
                    <linkRegionName>
                      <xsl:attribute name=""xsi:nil"">
                        <xsl:value-of select=""'true'"" />
                      </xsl:attribute>
                    </linkRegionName>
                  </xsl:if>
                  <xsl:if test=""string($var:v145)='false'"">
                    <linkRegionName>
                      <xsl:value-of select=""s1:Customer_Region_Name/text()"" />
                    </linkRegionName>
                  </xsl:if>
                </xsl:if>
                <ns8:Address>
                  <xsl:if test=""s1:Addr_AddressId"">
                    <xsl:attribute name=""siteid"">
                      <xsl:value-of select=""s1:Addr_AddressId/text()"" />
                    </xsl:attribute>
                  </xsl:if>
                  <xsl:if test=""s1:Addr_Address1"">
                    <siteAddress1>
                      <xsl:value-of select=""s1:Addr_Address1/text()"" />
                    </siteAddress1>
                  </xsl:if>
                  <xsl:if test=""s1:Addr_Address2"">
                    <xsl:variable name=""var:v146"" select=""string(s1:Addr_Address2/@xsi:nil) = 'true'"" />
                    <xsl:if test=""string($var:v146)='true'"">
                      <siteAddress2>
                        <xsl:attribute name=""xsi:nil"">
                          <xsl:value-of select=""'true'"" />
                        </xsl:attribute>
                      </siteAddress2>
                    </xsl:if>
                    <xsl:if test=""string($var:v146)='false'"">
                      <siteAddress2>
                        <xsl:value-of select=""s1:Addr_Address2/text()"" />
                      </siteAddress2>
                    </xsl:if>
                  </xsl:if>
                  <xsl:if test=""s1:Addr_Address3"">
                    <xsl:variable name=""var:v147"" select=""string(s1:Addr_Address3/@xsi:nil) = 'true'"" />
                    <xsl:if test=""string($var:v147)='true'"">
                      <siteAddress3>
                        <xsl:attribute name=""xsi:nil"">
                          <xsl:value-of select=""'true'"" />
                        </xsl:attribute>
                      </siteAddress3>
                    </xsl:if>
                    <xsl:if test=""string($var:v147)='false'"">
                      <siteAddress3>
                        <xsl:value-of select=""s1:Addr_Address3/text()"" />
                      </siteAddress3>
                    </xsl:if>
                  </xsl:if>
                  <xsl:if test=""s1:Addr_Address4"">
                    <xsl:variable name=""var:v148"" select=""string(s1:Addr_Address4/@xsi:nil) = 'true'"" />
                    <xsl:if test=""string($var:v148)='true'"">
                      <siteAddress4>
                        <xsl:attribute name=""xsi:nil"">
                          <xsl:value-of select=""'true'"" />
                        </xsl:attribute>
                      </siteAddress4>
                    </xsl:if>
                    <xsl:if test=""string($var:v148)='false'"">
                      <siteAddress4>
                        <xsl:value-of select=""s1:Addr_Address4/text()"" />
                      </siteAddress4>
                    </xsl:if>
                  </xsl:if>
                  <xsl:if test=""s1:Addr_Address5"">
                    <xsl:variable name=""var:v149"" select=""string(s1:Addr_Address5/@xsi:nil) = 'true'"" />
                    <xsl:if test=""string($var:v149)='true'"">
                      <siteAddress5>
                        <xsl:attribute name=""xsi:nil"">
                          <xsl:value-of select=""'true'"" />
                        </xsl:attribute>
                      </siteAddress5>
                    </xsl:if>
                    <xsl:if test=""string($var:v149)='false'"">
                      <siteAddress5>
                        <xsl:value-of select=""s1:Addr_Address5/text()"" />
                      </siteAddress5>
                    </xsl:if>
                  </xsl:if>
                  <xsl:if test=""s1:Addr_City"">
                    <xsl:variable name=""var:v150"" select=""string(s1:Addr_City/@xsi:nil) = 'true'"" />
                    <xsl:if test=""string($var:v150)='true'"">
                      <siteCity>
                        <xsl:attribute name=""xsi:nil"">
                          <xsl:value-of select=""'true'"" />
                        </xsl:attribute>
                      </siteCity>
                    </xsl:if>
                    <xsl:if test=""string($var:v150)='false'"">
                      <siteCity>
                        <xsl:value-of select=""s1:Addr_City/text()"" />
                      </siteCity>
                    </xsl:if>
                  </xsl:if>
                  <xsl:if test=""s1:Addr_State"">
                    <xsl:variable name=""var:v151"" select=""string(s1:Addr_State/@xsi:nil) = 'true'"" />
                    <xsl:if test=""string($var:v151)='true'"">
                      <siteState>
                        <xsl:attribute name=""xsi:nil"">
                          <xsl:value-of select=""'true'"" />
                        </xsl:attribute>
                      </siteState>
                    </xsl:if>
                    <xsl:if test=""string($var:v151)='false'"">
                      <siteState>
                        <xsl:value-of select=""s1:Addr_State/text()"" />
                      </siteState>
                    </xsl:if>
                  </xsl:if>
                  <xsl:if test=""s1:Addr_PostCode"">
                    <xsl:variable name=""var:v152"" select=""string(s1:Addr_PostCode/@xsi:nil) = 'true'"" />
                    <xsl:if test=""string($var:v152)='true'"">
                      <sitePostCode>
                        <xsl:attribute name=""xsi:nil"">
                          <xsl:value-of select=""'true'"" />
                        </xsl:attribute>
                      </sitePostCode>
                    </xsl:if>
                    <xsl:if test=""string($var:v152)='false'"">
                      <sitePostCode>
                        <xsl:value-of select=""s1:Addr_PostCode/text()"" />
                      </sitePostCode>
                    </xsl:if>
                  </xsl:if>
                  <xsl:if test=""s1:addr_SiteName"">
                    <xsl:variable name=""var:v153"" select=""string(s1:addr_SiteName/@xsi:nil) = 'true'"" />
                    <xsl:if test=""string($var:v153)='true'"">
                      <siteSiteName>
                        <xsl:attribute name=""xsi:nil"">
                          <xsl:value-of select=""'true'"" />
                        </xsl:attribute>
                      </siteSiteName>
                    </xsl:if>
                    <xsl:if test=""string($var:v153)='false'"">
                      <siteSiteName>
                        <xsl:value-of select=""s1:addr_SiteName/text()"" />
                      </siteSiteName>
                    </xsl:if>
                  </xsl:if>
                  <xsl:if test=""s1:addr_SiteID"">
                    <xsl:variable name=""var:v154"" select=""string(s1:addr_SiteID/@xsi:nil) = 'true'"" />
                    <xsl:if test=""string($var:v154)='true'"">
                      <siteSiteID>
                        <xsl:attribute name=""xsi:nil"">
                          <xsl:value-of select=""'true'"" />
                        </xsl:attribute>
                      </siteSiteID>
                    </xsl:if>
                    <xsl:if test=""string($var:v154)='false'"">
                      <siteSiteID>
                        <xsl:value-of select=""s1:addr_SiteID/text()"" />
                      </siteSiteID>
                    </xsl:if>
                  </xsl:if>
                  <xsl:if test=""s1:addr_SecondaryClientSiteID"">
                    <xsl:variable name=""var:v155"" select=""string(s1:addr_SecondaryClientSiteID/@xsi:nil) = 'true'"" />
                    <xsl:if test=""string($var:v155)='true'"">
                      <siteSecondaryClientSiteID>
                        <xsl:attribute name=""xsi:nil"">
                          <xsl:value-of select=""'true'"" />
                        </xsl:attribute>
                      </siteSecondaryClientSiteID>
                    </xsl:if>
                    <xsl:if test=""string($var:v155)='false'"">
                      <siteSecondaryClientSiteID>
                        <xsl:value-of select=""s1:addr_SecondaryClientSiteID/text()"" />
                      </siteSecondaryClientSiteID>
                    </xsl:if>
                  </xsl:if>
                  <xsl:if test=""s1:addr_clientdivisionid"">
                    <xsl:variable name=""var:v156"" select=""string(s1:addr_clientdivisionid/@xsi:nil) = 'true'"" />
                    <xsl:if test=""string($var:v156)='true'"">
                      <siteDivisionid>
                        <xsl:attribute name=""xsi:nil"">
                          <xsl:value-of select=""'true'"" />
                        </xsl:attribute>
                      </siteDivisionid>
                    </xsl:if>
                    <xsl:if test=""string($var:v156)='false'"">
                      <siteDivisionid>
                        <xsl:value-of select=""s1:addr_clientdivisionid/text()"" />
                      </siteDivisionid>
                    </xsl:if>
                  </xsl:if>
                  <xsl:if test=""s1:addr_clientregionid"">
                    <xsl:variable name=""var:v157"" select=""string(s1:addr_clientregionid/@xsi:nil) = 'true'"" />
                    <xsl:if test=""string($var:v157)='true'"">
                      <siteRegionid>
                        <xsl:attribute name=""xsi:nil"">
                          <xsl:value-of select=""'true'"" />
                        </xsl:attribute>
                      </siteRegionid>
                    </xsl:if>
                    <xsl:if test=""string($var:v157)='false'"">
                      <siteRegionid>
                        <xsl:value-of select=""s1:addr_clientregionid/text()"" />
                      </siteRegionid>
                    </xsl:if>
                  </xsl:if>
                  <xsl:if test=""s1:addr_latitude"">
                    <xsl:variable name=""var:v158"" select=""string(s1:addr_latitude/@xsi:nil) = 'true'"" />
                    <xsl:if test=""string($var:v158)='true'"">
                      <siteLatitude>
                        <xsl:attribute name=""xsi:nil"">
                          <xsl:value-of select=""'true'"" />
                        </xsl:attribute>
                      </siteLatitude>
                    </xsl:if>
                    <xsl:if test=""string($var:v158)='false'"">
                      <siteLatitude>
                        <xsl:value-of select=""s1:addr_latitude/text()"" />
                      </siteLatitude>
                    </xsl:if>
                  </xsl:if>
                  <xsl:if test=""s1:addr_longitude"">
                    <xsl:variable name=""var:v159"" select=""string(s1:addr_longitude/@xsi:nil) = 'true'"" />
                    <xsl:if test=""string($var:v159)='true'"">
                      <siteLongitude>
                        <xsl:attribute name=""xsi:nil"">
                          <xsl:value-of select=""'true'"" />
                        </xsl:attribute>
                      </siteLongitude>
                    </xsl:if>
                    <xsl:if test=""string($var:v159)='false'"">
                      <siteLongitude>
                        <xsl:value-of select=""s1:addr_longitude/text()"" />
                      </siteLongitude>
                    </xsl:if>
                  </xsl:if>
                </ns8:Address>
              </ns5:Location>
              <ns12:MService>
                <xsl:if test=""s1:sstr_name"">
                  <CategoryName_1>
                    <xsl:value-of select=""s1:sstr_name/text()"" />
                  </CategoryName_1>
                </xsl:if>
                <xsl:if test=""s1:srvt_name"">
                  <CategoryName_2>
                    <xsl:value-of select=""s1:srvt_name/text()"" />
                  </CategoryName_2>
                </xsl:if>
                <xsl:if test=""s1:srvd_name"">
                  <CatgeoryName_3>
                    <xsl:value-of select=""s1:srvd_name/text()"" />
                  </CatgeoryName_3>
                </xsl:if>
                <xsl:if test=""s1:Case_SLASeverity"">
                  <CategoryFrequency_3>
                    <xsl:value-of select=""s1:Case_SLASeverity/text()"" />
                  </CategoryFrequency_3>
                </xsl:if>
                <xsl:if test=""s1:sstr_servicestreamid"">
                  <CategoryId_1>
                    <xsl:value-of select=""s1:sstr_servicestreamid/text()"" />
                  </CategoryId_1>
                </xsl:if>
                <xsl:if test=""s1:srvt_servicetypeid"">
                  <CategoryId_2>
                    <xsl:value-of select=""s1:srvt_servicetypeid/text()"" />
                  </CategoryId_2>
                </xsl:if>
                <xsl:if test=""s1:srvd_servicedetailid"">
                  <CategoryId_3>
                    <xsl:value-of select=""s1:srvd_servicedetailid/text()"" />
                  </CategoryId_3>
                </xsl:if>
                <xsl:if test=""s1:srvd_statutory"">
                  <CategoryType_3>
                    <xsl:value-of select=""s1:srvd_statutory/text()"" />
                  </CategoryType_3>
                </xsl:if>
                <xsl:if test=""s1:srvd_servicedetailid"">
                  <VendorCode>
                    <xsl:value-of select=""s1:srvd_servicedetailid/text()"" />
                  </VendorCode>
                </xsl:if>
                <xsl:if test=""s1:adli_ClientPropertyId"">
                  <VendorServiceLine>
                    <xsl:value-of select=""s1:adli_ClientPropertyId/text()"" />
                  </VendorServiceLine>
                </xsl:if>
              </ns12:MService>
              <ns9:Service>
                <ns12:ServiceStream>
                  <xsl:if test=""s1:sstr_servicestreamid"">
                    <xsl:attribute name=""StreamId"">
                      <xsl:value-of select=""s1:sstr_servicestreamid/text()"" />
                    </xsl:attribute>
                  </xsl:if>
                  <xsl:if test=""s1:sstr_name"">
                    <Streamname>
                      <xsl:value-of select=""s1:sstr_name/text()"" />
                    </Streamname>
                  </xsl:if>
                  <xsl:if test=""s1:sstr_prioritycat"">
                    <xsl:variable name=""var:v160"" select=""string(s1:sstr_prioritycat/@xsi:nil) = 'true'"" />
                    <xsl:if test=""string($var:v160)='true'"">
                      <Streamprioritycategory>
                        <xsl:attribute name=""xsi:nil"">
                          <xsl:value-of select=""'true'"" />
                        </xsl:attribute>
                      </Streamprioritycategory>
                    </xsl:if>
                    <xsl:if test=""string($var:v160)='false'"">
                      <Streamprioritycategory>
                        <xsl:value-of select=""s1:sstr_prioritycat/text()"" />
                      </Streamprioritycategory>
                    </xsl:if>
                  </xsl:if>
                </ns12:ServiceStream>
                <ns12:ServiceType>
                  <xsl:if test=""s1:srvt_servicetypeid"">
                    <xsl:attribute name=""TypeId"">
                      <xsl:value-of select=""s1:srvt_servicetypeid/text()"" />
                    </xsl:attribute>
                  </xsl:if>
                  <xsl:if test=""s1:srvt_name"">
                    <Typename>
                      <xsl:value-of select=""s1:srvt_name/text()"" />
                    </Typename>
                  </xsl:if>
                  <servicestreamid>
                    <xsl:text>1</xsl:text>
                  </servicestreamid>
                  <xsl:if test=""s1:srvt_prioritycat"">
                    <xsl:variable name=""var:v161"" select=""string(s1:srvt_prioritycat/@xsi:nil) = 'true'"" />
                    <xsl:if test=""string($var:v161)='true'"">
                      <Typeprioritycategory>
                        <xsl:attribute name=""xsi:nil"">
                          <xsl:value-of select=""'true'"" />
                        </xsl:attribute>
                      </Typeprioritycategory>
                    </xsl:if>
                    <xsl:if test=""string($var:v161)='false'"">
                      <Typeprioritycategory>
                        <xsl:value-of select=""s1:srvt_prioritycat/text()"" />
                      </Typeprioritycategory>
                    </xsl:if>
                  </xsl:if>
                </ns12:ServiceType>
                <ns12:ServiceDetail>
                  <xsl:if test=""s1:srvd_servicedetailid"">
                    <xsl:attribute name=""DetailId"">
                      <xsl:value-of select=""s1:srvd_servicedetailid/text()"" />
                    </xsl:attribute>
                  </xsl:if>
                  <xsl:if test=""s1:srvd_name"">
                    <Detailname>
                      <xsl:value-of select=""s1:srvd_name/text()"" />
                    </Detailname>
                  </xsl:if>
                  <xsl:if test=""s1:srvd_servicetypeid"">
                    <servicetypeid>
                      <xsl:value-of select=""s1:srvd_servicetypeid/text()"" />
                    </servicetypeid>
                  </xsl:if>
                  <xsl:if test=""s1:srvd_prioritycat"">
                    <xsl:variable name=""var:v162"" select=""string(s1:srvd_prioritycat/@xsi:nil) = 'true'"" />
                    <xsl:if test=""string($var:v162)='true'"">
                      <Detailprioritycategory>
                        <xsl:attribute name=""xsi:nil"">
                          <xsl:value-of select=""'true'"" />
                        </xsl:attribute>
                      </Detailprioritycategory>
                    </xsl:if>
                    <xsl:if test=""string($var:v162)='false'"">
                      <Detailprioritycategory>
                        <xsl:value-of select=""s1:srvd_prioritycat/text()"" />
                      </Detailprioritycategory>
                    </xsl:if>
                  </xsl:if>
                  <xsl:if test=""s1:srvd_statutory"">
                    <xsl:variable name=""var:v163"" select=""string(s1:srvd_statutory/@xsi:nil) = 'true'"" />
                    <xsl:if test=""string($var:v163)='true'"">
                      <statutory>
                        <xsl:attribute name=""xsi:nil"">
                          <xsl:value-of select=""'true'"" />
                        </xsl:attribute>
                      </statutory>
                    </xsl:if>
                    <xsl:if test=""string($var:v163)='false'"">
                      <statutory>
                        <xsl:value-of select=""s1:srvd_statutory/text()"" />
                      </statutory>
                    </xsl:if>
                  </xsl:if>
                  <xsl:if test=""s1:srvd_servicedetailcategoryid"">
                    <xsl:variable name=""var:v164"" select=""string(s1:srvd_servicedetailcategoryid/@xsi:nil) = 'true'"" />
                    <xsl:if test=""string($var:v164)='true'"">
                      <categoryid>
                        <xsl:attribute name=""xsi:nil"">
                          <xsl:value-of select=""'true'"" />
                        </xsl:attribute>
                      </categoryid>
                    </xsl:if>
                    <xsl:if test=""string($var:v164)='false'"">
                      <categoryid>
                        <xsl:value-of select=""s1:srvd_servicedetailcategoryid/text()"" />
                      </categoryid>
                    </xsl:if>
                  </xsl:if>
                  <xsl:if test=""s1:srvd_description"">
                    <xsl:variable name=""var:v165"" select=""string(s1:srvd_description/@xsi:nil) = 'true'"" />
                    <xsl:if test=""string($var:v165)='true'"">
                      <description>
                        <xsl:attribute name=""xsi:nil"">
                          <xsl:value-of select=""'true'"" />
                        </xsl:attribute>
                      </description>
                    </xsl:if>
                    <xsl:if test=""string($var:v165)='false'"">
                      <description>
                        <xsl:value-of select=""s1:srvd_description/text()"" />
                      </description>
                    </xsl:if>
                  </xsl:if>
                </ns12:ServiceDetail>
              </ns9:Service>
              <ns9:Helpdesk>
                <ns9:CreatedByUser>
                  <ns4:User>
                    <xsl:if test=""s1:Logged_User_UserId"">
                      <xsl:attribute name=""UserId"">
                        <xsl:value-of select=""s1:Logged_User_UserId/text()"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:if test=""s1:Logged_User_Logon"">
                      <LogonName>
                        <xsl:value-of select=""s1:Logged_User_Logon/text()"" />
                      </LogonName>
                    </xsl:if>
                    <xsl:if test=""s1:Logged_User_Phone"">
                      <xsl:variable name=""var:v166"" select=""string(s1:Logged_User_Phone/@xsi:nil) = 'true'"" />
                      <xsl:if test=""string($var:v166)='true'"">
                        <Phone>
                          <xsl:attribute name=""xsi:nil"">
                            <xsl:value-of select=""'true'"" />
                          </xsl:attribute>
                        </Phone>
                      </xsl:if>
                      <xsl:if test=""string($var:v166)='false'"">
                        <Phone>
                          <xsl:value-of select=""s1:Logged_User_Phone/text()"" />
                        </Phone>
                      </xsl:if>
                    </xsl:if>
                    <xsl:if test=""s1:Logged_User_EmailAddress"">
                      <xsl:variable name=""var:v167"" select=""string(s1:Logged_User_EmailAddress/@xsi:nil) = 'true'"" />
                      <xsl:if test=""string($var:v167)='true'"">
                        <EmailAddress>
                          <xsl:attribute name=""xsi:nil"">
                            <xsl:value-of select=""'true'"" />
                          </xsl:attribute>
                        </EmailAddress>
                      </xsl:if>
                      <xsl:if test=""string($var:v167)='false'"">
                        <EmailAddress>
                          <xsl:value-of select=""s1:Logged_User_EmailAddress/text()"" />
                        </EmailAddress>
                      </xsl:if>
                    </xsl:if>
                  </ns4:User>
                </ns9:CreatedByUser>
                <ns9:UpdatedByUser>
                  <ns4:User>
                    <xsl:if test=""s1:Updated_User_UserId"">
                      <xsl:attribute name=""UserId"">
                        <xsl:value-of select=""s1:Updated_User_UserId/text()"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:if test=""s1:Updated_User_Logon"">
                      <LogonName>
                        <xsl:value-of select=""s1:Updated_User_Logon/text()"" />
                      </LogonName>
                    </xsl:if>
                    <xsl:if test=""s1:Updated_User_Phone"">
                      <xsl:variable name=""var:v168"" select=""string(s1:Updated_User_Phone/@xsi:nil) = 'true'"" />
                      <xsl:if test=""string($var:v168)='true'"">
                        <Phone>
                          <xsl:attribute name=""xsi:nil"">
                            <xsl:value-of select=""'true'"" />
                          </xsl:attribute>
                        </Phone>
                      </xsl:if>
                      <xsl:if test=""string($var:v168)='false'"">
                        <Phone>
                          <xsl:value-of select=""s1:Updated_User_Phone/text()"" />
                        </Phone>
                      </xsl:if>
                    </xsl:if>
                    <xsl:if test=""s1:Updated_User_EmailAddress"">
                      <xsl:variable name=""var:v169"" select=""string(s1:Updated_User_EmailAddress/@xsi:nil) = 'true'"" />
                      <xsl:if test=""string($var:v169)='true'"">
                        <EmailAddress>
                          <xsl:attribute name=""xsi:nil"">
                            <xsl:value-of select=""'true'"" />
                          </xsl:attribute>
                        </EmailAddress>
                      </xsl:if>
                      <xsl:if test=""string($var:v169)='false'"">
                        <EmailAddress>
                          <xsl:value-of select=""s1:Updated_User_EmailAddress/text()"" />
                        </EmailAddress>
                      </xsl:if>
                    </xsl:if>
                  </ns4:User>
                </ns9:UpdatedByUser>
                <ns9:AuthorisedByPerson>
                  <ns4:Person>
                    <xsl:if test=""s1:Authorisor_Pers_PersonID"">
                      <xsl:attribute name=""Id"">
                        <xsl:value-of select=""s1:Authorisor_Pers_PersonID/text()"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:if test=""s1:Authorisor_Pers_name"">
                      <xsl:variable name=""var:v170"" select=""string(s1:Authorisor_Pers_name/@xsi:nil) = 'true'"" />
                      <xsl:if test=""string($var:v170)='true'"">
                        <FirstName>
                          <xsl:attribute name=""xsi:nil"">
                            <xsl:value-of select=""'true'"" />
                          </xsl:attribute>
                        </FirstName>
                      </xsl:if>
                      <xsl:if test=""string($var:v170)='false'"">
                        <FirstName>
                          <xsl:value-of select=""s1:Authorisor_Pers_name/text()"" />
                        </FirstName>
                      </xsl:if>
                    </xsl:if>
                    <xsl:if test=""s1:Authorisor_Pers_Department"">
                      <xsl:variable name=""var:v171"" select=""string(s1:Authorisor_Pers_Department/@xsi:nil) = 'true'"" />
                      <xsl:if test=""string($var:v171)='true'"">
                        <department>
                          <xsl:attribute name=""xsi:nil"">
                            <xsl:value-of select=""'true'"" />
                          </xsl:attribute>
                        </department>
                      </xsl:if>
                      <xsl:if test=""string($var:v171)='false'"">
                        <department>
                          <xsl:value-of select=""s1:Authorisor_Pers_Department/text()"" />
                        </department>
                      </xsl:if>
                    </xsl:if>
                    <xsl:if test=""s1:Authorisor_Pers_PhoneNumber"">
                      <xsl:variable name=""var:v172"" select=""string(s1:Authorisor_Pers_PhoneNumber/@xsi:nil) = 'true'"" />
                      <xsl:if test=""string($var:v172)='true'"">
                        <PhoneNumber>
                          <xsl:attribute name=""xsi:nil"">
                            <xsl:value-of select=""'true'"" />
                          </xsl:attribute>
                        </PhoneNumber>
                      </xsl:if>
                      <xsl:if test=""string($var:v172)='false'"">
                        <PhoneNumber>
                          <xsl:value-of select=""s1:Authorisor_Pers_PhoneNumber/text()"" />
                        </PhoneNumber>
                      </xsl:if>
                    </xsl:if>
                    <xsl:if test=""s1:Authorisor_EmailAddress"">
                      <xsl:variable name=""var:v173"" select=""string(s1:Authorisor_EmailAddress/@xsi:nil) = 'true'"" />
                      <xsl:if test=""string($var:v173)='true'"">
                        <EmailAddress>
                          <xsl:attribute name=""xsi:nil"">
                            <xsl:value-of select=""'true'"" />
                          </xsl:attribute>
                        </EmailAddress>
                      </xsl:if>
                      <xsl:if test=""string($var:v173)='false'"">
                        <EmailAddress>
                          <xsl:value-of select=""s1:Authorisor_EmailAddress/text()"" />
                        </EmailAddress>
                      </xsl:if>
                    </xsl:if>
                  </ns4:Person>
                </ns9:AuthorisedByPerson>
                <ns9:PreAuthorisedByPerson>
                  <ns4:Person>
                    <xsl:if test=""s1:Pre-Authorisor_Pers_PersonID"">
                      <xsl:attribute name=""Id"">
                        <xsl:value-of select=""s1:Pre-Authorisor_Pers_PersonID/text()"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:if test=""s1:Pre-Authorisor_Pers_name"">
                      <xsl:variable name=""var:v174"" select=""string(s1:Pre-Authorisor_Pers_name/@xsi:nil) = 'true'"" />
                      <xsl:if test=""string($var:v174)='true'"">
                        <FirstName>
                          <xsl:attribute name=""xsi:nil"">
                            <xsl:value-of select=""'true'"" />
                          </xsl:attribute>
                        </FirstName>
                      </xsl:if>
                      <xsl:if test=""string($var:v174)='false'"">
                        <FirstName>
                          <xsl:value-of select=""s1:Pre-Authorisor_Pers_name/text()"" />
                        </FirstName>
                      </xsl:if>
                    </xsl:if>
                    <xsl:if test=""s1:Pre-Authorisor_Pers_Department"">
                      <xsl:variable name=""var:v175"" select=""string(s1:Pre-Authorisor_Pers_Department/@xsi:nil) = 'true'"" />
                      <xsl:if test=""string($var:v175)='true'"">
                        <department>
                          <xsl:attribute name=""xsi:nil"">
                            <xsl:value-of select=""'true'"" />
                          </xsl:attribute>
                        </department>
                      </xsl:if>
                      <xsl:if test=""string($var:v175)='false'"">
                        <department>
                          <xsl:value-of select=""s1:Pre-Authorisor_Pers_Department/text()"" />
                        </department>
                      </xsl:if>
                    </xsl:if>
                    <xsl:if test=""s1:Pre-Authorisor_Pers_PhoneNumber"">
                      <xsl:variable name=""var:v176"" select=""string(s1:Pre-Authorisor_Pers_PhoneNumber/@xsi:nil) = 'true'"" />
                      <xsl:if test=""string($var:v176)='true'"">
                        <PhoneNumber>
                          <xsl:attribute name=""xsi:nil"">
                            <xsl:value-of select=""'true'"" />
                          </xsl:attribute>
                        </PhoneNumber>
                      </xsl:if>
                      <xsl:if test=""string($var:v176)='false'"">
                        <PhoneNumber>
                          <xsl:value-of select=""s1:Pre-Authorisor_Pers_PhoneNumber/text()"" />
                        </PhoneNumber>
                      </xsl:if>
                    </xsl:if>
                    <xsl:if test=""s1:Pre-Authorisor_EmailAddress"">
                      <xsl:variable name=""var:v177"" select=""string(s1:Pre-Authorisor_EmailAddress/@xsi:nil) = 'true'"" />
                      <xsl:if test=""string($var:v177)='true'"">
                        <EmailAddress>
                          <xsl:attribute name=""xsi:nil"">
                            <xsl:value-of select=""'true'"" />
                          </xsl:attribute>
                        </EmailAddress>
                      </xsl:if>
                      <xsl:if test=""string($var:v177)='false'"">
                        <EmailAddress>
                          <xsl:value-of select=""s1:Pre-Authorisor_EmailAddress/text()"" />
                        </EmailAddress>
                      </xsl:if>
                    </xsl:if>
                    <xsl:if test=""s1:Pre-Authorisor_FaxNumber"">
                      <xsl:variable name=""var:v178"" select=""string(s1:Pre-Authorisor_FaxNumber/@xsi:nil) = 'true'"" />
                      <xsl:if test=""string($var:v178)='true'"">
                        <FaxNumber>
                          <xsl:attribute name=""xsi:nil"">
                            <xsl:value-of select=""'true'"" />
                          </xsl:attribute>
                        </FaxNumber>
                      </xsl:if>
                      <xsl:if test=""string($var:v178)='false'"">
                        <FaxNumber>
                          <xsl:value-of select=""s1:Pre-Authorisor_FaxNumber/text()"" />
                        </FaxNumber>
                      </xsl:if>
                    </xsl:if>
                  </ns4:Person>
                  <xsl:if test=""s1:Authorisor_FaxNumber"">
                    <xsl:value-of select=""s1:Authorisor_FaxNumber/text()"" />
                  </xsl:if>
                </ns9:PreAuthorisedByPerson>
                <ns9:SecondaryAuthorisedByPerson>
                  <ns4:Person>
                    <xsl:if test=""s1:Secondary-Authorisor_Pers_PersonID"">
                      <xsl:attribute name=""Id"">
                        <xsl:value-of select=""s1:Secondary-Authorisor_Pers_PersonID/text()"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:if test=""s1:Secondary-Authorisor_Pers_name"">
                      <xsl:variable name=""var:v179"" select=""string(s1:Secondary-Authorisor_Pers_name/@xsi:nil) = 'true'"" />
                      <xsl:if test=""string($var:v179)='true'"">
                        <FirstName>
                          <xsl:attribute name=""xsi:nil"">
                            <xsl:value-of select=""'true'"" />
                          </xsl:attribute>
                        </FirstName>
                      </xsl:if>
                      <xsl:if test=""string($var:v179)='false'"">
                        <FirstName>
                          <xsl:value-of select=""s1:Secondary-Authorisor_Pers_name/text()"" />
                        </FirstName>
                      </xsl:if>
                    </xsl:if>
                    <xsl:if test=""s1:Secondary-Authorisor_Pers_Department"">
                      <xsl:variable name=""var:v180"" select=""string(s1:Secondary-Authorisor_Pers_Department/@xsi:nil) = 'true'"" />
                      <xsl:if test=""string($var:v180)='true'"">
                        <department>
                          <xsl:attribute name=""xsi:nil"">
                            <xsl:value-of select=""'true'"" />
                          </xsl:attribute>
                        </department>
                      </xsl:if>
                      <xsl:if test=""string($var:v180)='false'"">
                        <department>
                          <xsl:value-of select=""s1:Secondary-Authorisor_Pers_Department/text()"" />
                        </department>
                      </xsl:if>
                    </xsl:if>
                    <xsl:if test=""s1:Secondary-Authorisor_Pers_PhoneNumber"">
                      <xsl:variable name=""var:v181"" select=""string(s1:Secondary-Authorisor_Pers_PhoneNumber/@xsi:nil) = 'true'"" />
                      <xsl:if test=""string($var:v181)='true'"">
                        <PhoneNumber>
                          <xsl:attribute name=""xsi:nil"">
                            <xsl:value-of select=""'true'"" />
                          </xsl:attribute>
                        </PhoneNumber>
                      </xsl:if>
                      <xsl:if test=""string($var:v181)='false'"">
                        <PhoneNumber>
                          <xsl:value-of select=""s1:Secondary-Authorisor_Pers_PhoneNumber/text()"" />
                        </PhoneNumber>
                      </xsl:if>
                    </xsl:if>
                    <xsl:if test=""s1:Secondary-Authorisor_EmailAddress"">
                      <xsl:variable name=""var:v182"" select=""string(s1:Secondary-Authorisor_EmailAddress/@xsi:nil) = 'true'"" />
                      <xsl:if test=""string($var:v182)='true'"">
                        <EmailAddress>
                          <xsl:attribute name=""xsi:nil"">
                            <xsl:value-of select=""'true'"" />
                          </xsl:attribute>
                        </EmailAddress>
                      </xsl:if>
                      <xsl:if test=""string($var:v182)='false'"">
                        <EmailAddress>
                          <xsl:value-of select=""s1:Secondary-Authorisor_EmailAddress/text()"" />
                        </EmailAddress>
                      </xsl:if>
                    </xsl:if>
                    <xsl:if test=""s1:Secondary-Authorisor_FaxNumber"">
                      <xsl:variable name=""var:v183"" select=""string(s1:Secondary-Authorisor_FaxNumber/@xsi:nil) = 'true'"" />
                      <xsl:if test=""string($var:v183)='true'"">
                        <FaxNumber>
                          <xsl:attribute name=""xsi:nil"">
                            <xsl:value-of select=""'true'"" />
                          </xsl:attribute>
                        </FaxNumber>
                      </xsl:if>
                      <xsl:if test=""string($var:v183)='false'"">
                        <FaxNumber>
                          <xsl:value-of select=""s1:Secondary-Authorisor_FaxNumber/text()"" />
                        </FaxNumber>
                      </xsl:if>
                    </xsl:if>
                  </ns4:Person>
                </ns9:SecondaryAuthorisedByPerson>
                <ns9:NotAuthorisedByPerson>
                  <ns4:Person>
                    <xsl:if test=""s1:Not-Authorisor_Pers_PersonID"">
                      <xsl:attribute name=""Id"">
                        <xsl:value-of select=""s1:Not-Authorisor_Pers_PersonID/text()"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:if test=""s1:Not-Authorisor_Pers_name"">
                      <xsl:variable name=""var:v184"" select=""string(s1:Not-Authorisor_Pers_name/@xsi:nil) = 'true'"" />
                      <xsl:if test=""string($var:v184)='true'"">
                        <FirstName>
                          <xsl:attribute name=""xsi:nil"">
                            <xsl:value-of select=""'true'"" />
                          </xsl:attribute>
                        </FirstName>
                      </xsl:if>
                      <xsl:if test=""string($var:v184)='false'"">
                        <FirstName>
                          <xsl:value-of select=""s1:Not-Authorisor_Pers_name/text()"" />
                        </FirstName>
                      </xsl:if>
                    </xsl:if>
                    <xsl:if test=""s1:Not-Authorisor_Pers_Department"">
                      <xsl:variable name=""var:v185"" select=""string(s1:Not-Authorisor_Pers_Department/@xsi:nil) = 'true'"" />
                      <xsl:if test=""string($var:v185)='true'"">
                        <department>
                          <xsl:attribute name=""xsi:nil"">
                            <xsl:value-of select=""'true'"" />
                          </xsl:attribute>
                        </department>
                      </xsl:if>
                      <xsl:if test=""string($var:v185)='false'"">
                        <department>
                          <xsl:value-of select=""s1:Not-Authorisor_Pers_Department/text()"" />
                        </department>
                      </xsl:if>
                    </xsl:if>
                    <xsl:if test=""s1:Not-Authorisor_Pers_PhoneNumber"">
                      <xsl:variable name=""var:v186"" select=""string(s1:Not-Authorisor_Pers_PhoneNumber/@xsi:nil) = 'true'"" />
                      <xsl:if test=""string($var:v186)='true'"">
                        <PhoneNumber>
                          <xsl:attribute name=""xsi:nil"">
                            <xsl:value-of select=""'true'"" />
                          </xsl:attribute>
                        </PhoneNumber>
                      </xsl:if>
                      <xsl:if test=""string($var:v186)='false'"">
                        <PhoneNumber>
                          <xsl:value-of select=""s1:Not-Authorisor_Pers_PhoneNumber/text()"" />
                        </PhoneNumber>
                      </xsl:if>
                    </xsl:if>
                    <xsl:if test=""s1:Not-Authorisor_EmailAddress"">
                      <xsl:variable name=""var:v187"" select=""string(s1:Not-Authorisor_EmailAddress/@xsi:nil) = 'true'"" />
                      <xsl:if test=""string($var:v187)='true'"">
                        <EmailAddress>
                          <xsl:attribute name=""xsi:nil"">
                            <xsl:value-of select=""'true'"" />
                          </xsl:attribute>
                        </EmailAddress>
                      </xsl:if>
                      <xsl:if test=""string($var:v187)='false'"">
                        <EmailAddress>
                          <xsl:value-of select=""s1:Not-Authorisor_EmailAddress/text()"" />
                        </EmailAddress>
                      </xsl:if>
                    </xsl:if>
                    <xsl:if test=""s1:Not-Authorisor_FaxNumber"">
                      <xsl:variable name=""var:v188"" select=""string(s1:Not-Authorisor_FaxNumber/@xsi:nil) = 'true'"" />
                      <xsl:if test=""string($var:v188)='true'"">
                        <FaxNumber>
                          <xsl:attribute name=""xsi:nil"">
                            <xsl:value-of select=""'true'"" />
                          </xsl:attribute>
                        </FaxNumber>
                      </xsl:if>
                      <xsl:if test=""string($var:v188)='false'"">
                        <FaxNumber>
                          <xsl:value-of select=""s1:Not-Authorisor_FaxNumber/text()"" />
                        </FaxNumber>
                      </xsl:if>
                    </xsl:if>
                  </ns4:Person>
                </ns9:NotAuthorisedByPerson>
              </ns9:Helpdesk>
              <ns12:WorkPackageBundle>
                <xsl:if test=""s1:package_id"">
                  <WorkPackageBundleId>
                    <xsl:value-of select=""s1:package_id/text()"" />
                  </WorkPackageBundleId>
                </xsl:if>
                <xsl:if test=""s1:package_name"">
                  <WorkPackageBundleName>
                    <xsl:value-of select=""s1:package_name/text()"" />
                  </WorkPackageBundleName>
                </xsl:if>
                <xsl:if test=""s1:package_type"">
                  <WorkPackageBundleType>
                    <xsl:value-of select=""s1:package_type/text()"" />
                  </WorkPackageBundleType>
                </xsl:if>
              </ns12:WorkPackageBundle>
              <ns12:BundleItem>
                <xsl:if test=""s1:bundle_id"">
                  <BundleItemId>
                    <xsl:value-of select=""s1:bundle_id/text()"" />
                  </BundleItemId>
                </xsl:if>
                <xsl:if test=""s1:bundle_name"">
                  <BundleItemName>
                    <xsl:value-of select=""s1:bundle_name/text()"" />
                  </BundleItemName>
                </xsl:if>
                <xsl:if test=""s1:bundle_type"">
                  <BundleType>
                    <xsl:value-of select=""s1:bundle_type/text()"" />
                  </BundleType>
                </xsl:if>
                <xsl:if test=""s1:bundle_description"">
                  <BundleDescription>
                    <xsl:value-of select=""s1:bundle_description/text()"" />
                  </BundleDescription>
                </xsl:if>
                <xsl:if test=""s1:bundle_budget"">
                  <BundleBudget>
                    <xsl:value-of select=""s1:bundle_budget/text()"" />
                  </BundleBudget>
                </xsl:if>
                <xsl:if test=""s1:bundle_preappovedamount"">
                  <BundlePreApprovedAmount>
                    <xsl:value-of select=""s1:bundle_preappovedamount/text()"" />
                  </BundlePreApprovedAmount>
                </xsl:if>
              </ns12:BundleItem>
            </ns9:Workitem>
          </xsl:for-each>
        </xsl:for-each>
      </ns1:IssuedWork>
    </ns0:DistributedWorkItems>
  </xsl:template>
</xsl:stylesheet>";
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"MFM.Lbg.Schemas.VFM_Extract_TypedProcedure_dbo+biz_Global_Fetch_Case_DataSetResponse";
        
        private const global::MFM.Lbg.Schemas.VFM_Extract_TypedProcedure_dbo.biz_Global_Fetch_Case_DataSetResponse _srcSchemaTypeReference0 = null;
        
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
                string[] _SrcSchemas = new string [1];
                _SrcSchemas[0] = @"MFM.Lbg.Schemas.VFM_Extract_TypedProcedure_dbo+biz_Global_Fetch_Case_DataSetResponse";
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
