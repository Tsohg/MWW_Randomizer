using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MWW_Randomizer.Randomizers
{
    class RandomizeRing : BaseRandomize
    {
        string[] rings = ("ring_default,ring_elemental_arcane_t1,ring_elemental_arcane_t1_2," +
            "ring_elemental_arcane_t2,ring_elemental_arcane_t2_2,ring_elemental_arcane_t3,ring_elemental_arcane_t3_2,ring_elemental_cold_t1,ring_elemental_cold_t1_2," +
            "ring_elemental_cold_t2,ring_elemental_cold_t2_2,ring_elemental_cold_t3,ring_elemental_cold_t3_2,ring_elemental_earth_t1,ring_elemental_earth_t1_2," +
            "ring_elemental_earth_t2,ring_elemental_earth_t2_2,ring_elemental_earth_t3,ring_elemental_earth_t3_2,ring_elemental_fire_t1,ring_elemental_fire_t1_2," +
            "ring_elemental_fire_t2,ring_elemental_fire_t2_2,ring_elemental_fire_t3,ring_elemental_fire_t3_2,ring_elemental_life_t1,ring_elemental_life_t1_2,ring_elemental_life_t2," +
            "ring_elemental_life_t2_2,ring_elemental_life_t3,ring_elemental_life_t3_2,ring_elemental_lightning_t1,ring_elemental_lightning_t1_2,ring_elemental_lightning_t2," +
            "ring_elemental_lightning_t2_2,ring_elemental_lightning_t3,ring_elemental_lightning_t3_2,ring_elemental_shield_t1,ring_elemental_shield_t1_2,ring_elemental_shield_t2," +
            "ring_elemental_shield_t2_2,ring_elemental_shield_t3,ring_elemental_shield_t3_2,ring_elemental_water_t1,ring_elemental_water_t1_2,ring_elemental_water_t2," +
            "ring_elemental_water_t2_2,ring_elemental_water_t3,ring_elemental_water_t3_2,ring_health_t1,ring_health_t1_2,ring_health_t2,ring_health_t2_2,ring_health_t3,ring_health_t3_2," +
            "ring_speed_t1,ring_speed_t1_2,ring_speed_t2,ring_speed_t2_2,ring_speed_t3,ring_speed_t3_2").Split(',');
        string pattern = "(\"ring_.*)";

        public override void Randomize(TextBox logs)
        {
            Random r = new Random();
            int ri = r.Next(0, rings.Length);
            string fileText = File.ReadAllText(fileName);
            Match match = Regex.Match(fileText, pattern);
            fileText = fileText.Replace(match.Value, "\"" + rings[ri] + "\"");
            WriteToFile(fileText);
            WriteToLogs(logs, "Ring successfully randomized.");
        }
    }
}
