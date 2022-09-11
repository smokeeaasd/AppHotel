using System;
using System.Collections.Generic;
using System.Text;

namespace AppHotel.Model
{
    public class Sessao
    {
        public string usuario;
        public bool manterConectado;

        public Sessao(string usuario, bool manterConectado)
        {
            this.usuario = usuario;
            this.manterConectado = manterConectado;
        }
    }
}
