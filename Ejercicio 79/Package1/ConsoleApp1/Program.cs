using System;

namespace InteresesBancarios
{
    class Program
    {
        static void Main(string[] args)
        {
            TarjetaDeCrédito tdc = new TarjetaDeCrédito(150);
            CuentaCorriente cc = new CuentaCorriente(300);
            CajaDeAhorro cda = new CajaDeAhorro(260);
            Interés i = new Interés();

            Console.WriteLine(tdc.Dinero);
            Console.WriteLine(cc.Dinero);
            Console.WriteLine(cda.Dinero);
            
            /* 
            
            i.visit(tdc);
            i.visit(cc);
            i.visit(cda);
            
            */
            
            tdc.accept(i);
            cc.accept(i);
            cda.accept(i);

            Console.WriteLine(tdc.Dinero);
            Console.WriteLine(cc.Dinero);
            Console.WriteLine(cda.Dinero);
        }
    }
}
