using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace API_opecovi;

[Table("m_proceso_almacen")]
public partial class MProcesoAlmacen
{
    [Key]
    [Column("id_proceso_almacen")]
    public int IdProcesoAlmacen { get; set; }

    [Column("id_empresa")]
    public int IdEmpresa { get; set; }

    [Column("id_tipo_movimiento_almacen")]
    public int IdTipoMovimientoAlmacen { get; set; }

    [Column("cod_proceso_almacen")]
    [StringLength(4)]
    [Unicode(false)]
    public string CodProcesoAlmacen { get; set; } = null!;

    [Column("nomb_proceso_almacen")]
    [StringLength(30)]
    [Unicode(false)]
    public string NombProcesoAlmacen { get; set; } = null!;

    [Column("es_activo")]
    public byte EsActivo { get; set; }

    [Column("es_eliminado")]
    public byte EsEliminado { get; set; }

    [Column("fecha_creacion", TypeName = "datetime")]
    public DateTime FechaCreacion { get; set; }

    [Column("usuario_modificacion")]
    [StringLength(20)]
    [Unicode(false)]
    public string UsuarioModificacion { get; set; } = null!;

    [Column("fecha_modificacion", TypeName = "datetime")]
    public DateTime FechaModificacion { get; set; }

    [Column("usuario_creacion")]
    [StringLength(20)]
    [Unicode(false)]
    public string UsuarioCreacion { get; set; } = null!;

    [ForeignKey("IdEmpresa")]
    [InverseProperty("MProcesoAlmacens")]
    public virtual MEmpresa IdEmpresaNavigation { get; set; } = null!;

    [ForeignKey("IdTipoMovimientoAlmacen")]
    [InverseProperty("MProcesoAlmacens")]
    public virtual MTipoMovimientoAlmacen IdTipoMovimientoAlmacenNavigation { get; set; } = null!;
}
