using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter1
{
    public class Collection : CollectionBase
    {
        public void Add(object item)
        {
            InnerList.Add(item);
        }

        public void Remove(object item)
        {
            InnerList.Remove(item);
        }

        public new int Count()
        {
            return InnerList.Count;
        }

        public new void Clear()
        {
            InnerList.Clear();
        }

        // Exercise 2
        public void Insert(int index, object item)
        {
            InnerList.Insert(index, item);
        }

        public int IndexOf(object item)
        {
            return InnerList.IndexOf(item);
        }

        public void RemoveAt(int index)
        {
            InnerList.RemoveAt(index);
        }
    }
}
