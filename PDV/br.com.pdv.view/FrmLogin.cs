using PDV.br.com.pdv.dao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDV.br.com.pdv.view
{
    public partial class FrmLogin : Form
    {
        readonly FrmMenuPrincipal _form;
        public FrmLogin(FrmMenuPrincipal f)
        {
            InitializeComponent();
            _form = f;
            this.Text = String.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        // Codigo para criar objeto e funcao de fechar a aplicacao
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void PanelTitle_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            txtUsername.Focus();
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja sair do Sistema?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Logar()
        {
            string user, senha;
            user = txtUsername.Text;
            senha = txtSenha.Text;

            // Verifica username vazio
            if (user == "")
            {
                MessageBox.Show("Username não pode ser vazio!", "Campo vazio...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Focus();
                return;
            }
            // Verifica senha vazia
            if (senha == "")
            {
                MessageBox.Show("Senha não pode ser vazia!", "Campo vazio...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSenha.Focus();
                return;
            }
            UsuarioDAO dao = new UsuarioDAO();
            DataTable dt = dao.EfetuarLogin(user, senha);
            if (dt.Rows.Count == 1)
            {
                _form.lblNivelAcesso.Text = dt.Rows[0].ItemArray[4].ToString();
                _form.lblNomeUsuario.Text = dt.Rows[0].Field<string>("nome");

                Program.nivel = int.Parse(dt.Rows[0].Field<Int32>("nivel").ToString());
                Program.nomeUsuario = dt.Rows[0].Field<string>("nome");
                Program.logado = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuário não encontrado!", "Tente novamente!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnEntrar_Click(object sender, EventArgs e)
        {
            Logar();
        }
    }
}
