namespace ProyectoEFE.Models
{
    public class TopicsModel
    {
        string name_topic;
        string description_topic;
        string image_url_topic;
        public TopicsModel(string nt, string dt, string iut)
        {
            name_topic = nt;
            description_topic = dt;
            image_url_topic = iut;
        }

        public string Name_topic { get => name_topic; set => name_topic = value; }
        public string Description_topic { get => description_topic; set => description_topic = value; }
        public string Image_url_topic { get => image_url_topic; set => image_url_topic = value; }
    }
}