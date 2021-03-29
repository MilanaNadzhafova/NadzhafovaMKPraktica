
namespace NadzhafovaMKPraktica
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.picBtnCatalog = new System.Windows.Forms.PictureBox();
            this.picClose = new System.Windows.Forms.PictureBox();
            this.picBasket = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBtnCatalog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBasket)).BeginInit();
            this.SuspendLayout();
            // 
            // picBtnCatalog
            // 
            this.picBtnCatalog.BackColor = System.Drawing.Color.Transparent;
            this.picBtnCatalog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBtnCatalog.Location = new System.Drawing.Point(165, 216);
            this.picBtnCatalog.Name = "picBtnCatalog";
            this.picBtnCatalog.Size = new System.Drawing.Size(213, 50);
            this.picBtnCatalog.TabIndex = 0;
            this.picBtnCatalog.TabStop = false;
            this.picBtnCatalog.Click += new System.EventHandler(this.picBtnCatalog_Click);
            // 
            // picClose
            // 
            this.picClose.BackColor = System.Drawing.Color.Transparent;
            this.picClose.BackgroundImage = global::NadzhafovaMKPraktica.Properties.Resources.ddd;
            this.picClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picClose.Location = new System.Drawing.Point(499, 12);
            this.picClose.Name = "picClose";
            this.picClose.Size = new System.Drawing.Size(39, 35);
            this.picClose.TabIndex = 1;
            this.picClose.TabStop = false;
            this.picClose.Click += new System.EventHandler(this.picClose_Click);
            // 
            // picBasket
            // 
            this.picBasket.BackColor = System.Drawing.Color.Transparent;
            this.picBasket.BackgroundImage = global::NadzhafovaMKPraktica.Properties.Resources.аа;
            this.picBasket.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picBasket.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBasket.Location = new System.Drawing.Point(437, 6);
            this.picBasket.Name = "picBasket";
            this.picBasket.Size = new System.Drawing.Size(50, 50);
            this.picBasket.TabIndex = 2;
            this.picBasket.TabStop = false;
            this.picBasket.Click += new System.EventHandler(this.picBasket_Click_1);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::NadzhafovaMKPraktica.Properties.Resources.homecat;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(550, 762);
            this.Controls.Add(this.picBasket);
            this.Controls.Add(this.picClose);
            this.Controls.Add(this.picBtnCatalog);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            ((System.ComponentModel.ISupportInitialize)(this.picBtnCatalog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBasket)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picBtnCatalog;
        private System.Windows.Forms.PictureBox picClose;
        private System.Windows.Forms.PictureBox picBasket;
    }
}