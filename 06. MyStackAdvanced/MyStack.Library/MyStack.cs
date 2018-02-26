using System;
using System.Collections.Generic;

namespace Stack.Library
{
    public class MyStack<T>
    {
        private int _count;
        private T _item;

        private MyStack<T> _currentList;

        public MyStack()
        {
            _count = 0;
            _item = default(T);
            _currentList = null;
        }

        public MyStack(MyStack<T> currentStack, int count, T item)
        {
            _count = count;
            _item = item;
            _currentList = currentStack;
        }

        public int Count
        {
            get { return _count; }
        }

        public MyStack<T> Push (T item)
        {
            return new MyStack<T>(this, _count + 1, item);
        }

        public T Peek()
        {
            return _item;
        }

        public MyStack<T> Pop()
        {
            return new MyStack<T>(_currentList, _count - 1, _item);
        }
    }
}
