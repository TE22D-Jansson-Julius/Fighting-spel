using System.Runtime.Intrinsics.Arm;

var random = new Random();
int damage;
string restart;
bool game = true;


Player player1 = new Player();
Player player2 = new Player();
//Different enemies 
string[] names = { "Adaladis", "Morotskillen", "Ben Dover", "Stenis", "Viggo" };

//Different weaponds and their damage
Object[][] weapons ={
new object[]{"Katana", 40, 50},
new object[]{"Matkort", 90, 100},
new object[]{"Kattspya Med Bajs", 20, 80}
};


player2.name = names[random.Next(0, names.Count())];


//void Adam()
//{if (player2.name == "Adaladis"){
//}



//The start 
while (game)
{
   player2.name = names[random.Next(0, names.Count())]; //Picks a random name

   player1.hp = 100; //Sets the hp of both the player and the opponent to 100
   player2.hp = 100;

   if (player2.name == "Adaladis")
   {
      player2.hp = 200;
   }

   Console.WriteLine("What does thy wish to be called?");
   player1.name = Console.ReadLine().Trim();

   Console.WriteLine();

   Console.WriteLine($"{player1.name} Press enter to start the fight.");
   Console.ReadLine();

   Console.WriteLine($"{player1.name} vs {player2.name} \n{player1.name}: {player1.hp}hp \n{player2.name}: {player2.hp}hp \nPress enter to attack");

   if (player2.name == "Adaladis")
   {
      Console.WriteLine("Woaw what a tjockis he looks like Nikocado \n Wait he is so fat that his hp has doubled");
   }
   Console.ReadLine();


   while (player1.hp > 0 && player2.hp > 0)
   {

      damage = random.Next(25, 40);


      Console.WriteLine($"{player1.name} attacks");
      player2.hp -= damage;
      Console.ReadLine();



      if (player2.hp < 0)
      {
         player2.hp = 0;
         Console.WriteLine($"{player1.name}: {player1.hp}hp \n{player2.name}: {player2.hp}hp");
      }
      else
      {
         Console.WriteLine($"{player1.name}: {player1.hp}hp \n{player2.name}: {player2.hp}hp");
      }
      Console.ReadLine();

      damage = random.Next(25, 41);

      //End of the game
      if (player2.hp <= 0)
      {

         Console.WriteLine($"You Beat the fat and ugly {player2.name}");
         Console.ReadLine();
         Console.WriteLine("To play again type 1 \nTo end game type anything");

         restart = Console.ReadLine();
         if (restart != "1")
         {
            game = false;
            break;
         }
         if (restart == "1")
         {
            continue;
         }
      }

      Console.WriteLine($"{player2.name} attacks");
      player1.hp -= damage;
      Console.ReadLine();

      if (player1.hp < 0)
      {
         player1.hp = 0;
         Console.WriteLine($"{player1.name}: {player1.hp}hp \n{player2.name}: {player2.hp}hp");
      }
      else
      {
         Console.WriteLine($"{player1.name}: {player1.hp}hp \n{player2.name}: {player2.hp}hp");
      }
      Console.ReadLine();

      //End of the game
      if (player1.hp <= 0)
      {
         player1.hp = 0;
         if (player2.name == "Adaladis")
         {
            Console.WriteLine($"You got crushed by the fat {player2.name} who looks like Snorlax.");
         }
         if (player2.name == "Morotskillen")
         {
            Console.WriteLine($"{player2.name}forces you to eat his big and juicy morot.");
         }
         if (player2.name == "Viggo")
         {
            Console.WriteLine($"{player2.name}sits on you slapping you and screaming. DET STAVAS MED W!");
         }
         if (player2.name == "Ben Dover")
         {
            Console.WriteLine($"{player2.name}says BEND OVER NOW!");
         }
         if (player2.name == "Stenis")
         {
            Console.WriteLine($"{player2.name}Hopskuttar into a slangbellis shooting himself hitting your blowing up your huvud.");
         }
      }
   }


   // Console.WriteLine($"You got crushed by the fat {player2.name} who looks like Snorlax");
   Console.ReadLine();
   Console.WriteLine("To play again type 1 \nTo end game type anything");
   restart = Console.ReadLine();
   if (restart != "1")
   {
      game = false;
      break;
   }
   else
   {
      continue;
   }
}







//Makes a class 
class Player
{
   //public int weapon;

   public string name;

   public int hp = 100;

}
