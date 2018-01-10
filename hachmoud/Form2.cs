using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hachmoud
{
    public partial class TirageAuto : Form
    {
        private PictureBox[] ppot1 = new PictureBox[8];
        private PictureBox[] ppot2 = new PictureBox[8];
        private PictureBox[] ppot3 = new PictureBox[8];
        private PictureBox[] ppot4 = new PictureBox[8];
        private PictureBox[] ppot5 = new PictureBox[32];
        private int ticks = 0;
        private Random rand = new Random();

        private PictureBox[] pic1 = new PictureBox[8];

        //public PictureBox getform3(int i)
        //{
        //    return pic1[i];            

        //}
        public TirageAuto()
        {
            InitializeComponent();
            button1.Visible = false;

            ppot1[0] = pictureBox1;
            ppot1[1] = pictureBox2;
            ppot1[2] = pictureBox3;
            ppot1[3] = pictureBox4;
            ppot1[4] = pictureBox5;
            ppot1[5] = pictureBox6;
            ppot1[6] = pictureBox7;
            ppot1[7] = pictureBox8;

            ppot2[0] = pictureBox9;
            ppot2[1] = pictureBox10;
            ppot2[2] = pictureBox11;
            ppot2[3] = pictureBox12;
            ppot2[4] = pictureBox13;
            ppot2[5] = pictureBox14;
            ppot2[6] = pictureBox15;
            ppot2[7] = pictureBox16;

            ppot3[0] = pictureBox17;
            ppot3[1] = pictureBox18;
            ppot3[2] = pictureBox19;
            ppot3[3] = pictureBox20;
            ppot3[4] = pictureBox21;
            ppot3[5] = pictureBox22;
            ppot3[6] = pictureBox23;
            ppot3[7] = pictureBox24;

            ppot4[0] = pictureBox25;
            ppot4[1] = pictureBox26;
            ppot4[2] = pictureBox27;
            ppot4[3] = pictureBox28;
            ppot4[4] = pictureBox29;
            ppot4[5] = pictureBox30;
            ppot4[6] = pictureBox31;
            ppot4[7] = pictureBox32;

        }

        //public Form3 get()
        //{
        //   return 
        //}

        private void button2_Click(object sender, EventArgs e)
        {
            ticks++;

            if (ticks == 1)
            {
                pot1();
            }
            else if (ticks == 2)
            {
                pot2();
            }
            else if (ticks == 3)
            {
                pot3();
            }
            else if (ticks == 4)
            {
                pot4();
            }
            else
            {
                MessageBox.Show("Tu as terminé le Tirage");
                button1.Visible = true;
                button2.Visible = false;
            }
        }

        private void pot1()
        {
            button2.Text = "Tirage Pot2";
            pictureBox1.Image = Properties.Resources.Russia;
            pictureBox2.Image = Properties.Resources.German;
            pictureBox3.Image = Properties.Resources.Brazil;
            pictureBox4.Image = Properties.Resources.Portugal;
            pictureBox5.Image = Properties.Resources.Argentina;
            pictureBox6.Image = Properties.Resources.Belgium;
            pictureBox7.Image = Properties.Resources.Poland;
            pictureBox8.Image = Properties.Resources.France;

            List<int> tab1 = new List<int>();
            int number1;
            for (int i = 0; i < 8; i++)
            {
                do
                {
                    number1 = rand.Next(0, 8);
                } while (tab1.Contains(number1));
                tab1.Add(number1);
            }

            pictureBox33.Image = ppot1[tab1[0]].Image;
            pictureBox37.Image = ppot1[tab1[1]].Image;
            pictureBox41.Image = ppot1[tab1[2]].Image;
            pictureBox42.Image = ppot1[tab1[3]].Image;
            pictureBox49.Image = ppot1[tab1[4]].Image;
            pictureBox50.Image = ppot1[tab1[5]].Image;
            pictureBox51.Image = ppot1[tab1[6]].Image;
            pictureBox52.Image = ppot1[tab1[7]].Image;
        }

        public PictureBox getpic1(int i)
        {
            return pic1[i];
        }

        private void pot2()
        {
            button2.Text = "Tirage Pot3";
            pictureBox9.Image = Properties.Resources.Spain;
            pictureBox10.Image = Properties.Resources.perou;
            pictureBox11.Image = Properties.Resources.Sweden;
            pictureBox12.Image = Properties.Resources.angleterre;
            pictureBox13.Image = Properties.Resources.Colombia;
            pictureBox14.Image = Properties.Resources.Mexica;
            pictureBox15.Image = Properties.Resources.Uruguay;
            pictureBox16.Image = Properties.Resources.Croatia;

            List<int> tab2 = new List<int>();
            int number2;
            for (int i = 0; i < 8; i++)
            {
                do
                {
                    number2 = rand.Next(0, 8);
                } while (tab2.Contains(number2));
                tab2.Add(number2);
            }


            pictureBox34.Image = ppot2[tab2[0]].Image;
            pictureBox38.Image = ppot2[tab2[1]].Image;
            pictureBox43.Image = ppot2[tab2[2]].Image;
            pictureBox44.Image = ppot2[tab2[3]].Image;
            pictureBox53.Image = ppot2[tab2[4]].Image;
            pictureBox55.Image = ppot2[tab2[5]].Image;
            pictureBox54.Image = ppot2[tab2[6]].Image;
            pictureBox56.Image = ppot2[tab2[7]].Image;

        }

        private void pot3()
        {
            button2.Text = "Tirage Pot4";
            pictureBox17.Image = Properties.Resources.Denmark;
            pictureBox18.Image = Properties.Resources.Islande;
            pictureBox19.Image = Properties.Resources.Costa_Rica;
            pictureBox20.Image = Properties.Resources.Switzerland;
            pictureBox21.Image = Properties.Resources.Tunisia;
            pictureBox22.Image = Properties.Resources.Egypte;
            pictureBox23.Image = Properties.Resources.Senegal;
            pictureBox24.Image = Properties.Resources.Iran;
            //label41.Text = "DEN";
            //label42.Text = "ISL";
            //label44.Text = "CRC";
            //label46.Text = "SWE";
            //label43.Text = "TUN";
            //label45.Text = "EGY";
            //label47.Text = "SEN";
            //label48.Text = "IRN";


            List<int> tab3 = new List<int>();
            int number3;
            for (int i = 0; i < 8; i++)
            {
                do
                {
                    number3 = rand.Next(0, 8);
                } while (tab3.Contains(number3));
                tab3.Add(number3);
            }

            pictureBox35.Image = ppot3[tab3[0]].Image;
            pictureBox39.Image = ppot3[tab3[1]].Image;
            pictureBox45.Image = ppot3[tab3[2]].Image;
            pictureBox46.Image = ppot3[tab3[3]].Image;
            pictureBox57.Image = ppot3[tab3[4]].Image;
            pictureBox59.Image = ppot3[tab3[5]].Image;
            pictureBox58.Image = ppot3[tab3[6]].Image;
            pictureBox60.Image = ppot3[tab3[7]].Image;
        }

        private void pot4()
        {
            button2.Text = "Fin De Tirage";
            pictureBox25.Image = Properties.Resources.Serbia;
            pictureBox26.Image = Properties.Resources.Nigeria;
            pictureBox27.Image = Properties.Resources.australien;
            pictureBox28.Image = Properties.Resources.Japan;
            pictureBox29.Image = Properties.Resources.Morocco;
            pictureBox30.Image = Properties.Resources.panama;
            pictureBox31.Image = Properties.Resources.South_Korea;
            pictureBox32.Image = Properties.Resources.Saudi_Arabia;
            //label49.Text = "SRB";
            //label50.Text = "NGA";
            //label52.Text = "AUS";
            //label54.Text = "JPN";
            //label51.Text = "MAR";
            //label53.Text = "PAN";
            //label55.Text = "KOR";
            //label56.Text = "KSA";

            List<int> tab4 = new List<int>();
            int number4;
            for (int i = 0; i < 8; i++)
            {
                do
                {
                    number4 = rand.Next(0, 8);
                } while (tab4.Contains(number4));
                tab4.Add(number4);
            }

            pictureBox36.Image = ppot4[tab4[0]].Image;
            pictureBox40.Image = ppot4[tab4[1]].Image;
            pictureBox47.Image = ppot4[tab4[2]].Image;
            pictureBox48.Image = ppot4[tab4[3]].Image;
            pictureBox61.Image = ppot4[tab4[4]].Image;
            pictureBox63.Image = ppot4[tab4[5]].Image;
            pictureBox62.Image = ppot4[tab4[6]].Image;
            pictureBox64.Image = ppot4[tab4[7]].Image;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Arbre a2 = new Arbre();
            a2.Show();
        }
    }
}


