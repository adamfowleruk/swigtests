#!/bin/bash
rm -rf bin/*
mkdir bin

swig -c++ -v -csharp -outdir bin src/dependent/dependent.i
mv src/dependent/dependent_* bin/
