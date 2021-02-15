namespace WindowsFormVideoThumbnails
{
    partial class MainForm
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
            this.startDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.endDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.explorerTextBox = new System.Windows.Forms.TextBox();
            this.chooseFolderBtn = new System.Windows.Forms.Button();
            this.filesListBox = new System.Windows.Forms.ListBox();
            this.listFilesBtn = new System.Windows.Forms.Button();
            this.convertBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // startDateTimePicker
            // 
            this.startDateTimePicker.Location = new System.Drawing.Point(84, 85);
            this.startDateTimePicker.Name = "startDateTimePicker";
            this.startDateTimePicker.Size = new System.Drawing.Size(285, 20);
            this.startDateTimePicker.TabIndex = 0;
            // 
            // endDateTimePicker
            // 
            this.endDateTimePicker.Location = new System.Drawing.Point(412, 85);
            this.endDateTimePicker.Name = "endDateTimePicker";
            this.endDateTimePicker.Size = new System.Drawing.Size(300, 20);
            this.endDateTimePicker.TabIndex = 1;
            // 
            // explorerTextBox
            // 
            this.explorerTextBox.Enabled = false;
            this.explorerTextBox.Location = new System.Drawing.Point(84, 41);
            this.explorerTextBox.Name = "explorerTextBox";
            this.explorerTextBox.Size = new System.Drawing.Size(461, 20);
            this.explorerTextBox.TabIndex = 2;
            // 
            // chooseFolderBtn
            // 
            this.chooseFolderBtn.Location = new System.Drawing.Point(551, 41);
            this.chooseFolderBtn.Name = "chooseFolderBtn";
            this.chooseFolderBtn.Size = new System.Drawing.Size(161, 23);
            this.chooseFolderBtn.TabIndex = 3;
            this.chooseFolderBtn.Text = "Selecciona Carpeta";
            this.chooseFolderBtn.UseVisualStyleBackColor = true;
            this.chooseFolderBtn.Click += new System.EventHandler(this.chooseFolderBtn_Click);
            // 
            // filesListBox
            // 
            this.filesListBox.FormattingEnabled = true;
            this.filesListBox.Location = new System.Drawing.Point(84, 167);
            this.filesListBox.Name = "filesListBox";
            this.filesListBox.Size = new System.Drawing.Size(628, 121);
            this.filesListBox.TabIndex = 4;
            // 
            // listFilesBtn
            // 
            this.listFilesBtn.Location = new System.Drawing.Point(84, 123);
            this.listFilesBtn.Name = "listFilesBtn";
            this.listFilesBtn.Size = new System.Drawing.Size(628, 23);
            this.listFilesBtn.TabIndex = 5;
            this.listFilesBtn.Text = "Listar Videos";
            this.listFilesBtn.UseVisualStyleBackColor = true;
            this.listFilesBtn.Click += new System.EventHandler(this.listFilesBtn_Click);
            // 
            // convertBtn
            // 
            this.convertBtn.Location = new System.Drawing.Point(84, 312);
            this.convertBtn.Name = "convertBtn";
            this.convertBtn.Size = new System.Drawing.Size(144, 23);
            this.convertBtn.TabIndex = 6;
            this.convertBtn.Text = "Extraer imágenes";
            this.convertBtn.UseVisualStyleBackColor = true;
            this.convertBtn.Click += new System.EventHandler(this.convertBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.convertBtn);
            this.Controls.Add(this.listFilesBtn);
            this.Controls.Add(this.filesListBox);
            this.Controls.Add(this.chooseFolderBtn);
            this.Controls.Add(this.explorerTextBox);
            this.Controls.Add(this.endDateTimePicker);
            this.Controls.Add(this.startDateTimePicker);
            this.AccessibleName = "MainForm";
            this.Text = "Exportador de videos 0.1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker startDateTimePicker;
        private System.Windows.Forms.DateTimePicker endDateTimePicker;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.TextBox explorerTextBox;
        private System.Windows.Forms.Button chooseFolderBtn;
        private System.Windows.Forms.ListBox filesListBox;
        private System.Windows.Forms.Button listFilesBtn;
        private System.Windows.Forms.Button convertBtn;
    }
}

