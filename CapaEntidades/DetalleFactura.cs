//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CapaEntidades
{
    using System;
    using System.Collections.Generic;
    
    public partial class DetalleFactura
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DetalleFactura()
        {
            this.Devoluciones = new HashSet<Devoluciones>();
        }
    
        public int IDdetalleFactura { get; set; }
        public int Cantidad { get; set; }
        public decimal SubtotalDetalle { get; set; }
        public int IDProducto { get; set; }
        public int IDFactura { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Devoluciones> Devoluciones { get; set; }
        public virtual Ventas Ventas { get; set; }
        public virtual Productos Productos { get; set; }
    }
}
