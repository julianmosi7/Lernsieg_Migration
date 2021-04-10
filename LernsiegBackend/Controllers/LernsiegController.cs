﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LernsiegBackend.Dtos;
using LernsiegDbLib;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LernsiegBackend.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class LernsiegController : ControllerBase
    {
        private LernsiegService lernsiegService;

        public LernsiegController(LernsiegService lernsiegService)
        {
            this.lernsiegService = lernsiegService;
            var db = CreateContext();
            int nr = db.Teachers.Count();
        }

        private static LernsiegContext CreateContext()
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(AppContext.BaseDirectory)
                .AddJsonFile("appsettings.json")
                .Build();
            var optionsBuilder = new DbContextOptionsBuilder<LernsiegContext>();
            optionsBuilder.UseSqlServer(config.GetConnectionString("LernsiegMdf"));
            var db = new LernsiegContext(optionsBuilder.Options);
            return db; 
        }

        


        [HttpGet]
        public IEnumerable<SchoolDto> TopSchools(string country)
        {
            return null;
        }




        //[HttpGet]
        //public IEnumerable<SchoolDto> FindSchools(string country, string filter)
        //{
        //    return null;
        //}

        //[HttpGet]
        //public SchoolDto GetSchool(int id)
        //{
        //    return null;
        //}

        //[HttpGet]
        //public IEnumerable<TeacherDto> FindTeachers(int schoolId, string filter)
        //{
        //    return null;
        //}

        //[HttpGet]
        //public TeacherDto GetTeacher(int id)
        //{
        //    return null;
        //}

        //[HttpGet]
        //public IEnumerable<EvaluationDto> Evaluations(int schoolOrTeacherid, int evaluationType)
        //{
        //    return null;
        //}

        //[HttpGet]
        //public IEnumerable<CriteriaDto> Criterias(int evaluationType)
        //{
        //    return null;
        //}

        //[HttpPost]
        //public EvaluationReplyDto SaveEvaluation([FromBody] EvaluationSaveDto data)
        //{
        //    return null;
        //}
    }
}
