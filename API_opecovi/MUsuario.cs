using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace API_opecovi;

[Table("m_usuario")]
public partial class MUsuario
{
    [Key]
    [Column("id_usuario")]
    public int IdUsuario { get; set; }

    [Column("id_empresa")]
    public int IdEmpresa { get; set; }

    [Column("id_empleado")]
    public int IdEmpleado { get; set; }

    [Column("usuario")]
    [StringLength(12)]
    [Unicode(false)]
    public string Usuario { get; set; } = null!;

    [Column("contraseña")]
    [StringLength(12)]
    [Unicode(false)]
    public string Contraseña { get; set; } = null!;

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

    [ForeignKey("IdEmpleado")]
    [InverseProperty("MUsuarios")]
    public virtual MEmpleado IdEmpleadoNavigation { get; set; } = null!;

    [ForeignKey("IdEmpresa")]
    [InverseProperty("MUsuarios")]
    public virtual MEmpresa IdEmpresaNavigation { get; set; } = null!;

    [InverseProperty("IdUsuarioNavigation")]
    public virtual ICollection<MUsuarioModulo> MUsuarioModulos { get; set; } = new List<MUsuarioModulo>();

    [InverseProperty("IdUsuarioNavigation")]
    public virtual ICollection<MUsuarioSucursal> MUsuarioSucursals { get; set; } = new List<MUsuarioSucursal>();
}
