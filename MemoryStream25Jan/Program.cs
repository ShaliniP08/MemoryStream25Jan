using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryStream25Jan
{
    class Program
    {
        static void MemoryStreamFunction()
        {
            try
            {
                byte[] file = File.ReadAllBytes("E:\\DP.png"); //Read all bytes in from a file
                using (MemoryStream memory = new MemoryStream(file)) //Create a memory stream from those bytes
                {
                    memory.Seek(0, SeekOrigin.Begin);
                    file = new byte[memory.Length];
                    var count = memory.Read(file, 0, 20);
                    while ((count = memory.ReadByte()) >= 0)
                    {
                        Console.WriteLine(Convert.ToChar(count));
                    }
                    Console.WriteLine("End of reading characters");
                    Console.WriteLine("Capacity = {0}\n", memory.Capacity.ToString());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        static void Main(string[] args)
        {
            MemoryStreamFunction();
            Console.ReadLine();
        }
    }
}
