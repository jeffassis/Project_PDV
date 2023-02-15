
namespace PDV.br.com.pdv.view
{
    partial class FrmLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.PanelTitle = new System.Windows.Forms.Panel();
            this.BtnFechar = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnEntrar = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.PanelTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelTitle
            // 
            this.PanelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(92)))), ((int)(((byte)(76)))));
            this.PanelTitle.Controls.Add(this.BtnFechar);
            this.PanelTitle.Controls.Add(this.lblTitle);
            this.PanelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTitle.Location = new System.Drawing.Point(0, 0);
            this.PanelTitle.Name = "PanelTitle";
            this.PanelTitle.Size = new System.Drawing.Size(498, 70);
            this.PanelTitle.TabIndex = 3;
            this.PanelTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelTitle_MouseDown);
            // 
            // BtnFechar
            // 
            this.BtnFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnFechar.FlatAppearance.BorderSize = 0;
            this.BtnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFechar.Image = global::PDV.Properties.Resources.btn_cancelar_24;
            this.BtnFechar.Location = new System.Drawing.Point(460, 4);
            this.BtnFechar.Name = "BtnFechar";
            this.BtnFechar.Size = new System.Drawing.Size(28, 28);
            this.BtnFechar.TabIndex = 1;
            this.BtnFechar.TabStop = false;
            this.toolTip1.SetToolTip(this.BtnFechar, "Fechar o sistema");
            this.BtnFechar.UseVisualStyleBackColor = true;
            this.BtnFechar.Click += new System.EventHandler(this.BtnFechar_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTitle.Location = new System.Drawing.Point(72, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(340, 28);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "AUTENTICAÇÃO DO SISTEMA";
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(227, 109);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(207, 23);
            this.txtUsername.TabIndex = 6;
            // 
            // txtSenha
            // 
            this.txtSenha.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Location = new System.Drawing.Point(227, 148);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(207, 23);
            this.txtSenha.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(64, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "@JeffAssis";
            // 
            // label1
            // 
            this.label1.Image = global::PDV.Properties.Resources.senha;
            this.label1.Location = new System.Drawing.Point(192, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 24);
            this.label1.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.Image = global::PDV.Properties.Resources.username_20;
            this.label4.Location = new System.Drawing.Point(192, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 24);
            this.label4.TabIndex = 11;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PDV.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(21, 82);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(148, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // BtnEntrar
            // 
            this.BtnEntrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(92)))), ((int)(((byte)(76)))));
            this.BtnEntrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEntrar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEntrar.ForeColor = System.Drawing.Color.Gainsboro;
            this.BtnEntrar.Image = global::PDV.Properties.Resources.login_20;
            this.BtnEntrar.Location = new System.Drawing.Point(267, 182);
            this.BtnEntrar.Name = "BtnEntrar";
            this.BtnEntrar.Size = new System.Drawing.Size(110, 45);
            this.BtnEntrar.TabIndex = 8;
            this.BtnEntrar.Text = "   Entrar";
            this.BtnEntrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.BtnEntrar, "Acessar o sistema");
            this.BtnEntrar.UseVisualStyleBackColor = false;
            this.BtnEntrar.Click += new System.EventHandler(this.BtnEntrar_Click);
            // 
            // FrmLogin
            // 
            this.AcceptButton = this.BtnEntrar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(498, 261);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnEntrar);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.PanelTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLogin";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela de Login";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.PanelTitle.ResumeLayout(false);
            this.PanelTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PanelTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Button BtnEntrar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnFechar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}