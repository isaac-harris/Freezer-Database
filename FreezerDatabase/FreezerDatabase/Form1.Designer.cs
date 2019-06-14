using System;

namespace FreezerDatabase
{
    partial class Form1
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
            this.itemName = new System.Windows.Forms.TextBox();
            this.useBy = new System.Windows.Forms.DateTimePicker();
            this.additionalNotes = new System.Windows.Forms.TextBox();
            this.locationDescription = new System.Windows.Forms.TextBox();
            this.saveRecord = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.itemIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.useByDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.additionalNotesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locationDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.freezerDatabaseDataSet = new FreezerDatabase.FreezerDatabaseDataSet();
            this.stockTableAdapter = new FreezerDatabase.FreezerDatabaseDataSetTableAdapters.StockTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.sortItemID = new System.Windows.Forms.RadioButton();
            this.orderButton = new System.Windows.Forms.Button();
            this.sortExpiryDate = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.freezerDatabaseDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // itemName
            // 
            this.itemName.Location = new System.Drawing.Point(94, 16);
            this.itemName.Name = "itemName";
            this.itemName.Size = new System.Drawing.Size(144, 20);
            this.itemName.TabIndex = 1;
            // 
            // useBy
            // 
            this.useBy.Location = new System.Drawing.Point(94, 42);
            this.useBy.Name = "useBy";
            this.useBy.Size = new System.Drawing.Size(144, 20);
            this.useBy.TabIndex = 2;
            // 
            // additionalNotes
            // 
            this.additionalNotes.Location = new System.Drawing.Point(94, 68);
            this.additionalNotes.Name = "additionalNotes";
            this.additionalNotes.Size = new System.Drawing.Size(144, 20);
            this.additionalNotes.TabIndex = 3;
            // 
            // locationDescription
            // 
            this.locationDescription.Location = new System.Drawing.Point(94, 94);
            this.locationDescription.Name = "locationDescription";
            this.locationDescription.Size = new System.Drawing.Size(144, 20);
            this.locationDescription.TabIndex = 4;
            // 
            // saveRecord
            // 
            this.saveRecord.Location = new System.Drawing.Point(237, 11);
            this.saveRecord.Name = "saveRecord";
            this.saveRecord.Size = new System.Drawing.Size(200, 100);
            this.saveRecord.TabIndex = 5;
            this.saveRecord.TabStop = false;
            this.saveRecord.Text = "Save Record";
            this.saveRecord.UseVisualStyleBackColor = true;
            this.saveRecord.Click += new System.EventHandler(this.saveRecord_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Item Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Use By Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Notes";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Location";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeight = 28;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemIDDataGridViewTextBoxColumn,
            this.itemNameDataGridViewTextBoxColumn,
            this.useByDataGridViewTextBoxColumn,
            this.additionalNotesDataGridViewTextBoxColumn,
            this.locationDescriptionDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.stockBindingSource;
            this.dataGridView1.GridColor = System.Drawing.Color.Black;
            this.dataGridView1.Location = new System.Drawing.Point(13, 131);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 100;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.Size = new System.Drawing.Size(621, 240);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.TabStop = false;
            // 
            // itemIDDataGridViewTextBoxColumn
            // 
            this.itemIDDataGridViewTextBoxColumn.DataPropertyName = "itemID";
            this.itemIDDataGridViewTextBoxColumn.HeaderText = "itemID";
            this.itemIDDataGridViewTextBoxColumn.Name = "itemIDDataGridViewTextBoxColumn";
            this.itemIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // itemNameDataGridViewTextBoxColumn
            // 
            this.itemNameDataGridViewTextBoxColumn.DataPropertyName = "itemName";
            this.itemNameDataGridViewTextBoxColumn.HeaderText = "itemName";
            this.itemNameDataGridViewTextBoxColumn.Name = "itemNameDataGridViewTextBoxColumn";
            // 
            // useByDataGridViewTextBoxColumn
            // 
            this.useByDataGridViewTextBoxColumn.DataPropertyName = "useBy";
            this.useByDataGridViewTextBoxColumn.HeaderText = "useBy";
            this.useByDataGridViewTextBoxColumn.Name = "useByDataGridViewTextBoxColumn";
            // 
            // additionalNotesDataGridViewTextBoxColumn
            // 
            this.additionalNotesDataGridViewTextBoxColumn.DataPropertyName = "additionalNotes";
            this.additionalNotesDataGridViewTextBoxColumn.HeaderText = "additionalNotes";
            this.additionalNotesDataGridViewTextBoxColumn.Name = "additionalNotesDataGridViewTextBoxColumn";
            // 
            // locationDescriptionDataGridViewTextBoxColumn
            // 
            this.locationDescriptionDataGridViewTextBoxColumn.DataPropertyName = "locationDescription";
            this.locationDescriptionDataGridViewTextBoxColumn.HeaderText = "locationDescription";
            this.locationDescriptionDataGridViewTextBoxColumn.Name = "locationDescriptionDataGridViewTextBoxColumn";
            // 
            // stockBindingSource
            // 
            this.stockBindingSource.DataMember = "Stock";
            this.stockBindingSource.DataSource = this.freezerDatabaseDataSet;
            // 
            // freezerDatabaseDataSet
            // 
            this.freezerDatabaseDataSet.DataSetName = "FreezerDatabaseDataSet";
            this.freezerDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stockTableAdapter
            // 
            this.stockTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.saveRecord);
            this.groupBox1.Location = new System.Drawing.Point(13, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(443, 119);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.sortItemID);
            this.groupBox2.Controls.Add(this.orderButton);
            this.groupBox2.Controls.Add(this.sortExpiryDate);
            this.groupBox2.Location = new System.Drawing.Point(472, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(88, 115);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            // 
            // sortItemID
            // 
            this.sortItemID.AutoSize = true;
            this.sortItemID.Location = new System.Drawing.Point(6, 53);
            this.sortItemID.Name = "sortItemID";
            this.sortItemID.Size = new System.Drawing.Size(75, 17);
            this.sortItemID.TabIndex = 2;
            this.sortItemID.TabStop = true;
            this.sortItemID.Text = "Input Date";
            this.sortItemID.UseVisualStyleBackColor = true;
            // 
            // orderButton
            // 
            this.orderButton.Location = new System.Drawing.Point(6, 11);
            this.orderButton.Name = "orderButton";
            this.orderButton.Size = new System.Drawing.Size(75, 23);
            this.orderButton.TabIndex = 1;
            this.orderButton.Text = "Sort";
            this.orderButton.UseVisualStyleBackColor = true;
            this.orderButton.Click += new System.EventHandler(this.orderButton_Click);
            // 
            // sortExpiryDate
            // 
            this.sortExpiryDate.AutoSize = true;
            this.sortExpiryDate.Location = new System.Drawing.Point(6, 35);
            this.sortExpiryDate.Name = "sortExpiryDate";
            this.sortExpiryDate.Size = new System.Drawing.Size(79, 17);
            this.sortExpiryDate.TabIndex = 0;
            this.sortExpiryDate.TabStop = true;
            this.sortExpiryDate.Text = "Expiry Date";
            this.sortExpiryDate.UseVisualStyleBackColor = true;
            this.sortExpiryDate.CheckedChanged += new System.EventHandler(this.sortExpiryDate_CheckedChanged);
            // 
            // Form1
            // 
            this.AcceptButton = this.saveRecord;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 398);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.locationDescription);
            this.Controls.Add(this.additionalNotes);
            this.Controls.Add(this.useBy);
            this.Controls.Add(this.itemName);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Freezer Database";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.freezerDatabaseDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion
        private System.Windows.Forms.TextBox itemName;
        private System.Windows.Forms.DateTimePicker useBy;
        private System.Windows.Forms.TextBox additionalNotes;
        private System.Windows.Forms.TextBox locationDescription;
        private System.Windows.Forms.Button saveRecord;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private FreezerDatabaseDataSet freezerDatabaseDataSet;
        private System.Windows.Forms.BindingSource stockBindingSource;
        private FreezerDatabaseDataSetTableAdapters.StockTableAdapter stockTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn useByDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn additionalNotesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button orderButton;
        private System.Windows.Forms.RadioButton sortExpiryDate;
        private System.Windows.Forms.RadioButton sortItemID;

        public EventHandler itemName_TextChanged { get; private set; }
        public EventHandler useBy_ValueChanged { get; private set; }
        public EventHandler additionalNotes_TextChanged { get; private set; }
        public EventHandler locationDescription_TextChanged { get; private set; }
    }
}

