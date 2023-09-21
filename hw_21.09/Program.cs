using System;

namespace hw_21._09
{
    internal class Program
    {
        enum Alcoholism
        {
            Алкоголик,
            Любитель,
            Пьет_по_праздникам,
            Не_пьёт
        }
        struct User 
        {
            public string name;
            public string city;
            public byte age;
            public int PIN;
        }
        struct Student
        {
            public string surname;
            public string name;
            public string id;
            public string data;
            public Alcoholism alcoholism;
            public double volume_alc;
        }
        static void Main(string[] args)
        {
            /*1.Выведите на экран информацию о каждом типе данных в виде:
            Тип данных – максимальное значение – минимальное значение*/
            Console.WriteLine("1.Выведите на экран информацию о каждом типе данных в виде:\r\n            Тип данных – максимальное значение – минимальное значение");
            Console.WriteLine("int: мин.значение - {0}, макс.значение - {0}", int.MinValue, int.MaxValue);
            Console.WriteLine("float: мин.значение - {0}, макс.значение - {0}", float.MinValue, float.MaxValue);
            Console.WriteLine("byte: мин.значение - {0}, макс.значение - {0}", byte.MinValue, byte.MaxValue);
            Console.WriteLine("long: мин.значение - {0}, макс.значение - {0}", long.MinValue, long.MaxValue);
            Console.WriteLine("short: мин.значение - {0}, макс.значение - {0}", short.MinValue, short.MaxValue);
            Console.WriteLine("double: мин.значение - {0}, макс.значение - {0}", double.MinValue, double.MaxValue);
            Console.WriteLine("decimal: мин.значение - {0}, макс.значение - {0}", decimal.MinValue, decimal.MaxValue);
            Console.WriteLine("sbyte: мин.значение - {0}, макс.значение - {0}", sbyte.MinValue, sbyte.MaxValue);
            Console.WriteLine("ushort: мин.значение - {0}, макс.значение - {0}", ushort.MinValue, ushort.MaxValue);
            Console.WriteLine("uint: мин.значение - {0}, макс.значение - {0}", uint.MinValue, uint.MaxValue);
            Console.WriteLine("ulong: мин.значение - {0}, макс.значение - {0}", ulong.MinValue, ulong.MaxValue);
            Console.WriteLine("string: мин.значение - нет, макс.значение - нет");
            Console.WriteLine("char: мин.значение - нет, макс.значение - нет");
            Console.WriteLine("bool: мин.значение - нет, макс.значение - нет");

            /*2. Напишите программу, в которой принимаются данные пользователя в виде имени,
города, возраста и PIN-кода. Далее сохраните все значение в соответствующей
переменной, а затем распечатайте всю информацию в правильном формате.*/
            Console.WriteLine("2. Пользователь вводит данные, программа сохраняет их в структуре и выводит");
            User user = new User();
            Console.Write("Введите имя: ");
            string name = Console.ReadLine();
            Console.Write("Введите город: ");
            string city = Console.ReadLine();
            Console.Write("Введите возраст: ");
            byte age = Convert.ToByte(Console.ReadLine());
            Console.Write("Введите пин-код: ");
            int pin = Convert.ToInt32(Console.ReadLine());
            user.name = name;
            user.city = city;
            user.age = age;
            user.PIN = pin;
            Console.WriteLine($"Имя: {user.name}, возраст: {user.age}, город: {user.city}, пин-код: {user.PIN}");
            /*4. Введите строку, введите подстроку. Необходимо найти количество вхождений и вывести
на экран.*/
            Console.WriteLine("Введите строку, введите подстроку. Необходимо найти количество вхождений и вывести на экран.");
            string str, str2;
            int c = 0;
            Console.Write("Введите строку: ");
            str = Console.ReadLine();
            Console.Write("Введите подстроку: ");
            str2 = Console.ReadLine();
            str = str.Replace(str2, "*");
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == '*')
                {
                    c++;
                }
            }
            Console.WriteLine("Количество вхождений подстроки: {0}", c);

            //5 задание
            Console.WriteLine("5. Окуп отпуска с помощью виски");
            int normPrice, salePrice, holidayPrice, saving;
            Console.Write("Введите обычную цену за бутылку: ");
            normPrice = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите скидку в Duty Free(в %): ");
            salePrice = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите стоимость отпуска: ");
            holidayPrice = Convert.ToInt32(Console.ReadLine());
            saving = (normPrice * salePrice)/100;//экономия с 1 бутылки
            Console.WriteLine("Чтобы окупить отдых надо {0} бутылок.", holidayPrice/saving);

            //8 задание
            Console.WriteLine("8. Создание структуры Студент, 5 студентов, посчитать кто сколько выпил.");
            Student student1 = new Student();
            student1.name = "Михаил";
            student1.surname = "Зубенко";
            student1.data = "21.09.2023";
            student1.id = "123";
            student1.alcoholism = 0;
            student1.volume_alc = 750;
            
            Student student2 = new Student();
            student2.name = "Клим";
            student2.surname = "Матвеев ";
            student2.data = "21.09.2023";
            student2.id = "566";
            student2.alcoholism = 0;
            student2.volume_alc = 350;

            Student student3 = new Student();
            student3.name = "Лукьян";
            student3.surname = "Комаров";
            student3.data = "21.09.2023";
            student3.id = "992";
            student3.alcoholism = 0;
            student3.volume_alc = 450;

            Student student4 = new Student();
            student4.name = "Назарий";
            student4.surname = "Миронов";
            student4.data = "21.09.2023";
            student4.id = "445";
            student4.alcoholism = 0;
            student4.volume_alc = 450;

            Student student5 = new Student();
            student5.name = "Пантелеймон";
            student5.surname = "Селиверстов";
            student5.data = "21.09.2023";
            student5.id = "777";
            student5.alcoholism = 0;
            student5.volume_alc = 900;

            double all_alc = student1.volume_alc + student2.volume_alc + student3.volume_alc + student4.volume_alc + student5.volume_alc;
            Console.WriteLine($"Студент {student1.surname} {student1.name} с категорией алкоголизма: {student1.alcoholism} выпил {(student1.volume_alc / all_alc) * 100}%");
            Console.WriteLine($"Студент {student2.surname} {student2.name} с категорией алкоголизма: {student2.alcoholism} выпил {(student2.volume_alc / all_alc) * 100}%");
            Console.WriteLine($"Студент {student3.surname} {student3.name} с категорией алкоголизма: {student3.alcoholism} выпил {(student3.volume_alc / all_alc) * 100}%");
            Console.WriteLine($"Студент {student4.surname} {student4.name} с категорией алкоголизма: {student4.alcoholism} выпил {(student4.volume_alc / all_alc) * 100}%");
            Console.WriteLine($"Студент {student5.surname} {student5.name} с категорией алкоголизма: {student5.alcoholism} выпил {(student5.volume_alc / all_alc) * 100}%");
        }
    }
}
