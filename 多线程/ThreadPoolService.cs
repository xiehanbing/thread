using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace 多线程
{
   public static class ThreadPoolService<T>
    {
       /// <summary>
       /// 定义线程池的委托
       /// </summary>
       /// <param name="threadId"></param>
       /// <returns></returns>
       public delegate T RunOnThreadPool(out int threadId,int x,int y);
       /// <summary>
       /// 回调函数
       /// </summary>
       /// <param name="tar"></param>
       public static void Callback(IAsyncResult tar)
       {
           Console.WriteLine("starting a callback...");

           Console.WriteLine("state passed to a callback:{0}", tar.AsyncState);

           Console.WriteLine("is thread pool thread:{0}", Thread.CurrentThread.IsThreadPoolThread);

           Console.WriteLine("thread pool worker thread id :{0}", Thread.CurrentThread.ManagedThreadId);
       }

       /// <summary>
       /// 真正执行函数
       /// </summary>
       /// <param name="threadId"></param>
       /// <returns></returns>
       public static TestModel Test(out int threadId, int x, int y)
       {
           Console.WriteLine("starting...");

           Console.WriteLine("is thread pool thread:{0}", Thread.CurrentThread.IsThreadPoolThread);

           Thread.Sleep(TimeSpan.FromSeconds(2));

           threadId = Thread.CurrentThread.ManagedThreadId;

           var result = x + y;
           var data = new TestModel
           {

               Message = string.Format(" thread pool worker thread id was :{0},reult:{1}", threadId, result),
               Data = result
           };
           return data;
       }


    }


    public class TestModel
    {
        public string Message { get; set; }
        public int Data { get; set; }
    }
}
