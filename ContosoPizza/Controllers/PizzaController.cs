using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContosoPizza.Models;
using ContosoPizza.Services;
using Microsoft.AspNetCore.Authorization.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;

namespace ContosoPizza.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PizzaController :ControllerBase
    {
        public  PizzaController(){
        

        }

        //Todas
        [HttpGet]
        public ActionResult<List<Pizza>> GetAll() => PizzaService.GetAll(); 
       
       
       //Por Id
        [HttpGet("{id}")]
        public ActionResult <Pizza> GetId(int id){
            var pizza=PizzaService.GetId(id);
            if(id == null)
                 return NotFound();
            return pizza;
             
            
        //Adicionar
        }
        [HttpPost]
        public IActionResult Create(Pizza pizza)
        {            
             PizzaService.add(pizza);
                return CreatedAtAction(nameof(GetId), new { id = pizza.Id }, pizza);
        }
        //Modificar
        [HttpPut("{id}")]
        public IActionResult Update(int id, Pizza pizza)
        {
             if (id != pizza.Id)
                 return BadRequest();
           
         var PizzaExiste = PizzaService.GetId(id);
             if(PizzaExiste is null)
                 return NotFound();
   
            PizzaService.Update(pizza);           
   
                return NoContent();
}

        [HttpDelete("{id}")]
        public IActionResult Delete (int id){
           var pizza= PizzaService.GetId(id);
                if(pizza is null)
                    return NotFound();
                PizzaService.Delete(id);
                    return NoContent();
            
            
        }

     

    
           
}

        
    }
    
