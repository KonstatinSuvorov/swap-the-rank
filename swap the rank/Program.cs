using System;
using System.ComponentModel;
/*
Пользователь вводит шестизначное число. После чего
пользователь вводит номера разрядов для обмена цифр.
Например, если пользователь ввёл один и шесть — это
значит, что надо обменять местами первую и шестую
цифры.
Число 723895 должно превратиться в 523897.
Если пользователь ввел не шестизначное число тре-
буется вывести сообщение об ошибке.*/

namespace swap_the_rank
{
    internal class Program
    { 
        static void Main(string[] args)
        {
            char[] c = new char[6];
            Console.Write("Введите шестизначное число: ");
            string num=Console.ReadLine();
             c = num.ToCharArray();
            
            

            Console.WriteLine("\nВведите номера разрядов которые надо поменять");

            int a = Convert.ToInt32(Console.ReadLine())-1;
            int b = Convert.ToInt32(Console.ReadLine())-1;
            char x;
            x = c[b];        //тут можно как то проще,
            c[b] = c[a];     //но чего-то не допонял
            c[a] = x;
            foreach (char c2 in c)
            {
                Console.Write(c2);
            }
            Console.ReadLine();
        }
    }
}
