using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AlchemyAlpha0._1
{
    public partial class AlchemyWindows : Form
    {
        public AlchemyWindows()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            //KeyPreview = true;
           // KeyDown += (s, e) => { if (e.KeyValue == (char)Keys.B) Mix_Button_Click(Mix_Button, null); };
        }

        private void AlchemyWindows_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.mag3;
            if (DataBank.sound_volume == true)
            {
                SoundPlayer sound = new SoundPlayer(Properties.Resources.water);
                sound.PlayLooping();
            }
            Inventory_Panel.Visible = false;
            Recipes_Panel.Visible = false;
            Alchemy_Panel.Visible = true;
            Money_label.Text = "Гроші: " + DataBank.money + "$";
            Hydrogen_label.Text = "Водород: " + DataBank.hydrogen;
            Sulfur_label.Text = "Кристал Вілідора: " + DataBank.sulfur;
            Chlorine_label.Text = "Вода Шанті: " + DataBank.Chlorine;
            Boron_label.Text = "Злиток Альтеіда: " + DataBank.Boron;
            Helium_label.Text = "Дихання Мілмулніра: " + DataBank.Helium;
            Nitrogen_label.Text = "Слина Сприггана: " + DataBank.Nitrogen;
            Hydrogen_Sulfide_label.Text = "Смрад Аарду: " + DataBank.Hydrogen_Sulfide;
            hel_hel_hel_label.Text = "Корунда: " + DataBank.Carbon;
            helium_hydrogen_label.Text = "Ектоплазма: " + DataBank.Hydrogen_Sulfide;
            carbid_bora_label.Text = "Мрачний Кристал: " + DataBank.carbid_bora;
            oksid_azota_label.Text = "Сіль Порожнечі: " + DataBank.nitrogen_boron;
            dioksid_hlora_label.Text = "Пахощі: " + DataBank.oksid_azota;
            trihlorid_azota_label.Text = "Вовча Загибель: " + DataBank.dioksid_hlora;
            nitrogen_boron_label.Text = "Сторічне Добриво: " + DataBank.trihlorid_azota;
        }

        private void Mix_Button_Click_1(object sender, EventArgs e)
        {
            if (DataBank.HydrogenSulfide == Mix_TextBox.Text)
            {
                if (DataBank.hydrogen >= 1 && DataBank.sulfur >= 1)
                {
                    Mix_Label.Text = "Результат : Смрад Аарду";
                    DataBank.Hydrogen_Sulfide += 1;
                    Hydrogen_Sulfide_label.Text = "Смрад Аарду: " + DataBank.Hydrogen_Sulfide;
                    DataBank.hydrogen -= 1;
                    Hydrogen_label.Text = "Водород: " + DataBank.hydrogen;
                    DataBank.sulfur -= 1;
                    Sulfur_label.Text = "Кристал Вілідора: " + DataBank.sulfur;

                }
                else
                {
                    MessageBox.Show("У вас недостатньо інгредієнтів!");
                }

            }
            if (DataBank.helhelhel == Mix_TextBox.Text)
            {

                Mix_Label.Text = "Результат : Корунда";
                hel_hel_hel_label.Text = "Корунда: " + DataBank.Carbon;
                DataBank.Helium -= 1;
                Helium_label.Text = "Дихання Мілмулніра: " + DataBank.Helium;




            }
            if (DataBank.heliumhydrogen == Mix_TextBox.Text)
            {
                if (DataBank.Helium >= 1 && DataBank.hydrogen >= 1)
                {
                    Mix_Label.Text = "Результат : Ектоплазма";
                    DataBank.Hydrogen_Sulfide += 1;
                    helium_hydrogen_label.Text = "Ектоплазма: " + DataBank.Hydrogen_Sulfide;
                    DataBank.Helium -= 1;
                    Helium_label.Text = "Дихання Мілмулніра: " + DataBank.Helium;
                    DataBank.hydrogen -= 1;
                    Nitrogen_label.Text = "Слина Сприггана: " + DataBank.hydrogen;

                }
                else
                {
                    MessageBox.Show("У вас недостатньо інгредієнтів!");
                }


            }
            if (DataBank.carbidbora == Mix_TextBox.Text)
            {
                if (DataBank.Boron >= 1 && DataBank.Carbon >= 1)
                {
                    Mix_Label.Text = "Результат : Мрачний Кристал";
                    DataBank.carbid_bora += 1;
                    carbid_bora_label.Text = "Мрачний Кристал: " + DataBank.carbid_bora;
                    DataBank.Boron -= 1;
                    Boron_label.Text = "Злиток Альтеіда: " + DataBank.Boron;
                    DataBank.Carbon -= 1;
                    hel_hel_hel_label.Text = "Корунда: " + DataBank.Carbon;

                }
                else
                {
                    MessageBox.Show("У вас недостатньо інгредієнтів!");
                }

            }
            if (DataBank.nitrogenboron == Mix_TextBox.Text)
            {
                if (DataBank.Boron >= 1 && DataBank.Nitrogen >= 1)
                {
                    Mix_Label.Text = "Результат : Сіль Порожнечі";
                    DataBank.nitrogen_boron += 1;
                    oksid_azota_label.Text = "Сіль Порожнечі: " + DataBank.nitrogen_boron;
                    DataBank.Boron -= 1;
                    Boron_label.Text = "Злиток Альтеіда: " + DataBank.Boron;
                    DataBank.Nitrogen -= 1;
                    Nitrogen_label.Text = "Слина Сприггана: " + DataBank.Nitrogen;

                }
                else
                {
                    MessageBox.Show("У вас недостатньо інгредієнтів!");
                }

            }
            if (DataBank.oksidazota == Mix_TextBox.Text)
            {
                if (DataBank.Nitrogen >= 1 && DataBank.Oxygen >= 1)
                {
                    Mix_Label.Text = "Результат : Пахощі";
                    DataBank.oksid_azota += 1;
                    dioksid_hlora_label.Text = "Пахощі: " + DataBank.oksid_azota;
                    DataBank.Nitrogen -= 1;
                    Nitrogen_label.Text = "Слина Сприггана: " + DataBank.Nitrogen;
                    DataBank.Oxygen -= 1;
                    //  label22.Text = "Кислород: " + Oxygen;

                }
                else
                {
                    MessageBox.Show("У вас недостатньо інгредієнтів!");
                }

            }
            if (DataBank.dioksidhlora == Mix_TextBox.Text)
            {
                if (DataBank.Chlorine >= 1 && DataBank.Oxygen >= 1)
                {
                    Mix_Label.Text = "Результат : Вовча Загибель";
                    DataBank.dioksid_hlora += 1;
                    trihlorid_azota_label.Text = "Вовча Загибель: " + DataBank.dioksid_hlora;
                    DataBank.Chlorine -= 1;
                    Chlorine_label.Text = "Вода Шанті: " + DataBank.Chlorine;
                    DataBank.Oxygen -= 2;
                    // label22.Text = "Кислород: " + Oxygen;
                }
                else
                {
                    MessageBox.Show("У вас недостатньо інгредієнтів!");
                }

            }
            if (DataBank.trihloridazota == Mix_TextBox.Text)
            {
                if (DataBank.Nitrogen >= 1 && DataBank.Chlorine >= 1)
                {
                    Mix_Label.Text = "Результат : Сторічне Добриво";
                    DataBank.nitrogen_boron += 1;
                    nitrogen_boron_label.Text = "Сторічне Добриво: " + DataBank.trihlorid_azota;
                    DataBank.Nitrogen -= 1;
                    Nitrogen_label.Text = "Слина Сприггана: " + DataBank.Nitrogen;
                    DataBank.Chlorine -= 3;
                    Chlorine_label.Text = "Вода Шанті: " + DataBank.Chlorine;
                }
                else
                {
                    MessageBox.Show("У вас недостатньо інгредієнтів!");
                }
            }
        }

        private void Main_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainWindow main = new MainWindow();
            main.Show();
        }

        private void Shop_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            ShopWindows shop = new ShopWindows();
            shop.Show();
        }

        private void Home_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomeWindow home = new HomeWindow();
            home.Show();
        }

        private void Inventory_Button_Click(object sender, EventArgs e)
        {
            Inventory_Panel.Visible= true;
        }

        private void Inventory_Close_Button_Click(object sender, EventArgs e)
        {
            Inventory_Panel.Visible= false;
        }

        private void Recipes_Button_Click(object sender, EventArgs e)
        {
            Recipes_Panel.Visible = true;
        }

        private void Recipes_Close_Button_Click(object sender, EventArgs e)
        {
            Recipes_Panel.Visible= false;
        }

       
    }
}
