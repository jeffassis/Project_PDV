using MySql.Data.MySqlClient;
using PDV.br.com.pdv.connect;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDV.br.com.pdv.dao
{
    class UsuarioDAO
    {
        private readonly MySqlConnection vcon;

        public UsuarioDAO()
        {
            this.vcon = new ConnectionFactory().GetConnection();
        }

        public DataTable EfetuarLogin(string username, string senha)
        {
            try
            {
                DataTable dt = new DataTable();
                string sql = "SELECT * FROM tb_user WHERE username=@username AND senha=@senha";
                MySqlCommand cmd = new MySqlCommand(sql, vcon);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@senha", senha);
                vcon.Open();
                cmd.ExecuteNonQuery();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                vcon.Close();
                vcon.Dispose();
                vcon.ClearAllPoolsAsync();
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao efetuar login: " + ex);
                return null;
            }
        }
    }
}
