using PDV.br.com.pdv.view;
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

namespace PDV
{
    public partial class FrmMenuPrincipal : Form
    {
        // Variavel de ativacao do formulario
        private Form activeForm;

        public FrmMenuPrincipal()
        {
            InitializeComponent();
            FrmLogin login = new FrmLogin(this);
            login.ShowDialog();
            //btnCloseChildForm.Visible = false;
            this.Text = String.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void PanelTitle_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.PanelDesktop.Controls.Add(childForm);
            this.PanelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = childForm.Text;
        }

        // Metodo para abrir os formularios com paramestros de nivel de acesso
        private void AbreForm(int nivel, Form f, object sender)
        {
            if (Program.logado)
            {
                if (Program.nivel >= nivel)
                {
                    OpenChildForm(f, sender);
                }
                else
                {
                    MessageBox.Show("Acesso não permitido", "Acesso negado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("É necessario ter um usuário logado", "Acesso bloqueado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MenuSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MenuFuncionarios_Click(object sender, EventArgs e)
        {
            FrmFuncionario form = new FrmFuncionario();
            AbreForm(1, form, sender);
        }

        private void FrmMenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnFecharChildForm_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
            {
                activeForm.Close();
                Reset();
            }
        }
        private void Reset()
        {
            lblTitle.Text = "HOME";
            BtnFecharChildForm.Visible = false;
        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                BtnFecharChildForm.Visible = true;
            }
        }
    }
}
