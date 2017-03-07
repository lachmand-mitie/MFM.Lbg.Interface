namespace MFM.Lbg.Schemas {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://MITIE.Helpdesk.Schemas/nms/evolution/in/v1",@"evoupdates")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"evoupdates"})]
    public sealed class Norlands_Update_Msg : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://MITIE.Helpdesk.Schemas/nms/evolution/in/v1"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" targetNamespace=""http://MITIE.Helpdesk.Schemas/nms/evolution/in/v1"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""evoupdates"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo rootTypeName=""evoupdates"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""1"" maxOccurs=""unbounded"" name=""evotaskupdate"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo notes=""Many updates can be included per message envelope, minimum is 1"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:complexType>
            <xs:sequence>
              <xs:element minOccurs=""1"" maxOccurs=""1"" name=""evoref"" type=""xs:string"">
                <xs:annotation>
                  <xs:appinfo>
                    <b:fieldInfo notes=""Evolution system identifier"" />
                  </xs:appinfo>
                </xs:annotation>
              </xs:element>
              <xs:element minOccurs=""1"" maxOccurs=""1"" name=""mitieref"" type=""xs:string"">
                <xs:annotation>
                  <xs:appinfo>
                    <b:fieldInfo notes=""MITIE supplied case reference"" />
                  </xs:appinfo>
                </xs:annotation>
              </xs:element>
              <xs:element minOccurs=""1"" maxOccurs=""1"" name=""status"" type=""xs:string"">
                <xs:annotation>
                  <xs:appinfo>
                    <b:fieldInfo notes=""Evolution system task status"" />
                  </xs:appinfo>
                </xs:annotation>
              </xs:element>
              <xs:element minOccurs=""0"" maxOccurs=""1"" name=""statusdatetime"" type=""xs:dateTime"">
                <xs:annotation>
                  <xs:appinfo>
                    <b:fieldInfo notes=""Evolution system status event timestamp"" />
                  </xs:appinfo>
                </xs:annotation>
              </xs:element>
              <xs:element minOccurs=""0"" maxOccurs=""1"" name=""casenotes"">
                <xs:annotation>
                  <xs:appinfo>
                    <b:recordInfo notes=""Optional note records"" />
                  </xs:appinfo>
                </xs:annotation>
                <xs:complexType>
                  <xs:sequence>
                    <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""note"">
                      <xs:annotation>
                        <xs:appinfo>
                          <b:recordInfo notes=""Many note records can be submitted at the same time for individual task"" />
                        </xs:appinfo>
                      </xs:annotation>
                      <xs:complexType>
                        <xs:sequence>
                          <xs:element minOccurs=""1"" maxOccurs=""1"" name=""messagebody"" type=""xs:string"">
                            <xs:annotation>
                              <xs:appinfo>
                                <b:fieldInfo notes=""The note message text"" />
                              </xs:appinfo>
                            </xs:annotation>
                          </xs:element>
                          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""noteid"" type=""xs:integer"">
                            <xs:annotation>
                              <xs:appinfo>
                                <b:fieldInfo notes=""unique identifier for the note"" />
                              </xs:appinfo>
                            </xs:annotation>
                          </xs:element>
                          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""n1"" type=""xs:string"" />
                          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""n2"" type=""xs:string"" />
                          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""n3"" type=""xs:string"" />
                        </xs:sequence>
                      </xs:complexType>
                    </xs:element>
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
              <xs:element minOccurs=""0"" maxOccurs=""1"" name=""z1"" type=""xs:string"" />
              <xs:element minOccurs=""0"" maxOccurs=""1"" name=""z2"" type=""xs:string"" />
              <xs:element minOccurs=""0"" maxOccurs=""1"" name=""z3"" type=""xs:string"" />
              <xs:element minOccurs=""0"" maxOccurs=""1"" name=""z4"" type=""xs:string"" />
              <xs:element minOccurs=""0"" maxOccurs=""1"" name=""z5"" type=""xs:string"" />
            </xs:sequence>
            <xs:attribute name=""messageid"" type=""xs:int"" use=""optional"">
              <xs:annotation>
                <xs:appinfo>
                  <b:fieldInfo notes=""Message sequencing identifier"" />
                </xs:appinfo>
              </xs:annotation>
            </xs:attribute>
          </xs:complexType>
        </xs:element>
      </xs:sequence>
      <xs:attribute name=""batchid"" type=""xs:int"" use=""optional"">
        <xs:annotation>
          <xs:appinfo>
            <b:fieldInfo notes=""Unique identifier for message envelope"" />
          </xs:appinfo>
        </xs:annotation>
      </xs:attribute>
      <xs:attribute name=""batchts"" type=""xs:dateTime"" use=""optional"">
        <xs:annotation>
          <xs:appinfo>
            <b:fieldInfo notes=""timestamp for this message envelope"" />
          </xs:appinfo>
        </xs:annotation>
      </xs:attribute>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public Norlands_Update_Msg() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "evoupdates";
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
