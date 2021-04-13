using System;

namespace Linked_List_y_Array_List_en_CS
{
    class Program
    {
        static void Main(string[] args)
        {
            int cuenta = LinkedList<int>.getListsCount();

            List<int> lista1 = new ArrayList<int>();
            List<String> lista2 = new ArrayList<String>();

            lista1.add(1);
            lista1.add(4);
            lista1.add(3);
            lista1.add(7);

            lista2.add("hola");
            lista2.add(" Object ");
            lista2.add(" Oriented ");
            lista2.add(" Programming ");

            lista1.delete(3);

            Console.WriteLine("---------------------");

            Console.WriteLine("El tamaño es:" + lista1.getSize());

            Iterator<int> it = lista1.getIterator();

            while (it.hasNext())
            {
                int element = it.next();

                Console.WriteLine("Dato: " + element);
            }

            Console.WriteLine("---------------------");

            it = lista1.getReverseIterator();

            while (it.hasNext())
            {
                int element = it.next();

                Console.WriteLine("Dato: " + element);
            }

            Console.WriteLine("---------------------");

            Iterator<String> itStrings = lista2.getIterator();

            while (itStrings.hasNext())
            {
                Console.WriteLine(itStrings.next());
            }
        }
    }
}
