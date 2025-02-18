using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ProjectWeb3.Models;

namespace ProjectWeb3.Data
{
    public class AppDbContext : IdentityDbContext<Usuario>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {         
        }

        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<ProdutoFoto> ProdutoFoto { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            #region Definição dos nomes do Entity  
            builder.Entity<Usuario>().ToTable("usuario");
            builder.Entity<IdentityRole>().ToTable("perfil");
            builder.Entity<IdentityUserRole<string>>().ToTable("usuario_perfil");
            builder.Entity<IdentityUserClaim<string>>().ToTable("usuario_regra");
            builder.Entity<IdentityUserToken<string>>().ToTable("usuario_token");        
            builder.Entity<IdentityUserLogin<string>>().ToTable("usuario_login");        
            builder.Entity<IdentityRoleClaim<string>>().ToTable("perfil_regra");       
            #endregion

            #region Categorias
                
                List<Categoria> categorias = new(){
                    new(){
                        Id = 1,
                        Name = "Eletrônicos", 
                    },
                    new(){
                        Id = 2,
                        Name = "Celulares"
                    }
                };
                builder.Entity<Categoria>().HasData(categorias);
            #endregion
            #region Popular Usuario

            Usuario usuario = new(){
                Id = Guid.NewGuid().ToString(),
                UserName = "BotinhoLindo",
                NormalizedUserName = "BOTINHOLINDO",
                Email = "BotiLoko12@gmail.com",
                NormalizedEmail = "BOTILOKO12@GMAIL.COM",
                EmailConfirmed = true,
                Name = "Vinicius augusto boti pereira",
                DataNascimento = DateTime.Parse("06/09/2002"),
                LockoutEnabled = true                
            };
            PasswordHasher<Usuario> password = new();
            password.HashPassword(usuario,"12345");
            builder.Entity<Usuario>().HasData(usuario);
            #endregion
           
            #region Popular Perfil
            List<IdentityRole> perfis = new(){
                new(){
                    Id = Guid.NewGuid().ToString(),
                    Name = "Administrador",
                    NormalizedName = "ADMINISTRADOR"
                },
                new(){
                    Id = Guid.NewGuid().ToString(),
                    Name = "funcionario",
                    NormalizedName = "FUNCIONARIO"
                },
                new(){
                    Id = Guid.NewGuid().ToString(),
                    Name = "cliente",
                    NormalizedName = "CLIENTE"
                }        
            };
            builder.Entity<IdentityRole>().HasData(perfis);               
            #endregion

            #region Popular Usuário-Perfil
            List<IdentityUserRole<string>> userRoles = new(){
                new(){
                    UserId = usuario.Id,
                    RoleId = perfis[0].Id
                }
            };
            builder.Entity<IdentityUserRole<string>>().HasData(userRoles);               
            #endregion
        }    
    }
}