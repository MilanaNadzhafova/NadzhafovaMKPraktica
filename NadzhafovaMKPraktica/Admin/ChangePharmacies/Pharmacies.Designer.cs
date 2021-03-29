﻿
namespace NadzhafovaMKPraktica
{
    partial class Pharmacies
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pharmacies));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.picClose = new System.Windows.Forms.PictureBox();
            this.tableOrders = new System.Windows.Forms.DataGridView();
            this.pharmaciesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pharmPanaceyaDataSet = new NadzhafovaMKPraktica.PharmPanaceyaDataSet();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lbList = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.pharmaciesTableAdapter = new NadzhafovaMKPraktica.PharmPanaceyaDataSetTableAdapters.PharmaciesTableAdapter();
            this.IDPharm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeWorkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmaciesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmPanaceyaDataSet)).BeginInit();
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
            this.picLogo.TabIndex = 66;
            this.picLogo.TabStop = false;
            // 
            // picClose
            // 
            this.picClose.BackColor = System.Drawing.Color.Transparent;
            this.picClose.BackgroundImage = global::NadzhafovaMKPraktica.Properties.Resources.close;
            this.picClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picClose.Location = new System.Drawing.Point(653, 14);
            this.picClose.Margin = new System.Windows.Forms.Padding(2);
            this.picClose.Name = "picClose";
            this.picClose.Size = new System.Drawing.Size(55, 46);
            this.picClose.TabIndex = 65;
            this.picClose.TabStop = false;
            this.picClose.Click += new System.EventHandler(this.picClose_Click);
            // 
            // tableOrders
            // 
            this.tableOrders.AllowUserToAddRows = false;
            this.tableOrders.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tableOrders.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tableOrders.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableOrders.AutoGenerateColumns = false;
            this.tableOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tableOrders.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.tableOrders.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(239)))), ((int)(((byte)(253)))));
            this.tableOrders.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Georgia", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tableOrders.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tableOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDPharm,
            this.nameDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.timeWorkDataGridViewTextBoxColumn});
            this.tableOrders.DataSource = this.pharmaciesBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tableOrders.DefaultCellStyle = dataGridViewCellStyle3;
            this.tableOrders.Location = new System.Drawing.Point(12, 113);
            this.tableOrders.Margin = new System.Windows.Forms.Padding(4);
            this.tableOrders.Name = "tableOrders";
            this.tableOrders.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tableOrders.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.tableOrders.RowHeadersVisible = false;
            this.tableOrders.RowHeadersWidth = 80;
            this.tableOrders.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tableOrders.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.tableOrders.Size = new System.Drawing.Size(700, 230);
            this.tableOrders.TabIndex = 60;
            this.tableOrders.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tableOrders_CellClick);
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
            // btnChange
            // 
            this.btnChange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(189)))), ((int)(((byte)(199)))));
            this.btnChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnChange.Location = new System.Drawing.Point(289, 359);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(148, 42);
            this.btnChange.TabIndex = 64;
            this.btnChange.Text = "Изменить";
            this.btnChange.UseVisualStyleBackColor = false;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(189)))), ((int)(((byte)(199)))));
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSearch.Location = new System.Drawing.Point(590, 70);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(122, 36);
            this.btnSearch.TabIndex = 63;
            this.btnSearch.Text = "Поиск";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Georgia", 12F);
            this.txtSearch.Location = new System.Drawing.Point(12, 73);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(562, 31);
            this.txtSearch.TabIndex = 62;
            this.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbList
            // 
            this.lbList.AutoSize = true;
            this.lbList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbList.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbList.Location = new System.Drawing.Point(12, 9);
            this.lbList.MinimumSize = new System.Drawing.Size(700, 55);
            this.lbList.Name = "lbList";
            this.lbList.Size = new System.Drawing.Size(700, 55);
            this.lbList.TabIndex = 61;
            this.lbList.Text = "Список аптек";
            this.lbList.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(189)))), ((int)(((byte)(199)))));
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnDelete.Location = new System.Drawing.Point(560, 359);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(148, 42);
            this.btnDelete.TabIndex = 68;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(189)))), ((int)(((byte)(199)))));
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAdd.Location = new System.Drawing.Point(13, 359);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(148, 42);
            this.btnAdd.TabIndex = 67;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // pharmaciesTableAdapter
            // 
            this.pharmaciesTableAdapter.ClearBeforeFill = true;
            // 
            // IDPharm
            // 
            this.IDPharm.DataPropertyName = "IDPharm";
            this.IDPharm.HeaderText = "IDPharm";
            this.IDPharm.Name = "IDPharm";
            this.IDPharm.ReadOnly = true;
            this.IDPharm.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Название";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Адрес";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // timeWorkDataGridViewTextBoxColumn
            // 
            this.timeWorkDataGridViewTextBoxColumn.DataPropertyName = "TimeWork";
            this.timeWorkDataGridViewTextBoxColumn.HeaderText = "Время работы";
            this.timeWorkDataGridViewTextBoxColumn.Name = "timeWorkDataGridViewTextBoxColumn";
            this.timeWorkDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Pharmacies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(239)))), ((int)(((byte)(253)))));
            this.ClientSize = new System.Drawing.Size(728, 413);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.picClose);
            this.Controls.Add(this.tableOrders);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lbList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Pharmacies";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pharmacies";
            this.Load += new System.EventHandler(this.Pharmacies_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmaciesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmPanaceyaDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.PictureBox picClose;
        private System.Windows.Forms.DataGridView tableOrders;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lbList;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private PharmPanaceyaDataSet pharmPanaceyaDataSet;
        private System.Windows.Forms.BindingSource pharmaciesBindingSource;
        private PharmPanaceyaDataSetTableAdapters.PharmaciesTableAdapter pharmaciesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDPharm;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeWorkDataGridViewTextBoxColumn;
    }
}