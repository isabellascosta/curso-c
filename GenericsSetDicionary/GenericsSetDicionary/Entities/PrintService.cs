using System;


namespace GenericsSetDicionary.Entities
{
    internal class PrintService<T>
    {
        //parametrizei que a classe vai ser de um tipo T, com isso consigo reutilizar no program como houver necessidade, ou como string, ou como int
        //senha que aconteça um typesafty
        private T[] _values = new T[10];
        private int _count = 0;

        public void AddValue(T value)
        {
            if (_count == 10)
            {
                throw new InvalidOperationException("Print service is full");
            }
            _values[_count] = value;
            _count++;
        }
        public T  First()
        {
            if( _count == 0) {
                throw new InvalidOperationException("Print service is empty");
            }
            return _values[0];
        }
        public void Print()
        {
            Console.Write("[");
            for(int i = 0; i < _count-1;i++)
            {
                Console.Write(_values[i]+", ");
            }
            if (_count > 0 )
            {
                Console.Write(_values[_count-1]);
            }
            Console.WriteLine("]");
        }
    }
}
