namespace Excel_Macros_Ablösetool_Fehlermeldungen
{
    public partial class Form1 : Form
    {
        string textFile = @"C:\Users\justi\OneDrive - BBBaden\Desktop\Fehlermeldungen.txt";

        public Form1()
        {
            InitializeComponent();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            // Da ploppt ein neues Fenster auf
            Fehlermeldung d = new Fehlermeldung();
            d.ShowDialog();
            MessageBox.Show(textFile,"Titel" );
        }
    }
}