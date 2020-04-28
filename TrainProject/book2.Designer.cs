namespace TrainProject
{
    partial class book2
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
            this.pay_btn = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.find_info_btn = new System.Windows.Forms.Button();
            this.oracleConnection1 = new Oracle.DataAccess.Client.OracleConnection();
            this.dataSet11 = new TrainProject.DataSet1();
            this.routeTableAdapter1 = new TrainProject.DataSet1TableAdapters.ROUTETableAdapter();
            this.routE1TableAdapter1 = new TrainProject.DataSet1TableAdapters.ROUTE1TableAdapter();
            this.stationTableAdapter1 = new TrainProject.DataSet1TableAdapters.STATIONTableAdapter();
            this.reservationTableAdapter1 = new TrainProject.DataSet1TableAdapters.RESERVATIONTableAdapter();
            this.reservedTableAdapter1 = new TrainProject.DataSet1TableAdapters.RESERVEDTableAdapter();
            this.oracleCommand1 = new Oracle.DataAccess.Client.OracleCommand();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            this.SuspendLayout();
            // 
            // pay_btn
            // 
            this.pay_btn.AutoSize = true;
            this.pay_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(49)))), ((int)(((byte)(50)))));
            this.pay_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pay_btn.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.pay_btn.ForeColor = System.Drawing.Color.White;
            this.pay_btn.Location = new System.Drawing.Point(265, 425);
            this.pay_btn.Name = "pay_btn";
            this.pay_btn.Size = new System.Drawing.Size(103, 49);
            this.pay_btn.TabIndex = 2;
            this.pay_btn.Text = "확인";
            this.pay_btn.UseVisualStyleBackColor = false;
            this.pay_btn.Click += new System.EventHandler(this.pay_btn_Click);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.listBox1.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(55, 101);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(313, 304);
            this.listBox1.TabIndex = 3;
            // 
            // find_info_btn
            // 
            this.find_info_btn.AutoSize = true;
            this.find_info_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(49)))), ((int)(((byte)(50)))));
            this.find_info_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.find_info_btn.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.find_info_btn.ForeColor = System.Drawing.Color.White;
            this.find_info_btn.Location = new System.Drawing.Point(265, 53);
            this.find_info_btn.Name = "find_info_btn";
            this.find_info_btn.Size = new System.Drawing.Size(103, 42);
            this.find_info_btn.TabIndex = 4;
            this.find_info_btn.Text = "조회";
            this.find_info_btn.UseVisualStyleBackColor = false;
            this.find_info_btn.Click += new System.EventHandler(this.find_info_btn_Click);
            // 
            // oracleConnection1
            // 
            this.oracleConnection1.ConnectionString = "DATA SOURCE=chaeyeon;USER ID=A5414290;PASSWORD=A5414290";
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // routeTableAdapter1
            // 
            this.routeTableAdapter1.ClearBeforeFill = true;
            // 
            // routE1TableAdapter1
            // 
            this.routE1TableAdapter1.ClearBeforeFill = true;
            // 
            // stationTableAdapter1
            // 
            this.stationTableAdapter1.ClearBeforeFill = true;
            // 
            // reservationTableAdapter1
            // 
            this.reservationTableAdapter1.ClearBeforeFill = true;
            // 
            // reservedTableAdapter1
            // 
            this.reservedTableAdapter1.ClearBeforeFill = true;
            // 
            // oracleCommand1
            // 
            this.oracleCommand1.CommandText = "SELECT SEAT_NUM,CLASS_NUM FROM RESERVATION";
            this.oracleCommand1.Connection = this.oracleConnection1;
            this.oracleCommand1.Transaction = null;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(12, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 32);
            this.label6.TabIndex = 21;
            this.label6.Text = "승차권";
            // 
            // book2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(404, 504);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.find_info_btn);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.pay_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "book2";
            this.Text = "승차권 정보 확인";
            this.Load += new System.EventHandler(this.book2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet1 dataSet11;
        private System.Windows.Forms.Button pay_btn;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button find_info_btn;
        private DataSet1TableAdapters.ROUTETableAdapter routeTableAdapter1;
        private DataSet1TableAdapters.ROUTE1TableAdapter routE1TableAdapter1;
        private DataSet1TableAdapters.STATIONTableAdapter stationTableAdapter1;
        private DataSet1TableAdapters.RESERVATIONTableAdapter reservationTableAdapter1;
        private DataSet1TableAdapters.RESERVEDTableAdapter reservedTableAdapter1;
        private Oracle.DataAccess.Client.OracleConnection oracleConnection1;
        private Oracle.DataAccess.Client.OracleCommand oracleCommand1;
        private System.Windows.Forms.Label label6;

    }
}