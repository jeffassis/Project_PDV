
namespace PDV
{
    partial class FrmMenuPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.PanelMenu = new System.Windows.Forms.Panel();
            this.PanelTitle = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuCadastros = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuFuncionarios = new System.Windows.Forms.ToolStripMenuItem();
            this.cargosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSair = new System.Windows.Forms.ToolStripMenuItem();
            this.PanelDesktop = new System.Windows.Forms.Panel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblNivelAcesso = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel6 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblNomeUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.BtnFecharChildForm = new System.Windows.Forms.Button();
            this.BtnFechar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PanelMenu.SuspendLayout();
            this.PanelTitle.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.PanelDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelMenu
            // 
            this.PanelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(92)))), ((int)(((byte)(76)))));
            this.PanelMenu.Controls.Add(this.pictureBox1);
            this.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelMenu.Location = new System.Drawing.Point(0, 0);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.Size = new System.Drawing.Size(150, 657);
            this.PanelMenu.TabIndex = 1;
            // 
            // PanelTitle
            // 
            this.PanelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(92)))), ((int)(((byte)(76)))));
            this.PanelTitle.Controls.Add(this.BtnFecharChildForm);
            this.PanelTitle.Controls.Add(this.BtnFechar);
            this.PanelTitle.Controls.Add(this.lblTitle);
            this.PanelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTitle.Location = new System.Drawing.Point(150, 0);
            this.PanelTitle.Name = "PanelTitle";
            this.PanelTitle.Size = new System.Drawing.Size(800, 80);
            this.PanelTitle.TabIndex = 2;
            this.PanelTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelTitle_MouseDown);
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTitle.Location = new System.Drawing.Point(259, 24);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(82, 28);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "HOME";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel4,
            this.toolStripStatusLabel5,
            this.lblNivelAcesso,
            this.toolStripStatusLabel6,
            this.lblNomeUsuario});
            this.statusStrip1.Location = new System.Drawing.Point(0, 657);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(950, 23);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(51, 18);
            this.toolStripStatusLabel1.Text = "Data.:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuCadastros,
            this.MenuSair});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(800, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuCadastros
            // 
            this.MenuCadastros.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuFuncionarios,
            this.cargosToolStripMenuItem});
            this.MenuCadastros.Name = "MenuCadastros";
            this.MenuCadastros.Size = new System.Drawing.Size(80, 21);
            this.MenuCadastros.Text = "Cadastros";
            // 
            // MenuFuncionarios
            // 
            this.MenuFuncionarios.Name = "MenuFuncionarios";
            this.MenuFuncionarios.Size = new System.Drawing.Size(150, 22);
            this.MenuFuncionarios.Text = "Funcionários";
            this.MenuFuncionarios.Click += new System.EventHandler(this.MenuFuncionarios_Click);
            // 
            // cargosToolStripMenuItem
            // 
            this.cargosToolStripMenuItem.Name = "cargosToolStripMenuItem";
            this.cargosToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.cargosToolStripMenuItem.Text = "Cargos";
            // 
            // MenuSair
            // 
            this.MenuSair.Name = "MenuSair";
            this.MenuSair.Size = new System.Drawing.Size(42, 21);
            this.MenuSair.Text = "Sair";
            this.MenuSair.Click += new System.EventHandler(this.MenuSair_Click);
            // 
            // PanelDesktop
            // 
            this.PanelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.PanelDesktop.Controls.Add(this.menuStrip1);
            this.PanelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelDesktop.Location = new System.Drawing.Point(150, 80);
            this.PanelDesktop.Name = "PanelDesktop";
            this.PanelDesktop.Size = new System.Drawing.Size(800, 577);
            this.PanelDesktop.TabIndex = 5;
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(84, 18);
            this.toolStripStatusLabel2.Text = "00-00-0000";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(51, 18);
            this.toolStripStatusLabel3.Text = "Hora.:";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(44, 18);
            this.toolStripStatusLabel4.Text = "00:00";
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(53, 18);
            this.toolStripStatusLabel5.Text = "Nivel.:";
            // 
            // lblNivelAcesso
            // 
            this.lblNivelAcesso.Name = "lblNivelAcesso";
            this.lblNivelAcesso.Size = new System.Drawing.Size(16, 18);
            this.lblNivelAcesso.Text = "0";
            // 
            // toolStripStatusLabel6
            // 
            this.toolStripStatusLabel6.Name = "toolStripStatusLabel6";
            this.toolStripStatusLabel6.Size = new System.Drawing.Size(70, 18);
            this.toolStripStatusLabel6.Text = "Usuário.:";
            // 
            // lblNomeUsuario
            // 
            this.lblNomeUsuario.Name = "lblNomeUsuario";
            this.lblNomeUsuario.Size = new System.Drawing.Size(32, 18);
            this.lblNomeUsuario.Text = "----";
            // 
            // BtnFecharChildForm
            // 
            this.BtnFecharChildForm.Dock = System.Windows.Forms.DockStyle.Left;
            this.BtnFecharChildForm.FlatAppearance.BorderSize = 0;
            this.BtnFecharChildForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFecharChildForm.Font = new System.Drawing.Font("Calisto MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFecharChildForm.ForeColor = System.Drawing.Color.White;
            this.BtnFecharChildForm.Image = global::PDV.Properties.Resources.btn_home_32;
            this.BtnFecharChildForm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnFecharChildForm.Location = new System.Drawing.Point(0, 0);
            this.BtnFecharChildForm.Name = "BtnFecharChildForm";
            this.BtnFecharChildForm.Size = new System.Drawing.Size(112, 80);
            this.BtnFecharChildForm.TabIndex = 4;
            this.BtnFecharChildForm.Text = "   HOME";
            this.BtnFecharChildForm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnFecharChildForm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnFecharChildForm.UseVisualStyleBackColor = true;
            this.BtnFecharChildForm.Click += new System.EventHandler(this.BtnFecharChildForm_Click);
            // 
            // BtnFechar
            // 
            this.BtnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnFechar.FlatAppearance.BorderSize = 0;
            this.BtnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFechar.Image = global::PDV.Properties.Resources.btn_cancelar_24;
            this.BtnFechar.Location = new System.Drawing.Point(769, 3);
            this.BtnFechar.Name = "BtnFechar";
            this.BtnFechar.Size = new System.Drawing.Size(28, 28);
            this.BtnFechar.TabIndex = 2;
            this.BtnFechar.TabStop = false;
            this.BtnFechar.UseVisualStyleBackColor = true;
            this.BtnFechar.Click += new System.EventHandler(this.BtnFechar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(92)))), ((int)(((byte)(76)))));
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 80);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FrmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 680);
            this.Controls.Add(this.PanelDesktop);
            this.Controls.Add(this.PanelTitle);
            this.Controls.Add(this.PanelMenu);
            this.Controls.Add(this.statusStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "FrmMenuPrincipal";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.Load += new System.EventHandler(this.FrmMenuPrincipal_Load);
            this.PanelMenu.ResumeLayout(false);
            this.PanelTitle.ResumeLayout(false);
            this.PanelTitle.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.PanelDesktop.ResumeLayout(false);
            this.PanelDesktop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel PanelMenu;
        private System.Windows.Forms.Panel PanelTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuCadastros;
        private System.Windows.Forms.ToolStripMenuItem MenuFuncionarios;
        private System.Windows.Forms.ToolStripMenuItem MenuSair;
        private System.Windows.Forms.Panel PanelDesktop;
        private System.Windows.Forms.ToolStripMenuItem cargosToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
        public System.Windows.Forms.ToolStripStatusLabel lblNivelAcesso;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel6;
        public System.Windows.Forms.ToolStripStatusLabel lblNomeUsuario;
        private System.Windows.Forms.Button BtnFechar;
        private System.Windows.Forms.Button BtnFecharChildForm;
    }
}

