using Common;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;
using ViewModel.Sample;

namespace BussinesLogic.Logic.Sample
{
    public class SampleKakezanLogic
    {
        #region "private field variable"
        private readonly ILogger _logger;
        #endregion "private field variable"

        #region "constructor"
        public SampleKakezanLogic(ILogger logger)
        {
            _logger = logger;
        }
        #endregion "constructor"

        #region "public methods"
        /// <summary>
        /// 掛け算を実行する
        /// </summary>
        /// <param name="request">SampleKakezanRequest</param>
        /// <returns>SampleKakezanResponce</returns>
        public SampleKakezanResponce Execute(SampleKakezanRequest request)
        {
            int result;

            //try
            //{
                // 掛け算を実施する
                result = request.KakezanHikisuuOne * request.KakezanHikisuuTwo;
            //}
            //catch(Exception e)
            //{
            //    // エラーメッセージセット
            //    string errorMessage = $"掛け算エラー発生 exception=${e.Message}";

            //    // エラーログ出力
            //    _logger.LogError(e, errorMessage);

            //    // エラーが発生した場合は、エラーステータス、エラーメッセージを
            //    // セットしレスポンスを返す
            //    return new SampleKakezanResponce()
            //    {
            //        // エラーステータスをセット
            //        Status = Const.ResponceStatus.Error
            //        ,
            //        // エラーメッセージをセット
            //        ErrorMessage = errorMessage
            //        ,
            //        // 掛け算結果は 0 をセットしておく
            //        KakezanResult = 0
            //    };
            //}

            // レスポンスオブジェクトを生成し、同時に掛け算結果も格納する。
            // ※インスタンス生成時の初期値指定
            var responce = new SampleKakezanResponce()
            {
                KakezanResult = result
            };

            // 生成したレスポンスを返す
            return responce;
        }
        #endregion "public methods"
    }
}
