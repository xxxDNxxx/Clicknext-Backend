using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Repository;
using WebAPI.Models;
namespace WebAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        public UserRepository userRepo;
        public UserController(UserRepository userRepo){
            this.userRepo = userRepo;
        }

        [HttpGet]
        public List<UserModel> GetUser(){
            return userRepo.GetAllUser();
        }

        [HttpPost]

        public void AddUser(UserModel data){
           userRepo.AddUser(data);
        }

        [HttpPost]

        public void EditUser(UserModel data){
            userRepo.EditUser(data);
        }

        [HttpPost]

        public void DeleteUser(UserModel data){
            userRepo.DeleteUser(data);
        }
        
        [HttpPost]

        public UserModel GetUserbyId(int userid){
            return userRepo.GetUserById(userid);
        }
    }
}