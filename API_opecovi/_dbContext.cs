using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace API_opecovi;

public partial class _dbContext : DbContext
{
    public _dbContext()
    {
    }

    public _dbContext(DbContextOptions<_dbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<MAlmacen> MAlmacens { get; set; }

    public virtual DbSet<MArea> MAreas { get; set; }

    public virtual DbSet<MArticulo> MArticulos { get; set; }

    public virtual DbSet<MCargo> MCargos { get; set; }

    public virtual DbSet<MEmpleado> MEmpleados { get; set; }

    public virtual DbSet<MEmpresa> MEmpresas { get; set; }

    public virtual DbSet<MEstado> MEstados { get; set; }

    public virtual DbSet<MModuloWeb> MModuloWebs { get; set; }

    public virtual DbSet<MPersona> MPersonas { get; set; }

    public virtual DbSet<MProcesoAlmacen> MProcesoAlmacens { get; set; }

    public virtual DbSet<MProveedor> MProveedors { get; set; }

    public virtual DbSet<MSucursal> MSucursals { get; set; }

    public virtual DbSet<MTipoMovimientoAlmacen> MTipoMovimientoAlmacens { get; set; }

    public virtual DbSet<MUsuario> MUsuarios { get; set; }

    public virtual DbSet<MUsuarioModulo> MUsuarioModulos { get; set; }

    public virtual DbSet<MUsuarioSucursal> MUsuarioSucursals { get; set; }

    public virtual DbSet<TCotizacion> TCotizacions { get; set; }

    public virtual DbSet<TCotizacionDetalle> TCotizacionDetalles { get; set; }

    public virtual DbSet<TMovimientoAlmacen> TMovimientoAlmacens { get; set; }

    public virtual DbSet<TMovimientoAlmacenDetalle> TMovimientoAlmacenDetalles { get; set; }

    public virtual DbSet<TOrdenCompra> TOrdenCompras { get; set; }

    public virtual DbSet<TOrdenCompraDetalle> TOrdenCompraDetalles { get; set; }

    public virtual DbSet<TRegistroCompra> TRegistroCompras { get; set; }

    public virtual DbSet<TRegistroCompraDetalle> TRegistroCompraDetalles { get; set; }

    public virtual DbSet<TRequerimiento> TRequerimientos { get; set; }

    public virtual DbSet<TRequerimientoDetalle> TRequerimientoDetalles { get; set; }

    public virtual DbSet<TSolicitudCompra> TSolicitudCompras { get; set; }

    public virtual DbSet<TSolicitudCompraDetalle> TSolicitudCompraDetalles { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("workstation id=DBopecovi.mssql.somee.com;packet size=4096;user id=usr_developer;pwd=123+opecovi;data source=DBopecovi.mssql.somee.com;persist security info=False;initial catalog=DBopecovi;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.UseCollation("Modern_Spanish_CI_AS");

        modelBuilder.Entity<MAlmacen>(entity =>
        {
            entity.HasKey(e => e.IdAlmacen).HasName("XPKm_almacen");

            entity.HasOne(d => d.IdEmpresaNavigation).WithMany(p => p.MAlmacens).HasConstraintName("R_116");

            entity.HasOne(d => d.IdSucursalNavigation).WithMany(p => p.MAlmacens).HasConstraintName("R_100");
        });

        modelBuilder.Entity<MArea>(entity =>
        {
            entity.HasKey(e => e.IdArea).HasName("XPKm_area");

            entity.HasOne(d => d.IdEmpresaNavigation).WithMany(p => p.MAreas)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("R_122");
        });

        modelBuilder.Entity<MArticulo>(entity =>
        {
            entity.HasKey(e => e.IdArticulo).HasName("XPKm_articulo");

            entity.HasOne(d => d.IdEmpresaNavigation).WithMany(p => p.MArticulos).HasConstraintName("R_90");
        });

        modelBuilder.Entity<MCargo>(entity =>
        {
            entity.HasKey(e => e.IdCargo).HasName("XPKm_cargo");

            entity.HasOne(d => d.IdAreaNavigation).WithMany(p => p.MCargos)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("R_171");

            entity.HasOne(d => d.IdEmpresaNavigation).WithMany(p => p.MCargos)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("R_92");
        });

        modelBuilder.Entity<MEmpleado>(entity =>
        {
            entity.HasKey(e => e.IdEmpleado).HasName("XPKm_empleado");

            entity.Property(e => e.IdEmpleado).ValueGeneratedNever();

            entity.HasOne(d => d.IdAreaNavigation).WithMany(p => p.MEmpleados)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("R_169");

            entity.HasOne(d => d.IdCargoNavigation).WithMany(p => p.MEmpleados)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("R_170");

            entity.HasOne(d => d.IdEmpresaNavigation).WithMany(p => p.MEmpleados)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("R_79");

            entity.HasOne(d => d.IdPersonaNavigation).WithMany(p => p.MEmpleados)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("R_77");
        });

        modelBuilder.Entity<MEmpresa>(entity =>
        {
            entity.HasKey(e => e.IdEmpresa).HasName("XPKm_empresa");
        });

        modelBuilder.Entity<MEstado>(entity =>
        {
            entity.HasKey(e => e.IdEstados).HasName("XPKm_estados");

            entity.HasOne(d => d.IdEmpresaNavigation).WithMany(p => p.MEstados)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("R_101");
        });

        modelBuilder.Entity<MModuloWeb>(entity =>
        {
            entity.HasKey(e => e.IdModuloWeb).HasName("XPKm_modulos_web");

            entity.HasOne(d => d.IdEmpresaNavigation).WithMany(p => p.MModuloWebs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("R_121");
        });

        modelBuilder.Entity<MPersona>(entity =>
        {
            entity.HasKey(e => e.IdPersona).HasName("XPKm_persona");

            entity.Property(e => e.IdPersona).ValueGeneratedNever();

            entity.HasOne(d => d.IdEmpresaNavigation).WithMany(p => p.MPersonas).HasConstraintName("R_78");
        });

        modelBuilder.Entity<MProcesoAlmacen>(entity =>
        {
            entity.HasKey(e => e.IdProcesoAlmacen).HasName("XPKm_proceso_almacen");

            entity.HasOne(d => d.IdEmpresaNavigation).WithMany(p => p.MProcesoAlmacens)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("R_74");

            entity.HasOne(d => d.IdTipoMovimientoAlmacenNavigation).WithMany(p => p.MProcesoAlmacens)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("R_73");
        });

        modelBuilder.Entity<MProveedor>(entity =>
        {
            entity.HasKey(e => e.IdProveedor).HasName("XPKm_proveedor");

            entity.Property(e => e.IdProveedor).ValueGeneratedNever();

            entity.HasOne(d => d.IdEmpresaNavigation).WithMany(p => p.MProveedors)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("R_117");
        });

        modelBuilder.Entity<MSucursal>(entity =>
        {
            entity.HasKey(e => e.IdSucursal).HasName("XPKm_sucursal");

            entity.HasOne(d => d.IdEmpresaNavigation).WithMany(p => p.MSucursals).HasConstraintName("R_88");
        });

        modelBuilder.Entity<MTipoMovimientoAlmacen>(entity =>
        {
            entity.HasKey(e => e.IdTipoMovimientoAlmacen).HasName("XPKm_tipo_movimiento_almacen");

            entity.HasOne(d => d.IdEmpresaNavigation).WithMany(p => p.MTipoMovimientoAlmacens)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("R_72");
        });

        modelBuilder.Entity<MUsuario>(entity =>
        {
            entity.HasKey(e => e.IdUsuario).HasName("XPKm_usuario");

            entity.HasOne(d => d.IdEmpleadoNavigation).WithMany(p => p.MUsuarios)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("R_96");

            entity.HasOne(d => d.IdEmpresaNavigation).WithMany(p => p.MUsuarios)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("R_118");
        });

        modelBuilder.Entity<MUsuarioModulo>(entity =>
        {
            entity.HasKey(e => e.IdUsuarioModulo).HasName("XPKm_usuario_modulo");

            entity.HasOne(d => d.IdEmpresaNavigation).WithMany(p => p.MUsuarioModulos)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("R_120");

            entity.HasOne(d => d.IdModuloWebNavigation).WithMany(p => p.MUsuarioModulos)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("R_95");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.MUsuarioModulos)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("R_97");
        });

        modelBuilder.Entity<MUsuarioSucursal>(entity =>
        {
            entity.HasKey(e => e.IdUsuarioSucursal).HasName("XPKm_usuario_sucursal");

            entity.HasOne(d => d.IdEmpresaNavigation).WithMany(p => p.MUsuarioSucursals)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("R_119");

            entity.HasOne(d => d.IdSucursalNavigation).WithMany(p => p.MUsuarioSucursals)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("R_99");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.MUsuarioSucursals)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("R_98");
        });

        modelBuilder.Entity<TCotizacion>(entity =>
        {
            entity.HasKey(e => e.IdCotizacion).HasName("XPKt_cotizacion");

            entity.HasOne(d => d.IdEmpleadoNavigation).WithMany(p => p.TCotizacionIdEmpleadoNavigations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("R_145");

            entity.HasOne(d => d.IdEmpleadoAprobacionNavigation).WithMany(p => p.TCotizacionIdEmpleadoAprobacionNavigations).HasConstraintName("R_144");

            entity.HasOne(d => d.IdEmpresaNavigation).WithMany(p => p.TCotizacions)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("R_132");

            entity.HasOne(d => d.IdProveedorNavigation).WithMany(p => p.TCotizacions)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("R_102");

            entity.HasOne(d => d.IdSolicitudCompraNavigation).WithMany(p => p.TCotizacions)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("R_112");

            entity.HasOne(d => d.IdSucursalNavigation).WithMany(p => p.TCotizacions)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("R_172");
        });

        modelBuilder.Entity<TCotizacionDetalle>(entity =>
        {
            entity.HasKey(e => e.IdCotizacionDetalle).HasName("XPKt_cotizacion_detalle");

            entity.HasOne(d => d.IdArticuloNavigation).WithMany(p => p.TCotizacionDetalles)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("R_105");

            entity.HasOne(d => d.IdCotizacionNavigation).WithMany(p => p.TCotizacionDetalles)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("R_123");

            entity.HasOne(d => d.IdEmpresaNavigation).WithMany(p => p.TCotizacionDetalles)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("R_159");

            entity.HasOne(d => d.IdSucursalNavigation).WithMany(p => p.TCotizacionDetalles)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("R_167");
        });

        modelBuilder.Entity<TMovimientoAlmacen>(entity =>
        {
            entity.HasKey(e => e.IdMovimientoAlmacen).HasName("XPKt_movimiento_almacen");

            entity.HasOne(d => d.IdAlmacenNavigation).WithMany(p => p.TMovimientoAlmacenIdAlmacenNavigations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("R_140");

            entity.HasOne(d => d.IdAlmacenOrigenNavigation).WithMany(p => p.TMovimientoAlmacenIdAlmacenOrigenNavigations).HasConstraintName("R_139");

            entity.HasOne(d => d.IdEmpleadoNavigation).WithMany(p => p.TMovimientoAlmacens)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("R_136");

            entity.HasOne(d => d.IdEmpresaNavigation).WithMany(p => p.TMovimientoAlmacens)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("R_131");

            entity.HasOne(d => d.IdSucursalNavigation).WithMany(p => p.TMovimientoAlmacenIdSucursalNavigations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("R_138");

            entity.HasOne(d => d.IdSucursalOrigenNavigation).WithMany(p => p.TMovimientoAlmacenIdSucursalOrigenNavigations).HasConstraintName("R_135");
        });

        modelBuilder.Entity<TMovimientoAlmacenDetalle>(entity =>
        {
            entity.HasKey(e => e.IdMovimientoAlmacenDetalle).HasName("XPKt_movimiento_almacen_detalle");

            entity.HasOne(d => d.IdArticuloNavigation).WithMany(p => p.TMovimientoAlmacenDetalles)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("R_156");

            entity.HasOne(d => d.IdEmpresaNavigation).WithMany(p => p.TMovimientoAlmacenDetalles)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("R_163");

            entity.HasOne(d => d.IdMovimientoAlmacenNavigation).WithMany(p => p.TMovimientoAlmacenDetalles)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("R_110");

            entity.HasOne(d => d.IdSucursalNavigation).WithMany(p => p.TMovimientoAlmacenDetalles)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("R_164");
        });

        modelBuilder.Entity<TOrdenCompra>(entity =>
        {
            entity.HasKey(e => e.IdOrdenCompra).HasName("XPKt_orden_compra");

            entity.HasOne(d => d.IdCotizacionNavigation).WithMany(p => p.TOrdenCompras)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("R_113");

            entity.HasOne(d => d.IdEmpleadoNavigation).WithMany(p => p.TOrdenCompraIdEmpleadoNavigations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("R_147");

            entity.HasOne(d => d.IdEmpleadoAprobadorNavigation).WithMany(p => p.TOrdenCompraIdEmpleadoAprobadorNavigations).HasConstraintName("R_146");

            entity.HasOne(d => d.IdEmpresaNavigation).WithMany(p => p.TOrdenCompras)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("R_134");

            entity.HasOne(d => d.IdSucursalNavigation).WithMany(p => p.TOrdenCompras)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("R_173");
        });

        modelBuilder.Entity<TOrdenCompraDetalle>(entity =>
        {
            entity.HasKey(e => e.IdOrdenCompraDetalle).HasName("XPKt_orden_compra_detalle");

            entity.HasOne(d => d.IdArticuloNavigation).WithMany(p => p.TOrdenCompraDetalles)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("R_154");

            entity.HasOne(d => d.IdEmpresaNavigation).WithMany(p => p.TOrdenCompraDetalles)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("R_161");

            entity.HasOne(d => d.IdOrdenCompraNavigation).WithMany(p => p.TOrdenCompraDetalles)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("R_107");

            entity.HasOne(d => d.IdSucursalNavigation).WithMany(p => p.TOrdenCompraDetalles)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("R_166");
        });

        modelBuilder.Entity<TRegistroCompra>(entity =>
        {
            entity.HasKey(e => e.IdRegistroCompra).HasName("XPKt_registro_compra");

            entity.HasOne(d => d.IdEmpleadoNavigation).WithMany(p => p.TRegistroCompraIdEmpleadoNavigations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("R_150");

            entity.HasOne(d => d.IdEmpleadoAprobadorNavigation).WithMany(p => p.TRegistroCompraIdEmpleadoAprobadorNavigations).HasConstraintName("R_149");

            entity.HasOne(d => d.IdEmpresaNavigation).WithMany(p => p.TRegistroCompras)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("R_133");

            entity.HasOne(d => d.IdOrdenCompraNavigation).WithMany(p => p.TRegistroCompras)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("R_114");

            entity.HasOne(d => d.IdSucursalNavigation).WithMany(p => p.TRegistroCompras).HasConstraintName("R_151");
        });

        modelBuilder.Entity<TRegistroCompraDetalle>(entity =>
        {
            entity.HasKey(e => e.IdRegistroCompraDetalle).HasName("XPKt_registro_compra_detalle");

            entity.HasOne(d => d.IdArticuloNavigation).WithMany(p => p.TRegistroCompraDetalles)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("R_155");

            entity.HasOne(d => d.IdEmpresaNavigation).WithMany(p => p.TRegistroCompraDetalles)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("R_162");

            entity.HasOne(d => d.IdRegistroCompraNavigation).WithMany(p => p.TRegistroCompraDetalles)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("R_109");

            entity.HasOne(d => d.IdSucursalNavigation).WithMany(p => p.TRegistroCompraDetalles)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("R_165");
        });

        modelBuilder.Entity<TRequerimiento>(entity =>
        {
            entity.HasKey(e => e.IdRequerimiento).HasName("XPKt_requerimiento");

            entity.HasOne(d => d.IdEmpleadoNavigation).WithMany(p => p.TRequerimientoIdEmpleadoNavigations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("R_84");

            entity.HasOne(d => d.IdEmpleadoAprobadorNavigation).WithMany(p => p.TRequerimientoIdEmpleadoAprobadorNavigations).HasConstraintName("R_80");

            entity.HasOne(d => d.IdEmpresaNavigation).WithMany(p => p.TRequerimientos)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("R_82");

            entity.HasOne(d => d.IdSucursalNavigation).WithMany(p => p.TRequerimientos)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("R_81");
        });

        modelBuilder.Entity<TRequerimientoDetalle>(entity =>
        {
            entity.HasKey(e => e.IdRequerimientoDetalle).HasName("XPKt_requerimiento_detalle");

            entity.HasOne(d => d.IdArticuloNavigation).WithMany(p => p.TRequerimientoDetalles)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("R_87");

            entity.HasOne(d => d.IdEmpresaNavigation).WithMany(p => p.TRequerimientoDetalles).HasConstraintName("R_157");

            entity.HasOne(d => d.IdRequerimientoNavigation).WithMany(p => p.TRequerimientoDetalles)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("R_85");
        });

        modelBuilder.Entity<TSolicitudCompra>(entity =>
        {
            entity.HasKey(e => e.IdSolicitudCompra).HasName("XPKt_solicitud_compra");

            entity.HasOne(d => d.IdEmpleadoNavigation).WithMany(p => p.TSolicitudCompraIdEmpleadoNavigations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("R_143");

            entity.HasOne(d => d.IdEmpleadoAprobadorNavigation).WithMany(p => p.TSolicitudCompraIdEmpleadoAprobadorNavigations).HasConstraintName("R_142");

            entity.HasOne(d => d.IdEmpresaNavigation).WithMany(p => p.TSolicitudCompras)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("R_124");

            entity.HasOne(d => d.IdRequerimientoNavigation).WithMany(p => p.TSolicitudCompras).HasConstraintName("R_111");

            entity.HasOne(d => d.IdSucursalNavigation).WithMany(p => p.TSolicitudCompras)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("R_141");
        });

        modelBuilder.Entity<TSolicitudCompraDetalle>(entity =>
        {
            entity.HasKey(e => e.IdSolicitudCompraDetalle).HasName("XPKt_solicitud_compra_detalle");

            entity.HasOne(d => d.IdArticuloNavigation).WithMany(p => p.TSolicitudCompraDetalles).HasConstraintName("R_153");

            entity.HasOne(d => d.IdEmpresaNavigation).WithMany(p => p.TSolicitudCompraDetalles)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("R_158");

            entity.HasOne(d => d.IdSolicitudCompraNavigation).WithMany(p => p.TSolicitudCompraDetalles)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("R_108");

            entity.HasOne(d => d.IdSucursalNavigation).WithMany(p => p.TSolicitudCompraDetalles)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("R_168");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
