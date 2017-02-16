using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HaloOnline.Survey.Rest.Messages;

namespace HaloOnline.Survey.Services
{
    public class SurveyServices : ISurveyServices
    {
        public SurveyQuestionMessage GetSurveyQuestions(int surveyId)
        {
            throw new NotImplementedException();
        }

        public SurveyResponseMessage SaveSurveyResponse(SurveyResponseRequest surveyResponseRequest)
        {
            throw new NotImplementedException();
        }
    }
}