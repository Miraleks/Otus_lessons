using System;

namespace HomeWork_05
{
    public partial class Stack
    {
        private int _size = 0;
        public int Size
        { get => _size; }
        string _top;
        public string Top
        {get => _top; }

        StackItem lastStackItem = null;


        public Stack(params string[] str)
        {
            if (str != null)
            {
                for (int i = 0; i < str.Length; i++)
                {
                    StackItem stackItem = new StackItem(str[i], lastStackItem);
                    lastStackItem = stackItem;
                    _size += 1;
                    _top = str[i];
                }
            }
            else
            {
                _size = 0;
                _top = null;
            }
        }

        /// <summary>
        /// добавить элемент в стек
        /// </summary>
        /// <param name="str"></param>
        public void Add(string str)
        {
            _size += 1;
            _top = str;
            StackItem stackItem = new StackItem(str, lastStackItem);
            lastStackItem = stackItem;


        }

        /// <summary>
        /// извлекает верхний элемент и удаляет его из стека
        /// </summary>
        /// <returns></returns>
        public string Pop()
        {
            _size -= 1;
            if (_size < 0)
            {
                throw new Exception("Стек пустой");
            }
            else
            {
                string deleteItem = _top;
                lastStackItem = lastStackItem.M;
                if (_size == 0)
                {
                    _top = null;
                }
                else
                {
                    _top = lastStackItem.CurrenItem;
                }
                return deleteItem;
            }
            
        }

        /// <summary>
        /// возвращает новый стек с элементами каждого стека в порядке параметров, 
        /// но сами элементы записаны в обратном порядке
        /// </summary>
        /// <param name="Stack"></param>
        /// <returns></returns>
        public static Stack Concat(params Stack[] Stack)
        {
            Stack newStack = new Stack();
            //newStack.Pop();
            foreach (var item in Stack)
            {
                newStack.Merge(item);
            }

            return newStack;
        }


        /// <summary>
        /// хранит текущее значение элемента стека и
        /// ссылку на предыдущий элемент в стеке
        /// </summary>
        class StackItem
        {
            string _currentItem;
            public string CurrenItem
            {
                get => _currentItem;
            }

            StackItem _stackItem;
            public StackItem M
            {
                get => _stackItem;
            }
            

            public StackItem(string str, StackItem stackItem)
            {
                _currentItem = str;
                _stackItem = stackItem;
            }

        }





    }
}
