using System;
using System.Collections.Generic;
using System.Text;

namespace LabaPervaya
{
    class Student
    {
        public string Name { get; set; }
        public string Sex { get; set; }
        public string HairColor { get; set; }
        public int Age { get; set; }

        public void MonsterName(Student x) => Name += x.Name;

        public void MonsterStudent(Student x)
        {
            Name += x.Name;
            Sex += x.Sex;
            HairColor += x.HairColor;
            Age += x.Age;
        }
    }
}
