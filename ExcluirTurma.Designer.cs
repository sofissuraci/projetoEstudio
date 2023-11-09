namespace Estudio
{
    partial class ExcluirTurma
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
            this.txtHora = new System.Windows.Forms.TextBox();
            this.txtDiaSemana = new System.Windows.Forms.TextBox();
            this.cbmIdMod = new System.Windows.Forms.ComboBox();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblDiaSemana = new System.Windows.Forms.Label();
            this.lblModalidade = new System.Windows.Forms.Label();
            this.btnExcuir = new System.Windows.Forms.Button();
            this.grbTurma.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbTurma
            // 
            this.grbTurma.Controls.Add(this.txtHora);
            this.grbTurma.Controls.Add(this.txtDiaSemana);
            this.grbTurma.Controls.Add(this.cbmIdMod);
            this.grbTurma.Controls.Add(this.lblHora);
            this.grbTurma.Controls.Add(this.lblDiaSemana);
            this.grbTurma.Controls.Add(this.lblModalidade);
            this.grbTurma.Controls.Add(this.btnExcuir);
            this.grbTurma.Location = new System.Drawing.Point(116, 134);
            this.grbTurma.Name = "grbTurma";
            this.grbTurma.Size = new System.Drawing.Size(325, 152);
            this.grbTurma.TabIndex = 0;
            this.grbTurma.TabStop = false;
            this.grbTurma.Text = "Turma";
            // 
            // txtHora
            // 
            this.txtHora.Location = new System.Drawing.Point(110, 82);
            this.txtHora.Name = "txtHora";
            this.txtHora.Size = new System.Drawing.Size(163, 20);
            this.txtHora.TabIndex = 10;
            // 
            // txtDiaSemana
            // 
            this.txtDiaSemana.Location = new System.Drawing.Point(110, 57);
            this.txtDiaSemana.Name = "txtDiaSemana";
            this.txtDiaSemana.Size = new System.Drawing.Size(163, 20);
            this.txtDiaSemana.TabIndex = 9;
            // 
            // cbmIdMod
            // 
            this.cbmIdMod.FormattingEnabled = true;
            this.cbmIdMod.Location = new System.Drawing.Point(110, 30);
            this.cbmIdMod.Name = "cbmIdMod";
            this.cbmIdMod.Size = new System.Drawing.Size(163, 21);
            this.cbmIdMod.TabIndex = 7;
            this.cbmIdMod.SelectedIndexChanged += new System.EventHandler(this.cbmIdTurma_SelectedIndexChanged);
            this.cbmIdMod.SelectedValueChanged += new System.EventHandler(this.cbmIdMod_SelectedValueChanged);
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Location = new System.Drawing.Point(71, 84);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(33, 13);
            this.lblHora.TabIndex = 3;
            this.lblHora.Text = "Hora:";
            // 
            // lblDiaSemana
            // 
            this.lblDiaSemana.AutoSize = true;
            this.lblDiaSemana.Location = new System.Drawing.Point(21, 57);
            this.lblDiaSemana.Name = "lblDiaSemana";
            this.lblDiaSemana.Size = new System.Drawing.Size(83, 13);
            this.lblDiaSemana.TabIndex = 2;
            this.lblDiaSemana.Text = "Dia da Semana:";
            // 
            // lblModalidade
            // 
            this.lblModalidade.AutoSize = true;
            this.lblModalidade.Location = new System.Drawing.Point(21, 33);
            this.lblModalidade.Name = "lblModalidade";
            this.lblModalidade.Size = new System.Drawing.Size(79, 13);
            this.lblModalidade.TabIndex = 1;
            this.lblModalidade.Text = "ID Modalidade:";
            // 
            // btnExcuir
            // 
            this.btnExcuir.Location = new System.Drawing.Point(24, 108);
            this.btnExcuir.Name = "btnExcuir";
            this.btnExcuir.Size = new System.Drawing.Size(249, 23);
            this.btnExcuir.TabIndex = 0;
            this.btnExcuir.Text = "Excluir";
            this.btnExcuir.UseVisualStyleBackColor = true;
            this.btnExcuir.Click += new System.EventHandler(this.btnExcuir_Click);
            // 
            // ExcluirTurma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 445);
            this.Controls.Add(this.grbTurma);
            this.Name = "ExcluirTurma";
            this.Text = "Excluir Turma";
            this.Load += new System.EventHandler(this.Form9_Load);
            this.grbTurma.ResumeLayout(false);
            this.grbTurma.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbTurma;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblDiaSemana;
        private System.Windows.Forms.Label lblModalidade;
        private System.Windows.Forms.Button btnExcuir;
        private System.Windows.Forms.ComboBox cbmIdMod;
        private System.Windows.Forms.TextBox txtHora;
        private System.Windows.Forms.TextBox txtDiaSemana;
    }
}