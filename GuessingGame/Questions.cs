using System;
using System.Collections.Generic;
using System.Text;

namespace Quiz
{
   public class Question
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Tip { get; set; }
        public string Answer { get; set; }

        public Question(int id, string name, string tip, string answer) 
        {
            Id = id;
            Name = name;
            Tip = tip;
            Answer = answer;
        }

    }    
    
}
   

