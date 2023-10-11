using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module05HM
{
    public class School
    {
        public void AccessNonExistentResource()
        {
            try
            {
                // Попытка обратиться к несуществующему веб-ресурсу
                throw new WebResourceNotFoundException("Не удалось получить доступ к веб-ресурсу.");
            }
            catch (WebResourceNotFoundException ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
        }

        public void AccessArrayOutOfBounds()
        {
            int[] array = { 1, 2, 3 };

            try
            {
                // Попытка обратиться к элементу массива, выходящему за его пределы
                int value = array[5];
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Завершение обработки массива.");
            }
        }

        public void CallMethodWithException()
        {
            try
            {
                GenerateException();
            }
            catch (CustomException ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
        }

        private void GenerateException()
        {
            // Генерируем пользовательское исключение
            throw new CustomException("Произошла пользовательская ошибка.");
        }
    }
}
