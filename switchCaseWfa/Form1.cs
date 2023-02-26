using System.Linq.Expressions;

namespace switchCaseWfa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
           
            int aylar = Convert.ToInt32(monthText.Text);

            switch (aylar)
            {
                case 1: sonucLabel.Text = "Ocak".ToString();

                    break;
                case 2:
                    sonucLabel.Text = "Şubat".ToString();

                    break;

                case 3:
                    sonucLabel.Text = "Mart".ToString();

                    break;

                case 4:
                    sonucLabel.Text = "Nisan".ToString();

                    break;

                case 5:
                    sonucLabel.Text = "Mayıs".ToString();

                    break;

                case 6:
                    sonucLabel.Text = "Haziran".ToString();

                    break;

                case 7:
                    sonucLabel.Text = "Temmuz".ToString();

                    break;

                case 8:
                    sonucLabel.Text = "Ağustos".ToString();

                    break;
                case 9:
                    sonucLabel.Text = "Eylül".ToString();

                    break;
                case 10:
                    sonucLabel.Text = "Ekim".ToString();

                    break;
                case 11:
                    sonucLabel.Text = "Kasım".ToString();

                    break;
                case 12:
                    sonucLabel.Text = "Aralık".ToString();

                    break;

                default:
                    MessageBox.Show("1 ile 12 arasında değer giriniz");
                    break;
                        



            }


        }
    }
}