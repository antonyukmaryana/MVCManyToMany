using System.Collections.Generic;

namespace ProjectName.Models
{
    public class Class2
    {
        public Class2()
        {
            this.Class2Plural = new HashSet<Class1Class2>();
        }

        public int Class2Id { get; set; }
        public string Description { get; set; }

        public ICollection<Class1Class2> Class2Plural { get;}
    }
}