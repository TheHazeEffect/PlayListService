using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;


namespace PlayListService.Web.Data
{
    public class SeedData
    {
        private readonly PlayListServiceContext _context;

        SeedData(PlayListServiceContext context){
            _context = context;
        }

         public static async Task InitializeAsync(IServiceProvider services)
        {
            var dbContext = services.GetRequiredService<PlayListServiceContext>();
            
            dbContext.Database.Migrate();
            //Seeders

            
            if (Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") == "Development")
            {
               
            }
        } 
    }
    
}