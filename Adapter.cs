using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_14
{
    class Adapter
    {
        public Text ConvertXMLToStr (string file)
        {
            var xml = new XmlFile(file);
            var strOut = new Text ();
            for (int i = 0; i < xml.ZooCount(); i++)
            {
                string str = "";
                str += "Name: " + xml.OutZoo(i).ZooName;
                str += "; SpicesAge: " + xml.OutZoo(i).SpicesAge;
                str += "; NameAndAge: " + xml.OutZoo(i).NameAndAge;
                str += "; Origin: " + xml.OutZoo(i).Origin;
                str += "; NameOfOwner: " + xml.OutZoo(i).NameOfOwner;
                str += ".";
                strOut.text.Add(str);
            }
            return strOut;
        }
    }
}
