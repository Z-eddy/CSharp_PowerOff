
namespace PowerOff
{
    partial class ZrPowerOff
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
            this.powerOff = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.numHour = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.numMin = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numSecond = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSecond)).BeginInit();
            this.SuspendLayout();
            // 
            // powerOff
            // 
            this.powerOff.Location = new System.Drawing.Point(15, 92);
            this.powerOff.Name = "powerOff";
            this.powerOff.Size = new System.Drawing.Size(75, 23);
            this.powerOff.TabIndex = 0;
            this.powerOff.Text = "关机";
            this.powerOff.UseVisualStyleBackColor = true;
            this.powerOff.Click += new System.EventHandler(this.powerOff_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(112, 92);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 23);
            this.cancel.TabIndex = 0;
            this.cancel.Text = "取消关机";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // numHour
            // 
            this.numHour.Location = new System.Drawing.Point(51, 11);
            this.numHour.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.numHour.Name = "numHour";
            this.numHour.Size = new System.Drawing.Size(120, 21);
            this.numHour.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "时";
            // 
            // numMin
            // 
            this.numMin.Location = new System.Drawing.Point(51, 38);
            this.numMin.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.numMin.Name = "numMin";
            this.numMin.Size = new System.Drawing.Size(120, 21);
            this.numMin.TabIndex = 1;
            this.numMin.Value = new decimal(new int[] {
            35,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "分";
            // 
            // numSecond
            // 
            this.numSecond.Location = new System.Drawing.Point(51, 65);
            this.numSecond.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.numSecond.Name = "numSecond";
            this.numSecond.Size = new System.Drawing.Size(120, 21);
            this.numSecond.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "秒";
            // 
            // ZrPowerOff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(210, 125);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numSecond);
            this.Controls.Add(this.numMin);
            this.Controls.Add(this.numHour);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.powerOff);
            this.Name = "ZrPowerOff";
            this.Text = "ZrPowerOff";
            ((System.ComponentModel.ISupportInitialize)(this.numHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSecond)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button powerOff;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.NumericUpDown numHour;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numMin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numSecond;
        private System.Windows.Forms.Label label3;
    }
}

