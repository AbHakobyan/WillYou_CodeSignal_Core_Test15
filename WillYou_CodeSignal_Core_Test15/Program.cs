using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WillYou_CodeSignal_Core_Test15
{
    class Program
    {
        static void Main(string[] args)
        {
            bool young = true;
            bool beautiful = false;
            bool loved = true;
            Console.WriteLine(WillYou(young,beautiful,loved));
        }

        static bool WillYou(bool young, bool beautiful, bool loved)
        {
            if (young == true && beautiful == false && loved == true)
            {
                return true;
            }
            else if (young == false && beautiful == false && loved == true)
            {
                return true;
            }
            else if (young == false && beautiful == true && loved == true)
            {
                return true;
            }
            else if (young == true && beautiful == true && loved == false)
            {
                return true;
            }
            else
            {
                return false;
            }
            return false;

        }
    }
}
