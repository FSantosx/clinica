namespace Hospital_D.FilipinoSmith
{
    partial class Cadastro_Usuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cadastro_Usuario));
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gb_usuario = new System.Windows.Forms.GroupBox();
            this.MtxtIdfun = new System.Windows.Forms.MaskedTextBox();
            this.lbdone = new System.Windows.Forms.Label();
            this.gb_usuario.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtUser
            // 
            this.txtUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUser.Location = new System.Drawing.Point(93, 68);
            this.txtUser.MaxLength = 20;
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(79, 13);
            this.txtUser.TabIndex = 1;
            // 
            // txtPassword
            // 
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Location = new System.Drawing.Point(93, 98);
            this.txtPassword.MaxLength = 50;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(79, 13);
            this.txtPassword.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(47, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Usuario";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(52, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Senha";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Location = new System.Drawing.Point(14, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "ID Funcionario";
            // 
            // gb_usuario
            // 
            this.gb_usuario.BackColor = System.Drawing.Color.Transparent;
            this.gb_usuario.Controls.Add(this.lbdone);
            this.gb_usuario.Controls.Add(this.MtxtIdfun);
            this.gb_usuario.Controls.Add(this.label3);
            this.gb_usuario.Controls.Add(this.txtUser);
            this.gb_usuario.Controls.Add(this.txtPassword);
            this.gb_usuario.Controls.Add(this.label1);
            this.gb_usuario.Controls.Add(this.label2);
            this.gb_usuario.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.gb_usuario.Location = new System.Drawing.Point(12, 13);
            this.gb_usuario.Name = "gb_usuario";
            this.gb_usuario.Size = new System.Drawing.Size(250, 170);
            this.gb_usuario.TabIndex = 7;
            this.gb_usuario.TabStop = false;
            this.gb_usuario.Text = "Cadastro Usuario";
            // 
            // MtxtIdfun
            // 
            this.MtxtIdfun.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MtxtIdfun.Location = new System.Drawing.Point(93, 37);
            this.MtxtIdfun.Mask = "000";
            this.MtxtIdfun.Name = "MtxtIdfun";
            this.MtxtIdfun.PromptChar = ' ';
            this.MtxtIdfun.Size = new System.Drawing.Size(23, 13);
            this.MtxtIdfun.TabIndex = 0;
            // 
            // lbdone
            // 
            this.lbdone.AutoSize = true;
            this.lbdone.BackColor = System.Drawing.Color.Transparent;
            this.lbdone.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbdone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbdone.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbdone.Location = new System.Drawing.Point(94, 137);
            this.lbdone.Name = "lbdone";
            this.lbdone.Size = new System.Drawing.Size(69, 17);
            this.lbdone.TabIndex = 8;
            this.lbdone.Text = "Confirmar";
            this.lbdone.Click += new System.EventHandler(this.salvar);
            // 
            // Cadastro_Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(272, 194);
            this.Controls.Add(this.gb_usuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Cadastro_Usuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro_Usuario";
            this.gb_usuario.ResumeLayout(false);
            this.gb_usuario.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gb_usuario;
        private System.Windows.Forms.MaskedTextBox MtxtIdfun;
        private System.Windows.Forms.Label lbdone;
    }
}