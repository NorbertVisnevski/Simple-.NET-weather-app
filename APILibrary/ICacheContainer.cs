using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APILibrary
{
    public interface ICacheContainer<K,V>
    {
        public int Size
        {
            get;
        }
        public V get(K key);
        public void add(K key, V value);
        public void clear();
    }
}
