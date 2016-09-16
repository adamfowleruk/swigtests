%module(directors="1")  simplecs

%include <exception.i>
%include <typemaps.i>

%include std_except.i
%include stl.i

%template(SomeKeyTypeMapN) std::map<testlib::nested::SomeKeyTypeN,std::string>;

//,std::less<testlib::SomeKeyType>

%{
#include "nested/header2.hpp"
%}

/* Parse the header file to generate wrappers */
/* WARNING - THESE MUST BE IN DEPENDENCY ORDER!!! ORDER IS VERY VERY IMPORTANT!!! */

%include "nested/header2.hpp"
