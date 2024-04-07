using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace API_opecovi;

[Table("m_empleado")]
public partial class MEmpleado
{
    [Key]
    [Column("id_empleado")]
    public int IdEmpleado { get; set; }

    [Column("id_empresa")]
    public int IdEmpresa { get; set; }

    [Column("id_persona")]
    public int IdPersona { get; set; }

    [Column("id_area")]
    public int IdArea { get; set; }

    [Column("id_cargo")]
    public int IdCargo { get; set; }

    [Column("es_activo")]
    public byte EsActivo { get; set; }

    [Column("es_eliminado")]
    public byte EsEliminado { get; set; }

    [Column("fecha_creacion", TypeName = "datetime")]
    public DateTime? FechaCreacion { get; set; }

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

    [ForeignKey("IdArea")]
    [InverseProperty("MEmpleados")]
    public virtual MArea IdAreaNavigation { get; set; } = null!;

    [ForeignKey("IdCargo")]
    [InverseProperty("MEmpleados")]
    public virtual MCargo IdCargoNavigation { get; set; } = null!;

    [ForeignKey("IdEmpresa")]
    [InverseProperty("MEmpleados")]
    public virtual MEmpresa IdEmpresaNavigation { get; set; } = null!;

    [ForeignKey("IdPersona")]
    [InverseProperty("MEmpleados")]
    public virtual MPersona IdPersonaNavigation { get; set; } = null!;

    [InverseProperty("IdEmpleadoNavigation")]
    public virtual ICollection<MUsuario> MUsuarios { get; set; } = new List<MUsuario>();

    [InverseProperty("IdEmpleadoAprobacionNavigation")]
    public virtual ICollection<TCotizacion> TCotizacionIdEmpleadoAprobacionNavigations { get; set; } = new List<TCotizacion>();

    [InverseProperty("IdEmpleadoNavigation")]
    public virtual ICollection<TCotizacion> TCotizacionIdEmpleadoNavigations { get; set; } = new List<TCotizacion>();

    [InverseProperty("IdEmpleadoNavigation")]
    public virtual ICollection<TMovimientoAlmacen> TMovimientoAlmacens { get; set; } = new List<TMovimientoAlmacen>();

    [InverseProperty("IdEmpleadoAprobadorNavigation")]
    public virtual ICollection<TOrdenCompra> TOrdenCompraIdEmpleadoAprobadorNavigations { get; set; } = new List<TOrdenCompra>();

    [InverseProperty("IdEmpleadoNavigation")]
    public virtual ICollection<TOrdenCompra> TOrdenCompraIdEmpleadoNavigations { get; set; } = new List<TOrdenCompra>();

    [InverseProperty("IdEmpleadoAprobadorNavigation")]
    public virtual ICollection<TRegistroCompra> TRegistroCompraIdEmpleadoAprobadorNavigations { get; set; } = new List<TRegistroCompra>();

    [InverseProperty("IdEmpleadoNavigation")]
    public virtual ICollection<TRegistroCompra> TRegistroCompraIdEmpleadoNavigations { get; set; } = new List<TRegistroCompra>();

    [InverseProperty("IdEmpleadoAprobadorNavigation")]
    public virtual ICollection<TRequerimiento> TRequerimientoIdEmpleadoAprobadorNavigations { get; set; } = new List<TRequerimiento>();

    [InverseProperty("IdEmpleadoNavigation")]
    public virtual ICollection<TRequerimiento> TRequerimientoIdEmpleadoNavigations { get; set; } = new List<TRequerimiento>();

    [InverseProperty("IdEmpleadoAprobadorNavigation")]
    public virtual ICollection<TSolicitudCompra> TSolicitudCompraIdEmpleadoAprobadorNavigations { get; set; } = new List<TSolicitudCompra>();

    [InverseProperty("IdEmpleadoNavigation")]
    public virtual ICollection<TSolicitudCompra> TSolicitudCompraIdEmpleadoNavigations { get; set; } = new List<TSolicitudCompra>();
}
