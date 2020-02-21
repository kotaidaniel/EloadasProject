using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace EloadasProject.Tests
{
    [TestFixture]
    class EloadasTest
    {
        [TestCase]
        public void UjEloadas()
        {
            Eloadas e = new Eloadas(10, 15);
        }
        [TestCase]
        public void UjFoglalas()
        {
            Eloadas e = new Eloadas(10, 15);
            e.Lefoglal();
        }
        [TestCase]
        public void UjFoglalas2()
        {
            Eloadas e = new Eloadas(10, 15);
            for (int i = 0; i < 3; i++)
            {
                e.Lefoglal();
            }
        }
        [TestCase]
        public void ujFoglalas3()
        {
            Eloadas e = new Eloadas(10, 15);
            for (int i = 0; i < 10; i++)
            {
                e.Lefoglal();
            }
            e.Foglalt(2, 3);
        }
        [TestCase]
        public void ujFoglalas4()
        {
            Eloadas e = new Eloadas(10, 15);
            for (int i = 0; i < 10; i++)
            {
                e.Lefoglal();
            }
            Assert.AreEqual(false, e.Foglalt(4, 2));
        }
        [TestCase]
        public void ujFoglalas5()
        {
            Eloadas e = new Eloadas(10, 15);
            for (int i = 0; i < 10; i++)
            {
                e.Lefoglal();
            }
            Assert.AreEqual(140, e.SzabadHelyekSzama());
        }
        [TestCase]
        public void ujFOglalas6()
        {
            Eloadas e = new Eloadas(10, 15);
            for (int i = 0; i < 150; i++)
            {
                e.Lefoglal();
            }
            Assert.AreEqual(true, e.Teli());
        }
    }
}
