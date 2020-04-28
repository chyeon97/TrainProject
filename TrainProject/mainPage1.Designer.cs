namespace TrainProject
{
    partial class mainPage1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            Oracle.DataAccess.Client.OracleParameter oracleParameter1 = new Oracle.DataAccess.Client.OracleParameter();
            Oracle.DataAccess.Client.OracleParameter oracleParameter2 = new Oracle.DataAccess.Client.OracleParameter();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainPage1));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.arrive_combobox = new System.Windows.Forms.ComboBox();
            this.sTATIONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet12 = new TrainProject.DataSet1();
            this.sTATIONBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.source_combobox = new System.Windows.Forms.ComboBox();
            this.duration = new System.Windows.Forms.GroupBox();
            this.busan_radio = new System.Windows.Forms.RadioButton();
            this.seoul_radio = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.search_tran_btn = new System.Windows.Forms.Button();
            this.dateTime_Search = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.cancle_btn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.train_gridView = new System.Windows.Forms.DataGridView();
            this.tIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.a2AIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rSTATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.출발역DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.도착역DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rOUTEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new TrainProject.DataSet1();
            this.sTATIONTableAdapter = new TrainProject.DataSet1TableAdapters.STATIONTableAdapter();
            this.rOUTETableAdapter = new TrainProject.DataSet1TableAdapters.ROUTETableAdapter();
            this.dataSet11 = new TrainProject.DataSet1();
            this.book_info_Cmd = new Oracle.DataAccess.Client.OracleCommand();
            this.oracleConnection1 = new Oracle.DataAccess.Client.OracleConnection();
            this.my_booking_Cmd = new Oracle.DataAccess.Client.OracleCommand();
            this.reservedTableAdapter1 = new TrainProject.DataSet1TableAdapters.RESERVEDTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sTATIONBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTATIONBindingSource1)).BeginInit();
            this.duration.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.train_gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rOUTEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tabControl1);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Panel2.Controls.Add(this.pictureBox1);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.button1);
            this.splitContainer1.Panel2.Controls.Add(this.train_gridView);
            this.splitContainer1.Size = new System.Drawing.Size(1280, 500);
            this.splitContainer1.SplitterDistance = 517;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("돋움체", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tabControl1.Location = new System.Drawing.Point(21, 3);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(487, 488);
            this.tabControl1.TabIndex = 46;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(90)))), ((int)(((byte)(150)))));
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tabPage1.Controls.Add(this.arrive_combobox);
            this.tabPage1.Controls.Add(this.source_combobox);
            this.tabPage1.Controls.Add(this.duration);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.search_tran_btn);
            this.tabPage1.Controls.Add(this.dateTime_Search);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.ForeColor = System.Drawing.Color.Black;
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(479, 458);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "열차예약";
            // 
            // arrive_combobox
            // 
            this.arrive_combobox.BackColor = System.Drawing.SystemColors.MenuBar;
            this.arrive_combobox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.sTATIONBindingSource, "S_NAME", true));
            this.arrive_combobox.DataSource = this.sTATIONBindingSource1;
            this.arrive_combobox.DisplayMember = "S_NAME";
            this.arrive_combobox.Font = new System.Drawing.Font("돋움", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.arrive_combobox.FormattingEnabled = true;
            this.arrive_combobox.Location = new System.Drawing.Point(136, 227);
            this.arrive_combobox.Name = "arrive_combobox";
            this.arrive_combobox.Size = new System.Drawing.Size(216, 29);
            this.arrive_combobox.TabIndex = 61;
            this.arrive_combobox.ValueMember = "S_NAME";
            // 
            // sTATIONBindingSource
            // 
            this.sTATIONBindingSource.DataMember = "STATION";
            this.sTATIONBindingSource.DataSource = this.dataSet12;
            // 
            // dataSet12
            // 
            this.dataSet12.DataSetName = "DataSet1";
            this.dataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sTATIONBindingSource1
            // 
            this.sTATIONBindingSource1.DataMember = "STATION";
            this.sTATIONBindingSource1.DataSource = this.dataSet12;
            // 
            // source_combobox
            // 
            this.source_combobox.BackColor = System.Drawing.SystemColors.MenuBar;
            this.source_combobox.DataSource = this.sTATIONBindingSource;
            this.source_combobox.DisplayMember = "S_NAME";
            this.source_combobox.Font = new System.Drawing.Font("돋움", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.source_combobox.FormattingEnabled = true;
            this.source_combobox.Location = new System.Drawing.Point(136, 163);
            this.source_combobox.Name = "source_combobox";
            this.source_combobox.Size = new System.Drawing.Size(216, 29);
            this.source_combobox.TabIndex = 60;
            this.source_combobox.ValueMember = "S_NAME";
            // 
            // duration
            // 
            this.duration.Controls.Add(this.busan_radio);
            this.duration.Controls.Add(this.seoul_radio);
            this.duration.Location = new System.Drawing.Point(63, 43);
            this.duration.Name = "duration";
            this.duration.Size = new System.Drawing.Size(360, 85);
            this.duration.TabIndex = 59;
            this.duration.TabStop = false;
            // 
            // busan_radio
            // 
            this.busan_radio.AutoSize = true;
            this.busan_radio.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.busan_radio.ForeColor = System.Drawing.Color.White;
            this.busan_radio.Location = new System.Drawing.Point(204, 30);
            this.busan_radio.Name = "busan_radio";
            this.busan_radio.Size = new System.Drawing.Size(94, 34);
            this.busan_radio.TabIndex = 44;
            this.busan_radio.TabStop = true;
            this.busan_radio.Text = "부산행";
            this.busan_radio.UseVisualStyleBackColor = true;
            // 
            // seoul_radio
            // 
            this.seoul_radio.AutoSize = true;
            this.seoul_radio.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.seoul_radio.ForeColor = System.Drawing.Color.White;
            this.seoul_radio.Location = new System.Drawing.Point(57, 30);
            this.seoul_radio.Name = "seoul_radio";
            this.seoul_radio.Size = new System.Drawing.Size(94, 34);
            this.seoul_radio.TabIndex = 43;
            this.seoul_radio.TabStop = true;
            this.seoul_radio.Text = "서울행";
            this.seoul_radio.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(75, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 30);
            this.label3.TabIndex = 58;
            this.label3.Text = "도착";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(75, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 30);
            this.label2.TabIndex = 57;
            this.label2.Text = "출발";
            // 
            // search_tran_btn
            // 
            this.search_tran_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(49)))), ((int)(((byte)(50)))));
            this.search_tran_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.search_tran_btn.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.search_tran_btn.ForeColor = System.Drawing.Color.White;
            this.search_tran_btn.Location = new System.Drawing.Point(267, 357);
            this.search_tran_btn.Name = "search_tran_btn";
            this.search_tran_btn.Size = new System.Drawing.Size(168, 62);
            this.search_tran_btn.TabIndex = 56;
            this.search_tran_btn.Text = "열차조회";
            this.search_tran_btn.UseVisualStyleBackColor = false;
            this.search_tran_btn.Click += new System.EventHandler(this.search_tran_btn_Click_1);
            // 
            // dateTime_Search
            // 
            this.dateTime_Search.CalendarFont = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dateTime_Search.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dateTime_Search.Location = new System.Drawing.Point(136, 296);
            this.dateTime_Search.Name = "dateTime_Search";
            this.dateTime_Search.Size = new System.Drawing.Size(216, 29);
            this.dateTime_Search.TabIndex = 55;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(76, 292);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 30);
            this.label5.TabIndex = 54;
            this.label5.Text = "날짜";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(90)))), ((int)(((byte)(150)))));
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.cancle_btn);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(479, 458);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "예약조회";
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("돋움체", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button2.Location = new System.Drawing.Point(323, 260);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 41);
            this.button2.TabIndex = 44;
            this.button2.Text = "재확인";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cancle_btn
            // 
            this.cancle_btn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cancle_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancle_btn.Font = new System.Drawing.Font("돋움체", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cancle_btn.Location = new System.Drawing.Point(174, 260);
            this.cancle_btn.Name = "cancle_btn";
            this.cancle_btn.Size = new System.Drawing.Size(129, 41);
            this.cancle_btn.TabIndex = 43;
            this.cancle_btn.Text = "예약취소";
            this.cancle_btn.UseVisualStyleBackColor = false;
            this.cancle_btn.Click += new System.EventHandler(this.cancle_btn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 80);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(455, 168);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.train_gridView_CellMouseClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(49)))), ((int)(((byte)(50)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(582, 386);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 62);
            this.button1.TabIndex = 41;
            this.button1.Text = "좌석선택";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // train_gridView
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.train_gridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.train_gridView.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.train_gridView.AutoGenerateColumns = false;
            this.train_gridView.BackgroundColor = System.Drawing.Color.White;
            this.train_gridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.train_gridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tIDDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1,
            this.a2AIDDataGridViewTextBoxColumn,
            this.rSTATEDataGridViewTextBoxColumn,
            this.tDATEDataGridViewTextBoxColumn,
            this.출발역DataGridViewTextBoxColumn,
            this.도착역DataGridViewTextBoxColumn});
            this.train_gridView.DataSource = this.rOUTEBindingSource;
            this.train_gridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.train_gridView.Location = new System.Drawing.Point(45, 111);
            this.train_gridView.Margin = new System.Windows.Forms.Padding(23, 22, 23, 22);
            this.train_gridView.MultiSelect = false;
            this.train_gridView.Name = "train_gridView";
            this.train_gridView.RowHeadersVisible = false;
            this.train_gridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.train_gridView.RowTemplate.Height = 23;
            this.train_gridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.train_gridView.Size = new System.Drawing.Size(703, 221);
            this.train_gridView.TabIndex = 0;
            this.train_gridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.train_gridView_CellMouseClick);
            // 
            // tIDDataGridViewTextBoxColumn
            // 
            this.tIDDataGridViewTextBoxColumn.DataPropertyName = "T_ID";
            this.tIDDataGridViewTextBoxColumn.HeaderText = "열차번호";
            this.tIDDataGridViewTextBoxColumn.Name = "tIDDataGridViewTextBoxColumn";
            this.tIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "SOURCE_S_ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "출발역번호";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // a2AIDDataGridViewTextBoxColumn
            // 
            this.a2AIDDataGridViewTextBoxColumn.DataPropertyName = "A2_A_ID";
            this.a2AIDDataGridViewTextBoxColumn.HeaderText = "도착역번호";
            this.a2AIDDataGridViewTextBoxColumn.Name = "a2AIDDataGridViewTextBoxColumn";
            this.a2AIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rSTATEDataGridViewTextBoxColumn
            // 
            this.rSTATEDataGridViewTextBoxColumn.DataPropertyName = "R_STATE";
            this.rSTATEDataGridViewTextBoxColumn.HeaderText = "상태";
            this.rSTATEDataGridViewTextBoxColumn.Name = "rSTATEDataGridViewTextBoxColumn";
            this.rSTATEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tDATEDataGridViewTextBoxColumn
            // 
            this.tDATEDataGridViewTextBoxColumn.DataPropertyName = "T_DATE";
            this.tDATEDataGridViewTextBoxColumn.HeaderText = "날짜";
            this.tDATEDataGridViewTextBoxColumn.Name = "tDATEDataGridViewTextBoxColumn";
            this.tDATEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 출발역DataGridViewTextBoxColumn
            // 
            this.출발역DataGridViewTextBoxColumn.DataPropertyName = "출발역";
            this.출발역DataGridViewTextBoxColumn.HeaderText = "출발역";
            this.출발역DataGridViewTextBoxColumn.Name = "출발역DataGridViewTextBoxColumn";
            this.출발역DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 도착역DataGridViewTextBoxColumn
            // 
            this.도착역DataGridViewTextBoxColumn.DataPropertyName = "도착역";
            this.도착역DataGridViewTextBoxColumn.HeaderText = "도착역";
            this.도착역DataGridViewTextBoxColumn.Name = "도착역DataGridViewTextBoxColumn";
            this.도착역DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rOUTEBindingSource
            // 
            this.rOUTEBindingSource.DataMember = "ROUTE";
            this.rOUTEBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sTATIONTableAdapter
            // 
            this.sTATIONTableAdapter.ClearBeforeFill = true;
            // 
            // rOUTETableAdapter
            // 
            this.rOUTETableAdapter.ClearBeforeFill = true;
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // book_info_Cmd
            // 
            this.book_info_Cmd.Connection = this.oracleConnection1;
            oracleParameter1.OracleDbType = Oracle.DataAccess.Client.OracleDbType.Decimal;
            oracleParameter1.ParameterName = "RES_NUM";
            this.book_info_Cmd.Parameters.Add(oracleParameter1);
            this.book_info_Cmd.Transaction = null;
            // 
            // oracleConnection1
            // 
            this.oracleConnection1.ConnectionString = "DATA SOURCE=chaeyeon;USER ID=A5414290;PASSWORD=A5414290";
            // 
            // my_booking_Cmd
            // 
            this.my_booking_Cmd.Connection = this.oracleConnection1;
            oracleParameter2.OracleDbType = Oracle.DataAccess.Client.OracleDbType.Varchar2;
            oracleParameter2.ParameterName = "M_ID";
            this.my_booking_Cmd.Parameters.Add(oracleParameter2);
            this.my_booking_Cmd.Transaction = null;
            // 
            // reservedTableAdapter1
            // 
            this.reservedTableAdapter1.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(54, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 47);
            this.label1.TabIndex = 42;
            this.label1.Text = "열차시간표";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(6, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 32);
            this.label4.TabIndex = 45;
            this.label4.Text = "나의 예약현황";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(732, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 28);
            this.pictureBox1.TabIndex = 43;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // mainPage1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(1280, 500);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "mainPage1";
            this.Text = "열차조회";
            this.Load += new System.EventHandler(this.mainPage1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sTATIONBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTATIONBindingSource1)).EndInit();
            this.duration.ResumeLayout(false);
            this.duration.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.train_gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rOUTEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
       // private System.Windows.Forms.DataGridViewTextBoxColumn sTATUSDataGridViewTextBoxColumn;
        // private System.Windows.Forms.DataGridViewTextBoxColumn tDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eXPR1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tSTATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eXPR2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wAITTIMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sOURCESIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aRRIVESIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn eXPR3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eXPR4DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eXPR5DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eXPR6DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eXPR7DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn eXPR8DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eXPR9DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eXPR10DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tSTARTTIMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView train_gridView;
        private System.Windows.Forms.BindingSource sTATIONBindingSource;
        private DataSet1 dataSet12;
        private DataSet1TableAdapters.STATIONTableAdapter sTATIONTableAdapter;
        private System.Windows.Forms.BindingSource sTATIONBindingSource1;
        private System.Windows.Forms.BindingSource rOUTEBindingSource;
        private DataSet1 dataSet1;
        private DataSet1TableAdapters.ROUTETableAdapter rOUTETableAdapter;
        private DataSet1 dataSet11;
        private System.Windows.Forms.DataGridViewTextBoxColumn tIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn a2AIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rSTATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 출발역DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 도착역DataGridViewTextBoxColumn;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private Oracle.DataAccess.Client.OracleCommand book_info_Cmd;
        private Oracle.DataAccess.Client.OracleConnection oracleConnection1;
        private Oracle.DataAccess.Client.OracleCommand my_booking_Cmd;
        private System.Windows.Forms.ComboBox arrive_combobox;
        private System.Windows.Forms.ComboBox source_combobox;
        private System.Windows.Forms.GroupBox duration;
        private System.Windows.Forms.RadioButton busan_radio;
        private System.Windows.Forms.RadioButton seoul_radio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button search_tran_btn;
        private System.Windows.Forms.DateTimePicker dateTime_Search;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button cancle_btn;
        private DataSet1TableAdapters.RESERVEDTableAdapter reservedTableAdapter1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
      //  private System.Windows.Forms.DataGridViewTextBoxColumn sOURCESIDDataGridViewTextBoxColumn;
       // private System.Windows.Forms.DataGridViewTextBoxColumn rUNTIMEDataGridViewTextBoxColumn;
       // private System.Windows.Forms.DataGridViewTextBoxColumn rSTATEDataGridViewTextBoxColumn;
       // private System.Windows.Forms.DataGridViewTextBoxColumn aRRIVESIDDataGridViewTextBoxColumn;
      //  private System.Windows.Forms.DataGridViewTextBoxColumn sOURCENAMEDataGridViewTextBoxColumn;
      //  private System.Windows.Forms.DataGridViewTextBoxColumn aRRIVENAMEDataGridViewTextBoxColumn;




    }
}