using RarePublishing.Api;
using RarePublishing.Data;

var builder = WebApplication.CreateBuilder(args);


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
app.MapControllers();
app.UseAuthorization();


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
