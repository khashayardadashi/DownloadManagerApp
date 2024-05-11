namespace Download_manager
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.url = new System.Windows.Forms.TextBox();
            this.filename = new System.Windows.Forms.TextBox();
            this.download = new System.Windows.Forms.Button();
            this.progress = new System.Windows.Forms.ProgressBar();
            this.num = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "URL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "FileName";
            // 
            // url
            // 
            this.url.Location = new System.Drawing.Point(79, 21);
            this.url.Name = "url";
            this.url.Size = new System.Drawing.Size(519, 22);
            this.url.TabIndex = 2;
            this.url.TextChanged += new System.EventHandler(this.url_TextChanged);
            // 
            // filename
            // 
            this.filename.Location = new System.Drawing.Point(79, 59);
            this.filename.Name = "filename";
            this.filename.Size = new System.Drawing.Size(519, 22);
            this.filename.TabIndex = 3;
            // 
            // download
            // 
            this.download.Location = new System.Drawing.Point(10, 100);
            this.download.Name = "download";
            this.download.Size = new System.Drawing.Size(106, 23);
            this.download.TabIndex = 4;
            this.download.Text = "Download";
            this.download.UseVisualStyleBackColor = true;
            this.download.Click += new System.EventHandler(this.download_Click);
            // 
            // progress
            // 
            this.progress.Location = new System.Drawing.Point(122, 100);
            this.progress.MarqueeAnimationSpeed = 10;
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(444, 23);
            this.progress.TabIndex = 10;
            // 
            // num
            // 
            this.num.AutoSize = true;
            this.num.Location = new System.Drawing.Point(572, 103);
            this.num.Name = "num";
            this.num.Size = new System.Drawing.Size(26, 16);
            this.num.TabIndex = 6;
            this.num.Text = "0%";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 150);
            this.Controls.Add(this.num);
            this.Controls.Add(this.progress);
            this.Controls.Add(this.download);
            this.Controls.Add(this.filename);
            this.Controls.Add(this.url);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "download manager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox url;
        private System.Windows.Forms.TextBox filename;
        private System.Windows.Forms.Button download;
        private System.Windows.Forms.ProgressBar progress;
        private System.Windows.Forms.Label num;
    }
}

