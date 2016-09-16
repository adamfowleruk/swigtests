%module(directors="1")  simplecs

%include <exception.i>
%include <typemaps.i>

%include std_except.i
%include stl.i

%nspace testlib::SomeKeyType;
%nspace testlib::SomeKeyTypeMap; // ignored
%nspace testlib::SomeClass;
%nspace testlib::nested::SomeKeyTypeN;
%nspace testlib::nested::SomeKeyTypeMapN; // ignored
%nspace testlib::nested::SomeClassN;
%nspace testlib::nested::SomeClassX;


%template(SomeKeyTypeMap) std::map<testlib::SomeKeyType,std::string>;
%template(SomeKeyTypeMapN) std::map<testlib::nested::SomeKeyTypeN,std::string>;


//,std::less<testlib::SomeKeyType>

%{
#include "testlib/header1.hpp"
#include "testlib/nested/header2.hpp"
%}

/* Parse the header file to generate wrappers */
/* WARNING - THESE MUST BE IN DEPENDENCY ORDER!!! ORDER IS VERY VERY IMPORTANT!!! */

%include "testlib/header1.hpp"

%include "testlib/nested/header2.hpp"
