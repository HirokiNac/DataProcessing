namespace DataProcessing
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
            this.components = new System.ComponentModel.Container();
            this.zedGraphControl1 = new ZedGraph.ZedGraphControl();
            this.tB_CosSinTrans_FitOrder = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cB_CosSinTrans_FitQuadra = new System.Windows.Forms.CheckBox();
            this.button_CosSinTrans_Output = new System.Windows.Forms.Button();
            this.button_CosSinTrans_FitRun = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button_CosSinTrans_ofd = new System.Windows.Forms.Button();
            this.tB_CosSinTrans_ofdPath = new System.Windows.Forms.TextBox();
            this.rB_CosSinTrans_FitSin = new System.Windows.Forms.RadioButton();
            this.rB_CosSinTrans_FitCos = new System.Windows.Forms.RadioButton();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.sfd = new System.Windows.Forms.SaveFileDialog();
            this.cB_CosSinTrans_OutF = new System.Windows.Forms.CheckBox();
            this.cB_CosSinTrans_ModData = new System.Windows.Forms.CheckBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage_CosSinTrans = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_FigSlope_ofd = new System.Windows.Forms.TextBox();
            this.button_FigSlope_ofd = new System.Windows.Forms.Button();
            this.button_FigSlope_Run = new System.Windows.Forms.Button();
            this.checkBox_FigSlope_noX = new System.Windows.Forms.CheckBox();
            this.textBox_FigSlope_Xpitch = new System.Windows.Forms.TextBox();
            this.textBox_FigSlope_Boxcar = new System.Windows.Forms.TextBox();
            this.textBox_FigSlope_Interval = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button_FigSlope_Output = new System.Windows.Forms.Button();
            this.textBox_Log = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage_CosSinTrans.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // zedGraphControl1
            // 
            this.zedGraphControl1.Location = new System.Drawing.Point(240, 12);
            this.zedGraphControl1.Name = "zedGraphControl1";
            this.zedGraphControl1.ScrollGrace = 0D;
            this.zedGraphControl1.ScrollMaxX = 0D;
            this.zedGraphControl1.ScrollMaxY = 0D;
            this.zedGraphControl1.ScrollMaxY2 = 0D;
            this.zedGraphControl1.ScrollMinX = 0D;
            this.zedGraphControl1.ScrollMinY = 0D;
            this.zedGraphControl1.ScrollMinY2 = 0D;
            this.zedGraphControl1.Size = new System.Drawing.Size(561, 343);
            this.zedGraphControl1.TabIndex = 0;
            // 
            // tB_CosSinTrans_FitOrder
            // 
            this.tB_CosSinTrans_FitOrder.Location = new System.Drawing.Point(39, 74);
            this.tB_CosSinTrans_FitOrder.Name = "tB_CosSinTrans_FitOrder";
            this.tB_CosSinTrans_FitOrder.Size = new System.Drawing.Size(70, 19);
            this.tB_CosSinTrans_FitOrder.TabIndex = 30;
            this.tB_CosSinTrans_FitOrder.Text = "2";
            this.tB_CosSinTrans_FitOrder.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 29;
            this.label6.Text = "波数";
            // 
            // cB_CosSinTrans_FitQuadra
            // 
            this.cB_CosSinTrans_FitQuadra.AutoSize = true;
            this.cB_CosSinTrans_FitQuadra.Checked = true;
            this.cB_CosSinTrans_FitQuadra.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cB_CosSinTrans_FitQuadra.Location = new System.Drawing.Point(100, 52);
            this.cB_CosSinTrans_FitQuadra.Name = "cB_CosSinTrans_FitQuadra";
            this.cB_CosSinTrans_FitQuadra.Size = new System.Drawing.Size(96, 16);
            this.cB_CosSinTrans_FitQuadra.TabIndex = 39;
            this.cB_CosSinTrans_FitQuadra.Text = "二次関数差分";
            this.cB_CosSinTrans_FitQuadra.UseVisualStyleBackColor = true;
            // 
            // button_CosSinTrans_Output
            // 
            this.button_CosSinTrans_Output.Location = new System.Drawing.Point(6, 150);
            this.button_CosSinTrans_Output.Name = "button_CosSinTrans_Output";
            this.button_CosSinTrans_Output.Size = new System.Drawing.Size(75, 23);
            this.button_CosSinTrans_Output.TabIndex = 38;
            this.button_CosSinTrans_Output.Text = "データ出力";
            this.button_CosSinTrans_Output.UseVisualStyleBackColor = true;
            this.button_CosSinTrans_Output.Click += new System.EventHandler(this.button_Fit_Output_Click);
            // 
            // button_CosSinTrans_FitRun
            // 
            this.button_CosSinTrans_FitRun.Location = new System.Drawing.Point(6, 99);
            this.button_CosSinTrans_FitRun.Name = "button_CosSinTrans_FitRun";
            this.button_CosSinTrans_FitRun.Size = new System.Drawing.Size(75, 23);
            this.button_CosSinTrans_FitRun.TabIndex = 35;
            this.button_CosSinTrans_FitRun.Text = "フィルタ実行";
            this.button_CosSinTrans_FitRun.UseVisualStyleBackColor = true;
            this.button_CosSinTrans_FitRun.Click += new System.EventHandler(this.button_Fit_Run_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 33;
            this.label1.Text = "Input File";
            // 
            // button_CosSinTrans_ofd
            // 
            this.button_CosSinTrans_ofd.Location = new System.Drawing.Point(176, 16);
            this.button_CosSinTrans_ofd.Name = "button_CosSinTrans_ofd";
            this.button_CosSinTrans_ofd.Size = new System.Drawing.Size(30, 23);
            this.button_CosSinTrans_ofd.TabIndex = 32;
            this.button_CosSinTrans_ofd.Text = "...";
            this.button_CosSinTrans_ofd.UseVisualStyleBackColor = true;
            this.button_CosSinTrans_ofd.Click += new System.EventHandler(this.button_ofd_Click);
            // 
            // tB_CosSinTrans_ofdPath
            // 
            this.tB_CosSinTrans_ofdPath.Location = new System.Drawing.Point(6, 18);
            this.tB_CosSinTrans_ofdPath.Name = "tB_CosSinTrans_ofdPath";
            this.tB_CosSinTrans_ofdPath.ReadOnly = true;
            this.tB_CosSinTrans_ofdPath.Size = new System.Drawing.Size(164, 19);
            this.tB_CosSinTrans_ofdPath.TabIndex = 31;
            // 
            // rB_CosSinTrans_FitSin
            // 
            this.rB_CosSinTrans_FitSin.AutoSize = true;
            this.rB_CosSinTrans_FitSin.Location = new System.Drawing.Point(6, 52);
            this.rB_CosSinTrans_FitSin.Name = "rB_CosSinTrans_FitSin";
            this.rB_CosSinTrans_FitSin.Size = new System.Drawing.Size(39, 16);
            this.rB_CosSinTrans_FitSin.TabIndex = 40;
            this.rB_CosSinTrans_FitSin.TabStop = true;
            this.rB_CosSinTrans_FitSin.Text = "Sin";
            this.rB_CosSinTrans_FitSin.UseVisualStyleBackColor = true;
            // 
            // rB_CosSinTrans_FitCos
            // 
            this.rB_CosSinTrans_FitCos.AutoSize = true;
            this.rB_CosSinTrans_FitCos.Location = new System.Drawing.Point(51, 52);
            this.rB_CosSinTrans_FitCos.Name = "rB_CosSinTrans_FitCos";
            this.rB_CosSinTrans_FitCos.Size = new System.Drawing.Size(43, 16);
            this.rB_CosSinTrans_FitCos.TabIndex = 41;
            this.rB_CosSinTrans_FitCos.TabStop = true;
            this.rB_CosSinTrans_FitCos.Text = "Cos";
            this.rB_CosSinTrans_FitCos.UseVisualStyleBackColor = true;
            // 
            // ofd
            // 
            this.ofd.FileName = "openFileDialog1";
            // 
            // cB_CosSinTrans_OutF
            // 
            this.cB_CosSinTrans_OutF.AutoSize = true;
            this.cB_CosSinTrans_OutF.Location = new System.Drawing.Point(8, 128);
            this.cB_CosSinTrans_OutF.Name = "cB_CosSinTrans_OutF";
            this.cB_CosSinTrans_OutF.Size = new System.Drawing.Size(55, 16);
            this.cB_CosSinTrans_OutF.TabIndex = 42;
            this.cB_CosSinTrans_OutF.Text = "F出力";
            this.cB_CosSinTrans_OutF.UseVisualStyleBackColor = true;
            // 
            // cB_CosSinTrans_ModData
            // 
            this.cB_CosSinTrans_ModData.AutoSize = true;
            this.cB_CosSinTrans_ModData.Location = new System.Drawing.Point(69, 128);
            this.cB_CosSinTrans_ModData.Name = "cB_CosSinTrans_ModData";
            this.cB_CosSinTrans_ModData.Size = new System.Drawing.Size(100, 16);
            this.cB_CosSinTrans_ModData.TabIndex = 42;
            this.cB_CosSinTrans_ModData.Text = "修正データ出力";
            this.cB_CosSinTrans_ModData.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage_CosSinTrans);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(222, 203);
            this.tabControl1.TabIndex = 43;
            // 
            // tabPage_CosSinTrans
            // 
            this.tabPage_CosSinTrans.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage_CosSinTrans.Controls.Add(this.label1);
            this.tabPage_CosSinTrans.Controls.Add(this.cB_CosSinTrans_ModData);
            this.tabPage_CosSinTrans.Controls.Add(this.tB_CosSinTrans_ofdPath);
            this.tabPage_CosSinTrans.Controls.Add(this.cB_CosSinTrans_OutF);
            this.tabPage_CosSinTrans.Controls.Add(this.button_CosSinTrans_ofd);
            this.tabPage_CosSinTrans.Controls.Add(this.rB_CosSinTrans_FitCos);
            this.tabPage_CosSinTrans.Controls.Add(this.tB_CosSinTrans_FitOrder);
            this.tabPage_CosSinTrans.Controls.Add(this.rB_CosSinTrans_FitSin);
            this.tabPage_CosSinTrans.Controls.Add(this.button_CosSinTrans_FitRun);
            this.tabPage_CosSinTrans.Controls.Add(this.button_CosSinTrans_Output);
            this.tabPage_CosSinTrans.Controls.Add(this.label6);
            this.tabPage_CosSinTrans.Controls.Add(this.cB_CosSinTrans_FitQuadra);
            this.tabPage_CosSinTrans.Location = new System.Drawing.Point(4, 22);
            this.tabPage_CosSinTrans.Name = "tabPage_CosSinTrans";
            this.tabPage_CosSinTrans.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_CosSinTrans.Size = new System.Drawing.Size(214, 181);
            this.tabPage_CosSinTrans.TabIndex = 0;
            this.tabPage_CosSinTrans.Text = "Cos Sin 変換";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.button_FigSlope_Output);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.textBox_FigSlope_Interval);
            this.tabPage2.Controls.Add(this.textBox_FigSlope_Boxcar);
            this.tabPage2.Controls.Add(this.textBox_FigSlope_Xpitch);
            this.tabPage2.Controls.Add(this.checkBox_FigSlope_noX);
            this.tabPage2.Controls.Add(this.button_FigSlope_Run);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.textBox_FigSlope_ofd);
            this.tabPage2.Controls.Add(this.button_FigSlope_ofd);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(214, 177);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "スロープエラー変換";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 36;
            this.label2.Text = "Input File";
            // 
            // textBox_FigSlope_ofd
            // 
            this.textBox_FigSlope_ofd.Location = new System.Drawing.Point(6, 18);
            this.textBox_FigSlope_ofd.Name = "textBox_FigSlope_ofd";
            this.textBox_FigSlope_ofd.ReadOnly = true;
            this.textBox_FigSlope_ofd.Size = new System.Drawing.Size(164, 19);
            this.textBox_FigSlope_ofd.TabIndex = 34;
            // 
            // button_FigSlope_ofd
            // 
            this.button_FigSlope_ofd.Location = new System.Drawing.Point(176, 16);
            this.button_FigSlope_ofd.Name = "button_FigSlope_ofd";
            this.button_FigSlope_ofd.Size = new System.Drawing.Size(30, 23);
            this.button_FigSlope_ofd.TabIndex = 35;
            this.button_FigSlope_ofd.Text = "...";
            this.button_FigSlope_ofd.UseVisualStyleBackColor = true;
            this.button_FigSlope_ofd.Click += new System.EventHandler(this.button_FigSlope_ofd_Click);
            // 
            // button_FigSlope_Run
            // 
            this.button_FigSlope_Run.Location = new System.Drawing.Point(120, 120);
            this.button_FigSlope_Run.Name = "button_FigSlope_Run";
            this.button_FigSlope_Run.Size = new System.Drawing.Size(75, 23);
            this.button_FigSlope_Run.TabIndex = 37;
            this.button_FigSlope_Run.Text = "変換";
            this.button_FigSlope_Run.UseVisualStyleBackColor = true;
            this.button_FigSlope_Run.Click += new System.EventHandler(this.button_FigSlope_Run_Click);
            // 
            // checkBox_FigSlope_noX
            // 
            this.checkBox_FigSlope_noX.AutoSize = true;
            this.checkBox_FigSlope_noX.Location = new System.Drawing.Point(30, 47);
            this.checkBox_FigSlope_noX.Name = "checkBox_FigSlope_noX";
            this.checkBox_FigSlope_noX.Size = new System.Drawing.Size(74, 16);
            this.checkBox_FigSlope_noX.TabIndex = 38;
            this.checkBox_FigSlope_noX.Text = "X座標なし";
            this.checkBox_FigSlope_noX.UseVisualStyleBackColor = true;
            // 
            // textBox_FigSlope_Xpitch
            // 
            this.textBox_FigSlope_Xpitch.Location = new System.Drawing.Point(110, 45);
            this.textBox_FigSlope_Xpitch.Name = "textBox_FigSlope_Xpitch";
            this.textBox_FigSlope_Xpitch.Size = new System.Drawing.Size(60, 19);
            this.textBox_FigSlope_Xpitch.TabIndex = 39;
            // 
            // textBox_FigSlope_Boxcar
            // 
            this.textBox_FigSlope_Boxcar.Location = new System.Drawing.Point(110, 70);
            this.textBox_FigSlope_Boxcar.Name = "textBox_FigSlope_Boxcar";
            this.textBox_FigSlope_Boxcar.Size = new System.Drawing.Size(60, 19);
            this.textBox_FigSlope_Boxcar.TabIndex = 39;
            this.textBox_FigSlope_Boxcar.Text = "2e-3";
            this.textBox_FigSlope_Boxcar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox_FigSlope_Interval
            // 
            this.textBox_FigSlope_Interval.Location = new System.Drawing.Point(110, 95);
            this.textBox_FigSlope_Interval.Name = "textBox_FigSlope_Interval";
            this.textBox_FigSlope_Interval.Size = new System.Drawing.Size(60, 19);
            this.textBox_FigSlope_Interval.TabIndex = 39;
            this.textBox_FigSlope_Interval.Text = "1e-3";
            this.textBox_FigSlope_Interval.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(176, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 12);
            this.label3.TabIndex = 40;
            this.label3.Text = "[m]";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(176, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 12);
            this.label4.TabIndex = 40;
            this.label4.Text = "[m]";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(176, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 12);
            this.label5.TabIndex = 40;
            this.label5.Text = "[m]";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(51, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 41;
            this.label7.Text = "移動平均";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(75, 98);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 41;
            this.label8.Text = "間隔";
            // 
            // button_FigSlope_Output
            // 
            this.button_FigSlope_Output.Location = new System.Drawing.Point(120, 149);
            this.button_FigSlope_Output.Name = "button_FigSlope_Output";
            this.button_FigSlope_Output.Size = new System.Drawing.Size(75, 23);
            this.button_FigSlope_Output.TabIndex = 42;
            this.button_FigSlope_Output.Text = "データ出力";
            this.button_FigSlope_Output.UseVisualStyleBackColor = true;
            this.button_FigSlope_Output.Click += new System.EventHandler(this.button_FigSlope_Output_Click);
            // 
            // textBox_Log
            // 
            this.textBox_Log.Location = new System.Drawing.Point(12, 221);
            this.textBox_Log.Multiline = true;
            this.textBox_Log.Name = "textBox_Log";
            this.textBox_Log.Size = new System.Drawing.Size(222, 134);
            this.textBox_Log.TabIndex = 43;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 376);
            this.Controls.Add(this.textBox_Log);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.zedGraphControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage_CosSinTrans.ResumeLayout(false);
            this.tabPage_CosSinTrans.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ZedGraph.ZedGraphControl zedGraphControl1;
        private System.Windows.Forms.TextBox tB_CosSinTrans_FitOrder;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox cB_CosSinTrans_FitQuadra;
        private System.Windows.Forms.Button button_CosSinTrans_Output;
        private System.Windows.Forms.Button button_CosSinTrans_FitRun;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_CosSinTrans_ofd;
        private System.Windows.Forms.TextBox tB_CosSinTrans_ofdPath;
        private System.Windows.Forms.RadioButton rB_CosSinTrans_FitSin;
        private System.Windows.Forms.RadioButton rB_CosSinTrans_FitCos;
        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.SaveFileDialog sfd;
        private System.Windows.Forms.CheckBox cB_CosSinTrans_OutF;
        private System.Windows.Forms.CheckBox cB_CosSinTrans_ModData;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage_CosSinTrans;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.CheckBox checkBox_FigSlope_noX;
        private System.Windows.Forms.Button button_FigSlope_Run;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_FigSlope_ofd;
        private System.Windows.Forms.Button button_FigSlope_ofd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_FigSlope_Interval;
        private System.Windows.Forms.TextBox textBox_FigSlope_Boxcar;
        private System.Windows.Forms.TextBox textBox_FigSlope_Xpitch;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button_FigSlope_Output;
        private System.Windows.Forms.TextBox textBox_Log;
    }
}

