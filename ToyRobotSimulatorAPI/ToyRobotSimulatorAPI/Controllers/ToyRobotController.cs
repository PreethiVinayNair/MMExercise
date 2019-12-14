using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ToyRobotSimulator.Services;
using ToyRobotSimulatorAPI.ModelBinding;

namespace ToyRobotSimulatorAPI.Controllers
{
    [ApiVersion("1.0")]
    [Route("api/[controller]")]
    [ApiController]
    public class ToyRobotController : ControllerBase
    {
        private readonly IToyRobotSimulatorService toyRobotSimulatorService;
        private readonly ILogger _logger;

        public ToyRobotController(IToyRobotSimulatorService toyRobotSimulatorService, ILogger<ToyRobotController> logger)
        {
            this.toyRobotSimulatorService = toyRobotSimulatorService;
            this._logger = logger;
        }
        [HttpPost]
        [MapToApiVersion("1.0")]
        [Route("")]
        public Task<string> Post([ModelBinder(typeof(QueryArgumentsModelBinder))] QueryArguments arguments)
        {
            try
            {
                _logger.LogInformation("Start of the Toy Robot Simulator Service");
                var report = toyRobotSimulatorService.simulate(arguments.Data);


                return Task.FromResult("");

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Stopped program because of exception");
                throw ex;
            }
        }
    }
}