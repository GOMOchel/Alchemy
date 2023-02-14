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
        }

        private void AlchemyWindows_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.mag3;
            if (DataBank.get_sound_volume() == true)
            {
                SoundPlayer sound = new SoundPlayer(Properties.Resources.water);
                sound.PlayLooping();
            }
            Inventory_Panel.Visible = false;
            Recipes_Panel.Visible = false;
            Alchemy_Panel.Visible = true;
            Money_label.Text = "Гроші: " + DataBank.get_money() + "$";
            Hydrogen_label.Text = "Водород: " + DataBank.get_hydrogen();
            Sulfur_label.Text = "Кристал Вілідора: " + DataBank.get_sulfur();
            Chlorine_label.Text = "Вода Шанті: " + DataBank.get_chlorine();
            Boron_label.Text = "Злиток Альтеіда: " + DataBank.get_boron();
            Helium_label.Text = "Дихання Мілмулніра: " + DataBank.get_helium();
            Nitrogen_label.Text = "Слина Сприггана: " + DataBank.get_nitrogen();
            Hydrogen_Sulfide_label.Text = "Смрад Аарду: " + DataBank.get_hydrogen_sulfide();
            hel_hel_hel_label.Text = "Корунда: " + DataBank.get_carbon();
            helium_hydrogen_label.Text = "Ектоплазма: " + DataBank.get_helium_hydrogen();
            carbid_bora_label.Text = "Мрачний Кристал: " + DataBank.get_carbid_bora();
            oksid_azota_label.Text = "Сіль Порожнечі: " + DataBank.get_nitrogen_boron();
            dioksid_hlora_label.Text = "Пахощі: " + DataBank.get_oksid_azota();
            trihlorid_azota_label.Text = "Вовча Загибель: " + DataBank.get_dioksid_hlora();
            nitrogen_boron_label.Text = "Сторічне Добриво: " + DataBank.get_trihlorid_azota();
        }

        private void Mix_Button_Click_1(object sender, EventArgs e)
        {
            if (DataBank.get_HydrogenSulfide() == Mix_TextBox.Text)
            {
                if (DataBank.get_hydrogen() >= 1 && DataBank.get_sulfur() >= 1)
                {
                    Mix_Label.Text = "Результат : Смрад Аарду";
                    DataBank.set_hydrogen_sulfide(DataBank.get_hydrogen_sulfide() + 1);
                    Hydrogen_Sulfide_label.Text = "Смрад Аарду: " + DataBank.get_hydrogen_sulfide();
                    DataBank.set_hydrogen(DataBank.get_hydrogen() - 1);
                    Hydrogen_label.Text = "Водород: " + DataBank.get_hydrogen();
                    DataBank.set_sulfur(DataBank.get_sulfur() - 1);
                    Sulfur_label.Text = "Кристал Вілідора: " + DataBank.get_sulfur();

                }
                else
                {
                    MessageBox.Show("У вас недостатньо інгредієнтів!");
                }

            }
            if (DataBank.get_helhelhel() == Mix_TextBox.Text)
            {

                Mix_Label.Text = "Результат : Корунда";
                hel_hel_hel_label.Text = "Корунда: " + DataBank.get_carbon();
                DataBank.set_helium(DataBank.get_helium() - 1);
                Helium_label.Text = "Дихання Мілмулніра: " + DataBank.get_helium();




            }
            if (DataBank.get_heliumhydrogen() == Mix_TextBox.Text)
            {
                if (DataBank.get_helium() >= 1 && DataBank.get_hydrogen() >= 1)
                {
                    Mix_Label.Text = "Результат : Ектоплазма";
                    DataBank.set_hydrogen_sulfide(DataBank.get_hydrogen_sulfide() + 1);
                    helium_hydrogen_label.Text = "Ектоплазма: " + DataBank.get_hydrogen_sulfide();
                    DataBank.set_helium(DataBank.get_helium() - 1);
                    Helium_label.Text = "Дихання Мілмулніра: " + DataBank.get_helium();
                    DataBank.set_hydrogen(DataBank.get_hydrogen() - 1);
                    Nitrogen_label.Text = "Слина Сприггана: " + DataBank.get_hydrogen();

                }
                else
                {
                    MessageBox.Show("У вас недостатньо інгредієнтів!");
                }


            }
            if (DataBank.get_carbidbora() == Mix_TextBox.Text)
            {
                if (DataBank.get_boron() >= 1 && DataBank.get_carbon() >= 1)
                {
                    Mix_Label.Text = "Результат : Мрачний Кристал";
                    DataBank.set_carbid_bora(DataBank.get_carbid_bora() + 1);
                    carbid_bora_label.Text = "Мрачний Кристал: " + DataBank.get_carbid_bora();
                    DataBank.set_boron(DataBank.get_boron() - 1);
                    Boron_label.Text = "Злиток Альтеіда: " + DataBank.get_boron();
                    DataBank.set_carbon(DataBank.get_carbon() - 1);
                    hel_hel_hel_label.Text = "Корунда: " + DataBank.get_carbon();

                }
                else
                {
                    MessageBox.Show("У вас недостатньо інгредієнтів!");
                }

            }
            if (DataBank.get_nitrogenboron() == Mix_TextBox.Text)
            {
                if (DataBank.get_boron() >= 1 && DataBank.get_nitrogen() >= 1)
                {
                    Mix_Label.Text = "Результат : Сіль Порожнечі";
                    DataBank.set_nitrogen_boron(DataBank.get_nitrogen_boron() + 1);
                    oksid_azota_label.Text = "Сіль Порожнечі: " + DataBank.get_nitrogen_boron();
                    DataBank.set_boron(DataBank.get_boron() - 1);
                    Boron_label.Text = "Злиток Альтеіда: " + DataBank.get_boron();
                    DataBank.set_nitrogen(DataBank.get_nitrogen() - 1);
                    Nitrogen_label.Text = "Слина Сприггана: " + DataBank.get_nitrogen();

                }
                else
                {
                    MessageBox.Show("У вас недостатньо інгредієнтів!");
                }

            }
            if (DataBank.get_oksidazota() == Mix_TextBox.Text)
            {
                if (DataBank.get_nitrogen() >= 1 && DataBank.get_oxygen() >= 1)
                {
                    Mix_Label.Text = "Результат : Пахощі";
                    DataBank.set_oksid_azota(DataBank.get_oksid_azota() + 1);
                    dioksid_hlora_label.Text = "Пахощі: " + DataBank.get_oksid_azota();
                    DataBank.set_nitrogen(DataBank.get_nitrogen() - 1);
                    Nitrogen_label.Text = "Слина Сприггана: " + DataBank.get_nitrogen();
                    DataBank.set_oxygen(DataBank.get_oxygen() - 1);
                }
                else
                {
                    MessageBox.Show("У вас недостатньо інгредієнтів!");
                }

            }
            if (DataBank.get_dioksidhlora() == Mix_TextBox.Text)
            {
                if (DataBank.get_chlorine() >= 1 && DataBank.get_oxygen() >= 1)
                {
                    Mix_Label.Text = "Результат : Вовча Загибель";
                    DataBank.set_dioksid_hlora(DataBank.get_dioksid_hlora() + 1);
                    trihlorid_azota_label.Text = "Вовча Загибель: " + DataBank.get_dioksid_hlora();
                    DataBank.set_chlorine(DataBank.get_chlorine() - 1);
                    Chlorine_label.Text = "Вода Шанті: " + DataBank.get_chlorine();
                    DataBank.set_oxygen(DataBank.get_oxygen() - 2);
                }
                else
                {
                    MessageBox.Show("У вас недостатньо інгредієнтів!");
                }

            }
            if (DataBank.get_trihloridazota() == Mix_TextBox.Text)
            {
                if (DataBank.get_nitrogen() >= 1 && DataBank.get_chlorine() >= 1)
                {
                    Mix_Label.Text = "Результат : Сторічне Добриво";
                    DataBank.set_nitrogen_boron(DataBank.get_nitrogen_boron() + 1);
                    nitrogen_boron_label.Text = "Сторічне Добриво: " + DataBank.get_trihlorid_azota();
                    DataBank.set_nitrogen(DataBank.get_nitrogen() - 1);
                    Nitrogen_label.Text = "Слина Сприггана: " + DataBank.get_nitrogen();
                    DataBank.set_chlorine(DataBank.get_chlorine() - 3);
                    Chlorine_label.Text = "Вода Шанті: " + DataBank.get_chlorine();
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
