using System;

namespace ProyectoEFE.Views.User
{
    internal class HtmlElementEventHandler
    {
        private Action<object, HtmlElementEventArgs> document_MouseOver;

        public HtmlElementEventHandler(Action<object, HtmlElementEventArgs> document_MouseOver)
        {
            this.document_MouseOver = document_MouseOver;
        }
    }
}