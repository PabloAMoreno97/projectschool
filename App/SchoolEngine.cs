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
            LoadCalifications();
            LoadStudents();
        }

        private void LoadCalifications()
        {
            throw new NotFiniteNumberException();
        }

        private void LoadStudents()
        {
            throw new NotFiniteNumberException();
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


