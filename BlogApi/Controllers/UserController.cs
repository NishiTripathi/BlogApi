using System.Collections.Generic;
using BlogApi.Data;
using BlogApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace BlogApi.Controllers
{
    [Route("api/users")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly ApplicationDbContext _db;
        public UserController(ApplicationDbContext db) 
        {
            _db=db;           
         }
         [HttpPost]
         public ActionResult CreatingUser(User user)
         {
           var created =_db.Users.Add(user);
           _db.SaveChanges();
           return Ok(user);
         }    
         [HttpGet]
         public ActionResult ViewingUser(User user)
         {
             IEnumerable<User> userList = _db.Users;
             return Ok(userList);
         }      
         }
}