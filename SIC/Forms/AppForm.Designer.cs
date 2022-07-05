namespace Forms
{
    partial class AppForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppForm));
            this.barraTitulo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btMinimizar = new System.Windows.Forms.PictureBox();
            this.btSair = new System.Windows.Forms.PictureBox();
            this.btMaximiar = new System.Windows.Forms.PictureBox();
            this.barraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btSair)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btMaximiar)).BeginInit();
            this.SuspendLayout();
            // 
            // barraTitulo
            // 
            this.barraTitulo.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.barraTitulo.Controls.Add(this.label1);
            this.barraTitulo.Controls.Add(this.pictureBox1);
            this.barraTitulo.Controls.Add(this.btMinimizar);
            this.barraTitulo.Controls.Add(this.btSair);
            this.barraTitulo.Controls.Add(this.btMaximiar);
            this.barraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.barraTitulo.Location = new System.Drawing.Point(0, 0);
            this.barraTitulo.Name = "barraTitulo";
            this.barraTitulo.Size = new System.Drawing.Size(1121, 46);
            this.barraTitulo.TabIndex = 1;
            this.barraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.barraTitulo_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(43, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "SIC - Sistema Interno de Correção";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // btMinimizar
            // 
            this.btMinimizar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btMinimizar.Image")));
            this.btMinimizar.Location = new System.Drawing.Point(1008, 8);
            this.btMinimizar.Name = "btMinimizar";
            this.btMinimizar.Size = new System.Drawing.Size(31, 30);
            this.btMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btMinimizar.TabIndex = 3;
            this.btMinimizar.TabStop = false;
            this.btMinimizar.Click += new System.EventHandler(this.btMinimizar_Click);
            // 
            // btSair
            // 
            this.btSair.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSair.Image = ((System.Drawing.Image)(resources.GetObject("btSair.Image")));
            this.btSair.Location = new System.Drawing.Point(1078, 7);
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
            this.btMaximiar.Location = new System.Drawing.Point(1041, 7);
            this.btMaximiar.Name = "btMaximiar";
            this.btMaximiar.Size = new System.Drawing.Size(31, 30);
            this.btMaximiar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btMaximiar.TabIndex = 3;
            this.btMaximiar.TabStop = false;
            this.btMaximiar.Click += new System.EventHandler(this.btMaximiar_Click);
            // 
            // AppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1121, 765);
            this.Controls.Add(this.barraTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.Name = "AppForm";
            this.Text = "Sistema Interno de Correção - SIC";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.barraTitulo.ResumeLayout(false);
            this.barraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btSair)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btMaximiar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel barraTitulo;
        private System.Windows.Forms.PictureBox btMinimizar;
        private System.Windows.Forms.PictureBox btSair;
        private System.Windows.Forms.PictureBox btMaximiar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}