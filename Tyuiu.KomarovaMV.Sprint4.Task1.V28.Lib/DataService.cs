﻿using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.KomarovaMV.Sprint4.Task1.V28.Lib
{
    public class DataService : ISprint4Task1V28
    {
        public int Calculate(int[] array)
        {
            int p = 1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i]%2 != 0)
                {
                    p*=array[i];
                }
            }
            return p;
        }
    }
}
