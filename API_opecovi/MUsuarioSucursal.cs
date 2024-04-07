using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace API_opecovi;

[Table("m_usuario_sucursal")]
public partial class MUsuarioSucursal
{
    [Key]
    [Column("id_usuario_sucursal")]
    public int IdUsuarioSucursal { get; set; }

    [Column("id_empresa")]
    public int IdEmpresa { get; set; }

    [Column("id_sucursal")]
    public int IdSucursal { get; set; }

    [Column("id_usuario")]
    public int IdUsuario { get; set; }

    [Column("usuario")]
    [StringLength(12)]
    [Unicode(false)]
    public string Usuario { get; set; } = null!;

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
    [InverseProperty("MUsuarioSucursals")]
    public virtual MEmpresa IdEmpresaNavigation { get; set; } = null!;

    [ForeignKey("IdSucursal")]
    [InverseProperty("MUsuarioSucursals")]
    public virtual MSucursal IdSucursalNavigation { get; set; } = null!;

    [ForeignKey("IdUsuario")]
    [InverseProperty("MUsuarioSucursals")]
    public virtual MUsuario IdUsuarioNavigation { get; set; } = null!;
}
