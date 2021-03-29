
namespace NadzhafovaMKPraktica
{
    partial class Autorization
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Autorization));
            this.lbLink = new System.Windows.Forms.LinkLabel();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.btnEntrance = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.picClose = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            this.SuspendLayout();
            // 
            // lbLink
            // 
            this.lbLink.AutoSize = true;
            this.lbLink.BackColor = System.Drawing.Color.Transparent;
            this.lbLink.Font = new System.Drawing.Font("Georgia", 12F);
            this.lbLink.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.lbLink.Location = new System.Drawing.Point(574, 359);
            this.lbLink.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbLink.Name = "lbLink";
            this.lbLink.Size = new System.Drawing.Size(155, 18);
            this.lbLink.TabIndex = 17;
            this.lbLink.TabStop = true;
            this.lbLink.Text = "Зарегистрируйтесь!";
            this.lbLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbLink_LinkClicked);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(184)))), ((int)(((byte)(189)))));
            this.txtPassword.Font = new System.Drawing.Font("Georgia", 16F);
            this.txtPassword.ForeColor = System.Drawing.Color.DimGray;
            this.txtPassword.Location = new System.Drawing.Point(421, 218);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtPassword.MinimumSize = new System.Drawing.Size(4, 32);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(303, 32);
            this.txtPassword.TabIndex = 15;
            this.txtPassword.Text = "Пароль";
            this.txtPassword.Click += new System.EventHandler(this.txtPassword_Click);
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // txtLogin
            // 
            this.txtLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(184)))), ((int)(((byte)(189)))));
            this.txtLogin.Font = new System.Drawing.Font("Georgia", 16F);
            this.txtLogin.ForeColor = System.Drawing.Color.DimGray;
            this.txtLogin.Location = new System.Drawing.Point(334, 126);
            this.txtLogin.Margin = new System.Windows.Forms.Padding(2);
            this.txtLogin.Multiline = true;
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(306, 32);
            this.txtLogin.TabIndex = 14;
            this.txtLogin.Text = "Логин";
            this.txtLogin.Click += new System.EventHandler(this.txtLogin_Click);
            // 
            // btnEntrance
            // 
            this.btnEntrance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(151)))), ((int)(((byte)(163)))));
            this.btnEntrance.Font = new System.Drawing.Font("Georgia", 16.2F);
            this.btnEntrance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnEntrance.Location = new System.Drawing.Point(463, 288);
            this.btnEntrance.Name = "btnEntrance";
            this.btnEntrance.Size = new System.Drawing.Size(214, 40);
            this.btnEntrance.TabIndex = 16;
            this.btnEntrance.Text = "Войти";
            this.btnEntrance.UseVisualStyleBackColor = false;
            this.btnEntrance.Click += new System.EventHandler(this.btnEntrance_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // picClose
            // 
            this.picClose.BackColor = System.Drawing.Color.Transparent;
            this.picClose.BackgroundImage = global::NadzhafovaMKPraktica.Properties.Resources.ddd;
            this.picClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picClose.Location = new System.Drawing.Point(685, 12);
            this.picClose.Name = "picClose";
            this.picClose.Size = new System.Drawing.Size(39, 35);
            this.picClose.TabIndex = 88;
            this.picClose.TabStop = false;
            this.picClose.Click += new System.EventHandler(this.picClose_Click_1);
            // 
            // Autorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(218)))), ((int)(((byte)(142)))));
            this.BackgroundImage = global::NadzhafovaMKPraktica.Properties.Resources.Welcom3;
            this.ClientSize = new System.Drawing.Size(740, 425);
            this.ControlBox = false;
            this.Controls.Add(this.picClose);
            this.Controls.Add(this.btnEntrance);
            this.Controls.Add(this.lbLink);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Autorization";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Autorization";
            this.Load += new System.EventHandler(this.Autorization_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.LinkLabel lbLink;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Button btnEntrance;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.PictureBox picClose;
    }
}

