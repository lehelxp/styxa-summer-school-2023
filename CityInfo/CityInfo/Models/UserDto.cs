using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CityInfo.Models
{
    public class UserDto
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        
        public UserDto() { }
        public UserDto(int id, string username, string password)
        {
            Id = id;
            Username = username;
            Password = password;
        }
    }
}
