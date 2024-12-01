using System.Runtime.Serialization.Json;
using System.Xml.Serialization;

namespace Open_closed_principle
{
    class HumanRepository
    {
        #region XML-сериализация
        public void SaveXmlSerializer(List<Human> list)
        {
            FileStream stream = new FileStream("human.xml", FileMode.OpenOrCreate);
            XmlSerializer serializer = new XmlSerializer(typeof(List<Human>));
            serializer.Serialize(stream, list);
            stream.Close();
            Console.WriteLine("Сериализация успешно выполнена!");
        }
        public List<Human> LoadXmlSerializer()
        {
            FileStream stream = new FileStream("human.xml", FileMode.Open);
            XmlSerializer serializer = new XmlSerializer(typeof(List<Human>));
            List<Human> list = serializer.Deserialize(stream) as List<Human> ?? new List<Human>();
            stream.Close();
            Console.WriteLine("Десериализация успешно выполнена!");
            return list;
        }
        #endregion

        #region JSON-сериализация
        public void SaveJSONSerializer(List<Human> list)
        {
            FileStream stream = new FileStream("human.json", FileMode.Create);
            var jsonFormatter = new DataContractJsonSerializer(typeof(List<Human>));
            jsonFormatter.WriteObject(stream, list);
            stream.Close();
            Console.WriteLine("Сериализация успешно выполнена!");
        }
        public List<Human> LoadJSONSerializer()
        {
            FileStream stream = new FileStream("human.json", FileMode.Open);
            var jsonFormatter = new DataContractJsonSerializer(typeof(List<Human>));
            List<Human> list = jsonFormatter.ReadObject(stream) as List<Human> ?? new List<Human>();
            stream.Close();
            Console.WriteLine("Десериализация успешно выполнена!");
            return list;
        }
        #endregion
    }
}
