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
    public partial class Arbre : Form
    {
       private PictureBox picture1  = new PictureBox();
       private PictureBox picture2  = new PictureBox();
       private PictureBox picture3  = new PictureBox();
       private PictureBox picture4  = new PictureBox();
       private PictureBox picture5  = new PictureBox();
       private PictureBox picture6  = new PictureBox();
       private PictureBox picture7  = new PictureBox();
       private PictureBox picture8  = new PictureBox();
       
       private PictureBox picture9  = new PictureBox();
       private PictureBox picture10 = new PictureBox();
       private PictureBox picture11 = new PictureBox();
       private PictureBox picture12 = new PictureBox();
       private PictureBox picture13 = new PictureBox();
       private PictureBox picture14 = new PictureBox();
       private PictureBox picture15 = new PictureBox();
       private PictureBox picture16 = new PictureBox();

       private PictureBox picture17 = new PictureBox();
       private PictureBox picture18 = new PictureBox();
       private PictureBox picture19 = new PictureBox();
       private PictureBox picture20 = new PictureBox();
       private PictureBox picture21 = new PictureBox();
       private PictureBox picture22 = new PictureBox();
       private PictureBox picture23 = new PictureBox();
       private PictureBox picture24 = new PictureBox();
       
       private PictureBox picture25 = new PictureBox();
       private PictureBox picture26 = new PictureBox();
       private PictureBox picture27 = new PictureBox();
       private PictureBox picture28 = new PictureBox();
       private PictureBox picture29 = new PictureBox();
       private PictureBox picture30 = new PictureBox();
       private PictureBox picture31 = new PictureBox();
       private PictureBox picture32 = new PictureBox();

        private Random rand = new Random();

        private PictureBox[] ppot1 = new PictureBox[8];
        private PictureBox[] ppot2 = new PictureBox[8];
        private PictureBox[] ppot3 = new PictureBox[8];
        private PictureBox[] ppot4 = new PictureBox[8];

        public Arbre()
        {
            InitializeComponent();

            ppot1[0] = picture1;
            ppot1[1] = picture2;
            ppot1[2] = picture3;
            ppot1[3] = picture4;
            ppot1[4] = picture5;
            ppot1[5] = picture6;
            ppot1[6] = picture7;
            ppot1[7] = picture8;

            ppot2[0] = picture9;
            ppot2[1] = picture10;
            ppot2[2] = picture11;
            ppot2[3] = picture12;
            ppot2[4] = picture13;
            ppot2[5] = picture14;
            ppot2[6] = picture15;
            ppot2[7] = picture16;

            ppot3[0] = picture17;
            ppot3[1] = picture18;
            ppot3[2] = picture19;
            ppot3[3] = picture20;
            ppot3[4] = picture21;
            ppot3[5] = picture22;
            ppot3[6] = picture23;
            ppot3[7] = picture24;

            ppot4[0] = picture25;
            ppot4[1] = picture26;
            ppot4[2] = picture27;
            ppot4[3] = picture28;
            ppot4[4] = picture29;
            ppot4[5] = picture30;
            ppot4[6] = picture31;
            ppot4[7] = picture32;

            pot1();
            pot2();
            pot3();
            pot4();
            pictureBox13.Image = pictureBox10.Image;
            pictureBox14.Image = pictureBox11.Image;
            pictureBox15.Image = pictureBox13.Image;
        }

        private void pot1()
        {
            picture1.Image = Properties.Resources.Russia;
            picture2.Image = Properties.Resources.German;
            picture3.Image = Properties.Resources.Brazil;
            picture4.Image = Properties.Resources.Portugal;
            picture5.Image = Properties.Resources.Argentina;
            picture6.Image = Properties.Resources.Belgium;
            picture7.Image = Properties.Resources.Poland;
            picture8.Image = Properties.Resources.France;

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
            pictureBox1.Image = ppot1[tab1[3]].Image;
            pictureBox2.Image = ppot1[tab1[6]].Image;
            pictureBox9.Image = ppot1[tab1[3]].Image;
        }

        private void pot2()
        {
            picture9.Image = Properties.Resources.Spain;
            picture10.Image = Properties.Resources.perou;
            picture11.Image = Properties.Resources.Sweden;
            picture12.Image = Properties.Resources.angleterre;
            picture13.Image = Properties.Resources.Colombia;
            picture14.Image = Properties.Resources.Mexica;
            picture15.Image = Properties.Resources.Uruguay;
            picture16.Image = Properties.Resources.Croatia;

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

            pictureBox3.Image = ppot2[tab2[0]].Image;
            pictureBox4.Image = ppot2[tab2[3]].Image;
            pictureBox10.Image = ppot2[tab2[3]].Image;
        }

        private void pot3()
        {
            picture17.Image = Properties.Resources.Denmark;
            picture18.Image = Properties.Resources.Islande;
            picture19.Image = Properties.Resources.Costa_Rica;
            picture20.Image = Properties.Resources.Switzerland;
            picture21.Image = Properties.Resources.Tunisia;
            picture22.Image = Properties.Resources.Egypte;
            picture23.Image = Properties.Resources.Senegal;
            picture24.Image = Properties.Resources.Iran;

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

            pictureBox5.Image = ppot3[tab3[2]].Image;
            pictureBox6.Image = ppot3[tab3[7]].Image;
            pictureBox11.Image = ppot3[tab3[2]].Image;
        }

        private void pot4()
        {
            picture25.Image = Properties.Resources.Serbia;
            picture26.Image = Properties.Resources.Nigeria;
            picture27.Image = Properties.Resources.australien;
            picture28.Image = Properties.Resources.Japan;
            picture29.Image = Properties.Resources.Morocco;
            picture30.Image = Properties.Resources.panama;
            picture31.Image = Properties.Resources.South_Korea;
            picture32.Image = Properties.Resources.Saudi_Arabia;

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

            pictureBox7.Image = ppot4[tab4[0]].Image;
            pictureBox8.Image = ppot4[tab4[4]].Image;
            pictureBox12.Image = ppot4[tab4[4]].Image;

        }
    }
}
