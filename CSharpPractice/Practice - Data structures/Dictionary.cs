using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice.Practice___Data_structures
{
    public class Dictionary
    {
        private Dictionary<string, string> _inspirationalPlayersDictionary;

        public Dictionary()
        {
            _inspirationalPlayersDictionary = new Dictionary<string, string>();
            PopulateDictionary();
        }

        public void PopulateDictionary()
        {
            _inspirationalPlayersDictionary.Add("Tokido", "Throughout the Grand Finals for Street Fighter League JPN 2022, " +
                "he thrived in the high pressuring matches. If he lost those crucial ones, their entire would've lost. " +
                "To take out Daigo and Gatchikun after losing to them in the final games, it was amazing to watch as he demonstrated" +
                "why to never give up, understand where he could improve and make those adaptations to get the victories");
            _inspirationalPlayersDictionary.Add("Daigo", "I remember how he didn't let his age be an excuse for his performance in competitions. Instead, he accepted" +
                "that his reactions made not be up to par compared to his younger days but works extra hard to make up for that. Also, I really like how humble and stoic he is throughout his matches" +
                "I don't think I've ever seen him popoff during his victories, instead he moves forward and continues to work hard. I also remember him menetioning that he does train with players" +
                "that he may not like, but does it so he can learn from them (and vice versa) and thus make him a stronger player.");
            _inspirationalPlayersDictionary.Add("Mister Crimson", "During 2021, their was a rivalary between Punk and Mister Crimson which Punk started first by mocking him and the European players. " +
                "the first time they players was during the Red Bull Kumite 2021 hosted in London. I remember Punk feeling himself during the warmup sessions. Plus, Punk beat Mister Crimson pretty nicely while they" +
                "at their hotel rooms. And when Punk and Mister Crimson faced off during the Kumite tournament, Mister Crimson learnt from his defeat from Punk and defated him in style! He popped off in front of Punk" +
                "and even said a couple of words to Punk while shaking his hand which Punk got salty and complained on Twitter about it. Mister Crimson then went to win the Red Bull Kumite tournament! Incredible" +
                " But wait, theres more! Mister Crimson and Punk competed in the Street Fighter US league in 2022 and they played against each other in two instances. In both instances, Punk either talked trash about"+
                " Mister Crimson or teabags him during matches. When I watched both matches, depsite all the crap from Punk which he does to try and get into Mister Crimson's head, Mister Crimson didn't let that affect him " +
                "and cause of that, he beat Punk not only with Dhalsim, but he defeated Punk's Karin with his secondary character G which was such a clutch moment! It was so satisfying to see Mister Crimson to put Punk " +
                "in his place in 3 instances! And yet Mister Crimson still never spoke crap about Punk after winning, he simply focused on being the best version of himself which was soo humble.");
        }

        public void PrintInspirationalPlayers()
        {
            foreach(var player in _inspirationalPlayersDictionary.Keys)
            {
                _inspirationalPlayersDictionary.TryGetValue(player, out var text);
                Console.WriteLine($"{player}:{text}");
            }
        }
    }
}
