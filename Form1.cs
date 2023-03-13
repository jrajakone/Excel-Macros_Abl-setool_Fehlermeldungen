using Microsoft.VisualBasic;
using System.Xml;
using System.Xml.Schema;

namespace Excel_Macros_Ablösetool_Fehlermeldungen
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            /// <summary>
            /// Da ploppt ein neues Fenster auf
            /// </summary>

            Fehlermeldung d = new Fehlermeldung();
            d.ShowDialog();
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            comboBox1.Items();

           
        }
    }
}