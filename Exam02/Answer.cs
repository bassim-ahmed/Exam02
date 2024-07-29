using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02
{
    internal class Answer
    {

        private int id { get; set; }
        private string text { get; set; }

        public int Id
        {
            get { return id; }
            set { id = value >= 0 ? value : throw new Exception("Invalid Id Number"); }
        }
        public string Text
        {
            get { return text ?? ""; }
            set { text = string.IsNullOrEmpty(value) ? throw new Exception("Answer is Required") : value; }
        }

        public Answer(int id, string text)
        {
            Id = id;
            Text = text;
        }

        public Answer()
        {

        }

        public override string ToString()
        {
            return $"{Id}-{Text}";
        }
    }
}
