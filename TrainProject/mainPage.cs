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
    public partial class mainPage : Form
    {
        DataTable mytable;
        public static string M_ID;

        public mainPage()
        {
            InitializeComponent();
           // mainPage_Paint();
        }
       

        private void mainPage_Load_1(object sender, EventArgs e)
        {
            memberTableAdapter1.Fill(dataSet11.MEMBER);
            mytable = dataSet11.Tables["MEMBER"];
        }
 
       
        private void login_btn_Click_1(object sender, EventArgs e)
        {
            try
            {


                int result = Convert.ToInt32(memberTableAdapter1.FillByLogin(id_txtbox.Text, password_txtbox.Text));

                M_ID = id_txtbox.Text;

                if (id_txtbox.Text == "admin" && password_txtbox.Text == "5414290")
                {
                    usermainpage form = new usermainpage();
                    form.ShowDialog();
                    this.Dispose();



                }
                if (result == 1)
                {
                  
                    mainPage1 form = new mainPage1();
                    form.ShowDialog();
                    this.Dispose();//현재 창 닫기
                }
                else
                {
                    MessageBox.Show("등록되지 않은 ID입니다");
                }


            }

            catch (Exception a) { MessageBox.Show(a.ToString()); }
        }

        

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Dispose();      
        }

      
    }
}
