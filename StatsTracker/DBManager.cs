using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatsTracker
{
    public enum ListType { Project, Activity, Software, Asset };

    public class DBManager
    {

        // Those are dummy lists which get replaced by the actual DB Data.
        public static List<string> projects = new List<string>() { "HotWar", "Miranda Miner", "Wilderness", "MistyTrees" };
        public static List<string> activities = new List<string>() { "Modeling", "Texturing", "Animating", "Level Design", "C#", "Python", "Game Design", "Project Management" };
        public static List<string> software = new List<string>() { "Blender", "Unity", "Substance Painter", "Substance Designe", "XMind", "SpeedTree", "GIMP", "World Machine" };
        public static List<string> assets = new List<string>() { "UZI" };

        public static void UpdateTables(List<List<string>> updatedLists)
        {
            // so, what do we want to do here?
            // we have a list of lists containing updated data
            // first thing we want to do: check if two lists are the same
            // like... intersect or except... but how was this used again oO

            Console.WriteLine("DBManager list update requested");
            foreach (List<string> list in updatedLists) {
                foreach (string s in list) {
                    // so... here, we go through all the items from all the lists
                    // this is pretty much a waste, since we do not need to check lists that have not been changed
                    // so, why dont we just pass lists to UpdateTabbles that have been changed?
                    // 
                    Console.WriteLine(s);
                }
            }
        }

    }


}
