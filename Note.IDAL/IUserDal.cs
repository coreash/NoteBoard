using Note.Model;
using System;
using System.Collections.Generic;

namespace Note.IDAL
{
    public interface IUserDal
    {
        List<User> GetUserList();
        User GetUser(int userNo);
    }
}
