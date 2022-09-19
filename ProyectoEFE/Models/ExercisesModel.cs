namespace ProyectoEFE.Models
{
    public class ExercisesModel
    {
        string name_exercise;
        string description_exercise;
        string image_url_exercise;
        public ExercisesModel(string ne, string de, string iue)
        {
            name_exercise = ne;
            description_exercise = de;
            image_url_exercise = iue;
        }

        public string Name_exercise { get => name_exercise; set => name_exercise = value; }
        public string Description_exercise { get => description_exercise; set => description_exercise = value; }
        public string Image_url_exercise { get => image_url_exercise; set => image_url_exercise = value; }
    }
}