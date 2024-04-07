using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace API_opecovi;

[Table("t_orden_compra_detalle")]
public partial class TOrdenCompraDetalle
{
    [Key]
    [Column("id_orden_compra_detalle")]
    public int IdOrdenCompraDetalle { get; set; }

    [Column("id_empresa")]
    public int IdEmpresa { get; set; }

    [Column("id_sucursal")]
    public int IdSucursal { get; set; }

    [Column("id_orden_compra")]
    public int IdOrdenCompra { get; set; }

    [Column("id_articulo")]
    public int IdArticulo { get; set; }

    [Column("cant_orden_compra")]
    public int CantOrdenCompra { get; set; }

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

    [ForeignKey("IdArticulo")]
    [InverseProperty("TOrdenCompraDetalles")]
    public virtual MArticulo IdArticuloNavigation { get; set; } = null!;

    [ForeignKey("IdEmpresa")]
    [InverseProperty("TOrdenCompraDetalles")]
    public virtual MEmpresa IdEmpresaNavigation { get; set; } = null!;

    [ForeignKey("IdOrdenCompra")]
    [InverseProperty("TOrdenCompraDetalles")]
    public virtual TOrdenCompra IdOrdenCompraNavigation { get; set; } = null!;

    [ForeignKey("IdSucursal")]
    [InverseProperty("TOrdenCompraDetalles")]
    public virtual MSucursal IdSucursalNavigation { get; set; } = null!;
}
