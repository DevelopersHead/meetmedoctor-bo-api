using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using mmd.bo.domain.entity;

namespace mmd_bo_api
{

    [ApiController]
    [Route("[controller]")]
    public class MenuItemController : ControllerBase
    {
        private readonly IBaseService<MenuItem> service;
        public MenuItemController(IBaseService<MenuItem> pService)
        {
            this.service = pService;
        }

        [HttpGet]
        public ICollection<MenuItem> Get()
        {
            return this.service.findAll();
        }
    }
}