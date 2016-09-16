

#include <map>
#include <string>

namespace testlib {

class SomeKeyType {
public:
  bool operator=(const SomeKeyType& other);
  const std::string getSomething() const;
  void doSomething();
};

class SomeClass {
public:

  const std::map<SomeKeyType,std::string> getResults();
  void setResults(std::map<SomeKeyType,std::string> own_map);

};


}
