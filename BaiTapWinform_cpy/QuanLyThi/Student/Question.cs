using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThi.Student
{
    public abstract class Question
    {
        public abstract void dataRowToQuestion(DataRow data);
        public abstract bool isTrue();
    }

    class TracNghiem : Question
    {
        public string content;
        public List<string> options;
        public int rightAnswer;
        public int preAnswer;
        public TracNghiem()
        {
            options = new List<string>();
        }

        public TracNghiem(string content, List<string> options, int rightAnswer, int preAnswer)
        {
            options = new List<string>();
            this.content = content;
            this.options = options;
            this.rightAnswer = rightAnswer;
            this.preAnswer = preAnswer;
        }

        public override void dataRowToQuestion(DataRow data)
        {
            this.content = data["noiDung"].ToString();
            options.Add(data["dapAn1"].ToString());
            options.Add(data["dapAn2"].ToString());
            options.Add(data["dapAn3"].ToString());
            options.Add(data["dapAn4"].ToString());
            this.rightAnswer = Convert.ToInt32(data["cauTraLoi"]);
            this.preAnswer = -1;
        }

        public override bool isTrue()
        {
            return preAnswer == rightAnswer;
        }
    }

    class TuLuan : Question
    {
        public string content;
        public string rightAnswer;
        public string preAnswer;
        public TuLuan() { }
        public TuLuan(string content, string rightAnswer, string preAnswer)
        {
            this.content = content;
            this.rightAnswer = rightAnswer;
            this.preAnswer = preAnswer;
        }
        
        public override void dataRowToQuestion(DataRow data)
        {
            this.content = data["noiDung"].ToString();
            this.rightAnswer = data["cauTraLoi"].ToString();
            this.preAnswer = "\0";
        }

        public override bool isTrue()
        {
            return preAnswer == rightAnswer;
        }
    }
}
