namespace TrainProject
{
    partial class book
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
            Oracle.DataAccess.Client.OracleParameter oracleParameter9 = new Oracle.DataAccess.Client.OracleParameter();
            Oracle.DataAccess.Client.OracleParameter oracleParameter10 = new Oracle.DataAccess.Client.OracleParameter();
            Oracle.DataAccess.Client.OracleParameter oracleParameter1 = new Oracle.DataAccess.Client.OracleParameter();
            Oracle.DataAccess.Client.OracleParameter oracleParameter2 = new Oracle.DataAccess.Client.OracleParameter();
            Oracle.DataAccess.Client.OracleParameter oracleParameter11 = new Oracle.DataAccess.Client.OracleParameter();
            Oracle.DataAccess.Client.OracleParameter oracleParameter12 = new Oracle.DataAccess.Client.OracleParameter();
            Oracle.DataAccess.Client.OracleParameter oracleParameter3 = new Oracle.DataAccess.Client.OracleParameter();
            Oracle.DataAccess.Client.OracleParameter oracleParameter4 = new Oracle.DataAccess.Client.OracleParameter();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(book));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.ok_btn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.reservation = new System.Windows.Forms.Button();
            this.room2 = new System.Windows.Forms.GroupBox();
            this.num_4 = new System.Windows.Forms.CheckBox();
            this.num_3 = new System.Windows.Forms.CheckBox();
            this.num_2 = new System.Windows.Forms.CheckBox();
            this.num_1 = new System.Windows.Forms.CheckBox();
            this.room1 = new System.Windows.Forms.GroupBox();
            this.num4 = new System.Windows.Forms.CheckBox();
            this.num2 = new System.Windows.Forms.CheckBox();
            this.num3 = new System.Windows.Forms.CheckBox();
            this.num1 = new System.Windows.Forms.CheckBox();
            this.nonReserveSeat_Cmd = new Oracle.DataAccess.Client.OracleCommand();
            this.oracleConnection1 = new Oracle.DataAccess.Client.OracleConnection();
            this.Reserved_Cmd = new Oracle.DataAccess.Client.OracleCommand();
            this.dataSet11 = new TrainProject.DataSet1();
            this.reservationTableAdapter1 = new TrainProject.DataSet1TableAdapters.RESERVATIONTableAdapter();
            this.Insert = new Oracle.DataAccess.Client.OracleCommand();
            this.INSERT_resNum_Cmd = new Oracle.DataAccess.Client.OracleCommand();
            this.memberTableAdapter1 = new TrainProject.DataSet1TableAdapters.MEMBERTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.room2.SuspendLayout();
            this.room1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.ok_btn);
            this.splitContainer1.Panel1.Controls.Add(this.textBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Panel2.Controls.Add(this.reservation);
            this.splitContainer1.Panel2.Controls.Add(this.room2);
            this.splitContainer1.Panel2.Controls.Add(this.room1);
            this.splitContainer1.Size = new System.Drawing.Size(1173, 571);
            this.splitContainer1.SplitterDistance = 115;
            this.splitContainer1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(18, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 32);
            this.label1.TabIndex = 16;
            this.label1.Text = "열차번호";
            // 
            // ok_btn
            // 
            this.ok_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(49)))), ((int)(((byte)(50)))));
            this.ok_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ok_btn.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ok_btn.ForeColor = System.Drawing.Color.White;
            this.ok_btn.Location = new System.Drawing.Point(991, 36);
            this.ok_btn.Name = "ok_btn";
            this.ok_btn.Size = new System.Drawing.Size(145, 59);
            this.ok_btn.TabIndex = 15;
            this.ok_btn.Text = "좌석조회";
            this.ok_btn.UseVisualStyleBackColor = false;
            this.ok_btn.Click += new System.EventHandler(this.ok_btn_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.textBox1.Font = new System.Drawing.Font("돋움체", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(135, 51);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(118, 35);
            this.textBox1.TabIndex = 12;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(193, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(788, 150);
            this.dataGridView1.TabIndex = 11;
            // 
            // reservation
            // 
            this.reservation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(49)))), ((int)(((byte)(50)))));
            this.reservation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reservation.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.reservation.ForeColor = System.Drawing.Color.White;
            this.reservation.Location = new System.Drawing.Point(1013, 364);
            this.reservation.Name = "reservation";
            this.reservation.Size = new System.Drawing.Size(123, 63);
            this.reservation.TabIndex = 10;
            this.reservation.Text = "예약";
            this.reservation.UseVisualStyleBackColor = false;
            this.reservation.Click += new System.EventHandler(this.reservation_Click);
            // 
            // room2
            // 
            this.room2.Controls.Add(this.num_4);
            this.room2.Controls.Add(this.num_3);
            this.room2.Controls.Add(this.num_2);
            this.room2.Controls.Add(this.num_1);
            this.room2.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.room2.ForeColor = System.Drawing.Color.White;
            this.room2.Location = new System.Drawing.Point(595, 201);
            this.room2.Name = "room2";
            this.room2.Size = new System.Drawing.Size(396, 202);
            this.room2.TabIndex = 8;
            this.room2.TabStop = false;
            this.room2.Text = "2호차";
            // 
            // num_4
            // 
            this.num_4.Appearance = System.Windows.Forms.Appearance.Button;
            this.num_4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(153)))), ((int)(((byte)(200)))));
            this.num_4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.num_4.Image = ((System.Drawing.Image)(resources.GetObject("num_4.Image")));
            this.num_4.Location = new System.Drawing.Point(238, 125);
            this.num_4.Name = "num_4";
            this.num_4.Size = new System.Drawing.Size(91, 51);
            this.num_4.TabIndex = 12;
            this.num_4.Text = "8";
            this.num_4.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.num_4.UseVisualStyleBackColor = false;
            this.num_4.CheckedChanged += new System.EventHandler(this.num_4_CheckedChanged);
            // 
            // num_3
            // 
            this.num_3.Appearance = System.Windows.Forms.Appearance.Button;
            this.num_3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(153)))), ((int)(((byte)(200)))));
            this.num_3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.num_3.Image = ((System.Drawing.Image)(resources.GetObject("num_3.Image")));
            this.num_3.Location = new System.Drawing.Point(238, 49);
            this.num_3.Name = "num_3";
            this.num_3.Size = new System.Drawing.Size(91, 51);
            this.num_3.TabIndex = 11;
            this.num_3.Text = "7";
            this.num_3.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.num_3.UseVisualStyleBackColor = false;
            this.num_3.CheckedChanged += new System.EventHandler(this.num_3_CheckedChanged);
            // 
            // num_2
            // 
            this.num_2.Appearance = System.Windows.Forms.Appearance.Button;
            this.num_2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(153)))), ((int)(((byte)(200)))));
            this.num_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.num_2.Image = ((System.Drawing.Image)(resources.GetObject("num_2.Image")));
            this.num_2.Location = new System.Drawing.Point(80, 125);
            this.num_2.Name = "num_2";
            this.num_2.Size = new System.Drawing.Size(91, 51);
            this.num_2.TabIndex = 10;
            this.num_2.Text = "6";
            this.num_2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.num_2.UseVisualStyleBackColor = false;
            this.num_2.CheckedChanged += new System.EventHandler(this.num_2_CheckedChanged);
            // 
            // num_1
            // 
            this.num_1.Appearance = System.Windows.Forms.Appearance.Button;
            this.num_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(153)))), ((int)(((byte)(200)))));
            this.num_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.num_1.Image = ((System.Drawing.Image)(resources.GetObject("num_1.Image")));
            this.num_1.Location = new System.Drawing.Point(80, 49);
            this.num_1.Name = "num_1";
            this.num_1.Size = new System.Drawing.Size(91, 51);
            this.num_1.TabIndex = 9;
            this.num_1.Text = "5";
            this.num_1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.num_1.UseVisualStyleBackColor = false;
            this.num_1.CheckedChanged += new System.EventHandler(this.num_1_CheckedChanged);
            // 
            // room1
            // 
            this.room1.Controls.Add(this.num4);
            this.room1.Controls.Add(this.num2);
            this.room1.Controls.Add(this.num3);
            this.room1.Controls.Add(this.num1);
            this.room1.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.room1.ForeColor = System.Drawing.Color.White;
            this.room1.Location = new System.Drawing.Point(122, 201);
            this.room1.Name = "room1";
            this.room1.Size = new System.Drawing.Size(396, 202);
            this.room1.TabIndex = 6;
            this.room1.TabStop = false;
            this.room1.Text = "1호차";
            // 
            // num4
            // 
            this.num4.Appearance = System.Windows.Forms.Appearance.Button;
            this.num4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(153)))), ((int)(((byte)(200)))));
            this.num4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.num4.Image = ((System.Drawing.Image)(resources.GetObject("num4.Image")));
            this.num4.Location = new System.Drawing.Point(239, 125);
            this.num4.Name = "num4";
            this.num4.Size = new System.Drawing.Size(91, 51);
            this.num4.TabIndex = 11;
            this.num4.Text = "4";
            this.num4.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.num4.UseVisualStyleBackColor = false;
            this.num4.CheckedChanged += new System.EventHandler(this.num4_CheckedChanged);
            // 
            // num2
            // 
            this.num2.Appearance = System.Windows.Forms.Appearance.Button;
            this.num2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(153)))), ((int)(((byte)(200)))));
            this.num2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.num2.Image = ((System.Drawing.Image)(resources.GetObject("num2.Image")));
            this.num2.Location = new System.Drawing.Point(81, 125);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(91, 51);
            this.num2.TabIndex = 10;
            this.num2.Text = "2";
            this.num2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.num2.UseVisualStyleBackColor = false;
            this.num2.CheckedChanged += new System.EventHandler(this.num2_CheckedChanged);
            // 
            // num3
            // 
            this.num3.Appearance = System.Windows.Forms.Appearance.Button;
            this.num3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(153)))), ((int)(((byte)(200)))));
            this.num3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.num3.Image = ((System.Drawing.Image)(resources.GetObject("num3.Image")));
            this.num3.Location = new System.Drawing.Point(239, 49);
            this.num3.Name = "num3";
            this.num3.Size = new System.Drawing.Size(91, 51);
            this.num3.TabIndex = 9;
            this.num3.Text = "3";
            this.num3.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.num3.UseVisualStyleBackColor = false;
            this.num3.CheckedChanged += new System.EventHandler(this.num3_CheckedChanged);
            // 
            // num1
            // 
            this.num1.Appearance = System.Windows.Forms.Appearance.Button;
            this.num1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(153)))), ((int)(((byte)(200)))));
            this.num1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.num1.Image = ((System.Drawing.Image)(resources.GetObject("num1.Image")));
            this.num1.Location = new System.Drawing.Point(81, 49);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(91, 51);
            this.num1.TabIndex = 8;
            this.num1.Text = "1";
            this.num1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.num1.UseVisualStyleBackColor = false;
            this.num1.CheckedChanged += new System.EventHandler(this.num1_CheckedChanged);
            // 
            // nonReserveSeat_Cmd
            // 
            this.nonReserveSeat_Cmd.Connection = this.oracleConnection1;
            oracleParameter9.OracleDbType = Oracle.DataAccess.Client.OracleDbType.Varchar2;
            oracleParameter9.ParameterName = "seatTID";
            oracleParameter10.OracleDbType = Oracle.DataAccess.Client.OracleDbType.Varchar2;
            oracleParameter10.ParameterName = "ResrvTID";
            this.nonReserveSeat_Cmd.Parameters.Add(oracleParameter9);
            this.nonReserveSeat_Cmd.Parameters.Add(oracleParameter10);
            this.nonReserveSeat_Cmd.Transaction = null;
            // 
            // oracleConnection1
            // 
            this.oracleConnection1.ConnectionString = "DATA SOURCE=chaeyeon;USER ID=A5414290;PASSWORD=A5414290";
            // 
            // Reserved_Cmd
            // 
            this.Reserved_Cmd.Connection = this.oracleConnection1;
            oracleParameter1.OracleDbType = Oracle.DataAccess.Client.OracleDbType.Varchar2;
            oracleParameter1.ParameterName = "Seat_TID";
            oracleParameter2.OracleDbType = Oracle.DataAccess.Client.OracleDbType.Varchar2;
            oracleParameter2.ParameterName = "Reserve_TID";
            oracleParameter11.OracleDbType = Oracle.DataAccess.Client.OracleDbType.Decimal;
            oracleParameter11.ParameterName = "S_id";
            oracleParameter12.OracleDbType = Oracle.DataAccess.Client.OracleDbType.Decimal;
            oracleParameter12.ParameterName = "A_id";
            this.Reserved_Cmd.Parameters.Add(oracleParameter1);
            this.Reserved_Cmd.Parameters.Add(oracleParameter2);
            this.Reserved_Cmd.Parameters.Add(oracleParameter11);
            this.Reserved_Cmd.Parameters.Add(oracleParameter12);
            this.Reserved_Cmd.Transaction = null;
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reservationTableAdapter1
            // 
            this.reservationTableAdapter1.ClearBeforeFill = true;
            // 
            // Insert
            // 
            this.Insert.Connection = this.oracleConnection1;
            this.Insert.Transaction = null;
            // 
            // INSERT_resNum_Cmd
            // 
            this.INSERT_resNum_Cmd.Connection = this.oracleConnection1;
            oracleParameter3.OracleDbType = Oracle.DataAccess.Client.OracleDbType.Varchar2;
            oracleParameter3.ParameterName = "M_ID";
            oracleParameter4.OracleDbType = Oracle.DataAccess.Client.OracleDbType.Decimal;
            oracleParameter4.ParameterName = "RES_NUM";
            this.INSERT_resNum_Cmd.Parameters.Add(oracleParameter3);
            this.INSERT_resNum_Cmd.Parameters.Add(oracleParameter4);
            this.INSERT_resNum_Cmd.Transaction = null;
            // 
            // memberTableAdapter1
            // 
            this.memberTableAdapter1.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1147, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 28);
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(1173, 571);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "book";
            this.Text = "book";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.room2.ResumeLayout(false);
            this.room1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button ok_btn;
        private System.Windows.Forms.TextBox textBox1;
        private DataSet1 dataSet11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cHARGEDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button reservation;
        private System.Windows.Forms.CheckBox num_4;
        private System.Windows.Forms.CheckBox num_3;
        private System.Windows.Forms.CheckBox num_2;
        private System.Windows.Forms.CheckBox num_1;
        private System.Windows.Forms.CheckBox num4;
        private System.Windows.Forms.CheckBox num2;
        private System.Windows.Forms.CheckBox num3;
        private System.Windows.Forms.CheckBox num1;
        private Oracle.DataAccess.Client.OracleCommand nonReserveSeat_Cmd;
        private Oracle.DataAccess.Client.OracleConnection oracleConnection1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Oracle.DataAccess.Client.OracleCommand Reserved_Cmd;
        private DataSet1TableAdapters.RESERVATIONTableAdapter reservationTableAdapter1;
        private System.Windows.Forms.GroupBox room2;
        private System.Windows.Forms.GroupBox room1;
        private Oracle.DataAccess.Client.OracleCommand Insert;
        private Oracle.DataAccess.Client.OracleCommand INSERT_resNum_Cmd;
        private DataSet1TableAdapters.MEMBERTableAdapter memberTableAdapter1;
        private System.Windows.Forms.PictureBox pictureBox1;

    }
}