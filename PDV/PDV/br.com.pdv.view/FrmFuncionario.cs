using PDV.br.com.pdv.dao;
using PDV.br.com.pdv.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDV
{
    public partial class FrmFuncionario : Form
    {
        string foto;
        public FrmFuncionario()
        {
            InitializeComponent();
        }

        private void FrmFuncionario_Load(object sender, EventArgs e)
        {
            LimparFoto();
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            Funcionario obj = new Funcionario
            {
                Nome = txtNome.Text,
                Cpf = txtCpf.Text,
                Telefone = txtTelefone.Text,
                Cargo = CbCargo.Text,
                Endereco = txtEndereco.Text
            };
            FuncionarioDAO dao = new FuncionarioDAO();
            dao.AdicionarFuncionario(obj, Img());
        }

        private byte[] Img()
        {
            if (foto == "")
            {
                return null;
            }

            FileStream fs = new FileStream(foto, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            byte[] imagem_byte = br.ReadBytes((int)fs.Length);
            return imagem_byte;
        }

        private void LimparFoto()
        {
            pictureBox1.Image = Properties.Resources.sem_foto;
            foto = "img/sem-foto.jpg";
        }
    }
}
