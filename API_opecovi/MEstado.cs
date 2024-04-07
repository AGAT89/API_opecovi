using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace API_opecovi;

[Table("m_estados")]
public partial class MEstado
{
    [Key]
    [Column("id_estados")]
    public int IdEstados { get; set; }

    [Column("id_empresa")]
    public int IdEmpresa { get; set; }

    [Column("nomb_tabla")]
    [StringLength(50)]
    [Unicode(false)]
    public string NombTabla { get; set; } = null!;

    [Column("codigo_estado")]
    [StringLength(12)]
    [Unicode(false)]
    public string CodigoEstado { get; set; } = null!;

    [Column("nomb_estados")]
    [StringLength(30)]
    [Unicode(false)]
    public string NombEstados { get; set; } = null!;

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
    [InverseProperty("MEstados")]
    public virtual MEmpresa IdEmpresaNavigation { get; set; } = null!;
}
