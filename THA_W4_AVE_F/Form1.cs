using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace THA_W4_AVE_F
{
    public partial class Form1 : Form
    {
        List<Player> playerList = new List<Player>();
        public Form1()
        {
            InitializeComponent();
        }
        void ComboCountry()
        {
            comboBox_country.Items.Add("Italian");
            comboBox_country.Items.Add("England");
        }

        void ComboPosition()
        {
            comboBox_position.Items.Add("GK");
            comboBox_position.Items.Add("DF");
            comboBox_position.Items.Add("MF");
            comboBox_position.Items.Add("FW");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Team team = new Team();
            comboBox_team.Items.Add(textBox_nameT);
            comboBox_country.Items.Add(textBox_countryT);
            if (string.IsNullOrEmpty(textBox_countryT.Text)==false)
            {
                comboBox_country.Items.Add(textBox_countryT.Text);
            }
            if (string.IsNullOrEmpty(textBox_nameT.Text)==false)
            {
                comboBox_team.Items.Add(textBox_nameT.Text);
            }
            textBox_nameT.Clear();
            textBox_countryT.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (Player p in playerList)
            {
                listBox_player.Items.Add("(" + p.AddNumber + ") " + p.AddName + ", " +
                    p.AddPosition);
            }
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            ComboCountry();
            ComboPosition();
        }

        private void listBox_player_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void comboBox_country_SelectedIndexChanged(object sender, EventArgs e)
        {
            string countrychoose = comboBox_country.SelectedIndex.ToString();
            Object team = comboBox_country.SelectedItem;
            string country = team.ToString();
            if (country=="Italian")
            {
                comboBox_team.Items.Add("Juventus");
            }
            else if(country=="England")
            {
                comboBox_team.Items.Add("Manchester United");
                comboBox_team.Items.Add("Liverpool");
            }
        }
        private void comboBox_team_SelectedIndexChanged(object sender, EventArgs e)
        {
            string teamchoose = comboBox_team.SelectedIndex.ToString();
            Object player = comboBox_team.SelectedItem;
            string team = player.ToString();
            if(team=="Juventus")
            {
                listBox_player.Items.Add("(07) Roberto Anzolin, GK");
                listBox_player.Items.Add("(04) Luigi Bertolini, MF");
                listBox_player.Items.Add("(09) Carlo Bigatto, MF");
                listBox_player.Items.Add("(02) Massimo Bonini, MF");
                listBox_player.Items.Add("(10) Gianluigi Buffon, GK");
                listBox_player.Items.Add("(15) Gianpiero Combi, GK");
                listBox_player.Items.Add("(13) Antonio Conte, MF");
                listBox_player.Items.Add("(20) Antonello Cuccureddu, MF");
                listBox_player.Items.Add("(17) Edgar Davids, MF");
                listBox_player.Items.Add("(25) Angelo Peruzzi, GK");
                listBox_player.Items.Add("(28) Alessio Tacchinardi, MF");
            }
            else if (team=="Manchester United")
            {
                listBox_player.Items.Add("(01) Willie Stewart, FW");
                listBox_player.Items.Add("(03) Alf Farman, FW");
                listBox_player.Items.Add("(09) Carlo Bigatto, MF");
                listBox_player.Items.Add("(05) Arthur Whalley, MF");
                listBox_player.Items.Add("(11) Frank Barrett, GK");
                listBox_player.Items.Add("(12) Alf Steward, GK");
                listBox_player.Items.Add("(07) Joe Spence, FW");
                listBox_player.Items.Add("(15) Clayton Blackmore, MF");
                listBox_player.Items.Add("(17) Mark Hughes, FW");
                listBox_player.Items.Add("(20) Peter Schmeichel, GK");
                listBox_player.Items.Add("(25) Fabien Barthez, GK");
            }
            else if(team=="Liverpool")
            {
                listBox_player.Items.Add("(02) Malcolm McVean, FW");
                listBox_player.Items.Add("(05) Joe Hewitt, FW");
                listBox_player.Items.Add("(09) Harry Storer, GK");
                listBox_player.Items.Add("(05) William Goldie, DF");
                listBox_player.Items.Add("(11) Bill Perkins, GK");
                listBox_player.Items.Add("(12) Maurice Parry, DF");
                listBox_player.Items.Add("(07) Tom Chorlton, DF");
                listBox_player.Items.Add("(15) Sam Hardy, GK");
                listBox_player.Items.Add("(17) Donald Mackinlay, DF");
                listBox_player.Items.Add("(20) José Reina, GK");
                listBox_player.Items.Add("(25) José Reina, FW");
            }
        }
        private void btn_remove_Click(object sender, EventArgs e)
        {

            if(listBox_player.SelectedIndex > 11)
            {
                listBox_player.Items.RemoveAt(listBox_player.SelectedIndex);
            }
            else
            {
                string remove = "Unable to remove Players if Players less than equal to 11";
                MessageBox.Show(remove,"",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }
        private void comboBox_position_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

    }
}
