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
        }

        /*
        ___________________________METHODS____________________________
        */
        private void LoadCalifications()
        {
            string[] names = { "Initial Evaluation", "Evaluation 1", "Evaluation 2", "Evaluation 3", "Final Evaluation" };
            foreach (Course course in School.Courses)
            {
                foreach (Assignment assignment in course.Assignments)
                {
                    foreach (Student student in course.Students)
                    {
                        List<Evaluation> evaluationsList = new List<Evaluation>();
                        foreach (string name in names)
                        {
                            Random rnd = new Random();
                            double calification = rnd.Next(0, 500);
                            calification /= 100;
                            evaluationsList.Add(new Evaluation
                            {
                                Name = name,
                                Assignment = assignment,
                                Student = student,
                                Calification = calification
                            });
                        }
                        course.Evaluation.AddRange(evaluationsList);
                    }
                }
            }
        }

        private List<Student> LoadRandomStudents(int quantity)
        {
            string[] names1 = { "Jhon", "Robert", "Mary", "Rose", "Philips" };
            string[] lastnames = { "Smith", "Johnson", "Miller", "Jones", "Williams" };
            string[] names2 = { "Liam", "Olivia", "Noah", "Emma", "Elijah" };

            IEnumerable<Student> studentsList = from name1 in names1
                                                from name2 in names2
                                                from lastname in lastnames
                                                select new Student { Name = $"{name1} {name2} {lastname}" };
            return studentsList.OrderBy((student) => student.Id).Take(quantity).ToList();
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
            List<Course> coursesList = new List<Course>(){
                new Course(){Name = "101", Schedule = Schedule.Morning },
                new Course(){Name = "102", Schedule = Schedule.Afternoon },
                new Course(){Name = "301", Schedule = Schedule.Morning },
                new Course(){Name = "501", Schedule = Schedule.Night },
                new Course(){Name = "401", Schedule = Schedule.Morning }
            };
            School.Courses.AddRange(coursesList);

            Random rnd = new Random();
            int randomQuantity = 0;
            foreach (Course course in School.Courses)
            {
                randomQuantity = rnd.Next(5, 20);
                course.Students = LoadRandomStudents(randomQuantity);
            }
        }
    }
}


