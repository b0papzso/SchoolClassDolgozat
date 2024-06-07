using Microsoft.VisualStudio.TestTools.UnitTesting;
using SchoolClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolClass.Tests
{
    [TestClass()]
    public class SchoolDirectorRepoTests
    {
        [TestMethod()]
        public void GetMostExperiencedDirectorsNameTestEmptyDataBase()
        {
            SchoolDirectorRepo repo = new SchoolDirectorRepo();
            List<SchoolDirector> schoolDirectors = new List<SchoolDirector>();

            string actual = repo.GetMostExperiencedDirectorsName(schoolDirectors);
            string expected = "";
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void GetMostExperiencedDirectorsNameTestFirstMore()
        {
            SchoolDirectorRepo repo = new SchoolDirectorRepo();
            List<SchoolDirector> schoolDirectors = new List<SchoolDirector>
            {
                new SchoolDirector("Vezethetetlen Vilmos", new DateTime(2010, 10, 10), 22, 250000),
                new SchoolDirector("Irányíthatatlan Ida", new DateTime(2011, 11, 11), 11, 245000)
            };
            string actual = repo.GetMostExperiencedDirectorsName(schoolDirectors);
            string expected = "Vezethetetlen Vilmos";
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void GetMostExperiencedDirectorsNameTestSecondMore()
        {
            SchoolDirectorRepo repo = new SchoolDirectorRepo();
            List<SchoolDirector> schoolDirectors = new List<SchoolDirector>
            {
                new SchoolDirector("Vezethetetlen Vilmos", new DateTime(2010, 10, 10), 22, 250000),
            new SchoolDirector("Irányíthatatlan Ida", new DateTime(2011, 11, 11), 33, 245000)
            };
            string actual = repo.GetMostExperiencedDirectorsName(schoolDirectors);
            string expected = "Irányíthatatlan Ida";
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void GetMostExperiencedDirectorsNameTestEqual()
        {
            SchoolDirectorRepo repo = new SchoolDirectorRepo();
            List<SchoolDirector> schoolDirectors = new List<SchoolDirector>
            {
                new SchoolDirector("Vezethetetlen Vilmos", new DateTime(2010, 10, 10), 22, 250000),
            new SchoolDirector("Irányíthatatlan Ida", new DateTime(2011, 11, 11), 22, 245000)
            };
            string actual = repo.GetMostExperiencedDirectorsName(schoolDirectors);
            string expected = "Ugyanannyira tapasztaltak";
            Assert.AreEqual(expected, actual);
        }
    }
}