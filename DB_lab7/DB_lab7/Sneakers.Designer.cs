
namespace DB_lab7
{
    partial class Sneakers
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
            this.SneakersDataGrid = new System.Windows.Forms.DataGridView();
            this.insertButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.text_model = new System.Windows.Forms.TextBox();
            this.text_gender = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.text_price = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.text_idBrand = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SneakersDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // SneakersDataGrid
            // 
            this.SneakersDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SneakersDataGrid.Location = new System.Drawing.Point(12, 231);
            this.SneakersDataGrid.Name = "SneakersDataGrid";
            this.SneakersDataGrid.RowHeadersWidth = 47;
            this.SneakersDataGrid.Size = new System.Drawing.Size(621, 207);
            this.SneakersDataGrid.TabIndex = 0;
            // 
            // insertButton
            // 
            this.insertButton.Location = new System.Drawing.Point(12, 179);
            this.insertButton.Name = "insertButton";
            this.insertButton.Size = new System.Drawing.Size(103, 37);
            this.insertButton.TabIndex = 1;
            this.insertButton.Text = "INSERT";
            this.insertButton.UseVisualStyleBackColor = true;
            this.insertButton.Click += new System.EventHandler(this.insertButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(171, 179);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(103, 37);
            this.updateButton.TabIndex = 2;
            this.updateButton.Text = "UPDATE";
            this.updateButton.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(530, 179);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(103, 37);
            this.button3.TabIndex = 4;
            this.button3.Text = "RESET";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(346, 179);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(103, 37);
            this.deleteButton.TabIndex = 3;
            this.deleteButton.Text = "DELETE";
            this.deleteButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "model";
            // 
            // text_model
            // 
            this.text_model.Location = new System.Drawing.Point(76, 20);
            this.text_model.Name = "text_model";
            this.text_model.Size = new System.Drawing.Size(100, 20);
            this.text_model.TabIndex = 6;
            // 
            // text_gender
            // 
            this.text_gender.Location = new System.Drawing.Point(76, 46);
            this.text_gender.Name = "text_gender";
            this.text_gender.Size = new System.Drawing.Size(100, 20);
            this.text_gender.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "gender";
            // 
            // text_price
            // 
            this.text_price.Location = new System.Drawing.Point(76, 72);
            this.text_price.Name = "text_price";
            this.text_price.Size = new System.Drawing.Size(100, 20);
            this.text_price.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "price";
            // 
            // text_idBrand
            // 
            this.text_idBrand.Location = new System.Drawing.Point(76, 98);
            this.text_idBrand.Name = "text_idBrand";
            this.text_idBrand.Size = new System.Drawing.Size(100, 20);
            this.text_idBrand.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "id_brand";
            // 
            // Sneakers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 450);
            this.Controls.Add(this.text_idBrand);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.text_price);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.text_gender);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.text_model);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.insertButton);
            this.Controls.Add(this.SneakersDataGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Sneakers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sneakers";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SneakersDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView SneakersDataGrid;
        private System.Windows.Forms.Button insertButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox text_model;
        private System.Windows.Forms.TextBox text_gender;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox text_price;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox text_idBrand;
        private System.Windows.Forms.Label label4;
    }
}

