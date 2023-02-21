namespace NumberPostCode
{
    public class NumberPost
    {
        static void Main(string[] args)
        {
            // Получаем число от пользователя
            int num = Library.GetNumber();

            // Преобразуем число в массив символов
            char[] charArr = num.ToString().ToCharArray();

            // Проходимся по каждому символу и выводим его в консоль
            //foreach (char c in charArr)
            //{
            //    Console.WriteLine(GetPattern(c));
            //}

            for (int i = 0; i < charArr.Length; i++)
            {
                Console.WriteLine(GetPattern(charArr[i]));
            }
        }

        // Возвращает образец вывода для указанного символа
        private static string GetPattern(char c)
        {
            switch (c)
            {
                case '0':
                    return " *** \n" +
                           "*   *\n" +
                           "*   *\n" +
                           "*   *\n" +
                           " *** \n";

                case '1':
                    return "    *\n" +
                           "   **\n" +
                           "  * *\n" +
                           "    *\n" +
                           "*****\n";

                case '2':
                    return " *** \n" +
                           "*   *\n" +
                           "   * \n" +
                           " *   \n" +
                           "*****\n";

                case '3':
                    return " *** \n" +
                           "*   *\n" +
                           "   **\n" +
                           "*   *\n" +
                           " *** \n";

                case '4':
                    return "   * \n" +
                           "  ** \n" +
                           " * * \n" +
                           "*****\n" +
                           "   * \n";

                case '5':
                    return "*****\n" +
                           "*    \n" +
                           "**** \n" +
                           "    *\n" +
                           "**** \n";

                case '6':
                    return " *** \n" +
                           "*    \n" +
                           "**** \n" +
                           "*   *\n" +
                           " *** \n";

                case '7':
                    return "*****\n" +
                           "   * \n" +
                           "  *  \n" +
                           " *   \n" +
                           "*    \n";

                case '8':
                    return " *** \n" +
                           "*   *\n" +
                           " *** \n" +
                           "*   *\n" +
                           " *** \n";

                case '9':
                    return " *** \n" +
                           "*   *\n" +
                           " ****\n" +
                           "    *\n" +
                           " *** \n";

                default:
                    return "";
            }
        }
    }
}
}