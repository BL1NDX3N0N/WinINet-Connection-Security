namespace WindowsInternet
{
    /// <summary>
    /// Specifies constants that represent a protocol.
    /// </summary>
    [System.Flags]
    public enum Protocol : uint
    {
        SP_PROT_NONE = 0,

        /// <summary>
        /// Private Communications Technology 1.0 server-side.
        /// </summary>
        SP_PROT_PCT1_SERVER = 1,

        /// <summary>
        /// Private Communications Technology 1.0 client-side.
        /// </summary>
        SP_PROT_PCT1_CLIENT = 2,

        /// <summary>
        /// Private Communications Technology 1.0.
        /// </summary>
        SP_PROT_PCT1 = SP_PROT_PCT1_SERVER | SP_PROT_SSL2_CLIENT,

        /// <summary>
        /// Secure Sockets Layer 2.0 server-side.
        /// </summary>
        SP_PROT_SSL2_SERVER = 4,

        /// <summary>
        /// Secure Sockets Layer 2.0 client-side.
        /// </summary>
        SP_PROT_SSL2_CLIENT = 8,

        /// <summary>
        /// Secure Sockets Layer 2.0
        /// </summary>
        SP_PROT_SSL2 = SP_PROT_SSL2_SERVER | SP_PROT_SSL2_CLIENT,

        /// <summary>
        /// Secure Sockets Layer 3.0 server-side.
        /// </summary>
        SP_PROT_SSL3_SERVER = 16,

        /// <summary>
        /// Secure Sockets Layer 3.0 client-side.
        /// </summary>
        SP_PROT_SSL3_CLIENT = 32,

        /// <summary>
        /// Secure Sockets Layer 3.0.
        /// </summary>
        SP_PROT_SSL3 = SP_PROT_SSL3_SERVER | SP_PROT_SSL3_CLIENT,

        /// <summary>
        /// Transport Layer Security 1.0 server-side.
        /// </summary>
        SP_PROT_TLS1_SERVER = 64,

        /// <summary>
        /// Transport Layer Security 1.0 client-side.
        /// </summary>
        SP_PROT_TLS1_CLIENT = 128,

        /// <summary>
        /// Transport Layer Security 1.0.
        /// </summary>
        SP_PROT_TLS1 = SP_PROT_TLS1_SERVER | SP_PROT_TLS1_CLIENT,

        /// <summary>
        /// Transport Layer Security 1.1 server-side.
        /// </summary>
        SP_PROT_TLS1_1_SERVER = 256,

        /// <summary>
        /// Transport Layer Security 1.1 client-side.
        /// </summary>
        SP_PROT_TLS1_1_CLIENT = 512,

        /// <summary>
        /// Transport Layer Security 1.1.
        /// </summary>
        SP_PROT_TLS1_1 = SP_PROT_TLS1_1_SERVER | SP_PROT_TLS1_1_CLIENT,

        /// <summary>
        /// Transport Layer Security 1.2 server-side.
        /// </summary>
        SP_PROT_TLS1_2_SERVER = 1024,

        /// <summary>
        /// Transport Layer Security 1.2 client-side.
        /// </summary>
        SP_PROT_TLS1_2_CLIENT = 2048,

        /// <summary>
        /// Transport Layer Security 1.2.
        /// </summary>
        SP_PROT_TLS1_2 = SP_PROT_TLS1_2_SERVER | SP_PROT_TLS1_2_CLIENT,

        /// <summary>
        ///  Transport Layer Security 1.3 client-side.
        /// </summary>
        SP_PROT_TLS1_3_CLIENT = 8192,

        /// <summary>
        /// Microsoft Unified Security server-side.
        /// </summary>
        SP_PROT_UNI_SERVER = 1073741824,

        /// <summary>
        /// Microsoft Unified Security client-side.
        /// </summary>
        SP_PROT_UNI_CLIENT = 2147483648,

        /// <summary>
        /// Microsoft Unified Security.
        /// </summary>
        SP_PROT_UNI = SP_PROT_UNI_SERVER | SP_PROT_UNI_CLIENT,


        SP_PROT_ALL = 4294967295,
    }
}
