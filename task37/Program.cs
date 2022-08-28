using System;

class Program
{
    // найти произведение пар чисел водномерном массиве. пара первый и последний эл-т,
    // второй и предпоследний
    static void Main (string[] args)    
    {
        int res1 = 0;
        int res2 = 0;
        int res3 = 0;
        int[] array = {1, 2,3,4,5};
        for(int i = 4; i < array.Length; i++)
        {
            res1 = res1 + array[0]*array[4];
            res2 = res2 + array[1]*array[3];
            res3 = res3 + array[0]*array[2];
             
            
        }
        //string numb = Convert.ToInt32(res1)
         int[] A = {res1,res2,res3};
         for(int j = 0; j < A.Length; j++)
        {
         //Console.Write("["+A[j]+"]");
        Console.Write($"{A[j]}");
        } 
    }
}        