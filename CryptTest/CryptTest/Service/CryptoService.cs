using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CryptTest.Service
{
    public static class CryptoService
    {
        public static string CryptSHA256(string word)
            => new SHA256CryptoServiceProvider()
           .ComputeHash(Encoding.ASCII.GetBytes(word))
           .Select(x => string.Format("{0:X2}", x))
           .Aggregate((n, elem) => n + elem);
        public static string CryptSHA256WithSalt(string word, string salt)
            => CryptSHA256(word + salt);
        /// <summary>
        /// デジタル署名を作成する
        /// </summary>
        /// <param name="message">署名を付けるメッセージ</param>
        /// <param name="privateKey">署名に使用する秘密鍵</param>
        /// <returns>作成された署名</returns>
        public static string CreateDigitalSignature(
            string message, string privateKey)
        {
            //メッセージをバイト型配列にして、SHA1ハッシュ値を計算
            byte[] msgData = Encoding.UTF8.GetBytes(message);
            SHA1Managed sha = new SHA1Managed();
            byte[] hashData = sha.ComputeHash(msgData);

            //RSACryptoServiceProviderオブジェクトの作成
            RSACryptoServiceProvider rsa =
                new RSACryptoServiceProvider();
            //秘密鍵を使って初期化
            rsa.FromXmlString(privateKey);

            //RSAPKCS1SignatureFormatterオブジェクトを作成
            RSAPKCS1SignatureFormatter rsaFormatter =
                new RSAPKCS1SignatureFormatter(rsa);
            //署名の作成に使用するハッシュアルゴリズムを指定
            rsaFormatter.SetHashAlgorithm("SHA1");

            //署名を作成
            byte[] signedValue = rsaFormatter.CreateSignature(hashData);

            //バイト型配列を文字列に変換して返す
            return Convert.ToBase64String(signedValue);
        }

        /// <summary>
        /// デジタル署名を検証する
        /// </summary>
        /// <param name="message">署名の付いたメッセージ</param>
        /// <param name="signature">署名</param>
        /// <param name="publicKey">送信者の公開鍵</param>
        /// <returns>認証に成功した時はTrue。失敗した時はFalse。</returns>
        public static bool VerifyDigitalSignature(
            string message, string signature, string publicKey)
        {
            //メッセージをバイト型配列にして、SHA1ハッシュ値を計算
            byte[] msgData = System.Text.Encoding.UTF8.GetBytes(message);
            SHA1Managed sha =
                new SHA1Managed();
            byte[] hashData = sha.ComputeHash(msgData);

            //RSACryptoServiceProviderオブジェクトの作成
            RSACryptoServiceProvider rsa =
                new RSACryptoServiceProvider();
            //公開鍵を使って初期化
            rsa.FromXmlString(publicKey);

            RSAPKCS1SignatureDeformatter rsaDeformatter =
                new RSAPKCS1SignatureDeformatter(rsa);
            //署名の検証に使用するハッシュアルゴリズムを指定
            rsaDeformatter.SetHashAlgorithm("SHA1");

            //署名を検証し、結果を返す
            return rsaDeformatter.VerifySignature(hashData,
                Convert.FromBase64String(signature));
        }

        /// <summary>
        /// 公開鍵と秘密鍵を作成して返す
        /// </summary>
        /// <param name="publicKey">作成された公開鍵(XML形式)</param>
        /// <param name="privateKey">作成された秘密鍵(XML形式)</param>
        public static (string publicKey, string privateKey) CreateKeys()
        {
            //RSACryptoServiceProviderオブジェクトの作成
            RSACryptoServiceProvider rsa =
                new RSACryptoServiceProvider();
            //公開鍵と秘密鍵をXML形式で取得
            return (rsa.ToXmlString(false), rsa.ToXmlString(true));
        }
        /// <summary>
        /// 公開鍵と秘密鍵を作成し、キーコンテナに格納する
        /// </summary>
        /// <param name="containerName">キーコンテナ名</param>
        /// <returns>作成された公開鍵(XML形式)</returns>
        public static string CreateKeysAndSaveContainer(string containerName)
        {
            //CspParametersオブジェクトの作成
            System.Security.Cryptography.CspParameters cp =
                new System.Security.Cryptography.CspParameters();
            //キーコンテナ名を指定する
            cp.KeyContainerName = containerName;
            //CspParametersを指定してRSACryptoServiceProviderオブジェクトを作成
            System.Security.Cryptography.RSACryptoServiceProvider rsa =
                new System.Security.Cryptography.RSACryptoServiceProvider(cp);

            //公開鍵をXML形式で取得して返す
            return rsa.ToXmlString(false);
        }

        /// <summary>
        /// 公開鍵を使って文字列を暗号化する
        /// </summary>
        /// <param name="str">暗号化する文字列</param>
        /// <param name="publicKey">暗号化に使用する公開鍵(XML形式)</param>
        /// <returns>暗号化された文字列</returns>
        public static string Encrypt(string str, string publicKey)
        {
            System.Security.Cryptography.RSACryptoServiceProvider rsa =
                new System.Security.Cryptography.RSACryptoServiceProvider();
            rsa.FromXmlString(publicKey);
            byte[] data = System.Text.Encoding.UTF8.GetBytes(str);
            byte[] encryptedData = rsa.Encrypt(data, false);
            return System.Convert.ToBase64String(encryptedData);
        }
        /// <summary>
        /// 秘密鍵を使って文字列を復号化する
        /// </summary>
        /// <param name="str">Encryptメソッドにより暗号化された文字列</param>
        /// <param name="privateKey">復号化に必要な秘密鍵(XML形式)</param>
        /// <returns>復号化された文字列</returns>
        public static string Decrypt(string str, string privateKey)
        {
            try
            {
                //RSACryptoServiceProviderオブジェクトの作成
                RSACryptoServiceProvider rsa =
                    new RSACryptoServiceProvider();

                //秘密鍵を指定
                rsa.FromXmlString(privateKey);

                //復号化する文字列をバイト配列に
                byte[] data = Convert.FromBase64String(str);
                //復号化する
                byte[] decryptedData = rsa.Decrypt(data, false);
                //結果を文字列に変換
                return Encoding.UTF8.GetString(decryptedData);
            }
            catch (Exception ex)
            {
                return string.Empty;//複合に失敗
            }
        }
        /// <summary>
        /// キーコンテナに格納された秘密鍵を使って、文字列を復号化する
        /// </summary>
        /// <param name="str">Encryptメソッドにより暗号化された文字列</param>
        /// <param name="containerName">キーコンテナ名</param>
        /// <returns>復号化された文字列</returns>
        public static string DecryptByContainer(string str, string containerName)
        {
            //CspParametersオブジェクトの作成
            System.Security.Cryptography.CspParameters cp =
                new System.Security.Cryptography.CspParameters();
            //キーコンテナ名を指定する
            cp.KeyContainerName = containerName;
            //CspParametersを指定してRSACryptoServiceProviderオブジェクトを作成
            System.Security.Cryptography.RSACryptoServiceProvider rsa =
                new System.Security.Cryptography.RSACryptoServiceProvider(cp);

            //復号化する
            byte[] data = System.Convert.FromBase64String(str);
            byte[] decryptedData = rsa.Decrypt(data, false);
            return System.Text.Encoding.UTF8.GetString(decryptedData);
        }

        /// <summary>
        /// 指定されたキーコンテナを削除する
        /// </summary>
        /// <param name="containerName">キーコンテナ名</param>
        public static void DeleteKeys(string containerName)
        {
            //CspParametersオブジェクトの作成
            System.Security.Cryptography.CspParameters cp =
                new System.Security.Cryptography.CspParameters();
            //キーコンテナ名を指定する
            cp.KeyContainerName = containerName;
            //CspParametersを指定してRSACryptoServiceProviderオブジェクトを作成
            System.Security.Cryptography.RSACryptoServiceProvider rsa =
                new System.Security.Cryptography.RSACryptoServiceProvider(cp);

            //キーコンテナを削除
            rsa.PersistKeyInCsp = false;
            rsa.Clear();
        }
    }
}
