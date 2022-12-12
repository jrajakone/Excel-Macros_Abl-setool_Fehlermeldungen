using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Excel_Macros_Ablösetool_Fehlermeldungen
{
    public partial class Fehlermeldung : Form
    {
        string textFile = @"C:\Users\justi\OneDrive - BBBaden\Desktop\Fehlermeldungen.txt";
        public Fehlermeldung()
        {
            InitializeComponent();

            // Text.txt wird geprüft und angezeigt
            if (File.Exists(textFile))
            {
                string textContent = File.ReadAllText(textFile);
                
                label2.Text = textContent;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
    
}
