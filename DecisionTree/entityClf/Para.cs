﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decision.Tree.entityClf
{
    class Para
    {
        int idHeader;
        string znach;

        public int GetIdHeader() {
            return idHeader;
        }

        public string GetZnach() {
            return znach;
        }

        public void SetIdHeader(int idHeader) {
            this.idHeader = idHeader;
        }

        public void SetZnach(string znach) {
            this.znach = znach;
        }
    }
}
