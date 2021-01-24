using System;

namespace DictHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDict<string, string> player_Club = new MyDict<string, string>();

            player_Club.Add("Mesut Ozil","Fenerbahçe");
            player_Club.Add("Sosa","Fenerbahçe");
            player_Club.Add("Drinkwater", "Kasımpaşa");
            player_Club.Add("Abobakar","Beşiktaş");
            player_Club.Add("Gustavo","Fenerbahçe");

            player_Club.ShowAll();
        }
    }
}
