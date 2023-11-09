namespace Estudio
{
    partial class CadastrarTurma
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
            this.grbTurma = new System.Windows.Forms.GroupBox();
            this.txtHora = new System.Windows.Forms.MaskedTextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.txtDiaSemana = new System.Windows.Forms.TextBox();
            this.txtProfessor = new System.Windows.Forms.TextBox();
            this.txtModalidade = new System.Windows.Forms.TextBox();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblDiaSemana = new System.Windows.Forms.Label();
            this.lblProfessor = new System.Windows.Forms.Label();
            this.lblModalidade = new System.Windows.Forms.Label();
            this.cmbModalidade = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grbTurma.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbTurma
            // 
            this.grbTurma.Controls.Add(this.label1);
            this.grbTurma.Controls.Add(this.cmbModalidade);
            this.grbTurma.Controls.Add(this.txtHora);
            this.grbTurma.Controls.Add(this.btnCadastrar);
            this.grbTurma.Controls.Add(this.txtDiaSemana);
            this.grbTurma.Controls.Add(this.txtProfessor);
            this.grbTurma.Controls.Add(this.txtModalidade);
            this.grbTurma.Controls.Add(this.lblHora);
            this.grbTurma.Controls.Add(this.lblDiaSemana);
            this.grbTurma.Controls.Add(this.lblProfessor);
            this.grbTurma.Controls.Add(this.lblModalidade);
            this.grbTurma.Location = new System.Drawing.Point(12, 12);
            this.grbTurma.Name = "grbTurma";
            this.grbTurma.Size = new System.Drawing.Size(425, 227);
            this.grbTurma.TabIndex = 0;
            this.grbTurma.TabStop = false;
            this.grbTurma.Text = "Turma";
            // 
            // txtHora
            // 
            this.txtHora.Location = new System.Drawing.Point(122, 138);
            this.txtHora.Mask = "90:00";
            this.txtHora.Name = "txtHora";
            this.txtHora.Size = new System.Drawing.Size(231, 20);
            this.txtHora.TabIndex = 10;
            this.txtHora.ValidatingType = typeof(System.DateTime);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(36, 174);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(317, 23);
            this.btnCadastrar.TabIndex = 8;
            this.btnCadastrar.Text = "Cadastrar\r\n";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // txtDiaSemana
            // 
            this.txtDiaSemana.Location = new System.Drawing.Point(122, 109);
            this.txtDiaSemana.Name = "txtDiaSemana";
            this.txtDiaSemana.Size = new System.Drawing.Size(231, 20);
            this.txtDiaSemana.TabIndex = 6;
            // 
            // txtProfessor
            // 
            this.txtProfessor.Location = new System.Drawing.Point(122, 83);
            this.txtProfessor.Name = "txtProfessor";
            this.txtProfessor.Size = new System.Drawing.Size(231, 20);
            this.txtProfessor.TabIndex = 5;
            // 
            // txtModalidade
            // 
            this.txtModalidade.Location = new System.Drawing.Point(122, 57);
            this.txtModalidade.Name = "txtModalidade";
            this.txtModalidade.Size = new System.Drawing.Size(231, 20);
            this.txtModalidade.TabIndex = 4;
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Location = new System.Drawing.Point(83, 138);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(33, 13);
            this.lblHora.TabIndex = 3;
            this.lblHora.Text = "Hora:";
            // 
            // lblDiaSemana
            // 
            this.lblDiaSemana.AutoSize = true;
            this.lblDiaSemana.Location = new System.Drawing.Point(33, 109);
            this.lblDiaSemana.Name = "lblDiaSemana";
            this.lblDiaSemana.Size = new System.Drawing.Size(83, 13);
            this.lblDiaSemana.TabIndex = 2;
            this.lblDiaSemana.Text = "Dia da Semana:";
            // 
            // lblProfessor
            // 
            this.lblProfessor.AutoSize = true;
            this.lblProfessor.Location = new System.Drawing.Point(62, 83);
            this.lblProfessor.Name = "lblProfessor";
            this.lblProfessor.Size = new System.Drawing.Size(54, 13);
            this.lblProfessor.TabIndex = 1;
            this.lblProfessor.Text = "Professor:";
            // 
            // lblModalidade
            // 
            this.lblModalidade.AutoSize = true;
            this.lblModalidade.Location = new System.Drawing.Point(37, 60);
            this.lblModalidade.Name = "lblModalidade";
            this.lblModalidade.Size = new System.Drawing.Size(79, 13);
            this.lblModalidade.TabIndex = 0;
            this.lblModalidade.Text = "ID Modalidade:";
            // 
            // cmbModalidade
            // 
            this.cmbModalidade.FormattingEnabled = true;
            this.cmbModalidade.Location = new System.Drawing.Point(122, 30);
            this.cmbModalidade.Name = "cmbModalidade";
            this.cmbModalidade.Size = new System.Drawing.Size(231, 21);
            this.cmbModalidade.TabIndex = 12;
            this.cmbModalidade.SelectedIndexChanged += new System.EventHandler(this.cmbModalidade_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Modalidades:";
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 406);
            this.Controls.Add(this.grbTurma);
            this.Name = "Form8";
            this.Text = "Cadastro de Turma";
            this.Load += new System.EventHandler(this.Form8_Load);
            this.grbTurma.ResumeLayout(false);
            this.grbTurma.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbTurma;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.TextBox txtDiaSemana;
        private System.Windows.Forms.TextBox txtProfessor;
        private System.Windows.Forms.TextBox txtModalidade;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblDiaSemana;
        private System.Windows.Forms.Label lblProfessor;
        private System.Windows.Forms.Label lblModalidade;
        private System.Windows.Forms.MaskedTextBox txtHora;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbModalidade;
    }
}