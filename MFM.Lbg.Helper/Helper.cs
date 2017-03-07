using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.XPath;
using System.Xml.Linq;
using System.Xml.Serialization;
using System.Web;
using System.Net;
using System.IO;
using System.Net.Mail;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Threading;

namespace MFM.Lbg.Helper
{
    [Serializable]
    public class Emailer
    {
        /// <summary>
        /// Simple plain text format email message
        /// Use for dumping whole xmldocument outer xml strings
        /// </summary>
        /// <param name="emailTo"></param>
        /// <param name="emailCc"></param>
        /// <param name="emailSubj"></param>
        /// <param name="emailBody"></param>
        /// <returns></returns>
        public bool RequestPlainTextEmail(
            String emailTo
            , String emailCc
            , String emailSubj
            , String emailBody)
        {
            bool result = false; 
            String xslFilename = string.Empty;
            String emailServer = "mailrelay.mitie.com";
            Int16 retries = 6;
            Int32 interval = 10;
            
            try
            {
                for (int i = 0; i < retries; i++)
                {

                    try
                    {
                        result = SendPlainTextEmail(retries, interval,emailTo,"",emailSubj,emailServer,emailBody);
                        if(result){break;}
                    }
                    catch (Exception e)
                    {
                        EventLog.WriteEntry("MFM.Helpdesk.Distributor", String.Format("Failed sending helper class email, message will retry; {0}\r\n\r\nConnecting to SMTP @ - check server address is correct adn available for SMTP on port 25.{1}\r\nXSLT Requested{2} - check path is correct.\r\n\r\n{3}", e.Message,emailServer,xslFilename, e.StackTrace), EventLogEntryType.Warning);
                    }
                    finally
                    {
                        System.Threading.Thread.Sleep(interval * 1000);
                    }

                }

                if (!result == true) { throw new Exception("Error sending helper class email"); }
            }
            catch (Exception e)
            {
                result = false;
                EventLog.WriteEntry("MFM.Helpdesk.Distributor", String.Format("{0}, message is suspended.See previous warnings in event log.\r\n\r\nTo: {1} (Type: {2})\r\nSubject: {3}\r\n\r\n{4}", e.Message,emailTo,"",emailSubj, e.StackTrace), EventLogEntryType.Error);
            }
            return result;

        }
        
        /// <summary>
        /// Requests that a submitted xmldocument be transformed
        /// by a xsl translation and set at html body on an
        /// email
        /// </summary>
        /// <param name="xslSwitch"></param>
        /// <param name="emailTo"></param>
        /// <param name="emailCc"></param>
        /// <param name="emailSubj"></param>
        /// <param name="bizMessage"></param>
        /// <returns></returns>
        public bool RequestSendTransformedEmail(
            String xslSwitch
            , String emailTo
            , String emailCc
            , String emailSubj
            , XmlDocument bizMessage)
        {
            bool result = false; 
            String xslFilename = string.Empty;
            String emailServer = "mailrelay.mitie.com";
            Int16 retries = 6;
            Int32 interval = 10;
            switch (xslSwitch)
            {
                case "DIST":
                    xslFilename = "Cafm_notify_distributed.xsl";
                    break;
                case "TEAM247":
                    xslFilename = "Cafm_notify_VisionFM_TL.xsl";
                    break;
                case "TEAMSUPP":
                     xslFilename = "Cafm_notify_VisionFM.xsl";
                     break;
                case "TFM":
                    xslFilename = "Cafm_notify_tfm.xsl";
                    break;
                case "DISTSENT":
                    xslFilename = "Cafm_notify_distributed_v2.xsl";
                    break;
                default:
                    break;                    
            }


            try
            {
                for (int i = 0; i < retries; i++)
                {

                    try
                    {
                        result = SendDynamicTransformedEmail(xslFilename, retries, interval, emailTo, emailCc, emailSubj, emailServer, bizMessage);
                        if(result){break;}
                    }
                    catch (Exception e)
                    {
                        EventLog.WriteEntry("MFM.Helpdesk.Distributor", String.Format("Failed sending helper class email, message will retry; {0}\r\n\r\nConnecting to SMTP @ - check server address is correct adn available for SMTP on port 25.{1}\r\nXSLT Requested{2} - check path is correct.\r\n\r\n{3}", e.Message,emailServer,xslFilename, e.StackTrace), EventLogEntryType.Warning);
                    }
                    finally
                    {
                        System.Threading.Thread.Sleep(interval * 1000);
                    }

                }

                if (!result == true) { throw new Exception("Error sending helper class email"); }
            }
            catch (Exception e)
            {
                result = false;
                EventLog.WriteEntry("MFM.Helpdesk.Distributor", String.Format("{0}, message is suspended.See previous warnings in event log.\r\n\r\nTo: {1} (Type: {2})\r\nSubject: {3}\r\n\r\n{4}", e.Message,emailTo,xslSwitch,emailSubj, e.StackTrace), EventLogEntryType.Error);
            }
            return result;

        }

        /// <summary>
        /// Transform XML File from path with partner XSL
        /// </summary>
        /// <param name="thisXmlDataPath"></param>
        /// <param name="thisXsltemplatepath"></param>
        /// <returns></returns>
        private static String GetHtmlTemplate(String thisXmlDataPath,String thisXsltemplatepath) 
        {
            System.IO.StringWriter sw = new System.IO.StringWriter();
            System.Xml.Xsl.XslCompiledTransform XsltTransformation = new System.Xml.Xsl.XslCompiledTransform(true);
            System.Xml.Xsl.XsltArgumentList XsltArgumentList = new System.Xml.Xsl.XsltArgumentList();
            XsltTransformation.Load(thisXsltemplatepath);
            XsltTransformation.Transform(thisXmlDataPath, XsltArgumentList, sw);
            return sw.ToString();

        }
       
        /// <summary>
        /// Transform XML document with partner XSL
        /// </summary>
        /// <param name="Xml"></param>
        /// <param name="thisXsltemplatepath"></param>
        /// <returns></returns>
        private static String GetHtmlTemplate( XmlDocument Xml, String thisXsltemplatepath)
        {
            System.IO.StringWriter sw = new System.IO.StringWriter();
            System.Xml.Xsl.XslCompiledTransform XsltTransformation = new System.Xml.Xsl.XslCompiledTransform(true);
            System.Xml.Xsl.XsltArgumentList XsltArgumentList = new System.Xml.Xsl.XsltArgumentList();

            XsltTransformation.Load(thisXsltemplatepath);
            XsltTransformation.Transform(Xml, XsltArgumentList, sw);
            return sw.ToString();
        }
        
        /// <summary>
        /// Replace dynamic send ports to transmit an email
        /// using a XSLT transformation
        /// </summary>
        /// <returns></returns>
        private static bool SendDynamicTransformedEmail(String xslFilename, Int16 retries, Int32 interval
            , String emailTo, String emailCc
            , String emailSubj, String toSmtp, XmlDocument bizMessage)
        {
            String DfsRoot = @"\\mitiegrp.internal.mitie.co.uk\AppData\MCS\Interfaces";
            String AppSubPath = @"MFM_LBG_CAFM\Xsl";
            String xslTemplatePath = String.Empty;
            String EmailHtml = String.Empty;
            Boolean isHtml = false;

            //Recognised and valid XSL switch was provided, so map XSL file
            if  (!String.IsNullOrEmpty(xslFilename))
            {
                
                switch (System.Net.Dns.GetHostName().ToLower())
                {
                    case "miti-msl-vm-41":
                    case "mitie-com-105":
                    case "mitie-com-106":
                    case "miti-w-int-0107":
                        xslTemplatePath = String.Format(@"{0}\{1}\{2}\{3}", DfsRoot, "LIVE", AppSubPath,xslFilename);
                        break;
                    case "miti-msl-vm-40":
                    case "miti-msl-vm-52":
                        xslTemplatePath = String.Format(@"{0}\{1}\{2}\{3}", DfsRoot, "QA", AppSubPath, xslFilename);
                        break;
                    default:
                        xslTemplatePath = String.Format(@"{0}\{1}\{2}\{3}", DfsRoot, "DEV", AppSubPath, xslFilename);
                        break;
                }


                EmailHtml = GetHtmlTemplate(bizMessage, xslTemplatePath);
                isHtml = true;

            }

            System.Net.Mail.SmtpClient thisSmtpServer = new System.Net.Mail.SmtpClient();
            System.Net.Mail.MailMessage mail = new System.Net.Mail.MailMessage();
            thisSmtpServer.Port = 25;
            thisSmtpServer.Host = toSmtp;
            mail.From = new MailAddress("no.reply@mitie.com");

            //More than one To address?
            string[] EmailToArray = emailTo.Split(';');
            foreach (string to in EmailToArray)
            {
                mail.To.Add(to);
            }
            if(!String.IsNullOrEmpty(emailCc))
            {
                string[] EmailCcArray = emailCc.Split(';');
                foreach (string cc in EmailCcArray)
                {
                    mail.CC.Add(cc);
                } 

            }           
            mail.Subject = emailSubj;
            mail.Body = EmailHtml;
            mail.IsBodyHtml = isHtml;
            
            //wrap retry here
            //for(
            thisSmtpServer.Send(mail);

            return true;
        }
    
        /// <summary>
        /// Transmit plain text email
        /// </summary>
        /// <param name="retries"></param>
        /// <param name="interval"></param>
        /// <param name="emailTo"></param>
        /// <param name="emailCc"></param>
        /// <param name="emailSubj"></param>
        /// <param name="toSmtp"></param>
        /// <param name="msgBody"></param>
        /// <returns></returns>
        private static bool SendPlainTextEmail(Int16 retries, Int32 interval
                , String emailTo, String emailCc
                , String emailSubj, String toSmtp, String msgBody)
            {
                Boolean isHtml = false;
                    
                System.Net.Mail.SmtpClient thisSmtpServer = new System.Net.Mail.SmtpClient();
                System.Net.Mail.MailMessage mail = new System.Net.Mail.MailMessage();
                thisSmtpServer.Port = 25;
                thisSmtpServer.Host = toSmtp;
                mail.From = new MailAddress("no.reply@mitie.com");

                //More than one To address?
                string[] EmailToArray = emailTo.Split(';');
                foreach (string to in EmailToArray)
                {
                    mail.To.Add(to);
                }
                if(!String.IsNullOrEmpty(emailCc))
                {
                    string[] EmailCcArray = emailCc.Split(';');
                    foreach (string cc in EmailCcArray)
                    {
                        mail.CC.Add(cc);
                    } 

                }           
                mail.Subject = emailSubj;
                mail.Body = msgBody;
                mail.IsBodyHtml = isHtml;
            
                //wrap retry here
                //for(
                thisSmtpServer.Send(mail);

                return true;
            }
        
    
    
    }

    [Serializable]
    public class HelpdeskSqlClient
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

        /// <summary>
        /// Indicate if BizTalk production environment
        /// </summary>
        /// <returns></returns>
        private static Boolean EnvChecker()
        {
            string host = System.Net.Dns.GetHostName().ToLower();
            Boolean useProd = false;
            if (host == "miti-msl-vm-41" || host == "MITI-W-INT-0107" || host == "mitie-com-106" || host == "mitie-com-105")
            {
                useProd = true;
            }
            return useProd;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private static String SqlClientVisionFM()
        {
            if (EnvChecker())
            {
                return GetConnString("mitie-sql7-01", "MFM_Helpdesk", "MFM.Helpdesk.Distributor");
            }
            else
            {
                switch (System.Net.Dns.GetHostName().ToLower())
                {
                    case "csvmg07-sv":
                        return GetConnString("mitie-com-19", "MFM_Helpdesk_Rad", "MFM.Helpdesk.Distributor");
                    default:
                        return GetConnString("mitie-com-19", "MFM_HELPDESK_SUPPORT", "MFM.Helpdesk.Distributor");
                }

            }
        }

        
        public Int32 FinanceCaseBulkLoad(XmlDocument xml, string source)
        {
            Int32 rvOut = -1;

            String procedureName = "[dbo].[biz_import_standard_feed]";
            SqlParameter r = new SqlParameter("@return", SqlDbType.Int);
            r.Direction = ParameterDirection.ReturnValue;
            SqlParameter tab = new SqlParameter("@tabin", SqlDbType.Structured);
            tab.Direction = ParameterDirection.Input;
            DataTable paramTab = FinanceCasesDt(xml);
            tab.Value = paramTab;
            DataTable returnedRows = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(SqlClientVisionFM()))
                {
                    conn.Open();
                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = conn;
                        command.CommandType = CommandType.StoredProcedure;
                        command.CommandText = procedureName;
                        command.CommandTimeout = 900;
                        command.Parameters.Add(r);
                        command.Parameters.Add(tab);

                        SqlDataReader rdr = command.ExecuteReader();
                        
                        String thisImport = String.Format("File: {3}\r\nLoad: {0}, Items: {1}\r\nTop Row...\r\n{2}", paramTab.Rows[0].ItemArray[0].ToString(), paramTab.Rows.Count.ToString(), "...some stuff about fails...", source);

                        if (Convert.ToInt32(command.Parameters["@return"].Value) == 0)
                        {
                            rvOut = 0;
                            //EventLog.WriteEntry("MFM.Helpdesk.Distributor", String.Format("Feed load complete...\r\n{0}", thisImport), EventLogEntryType.Information);
                        }
                        else
                        {
                            rvOut = Convert.ToInt32(command.Parameters["@return"].Value);
                            EventLog.WriteEntry("MFM.Helpdesk.Distributor", String.Format("Stored procedure {2} returned an error loading {4}, called by method FinanceCaseBulkLoad returned < 0.\r\nReturnValue: {0}\r\nError: {1}\r\nConn: {3}", command.Parameters["@return"].Value.ToString(), "", procedureName, SqlClientVisionFM(), source), EventLogEntryType.Error);
                            switch (rvOut)
                            {
                                case -1:
                                    EventLog.WriteEntry("MFM.Helpdesk.Distributor", String.Format("No rows were inserted into the staging table, please investigate. {0}", source), EventLogEntryType.Error);
                                    break;
                                case -2:
                                    EventLog.WriteEntry("MFM.Helpdesk.Distributor", String.Format("Rows with bad property codes were identified, check visionfm. {0}", source), EventLogEntryType.Error);
                                    returnedRows.Load(rdr);
                                    break;
                                default:
                                    EventLog.WriteEntry("MFM.Helpdesk.Distributor", String.Format("No additional information is available. {0}", source), EventLogEntryType.Error);
                                    break;
                            }

                        }

                    }
                }
            }
            catch (SqlException esql)
            {
                EventLog.WriteEntry("MFM.Helpdesk.Distributor", String.Format("SQL Client {0} returned an error loading {4}, Error below.\r\n\r\nError: {1}\r\n\r\nStack: {2} \r\nConn: {3}", procedureName, esql.Message, esql.StackTrace, SqlClientVisionFM(), source), EventLogEntryType.Error);
                rvOut = -3;
            }
            catch (Exception e)
            {
                EventLog.WriteEntry("MFM.Helpdesk.Distributor", String.Format("SQL Helper class {0} returned an error, Error below.\r\n\r\nError: {1}\r\n\r\nStack: {2}", "FinanceCaseBulkLoad", e.Message, e.StackTrace), EventLogEntryType.Error);
                rvOut = -4;
            }
            finally
            {
                sendFinanceEmailAlert(source, returnedRows, rvOut);
            }
            

            return rvOut;
        }

        private static void sendFinanceEmailAlert(string source, DataTable returnedRows, Int32 rvOut)
        {
            //do some stuff to send an email and attach failed rows.
            //set subject
            String msg = string.Empty;
            switch (rvOut)
            {
                case 0:
                    msg = String.Format("Load status: {0}\r\nFile: {1}", "Success", source);
                    break;
                case -1:
                    msg = String.Format("Load status: {0}\r\nFile: {1}", "Fail", source);
                    break;
                case -2:
                    msg = String.Format("Load status: {0}\r\nFile: {1}", "Partial Fail", source);
                    break;
                case -3:
                    msg = String.Format("Load status: {0}\r\nFile: {1}", "Complete SQL Fail", source);
                    break;
                case -4:
                    msg = String.Format("Load status: {0}\r\nFile: {1}", "Complete Load Fail", source);
                    break;
                default:
                    msg = String.Format("Load status: {0}\r\nFile: {1}", "Fail with unknown status", source);
                    break;
            }

            String bodyRows = string.Empty;
            if (rvOut == -2)
            {
                StringBuilder sb = new StringBuilder();
                foreach (DataRow r in returnedRows.Rows)
                {
                    sb.AppendFormat("\r\n{0},{1},{2},{3},{4},{5}", r.ItemArray[0].ToString(), r.ItemArray[1].ToString(), r.ItemArray[2].ToString(), r.ItemArray[14].ToString(), r.ItemArray[15].ToString(), Convert.ToDateTime(r.ItemArray[21].ToString()).ToString("yyyyMMdd"));
                }
                bodyRows = sb.ToString();
            }

            String EmailBody = string.Empty;
            EmailBody = msg + bodyRows;
            string[] split = source.Split('\\');
            String EmailSubject = String.Format("Finance case load {0}", split.ElementAt(split.Length - 1));

            Emailer Emailer = new Emailer();

            MFM.Lbg.Helper.Misc misc = new MFM.Lbg.Helper.Misc();
            string financeEmailTo = misc.GetFinanceMailbox();
            Emailer.RequestPlainTextEmail(financeEmailTo, "", EmailSubject, EmailBody);
        }

        private static DataTable FinanceCasesDt(XmlDocument xml)
        {
            DataTable DT = GetBulkLoadTable();
            //Shred Xml to Datatable
            XmlNamespaceManager oManager = new XmlNamespaceManager(new NameTable());
            oManager.AddNamespace("ns0", "http://schemas.microsoft.com/Sql/2008/05/TypedProcedures/dbo");
            oManager.AddNamespace("ns3", "http://schemas.microsoft.com/Sql/2008/05/Types/TableTypes/dbo");

            XmlNodeList casesNodeList = xml.SelectNodes(@"/ns0:biz_import_standard_feed/ns0:tabin/ns3:biz_Standard_Feed", oManager);
            foreach (XmlNode finCase in casesNodeList)
            {
                DataRow myRow = DT.NewRow();
                myRow[0] = finCase.SelectSingleNode("ns3:v1", oManager).InnerXml.ToString();
                myRow[1] = finCase.SelectSingleNode("ns3:v2", oManager).InnerXml.ToString();
                myRow[2] = finCase.SelectSingleNode("ns3:v3", oManager).InnerXml.ToString();
                myRow[14] = System.Convert.ToDecimal(finCase.SelectSingleNode("ns3:m1", oManager).InnerXml.ToString());

                try
                {
                    myRow[15] = System.Convert.ToDecimal(finCase.SelectSingleNode("ns3:m2", oManager).InnerXml.ToString());
                }
                catch
                {
                    myRow[15] = DBNull.Value;
                }
                DateTime fileDateFormat = System.Convert.ToDateTime(finCase.SelectSingleNode("ns3:d1", oManager).InnerXml.ToString());
                myRow[21] = fileDateFormat;

                DT.Rows.Add(myRow);
            }

            return DT;
        }

        /// <summary>
        /// BulkLoad datatable for structured data procedure input
        /// </summary>
        /// <returns></returns>
        public static DataTable GetBulkLoadTable()
        {
            DataTable BulkLoadTable = new DataTable();
            BulkLoadTable.Columns.Add(new DataColumn("v1", typeof(System.String))); //0
            BulkLoadTable.Columns.Add(new DataColumn("v2", typeof(System.String))); //1
            BulkLoadTable.Columns.Add(new DataColumn("v3", typeof(System.String))); //2
            BulkLoadTable.Columns.Add(new DataColumn("v4", typeof(System.String)));
            BulkLoadTable.Columns.Add(new DataColumn("v5", typeof(System.String)));
            BulkLoadTable.Columns.Add(new DataColumn("v6", typeof(System.String)));
            BulkLoadTable.Columns.Add(new DataColumn("v7", typeof(System.String)));
            BulkLoadTable.Columns.Add(new DataColumn("i1", typeof(System.Int32))); //7
            BulkLoadTable.Columns.Add(new DataColumn("i2", typeof(System.Int32)));
            BulkLoadTable.Columns.Add(new DataColumn("i3", typeof(System.Int32)));
            BulkLoadTable.Columns.Add(new DataColumn("i4", typeof(System.Int32)));
            BulkLoadTable.Columns.Add(new DataColumn("i5", typeof(System.Int32)));
            BulkLoadTable.Columns.Add(new DataColumn("i6", typeof(System.Int32)));
            BulkLoadTable.Columns.Add(new DataColumn("i7", typeof(System.Int32)));
            BulkLoadTable.Columns.Add(new DataColumn("m1", typeof(System.Decimal))); //14
            BulkLoadTable.Columns.Add(new DataColumn("m2", typeof(System.Decimal))); //15
            BulkLoadTable.Columns[15].AllowDBNull = true;
            BulkLoadTable.Columns.Add(new DataColumn("m3", typeof(System.Decimal)));
            BulkLoadTable.Columns.Add(new DataColumn("m4", typeof(System.Decimal)));
            BulkLoadTable.Columns.Add(new DataColumn("m5", typeof(System.Decimal)));
            BulkLoadTable.Columns.Add(new DataColumn("m6", typeof(System.Decimal)));
            BulkLoadTable.Columns.Add(new DataColumn("m7", typeof(System.Decimal)));
            BulkLoadTable.Columns.Add(new DataColumn("d1", typeof(System.DateTime))); //21
            BulkLoadTable.Columns.Add(new DataColumn("d2", typeof(System.DateTime)));
            BulkLoadTable.Columns.Add(new DataColumn("d3", typeof(System.DateTime)));
            BulkLoadTable.Columns.Add(new DataColumn("d4", typeof(System.DateTime)));
            BulkLoadTable.Columns.Add(new DataColumn("d5", typeof(System.DateTime)));
            BulkLoadTable.Columns.Add(new DataColumn("d6", typeof(System.DateTime)));
            BulkLoadTable.Columns.Add(new DataColumn("d7", typeof(System.DateTime)));
            return BulkLoadTable;
        }
        
        public bool WorklogsHaveProcessed(XmlDocument xml)
        {
            bool result = false;
            StringBuilder sb = new StringBuilder();
            string procedureName = "dbo.biz_Global_Load_Workogs";

            SqlParameter data = new SqlParameter("@xml", SqlDbType.Xml);
            SqlParameter msg = new SqlParameter("@msg", SqlDbType.VarChar);
            SqlParameter r = new SqlParameter("@return", SqlDbType.Int);
            r.Direction = ParameterDirection.ReturnValue;
            msg.Direction = ParameterDirection.Output;
            data.Direction = ParameterDirection.Input;

            msg.Size = 500;
            data.Value = xml.OuterXml.ToString();

            try
            {
                using (SqlConnection conn = new SqlConnection(SqlClientVisionFM()))
                {
                    conn.Open();
                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = conn;
                        command.CommandType = CommandType.StoredProcedure;
                        command.CommandText = procedureName;
                        command.CommandTimeout = 300;
                        command.Parameters.Add(r);
                        command.Parameters.Add(msg);
                        command.Parameters.Add(data);

                        command.ExecuteNonQuery();

                        if (Convert.ToInt32(command.Parameters["@return"].Value) == 0)
                        {
                            result = true;
                            sb.AppendLine(String.Format("Worklogs Loaded: {0}", result.ToString()));
                        }
                        else
                        {
                            EventLog.WriteEntry("MFM.Helpdesk.Distributor", String.Format("Stored procedure {2} returned an error, called by method WorklogsHaveProcessed returned false.\r\nReturnValue: {0}\r\nError: {1}\r\nConn: {3}", command.Parameters["@return"].Value.ToString(), command.Parameters["@msg"].Value.ToString(), procedureName, SqlClientVisionFM()), EventLogEntryType.Error);
                        }
                    }
                }

            }
            catch (SqlException esql)
            {
                EventLog.WriteEntry("MFM.Helpdesk.Distributor", String.Format("SQL Client {0} returned an error, Error below.\r\n\r\nError: {1}\r\n\r\nStack: {2} \r\nConn: {3}", procedureName, esql.Message,esql.StackTrace, SqlClientVisionFM()), EventLogEntryType.Error);
            }
                      

            return result;
        }


        public bool LoadCommunicationRequest(XmlDocument xml)
        {
            bool result = false;
            StringBuilder sb = new StringBuilder();
            string procedureName = "[dbo].[biz_Global_RT_WorkLog]";

            SqlParameter data = new SqlParameter("@xml", SqlDbType.Xml);
            SqlParameter msg = new SqlParameter("@msg", SqlDbType.VarChar);
            SqlParameter r = new SqlParameter("@return", SqlDbType.Int);
            r.Direction = ParameterDirection.ReturnValue;
            msg.Direction = ParameterDirection.Output;
            data.Direction = ParameterDirection.Input;

            msg.Size = 500;
            data.Value = xml.OuterXml.ToString();

            try
            {
                using (SqlConnection conn = new SqlConnection(SqlClientVisionFM()))
                {
                    conn.Open();
                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = conn;
                        command.CommandType = CommandType.StoredProcedure;
                        command.CommandText = procedureName;
                        command.CommandTimeout = 300;
                        command.Parameters.Add(r);
                        command.Parameters.Add(msg);
                        command.Parameters.Add(data);

                        command.ExecuteNonQuery();

                        if (Convert.ToInt32(command.Parameters["@return"].Value) == 0)
                        {
                            result = true;
                            sb.AppendLine(String.Format("Worklog Loaded: {0}", result.ToString()));
                        }
                        else
                        {
                            EventLog.WriteEntry("MFM.Helpdesk.Distributor", String.Format("Stored procedure {2} returned an error, called by method LoadCommunicationRequest returned false.\r\nReturnValue: {0}\r\nError: {1}\r\nConn: {3}", command.Parameters["@return"].Value.ToString(), command.Parameters["@msg"].Value.ToString(), procedureName, SqlClientVisionFM()), EventLogEntryType.Error);
                        }
                    }
                }

            }
            catch (SqlException esql)
            {
                EventLog.WriteEntry("MFM.Helpdesk.Distributor", String.Format("SQL Client {0} returned an error, Error below.\r\n\r\nError: {1}\r\n\r\nStack: {2} \r\nConn: {3}", procedureName, esql.Message, esql.StackTrace, SqlClientVisionFM()), EventLogEntryType.Error);
            }


            return result;
        }

        public Int32 LoadSimpleWorkflowRequest(XmlDocument xml)
        {
            Int32 result = -1;
            StringBuilder sb = new StringBuilder();
            string procedureName = "[ops].[Biz_AddSimpleWorkflowRequest]";

            SqlParameter data = new SqlParameter("@xml", SqlDbType.Xml);
            SqlParameter msg = new SqlParameter("@msg", SqlDbType.NVarChar);
            SqlParameter r = new SqlParameter("@return", SqlDbType.Int);
            r.Direction = ParameterDirection.ReturnValue;
            msg.Direction = ParameterDirection.Output;
            data.Direction = ParameterDirection.Input;

            msg.Size = 500;
            data.Value = xml.OuterXml.ToString();

            try
            {
                using (SqlConnection conn = new SqlConnection(SqlClientVisionFM()))
                {
                    conn.Open();
                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = conn;
                        command.CommandType = CommandType.StoredProcedure;
                        command.CommandText = procedureName;
                        command.CommandTimeout = 300;
                        command.Parameters.Add(r);
                        command.Parameters.Add(msg);
                        command.Parameters.Add(data);

                        command.ExecuteNonQuery();
                        result = Convert.ToInt32(command.Parameters["@return"].Value);
                        if (result == 0)
                        {
                            sb.AppendLine(String.Format("SimpleWorkflowRequest Loaded: {0}", result.ToString()));
                        }
                        else
                        {
                            EventLog.WriteEntry("MFM.Helpdesk.Distributor", String.Format("Stored procedure {2} returned an error, called by method LoadSimpleWorkflowRequest returned false.\r\nReturnValue: {0}\r\nError: {1}\r\nConn: {3}", command.Parameters["@return"].Value.ToString(), command.Parameters["@msg"].Value.ToString(), procedureName, SqlClientVisionFM()), EventLogEntryType.Error);
                        }
                    }
                }

            }
            catch (SqlException esql)
            {
                EventLog.WriteEntry("MFM.Helpdesk.Distributor", String.Format("SQL Client {0} returned an error, Error below.\r\n\r\nError: {1}\r\n\r\nStack: {2} \r\nConn: {3}", procedureName, esql.Message, esql.StackTrace, SqlClientVisionFM()), EventLogEntryType.Error);
                result = -100; // SQL Excception
            }
            catch (Exception ex)
            {
                EventLog.WriteEntry("MFM.Helpdesk.Distributor", String.Format("The Helper Class LoadSimpleWorkflowRequest returned a non-resumable error, Error below.\r\n\r\nError: {0}\r\n\r\nStack: {1} ", ex.Message, ex.StackTrace), EventLogEntryType.Error);
                result = -200; // Non-SQL Excception
            }

            return result;
        }
    }
    
    [Serializable]
    public class MiAMIWorkorderEnquiryResult
    {
        public Boolean ClientRefExists;
        public Boolean MiAMIRefExists;
        public Int32 NumberOfResults;
        public string MTFMClientRef;
        public string MiAMIWOWonum;
        public string MIAMIWOCurrentStatus;
        public string MiAMIWOSiteId;
    }

    [Serializable]
    public class MiAMIWorkorderUpdateResponse
    {
        public bool complete;
        public string errormessage;
        
    }

    [Serializable]
    public class MaximoHelper
    {
        public string GetMiamiFriendlyDateTimeString(string dt)
        {
            return dt;
        }

        public MiAMIWorkorderUpdateResponse UpdateMaximoWorkOrder(String upd)
        {   
            MiAMIWorkorderUpdateResponse result = new MiAMIWorkorderUpdateResponse();

            try
            {
                string _url = GetMaximoUrl();
                XmlDocument soapEnvelopeXml = new XmlDocument();
                soapEnvelopeXml.LoadXml(upd);   // = CreateSoapEnvelopeForUpdate(upd);

                if (soapEnvelopeXml != null)
                {
                    //EventLog.WriteEntry("MFM.Helpdesk.Distributor", soapEnvelopeXml.OuterXml, EventLogEntryType.Information);
                    HttpWebRequest webRequest = CreateWebRequest(_url, "urn:processDocument");
                    InsertSoapEnvelopeIntoWebRequest(soapEnvelopeXml, webRequest);

                    IAsyncResult asyncResult = webRequest.BeginGetResponse(null, null);

                    asyncResult.AsyncWaitHandle.WaitOne();

                    XmlDocument soapResult = new XmlDocument();

                    using (WebResponse webResponse = webRequest.EndGetResponse(asyncResult))
                    {
                        using (StreamReader rd = new StreamReader(webResponse.GetResponseStream()))
                        {
                            soapResult.LoadXml(rd.ReadToEnd());
                        }

                        if (soapResult != null)
                        {
                            result.complete = true;
                        }
                        else
                        {
                            result.complete = false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.EventLog.WriteEntry("MFM.Helpdesk.Distributor", string.Format("Failed to update maximo work order. Exception Message: {0} ", ex.Message), System.Diagnostics.EventLogEntryType.Error);
            }

            return result;
        }
        
        public MiAMIWorkorderEnquiryResult GetMaximoWorkOrder(string MtfmClientRef)
        {
            //System.Diagnostics.EventLog.WriteEntry("MFM.Helpdesk.Distributor", "Started " + MtfmClientRef, System.Diagnostics.EventLogEntryType.Warning);
            MiAMIWorkorderEnquiryResult result = new MiAMIWorkorderEnquiryResult();

            try
            {
                string _url = GetMaximoUrl();
                XmlDocument soapEnvelopeXml = null;
                soapEnvelopeXml = CreateSoapEnvelope(MtfmClientRef);

                if (soapEnvelopeXml != null)
                {
                    HttpWebRequest webRequest = CreateWebRequest(_url, "urn:processDocument");
                    InsertSoapEnvelopeIntoWebRequest(soapEnvelopeXml, webRequest);

                    IAsyncResult asyncResult = webRequest.BeginGetResponse(null, null);

                    asyncResult.AsyncWaitHandle.WaitOne();

                    XmlDocument soapResult = new XmlDocument();

                    using (WebResponse webResponse = webRequest.EndGetResponse(asyncResult))
                    {
                        using (StreamReader rd = new StreamReader(webResponse.GetResponseStream()))
                        {
                            soapResult.LoadXml(rd.ReadToEnd());
                        }

                        if (soapResult != null)
                        {
                            result = GetResultFromXml(soapResult);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.EventLog.WriteEntry("MFM.Helpdesk.Distributor", string.Format("Failed to get maximo work order. Exception Message: {0} ", ex.Message), System.Diagnostics.EventLogEntryType.Error);
            }

            return result;
        }

        private MiAMIWorkorderEnquiryResult GetResultFromXml(XmlDocument soapResult)
        {
            //System.Diagnostics.EventLog.WriteEntry("MFM.Helpdesk.Distributor", soapResult.OuterXml.Substring(0,32750), System.Diagnostics.EventLogEntryType.Warning);
            MiAMIWorkorderEnquiryResult result = new MiAMIWorkorderEnquiryResult();

            if (soapResult != null)
            {
                //result.WorkOrder = new MaximoWorkOrder();

                XmlNamespaceManager nsmgr = new XmlNamespaceManager(soapResult.NameTable);
                nsmgr.AddNamespace("SOAP-ENV", "http://schemas.xmlsoap.org/soap/envelope/");
                nsmgr.AddNamespace("xsi", "http://www.w3.org/2001/XMLSchema-instance");
                nsmgr.AddNamespace("", "http://www.ibm.com/maximo");

                XmlNodeList nodeCount = soapResult.SelectNodes("//*[local-name()='WORKORDER' and namespace-uri()='http://www.ibm.com/maximo']", nsmgr);

                result.NumberOfResults = nodeCount.Count;

                if (result.NumberOfResults == 1)
                {
                    result.ClientRefExists = true;

                    XmlNode node = soapResult.SelectSingleNode("//*[local-name()='WONUM' and namespace-uri()='http://www.ibm.com/maximo']", nsmgr);

                    if (node != null)
                    {
                        result.MiAMIWOWonum = node.InnerText;
                        //System.Diagnostics.EventLog.WriteEntry("MFM.Helpdesk.Distributor", result.MiAMIWOWonum, System.Diagnostics.EventLogEntryType.Warning);
                    }

                    node = soapResult.SelectSingleNode("//*[local-name()='SITEID' and namespace-uri()='http://www.ibm.com/maximo']", nsmgr);

                    if (node != null)
                    {
                        result.MiAMIWOSiteId = node.InnerText;
                        //System.Diagnostics.EventLog.WriteEntry("MFM.Helpdesk.Distributor", result.MiAMIWOSiteId, System.Diagnostics.EventLogEntryType.Warning);
                    }

                    node = soapResult.SelectSingleNode("//*[local-name()='MTFMCLIENTREF' and namespace-uri()='http://www.ibm.com/maximo']", nsmgr);

                    if (node != null)
                    {
                        result.MTFMClientRef = node.InnerText;
                        //System.Diagnostics.EventLog.WriteEntry("MFM.Helpdesk.Distributor", result.MTFMClientRef, System.Diagnostics.EventLogEntryType.Warning);
                    }

                    node = soapResult.SelectSingleNode("//*[local-name()='STATUS' and namespace-uri()='http://www.ibm.com/maximo']", nsmgr);

                    if (node != null)
                    {
                        result.MIAMIWOCurrentStatus = node.InnerText;
                    }

                    System.Diagnostics.EventLog.WriteEntry("MFM.Helpdesk.Distributor", String.Format("This RR Workorder {0} already exists in MiAMI, a update message will be sent to WONUM {1}.", result.MTFMClientRef,result.MiAMIWOWonum), System.Diagnostics.EventLogEntryType.Warning);
                }
                else
                {
                    if (result.NumberOfResults > 1)
                    {
                        result.ClientRefExists = true;
                        XmlNode node = soapResult.SelectSingleNode("//*[local-name()='MTFMCLIENTREF' and namespace-uri()='http://www.ibm.com/maximo'][1]", nsmgr);
                        System.Diagnostics.EventLog.WriteEntry("MFM.Helpdesk.Distributor", String.Format("Many duplicates exist in MiAMI for the RR Workorder {0}.  The request was terminated.",node.InnerText), System.Diagnostics.EventLogEntryType.Error);
                    }
                    else
                    {
                        result.ClientRefExists = false;
                                            }
                }
            }

            return result;
        }

        private XmlDocument CreateSoapEnvelope(string MtfmClientRef)
        {
            XmlDocument soapEnvelop = new XmlDocument();
            soapEnvelop.LoadXml(string.Format(@"<soapenv:Envelope xmlns:soapenv='http://schemas.xmlsoap.org/soap/envelope/' xmlns:max='http://www.ibm.com/maximo'>
                                               <soapenv:Header/>
                                               <soapenv:Body>
                                                  <max:QueryJM8WO >
                                                     <max:JM8WOQuery operandMode='AND'>
                                                     <max:WHERE>MTFMCLIENTREF='{0}'</max:WHERE>
                                                     </max:JM8WOQuery>
                                                  </max:QueryJM8WO>
                                               </soapenv:Body>
                                            </soapenv:Envelope>", MtfmClientRef));
            return soapEnvelop;
        }

        /// <summary>
        /// 
        /// </summary>
        /// removed <max:WOPRIORITY>{2}</max:WOPRIORITY>
        /// <returns></returns>
        public string CreateSoapEnvelopeForUpdate(string Wonum, string SiteId, string TargStart, string TargEnd)
        {
            XmlDocument soapEnvelop = new XmlDocument();

            soapEnvelop.LoadXml(string.Format(@"<soapenv:Envelope xmlns:soapenv='http://schemas.xmlsoap.org/soap/envelope/' xmlns:max='http://www.ibm.com/maximo'>
<soapenv:Header/>
    <soapenv:Body>
        <max:UpdateJM8WO>
            <max:JM8WOSet>
                <max:WORKORDER action='Change'>
                    <max:WONUM>{0}</max:WONUM>
                    <max:SITEID>{1}</max:SITEID>
                    <max:TARGSTARTDATE>{2}</max:TARGSTARTDATE>
                    <max:TARGCOMPDATE>{3}</max:TARGCOMPDATE>            
                </max:WORKORDER>
            </max:JM8WOSet>
        </max:UpdateJM8WO>
    </soapenv:Body>
</soapenv:Envelope>", Wonum, SiteId, Convert.ToDateTime(TargStart).ToString("yyyy-MM-ddTHH:mm:ssZ"), Convert.ToDateTime(TargEnd).ToString("yyyy-MM-ddTHH:mm:ssZ")));
            return soapEnvelop.OuterXml;
        }

        private string GetMaximoUrl()
        {
            string environment = GetEnvironment();
            string maximoEnvironment = string.Empty;

            switch (environment)
            {
                case "production":
                    maximoEnvironment = "https://maximo.mitie.com/meaweb/services/JM8WO";
                    break;
                case "uat":
                    maximoEnvironment = "http://172.17.10.10:80/meawebuat/services/JM8WO";
                    break;
                case "dev":
                    maximoEnvironment = "http://172.17.10.10/meawebdev/services/JM8WO";
                    break;
            }

            return maximoEnvironment;
        }

        private string GetEnvironment()
        {
            string host = System.Net.Dns.GetHostName().ToLower();
            string environment = string.Empty;

            switch (host)
            {
                case "miti-msl-vm-41":
                case "MITI-W-INT-0107":
                case "mitie-com-106":
                case "mitie-com-105":
                    environment = "production";
                    break;
                case "miti-msl-vm-52":
                case "miti-msl-vm-40":
                case "d34fvbt1":
                    environment = "uat";
                    break;
                case "csvmg08-sv":
                case "csvmg07-sv":
                    environment = "uat";
                    break;
            }

            return environment;
        }

        private HttpWebRequest CreateWebRequest(string url, string soapaction)
        {
            HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create(url);
            webRequest.Headers.Add("SOAPAction", soapaction);
            webRequest.ContentType = "text/xml;charset=\"utf-8\"";
            webRequest.Accept = "text/xml";
            webRequest.Method = "POST";
            if (UseProxy())
            {
                webRequest.Proxy = CreateWebProxy();
            }
            return webRequest;
        }

        private bool UseProxy()
        {
            bool useproxy = false;
            string environment = GetEnvironment();

            if (environment == "production")
            {
                useproxy = true;
            }

            return useproxy;
        }

        private WebProxy CreateWebProxy()
        {
            WebProxy webProxy = new WebProxy("http://proxy.mitiegrp.internal.mitie.co.uk:8080", true);
            webProxy.UseDefaultCredentials = true;
            return webProxy;
        }

        private void InsertSoapEnvelopeIntoWebRequest(XmlDocument soapEnvelopeXml, HttpWebRequest webRequest)
        {
            using (Stream stream = webRequest.GetRequestStream())
            {
                soapEnvelopeXml.Save(stream);
            }
        }

        public string RRUpdateFileName(XmlDocument xml)
        {
            //System.String.Format("RRMIAMIWOUPDATE_REQUEST_{0}_{1}_{3}_{2}.xml",updRrWonum,updStatus,System.DateTime.Now.ToString("yyyyMMddTHHmmss.ffff"),MiamiMsgid)
            StringBuilder fname = new StringBuilder();
            fname.Append("RRMIAMIWOUPDATE_REQUEST_");
            try
            {
                fname.Append(xml.SelectSingleNode("/*[local-name()='UpdateRRMIAMIWOUPDATE' and namespace-uri()='http://www.ibm.com/maximo']/*[local-name()='RRMIAMIWOUPDATESet' and namespace-uri()='http://www.ibm.com/maximo']/*[local-name()='WORKORDER' and namespace-uri()='http://www.ibm.com/maximo']/*[local-name()='WONUM' and namespace-uri()='http://www.ibm.com/maximo']").InnerText + "_");//updRrWonum
            }
            catch
            {
                fname.Append("_");
            }
            
            if (xml.OuterXml.Contains("WAPPR"))
            {
                fname.Append("WAPPR" + "_");
            }
            else if (xml.OuterXml.Contains("WORKLOG"))
            {
                fname.Append("WORKLOG" + "_");
            }
            else
            {
                try
                {
                    fname.Append(xml.SelectSingleNode("/*[local-name()='UpdateRRMIAMIWOUPDATE' and namespace-uri()='http://www.ibm.com/maximo']/*[local-name()='RRMIAMIWOUPDATESet' and namespace-uri()='http://www.ibm.com/maximo']/*[local-name()='WORKORDER' and namespace-uri()='http://www.ibm.com/maximo']/*[local-name()='STATUS' and namespace-uri()='http://www.ibm.com/maximo']").InnerText + "_");//updStatus
                }
                catch
                {
                    fname.Append("_");
                }
            }

            try
            {
                fname.Append(xml.SelectSingleNode("/*[local-name()='UpdateRRMIAMIWOUPDATE' and namespace-uri()='http://www.ibm.com/maximo']/@*[local-name()='messageID' and namespace-uri()='']").InnerText + "_");//MiamiMsgid
            }
            catch
            {
                fname.Append("_");
            }

            fname.Append(System.DateTime.Now.ToString("yyyyMMddTHHmmss.ffff") + ".xml");
            return fname.ToString();
        }
    }


    public class BstObject
    {
        public int year;
        public DateTime StartBst;
        public DateTime EndBst;

        public BstObject(int Year, DateTime Start, DateTime End)
        {
            year = Year;
            StartBst = Start;
            EndBst = End;
        }
    }

    [Serializable]
    public class SimpleWorkflowRequest
    {
        public Boolean IsValid;
        public string Action;
        public string Ref;
        public string Workflow;
        public string id;
        public string guid;

    }

    [Serializable]
    public class RrHelper
    {
        /// <summary>
        /// Supress email alerts for harmless failure messages
        /// from web service calls into the 1team RR update service
        /// These errors are in response to manual handling of the workorder
        /// that make the incoing message irrelevant
        /// </summary>
        /// <returns></returns>
        public static bool NoRrEmailAlerts()
        {
            return true;
        }

        /// <summary>
        /// Return the number or retries to be attempted
        /// </summary>
        /// <returns></returns>
        public static Int32 RrWebServiceRetryMaxAttempts()
        {
            return 5;
        }

        /// <summary>
        /// Return seconds between retries in orcestration pattern
        /// </summary>
        /// <returns></returns>
        public static Int32 RrWebServiceRetryInterval()
        {
            return 1000 * 30;
        }

        public static bool RrRetryFromSystemException(string errormsg)
        {
            //These both capture System.ServiceModel.EndpointNotFoundException depending on how biztalk states the error message
            if (errormsg.Contains("There was no endpoint listening")) return true;
            if (errormsg.Contains("EndpointNotFoundException")) return true;

            //default - keep true for now as may want to inspect all sys ex messages both deciding to terminate or resume
            //todo: get this to false.
            return true;
        }
    }

    [Serializable]
    public class Misc
    {

        /// <summary>
        /// Suppress email alerts for the capita messages being 
        /// output by maximo miami.  These messages relate to locations
        /// that are not in scope of the solution.  No audience exists for these messages
        /// </summary>
        /// <returns></returns>
        public static bool NoCapitaEmailAlerts()
        {
            return true;
        }

        /// <summary>
        /// Removes
        ///  ? < > \ : * | "
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public string RemoveUnsupportedFilePathCharacters(string input)
        {
            //"[^"]*" - replace qualified email addresses in the form "Cieslewicz, Pawel, Vodafone Ireland"
            string pattern1 = @"""[^""]*""";
            Regex rgx = new Regex(pattern1, RegexOptions.Multiline | RegexOptions.IgnoreCase);
            input = rgx.Replace(input, "").Trim();
            return input.Replace("<", "").Replace(">", "").Replace("?", "").Replace(":", "").Replace("*", "").Replace("|", "").Replace(@"\", "").Replace(@"/", ""); 
        }

        /// <summary>
        /// Basic pattern: 
        /// Action:TrackCase Case:1234-5678 Request:reject
        /// </summary>
        /// <param name="subject">
        /// </param>
        /// <returns></returns>
        public SimpleWorkflowRequest ParseSimpleWorkflowSubject(string subject)
        {
            SimpleWorkflowRequest swf = new SimpleWorkflowRequest();
            //EventLog.WriteEntry("MFM.Helpdesk.Distributor", String.Format("Subject: {0}", subject), EventLogEntryType.Information);

            //Must start Action: - Forwarded emails will be rejecting if start FWD etc
            //SIngle space splits action and case and request
            //Action is a verb, no spaces, only letter
            //Case follows current VisionFM numbering systems userid-caseid which is numeric-hypenh-numeric
            //Request will current support a space and letters to support multi-word workflow moves
            //Revisit above to restrict to single verb if suitable translation source can be identified. Preference would be termin match as first space after request.
            string pattern1 = @"^Action:([^ ]*) Case:([0-9]*-[0-9]*) Request:([a-z ]*) ID:([0-9]*) GUID:([0-9a-z]{8}-[0-9a-z]{4}-[0-9a-z]{4}-[0-9a-z]{4}-[0-9a-z]{12})";   
            Regex rgx = new Regex(pattern1, RegexOptions.Multiline | RegexOptions.IgnoreCase);

            Match m = rgx.Match(subject);
            swf.IsValid = m.Groups[0].Success;

            if (swf.IsValid == true)
            {
                swf.Action = m.Groups[1].Value.ToString();
                swf.Ref = m.Groups[2].Value.ToString();
                swf.Workflow = m.Groups[3].Value.ToString();
                swf.id = m.Groups[4].Value.ToString();
                swf.guid = m.Groups[5].Value.ToString();
            }

            return swf;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="iput"></param>
        /// <returns></returns>
        public string RemoveEncodedEntities(string iput)
        {
            StringWriter myWriter = new StringWriter();
            HttpUtility.HtmlDecode(iput, myWriter);
            return CleanVariableSourcedBodyText(myWriter.ToString());
        }


        /// <summary>
        /// Clean the Email Body, - remove formatting instuction between <!-- and -->

        /// Outlook client HTML format pattern      v\\.*&lt;!--.*--&gt;
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public string CleanVariableSourcedBodyText(string input)
        {
            //v\\.*&lt;!--.*--&gt;
            string pattern1 = @"<!--.*-->";   //Remove Comments- this should contain most outlook html formatting styles
            string pattern2 = @"^[a-z]\\:.*";       //Remove behaviours - this should contain most outlook html formatting styles
            string pattern3 = @"^.*\{.*\}";         //Remove behaviours - this should contain most outlook html formatting styles
            string pattern4 = @"^\r\n";             //Remove extra line breaks
            string replacement = "";
            Regex rgx = new Regex(pattern1, RegexOptions.Singleline);
            Regex rgx2 = new Regex(pattern2, RegexOptions.Multiline | RegexOptions.IgnoreCase);
            Regex rgx3 = new Regex(pattern3, RegexOptions.Multiline | RegexOptions.IgnoreCase);
            Regex rgx4 = new Regex(pattern4, RegexOptions.Multiline | RegexOptions.IgnoreCase);

            string result = rgx.Replace(input, replacement);
            result = rgx2.Replace(result, replacement);
            result = rgx3.Replace(result, replacement);
            result = rgx4.Replace(result, replacement);

            return result;
        }

        public String AdjustForBst(DateTime input)
        {
            DateTime returnDt = input.ToUniversalTime();


            BstObject Year2015 = new BstObject(2015, Convert.ToDateTime("2015-03-29T01:00:00").ToUniversalTime(), Convert.ToDateTime("2015-10-25T02:00:00").ToUniversalTime());
            BstObject Year2016 = new BstObject(2016, Convert.ToDateTime("2016-03-27T01:00:00").ToUniversalTime(), Convert.ToDateTime("2016-10-30T02:00:00").ToUniversalTime());
            BstObject Year2017 = new BstObject(2017, Convert.ToDateTime("2017-03-26T01:00:00").ToUniversalTime(), Convert.ToDateTime("2017-10-29T02:00:00").ToUniversalTime());
            BstObject Year2018 = new BstObject(2018, Convert.ToDateTime("2018-03-25T01:00:00").ToUniversalTime(), Convert.ToDateTime("2018-10-28T02:00:00").ToUniversalTime());

            List<BstObject> YearList = new List<BstObject>();
            YearList.Add(Year2015);
            YearList.Add(Year2016);
            YearList.Add(Year2017);
            YearList.Add(Year2018);

            int InputYear = input.Year;

            foreach (BstObject BstYr in YearList)
            {
                if (BstYr.year == input.Year)
                {
                    if (input.Ticks > BstYr.StartBst.Ticks && input.Ticks <= BstYr.EndBst.Ticks)
                    {
                        //This is BST
                        //EventLog.WriteEntry("MFM.Helpdesk.Distributor", "bst time", EventLogEntryType.Information);
                        return String.Format("{0}{1}", input.ToUniversalTime().ToString("yyyy-MM-ddTHH:mm:ss"), "+01:00");
                    }

                }
            }

            return String.Format("{0}{1}", input.ToString("yyyy-MM-ddTHH:mm:ss"), "+00:00");
        }
        
        public Boolean RestrictWorkLogsToStatusMsgs()
        {
            return true;
        }
        
        public int RandomDelay()
        {
            return RandNumber(0, 60);
        }
        
        private static int RandNumber(int Low, int High)
        {
            Random rndNum = new Random(int.Parse(Guid.NewGuid().ToString().Substring(0, new Random().Next(3, 8)), System.Globalization.NumberStyles.HexNumber));

            int rnd = rndNum.Next(Low, High);

            return rnd;
        }

        
        public static string XmlDocToBase64String(System.Xml.XmlDocument doc)
        {
            return Convert.ToBase64String(Encoding.UTF8.GetBytes(doc.OuterXml.ToString()));
        }

        public string GetFileName(string fullFilePath)
        {
            string tempName = fullFilePath;
            string[] split = tempName.Split('\\');
            tempName = split.ElementAt(split.Length - 1);
            return tempName.Replace(".xml", "").Replace(".XML", "");
        }


        public MiAMIWorkorderEnquiryResult GetMiAMIWoClientRefResult(string ClientRef)
        {
            MiAMIWorkorderEnquiryResult result = new MiAMIWorkorderEnquiryResult();
            result.ClientRefExists = false;

            return result;
        }


        public bool rrLogOnlySwitch()
        {
            return false;
        }

        public Int32 UpdateApproch()
        {
            // 1 - Normal
            // 2 - Split into Status Update and then Worklog Update with consolidated worklogs
            // 3 - Split into Status Update and then Worklogs 
            // 4 - Split into status update and then worklogs - both Async
            return 4;
        }

        public DateTime rrSecondsShifter(Int32 iteration, DateTime target)
        {
            return target.AddSeconds(System.Convert.ToDouble(iteration));
        }

        public string RrAdminUser()
        {
            return "MIAMIUSR";
        }

        public string RrFileName(string fullpath)
        {
            string[] parts = fullpath.Split('\\');
            Int32 i = parts.Length - 1;
            return parts[i];
        }

        public bool ApacheWsNotAvailable(XmlDocument SoapXmlFault)
        {
            return SoapXmlFault.OuterXml.Contains("The service cannot be found for the endpoint reference (EPR)");
        }

        public bool RetryOnErrors(XmlDocument SoapXmlFault)
        {
            //Alowed errors where retry can be supported
            List<string> MaximoErrorList = new List<string>();
            //MaximoErrorList.Add("BMXAA4211E"); //Duplicate concurrent inserts
            MaximoErrorList.Add("BMXAA4160E"); //General error occurs for http 500
            MaximoErrorList.Add("BMXAA6395E"); //The system could not connect to the JDBC source 
            MaximoErrorList.Add("BMXAA8229W"); //Work Order has been updated by another user. Your changes have not been saved
            MaximoErrorList.Add("BMXAA4211E"); // Database 2601, may be concurrency 
            MaximoErrorList.Add("BMXAA4494E"); //Clock sync error where rejection due to date in future

            foreach (string item in MaximoErrorList)
            {
                if (SoapXmlFault.OuterXml.Contains(item))
                {
                    EventLog.WriteEntry("MFM.Helpdesk.Distributor", String.Format("Supported Error ({1}) will retry unless manually submitted. Rolls Royce Maximo inbound Web Service\r\n\r\n{0}", FormatXml(SoapXmlFault.OuterXml), item), EventLogEntryType.Warning);
                    return true;
                }
            }

            //Chuck the error out to log
            EventLog.WriteEntry("MFM.Helpdesk.Distributor", String.Format("Unsupported Error returned from Rolls Royce Maximo inbound Web Service\r\n\r\n{0}", FormatXml(SoapXmlFault.OuterXml)), EventLogEntryType.Error);

            return false;
        }

        public string translateRrWorkType(string rrWorkType)
        {
            switch (rrWorkType)
            {
                case "CM":
                    return "RW";
                case "AESR":
                    return "RW";
                case "ADHOC":
                    return "QW";
                case "PCM":
                    return "RW";
                case "PROJ":
                    return "PW";
                case "PMSC":
                    return "PM";
                case "NPT":
                    return "PCM/RW";
                case "SI":
                    return "PM";
                case "PM":
                    return "PM";
                default:
                    return "";
            }
        }

        public string rrLongDescription(string loc, string locDesc, string rrWorkType, string woLongDesc, string rrAssetNum,string rrEmail)
        {
            string linebreak = System.Environment.NewLine;
            
            StringBuilder concat = new StringBuilder();
            concat.AppendLine(string.IsNullOrEmpty(loc) ? "" : loc);
            concat.AppendLine();
            concat.Append(linebreak);
            concat.AppendLine(string.IsNullOrEmpty(locDesc) ? "" : locDesc);
            concat.AppendLine();
            concat.Append(linebreak);
            concat.AppendLine(string.IsNullOrEmpty(rrWorkType) ? "" : rrWorkType);
            concat.AppendLine();
            concat.Append(linebreak);
            concat.AppendLine(string.IsNullOrEmpty(woLongDesc) ? "" : woLongDesc);
            concat.AppendLine();
            concat.Append(linebreak);
            concat.AppendLine(string.IsNullOrEmpty(rrAssetNum) ? "" : rrAssetNum);
            concat.AppendLine();
            concat.Append(linebreak); concat.Append(linebreak);
            concat.AppendLine(string.IsNullOrEmpty(rrEmail) ? "" : rrEmail);
            concat.Append(linebreak);
            return StripFormatting(concat.ToString());
        }

        public XmlDocument GetCombinedWorkLogMsg(XmlDocument msg)
        {
            //Get all Worklog Nodes
            XmlNamespaceManager xmlnsManager = new XmlNamespaceManager(msg.NameTable);
            xmlnsManager.AddNamespace("ns0", "http://www.ibm.com/maximo");
            List<MiamiWorklogNode> RawData = new List<MiamiWorklogNode>();
            XmlNodeList WorkLogNodes = msg.SelectNodes("/ns0:UpdateRRMIAMIWOUPDATE/ns0:RRMIAMIWOUPDATESet/ns0:WORKORDER/ns0:WORKLOG", xmlnsManager);
            ///ns0:UpdateRRMIAMIWOUPDATE/ns0:RRMIAMIWOUPDATESet/ns0:WORKORDER/ns0:WORKLOG/ns0:CLASS
            // /ns0:WORKLOG/ns0:DESCRIPTION
            foreach(XmlNode node in WorkLogNodes)
            {
                //split to class
                MiamiWorklogNode wl = new MiamiWorklogNode();

                //Clone the target node
                XmlDocument target = new XmlDocument();
                target.LoadXml(node.OuterXml);
                String strDescription = target.SelectSingleNode("//ns0:DESCRIPTION", xmlnsManager).InnerXml;
                wl.wlDescription = strDescription;
                wl.wlClass = target.SelectSingleNode("//ns0:CLASS", xmlnsManager).InnerXml;
                wl.WlCreateBy = target.SelectSingleNode("//ns0:CREATEBY", xmlnsManager).InnerXml;
                wl.wlCreateDate = System.Convert.ToDateTime(target.SelectSingleNode("//ns0:CREATEDATE", xmlnsManager).InnerXml);
                wl.wlLongDescription = StripFormatting(target.SelectSingleNode("//ns0:DESCRIPTION_LONGDESCRIPTION", xmlnsManager).InnerXml);
                wl.wlType = target.SelectSingleNode("//ns0:LOGTYPE", xmlnsManager).InnerXml;
                wl.wlModifyBy = target.SelectSingleNode("//ns0:MODIFYBY", xmlnsManager).InnerXml;
                wl.wlModifyDate = System.Convert.ToDateTime(target.SelectSingleNode("//ns0:MODIFYDATE", xmlnsManager).InnerXml);
                wl.wlRecordKey = target.SelectSingleNode("//ns0:RECORDKEY", xmlnsManager).InnerXml;
                
                RawData.Add(wl);
                wl = null;

            }

            //Build the long description for the combined worklog
            StringBuilder sb = new StringBuilder();
            foreach (MiamiWorklogNode log in RawData)
            {
                if(String.IsNullOrEmpty(log.wlDescription))
                {
                    sb.AppendFormat("Description: NONE {0} (1)", log.wlCreateDate.ToString("yyyy-MM-ddTmm:ss:hh"),log.wlType);
                }
                else
                {
                    sb.AppendFormat("Description: {0} (MiAMI {1})", log.wlDescription, log.wlType);
                }
                sb.AppendLine();
                sb.Append(log.wlLongDescription);
                sb.AppendLine();
                sb.AppendFormat("Created and Modified by: {0}\r\nONETEAM WONUM: {1}",log.wlModifyBy,log.wlRecordKey);
                sb.AppendLine();
                sb.AppendLine();
            }

            //Set the Worklog content

            DateTime newModifiedDate = RawData[RawData.Count - 1].wlModifyDate;
            WorkLogNodes[0].SelectSingleNode("//ns0:DESCRIPTION", xmlnsManager).InnerXml = "MiAMI WorkLog History";
            WorkLogNodes[0].SelectSingleNode("//ns0:MODIFYDATE", xmlnsManager).InnerXml = newModifiedDate.ToString("yyyy-MM-ddThh:mm:ss");
            WorkLogNodes[0].SelectSingleNode("//ns0:DESCRIPTION_LONGDESCRIPTION", xmlnsManager).InnerXml = sb.ToString();
           
            XmlNode xNode = WorkLogNodes[0];

            //Clear out all but the first node, work from count down to 1
            for (int i = WorkLogNodes.Count - 1; i > 0; i--)
            {
                WorkLogNodes[i].ParentNode.RemoveChild(WorkLogNodes[i]);
            }

            XmlDocument xml = new XmlDocument();
            xml = msg;
            return xml;
        }

        public class MiamiWorklogNode
        {
            public string wlClass;
            public string WlCreateBy;
            public DateTime wlCreateDate;
            public string wlDescription;
            public string wlLongDescription;
            public string wlType;
            public string wlModifyBy;
            public DateTime wlModifyDate;
            public String wlRecordKey;
        }


        /// <summary>
        /// Environment specific email To address for 1TEAM\MIAMI integration
        /// </summary>
        /// <param name="Team"></param>
        /// <returns></returns>
        public string rrSupportEmail(string Team)
        {
            string host = System.Net.Dns.GetHostName().ToLower();
            string devEmailAddress = "Tony.Arrighi@mitie.com";
            string qaEmailAddress1TEAM = "Tony.Arrighi@mitie.com";
            string qaEmailAddressMIAMI = "Tony.Arrighi@mitie.com";
            string prodEmailAddress1TEAM = "Tony.Arrighi@mitie.com";
            string prodEmailAddressMIAMI = "Tony.Arrighi@mitie.com";

            string emailAddress = string.Empty;
            string subject = string.Empty;

            if (Team == "MIAMI")
            {
                switch (host)
                {
                    case "miti-msl-vm-41":
                    case "mitie-com-105":
                    case "mitie-com-106":
                    case "miti-w-int-0107":
                        emailAddress = prodEmailAddressMIAMI;
                        break;
                    case "miti-msl-vm-40":
                    case "miti-msl-vm-52":
                        emailAddress = qaEmailAddressMIAMI;
                        break;
                    default:
                        emailAddress = devEmailAddress;
                        break;
                }
            }

            if (Team == "1TEAM")
            {
                switch (host)
                {
                    case "miti-msl-vm-41":
                    case "mitie-com-105":
                    case "mitie-com-106":
                    case "miti-w-int-0107":
                        emailAddress = prodEmailAddress1TEAM;
                        break;
                    case "miti-msl-vm-40":
                    case "miti-msl-vm-52":
                        emailAddress = qaEmailAddress1TEAM;
                        break;
                    default:
                        emailAddress = devEmailAddress;
                        break;
                }
            }

            return emailAddress;

        }

        public XmlDocument GetMssWebServiceEmailAlert(string To, string Bcc, string SmtpServer, string Subject, string Para1, XmlDocument xml)
        {
            EventLog.WriteEntry("MFM.Helpdesk.Distributor", "GetMssWebServiceEmailAlert invoked", EventLogEntryType.Information);
            XmlDocument msg = new XmlDocument();

            string MITIEDEFAULTSMTP = "mailrelay.mitie.com";

            if(string.IsNullOrEmpty(SmtpServer))
            {
                SmtpServer = MITIEDEFAULTSMTP;
            }

            if (string.IsNullOrEmpty(Bcc))
            {
                Bcc = "";
            }

            if (string.IsNullOrEmpty(Para1))
            {
                Para1 = "";
            }

            bool errorOnXml = false;
            Int32 skipPayload = 0;
            Int32 Attempts = 0;
            while (errorOnXml == false && Attempts < 2)
            {
                Attempts = Attempts + 1;
                StringBuilder sb = new StringBuilder();
                //EventLog.WriteEntry("MFM.Helpdesk.Distributor", "GetMssWebServiceEmailAlert while loop - skip value: " + skipPayload.ToString(), EventLogEntryType.Information);
                try
                {
                    sb.AppendFormat(@"<ns0:MSSWebServiceAlertEmail xmlns:ns0='http://MFM.Lbg.Schemas.WebServiceAlertEmail'>");
                    sb.AppendFormat("<SmtpServer>{0}</SmtpServer>", SmtpServer);
                    sb.AppendFormat("<Subject>{0}</Subject>", AddEnvironmentToSubjet(Subject));
                    sb.AppendFormat("<To>{0}</To>", To);
                    sb.AppendFormat("<Bcc>{0}</Bcc>", Bcc);
                    sb.AppendFormat("<BodyText><![CDATA[{0}]]></BodyText>", Para1);
                    if (skipPayload == 0)
                    {
                        sb.AppendFormat("<BodyTextPayload><![CDATA[{0}]]></BodyTextPayload>", FormatXml(xml.OuterXml));
                    }
                    else
                    {
                        sb.AppendFormat("<BodyTextPayload>{0}</BodyTextPayload>", "");
                    }
                    sb.AppendFormat("</ns0:MSSWebServiceAlertEmail>");
                    msg.LoadXml(sb.ToString());
                    errorOnXml = true;
                }
                catch (Exception ex)
                {
                    string note = "GetMssWebServiceEmailAlert Err: " + ex.Message + "\r\n" + sb.ToString();
                    if (note.Length >= 32766) note = note.Substring(0, 32766 - 1);
                    EventLog.WriteEntry("MFM.Helpdesk.Distributor", note, EventLogEntryType.Error);
                    skipPayload = 1;
                    Thread.Sleep(5000);
                }

            }

            return msg;
        }

        public XmlDocument GetMssWebServiceEmail(string To, string Bcc, string SmtpServer, string Subject, string Para1)
        {
            XmlDocument msg = new XmlDocument();
            StringBuilder sb = new StringBuilder();
            string MITIEDEFAULTSMTP = "mailrelay.mitie.com";

            if (string.IsNullOrEmpty(SmtpServer))
            {
                SmtpServer = MITIEDEFAULTSMTP;
            }

            if (string.IsNullOrEmpty(Bcc))
            {
                Bcc = "";
            }

            if (string.IsNullOrEmpty(Para1))
            {
                Para1 = "";
            }

            sb.AppendFormat(@"<ns0:MSSWebServiceAlertEmail xmlns:ns0='http://MFM.Lbg.Schemas.WebServiceAlertEmail'>");
            sb.AppendFormat("<SmtpServer>{0}</SmtpServer>", SmtpServer);
            sb.AppendFormat("<Subject>{0}</Subject>", AddEnvironmentToSubjet(Subject));
            sb.AppendFormat("<To>{0}</To>", To);
            sb.AppendFormat("<Bcc>{0}</Bcc>", Bcc);
            sb.AppendFormat("<BodyText>{0}</BodyText>", Para1);
            sb.AppendFormat("<BodyTextPayload><![CDATA[{0}]]></BodyTextPayload>", "");
            sb.AppendFormat("</ns0:MSSWebServiceAlertEmail>");
            msg.LoadXml(sb.ToString());

            return msg;
        }


        /// <summary>
        /// Use xml.Linq to quickly provide a formatted indented XML string
        /// </summary>
        /// <param name="Xml"></param>
        /// <returns></returns>
        private string FormatXml(String Xml)
        {
            try
            {
                XDocument doc = XDocument.Parse(Xml);
                return doc.ToString();
            }
            catch (Exception)
            {
                return Xml;
            }
        }

        public string XslPath(string xslSwitch)
        {
            String DfsRoot = @"\\mitiegrp.internal.mitie.co.uk\AppData\MCS\Interfaces";
            String AppSubPath = @"MFM_LBG_CAFM\Xsl";
            String xslTemplatePath = String.Empty;
            String xslFilename = String.Empty;

            switch (xslSwitch)
            {
                case "DIST":
                    xslFilename = "Cafm_notify_distributed.xsl";
                    break;
                case "TEAM247":
                    xslFilename = "Cafm_notify_VisionFM_TL_003.xsl";
                    break;
                case "TEAMSUPP":
                    xslFilename = "Cafm_notify_VisionFM_SUPP_002.xsl";
                    break;
                case "TFM":
                    xslFilename = "Cafm_notify_tfm.xsl";
                    break;
                case "DISTSENT":
                    xslFilename = "Cafm_notify_distributed_003.xsl";
                    break;
                default:
                    xslFilename = string.Empty;
                    break;
            }

            //Recognised and valid XSL switch was provided, so map XSL file                
            switch (System.Net.Dns.GetHostName().ToLower())
            {
                case "miti-msl-vm-41":
                case "mitie-com-105":
                case "mitie-com-106":
                case "miti-w-int-0107":
                    xslTemplatePath = String.Format(@"{0}\{1}\{2}\{3}", DfsRoot, "LIVE", AppSubPath,xslFilename);
                    break;
                case "miti-msl-vm-40":
                case "miti-msl-vm-52":
                    xslTemplatePath = String.Format(@"{0}\{1}\{2}\{3}", DfsRoot, "QA", AppSubPath, xslFilename);
                    break;
                default:
                    xslTemplatePath = String.Format(@"{0}\{1}\{2}\{3}", DfsRoot, "DEV", AppSubPath, xslFilename);
                    break;
            }

            return xslTemplatePath;
        }

        public string StripFormatting(string inputhtml)
        {
            const string RegexPattern = "<[^>]*>";

            string formatted = inputhtml;
            String clean = "";
            formatted = formatted.Replace("<br>", Environment.NewLine)
                                   .Replace("<div>", Environment.NewLine)
                                   .Replace("<p>", Environment.NewLine)
                                   .Replace("<span>", Environment.NewLine)
                                   .Replace("<tr>", Environment.NewLine)
                                   .Replace("]]>", "")
                                   .Replace("<![CDATA[", "")
                                   .Replace("&lt;", "")
                                   .Replace("&gt;", "")
                                   .Replace("EN-GB", "")
                                   .Replace("X-NONE", "")
                                   .Replace("MicrosoftInternetExplorer4", "");

            clean = Regex.Replace(formatted, RegexPattern, string.Empty);
            return clean.Replace("\r\n\r\n", "");
        }

        public string indicateEnv()
        {

            string host = System.Net.Dns.GetHostName().ToLower();

            switch (host)
            {
                case "miti-msl-vm-41":
                    return "";
                case "mite-com-105":
                    return "";
                case "mite-com-106":
                    return "";
                case "miti-msl-vm-40":
                    return "(UAT) ";
                case "miti-msl-vm-52":
                    return "(UAT) ";
                default:
                    return "(DEV) ";
            }
        }

        /// <summary>
        /// Prefix an environment indicateor to an existing string subject
        /// </summary>
        /// <param name="Subject"></param>
        /// <returns></returns>
        public string AddEnvironmentToSubjet(string Subject)
        {
            int debug = 0;

            string host = System.Net.Dns.GetHostName().ToLower();

            if (debug == 1)
            {
                //EventLog.WriteEntry("MFM.Helpdesk.Distributor", String.Format("0|{0}|{1}", host, Subject), EventLogEntryType.Information);
            }

            switch (host)
            {
                case "csvmg07-sv":
                    Subject = System.String.Format("{0} {1}", "(DEV)", Subject);
                    break;
                case "csvmg08-sv":
                    Subject = System.String.Format("{0} {1}", "(DEV)", Subject);
                    break;
                case "miti-msl-vm-41":
                    break;
                case "mite-com-105":
                    break;
                case "mite-com-106":
                    break;
                case "miti-msl-vm-40":
                    Subject = System.String.Format("{0} {1}", "(UAT)", Subject);
                    break;
                case "miti-msl-vm-52":
                    Subject = System.String.Format("{0} {1}", "(UAT)", Subject);
                    break;
            }

            if (debug == 1)
            {
                //EventLog.WriteEntry("MFM.Helpdesk.Distributor", String.Format("X|{0}|{1}", host, Subject), EventLogEntryType.Information);
            }

            return Subject;
        }

        public string editLookupConnectionString()
        {
            string host = System.Net.Dns.GetHostName().ToLower();
            switch (host)
            {
                case "miti-msl-vm-41":
                    return "Provider=SQLOLEDB;Database=MFM_SAP_DATA_INTERFACES;Integrated Security=SSPI;Server=MITIE-SQL4-01";
                case "mitie-com-105":
                    return "Provider=SQLOLEDB;Database=MFM_SAP_DATA_INTERFACES;Integrated Security=SSPI;Server=MITIE-SQL4-01";
                case "mitie-com-106":
                    return "Provider=SQLOLEDB;Database=MFM_SAP_DATA_INTERFACES;Integrated Security=SSPI;Server=MITIE-SQL4-01";
                case "MITI-W-INT-0107":
                      return "Provider=SQLOLEDB;Database=MFM_SAP_DATA_INTERFACES;Integrated Security=SSPI;Server=MITIE-SQL4-01";
                case "miti-msl-vm-40":
                    return "Provider=SQLOLEDB;Database=MFM_SAP_DATA_INTERFACES;Integrated Security=SSPI;Server=MITIE-COM-19";
                case "miti-msl-vm-52":
                    return "Provider=SQLOLEDB;Database=MFM_SAP_DATA_INTERFACES;Integrated Security=SSPI;Server=MITIE-COM-19";
                case "csvmg07-sv":
                    return "Provider=SQLOLEDB;Database=MFM_SAP_DATA_INTERFACES;Integrated Security=SSPI;Server=MITIE-COM-19";
                default:
                    return "Provider=SQLOLEDB;Database=MFM_SAP_DATA_INTERFACES;Integrated Security=SSPI;Server=MITIE-COM-19";
            }
        }

        public string VisionFMLookupConnectionString()
        {
            string host = System.Net.Dns.GetHostName().ToLower();
            switch (host)
            {
                case "miti-msl-vm-41":
                    return "Provider=SQLOLEDB;Database=MFM_HELPDESK;Integrated Security=SSPI;Server=MITIE-SQL7-01";
                case "mitie-com-105":
                    return "Provider=SQLOLEDB;Database=MFM_HELPDESK;Integrated Security=SSPI;Server=MITIE-SQL7-01";
                case "mitie-com-106":
                    return "Provider=SQLOLEDB;Database=MFM_HELPDESK;Integrated Security=SSPI;Server=MITIE-SQL7-01";
                case "MITI-W-INT-0107":
                    return "Provider=SQLOLEDB;Database=MFM_HELPDESK;Integrated Security=SSPI;Server=MITIE-SQL7-01";
                case "miti-msl-vm-40":
                    return "Provider=SQLOLEDB;Database=MFM_HELPDESK_SUPPORT;Integrated Security=SSPI;Server=MITIE-COM-19";
                case "miti-msl-vm-52":
                    return "Provider=SQLOLEDB;Database=MFM_HELPDESK_SUPPORT;Integrated Security=SSPI;Server=MITIE-COM-19";
                case "csvmg07-sv":
                    return "Provider=SQLOLEDB;Database=MFM_HELPDESK_RAD;Integrated Security=SSPI;Server=MITIE-COM-19";
                default:
                    return "Provider=SQLOLEDB;Database=MFM_HELPDESK_SUPPORT;Integrated Security=SSPI;Server=MITIE-COM-19";
            }
        }

        /// <summary>
        /// Add mapping from Facilities service stream 29070 to GENERALBSERV
        /// Add mapping from Projects service stream 29078 to GENERALBSERV
        /// </summary>
        /// <param name="CompanyId"></param>
        /// <param name="ServiceStreamId"></param>
        /// <param name="ServiceDetailId"></param>
        /// <returns></returns>
        public string getMiAMICommodity(int CompanyId, int ServiceStreamId, int ServiceDetailId)
        {

            string Commodity = ServiceDetailId.ToString();

            switch (ServiceStreamId)
            {
                case 18031:
                    Commodity = "GENERALBF";
                    break;

                case 18036:
                    Commodity = "GENERALME";
                    break;
                case 18032:
                    Commodity = "GENERALBSERV";
                    break;
                case 18040:
                    Commodity = "GENERALSEC";
                    break;
                case 18033:
                    Commodity = "GENERALCE";
                    break;
                case 29070:
                    Commodity = "GENERALBSERV";
                    break;
                case 29078:
                    Commodity = "GENERALBSERV";
                    break;
            }

            switch (CompanyId)
            {
                case 1414:
                    return Commodity;
                case 4248:
                    return Commodity;
                case 4250:
                    return Commodity;
                default:
                    return ServiceDetailId.ToString();
            }
        }


        public string GetRegionalEmailAddress(String region)
        {
            string host = System.Net.Dns.GetHostName().ToLower();
            bool useProd = false;
            string testEmail = "Tony.Arrighi@mitie.com";
            
            //Maintain here...biztalk prod servers will change soon!!!
            if (host == "miti-msl-vm-41" || host == "MITI-W-INT-0107" || host == "mitie-com-106" || host == "mitie-com-105")
            {
                    useProd = true;
            }

            if (useProd)
            {
                switch (region)
                {
                    case "MIDS":
                        return "MTFM.LloydsMIDS@mitie.com";
                    case "NSCT":
                        return "MTFM.LloydsNSCT@mitie.com";
                    case "SSW":
                        return "MTFM.LloydsSSW@mitie.com";
                    case "LSE":
                        return "MTFM.LloydsLSE@mitie.com";
                    case "NMS":
                        return "MTFM.LloydsNMS@mitie.com";
                    default:
                        return "MTFM.LloydsNMS@mitie.com";
                }
            }
            else
            {
                switch (region)
                {
                    case "MIDS":
                        return testEmail;
                    case "NSCT":
                        return testEmail;
                    case "SSW":
                        return testEmail;
                    case "LSE":
                        return testEmail;
                    case "NMS":
                        return testEmail;
                    default:
                        return testEmail;
                }
            }
        }

        public string GetVisionFMMailbox()
        {
            string host = System.Net.Dns.GetHostName().ToLower();
            bool useProd = false;
            string testEmail = "Tony.Arrighi@mitie.com";

            //Maintain here...biztalk prod servers will change soon!!!
            if (host == "miti-msl-vm-41" || host == "MITI-W-INT-0107" || host == "mitie-com-106" || host == "mitie-com-105")
            {
                useProd = true;
            }

            if (useProd)
            {
                return "lbg.helpdesk@mitie.com;24seven.support@mitie.com";
            }
            else
            {
                return testEmail;
            }
        }

        public string GetVisionFmTeamLeaderMailbox()
        {
            string host = System.Net.Dns.GetHostName().ToLower();
            bool useProd = false;
            string testEmail = "Tony.Arrighi@mitie.com";

            //Maintain here...biztalk prod servers will change soon!!!
            if (host == "miti-msl-vm-41" || host == "MITI-W-INT-0107" || host == "mitie-com-106" || host == "mitie-com-105")
            {
                useProd = true;
            }

            if (useProd)
            {
                return "24Seven.TeamLeaders@mitie.com;MOJ.TFMHelpdesk@mitie.com";
            }
            else
            {
                return testEmail;
            }
        }

        public string GetVisionFMSupportMailbox()
        {
            string host = System.Net.Dns.GetHostName().ToLower();
            bool useProd = false;
            string testEmail = "Tony.Arrighi@mitie.com";

            //Maintain here...biztalk prod servers will change soon!!!
            if (host == "miti-msl-vm-41" || host == "MITI-W-INT-0107" || host == "mitie-com-106" || host == "mitie-com-105")
            {
                useProd = true;
            }

            if (useProd)
            {
                return "24seven.support@mitie.com";
            }
            else
            {
                return testEmail;
            }
        }

        public string GetVisionFMSupportMailboxByContract(string Contract)
        {
            string host = System.Net.Dns.GetHostName().ToLower();
            bool useProd = false;
            string testEmail = "Tony.Arrighi@mitie.com";
            string testEmail2 = "Tony.Arrighi@mitie.co.uk";

            //Maintain here...biztalk prod servers will change soon!!!
            if (host == "miti-msl-vm-41" || host == "MITI-W-INT-0107" || host == "mitie-com-106" || host == "mitie-com-105")
            {
                useProd = true;
            }

            if (useProd)
            {
                if (Contract == "LBG")
                {
                    return "24seven.support@mitie.com";
                }
                else
                { 
                    return "visionfm.support@mitie.com";
                }
                
            }
            else
            {
                if (Contract == "LBG")
                {
                    return testEmail;
                }
                else
                {
                    return testEmail2;
                }
            }
        }

        public string GetFinanceMailbox()
        {
            string host = System.Net.Dns.GetHostName().ToLower();
            bool useProd = false;
            string testEmail = "Tony.Arrighi@mitie.com";

            //Maintain here...biztalk prod servers will change soon!!!
            if (host == "miti-msl-vm-41"||host=="mitie-com-106"||host=="mitie-com-105")
            {
                useProd = true;
            }

            if (useProd)
            {
                return "Dmu.finance@mitie.com";
            }
            else
            {
                return testEmail;
            }
        }

        public string vfmDateTimeTzFix(DateTime dt)
        {
            dt = DateTime.SpecifyKind(dt, DateTimeKind.Local);
            DateTimeOffset utcTime2 = dt;
            return System.String.Format("{0}", utcTime2);
        }


        public DateTimeOffset vfmDateTimeTz(DateTime d)
        {
            DateTime dt = DateTime.SpecifyKind(d, DateTimeKind.Local);
            DateTimeOffset utcTime2 = dt;
            return utcTime2;
        }

        public DateTime vfmNoShiftDt(DateTime d)
        {
            string dt = d.ToString("yyyy-MM-dd HH:mm:ss");
            return System.Convert.ToDateTime(dt);
        }

        public string SafeMessageNoteClassA(int a, String b, String c, String d, String e, int f, String g, String h, String i, String j, bool k, bool l)
        {
            // a = visit id
            // b-d = address
            // e = postcode
            // f visit type code - 
            // g visit type desc - 
            // h case reference
            // i call out notes
            // j post-calloutnotes
            //

            string tmp = string.Empty, address = string.Empty, status = string.Empty, notes = string.Empty, isUrgent = string.Empty, isDeleted = string.Empty;
            address = string.Format("{0}, {1}, {2}, {3}", b, c, d, e);
            if (f == 5) 
            { 
                status = String.Format("{0} - Open", g);
                notes = i; //callout notes
            } 
            else 
            { 
                status = String.Format("{0} - Complete", g);
                notes = j; //post-callout notes
            }

            if (k == true)
            {
                isUrgent = "Urgent: Visit is flagged as urgent";
            }
            if (l == true)
            {
                isDeleted = "Deleted: The visit was deleted in SAFE";
            }

            tmp = String.Format("VisitId: {0}\r\nCase: {3}\r\nWorks Address: {1}\r\nVisit Status: {2}\r\n{5}\r\n{6}\r\n\r\nNotes: {4}", System.Convert.ToString(a), address, status, h, notes, isUrgent, isDeleted);

            return tmp;
        }

        public void SendMail(string DataXML, string XSLFileName, string ToEMailAddress, string CCEMailAddress, string FromEMailAddress,string MailServer) 
        { 
            string XML = GetFormattedXml(DataXML, XSLFileName); 
            XmlDocument xDoc = new XmlDocument(); 
            xDoc.LoadXml(XML);
            
            System.Net.Mail.MailMessage oMail = new System.Net.Mail.MailMessage();
            
            MailAddress from = new MailAddress(FromEMailAddress, "VisionFM");
            MailAddress to = new MailAddress(ToEMailAddress, "MLA");
            MailMessage message = new MailMessage(from, to);

            oMail.Subject = xDoc.SelectSingleNode("//subject").InnerText; 
            oMail.Body = xDoc.SelectSingleNode("//messagebody").InnerXml; 
            oMail.BodyEncoding = System.Text.Encoding.UTF8;
            oMail.IsBodyHtml = true;

            SmtpClient client = new SmtpClient(MailServer);
            client.Send(oMail);
            xDoc = null; 
        }
        
        private string GetFormattedXml(string XML, string XSLFileName) 
        { 
            System.Xml.Xsl.XslTransform xslt = new System.Xml.Xsl.XslTransform(); 
            xslt.Load(XSLFileName); 
            System.IO.StringWriter stringWriter = new System.IO.StringWriter(); 
            XmlDocument xDoc = new XmlDocument(); 
            xDoc.LoadXml(XML); 
            xslt.Transform(xDoc, null, stringWriter); 
            return stringWriter.ToString(); 
        }
        
        private string GetFormattedXml(string XML, string XSLFileName, System.Xml.Xsl.XsltArgumentList Arg) 
        { 
            System.Xml.Xsl.XslTransform xslt = new System.Xml.Xsl.XslTransform(); 
            xslt.Load(XSLFileName); 
            System.IO.StringWriter stringWriter = new System.IO.StringWriter(); 
            XmlDocument xDoc = new XmlDocument(); 
            xDoc.LoadXml(XML); 
            xslt.Transform(xDoc, Arg, stringWriter); 
            return stringWriter.ToString(); 
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="SysName">The source system example BIZTALK</param>
        /// <param name="IsError">Injects INFO or ERROR message for False or True respectively</param>
        /// <param name="CaseRef">The VisionFM case reference to create the communciation against</param>
        /// <param name="EmailHdr">Error comms send an email also, this param sets a header text</param>
        /// <returns></returns>
        public string getBizTalkComm(string SysName,string Stage,string CaseRef,string EmailHdr,string L6,string L7,string L8,string Customer, string MsgText, string L12)
        {
            string biz_comm_str = System.String.Format("<ns0:Biz_comm xmlns:ns0='http://MFM.Lbg.Schemas.BizTalk_Comm'>");
            biz_comm_str = biz_comm_str + System.String.Format("<L1>{0}</L1>", SysName);
            biz_comm_str = biz_comm_str + System.String.Format("<L2>{0}</L2>", Stage);
            biz_comm_str = biz_comm_str + System.String.Format("<L3>{0}</L3>", CaseRef);
            biz_comm_str = biz_comm_str + System.String.Format("<L4>{0}</L4>", EmailHdr);
            biz_comm_str = biz_comm_str + System.String.Format("<L5>{0}</L5>", System.DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss"));
            biz_comm_str = biz_comm_str + System.String.Format("<L6>{0}</L6>", L6);
            biz_comm_str = biz_comm_str + System.String.Format("<L7>{0}</L7>", L7);
            biz_comm_str = biz_comm_str + System.String.Format("<L8>{0}</L8>", L8);
            biz_comm_str = biz_comm_str + System.String.Format("<L10>{0}</L10>", Customer);
            biz_comm_str = biz_comm_str + System.String.Format("<L11><![CDATA[{0}]]></L11>", MsgText);
            biz_comm_str = biz_comm_str + System.String.Format("<L12>{0}</L12>", L12);
            biz_comm_str = biz_comm_str + System.String.Format("</ns0:Biz_comm>");

            return biz_comm_str;
        }


        public bool IsOutOfHours()
        {
            bool r = true;
            Int32 h = DateTime.Now.Hour;

            if ((h > 7 && h < 18) && (DateTime.Now.DayOfWeek != DayOfWeek.Saturday) && (DateTime.Now.DayOfWeek != DayOfWeek.Sunday))
            {
                r = false;
            }
            
            return r;
        }

        public Guid GetGuid()
        {
            return Guid.NewGuid();
        }

        public String GetNullString()
        {
            string nullstring = string.Empty;
            return nullstring;
        }

        public Nullable<DateTime> GetNullDate()
        {
            Nullable<DateTime> nulldatetime;
            nulldatetime = null;
            return nulldatetime;
        }

        public string CleanNilString(string note)
        {
            if (String.IsNullOrEmpty(note))
            {
                return "";
            }
            else
            {
                return note;
            }
        }

        public string QualifyReasonCode(string Status, string ReasonCode)
        {
            List<string> SupportedStatusList = new List<string>();
            SupportedStatusList.Add("INPRG");
            SupportedStatusList.Add("SUSPEND");
            SupportedStatusList.Add("REJECT");
            SupportedStatusList.Add("CANCEL");

            if (SupportedStatusList.Contains(Status))
            {
                return ReasonCode;
            }
            else
            {
                return "";        
            }

        }

        public string MaximoStatusNote(string status, string statusTs, string wonum, string customerref, string worktype, string schedstart, string schedFinish, string ActualStart, string ActualFinish, string note, string reason)
        {
            StringBuilder r = new StringBuilder();
            try
            {
                if (!String.IsNullOrEmpty(reason))
                {
                    r.AppendFormat("Status: {0} ({1})\r\n", status, reason);
                }
                else
                {
                    r.AppendFormat("Status: {0}\r\n",status);
                }
                
                r.AppendFormat("System: MTFMMXO75 at {0}\r\n", statusTs);
                r.AppendFormat("Workorder: {0} Case Reference: {1}\r\n", wonum, customerref);
                r.AppendFormat("WorkType: {0}\r\n",  worktype);
                if(!String.IsNullOrEmpty(schedstart)){r.AppendFormat("Sched Start: {0}\r\n", schedstart);}
                if(!String.IsNullOrEmpty(schedFinish)){r.AppendFormat("Sched Finish: {0}\r\n", schedFinish);}
                if(!String.IsNullOrEmpty(ActualStart)){r.AppendFormat("Actual Start: {0}\r\n", ActualStart);}
                if(!String.IsNullOrEmpty(ActualFinish)){r.AppendFormat("Actual Finish: {0}\r\n", ActualFinish);}
                r.AppendFormat("\r\nNote: {0}\r\n", note);
                if(!String.IsNullOrEmpty(reason)){r.AppendFormat("\r\nReason: {0}\r\n", reason);}
            }
            catch(Exception e)
            {
                r.AppendFormat("BizTalk Error: {0}\r\n",e.Message);
            }

            return r.ToString();
        }

        public string MaximoWorkLogNote(string summary, string detail, string wtype, string ModBy, string ModTs, string Logid)
        {
            StringBuilder r = new StringBuilder();
            try
            {
                detail = StripFormatting(detail);
                r.AppendFormat("{0}\r\n{1}\r\n\r\n", summary.ToString(), detail.Replace(@"<br />","\r\n").Replace("<!-- RICH TEXT -->","").Replace(@"<div style=""width:1px""></div>","").ToString());
                r.AppendFormat("[{0}]\r\n", AppendStringDataAlways(wtype, "Log Type"));
                r.AppendFormat("[{0}]\r\n", AppendStringDataAlways(ModBy, "Last Modified By"));
                r.AppendFormat("[{0}]\r\n", AppendStringDataAlways(ModTs, "Last Modified"));
                r.AppendFormat("[{0}]\r\n", AppendStringDataAlways(Logid, "Log id"));
            }
            catch (Exception e)
            {
                r.AppendFormat("BizTalk Error: {0}\r\n", e.Message);
            }
            return r.ToString();
        }

        private static string AppendStringDataAlways(string theString, string theTag)
        {
            StringBuilder r = new StringBuilder();
            if (!String.IsNullOrEmpty(theString)) { r.AppendFormat("{0}: {1}", theTag, theString); }
            return r.ToString();
        }

        //public string ConvertHtmlTableToText(string TextBody)
        //{
        //    String r = TextBody;
        //    const string RegexPattern = "<[Tt][Aa][Bb][Ll][Ee]>.*</[Tt][Aa][Bb][Ll][Ee]>";
        //    try
        //    {

        //        return r;
        //    }
        //    catch (Exception e)
        //    {

        //    }
        //    finally
        //    {

        //    }

        //    return r;
        //}

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

        /// <summary>
        /// Indicate if BizTalk production environment
        /// </summary>
        /// <returns></returns>
        private static Boolean EnvChecker()
        {
            string host = System.Net.Dns.GetHostName().ToLower();
            Boolean useProd = false;
            if (host == "miti-msl-vm-41" || host == "MITI-W-INT-0107" || host == "mitie-com-106" || host == "mitie-com-105")
            {
                useProd = true;
            }
            return useProd;
        }


        ///Switch out stage
        public bool skipStatus(int providerId, string stage)
        {
            bool result = false;
            List<string> SkipStages = new List<string>();
            //SkipStages.Add("SUSPEND");
            //SkipStages.Add("CAN");
            //SkipStages.Add("REJECT");

            if( (SkipStages.Contains(stage)) && (providerId == 19009) )
            {
                result = true;
            }

            return result;
        }

        
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private static String SqlClientVisionFM()
        {
            if(EnvChecker())
            {
                return GetConnString("mitie-sql7-01", "MFM_Helpdesk", "MFM.Helpdesk.Distributor");
            }
            else
            {
                switch (System.Net.Dns.GetHostName().ToLower())
                {
                    case "csvmg07-sv":
                        return GetConnString("mitie-com-19", "MFM_Helpdesk_Rad", "MFM.Helpdesk.Distributor");
                    default:
                        return GetConnString("mitie-com-19", "MFM_HELPDESK_SUPPORT", "MFM.Helpdesk.Distributor");
                }

            }
        }
         
        /// <summary>
        /// 
        /// </summary>
        /// <param name="AssetXml"></param>
        /// <returns></returns>
        public bool CreateNewAsset(ref XmlDocument AssetXml)
        {
            
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(String.Format("Begin create new asset.", ""));

            bool result = false;
            String procedureName = "[ops].[Add_Asset]";

            sb.AppendLine(String.Format("Calling procedure {0}", procedureName));
            
            SqlParameter tab = new SqlParameter("@ASSETS", SqlDbType.Structured);
            SqlParameter IdSwitch = new SqlParameter("@GetIdValues", SqlDbType.Bit);
            SqlParameter userid = new SqlParameter("@BATCHUSER", SqlDbType.Int);
            SqlParameter msg = new SqlParameter("@msg", SqlDbType.VarChar);
            SqlParameter r = new SqlParameter("@return", SqlDbType.Int);

            try
            {
                r.Direction = ParameterDirection.ReturnValue;
                msg.Direction = ParameterDirection.Output;
                IdSwitch.Direction = ParameterDirection.Input;
                tab.Direction = ParameterDirection.Input;
                userid.Direction = ParameterDirection.Input;

                msg.Size = 500;

                userid.Value = 13442;
                IdSwitch.Value = 1;

                sb.AppendLine(String.Format("Userid:{0}", userid.Value.ToString()));
                sb.AppendLine(String.Format("Request Sage Primary keys: {0}", IdSwitch.Value.ToString()));

                XmlNodeReader reader = new XmlNodeReader(AssetXml);
                DataSet ds = new DataSet();
                ds.ReadXml(reader);
                tab.Value = ds.Tables[0].Copy();
                tab.TypeName = "ops.udtt_Asset";

                sb.AppendLine(String.Format("Message: {0}", ds.Tables[0].Rows[0].Field<String>("asst_TrackingNote")));
                sb.AppendLine(String.Format("Asset Ref: {0}", ds.Tables[0].Rows[0].Field<String>("asst_ForeignSysId")));
                sb.AppendLine(String.Format("Asset Description: {0}", ds.Tables[0].Rows[0].Field<String>("asst_Description")));
                sb.AppendLine(String.Format("Asset SubType: {0}", ds.Tables[0].Rows[0].Field<String>("asst_SubType")));

                
                using (SqlConnection conn = new SqlConnection(SqlClientVisionFM()))
                {
                    conn.Open();
                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = conn;
                        command.CommandType = CommandType.StoredProcedure;
                        command.CommandText = procedureName;
                        command.CommandTimeout = 30;
                        command.Parameters.Add(r);
                        command.Parameters.Add(msg);
                        command.Parameters.Add(IdSwitch);
                        command.Parameters.Add(userid);
                        command.Parameters.Add(tab);
                        command.ExecuteNonQuery();

                        if (Convert.ToInt32(command.Parameters["@return"].Value) == 0)
                        {
                            result = true;
                            sb.AppendLine(String.Format("Asset created: {0}", result.ToString()));
                        }
                        else
                        {
                            EventLog.WriteEntry("MFM.Helpdesk.Distributor", String.Format("Stored procedure {2} returned an error, called by method CreateNewAsset failed to create Asset.\r\nReturnValue: {0}\r\nError: {1}\r\nConn: {3}", command.Parameters["@return"].Value.ToString(), command.Parameters["@msg"].Value.ToString(), procedureName, SqlClientVisionFM()), EventLogEntryType.Error);
                        }
                    }
                }
            }
            catch (System.Data.SqlClient.SqlException e)
            {
                EventLog.WriteEntry("MFM.Helpdesk.Distributor", String.Format("Failure calling Stored procedure {2}, called by method CreateNewAsset failed to create Asset.. Error: {0}\r\nStack: {1}\r\nConn: {3}", e.Message, e.StackTrace, procedureName, SqlClientVisionFM()), EventLogEntryType.Error);
            }
            catch (System.Exception e)
            {
                EventLog.WriteEntry("MFM.Helpdesk.Distributor", String.Format("Failure in method CreateNewAsset failed to create Asset. Error: {0}\r\nStack: {1}", e.Message, e.StackTrace), EventLogEntryType.Error);
            }
            finally
            {
                //EventLog.WriteEntry("MFM.Helpdesk.Distributor", sb.ToString(), EventLogEntryType.Information);
            }

            return result;
        }


        public bool LoadWorkItemMessageStore(ref XmlDocument WimsUdtt)
        {
            
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(String.Format("Begin Load WiMS.", ""));

            bool result = false;
            String procedureName = "[ops].[Add_WorkItemMessageStore]";

            sb.AppendLine(String.Format("Calling procedure {0}", procedureName));
            
            SqlParameter tab = new SqlParameter("@wims", SqlDbType.Structured);
            SqlParameter userid = new SqlParameter("@BATCHUSER", SqlDbType.Int);
            SqlParameter msg = new SqlParameter("@msg", SqlDbType.VarChar);
            SqlParameter r = new SqlParameter("@return", SqlDbType.Int);

            try
            {
                r.Direction = ParameterDirection.ReturnValue;
                msg.Direction = ParameterDirection.Output;
                tab.Direction = ParameterDirection.Input;
                userid.Direction = ParameterDirection.Input;

                msg.Size = 500;

                userid.Value = 13442;

                sb.AppendLine(String.Format("Userid:{0}", userid.Value.ToString()));

                //XmlNodeReader reader = new XmlNodeReader(WimsUdtt);
                DataTable ds = UpdateTable.GetDataSetFromXmlDoc(WimsUdtt);
                //ds.ReadXml(reader);
                tab.Value = ds;
                tab.TypeName = "ops.udtt_WorkItemMessageStore";

                //sb.AppendLine(String.Format("Message: {0}", ds.Tables[0].Rows[0].Field<String>("asst_TrackingNote")));
                //sb.AppendLine(String.Format("Asset Ref: {0}", ds.Tables[0].Rows[0].Field<String>("asst_ForeignSysId")));
                //sb.AppendLine(String.Format("Asset Description: {0}", ds.Tables[0].Rows[0].Field<String>("asst_Description")));
                //sb.AppendLine(String.Format("Asset SubType: {0}", ds.Tables[0].Rows[0].Field<String>("asst_SubType")));

                
                using (SqlConnection conn = new SqlConnection(SqlClientVisionFM()))
                {
                    conn.Open();
                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = conn;
                        command.CommandType = CommandType.StoredProcedure;
                        command.CommandText = procedureName;
                        command.CommandTimeout = 90;
                        command.Parameters.Add(r);
                        command.Parameters.Add(msg);
                        command.Parameters.Add(userid);
                        command.Parameters.Add(tab);
                        command.ExecuteNonQuery();

                        if (Convert.ToInt32(command.Parameters["@return"].Value) == 0)
                        {
                            result = true;
                            sb.AppendLine(String.Format("WiMS staged: {0}", result.ToString()));
                        }
                        else
                        {
                            EventLog.WriteEntry("MFM.Helpdesk.Distributor", String.Format("Stored procedure {2} returned an error, called by method LoadWorkItemMessageStore failed to create WiMS.\r\nReturnValue: {0}\r\nError: {1}\r\nConn: {3}", command.Parameters["@return"].Value.ToString(), command.Parameters["@msg"].Value.ToString(), procedureName, SqlClientVisionFM()), EventLogEntryType.Error);
                        }
                    }
                }
            }
            catch (System.Data.SqlClient.SqlException e)
            {
                EventLog.WriteEntry("MFM.Helpdesk.Distributor", String.Format("Failure calling Stored procedure {2}, called by method LoadWorkItemMessageStore failed to create WiMS.. Error: {0}\r\nStack: {1}\r\nConn: {3}", e.Message, e.StackTrace, procedureName, SqlClientVisionFM()), EventLogEntryType.Error);
            }
            catch (System.Exception e)
            {
                EventLog.WriteEntry("MFM.Helpdesk.Distributor", String.Format("Failure in method LoadWorkItemMessageStore failed to create WiMS. Error: {0}\r\nStack: {1}", e.Message, e.StackTrace), EventLogEntryType.Error);
            }
            finally
            {
                //EventLog.WriteEntry("MFM.Helpdesk.Distributor", sb.ToString(), EventLogEntryType.Information);
            }

            return result;
        }

        /// <summary>
        /// Return a constructed XML message with associated attachment
        /// </summary>
        /// <param name="AttachXml"></param>
        /// <returns></returns>
        public XmlDocument NotifyConstructMsg(XmlDocument AttachXml)
        {
            XmlDocument msg = new XmlDocument();
            String Attach = XmlDocToBase64String(AttachXml);
            String MsgId = GetElementInnerXml(AttachXml, "SourceSystemMessageId");
            String MsgLocation = GetElementInnerXml(AttachXml, "WI_LocationLevel1");
            String MsgBuilding = GetElementInnerXml(AttachXml, "WI_LocationLevel3");
            String MsgWonum = GetElementInnerXml(AttachXml, "WI_SourceRef");
            String MsgStatus = GetElementInnerXml(AttachXml, "WI_Status");
            String MsgFirstStatus = GetElementInnerXml(AttachXml, "WI_ServiceLevel3");
            String strTs = System.DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss"); //1999-05-31T13:20:00.000-05:00
            String strTo = "Tony.Arrighi@mitie.com;Andrew.Melvin@mitie.com";
            String Subject = String.Format("Capita PM {3} Message Failed, location {0} status {1} ({2})", MsgLocation, MsgStatus, MsgFirstStatus, MsgWonum);
            String p1 = String.Format("The Location building {0} was not recognised in VisionFM.  This message can not be processed.",MsgBuilding);
            StringBuilder p2 = new StringBuilder();
            p2.AppendFormat("Workorder: {0}\r\n", MsgWonum);
            p2.AppendFormat("Location: {0}\r\n", MsgLocation);
            p2.AppendFormat("Building: {0}\r\n", MsgBuilding);
            p2.Append("The workorder will not appear or be updated in VisionFM until the building matches MiAMI data.  Once the building exists you can request the message be resumed.");

            String msgString = string.Empty;
            SetWorkItemNotifyAlert(ref msgString, msg, Attach, MsgId, strTs, strTo, Subject,p1,p2.ToString());
            
            return msg;

        }

        /// <summary>
        /// Dirty XML string
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="Attach"></param>
        /// <param name="MsgId"></param>
        /// <param name="strTs"></param>
        /// <param name="strTo"></param>
        private static void SetWorkItemNotifyAlert(ref String msgString, XmlDocument msg, String Attach, String MsgId, String strTs, String strTo, string Subject,String p1, String p2)
        {
            msgString = String.Format(@"

<ns0:MSSNotifyEmail xmlns:ns0=""http://MSS.Notification.Service.NotifyEmail/v1"">
  <ApplicationName>{0}</ApplicationName>
  <CreatedTs>{1}</CreatedTs>
  <SmtpHost>mailrelay.mitie.com</SmtpHost>
  <SmtpPort>25</SmtpPort>
  <Retry>5</Retry>
  <EmailMetaData>
    <To>{2}</To>
    <From>no.reply@mitie.com</From>
    <Subject>{5}</Subject>
    <HighImportance>false</HighImportance>
  </EmailMetaData>
  <EmailContentData>
    <BodyType>plain</BodyType>
    <BodyEncoding>UTF8</BodyEncoding>
    <BodyNonRecurring>
      <P1>{6}</P1>
      <P2>{7}</P2>
      <P3></P3>
      <P4></P4>
      <P5></P5>
    </BodyNonRecurring>
  </EmailContentData>
  <Attachments>
    <Count>1</Count>
    <Attachment>
      <Base64String>{3}</Base64String>
      <AttachmentName>Capita_PM_{4}.xml</AttachmentName>
    </Attachment>
  </Attachments>
  <ErrorHandle>
    <SuspendTs>{1}</SuspendTs>
    <EmailDidError>0</EmailDidError>
  </ErrorHandle>
</ns0:MSSNotifyEmail>", "MFM.Helpdesk.Distributor", strTs, strTo, Attach, MsgId, Subject, p1, p2);

            msg.LoadXml(msgString);
        }

        //FetchFromWI_Schema
        private static string GetElementInnerXml(XmlDocument AttachXml, String ElementName)
        {
            string output = string.Empty;
            try
            {
                output = AttachXml.SelectSingleNode(String.Format(@"/*[local-name()='MFMWorkItemUpdate' and namespace-uri()='http://MFM.Lbg.Schemas.MFMWorkItemUpdate']/*[local-name()='{0}' and namespace-uri()='']", ElementName)).InnerText.ToString();
            }
            catch
            {
               //do nothing
            }
            return output;
        }

    
    }

    [System.Serializable]
    public class UpdateTable
    {
        public static DataTable GetDataSetFromXmlDoc(XmlDocument doc)
        {
            NewDataSet data = new NewDataSet();

            XmlNamespaceManager nsmgr = new XmlNamespaceManager(doc.NameTable);
            nsmgr.AddNamespace("ns0", "http://schemas.microsoft.com/Sql/2008/05/Types/TableTypes/ops");

            XPathNodeIterator nodes = doc.CreateNavigator().Select("//ns0:udtt_WorkItemMessageStore", nsmgr);

            while (nodes.MoveNext())
            {
                NewDataSet.udtt_WorkItemMessageStoreRow row = data.udtt_WorkItemMessageStore.Newudtt_WorkItemMessageStoreRow();
                XPathNavigator curNode = nodes.Current;
                XPathNavigator node = null;

                //WiMS_WorkItemMessageId
                node = curNode.SelectSingleNode("ns0:WiMS_WorkItemMessageId", nsmgr);

                if (node != null)
                {
                    if (!String.IsNullOrEmpty(node.Value))
                    {
                        row.WiMS_WorkItemMessageId = node.Value;
                    }
                    else
                    {
                        row.SetWiMS_WorkItemMessageIdNull();
                    }
                }
                else
                {
                    row.SetWiMS_WorkItemMessageIdNull();
                }

                //WiMS_CreatedBy
                node = curNode.SelectSingleNode("ns0:WiMS_CreatedBy", nsmgr);

                if (node != null)
                {
                    if (!String.IsNullOrEmpty(node.Value))
                    {
                        row.WiMS_CreatedBy = Convert.ToInt32(node.Value);
                    }
                    else
                    {
                        row.SetWiMS_CreatedByNull();
                    }
                }
                else
                {
                    row.SetWiMS_CreatedByNull();
                }

                //WiMS_CreatedDate
                node = curNode.SelectSingleNode("ns0:WiMS_CreatedDate", nsmgr);

                if (node != null)
                {
                    if (!String.IsNullOrEmpty(node.Value))
                    {
                        row.WiMS_CreatedDate = Convert.ToDateTime(node.Value);
                    }
                    else
                    {
                        row.SetWiMS_CreatedDateNull();
                    }
                }
                else
                {
                    row.SetWiMS_CreatedDateNull();
                }

                //WiMS_UpdatedBy
                node = curNode.SelectSingleNode("ns0:WiMS_UpdatedBy", nsmgr);

                if (node != null)
                {
                    if (!String.IsNullOrEmpty(node.Value))
                    {
                        row.WiMS_UpdatedBy = Convert.ToInt32(node.Value);
                    }
                    else
                    {
                        row.SetWiMS_UpdatedByNull();
                    }
                }
                else
                {
                    row.SetWiMS_UpdatedByNull();
                }

                //WiMS_UpdatedDate
                node = curNode.SelectSingleNode("ns0:WiMS_UpdatedDate", nsmgr);

                if (node != null)
                {
                    if (!String.IsNullOrEmpty(node.Value))
                    {
                        row.WiMS_UpdatedDate = Convert.ToDateTime(node.Value);
                    }
                    else
                    {
                        row.SetWiMS_UpdatedDateNull();
                    }
                }
                else
                {
                    row.SetWiMS_UpdatedDateNull();
                }

                //WiMS_Timestamp
                node = curNode.SelectSingleNode("ns0:WiMS_Timestamp", nsmgr);

                if (node != null)
                {
                    if (!String.IsNullOrEmpty(node.Value))
                    {
                        row.WiMS_Timestamp = Convert.ToDateTime(node.Value);
                    }
                    else
                    {
                        row.SetWiMS_TimestampNull();
                    }
                }
                else
                {
                    row.SetWiMS_TimestampNull();
                }

                //WiMS_Deleted
                node = curNode.SelectSingleNode("ns0:WiMS_Deleted", nsmgr);

                if (node != null)
                {
                    if (!String.IsNullOrEmpty(node.Value))
                    {
                        row.WiMS_Deleted = Convert.ToInt32(node.Value);
                    }
                    else
                    {
                        row.SetWiMS_DeletedNull();
                    }
                }
                else
                {
                    row.SetWiMS_DeletedNull();
                }

                //WiMS_PollingStatus
                node = curNode.SelectSingleNode("ns0:WiMS_PollingStatus", nsmgr);

                if (node != null)
                {
                    if (!String.IsNullOrEmpty(node.Value))
                    {
                        row.WiMS_PollingStatus = node.Value;
                    }
                    else
                    {
                        row.SetWiMS_PollingStatusNull();
                    }
                }
                else
                {
                    row.SetWiMS_PollingStatusNull();
                }

                //WiMS_PollingTs
                node = curNode.SelectSingleNode("ns0:WiMS_PollingTs", nsmgr);

                if (node != null)
                {
                    if (!String.IsNullOrEmpty(node.Value))
                    {
                        row.WiMS_PollingTs = Convert.ToDateTime(node.Value);
                    }
                    else
                    {
                        row.SetWiMS_PollingTsNull();
                    }
                }
                else
                {
                    row.SetWiMS_PollingTsNull();
                }

                //WiMS_SourceSystem
                node = curNode.SelectSingleNode("ns0:WiMS_SourceSystem", nsmgr);

                if (node != null)
                {
                    if (!String.IsNullOrEmpty(node.Value))
                    {
                        row.WiMS_SourceSystem = node.Value;
                    }
                    else
                    {
                        row.SetWiMS_SourceSystemNull();
                    }
                }
                else
                {
                    row.SetWiMS_SourceSystemNull();
                }

                //WiMS_SourceSystemMessageID
                node = curNode.SelectSingleNode("ns0:WiMS_SourceSystemMessageID", nsmgr);

                if (node != null)
                {
                    if (!String.IsNullOrEmpty(node.Value))
                    {
                        row.WiMS_SourceSystemMessageID = node.Value;
                    }
                    else
                    {
                        row.SetWiMS_SourceSystemMessageIDNull();
                    }
                }
                else
                {
                    row.SetWiMS_SourceSystemMessageIDNull();
                }

                //WiMS_SourceSystemMessageTs
                node = curNode.SelectSingleNode("ns0:WiMS_SourceSystemMessageTs", nsmgr);

                if (node != null)
                {
                    if (!String.IsNullOrEmpty(node.Value))
                    {
                        row.WiMS_SourceSystemMessageTs = Convert.ToDateTime(node.Value);
                    }
                    else
                    {
                        row.SetWiMS_SourceSystemMessageTsNull();
                    }
                }
                else
                {
                    row.SetWiMS_SourceSystemMessageTsNull();
                }

                //WiMS_BizTalkMessageID
                node = curNode.SelectSingleNode("ns0:WiMS_BizTalkMessageID", nsmgr);

                if (node != null)
                {
                    if (!String.IsNullOrEmpty(node.Value))
                    {
                        row.WiMS_BizTalkMessageID = Convert.ToInt32(node.Value);
                    }
                    else
                    {
                        row.SetWiMS_BizTalkMessageIDNull();
                    }
                }
                else
                {
                    row.SetWiMS_BizTalkMessageIDNull();
                }

                //WiMS_BizTalkMessageTs
                node = curNode.SelectSingleNode("ns0:WiMS_BizTalkMessageTs", nsmgr);

                if (node != null)
                {
                    if (!String.IsNullOrEmpty(node.Value))
                    {
                        row.WiMS_BizTalkMessageTs = Convert.ToDateTime(node.Value);
                    }
                    else
                    {
                        row.SetWiMS_BizTalkMessageTsNull();
                    }
                }
                else
                {
                    row.SetWiMS_BizTalkMessageTsNull();
                }

                //WiMS_CaseCallType
                node = curNode.SelectSingleNode("ns0:WiMS_CaseCallType", nsmgr);

                if (node != null)
                {
                    if (!String.IsNullOrEmpty(node.Value))
                    {
                        row.WiMS_CaseCallType = node.Value;
                    }
                    else
                    {
                        row.SetWiMS_CaseCallTypeNull();
                    }
                }
                else
                {
                    row.SetWiMS_CaseCallTypeNull();
                }

                //WiMS_UpdateTs
                node = curNode.SelectSingleNode("ns0:WiMS_UpdateTs", nsmgr);

                if (node != null)
                {
                    if (!String.IsNullOrEmpty(node.Value))
                    {
                        row.WiMS_UpdateTs = Convert.ToDateTime(node.Value);
                    }
                    else
                    {
                        row.SetWiMS_UpdateTsNull();
                    }
                }
                else
                {
                    row.SetWiMS_UpdateTsNull();
                }

                //WiMS_ForeignSystemId
                node = curNode.SelectSingleNode("ns0:WiMS_ForeignSystemId", nsmgr);

                if (node != null)
                {
                    if (!String.IsNullOrEmpty(node.Value))
                    {
                        row.WiMS_ForeignSystemId = node.Value;
                    }
                    else
                    {
                        row.SetWiMS_ForeignSystemIdNull();
                    }
                }
                else
                {
                    row.SetWiMS_ForeignSystemIdNull();
                }

                //WiMS_CaseReferenceId
                node = curNode.SelectSingleNode("ns0:WiMS_CaseReferenceId", nsmgr);

                if (node != null)
                {
                    if (!String.IsNullOrEmpty(node.Value))
                    {
                        row.WiMS_CaseReferenceId = node.Value;
                    }
                    else
                    {
                        row.SetWiMS_CaseReferenceIdNull();
                    }
                }
                else
                {
                    row.SetWiMS_CaseReferenceIdNull();
                }

                //WiMS_ServiceLevel1
                node = curNode.SelectSingleNode("ns0:WiMS_ServiceLevel1", nsmgr);

                if (node != null)
                {
                    if (!String.IsNullOrEmpty(node.Value))
                    {
                        row.WiMS_ServiceLevel1 = node.Value;
                    }
                    else
                    {
                        row.SetWiMS_ServiceLevel1Null();
                    }
                }
                else
                {
                    row.SetWiMS_ServiceLevel1Null();
                }

                //WiMS_ServiceLevel2
                node = curNode.SelectSingleNode("ns0:WiMS_ServiceLevel2", nsmgr);

                if (node != null)
                {
                    if (!String.IsNullOrEmpty(node.Value))
                    {
                        row.WiMS_ServiceLevel2 = node.Value;
                    }
                    else
                    {
                        row.SetWiMS_ServiceLevel2Null();
                    }
                }
                else
                {
                    row.SetWiMS_ServiceLevel2Null();
                }

                //WiMS_ServiceLevel3
                node = curNode.SelectSingleNode("ns0:WiMS_ServiceLevel3", nsmgr);

                if (node != null)
                {
                    if (!String.IsNullOrEmpty(node.Value))
                    {
                        row.WiMS_ServiceLevel3 = node.Value;
                    }
                    else
                    {
                        row.SetWiMS_ServiceLevel3Null();
                    }
                }
                else
                {
                    row.SetWiMS_ServiceLevel3Null();
                }

                //WiMS_AssetRef
                node = curNode.SelectSingleNode("ns0:WiMS_AssetRef", nsmgr);

                if (node != null)
                {
                    if (!String.IsNullOrEmpty(node.Value))
                    {
                        row.WiMS_AssetRef = node.Value;
                    }
                    else
                    {
                        row.SetWiMS_AssetRefNull();
                    }
                }
                else
                {
                    row.SetWiMS_AssetRefNull();
                }

                //WiMS_LocationLevel1
                node = curNode.SelectSingleNode("ns0:WiMS_LocationLevel1", nsmgr);

                if (node != null)
                {
                    if (!String.IsNullOrEmpty(node.Value))
                    {
                        row.WiMS_LocationLevel1 = node.Value;
                    }
                    else
                    {
                        row.SetWiMS_LocationLevel1Null();
                    }
                }
                else
                {
                    row.SetWiMS_LocationLevel1Null();
                }

                //WiMS_LocationLevel2
                node = curNode.SelectSingleNode("ns0:WiMS_LocationLevel2", nsmgr);

                if (node != null)
                {
                    if (!String.IsNullOrEmpty(node.Value))
                    {
                        row.WiMS_LocationLevel2 = node.Value;
                    }
                    else
                    {
                        row.SetWiMS_LocationLevel2Null();
                    }
                }
                else
                {
                    row.SetWiMS_LocationLevel2Null();
                }

                //WiMS_LocationLevel3
                node = curNode.SelectSingleNode("ns0:WiMS_LocationLevel3", nsmgr);

                if (node != null)
                {
                    if (!String.IsNullOrEmpty(node.Value))
                    {
                        row.WiMS_LocationLevel3 = node.Value;
                    }
                    else
                    {
                        row.SetWiMS_LocationLevel3Null();
                    }
                }
                else
                {
                    row.SetWiMS_LocationLevel3Null();
                }

                //WiMS_LocationLevel4
                node = curNode.SelectSingleNode("ns0:WiMS_LocationLevel4", nsmgr);

                if (node != null)
                {
                    if (!String.IsNullOrEmpty(node.Value))
                    {
                        row.WiMS_LocationLevel4 = node.Value;
                    }
                    else
                    {
                        row.SetWiMS_LocationLevel4Null();
                    }
                }
                else
                {
                    row.SetWiMS_LocationLevel4Null();
                }

                //WiMS_Status
                node = curNode.SelectSingleNode("ns0:WiMS_Status", nsmgr);

                if (node != null)
                {
                    if (!String.IsNullOrEmpty(node.Value))
                    {
                        row.WiMS_Status = node.Value;
                    }
                    else
                    {
                        row.SetWiMS_StatusNull();
                    }
                }
                else
                {
                    row.SetWiMS_StatusNull();
                }

                //WiMS_StatusChange
                node = curNode.SelectSingleNode("ns0:WiMS_StatusChange", nsmgr);

                if (node != null)
                {
                    if (!String.IsNullOrEmpty(node.Value))
                    {
                        row.WiMS_StatusChange = Convert.ToDateTime(node.Value);
                    }
                    else
                    {
                        row.SetWiMS_StatusChangeNull();
                    }
                }
                else
                {
                    row.SetWiMS_StatusChangeNull();
                }

                //WiMS_StatusChangeNote
                node = curNode.SelectSingleNode("ns0:WiMS_StatusChangeNote", nsmgr);

                if (node != null)
                {
                    if (!String.IsNullOrEmpty(node.Value))
                    {
                        row.WiMS_StatusChangeNote = node.Value;
                    }
                    else
                    {
                        row.SetWiMS_StatusChangeNoteNull();
                    }
                }
                else
                {
                    row.SetWiMS_StatusChangeNoteNull();
                }

                //WiMS_Priority
                node = curNode.SelectSingleNode("ns0:WiMS_Priority", nsmgr);

                if (node != null)
                {
                    if (!String.IsNullOrEmpty(node.Value))
                    {
                        row.WiMS_Priority = node.Value;
                    }
                    else
                    {
                        row.SetWiMS_PriorityNull();
                    }
                }
                else
                {
                    row.SetWiMS_PriorityNull();
                }

                ////WiMS_KpiStartTs
                //node = curNode.SelectSingleNode("ns0:WiMS_KpiStartTs", nsmgr);

                //if (node != null)
                //{
                //    if (!String.IsNullOrEmpty(node.Value))
                //    {
                //        row.WiMS_KpiStartTs = Convert.ToDateTime(node.Value);
                //    }
                //    else
                //    {
                //        row.SetWiMS_KpiStartTsNull();
                //    }
                //}
                //else
                //{
                //    row.SetWiMS_KpiStartTsNull();
                //}


                //WiMS_CaseCPAcknowledge
                node = curNode.SelectSingleNode("ns0:WiMS_CaseCPAcknowledge", nsmgr);

                if (node != null)
                {
                    if (!String.IsNullOrEmpty(node.Value))
                    {
                        row.WiMS_CaseCPAcknowledge = Convert.ToDateTime(node.Value);
                    }
                    else
                    {
                        row.SetWiMS_CaseCPAcknowledgeNull();
                    }
                }
                else
                {
                    row.SetWiMS_CaseCPAcknowledgeNull();
                }


                //WiMS_CaseCPAllocate
                node = curNode.SelectSingleNode("ns0:WiMS_CaseCPAllocate", nsmgr);

                if (node != null)
                {
                    if (!String.IsNullOrEmpty(node.Value))
                    {
                        row.WiMS_CaseCPAllocate = Convert.ToDateTime(node.Value);
                    }
                    else
                    {
                        row.SetWiMS_CaseCPAllocateNull();
                    }
                }
                else
                {
                    row.SetWiMS_CaseCPAllocateNull();
                }

                ////WiMS_KpiConfirmTs
                //node = curNode.SelectSingleNode("ns0:WiMS_KpiConfirmTs", nsmgr);

                //if (node != null)
                //{
                //    if (!String.IsNullOrEmpty(node.Value))
                //    {
                //        row.WiMS_KpiConfirmTs = Convert.ToDateTime(node.Value);
                //    }
                //    else
                //    {
                //        row.SetWiMS_KpiConfirmTsNull();
                //    }
                //}
                //else
                //{
                //    row.SetWiMS_KpiConfirmTsNull();
                //}

                ////WiMS_ActualStartTs
                //node = curNode.SelectSingleNode("ns0:WiMS_ActualStartTs", nsmgr);

                //if (node != null)
                //{
                //    if (!String.IsNullOrEmpty(node.Value))
                //    {
                //        row.WiMS_ActualStartTs = Convert.ToDateTime(node.Value);
                //    }
                //    else
                //    {
                //        row.SetWiMS_ActualStartTsNull();
                //    }
                //}
                //else
                //{
                //    row.SetWiMS_ActualStartTsNull();
                //}

                //WiMS_CaseCPAttend
                node = curNode.SelectSingleNode("ns0:WiMS_CaseCPAttend", nsmgr);

                if (node != null)
                {
                    if (!String.IsNullOrEmpty(node.Value))
                    {
                        row.WiMS_CaseCPAttend = Convert.ToDateTime(node.Value);
                    }
                    else
                    {
                        row.SetWiMS_CaseCPAttendNull();
                    }
                }
                else
                {
                    row.SetWiMS_CaseCPAttendNull();
                }

                //WiMS_CaseCPComplete
                node = curNode.SelectSingleNode("ns0:WiMS_CaseCPComplete", nsmgr);

                if (node != null)
                {
                    if (!String.IsNullOrEmpty(node.Value))
                    {
                        row.WiMS_CaseCPComplete = Convert.ToDateTime(node.Value);
                    }
                    else
                    {
                        row.SetWiMS_CaseCPCompleteNull();
                    }
                }
                else
                {
                    row.SetWiMS_CaseCPCompleteNull();
                }


                //WiMS_CaseCPVerify
                node = curNode.SelectSingleNode("ns0:WiMS_CaseCPVerify", nsmgr);

                if (node != null)
                {
                    if (!String.IsNullOrEmpty(node.Value))
                    {
                        row.WiMS_CaseCPVerify = Convert.ToDateTime(node.Value);
                    }
                    else
                    {
                        row.SetWiMS_CaseCPVerifyNull();
                    }
                }
                else
                {
                    row.SetWiMS_CaseCPVerifyNull();
                }

                ////WiMS_ActualConfirmTs
                //node = curNode.SelectSingleNode("ns0:WiMS_ActualConfirmTs", nsmgr);

                //if (node != null)
                //{
                //    if (!String.IsNullOrEmpty(node.Value))
                //    {
                //        row.WiMS_ActualConfirmTs = Convert.ToDateTime(node.Value);
                //    }
                //    else
                //    {
                //        row.SetWiMS_ActualConfirmTsNull();
                //    }
                //}
                //else
                //{
                //    row.SetWiMS_ActualConfirmTsNull();
                //}

                //WiMS_CaseTimeAcknowledged
                node = curNode.SelectSingleNode("ns0:WiMS_CaseTimeAcknowledged", nsmgr);

                if (node != null)
                {
                    if (!String.IsNullOrEmpty(node.Value))
                    {
                        row.WiMS_CaseTimeAcknowledged = Convert.ToDateTime(node.Value);
                    }
                    else
                    {
                        row.SetWiMS_CaseTimeAcknowledgedNull();
                    }
                }
                else
                {
                    row.SetWiMS_CaseTimeAcknowledgedNull();
                }

                //WiMS_CaseTimeAllocated
                node = curNode.SelectSingleNode("ns0:WiMS_CaseTimeAllocated", nsmgr);

                if (node != null)
                {
                    if (!String.IsNullOrEmpty(node.Value))
                    {
                        row.WiMS_CaseTimeAllocated = Convert.ToDateTime(node.Value);
                    }
                    else
                    {
                        row.SetWiMS_CaseTimeAllocatedNull();
                    }
                }
                else
                {
                    row.SetWiMS_CaseTimeAllocatedNull();
                }

                //WiMS_CaseTimeAttended
                node = curNode.SelectSingleNode("ns0:WiMS_CaseTimeAttended", nsmgr);

                if (node != null)
                {
                    if (!String.IsNullOrEmpty(node.Value))
                    {
                        row.WiMS_CaseTimeAttended = Convert.ToDateTime(node.Value);
                    }
                    else
                    {
                        row.SetWiMS_CaseTimeAttendedNull();
                    }
                }
                else
                {
                    row.SetWiMS_CaseTimeAttendedNull();
                }

                //WiMS_CaseTimeCompleted
                node = curNode.SelectSingleNode("ns0:WiMS_CaseTimeCompleted", nsmgr);

                if (node != null)
                {
                    if (!String.IsNullOrEmpty(node.Value))
                    {
                        row.WiMS_CaseTimeCompleted = Convert.ToDateTime(node.Value);
                    }
                    else
                    {
                        row.SetWiMS_CaseTimeCompletedNull();
                    }
                }
                else
                {
                    row.SetWiMS_CaseCPCompleteNull();
                }

                //WiMS_CaseTimeVerified
                node = curNode.SelectSingleNode("ns0:WiMS_CaseTimeVerified", nsmgr);

                if (node != null)
                {
                    if (!String.IsNullOrEmpty(node.Value))
                    {
                        row.WiMS_CaseTimeVerified = Convert.ToDateTime(node.Value);
                    }
                    else
                    {
                        row.SetWiMS_CaseTimeVerifiedNull();
                    }
                }
                else
                {
                    row.SetWiMS_CaseTimeVerifiedNull();
                }
                
                //WiMS_PrimaryCompanyId
                node = curNode.SelectSingleNode("ns0:WiMS_PrimaryCompanyId", nsmgr);

                if (node != null)
                {
                    if (!String.IsNullOrEmpty(node.Value))
                    {
                        row.WiMS_PrimaryCompanyId = Convert.ToInt32(node.Value);
                    }
                    else
                    {
                        row.SetWiMS_PrimaryCompanyIdNull();
                    }
                }
                else
                {
                    row.SetWiMS_PrimaryCompanyIdNull();
                }

                //WiMS_PrimaryPersonId
                node = curNode.SelectSingleNode("ns0:WiMS_PrimaryPersonId", nsmgr);

                if (node != null)
                {
                    if (!String.IsNullOrEmpty(node.Value))
                    {
                        row.WiMS_PrimaryPersonId = Convert.ToInt32(node.Value);
                    }
                    else
                    {
                        row.SetWiMS_PrimaryPersonIdNull();
                    }
                }
                else
                {
                    row.SetWiMS_PrimaryPersonIdNull();
                }

                //WiMS_ClientDivisionId
                node = curNode.SelectSingleNode("ns0:WiMS_ClientDivisionId", nsmgr);

                if (node != null)
                {
                    if (!String.IsNullOrEmpty(node.Value))
                    {
                        row.WiMS_ClientDivisionId = Convert.ToInt32(node.Value);
                    }
                    else
                    {
                        row.SetWiMS_ClientDivisionIdNull();
                    }
                }
                else
                {
                    row.SetWiMS_ClientDivisionIdNull();
                }

                //WiMS_ClientRegionId
                node = curNode.SelectSingleNode("ns0:WiMS_ClientRegionId", nsmgr);

                if (node != null)
                {
                    if (!String.IsNullOrEmpty(node.Value))
                    {
                        row.WiMS_ClientRegionId = Convert.ToInt32(node.Value);
                    }
                    else
                    {
                        row.SetWiMS_ClientRegionIdNull();
                    }
                }
                else
                {
                    row.SetWiMS_ClientRegionIdNull();
                }

                //WiMS_LocationId
                node = curNode.SelectSingleNode("ns0:WiMS_LocationId", nsmgr);

                if (node != null)
                {
                    if (!String.IsNullOrEmpty(node.Value))
                    {
                        row.WiMS_LocationId = Convert.ToInt32(node.Value);
                    }
                    else
                    {
                        row.SetWiMS_LocationIdNull();
                    }
                }
                else
                {
                    row.SetWiMS_LocationIdNull();
                }

                //WiMS_ProviderCompanyId
                node = curNode.SelectSingleNode("ns0:WiMS_ProviderCompanyId", nsmgr);

                if (node != null)
                {
                    if (!String.IsNullOrEmpty(node.Value))
                    {
                        row.WiMS_ProviderCompanyId = Convert.ToInt32(node.Value);
                    }
                    else
                    {
                        row.SetWiMS_ProviderCompanyIdNull();
                    }
                }
                else
                {
                    row.SetWiMS_ProviderCompanyIdNull();
                }

                //WiMS_ProviderDivisionId
                node = curNode.SelectSingleNode("ns0:WiMS_ProviderDivisionId", nsmgr);

                if (node != null)
                {
                    if (!String.IsNullOrEmpty(node.Value))
                    {
                        row.WiMS_ProviderDivisionId = Convert.ToInt32(node.Value);
                    }
                    else
                    {
                        row.SetWiMS_ProviderDivisionIdNull();
                    }
                }
                else
                {
                    row.SetWiMS_ProviderDivisionIdNull();
                }

                //WiMS_ProviderPersonId
                node = curNode.SelectSingleNode("ns0:WiMS_ProviderPersonId", nsmgr);

                if (node != null)
                {
                    if (!String.IsNullOrEmpty(node.Value))
                    {
                        row.WiMS_ProviderPersonId = Convert.ToInt32(node.Value);
                    }
                    else
                    {
                        row.SetWiMS_ProviderPersonIdNull();
                    }
                }
                else
                {
                    row.SetWiMS_ProviderPersonIdNull();
                }


                //WiMS_ProviderLocationId
                node = curNode.SelectSingleNode("ns0:WiMS_ProviderLocationId", nsmgr);

                if (node != null)
                {
                    if (!String.IsNullOrEmpty(node.Value))
                    {
                        row.WiMS_ProviderLocationId = Convert.ToInt32(node.Value);
                    }
                    else
                    {
                        row.SetWiMS_ProviderLocationIdNull();
                    }
                }
                else
                {
                    row.SetWiMS_ProviderLocationIdNull();
                }

                //WiMS_BundleItemId
                node = curNode.SelectSingleNode("ns0:WiMS_BundleItemId", nsmgr);

                if (node != null)
                {
                    if (!String.IsNullOrEmpty(node.Value))
                    {
                        row.WiMS_BundleItemId = Convert.ToInt32(node.Value);
                    }
                    else
                    {
                        row.SetWiMS_BundleItemIdNull();
                    }
                }
                else
                {
                    row.SetWiMS_BundleItemIdNull();
                }

                //WiMS_LocationBundleItemId
                node = curNode.SelectSingleNode("ns0:WiMS_LocationBundleItemId", nsmgr);

                if (node != null)
                {
                    if (!String.IsNullOrEmpty(node.Value))
                    {
                        row.WiMS_LocationBundleItemId = Convert.ToInt32(node.Value);
                    }
                    else
                    {
                        row.SetWiMS_LocationBundleItemIdNull();
                    }
                }
                else
                {
                    row.SetWiMS_LocationBundleItemIdNull();
                }

                //WiMS_AuthoriserId
                node = curNode.SelectSingleNode("ns0:WiMS_AuthoriserId", nsmgr);

                if (node != null)
                {
                    if (!String.IsNullOrEmpty(node.Value))
                    {
                        row.WiMS_AuthoriserId = Convert.ToInt32(node.Value);
                    }
                    else
                    {
                        row.SetWiMS_AuthoriserIdNull();
                    }
                }
                else
                {
                    row.SetWiMS_AuthoriserIdNull();
                }

                //WiMS_CaseId
                node = curNode.SelectSingleNode("ns0:WiMS_CaseId", nsmgr);

                if (node != null)
                {
                    if (!String.IsNullOrEmpty(node.Value))
                    {
                        row.WiMS_CaseId = Convert.ToInt32(node.Value);
                    }
                    else
                    {
                        row.SetWiMS_CaseIdNull();
                    }
                }
                else
                {
                    row.SetWiMS_CaseIdNull();
                }

                //WiMS_ServiceStreamId
                node = curNode.SelectSingleNode("ns0:WiMS_ServiceStreamId", nsmgr);

                if (node != null)
                {
                    if (!String.IsNullOrEmpty(node.Value))
                    {
                        row.WiMS_ServiceStreamId = Convert.ToInt32(node.Value);
                    }
                    else
                    {
                        row.SetWiMS_ServiceStreamIdNull();
                    }
                }
                else
                {
                    row.SetWiMS_ServiceStreamIdNull();
                }

                //WiMS_ServiceTypeId
                node = curNode.SelectSingleNode("ns0:WiMS_ServiceTypeId", nsmgr);

                if (node != null)
                {
                    if (!String.IsNullOrEmpty(node.Value))
                    {
                        row.WiMS_ServiceTypeId = Convert.ToInt32(node.Value);
                    }
                    else
                    {
                        row.SetWiMS_ServiceTypeIdNull();
                    }
                }
                else
                {
                    row.SetWiMS_ServiceTypeIdNull();
                }

                //WiMS_ServiceDetailId
                node = curNode.SelectSingleNode("ns0:WiMS_ServiceDetailId", nsmgr);

                if (node != null)
                {
                    if (!String.IsNullOrEmpty(node.Value))
                    {
                        row.WiMS_ServiceDetailId = Convert.ToInt32(node.Value);
                    }
                    else
                    {
                        row.SetWiMS_ServiceDetailIdNull();
                    }
                }
                else
                {
                    row.SetWiMS_ServiceDetailIdNull();
                }

                //WiMS_CaseFinalCost
                node = curNode.SelectSingleNode("ns0:WiMS_CaseFinalCost", nsmgr);

                if (node != null)
                {
                    if (!String.IsNullOrEmpty(node.Value))
                    {
                        row.WiMS_CaseFinalCost = Convert.ToDecimal(node.Value);
                    }
                    else
                    {
                        row.SetWiMS_CaseFinalCostNull();
                    }
                }
                else
                {
                    row.SetWiMS_CaseFinalCostNull();
                }

                //WiMS_MetaRF01
                node = curNode.SelectSingleNode("ns0:WiMS_MetaRF01", nsmgr);

                if (node != null)
                {
                    if (!String.IsNullOrEmpty(node.Value))
                    {
                        row.WiMS_MetaRF01 = node.Value;
                    }
                    else
                    {
                        row.SetWiMS_MetaRF01Null();
                    }
                }
                else
                {
                    row.SetWiMS_MetaRF01Null();
                }

                //WiMS_MetaRF02
                node = curNode.SelectSingleNode("ns0:WiMS_MetaRF02", nsmgr);

                if (node != null)
                {
                    if (!String.IsNullOrEmpty(node.Value))
                    {
                        row.WiMS_MetaRF02 = node.Value;
                    }
                    else
                    {
                        row.SetWiMS_MetaRF02Null();
                    }
                }
                else
                {
                    row.SetWiMS_MetaRF02Null();
                }

                //WiMS_MetaRF03
                node = curNode.SelectSingleNode("ns0:WiMS_MetaRF03", nsmgr);

                if (node != null)
                {
                    if (!String.IsNullOrEmpty(node.Value))
                    {
                        row.WiMS_MetaRF03 = node.Value;
                    }
                    else
                    {
                        row.SetWiMS_MetaRF03Null();
                    }
                }
                else
                {
                    row.SetWiMS_MetaRF03Null();
                }

                //WiMS_MetaRF04
                node = curNode.SelectSingleNode("ns0:WiMS_MetaRF04", nsmgr);

                if (node != null)
                {
                    if (!String.IsNullOrEmpty(node.Value))
                    {
                        row.WiMS_MetaRF04 = node.Value;
                    }
                    else
                    {
                        row.SetWiMS_MetaRF04Null();
                    }
                }
                else
                {
                    row.SetWiMS_MetaRF04Null();
                }

                //WiMS_MetaRF05
                node = curNode.SelectSingleNode("ns0:WiMS_MetaRF05", nsmgr);

                if (node != null)
                {
                    if (!String.IsNullOrEmpty(node.Value))
                    {
                        row.WiMS_MetaRF05 = node.Value;
                    }
                    else
                    {
                        row.SetWiMS_MetaRF05Null();
                    }
                }
                else
                {
                    row.SetWiMS_MetaRF05Null();
                }

                //WiMS_MetaRF06
                node = curNode.SelectSingleNode("ns0:WiMS_MetaRF06", nsmgr);

                if (node != null)
                {
                    if (!String.IsNullOrEmpty(node.Value))
                    {
                        row.WiMS_MetaRF06 = Convert.ToInt32(node.Value);
                    }
                    else
                    {
                        row.SetWiMS_MetaRF06Null();
                    }
                }
                else
                {
                    row.SetWiMS_MetaRF06Null();
                }

                //WiMS_MetaRF07
                node = curNode.SelectSingleNode("ns0:WiMS_MetaRF07", nsmgr);

                if (node != null)
                {
                    if (!String.IsNullOrEmpty(node.Value))
                    {
                        row.WiMS_MetaRF07 = Convert.ToInt32(node.Value);
                    }
                    else
                    {
                        row.SetWiMS_MetaRF07Null();
                    }
                }
                else
                {
                    row.SetWiMS_MetaRF07Null();
                }

                //WiMS_MetaRF08
                node = curNode.SelectSingleNode("ns0:WiMS_MetaRF08", nsmgr);

                if (node != null)
                {
                    if (!String.IsNullOrEmpty(node.Value))
                    {
                        row.WiMS_MetaRF08 = Convert.ToInt32(node.Value);
                    }
                    else
                    {
                        row.SetWiMS_MetaRF08Null();
                    }
                }
                else
                {
                    row.SetWiMS_MetaRF08Null();
                }

                //WiMS_MetaRF09
                node = curNode.SelectSingleNode("ns0:WiMS_MetaRF09", nsmgr);

                if (node != null)
                {
                    if (!String.IsNullOrEmpty(node.Value))
                    {
                        row.WiMS_MetaRF09 = Convert.ToInt32(node.Value);
                    }
                    else
                    {
                        row.SetWiMS_MetaRF09Null();
                    }
                }
                else
                {
                    row.SetWiMS_MetaRF09Null();
                }

                //WiMS_MetaRF10
                node = curNode.SelectSingleNode("ns0:WiMS_MetaRF10", nsmgr);

                if (node != null)
                {
                    if (!String.IsNullOrEmpty(node.Value))
                    {
                        row.WiMS_MetaRF10 = Convert.ToInt32(node.Value);
                    }
                    else
                    {
                        row.SetWiMS_MetaRF10Null();
                    }
                }
                else
                {
                    row.SetWiMS_MetaRF10Null();
                }

                //WiMS_MetaRF11
                node = curNode.SelectSingleNode("ns0:WiMS_MetaRF11", nsmgr);

                if (node != null)
                {
                    if (!String.IsNullOrEmpty(node.Value))
                    {
                        row.WiMS_MetaRF11 = Convert.ToDateTime(node.Value);
                    }
                    else
                    {
                        row.SetWiMS_MetaRF11Null();
                    }
                }
                else
                {
                    row.SetWiMS_MetaRF11Null();
                }

                //WiMS_MetaRF12
                node = curNode.SelectSingleNode("ns0:WiMS_MetaRF12", nsmgr);

                if (node != null)
                {
                    if (!String.IsNullOrEmpty(node.Value))
                    {
                        row.WiMS_MetaRF12 = Convert.ToDateTime(node.Value);
                    }
                    else
                    {
                        row.SetWiMS_MetaRF12Null();
                    }
                }
                else
                {
                    row.SetWiMS_MetaRF12Null();
                }

                //WiMS_MetaRF13
                node = curNode.SelectSingleNode("ns0:WiMS_MetaRF13", nsmgr);

                if (node != null)
                {
                    if (!String.IsNullOrEmpty(node.Value))
                    {
                        row.WiMS_MetaRF13 = Convert.ToDateTime(node.Value);
                    }
                    else
                    {
                        row.SetWiMS_MetaRF13Null();
                    }
                }
                else
                {
                    row.SetWiMS_MetaRF13Null();
                }

                //WiMS_MetaRF14
                node = curNode.SelectSingleNode("ns0:WiMS_MetaRF14", nsmgr);

                if (node != null)
                {
                    if (!String.IsNullOrEmpty(node.Value))
                    {
                        row.WiMS_MetaRF14 = Convert.ToDateTime(node.Value);
                    }
                    else
                    {
                        row.SetWiMS_MetaRF14Null();
                    }
                }
                else
                {
                    row.SetWiMS_MetaRF14Null();
                }

                //WiMS_MetaRF15
                node = curNode.SelectSingleNode("ns0:WiMS_MetaRF15", nsmgr);

                if (node != null)
                {
                    if (!String.IsNullOrEmpty(node.Value))
                    {
                        row.WiMS_MetaRF15 = Convert.ToDateTime(node.Value);
                    }
                    else
                    {
                        row.SetWiMS_MetaRF15Null();
                    }
                }
                else
                {
                    row.SetWiMS_MetaRF15Null();
                }

                //WiMS_MetaRF16
                node = curNode.SelectSingleNode("ns0:WiMS_MetaRF16", nsmgr);

                if (node != null)
                {
                    if (!String.IsNullOrEmpty(node.Value))
                    {
                        row.WiMS_MetaRF16 = Convert.ToDouble(node.Value);
                    }
                    else
                    {
                        row.SetWiMS_MetaRF16Null();
                    }
                }
                else
                {
                    row.SetWiMS_MetaRF16Null();
                }

                //WiMS_MetaRF17
                node = curNode.SelectSingleNode("ns0:WiMS_MetaRF17", nsmgr);

                if (node != null)
                {
                    if (!String.IsNullOrEmpty(node.Value))
                    {
                        row.WiMS_MetaRF17 = Convert.ToDouble(node.Value);
                    }
                    else
                    {
                        row.SetWiMS_MetaRF17Null();
                    }
                }
                else
                {
                    row.SetWiMS_MetaRF17Null();
                }

                //WiMS_MetaRF18
                node = curNode.SelectSingleNode("ns0:WiMS_MetaRF18", nsmgr);

                if (node != null)
                {
                    if (!String.IsNullOrEmpty(node.Value))
                    {
                        row.WiMS_MetaRF18 = Convert.ToDouble(node.Value);
                    }
                    else
                    {
                        row.SetWiMS_MetaRF18Null();
                    }
                }
                else
                {
                    row.SetWiMS_MetaRF18Null();
                }

                //WiMS_MetaRF19
                node = curNode.SelectSingleNode("ns0:WiMS_MetaRF19", nsmgr);

                if (node != null)
                {
                    if (!String.IsNullOrEmpty(node.Value))
                    {
                        row.WiMS_MetaRF19 = Convert.ToDouble(node.Value);
                    }
                    else
                    {
                        row.SetWiMS_MetaRF19Null();
                    }
                }
                else
                {
                    row.SetWiMS_MetaRF19Null();
                }

                //WiMS_MetaRF20
                node = curNode.SelectSingleNode("ns0:WiMS_MetaRF20", nsmgr);

                if (node != null)
                {
                    if (!String.IsNullOrEmpty(node.Value))
                    {
                        row.WiMS_MetaRF20 = Convert.ToDouble(node.Value);
                    }
                    else
                    {
                        row.SetWiMS_MetaRF20Null();
                    }
                }
                else
                {
                    row.SetWiMS_MetaRF20Null();
                }

                //WiMS_AssetId
                node = curNode.SelectSingleNode("ns0:WiMS_AssetId", nsmgr);

                if (node != null)
                {
                    if (!String.IsNullOrEmpty(node.Value))
                    {
                        row.WiMS_AssetId = Convert.ToInt32(node.Value);
                    }
                    else
                    {
                        row.SetWiMS_AssetIdNull();
                    }
                }
                else
                {
                    row.SetWiMS_AssetIdNull();
                }

                //WiMS_Description
                node = curNode.SelectSingleNode("ns0:WiMS_Description", nsmgr);

                if (node != null)
                {
                    if (!String.IsNullOrEmpty(node.Value))
                    {
                        row.WiMS_Description = node.Value;
                    }
                    else
                    {
                        row.SetWiMS_DescriptionNull();
                    }
                }
                else
                {
                    row.SetWiMS_DescriptionNull();
                }

                //WiMS_Action
                node = curNode.SelectSingleNode("ns0:WiMS_Action", nsmgr);

                if (node != null)
                {
                    if (!String.IsNullOrEmpty(node.Value))
                    {
                        row.WiMS_Action = node.Value;
                    }
                    else
                    {
                        row.SetWiMS_ActionNull();
                    }
                }
                else
                {
                    row.SetWiMS_ActionNull();
                }

                //WiMS_ExternalMessageProcessId
                node = curNode.SelectSingleNode("ns0:WiMS_ExternalMessageProcessId", nsmgr);

                if (node != null)
                {
                    if (!String.IsNullOrEmpty(node.Value))
                    {
                        row.WiMS_ExternalMessageProcessId = Convert.ToInt32(node.Value);
                    }
                    else
                    {
                        row.SetWiMS_ExternalMessageProcessIdNull();
                    }
                }
                else
                {
                    row.SetWiMS_ExternalMessageProcessIdNull();
                }

                //WiMS_NextMilestone
                node = curNode.SelectSingleNode("ns0:WiMS_NextMilestone", nsmgr);

                if (node != null)
                {
                    if (!String.IsNullOrEmpty(node.Value))
                    {
                        row.WiMS_NextMilestone = node.Value;
                    }
                    else
                    {
                        row.SetWiMS_NextMilestoneNull();
                    }
                }
                else
                {
                    row.SetWiMS_NextMilestoneNull();
                }

                //WiMS_NextMilestoneDate
                node = curNode.SelectSingleNode("ns0:WiMS_NextMilestoneDate", nsmgr);

                if (node != null)
                {
                    if (!String.IsNullOrEmpty(node.Value))
                    {
                        row.WiMS_NextMilestoneDate = Convert.ToDateTime(node.Value);
                    }
                    else
                    {
                        row.SetWiMS_NextMilestoneDateNull();
                    }
                }
                else
                {
                    row.SetWiMS_NextMilestoneDateNull();
                }

                //WiMS_SLASeverity
                node = curNode.SelectSingleNode("ns0:WiMS_SLASeverity", nsmgr);

                if (node != null)
                {
                    if (!String.IsNullOrEmpty(node.Value))
                    {
                        row.WiMS_SLASeverity = node.Value;
                    }
                    else
                    {
                        row.SetWiMS_SLASeverityNull();
                    }
                }
                else
                {
                    row.SetWiMS_SLASeverityNull();
                }

                //WiMS_Direction
                node = curNode.SelectSingleNode("ns0:WiMS_Direction", nsmgr);

                if (node != null)
                {
                    if (!String.IsNullOrEmpty(node.Value))
                    {
                        row.WiMS_Direction = node.Value;
                    }
                    else
                    {
                        row.SetWiMS_DirectionNull();
                    }
                }
                else
                {
                    row.SetWiMS_DirectionNull();
                }

                //WiMS_ExternalCompanySystemId
                node = curNode.SelectSingleNode("ns0:WiMS_ExternalCompanySystemId", nsmgr);

                if (node != null)
                {
                    if (!String.IsNullOrEmpty(node.Value))
                    {
                        row.WiMS_ExternalCompanySystemId = Convert.ToInt32(node.Value);
                    }
                    else
                    {
                        row.SetWiMS_ExternalCompanySystemIdNull();
                    }
                }
                else
                {
                    row.SetWiMS_ExternalCompanySystemIdNull();
                }

                //WiMS_ForeignAssetTemplateId
                node = curNode.SelectSingleNode("ns0:WiMS_ForeignAssetTemplateId", nsmgr);

                if (node != null)
                {
                    if (!String.IsNullOrEmpty(node.Value))
                    {
                        row.WiMS_ForeignAssetTemplateId = node.Value;
                    }
                    else
                    {
                        row.SetWiMS_ForeignAssetTemplateIdNull();
                    }
                }
                else
                {
                    row.SetWiMS_ForeignAssetTemplateIdNull();
                }

                //Wims_ForeignStatus
                node = curNode.SelectSingleNode("ns0:Wims_ForeignStatus", nsmgr);

                if (node != null)
                {
                    if (!String.IsNullOrEmpty(node.Value))
                    {
                        row.Wims_ForeignStatus = node.Value;
                    }
                    else
                    {
                        row.SetWims_ForeignStatusNull();
                    }
                }
                else
                {
                    row.SetWims_ForeignStatusNull();
                }


                //Wims_ForeignWorkType
                node = curNode.SelectSingleNode("ns0:Wims_ForeignWorkType", nsmgr);

                if (node != null)
                {
                    if (!String.IsNullOrEmpty(node.Value))
                    {
                        row.Wims_ForeignWorkType = node.Value;
                    }
                    else
                    {
                        row.SetWims_ForeignWorkTypeNull();
                    }
                }
                else
                {
                    row.SetWims_ForeignWorkTypeNull();
                }

                //Wims_BizTalkMessageState
                node = curNode.SelectSingleNode("ns0:Wims_BizTalkMessageState", nsmgr);

                if (node != null)
                {
                    if (!String.IsNullOrEmpty(node.Value))
                    {
                        row.Wims_BizTalkMessageState = node.Value;
                    }
                    else
                    {
                        row.SetWims_BizTalkMessageStateNull();
                    }
                }
                else
                {
                    row.SetWims_BizTalkMessageStateNull();
                }

                //Wims_ForeignPmFrequency
                node = curNode.SelectSingleNode("ns0:Wims_ForeignPmFrequency", nsmgr);

                if (node != null)
                {
                    if (!String.IsNullOrEmpty(node.Value))
                    {
                        row.Wims_ForeignPmFrequency = node.Value;
                    }
                    else
                    {
                        row.SetWims_ForeignPmFrequencyNull();
                    }
                }
                else
                {
                    row.SetWims_ForeignPmFrequencyNull();
                }

                //WiMS_ForeignPmDueDate
                node = curNode.SelectSingleNode("ns0:WiMS_ForeignPmDueDate", nsmgr);

                if (node != null)
                {
                    if (!String.IsNullOrEmpty(node.Value))
                    {
                        row.WiMS_ForeignPmDueDate = Convert.ToDateTime(node.Value);
                    }
                    else
                    {
                        row.SetWiMS_ForeignPmDueDateNull();
                    }
                }
                else
                {
                    row.SetWiMS_ForeignPmDueDateNull();
                }

                //WiMS_ForeignPmNextDueDate
                node = curNode.SelectSingleNode("ns0:WiMS_ForeignPmNextDueDate", nsmgr);

                if (node != null)
                {
                    if (!String.IsNullOrEmpty(node.Value))
                    {
                        row.WiMS_ForeignPmNextDueDate = Convert.ToDateTime(node.Value);
                    }
                    else
                    {
                        row.SetWiMS_ForeignPmNextDueDateNull();
                    }
                }
                else
                {
                    row.SetWiMS_ForeignPmNextDueDateNull();
                }

                //WiMS_ForeignPmMasterPmNum
                node = curNode.SelectSingleNode("ns0:WiMS_ForeignPmMasterPmNum", nsmgr);

                if (node != null)
                {
                    if (!String.IsNullOrEmpty(node.Value))
                    {
                        row.WiMS_ForeignPmMasterPmNum = node.Value;
                    }
                    else
                    {
                        row.SetWiMS_ForeignPmMasterPmNumNull();
                    }
                }
                else
                {
                    row.SetWiMS_ForeignPmMasterPmNumNull();
                }

                //WiMS_ForeignJobPlanNum
                node = curNode.SelectSingleNode("ns0:WiMS_ForeignJobPlanNum", nsmgr);

                if (node != null)
                {
                    if (!String.IsNullOrEmpty(node.Value))
                    {
                        row.WiMS_ForeignJobPlanNum = node.Value;
                    }
                    else
                    {
                        row.SetWiMS_ForeignJobPlanNumNull();
                    }
                }
                else
                {
                    row.SetWiMS_ForeignJobPlanNumNull();
                }

                //WiMS_Stage
                node = curNode.SelectSingleNode("ns0:WiMS_Stage", nsmgr);

                if (node != null)
                {
                    if (!String.IsNullOrEmpty(node.Value))
                    {
                        row.WiMS_Stage = node.Value;
                    }
                    else
                    {
                        row.SetWiMS_StageNull();
                    }
                }
                else
                {
                    row.SetWiMS_StageNull();
                }

                //WiMS_Colour
                node = curNode.SelectSingleNode("ns0:WiMS_Colour", nsmgr);

                if (node != null)
                {
                    if (!String.IsNullOrEmpty(node.Value))
                    {
                        row.WiMS_Colour = node.Value;
                    }
                    else
                    {
                        row.SetWiMS_ColourNull();
                    }
                }
                else
                {
                    row.SetWiMS_ColourNull();
                }

                //WiMS_WorkflowInstanceId
                node = curNode.SelectSingleNode("ns0:WiMS_WorkflowInstanceId", nsmgr);

                if (node != null)
                {
                    if (!String.IsNullOrEmpty(node.Value))
                    {
                        row.WiMS_WorkflowInstanceId = Convert.ToInt32(node.Value);
                    }
                    else
                    {
                        row.SetWiMS_WorkflowInstanceIdNull();
                    }
                }
                else
                {
                    row.SetWiMS_WorkflowInstanceIdNull();
                }

                //WiMS_CommunicationId
                node = curNode.SelectSingleNode("ns0:WiMS_CommunicationId", nsmgr);

                if (node != null)
                {
                    if (!String.IsNullOrEmpty(node.Value))
                    {
                        row.WiMS_CommunicationId = Convert.ToInt32(node.Value);
                    }
                    else
                    {
                        row.SetWiMS_CommunicationIdNull();
                    }
                }
                else
                {
                    row.SetWiMS_CommunicationIdNull();
                }

                //WiMS_CmliCommPersonId
                node = curNode.SelectSingleNode("ns0:WiMS_CmliCommPersonId", nsmgr);

                if (node != null)
                {
                    if (!String.IsNullOrEmpty(node.Value))
                    {
                        row.WiMS_CmliCommPersonId = Convert.ToInt32(node.Value);
                    }
                    else
                    {
                        row.SetWiMS_CmliCommPersonIdNull();
                    }
                }
                else
                {
                    row.SetWiMS_CmliCommPersonIdNull();
                }
                
                //WiMS_MessageType
                node = curNode.SelectSingleNode("ns0:WiMS_MessageType", nsmgr);

                if (node != null)
                {
                    if (!String.IsNullOrEmpty(node.Value))
                    {
                        row.WiMS_MessageType = node.Value;
                    }
                    else
                    {
                        row.SetWiMS_MessageTypeNull();
                    }
                }
                else
                {
                    row.SetWiMS_MessageTypeNull();
                }

                //WiMS_CommunicationVisibility
                node = curNode.SelectSingleNode("ns0:WiMS_CommunicationVisibility", nsmgr);

                if (node != null)
                {
                    if (!String.IsNullOrEmpty(node.Value))
                    {
                        row.WiMS_CommunicationVisibility = Convert.ToInt32(node.Value);
                    }
                    else
                    {
                        row.SetWiMS_CommunicationVisibilityNull();
                    }
                }
                else
                {
                    row.SetWiMS_CommunicationVisibilityNull();
                }

                data.udtt_WorkItemMessageStore.Addudtt_WorkItemMessageStoreRow(row);
            }

            DataTable tbl = data.Tables[0].Copy();
            tbl.Columns.RemoveAt(tbl.Columns.Count - 1);

            return tbl;
        }
    }
}
