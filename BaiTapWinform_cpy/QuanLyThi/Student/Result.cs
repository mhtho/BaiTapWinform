using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThi.Student
{
    public partial class Result : Form
    {
        List<Submit> submits;
        int numOfRightAnswer, numOfWrongAnswer, numOfNullAnswer;
        public Result()
        {
            InitializeComponent();
        }

        public Result(List<Question> questionList, double point)
        {
            InitializeComponent();
            loadSubmit(questionList);
            loadResult();
            loadInfo(point);
        }
        public void loadInfo(double point)
        {
            labelRightAnswer.Text = numOfRightAnswer.ToString();
            labelWrongAnswer.Text = numOfWrongAnswer.ToString();
            labelNullAnswer.Text = numOfNullAnswer.ToString();
            labelPoint.Text = string.Format("{0:f2}", point);
        }
        public void loadSubmit(List<Question> questionList)
        {
            submits = new List<Submit>();
            int i = 0;
            foreach (Question question in questionList)
            {
                if (question is TuLuan)
                {
                    TuLuan cauTL = question as TuLuan;
                    submits.Add(new Submit()
                    {
                        id = ++i,
                        content = cauTL.content,
                        answered = (cauTL.preAnswer == "\0") ? "Bạn chưa trả lời" : cauTL.preAnswer,
                        rightAnswer = cauTL.rightAnswer,
                        status = (cauTL.preAnswer == "\0") ? -1 : (cauTL.preAnswer == cauTL.rightAnswer ? 1 : 0)
                    });
                }
                else if (question is TracNghiem)
                {
                    TracNghiem cauTN = question as TracNghiem;
                    string contents = cauTN.content + "\n";
                    for (int j = 0; j < 4; j++) contents += Convert.ToChar(j + 'A').ToString() + ". " + cauTN.options[j] + "\n";
                    submits.Add(new Submit()
                    {
                        id = ++i,
                        content = contents,
                        answered = (cauTN.preAnswer == -1) ? "Bạn chưa trả lời" : (Convert.ToChar(cauTN.preAnswer + 'A').ToString() + ". " + cauTN.options[cauTN.preAnswer - 1]),
                        rightAnswer = Convert.ToChar(cauTN.rightAnswer + 'A').ToString() + ". " + cauTN.options[cauTN.rightAnswer - 1],
                        status = (cauTN.preAnswer == -1) ? -1 : (cauTN.preAnswer == cauTN.rightAnswer ? 1 : 0)
                    });
                }
                if (submits[i - 1].status == 0) numOfWrongAnswer++;
                else if (submits[i - 1].status == 1) numOfRightAnswer++;
                else numOfNullAnswer++;
            }
        }
        public void loadResult()
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Column1",
                DataPropertyName = "id",
                HeaderText = "Câu hỏi",
                Width = 50,
                Resizable = DataGridViewTriState.False
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Column2",
                DataPropertyName = "content",
                HeaderText = "Đề bài",
                Width = 230,
                Resizable = DataGridViewTriState.False
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Column3",
                DataPropertyName = "answered",
                HeaderText = "Câu trả lời của bạn",
                Width = 245,
                Resizable = DataGridViewTriState.False
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Column4",
                DataPropertyName = "rightAnswer",
                HeaderText = "Câu trả lời đúng",
                Width = 245,
                Resizable = DataGridViewTriState.False
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "status",
                DataPropertyName = "status",
                Visible = false,
                Resizable = DataGridViewTriState.False
            });

            dataGridView1.DataSource = submits;

        }

        private void ClickToFinish(object sender, EventArgs e)
        {
            this.Close();
        }

        public class Submit
        {
            public int id { get; set; }
            public string content { get; set; }
            public string answered { get; set; }
            public string rightAnswer { get; set; }
            public int status { get; set; }

        }
        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            Color color;
            switch (dataGridView1.Rows[e.RowIndex].Cells["status"].Value.ToString())
            {
                case "-1":
                    color = Color.LightYellow;
                    break;
                case "0":
                    color = Color.LightPink;
                    break;
                case "1":
                    color = Color.LightGreen;
                    break;
                default:
                    color = Color.White;
                    break;
            }
            dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = color;
        }

    }
}
