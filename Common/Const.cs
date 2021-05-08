using System;
using System.Collections.Generic;
using System.Text;

namespace Common
{
    /// <summary>
    /// 共通定義クラス
    /// ※全プロジェクト書くクラスで共通定義したいものをここに書く
    /// </summary>
    public static class Const
    {
        public const string SAMPLE = "SAMPLE";

        /// <summary>
        //  レスポンスに格納する処理結果フラグ
        /// </summary>
        public enum ResponceStatus : int
        {
            /// <summary>
            /// エラー発生
            /// </summary>
            Error = -1,

            /// <summary>
            /// 正常終了
            /// </summary>
            Ok = 0,
        }
    }
}
