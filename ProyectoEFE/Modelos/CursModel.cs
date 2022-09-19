namespace ProyectoEFE.Modelos
{
    public class CursModel
    {
        string name_curs;
        string description_curs;
        string image_url_curs;
        public CursModel(string nc, string dc, string iuc)
        {
            name_curs = nc;
            description_curs = dc;
            image_url_curs = iuc;
        }

        public string Name_curs { get => name_curs; set => name_curs = value; }
        public string Description_curs { get => description_curs; set => description_curs = value; }
        public string Image_url_curs { get => image_url_curs; set => image_url_curs = value; }
    }
}