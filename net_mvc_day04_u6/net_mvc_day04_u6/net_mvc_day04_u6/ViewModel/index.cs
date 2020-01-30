using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace net_mvc_day04_u6.ViewModel
{
    public class index
    {
        [DisplayName("必選修")]
        public string required01 { get; set; }
        [Required(ErrorMessage="學生姓名不得空白")]
        public string required02 { get; set; }
        [StringLength(10, ErrorMessage = "學生姓名必須介於2-10字元",MinimumLength =2)]
        public string required03 { get; set; }
        [Range(0, 100, ErrorMessage = "得分必須介於0~100之間")]
        public int point { get; set; }
        [System.Web.Mvc.Compare("re_password", ErrorMessage = "兩次密碼輸入不一致")]
        public string password { get; set; }
        public string re_password { get; set; }
        [RegularExpression(@"^[0-9]{2,4}-?[0-9]{3,4}-?[0-9]{-4}$", ErrorMessage = "請輸入正確的電話號碼")]
        public string phone { get; set; }
        [EmailAddress(ErrorMessage = "這不是E-maill格式")]
        public string studentmail { get; set; }
        [Url(ErrorMessage = "這不是網址標準模式")]
        public string url { get; set; }
        [FileExtensions(ErrorMessage = "所上傳檔案不是圖片")]
        public string file { get; set; }
        [CreditCard(ErrorMessage ="這不是信用卡格式")]
        public string creditCard { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime date { get; set; }
        [Remote("RemoteTest", "Home", ErrorMessage = "Remote屬性測試")]
        public string For_Remore { get; set; }      
    }
} 