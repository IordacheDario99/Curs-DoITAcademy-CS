using System;

namespace Curs5WindowsForms
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
            this.butonPrincipal = new System.Windows.Forms.Button();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.nameValidationLabel = new System.Windows.Forms.Label();
            this.countryComboBox = new System.Windows.Forms.ComboBox();
            this.elevRadioBox = new System.Windows.Forms.RadioButton();
            this.studentRadioBox = new System.Windows.Forms.RadioButton();
            this.hiredRadioButton = new System.Windows.Forms.RadioButton();
            this.smokerCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // butonPrincipal
            // 
            this.butonPrincipal.BackColor = System.Drawing.Color.SteelBlue;
            this.butonPrincipal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butonPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butonPrincipal.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.butonPrincipal.Location = new System.Drawing.Point(164, 294);
            this.butonPrincipal.Name = "butonPrincipal";
            this.butonPrincipal.Size = new System.Drawing.Size(182, 66);
            this.butonPrincipal.TabIndex = 0;
            this.butonPrincipal.Text = "Apasa-ma!!";
            this.butonPrincipal.UseVisualStyleBackColor = false;
            this.butonPrincipal.Click += new System.EventHandler(this.butonPrincipal_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(31, 37);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(124, 46);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Nume";
            // 
            // nameTextBox
            // 
            this.nameTextBox.BackColor = System.Drawing.Color.IndianRed;
            this.nameTextBox.ForeColor = System.Drawing.SystemColors.Window;
            this.nameTextBox.Location = new System.Drawing.Point(147, 37);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(430, 20);
            this.nameTextBox.TabIndex = 2;
            // 
            // nameValidationLabel
            // 
            this.nameValidationLabel.ForeColor = System.Drawing.Color.Red;
            this.nameValidationLabel.Location = new System.Drawing.Point(144, 60);
            this.nameValidationLabel.Name = "nameValidationLabel";
            this.nameValidationLabel.Size = new System.Drawing.Size(202, 35);
            this.nameValidationLabel.TabIndex = 3;
            // 
            // countryComboBox
            // 
            this.countryComboBox.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.countryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.countryComboBox.FormattingEnabled = true;
            this.countryComboBox.Items.AddRange(new object[] {
            "Romania",
            "Elvetia",
            "Spania",
            "Italia"});
            this.countryComboBox.Location = new System.Drawing.Point(147, 98);
            this.countryComboBox.Name = "countryComboBox";
            this.countryComboBox.Size = new System.Drawing.Size(430, 21);
            this.countryComboBox.TabIndex = 4;
            // 
            // elevRadioBox
            // 
            this.elevRadioBox.Checked = true;
            this.elevRadioBox.Location = new System.Drawing.Point(147, 158);
            this.elevRadioBox.Name = "elevRadioBox";
            this.elevRadioBox.Size = new System.Drawing.Size(83, 19);
            this.elevRadioBox.TabIndex = 5;
            this.elevRadioBox.TabStop = true;
            this.elevRadioBox.Text = "Elev";
            this.elevRadioBox.UseVisualStyleBackColor = true;
            this.elevRadioBox.CheckedChanged += new System.EventHandler(this.elevRadioBox_CheckedChanged);
            // 
            // studentRadioBox
            // 
            this.studentRadioBox.Location = new System.Drawing.Point(261, 158);
            this.studentRadioBox.Name = "studentRadioBox";
            this.studentRadioBox.Size = new System.Drawing.Size(83, 19);
            this.studentRadioBox.TabIndex = 6;
            this.studentRadioBox.TabStop = true;
            this.studentRadioBox.Text = "Student";
            this.studentRadioBox.UseVisualStyleBackColor = true;
            // 
            // hiredRadioButton
            // 
            this.hiredRadioButton.Location = new System.Drawing.Point(397, 158);
            this.hiredRadioButton.Name = "hiredRadioButton";
            this.hiredRadioButton.Size = new System.Drawing.Size(83, 19);
            this.hiredRadioButton.TabIndex = 7;
            this.hiredRadioButton.TabStop = true;
            this.hiredRadioButton.Text = "Angajat";
            this.hiredRadioButton.UseVisualStyleBackColor = true;
            // 
            // smokerCheckBox
            // 
            this.smokerCheckBox.AutoEllipsis = true;
            this.smokerCheckBox.AutoSize = true;
            this.smokerCheckBox.Location = new System.Drawing.Point(147, 204);
            this.smokerCheckBox.Name = "smokerCheckBox";
            this.smokerCheckBox.Size = new System.Drawing.Size(64, 17);
            this.smokerCheckBox.TabIndex = 8;
            this.smokerCheckBox.Text = "Fumator";
            this.smokerCheckBox.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(643, 432);
            this.Controls.Add(this.smokerCheckBox);
            this.Controls.Add(this.hiredRadioButton);
            this.Controls.Add(this.studentRadioBox);
            this.Controls.Add(this.elevRadioBox);
            this.Controls.Add(this.countryComboBox);
            this.Controls.Add(this.nameValidationLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.butonPrincipal);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prima aplicatie";
            this.DoubleClick += new System.EventHandler(this.Form1_DoubleClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butonPrincipal;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label nameValidationLabel;
        private System.Windows.Forms.ComboBox countryComboBox;
        private System.Windows.Forms.RadioButton elevRadioBox;
        private System.Windows.Forms.RadioButton studentRadioBox;
        private System.Windows.Forms.RadioButton hiredRadioButton;
        private System.Windows.Forms.CheckBox smokerCheckBox;
    }
}

