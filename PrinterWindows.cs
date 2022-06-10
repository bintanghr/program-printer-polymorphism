using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelecPrinter
{
    public class PrinterWindows
    {
        //public string Name { get; set; }
        public virtual void Show()
        {
            Console.WriteLine("Printing..");
        }
        public virtual void Print()
        {

        }
    }
    public class Epson : PrinterWindows
    {
        public override void Show()
        {
            Console.WriteLine("Epson display dimension : 10*11");
        }
        public override void Print()
        {
            
            Console.WriteLine("Epson printer printing....");
        }
    }
    public class Canon : PrinterWindows
    {
        public override void Show()
        {
            Console.WriteLine("Canon display dimension : 9.5*12");
        }
        public override void Print()
        {
            Console.WriteLine("Canon printer printing....");
        }
    }
    public class LaserJet : PrinterWindows
    {
        public override void Show()
        {
            Console.WriteLine("LaserJet display dimension : 12*12");
        }
        public override void Print()
        {
            Console.WriteLine("LaserJet printer printing....");
        }
    }
}
;