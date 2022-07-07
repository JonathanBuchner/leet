# Discrete Optimization


## Week 1

### Professor Pascal Van Hentenryck
> Pascal Van Hentenryck holds a Vice-Chancellor Strategic Chair in Data-Intensive Computing at the Australian National University and is the leader of the Optimisation Research Group at NICTA. Prior to that, he was professor of computer science at Brown University for more than 20 years and a professor at the University of Melbourne. His main research interests are the design and implementation of optimization systems and their applications to complex problems. His current research projects focus on the use of optimization in logistics and supply chains, energy, and disaster management. He has written five books published by the MIT Press and built several optimization systems that are widely used in academia and industry.
>
>https://www.coursera.org/instructor/~1289035

### Syllabus
> Discrete Optimization is the most important field that no one has heard of. It is the science behind high-efficiency manufacturing, inventory management, energy markets, and sports scheduling, just to name a few. This course provides an introductory overview of to the science of Discrete Optimization and through programming assignments gives you first hand experience of what it is like to solve these types of problems. 
>
> https://www.coursera.org/learn/discrete-optimization/supplement/m0x9h/course-syllabus

#### NP Hardness
> In computational complexity theory, NP-hardness (non-deterministic polynomial-time hardness) is the defining property of a class of problems that are informally "at least as hard as the hardest problems in NP". A simple example of an NP-hard problem is the subset sum problem.
>
>https://en.wikipedia.org/wiki/NP-hardness

#### Van Hentenryck Lecture
>So this, what we're going to talk about in this class are optimization problems, like filling up multi knapsack, or like filling a knapsack. And these problems are called optimization problems, okay? So, these are, as I just said, very, very hard problems. They are among the hardest problems in computer science. And we'll talk about it, and this is a very, very well-defined class, they are called NP complete

> And so, informally, these NP-Complete problems will have two properties. 
> - The first one is very interesting. If I give you a solution, you will be able to verify that this actually indeed a solution very quickly.
> - If you can solve one of these problems okay, one of these NPR problems, then you can solve all of them.
>
>So this is essentially what NP Completeness is about. These two properties, you can check very quickly, and if you can solve one of these hard problems, you can solve all of them.
>
>  We are going to say, you know, finding the best possible solution is this humongous set of possibilities. It's just not possible, and what we're going to do is simply say, okay, we'll find a very, very high quality solution. It's not going to be the best, but it's going to be really close to that.  Okay, so that's the other kind of techniques that we will see in this class, okay?

### Greedy Algorithms
#### Van Hentenryck Lecture - Knapsack 1 - intuition
> First, in the next lecture is talk about greedy algorithm. And what you just saw is essentially, a very simple instance of a greedy algorithm. We take the most valuable item first and then the next valuable item that can fit into a knapsack. But there are many, many possible greedy algorithms.
>
> So, the key idea on all the greedy algorithms is going to be the same. **You're going to pick one item at a time in a greedy fashion.** And the only thing that's going to differ is the meaning of greedy in every one of these algorithms. Okay?
>
> So, in a sense, the main messages today is to show you that in practice there are many different greedy algorithms that you can build. You have to think, you know, creatively. What is the best greedy algorithms that I could get? And some will be better than others in different kinds of instances, okay, so, and, and so you may actually use several of them at the same time. The advantage of this is that they are very easy to use, very easy to design, okay, they can be very, very fast, they give you a first solution, they tell you, okay, you know, now I understand something about this problems. I know that this is at least a baseline, and I have to start doing better than this. They have a lot of issues obviously, okay? So, there is no solution guarantees in general. You don't know much you can improve them, you don't know how good they are. The quality of these heuristics may value from problems to problem, from instances to instances, and so on. And one of the things that I have assumed here is that you can build the solution easily. 

