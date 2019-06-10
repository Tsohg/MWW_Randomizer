using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MWW_Randomizer
{
    class BaseRandomize
    {
        protected string fileName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "WizardWars", "user_settings.config");

        public void Subscribe()
        {
            Form1.Randomize += Randomize;
        }

        public void Unsubscribe()
        {
            Form1.Randomize -= Randomize;
        }

        public void WriteToLogs(TextBox logs, string text)
        {
            logs.AppendText(text);
            logs.AppendText("\r\n");
        }

        public void WriteToFile(string text)
        {
            System.IO.File.WriteAllText(fileName, text);
        }

        public virtual void Randomize(TextBox logs)
        {
        }
    }
}
