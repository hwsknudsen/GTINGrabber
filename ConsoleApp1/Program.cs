using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1
{
    class Program { 
        [STAThread]

        static void Main(string[] args)
        {
            Console.WriteLine("Scan Barcode:"); // Prompt
            while (true) // Loop indefinitely
            {
                string line = Console.ReadLine(); // Get string from user
                Console.Clear();
                if (line == "exit") // Check string
                {
                    break;
                }
                Console.Write("You Scanned: "); // Report output
                Console.Write(line);
                Console.WriteLine();

                try { 
                    int gtin = line.IndexOf("01");
                    string gtinstr = line.Substring(gtin + 2, 14);
                    Console.WriteLine("Found GTIN: " + gtinstr);
                    Console.WriteLine("Has been Copied to clipbaord");
                    Console.WriteLine();
                    Clipboard.SetText(gtinstr);
                }
                catch
                {
                    Console.WriteLine("NO GTIN!!!!!!!!!!");
                    Console.WriteLine("Scanned Code been Copied to clipbaord");
                    Console.WriteLine();
                    Clipboard.SetText(line);
                }



                // Console.Write(line.Length);
                //Console.WriteLine(" character(s)");
                Console.WriteLine("Scan Barcode:"); // Prompt

            }
        }
    }
}
