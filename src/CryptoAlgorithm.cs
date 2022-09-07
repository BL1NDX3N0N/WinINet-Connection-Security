namespace WindowsInternet
{
    /// <summary>
    /// Specifies constants that represent a cryptographic algorithm.
    /// </summary>
    public enum CryptoAlgorithm : uint
    {
        None = 0,

        /// <summary>
        /// DSA public key signature algorithm.
        /// </summary>
        CALG_DSS_SIGN = 8704,

        /// <summary>
        /// Elliptic curve digital signature algorithm.
        /// </summary>
        CALG_ECDSA = 8707,

        /// <summary>
        /// No signature algorithm.
        /// </summary>
        CALG_NO_SIGN = 8192,

        /// <summary>
        /// RSA public key signature algorithm.
        /// </summary>
        CALG_RSA_SIGN = 9216,

        /// <summary>
        /// Used by the Schannel.dll operations system.
        /// </summary>
        CALG_SSL3_MASTER = 19457,

        /// <summary>
        /// Used by the Schannel.dll operations system.
        /// </summary>
        CALG_SCHANNEL_MASTER_HASH = 19458,

        /// <summary>
        /// Used by the Schannel.dll operations system.
        /// </summary>
        CALG_SCHANNEL_MAC_KEY = 19459,

        /// <summary>
        /// Used by the Schannel.dll operations system.
        /// </summary>
        CALG_PCT1_MASTER = 19460,

        /// <summary>
        /// Used by the Schannel.dll operations system.
        /// </summary>
        CALG_SSL2_MASTER = 19461,

        /// <summary>
        /// Used by the Schannel.dll operations system.
        /// </summary>
        CALG_TLS1_MASTER = 19462,

        /// <summary>
        /// Used by the Schannel.dll operations system.
        /// </summary>
        CALG_SCHANNEL_ENC_KEY = 19463,

        /// <summary>
        /// DES encryption algorithm.
        /// </summary>
        CALG_DES = 26113,

        /// <summary>
        /// RC2 block encryption algorithm.
        /// </summary>
        CALG_RC2 = 26114,

        /// <summary>
        /// Triple DES encryption algorithm.
        /// </summary>
        CALG_3DES = 26115,

        /// <summary>
        /// DESX encryption algorithm.
        /// </summary>
        CALG_DESX = 26116,

        /// <summary>
        /// Two-key triple DES encryption with effective key length equal to 112 bits.
        /// </summary>
        CALG_3DES_112 = 26121,

        /// <summary>
        /// Skipjack block encryption algorithm (FORTEZZA).
        /// </summary>
        CALG_SKIPJACK = 26122,

        /// <summary>
        /// TEK (FORTEZZA).
        /// </summary>
        CALG_TEK = 26123,

        /// <summary>
        /// An algorithm to create a 40-bit DES key that has parity bits and zeroed key bits to make
        /// its key length 64 bits.
        /// </summary>
        CALG_CYLINK_MEK = 26124,

        /// <summary>
        /// RC5 block encryption algorithm.
        /// </summary>
        CALG_RC5 = 26125,

        /// <summary>
        /// 128 bit AES.
        /// </summary>
        CALG_AES_128 = 26126,

        /// <summary>
        /// 192 bit AES.
        /// </summary>
        CALG_AES_192 = 26127,

        /// <summary>
        /// 256 bit AES.
        /// </summary>
        CALG_AES_256 = 26128,

        /// <summary>
        /// Advanced Encryption Standard (AES).
        /// </summary>
        CALG_AES = 26129,

        /// <summary>
        /// RC4 stream encryption algorithm.
        /// </summary>
        CALG_RC4 = 26625,

        /// <summary>
        /// SEAL encryption algorithm.
        /// </summary>
        CALG_SEAL = 26626,

        /// <summary>
        /// MD2 hashing algorithm.
        /// </summary>
        CALG_MD2 = 32769,

        /// <summary>
        /// MD4 hashing algorithm.
        /// </summary>
        CALG_MD4 = 32770,

        /// <summary>
        /// MD5 hashing algorithm.
        /// </summary>
        CALG_MD5 = 32771,

        /// <summary>
        /// SHA hashing algorithm.
        /// </summary>
        CALG_SHA1 = 32772,

        /// <summary>
        /// MAC keyed hash algorithm.
        /// </summary>
        CALG_MAC = 32773,

        /// <summary>
        /// Used by the Schannel.dll operations system.
        /// </summary>
        CALG_SSL3_SHAMD5 = 32776,

        /// <summary>
        /// HMAC keyed hash algorithm.
        /// </summary>
        CALG_HMAC = 32777,

        /// <summary>
        /// Used by the Schannel.dll operations system.
        /// </summary>
        CALG_TLS1PRF = 32778,

        /// <summary>
        /// One way function hashing algorithm.
        /// </summary>
        CALG_HASH_REPLACE_OWF = 32779,

        /// <summary>
        /// 256 bit SHA hashing algorithm.
        /// </summary>
        CALG_SHA_256 = 32780,

        /// <summary>
        /// 384 bit SHA hashing algorithm.
        /// </summary>
        CALG_SHA_384 = 32781,

        /// <summary>
        /// 512 bit SHA hashing algorithm.
        /// </summary>
        CALG_SHA_512 = 32782,

        /// <summary>
        /// Elliptic curve Menezes, Qu, and Vanstone (MQV) key exchange algorithm.
        /// </summary>
        CALG_ECMQV = 40961,

        /// <summary>
        /// Hughes MD5 hashing algorithm.
        /// </summary>
        CALG_HUGHES_MD5 = 40963,

        /// <summary>
        /// KEA key exchange algorithm (FORTEZZA).
        /// </summary>
        CALG_RSA_KEYX = 41984,

        /// <summary>
        /// Diffie-Hellman store and forward key exchange algorithm.
        /// </summary>
        CALG_DH_SF = 43521,

        /// <summary>
        /// Diffie-Hellman ephemeral key exchange algorithm.
        /// </summary>
        CALG_DH_EPHEM = 43522,

        /// <summary>
        /// Temporary algorithm identifier for handles of Diffie-Hellman–agreed keys.
        /// </summary>
        CALG_AGREEDKEY_ANY = 43523,

        /// <summary>
        /// KEA key exchange algorithm (FORTEZZA).
        /// </summary>
        CALG_KEA_KEYX = 43524,

        /// <summary>
        /// Elliptic curve Diffie-Hellman key exchange algorithm.
        /// </summary>
        CALG_ECDH = 43525,

        /// <summary>
        /// Ephemeral elliptic curve Diffie-Hellman key exchange algorithm.
        /// </summary>
        CALG_ECDH_EPHEM = 44550,

        /// <summary>
        /// The algorithm is defined in the encoded parameters.
        /// </summary>
        CALG_OID_INFO_PARAMETERS = 4294967294,

        /// <summary>
        /// The algorithm is only implemented in CNG.
        /// </summary>
        CALG_OID_INFO_CNG_ONLY = 4294967295
    }
}
