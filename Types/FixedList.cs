using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Types
{
    public class FixedList<T>
    {
        private T[] _arr { get; set; }

        public T GetItem(int idx)
        {
            if(idx < 0 || idx >= _arr.Length)
            {
                throw new Exception("this position doesn't exist");
            }
            return _arr[idx];
        }

        public void SetItem(int idx, T value)
        {
            if (idx < 0 || idx >= _arr.Length)
            {
                throw new Exception("this position doesn't exist");
            }
            _arr[idx] = value;
        }

        public void SwapIndexWithIndex(int index1, int index2)
        {
            T temp = _arr[index1];
            _arr[index1] = _arr[index2];
            _arr[index2] = temp;

        }

        public void SwapValueWithValue(T value1, T value2)
        {
            int firstIndex = Array.IndexOf<T>(_arr, value1);
            int secondIndex = Array.IndexOf<T>(_arr, value2);
            SwapIndexWithIndex(firstIndex, secondIndex);
        }

        public void SwapIndexWithValue(int firstIndex, T value)
        {
            int secondIndex = Array.IndexOf<T>(_arr, value);
            SwapIndexWithIndex(firstIndex, secondIndex);
        }

        public void SwapValueWithIndex(T value, int secondIndex)
        {
            int firstIndex = Array.IndexOf<T>(_arr, value);
            SwapIndexWithIndex(firstIndex, secondIndex);
        }

        public FixedList(int length)
        {
            _arr = new T[length];
        }
    }
}
