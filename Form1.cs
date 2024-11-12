using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace auoceaniaGUI_egyszeru
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btexit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Orszagok> lista = new List<Orszagok>();
            public void betoltes()
            {
                rtbadatok.Clear();
                FileStream fs = new FileStream("..\\..\\src\\ausztralia_oceania.txt", FileMode.Open);
                StreamReader sr = new StreamReader(fs);

                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    rtbadatok.Text = rtbadatok.Text+line+"\n";
                    Orszagok o=new Orszagok(line);
                    lista.Add(o);
                }
                sr.Close();
                fs.Close();
            }
        }
    }
}
