namespace BoxOfT
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Box<T>
    {
        public List<T> CreateList<T>(T item, int count)
        {
            List<T> list = new List<T>();

            for (int i = 0; i < count; i++)
            {
                list.Add(item);
            }

            return list;
        }
        
        private int count;
        private T[] data;
                
        public int Count { get; set; }
       
        public void Add(T item)
        {
            this.data.Add(item);
        }

        public T Remove()
        {
            var rem = this.data.Last();
            this.data.RemoveAt(this.data.Count - 1);
            return num;
        }
    }
}