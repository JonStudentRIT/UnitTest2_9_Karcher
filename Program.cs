using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest2_9
{
    /* Interface: IPlayer
     * Author: Jonathan Karcher
     * Purpose: Gives a list of actions that a player can perform
     */
    public interface IPlayer
    {
        /* Method: EatSnacks
         * Purpose: Eat Snacks
         * Restrictions: None
         */
        void EatSnacks();
        /* Method: PauseGame
         * Purpose: Pause the game your playing
         * Restrictions: None
         */
        void PauseGame();
        /* Method: ExitGame
         * Purpose: Exit the game your playing
         * Restrictions: None
         */
        void ExitGame();
    }
    /* Interface: IPlatform
     * Author: Jonathan Karcher
     * Purpose: Gives a list of actions that the Game Platform can perform
     */
    public interface IPlatform
    {
        /* Method: InconvenientUpdate
         * Purpose: Update the platform
         * Restrictions: None
         */
        void InconvenientUpdate();
        /* Method: PlayGame
         * Purpose: See if the game is playable and if so play it
         * Restrictions: None
         */
        void PlayGame(Game game);
        /* Method: LoadGame
         * Purpose: load the game
         * Restrictions: None
         */
        void LoadGame();
    }
    /* Class: Platform
     * Author: Jonathan Karcher
     * Purpose: defines the basic actions of any platform
     */
    public abstract class Platform : IPlatform
    {
        // string describing the system requierments
        private string systemRequierments;
        /* Method: InconvenientUpdate
         * Purpose: Update the platform
         * Restrictions: None
         */
        public void InconvenientUpdate()
        { }
        /* Method: PlayGame
         * Purpose: Play the game
         * Restrictions: None
         */
        public void PlayGame(Game game)
        { }
        /* Method: LoadGame
         * Purpose: Load the game
         * Restrictions: None
         */
        public void LoadGame()
        { }
        /* Method: CheckSystemRequierments
         * Purpose: Returns the requierments to play the game
         * Restrictions: None
         */
        public virtual string CheckSystemRequierments()
        {
            return systemRequierments;
        }
        /* Method: ConnectToTheInternet
         * Purpose: Connect to the internet
         * Restrictions: None
         */
        public abstract void ConnectToTheInternet();
        /* Method: DisconnectFromTheInternet
         * Purpose: Disconnect from the internet
         * Restrictions: None
         */
        public abstract void DisconnectFromTheInternet();
    }
    /* Class: GamingPC
     * Author: Jonathan Karcher
     * Purpose: defines a gaming PC
     */
    public class GamingPC : Platform
    {
        // string describing the system requierments
        private string systemRequierments;
        /* Constructor: GamingPC
         * Purpose: Create a GamingPC
         * Restrictions: None
         */
        public GamingPC(string systemRequierments)
        {
            this.systemRequierments = systemRequierments;
        }
        /* Method: CheckSystemRequierments
         * Purpose: Check the system requierments
         * Restrictions: None
         */
        public override string CheckSystemRequierments()
        {
            return systemRequierments;
        }
        /* Method: ConnectToTheInternet
         * Purpose: Connect to the internet
         * Restrictions: None
         */
        public override void ConnectToTheInternet()
        { }
        /* Method: DisconnectFromTheInternet
         * Purpose: Disconnect from the internet
         * Restrictions: None
         */
        public override void DisconnectFromTheInternet()
        { }
    }
    /* Class: Mobile
     * Author: Jonathan Karcher
     * Purpose: defines a Mobile platform
     */
    public class Mobile : Platform
    {
        // string describing the system requierments
        private string systemRequierments;
        /* Constructor: Mobile
         * Purpose: Create a Mobile platform
         * Restrictions: None
         */
        public Mobile(string systemRequierments)
        {
            this.systemRequierments = systemRequierments;
        }
        /* Method: CheckSystemRequierments
         * Purpose: Check the system requierments
         * Restrictions: None
         */
        public override string CheckSystemRequierments()
        {
            return systemRequierments;
        }
        /* Method: ConnectToTheInternet
         * Purpose: Connect to the internet
         * Restrictions: None
         */
        public override void ConnectToTheInternet()
        { }
        /* Method: DisconnectFromTheInternet
         * Purpose: Disconnect from the internet
         * Restrictions: None
         */
        public override void DisconnectFromTheInternet()
        { }
    }
    /* Class: GamingConsole
     * Author: Jonathan Karcher
     * Purpose: defines a Gaming Console
     */
    public class GamingConsole : Platform
    {
        // string describing the system requierments
        private string systemRequierments;
        /* Constructor: GamingConsole
         * Purpose: Create a Gaming Console
         * Restrictions: None
         */
        public GamingConsole(string systemRequierments)
        {
            this.systemRequierments = systemRequierments;
        }
        /* Method: CheckSystemRequierments
         * Purpose: Check the system requierments
         * Restrictions: None
         */
        public override string CheckSystemRequierments()
        {
            return systemRequierments;
        }
        /* Method: ConnectToTheInternet
         * Purpose: Connect to the internet
         * Restrictions: None
         */
        public override void ConnectToTheInternet()
        { }
        /* Method: DisconnectFromTheInternet
         * Purpose: Disconnect from the internet
         * Restrictions: None
         */
        public override void DisconnectFromTheInternet()
        { }
    }
    /* Class: Player
     * Author: Jonathan Karcher
     * Purpose: defines a Player
     */
    public class Player : IPlayer
    {
        /* Method: EatSnacks
         * Purpose: Eat Snacks
         * Restrictions: None
         */
        public void EatSnacks()
        { }
        /* Method: PauseGame
         * Purpose: Pause the game your playing
         * Restrictions: None
         */
        public void PauseGame()
        { }
        /* Method: ExitGame
         * Purpose: Exit the game your playing
         * Restrictions: None
         */
        public void ExitGame()
        { }
    }
    /* Class: Game
     * Author: Jonathan Karcher
     * Purpose: defines a Game
     */
    public class Game
    {
        // the name of the game
        string name;
        // what kind of platform the game can play on 
        string systemRequierments;
        /* Property: Name
         * Purpose: Returns the name of the game
         * Restrictions: Read only
         */
        public string Name { get { return name; } }
        /* Property: SystemRequierments
         * Purpose: Returns the requierments of the game
         * Restrictions: Read only
         */
        public string SystemRequierments { get { return systemRequierments; } }
        /* Constuctor: Game
         * Purpose: Creats a game
         * Restrictions: None
         */
        public Game(string name, string systemRequierments)
        {
            this.name = name;
            this.systemRequierments = systemRequierments;
        }
    }
    /* Class: Program
     * Author: Jonathan Karcher
     * Purpose: Main entery class for the program
     */
    class Program
    {
        /* Method: Main
         * Purpose: Main entery point for the program
         * Restrictions: None
         */
        static void Main(string[] args)
        {
            // create a player
            Player player = new Player();
            // create a game
            Game game = new Game("Awesome Adventures", "GamingPC");
            // create a mobile platform
            Mobile mobile = new Mobile("Mobile");
            // create a gaming PC
            GamingPC gamingPC = new GamingPC("GamingPC");
            // create a Gaming Console
            GamingConsole gamingConsole = new GamingConsole("GamingConsole");
            // Call PlayAGame on each platform and the game
            PlayAGame(mobile, game);
            PlayAGame(gamingPC, game);
            PlayAGame(gamingConsole, game);
        }
        /* Method: PlayAGame
         * Purpose: play the game if possible
         * Restrictions: None
         */
        public static void PlayAGame(object platform, Game game)
        {
            // create a platform interface reference
            IPlatform iplatform;
            // cast the platform interface to the platform
            iplatform = (IPlatform)platform;
            // create a basic platform reference
            Platform testingPlatform;
            // cast to the basic platform
            testingPlatform = (Platform)platform;
            // check to see if the platfoms system requierments are equal to the games system requierments 
            if(testingPlatform.CheckSystemRequierments().Equals(game.SystemRequierments))
            {
                // if so then play the game 
                Console.WriteLine("Starting: " + game.Name);
                iplatform.PlayGame(game);
            }
            else
            {
                // otherwise inform the player that it cant be played
                Console.WriteLine(game.Name + ", can not be played on this platform");
            }
        }
    }
}
