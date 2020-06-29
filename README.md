# PaymentAPIValidation
Payment api validation test using C# core, Specflow, BDD

Projecct platform: dot net core3.1
Recommended Visual Studio: "Microsoft Visual Studio Community 2019" (recommended version 16.5.1)

Open the "PaymentAPIValidation.sln" to run project

Add the following  NugetPackages in project ependencye

1. SpecFlow(recommended version: 3.3.30)
2. SpecRun.SpecFlow(recommended version: 3.3.30)
3. SpecFlow.Tools.MsBuild.Generation(recommended version: 3.3.30)

Follwoing packages should be included, if not then also add the followign NugetPackages

1. Microsoft.NET.Test.Sdk(recommended version: 16.6.1)
2. MSTest.TestAdapter(recommended version: 2.1.2)
3. MSTest.TestFramework(recommended version: 2.1.2)
4. coverlet.collector(recommended version: 1.3.0)

Feature file name: "APIValidationTest.feature"
Open the feature file and change the scenario as following

In Scenario "Request without a JWT token" keep the key field empty
In Scenario "Request with an invalid JWT token" provide invalid key
In all other Scenario, provide valid key.
In all Scenario put the provided api URL in api field.

Build the project and open Test Explorer, click "Run All Tests"



After running test from Test Explorer, open "TestResults" folder and open the test report by double click(html file). To see detailed log, open the correspondent log file in same location.
