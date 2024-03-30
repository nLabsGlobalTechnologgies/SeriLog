using Logger.ToSeq.API.Context;
using Logger.ToSeq.API.Models;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Security.Claims;
using System.Text.Json;

namespace Logger.ToSeq.API.Filters;

[AttributeUsage(AttributeTargets.Method)]
public sealed class LogFilter : ActionFilterAttribute, IActionFilter
{
    public string TableName { get; set; } = string.Empty;

    public override void OnActionExecuted(ActionExecutedContext context)
    {
        //throw new NotImplementedException();
    }

    public override void OnActionExecuting(ActionExecutingContext context)
    {
        var serviceProvider = context.HttpContext.RequestServices;
        var dbContext = serviceProvider.GetRequiredService<AppDbContext>();
        Log? log = new()
        {
            MethodName = context.HttpContext.Request.Path.Value ?? "",
            MethodType = context.HttpContext.Request.Method ?? "",
            TableName = TableName! ?? "",
            Body = JsonSerializer.Serialize(context.ActionArguments.First().Value) ?? "",
            UserId = context.HttpContext.User.FindFirstValue("UserId") ?? "",
            User = context.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier) ?? "",
            CreatedDate = DateTime.Now
        };

        dbContext.Logs.Add(log);
        dbContext.SaveChanges();
    }
}
