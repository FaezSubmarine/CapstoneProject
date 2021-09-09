using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CapstoneProject.Models;
using CapstoneProject.Repository;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using CapstoneProject.Service;
using Microsoft.AspNetCore.Authorization;

namespace CapstoneProject.Controllers
{
    [Route("TestRecord")]
    public class TestRecordController : Controller
    {
        private IRecordRepository recordRepo;
        public IUserService _userService;

        public TestRecordController(IUserService _userService,IRecordRepository recordRepo, ILogger<TestRecordController> logger)
        {
            this.recordRepo = recordRepo;
            this._userService = _userService;
        }

        [Route("Add")]
        [HttpGet]
        public ViewResult add() // get
        {
            List<circuit> circuitList = recordRepo.getCircuits();
            ViewBag.Circuits = new SelectList(circuitList, "id", "name");
            return View();
        }

        [Route("Add")]
        [HttpPost]
        public async Task<ActionResult> create(RaceRequest req) // post // Asp.net core fw is createing the object
        {
            if (ModelState.IsValid)
            {
                req.usernameID = await _userService.GetUserId();
                recordRepo.CreateRequest(req);

                List<RaceRequest> recList = recordRepo.GetRequestRecords().Where(e => e.timing != null).ToList();
                return View("~/Views/Home/index.cshtml", recList);
            }
            ViewBag.Circuits = new SelectList(recordRepo.getCircuits(), "id", "name");
            return View("~/Views/TestRecord/add.cshtml");
        }
        [Route("Accept/{id}")]
        public ActionResult accept(int id)
        {
            recordRepo.changeStatus(id, RequestStatus.ACCEPTED);
            List<RaceRequest> recList = recordRepo.GetRequestRecords().Where(e => e.timing == null).ToList();
            return View("~/Views/TestRecord/RequestList.cshtml", recList);
        }
        [Route("Decline/{id}")]
        public ActionResult decline(int id,string declineReason)
        {
            if(declineReason != null)
            {
                RaceRequest raceRequest = recordRepo.GetRequest(id);
                recordRepo.changeStatus(id, RequestStatus.REJECTED);
                raceRequest.declineReason = declineReason;
                recordRepo.RequestToRecordList(raceRequest);

            }
            List<RaceRequest> recList = recordRepo.GetRequestRecords().Where(e => e.timing == null).ToList();
            return View("~/Views/TestRecord/RequestList.cshtml", recList);
        }
        [Route("AddTime/{id}")]
        [HttpPost]
        public ActionResult AddTime(int id,string timing)
        {
            RaceRequest raceRequest = recordRepo.GetRequest(id);
            if(ModelState.IsValid && timing != null)
            {
                recordRepo.addTime(id, timing);
            }
            List<RaceRequest> recList = recordRepo.GetRequestRecords().Where(e => e.timing == null).ToList();
            return View("~/Views/TestRecord/RequestList.cshtml", recList);
        }

        [Route("RecordList")]
        public ViewResult getAllRaceRecords()
        {
            List<RaceRecords> recList = recordRepo.GetRaceRecords();
            return View("~/Views/TestRecord/RecordList.cshtml", recList);
        }
        [Route("PersonalRecordList")]
        public async Task<ViewResult> getAllPersonalRaceRecords()
        {
            List<RaceRequest> recList = recordRepo.GetRequestRecords();
            string userNameID = await _userService.GetUserId();
            recList = recList.FindAll(e => e.usernameID == userNameID);
            ViewBag.reqList = recordRepo.GetRequestRecords().FindAll(e => e.usernameID == userNameID).Where(e => e.timing == null).ToList();
            return View("~/Views/TestRecord/RecordList.cshtml", recList);
        }


        [Route("RequestList")]
        [Authorize(Roles="Admin,Mod")]
        public ViewResult getAllRaceRquests()
        {
            List<RaceRequest> recList = recordRepo.GetRequestRecords().Where(e=> e.timing == null).ToList();
            return View("~/Views/TestRecord/RequestList.cshtml", recList);
        }

        [Authorize("Admin")]
        [Route("AddCircuit")]
        [HttpPost]
        public IActionResult createCircuit(circuit circuit)
        {
            recordRepo.CreateCircuit(circuit);
            return RedirectToAction(actionName: "CircuitList", controllerName: "TestRecord");
        }
        [Route("AddCircuit")]
        [HttpGet]
        public ViewResult addCircuit()
        {
            return View();
        }
        [Route("CircuitList")]
        public ViewResult getAllCircuits()
        {
            List<circuit> recList = recordRepo.getCircuits();
            return View("~/Views/TestRecord/CircuitList.cshtml", recList);
        }
    }
}
