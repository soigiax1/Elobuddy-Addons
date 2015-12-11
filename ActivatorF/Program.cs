using System;
using System.Linq;
using ActivatorF.Defencives;
using ActivatorF.Items;
using ActivatorF.Summoner_Spells;
using EloBuddy;
using EloBuddy.SDK;
using EloBuddy.SDK.Events;
using EloBuddy.SDK.Menu;

namespace ActivatorF
{
    internal class Program
    {
        public static Menu Menu;

        private static void Main(string[] args)
        {
            Loading.OnLoadingComplete += Loading_OnLoadingComplete;
        }

        private static void Loading_OnLoadingComplete(EventArgs args)
        {
            Menu = MainMenu.AddMenu("Activator F", "activatorMenu");
            ItemManager.Init();
            SummonerSpells.Init();
            Defence.Init();
        }
    }
}
