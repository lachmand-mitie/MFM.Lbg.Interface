namespace MFM.Lbg.Schemas {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"",@"INVOIC02")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"INVOIC02"})]
    public sealed class INVOIC02 : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xsd:schema xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" version=""1.0"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"">
  <xsd:element name=""INVOIC02"">
    <xsd:annotation>
      <xsd:documentation>Invoice/Billing document</xsd:documentation>
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
                    <xsd:element fixed=""INVOIC02"" name=""IDOCTYP"" type=""xsd:string"">
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
              <xsd:element minOccurs=""0"" maxOccurs=""20"" name=""E1EDK02"">
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
              <xsd:element minOccurs=""0"" maxOccurs=""20"" name=""E1EDK03"">
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
              <xsd:element minOccurs=""0"" maxOccurs=""99"" name=""E1EDK05"">
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
              <xsd:element minOccurs=""0"" maxOccurs=""999"" name=""E1EDK04"">
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
              <xsd:element minOccurs=""0"" maxOccurs=""10"" name=""E1EDK17"">
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
              <xsd:element minOccurs=""0"" maxOccurs=""10"" name=""E1EDK18"">
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
              <xsd:element minOccurs=""0"" maxOccurs=""4"" name=""E1EDK23"">
                <xsd:annotation>
                  <xsd:documentation>IDoc: Document Header Currency Segment</xsd:documentation>
                </xsd:annotation>
                <xsd:complexType>
                  <xsd:sequence>
                    <xsd:element minOccurs=""0"" name=""QUALF"">
                      <xsd:annotation>
                        <xsd:documentation>Qualifier currency</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""3"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""WAERZ"">
                      <xsd:annotation>
                        <xsd:documentation>Three-digit character field for IDocs</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""3"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""WAERQ"">
                      <xsd:annotation>
                        <xsd:documentation>Three-digit character field for IDocs</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""3"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""KURS"">
                      <xsd:annotation>
                        <xsd:documentation>Character Field of Length 12</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""12"" />
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
                    <xsd:element minOccurs=""0"" name=""ZEIT"">
                      <xsd:annotation>
                        <xsd:documentation>IDOC: Time</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""6"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""KURS_M"">
                      <xsd:annotation>
                        <xsd:documentation>Indirectly quoted exchange rate in an IDoc segment</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""12"" />
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
              <xsd:element minOccurs=""0"" maxOccurs=""20"" name=""E1EDK28"">
                <xsd:annotation>
                  <xsd:documentation>IDoc: Document Header Bank Data</xsd:documentation>
                </xsd:annotation>
                <xsd:complexType>
                  <xsd:sequence>
                    <xsd:element minOccurs=""0"" name=""BCOUN"">
                      <xsd:annotation>
                        <xsd:documentation>Country Key</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""3"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""BRNUM"">
                      <xsd:annotation>
                        <xsd:documentation>Bank Key</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""17"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""BNAME"">
                      <xsd:annotation>
                        <xsd:documentation>Bank name</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""70"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""BALOC"">
                      <xsd:annotation>
                        <xsd:documentation>Location of bank</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""70"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""ACNUM"">
                      <xsd:annotation>
                        <xsd:documentation>Account number in bank data</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""30"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""ACNAM"">
                      <xsd:annotation>
                        <xsd:documentation>Account holder in bank data</xsd:documentation>
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
              <xsd:element minOccurs=""0"" maxOccurs=""20"" name=""E1EDK29"">
                <xsd:annotation>
                  <xsd:documentation>IDoc: Document Header General Foreign Trade Data</xsd:documentation>
                </xsd:annotation>
                <xsd:complexType>
                  <xsd:sequence>
                    <xsd:element minOccurs=""0"" name=""EXNUM"">
                      <xsd:annotation>
                        <xsd:documentation>Number of foreign trade data in MM and SD documents</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""10"" />
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
                    <xsd:element minOccurs=""0"" name=""EXPVZ"">
                      <xsd:annotation>
                        <xsd:documentation>Mode of Transport for Foreign Trade</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""1"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""ZOLLA"">
                      <xsd:annotation>
                        <xsd:documentation>Customs Office: Office of Exit/Entry for Foreign Trade</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""6"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""ZOLLB"">
                      <xsd:annotation>
                        <xsd:documentation>Customs office: Office of destination for foreign trade</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""6"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""ZOLL1"">
                      <xsd:annotation>
                        <xsd:documentation>Customs office: Customs office 1 for foreign trade</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""6"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""ZOLL2"">
                      <xsd:annotation>
                        <xsd:documentation>Customs office: Customs office 2 for foreign trade</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""6"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""ZOLL3"">
                      <xsd:annotation>
                        <xsd:documentation>Customs office: Customs office 3 for foreign trade</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""6"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""ZOLL4"">
                      <xsd:annotation>
                        <xsd:documentation>Customs office: Customs office 4 for foreign trade</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""6"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""ZOLL5"">
                      <xsd:annotation>
                        <xsd:documentation>Customs office: Customs office 5 for foreign trade</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""6"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""ZOLL6"">
                      <xsd:annotation>
                        <xsd:documentation>Customs office: Customs office 6 for foreign trade</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""6"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""KZGBE"">
                      <xsd:annotation>
                        <xsd:documentation>Indicator for means of transport crossing the border</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""30"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""KZABE"">
                      <xsd:annotation>
                        <xsd:documentation>Indicator for the means of transport at departure</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""30"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""STGBE"">
                      <xsd:annotation>
                        <xsd:documentation>Origin of Means of Transport when Crossing the Border</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""3"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""STABE"">
                      <xsd:annotation>
                        <xsd:documentation>Country of Origin of the Means of Transport at Departure</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""3"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""CONTA"">
                      <xsd:annotation>
                        <xsd:documentation>ID: Goods cross border in a container</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""1"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""GRWCU"">
                      <xsd:annotation>
                        <xsd:documentation>Currency of statistical values for foreign trade</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""5"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""GRWRT"">
                      <xsd:annotation>
                        <xsd:documentation>Total value of sum segment</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""18"" />
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
                    <xsd:element minOccurs=""0"" name=""LANDX"">
                      <xsd:annotation>
                        <xsd:documentation>Country Name</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""15"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""LANDA"">
                      <xsd:annotation>
                        <xsd:documentation>Alternative Country Key</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""3"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""XEGLD"">
                      <xsd:annotation>
                        <xsd:documentation>Indicator: European Union Member?</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""1"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""FREIH"">
                      <xsd:annotation>
                        <xsd:documentation>Indicator: Free Trade Area for Legal Control</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""1"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""EWRCO"">
                      <xsd:annotation>
                        <xsd:documentation>ID: European Economic Area (rel. for export control)</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""1"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""USC05"">
                      <xsd:annotation>
                        <xsd:documentation>USA: Five-Digit Country Code (SED: Schedule C Code)</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""5"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""JAP05"">
                      <xsd:annotation>
                        <xsd:documentation>Japan: Five digit country code (MITI customs declaration)</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""5"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""ALANX"">
                      <xsd:annotation>
                        <xsd:documentation>Country of dispatch - Description</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""15"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""ALANA"">
                      <xsd:annotation>
                        <xsd:documentation>Alternative country key for country of dispatch/export</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""3"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""LASTA"">
                      <xsd:annotation>
                        <xsd:documentation>Alt. key to nationality of means of transport (departarture)</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""3"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""LASTG"">
                      <xsd:annotation>
                        <xsd:documentation>Alt. key for nationality of means of transport at border</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""3"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""ALSCH"">
                      <xsd:annotation>
                        <xsd:documentation>Alternative country key for sold-to party</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""3"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""ALSRE"">
                      <xsd:annotation>
                        <xsd:documentation>Currency code by country directory</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""5"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""LADEO"">
                      <xsd:annotation>
                        <xsd:documentation>Place of loading</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""15"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""IEVER"">
                      <xsd:annotation>
                        <xsd:documentation>Domestic Mode of Transport for Foreign Trade</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""1"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""BANR01"">
                      <xsd:annotation>
                        <xsd:documentation>FT-EDI: Declarations to the authorities - ID no. 01</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""16"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""BANR02"">
                      <xsd:annotation>
                        <xsd:documentation>FT-EDI: Declarations to the authorities: ID no.</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""3"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""BANR03"">
                      <xsd:annotation>
                        <xsd:documentation>Customs number of exporter</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""7"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""BANR04"">
                      <xsd:annotation>
                        <xsd:documentation>Customs number of exporter</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""7"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""BANR05"">
                      <xsd:annotation>
                        <xsd:documentation>Customs number of exporter</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""7"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""BANR06"">
                      <xsd:annotation>
                        <xsd:documentation>Customs number of exporter</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""7"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""BANR07"">
                      <xsd:annotation>
                        <xsd:documentation>Customs number of exporter</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""7"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""BANR08"">
                      <xsd:annotation>
                        <xsd:documentation>Customs number of exporter</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""7"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""BANR09"">
                      <xsd:annotation>
                        <xsd:documentation>FT-EDI: Declarations to the authorities: ID no.</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""3"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""BANR10"">
                      <xsd:annotation>
                        <xsd:documentation>FT-EDI: Declarations to the authorities - ID no. 10</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""8"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""WZOCU"">
                      <xsd:annotation>
                        <xsd:documentation>Currency of customs values for import procg in foreign trade</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""5"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""EXPVZTX"">
                      <xsd:annotation>
                        <xsd:documentation>Description</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""20"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""ZOLLATX"">
                      <xsd:annotation>
                        <xsd:documentation>Description</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""30"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""ZOLLBTX"">
                      <xsd:annotation>
                        <xsd:documentation>Description</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""30"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""STGBETX"">
                      <xsd:annotation>
                        <xsd:documentation>Country Name</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""15"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""STABETX"">
                      <xsd:annotation>
                        <xsd:documentation>Country Name</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""15"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""FREIHTX"">
                      <xsd:annotation>
                        <xsd:documentation>Description</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""20"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""LADEL"">
                      <xsd:annotation>
                        <xsd:documentation>Place of loading/unloading for foreign trade</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""40"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""TEXT1"">
                      <xsd:annotation>
                        <xsd:documentation>Comments: Text for foreign trade processing</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""40"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""TEXT2"">
                      <xsd:annotation>
                        <xsd:documentation>Comments: Text for foreign trade processing</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""40"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""TEXT3"">
                      <xsd:annotation>
                        <xsd:documentation>Comments: Text for foreign trade processing</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""40"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""GBNUM"">
                      <xsd:annotation>
                        <xsd:documentation>Foreign Trade:Customs declaration list no. for Foreign Trade</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""20"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""REGNR"">
                      <xsd:annotation>
                        <xsd:documentation>Registration number for import processing in foreign trade</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""20"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""AUSFU"">
                      <xsd:annotation>
                        <xsd:documentation>Exporter for import processing in foreign trade</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""10"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""IEVER_TX"">
                      <xsd:annotation>
                        <xsd:documentation>Description</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""20"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""LAZL1"">
                      <xsd:annotation>
                        <xsd:documentation>Customs office: Country of customs office for foreign trade</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""3"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""LAZL2"">
                      <xsd:annotation>
                        <xsd:documentation>Customs office: Country of customs office for foreign trade</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""3"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""LAZL3"">
                      <xsd:annotation>
                        <xsd:documentation>Customs office: Country of customs office for foreign trade</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""3"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""LAZL4"">
                      <xsd:annotation>
                        <xsd:documentation>Customs office: Country of customs office for foreign trade</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""3"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""LAZL5"">
                      <xsd:annotation>
                        <xsd:documentation>Customs office: Country of customs office for foreign trade</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""3"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""LAZL6"">
                      <xsd:annotation>
                        <xsd:documentation>Customs office: Country of customs office for foreign trade</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""3"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""AZOLL"">
                      <xsd:annotation>
                        <xsd:documentation>Customs office: Export customs office for foreign trade</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""6"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""AZOLLTX"">
                      <xsd:annotation>
                        <xsd:documentation>Description</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""30"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""BFMAR"">
                      <xsd:annotation>
                        <xsd:documentation>Foreign Trade: Type of means of transport</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""6"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""FTVBD"">
                      <xsd:annotation>
                        <xsd:documentation>Association Indicator for Foreign Trade</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""1"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""CUDCL"">
                      <xsd:annotation>
                        <xsd:documentation>Customs declaration type for customs processing in FT</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""3"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""FTUPD"">
                      <xsd:annotation>
                        <xsd:documentation>Data service update indicator - Foreign Trade</xsd:documentation>
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
                    <xsd:element minOccurs=""0"" maxOccurs=""999"" name=""E1EDKT2"">
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
              <xsd:element minOccurs=""0"" maxOccurs=""10"" name=""E1EDK14"">
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
                    <xsd:element minOccurs=""0"" maxOccurs=""25"" name=""E1EDP02"">
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
                    <xsd:element minOccurs=""0"" maxOccurs=""25"" name=""E1EDP03"">
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
                    <xsd:element minOccurs=""0"" maxOccurs=""10"" name=""E1EDP19"">
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
                    <xsd:element minOccurs=""0"" maxOccurs=""20"" name=""E1EDP26"">
                      <xsd:annotation>
                        <xsd:documentation>IDoc: Document Item Amount Segment</xsd:documentation>
                      </xsd:annotation>
                      <xsd:complexType>
                        <xsd:sequence>
                          <xsd:element minOccurs=""0"" name=""QUALF"">
                            <xsd:annotation>
                              <xsd:documentation>Qualifier amount</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""3"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""BETRG"">
                            <xsd:annotation>
                              <xsd:documentation>Total value of sum segment</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""18"" />
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
                    <xsd:element minOccurs=""0"" maxOccurs=""20"" name=""E1EDPA1"">
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
                    <xsd:element minOccurs=""0"" maxOccurs=""99"" name=""E1EDP05"">
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
                    <xsd:element minOccurs=""0"" maxOccurs=""25"" name=""E1EDP04"">
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
                    <xsd:element minOccurs=""0"" maxOccurs=""9"" name=""E1EDP28"">
                      <xsd:annotation>
                        <xsd:documentation>IDoc: Document Item - General Foreign Trade Data</xsd:documentation>
                      </xsd:annotation>
                      <xsd:complexType>
                        <xsd:sequence>
                          <xsd:element minOccurs=""0"" name=""EXNUM"">
                            <xsd:annotation>
                              <xsd:documentation>Number of foreign trade data in MM and SD documents</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""10"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""EXPOS"">
                            <xsd:annotation>
                              <xsd:documentation>Internal item number for foreign trade data in MM and SD</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""6"" />
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
                          <xsd:element minOccurs=""0"" name=""EXART"">
                            <xsd:annotation>
                              <xsd:documentation>Business Transaction Type for Foreign Trade</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""2"" />
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
                          <xsd:element minOccurs=""0"" name=""HERTA"">
                            <xsd:annotation>
                              <xsd:documentation>Alternative country key for country of origin</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""3"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""HERTI"">
                            <xsd:annotation>
                              <xsd:documentation>Description of country of export/dispatch</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""15"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""STXT1"">
                            <xsd:annotation>
                              <xsd:documentation>Description of commodity code - First line</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""40"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""STXT2"">
                            <xsd:annotation>
                              <xsd:documentation>Description of commodity code - Second line</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""40"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""STXT3"">
                            <xsd:annotation>
                              <xsd:documentation>Description of commodity code - Third line</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""40"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""STXT4"">
                            <xsd:annotation>
                              <xsd:documentation>Description of commodity code - Fourth line</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""40"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""STXT5"">
                            <xsd:annotation>
                              <xsd:documentation>Description of commodity code - Fifth line</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""40"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""STXT6"">
                            <xsd:annotation>
                              <xsd:documentation>Description of commodity code - Sixth line</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""40"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""STXT7"">
                            <xsd:annotation>
                              <xsd:documentation>Description of commodity code - Seventh line</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""40"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""BEMAS"">
                            <xsd:annotation>
                              <xsd:documentation>Supplementary unit</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""5"" />
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
                          <xsd:element minOccurs=""0"" name=""BOLNR"">
                            <xsd:annotation>
                              <xsd:documentation>Bill of lading</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""35"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""TRATY"">
                            <xsd:annotation>
                              <xsd:documentation>Means-of-Transport Type</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""4"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""TRAID"">
                            <xsd:annotation>
                              <xsd:documentation>Means of Transport ID</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""20"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""BRULO"">
                            <xsd:annotation>
                              <xsd:documentation>Total weight</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""18"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""NETLO"">
                            <xsd:annotation>
                              <xsd:documentation>Net weight</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""18"" />
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
                          <xsd:element minOccurs=""0"" name=""BMGEW"">
                            <xsd:annotation>
                              <xsd:documentation>Net weight</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""18"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""TEXT1"">
                            <xsd:annotation>
                              <xsd:documentation>Comments: Text for foreign trade processing</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""40"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""TEXT2"">
                            <xsd:annotation>
                              <xsd:documentation>Comments: Text for foreign trade processing</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""40"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""TEXT3"">
                            <xsd:annotation>
                              <xsd:documentation>Comments: Text for foreign trade processing</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""40"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""COIMP"">
                            <xsd:annotation>
                              <xsd:documentation>Code number for import processing in foreign trade</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""17"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""COADI"">
                            <xsd:annotation>
                              <xsd:documentation>Anti-dumping code for import processing in foreign trade</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""6"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""COKON"">
                            <xsd:annotation>
                              <xsd:documentation>Customs quota code for import processing in foreign trade</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""6"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""COPHA"">
                            <xsd:annotation>
                              <xsd:documentation>Pharmaceutical products code (Foreign Trade)</xsd:documentation>
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
                          <xsd:element minOccurs=""0"" name=""VERLD"">
                            <xsd:annotation>
                              <xsd:documentation>Country of dispatch for Foreign Trade</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""3"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""VERLD_TX"">
                            <xsd:annotation>
                              <xsd:documentation>Country Name</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""15"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""HANLD"">
                            <xsd:annotation>
                              <xsd:documentation>Trading country for foreign trade</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""3"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""HANLD_TX"">
                            <xsd:annotation>
                              <xsd:documentation>Country Name</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""15"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""EXPRF_TX"">
                            <xsd:annotation>
                              <xsd:documentation>Description</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""30"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""EXART_TX"">
                            <xsd:annotation>
                              <xsd:documentation>Description</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""30"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""GBNUM"">
                            <xsd:annotation>
                              <xsd:documentation>Foreign Trade:Customs declaration list no. for Foreign Trade</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""20"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""REGNR"">
                            <xsd:annotation>
                              <xsd:documentation>Registration number for import processing in foreign trade</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""20"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""HERSE"">
                            <xsd:annotation>
                              <xsd:documentation>Manufacturer number for import processing in foreign trade</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""10"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""HERKR_TX"">
                            <xsd:annotation>
                              <xsd:documentation>Description</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""20"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""COBLD"">
                            <xsd:annotation>
                              <xsd:documentation>Import code no. in destination country for foreign trade</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""17"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""EIOKA"">
                            <xsd:annotation>
                              <xsd:documentation>EDI: Export/Import customs tariff number for foreign trade</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""VERFA"">
                            <xsd:annotation>
                              <xsd:documentation>Export/Import Procedure for Foreign Trade</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""8"" />
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
                              <xsd:documentation>Exemption certificate number for legal control</xsd:documentation>
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
                          <xsd:element minOccurs=""0"" name=""BESMA"">
                            <xsd:annotation>
                              <xsd:documentation>Supplementary unit</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""3"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""IMPMA"">
                            <xsd:annotation>
                              <xsd:documentation>Second unit of measurement</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""3"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""KTNUM"">
                            <xsd:annotation>
                              <xsd:documentation>Quota or Ceiling Number for Import Processing</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""10"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""PLNUM"">
                            <xsd:annotation>
                              <xsd:documentation>Quota or Ceiling Number for Import Processing</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""10"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""WKREG"">
                            <xsd:annotation>
                              <xsd:documentation>Region in which plant is located</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""3"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""IMGEW"">
                            <xsd:annotation>
                              <xsd:documentation>Net weight</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""18"" />
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
                    <xsd:element minOccurs=""0"" maxOccurs=""999999"" name=""E1EDP08"">
                      <xsd:annotation>
                        <xsd:documentation>IDoc: Package data individual</xsd:documentation>
                      </xsd:annotation>
                      <xsd:complexType>
                        <xsd:sequence>
                          <xsd:element minOccurs=""0"" name=""HLNUM"">
                            <xsd:annotation>
                              <xsd:documentation>Hierarchy number</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""12"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""PARENT"">
                            <xsd:annotation>
                              <xsd:documentation>Hierarchical parent ID</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""12"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""LEVEL"">
                            <xsd:annotation>
                              <xsd:documentation>Pack/subpack level ID</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""12"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""EXIDV"">
                            <xsd:annotation>
                              <xsd:documentation>External shipping unit ID</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""45"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""VENUM"">
                            <xsd:annotation>
                              <xsd:documentation>Internal Handling Unit Number</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""10"" />
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
                          <xsd:element minOccurs=""0"" name=""PCKAR"">
                            <xsd:annotation>
                              <xsd:documentation>Packing type</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""35"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""PCKNR"">
                            <xsd:annotation>
                              <xsd:documentation>Customer number of shipping unit</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""35"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""ANZAR"">
                            <xsd:annotation>
                              <xsd:documentation>Number of products per shipping unit</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""15"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""VBELN"">
                            <xsd:annotation>
                              <xsd:documentation>Delivery</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""35"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""POSNR"">
                            <xsd:annotation>
                              <xsd:documentation>Delivery item</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""30"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""BTGEW"">
                            <xsd:annotation>
                              <xsd:documentation>Total weight</xsd:documentation>
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
                          <xsd:element minOccurs=""0"" name=""TARAG"">
                            <xsd:annotation>
                              <xsd:documentation>Tare weight of shipping unit</xsd:documentation>
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
                          <xsd:element minOccurs=""0"" name=""BTVOL"">
                            <xsd:annotation>
                              <xsd:documentation>Total volume of shipping unit</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""18"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""NTVOL"">
                            <xsd:annotation>
                              <xsd:documentation>Loading volume of shipping unit</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""18"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""TAVOL"">
                            <xsd:annotation>
                              <xsd:documentation>Tare volume of shipping unit</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""18"" />
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
                          <xsd:element minOccurs=""0"" name=""LAENG"">
                            <xsd:annotation>
                              <xsd:documentation>Length</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""18"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""BREIT"">
                            <xsd:annotation>
                              <xsd:documentation>Width</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""18"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""HOEHE"">
                            <xsd:annotation>
                              <xsd:documentation>Height</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""18"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""MEABM"">
                            <xsd:annotation>
                              <xsd:documentation>Unit for length/width/height</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""3"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""MEINS"">
                            <xsd:annotation>
                              <xsd:documentation>Base unit of measure</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""3"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""VSTEL"">
                            <xsd:annotation>
                              <xsd:documentation>Shipping point</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""17"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""LSTEL"">
                            <xsd:annotation>
                              <xsd:documentation>Loading point</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""17"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""PKNRS"">
                            <xsd:annotation>
                              <xsd:documentation>Shipment number key for VDA/Odette</xsd:documentation>
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
                    <xsd:element minOccurs=""0"" maxOccurs=""99"" name=""E1EDP30"">
                      <xsd:annotation>
                        <xsd:documentation>IDOC: Document Item Account Assignment Intercompany Billing</xsd:documentation>
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
                          <xsd:element minOccurs=""0"" name=""IVKON"">
                            <xsd:annotation>
                              <xsd:documentation>30 Characters</xsd:documentation>
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
                    <xsd:element minOccurs=""0"" maxOccurs=""99"" name=""E1EDPT1"">
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
                          <xsd:element minOccurs=""0"" maxOccurs=""999"" name=""E1EDPT2"">
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
              <xsd:element minOccurs=""0"" maxOccurs=""30"" name=""E1EDS01"">
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
        
        public INVOIC02() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "INVOIC02";
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
