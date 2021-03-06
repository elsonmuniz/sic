namespace Forms
{
    partial class DialogViewer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DialogViewer));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btFechar = new System.Windows.Forms.ToolStripButton();
            this.barraTitulo = new System.Windows.Forms.Panel();
            this.lbNomeJanela = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btMinimizar = new System.Windows.Forms.PictureBox();
            this.btSair = new System.Windows.Forms.PictureBox();
            this.btMaximiar = new System.Windows.Forms.PictureBox();
            this.toolStrip1.SuspendLayout();
            this.barraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btSair)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btMaximiar)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btFechar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 41);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1000, 35);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btFechar
            // 
            this.btFechar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btFechar.Image = ((System.Drawing.Image)(resources.GetObject("btFechar.Image")));
            this.btFechar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btFechar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btFechar.Name = "btFechar";
            this.btFechar.Size = new System.Drawing.Size(32, 32);
            this.btFechar.Text = "F4 - Fechar";
            this.btFechar.Click += new System.EventHandler(this.btFechar_Click);
            // 
            // barraTitulo
            // 
            this.barraTitulo.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.barraTitulo.Controls.Add(this.lbNomeJanela);
            this.barraTitulo.Controls.Add(this.pictureBox1);
            this.barraTitulo.Controls.Add(this.btMinimizar);
            this.barraTitulo.Controls.Add(this.btSair);
            this.barraTitulo.Controls.Add(this.btMaximiar);
            this.barraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.barraTitulo.Location = new System.Drawing.Point(0, 0);
            this.barraTitulo.Name = "barraTitulo";
            this.barraTitulo.Size = new System.Drawing.Size(1000, 41);
            this.barraTitulo.TabIndex = 4;
            this.barraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.barraTitulo_MouseDown);
            // 
            // lbNomeJanela
            // 
            this.lbNomeJanela.AutoSize = true;
            this.lbNomeJanela.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbNomeJanela.Location = new System.Drawing.Point(32, 13);
            this.lbNomeJanela.Name = "lbNomeJanela";
            this.lbNomeJanela.Size = new System.Drawing.Size(0, 16);
            this.lbNomeJanela.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // btMinimizar
            // 
            this.btMinimizar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btMinimizar.Image")));
            this.btMinimizar.Location = new System.Drawing.Point(887, 5);
            this.btMinimizar.Name = "btMinimizar";
            this.btMinimizar.Size = new System.Drawing.Size(31, 30);
            this.btMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btMinimizar.TabIndex = 3;
            this.btMinimizar.TabStop = false;
            // 
            // btSair
            // 
            this.btSair.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSair.Image = ((System.Drawing.Image)(resources.GetObject("btSair.Image")));
            this.btSair.Location = new System.Drawing.Point(957, 4);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(31, 30);
            this.btSair.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btSair.TabIndex = 3;
            this.btSair.TabStop = false;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // btMaximiar
            // 
            this.btMaximiar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btMaximiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btMaximiar.Image = ((System.Drawing.Image)(resources.GetObject("btMaximiar.Image")));
            this.btMaximiar.Location = new System.Drawing.Point(920, 4);
            this.btMaximiar.Name = "btMaximiar";
            this.btMaximiar.Size = new System.Drawing.Size(31, 30);
            this.btMaximiar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btMaximiar.TabIndex = 3;
            this.btMaximiar.TabStop = false;
            // 
            // DialogViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 563);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.barraTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "DialogViewer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DialogViewer";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.barraTitulo.ResumeLayout(false);
            this.barraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btSair)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btMaximiar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btFechar;
        private System.Windows.Forms.Panel barraTitulo;
        private System.Windows.Forms.Label lbNomeJanela;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox btMinimizar;
        private System.Windows.Forms.PictureBox btSair;
        private System.Windows.Forms.PictureBox btMaximiar;
    }
}