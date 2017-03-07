namespace MFM.Lbg.Orcs.Maps {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"MFM.Lbg.Schemas.SimpleEmailWorkflowFFS", typeof(global::MFM.Lbg.Schemas.SimpleEmailWorkflowFFS))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"MFM.Lbg.Schemas.SimpleEmailWorkFlowPop3Audit", typeof(global::MFM.Lbg.Schemas.SimpleEmailWorkFlowPop3Audit))]
    public sealed class map_getSimplePop3Audit : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 userCSharp ScriptNS0"" version=""1.0"" xmlns:s0=""http://MFM.Helpdesk.TrackerAlerts.Schema.SimpleEmailWorkflowFFS"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"" xmlns:ScriptNS0=""http://schemas.microsoft.com/BizTalk/2003/ScriptNS0"">
  <xsl:output omit-xml-declaration=""yes"" indent=""yes"" version=""1.0"" method=""xml"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:VfmSimpleWorkFlowEmail"" />
  </xsl:template>
  <xsl:template match=""/s0:VfmSimpleWorkFlowEmail"">
    <xsl:variable name=""var:v1"" select=""userCSharp:StringConcat(&quot;placeholder&quot;)"" />
    <xsl:variable name=""var:v2"" select=""userCSharp:DateCurrentDateTime()"" />
    <SimpleEmailWorkFlowPop3Audit>
      <Header>
        <From>
          <xsl:value-of select=""$var:v1"" />
        </From>
        <To>
          <xsl:value-of select=""$var:v1"" />
        </To>
        <RawHeaders>
          <xsl:value-of select=""$var:v1"" />
        </RawHeaders>
        <SentDt>
          <xsl:value-of select=""$var:v2"" />
        </SentDt>
        <Subject>
          <xsl:value-of select=""$var:v1"" />
        </Subject>
      </Header>
      <Body>
        <xsl:variable name=""var:v3"" select=""userCSharp:InitCumulativeConcat(0)"" />
        <xsl:for-each select=""/s0:VfmSimpleWorkFlowEmail/VfmSimpleWorkFlowEmailLine"">
          <xsl:variable name=""var:v4"" select=""ScriptNS0:StripFormatting(string(VfmSimpleWorkFlowEmailLine_Child1/text()))"" />
          <xsl:variable name=""var:v5"" select=""userCSharp:ConvertChr(&quot;13&quot;)"" />
          <xsl:variable name=""var:v6"" select=""userCSharp:ConvertChr(&quot;10&quot;)"" />
          <xsl:variable name=""var:v7"" select=""userCSharp:StringConcat(string($var:v5) , string($var:v6))"" />
          <xsl:variable name=""var:v8"" select=""userCSharp:StringConcat(string($var:v4) , string($var:v7))"" />
          <xsl:variable name=""var:v9"" select=""userCSharp:AddToCumulativeConcat(0,string($var:v8),&quot;1000&quot;)"" />
        </xsl:for-each>
        <xsl:variable name=""var:v10"" select=""userCSharp:GetCumulativeConcat(0)"" />
        <xsl:variable name=""var:v11"" select=""userCSharp:StringConcat(&quot;&lt;![CDATA[&quot; , string($var:v10) , &quot;]]&gt;&quot;)"" />
        <xsl:variable name=""var:v12"" select=""ScriptNS0:RemoveEncodedEntities(string($var:v11))"" />
        <RawBodyContent>
          <xsl:value-of select=""$var:v12"" />
        </RawBodyContent>
      </Body>
      <VisionData>
        <ValidSubject>
          <xsl:text>false</xsl:text>
        </ValidSubject>
        <Action>
          <xsl:value-of select=""$var:v1"" />
        </Action>
        <Ref>
          <xsl:value-of select=""$var:v1"" />
        </Ref>
        <Workflow>
          <xsl:value-of select=""$var:v1"" />
        </Workflow>
        <Id>
          <xsl:value-of select=""$var:v1"" />
        </Id>
        <Guid>
          <xsl:value-of select=""$var:v1"" />
        </Guid>
      </VisionData>
      <xsl:value-of select=""./text()"" />
    </SimpleEmailWorkFlowPop3Audit>
  </xsl:template>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp""><![CDATA[
public string InitCumulativeConcat(int index)
{
	if (index >= 0)
	{
		if (index >= myCumulativeConcatArray.Count)
		{
			int i = myCumulativeConcatArray.Count;
			for (; i<=index; i++)
			{
				myCumulativeConcatArray.Add("""");
			}
		}
		else
		{
			myCumulativeConcatArray[index] = """";
		}
	}
	return """";
}

public System.Collections.ArrayList myCumulativeConcatArray = new System.Collections.ArrayList();

public string AddToCumulativeConcat(int index, string val, string notused)
{
	if (index < 0 || index >= myCumulativeConcatArray.Count)
	{
		return """";
	}
	myCumulativeConcatArray[index] = (string)(myCumulativeConcatArray[index]) + val;
	return myCumulativeConcatArray[index].ToString();
}

public string GetCumulativeConcat(int index)
{
	if (index < 0 || index >= myCumulativeConcatArray.Count)
	{
		return """";
	}
	return myCumulativeConcatArray[index].ToString();
}

public string StringConcat(string param0)
{
   return param0;
}


public string DateCurrentDateTime()
{
	DateTime dt = DateTime.Now;
	string curdate = dt.ToString(""yyyy-MM-dd"", System.Globalization.CultureInfo.InvariantCulture);
	string curtime = dt.ToString(""T"", System.Globalization.CultureInfo.InvariantCulture);
	string retval = curdate + ""T"" + curtime;
	return retval;
}


public string StringConcat(string param0, string param1)
{
   return param0 + param1;
}


public string ConvertChr(string val)
{
	string retval = """";
	double d = 0;
	if (IsNumeric(val, ref d))
	{
		int v = (int) d;
		if (v >= 1 && v <= 127)
		{
			char c = (char)v;
			retval = c.ToString(System.Globalization.CultureInfo.InvariantCulture);
		}
	}
	return retval;
}


public string StringConcat(string param0, string param1, string param2)
{
   return param0 + param1 + param2;
}


public bool IsNumeric(string val)
{
	if (val == null)
	{
		return false;
	}
	double d = 0;
	return Double.TryParse(val, System.Globalization.NumberStyles.AllowThousands | System.Globalization.NumberStyles.Float, System.Globalization.CultureInfo.InvariantCulture, out d);
}

public bool IsNumeric(string val, ref double d)
{
	if (val == null)
	{
		return false;
	}
	return Double.TryParse(val, System.Globalization.NumberStyles.AllowThousands | System.Globalization.NumberStyles.Float, System.Globalization.CultureInfo.InvariantCulture, out d);
}


]]></msxsl:script>
</xsl:stylesheet>";
        
        private const string _strArgList = @"<ExtensionObjects>
  <ExtensionObject Namespace=""http://schemas.microsoft.com/BizTalk/2003/ScriptNS0"" AssemblyName=""MFM.Lbg.Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=b52a4a519c43e251"" ClassName=""MFM.Lbg.Helper.Misc"" />
</ExtensionObjects>";
        
        private const string _strSrcSchemasList0 = @"MFM.Lbg.Schemas.SimpleEmailWorkflowFFS";
        
        private const global::MFM.Lbg.Schemas.SimpleEmailWorkflowFFS _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"MFM.Lbg.Schemas.SimpleEmailWorkFlowPop3Audit";
        
        private const global::MFM.Lbg.Schemas.SimpleEmailWorkFlowPop3Audit _trgSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"MFM.Lbg.Schemas.SimpleEmailWorkflowFFS";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"MFM.Lbg.Schemas.SimpleEmailWorkFlowPop3Audit";
                return _TrgSchemas;
            }
        }
    }
}
