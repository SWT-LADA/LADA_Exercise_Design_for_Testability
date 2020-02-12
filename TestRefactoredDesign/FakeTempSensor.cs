using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Refactored_Design;

namespace TestRefactoredDesign
{
    class FakeTempSensor :ITempSensor
    {
        public int temp { get; set; }
        public int GetTemp()
        {
            return temp;
        }

        public bool RunSelfTest()
        {
            throw new NotImplementedException();
        }
    }
}
