using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace API_opecovi;

[Table("t_movimiento_almacen_detalle")]
public partial class TMovimientoAlmacenDetalle
{
    [Key]
    [Column("id_movimiento_almacen_detalle")]
    public int IdMovimientoAlmacenDetalle { get; set; }

    [Column("id_empresa")]
    public int IdEmpresa { get; set; }

    [Column("id_sucursal")]
    public int IdSucursal { get; set; }

    [Column("id_movimiento_almacen")]
    public int IdMovimientoAlmacen { get; set; }

    [Column("id_articulo")]
    public int IdArticulo { get; set; }

    [Column("cant_movimiento_almacen")]
    [StringLength(20)]
    [Unicode(false)]
    public string CantMovimientoAlmacen { get; set; } = null!;

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

    [Column("saldo_fisico")]
    [StringLength(14)]
    [Unicode(false)]
    public string? SaldoFisico { get; set; }

    [Column("saldo_valor")]
    [StringLength(14)]
    [Unicode(false)]
    public string? SaldoValor { get; set; }

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

    [ForeignKey("IdArticulo")]
    [InverseProperty("TMovimientoAlmacenDetalles")]
    public virtual MArticulo IdArticuloNavigation { get; set; } = null!;

    [ForeignKey("IdEmpresa")]
    [InverseProperty("TMovimientoAlmacenDetalles")]
    public virtual MEmpresa IdEmpresaNavigation { get; set; } = null!;

    [ForeignKey("IdMovimientoAlmacen")]
    [InverseProperty("TMovimientoAlmacenDetalles")]
    public virtual TMovimientoAlmacen IdMovimientoAlmacenNavigation { get; set; } = null!;

    [ForeignKey("IdSucursal")]
    [InverseProperty("TMovimientoAlmacenDetalles")]
    public virtual MSucursal IdSucursalNavigation { get; set; } = null!;
}
