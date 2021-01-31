using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();
            myDictionary.Add(123, "Berrin Cengiz");
            myDictionary.Add(456, "Ali Cengiz");
            myDictionary.Add(789, "Engin Demiroğ");
            Console.WriteLine(myDictionary.Count);
        }
    }
    class MyDictionary<K,V>
    {
        K[] _arrayK;
        V[] _arrayV;
        K[] _tempArrayK;
        V[] _tempArrayV;
        public MyDictionary()
        {
            _arrayK = new K[0];
            _arrayV = new V[0];
        }

        public void Add(K item, V item2)
        {
            _tempArrayK = _arrayK; // dizideki veriler kaybolmasın diye geçici bir dizi oluşturduk. _array dizisinin referansını tutuyor.
            _tempArrayV = _arrayV;
            _arrayK = new K[_arrayK.Length + 1];
            _arrayV = new V[_arrayV.Length + 1];
            for (int i = 0; i < _tempArrayK.Length; i++)
            {
                _arrayK[i] = _tempArrayK[i]; // geçici dizideki elemanları aktardık.
            }
            for (int i = 0; i < _tempArrayV.Length; i++)
            {
                _arrayV[i] = _tempArrayV[i]; // geçici dizideki elemanları aktardık.
            }
        }
        public int Count
        {
            get { return _arrayK.Length; }
        }
    }
}

