using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace API_opecovi;

[Table("t_requerimiento_detalle")]
public partial class TRequerimientoDetalle
{
    [Key]
    [Column("id_requerimiento_detalle")]
    public int IdRequerimientoDetalle { get; set; }

    [Column("id_empresa")]
    public int? IdEmpresa { get; set; }

    [Column("id_requerimiento")]
    public int IdRequerimiento { get; set; }

    [Column("id_articulo")]
    public int IdArticulo { get; set; }

    [Column("cant_solicitada")]
    public int? CantSolicitada { get; set; }

    [Column("cant_atendida")]
    public int? CantAtendida { get; set; }

    [Column("usuario_creacion")]
    [StringLength(12)]
    [Unicode(false)]
    public string? UsuarioCreacion { get; set; }

    [Column("fecha_creacion", TypeName = "datetime")]
    public DateTime FechaCreacion { get; set; }

    [Column("usuario_modificacion")]
    [StringLength(12)]
    [Unicode(false)]
    public string UsuarioModificacion { get; set; } = null!;

    [Column("fecha_modificacion", TypeName = "datetime")]
    public DateTime? FechaModificacion { get; set; }

    [ForeignKey("IdArticulo")]
    [InverseProperty("TRequerimientoDetalles")]
    public virtual MArticulo IdArticuloNavigation { get; set; } = null!;

    [ForeignKey("IdEmpresa")]
    [InverseProperty("TRequerimientoDetalles")]
    public virtual MEmpresa? IdEmpresaNavigation { get; set; }

    [ForeignKey("IdRequerimiento")]
    [InverseProperty("TRequerimientoDetalles")]
    public virtual TRequerimiento IdRequerimientoNavigation { get; set; } = null!;
}
