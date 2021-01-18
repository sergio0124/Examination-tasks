using System;
using System.Collections.Generic;
using System.Text;

namespace Test
{
    class Class1: Interface1
    {
        private int[] array;
        public int this[int index] { get => array[index]; set => array[index]=value; }
        public Class1() { 
        }
        public Class1(int size) {
            if (size > 0)
            {
                if (size > 10)
                {
                    array = new int[size];
                }
                else
                {
                    Random r = new Random();
                    array = new int[r.Next(10, 20)];
                }
            }
        }
        public void SetSize(int size) {
            if (size > 0) {
                if (size > 10)
                {
                    array = new int[size];
                }
                else {
                    Random r = new Random();
                    array = new int[r.Next(10,20)];
                }
            }
        }
        public string Method1() {
            return "Method1";
        }
        public string Method2()
        {
            return "Method2";
        }
        internal int GetSize()
        {
            return array.Length;
        }

    }
}
