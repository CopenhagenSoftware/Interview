using Interview;
using Interview.Services;
using Interview.Utils;
using Microsoft.AspNetCore.Mvc;
using JsonOptions = Microsoft.AspNetCore.Http.Json.JsonOptions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IHolidayRegistrationService, HolidayRegistrationService>();
builder.Services.AddScoped<IPublicHolidayService, PublicHolidayService>();

builder.Services.Configure<JsonOptions>(options =>
{
    options.SerializerOptions.Converters.Add(new DateOnlyConverter());
});

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapPost(
    "/vacationdays",
    async (IHolidayRegistrationService holidayRegistrationService,
           [FromBody] HolidayRegistrationDto request) =>
    {
        await holidayRegistrationService.AddHolidayRegistration(request.StartDate, request.NumberOfDays);

        return Results.Created();

    })
    .WithName("PostNewHolidayRegistration");

app.MapGet(
    "/vacationdaysused",
    async (IPublicHolidayService publicHolidayService, IHolidayRegistrationService holidayRegistrationService) =>
    {
        // Add awesome code here! 

        return 1; // return the number of days used
    })
    .WithName("GetVacationDaysUsed");

app.Run();

