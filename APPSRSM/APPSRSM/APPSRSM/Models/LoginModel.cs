using System;
using System.Collections.Generic;
using System.Text;

namespace APPSRSM.Models
{
    #region models
    public class LoginModel
    {
        #region Propiedades
        public string usuario
        { get;
            set;
        }
        public string clave
        { get;
            set;
        }
        public bool corriendo
        { get;
            set;
        }
        public bool recordar
        { get;
            set;
        }
        #endregion
        #region Constructor
        public LoginModel()
        {
            this.recordar = true;
        }
        #endregion
    }
    #endregion
}
