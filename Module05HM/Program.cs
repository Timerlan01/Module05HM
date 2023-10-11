using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module05HM
{

        class CustomException : Exception
        {
            public CustomException(string message) : base(message) { }
        }

        class WebResourceNotFoundException : Exception
        {
            public WebResourceNotFoundException(string message) : base(message) { }
        }

        class Program
        {
            static void Main()
            {
                School school = new School();

                //Перехватить исключение запроса к несуществующему веб-ресурсу
                school.AccessNonExistentResource();

                //Обращение к элементам массива за его пределами
                school.AccessArrayOutOfBounds();

                //Генерация исключения и перехват в вызывающем методе
                school.CallMethodWithException();
            }
        }

    }
}
}
