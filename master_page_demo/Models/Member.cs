using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace master_page_demo.Models
{
    public class Member
    {
        public String first_name { get; set; }
        public String last_name { get; set; }
        public String email_id { get; set; }
        public String address { get; set; }
        public string gender { get; set; }
        public int age { get; set; }
        public string password { get; set; }
        public string conf_password { get; set; }
        public string phone_no { get; set; }
      

    }
}