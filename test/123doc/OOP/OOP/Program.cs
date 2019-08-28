using System;
using System.Collections.Generic;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            #region List in SortedList 
            //SortedList<string, List<string>> MySL = new SortedList<string, List<string>>();
            //MySL.Add("Bao", new List<string>() { "vua dep", "vua gioi" });
            //MySL.Add("huy", new List<string>() {"xau trai" });
            //MySL.Add("nhan", new List<string>() { "ga" });
            //MySL.Add("ha", new List<string>() { "ga" });

            ////foreach(var item in MySL)
            ////{
            ////    Console.WriteLine(item);
            ////}

            //foreach (var key in MySL.Keys)
            //{
            //    Console.WriteLine("Key : {0} Value : {1}", key, MySL[key]);
            //}

            #endregion

            #region SortedList
            //SortedList<string, string> MySl = new SortedList<string, string>();
            //MySl.Add("nhan", "dep trai");
            //MySl.Add("huy", "gamer");
            //MySl.Add("bao", "ga");

            ////foreach(var item in MySl)
            ////{
            ////    Console.WriteLine(item);
            ////}

            //foreach (var key in MySl.Keys)
            //{
            //    Console.WriteLine("Key : {0} Value : {1}", key, MySl[key]);
            //}


            ////Xoa theo key
            //MySl.Remove("Bao");
            //foreach (var key in MySl.Keys)
            //{
            //    Console.WriteLine("Key : {0} Value : {1}", key, MySl[key]);
            //}

            ////xoa theo vi tri
            //Console.WriteLine("-------------");
            //MySl.RemoveAt(0);
            //foreach( var key in MySl.Keys)
            //{
            //    Console.WriteLine("Key : {0} Value : {1}", key, MySl[key]);
            //}

            //// xoa theo key va tra ve value
            //string nhanvalue;
            //MySl.Remove("nhan", out nhanvalue);
            //Console.WriteLine(nhanvalue);

            //var enumrator = MySl.GetEnumerator();
            //while (enumrator.MoveNext())
            //{
            //    Console.WriteLine("Key : {0} Value : {1}",enumrator.Current.Key,enumrator.Current.Value);
            //}
            #endregion

            #region Dictionary

            //Dictionary<string, string> MyDic = new Dictionary<string, string>();
            //MyDic.Add("nhan", "dep trai");
            //MyDic.Add("huy", "gamer");
            //MyDic.Add("bao", "ga");
            //MyDic.Add("ha", "ca");

            //foreach(var key in MyDic.Keys)
            //{
            //    Console.WriteLine("Key : {0} Value : {1}",key,MyDic[key]);
            //}



            #endregion

            #region Stack Generic
            //Stack<string> MyStack = new Stack<string>();
            //MyStack.Push("bao");
            //MyStack.Push("huy");
            //MyStack.Push("nhan");
            //MyStack.Push("tri");
            //foreach(var item in MyStack)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("--------------------");
            ////MyStack.Pop();
            //Console.WriteLine(MyStack.Pop());
            //Console.WriteLine("--------------------");
            //MyStack.Peek();
            //foreach (var item in MyStack)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine("--------------------");
            //var array = MyStack.ToArray();
            //foreach(var item in array)
            //{
            //    Console.Write(" "+item);
            //}


            #endregion

            #region Queue 
            //Queue<string> MyQueue = new Queue<string>();
            //MyQueue.Enqueue("bao");
            //MyQueue.Enqueue("huy");
            //MyQueue.Enqueue("tri");
            //MyQueue.Enqueue("nhan");

            //foreach(var item in MyQueue)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("-------------");
            //Console.WriteLine(MyQueue.Dequeue());
            //Console.WriteLine("-------------");
            //foreach (var item in MyQueue)
            //{
            //    Console.WriteLine(item);
            //}



            #endregion

            //var MyTuple = new Tuple<string, int, bool, float>("bao", 3, true, 2.1f);
            //Console.WriteLine(MyTuple.ToString());

            #region LinkedList
            //LinkedList<string> MyLinkedlist = new LinkedList<string>();

            //MyLinkedlist.AddFirst("bao");
            //var huy = MyLinkedlist.First;
            //MyLinkedlist.AddAfter(huy,"huy");
            //var nhan = MyLinkedlist.Find("huy");
            //MyLinkedlist.AddAfter(huy,"nhan");
            //var ha = MyLinkedlist.Find("nhan");
            //MyLinkedlist.AddAfter(huy,"ha");

            //foreach(var item in MyLinkedlist)
            //{
            //    Console.WriteLine(item);
            //}



            #endregion

            #region List<>

            List<Dictionary<int, string>> Customer = new List<Dictionary<int, string>>();

            var bao = new Dictionary<int, string>() { { 1, "quocbao" } };
            Customer.Add(bao);

            var khoa = new Dictionary<int, string>() { { 1, "khoanguyen" } };
            Customer.Add(khoa);

            foreach(var customer in Customer)
            {
                foreach (var item in customer)
                {
                    Console.WriteLine("ID: {0} , Name: {1}", item.Key, item.Value);
                }
            }
           
            #endregion

        }
    }
}
