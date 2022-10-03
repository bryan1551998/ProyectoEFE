namespace ProyectoEFE.Models
{
    public class ExercisesModel
    {
        //Atributes
        int id_exercise;
        int fk_topic;
        string name_exercise;
        string description_exercise;
        string ejemplo_exercise;
        string solution_exercise;
        int number_exercise;

        //Get and Set
        public int Id_exercise { get => id_exercise; set => id_exercise = value; }
        public int Fk_topic { get => fk_topic; set => fk_topic = value; }
        public string Name_exercise { get => name_exercise; set => name_exercise = value; }
        public string Description_exercise { get => description_exercise; set => description_exercise = value; }
        public string Ejemplo_exercise { get => ejemplo_exercise; set => ejemplo_exercise = value; }
        public string Solution_exercise { get => solution_exercise; set => solution_exercise = value; }
        public int Number_exercise { get => number_exercise; set => number_exercise = value; }


        //Constructors
        public ExercisesModel(int id_exercise, int fk_topic, string name_exercise, string description_exercise, string solution_exercise, string ejemplo_exercise, int number_exercise)
        {
            this.Id_exercise = id_exercise;
            this.Fk_topic = fk_topic;
            this.Name_exercise = name_exercise;
            this.Description_exercise = description_exercise;
            this.Solution_exercise = solution_exercise;
            this.Number_exercise = number_exercise;
            this.Ejemplo_exercise = ejemplo_exercise;
        }

        public ExercisesModel(int fk_topic, string name_exercise, string description_exercise, string solution_exercise, string ejemplo_exercise, int number_exercise)
        {
            this.Fk_topic = fk_topic;
            this.Name_exercise = name_exercise;
            this.Description_exercise = description_exercise;
            this.Solution_exercise = solution_exercise;
            this.Number_exercise = number_exercise;
            this.Ejemplo_exercise = ejemplo_exercise;
        }

        public ExercisesModel(string name_exercise, string description_exercise, string solution_exercise, string ejemplo_exercise, int number_exercise)
        {
            this.Name_exercise = name_exercise;
            this.Description_exercise = description_exercise;
            this.Solution_exercise = solution_exercise;
            this.Number_exercise = number_exercise;
            this.Ejemplo_exercise = ejemplo_exercise;
        }
        public ExercisesModel()
        {

        }
    }
}