using System.Collections.Generic;
using System.Linq;

namespace SmallTownSchoolGrade
{
    /// <summary>
    /// Given students' names along with the grade that they are in, create a roster for the school.
    /// </summary>
    public class GradeSchool
    {
        private readonly List<(int grade, string name)> fullGrade = new List<(int grade, string name)>();

        public void Add(string student, int grade) => fullGrade.Add((grade, student));

        public IEnumerable<string> Roster() =>
            fullGrade.OrderBy(x => x.grade).ThenBy(x => x.name).Select(x => x.name);

        public IEnumerable<string> Grade(int grade) => 
            fullGrade.Where(x => x.grade == grade).Select(x => x.name).OrderBy(x => x);
    }
}