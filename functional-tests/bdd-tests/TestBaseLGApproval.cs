﻿using Microsoft.Extensions.Configuration;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.UI;
using Protractor;
using System;
using Xunit;
using Xunit.Abstractions;
using Xunit.Gherkin.Quick;
using Microsoft.Extensions.Configuration.UserSecrets;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Runtime.CompilerServices;

namespace bdd_tests
{
    public abstract partial class TestBase : Feature, IDisposable
    {
        [And(@"I approve the application for a (.*)")]
        public void ApproveApplication(string applicationType)
        {
            if (applicationType == "picnic area")
            {

            }
        }


        [And(@"I read the response from the local government")]
        public void ReadResponse()
        {

        }


        [And(@"I specify that the zoning allows the endorsement")]
        public void ZoningAllowsEndorsement()
        {

        }


        [And(@"I specify my contact details")]
        public void SpecifyContactDetails()
        {

        }


        [And(@"I review the local government")]
        public void ReviewLocalGovernment()
        {

        }


        [And(@"the dashboard status is updated as (.*)")]
        public void DashboardStatus(string status)
        {
            if (status == "Application Under Review")
            { 
            
            }
        }
    }
}