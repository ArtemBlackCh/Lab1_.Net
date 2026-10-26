using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab1_.Net;

namespace Lab2_UnitTests
{
    [TestClass]
    public class CircleSectorTest
    {
        private const double Delta = 1e-9;

        [TestMethod]
        public void Area_quarter_circle()
        {
            var sector = new CircleSector(2, 0, 90);
            var testRes = Math.PI;
            var res = sector.CalculateArea();
            Assert.AreEqual(testRes, res, Delta);
        }

        [TestMethod]
        public void Area_full_circle()
        {
            var sector = new CircleSector(3, 0, 360);
            var testRes = 9 * Math.PI;
            var res = sector.CalculateArea();
            Assert.AreEqual(testRes, res, Delta);
        }

        [TestMethod]
        public void Area_negative_start_angle()
        {
            var sector = new CircleSector(6, -30, 30);
            var testRes = 6 * Math.PI;
            var res = sector.CalculateArea();
            Assert.AreEqual(testRes, res, Delta);
        }

        [TestMethod]
        public void Area_zero_delta()
        {
            var sector = new CircleSector(5, 45, 45);
            var res = sector.CalculateArea();
            Assert.AreEqual(0, res, Delta);
        }

        [TestMethod]
        public void Length_quarter_circle()
        {
            var sector = new CircleSector(2, 0, 90);
            var testRes = Math.PI;
            var res = sector.CalculateLength();
            Assert.AreEqual(testRes, res, Delta);
        }

        [TestMethod]
        public void Length_full_circle()
        {
            var sector = new CircleSector(3, 0, 360);
            var testRes = 6 * Math.PI;
            var res = sector.CalculateLength();
            Assert.AreEqual(testRes, res, Delta);
        }

        [TestMethod]
        public void Length_fractional_values()
        {
            var sector = new CircleSector(1.5, 10.5, 40.5);
            var testRes = Math.PI * 1.5 * 30 / 180;
            var res = sector.CalculateLength();
            Assert.AreEqual(testRes, res, Delta);
        }

        [TestMethod]
        public void ContainsAngle_inside()
        {
            var sector = new CircleSector(1, 30, 120);
            Assert.IsTrue(sector.ContainsAngle(60));
        }

        [TestMethod]
        public void ContainsAngle_boundaries_are_included()
        {
            var sector = new CircleSector(1, 30, 120);
            Assert.IsTrue(sector.ContainsAngle(30));
            Assert.IsTrue(sector.ContainsAngle(120));
        }

        [TestMethod]
        public void ContainsAngle_outside()
        {
            var sector = new CircleSector(1, 30, 120);
            Assert.IsFalse(sector.ContainsAngle(29.999));
            Assert.IsFalse(sector.ContainsAngle(120.001));
            Assert.IsFalse(sector.ContainsAngle(-60));
        }

        [TestMethod]
        public void Radius_zero_throws()
        {
            Assert.ThrowsExactly<ArgumentException>(() => new CircleSector(0, 0, 90));
        }

        [TestMethod]
        public void Radius_negative_throws()
        {
            Assert.ThrowsExactly<ArgumentException>(() => new CircleSector(-1, 0, 90));
        }

        [TestMethod]
        public void Alpha2_less_than_alpha1_throws()
        {
            Assert.ThrowsExactly<ArgumentException>(() => new CircleSector(1, 90, 30));
        }

        [TestMethod]
        public void Delta_more_than_360_throws()
        {
            Assert.ThrowsExactly<ArgumentException>(() => new CircleSector(1, 0, 360.5));
        }

        [TestMethod]
        public void Nan_angle_throws()
        {
            Assert.ThrowsExactly<ArgumentException>(() => new CircleSector(1, double.NaN, 90));
        }

        [TestMethod]
        public void Angles_changed_to_invalid_values_throw_on_calculation()
        {
            var sector = new CircleSector(1, 0, 90);
            sector.Alpha1 = 200;
            Assert.ThrowsExactly<ArgumentException>(() => sector.CalculateArea());
            Assert.ThrowsExactly<ArgumentException>(() => sector.CalculateLength());
            Assert.ThrowsExactly<ArgumentException>(() => sector.ContainsAngle(10));
        }

        [TestMethod]
        public void Constructor_default_values()
        {
            var sector = new CircleSector();
            Assert.AreEqual(1, sector.Radius, Delta);
            Assert.AreEqual(0, sector.Alpha1, Delta);
            Assert.AreEqual(90, sector.Alpha2, Delta);
            Assert.AreEqual(90, sector.DeltaAngle, Delta);
        }

        [TestMethod]
        public void Constructor_one_parameter_radius()
        {
            var sector = new CircleSector(4);
            var res = sector.CalculateArea();
            Assert.AreEqual(4, sector.Radius, Delta);
            Assert.AreEqual(0, sector.Alpha1, Delta);
            Assert.AreEqual(90, sector.Alpha2, Delta);
            Assert.AreEqual(4 * Math.PI, res, Delta);
        }

        [TestMethod]
        public void Properties_set_and_calculate()
        {
            var sector = new CircleSector();
            sector.Radius = 2;
            sector.Alpha2 = 180;
            Assert.AreEqual(2, sector.Radius, Delta);
            Assert.AreEqual(180, sector.DeltaAngle, Delta);
            Assert.AreEqual(2 * Math.PI, sector.CalculateArea(), Delta);
        }
    }
}
