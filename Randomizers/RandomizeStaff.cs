using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace MWW_Randomizer.Randomizers
{
    class RandomizeStaff : BaseRandomize
    {
        string[] staves = ("staff_assatur,staff_birdnest,staff_blowtorch,staff_bo,staff_broomstick,staff_cities_bird,staff_cold,staff_community,staff_crafted_basic_arcane," +
            "staff_crafted_basic_cold,staff_crafted_basic_earth,staff_crafted_basic_fire,staff_crafted_basic_health,staff_crafted_basic_life," +
            "staff_crafted_basic_lightning,staff_crafted_basic_shield,staff_crafted_basic_speed,staff_crafted_basic_water,staff_crafted_fancy_death," +
            "staff_crafted_fancy_earth,staff_crafted_fancy_fire,staff_crafted_fancy_health,staff_crafted_fancy_ice,staff_crafted_fancy_life," +
            "staff_crafted_fancy_lightning,staff_crafted_fancy_shield,staff_crafted_fancy_speed,staff_crafted_fancy_water,staff_crook,staff_cultist,staff_curse,staff_death," +
            "staff_default,staff_diamond,staff_earth,staff_ember,staff_epic,staff_excelsior_line,staff_fancyshield,staff_fire,staff_fire_hydrant,staff_flaming_steps," +
            "staff_fork,staff_founders_cane,staff_frost,staff_grey_wizard,staff_headmaster,staff_iron,staff_knight,staff_lantern,staff_life,staff_lightning,staff_lightning_rod," +
            "staff_mace,staff_magma,staff_marble,staff_mayhem,staff_mistletoe,staff_moon,staff_octopus,staff_parrot,staff_platypus,staff_pumpkin,staff_razor,staff_runners_stick," +
            "staff_shield,staff_snowflake,staff_snowman,staff_tesla,staff_valkyrie,staff_water,staff_yggdrasil").Split(',');
        string pattern = "(\"staff_).*";

        public override void Randomize(TextBox logs)
        {
            Random r = new Random();
            int ri = r.Next(0, staves.Length);
            string fileText = File.ReadAllText(fileName);
            Match match = Regex.Match(fileText, pattern);
            fileText = fileText.Replace(match.Value,"\"" + staves[ri] + "\"");
            WriteToFile(fileText);
            WriteToLogs(logs, "Staff successfully randomized.");
        }
    }
}
