using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheTextAdventure
{
    internal class LevelSystem
    {
        public ProgressBar LevelShow { get; set; }
        public Label LevelStatusShow { get; set; }
        public static int Level { get; set; }
        public static int UserXP { get; set; } // UserXP is User's All XP
        public static int LevelXP { get; set; } // LevelXP XP required to Level Up 
        public static int XP { get; set; } // XP The user's XP at the current Level


        void Start()
        {
            // This method must be Update.
            Level = 1;
            UserXP = 0;
            LevelXP = 100;
            XP = 0;
        }
        void Update()
        {
            //if (XP>=LevelXP)
            //{
            //    Level++;
            //    XP = 0;
            //    LevelXP = Level * 2;
            //    UserXP = UserXP + LevelXP;
            //    LevelShow.Value = 0;
            //    LevelShow.Maximum = LevelXP;
            //    LevelStatusShow.Text = "Level:" + Level;

            //}
        }

        public void LevelUpdate(ToolStripProgressBar LevelShow,ToolStripLabel LevelStatusShow)
        {
            if (XP >= LevelXP)
            {
                Level++;
                XP = 0;
                LevelXP = Level * 2;
                UserXP = UserXP + LevelXP;
                LevelShow.Value = 0;
                LevelShow.Maximum = LevelXP;
            }
        }
    }
}
