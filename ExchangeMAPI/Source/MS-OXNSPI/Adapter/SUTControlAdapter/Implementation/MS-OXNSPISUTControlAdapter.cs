using Microsoft.Protocols.TestTools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.Protocols.TestSuites.MS_OXNSPI
{
    public class MS_OXNSPISUTControlAdapter : ManagedAdapterBase, IMS_OXNSPISUTControlAdapter
    {
        /// <summary>
        /// Initialize the adapter.
        /// </summary>
        /// <param name="testSite">Test site.</param>
        public override void Initialize(ITestSite testSite)
        {
            base.Initialize(testSite);
        }

        public uint GetNumberOfAddressBookObject()
        {
            return 102;
        }
    }
}
