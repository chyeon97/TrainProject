using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrainProject
{
    public partial class FIND_ID : Form
    {
        //DataTable mytable;

        public FIND_ID()
        {
            InitializeComponent();
          //  mytable = dataSet11.Tables["MEMBER"];
        }

        private void find_btn_Click(object sender, EventArgs e)
        {
           /* int result = Convert.ToInt32(memberTableAdapter1.FillByfind_ID(name_txtbox.Text, phone_txtbox.Text));
            if (result == 1) { 
                foreach(DataRow mydataRow  in mytable.Rows)
                {
                    MessageBox.Show("ID는" + mydataRow["M_ID"].ToString() + "입니다.");
                }
              
            
            
            }*/
        }
    }
}
