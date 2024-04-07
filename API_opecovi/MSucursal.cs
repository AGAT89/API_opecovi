using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace API_opecovi;

[Table("m_sucursal")]
public partial class MSucursal
{
    [Key]
    [Column("id_sucursal")]
    public int IdSucursal { get; set; }

    [Column("id_empresa")]
    public int? IdEmpresa { get; set; }

    [Column("cod_sucursal")]
    [StringLength(12)]
    [Unicode(false)]
    public string CodSucursal { get; set; } = null!;

    [Column("nomb_sucursal")]
    [StringLength(30)]
    [Unicode(false)]
    public string NombSucursal { get; set; } = null!;

    [Column("direcion")]
    [StringLength(20)]
    [Unicode(false)]
    public string Direcion { get; set; } = null!;

    [Column("ubigeo")]
    [StringLength(6)]
    [Unicode(false)]
    public string Ubigeo { get; set; } = null!;

    [Column("telefono")]
    public int? Telefono { get; set; }

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
    [InverseProperty("MSucursals")]
    public virtual MEmpresa? IdEmpresaNavigation { get; set; }

    [InverseProperty("IdSucursalNavigation")]
    public virtual ICollection<MAlmacen> MAlmacens { get; set; } = new List<MAlmacen>();

    [InverseProperty("IdSucursalNavigation")]
    public virtual ICollection<MUsuarioSucursal> MUsuarioSucursals { get; set; } = new List<MUsuarioSucursal>();

    [InverseProperty("IdSucursalNavigation")]
    public virtual ICollection<TCotizacionDetalle> TCotizacionDetalles { get; set; } = new List<TCotizacionDetalle>();

    [InverseProperty("IdSucursalNavigation")]
    public virtual ICollection<TCotizacion> TCotizacions { get; set; } = new List<TCotizacion>();

    [InverseProperty("IdSucursalNavigation")]
    public virtual ICollection<TMovimientoAlmacenDetalle> TMovimientoAlmacenDetalles { get; set; } = new List<TMovimientoAlmacenDetalle>();

    [InverseProperty("IdSucursalNavigation")]
    public virtual ICollection<TMovimientoAlmacen> TMovimientoAlmacenIdSucursalNavigations { get; set; } = new List<TMovimientoAlmacen>();

    [InverseProperty("IdSucursalOrigenNavigation")]
    public virtual ICollection<TMovimientoAlmacen> TMovimientoAlmacenIdSucursalOrigenNavigations { get; set; } = new List<TMovimientoAlmacen>();

    [InverseProperty("IdSucursalNavigation")]
    public virtual ICollection<TOrdenCompraDetalle> TOrdenCompraDetalles { get; set; } = new List<TOrdenCompraDetalle>();

    [InverseProperty("IdSucursalNavigation")]
    public virtual ICollection<TOrdenCompra> TOrdenCompras { get; set; } = new List<TOrdenCompra>();

    [InverseProperty("IdSucursalNavigation")]
    public virtual ICollection<TRegistroCompraDetalle> TRegistroCompraDetalles { get; set; } = new List<TRegistroCompraDetalle>();

    [InverseProperty("IdSucursalNavigation")]
    public virtual ICollection<TRegistroCompra> TRegistroCompras { get; set; } = new List<TRegistroCompra>();

    [InverseProperty("IdSucursalNavigation")]
    public virtual ICollection<TRequerimiento> TRequerimientos { get; set; } = new List<TRequerimiento>();

    [InverseProperty("IdSucursalNavigation")]
    public virtual ICollection<TSolicitudCompraDetalle> TSolicitudCompraDetalles { get; set; } = new List<TSolicitudCompraDetalle>();

    [InverseProperty("IdSucursalNavigation")]
    public virtual ICollection<TSolicitudCompra> TSolicitudCompras { get; set; } = new List<TSolicitudCompra>();
}
