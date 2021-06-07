
namespace DB_lab7
{
    partial class Exemplar
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
            this.text_idSneakers = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.text_color = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.text_size = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.text_count = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.insertButton = new System.Windows.Forms.Button();
            this.SneakersDataGrid = new System.Windows.Forms.DataGridView();
            this.text_idSale = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.text_idDelivery = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SneakersDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // text_idSneakers
            // 
            this.text_idSneakers.Location = new System.Drawing.Point(285, 98);
            this.text_idSneakers.Name = "text_idSneakers";
            this.text_idSneakers.Size = new System.Drawing.Size(100, 20);
            this.text_idSneakers.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(231, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "id_sneakers";
            // 
            // text_color
            // 
            this.text_color.Location = new System.Drawing.Point(285, 72);
            this.text_color.Name = "text_color";
            this.text_color.Size = new System.Drawing.Size(100, 20);
            this.text_color.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(231, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "color";
            // 
            // text_size
            // 
            this.text_size.Location = new System.Drawing.Point(285, 46);
            this.text_size.Name = "text_size";
            this.text_size.Size = new System.Drawing.Size(100, 20);
            this.text_size.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(231, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "size";
            // 
            // text_count
            // 
            this.text_count.Location = new System.Drawing.Point(285, 20);
            this.text_count.Name = "text_count";
            this.text_count.Size = new System.Drawing.Size(100, 20);
            this.text_count.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(231, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "count";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(643, 141);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(103, 37);
            this.button3.TabIndex = 17;
            this.button3.Text = "RESET";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(433, 141);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(103, 37);
            this.deleteButton.TabIndex = 16;
            this.deleteButton.Text = "DELETE";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(214, 141);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(103, 37);
            this.updateButton.TabIndex = 15;
            this.updateButton.Text = "UPDATE";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // insertButton
            // 
            this.insertButton.Location = new System.Drawing.Point(22, 141);
            this.insertButton.Name = "insertButton";
            this.insertButton.Size = new System.Drawing.Size(103, 37);
            this.insertButton.TabIndex = 14;
            this.insertButton.Text = "INSERT";
            this.insertButton.UseVisualStyleBackColor = true;
            this.insertButton.Click += new System.EventHandler(this.insertButton_Click);
            // 
            // SneakersDataGrid
            // 
            this.SneakersDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SneakersDataGrid.Location = new System.Drawing.Point(22, 193);
            this.SneakersDataGrid.Name = "SneakersDataGrid";
            this.SneakersDataGrid.RowHeadersWidth = 47;
            this.SneakersDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SneakersDataGrid.Size = new System.Drawing.Size(724, 207);
            this.SneakersDataGrid.TabIndex = 13;
            this.SneakersDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SneakersDataGrid_CellContentClick);
            // 
            // text_idSale
            // 
            this.text_idSale.Location = new System.Drawing.Point(473, 49);
            this.text_idSale.Name = "text_idSale";
            this.text_idSale.Size = new System.Drawing.Size(100, 20);
            this.text_idSale.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(410, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "id_sale";
            // 
            // text_idDelivery
            // 
            this.text_idDelivery.Location = new System.Drawing.Point(473, 20);
            this.text_idDelivery.Name = "text_idDelivery";
            this.text_idDelivery.Size = new System.Drawing.Size(100, 20);
            this.text_idDelivery.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(410, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "id_delivery";
            // 
            // Exemplar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 437);
            this.Controls.Add(this.text_idSale);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.text_idDelivery);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.text_idSneakers);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.text_color);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.text_size);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.text_count);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.insertButton);
            this.Controls.Add(this.SneakersDataGrid);
            this.Name = "Exemplar";
            this.Text = "Exemplar";
            this.Load += new System.EventHandler(this.Exemplar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SneakersDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox text_idSneakers;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox text_color;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox text_size;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox text_count;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button insertButton;
        private System.Windows.Forms.DataGridView SneakersDataGrid;
        private System.Windows.Forms.TextBox text_idSale;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox text_idDelivery;
        private System.Windows.Forms.Label label6;
    }
}