﻿using HumanEmotions.Emotions.Interface;
using HumanEmotions.Logger;

namespace HumanEmotions.Emotions
{
    public class Happiness : IEmotion
    {
        public override bool Equals(object obj)
        {
            if (object.ReferenceEquals(obj, this))
            {
                return true;
            }
            return this.ToString().Equals(obj.ToString(), System.StringComparison.OrdinalIgnoreCase);
        }
        public override string ToString()
        {
            return ":-)";
        }
    }
}