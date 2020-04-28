namespace TrainProject
{
    partial class join
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
            this.join_phone_txtbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.id_check_btn = new System.Windows.Forms.Button();
            this.ok_btn = new System.Windows.Forms.Button();
            this.join_password_txtbox = new System.Windows.Forms.TextBox();
            this.join_id_txtbox = new System.Windows.Forms.TextBox();
            this.join_name_txtbox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.close_btn = new System.Windows.Forms.Button();
            this.dataSet11 = new TrainProject.DataSet1();
            this.memberTableAdapter1 = new TrainProject.DataSet1TableAdapters.MEMBERTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            this.SuspendLayout();
            // 
            // join_phone_txtbox
            // 
            this.join_phone_txtbox.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.join_phone_txtbox.Location = new System.Drawing.Point(251, 333);
            this.join_phone_txtbox.Name = "join_phone_txtbox";
            this.join_phone_txtbox.Size = new System.Drawing.Size(172, 33);
            this.join_phone_txtbox.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(81, 329);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 37);
            this.label1.TabIndex = 31;
            this.label1.Text = "전화번호";
            // 
            // id_check_btn
            // 
            this.id_check_btn.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.id_check_btn.Location = new System.Drawing.Point(444, 121);
            this.id_check_btn.Name = "id_check_btn";
            this.id_check_btn.Size = new System.Drawing.Size(130, 41);
            this.id_check_btn.TabIndex = 27;
            this.id_check_btn.Text = "중복체크";
            this.id_check_btn.UseVisualStyleBackColor = true;
            this.id_check_btn.Click += new System.EventHandler(this.id_check_btn_Click);
            // 
            // ok_btn
            // 
            this.ok_btn.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ok_btn.Location = new System.Drawing.Point(454, 396);
            this.ok_btn.Name = "ok_btn";
            this.ok_btn.Size = new System.Drawing.Size(130, 56);
            this.ok_btn.TabIndex = 23;
            this.ok_btn.Text = "확인";
            this.ok_btn.UseVisualStyleBackColor = true;
            this.ok_btn.Click += new System.EventHandler(this.ok_btn_Click);
            // 
            // join_password_txtbox
            // 
            this.join_password_txtbox.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.join_password_txtbox.Location = new System.Drawing.Point(251, 258);
            this.join_password_txtbox.Name = "join_password_txtbox";
            this.join_password_txtbox.Size = new System.Drawing.Size(172, 33);
            this.join_password_txtbox.TabIndex = 30;
            // 
            // join_id_txtbox
            // 
            this.join_id_txtbox.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.join_id_txtbox.Location = new System.Drawing.Point(251, 125);
            this.join_id_txtbox.Name = "join_id_txtbox";
            this.join_id_txtbox.Size = new System.Drawing.Size(172, 33);
            this.join_id_txtbox.TabIndex = 29;
            // 
            // join_name_txtbox
            // 
            this.join_name_txtbox.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.join_name_txtbox.Location = new System.Drawing.Point(251, 187);
            this.join_name_txtbox.Name = "join_name_txtbox";
            this.join_name_txtbox.Size = new System.Drawing.Size(172, 33);
            this.join_name_txtbox.TabIndex = 24;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("맑은 고딕", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label11.Location = new System.Drawing.Point(135, 179);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 37);
            this.label11.TabIndex = 28;
            this.label11.Text = "성명";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("맑은 고딕", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.Location = new System.Drawing.Point(81, 250);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(125, 37);
            this.label9.TabIndex = 25;
            this.label9.Text = "비밀번호";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("맑은 고딕", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(108, 121);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 37);
            this.label8.TabIndex = 26;
            this.label8.Text = "아이디";
            // 
            // close_btn
            // 
            this.close_btn.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.close_btn.Location = new System.Drawing.Point(306, 396);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(130, 56);
            this.close_btn.TabIndex = 33;
            this.close_btn.Text = "취소";
            this.close_btn.UseVisualStyleBackColor = true;
            this.close_btn.Click += new System.EventHandler(this.close_btn_Click);
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // memberTableAdapter1
            // 
            this.memberTableAdapter1.ClearBeforeFill = true;
            // 
            // join
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 517);
            this.Controls.Add(this.close_btn);
            this.Controls.Add(this.join_phone_txtbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.id_check_btn);
            this.Controls.Add(this.ok_btn);
            this.Controls.Add(this.join_password_txtbox);
            this.Controls.Add(this.join_id_txtbox);
            this.Controls.Add(this.join_name_txtbox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "join";
            this.Text = "join";
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox join_phone_txtbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button id_check_btn;
        private System.Windows.Forms.Button ok_btn;
        private System.Windows.Forms.TextBox join_password_txtbox;
        private System.Windows.Forms.TextBox join_id_txtbox;
        private System.Windows.Forms.TextBox join_name_txtbox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button close_btn;
        private DataSet1 dataSet11;
        private DataSet1TableAdapters.MEMBERTableAdapter memberTableAdapter1;
    }
}