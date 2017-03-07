namespace MFM.Lbg.Schemas {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"",@"MATMAS04")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"MATMAS04"})]
    public sealed class MATMAS04 : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xsd:schema xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" version=""1.0"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"">
  <xsd:element name=""MATMAS04"">
    <xsd:annotation>
      <xsd:documentation>Material Master</xsd:documentation>
    </xsd:annotation>
    <xsd:complexType>
      <xsd:sequence>
        <xsd:element name=""IDOC"">
          <xsd:complexType>
            <xsd:sequence>
              <xsd:element name=""EDI_DC40"">
                <xsd:annotation>
                  <xsd:documentation>IDoc Control Record for Interface to External System</xsd:documentation>
                </xsd:annotation>
                <xsd:complexType>
                  <xsd:sequence>
                    <xsd:element fixed=""EDI_DC40"" name=""TABNAM"" type=""xsd:string"">
                      <xsd:annotation>
                        <xsd:documentation>Name of Table Structure</xsd:documentation>
                      </xsd:annotation>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""MANDT"">
                      <xsd:annotation>
                        <xsd:documentation>Client</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""3"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""DOCNUM"">
                      <xsd:annotation>
                        <xsd:documentation>IDoc number</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""16"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""DOCREL"">
                      <xsd:annotation>
                        <xsd:documentation>SAP Release for IDoc</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""4"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""STATUS"">
                      <xsd:annotation>
                        <xsd:documentation>Status of IDoc</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""2"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element name=""DIRECT"">
                      <xsd:annotation>
                        <xsd:documentation>Direction</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:enumeration value=""1"">
                            <xsd:annotation>
                              <xsd:documentation>Outbound</xsd:documentation>
                            </xsd:annotation>
                          </xsd:enumeration>
                          <xsd:enumeration value=""2"">
                            <xsd:annotation>
                              <xsd:documentation>Inbound</xsd:documentation>
                            </xsd:annotation>
                          </xsd:enumeration>
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""OUTMOD"">
                      <xsd:annotation>
                        <xsd:documentation>Output mode</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""1"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""EXPRSS"">
                      <xsd:annotation>
                        <xsd:documentation>Overriding in inbound processing</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""1"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""TEST"">
                      <xsd:annotation>
                        <xsd:documentation>Test flag</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""1"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element fixed=""MATMAS04"" name=""IDOCTYP"" type=""xsd:string"">
                      <xsd:annotation>
                        <xsd:documentation>Name of basic type</xsd:documentation>
                      </xsd:annotation>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" fixed="""" name=""CIMTYP"" type=""xsd:string"">
                      <xsd:annotation>
                        <xsd:documentation>Extension (defined by customer)</xsd:documentation>
                      </xsd:annotation>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""MESTYP"">
                      <xsd:annotation>
                        <xsd:documentation>Message type</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""30"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""MESCOD"">
                      <xsd:annotation>
                        <xsd:documentation>Message code</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""3"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""MESFCT"">
                      <xsd:annotation>
                        <xsd:documentation>Message Function</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""3"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""STD"">
                      <xsd:annotation>
                        <xsd:documentation>EDI standard, flag</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""1"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""STDVRS"">
                      <xsd:annotation>
                        <xsd:documentation>EDI standard, version and release</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""6"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""STDMES"">
                      <xsd:annotation>
                        <xsd:documentation>EDI message type</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""6"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element name=""SNDPOR"">
                      <xsd:annotation>
                        <xsd:documentation>Sender port (SAP System, external subsystem)</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""10"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element name=""SNDPRT"">
                      <xsd:annotation>
                        <xsd:documentation>Partner type of sender</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""2"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""SNDPFC"">
                      <xsd:annotation>
                        <xsd:documentation>Partner Function of Sender</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""2"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element name=""SNDPRN"">
                      <xsd:annotation>
                        <xsd:documentation>Partner Number of Sender</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""10"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""SNDSAD"">
                      <xsd:annotation>
                        <xsd:documentation>Sender address (SADR)</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""21"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""SNDLAD"">
                      <xsd:annotation>
                        <xsd:documentation>Logical address of sender</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""70"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element name=""RCVPOR"">
                      <xsd:annotation>
                        <xsd:documentation>Receiver port</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""10"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""RCVPRT"">
                      <xsd:annotation>
                        <xsd:documentation>Partner Type of Receiver</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""2"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""RCVPFC"">
                      <xsd:annotation>
                        <xsd:documentation>Partner function of recipient</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""2"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element name=""RCVPRN"">
                      <xsd:annotation>
                        <xsd:documentation>Partner Number of Receiver</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""10"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""RCVSAD"">
                      <xsd:annotation>
                        <xsd:documentation>Recipient address (SADR)</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""21"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""RCVLAD"">
                      <xsd:annotation>
                        <xsd:documentation>Logical address of recipient</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""70"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""CREDAT"">
                      <xsd:annotation>
                        <xsd:documentation>Created on</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""8"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""CRETIM"">
                      <xsd:annotation>
                        <xsd:documentation>Created at</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""6"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""REFINT"">
                      <xsd:annotation>
                        <xsd:documentation>Transmission file (EDI Interchange)</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""14"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""REFGRP"">
                      <xsd:annotation>
                        <xsd:documentation>Message group (EDI Message Group)</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""14"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""REFMES"">
                      <xsd:annotation>
                        <xsd:documentation>Message (EDI Message)</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""14"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""ARCKEY"">
                      <xsd:annotation>
                        <xsd:documentation>Key for external message archive</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""70"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""SERIAL"">
                      <xsd:annotation>
                        <xsd:documentation>Serialization</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""20"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                  </xsd:sequence>
                  <xsd:attribute name=""SEGMENT"" use=""required"">
                    <xsd:simpleType>
                      <xsd:restriction base=""xsd:string"">
                        <xsd:enumeration value=""1"" />
                      </xsd:restriction>
                    </xsd:simpleType>
                  </xsd:attribute>
                </xsd:complexType>
              </xsd:element>
              <xsd:element maxOccurs=""9999"" name=""E1MARAM"">
                <xsd:annotation>
                  <xsd:documentation>Master material general data (MARA)</xsd:documentation>
                </xsd:annotation>
                <xsd:complexType>
                  <xsd:sequence>
                    <xsd:element minOccurs=""0"" name=""MSGFN"">
                      <xsd:annotation>
                        <xsd:documentation>Function</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""3"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""MATNR"">
                      <xsd:annotation>
                        <xsd:documentation>Material Number</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""18"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""ERSDA"">
                      <xsd:annotation>
                        <xsd:documentation>Created On</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""8"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""ERNAM"">
                      <xsd:annotation>
                        <xsd:documentation>Name of Person who Created the Object</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""12"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""LAEDA"">
                      <xsd:annotation>
                        <xsd:documentation>Date of Last Change</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""8"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""AENAM"">
                      <xsd:annotation>
                        <xsd:documentation>Name of Person Who Changed Object</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""12"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""PSTAT"">
                      <xsd:annotation>
                        <xsd:documentation>Maintenance status</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""15"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""LVORM"">
                      <xsd:annotation>
                        <xsd:documentation>Flag Material for Deletion at Client Level</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""1"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""MTART"">
                      <xsd:annotation>
                        <xsd:documentation>Material Type</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""4"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""MBRSH"">
                      <xsd:annotation>
                        <xsd:documentation>Industry sector</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""1"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""MATKL"">
                      <xsd:annotation>
                        <xsd:documentation>Material Group</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""9"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""BISMT"">
                      <xsd:annotation>
                        <xsd:documentation>Old material number</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""18"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""MEINS"">
                      <xsd:annotation>
                        <xsd:documentation>Base Unit of Measure</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""3"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""BSTME"">
                      <xsd:annotation>
                        <xsd:documentation>Purchase Order Unit of Measure</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""3"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""ZEINR"">
                      <xsd:annotation>
                        <xsd:documentation>Document number (without document management system)</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""22"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""ZEIAR"">
                      <xsd:annotation>
                        <xsd:documentation>Document type (without Document Management system)</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""3"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""ZEIVR"">
                      <xsd:annotation>
                        <xsd:documentation>Document version (without Document Management system)</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""2"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""ZEIFO"">
                      <xsd:annotation>
                        <xsd:documentation>Page format of document (without Document Management system)</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""4"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""AESZN"">
                      <xsd:annotation>
                        <xsd:documentation>Document change number (without document management system)</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""6"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""BLATT"">
                      <xsd:annotation>
                        <xsd:documentation>Page number of document (without Document Management system)</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""3"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""BLANZ"">
                      <xsd:annotation>
                        <xsd:documentation>Number of sheets (without Document Management system)</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""3"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""FERTH"">
                      <xsd:annotation>
                        <xsd:documentation>Production/inspection memo</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""18"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""FORMT"">
                      <xsd:annotation>
                        <xsd:documentation>Page Format of Production Memo</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""4"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""GROES"">
                      <xsd:annotation>
                        <xsd:documentation>Size/dimensions</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""32"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""WRKST"">
                      <xsd:annotation>
                        <xsd:documentation>Basic material (basic constituent of a material) - obsolete</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""14"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""NORMT"">
                      <xsd:annotation>
                        <xsd:documentation>Industry Standard Description (such as ANSI or ISO)</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""18"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""LABOR"">
                      <xsd:annotation>
                        <xsd:documentation>Laboratory/design office</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""3"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""EKWSL"">
                      <xsd:annotation>
                        <xsd:documentation>Purchasing Value Key</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""4"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""BRGEW"">
                      <xsd:annotation>
                        <xsd:documentation>Gross Weight</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""14"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""NTGEW"">
                      <xsd:annotation>
                        <xsd:documentation>Net Weight</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""14"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""GEWEI"">
                      <xsd:annotation>
                        <xsd:documentation>Weight Unit</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""3"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""VOLUM"">
                      <xsd:annotation>
                        <xsd:documentation>Volume</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""14"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""VOLEH"">
                      <xsd:annotation>
                        <xsd:documentation>Volume unit</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""3"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""BEHVO"">
                      <xsd:annotation>
                        <xsd:documentation>Container requirements</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""2"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""RAUBE"">
                      <xsd:annotation>
                        <xsd:documentation>Storage conditions</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""2"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""TEMPB"">
                      <xsd:annotation>
                        <xsd:documentation>Temperature conditions indicator</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""2"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""TRAGR"">
                      <xsd:annotation>
                        <xsd:documentation>Transportation Group</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""4"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""STOFF"">
                      <xsd:annotation>
                        <xsd:documentation>Hazardous material number</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""18"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""SPART"">
                      <xsd:annotation>
                        <xsd:documentation>Division</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""2"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""KUNNR"">
                      <xsd:annotation>
                        <xsd:documentation>Competitor</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""10"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""WESCH"">
                      <xsd:annotation>
                        <xsd:documentation>Quantity: Number of GR/GI slips to be printed</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""14"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""BWVOR"">
                      <xsd:annotation>
                        <xsd:documentation>Procurement rule</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""1"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""BWSCL"">
                      <xsd:annotation>
                        <xsd:documentation>Source of Supply</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""1"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""SAISO"">
                      <xsd:annotation>
                        <xsd:documentation>Season Category</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""4"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""ETIAR"">
                      <xsd:annotation>
                        <xsd:documentation>Label type</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""2"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""ETIFO"">
                      <xsd:annotation>
                        <xsd:documentation>Label form</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""2"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""EAN11"">
                      <xsd:annotation>
                        <xsd:documentation>International Article Number (EAN/UPC)</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""18"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""NUMTP"">
                      <xsd:annotation>
                        <xsd:documentation>Category of International Article Number (EAN)</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""2"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""LAENG"">
                      <xsd:annotation>
                        <xsd:documentation>Length</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""14"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""BREIT"">
                      <xsd:annotation>
                        <xsd:documentation>Width</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""14"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""HOEHE"">
                      <xsd:annotation>
                        <xsd:documentation>Height</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""14"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""MEABM"">
                      <xsd:annotation>
                        <xsd:documentation>Unit of Dimension for Length/Width/Height</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""3"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""PRDHA"">
                      <xsd:annotation>
                        <xsd:documentation>Product hierarchy</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""18"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""CADKZ"">
                      <xsd:annotation>
                        <xsd:documentation>CAD Indicator</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""1"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""ERGEW"">
                      <xsd:annotation>
                        <xsd:documentation>Allowed packaging weight</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""14"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""ERGEI"">
                      <xsd:annotation>
                        <xsd:documentation>Weight Unit</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""3"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""ERVOL"">
                      <xsd:annotation>
                        <xsd:documentation>Allowed packaging volume</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""14"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""ERVOE"">
                      <xsd:annotation>
                        <xsd:documentation>Volume unit</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""3"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""GEWTO"">
                      <xsd:annotation>
                        <xsd:documentation>Excess Weight Tolerance for Handling unit</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""3"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""VOLTO"">
                      <xsd:annotation>
                        <xsd:documentation>Excess Volume Tolerance of the Handling Unit</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""3"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""VABME"">
                      <xsd:annotation>
                        <xsd:documentation>Variable Purchase Order Unit Active</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""1"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""KZKFG"">
                      <xsd:annotation>
                        <xsd:documentation>Configurable Material</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""1"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""XCHPF"">
                      <xsd:annotation>
                        <xsd:documentation>Batch management requirement indicator</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""1"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""VHART"">
                      <xsd:annotation>
                        <xsd:documentation>Packaging Material Type</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""4"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""FUELG"">
                      <xsd:annotation>
                        <xsd:documentation>Maximum level (by volume)</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""3"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""STFAK"">
                      <xsd:annotation>
                        <xsd:documentation>Stacking factor</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""5"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""MAGRV"">
                      <xsd:annotation>
                        <xsd:documentation>Material Group: Packaging Materials</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""4"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""BEGRU"">
                      <xsd:annotation>
                        <xsd:documentation>Authorization Group</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""4"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""QMPUR"">
                      <xsd:annotation>
                        <xsd:documentation>QM in Procurement is Active</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""1"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""RBNRM"">
                      <xsd:annotation>
                        <xsd:documentation>Catalog Profile</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""9"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""MHDRZ"">
                      <xsd:annotation>
                        <xsd:documentation>Minimum Remaining Shelf Life</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""6"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""MHDHB"">
                      <xsd:annotation>
                        <xsd:documentation>Total shelf life</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""6"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""MHDLP"">
                      <xsd:annotation>
                        <xsd:documentation>Storage percentage</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""5"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""VPSTA"">
                      <xsd:annotation>
                        <xsd:documentation>Maintenance status of complete material</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""15"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""EXTWG"">
                      <xsd:annotation>
                        <xsd:documentation>External Material Group</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""18"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""MSTAE"">
                      <xsd:annotation>
                        <xsd:documentation>Cross-Plant Material Status</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""2"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""MSTAV"">
                      <xsd:annotation>
                        <xsd:documentation>Cross-distribution-chain material status</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""2"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""MSTDE"">
                      <xsd:annotation>
                        <xsd:documentation>Date from which the cross-plant material status is valid</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""8"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""MSTDV"">
                      <xsd:annotation>
                        <xsd:documentation>Date from which the X-distr.-chain material status is valid</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""8"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""KZUMW"">
                      <xsd:annotation>
                        <xsd:documentation>Environmentally Relevant</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""1"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""KOSCH"">
                      <xsd:annotation>
                        <xsd:documentation>Product allocation determination procedure</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""18"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""NRFHG"">
                      <xsd:annotation>
                        <xsd:documentation>Material qualifies for discount in kind</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""1"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""MFRPN"">
                      <xsd:annotation>
                        <xsd:documentation>Manufacturer Part Number</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""40"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""MFRNR"">
                      <xsd:annotation>
                        <xsd:documentation>Number of a Manufacturer</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""10"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""BMATN"">
                      <xsd:annotation>
                        <xsd:documentation>To material number</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""18"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""MPROF"">
                      <xsd:annotation>
                        <xsd:documentation>Manufacturer Part Profile</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""4"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""PROFL"">
                      <xsd:annotation>
                        <xsd:documentation>Dangerous Goods Indicator Profile</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""3"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""IHIVI"">
                      <xsd:annotation>
                        <xsd:documentation>Indicator: Highly Viscous</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""1"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""ILOOS"">
                      <xsd:annotation>
                        <xsd:documentation>Indicator: In Bulk/Liquid</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""1"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""KZGVH"">
                      <xsd:annotation>
                        <xsd:documentation>Packaging Material is Closed Packaging</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""1"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""XGCHP"">
                      <xsd:annotation>
                        <xsd:documentation>Indicator: Approved batch record required</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""1"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""COMPL"">
                      <xsd:annotation>
                        <xsd:documentation>Material completion level</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""2"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""KZEFF"">
                      <xsd:annotation>
                        <xsd:documentation>Assign effectivity parameter values/ override change numbers</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""1"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""RDMHD"">
                      <xsd:annotation>
                        <xsd:documentation>Rounding rule for calculation of SLED</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""1"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""IPRKZ"">
                      <xsd:annotation>
                        <xsd:documentation>Period Indicator for Shelf Life Expiration Date</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""1"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""PRZUS"">
                      <xsd:annotation>
                        <xsd:documentation>Indicator: Product composition printed on packaging</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""1"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""MTPOS_MARA"">
                      <xsd:annotation>
                        <xsd:documentation>General item category group</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""4"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""GEWTO_NEW"">
                      <xsd:annotation>
                        <xsd:documentation>Excess Weight Tolerance for Handling unit</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""5"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""VOLTO_NEW"">
                      <xsd:annotation>
                        <xsd:documentation>Excess Volume Tolerance of the Handling Unit</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""5"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""WRKST_NEW"">
                      <xsd:annotation>
                        <xsd:documentation>Basic Material</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""48"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""AENNR"">
                      <xsd:annotation>
                        <xsd:documentation>Change Number</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""12"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""MATFI"">
                      <xsd:annotation>
                        <xsd:documentation>Material Is Locked</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""1"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""CMREL"">
                      <xsd:annotation>
                        <xsd:documentation>Relevant for Configuration Management</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""1"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""SATNR"">
                      <xsd:annotation>
                        <xsd:documentation>Cross-Plant Configurable Material</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""18"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""SLED_BBD"">
                      <xsd:annotation>
                        <xsd:documentation>Expiration Date</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""1"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""GTIN_VARIANT"">
                      <xsd:annotation>
                        <xsd:documentation>Global Trade Item Number Variant</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""2"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""GENNR"">
                      <xsd:annotation>
                        <xsd:documentation>Material Number of the Generic Material in Prepack Materials</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""18"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""SERLV"">
                      <xsd:annotation>
                        <xsd:documentation>Level of Explicitness for Serial Number</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""1"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""RMATP"">
                      <xsd:annotation>
                        <xsd:documentation>Reference material for materials packed in same way</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""18"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""GDS_RELEVANT"">
                      <xsd:annotation>
                        <xsd:documentation>Indicator: Global Data Synchronization-Relevant</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""1"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""MCOND"">
                      <xsd:annotation>
                        <xsd:documentation>Material Condition Management</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""1"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""RETDELC"">
                      <xsd:annotation>
                        <xsd:documentation>Return Code</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""1"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""LOGLEV_RETO"">
                      <xsd:annotation>
                        <xsd:documentation>Return to Logistics Level</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""1"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""NSNID"">
                      <xsd:annotation>
                        <xsd:documentation>NATO Stock Number</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""9"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""WEORA"">
                      <xsd:annotation>
                        <xsd:documentation>Acceptance At Origin</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""1"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""_-CWM_-TOLGR"">
                      <xsd:annotation>
                        <xsd:documentation>Tolerance Group for Catch Weight Management</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""9"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""_-CWM_-TARA"">
                      <xsd:annotation>
                        <xsd:documentation>Checkbox</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""1"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""_-CWM_-TARUM"">
                      <xsd:annotation>
                        <xsd:documentation>Base Unit of Measure</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""3"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""E1MARA1"">
                      <xsd:annotation>
                        <xsd:documentation>Additional Fields for E1MARAM</xsd:documentation>
                      </xsd:annotation>
                      <xsd:complexType>
                        <xsd:sequence>
                          <xsd:element minOccurs=""0"" name=""MATNR_EXTERNAL"">
                            <xsd:annotation>
                              <xsd:documentation>Material Number</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""40"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""MATNR_VERSION"">
                            <xsd:annotation>
                              <xsd:documentation>Version Number for MATNR Field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""10"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""MATNR_GUID"">
                            <xsd:annotation>
                              <xsd:documentation>External GUID for MATNR Field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""32"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""BMATN_EXTERNAL"">
                            <xsd:annotation>
                              <xsd:documentation>Long Material Number for Field BMATN</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""40"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""BMATN_VERSION"">
                            <xsd:annotation>
                              <xsd:documentation>Version Number for Field BMATN</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""10"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""BMATN_GUID"">
                            <xsd:annotation>
                              <xsd:documentation>External GUID for Field BMATN</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""32"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""STOFF_EXTERNAL"">
                            <xsd:annotation>
                              <xsd:documentation>Long Material Number for Field STOFF</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""40"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""STOFF_VERSION"">
                            <xsd:annotation>
                              <xsd:documentation>Version Number for Field STOFF</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""10"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""STOFF_GUID"">
                            <xsd:annotation>
                              <xsd:documentation>External GUID for Field STOFF</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""32"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                        </xsd:sequence>
                        <xsd:attribute name=""SEGMENT"" use=""required"">
                          <xsd:simpleType>
                            <xsd:restriction base=""xsd:string"">
                              <xsd:enumeration value=""1"" />
                            </xsd:restriction>
                          </xsd:simpleType>
                        </xsd:attribute>
                      </xsd:complexType>
                    </xsd:element>
                    <xsd:element maxOccurs=""99"" name=""E1MAKTM"">
                      <xsd:annotation>
                        <xsd:documentation>Master material short texts (MAKT)</xsd:documentation>
                      </xsd:annotation>
                      <xsd:complexType>
                        <xsd:sequence>
                          <xsd:element minOccurs=""0"" name=""MSGFN"">
                            <xsd:annotation>
                              <xsd:documentation>Function</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""3"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""SPRAS"">
                            <xsd:annotation>
                              <xsd:documentation>Language Key</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""MAKTX"">
                            <xsd:annotation>
                              <xsd:documentation>Material Description (Short Text)</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""40"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""SPRAS_ISO"">
                            <xsd:annotation>
                              <xsd:documentation>Language according to ISO 639</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""2"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                        </xsd:sequence>
                        <xsd:attribute name=""SEGMENT"" use=""required"">
                          <xsd:simpleType>
                            <xsd:restriction base=""xsd:string"">
                              <xsd:enumeration value=""1"" />
                            </xsd:restriction>
                          </xsd:simpleType>
                        </xsd:attribute>
                      </xsd:complexType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" maxOccurs=""9999"" name=""E1MARCM"">
                      <xsd:annotation>
                        <xsd:documentation>Master material C segment (MARC)</xsd:documentation>
                      </xsd:annotation>
                      <xsd:complexType>
                        <xsd:sequence>
                          <xsd:element minOccurs=""0"" name=""MSGFN"">
                            <xsd:annotation>
                              <xsd:documentation>Function</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""3"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""WERKS"">
                            <xsd:annotation>
                              <xsd:documentation>Plant</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""4"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""PSTAT"">
                            <xsd:annotation>
                              <xsd:documentation>Maintenance status</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""15"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""LVORM"">
                            <xsd:annotation>
                              <xsd:documentation>Deletion Indicator</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""BWTTY"">
                            <xsd:annotation>
                              <xsd:documentation>Valuation Category</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""MAABC"">
                            <xsd:annotation>
                              <xsd:documentation>ABC Indicator</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""KZKRI"">
                            <xsd:annotation>
                              <xsd:documentation>Indicator: Critical part</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""EKGRP"">
                            <xsd:annotation>
                              <xsd:documentation>Purchasing Group</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""3"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""AUSME"">
                            <xsd:annotation>
                              <xsd:documentation>Unit of issue</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""3"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""DISPR"">
                            <xsd:annotation>
                              <xsd:documentation>Material: MRP profile</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""4"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""DISMM"">
                            <xsd:annotation>
                              <xsd:documentation>MRP Type</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""2"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""DISPO"">
                            <xsd:annotation>
                              <xsd:documentation>MRP Controller (Materials Planner)</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""3"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""PLIFZ"">
                            <xsd:annotation>
                              <xsd:documentation>Planned Delivery Time in Days</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""3"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""WEBAZ"">
                            <xsd:annotation>
                              <xsd:documentation>Goods Receipt Processing Time in Days</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""3"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""PERKZ"">
                            <xsd:annotation>
                              <xsd:documentation>Period Indicator</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""AUSSS"">
                            <xsd:annotation>
                              <xsd:documentation>Assembly scrap in percent</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""5"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""DISLS"">
                            <xsd:annotation>
                              <xsd:documentation>Lot size (materials planning)</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""2"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""BESKZ"">
                            <xsd:annotation>
                              <xsd:documentation>Procurement Type</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""SOBSL"">
                            <xsd:annotation>
                              <xsd:documentation>Special procurement type</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""2"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""MINBE"">
                            <xsd:annotation>
                              <xsd:documentation>Reorder Point</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""14"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""EISBE"">
                            <xsd:annotation>
                              <xsd:documentation>Safety Stock</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""14"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""BSTMI"">
                            <xsd:annotation>
                              <xsd:documentation>Minimum Lot Size</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""14"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""BSTMA"">
                            <xsd:annotation>
                              <xsd:documentation>Maximum Lot Size</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""14"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""BSTFE"">
                            <xsd:annotation>
                              <xsd:documentation>Fixed lot size</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""14"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""BSTRF"">
                            <xsd:annotation>
                              <xsd:documentation>Rounding value for purchase order quantity</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""14"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""MABST"">
                            <xsd:annotation>
                              <xsd:documentation>Maximum stock level</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""14"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""LOSFX"">
                            <xsd:annotation>
                              <xsd:documentation>Ordering costs</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""12"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""SBDKZ"">
                            <xsd:annotation>
                              <xsd:documentation>Dependent requirements ind. for individual and coll. reqmts</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""LAGPR"">
                            <xsd:annotation>
                              <xsd:documentation>Storage costs indicator</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""ALTSL"">
                            <xsd:annotation>
                              <xsd:documentation>Method for Selecting Alternative Bills of Material</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""KZAUS"">
                            <xsd:annotation>
                              <xsd:documentation>Discontinuation indicator</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""AUSDT"">
                            <xsd:annotation>
                              <xsd:documentation>Effective-Out Date</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""8"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""NFMAT"">
                            <xsd:annotation>
                              <xsd:documentation>Follow-Up Material</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""18"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""KZBED"">
                            <xsd:annotation>
                              <xsd:documentation>Indicator for Requirements Grouping</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""MISKZ"">
                            <xsd:annotation>
                              <xsd:documentation>Mixed MRP indicator</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""FHORI"">
                            <xsd:annotation>
                              <xsd:documentation>Scheduling Margin Key for Floats</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""3"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""PFREI"">
                            <xsd:annotation>
                              <xsd:documentation>Indicator: automatic fixing of planned orders</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""FFREI"">
                            <xsd:annotation>
                              <xsd:documentation>Release indicator for production orders</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""RGEKZ"">
                            <xsd:annotation>
                              <xsd:documentation>Indicator: Backflush</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""FEVOR"">
                            <xsd:annotation>
                              <xsd:documentation>Production scheduler</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""3"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""BEARZ"">
                            <xsd:annotation>
                              <xsd:documentation>Processing time</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""6"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""RUEZT"">
                            <xsd:annotation>
                              <xsd:documentation>Setup and teardown time</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""6"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""TRANZ"">
                            <xsd:annotation>
                              <xsd:documentation>Interoperation time</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""6"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""BASMG"">
                            <xsd:annotation>
                              <xsd:documentation>Base quantity</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""14"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""DZEIT"">
                            <xsd:annotation>
                              <xsd:documentation>In-house production time</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""3"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""MAXLZ"">
                            <xsd:annotation>
                              <xsd:documentation>Maximum storage period</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""5"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""LZEIH"">
                            <xsd:annotation>
                              <xsd:documentation>Unit for maximum storage period</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""3"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""KZPRO"">
                            <xsd:annotation>
                              <xsd:documentation>Indicator: withdrawal of stock from production bin</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""GPMKZ"">
                            <xsd:annotation>
                              <xsd:documentation>Indicator: Material Included in Rough-Cut Planning</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""UEETO"">
                            <xsd:annotation>
                              <xsd:documentation>Overdelivery tolerance limit</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""4"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""UEETK"">
                            <xsd:annotation>
                              <xsd:documentation>Indicator: Unlimited Overdelivery Allowed</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""UNETO"">
                            <xsd:annotation>
                              <xsd:documentation>Underdelivery tolerance limit</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""4"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""WZEIT"">
                            <xsd:annotation>
                              <xsd:documentation>Total replenishment lead time (in workdays)</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""3"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""ATPKZ"">
                            <xsd:annotation>
                              <xsd:documentation>Replacement part</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""VZUSL"">
                            <xsd:annotation>
                              <xsd:documentation>Surcharge factor for cost in percent</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""5"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""HERBL"">
                            <xsd:annotation>
                              <xsd:documentation>State of manufacture</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""2"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""INSMK"">
                            <xsd:annotation>
                              <xsd:documentation>Post to Inspection Stock</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""SSQSS"">
                            <xsd:annotation>
                              <xsd:documentation>QA Control Key</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""8"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""KZDKZ"">
                            <xsd:annotation>
                              <xsd:documentation>Documentation required indicator</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""UMLMC"">
                            <xsd:annotation>
                              <xsd:documentation>Stock in Transfer (Plant to Plant)</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""14"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""LADGR"">
                            <xsd:annotation>
                              <xsd:documentation>Loading Group</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""4"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""XCHPF"">
                            <xsd:annotation>
                              <xsd:documentation>Batch management requirement indicator</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""USEQU"">
                            <xsd:annotation>
                              <xsd:documentation>Quota arrangement usage</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""LGRAD"">
                            <xsd:annotation>
                              <xsd:documentation>Service level</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""4"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""AUFTL"">
                            <xsd:annotation>
                              <xsd:documentation>Splitting Indicator</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""PLVAR"">
                            <xsd:annotation>
                              <xsd:documentation>Plan Version</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""2"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""OTYPE"">
                            <xsd:annotation>
                              <xsd:documentation>Object Type</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""2"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""OBJID"">
                            <xsd:annotation>
                              <xsd:documentation>Object ID</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""8"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""MTVFP"">
                            <xsd:annotation>
                              <xsd:documentation>Checking Group for Availability Check</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""2"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""PERIV"">
                            <xsd:annotation>
                              <xsd:documentation>Fiscal Year Variant</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""2"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""KZKFK"">
                            <xsd:annotation>
                              <xsd:documentation>Indicator: take correction factors into account</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""VRVEZ"">
                            <xsd:annotation>
                              <xsd:documentation>Shipping setup time</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""6"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""VBAMG"">
                            <xsd:annotation>
                              <xsd:documentation>Base quantity for capacity planning in shipping</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""14"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""VBEAZ"">
                            <xsd:annotation>
                              <xsd:documentation>Shipping processing time</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""6"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""LIZYK"">
                            <xsd:annotation>
                              <xsd:documentation>Delivery cycle</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""4"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""BWSCL"">
                            <xsd:annotation>
                              <xsd:documentation>Source of Supply</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""KAUTB"">
                            <xsd:annotation>
                              <xsd:documentation>Indicator: ""automatic purchase order allowed""</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""KORDB"">
                            <xsd:annotation>
                              <xsd:documentation>Indicator: Source list requirement</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""STAWN"">
                            <xsd:annotation>
                              <xsd:documentation>Commodity Code/Import Code Number for Foreign Trade</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""17"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""HERKL"">
                            <xsd:annotation>
                              <xsd:documentation>Country of origin of the material</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""3"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""HERKR"">
                            <xsd:annotation>
                              <xsd:documentation>Region of origin of material (non-preferential origin)</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""3"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""EXPME"">
                            <xsd:annotation>
                              <xsd:documentation>Unit of measure for commodity code (foreign trade)</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""3"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""MTVER"">
                            <xsd:annotation>
                              <xsd:documentation>Export/import material group</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""4"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""PRCTR"">
                            <xsd:annotation>
                              <xsd:documentation>Profit Center</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""10"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""TRAME"">
                            <xsd:annotation>
                              <xsd:documentation>Stock in Transit</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""15"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""MRPPP"">
                            <xsd:annotation>
                              <xsd:documentation>PPC planning calendar</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""3"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""SAUFT"">
                            <xsd:annotation>
                              <xsd:documentation>Ind.: Repetitive mfg allowed</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""FXHOR"">
                            <xsd:annotation>
                              <xsd:documentation>Planning time fence</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""3"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""VRMOD"">
                            <xsd:annotation>
                              <xsd:documentation>Consumption mode</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""VINT1"">
                            <xsd:annotation>
                              <xsd:documentation>Consumption period: backward</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""3"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""VINT2"">
                            <xsd:annotation>
                              <xsd:documentation>Consumption period: forward</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""3"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""STLAL"">
                            <xsd:annotation>
                              <xsd:documentation>Alternative BOM</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""2"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""STLAN"">
                            <xsd:annotation>
                              <xsd:documentation>BOM Usage</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""PLNNR"">
                            <xsd:annotation>
                              <xsd:documentation>Key for Task List Group</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""8"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""APLAL"">
                            <xsd:annotation>
                              <xsd:documentation>Group Counter</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""2"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""LOSGR"">
                            <xsd:annotation>
                              <xsd:documentation>Lot Size for Product Costing</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""14"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""SOBSK"">
                            <xsd:annotation>
                              <xsd:documentation>Special Procurement Type for Costing</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""2"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""FRTME"">
                            <xsd:annotation>
                              <xsd:documentation>Production unit</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""3"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""LGPRO"">
                            <xsd:annotation>
                              <xsd:documentation>Issue Storage Location</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""4"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""DISGR"">
                            <xsd:annotation>
                              <xsd:documentation>MRP Group</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""4"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""KAUSF"">
                            <xsd:annotation>
                              <xsd:documentation>Component scrap in percent</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""5"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""QZGTP"">
                            <xsd:annotation>
                              <xsd:documentation>Certificate Type</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""4"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""TAKZT"">
                            <xsd:annotation>
                              <xsd:documentation>Takt time</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""3"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""RWPRO"">
                            <xsd:annotation>
                              <xsd:documentation>Range of coverage profile</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""3"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""COPAM"">
                            <xsd:annotation>
                              <xsd:documentation>Local field name for CO/PA link to SOP</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""10"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""ABCIN"">
                            <xsd:annotation>
                              <xsd:documentation>Physical inventory indicator for cycle counting</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""AWSLS"">
                            <xsd:annotation>
                              <xsd:documentation>Variance Key</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""6"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""SERNP"">
                            <xsd:annotation>
                              <xsd:documentation>Serial Number Profile</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""4"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""STDPD"">
                            <xsd:annotation>
                              <xsd:documentation>Configurable material</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""18"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""SFEPR"">
                            <xsd:annotation>
                              <xsd:documentation>Repetitive manufacturing profile</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""4"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""XMCNG"">
                            <xsd:annotation>
                              <xsd:documentation>Negative stocks allowed in plant</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""QSSYS"">
                            <xsd:annotation>
                              <xsd:documentation>Required QM System for Vendor</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""4"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""LFRHY"">
                            <xsd:annotation>
                              <xsd:documentation>Planning cycle</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""3"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""RDPRF"">
                            <xsd:annotation>
                              <xsd:documentation>Rounding Profile</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""4"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""VRBMT"">
                            <xsd:annotation>
                              <xsd:documentation>Reference material for consumption</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""18"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""VRBWK"">
                            <xsd:annotation>
                              <xsd:documentation>Reference plant for consumption</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""4"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""VRBDT"">
                            <xsd:annotation>
                              <xsd:documentation>To date of the material to be copied for consumption</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""8"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""VRBFK"">
                            <xsd:annotation>
                              <xsd:documentation>Multiplier for reference material for consumption</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""5"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""AUTRU"">
                            <xsd:annotation>
                              <xsd:documentation>Reset Forecast Model Automatically</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""PREFE"">
                            <xsd:annotation>
                              <xsd:documentation>Preference indicator in export/import</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""PRENC"">
                            <xsd:annotation>
                              <xsd:documentation>Exemption certificate: Indicator for legal control</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""PRENO"">
                            <xsd:annotation>
                              <xsd:documentation>Number of exemption certificate in export/import</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""8"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""PREND"">
                            <xsd:annotation>
                              <xsd:documentation>Exemption certificate: Issue date of exemption certificate</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""8"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""PRENE"">
                            <xsd:annotation>
                              <xsd:documentation>Indicator: Vendor declaration exists</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""PRENG"">
                            <xsd:annotation>
                              <xsd:documentation>Validity date of vendor declaration</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""8"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""ITARK"">
                            <xsd:annotation>
                              <xsd:documentation>Indicator: Military goods</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""PRFRQ"">
                            <xsd:annotation>
                              <xsd:documentation>Character Field With Field Length 7</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""7"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""KZKUP"">
                            <xsd:annotation>
                              <xsd:documentation>Indicator: Material can be co-product</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""STRGR"">
                            <xsd:annotation>
                              <xsd:documentation>Planning strategy group</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""2"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""LGFSB"">
                            <xsd:annotation>
                              <xsd:documentation>Default storage location for external procurement</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""4"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""SCHGT"">
                            <xsd:annotation>
                              <xsd:documentation>Indicator: Bulk Material</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""CCFIX"">
                            <xsd:annotation>
                              <xsd:documentation>CC indicator is fixed</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""EPRIO"">
                            <xsd:annotation>
                              <xsd:documentation>Withdrawal sequence group for stocks</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""4"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""QMATA"">
                            <xsd:annotation>
                              <xsd:documentation>Material Authorization Group for Activities in QM</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""6"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""PLNTY"">
                            <xsd:annotation>
                              <xsd:documentation>Task List Type</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""MMSTA"">
                            <xsd:annotation>
                              <xsd:documentation>Plant-Specific Material Status</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""2"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""SFCPF"">
                            <xsd:annotation>
                              <xsd:documentation>Production Scheduling Profile</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""6"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""SHFLG"">
                            <xsd:annotation>
                              <xsd:documentation>Safety time indicator (with or without safety time)</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""SHZET"">
                            <xsd:annotation>
                              <xsd:documentation>Safety time (in workdays)</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""2"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""MDACH"">
                            <xsd:annotation>
                              <xsd:documentation>Action control: planned order processing</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""2"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""KZECH"">
                            <xsd:annotation>
                              <xsd:documentation>Determination of batch entry in the production/process order</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""MMSTD"">
                            <xsd:annotation>
                              <xsd:documentation>Date from which the plant-specific material status is valid</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""8"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""MFRGR"">
                            <xsd:annotation>
                              <xsd:documentation>Material freight group</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""8"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""FVIDK"">
                            <xsd:annotation>
                              <xsd:documentation>Production Version To Be Costed</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""4"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""INDUS"">
                            <xsd:annotation>
                              <xsd:documentation>Material CFOP category</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""2"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""MOWNR"">
                            <xsd:annotation>
                              <xsd:documentation>CAP: Number of CAP products list</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""12"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""MOGRU"">
                            <xsd:annotation>
                              <xsd:documentation>Common Agricultural Policy: CAP products group-Foreign Trade</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""6"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""CASNR"">
                            <xsd:annotation>
                              <xsd:documentation>CAS number for pharmaceutical products in foreign trade</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""15"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""GPNUM"">
                            <xsd:annotation>
                              <xsd:documentation>Production statistics: PRODCOM number for foreign trade</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""9"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""STEUC"">
                            <xsd:annotation>
                              <xsd:documentation>Control code for consumption taxes in foreign trade</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""16"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""FABKZ"">
                            <xsd:annotation>
                              <xsd:documentation>Indicator: Item Relevant to JIT Delivery Schedules</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""MATGR"">
                            <xsd:annotation>
                              <xsd:documentation>Group of Materials for Transition Matrix</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""20"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""LOGGR"">
                            <xsd:annotation>
                              <xsd:documentation>Logistics handling group for workload calculation</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""4"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""VSPVB"">
                            <xsd:annotation>
                              <xsd:documentation>Proposed Supply Area in Material Master Record</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""10"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""DPLFS"">
                            <xsd:annotation>
                              <xsd:documentation>Fair share rule</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""2"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""DPLPU"">
                            <xsd:annotation>
                              <xsd:documentation>Indicator: push distribution</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""DPLHO"">
                            <xsd:annotation>
                              <xsd:documentation>Deployment horizon in days</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""4"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""MINLS"">
                            <xsd:annotation>
                              <xsd:documentation>Minimum lot size for Supply Demand Match</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""15"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""MAXLS"">
                            <xsd:annotation>
                              <xsd:documentation>Maximum lot size for Supply Demand Match</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""15"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""FIXLS"">
                            <xsd:annotation>
                              <xsd:documentation>Fixed lot size for Supply Demand Match</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""15"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""LTINC"">
                            <xsd:annotation>
                              <xsd:documentation>Lot size increment for  Supply Demand Match</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""15"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""COMPL"">
                            <xsd:annotation>
                              <xsd:documentation>Material completion level</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""2"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""CONVT"">
                            <xsd:annotation>
                              <xsd:documentation>Conversion types for production figures</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""2"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""FPRFM"">
                            <xsd:annotation>
                              <xsd:documentation>Distribution profile of material in plant</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""3"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""SHPRO"">
                            <xsd:annotation>
                              <xsd:documentation>Period Profile for Safety Time</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""3"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""FXPRU"">
                            <xsd:annotation>
                              <xsd:documentation>Fixed-Price Co-Product</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""KZPSP"">
                            <xsd:annotation>
                              <xsd:documentation>Indicator for cross-project material</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""OCMPF"">
                            <xsd:annotation>
                              <xsd:documentation>Profile for OCM PP / PS</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""6"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""APOKZ"">
                            <xsd:annotation>
                              <xsd:documentation>Indicator: Is material relevant for APO</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""AHDIS"">
                            <xsd:annotation>
                              <xsd:documentation>MRP relevancy for dependent requirements</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""EISLO"">
                            <xsd:annotation>
                              <xsd:documentation>Minimum Safety Stock</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""15"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""NCOST"">
                            <xsd:annotation>
                              <xsd:documentation>Do Not Cost</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""MEGRU"">
                            <xsd:annotation>
                              <xsd:documentation>Unit of Measure Group</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""4"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""ROTATION_DATE"">
                            <xsd:annotation>
                              <xsd:documentation>Strategy for Putaway and Stock Removal</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""UCHKZ"">
                            <xsd:annotation>
                              <xsd:documentation>Indicator for Original Batch Management</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""UCMAT"">
                            <xsd:annotation>
                              <xsd:documentation>Reference Material for Original Batches</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""18"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""E1MARC1"">
                            <xsd:annotation>
                              <xsd:documentation>Additional Fields for E1MARCM</xsd:documentation>
                            </xsd:annotation>
                            <xsd:complexType>
                              <xsd:sequence>
                                <xsd:element minOccurs=""0"" name=""NFMAT_EXTERNAL"">
                                  <xsd:annotation>
                                    <xsd:documentation>Long Material Number for Field NFMAT</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""40"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""NFMAT_VERSION"">
                                  <xsd:annotation>
                                    <xsd:documentation>Version Number for Field NFMAT</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""10"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""NFMAT_GUID"">
                                  <xsd:annotation>
                                    <xsd:documentation>External GUID for Field NFMAT</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""32"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""STDPD_EXTERNAL"">
                                  <xsd:annotation>
                                    <xsd:documentation>Long Material Number for Field STDPD</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""40"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""STDPD_VERSION"">
                                  <xsd:annotation>
                                    <xsd:documentation>Version Number for Field STDPD</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""10"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""STDPD_GUID"">
                                  <xsd:annotation>
                                    <xsd:documentation>External GUID for Field STDPD</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""32"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""VRBMT_EXTERNAL"">
                                  <xsd:annotation>
                                    <xsd:documentation>Long Material Number for Field VRBMT</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""40"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""VRBMT_VERSION"">
                                  <xsd:annotation>
                                    <xsd:documentation>Version Number for Field VRBMT</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""10"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""VRBMT_GUID"">
                                  <xsd:annotation>
                                    <xsd:documentation>External GUID for Field VRBMT</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""32"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                              </xsd:sequence>
                              <xsd:attribute name=""SEGMENT"" use=""required"">
                                <xsd:simpleType>
                                  <xsd:restriction base=""xsd:string"">
                                    <xsd:enumeration value=""1"" />
                                  </xsd:restriction>
                                </xsd:simpleType>
                              </xsd:attribute>
                            </xsd:complexType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" maxOccurs=""9999"" name=""E1MARDM"">
                            <xsd:annotation>
                              <xsd:documentation>Master material warehouse/batch segment (MARD)</xsd:documentation>
                            </xsd:annotation>
                            <xsd:complexType>
                              <xsd:sequence>
                                <xsd:element minOccurs=""0"" name=""MSGFN"">
                                  <xsd:annotation>
                                    <xsd:documentation>Function</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""3"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""LGORT"">
                                  <xsd:annotation>
                                    <xsd:documentation>Storage Location</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""4"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""PSTAT"">
                                  <xsd:annotation>
                                    <xsd:documentation>Maintenance status</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""15"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""LVORM"">
                                  <xsd:annotation>
                                    <xsd:documentation>Flag Material for Deletion at Storage Location Level</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""1"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""DISKZ"">
                                  <xsd:annotation>
                                    <xsd:documentation>Storage location MRP indicator</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""1"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""LSOBS"">
                                  <xsd:annotation>
                                    <xsd:documentation>Special procurement type</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""2"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""LMINB"">
                                  <xsd:annotation>
                                    <xsd:documentation>Reorder point for storage location MRP</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""14"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""LBSTF"">
                                  <xsd:annotation>
                                    <xsd:documentation>Replenishment quantity for storage location MRP</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""14"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""HERKL"">
                                  <xsd:annotation>
                                    <xsd:documentation>Country of origin of the material</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""3"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""EXPPG"">
                                  <xsd:annotation>
                                    <xsd:documentation>Preference indicator (deactivated)</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""1"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""EXVER"">
                                  <xsd:annotation>
                                    <xsd:documentation>Export indicator (deactivated)</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""2"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""LGPBE"">
                                  <xsd:annotation>
                                    <xsd:documentation>Storage Bin</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""10"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""PRCTL"">
                                  <xsd:annotation>
                                    <xsd:documentation>Profit Center</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""10"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""LWMKB"">
                                  <xsd:annotation>
                                    <xsd:documentation>Picking area for lean WM</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""3"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""BSKRF"">
                                  <xsd:annotation>
                                    <xsd:documentation>Inventory correction factor</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""24"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                              </xsd:sequence>
                              <xsd:attribute name=""SEGMENT"" use=""required"">
                                <xsd:simpleType>
                                  <xsd:restriction base=""xsd:string"">
                                    <xsd:enumeration value=""1"" />
                                  </xsd:restriction>
                                </xsd:simpleType>
                              </xsd:attribute>
                            </xsd:complexType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""E1MFHMM"">
                            <xsd:annotation>
                              <xsd:documentation>Master material production resource/tool (MFHM)</xsd:documentation>
                            </xsd:annotation>
                            <xsd:complexType>
                              <xsd:sequence>
                                <xsd:element minOccurs=""0"" name=""MSGFN"">
                                  <xsd:annotation>
                                    <xsd:documentation>Function</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""3"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""OBJTY"">
                                  <xsd:annotation>
                                    <xsd:documentation>Object types of the CIM resource</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""2"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""OBJID"">
                                  <xsd:annotation>
                                    <xsd:documentation>Object ID of the resource</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""8"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""ZAEHL"">
                                  <xsd:annotation>
                                    <xsd:documentation>Internal counter</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""8"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""OBJTY_V"">
                                  <xsd:annotation>
                                    <xsd:documentation>Object types of the CIM resource</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""2"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""OBJID_V"">
                                  <xsd:annotation>
                                    <xsd:documentation>Object ID of the resource</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""8"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""KZKBL"">
                                  <xsd:annotation>
                                    <xsd:documentation>Indicator: Create load records for prod. resources/tools</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""1"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""STEUF"">
                                  <xsd:annotation>
                                    <xsd:documentation>Control key for management of production resources/tools</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""4"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""STEUF_REF"">
                                  <xsd:annotation>
                                    <xsd:documentation>Control key cannot be changed</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""1"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""FGRU1"">
                                  <xsd:annotation>
                                    <xsd:documentation>Grouping key 1 for production resources/tools</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""4"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""FGRU2"">
                                  <xsd:annotation>
                                    <xsd:documentation>Grouping key 2 for production resources/tools</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""4"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""PLANV"">
                                  <xsd:annotation>
                                    <xsd:documentation>Production resource/tool usage</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""3"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""KTSCH"">
                                  <xsd:annotation>
                                    <xsd:documentation>Standard text key for production resources/tools</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""7"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""KTSCH_REF"">
                                  <xsd:annotation>
                                    <xsd:documentation>Reference Key Cannot be Changed</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""1"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""BZOFFB"">
                                  <xsd:annotation>
                                    <xsd:documentation>Reference date to start of production resource/tool usage</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""2"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""BZOFFB_REF"">
                                  <xsd:annotation>
                                    <xsd:documentation>Offset to start cannot be changed</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""1"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""OFFSTB"">
                                  <xsd:annotation>
                                    <xsd:documentation>Offset to start of production resource/tool usage</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""7"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""EHOFFB"">
                                  <xsd:annotation>
                                    <xsd:documentation>Offset unit for start of prod. resource/tool usage</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""3"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""OFFSTB_REF"">
                                  <xsd:annotation>
                                    <xsd:documentation>Offset to start cannot be changed</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""1"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""BZOFFE"">
                                  <xsd:annotation>
                                    <xsd:documentation>Reference date for end of production resource/tool usage</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""2"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""BZOFFE_REF"">
                                  <xsd:annotation>
                                    <xsd:documentation>End reference date cannot be changed</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""1"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""OFFSTE"">
                                  <xsd:annotation>
                                    <xsd:documentation>Offset to finish of production resource/tool usage</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""7"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""EHOFFE"">
                                  <xsd:annotation>
                                    <xsd:documentation>Offset unit for end of production resource/tool usage</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""3"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""OFFSTE_REF"">
                                  <xsd:annotation>
                                    <xsd:documentation>Offset to end cannot be changed</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""1"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""MGFORM"">
                                  <xsd:annotation>
                                    <xsd:documentation>Formula for calculating the total quantity of PRT</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""6"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""MGFORM_REF"">
                                  <xsd:annotation>
                                    <xsd:documentation>Formula for calculating the total quantity cannot be changed</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""1"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""EWFORM"">
                                  <xsd:annotation>
                                    <xsd:documentation>Formula for calculating the total usage value of PRT</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""6"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""EWFORM_REF"">
                                  <xsd:annotation>
                                    <xsd:documentation>Formula to calculate entire usage value cannot be changed</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""1"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""PAR01"">
                                  <xsd:annotation>
                                    <xsd:documentation>First parameter (for formulas)</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""6"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""PAR02"">
                                  <xsd:annotation>
                                    <xsd:documentation>Second parameter (for formulas)</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""6"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""PAR03"">
                                  <xsd:annotation>
                                    <xsd:documentation>Third parameter (for formulas)</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""6"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""PAR04"">
                                  <xsd:annotation>
                                    <xsd:documentation>Fourth parameter (for formulas)</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""6"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""PAR05"">
                                  <xsd:annotation>
                                    <xsd:documentation>Fifth parameter (for formulas)</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""6"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""PAR06"">
                                  <xsd:annotation>
                                    <xsd:documentation>Sixth parameter (for formulas)</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""6"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""PARU1"">
                                  <xsd:annotation>
                                    <xsd:documentation>Parameter unit</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""3"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""PARU2"">
                                  <xsd:annotation>
                                    <xsd:documentation>Parameter unit</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""3"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""PARU3"">
                                  <xsd:annotation>
                                    <xsd:documentation>Parameter unit</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""3"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""PARU4"">
                                  <xsd:annotation>
                                    <xsd:documentation>Parameter unit</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""3"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""PARU5"">
                                  <xsd:annotation>
                                    <xsd:documentation>Parameter unit</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""3"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""PARU6"">
                                  <xsd:annotation>
                                    <xsd:documentation>Parameter unit</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""3"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""PARV1"">
                                  <xsd:annotation>
                                    <xsd:documentation>Parameter value</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""11"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""PARV2"">
                                  <xsd:annotation>
                                    <xsd:documentation>Parameter value</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""11"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""PARV3"">
                                  <xsd:annotation>
                                    <xsd:documentation>Parameter value</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""11"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""PARV4"">
                                  <xsd:annotation>
                                    <xsd:documentation>Parameter value</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""11"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""PARV5"">
                                  <xsd:annotation>
                                    <xsd:documentation>Parameter value</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""11"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""PARV6"">
                                  <xsd:annotation>
                                    <xsd:documentation>Parameter value</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""11"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                              </xsd:sequence>
                              <xsd:attribute name=""SEGMENT"" use=""required"">
                                <xsd:simpleType>
                                  <xsd:restriction base=""xsd:string"">
                                    <xsd:enumeration value=""1"" />
                                  </xsd:restriction>
                                </xsd:simpleType>
                              </xsd:attribute>
                            </xsd:complexType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""E1MPGDM"">
                            <xsd:annotation>
                              <xsd:documentation>Master material product group</xsd:documentation>
                            </xsd:annotation>
                            <xsd:complexType>
                              <xsd:sequence>
                                <xsd:element minOccurs=""0"" name=""MSGFN"">
                                  <xsd:annotation>
                                    <xsd:documentation>Function</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""3"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""PRGRP"">
                                  <xsd:annotation>
                                    <xsd:documentation>Planning material</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""18"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""PRWRK"">
                                  <xsd:annotation>
                                    <xsd:documentation>Planning plant</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""4"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""UMREF"">
                                  <xsd:annotation>
                                    <xsd:documentation>Conv. factor f. plng material</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""10"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""PRGRP_EXTERNAL"">
                                  <xsd:annotation>
                                    <xsd:documentation>Name of Product Group</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""40"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""PRGRP_VERSION"">
                                  <xsd:annotation>
                                    <xsd:documentation>Version Number for Field PRGRP</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""10"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""PRGRP_GUID"">
                                  <xsd:annotation>
                                    <xsd:documentation>External GUID for Field PRGRP</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""32"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                              </xsd:sequence>
                              <xsd:attribute name=""SEGMENT"" use=""required"">
                                <xsd:simpleType>
                                  <xsd:restriction base=""xsd:string"">
                                    <xsd:enumeration value=""1"" />
                                  </xsd:restriction>
                                </xsd:simpleType>
                              </xsd:attribute>
                            </xsd:complexType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""E1MPOPM"">
                            <xsd:annotation>
                              <xsd:documentation>Master material forecast parameter</xsd:documentation>
                            </xsd:annotation>
                            <xsd:complexType>
                              <xsd:sequence>
                                <xsd:element minOccurs=""0"" name=""MSGFN"">
                                  <xsd:annotation>
                                    <xsd:documentation>Function</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""3"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""VERSP"">
                                  <xsd:annotation>
                                    <xsd:documentation>Version number of forecast parameters</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""2"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""PROPR"">
                                  <xsd:annotation>
                                    <xsd:documentation>Forecast profile</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""4"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""MODAW"">
                                  <xsd:annotation>
                                    <xsd:documentation>Model Selection Indicator</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""1"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""MODAV"">
                                  <xsd:annotation>
                                    <xsd:documentation>Model selection procedure</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""1"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""KZPAR"">
                                  <xsd:annotation>
                                    <xsd:documentation>Indicator for parameter optimization</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""1"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""OPGRA"">
                                  <xsd:annotation>
                                    <xsd:documentation>Optimization level</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""1"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""KZINI"">
                                  <xsd:annotation>
                                    <xsd:documentation>Initialization indicator</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""1"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""PRMOD"">
                                  <xsd:annotation>
                                    <xsd:documentation>Forecast model</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""1"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""ALPHA"">
                                  <xsd:annotation>
                                    <xsd:documentation>Basic value smoothing using alpha factor</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""5"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""BETA1"">
                                  <xsd:annotation>
                                    <xsd:documentation>Trend value smoothing using the beta factor</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""5"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""GAMMA"">
                                  <xsd:annotation>
                                    <xsd:documentation>Seasonal index smoothing using gamma factor</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""5"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""DELTA"">
                                  <xsd:annotation>
                                    <xsd:documentation>MAD (mean absolute deviation) smoothing using delta factor</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""5"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""EPSIL"">
                                  <xsd:annotation>
                                    <xsd:documentation>Epsilon factor</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""5"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""SIGGR"">
                                  <xsd:annotation>
                                    <xsd:documentation>Tracking limit</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""7"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""PERKZ"">
                                  <xsd:annotation>
                                    <xsd:documentation>Period Indicator</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""1"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""PRDAT"">
                                  <xsd:annotation>
                                    <xsd:documentation>Date of last forecast</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""8"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""PERAN"">
                                  <xsd:annotation>
                                    <xsd:documentation>Number of historical periods</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""5"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""PERIN"">
                                  <xsd:annotation>
                                    <xsd:documentation>Number of periods for initialization</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""5"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""PERIO"">
                                  <xsd:annotation>
                                    <xsd:documentation>Number of periods per seasonal cycle</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""5"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""PEREX"">
                                  <xsd:annotation>
                                    <xsd:documentation>Number of periods for ex-post forecasting</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""5"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""ANZPR"">
                                  <xsd:annotation>
                                    <xsd:documentation>Number of forecast periods</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""5"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""FIMON"">
                                  <xsd:annotation>
                                    <xsd:documentation>Fixed periods</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""5"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""GWERT"">
                                  <xsd:annotation>
                                    <xsd:documentation>Basic value</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""15"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""GWER1"">
                                  <xsd:annotation>
                                    <xsd:documentation>Basic value of the 2nd order</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""15"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""GWER2"">
                                  <xsd:annotation>
                                    <xsd:documentation>Basic value of the 2nd order</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""15"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""VMGWE"">
                                  <xsd:annotation>
                                    <xsd:documentation>Basic value of previous period</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""15"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""VMGW1"">
                                  <xsd:annotation>
                                    <xsd:documentation>Base value of the second order in previous period</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""15"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""VMGW2"">
                                  <xsd:annotation>
                                    <xsd:documentation>Base value of the second order in previous period</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""15"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""TWERT"">
                                  <xsd:annotation>
                                    <xsd:documentation>Trend value</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""15"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""VMTWE"">
                                  <xsd:annotation>
                                    <xsd:documentation>Trend value of previous period</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""15"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""PRMAD"">
                                  <xsd:annotation>
                                    <xsd:documentation>Mean absolute deviation (MAD)</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""15"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""VMMAD"">
                                  <xsd:annotation>
                                    <xsd:documentation>Mean absolute devaition of previous period</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""15"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""FSUMM"">
                                  <xsd:annotation>
                                    <xsd:documentation>Error total</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""15"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""VMFSU"">
                                  <xsd:annotation>
                                    <xsd:documentation>Error total for the previous period</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""15"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""GEWGR"">
                                  <xsd:annotation>
                                    <xsd:documentation>Weighting group</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""2"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""THKOF"">
                                  <xsd:annotation>
                                    <xsd:documentation>Theil coefficient</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""7"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""AUSNA"">
                                  <xsd:annotation>
                                    <xsd:documentation>Exception message bar</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""30"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""PROAB"">
                                  <xsd:annotation>
                                    <xsd:documentation>Forecast flow control</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""10"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                              </xsd:sequence>
                              <xsd:attribute name=""SEGMENT"" use=""required"">
                                <xsd:simpleType>
                                  <xsd:restriction base=""xsd:string"">
                                    <xsd:enumeration value=""1"" />
                                  </xsd:restriction>
                                </xsd:simpleType>
                              </xsd:attribute>
                            </xsd:complexType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" maxOccurs=""999999"" name=""E1MPRWM"">
                            <xsd:annotation>
                              <xsd:documentation>Master material forecast value</xsd:documentation>
                            </xsd:annotation>
                            <xsd:complexType>
                              <xsd:sequence>
                                <xsd:element minOccurs=""0"" name=""MSGFN"">
                                  <xsd:annotation>
                                    <xsd:documentation>Function</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""3"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""ERTAG"">
                                  <xsd:annotation>
                                    <xsd:documentation>First day of the period to which the values refer</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""8"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""PRWRT"">
                                  <xsd:annotation>
                                    <xsd:documentation>Forecast value</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""15"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""KOPRW"">
                                  <xsd:annotation>
                                    <xsd:documentation>Corrected value for forecast</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""15"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""SAIIN"">
                                  <xsd:annotation>
                                    <xsd:documentation>Seasonal index</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""7"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""FIXKZ"">
                                  <xsd:annotation>
                                    <xsd:documentation>Indicator: consumption value is fixed</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""1"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""EXPRW"">
                                  <xsd:annotation>
                                    <xsd:documentation>Ex-post forecast value</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""15"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""ANTEI"">
                                  <xsd:annotation>
                                    <xsd:documentation>Ratio of the corrected value to the original value (CV:OV)</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""6"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                              </xsd:sequence>
                              <xsd:attribute name=""SEGMENT"" use=""required"">
                                <xsd:simpleType>
                                  <xsd:restriction base=""xsd:string"">
                                    <xsd:enumeration value=""1"" />
                                  </xsd:restriction>
                                </xsd:simpleType>
                              </xsd:attribute>
                            </xsd:complexType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" maxOccurs=""999999"" name=""E1MVEGM"">
                            <xsd:annotation>
                              <xsd:documentation>Master material total consumption</xsd:documentation>
                            </xsd:annotation>
                            <xsd:complexType>
                              <xsd:sequence>
                                <xsd:element minOccurs=""0"" name=""MSGFN"">
                                  <xsd:annotation>
                                    <xsd:documentation>Function</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""3"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""ERTAG"">
                                  <xsd:annotation>
                                    <xsd:documentation>First day of the period to which the values refer</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""8"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""VBWRT"">
                                  <xsd:annotation>
                                    <xsd:documentation>Consumption value</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""15"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""KOVBW"">
                                  <xsd:annotation>
                                    <xsd:documentation>Corrected consumption value</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""15"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""KZEXI"">
                                  <xsd:annotation>
                                    <xsd:documentation>Checkbox</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""1"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""ANTEI"">
                                  <xsd:annotation>
                                    <xsd:documentation>Ratio of the corrected value to the original value (CV:OV)</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""6"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                              </xsd:sequence>
                              <xsd:attribute name=""SEGMENT"" use=""required"">
                                <xsd:simpleType>
                                  <xsd:restriction base=""xsd:string"">
                                    <xsd:enumeration value=""1"" />
                                  </xsd:restriction>
                                </xsd:simpleType>
                              </xsd:attribute>
                            </xsd:complexType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" maxOccurs=""999999"" name=""E1MVEUM"">
                            <xsd:annotation>
                              <xsd:documentation>Master material unplanned consumption</xsd:documentation>
                            </xsd:annotation>
                            <xsd:complexType>
                              <xsd:sequence>
                                <xsd:element minOccurs=""0"" name=""MSGFN"">
                                  <xsd:annotation>
                                    <xsd:documentation>Function</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""3"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""ERTAG"">
                                  <xsd:annotation>
                                    <xsd:documentation>First day of the period to which the values refer</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""8"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""VBWRT"">
                                  <xsd:annotation>
                                    <xsd:documentation>Consumption value</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""15"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""KOVBW"">
                                  <xsd:annotation>
                                    <xsd:documentation>Corrected consumption value</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""15"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""KZEXI"">
                                  <xsd:annotation>
                                    <xsd:documentation>Checkbox</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""1"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""ANTEI"">
                                  <xsd:annotation>
                                    <xsd:documentation>Ratio of the corrected value to the original value (CV:OV)</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""6"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                              </xsd:sequence>
                              <xsd:attribute name=""SEGMENT"" use=""required"">
                                <xsd:simpleType>
                                  <xsd:restriction base=""xsd:string"">
                                    <xsd:enumeration value=""1"" />
                                  </xsd:restriction>
                                </xsd:simpleType>
                              </xsd:attribute>
                            </xsd:complexType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" maxOccurs=""999999"" name=""E1MKALM"">
                            <xsd:annotation>
                              <xsd:documentation>Master material production version</xsd:documentation>
                            </xsd:annotation>
                            <xsd:complexType>
                              <xsd:sequence>
                                <xsd:element minOccurs=""0"" name=""MSGFN"">
                                  <xsd:annotation>
                                    <xsd:documentation>Function</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""3"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""VERID"">
                                  <xsd:annotation>
                                    <xsd:documentation>Production Version</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""4"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""BDATU"">
                                  <xsd:annotation>
                                    <xsd:documentation>Run-time end: production version</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""8"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""ADATU"">
                                  <xsd:annotation>
                                    <xsd:documentation>Valid-from date of production version</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""8"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""STLAL"">
                                  <xsd:annotation>
                                    <xsd:documentation>Alternative BOM</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""2"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""STLAN"">
                                  <xsd:annotation>
                                    <xsd:documentation>BOM Usage</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""1"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""PLNTY"">
                                  <xsd:annotation>
                                    <xsd:documentation>Task List Type</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""1"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""PLNNR"">
                                  <xsd:annotation>
                                    <xsd:documentation>Key for Task List Group</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""8"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""ALNAL"">
                                  <xsd:annotation>
                                    <xsd:documentation>Group Counter</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""2"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""BESKZ"">
                                  <xsd:annotation>
                                    <xsd:documentation>Procurement Type</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""1"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""SOBSL"">
                                  <xsd:annotation>
                                    <xsd:documentation>Special procurement type</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""2"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""LOSGR"">
                                  <xsd:annotation>
                                    <xsd:documentation>Lot Size for Product Costing</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""15"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""MDV01"">
                                  <xsd:annotation>
                                    <xsd:documentation>Aggregation field for production versions</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""8"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""MDV02"">
                                  <xsd:annotation>
                                    <xsd:documentation>Aggregation field for production versions</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""8"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""TEXT1"">
                                  <xsd:annotation>
                                    <xsd:documentation>Short text on the production version</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""40"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""EWAHR"">
                                  <xsd:annotation>
                                    <xsd:documentation>Usage Probability with Version Control</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""5"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""VERTO"">
                                  <xsd:annotation>
                                    <xsd:documentation>Distribution key for quantity produced</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""4"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""SERKZ"">
                                  <xsd:annotation>
                                    <xsd:documentation>Repetitive manufacturing allowed for version</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""1"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""BSTMI"">
                                  <xsd:annotation>
                                    <xsd:documentation>Lower value of the lot-size interval</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""15"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""BSTMA"">
                                  <xsd:annotation>
                                    <xsd:documentation>Upper value of the lot-size interval</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""15"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""RGEKZ"">
                                  <xsd:annotation>
                                    <xsd:documentation>Indicator: backflush for RS header</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""1"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""ALORT"">
                                  <xsd:annotation>
                                    <xsd:documentation>Receiving storage location for repetitive manufacturing</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""4"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""PLTYG"">
                                  <xsd:annotation>
                                    <xsd:documentation>Task List Type</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""1"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""PLNNG"">
                                  <xsd:annotation>
                                    <xsd:documentation>Key for Task List Group</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""8"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""ALNAG"">
                                  <xsd:annotation>
                                    <xsd:documentation>Group Counter</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""2"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""PLTYM"">
                                  <xsd:annotation>
                                    <xsd:documentation>Task List Type</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""1"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""PLNNM"">
                                  <xsd:annotation>
                                    <xsd:documentation>Key for Task List Group</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""8"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""ALNAM"">
                                  <xsd:annotation>
                                    <xsd:documentation>Group Counter</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""2"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""CSPLT"">
                                  <xsd:annotation>
                                    <xsd:documentation>Apportionment Structure</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""4"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""MATKO"">
                                  <xsd:annotation>
                                    <xsd:documentation>Other material for which BOM and task list are maintained</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""18"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""ELPRO"">
                                  <xsd:annotation>
                                    <xsd:documentation>Proposed issue storage location for components</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""4"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""PRVBE"">
                                  <xsd:annotation>
                                    <xsd:documentation>Default supply area for components</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""10"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""MATKO_EXTERNAL"">
                                  <xsd:annotation>
                                    <xsd:documentation>Long Material Number for Field MATKO</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""40"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""MATKO_VERSION"">
                                  <xsd:annotation>
                                    <xsd:documentation>Version Number for Field MATKO</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""10"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""MATKO_GUID"">
                                  <xsd:annotation>
                                    <xsd:documentation>External GUID for Field MATKO</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""32"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                              </xsd:sequence>
                              <xsd:attribute name=""SEGMENT"" use=""required"">
                                <xsd:simpleType>
                                  <xsd:restriction base=""xsd:string"">
                                    <xsd:enumeration value=""1"" />
                                  </xsd:restriction>
                                </xsd:simpleType>
                              </xsd:attribute>
                            </xsd:complexType>
                          </xsd:element>
                        </xsd:sequence>
                        <xsd:attribute name=""SEGMENT"" use=""required"">
                          <xsd:simpleType>
                            <xsd:restriction base=""xsd:string"">
                              <xsd:enumeration value=""1"" />
                            </xsd:restriction>
                          </xsd:simpleType>
                        </xsd:attribute>
                      </xsd:complexType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" maxOccurs=""999"" name=""E1MARMM"">
                      <xsd:annotation>
                        <xsd:documentation>Master material units of measure (MARM)</xsd:documentation>
                      </xsd:annotation>
                      <xsd:complexType>
                        <xsd:sequence>
                          <xsd:element minOccurs=""0"" name=""MSGFN"">
                            <xsd:annotation>
                              <xsd:documentation>Function</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""3"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""MEINH"">
                            <xsd:annotation>
                              <xsd:documentation>Alternative Unit of Measure for Stockkeeping Unit</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""3"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""UMREZ"">
                            <xsd:annotation>
                              <xsd:documentation>Numerator for Conversion to Base Units of Measure</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""5"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""UMREN"">
                            <xsd:annotation>
                              <xsd:documentation>Denominator for conversion to base units of measure</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""5"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""EAN11"">
                            <xsd:annotation>
                              <xsd:documentation>International Article Number (EAN/UPC)</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""18"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""NUMTP"">
                            <xsd:annotation>
                              <xsd:documentation>Category of International Article Number (EAN)</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""2"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""LAENG"">
                            <xsd:annotation>
                              <xsd:documentation>Length</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""14"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""BREIT"">
                            <xsd:annotation>
                              <xsd:documentation>Width</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""14"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""HOEHE"">
                            <xsd:annotation>
                              <xsd:documentation>Height</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""14"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""MEABM"">
                            <xsd:annotation>
                              <xsd:documentation>Unit of Dimension for Length/Width/Height</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""3"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""VOLUM"">
                            <xsd:annotation>
                              <xsd:documentation>Volume</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""14"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""VOLEH"">
                            <xsd:annotation>
                              <xsd:documentation>Volume unit</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""3"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""BRGEW"">
                            <xsd:annotation>
                              <xsd:documentation>Gross Weight</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""14"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""GEWEI"">
                            <xsd:annotation>
                              <xsd:documentation>Weight Unit</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""3"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""MESUB"">
                            <xsd:annotation>
                              <xsd:documentation>Lower-Level Unit of Measure in a Packing Hierarchy</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""3"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""GTIN_VARIANT"">
                            <xsd:annotation>
                              <xsd:documentation>Global Trade Item Number Variant</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""2"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""_-CWM_-TY2TQ"">
                            <xsd:annotation>
                              <xsd:documentation>Type of Parallel Unit of Measure</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" maxOccurs=""9999"" name=""E1MEANM"">
                            <xsd:annotation>
                              <xsd:documentation>Master Material European Article Number (MEAN)</xsd:documentation>
                            </xsd:annotation>
                            <xsd:complexType>
                              <xsd:sequence>
                                <xsd:element minOccurs=""0"" name=""MSGFN"">
                                  <xsd:annotation>
                                    <xsd:documentation>Function</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""3"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""MEINH"">
                                  <xsd:annotation>
                                    <xsd:documentation>Unit of Measure for Display</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""3"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""LFNUM"">
                                  <xsd:annotation>
                                    <xsd:documentation>Consecutive Number</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""5"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""EAN11"">
                                  <xsd:annotation>
                                    <xsd:documentation>International Article Number (EAN/UPC)</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""18"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""EANTP"">
                                  <xsd:annotation>
                                    <xsd:documentation>Category of International Article Number (EAN)</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""2"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""HPEAN"">
                                  <xsd:annotation>
                                    <xsd:documentation>Indicator: Main EAN</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""1"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                              </xsd:sequence>
                              <xsd:attribute name=""SEGMENT"" use=""required"">
                                <xsd:simpleType>
                                  <xsd:restriction base=""xsd:string"">
                                    <xsd:enumeration value=""1"" />
                                  </xsd:restriction>
                                </xsd:simpleType>
                              </xsd:attribute>
                            </xsd:complexType>
                          </xsd:element>
                        </xsd:sequence>
                        <xsd:attribute name=""SEGMENT"" use=""required"">
                          <xsd:simpleType>
                            <xsd:restriction base=""xsd:string"">
                              <xsd:enumeration value=""1"" />
                            </xsd:restriction>
                          </xsd:simpleType>
                        </xsd:attribute>
                      </xsd:complexType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" maxOccurs=""9999"" name=""E1MBEWM"">
                      <xsd:annotation>
                        <xsd:documentation>Master material material valuation (MBEW)</xsd:documentation>
                      </xsd:annotation>
                      <xsd:complexType>
                        <xsd:sequence>
                          <xsd:element minOccurs=""0"" name=""MSGFN"">
                            <xsd:annotation>
                              <xsd:documentation>Function</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""3"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""BWKEY"">
                            <xsd:annotation>
                              <xsd:documentation>Valuation Area</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""4"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""BWTAR"">
                            <xsd:annotation>
                              <xsd:documentation>Valuation Type</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""10"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""LVORM"">
                            <xsd:annotation>
                              <xsd:documentation>Deletion Indicator</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""VPRSV"">
                            <xsd:annotation>
                              <xsd:documentation>Price control indicator</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""VERPR"">
                            <xsd:annotation>
                              <xsd:documentation>Moving Average Price/Periodic Unit Price</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""12"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""STPRS"">
                            <xsd:annotation>
                              <xsd:documentation>Standard price</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""12"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""PEINH"">
                            <xsd:annotation>
                              <xsd:documentation>Price Unit</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""5"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""BKLAS"">
                            <xsd:annotation>
                              <xsd:documentation>Valuation Class</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""4"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""VMVPR"">
                            <xsd:annotation>
                              <xsd:documentation>Price Control Indicator in Previous Period</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""VMVER"">
                            <xsd:annotation>
                              <xsd:documentation>Moving Average Price/Periodic Unit Price in Previous Period</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""12"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""VMSTP"">
                            <xsd:annotation>
                              <xsd:documentation>Standard price in the previous period</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""12"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""VMPEI"">
                            <xsd:annotation>
                              <xsd:documentation>Price unit of previous period</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""5"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""VMBKL"">
                            <xsd:annotation>
                              <xsd:documentation>Valuation Class in Previous Period</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""4"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""VJVPR"">
                            <xsd:annotation>
                              <xsd:documentation>Price Control Indicator in Previous Year</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""VJVER"">
                            <xsd:annotation>
                              <xsd:documentation>Moving Average Price/Periodic Unit Price in Previous Year</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""12"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""VJSTP"">
                            <xsd:annotation>
                              <xsd:documentation>Standard price in previous year</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""12"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""LFGJA"">
                            <xsd:annotation>
                              <xsd:documentation>Fiscal Year of Current Period</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""4"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""LFMON"">
                            <xsd:annotation>
                              <xsd:documentation>Current period (posting period)</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""2"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""BWTTY"">
                            <xsd:annotation>
                              <xsd:documentation>Valuation Category</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""ZKPRS"">
                            <xsd:annotation>
                              <xsd:documentation>Future price</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""12"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""ZKDAT"">
                            <xsd:annotation>
                              <xsd:documentation>Date as of which the price is valid</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""8"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""BWPRS"">
                            <xsd:annotation>
                              <xsd:documentation>Valuation price based on tax law: level 1</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""12"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""BWPRH"">
                            <xsd:annotation>
                              <xsd:documentation>Valuation price based on commercial law: level 1</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""12"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""VJBWS"">
                            <xsd:annotation>
                              <xsd:documentation>Valuation price based on tax law: level 3</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""12"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""VJBWH"">
                            <xsd:annotation>
                              <xsd:documentation>Valuation price based on commercial law: level 3</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""12"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""VVJLB"">
                            <xsd:annotation>
                              <xsd:documentation>Total valuated stock in year before last</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""15"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""VVMLB"">
                            <xsd:annotation>
                              <xsd:documentation>Total valuated stock in period before last</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""15"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""VVSAL"">
                            <xsd:annotation>
                              <xsd:documentation>Value of total valuated stock in period before last</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""15"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""ZPLPR"">
                            <xsd:annotation>
                              <xsd:documentation>Future planned price</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""12"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""ZPLP1"">
                            <xsd:annotation>
                              <xsd:documentation>Future Planned Price 1</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""12"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""ZPLP2"">
                            <xsd:annotation>
                              <xsd:documentation>Future Planned Price 2</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""12"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""ZPLP3"">
                            <xsd:annotation>
                              <xsd:documentation>Future Planned Price 3</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""12"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""ZPLD1"">
                            <xsd:annotation>
                              <xsd:documentation>Date from Which Future Planned Price 1 Is Valid</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""8"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""ZPLD2"">
                            <xsd:annotation>
                              <xsd:documentation>Date from Which Future Planned Price 2 Is Valid</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""8"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""ZPLD3"">
                            <xsd:annotation>
                              <xsd:documentation>Date from Which Future Planned Price 3 Is Valid</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""8"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""KALKZ"">
                            <xsd:annotation>
                              <xsd:documentation>Indicator: Standard cost estimate for the period</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""KALKL"">
                            <xsd:annotation>
                              <xsd:documentation>Standard Cost Estimate for Current Period</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""XLIFO"">
                            <xsd:annotation>
                              <xsd:documentation>LIFO/FIFO-Relevant</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""MYPOL"">
                            <xsd:annotation>
                              <xsd:documentation>Pool number for LIFO valuation</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""4"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""BWPH1"">
                            <xsd:annotation>
                              <xsd:documentation>Valuation price based on commercial law: level 2</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""12"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""BWPS1"">
                            <xsd:annotation>
                              <xsd:documentation>Valuation price based on tax law: level 2</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""12"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""ABWKZ"">
                            <xsd:annotation>
                              <xsd:documentation>Lowest value: devaluation indicator</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""2"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""PSTAT"">
                            <xsd:annotation>
                              <xsd:documentation>Maintenance status</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""15"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""KALN1"">
                            <xsd:annotation>
                              <xsd:documentation>Cost Estimate Number - Product Costing</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""12"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""KALNR"">
                            <xsd:annotation>
                              <xsd:documentation>Cost Estimate Number for Cost Est. w/o Qty Structure</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""12"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""BWVA1"">
                            <xsd:annotation>
                              <xsd:documentation>Valuation Variant for Future Standard Cost Estimate</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""3"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""BWVA2"">
                            <xsd:annotation>
                              <xsd:documentation>Valuation Variant for Current Standard Cost Estimate</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""3"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""BWVA3"">
                            <xsd:annotation>
                              <xsd:documentation>Valuation Variant for Previous Standard Cost Estimate</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""3"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""VERS1"">
                            <xsd:annotation>
                              <xsd:documentation>Costing Version of Future Standard Cost Estimate</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""2"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""VERS2"">
                            <xsd:annotation>
                              <xsd:documentation>Costing Version of Current Standard Cost Estimate</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""2"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""VERS3"">
                            <xsd:annotation>
                              <xsd:documentation>Costing Version of Previous Standard Cost Estimate</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""2"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""HRKFT"">
                            <xsd:annotation>
                              <xsd:documentation>Origin Group as Subdivision of Cost Element</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""4"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""KOSGR"">
                            <xsd:annotation>
                              <xsd:documentation>Costing Overhead Group</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""10"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""PPRDZ"">
                            <xsd:annotation>
                              <xsd:documentation>Period of Future Standard Cost Estimate</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""3"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""PPRDL"">
                            <xsd:annotation>
                              <xsd:documentation>Period of Current Standard Cost Estimate</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""3"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""PPRDV"">
                            <xsd:annotation>
                              <xsd:documentation>Period of Previous Standard Cost Estimate</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""3"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""PDATZ"">
                            <xsd:annotation>
                              <xsd:documentation>Fiscal Year of Future Standard Cost Estimate</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""4"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""PDATL"">
                            <xsd:annotation>
                              <xsd:documentation>Fiscal Year of Current Standard Cost Estimate</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""4"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""PDATV"">
                            <xsd:annotation>
                              <xsd:documentation>Fiscal Year of Previous Standard Cost Estimate</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""4"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""EKALR"">
                            <xsd:annotation>
                              <xsd:documentation>Material Is Costed with Quantity Structure</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""VPLPR"">
                            <xsd:annotation>
                              <xsd:documentation>Previous planned price</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""12"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""MLMAA"">
                            <xsd:annotation>
                              <xsd:documentation>Material ledger activated at material level</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""MLAST"">
                            <xsd:annotation>
                              <xsd:documentation>Material Price Determination: Control</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""VJBKL"">
                            <xsd:annotation>
                              <xsd:documentation>Valuation Class in Previous Year</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""4"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""VJPEI"">
                            <xsd:annotation>
                              <xsd:documentation>Price unit of previous year</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""7"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""HKMAT"">
                            <xsd:annotation>
                              <xsd:documentation>Material-related origin</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""EKLAS"">
                            <xsd:annotation>
                              <xsd:documentation>Valuation Class for Sales Order Stock</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""4"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""QKLAS"">
                            <xsd:annotation>
                              <xsd:documentation>Valuation Class for Project Stock</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""4"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""MTUSE"">
                            <xsd:annotation>
                              <xsd:documentation>Usage of the material</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""MTORG"">
                            <xsd:annotation>
                              <xsd:documentation>Origin of the material</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""OWNPR"">
                            <xsd:annotation>
                              <xsd:documentation>Produced in-house</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""BWPEI"">
                            <xsd:annotation>
                              <xsd:documentation>Price unit for valuation prices based on tax/commercial law</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""6"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""CON_FIN_VALLEVEL"">
                            <xsd:annotation>
                              <xsd:documentation>Valuation Level</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""3"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""CON_FIN_VALPROC"">
                            <xsd:annotation>
                              <xsd:documentation>Valuation Procedure</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""3"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                        </xsd:sequence>
                        <xsd:attribute name=""SEGMENT"" use=""required"">
                          <xsd:simpleType>
                            <xsd:restriction base=""xsd:string"">
                              <xsd:enumeration value=""1"" />
                            </xsd:restriction>
                          </xsd:simpleType>
                        </xsd:attribute>
                      </xsd:complexType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" maxOccurs=""9999"" name=""E1MLGNM"">
                      <xsd:annotation>
                        <xsd:documentation>Master material material data per warehouse number (MLGN)</xsd:documentation>
                      </xsd:annotation>
                      <xsd:complexType>
                        <xsd:sequence>
                          <xsd:element minOccurs=""0"" name=""MSGFN"">
                            <xsd:annotation>
                              <xsd:documentation>Function</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""3"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""LGNUM"">
                            <xsd:annotation>
                              <xsd:documentation>Warehouse Number / Warehouse Complex</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""3"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""LVORM"">
                            <xsd:annotation>
                              <xsd:documentation>Deletion flag for all material data of a warehouse number</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""LGBKZ"">
                            <xsd:annotation>
                              <xsd:documentation>Storage Section Indicators</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""3"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""LTKZE"">
                            <xsd:annotation>
                              <xsd:documentation>Storage type indicator for stock placement</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""3"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""LTKZA"">
                            <xsd:annotation>
                              <xsd:documentation>Storage type indicator for stock removal</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""3"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""LHMG1"">
                            <xsd:annotation>
                              <xsd:documentation>Loading equipment quantity</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""14"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""LHMG2"">
                            <xsd:annotation>
                              <xsd:documentation>Loading equipment quantity</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""14"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""LHMG3"">
                            <xsd:annotation>
                              <xsd:documentation>Loading equipment quantity</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""14"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""LHME1"">
                            <xsd:annotation>
                              <xsd:documentation>Unit of measure for loading equipment quantity</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""3"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""LHME2"">
                            <xsd:annotation>
                              <xsd:documentation>Unit of measure for loading equipment quantity</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""3"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""LHME3"">
                            <xsd:annotation>
                              <xsd:documentation>Unit of measure for loading equipment quantity</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""3"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""LETY1"">
                            <xsd:annotation>
                              <xsd:documentation>Storage Unit Type</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""3"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""LETY2"">
                            <xsd:annotation>
                              <xsd:documentation>Storage Unit Type</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""3"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""LETY3"">
                            <xsd:annotation>
                              <xsd:documentation>Storage Unit Type</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""3"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""LVSME"">
                            <xsd:annotation>
                              <xsd:documentation>Warehouse Management Unit of Measure</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""3"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""KZZUL"">
                            <xsd:annotation>
                              <xsd:documentation>Indicator: Allow addition to existing stock</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""BLOCK"">
                            <xsd:annotation>
                              <xsd:documentation>Bulk storage indicator</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""2"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""KZMBF"">
                            <xsd:annotation>
                              <xsd:documentation>Indicator: Message to inventory management</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""BSSKZ"">
                            <xsd:annotation>
                              <xsd:documentation>Special movement indicator for warehouse management</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""MKAPV"">
                            <xsd:annotation>
                              <xsd:documentation>Capacity usage</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""13"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""BEZME"">
                            <xsd:annotation>
                              <xsd:documentation>Unit of measure for capacity consumption</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""3"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""PLKPT"">
                            <xsd:annotation>
                              <xsd:documentation>Picking storage type for rough-cut and detailed planning</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""3"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""VOMEM"">
                            <xsd:annotation>
                              <xsd:documentation>Default for unit of measure from material master record</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""L2SKR"">
                            <xsd:annotation>
                              <xsd:documentation>Material relevance for 2-step picking</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" maxOccurs=""9999"" name=""E1MLGTM"">
                            <xsd:annotation>
                              <xsd:documentation>Material Master: Material Data for Each Storage Type (MLGT)</xsd:documentation>
                            </xsd:annotation>
                            <xsd:complexType>
                              <xsd:sequence>
                                <xsd:element minOccurs=""0"" name=""MSGFN"">
                                  <xsd:annotation>
                                    <xsd:documentation>Function</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""3"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""LGTYP"">
                                  <xsd:annotation>
                                    <xsd:documentation>Storage Type</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""3"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""LVORM"">
                                  <xsd:annotation>
                                    <xsd:documentation>Deletion flag for all material data of a storage type</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""1"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""LGPLA"">
                                  <xsd:annotation>
                                    <xsd:documentation>Storage Bin</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""10"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""LPMAX"">
                                  <xsd:annotation>
                                    <xsd:documentation>Maximum storage bin quantity</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""15"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""LPMIN"">
                                  <xsd:annotation>
                                    <xsd:documentation>Minimum storage bin quantity</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""15"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""MAMNG"">
                                  <xsd:annotation>
                                    <xsd:documentation>Control quantity</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""15"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""NSMNG"">
                                  <xsd:annotation>
                                    <xsd:documentation>Replenishment quantity</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""15"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""KOBER"">
                                  <xsd:annotation>
                                    <xsd:documentation>Picking Area</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""3"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""RDMNG"">
                                  <xsd:annotation>
                                    <xsd:documentation>Rounding qty</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""15"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                              </xsd:sequence>
                              <xsd:attribute name=""SEGMENT"" use=""required"">
                                <xsd:simpleType>
                                  <xsd:restriction base=""xsd:string"">
                                    <xsd:enumeration value=""1"" />
                                  </xsd:restriction>
                                </xsd:simpleType>
                              </xsd:attribute>
                            </xsd:complexType>
                          </xsd:element>
                        </xsd:sequence>
                        <xsd:attribute name=""SEGMENT"" use=""required"">
                          <xsd:simpleType>
                            <xsd:restriction base=""xsd:string"">
                              <xsd:enumeration value=""1"" />
                            </xsd:restriction>
                          </xsd:simpleType>
                        </xsd:attribute>
                      </xsd:complexType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" maxOccurs=""9999"" name=""E1MVKEM"">
                      <xsd:annotation>
                        <xsd:documentation>Master material sales data (MVKE)</xsd:documentation>
                      </xsd:annotation>
                      <xsd:complexType>
                        <xsd:sequence>
                          <xsd:element minOccurs=""0"" name=""MSGFN"">
                            <xsd:annotation>
                              <xsd:documentation>Function</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""3"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""VKORG"">
                            <xsd:annotation>
                              <xsd:documentation>Sales Organization</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""4"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""VTWEG"">
                            <xsd:annotation>
                              <xsd:documentation>Distribution Channel</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""2"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""LVORM"">
                            <xsd:annotation>
                              <xsd:documentation>Ind.: Flag material for deletion at distribution chain level</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""VERSG"">
                            <xsd:annotation>
                              <xsd:documentation>Material statistics group</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""BONUS"">
                            <xsd:annotation>
                              <xsd:documentation>Volume rebate group</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""2"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""PROVG"">
                            <xsd:annotation>
                              <xsd:documentation>Commission group</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""2"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""SKTOF"">
                            <xsd:annotation>
                              <xsd:documentation>Cash discount indicator</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""VMSTA"">
                            <xsd:annotation>
                              <xsd:documentation>Distribution-chain-specific material status</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""2"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""VMSTD"">
                            <xsd:annotation>
                              <xsd:documentation>Date from which distr.-chain-spec. material status is valid</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""8"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""AUMNG"">
                            <xsd:annotation>
                              <xsd:documentation>Minimum order quantity in base unit of measure</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""14"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""LFMNG"">
                            <xsd:annotation>
                              <xsd:documentation>Minimum delivery quantity in delivery note processing</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""14"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""EFMNG"">
                            <xsd:annotation>
                              <xsd:documentation>Minimum make-to-order quantity</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""14"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""SCMNG"">
                            <xsd:annotation>
                              <xsd:documentation>Delivery unit</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""14"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""SCHME"">
                            <xsd:annotation>
                              <xsd:documentation>Unit of measure of delivery unit</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""3"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""VRKME"">
                            <xsd:annotation>
                              <xsd:documentation>Sales unit</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""3"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""MTPOS"">
                            <xsd:annotation>
                              <xsd:documentation>Item category group from material master</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""4"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""DWERK"">
                            <xsd:annotation>
                              <xsd:documentation>Delivering Plant</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""4"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""PRODH"">
                            <xsd:annotation>
                              <xsd:documentation>Product hierarchy</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""18"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""PMATN"">
                            <xsd:annotation>
                              <xsd:documentation>Pricing Reference Material</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""18"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""KONDM"">
                            <xsd:annotation>
                              <xsd:documentation>Material Pricing Group</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""2"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""KTGRM"">
                            <xsd:annotation>
                              <xsd:documentation>Account assignment group for this material</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""2"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""MVGR1"">
                            <xsd:annotation>
                              <xsd:documentation>Material group 1</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""3"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""MVGR2"">
                            <xsd:annotation>
                              <xsd:documentation>Material group 2</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""3"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""MVGR3"">
                            <xsd:annotation>
                              <xsd:documentation>Material group 3</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""3"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""MVGR4"">
                            <xsd:annotation>
                              <xsd:documentation>Material group 4</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""3"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""MVGR5"">
                            <xsd:annotation>
                              <xsd:documentation>Material group 5</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""3"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""SSTUF"">
                            <xsd:annotation>
                              <xsd:documentation>Assortment grade</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""2"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""PFLKS"">
                            <xsd:annotation>
                              <xsd:documentation>External assortment priority</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""LSTFL"">
                            <xsd:annotation>
                              <xsd:documentation>Listing procedure for store or other assortment categories</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""2"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""LSTVZ"">
                            <xsd:annotation>
                              <xsd:documentation>Listing procedure for distr. center assortment categories</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""2"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""LSTAK"">
                            <xsd:annotation>
                              <xsd:documentation>Listing functions (assortments) are active</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""PRAT1"">
                            <xsd:annotation>
                              <xsd:documentation>ID for product attribute 1</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""PRAT2"">
                            <xsd:annotation>
                              <xsd:documentation>ID for product attribute 2</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""PRAT3"">
                            <xsd:annotation>
                              <xsd:documentation>ID for product attribute 3</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""PRAT4"">
                            <xsd:annotation>
                              <xsd:documentation>ID for product attribute 4</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""PRAT5"">
                            <xsd:annotation>
                              <xsd:documentation>ID for product attribute 5</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""PRAT6"">
                            <xsd:annotation>
                              <xsd:documentation>ID for product attribute 6</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""PRAT7"">
                            <xsd:annotation>
                              <xsd:documentation>ID for product attribute 7</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""PRAT8"">
                            <xsd:annotation>
                              <xsd:documentation>ID for product attribute 8</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""PRAT9"">
                            <xsd:annotation>
                              <xsd:documentation>ID for product attribute 9</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""PRATA"">
                            <xsd:annotation>
                              <xsd:documentation>ID for product attribute 10</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""VAVME"">
                            <xsd:annotation>
                              <xsd:documentation>Variable Sales Unit Not Allowed</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""RDPRF"">
                            <xsd:annotation>
                              <xsd:documentation>Rounding Profile</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""4"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""MEGRU"">
                            <xsd:annotation>
                              <xsd:documentation>Unit of Measure Group</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""4"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""PMATN_EXTERNAL"">
                            <xsd:annotation>
                              <xsd:documentation>Long Material Number for Field PMATN</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""40"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""PMATN_VERSION"">
                            <xsd:annotation>
                              <xsd:documentation>Version Number for Field PMATN</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""10"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""PMATN_GUID"">
                            <xsd:annotation>
                              <xsd:documentation>External GUID for Field PMATN</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""32"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                        </xsd:sequence>
                        <xsd:attribute name=""SEGMENT"" use=""required"">
                          <xsd:simpleType>
                            <xsd:restriction base=""xsd:string"">
                              <xsd:enumeration value=""1"" />
                            </xsd:restriction>
                          </xsd:simpleType>
                        </xsd:attribute>
                      </xsd:complexType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" maxOccurs=""9999"" name=""E1MLANM"">
                      <xsd:annotation>
                        <xsd:documentation>Master material tax classification (MLAN)</xsd:documentation>
                      </xsd:annotation>
                      <xsd:complexType>
                        <xsd:sequence>
                          <xsd:element minOccurs=""0"" name=""MSGFN"">
                            <xsd:annotation>
                              <xsd:documentation>Function</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""3"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""ALAND"">
                            <xsd:annotation>
                              <xsd:documentation>Departure country (country from which the goods are sent)</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""3"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""TATY1"">
                            <xsd:annotation>
                              <xsd:documentation>Tax category (sales tax, federal sales tax,...)</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""4"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""TAXM1"">
                            <xsd:annotation>
                              <xsd:documentation>Tax classification material</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""TATY2"">
                            <xsd:annotation>
                              <xsd:documentation>Tax category (sales tax, federal sales tax,...)</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""4"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""TAXM2"">
                            <xsd:annotation>
                              <xsd:documentation>Tax classification material</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""TATY3"">
                            <xsd:annotation>
                              <xsd:documentation>Tax category (sales tax, federal sales tax,...)</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""4"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""TAXM3"">
                            <xsd:annotation>
                              <xsd:documentation>Tax classification material</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""TATY4"">
                            <xsd:annotation>
                              <xsd:documentation>Tax category (sales tax, federal sales tax,...)</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""4"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""TAXM4"">
                            <xsd:annotation>
                              <xsd:documentation>Tax classification material</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""TATY5"">
                            <xsd:annotation>
                              <xsd:documentation>Tax category (sales tax, federal sales tax,...)</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""4"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""TAXM5"">
                            <xsd:annotation>
                              <xsd:documentation>Tax classification material</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""TATY6"">
                            <xsd:annotation>
                              <xsd:documentation>Tax category (sales tax, federal sales tax,...)</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""4"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""TAXM6"">
                            <xsd:annotation>
                              <xsd:documentation>Tax classification material</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""TATY7"">
                            <xsd:annotation>
                              <xsd:documentation>Tax category (sales tax, federal sales tax,...)</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""4"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""TAXM7"">
                            <xsd:annotation>
                              <xsd:documentation>Tax classification material</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""TATY8"">
                            <xsd:annotation>
                              <xsd:documentation>Tax category (sales tax, federal sales tax,...)</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""4"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""TAXM8"">
                            <xsd:annotation>
                              <xsd:documentation>Tax classification material</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""TATY9"">
                            <xsd:annotation>
                              <xsd:documentation>Tax category (sales tax, federal sales tax,...)</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""4"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""TAXM9"">
                            <xsd:annotation>
                              <xsd:documentation>Tax classification material</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""TAXIM"">
                            <xsd:annotation>
                              <xsd:documentation>Tax indicator for material (Purchasing)</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                        </xsd:sequence>
                        <xsd:attribute name=""SEGMENT"" use=""required"">
                          <xsd:simpleType>
                            <xsd:restriction base=""xsd:string"">
                              <xsd:enumeration value=""1"" />
                            </xsd:restriction>
                          </xsd:simpleType>
                        </xsd:attribute>
                      </xsd:complexType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" maxOccurs=""9999"" name=""E1MTXHM"">
                      <xsd:annotation>
                        <xsd:documentation>Master material long text header</xsd:documentation>
                      </xsd:annotation>
                      <xsd:complexType>
                        <xsd:sequence>
                          <xsd:element minOccurs=""0"" name=""MSGFN"">
                            <xsd:annotation>
                              <xsd:documentation>Function</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""3"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""TDOBJECT"">
                            <xsd:annotation>
                              <xsd:documentation>Texts: Application Object</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""10"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""TDNAME"">
                            <xsd:annotation>
                              <xsd:documentation>Name</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""70"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""TDID"">
                            <xsd:annotation>
                              <xsd:documentation>Text ID</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""4"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""TDSPRAS"">
                            <xsd:annotation>
                              <xsd:documentation>Language Key</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""TDTEXTTYPE"">
                            <xsd:annotation>
                              <xsd:documentation>SAPscript: Format of Text</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""6"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""SPRAS_ISO"">
                            <xsd:annotation>
                              <xsd:documentation>Language according to ISO 639</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""2"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" maxOccurs=""9999"" name=""E1MTXLM"">
                            <xsd:annotation>
                              <xsd:documentation>Master material long text line</xsd:documentation>
                            </xsd:annotation>
                            <xsd:complexType>
                              <xsd:sequence>
                                <xsd:element minOccurs=""0"" name=""MSGFN"">
                                  <xsd:annotation>
                                    <xsd:documentation>Function</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""3"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""TDFORMAT"">
                                  <xsd:annotation>
                                    <xsd:documentation>Tag column</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""2"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""TDLINE"">
                                  <xsd:annotation>
                                    <xsd:documentation>Text Line</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""132"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                              </xsd:sequence>
                              <xsd:attribute name=""SEGMENT"" use=""required"">
                                <xsd:simpleType>
                                  <xsd:restriction base=""xsd:string"">
                                    <xsd:enumeration value=""1"" />
                                  </xsd:restriction>
                                </xsd:simpleType>
                              </xsd:attribute>
                            </xsd:complexType>
                          </xsd:element>
                        </xsd:sequence>
                        <xsd:attribute name=""SEGMENT"" use=""required"">
                          <xsd:simpleType>
                            <xsd:restriction base=""xsd:string"">
                              <xsd:enumeration value=""1"" />
                            </xsd:restriction>
                          </xsd:simpleType>
                        </xsd:attribute>
                      </xsd:complexType>
                    </xsd:element>
                  </xsd:sequence>
                  <xsd:attribute name=""SEGMENT"" use=""required"">
                    <xsd:simpleType>
                      <xsd:restriction base=""xsd:string"">
                        <xsd:enumeration value=""1"" />
                      </xsd:restriction>
                    </xsd:simpleType>
                  </xsd:attribute>
                </xsd:complexType>
              </xsd:element>
            </xsd:sequence>
            <xsd:attribute name=""BEGIN"" use=""required"">
              <xsd:simpleType>
                <xsd:restriction base=""xsd:string"">
                  <xsd:enumeration value=""1"" />
                </xsd:restriction>
              </xsd:simpleType>
            </xsd:attribute>
          </xsd:complexType>
        </xsd:element>
      </xsd:sequence>
    </xsd:complexType>
  </xsd:element>
</xsd:schema>";
        
        public MATMAS04() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "MATMAS04";
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
