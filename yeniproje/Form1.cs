using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yeniproje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text=DateTime.Now.ToString("HH:mm:ss");
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //string[] arabalar = { "BMW", "Mercedes", "Audi", "Toyota", "Honda" };
            //listBox1.Items.AddRange(arabalar);


            List<string> arabalar = new List<string> {"Ford","Byd","Volvo" };
            listBox1.DataSource = arabalar;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            listBox3.Items.Clear();

            Dictionary<string, string[]> modeller = new Dictionary<string, string[]>();

            modeller.Add("Ford", new string[] { "Focus", "Fiesta", "Kuga" });
            modeller.Add("Byd", new string[] { "Atto 3", "Dolphin", "Seal" });
            modeller.Add("Volvo", new string[] { "XC40", "XC60", "XC90" });

            string marka = listBox1.SelectedItem.ToString();

            listBox2.Items.AddRange(modeller[marka]);
        }

       
        

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox3.Items.Clear();

            Dictionary<string, string[]> paketler = new Dictionary<string, string[]>();

            paketler.Add("Focus", new string[] { "Trend X", "Titanium" });
            paketler.Add("Fiesta", new string[] { "Trend", "Titanium" });
            paketler.Add("Kuga", new string[] { "Titanium", "ST-Line" });

            paketler.Add("Atto 3", new string[] { "Comfort", "Design" });
            paketler.Add("Dolphin", new string[] { "Comfort", "Design" });
            paketler.Add("Seal", new string[] { "Design", "Excellence" });

            paketler.Add("XC40", new string[] { "Core", "Plus" });
            paketler.Add("XC60", new string[] { "Plus", "Ultimate" });
            paketler.Add("XC90", new string[] { "Plus", "Ultimate" });

            string model = listBox2.SelectedItem.ToString();

            listBox3.Items.AddRange(paketler[model]);
        }
    }
}
