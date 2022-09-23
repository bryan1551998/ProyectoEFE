namespace ProyectoEFE.Models
{
    public class ExercisesModel
    {
        //Atributes
        int id_exercise;
        int fk_lessons;
        string image_exercise;
        string name_exercise;
        string description_exercise;
        string solution_exercise;

        //Get and Set
        public int Id_exercise { get => id_exercise; set => id_exercise = value; }
        public int Fk_lessons { get => fk_lessons; set => fk_lessons = value; }
        public string Image_exercise { get => image_exercise; set => image_exercise = value; }
        public string Name_exercise { get => name_exercise; set => name_exercise = value; }
        public string Description_exercise { get => description_exercise; set => description_exercise = value; }
        public string Solution_exercise { get => solution_exercise; set => solution_exercise = value; }

        //Constructors
        public ExercisesModel(int id_exercise, int fk_lessons, string image_exercise, string name_exercise, string description_exercise, string solution_exercise)
        {
            this.Id_exercise = id_exercise;
            this.Fk_lessons = fk_lessons;
            this.Image_exercise = image_exercise;
            this.Name_exercise = name_exercise;
            this.Description_exercise = description_exercise;
            this.Solution_exercise = solution_exercise;
        }

        public ExercisesModel(int fk_lessons, string image_exercise, string name_exercise, string description_exercise, string solution_exercise)
        {
            this.Fk_lessons = fk_lessons;
            this.Image_exercise = image_exercise;
            this.Name_exercise = name_exercise;
            this.Description_exercise = description_exercise;
            this.Solution_exercise = solution_exercise;
        }

        public ExercisesModel()
        {
        }
    }
}