using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Polymorphizm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        
           
        }

        private void btnEt_Click(object sender, EventArgs e)
        {
            EtYemekleri ey = new EtYemekleri();
            YemeklerinSunumSekli(ey);
            //MessageBox.Show(ey.SunumSekli());
        }

        private void btnSebze_Click(object sender, EventArgs e)
        {
            SebzeYemekleri sb = new SebzeYemekleri();
            YemeklerinSunumSekli(sb);
            //MessageBox.Show(sb.SunumSekli());
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            AraSicaklar ara = new AraSicaklar();
            YemeklerinSunumSekli(ara);
            //MessageBox.Show(ara.SunumSekli());
        }
        void YemeklerinSunumSekli(Yemek yss)
        {
            MessageBox.Show(yss.SunumSekli());
        }
    }
}
