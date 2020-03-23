 .\packages\OpenCover.4.7.922\tools\OpenCover.Console.exe -register:user -target:"C:\Program Files (x86)\Microsoft Visual Studio\2019\Enterprise\Common7\IDE\MSTest.exe" -targetargs:"/testcontainer:BddDo
mainTests\bin\Debug\BddDomainTests.dll  /resultsfile:.\results-mstest.xml" -filter:+[*]* -output:.\coverage.xml 

.\packages\ReportGenerator.3.1.2\tools\ReportGenerator.exe -reports:.\coverage.xml -targetdir:./coverage