using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_QLNguoiDung
{
    public partial class frm_CauHinhChuoiKetNoi : Form
    {
        public frm_CauHinhChuoiKetNoi()
        {
            InitializeComponent();
        }

        private void cbo_Server_DropDown(object sender, EventArgs e)
        {
            //cbo_Server.DataSource = f
        }
        private DataTable getServerName()
        {
            DataTable dt = new DataTable();
            dt = SqlDataSourceEnumerator.Instance.GetDataSources();
            return dt;
        }
    }   
}
