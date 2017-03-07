using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Xml;
using System.Web;
using System.IO;
using System.Data.SqlClient;

namespace HelperTester
{
    class Program
    {

        private static string GetConnString(string Server, string Database, String ApplicationName)
        {
            SqlConnectionStringBuilder cs = new SqlConnectionStringBuilder();
            cs.DataSource = Server;
            cs.InitialCatalog = Database;
            cs.IntegratedSecurity = true;
            cs.Pooling = false;
            cs.MultipleActiveResultSets = true;
            cs.ConnectTimeout = 720;
            cs.ApplicationName = ApplicationName;
            return cs.ToString();
        }


        static void Main(string[] args)
        {



            //Test SQl
            //MITIE-SQL5-02\MITIE_SQL5_02:55216 
            //MITIE-SQL5-02:55216/MITIE_SQL5_02
            //"Provider=SQLOLEDB;Database=MFM_HELPDESK;Integrated Security=SSPI;Server=MITIE-SQL7-01";

            //using (SqlConnection conn = new SqlConnection(GetConnString("MITIE-SQL5-02\\MITIE_SQL5_02", "MFM_Helpdesk", "MFM.Helpdesk.Distributor")))
            //{
            //    conn.Open();
            //}

            //SubjectParser();

            //testBst();

            //string input = @"""Cieslewicz, Pawel, Vodafone Ireland"" <Cieslewicz.Pawel@Vodafone.com>";
            string input = @"""Fitzgerald, Gerry, Vodafone Ireland (External)""	 gerry.fitzgerald@vodafone.com";
            input = EmailParser(input);
            //input = @"<Cieslewicz.Pawel@Vodafone.com>";
            //EmailParser(input);


        }
        private static string EmailParser(string input)
        {
            //"Cieslewicz, Pawel, Vodafone Ireland" <Cieslewicz.Pawel@Vodafone.com>
            MFM.Lbg.Helper.Misc Misc = new MFM.Lbg.Helper.Misc();
            string tmp = Misc.RemoveUnsupportedFilePathCharacters(input);
            return tmp;
        }

        //public static string RemoveUnsupportedFilePathCharacters(string input)
        //{
        //    //"[^"]*" - replace qualified email addresses in the form "Cieslewicz, Pawel, Vodafone Ireland"
        //    string pattern1 = @"""[^""]*""";
        //    Regex rgx = new Regex(pattern1, RegexOptions.Multiline | RegexOptions.IgnoreCase);
        //    input = rgx.Replace(input, "").Trim();
        //    return input.Replace("<", "").Replace(">", "").Replace("?", "").Replace(":", "").Replace("*", "").Replace("|", "").Replace(@"\", "").Replace(@"/", "");
        //}


        private static void SubjectParser()
        {
            MFM.Lbg.Helper.Misc Misc = new MFM.Lbg.Helper.Misc();
            MFM.Lbg.Helper.SimpleWorkflowRequest SimpleWorkflowRequest = new MFM.Lbg.Helper.SimpleWorkflowRequest();

            SimpleWorkflowRequest = Misc.ParseSimpleWorkflowSubject("Action:TrackCase Case:3365-3687187 Request:Accept ID:3687187 GUID:a50f6ae1-650e-4277-8292-47de72f5bba2");
        }

        private static void TestBodyParser()
        {
            string test = @"&lt;![CDATA[



v\:* {behavior:url(#default#VML);}
o\:* {behavior:url(#default#VML);}
w\:* {behavior:url(#default#VML);}
.shape {behavior:url(#default#VML);}
&lt;!--
/* Font Definitions */
@font-face
	{font-family:Calibri;
	panose-1:2 15 5 2 2 2 4 3 2 4;}
@font-face
	{font-family:Tahoma;
	panose-1:2 11 6 4 3 5 4 4 2 4;}
/* Style Definitions */
p.MsoNormal, li.MsoNormal, div.MsoNormal
	{margin:0cm;
	margin-bottom:.0001pt;
	font-size:10.0pt;

	mso-fareast-language:EN-US;}
@page WordSection1
	{size:612.0pt 792.0pt;
	margin:72.0pt 72.0pt 72.0pt 72.0pt;}
div.WordSection1
	{page:WordSection1;}
--&gt;








This is a html email
 
Tony Arrighi
Interface Solutions Architect
 
Mitie
35 Duchess Road, Rutherglen, Glasgow, Lanarkshire, G73 1AU, UK
T: +44 (0)141 278 5861 | M: +44 (0)7979 702388
 
www.mitie.com
 

 


















 
MITIE Group plc is registered in Scotland under company number SC19230 at 35 Duchess Road, Rutherglen, Glasgow, G73 1AU, UK
 




]]&gt;";
            MFM.Lbg.Helper.Misc Misc = new MFM.Lbg.Helper.Misc();
            Misc.CleanVariableSourcedBodyText(test);
        }

        private static void testBst()
        {
            MFM.Lbg.Helper.Misc Misc = new MFM.Lbg.Helper.Misc();

            DateTime input, output;

            // DT evaluated as BST 2014-10-02T13:39:00+01:00 - skips and passes back as +01 as no year 2014 specified - Ok
            // DT evaluated as BST 2015-10-02T13:39:00+01:00 - catches and forces +01:00 as is within 2015 bst dates - OK
            // DT evaluated as BST 2015-11-01T13:39:00+01:00 - incorrectly marked as bst as logged in bst window, corrects to +00:00 - ok
            // DT evaluated as BST 2015-04-01T13:39:00+01:00 - incorrectly marked as GMT as logged before bst window

            input = System.Convert.ToDateTime("2015-03-31T09:01:00Z");

            string u = Misc.AdjustForBst(input);


            //string extString = u.ToString("yyyy-MM-ddTHH:mm:sszzz");

        }

        private static void TestUpd()
        {
            MFM.Lbg.Helper.MaximoHelper Upd = new MFM.Lbg.Helper.MaximoHelper();
            string UpdMsg = Upd.CreateSoapEnvelopeForUpdate("LN7012676", "LSE", "2014-11-14 13:59:00.000", "2015-07-01 16:01:00.000");
            MFM.Lbg.Helper.MiAMIWorkorderUpdateResponse r = new MFM.Lbg.Helper.MiAMIWorkorderUpdateResponse();
            r = Upd.UpdateMaximoWorkOrder(UpdMsg);
        }

        private static void TestBulkLoader()
        {
            //Test helper bulk load
            XmlDocument data = new XmlDocument();
            data.Load(@"C:\Users\mcss-tarrighi-p\TFS2012\MFM Integration Apps Group\BizTalk2013\Beacon\MFM.Lbg.Interface\HelperTester\Test\out.xml");

            MFM.Lbg.Helper.HelpdeskSqlClient Loader = new MFM.Lbg.Helper.HelpdeskSqlClient();

            MFM.Lbg.Helper.Misc Misc = new MFM.Lbg.Helper.Misc();

            XmlDocument msg = new XmlDocument();
            msg = Misc.NotifyConstructMsg(data);
        }

        //private string ReplaceTag(string TagPattern, string HtmlText, string Replacement)
        //{
        //    Regex.Replace(HtmlText,String.Format(@"<{0}[^>*]>",TagPattern, delegate(Match TagMatch)
        //    {
        //        string c = TagMatch.
        //    }
        //    );
        //}

        static void DpRrFilename()
        {
            string myPath = @"\\uncserver\here\sub\myfile.xml";
            MFM.Lbg.Helper.Misc doIt = new MFM.Lbg.Helper.Misc();
            string result = doIt.RrFileName(myPath);
        }

        static void ParseWorlogs()
        {
            //Read Xml 

            XmlDocument msg = new XmlDocument();
            msg.Load(@"C:\Users\mcss-tarrighi-p\TFS2012\MFM Integration Apps Group\BizTalk2013\Beacon\MFM.Lbg.Interface\HelperTester\Test\TEST_MX4456660_INPRG.xml");


            XmlDocument result = new XmlDocument();
            MFM.Lbg.Helper.Misc doIt = new MFM.Lbg.Helper.Misc();
            result = doIt.GetCombinedWorkLogMsg(msg);

        }

        static void someregthing()
        {
            string r = @"AWAITING MATERLS, SE37, <table border='0' cellpadding='0' cellspacing='0' width='815'><colgroup><col width='815'></col></colgroup><tbody><tr height='21'>   <td class='xl270' height='21' style='height:15.75pt;width:611pt' width='815'>Waiting   on materials / consumables / parts causing a delay to service provision <span style='mso-spacerun:yes'>  </span>SE37</td> </tr></tbody></table><!-- RICH TEXT -->";
            const string RegexPattern = "<[Tt][Aa][Bb][Ll][Ee]>.*</[Tt][Aa][Bb][Ll][Ee]>";
            Regex.Replace(r, RegexPattern, delegate(Match tableHtml)
            {
                string m = tableHtml.ToString();
                return m;
            }
            );
        }

        static void TestNotifications()
        {
            System.Xml.XmlDocument xml = new System.Xml.XmlDocument();

            MFM.Lbg.Helper.Emailer Emailer = new MFM.Lbg.Helper.Emailer();
            bool RequestEmail = Emailer.RequestSendTransformedEmail("TEAM247", "tony.arrighi@mitie.com", "", "Test ME", xml);
        }
    }
}
