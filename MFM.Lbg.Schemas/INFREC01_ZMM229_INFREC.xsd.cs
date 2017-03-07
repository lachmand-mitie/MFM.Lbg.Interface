namespace MFM.Lbg.Schemas {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"",@"ZMM229_INFREC")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"ZMM229_INFREC"})]
    public sealed class INFREC01_ZMM229_INFREC : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xsd:schema xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" version=""1.0"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"">
  <xsd:element name=""ZMM229_INFREC"">
    <xsd:annotation>
      <xsd:documentation>Purchasing Info record Extension</xsd:documentation>
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
                    <xsd:element fixed=""INFREC01"" name=""IDOCTYP"" type=""xsd:string"">
                      <xsd:annotation>
                        <xsd:documentation>Name of basic type</xsd:documentation>
                      </xsd:annotation>
                    </xsd:element>
                    <xsd:element fixed=""ZMM229_INFREC"" name=""CIMTYP"" type=""xsd:string"">
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
              <xsd:element name=""E1EINAM"">
                <xsd:annotation>
                  <xsd:documentation>Purchasing Info Record: General Data</xsd:documentation>
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
                    <xsd:element minOccurs=""0"" name=""INFNR"">
                      <xsd:annotation>
                        <xsd:documentation>Number of Purchasing Info Record</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""10"" />
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
                    <xsd:element minOccurs=""0"" name=""LIFNR"">
                      <xsd:annotation>
                        <xsd:documentation>Vendor Account Number</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""10"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""LOEKZ"">
                      <xsd:annotation>
                        <xsd:documentation>Purchasing info: General data flagged for deletion</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""1"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""ERDAT"">
                      <xsd:annotation>
                        <xsd:documentation>Date on Which Record Was Created</xsd:documentation>
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
                    <xsd:element minOccurs=""0"" name=""TXZ01"">
                      <xsd:annotation>
                        <xsd:documentation>Short Text for Purchasing Info Record</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""40"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""SORTL"">
                      <xsd:annotation>
                        <xsd:documentation>Sort Term for Non-Stock Info Records</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""10"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""MEINS"">
                      <xsd:annotation>
                        <xsd:documentation>Purchase Order Unit of Measure</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""3"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""UMREZ"">
                      <xsd:annotation>
                        <xsd:documentation>Numerator for Conversion of Order Unit to Base Unit</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""8"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""UMREN"">
                      <xsd:annotation>
                        <xsd:documentation>Denominator for Conversion of Order Unit to Base Unit</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""8"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""IDNLF"">
                      <xsd:annotation>
                        <xsd:documentation>Material number used by vendor</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""22"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""VERKF"">
                      <xsd:annotation>
                        <xsd:documentation>Salesperson Responsible in the Event of Queries</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""30"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""TELF1"">
                      <xsd:annotation>
                        <xsd:documentation>Vendor's Telephone Number</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""16"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""MAHN1"">
                      <xsd:annotation>
                        <xsd:documentation>Number of Days for First Reminder/Expediter</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""5"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""MAHN2"">
                      <xsd:annotation>
                        <xsd:documentation>Number of Days for Second Reminder/Expediter</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""5"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""MAHN3"">
                      <xsd:annotation>
                        <xsd:documentation>Number of Days for Third Reminder/Expediter</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""5"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""URZNR"">
                      <xsd:annotation>
                        <xsd:documentation>Certificate Number</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""10"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""URZDT"">
                      <xsd:annotation>
                        <xsd:documentation>Certificate of Origin Valid Until</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""8"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""URZLA"">
                      <xsd:annotation>
                        <xsd:documentation>Country of Issue of Certificate of Origin</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""3"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""URZTP"">
                      <xsd:annotation>
                        <xsd:documentation>Certificate Category</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""1"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""URZZT"">
                      <xsd:annotation>
                        <xsd:documentation>Number</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""16"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""LMEIN"">
                      <xsd:annotation>
                        <xsd:documentation>Base Unit of Measure</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""3"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""REGIO"">
                      <xsd:annotation>
                        <xsd:documentation>Region (State, Province, County)</xsd:documentation>
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
                    <xsd:element minOccurs=""0"" name=""LTSNR"">
                      <xsd:annotation>
                        <xsd:documentation>Vendor Subrange</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""6"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""LTSSF"">
                      <xsd:annotation>
                        <xsd:documentation>Sort Sequence Number</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""5"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""WGLIF"">
                      <xsd:annotation>
                        <xsd:documentation>Vendor Material Group</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""18"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""RUECK"">
                      <xsd:annotation>
                        <xsd:documentation>Return Agreement</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""2"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""LIFAB"">
                      <xsd:annotation>
                        <xsd:documentation>Available (Deliverable) From</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""8"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""LIFBI"">
                      <xsd:annotation>
                        <xsd:documentation>Available (Deliverable) Until</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""8"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""KOLIF"">
                      <xsd:annotation>
                        <xsd:documentation>Prior Vendor</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""10"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""ANZPU"">
                      <xsd:annotation>
                        <xsd:documentation>Number of Points</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""15"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""PUNEI"">
                      <xsd:annotation>
                        <xsd:documentation>Points unit</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""3"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""RELIF"">
                      <xsd:annotation>
                        <xsd:documentation>Regular Vendor</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""1"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""KDMAT35"">
                      <xsd:annotation>
                        <xsd:documentation>Material Number Used by Vendor</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""35"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
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
                    <xsd:element minOccurs=""0"" name=""IDNLF_EXTERNAL"">
                      <xsd:annotation>
                        <xsd:documentation>Material Number Used by Vendor</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""40"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""IDNLF_VERSION"">
                      <xsd:annotation>
                        <xsd:documentation>Material Number Used by Vendor</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""10"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""IDNLF_GUID"">
                      <xsd:annotation>
                        <xsd:documentation>Material Number Used by Vendor</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""32"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""KDMAT35_EXTERNAL"">
                      <xsd:annotation>
                        <xsd:documentation>Long Material Number (Future Development) for KDMAT Field</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""40"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""KDMAT35_VERSION"">
                      <xsd:annotation>
                        <xsd:documentation>Version Number (Future Development) for KDMAT35 Field</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""10"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""KDMAT35_GUID"">
                      <xsd:annotation>
                        <xsd:documentation>External GUID (Future Development) for KDMAT35 Field</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""32"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""Z1ZMM229_EINA"">
                      <xsd:annotation>
                        <xsd:documentation>Info Record Extension (EINA)</xsd:documentation>
                      </xsd:annotation>
                      <xsd:complexType>
                        <xsd:sequence>
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
                    <xsd:element minOccurs=""0"" maxOccurs=""999"" name=""E1EALTH"">
                      <xsd:annotation>
                        <xsd:documentation>Text Identification for Purchasing Info Record: General Data</xsd:documentation>
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
                              <xsd:documentation>Language key</xsd:documentation>
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
                          <xsd:element minOccurs=""0"" maxOccurs=""9999"" name=""E1EALTL"">
                            <xsd:annotation>
                              <xsd:documentation>Text Line for Purchasing Info Record: General Data</xsd:documentation>
                            </xsd:annotation>
                            <xsd:complexType>
                              <xsd:sequence>
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
                    <xsd:element minOccurs=""0"" maxOccurs=""9999"" name=""E1EINEM"">
                      <xsd:annotation>
                        <xsd:documentation>Purchasing Info Record: Purchasing Organization Data</xsd:documentation>
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
                          <xsd:element minOccurs=""0"" name=""EKORG"">
                            <xsd:annotation>
                              <xsd:documentation>Purchasing Organization</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""4"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""ESOKZ"">
                            <xsd:annotation>
                              <xsd:documentation>Purchasing info record category</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
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
                          <xsd:element minOccurs=""0"" name=""LOEKZ"">
                            <xsd:annotation>
                              <xsd:documentation>Purch. info: Purch. organization data flagged for deletion</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""ERDAT"">
                            <xsd:annotation>
                              <xsd:documentation>Date on Which Record Was Created</xsd:documentation>
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
                          <xsd:element minOccurs=""0"" name=""WAERS"">
                            <xsd:annotation>
                              <xsd:documentation>Currency Key</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""5"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""BONUS"">
                            <xsd:annotation>
                              <xsd:documentation>Indicator: Volume-Based Rebate</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""MGBON"">
                            <xsd:annotation>
                              <xsd:documentation>Indicator: Quantity-Based Volume Rebate</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""MINBM"">
                            <xsd:annotation>
                              <xsd:documentation>Minimum Purchase Order Quantity</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""15"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""NORBM"">
                            <xsd:annotation>
                              <xsd:documentation>Standard Purchase Order Quantity</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""15"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""APLFZ"">
                            <xsd:annotation>
                              <xsd:documentation>Planned Delivery Time in Days</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""5"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""UEBTO"">
                            <xsd:annotation>
                              <xsd:documentation>Overdelivery Tolerance Limit</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""5"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""UEBTK"">
                            <xsd:annotation>
                              <xsd:documentation>Indicator: Unlimited Overdelivery Allowed</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""UNTTO"">
                            <xsd:annotation>
                              <xsd:documentation>Underdelivery Tolerance Limit</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""5"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""ANGNR"">
                            <xsd:annotation>
                              <xsd:documentation>Quotation Number</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""10"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""ANGDT"">
                            <xsd:annotation>
                              <xsd:documentation>Quotation Validity Date</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""8"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""ABSKZ"">
                            <xsd:annotation>
                              <xsd:documentation>Rejection Indicator</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""NETPR"">
                            <xsd:annotation>
                              <xsd:documentation>Net Price in Purchasing Info Record</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""13"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""PEINH"">
                            <xsd:annotation>
                              <xsd:documentation>Price Unit</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""8"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""BPRME"">
                            <xsd:annotation>
                              <xsd:documentation>Order Price Unit (Purchasing)</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""3"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""PRDAT"">
                            <xsd:annotation>
                              <xsd:documentation>Date of Price Determination</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""8"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""BPUMZ"">
                            <xsd:annotation>
                              <xsd:documentation>Numerator for Conversion of Order Price Unit into Order Unit</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""8"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""BPUMN"">
                            <xsd:annotation>
                              <xsd:documentation>Denominator for Conv. of Order Price Unit into Order Unit</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""8"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""MTXNO"">
                            <xsd:annotation>
                              <xsd:documentation>Material Master Record PO Text Not Relevant</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""WEBRE"">
                            <xsd:annotation>
                              <xsd:documentation>Indicator: GR-Based Invoice Verification</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""EFFPR"">
                            <xsd:annotation>
                              <xsd:documentation>Effective Price in Purchasing Info Record</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""13"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""EKKOL"">
                            <xsd:annotation>
                              <xsd:documentation>Condition Group with Vendor</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""4"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""SKTOF"">
                            <xsd:annotation>
                              <xsd:documentation>Item Does Not Qualify for Cash Discount</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""KZABS"">
                            <xsd:annotation>
                              <xsd:documentation>Order Acknowledgment Requirement</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""MWSKZ"">
                            <xsd:annotation>
                              <xsd:documentation>Sales Tax Code</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""2"" />
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
                          <xsd:element minOccurs=""0"" name=""EBONU"">
                            <xsd:annotation>
                              <xsd:documentation>Settlement Group 1 (Purchasing)</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""2"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""EVERS"">
                            <xsd:annotation>
                              <xsd:documentation>Shipping Instructions</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""2"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""EXPRF"">
                            <xsd:annotation>
                              <xsd:documentation>Export/Import procedure for foreign trade (5 digits)</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""5"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""BSTAE"">
                            <xsd:annotation>
                              <xsd:documentation>Confirmation Control Key</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""4"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""MEPRF"">
                            <xsd:annotation>
                              <xsd:documentation>Price Determination (Pricing) Date Control</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""INCO1"">
                            <xsd:annotation>
                              <xsd:documentation>Incoterms (Part 1)</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""3"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""INCO2"">
                            <xsd:annotation>
                              <xsd:documentation>Incoterms (Part 2)</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""28"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""XERSN"">
                            <xsd:annotation>
                              <xsd:documentation>No Evaluated Receipt Settlement (ERS)</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""EBON2"">
                            <xsd:annotation>
                              <xsd:documentation>Settlement Group 2 (Rebate Settlement, Purchasing)</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""2"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""EBON3"">
                            <xsd:annotation>
                              <xsd:documentation>Settlement Group 3 (Rebate Settlement, Purchasing)</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""2"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""EBONF"">
                            <xsd:annotation>
                              <xsd:documentation>Item Not Relevant to Subseq. (Period-End Rebate) Settlement</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
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
                          <xsd:element minOccurs=""0"" name=""BSTMA"">
                            <xsd:annotation>
                              <xsd:documentation>Maximum Lot Size</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""15"" />
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
                          <xsd:element minOccurs=""0"" name=""J_1BNBM"">
                            <xsd:annotation>
                              <xsd:documentation>Brazilian NCM Code</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""16"" />
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
                          <xsd:element minOccurs=""0"" name=""EXPRF8"">
                            <xsd:annotation>
                              <xsd:documentation>Export-/Import Procedures for Foreign Trade (8-Character)</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""8"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""TRANSPORT_CHAIN"">
                            <xsd:annotation>
                              <xsd:documentation>Transportation Chain</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""10"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""STAGING_TIME"">
                            <xsd:annotation>
                              <xsd:documentation>Staging Time in Days</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""4"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" maxOccurs=""999"" name=""E1EELTH"">
                            <xsd:annotation>
                              <xsd:documentation>Text ID for Purchasing Info Record: Purchasing Org. Data</xsd:documentation>
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
                                    <xsd:documentation>Language key</xsd:documentation>
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
                                <xsd:element minOccurs=""0"" maxOccurs=""9999"" name=""E1EELTL"">
                                  <xsd:annotation>
                                    <xsd:documentation>Text Line for Purchasing Info Record: Purchasing Org. Data</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:complexType>
                                    <xsd:sequence>
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
        
        public INFREC01_ZMM229_INFREC() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "ZMM229_INFREC";
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
