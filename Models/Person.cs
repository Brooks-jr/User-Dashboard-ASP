using System.ComponentModel.DataAnnotations;
using System;
namespace userDashboardASP.Models
{
    public class Person : BaseEntity
    {

        public int id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string user_level { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }


    }
}
