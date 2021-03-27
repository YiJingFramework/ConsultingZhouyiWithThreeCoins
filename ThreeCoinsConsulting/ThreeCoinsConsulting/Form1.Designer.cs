
namespace ThreeCoinsConsulting
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelOriginalPainting = new System.Windows.Forms.Label();
            this.labelChangedPainting = new System.Windows.Forms.Label();
            this.pictureBoxCoin3 = new System.Windows.Forms.PictureBox();
            this.pictureBoxCoin2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxCoin1 = new System.Windows.Forms.PictureBox();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.buttonTossAll = new System.Windows.Forms.Button();
            this.buttonRestart = new System.Windows.Forms.Button();
            this.buttonRecord = new System.Windows.Forms.Button();
            this.textBoxResult2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoin3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoin2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoin1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelOriginalPainting
            // 
            this.labelOriginalPainting.AutoSize = true;
            this.labelOriginalPainting.Location = new System.Drawing.Point(17, 188);
            this.labelOriginalPainting.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelOriginalPainting.Name = "labelOriginalPainting";
            this.labelOriginalPainting.Size = new System.Drawing.Size(17, 126);
            this.labelOriginalPainting.TabIndex = 0;
            this.labelOriginalPainting.Text = "-\r\n-\r\n-\r\n-\r\n-\r\n-";
            // 
            // labelChangedPainting
            // 
            this.labelChangedPainting.AutoSize = true;
            this.labelChangedPainting.Location = new System.Drawing.Point(193, 293);
            this.labelChangedPainting.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelChangedPainting.Name = "labelChangedPainting";
            this.labelChangedPainting.Size = new System.Drawing.Size(55, 21);
            this.labelChangedPainting.TabIndex = 1;
            this.labelChangedPainting.Text = "label2";
            // 
            // pictureBoxCoin3
            // 
            this.pictureBoxCoin3.Location = new System.Drawing.Point(177, 15);
            this.pictureBoxCoin3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxCoin3.Name = "pictureBoxCoin3";
            this.pictureBoxCoin3.Size = new System.Drawing.Size(71, 62);
            this.pictureBoxCoin3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCoin3.TabIndex = 2;
            this.pictureBoxCoin3.TabStop = false;
            this.pictureBoxCoin3.Click += new System.EventHandler(this.Toss);
            // 
            // pictureBoxCoin2
            // 
            this.pictureBoxCoin2.Location = new System.Drawing.Point(97, 15);
            this.pictureBoxCoin2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxCoin2.Name = "pictureBoxCoin2";
            this.pictureBoxCoin2.Size = new System.Drawing.Size(71, 62);
            this.pictureBoxCoin2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCoin2.TabIndex = 3;
            this.pictureBoxCoin2.TabStop = false;
            this.pictureBoxCoin2.Click += new System.EventHandler(this.Toss);
            // 
            // pictureBoxCoin1
            // 
            this.pictureBoxCoin1.Location = new System.Drawing.Point(17, 15);
            this.pictureBoxCoin1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxCoin1.Name = "pictureBoxCoin1";
            this.pictureBoxCoin1.Size = new System.Drawing.Size(71, 62);
            this.pictureBoxCoin1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCoin1.TabIndex = 4;
            this.pictureBoxCoin1.TabStop = false;
            this.pictureBoxCoin1.Click += new System.EventHandler(this.Toss);
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(257, 15);
            this.textBoxResult.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxResult.Multiline = true;
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult.Size = new System.Drawing.Size(300, 299);
            this.textBoxResult.TabIndex = 5;
            this.textBoxResult.TabStop = false;
            // 
            // buttonTossAll
            // 
            this.buttonTossAll.Location = new System.Drawing.Point(17, 84);
            this.buttonTossAll.Margin = new System.Windows.Forms.Padding(4);
            this.buttonTossAll.Name = "buttonTossAll";
            this.buttonTossAll.Size = new System.Drawing.Size(231, 28);
            this.buttonTossAll.TabIndex = 6;
            this.buttonTossAll.Text = "TossAll";
            this.buttonTossAll.UseVisualStyleBackColor = true;
            this.buttonTossAll.Click += new System.EventHandler(this.TossAll);
            // 
            // buttonRestart
            // 
            this.buttonRestart.Location = new System.Drawing.Point(17, 156);
            this.buttonRestart.Margin = new System.Windows.Forms.Padding(4);
            this.buttonRestart.Name = "buttonRestart";
            this.buttonRestart.Size = new System.Drawing.Size(231, 28);
            this.buttonRestart.TabIndex = 7;
            this.buttonRestart.Text = "Restart";
            this.buttonRestart.UseVisualStyleBackColor = true;
            this.buttonRestart.Click += new System.EventHandler(this.Restart);
            // 
            // buttonRecord
            // 
            this.buttonRecord.Location = new System.Drawing.Point(17, 120);
            this.buttonRecord.Margin = new System.Windows.Forms.Padding(4);
            this.buttonRecord.Name = "buttonRecord";
            this.buttonRecord.Size = new System.Drawing.Size(231, 28);
            this.buttonRecord.TabIndex = 8;
            this.buttonRecord.Text = "Record";
            this.buttonRecord.UseVisualStyleBackColor = true;
            this.buttonRecord.Click += new System.EventHandler(this.Record);
            // 
            // textBoxResult2
            // 
            this.textBoxResult2.Location = new System.Drawing.Point(565, 15);
            this.textBoxResult2.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxResult2.Multiline = true;
            this.textBoxResult2.Name = "textBoxResult2";
            this.textBoxResult2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult2.Size = new System.Drawing.Size(300, 295);
            this.textBoxResult2.TabIndex = 9;
            this.textBoxResult2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 323);
            this.Controls.Add(this.textBoxResult2);
            this.Controls.Add(this.buttonRecord);
            this.Controls.Add(this.buttonRestart);
            this.Controls.Add(this.buttonTossAll);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.pictureBoxCoin1);
            this.Controls.Add(this.pictureBoxCoin2);
            this.Controls.Add(this.pictureBoxCoin3);
            this.Controls.Add(this.labelChangedPainting);
            this.Controls.Add(this.labelOriginalPainting);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "Form1";
            this.Text = "ThreeCoinsConsulting";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoin3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoin2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoin1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelChangedPainting;
        private System.Windows.Forms.Label labelOriginalPainting;
        private System.Windows.Forms.PictureBox pictureBoxCoin3;
        private System.Windows.Forms.PictureBox pictureBoxCoin2;
        private System.Windows.Forms.PictureBox pictureBoxCoin1;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Button buttonTossAll;
        private System.Windows.Forms.Button buttonRestart;
        private System.Windows.Forms.Button buttonRecord;
        private System.Windows.Forms.TextBox textBoxResult2;
    }
}

