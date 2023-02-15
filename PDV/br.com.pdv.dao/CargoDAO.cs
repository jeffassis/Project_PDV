using MySql.Data.MySqlClient;
using PDV.br.com.pdv.connect;
using PDV.br.com.pdv.model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDV.br.com.pdv.dao
{
    public class CargoDAO
    {
        private readonly MySqlConnection vcon;

        public CargoDAO()
        {
            this.vcon = new ConnectionFactory().GetConnection();
        }

        public void CadastrarCargo(Cargo obj)
        {
            try
            {
                string sql = @"INSERT INTO tb_cargo(descricao) VALUES (@descricao)";
                MySqlCommand cmd = new MySqlCommand(sql, vcon);
                cmd.Parameters.AddWithValue("@descricao", obj.Descricao);
                vcon.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Adicionado com sucesso", "Dados adicionados...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                vcon.Close();
                vcon.Dispose();
                vcon.ClearAllPoolsAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao adicionar: " + ex);                
            }
        }

        public void EditarCargo(Cargo obj, string id)
        {
            try
            {
                string sql = @"UPDATE tb_cargo SET descricao=@descricao WHERE id_cargo=@id";
                MySqlCommand cmd = new MySqlCommand(sql, vcon);
                cmd.Parameters.AddWithValue("@descricao", obj.Descricao);
                cmd.Parameters.AddWithValue("@id", id);
                vcon.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Atualizado com sucesso", "Dados atualizados...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                vcon.Close();
                vcon.Dispose();
                vcon.ClearAllPoolsAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar: " + ex);               
            }
        }

        public void ExcluirCargo(string id)
        {
            try
            {
                string sql = "DELETE FROM tb_cargo WHERE id_cargo=@id";
                MySqlCommand cmd = new MySqlCommand(sql, vcon);
                cmd.Parameters.AddWithValue("@id", id);
                vcon.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Excluido com sucesso", "Excluir dados...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                vcon.Close();
                vcon.Dispose();
                vcon.ClearAllPoolsAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir: " + ex);               
            }
        }

        public DataTable ListarCargo()
        {
            try
            {
                DataTable dt = new DataTable();
                string sql = "SELECT * FROM tb_cargo";
                MySqlCommand cmd = new MySqlCommand(sql, vcon);
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
                MessageBox.Show("Erro ao executar a lista: " + ex);
                return null;
            }
        }
    }
}
