
namespace ProyectoEFE.Models
{
    public class LessonsModel
    {
        string name_lesson;
        string description_lesson;
        string image_url_lesson;
        public LessonsModel(string nl, string dl, string iul)
        {
            name_lesson = nl;
            description_lesson = dl;
            image_url_lesson = iul;
        }

        public string Name_lesson { get => name_lesson; set => name_lesson = value; }
        public string Description_lesson { get => description_lesson; set => description_lesson = value; }
        public string Image_url_lesson { get => image_url_lesson; set => image_url_lesson = value; }
    }
}