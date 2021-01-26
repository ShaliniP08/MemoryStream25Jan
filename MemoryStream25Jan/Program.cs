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
                    using (BinaryReader br = new BinaryReader(memory))
                    {
                        for (int i = 0; i < file.Length; i++)
                        {
                            byte result = br.ReadByte();
                            Console.WriteLine(result);
                        }

                        Console.WriteLine("End of reading characters");
                        Console.WriteLine("No. of characters = {0}\n", memory.Length.ToString());
                    }
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
