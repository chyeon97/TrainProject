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
    public partial class mainPage1 : Form
    {
        public static string selected_value;
        string source_txt, arrive_txt;
       static  public string value = null;
        public static DataTable dt;
        DataTable mytable2 = new DataTable();

        int res_num;

        public  mainPage1()
        {
            InitializeComponent();
            oracleConnection1.Open();
        }

       public void newtable() //새로운 테이블 생성 메소드
        {
            dt = new DataTable("Calculate");
           
            DataColumn dc_title = new DataColumn("source_id", typeof(string));
            DataColumn dc_title_2 = new DataColumn("arrive_id", typeof(string));
           
            dc_title.AllowDBNull = false;
            dc_title_2.AllowDBNull = false;
            dt.Columns.Add(dc_title); //테이블에 컬럼 추가
            dt.Columns.Add(dc_title_2);

            
        }
        
        private void mainPage1_Load(object sender, EventArgs e)
        {

            this.sTATIONTableAdapter.Fill(dataSet12.STATION);
          
         
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer2_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

         public void dt_insert_coloum() //새로운 테이블에 컬럼추가 메소드
        {
            dt = dataSet11.Tables["dt"];
            DataRow row = dt.NewRow();
            row.ItemArray = new string[] {train_gridView.SelectedRows[0].Cells[1].FormattedValue.ToString(), train_gridView.SelectedRows[0].Cells[2].FormattedValue.ToString() };
            dt.Rows.Add(row);
        
        }
    
  
        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

    
        private void button1_Click(object sender, EventArgs e) //좌석조회 버튼
        {
            
            selected_value =train_gridView.SelectedRows[0].Cells[0].FormattedValue.ToString();//열차번호 저장
            book form = new book();
            form.ShowDialog();
            this.Dispose();
        }

        private void train_gridView_CellMouseClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void tabPage2_Click(object sender, EventArgs e) //예약조회 탭으로 이동시 
        {
            DataTable mytable=new DataTable();
           
            string id=mainPage.M_ID;
            
            my_booking_Cmd.CommandText="select RES_NUM FROM MEMBER WHERE M_ID=:M_ID";
            my_booking_Cmd.Parameters["M_ID"].Value=id;  // 회원 아이디를 통해 예약번호 찾기
            
            OracleDataReader rdr= my_booking_Cmd.ExecuteReader();
            mytable.Load(rdr);
            res_num = Convert.ToInt32(mytable.Rows[0][0]);
            book_info_Cmd.CommandText = "SELECT * FROM RESERVED WHERE RES_NUM=:RES_NUM";
            book_info_Cmd.Parameters["RES_NUM"].Value = res_num; //예약번호를 통해 총 예약 내역 찾기

            

            OracleDataReader rdr2 = book_info_Cmd.ExecuteReader();
            mytable2.Load(rdr2);

            dataGridView1.DataSource = mytable2; // data그리드 뷰에 회원아이디에 맞는  예약내역 출력
           

        }

        private void cancle_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("해당 좌석을 취소합니다");
            string seat_num = dataGridView1.SelectedRows[0].Cells[0].FormattedValue.ToString();
            string class_num = dataGridView1.SelectedRows[0].Cells[1].FormattedValue.ToString();


           
            this.reservedTableAdapter1.DeleteQuery(res_num,seat_num, class_num);
            
        }

        private void button2_Click(object sender, EventArgs e) //조회버튼
        {
            DataTable mytable3 = new DataTable();
            OracleDataReader rdr = book_info_Cmd.ExecuteReader();
            mytable3.Load(rdr);

            
            dataGridView1.DataSource =mytable3;
        }

        private void search_tran_btn_Click_1(object sender, EventArgs e)
        {
            source_txt = source_combobox.Text;
            arrive_txt = arrive_combobox.Text;
            MessageBox.Show(source_txt.ToString());
            MessageBox.Show(arrive_txt.ToString());


            if (seoul_radio.Checked == true && busan_radio.Checked == false) value = "서울행";
            else if (busan_radio.Checked == true && seoul_radio.Checked == false) value = "부산행";

            string date_value = dateTime_Search.Value.ToString("yyyy-MM-dd"); //날짜선택한 값 가져옴

            this.rOUTETableAdapter.Fill(dataSet1.ROUTE, source_txt, arrive_txt, date_value, value);

            newtable();
            dt_insert_coloum();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }


     
       
    }
}
