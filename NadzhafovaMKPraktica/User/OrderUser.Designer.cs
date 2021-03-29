
namespace NadzhafovaMKPraktica
{
    partial class OrderUser
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableConsist = new System.Windows.Forms.DataGridView();
            this.pharmaciesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pharmPanaceyaDataSet = new NadzhafovaMKPraktica.PharmPanaceyaDataSet();
            this.pharmaciesTableAdapter = new NadzhafovaMKPraktica.PharmPanaceyaDataSetTableAdapters.PharmaciesTableAdapter();
            this.payMethodBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.payMethodTableAdapter = new NadzhafovaMKPraktica.PharmPanaceyaDataSetTableAdapters.PayMethodTableAdapter();
            this.btnAddOnOrders = new System.Windows.Forms.Button();
            this.comboAddress = new System.Windows.Forms.ComboBox();
            this.comboPay = new System.Windows.Forms.ComboBox();
            this.picClose = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.tableConsist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmaciesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmPanaceyaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.payMethodBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            this.SuspendLayout();
            // 
            // tableConsist
            // 
            this.tableConsist.AllowUserToAddRows = false;
            this.tableConsist.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Georgia", 8.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tableConsist.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tableConsist.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableConsist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tableConsist.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.tableConsist.BackgroundColor = System.Drawing.Color.White;
            this.tableConsist.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tableConsist.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tableConsist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.Format = "N0";
            dataGridViewCellStyle3.NullValue = null;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tableConsist.DefaultCellStyle = dataGridViewCellStyle3;
            this.tableConsist.Location = new System.Drawing.Point(479, 100);
            this.tableConsist.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableConsist.Name = "tableConsist";
            this.tableConsist.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tableConsist.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.tableConsist.RowHeadersVisible = false;
            this.tableConsist.RowHeadersWidth = 80;
            this.tableConsist.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Georgia", 8.25F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tableConsist.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.tableConsist.Size = new System.Drawing.Size(625, 290);
            this.tableConsist.TabIndex = 85;
            // 
            // pharmaciesBindingSource
            // 
            this.pharmaciesBindingSource.DataMember = "Pharmacies";
            this.pharmaciesBindingSource.DataSource = this.pharmPanaceyaDataSet;
            // 
            // pharmPanaceyaDataSet
            // 
            this.pharmPanaceyaDataSet.DataSetName = "PharmPanaceyaDataSet";
            this.pharmPanaceyaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pharmaciesTableAdapter
            // 
            this.pharmaciesTableAdapter.ClearBeforeFill = true;
            // 
            // payMethodBindingSource
            // 
            this.payMethodBindingSource.DataMember = "PayMethod";
            this.payMethodBindingSource.DataSource = this.pharmPanaceyaDataSet;
            // 
            // payMethodTableAdapter
            // 
            this.payMethodTableAdapter.ClearBeforeFill = true;
            // 
            // btnAddOnOrders
            // 
            this.btnAddOnOrders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(241)))), ((int)(((byte)(202)))));
            this.btnAddOnOrders.Font = new System.Drawing.Font("Georgia", 15F);
            this.btnAddOnOrders.ForeColor = System.Drawing.Color.Black;
            this.btnAddOnOrders.Location = new System.Drawing.Point(671, 532);
            this.btnAddOnOrders.Name = "btnAddOnOrders";
            this.btnAddOnOrders.Size = new System.Drawing.Size(284, 56);
            this.btnAddOnOrders.TabIndex = 88;
            this.btnAddOnOrders.Text = "Оформить заказ";
            this.btnAddOnOrders.UseVisualStyleBackColor = false;
            this.btnAddOnOrders.Click += new System.EventHandler(this.btnAddOnOrders_Click);
            // 
            // comboAddress
            // 
            this.comboAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(251)))), ((int)(((byte)(237)))));
            this.comboAddress.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboAddress.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboAddress.Font = new System.Drawing.Font("Georgia", 12F);
            this.comboAddress.FormattingEnabled = true;
            this.comboAddress.Location = new System.Drawing.Point(794, 407);
            this.comboAddress.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboAddress.Name = "comboAddress";
            this.comboAddress.Size = new System.Drawing.Size(310, 26);
            this.comboAddress.TabIndex = 89;
            this.comboAddress.SelectedIndexChanged += new System.EventHandler(this.comboAddress_SelectedIndexChanged);
            // 
            // comboPay
            // 
            this.comboPay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(251)))), ((int)(((byte)(237)))));
            this.comboPay.DataSource = this.payMethodBindingSource;
            this.comboPay.DisplayMember = "Method";
            this.comboPay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboPay.Font = new System.Drawing.Font("Georgia", 12F);
            this.comboPay.FormattingEnabled = true;
            this.comboPay.Location = new System.Drawing.Point(794, 467);
            this.comboPay.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboPay.Name = "comboPay";
            this.comboPay.Size = new System.Drawing.Size(310, 26);
            this.comboPay.TabIndex = 90;
            this.comboPay.TabStop = false;
            this.comboPay.ValueMember = "IDPay";
            this.comboPay.SelectedIndexChanged += new System.EventHandler(this.comboPay_SelectedIndexChanged);
            // 
            // picClose
            // 
            this.picClose.BackColor = System.Drawing.Color.Transparent;
            this.picClose.BackgroundImage = global::NadzhafovaMKPraktica.Properties.Resources.ddd;
            this.picClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picClose.Location = new System.Drawing.Point(1103, 12);
            this.picClose.Name = "picClose";
            this.picClose.Size = new System.Drawing.Size(39, 35);
            this.picClose.TabIndex = 91;
            this.picClose.TabStop = false;
            this.picClose.Click += new System.EventHandler(this.picClose_Click);
            // 
            // OrderUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::NadzhafovaMKPraktica.Properties.Resources.orders2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1154, 619);
            this.Controls.Add(this.picClose);
            this.Controls.Add(this.comboPay);
            this.Controls.Add(this.comboAddress);
            this.Controls.Add(this.btnAddOnOrders);
            this.Controls.Add(this.tableConsist);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OrderUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrderUser";
            this.Load += new System.EventHandler(this.OrderUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tableConsist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmaciesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmPanaceyaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.payMethodBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView tableConsist;
        private PharmPanaceyaDataSet pharmPanaceyaDataSet;
        private System.Windows.Forms.BindingSource pharmaciesBindingSource;
        private PharmPanaceyaDataSetTableAdapters.PharmaciesTableAdapter pharmaciesTableAdapter;
        private System.Windows.Forms.BindingSource payMethodBindingSource;
        private PharmPanaceyaDataSetTableAdapters.PayMethodTableAdapter payMethodTableAdapter;
        private System.Windows.Forms.Button btnAddOnOrders;
        private System.Windows.Forms.ComboBox comboAddress;
        private System.Windows.Forms.ComboBox comboPay;
        private System.Windows.Forms.PictureBox picClose;
    }
}