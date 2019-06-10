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
    class RandomizeTrinket : BaseRandomize
    {
        string[] trinkets = ("trinket_aegirs_compass,trinket_amulet_of_passing,trinket_badassium_core,trinket_beloved_pet,trinket_cake_of_death," +
            "trinket_captains_medal,trinket_cheese_wheel,trinket_contained_lightning,trinket_crystal_ball,trinket_dead_mans_hand,trinket_default," +
            "trinket_delicious_ruby,trinket_dowsing_rod,trinket_essence_of_cold,trinket_essence_of_earth,trinket_essence_of_fire,trinket_essence_of_shield,trinket_essence_of_water," +
            "trinket_fafnirs_sphere,trinket_fairys_blessing,trinket_fire_sprite,trinket_food_ration,trinket_forgotten_meeting,trinket_fossil,trinket_frost_hamster_teeth," +
            "trinket_frozen_acorn,trinket_frozen_treat,trinket_golden_bracelet,trinket_golden_idol,trinket_green_herb,trinket_halflings_emerald,trinket_holiday_gift," +
            "trinket_holy_book,trinket_jar_o_dirt,trinket_lens_of_burning,trinket_lightning_bolt,trinket_magick_bandages,trinket_magick_lighter,trinket_marital_sapphire," +
            "trinket_mobile_recharger,trinket_motivational_tool,trinket_partner_pyramid,trinket_pen_pal,trinket_pocket_mirror,trinket_power_supply,trinket_protective_charm," +
            "trinket_rans_bauble,trinket_red_coating,trinket_rosary,trinket_sausage,trinket_seven_league_socks,trinket_shoe_gravel,trinket_shroom_of_power,trinket_skeltor_candle_holder," +
            "trinket_slingers_sash,trinket_snow_globe,trinket_stats_to_zero,trinket_strategic_etui,trinket_straw_man,trinket_tinfoil_hat,trinket_underpants_of_the_undead," +
            "trinket_warm_water_bottle").Split(',');
        string pattern = "(\"trinket_.*)";

        public override void Randomize(TextBox logs)
        {
            Random r = new Random();
            int ri = r.Next(0, trinkets.Length);
            string fileText = File.ReadAllText(fileName);
            Match match = Regex.Match(fileText, pattern);
            fileText = fileText.Replace(match.Value, "\"" + trinkets[ri] + "\"");
            WriteToFile(fileText);
            WriteToLogs(logs, "Trinket successfully randomized.");

        }
    }
}
