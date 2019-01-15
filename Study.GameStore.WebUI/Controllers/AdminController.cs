﻿using Study.GameStore.Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Study.GameStore.WebUI.Controllers
{
    public class AdminController : Controller
    {
        IGameRepository repository;

        public AdminController(IGameRepository repo)
        {
            repository = repo;
        }

        public ViewResult Index()
        {
            return View(repository.Games);
        }
    }
}