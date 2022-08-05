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
        private int[] _arr = new int[100];
        private string[] _dayArr = new string[100];
        private int  _sum = 0 ;
        private int _viTriMang = 0 ,_x;
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
                            _dayArr[_viTriMang] = sequence[i] + " " + sequence[k];
                            _arr[_viTriMang] = sequence[i] + sequence[k];
                            _x = k;
                            if (k == sequence.Length - 1)
                            {
                                _hieuHaiSo = null;
                                _viTriMang++;
                            }
                        }
                        else
                        {
                            if (sequence[k] - sequence[_x] == _hieuHaiSo)
                            {
                                _dayArr[_viTriMang] += " " + sequence[k];
                                _arr[_viTriMang] += sequence[k];
                                _x = k;
                                if (k == sequence.Length - 1)
                                {
                                    _hieuHaiSo = null;
                                    _viTriMang++;
                                }
                            }
                            else
                            {
                                if (k == sequence.Length - 1)
                                {
                                    _hieuHaiSo = null;
                                    _viTriMang++;
                                }
                                
                            }

                        }
                    }
                }
            }
            for (int i = 0; i < _arr.Length; i++)
            {
                if (_arr[i] != 0)
                {
                    if (_arr[i] > _sum)
                    {
                        _sum = _arr[i];
                    }
                }
            }
            for (int i = 0; i < _dayArr.Length; i++)
            {
                if (_dayArr[i] != null)
                {
                    Console.WriteLine(_dayArr[i]);
                }
                

            }
            return _sum;
        }
    }
}
