﻿using System;

namespace ConsoleApplication
{
    public class Program
    {
    	//Задача 5 про четность

    	//Даны три целых числа A, B, C. Определить, есть ли среди них хотя бы одно четное и хотя бы одно нечетное.

		//Входные данные
		//Числа A, B, C, не превышающие по модулю 10000.

		//Выходные данные
		//Одна строка – "ДА" или "НЕТ".

		//Примеры
		//входные данные
		//3
		//4
		//5
		//выходные данные
		//ДА
		

		//входные данные
		//7
		//7
		//7
		//выходные данные
		//НЕТ
        public static void Main(string[] args)
        {
			Console.OutputEncoding = System.Text.Encoding.Unicode;
        	Console.InputEncoding = System.Text.Encoding.Unicode;
            Console.WriteLine("Hello World!");

			Console.WriteLine("Задача №1. Четность");
			int a, b, c, k;
			Console.WriteLine("Введите три целых числа A, B, C");
			a = int.Parse(Console.ReadLine());
			b = int.Parse(Console.ReadLine());
			c = int.Parse(Console.ReadLine());
			

        }
    }
}