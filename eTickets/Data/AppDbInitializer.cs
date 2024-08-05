using eTickets.Models;

namespace eTickets.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();
                context.Database.EnsureCreated();
                //Cinema

                if (!context.Cinemas.Any())
                {
                    context.Cinemas.AddRange(new List<Cinema>
                    {
                        new Cinema()
                        {
                            Name="Cinema  1",
                            logo="http://dotnethow.net/images/cinemas/cinema-1.jpeg",
                            Description="This is the description of teh first cinema"
                        },
                        new Cinema()
                        {
                            Name="Cinema  2",
                            logo="http://dotnethow.net/images/cinemas/cinema-2.jpeg",
                            Description="This is the description of teh first cinema"
                        },
                        new Cinema()
                        {
                            Name="Cinema  3",
                            logo="http://dotnethow.net/images/cinemas/cinema-3.jpeg",
                            Description="This is the description of teh first cinema"
                        },
                        new Cinema()
                        {
                            Name="Cinema  4",
                            logo="http://dotnethow.net/images/cinemas/cinema-4.jpeg",
                            Description="This is the description of teh first cinema"
                        },
                       new Cinema()
                        {
                            Name="Cinema  5",
                            logo="http://dotnethow.net/images/cinemas/cinema-5.jpeg",
                            Description="This is the description of teh first cinema"
                        },
                    });
                    context.SaveChanges(); 

                }
                //Actors
                if (!context.Actors.Any())
                {
                    context.Actors.AddRange(new List<Actor>() {

                        new Actor() {
                            
                        }





                    });
                                     
                        
                        
                       

                }

                //Produsers
                if (!context.Producers.Any()) 
                { 
                
                
                }
                //Movies
                if(!context.Movies.Any())
                {


                }
                //Actors & Movies
                if(!context.Actor_Movies.Any())
                {

                }
            }
             
        }
    }
}
