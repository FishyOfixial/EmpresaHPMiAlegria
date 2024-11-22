using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaHPMiAlegria
{
    public class Usuario
    {
        int isOp, isBuy, isSys;

        public Usuario()
        {
            isOp = isBuy = isSys = 0;
        }
        public Usuario(int isOp, int isBuy, int isSys)
        {
            this.isOp = isOp;
            this.isBuy = isBuy;
            this.isSys = isSys;
        }

        #region getters y setters
        public int IsOp
        {
            get { return isOp; }
            set { isOp = value; }
        }

        public int IsBuy
        {
            get { return isBuy;  }
            set { isBuy = value; }
        }

        public int IsSys
        {
            get { return isSys; }
            set { isSys = value; }
        }
        #endregion
    }
}
