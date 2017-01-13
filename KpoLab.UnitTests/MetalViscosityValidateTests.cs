using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using KpoLab.Lib;

namespace KpoLab.UnitTests
{
    [TestFixture]
    public class MetalViscosityValidateTests
    {
        #region Проверка поля "Вещество"
        [Test]
        public void EmptyName()
        {
            var item = new MetalViscosity()
            {
                Name = "",
                AtomicNumber = 1,
                Temperature = 10,
                Viscosity = 2.5
            };

            Assert.IsFalse(MetalViscosityHelper.ValidateFields(item));
        }

        [Test]
        public void NullName()
        {
            var item = new MetalViscosity()
            {
                Name = null,
                AtomicNumber = 1,
                Temperature = 10,
                Viscosity = 2.5
            };

            Assert.IsFalse(MetalViscosityHelper.ValidateFields(item));
        }

        [Test]
        public void WhiteSpaceName()
        {
            var item = new MetalViscosity()
            {
                Name = " ",
                AtomicNumber = 1,
                Temperature = 10,
                Viscosity = 2.5
            };

            Assert.IsFalse(MetalViscosityHelper.ValidateFields(item));
        }

        [Test]
        public void ExceededMaxLengthName()
        {
            var item = new MetalViscosity()
            {
                Name = "12345678901234567890123456789012345",
                AtomicNumber = 1,
                Temperature = 10,
                Viscosity = 2.5
            };

            Assert.IsFalse(MetalViscosityHelper.ValidateFields(item));
        }

        [Test]
        public void CorrectName()
        {
            var item = new MetalViscosity()
            {
                Name = "Корректное значение",
                AtomicNumber = 1,
                Temperature = 10,
                Viscosity = 2.5
            };

            Assert.IsTrue(MetalViscosityHelper.ValidateFields(item));
        }
        #endregion

        #region Проверка поля "Атомный номер"
        [Test]
        public void LessThanZeroAtomicNumber()
        {
            var item = new MetalViscosity()
            {
                Name = "Вещество",
                AtomicNumber = -1,
                Temperature = 10,
                Viscosity = 2.5
            };

            Assert.IsFalse(MetalViscosityHelper.ValidateFields(item));
        }

        [Test]
        public void ZeroAtomicNumber()
        {
            var item = new MetalViscosity()
            {
                Name = "Вещество",
                AtomicNumber = 0,
                Temperature = 10,
                Viscosity = 2.5
            };

            Assert.IsFalse(MetalViscosityHelper.ValidateFields(item));
        }

        [Test]
        public void OneAtomicNumber()
        {
            var item = new MetalViscosity()
            {
                Name = "Вещество",
                AtomicNumber = 1,
                Temperature = 10,
                Viscosity = 2.5
            };

            Assert.IsTrue(MetalViscosityHelper.ValidateFields(item));
        }

        [Test]
        public void CorrectAtomicNumber()
        {
            var item = new MetalViscosity()
            {
                Name = "Вещество",
                AtomicNumber = 1,
                Temperature = 10,
                Viscosity = 2.5
            };

            Assert.IsTrue(MetalViscosityHelper.ValidateFields(item));
        }
        #endregion

        #region Проверка поля "Температура"
        [Test]
        public void LessThanAbsoluteNullTemperature()
        {
            var item = new MetalViscosity()
            {
                Name = "Вещество",
                AtomicNumber = 1,
                Temperature = -1000,
                Viscosity = 2.5
            };

            Assert.IsFalse(MetalViscosityHelper.ValidateFields(item));
        }

        [Test]
        public void AbsoluteNullTemperature()
        {
            var item = new MetalViscosity()
            {
                Name = "Вещество",
                AtomicNumber = 1,
                Temperature = -273,
                Viscosity = 2.5
            };

            Assert.IsTrue(MetalViscosityHelper.ValidateFields(item));
        }

        [Test]
        public void CorrectTemperature()
        {
            var item = new MetalViscosity()
            {
                Name = "Вещество",
                AtomicNumber = 1,
                Temperature = 1000,
                Viscosity = 2.5
            };

            Assert.IsTrue(MetalViscosityHelper.ValidateFields(item));
        }
        #endregion
    }
}
