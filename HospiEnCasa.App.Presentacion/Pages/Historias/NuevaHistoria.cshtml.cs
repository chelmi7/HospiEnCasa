using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace HospiEnCasa.App.Presentacion.Pages.Historias
{
    [Authorize]
    public class NuevaHistoriaModel : PageModel
    {
        private readonly ILogger<NuevaHistoriaModel> _logger;

        public NuevaHistoriaModel(ILogger<NuevaHistoriaModel> logger)
        {
            _logger = logger;
        }

        public void OnGet(int id)
        {
        }
    }
}