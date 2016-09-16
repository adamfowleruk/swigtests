%module(directors="1")  simplecs

%include <exception.i>
%include <typemaps.i>

%include std_except.i
%include stl.i

%template(SomeKeyTypeMap) std::map<testlib::SomeKeyType,std::string>;

//,std::less<testlib::SomeKeyType>

%{
#include "testlib/header1.hpp"
%}

/* Parse the header file to generate wrappers */
/* WARNING - THESE MUST BE IN DEPENDENCY ORDER!!! ORDER IS VERY VERY IMPORTANT!!! */

%include "testlib/header1.hpp"
