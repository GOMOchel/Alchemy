using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlchemyAlpha0._1
{
    public partial class ShopWindows : Form
    {
        public ShopWindows()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
        }

        private void Main_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainWindow main = new MainWindow();
            main.Show();
        }

        private void ShopWindows_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.lavka;
            if (DataBank.get_sound_volume() == true)
            {
                SoundPlayer sound = new SoundPlayer(Properties.Resources.bazar);
                sound.PlayLooping();
            }
            Inventory_Panel.Visible = false;
            Recipes_Panel.Visible = false;
            Shop_Panel.Visible = true;
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

        private void Home_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomeWindow home = new HomeWindow();
            home.Show();
        }

        private void Alchemy_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            AlchemyWindows alchemy = new AlchemyWindows();
            alchemy.Show();
        }

        private void Hydrogen_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (DataBank.get_money() >= 10)
                {
                    DataBank.set_money(DataBank.get_money() - 10);
                    Money_label.Text = "Гроші: " + DataBank.get_money() + "$";
                    DataBank.set_hydrogen(DataBank.get_hydrogen() + 1);
                    Hydrogen_label.Text = "Водород: " + DataBank.get_hydrogen();

                }
                else
                {
                    MessageBox.Show("У вас недостатньо грошей!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Sulfur_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (DataBank.get_money() >= 10)
                {
                    DataBank.set_money(DataBank.get_money() - 10);
                    Money_label.Text = "Гроші: " + DataBank.get_money() + "$";
                    DataBank.set_sulfur(DataBank.get_sulfur() + 1);
                    Sulfur_label.Text = "Кристал Вілідора: " + DataBank.get_sulfur();

                }
                else
                {
                    MessageBox.Show("У вас недостатньо грошей!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Chlorine_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (DataBank.get_money() >= 20)
                {
                    DataBank.set_money(DataBank.get_money() - 20);
                    Money_label.Text = "Гроші: " + DataBank.get_money() + "$";
                    DataBank.set_chlorine(DataBank.get_chlorine() + 1);
                    Chlorine_label.Text = "Вода Шанті: " + DataBank.get_chlorine();

                }
                else
                {
                    MessageBox.Show("У вас недостатньо грошей!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Boron_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (DataBank.get_money() >= 40)
                {
                    DataBank.set_money(DataBank.get_money() - 40);
                    Money_label.Text = "Гроші: " + DataBank.get_money() + "$";
                    DataBank.set_boron(DataBank.get_boron() + 1);
                    Boron_label.Text = "Злиток Альтеіда: " + DataBank.get_boron();

                }
                else
                {
                    MessageBox.Show("У вас недостатньо грошей!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Helium_button_Click(object sender, EventArgs e)
        {
            try { 
            if (DataBank.get_money() >= 40)
            {
                DataBank.set_money(DataBank.get_money() - 40);
                Money_label.Text = "Гроші: " + DataBank.get_money() + "$";
                DataBank.set_helium(DataBank.get_helium() + 1);
                Helium_label.Text = "Дихання Мілмулніра: " + DataBank.get_helium();
               
            }
            else
            {
                MessageBox.Show("У вас недостатньо грошей!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Nitrogen_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (DataBank.get_money() >= 50)
                {
                    DataBank.set_money(DataBank.get_money() - 50);
                    Money_label.Text = "Гроші: " + DataBank.get_money() + "$";
                    DataBank.set_nitrogen(DataBank.get_nitrogen() + 1);
                    Nitrogen_label.Text = "Слина Сприггана: " + DataBank.get_nitrogen();

                }
                else
                {
                    MessageBox.Show("У вас недостатньо грошей!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Inventory_Button_Click(object sender, EventArgs e)
        {
            Inventory_Panel.Visible = true;
        }

        private void Inventory_Close_Button_Click(object sender, EventArgs e)
        {
            Inventory_Panel.Visible = false;
        }

        private void Recipes_Button_Click(object sender, EventArgs e)
        {
            Recipes_Panel.Visible = true;
        }

        private void Recipes_Close_Button_Click(object sender, EventArgs e)
        {
            Recipes_Panel.Visible = false;
        }

        private void peoples_orders_Click(object sender, EventArgs e)
        {
             
        }
    }
}
