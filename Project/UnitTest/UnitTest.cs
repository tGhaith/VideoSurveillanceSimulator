using NUnit.Framework;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Project.Test
{
    [TestFixture]
    class UnitTest
    {
        [Test]
        public void testNewProject()
        {
            frmWorkSpace fws = new frmWorkSpace();
            fws.Show();
        }
        [Test]
        public void testCorrectionCoordonnee()
        {
            PrivateObject obj = new PrivateObject(typeof(frmWorkSpace));
            float result = (float)(obj.Invoke("correctionCoordonees", new object[]{ 5 , 10f }));
            NUnit.Framework.Assert.AreEqual(0.5, result);
        }
    }
}
