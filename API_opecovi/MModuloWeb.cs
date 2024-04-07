using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace API_opecovi;

[Table("m_modulo_web")]
public partial class MModuloWeb
{
    [Key]
    [Column("id_modulo_web")]
    public int IdModuloWeb { get; set; }

    [Column("id_empresa")]
    public int IdEmpresa { get; set; }

    [Column("cod_modulo_web")]
    [StringLength(12)]
    [Unicode(false)]
    public string? CodModuloWeb { get; set; }

    [Column("nomb_modulo_web")]
    [StringLength(30)]
    [Unicode(false)]
    public string? NombModuloWeb { get; set; }

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

    [ForeignKey("IdEmpresa")]
    [InverseProperty("MModuloWebs")]
    public virtual MEmpresa IdEmpresaNavigation { get; set; } = null!;

    [InverseProperty("IdModuloWebNavigation")]
    public virtual ICollection<MUsuarioModulo> MUsuarioModulos { get; set; } = new List<MUsuarioModulo>();
}
