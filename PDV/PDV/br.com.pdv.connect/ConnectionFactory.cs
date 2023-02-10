using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDV.br.com.pdv.connect
{
    public class ConnectionFactory
    {
        public MySqlConnection GetConnection()
        {
            string vcon = ConfigurationManager.ConnectionStrings["PDV.Properties.Settings.project_pdvConnectionString"].ConnectionString;
            return new MySqlConnection(vcon);
        }
    }
}
