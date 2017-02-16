using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HaloOnline.Survey.Rest.Messages
{
    public class SurveyQuestionMessage
    {
        public int QuestionId { get; set; }
        public int PromptId { get; set; }
        public int SurveyId { get; set; }
        public int QuestionTypeId { get; set; }
        public string Prompt { get; set; }
        public string Question { get; set; }
        public int Sequence { get; set; }
        public int DisplayOrder { get; set; }
        public bool AmberFlag { get; set; }
    }
}