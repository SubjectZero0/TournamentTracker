﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class MatchupEntryModel
    {
        public TeamModel TeamCompeting { get; set; }
        public int Score { get; set; }
        public MatchupModel ParentMatchup { get; set; }

    }
}
