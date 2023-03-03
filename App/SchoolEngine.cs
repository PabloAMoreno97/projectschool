using CoreSchool.Entities;

namespace CoreSchool
{

    public class SchoolEngine
    {
        public School School { get; set; }

        public void Initialize()
        {
            School = new School(
                "Penca",
                2015,
                SchoolTypes.Intermediate,
                country: "Spain",
                city: "Valencia"
            );

            LoadCourses();
            LoadAssignments();
            foreach (var course in School.Courses)
            {
                course.Students.AddRange(LoadStudents());
            }
            LoadCalifications();

        }

        /*
        ___________________________METHODS____________________________
        */
        private void LoadCalifications()
        {

        }

        private IEnumerable<Student> LoadStudents()
        {
            string[] names1 = { "Jhon", "Robert", "Mary", "Rose", "Philips" };
            string[] lastnames = { "Smith", "Johnson", "Miller", "Jones", "Williams" };
            string[] names2 = { "Liam", "Olivia", "Noah", "Emma", "Elijah" };

            IEnumerable<Student> studentsList = from name1 in names1
                                                from name2 in names2
                                                from lastname in lastnames
                                                select new Student { Name = $"{name1} {name2} {lastname}" };
            return studentsList;
        }

        private void LoadAssignments()
        {
            foreach (Course course in School.Courses)
            {
                List<Assignment> assignmentsList = new List<Assignment>()
                {
                    new Assignment(){Name="Economy"},
                    new Assignment(){Name="Literature"},
                    new Assignment(){Name="Politics"},
                    new Assignment(){Name="Maths"}
                };
                course.Assignments.AddRange(assignmentsList);
            }
        }

        public void LoadCourses()
        {
            List<Course> courseList = new List<Course>(){
                new Course(){Name = "101", Schedule = Schedule.Morning },
                new Course(){Name = "102", Schedule = Schedule.Afternoon },
                new Course(){Name = "301", Schedule = Schedule.Morning },
                new Course(){Name = "501", Schedule = Schedule.Night },
                new Course(){Name = "401", Schedule = Schedule.Morning }
            };
            School.Courses = courseList;
        }
    }
}


