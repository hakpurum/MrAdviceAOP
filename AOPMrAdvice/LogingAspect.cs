using ArxOne.MrAdvice.Advice;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOPMrAdvice
{
    public class LogingAspect : Attribute, IMethodAdvice
    {
        public void Advise(MethodAdviceContext context)
        {
            try
            {
                //Method ya da class a gönderilen değerler alındı
                IList<object> arguments = context.Arguments;

                Console.WriteLine(context.TargetName + " Method'a girdi");
                if (arguments != null && arguments.Count > 0)
                {
                    foreach (var arg in arguments)
                    {
                        //değerler ekrana yazdırıldı
                        Console.WriteLine("Parametre : " + arg);
                    }
                }

                //Method işlemi yürütüldü
                context.Proceed();

                Console.WriteLine(context.TargetName + " Methodan çıktı");
            }
            catch (Exception ex)
            {
                Console.WriteLine("hata oluştu");
                Debug.WriteLine(ex);
            }
        }

    }

}
