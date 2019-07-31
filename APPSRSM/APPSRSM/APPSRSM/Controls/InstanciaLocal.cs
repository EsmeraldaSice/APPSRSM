using System;
using System.Collections.Generic;
using System.Text;

namespace APPSRSM.Controls
{
    using Models;
    public class InstanciaLocal
    {
        public MainModel Main
        { get;
            set;

        }
        public InstanciaLocal()
            {
            this.Main = new MainModel();
             }
    }
}
