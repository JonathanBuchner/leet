using System;
using System.Collections.Generic;
using System.Text;

namespace leet.Cormen.Chapter2
{
	#region Introduction

	// Sequence 
	// Repetions allowed; order matters.
	// In mathematics, a sequence is an enumerated collection of objects in which repetitions are allowed and order matters. Like a set, it contains members (also called elements, or terms). The number of elements (possibly infinite) is called the length of the sequence. Unlike a set, the same elements can appear multiple times at different positions in a sequence, and unlike a set, the order does matter.

	// Set
	// No repetitions; order does not matter.
	//In mathematics, a set is a collection of distinct elements.The elements that make up a set can be any kind of things: people, letters of the alphabet, numbers, points in space, lines, other geometrical shapes, variables, or even other sets. Two sets are equal if and only if they have precisely the same elements.

	// Permutation
	// Change order of set or sequence
	// In mathematics, a permutation of a set is, loosely speaking, an arrangement of its members into a sequence or linear order, or if the set is already ordered, a rearrangement of its elements.The word "permutation" also refers to the act or process of changing the linear order of an ordered se
	#endregion

	// Sorts in place
	public class Insertion_sort
    {
		public void Sort(int[] input)
        {
			if (input.Length < 2) return;

			for (var i = 1; i < input.Length; i++)
			{
				var key = input[i];
				var j = i - 1;

				while (j >= 0 && input[j] > key)
				{
					input[j + 1] = input[j];
					input[j] = key;
					j--;
				}
			}
        }
    }
}

