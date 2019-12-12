using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ToyRobotSimulator.Services;

namespace ToyRobotSimulatorAPI.Controllers
{
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
    }
}