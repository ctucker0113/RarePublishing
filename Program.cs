using RarePublishing.Api;
using RarePublishing.Data;

//Fixed issue with cores
var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: MyAllowSpecificOrigins,
                      policy =>
                      {
                          policy.WithOrigins("http://localhost:3000").AllowAnyHeader().AllowAnyMethod();
                      });
});


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
app.UseCors(MyAllowSpecificOrigins);


CategoryApi.Map(app);
CommentApi.Map(app);
PostApi.Map(app);
PostReactions.Map(app);
PostTagsApi.Map(app);
Reactions.Map(app);
SubscriptionApi.Map(app);
Tags.Map(app);
RareUserApi.Map(app);





app.Run();
