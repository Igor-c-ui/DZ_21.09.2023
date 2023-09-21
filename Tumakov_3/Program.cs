using System;

namespace Tumakov_3
{
    internal class Program
    {
        enum Type_bank_account 
        {
            Текущий,
            Сберегательный
        }
        struct Bank_account 
        {
            public string number;
            public Type_bank_account type_account;
            public double balance;
        }
        enum Vuz 
        {
            Kgu,
            Kai,
            Kxti
        }
        public struct Worker 
        {
            public string name;
            public string vuz;
        }
        static void Main(string[] args)
        {
            // Упр.3_1 Вывести тип банковского счета
            Console.WriteLine("Упр.3_1 Вывести тип банковского счета");
            Type_bank_account account = Type_bank_account.Сберегательный;
            Console.WriteLine(account);

            // Упр.3_2 Создать структуру с информацией об банковском счёте, заполнить ее и вывести информацию
            Console.WriteLine("Упр.3_2 Создать структуру с информацией об банковском счёте, заполнить ее и вывести информацию");
            Bank_account acc = new Bank_account();
            acc.number = "40312345634901546237";
            acc.type_account = 0;
            acc.balance= 5432.45;
            Console.WriteLine($"Номер банковского счета: {acc.number}, тип: {acc.type_account}, баланс: {acc.balance}");
            /* ДЗ_3.1 Создать перечислимый тип ВУЗ{КГУ, КАИ, КХТИ}. Создать
структуру работник с двумя полями: имя, ВУЗ. Заполнить структуру данными и
распечатать.*/
            Console.WriteLine("ДЗ_3.1 Создать перечислимый тип ВУЗ{КГУ, КАИ, КХТИ}. Создать\r\nструктуру работник с двумя полями: имя, ВУЗ. Заполнить структуру данными и\r\nраспечатать.");
            Vuz vuz = Vuz.Kai;
            Vuz vuz2 = Vuz.Kxti;
            Vuz vuz3 = Vuz.Kgu;
            Worker worker = new Worker();
            Worker worker2 = new Worker();
            Worker worker3 = new Worker();
            worker.name = "Сераж";
            worker.vuz = Convert.ToString(vuz);
            worker2.name = "Сердар";
            worker2.vuz = Convert.ToString(vuz2);
            worker3.name = "Абдылжапар";
            worker3.vuz = Convert.ToString(vuz3);
            Console.WriteLine("Имя 1 работника - {0}, вуз - {1}.",worker.name, worker.vuz);
            Console.WriteLine("Имя 2 работника - {0}, вуз - {1}.", worker2.name, worker2.vuz);
            Console.WriteLine("Имя 3 работника - {0}, вуз - {1}.", worker3.name, worker3.vuz);
        }
    }
}
