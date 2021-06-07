
namespace DbLab6
{
    partial class SneakersForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.shopsneakersDataSet = new DbLab6.shopsneakersDataSet();
            this.shopsneakersDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shopsneakersDataSet1 = new DbLab6.shopsneakersDataSet1();
            this.sneakersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sneakersTableAdapter = new DbLab6.shopsneakersDataSet1TableAdapters.sneakersTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idbrandDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addSneakers = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopsneakersDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopsneakersDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopsneakersDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sneakersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.modelDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.idbrandDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.sneakersBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 47;
            this.dataGridView1.Size = new System.Drawing.Size(625, 426);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // shopsneakersDataSet
            // 
            this.shopsneakersDataSet.DataSetName = "shopsneakersDataSet";
            this.shopsneakersDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // shopsneakersDataSetBindingSource
            // 
            this.shopsneakersDataSetBindingSource.DataSource = this.shopsneakersDataSet;
            this.shopsneakersDataSetBindingSource.Position = 0;
            // 
            // shopsneakersDataSet1
            // 
            this.shopsneakersDataSet1.DataSetName = "shopsneakersDataSet1";
            this.shopsneakersDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sneakersBindingSource
            // 
            this.sneakersBindingSource.DataMember = "sneakers";
            this.sneakersBindingSource.DataSource = this.shopsneakersDataSet1;
            // 
            // sneakersTableAdapter
            // 
            this.sneakersTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 115;
            // 
            // modelDataGridViewTextBoxColumn
            // 
            this.modelDataGridViewTextBoxColumn.DataPropertyName = "model";
            this.modelDataGridViewTextBoxColumn.HeaderText = "model";
            this.modelDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.modelDataGridViewTextBoxColumn.Name = "modelDataGridViewTextBoxColumn";
            this.modelDataGridViewTextBoxColumn.Width = 115;
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "gender";
            this.genderDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            this.genderDataGridViewTextBoxColumn.Width = 115;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "price";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.Width = 115;
            // 
            // idbrandDataGridViewTextBoxColumn
            // 
            this.idbrandDataGridViewTextBoxColumn.DataPropertyName = "id_brand";
            this.idbrandDataGridViewTextBoxColumn.HeaderText = "id_brand";
            this.idbrandDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idbrandDataGridViewTextBoxColumn.Name = "idbrandDataGridViewTextBoxColumn";
            this.idbrandDataGridViewTextBoxColumn.Width = 115;
            // 
            // addSneakers
            // 
            this.addSneakers.Location = new System.Drawing.Point(643, 20);
            this.addSneakers.Name = "addSneakers";
            this.addSneakers.Size = new System.Drawing.Size(75, 23);
            this.addSneakers.TabIndex = 2;
            this.addSneakers.Text = "Add";
            this.addSneakers.UseVisualStyleBackColor = true;
            this.addSneakers.Click += new System.EventHandler(this.button2_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(643, 49);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 3;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            // 
            // SneakersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 450);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.addSneakers);
            this.Controls.Add(this.dataGridView1);
            this.Name = "SneakersForm";
            this.Text = "SneakersForm";
            this.Load += new System.EventHandler(this.SneakersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopsneakersDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopsneakersDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopsneakersDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sneakersBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridView1;
        private shopsneakersDataSet shopsneakersDataSet;
        private System.Windows.Forms.BindingSource shopsneakersDataSetBindingSource;
        public shopsneakersDataSet1 shopsneakersDataSet1;
        public System.Windows.Forms.BindingSource sneakersBindingSource;
        public shopsneakersDataSet1TableAdapters.sneakersTableAdapter sneakersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idbrandDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button addSneakers;
        private System.Windows.Forms.Button saveButton;
    }
}