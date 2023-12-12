using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using MiniERP;

namespace MiniERP
{
    public partial class miniERPContext : DbContext
    {
        public miniERPContext()
        {
        }

        public miniERPContext(DbContextOptions<miniERPContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Cliente> Clientes { get; set; } = null!;
        public virtual DbSet<Fornecedor> Fornecedores { get; set; } = null!;
        public virtual DbSet<Pedido> Pedidos { get; set; } = null!;
        public virtual DbSet<Produto> Produtos { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=localhost; Initial Catalog=miniERP; User ID=minierp; password=123456;language=Portuguese;Trusted_Connection=True;TrustServerCertificate=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>(entity =>
            {
                entity.ToTable("clientes");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Nome)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("nome");
            });

            modelBuilder.Entity<Fornecedor>(entity =>
            {
                entity.ToTable("fornecedores");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Nome)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("nome");
            });

            modelBuilder.Entity<Pedido>(entity =>
            {
                entity.ToTable("pedido");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Emissao)
                    .HasColumnType("datetime")
                    .HasColumnName("emissao");

                entity.Property(e => e.FkCliente).HasColumnName("fk_cliente");

                entity.Property(e => e.FkProduto).HasColumnName("fk_produto");

                entity.Property(e => e.Quantidade).HasColumnName("quantidade");

                entity.Property(e => e.TotalItem)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("totalItem");

                entity.HasOne(d => d.FkClienteNavigation)
                    .WithMany(p => p.Pedidos)
                    .HasForeignKey(d => d.FkCliente)
                    .HasConstraintName("FK__pedido__fk_clien__02084FDA");

                entity.HasOne(d => d.FkProdutoNavigation)
                    .WithMany(p => p.Pedidos)
                    .HasForeignKey(d => d.FkProduto)
                    .HasConstraintName("FK__pedido__fk_produ__01142BA1");
            });

            modelBuilder.Entity<Produto>(entity =>
            {
                entity.ToTable("produtos");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Estoque).HasColumnName("estoque");

                entity.Property(e => e.FkFornecedor).HasColumnName("fk_fornecedor");

                entity.Property(e => e.Nome)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nome");

                entity.Property(e => e.Preco)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("preco");

                entity.HasOne(d => d.FkFornecedorNavigation)
                    .WithMany(p => p.Produtos)
                    .HasForeignKey(d => d.FkFornecedor)
                    .HasConstraintName("FK__produtos__fk_for__656C112C");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
