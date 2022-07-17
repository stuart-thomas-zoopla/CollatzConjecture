# CollatzConjecture
What is the Collatz conjecture?

In short, its a mathematical conjecture that can be defined as - Any positive interger (or whole number) will always return to 1 when processed using the following rules:

- If the interger is even, then divide by 2
- If the interger is odd, then multiply by 3 and add 1

In all known cases, this will eventually return to 1 and enter the 4-2-1 loop. The 4-2-1 loop is a loop at the end of the calculations where 4 divided by 2 is 2, 2 divided by 2 is 1, and 1 mulitplied by 3 add 1 is 4, and so it enters a loop.

[Wikipedia](https://en.wikipedia.org/wiki/Collatz_conjecture) covers the topic in far more detail.

This console app was written as a bit of fun and to kill a few minutes while on Holiday during lockdown.

This console app was inspired by this [Youtube Video](https://www.youtube.com/watch?v=094y1Z2wpJg) and as according to the video we knew for certain numbers smaller than 2^68 complied with the rules of the conjecture, I started with the first number being 2^68 and go up 1 at a time from there.

Word of warning, don't run this for a long time on anything that can be damaged by a large number of writes.  I had it running on a raspberry pi four a couple months and it killed the SD card after a few million writes.
