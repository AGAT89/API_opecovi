using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace API_opecovi;

[Table("t_requerimiento")]
public partial class TRequerimiento
{
    [Key]
    [Column("id_requerimiento")]
    public int IdRequerimiento { get; set; }

    [Column("id_empresa")]
    public int IdEmpresa { get; set; }

    [Column("id_sucursal")]
    public int IdSucursal { get; set; }

    [Column("id_empleado")]
    public int IdEmpleado { get; set; }

    [Column("id_empleado_aprobador")]
    public int? IdEmpleadoAprobador { get; set; }

    [Column("nro_requerimiento")]
    [StringLength(30)]
    [Unicode(false)]
    public string? NroRequerimiento { get; set; }

    [Column("fecha_emision", TypeName = "datetime")]
    public DateTime FechaEmision { get; set; }

    [Column("fecha_creacion", TypeName = "datetime")]
    public DateTime? FechaCreacion { get; set; }

    [Column("es_activo")]
    public byte EsActivo { get; set; }

    [Column("es_eliminado")]
    public byte EsEliminado { get; set; }

    [Column("usuario_modificacion")]
    [StringLength(12)]
    [Unicode(false)]
    public string? UsuarioModificacion { get; set; }

    [Column("fecha_modificacion", TypeName = "datetime")]
    public DateTime? FechaModificacion { get; set; }

    [Column("usuario_creacion")]
    [StringLength(12)]
    [Unicode(false)]
    public string? UsuarioCreacion { get; set; }

    [Column("fecha_aprobacion", TypeName = "datetime")]
    public DateTime? FechaAprobacion { get; set; }

    [ForeignKey("IdEmpleadoAprobador")]
    [InverseProperty("TRequerimientoIdEmpleadoAprobadorNavigations")]
    public virtual MEmpleado? IdEmpleadoAprobadorNavigation { get; set; }

    [ForeignKey("IdEmpleado")]
    [InverseProperty("TRequerimientoIdEmpleadoNavigations")]
    public virtual MEmpleado IdEmpleadoNavigation { get; set; } = null!;

    [ForeignKey("IdEmpresa")]
    [InverseProperty("TRequerimientos")]
    public virtual MEmpresa IdEmpresaNavigation { get; set; } = null!;

    [ForeignKey("IdSucursal")]
    [InverseProperty("TRequerimientos")]
    public virtual MSucursal IdSucursalNavigation { get; set; } = null!;

    [InverseProperty("IdRequerimientoNavigation")]
    public virtual ICollection<TRequerimientoDetalle> TRequerimientoDetalles { get; set; } = new List<TRequerimientoDetalle>();

    [InverseProperty("IdRequerimientoNavigation")]
    public virtual ICollection<TSolicitudCompra> TSolicitudCompras { get; set; } = new List<TSolicitudCompra>();
}
