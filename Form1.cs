using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MWW_Randomizer.Randomizers;

namespace MWW_Randomizer
{
    /// <summary>
    /// Special thanks to Neon for giving me the full listing of equipable items in the game.
    /// </summary>
    public partial class Form1 : Form
    {
        //Delegate and Event used for handling the randomizers.
        public delegate void RandomHandler(TextBox logs);
        public static event RandomHandler Randomize;

        //Instantiate randomizer classes.
        private RandomizeRobes robe = new RandomizeRobes();
        private RandomizeStaff staff = new RandomizeStaff();
        private RandomizeImp imp = new RandomizeImp();
        private RandomizeWeapon weapon = new RandomizeWeapon();
        private RandomizeRing ring = new RandomizeRing();
        private RandomizeTrinket trinket = new RandomizeTrinket();
        private RandomizeMagicks magicks = new RandomizeMagicks();
        private RandomizeElements elements = new RandomizeElements();

        private List<BaseRandomize> randomizers;

        private string defaultMessage = "Please select what you want to randomize from the left.\r\n" +
            "Restore Backup will restore your config file in the event of MWW crashing.\r\n" + 
            "In the event of a MWW crash send @Alias a copy of:\r\n" +
            "    ...\\Appdata\\Roaming\\WizardWars\\user_settings.config";

        public Form1()
        {
            InitializeComponent();
            clearButton_Click(this, new EventArgs());
            CreateBackup();

            //Add to list to ensure everything is unsubscribed at first.
            randomizers = new List<BaseRandomize>();
            randomizers.Add(robe);
            randomizers.Add(staff);
            randomizers.Add(imp);
            randomizers.Add(weapon);
            randomizers.Add(ring);
            randomizers.Add(trinket);
            randomizers.Add(magicks);
            randomizers.Add(elements);
        }

        private void randomizeButton_Click(object sender, EventArgs e)
        {
            //logs.ResetText();
            foreach (BaseRandomize b in randomizers)
                b.Unsubscribe();
            foreach (object o in randomSelector.CheckedItems)
            {
                switch (o.ToString())
                {
                    case "Robe":
                        robe.Subscribe();
                        break;
                    case "Staff":
                        staff.Subscribe();
                        break;
                    case "Weapon":
                        weapon.Subscribe();
                        break;
                    case "Ring":
                        ring.Subscribe();
                        break;
                    case "Trinket":
                        trinket.Subscribe();
                        break;
                    case "Magicks":
                        magicks.Subscribe();
                        break;
                    case "Imp":
                        imp.Subscribe();
                        break;
                    case "Element Keybinds":
                        elements.Subscribe();
                        break;
                    default:
                        logs.AppendText(o.ToString());
                        break;
                }
            }
            if (Randomize != null)
            {
                Randomize(logs);
                logs.AppendText("Done!\r\n");
            }
            else
                logs.AppendText("Select something to randomize.\r\n");
            if(nullCheckBox.Checked)
            {
                string pattern = "(\"trinket_.*)";
                string fileName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "WizardWars", "user_settings.config");
                string fileText = File.ReadAllText(fileName);
                Match match = Regex.Match(fileText, pattern);
                fileText = fileText.Replace(match.Value, "\"" + "trinket_stats_to_zero" + "\"");
                System.IO.File.WriteAllText(fileName, fileText);
            }
        }

        private void restoreBinds_Click(object sender, EventArgs e)
        {
            elements.RestoreKeybinds(logs);
        }

        private void allEquipSelect_CheckedChanged(object sender, EventArgs e)
        {
            if(allEquipSelect.Checked)
            {
                randomSelector.SetItemChecked(0, true);
                randomSelector.SetItemChecked(1, true);
                randomSelector.SetItemChecked(2, true);
                randomSelector.SetItemChecked(3, true);
                randomSelector.SetItemChecked(4, true);
                randomSelector.SetItemChecked(6, true);
            }
            else
            {
                randomSelector.SetItemChecked(0, false);
                randomSelector.SetItemChecked(1, false);
                randomSelector.SetItemChecked(2, false);
                randomSelector.SetItemChecked(3, false);
                randomSelector.SetItemChecked(4, false);
                randomSelector.SetItemChecked(6, false);
            }
        }

        private void allSelect_CheckedChanged(object sender, EventArgs e)
        {
            if (allEquipSelect.Checked)
                allEquipSelect.Checked = false;
            if (allSelect.Checked)
            {
                for (int i = 0; i < randomSelector.Items.Count; i++)
                    randomSelector.SetItemChecked(i, true);
                allEquipSelect.Enabled = false;
            }
            else
            {
                for (int i = 0; i < randomSelector.Items.Count; i++)
                    randomSelector.SetItemChecked(i, false);
                allEquipSelect.Enabled = true;
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            logs.ResetText();
            logs.Text = defaultMessage;
        }

        private void CreateBackup()
        {
            if(!File.Exists(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "WizardWars", "user_settings_bak.config")))
            {
                string backupName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "WizardWars", "user_settings_bak.config");
                string originalName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "WizardWars", "user_settings.config");
                System.IO.File.Copy(originalName, backupName);
            }
        }

        private void restoreBackupButton_Click(object sender, EventArgs e)
        {
            string backupName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "WizardWars", "user_settings_bak.config");
            string originalName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "WizardWars", "user_settings.config");
            System.IO.File.WriteAllText(originalName, File.ReadAllText(backupName));
        }
    }
}
///db320f93ead463e1a2faee198cd9a122
///9ab45e5fc61f80cb8255275afaefb8cb