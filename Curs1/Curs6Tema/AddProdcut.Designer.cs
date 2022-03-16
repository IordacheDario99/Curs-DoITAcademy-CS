namespace Curs6Tema
{
    partial class AddProdcut
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
            this.label1 = new System.Windows.Forms.Label();
            this.productNamelabel = new System.Windows.Forms.Label();
            this.productcategoryLabel = new System.Windows.Forms.Label();
            this.productPriceLabel = new System.Windows.Forms.Label();
            this.productDescriptionLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox3 = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Freestyle Script", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(197, 244);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Freestyle Script", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(80, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Add new product";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // productNamelabel
            // 
            this.productNamelabel.Font = new System.Drawing.Font("Freestyle Script", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productNamelabel.Location = new System.Drawing.Point(12, 60);
            this.productNamelabel.Name = "productNamelabel";
            this.productNamelabel.Size = new System.Drawing.Size(80, 18);
            this.productNamelabel.TabIndex = 2;
            this.productNamelabel.Text = "Name";
            // 
            // productcategoryLabel
            // 
            this.productcategoryLabel.Font = new System.Drawing.Font("Freestyle Script", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productcategoryLabel.Location = new System.Drawing.Point(12, 86);
            this.productcategoryLabel.Name = "productcategoryLabel";
            this.productcategoryLabel.Size = new System.Drawing.Size(51, 23);
            this.productcategoryLabel.TabIndex = 3;
            this.productcategoryLabel.Text = "Cateogry";
            // 
            // productPriceLabel
            // 
            this.productPriceLabel.Font = new System.Drawing.Font("Freestyle Script", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productPriceLabel.Location = new System.Drawing.Point(12, 112);
            this.productPriceLabel.Name = "productPriceLabel";
            this.productPriceLabel.Size = new System.Drawing.Size(51, 17);
            this.productPriceLabel.TabIndex = 4;
            this.productPriceLabel.Text = "Price";
            // 
            // productDescriptionLabel
            // 
            this.productDescriptionLabel.Font = new System.Drawing.Font("Freestyle Script", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productDescriptionLabel.Location = new System.Drawing.Point(12, 138);
            this.productDescriptionLabel.Name = "productDescriptionLabel";
            this.productDescriptionLabel.Size = new System.Drawing.Size(64, 14);
            this.productDescriptionLabel.TabIndex = 5;
            this.productDescriptionLabel.Text = "Description";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(98, 60);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(140, 20);
            this.nameTextBox.TabIndex = 6;
            // 
            // priceTextBox3
            // 
            this.priceTextBox3.Location = new System.Drawing.Point(98, 112);
            this.priceTextBox3.Name = "priceTextBox3";
            this.priceTextBox3.Size = new System.Drawing.Size(140, 20);
            this.priceTextBox3.TabIndex = 8;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(98, 138);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(140, 74);
            this.descriptionTextBox.TabIndex = 9;
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(98, 85);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(140, 21);
            this.categoryComboBox.TabIndex = 10;
            // 
            // AddProdcut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 279);
            this.Controls.Add(this.categoryComboBox);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.priceTextBox3);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.productDescriptionLabel);
            this.Controls.Add(this.productPriceLabel);
            this.Controls.Add(this.productcategoryLabel);
            this.Controls.Add(this.productNamelabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "AddProdcut";
            this.Text = "AddProdcut";
            this.Shown += new System.EventHandler(this.AddProdcut_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label productNamelabel;
        private System.Windows.Forms.Label productcategoryLabel;
        private System.Windows.Forms.Label productPriceLabel;
        private System.Windows.Forms.Label productDescriptionLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox priceTextBox3;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.ComboBox categoryComboBox;
    }
}