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
            if (DataBank.get_sound_volume() == true)
            {
                Sound_button.BackgroundImage = Properties.Resources.volume_on;
            }
            else if (DataBank.get_sound_volume() == false)
            {
                Sound_button.BackgroundImage = Properties.Resources.volume_off;
            }
            if (DataBank.get_sound_volume() == true)
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
            if (DataBank.get_sound_volume() == true)
            {
                Sound_button.BackgroundImage = Properties.Resources.volume_off;
                DataBank.set_sound_volume(false);
                sound.Stop();
            }
            else if (DataBank.get_sound_volume() == false)
            {
                Sound_button.BackgroundImage = Properties.Resources.volume_on;
                DataBank.set_sound_volume(true);
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
                DataBank.set_order(Int32.Parse(fileText[0]));
                DataBank.set_money(Int32.Parse(fileText[1]));
                DataBank.set_hydrogen(Int32.Parse(fileText[2]));
                DataBank.set_sulfur(Int32.Parse(fileText[3]));
                DataBank.set_helium(Int32.Parse(fileText[4]));
                DataBank.set_boron(Int32.Parse(fileText[5]));
                DataBank.set_carbon(Int32.Parse(fileText[6]));
                DataBank.set_nitrogen(Int32.Parse(fileText[7]));
                DataBank.set_oxygen(Int32.Parse(fileText[8]));
                DataBank.set_chlorine(Int32.Parse(fileText[9]));
                DataBank.set_hydrogen_sulfide(Int32.Parse(fileText[10]));
                DataBank.set_hel_hel_hel(Int32.Parse(fileText[11]));
                DataBank.set_helium_hydrogen(Int32.Parse(fileText[12]));
                DataBank.set_carbid_bora(Int32.Parse(fileText[13]));
                DataBank.set_nitrogen_boron(Int32.Parse(fileText[14]));
                DataBank.set_oksid_azota(Int32.Parse(fileText[15]));
                DataBank.set_trihlorid_azota(Int32.Parse(fileText[16]));
            }
            while (false);


            MessageBox.Show("Файл відкрито", "Робота з файлом");
        }
        }
    }


