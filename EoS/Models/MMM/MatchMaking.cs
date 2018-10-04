﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EoS.Models.MMM
{
    public class MatchMaking
    {
        public MatchMaking()
        {
            MaxNoOfMatches = 8; // this.GetType().GetMembers().Count() - 7;
            NoOfMatches = 0;
        }

        [Key]
        public int MatchMakingId { get; set; }

        [Editable(false)]
        [Display(Name = "Date of Match making")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd HH:mm:ss}")]
        public DateTime MatchMakingDate { get; internal set; }

        [Display(Name = "Investment profile")]
        public string InvestmentId { get; set; }
        public virtual Investor.Investment Investment { get; set; }

        [Display(Name = "Startup project")]
        public string StartupId { get; set; }
        public virtual IdeaCarrier.Startup Startup { get; set; }

        [Display(Name = "Project domain")] //1
        public bool? ProjectDomainMatched { get; set; }

        [Display(Name = "Funding phase")] //2
        public bool? FundingPhaseMatched { get; set; }

        [Display(Name = "Funding amount")] //3
        public bool? FundingAmountMatched { get; set; }

        [Display(Name = "Estimated exit plan")] //4
        public bool? EstimatedExitPlanMatched { get; set; }

        [Display(Name = "Team skills")] //5
        public bool? TeamSkillsMatched { get; set; }

        [Display(Name = "Outcomes")] //6
        public bool? OutcomesMatched { get; set; }

        [Display(Name = "Level of innovation")] //7
        public bool? InnovationLevelMatched { get; set; }

        [Display(Name = "Required scalability")] //8
        public bool? ScalabilityMatched { get; set; }

        [Display(Name = "Number of matches")]
        public int NoOfMatches { get; internal set; }

        [Display(Name = "Maximal number of matches")]
        public int MaxNoOfMatches { get; internal set; }

        [Display(Name = "Sent to investor")]
        public bool Sent { get; set; }
    }
}