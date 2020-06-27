using System;

namespace OOP1._1
{
    class Program
    {
        class pokupatel
        {
            public string FAMILIA;
            public string IM9;
            public string OT4ESTVO;
            internal string NOMERkrcart;
            internal string NOMERbankc4et;

        }
        static void Main(string[] args)
        {
            pokupatel clas = new pokupatel();
            Console.Write("Введите фамилию: ");
            clas.FAMILIA = Convert.ToString(Console.ReadLine());

            Console.Write("Введите имя: ");
            clas.IM9 = Convert.ToString(Console.ReadLine());

            Console.Write("Введите отчество: ");
            clas.OT4ESTVO = Convert.ToString(Console.ReadLine());

            Console.Write("Введите номер кредитной карты: ");
            clas.NOMERkrcart = Convert.ToString(Console.ReadLine());

            Console.Write("Введите номер банковского счета: ");
            clas.NOMERbankc4et = Convert.ToString(Console.ReadLine());

            Console.WriteLine("_____________________________");
            Console.WriteLine(clas.FAMILIA + " " + clas.IM9 + " " + clas.OT4ESTVO + " " + clas.NOMERkrcart + " "+ clas.NOMERbankc4et);
            Console.ReadLine();
        }
    }
}
