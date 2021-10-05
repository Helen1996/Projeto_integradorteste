namespace ProjetoSiscola
{
    partial class frm_cadastro_funcionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_cadastro_funcionario));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.cbb_cargo = new System.Windows.Forms.ComboBox();
            this.lbl_cargo = new System.Windows.Forms.Label();
            this.txt_login = new System.Windows.Forms.TextBox();
            this.lbl_senha = new System.Windows.Forms.Label();
            this.lbl_login = new System.Windows.Forms.Label();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.txt_senha = new System.Windows.Forms.TextBox();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.pcb_senha = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_senha)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pcb_senha);
            this.groupBox1.Controls.Add(this.txt_senha);
            this.groupBox1.Controls.Add(this.btn_buscar);
            this.groupBox1.Controls.Add(this.cbb_cargo);
            this.groupBox1.Controls.Add(this.lbl_cargo);
            this.groupBox1.Controls.Add(this.txt_login);
            this.groupBox1.Controls.Add(this.lbl_senha);
            this.groupBox1.Controls.Add(this.lbl_login);
            this.groupBox1.Controls.Add(this.lbl_nome);
            this.groupBox1.Controls.Add(this.btn_limpar);
            this.groupBox1.Controls.Add(this.btn_excluir);
            this.groupBox1.Controls.Add(this.txt_nome);
            this.groupBox1.Controls.Add(this.btn_salvar);
            this.groupBox1.Location = new System.Drawing.Point(178, 81);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(450, 266);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadastro de Funcionarios";
            // 
            // btn_buscar
            // 
            this.btn_buscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_buscar.BackgroundImage")));
            this.btn_buscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_buscar.Location = new System.Drawing.Point(293, 161);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(48, 49);
            this.btn_buscar.TabIndex = 7;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_buscar.UseVisualStyleBackColor = true;
            // 
            // cbb_cargo
            // 
            this.cbb_cargo.FormattingEnabled = true;
            this.cbb_cargo.Items.AddRange(new object[] {
            "OPERADOR DE IMPILHADEIRA",
            "ADM",
            "VENDAS",
            "RH",
            "LIMPEZA",
            "AUXILIAR DE ADM",
            "TÉC INFORMATICA"});
            this.cbb_cargo.Location = new System.Drawing.Point(101, 141);
            this.cbb_cargo.Name = "cbb_cargo";
            this.cbb_cargo.Size = new System.Drawing.Size(121, 21);
            this.cbb_cargo.TabIndex = 3;
            // 
            // lbl_cargo
            // 
            this.lbl_cargo.AutoSize = true;
            this.lbl_cargo.Location = new System.Drawing.Point(60, 144);
            this.lbl_cargo.Name = "lbl_cargo";
            this.lbl_cargo.Size = new System.Drawing.Size(35, 13);
            this.lbl_cargo.TabIndex = 9;
            this.lbl_cargo.Text = "Cargo";
            // 
            // txt_login
            // 
            this.txt_login.Location = new System.Drawing.Point(101, 89);
            this.txt_login.Name = "txt_login";
            this.txt_login.Size = new System.Drawing.Size(121, 20);
            this.txt_login.TabIndex = 1;
            // 
            // lbl_senha
            // 
            this.lbl_senha.AutoSize = true;
            this.lbl_senha.Location = new System.Drawing.Point(60, 118);
            this.lbl_senha.Name = "lbl_senha";
            this.lbl_senha.Size = new System.Drawing.Size(38, 13);
            this.lbl_senha.TabIndex = 8;
            this.lbl_senha.Text = "Senha";
            // 
            // lbl_login
            // 
            this.lbl_login.AutoSize = true;
            this.lbl_login.Location = new System.Drawing.Point(60, 92);
            this.lbl_login.Name = "lbl_login";
            this.lbl_login.Size = new System.Drawing.Size(33, 13);
            this.lbl_login.TabIndex = 7;
            this.lbl_login.Text = "Login";
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Location = new System.Drawing.Point(60, 65);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(35, 13);
            this.lbl_nome.TabIndex = 6;
            this.lbl_nome.Text = "Nome";
            // 
            // btn_limpar
            // 
            this.btn_limpar.Location = new System.Drawing.Point(212, 173);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(75, 23);
            this.btn_limpar.TabIndex = 6;
            this.btn_limpar.Text = "Limpar";
            this.btn_limpar.UseVisualStyleBackColor = true;
            // 
            // btn_excluir
            // 
            this.btn_excluir.Location = new System.Drawing.Point(131, 173);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(75, 23);
            this.btn_excluir.TabIndex = 5;
            this.btn_excluir.Text = "Excluir";
            this.btn_excluir.UseVisualStyleBackColor = true;
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(101, 62);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(121, 20);
            this.txt_nome.TabIndex = 0;
            // 
            // txt_senha
            // 
            this.txt_senha.Location = new System.Drawing.Point(101, 115);
            this.txt_senha.Name = "txt_senha";
            this.txt_senha.PasswordChar = '*';
            this.txt_senha.Size = new System.Drawing.Size(121, 20);
            this.txt_senha.TabIndex = 2;
            // 
            // btn_salvar
            // 
            this.btn_salvar.Location = new System.Drawing.Point(50, 173);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(75, 23);
            this.btn_salvar.TabIndex = 4;
            this.btn_salvar.Text = "Salvar";
            this.btn_salvar.UseVisualStyleBackColor = true;
            // 
            // pcb_senha
            // 
            this.pcb_senha.Image = ((System.Drawing.Image)(resources.GetObject("pcb_senha.Image")));
            this.pcb_senha.Location = new System.Drawing.Point(228, 115);
            this.pcb_senha.Name = "pcb_senha";
            this.pcb_senha.Size = new System.Drawing.Size(23, 20);
            this.pcb_senha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcb_senha.TabIndex = 10;
            this.pcb_senha.TabStop = false;
            this.pcb_senha.Click += new System.EventHandler(this.pcb_senha_Click);
            this.pcb_senha.MouseLeave += new System.EventHandler(this.pcb_senha_MouseLeave);
            this.pcb_senha.MouseHover += new System.EventHandler(this.pcb_senha_MouseHover);
            // 
            // frm_cadastro_funcionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_cadastro_funcionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Funcionario";
            this.Load += new System.EventHandler(this.frm_cadastro_funcionario_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_senha)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.ComboBox cbb_cargo;
        private System.Windows.Forms.Label lbl_cargo;
        private System.Windows.Forms.TextBox txt_login;
        private System.Windows.Forms.Label lbl_senha;
        private System.Windows.Forms.Label lbl_login;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.Button btn_limpar;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.TextBox txt_senha;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.PictureBox pcb_senha;
    }
}