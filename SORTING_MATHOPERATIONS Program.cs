﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SORTING_MATHOPERATIONS
{
    class Program
    {
        void sortarray()
        {
            int size;
            int[] a = new int[50];
            Console.WriteLine("enter the size of array:");
            size = Int32.Parse(Console.ReadLine());
            Console.WriteLine("enter the elements to array:");
            for (int i = 0; i < size; i++)
            {
                Console.Write(a[i] + " ");
            }
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (a[j] > a[j + 1])
                    {
                        int temp = a[j + 1];
                        a[j + 1] = a[j];
                        a[j] = temp;
                    }
                }
            }
            Console.Write("\n after sorting:");
            for (int i = 0; i < size; i++)
                Console.Write(a[i] + " ");
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            Program p = new Program();



            int choice1,choice2, x, y, z;
            for (; ; )
            {
                Console.WriteLine("Enter choice");
                Console.WriteLine("1:Sorting of array\n2:Mathoperations(.dll)\n3:Mathoperations(.exe)");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("\n***SORTING***");
                        p.sortarray();
                        break;

                    case 2:
                        Console.WriteLine("\n***DLL***");
                        Console.WriteLine("1:Addition\n2:Subtraction\n3:Multiplication\n4:Division\n5:Modulus");
                        choice1 = Convert.ToInt32(Console.ReadLine());
                        switch (choice1)
                        {
                            case 1:
                                Console.WriteLine("\n**ADDITION**\n");
                                Console.WriteLine("enter the two values of addition:");
                                x = Convert.ToInt32(Console.ReadLine());
                                y = Convert.ToInt32(Console.ReadLine());
                                z = x + y;
                                Console.WriteLine(z);                                                         
                                Console.ReadLine();
                                break;

                            case 2:
                                Console.WriteLine("\n**SUBTRACTION**\n");
                                Console.WriteLine("enter the two values of subtraction:");
                                x = Convert.ToInt32(Console.ReadLine());
                                y = Convert.ToInt32(Console.ReadLine());
                                z = x - y;
                                Console.WriteLine(z);
                                Console.ReadLine();
                                break;

                            case 3:
                                Console.WriteLine("\n**MULTIPLICATION**\n");
                                Console.WriteLine("enter the two values of multiplication:");
                                x = Convert.ToInt32(Console.ReadLine());
                                y = Convert.ToInt32(Console.ReadLine());
                                z = x * y;
                                Console.WriteLine(z);
                                Console.ReadLine();
                                break;
                            case 4:
                                Console.WriteLine("\n**DIVISION**\n");
                                Console.WriteLine("enter the two values of division:");
                                x = Convert.ToInt32(Console.ReadLine());
                                y = Convert.ToInt32(Console.ReadLine());
                                z = x / y;
                                Console.WriteLine(z);
                                Console.ReadLine();
                                break;
                            case 5:
                                Console.WriteLine("\n**MODULUS**\n");
                                Console.WriteLine("enter the two values of modulus:");
                                x = Convert.ToInt32(Console.ReadLine());
                                y = Convert.ToInt32(Console.ReadLine());
                                z = x % y;
                                Console.WriteLine(z);
                                Console.ReadLine();
                                break;



                        }
                        break;

                    case 3:
                        Console.WriteLine("\n***EXE***");
                        Console.WriteLine("1:Addition\n2:Subtraction\n3:Multiplication\n4:Division\n5:Modulus");
                        choice2 = Convert.ToInt32(Console.ReadLine());
                        switch (choice2)
                        {
                            case 1:
                                Console.WriteLine("\n**ADDITION**\n");
                                Console.WriteLine("enter the two values of addition:");
                                x = Convert.ToInt32(Console.ReadLine());
                                y = Convert.ToInt32(Console.ReadLine());
                                z = x + y;
                                Console.WriteLine(z);
                                Console.ReadLine();
                                break;

                            case 2:
                                Console.WriteLine("\n**SUBTRACTION**\n");
                                Console.WriteLine("enter the two values of subtraction:");
                                x = Convert.ToInt32(Console.ReadLine());
                                y = Convert.ToInt32(Console.ReadLine());
                                z = x - y;
                                Console.WriteLine(z);
                                Console.ReadLine();
                                break;
                            case 3:
                                Console.WriteLine("\n**MULTIPLICATION**\n");
                                Console.WriteLine("enter the two values of multiplication:");
                                x = Convert.ToInt32(Console.ReadLine());
                                y = Convert.ToInt32(Console.ReadLine());
                                z = x * y;
                                Console.WriteLine(z);
                                Console.ReadLine();
                                break;
                            case 4:
                                Console.WriteLine("\n**DIVISION**\n");
                                Console.WriteLine("enter the two values of division:");
                                x = Convert.ToInt32(Console.ReadLine());
                                y = Convert.ToInt32(Console.ReadLine());
                                z = x / y;
                                Console.WriteLine(z);
                                Console.ReadLine();
                                break;
                            case 5:
                                Console.WriteLine("\n**MODULUS**\n");
                                Console.WriteLine("enter the two values of modulus:");
                                x = Convert.ToInt32(Console.ReadLine());
                                y = Convert.ToInt32(Console.ReadLine());
                                z = x % y;
                                Console.WriteLine(z);
                                Console.ReadLine();
                                break;


                        }
                        break;
                }
            }

        }
    }
}

