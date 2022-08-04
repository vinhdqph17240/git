using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai5TestWeed1
{
    class Service
    {
        private int? _hieuHaiSo;
        private int[] arr = new int[100];
        private string[] dayArr = new string[100];
        private int  sum = 0 ;
        private int viTriMang = 0 ,x;
        public  int SumOfLongestArithmeticSequence(int[] sequence)
        {
            for (int i = 0; i < sequence.Length; i++)
            {
                for (int j = i+1; j < sequence.Length; j++)
                {
                    for (int k = j  ; k < sequence.Length; k++)
                    {
                        if (_hieuHaiSo == null)
                        {
                            _hieuHaiSo = sequence[k] - sequence[i];
                            dayArr[viTriMang] = sequence[i] + " " + sequence[k];
                            arr[viTriMang] = sequence[i] + sequence[k];
                            x = k;
                            if (k == sequence.Length - 1)
                            {
                                _hieuHaiSo = null;
                                viTriMang++;
                            }
                        }
                        else
                        {
                            if (sequence[k] - sequence[x] == _hieuHaiSo)
                            {
                                dayArr[viTriMang] += " " + sequence[k];
                                arr[viTriMang] += sequence[k];
                                x = k;
                                if (k == sequence.Length - 1)
                                {
                                    _hieuHaiSo = null;
                                    viTriMang++;
                                }
                            }
                            else
                            {
                                if (k == sequence.Length - 1)
                                {
                                    _hieuHaiSo = null;
                                    viTriMang++;
                                }
                                
                            }

                        }
                    }
                }
            }
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != null)
                {
                    if (arr[i] > sum)
                    {
                        sum = arr[i];
                    }
                }
            }
            for (int i = 0; i < dayArr.Length; i++)
            {
                if (dayArr[i] != null)
                {
                    Console.WriteLine(dayArr[i]);
                }
                

            }
            return sum;
        }
    }
}
