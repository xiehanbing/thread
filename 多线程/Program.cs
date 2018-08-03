using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace 多线程
{
    abstract class CounterBase
    {
        public abstract void Increment();

        public abstract void Decrement();


    }


    class Counter : CounterBase
    {
        public int Count { get; set; }

        public override void Increment()
        {
            Count++;
            //throw new NotImplementedException();
        }

        public override void Decrement()
        {
            Count--;
            //throw new NotImplementedException();
        }

    }

    class ConterWithNolock : CounterBase
    {
        private readonly object _syncRoot = new object();
        public int Count { get; set; }

        public override void Increment()
        {
            lock (_syncRoot)
            {
                Count++;
            }
            //throw new NotImplementedException();
        }

        public override void Decrement()
        {
            lock (_syncRoot)
            {
                Count--;
            }
            //throw new NotImplementedException();
        }
    }

    class CounterNolock : CounterBase
    {
        private int _count;

        public int Count { get{
        return _count;
        }}

        public override void Increment()
        {
            //_count++;
            Interlocked.Increment(ref _count);
            //throw new NotImplementedException();
        }

        public override void Decrement()
        {
           // _count--;
            Interlocked.Decrement(ref _count);
            //throw new NotImplementedException();
        }
    }


    class Perple
    {

        public string Name { get; set; }


    }

 
    class Program
    {

        static void TestCounter(CounterBase c)
        {
            for (var i = 0; i < 10; i++)
            {
                c.Increment();
               // c.Decrement();
            }

        }
        static void Main(string[] args)
        {
            Console.WriteLine("hello world");

            //Thread t1 = new Thread(Print);
            //t1.Start("dasdasffdsff");

            //Task t = Task.Factory.StartNew((num) =>
            //{
            //    Console.WriteLine(((int)num).ToString());

            //},3);

            //Thread t = new Thread(() => Print("t"));

            //Thread t1 = new Thread(() => Print("t1"));
            //Thread t2 = new Thread(() => Print("t2"));
            //t.Start();
            //t.Join();
            //t1.Start();
            //t1.Join();
            //t2.Start();
            
           
           // t2.Join();

            //ThreadPool.SetMaxThreads(1, 1);
            //ThreadPool.QueueUserWorkItem(new WaitCallback(Print),"ssdsa");

            //var c = new Counter();

            //var t1 = new Thread(() => TestCounter(c));


            //var t2 = new Thread(() => TestCounter(c));

            //var t3 = new Thread(() => TestCounter(c));

            //t1.Start();

            //t2.Start();

            //t3.Start();

            //t1.Join();

            //t2.Join();

            //t3.Join();

            //Console.WriteLine("total count: "+c.Count+"");

            //Console.WriteLine("----------------------");

            //Console.WriteLine("correct counter");


            //var c1 = new ConterWithNolock();
            //t1 = new Thread(() => TestCounter(c1));
            //t2 = new Thread(() => TestCounter(c1));
            //t3 = new Thread(() => TestCounter(c1));
            //t1.Start();
            //t2.Start();
            //t3.Start();

            //t1.Join();

            //t2.Join();

            //t3.Join();
            //Console.WriteLine("total count: " + c1.Count + "");

            //var lock1 = new object();

            //var lock2 = new object();

            //new Thread(() => LockTooMuch(lock1, lock2)).Start();

            //lock(lock2)
            //{
            //    Thread.Sleep(1000);

            //    Console.WriteLine("monitor.tryenter allows not to set stuck,returning false after a specified time out is elapsed");

            //        if(Monitor.TryEnter(lock1,TimeSpan.FromSeconds(5)))
            //        {
            //            Console.WriteLine("acquired a protected resource succesfully");

            //        }
            //        else
            //        {
            //            Console.WriteLine(" time out acquiring a resource");
            //        }
            //}

            //new Thread(()=>LockTooMuch(lock1,lock2));
            //Console.WriteLine("------------------------------");

            //lock(lock2)
            //{
            //    Console.WriteLine("this will be deadlock");
            //    Thread.Sleep(1000);

            //    lock(lock1)
            //    {
            //        Console.WriteLine("acquired a protected resource succesfully");
            //    }
            //}


            //处理异常
            //var t = new Thread(FaultyThread);
            //t.Start();
            //t.Join();

            //try
            //{
            //    t = new Thread(BadFaultyThread);
            //    t.Start();
            //}
            //catch (Exception ex)
            //{

            //    Console.WriteLine("we won't get here");
            //}

           // Console.WriteLine("incrrect counter");

            //List<int> list = new List<int> { 1, 2, 3, 4 };

            //var list1 = new List<int> { 1, 2, 3, 4 };

            //Console.WriteLine(list1.GetType());

            //var c = new CounterNolock();

            //Task[] task = new Task[100];
            //for(var i=0;i<task.Length;i++)
            //{
            //    task[i]=Task.Factory.StartNew((num)=>{
            //    var tskid=(int)num;
            //    TestCounter(c);
            //    },i);
            //}
           // task[0]=new Thread(() => TestCounter(c));
            //var t1 = new Thread(() => TestCounter(c));

            //var t2 = new Thread(() => TestCounter(c));

            //var t3 = new Thread(() => TestCounter(c));

            //t1.Start();
            ////t1.Join();

            //t2.Start();
            ////t2.Join();
            //t3.Start();

            //Task.WaitAll(task);
          

          

            //t3.Join();

            //Console.WriteLine("total count :"+c.Count);

            //const string MutexName = "CSharpThreadingCookbook";

            //using(var m=new Mutex(false,MutexName))
            //{
            //    if(!m.WaitOne(TimeSpan.FromSeconds(5),false))
            //    {
            //        Console.WriteLine("second instance is runing");
            //    }
            //    else
            //    {
            //        Console.WriteLine("runing");
            //        Console.ReadLine();
            //        m.ReleaseMutex();
            //    }
            //}

            //for (int i = 1; i <= 6;i++ )
            //{

            //    string threadName = "Thread" + i;

            //    int secondsToWait = 2 + 2 * i;

            //    var t = new Thread(() => AccessDataBase(threadName, secondsToWait));
            //    t.Start();
            //}

            //var t = new Thread(() => Process(10));

            //t.Start();


            
            //Console.WriteLine("waiting for another thread to completework");

            //_workEvent.WaitOne();

            //Console.WriteLine("first operatorion is completed!");

            //Console.WriteLine("performing an operatorion on a main thread ");

            //Thread.Sleep(TimeSpan.FromSeconds(5));

            //_mainEvent.Set();

            //Console.WriteLine("now runing the second operation on a second thread");
            //_workEvent.WaitOne();
            //Console.WriteLine("second operation is completed!");

            //var t1 = new Thread(() => TravelThroughGates("thread1", 5));


            //var t2 = new Thread(() => TravelThroughGates("thread2", 6));


            //var t3 = new Thread(() => TravelThroughGates("thread3", 12));

            //t1.Start();

            //t2.Start();

            //t3.Start();

            //Thread.Sleep(TimeSpan.FromSeconds(6));

            //Console.WriteLine("the gates have been open!");

            //_mainSlimEvent.Set();

            //Thread.Sleep(TimeSpan.FromSeconds(2));

            //_mainSlimEvent.Reset();

            //Console.WriteLine("the gates have been closed!");

            //Thread.Sleep(TimeSpan.FromSeconds(10));

            //Console.WriteLine("the gates are now open for the secondTime!");

            //_mainSlimEvent.Set();

            //Thread.Sleep(TimeSpan.FromSeconds(2));

            //Console.WriteLine("the gates have been closed!");

            //_mainSlimEvent.Reset();
    



             

            //var test1 = 0;


            //var success=Verify();

            //new Thread(Read) { IsBackground = true }.Start();


            //new Thread(Read) { IsBackground = true }.Start();

            //new Thread(Read) { IsBackground = true }.Start();

            //new Thread(()=>Write("thread1")) { IsBackground = true }.Start();

            //new Thread(() => Write("thread2")) { IsBackground = true }.Start();

            //Thread.Sleep(TimeSpan.FromSeconds(30));

            //var t1 = new Thread(UserModeWait);

            //var t2 = new Thread(HybridSpinWait);

            //Console.WriteLine("runing user mode waiting");

            //t1.Start();
            //Thread.Sleep(20);
            //_isCompleted = true;
            //Thread.Sleep(TimeSpan.FromSeconds(1));
            //_isCompleted = false;

            //Console.WriteLine("runing hybrid spinwait construct waiting");

            //Thread.Sleep(5);

            //_isCompleted = true;

            //测试
            int threadId = 0;

            ThreadPoolService<TestModel>.RunOnThreadPool poolDelegate = ThreadPoolService<TestModel>.Test;

            var t = new Thread(() => ThreadPoolService<TestModel>.Test(out threadId, 1, 2));

            t.Start();

            t.Join();


            Console.WriteLine("mainthread id :{0}", threadId);

            IAsyncResult r = poolDelegate.BeginInvoke(out threadId, 1, 2, ThreadPoolService<TestModel>.Callback, "a delegate asynchronous call");

            r.AsyncWaitHandle.WaitOne();

            TestModel result = poolDelegate.EndInvoke(out threadId, r);


            Console.WriteLine("mainthread poool worker thread id :{0}", threadId);

            Console.WriteLine(result);

            //Thread.Sleep(TimeSpan.FromSeconds(2));

            Console.ReadKey();

        }



        static volatile bool _isCompleted = false;

        static void UserModeWait()
        {
            while(!_isCompleted)
            {
                Console.WriteLine(".");
            }
            Console.WriteLine();

            Console.WriteLine("waiting is completed");
        }

        static void HybridSpinWait()
        {
            var w = new SpinWait();

            while(!_isCompleted)
            {
                w.SpinOnce();
                Console.WriteLine(w.NextSpinWillYield);
            }
            Console.WriteLine("wait is complete");
        }
        static ReaderWriterLockSlim _rw = new ReaderWriterLockSlim();
        static Dictionary<int, int> _items = new Dictionary<int, int>();
        static void Read()
        {

            Console.WriteLine("reading contents of a dictionary");

            while(true)
            {
                try
                {
                    _rw.EnterReadLock();
                    foreach (var key in _items.Keys)
                    {
                        Thread.Sleep(TimeSpan.FromSeconds(0.1));

                    }
                }
                finally
                {
                    _rw.ExitReadLock();
                }
                
            }
        }

        static void Write(string threadName)
        {

            //Console.WriteLine("reading contents of a dictionary");

            while (true)
            {
                try
                {
                    int newKey = new Random().Next(250);
                    _rw.EnterUpgradeableReadLock();
                    if(!_items.ContainsKey(newKey))
                    {
                        try
                        {
                            _rw.EnterWriteLock();
                            _items[newKey] = 1;
                            Console.WriteLine("new key {0} is added to a dictionary by a {1}", newKey, threadName);
                        }
                        finally
                        {
                            _rw.ExitWriteLock();
                        }
                    }
                    Thread.Sleep(TimeSpan.FromSeconds(0.1));
                  
                }
                finally
                {
                    _rw.ExitUpgradeableReadLock();
                }

            }
        }



        static ManualResetEventSlim _mainSlimEvent = new ManualResetEventSlim(false);
        static void TravelThroughGates(string threadName,int seconds)
        {
            Console.WriteLine("{0} falls to sleep ", threadName);
            Thread.Sleep(TimeSpan.FromSeconds(seconds));

            Console.WriteLine("{0} waits for the gates to open!", threadName);

            _mainSlimEvent.Wait();

            Console.WriteLine("{0} enters the gates!", threadName);

        }
        private static AutoResetEvent _workEvent = new AutoResetEvent(false);

        private static AutoResetEvent _mainEvent = new AutoResetEvent(false);

        static void Process(int seconds)
        {
            Console.WriteLine("Starting a long running work...");

            Thread.Sleep(TimeSpan.FromSeconds(seconds));

            Console.WriteLine("work is done!");

            _workEvent.Set();

            Console.WriteLine("waiting for a main thread to complete its work");

            _mainEvent.WaitOne();

            Console.WriteLine("starting second operator...");

            Thread.Sleep(TimeSpan.FromSeconds(seconds));

            Console.WriteLine("work is done!");

            _workEvent.Set();

        }


        /// <summary>
        /// 限制访问 同一资源的 线程数量
        /// </summary>
        static SemaphoreSlim _semaphore = new SemaphoreSlim(4);

        static void AccessDataBase(string name,int seconds)
        {
            Console.WriteLine(name + " waits to access a database");
            _semaphore.Wait();

            Console.WriteLine(name + " was granted an access to a database");

            Thread.Sleep(TimeSpan.FromSeconds(seconds));

            Console.WriteLine(name + " is completed ");

            _semaphore.Release();
        }

       static bool Verify()
        {
            return false;
        }

        static void BadFaultyThread()
        {
            Console.WriteLine("starting a faulty thread...");
            Thread.Sleep(TimeSpan.FromSeconds(2));
            throw new Exception("Boom!");
        }

        static void FaultyThread()
        {
            try
            {
                Console.WriteLine("starting a faulty thread...");
                Thread.Sleep(TimeSpan.FromSeconds(1));
                throw new Exception("Boom!");
            }
            catch (Exception ex)
            {

                Console.WriteLine("exception handled:" + ex.Message + "");
            }
        }

        static void LockTooMuch(object lock1, object lock2)
        {
            lock (lock1)
            {
                Thread.Sleep(1000);
                lock (lock2) ;
            }
        }

        public static void Print(object name)
        {
            Perple p = new Perple
            {
                Name = (string)name
            };
            //Console.WriteLine(p.Name);

            for(var i=1;i<10;i++)
            {
                Console.WriteLine(p.Name + ":" + i);
            }
        }
    }
}
