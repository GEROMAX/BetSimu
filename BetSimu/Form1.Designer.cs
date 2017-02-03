namespace BetSimu
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCalc = new System.Windows.Forms.Button();
            this.nudStartValue = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nudLimit = new System.Windows.Forms.NumericUpDown();
            this.nudTryTime = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblGet = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblRate = new System.Windows.Forms.Label();
            this.grdResult = new System.Windows.Forms.DataGridView();
            this.btnLogToggle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudStartValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLimit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTryTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdResult)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(197, 53);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(75, 23);
            this.btnCalc.TabIndex = 0;
            this.btnCalc.Text = "Calc";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // nudStartValue
            // 
            this.nudStartValue.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudStartValue.Location = new System.Drawing.Point(71, 7);
            this.nudStartValue.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudStartValue.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudStartValue.Name = "nudStartValue";
            this.nudStartValue.Size = new System.Drawing.Size(120, 19);
            this.nudStartValue.TabIndex = 1;
            this.nudStartValue.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "開始額";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "上限額";
            // 
            // nudLimit
            // 
            this.nudLimit.Increment = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudLimit.Location = new System.Drawing.Point(71, 32);
            this.nudLimit.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.nudLimit.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudLimit.Name = "nudLimit";
            this.nudLimit.Size = new System.Drawing.Size(120, 19);
            this.nudLimit.TabIndex = 4;
            this.nudLimit.Value = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            // 
            // nudTryTime
            // 
            this.nudTryTime.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudTryTime.Location = new System.Drawing.Point(71, 57);
            this.nudTryTime.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudTryTime.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudTryTime.Name = "nudTryTime";
            this.nudTryTime.Size = new System.Drawing.Size(120, 19);
            this.nudTryTime.TabIndex = 5;
            this.nudTryTime.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "試行回数";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "累計投入額";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(119, 152);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(11, 12);
            this.lblTotal.TabIndex = 8;
            this.lblTotal.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "回収額";
            // 
            // lblGet
            // 
            this.lblGet.AutoSize = true;
            this.lblGet.Location = new System.Drawing.Point(119, 178);
            this.lblGet.Name = "lblGet";
            this.lblGet.Size = new System.Drawing.Size(11, 12);
            this.lblGet.TabIndex = 10;
            this.lblGet.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 11;
            this.label6.Text = "回収率";
            // 
            // lblRate
            // 
            this.lblRate.AutoSize = true;
            this.lblRate.Location = new System.Drawing.Point(119, 202);
            this.lblRate.Name = "lblRate";
            this.lblRate.Size = new System.Drawing.Size(11, 12);
            this.lblRate.TabIndex = 12;
            this.lblRate.Text = "0";
            // 
            // grdResult
            // 
            this.grdResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdResult.Location = new System.Drawing.Point(300, 7);
            this.grdResult.Name = "grdResult";
            this.grdResult.RowTemplate.Height = 21;
            this.grdResult.Size = new System.Drawing.Size(669, 243);
            this.grdResult.TabIndex = 13;
            // 
            // btnLogToggle
            // 
            this.btnLogToggle.Location = new System.Drawing.Point(197, 227);
            this.btnLogToggle.Name = "btnLogToggle";
            this.btnLogToggle.Size = new System.Drawing.Size(75, 23);
            this.btnLogToggle.TabIndex = 14;
            this.btnLogToggle.Text = "経過表示";
            this.btnLogToggle.UseVisualStyleBackColor = true;
            this.btnLogToggle.Click += new System.EventHandler(this.btnLogToggle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 262);
            this.Controls.Add(this.btnLogToggle);
            this.Controls.Add(this.grdResult);
            this.Controls.Add(this.lblRate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblGet);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nudTryTime);
            this.Controls.Add(this.nudLimit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudStartValue);
            this.Controls.Add(this.btnCalc);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nudStartValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLimit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTryTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.NumericUpDown nudStartValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudLimit;
        private System.Windows.Forms.NumericUpDown nudTryTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblGet;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblRate;
        private System.Windows.Forms.DataGridView grdResult;
        private System.Windows.Forms.Button btnLogToggle;
    }
}

