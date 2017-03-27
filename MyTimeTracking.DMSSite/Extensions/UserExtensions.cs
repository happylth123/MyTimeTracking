using MyTimeTracking.DMSSite.BLL.Models;
using MyTimeTracking.DMSSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyTimeTracking.DMSSite.Extensions
{
    public static partial class UserExtensions
    {
        public static UserVM ToViewModel(this User domainModel)
        {
            if (domainModel == null)
            {
                return new UserVM();
            }

            var viewModel = new UserVM()
            {
                ID = domainModel.ID,
                Email = domainModel.Email,
                UserName = domainModel.UserName,
                PassWord = domainModel.PassWord,
                UserType = domainModel.UserType,
                ProfileGravatar = domainModel.ProfileGravatar,
                CreatedOn = domainModel.CreatedOn,
                UpdateOn = domainModel.UpdateOn,
                IsDeleted = domainModel.IsDeleted,
                DeletedOn = domainModel.DeletedOn


            };
            return viewModel;
        }
    }
}