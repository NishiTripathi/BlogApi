using System;
using System.Collections.Generic;
using BlogApi.Data;
using BlogApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace BlogApi.Controllers
{
    [Route("api/blogs")]
    [ApiController]
    public class BlogController : ControllerBase
    {
        private readonly ApplicationDbContext _db;
        public BlogController(ApplicationDbContext db) 
        {
            _db=db;           
         }
         [HttpGet]
         public ActionResult View(Blog blog)
         {
             IEnumerable<Blog> blogList = _db.Blog;
             return Ok(blogList);
         }
         [HttpPost("{id}")]
         public ActionResult Create(Blog blog,int id)
         {
             var create = _db.Blog.Add(blog);
             _db.SaveChanges();
             return Ok(blog);
            
         }            
    }

    }
    
