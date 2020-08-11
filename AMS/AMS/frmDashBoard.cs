using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using EL;
using DL;

namespace AMS
{
    public partial class frmDashBoard : DevExpress.XtraEditors.XtraForm
    {
        ETimeSheet objETimeSheet = new ETimeSheet();
        DTimeSheet objDTimeSheet = new DTimeSheet();
        public frmDashBoard()
        {
            InitializeComponent();
            objDTimeSheet.GetDashboard(objETimeSheet);
            gcDashBoard.DataSource = objETimeSheet.dtDashoard;
        }
    }
}