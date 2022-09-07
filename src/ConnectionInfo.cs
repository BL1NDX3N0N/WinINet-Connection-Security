namespace WindowsInternet
{
    /// <summary>
    /// Structure containing protocol and cipher information.
    /// </summary>
    public readonly struct ConnectionInfo
    {
        /// <summary>
        /// Protocol used to establish this connection.
        /// </summary>
        public readonly Protocol Protocol;

        /// <summary>
        /// Algorithm for the bulk encryption cipher used by this connection.
        /// </summary>
        public readonly CryptoAlgorithm Cipher;

        /// <summary>
        /// Strength of the bulk encryption cipher, in bits.
        /// </summary>
        public readonly uint CipherStrength;

        /// <summary>
        /// Hashing algorithm used for generating Message Authentication Codes (MACs).
        /// </summary>
        public readonly CryptoAlgorithm Hash;

        /// <summary>
        /// Strength of the hash, in bits.
        /// </summary>
        public readonly uint HashStrength;

        /// <summary>
        /// Key exchange algorithm used to generate the shared master secret.
        /// </summary>
        public readonly CryptoAlgorithm KeyExchangeAlgorithm;

        /// <summary>
        /// Key length, in bits.
        /// </summary>
        public readonly uint KeyExchangeStrength;
    }
}
