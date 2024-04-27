using BusinessLogicLayer.DTOs.Braches;
using BusinessLogicLayer.Interfaces.Branches;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Apteka.WebApi.Controllers.Branches
{
    [Route("api/branch")]
    [ApiController]
    public class BranchController : ControllerBase
    {
        private IBranchService _branchService;

        public BranchController(IBranchService branchService)
        {
            _branchService = branchService;
        }
        [HttpGet]
        public IActionResult GetAll()
        => Ok(_branchService.GetAll());

        [HttpPost]
        public IActionResult Add(AddBranchDto dto)
        => Ok(_branchService.Add(dto));

        [HttpDelete]
        public IActionResult Remove(Guid Id)
        => Ok(_branchService.Remove(Id));

        [HttpPut]
        public IActionResult Update(UpdateBranchDto dto, Guid Id)
        => Ok(_branchService.Update(dto, Id));
    }
}
