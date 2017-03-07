namespace MFM.Lbg.Schemas {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"",@"PORDCR102")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"PORDCR102"})]
    public sealed class PORDCR102 : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xsd:schema xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" version=""1.0"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"">
  <xsd:element name=""PORDCR102"">
    <xsd:annotation>
      <xsd:documentation>Create Purchase Order</xsd:documentation>
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
                    <xsd:element fixed=""PORDCR102"" name=""IDOCTYP"" type=""xsd:string"">
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
              <xsd:element minOccurs=""0"" name=""E1PORDCR1"">
                <xsd:annotation>
                  <xsd:documentation>Header Segment</xsd:documentation>
                </xsd:annotation>
                <xsd:complexType>
                  <xsd:sequence>
                    <xsd:element minOccurs=""0"" name=""TESTRUN"">
                      <xsd:annotation>
                        <xsd:documentation>Single-Character Indicator</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""1"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""MEMORY_UNCOMPLETE"">
                      <xsd:annotation>
                        <xsd:documentation>Single-Character Indicator</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""1"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""MEMORY_COMPLETE"">
                      <xsd:annotation>
                        <xsd:documentation>Single-Character Indicator</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""1"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""NO_MESSAGING"">
                      <xsd:annotation>
                        <xsd:documentation>Single-Character Indicator</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""1"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""NO_MESSAGE_REQ"">
                      <xsd:annotation>
                        <xsd:documentation>Single-Character Indicator</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""1"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""NO_AUTHORITY"">
                      <xsd:annotation>
                        <xsd:documentation>Single-Character Indicator</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""1"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""NO_PRICE_FROM_PO"">
                      <xsd:annotation>
                        <xsd:documentation>Single-Character Indicator</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""1"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""PARK_COMPLETE"">
                      <xsd:annotation>
                        <xsd:documentation>Single-Character Indicator</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""1"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""PARK_UNCOMPLETE"">
                      <xsd:annotation>
                        <xsd:documentation>Single-Character Indicator</xsd:documentation>
                      </xsd:annotation>
                      <xsd:simpleType>
                        <xsd:restriction base=""xsd:string"">
                          <xsd:maxLength value=""1"" />
                        </xsd:restriction>
                      </xsd:simpleType>
                    </xsd:element>
                    <xsd:element minOccurs=""0"" name=""E1BPMEPOHEADER"">
                      <xsd:annotation>
                        <xsd:documentation>Purchase Order Header Data</xsd:documentation>
                      </xsd:annotation>
                      <xsd:complexType>
                        <xsd:sequence>
                          <xsd:element minOccurs=""0"" name=""PO_NUMBER"">
                            <xsd:annotation>
                              <xsd:documentation>Purchasing Document Number</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""10"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""COMP_CODE"">
                            <xsd:annotation>
                              <xsd:documentation>Company Code</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""4"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""DOC_TYPE"">
                            <xsd:annotation>
                              <xsd:documentation>Purchasing Document Type</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""4"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""DELETE_IND"">
                            <xsd:annotation>
                              <xsd:documentation>Deletion Indicator in Purchasing Document</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""STATUS"">
                            <xsd:annotation>
                              <xsd:documentation>Status of Purchasing Document</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""CREAT_DATE"">
                            <xsd:annotation>
                              <xsd:documentation>Date on Which Record Was Created</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""8"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""CREATED_BY"">
                            <xsd:annotation>
                              <xsd:documentation>Name of Person who Created the Object</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""12"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""ITEM_INTVL"">
                            <xsd:annotation>
                              <xsd:documentation>Item Number Interval</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""5"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""VENDOR"">
                            <xsd:annotation>
                              <xsd:documentation>Vendor Account Number</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""10"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""LANGU"">
                            <xsd:annotation>
                              <xsd:documentation>Language Key</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""LANGU_ISO"">
                            <xsd:annotation>
                              <xsd:documentation>ISO code for language key</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""2"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""PMNTTRMS"">
                            <xsd:annotation>
                              <xsd:documentation>Terms of Payment Key</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""4"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""DSCNT1_TO"">
                            <xsd:annotation>
                              <xsd:documentation>Cash (Prompt Payment) Discount Days</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""4"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""DSCNT2_TO"">
                            <xsd:annotation>
                              <xsd:documentation>Cash (Prompt Payment) Discount Days</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""4"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""DSCNT3_TO"">
                            <xsd:annotation>
                              <xsd:documentation>Cash (Prompt Payment) Discount Days</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""4"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""DSCT_PCT1"">
                            <xsd:annotation>
                              <xsd:documentation>Cash Discount Percentage 1</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""7"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""DSCT_PCT2"">
                            <xsd:annotation>
                              <xsd:documentation>Cash Discount Percentage 2</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""7"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""PURCH_ORG"">
                            <xsd:annotation>
                              <xsd:documentation>Purchasing Organization</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""4"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""PUR_GROUP"">
                            <xsd:annotation>
                              <xsd:documentation>Purchasing Group</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""3"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""CURRENCY"">
                            <xsd:annotation>
                              <xsd:documentation>Currency Key</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""5"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""CURRENCY_ISO"">
                            <xsd:annotation>
                              <xsd:documentation>ISO code currency</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""3"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""EXCH_RATE"">
                            <xsd:annotation>
                              <xsd:documentation>Exchange Rate</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""11"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""EX_RATE_FX"">
                            <xsd:annotation>
                              <xsd:documentation>Indicator: Fixing of Exchange Rate</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""DOC_DATE"">
                            <xsd:annotation>
                              <xsd:documentation>Purchasing Document Date</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""8"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""VPER_START"">
                            <xsd:annotation>
                              <xsd:documentation>Start of Validity Period</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""8"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""VPER_END"">
                            <xsd:annotation>
                              <xsd:documentation>End of Validity Period</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""8"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""WARRANTY"">
                            <xsd:annotation>
                              <xsd:documentation>Warranty Date</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""8"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""QUOTATION"">
                            <xsd:annotation>
                              <xsd:documentation>Quotation Number</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""10"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""QUOT_DATE"">
                            <xsd:annotation>
                              <xsd:documentation>Quotation Submission Date</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""8"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""REF_1"">
                            <xsd:annotation>
                              <xsd:documentation>Your Reference</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""12"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""SALES_PERS"">
                            <xsd:annotation>
                              <xsd:documentation>Responsible Salesperson at Vendor's Office</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""30"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""TELEPHONE"">
                            <xsd:annotation>
                              <xsd:documentation>Vendor's Telephone Number</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""16"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""SUPPL_VEND"">
                            <xsd:annotation>
                              <xsd:documentation>Supplying Vendor</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""10"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""CUSTOMER"">
                            <xsd:annotation>
                              <xsd:documentation>Customer Number</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""10"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""AGREEMENT"">
                            <xsd:annotation>
                              <xsd:documentation>Number of Principal Purchase Agreement</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""10"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""GR_MESSAGE"">
                            <xsd:annotation>
                              <xsd:documentation>Indicator: Goods Receipt Message</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""SUPPL_PLNT"">
                            <xsd:annotation>
                              <xsd:documentation>Supplying (Issuing) Plant in Stock Transport Order</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""4"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""INCOTERMS1"">
                            <xsd:annotation>
                              <xsd:documentation>Incoterms (Part 1)</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""3"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""INCOTERMS2"">
                            <xsd:annotation>
                              <xsd:documentation>Incoterms (Part 2)</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""28"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""COLLECT_NO"">
                            <xsd:annotation>
                              <xsd:documentation>Collective Number</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""10"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""DIFF_INV"">
                            <xsd:annotation>
                              <xsd:documentation>Different Invoicing Party</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""10"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""OUR_REF"">
                            <xsd:annotation>
                              <xsd:documentation>Our Reference</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""12"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""LOGSYSTEM"">
                            <xsd:annotation>
                              <xsd:documentation>Logical System</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""10"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""SUBITEMINT"">
                            <xsd:annotation>
                              <xsd:documentation>Item Number Interval for Subitems</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""5"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""PO_REL_IND"">
                            <xsd:annotation>
                              <xsd:documentation>Release Indicator: Purchasing Document</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""REL_STATUS"">
                            <xsd:annotation>
                              <xsd:documentation>Release status</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""8"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""VAT_CNTRY"">
                            <xsd:annotation>
                              <xsd:documentation>Country of Sales Tax ID Number</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""3"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""VAT_CNTRY_ISO"">
                            <xsd:annotation>
                              <xsd:documentation>ISO country code for VAT registration number</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""2"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""REASON_CANCEL"">
                            <xsd:annotation>
                              <xsd:documentation>Reason for Cancellation</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""2"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""REASON_CODE"">
                            <xsd:annotation>
                              <xsd:documentation>Goods Receipt Reason Code</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""4"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""RETENTION_TYPE"">
                            <xsd:annotation>
                              <xsd:documentation>Retention Indicator</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""RETENTION_PERCENTAGE"">
                            <xsd:annotation>
                              <xsd:documentation>Retention in Percent</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""7"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""DOWNPAY_TYPE"">
                            <xsd:annotation>
                              <xsd:documentation>Down Payment Indicator</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""4"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""DOWNPAY_AMOUNT"">
                            <xsd:annotation>
                              <xsd:documentation>Down Payment Amount in BAPI</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""25"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""DOWNPAY_PERCENT"">
                            <xsd:annotation>
                              <xsd:documentation>Down Payment Percentage</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""7"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""DOWNPAY_DUEDATE"">
                            <xsd:annotation>
                              <xsd:documentation>Due Date for Down Payment</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""8"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""MEMORY"">
                            <xsd:annotation>
                              <xsd:documentation>Purchase order not yet complete</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""MEMORYTYPE"">
                            <xsd:annotation>
                              <xsd:documentation>Category of Incompleteness</xsd:documentation>
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
                    <xsd:element minOccurs=""0"" name=""E1BPMEPOHEADERX"">
                      <xsd:annotation>
                        <xsd:documentation>Purchase Order Header Data (Change Parameter)</xsd:documentation>
                      </xsd:annotation>
                      <xsd:complexType>
                        <xsd:sequence>
                          <xsd:element minOccurs=""0"" name=""PO_NUMBER"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""COMP_CODE"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""DOC_TYPE"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""DELETE_IND"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""STATUS"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""CREAT_DATE"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""CREATED_BY"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""ITEM_INTVL"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""VENDOR"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""LANGU"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""LANGU_ISO"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""PMNTTRMS"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""DSCNT1_TO"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""DSCNT2_TO"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""DSCNT3_TO"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""DSCT_PCT1"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""DSCT_PCT2"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""PURCH_ORG"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""PUR_GROUP"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""CURRENCY"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""CURRENCY_ISO"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""EXCH_RATE"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""EX_RATE_FX"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""DOC_DATE"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""VPER_START"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""VPER_END"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""WARRANTY"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""QUOTATION"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""QUOT_DATE"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""REF_1"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""SALES_PERS"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""TELEPHONE"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""SUPPL_VEND"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""CUSTOMER"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""AGREEMENT"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""GR_MESSAGE"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""SUPPL_PLNT"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""INCOTERMS1"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""INCOTERMS2"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""COLLECT_NO"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""DIFF_INV"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""OUR_REF"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""LOGSYSTEM"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""SUBITEMINT"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""PO_REL_IND"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""REL_STATUS"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""VAT_CNTRY"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""VAT_CNTRY_ISO"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""REASON_CANCEL"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""REASON_CODE"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""RETENTION_TYPE"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""RETENTION_PERCENTAGE"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""DOWNPAY_TYPE"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""DOWNPAY_AMOUNT"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""DOWNPAY_PERCENT"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""DOWNPAY_DUEDATE"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""MEMORY"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""MEMORYTYPE"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
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
                    <xsd:element minOccurs=""0"" name=""E1BPMEPOADDRVENDOR"">
                      <xsd:annotation>
                        <xsd:documentation>PO Header: Address Structure BAPIADDR1 for Vendor</xsd:documentation>
                      </xsd:annotation>
                      <xsd:complexType>
                        <xsd:sequence>
                          <xsd:element minOccurs=""0"" name=""PO_NUMBER"">
                            <xsd:annotation>
                              <xsd:documentation>Purchasing Document Number</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""10"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""ADDR_NO"">
                            <xsd:annotation>
                              <xsd:documentation>Address number</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""10"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""FORMOFADDR"">
                            <xsd:annotation>
                              <xsd:documentation>Form of address text</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""20"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""NAME"">
                            <xsd:annotation>
                              <xsd:documentation>Name 1</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""40"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""NAME_2"">
                            <xsd:annotation>
                              <xsd:documentation>Name 2</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""40"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""NAME_3"">
                            <xsd:annotation>
                              <xsd:documentation>Name 3</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""40"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""NAME_4"">
                            <xsd:annotation>
                              <xsd:documentation>Name 4</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""40"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""C_O_NAME"">
                            <xsd:annotation>
                              <xsd:documentation>c/o name</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""40"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""CITY"">
                            <xsd:annotation>
                              <xsd:documentation>City</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""40"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""DISTRICT"">
                            <xsd:annotation>
                              <xsd:documentation>District</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""40"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""CITY_NO"">
                            <xsd:annotation>
                              <xsd:documentation>City code for city/street file</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""12"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""POSTL_COD1"">
                            <xsd:annotation>
                              <xsd:documentation>City postal code</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""10"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""POSTL_COD2"">
                            <xsd:annotation>
                              <xsd:documentation>PO Box postal code</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""10"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""POSTL_COD3"">
                            <xsd:annotation>
                              <xsd:documentation>Company postal code (for large customers)</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""10"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""PO_BOX"">
                            <xsd:annotation>
                              <xsd:documentation>PO Box</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""10"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""PO_BOX_CIT"">
                            <xsd:annotation>
                              <xsd:documentation>PO Box city</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""40"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""DELIV_DIS"">
                            <xsd:annotation>
                              <xsd:documentation>(Not Supported) Post Delivery District</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""15"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""STREET"">
                            <xsd:annotation>
                              <xsd:documentation>Street name</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""40"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""STREET_NO"">
                            <xsd:annotation>
                              <xsd:documentation>Street Number for City/Street File</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""12"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""STR_ABBR"">
                            <xsd:annotation>
                              <xsd:documentation>(Not Supported) Abbreviation of Street Name</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""2"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""HOUSE_NO"">
                            <xsd:annotation>
                              <xsd:documentation>House Number</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""10"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""STR_SUPPL1"">
                            <xsd:annotation>
                              <xsd:documentation>Street 2</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""40"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""STR_SUPPL2"">
                            <xsd:annotation>
                              <xsd:documentation>Street 3</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""40"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""LOCATION"">
                            <xsd:annotation>
                              <xsd:documentation>Street 5</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""40"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""BUILDING"">
                            <xsd:annotation>
                              <xsd:documentation>old: building (no. or abbreviation)</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""10"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""FLOOR"">
                            <xsd:annotation>
                              <xsd:documentation>Floor in building</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""10"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""ROOM_NO"">
                            <xsd:annotation>
                              <xsd:documentation>Room or Appartment Number</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""10"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""COUNTRY"">
                            <xsd:annotation>
                              <xsd:documentation>Country Key</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""3"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""LANGU"">
                            <xsd:annotation>
                              <xsd:documentation>Language Key</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""REGION"">
                            <xsd:annotation>
                              <xsd:documentation>Region (State, Province, County)</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""3"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""SORT1"">
                            <xsd:annotation>
                              <xsd:documentation>Search Term 1</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""20"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""SORT2"">
                            <xsd:annotation>
                              <xsd:documentation>Search Term 2</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""20"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""TIME_ZONE"">
                            <xsd:annotation>
                              <xsd:documentation>Address time zone</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""6"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""TAXJURCODE"">
                            <xsd:annotation>
                              <xsd:documentation>Tax Jurisdiction</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""15"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""ADR_NOTES"">
                            <xsd:annotation>
                              <xsd:documentation>Address notes</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""50"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""COMM_TYPE"">
                            <xsd:annotation>
                              <xsd:documentation>Communication Method (Key) (Business Address Services)</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""3"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""TEL1_NUMBR"">
                            <xsd:annotation>
                              <xsd:documentation>First telephone no.: dialling code+number</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""30"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""TEL1_EXT"">
                            <xsd:annotation>
                              <xsd:documentation>First Telephone No.: Extension</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""10"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""FAX_NUMBER"">
                            <xsd:annotation>
                              <xsd:documentation>First fax no.: dialling code+number</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""30"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""FAX_EXTENS"">
                            <xsd:annotation>
                              <xsd:documentation>First fax no.: extension</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""10"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""STREET_LNG"">
                            <xsd:annotation>
                              <xsd:documentation>Street</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""60"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""DISTRCT_NO"">
                            <xsd:annotation>
                              <xsd:documentation>District code for City and Street file</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""8"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""CHCKSTATUS"">
                            <xsd:annotation>
                              <xsd:documentation>City file test status</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""PBOXCIT_NO"">
                            <xsd:annotation>
                              <xsd:documentation>City PO box code (City file)</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""12"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""TRANSPZONE"">
                            <xsd:annotation>
                              <xsd:documentation>Transportation zone to or from which the goods are delivered</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""10"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""HOUSE_NO2"">
                            <xsd:annotation>
                              <xsd:documentation>House number supplement</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""10"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""E1BPMEPOADDRVENDOR1"">
                            <xsd:annotation>
                              <xsd:documentation>PO Header: Address Structure BAPIADDR1 for Vendor</xsd:documentation>
                            </xsd:annotation>
                            <xsd:complexType>
                              <xsd:sequence>
                                <xsd:element minOccurs=""0"" name=""E_MAIL"">
                                  <xsd:annotation>
                                    <xsd:documentation>E-Mail Address</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""241"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""STR_SUPPL3"">
                                  <xsd:annotation>
                                    <xsd:documentation>Street 4</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""40"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""TITLE"">
                                  <xsd:annotation>
                                    <xsd:documentation>Title text</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""30"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""COUNTRYISO"">
                                  <xsd:annotation>
                                    <xsd:documentation>Country ISO code</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""2"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""LANGU_ISO"">
                                  <xsd:annotation>
                                    <xsd:documentation>Language according to ISO 639</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""2"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""BUILD_LONG"">
                                  <xsd:annotation>
                                    <xsd:documentation>Building (Number or Code)</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""20"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""REGIOGROUP"">
                                  <xsd:annotation>
                                    <xsd:documentation>Regional structure grouping</xsd:documentation>
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
                    <xsd:element minOccurs=""0"" name=""E1BPEIKP"">
                      <xsd:annotation>
                        <xsd:documentation>Foreign Trade: Export/Import: Header Data</xsd:documentation>
                      </xsd:annotation>
                      <xsd:complexType>
                        <xsd:sequence>
                          <xsd:element minOccurs=""0"" name=""TRANSPORT_MODE"">
                            <xsd:annotation>
                              <xsd:documentation>Mode of Transport for Foreign Trade</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""CUSTOMS"">
                            <xsd:annotation>
                              <xsd:documentation>Customs Office: Office of Exit/Entry for Foreign Trade</xsd:documentation>
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
                    <xsd:element minOccurs=""0"" name=""E1BPEIKPX"">
                      <xsd:annotation>
                        <xsd:documentation>Foreign Trade: Import/Export Header Data (Change Parameter)</xsd:documentation>
                      </xsd:annotation>
                      <xsd:complexType>
                        <xsd:sequence>
                          <xsd:element minOccurs=""0"" name=""TRANSPORT_MODE"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""CUSTOMS"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
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
                    <xsd:element minOccurs=""0"" name=""E1BPMEDCM"">
                      <xsd:annotation>
                        <xsd:documentation>Version Management</xsd:documentation>
                      </xsd:annotation>
                      <xsd:complexType>
                        <xsd:sequence>
                          <xsd:element minOccurs=""0"" name=""POST_DATE"">
                            <xsd:annotation>
                              <xsd:documentation>Posting date of version</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""8"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""COMPLETED"">
                            <xsd:annotation>
                              <xsd:documentation>Status ""version completed""</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""REASON"">
                            <xsd:annotation>
                              <xsd:documentation>Reason for change</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""4"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""DESCRIPTION"">
                            <xsd:annotation>
                              <xsd:documentation>Description of version</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""60"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""REQ_BY"">
                            <xsd:annotation>
                              <xsd:documentation>Person requesting change</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""12"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""REQ_BY_EXT"">
                            <xsd:annotation>
                              <xsd:documentation>External Change Number of Version</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""20"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""ACTIVITY"">
                            <xsd:annotation>
                              <xsd:documentation>Processing Type - Not Yet Usable in mySAP ERP</xsd:documentation>
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
                    <xsd:element minOccurs=""0"" maxOccurs=""999999"" name=""E1BPMEPOITEM"">
                      <xsd:annotation>
                        <xsd:documentation>Purchase Order Item</xsd:documentation>
                      </xsd:annotation>
                      <xsd:complexType>
                        <xsd:sequence>
                          <xsd:element minOccurs=""0"" name=""PO_ITEM"">
                            <xsd:annotation>
                              <xsd:documentation>Item Number of Purchasing Document</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""5"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""DELETE_IND"">
                            <xsd:annotation>
                              <xsd:documentation>Deletion Indicator in Purchasing Document</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""SHORT_TEXT"">
                            <xsd:annotation>
                              <xsd:documentation>Short Text</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""40"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""MATERIAL"">
                            <xsd:annotation>
                              <xsd:documentation>Material Number</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""18"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""MATERIAL_EXTERNAL"">
                            <xsd:annotation>
                              <xsd:documentation>Long Material Number for MATERIAL Field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""40"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""MATERIAL_GUID"">
                            <xsd:annotation>
                              <xsd:documentation>External GUID for MATERIAL Field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""32"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""MATERIAL_VERSION"">
                            <xsd:annotation>
                              <xsd:documentation>Version Number for MATERIAL Field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""10"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""EMATERIAL"">
                            <xsd:annotation>
                              <xsd:documentation>Material Number</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""18"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""EMATERIAL_EXTERNAL"">
                            <xsd:annotation>
                              <xsd:documentation>Long Material Number for MATERIAL Field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""40"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""EMATERIAL_GUID"">
                            <xsd:annotation>
                              <xsd:documentation>External GUID for MATERIAL Field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""32"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""EMATERIAL_VERSION"">
                            <xsd:annotation>
                              <xsd:documentation>Version Number for MATERIAL Field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""10"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""PLANT"">
                            <xsd:annotation>
                              <xsd:documentation>Plant</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""4"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""STGE_LOC"">
                            <xsd:annotation>
                              <xsd:documentation>Storage Location</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""4"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""TRACKINGNO"">
                            <xsd:annotation>
                              <xsd:documentation>Requirement Tracking Number</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""10"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""MATL_GROUP"">
                            <xsd:annotation>
                              <xsd:documentation>Material Group</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""9"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""INFO_REC"">
                            <xsd:annotation>
                              <xsd:documentation>Number of Purchasing Info Record</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""10"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""VEND_MAT"">
                            <xsd:annotation>
                              <xsd:documentation>Material Number Used by Vendor</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""35"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""QUANTITY"">
                            <xsd:annotation>
                              <xsd:documentation>Purchase Order Quantity</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""15"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""PO_UNIT"">
                            <xsd:annotation>
                              <xsd:documentation>Purchase Order Unit of Measure</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""3"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""PO_UNIT_ISO"">
                            <xsd:annotation>
                              <xsd:documentation>Order unit in ISO code</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""3"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""ORDERPR_UN"">
                            <xsd:annotation>
                              <xsd:documentation>Order Price Unit (Purchasing)</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""3"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""ORDERPR_UN_ISO"">
                            <xsd:annotation>
                              <xsd:documentation>ISO code for purchase order price unit</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""3"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""CONV_NUM1"">
                            <xsd:annotation>
                              <xsd:documentation>Numerator for Conversion of Order Price Unit into Order Unit</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""6"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""CONV_DEN1"">
                            <xsd:annotation>
                              <xsd:documentation>Denominator for Conv. of Order Price Unit into Order Unit</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""6"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""NET_PRICE"">
                            <xsd:annotation>
                              <xsd:documentation>Currency amount for BAPIS (with 9 decimal places)</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""31"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""PRICE_UNIT"">
                            <xsd:annotation>
                              <xsd:documentation>Price Unit</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""6"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""GR_PR_TIME"">
                            <xsd:annotation>
                              <xsd:documentation>Goods Receipt Processing Time in Days</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""4"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""TAX_CODE"">
                            <xsd:annotation>
                              <xsd:documentation>Tax on sales/purchases code</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""2"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""BON_GRP1"">
                            <xsd:annotation>
                              <xsd:documentation>Settlement Group 1 (Purchasing)</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""2"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""QUAL_INSP"">
                            <xsd:annotation>
                              <xsd:documentation>Stock Type</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""INFO_UPD"">
                            <xsd:annotation>
                              <xsd:documentation>Indicator: Update Info Record</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""PRNT_PRICE"">
                            <xsd:annotation>
                              <xsd:documentation>Price Printout</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""EST_PRICE"">
                            <xsd:annotation>
                              <xsd:documentation>Indicator: Estimated Price</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""REMINDER1"">
                            <xsd:annotation>
                              <xsd:documentation>Number of Days for First Reminder/Expediter</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""4"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""REMINDER2"">
                            <xsd:annotation>
                              <xsd:documentation>Number of Days for Second Reminder/Expediter</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""4"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""REMINDER3"">
                            <xsd:annotation>
                              <xsd:documentation>Number of Days for Third Reminder/Expediter</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""4"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""OVER_DLV_TOL"">
                            <xsd:annotation>
                              <xsd:documentation>Overdelivery Tolerance Limit</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""5"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""UNLIMITED_DLV"">
                            <xsd:annotation>
                              <xsd:documentation>Indicator: Unlimited Overdelivery Allowed</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""UNDER_DLV_TOL"">
                            <xsd:annotation>
                              <xsd:documentation>Underdelivery Tolerance Limit</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""5"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""VAL_TYPE"">
                            <xsd:annotation>
                              <xsd:documentation>Valuation Type</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""10"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""NO_MORE_GR"">
                            <xsd:annotation>
                              <xsd:documentation>""Delivery Completed"" Indicator</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""FINAL_INV"">
                            <xsd:annotation>
                              <xsd:documentation>Final Invoice Indicator</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""ITEM_CAT"">
                            <xsd:annotation>
                              <xsd:documentation>Item Category in Purchasing Document</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""ACCTASSCAT"">
                            <xsd:annotation>
                              <xsd:documentation>Account Assignment Category</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""DISTRIB"">
                            <xsd:annotation>
                              <xsd:documentation>Distribution Indicator for Multiple Account Assignment</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""PART_INV"">
                            <xsd:annotation>
                              <xsd:documentation>Partial Invoice Indicator</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""GR_IND"">
                            <xsd:annotation>
                              <xsd:documentation>Goods Receipt Indicator</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""GR_NON_VAL"">
                            <xsd:annotation>
                              <xsd:documentation>Goods Receipt, Non-Valuated</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""IR_IND"">
                            <xsd:annotation>
                              <xsd:documentation>Invoice Receipt Indicator</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""FREE_ITEM"">
                            <xsd:annotation>
                              <xsd:documentation>Free Item</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""GR_BASEDIV"">
                            <xsd:annotation>
                              <xsd:documentation>Indicator: GR-Based Invoice Verification</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""ACKN_REQD"">
                            <xsd:annotation>
                              <xsd:documentation>Order Acknowledgment Requirement</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""ACKNOWL_NO"">
                            <xsd:annotation>
                              <xsd:documentation>Order Acknowledgment Number</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""20"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""AGREEMENT"">
                            <xsd:annotation>
                              <xsd:documentation>Number of Principal Purchase Agreement</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""10"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""AGMT_ITEM"">
                            <xsd:annotation>
                              <xsd:documentation>Item Number of Principal Purchase Agreement</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""5"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""SHIPPING"">
                            <xsd:annotation>
                              <xsd:documentation>Shipping Instructions</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""2"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""CUSTOMER"">
                            <xsd:annotation>
                              <xsd:documentation>Customer</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""10"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""COND_GROUP"">
                            <xsd:annotation>
                              <xsd:documentation>Condition Group with Vendor</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""4"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""NO_DISCT"">
                            <xsd:annotation>
                              <xsd:documentation>Item Does Not Qualify for Cash Discount</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""PLAN_DEL"">
                            <xsd:annotation>
                              <xsd:documentation>Planned Delivery Time in Days</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""4"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""NET_WEIGHT"">
                            <xsd:annotation>
                              <xsd:documentation>Net Weight</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""15"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""WEIGHTUNIT"">
                            <xsd:annotation>
                              <xsd:documentation>Unit of Weight</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""3"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""WEIGHTUNIT_ISO"">
                            <xsd:annotation>
                              <xsd:documentation>ISO code for unit of weight</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""3"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""TAXJURCODE"">
                            <xsd:annotation>
                              <xsd:documentation>Tax Jurisdiction</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""15"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""CTRL_KEY"">
                            <xsd:annotation>
                              <xsd:documentation>Control Key for Quality Management in Procurement</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""8"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""CONF_CTRL"">
                            <xsd:annotation>
                              <xsd:documentation>Confirmation Control Key</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""4"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""REV_LEV"">
                            <xsd:annotation>
                              <xsd:documentation>Revision Level</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""2"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""FUND"">
                            <xsd:annotation>
                              <xsd:documentation>Fund</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""10"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""FUNDS_CTR"">
                            <xsd:annotation>
                              <xsd:documentation>Funds Center</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""16"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""CMMT_ITEM"">
                            <xsd:annotation>
                              <xsd:documentation>Commitment Item</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""14"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""PRICEDATE"">
                            <xsd:annotation>
                              <xsd:documentation>Price Determination (Pricing) Date Control</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""PRICE_DATE"">
                            <xsd:annotation>
                              <xsd:documentation>Date of Price Determination</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""8"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""GROSS_WT"">
                            <xsd:annotation>
                              <xsd:documentation>Gross Weight</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""15"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""VOLUME"">
                            <xsd:annotation>
                              <xsd:documentation>Volume</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""15"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""VOLUMEUNIT"">
                            <xsd:annotation>
                              <xsd:documentation>Volume unit</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""3"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""VOLUMEUNIT_ISO"">
                            <xsd:annotation>
                              <xsd:documentation>Volume unit in ISO code</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""3"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""INCOTERMS1"">
                            <xsd:annotation>
                              <xsd:documentation>Incoterms (Part 1)</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""3"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""INCOTERMS2"">
                            <xsd:annotation>
                              <xsd:documentation>Incoterms (Part 2)</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""28"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""PRE_VENDOR"">
                            <xsd:annotation>
                              <xsd:documentation>Prior Vendor</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""10"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""VEND_PART"">
                            <xsd:annotation>
                              <xsd:documentation>Vendor Subrange</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""6"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""HL_ITEM"">
                            <xsd:annotation>
                              <xsd:documentation>Higher-Level Item in Purchasing Documents</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""5"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""GR_TO_DATE"">
                            <xsd:annotation>
                              <xsd:documentation>Latest Possible Goods Receipt</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""8"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""SUPP_VENDOR"">
                            <xsd:annotation>
                              <xsd:documentation>Vendor to be supplied/who is to receive delivery</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""10"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""SC_VENDOR"">
                            <xsd:annotation>
                              <xsd:documentation>Subcontracting vendor</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""KANBAN_IND"">
                            <xsd:annotation>
                              <xsd:documentation>Kanban Indicator</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""ERS"">
                            <xsd:annotation>
                              <xsd:documentation>Evaluated Receipt Settlement (ERS)</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""R_PROMO"">
                            <xsd:annotation>
                              <xsd:documentation>Promotion</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""10"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""POINTS"">
                            <xsd:annotation>
                              <xsd:documentation>Number of Points</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""15"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""POINT_UNIT"">
                            <xsd:annotation>
                              <xsd:documentation>Points unit</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""3"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""POINT_UNIT_ISO"">
                            <xsd:annotation>
                              <xsd:documentation>ISO code for points unit</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""3"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""SEASON"">
                            <xsd:annotation>
                              <xsd:documentation>Season Category</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""4"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""SEASON_YR"">
                            <xsd:annotation>
                              <xsd:documentation>Season Year</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""4"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""BON_GRP2"">
                            <xsd:annotation>
                              <xsd:documentation>Settlement Group 2 (Rebate Settlement, Purchasing)</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""2"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""BON_GRP3"">
                            <xsd:annotation>
                              <xsd:documentation>Settlement Group 3 (Rebate Settlement, Purchasing)</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""2"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""SETT_ITEM"">
                            <xsd:annotation>
                              <xsd:documentation>Item Relevant to Subsequent (Period-End Rebate) Settlement</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""MINREMLIFE"">
                            <xsd:annotation>
                              <xsd:documentation>Minimum Remaining Shelf Life</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""6"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""RFQ_NO"">
                            <xsd:annotation>
                              <xsd:documentation>RFQ Number</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""10"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""RFQ_ITEM"">
                            <xsd:annotation>
                              <xsd:documentation>Item Number of RFQ</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""5"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""PREQ_NO"">
                            <xsd:annotation>
                              <xsd:documentation>Purchase Requisition Number</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""10"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""PREQ_ITEM"">
                            <xsd:annotation>
                              <xsd:documentation>Item Number of Purchase Requisition</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""5"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""REF_DOC"">
                            <xsd:annotation>
                              <xsd:documentation>Reference Document Number</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""10"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""REF_ITEM"">
                            <xsd:annotation>
                              <xsd:documentation>Item of reference document</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""5"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""SI_CAT"">
                            <xsd:annotation>
                              <xsd:documentation>Subitem Category, Purchasing Document</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""RET_ITEM"">
                            <xsd:annotation>
                              <xsd:documentation>Returns Item</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""AT_RELEV"">
                            <xsd:annotation>
                              <xsd:documentation>Relevant to Allocation Table</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""ORDER_REASON"">
                            <xsd:annotation>
                              <xsd:documentation>Reason for Ordering</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""3"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""BRAS_NBM"">
                            <xsd:annotation>
                              <xsd:documentation>Brazilian NCM Code</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""16"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""MATL_USAGE"">
                            <xsd:annotation>
                              <xsd:documentation>Usage of the material</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""MAT_ORIGIN"">
                            <xsd:annotation>
                              <xsd:documentation>Origin of the material</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""IN_HOUSE"">
                            <xsd:annotation>
                              <xsd:documentation>Produced in-house</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""INDUS3"">
                            <xsd:annotation>
                              <xsd:documentation>Material CFOP category</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""2"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""INF_INDEX"">
                            <xsd:annotation>
                              <xsd:documentation>Inflation Index</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""5"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""UNTIL_DATE"">
                            <xsd:annotation>
                              <xsd:documentation>Inflation Index Date</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""8"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""DELIV_COMPL"">
                            <xsd:annotation>
                              <xsd:documentation>""Outward Delivery Completed"" Indicator</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""PART_DELIV"">
                            <xsd:annotation>
                              <xsd:documentation>Partial Delivery at Item Level (Stock Transfer)</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""SHIP_BLOCKED"">
                            <xsd:annotation>
                              <xsd:documentation>Item blocked for SD delivery</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""PREQ_NAME"">
                            <xsd:annotation>
                              <xsd:documentation>Name of Requisitioner/Requester</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""12"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""PERIOD_IND_EXPIRATION_DATE"">
                            <xsd:annotation>
                              <xsd:documentation>Period Indicator for Shelf Life Expiration Date</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""INT_OBJ_NO"">
                            <xsd:annotation>
                              <xsd:documentation>Configuration (internal object number)</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""18"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""PCKG_NO"">
                            <xsd:annotation>
                              <xsd:documentation>Package number</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""10"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""BATCH"">
                            <xsd:annotation>
                              <xsd:documentation>Batch Number</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""10"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""VENDRBATCH"">
                            <xsd:annotation>
                              <xsd:documentation>Vendor Batch Number</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""15"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""CALCTYPE"">
                            <xsd:annotation>
                              <xsd:documentation>Pricing type</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""GRANT_NBR"">
                            <xsd:annotation>
                              <xsd:documentation>Grant</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""20"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""CMMT_ITEM_LONG"">
                            <xsd:annotation>
                              <xsd:documentation>Commitment Item</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""24"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""FUNC_AREA_LONG"">
                            <xsd:annotation>
                              <xsd:documentation>Functional Area</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""16"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""NO_ROUNDING"">
                            <xsd:annotation>
                              <xsd:documentation>Indicator: suppress rounding in purchase order item</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""PO_PRICE"">
                            <xsd:annotation>
                              <xsd:documentation>Price Adoption: 1 = Gross, 2 = Net</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""SUPPL_STLOC"">
                            <xsd:annotation>
                              <xsd:documentation>Issuing Storage Location for Stock Transport Order</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""4"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""SRV_BASED_IV"">
                            <xsd:annotation>
                              <xsd:documentation>Indicator for Service-Based Invoice Verification</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""FUNDS_RES"">
                            <xsd:annotation>
                              <xsd:documentation>Document Number for Earmarked Funds</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""10"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""RES_ITEM"">
                            <xsd:annotation>
                              <xsd:documentation>Earmarked Funds: Document Item</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""3"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""E1BPMEPOITEM1"">
                            <xsd:annotation>
                              <xsd:documentation>Purchase Order Item</xsd:documentation>
                            </xsd:annotation>
                            <xsd:complexType>
                              <xsd:sequence>
                                <xsd:element minOccurs=""0"" name=""ORIG_ACCEPT"">
                                  <xsd:annotation>
                                    <xsd:documentation>Acceptance At Origin</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""1"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""ALLOC_TBL"">
                                  <xsd:annotation>
                                    <xsd:documentation>Allocation Table Number</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""10"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""ALLOC_TBL_ITEM"">
                                  <xsd:annotation>
                                    <xsd:documentation>Item number of allocation table</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""5"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""SRC_STOCK_TYPE"">
                                  <xsd:annotation>
                                    <xsd:documentation>Stock Type of Source Storage Location in STO</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""1"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""REASON_REJ"">
                                  <xsd:annotation>
                                    <xsd:documentation>Reason for rejection of quotations and sales orders</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""2"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""CRM_SALES_ORDER_NO"">
                                  <xsd:annotation>
                                    <xsd:documentation>CRM Sales Order Number for TPOP Process</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""10"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""CRM_SALES_ORDER_ITEM_NO"">
                                  <xsd:annotation>
                                    <xsd:documentation>CRM Sales Order Item Number in TPOP Process</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""6"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""CRM_REF_SALES_ORDER_NO"">
                                  <xsd:annotation>
                                    <xsd:documentation>CRM Reference Order Number for TPOP Process</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""35"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""CRM_REF_SO_ITEM_NO"">
                                  <xsd:annotation>
                                    <xsd:documentation>CRM Reference Sales Order Item Number in TPOP Process</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""6"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""PRIO_URGENCY"">
                                  <xsd:annotation>
                                    <xsd:documentation>Requirement Urgency</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""2"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""PRIO_REQUIREMENT"">
                                  <xsd:annotation>
                                    <xsd:documentation>Requirement Priority</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""3"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""REASON_CODE"">
                                  <xsd:annotation>
                                    <xsd:documentation>Goods Receipt Reason Code</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""4"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""FUND_LONG"">
                                  <xsd:annotation>
                                    <xsd:documentation>Long Fund (Obsolete)</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""20"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""LONG_ITEM_NUMBER"">
                                  <xsd:annotation>
                                    <xsd:documentation>Item Number Length</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""40"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""EXTERNAL_SORT_NUMBER"">
                                  <xsd:annotation>
                                    <xsd:documentation>External Sorting</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""5"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""EXTERNAL_HIERARCHY_TYPE"">
                                  <xsd:annotation>
                                    <xsd:documentation>External Hierarchy Category</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""4"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""RETENTION_PERCENTAGE"">
                                  <xsd:annotation>
                                    <xsd:documentation>Retention in Percent</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""7"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""DOWNPAY_TYPE"">
                                  <xsd:annotation>
                                    <xsd:documentation>Down Payment Indicator</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""4"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""DOWNPAY_AMOUNT"">
                                  <xsd:annotation>
                                    <xsd:documentation>Down Payment Amount in BAPI</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""25"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""DOWNPAY_PERCENT"">
                                  <xsd:annotation>
                                    <xsd:documentation>Down Payment Percentage</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""7"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""DOWNPAY_DUEDATE"">
                                  <xsd:annotation>
                                    <xsd:documentation>Due Date for Down Payment</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""8"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""EXT_RFX_NUMBER"">
                                  <xsd:annotation>
                                    <xsd:documentation>Document Number of External Document</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""35"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""EXT_RFX_ITEM"">
                                  <xsd:annotation>
                                    <xsd:documentation>Item Number of External Document</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""10"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""EXT_RFX_SYSTEM"">
                                  <xsd:annotation>
                                    <xsd:documentation>Logical System</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""10"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""SRM_CONTRACT_ID"">
                                  <xsd:annotation>
                                    <xsd:documentation>Central Contract</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""10"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""SRM_CONTRACT_ITM"">
                                  <xsd:annotation>
                                    <xsd:documentation>Central Contract Item Number</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""10"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""BUDGET_PERIOD"">
                                  <xsd:annotation>
                                    <xsd:documentation>FM: Budget Period</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""10"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""BLOCK_REASON_ID"">
                                  <xsd:annotation>
                                    <xsd:documentation>Blocking Reason - ID</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""4"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""BLOCK_REASON_TEXT"">
                                  <xsd:annotation>
                                    <xsd:documentation>Blocking Reason - Text</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""40"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""SPE_CRM_FKREL"">
                                  <xsd:annotation>
                                    <xsd:documentation>Billing Relevance CRM</xsd:documentation>
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
                    <xsd:element minOccurs=""0"" maxOccurs=""999999"" name=""E1BPMEPOITEMX"">
                      <xsd:annotation>
                        <xsd:documentation>Purchase Order Item Data (Change Parameter)</xsd:documentation>
                      </xsd:annotation>
                      <xsd:complexType>
                        <xsd:sequence>
                          <xsd:element minOccurs=""0"" name=""PO_ITEM"">
                            <xsd:annotation>
                              <xsd:documentation>Item Number of Purchasing Document</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""5"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""PO_ITEMX"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""DELETE_IND"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""SHORT_TEXT"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""MATERIAL"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""MATERIAL_EXTERNAL"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""MATERIAL_GUID"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""MATERIAL_VERSION"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""EMATERIAL"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""EMATERIAL_EXTERNAL"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""EMATERIAL_GUID"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""EMATERIAL_VERSION"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""PLANT"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""STGE_LOC"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""TRACKINGNO"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""MATL_GROUP"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""INFO_REC"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""VEND_MAT"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""QUANTITY"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""PO_UNIT"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""PO_UNIT_ISO"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""ORDERPR_UN"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""ORDERPR_UN_ISO"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""CONV_NUM1"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""CONV_DEN1"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""NET_PRICE"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""PRICE_UNIT"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""GR_PR_TIME"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""TAX_CODE"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""BON_GRP1"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""QUAL_INSP"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""INFO_UPD"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""PRNT_PRICE"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""EST_PRICE"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""REMINDER1"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""REMINDER2"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""REMINDER3"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""OVER_DLV_TOL"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""UNLIMITED_DLV"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""UNDER_DLV_TOL"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""VAL_TYPE"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""NO_MORE_GR"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""FINAL_INV"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""ITEM_CAT"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""ACCTASSCAT"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""DISTRIB"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""PART_INV"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""GR_IND"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""GR_NON_VAL"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""IR_IND"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""FREE_ITEM"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""GR_BASEDIV"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""ACKN_REQD"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""ACKNOWL_NO"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""AGREEMENT"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""AGMT_ITEM"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""SHIPPING"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""CUSTOMER"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""COND_GROUP"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""NO_DISCT"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""PLAN_DEL"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""NET_WEIGHT"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""WEIGHTUNIT"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""WEIGHTUNIT_ISO"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""TAXJURCODE"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""CTRL_KEY"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""CONF_CTRL"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""REV_LEV"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""FUND"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""FUNDS_CTR"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""CMMT_ITEM"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""PRICEDATE"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""PRICE_DATE"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""GROSS_WT"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""VOLUME"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""VOLUMEUNIT"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""VOLUMEUNIT_ISO"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""INCOTERMS1"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""INCOTERMS2"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""PRE_VENDOR"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""VEND_PART"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""HL_ITEM"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""GR_TO_DATE"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""SUPP_VENDOR"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""SC_VENDOR"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""KANBAN_IND"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""ERS"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""R_PROMO"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""POINTS"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""POINT_UNIT"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""POINT_UNIT_ISO"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""SEASON"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""SEASON_YR"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""BON_GRP2"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""BON_GRP3"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""SETT_ITEM"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""MINREMLIFE"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""RFQ_NO"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""RFQ_ITEM"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""PREQ_NO"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""PREQ_ITEM"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""REF_DOC"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""REF_ITEM"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""SI_CAT"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""RET_ITEM"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""AT_RELEV"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""ORDER_REASON"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""BRAS_NBM"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""MATL_USAGE"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""MAT_ORIGIN"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""IN_HOUSE"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""INDUS3"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""INF_INDEX"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""UNTIL_DATE"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""DELIV_COMPL"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""PART_DELIV"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""SHIP_BLOCKED"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""PREQ_NAME"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""PERIOD_IND_EXPIRATION_DATE"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""INT_OBJ_NO"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""PCKG_NO"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""BATCH"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""VENDRBATCH"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""CALCTYPE"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""NO_ROUNDING"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""PO_PRICE"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""SUPPL_STLOC"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""SRV_BASED_IV"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""FUNDS_RES"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""RES_ITEM"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""GRANT_NBR"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""FUNC_AREA_LONG"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""ORIG_ACCEPT"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""ALLOC_TBL"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""ALLOC_TBL_ITEM"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""SRC_STOCK_TYPE"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""REASON_REJ"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""CRM_SALES_ORDER_NO"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""CRM_SALES_ORDER_ITEM_NO"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""CRM_REF_SALES_ORDER_NO"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""CRM_REF_SO_ITEM_NO"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""PRIO_URGENCY"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""PRIO_REQUIREMENT"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""REASON_CODE"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""LONG_ITEM_NUMBER"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""EXTERNAL_SORT_NUMBER"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""EXTERNAL_HIERARCHY_TYPE"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""RETENTION_PERCENTAGE"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""DOWNPAY_TYPE"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""DOWNPAY_AMOUNT"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""DOWNPAY_PERCENT"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""DOWNPAY_DUEDATE"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""EXT_RFX_NUMBER"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""EXT_RFX_ITEM"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""EXT_RFX_SYSTEM"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""SRM_CONTRACT_ID"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""SRM_CONTRACT_ITM"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""BUDGET_PERIOD"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""BLOCK_REASON_ID"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""BLOCK_REASON_TEXT"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""SPE_CRM_FKREL"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
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
                    <xsd:element minOccurs=""0"" maxOccurs=""999999"" name=""E1BPMEPOADDRDELIVERY"">
                      <xsd:annotation>
                        <xsd:documentation>PO Item: Address Structure BAPIADDR1 for Inbound Delivery</xsd:documentation>
                      </xsd:annotation>
                      <xsd:complexType>
                        <xsd:sequence>
                          <xsd:element minOccurs=""0"" name=""PO_ITEM"">
                            <xsd:annotation>
                              <xsd:documentation>Item Number of Purchasing Document</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""5"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""ADDR_NO"">
                            <xsd:annotation>
                              <xsd:documentation>Address number</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""10"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""FORMOFADDR"">
                            <xsd:annotation>
                              <xsd:documentation>Form of address text</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""20"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""NAME"">
                            <xsd:annotation>
                              <xsd:documentation>Name 1</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""40"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""NAME_2"">
                            <xsd:annotation>
                              <xsd:documentation>Name 2</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""40"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""NAME_3"">
                            <xsd:annotation>
                              <xsd:documentation>Name 3</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""40"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""NAME_4"">
                            <xsd:annotation>
                              <xsd:documentation>Name 4</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""40"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""C_O_NAME"">
                            <xsd:annotation>
                              <xsd:documentation>c/o name</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""40"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""CITY"">
                            <xsd:annotation>
                              <xsd:documentation>City</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""40"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""DISTRICT"">
                            <xsd:annotation>
                              <xsd:documentation>District</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""40"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""CITY_NO"">
                            <xsd:annotation>
                              <xsd:documentation>City code for city/street file</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""12"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""POSTL_COD1"">
                            <xsd:annotation>
                              <xsd:documentation>City postal code</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""10"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""POSTL_COD2"">
                            <xsd:annotation>
                              <xsd:documentation>PO Box postal code</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""10"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""POSTL_COD3"">
                            <xsd:annotation>
                              <xsd:documentation>Company postal code (for large customers)</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""10"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""PO_BOX"">
                            <xsd:annotation>
                              <xsd:documentation>PO Box</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""10"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""PO_BOX_CIT"">
                            <xsd:annotation>
                              <xsd:documentation>PO Box city</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""40"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""DELIV_DIS"">
                            <xsd:annotation>
                              <xsd:documentation>(Not Supported) Post Delivery District</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""15"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""STREET"">
                            <xsd:annotation>
                              <xsd:documentation>Street</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""60"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""STREET_NO"">
                            <xsd:annotation>
                              <xsd:documentation>Street Number for City/Street File</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""12"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""STR_ABBR"">
                            <xsd:annotation>
                              <xsd:documentation>(Not Supported) Abbreviation of Street Name</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""2"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""HOUSE_NO"">
                            <xsd:annotation>
                              <xsd:documentation>House Number</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""10"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""STR_SUPPL1"">
                            <xsd:annotation>
                              <xsd:documentation>Street 2</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""40"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""STR_SUPPL2"">
                            <xsd:annotation>
                              <xsd:documentation>Street 3</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""40"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""LOCATION"">
                            <xsd:annotation>
                              <xsd:documentation>Street 5</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""40"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""BUILDING"">
                            <xsd:annotation>
                              <xsd:documentation>old: building (no. or abbreviation)</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""10"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""FLOOR"">
                            <xsd:annotation>
                              <xsd:documentation>Floor in building</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""10"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""ROOM_NO"">
                            <xsd:annotation>
                              <xsd:documentation>Room or Appartment Number</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""10"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""COUNTRY"">
                            <xsd:annotation>
                              <xsd:documentation>Country Key</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""3"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""LANGU"">
                            <xsd:annotation>
                              <xsd:documentation>Language Key</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""REGION"">
                            <xsd:annotation>
                              <xsd:documentation>Region (State, Province, County)</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""3"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""SORT1"">
                            <xsd:annotation>
                              <xsd:documentation>Search Term 1</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""20"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""SORT2"">
                            <xsd:annotation>
                              <xsd:documentation>Search Term 2</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""20"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""TIME_ZONE"">
                            <xsd:annotation>
                              <xsd:documentation>Address time zone</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""6"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""TAXJURCODE"">
                            <xsd:annotation>
                              <xsd:documentation>Tax Jurisdiction</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""15"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""ADR_NOTES"">
                            <xsd:annotation>
                              <xsd:documentation>Address notes</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""50"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""COMM_TYPE"">
                            <xsd:annotation>
                              <xsd:documentation>Communication Method (Key) (Business Address Services)</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""3"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""TEL1_NUMBR"">
                            <xsd:annotation>
                              <xsd:documentation>First telephone no.: dialling code+number</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""30"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""TEL1_EXT"">
                            <xsd:annotation>
                              <xsd:documentation>First Telephone No.: Extension</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""10"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""FAX_NUMBER"">
                            <xsd:annotation>
                              <xsd:documentation>First fax no.: dialling code+number</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""30"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""FAX_EXTENS"">
                            <xsd:annotation>
                              <xsd:documentation>First fax no.: extension</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""10"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""STREET_LNG"">
                            <xsd:annotation>
                              <xsd:documentation>Street</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""60"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""DISTRCT_NO"">
                            <xsd:annotation>
                              <xsd:documentation>District code for City and Street file</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""8"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""CHCKSTATUS"">
                            <xsd:annotation>
                              <xsd:documentation>City file test status</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""PBOXCIT_NO"">
                            <xsd:annotation>
                              <xsd:documentation>City PO box code (City file)</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""12"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""TRANSPZONE"">
                            <xsd:annotation>
                              <xsd:documentation>Transportation zone to or from which the goods are delivered</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""10"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""HOUSE_NO2"">
                            <xsd:annotation>
                              <xsd:documentation>House number supplement</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""10"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""E1BPMEPOADDRDELIVERY1"">
                            <xsd:annotation>
                              <xsd:documentation>PO Item: Address Structure BAPIADDR1 for Inbound Delivery</xsd:documentation>
                            </xsd:annotation>
                            <xsd:complexType>
                              <xsd:sequence>
                                <xsd:element minOccurs=""0"" name=""E_MAIL"">
                                  <xsd:annotation>
                                    <xsd:documentation>E-Mail Address</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""241"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""STR_SUPPL3"">
                                  <xsd:annotation>
                                    <xsd:documentation>Street 4</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""40"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""TITLE"">
                                  <xsd:annotation>
                                    <xsd:documentation>Title text</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""30"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""COUNTRYISO"">
                                  <xsd:annotation>
                                    <xsd:documentation>Country ISO code</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""2"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""LANGU_ISO"">
                                  <xsd:annotation>
                                    <xsd:documentation>Language according to ISO 639</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""2"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""BUILD_LONG"">
                                  <xsd:annotation>
                                    <xsd:documentation>Building (Number or Code)</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""20"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""REGIOGROUP"">
                                  <xsd:annotation>
                                    <xsd:documentation>Regional structure grouping</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""8"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""SUPP_VENDOR"">
                                  <xsd:annotation>
                                    <xsd:documentation>Vendor to be supplied/who is to receive delivery</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""10"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""CUSTOMER"">
                                  <xsd:annotation>
                                    <xsd:documentation>Customer</xsd:documentation>
                                  </xsd:annotation>
                                  <xsd:simpleType>
                                    <xsd:restriction base=""xsd:string"">
                                      <xsd:maxLength value=""10"" />
                                    </xsd:restriction>
                                  </xsd:simpleType>
                                </xsd:element>
                                <xsd:element minOccurs=""0"" name=""SC_VENDOR"">
                                  <xsd:annotation>
                                    <xsd:documentation>Subcontracting vendor</xsd:documentation>
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
                    <xsd:element minOccurs=""0"" maxOccurs=""999999"" name=""E1BPMEPOSCHEDULE"">
                      <xsd:annotation>
                        <xsd:documentation>Fields for Purchase Order Delivery Schedule Lines</xsd:documentation>
                      </xsd:annotation>
                      <xsd:complexType>
                        <xsd:sequence>
                          <xsd:element minOccurs=""0"" name=""PO_ITEM"">
                            <xsd:annotation>
                              <xsd:documentation>Item Number of Purchasing Document</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""5"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""SCHED_LINE"">
                            <xsd:annotation>
                              <xsd:documentation>Delivery Schedule Line Number</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""4"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""DEL_DATCAT_EXT"">
                            <xsd:annotation>
                              <xsd:documentation>Category of Delivery Date</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""DELIVERY_DATE"">
                            <xsd:annotation>
                              <xsd:documentation>Delivery Date</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""10"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""QUANTITY"">
                            <xsd:annotation>
                              <xsd:documentation>Scheduled Quantity</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""15"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""DELIV_TIME"">
                            <xsd:annotation>
                              <xsd:documentation>Delivery Date Time-Spot</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""6"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""STAT_DATE"">
                            <xsd:annotation>
                              <xsd:documentation>Statistics-Relevant Delivery Date</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""8"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""PREQ_NO"">
                            <xsd:annotation>
                              <xsd:documentation>Purchase Requisition Number</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""10"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""PREQ_ITEM"">
                            <xsd:annotation>
                              <xsd:documentation>Item Number of Purchase Requisition</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""5"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""PO_DATE"">
                            <xsd:annotation>
                              <xsd:documentation>Order date of schedule line</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""8"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""ROUTESCHED"">
                            <xsd:annotation>
                              <xsd:documentation>Route Schedule</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""10"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""MS_DATE"">
                            <xsd:annotation>
                              <xsd:documentation>Material Staging/Availability Date</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""8"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""MS_TIME"">
                            <xsd:annotation>
                              <xsd:documentation>Material Staging Time (Local, Relating to a Plant)</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""6"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""LOAD_DATE"">
                            <xsd:annotation>
                              <xsd:documentation>Loading Date</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""8"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""LOAD_TIME"">
                            <xsd:annotation>
                              <xsd:documentation>Loading Time (Local Time Relating to a Shipping Point)</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""6"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""TP_DATE"">
                            <xsd:annotation>
                              <xsd:documentation>Transportation Planning Date</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""8"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""TP_TIME"">
                            <xsd:annotation>
                              <xsd:documentation>Transp. Planning Time (Local, Relating to a Shipping Point)</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""6"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""GI_DATE"">
                            <xsd:annotation>
                              <xsd:documentation>Goods Issue Date</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""8"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""GI_TIME"">
                            <xsd:annotation>
                              <xsd:documentation>Time of Goods Issue (Local, Relating to a Plant)</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""6"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""DELETE_IND"">
                            <xsd:annotation>
                              <xsd:documentation>Deletion Indicator in Purchasing Document</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""REQ_CLOSED"">
                            <xsd:annotation>
                              <xsd:documentation>Purchase Requisition Closed</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""GR_END_DATE"">
                            <xsd:annotation>
                              <xsd:documentation>Goods Receipt End Date</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""8"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""GR_END_TIME"">
                            <xsd:annotation>
                              <xsd:documentation>Goods Receipt End Time (Local, Relating to a Plant)</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""6"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""COM_QTY"">
                            <xsd:annotation>
                              <xsd:documentation>Committed Quantity</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""15"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""COM_DATE"">
                            <xsd:annotation>
                              <xsd:documentation>Committed Date</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""8"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""GEO_ROUTE"">
                            <xsd:annotation>
                              <xsd:documentation>Description of a Geographical Route</xsd:documentation>
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
                    <xsd:element minOccurs=""0"" maxOccurs=""999999"" name=""E1BPMEPOSCHEDULX"">
                      <xsd:annotation>
                        <xsd:documentation>Fields for Schedule Lines in Purchase Order (Change Toolbar)</xsd:documentation>
                      </xsd:annotation>
                      <xsd:complexType>
                        <xsd:sequence>
                          <xsd:element minOccurs=""0"" name=""PO_ITEM"">
                            <xsd:annotation>
                              <xsd:documentation>Item Number of Purchasing Document</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""5"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""SCHED_LINE"">
                            <xsd:annotation>
                              <xsd:documentation>Delivery Schedule Line Number</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""4"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""PO_ITEMX"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""SCHED_LINEX"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""DEL_DATCAT_EXT"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""DELIVERY_DATE"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""QUANTITY"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""DELIV_TIME"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""STAT_DATE"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""PREQ_NO"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""PREQ_ITEM"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""PO_DATE"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""ROUTESCHED"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""MS_DATE"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""MS_TIME"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""LOAD_DATE"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""LOAD_TIME"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""TP_DATE"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""TP_TIME"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""GI_DATE"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""GI_TIME"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""DELETE_IND"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""REQ_CLOSED"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""GR_END_DATE"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""GR_END_TIME"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""COM_QTY"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""COM_DATE"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""GEO_ROUTE"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
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
                    <xsd:element minOccurs=""0"" maxOccurs=""999999"" name=""E1BPMEPOACCOUNT"">
                      <xsd:annotation>
                        <xsd:documentation>Account Assignment Fields for Purchase Order</xsd:documentation>
                      </xsd:annotation>
                      <xsd:complexType>
                        <xsd:sequence>
                          <xsd:element minOccurs=""0"" name=""PO_ITEM"">
                            <xsd:annotation>
                              <xsd:documentation>Item Number of Purchasing Document</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""5"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""SERIAL_NO"">
                            <xsd:annotation>
                              <xsd:documentation>Sequential Number of Account Assignment</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""2"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""DELETE_IND"">
                            <xsd:annotation>
                              <xsd:documentation>Deletion Indicator: Purchasing Document Account Assignment</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""CREAT_DATE"">
                            <xsd:annotation>
                              <xsd:documentation>Date on Which Record Was Created</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""8"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""QUANTITY"">
                            <xsd:annotation>
                              <xsd:documentation>Quantity</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""15"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""DISTR_PERC"">
                            <xsd:annotation>
                              <xsd:documentation>Distribution Percentage in Case of Multiple Account Assgt</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""5"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""NET_VALUE"">
                            <xsd:annotation>
                              <xsd:documentation>Currency amount for BAPIS (with 9 decimal places)</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""31"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""GL_ACCOUNT"">
                            <xsd:annotation>
                              <xsd:documentation>G/L Account Number</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""10"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""BUS_AREA"">
                            <xsd:annotation>
                              <xsd:documentation>Business Area</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""4"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""COSTCENTER"">
                            <xsd:annotation>
                              <xsd:documentation>Cost Center</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""10"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""SD_DOC"">
                            <xsd:annotation>
                              <xsd:documentation>Sales and Distribution Document Number</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""10"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""ITM_NUMBER"">
                            <xsd:annotation>
                              <xsd:documentation>Sales Document Item</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""6"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""SCHED_LINE"">
                            <xsd:annotation>
                              <xsd:documentation>Delivery Schedule Line Number</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""4"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""ASSET_NO"">
                            <xsd:annotation>
                              <xsd:documentation>Main Asset Number</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""12"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""SUB_NUMBER"">
                            <xsd:annotation>
                              <xsd:documentation>Asset Subnumber</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""4"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""ORDERID"">
                            <xsd:annotation>
                              <xsd:documentation>Order Number</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""12"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""GR_RCPT"">
                            <xsd:annotation>
                              <xsd:documentation>Goods Recipient/Ship-To Party</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""12"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""UNLOAD_PT"">
                            <xsd:annotation>
                              <xsd:documentation>Unloading Point</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""25"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""CO_AREA"">
                            <xsd:annotation>
                              <xsd:documentation>Controlling Area</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""4"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""COSTOBJECT"">
                            <xsd:annotation>
                              <xsd:documentation>Cost Object</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""12"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""PROFIT_CTR"">
                            <xsd:annotation>
                              <xsd:documentation>Profit Center</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""10"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""WBS_ELEMENT"">
                            <xsd:annotation>
                              <xsd:documentation>Work Breakdown Structure Element (WBS Element)</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""24"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""NETWORK"">
                            <xsd:annotation>
                              <xsd:documentation>Network Number for Account Assignment</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""12"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""RL_EST_KEY"">
                            <xsd:annotation>
                              <xsd:documentation>Internal Key for Real Estate Object</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""8"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""PART_ACCT"">
                            <xsd:annotation>
                              <xsd:documentation>Partner account number</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""10"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""CMMT_ITEM"">
                            <xsd:annotation>
                              <xsd:documentation>Commitment Item</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""14"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""REC_IND"">
                            <xsd:annotation>
                              <xsd:documentation>Recovery Indicator</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""2"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""FUNDS_CTR"">
                            <xsd:annotation>
                              <xsd:documentation>Funds Center</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""16"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""FUND"">
                            <xsd:annotation>
                              <xsd:documentation>Fund</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""10"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""FUNC_AREA"">
                            <xsd:annotation>
                              <xsd:documentation>Functional Area</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""4"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""REF_DATE"">
                            <xsd:annotation>
                              <xsd:documentation>Reference Date for Settlement</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""8"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""TAX_CODE"">
                            <xsd:annotation>
                              <xsd:documentation>Tax on sales/purchases code</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""2"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""TAXJURCODE"">
                            <xsd:annotation>
                              <xsd:documentation>Tax Jurisdiction</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""15"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""NOND_ITAX"">
                            <xsd:annotation>
                              <xsd:documentation>Currency amount for BAPIS (with 9 decimal places)</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""31"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""ACTTYPE"">
                            <xsd:annotation>
                              <xsd:documentation>Activity Type</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""6"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""CO_BUSPROC"">
                            <xsd:annotation>
                              <xsd:documentation>Business Process</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""12"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""RES_DOC"">
                            <xsd:annotation>
                              <xsd:documentation>Document Number for Earmarked Funds</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""10"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""RES_ITEM"">
                            <xsd:annotation>
                              <xsd:documentation>Earmarked Funds: Document Item</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""3"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""ACTIVITY"">
                            <xsd:annotation>
                              <xsd:documentation>Operation/Activity Number</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""4"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""GRANT_NBR"">
                            <xsd:annotation>
                              <xsd:documentation>Grant</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""20"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""CMMT_ITEM_LONG"">
                            <xsd:annotation>
                              <xsd:documentation>Commitment Item</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""24"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""FUNC_AREA_LONG"">
                            <xsd:annotation>
                              <xsd:documentation>Functional Area</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""16"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""BUDGET_PERIOD"">
                            <xsd:annotation>
                              <xsd:documentation>FM: Budget Period</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""10"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""FINAL_IND"">
                            <xsd:annotation>
                              <xsd:documentation>Final Account Assignment Indicator</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""FINAL_REASON"">
                            <xsd:annotation>
                              <xsd:documentation>Final Account Assignment Reason Code</xsd:documentation>
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
                    <xsd:element minOccurs=""0"" maxOccurs=""999999"" name=""E1BPMEPOACCOUNTPROFITSEGMEN"">
                      <xsd:annotation>
                        <xsd:documentation>Reservation Profitability Seg.: BAPI_PROFITABILITY_SEGMENT</xsd:documentation>
                      </xsd:annotation>
                      <xsd:complexType>
                        <xsd:sequence>
                          <xsd:element minOccurs=""0"" name=""PO_ITEM"">
                            <xsd:annotation>
                              <xsd:documentation>Item Number of Purchasing Document</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""5"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""SERIAL_NO"">
                            <xsd:annotation>
                              <xsd:documentation>Sequential Number of Account Assignment</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""2"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""FIELDNAME"">
                            <xsd:annotation>
                              <xsd:documentation>Field Name</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""30"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""VALUE"">
                            <xsd:annotation>
                              <xsd:documentation>CO-PA characteristic value</xsd:documentation>
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
                    <xsd:element minOccurs=""0"" maxOccurs=""999999"" name=""E1BPMEPOACCOUNTX"">
                      <xsd:annotation>
                        <xsd:documentation>Account Assignment Fields in Purchase Order (Change Toolbar)</xsd:documentation>
                      </xsd:annotation>
                      <xsd:complexType>
                        <xsd:sequence>
                          <xsd:element minOccurs=""0"" name=""PO_ITEM"">
                            <xsd:annotation>
                              <xsd:documentation>Item Number of Purchasing Document</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""5"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""SERIAL_NO"">
                            <xsd:annotation>
                              <xsd:documentation>Sequential Number of Account Assignment</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""2"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""PO_ITEMX"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""SERIAL_NOX"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""DELETE_IND"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""CREAT_DATE"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""QUANTITY"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""DISTR_PERC"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""NET_VALUE"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""GL_ACCOUNT"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""BUS_AREA"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""COSTCENTER"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""SD_DOC"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""ITM_NUMBER"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""SCHED_LINE"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""ASSET_NO"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""SUB_NUMBER"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""ORDERID"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""GR_RCPT"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""UNLOAD_PT"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""CO_AREA"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""COSTOBJECT"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""PROFIT_CTR"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""WBS_ELEMENT"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""NETWORK"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""RL_EST_KEY"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""PART_ACCT"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""CMMT_ITEM"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""REC_IND"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""FUNDS_CTR"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""FUND"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""FUNC_AREA"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""REF_DATE"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""TAX_CODE"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""TAXJURCODE"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""NOND_ITAX"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""ACTTYPE"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""CO_BUSPROC"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""RES_DOC"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""RES_ITEM"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""ACTIVITY"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""GRANT_NBR"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""BUDGET_PERIOD"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""FINAL_IND"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""FINAL_REASON"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
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
                    <xsd:element minOccurs=""0"" maxOccurs=""999999"" name=""E1BPMEPOCONDHEADER"">
                      <xsd:annotation>
                        <xsd:documentation>Conditions (Header)</xsd:documentation>
                      </xsd:annotation>
                      <xsd:complexType>
                        <xsd:sequence>
                          <xsd:element minOccurs=""0"" name=""CONDITION_NO"">
                            <xsd:annotation>
                              <xsd:documentation>Number of the document condition</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""10"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""ITM_NUMBER"">
                            <xsd:annotation>
                              <xsd:documentation>Condition item number</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""6"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""COND_ST_NO"">
                            <xsd:annotation>
                              <xsd:documentation>Step number</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""3"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""COND_COUNT"">
                            <xsd:annotation>
                              <xsd:documentation>Condition counter</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""2"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""COND_TYPE"">
                            <xsd:annotation>
                              <xsd:documentation>Condition type</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""4"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""COND_VALUE"">
                            <xsd:annotation>
                              <xsd:documentation>Condition rate</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""31"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""CURRENCY"">
                            <xsd:annotation>
                              <xsd:documentation>Currency Key</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""5"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""CURRENCY_ISO"">
                            <xsd:annotation>
                              <xsd:documentation>ISO code currency</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""3"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""COND_UNIT"">
                            <xsd:annotation>
                              <xsd:documentation>Condition unit</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""3"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""COND_UNIT_ISO"">
                            <xsd:annotation>
                              <xsd:documentation>Condition unit of measure in UoM</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""3"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""COND_P_UNT"">
                            <xsd:annotation>
                              <xsd:documentation>Condition pricing unit</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""6"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""APPLICATIO"">
                            <xsd:annotation>
                              <xsd:documentation>Application</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""2"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""CONPRICDAT"">
                            <xsd:annotation>
                              <xsd:documentation>Condition pricing date</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""8"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""CALCTYPCON"">
                            <xsd:annotation>
                              <xsd:documentation>Calculation type for condition</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""CONBASEVAL"">
                            <xsd:annotation>
                              <xsd:documentation>Condition base value</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""31"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""CONEXCHRAT"">
                            <xsd:annotation>
                              <xsd:documentation>Condition exchange rate for conversion to local currency</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""11"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""NUMCONVERT"">
                            <xsd:annotation>
                              <xsd:documentation>Numerator for converting condition units to base units</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""6"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""DENOMINATO"">
                            <xsd:annotation>
                              <xsd:documentation>Denominator for converting condition units to base units</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""6"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""CONDTYPE"">
                            <xsd:annotation>
                              <xsd:documentation>Condition category (examples: tax, freight, price, cost)</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""STAT_CON"">
                            <xsd:annotation>
                              <xsd:documentation>Condition is used for statistics</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""SCALETYPE"">
                            <xsd:annotation>
                              <xsd:documentation>Scale Type</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""ACCRUALS"">
                            <xsd:annotation>
                              <xsd:documentation>Condition is Relevant for Accrual  (e.g. Freight)</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""CONINVOLST"">
                            <xsd:annotation>
                              <xsd:documentation>Condition for invoice list</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""CONDORIGIN"">
                            <xsd:annotation>
                              <xsd:documentation>Origin of the condition</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""GROUPCOND"">
                            <xsd:annotation>
                              <xsd:documentation>Group condition</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""COND_UPDAT"">
                            <xsd:annotation>
                              <xsd:documentation>Condition update</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""ACCESS_SEQ"">
                            <xsd:annotation>
                              <xsd:documentation>Access sequence - Access number</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""2"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""CONDCOUNT"">
                            <xsd:annotation>
                              <xsd:documentation>Sequential number of the condition</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""2"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""CONDCNTRL"">
                            <xsd:annotation>
                              <xsd:documentation>Condition control</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""CONDISACTI"">
                            <xsd:annotation>
                              <xsd:documentation>Condition is inactive</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""CONDCLASS"">
                            <xsd:annotation>
                              <xsd:documentation>Condition class</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""FACTBASVAL"">
                            <xsd:annotation>
                              <xsd:documentation>Factor for condition base value</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""24"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""SCALEBASIN"">
                            <xsd:annotation>
                              <xsd:documentation>Scale basis indicator</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""SCALBASVAL"">
                            <xsd:annotation>
                              <xsd:documentation>Scale base value of the condition</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""31"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""UNITMEASUR"">
                            <xsd:annotation>
                              <xsd:documentation>Condition scale unit of measure</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""3"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""UNITMEASUR_ISO"">
                            <xsd:annotation>
                              <xsd:documentation>ISO code for unit of measurement</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""3"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""CURRENCKEY"">
                            <xsd:annotation>
                              <xsd:documentation>Scale currency</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""5"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""CURRENCKEY_ISO"">
                            <xsd:annotation>
                              <xsd:documentation>ISO code currency</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""3"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""CONDINCOMP"">
                            <xsd:annotation>
                              <xsd:documentation>Condition for inter-company billing</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""CONDCONFIG"">
                            <xsd:annotation>
                              <xsd:documentation>Condition for configuration</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""CONDCHAMAN"">
                            <xsd:annotation>
                              <xsd:documentation>Condition changed manually</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""COND_NO"">
                            <xsd:annotation>
                              <xsd:documentation>Condition record number</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""10"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""CHANGE_ID"">
                            <xsd:annotation>
                              <xsd:documentation>Change Type (U, I, S, D)</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""VENDOR_NO"">
                            <xsd:annotation>
                              <xsd:documentation>Account Number of Vendor or Creditor</xsd:documentation>
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
                    <xsd:element minOccurs=""0"" maxOccurs=""999999"" name=""E1BPMEPOCONDHEADERX"">
                      <xsd:annotation>
                        <xsd:documentation>Conditions (Header, Change Bar)</xsd:documentation>
                      </xsd:annotation>
                      <xsd:complexType>
                        <xsd:sequence>
                          <xsd:element minOccurs=""0"" name=""CONDITION_NO"">
                            <xsd:annotation>
                              <xsd:documentation>Number of the document condition</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""10"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""ITM_NUMBER"">
                            <xsd:annotation>
                              <xsd:documentation>Condition item number</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""6"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""COND_ST_NO"">
                            <xsd:annotation>
                              <xsd:documentation>Step number</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""3"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""CONDITION_NOX"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""ITM_NUMBERX"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""COND_ST_NOX"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""COND_COUNT"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""COND_TYPE"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""COND_VALUE"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""CURRENCY"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""CURRENCY_ISO"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""COND_UNIT"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""COND_UNIT_ISO"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""COND_P_UNT"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""APPLICATIO"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""CONPRICDAT"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""CALCTYPCON"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""CONBASEVAL"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""CONEXCHRAT"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""NUMCONVERT"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""DENOMINATO"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""CONDTYPE"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""STAT_CON"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""SCALETYPE"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""ACCRUALS"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""CONINVOLST"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""CONDORIGIN"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""GROUPCOND"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""COND_UPDAT"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""ACCESS_SEQ"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""CONDCOUNT"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""CONDCNTRL"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""CONDISACTI"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""CONDCLASS"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""FACTBASVAL"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""SCALEBASIN"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""SCALBASVAL"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""UNITMEASUR"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""UNITMEASUR_ISO"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""CURRENCKEY"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""CURRENCKEY_ISO"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""CONDINCOMP"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""CONDCONFIG"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""CONDCHAMAN"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""COND_NO"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""CHANGE_ID"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""VENDOR_NO"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
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
                    <xsd:element minOccurs=""0"" maxOccurs=""999999"" name=""E1BPMEPOCOND"">
                      <xsd:annotation>
                        <xsd:documentation>Conditions in purchase order</xsd:documentation>
                      </xsd:annotation>
                      <xsd:complexType>
                        <xsd:sequence>
                          <xsd:element minOccurs=""0"" name=""CONDITION_NO"">
                            <xsd:annotation>
                              <xsd:documentation>Number of the document condition</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""10"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""ITM_NUMBER"">
                            <xsd:annotation>
                              <xsd:documentation>Condition item number</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""6"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""COND_ST_NO"">
                            <xsd:annotation>
                              <xsd:documentation>Step number</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""3"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""COND_COUNT"">
                            <xsd:annotation>
                              <xsd:documentation>Condition counter</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""2"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""COND_TYPE"">
                            <xsd:annotation>
                              <xsd:documentation>Condition type</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""4"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""COND_VALUE"">
                            <xsd:annotation>
                              <xsd:documentation>Condition rate</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""31"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""CURRENCY"">
                            <xsd:annotation>
                              <xsd:documentation>Currency Key</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""5"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""CURRENCY_ISO"">
                            <xsd:annotation>
                              <xsd:documentation>ISO code currency</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""3"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""COND_UNIT"">
                            <xsd:annotation>
                              <xsd:documentation>Condition unit</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""3"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""COND_UNIT_ISO"">
                            <xsd:annotation>
                              <xsd:documentation>Condition unit of measure in UoM</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""3"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""COND_P_UNT"">
                            <xsd:annotation>
                              <xsd:documentation>Condition pricing unit</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""6"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""APPLICATIO"">
                            <xsd:annotation>
                              <xsd:documentation>Application</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""2"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""CONPRICDAT"">
                            <xsd:annotation>
                              <xsd:documentation>Condition pricing date</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""8"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""CALCTYPCON"">
                            <xsd:annotation>
                              <xsd:documentation>Calculation type for condition</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""CONBASEVAL"">
                            <xsd:annotation>
                              <xsd:documentation>Condition base value</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""31"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""CONEXCHRAT"">
                            <xsd:annotation>
                              <xsd:documentation>Condition exchange rate for conversion to local currency</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""11"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""NUMCONVERT"">
                            <xsd:annotation>
                              <xsd:documentation>Numerator for converting condition units to base units</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""6"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""DENOMINATO"">
                            <xsd:annotation>
                              <xsd:documentation>Denominator for converting condition units to base units</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""6"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""CONDTYPE"">
                            <xsd:annotation>
                              <xsd:documentation>Condition category (examples: tax, freight, price, cost)</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""STAT_CON"">
                            <xsd:annotation>
                              <xsd:documentation>Condition is used for statistics</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""SCALETYPE"">
                            <xsd:annotation>
                              <xsd:documentation>Scale Type</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""ACCRUALS"">
                            <xsd:annotation>
                              <xsd:documentation>Condition is Relevant for Accrual  (e.g. Freight)</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""CONINVOLST"">
                            <xsd:annotation>
                              <xsd:documentation>Condition for invoice list</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""CONDORIGIN"">
                            <xsd:annotation>
                              <xsd:documentation>Origin of the condition</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""GROUPCOND"">
                            <xsd:annotation>
                              <xsd:documentation>Group condition</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""COND_UPDAT"">
                            <xsd:annotation>
                              <xsd:documentation>Condition update</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""ACCESS_SEQ"">
                            <xsd:annotation>
                              <xsd:documentation>Access sequence - Access number</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""2"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""CONDCOUNT"">
                            <xsd:annotation>
                              <xsd:documentation>Sequential number of the condition</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""2"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""CONDCNTRL"">
                            <xsd:annotation>
                              <xsd:documentation>Condition control</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""CONDISACTI"">
                            <xsd:annotation>
                              <xsd:documentation>Condition is inactive</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""CONDCLASS"">
                            <xsd:annotation>
                              <xsd:documentation>Condition class</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""FACTBASVAL"">
                            <xsd:annotation>
                              <xsd:documentation>Factor for condition base value</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""24"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""SCALEBASIN"">
                            <xsd:annotation>
                              <xsd:documentation>Scale basis indicator</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""SCALBASVAL"">
                            <xsd:annotation>
                              <xsd:documentation>Scale base value of the condition</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""31"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""UNITMEASUR"">
                            <xsd:annotation>
                              <xsd:documentation>Condition scale unit of measure</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""3"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""UNITMEASUR_ISO"">
                            <xsd:annotation>
                              <xsd:documentation>ISO code for unit of measurement</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""3"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""CURRENCKEY"">
                            <xsd:annotation>
                              <xsd:documentation>Scale currency</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""5"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""CURRENCKEY_ISO"">
                            <xsd:annotation>
                              <xsd:documentation>ISO code currency</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""3"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""CONDINCOMP"">
                            <xsd:annotation>
                              <xsd:documentation>Condition for inter-company billing</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""CONDCONFIG"">
                            <xsd:annotation>
                              <xsd:documentation>Condition for configuration</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""CONDCHAMAN"">
                            <xsd:annotation>
                              <xsd:documentation>Condition changed manually</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""COND_NO"">
                            <xsd:annotation>
                              <xsd:documentation>Condition record number</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""10"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""CHANGE_ID"">
                            <xsd:annotation>
                              <xsd:documentation>Change Type (U, I, S, D)</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""VENDOR_NO"">
                            <xsd:annotation>
                              <xsd:documentation>Account Number of Vendor or Creditor</xsd:documentation>
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
                    <xsd:element minOccurs=""0"" maxOccurs=""999999"" name=""E1BPMEPOCONDX"">
                      <xsd:annotation>
                        <xsd:documentation>Change Toolbar: Conditions in Purchase Order</xsd:documentation>
                      </xsd:annotation>
                      <xsd:complexType>
                        <xsd:sequence>
                          <xsd:element minOccurs=""0"" name=""CONDITION_NO"">
                            <xsd:annotation>
                              <xsd:documentation>Number of the document condition</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""10"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""ITM_NUMBER"">
                            <xsd:annotation>
                              <xsd:documentation>Condition item number</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""6"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""COND_ST_NO"">
                            <xsd:annotation>
                              <xsd:documentation>Step number</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""3"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""CONDITION_NOX"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""ITM_NUMBERX"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""COND_ST_NOX"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""COND_COUNT"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""COND_TYPE"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""COND_VALUE"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""CURRENCY"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""CURRENCY_ISO"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""COND_UNIT"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""COND_UNIT_ISO"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""COND_P_UNT"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""APPLICATIO"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""CONPRICDAT"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""CALCTYPCON"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""CONBASEVAL"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""CONEXCHRAT"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""NUMCONVERT"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""DENOMINATO"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""CONDTYPE"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""STAT_CON"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""SCALETYPE"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""ACCRUALS"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""CONINVOLST"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""CONDORIGIN"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""GROUPCOND"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""COND_UPDAT"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""ACCESS_SEQ"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""CONDCOUNT"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""CONDCNTRL"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""CONDISACTI"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""CONDCLASS"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""FACTBASVAL"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""SCALEBASIN"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""SCALBASVAL"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""UNITMEASUR"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""UNITMEASUR_ISO"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""CURRENCKEY"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""CURRENCKEY_ISO"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""CONDINCOMP"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""CONDCONFIG"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""CONDCHAMAN"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""COND_NO"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""CHANGE_ID"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""VENDOR_NO"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
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
                    <xsd:element minOccurs=""0"" maxOccurs=""999999"" name=""E1BPESUHC"">
                      <xsd:annotation>
                        <xsd:documentation>Communication Structure: Limits</xsd:documentation>
                      </xsd:annotation>
                      <xsd:complexType>
                        <xsd:sequence>
                          <xsd:element minOccurs=""0"" name=""PCKG_NO"">
                            <xsd:annotation>
                              <xsd:documentation>Package number</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""10"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""LIMIT"">
                            <xsd:annotation>
                              <xsd:documentation>Overall limit</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""25"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""NO_LIMIT"">
                            <xsd:annotation>
                              <xsd:documentation>No Limit</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""EXP_VALUE"">
                            <xsd:annotation>
                              <xsd:documentation>Expected value</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""25"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""SSC_EXIST"">
                            <xsd:annotation>
                              <xsd:documentation>Limits exist for service types</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""CON_EXIST"">
                            <xsd:annotation>
                              <xsd:documentation>Limit on contract items exists</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""TMP_EXIST"">
                            <xsd:annotation>
                              <xsd:documentation>Limit on service packages exists</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""PRICE_CHG"">
                            <xsd:annotation>
                              <xsd:documentation>Price Change in Entry Sheet</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""FREE_LIMIT"">
                            <xsd:annotation>
                              <xsd:documentation>Free limit</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""25"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""NO_FRLIMIT"">
                            <xsd:annotation>
                              <xsd:documentation>No Limit</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""SERV_TYPE"">
                            <xsd:annotation>
                              <xsd:documentation>Short Description of Service Type</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""3"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""EDITION"">
                            <xsd:annotation>
                              <xsd:documentation>Edition of Service Type</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""4"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""SSC_LIMIT"">
                            <xsd:annotation>
                              <xsd:documentation>Value limits on service types</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""25"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""SSC_NOLIM"">
                            <xsd:annotation>
                              <xsd:documentation>No limit on standard service type</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""SSC_PRSCHG"">
                            <xsd:annotation>
                              <xsd:documentation>Price Change in Entry Sheet</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""SSC_PERC"">
                            <xsd:annotation>
                              <xsd:documentation>Percentage for price determination</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""5"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""TMP_NUMBER"">
                            <xsd:annotation>
                              <xsd:documentation>Number of a Set of Model Service Specifications</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""10"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""TMP_LIMIT"">
                            <xsd:annotation>
                              <xsd:documentation>Limits on model service specifications</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""25"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""TMP_NOLIM"">
                            <xsd:annotation>
                              <xsd:documentation>No Limit on Model Specifications</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""TMP_PRSCHG"">
                            <xsd:annotation>
                              <xsd:documentation>Price Change in Entry Sheet</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""TMP_PERC"">
                            <xsd:annotation>
                              <xsd:documentation>Percentage for Price Determination</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""5"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""CONT_PERC"">
                            <xsd:annotation>
                              <xsd:documentation>Percentage for price determination</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""5"" />
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
                    <xsd:element minOccurs=""0"" maxOccurs=""999999"" name=""E1BPESUCC"">
                      <xsd:annotation>
                        <xsd:documentation>Communication Structure: Contract Limits</xsd:documentation>
                      </xsd:annotation>
                      <xsd:complexType>
                        <xsd:sequence>
                          <xsd:element minOccurs=""0"" name=""PCKG_NO"">
                            <xsd:annotation>
                              <xsd:documentation>Package number</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""10"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""LINE_NO"">
                            <xsd:annotation>
                              <xsd:documentation>Internal line number for limits</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""10"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""CON_NUMBER"">
                            <xsd:annotation>
                              <xsd:documentation>Contract number</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""10"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""CON_ITEM"">
                            <xsd:annotation>
                              <xsd:documentation>Item number, contract</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""5"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""LIMIT"">
                            <xsd:annotation>
                              <xsd:documentation>Overall limit</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""25"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""NO_LIMIT"">
                            <xsd:annotation>
                              <xsd:documentation>No Limit</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""PRICE_CHG"">
                            <xsd:annotation>
                              <xsd:documentation>Price Change in Entry Sheet</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""SHORT_TEXT"">
                            <xsd:annotation>
                              <xsd:documentation>Short Text 1</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""40"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""DELETE_IND"">
                            <xsd:annotation>
                              <xsd:documentation>Deletion Indicator</xsd:documentation>
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
                    <xsd:element minOccurs=""0"" maxOccurs=""999999"" name=""E1BPESLLC"">
                      <xsd:annotation>
                        <xsd:documentation>Communication Structure: Create Service Line</xsd:documentation>
                      </xsd:annotation>
                      <xsd:complexType>
                        <xsd:sequence>
                          <xsd:element minOccurs=""0"" name=""PCKG_NO"">
                            <xsd:annotation>
                              <xsd:documentation>Package number</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""10"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""LINE_NO"">
                            <xsd:annotation>
                              <xsd:documentation>Internal line number</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""10"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""EXT_LINE"">
                            <xsd:annotation>
                              <xsd:documentation>Line Number</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""10"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""OUTL_LEVEL"">
                            <xsd:annotation>
                              <xsd:documentation>Hierarchy level of group</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""3"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""OUTL_NO"">
                            <xsd:annotation>
                              <xsd:documentation>Outline Level</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""8"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""OUTL_IND"">
                            <xsd:annotation>
                              <xsd:documentation>Indicator: Outline line</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""SUBPCKG_NO"">
                            <xsd:annotation>
                              <xsd:documentation>Subpackage number</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""10"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""SERVICE"">
                            <xsd:annotation>
                              <xsd:documentation>Activity Number</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""18"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""SERV_TYPE"">
                            <xsd:annotation>
                              <xsd:documentation>Short Description of Service Type</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""3"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""EDITION"">
                            <xsd:annotation>
                              <xsd:documentation>Edition of Service Type</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""4"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""SSC_ITEM"">
                            <xsd:annotation>
                              <xsd:documentation>Standard Service Catalog Item</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""18"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""EXT_SERV"">
                            <xsd:annotation>
                              <xsd:documentation>Vendor's Service Number</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""18"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""QUANTITY"">
                            <xsd:annotation>
                              <xsd:documentation>Quantity with Sign</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""15"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""BASE_UOM"">
                            <xsd:annotation>
                              <xsd:documentation>Base Unit of Measure</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""3"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""UOM_ISO"">
                            <xsd:annotation>
                              <xsd:documentation>ISO code for unit of measurement</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""3"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""OVF_TOL"">
                            <xsd:annotation>
                              <xsd:documentation>Overfulfillment Tolerance</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""5"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""OVF_UNLIM"">
                            <xsd:annotation>
                              <xsd:documentation>Unlimited Overfulfillment</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""PRICE_UNIT"">
                            <xsd:annotation>
                              <xsd:documentation>Price Unit</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""6"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""GR_PRICE"">
                            <xsd:annotation>
                              <xsd:documentation>Gross price</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""25"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""FROM_LINE"">
                            <xsd:annotation>
                              <xsd:documentation>Lower Limit</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""6"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""TO_LINE"">
                            <xsd:annotation>
                              <xsd:documentation>Upper Limit</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""6"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""SHORT_TEXT"">
                            <xsd:annotation>
                              <xsd:documentation>Short Text</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""40"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""DISTRIB"">
                            <xsd:annotation>
                              <xsd:documentation>Distribution Indicator for Multiple Account Assignment</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""PERS_NO"">
                            <xsd:annotation>
                              <xsd:documentation>Personnel Number</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""8"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""WAGETYPE"">
                            <xsd:annotation>
                              <xsd:documentation>Wage Type</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""4"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""PLN_PCKG"">
                            <xsd:annotation>
                              <xsd:documentation>Source package number</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""10"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""PLN_LINE"">
                            <xsd:annotation>
                              <xsd:documentation>Entry: Planned package line</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""10"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""CON_PCKG"">
                            <xsd:annotation>
                              <xsd:documentation>Entry: Unplanned from contract</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""10"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""CON_LINE"">
                            <xsd:annotation>
                              <xsd:documentation>Entry: Unplanned from contract</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""10"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""TMP_PCKG"">
                            <xsd:annotation>
                              <xsd:documentation>Entry: Unplanned service from model specifications</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""10"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""TMP_LINE"">
                            <xsd:annotation>
                              <xsd:documentation>Entry: Unplanned service from model specifications</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""10"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""SSC_LIM"">
                            <xsd:annotation>
                              <xsd:documentation>Service line refers to standard service catalog limits</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""LIMIT_LINE"">
                            <xsd:annotation>
                              <xsd:documentation>Entry: Unplanned, limit line</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""10"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""TARGET_VAL"">
                            <xsd:annotation>
                              <xsd:documentation>Target Value</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""25"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""BASLINE_NO"">
                            <xsd:annotation>
                              <xsd:documentation>Alternatives: Reference to basic item</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""10"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""BASIC_LINE"">
                            <xsd:annotation>
                              <xsd:documentation>Basic Line</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""ALTERNAT"">
                            <xsd:annotation>
                              <xsd:documentation>Alternative Line</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""BIDDER"">
                            <xsd:annotation>
                              <xsd:documentation>Bidder's Line</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""SUPP_LINE"">
                            <xsd:annotation>
                              <xsd:documentation>Supplementary Line</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""OPEN_QTY"">
                            <xsd:annotation>
                              <xsd:documentation>Line with Open Quantity</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""INFORM"">
                            <xsd:annotation>
                              <xsd:documentation>Informatory Line</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""BLANKET"">
                            <xsd:annotation>
                              <xsd:documentation>Blanket Line</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""EVENTUAL"">
                            <xsd:annotation>
                              <xsd:documentation>Contingency Line</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""TAX_CODE"">
                            <xsd:annotation>
                              <xsd:documentation>Tax on sales/purchases code</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""2"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""TAXJURCODE"">
                            <xsd:annotation>
                              <xsd:documentation>Tax Jurisdiction</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""15"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""PRICE_CHG"">
                            <xsd:annotation>
                              <xsd:documentation>Price Change in Entry Sheet</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""MATL_GROUP"">
                            <xsd:annotation>
                              <xsd:documentation>Material Group</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""9"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""DATE"">
                            <xsd:annotation>
                              <xsd:documentation>Date</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""8"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""BEGINTIME"">
                            <xsd:annotation>
                              <xsd:documentation>Start Time</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""6"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""ENDTIME"">
                            <xsd:annotation>
                              <xsd:documentation>End Time</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""6"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""EXTPERS_NO"">
                            <xsd:annotation>
                              <xsd:documentation>External Personnel Number</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""40"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""FORMULA"">
                            <xsd:annotation>
                              <xsd:documentation>Formula Number</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""10"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""FORM_VAL1"">
                            <xsd:annotation>
                              <xsd:documentation>Formula Value</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""15"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""FORM_VAL2"">
                            <xsd:annotation>
                              <xsd:documentation>Formula value</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""15"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""FORM_VAL3"">
                            <xsd:annotation>
                              <xsd:documentation>Formula value</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""15"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""FORM_VAL4"">
                            <xsd:annotation>
                              <xsd:documentation>Formula value</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""15"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""FORM_VAL5"">
                            <xsd:annotation>
                              <xsd:documentation>Formula value</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""15"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
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
                          <xsd:element minOccurs=""0"" name=""HI_LINE_NO"">
                            <xsd:annotation>
                              <xsd:documentation>Hierarchically superior line number</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""10"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""EXTREFKEY"">
                            <xsd:annotation>
                              <xsd:documentation>External Reference Key for Service</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""40"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""DELETE_IND"">
                            <xsd:annotation>
                              <xsd:documentation>Deletion Indicator</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""PER_SDATE"">
                            <xsd:annotation>
                              <xsd:documentation>Period of Performance Start Date</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""8"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""PER_EDATE"">
                            <xsd:annotation>
                              <xsd:documentation>Period of Performance End Date</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""8"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""EXTERNAL_ITEM_ID"">
                            <xsd:annotation>
                              <xsd:documentation>SRM Reference Key</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""40"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""SERVICE_ITEM_KEY"">
                            <xsd:annotation>
                              <xsd:documentation>Item Key for eSOA Messages</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""10"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""NET_VALUE"">
                            <xsd:annotation>
                              <xsd:documentation>Net value</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""25"" />
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
                    <xsd:element minOccurs=""0"" maxOccurs=""999999"" name=""E1BPESKLC"">
                      <xsd:annotation>
                        <xsd:documentation>Create Comm. Structure: Acct Assgt Distr. for Service Line</xsd:documentation>
                      </xsd:annotation>
                      <xsd:complexType>
                        <xsd:sequence>
                          <xsd:element minOccurs=""0"" name=""PCKG_NO"">
                            <xsd:annotation>
                              <xsd:documentation>Package number</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""10"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""LINE_NO"">
                            <xsd:annotation>
                              <xsd:documentation>Line Number</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""10"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""SERNO_LINE"">
                            <xsd:annotation>
                              <xsd:documentation>Seq. Number of Acc. Assignment Specification: Service Line</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""2"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""PERCENTAGE"">
                            <xsd:annotation>
                              <xsd:documentation>Percentage for Account Assignment Value Distribution</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""7"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""SERIAL_NO"">
                            <xsd:annotation>
                              <xsd:documentation>Sequential Number of Account Assignment</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""2"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""QUANTITY"">
                            <xsd:annotation>
                              <xsd:documentation>Quantity with Sign</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""15"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""NET_VALUE"">
                            <xsd:annotation>
                              <xsd:documentation>Net Value of Item</xsd:documentation>
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
                    <xsd:element minOccurs=""0"" maxOccurs=""999999"" name=""E1BPESLLTX"">
                      <xsd:annotation>
                        <xsd:documentation>BAPI Services Long Text</xsd:documentation>
                      </xsd:annotation>
                      <xsd:complexType>
                        <xsd:sequence>
                          <xsd:element minOccurs=""0"" name=""PCKG_NO"">
                            <xsd:annotation>
                              <xsd:documentation>Package number</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""10"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""LINE_NO"">
                            <xsd:annotation>
                              <xsd:documentation>Internal line number</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""10"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""TEXT_ID"">
                            <xsd:annotation>
                              <xsd:documentation>Text ID</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""4"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""FORMAT_COL"">
                            <xsd:annotation>
                              <xsd:documentation>Tag column</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""2"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""TEXT_LINE"">
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
                    <xsd:element minOccurs=""0"" maxOccurs=""999999"" name=""E1BPPAREX"">
                      <xsd:annotation>
                        <xsd:documentation>Ref. Structure for BAPI Parameter EXTENSIONIN/EXTENSIONOUT</xsd:documentation>
                      </xsd:annotation>
                      <xsd:complexType>
                        <xsd:sequence>
                          <xsd:element minOccurs=""0"" name=""STRUCTURE"">
                            <xsd:annotation>
                              <xsd:documentation>Structure name of  BAPI table extension</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""30"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""VALUEPART1"">
                            <xsd:annotation>
                              <xsd:documentation>Data part of BAPI extension parameter</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""240"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""VALUEPART2"">
                            <xsd:annotation>
                              <xsd:documentation>Data part of BAPI extension parameter</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""240"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""VALUEPART3"">
                            <xsd:annotation>
                              <xsd:documentation>Data part of BAPI extension parameter</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""240"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""VALUEPART4"">
                            <xsd:annotation>
                              <xsd:documentation>Data part of BAPI extension parameter</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""240"" />
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
                    <xsd:element minOccurs=""0"" maxOccurs=""999999"" name=""E1BPEIPO"">
                      <xsd:annotation>
                        <xsd:documentation>Foreign Trade: Export/Import: Item Data</xsd:documentation>
                      </xsd:annotation>
                      <xsd:complexType>
                        <xsd:sequence>
                          <xsd:element minOccurs=""0"" name=""PO_ITEM"">
                            <xsd:annotation>
                              <xsd:documentation>Item Number of Purchasing Document</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""5"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""BUSINESS_TRANSACTION_TYPE"">
                            <xsd:annotation>
                              <xsd:documentation>Business Transaction Type for Foreign Trade</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""2"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""EXPORT_IMPORT_PROCEDURE"">
                            <xsd:annotation>
                              <xsd:documentation>Export/Import Procedure for Foreign Trade</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""8"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""COUNTRYORI"">
                            <xsd:annotation>
                              <xsd:documentation>Country of origin of the material</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""3"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""COUNTRYORI_ISO"">
                            <xsd:annotation>
                              <xsd:documentation>Country ISO code</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""2"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""REGIONORIG"">
                            <xsd:annotation>
                              <xsd:documentation>Region of origin of material (non-preferential origin)</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""3"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""COMM_CODE"">
                            <xsd:annotation>
                              <xsd:documentation>Commodity Code/Import Code Number for Foreign Trade</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""17"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""SHIPPING_COUNTRY"">
                            <xsd:annotation>
                              <xsd:documentation>Country of dispatch for Foreign Trade</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""3"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""SHIPPING_COUNTRY_ISO"">
                            <xsd:annotation>
                              <xsd:documentation>Country ISO code</xsd:documentation>
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
                    <xsd:element minOccurs=""0"" maxOccurs=""999999"" name=""E1BPEIPOX"">
                      <xsd:annotation>
                        <xsd:documentation>Foreign Trade: Import/Export: Item Data (Change Parameter)</xsd:documentation>
                      </xsd:annotation>
                      <xsd:complexType>
                        <xsd:sequence>
                          <xsd:element minOccurs=""0"" name=""PO_ITEM"">
                            <xsd:annotation>
                              <xsd:documentation>Item Number of Purchasing Document</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""5"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""BUSINESS_TRANSACTION_TYPE"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""EXPORT_IMPORT_PROCEDURE"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""COUNTRYORI"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""COUNTRYORI_ISO"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""REGIONORIG"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""COMM_CODE"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""SHIPPING_COUNTRY"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""SHIPPING_COUNTRY_ISO"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
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
                    <xsd:element minOccurs=""0"" maxOccurs=""999999"" name=""E1BPMEPOTEXTHEADER"">
                      <xsd:annotation>
                        <xsd:documentation>Header Texts</xsd:documentation>
                      </xsd:annotation>
                      <xsd:complexType>
                        <xsd:sequence>
                          <xsd:element minOccurs=""0"" name=""PO_NUMBER"">
                            <xsd:annotation>
                              <xsd:documentation>Purchasing Document Number</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""10"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""PO_ITEM"">
                            <xsd:annotation>
                              <xsd:documentation>Item Number of Purchasing Document</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""5"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""TEXT_ID"">
                            <xsd:annotation>
                              <xsd:documentation>Text ID</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""4"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""TEXT_FORM"">
                            <xsd:annotation>
                              <xsd:documentation>Tag column</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""2"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""TEXT_LINE"">
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
                    <xsd:element minOccurs=""0"" maxOccurs=""999999"" name=""E1BPMEPOTEXT"">
                      <xsd:annotation>
                        <xsd:documentation>Texts: (Header or Item)</xsd:documentation>
                      </xsd:annotation>
                      <xsd:complexType>
                        <xsd:sequence>
                          <xsd:element minOccurs=""0"" name=""PO_NUMBER"">
                            <xsd:annotation>
                              <xsd:documentation>Purchasing Document Number</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""10"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""PO_ITEM"">
                            <xsd:annotation>
                              <xsd:documentation>Item Number of Purchasing Document</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""5"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""TEXT_ID"">
                            <xsd:annotation>
                              <xsd:documentation>Text ID</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""4"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""TEXT_FORM"">
                            <xsd:annotation>
                              <xsd:documentation>Tag column</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""2"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""TEXT_LINE"">
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
                    <xsd:element minOccurs=""0"" maxOccurs=""999999"" name=""E1BPMEDCM_ALLVERSIONS"">
                      <xsd:annotation>
                        <xsd:documentation>Version Management - All Version Data</xsd:documentation>
                      </xsd:annotation>
                      <xsd:complexType>
                        <xsd:sequence>
                          <xsd:element minOccurs=""0"" name=""DOC_TYPE"">
                            <xsd:annotation>
                              <xsd:documentation>Purchasing Document Category</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""DOC_NUMBER"">
                            <xsd:annotation>
                              <xsd:documentation>Object Number in Purchasing</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""10"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""ITEM_NUMBER"">
                            <xsd:annotation>
                              <xsd:documentation>Purchasing object: item</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""5"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""VERSION"">
                            <xsd:annotation>
                              <xsd:documentation>Version number in Purchasing</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""8"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""CREATED_BY"">
                            <xsd:annotation>
                              <xsd:documentation>Name of Person who Created the Object</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""12"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""CR_ON"">
                            <xsd:annotation>
                              <xsd:documentation>Date on Which Record Was Created</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""8"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""REC_TIME"">
                            <xsd:annotation>
                              <xsd:documentation>Entry time</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""6"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""RELEASED_BY"">
                            <xsd:annotation>
                              <xsd:documentation>Name of person effecting release</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""12"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""RELEASE_DATE"">
                            <xsd:annotation>
                              <xsd:documentation>Date of release</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""8"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""RELEASE_TIME"">
                            <xsd:annotation>
                              <xsd:documentation>Time of release</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""6"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""RELEASEBY_PUR"">
                            <xsd:annotation>
                              <xsd:documentation>Name of approving buyer</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""12"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""RELEASEDATE_PUR"">
                            <xsd:annotation>
                              <xsd:documentation>Date of buyer approval</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""8"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""RELEASETIME_PUR"">
                            <xsd:annotation>
                              <xsd:documentation>Time of buyer approval</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""6"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""REASON"">
                            <xsd:annotation>
                              <xsd:documentation>Reason for change</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""4"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""DESCRIPTION"">
                            <xsd:annotation>
                              <xsd:documentation>Description of version</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""60"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""REQ_BY_EXT"">
                            <xsd:annotation>
                              <xsd:documentation>External Change Number of Version</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""20"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""REQ_BY"">
                            <xsd:annotation>
                              <xsd:documentation>Person requesting change</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""12"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""NET_VALUE"">
                            <xsd:annotation>
                              <xsd:documentation>Net Order Value in PO Currency</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""15"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""VALUE_CHANGED"">
                            <xsd:annotation>
                              <xsd:documentation>Value change due to version</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""15"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""CURRENCY"">
                            <xsd:annotation>
                              <xsd:documentation>Currency Key</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""5"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""CURRENCY_ISO"">
                            <xsd:annotation>
                              <xsd:documentation>ISO code currency</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""3"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""POST_DATE"">
                            <xsd:annotation>
                              <xsd:documentation>Posting date of version</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""8"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""COMPLETED"">
                            <xsd:annotation>
                              <xsd:documentation>Status ""version completed""</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""STATUS"">
                            <xsd:annotation>
                              <xsd:documentation>Version status</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""DELETE_IND"">
                            <xsd:annotation>
                              <xsd:documentation>Deletion Indicator in Purchasing Document</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""STATUS_DOC_OLD"">
                            <xsd:annotation>
                              <xsd:documentation>Old processing state in purchasing document before version</xsd:documentation>
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
                    <xsd:element minOccurs=""0"" maxOccurs=""999999"" name=""E1BPEKKOP"">
                      <xsd:annotation>
                        <xsd:documentation>Transfer Structure for Partner Roles in BAPI_PO_CREATE</xsd:documentation>
                      </xsd:annotation>
                      <xsd:complexType>
                        <xsd:sequence>
                          <xsd:element minOccurs=""0"" name=""PARTNERDESC"">
                            <xsd:annotation>
                              <xsd:documentation>Language-specific description of partner function</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""2"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""LANGU"">
                            <xsd:annotation>
                              <xsd:documentation>Language Key</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""BUSPARTNO"">
                            <xsd:annotation>
                              <xsd:documentation>Number of a Business Partner in Vendor Master Record</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""10"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""DELETE_IND"">
                            <xsd:annotation>
                              <xsd:documentation>Deletion Indicator</xsd:documentation>
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
                    <xsd:element minOccurs=""0"" maxOccurs=""999999"" name=""E1BPMEPOCOMPONENT"">
                      <xsd:annotation>
                        <xsd:documentation>BAPI Structure for Components</xsd:documentation>
                      </xsd:annotation>
                      <xsd:complexType>
                        <xsd:sequence>
                          <xsd:element minOccurs=""0"" name=""PO_ITEM"">
                            <xsd:annotation>
                              <xsd:documentation>Item Number of Purchasing Document</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""5"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""SCHED_LINE"">
                            <xsd:annotation>
                              <xsd:documentation>Delivery Schedule Line Number</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""4"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""ITEM_NO"">
                            <xsd:annotation>
                              <xsd:documentation>Item Number of Reservation/Dependent Requirement</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""4"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""MATERIAL"">
                            <xsd:annotation>
                              <xsd:documentation>Material Number</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""18"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""ENTRY_QUANTITY"">
                            <xsd:annotation>
                              <xsd:documentation>Requirement quantity of the component</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""15"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""ENTRY_UOM"">
                            <xsd:annotation>
                              <xsd:documentation>Unit of Entry</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""3"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""ENTRY_UOM_ISO"">
                            <xsd:annotation>
                              <xsd:documentation>Unit of entry in ISO code</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""3"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""FIXED_QUAN"">
                            <xsd:annotation>
                              <xsd:documentation>Quantity is Fixed</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""PLANT"">
                            <xsd:annotation>
                              <xsd:documentation>Plant</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""4"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""REQ_DATE"">
                            <xsd:annotation>
                              <xsd:documentation>Requirement Date for the Component</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""8"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""CHANGE_ID"">
                            <xsd:annotation>
                              <xsd:documentation>Change Type (U, I, S, D)</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""MATERIAL_EXTERNAL"">
                            <xsd:annotation>
                              <xsd:documentation>Long Material Number for MATERIAL Field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""40"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""MATERIAL_GUID"">
                            <xsd:annotation>
                              <xsd:documentation>External GUID for MATERIAL Field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""32"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""MATERIAL_VERSION"">
                            <xsd:annotation>
                              <xsd:documentation>Version Number for MATERIAL Field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""10"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""ITEM_CAT"">
                            <xsd:annotation>
                              <xsd:documentation>Item Category (Bill of Material)</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""REQ_QUAN"">
                            <xsd:annotation>
                              <xsd:documentation>Requirement Quantity</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""15"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""BASE_UOM"">
                            <xsd:annotation>
                              <xsd:documentation>Base Unit of Measure</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""3"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""BASE_UOM_ISO"">
                            <xsd:annotation>
                              <xsd:documentation>Base unit of measure in ISO code</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""3"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""PHANT_ITEM"">
                            <xsd:annotation>
                              <xsd:documentation>Phantom item indicator</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""BATCH"">
                            <xsd:annotation>
                              <xsd:documentation>Batch Number</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""10"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""MAT_PROVISION"">
                            <xsd:annotation>
                              <xsd:documentation>Material Provision Indicator</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""ISS_ST_LOC"">
                            <xsd:annotation>
                              <xsd:documentation>Issue Storage Location</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""4"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""REV_LEV"">
                            <xsd:annotation>
                              <xsd:documentation>Revision Level</xsd:documentation>
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
                    <xsd:element minOccurs=""0"" maxOccurs=""999999"" name=""E1BPMEPOCOMPONENTX"">
                      <xsd:annotation>
                        <xsd:documentation>Update Information for Components in BUS2012 API</xsd:documentation>
                      </xsd:annotation>
                      <xsd:complexType>
                        <xsd:sequence>
                          <xsd:element minOccurs=""0"" name=""PO_ITEM"">
                            <xsd:annotation>
                              <xsd:documentation>Item Number of Purchasing Document</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""5"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""SCHED_LINE"">
                            <xsd:annotation>
                              <xsd:documentation>Delivery Schedule Line Number</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""4"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""ITEM_NO"">
                            <xsd:annotation>
                              <xsd:documentation>Item Number of Reservation/Dependent Requirement</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""4"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""PO_ITEMX"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""SCHED_LINEX"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""ITEM_NOX"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""MATERIAL"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""ENTRY_QUANTITY"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""ENTRY_UOM"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""ENTRY_UOM_ISO"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""FIXED_QUAN"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""PLANT"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""REQ_DATE"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""CHANGE_ID"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""MATERIAL_EXTERNAL"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""MATERIAL_GUID"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""MATERIAL_VERSION"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""REQ_QUAN"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""BASE_UOM"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""BASE_UOM_ISO"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""PHANT_ITEM"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""BATCH"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""MAT_PROVISION"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""ISS_ST_LOC"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""ITEM_CAT"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""REV_LEV"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
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
                    <xsd:element minOccurs=""0"" maxOccurs=""999999"" name=""E1BPITEMSHIP"">
                      <xsd:annotation>
                        <xsd:documentation>BAPI Shipping Data for Stock Transport Orders</xsd:documentation>
                      </xsd:annotation>
                      <xsd:complexType>
                        <xsd:sequence>
                          <xsd:element minOccurs=""0"" name=""PO_ITEM"">
                            <xsd:annotation>
                              <xsd:documentation>Item Number of Purchasing Document</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""5"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""SHIP_POINT"">
                            <xsd:annotation>
                              <xsd:documentation>Shipping Point/Receiving Point</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""4"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""SHIP_COND"">
                            <xsd:annotation>
                              <xsd:documentation>Shipping Conditions</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""2"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""DLV_PRIO"">
                            <xsd:annotation>
                              <xsd:documentation>Delivery Priority</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""2"" />
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
                          <xsd:element minOccurs=""0"" name=""UNLOAD_PT"">
                            <xsd:annotation>
                              <xsd:documentation>Unloading Point</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""25"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""AUTH_NUMBER"">
                            <xsd:annotation>
                              <xsd:documentation>Return Material Authorization Number</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""20"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""SRC_DLV_NO"">
                            <xsd:annotation>
                              <xsd:documentation>Source delivery number</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""10"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""SRC_HANDLG_UNIT"">
                            <xsd:annotation>
                              <xsd:documentation>Source/Target handling unit (external ID)</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""20"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""INSPOUT_GUID"">
                            <xsd:annotation>
                              <xsd:documentation>Inspection Outcome: Stock  GUID set by EWM</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""32"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""FOLLOW_UP"">
                            <xsd:annotation>
                              <xsd:documentation>Default Follow-Up Activity Code</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""4"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""LOADINGGRP"">
                            <xsd:annotation>
                              <xsd:documentation>Loading Group</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""4"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""TRANS_GRP"">
                            <xsd:annotation>
                              <xsd:documentation>Transportation Group</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""4"" />
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
                    <xsd:element minOccurs=""0"" maxOccurs=""999999"" name=""E1BPITEMSHIPX"">
                      <xsd:annotation>
                        <xsd:documentation>BAPI Shipping Data Change Parameter</xsd:documentation>
                      </xsd:annotation>
                      <xsd:complexType>
                        <xsd:sequence>
                          <xsd:element minOccurs=""0"" name=""PO_ITEM"">
                            <xsd:annotation>
                              <xsd:documentation>Item Number of Purchasing Document</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""5"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""PO_ITEMX"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""SHIP_POINT"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""SHIP_COND"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""DLV_PRIO"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""ROUTE"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""UNLOAD_PT"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""AUTH_NUMBER"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""SRC_DLV_NO"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""SRC_HANDLG_UNIT"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""INSPOUT_GUID"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""FOLLOW_UP"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""LOADINGGRP"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""TRANS_GRP"">
                            <xsd:annotation>
                              <xsd:documentation>Updated information in related user data field</xsd:documentation>
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
                    <xsd:element minOccurs=""0"" maxOccurs=""999999"" name=""E1BPMEPOSHIPPEXP"">
                      <xsd:annotation>
                        <xsd:documentation>Export Structure for Shipping Data</xsd:documentation>
                      </xsd:annotation>
                      <xsd:complexType>
                        <xsd:sequence>
                          <xsd:element minOccurs=""0"" name=""PO_ITEM"">
                            <xsd:annotation>
                              <xsd:documentation>Item Number of Purchasing Document</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""5"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""SHIP_POINT"">
                            <xsd:annotation>
                              <xsd:documentation>Shipping Point/Receiving Point</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""4"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""DLV_PRIO"">
                            <xsd:annotation>
                              <xsd:documentation>Delivery Priority</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""2"" />
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
                          <xsd:element minOccurs=""0"" name=""CUSTOMER"">
                            <xsd:annotation>
                              <xsd:documentation>Customer Number</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""10"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""SOLD_TO"">
                            <xsd:annotation>
                              <xsd:documentation>Sold-to party</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""10"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""FWDAGENT"">
                            <xsd:annotation>
                              <xsd:documentation>Forwarding agent</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""10"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""SALESORG"">
                            <xsd:annotation>
                              <xsd:documentation>Sales Organization</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""4"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""DISTR_CHAN"">
                            <xsd:annotation>
                              <xsd:documentation>Distribution Channel</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""2"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""DIVISION"">
                            <xsd:annotation>
                              <xsd:documentation>Division</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""2"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""DEL_CREATE_DATE"">
                            <xsd:annotation>
                              <xsd:documentation>Delivery Creation Date</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""8"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""PLND_DELRY"">
                            <xsd:annotation>
                              <xsd:documentation>Planned Delivery Time in Days</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""4"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""LANGU"">
                            <xsd:annotation>
                              <xsd:documentation>Language Key</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""LANGU_ISO"">
                            <xsd:annotation>
                              <xsd:documentation>ISO code for language key</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""2"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""SHIP_COND"">
                            <xsd:annotation>
                              <xsd:documentation>Shipping Conditions</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""2"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""LOADINGGRP"">
                            <xsd:annotation>
                              <xsd:documentation>Loading Group</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""4"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""TRANS_GRP"">
                            <xsd:annotation>
                              <xsd:documentation>Transportation Group</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""4"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""UNLOAD_PT"">
                            <xsd:annotation>
                              <xsd:documentation>Unloading Point</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""25"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""ORDCOMBIND"">
                            <xsd:annotation>
                              <xsd:documentation>Order Combination Indicator</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""1"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""TIME_ZONE"">
                            <xsd:annotation>
                              <xsd:documentation>Time zone of delivering location</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""6"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""AUTH_NUMBER"">
                            <xsd:annotation>
                              <xsd:documentation>Return Material Authorization Number</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""20"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""SRC_DLV_NO"">
                            <xsd:annotation>
                              <xsd:documentation>Source delivery number</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""10"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""SRC_HANDLG_UNIT"">
                            <xsd:annotation>
                              <xsd:documentation>Source/Target handling unit (external ID)</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""20"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""INSPOUT_GUID"">
                            <xsd:annotation>
                              <xsd:documentation>Inspection Outcome: Stock  GUID set by EWM</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""32"" />
                              </xsd:restriction>
                            </xsd:simpleType>
                          </xsd:element>
                          <xsd:element minOccurs=""0"" name=""FOLLOW_UP"">
                            <xsd:annotation>
                              <xsd:documentation>Default Follow-Up Activity Code</xsd:documentation>
                            </xsd:annotation>
                            <xsd:simpleType>
                              <xsd:restriction base=""xsd:string"">
                                <xsd:maxLength value=""4"" />
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
        
        public PORDCR102() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "PORDCR102";
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
