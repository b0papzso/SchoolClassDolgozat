using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolClass
{
    public class SchoolDirectorRepo
    {
        public SchoolDirectorRepo()
        {
            SchoolDirectors = new List<SchoolDirector>
            {
                new SchoolDirector("Vezethetetlen Vilmos", new DateTime(2010, 10, 10), 22, 250000),
            new SchoolDirector("Irányíthatatlan Ida", new DateTime(2011, 11, 11), 11, 245000)
        };
        }


        public List<SchoolDirector> SchoolDirectors { get; set; }
    
        public string GetMostExperiencedDirectorsName(List<SchoolDirector> schoolDirectors)
        {
            int equalCount = 1;
            string mostExperienced = "";
            int highestExperience = int.MinValue;
            if(schoolDirectors.Count == 0) { return string.Empty; }
            else
            {
                foreach(var directors in schoolDirectors)
                {
                    if(directors.TeachedYears == highestExperience)
                    {
                        equalCount++;
                        
                    }
                    if(directors.TeachedYears > highestExperience)
                    {
                        mostExperienced = directors.DirectorName;
                        highestExperience = directors.TeachedYears;
                    }
                }
            }
            if(equalCount == schoolDirectors.Count())
            {
                mostExperienced = "Ugyanannyira tapasztaltak";
            }
            return mostExperienced;

        }
    }
}
