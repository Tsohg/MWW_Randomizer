using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MWW_Randomizer
{
    class RandomizeRobes : BaseRandomize
    {
        //All the robes from Neon's file.
        string[] robes = ("robe_amazon,robe_arctic_survival,robe_assassin,robe_astronomer,robe_cold,robe_cultist,robe_death,robe_druid,robe_earth,robe_epic,robe_fire," +
            "robe_fire_enchanter,robe_fire_mage,robe_flipper,robe_folk,robe_gladiator,robe_grimnir,robe_hardened,robe_headmaster,robe_highlander,robe_ice_regent,robe_illusionist," +
            "robe_lightning,robe_lightning_mage,robe_malefice,robe_merfolk,robe_minstrel,robe_moon,robe_officer,robe_pharaoh,robe_pirate,robe_platypus,robe_ranger,robe_santa," +
            "robe_scientist,robe_shaman,robe_shield,robe_speedy,robe_steampunk,robe_templar,robe_valkyrie,robe_vizier,robe_vlad,robe_water_bender,robe_witch,robe_wizard,robe_wuxia").Split(',');
        string pattern = @"(robe).*";

        public override void Randomize(TextBox logs)
        {
            Random r = new Random();
            int ri = r.Next(0, robes.Length);
            string fileText = File.ReadAllText(fileName);
            MatchCollection matches = Regex.Matches(fileText, pattern);
            foreach(Match m in matches)
            {
                if(Regex.Match(m.Value, @"\d").Success) //skin
                {
                    int skin = r.Next(1, MaxSkinValueByName(robes[ri]));
                    string split = m.Value.Split(' ')[2];
                    fileText = fileText.Replace(split, "\"" + robes[ri] + "_" + skin + "\"");
                    //WriteToLogs(logs, "\"" + robes[ri] + "_1" + "\"");
                }
                if (!Regex.Match(m.Value, @"\d").Success) //not skin
                {
                    string split = m.Value.Split(' ')[2];
                    fileText = fileText.Replace(split, "\"" + robes[ri] + "\"");
                    //WriteToLogs(logs, "\"" + robes[ri] + "\"");
                }
            }
            WriteToFile(fileText);
            WriteToLogs(logs, "Robes successfully randomized.");
        }

        private int MaxSkinValueByName(string robeName)
        {
            switch (robeName)
            {
                case "robe_gladiator":
                    return 10;
                case "robe_wizard":
                    return 8;
                case "robe_vlad":
                case "robe_platypus":
                    return 1;
                case "robe_grimnir":
                case "robe_valkyrie":
                case "robe_steampunk":
                case "robe_cultist":
                case "robe_epic":
                case "robe_santa": //jolnir?
                    return 2;
                case "robe_headmaster":
                case "robe_moon":
                case "robe_hardened":
                case "robe_speedy":
                case "robe_cold":
                case "robe_shield":
                case "robe_druid":
                case "robe_lightning":
                case "robe_death":
                case "robe_earth":
                case "robe_fire":
                case "robe_officer":
                case "robe_fire_mage":
                    return 5;
                default:
                    return 4;
            }
        }
    }
}
