using System.Runtime.InteropServices;

namespace WindowsInternet
{
    /// <summary>
    /// Structure containing protocol and cipher information.
    /// </summary>
    public readonly struct SecurityInfo
    {
        /// <summary>
        /// Size of this structure in bytes.
        /// </summary>
        public readonly uint Size;

        /// <summary>
        /// Indicates whether the connection is secure.
        /// </summary>
        public readonly bool Secure;

        /// <summary>
        /// Gets a <see cref="ConnectionInfo"/> structure for this connection.
        /// </summary>
        public ConnectionInfo ConnectionInfo { get; }

        /// <summary>
        /// Gets a <see cref="CipherInfo"/> structure for this connection.
        /// </summary>
        public CipherInfo CipherInfo { get; }
    }
}
