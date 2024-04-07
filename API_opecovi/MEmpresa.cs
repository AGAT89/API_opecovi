using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace API_opecovi;

[Table("m_empresa")]
public partial class MEmpresa
{
    [Key]
    [Column("id_empresa")]
    public int IdEmpresa { get; set; }

    [Column("cod_empresa")]
    [StringLength(4)]
    [Unicode(false)]
    public string CodEmpresa { get; set; } = null!;

    [Column("nomb_empresa")]
    [StringLength(50)]
    [Unicode(false)]
    public string NombEmpresa { get; set; } = null!;

    [Column("ruc")]
    [StringLength(20)]
    [Unicode(false)]
    public string Ruc { get; set; } = null!;

    [Column("direccion")]
    [StringLength(20)]
    [Unicode(false)]
    public string? Direccion { get; set; }

    [Column("telefono")]
    [StringLength(12)]
    [Unicode(false)]
    public string? Telefono { get; set; }

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

    [InverseProperty("IdEmpresaNavigation")]
    public virtual ICollection<MAlmacen> MAlmacens { get; set; } = new List<MAlmacen>();

    [InverseProperty("IdEmpresaNavigation")]
    public virtual ICollection<MArea> MAreas { get; set; } = new List<MArea>();

    [InverseProperty("IdEmpresaNavigation")]
    public virtual ICollection<MArticulo> MArticulos { get; set; } = new List<MArticulo>();

    [InverseProperty("IdEmpresaNavigation")]
    public virtual ICollection<MCargo> MCargos { get; set; } = new List<MCargo>();

    [InverseProperty("IdEmpresaNavigation")]
    public virtual ICollection<MEmpleado> MEmpleados { get; set; } = new List<MEmpleado>();

    [InverseProperty("IdEmpresaNavigation")]
    public virtual ICollection<MEstado> MEstados { get; set; } = new List<MEstado>();

    [InverseProperty("IdEmpresaNavigation")]
    public virtual ICollection<MModuloWeb> MModuloWebs { get; set; } = new List<MModuloWeb>();

    [InverseProperty("IdEmpresaNavigation")]
    public virtual ICollection<MPersona> MPersonas { get; set; } = new List<MPersona>();

    [InverseProperty("IdEmpresaNavigation")]
    public virtual ICollection<MProcesoAlmacen> MProcesoAlmacens { get; set; } = new List<MProcesoAlmacen>();

    [InverseProperty("IdEmpresaNavigation")]
    public virtual ICollection<MProveedor> MProveedors { get; set; } = new List<MProveedor>();

    [InverseProperty("IdEmpresaNavigation")]
    public virtual ICollection<MSucursal> MSucursals { get; set; } = new List<MSucursal>();

    [InverseProperty("IdEmpresaNavigation")]
    public virtual ICollection<MTipoMovimientoAlmacen> MTipoMovimientoAlmacens { get; set; } = new List<MTipoMovimientoAlmacen>();

    [InverseProperty("IdEmpresaNavigation")]
    public virtual ICollection<MUsuarioModulo> MUsuarioModulos { get; set; } = new List<MUsuarioModulo>();

    [InverseProperty("IdEmpresaNavigation")]
    public virtual ICollection<MUsuarioSucursal> MUsuarioSucursals { get; set; } = new List<MUsuarioSucursal>();

    [InverseProperty("IdEmpresaNavigation")]
    public virtual ICollection<MUsuario> MUsuarios { get; set; } = new List<MUsuario>();

    [InverseProperty("IdEmpresaNavigation")]
    public virtual ICollection<TCotizacionDetalle> TCotizacionDetalles { get; set; } = new List<TCotizacionDetalle>();

    [InverseProperty("IdEmpresaNavigation")]
    public virtual ICollection<TCotizacion> TCotizacions { get; set; } = new List<TCotizacion>();

    [InverseProperty("IdEmpresaNavigation")]
    public virtual ICollection<TMovimientoAlmacenDetalle> TMovimientoAlmacenDetalles { get; set; } = new List<TMovimientoAlmacenDetalle>();

    [InverseProperty("IdEmpresaNavigation")]
    public virtual ICollection<TMovimientoAlmacen> TMovimientoAlmacens { get; set; } = new List<TMovimientoAlmacen>();

    [InverseProperty("IdEmpresaNavigation")]
    public virtual ICollection<TOrdenCompraDetalle> TOrdenCompraDetalles { get; set; } = new List<TOrdenCompraDetalle>();

    [InverseProperty("IdEmpresaNavigation")]
    public virtual ICollection<TOrdenCompra> TOrdenCompras { get; set; } = new List<TOrdenCompra>();

    [InverseProperty("IdEmpresaNavigation")]
    public virtual ICollection<TRegistroCompraDetalle> TRegistroCompraDetalles { get; set; } = new List<TRegistroCompraDetalle>();

    [InverseProperty("IdEmpresaNavigation")]
    public virtual ICollection<TRegistroCompra> TRegistroCompras { get; set; } = new List<TRegistroCompra>();

    [InverseProperty("IdEmpresaNavigation")]
    public virtual ICollection<TRequerimientoDetalle> TRequerimientoDetalles { get; set; } = new List<TRequerimientoDetalle>();

    [InverseProperty("IdEmpresaNavigation")]
    public virtual ICollection<TRequerimiento> TRequerimientos { get; set; } = new List<TRequerimiento>();

    [InverseProperty("IdEmpresaNavigation")]
    public virtual ICollection<TSolicitudCompraDetalle> TSolicitudCompraDetalles { get; set; } = new List<TSolicitudCompraDetalle>();

    [InverseProperty("IdEmpresaNavigation")]
    public virtual ICollection<TSolicitudCompra> TSolicitudCompras { get; set; } = new List<TSolicitudCompra>();
}
