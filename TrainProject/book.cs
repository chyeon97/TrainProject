using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Forms;



namespace TrainProject
{
    public partial class book : Form
    {

        int s_id ;//출발역 번호
        int a_id ; //도착역 번호
        string t_state = (mainPage1.value).ToString();
        
        public DataTable dt2 = new DataTable();//예약된 정보 들고오는 테이블
        public DataTable dt3;
        static public long seq;//현재 시퀀스번호 들고오는 변수
        static public string seat_num, class_num;//좌석,호차번호

        public book()
        {
            s_id = Convert.ToInt32(mainPage1.dt.Rows[0][0]);
            a_id = Convert.ToInt32(mainPage1.dt.Rows[0][1]);

            InitializeComponent();
            oracleConnection1.Open();

            this.textBox1.Text = mainPage1.selected_value; //열차번호
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }


        public void insert_dt2_coloum() //dt2의 열 삽입
        {

            Reserved_Cmd.CommandText = "SELECT a1.SOURCE_S_ID, a2.ARRIVE_S_ID,SEAT_NUM,CLASS_NUM FROM ROUTE a1 INNER JOIN ROUTE a2 ON a1.T_ID=a2.T_ID AND a1.R_STATE=a2.R_STATE INNER JOIN SEAT ON SEAT.T_ID=a1.T_ID AND SEAT.T_ID=a2.T_ID AND SEAT.T_STATE=a1.R_STATE AND SEAT.T_STATE=a2.R_STATE WHERE SEAT.T_ID=:Seat_TID INTERSECT SELECT a1.SOURCE_S_ID, a2.ARRIVE_S_ID,RESERVED.SEAT_NUM ,RESERVED.CLASS_NUM FROM ROUTE a1 INNER JOIN ROUTE a2 ON a1.T_ID=a2.T_ID AND a1.R_STATE=a2.R_STATE INNER JOIN RESERVED ON a1.SOURCE_S_ID=RESERVED.SOURCE_S_ID AND a2.ARRIVE_S_ID = RESERVED.ARRIVE_S_ID WHERE RESERVED.T_ID=:Reserve_TID AND a1.SOURCE_S_ID=:S_id AND a2.ARRIVE_S_ID=:A_id";
            Reserved_Cmd.Parameters["Seat_TID"].Value = textBox1.Text;
            Reserved_Cmd.Parameters["Reserve_TID"].Value = textBox1.Text;

            Reserved_Cmd.Parameters["S_id"].Value = s_id;
            Reserved_Cmd.Parameters["A_id"].Value = a_id;

            OracleDataReader rdr2 = Reserved_Cmd.ExecuteReader();
            dt2.Load(rdr2);


        }
        public void newtable_dt3()
        {
            dt3 = new DataTable("Reserved_seat_table");  //예약된 좌석의 호차번호와 좌석번호 추출하는 테이블       
            DataColumn Seat = new DataColumn("seat_n", typeof(string));
            DataColumn Class = new DataColumn("class_n", typeof(string));

            Seat.AllowDBNull = false;
            Class.AllowDBNull = false;

            dt3.Columns.Add(Seat); //테이블에 컬럼 추가
            dt3.Columns.Add(Class);
        }

        public void insert_dt3_coloum() //dt3의 열 삽입
        {
            string s_num, c_num = null;

            for (int i = 0; i < dt2.Rows.Count; i++)
            {
                DataRow newRow = dt3.NewRow();

                DataRow s = dt2.Rows[i];

                s_num = s["SEAT_NUM"].ToString();
                c_num = s["CLASS_NUM"].ToString();

                newRow["seat_n"] = s_num;
                newRow["class_n"] = c_num;

                dt3.Rows.Add(newRow);
            }

        }

        private void ok_btn_Click(object sender, EventArgs e) //좌석조회 버튼
        {

            try
            {
                nonReserveSeat_Cmd.CommandText = "SELECT a1.SOURCE_S_ID, a2.ARRIVE_S_ID,SEAT_NUM,CLASS_NUM FROM ROUTE a1 INNER JOIN ROUTE a2 ON a1.T_ID=a2.T_ID AND a1.R_STATE=a2.R_STATE INNER JOIN SEAT ON SEAT.T_ID=a1.T_ID AND SEAT.T_ID=a2.T_ID AND SEAT.T_STATE=a1.R_STATE AND SEAT.T_STATE=a2.R_STATE WHERE SEAT.T_ID=:seatTID MINUS select a1.SOURCE_S_ID, a2.ARRIVE_S_ID,RESERVED.SEAT_NUM,RESERVED.CLASS_NUM FROM ROUTE a1 INNER JOIN ROUTE a2 ON a1.T_ID=a2.T_ID AND a1.R_STATE=a2.R_STATE INNER JOIN RESERVED ON a1.SOURCE_S_ID=RESERVED.SOURCE_S_ID AND a2.ARRIVE_S_ID = RESERVED.ARRIVE_S_ID WHERE RESERVED.T_ID=:ResrvTID";
                nonReserveSeat_Cmd.Parameters["seatTID"].Value = textBox1.Text;
                nonReserveSeat_Cmd.Parameters["ResrvTID"].Value = textBox1.Text;

                DataTable dt = new DataTable();
                OracleDataReader rdr = nonReserveSeat_Cmd.ExecuteReader();
                dt.Load(rdr);
                dataGridView1.DataSource = dt;
                
                insert_dt2_coloum();
                newtable_dt3();
                insert_dt3_coloum();


                for (int i = 0; i < dt3.Rows.Count; i++) //예약된 좌석이면 버튼막기
                {

                    foreach (DataRow row in dt3.Rows)
                    {
                        if (dt3.Rows[i][0].ToString() == num1.Text && dt3.Rows[i][1].ToString() == room1.Text)
                        {
                            num1.Enabled = false;
                        }
                    }
                    foreach (DataRow row in dt3.Rows)
                    {
                        if (dt3.Rows[i][0].ToString() == num2.Text && dt3.Rows[i][1].ToString() == room1.Text)
                        {
                            num2.Enabled = false;
                        }

                    }
                    foreach (DataRow row in dt3.Rows)
                    {
                        if (dt3.Rows[i][0].ToString() == num3.Text && dt3.Rows[i][1].ToString() == room1.Text)
                        {
                            num3.Enabled = false;
                        }

                    }
                    foreach (DataRow row in dt3.Rows)
                    {
                        if (dt3.Rows[i][0].ToString() == num4.Text && dt3.Rows[i][1].ToString() == room1.Text)
                        {
                            num4.Enabled = false;
                        }

                    }
                    foreach (DataRow row in dt3.Rows)
                    {
                        if (dt3.Rows[i][0].ToString() == num_1.Text && dt3.Rows[i][1].ToString() == room2.Text)
                        {
                            num_1.Enabled = false;
                        }

                    }
                    foreach (DataRow row in dt3.Rows)
                    {
                        if (dt3.Rows[i][0].ToString() == num_2.Text && dt3.Rows[i][1].ToString() == room2.Text)
                        {
                            num_2.Enabled = false;
                        }

                    }
                    foreach (DataRow row in dt3.Rows)
                    {
                        if (dt3.Rows[i][0].ToString() == num_3.Text && dt3.Rows[i][1].ToString() == room2.Text)
                        {
                            num_3.Enabled = false;
                        }
                    }

                    foreach (DataRow row in dt3.Rows)
                    {
                        if (dt3.Rows[i][0].ToString() == num_4.Text && dt3.Rows[i][1].ToString() == room2.Text)
                        {
                            num_4.Enabled = false;
                        }

                    }
                }
            }
            catch (Exception a) { MessageBox.Show(a.ToString()); }



        }

        private void num1_CheckedChanged(object sender, EventArgs e)
        {
        }
        private void num2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void num3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void num4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void num_1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void num_2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void num_3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void num_4_CheckedChanged(object sender, EventArgs e)
        {

        }




       private void reservation_Click(object sender, EventArgs e) //예약 버튼
        {

            Insert.CommandText = "select RES_NUM.nextval from dual"; //현재 시퀀스 번호 
             seq= Convert.ToInt64(Insert.ExecuteScalar());
            MessageBox.Show(seq.ToString());

            CheckBox[] checkbox = new CheckBox[] { num1, num2, num3, num4, num_1, num_2, num_3, num_4 };
            foreach (CheckBox c in checkbox)
            {
                int test = Convert.ToInt32(c.Text);             
                if(test <=4)
                 {
                      if (c.Checked == true)
                       {
                           class_num = "1호차";
                             switch (c.Text)
                             {

                                 case "1": seat_num = c.Text; this.reservationTableAdapter1.InsertQuery(s_id, a_id, textBox1.Text, c.Text, room1.Text, t_state,seq); break;
                                 case "2": seat_num = c.Text; this.reservationTableAdapter1.InsertQuery(s_id, a_id, textBox1.Text, c.Text, room1.Text, t_state,seq); break;
                                 case "3": seat_num = c.Text; this.reservationTableAdapter1.InsertQuery(s_id, a_id, textBox1.Text, c.Text, room1.Text, t_state,seq); break;
                                 case "4": seat_num = c.Text; this.reservationTableAdapter1.InsertQuery(s_id, a_id, textBox1.Text, c.Text, room1.Text, t_state,seq); break;
                               }
                           
                   
                         }
                
                  }
                 
                else{
                     if (c.Checked == true)
                      {
                          class_num = "2호차";
                        switch (c.Text)
                        {
                                
                            case "5": seat_num = c.Text; this.reservationTableAdapter1.InsertQuery(s_id, a_id, textBox1.Text, c.Text, room2.Text, t_state,seq); break;
                            case "6": seat_num = c.Text; this.reservationTableAdapter1.InsertQuery(s_id, a_id, textBox1.Text, c.Text, room2.Text, t_state,seq); break;
                            case "7": seat_num = c.Text; this.reservationTableAdapter1.InsertQuery(s_id, a_id, textBox1.Text, c.Text, room2.Text, t_state,seq); break;
                            case "8": seat_num = c.Text; this.reservationTableAdapter1.InsertQuery(s_id, a_id, textBox1.Text, c.Text, room2.Text, t_state,seq); break;
                           
                           
                        }
                    }
              
                    }          
                }

            this.memberTableAdapter1.UpdateQuery(seq, mainPage.M_ID);//회원이 예약하면 예약번호 할당
           
            


            MessageBox.Show("Reservation 테이블에 삽입");

            book2 form = new book2();
            form.ShowDialog();
            this.Dispose();
             
            
            }

       private void pictureBox1_Click(object sender, EventArgs e)
       {
           this.Dispose();
       }

        }
    }


