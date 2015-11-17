using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Math;

namespace DataProcessing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        int N1;
        int N2;
        double[] readData1;
        double[,] readData2;
        double[] data1;
        double[,] data2;
        double[] result1;
        double[,] result2;

        #region フィルタ
        double[] F;

        private void button_ofd_Click(object sender, EventArgs e)
        {
            if(this.ofd.ShowDialog()==DialogResult.OK)
            {
                this.tB_CosSinTrans_ofdPath.Text = this.ofd.FileName;
                ClsNac.FileIO.FileIO.readFile(this.ofd.FileName, ref this.readData1);
            }
        }

        private void button_Fit_Run_Click(object sender, EventArgs e)
        {
            data1 = Fit0n(readData1);
            
            //二次関数フィット
            //最初と最後がゼロになるように傾ける


            this.F = ClsNac.Transform.DFT.DST(data1);
            this.result1 = ClsNac.Transform.DFT.iDST(this.F, Convert.ToInt32(this.tB_CosSinTrans_FitOrder.Text));
        }

        static double[] Fit0n(double[] y)
        {
            int N = y.Length;
            

            double[] result = new double[N];

            double[] xx = new double[] { 0.0, N - 1.0 };
            double[] yy = new double[] { y[0], y[N - 1] };
            var fitcoef = MathNet.Numerics.Fit.Line(xx, yy);

            for (int i = 0; i < N; i++)
                result[i] = y[i] - fitcoef.Item2 * i - y[0];

            return result;
        }

        private void button_Fit_Output_Click(object sender, EventArgs e)
        {
            if(this.sfd.ShowDialog()==DialogResult.OK)
            {
                ClsNac.FileIO.FileIO.writeFile(this.sfd.FileName, this.result1);
            }
            if (this.cB_CosSinTrans_OutF.Checked && this.sfd.ShowDialog() == DialogResult.OK)
            {
                ClsNac.FileIO.FileIO.writeFile(this.sfd.FileName, this.F);
            }
            if (this.cB_CosSinTrans_ModData.Checked && this.sfd.ShowDialog() == DialogResult.OK)
            {
                ClsNac.FileIO.FileIO.writeFile(this.sfd.FileName, this.data1);
            }

        }
        #endregion



        private void button_FigSlope_ofd_Click(object sender, EventArgs e)
        {
            if (this.ofd.ShowDialog() == DialogResult.OK)
            {
                ClsNac.FileIO.FileIO.readFile(this.ofd.FileName, ref readData2);
                N1 = readData2.GetLength(0);
                N2 = readData2.GetLength(1);
                this.textBox_FigSlope_ofd.Text = this.ofd.FileName;
            }
        }

        private void button_FigSlope_Run_Click(object sender, EventArgs e)
        {
            #region X座標設定
            double[] readDataX = new double[N2];
            if (this.checkBox_FigSlope_noX.Checked)
            {
                //読込データにX座標が含まれていない場合
                double xPitch;
                if (!Double.TryParse(this.textBox_FigSlope_Xpitch.Text, out xPitch))
                { throw new ArgumentException(""); }

                for (int j = 0; j < N2; j++)
                { readDataX[j] = j * xPitch; }
            }
            else
            {
                //読込データにX座標が含まれている場合
                for (int j = 0; j < N2; j++)
                    readDataX[j] = readData2[0, j];

                N1--;
                double[,] subReadData2 = (double[,])readData2.Clone();
                readData2 = new double[N1, N2];
                Array.Copy(subReadData2, N2, readData2, 0, N2 * N1);
            }
            #endregion

            //スロープ計算
            double[,] slope = new double[N1, N2];
            for (int i = 0; i < N1; i++)
            {
                for (int j = 0; j < N2 - 1; j++)
                {
                    slope[i, j] = (readData2[i, j + 1] - readData2[i, j]) / (readDataX[j + 1] - readDataX[j]);
                }
                slope[i, N2 - 1] = slope[i, N2 - 2];
            }

            //移動平均
            //X座標設定
            double boxcar = Convert.ToDouble(this.textBox_FigSlope_Boxcar.Text);
            double interval = Convert.ToDouble(this.textBox_FigSlope_Interval.Text);

            int N3 = (int)((readDataX[N2 - 1] - readDataX[0]) / interval) - 1;
            result2 = new double[N1 + 1, N3];
            double[] RMS = new double[N1];

            for (int m = 0; m < N3; m++)
            {
                int count = 0;

                //slopeBoxcarのX座標
                result2[0, m] = interval * (m + 1);

                for (int j = 0; j < N2; j++)
                {
                    if (interval * (m + 1.0) - boxcar / 2.0 <= readDataX[j]
                        && readDataX[j] <= interval * (m + 1.0) + boxcar / 2.0)
                    {
                        for (int i = 0; i < N1; i++)
                        {
                            result2[i + 1, m] += slope[i, j];
                        }
                        count++;

                    }
                    if (interval * (m + 1) + boxcar / 2.0 < readDataX[j])
                    { break; }
                }
                for (int i = 0; i < N1; i++)
                {
                    result2[i + 1, m] /= (double)count;
                    RMS[i] += Pow(result2[i + 1, m], 2.0);
                }
                
            }
            for (int i = 0; i < N1; i++)
            {
                RMS[i] = Sqrt(RMS[i] / N3);
                this.textBox_Log.Text += RMS[i].ToString() + "\r\n";
            }
        }

        private void button_FigSlope_Output_Click(object sender, EventArgs e)
        {
            if(this.sfd.ShowDialog()==DialogResult.OK)
            {
                ClsNac.FileIO.FileIO.writeFile(this.sfd.FileName, result2);
            }
        }
    }
}
