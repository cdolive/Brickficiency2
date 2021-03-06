﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindmillHelix.Brickficiency2.Common.Domain;
using WindmillHelix.Brickficiency2.ExternalApi.Bricklink.Models;

namespace WindmillHelix.Brickficiency2.ExternalApi.Bricklink
{
    public interface IBricklinkWantedListApi
    {
        IReadOnlyCollection<WantedList> GetWantedLists();

        IReadOnlyCollection<WantedListItem> GetWantedListItems(int wantedListId);
    }
}
