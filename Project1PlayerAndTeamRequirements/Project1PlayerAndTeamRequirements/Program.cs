using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1PlayerAndTeamRequirements
{
    public class Player
    {
        public int PlayerId
        {
            get; set;
        }
        public string PlayerName
        {
            get; set;
        }
        public int PlayerAge
        {
            get; set;
        }
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


        }


        public void Add(Player player)
        {
            if (oneDayTeam.Count < 11)
            {
                // Check if the team size is less than 11
                // Implementation for adding a player to the team
                if (!PlayerIdExists(player.PlayerId))
                {
                    oneDayTeam.Add(player);
                    Console.WriteLine($"Player {player.PlayerName} added to the team.");
                }
                else
                {
                    Console.WriteLine($"Player with ID {player.PlayerId} already exists in the team.");
                }
            }
            else
            {
                Console.WriteLine("Cannot add more than 11 players to the team.");
            }




        }

        

        public void Remove(int playerId)
        {
            // Implementation for removing a player from the team by Id
            Player playerToRemove = oneDayTeam.Find(player => player.PlayerId == playerId);

            if (playerToRemove != null)
            {
                oneDayTeam.Remove(playerToRemove);
                Console.WriteLine($"Player with ID {playerId} removed from the team.");
            }
            else
            {
                Console.WriteLine($"Player with ID {playerId} not found in the team.");
            }
        }

        public Player GetPlayerById(int playerId)
        {
            // Implementation to get a player by Id
            return oneDayTeam.Find(player => player.PlayerId == playerId);
        }

        public Player GetPlayerByName(string playerName)
        {
            // Implementation to get a player by name
            return oneDayTeam.Find(player => player.PlayerName == playerName);
        }

        public List<Player> GetAllPlayers()
        {
            // Implementation to get all players in the team
            return oneDayTeam;
        }

        private bool PlayerIdExists(int playerId)
        {
            // Check if a player with the given ID already exists in the team
            return oneDayTeam.Exists(player => player.PlayerId == playerId);
        }

        // Implement other ITeam interface methods as needed
    }


    class Program
    {
        static void Main(string[] args)
        {

            OneDayTeam oneDayTeam = new OneDayTeam();
            bool continueRunning = true;

            while (continueRunning)
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
                        Console.Write("Enter Player Id: ");
                        int playerId = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Enter Player Name: ");
                        string playerName = Console.ReadLine();

                        Console.Write("Enter Player Age: ");
                        int playerAge = Convert.ToInt32(Console.ReadLine());

                        Player newPlayer = new Player
                        {
                            PlayerId = playerId,
                            PlayerName = playerName,
                            PlayerAge = playerAge
                        };

                        oneDayTeam.Add(newPlayer);
                        break;
                    case 2:
                        // Remove Player by Id functionality
                        Console.Write("Enter Player Id to remove: ");
                        int playerIdToRemove = Convert.ToInt32(Console.ReadLine());

                        oneDayTeam.Remove(playerIdToRemove);
                        break;
                    case 3:
                        // Get Player by Id functionality
                        Console.Write("Enter Player Id to get details: ");
                        int playerIdToGet = Convert.ToInt32(Console.ReadLine());

                        Player playerDetailsById = oneDayTeam.GetPlayerById(playerIdToGet);

                        if (playerDetailsById != null)
                        {
                            Console.WriteLine($"Player ID: {playerDetailsById.PlayerId}, Name: {playerDetailsById.PlayerName}, Age: {playerDetailsById.PlayerAge}");
                        }
                        else
                        {
                            Console.WriteLine($"Player with ID {playerIdToGet} not found in the team.");
                        }
                        break;
                    case 4:
                        // Get Player by Name functionality
                        Console.Write("Enter Player Name to get details: ");
                        string playerNameToGet = Console.ReadLine();

                        Player playerDetailsByName = oneDayTeam.GetPlayerByName(playerNameToGet);

                        if (playerDetailsByName != null)
                        {
                            Console.WriteLine($"Player ID: {playerDetailsByName.PlayerId}, Name: {playerDetailsByName.PlayerName}, Age: {playerDetailsByName.PlayerAge}");
                        }
                        else
                        {
                            Console.WriteLine($"Player with Name {playerNameToGet} not found in the team.");
                        }
                        break;
                    case 5:
                        // Get All Players functionality
                        List<Player> allPlayers = oneDayTeam.GetAllPlayers();

                        Console.WriteLine("All Players in the Team:");
                        foreach (var player in allPlayers)
                        {
                            Console.WriteLine($"Player ID: {player.PlayerId}, Name: {player.PlayerName}, Age: {player.PlayerAge}");
                        }
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }



                //ask the user if they want to continue

                Console.Write("Do you want to continue? (Yes/No): ");
                char continueChoice = Console.ReadLine().ToUpper()[0];
                continueRunning = (continueChoice == 'Y');


            }
        }
    }
}
