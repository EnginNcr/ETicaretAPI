﻿using ETicaretAPI.Application.Abstractions;
using ETicaretAPI.Application.Repositories;
using ETicaretAPI.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ETicaretAPI.API.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class ProductsController : ControllerBase
  {
    readonly private IProductWriteRepository _productWriteRepository;
    readonly private IProductReadRepository _productReadRepository;

    readonly private IOrderWriteRepository _orderWriteRepository;
    readonly private IOrderReadRepository _orderReadRepository;
    readonly private ICustomerWriteRepository _customerWriteRepository;


    public ProductsController(IProductWriteRepository productWriteRepository, IProductReadRepository productReadRepository, IOrderWriteRepository orderWriteRepository, ICustomerWriteRepository customerWriteRepository, IOrderReadRepository orderReadRepository)
    {
      _productWriteRepository = productWriteRepository;
      _productReadRepository = productReadRepository;
      _orderWriteRepository = orderWriteRepository;
      _customerWriteRepository = customerWriteRepository;
      _orderReadRepository = orderReadRepository;
    }
    [HttpGet]
    public async Task Get()
    {
      Order order=await _orderReadRepository.GetByIdAsync("411a379c-5b80-49ff-b57a-bf6f163239b8");
      order.Address = "İstanbul";
      await _orderWriteRepository.SaveAsync();
    }


  }
}
