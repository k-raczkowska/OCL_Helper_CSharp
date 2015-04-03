using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OCL_Helper.collections
{
    class Set<T>
    {
        List<T> list;

        Set()
        {
            list = new List<T>();
        }

        public bool operator ==(Set<T> other, Set<T> set){//for the = operation
            foreach(T t in list){
                foreach(T t2 in other.list){
                    if(!t.Equals(t2)){
                        return false;
                    }
                }
            }
            return true;
        }

        public bool operator !=(Set<T> other, Set<T> set)//for the <> operation
        {
            return other == set;
        }

        public int size()
        {
            return list.Count;
        }

        public bool includes(T elem)
        {
            return list.Contains(elem);
        }

        public bool excludes(T elem)
        {
            return !list.Contains(elem);
        }

        public int count(T elem)
        {
            int counter = 0;
            foreach(T t in list)
            {
                if(t.Equals(elem))
                {
                    counter++;   
                }
            }
            return counter;
        }
    }
}
