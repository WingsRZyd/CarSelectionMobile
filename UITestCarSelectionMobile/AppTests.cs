﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace UITestCarSelectionMobile
{
    [TestFixture(Platform.Android)]
    [TestFixture(Platform.iOS)]
    public class AppTests
    {
        IApp app;
        Platform platform;

        public AppTests(Platform platform)
        {
            this.platform = platform;
        }

        [SetUp]
        public void BeforeEachTest()
        {
            app = AppInitializer.StartApp(platform);
        }

        [Test]
        public void TestMethod1()
        {
            Assert.IsTrue(true);
        }
    }
}