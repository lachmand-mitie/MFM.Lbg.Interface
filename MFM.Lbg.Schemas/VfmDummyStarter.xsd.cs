namespace MFM.Lbg.Schemas {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://MFM.Lbg.Schemas.VfmDummyStarter",@"VfmDummyStarter")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"VfmDummyStarter"})]
    public sealed class VfmDummyStarter : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://MFM.Lbg.Schemas.VfmDummyStarter"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" targetNamespace=""http://MFM.Lbg.Schemas.VfmDummyStarter"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""VfmDummyStarter"">
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""Payload"">
          <xs:complexType>
            <xs:sequence>
              <xs:element maxOccurs=""unbounded"" name=""E1EDK14"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element name=""QUALF"" type=""xs:string"" />
                    <xs:element name=""ORGID"" type=""xs:string"" />
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
              <xs:element maxOccurs=""unbounded"" name=""E1EDK03"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element name=""IDDAT"" type=""xs:string"" />
                    <xs:element name=""DATUM"" type=""xs:string"" />
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
              <xs:element maxOccurs=""99"" name=""E1EDKA1"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element name=""PARVW"" type=""xs:string"" />
                    <xs:element minOccurs=""0"" maxOccurs=""1"" name=""PARTN"" type=""xs:string"" />
                    <xs:element minOccurs=""0"" maxOccurs=""1"" name=""IHREZ"" type=""xs:string"" />
                    <xs:element minOccurs=""0"" maxOccurs=""1"" name=""BNAME"" type=""xs:string"" />
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
              <xs:element maxOccurs=""99"" name=""E1EDKT1"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element name=""TDID"" type=""xs:string"" />
                    <xs:element maxOccurs=""999999"" name=""E1EDKT2"">
                      <xs:complexType>
                        <xs:sequence>
                          <xs:element name=""TDLINE"" type=""xs:string"" />
                          <xs:element name=""TDFORMAT"" type=""xs:string"" />
                        </xs:sequence>
                      </xs:complexType>
                    </xs:element>
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
              <xs:element maxOccurs=""9999"" name=""ITEM"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element name=""NUM"" type=""xs:string"" />
                    <xs:element name=""QUANTITY"" type=""xs:string"" />
                    <xs:element name=""MATERIAL"" type=""xs:string"" />
                    <xs:element name=""WBS"" type=""xs:string"" />
                    <xs:element name=""CONDITION"" type=""xs:string"" />
                    <xs:element name=""PRICE"" type=""xs:string"" />
                    <xs:element name=""KTEXT"" type=""xs:string"" />
                    <xs:element name=""KTEXTQUALF"" type=""xs:string"" />
                    <xs:element name=""TEXTID"" type=""xs:string"" />
                    <xs:element name=""TEXTP1"" type=""xs:string"" />
                    <xs:element name=""TEXTP2"" type=""xs:string"" />
                    <xs:element name=""TEXTP3"" type=""xs:string"" />
                    <xs:element name=""TEXTP4"" type=""xs:string"" />
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
            </xs:sequence>
          </xs:complexType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public VfmDummyStarter() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "VfmDummyStarter";
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
