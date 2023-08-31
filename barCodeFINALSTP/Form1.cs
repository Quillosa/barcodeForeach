using System.Collections;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace barCodeFINALSTP
{
    public partial class Form1 : Form
    {
        ArrayList code = new ArrayList();
        ArrayList product = new ArrayList();
        public int x = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            code.Add(textBox1.Text);

            product.Add(textBox2.Text);


            MessageBox.Show("Saved");
            textBox1.Text = "";
            textBox2.Text = "";

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

            foreach (var lop in code)
            {
                if (textBox3.Text.Equals(lop.ToString()))
                {
                    label1.Text = product[code.IndexOf(lop.ToString())].ToString();

                }
            }
            


        }
    }
}