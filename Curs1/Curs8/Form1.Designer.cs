namespace Curs8
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
            this.messageDsiplay = new System.Windows.Forms.RichTextBox();
            this.readButton = new System.Windows.Forms.Button();
            this.browseFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.browseFile = new System.Windows.Forms.Button();
            this.writeButton = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SaveButton = new System.Windows.Forms.Button();
            this.copyButton = new System.Windows.Forms.Button();
            this.moveFileButton = new System.Windows.Forms.Button();
            this.deleteFilebutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // messageDsiplay
            // 
            this.messageDsiplay.Location = new System.Drawing.Point(12, 12);
            this.messageDsiplay.Name = "messageDsiplay";
            this.messageDsiplay.Size = new System.Drawing.Size(446, 167);
            this.messageDsiplay.TabIndex = 0;
            this.messageDsiplay.Text = "";
            // 
            // readButton
            // 
            this.readButton.Location = new System.Drawing.Point(12, 185);
            this.readButton.Name = "readButton";
            this.readButton.Size = new System.Drawing.Size(75, 23);
            this.readButton.TabIndex = 1;
            this.readButton.Text = "Read";
            this.readButton.UseVisualStyleBackColor = true;
            this.readButton.Click += new System.EventHandler(this.readButton_Click);
            // 
            // browseFileDialog
            // 
            this.browseFileDialog.FileName = "openFileDialog1";
            this.browseFileDialog.Filter = "All |*.*";
            this.browseFileDialog.Title = "Pick a file";
            // 
            // browseFile
            // 
            this.browseFile.Location = new System.Drawing.Point(93, 185);
            this.browseFile.Name = "browseFile";
            this.browseFile.Size = new System.Drawing.Size(75, 23);
            this.browseFile.TabIndex = 2;
            this.browseFile.Text = "Browse";
            this.browseFile.UseVisualStyleBackColor = true;
            this.browseFile.Click += new System.EventHandler(this.browseFile_Click);
            // 
            // writeButton
            // 
            this.writeButton.Location = new System.Drawing.Point(174, 185);
            this.writeButton.Name = "writeButton";
            this.writeButton.Size = new System.Drawing.Size(75, 23);
            this.writeButton.TabIndex = 3;
            this.writeButton.Text = "Write";
            this.writeButton.UseVisualStyleBackColor = true;
            this.writeButton.Click += new System.EventHandler(this.writeButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(256, 186);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 4;
            this.SaveButton.TabStop = false;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // copyButton
            // 
            this.copyButton.Location = new System.Drawing.Point(338, 186);
            this.copyButton.Name = "copyButton";
            this.copyButton.Size = new System.Drawing.Size(75, 23);
            this.copyButton.TabIndex = 5;
            this.copyButton.Text = "Copy File";
            this.copyButton.UseVisualStyleBackColor = true;
            this.copyButton.Click += new System.EventHandler(this.copyButton_Click);
            // 
            // moveFileButton
            // 
            this.moveFileButton.Location = new System.Drawing.Point(12, 214);
            this.moveFileButton.Name = "moveFileButton";
            this.moveFileButton.Size = new System.Drawing.Size(75, 23);
            this.moveFileButton.TabIndex = 6;
            this.moveFileButton.Text = "Move File";
            this.moveFileButton.UseVisualStyleBackColor = true;
            this.moveFileButton.Click += new System.EventHandler(this.moveFileButton_Click);
            // 
            // deleteFilebutton
            // 
            this.deleteFilebutton.Location = new System.Drawing.Point(93, 214);
            this.deleteFilebutton.Name = "deleteFilebutton";
            this.deleteFilebutton.Size = new System.Drawing.Size(75, 23);
            this.deleteFilebutton.TabIndex = 7;
            this.deleteFilebutton.Text = "Delete";
            this.deleteFilebutton.UseVisualStyleBackColor = true;
            this.deleteFilebutton.Click += new System.EventHandler(this.deleteFilebutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 245);
            this.Controls.Add(this.deleteFilebutton);
            this.Controls.Add(this.moveFileButton);
            this.Controls.Add(this.copyButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.writeButton);
            this.Controls.Add(this.browseFile);
            this.Controls.Add(this.readButton);
            this.Controls.Add(this.messageDsiplay);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox messageDsiplay;
        private System.Windows.Forms.Button readButton;
        private System.Windows.Forms.OpenFileDialog browseFileDialog;
        private System.Windows.Forms.Button browseFile;
        private System.Windows.Forms.Button writeButton;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button copyButton;
        private System.Windows.Forms.Button moveFileButton;
        private System.Windows.Forms.Button deleteFilebutton;
    }
}

