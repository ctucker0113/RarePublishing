var builder = WebApplication.CreateBuilder(args);
<<<<<<< HEAD
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
var app = builder.Build();
=======


builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

>>>>>>> main
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
<<<<<<< HEAD
app.UseHttpsRedirection();
// Start Coding Here!
app.Run();

=======

app.UseHttpsRedirection();
// Start Coding Here!

app.Run();
>>>>>>> main
