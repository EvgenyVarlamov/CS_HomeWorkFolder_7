/* Конвертер валют. У пользователя есть баланс в каждой из представленных валют. 
С помощью команд он может попросить сконвертировать одну валюту в другую. 
Курс конвертации просто описать в программе. 
Программа заканчивает свою работу в тот момент, когда решит пользователь. */

string[] money = {"RUB: ", "CNY: ", "BRL: ", "INR: ", "ZAR: "};                  // Название валют
double[] balance = new double[money.Length];                                     // Открытие счёта в указанных валютах
string[] commandList = {"Balance", "Convertor","Help","Exit"};                   // Массив с названиями команд
string[] converts = {"To RUB", "To CNY", "To BRL", "To INR", "To ZAR", "Exit"};  // Массив с названиями подкоманд
double[] ratesRub = {1, 0.103, 0.077, 1.16, 0.246};                              //Курсы валют
double[] ratesChy = {9.708, 1, 0.754, 11.2,  2.39};
double[] ratesBrr = {12.987, 1.326, 1, 11.84, 3.16};
double[] ratesIru = {0.862, 0.089, 0.084, 1, 0.214};
double[] ratesSar = {4.065, 0.418, 0.316, 4.672, 1};
string message = "Вы можете узнать свой текущий баланс, а также произвести конвертацию имеющихся валют на любую доступную сумму.";

// Пополнение счетов в валютах //////////////////////////////////////////////////
for (int i = 0; i < balance.Length; i++)
{
    balance[i] = Math.Round(new Random().NextDouble()*100000, 2);
}

// Основной код программы ///////////////////////////////////////////////////////
string? password = "123";
int tryOpen = 3;
Console.WriteLine("Введите пароль: ");

for (int i = 1; i <= tryOpen; i++)  
{
    Console.Write($"Ваша {i}-я попытка: ");

    if (Console.ReadLine() == password) 
    {
        Console.WriteLine("Пароль введен правильно");
        Console.WriteLine();
        while (true)
        {
            Console.Write("Главное меню > ");
            MainCommadsList();
            Console.Write("Введите команду: ");
            string? command = Console.ReadLine();
            Console.WriteLine();
            if (command?.ToLower() == "balance")
            {
                PrintBalanse(money, balance);
            }
            else if (command?.ToLower() == "convertor")
            {
                for (;;)
                {                    
                    Console.Write("Подменю конвертации > ");
                    ConvertList();
                    Console.Write("Введите подкоманду: ");
                    string? subcommand = Console.ReadLine();
                    Console.WriteLine();
                    int codeMoney = 0;
                    if (subcommand?.ToLower() == "exit")
                    {
                        Console.WriteLine("Выход из подменю конвертации");
                        Console.WriteLine();
                        break;
                    }
                    else if (subcommand?.ToLower() == "to rub")
                    {
                        codeMoney = 0;
                        MoneyConverter(money, balance, ratesRub, codeMoney);
                    }
                    else if (subcommand?.ToLower() == "to cny")
                    {
                        codeMoney = 1;
                        MoneyConverter(money, balance, ratesChy, codeMoney);
                    }
                    else if (subcommand?.ToLower() == "to brl")
                    {
                        codeMoney = 2;
                        MoneyConverter(money, balance, ratesBrr, codeMoney);
                    }
                    else if (subcommand?.ToLower() == "to inr")
                    {
                        codeMoney = 3;
                        MoneyConverter(money, balance, ratesIru, codeMoney);
                    }
                    else if (subcommand?.ToLower() == "to zar")
                    {
                        codeMoney = 4;
                        MoneyConverter(money, balance, ratesSar, codeMoney);
                    }
                    else
                    {
                        Console.WriteLine("Такой команды не существует");
                    }
                }
                
            }
            else if (command?.ToLower() == "help")
            {
                Console.WriteLine(message);
                Console.WriteLine();
            }
            else if (command?.ToLower() == "exit")
            {
                Console.WriteLine("Работа с программой завершена");
                break;
            }
            else
            {
                Console.WriteLine("Такой команды не существует");
            }
        }
        break;
    }
    else if(i == tryOpen)
    {
        Console.WriteLine("Доступ заблокирован");
    }
} 

// Метод/функция вывода баланса /////////////////////////////////////////////////
void PrintBalanse(string[] arrayMoney, double[] arrayBalance)
{
    Console.WriteLine("Ваш баланс:");
    for (int i = 0; i < arrayMoney.Length; i++)
    {
        Console.WriteLine(arrayMoney[i] + arrayBalance[i]);
    }
    Console.WriteLine();
}

// Метод/функция вызова списка команд ///////////////////////////////////////////
void MainCommadsList()
{
    Console.WriteLine("Список команд:");
    for (int i = 0; i < commandList.Length; i++)
    {
        Console.Write($"<{commandList[i]}> ");
    }
    Console.WriteLine();
}

// Метод/функция вызова списка подкоманд ////////////////////////////////////////
void ConvertList()
{
    Console.WriteLine("Список команд конвертации:");
    for (int i = 0; i < converts.Length; i++)
    {
        Console.Write($"<{converts[i]}> ");
    }
    Console.WriteLine();
}

// Метод/функция конвертации валют //////////////////////////////////////////////
void MoneyConverter(string[] moneyName, double[] arrayConvert, double[] rates, int moneyCode)
{
    PrintBalanse(money, balance);
    
    double[] sumConvert = new double[arrayConvert.Length];
        
    for (int i = 0; i < arrayConvert.Length; i++)
    {
        Console.Write("Сумма конвертации ");
        Console.Write(moneyName[i]);
        while (true)
        {
            sumConvert[i] = Convert.ToDouble(Console.ReadLine());
            if (sumConvert[i] > arrayConvert[i] || sumConvert[i] < 0)
            {
                Console.WriteLine("Введёна некорректная сумма");
                Console.Write("Сумма конвертации ");
                Console.Write(moneyName[i]);
            }
            else
            {
                break;
            }
        }
        arrayConvert[moneyCode] = Math.Round(arrayConvert[moneyCode] + rates[i]*sumConvert[i], 2);
        arrayConvert[i] -= sumConvert[i];
        Math.Round(arrayConvert[i], 2);
    }
    Console.WriteLine();
    Console.WriteLine("Конвертация завершена");
    PrintBalanse(money, arrayConvert);
}