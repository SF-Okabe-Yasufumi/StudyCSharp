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
    // [ApiController]と[Route("[controller]")]を、クラス名の前の行に
    // 記述することにより、http://localhost:5000/ の後に、このクラス名
    // ここでいうSampleKakezan をURLに追加ということになります。
    // ※ クラス名語尾のController は自動で無視されます。
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
        // [Route("Execute")]を、関数名の前の行に
        // 記述することにより、http://localhost:5000/SampleKakezan/ の後に、Executeを
        // URLに追加ということになります。
        // [HttpPost]は今のところはまだ無視して下さい。
        // http://localhost:5000/SampleKakezan/Execute のURLをたたくとこの関数が実行されます。
        [Route("Execute")]
        [HttpPost]
        public SampleKakezanResponce Execute(SampleKakezanRequest request)
        {
            // ログ出力をしています。
            _logger.LogInformation("----------------------------------------------------------------------------------------");
            _logger.LogInformation("掛け算実行リクエスト");
            _logger.LogInformation($"---------- SampleKakezanRequest.KakezanHikisuuOne : [{request.KakezanHikisuuOne}]");
            _logger.LogInformation($"---------- SampleKakezanRequest.KakezanHikisuuTwo : [{request.KakezanHikisuuTwo}]");
            _logger.LogInformation("----------------------------------------------------------------------------------------");

            // メイン処理をするためのクラスを生成し実行関数を呼びだしています。
            var responce = new SampleKakezanLogic(_logger).Execute(request);

            return responce;
        }

        #endregion "public methods"
    }
}
