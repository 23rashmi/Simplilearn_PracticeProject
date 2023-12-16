using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerandTeamRequirements
{
    public class Player
    {
        public int PlayerId { get; set; }
        public string PlayerName { get; set; }
        public int PlayerAge { get; set; }
    }

    public interface ITeam
    {
        void Add(Player player);
        void Remove(int playerId);
        Player GetPlayerById(int playerId);
        Player GetPlayerByName(string playerName);
        List<Player> GetAllPlayers();
    }

    public class OneDayTeam : ITeam
    {
        public static List<Player> oneDayTeam = new List<Player>();

        public OneDayTeam()
        {
            // Constructor to set the capacity property to 11


            oneDayTeam = new List<Player>();

        }

        public void Add(Player player)
        {
            // Implementation for adding a player to the team

            oneDayTeam.Add(player);



        }

        public void Remove(int playerId)
        {
            // Implementation for removing a player from the team

        }

        public Player GetPlayerById(int playerId)
        {

            return oneDayTeam[playerId];
        }

        public Player GetPlayerByName(string playerName)
        {
            
        }
       

        public List<Player> GetAllPlayers()
        {
            // Implementation to get all players in the team
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            OneDayTeam oneDayTeam = new OneDayTeam();

            while (true)
            {
                // Display menu to the user
                Console.WriteLine("Enter 1: To Add Player 2: To Remove Player by Id 3: Get Player By Id 4: Get Player by Name 5: Get All Players");

                // Read user input
                int choice = Convert.ToInt32(Console.ReadLine());

                // Switch-case to perform actions based on user choice
                switch (choice)
                {
                    case 1:
                        // Add Player functionality
                        break;
                    case 2:
                        // Remove Player by Id functionality
                        break;
                    case 3:
                        // Get Player By Id functionality
                        break;
                    case 4:
                        // Get Player By Name functionality
                        break;
                    case 5:
                        // Get All Players functionality
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }
    }
}
