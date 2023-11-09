
namespace Estudio
{
    partial class atualizaTurma
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
            this.grbAtualizar = new System.Windows.Forms.GroupBox();
            this.cmbModalidade = new System.Windows.Forms.ComboBox();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.txtHora = new System.Windows.Forms.MaskedTextBox();
            this.txtDiaSemana = new System.Windows.Forms.TextBox();
            this.txtProfessor = new System.Windows.Forms.TextBox();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblDiaSemana = new System.Windows.Forms.Label();
            this.lblProfessor = new System.Windows.Forms.Label();
            this.lblModalidade = new System.Windows.Forms.Label();
            this.grbAtualizar.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbAtualizar
            // 
            this.grbAtualizar.Controls.Add(this.cmbModalidade);
            this.grbAtualizar.Controls.Add(this.btnAtualizar);
            this.grbAtualizar.Controls.Add(this.txtHora);
            this.grbAtualizar.Controls.Add(this.txtDiaSemana);
            this.grbAtualizar.Controls.Add(this.txtProfessor);
            this.grbAtualizar.Controls.Add(this.lblHora);
            this.grbAtualizar.Controls.Add(this.lblDiaSemana);
            this.grbAtualizar.Controls.Add(this.lblProfessor);
            this.grbAtualizar.Controls.Add(this.lblModalidade);
            this.grbAtualizar.Location = new System.Drawing.Point(164, 79);
            this.grbAtualizar.Name = "grbAtualizar";
            this.grbAtualizar.Size = new System.Drawing.Size(428, 213);
            this.grbAtualizar.TabIndex = 0;
            this.grbAtualizar.TabStop = false;
            this.grbAtualizar.Text = "Atualizar Turma";
            this.grbAtualizar.Enter += new System.EventHandler(this.grbAtualizar_Enter);
            // 
            // cmbModalidade
            // 
            this.cmbModalidade.FormattingEnabled = true;
            this.cmbModalidade.Location = new System.Drawing.Point(137, 49);
            this.cmbModalidade.Name = "cmbModalidade";
            this.cmbModalidade.Size = new System.Drawing.Size(231, 21);
            this.cmbModalidade.TabIndex = 25;
            this.cmbModalidade.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(51, 166);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(316, 23);
            this.btnAtualizar.TabIndex = 23;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // txtHora
            // 
            this.txtHora.Location = new System.Drawing.Point(137, 139);
            this.txtHora.Mask = "90:00";
            this.txtHora.Name = "txtHora";
            this.txtHora.Size = new System.Drawing.Size(231, 20);
            this.txtHora.TabIndex = 20;
            this.txtHora.ValidatingType = typeof(System.DateTime);
            // 
            // txtDiaSemana
            // 
            this.txtDiaSemana.Location = new System.Drawing.Point(137, 110);
            this.txtDiaSemana.Name = "txtDiaSemana";
            this.txtDiaSemana.Size = new System.Drawing.Size(231, 20);
            this.txtDiaSemana.TabIndex = 17;
            // 
            // txtProfessor
            // 
            this.txtProfessor.Location = new System.Drawing.Point(137, 84);
            this.txtProfessor.Name = "txtProfessor";
            this.txtProfessor.Size = new System.Drawing.Size(231, 20);
            this.txtProfessor.TabIndex = 16;
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Location = new System.Drawing.Point(98, 139);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(33, 13);
            this.lblHora.TabIndex = 14;
            this.lblHora.Text = "Hora:";
            // 
            // lblDiaSemana
            // 
            this.lblDiaSemana.AutoSize = true;
            this.lblDiaSemana.Location = new System.Drawing.Point(48, 110);
            this.lblDiaSemana.Name = "lblDiaSemana";
            this.lblDiaSemana.Size = new System.Drawing.Size(83, 13);
            this.lblDiaSemana.TabIndex = 13;
            this.lblDiaSemana.Text = "Dia da Semana:";
            // 
            // lblProfessor
            // 
            this.lblProfessor.AutoSize = true;
            this.lblProfessor.Location = new System.Drawing.Point(77, 84);
            this.lblProfessor.Name = "lblProfessor";
            this.lblProfessor.Size = new System.Drawing.Size(54, 13);
            this.lblProfessor.TabIndex = 12;
            this.lblProfessor.Text = "Professor:";
            // 
            // lblModalidade
            // 
            this.lblModalidade.AutoSize = true;
            this.lblModalidade.Location = new System.Drawing.Point(52, 52);
            this.lblModalidade.Name = "lblModalidade";
            this.lblModalidade.Size = new System.Drawing.Size(79, 13);
            this.lblModalidade.TabIndex = 11;
            this.lblModalidade.Text = "ID Modalidade:";
            // 
            // atualizaTurma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grbAtualizar);
            this.Name = "atualizaTurma";
            this.Text = "Atualiza Turma";
            this.Load += new System.EventHandler(this.Form10_Load);
            this.grbAtualizar.ResumeLayout(false);
            this.grbAtualizar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbAtualizar;
        private System.Windows.Forms.MaskedTextBox txtHora;
        private System.Windows.Forms.TextBox txtDiaSemana;
        private System.Windows.Forms.TextBox txtProfessor;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblDiaSemana;
        private System.Windows.Forms.Label lblProfessor;
        private System.Windows.Forms.Label lblModalidade;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.ComboBox cmbModalidade;
    }
}