using InsuranceApp.Data;



using Microsoft.EntityFrameworkCore;



var builder = WebApplication.CreateBuilder(args);



// Add services to the container.



builder.Services.AddDbContext<DataDBContext>(Options => Options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));



builder.Services.AddCors(options =>



{



    options.AddPolicy("AllowLocalhost3000",



       builder =>



       {



           builder.WithOrigins("http://localhost:3000")



            .AllowAnyHeader()



            .AllowAnyMethod();



       });



});



builder.Services.AddControllers();



// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle



builder.Services.AddEndpointsApiExplorer();



builder.Services.AddSwaggerGen();



var app = builder.Build();



// Configure the HTTP request pipeline.



if (app.Environment.IsDevelopment())



{



    app.UseSwagger();



    app.UseSwaggerUI();



}



app.UseHttpsRedirection();



app.UseAuthorization();



app.UseCors(c => c.AllowAnyHeader().AllowAnyOrigin().AllowAnyMethod());



app.MapControllers();



app.Run();