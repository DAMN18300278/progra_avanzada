using System;
using System.Linq;
using static System.Console;

namespace Program{
    public class Node{
        public int num;
        public Node? start;
        public Node? next;

        public void Insert(int num){
            Node? insert = new Node();

            if(start == null){
                insert.num = num;
                insert.next = start;
                start = insert;
            }else{
                insert = start;
                Node plug = new Node();
                plug.num = num;

                while(true){
                    if(insert == null){
                        plug.next = start;
                        start = plug;
                        break;
                    }
                    if(num > insert.num){
                            insert = insert.next;
                    }else{
                        plug.next = start;
                        start = plug;
                        break;
                    }
                }
            }
        }

        public void print(){
            Node? actual = start;
            Write("{ ");
            while(actual != null){
                if(actual.next == null){
                    Write(actual.num + " }");
                }else{
                    Write(actual.num + " ,");
                }
                actual = actual.next;
            }
        }
    }

    class Program{
        public static void Main(){
            List<int> list1 = new List<int>();
            List<int> list2 = new List<int>();

            WriteLine($"Inserte el primer arreglo e ingrese cualquier simbolo para terminar: ");
            
            while(true){
                int temp;
                bool exit = int.TryParse(ReadLine(), out temp);

                if(exit){
                    list1.Add(temp);
                }else{
                    Write("\r\n");
                    break;
                }
            }

            WriteLine($"Inserte la segunda lista: ");

            while(true){
                int temp;
                bool exit = int.TryParse(ReadLine(), out temp);

                if(exit){
                    list2.Add(temp);    
                }else{
                    Write("\r\n");
                    break;
                }
            }

            Node node = new Node();

            list1 = list1.Concat(list2).ToList();
            list1 = list1.OrderByDescending(list1 => list1).ToList();

            foreach(var t in list1){
                node.Insert(t);
            }

            node.print();

        }
    }
}