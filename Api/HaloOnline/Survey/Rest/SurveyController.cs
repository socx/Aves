using HaloOnline.Common;
using HaloOnline.Survey.Rest.Messages;
using HaloOnline.Survey.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HaloOnline.Survey.Rest
{
    [RoutePrefix("api/survey")]
    public class SurveyController : ApiController
    {
        private ILogger _fileLogger = new FileLogger();
        private SurveyServices _surveyServices = new SurveyServices();

        public SurveyController()
        {
            _fileLogger = new FileLogger() { ErrorLogFilePath = System.Web.HttpContext.Current.Server.MapPath("\\logs\\") };
        }

        [HttpGet]
        [Route("questions/{surveyId:int}")]
        public IHttpActionResult GetSurveyQuestions(int surveyId)
        {
            try
            {
                var questions = _surveyServices.GetSurveyQuestions(surveyId);
                if (questions != null)
                {
                    return Ok(questions);
                }
            }
            catch (Exception ex)
            {
                _fileLogger.LogError(ex);
            }

            return Content(HttpStatusCode.OK, "No data found");

        }

        [HttpPost]
        [Route("responses")]
        public IHttpActionResult SaveSurveyResponse([FromBody] SurveyResponseRequest surveyResponseRequest)
        {
            try
            {
                var response = _surveyServices.SaveSurveyResponse(surveyResponseRequest);
                if (response != null)
                {
                    return Ok(response);
                }
            }
            catch (Exception ex)
            {
                _fileLogger.LogError(ex);
            }

            return Content(HttpStatusCode.OK, "No data found");

        }

    }
}
