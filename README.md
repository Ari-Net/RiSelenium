# Ari_Selenium #
***8 solutions for feauture file on C#***

Each class file is a solution for scenarios from feature file.
There is no POM here.
From 8 scenarios 7 passed and 1 failed.
In failed test I try to get "Careers" element on [EPAM](https://www.epam.com/ "Click to open") with all tree callings, but get next "because of System.NullReferenceException : Object reference not set to an instance of an object".
***
###   System requirenments   ###
* Runs on Lenovo with Windows10
* Requires Microsoft Visual Studio 2019
* Automation API WebDriver
* Testing Framework NUnit
* Browser Google Chrome 87.0.4280.88
* WebDriver ChromeDriver 87.0.4280.88
* Requires C# version="v4.0" sku=".NETFramework,Version=v4.7.2"
* Internet connection
***
###  Requires the following packages  ###
|Id                             |Versions        |
|-------------------------------|----------------|
|NUnit                          |{3.12.0}        |    
|NUnit3TestAdapter              |{3.17.0}        |  
|Selenium.WebDriver             |{3.141.0}       |     
|Selenium.WebDriver.ChromeDriver|{87.0.4280.8800}|
***
###   Running   ###
1. Install Visual Stusio 2019
2. Install next Workloads: Universal Windows Platforms development, .NET desktop developement
3. Create Console App(.NET Framework) project
4. Install packages from NuGet Package Manager
5. Make right click on your project name in Solution Explorer
6. Select "Properties", then change Output type to Class Library
7. Place classes files in your home directory
8. Open TestExplorer and click "Run" to check tests (there is one failed - number 5)
