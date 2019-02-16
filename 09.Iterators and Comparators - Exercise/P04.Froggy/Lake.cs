﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P04.Froggy
{
    public class Lake : IEnumerable<int>
    {
        private List<int> stoneValues;

        public Lake(params int[] stoneValues)
        {
            this.stoneValues = stoneValues.ToList();
        }

        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i < this.stoneValues.Count; i += 2)
            {
                yield return this.stoneValues[i];
            }

            int startReversedIndex = this.stoneValues.Count - 1 % 2 != 0 ? this.stoneValues.Count - 2 : this.stoneValues.Count - 1;

            for (int i = startReversedIndex; i >= 0; i -= 2)
            {
                yield return this.stoneValues[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        => this.GetEnumerator();
    }
}
