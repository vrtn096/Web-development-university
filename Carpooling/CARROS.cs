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
    
    public partial class CARROS
    {
        public CARROS()
        {
            this.AGENDA = new HashSet<AGENDA>();
        }
    
        public int idCar { get; set; }
        public string modeloCar { get; set; }
        public string placaCar { get; set; }
        public string corCar { get; set; }
        public int capacidadeCar { get; set; }
        public Nullable<int> fkUsu { get; set; }
    
        public virtual ICollection<AGENDA> AGENDA { get; set; }
        public virtual USUARIOS USUARIOS { get; set; }
    }
}
