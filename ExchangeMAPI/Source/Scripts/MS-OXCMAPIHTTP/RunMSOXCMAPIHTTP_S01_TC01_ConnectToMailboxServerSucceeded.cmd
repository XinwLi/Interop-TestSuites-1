@echo off
pushd %~dp0
"C:\Program Files (x86)\Microsoft Visual Studio\2017\Enterprise\Common7\IDE\mstest" /test:Microsoft.Protocols.TestSuites.MS_OXCMAPIHTTP.S01_RequestTypesForMailboxServerEndpoint.MSOXCMAPIHTTP_S01_TC01_ConnectToMailboxServerSucceeded /testcontainer:..\..\MS-OXCMAPIHTTP\TestSuite\bin\Debug\MS-OXCMAPIHTTP_TestSuite.dll /runconfig:..\..\MS-OXCMAPIHTTP\MS-OXCMAPIHTTP.testsettings /unique
pause