// See https://aka.ms/new-console-template for more information
using Football_3_Pas_and_Goal;
using System.ComponentModel;


namespace FootBall
{
    class Program
    {
        static void Main(string[] args)
        {

            


            List<Footballer> team = new List<Footballer>();

            team.Add(new Footballer("Fernando Muslera", 1));
            team.Add(new Defender("Sacha Boey", 2));
            team.Add(new Defender("Victor Enok Nelsson", 3));
            team.Add(new Defender("Abdülkerim Bardakc", 4));
            team.Add(new Defender("Emin Bayram", 5));
            team.Add(new Midfielder("Lucas Torreira", 6));
            team.Add(new Midfielder("Fredrik Midtsjö", 7));
            team.Add(new Midfielder("Sergio Oliveira", 8));
            team.Add(new Midfielder("Barış Alper Yılmaz", 9));
            team.Add(new Forvard("Mauro Icardi", 10));
            team.Add(new Forvard("Bafetimbi Gomis", 11));

            Random random = new Random();
            Footballer footballer = new Footballer();
            Boolean SituationGoal = true;
            int PlayerNo = random.Next(1,12);
            int PassControl = 12;


            for (int i = 1; i <= 3; i++)
            {
                while(PassControl == PlayerNo)
                {
                    PlayerNo = random.Next(1, 12);
                }

                PassControl = PlayerNo;



                if (!team[PlayerNo-1].PassMetot())
                {
                    Console.WriteLine(PlayerNo + " Made a mistake while passing");
                    SituationGoal = false;
                    break;
                }
                else 
                {
                    Console.WriteLine(PlayerNo + " Successful pass");
                    System.Threading.Thread.Sleep(1000);
                }


            }

            Console.WriteLine(PlayerNo + " The player is very close to the goal");
            System.Threading.Thread.Sleep(1000);
            if (SituationGoal = true)
            {


                if (team[PlayerNo -1].GoolMetot())
                {
                    Console.WriteLine("GOOOOOOOOOOL" + PlayerNo);
                }

                else
                {
                    Console.WriteLine(PlayerNo + " narrowly missed the goal");
                }

               



            }

            Console.ReadLine();













        }





















    }






}
















