using System;
using System.Collections.Generic;
using System.Text;

namespace ProgramacionOrientadaObjetos.Business
{
    // Como usar los generics
    // Para indicar que la clase trabaja con un generico se debe poner <> al final del nombre de la clase
    // por combención se pone <T> pero puede ir cualquier letra ejm: "<HolaMundo>"
    public class Colletion<T>
    {
        private T[] _elements;
        private int _index;
        private int _limit;

        public Colletion(int limit) 
        {
            _index = 0;
            _limit = limit;
            _elements = new T[_limit];
        }

        public void Add(T element)
        { 
            if (_index < _limit)
            {
                _elements[_index] = element;
                _index++;
            }
        }

        public T[] Get()
            => _elements;
    }
}
