using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Study.GameStore.Domain.Entities;

namespace Study.GameStore.WebUI.Models
{
    public class GamesListViewModel
    {
        public IEnumerable<Game> Games { get; set; }
        public PagingInfo PagingInfo { get; set; }
        public string CurrentCategory { get; set; }
    }
}