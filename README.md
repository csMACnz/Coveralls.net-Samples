Coveralls.net Samples
=====================

These are sample configurations for using [coveralls.net](https://github.com/csmacnz/Coveralls.net) with different CI and coverage tools. Each branch is a unique scenario combination of test framework, coverage tool and coveralls.net publishing the results to [coveralls.io](https://coveralls.io/).

### [Sample Application Branch](https://github.com/csmacnz/Coveralls.net-Samples/tree/sample-application) ###
[![Appveyor Build status](https://ci.appveyor.com/api/projects/status/v4m661b28npr789g/branch/sample-application?svg=true)](https://ci.appveyor.com/project/MarkClearwater/coveralls-net-samples/branch/sample-application)
[![Build Status](https://travis-ci.org/csMACnz/Coveralls.net-Samples.svg?branch=sample-application)](https://travis-ci.org/csmacnz/Coveralls.net-Samples)

This branch represents the base application, with tests, so I can branch off of this with different build configurations and see how these are reported in different CI builds, coverage runners, and coveralls.io.

### [xUnit + OpenCover + Appveyor Branch](https://github.com/csmacnz/Coveralls.net-Samples/tree/xunit-opencover-appveyor) ###
[![Appveyor Build status](https://ci.appveyor.com/api/projects/status/v4m661b28npr789g/branch/xunit-opencover-appveyor?svg=true)](https://ci.appveyor.com/project/MarkClearwater/coveralls-net-samples/branch/xunit-opencover-appveyor)
[![Coverage Status](https://coveralls.io/repos/csmacnz/Coveralls.net-Samples/badge.svg?branch=xunit-opencover-appveyor)](https://coveralls.io/r/csmacnz/Coveralls.net-Samples?branch=xunit-opencover-appveyor)

This branch uses the xUnit test runner to run the xUnit tests through OpenCover, and Coveralls.net is run over the results.  This branch is picked up and run by Appveyor using the appveyor.yml file.

### [NUnit + OpenCover + Appveyor Branch](https://github.com/csmacnz/Coveralls.net-Samples/tree/nunit-opencover-appveyor) ###
[![Appveyor Build status](https://ci.appveyor.com/api/projects/status/v4m661b28npr789g/branch/nunit-opencover-appveyor?svg=true)](https://ci.appveyor.com/project/MarkClearwater/coveralls-net-samples/branch/nunit-opencover-appveyor)
[![Coverage Status](https://coveralls.io/repos/csmacnz/Coveralls.net-Samples/badge.svg?branch=nunit-opencover-appveyor)](https://coveralls.io/r/csmacnz/Coveralls.net-Samples?branch=nunit-opencover-appveyor)

This branch uses the NUnit test runner to run the NUnit tests through OpenCover, and Coveralls.net is run over the results.  This branch is picked up and run by Appveyor using the appveyor.yml file.

### [xUnit + monocov + Travis-CI Branch](https://github.com/csmacnz/Coveralls.net-Samples/tree/nunit-opencover-appveyor) ###
[![Build Status](https://travis-ci.org/csMACnz/Coveralls.net-Samples.svg?branch=xunit-monocov-travisci)](https://travis-ci.org/csmacnz/Coveralls.net-Samples)
[![Coverage Status](https://coveralls.io/repos/csmacnz/Coveralls.net-Samples/badge.svg?branch=xunit-monocov-travisci)](https://coveralls.io/r/csmacnz/Coveralls.net-Samples?branch=xunit-monocov-travisci)

This branch uses the xUnit test runner to run the xUnit tests through monocov, and Coveralls.net is run over the results.  This branch is picked up and run by Travis-CI using the travis.yml file.
