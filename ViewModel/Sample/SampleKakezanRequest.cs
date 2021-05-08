using System;
using System.Collections.Generic;
using System.Text;

namespace ViewModel.Sample
{
    public class SampleKakezanRequest : RequestBase
    {
        /// <summary>
        /// 掛け算引数１
        /// </summary>
        public int KakezanHikisuuOne { get; set; }

        /// <summary>
        /// 掛け算引数２
        /// </summary>
        public int KakezanHikisuuTwo { get; set; }
    }
}
