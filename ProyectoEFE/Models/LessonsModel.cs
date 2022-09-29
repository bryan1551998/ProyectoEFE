
namespace ProyectoEFE.Models
{
    public class LessonsModel
    {
        //Atributos
        int id_lessons;
        int fk_topic;
        string image_url_lesson;
        string name_lesson;
        string description_lesson;

        //Get and Set
        public int Id_lessons { get => id_lessons; set => id_lessons = value; }
        public int Fk_topic { get => fk_topic; set => fk_topic = value; }
        public string Image_url_lesson { get => image_url_lesson; set => image_url_lesson = value; }
        public string Name_lesson { get => name_lesson; set => name_lesson = value; }
        public string Description_lesson { get => description_lesson; set => description_lesson = value; }

        //Constructors
        public LessonsModel(int id_lessons, int fk_topic, string image_url_lesson, string name_lesson, string description_lesson)
        {
            this.Id_lessons = id_lessons;
            this.Fk_topic = fk_topic;
            this.Image_url_lesson = image_url_lesson;
            this.Name_lesson = name_lesson;
            this.Description_lesson = description_lesson;
        }

        public LessonsModel(int fk_topic, string image_url_lesson, string name_lesson, string description_lesson)
        {
            this.Fk_topic = fk_topic;
            this.Image_url_lesson = image_url_lesson;
            this.Name_lesson = name_lesson;
            this.Description_lesson = description_lesson;
        }
        public LessonsModel(string image_url_lesson, string name_lesson, string description_lesson)
        {
            this.Image_url_lesson = image_url_lesson;
            this.Name_lesson = name_lesson;
            this.Description_lesson = description_lesson;
        }

        public LessonsModel()
        {
        }
    }
}