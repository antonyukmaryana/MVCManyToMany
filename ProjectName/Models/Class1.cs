using System.Collections.Generic;

namespace ProjectName.Models
{
  public class Class1
    {
        public Class1()
        {
            this.Items = new HashSet<Class1Class2>();
        }

        public int Class1Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Class1Class2> Class2Plural { get; set; }
    }
}