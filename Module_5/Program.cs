using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Url.Module;

///1.	Перехватить исключение запроса к несуществующему веб ресурсу и вывести сообщение о том, что произошла ошибка. Программа должна завершиться без ошибок.
///

namespace Module_5
{
    class Program
    {
        static void Main(string[] args)
        {
            EnterUrl url = new EnterUrl();

            url.SetUrl();
        }       
    }
}