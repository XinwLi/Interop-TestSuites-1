namespace Microsoft.Protocols.TestSuites.SharedAdapter
{
    using Microsoft.Protocols.TestTools;

    /// <summary>
    /// SUT control adapter interface.
    /// </summary>
    public interface IMS_FSSHTTP_FSSHTTPBSUTControlAdapter : IAdapter
    {
        /// <summary>
        /// This method is used to set the maximum number of clients allowed to join a coauthoring session.
        /// </summary>
        /// <param name="count">The maximum number of clients allowed to join a co-authoring session.</param>
        /// <returns>Return true if set max number of clients succeed, otherwise return false.</returns>
        [MethodHelp(@"Change the maximum number of clients allowed to join a coauthoring session to the specified parameter(count)." +
                     "If the operation succeeds, enter true; otherwise, enter false.")]
        bool SetMaxNumOfCoauthUsers(int count);

        /// <summary>
        /// This method is used to change the status of the document library whether needs to check out the files before editing or locking.
        /// </summary>
        /// <param name="isCheckoutRequired">Indicating whether the doc library requires checking out files or not.</param>
        /// <returns>Return true if the operation succeeds, otherwise returns false.</returns>
        [MethodHelp(@"If the specified parameter (isCheckoutRequired) is true, change the status of the document library to require file checkout before editing or locking; otherwise, change the status of the document library to not require file checkout." +
                      "If the operation succeeds, enter true; otherwise, enter false.")]
        bool ChangeDocLibraryStatus(bool isCheckoutRequired);

        /// <summary>
        /// This method is used to change the status of the document library whether the coauthoring feature is disabled. 
        /// </summary>
        /// <param name="isDisabled">Specify whether disable the coauthoring feature. If true then disable the coauthoring feature, otherwise enable the coauthoring feature.</param>
        /// <returns>Return true if the operation succeeds, otherwise returns false.</returns>
        [MethodHelp(@"If the specified parameter (isDisabled) is true, disable the coauthoring feature; otherwise, enable the feature." +
                      "If the operation succeeds, enter true; otherwise, enter false.")]
        bool SwitchCoauthoringFeature(bool isDisabled);

        /// <summary>
        /// This method is used to get the GUID of the specified list name.
        /// </summary>
        /// <param name="listName">A specified list name in the server.</param>
        /// <returns>The GUID of the list.</returns>
        [MethodHelp("Enter the GUID for the specified listName parameter.")]
        string GetListGuidByName(string listName);

        /// <summary>
        /// This method is used to turn on/turn off the cell storage service.
        /// </summary>
        /// <param name="isEnabled">Specify whether the cell storage service is turned on or turned off. True indicates the cell storage service is turned on, otherwise the service is turned off.</param>
        /// <returns>Return true if the operation succeeds, otherwise returns false.</returns>        
        [MethodHelp(@"If the specified parameter (isEnabled) is true, turn on the cell storage service; otherwise, turn off the service." +
                      "If the operation succeeds, enter true; otherwise, enter false.")]
        bool SwitchCellStorageService(bool isEnabled);

        /// <summary>
        /// This method is used to change the authentication mode to windows/claims based authentication.
        /// </summary>
        /// <param name="isClaimsAuthentication">Specify the authentication mode. True indicates the claims based authentication, false indicates the windows based authentication.</param>
        /// <returns>Return true if the operation succeeds, otherwise returns false.</returns>
        [MethodHelp(@"If the specified parameter (isClaimsAuthentication) is true, change the authentication mode to claims-based authentication; otherwise, change the authentication mode to Windows authentication." +
                      "If the operation succeeds, enter true; otherwise, enter false.")]
        bool SwitchClaimsAuthentication(bool isClaimsAuthentication);

        /// <summary>
        /// This method is used to turn on and turn off the versioning of the document library.
        /// </summary>
        /// <param name="documentLibraryName">Specify the document library name.</param>
        /// <param name="isEnable">Whether turn on or turn off the versioning of the document library. True indicates turning on the versioning of this document library, false indicates turning off the versioning.</param>
        /// <returns>Return true if the operation succeeds, otherwise returns false.</returns>
        [MethodHelp(@"If the specified parameter (isEnabled) is true, turn on the versioning feature of the specified (documentLibraryName); otherwise, turn off versioning." +
                      "If the operation succeeds, enter true; otherwise, enter false.")]
        bool SwitchMajorVersioning(string documentLibraryName, bool isEnable);

        /// <summary>
        /// Add a file into the specified Document Library list on the SUT.
        /// </summary>
        /// <param name="documentLibraryUrl">The url of the Document Library list where the file will be added.</param>
        /// <param name="fileName">The name of the file.</param>
        /// <returns>A return value represents the absolute URL of the file on the specified Document library list if succeed, otherwise return null.</returns>
        [MethodHelp("Add a file (fileName) with any content into the document library (documentLibraryUrl). If the operation succeeds, enter true; otherwise, enter false.")]
        bool UploadTextFile(string documentLibraryUrl, string fileName);
    }
}