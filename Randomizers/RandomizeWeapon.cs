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
    class RandomizeWeapon : BaseRandomize
    {
        string[] weapons = ("weapon_arakh_sword,weapon_arcane_axe,weapon_arcane_sword,weapon_barnacle_blade,weapon_baseball_bat,weapon_bear_claw,weapon_bearded_axe," +
            "weapon_blade_default,weapon_blade_gun,weapon_blaster,weapon_caxirola,weapon_chainsword,weapon_chakram,weapon_chakram_digital," +
            "weapon_chakram_princess,weapon_crafted_crossbow_arcane,weapon_crafted_crossbow_cold,weapon_crafted_crossbow_earth,weapon_crafted_crossbow_fire," +
            "weapon_crafted_crossbow_lightning,weapon_crafted_crossbow_water,weapon_crafted_mace_arcane,weapon_crafted_mace_cold,weapon_crafted_mace_earth,weapon_crafted_mace_fire," +
            "weapon_crafted_mace_lightning,weapon_crafted_mace_water,weapon_cultist_blade,weapon_cutlass,weapon_double_axe,weapon_epic_sword,weapon_exotic_blade,weapon_fire_longsword," +
            "weapon_flaming_sword,weapon_flintlock_pistol,weapon_founders_sabre,weapon_gladius,weapon_grass_blade,weapon_grimnir_dagger,weapon_gungnir,weapon_hatchet," +
            "weapon_headmaster_blade,weapon_heavy_metal_axe,weapon_ice_blade,weapon_ice_brand,weapon_jotun_mace,weapon_keytar,weapon_laser_sword,weapon_laser_sword_crafted_blackblue," +
            "weapon_laser_sword_crafted_blackgreen,weapon_laser_sword_crafted_blackred,weapon_laser_sword_crafted_blackyellow,weapon_laser_sword_crafted_blue,weapon_laser_sword_crafted_green," +
            "weapon_laser_sword_crafted_red,weapon_laser_sword_crafted_yellow,weapon_laser_sword_rainbow,weapon_lightning_spear,weapon_longinus,weapon_mjolnir,weapon_moon,weapon_pipe," +
            "weapon_pitchfork,weapon_platypus_sword,weapon_present,weapon_razor_blade,weapon_rusty_knife,weapon_sickle,weapon_snowball,weapon_stone_mallet,weapon_sword_of_masters," +
            "weapon_tidal_sword,weapon_tomahawk,weapon_unicorn_horn,weapon_valkyrie_spear,weapon_vendetta_dagger,weapon_war_hammer,weapon_war_horn,weapon_wrench,weapon_wurstmachers_cleaver").Split(',');
        string pattern = "(\"weapon_.*)";

        public override void Randomize(TextBox logs)
        {
            Random r = new Random();
            int ri = r.Next(0, weapons.Length);
            string fileText = File.ReadAllText(fileName);
            Match match = Regex.Match(fileText, pattern);
            fileText = fileText.Replace(match.Value, "\"" + weapons[ri] + "\"");
            WriteToFile(fileText);
            WriteToLogs(logs, "Weapon successfully randomized.");
        }
    }
}
