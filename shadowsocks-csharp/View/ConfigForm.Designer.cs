namespace Shadowsocks.View
{
    partial class ConfigForm
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.picQRcode = new System.Windows.Forms.PictureBox();
            this.lstServers = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.ServerGroupBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cmbObfs = new System.Windows.Forms.ComboBox();
            this.lblObfs = new System.Windows.Forms.Label();
            this.lblServerPort = new System.Windows.Forms.Label();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.nudServerPort = new System.Windows.Forms.NumericUpDown();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblEncryption = new System.Windows.Forms.Label();
            this.cmbEncryption = new System.Windows.Forms.ComboBox();
            this.txtLink = new System.Windows.Forms.TextBox();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.lblObfsUdp = new System.Windows.Forms.Label();
            this.chkObfsUDP = new System.Windows.Forms.CheckBox();
            this.lblTCPProtocol = new System.Windows.Forms.Label();
            this.lblUdpOverTcp = new System.Windows.Forms.Label();
            this.chkUdpOverTcp = new System.Windows.Forms.CheckBox();
            this.LabelNote = new System.Windows.Forms.Label();
            this.chkPassword = new System.Windows.Forms.CheckBox();
            this.lblTcpOverUdp = new System.Windows.Forms.Label();
            this.chkTcpOverUdp = new System.Windows.Forms.CheckBox();
            this.cmbTcpProtocol = new System.Windows.Forms.ComboBox();
            this.lblObfsParam = new System.Windows.Forms.Label();
            this.txtObfsParam = new System.Windows.Forms.TextBox();
            this.lblGroup = new System.Windows.Forms.Label();
            this.txtGroup = new System.Windows.Forms.TextBox();
            this.chkAdvSetting = new System.Windows.Forms.CheckBox();
            this.lblUDPPort = new System.Windows.Forms.Label();
            this.nudUdpPort = new System.Windows.Forms.NumericUpDown();
            this.chkSSRLink = new System.Windows.Forms.CheckBox();
            this.lblRemarks = new System.Windows.Forms.Label();
            this.lblProtocolParam = new System.Windows.Forms.Label();
            this.txtProtocolParam = new System.Windows.Forms.TextBox();
            this.chkIP = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.llbUpdate = new System.Windows.Forms.LinkLabel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picQRcode)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.ServerGroupBox.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudServerPort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudUdpPort)).BeginInit();
            this.tableLayoutPanel7.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel2.AutoSize = true;
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.Location = new System.Drawing.Point(600, 200);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(0, 0);
            this.panel2.TabIndex = 1;
            // 
            // btnDelete
            // 
            this.btnDelete.AutoSize = true;
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDelete.Location = new System.Drawing.Point(151, 0);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(0);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(151, 42);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.AutoSize = true;
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdd.Location = new System.Drawing.Point(0, 0);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(0);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(151, 42);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // picQRcode
            // 
            this.picQRcode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picQRcode.BackColor = System.Drawing.SystemColors.Control;
            this.picQRcode.Location = new System.Drawing.Point(4, 273);
            this.picQRcode.Margin = new System.Windows.Forms.Padding(4);
            this.picQRcode.Name = "picQRcode";
            this.picQRcode.Size = new System.Drawing.Size(260, 200);
            this.picQRcode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picQRcode.TabIndex = 13;
            this.picQRcode.TabStop = false;
            // 
            // lstServers
            // 
            this.lstServers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstServers.HorizontalScrollbar = true;
            this.lstServers.ItemHeight = 31;
            this.lstServers.Location = new System.Drawing.Point(0, 0);
            this.lstServers.Margin = new System.Windows.Forms.Padding(0);
            this.lstServers.Name = "lstServers";
            this.lstServers.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstServers.Size = new System.Drawing.Size(302, 292);
            this.lstServers.TabIndex = 0;
            this.lstServers.SelectedIndexChanged += new System.EventHandler(this.ServersListBox_SelectedIndexChanged);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.ServerGroupBox, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel7, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel5, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 1, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(12, 13);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1253, 804);
            this.tableLayoutPanel2.TabIndex = 7;
            // 
            // ServerGroupBox
            // 
            this.ServerGroupBox.AutoSize = true;
            this.ServerGroupBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ServerGroupBox.Controls.Add(this.tableLayoutPanel1);
            this.ServerGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ServerGroupBox.Location = new System.Drawing.Point(320, 0);
            this.ServerGroupBox.Margin = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.ServerGroupBox.Name = "ServerGroupBox";
            this.ServerGroupBox.Size = new System.Drawing.Size(650, 753);
            this.ServerGroupBox.TabIndex = 20;
            this.ServerGroupBox.TabStop = false;
            this.ServerGroupBox.Text = "Server";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.cmbObfs, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.lblObfs, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.lblServerPort, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtIP, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.nudServerPort, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtPassword, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblEncryption, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.cmbEncryption, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtLink, 1, 11);
            this.tableLayoutPanel1.Controls.Add(this.txtRemarks, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.lblObfsUdp, 0, 16);
            this.tableLayoutPanel1.Controls.Add(this.chkObfsUDP, 1, 16);
            this.tableLayoutPanel1.Controls.Add(this.lblTCPProtocol, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblUdpOverTcp, 0, 15);
            this.tableLayoutPanel1.Controls.Add(this.chkUdpOverTcp, 1, 15);
            this.tableLayoutPanel1.Controls.Add(this.LabelNote, 1, 12);
            this.tableLayoutPanel1.Controls.Add(this.chkPassword, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblTcpOverUdp, 0, 14);
            this.tableLayoutPanel1.Controls.Add(this.chkTcpOverUdp, 1, 14);
            this.tableLayoutPanel1.Controls.Add(this.cmbTcpProtocol, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblObfsParam, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.txtObfsParam, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.lblGroup, 0, 10);
            this.tableLayoutPanel1.Controls.Add(this.txtGroup, 1, 10);
            this.tableLayoutPanel1.Controls.Add(this.chkAdvSetting, 0, 12);
            this.tableLayoutPanel1.Controls.Add(this.lblUDPPort, 0, 13);
            this.tableLayoutPanel1.Controls.Add(this.nudUdpPort, 1, 13);
            this.tableLayoutPanel1.Controls.Add(this.chkSSRLink, 0, 11);
            this.tableLayoutPanel1.Controls.Add(this.lblRemarks, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.lblProtocolParam, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.txtProtocolParam, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.chkIP, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 34);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(3);
            this.tableLayoutPanel1.RowCount = 18;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(644, 716);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // cmbObfs
            // 
            this.cmbObfs.Dock = System.Windows.Forms.DockStyle.Top;
            this.cmbObfs.FormattingEnabled = true;
            this.cmbObfs.Items.AddRange(new object[] {
            "plain",
            "http_simple",
            "http_post",
            "random_head",
            "tls1.2_ticket_auth",
            "tls1.2_ticket_fastauth"});
            this.cmbObfs.Location = new System.Drawing.Point(219, 282);
            this.cmbObfs.Margin = new System.Windows.Forms.Padding(3, 3, 3, 8);
            this.cmbObfs.Name = "cmbObfs";
            this.cmbObfs.Size = new System.Drawing.Size(419, 39);
            this.cmbObfs.TabIndex = 19;
            this.cmbObfs.TextChanged += new System.EventHandler(this.ObfsCombo_TextChanged);
            // 
            // lblObfs
            // 
            this.lblObfs.AutoSize = true;
            this.lblObfs.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblObfs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblObfs.Location = new System.Drawing.Point(6, 282);
            this.lblObfs.Margin = new System.Windows.Forms.Padding(3);
            this.lblObfs.Name = "lblObfs";
            this.lblObfs.Size = new System.Drawing.Size(207, 32);
            this.lblObfs.TabIndex = 18;
            this.lblObfs.Text = "Obfs";
            this.lblObfs.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblServerPort
            // 
            this.lblServerPort.AutoSize = true;
            this.lblServerPort.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblServerPort.Location = new System.Drawing.Point(6, 50);
            this.lblServerPort.Margin = new System.Windows.Forms.Padding(3);
            this.lblServerPort.Name = "lblServerPort";
            this.lblServerPort.Size = new System.Drawing.Size(207, 32);
            this.lblServerPort.TabIndex = 8;
            this.lblServerPort.Text = "Server Port";
            this.lblServerPort.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtIP
            // 
            this.txtIP.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtIP.Location = new System.Drawing.Point(219, 6);
            this.txtIP.MaxLength = 512;
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(419, 38);
            this.txtIP.TabIndex = 7;
            this.txtIP.UseSystemPasswordChar = true;
            this.txtIP.WordWrap = false;
            // 
            // nudServerPort
            // 
            this.nudServerPort.Dock = System.Windows.Forms.DockStyle.Top;
            this.nudServerPort.Location = new System.Drawing.Point(219, 50);
            this.nudServerPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.nudServerPort.Name = "nudServerPort";
            this.nudServerPort.Size = new System.Drawing.Size(419, 38);
            this.nudServerPort.TabIndex = 9;
            // 
            // txtPassword
            // 
            this.txtPassword.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtPassword.Location = new System.Drawing.Point(219, 94);
            this.txtPassword.MaxLength = 256;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(419, 38);
            this.txtPassword.TabIndex = 11;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.WordWrap = false;
            // 
            // lblEncryption
            // 
            this.lblEncryption.AutoSize = true;
            this.lblEncryption.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblEncryption.Location = new System.Drawing.Point(6, 138);
            this.lblEncryption.Margin = new System.Windows.Forms.Padding(3);
            this.lblEncryption.Name = "lblEncryption";
            this.lblEncryption.Size = new System.Drawing.Size(207, 32);
            this.lblEncryption.TabIndex = 12;
            this.lblEncryption.Text = "Encryption";
            this.lblEncryption.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbEncryption
            // 
            this.cmbEncryption.Dock = System.Windows.Forms.DockStyle.Top;
            this.cmbEncryption.FormattingEnabled = true;
            this.cmbEncryption.Location = new System.Drawing.Point(219, 138);
            this.cmbEncryption.Margin = new System.Windows.Forms.Padding(3, 3, 3, 8);
            this.cmbEncryption.Name = "cmbEncryption";
            this.cmbEncryption.Size = new System.Drawing.Size(419, 39);
            this.cmbEncryption.TabIndex = 13;
            // 
            // txtLink
            // 
            this.txtLink.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtLink.Location = new System.Drawing.Point(219, 464);
            this.txtLink.Name = "txtLink";
            this.txtLink.ReadOnly = true;
            this.txtLink.Size = new System.Drawing.Size(419, 38);
            this.txtLink.TabIndex = 27;
            this.txtLink.WordWrap = false;
            this.txtLink.Enter += new System.EventHandler(this.TextBox_Enter);
            this.txtLink.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TextBox_MouseUp);
            // 
            // txtRemarks
            // 
            this.txtRemarks.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtRemarks.Location = new System.Drawing.Point(219, 376);
            this.txtRemarks.MaxLength = 256;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(419, 38);
            this.txtRemarks.TabIndex = 23;
            this.txtRemarks.WordWrap = false;
            // 
            // lblObfsUdp
            // 
            this.lblObfsUdp.AutoSize = true;
            this.lblObfsUdp.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblObfsUdp.Location = new System.Drawing.Point(6, 674);
            this.lblObfsUdp.Margin = new System.Windows.Forms.Padding(3);
            this.lblObfsUdp.Name = "lblObfsUdp";
            this.lblObfsUdp.Size = new System.Drawing.Size(207, 32);
            this.lblObfsUdp.TabIndex = 36;
            this.lblObfsUdp.Text = "Obfs UDP";
            this.lblObfsUdp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblObfsUdp.Visible = false;
            // 
            // chkObfsUDP
            // 
            this.chkObfsUDP.AutoSize = true;
            this.chkObfsUDP.Dock = System.Windows.Forms.DockStyle.Top;
            this.chkObfsUDP.Location = new System.Drawing.Point(219, 674);
            this.chkObfsUDP.Name = "chkObfsUDP";
            this.chkObfsUDP.Size = new System.Drawing.Size(419, 36);
            this.chkObfsUDP.TabIndex = 37;
            this.chkObfsUDP.Text = "Recommend checked";
            this.chkObfsUDP.UseVisualStyleBackColor = true;
            this.chkObfsUDP.Visible = false;
            // 
            // lblTCPProtocol
            // 
            this.lblTCPProtocol.AutoSize = true;
            this.lblTCPProtocol.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTCPProtocol.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblTCPProtocol.Location = new System.Drawing.Point(6, 188);
            this.lblTCPProtocol.Margin = new System.Windows.Forms.Padding(3);
            this.lblTCPProtocol.Name = "lblTCPProtocol";
            this.lblTCPProtocol.Size = new System.Drawing.Size(207, 32);
            this.lblTCPProtocol.TabIndex = 14;
            this.lblTCPProtocol.Text = "Protocol";
            this.lblTCPProtocol.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblUdpOverTcp
            // 
            this.lblUdpOverTcp.AutoSize = true;
            this.lblUdpOverTcp.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblUdpOverTcp.Location = new System.Drawing.Point(6, 632);
            this.lblUdpOverTcp.Margin = new System.Windows.Forms.Padding(3);
            this.lblUdpOverTcp.Name = "lblUdpOverTcp";
            this.lblUdpOverTcp.Size = new System.Drawing.Size(207, 32);
            this.lblUdpOverTcp.TabIndex = 34;
            this.lblUdpOverTcp.Text = "UDP over TCP";
            this.lblUdpOverTcp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblUdpOverTcp.Visible = false;
            // 
            // chkUdpOverTcp
            // 
            this.chkUdpOverTcp.AutoSize = true;
            this.chkUdpOverTcp.Dock = System.Windows.Forms.DockStyle.Top;
            this.chkUdpOverTcp.Location = new System.Drawing.Point(219, 632);
            this.chkUdpOverTcp.Name = "chkUdpOverTcp";
            this.chkUdpOverTcp.Size = new System.Drawing.Size(419, 36);
            this.chkUdpOverTcp.TabIndex = 35;
            this.chkUdpOverTcp.Text = "UDP over TCP if not checked";
            this.chkUdpOverTcp.UseVisualStyleBackColor = true;
            this.chkUdpOverTcp.Visible = false;
            // 
            // LabelNote
            // 
            this.LabelNote.AutoSize = true;
            this.LabelNote.Dock = System.Windows.Forms.DockStyle.Top;
            this.LabelNote.Location = new System.Drawing.Point(216, 508);
            this.LabelNote.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.LabelNote.Name = "LabelNote";
            this.LabelNote.Size = new System.Drawing.Size(422, 32);
            this.LabelNote.TabIndex = 29;
            this.LabelNote.Text = "NOT all server support belows";
            // 
            // chkPassword
            // 
            this.chkPassword.AutoSize = true;
            this.chkPassword.Dock = System.Windows.Forms.DockStyle.Top;
            this.chkPassword.Location = new System.Drawing.Point(3, 91);
            this.chkPassword.Margin = new System.Windows.Forms.Padding(0);
            this.chkPassword.Name = "chkPassword";
            this.chkPassword.Size = new System.Drawing.Size(213, 36);
            this.chkPassword.TabIndex = 10;
            this.chkPassword.Text = "Password";
            this.chkPassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkPassword.UseVisualStyleBackColor = true;
            this.chkPassword.CheckedChanged += new System.EventHandler(this.PasswordLabel_CheckedChanged);
            // 
            // lblTcpOverUdp
            // 
            this.lblTcpOverUdp.AutoSize = true;
            this.lblTcpOverUdp.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTcpOverUdp.Location = new System.Drawing.Point(6, 590);
            this.lblTcpOverUdp.Margin = new System.Windows.Forms.Padding(3);
            this.lblTcpOverUdp.Name = "lblTcpOverUdp";
            this.lblTcpOverUdp.Size = new System.Drawing.Size(207, 32);
            this.lblTcpOverUdp.TabIndex = 32;
            this.lblTcpOverUdp.Text = "TCP over UDP";
            this.lblTcpOverUdp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblTcpOverUdp.Visible = false;
            // 
            // chkTcpOverUdp
            // 
            this.chkTcpOverUdp.AutoSize = true;
            this.chkTcpOverUdp.Dock = System.Windows.Forms.DockStyle.Top;
            this.chkTcpOverUdp.Location = new System.Drawing.Point(219, 590);
            this.chkTcpOverUdp.Name = "chkTcpOverUdp";
            this.chkTcpOverUdp.Size = new System.Drawing.Size(419, 36);
            this.chkTcpOverUdp.TabIndex = 33;
            this.chkTcpOverUdp.Text = "TCP over UDP if not checked";
            this.chkTcpOverUdp.UseVisualStyleBackColor = true;
            this.chkTcpOverUdp.Visible = false;
            // 
            // cmbTcpProtocol
            // 
            this.cmbTcpProtocol.Dock = System.Windows.Forms.DockStyle.Top;
            this.cmbTcpProtocol.FormattingEnabled = true;
            this.cmbTcpProtocol.Items.AddRange(new object[] {
            "origin",
            "verify_deflate",
            "auth_sha1_v4",
            "auth_aes128_md5",
            "auth_aes128_sha1",
            "auth_chain_a",
            "auth_chain_b",
            "auth_chain_c",
            "auth_chain_d",
            "auth_chain_e",
            "auth_chain_f",
            "auth_akarin_rand",
            "auth_akarin_spec_a"});
            this.cmbTcpProtocol.Location = new System.Drawing.Point(219, 188);
            this.cmbTcpProtocol.Margin = new System.Windows.Forms.Padding(3, 3, 3, 8);
            this.cmbTcpProtocol.Name = "cmbTcpProtocol";
            this.cmbTcpProtocol.Size = new System.Drawing.Size(419, 39);
            this.cmbTcpProtocol.TabIndex = 15;
            // 
            // lblObfsParam
            // 
            this.lblObfsParam.AutoSize = true;
            this.lblObfsParam.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblObfsParam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblObfsParam.Location = new System.Drawing.Point(6, 332);
            this.lblObfsParam.Margin = new System.Windows.Forms.Padding(3);
            this.lblObfsParam.Name = "lblObfsParam";
            this.lblObfsParam.Size = new System.Drawing.Size(207, 32);
            this.lblObfsParam.TabIndex = 20;
            this.lblObfsParam.Text = "Obfs param";
            this.lblObfsParam.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtObfsParam
            // 
            this.txtObfsParam.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtObfsParam.Location = new System.Drawing.Point(219, 332);
            this.txtObfsParam.Name = "txtObfsParam";
            this.txtObfsParam.Size = new System.Drawing.Size(419, 38);
            this.txtObfsParam.TabIndex = 21;
            // 
            // lblGroup
            // 
            this.lblGroup.AutoSize = true;
            this.lblGroup.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblGroup.Location = new System.Drawing.Point(6, 420);
            this.lblGroup.Margin = new System.Windows.Forms.Padding(3);
            this.lblGroup.Name = "lblGroup";
            this.lblGroup.Size = new System.Drawing.Size(207, 32);
            this.lblGroup.TabIndex = 24;
            this.lblGroup.Text = "Group";
            this.lblGroup.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtGroup
            // 
            this.txtGroup.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtGroup.Location = new System.Drawing.Point(219, 420);
            this.txtGroup.MaxLength = 64;
            this.txtGroup.Name = "txtGroup";
            this.txtGroup.Size = new System.Drawing.Size(419, 38);
            this.txtGroup.TabIndex = 25;
            this.txtGroup.WordWrap = false;
            // 
            // chkAdvSetting
            // 
            this.chkAdvSetting.AutoSize = true;
            this.chkAdvSetting.Dock = System.Windows.Forms.DockStyle.Top;
            this.chkAdvSetting.Location = new System.Drawing.Point(3, 505);
            this.chkAdvSetting.Margin = new System.Windows.Forms.Padding(0);
            this.chkAdvSetting.Name = "chkAdvSetting";
            this.chkAdvSetting.Size = new System.Drawing.Size(213, 36);
            this.chkAdvSetting.TabIndex = 28;
            this.chkAdvSetting.Text = "Adv. Setting";
            this.chkAdvSetting.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkAdvSetting.UseVisualStyleBackColor = true;
            this.chkAdvSetting.CheckedChanged += new System.EventHandler(this.checkAdvSetting_CheckedChanged);
            // 
            // lblUDPPort
            // 
            this.lblUDPPort.AutoSize = true;
            this.lblUDPPort.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblUDPPort.Location = new System.Drawing.Point(6, 546);
            this.lblUDPPort.Margin = new System.Windows.Forms.Padding(3);
            this.lblUDPPort.Name = "lblUDPPort";
            this.lblUDPPort.Size = new System.Drawing.Size(207, 32);
            this.lblUDPPort.TabIndex = 30;
            this.lblUDPPort.Text = "UDP Port";
            this.lblUDPPort.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblUDPPort.Visible = false;
            // 
            // nudUdpPort
            // 
            this.nudUdpPort.Dock = System.Windows.Forms.DockStyle.Top;
            this.nudUdpPort.Location = new System.Drawing.Point(219, 546);
            this.nudUdpPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.nudUdpPort.Name = "nudUdpPort";
            this.nudUdpPort.Size = new System.Drawing.Size(419, 38);
            this.nudUdpPort.TabIndex = 31;
            this.nudUdpPort.Visible = false;
            // 
            // chkSSRLink
            // 
            this.chkSSRLink.AutoSize = true;
            this.chkSSRLink.Checked = true;
            this.chkSSRLink.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSSRLink.Dock = System.Windows.Forms.DockStyle.Top;
            this.chkSSRLink.Location = new System.Drawing.Point(3, 461);
            this.chkSSRLink.Margin = new System.Windows.Forms.Padding(0);
            this.chkSSRLink.Name = "chkSSRLink";
            this.chkSSRLink.Size = new System.Drawing.Size(213, 36);
            this.chkSSRLink.TabIndex = 26;
            this.chkSSRLink.Text = "SSR Link";
            this.chkSSRLink.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkSSRLink.UseVisualStyleBackColor = true;
            this.chkSSRLink.CheckedChanged += new System.EventHandler(this.checkSSRLink_CheckedChanged);
            // 
            // lblRemarks
            // 
            this.lblRemarks.AutoSize = true;
            this.lblRemarks.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblRemarks.Location = new System.Drawing.Point(6, 376);
            this.lblRemarks.Margin = new System.Windows.Forms.Padding(3);
            this.lblRemarks.Name = "lblRemarks";
            this.lblRemarks.Size = new System.Drawing.Size(207, 32);
            this.lblRemarks.TabIndex = 22;
            this.lblRemarks.Text = "Remarks";
            this.lblRemarks.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblProtocolParam
            // 
            this.lblProtocolParam.AutoSize = true;
            this.lblProtocolParam.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblProtocolParam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblProtocolParam.Location = new System.Drawing.Point(6, 238);
            this.lblProtocolParam.Margin = new System.Windows.Forms.Padding(3);
            this.lblProtocolParam.Name = "lblProtocolParam";
            this.lblProtocolParam.Size = new System.Drawing.Size(207, 32);
            this.lblProtocolParam.TabIndex = 16;
            this.lblProtocolParam.Text = "Protocol param";
            this.lblProtocolParam.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtProtocolParam
            // 
            this.txtProtocolParam.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtProtocolParam.Location = new System.Drawing.Point(219, 238);
            this.txtProtocolParam.Name = "txtProtocolParam";
            this.txtProtocolParam.Size = new System.Drawing.Size(419, 38);
            this.txtProtocolParam.TabIndex = 17;
            // 
            // chkIP
            // 
            this.chkIP.AutoSize = true;
            this.chkIP.Dock = System.Windows.Forms.DockStyle.Top;
            this.chkIP.Location = new System.Drawing.Point(3, 3);
            this.chkIP.Margin = new System.Windows.Forms.Padding(0);
            this.chkIP.Name = "chkIP";
            this.chkIP.Size = new System.Drawing.Size(213, 36);
            this.chkIP.TabIndex = 38;
            this.chkIP.Text = "Server IP";
            this.chkIP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkIP.UseVisualStyleBackColor = true;
            this.chkIP.CheckedChanged += new System.EventHandler(this.IPLabel_CheckedChanged);
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.AutoSize = true;
            this.tableLayoutPanel7.ColumnCount = 1;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel7.Controls.Add(this.lstServers, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.llbUpdate, 0, 2);
            this.tableLayoutPanel7.Controls.Add(this.tableLayoutPanel4, 0, 1);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 3;
            this.tableLayoutPanel2.SetRowSpan(this.tableLayoutPanel7, 2);
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel7.Size = new System.Drawing.Size(302, 798);
            this.tableLayoutPanel7.TabIndex = 16;
            // 
            // llbUpdate
            // 
            this.llbUpdate.AutoSize = true;
            this.llbUpdate.Location = new System.Drawing.Point(5, 397);
            this.llbUpdate.Margin = new System.Windows.Forms.Padding(5);
            this.llbUpdate.Name = "llbUpdate";
            this.llbUpdate.Size = new System.Drawing.Size(292, 32);
            this.llbUpdate.TabIndex = 5;
            this.llbUpdate.TabStop = true;
            this.llbUpdate.Text = "New version available";
            this.llbUpdate.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkUpdate_LinkClicked);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.AutoSize = true;
            this.tableLayoutPanel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.btnDown, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.btnUp, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.btnDelete, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnAdd, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 297);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(302, 90);
            this.tableLayoutPanel4.TabIndex = 8;
            // 
            // btnDown
            // 
            this.btnDown.AutoSize = true;
            this.btnDown.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDown.Location = new System.Drawing.Point(151, 48);
            this.btnDown.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(151, 42);
            this.btnDown.TabIndex = 4;
            this.btnDown.Text = "Down";
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.DownButton_Click);
            // 
            // btnUp
            // 
            this.btnUp.AutoSize = true;
            this.btnUp.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUp.Location = new System.Drawing.Point(0, 48);
            this.btnUp.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(151, 42);
            this.btnUp.TabIndex = 3;
            this.btnUp.Text = "Up";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.UpButton_Click);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.AutoSize = true;
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel5.Controls.Add(this.picQRcode, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(982, 3);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(12, 3, 3, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.Size = new System.Drawing.Size(268, 747);
            this.tableLayoutPanel5.TabIndex = 17;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.AutoSize = true;
            this.tableLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.btnCancel, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnOK, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(320, 756);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(12, 3, 0, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.Size = new System.Drawing.Size(650, 45);
            this.tableLayoutPanel3.TabIndex = 14;
            // 
            // btnCancel
            // 
            this.btnCancel.AutoSize = true;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCancel.Location = new System.Drawing.Point(328, 3);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(322, 42);
            this.btnCancel.TabIndex = 39;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // btnOK
            // 
            this.btnOK.AutoSize = true;
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOK.Location = new System.Drawing.Point(0, 3);
            this.btnOK.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(325, 42);
            this.btnOK.TabIndex = 38;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // ConfigForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1312, 1014);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConfigForm";
            this.Padding = new System.Windows.Forms.Padding(12, 13, 12, 13);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Servers";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ConfigForm_FormClosed);
            this.Shown += new System.EventHandler(this.ConfigForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.picQRcode)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ServerGroupBox.ResumeLayout(false);
            this.ServerGroupBox.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudServerPort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudUdpPort)).EndInit();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListBox lstServers;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.PictureBox picQRcode;
        private System.Windows.Forms.LinkLabel llbUpdate;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.GroupBox ServerGroupBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox cmbObfs;
        private System.Windows.Forms.Label lblObfs;
        private System.Windows.Forms.Label lblServerPort;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.NumericUpDown nudServerPort;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblEncryption;
        private System.Windows.Forms.ComboBox cmbEncryption;
        private System.Windows.Forms.TextBox txtLink;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.Label lblObfsUdp;
        private System.Windows.Forms.CheckBox chkObfsUDP;
        private System.Windows.Forms.Label lblTCPProtocol;
        private System.Windows.Forms.Label lblUdpOverTcp;
        private System.Windows.Forms.CheckBox chkUdpOverTcp;
        private System.Windows.Forms.Label LabelNote;
        private System.Windows.Forms.CheckBox chkPassword;
        private System.Windows.Forms.Label lblTcpOverUdp;
        private System.Windows.Forms.CheckBox chkTcpOverUdp;
        private System.Windows.Forms.ComboBox cmbTcpProtocol;
        private System.Windows.Forms.Label lblObfsParam;
        private System.Windows.Forms.TextBox txtObfsParam;
        private System.Windows.Forms.Label lblGroup;
        private System.Windows.Forms.TextBox txtGroup;
        private System.Windows.Forms.CheckBox chkAdvSetting;
        private System.Windows.Forms.Label lblUDPPort;
        private System.Windows.Forms.NumericUpDown nudUdpPort;
        private System.Windows.Forms.CheckBox chkSSRLink;
        private System.Windows.Forms.Label lblRemarks;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label lblProtocolParam;
        private System.Windows.Forms.TextBox txtProtocolParam;
        private System.Windows.Forms.CheckBox chkIP;
    }
}

