namespace Soil_Serial
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
            this.label1 = new System.Windows.Forms.Label();
            this.StempCalibra = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textSoilHumid = new System.Windows.Forms.TextBox();
            this.SHumidCalibra = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textECTemp = new System.Windows.Forms.TextBox();
            this.ECtempCalibra = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ECClear = new System.Windows.Forms.Button();
            this.ECCalibra = new System.Windows.Forms.Button();
            this.textEC_A = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textEC_B = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textEC_C = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.SerialId = new System.Windows.Forms.ComboBox();
            this.OpenSerial = new System.Windows.Forms.Button();
            this.CollectTime = new System.Windows.Forms.TextBox();
            this.StempClear = new System.Windows.Forms.Button();
            this.SHumidClear = new System.Windows.Forms.Button();
            this.SoilCheck = new System.Windows.Forms.Button();
            this.ECTempClear = new System.Windows.Forms.Button();
            this.ECCheck = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.剪切ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.复制ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.粘贴ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.全选ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SetModebox = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textSoilTemp = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SoilTempLabel = new System.Windows.Forms.LinkLabel();
            this.HumidityLabel = new System.Windows.Forms.LinkLabel();
            this.HumdataLabel = new System.Windows.Forms.LinkLabel();
            this.label11 = new System.Windows.Forms.Label();
            this.CalibrasoiltempLabel = new System.Windows.Forms.LinkLabel();
            this.CalibrahumidityLabel = new System.Windows.Forms.LinkLabel();
            this.label15 = new System.Windows.Forms.Label();
            this.ECTempLabel = new System.Windows.Forms.LinkLabel();
            this.ECALabel = new System.Windows.Forms.LinkLabel();
            this.ECBLabel = new System.Windows.Forms.LinkLabel();
            this.ECCLabel = new System.Windows.Forms.LinkLabel();
            this.CalibraTempLabel = new System.Windows.Forms.LinkLabel();
            this.label17 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.CalibraECALabel = new System.Windows.Forms.LinkLabel();
            this.CalibraECBLabel = new System.Windows.Forms.LinkLabel();
            this.CalibraECCLabel = new System.Windows.Forms.LinkLabel();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.CurrentEcLabel = new System.Windows.Forms.LinkLabel();
            this.label31 = new System.Windows.Forms.Label();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(8, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "土壤温度：";
            // 
            // StempCalibra
            // 
            this.StempCalibra.Location = new System.Drawing.Point(210, 104);
            this.StempCalibra.Name = "StempCalibra";
            this.StempCalibra.Size = new System.Drawing.Size(77, 34);
            this.StempCalibra.TabIndex = 3;
            this.StempCalibra.Text = "标定";
            this.StempCalibra.UseVisualStyleBackColor = true;
            this.StempCalibra.Click += new System.EventHandler(this.StempCalibra_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(6, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "土壤湿度：";
            // 
            // textSoilHumid
            // 
            this.textSoilHumid.Location = new System.Drawing.Point(98, 193);
            this.textSoilHumid.Name = "textSoilHumid";
            this.textSoilHumid.Size = new System.Drawing.Size(100, 25);
            this.textSoilHumid.TabIndex = 6;
            this.textSoilHumid.Text = "330";
            // 
            // SHumidCalibra
            // 
            this.SHumidCalibra.Location = new System.Drawing.Point(210, 187);
            this.SHumidCalibra.Name = "SHumidCalibra";
            this.SHumidCalibra.Size = new System.Drawing.Size(77, 31);
            this.SHumidCalibra.TabIndex = 7;
            this.SHumidCalibra.Text = "标定";
            this.SHumidCalibra.UseVisualStyleBackColor = true;
            this.SHumidCalibra.Click += new System.EventHandler(this.SHumidCalibra_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(8, 375);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "土壤温度：";
            // 
            // textECTemp
            // 
            this.textECTemp.Location = new System.Drawing.Point(99, 409);
            this.textECTemp.Name = "textECTemp";
            this.textECTemp.Size = new System.Drawing.Size(99, 25);
            this.textECTemp.TabIndex = 9;
            // 
            // ECtempCalibra
            // 
            this.ECtempCalibra.Location = new System.Drawing.Point(210, 400);
            this.ECtempCalibra.Name = "ECtempCalibra";
            this.ECtempCalibra.Size = new System.Drawing.Size(74, 34);
            this.ECtempCalibra.TabIndex = 10;
            this.ECtempCalibra.Text = "标定";
            this.ECtempCalibra.UseVisualStyleBackColor = true;
            this.ECtempCalibra.Click += new System.EventHandler(this.ECtempCalibra_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(133, 465);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "土壤EC三点标定";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(138, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "土壤温湿度标定";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(133, 331);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "土壤EC温度标定";
            // 
            // ECClear
            // 
            this.ECClear.Location = new System.Drawing.Point(328, 596);
            this.ECClear.Name = "ECClear";
            this.ECClear.Size = new System.Drawing.Size(78, 49);
            this.ECClear.TabIndex = 18;
            this.ECClear.Text = "清零";
            this.ECClear.UseVisualStyleBackColor = true;
            this.ECClear.Click += new System.EventHandler(this.ECClear_Click);
            // 
            // ECCalibra
            // 
            this.ECCalibra.Location = new System.Drawing.Point(328, 531);
            this.ECCalibra.Name = "ECCalibra";
            this.ECCalibra.Size = new System.Drawing.Size(78, 47);
            this.ECCalibra.TabIndex = 17;
            this.ECCalibra.Text = "标定";
            this.ECCalibra.UseVisualStyleBackColor = true;
            this.ECCalibra.Click += new System.EventHandler(this.ECCalibra_Click);
            // 
            // textEC_A
            // 
            this.textEC_A.Location = new System.Drawing.Point(227, 531);
            this.textEC_A.Name = "textEC_A";
            this.textEC_A.Size = new System.Drawing.Size(86, 25);
            this.textEC_A.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(8, 539);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 19);
            this.label7.TabIndex = 15;
            this.label7.Text = "EC<0.5：";
            // 
            // textEC_B
            // 
            this.textEC_B.Location = new System.Drawing.Point(227, 576);
            this.textEC_B.Name = "textEC_B";
            this.textEC_B.Size = new System.Drawing.Size(86, 25);
            this.textEC_B.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(8, 584);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 19);
            this.label8.TabIndex = 19;
            this.label8.Text = "1<EC<3：";
            // 
            // textEC_C
            // 
            this.textEC_C.Location = new System.Drawing.Point(227, 620);
            this.textEC_C.Name = "textEC_C";
            this.textEC_C.Size = new System.Drawing.Size(86, 25);
            this.textEC_C.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(5, 628);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 19);
            this.label9.TabIndex = 23;
            this.label9.Text = "9<EC<10：";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(393, 73);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 19);
            this.label10.TabIndex = 27;
            this.label10.Text = "端口：";
            // 
            // SerialId
            // 
            this.SerialId.FormattingEnabled = true;
            this.SerialId.Location = new System.Drawing.Point(457, 73);
            this.SerialId.Name = "SerialId";
            this.SerialId.Size = new System.Drawing.Size(99, 23);
            this.SerialId.TabIndex = 28;
            this.SerialId.DropDown += new System.EventHandler(this.SerialId_DropDown);
            // 
            // OpenSerial
            // 
            this.OpenSerial.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.OpenSerial.Location = new System.Drawing.Point(949, 66);
            this.OpenSerial.Name = "OpenSerial";
            this.OpenSerial.Size = new System.Drawing.Size(105, 29);
            this.OpenSerial.TabIndex = 29;
            this.OpenSerial.Text = "打开串口";
            this.OpenSerial.UseVisualStyleBackColor = true;
            this.OpenSerial.Click += new System.EventHandler(this.OpenSerial_Click);
            // 
            // CollectTime
            // 
            this.CollectTime.Location = new System.Drawing.Point(777, 71);
            this.CollectTime.Name = "CollectTime";
            this.CollectTime.Size = new System.Drawing.Size(149, 25);
            this.CollectTime.TabIndex = 30;
            this.CollectTime.Text = "采集时间(最好>5s)";
            this.CollectTime.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.CollectTime_MouseDoubleClick);
            // 
            // StempClear
            // 
            this.StempClear.Location = new System.Drawing.Point(303, 104);
            this.StempClear.Name = "StempClear";
            this.StempClear.Size = new System.Drawing.Size(72, 34);
            this.StempClear.TabIndex = 31;
            this.StempClear.Text = "清零";
            this.StempClear.UseVisualStyleBackColor = true;
            this.StempClear.Click += new System.EventHandler(this.StempClear_Click);
            // 
            // SHumidClear
            // 
            this.SHumidClear.Location = new System.Drawing.Point(303, 184);
            this.SHumidClear.Name = "SHumidClear";
            this.SHumidClear.Size = new System.Drawing.Size(72, 34);
            this.SHumidClear.TabIndex = 33;
            this.SHumidClear.Text = "清零";
            this.SHumidClear.UseVisualStyleBackColor = true;
            this.SHumidClear.Click += new System.EventHandler(this.SHumidClear_Click);
            // 
            // SoilCheck
            // 
            this.SoilCheck.Location = new System.Drawing.Point(210, 256);
            this.SoilCheck.Name = "SoilCheck";
            this.SoilCheck.Size = new System.Drawing.Size(72, 34);
            this.SoilCheck.TabIndex = 32;
            this.SoilCheck.Text = "查询";
            this.SoilCheck.UseVisualStyleBackColor = true;
            this.SoilCheck.Click += new System.EventHandler(this.SoilCheck_Click);
            // 
            // ECTempClear
            // 
            this.ECTempClear.Location = new System.Drawing.Point(303, 400);
            this.ECTempClear.Name = "ECTempClear";
            this.ECTempClear.Size = new System.Drawing.Size(69, 34);
            this.ECTempClear.TabIndex = 35;
            this.ECTempClear.Text = "清零";
            this.ECTempClear.UseVisualStyleBackColor = true;
            this.ECTempClear.Click += new System.EventHandler(this.ECTempClear_Click);
            // 
            // ECCheck
            // 
            this.ECCheck.Location = new System.Drawing.Point(234, 720);
            this.ECCheck.Name = "ECCheck";
            this.ECCheck.Size = new System.Drawing.Size(86, 48);
            this.ECCheck.TabIndex = 34;
            this.ECCheck.Text = "补偿查询";
            this.ECCheck.UseVisualStyleBackColor = true;
            this.ECCheck.Click += new System.EventHandler(this.ECCheck_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.ContextMenuStrip = this.contextMenuStrip1;
            this.richTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.richTextBox1.Location = new System.Drawing.Point(457, 113);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(597, 679);
            this.richTextBox1.TabIndex = 38;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.RichTextBox1_TextChanged);
            this.richTextBox1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.RichTextBox1_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.剪切ToolStripMenuItem,
            this.复制ToolStripMenuItem,
            this.粘贴ToolStripMenuItem,
            this.全选ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip2";
            this.contextMenuStrip1.Size = new System.Drawing.Size(109, 100);
            // 
            // 剪切ToolStripMenuItem
            // 
            this.剪切ToolStripMenuItem.Name = "剪切ToolStripMenuItem";
            this.剪切ToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
            this.剪切ToolStripMenuItem.Text = "剪切";
            this.剪切ToolStripMenuItem.Click += new System.EventHandler(this.剪切ToolStripMenuItem_Click);
            // 
            // 复制ToolStripMenuItem
            // 
            this.复制ToolStripMenuItem.Name = "复制ToolStripMenuItem";
            this.复制ToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
            this.复制ToolStripMenuItem.Text = "复制";
            this.复制ToolStripMenuItem.Click += new System.EventHandler(this.复制ToolStripMenuItem_Click);
            // 
            // 粘贴ToolStripMenuItem
            // 
            this.粘贴ToolStripMenuItem.Name = "粘贴ToolStripMenuItem";
            this.粘贴ToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
            this.粘贴ToolStripMenuItem.Text = "粘贴";
            this.粘贴ToolStripMenuItem.Click += new System.EventHandler(this.粘贴ToolStripMenuItem_Click);
            // 
            // 全选ToolStripMenuItem
            // 
            this.全选ToolStripMenuItem.Name = "全选ToolStripMenuItem";
            this.全选ToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
            this.全选ToolStripMenuItem.Text = "全选";
            this.全选ToolStripMenuItem.Click += new System.EventHandler(this.全选ToolStripMenuItem_Click);
            // 
            // SetModebox
            // 
            this.SetModebox.FormattingEnabled = true;
            this.SetModebox.Location = new System.Drawing.Point(634, 72);
            this.SetModebox.Name = "SetModebox";
            this.SetModebox.Size = new System.Drawing.Size(121, 23);
            this.SetModebox.TabIndex = 45;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label13.Location = new System.Drawing.Point(562, 74);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(66, 19);
            this.label13.TabIndex = 46;
            this.label13.Text = "标定：";
            // 
            // textSoilTemp
            // 
            this.textSoilTemp.Location = new System.Drawing.Point(99, 113);
            this.textSoilTemp.Name = "textSoilTemp";
            this.textSoilTemp.Size = new System.Drawing.Size(99, 25);
            this.textSoilTemp.TabIndex = 48;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label14.Location = new System.Drawing.Point(108, 79);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(0, 19);
            this.label14.TabIndex = 51;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(109, 83);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(0, 15);
            this.linkLabel1.TabIndex = 53;
            // 
            // SoilTempLabel
            // 
            this.SoilTempLabel.AutoSize = true;
            this.SoilTempLabel.Location = new System.Drawing.Point(109, 81);
            this.SoilTempLabel.Name = "SoilTempLabel";
            this.SoilTempLabel.Size = new System.Drawing.Size(39, 15);
            this.SoilTempLabel.TabIndex = 54;
            this.SoilTempLabel.TabStop = true;
            this.SoilTempLabel.Text = "00.0";
            // 
            // HumidityLabel
            // 
            this.HumidityLabel.AutoSize = true;
            this.HumidityLabel.Location = new System.Drawing.Point(170, 159);
            this.HumidityLabel.Name = "HumidityLabel";
            this.HumidityLabel.Size = new System.Drawing.Size(55, 15);
            this.HumidityLabel.TabIndex = 55;
            this.HumidityLabel.TabStop = true;
            this.HumidityLabel.Text = " 00.0 ";
            // 
            // HumdataLabel
            // 
            this.HumdataLabel.AutoSize = true;
            this.HumdataLabel.Location = new System.Drawing.Point(98, 159);
            this.HumdataLabel.Name = "HumdataLabel";
            this.HumdataLabel.Size = new System.Drawing.Size(63, 15);
            this.HumdataLabel.TabIndex = 56;
            this.HumdataLabel.TabStop = true;
            this.HumdataLabel.Text = "  000  ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.Location = new System.Drawing.Point(8, 235);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(104, 19);
            this.label11.TabIndex = 57;
            this.label11.Text = "温度补偿：";
            // 
            // CalibrasoiltempLabel
            // 
            this.CalibrasoiltempLabel.AutoSize = true;
            this.CalibrasoiltempLabel.Location = new System.Drawing.Point(109, 237);
            this.CalibrasoiltempLabel.Name = "CalibrasoiltempLabel";
            this.CalibrasoiltempLabel.Size = new System.Drawing.Size(39, 15);
            this.CalibrasoiltempLabel.TabIndex = 58;
            this.CalibrasoiltempLabel.TabStop = true;
            this.CalibrasoiltempLabel.Text = "00.0";
            // 
            // CalibrahumidityLabel
            // 
            this.CalibrahumidityLabel.AutoSize = true;
            this.CalibrahumidityLabel.Location = new System.Drawing.Point(104, 275);
            this.CalibrahumidityLabel.Name = "CalibrahumidityLabel";
            this.CalibrahumidityLabel.Size = new System.Drawing.Size(63, 15);
            this.CalibrahumidityLabel.TabIndex = 59;
            this.CalibrahumidityLabel.TabStop = true;
            this.CalibrahumidityLabel.Text = "  000  ";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label15.Location = new System.Drawing.Point(8, 271);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(104, 19);
            this.label15.TabIndex = 60;
            this.label15.Text = "湿度补偿：";
            // 
            // ECTempLabel
            // 
            this.ECTempLabel.AutoSize = true;
            this.ECTempLabel.Location = new System.Drawing.Point(104, 379);
            this.ECTempLabel.Name = "ECTempLabel";
            this.ECTempLabel.Size = new System.Drawing.Size(39, 15);
            this.ECTempLabel.TabIndex = 61;
            this.ECTempLabel.TabStop = true;
            this.ECTempLabel.Text = "00.0";
            // 
            // ECALabel
            // 
            this.ECALabel.AutoSize = true;
            this.ECALabel.Location = new System.Drawing.Point(109, 541);
            this.ECALabel.Name = "ECALabel";
            this.ECALabel.Size = new System.Drawing.Size(55, 15);
            this.ECALabel.TabIndex = 62;
            this.ECALabel.TabStop = true;
            this.ECALabel.Text = "00.000";
            // 
            // ECBLabel
            // 
            this.ECBLabel.AutoSize = true;
            this.ECBLabel.Location = new System.Drawing.Point(109, 586);
            this.ECBLabel.Name = "ECBLabel";
            this.ECBLabel.Size = new System.Drawing.Size(55, 15);
            this.ECBLabel.TabIndex = 63;
            this.ECBLabel.TabStop = true;
            this.ECBLabel.Text = "00.000";
            // 
            // ECCLabel
            // 
            this.ECCLabel.AutoSize = true;
            this.ECCLabel.Location = new System.Drawing.Point(109, 630);
            this.ECCLabel.Name = "ECCLabel";
            this.ECCLabel.Size = new System.Drawing.Size(55, 15);
            this.ECCLabel.TabIndex = 64;
            this.ECCLabel.TabStop = true;
            this.ECCLabel.Text = "00.000";
            // 
            // CalibraTempLabel
            // 
            this.CalibraTempLabel.AutoSize = true;
            this.CalibraTempLabel.Location = new System.Drawing.Point(109, 674);
            this.CalibraTempLabel.Name = "CalibraTempLabel";
            this.CalibraTempLabel.Size = new System.Drawing.Size(39, 15);
            this.CalibraTempLabel.TabIndex = 67;
            this.CalibraTempLabel.TabStop = true;
            this.CalibraTempLabel.Text = "00.0";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label17.Location = new System.Drawing.Point(8, 670);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(104, 19);
            this.label17.TabIndex = 66;
            this.label17.Text = "温度补偿：";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.Location = new System.Drawing.Point(8, 703);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(88, 19);
            this.label12.TabIndex = 68;
            this.label12.Text = "EC<0.5：";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label16.Location = new System.Drawing.Point(8, 735);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(88, 19);
            this.label16.TabIndex = 69;
            this.label16.Text = "1<EC<3：";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label18.Location = new System.Drawing.Point(8, 765);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(98, 19);
            this.label18.TabIndex = 70;
            this.label18.Text = "9<EC<10：";
            // 
            // CalibraECALabel
            // 
            this.CalibraECALabel.AutoSize = true;
            this.CalibraECALabel.Location = new System.Drawing.Point(106, 707);
            this.CalibraECALabel.Name = "CalibraECALabel";
            this.CalibraECALabel.Size = new System.Drawing.Size(55, 15);
            this.CalibraECALabel.TabIndex = 71;
            this.CalibraECALabel.TabStop = true;
            this.CalibraECALabel.Text = "00.000";
            // 
            // CalibraECBLabel
            // 
            this.CalibraECBLabel.AutoSize = true;
            this.CalibraECBLabel.Location = new System.Drawing.Point(106, 739);
            this.CalibraECBLabel.Name = "CalibraECBLabel";
            this.CalibraECBLabel.Size = new System.Drawing.Size(55, 15);
            this.CalibraECBLabel.TabIndex = 72;
            this.CalibraECBLabel.TabStop = true;
            this.CalibraECBLabel.Text = "00.000";
            // 
            // CalibraECCLabel
            // 
            this.CalibraECCLabel.AutoSize = true;
            this.CalibraECCLabel.Location = new System.Drawing.Point(106, 769);
            this.CalibraECCLabel.Name = "CalibraECCLabel";
            this.CalibraECCLabel.Size = new System.Drawing.Size(55, 15);
            this.CalibraECCLabel.TabIndex = 73;
            this.CalibraECCLabel.TabStop = true;
            this.CalibraECCLabel.Text = "00.000";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label19.Location = new System.Drawing.Point(154, 81);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(38, 15);
            this.label19.TabIndex = 74;
            this.label19.Text = "℃  ";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label20.Location = new System.Drawing.Point(160, 239);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(38, 15);
            this.label20.TabIndex = 75;
            this.label20.Text = "℃  ";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label21.Location = new System.Drawing.Point(149, 379);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(38, 15);
            this.label21.TabIndex = 76;
            this.label21.Text = "℃  ";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label22.Location = new System.Drawing.Point(170, 541);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(39, 15);
            this.label22.TabIndex = 77;
            this.label22.Text = "ds/m";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label23.Location = new System.Drawing.Point(170, 586);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(39, 15);
            this.label23.TabIndex = 78;
            this.label23.Text = "ds/m";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label24.Location = new System.Drawing.Point(170, 630);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(39, 15);
            this.label24.TabIndex = 79;
            this.label24.Text = "ds/m";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label25.Location = new System.Drawing.Point(170, 674);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(22, 15);
            this.label25.TabIndex = 80;
            this.label25.Text = "℃";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label26.Location = new System.Drawing.Point(170, 707);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(39, 15);
            this.label26.TabIndex = 81;
            this.label26.Text = "ds/m";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label27.Location = new System.Drawing.Point(170, 739);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(39, 15);
            this.label27.TabIndex = 82;
            this.label27.Text = "ds/m";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label28.Location = new System.Drawing.Point(170, 769);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(39, 15);
            this.label28.TabIndex = 83;
            this.label28.Text = "ds/m";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label29.Location = new System.Drawing.Point(231, 159);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(30, 15);
            this.label29.TabIndex = 84;
            this.label29.Text = "％ ";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label30.Location = new System.Drawing.Point(8, 504);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(123, 19);
            this.label30.TabIndex = 85;
            this.label30.Text = "土壤电导率：";
            // 
            // CurrentEcLabel
            // 
            this.CurrentEcLabel.AutoSize = true;
            this.CurrentEcLabel.Location = new System.Drawing.Point(134, 508);
            this.CurrentEcLabel.Name = "CurrentEcLabel";
            this.CurrentEcLabel.Size = new System.Drawing.Size(55, 15);
            this.CurrentEcLabel.TabIndex = 86;
            this.CurrentEcLabel.TabStop = true;
            this.CurrentEcLabel.Text = "00.000";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label31.Location = new System.Drawing.Point(207, 508);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(39, 15);
            this.label31.TabIndex = 87;
            this.label31.Text = "ds/m";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 859);
            this.Controls.Add(this.label31);
            this.Controls.Add(this.CurrentEcLabel);
            this.Controls.Add(this.label30);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.CalibraECCLabel);
            this.Controls.Add(this.CalibraECBLabel);
            this.Controls.Add(this.CalibraECALabel);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.CalibraTempLabel);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.ECCLabel);
            this.Controls.Add(this.ECBLabel);
            this.Controls.Add(this.ECALabel);
            this.Controls.Add(this.ECTempLabel);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.CalibrahumidityLabel);
            this.Controls.Add(this.CalibrasoiltempLabel);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.HumdataLabel);
            this.Controls.Add(this.HumidityLabel);
            this.Controls.Add(this.SoilTempLabel);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.textSoilTemp);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.SetModebox);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.ECTempClear);
            this.Controls.Add(this.ECCheck);
            this.Controls.Add(this.SHumidClear);
            this.Controls.Add(this.SoilCheck);
            this.Controls.Add(this.StempClear);
            this.Controls.Add(this.CollectTime);
            this.Controls.Add(this.OpenSerial);
            this.Controls.Add(this.SerialId);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textEC_C);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textEC_B);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ECClear);
            this.Controls.Add(this.ECCalibra);
            this.Controls.Add(this.textEC_A);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ECtempCalibra);
            this.Controls.Add(this.textECTemp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SHumidCalibra);
            this.Controls.Add(this.textSoilHumid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.StempCalibra);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button StempCalibra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textSoilHumid;
        private System.Windows.Forms.Button SHumidCalibra;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textECTemp;
        private System.Windows.Forms.Button ECtempCalibra;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button ECClear;
        private System.Windows.Forms.Button ECCalibra;
        private System.Windows.Forms.TextBox textEC_A;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textEC_B;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textEC_C;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox SerialId;
        private System.Windows.Forms.Button OpenSerial;
        private System.Windows.Forms.TextBox CollectTime;
        private System.Windows.Forms.Button StempClear;
        private System.Windows.Forms.Button SHumidClear;
        private System.Windows.Forms.Button SoilCheck;
        private System.Windows.Forms.Button ECTempClear;
        private System.Windows.Forms.Button ECCheck;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 剪切ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 复制ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 粘贴ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 全选ToolStripMenuItem;
        private System.Windows.Forms.ComboBox SetModebox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textSoilTemp;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel SoilTempLabel;
        private System.Windows.Forms.LinkLabel HumidityLabel;
        private System.Windows.Forms.LinkLabel HumdataLabel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.LinkLabel CalibrasoiltempLabel;
        private System.Windows.Forms.LinkLabel CalibrahumidityLabel;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.LinkLabel ECTempLabel;
        private System.Windows.Forms.LinkLabel ECALabel;
        private System.Windows.Forms.LinkLabel ECBLabel;
        private System.Windows.Forms.LinkLabel ECCLabel;
        private System.Windows.Forms.LinkLabel CalibraTempLabel;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.LinkLabel CalibraECALabel;
        private System.Windows.Forms.LinkLabel CalibraECBLabel;
        private System.Windows.Forms.LinkLabel CalibraECCLabel;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.LinkLabel CurrentEcLabel;
        private System.Windows.Forms.Label label31;
    }
}

