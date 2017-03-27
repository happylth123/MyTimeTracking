using MyTimeTracking.DMSSite.BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MyTimeTracking.DMSSite.BLL.Extensions
{
    public static partial class ModelMapping
    {
        public static class Express
        {
            public static Expression<Func<Data.Models.User, User>> ToBLLUser()
            {
                return model => new User
                {
                    ID = model.ID,
                    Email = model.Email,
                    UserName = model.UserName,
                    PassWord = model.PassWord,
                    UserType = model.UserType,
                    ProfileGravatar = model.ProfileGravatar,
                    CreatedOn = model.CreatedOn,
                    UpdateOn = model.UpdateOn,
                    IsDeleted = model.IsDeleted,
                    DeletedOn = model.DeletedOn
                };
            }
        }
    }
}
