using CountryList.Application;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CountryList.UnitTests
{
    class CheckDocTests
    {
        string[] can = ["USA", "CAN"];
        string[] usa = ["USA"];
        string[] mex = ["USA", "MEX"];
        string[] blz = ["USA", "MEX", "BLZ"];
        string[] gtm = ["USA", "MEX", "GTM"];
        string[] slv = ["USA", "MEX", "GTM", "SLV"];
        string[] hnd = ["USA", "MEX", "GTM", "HND"];
        string[] nic = ["USA", "MEX", "GTM", "HND", "NIC"];
        string[] cri = ["USA", "MEX", "GTM", "HND", "NIC", "CRI"];
        string[] pan = ["USA", "MEX", "GTM", "HND", "NIC", "CRI", "PAN"];


        [Test]
        public void can_checkDocuments_WhenCalled_SchouldReturnCorrectList()
        {
            var generator = new CheckDoc();
            var country = "can";
            var result = generator.checkDocuments(country);

            for (int i = 0; i < result.Length; i++)
                Assert.That(result[i], Is.EqualTo(can[i]));
        }

        [Test]
        public void usa_checkDocuments_WhenCalled_SchouldReturnCorrectList()
        {
            var generator = new CheckDoc();
            var country = "usa";
            var result = generator.checkDocuments(country);

            for (int i = 0; i < result.Length; i++)
                Assert.That(result[i], Is.EqualTo(usa[i]));
        }

        [Test]
        public void mex_checkDocuments_WhenCalled_SchouldReturnCorrectList()
        {
            var generator = new CheckDoc();
            var country = "mex";
            var result = generator.checkDocuments(country);

            for (int i = 0; i < result.Length; i++)
                Assert.That(result[i], Is.EqualTo(mex[i]));
        }

        [Test]
        public void blz_checkDocuments_WhenCalled_SchouldReturnCorrectList()
        {
            var generator = new CheckDoc();
            var country = "blz";
            var result = generator.checkDocuments(country);

            for (int i = 0; i < result.Length; i++)
                Assert.That(result[i], Is.EqualTo(blz[i]));
        }

        [Test]
        public void gtm_checkDocuments_WhenCalled_SchouldReturnCorrectList()
        {
            var generator = new CheckDoc();
            var country = "gtm";
            var result = generator.checkDocuments(country);

            for (int i = 0; i < result.Length; i++)
                Assert.That(result[i], Is.EqualTo(gtm[i]));
        }

        [Test]
        public void slv_checkDocuments_WhenCalled_SchouldReturnCorrectList()
        {
            var generator = new CheckDoc();
            var country = "slv";
            var result = generator.checkDocuments(country);

            for (int i = 0; i < result.Length; i++)
                Assert.That(result[i], Is.EqualTo(slv[i]));
        }

        [Test]
        public void nhd_checkDocuments_WhenCalled_SchouldReturnCorrectList()
        {
            var generator = new CheckDoc();
            var country = "hnd";
            var result = generator.checkDocuments(country);

            for (int i = 0; i < result.Length; i++)
                Assert.That(result[i], Is.EqualTo(hnd[i]));
        }

        [Test]
        public void nic_checkDocuments_WhenCalled_SchouldReturnCorrectList()
        {
            var generator = new CheckDoc();
            var country = "nic";
            var result = generator.checkDocuments(country);

            for (int i = 0; i < result.Length; i++)
                Assert.That(result[i], Is.EqualTo(nic[i]));
        }

        [Test]
        public void cri_checkDocuments_WhenCalled_SchouldReturnCorrectList()
        {
            var generator = new CheckDoc();
            var country = "cri";
            var result = generator.checkDocuments(country);

            for (int i = 0; i < result.Length; i++)
                Assert.That(result[i], Is.EqualTo(cri[i]));
        }

        [Test]
        public void pan_checkDocuments_WhenCalled_SchouldReturnCorrectList()
        {
            var generator = new CheckDoc();
            var country = "pan";
            var result = generator.checkDocuments(country);

            for (int i = 0; i < result.Length; i++)
                Assert.That(result[i], Is.EqualTo(pan[i]));
        }
    }
}
