using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Oracle.DataAccess.Client;

namespace TrainProject
{
    public partial class usermainpage : Form
    {
        string date;
        int time;// 운행시간 변수
        string t_id, t_state;
        
        DataTable mytable = new DataTable(); //열차
        DataTable route_info = new DataTable(); //경로에 따른 운행시간

        DateTime start_time, arrive_time; //출발,도착시간

        public usermainpage()
        {
            InitializeComponent();
            oracleConnection1.Open();
        }

        private void usermainpage_Load(object sender, EventArgs e)
        {
            // TODO: 이 코드는 데이터를 'dataSet1.ROUTE_INFO' 테이블에 로드합니다. 필요한 경우 이 코드를 이동하거나 제거할 수 있습니다.
          //  this.rOUTE_INFOTableAdapter.Fill(this.dataSet1.ROUTE_INFO);
          
        }
       
    
        private void button1_Click(object sender, EventArgs e) //열차생성버튼
        {
            date = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            trainInsert_Cmd.CommandText = "INSERT INTO TRAIN VALUES(:T_ID,:T_STATE,:T_DATE)";
            trainInsert_Cmd.Parameters["T_ID"].Value = train_num_txtbox.Text;
            trainInsert_Cmd.Parameters["T_STATE"].Value = comboBox1.Text;
            trainInsert_Cmd.Parameters["T_DATE"].Value = date;

            trainInsert_Cmd.ExecuteNonQuery(); //train 테이블에 삽입


            MessageBox.Show("열차가 DB에 업데이트되었습니다.");
             this.trainTableAdapter1.Fill(dataSet1.TRAIN);

        }
   

        private void button3_Click(object sender, EventArgs e)//경로생성 버튼
        {

            DataTable station = new DataTable();
            OracleDataReader rdr2 = station_Cmd.ExecuteReader(); // 역번호 가져오기
                station.Load(rdr2); 
            
            

            string init_time = init_time_txtbox.Text; //초기 시간
            DateTime INIT_TIME = Convert.ToDateTime(init_time); //초기 시간을 DateTime으로 형변환

            string fee = fee_txtbox.Text; //구간별 요금
            OracleDataReader rdr = routeInfo_Cmd.ExecuteReader(); //route_info 테이블의 운행시간 가져오기
            route_info.Load(rdr);

            int start_s_id = Convert.ToInt32(station.Rows[0][0]); //부산 역번호
            int arrive_s_id = Convert.ToInt32(stationTableAdapter1.ScalarQuery()); //역 테이블의 역갯수(도착역번호)


            if (trainState_txtbox.Text == "서울행") 
            {

                for (int i = start_s_id; i < arrive_s_id; i++)
                {

                    if (i == 1)
                    {
                        time = Convert.ToInt32(route_info.Rows[0][0]); //부산-> 대구 운행시간
                        arrive_time = INIT_TIME.AddMinutes(Convert.ToDouble(time)); //부산-> 대구의 도착시간
                        this.routE1TableAdapter1.InsertQuery(i, t_id, fee, route_info.Rows[0][0].ToString(), i + 1, date, INIT_TIME, arrive_time, t_state); 


                    }
                    else if (i > 1)
                    {

                        start_time = arrive_time.AddMinutes(5);//출발시간
                        arrive_time = start_time.AddMinutes(Convert.ToDouble(route_info.Rows[i - 1][0])); //도착시간
                        this.routE1TableAdapter1.InsertQuery(i, t_id, fee, route_info.Rows[i - 1][0].ToString(), i + 1, date, start_time, arrive_time, trainState_txtbox.Text);


                    }



                }
            }

            if (trainState_txtbox.Text == "부산행") 
            {
                for (int i = arrive_s_id; i > start_s_id; i--) 
                {
                    if (i == 5) 
                    {
                        time = Convert.ToInt32(route_info.Rows[3][0]); //서울-> 부산 운행시간
                        arrive_time = INIT_TIME.AddMinutes(Convert.ToDouble(time)); //서울-> 천안 의 도착시간
                        this.routE1TableAdapter1.InsertQuery(i, train_num_txtbox.Text, fee, route_info.Rows[3][0].ToString(), i - 1, date, INIT_TIME, arrive_time, trainState_txtbox.Text); 
                    }
                    else if (i < 5) 
                    {
                        start_time = arrive_time.AddMinutes(5);//출발시간
                        arrive_time = start_time.AddMinutes(Convert.ToDouble(route_info.Rows[i - 2][0])); //도착시간
                        this.routE1TableAdapter1.InsertQuery(i, train_num_txtbox.Text, fee, route_info.Rows[i - 2][0].ToString(), i - 1, date, start_time, arrive_time, trainState_txtbox.Text);
                        
                    
                    }
                
                }
            
            }

            MessageBox.Show("경로 업데이트 완료");
            this.routE1TableAdapter1.Fill(dataSet1.ROUTE1);
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
           

        }

        private void button4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= 4; i++) 
            {
                string room = "1호차";
                this.seatTableAdapter1.InsertQuery(i.ToString(), room, textBox1.Text, textBox2.Text);
            
            }

            for (int i = 5; i <= 8; i++) 
            {
                string room = "2호차";
                this.seatTableAdapter1.InsertQuery(i.ToString(), room, textBox1.Text, textBox2.Text);
            }

           
            MessageBox.Show("자리생성이 완료되었습니다.");
            this.seatTableAdapter1.Fill(dataSet1.SEAT);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            tabControl1.SelectedTab = tabControl1.TabPages[1]; //다음탭으로 이동

            t_id = train_num_txtbox.Text;
            t_state = comboBox1.Text;

            trainNum_txtbox.Text = t_id;
            trainState_txtbox.Text = t_state;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            mainPage form = new mainPage();
            form.ShowDialog();
            this.Dispose();
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabControl1.TabPages[2];
            textBox1.Text = train_num_txtbox.Text;
            textBox2.Text = trainState_txtbox.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            stationTableAdapter1.Fill(dataSet1.STATION);

           
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            sTATIONBindingSource.AddNew();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            stationTableAdapter1.Update(dataSet1.STATION);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            rOUTE_INFOTableAdapter.Update(dataSet1.ROUTE_INFO);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            rOUTE_INFOTableAdapter.Fill(dataSet1.ROUTE_INFO);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            rOUTEINFOBindingSource.AddNew();
        }

    
       
      
    

      
        
    }
}
