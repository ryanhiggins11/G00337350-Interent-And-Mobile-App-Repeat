using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace RepeatProject.Model
{
    class Token
    {
        public int Id { get; set; }
        public string Access_token { get; set; }
        public String Error_description { get; set; }
        public DateTime Expire_date { get; set; }

        public Token() { }
    }
}