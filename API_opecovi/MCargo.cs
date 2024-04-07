using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace API_opecovi;

[Table("m_cargo")]
public partial class MCargo
{
    [Key]
    [Column("id_cargo")]
    public int IdCargo { get; set; }

    [Column("id_empresa")]
    public int IdEmpresa { get; set; }

    [Column("id_area")]
    public int IdArea { get; set; }

    [Column("cod_cargo")]
    [StringLength(12)]
    [Unicode(false)]
    public string CodCargo { get; set; } = null!;

    [Column("nomb_cargo")]
    [StringLength(30)]
    [Unicode(false)]
    public string NombCargo { get; set; } = null!;

    [Column("es_activo")]
    public byte EsActivo { get; set; }

    [Column("es_eliminado")]
    public byte EsEliminado { get; set; }

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

    [ForeignKey("IdArea")]
    [InverseProperty("MCargos")]
    public virtual MArea IdAreaNavigation { get; set; } = null!;

    [ForeignKey("IdEmpresa")]
    [InverseProperty("MCargos")]
    public virtual MEmpresa IdEmpresaNavigation { get; set; } = null!;

    [InverseProperty("IdCargoNavigation")]
    public virtual ICollection<MEmpleado> MEmpleados { get; set; } = new List<MEmpleado>();
}
