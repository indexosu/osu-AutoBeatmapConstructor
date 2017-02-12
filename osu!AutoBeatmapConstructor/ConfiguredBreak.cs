﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BMAPI.v1.HitObjects;

namespace osu_AutoBeatmapConstructor
{
    [Serializable]
    public class ConfiguredBreak : ConfiguredPattern
    {
        public int seconds;

        public ConfiguredBreak(int seconds) : base(PatternType.Break, false)
        {
            this.seconds = seconds;
        }

        public ConfiguredBreak()
        {

        }

        public override List<CircleObject> generatePattern(MapContextAwareness mapContext)
        {
            int periods = (int)(1000.0 * seconds / mapContext.bpm);
            mapContext.Offset += mapContext.bpm * periods;

            return new List<CircleObject>();
        }

        public override string ToString()
        {
            return seconds + " seconds break";
        }
    }
}
