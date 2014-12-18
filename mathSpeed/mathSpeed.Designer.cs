namespace mathSpeed
{
    partial class mathSpeed
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tbAnswer = new System.Windows.Forms.TextBox();
            this.lblTest = new System.Windows.Forms.Label();
            this.butStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tiCount = new System.Windows.Forms.Timer(this.components);
            this.lblInstru = new System.Windows.Forms.Label();
            this.lblRecord = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbAnswer
            // 
            this.tbAnswer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbAnswer.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbAnswer.Location = new System.Drawing.Point(150, 59);
            this.tbAnswer.Name = "tbAnswer";
            this.tbAnswer.Size = new System.Drawing.Size(123, 35);
            this.tbAnswer.TabIndex = 0;
            this.tbAnswer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbAnswer_KeyDown);
            // 
            // lblTest
            // 
            this.lblTest.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTest.AutoEllipsis = true;
            this.lblTest.AutoSize = true;
            this.lblTest.Font = new System.Drawing.Font("Verdana Ref", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTest.Location = new System.Drawing.Point(114, 25);
            this.lblTest.Name = "lblTest";
            this.lblTest.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTest.Size = new System.Drawing.Size(194, 31);
            this.lblTest.TabIndex = 1;
            this.lblTest.Text = "Are you ready?";
            this.lblTest.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblTest.Click += new System.EventHandler(this.lblTest_Click);
            // 
            // butStart
            // 
            this.butStart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.butStart.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butStart.Location = new System.Drawing.Point(95, 179);
            this.butStart.Name = "butStart";
            this.butStart.Size = new System.Drawing.Size(126, 62);
            this.butStart.TabIndex = 2;
            this.butStart.Text = "START";
            this.butStart.UseVisualStyleBackColor = true;
            this.butStart.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana Ref", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(274, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "SCORE";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tiCount
            // 
            this.tiCount.Interval = 1000;
            this.tiCount.Tick += new System.EventHandler(this.tiCount_Tick);
            // 
            // lblInstru
            // 
            this.lblInstru.AutoSize = true;
            this.lblInstru.Font = new System.Drawing.Font("黑体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblInstru.Location = new System.Drawing.Point(151, 124);
            this.lblInstru.Name = "lblInstru";
            this.lblInstru.Size = new System.Drawing.Size(0, 21);
            this.lblInstru.TabIndex = 4;
            // 
            // lblRecord
            // 
            this.lblRecord.AutoSize = true;
            this.lblRecord.Font = new System.Drawing.Font("Verdana Ref", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecord.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblRecord.Location = new System.Drawing.Point(287, 247);
            this.lblRecord.Name = "lblRecord";
            this.lblRecord.Size = new System.Drawing.Size(119, 21);
            this.lblRecord.TabIndex = 5;
            this.lblRecord.Text = "Your Record";
            this.lblRecord.Click += new System.EventHandler(this.lblRecord_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(301, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "Your Record";
            // 
            // mathSpeed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(432, 280);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblRecord);
            this.Controls.Add(this.lblInstru);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.butStart);
            this.Controls.Add(this.lblTest);
            this.Controls.Add(this.tbAnswer);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "mathSpeed";
            this.Text = "mathSpeed";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mathSpeed_FormClosing);
            this.Load += new System.EventHandler(this.mathSpeed_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbAnswer;
        private System.Windows.Forms.Label lblTest;
        private System.Windows.Forms.Button butStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer tiCount;
        private System.Windows.Forms.Label lblInstru;
        private System.Windows.Forms.Label lblRecord;
        private System.Windows.Forms.Label label2;
    }
}

