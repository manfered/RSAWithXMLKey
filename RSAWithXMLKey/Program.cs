using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSAWithXMLKey
{
    class Program
    {
        static void Main(string[] args)
        {
            var rsaWithXML = new RSAWithXMLKey();

            const string message = "Message to Encrypt";
            const string privateKeyPath = "c:\\temp\\privateKey.xml";
            const string publicKeyPath = "c:\\temp\\publicKey.xml";

            rsaWithXML.AssignNewKey(publicKeyPath, privateKeyPath);

            var encrypted = rsaWithXML.Encrypt(publicKeyPath, Encoding.UTF8.GetBytes(message));
            var decrypted = rsaWithXML.Decrypt(privateKeyPath, encrypted);

            Console.WriteLine("RSA Encryption With XML Key");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine();
            Console.WriteLine($"Message text : {message}");
            Console.WriteLine($"Encrypted text : {Convert.ToBase64String(encrypted)}");
            Console.WriteLine($"Decrypted text : {Encoding.UTF8.GetString(decrypted)}");


        }
    }
}
