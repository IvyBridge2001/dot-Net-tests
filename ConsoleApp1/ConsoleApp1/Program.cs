using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DemoApplication
{
    internal class Tutorial
    {
        static void Main(string[] args)
        {

            using (StreamReader sr1 = File.OpenText(@"D:\Example.txt"))
            using (StreamWriter sr2 = File.AppendText(@"D:\Example.log"))
            {
                String s = "";

                while ((s = sr1.ReadLine()) != null)
                {
                    string[] temp = s.Split(", ");
                    sr2.WriteLine(temp[0]);
                    
                }
                sr2.Close();
            }
            
            Console.ReadKey();
        }
    }
}
