using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

delegate int ChangeNumber(int n);

namespace DelegateDemo2
{


    public class PrintString
    {
        public static FileStream fs;
        public static StreamWriter sw;

        public delegate void print_string(string s);

        public static void WriteToScrenn(string str)
        {
            Console.WriteLine("Das string ist  {0} " ,str);
        }

        public static void WriteToFile(string s)
        {
            fs = new FileStream(@"C:\Users\sadok\Documents\Visual Studio 2015\Projects\Console\DelegateDemo2\test.txt",FileMode.Append,FileAccess.Write);
            sw = new StreamWriter(fs);
            sw.WriteLine(s);
            sw.Flush();
            sw.Close();
            fs.Close();

        }
        // this method takes the delegate as parameter and uses it tocall the methods as required
        public static void SendString(print_string ps)
        {
            ps("Hello word");
        }
    }
    class TestDelegate
    {
        public static int n = 10;

        public static int AddNum(int p)
        {
            return n += p;
        }

        public static int MulNum(int q)
        {
            return n *= q;
        }

        public static int  GetNum()
        {
            return n;
        }

        static void Main(string[] args)
        {
            //create delegate instances
            ChangeNumber NC1 = new ChangeNumber(AddNum);
            ChangeNumber NC2 = new ChangeNumber(MulNum);

            //calling the methods using the delegate objects
            NC1(5);
            Console.WriteLine("Value of Num {0}",GetNum());

            NC2(10);
            Console.WriteLine("Value of Num {0}",GetNum());

            //##################################################################

            PrintString.print_string ps1 = new PrintString.print_string(PrintString.WriteToScrenn);
            PrintString.print_string ps2 = new PrintString.print_string(PrintString.WriteToFile);

            PrintString.SendString(ps1);
            PrintString.SendString(ps2);

            Console.ReadKey();
        }
    }
}
