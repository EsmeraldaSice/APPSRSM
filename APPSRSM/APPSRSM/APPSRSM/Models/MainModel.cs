using System;
using System.Collections.Generic;
using System.Text;

namespace APPSRSM.Models
{
    public class MainModel
    {
        #region model
        public LoginModel login
        {
            get;
            set;
        }
        #endregion
        public MainModel()
        {
            this.login = new LoginModel();
        }
    }
}
