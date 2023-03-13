using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace Excel_Macros_Ablösetool_Fehlermeldungen
{
    public partial class Fehlermeldung : Form
    {
        // string textFile = @"C:\Users\justi\OneDrive - BBBaden\Desktop\Fehlermeldungen.txt"; // Fehlermeldung text
        string configfile = @"C:\Users\justi\OneDrive - BBBaden\Desktop\app.config.txt";  // Configfile datei


        public Fehlermeldung()
        {
            InitializeComponent();

            // Text.txt wird geprüft und angezeigt
            String[] data = File.ReadAllLines(configfile);
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(String.Join("", data));

            XmlNode root = doc.FirstChild;

            MessageBox.Show(root.ChildNodes[0].ChildNodes[0].Attributes["key"].Value);

            //
            string[] str = new string[2];
            str[0] = root.ChildNodes[0].ChildNodes[0].Attributes["key"].Value;
            
            //

        }

        private void button1_Click(object sender, EventArgs e)
        {
        }
    }
    
}
