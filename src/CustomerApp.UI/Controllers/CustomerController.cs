using AutoMapper;
using CustomerApp.Core.Interfaces;
using CustomerApp.Core.Models;
using CustomerApp.UI.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerApp.UI.Controllers
{
    [Route("Customer")]
    public class CustomerController : Controller
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IStateRepository _stateRepository;
        private readonly ICityRepository _cityRepository;
        private readonly IMapper _mapper;

        public CustomerController(ICustomerRepository customerRepository, 
                                  IStateRepository stateRepository,
                                  ICityRepository cityRepository,
                                  IMapper mapper)
        {
            _customerRepository = customerRepository;
            _stateRepository = stateRepository;
            _cityRepository = cityRepository;
            _mapper = mapper;
        }

        [Route("List")]
        public async Task<IActionResult> Index()
        {
            return View(_mapper.Map<IEnumerable<CustomerViewModel>>(await _customerRepository.GetAll()).OrderBy(c => c.Id));
        }

        public async Task<IActionResult> Details(int id)
        {
            var customerViewModel = _mapper.Map<CustomerViewModel>(await _customerRepository.GetById(id));

            if (customerViewModel == null)
            {
                return NotFound();
            }

            return View(customerViewModel);
        }

        [Route("Add")]
        public async Task<IActionResult> Create()
        {
            ViewData["States"] = new SelectList(await _stateRepository.GetAll(), "Initial", "Name").OrderBy(s => s.Text);

            return View();
        }

        [HttpPost]
        [Route("Add")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CustomerViewModel customerViewModel)
        {
            if (ModelState.IsValid)
            {
                var customer = _mapper.Map<Customer>(customerViewModel);

                await _customerRepository.Create(customer);

                return RedirectToAction(nameof(Index));
            }
            return View(customerViewModel);
        }

        [Route("Edit/{id:int}")]
        public async Task<IActionResult> Edit(int id)
        {
            var customerViewModel = _mapper.Map<CustomerViewModel>(await _customerRepository.GetById(id));

            if (customerViewModel == null)
            {
                return NoContent();
            }

            ViewData["States"] = new SelectList(await _stateRepository.GetAll(), "Initial", "Name").OrderBy(s => s.Text);

            return View(customerViewModel);
        }

        [HttpPost]
        [Route("Edit/{id:int}")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, CustomerViewModel customerViewModel)
        {
            if (id != customerViewModel.Id)
            {
                return NoContent();
            }

            if (ModelState.IsValid)
            {
                var customer = _mapper.Map<Customer>(customerViewModel);

                await _customerRepository.Update(customer);

                return RedirectToAction(nameof(Index));
            }

            return View(customerViewModel);
        }

        [Route("Delete/{id:int}")]
        public async Task<IActionResult> Delete(int id)
        {
            var customerViewModel = _mapper.Map<CustomerViewModel>(await _customerRepository.GetById(id));

            if (customerViewModel == null)
            {
                return NoContent();
            }

            return PartialView(customerViewModel);
        }

        [HttpPost, ActionName("Delete")]
        [Route("Delete/{id:int}")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if(_customerRepository.GetById(id) == null)
            {
                return NotFound();
            }

            await _customerRepository.Delete(id);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> GetStates(string search)
        {
            var list = await _stateRepository.GetAll();
  
            var data = list.Where(j => j.Initial.ToLower().Contains(search.ToLower())).Select(j => j.Initial).ToList();

            return Ok(data);
        }

        [HttpGet]
        [Route("GetCities")]
        public async Task<IActionResult> GetCities(string search, string state)
        {
            var list = await _cityRepository.GetByState(state);

            var data = list.Where(j => j.Name.ToLower().Contains(search.ToLower())).Select(j => j.Name).ToList();

            return Ok(data);
        }
    }
}
