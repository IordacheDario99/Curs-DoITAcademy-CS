using System;

namespace Curs5Tema1Ghici
{
    partial class Ghici
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ghici));
            this.checkButton = new System.Windows.Forms.Button();
            this.numberLabel = new System.Windows.Forms.Label();
            this.timerProgressBar = new System.Windows.Forms.ProgressBar();
            this.timerProgressLabel = new System.Windows.Forms.Label();
            this.input = new System.Windows.Forms.TextBox();
            this.statusLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.easyButton = new System.Windows.Forms.Button();
            this.hardButton = new System.Windows.Forms.Button();
            this.mediumButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkButton
            // 
            this.checkButton.BackColor = System.Drawing.Color.YellowGreen;
            this.checkButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.checkButton.Font = new System.Drawing.Font("MV Boli", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.checkButton.Location = new System.Drawing.Point(69, 110);
            this.checkButton.Name = "checkButton";
            this.checkButton.Size = new System.Drawing.Size(75, 23);
            this.checkButton.TabIndex = 0;
            this.checkButton.Text = "Check!";
            this.checkButton.UseVisualStyleBackColor = false;
            this.checkButton.Click += new System.EventHandler(this.checkButton_Click);
            // 
            // numberLabel
            // 
            this.numberLabel.AutoSize = true;
            this.numberLabel.Font = new System.Drawing.Font("MV Boli", 8.25F);
            this.numberLabel.Location = new System.Drawing.Point(50, 55);
            this.numberLabel.Name = "numberLabel";
            this.numberLabel.Size = new System.Drawing.Size(117, 16);
            this.numberLabel.TabIndex = 1;
            this.numberLabel.Text = "Introduceti un numar";
            // 
            // timerProgressBar
            // 
            this.timerProgressBar.Location = new System.Drawing.Point(53, 154);
            this.timerProgressBar.Name = "timerProgressBar";
            this.timerProgressBar.Size = new System.Drawing.Size(114, 23);
            this.timerProgressBar.TabIndex = 2;
            this.timerProgressBar.Click += new System.EventHandler(this.timerProgressBar_Click);
            // 
            // timerProgressLabel
            // 
            this.timerProgressLabel.AutoSize = true;
            this.timerProgressLabel.Font = new System.Drawing.Font("MV Boli", 8.25F);
            this.timerProgressLabel.Location = new System.Drawing.Point(12, 154);
            this.timerProgressLabel.Name = "timerProgressLabel";
            this.timerProgressLabel.Size = new System.Drawing.Size(32, 16);
            this.timerProgressLabel.TabIndex = 3;
            this.timerProgressLabel.Text = "Timp";
            // 
            // input
            // 
            this.input.Location = new System.Drawing.Point(53, 71);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(114, 20);
            this.input.TabIndex = 4;
            // 
            // statusLabel
            // 
            this.statusLabel.Font = new System.Drawing.Font("MV Boli", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLabel.ForeColor = System.Drawing.Color.Firebrick;
            this.statusLabel.Location = new System.Drawing.Point(12, 9);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(192, 46);
            this.statusLabel.TabIndex = 5;
            this.statusLabel.Text = "STATUS";
            this.statusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // easyButton
            // 
            this.easyButton.BackColor = System.Drawing.Color.YellowGreen;
            this.easyButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.easyButton.Font = new System.Drawing.Font("MV Boli", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.easyButton.Location = new System.Drawing.Point(20, 195);
            this.easyButton.Name = "easyButton";
            this.easyButton.Size = new System.Drawing.Size(54, 23);
            this.easyButton.TabIndex = 6;
            this.easyButton.Text = "Easy";
            this.easyButton.UseVisualStyleBackColor = false;
            this.easyButton.Click += new System.EventHandler(this.easyButton_Click);
            // 
            // hardButton
            // 
            this.hardButton.BackColor = System.Drawing.Color.Salmon;
            this.hardButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.hardButton.Font = new System.Drawing.Font("MV Boli", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hardButton.Location = new System.Drawing.Point(140, 195);
            this.hardButton.Name = "hardButton";
            this.hardButton.Size = new System.Drawing.Size(54, 23);
            this.hardButton.TabIndex = 7;
            this.hardButton.Text = "Hard";
            this.hardButton.UseVisualStyleBackColor = false;
            this.hardButton.Click += new System.EventHandler(this.hardButton_Click);
            // 
            // mediumButton
            // 
            this.mediumButton.BackColor = System.Drawing.Color.Gold;
            this.mediumButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.mediumButton.Font = new System.Drawing.Font("MV Boli", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mediumButton.Location = new System.Drawing.Point(80, 195);
            this.mediumButton.Name = "mediumButton";
            this.mediumButton.Size = new System.Drawing.Size(54, 23);
            this.mediumButton.TabIndex = 8;
            this.mediumButton.Text = "Medium";
            this.mediumButton.UseVisualStyleBackColor = false;
            this.mediumButton.Click += new System.EventHandler(this.mediumButton_Click);
            // 
            // Ghici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(216, 230);
            this.Controls.Add(this.mediumButton);
            this.Controls.Add(this.hardButton);
            this.Controls.Add(this.easyButton);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.input);
            this.Controls.Add(this.timerProgressLabel);
            this.Controls.Add(this.timerProgressBar);
            this.Controls.Add(this.numberLabel);
            this.Controls.Add(this.checkButton);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Ghici";
            this.Text = "Ghici";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button checkButton;
        private System.Windows.Forms.Label numberLabel;
        private System.Windows.Forms.ProgressBar timerProgressBar;
        private System.Windows.Forms.Label timerProgressLabel;
        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button easyButton;
        private System.Windows.Forms.Button hardButton;
        private System.Windows.Forms.Button mediumButton;
    }
}

