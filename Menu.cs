using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Runtime;
using System.Security;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1
{
    static class ConstantKey
    {
        public const int KEY_UP = 72;
        public const int KEY_DOWN = 80;
        public const int KEY_LEFT = 75;
        public const int KEY_RIGHT = 77;
        public const int KEY_ENTER = 13;
        public const int KEY_BACKSPACE = 8;
        public const int KEY_ESC = 27;
    }
    enum ERole
    {
        Broker,
        App
    };

    enum EOptions
    {
        Option1 = 0,
        Option2 = 1,
        Option3 = 2,
        Option4 = 3
    }
    enum EMenu
    {
        None,
        MainMenu,
        AppMenu,
        BrokerMenu,
        ContractMenu
    }

    internal class Menu
    {
        //Tạo người thuê
        static Employer myEmployer1 = new Employer("052204007418", "Nguyen Van Vu", "0123", "01 Vo Van Ngan", new DateTime(2004, 1, 1));
        static Employer myEmployer2 = new Employer("072204000255", "Ho Thanh Dat", "0123", "02 Vo Van Ngan", new DateTime(2004, 3, 26));

        //Tạo đối tượng thuê bằng app
        ByApp a = new ByApp(myEmployer1);

        //Tạo đối tượng thuê bằng người môi giới
        ByBroker b = new ByBroker(myEmployer2);

        public void StartMenu()
        {
            int option = 20000;
            EMenu currentMenu = EMenu.MainMenu;
            char key;

            while (true)
            {
                Console.Clear();
                Console.WriteLine("============== HIRING MAID ==============");
                PrintMenu(currentMenu, option);
                ConsoleKeyInfo keyInfo = Console.ReadKey(true);

                while (true)
                {
                    switch (keyInfo.Key)
                    {
                        case ConsoleKey.Enter:
                            switch (currentMenu)
                            {
                                case EMenu.MainMenu:
                                    switch (option % GetMenuOptions(currentMenu).Length)
                                    {
                                        case (int)EOptions.Option1:
                                            currentMenu = EMenu.AppMenu;
                                            break;
                                        case (int)EOptions.Option2:
                                            currentMenu = EMenu.BrokerMenu;
                                            break;
                                        case (int)EOptions.Option3:
                                            currentMenu = EMenu.ContractMenu;
                                            break;
                                        case (int)EOptions.Option4:
                                            Exit();
                                            break;
                                    }
                                    break;
                                case EMenu.AppMenu:
                                    switch (option % GetMenuOptions(currentMenu).Length)
                                    {
                                        case (int)EOptions.Option1:
                                            Console.Clear();
                                            a.printListDomesticHelper();
                                            Console.WriteLine("Do you want to return previous menu? (Y/N)");
                                            key = Char.ToLower(Console.ReadKey().KeyChar);
                                            if (key == 'y')
                                            {
                                                break;
                                            }
                                            else
                                            {
                                                continue;
                                            }
                                        case (int)EOptions.Option2:
                                            Console.Clear();
                                            a.filterDomesticHelper();
                                            a.signContract();
                                            Console.WriteLine("Do you want to return previous menu? (Y/N)");
                                            key = Char.ToLower(Console.ReadKey().KeyChar);
                                            if (key == 'y')
                                            {
                                                break;
                                            }
                                            else
                                            {
                                                continue;
                                            }
                                        case (int)EOptions.Option3:
                                            currentMenu = EMenu.MainMenu;
                                            break;
                                    }
                                    break;
                                case EMenu.BrokerMenu:
                                    switch (option % GetMenuOptions(currentMenu).Length)
                                    {
                                        case (int)EOptions.Option1:
                                            Console.Clear();
                                            b.SelectBrokerAndHelper();
                                            Console.WriteLine("Do you want to return previous menu? (Y/N)");
                                            key = Char.ToLower(Console.ReadKey().KeyChar);
                                            if (key == 'y')
                                            {
                                                break;
                                            }
                                            else
                                            {
                                                continue;
                                            }
                                        case (int)EOptions.Option2:
                                            currentMenu = EMenu.MainMenu;
                                            break;
                                    }
                                    break;
                                case EMenu.ContractMenu:
                                    switch (option % GetMenuOptions(currentMenu).Length)
                                    {
                                        case (int)EOptions.Option1:
                                            //Thêm method cho xem những bản hợp đồng
                                            break;
                                        case (int)EOptions.Option2:
                                            currentMenu = EMenu.MainMenu;
                                            break;
                                    }
                                    break;
                            }
                            option = 0;
                            break;
                        case ConsoleKey.UpArrow:
                            option = (option - 1 + GetMenuOptions(currentMenu).Length) % GetMenuOptions(currentMenu).Length;
                            break;
                        case ConsoleKey.DownArrow:
                            option = (option + 1) % GetMenuOptions(currentMenu).Length;
                            break;
                        case ConsoleKey.Escape:
                            Exit();
                            break;
                    }

                    if (currentMenu != EMenu.None)
                    {
                        Console.Clear();
                        PrintMenu(currentMenu, option);
                        break;
                    }
                }

                void PrintMenu(EMenu type, int option)
                {
                    string[] options = GetMenuOptions(type);

                    for (int i = 0; i < options.Length; i++)
                    {
                        if (i == option % options.Length)
                        {
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.BackgroundColor = ConsoleColor.White;
                            Console.WriteLine($"\t> {options[i]}");
                            Console.ResetColor();
                        }
                        else
                        {
                            Console.WriteLine($"\t{options[i]}");
                        }
                    }
                }

                string[] GetMenuOptions(EMenu type)
                {
                    switch (type)
                    {
                        case EMenu.MainMenu:
                            return new string[] { "1. Hiring maid by App.", "2. Hiring maid by Broker", "3. About Contract.", "4. Exit." };
                        case EMenu.AppMenu:
                            return new string[] { "1. Show list of available Domestic Helper.", "2. Insert your requirement.", "3. Return to main menu." };
                        case EMenu.BrokerMenu:
                            return new string[] { "1. Show list of available Broker.", "2. Return to main menu." };
                        case EMenu.ContractMenu:
                            return new string[] { "1. Show available contracts.", "2. Return to main menu." };
                        default:
                            return new string[0];
                    }
                }

            }
            void Exit()
            {
                Console.WriteLine("Do you want to exit the program? (Y/N)");
                char response = Char.ToLower(Console.ReadKey().KeyChar);

                if (response == 'y')
                {
                    Environment.Exit(0);
                }
            }
        }
    }
}

