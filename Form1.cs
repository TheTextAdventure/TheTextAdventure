using Microsoft.VisualBasic;
using System.Numerics;
using System.Windows.Forms;

namespace TheTextAdventure
{
    public partial class TheTextAdventure : Form
    {
        private int countdown = 5;
        string filePath = "save.txt";

        public TheTextAdventure()
        {
            InitializeComponent();
            if (File.Exists(filePath))
            {
                string Name = File.ReadAllText(filePath);
            }
            PlayerName.Text = Name;

            PickTimer.Interval = 1000;
            PickTimer.Tick += PickTimer_Tick;

            HuntAndFightTimer.Interval = 1000;
            HuntAndFightTimer.Tick += HuntAndFightTimer_Tick;
        }
        private void TheTextAdventure_Load(object sender, EventArgs e)
        {

            Account.Health = 100;
            Account.MaxHealth = 100;
        }
        private void nameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string Name = Interaction.InputBox("Enter Name", "Name", "", 300, 300);
            PlayerName.Text = Name;


            File.WriteAllText(filePath, Name);
            LevelShow.Value = 0;

        }

        private void PickButton_Click(object sender, EventArgs e)
        {
            // Butonu devre dýþý býrak ve zamanlayýcýyý baþlat
            PickButton.Enabled = false;
            countdown = 10; // Süreyi baþtan ayarla
            PickTimer.Start();
            if (LevelShow.Maximum <= LevelShow.Value + 1)
            {
                LevelSystem levelSystem = new LevelSystem();
                levelSystem.LevelUpdate(LevelShow, LevelStatusShow);
                LevelStatusShow.Text = "Level:" + LevelSystem.Level;
            }
            else
            {
                LevelShow.Value += 1;
            }
            Account.Apple++;
            AppleLabel.Text = "Apple:" + Account.Apple;

        }

        private void PickTimer_Tick(object sender, EventArgs e)
        {
            countdown--;

            if (countdown <= 0)
            {
                PickTimer.Stop();
                PickButton.Enabled = true;
            }
        }

        private void HuntButton_Click(object sender, EventArgs e)
        {
            HuntButton.Enabled = false;
            countdown = 10;
            HuntAndFightTimer.Start();
            if (LevelShow.Maximum <= LevelShow.Value + 50)
            {
                LevelSystem levelSystem = new LevelSystem();
                levelSystem.LevelUpdate(LevelShow, LevelStatusShow);
                LevelStatusShow.Text = "Level:" + LevelSystem.Level;
            }
            else
            {
                LevelShow.Value += 50;
            }
            Account.Wolf++;
            WolfLabel.Text = "Wolf:" + Account.Wolf;
            Account.Health = Account.Health - 10;
            HealthShow.Text = "Health:" + Account.Health + "/" + Account.MaxHealth;

        }

        private void HuntAndFightTimer_Tick(object sender, EventArgs e)
        {
            countdown--;
            if (countdown <= 0)
            {
                HuntAndFightTimer.Stop();
                HuntButton.Enabled = true;
            }
        }

        private void HealthShow_Click(object sender, EventArgs e)
        {
            if (Account.MiniLifePotion > 0)
            {
                Account.MiniLifePotion--;
                Account.Health += 10;
                if (Account.Health > Account.MaxHealth)
                {
                    Account.Health = Account.MaxHealth;
                }
                HealthShow.Text = "Health:" + Account.Health + "/" + Account.MaxHealth;
            }
            else
            {
                MessageBox.Show("You don't have any life potion");
            }
        }
        private void BuyCartButton_Click(object sender, EventArgs e)
        {

        }

        private void MarketListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            MarketListBox.Items.Add("Mini Life Potion");
        }
    }
}
