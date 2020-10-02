using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    public abstract class Shape
    {
        public abstract void GetNumberofCorners();
    }

    public class Pentagon : Shape
    {
       /*
        * Method : GetNumberofCorners
        * Output Parameter : Write the output
        */
       public override void GetNumberofCorners()
       {    
            Console.WriteLine("Pentagon has five corners.");
       }

       static void Main(string[] args)
       {
            Pentagon objPentagon = new Pentagon();                
            objPentagon.GetNumberofCorners();
       }
    }
}
