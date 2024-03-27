using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Task9_1
{
    /*
     * Help for me
     * DivideByZeroException: представляет исключение, которое генерируется при делении на ноль
     * ArgumentOutOfRangeException: генерируется, если значение аргумента находится вне диапазона допустимых значений
     * ArgumentException: генерируется, если в метод для параметра передается некорректное значение
     * IndexOutOfRangeException: генерируется, если индекс элемента массива или коллекции находится вне диапазона допустимых значений
     * InvalidCastException: генерируется при попытке произвести недопустимые преобразования типов
     * NullReferenceException: генерируется при попытке обращения к объекту, который равен null (то есть по сути неопределен)
    */
    internal class Program
    {

        static void SetException(Exception exp)
        {
            try
            {
                throw exp;
            }
            catch (MyException myExp)
            {
                Console.WriteLine($"Исключение: {myExp.GetType()} - {myExp.Message}");
            }
            catch (ArgumentOutOfRangeException argOutRnExp)
            {
                Console.WriteLine($"Исключение: {argOutRnExp.GetType()} - {argOutRnExp.Message}");
            }
            catch (ArgumentException argExp)
            {
                Console.WriteLine($"Исключение: {argExp.GetType()} - {argExp.Message}");
            }
            catch (IndexOutOfRangeException indOutExp)
            {
                Console.WriteLine($"Исключение: {indOutExp.GetType()} - {indOutExp.Message}");
            }
            catch (InvalidCastException invCastExp)
            {
                Console.WriteLine($"Исключение: {invCastExp.GetType()} - {invCastExp.Message}");
            }
            finally
            {
                Console.WriteLine("");
            }
        }
        static void Main(string[] args)
        {
            try
            {
                Exception[] exceptionArray = {
                new MyException(),
                new ArgumentOutOfRangeException(),
                new ArgumentException(),
                new IndexOutOfRangeException(),
                new InvalidCastException()
            };

                foreach (Exception ex in exceptionArray)
                {
                    SetException(ex);
                }

                Console.ReadKey();
            }
            catch (Exception exp)
            {
                Console.WriteLine($"Исключение: {exp.GetType()} - {exp.Message}");
            }
            finally
            {
                Console.WriteLine("The End!");
            }

        }
    }
}
