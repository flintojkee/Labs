﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_CSharp_Vasylenko
{
    static class CalcAgeAdapter
    {
        internal static User CreateUser(DateTime date)
        {
            User user;
            try
            {
                user = new User(date);
            }
            catch (Exception)
            {
                return null;
            }
            return user;
        }
    }
}
