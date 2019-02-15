namespace P01.ListyIterator
{
    using System.Collections.Generic;

    public class ListyIterator<T>
    {
        private List<T> data;
        private int index;

        public ListyIterator(List<T> data)
        {
            this.data = data;
            int index = 0;
        }

        public bool Move()
        {

        }

        public bool HasNext()
        {
            if (index + 1 < this.data.Count)
            {
                return true;
            }
            return false;
        }

        public string Print()
        {

        }
    }
}