using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football_3_Pas_and_Goal
{
    internal class Footballer
    {
        public Random random = new Random();

        protected string NameSurname;
        protected int No;
        protected int Speed;
        protected int Stamina;
        protected int Pass;
        protected int Shot;
        protected int Skill;
        protected int DecisionMaking;
        protected int NaturalForm;
        protected int Luck;

       

        public Footballer(string NameSurname , int No)
        {
           
            Speed = random.Next(50,100);
            Stamina = random.Next(50,100);
            Pass = random.Next(50,100);
            Shot= random.Next(50,100);
            Skill= random.Next(50,100);
            DecisionMaking= random.Next(50,100);
            NaturalForm= random.Next(50,100);
            Luck= random.Next(50,100);
        }

        public Footballer()
        {

        }

        public virtual Boolean PassMetot()
        {
            int PassScore = Convert.ToInt32(Pass * 0.3 + Skill * 0.3 + Stamina * 0.1 + NaturalForm * 0.1 + Luck * 0.2);

            if (PassScore > 60)
            {
                return true;
            }
            else
            {
                return false;
            }


        }

        public virtual Boolean GoolMetot()
        {
            int GoolScore = Convert.ToInt32(Skill * 0.3 + Shot * 0.2 + DecisionMaking * 0.1 + NaturalForm * 0.1 + Speed * 0.1 + Luck * 0.2);

            if(GoolScore > 70)
            {
                return true;
            }
            else
            {
                return false;
            }


        }




    }


    internal class Defender : Footballer
    {
        private int Positioning;
        private int Header;
        private int Jumping;

        public Defender(string namesurname,int no)
        {
            this.NameSurname= namesurname;
            this.No = no;

            Speed = random.Next(50, 90);
            Stamina = random.Next(50, 90);
            Pass = random.Next(50, 90);
            Shot = random.Next(50, 90);
            Skill = random.Next(50, 90);
            DecisionMaking = random.Next(50, 90);
            NaturalForm = random.Next(50, 90);
            Luck = random.Next(50, 90);

            Positioning = random.Next(50,90);
            Header = random.Next(50,90);
            Jumping = random.Next(50, 90);
        }

        public override Boolean PassMetot()
        {
            int PassScore = Convert.ToInt32(Pass * 0.3 + Skill * 0.3 + Stamina * 0.1 + NaturalForm * 0.1 + Positioning * 0.1 + Luck * 0.2 );

            if (PassScore > 60)
            {
                return true;
            }
            else
            {
                return false;
            }


        }

        public override Boolean GoolMetot()
        {
            int GoolScore = Convert.ToInt32(Skill * 0.3 + Shot + 0.2 + DecisionMaking * 0.1 + NaturalForm * 0.1 + Header * 0.2 + Jumping * 0.1 * Luck * 0.1 );

            if (GoolScore > 70)
            {
                return true;
            }
            else
            {
                return false;
            }


        }


    }

    internal class Midfielder : Footballer
    {
        private int LongBall;
        private int FirstTouch;
        private int Productivity;
        private int Dribbling;
        private int SpecialSkill;

        public Midfielder(string namesurname,int no)
        {
            this.NameSurname = namesurname;
            this.No = no;

            Speed = random.Next(60, 100);
            Stamina = random.Next(60, 100);
            Pass = random.Next(60, 100);
            Shot = random.Next(60, 100);
            Skill = random.Next(60, 100);
            DecisionMaking = random.Next(60, 100);
            NaturalForm = random.Next(60, 100);
            Luck = random.Next(60, 100);


            LongBall = random.Next(60,100);
            FirstTouch= random.Next(60,100);
            Productivity= random.Next(60,100);
            Dribbling= random.Next(60,100);
            SpecialSkill= random.Next(60,100);
        }

        public override Boolean PassMetot()
        {
            int PassScore = Convert.ToInt32(Pass * 0.3 + Skill * 0.2 + SpecialSkill * 0.2 + Stamina * 0.1 + NaturalForm * 0.1 + LongBall * 0.1 + Dribbling * 0.1 + Luck * 0.1 );

            if (PassScore > 60)
            {
                return true;
            }
            else
            {
                return false;
            }


        }

        public override Boolean GoolMetot()
        {
            int GoolScore = Convert.ToInt32(Skill * 0.3 + SpecialSkill * 0.2 + Shot * 0.2 + FirstTouch * 0.1 + DecisionMaking * 0.1 + NaturalForm * 0.1 + Luck * 0.1);

            if (GoolScore > 70)
            {
                return true;
            }
            else
            {
                return false;
            }


        }


    }

    internal class Forvard : Footballer
    {
        private int Finishing;
        private int FirstTouch;
        private int Header;
        private int SpecialSkil;
        private int Composure;

        public Forvard(string namesurname,int no)
        {
            this.NameSurname = namesurname;
            this.No = no;

            Speed = random.Next(70, 100);
            Stamina = random.Next(70, 100);
            Pass = random.Next(70, 100);
            Shot = random.Next(70, 100);
            Skill = random.Next(70, 100);
            DecisionMaking = random.Next(70, 100);
            NaturalForm = random.Next(70, 100);
            Luck = random.Next(70, 100);

            Finishing = random.Next(70,100);
            FirstTouch = random.Next(70, 100);
            Header = random.Next(70, 100);
            SpecialSkil = random.Next(70, 100);
            Composure = random.Next(70, 100);
        }


        public override Boolean PassMetot()
        {
            int PassScore = Convert.ToInt32(Pass * 0.3 + Skill * 0.2 + SpecialSkil * 0.2 + Stamina * 0.1 + NaturalForm * 0.2 + Luck * 0.1);

            if (PassScore > 60)
            {
                return true;
            }
            else
            {
                return false;
            }


        }

        public override Boolean GoolMetot()
        {
            int GoolScore = Convert.ToInt32(Skill * 0.2 + SpecialSkil * 0.2 + Shot * 0.1 + Header * 0.1 + FirstTouch * 0.1 + Finishing * 0.1 + Composure * 0.1 + DecisionMaking * 0.1 + NaturalForm * 0.1 + Luck * 0.2   );

            if (GoolScore > 70)
            {
                return true;
            }
            else
            {
                return false;
            }


        }


    }





}
