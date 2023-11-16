using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContosoPizza.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.FileProviders;

namespace ContosoPizza.Services
{
    public static class PizzaService
    {
        static List<Pizza> Pizzas {get;}
        static int nextId=3;
        static PizzaService(){
            Pizzas = new List<Pizza>{
                new Pizza {Id = 1 ,Name = "Italiana", LivreDeGluten = false},
                new Pizza { Id = 2 , Name = "Portuguesa", LivreDeGluten = false}
            };

        }
      public  static List<Pizza> GetAll()=> Pizzas;
       public static Pizza GetId(int id) => Pizzas.FirstOrDefault(p=>p.Id ==id);
        
       public  static void add ( Pizza pizza){
            pizza.Id= nextId++;
            Pizzas.Add(pizza);
            
        }
    public   static  void  Delete (int id){
            var DeletarporID= GetId(id);
            if(id == null)
               
            Pizzas.Remove(DeletarporID);
        }
       public static void  Update (Pizza pizza){
            var index =Pizzas.FindIndex(p=>p.Id==pizza.Id);
            if (index == -1)
            Pizzas[index]= pizza;
            




        }
    }
}