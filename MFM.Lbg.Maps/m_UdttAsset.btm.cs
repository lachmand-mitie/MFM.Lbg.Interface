namespace MFM.Lbg.Maps {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"MFM.Lbg.Schemas.MFMWorkItemUpdate", typeof(global::MFM.Lbg.Schemas.MFMWorkItemUpdate))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"MFM.Lbg.Schemas.Add_Asset_UdttTableType_ops+ArrayOfudtt_Asset", typeof(global::MFM.Lbg.Schemas.Add_Asset_UdttTableType_ops.ArrayOfudtt_Asset))]
    public sealed class m_UdttAsset : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 ScriptNS0 ScriptNS1"" version=""1.0"" xmlns:s0=""http://MFM.Lbg.Schemas.MFMWorkItemUpdate"" xmlns:ns0=""http://schemas.microsoft.com/Sql/2008/05/Types/TableTypes/ops"" xmlns:ScriptNS0=""http://schemas.microsoft.com/BizTalk/2003/ScriptNS0"" xmlns:ScriptNS1=""http://schemas.microsoft.com/BizTalk/2003/ScriptNS1"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:MFMWorkItemUpdate"" />
  </xsl:template>
  <xsl:template match=""/s0:MFMWorkItemUpdate"">
    <ns0:ArrayOfudtt_Asset>
      <ns0:udtt_Asset>
        <xsl:variable name=""var:v1"" select=""ScriptNS0:VisionFMLookupConnectionString()"" />
        <xsl:variable name=""var:v2"" select=""ScriptNS1:DBLookup(0 , string(WI_AssetRef/text()) , string($var:v1) , &quot;[ops].[vMTFMAssets]&quot; , &quot;asst_ForeignSysId&quot;)"" />
        <xsl:variable name=""var:v3"" select=""ScriptNS1:DBValueExtract(string($var:v2) , &quot;asst_ForeignSysId&quot;)"" />
        <ns0:asst_ForeignSysId>
          <xsl:value-of select=""$var:v3"" />
        </ns0:asst_ForeignSysId>
      </ns0:udtt_Asset>
    </ns0:ArrayOfudtt_Asset>
    <xsl:variable name=""var:v4"" select=""ScriptNS1:DBLookupShutdown()"" />
  </xsl:template>
</xsl:stylesheet>";
        
        private const string _strArgList = @"<ExtensionObjects>
  <ExtensionObject Namespace=""http://schemas.microsoft.com/BizTalk/2003/ScriptNS0"" AssemblyName=""MFM.Lbg.Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=b52a4a519c43e251"" ClassName=""MFM.Lbg.Helper.Misc"" />
  <ExtensionObject Namespace=""http://schemas.microsoft.com/BizTalk/2003/ScriptNS1"" AssemblyName=""Microsoft.BizTalk.BaseFunctoids, Version=3.0.1.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35"" ClassName=""Microsoft.BizTalk.BaseFunctoids.FunctoidScripts"" />
</ExtensionObjects>";
        
        private const string _strSrcSchemasList0 = @"MFM.Lbg.Schemas.MFMWorkItemUpdate";
        
        private const global::MFM.Lbg.Schemas.MFMWorkItemUpdate _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"MFM.Lbg.Schemas.Add_Asset_UdttTableType_ops+ArrayOfudtt_Asset";
        
        private const global::MFM.Lbg.Schemas.Add_Asset_UdttTableType_ops.ArrayOfudtt_Asset _trgSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"MFM.Lbg.Schemas.MFMWorkItemUpdate";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"MFM.Lbg.Schemas.Add_Asset_UdttTableType_ops+ArrayOfudtt_Asset";
                return _TrgSchemas;
            }
        }
    }
}
