using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IBM.Data.DB2;

namespace AddressRepository
{
    public class AddresFileHelper
    {

        //Get data from ACCTCOPY. If not found in DTCLIBLE, get data from DTALIBLE
        public static List<Address> GetAddresses(string search)
        {
            DataTable dt = new DataTable();
         
            List<Address> addresses = new List<Address>();
                using (DB2Connection conn = Connection.getDB2Connection())
                {
                    conn.Open();
                    string callstring = "SELECT ADCODE, ADCNAM, ADADR1, ADADR2, ADADR3, ADADR4, ADPSTC, ADCNTY FROM DTCLIBLE.ADRSFILE " +
                                        "WHERE UCASE(ADCNAM) LIKE '%" + search.ToUpper() + "%' AND adcnty = 'GB' fetch first 500 rows only";


                    DB2Command cmd = new DB2Command(callstring, conn);
                    cmd.CommandType = CommandType.Text;
                    DB2DataAdapter adp = new DB2DataAdapter(cmd);
                    adp.Fill(dt);
                    cmd.Dispose();
                }


            foreach (DataRow dataRow in dt.Rows)
            {
                addresses.Add(new Address
                {
                    Code = dataRow["ADCODE"].ToString(),
                    Name = dataRow["ADCNAM"].ToString(),
                    Addr1 = dataRow["ADADR1"].ToString(),
                    Addr2 = dataRow["ADADR2"].ToString(),
                    Addr3 = dataRow["ADADR3"].ToString(),
                    Addr4 = dataRow["ADADR4"].ToString(),
                    PostCode = dataRow["ADPSTC"].ToString(),
                    Country = dataRow["ADCNTY"].ToString()
                });
            }

            return addresses;

        }
    }

    public class Address

    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string Addr1 { get; set; }
        public string Addr2 { get; set; }
        public string Addr3 { get; set; }
        public string Addr4 { get; set; }
        public string PostCode { get; set; }
        public string Country { get; set; }
    }
}
