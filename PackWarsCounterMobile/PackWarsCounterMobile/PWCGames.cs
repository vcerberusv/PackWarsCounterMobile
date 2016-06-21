using System;
using SQLite;

namespace PackWarsCounterMobile
{
    public class PWCGames
    {
        public PWCGames()
        {
        }

        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }                     //The index of the game in the table
        public string Name { get; set; }                //The name of the card game
        public int Num_Cards { get; set; }              //The number of cards per pack
        public int Num_types { get; set; }              //The number of card types there can be
        public string Types { get; set; }               //The types in ascending order of values of each type
        public string Values { get; set; }              //The values in ascending order by type
        public string Special { get; set; }             //The name of the special types of cards i.e. gold, foil
        public bool Custom { get; set; }                //If the entries are not custom made they cannot be deleted
    }
}
