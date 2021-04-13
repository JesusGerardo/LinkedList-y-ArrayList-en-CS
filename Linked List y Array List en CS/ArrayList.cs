using System;
using System.Collections.Generic;
using System.Text;

namespace Linked_List_y_Array_List_en_CS
{
    class ArrayList<H> : List<H>
    {
        private Object[] array;
        private int size;

        public ArrayList()
        {
            this.array = new Object[4];
        }

        //override
        public void add(H data)
        {

            this.array[size++] = data;
        }

        //override
        public H get(int index)
        {
            return (H)this.array[index];
        }

        //override
        public void delete(int index)
        {

        }

        //override
        public int getSize()
        {
            return size;
        }

        //override
        public Iterator<H> getIterator()
        {
            return new ForwardIterator(this);
        }

        //override
        public void insert(H data, Position position, Iterator<H> it)
        {

        }

        //override
        public Iterator<H> getReverseIterator()
        {
            return new ReverseIterator(this);
        }

        public class ForwardIterator : Iterator<H>
        {
            private ArrayList<H> array;
            private int currentIndex;

            public ForwardIterator(ArrayList<H> array)
            {
                this.array = array;
                currentIndex = 0;
            }

            public int getCurrentIndex()
            {
                return currentIndex;
            }

            //override
            public bool hasNext()
            {
                return currentIndex < array.size;
            }

            //override
            public H next()
            {
                H data;
                data = (H)array.array[currentIndex];
                currentIndex++;
                return data;
            }
        }

        public class ReverseIterator : Iterator<H>
        {
            private ArrayList<H> array;
            private int currentIndex;

            public ReverseIterator(ArrayList<H> array)
            {
                this.array = array;
                currentIndex = array.size - 1;
            }

            public int getCurrentIndex()
            {
                return currentIndex;
            }

            //override
            public bool hasNext()
            {
                return currentIndex >= 0;
            }

            //override
            public H next()
            {
                H data;
                data = (H)array.array[currentIndex];
                currentIndex--;
                return data;
            }
        }
    }
}
