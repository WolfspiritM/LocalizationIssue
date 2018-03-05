using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LocalizationIssue.Models;

namespace LocalizationIssue.Controllers
{

    using Microsoft.Extensions.Localization;

    public class TranslationController : Controller
    {
        private readonly IStringLocalizer<DataAnnotationResource> localizer;

        private readonly IStringLocalizerFactory factory;

        public TranslationController(IStringLocalizer<DataAnnotationResource> localizer, IStringLocalizerFactory factory)
        {
            this.localizer = localizer;
            this.factory = factory;
        }

        public IActionResult Index()
        {
            var createdlocalizer = factory.Create(typeof(DataAnnotationResource));

            return this.Ok(new { DI = this.localizer["Username"], Factory = createdlocalizer["Username"] });
        }
    }
}
