namespace QuanLyThi
{
    partial class TakingExam
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelAnswered = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.flowLayoutPanelDanhSachCauHoi = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanelTraLoi = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanelDeBai = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonPrevQuestion = new System.Windows.Forms.Button();
            this.buttonNextQuestion = new System.Windows.Forms.Button();
            this.button = new System.Windows.Forms.Button();
            this.labelExamName = new System.Windows.Forms.Label();
            this.labelSubjectExam = new System.Windows.Forms.Label();
            this.labelTeacherName = new System.Windows.Forms.Label();
            this.labelStudentName = new System.Windows.Forms.Label();
            this.labelCountDown = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelAnswered);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.flowLayoutPanelDanhSachCauHoi);
            this.groupBox1.Location = new System.Drawing.Point(12, 113);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(211, 300);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách câu hỏi";
            // 
            // labelAnswered
            // 
            this.labelAnswered.AutoSize = true;
            this.labelAnswered.Location = new System.Drawing.Point(106, 267);
            this.labelAnswered.Name = "labelAnswered";
            this.labelAnswered.Size = new System.Drawing.Size(13, 13);
            this.labelAnswered.TabIndex = 3;
            this.labelAnswered.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 267);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Số câu đã làm: ";
            // 
            // flowLayoutPanelDanhSachCauHoi
            // 
            this.flowLayoutPanelDanhSachCauHoi.AutoScroll = true;
            this.flowLayoutPanelDanhSachCauHoi.Location = new System.Drawing.Point(18, 19);
            this.flowLayoutPanelDanhSachCauHoi.Name = "flowLayoutPanelDanhSachCauHoi";
            this.flowLayoutPanelDanhSachCauHoi.Size = new System.Drawing.Size(174, 232);
            this.flowLayoutPanelDanhSachCauHoi.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelCountDown);
            this.groupBox2.Controls.Add(this.labelStudentName);
            this.groupBox2.Controls.Add(this.labelTeacherName);
            this.groupBox2.Controls.Add(this.labelSubjectExam);
            this.groupBox2.Controls.Add(this.labelExamName);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(225, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(858, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tên đề: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Người giao đề: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Môn thi: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Học sinh: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(407, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thời gian còn lại: ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.panel1);
            this.groupBox3.Location = new System.Drawing.Point(225, 110);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(858, 496);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Làm bài";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.flowLayoutPanelTraLoi);
            this.panel1.Controls.Add(this.flowLayoutPanelDeBai);
            this.panel1.Location = new System.Drawing.Point(9, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(843, 467);
            this.panel1.TabIndex = 0;
            // 
            // flowLayoutPanelTraLoi
            // 
            this.flowLayoutPanelTraLoi.AutoScroll = true;
            this.flowLayoutPanelTraLoi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanelTraLoi.Location = new System.Drawing.Point(4, 387);
            this.flowLayoutPanelTraLoi.Name = "flowLayoutPanelTraLoi";
            this.flowLayoutPanelTraLoi.Size = new System.Drawing.Size(836, 74);
            this.flowLayoutPanelTraLoi.TabIndex = 1;
            // 
            // flowLayoutPanelDeBai
            // 
            this.flowLayoutPanelDeBai.AutoScroll = true;
            this.flowLayoutPanelDeBai.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanelDeBai.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelDeBai.Location = new System.Drawing.Point(4, 4);
            this.flowLayoutPanelDeBai.Name = "flowLayoutPanelDeBai";
            this.flowLayoutPanelDeBai.Size = new System.Drawing.Size(836, 376);
            this.flowLayoutPanelDeBai.TabIndex = 0;
            this.flowLayoutPanelDeBai.WrapContents = false;
            // 
            // buttonPrevQuestion
            // 
            this.buttonPrevQuestion.Location = new System.Drawing.Point(462, 606);
            this.buttonPrevQuestion.Name = "buttonPrevQuestion";
            this.buttonPrevQuestion.Size = new System.Drawing.Size(184, 37);
            this.buttonPrevQuestion.TabIndex = 3;
            this.buttonPrevQuestion.Text = "< |";
            this.buttonPrevQuestion.UseVisualStyleBackColor = true;
            this.buttonPrevQuestion.Click += new System.EventHandler(this.ClickToPrevQuestion);
            // 
            // buttonNextQuestion
            // 
            this.buttonNextQuestion.Location = new System.Drawing.Point(652, 606);
            this.buttonNextQuestion.Name = "buttonNextQuestion";
            this.buttonNextQuestion.Size = new System.Drawing.Size(170, 37);
            this.buttonNextQuestion.TabIndex = 3;
            this.buttonNextQuestion.Text = "| >";
            this.buttonNextQuestion.UseVisualStyleBackColor = true;
            this.buttonNextQuestion.Click += new System.EventHandler(this.ClickToNextQuestion);
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(30, 419);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(174, 39);
            this.button.TabIndex = 4;
            this.button.Text = "Nộp bài";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.ClickToSubmit);
            // 
            // labelExamName
            // 
            this.labelExamName.AutoSize = true;
            this.labelExamName.Location = new System.Drawing.Point(96, 20);
            this.labelExamName.Name = "labelExamName";
            this.labelExamName.Size = new System.Drawing.Size(16, 13);
            this.labelExamName.TabIndex = 1;
            this.labelExamName.Text = "...";
            // 
            // labelSubjectExam
            // 
            this.labelSubjectExam.AutoSize = true;
            this.labelSubjectExam.Location = new System.Drawing.Point(96, 39);
            this.labelSubjectExam.Name = "labelSubjectExam";
            this.labelSubjectExam.Size = new System.Drawing.Size(16, 13);
            this.labelSubjectExam.TabIndex = 1;
            this.labelSubjectExam.Text = "...";
            // 
            // labelTeacherName
            // 
            this.labelTeacherName.AutoSize = true;
            this.labelTeacherName.Location = new System.Drawing.Point(96, 57);
            this.labelTeacherName.Name = "labelTeacherName";
            this.labelTeacherName.Size = new System.Drawing.Size(16, 13);
            this.labelTeacherName.TabIndex = 1;
            this.labelTeacherName.Text = "...";
            // 
            // labelStudentName
            // 
            this.labelStudentName.AutoSize = true;
            this.labelStudentName.Location = new System.Drawing.Point(96, 74);
            this.labelStudentName.Name = "labelStudentName";
            this.labelStudentName.Size = new System.Drawing.Size(16, 13);
            this.labelStudentName.TabIndex = 1;
            this.labelStudentName.Text = "...";
            // 
            // labelCountDown
            // 
            this.labelCountDown.AutoSize = true;
            this.labelCountDown.Location = new System.Drawing.Point(505, 20);
            this.labelCountDown.Name = "labelCountDown";
            this.labelCountDown.Size = new System.Drawing.Size(13, 13);
            this.labelCountDown.TabIndex = 2;
            this.labelCountDown.Text = "0";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // TakingExam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 664);
            this.Controls.Add(this.button);
            this.Controls.Add(this.buttonNextQuestion);
            this.Controls.Add(this.buttonPrevQuestion);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "TakingExam";
            this.Text = "TakingExam";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TakingExam_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelDanhSachCauHoi;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonPrevQuestion;
        private System.Windows.Forms.Button buttonNextQuestion;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelTraLoi;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelDeBai;
        private System.Windows.Forms.Label labelAnswered;
        private System.Windows.Forms.Label labelStudentName;
        private System.Windows.Forms.Label labelTeacherName;
        private System.Windows.Forms.Label labelSubjectExam;
        private System.Windows.Forms.Label labelExamName;
        private System.Windows.Forms.Label labelCountDown;
        private System.Windows.Forms.Timer timer1;
    }
}