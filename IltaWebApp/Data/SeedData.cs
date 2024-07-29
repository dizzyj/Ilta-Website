using IltaWebApp.Models;
namespace IltaWebApp.Data
{
    public static class SeedData
    {
        public static void Initialize(BlogPostContext db)
        {
            var blogs = new BlogPost[]
            {
                new BlogPost()
                {
                    CreatedAt = new DateTime(2024,5,1),
                    ImageUrl = "journal/may2024.png",
                    Text = " i'm on new ADHD meds and they're actually working?! i can finally crank out art again! i'm working on finishing the\ntrash animals piece i've put off for... well, years... and i'm also starting a cake themed animal series.\ni also made some amazing food this month. the images above are chicken katsu with rice, and pork udon."
                },
                new BlogPost()
                {
                    CreatedAt = new DateTime(2024,4,1),
                    ImageUrl = "journal/april2024.png",
                    Text = " went to a wedding in california this month, for my sister in law and her now wife! <br><br>\r\n\r\n                i have also been working on a new isometric piece. it will have a transition animation between outside and inside-\r\n                fun stuff!"
                },
                new BlogPost()
                {
                    CreatedAt = new DateTime(2024,3,1),
                    ImageUrl = "journal/march2024.png",
                    Text = " this month, i've been struck with extreme fatigue due to hormonal imbalance issues 😭 i feel like i'm going to fall\r\n                asleep at any moment all day... it's a lot. <br><br>\r\n\r\n                i've also been obsessed with watching weekly dungeon meshi under the kotatsu, with delicious homemade japanese meals\r\n                for me and my family. such cozy times, it's a shame we'll have to put away the blanket soon, now that it's becoming\r\n                warmer! here's some of the meals in question from this month."
                },
                new BlogPost()
                {
                    CreatedAt = new DateTime(2024,2,1),
                    ImageUrl = "journal/february2024.png",
                    Text = "valentine's day is me & my husband's anniversary. btw, <i>do not get married on valentine's.</i> absolutely terrible\r\n                decision on our part... we go out to eat and all our favorite restaurants are reservation only! we always celebrate\r\n                the weekend of instead. it will be year 9 for us this year. next year, for the big #10, we're thinking of changing our\r\n                date with a mini ceremony to escape valentine's hell. <br><br>\r\n\r\n                i got an urge to draw borzois this month after being inspired by the new <a href=\"https://www.youtube.com/watch?v=Z9ZlS7i2Xvc\">\r\n                    SIAMES music video\r\n                </a>. seriously can't get enough of the artistry and cult vibe. the boizoi's are not quite done yet,\r\n                but the sketches are above!"
                },
                new BlogPost()
                {
                    CreatedAt = new DateTime(2024,1,1),
                    ImageUrl = "journal/january2024.png",
                    Text = "first post! this will be my digital journal/sketchbook where i post thoughts and share sketches. i wanted a leisurely\r\n                corner of the internet where i can unwind and update you, as recently social media stresses me out. i'll be doing a\r\n                format where i add the month, then fill out the month with 1-4 paragraphs whever i feel i have something to say. <br><br>\r\n\r\n                i finished my kotatsu i've been building with my dad! it was a huuuge project but we finally got it done and i ADORE\r\n                it. coziest single item in existence <br><br>\r\n\r\n                i also made a top 10 waifu list during discord shenanigans this month. <a><i>click the image above to behold!</i></a><br><br>"
                }
            };
            db.BlogPosts.AddRange(blogs);
            db.SaveChanges();
        }
    }
}
