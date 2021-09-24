using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Lab_14
{
    class XmlFile
    {
        private string path;

        private List<Zoo> zooList = new List<Zoo>();
        public XmlFile(string str)
        {
            path = str;
            Read();
        }

        public Zoo OutZoo(int num) 
        {
            if (num < zooList.Count)
            {
                return zooList[num];
            } 
            else
            {
                return new Zoo();
            }
        }

        public int ZooCount()
        {
            return zooList.Count;
        }

        public void Read()
        {
            var doc = new XmlDocument();
            doc.Load(path);
            var xRoot = doc.DocumentElement;
            foreach (XmlNode xnode in xRoot)
            {
                var newZoo = new Zoo();
                if (xnode.Attributes.Count > 0)
                {
                    XmlNode attr = xnode.Attributes.GetNamedItem("ZooName");
                    if (attr != null)
                    {
                        newZoo.ZooName = attr.Value;
                    }

                }
                foreach (XmlNode childnode in xnode.ChildNodes)
                {
                    if (childnode.Name == "SpicesAge")
                    {
                        newZoo.SpicesAge = childnode.InnerText;
                    }
                    if (childnode.Name == "NameAndAge")
                    {
                        newZoo.NameAndAge = childnode.InnerText;
                    }
                    if (childnode.Name == "Origin")
                    {
                        newZoo.Origin = childnode.InnerText;
                    }
                    if (childnode.Name == "NameOfOwner")
                    {
                        newZoo.NameOfOwner = childnode.InnerText;
                    }
                }
                zooList.Add(newZoo);
            }
        }
    }
}
