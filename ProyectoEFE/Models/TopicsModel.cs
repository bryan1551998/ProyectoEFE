namespace ProyectoEFE.Models
{
    public class TopicsModel
    {
        //Atributos
        int id_topic;
        int fk_curs;
        string image_url_topic;
        string name_topic;
        string description_topic;

        //Set and Get
        public int Id_topic { get => id_topic; set => id_topic = value; }
        public int Fk_curs { get => fk_curs; set => fk_curs = value; }
        public string Image_url_topic { get => image_url_topic; set => image_url_topic = value; }
        public string Name_topic { get => name_topic; set => name_topic = value; }
        public string Description_topic { get => description_topic; set => description_topic = value; }

        //Constructors
        public TopicsModel(int id_topic, int fk_curs, string image_url_topic, string name_topic, string description_topic)
        {
            this.Id_topic = id_topic;
            this.Fk_curs = fk_curs;
            this.Image_url_topic = image_url_topic;
            this.Name_topic = name_topic;
            this.Description_topic = description_topic;
        }

        public TopicsModel(int fk_curs, string image_url_topic, string name_topic, string description_topic)
        {
            this.Fk_curs = fk_curs;
            this.Image_url_topic = image_url_topic;
            this.Name_topic = name_topic;
            this.Description_topic = description_topic;
        }

        public TopicsModel()
        {
        }
    }
}