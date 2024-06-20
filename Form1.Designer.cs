namespace jogo_par_impar
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbPar = new System.Windows.Forms.RadioButton();
            this.rdbTmpar = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.btnJogar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome de Jogador:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(38, 66);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(296, 20);
            this.txtNome.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbTmpar);
            this.groupBox1.Controls.Add(this.rdbPar);
            this.groupBox1.Location = new System.Drawing.Point(38, 106);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(123, 39);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Escolha";
            // 
            // rdbPar
            // 
            this.rdbPar.AutoSize = true;
            this.rdbPar.Location = new System.Drawing.Point(7, 20);
            this.rdbPar.Name = "rdbPar";
            this.rdbPar.Size = new System.Drawing.Size(41, 17);
            this.rdbPar.TabIndex = 0;
            this.rdbPar.TabStop = true;
            this.rdbPar.Text = "Par";
            this.rdbPar.UseVisualStyleBackColor = true;
            // 
            // rdbTmpar
            // 
            this.rdbTmpar.AutoSize = true;
            this.rdbTmpar.Location = new System.Drawing.Point(54, 20);
            this.rdbTmpar.Name = "rdbTmpar";
            this.rdbTmpar.Size = new System.Drawing.Size(51, 17);
            this.rdbTmpar.TabIndex = 1;
            this.rdbTmpar.TabStop = true;
            this.rdbTmpar.Text = "Ímpar";
            this.rdbTmpar.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F);
            this.label2.Location = new System.Drawing.Point(198, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Valor";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(201, 123);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 20);
            this.txtValor.TabIndex = 4;
            // 
            // btnJogar
            // 
            this.btnJogar.BackColor = System.Drawing.SystemColors.Control;
            this.btnJogar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnJogar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnJogar.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F);
            this.btnJogar.Location = new System.Drawing.Point(130, 181);
            this.btnJogar.Name = "btnJogar";
            this.btnJogar.Size = new System.Drawing.Size(94, 43);
            this.btnJogar.TabIndex = 5;
            this.btnJogar.Text = "Jogar";
            this.btnJogar.UseVisualStyleBackColor = false;
            this.btnJogar.Click += new System.EventHandler(this.btnJogar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 253);
            this.Controls.Add(this.btnJogar);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbTmpar;
        private System.Windows.Forms.RadioButton rdbPar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Button btnJogar;
    }
}

