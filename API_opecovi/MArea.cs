using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace API_opecovi;

[Table("m_area")]
public partial class MArea
{
    [Key]
    [Column("id_area")]
    public int IdArea { get; set; }

    [Column("id_empresa")]
    public int IdEmpresa { get; set; }

    [Column("cod_area")]
    [StringLength(12)]
    [Unicode(false)]
    public string CodArea { get; set; } = null!;

    [Column("nomb_area")]
    [StringLength(30)]
    [Unicode(false)]
    public string NombArea { get; set; } = null!;

    [Column("centro_costos")]
    [StringLength(14)]
    [Unicode(false)]
    public string? CentroCostos { get; set; }

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

    [ForeignKey("IdEmpresa")]
    [InverseProperty("MAreas")]
    public virtual MEmpresa IdEmpresaNavigation { get; set; } = null!;

    [InverseProperty("IdAreaNavigation")]
    public virtual ICollection<MCargo> MCargos { get; set; } = new List<MCargo>();

    [InverseProperty("IdAreaNavigation")]
    public virtual ICollection<MEmpleado> MEmpleados { get; set; } = new List<MEmpleado>();
}
