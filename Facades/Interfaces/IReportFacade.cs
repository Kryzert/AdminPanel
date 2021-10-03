using AdminPanel.Models;
using AdminPanel.Models.Requests;
using AdminPanel.Models.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminPanel.Facades.Interfaces
{
    public interface IReportFacade
    {
        public Task<UserResponse> GetUserReportAsync();
        public Task<UserResponse> AddUserReportAsync(UserRequest userRequest);
        public Task<string> DeleteUserReportAsync(string userId);
        public Task UpdateUserReportAsync(string userId, UserRequest userRequest);
    }
}
