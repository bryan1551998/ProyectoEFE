using ProyectoEFE.DAL;
using ProyectoEFE.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoEFE
{
    public partial class CursPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Add_Curs_Click(object sender, EventArgs e)
        {
            DalCurs addcurs = new DalCurs();
            string namc = txtcurso.Text;
            addcurs.AddCurs(new CursModel(namc, namc, namc));
        }

        protected void Add_topics_Click(object sender, EventArgs e)
        {
            DalTopics addtopoic = new DalTopics();
            string nametop = txttopics.Text;
            addtopoic.AddTopic(new TopicsModel(nametop, nametop, nametop));
        }

        protected void Add_lesson_Click(object sender, EventArgs e)
        {
            DalLessons addlesson = new DalLessons();
            string namele = txtlesson.Text;
            addlesson.AddLesson(new LessonsModel(namele, namele, namele));
        }

        protected void Add_exercises_Click(object sender, EventArgs e)
        {
            DalExercises addexerc = new DalExercises();
            string nameexe = txtexerci.Text;
            addexerc.AddExercises(new ExercisesModel(nameexe, nameexe, nameexe));
        }
    }
}