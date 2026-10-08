namespace Tutorial2_4
{
    partial class FinlandPictureBox
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.FinlanPictureBox = new System.Windows.Forms.PictureBox();
            this.francePictureBox = new System.Windows.Forms.PictureBox();
            this.germanPictureBox = new System.Windows.Forms.PictureBox();
            this.countryLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.FinlanPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.francePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.germanPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // FinlanPictureBox
            // 
            this.FinlanPictureBox.AccessibleName = "";
            this.FinlanPictureBox.Image = global::Tutorial2_4.Properties.Resources.Finland;
            this.FinlanPictureBox.Location = new System.Drawing.Point(21, 123);
            this.FinlanPictureBox.Name = "FinlanPictureBox";
            this.FinlanPictureBox.Size = new System.Drawing.Size(216, 130);
            this.FinlanPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FinlanPictureBox.TabIndex = 0;
            this.FinlanPictureBox.TabStop = false;
            this.FinlanPictureBox.Click += new System.EventHandler(this.芬蘭_Click);
            // 
            // francePictureBox
            // 
            this.francePictureBox.Image = global::Tutorial2_4.Properties.Resources.France;
            this.francePictureBox.Location = new System.Drawing.Point(266, 123);
            this.francePictureBox.Name = "francePictureBox";
            this.francePictureBox.Size = new System.Drawing.Size(210, 130);
            this.francePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.francePictureBox.TabIndex = 1;
            this.francePictureBox.TabStop = false;
            this.francePictureBox.Click += new System.EventHandler(this.法國_Click);
            // 
            // germanPictureBox
            // 
            this.germanPictureBox.Image = global::Tutorial2_4.Properties.Resources.Germany;
            this.germanPictureBox.Location = new System.Drawing.Point(516, 123);
            this.germanPictureBox.Name = "germanPictureBox";
            this.germanPictureBox.Size = new System.Drawing.Size(225, 130);
            this.germanPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.germanPictureBox.TabIndex = 2;
            this.germanPictureBox.TabStop = false;
            this.germanPictureBox.Click += new System.EventHandler(this.germanPictureBox_Click);
            // 
            // countryLabel
            // 
            this.countryLabel.AutoSize = true;
            this.countryLabel.Font = new System.Drawing.Font("標楷體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.countryLabel.Location = new System.Drawing.Point(157, 39);
            this.countryLabel.Name = "countryLabel";
            this.countryLabel.Size = new System.Drawing.Size(432, 28);
            this.countryLabel.TabIndex = 3;
            this.countryLabel.Text = "點選一個國旗，告訴你是哪個國家";
            this.countryLabel.Click += new System.EventHandler(this.countryLabel_Click);
            // 
            // FinlandPictureBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 499);
            this.Controls.Add(this.countryLabel);
            this.Controls.Add(this.germanPictureBox);
            this.Controls.Add(this.francePictureBox);
            this.Controls.Add(this.FinlanPictureBox);
            this.Name = "FinlandPictureBox";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FinlanPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.francePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.germanPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox FinlanPictureBox;
        private System.Windows.Forms.PictureBox francePictureBox;
        private System.Windows.Forms.PictureBox germanPictureBox;
        private System.Windows.Forms.Label countryLabel;
    }
}

