using System.Collections.Generic;
using WebAPI.Models;
using System.Linq;
using WebAPI.Repository;
namespace WebAPI.Repository
{
    public class UserRepository
    {
        public List<UserModel> user;
        public UserRepository(){
            this.user = new List<UserModel>();
            this.user.Add(new UserModel{
                UserId=1,
                FirstName="Paiboonkiat",
                LastName="kiewneth",
                UserName="apb",
                Password="123456",
                Email="555@gmail.com",
                Tel="0912345678"

            });
        }
        public List<UserModel>GetAllUser(){
            return user.ToList();
        }

        public void AddUser(UserModel data){
            user.Add(data);
        }
        public void EditUser(UserModel data){
            var _EditUser = user.Where(user=>user.UserId==data.UserId).FirstOrDefault();
            _EditUser.FirstName = data.FirstName;
            _EditUser.LastName = data.LastName;
            _EditUser.UserName = data.UserName;
            _EditUser.Password = data.Password;
            _EditUser.Email = data.Email;
            _EditUser.Tel = data.Tel;
        }

        public void DeleteUser(UserModel data){
            var _deleteUser = user.Where(user=>user.UserId==data.UserId).FirstOrDefault();

            if(_deleteUser!=null){
                user.Remove(_deleteUser);
            }
        }
        public UserModel GetUserById(int userid){
            return user.Where(user=>user.UserId==userid).FirstOrDefault();
        }
        
    }
}