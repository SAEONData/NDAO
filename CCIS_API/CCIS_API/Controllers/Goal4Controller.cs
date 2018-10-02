﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CCIS_API.Database.Contexts;
using CCIS_API.Database.Models;
using CCIS_API.Extensions;
using Microsoft.AspNet.OData;
using Microsoft.AspNet.OData.Routing;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CCIS_API.Controllers
{
    [Produces("application/json")]
    [ODataRoutePrefix("Goal4")]
    [EnableCors("CORSPolicy")]
    public class Goal4Controller : ODataController
    {
        public SQLDBContext _context { get; }
        public Goal4Controller(SQLDBContext context)
        {
            _context = context;
        }

        [HttpGet]
        [EnableQuery]
        public IQueryable<Goal4> Get()
        {
            return _context.Goal4.AsQueryable();
        }

        //Add/Update
        [HttpPost]
        //[Authorize(Roles = "Contributor,Custodian,Configurator,SysAdmin")]
        [EnableQuery]
        public async Task<IActionResult> Post([FromBody]Goal4 goal)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var exiting = _context.Goal4.FirstOrDefault(x => x.Id == goal.Id);
            if (exiting == null)
            {
                if (!HelperExtensions.CheckGoalCreateValues(goal))
                {
                    return BadRequest(new MissingFieldException("CreateUserId value required"));
                }

                //ADD
                HelperExtensions.ClearIdentityValue(goal);
                HelperExtensions.ClearNullableInts(goal);
                _context.Goal4.Add(goal);
                await _context.SaveChangesAsync();
                return Created(goal);
            }
            else
            {
                if (!HelperExtensions.CheckGoalUpdateValues(goal))
                {
                    return BadRequest(new MissingFieldException("LastUpdateUserId value required"));
                }

                //UPDATE
                goal.Created = exiting.Created;
                goal.CreateUserId = exiting.CreateUserId;
                _context.Entry(exiting).CurrentValues.SetValues(goal);

                await _context.SaveChangesAsync();
                return Updated(exiting);
            }
        }
    }
}