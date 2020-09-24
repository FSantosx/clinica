namespace Hospital_D.FilipinoSmith
{
    partial class Cadastro_Funcionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cadastro_Funcionario));
            this.info1lb = new System.Windows.Forms.Label();
            this.Gb_Medico = new System.Windows.Forms.GroupBox();
            this.EspeciaMedico_Combo = new System.Windows.Forms.ComboBox();
            this.Mtxt_HorarioMedico = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Gb_DadosFun = new System.Windows.Forms.GroupBox();
            this.perfilPB = new System.Windows.Forms.PictureBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txt_StatusFun = new System.Windows.Forms.TextBox();
            this.Mtxt_cpfFun = new System.Windows.Forms.MaskedTextBox();
            this.Mtxt_rgFun = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.FuncaoFun_Combo = new System.Windows.Forms.ComboBox();
            this.take = new System.Windows.Forms.Button();
            this.btn_escolher_imagem = new System.Windows.Forms.Button();
            this.txt_nomeFun = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbdone = new System.Windows.Forms.Label();
            this.GB_busca = new System.Windows.Forms.GroupBox();
            this.lbbuscaerro = new System.Windows.Forms.Label();
            this.Mtxtbusca = new System.Windows.Forms.MaskedTextBox();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Gb_Medico.SuspendLayout();
            this.Gb_DadosFun.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.perfilPB)).BeginInit();
            this.GB_busca.SuspendLayout();
            this.SuspendLayout();
            // 
            // info1lb
            // 
            this.info1lb.AutoSize = true;
            this.info1lb.BackColor = System.Drawing.Color.Transparent;
            this.info1lb.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.info1lb.Location = new System.Drawing.Point(88, 26);
            this.info1lb.Name = "info1lb";
            this.info1lb.Size = new System.Drawing.Size(185, 13);
            this.info1lb.TabIndex = 41;
            this.info1lb.Text = "Efetuar cadastro de novo Funcionario\r\n";
            // 
            // Gb_Medico
            // 
            this.Gb_Medico.BackColor = System.Drawing.Color.Transparent;
            this.Gb_Medico.Controls.Add(this.EspeciaMedico_Combo);
            this.Gb_Medico.Controls.Add(this.Mtxt_HorarioMedico);
            this.Gb_Medico.Controls.Add(this.label1);
            this.Gb_Medico.Controls.Add(this.label7);
            this.Gb_Medico.Enabled = false;
            this.Gb_Medico.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.Gb_Medico.Location = new System.Drawing.Point(21, 246);
            this.Gb_Medico.Name = "Gb_Medico";
            this.Gb_Medico.Size = new System.Drawing.Size(317, 116);
            this.Gb_Medico.TabIndex = 38;
            this.Gb_Medico.TabStop = false;
            this.Gb_Medico.Text = "Médico";
            // 
            // EspeciaMedico_Combo
            // 
            this.EspeciaMedico_Combo.FormattingEnabled = true;
            this.EspeciaMedico_Combo.Items.AddRange(new object[] {
            "Obstetra",
            "Cardiologista",
            "Oftalmologista"});
            this.EspeciaMedico_Combo.Location = new System.Drawing.Point(117, 62);
            this.EspeciaMedico_Combo.Name = "EspeciaMedico_Combo";
            this.EspeciaMedico_Combo.Size = new System.Drawing.Size(121, 21);
            this.EspeciaMedico_Combo.TabIndex = 40;
            // 
            // Mtxt_HorarioMedico
            // 
            this.Mtxt_HorarioMedico.Location = new System.Drawing.Point(117, 36);
            this.Mtxt_HorarioMedico.Mask = "00:00";
            this.Mtxt_HorarioMedico.Name = "Mtxt_HorarioMedico";
            this.Mtxt_HorarioMedico.PromptChar = ' ';
            this.Mtxt_HorarioMedico.Size = new System.Drawing.Size(100, 20);
            this.Mtxt_HorarioMedico.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "Horário";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 36;
            this.label7.Text = "Especialização";
            // 
            // Gb_DadosFun
            // 
            this.Gb_DadosFun.BackColor = System.Drawing.Color.Transparent;
            this.Gb_DadosFun.Controls.Add(this.perfilPB);
            this.Gb_DadosFun.Controls.Add(this.label16);
            this.Gb_DadosFun.Controls.Add(this.txt_StatusFun);
            this.Gb_DadosFun.Controls.Add(this.Mtxt_cpfFun);
            this.Gb_DadosFun.Controls.Add(this.Mtxt_rgFun);
            this.Gb_DadosFun.Controls.Add(this.label9);
            this.Gb_DadosFun.Controls.Add(this.label8);
            this.Gb_DadosFun.Controls.Add(this.FuncaoFun_Combo);
            this.Gb_DadosFun.Controls.Add(this.take);
            this.Gb_DadosFun.Controls.Add(this.btn_escolher_imagem);
            this.Gb_DadosFun.Controls.Add(this.txt_nomeFun);
            this.Gb_DadosFun.Controls.Add(this.label6);
            this.Gb_DadosFun.Controls.Add(this.label3);
            this.Gb_DadosFun.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.Gb_DadosFun.Location = new System.Drawing.Point(21, 60);
            this.Gb_DadosFun.Name = "Gb_DadosFun";
            this.Gb_DadosFun.Size = new System.Drawing.Size(317, 180);
            this.Gb_DadosFun.TabIndex = 37;
            this.Gb_DadosFun.TabStop = false;
            this.Gb_DadosFun.Text = "Dados Primários";
            // 
            // perfilPB
            // 
            this.perfilPB.Location = new System.Drawing.Point(208, 54);
            this.perfilPB.Name = "perfilPB";
            this.perfilPB.Size = new System.Drawing.Size(99, 87);
            this.perfilPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.perfilPB.TabIndex = 53;
            this.perfilPB.TabStop = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(48, 123);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(37, 13);
            this.label16.TabIndex = 52;
            this.label16.Text = "Status";
            // 
            // txt_StatusFun
            // 
            this.txt_StatusFun.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_StatusFun.Location = new System.Drawing.Point(90, 122);
            this.txt_StatusFun.Name = "txt_StatusFun";
            this.txt_StatusFun.Size = new System.Drawing.Size(79, 13);
            this.txt_StatusFun.TabIndex = 51;
            // 
            // Mtxt_cpfFun
            // 
            this.Mtxt_cpfFun.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Mtxt_cpfFun.Location = new System.Drawing.Point(90, 92);
            this.Mtxt_cpfFun.Mask = "000.000.000-A0";
            this.Mtxt_cpfFun.Name = "Mtxt_cpfFun";
            this.Mtxt_cpfFun.PromptChar = ' ';
            this.Mtxt_cpfFun.Size = new System.Drawing.Size(79, 13);
            this.Mtxt_cpfFun.TabIndex = 43;
            // 
            // Mtxt_rgFun
            // 
            this.Mtxt_rgFun.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Mtxt_rgFun.Location = new System.Drawing.Point(90, 62);
            this.Mtxt_rgFun.Mask = "00.000.000-A";
            this.Mtxt_rgFun.Name = "Mtxt_rgFun";
            this.Mtxt_rgFun.PromptChar = ' ';
            this.Mtxt_rgFun.Size = new System.Drawing.Size(79, 13);
            this.Mtxt_rgFun.TabIndex = 42;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(61, 93);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 13);
            this.label9.TabIndex = 45;
            this.label9.Text = "Cpf";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(65, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(21, 13);
            this.label8.TabIndex = 44;
            this.label8.Text = "Rg";
            // 
            // FuncaoFun_Combo
            // 
            this.FuncaoFun_Combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FuncaoFun_Combo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FuncaoFun_Combo.FormattingEnabled = true;
            this.FuncaoFun_Combo.Items.AddRange(new object[] {
            "Médico",
            "Enfermeiro"});
            this.FuncaoFun_Combo.Location = new System.Drawing.Point(90, 149);
            this.FuncaoFun_Combo.Name = "FuncaoFun_Combo";
            this.FuncaoFun_Combo.Size = new System.Drawing.Size(100, 21);
            this.FuncaoFun_Combo.TabIndex = 4;
            this.FuncaoFun_Combo.SelectedIndexChanged += new System.EventHandler(this.FuncaoFun_Combo_SelectedIndexChanged);
            // 
            // take
            // 
            this.take.BackColor = System.Drawing.Color.White;
            this.take.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.take.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.take.Location = new System.Drawing.Point(267, 147);
            this.take.Name = "take";
            this.take.Size = new System.Drawing.Size(40, 23);
            this.take.TabIndex = 6;
            this.take.Text = "Tirar";
            this.take.UseVisualStyleBackColor = false;
            this.take.Click += new System.EventHandler(this.tirar_foto);
            // 
            // btn_escolher_imagem
            // 
            this.btn_escolher_imagem.BackColor = System.Drawing.Color.White;
            this.btn_escolher_imagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_escolher_imagem.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btn_escolher_imagem.Location = new System.Drawing.Point(208, 147);
            this.btn_escolher_imagem.Name = "btn_escolher_imagem";
            this.btn_escolher_imagem.Size = new System.Drawing.Size(60, 23);
            this.btn_escolher_imagem.TabIndex = 5;
            this.btn_escolher_imagem.Text = "Neste Pc";
            this.btn_escolher_imagem.UseVisualStyleBackColor = false;
            this.btn_escolher_imagem.Click += new System.EventHandler(this.inserir_imagem);
            // 
            // txt_nomeFun
            // 
            this.txt_nomeFun.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_nomeFun.Location = new System.Drawing.Point(90, 33);
            this.txt_nomeFun.MaxLength = 75;
            this.txt_nomeFun.Name = "txt_nomeFun";
            this.txt_nomeFun.Size = new System.Drawing.Size(217, 13);
            this.txt_nomeFun.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Função";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Nome";
            // 
            // lbdone
            // 
            this.lbdone.AutoSize = true;
            this.lbdone.BackColor = System.Drawing.Color.Transparent;
            this.lbdone.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbdone.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbdone.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbdone.Location = new System.Drawing.Point(148, 371);
            this.lbdone.Name = "lbdone";
            this.lbdone.Size = new System.Drawing.Size(63, 18);
            this.lbdone.TabIndex = 43;
            this.lbdone.Text = "Concluir";
            this.lbdone.Click += new System.EventHandler(this.Concluir);
            // 
            // GB_busca
            // 
            this.GB_busca.BackColor = System.Drawing.Color.Transparent;
            this.GB_busca.Controls.Add(this.lbbuscaerro);
            this.GB_busca.Controls.Add(this.Mtxtbusca);
            this.GB_busca.Controls.Add(this.BtnBuscar);
            this.GB_busca.Controls.Add(this.label2);
            this.GB_busca.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.GB_busca.Location = new System.Drawing.Point(21, 9);
            this.GB_busca.Name = "GB_busca";
            this.GB_busca.Size = new System.Drawing.Size(317, 46);
            this.GB_busca.TabIndex = 45;
            this.GB_busca.TabStop = false;
            this.GB_busca.Text = "Pesquisa";
            this.GB_busca.Visible = false;
            // 
            // lbbuscaerro
            // 
            this.lbbuscaerro.AutoSize = true;
            this.lbbuscaerro.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbbuscaerro.Location = new System.Drawing.Point(206, 21);
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
            this.Mtxtbusca.Name = "Mtxtbusca";
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
            this.BtnBuscar.Click += new System.EventHandler(this.buscarFun);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(3, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "Buscar";
            // 
            // Cadastro_Funcionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(357, 400);
            this.Controls.Add(this.info1lb);
            this.Controls.Add(this.lbdone);
            this.Controls.Add(this.Gb_Medico);
            this.Controls.Add(this.Gb_DadosFun);
            this.Controls.Add(this.GB_busca);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Cadastro_Funcionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro_Funcionario";
            this.Load += new System.EventHandler(this.Cadastro_Funcionario_Load);
            this.Gb_Medico.ResumeLayout(false);
            this.Gb_Medico.PerformLayout();
            this.Gb_DadosFun.ResumeLayout(false);
            this.Gb_DadosFun.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.perfilPB)).EndInit();
            this.GB_busca.ResumeLayout(false);
            this.GB_busca.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label info1lb;
        private System.Windows.Forms.GroupBox Gb_Medico;
        private System.Windows.Forms.ComboBox EspeciaMedico_Combo;
        private System.Windows.Forms.MaskedTextBox Mtxt_HorarioMedico;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox Gb_DadosFun;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txt_StatusFun;
        private System.Windows.Forms.MaskedTextBox Mtxt_cpfFun;
        private System.Windows.Forms.MaskedTextBox Mtxt_rgFun;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox FuncaoFun_Combo;
        private System.Windows.Forms.Button take;
        private System.Windows.Forms.Button btn_escolher_imagem;
        private System.Windows.Forms.TextBox txt_nomeFun;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox perfilPB;
        private System.Windows.Forms.Label lbdone;
        private System.Windows.Forms.GroupBox GB_busca;
        private System.Windows.Forms.Label lbbuscaerro;
        private System.Windows.Forms.MaskedTextBox Mtxtbusca;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.Label label2;
    }
}