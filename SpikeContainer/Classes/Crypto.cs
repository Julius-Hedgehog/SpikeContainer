using System;
using System.Text;
using System.Security.Cryptography;
using System.IO;

namespace PFCS.Classes
{
    class Crypto
    {
        //// This constant is used to determine the keysize of the encryption algorithm in bits.
        //// We divide this by 8 within the code below to get the equivalent number of bytes.
        //private const int Keysize = 256;

        //// This constant determines the number of iterations for the password bytes generation function.
        //private const int DerivationIterations = 1000;

        //internal static string Encrypt(string plainText, string passPhrase)
        //{
        //    byte[] planeByte = Encoding.UTF8.GetBytes(plainText);
        //    var planeB64String = Convert.ToBase64String(planeByte);
        //    if (passPhrase.Length % 4 != 0) passPhrase += new string('=', 4 - passPhrase.Length % 4);
        //    // Salt and IV is randomly generated each time, but is preprended to encrypted cipher text
        //    // so that the same Salt and IV values can be used when decrypting.  
        //    var saltStringBytes = Generate256BitsOfRandomEntropy();
        //    var ivStringBytes = Generate256BitsOfRandomEntropy();
        //    var plainTextBytes = Encoding.UTF8.GetBytes(planeB64String);
        //    using (var password = new Rfc2898DeriveBytes(passPhrase, saltStringBytes, DerivationIterations))
        //    {
        //        var keyBytes = password.GetBytes(Keysize / 8);
        //        using (var symmetricKey = new RijndaelManaged())
        //        {
        //            symmetricKey.BlockSize = 256;
        //            symmetricKey.Mode = CipherMode.CBC;
        //            symmetricKey.Padding = PaddingMode.PKCS7;
        //            using (var encryptor = symmetricKey.CreateEncryptor(keyBytes, ivStringBytes))
        //            {
        //                using (var memoryStream = new MemoryStream())
        //                {
        //                    using (var cryptoStream = new CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write))
        //                    {
        //                        cryptoStream.Write(plainTextBytes, 0, plainTextBytes.Length);
        //                        cryptoStream.FlushFinalBlock();
        //                        // Create the final bytes as a concatenation of the random salt bytes, the random iv bytes and the cipher bytes.
        //                        var cipherTextBytes = saltStringBytes;
        //                        cipherTextBytes = cipherTextBytes.Concat(ivStringBytes).ToArray();
        //                        cipherTextBytes = cipherTextBytes.Concat(memoryStream.ToArray()).ToArray();
        //                        memoryStream.Close();
        //                        cryptoStream.Close();
        //                        return Convert.ToBase64String(cipherTextBytes);
        //                    }
        //                }
        //            }
        //        }
        //    }
        //}

        //internal static string Decrypt(string cipherText, string passPhrase)
        //{
        //    //byte[] cipherByte = Encoding.UTF8.GetBytes(cipherText);
        //    //var cipherB64String = Convert.ToBase64String(cipherByte);
        //    if (passPhrase.Length % 4 != 0) passPhrase += new string('=', 4 - passPhrase.Length % 4);
        //    // Get the complete stream of bytes that represent:
        //    // [32 bytes of Salt] + [32 bytes of IV] + [n bytes of CipherText]
        //    var cipherTextBytesWithSaltAndIv = Convert.FromBase64String(cipherText);
        //    // Get the saltbytes by extracting the first 32 bytes from the supplied cipherText bytes.
        //    var saltStringBytes = cipherTextBytesWithSaltAndIv.Take(Keysize / 8).ToArray();
        //    // Get the IV bytes by extracting the next 32 bytes from the supplied cipherText bytes.
        //    var ivStringBytes = cipherTextBytesWithSaltAndIv.Skip(Keysize / 8).Take(Keysize / 8).ToArray();
        //    // Get the actual cipher text bytes by removing the first 64 bytes from the cipherText string.
        //    var cipherTextBytes = cipherTextBytesWithSaltAndIv.Skip((Keysize / 8) * 2).Take(cipherTextBytesWithSaltAndIv.Length - ((Keysize / 8) * 2)).ToArray();

        //    using (var password = new Rfc2898DeriveBytes(passPhrase, saltStringBytes, DerivationIterations))
        //    {
        //        var keyBytes = password.GetBytes(Keysize / 8);
        //        using (var symmetricKey = new RijndaelManaged())
        //        {
        //            symmetricKey.BlockSize = 256;
        //            symmetricKey.Mode = CipherMode.CBC;
        //            symmetricKey.Padding = PaddingMode.PKCS7;
        //            using (var decryptor = symmetricKey.CreateDecryptor(keyBytes, ivStringBytes))
        //            {
        //                using (var memoryStream = new MemoryStream(cipherTextBytes))
        //                {
        //                    using (var cryptoStream = new CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read))
        //                    {
        //                        var plainTextBytes = new byte[cipherTextBytes.Length];
        //                        var decryptedByteCount = cryptoStream.Read(plainTextBytes, 0, plainTextBytes.Length);
        //                        memoryStream.Close();
        //                        cryptoStream.Close();
        //                        return Encoding.UTF8.GetString(plainTextBytes, 0, decryptedByteCount);
        //                    }
        //                }
        //            }
        //        }
        //    }
        //}

        //private static byte[] Generate256BitsOfRandomEntropy()
        //{
        //    var randomBytes = new byte[32]; // 32 Bytes will give us 256 bits.
        //    using (var rngCsp = new RNGCryptoServiceProvider())
        //    {
        //        // Fill the array with cryptographically secure random bytes.
        //        rngCsp.GetBytes(randomBytes);
        //    }
        //    return randomBytes;
        //}
        // Change these keys
        private byte[] Key;
        private byte[] Vector = { 134, 176, 200, 88, 149, 107, 109, 191, 247, 46, 41, 155, 241, 251, 213, 205};
        private const int Salt = 8;

        private ICryptoTransform EncryptorTransform, DecryptorTransform;
        private UTF8Encoding UTFEncoder;

        public Crypto(string key)
        {
            //This is our encryption method
            RijndaelManaged rm = new RijndaelManaged();

            var keyBytes = Encoding.Unicode.GetBytes(key);
            var newKey = new byte[32];
            var keyDif = newKey.Length - keyBytes.Length;
            Array.Copy(keyBytes, 0, newKey, keyDif, keyBytes.Length);
            Key = newKey;

            //Create an encryptor and a decryptor using our encryption method, key, and vector.
            EncryptorTransform = rm.CreateEncryptor(Key, Vector);
            DecryptorTransform = rm.CreateDecryptor(Key, Vector);

            //Used to translate bytes to text and vice versa
            UTFEncoder = new UTF8Encoding();
        }



        /// -------------- Two Utility Methods (not used but may be useful) -----------
        /// Generates an encryption key.
        static public byte[] GenerateEncryptionKey()
        {
            //Generate a Key.
            RijndaelManaged rm = new RijndaelManaged();
            rm.GenerateKey();
            return rm.Key;
        }

        /// Generates a unique encryption vector
        static public byte[] GenerateEncryptionVector()
        {
            //Generate a Vector
            RijndaelManaged rm = new RijndaelManaged();
            rm.GenerateIV();
            return rm.IV;
        }

        static internal string EncryptText(string TextValue, string Key)
        {

            var crypto = new Crypto(Key);
            return crypto.EncryptString(TextValue);
        }

        static internal string DecryptText(string TextValue, string Key)
        {
            var crypto = new Crypto(Key);
            return crypto.DecryptString(TextValue);
        }

        /// ----------- The commonly used methods ------------------------------   
        /// Encrypt some text and return a string suitable for passing in a URL.
        public string EncryptString(string TextValue)
        {
            return (TextValue != "") ? Convert.ToBase64String(Encrypt(TextValue)) : "";
        }

        /// Encrypt some text and return an encrypted byte array.
        public byte[] Encrypt(string TextValue)
        {
            //Translates our text value into a byte array.
            Byte[] pepper = UTFEncoder.GetBytes(TextValue);
            // add salt
            Byte[] salt = new byte[Salt];
            RNGCryptoServiceProvider crypto = new RNGCryptoServiceProvider();
            crypto.GetNonZeroBytes(salt);
            Byte[] bytes = new byte[2 * Salt + pepper.Length];
            System.Buffer.BlockCopy(salt, 0, bytes, 0, Salt);
            System.Buffer.BlockCopy(pepper, 0, bytes, Salt, pepper.Length);
            crypto.GetNonZeroBytes(salt);
            System.Buffer.BlockCopy(salt, 0, bytes, Salt + pepper.Length, Salt);

            //Used to stream the data in and out of the CryptoStream.
            MemoryStream memoryStream = new MemoryStream();

            /*
             * We will have to write the unencrypted bytes to the stream,
             * then read the encrypted result back from the stream.
             */
            #region Write the decrypted value to the encryption stream
            CryptoStream cs = new CryptoStream(memoryStream, EncryptorTransform, CryptoStreamMode.Write);
            cs.Write(bytes, 0, bytes.Length);
            cs.FlushFinalBlock();
            #endregion

            #region Read encrypted value back out of the stream
            memoryStream.Position = 0;
            byte[] encrypted = new byte[memoryStream.Length];
            memoryStream.Read(encrypted, 0, encrypted.Length);
            #endregion

            //Clean up.
            cs.Close();
            memoryStream.Close();

            return encrypted;
        }

        /// The other side: Decryption methods
        public string DecryptString(string EncryptedString)
        {
            return (EncryptedString != "") ? Decrypt(Convert.FromBase64String(EncryptedString)) : "";
        }

        /// Decryption when working with byte arrays.    
        public string Decrypt(byte[] EncryptedValue)
        {
            #region Write the encrypted value to the decryption stream
            MemoryStream encryptedStream = new MemoryStream();
            CryptoStream decryptStream = new CryptoStream(encryptedStream, DecryptorTransform, CryptoStreamMode.Write);
            decryptStream.Write(EncryptedValue, 0, EncryptedValue.Length);
            decryptStream.FlushFinalBlock();
            #endregion

            #region Read the decrypted value from the stream.
            encryptedStream.Position = 0;
            Byte[] decryptedBytes = new Byte[encryptedStream.Length];
            encryptedStream.Read(decryptedBytes, 0, decryptedBytes.Length);
            encryptedStream.Close();
            #endregion
            // remove salt
            int len = decryptedBytes.Length - 2 * Salt;
            Byte[] pepper = new Byte[len];
            System.Buffer.BlockCopy(decryptedBytes, Salt, pepper, 0, len);
            return UTFEncoder.GetString(pepper);
        }

    }
}