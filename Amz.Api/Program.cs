using Amz.Api.AutoMapperProfiles;
using Amz.Api.Validators.Product;
using Amz.Application.Queries.Products;
using Amz.DAL.Context;
using FluentValidation;
using FluentValidation.AspNetCore;
using MediatR;
using Microsoft.EntityFrameworkCore;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Host.ConfigureLogging(logging => {
            logging.ClearProviders();
            logging.AddConsole();
        });

        // Add services to the container.

        builder.Services.AddControllers();
        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();
        builder.Services.AddDbContext<AmzDbContext>(options =>
        {
            options.UseSqlServer(builder.Configuration.GetConnectionString("Default"));
        });
        builder.Services.AddMediatR(typeof(GetAllProductsQuery));

        builder.Services.AddFluentValidation();
        builder.Services.AddValidatorsFromAssemblyContaining<CreateProductViewModelValidator>();

        builder.Services.AddAutoMapper(typeof(ProductProfile), typeof(Amz.Application.AutoMapperProfiles.ProductProfile));
        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseHttpsRedirection();

        app.UseAuthorization();

        app.MapControllers();

        app.Run();
    }
}