using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static AlchemyAlpha0._1.Program;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace AlchemyAlpha0._1
{
    public partial class MainWindow : Form
    {        
        public MainWindow()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            saveFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.fon_1;
            if (DataBank.sound_volume == true)
            {
                SoundPlayer sound = new SoundPlayer(Properties.Resources.house);
                sound.PlayLooping();
            }
            Inventory_Panel.Visible = false;
            Recipes_Panel.Visible = false;
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

        private void Shop_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            ShopWindows shop = new ShopWindows();
            shop.Show();
        }

        private void Alchemy_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            AlchemyWindows alchemy = new AlchemyWindows();
            alchemy.Show();
        }

        private void Inventory_Button_Click(object sender, EventArgs e)
        {
            Inventory_Panel.Visible = true;
        }

        private void Recipes_Button_Click(object sender, EventArgs e)
        {
            Recipes_Panel.Visible = true;
        }

        private void Home_Button_Click(object sender, EventArgs e)
        {
            this.Close();
            HomeWindow home = new HomeWindow();
            home.Show();
        }

        private void Inventory_Close_Button_Click(object sender, EventArgs e)
        {
            Inventory_Panel.Visible = false;
        }

        private void Recipes_Close_Button_Click(object sender, EventArgs e)
        {
            Recipes_Panel.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = 1;
            int b = 10;
            panel1.Size = new Size(500,545);
            panel1.Location = new Point(1500,400);
           // textBox1.Location = new Point(1000,650);
            Random rnd = new Random();
            int c = rnd.Next(a, b);
            if (c == 1)
            {
                panel1.Visible = true;
                panel1.BackgroundImage = Properties.Resources._1;
                panel1.BackgroundImageLayout = ImageLayout.Zoom;
                textBox1.Visible = true;
                textBox1.Text = "Доброго дня алхімік, мені потрібен яд Вовча Загибель, не задавай зайвих запитань і я доплачу за працю";
                void sale_Click(object sender, EventArgs e){
                    if (DataBank.dioksid_hlora >= 1)
                    {
                        DataBank.dioksid_hlora = DataBank.dioksid_hlora - 1;
                        trihlorid_azota_label.Text = "Вовча Загибель: " + DataBank.dioksid_hlora;
                        DataBank.money = DataBank.money + 50;
                        Money_label.Text = "Гроші: " + DataBank.money + "$";
                        DataBank.order = DataBank.order + 1;
                        label2.Text = "Замовлення:" + DataBank.order;

                        Random rnd = new Random();
                        int c = rnd.Next(a, b);
                    }
                    else
                    {
                        MessageBox.Show("У вас недостатньо інгредієнтів!");
                    }
                }
            }

            if (c == 2)
            {
                panel1.Visible = true;
                panel1.BackgroundImage = Properties.Resources._2;
                textBox1.Visible = true;
                textBox1.Text = "Потрібна ектоплазма для добрива, у невеликих кульках";
                if (DataBank.Hydrogen_Sulfide >= 1)
                {
                    DataBank.Hydrogen_Sulfide = DataBank.Hydrogen_Sulfide - 1;
                    helium_hydrogen_label.Text = "Ектоплазма: " + DataBank.Hydrogen_Sulfide;
                    DataBank.money = DataBank.money + 60;
                    Money_label.Text = "Гроші: " + DataBank.money + "$";
                    DataBank.order = DataBank.order + 1;
                    label2.Text = "Замовлення:" + DataBank.order;

                }
                else
                {
                    MessageBox.Show("У вас недостатньо інгредієнтів!");
                }
            }

            if (c == 3)
            {
                panel1.Visible = true;
                panel1.BackgroundImage = Properties.Resources._3;
                textBox1.Visible = true;
                textBox1.Text = "Усього доброго, міський алхімік, для нашої церкви потрібні нові пахощі. Церковна парафія буде тобі вдячна";
                if (DataBank.oksid_azota >= 1)
                {
                    DataBank.oksid_azota = DataBank.oksid_azota - 1;
                    dioksid_hlora_label.Text = "Пахощі: " + DataBank.oksid_azota;
                    DataBank.money = DataBank.money + 70;
                    Money_label.Text = "Гроші: " + DataBank.money + "$";
                    DataBank.order = DataBank.order + 1;
                    label2.Text = "Замовлення:" + DataBank.order;

                }
                else
                {
                    MessageBox.Show("У вас недостатньо інгредієнтів!");
                }
            }

            if (c == 4)
            {
                panel1.Visible = true;
                panel1.BackgroundImage = Properties.Resources._4;
                textBox1.Visible = true;
                textBox1.Text = "Привести колега, для моїх ексерементів потрібна Сіль Порожнечі, потім зайду покажу результати";
                if (DataBank.nitrogen_boron >= 1)
                {
                    DataBank.nitrogen_boron = DataBank.nitrogen_boron - 1;
                    oksid_azota_label.Text = "Сіль Порожнечі: " + DataBank.nitrogen_boron;
                    DataBank.money = DataBank.money + 80;
                    Money_label.Text = "Гроші: " + DataBank.money + "$";
                    DataBank.order = DataBank.order + 1;
                    label2.Text = "Замовлення:" + DataBank.order;

                }
                else
                {
                    MessageBox.Show("У вас недостатньо інгредієнтів!");
                }
            }

            if (c == 5)
            {
                panel1.Visible = true;
                panel1.BackgroundImage = Properties.Resources._5;
                textBox1.Visible = true;
                textBox1.Text = "Потрібно Сторічне Добриво, мої рослини помирають від вашого холодного клімату.";
                if (DataBank.trihlorid_azota >= 1)
                {
                    DataBank.trihlorid_azota = DataBank.trihlorid_azota - 1;
                    nitrogen_boron_label.Text = "Сторічне Добриво: " + DataBank.trihlorid_azota;
                    DataBank.money = DataBank.money + 90;
                    Money_label.Text = "Гроші: " + DataBank.money + "$";
                    DataBank.order = DataBank.order + 1;
                    label2.Text = "Замовлення:" + DataBank.order;

                }
                else
                {
                    MessageBox.Show("У вас недостатньо інгредієнтів!");
                }
            }

            if (c == 6)
            {
                panel1.Visible = true;
                panel1.BackgroundImage = Properties.Resources._6;
                textBox1.Visible = true;
                textBox1.Text = "У кузні потрібна нова партія Злитків Альтеіда. Впораєшся за декілька днів?";
                if (DataBank.Boron >= 1)
                {
                    DataBank.Boron = DataBank.Boron - 1;
                    Boron_label.Text = "Злиток Альтеіда: " + DataBank.Boron;
                    DataBank.money = DataBank.money + 100;
                    Money_label.Text = "Гроші: " + DataBank.money + "$";
                    DataBank.order = DataBank.order + 1;
                    label2.Text = "Замовлення:" + DataBank.order;

                }
                else
                {
                    MessageBox.Show("У вас недостатньо інгредієнтів!");
                }
            }

            if (c == 7)
            {
                panel1.Visible = true;
                panel1.BackgroundImage = Properties.Resources._7;
                textBox1.Visible = true;
                textBox1.Text = "У бібліотеці завелися щури. Відвідувачі не дотримувалися правила \"З їжею не можна\". Знайдіть відповідний засіб вирішення проблеми.(Смрад Аарду)";
                if (DataBank.Hydrogen_Sulfide >= 1)
                {
                    DataBank.Hydrogen_Sulfide = DataBank.Hydrogen_Sulfide - 1;
                    Hydrogen_Sulfide_label.Text = "Смрад Аарду: " + DataBank.Hydrogen_Sulfide;
                    DataBank.money = DataBank.money + 55;
                    Money_label.Text = "Гроші: " + DataBank.money + "$";
                    DataBank.order = DataBank.order + 1;
                    label2.Text = "Замовлення:" + DataBank.order;

                }
                else
                {
                    MessageBox.Show("У вас недостатньо інгредієнтів!");
                }
            }

            if (c == 8)
            {
                panel1.Visible = true;
                panel1.BackgroundImage = Properties.Resources._8;
                textBox1.Visible = true;
                textBox1.Text = "На річницю хочу подарувати дружині намисто із Мрачними Кристалами. Впораєтеся із замовленням?";
                if (DataBank.carbid_bora >= 1)
                {
                    DataBank.carbid_bora = DataBank.carbid_bora - 1;
                    carbid_bora_label.Text = "Мрачний Кристал: " + DataBank.carbid_bora;
                    DataBank.money = DataBank.money + 65;
                    Money_label.Text = "Гроші: " + DataBank.money + "$";
                    DataBank.order = DataBank.order + 1;
                    label2.Text = "Замовлення:" + DataBank.order;

                }
                else
                {
                    MessageBox.Show("У вас недостатньо інгредієнтів!");
                }
            }

            if (c == 9)
            {
                panel1.Visible = true;
                panel1.BackgroundImage = Properties.Resources._1;
                textBox1.Visible = true;
                textBox1.Text = "Для моїх цілей знадобився Кристал Вілідора. Чим швидше дістанеш, тим більше отримаєш";
                if (DataBank.sulfur >= 1)
                {
                    DataBank.sulfur = DataBank.sulfur - 1;
                    Sulfur_label.Text = "Кристал Вілідора: " + DataBank.sulfur;
                    DataBank.money = DataBank.money + 75;
                    Money_label.Text = "Гроші: " + DataBank.money + "$";
                    DataBank.order = DataBank.order + 1;
                    label2.Text = "Замовлення:" + DataBank.order;

                }
                else
                {
                    MessageBox.Show("У вас недостатньо інгредієнтів!");
                }
            }
        }

        private void sale_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Main_Button_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.BackColor = Color.Turquoise;
            DataBank.getallstr();

            {
                if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                    return;
                // получаем выбранный файл
                string filename = saveFileDialog1.FileName;
                // сохраняем текст в файл
                string[] files = DataBank.getallstr().ToArray();
                System.IO.File.WriteAllLines(filename, files);

                MessageBox.Show("Файл збережено", "Робота з файлом");
            }


        }

        private void Money_label_Click(object sender, EventArgs e)
        {

        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
