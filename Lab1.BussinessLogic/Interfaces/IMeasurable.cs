using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.BussinessLogic.Interfaces
{
    public interface IMeasurable
    {
        double CalculateQuality(int[] actual, int[] expected);
    }
}
