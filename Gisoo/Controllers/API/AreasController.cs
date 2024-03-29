﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Gisoo.DAL;
using Gisoo.Models;
using Gisoo.Service.Interface;

namespace Gisoo.Controllers.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class AreasController : ControllerBase
    {
        private readonly Context _context;

        private ICity _City;

        public AreasController(Context context, ICity City)
        {
            _context = context;
            _City = City;

        }

        // GET: api/AllPrices
        [HttpGet("{provinceId}")]
        public object GetAreas([FromRoute]int provinceId)
        {
            var data = _City.GetAreas(provinceId);
            return data;
        }

        // GET: api/AllPrices/5
        
    }
}