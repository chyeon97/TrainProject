using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;

namespace TrainProject
{
    public partial class book2 : Form
    {
        bool state = false;
        DataTable mytable = new DataTable();
        string arrive_time, start_time;//각 역마다의 도착, 출발시간

        int total_fee = 0; //총 요금
        int fee;//경로 구간마다의 요금
        string class_num ;
       string seat_num;
        public book2()
        {
            InitializeComponent();

        }
        private void find_info_btn_Click(object sender, EventArgs e)//정보조회버튼
        {
            state = true;
            if (state == true) this.find_info_btn.Enabled = false; //버튼 한번만 클릭
            

            mytable= this.reservationTableAdapter1.GetDataBy3();
            

            CalculateFee();//요금계산

          
            listBox1.Items.Add("출발역:" + this.stationTableAdapter1.Scalar_S_name(Convert.ToInt32(mainPage1.dt.Rows[0][0])));
            listBox1.Items.Add("도착역:" + this.stationTableAdapter1.Scalar_S_name(Convert.ToInt32(mainPage1.dt.Rows[0][1])));
            for (int i = 0; i < Convert.ToInt32(reservationTableAdapter1.ScalarQuery()); i++) 
            {
                 class_num = mytable.Rows[i][4].ToString();
                 seat_num= mytable.Rows[i][3].ToString();
                listBox1.Items.Add("호차번호:" + class_num);
                listBox1.Items.Add("좌석번호:" + seat_num);
            }
           
           
        }

        public void CalculateFee() //요금계산
        {
            int m_fee = 0;
            int count = Convert.ToInt32(this.reservationTableAdapter1.ScalarQuery()); //예약한 갯수

            for (int i = Convert.ToInt32(mainPage1.dt.Rows[0][0]); i < Convert.ToInt32(mainPage1.dt.Rows[0][1]); i++)
            {

                fee = Convert.ToInt32(this.routeTableAdapter1.FillBy(i, mainPage1.selected_value));
                m_fee += fee;
                total_fee = m_fee * count;

            }

            listBox1.Items.Add("열차요금:" + total_fee.ToString());
     
        }




        private void book2_Load(object sender, EventArgs e)
        {

        }

        private void pay_btn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Convert.ToInt32(reservationTableAdapter1.ScalarQuery()); i++)
            {
                class_num = mytable.Rows[i][4].ToString();
                seat_num = mytable.Rows[i][3].ToString();
                this.reservedTableAdapter1.InsertQuery(seat_num, class_num, mainPage1.selected_value, Convert.ToInt32(mainPage1.dt.Rows[0][0]), Convert.ToInt32(mainPage1.dt.Rows[0][1]),book.seq,mainPage.M_ID);//예약된 테이블에 삽입

            }
           
            this.reservationTableAdapter1.DeleteQuery();

            MessageBox.Show("예약이 완료되었습니다.");
            this.Dispose();   
        }


    }
}
