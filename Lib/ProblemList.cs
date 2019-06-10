using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Lib
{
    [Serializable]
    public class SerializableDictionary<TKey, TValue> : Dictionary<TKey, TValue>, IXmlSerializable
    {
        public SerializableDictionary() { }
        public void WriteXml(XmlWriter write)       // Serializer
        {
            XmlSerializer KeySerializer = new XmlSerializer(typeof(TKey));
            XmlSerializer ValueSerializer = new XmlSerializer(typeof(TValue));

            foreach (KeyValuePair<TKey, TValue> kv in this)
            {
                write.WriteStartElement("SerializableDictionary");
                write.WriteStartElement("key");
                KeySerializer.Serialize(write, kv.Key);
                write.WriteEndElement();
                write.WriteStartElement("value");
                ValueSerializer.Serialize(write, kv.Value);
                write.WriteEndElement();
                write.WriteEndElement();
            }
        }
        public void ReadXml(XmlReader reader)       // Deserializer
        {
            reader.Read();
            XmlSerializer KeySerializer = new XmlSerializer(typeof(TKey));
            XmlSerializer ValueSerializer = new XmlSerializer(typeof(TValue));

            while (reader.NodeType != XmlNodeType.EndElement)
            {
                reader.ReadStartElement("SerializableDictionary");
                reader.ReadStartElement("key");
                TKey tk = (TKey)KeySerializer.Deserialize(reader);
                reader.ReadEndElement();
                reader.ReadStartElement("value");
                TValue vl = (TValue)ValueSerializer.Deserialize(reader);
                reader.ReadEndElement();
                reader.ReadEndElement();
                this.Add(tk, vl);
                reader.MoveToContent();
            }
            reader.ReadEndElement();

        }
        public XmlSchema GetSchema()
        {
            return null;
        }

        XmlSchema IXmlSerializable.GetSchema()
        {
            throw new NotImplementedException();
        }
    }

    public static class ProblemList
    {
        private static SerializableDictionary<int,StructureOfProblem> problem = new SerializableDictionary<int, StructureOfProblem>();
        private const string path = "./Problem/Problem.xml";
        static ProblemList() {
            Init();
        }
        public static void Init() {
            if (File.Exists(path))
            {
                XmlOperator xmlopertor = new XmlOperator();
                problem = xmlopertor.readXML(path);
            }
        }
        public static void Add(StructureOfProblem newProblem) {
            if (!problem.ContainsKey(newProblem.ProblemID))
                problem.Add(newProblem.ProblemID, newProblem);
            else problem[newProblem.ProblemID] = newProblem;
            Save();
        }
        public static StructureOfProblem GetProblem(int ID) {
            return problem[ID];
        }
        public static SerializableDictionary<int, StructureOfProblem> GetAll()
        {
            return problem;
        }
        public static void Delete(int ID)
        {
            problem.Remove(ID);
            Save();
        }
        public static void Save() {
            XmlOperator xmlopertor = new XmlOperator();
            xmlopertor.XMLSerialized(path, problem);
        }
        public static void UpdateStatus(StructureOfProblem s)
        {
            problem[s.ProblemID] = s;
            Save();
        }
    }
}
