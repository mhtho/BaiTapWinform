using QuanLyThi.Student;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace QuanLyThi
{
    public partial class TakingExam : Form
    {
        private DataRow exam;
        private int totalQuestions;
        private List<Question> questionList;
        private List<Button> buttonList;
        private int curQuestionID;
        private int numOfAnswered;
        private int studentID;
        private long timeCountDown = 300;
        public TakingExam()
        {
            InitializeComponent();
        }
        public TakingExam(DataRow curExam = null, int totalQuestions = 0, int studentID = 1)
        {
            InitializeComponent();
            this.exam = curExam;
            this.totalQuestions = totalQuestions;
            this.numOfAnswered = 0;
            this.studentID = studentID;
            loadExam();
            loadStatus();
            loadInfo();
            loadDeBai(curQuestionID);
            loadBaiLam(curQuestionID);
            timer1.Start();
        }
        void loadExam()
        {
            questionList = new List<Question>();
            buttonList = new List<Button>();
            SqlRunner sqlRunner = new SqlRunner();
            DataTable dataTN = sqlRunner.excuteQuery(string.Format("SELECT tn.noiDung, tn.dapAn1, tn.dapAn2, tn.dapAn3, tn.dapAn4, tn.cauTraLoi FROM dbo.ChiTiet_DeThi as detail INNER JOIN dbo.CauHoiTracNghiem as tn ON detail.maCauHoiTN = tn.maCauHoi WHERE detail.maDeThi = {0}", exam["maDeThi"]));
            DataTable dataTL = sqlRunner.excuteQuery(string.Format("SELECT tl.noiDung, tl.cauTraLoi FROM dbo.ChiTiet_DeThi as detail INNER JOIN dbo.CauHoiTuLuan as tl ON detail.maCauHoiTL = tl.maCauHoi WHERE detail.maDeThi = {0}", exam["maDeThi"]));
            int totalTN = dataTN.Rows.Count;
            int totalTL = dataTL.Rows.Count; 
            for (int i = 0; i < totalTN; i++)
            {
                Button btn = new Button() { Text = (i + 1).ToString(), Size = new Size(33, 33) };
                btn.Click += clickButtonLoadDe;
                DataRow data = dataTN.Rows[i];
                TracNghiem tn = new TracNghiem();
                tn.dataRowToQuestion(data);
                questionList.Add(tn);
                buttonList.Add(btn);
                flowLayoutPanelDanhSachCauHoi.Controls.Add(btn);
            }

            for (int i = totalTN; i < totalQuestions; i++)
            {
                Button btn = new Button() { Text = (i + 1).ToString(), Size = new Size(33, 33) };
                btn.Click += clickButtonLoadDe;
                DataRow data = dataTL.Rows[i - totalTN];
                TuLuan tl = new TuLuan();
                tl.dataRowToQuestion(data);
                questionList.Add(tl);
                buttonList.Add(btn);
                flowLayoutPanelDanhSachCauHoi.Controls.Add(btn);
            }
        }
        public void loadStatus()
        {
            labelAnswered.Text = string.Format("{0} / {1}", numOfAnswered, totalQuestions);
        }
        public void loadButton()
        {
            buttonList[curQuestionID].BackColor = Color.LightGreen;
        }
        public void loadInfo() 
        {
            SqlRunner sqlRunner = new SqlRunner();
            DataTable dt = sqlRunner.excuteQuery(string.Format("SELECT hoTen FROM dbo.HocSinh WHERE maHocSinh = {0}", studentID));
            labelExamName.Text = exam["tenDeThi"].ToString();
            labelSubjectExam.Text = exam["monThi"].ToString();
            labelTeacherName.Text = exam["hoTen"].ToString();
            labelStudentName.Text = dt.Rows[0]["hoTen"].ToString();
            timeCountDown = Convert.ToInt64(exam["thoiGianLamBai"]) * 60;
            labelCountDown.Text = TimeSpan.FromSeconds(timeCountDown).ToString("mm\\:ss");
        }
        public void loadDeBai(int id)
        {
            if (questionList[id] is TracNghiem)
            {
                loadDeTN(questionList[id], id + 1);
            }
            else if(questionList[id] is TuLuan)
            {
                loadDeTL(questionList[id], id + 1);
            }
        }
        public void loadDeTN(Question x, int id)
        {
            TracNghiem cauTN = x as TracNghiem;
            flowLayoutPanelDeBai.Controls.Clear();
            Label deBai = new Label() { Text = "Câu " + id + ":\n" + cauTN.content, AutoSize = true, Font = new Font(Font.FontFamily, 14.5f, FontStyle.Regular)};
            deBai.Margin = new Padding(40, 15, 40, 15);
            flowLayoutPanelDeBai.Controls.Add(deBai);
            for(int i = 0; i < 4; i++)
            {
                Label dapAn = new Label() { Text = Convert.ToChar(i + 'A').ToString() + ". " + cauTN.options[i], AutoSize = true, Font = new Font(Font.FontFamily, 14.5f, FontStyle.Regular) };
                dapAn.Margin = new Padding(40, 15, 40, 15); 
                flowLayoutPanelDeBai.Controls.Add(dapAn);
            }
        }
        public void loadDeTL(Question x, int id)
        {
            TuLuan cauTL = x as TuLuan;
            flowLayoutPanelDeBai.Controls.Clear();
            Label deBai = new Label() { Text = "Câu " + id + ":\n" + cauTL.content, AutoSize = true, Font = new Font(Font.FontFamily, 14.5f, FontStyle.Regular) };
            deBai.Margin = new Padding(40, 15, 40, 15);
            flowLayoutPanelDeBai.Controls.Add(deBai);
        }
        public void loadBaiLam(int id)
        {
            if (questionList[id] is TracNghiem)
            {
                loadBaiLamTN(questionList[id], id + 1);
            }
            else if (questionList[id] is TuLuan)
            {
                loadBaiLamTL(questionList[id], id + 1);
            }
        }
        public void loadBaiLamTN(Question x, int id)
        {
            TracNghiem cauTN = x as TracNghiem;
            flowLayoutPanelTraLoi.Controls.Clear();
            for(int i = 0; i < 4; i++)
            {
                RadioButton option = new RadioButton() { Text = Convert.ToChar(i + 'A').ToString() , Font = new Font(Font.FontFamily, 14.5f, FontStyle.Regular) };
                option.Checked = (cauTN.preAnswer == i + 1);
                option.Margin = new Padding(40, 23, 40, 23);
                option.Tag = i + 1;
                option.Click += Option_Click;
                flowLayoutPanelTraLoi.Controls.Add(option);
            }
        }
        public void loadBaiLamTL(Question x, int id)
        {
            TuLuan cauTL = x as TuLuan;
            flowLayoutPanelTraLoi.Controls.Clear();
            Label title = new Label() { Text = "Điền đáp án vào đây: ", AutoSize = true, Font = new Font(Font.FontFamily, 14.5f, FontStyle.Regular) };
            title.Margin = new Padding(40, 23, 10, 23);
            TextBox answer = new TextBox() { Text = cauTL.preAnswer, Size = new Size(300, 25), Multiline = false};
            answer.Margin = new Padding(40, 23, 40, 23);
            answer.TextChanged += Answer_TextChanged;
            flowLayoutPanelTraLoi.Controls.Add(title);
            flowLayoutPanelTraLoi.Controls.Add(answer);
        }
        public bool submitBaiLam()
        {
            DialogResult res = MessageBox.Show("Bạn có chắc muốn nộp không ?", "Notice", MessageBoxButtons.OKCancel);
            if (res == DialogResult.Cancel) return false;
            submitForce();
            return true;
        }
        public void submitForce()
        {
            timer1.Stop();
            Submission submit = new Submission();
            double point = submit.getResult(questionList);
            submit.pushSubmit(studentID, Convert.ToInt32(exam["maDeThi"]), point);
            Form form = new Result(questionList, point);
            form.ShowDialog();
        }
        private void Answer_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            TuLuan cauTL = questionList[curQuestionID] as TuLuan;
            if (cauTL.preAnswer == "\0")
            {
                numOfAnswered++;
                loadStatus();
                loadButton();
            }
            cauTL.preAnswer = textBox.Text;
        }
        private void clickButtonLoadDe(object sender, EventArgs e)
        {
            Button bt = sender as Button;
            curQuestionID = Convert.ToInt32(bt.Text) - 1;
            loadDeBai(curQuestionID);
            loadBaiLam(curQuestionID);
        }
        private void Option_Click(object sender, EventArgs e)
        {
            RadioButton curCheck = sender as RadioButton; 
            TracNghiem cauTN = questionList[curQuestionID] as TracNghiem;
            if (cauTN.preAnswer == -1)
            {
                numOfAnswered++;
                loadStatus();
                loadButton();
            }
            cauTN.preAnswer = Convert.ToInt32(curCheck.Tag);
            foreach(RadioButton rb in flowLayoutPanelTraLoi.Controls)
            {
                if (rb == curCheck) continue;
                rb.Checked = !curCheck.Checked;
            }
        }
        private void ClickToNextQuestion(object sender, EventArgs e)
        {
            if (curQuestionID + 1 >= totalQuestions) return;
            curQuestionID++;
            loadDeBai(curQuestionID);
            loadBaiLam(curQuestionID);
        }
        private void ClickToPrevQuestion(object sender, EventArgs e)
        {
            if (curQuestionID - 1 < 0) return;
            curQuestionID--;
            loadDeBai(curQuestionID);
            loadBaiLam(curQuestionID);
        }
        private void ClickToSubmit(object sender, EventArgs e)
        {
            this.Close();
        }
        private void TakingExam_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (timeCountDown < 0) submitForce();
            else if(!submitBaiLam()) e.Cancel = true;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            timeCountDown--;
            if(timeCountDown < 0)
            {
                timer1.Stop();
                this.Close();
            }
                
            labelCountDown.Text = TimeSpan.FromSeconds(timeCountDown).ToString("mm\\:ss");
        }
    }
}
