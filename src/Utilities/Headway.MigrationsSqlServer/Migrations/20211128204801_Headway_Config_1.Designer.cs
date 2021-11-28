﻿// <auto-generated />
using System;
using Headway.Repository.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Headway.MigrationsSqlServer.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20211128204801_Headway_Config_1")]
    partial class Headway_Config_1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Headway.Core.Model.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryId"), 1L, 1);

                    b.Property<int?>("ModuleId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("Order")
                        .HasColumnType("int");

                    b.Property<string>("Permission")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("CategoryId");

                    b.HasIndex("ModuleId");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("Headway.Core.Model.Config", b =>
                {
                    b.Property<int>("ConfigId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ConfigId"), 1L, 1);

                    b.Property<string>("Container")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("ModelApi")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("NavigateBack")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("NavigateBackConfig")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("NavigateBackProperty")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("NavigateTo")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("NavigateToConfig")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("NavigateToProperty")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("OrderModelBy")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ConfigId");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Configs");
                });

            modelBuilder.Entity("Headway.Core.Model.ConfigContainer", b =>
                {
                    b.Property<int>("ConfigContainerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ConfigContainerId"), 1L, 1);

                    b.Property<int?>("Column")
                        .HasColumnType("int");

                    b.Property<int?>("ConfigContainerId1")
                        .HasColumnType("int");

                    b.Property<int?>("ConfigId")
                        .HasColumnType("int");

                    b.Property<string>("Container")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<bool>("IsRootContainer")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Order")
                        .HasColumnType("int");

                    b.Property<int?>("Row")
                        .HasColumnType("int");

                    b.Property<string>("Text")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ConfigContainerId");

                    b.HasIndex("ConfigContainerId1");

                    b.HasIndex("ConfigId");

                    b.ToTable("ConfigContainers");
                });

            modelBuilder.Entity("Headway.Core.Model.ConfigItem", b =>
                {
                    b.Property<int>("ConfigItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ConfigItemId"), 1L, 1);

                    b.Property<string>("Component")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("ComponentArgs")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ConfigContainerId")
                        .HasColumnType("int");

                    b.Property<int?>("ConfigId")
                        .HasColumnType("int");

                    b.Property<string>("ConfigName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsIdentity")
                        .HasColumnType("bit");

                    b.Property<bool>("IsTitle")
                        .HasColumnType("bit");

                    b.Property<string>("Label")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Order")
                        .HasColumnType("int");

                    b.Property<string>("PropertyName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ConfigItemId");

                    b.HasIndex("ConfigContainerId");

                    b.HasIndex("ConfigId");

                    b.ToTable("ConfigItems");
                });

            modelBuilder.Entity("Headway.Core.Model.MenuItem", b =>
                {
                    b.Property<int>("MenuItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MenuItemId"), 1L, 1);

                    b.Property<int?>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Config")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("ImageClass")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("NavigateTo")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("Order")
                        .HasColumnType("int");

                    b.Property<string>("Permission")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("MenuItemId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("MenuItems");
                });

            modelBuilder.Entity("Headway.Core.Model.Module", b =>
                {
                    b.Property<int>("ModuleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ModuleId"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("Order")
                        .HasColumnType("int");

                    b.Property<string>("Permission")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("ModuleId");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Modules");
                });

            modelBuilder.Entity("Headway.Core.Model.Permission", b =>
                {
                    b.Property<int>("PermissionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PermissionId"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("PermissionId");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Permissions");
                });

            modelBuilder.Entity("Headway.Core.Model.Role", b =>
                {
                    b.Property<int>("RoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RoleId"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("RoleId");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("Headway.Core.Model.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"), 1L, 1);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("UserId");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("UserName")
                        .IsUnique();

                    b.ToTable("Users");
                });

            modelBuilder.Entity("PermissionRole", b =>
                {
                    b.Property<int>("PermissionsPermissionId")
                        .HasColumnType("int");

                    b.Property<int>("RolesRoleId")
                        .HasColumnType("int");

                    b.HasKey("PermissionsPermissionId", "RolesRoleId");

                    b.HasIndex("RolesRoleId");

                    b.ToTable("PermissionRole");
                });

            modelBuilder.Entity("PermissionUser", b =>
                {
                    b.Property<int>("PermissionsPermissionId")
                        .HasColumnType("int");

                    b.Property<int>("UsersUserId")
                        .HasColumnType("int");

                    b.HasKey("PermissionsPermissionId", "UsersUserId");

                    b.HasIndex("UsersUserId");

                    b.ToTable("PermissionUser");
                });

            modelBuilder.Entity("RoleUser", b =>
                {
                    b.Property<int>("RolesRoleId")
                        .HasColumnType("int");

                    b.Property<int>("UsersUserId")
                        .HasColumnType("int");

                    b.HasKey("RolesRoleId", "UsersUserId");

                    b.HasIndex("UsersUserId");

                    b.ToTable("RoleUser");
                });

            modelBuilder.Entity("Headway.Core.Model.Category", b =>
                {
                    b.HasOne("Headway.Core.Model.Module", "Module")
                        .WithMany("Categories")
                        .HasForeignKey("ModuleId");

                    b.Navigation("Module");
                });

            modelBuilder.Entity("Headway.Core.Model.ConfigContainer", b =>
                {
                    b.HasOne("Headway.Core.Model.ConfigContainer", null)
                        .WithMany("ConfigContainers")
                        .HasForeignKey("ConfigContainerId1");

                    b.HasOne("Headway.Core.Model.Config", null)
                        .WithMany("Containers")
                        .HasForeignKey("ConfigId");
                });

            modelBuilder.Entity("Headway.Core.Model.ConfigItem", b =>
                {
                    b.HasOne("Headway.Core.Model.ConfigContainer", "ConfigContainer")
                        .WithMany()
                        .HasForeignKey("ConfigContainerId");

                    b.HasOne("Headway.Core.Model.Config", null)
                        .WithMany("ConfigItems")
                        .HasForeignKey("ConfigId");

                    b.Navigation("ConfigContainer");
                });

            modelBuilder.Entity("Headway.Core.Model.MenuItem", b =>
                {
                    b.HasOne("Headway.Core.Model.Category", "Category")
                        .WithMany("MenuItems")
                        .HasForeignKey("CategoryId");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("PermissionRole", b =>
                {
                    b.HasOne("Headway.Core.Model.Permission", null)
                        .WithMany()
                        .HasForeignKey("PermissionsPermissionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Headway.Core.Model.Role", null)
                        .WithMany()
                        .HasForeignKey("RolesRoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PermissionUser", b =>
                {
                    b.HasOne("Headway.Core.Model.Permission", null)
                        .WithMany()
                        .HasForeignKey("PermissionsPermissionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Headway.Core.Model.User", null)
                        .WithMany()
                        .HasForeignKey("UsersUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("RoleUser", b =>
                {
                    b.HasOne("Headway.Core.Model.Role", null)
                        .WithMany()
                        .HasForeignKey("RolesRoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Headway.Core.Model.User", null)
                        .WithMany()
                        .HasForeignKey("UsersUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Headway.Core.Model.Category", b =>
                {
                    b.Navigation("MenuItems");
                });

            modelBuilder.Entity("Headway.Core.Model.Config", b =>
                {
                    b.Navigation("ConfigItems");

                    b.Navigation("Containers");
                });

            modelBuilder.Entity("Headway.Core.Model.ConfigContainer", b =>
                {
                    b.Navigation("ConfigContainers");
                });

            modelBuilder.Entity("Headway.Core.Model.Module", b =>
                {
                    b.Navigation("Categories");
                });
#pragma warning restore 612, 618
        }
    }
}
