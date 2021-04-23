using AutoMapper;
using Core.DTOs;
using Core.Entities;
using Core.Exceptions;
using Core.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Models;

namespace Web.Controllers
{
    public class OrderController : Controller
    {
        private readonly IUserService _userService;
        private readonly IOrderService _orderService;

        public OrderController(IUserService userService, IOrderService orderService)
        {
            _userService = userService;
            _orderService = orderService;
        }

        [HttpGet]
        public IActionResult CreateOrder()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateOrder(UserViewModel userViewModel)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var mapper = new MapperConfiguration(cfg => cfg.CreateMap<UserViewModel, User>()).CreateMapper();
                    var user = mapper.Map<UserViewModel, User>(userViewModel);

                    _userService.Create(user);
                    _orderService.Create(user.Email);

                    return RedirectToAction("GetListOrders");
                }
                catch (ValidationException ex)
                {
                    ModelState.AddModelError(ex.Property, ex.Message);
                }
            }

            return View();
        }

        [HttpGet]
        public IActionResult GetListOrders()
        {
            var orderDTOs = _orderService.GetAll();
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<OrderDTO, OrderViewModel>()).CreateMapper();
            var orders = mapper.Map<IEnumerable<OrderDTO>, List<OrderViewModel>>(orderDTOs);

            return View(new ListOrderViewModel() {  Orders = orders.OrderByDescending(p=>p.DateTimeOrder)});
        }
    }
}
