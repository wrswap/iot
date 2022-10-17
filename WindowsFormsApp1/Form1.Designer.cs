
namespace WindowsFormsApp1
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxTWd = new System.Windows.Forms.TextBox();
            this.TxTSd = new System.Windows.Forms.TextBox();
            this.TxTZq = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.rtbJ1 = new System.Windows.Forms.RichTextBox();
            this.btStart = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(397, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(138, 39);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "发送记录";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "温度";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "水位";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 292);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "发送周期";
            // 
            // TxTWd
            // 
            this.TxTWd.Font = new System.Drawing.Font("微软雅黑 Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TxTWd.Location = new System.Drawing.Point(129, 76);
            this.TxTWd.Name = "TxTWd";
            this.TxTWd.Size = new System.Drawing.Size(155, 27);
            this.TxTWd.TabIndex = 4;
            // 
            // TxTSd
            // 
            this.TxTSd.Location = new System.Drawing.Point(129, 185);
            this.TxTSd.Name = "TxTSd";
            this.TxTSd.Size = new System.Drawing.Size(155, 25);
            this.TxTSd.TabIndex = 5;
            this.TxTSd.TextChanged += new System.EventHandler(this.TxTSd_TextChanged);
            // 
            // TxTZq
            // 
            this.TxTZq.Location = new System.Drawing.Point(129, 282);
            this.TxTZq.Name = "TxTZq";
            this.TxTZq.Size = new System.Drawing.Size(155, 25);
            this.TxTZq.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(290, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "℃";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(290, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "cd";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(290, 285);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "秒";
            // 
            // rtbJ1
            // 
            this.rtbJ1.Location = new System.Drawing.Point(350, 50);
            this.rtbJ1.Name = "rtbJ1";
            this.rtbJ1.Size = new System.Drawing.Size(438, 257);
            this.rtbJ1.TabIndex = 10;
            this.rtbJ1.Text = "";
            this.rtbJ1.TextChanged += new System.EventHandler(this.rtbJ1_TextChanged);
            // 
            // btStart
            // 
            this.btStart.Location = new System.Drawing.Point(129, 376);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(92, 41);
            this.btStart.TabIndex = 12;
            this.btStart.Text = "开始";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btStart);
            this.Controls.Add(this.rtbJ1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxTZq);
            this.Controls.Add(this.TxTSd);
            this.Controls.Add(this.TxTWd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form1";
            this.Text = "物联网终端仿真（3组 王荣帅）";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxTWd;
        private System.Windows.Forms.TextBox TxTSd;
        private System.Windows.Forms.TextBox TxTZq;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox rtbJ1;
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.Timer timer1;
    }
}

