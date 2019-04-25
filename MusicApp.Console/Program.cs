using MusicApp.DataAccess;
using System;

namespace MusicApp.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int choice = 0;
                bool check = false;
                while (!check)
                {
                    System.Console.Clear();
                    System.Console.Write("\tМузыкальная коллекция\n" +
                                        "1) Добавить группу\n" +
                                        "2) Добавить песню\n" +
                                        "3) Найти группу\n" +
                                        "4) Найти песню\n" +
                                        "5) Изменить группу\n" +
                                        "6) Изменить песню\n" +
                                        "7) Удалить группу\n" +
                                        "8) Удалить песню\n" +
                                        "9) Выход\n" +
                                        "Выберите действие: ");
                    check = int.TryParse(System.Console.ReadLine(), out choice);
                    if (choice < 1 || choice > 9)
                        check = false;
                    if (choice == 9)
                        Environment.Exit(0);
                }
                System.Console.Clear();

                string name = "";
                if (choice >= 3 && choice % 2 == 1)
                {
                    System.Console.Write("Введите название группы: ");
                    name = System.Console.ReadLine();
                }
                else if(choice >= 4 && choice % 2 == 0)
                {
                    System.Console.WriteLine("Введите название песни: ");
                    name = System.Console.ReadLine();
                }

                switch (choice)
                {
                    case 1: SongsTableDataService.InsertTeam(); break;
                    case 2: SongsTableDataService.InsertSong(); break;
                    case 3: SongsTableDataService.FindTeam(name); break;
                    case 4: SongsTableDataService.FindSong(name); break;
                    case 5: SongsTableDataService.UpdateTeam(name); break;
                    case 6: SongsTableDataService.UpdateSong(name); break;
                    case 7: SongsTableDataService.DeleteTeam(name); break;
                    case 8: SongsTableDataService.DeleteSong(name); break;
                }
            }
        }
    }
}
