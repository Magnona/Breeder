using System.Collections.Generic;
using System.Linq;
using Breeder.Common.Dto;
using Breeder.Framework.Repositories;
using BreederWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace BreederWeb.Controllers
{

    public class BullyDogController : Controller
    {
        public IActionResult Puppy()
        {
            var model = new BullyDogViewModel();
            model.Pets = GetAllPets().Where(x => !x.IsAdult).ToList();
            model.SelectedPet = model.Pets.FirstOrDefault(pet => pet.Name == "Dog 3");
            model.Title = "Available Puppies";
            return View("BullyDog", model);
        }

        public IActionResult AdultDog()
        {
            var model = new BullyDogViewModel();
            model.Pets = GetAllPets().Where(x => x.IsAdult).ToList();
            model.SelectedPet = model.Pets.FirstOrDefault(pet => pet.Name == "Dog 3");
            model.Title = "Available Dogs";
            return View("BullyDog", model);
        }

        /*
        //
        // GET: /ShoppingCart/
        public async Task<IActionResult> GetPetInfo(int id)
        {
            var cart = ShoppingCart.GetCart(DbContext, HttpContext);

            // Set up our ViewModel
            var viewModel = new ShoppingCartViewModel
            {
                CartItems = await cart.GetCartItems(),
                CartTotal = await cart.GetTotal()
            };

            // Return the view
            return View("Detail",viewModel);
        }


        //
        // GET: /ShoppingCart/AddToCart/5
        */
        //BullyDog/GetPetInfo/1
        public IActionResult GetPetInfo(int id)
        {
            var model = new BullyDogViewModel();
            model.Pets = GetAllPets();
            model.SelectedPet = model.Pets.FirstOrDefault(pet => pet.Name == "Dog 3");
            return View("Detail", model);
        }


        #region  Api

        private ICollection<PetDto> GetAllPets()
        {
            var repo = new PetRepository();
            return repo.GetAllPets();
        }

        #endregion

    }
}
