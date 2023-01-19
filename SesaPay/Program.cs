using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;
using SesaPay.DataModels;
using SesaPay.Repository.Admin;
using SesaPay.Services.Admin;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
builder.Services.AddAdminServices();
builder.Services.AddAdminRepository();

//"Server=127.0.0.1;Port=3306;Uid=username;Pwd=password;Database=db;"
//Server=35.180.47.94:3306;Uid=ubuntu;Pwd=SesapayFree@123;Database=sesapay_2021_v3;
//Driver={mySQL};Server=myServerAddress;Option=131072;Stmt=;Database=myDataBase;User=myUsername;Password=myPassword;
//Server=myServerAddress;Database=myDataBase;Uid=myUsername;Pwd=myPassword;
builder.Services.AddDbContext<SesaPayContext>(options =>
{
options.UseMySql("Server=127.0.0.1;Port=3306;Database=sesapay_2021_v3;Uid=root;Pwd=",
    ServerVersion.AutoDetect("Server=127.0.0.1;Port=3306;Database=sesapay_2021_v3;Uid=root;Pwd=;"),
    mySqlOptions =>
        mySqlOptions.EnableRetryOnFailure(
            maxRetryCount: 10,
            maxRetryDelay: TimeSpan.FromSeconds(30),
            errorNumbersToAdd: null)
        );
});


//var connectionString = config["mysqlconnection:connectionString"];
builder.Services.AddDbContext<SesaPayContext>(o => o.UseMySql("Server=localhost;Port=3306;Database=sesapay_2021_v3;Uid=root;Pwd=;",
    MySqlServerVersion.LatestSupportedServerVersion));


var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: MyAllowSpecificOrigins,
                      policy =>
                      {
                          policy.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin();
                      });
});


var app = builder.Build();


app.UseCors(MyAllowSpecificOrigins);

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseSwaggerUI(options =>
{
    options.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
    options.RoutePrefix = string.Empty;
});
app.UseSwagger(options =>
{
    options.SerializeAsV2 = true;
});

app.UseHttpsRedirection();
app.UseDeveloperExceptionPage();

app.UseAuthorization();

app.MapControllers();

app.Run();
