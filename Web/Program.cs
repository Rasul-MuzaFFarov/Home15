using Infrastructure.Data;
using Infrastructure.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
var connection = builder.Configuration.GetConnectionString("Default");
builder.Services.AddDbContext<DataContext>(conf => conf.UseNpgsql(connection));
builder.Services.AddScoped<CategoryService>();
builder.Services.AddScoped<ExternalAccountService>();
builder.Services.AddScoped<FollowingRelationShipService>();
builder.Services.AddScoped<LocationService>();
builder.Services.AddScoped<PostCategoryService>();
builder.Services.AddScoped<PostCommentService>();
builder.Services.AddScoped<PostFavoriteService>();
builder.Services.AddScoped<PostStatService>();
builder.Services.AddScoped<PostTagService>();
builder.Services.AddScoped<PostCategoryService>();
builder.Services.AddScoped<TagService>();
builder.Services.AddScoped<UserService>();
var app = builder.Build();


// builder.Services.AddScoped<UserSettingService>();

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
