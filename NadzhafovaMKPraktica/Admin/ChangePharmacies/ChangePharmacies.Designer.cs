
namespace NadzhafovaMKPraktica
{
    partial class ChangePharmacies
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePharmacies));
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.picClose = new System.Windows.Forms.PictureBox();
            this.lbList = new System.Windows.Forms.Label();
            this.txtTimeWork = new System.Windows.Forms.TextBox();
            this.txtAddres = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnChange = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            this.SuspendLayout();
            // 
            // picLogo
            // 
            this.picLogo.BackColor = System.Drawing.Color.Transparent;
            this.picLogo.BackgroundImage = global::NadzhafovaMKPraktica.Properties.Resources.lg51;
            this.picLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picLogo.InitialImage = ((System.Drawing.Image)(resources.GetObject("picLogo.InitialImage")));
            this.picLogo.Location = new System.Drawing.Point(21, 14);
            this.picLogo.Margin = new System.Windows.Forms.Padding(2);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(74, 46);
            this.picLogo.TabIndex = 69;
            this.picLogo.TabStop = false;
            // 
            // picClose
            // 
            this.picClose.BackColor = System.Drawing.Color.Transparent;
            this.picClose.BackgroundImage = global::NadzhafovaMKPraktica.Properties.Resources.close;
            this.picClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picClose.Location = new System.Drawing.Point(406, 14);
            this.picClose.Margin = new System.Windows.Forms.Padding(2);
            this.picClose.Name = "picClose";
            this.picClose.Size = new System.Drawing.Size(55, 46);
            this.picClose.TabIndex = 68;
            this.picClose.TabStop = false;
            this.picClose.Click += new System.EventHandler(this.picClose_Click);
            // 
            // lbList
            // 
            this.lbList.AutoSize = true;
            this.lbList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbList.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbList.Location = new System.Drawing.Point(12, 9);
            this.lbList.MinimumSize = new System.Drawing.Size(450, 55);
            this.lbList.Name = "lbList";
            this.lbList.Size = new System.Drawing.Size(450, 55);
            this.lbList.TabIndex = 67;
            this.lbList.Text = "Изменение аптеки";
            this.lbList.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTimeWork
            // 
            this.txtTimeWork.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtTimeWork.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtTimeWork.ForeColor = System.Drawing.Color.DimGray;
            this.txtTimeWork.Location = new System.Drawing.Point(12, 210);
            this.txtTimeWork.Multiline = true;
            this.txtTimeWork.Name = "txtTimeWork";
            this.txtTimeWork.Size = new System.Drawing.Size(449, 35);
            this.txtTimeWork.TabIndex = 72;
            this.txtTimeWork.Text = "Время работы";
            this.txtTimeWork.Click += new System.EventHandler(this.txtTimeWork_Click);
            // 
            // txtAddres
            // 
            this.txtAddres.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtAddres.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtAddres.ForeColor = System.Drawing.Color.DimGray;
            this.txtAddres.Location = new System.Drawing.Point(12, 152);
            this.txtAddres.Multiline = true;
            this.txtAddres.Name = "txtAddres";
            this.txtAddres.Size = new System.Drawing.Size(449, 35);
            this.txtAddres.TabIndex = 71;
            this.txtAddres.Text = "Адрес";
            this.txtAddres.Click += new System.EventHandler(this.txtAddres_Click);
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtName.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtName.ForeColor = System.Drawing.Color.DimGray;
            this.txtName.Location = new System.Drawing.Point(12, 97);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(449, 35);
            this.txtName.TabIndex = 70;
            this.txtName.Text = "Наименование";
            this.txtName.Click += new System.EventHandler(this.txtName_Click);
            // 
            // btnChange
            // 
            this.btnChange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(189)))), ((int)(((byte)(199)))));
            this.btnChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnChange.Location = new System.Drawing.Point(159, 277);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(148, 42);
            this.btnChange.TabIndex = 73;
            this.btnChange.Text = "Изменить";
            this.btnChange.UseVisualStyleBackColor = false;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // ChangePharmacies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(239)))), ((int)(((byte)(253)))));
            this.ClientSize = new System.Drawing.Size(481, 336);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.txtTimeWork);
            this.Controls.Add(this.txtAddres);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.picClose);
            this.Controls.Add(this.lbList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ChangePharmacies";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChangePharmacies";
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.PictureBox picClose;
        private System.Windows.Forms.Label lbList;
        private System.Windows.Forms.TextBox txtTimeWork;
        private System.Windows.Forms.TextBox txtAddres;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnChange;
    }
}