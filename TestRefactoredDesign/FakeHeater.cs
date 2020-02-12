using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Refactored_Design;

namespace TestRefactoredDesign
{
    class FakeHeater : IHeater
    {
        public bool isOn;
        public bool RunSelfTest()
        {
            throw new NotImplementedException();
        }

        public void TurnOff()
        {
            isOn = false;
        }

        public void TurnOn()
        {
            isOn = true;
        }
    }
}
