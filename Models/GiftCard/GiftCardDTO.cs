﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fotoTeca.Models.GiftCard
{
    public class GiftCarResponse
    {
        public string api_Dice { get; set; }
        public int idGiftCard { get; set; }
        public string NameGiftCard { get; set; }
        public int idStatusGiftCard { get; set; }
        public string nameStatus { get; set; }
    }
    public class GiftCarResponse2
    {
        public int idGiftCard { get; set; }
        public string NameGiftCard { get; set; }
        public string reference { get; set; }
        public decimal value { get; set; }
        public int  idStatusGiftCard { get; set; }
        public string Status { get; set; }
        public string dateAdd { get; set; }
        public int IVA { get; set; }



    }
    public class GiftCarByCodeResponse
    {
        public int idGiftCard { get; set; }
        public decimal value { get; set; }
        public string DateExpiration { get; set; }
        public string idStatusGiftCard { get; set; }
        public string nameStatus { get; set; }
        public int balance { get; set; }
    }

    public class SalesGiftCardResponse
    {
        public int idOrder { get; set; }
        public string idGiftCard { get; set; }
        public string value { get; set; }
        public string dateAdd { get; set; }
        public string invoice { get; set; }

        public string idStatusPayOrder { get; set; }
        public string FullNameBuyer { get; set; }
        public string FullNameAddressee { get; set; }
        public string EamilBuyer { get; set; }
        public string EmailAddressee { get; set; }
        public string DateExpiration { get; set; }
        public string currentDate { get; set; }
        public string StatusPoll { get; set; }
        public string surveyResult { get; set; }
        public string StatusEmailSale { get; set; }
        public string NameStatus { get; set; }
        public string UsedGiftCard { get; set; }
        public string NamePromotion { get; set; }
        public string idPromotion { get; set; }
        public string idStatusOrder { get; set; }
        public string NameStatusOrder { get; set; }
        public string typeSale { get; set; }

    }

    public class GiftCarResqueride
    {
        public int idGiftCard { get; set; }
        public string NameGiftCard { get; set; }
        public string reference { get; set; }
        public decimal value { get; set; }
        public int IVA { get; set; }

    }

    public class dataPendign
    {
        public string email { get; set; }
        public string nombreResibe { get; set; }
        public string nombreComprador { get; set; }
        public string codeGitfCard { get; set; }
    }

    public class GiftCarStatusResqueride
    {
        public int idGiftCard { get; set; }
        public int idStatus { get; set; }
    }

   

}
