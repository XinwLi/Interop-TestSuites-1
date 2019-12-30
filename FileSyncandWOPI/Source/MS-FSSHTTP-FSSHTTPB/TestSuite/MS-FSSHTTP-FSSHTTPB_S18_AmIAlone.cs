﻿namespace Microsoft.Protocols.TestSuites.MS_FSSHTTP_FSSHTTPB
{
    using Microsoft.Protocols.TestSuites.Common;
    using Microsoft.Protocols.TestSuites.SharedAdapter;
    using Microsoft.Protocols.TestSuites.SharedTestSuite;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// A class which contains test cases used to verify the AmIAlone sub request operation.
    /// </summary>
    [TestClass]
    public sealed class MS_FSSHTTP_FSSHTTPB_S18_AmIAlone : S18_AmIAlone
    {
        #region Test Suite Initialization

        /// <summary>
        /// A method used to initialize this class.
        /// </summary>
        /// <param name="testContext">A parameter represents the context of the test suite.</param>
        [ClassInitialize]
        public static new void ClassInitialize(TestContext testContext)
        {
            SharedTestSuiteBase.ClassInitialize(testContext);
        }

        /// <summary>
        /// A method used to clean up the test environment.
        /// </summary>
        [ClassCleanup]
        public static new void ClassCleanup()
        {
            SharedTestSuiteBase.ClassCleanup();
        }

        #endregion

                /// <summary>
        /// A method used to verify that AmIAlone sub-request failed.
        /// </summary>
        [TestCategory("MSFSSHTTP_FSSHTTPB"), TestMethod()]
        public void MSFSSHTTP_FSSHTTPB_TestCase_S18_TC01_AmIAlone_False()
        {
            // Initialize the service
            this.InitializeContext(this.DefaultFileUrl, this.UserName01, this.Password01, this.Domain);

            AmIAloneSubRequestType amIAlone = SharedTestSuiteHelper.CreateAmIAloneSubRequest();
            CellStorageResponse response = this.Adapter.CellStorageRequest(this.DefaultFileUrl, new SubRequestType[] { amIAlone });
            AmIAloneSubResponseType amIAloneResponse = SharedTestSuiteHelper.ExtractSubResponse<AmIAloneSubResponseType>(response, 0, 0, this.Site);
            SubResponseType subresponse = response.ResponseCollection.Response[0].SubResponse[0];

            if (SharedContext.Current.IsMsFsshttpRequirementsCaptured)
            {
                // Verify MS-FSSHTTP requirement: MS-FSSHTTP_R224912
                //Site.CaptureRequirementIfIsFalse(
                //    amIAloneResponse.SubResponseData.AmIAlone,
                //    "MS-FSSHTTP",
                //    224912,
                //    @"[In AmIAloneSubResponseDataType]AmIAlone: False means the user is not alone in the coauthoring session.");

                // Verify MS-FSSHTTP requirement: MS-FSSHTTP_R22522
                Site.CaptureRequirementIfAreNotEqual<string>(
                    GenericErrorCodeTypes.Success.ToString(),
                    subresponse.ErrorCode,
                    "MS-FSSHTTP",
                    22522,
                    @"[In AmIAloneSubResponseType]In the case of failure, the ErrorCode attribute that is part of a SubResponse element specifies the error code result for this subrequest. ");
            }
            else
            {
                Site.Assert.AreNotEqual<string>(
                    GenericErrorCodeTypes.Success.ToString(),
                    subresponse.ErrorCode,
                    "Error should occur if the user is not alone.");
            }
        }
        /// <summary>
        /// Initialize the shared context based on the specified request file URL, user name, password and domain for the MS-FSSHTTP test purpose.
        /// </summary>
        /// <param name="requestFileUrl">Specify the request file URL.</param>
        /// <param name="userName">Specify the user name.</param>
        /// <param name="password">Specify the password.</param>
        /// <param name="domain">Specify the domain.</param>
        protected override void InitializeContext(string requestFileUrl, string userName, string password, string domain)
        {
            SharedContextUtils.InitializeSharedContextForFSSHTTP(userName, password, domain, this.Site);
        }

        /// <summary>
        /// Merge the common configuration and should/may configuration file.
        /// </summary>
        /// <param name="site">An instance of interface ITestSite which provides logging, assertions,
        /// and adapters for test code onto its execution context.</param>
        protected override void MergeConfigurationFile(TestTools.ITestSite site)
        {
            ConfigurationFileHelper.MergeConfigurationFile(site);
        }
    }
}