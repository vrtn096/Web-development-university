//------------------------------------------------------------------------------
// <auto-generated>
//    O código foi gerado a partir de um modelo.
//
//    Alterações manuais neste arquivo podem provocar comportamento inesperado no aplicativo.
//    Alterações manuais neste arquivo serão substituídas se o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CarpoolingEL
{
    using System;
    using System.Collections.Generic;
    
    public partial class USUARIOS
    {
        public USUARIOS()
        {
            this.AGENDA = new HashSet<AGENDA>();
            this.AGENDA_USUARIOS = new HashSet<AGENDA_USUARIOS>();
            this.CARROS = new HashSet<CARROS>();
            this.DESTINOS = new HashSet<DESTINOS>();
        }
    
        public int idUsu { get; set; }
        public string nomeUsu { get; set; }
        public string emailUsu { get; set; }
        public string rgUsu { get; set; }
        public string endUsu { get; set; }
        public string compUsu { get; set; }
        public string cepUsu { get; set; }
        public string bairroUsu { get; set; }
        public string cidadeUsu { get; set; }
        public string ufUsu { get; set; }
        public string telUsu { get; set; }
        public string celUsu { get; set; }
        public string usuario { get; set; }
        public string senha { get; set; }
        public Nullable<int> fkTipo { get; set; }
    
        public virtual ICollection<AGENDA> AGENDA { get; set; }
        public virtual ICollection<AGENDA_USUARIOS> AGENDA_USUARIOS { get; set; }
        public virtual ICollection<CARROS> CARROS { get; set; }
        public virtual TIPO_USUARIO TIPO_USUARIO { get; set; }
        public virtual ICollection<DESTINOS> DESTINOS { get; set; }
    }
}
