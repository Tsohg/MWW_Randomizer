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
    class RandomizeMagicks : BaseRandomize
    {
        private string[] tier1 = ("magick_flame_tornado,magick_geyser,magick_haste,magick_heal_totem,magick_stasis,magick_stone_prison,magick_teleport").Split(',');
        private string[] tier2 = ("magick_charm,magick_conflagration,magick_frost_bomb,magick_natures_call,magick_tidal_wave,magick_tornado").Split(',');
        private string[] tier3 = ("magick_napalm,magick_nullify,magick_random_teleport,magick_revive_target_area,magick_summon_death,magick_yellowstone").Split(',');
        private string[] tier4 = ("magick_meteor_shower,magick_mighty_hail,magick_raise_dead,magick_thunderstorm").Split(',');
        private string patternMagick1 = "(magick_1)( = )(\"magick_.*)";
        private string patternMagick2 = "(magick_2)( = )(\"magick_.*)";
        private string patternMagick3 = "(magick_3)( = )(\"magick_.*)";
        private string patternMagick4 = "(magick_4)( = )(\"magick_.*)";

        public override void Randomize(TextBox logs)
        {
            Random r = new Random();
            int r1 = r.Next(0, tier1.Length);
            int r2 = r.Next(0, tier2.Length);
            int r3 = r.Next(0, tier3.Length);
            int r4 = r.Next(0, tier4.Length);
            string fileText = File.ReadAllText(fileName);
            Match m1 = Regex.Match(fileText, patternMagick1);
            Match m2 = Regex.Match(fileText, patternMagick2);
            Match m3 = Regex.Match(fileText, patternMagick3);
            Match m4 = Regex.Match(fileText, patternMagick4);
            string split1 = m1.Value.Split(' ')[2];
            string split2 = m2.Value.Split(' ')[2];
            string split3 = m3.Value.Split(' ')[2];
            string split4 = m4.Value.Split(' ')[2];
            fileText = fileText.Replace(split1, "\"" + tier1[r1] + "\"");
            fileText = fileText.Replace(split2, "\"" + tier2[r2] + "\"");
            fileText = fileText.Replace(split3, "\"" + tier3[r3] + "\"");
            fileText = fileText.Replace(split4, "\"" + tier4[r4] + "\"");
            WriteToFile(fileText);
            WriteToLogs(logs, "Magicks successfully randomized.");
        }
    }
}
