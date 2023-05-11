using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace f1_projesi
{
    public partial class f1_game : Form
    {
        public f1_game()
        {
            InitializeComponent();
        }
        int ver,per,ham,russ,fer,lance,carlos,charles,yuki,fres,noris,pias,gasly,ocon,bottas,zhous,albon,sarge,magn,hulk;

        private void button2_Click(object sender, EventArgs e)
        {
         
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int verg, perg, hamg, russg, ferg, lanceg, carlosg, charlesg, yukig, fresg, norisg, piasg, gaslyg, ocong, bottasg, zhousg, albong, sargeg, magng, hulkg;
            verg = max.Width;
            perg = perez.Width;
            hamg = lewis.Width;
            russg = rus.Width;
            ferg = alo.Width;
            lanceg = str.Width;
            carlosg = sai.Width;
            charlesg = lec.Width;
            yukig = tsu.Width;
            fresg = de.Width;
            norisg = lando.Width;
            piasg = osca.Width;
            gaslyg = gas.Width;
            ocong = oco.Width;
            bottasg = bot.Width;
            zhousg = zhou.Width;
            albong = alb.Width;
            sargeg = sar.Width;
            magng = mag.Width;
            hulkg = hul.Width;


            int uzaklabel = label1.Left;

            Random rastgele = new Random();
            max.Left = max.Left + rasgele.Next(5, 15);
            perez.Left = perez.Left + rasgele.Next(5, 15);
            lewis.Left = lewis.Left + rasgele.Next(5, 15);
            rus.Left = rus.Left + rasgele.Next(5, 15);
            alo.Left = alo.Left + rasgele.Next(5, 15);
            str.Left = str.Left + rasgele.Next(5, 15);
            lec.Left = lec.Left + rasgele.Next(5, 15);
            sai.Left = sai.Left + rasgele.Next(5, 15);
            tsu.Left = tsu.Left + rasgele.Next(5, 15);
            de.Left = tsu.Left + rasgele.Next(5, 15);
            lando.Left = lando.Left + rasgele.Next(5, 15);
            osca.Left = osca.Left + rasgele.Next(5, 15);
            gas.Left = gas.Left + rasgele.Next(5, 15);
            oco.Left = oco.Left + rasgele.Next(5, 15);
            bot.Left = bot.Left + rasgele.Next(5, 15);
            zhou.Left = zhou.Left + rasgele.Next(5, 15);
            alb.Left = alb.Left + rasgele.Next(5, 15);
            sar.Left = sar.Left + rasgele.Next(5, 15);
            hul.Left = hul.Left + rasgele.Next(5, 15);
            mag.Left = mag.Left + rasgele.Next(5, 15);


            if (max.Left > perez.Left + 5 &&
                max.Left > lewis.Left + 5 &&
                max.Left > rus.Left   + 5 &&
                max.Left > alo.Left   + 5 &&
                max.Left > str.Left   + 5 &&
                max.Left > lec.Left   + 5 &&
                max.Left > sai.Left   + 5 &&
                max.Left > tsu.Left   + 5 &&
                max.Left > de.Left    + 5 &&
                max.Left > lando.Left + 5 &&
                max.Left > osca.Left  + 5 &&
                max.Left > gas.Left   + 5 &&
                max.Left > oco.Left   + 5 &&
                max.Left > bot.Left   + 5 &&
                max.Left > zhou.Left  + 5 &&
                max.Left > alb.Left   + 5 &&
                max.Left > sar.Left   + 5 &&
                max.Left > hul.Left   + 5 &&
                max.Left > mag.Left   + 5)     
            {
                label2.Text = "MAX ÖNDE";

             
            }
            if (perez.Left > max.Left + 5 &&
              perez.Left > lewis.Left + 5 &&
              perez.Left > rus.Left + 5 &&
              perez.Left > alo.Left + 5 &&
              perez.Left > str.Left + 5 &&
              perez.Left > lec.Left + 5 &&
              perez.Left > sai.Left + 5 &&
              perez.Left > tsu.Left + 5 &&
              perez.Left > de.Left + 5 &&
              perez.Left > lando.Left + 5 &&
              perez.Left > osca.Left + 5 &&
              perez.Left > gas.Left + 5 &&
              perez.Left > oco.Left + 5 &&
              perez.Left > bot.Left + 5 &&
              perez.Left > zhou.Left + 5 &&
              perez.Left > alb.Left + 5 &&
              perez.Left > sar.Left + 5 &&
              perez.Left > hul.Left + 5 &&
              perez.Left > mag.Left + 5)
            {
                label2.Text = "PEREZ ÖNDE";
             
            }
            if (lewis.Left > perez.Left + 5 &&
              lewis.Left > max.Left + 5 &&
              lewis.Left > rus.Left + 5 &&
              lewis.Left > alo.Left + 5 &&
              lewis.Left > str.Left + 5 &&
              lewis.Left > lec.Left + 5 &&
              lewis.Left > sai.Left + 5 &&
              lewis.Left > tsu.Left + 5 &&
              lewis.Left > de.Left + 5 &&
              lewis.Left > lando.Left + 5 &&
              lewis.Left > osca.Left + 5 &&
              lewis.Left > gas.Left + 5 &&
              lewis.Left > oco.Left + 5 &&
              lewis.Left > bot.Left + 5 &&
              lewis.Left > zhou.Left + 5 &&
              lewis.Left > alb.Left + 5 &&
              lewis.Left > sar.Left + 5 &&
              lewis.Left > hul.Left + 5 &&
              lewis.Left > mag.Left + 5)
            {
                label2.Text = "LEWİS ÖNDE";
              
            }
            if (rus.Left > perez.Left + 5 &&
             rus.Left > max.Left + 5 &&
             rus.Left > lewis.Left + 5 &&
             rus.Left > alo.Left + 5 &&
             rus.Left > str.Left + 5 &&
             rus.Left > lec.Left + 5 &&
             rus.Left > sai.Left + 5 &&
             rus.Left > tsu.Left + 5 &&
             rus.Left > de.Left + 5 &&
             rus.Left > lando.Left + 5 &&
             rus.Left > osca.Left + 5 &&
             rus.Left > gas.Left + 5 &&
             rus.Left > oco.Left + 5 &&
             rus.Left > bot.Left + 5 &&
             rus.Left > zhou.Left + 5 &&
             rus.Left > alb.Left + 5 &&
             rus.Left > sar.Left + 5 &&
             rus.Left > hul.Left + 5 &&
             rus.Left > mag.Left + 5)
            {
                label2.Text = "RUSELL ÖNDE";
         
            }



            if (alo.Left > perez.Left + 5 &&
              alo.Left > lewis.Left + 5 &&
              alo.Left > rus.Left + 5 &&
              alo.Left > max.Left + 5 &&
              alo.Left > str.Left + 5 &&
              alo.Left > lec.Left + 5 &&
              alo.Left > sai.Left + 5 &&
              alo.Left > tsu.Left + 5 &&
              alo.Left > de.Left + 5 &&
              alo.Left > lando.Left + 5 &&
              alo.Left > osca.Left + 5 &&
              alo.Left > gas.Left + 5 &&
              alo.Left > oco.Left + 5 &&
              alo.Left > bot.Left + 5 &&
              alo.Left > zhou.Left + 5 &&
              alo.Left > alb.Left + 5 &&
              alo.Left > sar.Left + 5 &&
              alo.Left > hul.Left + 5 &&
              alo.Left > mag.Left + 5)
            {
                label2.Text = "ALONSO ÖNDE";
             
            }
            if (alo.Left > perez.Left + 5 &&
             str.Left > lewis.Left + 5 &&
             str.Left > rus.Left + 5 &&
             str.Left > max.Left + 5 &&
             str.Left > alo.Left + 5 &&
             str.Left > lec.Left + 5 &&
             str.Left > sai.Left + 5 &&
             str.Left > tsu.Left + 5 &&
             str.Left > de.Left + 5 &&
             str.Left > lando.Left + 5 &&
             str.Left > osca.Left + 5 &&
             str.Left > gas.Left + 5 &&
             str.Left > oco.Left + 5 &&
             str.Left > bot.Left + 5 &&
             str.Left > zhou.Left + 5 &&
             str.Left > alb.Left + 5 &&
             str.Left > sar.Left + 5 &&
             str.Left > hul.Left + 5 &&
             str.Left > mag.Left + 5)
            {
                label2.Text = "STROLL ÖNDE";
              
            }
            if (lec.Left > perez.Left + 5 &&
            lec.Left > lewis.Left + 5 &&
            lec.Left > rus.Left + 5 &&
            lec.Left > max.Left + 5 &&
            lec.Left > alo.Left + 5 &&
            lec.Left > str.Left + 5 &&
            lec.Left > sai.Left + 5 &&
            lec.Left > tsu.Left + 5 &&
            lec.Left > de.Left + 5 &&
            lec.Left > lando.Left + 5 &&
            lec.Left > osca.Left + 5 &&
            lec.Left > gas.Left + 5 &&
            lec.Left > oco.Left + 5 &&
            lec.Left > bot.Left + 5 &&
            lec.Left > zhou.Left + 5 &&
            lec.Left > alb.Left + 5 &&
            lec.Left > sar.Left + 5 &&
            lec.Left > hul.Left + 5 &&
            lec.Left > mag.Left + 5)
            {
                label2.Text = "LECLERC ÖNDE";
               
            }
            if (sai.Left > perez.Left + 5 &&
            sai.Left > lewis.Left + 5 &&
            sai.Left > rus.Left + 5 &&
            sai.Left > max.Left + 5 &&
            sai.Left > alo.Left + 5 &&
            sai.Left > str.Left + 5 &&
            sai.Left > lec.Left + 5 &&
            sai.Left > tsu.Left + 5 &&
            sai.Left > de.Left + 5 &&
            sai.Left > lando.Left + 5 &&
            sai.Left > osca.Left + 5 &&
            sai.Left > gas.Left + 5 &&
            sai.Left > oco.Left + 5 &&
            sai.Left > bot.Left + 5 &&
            sai.Left > zhou.Left + 5 &&
            sai.Left > alb.Left + 5 &&
            sai.Left > sar.Left + 5 &&
            sai.Left > hul.Left + 5 &&
            sai.Left > mag.Left + 5)
            {
                label2.Text = "SAİNZ ÖNDE";
             
                
            }
            if (tsu.Left > perez.Left + 5 &&
           tsu.Left > lewis.Left + 5 &&
           tsu.Left > rus.Left + 5 &&
           tsu.Left > max.Left + 5 &&
           tsu.Left > alo.Left + 5 &&
           tsu.Left > str.Left + 5 &&
           tsu.Left > lec.Left + 5 &&
           tsu.Left > sai.Left + 5 &&
           tsu.Left > de.Left + 5 &&
           tsu.Left > lando.Left + 5 &&
           tsu.Left > osca.Left + 5 &&
           tsu.Left > gas.Left + 5 &&
           tsu.Left > oco.Left + 5 &&
           tsu.Left > bot.Left + 5 &&
           tsu.Left > zhou.Left + 5 &&
           tsu.Left > alb.Left + 5 &&
           tsu.Left > sar.Left + 5 &&
           tsu.Left > hul.Left + 5 &&
           tsu.Left > mag.Left + 5)
            {
                label2.Text = "TSUNODA ÖNDE";
           
            }
           if (de.Left > perez.Left + 5 &&
          de.Left > lewis.Left + 5 &&
          de.Left > rus.Left + 5 &&
          de.Left > max.Left + 5 &&
          de.Left > alo.Left + 5 &&
          de.Left > str.Left + 5 &&
          de.Left > lec.Left + 5 &&
          de.Left > sai.Left + 5 &&
          de.Left > tsu.Left + 5 &&
          de.Left > lando.Left + 5 &&
          de.Left > osca.Left + 5 &&
          de.Left > gas.Left + 5 &&
          de.Left > oco.Left + 5 &&
          de.Left > bot.Left + 5 &&
          de.Left > zhou.Left + 5 &&
          de.Left > alb.Left + 5 &&
          de.Left > sar.Left + 5 &&
          de.Left > hul.Left + 5 &&
          de.Left > mag.Left + 5)
            {
                label2.Text = "NYCK ÖNDE";
             
            }
            if (lando.Left > perez.Left + 5 &&
              lando.Left > lewis.Left + 5 &&
              lando.Left > rus.Left + 5 &&
              lando.Left > max.Left + 5 &&
              lando.Left > alo.Left + 5 &&
              lando.Left > str.Left + 5 &&
              lando.Left > lec.Left + 5 &&
              lando.Left > sai.Left + 5 &&
              lando.Left > de.Left + 5 &&
              lando.Left > de.Left + 5 &&
              lando.Left > osca.Left + 5 &&
              lando.Left > gas.Left + 5 &&
              lando.Left > oco.Left + 5 &&
              lando.Left > bot.Left + 5 &&
              lando.Left > zhou.Left + 5 &&
              lando.Left > alb.Left + 5 &&
              lando.Left > sar.Left + 5 &&
              lando.Left > hul.Left + 5 &&
              lando.Left > mag.Left + 5)
            {
                label2.Text = "LANDO ÖNDE";
           
            }
            if (osca.Left > perez.Left + 5 &&
              osca.Left > lewis.Left + 5 &&
              osca.Left > rus.Left + 5 &&
              osca.Left > max.Left + 5 &&
              osca.Left > alo.Left + 5 &&
              osca.Left > str.Left + 5 &&
              osca.Left > lec.Left + 5 &&
              osca.Left > sai.Left + 5 &&
              osca.Left > de.Left + 5 &&
              osca.Left > de.Left + 5 &&
              osca.Left > lando.Left + 5 &&
              osca.Left > gas.Left + 5 &&
              osca.Left > oco.Left + 5 &&
              osca.Left > bot.Left + 5 &&
              osca.Left > zhou.Left + 5 &&
              osca.Left > alb.Left + 5 &&
              osca.Left > sar.Left + 5 &&
              osca.Left > hul.Left + 5 &&
              osca.Left > mag.Left + 5)
            {
                label2.Text = "OSCAR ÖNDE";
             
            }
            if (gas.Left > perez.Left + 5 &&
              gas.Left > lewis.Left + 5 &&
              gas.Left > rus.Left + 5 &&
              gas.Left > max.Left + 5 &&
              gas.Left > alo.Left + 5 &&
              gas.Left > str.Left + 5 &&
              gas.Left > lec.Left + 5 &&
              gas.Left > sai.Left + 5 &&
              gas.Left > de.Left + 5 &&
              gas.Left > de.Left + 5 &&
              gas.Left > lando.Left + 5 &&
              gas.Left > osca.Left + 5 &&
              gas.Left > oco.Left + 5 &&
              gas.Left > bot.Left + 5 &&
              gas.Left > zhou.Left + 5 &&
              gas.Left > alb.Left + 5 &&
              gas.Left > sar.Left + 5 &&
              gas.Left > hul.Left + 5 &&
              gas.Left > mag.Left + 5)
            {
                label2.Text = "GASLY ÖNDE";
     
            }
            if (oco.Left > perez.Left + 5 &&
              oco.Left > lewis.Left + 5 &&
              oco.Left > rus.Left + 5 &&
              oco.Left > max.Left + 5 &&
              oco.Left > alo.Left + 5 &&
              oco.Left > str.Left + 5 &&
              oco.Left > lec.Left + 5 &&
              oco.Left > sai.Left + 5 &&
              oco.Left > de.Left + 5 &&
              oco.Left > de.Left + 5 &&
              oco.Left > lando.Left + 5 &&
              oco.Left > osca.Left + 5 &&
              oco.Left > gas.Left + 5 &&
              oco.Left > bot.Left + 5 &&
              oco.Left > zhou.Left + 5 &&
              oco.Left > alb.Left + 5 &&
              oco.Left > sar.Left + 5 &&
              oco.Left > hul.Left + 5 &&
              oco.Left > mag.Left + 5)
            {
                label2.Text = "OCON ÖNDE";
        
            }
            if (bot.Left > perez.Left + 5 &&
             bot.Left > lewis.Left + 5 &&
             bot.Left > rus.Left + 5 &&
             bot.Left > max.Left + 5 &&
             bot.Left > alo.Left + 5 &&
             bot.Left > str.Left + 5 &&
             bot.Left > lec.Left + 5 &&
             bot.Left > sai.Left + 5 &&
             bot.Left > de.Left + 5 &&
             bot.Left > de.Left + 5 &&
             bot.Left > lando.Left + 5 &&
             bot.Left > osca.Left + 5 &&
             bot.Left > gas.Left + 5 &&
             bot.Left > oco.Left + 5 &&
             bot.Left > zhou.Left + 5 &&
             bot.Left > alb.Left + 5 &&
             bot.Left > sar.Left + 5 &&
             bot.Left > hul.Left + 5 &&
             bot.Left > mag.Left + 5)
            {
                label2.Text = "BOTTAS ÖNDE";
         
            }
            if (zhou.Left > perez.Left + 5 &&
             zhou.Left > lewis.Left + 5 &&
             zhou.Left > rus.Left + 5 &&
             zhou.Left > max.Left + 5 &&
             zhou.Left > alo.Left + 5 &&
             zhou.Left > str.Left + 5 &&
             zhou.Left > lec.Left + 5 &&
             zhou.Left > sai.Left + 5 &&
             zhou.Left > de.Left + 5 &&
             zhou.Left > de.Left + 5 &&
             zhou.Left > lando.Left + 5 &&
             zhou.Left > osca.Left + 5 &&
             zhou.Left > gas.Left + 5 &&
             zhou.Left > oco.Left + 5 &&
             zhou.Left > bot.Left + 5 &&
             zhou.Left > alb.Left + 5 &&
             zhou.Left > sar.Left + 5 &&
             zhou.Left > hul.Left + 5 &&
             zhou.Left > mag.Left + 5)
            {
                label2.Text = "ZHOU ÖNDE";
         
            }
            if (alb.Left > perez.Left + 5 &&
            alb.Left > lewis.Left + 5 &&
            alb.Left > rus.Left + 5 &&
            alb.Left > max.Left + 5 &&
            alb.Left > alo.Left + 5 &&
            alb.Left > str.Left + 5 &&
            alb.Left > lec.Left + 5 &&
            alb.Left > sai.Left + 5 &&
            alb.Left > de.Left + 5 &&
            alb.Left > de.Left + 5 &&
            alb.Left > lando.Left + 5 &&
            alb.Left > osca.Left + 5 &&
            alb.Left > gas.Left + 5 &&
            alb.Left > oco.Left + 5 &&
            alb.Left > bot.Left + 5 &&
            alb.Left > zhou.Left + 5 &&
            alb.Left > sar.Left + 5 &&
            alb.Left > hul.Left + 5 &&
            alb.Left > mag.Left + 5)
            {
                label2.Text = "ALBON ÖNDE";
              
            }
            if (sar.Left > perez.Left + 5 &&
           sar.Left > lewis.Left + 5 &&
           sar.Left > rus.Left + 5 &&
           sar.Left > max.Left + 5 &&
           sar.Left > alo.Left + 5 &&
           sar.Left > str.Left + 5 &&
           sar.Left > lec.Left + 5 &&
           sar.Left > sai.Left + 5 &&
           sar.Left > de.Left + 5 &&
           sar.Left > de.Left + 5 &&
           sar.Left > lando.Left + 5 &&
           sar.Left > osca.Left + 5 &&
           sar.Left > gas.Left + 5 &&
           sar.Left > oco.Left + 5 &&
           sar.Left > bot.Left + 5 &&
           sar.Left > zhou.Left + 5 &&
           sar.Left > alb.Left + 5 &&
           sar.Left > hul.Left + 5 &&
           sar.Left > mag.Left + 5)
            {
                label2.Text = "LOGAN ÖNDE";
      
            }
            if (hul.Left > perez.Left + 5 &&
           hul.Left > lewis.Left + 5 &&
           hul.Left > rus.Left + 5 &&
           hul.Left > max.Left + 5 &&
           hul.Left > alo.Left + 5 &&
           hul.Left > str.Left + 5 &&
           hul.Left > lec.Left + 5 &&
           hul.Left > sai.Left + 5 &&
           hul.Left > de.Left + 5 &&
           hul.Left > de.Left + 5 &&
           hul.Left > lando.Left + 5 &&
           hul.Left > osca.Left + 5 &&
           hul.Left > gas.Left + 5 &&
           hul.Left > oco.Left + 5 &&
           hul.Left > bot.Left + 5 &&
           hul.Left > zhou.Left + 5 &&
           hul.Left > alb.Left + 5 &&
           hul.Left > sar.Left + 5 &&
           hul.Left > mag.Left + 5)
            {
                label2.Text = "NİCO ÖNDE";
            
            }
            if (mag.Left > perez.Left + 5 &&
           mag.Left > lewis.Left + 5 &&
           mag.Left > rus.Left + 5 &&
           mag.Left > max.Left + 5 &&
           mag.Left > alo.Left + 5 &&
           mag.Left > str.Left + 5 &&
           mag.Left > lec.Left + 5 &&
           mag.Left > sai.Left + 5 &&
           mag.Left > de.Left + 5 &&
           mag.Left > de.Left + 5 &&
           mag.Left > lando.Left + 5 &&
           mag.Left > osca.Left + 5 &&
           mag.Left > gas.Left + 5 &&
           mag.Left > oco.Left + 5 &&
           mag.Left > bot.Left + 5 &&
           mag.Left > zhou.Left + 5 &&
           mag.Left > alb.Left + 5 &&
           mag.Left > sar.Left + 5 &&
           mag.Left > mag.Left + 5)
            {
                label2.Text = "KEVİN ÖNDE";
         
            }




            if (verg + max.Left >= uzaklabel)
            {
                timer1.Enabled = false;
                MessageBox.Show("Max Verstappen Wins");
                
               
                
            }
            if (perg + perez.Left >= uzaklabel)
            {
                timer1.Enabled = false;
                MessageBox.Show("Sergio Perez Wins");
            }

            if (hamg + lewis.Left >= uzaklabel)
            {
                timer1.Enabled = false;
                MessageBox.Show("Lewis Hamilton Wins");
            }
            if (russg + rus.Left >= uzaklabel)
            {
                timer1.Enabled = false;
                MessageBox.Show("George Russell Wins");
            }
            if (ferg + alo.Left >= uzaklabel)
            {
                timer1.Enabled = false;
                MessageBox.Show("Fernando Alonso Wins");
            }
            if (lanceg + str.Left >= uzaklabel)
            {
                timer1.Enabled = false;
                MessageBox.Show("Lance Stroll Wins");
            }
            if (carlosg + sai.Left >= uzaklabel)
            {
                timer1.Enabled = false;
                MessageBox.Show("Carlos Sainz Wins");
            }
            if (charlesg + lec.Left >= uzaklabel)
            {
                timer1.Enabled = false;
                MessageBox.Show("Charles Leclerc Wins");
            }
            if (yukig + tsu.Left >= uzaklabel)
            {
                timer1.Enabled = false;
                MessageBox.Show("Yuki Tsunoda Wins");
            }
            if (ferg + de.Left >= uzaklabel)
            {
                timer1.Enabled = false;
                MessageBox.Show("Nyck de Vries Wins");
            }
            if (norisg + lando.Left >= uzaklabel)
            {
                timer1.Enabled = false;
                MessageBox.Show("Lando Norris Wins");

            }
            if (piasg + osca.Left >= uzaklabel)
            {
                timer1.Enabled = false;
                MessageBox.Show("Oscar Piastri Wins");
            }
            if (gaslyg + gas.Left >= uzaklabel)
            {
                timer1.Enabled = false;
                MessageBox.Show("Pierre Gasly Wins");
            }
            if (ocong + oco.Left >= uzaklabel)
            {
                timer1.Enabled = false;
                MessageBox.Show("Esteban Ocon Wins");
            }
            if (bottasg + bot.Left >= uzaklabel)
            {
                timer1.Enabled = false;
                MessageBox.Show("Valtteri Bottas Wins");
            }
            if (zhousg + zhou.Left >= uzaklabel)
            {
                timer1.Enabled = false;
                MessageBox.Show("Zhou Guanyu Wins");
            }
            if (albong + alb.Left >= uzaklabel)
            {
                timer1.Enabled = false;
                MessageBox.Show("Alex Albon Wins");
            }
            if (sargeg + sar.Left >= uzaklabel)
            {
                timer1.Enabled = false;
                MessageBox.Show("Logan Sargeant Wins");
            }
            if (hulkg + hul.Left >= uzaklabel)
            {
                timer1.Enabled = false;
                MessageBox.Show("Nico Hulkenberg Wins");
            }
            if (magng + mag.Left >= uzaklabel)
            {
                timer1.Enabled = false;
                MessageBox.Show("Kevin Magnussen Wins");
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            axWindowsMediaPlayer1.URL = "f1_lights.mp3";
            timer1.Enabled = true;
            
            
        }

        Random rasgele = new Random();
        private void Form1_Load(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "f1-Theme.mp3";
            ver = max.Left;
            per = perez.Left;
            ham = lewis.Left;
            russ = rus.Left;
            fer = alo.Left;
            lance = str.Left;
            carlos = sai.Left;
            charles = lec.Left;
            yuki = tsu.Left;
            fres = de.Left;
            noris = lando.Left;
            pias = osca.Left;
            gasly = gas.Left;
            ocon = oco.Left;
            bottas = bot.Left;
            zhous = zhou.Left;
            albon = alb.Left;
            sarge = sar.Left;
            magn = mag.Left;
            hulk = hul.Left;
        }
    }
}
