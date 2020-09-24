namespace Hospital_D.FilipinoSmith
{
    partial class CadPacinleito
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
            this.Gb_cadLeito = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtbusca = new System.Windows.Forms.TextBox();
            this.Gb_cadLeito.SuspendLayout();
            this.SuspendLayout();
            // 
            // Gb_cadLeito
            // 
            this.Gb_cadLeito.BackColor = System.Drawing.Color.Transparent;
            this.Gb_cadLeito.Controls.Add(this.button2);
            this.Gb_cadLeito.Controls.Add(this.button1);
            this.Gb_cadLeito.Controls.Add(this.txtbusca);
            this.Gb_cadLeito.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Gb_cadLeito.Location = new System.Drawing.Point(12, 12);
            this.Gb_cadLeito.Name = "Gb_cadLeito";
            this.Gb_cadLeito.Size = new System.Drawing.Size(260, 237);
            this.Gb_cadLeito.TabIndex = 0;
            this.Gb_cadLeito.TabStop = false;
            this.Gb_cadLeito.Text = "Cadastro em Leito";
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(24, 199);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(53, 23);
            this.button2.TabIndex = 36;
            this.button2.Text = "Voltar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(184, 199);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(55, 23);
            this.button1.TabIndex = 35;
            this.button1.Text = "Go";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txtbusca
            // 
            this.txtbusca.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbusca.Location = new System.Drawing.Point(79, 51);
            this.txtbusca.Name = "txtbusca";
            this.txtbusca.Size = new System.Drawing.Size(100, 13);
            this.txtbusca.TabIndex = 0;
            // 
            // CadPacinleito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Hospital_D.FilipinoSmith.Properties.Resources.fffffe;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.Gb_cadLeito);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CadPacinleito";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CadPacinleito";
            this.Load += new System.EventHandler(this.CadPacinleito_Load);
            this.Gb_cadLeito.ResumeLayout(false);
            this.Gb_cadLeito.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Gb_cadLeito;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtbusca;
    }
}