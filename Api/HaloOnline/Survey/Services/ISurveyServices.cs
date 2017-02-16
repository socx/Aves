using HaloOnline.Survey.Rest.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaloOnline.Survey.Services
{
    public interface ISurveyServices
    {
        SurveyQuestionMessage GetSurveyQuestions(int surveyId);
        SurveyResponseMessage SaveSurveyResponse(SurveyResponseRequest surveyResponseRequest);
    }
}
