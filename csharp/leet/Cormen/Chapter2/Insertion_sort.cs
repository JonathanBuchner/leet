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

		public void ReverseSort(int[] input)
		{
			if (input.Length < 2) return;

			for (var i = 1; i < input.Length; i++)
			{
				var key = input[i];
				var j = i - 1;

				while (j >= 0 && input[j] < key)
				{
					input[j + 1] = input[j];
					input[j] = key;
					j--;
				}
			}
		}
	}

	#region Description

	// Invariants in computer science
	// In computer science, one can encounter invariants that can be relied upon to be true during the execution of a program, or during some portion of it.It is a logical assertion that is always held to be true during a certain phase of execution.For example, a loop invariant is a condition that is true at the beginning and the end of every execution of a loop.

	// Loop invariant
	// In computer science, a loop invariant is a property of a program loop that is true before (and after) each iteration. It is a logical assertion, sometimes checked within the code by an assertion call. Knowing its invariant(s) is essential in understanding the effect of a loop.

	// Loop invarients have initialization, maintenance, and termination.

	// Short curcuiting
	// The result of x && y is true if both x and y evaluate to true. Otherwise, the result is false. If x evaluates to false, y is not evaluated.

	// Analyzing and algorithm
	// Predicting the resources that the algorithm requires.
	// - Usually we care about time, but sometimes also about memory ( or communication bandiwth, or hardware)

	// RAM Model
	// Arithmatic: Add, Subract, Multiple, Divide, Remainder, Floor, Ceiling 
	// Data Movmenet: (load, store, copy)
	// Control (contidtional and unconditional branch, subroutine call, return)
	// Even if you knew the time of each operations, you would still need to count steps because different intputs (such as large numbers vs small numbers create) different amount of times.

	// Best case, average-case, worst case
	// We focus on worst-case
	//	Gives upper bound
	//	Some algorithms, worst case occurs very often (e.g. linear search in application for item that does not exist)
	//	Average case for many algorithms is the same as the worst case

	// What we really care about is order of growth... we care about the leading term of the polynomial and leading terms coeffecient.
	
	#endregion
}

