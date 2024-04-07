using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace API_opecovi;

[Table("t_registro_compra")]
public partial class TRegistroCompra
{
    [Key]
    [Column("id_registro_compra")]
    public int IdRegistroCompra { get; set; }

    [Column("id_empresa")]
    public int IdEmpresa { get; set; }

    [Column("id_sucursal")]
    public int? IdSucursal { get; set; }

    [Column("id_orden_compra")]
    public int IdOrdenCompra { get; set; }

    [Column("id_empleado")]
    public int IdEmpleado { get; set; }

    [Column("id_empleado_aprobador")]
    public int? IdEmpleadoAprobador { get; set; }

    [Column("nro_registro_compra")]
    [StringLength(30)]
    [Unicode(false)]
    public string? NroRegistroCompra { get; set; }

    [Column("fecha_registro_compra", TypeName = "datetime")]
    public DateTime FechaRegistroCompra { get; set; }

    [Column("fecha_orden_compra", TypeName = "datetime")]
    public DateTime? FechaOrdenCompra { get; set; }

    [Column("imp_neto", TypeName = "numeric(14, 6)")]
    public decimal ImpNeto { get; set; }

    [Column("imp_base_isc", TypeName = "numeric(14, 6)")]
    public decimal ImpBaseIsc { get; set; }

    [Column("imp_isc", TypeName = "numeric(14, 6)")]
    public decimal ImpIsc { get; set; }

    [Column("imp_base_igv", TypeName = "numeric(14, 6)")]
    public decimal ImpBaseIgv { get; set; }

    [Column("imp_igv", TypeName = "numeric(14, 6)")]
    public decimal ImpIgv { get; set; }

    [Column("imp_cobrar", TypeName = "numeric(14, 6)")]
    public decimal ImpCobrar { get; set; }

    [Column("es_activo")]
    public byte EsActivo { get; set; }

    [Column("es_eliminado")]
    public byte EsEliminado { get; set; }

    [Column("usuario_creacion")]
    [StringLength(12)]
    [Unicode(false)]
    public string UsuarioCreacion { get; set; } = null!;

    [Column("fecha_creacion", TypeName = "datetime")]
    public DateTime FechaCreacion { get; set; }

    [Column("usuario_modificacion")]
    [StringLength(12)]
    [Unicode(false)]
    public string UsuarioModificacion { get; set; } = null!;

    [Column("fecha_modificacion", TypeName = "datetime")]
    public DateTime FechaModificacion { get; set; }

    [ForeignKey("IdEmpleadoAprobador")]
    [InverseProperty("TRegistroCompraIdEmpleadoAprobadorNavigations")]
    public virtual MEmpleado? IdEmpleadoAprobadorNavigation { get; set; }

    [ForeignKey("IdEmpleado")]
    [InverseProperty("TRegistroCompraIdEmpleadoNavigations")]
    public virtual MEmpleado IdEmpleadoNavigation { get; set; } = null!;

    [ForeignKey("IdEmpresa")]
    [InverseProperty("TRegistroCompras")]
    public virtual MEmpresa IdEmpresaNavigation { get; set; } = null!;

    [ForeignKey("IdOrdenCompra")]
    [InverseProperty("TRegistroCompras")]
    public virtual TOrdenCompra IdOrdenCompraNavigation { get; set; } = null!;

    [ForeignKey("IdSucursal")]
    [InverseProperty("TRegistroCompras")]
    public virtual MSucursal? IdSucursalNavigation { get; set; }

    [InverseProperty("IdRegistroCompraNavigation")]
    public virtual ICollection<TRegistroCompraDetalle> TRegistroCompraDetalles { get; set; } = new List<TRegistroCompraDetalle>();
}
