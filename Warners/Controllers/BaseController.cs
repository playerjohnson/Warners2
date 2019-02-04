using System;
using System.Diagnostics;
using System.Web.Mvc;
using Warners.Common.Serialization;
using Warners.Common.Services.Cache;
using Warners.Common.Services.Model;
using Warners.Common.Services.Session;

namespace Warners.Controllers
{
    public class BaseController : Controller
    {
        protected readonly ISessionService _sessionService;
        protected readonly ICacheService _cacheService;
        protected readonly IQAFModelService _modelService;
        protected readonly ISerializer _serializer;

        public BaseController(ICacheService cacheService, ISessionService sessionService, IQAFModelService modelService, ISerializer serializer)
        {
            this._sessionService = sessionService;
            this._cacheService = cacheService;
            this._modelService = modelService;
            this._serializer = serializer;
        }

        protected override void OnException(ExceptionContext filterContext)
        {
            base.OnException(filterContext);

            filterContext.ExceptionHandled = true;

            Exception ex = filterContext.Exception;

            string message = ex.Message;

            Debug.WriteLine(message);
        }
    }
}