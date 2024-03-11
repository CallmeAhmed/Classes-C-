
Game supermario = new Game("supermario", 2, "mario"); //this is use with the class having constructor function
//    Game GTA = new()
//    { // this methid is only work when we create a class without constructor
//        gamename = "GTA Vice City",
//    gameversion = 1,
//    company = "Grand Theft Auto"
//}; 
//Console.WriteLine(supermario.gamename);
Console.WriteLine($"{supermario.gamename}  {supermario.gameversion}  {supermario.company}");
//Console.WriteLine("{0} {1} {2}", GTA.gamename, GTA.gameversion, GTA.company);


Game Asphalt = new Game("Asphalt8", "Asphalt");
Console.WriteLine($"Our Company {Asphalt.company} Introduce a concept of a new game named {Asphalt.gamename}");
Console.ReadKey();


class Game
{
    public string gamename;
    public int gameversion;
    public string company;


    public Game(string gamename, int gameversion, string company)
    {
        this.gamename = gamename;
        this.gameversion = gameversion;
        this.company = company;
    }
    public Game(string gamename, int gameversion)
    {
        this.gamename = gamename;
        this.gameversion = gameversion;

    }
    public Game(string gamename)
    {
        this.gamename = gamename;

    }
    public Game(string gamename, string company)
    {
        this.gamename = gamename;
        this.company = company;

    }
}

//class Game(string gamename, int gameversion, string company)
//{
//    public string gamename = gamename;
//    public int gameversion = gameversion;
//    public string company = company;


//}