namespace SSCOM
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnSetSP = new System.Windows.Forms.Button();
            this.btnSwitchSP = new System.Windows.Forms.Button();
            this.txtSend = new System.Windows.Forms.TextBox();
            this.btnSendData = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.textCode = new System.Windows.Forms.TextBox();
            this.SetCode = new System.Windows.Forms.Button();
            this.textip = new System.Windows.Forms.TextBox();
            this.SetIP = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSetSP
            // 
            this.btnSetSP.Location = new System.Drawing.Point(12, 14);
            this.btnSetSP.Name = "btnSetSP";
            this.btnSetSP.Size = new System.Drawing.Size(75, 23);
            this.btnSetSP.TabIndex = 0;
            this.btnSetSP.Text = "设置串口";
            this.btnSetSP.UseVisualStyleBackColor = true;
            this.btnSetSP.Click += new System.EventHandler(this.btnSetSP_Click);
            // 
            // btnSwitchSP
            // 
            this.btnSwitchSP.Location = new System.Drawing.Point(12, 73);
            this.btnSwitchSP.Name = "btnSwitchSP";
            this.btnSwitchSP.Size = new System.Drawing.Size(75, 23);
            this.btnSwitchSP.TabIndex = 1;
            this.btnSwitchSP.Text = "打开串口";
            this.btnSwitchSP.UseVisualStyleBackColor = true;
            this.btnSwitchSP.Click += new System.EventHandler(this.btnSwitchSP_Click);
            // 
            // txtSend
            // 
            this.txtSend.Location = new System.Drawing.Point(102, 14);
            this.txtSend.Name = "txtSend";
            this.txtSend.Size = new System.Drawing.Size(101, 21);
            this.txtSend.TabIndex = 2;
            this.txtSend.Text = "0";
            // 
            // btnSendData
            // 
            this.btnSendData.Location = new System.Drawing.Point(227, 14);
            this.btnSendData.Name = "btnSendData";
            this.btnSendData.Size = new System.Drawing.Size(75, 23);
            this.btnSendData.TabIndex = 3;
            this.btnSendData.Text = "正转";
            this.btnSendData.UseVisualStyleBackColor = true;
            this.btnSendData.Click += new System.EventHandler(this.btnSendData_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(30, 171);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(250, 86);
            this.textBox1.TabIndex = 4;
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "状态信息";
            // 
            // textCode
            // 
            this.textCode.Location = new System.Drawing.Point(102, 45);
            this.textCode.Name = "textCode";
            this.textCode.Size = new System.Drawing.Size(101, 21);
            this.textCode.TabIndex = 6;
            this.textCode.Text = "0";
            // 
            // SetCode
            // 
            this.SetCode.Location = new System.Drawing.Point(227, 43);
            this.SetCode.Name = "SetCode";
            this.SetCode.Size = new System.Drawing.Size(75, 23);
            this.SetCode.TabIndex = 7;
            this.SetCode.Text = "反转";
            this.SetCode.UseVisualStyleBackColor = true;
            this.SetCode.Click += new System.EventHandler(this.SetCode_Click);
            // 
            // textip
            // 
            this.textip.Location = new System.Drawing.Point(102, 75);
            this.textip.Name = "textip";
            this.textip.Size = new System.Drawing.Size(101, 21);
            this.textip.TabIndex = 8;
            this.textip.Text = "10";
            // 
            // SetIP
            // 
            this.SetIP.Location = new System.Drawing.Point(227, 73);
            this.SetIP.Name = "SetIP";
            this.SetIP.Size = new System.Drawing.Size(75, 23);
            this.SetIP.TabIndex = 9;
            this.SetIP.Text = "速度";
            this.SetIP.UseVisualStyleBackColor = true;
            this.SetIP.Click += new System.EventHandler(this.SetIP_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 10;
            this.label2.Text = "当前位置：";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(102, 109);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 21);
            this.textBox2.TabIndex = 11;
            this.textBox2.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 269);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SetIP);
            this.Controls.Add(this.textip);
            this.Controls.Add(this.SetCode);
            this.Controls.Add(this.textCode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnSendData);
            this.Controls.Add(this.txtSend);
            this.Controls.Add(this.btnSwitchSP);
            this.Controls.Add(this.btnSetSP);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "偏振控制器";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSetSP;
        private System.Windows.Forms.Button btnSwitchSP;
        private System.Windows.Forms.TextBox txtSend;
        private System.Windows.Forms.Button btnSendData;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textCode;
        private System.Windows.Forms.Button SetCode;
        private System.Windows.Forms.TextBox textip;
        private System.Windows.Forms.Button SetIP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
    }
}

