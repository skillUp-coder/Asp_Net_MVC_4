using System.Data.Entity;
using epam_task_4_data.Entities;

namespace epam_task_4.Repository
{
    public class DbInitialicer:DropCreateDatabaseAlways<DataContext>
    {
        protected override void Seed(DataContext context)
        {
            context.feedBackDatas.Add(new FeedBackData { Name = "Jony", Message="Not bad" });
            
            context.Articles.Add(new Article { Author= "Robert McLachlan", Title = "New Zealand poised to introduce clean car standards and incentives to cut emissions", Text= "The New Zealand government has proposed new fuel standards to cut greenhouse emissions, along with consumer rebates for cleaner cars – paid for by fees on high-polluting cars.The long - awaited proposed changes would bring New Zealand in line with most other developed countries; apart from New Zealand, Russia and Australia are the last remaining OECD nations without fuel efficiency standards." });
            context.Articles.Add(new Article { Author = "Joshua Hammer", Title = "Charging Ahead With a New Electric Car", Text = "The middle of 2007, Shai Agassi, a software multimillionaire turned environmental entrepreneur, was pondering how to make an electric car affordable to the average Joe. At that point, the all-electric vehicle—as opposed to electric-gasoline hybrids such as the Toyota Prius—was widely derided as impractical. General Motor’s EV1 had appeared in 1996 and, despite its cultlike following, the company stopped producing it after three years, saying the program was not commercially successful. The most advanced electric vehicle, the Tesla Roadster, was about to be released; it would travel some 200 miles on a fully charged battery, but at $109,000, the sleek sports car would be accessible only to the affluent; the company says about 1,200 of the vehicles are on the road. More affordable cars, at the time mostly in the planning stages, would be equipped with batteries averaging just 40 to 100 miles per charge. The power limitations had even spawned a new expression—“range anxiety,” the fear of being stranded with a dead battery miles from one’s destination." });

            base.Seed(context);
        }
    }
}