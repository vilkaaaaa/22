using Xunit;
using EasyTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyTest.Tests
{
    public class LibraryTests
    {
        [Fact()]
        public void AddTest()
        {
            int a = 4;
            int b = 5;
            int res = 9;
            Library library = new Library();
            int actualres = library.Add(a, b);
            Assert.Equal(res, actualres);
        }

        [Fact()]
        public void SubTest()
        {
            int a = 20;
            int b = 12;
            int res = 8;
            Library library = new Library();
            int actualres = library.Sub(a, b);
            Assert.Equal(res, actualres);
        }

        [Fact()]
        public void SqrlTest()
        {
            double a = 16;
            double res = 4;
            Library library = new Library();
            double actualres = library.Sqrl(a);
            Assert.Equal(res, actualres);
        }

        [Fact()]
        public void PowTest()
        {
            int a = 4;
            int b = 2;
            int res = 16;
            Library library = new Library();
            int actulres= library.Pow(a, b);
            Assert.Equal(res, actulres);
        }

        [Fact()]
        public void DivisionTest()
        {
            int a = 18;
            int b = 6;
            int res = 3;
            Library library = new Library();
            int actulres = library.Division(a, b);
            Assert.Equal(res, actulres);
        }
    }
}