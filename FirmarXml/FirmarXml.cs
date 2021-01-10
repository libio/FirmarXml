﻿using System.Xml;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Security.Cryptography.Xml;
using System.IO;

namespace FirmarXml
{
    class FirmarXml
    {
        public XmlDocument FirmarDocumentXML(XmlDocument xmlDocument, string rutaArchivoCertificado, string passwordCertificado)
        {



            xmlDocument.PreserveWhitespace = true;
            XmlNode ExtensionContent = xmlDocument.GetElementsByTagName("ExtensionContent", "urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2").Item(0);
            ExtensionContent.RemoveAll();

            X509Certificate2 x509Certificate2 = new X509Certificate2(File.ReadAllBytes(rutaArchivoCertificado), passwordCertificado, X509KeyStorageFlags.Exportable);
            RSACryptoServiceProvider key = new RSACryptoServiceProvider(new CspParameters(24));

            SignedXml signedXml = new SignedXml(xmlDocument);
            XmlDsigEnvelopedSignatureTransform env = new XmlDsigEnvelopedSignatureTransform();
            KeyInfo keyInfo = new KeyInfo();
            KeyInfoX509Data keyInfoX509Data = new KeyInfoX509Data(x509Certificate2);
            Reference reference = new Reference("");

            string exportarLlave = x509Certificate2.PrivateKey.ToXmlString(true);
            key.PersistKeyInCsp = false;
            key.FromXmlString(exportarLlave);
            reference.AddTransform(env);
            signedXml.SigningKey = key;
            Signature XMLSignature = signedXml.Signature;
            XMLSignature.SignedInfo.AddReference(reference);
            keyInfoX509Data.AddSubjectName(x509Certificate2.Subject);
            keyInfo.AddClause(keyInfoX509Data);
            XMLSignature.KeyInfo = keyInfo;
            XMLSignature.Id = "SignatureKG";
            signedXml.ComputeSignature(); ExtensionContent.AppendChild(signedXml.GetXml());
            return xmlDocument;
        }
    }
}
