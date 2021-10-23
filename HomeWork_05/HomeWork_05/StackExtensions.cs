namespace HomeWork_05
{
    public partial class Stack
    {
        public void Merge(Stack stack)
        {
            int step = stack.Size;
            for (int i = 0; i < step; i++)
            {
                string addStack = stack.Pop();
                Add(addStack);
            }
            
        }
    }
}
