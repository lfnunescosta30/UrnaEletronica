using System.Security.Cryptography.X509Certificates;

namespace UrnaEletronica
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       // string joao = "12";
        //string pedro = "13";
        //string paulo = "14";
        string x = "";
        string y = "";
        string z = "";
        private void btn_num_um_Click(object sender, EventArgs e)
        {
             x = "1";
        }

        private void btn_num_dois_Click(object sender, EventArgs e)
        {
            y = "2";
            
        }

        private void btn_confirma_Click(object sender, EventArgs e)
        {
            z = x + y;
            
            if (z == "12")
            {
                MessageBox.Show("Você votou no joao");
            }
        }
    }
}