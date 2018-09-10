﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CCIS_API.Database.Contexts;
using CCIS_API.Database.Models;
using CCIS_API.Extensions;
using Microsoft.AspNet.OData;
using Microsoft.AspNet.OData.Routing;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CCIS_API.Controllers
{
    [Produces("application/json")]
    [ODataRoutePrefix("Goal1")]
    [EnableCors("CORSPolicy")]
    public class Goal1Controller : ODataController
    {
        public SQLDBContext _context { get; }
        public Goal1Controller(SQLDBContext context)
        {
            _context = context;
        }

        [HttpGet]
        [EnableQuery]
        public IQueryable<Goal1> Get()
        {
            return _context.Goal1.AsQueryable();
        }

        //Add/Update
        [HttpPost]
        //[Authorize(Roles = "Contributor,Custodian,Configurator,SysAdmin")]
        [EnableQuery]
        public async Task<IActionResult> Post([FromBody]Goal1 goal)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var exiting = _context.Goal1.FirstOrDefault(x => x.Id == goal.Id);
            if (exiting == null)
            {
                //ADD
                HelperExtensions.ClearIdentityValue(ref goal);
                HelperExtensions.ClearNullableInts(ref goal);
                _context.Goal1.Add(goal);
                await _context.SaveChangesAsync();
                return Created(goal);
            }
            //else
            //{
            //    //UPDATE
            //    _context.Entry(exiting).CurrentValues.SetValues(goal);
            //    await _context.SaveChangesAsync();
            //    return Updated(exiting);
            //}

            return Ok(goal);
        }
    }
}