using System.Collections.Generic;
using WebApplication2.Models;

namespace WebApplication2.ViewModels
{
    public class HomeVM
    {
        public List<Feature> Features= new List<Feature>(); 
        public List<Service> Services= new List<Service>();
        public List<Testimonial> Tests= new List<Testimonial>(); 
        public List<Portfolio> Portfolios= new List<Portfolio>();
        public List<Team> Teams = new List<Team>();
        public List<Prices> Prices = new List<Prices>();
    }
}
