﻿using System;
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
            if (DataBank.sound_volume == true)
            {
                SoundPlayer sound = new SoundPlayer(Properties.Resources.bazar);
                sound.PlayLooping();
            }
            Inventory_Panel.Visible = false;
            Recipes_Panel.Visible = false;
            Shop_Panel.Visible = true;
            Money_label.Text = "Гроші: " + DataBank.money + "$";
            Hydrogen_label.Text = "Водород: " + DataBank.hydrogen;
            Sulfur_label.Text = "Кристал Вілідора: " + DataBank.sulfur;
            Chlorine_label.Text = "Вода Шанті: " + DataBank.Chlorine;
            Boron_label.Text = "Злиток Альтеід: " + DataBank.Boron;
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
            if (DataBank.money >= 10)
            {
                DataBank.money = DataBank.money - 10;
                Money_label.Text = "Гроші: " + DataBank.money + "$";
                DataBank.hydrogen += 1;
                Hydrogen_label.Text = "Водород: " + DataBank.hydrogen;
                
            }
            else
            {
                MessageBox.Show("У вас недостатньо грошей!");
            }
        }

        private void Sulfur_button_Click(object sender, EventArgs e)
        {
            if (DataBank.money >= 10)
            {
                DataBank.money = DataBank.money - 10;
                Money_label.Text = "Гроші: " + DataBank.money + "$";
                DataBank.sulfur += 1;
                Sulfur_label.Text = "Кристал Вілідора: " + DataBank.sulfur;
             
            }
            else
            {
                MessageBox.Show("У вас недостатньо грошей!");
            }
        }

        private void Chlorine_button_Click(object sender, EventArgs e)
        {
            if (DataBank.money >= 20)
            {
                DataBank.money = DataBank.money - 20;
                Money_label.Text = "Гроші: " + DataBank.money + "$";
                DataBank.Chlorine += 1;
                Chlorine_label.Text = "Вода Шанті: " + DataBank.Chlorine;
                
            }
            else
            {
                MessageBox.Show("У вас недостатньо грошей!");
            }
        }

        private void Boron_button_Click(object sender, EventArgs e)
        {
            if (DataBank.money >= 40)
            {
                DataBank.money = DataBank.money - 40;
                Money_label.Text = "Гроші: " + DataBank.money + "$";
                DataBank.Boron += 1;
                Boron_label.Text = "Злиток Альтеіда: " + DataBank.Boron;
              
            }
            else
            {
                MessageBox.Show("У вас недостатньо грошей!");
            }
        }

        private void Helium_button_Click(object sender, EventArgs e)
        {
            if (DataBank.money >= 40)
            {
                DataBank.money = DataBank.money - 40;
                Money_label.Text = "Гроші: " + DataBank.money + "$";
                DataBank.Helium += 1;
                Helium_label.Text = "Дихання Мілмулніра: " + DataBank.Helium;
               
            }
            else
            {
                MessageBox.Show("У вас недостатньо грошей!");
            }
        }

        private void Nitrogen_button_Click(object sender, EventArgs e)
        {
            if (DataBank.money >= 50)
            {
                DataBank.money = DataBank.money - 50;
                Money_label.Text = "Гроші: " + DataBank.money + "$";
                DataBank.Nitrogen += 1;
                Nitrogen_label.Text = "Слина Сприггана: " + DataBank.Nitrogen;
               
            }
            else
            {
                MessageBox.Show("У вас недостатньо грошей!");
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
