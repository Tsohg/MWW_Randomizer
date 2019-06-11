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
    class RandomizeImp : BaseRandomize
    {
        string[] imps = ("familiar_dragon_imp,familiar_elf_imp,familiar_founder_imp,familiar_imp,familiar_imp_alpha,familiar_imp_anonymous,familiar_imp_beta," +
            "familiar_imp_beta_blue,familiar_imp_beta_green,familiar_imp_beta_yellow,familiar_imp_box,familiar_imp_cow,familiar_imp_craftable_robot," +
            "familiar_imp_craftable_robot_black,familiar_imp_craftable_robot_gray,familiar_imp_craftable_robot_rusted,familiar_imp_craftable_robot_white,familiar_imp_halloween," +
            "familiar_midsummer_imp,familiar_pirate_imp,familiar_programmer_imp,familiar_razor_imp").Split(',');
        string pattern = "(\"familiar_.*)";

        public override void Randomize(TextBox logs)
        {
            Random r = new Random();
            int ri = r.Next(0, imps.Length);
            string fileText = File.ReadAllText(fileName);
            Match match = Regex.Match(fileText, pattern);
            fileText = fileText.Replace(match.Value, "\"" + imps[ri] + "\"");
            WriteToFile(fileText);
            WriteToLogs(logs, "Imp successfully randomized.");
        }
    }
}
