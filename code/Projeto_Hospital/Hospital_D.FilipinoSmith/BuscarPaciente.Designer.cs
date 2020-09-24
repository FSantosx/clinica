namespace Hospital_D.FilipinoSmith
{
    partial class BuscarPaciente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuscarPaciente));
            this.label2 = new System.Windows.Forms.Label();
            this.Gb_busca = new System.Windows.Forms.GroupBox();
            this.Mtxtbusca = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lbbuscaerro = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtnomepac = new System.Windows.Forms.TextBox();
            this.nomelb = new System.Windows.Forms.Label();
            this.GB_dados = new System.Windows.Forms.GroupBox();
            this.txtcellpac = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txttellpac = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pbperfil = new System.Windows.Forms.PictureBox();
            this.txtleitopac = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtsitupac = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Gb_busca.SuspendLayout();
            this.GB_dados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbperfil)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(17, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "Buscar";
            // 
            // Gb_busca
            // 
            this.Gb_busca.BackColor = System.Drawing.Color.Transparent;
            this.Gb_busca.Controls.Add(this.Mtxtbusca);
            this.Gb_busca.Controls.Add(this.label6);
            this.Gb_busca.Controls.Add(this.lbbuscaerro);
            this.Gb_busca.Controls.Add(this.button2);
            this.Gb_busca.Controls.Add(this.button1);
            this.Gb_busca.Controls.Add(this.label2);
            this.Gb_busca.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Gb_busca.Location = new System.Drawing.Point(49, 7);
            this.Gb_busca.Name = "Gb_busca";
            this.Gb_busca.Size = new System.Drawing.Size(213, 124);
            this.Gb_busca.TabIndex = 34;
            this.Gb_busca.TabStop = false;
            this.Gb_busca.Text = "Pesquisar";
            // 
            // Mtxtbusca
            // 
            this.Mtxtbusca.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Mtxtbusca.Location = new System.Drawing.Point(63, 27);
            this.Mtxtbusca.Mask = "00000000000";
            this.Mtxtbusca.Name = "Mtxtbusca";
            this.Mtxtbusca.PromptChar = ' ';
            this.Mtxtbusca.Size = new System.Drawing.Size(100, 13);
            this.Mtxtbusca.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(84, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 12);
            this.label6.TabIndex = 37;
            this.label6.Text = "( ID ou CPF )";
            // 
            // lbbuscaerro
            // 
            this.lbbuscaerro.AutoSize = true;
            this.lbbuscaerro.Location = new System.Drawing.Point(72, 73);
            this.lbbuscaerro.Name = "lbbuscaerro";
            this.lbbuscaerro.Size = new System.Drawing.Size(80, 13);
            this.lbbuscaerro.TabIndex = 35;
            this.lbbuscaerro.Text = "Busca Inválida!";
            this.lbbuscaerro.Visible = false;
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(46, 95);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(53, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Voltar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.voltar);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(117, 95);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(55, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Go";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buscar);
            // 
            // txtnomepac
            // 
            this.txtnomepac.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtnomepac.Location = new System.Drawing.Point(58, 32);
            this.txtnomepac.Name = "txtnomepac";
            this.txtnomepac.ReadOnly = true;
            this.txtnomepac.Size = new System.Drawing.Size(200, 13);
            this.txtnomepac.TabIndex = 3;
            // 
            // nomelb
            // 
            this.nomelb.AutoSize = true;
            this.nomelb.BackColor = System.Drawing.Color.Transparent;
            this.nomelb.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.nomelb.Location = new System.Drawing.Point(20, 32);
            this.nomelb.Name = "nomelb";
            this.nomelb.Size = new System.Drawing.Size(35, 13);
            this.nomelb.TabIndex = 36;
            this.nomelb.Text = "Nome";
            // 
            // GB_dados
            // 
            this.GB_dados.BackColor = System.Drawing.Color.Transparent;
            this.GB_dados.Controls.Add(this.txtcellpac);
            this.GB_dados.Controls.Add(this.label5);
            this.GB_dados.Controls.Add(this.txttellpac);
            this.GB_dados.Controls.Add(this.label4);
            this.GB_dados.Controls.Add(this.pbperfil);
            this.GB_dados.Controls.Add(this.txtleitopac);
            this.GB_dados.Controls.Add(this.label3);
            this.GB_dados.Controls.Add(this.txtsitupac);
            this.GB_dados.Controls.Add(this.label1);
            this.GB_dados.Controls.Add(this.txtnomepac);
            this.GB_dados.Controls.Add(this.nomelb);
            this.GB_dados.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.GB_dados.Location = new System.Drawing.Point(15, 142);
            this.GB_dados.Name = "GB_dados";
            this.GB_dados.Size = new System.Drawing.Size(280, 179);
            this.GB_dados.TabIndex = 37;
            this.GB_dados.TabStop = false;
            this.GB_dados.Text = "Dados";
            this.GB_dados.Visible = false;
            // 
            // txtcellpac
            // 
            this.txtcellpac.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtcellpac.Location = new System.Drawing.Point(58, 138);
            this.txtcellpac.Name = "txtcellpac";
            this.txtcellpac.ReadOnly = true;
            this.txtcellpac.Size = new System.Drawing.Size(100, 13);
            this.txtcellpac.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Location = new System.Drawing.Point(13, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 45;
            this.label5.Text = "Celular";
            // 
            // txttellpac
            // 
            this.txttellpac.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txttellpac.Location = new System.Drawing.Point(58, 112);
            this.txttellpac.Name = "txttellpac";
            this.txttellpac.ReadOnly = true;
            this.txttellpac.Size = new System.Drawing.Size(100, 13);
            this.txttellpac.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Location = new System.Drawing.Point(6, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 43;
            this.label4.Text = "Telefone";
            // 
            // pbperfil
            // 
            this.pbperfil.Location = new System.Drawing.Point(176, 60);
            this.pbperfil.Name = "pbperfil";
            this.pbperfil.Size = new System.Drawing.Size(82, 91);
            this.pbperfil.TabIndex = 41;
            this.pbperfil.TabStop = false;
            // 
            // txtleitopac
            // 
            this.txtleitopac.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtleitopac.Location = new System.Drawing.Point(58, 85);
            this.txtleitopac.Name = "txtleitopac";
            this.txtleitopac.ReadOnly = true;
            this.txtleitopac.Size = new System.Drawing.Size(100, 13);
            this.txtleitopac.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Location = new System.Drawing.Point(25, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 40;
            this.label3.Text = "Leito";
            // 
            // txtsitupac
            // 
            this.txtsitupac.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtsitupac.Location = new System.Drawing.Point(58, 60);
            this.txtsitupac.Name = "txtsitupac";
            this.txtsitupac.ReadOnly = true;
            this.txtsitupac.Size = new System.Drawing.Size(100, 13);
            this.txtsitupac.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(6, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "Situação";
            // 
            // BuscarPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(310, 333);
            this.Controls.Add(this.GB_dados);
            this.Controls.Add(this.Gb_busca);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BuscarPaciente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BuscarPaciente";
            this.Gb_busca.ResumeLayout(false);
            this.Gb_busca.PerformLayout();
            this.GB_dados.ResumeLayout(false);
            this.GB_dados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbperfil)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox Gb_busca;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lbbuscaerro;
        private System.Windows.Forms.TextBox txtnomepac;
        private System.Windows.Forms.Label nomelb;
        private System.Windows.Forms.GroupBox GB_dados;
        private System.Windows.Forms.TextBox txtsitupac;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtcellpac;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txttellpac;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pbperfil;
        private System.Windows.Forms.TextBox txtleitopac;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox Mtxtbusca;
    }
}