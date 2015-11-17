using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Math;

namespace ClsNac.Transform
{
    static class DFT
    {
        /// <summary>
        /// discrete cosine trans
        /// </summary>
        /// <param name="f"></param>
        /// <returns></returns>
        public static double[] DCT(double[] f)
        {
            
            int N = f.Length;
            double[] F = new double[N];
            for (int u = 0; u < N; u++)
            {
                F[u] = 0.0;
                for (int n = 0; n < N; n++)
                {
                    F[u] +=  f[n] * Cos(PI * u * (2.0 * n + 1) / (2.0 * N));
                    f[n] -= f[n] * Cos(PI * u * (2.0 * n + 1) / (2.0 * N));
                }
                F[u] *= 2.0 / N * C(u);
            }
            return F;
        }

        public static double[] iDCT(double[] F, int NN = 0)
        {
            int N = F.Length;
            double[] f = new double[N];
            NN = NN == 0 ? N : NN;

            for (int n = 0; n < N; n++)
            {
                f[n] = 0.0;
                for (int u = 0; u < NN; u++)
                {
                    f[n] += C(u) * F[u] * Cos(PI * u * (2.0 * n + 1) / (2.0 * N));
                }
            }
            return f;

        }

        static double C(int p)
        {
            return p == 0 ? 1.0 / Sqrt(2.0) : 1.0;
        }


        /// <summary>
        /// discrete sine trans
        /// </summary>
        /// <param name="f"></param>
        /// <returns></returns>
        public static double[] DST(double[] f)
        {
            
            int N = f.Length;
            double[] F = new double[N];
            for (int u = 0; u < N; u++)
            {
                F[u] = 0.0;
                for (int n = 0; n < N; n++)
                {
                    F[u] += f[n] * Sin(PI * (n + 1.0) * (u + 1.0) / (N + 1.0));
                }
                F[u] *= 2.0 / (N + 1.0);
            }
            return F;
        }

        public static double[] iDST(double[] F, int NN = 0)
        {
            int N = F.Length;
            double[] f = new double[N];
            NN = NN == 0 ? N : NN;

            for (int n = 0; n < N; n++)
            {
                f[n] = 0.0;
                for (int u = 0; u < NN; u++)
                {
                    f[n] += F[u] * Sin(PI * (n + 1.0) * (u + 1.0) / (N + 1.0));
                }
            }
            return f;

        }

    }
}
