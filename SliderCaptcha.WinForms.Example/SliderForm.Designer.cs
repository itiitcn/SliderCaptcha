namespace SliderCaptcha.WinForms.Example
{
    partial class SliderForm
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.pb2 = new System.Windows.Forms.PictureBox();
            this.pb1 = new System.Windows.Forms.PictureBox();
            this.lblbox = new System.Windows.Forms.Label();
            this.lblSlider = new System.Windows.Forms.Label();
            this.lblRefresh = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            this.SuspendLayout();
            // 
            // pb2
            // 
            this.pb2.BackColor = System.Drawing.Color.Transparent;
            this.pb2.Location = new System.Drawing.Point(12, 12);
            this.pb2.Name = "pb2";
            this.pb2.Size = new System.Drawing.Size(51, 155);
            this.pb2.TabIndex = 2;
            this.pb2.TabStop = false;
            // 
            // pb1
            // 
            this.pb1.BackColor = System.Drawing.SystemColors.Control;
            this.pb1.Location = new System.Drawing.Point(12, 12);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(280, 155);
            this.pb1.TabIndex = 1;
            this.pb1.TabStop = false;
            // 
            // lblbox
            // 
            this.lblbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblbox.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.lblbox.Location = new System.Drawing.Point(12, 182);
            this.lblbox.Name = "lblbox";
            this.lblbox.Size = new System.Drawing.Size(280, 40);
            this.lblbox.TabIndex = 3;
            this.lblbox.Text = "向右拖动滑块填充拼图";
            this.lblbox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSlider
            // 
            this.lblSlider.BackColor = System.Drawing.Color.White;
            this.lblSlider.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSlider.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblSlider.ForeColor = System.Drawing.Color.Black;
            this.lblSlider.Location = new System.Drawing.Point(12, 182);
            this.lblSlider.Name = "lblSlider";
            this.lblSlider.Size = new System.Drawing.Size(40, 40);
            this.lblSlider.TabIndex = 4;
            this.lblSlider.Text = "➞";
            this.lblSlider.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSlider.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblSlider_MouseDown);
            this.lblSlider.MouseLeave += new System.EventHandler(this.lblSlider_MouseLeave);
            this.lblSlider.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblSlider_MouseMove);
            this.lblSlider.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lblSlider_MouseUp);
            // 
            // lblRefresh
            // 
            this.lblRefresh.BackColor = System.Drawing.Color.Transparent;
            this.lblRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblRefresh.Font = new System.Drawing.Font("微软雅黑", 16F, System.Drawing.FontStyle.Bold);
            this.lblRefresh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.lblRefresh.Location = new System.Drawing.Point(259, 15);
            this.lblRefresh.Name = "lblRefresh";
            this.lblRefresh.Size = new System.Drawing.Size(30, 30);
            this.lblRefresh.TabIndex = 5;
            this.lblRefresh.Text = "↻";
            this.lblRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblRefresh.Click += new System.EventHandler(this.lblRefresh_Click);
            // 
            // lblArea
            // 
            this.lblArea.BackColor = System.Drawing.Color.White;
            this.lblArea.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblArea.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblArea.ForeColor = System.Drawing.Color.Black;
            this.lblArea.Location = new System.Drawing.Point(298, 182);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(10, 40);
            this.lblArea.TabIndex = 6;
            this.lblArea.Tag = "0";
            this.lblArea.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblArea.Paint += new System.Windows.Forms.PaintEventHandler(this.lblArea_Paint);
            // 
            // SliderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 232);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.lblRefresh);
            this.Controls.Add(this.lblSlider);
            this.Controls.Add(this.lblbox);
            this.Controls.Add(this.pb2);
            this.Controls.Add(this.pb1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "SliderForm";
            this.Text = "验证码";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pb1;
        private System.Windows.Forms.PictureBox pb2;
        private System.Windows.Forms.Label lblbox;
        private System.Windows.Forms.Label lblSlider;
        private System.Windows.Forms.Label lblRefresh;
        private System.Windows.Forms.Label lblArea;
    }
}

