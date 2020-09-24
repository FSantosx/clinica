namespace Hospital_D.FilipinoSmith
{
    partial class Editar_Usuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Editar_Usuario));
            this.GB_busca = new System.Windows.Forms.GroupBox();
            this.lbbuscaerro = new System.Windows.Forms.Label();
            this.Mtxtbusca = new System.Windows.Forms.MaskedTextBox();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.label24 = new System.Windows.Forms.Label();
            this.LBIDorCpf = new System.Windows.Forms.Label();
            this.LbDescribAction = new System.Windows.Forms.Label();
            this.Gb_usuario = new System.Windows.Forms.GroupBox();
            this.pbcheck = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbcheck2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.newpass2 = new System.Windows.Forms.TextBox();
            this.newpass1 = new System.Windows.Forms.TextBox();
            this.lbuser = new System.Windows.Forms.Label();
            this.pbwrong = new System.Windows.Forms.PictureBox();
            this.lbdone = new System.Windows.Forms.Label();
            this.GB_busca.SuspendLayout();
            this.Gb_usuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbcheck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbcheck2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbwrong)).BeginInit();
            this.SuspendLayout();
            // 
            // GB_busca
            // 
            this.GB_busca.BackColor = System.Drawing.Color.Transparent;
            this.GB_busca.Controls.Add(this.lbbuscaerro);
            this.GB_busca.Controls.Add(this.Mtxtbusca);
            this.GB_busca.Controls.Add(this.BtnBuscar);
            this.GB_busca.Controls.Add(this.label24);
            this.GB_busca.Controls.Add(this.LBIDorCpf);
            this.GB_busca.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.GB_busca.Location = new System.Drawing.Point(12, 12);
            this.GB_busca.Name = "GB_busca";
            this.GB_busca.Size = new System.Drawing.Size(180, 66);
            this.GB_busca.TabIndex = 43;
            this.GB_busca.TabStop = false;
            this.GB_busca.Text = "Pesquisa";
            // 
            // lbbuscaerro
            // 
            this.lbbuscaerro.AutoSize = true;
            this.lbbuscaerro.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbbuscaerro.Location = new System.Drawing.Point(58, 49);
            this.lbbuscaerro.Name = "lbbuscaerro";
            this.lbbuscaerro.Size = new System.Drawing.Size(69, 12);
            this.lbbuscaerro.TabIndex = 42;
            this.lbbuscaerro.Text = "Busca Inválida!";
            this.lbbuscaerro.Visible = false;
            // 
            // Mtxtbusca
            // 
            this.Mtxtbusca.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Mtxtbusca.Location = new System.Drawing.Point(43, 20);
            this.Mtxtbusca.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.Mtxtbusca.Mask = "000";
            this.Mtxtbusca.Name = "Mtxtbusca";
            this.Mtxtbusca.PromptChar = ' ';
            this.Mtxtbusca.Size = new System.Drawing.Size(100, 13);
            this.Mtxtbusca.TabIndex = 37;
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.BackColor = System.Drawing.Color.Silver;
            this.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnBuscar.Location = new System.Drawing.Point(149, 18);
            this.BtnBuscar.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(25, 17);
            this.BtnBuscar.TabIndex = 40;
            this.BtnBuscar.Text = "Go";
            this.BtnBuscar.UseVisualStyleBackColor = false;
            this.BtnBuscar.Click += new System.EventHandler(this.BuscarUser);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.BackColor = System.Drawing.Color.Transparent;
            this.label24.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label24.Location = new System.Drawing.Point(3, 20);
            this.label24.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(40, 13);
            this.label24.TabIndex = 38;
            this.label24.Text = "Buscar";
            // 
            // LBIDorCpf
            // 
            this.LBIDorCpf.AutoSize = true;
            this.LBIDorCpf.BackColor = System.Drawing.Color.Transparent;
            this.LBIDorCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBIDorCpf.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.LBIDorCpf.Location = new System.Drawing.Point(78, 37);
            this.LBIDorCpf.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LBIDorCpf.Name = "LBIDorCpf";
            this.LBIDorCpf.Size = new System.Drawing.Size(25, 12);
            this.LBIDorCpf.TabIndex = 39;
            this.LBIDorCpf.Text = "( ID )";
            // 
            // LbDescribAction
            // 
            this.LbDescribAction.AutoSize = true;
            this.LbDescribAction.BackColor = System.Drawing.Color.Transparent;
            this.LbDescribAction.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.LbDescribAction.Location = new System.Drawing.Point(15, 18);
            this.LbDescribAction.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LbDescribAction.Name = "LbDescribAction";
            this.LbDescribAction.Size = new System.Drawing.Size(172, 13);
            this.LbDescribAction.TabIndex = 42;
            this.LbDescribAction.Text = "Efetuar cadastro de novo Paciente";
            // 
            // Gb_usuario
            // 
            this.Gb_usuario.BackColor = System.Drawing.Color.Transparent;
            this.Gb_usuario.Controls.Add(this.pbcheck);
            this.Gb_usuario.Controls.Add(this.pictureBox1);
            this.Gb_usuario.Controls.Add(this.pbcheck2);
            this.Gb_usuario.Controls.Add(this.label2);
            this.Gb_usuario.Controls.Add(this.label1);
            this.Gb_usuario.Controls.Add(this.newpass2);
            this.Gb_usuario.Controls.Add(this.newpass1);
            this.Gb_usuario.Controls.Add(this.lbuser);
            this.Gb_usuario.Controls.Add(this.pbwrong);
            this.Gb_usuario.Enabled = false;
            this.Gb_usuario.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.Gb_usuario.Location = new System.Drawing.Point(11, 87);
            this.Gb_usuario.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.Gb_usuario.Name = "Gb_usuario";
            this.Gb_usuario.Padding = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.Gb_usuario.Size = new System.Drawing.Size(273, 125);
            this.Gb_usuario.TabIndex = 44;
            this.Gb_usuario.TabStop = false;
            this.Gb_usuario.Text = "Usuário";
            // 
            // pbcheck
            // 
            this.pbcheck.Image = ((System.Drawing.Image)(resources.GetObject("pbcheck.Image")));
            this.pbcheck.Location = new System.Drawing.Point(206, 41);
            this.pbcheck.Name = "pbcheck";
            this.pbcheck.Size = new System.Drawing.Size(26, 24);
            this.pbcheck.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbcheck.TabIndex = 29;
            this.pbcheck.TabStop = false;
            this.pbcheck.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(208, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // pbcheck2
            // 
            this.pbcheck2.Image = ((System.Drawing.Image)(resources.GetObject("pbcheck2.Image")));
            this.pbcheck2.Location = new System.Drawing.Point(206, 81);
            this.pbcheck2.Name = "pbcheck2";
            this.pbcheck2.Size = new System.Drawing.Size(26, 24);
            this.pbcheck2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbcheck2.TabIndex = 30;
            this.pbcheck2.TabStop = false;
            this.pbcheck2.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 90);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Confirmar Senha";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Nova Senha";
            // 
            // newpass2
            // 
            this.newpass2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.newpass2.Location = new System.Drawing.Point(99, 90);
            this.newpass2.Name = "newpass2";
            this.newpass2.Size = new System.Drawing.Size(100, 13);
            this.newpass2.TabIndex = 26;
            this.newpass2.Leave += new System.EventHandler(this.check_pass1);
            this.newpass2.MouseLeave += new System.EventHandler(this.check_pass1);
            // 
            // newpass1
            // 
            this.newpass1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.newpass1.Location = new System.Drawing.Point(99, 51);
            this.newpass1.Name = "newpass1";
            this.newpass1.Size = new System.Drawing.Size(100, 13);
            this.newpass1.TabIndex = 25;
            this.newpass1.Leave += new System.EventHandler(this.check_pass1);
            // 
            // lbuser
            // 
            this.lbuser.AutoSize = true;
            this.lbuser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbuser.Location = new System.Drawing.Point(96, 21);
            this.lbuser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbuser.Name = "lbuser";
            this.lbuser.Size = new System.Drawing.Size(79, 17);
            this.lbuser.TabIndex = 24;
            this.lbuser.Text = "User Name";
            // 
            // pbwrong
            // 
            this.pbwrong.Image = ((System.Drawing.Image)(resources.GetObject("pbwrong.Image")));
            this.pbwrong.Location = new System.Drawing.Point(208, 86);
            this.pbwrong.Name = "pbwrong";
            this.pbwrong.Size = new System.Drawing.Size(20, 20);
            this.pbwrong.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbwrong.TabIndex = 31;
            this.pbwrong.TabStop = false;
            this.pbwrong.Visible = false;
            // 
            // lbdone
            // 
            this.lbdone.AutoSize = true;
            this.lbdone.BackColor = System.Drawing.Color.Transparent;
            this.lbdone.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbdone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbdone.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbdone.Location = new System.Drawing.Point(122, 232);
            this.lbdone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbdone.Name = "lbdone";
            this.lbdone.Size = new System.Drawing.Size(59, 17);
            this.lbdone.TabIndex = 45;
            this.lbdone.Text = "Concluir";
            this.lbdone.Click += new System.EventHandler(this.confirmar);
            // 
            // Editar_Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Hospital_D.FilipinoSmith.Properties.Resources.fffffe;
            this.ClientSize = new System.Drawing.Size(299, 266);
            this.Controls.Add(this.lbdone);
            this.Controls.Add(this.Gb_usuario);
            this.Controls.Add(this.GB_busca);
            this.Controls.Add(this.LbDescribAction);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Editar_Usuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar_Usuario";
            this.GB_busca.ResumeLayout(false);
            this.GB_busca.PerformLayout();
            this.Gb_usuario.ResumeLayout(false);
            this.Gb_usuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbcheck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbcheck2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbwrong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GB_busca;
        private System.Windows.Forms.Label lbbuscaerro;
        private System.Windows.Forms.MaskedTextBox Mtxtbusca;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label LBIDorCpf;
        private System.Windows.Forms.Label LbDescribAction;
        private System.Windows.Forms.GroupBox Gb_usuario;
        private System.Windows.Forms.Label lbuser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox newpass2;
        private System.Windows.Forms.TextBox newpass1;
        private System.Windows.Forms.Label lbdone;
        private System.Windows.Forms.PictureBox pbcheck2;
        private System.Windows.Forms.PictureBox pbcheck;
        private System.Windows.Forms.PictureBox pbwrong;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}