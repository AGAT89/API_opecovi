using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace API_opecovi;

[Table("m_persona")]
public partial class MPersona
{
    [Key]
    [Column("id_persona")]
    public int IdPersona { get; set; }

    [Column("id_empresa")]
    public int? IdEmpresa { get; set; }

    [Column("tipo_persona")]
    [StringLength(12)]
    [Unicode(false)]
    public string TipoPersona { get; set; } = null!;

    [Column("tipo_documento")]
    [StringLength(14)]
    [Unicode(false)]
    public string TipoDocumento { get; set; } = null!;

    [Column("documento_identidad")]
    [StringLength(9)]
    [Unicode(false)]
    public string DocumentoIdentidad { get; set; } = null!;

    [Column("apellido_paterno")]
    [StringLength(14)]
    [Unicode(false)]
    public string ApellidoPaterno { get; set; } = null!;

    [Column("apellido_materno")]
    [StringLength(14)]
    [Unicode(false)]
    public string ApellidoMaterno { get; set; } = null!;

    [Column("nombres")]
    [StringLength(30)]
    [Unicode(false)]
    public string Nombres { get; set; } = null!;

    [Column("razon_social")]
    [StringLength(30)]
    [Unicode(false)]
    public string? RazonSocial { get; set; }

    [Column("direccion")]
    [StringLength(20)]
    [Unicode(false)]
    public string Direccion { get; set; } = null!;

    [Column("ubigeo")]
    [StringLength(8)]
    [Unicode(false)]
    public string Ubigeo { get; set; } = null!;

    [Column("telefono")]
    public int Telefono { get; set; }

    [Column("es_empleado")]
    public byte EsEmpleado { get; set; }

    [Column("es_proveedor")]
    public byte EsProveedor { get; set; }

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
    [InverseProperty("MPersonas")]
    public virtual MEmpresa? IdEmpresaNavigation { get; set; }

    [InverseProperty("IdPersonaNavigation")]
    public virtual ICollection<MEmpleado> MEmpleados { get; set; } = new List<MEmpleado>();
}
