namespace QuaseLar_Oficial_CSHARP
{
    partial class Painel_de_botoes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Painel_de_botoes));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.animaisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.animaisPerdidosDesaparecidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.usuariosCadastradosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.animaisCadastradosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.animaisToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSairPainel = new System.Windows.Forms.ToolStripButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Lavender;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.btnSairPainel});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(981, 67);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuariosToolStripMenuItem,
            this.animaisToolStripMenuItem,
            this.animaisPerdidosDesaparecidosToolStripMenuItem});
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(128, 64);
            this.toolStripButton1.Text = "Cadastros";
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.CheckOnClick = true;
            this.usuariosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("usuariosToolStripMenuItem.Image")));
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.U)));
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(420, 46);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            this.usuariosToolStripMenuItem.Click += new System.EventHandler(this.usuariosToolStripMenuItem_Click);
            // 
            // animaisToolStripMenuItem
            // 
            this.animaisToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("animaisToolStripMenuItem.Image")));
            this.animaisToolStripMenuItem.Name = "animaisToolStripMenuItem";
            this.animaisToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.A)));
            this.animaisToolStripMenuItem.Size = new System.Drawing.Size(400, 26);
            this.animaisToolStripMenuItem.Text = "Animais";
            this.animaisToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.animaisToolStripMenuItem.Click += new System.EventHandler(this.animaisToolStripMenuItem_Click);
            // 
            // animaisPerdidosDesaparecidosToolStripMenuItem
            // 
            this.animaisPerdidosDesaparecidosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("animaisPerdidosDesaparecidosToolStripMenuItem.Image")));
            this.animaisPerdidosDesaparecidosToolStripMenuItem.Name = "animaisPerdidosDesaparecidosToolStripMenuItem";
            this.animaisPerdidosDesaparecidosToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.P)));
            this.animaisPerdidosDesaparecidosToolStripMenuItem.Size = new System.Drawing.Size(400, 26);
            this.animaisPerdidosDesaparecidosToolStripMenuItem.Text = "Animais Perdidos/Desaparecidos";
            this.animaisPerdidosDesaparecidosToolStripMenuItem.Click += new System.EventHandler(this.animaisPerdidosDesaparecidosToolStripMenuItem_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuariosCadastradosToolStripMenuItem,
            this.animaisCadastradosToolStripMenuItem,
            this.animaisToolStripMenuItem1});
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(126, 64);
            this.toolStripButton2.Text = "Consultas";
            // 
            // usuariosCadastradosToolStripMenuItem
            // 
            this.usuariosCadastradosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("usuariosCadastradosToolStripMenuItem.Image")));
            this.usuariosCadastradosToolStripMenuItem.Name = "usuariosCadastradosToolStripMenuItem";
            this.usuariosCadastradosToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.U)));
            this.usuariosCadastradosToolStripMenuItem.Size = new System.Drawing.Size(539, 26);
            this.usuariosCadastradosToolStripMenuItem.Text = "Usúarios Cadastrados";
            this.usuariosCadastradosToolStripMenuItem.Click += new System.EventHandler(this.usuariosCadastradosToolStripMenuItem_Click);
            // 
            // animaisCadastradosToolStripMenuItem
            // 
            this.animaisCadastradosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("animaisCadastradosToolStripMenuItem.Image")));
            this.animaisCadastradosToolStripMenuItem.Name = "animaisCadastradosToolStripMenuItem";
            this.animaisCadastradosToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.A)));
            this.animaisCadastradosToolStripMenuItem.Size = new System.Drawing.Size(539, 26);
            this.animaisCadastradosToolStripMenuItem.Text = "Animais Cadastrados";
            this.animaisCadastradosToolStripMenuItem.Click += new System.EventHandler(this.animaisCadastradosToolStripMenuItem_Click);
            // 
            // animaisToolStripMenuItem1
            // 
            this.animaisToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("animaisToolStripMenuItem1.Image")));
            this.animaisToolStripMenuItem1.Name = "animaisToolStripMenuItem1";
            this.animaisToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.P)));
            this.animaisToolStripMenuItem1.Size = new System.Drawing.Size(539, 26);
            this.animaisToolStripMenuItem1.Text = "Animais Animais Perdidos/Desaparecidos Cadastrados";
            this.animaisToolStripMenuItem1.Click += new System.EventHandler(this.animaisToolStripMenuItem1_Click);
            // 
            // btnSairPainel
            // 
            this.btnSairPainel.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnSairPainel.Image = ((System.Drawing.Image)(resources.GetObject("btnSairPainel.Image")));
            this.btnSairPainel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSairPainel.Name = "btnSairPainel";
            this.btnSairPainel.Size = new System.Drawing.Size(44, 64);
            this.btnSairPainel.Text = "Sair";
            this.btnSairPainel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSairPainel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSairPainel.Click += new System.EventHandler(this.btnSairPainel_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 79);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(957, 562);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage1.BackgroundImage")));
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(949, 533);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Apresentação";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(949, 533);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Regras";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(949, 533);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Quem Somos?";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label1.Location = new System.Drawing.Point(92, 53);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(755, 457);
            this.label1.TabIndex = 0;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // Painel_de_botoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 654);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Painel_de_botoes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QuaseLar - MENU";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnSairPainel;
        private System.Windows.Forms.ToolStripDropDownButton toolStripButton1;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem animaisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem animaisPerdidosDesaparecidosToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton toolStripButton2;
        private System.Windows.Forms.ToolStripMenuItem usuariosCadastradosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem animaisCadastradosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem animaisToolStripMenuItem1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label1;
    }
}