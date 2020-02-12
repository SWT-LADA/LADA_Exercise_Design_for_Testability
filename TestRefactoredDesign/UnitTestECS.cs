using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Refactored_Design;

namespace TestRefactoredDesign
{[TestFixture]
    public class UnitTestECS
    {
        private ECS uut;
        private FakeHeater heater;
        private FakeTempSensor tempSensor;

        [SetUp]
        public void SetUp()
        {
            heater = new FakeHeater();
            tempSensor = new FakeTempSensor();
            uut = new ECS(28, tempSensor, heater);
        }

        [TestCase(5, true)]
        [TestCase(28,false)]
        [TestCase(30,false)]
        [TestCase(22,true)]
        [TestCase(20,true)]
        [TestCase(21, true)]


        //Interaction based test: tester om uut har interageret korrekt med vores fake
        public void TestRegulate(int temp, bool res)
        {
            tempSensor.temp = temp;
            uut.Regulate();
            Assert.That(heater.isOn,Is.EqualTo(res));
        }
    }
}
