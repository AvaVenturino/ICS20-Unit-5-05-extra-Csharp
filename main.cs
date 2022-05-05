// Created by: Ava Venturino
// Created on: April 2022
//
// This program accepts user input

using System;

class Program
{
    public static void Main(string[] args)
    {
        int sideA;
        int sideB;
        int sideC;
        Console.Write("Check whether a triangle is Equilateral, Isosceles or Scalene:\n");
        Console.Write("Input side 1 of triangle: ");
        sideA = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input side 2 of triangle: ");
        sideB = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input side 3 of triangle: ");
        sideC = Convert.ToInt32(Console.ReadLine());
        if (sideA > 0 && sideB > 0 && sideC > 0) {
          if ( sideA == sideB && sideB == sideC ) {
              Console.Write ("This is an equilateral triangle.\n");
          } else if (sideA == sideB || sideA == sideC || sideB == sideC) {
              Console.Write ("This is an isosceles triangle.\n");
          } else {
              Console.Write ("This is a scalene triangle.\n");
          }
        } else {
          Console.Write ("Input is negative. Try again.\n");
        }
    }
}