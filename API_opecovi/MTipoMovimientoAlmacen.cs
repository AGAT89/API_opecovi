using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace API_opecovi;

[Table("m_tipo_movimiento_almacen")]
public partial class MTipoMovimientoAlmacen
{
    [Key]
    [Column("id_tipo_movimiento_almacen")]
    public int IdTipoMovimientoAlmacen { get; set; }

    [Column("id_empresa")]
    public int IdEmpresa { get; set; }

    [Column("cod_accion_movimiento")]
    [StringLength(12)]
    [Unicode(false)]
    public string CodAccionMovimiento { get; set; } = null!;

    [Column("cod_tipo_movimiento_almacen")]
    [StringLength(12)]
    [Unicode(false)]
    public string CodTipoMovimientoAlmacen { get; set; } = null!;

    [Column("nomb_tipo_movimiento_almacen")]
    [StringLength(30)]
    [Unicode(false)]
    public string NombTipoMovimientoAlmacen { get; set; } = null!;

    [Column("es_activo")]
    public byte EsActivo { get; set; }

    [Column("es_eliminado")]
    public byte EsEliminado { get; set; }

    [Column("usuario_creacion")]
    [StringLength(20)]
    [Unicode(false)]
    public string UsuarioCreacion { get; set; } = null!;

    [Column("fecha_creacion", TypeName = "datetime")]
    public DateTime FechaCreacion { get; set; }

    [Column("usuario_modificacion")]
    [StringLength(20)]
    [Unicode(false)]
    public string UsuarioModificacion { get; set; } = null!;

    [Column("fecha_modificacion", TypeName = "datetime")]
    public DateTime FechaModificacion { get; set; }

    [ForeignKey("IdEmpresa")]
    [InverseProperty("MTipoMovimientoAlmacens")]
    public virtual MEmpresa IdEmpresaNavigation { get; set; } = null!;

    [InverseProperty("IdTipoMovimientoAlmacenNavigation")]
    public virtual ICollection<MProcesoAlmacen> MProcesoAlmacens { get; set; } = new List<MProcesoAlmacen>();
}
