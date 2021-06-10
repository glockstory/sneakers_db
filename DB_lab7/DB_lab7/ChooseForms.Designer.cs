
namespace DB_lab7
{
    partial class ChooseForms
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
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.query1 = new System.Windows.Forms.Button();
            this.query2 = new System.Windows.Forms.Button();
            this.selectPrice = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(57, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 51);
            this.button1.TabIndex = 0;
            this.button1.Text = "to Sneakers";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(57, 107);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(115, 51);
            this.button3.TabIndex = 2;
            this.button3.Text = "to Exemplar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // query1
            // 
            this.query1.Location = new System.Drawing.Point(57, 185);
            this.query1.Name = "query1";
            this.query1.Size = new System.Drawing.Size(115, 51);
            this.query1.TabIndex = 3;
            this.query1.Text = "to select model";
            this.query1.UseVisualStyleBackColor = true;
            this.query1.Click += new System.EventHandler(this.query1_Click);
            // 
            // query2
            // 
            this.query2.Location = new System.Drawing.Point(57, 266);
            this.query2.Name = "query2";
            this.query2.Size = new System.Drawing.Size(115, 51);
            this.query2.TabIndex = 4;
            this.query2.Text = "to select sneaker with size";
            this.query2.UseVisualStyleBackColor = true;
            this.query2.Click += new System.EventHandler(this.query2_Click);
            // 
            // selectPrice
            // 
            this.selectPrice.Location = new System.Drawing.Point(57, 341);
            this.selectPrice.Name = "selectPrice";
            this.selectPrice.Size = new System.Drawing.Size(115, 51);
            this.selectPrice.TabIndex = 5;
            this.selectPrice.Text = "select models with price";
            this.selectPrice.UseVisualStyleBackColor = true;
            this.selectPrice.Click += new System.EventHandler(this.selectPrice_Click);
            // 
            // ChooseForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(233, 394);
            this.Controls.Add(this.selectPrice);
            this.Controls.Add(this.query2);
            this.Controls.Add(this.query1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Name = "ChooseForms";
            this.Text = "ChooseForms";
            this.Load += new System.EventHandler(this.ChooseForms_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button query1;
        private System.Windows.Forms.Button query2;
        private System.Windows.Forms.Button selectPrice;
    }
}