using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Quiz_Project_for_Uni.Data
{
    public class Quiz
    {
        public int Id { get; set; }
        public string Question { get; set; }

        
        public string Answers { get; set; }

        
        public int CorrectAnswerIndex { get; set; }

        [NotMapped]
        public List<string> AnswersList
        {
            get => string.IsNullOrEmpty(Answers)
                ? new List<string>()
                : JsonSerializer.Deserialize<List<string>>(Answers);

            set => Answers = JsonSerializer.Serialize(value);
        }

        public Quiz()
        {
            AnswersList = new List<string>();
        }

     }
}
