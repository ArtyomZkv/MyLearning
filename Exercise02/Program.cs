using System;

namespace Exercise02
{
    class Program
    {
        static void Main(string[] args)
        {

            System.Console.WriteLine($"Количество байт в типе = {sizeof(sbyte)}, минимальное значение = {sbyte.MinValue}, максимальное значение = {sbyte.MaxValue}\n" +
            $"Количество байт в типе = {sizeof(byte)}, минимальное значение = {byte.MinValue}, максимальное значение = {byte.MaxValue}\n" +
            $"Количество байт в типе = {sizeof(short)}, минимальное значение = {short.MinValue}, максимальное значение = {short.MaxValue}\n" +
            $"Количество байт в типе = {sizeof(ushort)}, минимальное значение = {ushort.MinValue}, максимальное значение = {ushort.MaxValue}\n" +
            $"Количество байт в типе = {sizeof(int)}, минимальное значение = {int.MinValue}, максимальное значение = {int.MaxValue}\n" +
            $"Количество байт в типе = {sizeof(uint)}, минимальное значение = {uint.MinValue}, максимальное значение = {uint.MaxValue}\n" +
            $"Количество байт в типе = {sizeof(long)}, минимальное значение = {long.MinValue}, максимальное значение = {long.MaxValue}\n" +
            $"Количество байт в типе = {sizeof(ulong)}, минимальное значение = {ulong.MinValue}, максимальное значение = {ulong.MaxValue}\n" +
            $"Количество байт в типе = {sizeof(float)}, минимальное значение = {float.MinValue}, максимальное значение = {float.MaxValue}\n" +
            $"Количество байт в типе = {sizeof(double)}, минимальное значение = {double.MinValue}, максимальное значение = {double.MaxValue}\n" +
            $"Количество байт в типе = {sizeof(decimal)}, минимальное значение = {decimal.MinValue}, максимальное значение = {decimal.MaxValue}");

        }
    }
}
