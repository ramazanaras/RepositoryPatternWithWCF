using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KuzeyYeli.WinArayuz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Wcf servisindeki UrunService.vsc burda sonuna Client eklenmiş.o classı kullanıyoruz
            UrunServiceReference.UrunServiceClient client = new UrunServiceReference.UrunServiceClient();//servisten instance aldıkö

            dataGridView1.DataSource = client.Listele();
        
        
        }
    }
}
