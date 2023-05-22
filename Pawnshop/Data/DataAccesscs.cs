﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Pawnshop.Models;

namespace Pawnshop.Data
{
    internal static class DataAccess
    {
        const string DATA_PATH = "Data\\Pawnshop.json";

        public static void Save(PawnshopList pawnshop)
        {
            string jsonString = JsonSerializer.Serialize(pawnshop.Lots);
            File.WriteAllText(DATA_PATH, jsonString);
            pawnshop.IsDirty = false;
        }

        public static void Load(PawnshopList pawnshop)
        {
            string jsonString = File.ReadAllText(DATA_PATH);
            var newLots = JsonSerializer.Deserialize<List<Lot>>(jsonString);
            pawnshop.Lots.Clear();
            pawnshop.Lots.AddRange(newLots);
            pawnshop.IsDirty = false;
        }

    }
}