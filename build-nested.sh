#!/bin/bash
rm -rf bin/*
mkdir bin/testlib-nested
mkdir bin/testlib

swig -c++ -v -csharp -namespace testlib.nested -outdir bin/testlib-nested src/nested/testlib/nested.i
mv src/nested/testlib/nested_* bin/testlib-nested/

#read -n 1 -s

swig -c++ -v -csharp -namespace testlib -outdir bin/testlib src/nested/nested.i
mv src/nested/nested_* bin/testlib/
