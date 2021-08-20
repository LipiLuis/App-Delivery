using AppFood.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppFood.Services
{
    public class SaboresPizzaServices
    {
        public List<SaboresPizza> GetAll()
        {
            return new List<SaboresPizza>
            {
                new SaboresPizza(1,1,"dasdsa", 5.00m)
            };
        }

    }
}
