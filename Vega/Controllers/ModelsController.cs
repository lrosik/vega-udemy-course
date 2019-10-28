using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Vega.DTOs;
using Vega.Models;

namespace Vega.Controllers
{
    [Route("api/[controller]")]
    public class ModelsController
    {
        private readonly VegaDbContext _context;
        private readonly IMapper _mapper;
        public ModelsController(VegaDbContext context, IMapper mapper)
        {
            _mapper = mapper;
            _context = context;
        }

        [HttpGet("{id}")]
        public async Task<IEnumerable<ModelDto>> GetModels(int id)
        {
            var models = _context.Models.Where(m => m.MakeId == id).ToListAsync();

            return _mapper.Map<IEnumerable<Model>, IEnumerable<ModelDto>>(await models);
        }
    }
}