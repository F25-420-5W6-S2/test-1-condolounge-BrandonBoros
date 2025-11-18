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
    public class CondoController : BaseController<Condo>
    {
        private IUnitOfWork _unitOfWork;

        public CondoController(ILogger<CondoController> logger, IUnitOfWork unitOfWork) : base(logger, unitOfWork.GetRepository<ICondoLoungeGenericRepository<Condo>>())
        {
            _unitOfWork = unitOfWork;
        }
    }
}
