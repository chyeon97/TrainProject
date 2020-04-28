namespace TrainProject
{
    partial class usermainpage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Oracle.DataAccess.Client.OracleParameter oracleParameter1 = new Oracle.DataAccess.Client.OracleParameter();
            Oracle.DataAccess.Client.OracleParameter oracleParameter2 = new Oracle.DataAccess.Client.OracleParameter();
            Oracle.DataAccess.Client.OracleParameter oracleParameter3 = new Oracle.DataAccess.Client.OracleParameter();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(usermainpage));
            this.trainInsert_Cmd = new Oracle.DataAccess.Client.OracleCommand();
            this.oracleConnection1 = new Oracle.DataAccess.Client.OracleConnection();
            this.routeInfo_Cmd = new Oracle.DataAccess.Client.OracleCommand();
            this.station_Cmd = new Oracle.DataAccess.Client.OracleCommand();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.tIDDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tSTATEDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLASSNUMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sEATNUMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sEATBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new TrainProject.DataSet1();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.sOURCESIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fEEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rUNTIMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aRRIVESIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tDATEDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tRAINSTARTTIMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tRAINARRIVETIMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rSTATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rOUTE1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button3 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.fee_txtbox = new System.Windows.Forms.TextBox();
            this.init_time_txtbox = new System.Windows.Forms.TextBox();
            this.trainState_txtbox = new System.Windows.Forms.TextBox();
            this.trainNum_txtbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tSTATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tRAINBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.train_num_txtbox = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.sTARTSIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aRRIVESIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rUNTIMEDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.START_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ARRIVE_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rOUTEINFOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.sIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wAITTIMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTATIONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.trainTableAdapter1 = new TrainProject.DataSet1TableAdapters.TRAINTableAdapter();
            this.stationTableAdapter1 = new TrainProject.DataSet1TableAdapters.STATIONTableAdapter();
            this.routE1TableAdapter1 = new TrainProject.DataSet1TableAdapters.ROUTE1TableAdapter();
            this.seatTableAdapter1 = new TrainProject.DataSet1TableAdapters.SEATTableAdapter();
            this.rOUTE_INFOTableAdapter = new TrainProject.DataSet1TableAdapters.ROUTE_INFOTableAdapter();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sEATBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rOUTE1BindingSource)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRAINBindingSource)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rOUTEINFOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTATIONBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // trainInsert_Cmd
            // 
            this.trainInsert_Cmd.Connection = this.oracleConnection1;
            oracleParameter1.OracleDbType = Oracle.DataAccess.Client.OracleDbType.Varchar2;
            oracleParameter1.ParameterName = "T_ID";
            oracleParameter2.OracleDbType = Oracle.DataAccess.Client.OracleDbType.Varchar2;
            oracleParameter2.ParameterName = "T_STATE";
            oracleParameter3.OracleDbType = Oracle.DataAccess.Client.OracleDbType.Varchar2;
            oracleParameter3.ParameterName = "T_DATE";
            this.trainInsert_Cmd.Parameters.Add(oracleParameter1);
            this.trainInsert_Cmd.Parameters.Add(oracleParameter2);
            this.trainInsert_Cmd.Parameters.Add(oracleParameter3);
            this.trainInsert_Cmd.Transaction = null;
            // 
            // oracleConnection1
            // 
            this.oracleConnection1.ConnectionString = "DATA SOURCE=chaeyeon;USER ID=A5414290;PASSWORD=A5414290";
            // 
            // routeInfo_Cmd
            // 
            this.routeInfo_Cmd.CommandText = "SELECT RUNTIME FROM ROUTE_INFO";
            this.routeInfo_Cmd.Connection = this.oracleConnection1;
            this.routeInfo_Cmd.Transaction = null;
            // 
            // station_Cmd
            // 
            this.station_Cmd.CommandText = "SELECT S_ID FROM STATION WHERE S_ID>0";
            this.station_Cmd.Connection = this.oracleConnection1;
            this.station_Cmd.Transaction = null;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Beige;
            this.tabPage3.Controls.Add(this.dataGridView3);
            this.tabPage3.Controls.Add(this.button4);
            this.tabPage3.Controls.Add(this.textBox2);
            this.tabPage3.Controls.Add(this.textBox1);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Location = new System.Drawing.Point(4, 26);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1002, 453);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "좌석";
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tIDDataGridViewTextBoxColumn2,
            this.tSTATEDataGridViewTextBoxColumn1,
            this.cLASSNUMDataGridViewTextBoxColumn,
            this.sEATNUMDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.sEATBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(484, 82);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowTemplate.Height = 23;
            this.dataGridView3.Size = new System.Drawing.Size(448, 271);
            this.dataGridView3.TabIndex = 12;
            // 
            // tIDDataGridViewTextBoxColumn2
            // 
            this.tIDDataGridViewTextBoxColumn2.DataPropertyName = "T_ID";
            this.tIDDataGridViewTextBoxColumn2.HeaderText = "열차번호";
            this.tIDDataGridViewTextBoxColumn2.Name = "tIDDataGridViewTextBoxColumn2";
            // 
            // tSTATEDataGridViewTextBoxColumn1
            // 
            this.tSTATEDataGridViewTextBoxColumn1.DataPropertyName = "T_STATE";
            this.tSTATEDataGridViewTextBoxColumn1.HeaderText = "방향";
            this.tSTATEDataGridViewTextBoxColumn1.Name = "tSTATEDataGridViewTextBoxColumn1";
            // 
            // cLASSNUMDataGridViewTextBoxColumn
            // 
            this.cLASSNUMDataGridViewTextBoxColumn.DataPropertyName = "CLASS_NUM";
            this.cLASSNUMDataGridViewTextBoxColumn.HeaderText = "호차번호";
            this.cLASSNUMDataGridViewTextBoxColumn.Name = "cLASSNUMDataGridViewTextBoxColumn";
            // 
            // sEATNUMDataGridViewTextBoxColumn
            // 
            this.sEATNUMDataGridViewTextBoxColumn.DataPropertyName = "SEAT_NUM";
            this.sEATNUMDataGridViewTextBoxColumn.HeaderText = "좌석번호";
            this.sEATNUMDataGridViewTextBoxColumn.Name = "sEATNUMDataGridViewTextBoxColumn";
            // 
            // sEATBindingSource
            // 
            this.sEATBindingSource.DataMember = "SEAT";
            this.sEATBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(106, 284);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(174, 51);
            this.button4.TabIndex = 11;
            this.button4.Text = "자리생성";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("돋움체", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox2.Location = new System.Drawing.Point(182, 192);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(98, 29);
            this.textBox2.TabIndex = 7;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("돋움체", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox1.Location = new System.Drawing.Point(182, 105);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(98, 29);
            this.textBox1.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.Location = new System.Drawing.Point(126, 191);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 25);
            this.label9.TabIndex = 6;
            this.label9.Text = "방향";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(88, 106);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 25);
            this.label8.TabIndex = 5;
            this.label8.Text = "열차번호";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Beige;
            this.tabPage2.Controls.Add(this.pictureBox3);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.fee_txtbox);
            this.tabPage2.Controls.Add(this.init_time_txtbox);
            this.tabPage2.Controls.Add(this.trainState_txtbox);
            this.tabPage2.Controls.Add(this.trainNum_txtbox);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Font = new System.Drawing.Font("돋움", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1002, 453);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "경로";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(963, 419);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(33, 28);
            this.pictureBox3.TabIndex = 30;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sOURCESIDDataGridViewTextBoxColumn,
            this.tIDDataGridViewTextBoxColumn1,
            this.fEEDataGridViewTextBoxColumn,
            this.rUNTIMEDataGridViewTextBoxColumn,
            this.aRRIVESIDDataGridViewTextBoxColumn,
            this.tDATEDataGridViewTextBoxColumn1,
            this.tRAINSTARTTIMEDataGridViewTextBoxColumn,
            this.tRAINARRIVETIMEDataGridViewTextBoxColumn,
            this.rSTATEDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.rOUTE1BindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(24, 125);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 23;
            this.dataGridView2.Size = new System.Drawing.Size(950, 264);
            this.dataGridView2.TabIndex = 11;
            // 
            // sOURCESIDDataGridViewTextBoxColumn
            // 
            this.sOURCESIDDataGridViewTextBoxColumn.DataPropertyName = "SOURCE_S_ID";
            this.sOURCESIDDataGridViewTextBoxColumn.HeaderText = "출발역번호";
            this.sOURCESIDDataGridViewTextBoxColumn.Name = "sOURCESIDDataGridViewTextBoxColumn";
            // 
            // tIDDataGridViewTextBoxColumn1
            // 
            this.tIDDataGridViewTextBoxColumn1.DataPropertyName = "T_ID";
            this.tIDDataGridViewTextBoxColumn1.HeaderText = "열차번호";
            this.tIDDataGridViewTextBoxColumn1.Name = "tIDDataGridViewTextBoxColumn1";
            // 
            // fEEDataGridViewTextBoxColumn
            // 
            this.fEEDataGridViewTextBoxColumn.DataPropertyName = "FEE";
            this.fEEDataGridViewTextBoxColumn.HeaderText = "요금";
            this.fEEDataGridViewTextBoxColumn.Name = "fEEDataGridViewTextBoxColumn";
            // 
            // rUNTIMEDataGridViewTextBoxColumn
            // 
            this.rUNTIMEDataGridViewTextBoxColumn.DataPropertyName = "RUN_TIME";
            this.rUNTIMEDataGridViewTextBoxColumn.HeaderText = "운행시간";
            this.rUNTIMEDataGridViewTextBoxColumn.Name = "rUNTIMEDataGridViewTextBoxColumn";
            // 
            // aRRIVESIDDataGridViewTextBoxColumn
            // 
            this.aRRIVESIDDataGridViewTextBoxColumn.DataPropertyName = "ARRIVE_S_ID";
            this.aRRIVESIDDataGridViewTextBoxColumn.HeaderText = "도착역번호";
            this.aRRIVESIDDataGridViewTextBoxColumn.Name = "aRRIVESIDDataGridViewTextBoxColumn";
            // 
            // tDATEDataGridViewTextBoxColumn1
            // 
            this.tDATEDataGridViewTextBoxColumn1.DataPropertyName = "T_DATE";
            this.tDATEDataGridViewTextBoxColumn1.HeaderText = "운행날짜";
            this.tDATEDataGridViewTextBoxColumn1.Name = "tDATEDataGridViewTextBoxColumn1";
            // 
            // tRAINSTARTTIMEDataGridViewTextBoxColumn
            // 
            this.tRAINSTARTTIMEDataGridViewTextBoxColumn.DataPropertyName = "TRAIN_START_TIME";
            this.tRAINSTARTTIMEDataGridViewTextBoxColumn.HeaderText = "출발시간";
            this.tRAINSTARTTIMEDataGridViewTextBoxColumn.Name = "tRAINSTARTTIMEDataGridViewTextBoxColumn";
            // 
            // tRAINARRIVETIMEDataGridViewTextBoxColumn
            // 
            this.tRAINARRIVETIMEDataGridViewTextBoxColumn.DataPropertyName = "TRAIN_ARRIVE_TIME";
            this.tRAINARRIVETIMEDataGridViewTextBoxColumn.HeaderText = "도착시간";
            this.tRAINARRIVETIMEDataGridViewTextBoxColumn.Name = "tRAINARRIVETIMEDataGridViewTextBoxColumn";
            // 
            // rSTATEDataGridViewTextBoxColumn
            // 
            this.rSTATEDataGridViewTextBoxColumn.DataPropertyName = "R_STATE";
            this.rSTATEDataGridViewTextBoxColumn.HeaderText = "방향";
            this.rSTATEDataGridViewTextBoxColumn.Name = "rSTATEDataGridViewTextBoxColumn";
            // 
            // rOUTE1BindingSource
            // 
            this.rOUTE1BindingSource.DataMember = "ROUTE1";
            this.rOUTE1BindingSource.DataSource = this.dataSet1;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(496, 26);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(137, 74);
            this.button3.TabIndex = 10;
            this.button3.Text = "경로생성";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(238, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 25);
            this.label7.TabIndex = 9;
            this.label7.Text = "구간별 요금";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // fee_txtbox
            // 
            this.fee_txtbox.Font = new System.Drawing.Font("돋움체", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.fee_txtbox.Location = new System.Drawing.Point(358, 72);
            this.fee_txtbox.Name = "fee_txtbox";
            this.fee_txtbox.Size = new System.Drawing.Size(100, 29);
            this.fee_txtbox.TabIndex = 8;
            // 
            // init_time_txtbox
            // 
            this.init_time_txtbox.Font = new System.Drawing.Font("돋움체", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.init_time_txtbox.Location = new System.Drawing.Point(358, 23);
            this.init_time_txtbox.Name = "init_time_txtbox";
            this.init_time_txtbox.Size = new System.Drawing.Size(100, 29);
            this.init_time_txtbox.TabIndex = 6;
            // 
            // trainState_txtbox
            // 
            this.trainState_txtbox.Font = new System.Drawing.Font("돋움체", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.trainState_txtbox.Location = new System.Drawing.Point(110, 76);
            this.trainState_txtbox.Name = "trainState_txtbox";
            this.trainState_txtbox.ReadOnly = true;
            this.trainState_txtbox.Size = new System.Drawing.Size(98, 29);
            this.trainState_txtbox.TabIndex = 5;
            // 
            // trainNum_txtbox
            // 
            this.trainNum_txtbox.Font = new System.Drawing.Font("돋움체", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.trainNum_txtbox.Location = new System.Drawing.Point(110, 26);
            this.trainNum_txtbox.Name = "trainNum_txtbox";
            this.trainNum_txtbox.ReadOnly = true;
            this.trainNum_txtbox.Size = new System.Drawing.Size(98, 29);
            this.trainNum_txtbox.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(257, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 25);
            this.label6.TabIndex = 7;
            this.label6.Text = "출발시간";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(45, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "방향";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(16, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "열차번호";
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Beige;
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.dateTimePicker1);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.comboBox1);
            this.tabPage1.Controls.Add(this.train_num_txtbox);
            this.tabPage1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1002, 453);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "열차";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(946, 396);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 28);
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tIDDataGridViewTextBoxColumn,
            this.tSTATEDataGridViewTextBoxColumn,
            this.tDATEDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tRAINBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(582, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(345, 326);
            this.dataGridView1.TabIndex = 8;
            // 
            // tIDDataGridViewTextBoxColumn
            // 
            this.tIDDataGridViewTextBoxColumn.DataPropertyName = "T_ID";
            this.tIDDataGridViewTextBoxColumn.HeaderText = "열차번호";
            this.tIDDataGridViewTextBoxColumn.Name = "tIDDataGridViewTextBoxColumn";
            // 
            // tSTATEDataGridViewTextBoxColumn
            // 
            this.tSTATEDataGridViewTextBoxColumn.DataPropertyName = "T_STATE";
            this.tSTATEDataGridViewTextBoxColumn.HeaderText = "방향";
            this.tSTATEDataGridViewTextBoxColumn.Name = "tSTATEDataGridViewTextBoxColumn";
            // 
            // tDATEDataGridViewTextBoxColumn
            // 
            this.tDATEDataGridViewTextBoxColumn.DataPropertyName = "T_DATE";
            this.tDATEDataGridViewTextBoxColumn.HeaderText = "운행날짜";
            this.tDATEDataGridViewTextBoxColumn.Name = "tDATEDataGridViewTextBoxColumn";
            // 
            // tRAINBindingSource
            // 
            this.tRAINBindingSource.DataMember = "TRAIN";
            this.tRAINBindingSource.DataSource = this.dataSet1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(158, 280);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 60);
            this.button1.TabIndex = 7;
            this.button1.Text = "열차생성";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dateTimePicker1.Location = new System.Drawing.Point(157, 208);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(170, 33);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(49, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "운행날짜";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(81, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "방향";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(63, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "열차번호";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "서울행",
            "부산행"});
            this.comboBox1.Location = new System.Drawing.Point(157, 151);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(170, 33);
            this.comboBox1.TabIndex = 1;
            // 
            // train_num_txtbox
            // 
            this.train_num_txtbox.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.train_num_txtbox.Location = new System.Drawing.Point(158, 87);
            this.train_num_txtbox.Name = "train_num_txtbox";
            this.train_num_txtbox.Size = new System.Drawing.Size(169, 33);
            this.train_num_txtbox.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Font = new System.Drawing.Font("돋움", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tabControl1.Location = new System.Drawing.Point(35, 47);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1010, 483);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.Beige;
            this.tabPage4.Controls.Add(this.button9);
            this.tabPage4.Controls.Add(this.button8);
            this.tabPage4.Controls.Add(this.button7);
            this.tabPage4.Controls.Add(this.dataGridView5);
            this.tabPage4.Controls.Add(this.button6);
            this.tabPage4.Controls.Add(this.button5);
            this.tabPage4.Controls.Add(this.button2);
            this.tabPage4.Controls.Add(this.dataGridView4);
            this.tabPage4.Font = new System.Drawing.Font("돋움", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tabPage4.Location = new System.Drawing.Point(4, 26);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1002, 453);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "역관리";
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button9.ForeColor = System.Drawing.Color.White;
            this.button9.Location = new System.Drawing.Point(649, 350);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(160, 58);
            this.button9.TabIndex = 23;
            this.button9.Text = "운행시간추가";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.Location = new System.Drawing.Point(463, 350);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(156, 58);
            this.button8.TabIndex = 22;
            this.button8.Text = "구간운행시간";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Location = new System.Drawing.Point(867, 350);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(93, 58);
            this.button7.TabIndex = 21;
            this.button7.Text = "완료";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // dataGridView5
            // 
            this.dataGridView5.AutoGenerateColumns = false;
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView5.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sTARTSIDDataGridViewTextBoxColumn,
            this.aRRIVESIDDataGridViewTextBoxColumn1,
            this.rUNTIMEDataGridViewTextBoxColumn1,
            this.START_NAME,
            this.ARRIVE_NAME});
            this.dataGridView5.DataSource = this.rOUTEINFOBindingSource;
            this.dataGridView5.Location = new System.Drawing.Point(447, 43);
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.RowTemplate.Height = 23;
            this.dataGridView5.Size = new System.Drawing.Size(537, 287);
            this.dataGridView5.TabIndex = 20;
            // 
            // sTARTSIDDataGridViewTextBoxColumn
            // 
            this.sTARTSIDDataGridViewTextBoxColumn.DataPropertyName = "START_S_ID";
            this.sTARTSIDDataGridViewTextBoxColumn.HeaderText = "출발역번호";
            this.sTARTSIDDataGridViewTextBoxColumn.Name = "sTARTSIDDataGridViewTextBoxColumn";
            // 
            // aRRIVESIDDataGridViewTextBoxColumn1
            // 
            this.aRRIVESIDDataGridViewTextBoxColumn1.DataPropertyName = "ARRIVE_S_ID";
            this.aRRIVESIDDataGridViewTextBoxColumn1.HeaderText = "도착역번호";
            this.aRRIVESIDDataGridViewTextBoxColumn1.Name = "aRRIVESIDDataGridViewTextBoxColumn1";
            // 
            // rUNTIMEDataGridViewTextBoxColumn1
            // 
            this.rUNTIMEDataGridViewTextBoxColumn1.DataPropertyName = "RUNTIME";
            this.rUNTIMEDataGridViewTextBoxColumn1.HeaderText = "운행시간";
            this.rUNTIMEDataGridViewTextBoxColumn1.Name = "rUNTIMEDataGridViewTextBoxColumn1";
            // 
            // START_NAME
            // 
            this.START_NAME.DataPropertyName = "START_NAME";
            this.START_NAME.HeaderText = "출발역";
            this.START_NAME.Name = "START_NAME";
            // 
            // ARRIVE_NAME
            // 
            this.ARRIVE_NAME.DataPropertyName = "ARRIVE_NAME";
            this.ARRIVE_NAME.HeaderText = "도착역";
            this.ARRIVE_NAME.Name = "ARRIVE_NAME";
            // 
            // rOUTEINFOBindingSource
            // 
            this.rOUTEINFOBindingSource.DataMember = "ROUTE_INFO";
            this.rOUTEINFOBindingSource.DataSource = this.dataSet1;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(292, 350);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(93, 58);
            this.button6.TabIndex = 19;
            this.button6.Text = "완료";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(164, 350);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(93, 58);
            this.button5.TabIndex = 18;
            this.button5.Text = "역추가";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(57, 350);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 58);
            this.button2.TabIndex = 17;
            this.button2.Text = "역조회";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView4
            // 
            this.dataGridView4.AutoGenerateColumns = false;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sIDDataGridViewTextBoxColumn,
            this.sNAMEDataGridViewTextBoxColumn,
            this.wAITTIMEDataGridViewTextBoxColumn});
            this.dataGridView4.DataSource = this.sTATIONBindingSource;
            this.dataGridView4.Location = new System.Drawing.Point(57, 33);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.RowTemplate.Height = 23;
            this.dataGridView4.Size = new System.Drawing.Size(343, 287);
            this.dataGridView4.TabIndex = 16;
            // 
            // sIDDataGridViewTextBoxColumn
            // 
            this.sIDDataGridViewTextBoxColumn.DataPropertyName = "S_ID";
            this.sIDDataGridViewTextBoxColumn.HeaderText = "역번호";
            this.sIDDataGridViewTextBoxColumn.Name = "sIDDataGridViewTextBoxColumn";
            // 
            // sNAMEDataGridViewTextBoxColumn
            // 
            this.sNAMEDataGridViewTextBoxColumn.DataPropertyName = "S_NAME";
            this.sNAMEDataGridViewTextBoxColumn.HeaderText = "역이름";
            this.sNAMEDataGridViewTextBoxColumn.Name = "sNAMEDataGridViewTextBoxColumn";
            // 
            // wAITTIMEDataGridViewTextBoxColumn
            // 
            this.wAITTIMEDataGridViewTextBoxColumn.DataPropertyName = "WAIT_TIME";
            this.wAITTIMEDataGridViewTextBoxColumn.HeaderText = "정차시간";
            this.wAITTIMEDataGridViewTextBoxColumn.Name = "wAITTIMEDataGridViewTextBoxColumn";
            // 
            // sTATIONBindingSource
            // 
            this.sTATIONBindingSource.DataMember = "STATION";
            this.sTATIONBindingSource.DataSource = this.dataSet1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(29, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(135, 32);
            this.label10.TabIndex = 17;
            this.label10.Text = "관리자모드";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1023, 9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(31, 32);
            this.pictureBox2.TabIndex = 30;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // trainTableAdapter1
            // 
            this.trainTableAdapter1.ClearBeforeFill = true;
            // 
            // stationTableAdapter1
            // 
            this.stationTableAdapter1.ClearBeforeFill = true;
            // 
            // routE1TableAdapter1
            // 
            this.routE1TableAdapter1.ClearBeforeFill = true;
            // 
            // seatTableAdapter1
            // 
            this.seatTableAdapter1.ClearBeforeFill = true;
            // 
            // rOUTE_INFOTableAdapter
            // 
            this.rOUTE_INFOTableAdapter.ClearBeforeFill = true;
            // 
            // usermainpage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.ClientSize = new System.Drawing.Size(1066, 561);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "usermainpage";
            this.Text = "usermainpage";
            this.Load += new System.EventHandler(this.usermainpage_Load);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sEATBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rOUTE1BindingSource)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRAINBindingSource)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rOUTEINFOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTATIONBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Oracle.DataAccess.Client.OracleCommand trainInsert_Cmd;
        private Oracle.DataAccess.Client.OracleConnection oracleConnection1;
        private DataSet1TableAdapters.TRAINTableAdapter trainTableAdapter1;
        private DataSet1 dataSet1;
        private Oracle.DataAccess.Client.OracleCommand routeInfo_Cmd;
        private DataSet1TableAdapters.STATIONTableAdapter stationTableAdapter1;
        private Oracle.DataAccess.Client.OracleCommand station_Cmd;
        private System.Windows.Forms.BindingSource tRAINBindingSource;
        private System.Windows.Forms.BindingSource rOUTE1BindingSource;
        private System.Windows.Forms.BindingSource sEATBindingSource;
        private DataSet1TableAdapters.ROUTE1TableAdapter routE1TableAdapter1;
        private DataSet1TableAdapters.SEATTableAdapter seatTableAdapter1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn sOURCESIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fEEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rUNTIMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aRRIVESIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tDATEDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tRAINSTARTTIMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tRAINARRIVETIMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rSTATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox fee_txtbox;
        private System.Windows.Forms.TextBox init_time_txtbox;
        private System.Windows.Forms.TextBox trainState_txtbox;
        private System.Windows.Forms.TextBox trainNum_txtbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tSTATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox train_num_txtbox;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.DataGridViewTextBoxColumn tIDDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn tSTATEDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLASSNUMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sEATNUMDataGridViewTextBoxColumn;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.BindingSource sTATIONBindingSource;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.DataGridView dataGridView5;
        private System.Windows.Forms.BindingSource rOUTEINFOBindingSource;
        private DataSet1TableAdapters.ROUTE_INFOTableAdapter rOUTE_INFOTableAdapter;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.DataGridViewTextBoxColumn sIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wAITTIMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTARTSIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aRRIVESIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn rUNTIMEDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn START_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn ARRIVE_NAME;

    }
}