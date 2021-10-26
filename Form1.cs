using System;
using System.Windows.Forms;

namespace DNDCharaRandomizer
{
    public partial class Form1 : Form
    {
        string[] classes = { "Barbarian", "Bard", "Cleric", "Druid", "Fighter", "Monk", "Paladin", "Ranger", "Rogue", "Sorcerer", "Warlock", "Wizard", "Artificer", "Bloodhunter"}; //14 total
        string[] races = {"Dragonborn", "Dwarf", "Elf", "Gnome", "Half-Elf", "Halfling", "Half-Orc", "Human", "Tiefling", "Warforged", "Aarakocra", "Genasi", "Goliath", "Goblin", "Kobold", "Orc", "Tabaxi" }; //17 total
        string[] dragSub = {"Black", "Blue", "Brass", "Bronze", "Copper", "Gold", "Green", "Red", "Silver", "White" }; //10
        string[] dwarfSub = { "Hill", "Mountain", "Duergar", "Mark of Warding" }; //4
        string[] elfSub = { "Eladrin", "High", "Wood", "Dark", "Sea", "Shadar-Kai", "Pallid", "Mark of Shadow", "Astral", "Avariel", "Grugach", "Bishtahar", "Vahadar" }; //13
        string[] gnomeSub = { "Deep", "Rock", "Forest", "Mark of Scribing" }; //4
        string[] halfelfSub = { "Regular", "Mark of Detection", "Mark of the Storm" }; //3
        string[] halflingSub = { "Lightfoot", "Stout", "Ghostwise", "Lotusden", "Mark of Hospitality", "Mark of Healing" }; //6
        string[] halforcSub = { "Regular", "Mark of Finding" }; //2
        string[] humanSub = { "Regular", "Mark of Finding", "Mark of Handling", "Mark of Making", "Mark of Passage", "Mark of Sentinel" }; //6
        string[] tieflingSub = { "Asmodeus", "Baalzebul", "Dispater", "Fierna", "Glasya", "Levistus", "Mammon", "Mephistopheles", "Zariel" }; //9
        string[] warforgedSub = { "None" }; //1
        string[] aarakocraSub = {"Eagle", "Macaw", "Owl", "Potoo", "Finch", "Raven", "Albatross", "Chicken", "Penguin", "Ostrich"}; //10
        string[] genasiSub = { "Air", "Earth", "Fire", "Water" }; //4
        string[] goliathSub = { "None"}; //1
        string[] golbinSub = { "Traditional", "Boggart", "Gremlin", }; //3
        string[] koboldSub = { "Burrows", "Loredrake", "Winged" }; //3
        string[] orcSub = { "Common", "Orog", "Water", "Ur'ukia" }; //4
        string[] tabaxiSub = { "Mountain", "Grassland", "Jungle", "Forest", "Urban" }; //5
        string[] featOrFlaw = { 
            "You have freakishly long toe nails and you have to try and hide them or else face potential embarrassment.", 
            "You say you're an orphan but you actually have loving parents.", 
            "You have 3 diamond teeth, you get to pick where they are.", 
            "You're secretly wealthy, you have 50,000 gold stached away, but you forgot where and you need to find it.",
            "You're convinced you can fly, but you've never tested your theory out.",
            "You can speak any language, but only when nobody is listening.",
            "You can secretly move 5 extra feet, but don't let the DM catch you.",
            "You have a mountain of nose hair that you feel obligated to keep braided. Let's hope you're a dwarf!",
            "You're a struggling alcoholic, but try to hide it as best as possible",
            "Will get absolutely infuriated at the sight of cheese",
            "Must say your race in every sentance, kind of like a pokemon saying their own race",
            "You have a very small bladder, you need to take frequent bathroom breaks",
            "You physically cannot turn left. In order to go 90 degrees left, you have to turn right 270 degrees"
        }; //13

        private readonly Random randNum = new Random();
        //adding temp comment
        public int RandomNumber(int min, int max)
        {
            return randNum.Next(min, max);
        }
        public int GetDiceTotal()
        {
            int Dice1 = 0, Dice2 = 0, Dice3 = 0;
            Dice1 = RandomNumber(1, 7);
            Dice2 = RandomNumber(1, 7);
            Dice3 = RandomNumber(1, 7);
            if (Dice1 == 1)
            {
                Dice1 = RandomNumber(1, 7);
            }
            else if (Dice2 == 1)
            {
                Dice2 = RandomNumber(1, 7);
            }
            else if (Dice3 == 1)
            {
                Dice3 = RandomNumber(1, 7);
            }

            int Total = Dice1 + Dice2 + Dice3;
            return Total;
        }

        private void randomClassBtn_Click(object sender, EventArgs e)
        {
            raceTxt.Clear();
            classTxt.Clear();
            subRaceTxt.Clear();
            featOrFlawTxt.Clear();

            raceTxt.Text = races[RandomNumber(0, 17)];
            classTxt.Text = classes[RandomNumber(0, 14)];
            featOrFlawTxt.Text = featOrFlaw[RandomNumber(0, 13)];

            if (raceTxt.Text == "Dragonborn")
            {
                subRaceTxt.Text = dragSub[RandomNumber(0, 9)];   //adjust max num
            }
            else if (raceTxt.Text == "Dwarf")
            {
                subRaceTxt.Text = dwarfSub[RandomNumber(0, 4)];   //adjust max num
            }
            else if (raceTxt.Text == "Elf")
            {
                subRaceTxt.Text = elfSub[RandomNumber(0, 13)];   //adjust max num
            }
            else if (raceTxt.Text == "Gnome")
            {
                subRaceTxt.Text = gnomeSub[RandomNumber(0, 4)];   //adjust max num
            }
            else if (raceTxt.Text == "Half-Elf")
            {
                subRaceTxt.Text = halfelfSub[RandomNumber(0, 3)];   //adjust max num
            }
            else if (raceTxt.Text == "Halfling")
            {
                subRaceTxt.Text = halflingSub[RandomNumber(0, 6)];   //adjust max num
            }
            else if (raceTxt.Text == "Half-Orc")
            {
                subRaceTxt.Text = halforcSub[RandomNumber(0, 2)];   //adjust max num
            }
            else if (raceTxt.Text == "Human")
            {
                subRaceTxt.Text = humanSub[RandomNumber(0, 6)];   //adjust max num
            }
            else if (raceTxt.Text == "Tiefling")
            {
                subRaceTxt.Text = tieflingSub[RandomNumber(0, 9)];   //adjust max num
            }
            else if (raceTxt.Text == "Warforged")
            {
                subRaceTxt.Text = warforgedSub[RandomNumber(0, 1)];   //adjust max num
            }
            else if (raceTxt.Text == "Aarakocra")
            {
                subRaceTxt.Text = aarakocraSub[RandomNumber(0, 10)];   //adjust max num
            }
            else if (raceTxt.Text == "Genasi")
            {
                subRaceTxt.Text = genasiSub[RandomNumber(0, 4)];   //adjust max num
            }
            else if (raceTxt.Text == "Goliath")
            {
                subRaceTxt.Text = goliathSub[RandomNumber(0, 1)];   //adjust max num
            }
            else if (raceTxt.Text == "Goblin")
            {
                subRaceTxt.Text = golbinSub[RandomNumber(0, 3)];   //adjust max num
            }
            else if (raceTxt.Text == "Kobold")
            {
                subRaceTxt.Text = koboldSub[RandomNumber(0, 3)];   //adjust max num
            }
            else if (raceTxt.Text == "Orc")
            {
                subRaceTxt.Text = orcSub[RandomNumber(0, 4)];   //adjust max num
            }
            else if (raceTxt.Text == "Tabaxi")
            {
                subRaceTxt.Text = tabaxiSub[RandomNumber(0, 5)];   //adjust max num
            }

            if (classTxt.Text == "Barbarian")   //done
            {
                strLbl.Text = "Very High";
                dexLbl.Text = "Medium";
                conLbl.Text = "Very High";
                intLbl.Text = "Low";
                wisLbl.Text = "Medium";
                chrLbl.Text = "Medium";
            }
            else if (classTxt.Text == "Bard")   //done
            {
                strLbl.Text = "Low";
                dexLbl.Text = "High";
                conLbl.Text = "High";
                intLbl.Text = "Medium";
                wisLbl.Text = "Medium";
                chrLbl.Text = "Very High";
            }
            else if (classTxt.Text == "Cleric") //done
            {
                strLbl.Text = "Medium";
                dexLbl.Text = "Medium";
                conLbl.Text = "High";
                intLbl.Text = "Low";
                wisLbl.Text = "Very High";
                chrLbl.Text = "Medium";
            }
            else if (classTxt.Text == "Druid")  //done
            {
                strLbl.Text = "Low";
                dexLbl.Text = "High";
                conLbl.Text = "High";
                intLbl.Text = "Medium";
                wisLbl.Text = "Very High";
                chrLbl.Text = "Low";
            }
            else if (classTxt.Text == "Fighter")    //done
            {
                strLbl.Text = "Very High";
                dexLbl.Text = "Low";
                conLbl.Text = "High";
                intLbl.Text = "Medium";
                wisLbl.Text = "Medium";
                chrLbl.Text = "Medium";
            }
            else if (classTxt.Text == "Monk")   //done
            {
                strLbl.Text = "Medium";
                dexLbl.Text = "Very High";
                conLbl.Text = "High";
                intLbl.Text = "Low";
                wisLbl.Text = "High";
                chrLbl.Text = "Low";
            }
            else if (classTxt.Text == "Paladin")    //done  
            {
                strLbl.Text = "Very High";
                dexLbl.Text = "Low";
                conLbl.Text = "High";
                intLbl.Text = "Low";
                wisLbl.Text = "Low";
                chrLbl.Text = "Very High";
            }
            else if (classTxt.Text == "Ranger") //done
            {
                strLbl.Text = "Low";
                dexLbl.Text = "Very High";
                conLbl.Text = "High";
                intLbl.Text = "Medium";
                wisLbl.Text = "High";
                chrLbl.Text = "Low";
            }
            else if (classTxt.Text == "Rogue")  //done
            {
                strLbl.Text = "Low";
                dexLbl.Text = "Very High";
                conLbl.Text = "High";
                intLbl.Text = "High";
                wisLbl.Text = "Medium";
                chrLbl.Text = "Medium";
            }
            else if (classTxt.Text == "Sorcerer")   //done
            {
                strLbl.Text = "Low";
                dexLbl.Text = "High";
                conLbl.Text = "High";
                intLbl.Text = "Medium";
                wisLbl.Text = "Medium";
                chrLbl.Text = "Very High";
            }
            else if (classTxt.Text == "Warlock")    //done
            {
                strLbl.Text = "Low";
                dexLbl.Text = "High";
                conLbl.Text = "High";
                intLbl.Text = "Medium";
                wisLbl.Text = "Low";
                chrLbl.Text = "Very High";
            }
            else if (classTxt.Text == "Wizard") //done
            {
                strLbl.Text = "Low";
                dexLbl.Text = "High";
                conLbl.Text = "High";
                intLbl.Text = "Very High";
                wisLbl.Text = "Medium";
                chrLbl.Text = "Low";
            }
            else if (classTxt.Text == "Artificer")  //done
            {
                strLbl.Text = "Low";
                dexLbl.Text = "High";
                conLbl.Text = "High";
                intLbl.Text = "Very High";
                wisLbl.Text = "Low";
                chrLbl.Text = "Low";
            }
            else if (classTxt.Text == "Bloodhunter")    //done
            {
                strLbl.Text = "Low";
                dexLbl.Text = "Very High";
                conLbl.Text = "High";
                intLbl.Text = "Low";
                wisLbl.Text = "High";
                chrLbl.Text = "Low";
            }

        }

        private void randomStatsBtn_Click(object sender, EventArgs e)
        {
            strTxt.Clear();
            strLbl.Text = "";
            dexTxt.Clear();
            dexLbl.Text = "";
            conTxt.Clear();
            conLbl.Text = "";
            intTxt.Clear();
            intLbl.Text = "";
            wisTxt.Clear();
            wisLbl.Text = "";
            charTxt.Clear();
            chrLbl.Text = "";

            strTxt.Text = GetDiceTotal().ToString();
            dexTxt.Text = GetDiceTotal().ToString();
            conTxt.Text = GetDiceTotal().ToString();
            intTxt.Text = GetDiceTotal().ToString();
            wisTxt.Text = GetDiceTotal().ToString();
            charTxt.Text = GetDiceTotal().ToString();
            
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
