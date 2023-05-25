using System;
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
        const string DATA_PATH2 = "Data\\State.json";

        public static void Save(PawnshopList pawnshop)
        {
            string jsonString = JsonSerializer.Serialize(pawnshop);
            File.WriteAllText(DATA_PATH, jsonString);
            pawnshop.IsDirty = false;
        }

        public static void Load(PawnshopList pawnshop)
        {
            string jsonString = File.ReadAllText(DATA_PATH);
            var newPawnshop = JsonSerializer.Deserialize<PawnshopList>(jsonString);
            pawnshop.Lots.Clear();
            pawnshop.Lots.AddRange(newPawnshop.Lots);
            pawnshop.IdCounter = newPawnshop.IdCounter;
            pawnshop.IsDirty = false;
        }

        public static bool stateLoad()
        {
            string jsonString = File.ReadAllText(DATA_PATH2);
            var newState = JsonSerializer.Deserialize<bool>(jsonString);
            return newState;
        }
        public static void stateSave(bool IsLoaded)
        {
            string jsonString = JsonSerializer.Serialize(IsLoaded);
            File.WriteAllText(DATA_PATH2, jsonString);
        }
    }
}
