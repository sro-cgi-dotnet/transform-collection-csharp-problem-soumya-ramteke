using System;
using System.Linq;
using System.Collections.Generic;

namespace Transform
{   
    public delegate int ExpDelegate(int num);
    public static class Transform 
    {
        public static int[] Map(this int[] num_arr, ExpDelegate expDelegate)
        {
            //throw new NotImplementedException();
             // transform elements of the array one by one
            int[] result = new int[num_arr.Length];
            for(int i = 0; i < result.Length; i++){
                result[i] = expDelegate(num_arr[i]);
            }
            return result;
        }
    }
}
