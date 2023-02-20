using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.ForegroundColor = ConsoleColor.DarkMagenta;

            Console.ForegroundColor = ConsoleColor.Green;
            {
                Console.WriteLine("Числовые типы:");
                Console.WriteLine("");
            }

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine($"Тип: byte | Тип данных: Мин.значение: {typeof(byte)} | Мин.значение: {byte.MinValue} | Макс.значение: {byte.MaxValue} | Количество байт: {sizeof(byte)} ");
            Console.WriteLine($"Тип: int | Тип данных: {typeof(int)} | Мин.значение: {int.MinValue} | Макс.значение: {int.MaxValue} | Количество байт: {sizeof(int)} ");
            Console.WriteLine($"Тип: decimal | Тип данных: {typeof(decimal)} | Мин.значение: {decimal.MinValue} | Макс.значение: {decimal.MaxValue} | Количество байт: {sizeof(decimal)} ");
            Console.WriteLine($"Тип: sbyte | Тип данных: {typeof(sbyte)} | Мин.значение: {sbyte.MinValue}  | Макc.значение:  {sbyte.MaxValue}  | Количество байт:  {sizeof(sbyte)} ");
            Console.WriteLine($"Тип: uint | Тип данных: {typeof(uint)} | Мин. значение: {uint.MinValue}  | Макс.значение:  {uint.MaxValue}  | Количество байт:  {sizeof(uint)} ");
            Console.WriteLine($"Тип: short | Тип данных: {typeof(short)} | Мин.значение: {double.MinValue} | Макс.значение: {double.MaxValue} | Количество байт: {sizeof(double)} ");
            Console.WriteLine($"Тип: double | Тип данных: {typeof(double)} | Мин.значение: {double.MinValue} | Макс.значение: {double.MaxValue} | Количество байт: {sizeof(double)} ");
            Console.WriteLine($"Тип: ushort | Тип данных: {typeof(ushort)}  | Мин.значение:  {ushort.MinValue} | Макс.значение: {ushort.MaxValue} | Количество байт: {sizeof(ushort)} ");
            Console.WriteLine($"Тип: float | Тип данных: {typeof(float)} | Мин.значение: {float.MinValue} | Макс.значение: {float.MaxValue} | Количество байт: {sizeof(float)} ");
            Console.WriteLine($"Тип: long | Тип данных: {typeof(ulong)} | Мин.значение: {ulong.MinValue} | Макс.значение: {ulong.MaxValue} | Количество байт: {sizeof(ulong)} ");
            Console.WriteLine($"Тип: ulong | Тип данных: {typeof(ulong)} | Мин.значение: {ulong.MinValue} | Макс.значение: {ulong.MaxValue} | Количество байт: {sizeof(ulong)} ");

            Console.WriteLine("");
            Console.WriteLine("Символьные типы:");
            Console.WriteLine("");

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine($"Тип: char | Тип данных: {typeof(char)} | Мин.значение: {char.MinValue} | Макс.значение: {char.MaxValue} | Количество байт: {sizeof(char)} ");

            Console.ForegroundColor = ConsoleColor.Green;
            {
                Console.WriteLine("");
                Console.WriteLine("Логические типы:");
                Console.WriteLine("");
            }
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine($"Тип: bool | Тип данных: {typeof(bool)} | Мин.значение: False  | Макс.значение: True | Количество байт: {sizeof(bool)} ");

            
                Console.ForegroundColor = ConsoleColor.Green;
            { 
                Console.WriteLine("");
                Console.WriteLine("Особые типы:");
                Console.WriteLine("");
            }

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine($"Тип: object | Тип данных: {typeof(object)} | Мин.значение:  | Макс.значение:  | Количество байт:  ");

            Console.ForegroundColor = ConsoleColor.Green;
            {

                Console.WriteLine("");
                Console.WriteLine("Вывод веса сообщения:");
                Console.WriteLine("");
            }

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            string str = "Объект – категория, выражающая то, что противостоит субъекту в его предметно-практической и познавательной деятельности.";

            Console.WriteLine($" ASCII {Encoding.ASCII.GetByteCount(str)}");
            Console.WriteLine($" UTF-7 {Encoding.UTF7.GetByteCount(str)}");
            Console.WriteLine($" UTF-8 {Encoding.UTF8.GetByteCount(str)}");         
            Console.WriteLine($" UTF-32 {Encoding.UTF32.GetByteCount(str)}");


        }
    }
}
