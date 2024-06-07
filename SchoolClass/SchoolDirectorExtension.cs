using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolClass
{
    public static class SchoolDirectorExtension
    {
        public static string WhoTeachedMore(this SchoolDirector sd1, SchoolDirector sd2)
        {
            if(sd1.TeachedYears > sd2.TeachedYears)
            {
                return $"{sd1.DirectorName} hosszabb időt volt tanár, mint {sd2.DirectorName}!";
            }
            else if (sd1.TeachedYears < sd2.TeachedYears)
            {
                return $"{sd2.DirectorName} hosszabb időt volt tanár, mint {sd1.DirectorName}!";
            }
            else
            {
                return "A két vezető ugyan annyi időt volt tanár!";
            }
        }
    }
}
