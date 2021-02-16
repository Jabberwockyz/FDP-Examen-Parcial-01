using System;

namespace Examen_Parcial
{
    class Program
    {
        static void Main(string[] args)
        {
            int Banco;
            int B1000 = 18;
            int B500 = 19;
            int B200 = 23;
            int B100 = 50;
            int RetB1000, RetB500, RetB200, RetB100;

            do
            {
                Console.WriteLine("Cajero Automático de FDP INVERSMENTS");
                Console.WriteLine();
                Console.WriteLine("Porfavor elija la opción que desee utilizar.");
                Console.WriteLine();
                Console.WriteLine("1 - FDP INVERSMENTS");
                Console.WriteLine("2 - Salir");
                Banco = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                int Ret;
                int YN = 0;
                if (Banco != 2)
                {
                    do
                    {
                        Console.WriteLine("Introduzca el monto que desea retirar:");
                        Ret = Convert.ToInt32(Console.ReadLine());
                        if (Ret > 20000)
                        {
                            YN = 1;
                            Console.Clear();
                            Console.WriteLine("El monto solicitado excede el límite de transacción.");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        if (Ret < 10000)
                        {
                            YN = 1;
                            Console.Clear();
                            Console.WriteLine("El monto solicitado es menor al mínimo permitido.");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        if (Ret >= 10000 && Ret <= 20000)
                        {
                            Console.Clear();
                            RetB1000 = Ret / 1000;
                            if (RetB1000 <= B1000)
                            {
                                int Rest1 = Ret %= 1000;
                                B1000 = B1000 - RetB1000;
                                if (Rest1 == 0)
                                {
                                    Console.WriteLine("Billetes de 1000 dispensados: " + RetB1000);
                                }
                                else
                                {
                                    int Ret2 = Ret - (B1000 * 1000);
                                    RetB1000 = B1000;
                                    RetB500 = Ret2 / 500;
                                    int Rest2;
                                    if (RetB500 <= B500)
                                    {
                                        Rest2 = Ret2 %= 500;
                                        if (Rest2 == 0)
                                        {
                                            B500 = B500 - RetB500;
                                            B1000 = B1000 - RetB1000;
                                            Console.WriteLine("Billetes de 1000 dispensados: " + RetB1000);
                                            Console.WriteLine("Billetes de 500 dispensados: " + RetB500);
                                        }
                                        else
                                        {
                                            RetB200 = Rest2 / 200;
                                            int Rest3 = Rest2 %= 200;
                                            if (Rest3 == 0)
                                            {
                                                Console.WriteLine("Billetes de 1000 dispensados: " + RetB1000);
                                                Console.WriteLine("Billetes de 500 dispensados: " + RetB500);
                                                Console.WriteLine("Billetes de 200 dispensados: " + RetB200);
                                            }
                                            else
                                            {
                                                RetB100 = Rest3 / 100;
                                                int Rest4 = Rest3 %= 100;
                                                if (Rest4 == 0)
                                                {
                                                    Console.WriteLine("Billetes de 1000 dispensados: " + RetB1000);
                                                    Console.WriteLine("Billetes de 500 dispensados: " + RetB500);
                                                    Console.WriteLine("Billetes de 200 dispensados: " + RetB200);
                                                    Console.WriteLine("Billetes de 100 dispensados: " + RetB100);
                                                }
                                                else
                                                {
                                                    RetB100++;
                                                    Console.WriteLine("Billetes de 1000 dispensados: " + RetB1000);
                                                    Console.WriteLine("Billetes de 500 dispensados: " + RetB500);
                                                    Console.WriteLine("Billetes de 200 dispensados: " + RetB200);
                                                    Console.WriteLine("Billetes de 100 dispensados: " + RetB100);
                                                }
                                            }
                                        }
                                    }
                                    else
                                    {
                                        int Ret3 = Ret2 - (B500 * 500);
                                        RetB500 = B500;
                                        RetB200 = Ret3 / 200;
                                        int Rest3;
                                        if (RetB200 <= B200)
                                        {
                                            Rest3 = Ret3 %= 500;
                                            if (Rest3 == 0)
                                            {
                                                B500 = B500 - RetB500;
                                                B1000 = B1000 - RetB1000;
                                                B200 = B200 - RetB200;
                                                Console.WriteLine("Billetes de 1000 dispensados: " + RetB1000);
                                                Console.WriteLine("Billetes de 500 dispensados: " + RetB500);
                                                Console.WriteLine("Billetes de 200 dispensados: " + RetB200);
                                            }
                                        }
                                        else
                                        {
                                            int Ret4 = Ret3 - (B200 * 200);
                                            RetB200 = B200;
                                            RetB100 = Ret4 / 100;
                                            int Rest4;
                                            if (RetB100 <= B100)
                                            {
                                                Rest4 = Ret4 %= 200;
                                                if (Rest4 == 0)
                                                {
                                                    B500 = B500 - RetB500;
                                                    B1000 = B1000 - RetB1000;
                                                    B200 = B200 - RetB200;
                                                    B100 = B100 - RetB100;
                                                    Console.WriteLine("Billetes de 1000 dispensados: " + RetB1000);
                                                    Console.WriteLine("Billetes de 500 dispensados: " + RetB500);
                                                    Console.WriteLine("Billetes de 200 dispensados: " + RetB200);
                                                    Console.WriteLine("Billetes de 200 dispensados: " + RetB100);
                                                }
                                            }
                                            else
                                            {
                                                Console.WriteLine("No se pudo completar su retiro, porfavor acuda a otro cajero.");
                                            }
                                        }

                                    }
                                }
                            }
                            else
                            {
                                int Ret2 = Ret - (B1000 * 1000);
                                RetB1000 = B1000;
                                RetB500 = Ret2 / 500;
                                int Rest2;
                                if (RetB500 <= B500)
                                {
                                    Rest2 = Ret2 %= 500;
                                    if (Rest2 == 0)
                                    {
                                        B500 = B500 - RetB500;
                                        B1000 = B1000 - RetB1000;
                                        Console.WriteLine("Billetes de 1000 dispensados: " + RetB1000);
                                        Console.WriteLine("Billetes de 500 dispensados: " + RetB500);
                                    }
                                    else
                                    {
                                        RetB200 = Rest2 / 200;
                                        int Rest3 = Rest2 %= 200;
                                        if (Rest3 == 0)
                                        {
                                            Console.WriteLine("Billetes de 1000 dispensados: " + RetB1000);
                                            Console.WriteLine("Billetes de 500 dispensados: " + RetB500);
                                            Console.WriteLine("Billetes de 200 dispensados: " + RetB200);
                                        }
                                        else
                                        {
                                            RetB100 = Rest3 / 100;
                                            int Rest4 = Rest3 %= 100;
                                            if (Rest4 == 0)
                                            {
                                                Console.WriteLine("Billetes de 1000 dispensados: " + RetB1000);
                                                Console.WriteLine("Billetes de 500 dispensados: " + RetB500);
                                                Console.WriteLine("Billetes de 200 dispensados: " + RetB200);
                                                Console.WriteLine("Billetes de 100 dispensados: " + RetB100);
                                            }
                                            else
                                            {
                                                RetB100++;
                                                Console.WriteLine("Billetes de 1000 dispensados: " + RetB1000);
                                                Console.WriteLine("Billetes de 500 dispensados: " + RetB500);
                                                Console.WriteLine("Billetes de 200 dispensados: " + RetB200);
                                                Console.WriteLine("Billetes de 100 dispensados: " + RetB100);
                                            }
                                        }
                                    }
                                }
                                else
                                {
                                    int Ret3 = Ret2 - (B500 * 500);
                                    RetB500 = B500;
                                    RetB200 = Ret3 / 200;
                                    int Rest3;
                                    if (RetB200 <= B200)
                                    {
                                        Rest3 = Ret3 %= 500;
                                        if (Rest3 == 0)
                                        {
                                            B500 = B500 - RetB500;
                                            B1000 = B1000 - RetB1000;
                                            B200 = B200 - RetB200;
                                            Console.WriteLine("Billetes de 1000 dispensados: " + RetB1000);
                                            Console.WriteLine("Billetes de 500 dispensados: " + RetB500);
                                            Console.WriteLine("Billetes de 200 dispensados: " + RetB200);
                                        }
                                    }
                                    else
                                    {
                                        int Ret4 = Ret3 - (B200 * 200);
                                        RetB200 = B200;
                                        RetB100 = Ret4 / 100;
                                        int Rest4;
                                        if (RetB100 <= B100)
                                        {
                                            Rest4 = Ret4 %= 200;
                                            if (Rest4 == 0)
                                            {
                                                B500 = B500 - RetB500;
                                                B1000 = B1000 - RetB1000;
                                                B200 = B200 - RetB200;
                                                B100 = B100 - RetB100;
                                                Console.WriteLine("Billetes de 1000 dispensados: " + RetB1000);
                                                Console.WriteLine("Billetes de 500 dispensados: " + RetB500);
                                                Console.WriteLine("Billetes de 200 dispensados: " + RetB200);
                                                Console.WriteLine("Billetes de 200 dispensados: " + RetB100);
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine("No se pudo completar su retiro, porfavor acuda a otro cajero.");
                                        }
                                    }

                                }
                            }
                            Console.ReadKey();
                            Console.Clear();
                        }
                    } while (YN != 0);
                }
            } while (Banco != 2);
        }
    }
}
