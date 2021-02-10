using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace urlParse.Models
{
    class Url
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int? Age { get; set; }
        public string Token { get; set; }
        public string Host { get; set; }
        public string SessionId { get; set; }
        public string Language { get; set; }

        public Url(string url)
        {
            Uri myUri = new Uri(url);
            Id = int.Parse(HttpUtility.ParseQueryString(myUri.Query).Get("id"));
            FirstName = HttpUtility.ParseQueryString(myUri.Query).Get("name").Split(' ')[0];
            LastName = HttpUtility.ParseQueryString(myUri.Query).Get("name").Split(' ')[1];
            Age = string.IsNullOrEmpty(HttpUtility.ParseQueryString(myUri.Query).Get("age")) ? (int?)null : int.Parse(HttpUtility.ParseQueryString(myUri.Query).Get("age"));
            Token = HttpUtility.ParseQueryString(myUri.Query).Get("token");
            Host = HttpUtility.ParseQueryString(myUri.Query)[0];
            SessionId = HttpUtility.ParseQueryString(myUri.Query).Get("session_id");
            string culture = string.IsNullOrEmpty(HttpUtility.ParseQueryString(myUri.Query).Get("lang")) ? "en-GB" : HttpUtility.ParseQueryString(myUri.Query).Get("lang");
            Language = CultureInfo.GetCultureInfo(culture).EnglishName;
        }
    }
}
