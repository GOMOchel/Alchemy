using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Diagnostics;

namespace AlchemyAlpha0._1
{
    public partial class HomeWindow : Form
    {
        SoundPlayer sound = new SoundPlayer();

        public HomeWindow()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;

        }

        private void HomeWindow_Load(object sender, EventArgs e)
        {
            if (DataBank.sound_volume == true)
            {
                Sound_button.BackgroundImage = Properties.Resources.volume_on;
            }
            else if (DataBank.sound_volume == false)
            {
                Sound_button.BackgroundImage = Properties.Resources.volume_off;
            }
            if (DataBank.sound_volume == true)
            {
                SoundPlayer sound = new SoundPlayer(Properties.Resources.secunda);
                sound.PlayLooping();
            }
        }

        private void Play_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainWindow main = new MainWindow();
            main.Show();
        }

        private void Exit_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Sound_button_Click(object sender, EventArgs e)
        {
            if (DataBank.sound_volume == true)
            {
                Sound_button.BackgroundImage = Properties.Resources.volume_off;
                DataBank.sound_volume = false;
                sound.Stop();
            }
            else if (DataBank.sound_volume == false)
            {
                Sound_button.BackgroundImage = Properties.Resources.volume_on;
                DataBank.sound_volume = true;
                SoundPlayer sound = new SoundPlayer(Properties.Resources.secunda);
                sound.PlayLooping();
            }
        }

        private void Author_button_Click(object sender, EventArgs e)
        {
            if (panel1.Visible == true)
            {
                panel1.Visible = false;
            }
            else if (panel1.Visible == false)
            {
                panel1.Visible = true;
            }
        }

        private void Load_Save_button_Click(object sender, EventArgs e)
        {
            Load_Save_button.BackColor = Color.LightGoldenrodYellow;
            Load_Save_button.Text = "Завантажено!";
  
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            string[] fileText = File.ReadAllLines(openFileDialog1.FileName);
            do
            {
                DataBank.order = Int32.Parse(fileText[0]);
                DataBank.money = Int32.Parse(fileText[1]);
                DataBank.hydrogen = Int32.Parse(fileText[2]);
                DataBank.sulfur = Int32.Parse(fileText[3]);
                DataBank.Helium = Int32.Parse(fileText[4]);
                DataBank.Boron = Int32.Parse(fileText[5]);
                DataBank.Carbon = Int32.Parse(fileText[6]);
                DataBank.Nitrogen = Int32.Parse(fileText[7]);
                DataBank.Oxygen = Int32.Parse(fileText[8]);
                DataBank.Chlorine = Int32.Parse(fileText[9]);
                DataBank.Hydrogen_Sulfide = Int32.Parse(fileText[10]);
                DataBank.hel_hel_hel = Int32.Parse(fileText[11]);
                DataBank.helium_hydrogen = Int32.Parse(fileText[12]);
                DataBank.carbid_bora = Int32.Parse(fileText[13]);
                DataBank.nitrogen_boron = Int32.Parse(fileText[14]);
                DataBank.oksid_azota = Int32.Parse(fileText[17]);
                DataBank.dioksid_hlora = Int32.Parse(fileText[15]);
                DataBank.trihlorid_azota = Int32.Parse(fileText[16]);
            }
            while (false);


            MessageBox.Show("Файл відкрито", "Робота з файлом");
        }
        }
    }


