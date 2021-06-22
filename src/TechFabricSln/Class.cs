using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TechFabricSln
{
    public class Class
    {
        public User madeby { get; set; }

        public bool BoughtBy(User user)
        {
            if (user.customer)
                return true;

            if (madeby == user)
                return true;

            return false;
        }
    }
    public class User
    {
        public bool customer { get; set; }
    }
}
