using Lab1.BussinessLogic.Metrics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1.UI
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            #region magic
            //bool[] qweqwe = { true, false };
            //int[] foo = qweqwe.Select(qw => Convert.ToInt32(qw)).ToArray();
            //int[] bar = { 0, 1, 0, 0, 1, 2, 0, 1 };
            //bool ans = false;
            //int i = bar.FirstOrDefault(b => Convert.ToBoolean(b).ToString() == true.GetType().Name);

            //var act = new int[] { 0, 1, 0, 1, 0 };
            //var exp = new int[] { 1, 1, 1, 1, 0 };

            //var fmeasure = new FMeasure();
            //var f = fmeasure.CalculateQuality(act, exp);

            //var stop = true;
            #endregion
        }
    }
}
