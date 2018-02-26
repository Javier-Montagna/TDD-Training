using System;

namespace Stack.Library
{
    public class MyStack
    {
        private object[] _items;
        private int _currentIndex;

        public MyStack(int capacity)
        {
            _items = new object[capacity];
            _currentIndex = 0;
        }

        public void Push(object item)
        {
            if (item == null) 
            {
                throw new Exception();
            }
            _items[_currentIndex] = item;
            _currentIndex++;
        }

        public object Pop()
        {
            if (_currentIndex == 0)
            {
                return null;
            }
            var item = _items[_currentIndex - 1];
            _currentIndex--;
            return item;
        }
    }
}
