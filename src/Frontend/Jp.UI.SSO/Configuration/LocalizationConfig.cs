﻿using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Localization;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using System.Globalization;

namespace Jp.UI.SSO.Configuration
{
    public static class LocalizationConfig
    {
        public static void AddMvcLocalization(this IServiceCollection services)
        {
            services.AddLocalization(opts => { opts.ResourcesPath = "Resources"; });

            services.Configure<RequestLocalizationOptions>(
                            opts =>
                            {
                                var supportedCultures = new[]
                                {
                                //    new CultureInfo("pt-BR"),
                                   new CultureInfo("fa-IR"),
                                 //   new CultureInfo("en"),
                               //     new CultureInfo("zh-TW"),
                               //     new CultureInfo("zh-CN"),
                               //     new CultureInfo("es"),
                               //     new CultureInfo("nl"),
                               //     new CultureInfo("fr"),
                               //     new CultureInfo("ru"),
                               //     new CultureInfo("el-GR"),
                                };

                                opts.DefaultRequestCulture = new RequestCulture("fa-IR");
                                opts.SupportedCultures = supportedCultures;
                                opts.SupportedUICultures = supportedCultures;
                            });
        }

        public static void UseLocalization(this IApplicationBuilder app)
        {
            var options = app.ApplicationServices.GetService<IOptions<RequestLocalizationOptions>>();
            app.UseRequestLocalization(options.Value);
        }

    }
}
