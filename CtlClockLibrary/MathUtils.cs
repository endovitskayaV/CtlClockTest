using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathUtilsLib
{
   static class MathUtils
    {
        public static double GradToRadian(double angleGrad)
        {
            return angleGrad * (Math.PI / 180);
        }
    }
}
