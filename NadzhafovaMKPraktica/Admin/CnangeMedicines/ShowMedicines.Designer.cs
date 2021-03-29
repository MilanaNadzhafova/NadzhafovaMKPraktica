
namespace NadzhafovaMKPraktica
{
    partial class ShowMedicines
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowMedicines));
            this.picClose = new System.Windows.Forms.PictureBox();
            this.lbPrice = new System.Windows.Forms.Label();
            this.lbAmount = new System.Windows.Forms.Label();
            this.lbCategories = new System.Windows.Forms.Label();
            this.lbDescription = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lb = new System.Windows.Forms.Label();
            this.checkPresence = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            this.SuspendLayout();
            // 
            // picClose
            // 
            this.picClose.BackColor = System.Drawing.Color.Transparent;
            this.picClose.BackgroundImage = global::NadzhafovaMKPraktica.Properties.Resources.close;
            this.picClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picClose.Location = new System.Drawing.Point(620, 4);
            this.picClose.Margin = new System.Windows.Forms.Padding(2);
            this.picClose.Name = "picClose";
            this.picClose.Size = new System.Drawing.Size(55, 46);
            this.picClose.TabIndex = 73;
            this.picClose.TabStop = false;
            this.picClose.Click += new System.EventHandler(this.picClose_Click);
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Font = new System.Drawing.Font("Georgia", 16F);
            this.lbPrice.Location = new System.Drawing.Point(90, 469);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(72, 27);
            this.lbPrice.TabIndex = 72;
            this.lbPrice.Text = "Цена:";
            // 
            // lbAmount
            // 
            this.lbAmount.AutoSize = true;
            this.lbAmount.Font = new System.Drawing.Font("Georgia", 16F);
            this.lbAmount.Location = new System.Drawing.Point(23, 408);
            this.lbAmount.Name = "lbAmount";
            this.lbAmount.Size = new System.Drawing.Size(139, 27);
            this.lbAmount.TabIndex = 71;
            this.lbAmount.Text = "Количество:";
            // 
            // lbCategories
            // 
            this.lbCategories.AutoSize = true;
            this.lbCategories.Font = new System.Drawing.Font("Georgia", 16F);
            this.lbCategories.Location = new System.Drawing.Point(36, 353);
            this.lbCategories.Name = "lbCategories";
            this.lbCategories.Size = new System.Drawing.Size(126, 27);
            this.lbCategories.TabIndex = 69;
            this.lbCategories.Text = "Категория:";
            // 
            // lbDescription
            // 
            this.lbDescription.AutoSize = true;
            this.lbDescription.Font = new System.Drawing.Font("Georgia", 16F);
            this.lbDescription.Location = new System.Drawing.Point(254, 143);
            this.lbDescription.Name = "lbDescription";
            this.lbDescription.Size = new System.Drawing.Size(119, 27);
            this.lbDescription.TabIndex = 68;
            this.lbDescription.Text = "Описание:";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Georgia", 16F);
            this.lbName.Location = new System.Drawing.Point(228, 65);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(172, 27);
            this.lbName.TabIndex = 67;
            this.lbName.Text = "Наименование:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 16F);
            this.label4.Location = new System.Drawing.Point(585, 412);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 27);
            this.label4.TabIndex = 66;
            this.label4.Text = "шт.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 16F);
            this.label3.Location = new System.Drawing.Point(585, 472);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 27);
            this.label3.TabIndex = 65;
            this.label3.Text = "руб.";
            // 
            // txtCategory
            // 
            this.txtCategory.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtCategory.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtCategory.ForeColor = System.Drawing.Color.DimGray;
            this.txtCategory.Location = new System.Drawing.Point(181, 350);
            this.txtCategory.Multiline = true;
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.ReadOnly = true;
            this.txtCategory.Size = new System.Drawing.Size(398, 35);
            this.txtCategory.TabIndex = 63;
            this.txtCategory.Text = "Категория";
            // 
            // txtAmount
            // 
            this.txtAmount.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtAmount.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtAmount.ForeColor = System.Drawing.Color.DimGray;
            this.txtAmount.Location = new System.Drawing.Point(181, 404);
            this.txtAmount.Multiline = true;
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.ReadOnly = true;
            this.txtAmount.Size = new System.Drawing.Size(398, 35);
            this.txtAmount.TabIndex = 62;
            this.txtAmount.Text = "Количество";
            // 
            // txtPrice
            // 
            this.txtPrice.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtPrice.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtPrice.ForeColor = System.Drawing.Color.DimGray;
            this.txtPrice.Location = new System.Drawing.Point(181, 464);
            this.txtPrice.Multiline = true;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.Size = new System.Drawing.Size(398, 35);
            this.txtPrice.TabIndex = 61;
            this.txtPrice.Text = "Цена";
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtDescription.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtDescription.ForeColor = System.Drawing.Color.DimGray;
            this.txtDescription.Location = new System.Drawing.Point(48, 173);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ReadOnly = true;
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescription.Size = new System.Drawing.Size(531, 152);
            this.txtDescription.TabIndex = 60;
            this.txtDescription.Text = "Описание";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtName.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtName.ForeColor = System.Drawing.Color.DimGray;
            this.txtName.Location = new System.Drawing.Point(41, 98);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(538, 35);
            this.txtName.TabIndex = 59;
            this.txtName.Text = "Наименование";
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb.Location = new System.Drawing.Point(12, 9);
            this.lb.MinimumSize = new System.Drawing.Size(600, 40);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(600, 40);
            this.lb.TabIndex = 58;
            this.lb.Text = "Просмотр товара";
            this.lb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkPresence
            // 
            this.checkPresence.AutoSize = true;
            this.checkPresence.Enabled = false;
            this.checkPresence.Font = new System.Drawing.Font("Georgia", 16F);
            this.checkPresence.Location = new System.Drawing.Point(259, 521);
            this.checkPresence.Name = "checkPresence";
            this.checkPresence.Size = new System.Drawing.Size(123, 31);
            this.checkPresence.TabIndex = 74;
            this.checkPresence.Text = "Наличие";
            this.checkPresence.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkPresence.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.checkPresence.UseVisualStyleBackColor = true;
            // 
            // ShowMedicines
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(232)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(686, 558);
            this.Controls.Add(this.checkPresence);
            this.Controls.Add(this.picClose);
            this.Controls.Add(this.lbPrice);
            this.Controls.Add(this.lbAmount);
            this.Controls.Add(this.lbCategories);
            this.Controls.Add(this.lbDescription);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCategory);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ShowMedicines";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ShowMedicines";
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picClose;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.Label lbAmount;
        private System.Windows.Forms.Label lbCategories;
        private System.Windows.Forms.Label lbDescription;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lb;
        private System.Windows.Forms.CheckBox checkPresence;
    }
}