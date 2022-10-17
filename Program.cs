using System;
using static System.Console;

namespace code{
    public static class ejercicios{
        public static void Main(){
            WriteLine($"+-type--+---size---+--------------min-----------------+--------------max-----------------+");
            WriteLine($"|byte   |  {sizeof(byte), -8}|  {byte.MinValue,32}|  {byte.MaxValue, 32}|");
            WriteLine($"+-------+----------+----------------------------------+----------------------------------+");
            WriteLine($"|short  |  {sizeof(short), -8}|  {short.MinValue,32}|  {short.MaxValue, 32}|");
            WriteLine($"+-------+----------+----------------------------------+----------------------------------+");
            WriteLine($"|uint   |  {sizeof(uint), -8}|  {uint.MinValue, 32}|  {uint.MaxValue, 32}|");
            WriteLine($"+-------+----------+----------------------------------+----------------------------------+");
            WriteLine($"|int    |  {sizeof(int), -8}|  {int.MinValue, 32}|  {int.MaxValue, 32}|");
            WriteLine($"+-------+----------+----------------------------------+----------------------------------+");
            WriteLine($"|float  |  {sizeof(float), -8}|  {float.MinValue, 32}|  {float.MaxValue, 32}|");
            WriteLine($"+-------+----------+----------------------------------+----------------------------------+");
            WriteLine($"|double |  {sizeof(double), -8}|  {double.MinValue, 32}|  {double.MaxValue, 32}|");
            WriteLine($"+-------+----------+----------------------------------+----------------------------------+");
            WriteLine($"|long   |  {sizeof(long), -8}|  {long.MinValue, 32}|  {long.MaxValue, 32}|");
            WriteLine($"+-------+----------+----------------------------------+----------------------------------+");
            WriteLine($"|ulong  |  {sizeof(ulong), -8}|  {ulong.MinValue, 32}|  {ulong.MaxValue, 32}|");
            WriteLine($"+----------------------------------------------------------------------------------------+");

        }
    }
}
