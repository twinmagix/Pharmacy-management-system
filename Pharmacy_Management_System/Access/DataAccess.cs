using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy_Management_System.Access
{
    class DataAccess
    {
        private String ConnectionString = "Data Source=Server=LEARNERAIO11;Database=DB_SAF.mdf;Trusted_Connection=True;Column Encryption Setting=Enabled;MultipleActiveResultSets=True;Persist Security Info=True;Encrypt=True;TrustServerCertificate=True;";
         
        private SqlConnection sqlCon;
        private SqlCommand sqlCmd;
        private SqlDataAdapter sqlDataAdapter;

        public SqlConnection SqlCon
        {
            set { this.sqlCon = value; }
            get { return this.sqlCon; }
        }

        public SqlCommand SqlCmd
        {
            set { this.sqlCmd = value; }
            get { return this.sqlCmd; }
        }

        public SqlDataAdapter SqlDA
        {
            set { this.sqlDataAdapter = value; }
            get { return this.sqlDataAdapter; }
        }

        public DataAccess()
        {
            SqlCon = new SqlConnection(ConnectionString);
        }
    }
}
