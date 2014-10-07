mef-mappers-synd
================

Summary
------

Played around with MEF a bit and determined that its functionality doesn't really provide anything better than what an IOC container can provide (in its current form). Autofac (or Unity for that matter) could theoretically provide all the same behavior (and more).


Orig Concepts
-------

Playing with MEF and extensible mappers

Stuff to play around with

1. See if we can make a simple interface that maps from T1 to T2
2. What should map(t1,t2) return? (string, xdoc, jobject) ?
3. What inputs should it take (inSchema, outSchema, inModel) returning outModel ?
