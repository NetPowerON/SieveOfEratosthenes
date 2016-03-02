# Sieve Of Eratosthenes

This is an example of Calculating Prime numbers in C# using the Sieve of Eratosthenes method. This example was developed as part of a question used on a programming test for a
employment prospect. Focus on OOP. Thought I would put it here for future reference. This is my original code I just used the Sieve of Eratosthenes method to create the library.
I had an idea for a few optimizations since the sieve is contained in a seperate class it would be possible to keep increasing the size every time the upper limit of the sieve is
reached while looking for Prime numbers. For example in 1000 element sieve with a square root of 10 could be further expanded using the prime numbers already found in the sieve.

The sieve uses a bool array. I tried other array types like BitArray, but I found that for this purpose Bool Array just worked better. A byte array might be even
more suitable.
