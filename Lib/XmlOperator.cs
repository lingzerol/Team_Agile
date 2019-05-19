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

        public void XMLSerialized(StructureOfProblem problem)
        {
            XmlSerializer xs = new XmlSerializer(typeof(StructureOfProblem));
            //默认D盘为根目录 
            Console.WriteLine(problem.QuestionName);
            checkDir("Problem//");
            Stream stream = new FileStream("Problem//Problem" + problem.QuestionName + ".xml", FileMode.Create, FileAccess.Write, FileShare.Read);
            xs.Serialize(stream, problem);
            stream.Close();
        }
        public StructureOfProblem readXML(String name)
        {
            StructureOfProblem problem = new StructureOfProblem();

            try
            {
                XmlSerializer xs = new XmlSerializer(typeof(StructureOfProblem));
                Stream stream = new FileStream("Problem//Problem" + name + ".xml", FileMode.Open, FileAccess.Read, FileShare.Read);
                problem = xs.Deserialize(stream) as StructureOfProblem;
            }
            catch (Exception e)
            {
                Console.Write("打开失败");
            }

            return problem;
        }
    }
}
