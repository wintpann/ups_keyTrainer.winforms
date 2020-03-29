using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace keyTrainer
{
    static class Colors
    {
        public static readonly Color LR1;
        public static readonly Color L5;
        public static readonly Color L4;
        public static readonly Color L3;
        public static readonly Color L2;
        public static readonly Color R2;
        public static readonly Color R3;
        public static readonly Color R4;
        public static readonly Color R5;
        public static readonly Color ButtonStandard;
        static Colors()
        {
            LR1 = Color.FromArgb(127, 0, 0);
            L5 = Color.FromArgb(0, 148, 255);
            L4 = Color.FromArgb(76, 255, 0);
            L3 = Color.FromArgb(255, 106, 0);
            L2 = Color.FromArgb(255, 216, 0);
            R2 = Color.FromArgb(0, 255, 33);
            R3 = Color.FromArgb(0, 255, 255);
            R4 = Color.FromArgb(255, 216, 0);
            R5 = Color.FromArgb(255, 106, 0);
            ButtonStandard = Color.FromArgb(35, 35, 50);
        }
    }
}
