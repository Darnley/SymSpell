﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Speller.SpellingBox.Models
{
    public interface IMachineLearningWord
    {
    }

    public class MachineLearningWord : IMachineLearningWord
    {
        public string Word { get; set; }
        public int Index { get; set; } = -1;
    }
}
