﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AspirationQuiz
{
    class MaleAspirationQuiz : AbstractAspirationQuiz
    {
        
        public MaleAspirationQuiz(): base()
        {
            Description = "Are you an aspiring male?";
        }

        protected override List<AspirationQuestion> FullQuestionsList()
        {
            List<AspirationQuestion> fullList = new List<AspirationQuestion>();
            fullList.Add(new AspirationQuestion("You have a mission in life", 7));
            fullList.Add(new AspirationQuestion("You believe in yourself", 5));
            fullList.Add(new AspirationQuestion("You know what you want to do when you grow up", 5));
            fullList.Add(new AspirationQuestion("You have a clear vision of your future", 5));
            fullList.Add(new AspirationQuestion("You find it easy to stay relaxed even when there is some pressure.", 5));
            fullList.Add(new AspirationQuestion("You usually do things out of sheer curiousity.", 3));
            fullList.Add(new AspirationQuestion("Are you comfortable leading?", 4));
            fullList.Add(new AspirationQuestion("Do you listen to others, especially if they're more experienced on a certain subject?", 6));
            return fullList;
        }
    }
}
