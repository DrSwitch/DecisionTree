using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decision.Tree.entity
{
    public class Header
    {
        string nameHeader;

        public Header(string name) {
            this.nameHeader = name;
        }

        public void SetNameHeader(string name) {
            this.nameHeader = name;
        }

        public string GetNameHeader() {
            return nameHeader;
        }

    }
}
