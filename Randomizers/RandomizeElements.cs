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
    class RandomizeElements : BaseRandomize
    {
        private string[] magickPatterns = new string[]
        {
            "(water)( = )(\"[qwerasdf]\")",
            "(life)( = )(\"[qwerasdf]\")",
            "(shield)( = )(\"[qwerasdf]\")",
            "(cold)( = )(\"[qwerasdf]\")",
            "(lightning)( = )(\"[qwerasdf]\")",
            "(arcane)( = )(\"[qwerasdf]\")",
            "(earth)( = )(\"[qwerasdf]\")",
            "(fire)( = )(\"[qwerasdf]\")"
        };

        private string[] elements = new string[]
        {
            "\"q\"",
            "\"w\"",
            "\"e\"",
            "\"r\"",
            "\"a\"",
            "\"s\"",
            "\"d\"",
            "\"f\"",
        };

        public override void Randomize(TextBox logs)
        {
            Random random = new Random();
            string fileText = File.ReadAllText(fileName);
            string[][] splits = GetSplits(fileText);
            bool[] available = new bool[8];
            Stack<string> randomStack = new Stack<string>();
            for (int i = 0; i < available.Length; i++)
                available[i] = true;
            for(int i = 0; i < 8; i++)
            {
                int ri = random.Next(0, 8);
                if (!available[ri])
                    i--;
                else
                {
                    randomStack.Push(elements[ri]);
                    available[ri] = false;
                }
            }
            for(int i = 0; i < splits.Length; i++)
            {
                string s = splits[i][0] + " " + splits[i][1] + " " + randomStack.Pop();
                fileText = fileText.Replace(splits[i][0] + " " + splits[i][1] + " " + splits[i][2], s);
            }
            WriteToFile(fileText);
            WriteToLogs(logs, "Elements successfully randomized.");
        }

        public void RestoreKeybinds(TextBox logs)
        {
            string fileText = File.ReadAllText(fileName);
            string[][] splits = GetSplits(fileText);
            for(int i = 0; i < 8; i++)
            {
                string s = splits[i][0] + " " + splits[i][1] + " " + elements[i];
                fileText = fileText.Replace(splits[i][0] + " " + splits[i][1] + " " + splits[i][2], s);
            }
            WriteToFile(fileText);
            WriteToLogs(logs, "Keybinds restored to default.");
        }

        private string[][] GetSplits(string fileText)
        {
            Match mQ = Regex.Match(fileText, magickPatterns[0]);
            Match mW = Regex.Match(fileText, magickPatterns[1]);
            Match mE = Regex.Match(fileText, magickPatterns[2]);
            Match mR = Regex.Match(fileText, magickPatterns[3]);
            Match mA = Regex.Match(fileText, magickPatterns[4]);
            Match mS = Regex.Match(fileText, magickPatterns[5]);
            Match mD = Regex.Match(fileText, magickPatterns[6]);
            Match mF = Regex.Match(fileText, magickPatterns[7]);
            return new string[][]
            {
                mQ.Value.Split(' '),
                mW.Value.Split(' '),
                mE.Value.Split(' '),
                mR.Value.Split(' '),
                mA.Value.Split(' '),
                mS.Value.Split(' '),
                mD.Value.Split(' '),
                mF.Value.Split(' ')
            };
        }
    }
}
