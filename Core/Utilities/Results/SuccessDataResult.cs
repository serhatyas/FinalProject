using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class SuccessDataResult<T>:DataResult<T>
    {
        //DEFAULT Datanın varsayılan değerini döndürür

        //TÜM BİLGİLERİ VERDİĞİ VERSİYON DATA, MESAJ, İŞLEM SONUCU(DEFAULT TRUE)
        public SuccessDataResult(T data, string message):base(data,true,message)
        {

        }

        //MESAJSIZ VERSİYON
        public SuccessDataResult(T data) : base(data, true)
        {

        }

        //SADECE MESAJ (DATA DEFAULT OLARAK BİR ŞEY DÖNDÜRMEK İSTEMYEBİLİRSİN)
        public SuccessDataResult(string message) : base(default, true, message)
        {

        }

        //HİÇ BİR ŞEY VERMEK İSTEMİYORSAN
        public SuccessDataResult() : base(default, true)
        {

        }
    }
}
