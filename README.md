# PaymentAPIValidation
Payment api validation test using C# core, Specflow, BDD

Project platform: dot net core3.1
Recommended Visual Studio: "Microsoft Visual Studio Community 2019" (recommended version 16.5.1)

Instructions to Run the project:

1.	Open the "PaymentAPIValidation.sln" to run project
2.	 Check if the following NugetPackages are intalled in Dependencies. If not then, add the following  NugetPackages in project dependencies
     a.	SpecFlow(recommended version: 3.3.30)
     
     b.	SpecRun.SpecFlow(recommended version: 3.3.30)
     
     c.	SpecFlow.Tools.MsBuild.Generation(recommended version: 3.3.30)
     
Following packages should also be included, if not then also add the following NugetPackages

     a.	Microsoft.NET.Test.Sdk(recommended version: 16.6.1)
     
     b.	MSTest.TestAdapter(recommended version: 2.1.2)
     
     c.	MSTest.TestFramework(recommended version: 2.1.2)
     
     d.	coverlet.collector(recommended version: 1.3.0)

3.	Open the feature file (Feature file name: "APIValidationTest.feature") and change the scenario as following

     a.	In Scenario "Request without a JWT token" keep the key field empty
     
     b.	In Scenario "Request with an invalid JWT token" provide invalid key
     
     c.	In all other Scenario, provide valid key.
     
     d.	In all Scenario put the provided api URL in api field.
     
4.	To run Test Cases, in Test Explorer, click "Run All Tests"

5.	After running test from Test Explorer, open "TestResults" folder and open the test report by double click (html file). To see detailed log, open the correspondent log file in same location.

