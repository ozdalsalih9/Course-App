
namespace basics.Models
{
    public class Repository
    {
        private static readonly List<Course> _courses;

        // Statik yapıyı kullanarak _courses listesine başlangıç değerleri atanıyor
        static Repository()
        {
            _courses = new List<Course>
            {
                new Course { Id = 1, Title = "ASPNET kursu", Description = "iyi kurs", Image = "img1.webp", Tags= new string[] {"aspnet","web geliştirme"}, isActive=true, isHome=true },
                new Course { Id = 2, Title = "JS kursu", Description = "iyi kurs", Image = "img1.webp", Tags= new string[] {"aspnet","web geliştirme"}, isActive=true, isHome=true },
                new Course { Id = 3, Title = "PHP kursu", Description = "iyi kurs", Image = "img2.jpg", Tags= new string[] {"PHP","web geliştirme"}, isActive=false, isHome=true  },
                new Course { Id = 4, Title = "Go kursu", Description = "iyi kurs", Image = "img3.jpg.webp",  isActive=true, isHome=false  }
            };
        }

        // Courses özelliği ile _courses listesine dışarıdan erişim sağlanıyor
        public static List<Course> Courses
        {
            get { return _courses; }
        }

        public static Course? GetById (int? Id){
            return _courses.FirstOrDefault(c => c.Id ==Id);
        }
    }


 
}

