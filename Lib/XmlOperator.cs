using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace Lib
{
    public class XmlOperator
    {
        public static bool checkDir(string url)
        {
            try
            {
                if (!Directory.Exists(url))//如果不存在就创建file文件夹　　             　　              
                    Directory.CreateDirectory(url);//创建该文件夹　　            
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public void XMLSerialized(string path, SerializableDictionary<int, StructureOfProblem> problem)
        {
            XmlSerializer xs = new XmlSerializer(typeof(SerializableDictionary<int,StructureOfProblem>));
            //默认D盘为根目录 
            checkDir("Problem//");
            Stream stream = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.Read);
            xs.Serialize(stream, problem);
            stream.Close();
        }
        public SerializableDictionary<int, StructureOfProblem> readXML(String path)
        {
            SerializableDictionary<int, StructureOfProblem> item = new SerializableDictionary<int, StructureOfProblem>();

            try
            {
                XmlSerializer xs = new XmlSerializer(typeof(SerializableDictionary<int, StructureOfProblem>));
                Stream stream = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read);
                item = (SerializableDictionary<int, StructureOfProblem>)xs.Deserialize(stream);
                stream.Close();
            }
            catch (Exception e)
            {
                Console.Write("打开失败");
            }

            return item;
        }
    }
}
