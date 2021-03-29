
namespace NadzhafovaMKPraktica
{
    partial class Catalog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Catalog));
            this.picClose = new System.Windows.Forms.PictureBox();
            this.picBtnDiabetes = new System.Windows.Forms.PictureBox();
            this.picBtnVision = new System.Windows.Forms.PictureBox();
            this.picBtnJoints = new System.Windows.Forms.PictureBox();
            this.picBtnHygiene = new System.Windows.Forms.PictureBox();
            this.picBtnBasket = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBtnDiabetes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBtnVision)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBtnJoints)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBtnHygiene)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBtnBasket)).BeginInit();
            this.SuspendLayout();
            // 
            // picClose
            // 
            this.picClose.BackColor = System.Drawing.Color.Transparent;
            this.picClose.BackgroundImage = global::NadzhafovaMKPraktica.Properties.Resources.ddd;
            this.picClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picClose.Location = new System.Drawing.Point(500, 12);
            this.picClose.Name = "picClose";
            this.picClose.Size = new System.Drawing.Size(39, 35);
            this.picClose.TabIndex = 2;
            this.picClose.TabStop = false;
            this.picClose.Click += new System.EventHandler(this.picClose_Click);
            // 
            // picBtnDiabetes
            // 
            this.picBtnDiabetes.BackColor = System.Drawing.Color.Transparent;
            this.picBtnDiabetes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBtnDiabetes.Location = new System.Drawing.Point(51, 376);
            this.picBtnDiabetes.Name = "picBtnDiabetes";
            this.picBtnDiabetes.Size = new System.Drawing.Size(449, 55);
            this.picBtnDiabetes.TabIndex = 3;
            this.picBtnDiabetes.TabStop = false;
            this.picBtnDiabetes.Click += new System.EventHandler(this.picBtnDiabetes_Click);
            // 
            // picBtnVision
            // 
            this.picBtnVision.BackColor = System.Drawing.Color.Transparent;
            this.picBtnVision.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBtnVision.Location = new System.Drawing.Point(51, 460);
            this.picBtnVision.Name = "picBtnVision";
            this.picBtnVision.Size = new System.Drawing.Size(449, 55);
            this.picBtnVision.TabIndex = 4;
            this.picBtnVision.TabStop = false;
            this.picBtnVision.Click += new System.EventHandler(this.picBtnVision_Click);
            // 
            // picBtnJoints
            // 
            this.picBtnJoints.BackColor = System.Drawing.Color.Transparent;
            this.picBtnJoints.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBtnJoints.Location = new System.Drawing.Point(51, 548);
            this.picBtnJoints.Name = "picBtnJoints";
            this.picBtnJoints.Size = new System.Drawing.Size(449, 55);
            this.picBtnJoints.TabIndex = 5;
            this.picBtnJoints.TabStop = false;
            this.picBtnJoints.Click += new System.EventHandler(this.picBtnJoints_Click);
            // 
            // picBtnHygiene
            // 
            this.picBtnHygiene.BackColor = System.Drawing.Color.Transparent;
            this.picBtnHygiene.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBtnHygiene.Location = new System.Drawing.Point(51, 636);
            this.picBtnHygiene.Name = "picBtnHygiene";
            this.picBtnHygiene.Size = new System.Drawing.Size(449, 55);
            this.picBtnHygiene.TabIndex = 6;
            this.picBtnHygiene.TabStop = false;
            this.picBtnHygiene.Click += new System.EventHandler(this.picBtnHygiene_Click);
            // 
            // picBtnBasket
            // 
            this.picBtnBasket.BackColor = System.Drawing.Color.Transparent;
            this.picBtnBasket.BackgroundImage = global::NadzhafovaMKPraktica.Properties.Resources.аа;
            this.picBtnBasket.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picBtnBasket.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBtnBasket.Location = new System.Drawing.Point(438, 3);
            this.picBtnBasket.Name = "picBtnBasket";
            this.picBtnBasket.Size = new System.Drawing.Size(50, 50);
            this.picBtnBasket.TabIndex = 7;
            this.picBtnBasket.TabStop = false;
            this.picBtnBasket.Click += new System.EventHandler(this.picBtnBasket_Click_1);
            // 
            // Catalog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(141)))), ((int)(((byte)(142)))));
            this.BackgroundImage = global::NadzhafovaMKPraktica.Properties.Resources.catalog2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(551, 735);
            this.Controls.Add(this.picBtnBasket);
            this.Controls.Add(this.picBtnHygiene);
            this.Controls.Add(this.picBtnJoints);
            this.Controls.Add(this.picBtnVision);
            this.Controls.Add(this.picBtnDiabetes);
            this.Controls.Add(this.picClose);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Catalog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Catalog";
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBtnDiabetes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBtnVision)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBtnJoints)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBtnHygiene)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBtnBasket)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picClose;
        private System.Windows.Forms.PictureBox picBtnDiabetes;
        private System.Windows.Forms.PictureBox picBtnVision;
        private System.Windows.Forms.PictureBox picBtnJoints;
        private System.Windows.Forms.PictureBox picBtnHygiene;
        private System.Windows.Forms.PictureBox picBtnBasket;
    }
}