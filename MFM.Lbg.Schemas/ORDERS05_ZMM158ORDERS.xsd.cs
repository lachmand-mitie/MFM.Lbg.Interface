namespace MFM.Lbg.Schemas {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"",@"ZMM158ORDERS")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "IDOC.E1EDK01.BELNR", XPath = @"/*[local-name()='ZMM158ORDERS' and namespace-uri()='']/*[local-name()='IDOC' and namespace-uri()='']/*[local-name()='E1EDK01' and namespace-uri()='']/*[local-name()='BELNR' and namespace-uri()='']", XsdType = @"string")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"ZMM158ORDERS"})]
    public sealed class ORDERS05_ZMM158ORDERS : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xsd:schema xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" version=""1.0"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"">
  <xsd:element name=""ZMM158ORDERS"">
    <xsd:annotation>
      <xsd:documentation>R3 MM 158 Outbound PO extension - email</xsd:documentation>
      <xsd:appinfo>
        <b:properties>
          <b:property distinguished=""true"" xpath=""/*[local-name()='ZMM158ORDERS' and namespace-uri()='']/*[local-name()='IDOC' and namespace-uri()='']/*[local-name()='E1EDK01' and namespace-uri()='']/*[local-name()='BELNR' and namespace-uri()='']"" />
        </b:properties>
      </xsd:appinfo>
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
                    <xsd:element fixed=""ORDERS05"" name=""IDOCTYP"" type=""xsd:string"">
                      <xsd:annotation>
                        <xsd:documentation>Name of basic type</xsd:documentation>
                      </xsd:annotation>
                    </xsd:element>
                    <xsd:element fixed=""ZMM158ORDERS"" name=""CIMTYP"" type=""xsd:string"">
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
              <xsd:element name=""E1EDK01"">
                <xsd:annotation>
                  <xsd:documentation>IDoc: Document header general data</xsd:documentation>
                </xsd:annotation>
                <xsd:complexType>
                  <xsd:sequence>
                    <xsd:element minOccurs=""0"" name=""ACTION"">
                      <xsd:annotation>
                        <xsd:documentation>Action code for the whole EDI message</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""3"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""KZABS"">
                      <xsd:annotation>
                        <xsd:documentation>Flag: order acknowledgment required</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""1"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""CURCY"">
                      <xsd:annotation>
                        <xsd:documentation>Currency</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""3"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""HWAER"">
                      <xsd:annotation>
                        <xsd:documentation>EDI local currency</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""3"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""WKURS"">
                      <xsd:annotation>
                        <xsd:documentation>Exchange rate</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""12"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""ZTERM"">
                      <xsd:annotation>
                        <xsd:documentation>Terms of payment key</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""17"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""KUNDEUINR"">
                      <xsd:annotation>
                        <xsd:documentation>VAT Registration Number</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""20"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""EIGENUINR"">
                      <xsd:annotation>
                        <xsd:documentation>VAT Registration Number</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""20"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""BSART"">
                      <xsd:annotation>
                        <xsd:documentation>Document type</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""4"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""BELNR"">
                      <xsd:annotation>
                        <xsd:documentation>IDOC document number</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""35"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""NTGEW"">
                      <xsd:annotation>
                        <xsd:documentation>Net weight</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""18"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""BRGEW"">
                      <xsd:annotation>
                        <xsd:documentation>Net weight</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""18"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""GEWEI"">
                      <xsd:annotation>
                        <xsd:documentation>Weight unit</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""3"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""FKART_RL"">
                      <xsd:annotation>
                        <xsd:documentation>Invoice list type</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""4"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""ABLAD"">
                      <xsd:annotation>
                        <xsd:documentation>Unloading Point</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""25"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""BSTZD"">
                      <xsd:annotation>
                        <xsd:documentation>Purchase order number supplement</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""4"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""VSART"">
                      <xsd:annotation>
                        <xsd:documentation>Shipping Conditions</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""2"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""VSART_BEZ"">
                      <xsd:annotation>
                        <xsd:documentation>Description of the Shipping Type</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""20"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""RECIPNT_NO"">
                      <xsd:annotation>
                        <xsd:documentation>Number of recipient (for control via the ALE model)</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""10"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""KZAZU"">
                      <xsd:annotation>
                        <xsd:documentation>Order Combination Indicator</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""1"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""AUTLF"">
                      <xsd:annotation>
                        <xsd:documentation>Complete delivery defined for each sales order?</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""1"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""AUGRU"">
                      <xsd:annotation>
                        <xsd:documentation>Order reason (reason for the business transaction)</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""3"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""AUGRU_BEZ"">
                      <xsd:annotation>
                        <xsd:documentation>Description</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""40"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""ABRVW"">
                      <xsd:annotation>
                        <xsd:documentation>Usage Indicator</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""3"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""ABRVW_BEZ"">
                      <xsd:annotation>
                        <xsd:documentation>Description</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""20"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""FKTYP"">
                      <xsd:annotation>
                        <xsd:documentation>Billing category</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""1"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""LIFSK"">
                      <xsd:annotation>
                        <xsd:documentation>Delivery block (document header)</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""2"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""LIFSK_BEZ"">
                      <xsd:annotation>
                        <xsd:documentation>Description</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""20"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""EMPST"">
                      <xsd:annotation>
                        <xsd:documentation>Receiving point</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""25"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""ABTNR"">
                      <xsd:annotation>
                        <xsd:documentation>Department number</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""4"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""DELCO"">
                      <xsd:annotation>
                        <xsd:documentation>Agreed delivery time</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""3"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""WKURS_M"">
                      <xsd:annotation>
                        <xsd:documentation>Indirectly quoted exchange rate in an IDoc segment</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""12"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element name=""Z1EDK158EMAIL"">
                      <xsd:annotation>
                        <xsd:documentation>R3 MM 158 BUNZL email address extension</xsd:documentation>
                      </xsd:annotation>
                      <xsd:complexType>
                        <xsd:sequence>
                          <xsd:element minOccurs=""0"" name=""VENDOR_EMAIL"">
                            <xsd:annotation>
                              <xsd:documentation>E-Mail Address</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""241"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""PURCHASING_EMAIL"">
                            <xsd:annotation>
                              <xsd:documentation>E-Mail Address</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""241"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""CONTACT_EMAIL"">
                            <xsd:annotation>
                              <xsd:documentation>E-Mail Address</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""241"" />
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
              <xsd:element minOccurs=""0"" maxOccurs=""12"" name=""E1EDK14"">
                <xsd:annotation>
                  <xsd:documentation>IDoc: Document Header Organizational Data</xsd:documentation>
                </xsd:annotation>
                <xsd:complexType>
                  <xsd:sequence>
                    <xsd:element minOccurs=""0"" name=""QUALF"">
                      <xsd:annotation>
                        <xsd:documentation>IDOC qualifer organization</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""3"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""ORGID"">
                      <xsd:annotation>
                        <xsd:documentation>IDOC organization</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""35"" />
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
              <xsd:element minOccurs=""0"" maxOccurs=""10"" name=""E1EDK03"">
                <xsd:annotation>
                  <xsd:documentation>IDoc: Document header date segment</xsd:documentation>
                </xsd:annotation>
                <xsd:complexType>
                  <xsd:sequence>
                    <xsd:element minOccurs=""0"" name=""IDDAT"">
                      <xsd:annotation>
                        <xsd:documentation>Qualifier for IDOC date segment</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""3"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""DATUM"">
                      <xsd:annotation>
                        <xsd:documentation>IDOC: Date</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""8"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""UZEIT"">
                      <xsd:annotation>
                        <xsd:documentation>IDOC: Time</xsd:documentation>
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
              <xsd:element minOccurs=""0"" maxOccurs=""10"" name=""E1EDK04"">
                <xsd:annotation>
                  <xsd:documentation>IDoc: Document header taxes</xsd:documentation>
                </xsd:annotation>
                <xsd:complexType>
                  <xsd:sequence>
                    <xsd:element minOccurs=""0"" name=""MWSKZ"">
                      <xsd:annotation>
                        <xsd:documentation>VAT indicator</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""7"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""MSATZ"">
                      <xsd:annotation>
                        <xsd:documentation>VAT rate</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""17"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""MWSBT"">
                      <xsd:annotation>
                        <xsd:documentation>Value added tax amount</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""18"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""TXJCD"">
                      <xsd:annotation>
                        <xsd:documentation>Tax Jurisdiction</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""15"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""KTEXT"">
                      <xsd:annotation>
                        <xsd:documentation>Text Field</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""50"" />
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
              <xsd:element minOccurs=""0"" maxOccurs=""16"" name=""E1EDK05"">
                <xsd:annotation>
                  <xsd:documentation>IDoc: Document header conditions</xsd:documentation>
                </xsd:annotation>
                <xsd:complexType>
                  <xsd:sequence>
                    <xsd:element minOccurs=""0"" name=""ALCKZ"">
                      <xsd:annotation>
                        <xsd:documentation>Surcharge or discount indicator</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""3"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""KSCHL"">
                      <xsd:annotation>
                        <xsd:documentation>Condition type (coded)</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""4"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""KOTXT"">
                      <xsd:annotation>
                        <xsd:documentation>Condition text</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""80"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""BETRG"">
                      <xsd:annotation>
                        <xsd:documentation>Fixed surcharge/discount on total gross</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""18"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""KPERC"">
                      <xsd:annotation>
                        <xsd:documentation>Condition percentage rate</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""8"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""KRATE"">
                      <xsd:annotation>
                        <xsd:documentation>Condition record per unit</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""15"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""UPRBS"">
                      <xsd:annotation>
                        <xsd:documentation>Price unit</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""9"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""MEAUN"">
                      <xsd:annotation>
                        <xsd:documentation>Unit of measurement</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""3"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""KOBTR"">
                      <xsd:annotation>
                        <xsd:documentation>IDoc condition end amount</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""18"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""MWSKZ"">
                      <xsd:annotation>
                        <xsd:documentation>VAT indicator</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""7"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""MSATZ"">
                      <xsd:annotation>
                        <xsd:documentation>VAT rate</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""17"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""KOEIN"">
                      <xsd:annotation>
                        <xsd:documentation>Currency</xsd:documentation>
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
              <xsd:element minOccurs=""0"" maxOccurs=""99"" name=""E1EDKA1"">
                <xsd:annotation>
                  <xsd:documentation>IDoc: Document Header Partner Information</xsd:documentation>
                </xsd:annotation>
                <xsd:complexType>
                  <xsd:sequence>
                    <xsd:element minOccurs=""0"" name=""PARVW"">
                      <xsd:annotation>
                        <xsd:documentation>Partner function (e.g. sold-to party, ship-to party, ...)</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""3"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""PARTN"">
                      <xsd:annotation>
                        <xsd:documentation>Partner number</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""17"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""LIFNR"">
                      <xsd:annotation>
                        <xsd:documentation>Vendor number at customer location</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""17"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""NAME1"">
                      <xsd:annotation>
                        <xsd:documentation>Name 1</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""35"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""NAME2"">
                      <xsd:annotation>
                        <xsd:documentation>Name 2</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""35"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""NAME3"">
                      <xsd:annotation>
                        <xsd:documentation>Name 3</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""35"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""NAME4"">
                      <xsd:annotation>
                        <xsd:documentation>Name 4</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""35"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""STRAS"">
                      <xsd:annotation>
                        <xsd:documentation>Street and house number 1</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""35"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""STRS2"">
                      <xsd:annotation>
                        <xsd:documentation>Street and house number 2</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""35"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""PFACH"">
                      <xsd:annotation>
                        <xsd:documentation>PO Box</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""35"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""ORT01"">
                      <xsd:annotation>
                        <xsd:documentation>City</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""35"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""COUNC"">
                      <xsd:annotation>
                        <xsd:documentation>County code</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""9"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""PSTLZ"">
                      <xsd:annotation>
                        <xsd:documentation>Postal code</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""9"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""PSTL2"">
                      <xsd:annotation>
                        <xsd:documentation>P.O. Box postal code</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""9"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""LAND1"">
                      <xsd:annotation>
                        <xsd:documentation>Country Key</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""3"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""ABLAD"">
                      <xsd:annotation>
                        <xsd:documentation>Unloading Point</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""35"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""PERNR"">
                      <xsd:annotation>
                        <xsd:documentation>Contact person's personnel number</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""30"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""PARNR"">
                      <xsd:annotation>
                        <xsd:documentation>Contact person's number (not personnel number)</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""30"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""TELF1"">
                      <xsd:annotation>
                        <xsd:documentation>1st telephone number of contact person</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""25"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""TELF2"">
                      <xsd:annotation>
                        <xsd:documentation>2nd telephone number of contact person</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""25"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""TELBX"">
                      <xsd:annotation>
                        <xsd:documentation>Telebox number</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""25"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""TELFX"">
                      <xsd:annotation>
                        <xsd:documentation>Fax number</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""25"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""TELTX"">
                      <xsd:annotation>
                        <xsd:documentation>Teletex number</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""25"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""TELX1"">
                      <xsd:annotation>
                        <xsd:documentation>Telex number</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""25"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""SPRAS"">
                      <xsd:annotation>
                        <xsd:documentation>Language key</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""1"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""ANRED"">
                      <xsd:annotation>
                        <xsd:documentation>Form of Address</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""15"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""ORT02"">
                      <xsd:annotation>
                        <xsd:documentation>District</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""35"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""HAUSN"">
                      <xsd:annotation>
                        <xsd:documentation>House number</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""6"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""STOCK"">
                      <xsd:annotation>
                        <xsd:documentation>Floor</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""6"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""REGIO"">
                      <xsd:annotation>
                        <xsd:documentation>Region</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""3"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""PARGE"">
                      <xsd:annotation>
                        <xsd:documentation>Partner's gender</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""1"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""ISOAL"">
                      <xsd:annotation>
                        <xsd:documentation>Country ISO code</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""2"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""ISONU"">
                      <xsd:annotation>
                        <xsd:documentation>Country ISO code</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""2"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""FCODE"">
                      <xsd:annotation>
                        <xsd:documentation>Company key (France)</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""20"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""IHREZ"">
                      <xsd:annotation>
                        <xsd:documentation>Your reference (Partner)</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""30"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""BNAME"">
                      <xsd:annotation>
                        <xsd:documentation>IDoc user name</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""35"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""PAORG"">
                      <xsd:annotation>
                        <xsd:documentation>IDOC organization code</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""30"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""ORGTX"">
                      <xsd:annotation>
                        <xsd:documentation>IDoc organization code text</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""35"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""PAGRU"">
                      <xsd:annotation>
                        <xsd:documentation>IDoc group code</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""30"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""KNREF"">
                      <xsd:annotation>
                        <xsd:documentation>Customer description of partner (plant, storage location)</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""30"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""ILNNR"">
                      <xsd:annotation>
                        <xsd:documentation>Character field, length 70</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""70"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""PFORT"">
                      <xsd:annotation>
                        <xsd:documentation>PO Box city</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""35"" />
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
                    <xsd:element minOccurs=""0"" name=""TITLE"">
                      <xsd:annotation>
                        <xsd:documentation>Title</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""15"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""Z1EDK158A1"">
                      <xsd:annotation>
                        <xsd:documentation>MM 158 Extension to E1EDKA1 - extended address fields</xsd:documentation>
                      </xsd:annotation>
                      <xsd:complexType>
                        <xsd:sequence>
                          <xsd:element minOccurs=""0"" name=""PARVW"">
                            <xsd:annotation>
                              <xsd:documentation>Partner function (e.g. sold-to party, ship-to party, ...)</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""3"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""PARTN"">
                            <xsd:annotation>
                              <xsd:documentation>Partner number</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""17"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""LIFNR"">
                            <xsd:annotation>
                              <xsd:documentation>Vendor number at customer location</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""17"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""NAME"">
                            <xsd:annotation>
                              <xsd:documentation>MM 158 iDoc Address Component</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""80"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""ADDR1"">
                            <xsd:annotation>
                              <xsd:documentation>MM 158 iDoc Address Component</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""80"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""ADDR2"">
                            <xsd:annotation>
                              <xsd:documentation>MM 158 iDoc Address Component</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""80"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""ADDR3"">
                            <xsd:annotation>
                              <xsd:documentation>MM 158 iDoc Address Component</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""80"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""ADDR4"">
                            <xsd:annotation>
                              <xsd:documentation>MM 158 iDoc Address Component</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""80"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""ADDR5"">
                            <xsd:annotation>
                              <xsd:documentation>MM 158 iDoc Address Component</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""80"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""ADDR6"">
                            <xsd:annotation>
                              <xsd:documentation>MM 158 iDoc Address Component</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""80"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""PSTLZ"">
                            <xsd:annotation>
                              <xsd:documentation>Postal code</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""9"" />
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
                    <xsd:element minOccurs=""0"" maxOccurs=""99"" name=""E1EDKA3"">
                      <xsd:annotation>
                        <xsd:documentation>IDoc: Document Header Partner Information Additional Data</xsd:documentation>
                      </xsd:annotation>
                      <xsd:complexType>
                        <xsd:sequence>
                          <xsd:element minOccurs=""0"" name=""QUALP"">
                            <xsd:annotation>
                              <xsd:documentation>IDOC Partner identification (e.g.Dun&amp;Bradstreet number)</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""3"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""STDPN"">
                            <xsd:annotation>
                              <xsd:documentation>Character field, length 70</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""70"" />
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
              <xsd:element minOccurs=""0"" maxOccurs=""10"" name=""E1EDK02"">
                <xsd:annotation>
                  <xsd:documentation>IDoc: Document header reference data</xsd:documentation>
                </xsd:annotation>
                <xsd:complexType>
                  <xsd:sequence>
                    <xsd:element minOccurs=""0"" name=""QUALF"">
                      <xsd:annotation>
                        <xsd:documentation>IDOC qualifier reference document</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""3"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""BELNR"">
                      <xsd:annotation>
                        <xsd:documentation>IDOC document number</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""35"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""POSNR"">
                      <xsd:annotation>
                        <xsd:documentation>Item number</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""6"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""DATUM"">
                      <xsd:annotation>
                        <xsd:documentation>IDOC: Date</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""8"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""UZEIT"">
                      <xsd:annotation>
                        <xsd:documentation>IDOC: Time</xsd:documentation>
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
              <xsd:element minOccurs=""0"" maxOccurs=""4"" name=""E1EDK17"">
                <xsd:annotation>
                  <xsd:documentation>IDoc: Document Header Terms of Delivery</xsd:documentation>
                </xsd:annotation>
                <xsd:complexType>
                  <xsd:sequence>
                    <xsd:element minOccurs=""0"" name=""QUALF"">
                      <xsd:annotation>
                        <xsd:documentation>IDOC qualifier: Terms of delivery</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""3"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""LKOND"">
                      <xsd:annotation>
                        <xsd:documentation>IDOC delivery condition code</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""3"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""LKTEXT"">
                      <xsd:annotation>
                        <xsd:documentation>IDOC delivery condition text</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""70"" />
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
              <xsd:element minOccurs=""0"" maxOccurs=""3"" name=""E1EDK18"">
                <xsd:annotation>
                  <xsd:documentation>IDoc: Document Header Terms of Payment</xsd:documentation>
                </xsd:annotation>
                <xsd:complexType>
                  <xsd:sequence>
                    <xsd:element minOccurs=""0"" name=""QUALF"">
                      <xsd:annotation>
                        <xsd:documentation>IDOC qualifier: Terms of payment</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""3"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""TAGE"">
                      <xsd:annotation>
                        <xsd:documentation>IDOC Number of days</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""8"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""PRZNT"">
                      <xsd:annotation>
                        <xsd:documentation>IDOC percentage for terms of payment</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""8"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""ZTERM_TXT"">
                      <xsd:annotation>
                        <xsd:documentation>Text line</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""70"" />
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
              <xsd:element minOccurs=""0"" maxOccurs=""99999"" name=""E1EDK35"">
                <xsd:annotation>
                  <xsd:documentation>IDoc: Document Header Additional Data</xsd:documentation>
                </xsd:annotation>
                <xsd:complexType>
                  <xsd:sequence>
                    <xsd:element minOccurs=""0"" name=""QUALZ"">
                      <xsd:annotation>
                        <xsd:documentation>Qualifier for IDoc additional data</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""3"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""CUSADD"">
                      <xsd:annotation>
                        <xsd:documentation>Data Element Type CHAR Length 35</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""35"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""CUSADD_BEZ"">
                      <xsd:annotation>
                        <xsd:documentation>Character field of length 40</xsd:documentation>
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
              <xsd:element minOccurs=""0"" maxOccurs=""99"" name=""E1EDK36"">
                <xsd:annotation>
                  <xsd:documentation>IDOC: Doc.header payment cards</xsd:documentation>
                </xsd:annotation>
                <xsd:complexType>
                  <xsd:sequence>
                    <xsd:element minOccurs=""0"" name=""CCINS"">
                      <xsd:annotation>
                        <xsd:documentation>Payment cards: Card type</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""4"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""CCINS_BEZEI"">
                      <xsd:annotation>
                        <xsd:documentation>Description</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""20"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""CCNUM"">
                      <xsd:annotation>
                        <xsd:documentation>Payment cards: Card number</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""25"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""EXDATBI"">
                      <xsd:annotation>
                        <xsd:documentation>IDOC: Date</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""8"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""CCNAME"">
                      <xsd:annotation>
                        <xsd:documentation>Payment cards: Name of cardholder</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""40"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""FAKWR"">
                      <xsd:annotation>
                        <xsd:documentation>Maximum amount</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""17"" />
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
              <xsd:element minOccurs=""0"" maxOccurs=""99"" name=""E1EDKT1"">
                <xsd:annotation>
                  <xsd:documentation>IDoc: Document Header Text Identification</xsd:documentation>
                </xsd:annotation>
                <xsd:complexType>
                  <xsd:sequence>
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
                    <xsd:element minOccurs=""0"" name=""TSSPRAS"">
                      <xsd:annotation>
                        <xsd:documentation>Language Key</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""3"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""TSSPRAS_ISO"">
                      <xsd:annotation>
                        <xsd:documentation>Language according to ISO 639</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""2"" />
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
                    <xsd:element minOccurs=""0"" name=""TDOBNAME"">
                      <xsd:annotation>
                        <xsd:documentation>Name</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""70"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" maxOccurs=""999999"" name=""E1EDKT2"">
                      <xsd:annotation>
                        <xsd:documentation>IDoc: Document Header Texts</xsd:documentation>
                      </xsd:annotation>
                      <xsd:complexType>
                        <xsd:sequence>
                          <xsd:element minOccurs=""0"" name=""TDLINE"">
                            <xsd:annotation>
                              <xsd:documentation>Text line</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""70"" />
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
              <xsd:element minOccurs=""0"" maxOccurs=""999999"" name=""E1EDP01"">
                <xsd:annotation>
                  <xsd:documentation>IDoc: Document Item General Data</xsd:documentation>
                </xsd:annotation>
                <xsd:complexType>
                  <xsd:sequence>
                    <xsd:element minOccurs=""0"" name=""POSEX"">
                      <xsd:annotation>
                        <xsd:documentation>Item number</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""6"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""ACTION"">
                      <xsd:annotation>
                        <xsd:documentation>Action code for the item</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""3"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""PSTYP"">
                      <xsd:annotation>
                        <xsd:documentation>Item Category</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""1"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""KZABS"">
                      <xsd:annotation>
                        <xsd:documentation>Flag: order acknowledgment required</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""1"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""MENGE"">
                      <xsd:annotation>
                        <xsd:documentation>Quantity</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""15"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""MENEE"">
                      <xsd:annotation>
                        <xsd:documentation>Unit of measure</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""3"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""BMNG2"">
                      <xsd:annotation>
                        <xsd:documentation>Quantity in price unit</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""15"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""PMENE"">
                      <xsd:annotation>
                        <xsd:documentation>Price Unit of Measure</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""3"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""ABFTZ"">
                      <xsd:annotation>
                        <xsd:documentation>Agreed cumulative quantity</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""7"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""VPREI"">
                      <xsd:annotation>
                        <xsd:documentation>Price (net)</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""15"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""PEINH"">
                      <xsd:annotation>
                        <xsd:documentation>Price unit</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""9"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""NETWR"">
                      <xsd:annotation>
                        <xsd:documentation>Item value (net)</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""18"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""ANETW"">
                      <xsd:annotation>
                        <xsd:documentation>Absolute net value of item</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""18"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""SKFBP"">
                      <xsd:annotation>
                        <xsd:documentation>Amount qualifying for cash discount</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""18"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""NTGEW"">
                      <xsd:annotation>
                        <xsd:documentation>Net weight</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""18"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""GEWEI"">
                      <xsd:annotation>
                        <xsd:documentation>Weight unit</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""3"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""EINKZ"">
                      <xsd:annotation>
                        <xsd:documentation>Flag: More than one schedule line for the item</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""1"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""CURCY"">
                      <xsd:annotation>
                        <xsd:documentation>Currency</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""3"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""PREIS"">
                      <xsd:annotation>
                        <xsd:documentation>Gross price</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""18"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""MATKL"">
                      <xsd:annotation>
                        <xsd:documentation>IDOC material class</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""9"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""UEPOS"">
                      <xsd:annotation>
                        <xsd:documentation>Higher-Level Item in BOM Structures</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""6"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""GRKOR"">
                      <xsd:annotation>
                        <xsd:documentation>Delivery group (items delivered together)</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""3"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""EVERS"">
                      <xsd:annotation>
                        <xsd:documentation>Shipping instructions</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""7"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""BPUMN"">
                      <xsd:annotation>
                        <xsd:documentation>Denominator for Conv. of Order Price Unit into Order Unit</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""6"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""BPUMZ"">
                      <xsd:annotation>
                        <xsd:documentation>Numerator for Conversion of Order Price Unit into Order Unit</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""6"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""ABGRU"">
                      <xsd:annotation>
                        <xsd:documentation>Reason for rejection of quotations and sales orders</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""2"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""ABGRT"">
                      <xsd:annotation>
                        <xsd:documentation>Description</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""40"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""ANTLF"">
                      <xsd:annotation>
                        <xsd:documentation>Maximum number of partial deliveries allowed per item</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""1"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""FIXMG"">
                      <xsd:annotation>
                        <xsd:documentation>Delivery date and quantity fixed</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""1"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""KZAZU"">
                      <xsd:annotation>
                        <xsd:documentation>Order Combination Indicator</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""1"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""BRGEW"">
                      <xsd:annotation>
                        <xsd:documentation>Total weight</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""18"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""PSTYV"">
                      <xsd:annotation>
                        <xsd:documentation>Sales document item category</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""4"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""EMPST"">
                      <xsd:annotation>
                        <xsd:documentation>Receiving point</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""25"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""ABTNR"">
                      <xsd:annotation>
                        <xsd:documentation>Department number</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""4"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""ABRVW"">
                      <xsd:annotation>
                        <xsd:documentation>Usage Indicator</xsd:documentation>
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
                    <xsd:element minOccurs=""0"" name=""LPRIO"">
                      <xsd:annotation>
                        <xsd:documentation>Delivery Priority</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""2"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""LPRIO_BEZ"">
                      <xsd:annotation>
                        <xsd:documentation>Description</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""20"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""ROUTE"">
                      <xsd:annotation>
                        <xsd:documentation>Route</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""6"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""ROUTE_BEZ"">
                      <xsd:annotation>
                        <xsd:documentation>Description</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""40"" />
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
                    <xsd:element minOccurs=""0"" name=""VSTEL"">
                      <xsd:annotation>
                        <xsd:documentation>Shipping Point/Receiving Point</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""4"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""DELCO"">
                      <xsd:annotation>
                        <xsd:documentation>Agreed delivery time</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""3"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""MATNR"">
                      <xsd:annotation>
                        <xsd:documentation>IDOC material ID</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""35"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""VALTG"">
                      <xsd:annotation>
                        <xsd:documentation>Additional value days</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""2"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""HIPOS"">
                      <xsd:annotation>
                        <xsd:documentation>Superior item in an item hierarchy</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""6"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""HIEVW"">
                      <xsd:annotation>
                        <xsd:documentation>Use of Hierarchy Item</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""1"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""POSGUID"">
                      <xsd:annotation>
                        <xsd:documentation>ATP: Encryption of DELNR and DELPS</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""22"" />
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
                    <xsd:element minOccurs=""0"" maxOccurs=""10"" name=""E1EDP02"">
                      <xsd:annotation>
                        <xsd:documentation>IDoc: Document Item Reference Data</xsd:documentation>
                      </xsd:annotation>
                      <xsd:complexType>
                        <xsd:sequence>
                          <xsd:element minOccurs=""0"" name=""QUALF"">
                            <xsd:annotation>
                              <xsd:documentation>IDOC qualifier reference document</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""3"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""BELNR"">
                            <xsd:annotation>
                              <xsd:documentation>IDOC document number</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""35"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""ZEILE"">
                            <xsd:annotation>
                              <xsd:documentation>Item number</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""6"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""DATUM"">
                            <xsd:annotation>
                              <xsd:documentation>IDOC: Date</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""8"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""UZEIT"">
                            <xsd:annotation>
                              <xsd:documentation>IDOC: Time</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""6"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""BSARK"">
                            <xsd:annotation>
                              <xsd:documentation>IDOC organization</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""35"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""IHREZ"">
                            <xsd:annotation>
                              <xsd:documentation>Your reference (Partner)</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""30"" />
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
                    <xsd:element minOccurs=""0"" name=""E1CUREF"">
                      <xsd:annotation>
                        <xsd:documentation>CU: Reference order item / instance in configuration</xsd:documentation>
                      </xsd:annotation>
                      <xsd:complexType>
                        <xsd:sequence>
                          <xsd:element minOccurs=""0"" name=""POSEX"">
                            <xsd:annotation>
                              <xsd:documentation>Character field of length 6</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""6"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""CONFIG_ID"">
                            <xsd:annotation>
                              <xsd:documentation>Character field of length 6</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""6"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""INST_ID"">
                            <xsd:annotation>
                              <xsd:documentation>Character field, 8 characters long</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""8"" />
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
                    <xsd:element minOccurs=""0"" maxOccurs=""999999"" name=""E1ADDI1"">
                      <xsd:annotation>
                        <xsd:documentation>IDoc: Additionals</xsd:documentation>
                      </xsd:annotation>
                      <xsd:complexType>
                        <xsd:sequence>
                          <xsd:element minOccurs=""0"" name=""ADDIMATNR"">
                            <xsd:annotation>
                              <xsd:documentation>Material number for additional</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""18"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""ADDINUMBER"">
                            <xsd:annotation>
                              <xsd:documentation>Number of additionals</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""17"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""ADDIVKME"">
                            <xsd:annotation>
                              <xsd:documentation>Sales unit of the material</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""3"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""ADDIFM"">
                            <xsd:annotation>
                              <xsd:documentation>Procedure for additionals</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""4"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""ADDIFM_TXT"">
                            <xsd:annotation>
                              <xsd:documentation>Additionals: Description for the procedure for additionals</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""40"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""ADDIKLART"">
                            <xsd:annotation>
                              <xsd:documentation>Class type displayed when editing additionals</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""3"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""ADDIKLART_TXT"">
                            <xsd:annotation>
                              <xsd:documentation>Text describing class type</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""40"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""ADDICLASS"">
                            <xsd:annotation>
                              <xsd:documentation>Class with additionals assigned to its elements</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""18"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""ADDICLASS_TXT"">
                            <xsd:annotation>
                              <xsd:documentation>Keywords</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""40"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""ADDIIDOC"">
                            <xsd:annotation>
                              <xsd:documentation>Indicator which refers to separate additionals IDoc</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""ADDIMATNR_EXTERNAL"">
                            <xsd:annotation>
                              <xsd:documentation>Long Material Number for ADDIMATNR Field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""40"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""ADDIMATNR_VERSION"">
                            <xsd:annotation>
                              <xsd:documentation>Version Number for ADDIMATNR Field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""10"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""ADDIMATNR_GUID"">
                            <xsd:annotation>
                              <xsd:documentation>External GUID for ADDIMATNR Field</xsd:documentation>
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
                    <xsd:element minOccurs=""0"" maxOccurs=""10"" name=""E1EDP03"">
                      <xsd:annotation>
                        <xsd:documentation>IDoc: Document Item Date Segment</xsd:documentation>
                      </xsd:annotation>
                      <xsd:complexType>
                        <xsd:sequence>
                          <xsd:element minOccurs=""0"" name=""IDDAT"">
                            <xsd:annotation>
                              <xsd:documentation>Qualifier for IDOC date segment</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""3"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""DATUM"">
                            <xsd:annotation>
                              <xsd:documentation>Date</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""8"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""UZEIT"">
                            <xsd:annotation>
                              <xsd:documentation>Time</xsd:documentation>
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
                    <xsd:element minOccurs=""0"" maxOccurs=""10"" name=""E1EDP04"">
                      <xsd:annotation>
                        <xsd:documentation>IDoc: Document Item Taxes</xsd:documentation>
                      </xsd:annotation>
                      <xsd:complexType>
                        <xsd:sequence>
                          <xsd:element minOccurs=""0"" name=""MWSKZ"">
                            <xsd:annotation>
                              <xsd:documentation>VAT indicator</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""7"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""MSATZ"">
                            <xsd:annotation>
                              <xsd:documentation>VAT rate</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""17"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""MWSBT"">
                            <xsd:annotation>
                              <xsd:documentation>Value added tax amount</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""18"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""TXJCD"">
                            <xsd:annotation>
                              <xsd:documentation>Tax Jurisdiction</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""15"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""KTEXT"">
                            <xsd:annotation>
                              <xsd:documentation>Text Field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""50"" />
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
                    <xsd:element minOccurs=""0"" maxOccurs=""16"" name=""E1EDP05"">
                      <xsd:annotation>
                        <xsd:documentation>IDoc: Document Item Conditions</xsd:documentation>
                      </xsd:annotation>
                      <xsd:complexType>
                        <xsd:sequence>
                          <xsd:element minOccurs=""0"" name=""ALCKZ"">
                            <xsd:annotation>
                              <xsd:documentation>Surcharge or discount indicator</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""3"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""KSCHL"">
                            <xsd:annotation>
                              <xsd:documentation>Condition type (coded)</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""4"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""KOTXT"">
                            <xsd:annotation>
                              <xsd:documentation>Condition text</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""80"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""BETRG"">
                            <xsd:annotation>
                              <xsd:documentation>Fixed surcharge/discount on total gross</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""18"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""KPERC"">
                            <xsd:annotation>
                              <xsd:documentation>Condition percentage rate</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""8"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""KRATE"">
                            <xsd:annotation>
                              <xsd:documentation>Condition record per unit</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""15"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""UPRBS"">
                            <xsd:annotation>
                              <xsd:documentation>Price unit</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""9"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""MEAUN"">
                            <xsd:annotation>
                              <xsd:documentation>Unit of measurement</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""3"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""KOBTR"">
                            <xsd:annotation>
                              <xsd:documentation>IDoc condition end amount</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""18"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""MENGE"">
                            <xsd:annotation>
                              <xsd:documentation>Price scale quantity (SPEC2000)</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""15"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""PREIS"">
                            <xsd:annotation>
                              <xsd:documentation>Price by unit of measure (SPEC2000)</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""15"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""MWSKZ"">
                            <xsd:annotation>
                              <xsd:documentation>VAT indicator</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""7"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""MSATZ"">
                            <xsd:annotation>
                              <xsd:documentation>VAT rate</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""17"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""KOEIN"">
                            <xsd:annotation>
                              <xsd:documentation>Currency</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""3"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""CURTP"">
                            <xsd:annotation>
                              <xsd:documentation>Currency Type and Valuation View</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""2"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""KOBAS"">
                            <xsd:annotation>
                              <xsd:documentation>Base value to which condition refers</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""18"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" maxOccurs=""99"" name=""E1EDPS5"">
                            <xsd:annotation>
                              <xsd:documentation>A&amp;D: Price Scale (Quantity)</xsd:documentation>
                            </xsd:annotation>
                            <xsd:complexType>
                              <xsd:sequence>
                                <xsd:element minOccurs=""0"" name=""KSTBM"">
                                  <xsd:annotation>
                                    <xsd:documentation>Condition scale quantity</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""17"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""KBETR"">
                                  <xsd:annotation>
                                    <xsd:documentation>Rate (condition amount or percentage)</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""13"" />
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
                    <xsd:element minOccurs=""0"" maxOccurs=""9999"" name=""E1EDP20"">
                      <xsd:annotation>
                        <xsd:documentation>IDoc schedule lines</xsd:documentation>
                      </xsd:annotation>
                      <xsd:complexType>
                        <xsd:sequence>
                          <xsd:element minOccurs=""0"" name=""WMENG"">
                            <xsd:annotation>
                              <xsd:documentation>Scheduled quantity</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""15"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""AMENG"">
                            <xsd:annotation>
                              <xsd:documentation>Previous scheduled quantity</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""15"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""EDATU"">
                            <xsd:annotation>
                              <xsd:documentation>IDOC: Date</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""8"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""EZEIT"">
                            <xsd:annotation>
                              <xsd:documentation>IDOC: Time</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""6"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""EDATU_OLD"">
                            <xsd:annotation>
                              <xsd:documentation>IDOC: Date</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""8"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""EZEIT_OLD"">
                            <xsd:annotation>
                              <xsd:documentation>IDOC: Time</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""6"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""ACTION"">
                            <xsd:annotation>
                              <xsd:documentation>Action code for the item</xsd:documentation>
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
                    <xsd:element minOccurs=""0"" maxOccurs=""8"" name=""E1EDPA1"">
                      <xsd:annotation>
                        <xsd:documentation>IDoc: Doc.item partner information</xsd:documentation>
                      </xsd:annotation>
                      <xsd:complexType>
                        <xsd:sequence>
                          <xsd:element minOccurs=""0"" name=""PARVW"">
                            <xsd:annotation>
                              <xsd:documentation>Partner function (e.g. sold-to party, ship-to party, ...)</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""3"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""PARTN"">
                            <xsd:annotation>
                              <xsd:documentation>Partner number</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""17"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""LIFNR"">
                            <xsd:annotation>
                              <xsd:documentation>Vendor number at customer location</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""17"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""NAME1"">
                            <xsd:annotation>
                              <xsd:documentation>Name 1</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""35"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""NAME2"">
                            <xsd:annotation>
                              <xsd:documentation>Name 2</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""35"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""NAME3"">
                            <xsd:annotation>
                              <xsd:documentation>Name 3</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""35"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""NAME4"">
                            <xsd:annotation>
                              <xsd:documentation>Name 4</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""35"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""STRAS"">
                            <xsd:annotation>
                              <xsd:documentation>Street and house number 1</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""35"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""STRS2"">
                            <xsd:annotation>
                              <xsd:documentation>Street and house number 2</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""35"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""PFACH"">
                            <xsd:annotation>
                              <xsd:documentation>PO Box</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""35"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""ORT01"">
                            <xsd:annotation>
                              <xsd:documentation>City</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""35"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""COUNC"">
                            <xsd:annotation>
                              <xsd:documentation>County code</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""9"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""PSTLZ"">
                            <xsd:annotation>
                              <xsd:documentation>Postal code</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""9"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""PSTL2"">
                            <xsd:annotation>
                              <xsd:documentation>P.O. Box postal code</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""9"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""LAND1"">
                            <xsd:annotation>
                              <xsd:documentation>Country Key</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""3"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""ABLAD"">
                            <xsd:annotation>
                              <xsd:documentation>Unloading Point</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""35"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""PERNR"">
                            <xsd:annotation>
                              <xsd:documentation>Contact person's personnel number</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""30"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""PARNR"">
                            <xsd:annotation>
                              <xsd:documentation>Contact person's number (not personnel number)</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""30"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""TELF1"">
                            <xsd:annotation>
                              <xsd:documentation>1st telephone number of contact person</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""25"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""TELF2"">
                            <xsd:annotation>
                              <xsd:documentation>2nd telephone number of contact person</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""25"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""TELBX"">
                            <xsd:annotation>
                              <xsd:documentation>Telebox number</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""25"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""TELFX"">
                            <xsd:annotation>
                              <xsd:documentation>Fax number</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""25"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""TELTX"">
                            <xsd:annotation>
                              <xsd:documentation>Teletex number</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""25"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""TELX1"">
                            <xsd:annotation>
                              <xsd:documentation>Telex number</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""25"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""SPRAS"">
                            <xsd:annotation>
                              <xsd:documentation>Language key</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""ANRED"">
                            <xsd:annotation>
                              <xsd:documentation>Form of Address</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""15"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""ORT02"">
                            <xsd:annotation>
                              <xsd:documentation>District</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""35"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""HAUSN"">
                            <xsd:annotation>
                              <xsd:documentation>House number</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""6"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""STOCK"">
                            <xsd:annotation>
                              <xsd:documentation>Floor</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""6"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""REGIO"">
                            <xsd:annotation>
                              <xsd:documentation>Region</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""3"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""PARGE"">
                            <xsd:annotation>
                              <xsd:documentation>Partner's gender</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""ISOAL"">
                            <xsd:annotation>
                              <xsd:documentation>Country ISO code</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""2"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""ISONU"">
                            <xsd:annotation>
                              <xsd:documentation>Country ISO code</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""2"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""FCODE"">
                            <xsd:annotation>
                              <xsd:documentation>Company key (France)</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""20"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""IHREZ"">
                            <xsd:annotation>
                              <xsd:documentation>Your reference (Partner)</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""30"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""BNAME"">
                            <xsd:annotation>
                              <xsd:documentation>IDoc user name</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""35"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""PAORG"">
                            <xsd:annotation>
                              <xsd:documentation>IDOC organization code</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""30"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""ORGTX"">
                            <xsd:annotation>
                              <xsd:documentation>IDoc organization code text</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""35"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""PAGRU"">
                            <xsd:annotation>
                              <xsd:documentation>IDoc group code</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""30"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""KNREF"">
                            <xsd:annotation>
                              <xsd:documentation>Customer description of partner (plant, storage location)</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""30"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""ILNNR"">
                            <xsd:annotation>
                              <xsd:documentation>Character field, length 70</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""70"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""PFORT"">
                            <xsd:annotation>
                              <xsd:documentation>PO Box city</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""35"" />
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
                          <xsd:element minOccurs=""0"" name=""TITLE"">
                            <xsd:annotation>
                              <xsd:documentation>Title</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""15"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" maxOccurs=""99"" name=""E1EDPA3"">
                            <xsd:annotation>
                              <xsd:documentation>IDoc: Document Item Partner Information Additional Data</xsd:documentation>
                            </xsd:annotation>
                            <xsd:complexType>
                              <xsd:sequence>
                                <xsd:element minOccurs=""0"" name=""QUALP"">
                                  <xsd:annotation>
                                    <xsd:documentation>IDOC Partner identification (e.g.Dun&amp;Bradstreet number)</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""3"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""STDPN"">
                                  <xsd:annotation>
                                    <xsd:documentation>Character field, length 70</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""70"" />
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
                    <xsd:element minOccurs=""0"" maxOccurs=""5"" name=""E1EDP19"">
                      <xsd:annotation>
                        <xsd:documentation>IDoc: Document Item Object Identification</xsd:documentation>
                      </xsd:annotation>
                      <xsd:complexType>
                        <xsd:sequence>
                          <xsd:element minOccurs=""0"" name=""QUALF"">
                            <xsd:annotation>
                              <xsd:documentation>IDOC object identification such as material no.,customer</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""3"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""IDTNR"">
                            <xsd:annotation>
                              <xsd:documentation>IDOC material ID</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""35"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""KTEXT"">
                            <xsd:annotation>
                              <xsd:documentation>IDOC short text</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""70"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""MFRPN"">
                            <xsd:annotation>
                              <xsd:documentation>Manufacturer part number</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""42"" />
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
                          <xsd:element minOccurs=""0"" name=""IDTNR_EXTERNAL"">
                            <xsd:annotation>
                              <xsd:documentation>Length of Material (Future Development) for Field IDTNR</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""40"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""IDTNR_VERSION"">
                            <xsd:annotation>
                              <xsd:documentation>Version Number (Future Development) for Field IDTNR</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""10"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""IDTNR_GUID"">
                            <xsd:annotation>
                              <xsd:documentation>External GUID (Future Development) for Field IDTNR</xsd:documentation>
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
                    <xsd:element minOccurs=""0"" name=""E1EDPAD"">
                      <xsd:annotation>
                        <xsd:documentation>A&amp;D: Material Exchange</xsd:documentation>
                      </xsd:annotation>
                      <xsd:complexType>
                        <xsd:sequence>
                          <xsd:element minOccurs=""0"" name=""QUALF"">
                            <xsd:annotation>
                              <xsd:documentation>IDoc object identification(A&amp;D)</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""3"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""ICC"">
                            <xsd:annotation>
                              <xsd:documentation>Interchangeability Code</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""2"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""MOI"">
                            <xsd:annotation>
                              <xsd:documentation>Type Identification</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""4"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""PRI"">
                            <xsd:annotation>
                              <xsd:documentation>Order Priority</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""3"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""ACN"">
                            <xsd:annotation>
                              <xsd:documentation>Aircraft Registration Number</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""5"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""E1TXTH1"">
                            <xsd:annotation>
                              <xsd:documentation>General Text Header</xsd:documentation>
                            </xsd:annotation>
                            <xsd:complexType>
                              <xsd:sequence>
                                <xsd:element minOccurs=""0"" name=""FUNCTION"">
                                  <xsd:annotation>
                                    <xsd:documentation>Function (for transferred text)</xsd:documentation>
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
                                <xsd:element minOccurs=""0"" name=""TDOBNAME"">
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
                                    <xsd:documentation>Language</xsd:documentation>
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
                                <xsd:element minOccurs=""0"" name=""LANGUA_ISO"">
                                  <xsd:annotation>
                                    <xsd:documentation>Language key</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""2"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" maxOccurs=""100"" name=""E1TXTP1"">
                                  <xsd:annotation>
                                    <xsd:documentation>General Text Segment</xsd:documentation>
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
                    <xsd:element minOccurs=""0"" maxOccurs=""5"" name=""E1EDP17"">
                      <xsd:annotation>
                        <xsd:documentation>IDoc: Document item terms of delivery</xsd:documentation>
                      </xsd:annotation>
                      <xsd:complexType>
                        <xsd:sequence>
                          <xsd:element minOccurs=""0"" name=""QUALF"">
                            <xsd:annotation>
                              <xsd:documentation>IDOC qualifier: Terms of delivery</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""3"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""LKOND"">
                            <xsd:annotation>
                              <xsd:documentation>IDOC delivery condition code</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""3"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""LKTEXT"">
                            <xsd:annotation>
                              <xsd:documentation>IDOC delivery condition text</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""70"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""LPRIO"">
                            <xsd:annotation>
                              <xsd:documentation>Delivery Priority</xsd:documentation>
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
                    <xsd:element minOccurs=""0"" maxOccurs=""3"" name=""E1EDP18"">
                      <xsd:annotation>
                        <xsd:documentation>IDoc: Document Item Terms of Payment</xsd:documentation>
                      </xsd:annotation>
                      <xsd:complexType>
                        <xsd:sequence>
                          <xsd:element minOccurs=""0"" name=""QUALF"">
                            <xsd:annotation>
                              <xsd:documentation>IDOC qualifier: Terms of payment</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""3"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""TAGE"">
                            <xsd:annotation>
                              <xsd:documentation>IDOC Number of days</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""8"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""PRZNT"">
                            <xsd:annotation>
                              <xsd:documentation>IDOC percentage for terms of payment</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""8"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""ZTERM_TXT"">
                            <xsd:annotation>
                              <xsd:documentation>Text line</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""70"" />
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
                    <xsd:element minOccurs=""0"" maxOccurs=""99999"" name=""E1EDP35"">
                      <xsd:annotation>
                        <xsd:documentation>IDoc: Document Item Additional Data</xsd:documentation>
                      </xsd:annotation>
                      <xsd:complexType>
                        <xsd:sequence>
                          <xsd:element minOccurs=""0"" name=""QUALZ"">
                            <xsd:annotation>
                              <xsd:documentation>Qualifier for IDoc additional data</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""3"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""CUSADD"">
                            <xsd:annotation>
                              <xsd:documentation>Data Element Type CHAR Length 35</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""35"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""CUSADD_BEZ"">
                            <xsd:annotation>
                              <xsd:documentation>Character field of length 40</xsd:documentation>
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
                    <xsd:element minOccurs=""0"" maxOccurs=""999999"" name=""E1EDPT1"">
                      <xsd:annotation>
                        <xsd:documentation>IDoc: Document Item Text Identification</xsd:documentation>
                      </xsd:annotation>
                      <xsd:complexType>
                        <xsd:sequence>
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
                          <xsd:element minOccurs=""0"" name=""TSSPRAS"">
                            <xsd:annotation>
                              <xsd:documentation>Language Key</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""3"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""TSSPRAS_ISO"">
                            <xsd:annotation>
                              <xsd:documentation>Language according to ISO 639</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""2"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" maxOccurs=""999999"" name=""E1EDPT2"">
                            <xsd:annotation>
                              <xsd:documentation>IDoc: Document Item Texts</xsd:documentation>
                            </xsd:annotation>
                            <xsd:complexType>
                              <xsd:sequence>
                                <xsd:element minOccurs=""0"" name=""TDLINE"">
                                  <xsd:annotation>
                                    <xsd:documentation>Text line</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""70"" />
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
                    <xsd:element minOccurs=""0"" maxOccurs=""999999"" name=""E1EDC01"">
                      <xsd:annotation>
                        <xsd:documentation>SS: Service specifications general data</xsd:documentation>
                      </xsd:annotation>
                      <xsd:complexType>
                        <xsd:sequence>
                          <xsd:element minOccurs=""0"" name=""SGTYP"">
                            <xsd:annotation>
                              <xsd:documentation>IDoc service specifications segment type</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""3"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""ZLTYP"">
                            <xsd:annotation>
                              <xsd:documentation>IDoc service specifications line category</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""3"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""LVALT"">
                            <xsd:annotation>
                              <xsd:documentation>IDoc service specifications alternatives</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""3"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""ALTNO"">
                            <xsd:annotation>
                              <xsd:documentation>IDoc alternative number for service specifications</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""2"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""ALREF"">
                            <xsd:annotation>
                              <xsd:documentation>IDoc Assignment Number for Service Specifications</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""5"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""ZLART"">
                            <xsd:annotation>
                              <xsd:documentation>IDoc service specifications line type</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""3"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""POSEX"">
                            <xsd:annotation>
                              <xsd:documentation>Line Number</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:pattern value=""\d+"" />
                                <xsd:maxLength value=""10"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""RANG"">
                            <xsd:annotation>
                              <xsd:documentation>Hierarchy level of group</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""2"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""EXGRP"">
                            <xsd:annotation>
                              <xsd:documentation>Outline Level</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""8"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""UEPOS"">
                            <xsd:annotation>
                              <xsd:documentation>Higher-Level Item in BOM Structures</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""6"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""MATKL"">
                            <xsd:annotation>
                              <xsd:documentation>IDOC material class</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""9"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""MENGE"">
                            <xsd:annotation>
                              <xsd:documentation>Quantity</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""15"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""MENEE"">
                            <xsd:annotation>
                              <xsd:documentation>Unit of measure</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""3"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""BMNG2"">
                            <xsd:annotation>
                              <xsd:documentation>Quantity in price unit</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""15"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""PMENE"">
                            <xsd:annotation>
                              <xsd:documentation>Price Unit of Measure</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""3"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""BPUMN"">
                            <xsd:annotation>
                              <xsd:documentation>Denominator for Conv. of Order Price Unit into Order Unit</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""6"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""BPUMZ"">
                            <xsd:annotation>
                              <xsd:documentation>Numerator for Conversion of Order Price Unit into Order Unit</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""6"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""VPREI"">
                            <xsd:annotation>
                              <xsd:documentation>Price (net)</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""15"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""PEINH"">
                            <xsd:annotation>
                              <xsd:documentation>Price unit</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""9"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""NETWR"">
                            <xsd:annotation>
                              <xsd:documentation>Item value (net)</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""18"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""ANETW"">
                            <xsd:annotation>
                              <xsd:documentation>Absolute net value of item</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""18"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""SKFBP"">
                            <xsd:annotation>
                              <xsd:documentation>Amount qualifying for cash discount</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""18"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""CURCY"">
                            <xsd:annotation>
                              <xsd:documentation>Currency</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""3"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""PREIS"">
                            <xsd:annotation>
                              <xsd:documentation>Gross price</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""18"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""ACTION"">
                            <xsd:annotation>
                              <xsd:documentation>Action code for the item</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""3"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""KZABS"">
                            <xsd:annotation>
                              <xsd:documentation>Flag: order acknowledgment required</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""UEBTO"">
                            <xsd:annotation>
                              <xsd:documentation>overfulfillment tolerance</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""4"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""UEBTK"">
                            <xsd:annotation>
                              <xsd:documentation>Unlimited Overfulfillment</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""LBNUM"">
                            <xsd:annotation>
                              <xsd:documentation>Short Description of Service Type</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""3"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""AUSGB"">
                            <xsd:annotation>
                              <xsd:documentation>Edition of Service Type</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:pattern value=""\d+"" />
                                <xsd:maxLength value=""4"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""FRPOS"">
                            <xsd:annotation>
                              <xsd:documentation>Lower Limit</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""6"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""TOPOS"">
                            <xsd:annotation>
                              <xsd:documentation>Upper Limit</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""6"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""KTXT1"">
                            <xsd:annotation>
                              <xsd:documentation>Short Text</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""40"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""KTXT2"">
                            <xsd:annotation>
                              <xsd:documentation>Short Text</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""40"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""PERNR"">
                            <xsd:annotation>
                              <xsd:documentation>Personnel Number</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:pattern value=""\d+"" />
                                <xsd:maxLength value=""8"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""LGART"">
                            <xsd:annotation>
                              <xsd:documentation>Wage Type</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""4"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""STELL"">
                            <xsd:annotation>
                              <xsd:documentation>Job</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:pattern value=""\d+"" />
                                <xsd:maxLength value=""8"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""ZWERT"">
                            <xsd:annotation>
                              <xsd:documentation>Total value of sum segment</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""18"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" maxOccurs=""10"" name=""E1EDC02"">
                            <xsd:annotation>
                              <xsd:documentation>SS item: Reference data</xsd:documentation>
                            </xsd:annotation>
                            <xsd:complexType>
                              <xsd:sequence>
                                <xsd:element minOccurs=""0"" name=""QUALF"">
                                  <xsd:annotation>
                                    <xsd:documentation>IDoc qualifier reference document for service specifications</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""3"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""BELNR"">
                                  <xsd:annotation>
                                    <xsd:documentation>IDOC document number</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""35"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""XLINE"">
                                  <xsd:annotation>
                                    <xsd:documentation>Line Number</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:pattern value=""\d+"" />
                                      <xsd:maxLength value=""10"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""DATUM"">
                                  <xsd:annotation>
                                    <xsd:documentation>IDOC: Date</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""8"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""UZEIT"">
                                  <xsd:annotation>
                                    <xsd:documentation>IDOC: Time</xsd:documentation>
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
                          <xsd:element minOccurs=""0"" maxOccurs=""10"" name=""E1EDC03"">
                            <xsd:annotation>
                              <xsd:documentation>SS item: Date segment</xsd:documentation>
                            </xsd:annotation>
                            <xsd:complexType>
                              <xsd:sequence>
                                <xsd:element minOccurs=""0"" name=""IDDAT"">
                                  <xsd:annotation>
                                    <xsd:documentation>Qualifier for IDOC date segment</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""3"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""DATUM"">
                                  <xsd:annotation>
                                    <xsd:documentation>Date</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""8"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""UZEIT"">
                                  <xsd:annotation>
                                    <xsd:documentation>Time</xsd:documentation>
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
                          <xsd:element minOccurs=""0"" maxOccurs=""10"" name=""E1EDC04"">
                            <xsd:annotation>
                              <xsd:documentation>SS item: Taxes</xsd:documentation>
                            </xsd:annotation>
                            <xsd:complexType>
                              <xsd:sequence>
                                <xsd:element minOccurs=""0"" name=""MWSKZ"">
                                  <xsd:annotation>
                                    <xsd:documentation>VAT indicator</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""7"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""MSATZ"">
                                  <xsd:annotation>
                                    <xsd:documentation>VAT rate</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""17"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""MWSBT"">
                                  <xsd:annotation>
                                    <xsd:documentation>Value added tax amount</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""18"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""TXJCD"">
                                  <xsd:annotation>
                                    <xsd:documentation>Tax Jurisdiction</xsd:documentation>
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
                          <xsd:element minOccurs=""0"" maxOccurs=""16"" name=""E1EDC05"">
                            <xsd:annotation>
                              <xsd:documentation>SS item: Conditions</xsd:documentation>
                            </xsd:annotation>
                            <xsd:complexType>
                              <xsd:sequence>
                                <xsd:element minOccurs=""0"" name=""ALCKZ"">
                                  <xsd:annotation>
                                    <xsd:documentation>Surcharge or discount indicator</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""3"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""KSCHL"">
                                  <xsd:annotation>
                                    <xsd:documentation>Condition type (coded)</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""4"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""KOTXT"">
                                  <xsd:annotation>
                                    <xsd:documentation>Condition text</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""80"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""BETRG"">
                                  <xsd:annotation>
                                    <xsd:documentation>Fixed surcharge/discount on total gross</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""18"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""KPERC"">
                                  <xsd:annotation>
                                    <xsd:documentation>Condition percentage rate</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""8"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""KRATE"">
                                  <xsd:annotation>
                                    <xsd:documentation>Condition record per unit</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""15"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""UPRBS"">
                                  <xsd:annotation>
                                    <xsd:documentation>Price unit</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""9"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""MEAUN"">
                                  <xsd:annotation>
                                    <xsd:documentation>Unit of measurement</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""3"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""KOBTR"">
                                  <xsd:annotation>
                                    <xsd:documentation>IDoc condition end amount</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""18"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""MENGE"">
                                  <xsd:annotation>
                                    <xsd:documentation>Price scale quantity (SPEC2000)</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""15"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""PREIS"">
                                  <xsd:annotation>
                                    <xsd:documentation>Price by unit of measure (SPEC2000)</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""15"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""MWSKZ"">
                                  <xsd:annotation>
                                    <xsd:documentation>VAT indicator</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""7"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""MSATZ"">
                                  <xsd:annotation>
                                    <xsd:documentation>VAT rate</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""17"" />
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
                          <xsd:element minOccurs=""0"" name=""E1EDC06"">
                            <xsd:annotation>
                              <xsd:documentation>Service line formula fields</xsd:documentation>
                            </xsd:annotation>
                            <xsd:complexType>
                              <xsd:sequence>
                                <xsd:element minOccurs=""0"" name=""FORMELNR"">
                                  <xsd:annotation>
                                    <xsd:documentation>Formula Number</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""10"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""FRMVAL1"">
                                  <xsd:annotation>
                                    <xsd:documentation>Formula Value</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""15"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""FRMVAL2"">
                                  <xsd:annotation>
                                    <xsd:documentation>Formula Value</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""15"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""FRMVAL3"">
                                  <xsd:annotation>
                                    <xsd:documentation>Formula Value</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""15"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""FRMVAL4"">
                                  <xsd:annotation>
                                    <xsd:documentation>Formula Value</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""15"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""FRMVAL5"">
                                  <xsd:annotation>
                                    <xsd:documentation>Formula Value</xsd:documentation>
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
                          <xsd:element minOccurs=""0"" name=""E1EDC07"">
                            <xsd:annotation>
                              <xsd:documentation>Service line user fields</xsd:documentation>
                            </xsd:annotation>
                            <xsd:complexType>
                              <xsd:sequence>
                                <xsd:element minOccurs=""0"" name=""USERF1_NUM"">
                                  <xsd:annotation>
                                    <xsd:documentation>User-Defined Field</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""10"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""USERF2_NUM"">
                                  <xsd:annotation>
                                    <xsd:documentation>User-Defined Field</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""15"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""USERF1_TXT"">
                                  <xsd:annotation>
                                    <xsd:documentation>User-Defined Field</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""40"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""USERF2_TXT"">
                                  <xsd:annotation>
                                    <xsd:documentation>User-Defined Field</xsd:documentation>
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
                          <xsd:element minOccurs=""0"" maxOccurs=""8"" name=""E1EDCA1"">
                            <xsd:annotation>
                              <xsd:documentation>SS items: Partner information</xsd:documentation>
                            </xsd:annotation>
                            <xsd:complexType>
                              <xsd:sequence>
                                <xsd:element minOccurs=""0"" name=""PARVW"">
                                  <xsd:annotation>
                                    <xsd:documentation>Partner function (e.g. sold-to party, ship-to party, ...)</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""3"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""PARTN"">
                                  <xsd:annotation>
                                    <xsd:documentation>Partner number</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""17"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""LIFNR"">
                                  <xsd:annotation>
                                    <xsd:documentation>Vendor number at customer location</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""17"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""NAME1"">
                                  <xsd:annotation>
                                    <xsd:documentation>Name 1</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""35"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""NAME2"">
                                  <xsd:annotation>
                                    <xsd:documentation>Name 2</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""35"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""NAME3"">
                                  <xsd:annotation>
                                    <xsd:documentation>Name 3</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""35"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""NAME4"">
                                  <xsd:annotation>
                                    <xsd:documentation>Name 4</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""35"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""STRAS"">
                                  <xsd:annotation>
                                    <xsd:documentation>Street and house number 1</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""35"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""STRS2"">
                                  <xsd:annotation>
                                    <xsd:documentation>Street and house number 2</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""35"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""PFACH"">
                                  <xsd:annotation>
                                    <xsd:documentation>PO Box</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""35"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""ORT01"">
                                  <xsd:annotation>
                                    <xsd:documentation>City</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""35"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""COUNC"">
                                  <xsd:annotation>
                                    <xsd:documentation>County code</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""9"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""PSTLZ"">
                                  <xsd:annotation>
                                    <xsd:documentation>Postal code</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""9"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""PSTL2"">
                                  <xsd:annotation>
                                    <xsd:documentation>P.O. Box postal code</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""9"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""LAND1"">
                                  <xsd:annotation>
                                    <xsd:documentation>Country Key</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""3"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""ABLAD"">
                                  <xsd:annotation>
                                    <xsd:documentation>Unloading Point</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""35"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""PERNR"">
                                  <xsd:annotation>
                                    <xsd:documentation>Contact person's personnel number</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""30"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""PARNR"">
                                  <xsd:annotation>
                                    <xsd:documentation>Contact person's number (not personnel number)</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""30"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""TELF1"">
                                  <xsd:annotation>
                                    <xsd:documentation>1st telephone number of contact person</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""25"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""TELF2"">
                                  <xsd:annotation>
                                    <xsd:documentation>2nd telephone number of contact person</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""25"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""TELBX"">
                                  <xsd:annotation>
                                    <xsd:documentation>Telebox number</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""25"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""TELFX"">
                                  <xsd:annotation>
                                    <xsd:documentation>Fax number</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""25"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""TELTX"">
                                  <xsd:annotation>
                                    <xsd:documentation>Teletex number</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""25"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""TELX1"">
                                  <xsd:annotation>
                                    <xsd:documentation>Telex number</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""25"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""SPRAS"">
                                  <xsd:annotation>
                                    <xsd:documentation>Language key</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""1"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""ANRED"">
                                  <xsd:annotation>
                                    <xsd:documentation>Form of Address</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""15"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""ORT02"">
                                  <xsd:annotation>
                                    <xsd:documentation>District</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""35"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""HAUSN"">
                                  <xsd:annotation>
                                    <xsd:documentation>House number</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""6"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""STOCK"">
                                  <xsd:annotation>
                                    <xsd:documentation>Floor</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""6"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""REGIO"">
                                  <xsd:annotation>
                                    <xsd:documentation>Region</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""3"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""PARGE"">
                                  <xsd:annotation>
                                    <xsd:documentation>Partner's gender</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""1"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""ISOAL"">
                                  <xsd:annotation>
                                    <xsd:documentation>Country ISO code</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""2"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""ISONU"">
                                  <xsd:annotation>
                                    <xsd:documentation>Country ISO code</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""2"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""FCODE"">
                                  <xsd:annotation>
                                    <xsd:documentation>Company key (France)</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""20"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""IHREZ"">
                                  <xsd:annotation>
                                    <xsd:documentation>Your reference (Partner)</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""30"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""BNAME"">
                                  <xsd:annotation>
                                    <xsd:documentation>IDoc user name</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""35"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""PAORG"">
                                  <xsd:annotation>
                                    <xsd:documentation>IDOC organization code</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""30"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""ORGTX"">
                                  <xsd:annotation>
                                    <xsd:documentation>IDoc organization code text</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""35"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""PAGRU"">
                                  <xsd:annotation>
                                    <xsd:documentation>IDoc group code</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""30"" />
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
                          <xsd:element minOccurs=""0"" maxOccurs=""5"" name=""E1EDC19"">
                            <xsd:annotation>
                              <xsd:documentation>SS items: Object identification</xsd:documentation>
                            </xsd:annotation>
                            <xsd:complexType>
                              <xsd:sequence>
                                <xsd:element minOccurs=""0"" name=""QUALF"">
                                  <xsd:annotation>
                                    <xsd:documentation>IDoc object identification for service specfns object</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""3"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""IDTNR"">
                                  <xsd:annotation>
                                    <xsd:documentation>IDOC material ID</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""35"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""KTEXT"">
                                  <xsd:annotation>
                                    <xsd:documentation>IDOC short text</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""70"" />
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
                          <xsd:element minOccurs=""0"" maxOccurs=""5"" name=""E1EDC17"">
                            <xsd:annotation>
                              <xsd:documentation>SS items: Terms of delivery</xsd:documentation>
                            </xsd:annotation>
                            <xsd:complexType>
                              <xsd:sequence>
                                <xsd:element minOccurs=""0"" name=""QUALF"">
                                  <xsd:annotation>
                                    <xsd:documentation>IDOC qualifier: Terms of delivery</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""3"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""LKOND"">
                                  <xsd:annotation>
                                    <xsd:documentation>IDOC delivery condition code</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""3"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""LKTEXT"">
                                  <xsd:annotation>
                                    <xsd:documentation>IDOC delivery condition text</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""70"" />
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
                          <xsd:element minOccurs=""0"" maxOccurs=""3"" name=""E1EDC18"">
                            <xsd:annotation>
                              <xsd:documentation>SS items: Terms of payment</xsd:documentation>
                            </xsd:annotation>
                            <xsd:complexType>
                              <xsd:sequence>
                                <xsd:element minOccurs=""0"" name=""QUALF"">
                                  <xsd:annotation>
                                    <xsd:documentation>IDOC qualifier: Terms of payment</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""3"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""TAGE"">
                                  <xsd:annotation>
                                    <xsd:documentation>IDOC Number of days</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""8"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""PRZNT"">
                                  <xsd:annotation>
                                    <xsd:documentation>IDOC percentage for terms of payment</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""8"" />
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
                          <xsd:element minOccurs=""0"" maxOccurs=""999999"" name=""E1EDCT1"">
                            <xsd:annotation>
                              <xsd:documentation>SS items: Text identification</xsd:documentation>
                            </xsd:annotation>
                            <xsd:complexType>
                              <xsd:sequence>
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
                                <xsd:element minOccurs=""0"" name=""TSSPRAS"">
                                  <xsd:annotation>
                                    <xsd:documentation>Language Key</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""3"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" maxOccurs=""999999"" name=""E1EDCT2"">
                                  <xsd:annotation>
                                    <xsd:documentation>SS items: Texts</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:complexType>
                                    <xsd:sequence>
                                      <xsd:element minOccurs=""0"" name=""TDLINE"">
                                        <xsd:annotation>
                                          <xsd:documentation>Text line</xsd:documentation>
                                        </xsd:annotation>
                                        <xsd:simpleType>
                                          <xsd:restriction base=""xsd:string"">
                                            <xsd:maxLength value=""70"" />
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
              <xsd:element minOccurs=""0"" maxOccurs=""99999"" name=""E1CUCFG"">
                <xsd:annotation>
                  <xsd:documentation>CU: Configuration data</xsd:documentation>
                </xsd:annotation>
                <xsd:complexType>
                  <xsd:sequence>
                    <xsd:element minOccurs=""0"" name=""POSEX"">
                      <xsd:annotation>
                        <xsd:documentation>Character field of length 6</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""6"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""CONFIG_ID"">
                      <xsd:annotation>
                        <xsd:documentation>Character field of length 6</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""6"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""ROOT_ID"">
                      <xsd:annotation>
                        <xsd:documentation>Character field, 8 characters long</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""8"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""SCE"">
                      <xsd:annotation>
                        <xsd:documentation>CU: Only Information Transferred from SCE to Configuration</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""1"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""KBNAME"">
                      <xsd:annotation>
                        <xsd:documentation>Knowledge-Base Object</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""30"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""KBVERSION"">
                      <xsd:annotation>
                        <xsd:documentation>Runtime Version of SCE Knowledge Base</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""30"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""COMPLETE"">
                      <xsd:annotation>
                        <xsd:documentation>General Indicator</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""1"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""CONSISTENT"">
                      <xsd:annotation>
                        <xsd:documentation>General Indicator</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""1"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""CFGINFO"">
                      <xsd:annotation>
                        <xsd:documentation>CU: Configuration BLOB (SCE)</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""250"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""KBPROFILE"">
                      <xsd:annotation>
                        <xsd:documentation>Knowledge-Base Profile</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""30"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""KBLANGUAGE"">
                      <xsd:annotation>
                        <xsd:documentation>Configuration Language</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""1"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""CBASE_ID"">
                      <xsd:annotation>
                        <xsd:documentation>Instance Number (Persistent)</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""32"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""CBASE_ID_TYPE"">
                      <xsd:annotation>
                        <xsd:documentation>Type of Instance Number (Persistent)</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""1"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" maxOccurs=""99999"" name=""E1CUINS"">
                      <xsd:annotation>
                        <xsd:documentation>CU: Instance data</xsd:documentation>
                      </xsd:annotation>
                      <xsd:complexType>
                        <xsd:sequence>
                          <xsd:element minOccurs=""0"" name=""INST_ID"">
                            <xsd:annotation>
                              <xsd:documentation>Character field, 8 characters long</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""8"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""OBJ_TYPE"">
                            <xsd:annotation>
                              <xsd:documentation>Character Field Length = 10</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""10"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""CLASS_TYPE"">
                            <xsd:annotation>
                              <xsd:documentation>3-Byte field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""3"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""OBJ_KEY"">
                            <xsd:annotation>
                              <xsd:documentation>Comment</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""50"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""OBJ_TXT"">
                            <xsd:annotation>
                              <xsd:documentation>Character field, length 70</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""70"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""QUANTITY"">
                            <xsd:annotation>
                              <xsd:documentation>Char 15</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""15"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""AUTHOR"">
                            <xsd:annotation>
                              <xsd:documentation>Statement was Inferred</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""QUANTITY_UNIT"">
                            <xsd:annotation>
                              <xsd:documentation>Unit of Measure</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""3"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""COMPLETE"">
                            <xsd:annotation>
                              <xsd:documentation>General Indicator</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""CONSISTENT"">
                            <xsd:annotation>
                              <xsd:documentation>General Indicator</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""OBJECT_GUID"">
                            <xsd:annotation>
                              <xsd:documentation>GUID for TYPE_OF Statement of Instance</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""32"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""PERSIST_ID"">
                            <xsd:annotation>
                              <xsd:documentation>Instance Number (Persistent)</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""32"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""PERSIST_ID_TYPE"">
                            <xsd:annotation>
                              <xsd:documentation>Type of Instance Number (Persistent)</xsd:documentation>
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
                    <xsd:element minOccurs=""0"" maxOccurs=""99999"" name=""E1CUPRT"">
                      <xsd:annotation>
                        <xsd:documentation>CU: part-of data</xsd:documentation>
                      </xsd:annotation>
                      <xsd:complexType>
                        <xsd:sequence>
                          <xsd:element minOccurs=""0"" name=""PARENT_ID"">
                            <xsd:annotation>
                              <xsd:documentation>Character field, 8 characters long</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""8"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""INST_ID"">
                            <xsd:annotation>
                              <xsd:documentation>Character field, 8 characters long</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""8"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""PART_OF_NO"">
                            <xsd:annotation>
                              <xsd:documentation>Not More Closely Defined Area, Possibly Used for Patchlevels</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""4"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""OBJ_TYPE"">
                            <xsd:annotation>
                              <xsd:documentation>Character Field Length = 10</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""10"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""CLASS_TYPE"">
                            <xsd:annotation>
                              <xsd:documentation>3-Byte field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""3"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""OBJ_KEY"">
                            <xsd:annotation>
                              <xsd:documentation>Comment</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""50"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""AUTHOR"">
                            <xsd:annotation>
                              <xsd:documentation>Statement was Inferred</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""SALES_RELEVANT"">
                            <xsd:annotation>
                              <xsd:documentation>Part is Sales-Relevant</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""PART_OF_GUID"">
                            <xsd:annotation>
                              <xsd:documentation>GUID for PART_OF Statement for Instance</xsd:documentation>
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
                    <xsd:element minOccurs=""0"" maxOccurs=""99999"" name=""E1CUVAL"">
                      <xsd:annotation>
                        <xsd:documentation>CU: Characteristic valuation</xsd:documentation>
                      </xsd:annotation>
                      <xsd:complexType>
                        <xsd:sequence>
                          <xsd:element minOccurs=""0"" name=""INST_ID"">
                            <xsd:annotation>
                              <xsd:documentation>Character field, 8 characters long</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""8"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""CHARC"">
                            <xsd:annotation>
                              <xsd:documentation>Character field of length 40</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""40"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""CHARC_TXT"">
                            <xsd:annotation>
                              <xsd:documentation>Character field, length 70</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""70"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""VALUE"">
                            <xsd:annotation>
                              <xsd:documentation>Character field of length 40</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""40"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""VALUE_TXT"">
                            <xsd:annotation>
                              <xsd:documentation>Character field, length 70</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""70"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""AUTHOR"">
                            <xsd:annotation>
                              <xsd:documentation>Statement was Inferred</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""VALUE_TO"">
                            <xsd:annotation>
                              <xsd:documentation>Characteristic Value</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""40"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""VALCODE"">
                            <xsd:annotation>
                              <xsd:documentation>Value Type: Interval Limits - Single Values</xsd:documentation>
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
                    <xsd:element minOccurs=""0"" maxOccurs=""999999"" name=""E1CUBLB"">
                      <xsd:annotation>
                        <xsd:documentation>CU: Configuration BLOB (SCE)</xsd:documentation>
                      </xsd:annotation>
                      <xsd:complexType>
                        <xsd:sequence>
                          <xsd:element minOccurs=""0"" name=""CONTENT"">
                            <xsd:annotation>
                              <xsd:documentation>CU: Configuration BLOB (SCE)</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""250"" />
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
              <xsd:element minOccurs=""0"" maxOccurs=""999999"" name=""E1EDL37"">
                <xsd:annotation>
                  <xsd:documentation>Handling unit header</xsd:documentation>
                </xsd:annotation>
                <xsd:complexType>
                  <xsd:sequence>
                    <xsd:element minOccurs=""0"" name=""EXIDV"">
                      <xsd:annotation>
                        <xsd:documentation>External Handling Unit Identification</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""20"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""TARAG"">
                      <xsd:annotation>
                        <xsd:documentation>Tare weight of handling unit</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""17"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""GWEIT"">
                      <xsd:annotation>
                        <xsd:documentation>Weight Unit Tare</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""3"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""BRGEW"">
                      <xsd:annotation>
                        <xsd:documentation>Total Weight of Handling Unit</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""17"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""NTGEW"">
                      <xsd:annotation>
                        <xsd:documentation>Loading Weight of Handling Unit</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""17"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""MAGEW"">
                      <xsd:annotation>
                        <xsd:documentation>Allowed Loading Weight of a Handling Unit</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""17"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""GWEIM"">
                      <xsd:annotation>
                        <xsd:documentation>Weight Unit</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""3"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""BTVOL"">
                      <xsd:annotation>
                        <xsd:documentation>Total Volume of Handling Unit</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""17"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""NTVOL"">
                      <xsd:annotation>
                        <xsd:documentation>Loading Volume of Handling Unit</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""17"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""MAVOL"">
                      <xsd:annotation>
                        <xsd:documentation>Allowed Loading Volume for Handling Unit</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""17"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""VOLEM"">
                      <xsd:annotation>
                        <xsd:documentation>Volume unit</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""3"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""TAVOL"">
                      <xsd:annotation>
                        <xsd:documentation>Tare volume of handling unit</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""17"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""VOLET"">
                      <xsd:annotation>
                        <xsd:documentation>Volume Unit Tare</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""3"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""VEGR2"">
                      <xsd:annotation>
                        <xsd:documentation>Handling Unit Group 2                     (Freely Definable)</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""5"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""VEGR1"">
                      <xsd:annotation>
                        <xsd:documentation>Handling Unit Group 1                     (Freely Definable)</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""5"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""VEGR3"">
                      <xsd:annotation>
                        <xsd:documentation>Handling Unit Group 3                     (Freely Definable)</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""5"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""VHILM"">
                      <xsd:annotation>
                        <xsd:documentation>Packaging Materials</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""18"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""VEGR4"">
                      <xsd:annotation>
                        <xsd:documentation>Handling Unit Group 4                     (Freely Definable)</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""5"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""LAENG"">
                      <xsd:annotation>
                        <xsd:documentation>Length</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""15"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""VEGR5"">
                      <xsd:annotation>
                        <xsd:documentation>Handling Unit Group 5                     (Freely Definable)</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""5"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""BREIT"">
                      <xsd:annotation>
                        <xsd:documentation>Width</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""15"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""HOEHE"">
                      <xsd:annotation>
                        <xsd:documentation>Height</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""15"" />
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
                    <xsd:element minOccurs=""0"" name=""INHALT"">
                      <xsd:annotation>
                        <xsd:documentation>Description of Handling Unit Content</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""40"" />
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
                    <xsd:element minOccurs=""0"" name=""LADLG"">
                      <xsd:annotation>
                        <xsd:documentation>Lgth of loading platform in lgth of LdPlat measurement units</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""8"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""LADEH"">
                      <xsd:annotation>
                        <xsd:documentation>Unit of measure to measure the length of loading platform</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""3"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""FARZT"">
                      <xsd:annotation>
                        <xsd:documentation>Travel Time</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""4"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""FAREH"">
                      <xsd:annotation>
                        <xsd:documentation>Unit of travel time</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""3"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""ENTFE"">
                      <xsd:annotation>
                        <xsd:documentation>Distance Travelled</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""8"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""EHENT"">
                      <xsd:annotation>
                        <xsd:documentation>Unit of distance</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""3"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""VELTP"">
                      <xsd:annotation>
                        <xsd:documentation>Packaging Material Category</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""1"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""EXIDV2"">
                      <xsd:annotation>
                        <xsd:documentation>Handling Unit's 2nd External Identification</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""20"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""LANDT"">
                      <xsd:annotation>
                        <xsd:documentation>Country providing means of transport</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""3"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""LANDF"">
                      <xsd:annotation>
                        <xsd:documentation>Driver's Nationality</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""3"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""NAMEF"">
                      <xsd:annotation>
                        <xsd:documentation>Driver name</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""35"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""NAMBE"">
                      <xsd:annotation>
                        <xsd:documentation>Alternate Driver's Name</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""35"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""VHILM_KU"">
                      <xsd:annotation>
                        <xsd:documentation>Material belonging to the customer</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""22"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""VEBEZ"">
                      <xsd:annotation>
                        <xsd:documentation>Description of Packaging Material</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""40"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""SMGKN"">
                      <xsd:annotation>
                        <xsd:documentation>SMG identification for material tag</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""1"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""KDMAT35"">
                      <xsd:annotation>
                        <xsd:documentation>Partner's (Customer's or Vendor's) Packaging Material</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""35"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""SORTL"">
                      <xsd:annotation>
                        <xsd:documentation>Sort field</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""10"" />
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
                    <xsd:element minOccurs=""0"" name=""GEWFX"">
                      <xsd:annotation>
                        <xsd:documentation>Weight and Volume Fixed</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""1"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""ERLKZ"">
                      <xsd:annotation>
                        <xsd:documentation>Status (at this time without functionality)</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""1"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""EXIDA"">
                      <xsd:annotation>
                        <xsd:documentation>Type of External Handling Unit Identifier</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""1"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""MOVE_STATUS"">
                      <xsd:annotation>
                        <xsd:documentation>Handling unit status</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""4"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""PACKVORSCHR"">
                      <xsd:annotation>
                        <xsd:documentation>Text string 22 characters</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""22"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""PACKVORSCHR_ST"">
                      <xsd:annotation>
                        <xsd:documentation>Single-Character Indicator</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""1"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""LABELTYP"">
                      <xsd:annotation>
                        <xsd:documentation>Indicator: do not print external shipping label</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""1"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""ZUL_AUFL"">
                      <xsd:annotation>
                        <xsd:documentation>17-Char. Field</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""17"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""VHILM_EXTERNAL"">
                      <xsd:annotation>
                        <xsd:documentation>Shipping Material</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""40"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""VHILM_VERSION"">
                      <xsd:annotation>
                        <xsd:documentation>Version Number for Field VHILM</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""10"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""VHILM_GUID"">
                      <xsd:annotation>
                        <xsd:documentation>External GUID for Field VHILM</xsd:documentation>
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
                    <xsd:element minOccurs=""0"" name=""VHILM_KU_EXTERNAL"">
                      <xsd:annotation>
                        <xsd:documentation>Long Material Number (Future Development) for Field VHILM</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""40"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""VHILM_KU_VERSION"">
                      <xsd:annotation>
                        <xsd:documentation>Version Number (Future Development) for Field VHILM_KU</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""10"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""VHILM_KU_GUID"">
                      <xsd:annotation>
                        <xsd:documentation>External GUID (Future Development) for Field VHILM_KU</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""32"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" maxOccurs=""9"" name=""E1EDL39"">
                      <xsd:annotation>
                        <xsd:documentation>Control Segment for Handling Units</xsd:documentation>
                      </xsd:annotation>
                      <xsd:complexType>
                        <xsd:sequence>
                          <xsd:element minOccurs=""0"" name=""QUALF"">
                            <xsd:annotation>
                              <xsd:documentation>Qualifier: Control (shipping unit)</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""3"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""PARAM"">
                            <xsd:annotation>
                              <xsd:documentation>IDOC: Control Parameters</xsd:documentation>
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
                    <xsd:element minOccurs=""0"" name=""E1EDL38"">
                      <xsd:annotation>
                        <xsd:documentation>Handling Unit Header Descriptions</xsd:documentation>
                      </xsd:annotation>
                      <xsd:complexType>
                        <xsd:sequence>
                          <xsd:element minOccurs=""0"" name=""VEGR1_BEZ"">
                            <xsd:annotation>
                              <xsd:documentation>Description of shipping unit 1</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""20"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""VEGR2_BEZ"">
                            <xsd:annotation>
                              <xsd:documentation>Description of shipping unit 2</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""20"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""VEGR3_BEZ"">
                            <xsd:annotation>
                              <xsd:documentation>Description of shipping unit 3</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""20"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""VEGR4_BEZ"">
                            <xsd:annotation>
                              <xsd:documentation>Description of shipping unit 4</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""20"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""VEGR5_BEZ"">
                            <xsd:annotation>
                              <xsd:documentation>Description of shipping unit 5</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""20"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""VHART_BEZ"">
                            <xsd:annotation>
                              <xsd:documentation>Description of shipping material type</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""20"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""MAGRV_BEZ"">
                            <xsd:annotation>
                              <xsd:documentation>Description of material grouping shipping material</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""20"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""VEBEZ"">
                            <xsd:annotation>
                              <xsd:documentation>Description of Packaging Material</xsd:documentation>
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
                    <xsd:element minOccurs=""0"" maxOccurs=""99999"" name=""E1EDL44"">
                      <xsd:annotation>
                        <xsd:documentation>IDoc: Handling Unit Item (Delivery)</xsd:documentation>
                      </xsd:annotation>
                      <xsd:complexType>
                        <xsd:sequence>
                          <xsd:element minOccurs=""0"" name=""VELIN"">
                            <xsd:annotation>
                              <xsd:documentation>Type of Handling-unit Item Content</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""VBELN"">
                            <xsd:annotation>
                              <xsd:documentation>Sales and Distribution Document Number</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""10"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""POSNR"">
                            <xsd:annotation>
                              <xsd:documentation>Item number of the SD document</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""6"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""EXIDV"">
                            <xsd:annotation>
                              <xsd:documentation>External Handling Unit Identification</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""20"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""VEMNG"">
                            <xsd:annotation>
                              <xsd:documentation>Base Quantity Packed in the Handling Unit Item</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""17"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""VEMEH"">
                            <xsd:annotation>
                              <xsd:documentation>Base Unit of Measure of the Quantity to be Packed (VEMNG)</xsd:documentation>
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
                          <xsd:element minOccurs=""0"" name=""KDMAT"">
                            <xsd:annotation>
                              <xsd:documentation>Material belonging to the customer</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""35"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""CHARG"">
                            <xsd:annotation>
                              <xsd:documentation>Batch Number</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""10"" />
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
                          <xsd:element minOccurs=""0"" name=""CUOBJ"">
                            <xsd:annotation>
                              <xsd:documentation>Configuration (internal object number)</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""18"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""BESTQ"">
                            <xsd:annotation>
                              <xsd:documentation>Stock Category in the Warehouse Management System</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""SOBKZ"">
                            <xsd:annotation>
                              <xsd:documentation>Special Stock Indicator</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""SONUM"">
                            <xsd:annotation>
                              <xsd:documentation>Special Stock Number</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""16"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""ANZSN"">
                            <xsd:annotation>
                              <xsd:documentation>Number of serial numbers</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""11"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""WDATU"">
                            <xsd:annotation>
                              <xsd:documentation>Date of Goods Receipt</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""8"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""PARID"">
                            <xsd:annotation>
                              <xsd:documentation>External partner number</xsd:documentation>
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
                          <xsd:element minOccurs=""0"" name=""KDMAT_EXTERNAL"">
                            <xsd:annotation>
                              <xsd:documentation>Customer Material</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""40"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""KDMAT_VERSION"">
                            <xsd:annotation>
                              <xsd:documentation>Customer Material</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""10"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""KDMAT_GUID"">
                            <xsd:annotation>
                              <xsd:documentation>Customer Material</xsd:documentation>
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
              <xsd:element minOccurs=""0"" maxOccurs=""5"" name=""E1EDS01"">
                <xsd:annotation>
                  <xsd:documentation>IDoc: Summary segment general</xsd:documentation>
                </xsd:annotation>
                <xsd:complexType>
                  <xsd:sequence>
                    <xsd:element minOccurs=""0"" name=""SUMID"">
                      <xsd:annotation>
                        <xsd:documentation>Qualifier for totals segment for shipping notification</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""3"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""SUMME"">
                      <xsd:annotation>
                        <xsd:documentation>Total value of sum segment</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""18"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""SUNIT"">
                      <xsd:annotation>
                        <xsd:documentation>Total value unit for totals segment in the shipping notif.</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""3"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""WAERQ"">
                      <xsd:annotation>
                        <xsd:documentation>Currency</xsd:documentation>
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
        
        public ORDERS05_ZMM158ORDERS() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "ZMM158ORDERS";
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
