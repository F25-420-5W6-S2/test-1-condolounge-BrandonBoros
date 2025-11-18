using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CondoLounge.Data;
using CondoLounge.Data.Entities;
using CondoLounge.Controllers.Base;
using CondoLounge.Data.Interfaces;

namespace CondoLounge.Controllers
{
    public class BuildingController : BaseController<Building>
    {
        private IUnitOfWork _unitOfWork;

        public BuildingController(ILogger<BuildingController> logger, IUnitOfWork unitOfWork) : base(logger, unitOfWork.GetRepository<ICondoLoungeGenericRepository<Building>>())
        {
            _unitOfWork = unitOfWork;
        }
    }
}
