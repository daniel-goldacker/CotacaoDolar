using ContacaoDolar.Domain;
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
using System.Windows.Forms.DataVisualization.Charting;

namespace CotacaoDolar.UI
{
    public partial class frmCotacaoDolar : Form
    {
        public frmCotacaoDolar()
        {
            InitializeComponent();
            montaGrid();
        }
       
        private void montaGrid()
        {
            dgvCotacaoDolar.Columns.Add("Data", "Data");
            dgvCotacaoDolar.Columns.Add("Valor", "Valor (U$)");
            dgvCotacaoDolar.ReadOnly = true;
        }

        private void btnMostrarCotacaoDolar_Click(object sender, EventArgs e)
        {
            double cotacaoDolarAtual = 0;

            dgvCotacaoDolar.Rows.Clear();
            lblCotacaoDolarAtual.Text = String.Empty;

            CotacaoDolarBLL cotacaoDolarBLL = new CotacaoDolarBLL();
            foreach (var item in cotacaoDolarBLL.BuscaDadosCotacaoDolarAPI((int) nudDias.Value))
            {
                dgvCotacaoDolar.Rows.Add(item.Data, Math.Round(item.Valor, 2));
                cotacaoDolarAtual = item.Valor;
            }

            lblCotacaoDolarAtual.Text = "U$ " + Convert.ToString(Math.Round(cotacaoDolarAtual, 2));
            lblCotacaoDolarAtual.TextAlign = ContentAlignment.MiddleCenter;
        }
    }
}
