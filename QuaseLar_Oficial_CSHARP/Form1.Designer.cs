namespace QuaseLar_Oficial_CSHARP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.emaiAcesso = new System.Windows.Forms.Label();
            this.senhaAcesso = new System.Windows.Forms.Label();
            this.txtEmailAcesso = new System.Windows.Forms.TextBox();
            this.txtSenhaAcesso = new System.Windows.Forms.TextBox();
            this.acessoFechar = new System.Windows.Forms.Button();
            this.acessoEntrar = new System.Windows.Forms.Button();
            this.msgErroAcesso = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(129, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(314, 84);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FloralWhite;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.msgErroAcesso);
            this.groupBox1.Controls.Add(this.acessoEntrar);
            this.groupBox1.Controls.Add(this.acessoFechar);
            this.groupBox1.Controls.Add(this.txtSenhaAcesso);
            this.groupBox1.Controls.Add(this.txtEmailAcesso);
            this.groupBox1.Controls.Add(this.senhaAcesso);
            this.groupBox1.Controls.Add(this.emaiAcesso);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 120);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(553, 251);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "LOGIN DE ACESSO";
            // 
            // emaiAcesso
            // 
            this.emaiAcesso.AutoSize = true;
            this.emaiAcesso.Location = new System.Drawing.Point(78, 60);
            this.emaiAcesso.Name = "emaiAcesso";
            this.emaiAcesso.Size = new System.Drawing.Size(80, 25);
            this.emaiAcesso.TabIndex = 0;
            this.emaiAcesso.Text = "E-mail:";
            // 
            // senhaAcesso
            // 
            this.senhaAcesso.AutoSize = true;
            this.senhaAcesso.Location = new System.Drawing.Point(76, 106);
            this.senhaAcesso.Name = "senhaAcesso";
            this.senhaAcesso.Size = new System.Drawing.Size(82, 25);
            this.senhaAcesso.TabIndex = 1;
            this.senhaAcesso.Text = "Senha:";
            // 
            // txtEmailAcesso
            // 
            this.txtEmailAcesso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmailAcesso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailAcesso.Location = new System.Drawing.Point(164, 58);
            this.txtEmailAcesso.Name = "txtEmailAcesso";
            this.txtEmailAcesso.Size = new System.Drawing.Size(301, 30);
            this.txtEmailAcesso.TabIndex = 2;
            this.txtEmailAcesso.TextChanged += new System.EventHandler(this.txtEmailAcesso_TextChanged);
            // 
            // txtSenhaAcesso
            // 
            this.txtSenhaAcesso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSenhaAcesso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenhaAcesso.Location = new System.Drawing.Point(164, 104);
            this.txtSenhaAcesso.Name = "txtSenhaAcesso";
            this.txtSenhaAcesso.Size = new System.Drawing.Size(301, 30);
            this.txtSenhaAcesso.TabIndex = 3;
            this.txtSenhaAcesso.UseSystemPasswordChar = true;
            this.txtSenhaAcesso.TextChanged += new System.EventHandler(this.txtSenhaAcesso_TextChanged);
            // 
            // acessoFechar
            // 
            this.acessoFechar.BackColor = System.Drawing.Color.MistyRose;
            this.acessoFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acessoFechar.Location = new System.Drawing.Point(117, 177);
            this.acessoFechar.Name = "acessoFechar";
            this.acessoFechar.Size = new System.Drawing.Size(155, 50);
            this.acessoFechar.TabIndex = 4;
            this.acessoFechar.Text = "Cancelar";
            this.acessoFechar.UseVisualStyleBackColor = false;
            this.acessoFechar.Click += new System.EventHandler(this.acessoFechar_Click);
            // 
            // acessoEntrar
            // 
            this.acessoEntrar.BackColor = System.Drawing.Color.LightSkyBlue;
            this.acessoEntrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acessoEntrar.Location = new System.Drawing.Point(289, 177);
            this.acessoEntrar.Name = "acessoEntrar";
            this.acessoEntrar.Size = new System.Drawing.Size(155, 50);
            this.acessoEntrar.TabIndex = 5;
            this.acessoEntrar.Text = "Entrar";
            this.acessoEntrar.UseVisualStyleBackColor = false;
            this.acessoEntrar.Click += new System.EventHandler(this.acessoEntrar_Click);
            // 
            // msgErroAcesso
            // 
            this.msgErroAcesso.AutoSize = true;
            this.msgErroAcesso.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msgErroAcesso.ForeColor = System.Drawing.Color.Red;
            this.msgErroAcesso.Location = new System.Drawing.Point(176, 137);
            this.msgErroAcesso.Name = "msgErroAcesso";
            this.msgErroAcesso.Size = new System.Drawing.Size(0, 16);
            this.msgErroAcesso.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 376);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QuaseLar - Gerenciador";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label senhaAcesso;
        private System.Windows.Forms.Label emaiAcesso;
        private System.Windows.Forms.Button acessoEntrar;
        private System.Windows.Forms.Button acessoFechar;
        private System.Windows.Forms.TextBox txtSenhaAcesso;
        private System.Windows.Forms.TextBox txtEmailAcesso;
        private System.Windows.Forms.Label msgErroAcesso;
    }
}

