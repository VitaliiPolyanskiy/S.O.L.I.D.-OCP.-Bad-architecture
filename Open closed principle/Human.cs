using System.Runtime.Serialization;

namespace Open_closed_principle
{
    [Serializable]
    [DataContract]
    public class Human
    {
        [DataMember]
        public int Age { get; set; }
        [DataMember]
        public string Name { get; set; }

        public Human(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public Human()
        {
            Name = "Default Name";
            Age = 25;
        }
    }
}
