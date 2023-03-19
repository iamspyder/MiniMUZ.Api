using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace MiniMUZ.Api.MuzModels;

public partial class MiniMuzContext : DbContext
{
    public MiniMuzContext()
    {
    }

    public MiniMuzContext(DbContextOptions<MiniMuzContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Dispatch> Dispatches { get; set; }

    public virtual DbSet<Shipment> Shipments { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<UserWarehouse> UserWarehouses { get; set; }

    public virtual DbSet<Vehicle> Vehicles { get; set; }

    public virtual DbSet<Warehouse> Warehouses { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=DESKTOP-RFV73GF\\SQLEXPRESS;Initial Catalog=MiniMUZ;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Dispatch>(entity =>
        {
            entity.HasKey(e => e.DispatchId).HasName("PK__Dispatch__434DBD755E83DC6D");

            entity.ToTable("Dispatch");

            entity.Property(e => e.DispatchId).HasColumnName("DispatchID");
            entity.Property(e => e.DispatchDate).HasColumnType("date");
            entity.Property(e => e.DispatchDetails)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.Shipment).WithMany(p => p.Dispatches)
                .HasForeignKey(d => d.ShipmentId)
                .HasConstraintName("FK__Dispatch__Shipme__5FB337D6");

            entity.HasOne(d => d.Vehicle).WithMany(p => p.Dispatches)
                .HasForeignKey(d => d.VehicleId)
                .HasConstraintName("FK__Dispatch__Vehicl__60A75C0F");
        });

        modelBuilder.Entity<Shipment>(entity =>
        {
            entity.HasKey(e => e.ShipmentId).HasName("PK__Shipment__5CAD37ED80784ACA");

            entity.ToTable("Shipment");

            entity.Property(e => e.ShipmentDate).HasColumnType("date");
            entity.Property(e => e.ShipmentName)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Uwid).HasColumnName("UWId");

            entity.HasOne(d => d.Uw).WithMany(p => p.Shipments)
                .HasForeignKey(d => d.Uwid)
                .HasConstraintName("FK__Shipment__UWId__5CD6CB2B");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__Users__1788CC4CA01197E9");

            entity.Property(e => e.UserEmail)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.UserName)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<UserWarehouse>(entity =>
        {
            entity.HasKey(e => e.Uwid).HasName("PK__UserWare__B565E05079A9C439");

            entity.ToTable("UserWarehouse");

            entity.Property(e => e.Uwid).HasColumnName("UWId");

            entity.HasOne(d => d.User).WithMany(p => p.UserWarehouses)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK__UserWareh__UserI__3A81B327");

            entity.HasOne(d => d.Warehouse).WithMany(p => p.UserWarehouses)
                .HasForeignKey(d => d.WarehouseId)
                .HasConstraintName("FK__UserWareh__Wareh__3B75D760");
        });

        modelBuilder.Entity<Vehicle>(entity =>
        {
            entity.HasKey(e => e.VehicleId).HasName("PK__Vehicle__476B54920E484688");

            entity.ToTable("Vehicle");

            entity.Property(e => e.OwnerName)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.VehicleName)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.VehicleNo)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Warehouse>(entity =>
        {
            entity.HasKey(e => e.WarehouseId).HasName("PK__Warehous__2608AFF974A99F07");

            entity.ToTable("Warehouse");

            entity.Property(e => e.WareHouseLocation)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.WarehouseName)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
