using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace API_opecovi;

[Table("t_movimiento_almacen")]
public partial class TMovimientoAlmacen
{
    [Key]
    [Column("id_movimiento_almacen")]
    public int IdMovimientoAlmacen { get; set; }

    [Column("id_empresa")]
    public int IdEmpresa { get; set; }

    [Column("id_sucursal")]
    public int IdSucursal { get; set; }

    [Column("id_almacen")]
    public int IdAlmacen { get; set; }

    [Column("id_sucursal_origen")]
    public int? IdSucursalOrigen { get; set; }

    [Column("id_almacen_origen")]
    public int? IdAlmacenOrigen { get; set; }

    [Column("id_empleado")]
    public int IdEmpleado { get; set; }

    [Column("tipo_movimiento_almacen")]
    [StringLength(14)]
    [Unicode(false)]
    public string? TipoMovimientoAlmacen { get; set; }

    [Column("proceso_almacen")]
    [StringLength(20)]
    [Unicode(false)]
    public string? ProcesoAlmacen { get; set; }

    [Column("nro_mov_almacen")]
    public int? NroMovAlmacen { get; set; }

    [Column("nro_orden_almacen")]
    public int? NroOrdenAlmacen { get; set; }

    [Column("serie_proceso")]
    [StringLength(12)]
    [Unicode(false)]
    public string? SerieProceso { get; set; }

    [Column("nro_correlativo_proceso")]
    [StringLength(20)]
    [Unicode(false)]
    public string? NroCorrelativoProceso { get; set; }

    [Column("fecha_movimiento_almacen", TypeName = "datetime")]
    public DateTime? FechaMovimientoAlmacen { get; set; }

    [Column("tipo_documento_referencia")]
    [StringLength(20)]
    [Unicode(false)]
    public string? TipoDocumentoReferencia { get; set; }

    [Column("nro_documento_referencia")]
    [StringLength(20)]
    [Unicode(false)]
    public string? NroDocumentoReferencia { get; set; }

    [Column("transportista")]
    [StringLength(30)]
    [Unicode(false)]
    public string? Transportista { get; set; }

    [Column("vehiculo")]
    [StringLength(20)]
    [Unicode(false)]
    public string? Vehiculo { get; set; }

    [Column("chofer")]
    [StringLength(30)]
    [Unicode(false)]
    public string? Chofer { get; set; }

    [Column("imp_neto", TypeName = "numeric(14, 6)")]
    public decimal? ImpNeto { get; set; }

    [Column("imp_base_isc", TypeName = "numeric(14, 6)")]
    public decimal? ImpBaseIsc { get; set; }

    [Column("imp_isc", TypeName = "numeric(14, 6)")]
    public decimal? ImpIsc { get; set; }

    [Column("imp_base_igv", TypeName = "numeric(14, 6)")]
    public decimal? ImpBaseIgv { get; set; }

    [Column("imp_igv", TypeName = "numeric(14, 6)")]
    public decimal? ImpIgv { get; set; }

    [Column("imp_cobrar", TypeName = "numeric(14, 6)")]
    public decimal? ImpCobrar { get; set; }

    [Column("es_activo")]
    public byte EsActivo { get; set; }

    [Column("es_eliminado")]
    public byte EsEliminado { get; set; }

    [Column("usuario_creacion")]
    [StringLength(14)]
    [Unicode(false)]
    public string? UsuarioCreacion { get; set; }

    [Column("fecha_creacion", TypeName = "datetime")]
    public DateTime? FechaCreacion { get; set; }

    [Column("usuario_modificacion")]
    [StringLength(14)]
    [Unicode(false)]
    public string? UsuarioModificacion { get; set; }

    [Column("fecha_modificacion", TypeName = "datetime")]
    public DateTime? FechaModificacion { get; set; }

    [ForeignKey("IdAlmacen")]
    [InverseProperty("TMovimientoAlmacenIdAlmacenNavigations")]
    public virtual MAlmacen IdAlmacenNavigation { get; set; } = null!;

    [ForeignKey("IdAlmacenOrigen")]
    [InverseProperty("TMovimientoAlmacenIdAlmacenOrigenNavigations")]
    public virtual MAlmacen? IdAlmacenOrigenNavigation { get; set; }

    [ForeignKey("IdEmpleado")]
    [InverseProperty("TMovimientoAlmacens")]
    public virtual MEmpleado IdEmpleadoNavigation { get; set; } = null!;

    [ForeignKey("IdEmpresa")]
    [InverseProperty("TMovimientoAlmacens")]
    public virtual MEmpresa IdEmpresaNavigation { get; set; } = null!;

    [ForeignKey("IdSucursal")]
    [InverseProperty("TMovimientoAlmacenIdSucursalNavigations")]
    public virtual MSucursal IdSucursalNavigation { get; set; } = null!;

    [ForeignKey("IdSucursalOrigen")]
    [InverseProperty("TMovimientoAlmacenIdSucursalOrigenNavigations")]
    public virtual MSucursal? IdSucursalOrigenNavigation { get; set; }

    [InverseProperty("IdMovimientoAlmacenNavigation")]
    public virtual ICollection<TMovimientoAlmacenDetalle> TMovimientoAlmacenDetalles { get; set; } = new List<TMovimientoAlmacenDetalle>();
}
