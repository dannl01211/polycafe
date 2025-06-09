
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL_PolyCafe; // Ensure this namespace exists and contains the BUSThongKe class  

namespace GUI_PolyCafe
{
    public partial class frmThongKe : Form
    {
        BUSThongKe busThongKe = new BUSThongKe(); // Ensure BUSThongKe is defined in the BLL_PolyCafe namespace  
        public frmThongKe()
        {
            InitializeComponent();
        }

        private void frmThongKe_Load(object sender, EventArgs e)
        {

        }
    }
}
