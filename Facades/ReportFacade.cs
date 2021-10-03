using AdminPanel.Facades.Interfaces;
using AdminPanel.Models;
using AdminPanel.Models.Requests;
using AdminPanel.Models.Responses;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AdminPanel.Facades
{
    
    public class ReportFacade : IReportFacade
    {
        
        public ReportFacade()
        {

        }

        public async Task<UserResponse> GetUserReportAsync()
        {
            var response = new UserResponse();
            response.User = Program.userList;
            response.Status = "OK";

            return response;
        }

        public async Task<UserResponse> AddUserReportAsync(UserRequest userRequest)
        {
            var response = new UserResponse();
            var user = new User();

            foreach (var item in userRequest.User)
            {
                user.Approved = item.Approved;
                user.Email = item.Email;
                user.Id = item.Id;
                user.Name = item.Name;
                user.Phone = item.Phone;
                user.RegisterDate = item.RegisterDate;
            }

            Program.userList.Add(user);

            response.User = Program.userList;
            response.Status = "Ok";

            return response;
            
        }

        public async Task<string> DeleteUserReportAsync(string id)
        {
            if (Program.userList.Exists(x => x.Id == id))
            {
                Program.userList.RemoveAll(x => x.Id == id);
                return "Usuário com id " + id + " deletado com sucesso!";
            }
            return "Este usuário não existe.";
        }

        public async Task UpdateUserReportAsync(string userId, UserRequest userRequest)
        {
            if (Program.userList.Exists(x => x.Id == userId))
            {
                int index = Program.userList.FindIndex(x => x.Id == userId);
                var user = Program.userList.Find(x => x.Id == userId);
                

                foreach (var item in userRequest.User)
                {
                    user.Approved = item.Approved;
                    user.Email = item.Email ?? user.Email;
                    user.Id = userId;
                    user.Name = item.Name ?? user.Name;
                    user.Phone = item.Phone ?? user.Phone;
                    user.RegisterDate = item.RegisterDate ?? user.RegisterDate;
                }

                Program.userList.RemoveAt(index);
                Program.userList.Insert(index, user);

            }
        }
    }
}
