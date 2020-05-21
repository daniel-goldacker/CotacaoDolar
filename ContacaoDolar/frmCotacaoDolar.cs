using CotacaoDolar.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContacaoDolar
{
    public partial class frmCotacaoDolar : Form
    {
        public frmCotacaoDolar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CotacaoDolarBLL cotacaoDolarBLL = new CotacaoDolarBLL();

            MessageBox.Show(cotacaoDolarBLL.BuscaDadosCotacaoDolarAPI(1));

            CotacaoDolar[] CotacaoDolar = new CotacaoDolar[]();
        }
    }
}
