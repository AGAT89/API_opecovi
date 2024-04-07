using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace API_opecovi;

[Table("m_almacen")]
public partial class MAlmacen
{
    [Key]
    [Column("id_almacen")]
    public int IdAlmacen { get; set; }

    [Column("id_empresa")]
    public int? IdEmpresa { get; set; }

    [Column("id_sucursal")]
    public int? IdSucursal { get; set; }

    [Column("cod_almacen")]
    [StringLength(12)]
    [Unicode(false)]
    public string CodAlmacen { get; set; } = null!;

    [Column("nomb_almacen")]
    [StringLength(30)]
    [Unicode(false)]
    public string? NombAlmacen { get; set; }

    [Column("direccion")]
    [StringLength(20)]
    [Unicode(false)]
    public string? Direccion { get; set; }

    [Column("ubigeo")]
    [StringLength(8)]
    [Unicode(false)]
    public string? Ubigeo { get; set; }

    [Column("telefono")]
    public int? Telefono { get; set; }

    [Column("es_activo")]
    public byte EsActivo { get; set; }

    [Column("es_eliminado")]
    public byte EsEliminado { get; set; }

    [Column("usuario_creacion")]
    [StringLength(12)]
    [Unicode(false)]
    public string? UsuarioCreacion { get; set; }

    [Column("fecha_creacion", TypeName = "datetime")]
    public DateTime? FechaCreacion { get; set; }

    [Column("usuario_modificacion")]
    [StringLength(12)]
    [Unicode(false)]
    public string? UsuarioModificacion { get; set; }

    [Column("fecha_modificacion", TypeName = "datetime")]
    public DateTime? FechaModificacion { get; set; }

    [ForeignKey("IdEmpresa")]
    [InverseProperty("MAlmacens")]
    public virtual MEmpresa? IdEmpresaNavigation { get; set; }

    [ForeignKey("IdSucursal")]
    [InverseProperty("MAlmacens")]
    public virtual MSucursal? IdSucursalNavigation { get; set; }

    [InverseProperty("IdAlmacenNavigation")]
    public virtual ICollection<TMovimientoAlmacen> TMovimientoAlmacenIdAlmacenNavigations { get; set; } = new List<TMovimientoAlmacen>();

    [InverseProperty("IdAlmacenOrigenNavigation")]
    public virtual ICollection<TMovimientoAlmacen> TMovimientoAlmacenIdAlmacenOrigenNavigations { get; set; } = new List<TMovimientoAlmacen>();
}
