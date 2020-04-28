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
    public partial class join : Form
    {
       DataTable mytable;
        public join()
        {
            InitializeComponent();
            mytable = dataSet11.Tables["MEMBER"];
        }

        private void ok_btn_Click(object sender, EventArgs e)
        {
            try
            {

                DataRow mynewDataRow = mytable.NewRow();
                mynewDataRow["M_ID"] = join_id_txtbox.Text;
                mynewDataRow["M_PASSWORD"] = join_password_txtbox.Text;
                mynewDataRow["M_NAME"] = join_name_txtbox.Text;
                mynewDataRow["M_PHONE"] = join_phone_txtbox.Text;
                mytable.Rows.Add(mynewDataRow);

                memberTableAdapter1.Update(mynewDataRow);

                MessageBox.Show("DB업데이트완료");
                 this.Close();
            }
            catch (Exception a) { MessageBox.Show(a.ToString()); }
        }

        private void id_check_btn_Click(object sender, EventArgs e)
        {
            try
            {

                int result = Convert.ToInt32(memberTableAdapter1.FillByCheck(join_id_txtbox.Text));
                if (result == 1)
                {
                    MessageBox.Show("이미 존재하는 ID입니다.");
                    join_id_txtbox.Text = null;
                }
                else
                {
                    MessageBox.Show("사용가능한 ID입니다.");
                }
                

            }
            catch (Exception a) { MessageBox.Show(a.ToString()); }
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
