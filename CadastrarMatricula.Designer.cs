namespace Estudio
{
    partial class CadastrarMatricula
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
            this.lblTurma = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.ltbTurma = new System.Windows.Forms.ListBox();
            this.gpbMatricula = new System.Windows.Forms.GroupBox();
            this.gpbMatricula.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Modalidade:";
            // 
            // lblTurma
            // 
            this.lblTurma.AutoSize = true;
            this.lblTurma.Location = new System.Drawing.Point(6, 81);
            this.lblTurma.Name = "lblTurma";
            this.lblTurma.Size = new System.Drawing.Size(40, 13);
            this.lblTurma.TabIndex = 1;
            this.lblTurma.Text = "Turma:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(222, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "CPF:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(77, 41);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(258, 42);
            this.maskedTextBox1.Mask = "999.999.999-99";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(85, 20);
            this.maskedTextBox1.TabIndex = 4;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(9, 265);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(334, 23);
            this.btnCadastrar.TabIndex = 5;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            // 
            // ltbTurma
            // 
            this.ltbTurma.FormattingEnabled = true;
            this.ltbTurma.Location = new System.Drawing.Point(9, 97);
            this.ltbTurma.Name = "ltbTurma";
            this.ltbTurma.Size = new System.Drawing.Size(334, 147);
            this.ltbTurma.TabIndex = 6;
            // 
            // gpbMatricula
            // 
            this.gpbMatricula.Controls.Add(this.label1);
            this.gpbMatricula.Controls.Add(this.btnCadastrar);
            this.gpbMatricula.Controls.Add(this.ltbTurma);
            this.gpbMatricula.Controls.Add(this.maskedTextBox1);
            this.gpbMatricula.Controls.Add(this.comboBox1);
            this.gpbMatricula.Controls.Add(this.label3);
            this.gpbMatricula.Controls.Add(this.lblTurma);
            this.gpbMatricula.Location = new System.Drawing.Point(207, 61);
            this.gpbMatricula.Name = "gpbMatricula";
            this.gpbMatricula.Size = new System.Drawing.Size(353, 311);
            this.gpbMatricula.TabIndex = 7;
            this.gpbMatricula.TabStop = false;
            this.gpbMatricula.Text = "Cadastrar Matricula";
            // 
            // CadastrarMatricula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gpbMatricula);
            this.Name = "CadastrarMatricula";
            this.Text = "CadastrarMatricula";
            this.gpbMatricula.ResumeLayout(false);
            this.gpbMatricula.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTurma;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.ListBox ltbTurma;
        private System.Windows.Forms.GroupBox gpbMatricula;
    }
}