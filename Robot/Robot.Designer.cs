namespace Robot
{
    partial class Robot
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
            this.PointerDirectionLabel = new System.Windows.Forms.Label();
            this.NorthBtn = new System.Windows.Forms.Button();
            this.SouthBtn = new System.Windows.Forms.Button();
            this.WestBtn = new System.Windows.Forms.Button();
            this.EastBtn = new System.Windows.Forms.Button();
            this.Go1Btn = new System.Windows.Forms.Button();
            this.Go10Btn = new System.Windows.Forms.Button();
            this.PointerLocationLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnExit = new System.Windows.Forms.Button();
            this.DistanceLabel = new System.Windows.Forms.Label();
            this.KeyInfo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PointerDirectionLabel
            // 
            this.PointerDirectionLabel.Font = new System.Drawing.Font("Wingdings", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.PointerDirectionLabel.Location = new System.Drawing.Point(0, 0);
            this.PointerDirectionLabel.Margin = new System.Windows.Forms.Padding(0);
            this.PointerDirectionLabel.MinimumSize = new System.Drawing.Size(200, 200);
            this.PointerDirectionLabel.Name = "PointerDirectionLabel";
            this.PointerDirectionLabel.Size = new System.Drawing.Size(200, 200);
            this.PointerDirectionLabel.TabIndex = 0;
            this.PointerDirectionLabel.Text = "6";
            this.PointerDirectionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NorthBtn
            // 
            this.NorthBtn.Location = new System.Drawing.Point(95, 229);
            this.NorthBtn.Name = "NorthBtn";
            this.NorthBtn.Size = new System.Drawing.Size(25, 25);
            this.NorthBtn.TabIndex = 1;
            this.NorthBtn.Text = "N";
            this.NorthBtn.UseVisualStyleBackColor = true;
            this.NorthBtn.Click += new System.EventHandler(this.NorthBtn_Click);
            // 
            // SouthBtn
            // 
            this.SouthBtn.Location = new System.Drawing.Point(95, 289);
            this.SouthBtn.Name = "SouthBtn";
            this.SouthBtn.Size = new System.Drawing.Size(25, 25);
            this.SouthBtn.TabIndex = 2;
            this.SouthBtn.Text = "S";
            this.SouthBtn.UseVisualStyleBackColor = true;
            this.SouthBtn.Click += new System.EventHandler(this.SouthBtn_Click);
            // 
            // WestBtn
            // 
            this.WestBtn.Location = new System.Drawing.Point(60, 259);
            this.WestBtn.Name = "WestBtn";
            this.WestBtn.Size = new System.Drawing.Size(25, 25);
            this.WestBtn.TabIndex = 3;
            this.WestBtn.Text = "W";
            this.WestBtn.UseVisualStyleBackColor = true;
            this.WestBtn.Click += new System.EventHandler(this.WestBtn_Click);
            // 
            // EastBtn
            // 
            this.EastBtn.Location = new System.Drawing.Point(129, 259);
            this.EastBtn.Name = "EastBtn";
            this.EastBtn.Size = new System.Drawing.Size(25, 25);
            this.EastBtn.TabIndex = 4;
            this.EastBtn.Text = "E";
            this.EastBtn.UseVisualStyleBackColor = true;
            this.EastBtn.Click += new System.EventHandler(this.EastBtn_Click);
            // 
            // Go1Btn
            // 
            this.Go1Btn.Location = new System.Drawing.Point(13, 260);
            this.Go1Btn.Name = "Go1Btn";
            this.Go1Btn.Size = new System.Drawing.Size(41, 24);
            this.Go1Btn.TabIndex = 5;
            this.Go1Btn.Text = "Go 1";
            this.Go1Btn.UseVisualStyleBackColor = true;
            this.Go1Btn.Click += new System.EventHandler(this.Go1Btn_Click);
            // 
            // Go10Btn
            // 
            this.Go10Btn.Location = new System.Drawing.Point(160, 260);
            this.Go10Btn.Name = "Go10Btn";
            this.Go10Btn.Size = new System.Drawing.Size(50, 24);
            this.Go10Btn.TabIndex = 6;
            this.Go10Btn.Text = "Go 10";
            this.Go10Btn.UseVisualStyleBackColor = true;
            this.Go10Btn.Click += new System.EventHandler(this.Go10Btn_Click);
            // 
            // PointerLocationLabel
            // 
            this.PointerLocationLabel.AutoSize = true;
            this.PointerLocationLabel.Location = new System.Drawing.Point(10, 9);
            this.PointerLocationLabel.Name = "PointerLocationLabel";
            this.PointerLocationLabel.Size = new System.Drawing.Size(59, 13);
            this.PointerLocationLabel.TabIndex = 7;
            this.PointerLocationLabel.Text = "{X=0, Y=0}";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.PointerDirectionLabel);
            this.panel1.Location = new System.Drawing.Point(8, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 200);
            this.panel1.TabIndex = 8;
            // 
            // BtnExit
            // 
            this.BtnExit.Location = new System.Drawing.Point(145, 305);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(75, 23);
            this.BtnExit.TabIndex = 9;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // DistanceLabel
            // 
            this.DistanceLabel.AutoSize = true;
            this.DistanceLabel.Location = new System.Drawing.Point(126, 9);
            this.DistanceLabel.Name = "DistanceLabel";
            this.DistanceLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DistanceLabel.Size = new System.Drawing.Size(0, 13);
            this.DistanceLabel.TabIndex = 10;
            // 
            // KeyInfo
            // 
            this.KeyInfo.AutoSize = true;
            this.KeyInfo.Font = new System.Drawing.Font("Microsoft YaHei", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyInfo.Location = new System.Drawing.Point(6, 283);
            this.KeyInfo.Name = "KeyInfo";
            this.KeyInfo.Size = new System.Drawing.Size(49, 11);
            this.KeyInfo.TabIndex = 11;
            this.KeyInfo.Text = "Key Codes:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 292);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 11);
            this.label1.TabIndex = 12;
            this.label1.Text = "North : N, South : S";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 301);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 11);
            this.label2.TabIndex = 13;
            this.label2.Text = "West : W, East : E";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 310);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 11);
            this.label3.TabIndex = 14;
            this.label3.Text = "Go 1 : 1, Go 10 : 0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 319);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 11);
            this.label4.TabIndex = 15;
            this.label4.Text = "Exit : Back, Escape";
            // 
            // Robot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(221, 331);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.KeyInfo);
            this.Controls.Add(this.DistanceLabel);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PointerLocationLabel);
            this.Controls.Add(this.Go10Btn);
            this.Controls.Add(this.Go1Btn);
            this.Controls.Add(this.EastBtn);
            this.Controls.Add(this.WestBtn);
            this.Controls.Add(this.SouthBtn);
            this.Controls.Add(this.NorthBtn);
            this.KeyPreview = true;
            this.Name = "Robot";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Robot";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Robot_KeyDown);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PointerDirectionLabel;
        private System.Windows.Forms.Button NorthBtn;
        private System.Windows.Forms.Button SouthBtn;
        private System.Windows.Forms.Button WestBtn;
        private System.Windows.Forms.Button EastBtn;
        private System.Windows.Forms.Button Go1Btn;
        private System.Windows.Forms.Button Go10Btn;
        private System.Windows.Forms.Label PointerLocationLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Label DistanceLabel;
        private System.Windows.Forms.Label KeyInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}