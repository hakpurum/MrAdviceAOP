using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOPMrAdvice
{
    class Program
    {
        static void Main(string[] args)
        {
            var detail = new UserService().GetUserName(1);
            Console.Write(detail);

            Console.ReadLine();
        }
    }


    public class UserService
    {
        [LogingAspect]
        public string GetUserName(int id)
        {
            throw new ArgumentNullException();
            return "Hasan Akpürüm";
        }
    }
}
