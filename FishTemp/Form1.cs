using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace FishTemp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void FishName_TextChanged(object sender, EventArgs e)
        {
            if (FishName.Text == "Минтай")
            {
                MinTemp.Visible = false;
                TimeMin.Visible = false;
            }
            else
            {
                MaxTemp.Visible = true;
                TimeMax.Visible = true;
                MinTemp.Visible = true;
                TimeMin.Visible = true;
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader sr = new StreamReader(ofd.FileName))
                {
                    List<string> list = new List<string>();
                    string line = sr.ReadLine();
                    while (line != null)
                    {
                        DataTime.Text = Convert.ToDateTime(line).ToString("yy.mm.dd h:mm");
                        line = sr.ReadLine();
                        Temperature.Text = line;
                        line = sr.ReadLine();
                    }
                }
            }
        }

        private void Run_Click(object sender, EventArgs e)
        {
/*            switch (FishName.Text)
            {
                case "Сенга"
                    if ()
                    break;

            }*/
        }
    }
}
