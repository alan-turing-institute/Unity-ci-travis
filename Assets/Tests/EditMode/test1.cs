using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class test1
    {
        // A Test behaves as an ordinary method
        [Test]
        public void test1SimplePasses()
        {
            // Use the Assert class to test conditions
        }

        [Test]
        public void BasicTest()
        {


            bool isActive = false;
            Assert.AreEqual(false, isActive);
            //Assert.AreEqual(new Vector3(1, 1, 5), );

            Assert.AreEqual(3, addition.addstuff(1, 2));
            Assert.AreEqual(new Vector3(1, 1, 5), cube_rotate.get_object_position(new Vector3(1, 1, 5)));

        }

        [Test]
        [TestCase(1, 1, 5)]
        public void Test_cube_position(int x, int y, int z)
        {
            //Assert.AreEqual(new Vector3(1, 1, 5), cube_rotate.get_object_position(new Vector3(x, y, z)));
            Assert.AreEqual(new Vector3(1, 1, 1), cube_rotate.get_object_position(new Vector3(x, y, z)));
        }

        [Test]
        [TestCase(1, 1, 1)]
        [TestCase(1, 10, 5)]
        [TestCase(0, 0, 0)]
        public void Test_bad_cube_position(int x, int y, int z)
        {
            Assert.AreNotEqual(new Vector3(1, 1, 5), cube_rotate.get_object_position(new Vector3(x, y, z)));
        }


        // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
        // `yield return null;` to skip a frame.
        [UnityTest]
        public IEnumerator test1WithEnumeratorPasses()
        {
            // Use the Assert class to test conditions.
            // Use yield to skip a frame.
            yield return null;
        }
    }
}
