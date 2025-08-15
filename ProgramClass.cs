using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PublishingHouseClient2
{
    internal class ProgramClass
    {
        public static void FloatNumbersCheck(KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58)
                && number != 8
                && number != 44)
            {
                e.Handled = true;
            }
        }
        public static void IntNumbersCheck(KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58)
                && number != 8)
            {
                e.Handled = true;
            }
        }

        public static void SimbolsOnlyCheck(KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsLetter(e.KeyChar) && number != 8 && number != 32 && number != 45)
            {
                e.Handled = true;
            }
        }
    }
}
