using MySql.Data.MySqlClient;
using PDV.br.com.pdv.connect;
using PDV.br.com.pdv.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDV.br.com.pdv.dao
{
    public class FuncionarioDAO
    {
        private readonly MySqlConnection vcon;

        public FuncionarioDAO()
        {
            this.vcon = new ConnectionFactory().GetConnection();
        }

        public void AdicionarFuncionario(Funcionario obj, byte[] foto)
        {
            try
            {
                string sql = @"INSERT INTO tb_funcionario(nome, cpf, telefone, cargo, endereco, data, imagem) 
                                       VALUES(@nome, @cpf, @telefone, @cargo, @endereco, curDate(), @imagem)";
                MySqlCommand cmd = new MySqlCommand(sql, vcon);
                cmd.Parameters.AddWithValue("@nome", obj.Nome);
                cmd.Parameters.AddWithValue("@cpf", obj.Cpf);
                cmd.Parameters.AddWithValue("@telefone", obj.Telefone);
                cmd.Parameters.AddWithValue("@cargo", obj.Cargo);
                cmd.Parameters.AddWithValue("@endereco", obj.Endereco);
                cmd.Parameters.AddWithValue("@imagem", foto);
                vcon.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Adicionado com sucesso", "Adicionando dados...", 
                                                            MessageBoxButtons.OK, 
                                                            MessageBoxIcon.Information);
                vcon.Close();
                vcon.Dispose();
                vcon.ClearAllPoolsAsync();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao adicionar: " + ex);
            }
        }
    }
}
