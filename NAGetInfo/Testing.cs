using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Compatibility;
using NUnit.Framework;


namespace NAGetInfo
{
    [TestFixture]
    public class Testing
    {
        [SetUp]
        public Record GetAllData()
        {
            Record fullyPopulated = new Record();
            fullyPopulated.title = "Some Title";
            fullyPopulated.scopeContent.description = "Some description";
            fullyPopulated.citableReference = "ABCD";
            return fullyPopulated;

        }
        public Record GetDescriptiontData()
        {
            Record decriptionPopulated = new Record();
            decriptionPopulated.title = null;
            decriptionPopulated.scopeContent.description = "Some description";
            decriptionPopulated.citableReference = "ABCD";
            return decriptionPopulated;

        }

        public Record GetReferenceData()
        {
            Record decriptionPopulated = new Record();
            decriptionPopulated.title = null;
            decriptionPopulated.scopeContent.description = null;
            decriptionPopulated.citableReference = "ABCD";
            return decriptionPopulated;
        }

        public Record GetNoData()
        {
            Record decriptionPopulated = new Record();
            decriptionPopulated.title = null;
            decriptionPopulated.scopeContent.description = null;
            decriptionPopulated.citableReference = null;
            return decriptionPopulated;
        }


        [Test]
        [Category("pass")]
        public void UseTitle()
        {
            string expected = "Some Title";
            Record r = new Record();
            r = GetAllData();
            string output = (string)r.title ?? r.scopeContent.description ?? r.citableReference ?? "Not Sufficient Info";

            Assert.AreEqual(output, expected);
        }
        
        [Test]
        [Category("pass")]
        public void UseDecription()
        {
            string expected = "Some description";
            Record r = new Record();
            r = GetDescriptiontData();
            string output = (string)r.title ?? r.scopeContent.description ?? r.citableReference ?? "Not Sufficient Info";

            Assert.AreEqual(output, expected);
        }

        [Test]
        [Category("pass")]
        public void UseReference()
        {
            string expected = "ABCD";
            Record r = new Record();
            r = GetReferenceData();
            string output = (string)r.title ?? r.scopeContent.description ?? r.citableReference ?? "Not Sufficient Info";
            Assert.AreEqual(output, expected);
        }

        [Test]
        [Category("pass")]
        public void NotEnoughInfo()
        {
            string expected = "Not Sufficient Info";
            Record r = new Record();
            r = GetNoData();
            string output = (string)r.title ?? r.scopeContent.description ?? r.citableReference ?? "Not Sufficient Info";
            Assert.AreEqual(output, expected);
        }

    }
}
