using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace API_opecovi;

[Table("t_cotizacion")]
public partial class TCotizacion
{
    [Key]
    [Column("id_cotizacion")]
    public int IdCotizacion { get; set; }

    [Column("id_empresa")]
    public int IdEmpresa { get; set; }

    [Column("id_sucursal")]
    public int IdSucursal { get; set; }

    [Column("id_solicitud_compra")]
    public int IdSolicitudCompra { get; set; }

    [Column("id_proveedor")]
    public int IdProveedor { get; set; }

    [Column("id_empleado")]
    public int IdEmpleado { get; set; }

    [Column("id_empleado_aprobacion")]
    public int? IdEmpleadoAprobacion { get; set; }

    [Column("nro_cotizacion")]
    [StringLength(30)]
    [Unicode(false)]
    public string? NroCotizacion { get; set; }

    [Column("fecha_cotizacion", TypeName = "datetime")]
    public DateTime FechaCotizacion { get; set; }

    [Column("fecha_solicitud_compra", TypeName = "datetime")]
    public DateTime FechaSolicitudCompra { get; set; }

    [Column("fecha_aprobacion", TypeName = "datetime")]
    public DateTime FechaAprobacion { get; set; }

    [Column("imp_neto", TypeName = "numeric(14, 6)")]
    public decimal ImpNeto { get; set; }

    [Column("imp_base_isc", TypeName = "numeric(14, 6)")]
    public decimal ImpBaseIsc { get; set; }

    [Column("imp_isc", TypeName = "numeric(14, 6)")]
    public decimal ImpIsc { get; set; }

    [Column("es_activo")]
    public byte EsActivo { get; set; }

    [Column("es_eliminado")]
    public byte EsEliminado { get; set; }

    [Column("imp_base_igv", TypeName = "numeric(14, 6)")]
    public decimal ImpBaseIgv { get; set; }

    [Column("imp_igv", TypeName = "numeric(14, 6)")]
    public decimal ImpIgv { get; set; }

    [Column("imp_cobrar", TypeName = "numeric(14, 6)")]
    public decimal ImpCobrar { get; set; }

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

    [ForeignKey("IdEmpleadoAprobacion")]
    [InverseProperty("TCotizacionIdEmpleadoAprobacionNavigations")]
    public virtual MEmpleado? IdEmpleadoAprobacionNavigation { get; set; }

    [ForeignKey("IdEmpleado")]
    [InverseProperty("TCotizacionIdEmpleadoNavigations")]
    public virtual MEmpleado IdEmpleadoNavigation { get; set; } = null!;

    [ForeignKey("IdEmpresa")]
    [InverseProperty("TCotizacions")]
    public virtual MEmpresa IdEmpresaNavigation { get; set; } = null!;

    [ForeignKey("IdProveedor")]
    [InverseProperty("TCotizacions")]
    public virtual MProveedor IdProveedorNavigation { get; set; } = null!;

    [ForeignKey("IdSolicitudCompra")]
    [InverseProperty("TCotizacions")]
    public virtual TSolicitudCompra IdSolicitudCompraNavigation { get; set; } = null!;

    [ForeignKey("IdSucursal")]
    [InverseProperty("TCotizacions")]
    public virtual MSucursal IdSucursalNavigation { get; set; } = null!;

    [InverseProperty("IdCotizacionNavigation")]
    public virtual ICollection<TCotizacionDetalle> TCotizacionDetalles { get; set; } = new List<TCotizacionDetalle>();

    [InverseProperty("IdCotizacionNavigation")]
    public virtual ICollection<TOrdenCompra> TOrdenCompras { get; set; } = new List<TOrdenCompra>();
}
