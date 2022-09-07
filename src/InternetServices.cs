using System;
using System.Runtime.InteropServices;

namespace WindowsInternet
{
    public static class InternetServices
    {
        public static SecurityInfo GetSecurityInfo(IntPtr internetHandle)
        {
            var securityInfo = new SecurityInfo();
            var bufferLength = (uint)Marshal.SizeOf<SecurityInfo>();
            InternetQueryOption(
                internetHandle, 66, ref securityInfo, ref bufferLength);

            return securityInfo;
        }

        [DllImport("wininet.dll", CharSet = CharSet.Unicode)]
        public static extern IntPtr InternetOpenUrl(
            IntPtr internet, string url, string headers, uint headerLength, uint flags, IntPtr context);

        [DllImport("wininet.dll", CharSet = CharSet.Unicode)]
        public static extern bool InternetQueryOption(
            IntPtr internet, uint option, ref SecurityInfo securityInfo, ref uint bufferLength);

        [DllImport("wininet.dll")]
        public static extern bool InternetCloseHandle(IntPtr internetHandle);

        [DllImport("wininet.dll", CharSet = CharSet.Unicode)]
        private static extern IntPtr InternetOpen(
            string agent, uint accessType, string proxy, string proxyBypass, uint flags);
    }
}
