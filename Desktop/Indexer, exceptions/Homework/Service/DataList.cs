﻿using System;
namespace Service
{
    public class DataList<T> where T : class
    {
        private T[] _datas;

        public DataList()
        {
            _datas = new T[0];
        }

        public void Add(T item)
        {
            Array.Resize(ref _datas, _datas.Length + 1);

            _datas[_datas.Length - 1] = item;
        }

        public T[] GetAll()
        {
            return _datas;
        }
    }
}

