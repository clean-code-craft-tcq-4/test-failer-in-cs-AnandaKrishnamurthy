using System;
using System.Diagnostics;
namespace MisalignedSpace
{
    class Misaligned
    {

        public  static IList<bool> Allignment_Result = new List<bool> { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false };
       
        static bool Check_For_Saparator_Allignment(IList<bool> Local_Allignment_Result)
        {
            return !Local_Allignment_Result.Contains(false);
        }
        static int printColorMap()
        {

            string Printable_String;
            string[] majorColors = { "White", "Red", "Black", "Yellow", "Violet" };
            string[] minorColors = { "Blue", "Orange", "Green", "Brown", "Slate" };
            int i = 0, j = 0;
            
            for (i = 0; i < 5; i++)
            {
                for (j = 0; j < 5; j++)
                {
                    Console.WriteLine("{0} | {1} | {2}", i * 5 + j, majorColors[i], minorColors[i]);
                    Printable_String = string.Format("{0} | {1} | {2}", i * 5 + j, majorColors[i], minorColors[i]);
  
                    if ((Printable_String.Substring(2,1) == "|") & (Printable_String.Substring(10,1) == "|"))
                        Allignment_Result[i * 5 + j]=true;
                    else
                        Allignment_Result[i * 5 + j] = false;
                }
            }
  
            return i * j;
            
        }
        static void Main(string[] args)
        {
            int result = printColorMap();
            Misaligned INST_Misaligned1 = new Misaligned();
            Debug.Assert(result == 25);
            Debug.Assert(Check_For_Saparator_Allignment(MisalignedSpace.Misaligned.Allignment_Result)== true);
            Console.WriteLine("All is well (maybe!)");
        }
    }
}
