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
            this.textSoilTemp = new System.Windows.Forms.TextBox();
            this.StempCalibra = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textSoilHumid = new System.Windows.Forms.TextBox();
            this.SHumidCalibra = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textECTemp = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ECAClear = new System.Windows.Forms.Button();
            this.ECACalibra = new System.Windows.Forms.Button();
            this.textEC_A = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ECBClear = new System.Windows.Forms.Button();
            this.ECBCalibra = new System.Windows.Forms.Button();
            this.textEC_B = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ECCClear = new System.Windows.Forms.Button();
            this.ECCCalibra = new System.Windows.Forms.Button();
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
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.剪切ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.复制ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.粘贴ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.全选ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SoilTempcheckBox = new System.Windows.Forms.CheckBox();
            this.SoilHumidcheckBox = new System.Windows.Forms.CheckBox();
            this.ECTempcheckBox = new System.Windows.Forms.CheckBox();
            this.ECAcheckBox = new System.Windows.Forms.CheckBox();
            this.ECCcheckBox = new System.Windows.Forms.CheckBox();
            this.ECBcheckBox = new System.Windows.Forms.CheckBox();
            this.SetModebox = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(8, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "土壤温度";
            // 
            // textSoilTemp
            // 
            this.textSoilTemp.Location = new System.Drawing.Point(183, 73);
            this.textSoilTemp.Name = "textSoilTemp";
            this.textSoilTemp.Size = new System.Drawing.Size(161, 25);
            this.textSoilTemp.TabIndex = 2;
            // 
            // StempCalibra
            // 
            this.StempCalibra.Location = new System.Drawing.Point(183, 113);
            this.StempCalibra.Name = "StempCalibra";
            this.StempCalibra.Size = new System.Drawing.Size(73, 34);
            this.StempCalibra.TabIndex = 3;
            this.StempCalibra.Text = "标定";
            this.StempCalibra.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(7, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "土壤湿度";
            // 
            // textSoilHumid
            // 
            this.textSoilHumid.Location = new System.Drawing.Point(183, 174);
            this.textSoilHumid.Name = "textSoilHumid";
            this.textSoilHumid.Size = new System.Drawing.Size(162, 25);
            this.textSoilHumid.TabIndex = 6;
            // 
            // SHumidCalibra
            // 
            this.SHumidCalibra.Location = new System.Drawing.Point(184, 213);
            this.SHumidCalibra.Name = "SHumidCalibra";
            this.SHumidCalibra.Size = new System.Drawing.Size(73, 31);
            this.SHumidCalibra.TabIndex = 7;
            this.SHumidCalibra.Text = "标定";
            this.SHumidCalibra.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(8, 375);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "土壤EC温度";
            // 
            // textECTemp
            // 
            this.textECTemp.Location = new System.Drawing.Point(184, 369);
            this.textECTemp.Name = "textECTemp";
            this.textECTemp.Size = new System.Drawing.Size(160, 25);
            this.textECTemp.TabIndex = 9;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(184, 405);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(74, 34);
            this.button4.TabIndex = 10;
            this.button4.Text = "标定";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(180, 467);
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
            this.label6.Location = new System.Drawing.Point(180, 328);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "土壤EC温度标定";
            // 
            // ECAClear
            // 
            this.ECAClear.Location = new System.Drawing.Point(276, 542);
            this.ECAClear.Name = "ECAClear";
            this.ECAClear.Size = new System.Drawing.Size(69, 34);
            this.ECAClear.TabIndex = 18;
            this.ECAClear.Text = "清零";
            this.ECAClear.UseVisualStyleBackColor = true;
            // 
            // ECACalibra
            // 
            this.ECACalibra.Location = new System.Drawing.Point(184, 542);
            this.ECACalibra.Name = "ECACalibra";
            this.ECACalibra.Size = new System.Drawing.Size(72, 34);
            this.ECACalibra.TabIndex = 17;
            this.ECACalibra.Text = "标定";
            this.ECACalibra.UseVisualStyleBackColor = true;
            // 
            // textEC_A
            // 
            this.textEC_A.Location = new System.Drawing.Point(184, 507);
            this.textEC_A.Name = "textEC_A";
            this.textEC_A.Size = new System.Drawing.Size(160, 25);
            this.textEC_A.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(8, 515);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 19);
            this.label7.TabIndex = 15;
            this.label7.Text = "EC<0.5";
            // 
            // ECBClear
            // 
            this.ECBClear.Location = new System.Drawing.Point(275, 633);
            this.ECBClear.Name = "ECBClear";
            this.ECBClear.Size = new System.Drawing.Size(69, 34);
            this.ECBClear.TabIndex = 22;
            this.ECBClear.Text = "清零";
            this.ECBClear.UseVisualStyleBackColor = true;
            // 
            // ECBCalibra
            // 
            this.ECBCalibra.Location = new System.Drawing.Point(184, 633);
            this.ECBCalibra.Name = "ECBCalibra";
            this.ECBCalibra.Size = new System.Drawing.Size(72, 34);
            this.ECBCalibra.TabIndex = 21;
            this.ECBCalibra.Text = "标定";
            this.ECBCalibra.UseVisualStyleBackColor = true;
            // 
            // textEC_B
            // 
            this.textEC_B.Location = new System.Drawing.Point(184, 591);
            this.textEC_B.Name = "textEC_B";
            this.textEC_B.Size = new System.Drawing.Size(161, 25);
            this.textEC_B.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(8, 591);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 19);
            this.label8.TabIndex = 19;
            this.label8.Text = "1<EC<3";
            // 
            // ECCClear
            // 
            this.ECCClear.Location = new System.Drawing.Point(275, 725);
            this.ECCClear.Name = "ECCClear";
            this.ECCClear.Size = new System.Drawing.Size(68, 34);
            this.ECCClear.TabIndex = 26;
            this.ECCClear.Text = "清零";
            this.ECCClear.UseVisualStyleBackColor = true;
            // 
            // ECCCalibra
            // 
            this.ECCCalibra.Location = new System.Drawing.Point(183, 725);
            this.ECCCalibra.Name = "ECCCalibra";
            this.ECCCalibra.Size = new System.Drawing.Size(72, 34);
            this.ECCCalibra.TabIndex = 25;
            this.ECCCalibra.Text = "标定";
            this.ECCCalibra.UseVisualStyleBackColor = true;
            // 
            // textEC_C
            // 
            this.textEC_C.Location = new System.Drawing.Point(184, 683);
            this.textEC_C.Name = "textEC_C";
            this.textEC_C.Size = new System.Drawing.Size(160, 25);
            this.textEC_C.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(7, 684);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 19);
            this.label9.TabIndex = 23;
            this.label9.Text = "9<EC<10";
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
            this.StempClear.Location = new System.Drawing.Point(275, 113);
            this.StempClear.Name = "StempClear";
            this.StempClear.Size = new System.Drawing.Size(69, 34);
            this.StempClear.TabIndex = 31;
            this.StempClear.Text = "清零";
            this.StempClear.UseVisualStyleBackColor = true;
            // 
            // SHumidClear
            // 
            this.SHumidClear.Location = new System.Drawing.Point(276, 211);
            this.SHumidClear.Name = "SHumidClear";
            this.SHumidClear.Size = new System.Drawing.Size(69, 34);
            this.SHumidClear.TabIndex = 33;
            this.SHumidClear.Text = "清零";
            this.SHumidClear.UseVisualStyleBackColor = true;
            // 
            // SoilCheck
            // 
            this.SoilCheck.Location = new System.Drawing.Point(183, 271);
            this.SoilCheck.Name = "SoilCheck";
            this.SoilCheck.Size = new System.Drawing.Size(99, 34);
            this.SoilCheck.TabIndex = 32;
            this.SoilCheck.Text = "查询";
            this.SoilCheck.UseVisualStyleBackColor = true;
            // 
            // ECTempClear
            // 
            this.ECTempClear.Location = new System.Drawing.Point(276, 405);
            this.ECTempClear.Name = "ECTempClear";
            this.ECTempClear.Size = new System.Drawing.Size(69, 34);
            this.ECTempClear.TabIndex = 35;
            this.ECTempClear.Text = "清零";
            this.ECTempClear.UseVisualStyleBackColor = true;
            // 
            // ECCheck
            // 
            this.ECCheck.Location = new System.Drawing.Point(184, 777);
            this.ECCheck.Name = "ECCheck";
            this.ECCheck.Size = new System.Drawing.Size(98, 34);
            this.ECCheck.TabIndex = 34;
            this.ECCheck.Text = "查询";
            this.ECCheck.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.Location = new System.Drawing.Point(7, 279);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(123, 19);
            this.label11.TabIndex = 36;
            this.label11.Text = "土壤温度标定";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.Location = new System.Drawing.Point(7, 785);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(105, 19);
            this.label12.TabIndex = 37;
            this.label12.Text = "土壤EC标定";
            // 
            // richTextBox1
            // 
            this.richTextBox1.ContextMenuStrip = this.contextMenuStrip1;
            this.richTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.richTextBox1.Location = new System.Drawing.Point(457, 113);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(597, 595);
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
            // SoilTempcheckBox
            // 
            this.SoilTempcheckBox.AutoSize = true;
            this.SoilTempcheckBox.Location = new System.Drawing.Point(134, 80);
            this.SoilTempcheckBox.Name = "SoilTempcheckBox";
            this.SoilTempcheckBox.Size = new System.Drawing.Size(44, 19);
            this.SoilTempcheckBox.TabIndex = 39;
            this.SoilTempcheckBox.Text = "减";
            this.SoilTempcheckBox.UseVisualStyleBackColor = true;
            // 
            // SoilHumidcheckBox
            // 
            this.SoilHumidcheckBox.AutoSize = true;
            this.SoilHumidcheckBox.Location = new System.Drawing.Point(134, 181);
            this.SoilHumidcheckBox.Name = "SoilHumidcheckBox";
            this.SoilHumidcheckBox.Size = new System.Drawing.Size(44, 19);
            this.SoilHumidcheckBox.TabIndex = 40;
            this.SoilHumidcheckBox.Text = "减";
            this.SoilHumidcheckBox.UseVisualStyleBackColor = true;
            // 
            // ECTempcheckBox
            // 
            this.ECTempcheckBox.AutoSize = true;
            this.ECTempcheckBox.Location = new System.Drawing.Point(134, 375);
            this.ECTempcheckBox.Name = "ECTempcheckBox";
            this.ECTempcheckBox.Size = new System.Drawing.Size(44, 19);
            this.ECTempcheckBox.TabIndex = 41;
            this.ECTempcheckBox.Text = "减";
            this.ECTempcheckBox.UseVisualStyleBackColor = true;
            // 
            // ECAcheckBox
            // 
            this.ECAcheckBox.AutoSize = true;
            this.ECAcheckBox.Location = new System.Drawing.Point(134, 516);
            this.ECAcheckBox.Name = "ECAcheckBox";
            this.ECAcheckBox.Size = new System.Drawing.Size(44, 19);
            this.ECAcheckBox.TabIndex = 42;
            this.ECAcheckBox.Text = "负";
            this.ECAcheckBox.UseVisualStyleBackColor = true;
            // 
            // ECCcheckBox
            // 
            this.ECCcheckBox.AutoSize = true;
            this.ECCcheckBox.Location = new System.Drawing.Point(134, 684);
            this.ECCcheckBox.Name = "ECCcheckBox";
            this.ECCcheckBox.Size = new System.Drawing.Size(44, 19);
            this.ECCcheckBox.TabIndex = 43;
            this.ECCcheckBox.Text = "负";
            this.ECCcheckBox.UseVisualStyleBackColor = true;
            // 
            // ECBcheckBox
            // 
            this.ECBcheckBox.AutoSize = true;
            this.ECBcheckBox.Location = new System.Drawing.Point(134, 592);
            this.ECBcheckBox.Name = "ECBcheckBox";
            this.ECBcheckBox.Size = new System.Drawing.Size(44, 19);
            this.ECBcheckBox.TabIndex = 44;
            this.ECBcheckBox.Text = "负";
            this.ECBcheckBox.UseVisualStyleBackColor = true;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 835);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.SetModebox);
            this.Controls.Add(this.ECBcheckBox);
            this.Controls.Add(this.ECCcheckBox);
            this.Controls.Add(this.ECAcheckBox);
            this.Controls.Add(this.ECTempcheckBox);
            this.Controls.Add(this.SoilHumidcheckBox);
            this.Controls.Add(this.SoilTempcheckBox);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.ECTempClear);
            this.Controls.Add(this.ECCheck);
            this.Controls.Add(this.SHumidClear);
            this.Controls.Add(this.SoilCheck);
            this.Controls.Add(this.StempClear);
            this.Controls.Add(this.CollectTime);
            this.Controls.Add(this.OpenSerial);
            this.Controls.Add(this.SerialId);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.ECCClear);
            this.Controls.Add(this.ECCCalibra);
            this.Controls.Add(this.textEC_C);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.ECBClear);
            this.Controls.Add(this.ECBCalibra);
            this.Controls.Add(this.textEC_B);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ECAClear);
            this.Controls.Add(this.ECACalibra);
            this.Controls.Add(this.textEC_A);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.textECTemp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SHumidCalibra);
            this.Controls.Add(this.textSoilHumid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.StempCalibra);
            this.Controls.Add(this.textSoilTemp);
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
        private System.Windows.Forms.TextBox textSoilTemp;
        private System.Windows.Forms.Button StempCalibra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textSoilHumid;
        private System.Windows.Forms.Button SHumidCalibra;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textECTemp;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button ECAClear;
        private System.Windows.Forms.Button ECACalibra;
        private System.Windows.Forms.TextBox textEC_A;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button ECBClear;
        private System.Windows.Forms.Button ECBCalibra;
        private System.Windows.Forms.TextBox textEC_B;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button ECCClear;
        private System.Windows.Forms.Button ECCCalibra;
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
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.CheckBox SoilTempcheckBox;
        private System.Windows.Forms.CheckBox SoilHumidcheckBox;
        private System.Windows.Forms.CheckBox ECTempcheckBox;
        private System.Windows.Forms.CheckBox ECAcheckBox;
        private System.Windows.Forms.CheckBox ECCcheckBox;
        private System.Windows.Forms.CheckBox ECBcheckBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 剪切ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 复制ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 粘贴ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 全选ToolStripMenuItem;
        private System.Windows.Forms.ComboBox SetModebox;
        private System.Windows.Forms.Label label13;
    }
}

