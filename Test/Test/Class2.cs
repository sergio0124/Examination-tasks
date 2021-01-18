using System;
using System.Collections.Generic;
using System.Text;

namespace Test
{
    class Class2 : Interface1
    {
        List<int> list = new List<int>();
        public Class2()
        {
        }
        public Class2(int size)
        {
            if (size > 0)
            {
                if (size > 10)
                {
                    list = new List<int>();
                    for (int i = 0; i < size; i++)
                    {
                        list.Add(0);
                    }
                }
                else
                {
                    Random r = new Random();
                    list = new List<int>();
                    for (int i = 0; i < r.Next(10, 20); i++)
                    {
                        list.Add(0);
                    }
                }
            }
        }
        public void SetSize(int size)
        {
            if (size > 0)
            {
                if (size > 10)
                {
                    list = new List<int>();
                    for (int i = 0; i < size; i++)
                    {
                        list.Add(0);
                    }
                }
                else
                {
                    Random r = new Random();
                    list = new List<int>();
                    for (int i = 0; i < r.Next(10, 20); i++)
                    {
                        list.Add(0);
                    }
                }
            }
        }
        public int this[int index] { 
            get { 
                if (index < list.Count) 
                { return list[index]; }
                else return 0;
            }
            set { list.Insert(index, value); }
        }

        public string Method1()
        {
            return "Method1";
        }
        public string Method2()
        {
            return "Method2";
        }
        internal int GetSize()
        {
            return list.Capacity;
        }
    }
}
