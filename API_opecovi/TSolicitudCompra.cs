using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace API_opecovi;

[Table("t_solicitud_compra")]
public partial class TSolicitudCompra
{
    [Key]
    [Column("id_solicitud_compra")]
    public int IdSolicitudCompra { get; set; }

    [Column("id_empresa")]
    public int IdEmpresa { get; set; }

    [Column("id_sucursal")]
    public int IdSucursal { get; set; }

    [Column("id_requerimiento")]
    public int? IdRequerimiento { get; set; }

    [Column("id_empleado_aprobador")]
    public int? IdEmpleadoAprobador { get; set; }

    [Column("id_empleado")]
    public int IdEmpleado { get; set; }

    [Column("nro_solicitud_compra")]
    [StringLength(30)]
    [Unicode(false)]
    public string? NroSolicitudCompra { get; set; }

    [Column("fecha_solicitud_compra", TypeName = "datetime")]
    public DateTime? FechaSolicitudCompra { get; set; }

    [Column("fecha_recepcion", TypeName = "datetime")]
    public DateTime? FechaRecepcion { get; set; }

    [Column("es_activo")]
    public byte EsActivo { get; set; }

    [Column("es_eliminado")]
    public byte EsEliminado { get; set; }

    [Column("usuario_creacion")]
    [StringLength(12)]
    [Unicode(false)]
    public string? UsuarioCreacion { get; set; }

    [Column("fecha_creacion", TypeName = "datetime")]
    public DateTime? FechaCreacion { get; set; }

    [Column("usuario_modificacion")]
    [StringLength(12)]
    [Unicode(false)]
    public string? UsuarioModificacion { get; set; }

    [Column("fecha_modificacion", TypeName = "datetime")]
    public DateTime? FechaModificacion { get; set; }

    [ForeignKey("IdEmpleadoAprobador")]
    [InverseProperty("TSolicitudCompraIdEmpleadoAprobadorNavigations")]
    public virtual MEmpleado? IdEmpleadoAprobadorNavigation { get; set; }

    [ForeignKey("IdEmpleado")]
    [InverseProperty("TSolicitudCompraIdEmpleadoNavigations")]
    public virtual MEmpleado IdEmpleadoNavigation { get; set; } = null!;

    [ForeignKey("IdEmpresa")]
    [InverseProperty("TSolicitudCompras")]
    public virtual MEmpresa IdEmpresaNavigation { get; set; } = null!;

    [ForeignKey("IdRequerimiento")]
    [InverseProperty("TSolicitudCompras")]
    public virtual TRequerimiento? IdRequerimientoNavigation { get; set; }

    [ForeignKey("IdSucursal")]
    [InverseProperty("TSolicitudCompras")]
    public virtual MSucursal IdSucursalNavigation { get; set; } = null!;

    [InverseProperty("IdSolicitudCompraNavigation")]
    public virtual ICollection<TCotizacion> TCotizacions { get; set; } = new List<TCotizacion>();

    [InverseProperty("IdSolicitudCompraNavigation")]
    public virtual ICollection<TSolicitudCompraDetalle> TSolicitudCompraDetalles { get; set; } = new List<TSolicitudCompraDetalle>();
}
