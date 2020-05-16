﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aurora.Profiles.LeagueOfLegends.GSI.Nodes
{
    public class MatchNode : Node<MatchNode>
    {
        public MapTerrain MapTerrain;

        public GameMode GameMode;

        public float GameTime;

        public bool InGame;

        public int DragonsKilled;

        public int TurretsKilled;

        public int InhibsKilled;

        public int BaronsKilled;

        public int HeraldsKilled;
    }

    public enum MapTerrain
    {
        Unknown,
        Default,
        Infernal,
        Cloud,
        Mountain,
        Ocean
    }

    public enum GameMode 
    {     
        Unknown = -1,
        None = 0,
        PracticeTool
    }
}
