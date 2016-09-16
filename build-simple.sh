#!/bin/sh
rm -rf bin/*
swig -c++ -v -csharp -namespace testlib -outdir bin src/simple/simple.i
mv src/simple/simple_* bin/
