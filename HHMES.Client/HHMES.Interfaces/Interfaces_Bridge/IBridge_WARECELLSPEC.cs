﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace HHMES.Interfaces
{
    public interface IBridge_WARECELLSPEC
    {
        System.Data.DataTable FuzzySearch(string content);

    }
}
