using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decision.Tree.entity
{
    class Results
    {
        string nameResult;

        public Results(string name) {
            this.nameResult = name;
        }

        public string GetNameResult() {
            return this.nameResult;
        }
    }
}
