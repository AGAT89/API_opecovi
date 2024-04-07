using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace API_opecovi;

[Table("m_articulo")]
public partial class MArticulo
{
    [Key]
    [Column("id_articulo")]
    public int IdArticulo { get; set; }

    [Column("id_empresa")]
    public int? IdEmpresa { get; set; }

    [Column("cod_articulo")]
    [StringLength(12)]
    [Unicode(false)]
    public string CodArticulo { get; set; } = null!;

    [Column("nomb_articulo")]
    [StringLength(30)]
    [Unicode(false)]
    public string NombArticulo { get; set; } = null!;

    [Column("unidad_medida")]
    [StringLength(20)]
    [Unicode(false)]
    public string UnidadMedida { get; set; } = null!;

    [Column("contenido_articulo")]
    public int ContenidoArticulo { get; set; }

    [Column("peso_articulo")]
    public int? PesoArticulo { get; set; }

    [Column("volumen_articulo")]
    public int? VolumenArticulo { get; set; }

    [Column("stock_minimo")]
    public int? StockMinimo { get; set; }

    [Column("stock_maximo")]
    public int? StockMaximo { get; set; }

    [Column("tipo_articulo")]
    [StringLength(20)]
    [Unicode(false)]
    public string TipoArticulo { get; set; } = null!;

    [Column("cod_barra_articulo")]
    [StringLength(12)]
    [Unicode(false)]
    public string? CodBarraArticulo { get; set; }

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

    [ForeignKey("IdEmpresa")]
    [InverseProperty("MArticulos")]
    public virtual MEmpresa? IdEmpresaNavigation { get; set; }

    [InverseProperty("IdArticuloNavigation")]
    public virtual ICollection<TCotizacionDetalle> TCotizacionDetalles { get; set; } = new List<TCotizacionDetalle>();

    [InverseProperty("IdArticuloNavigation")]
    public virtual ICollection<TMovimientoAlmacenDetalle> TMovimientoAlmacenDetalles { get; set; } = new List<TMovimientoAlmacenDetalle>();

    [InverseProperty("IdArticuloNavigation")]
    public virtual ICollection<TOrdenCompraDetalle> TOrdenCompraDetalles { get; set; } = new List<TOrdenCompraDetalle>();

    [InverseProperty("IdArticuloNavigation")]
    public virtual ICollection<TRegistroCompraDetalle> TRegistroCompraDetalles { get; set; } = new List<TRegistroCompraDetalle>();

    [InverseProperty("IdArticuloNavigation")]
    public virtual ICollection<TRequerimientoDetalle> TRequerimientoDetalles { get; set; } = new List<TRequerimientoDetalle>();

    [InverseProperty("IdArticuloNavigation")]
    public virtual ICollection<TSolicitudCompraDetalle> TSolicitudCompraDetalles { get; set; } = new List<TSolicitudCompraDetalle>();
}
