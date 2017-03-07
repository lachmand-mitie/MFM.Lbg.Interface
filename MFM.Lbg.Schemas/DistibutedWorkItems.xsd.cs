namespace MFM.Lbg.Schemas {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://MFM.Lbg.Schemas.DistibutedWorkItems",@"DistributedWorkItems")]
    [Microsoft.XLANGs.BaseTypes.PropertyAttribute(typeof(global::MFM.Lbg.Schemas.HelpdeskId), XPath = @"/*[local-name()='DistributedWorkItems' and namespace-uri()='http://MFM.Lbg.Schemas.DistibutedWorkItems']/*[local-name()='IssuedWork' and namespace-uri()='http://MFMSharedResources/Types/Helpdesk/v1/IssuedWork']/*[local-name()='Workitem' and namespace-uri()='http://MFMSharedResources/Types/Helpdesk/v1/Workitem']/*[local-name()='HelpdeskId' and namespace-uri()='http://MFMSharedResources/Types/Helpdesk/v1/Workitem']", XsdType = @"int")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "IssuedWork.Workitem.HelpdeskReference", XPath = @"/*[local-name()='DistributedWorkItems' and namespace-uri()='http://MFM.Lbg.Schemas.DistibutedWorkItems']/*[local-name()='IssuedWork' and namespace-uri()='http://MFMSharedResources/Types/Helpdesk/v1/IssuedWork']/*[local-name()='Workitem' and namespace-uri()='http://MFMSharedResources/Types/Helpdesk/v1/Workitem']/*[local-name()='HelpdeskReference' and namespace-uri()='http://MFMSharedResources/Types/Helpdesk/v1/Workitem']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "IssuedWork.Workitem.CustomerRef", XPath = @"/*[local-name()='DistributedWorkItems' and namespace-uri()='http://MFM.Lbg.Schemas.DistibutedWorkItems']/*[local-name()='IssuedWork' and namespace-uri()='http://MFMSharedResources/Types/Helpdesk/v1/IssuedWork']/*[local-name()='Workitem' and namespace-uri()='http://MFMSharedResources/Types/Helpdesk/v1/Workitem']/*[local-name()='CustomerRef' and namespace-uri()='http://MFMSharedResources/Types/Helpdesk/v1/Workitem']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "IssuedWork.Workitem.Location.linkpropertyid", XPath = @"/*[local-name()='DistributedWorkItems' and namespace-uri()='http://MFM.Lbg.Schemas.DistibutedWorkItems']/*[local-name()='IssuedWork' and namespace-uri()='http://MFMSharedResources/Types/Helpdesk/v1/IssuedWork']/*[local-name()='Workitem' and namespace-uri()='http://MFMSharedResources/Types/Helpdesk/v1/Workitem']/*[local-name()='Location' and namespace-uri()='http://MFMSharedResources/Types/Helpdesk/v1/Location']/*[local-name()='linkpropertyid' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "IssuedWork.Workitem.Location.Address.siteSiteID", XPath = @"/*[local-name()='DistributedWorkItems' and namespace-uri()='http://MFM.Lbg.Schemas.DistibutedWorkItems']/*[local-name()='IssuedWork' and namespace-uri()='http://MFMSharedResources/Types/Helpdesk/v1/IssuedWork']/*[local-name()='Workitem' and namespace-uri()='http://MFMSharedResources/Types/Helpdesk/v1/Workitem']/*[local-name()='Location' and namespace-uri()='http://MFMSharedResources/Types/Helpdesk/v1/Location']/*[local-name()='Address' and namespace-uri()='http://MFMSharedResources/Types/Helpdesk/v1/Address']/*[local-name()='siteSiteID' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "IssuedWork.MRoute.ContractName", XPath = @"/*[local-name()='DistributedWorkItems' and namespace-uri()='http://MFM.Lbg.Schemas.DistibutedWorkItems']/*[local-name()='IssuedWork' and namespace-uri()='http://MFMSharedResources/Types/Helpdesk/v1/IssuedWork']/*[local-name()='MRoute' and namespace-uri()='http://MFMSharedResources/Types/Helpdesk/v1/MRouting']/*[local-name()='ContractName' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "IssuedWork.MRoute.BizTalkCBR", XPath = @"/*[local-name()='DistributedWorkItems' and namespace-uri()='http://MFM.Lbg.Schemas.DistibutedWorkItems']/*[local-name()='IssuedWork' and namespace-uri()='http://MFMSharedResources/Types/Helpdesk/v1/IssuedWork']/*[local-name()='MRoute' and namespace-uri()='http://MFMSharedResources/Types/Helpdesk/v1/MRouting']/*[local-name()='BizTalkCBR' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "IssuedWork.MRoute.ServiceLineType", XPath = @"/*[local-name()='DistributedWorkItems' and namespace-uri()='http://MFM.Lbg.Schemas.DistibutedWorkItems']/*[local-name()='IssuedWork' and namespace-uri()='http://MFMSharedResources/Types/Helpdesk/v1/IssuedWork']/*[local-name()='MRoute' and namespace-uri()='http://MFMSharedResources/Types/Helpdesk/v1/MRouting']/*[local-name()='ServiceLineType' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "IssuedWork.Workitem.MService.VendorServiceLine", XPath = @"/*[local-name()='DistributedWorkItems' and namespace-uri()='http://MFM.Lbg.Schemas.DistibutedWorkItems']/*[local-name()='IssuedWork' and namespace-uri()='http://MFMSharedResources/Types/Helpdesk/v1/IssuedWork']/*[local-name()='Workitem' and namespace-uri()='http://MFMSharedResources/Types/Helpdesk/v1/Workitem']/*[local-name()='MService' and namespace-uri()='http://MFMSharedResources/Types/Helpdesk/v1/Service']/*[local-name()='VendorServiceLine' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "IssuedWork.Workitem.MService.VendorCode", XPath = @"/*[local-name()='DistributedWorkItems' and namespace-uri()='http://MFM.Lbg.Schemas.DistibutedWorkItems']/*[local-name()='IssuedWork' and namespace-uri()='http://MFMSharedResources/Types/Helpdesk/v1/IssuedWork']/*[local-name()='Workitem' and namespace-uri()='http://MFMSharedResources/Types/Helpdesk/v1/Workitem']/*[local-name()='MService' and namespace-uri()='http://MFMSharedResources/Types/Helpdesk/v1/Service']/*[local-name()='VendorCode' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "IssuedWork.Workitem.Location.linkMitiePropertyCode", XPath = @"/*[local-name()='DistributedWorkItems' and namespace-uri()='http://MFM.Lbg.Schemas.DistibutedWorkItems']/*[local-name()='IssuedWork' and namespace-uri()='http://MFMSharedResources/Types/Helpdesk/v1/IssuedWork']/*[local-name()='Workitem' and namespace-uri()='http://MFMSharedResources/Types/Helpdesk/v1/Workitem']/*[local-name()='Location' and namespace-uri()='http://MFMSharedResources/Types/Helpdesk/v1/Location']/*[local-name()='linkMitiePropertyCode' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.PropertyAttribute(typeof(global::MFM.Lbg.Schemas.Property1), XPath = @"/*[local-name()='DistributedWorkItems' and namespace-uri()='http://MFM.Lbg.Schemas.DistibutedWorkItems']/*[local-name()='IssuedWork' and namespace-uri()='http://MFMSharedResources/Types/Helpdesk/v1/IssuedWork']/*[local-name()='Workitem' and namespace-uri()='http://MFMSharedResources/Types/Helpdesk/v1/Workitem']/*[local-name()='Location' and namespace-uri()='http://MFMSharedResources/Types/Helpdesk/v1/Location']/*[local-name()='linkMitiePropertyCode' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.PropertyAttribute(typeof(global::MFM.Lbg.Schemas.ServiceLine1), XPath = @"/*[local-name()='DistributedWorkItems' and namespace-uri()='http://MFM.Lbg.Schemas.DistibutedWorkItems']/*[local-name()='IssuedWork' and namespace-uri()='http://MFMSharedResources/Types/Helpdesk/v1/IssuedWork']/*[local-name()='Workitem' and namespace-uri()='http://MFMSharedResources/Types/Helpdesk/v1/Workitem']/*[local-name()='MService' and namespace-uri()='http://MFMSharedResources/Types/Helpdesk/v1/Service']/*[local-name()='VendorServiceLine' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.PropertyAttribute(typeof(global::MFM.Lbg.Schemas.VendorSystem), XPath = @"/*[local-name()='DistributedWorkItems' and namespace-uri()='http://MFM.Lbg.Schemas.DistibutedWorkItems']/*[local-name()='IssuedWork' and namespace-uri()='http://MFMSharedResources/Types/Helpdesk/v1/IssuedWork']/*[local-name()='MRoute' and namespace-uri()='http://MFMSharedResources/Types/Helpdesk/v1/MRouting']/*[local-name()='BizTalkCBR' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "IssuedWork.Vendor.Person.EmailAddress", XPath = @"/*[local-name()='DistributedWorkItems' and namespace-uri()='http://MFM.Lbg.Schemas.DistibutedWorkItems']/*[local-name()='IssuedWork' and namespace-uri()='http://MFMSharedResources/Types/Helpdesk/v1/IssuedWork']/*[local-name()='Vendor' and namespace-uri()='http://MFMSharedResources/Types/Helpdesk/v1/Vendor']/*[local-name()='Person' and namespace-uri()='http://MFMSharedResources/Types/Helpdesk/v1/Person']/*[local-name()='EmailAddress' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "IssuedWork.Workitem.WorkPackageBundle.WorkPackageBundleName", XPath = @"/*[local-name()='DistributedWorkItems' and namespace-uri()='http://MFM.Lbg.Schemas.DistibutedWorkItems']/*[local-name()='IssuedWork' and namespace-uri()='http://MFMSharedResources/Types/Helpdesk/v1/IssuedWork']/*[local-name()='Workitem' and namespace-uri()='http://MFMSharedResources/Types/Helpdesk/v1/Workitem']/*[local-name()='WorkPackageBundle' and namespace-uri()='http://MFMSharedResources/Types/Helpdesk/v1/Service']/*[local-name()='WorkPackageBundleName' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.DateTime), "IssuedWork.Workitem.VendorAttendBy", XPath = @"/*[local-name()='DistributedWorkItems' and namespace-uri()='http://MFM.Lbg.Schemas.DistibutedWorkItems']/*[local-name()='IssuedWork' and namespace-uri()='http://MFMSharedResources/Types/Helpdesk/v1/IssuedWork']/*[local-name()='Workitem' and namespace-uri()='http://MFMSharedResources/Types/Helpdesk/v1/Workitem']/*[local-name()='VendorAttendBy' and namespace-uri()='http://MFMSharedResources/Types/Helpdesk/v1/Workitem']", XsdType = @"dateTime")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.DateTime), "IssuedWork.Workitem.VendorCompleteBy", XPath = @"/*[local-name()='DistributedWorkItems' and namespace-uri()='http://MFM.Lbg.Schemas.DistibutedWorkItems']/*[local-name()='IssuedWork' and namespace-uri()='http://MFMSharedResources/Types/Helpdesk/v1/IssuedWork']/*[local-name()='Workitem' and namespace-uri()='http://MFMSharedResources/Types/Helpdesk/v1/Workitem']/*[local-name()='VendorCompleteBy' and namespace-uri()='http://MFMSharedResources/Types/Helpdesk/v1/Workitem']", XsdType = @"dateTime")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "IssuedWork.Workitem.Helpdesk.UpdatedByUser.User.LogonName", XPath = @"/*[local-name()='DistributedWorkItems' and namespace-uri()='http://MFM.Lbg.Schemas.DistibutedWorkItems']/*[local-name()='IssuedWork' and namespace-uri()='http://MFMSharedResources/Types/Helpdesk/v1/IssuedWork']/*[local-name()='Workitem' and namespace-uri()='http://MFMSharedResources/Types/Helpdesk/v1/Workitem']/*[local-name()='Helpdesk' and namespace-uri()='http://MFMSharedResources/Types/Helpdesk/v1/Workitem']/*[local-name()='UpdatedByUser' and namespace-uri()='http://MFMSharedResources/Types/Helpdesk/v1/Workitem']/*[local-name()='User' and namespace-uri()='http://MFMSharedResources/Types/Helpdesk/v1/Person']/*[local-name()='LogonName' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "IssuedWork.Workitem.Helpdesk.UpdatedByUser.User.Phone", XPath = @"/*[local-name()='DistributedWorkItems' and namespace-uri()='http://MFM.Lbg.Schemas.DistibutedWorkItems']/*[local-name()='IssuedWork' and namespace-uri()='http://MFMSharedResources/Types/Helpdesk/v1/IssuedWork']/*[local-name()='Workitem' and namespace-uri()='http://MFMSharedResources/Types/Helpdesk/v1/Workitem']/*[local-name()='Helpdesk' and namespace-uri()='http://MFMSharedResources/Types/Helpdesk/v1/Workitem']/*[local-name()='UpdatedByUser' and namespace-uri()='http://MFMSharedResources/Types/Helpdesk/v1/Workitem']/*[local-name()='User' and namespace-uri()='http://MFMSharedResources/Types/Helpdesk/v1/Person']/*[local-name()='Phone' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "IssuedWork.Workitem.Helpdesk.UpdatedByUser.User.EmailAddress", XPath = @"/*[local-name()='DistributedWorkItems' and namespace-uri()='http://MFM.Lbg.Schemas.DistibutedWorkItems']/*[local-name()='IssuedWork' and namespace-uri()='http://MFMSharedResources/Types/Helpdesk/v1/IssuedWork']/*[local-name()='Workitem' and namespace-uri()='http://MFMSharedResources/Types/Helpdesk/v1/Workitem']/*[local-name()='Helpdesk' and namespace-uri()='http://MFMSharedResources/Types/Helpdesk/v1/Workitem']/*[local-name()='UpdatedByUser' and namespace-uri()='http://MFMSharedResources/Types/Helpdesk/v1/Workitem']/*[local-name()='User' and namespace-uri()='http://MFMSharedResources/Types/Helpdesk/v1/Person']/*[local-name()='EmailAddress' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "IssuedWork.Workitem.Location.Address.siteSiteName", XPath = @"/*[local-name()='DistributedWorkItems' and namespace-uri()='http://MFM.Lbg.Schemas.DistibutedWorkItems']/*[local-name()='IssuedWork' and namespace-uri()='http://MFMSharedResources/Types/Helpdesk/v1/IssuedWork']/*[local-name()='Workitem' and namespace-uri()='http://MFMSharedResources/Types/Helpdesk/v1/Workitem']/*[local-name()='Location' and namespace-uri()='http://MFMSharedResources/Types/Helpdesk/v1/Location']/*[local-name()='Address' and namespace-uri()='http://MFMSharedResources/Types/Helpdesk/v1/Address']/*[local-name()='siteSiteName' and namespace-uri()='']", XsdType = @"string")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"DistributedWorkItems"})]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"MFM.SharedResources.IssuedWork", typeof(global::MFM.SharedResources.IssuedWork))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"MFM.Lbg.Schemas.PropertySchema_2", typeof(global::MFM.Lbg.Schemas.PropertySchema_2))]
    public sealed class DistibutedWorkItems : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:ns2=""https://MFM.Lbg.Schemas.PropertySchema_2"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns:ns0=""http://MFM.SharedResources/Types/Helpdesk/v1/IssuedWork"" xmlns=""http://MFM.Lbg.Schemas.DistibutedWorkItems"" xmlns:ns1=""http://MFMSharedResources/Types/Helpdesk/v1/IssuedWork"" targetNamespace=""http://MFM.Lbg.Schemas.DistibutedWorkItems"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:import schemaLocation=""MFM.SharedResources.IssuedWork"" namespace=""http://MFMSharedResources/Types/Helpdesk/v1/IssuedWork"" />
  <xs:annotation>
    <xs:appinfo>
      <b:references>
        <b:reference targetNamespace=""http://MFMSharedResources/Types/Helpdesk/v1/Service"" />
        <b:reference targetNamespace=""http://MFMSharedResources/Types/Helpdesk/v1/MSurvey"" />
        <b:reference targetNamespace=""http://MFMSharedResources/Types/Helpdesk/v1/Customer"" />
        <b:reference targetNamespace=""http://MFMSharedResources/Types/Helpdesk/v1/Workitem"" />
        <b:reference targetNamespace=""http://MFMSharedResources/Types/Helpdesk/v1/Address"" />
        <b:reference targetNamespace=""http://MFMSharedResources/Types/Helpdesk/v1/MSurveyQuestion"" />
        <b:reference targetNamespace=""http://MFMSharedResources/Types/Helpdesk/v1/MSurveySet"" />
        <b:reference targetNamespace=""http://MFMSharedResources/Types/Helpdesk/v1/Location"" />
        <b:reference targetNamespace=""http://MFMSharedResources/Types/Helpdesk/v1/Person"" />
        <b:reference targetNamespace=""http://MFMSharedResources/Types/Helpdesk/v1/IssuedWork"" />
        <b:reference targetNamespace=""http://MFMSharedResources/Types/Helpdesk/v1/MRouting"" />
        <b:reference targetNamespace=""http://MFMSharedResources/Types/Helpdesk/v1/Vendor"" />
      </b:references>
      <b:imports>
        <b:namespace prefix=""ns2"" uri=""https://MFM.Lbg.Schemas.PropertySchema_2"" location=""MFM.Lbg.Schemas.PropertySchema_2"" />
      </b:imports>
    </xs:appinfo>
  </xs:annotation>
  <xs:element name=""DistributedWorkItems"">
    <xs:annotation>
      <xs:appinfo>
        <b:properties>
          <b:property name=""ns2:HelpdeskId"" xpath=""/*[local-name()='DistributedWorkItems' and namespace-uri()='http://MFM.Lbg.Schemas.DistibutedWorkItems']/*[local-name()='IssuedWork' and namespace-uri()='http://MFMSharedResources/Types/Helpdesk/v1/IssuedWork']/*[local-name()='Workitem' and namespace-uri()='http://MFMSharedResources/Types/Helpdesk/v1/Workitem']/*[local-name()='HelpdeskId' and namespace-uri()='http://MFMSharedResources/Types/Helpdesk/v1/Workitem']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='DistributedWorkItems' and namespace-uri()='http://MFM.Lbg.Schemas.DistibutedWorkItems']/*[local-name()='IssuedWork' and namespace-uri()='http://MFMSharedResources/Types/Helpdesk/v1/IssuedWork']/*[local-name()='Workitem' and namespace-uri()='http://MFMSharedResources/Types/Helpdesk/v1/Workitem']/*[local-name()='HelpdeskReference' and namespace-uri()='http://MFMSharedResources/Types/Helpdesk/v1/Workitem']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='DistributedWorkItems' and namespace-uri()='http://MFM.Lbg.Schemas.DistibutedWorkItems']/*[local-name()='IssuedWork' and namespace-uri()='http://MFMSharedResources/Types/Helpdesk/v1/IssuedWork']/*[local-name()='Workitem' and namespace-uri()='http://MFMSharedResources/Types/Helpdesk/v1/Workitem']/*[local-name()='CustomerRef' and namespace-uri()='http://MFMSharedResources/Types/Helpdesk/v1/Workitem']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='DistributedWorkItems' and namespace-uri()='http://MFM.Lbg.Schemas.DistibutedWorkItems']/*[local-name()='IssuedWork' and namespace-uri()='http://MFMSharedResources/Types/Helpdesk/v1/IssuedWork']/*[local-name()='Workitem' and namespace-uri()='http://MFMSharedResources/Types/Helpdesk/v1/Workitem']/*[local-name()='Location' and namespace-uri()='http://MFMSharedResources/Types/Helpdesk/v1/Location']/*[local-name()='linkpropertyid' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='DistributedWorkItems' and namespace-uri()='http://MFM.Lbg.Schemas.DistibutedWorkItems']/*[local-name()='IssuedWork' and namespace-uri()='http://MFMSharedResources/Types/Helpdesk/v1/IssuedWork']/*[local-name()='Workitem' and namespace-uri()='http://MFMSharedResources/Types/Helpdesk/v1/Workitem']/*[local-name()='Location' and namespace-uri()='http://MFMSharedResources/Types/Helpdesk/v1/Location']/*[local-name()='Address' and namespace-uri()='http://MFMSharedResources/Types/Helpdesk/v1/Address']/*[local-name()='siteSiteID' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='DistributedWorkItems' and namespace-uri()='http://MFM.Lbg.Schemas.DistibutedWorkItems']/*[local-name()='IssuedWork' and namespace-uri()='http://MFMSharedResources/Types/Helpdesk/v1/IssuedWork']/*[local-name()='MRoute' and namespace-uri()='http://MFMSharedResources/Types/Helpdesk/v1/MRouting']/*[local-name()='ContractName' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='DistributedWorkItems' and namespace-uri()='http://MFM.Lbg.Schemas.DistibutedWorkItems']/*[local-name()='IssuedWork' and namespace-uri()='http://MFMSharedResources/Types/Helpdesk/v1/IssuedWork']/*[local-name()='MRoute' and namespace-uri()='http://MFMSharedResources/Types/Helpdesk/v1/MRouting']/*[local-name()='BizTalkCBR' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='DistributedWorkItems' and namespace-uri()='http://MFM.Lbg.Schemas.DistibutedWorkItems']/*[local-name()='IssuedWork' and namespace-uri()='http://MFMSharedResources/Types/Helpdesk/v1/IssuedWork']/*[local-name()='MRoute' and namespace-uri()='http://MFMSharedResources/Types/Helpdesk/v1/MRouting']/*[local-name()='ServiceLineType' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='DistributedWorkItems' and namespace-uri()='http://MFM.Lbg.Schemas.DistibutedWorkItems']/*[local-name()='IssuedWork' and namespace-uri()='http://MFMSharedResources/Types/Helpdesk/v1/IssuedWork']/*[local-name()='Workitem' and namespace-uri()='http://MFMSharedResources/Types/Helpdesk/v1/Workitem']/*[local-name()='MService' and namespace-uri()='http://MFMSharedResources/Types/Helpdesk/v1/Service']/*[local-name()='VendorServiceLine' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='DistributedWorkItems' and namespace-uri()='http://MFM.Lbg.Schemas.DistibutedWorkItems']/*[local-name()='IssuedWork' and namespace-uri()='http://MFMSharedResources/Types/Helpdesk/v1/IssuedWork']/*[local-name()='Workitem' and namespace-uri()='http://MFMSharedResources/Types/Helpdesk/v1/Workitem']/*[local-name()='MService' and namespace-uri()='http://MFMSharedResources/Types/Helpdesk/v1/Service']/*[local-name()='VendorCode' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='DistributedWorkItems' and namespace-uri()='http://MFM.Lbg.Schemas.DistibutedWorkItems']/*[local-name()='IssuedWork' and namespace-uri()='http://MFMSharedResources/Types/Helpdesk/v1/IssuedWork']/*[local-name()='Workitem' and namespace-uri()='http://MFMSharedResources/Types/Helpdesk/v1/Workitem']/*[local-name()='Location' and namespace-uri()='http://MFMSharedResources/Types/Helpdesk/v1/Location']/*[local-name()='linkMitiePropertyCode' and namespace-uri()='']"" />
          <b:property name=""ns2:Property1"" xpath=""/*[local-name()='DistributedWorkItems' and namespace-uri()='http://MFM.Lbg.Schemas.DistibutedWorkItems']/*[local-name()='IssuedWork' and namespace-uri()='http://MFMSharedResources/Types/Helpdesk/v1/IssuedWork']/*[local-name()='Workitem' and namespace-uri()='http://MFMSharedResources/Types/Helpdesk/v1/Workitem']/*[local-name()='Location' and namespace-uri()='http://MFMSharedResources/Types/Helpdesk/v1/Location']/*[local-name()='linkMitiePropertyCode' and namespace-uri()='']"" />
          <b:property name=""ns2:ServiceLine1"" xpath=""/*[local-name()='DistributedWorkItems' and namespace-uri()='http://MFM.Lbg.Schemas.DistibutedWorkItems']/*[local-name()='IssuedWork' and namespace-uri()='http://MFMSharedResources/Types/Helpdesk/v1/IssuedWork']/*[local-name()='Workitem' and namespace-uri()='http://MFMSharedResources/Types/Helpdesk/v1/Workitem']/*[local-name()='MService' and namespace-uri()='http://MFMSharedResources/Types/Helpdesk/v1/Service']/*[local-name()='VendorServiceLine' and namespace-uri()='']"" />
          <b:property name=""ns2:VendorSystem"" xpath=""/*[local-name()='DistributedWorkItems' and namespace-uri()='http://MFM.Lbg.Schemas.DistibutedWorkItems']/*[local-name()='IssuedWork' and namespace-uri()='http://MFMSharedResources/Types/Helpdesk/v1/IssuedWork']/*[local-name()='MRoute' and namespace-uri()='http://MFMSharedResources/Types/Helpdesk/v1/MRouting']/*[local-name()='BizTalkCBR' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='DistributedWorkItems' and namespace-uri()='http://MFM.Lbg.Schemas.DistibutedWorkItems']/*[local-name()='IssuedWork' and namespace-uri()='http://MFMSharedResources/Types/Helpdesk/v1/IssuedWork']/*[local-name()='Vendor' and namespace-uri()='http://MFMSharedResources/Types/Helpdesk/v1/Vendor']/*[local-name()='Person' and namespace-uri()='http://MFMSharedResources/Types/Helpdesk/v1/Person']/*[local-name()='EmailAddress' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='DistributedWorkItems' and namespace-uri()='http://MFM.Lbg.Schemas.DistibutedWorkItems']/*[local-name()='IssuedWork' and namespace-uri()='http://MFMSharedResources/Types/Helpdesk/v1/IssuedWork']/*[local-name()='Workitem' and namespace-uri()='http://MFMSharedResources/Types/Helpdesk/v1/Workitem']/*[local-name()='WorkPackageBundle' and namespace-uri()='http://MFMSharedResources/Types/Helpdesk/v1/Service']/*[local-name()='WorkPackageBundleName' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='DistributedWorkItems' and namespace-uri()='http://MFM.Lbg.Schemas.DistibutedWorkItems']/*[local-name()='IssuedWork' and namespace-uri()='http://MFMSharedResources/Types/Helpdesk/v1/IssuedWork']/*[local-name()='Workitem' and namespace-uri()='http://MFMSharedResources/Types/Helpdesk/v1/Workitem']/*[local-name()='VendorAttendBy' and namespace-uri()='http://MFMSharedResources/Types/Helpdesk/v1/Workitem']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='DistributedWorkItems' and namespace-uri()='http://MFM.Lbg.Schemas.DistibutedWorkItems']/*[local-name()='IssuedWork' and namespace-uri()='http://MFMSharedResources/Types/Helpdesk/v1/IssuedWork']/*[local-name()='Workitem' and namespace-uri()='http://MFMSharedResources/Types/Helpdesk/v1/Workitem']/*[local-name()='VendorCompleteBy' and namespace-uri()='http://MFMSharedResources/Types/Helpdesk/v1/Workitem']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='DistributedWorkItems' and namespace-uri()='http://MFM.Lbg.Schemas.DistibutedWorkItems']/*[local-name()='IssuedWork' and namespace-uri()='http://MFMSharedResources/Types/Helpdesk/v1/IssuedWork']/*[local-name()='Workitem' and namespace-uri()='http://MFMSharedResources/Types/Helpdesk/v1/Workitem']/*[local-name()='Helpdesk' and namespace-uri()='http://MFMSharedResources/Types/Helpdesk/v1/Workitem']/*[local-name()='UpdatedByUser' and namespace-uri()='http://MFMSharedResources/Types/Helpdesk/v1/Workitem']/*[local-name()='User' and namespace-uri()='http://MFMSharedResources/Types/Helpdesk/v1/Person']/*[local-name()='LogonName' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='DistributedWorkItems' and namespace-uri()='http://MFM.Lbg.Schemas.DistibutedWorkItems']/*[local-name()='IssuedWork' and namespace-uri()='http://MFMSharedResources/Types/Helpdesk/v1/IssuedWork']/*[local-name()='Workitem' and namespace-uri()='http://MFMSharedResources/Types/Helpdesk/v1/Workitem']/*[local-name()='Helpdesk' and namespace-uri()='http://MFMSharedResources/Types/Helpdesk/v1/Workitem']/*[local-name()='UpdatedByUser' and namespace-uri()='http://MFMSharedResources/Types/Helpdesk/v1/Workitem']/*[local-name()='User' and namespace-uri()='http://MFMSharedResources/Types/Helpdesk/v1/Person']/*[local-name()='Phone' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='DistributedWorkItems' and namespace-uri()='http://MFM.Lbg.Schemas.DistibutedWorkItems']/*[local-name()='IssuedWork' and namespace-uri()='http://MFMSharedResources/Types/Helpdesk/v1/IssuedWork']/*[local-name()='Workitem' and namespace-uri()='http://MFMSharedResources/Types/Helpdesk/v1/Workitem']/*[local-name()='Helpdesk' and namespace-uri()='http://MFMSharedResources/Types/Helpdesk/v1/Workitem']/*[local-name()='UpdatedByUser' and namespace-uri()='http://MFMSharedResources/Types/Helpdesk/v1/Workitem']/*[local-name()='User' and namespace-uri()='http://MFMSharedResources/Types/Helpdesk/v1/Person']/*[local-name()='EmailAddress' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='DistributedWorkItems' and namespace-uri()='http://MFM.Lbg.Schemas.DistibutedWorkItems']/*[local-name()='IssuedWork' and namespace-uri()='http://MFMSharedResources/Types/Helpdesk/v1/IssuedWork']/*[local-name()='Workitem' and namespace-uri()='http://MFMSharedResources/Types/Helpdesk/v1/Workitem']/*[local-name()='Location' and namespace-uri()='http://MFMSharedResources/Types/Helpdesk/v1/Location']/*[local-name()='Address' and namespace-uri()='http://MFMSharedResources/Types/Helpdesk/v1/Address']/*[local-name()='siteSiteName' and namespace-uri()='']"" />
        </b:properties>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""1"" maxOccurs=""1"" ref=""ns1:IssuedWork"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        private const global::MFM.SharedResources.IssuedWork  __DummyVar0 = null;
        
        public DistibutedWorkItems() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "DistributedWorkItems";
                return _RootElements;
            }
        }
        
        protected override object RawSchema {
            get {
                return _rawSchema;
            }
            set {
                _rawSchema = value;
            }
        }
    }
}