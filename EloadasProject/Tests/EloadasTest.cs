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
        public void UjEloadasPozitivErtekekkelLefut()
        {
            Eloadas e = new Eloadas(10, 15);
        }
        [TestCase]
        public void UjEloadasNullaErtekekkelArgumentetDob()
        {
            Assert.Throws<ArgumentException>(() => { Eloadas e = new Eloadas(0, 0); });
        }
        [TestCase]
        public void UjEloadasKonstruktorNegativErtekekArgumentetDob()
        {
            Assert.Throws<ArgumentException>(() => { Eloadas e = new Eloadas(-1, -2); });
        }

        [TestCase]
        public void UjFoglalasLefoglalLefut()
        {
            Eloadas e = new Eloadas(10, 15);
            e.Lefoglal();
        }
        [TestCase]
        public void ujFoglalasFoglaltRosszErtekekkelFalsetDob()
        {
            Eloadas e = new Eloadas(10, 15);
            e.Lefoglal();
            
            Assert.AreEqual(false, e.Foglalt(2, 3));
        }
        [TestCase]
        public void ujFoglalasFoglaltNegativErtekekkelIndexOutOfRangeExceptiontDob()
        {
            Eloadas e = new Eloadas(10, 15);
            e.Lefoglal();
            Assert.Throws<IndexOutOfRangeException>(() => {
                Assert.AreEqual(false, e.Foglalt(-4, -2));
            });
        }
        [TestCase]
        public void ujFoglalasFoglaltJoErtekekkelTruetDob()
        {
            Eloadas e = new Eloadas(10, 15);
            e.Lefoglal();
            
            Assert.AreEqual(true, e.Foglalt(0, 0));
        }
        [TestCase]
        public void ujFoglalasSzabadHelyekSzamaJoErtekkelEgyenlo()
        {
            Eloadas e = new Eloadas(10, 15);
            for (int i = 0; i < 10; i++)
            {
                e.Lefoglal();
            }
            
            Assert.AreEqual(140, e.SzabadHelyekSzama());
        }
        [TestCase]
        public void ujFoglalasSzabadHelyekSzamaOsszesHelyLefoglalasUtanNullatDob()
        {
            Eloadas e = new Eloadas(10, 15);
            for (int i = 0; i < 150; i++)
            {
                e.Lefoglal();
            }
            Assert.AreEqual(0, e.SzabadHelyekSzama());
        }

        [TestCase]
        public void ujFoglalasTeliJoErtekkelTruetDob()
        {
            Eloadas e = new Eloadas(10, 15);
            for (int i = 0; i < 150; i++)
            {
                e.Lefoglal();
            }
            Assert.AreEqual(true, e.Teli());
        }
        [TestCase]
        public void ujFoglalasTeliRosszErtekkelFalsetDob()
        {
            Eloadas e = new Eloadas(10, 15);
            e.Lefoglal();
            
            Assert.AreEqual(false, e.Teli());
        }

        [TestCase]
        public void ujFoglalasSzabadhelyekSzamaEgyenloNullaval()
        {
            Eloadas e = new Eloadas(10, 15);
            for (int i = 0; i < 150; i++)
            {
                e.Lefoglal();
            }
            Assert.Zero(e.SzabadHelyekSzama());
        }


    }
}
