namespace EasyChecker
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
            this.textBoxURL = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelPingCheck = new System.Windows.Forms.Label();
            this.panel1dot = new System.Windows.Forms.TableLayoutPanel();
            this.label1Dot = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelIP1dot = new System.Windows.Forms.Label();
            this.panelLocalDNS = new System.Windows.Forms.TableLayoutPanel();
            this.labelLocal = new System.Windows.Forms.Label();
            this.labelIPLocal = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelDnsCheck = new System.Windows.Forms.Label();
            this.labelPingTimeOut = new System.Windows.Forms.Label();
            this.labelTCPingCheck = new System.Windows.Forms.Label();
            this.labelTCPingTimeOut = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1dot.SuspendLayout();
            this.panelLocalDNS.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxURL
            // 
            this.textBoxURL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxURL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxURL.Location = new System.Drawing.Point(15, 17);
            this.textBoxURL.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxURL.Name = "textBoxURL";
            this.textBoxURL.Size = new System.Drawing.Size(462, 27);
            this.textBoxURL.TabIndex = 0;
            this.textBoxURL.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxURL_KeyDown);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.58621F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.41379F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 175F));
            this.tableLayoutPanel1.Controls.Add(this.labelPingCheck, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1dot, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.panelLocalDNS, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelDnsCheck, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelPingTimeOut, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelTCPingCheck, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelTCPingTimeOut, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(15, 52);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 59.15493F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.84507F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 69F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 290F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(462, 502);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // labelPingCheck
            // 
            this.labelPingCheck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPingCheck.AutoSize = true;
            this.labelPingCheck.Location = new System.Drawing.Point(3, 103);
            this.labelPingCheck.Name = "labelPingCheck";
            this.labelPingCheck.Size = new System.Drawing.Size(101, 20);
            this.labelPingCheck.TabIndex = 5;
            this.labelPingCheck.Text = "Ping查询";
            this.labelPingCheck.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1dot
            // 
            this.panel1dot.ColumnCount = 1;
            this.panel1dot.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panel1dot.Controls.Add(this.label1Dot, 0, 2);
            this.panel1dot.Controls.Add(this.label3, 0, 0);
            this.panel1dot.Controls.Add(this.labelIP1dot, 0, 1);
            this.panel1dot.Location = new System.Drawing.Point(289, 3);
            this.panel1dot.Name = "panel1dot";
            this.panel1dot.RowCount = 3;
            this.panel1dot.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.05128F));
            this.panel1dot.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.05128F));
            this.panel1dot.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.panel1dot.Size = new System.Drawing.Size(166, 78);
            this.panel1dot.TabIndex = 3;
            this.panel1dot.Visible = false;
            // 
            // label1Dot
            // 
            this.label1Dot.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1Dot.AutoSize = true;
            this.label1Dot.Location = new System.Drawing.Point(3, 54);
            this.label1Dot.Name = "label1Dot";
            this.label1Dot.Size = new System.Drawing.Size(160, 20);
            this.label1Dot.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "远端DNS";
            // 
            // labelIP1dot
            // 
            this.labelIP1dot.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelIP1dot.AutoSize = true;
            this.labelIP1dot.Location = new System.Drawing.Point(3, 27);
            this.labelIP1dot.Name = "labelIP1dot";
            this.labelIP1dot.Size = new System.Drawing.Size(160, 20);
            this.labelIP1dot.TabIndex = 2;
            this.labelIP1dot.Text = "0.0.0.0";
            // 
            // panelLocalDNS
            // 
            this.panelLocalDNS.ColumnCount = 1;
            this.panelLocalDNS.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panelLocalDNS.Controls.Add(this.labelLocal, 0, 2);
            this.panelLocalDNS.Controls.Add(this.labelIPLocal, 0, 1);
            this.panelLocalDNS.Controls.Add(this.label2, 0, 0);
            this.panelLocalDNS.Location = new System.Drawing.Point(110, 3);
            this.panelLocalDNS.Name = "panelLocalDNS";
            this.panelLocalDNS.RowCount = 3;
            this.panelLocalDNS.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.05128F));
            this.panelLocalDNS.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.05128F));
            this.panelLocalDNS.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.panelLocalDNS.Size = new System.Drawing.Size(173, 78);
            this.panelLocalDNS.TabIndex = 2;
            this.panelLocalDNS.Visible = false;
            // 
            // labelLocal
            // 
            this.labelLocal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelLocal.AutoSize = true;
            this.labelLocal.Location = new System.Drawing.Point(3, 54);
            this.labelLocal.Name = "labelLocal";
            this.labelLocal.Size = new System.Drawing.Size(167, 20);
            this.labelLocal.TabIndex = 2;
            // 
            // labelIPLocal
            // 
            this.labelIPLocal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelIPLocal.AutoSize = true;
            this.labelIPLocal.Location = new System.Drawing.Point(3, 27);
            this.labelIPLocal.Name = "labelIPLocal";
            this.labelIPLocal.Size = new System.Drawing.Size(167, 20);
            this.labelIPLocal.TabIndex = 1;
            this.labelIPLocal.Text = "0.0.0.0";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "本地DNS";
            // 
            // labelDnsCheck
            // 
            this.labelDnsCheck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDnsCheck.AutoSize = true;
            this.labelDnsCheck.Location = new System.Drawing.Point(3, 32);
            this.labelDnsCheck.Name = "labelDnsCheck";
            this.labelDnsCheck.Size = new System.Drawing.Size(101, 20);
            this.labelDnsCheck.TabIndex = 0;
            this.labelDnsCheck.Text = "DNS查询";
            this.labelDnsCheck.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPingTimeOut
            // 
            this.labelPingTimeOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPingTimeOut.AutoSize = true;
            this.labelPingTimeOut.Location = new System.Drawing.Point(110, 103);
            this.labelPingTimeOut.Name = "labelPingTimeOut";
            this.labelPingTimeOut.Size = new System.Drawing.Size(173, 20);
            this.labelPingTimeOut.TabIndex = 4;
            // 
            // labelTCPingCheck
            // 
            this.labelTCPingCheck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTCPingCheck.AutoSize = true;
            this.labelTCPingCheck.Location = new System.Drawing.Point(3, 166);
            this.labelTCPingCheck.Name = "labelTCPingCheck";
            this.labelTCPingCheck.Size = new System.Drawing.Size(101, 20);
            this.labelTCPingCheck.TabIndex = 6;
            this.labelTCPingCheck.Text = "TCPing查询";
            this.labelTCPingCheck.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTCPingTimeOut
            // 
            this.labelTCPingTimeOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTCPingTimeOut.AutoSize = true;
            this.labelTCPingTimeOut.Location = new System.Drawing.Point(110, 166);
            this.labelTCPingTimeOut.Name = "labelTCPingTimeOut";
            this.labelTCPingTimeOut.Size = new System.Drawing.Size(173, 20);
            this.labelTCPingTimeOut.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 566);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.textBoxURL);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "EasyChecker";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1dot.ResumeLayout(false);
            this.panel1dot.PerformLayout();
            this.panelLocalDNS.ResumeLayout(false);
            this.panelLocalDNS.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxURL;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelDnsCheck;
        private System.Windows.Forms.TableLayoutPanel panel1dot;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelIP1dot;
        private System.Windows.Forms.TableLayoutPanel panelLocalDNS;
        private System.Windows.Forms.Label labelIPLocal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1Dot;
        private System.Windows.Forms.Label labelLocal;
        private System.Windows.Forms.Label labelPingCheck;
        private System.Windows.Forms.Label labelPingTimeOut;
        private System.Windows.Forms.Label labelTCPingCheck;
        private System.Windows.Forms.Label labelTCPingTimeOut;
    }
}

