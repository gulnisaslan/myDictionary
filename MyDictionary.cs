using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsHomework_MyDictionary
{
    class MyDictionary<T,TV>
    {
        T[] keys;
        TV[] values;
        

        public MyDictionary()
        {
            keys = new T[0];
            values = new TV[0];


        }

        public void Add(T key,  TV value)
        {
            T[] tempDictionary = keys;
            TV[] tempDictionaryV = values;

            keys = new T[keys.Length + 1];
            values = new TV[values.Length + 1];

         

            for (int i = 0; i < tempDictionary.Length; i++)
            {
                keys[i] = tempDictionary[i];
                values[i] = tempDictionaryV[i];
              


            }
             keys[keys.Length - 1] = key;
             values[values.Length - 1] = value;
        }
        public T[] Key
        {
            get { return keys; }
        }

        public TV[] Value
        {
            get { return values; }
        }
    }
}
