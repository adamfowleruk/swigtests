

#include <map>
#include <string>

#include <testlib/header1.hpp>

namespace testlib {

namespace nested {

class SomeKeyTypeN {
public:
  bool operator=(const SomeKeyTypeN& other);
  const std::string getSomething() const;
  void doSomething();
};

class SomeClassN {
public:

  const std::map<SomeKeyTypeN,std::string> getResults();
  void setResults(std::map<SomeKeyTypeN,std::string> own_map);

};

class SomeClassX {
public:

  const std::map<SomeKeyType,std::string> getTopResults();
};


}
}
