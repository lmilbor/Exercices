using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADO
{
    public partial class FormCommandes : Form
    {
        public FormCommandes()
        {
            InitializeComponent();
            lbClient.DataSource = DAL.GetListClientNom();
            lbClient.DoubleClick += LbClient_DoubleClick;
        }

        private void LbClient_DoubleClick(object sender, EventArgs e)
        {
            dgvListCommandesClient.DataSource = DAL.GetCommandesClient(lbClient.SelectedItem.ToString()); 
        }
    }
}
