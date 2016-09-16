# SWIG Tests

These examples are provided as Public Domain with no warranty whatsoever. Use at your own risk.

They were created due to frustration in the documentation for Swig, and the desire to generate working examples.

## Examples

### Simple

This simple example uses a map in a single namespace. This generates all code in to the C# testlib namespace.

### Nested

This uses a nested namespace called 'nested' within the root namespace 'testlib'. This uses multiple I files for SWIG.
This is mentioned as a potential solution to the problem of nested namespaces in SWIG's own documentation.

*WARNING: THIS IS AN ANTI-PATTERN*

The problem with this approach is that you get generated two sets of wrapper CXX and H files which cannot be resolved
easily in a compile step. Each has its own entry points, but only defines the classes within its own namespace.

You will have issues if a class in one namespace relies upon a class in another namespace. A VERY common occurence.

### Dependent  

This is an attempt to fix the namespace issue by using the %nspace feature of the C# support in SWIG, and clever
manipulation of namespaces and templates. It uses a single I swig file.

The remaining issue here is that the Map templates created are created in the root namespace only - i.e. no C#
namespace whatsoever. This can be overridden on the command line, but this causes issues with the %nspace declarations
within the file, and would again require multiple I files, one per namespace. Thus it is a NON STARTER.

## Solution

There currently is no workable solution for a single C++ project with multiple namespaces targeting a C# output
with the same or corresponding namespaces, where interdependencies exist between classes in each namespace.

## Workarounds

Below are some potential workarounds.

### Manually adding namespaces

By using the Dependent example and then manually adding the relevant namespaces before the first 'public class' string
in each generated Map file, and then moving the file to the right namespace subdirectory, it is theoretically possible
to fix this issue.

This would still leave you with potential namespace resolution issues of any classes which use the template - you
would need to ensure each class that uses the template also had a using directive for the relevant namespace.

This may be a suitable workaround short term, but is very very ugly from an Engineering perspective.

## Fixes required

Below lists a few recommended fixes / enhancements for SWIG based on my experiences.

### Add namespace support to templates

Allow something like the below:-

```
%template(testlib.nested.SomeKeyTypeMapN) std::map<testlib::nested::SomeKeyTypeN,std::string>;
```

And have any languages which don't support namespaces silently ignore the dot names.

or alter the output created from this:-

```
namespace testlib {
  %template(SomeKeyTypeMap) std::map<SomeKeyType,std::string>;

  namespace nested {
    %template(SomeKeyTypeMapN) std::map<SomeKeyTypeN,std::string>;
  }
}
```

Make the above actually generated the relevant maps in the correct namespace - at the moment SWIG only uses the
namespace directive to shortcut referencing the full namespace in the std::map<KEYTYPE,VALUETYPE> part, and
not to affect the output of the C# class being created.

Personally I think the current effect of generatingSomeKeyTypeMap in the blank namespace instead of the testlib
namespace when the above is encountered is a bug - if you manually used 'typedef std::map<SomeKeyType,std::string> SomeKeyTypeMap'
in C++ then it would be generated in the testlib namespace, so SWIG actually breaks the mental model of C++ by not
generating the Map class in the testlib namespace.
