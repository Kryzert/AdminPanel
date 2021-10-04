using Microsoft.AspNetCore.Mvc;
using AdminPanel.Facades.Interfaces;
using System.Threading.Tasks;
using AdminPanel.Models.Requests;
using AdminPanel.Models.Responses;
using AdminPanel.Facades;
using AdminPanel.Models;
using System.Collections.Generic;
using System;
using Microsoft.Extensions.Logging;

namespace AdminPanel.Controllers
{
    [Route("user")]
    [ApiController]
    
    public class ReportController : Controller
    {
        #region Constructor
        public ReportController()
        {
            
        }
        #endregion

        /// <summary>
        /// Retrieves an user || all users
        /// </summary>
        [HttpGet("get")]
        public async Task<UserResponse> GetUsersReportAsync()
        {
            System.Diagnostics.Debug.WriteLine("Método GET acionado!");
            var reportFacade = new ReportFacade();
            var response = await reportFacade.GetUserReportAsync();
            
            return response;
        }

        /// <summary>
        /// Add an user
        /// </summary>
        [HttpPost("add")]
        public async Task<UserResponse> AddUserReportAsync([FromBody] UserRequest userRequest)
        {
            System.Diagnostics.Debug.WriteLine("Método POST acionado!");
            var reportFacade = new ReportFacade();

            if (userRequest == null)
            {
                return new UserResponse();
            }
            var response = await reportFacade.AddUserReportAsync(userRequest);

            return response;
        }

        /// <summary>
        /// Delete a report
        /// </summary>
        [HttpDelete("delete/{id}")]
        public async Task<string> DeleteUserReportAsync(string id)
        {
            System.Diagnostics.Debug.WriteLine("Método DELETE acionado!");
            var reportFacade = new ReportFacade();

            var response = await reportFacade.DeleteUserReportAsync(id);

            return response;
        }

        /// <summary>
        /// Update a report
        /// </summary>
        /// <param name="request"></param>
        [HttpPut("update/{id}")]
        public async Task UpdateUserReportAsync(string id, [FromBody] UserRequest userRequest)
        {
            System.Diagnostics.Debug.WriteLine("Método PUT acionado!");
            var reportFacade = new ReportFacade();

            await reportFacade.UpdateUserReportAsync(id, userRequest);
        }
    }
}
