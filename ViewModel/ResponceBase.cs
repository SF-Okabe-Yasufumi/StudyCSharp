using System;
using System.Collections.Generic;
using System.Text;
using static Common.Const;

namespace ViewModel
{
    public class ResponceBase
    {
        /// <summary>
        /// レスポンス日時
        /// </summary>
        public DateTime ResponceTime { get; set; } = DateTime.Now;

        /// <summary>
        /// 処理結果
        ///  0: 正常終了
        /// -1: エラー
        /// </summary>
        public ResponceStatus Status { get; set; } = ResponceStatus.Ok;

        /// <summary>
        /// エラー発生時のエラーメッセージ
        /// </summary>
        public string ErrorMessage { get; set; }
    }
}
