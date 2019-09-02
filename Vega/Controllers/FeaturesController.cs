using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Vega.DTOs;
using Vega.Models;

namespace Vega.Controllers
{
    [Route("api/[controller]")]
    public class FeaturesController : Controller
    {
        private readonly VegaDbContext _context;
        private readonly IMapper _mapper;

        public FeaturesController(VegaDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IEnumerable<FeatureDto>> GetFeatures()
        {
            var features = _context.Features.ToListAsync();

            return _mapper.Map<List<Feature>, List<FeatureDto>>(await features);
        }
    }
}