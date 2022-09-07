using System.Runtime.InteropServices;

namespace WindowsInternet
{
    /// <summary>
    /// Structure containing cipher information.
    /// </summary>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct CipherInfo
    {
        /// <summary>
        /// The version.
        /// </summary>
        public readonly uint Version;

        /// <summary>
        /// The protocol.
        /// </summary>
        public readonly uint Protocol;

        /// <summary>
        /// The cipher suite.
        /// </summary>
        public readonly uint CipherSuite;

        /// <summary>
        /// The base cipher suite.
        /// </summary>
        public readonly uint BaseCipherSuite;

        /// <summary>
        /// The cipher suite.
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
        public readonly string CipherSuiteLabel;

        /// <summary>
        /// The cipher.
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
        public readonly string Cipher;

        /// <summary>
        /// The cipher length.
        /// </summary>
        public readonly uint CipherLength;

        /// <summary>
        /// The cipher block length in bytes.
        /// </summary>
        public readonly uint CipherBlockLength;

        /// <summary>
        /// The hash.
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
        public readonly string Hash;

        /// <summary>
        /// The hash length.
        /// </summary>
        public readonly uint HashLength;

        /// <summary>
        /// The exchange.
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
        public readonly string Exchange;

        /// <summary>
        /// The min exchange length.
        /// </summary>
        public readonly uint MinExchangeLength;

        /// <summary>
        /// The max exchange length.
        /// </summary>
        public readonly uint MaxExchangeLength;

        /// <summary>
        /// The certificate.
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
        public readonly string Certificate;

        /// <summary>
        /// The key type.
        /// </summary>
        public readonly uint KeyType;
    }
}
