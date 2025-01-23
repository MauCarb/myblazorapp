using Blazored.SessionStorage;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using BlazorApp.Client;
using Syncfusion.Blazor;

Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("NTE2MDYxQDMxMzkyZTMzMmUzMFY1eGRPdEdJWXlTMzhoR1FWdmh3UTBoZE9qZ1YyaWtlcG5IMkRRV2dxdUk9;NTE2MDYyQDMxMzkyZTMzMmUzMEE1TWl0Ui90S3FWR2NJQnFUUlJJczNMNmZKYU4wTTdBZEVJRVFKVks4Mms9;NTE2MDYzQDMxMzkyZTMzMmUzMFBRRkJYVGprVThJYm5aS0Z4UXdQZkMwMDBKV0N0TERteXhVQVhuT3NlSmc9;NTE2MDY0QDMxMzkyZTMzMmUzMEYrOVdWaDJGOVVRUnlCTytHNnM2cWR5eVdRMXUxS3lTbHR6REJjWUp6T2M9;NTE2MDY1QDMxMzkyZTMzMmUzMEcyMVJNbXRvcmc3UGxxejk2cWtMQXBFT25LOHVOa3RhQnIwSTNWUnRBbE09;NTE2MDY2QDMxMzkyZTMzMmUzMGpCeGtVbHZWT25FcWxmOFZDYWIzdUh6RGVxdUdnMGw1UmhxbHErb1M5V1k9;NTE2MDY3QDMxMzkyZTMzMmUzME03T3lLK3VmckFnL1RsNnkwbnliZ2ZaZzJBd1cxU01VUW5QSkFLRUVQWWM9;NTE2MDY4QDMxMzkyZTMzMmUzMENkSWQxRC9Wc2sva01vYmFVUS9BZTdxZUZPQk9yMld2R1REcTlvY3F3dzA9;NTE2MDY5QDMxMzkyZTMzMmUzMEJZeVBCbTRKdG5YVHQ0QWdUY29tMTR5U0JKRVcrSzVDNU9lUUx4cTV2aWc9;NTE2MDcwQDMxMzkyZTMzMmUzMEs1L2JWbnZXYzFqdDZzdVYvK0FqbHFHKzE2QzBuT3pDMzZYck05aWdPK1U9;NTE2MDcxQDMxMzkyZTMzMmUzMG1CQmJGWXFlWWxqNlF4TUgzaWJITnV0U3pIaDdWWmw4RW4wTUtaU0VzUXc9");

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.Configuration["API_Prefix"] ?? builder.HostEnvironment.BaseAddress) });

builder.Services.AddBlazoredSessionStorage();

builder.Services.AddScoped<LoginService>();

builder.Services.AddScoped<ClientiService>();

builder.Services.AddScoped<PatientService>();

builder.Services.AddScoped<PatientMngService>();

builder.Services.AddScoped<ListVisitsService>();

builder.Services.AddScoped<VisitService>();

builder.Services.AddScoped<ListVisusService>();

builder.Services.AddScoped<VisusService>();

builder.Services.AddScoped<VisusFilterService>();

builder.Services.AddScoped<ControlliService>();

builder.Services.AddScoped<ListControlliService>();

builder.Services.AddScoped<OrtoctisService>();

builder.Services.AddScoped<ListOrtoctisService>();

builder.Services.AddScoped<ListDrugsService>();

builder.Services.AddScoped<PrescrizioniService>();

builder.Services.AddSyncfusionBlazor();

await builder.Build().RunAsync();
