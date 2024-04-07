using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace API_opecovi;

[Table("m_proveedor")]
public partial class MProveedor
{
    [Key]
    [Column("id_proveedor")]
    public int IdProveedor { get; set; }

    [Column("id_empresa")]
    public int IdEmpresa { get; set; }

    [Column("id_persona")]
    public int IdPersona { get; set; }

    [Column("giro_negocio")]
    [StringLength(14)]
    [Unicode(false)]
    public string GiroNegocio { get; set; } = null!;

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
    [InverseProperty("MProveedors")]
    public virtual MEmpresa IdEmpresaNavigation { get; set; } = null!;

    [InverseProperty("IdProveedorNavigation")]
    public virtual ICollection<TCotizacion> TCotizacions { get; set; } = new List<TCotizacion>();
}
