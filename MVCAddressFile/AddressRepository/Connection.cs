using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using IBM.Data.DB2;

namespace AddressRepository
{
    public class Connection
    {
        public Connection()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        public static DB2Connection getDB2Connection()
        {
            string path = @"C:\Live AS400\AS400.xml";

            string server = XElement.Load(path).Element("IP").Value;
            string database = XElement.Load(path).Element("Database").Value;

            DB2ConnectionStringBuilder cnStr = new DB2ConnectionStringBuilder();
            cnStr.Server = server;
            cnStr.UserID = "ONLBILLING";
            cnStr.Database = database;
            cnStr.Password = "ONLBILLIN#";
            cnStr.MinPoolSize = 10;
            cnStr.MinPoolSize = 10;
            cnStr.SchemaList = "'scmlible', 'genlible'";
            cnStr.Connect_Timeout = 15;
            //cnStr.Pooling = false;
            //cnStr.PersistSecurityInfo = true;
            //      cnStr.CurrentSchema = "SCMLIBLE";

            DB2Connection conn = new DB2Connection();
            bool fromPool = conn.IsConnectionFromPool;
            conn.ConnectionString = cnStr.ConnectionString;
            //       conn.ConnectionString = ConfigurationManager.ConnectionStrings["db2IBM"].ConnectionString;
            //     conn.Open();

            return conn;
        }
    }
}
