namespace DimensionamentoDeFrota
{
    partial class loginProf
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
            this.linkAluno = new System.Windows.Forms.LinkLabel();
            this.PROFESSOR = new System.Windows.Forms.Label();
            this.btnEntrarProf = new System.Windows.Forms.Button();
            this.txtSalaProf = new System.Windows.Forms.TextBox();
            this.txtNomeProf = new System.Windows.Forms.TextBox();
            this.btnCriarSala = new System.Windows.Forms.Button();
            this.txtSenhaProf = new System.Windows.Forms.TextBox();
            this.linkCadastro = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // linkAluno
            // 
            this.linkAluno.AutoSize = true;
            this.linkAluno.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkAluno.Location = new System.Drawing.Point(129, 388);
            this.linkAluno.Name = "linkAluno";
            this.linkAluno.Size = new System.Drawing.Size(105, 16);
            this.linkAluno.TabIndex = 7;
            this.linkAluno.TabStop = true;
            this.linkAluno.Text = "Entrar como Aluno";
            this.linkAluno.Click += new System.EventHandler(this.linkAluno_Click);
            // 
            // PROFESSOR
            // 
            this.PROFESSOR.AutoSize = true;
            this.PROFESSOR.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PROFESSOR.Location = new System.Drawing.Point(126, 101);
            this.PROFESSOR.Name = "PROFESSOR";
            this.PROFESSOR.Size = new System.Drawing.Size(100, 21);
            this.PROFESSOR.TabIndex = 0;
            this.PROFESSOR.Text = "PROFESSOR";
            // 
            // btnEntrarProf
            // 
            this.btnEntrarProf.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnEntrarProf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntrarProf.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrarProf.ForeColor = System.Drawing.Color.White;
            this.btnEntrarProf.Location = new System.Drawing.Point(130, 243);
            this.btnEntrarProf.Name = "btnEntrarProf";
            this.btnEntrarProf.Size = new System.Drawing.Size(100, 23);
            this.btnEntrarProf.TabIndex = 4;
            this.btnEntrarProf.Text = "Entrar";
            this.btnEntrarProf.UseVisualStyleBackColor = false;
            this.btnEntrarProf.Click += new System.EventHandler(this.btnEntrarProf_Click);
            // 
            // txtSalaProf
            // 
            this.txtSalaProf.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalaProf.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtSalaProf.Location = new System.Drawing.Point(130, 207);
            this.txtSalaProf.Name = "txtSalaProf";
            this.txtSalaProf.Size = new System.Drawing.Size(100, 21);
            this.txtSalaProf.TabIndex = 3;
            this.txtSalaProf.Text = "Sala:";
            this.txtSalaProf.Click += new System.EventHandler(this.txtSalaProf_Click);
            this.txtSalaProf.TextChanged += new System.EventHandler(this.txtSalaProf_TextChanged);
            // 
            // txtNomeProf
            // 
            this.txtNomeProf.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeProf.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtNomeProf.Location = new System.Drawing.Point(130, 152);
            this.txtNomeProf.Name = "txtNomeProf";
            this.txtNomeProf.Size = new System.Drawing.Size(100, 21);
            this.txtNomeProf.TabIndex = 1;
            this.txtNomeProf.Text = "Nome:";
            this.txtNomeProf.Click += new System.EventHandler(this.txtNomeProf_Click);
            this.txtNomeProf.TextChanged += new System.EventHandler(this.txtNomeProf_TextChanged);
            // 
            // btnCriarSala
            // 
            this.btnCriarSala.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnCriarSala.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCriarSala.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCriarSala.ForeColor = System.Drawing.Color.White;
            this.btnCriarSala.Location = new System.Drawing.Point(130, 272);
            this.btnCriarSala.Name = "btnCriarSala";
            this.btnCriarSala.Size = new System.Drawing.Size(100, 23);
            this.btnCriarSala.TabIndex = 5;
            this.btnCriarSala.Text = "Criar sala";
            this.btnCriarSala.UseVisualStyleBackColor = false;
            this.btnCriarSala.Click += new System.EventHandler(this.btnCriarSala_Click);
            // 
            // txtSenhaProf
            // 
            this.txtSenhaProf.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenhaProf.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtSenhaProf.Location = new System.Drawing.Point(130, 181);
            this.txtSenhaProf.Name = "txtSenhaProf";
            this.txtSenhaProf.Size = new System.Drawing.Size(100, 21);
            this.txtSenhaProf.TabIndex = 2;
            this.txtSenhaProf.Text = "Senha:";
            this.txtSenhaProf.Click += new System.EventHandler(this.txtSenhaProf_Click);
            this.txtSenhaProf.TextChanged += new System.EventHandler(this.txtSenhaProf_TextChanged);
            // 
            // linkCadastro
            // 
            this.linkCadastro.AutoSize = true;
            this.linkCadastro.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkCadastro.Location = new System.Drawing.Point(129, 360);
            this.linkCadastro.Name = "linkCadastro";
            this.linkCadastro.Size = new System.Drawing.Size(117, 16);
            this.linkCadastro.TabIndex = 6;
            this.linkCadastro.TabStop = true;
            this.linkCadastro.Text = "Não tenho cadastro";
            this.linkCadastro.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkCadastro_LinkClicked);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel1.Location = new System.Drawing.Point(0, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(371, 43);
            this.panel1.TabIndex = 0;
            // 
            // loginProf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.linkCadastro);
            this.Controls.Add(this.txtSenhaProf);
            this.Controls.Add(this.btnCriarSala);
            this.Controls.Add(this.linkAluno);
            this.Controls.Add(this.PROFESSOR);
            this.Controls.Add(this.btnEntrarProf);
            this.Controls.Add(this.txtSalaProf);
            this.Controls.Add(this.txtNomeProf);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "loginProf";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "loginProf";
            this.Load += new System.EventHandler(this.loginProf_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkAluno;
        private System.Windows.Forms.Label PROFESSOR;
        private System.Windows.Forms.Button btnEntrarProf;
        private System.Windows.Forms.TextBox txtSalaProf;
        private System.Windows.Forms.TextBox txtNomeProf;
        private System.Windows.Forms.Button btnCriarSala;
        private System.Windows.Forms.TextBox txtSenhaProf;
        private System.Windows.Forms.LinkLabel linkCadastro;
        private System.Windows.Forms.Panel panel1;
    }
}