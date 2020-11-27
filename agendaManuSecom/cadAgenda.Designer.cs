namespace agendaManuSecom
{
    partial class cadAgenda
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbtecnico = new System.Windows.Forms.ComboBox();
            this.cbSituacao = new System.Windows.Forms.ComboBox();
            this.txtCodCliente = new System.Windows.Forms.TextBox();
            this.txtContaOperacional = new System.Windows.Forms.TextBox();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.txtMotivo = new System.Windows.Forms.TextBox();
            this.bntSalvar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpAtendimento = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(364, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo do cliente:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(606, 34);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Conta:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 114);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nome do cliente:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 212);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Motivo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 375);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Situação:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 34);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Técnico:";
            // 
            // cbtecnico
            // 
            this.cbtecnico.FormattingEnabled = true;
            this.cbtecnico.Location = new System.Drawing.Point(37, 54);
            this.cbtecnico.Margin = new System.Windows.Forms.Padding(4);
            this.cbtecnico.Name = "cbtecnico";
            this.cbtecnico.Size = new System.Drawing.Size(289, 24);
            this.cbtecnico.TabIndex = 6;
            // 
            // cbSituacao
            // 
            this.cbSituacao.FormattingEnabled = true;
            this.cbSituacao.Items.AddRange(new object[] {
            "AGENDADO",
            "CONCLUIDA",
            "CONCLUIDA COM RETORNO",
            "PENDENTE",
            "FECHADO"});
            this.cbSituacao.Location = new System.Drawing.Point(34, 395);
            this.cbSituacao.Margin = new System.Windows.Forms.Padding(4);
            this.cbSituacao.Name = "cbSituacao";
            this.cbSituacao.Size = new System.Drawing.Size(289, 24);
            this.cbSituacao.TabIndex = 7;
            // 
            // txtCodCliente
            // 
            this.txtCodCliente.Location = new System.Drawing.Point(368, 54);
            this.txtCodCliente.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodCliente.Name = "txtCodCliente";
            this.txtCodCliente.Size = new System.Drawing.Size(178, 22);
            this.txtCodCliente.TabIndex = 8;
            this.txtCodCliente.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtContaOperacional
            // 
            this.txtContaOperacional.Location = new System.Drawing.Point(611, 55);
            this.txtContaOperacional.Margin = new System.Windows.Forms.Padding(4);
            this.txtContaOperacional.Name = "txtContaOperacional";
            this.txtContaOperacional.Size = new System.Drawing.Size(178, 22);
            this.txtContaOperacional.TabIndex = 9;
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.Location = new System.Drawing.Point(37, 149);
            this.txtNomeCliente.Margin = new System.Windows.Forms.Padding(4);
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.Size = new System.Drawing.Size(509, 22);
            this.txtNomeCliente.TabIndex = 10;
            // 
            // txtMotivo
            // 
            this.txtMotivo.Location = new System.Drawing.Point(37, 245);
            this.txtMotivo.Margin = new System.Windows.Forms.Padding(4);
            this.txtMotivo.Multiline = true;
            this.txtMotivo.Name = "txtMotivo";
            this.txtMotivo.Size = new System.Drawing.Size(752, 86);
            this.txtMotivo.TabIndex = 11;
            // 
            // bntSalvar
            // 
            this.bntSalvar.Location = new System.Drawing.Point(356, 455);
            this.bntSalvar.Margin = new System.Windows.Forms.Padding(4);
            this.bntSalvar.Name = "bntSalvar";
            this.bntSalvar.Size = new System.Drawing.Size(100, 28);
            this.bntSalvar.TabIndex = 12;
            this.bntSalvar.Text = "SALVAR";
            this.bntSalvar.UseVisualStyleBackColor = true;
            this.bntSalvar.Click += new System.EventHandler(this.bntSalvar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(606, 114);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "Data do atendimento:";
            // 
            // dtpAtendimento
            // 
            this.dtpAtendimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpAtendimento.Location = new System.Drawing.Point(611, 149);
            this.dtpAtendimento.Margin = new System.Windows.Forms.Padding(4);
            this.dtpAtendimento.Name = "dtpAtendimento";
            this.dtpAtendimento.Size = new System.Drawing.Size(178, 22);
            this.dtpAtendimento.TabIndex = 15;
            // 
            // cadAgenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 503);
            this.Controls.Add(this.dtpAtendimento);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.bntSalvar);
            this.Controls.Add(this.txtMotivo);
            this.Controls.Add(this.txtNomeCliente);
            this.Controls.Add(this.txtContaOperacional);
            this.Controls.Add(this.txtCodCliente);
            this.Controls.Add(this.cbSituacao);
            this.Controls.Add(this.cbtecnico);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "cadAgenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CADASTRAR AGENDA";
            this.Load += new System.EventHandler(this.cadAgenda_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbtecnico;
        private System.Windows.Forms.ComboBox cbSituacao;
        private System.Windows.Forms.TextBox txtCodCliente;
        private System.Windows.Forms.TextBox txtContaOperacional;
        private System.Windows.Forms.TextBox txtNomeCliente;
        private System.Windows.Forms.TextBox txtMotivo;
        private System.Windows.Forms.Button bntSalvar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpAtendimento;
    }
}