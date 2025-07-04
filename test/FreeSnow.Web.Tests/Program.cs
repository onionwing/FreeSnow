using Microsoft.AspNetCore.Builder;
using FreeSnow;
using Volo.Abp.AspNetCore.TestBase;

var builder = WebApplication.CreateBuilder();

builder.Environment.ContentRootPath = GetWebProjectContentRootPathHelper.Get("FreeSnow.Web.csproj");
await builder.RunAbpModuleAsync<FreeSnowWebTestModule>(applicationName: "FreeSnow.Web" );

public partial class Program
{
}
