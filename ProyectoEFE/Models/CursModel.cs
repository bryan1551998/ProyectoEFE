namespace ProyectoEFE.Models
{
    public class CursModel
    {
        //Atributos
        int id_curs;
        string name_curs;
        string description_curs;
        string image_url_curs;
        string autor_name;
        string autor_idUser;

        //Get and Set
        public int Id_curs { get => id_curs; set => id_curs = value; }
        public string Name_curs { get => name_curs; set => name_curs = value; }
        public string Description_curs { get => description_curs; set => description_curs = value; }
        public string Image_url_curs { get => image_url_curs; set => image_url_curs = value; }
        public string Autor_name { get => autor_name; set => autor_name = value; }
        public string Autor_idUser { get => autor_idUser; set => autor_idUser = value; }

        //Constructors
        public CursModel(int id_curs, string name_curs, string description_curs, string image_url_curs, string autor_name, string autor_idUser)
        {
            this.Id_curs = id_curs;
            this.Name_curs = name_curs;
            this.Description_curs = description_curs;
            this.Image_url_curs = image_url_curs;
            this.Autor_name = autor_name;
            this.Autor_idUser = autor_idUser;
        }

        public CursModel(string name_curs, string description_curs, string image_url_curs, string autor_name)
        {
            this.Name_curs = name_curs;
            this.Description_curs = description_curs;
            this.Image_url_curs = image_url_curs;
            this.Autor_name = autor_name;
        }

        public CursModel()
        {
        }
    }
}