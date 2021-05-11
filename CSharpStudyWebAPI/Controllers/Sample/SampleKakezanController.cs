using BussinesLogic.Logic.Sample;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ViewModel.Sample;

namespace CSharpStudyWebAPI.Controllers.Sample
{
    [ApiController]
    [Route("[controller]")]
    public class SampleKakezanController
    {
        #region "private field variable"
        private readonly ILogger<SampleKakezanController> _logger;
        #endregion "private field variable"

        #region "constructor"
        /// <summary>
        /// デフォルトコンストラクタ
        /// </summary>
        public SampleKakezanController(ILogger<SampleKakezanController> logger)
        {
            _logger = logger;
        }
        #endregion "constructor"

        #region "public methods"
        [Route("Execute")]
        [HttpPost]
        public SampleKakezanResponce Execute(SampleKakezanRequest request)
        {
            _logger.LogInformation("----------------------------------------------------------------------------------------");
            _logger.LogInformation("掛け算実行リクエスト ");
            _logger.LogInformation($"---------- SampleKakezanRequest.KakezanHikisuuOne : [{request.KakezanHikisuuOne}]");
            _logger.LogInformation($"---------- SampleKakezanRequest.KakezanHikisuuTwo : [{request.KakezanHikisuuTwo}]");
            _logger.LogInformation("----------------------------------------------------------------------------------------");

            var responce = new SampleKakezanLogic(_logger).Execute(request);

            return responce;
        }

        #endregion "public methods"
    }
}
