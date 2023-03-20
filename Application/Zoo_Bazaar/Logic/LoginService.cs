using DataCL;
using DataCL.DTOs;
using Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicCL
{
    public class LoginService
    {
        private UserDataTraffic userDataTraffic;

        public LoginService()
        {
            userDataTraffic = new UserDataTraffic();
        }
        public User? validateUserCredentials(string username, string password)
        {
            List<UserDTO> usersDTOs = new List<UserDTO>();
            usersDTOs.AddRange(this.userDataTraffic.retrieveUsers());
            User? foundUser = null;
            UserDTO? userDto = null;
            foreach(UserDTO dto in usersDTOs)
            {
                if (dto.Username == username && dto.Password == password)
                {
                    userDto = dto;
                }
            }
            if (userDto != null)
            {
                if (userDto.Role == 1)
                {
                    foundUser = new HR(userDto.SpouseName, userDto.SpousePhone, userDto.EmergencyName, userDto.EmergencyPhone, userDto.BSN, userDto.ContractStatus, userDto.ImageUrl, userDto.Id, userDto.Firstname, userDto.Lastname, userDto.Username, userDto.Password, userDto.Email, userDto.Phone, userDto.Birthdate, userDto.Address, userDto.City);
                }
                if (userDto.Role == 2)
                {
                    foundUser = new Zookeeper(userDto.SpouseName, userDto.SpousePhone, userDto.EmergencyName, userDto.EmergencyPhone, userDto.BSN, userDto.ContractStatus, userDto.ImageUrl, userDto.Id, userDto.Firstname, userDto.Lastname, userDto.Username, userDto.Password, userDto.Email, userDto.Phone, userDto.Birthdate, userDto.Address, userDto.City);
                }
            }          
            return foundUser;
        }
    }
}
 