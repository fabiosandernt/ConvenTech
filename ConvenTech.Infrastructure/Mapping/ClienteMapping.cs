using ConvenTech.Domain.Cliente;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace ConvenTech.Infrastructure.Mapping
{
    public class ClienteMapping : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.ToTable("Cliente");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.Nome).IsRequired().HasMaxLength(200);
            builder.Property(x => x.Telefone).IsRequired();


           //builder.OwnsOne(x => x.Endereco, p =>
           // {
           //     p.Property(f => f.Logradouro).HasColumnName("Logradouro");
           //     p.Property(f => f.Numero).HasColumnName("Numero");
           //     p.Property(f => f.Complemento).HasColumnName("Complemento");
           //     p.Property(f => f.Bairro).HasColumnName("Bairro");
           //     p.Property(f => f.Cidade).HasColumnName("Cidade");
           //     p.Property(f => f.Estado).HasColumnName("Estado");
           //     p.Property(f => f.Cep).HasColumnName("Cep");
           // });

            builder.OwnsOne(x => x.Email, p =>
            {
                p.Property(f => f.Valor).HasColumnName("Email").IsRequired().HasMaxLength(1024);
            });

           builder.OwnsOne(c => c.Identificador, i =>
           {
               i.Property(id => id.Numero)
                   .IsRequired()
                   .HasMaxLength(14);
           });

           // builder.HasDiscriminator<string>("TipoCliente")
           //     .HasValue<PessoaFisica>("PF")
           //     .HasValue<PessoaJuridica>("PJ");

        }
    }
}
