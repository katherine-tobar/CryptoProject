using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace DecryptionAlgorithm
{
    class XMLProcessor
    {
        public XmlDocument ImportXML(String path)
        {
            Console.WriteLine(path);

            XmlDocument doc = new XmlDocument();
            doc.Load(path);
            Console.WriteLine(doc.ToString());
            return doc;
        }

        public String[] GetRSAValues(XmlDocument doc)
        {
            Console.WriteLine(doc.DocumentElement.OuterXml);

            String privatePath = "ALGORITMO/clavePrivada";
            XmlNode privateNodes = doc.SelectSingleNode(privatePath);

            string publicPath = "ALGORITMO/clave";
            XmlNode publicNodes = doc.SelectSingleNode(publicPath);

            XmlDocument newDoc = new XmlDocument();
            newDoc.LoadXml(privateNodes.InnerText);

            XmlDocument newDocPublic = new XmlDocument();
            newDocPublic.LoadXml(publicNodes.InnerText);
            String keysPath = "ALGORITMOKeyValue";
            XmlNodeList keysnodes = newDoc.SelectNodes(keysPath);
            XmlNode nodePublic = newDocPublic.SelectSingleNode("ALGORITMOKeyValue/Modulus");
            XmlNode nodePrivate = newDoc.SelectSingleNode("ALGORITMOKeyValue");

            String[] data = { nodePublic.InnerText, nodePrivate.InnerText, privateNodes.InnerText };
            return data;
        }
    }
}

