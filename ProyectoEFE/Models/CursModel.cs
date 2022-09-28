namespace ProyectoEFE.Models
{
    public class CursModel
    {
        //Atributos
        int id_curs;
        string name_curs;
        string description_curs;
        string image_url_curs;
        string autor_curs;

        //Get and Set
        public int Id_curs { get => id_curs; set => id_curs = value; }
        public string Name_curs { get => name_curs; set => name_curs = value; }
        public string Description_curs { get => description_curs; set => description_curs = value; }
        public string Image_url_curs { get => image_url_curs; set => image_url_curs = value; }
        public string Autor_curs { get => autor_curs; set => autor_curs = value; }

        //Constructors
        public CursModel(int id_curs, string name_curs, string description_curs, string image_url_curs, string autor_curs)
        {
            this.Id_curs = id_curs;
            this.Name_curs = name_curs;
            this.Description_curs = description_curs;
            this.Image_url_curs = image_url_curs;
            this.Autor_curs = autor_curs;
        }

        public CursModel(string name_curs, string description_curs, string image_url_curs, string autor_curs)
        {
            this.Name_curs = name_curs;
            this.Description_curs = description_curs;
            this.Image_url_curs = image_url_curs;
            this.Autor_curs = autor_curs;
        }

        public CursModel()
        {
        }
    }
}