using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace API_opecovi;

[Table("t_solicitud_compra_detalle")]
public partial class TSolicitudCompraDetalle
{
    [Key]
    [Column("id_solicitud_compra_detalle")]
    public int IdSolicitudCompraDetalle { get; set; }

    [Column("id_empresa")]
    public int IdEmpresa { get; set; }

    [Column("id_sucursal")]
    public int IdSucursal { get; set; }

    [Column("id_solicitud_compra")]
    public int IdSolicitudCompra { get; set; }

    [Column("id_articulo")]
    public int? IdArticulo { get; set; }

    [Column("cant_compra")]
    public int CantCompra { get; set; }

    [Column("fecha_creacion", TypeName = "datetime")]
    public DateTime FechaCreacion { get; set; }

    [Column("usuario_modificacion")]
    [StringLength(12)]
    [Unicode(false)]
    public string UsuarioModificacion { get; set; } = null!;

    [Column("fecha_modificacion", TypeName = "datetime")]
    public DateTime FechaModificacion { get; set; }

    [Column("usuario_creacion")]
    [StringLength(12)]
    [Unicode(false)]
    public string UsuarioCreacion { get; set; } = null!;

    [ForeignKey("IdArticulo")]
    [InverseProperty("TSolicitudCompraDetalles")]
    public virtual MArticulo? IdArticuloNavigation { get; set; }

    [ForeignKey("IdEmpresa")]
    [InverseProperty("TSolicitudCompraDetalles")]
    public virtual MEmpresa IdEmpresaNavigation { get; set; } = null!;

    [ForeignKey("IdSolicitudCompra")]
    [InverseProperty("TSolicitudCompraDetalles")]
    public virtual TSolicitudCompra IdSolicitudCompraNavigation { get; set; } = null!;

    [ForeignKey("IdSucursal")]
    [InverseProperty("TSolicitudCompraDetalles")]
    public virtual MSucursal IdSucursalNavigation { get; set; } = null!;
}
