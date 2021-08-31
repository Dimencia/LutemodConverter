﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuteMod.TrackSelection
{
    public class MidiChannelItem
    {
        private int id;
        private bool active;

        public int Id { get => id; set => id = value; }
        public string Name { get { return MidiChannelTypes.Names[id]; } }
        public bool Active { get => active; set => active = value; }
    }
}
