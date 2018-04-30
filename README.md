Coveralls.net Samples
=====================

These are sample configurations for using [coveralls.net](https://github.com/csMACnz/Coveralls.net) with different CI and coverage tools. Each branch is a unique scenario combination of test framework, coverage tool and coveralls.net publishing the results to [coveralls.io](https://coveralls.io/).

### [Sample Application Branch](https://github.com/csMACnz/Coveralls.net-Samples/tree/sample-application) ###
[![Appveyor Build status](https://ci.appveyor.com/api/projects/status/v4m661b28npr789g/branch/sample-application?svg=true)](https://ci.appveyor.com/project/MarkClearwater/coveralls-net-samples/branch/sample-application)
[![Build Status](https://travis-ci.org/csMACnz/Coveralls.net-Samples.svg?branch=sample-application)](https://travis-ci.org/csMACnz/Coveralls.net-Samples)

This branch represents the base application, with tests, so I can branch off of this with different build configurations and see how these are reported in different CI builds, coverage runners, and coveralls.io.

### [.Net Core + xUnit + OpenCover + Appveyor Branch](https://github.com/csMACnz/Coveralls.net-Samples/tree/core-xunit-opencover-appveyor) ###
[![Appveyor Build status](https://ci.appveyor.com/api/projects/status/v4m661b28npr789g/branch/core-xunit-opencover-appveyor?svg=true)](https://ci.appveyor.com/project/MarkClearwater/coveralls-net-samples/branch/core-xunit-opencover-appveyor)
[![Coverage Status](https://coveralls.io/repos/csMACnz/Coveralls.net-Samples/badge.svg?branch=core-xunit-opencover-appveyor)](https://coveralls.io/github/csMACnz/Coveralls.net-Samples?branch=core-xunit-opencover-appveyor)

This is using the latest dotnet 2.1 global tools version of Coveralls.net.

This branch has a .Net Core application using the xUnit test runner to run the xUnit tests through OpenCover, and Coveralls.net is run over the results.  This branch is picked up and run by Appveyor using the appveyor.yml file.

### [.Net 4.5.1 + xUnit + OpenCover + Appveyor Branch](https://github.com/csMACnz/Coveralls.net-Samples/tree/xunit-opencover-appveyor) ###
[![Appveyor Build status](https://ci.appveyor.com/api/projects/status/v4m661b28npr789g/branch/xunit-opencover-appveyor?svg=true)](https://ci.appveyor.com/project/MarkClearwater/coveralls-net-samples/branch/xunit-opencover-appveyor)
[![Coverage Status](https://coveralls.io/repos/csMACnz/Coveralls.net-Samples/badge.svg?branch=xunit-opencover-appveyor)](https://coveralls.io/github/csMACnz/Coveralls.net-Samples?branch=xunit-opencover-appveyor)

This branch has a legacy .Net 4.5.1 Application using the xUnit test runner to run the xUnit tests through OpenCover, and Coveralls.net is run over the results.  This branch is picked up and run by Appveyor using the appveyor.yml file.

### [NUnit + OpenCover + Appveyor Branch](https://github.com/csMACnz/Coveralls.net-Samples/tree/nunit-opencover-appveyor) ###
[![Appveyor Build status](https://ci.appveyor.com/api/projects/status/v4m661b28npr789g/branch/nunit-opencover-appveyor?svg=true)](https://ci.appveyor.com/project/MarkClearwater/coveralls-net-samples/branch/nunit-opencover-appveyor)
[![Coverage Status](https://coveralls.io/repos/csMACnz/Coveralls.net-Samples/badge.svg?branch=nunit-opencover-appveyor)](https://coveralls.io/github/csMACnz/Coveralls.net-Samples?branch=nunit-opencover-appveyor)

This branch uses the NUnit test runner to run the NUnit tests through OpenCover, and Coveralls.net is run over the results.  This branch is picked up and run by Appveyor using the appveyor.yml file.

### [Typescript + Chutzpah + Appveyor Branch](https://github.com/csMACnz/Coveralls.net-Samples/tree/typescript-chutzpah-appveyor) ###
[![Appveyor Build status](https://ci.appveyor.com/api/projects/status/v4m661b28npr789g/branch/typescript-chutzpah-appveyor?svg=true)](https://ci.appveyor.com/project/MarkClearwater/coveralls-net-samples/branch/typescript-chutzpah-appveyor)
[![Coverage Status](https://coveralls.io/repos/csMACnz/Coveralls.net-Samples/badge.svg?branch=typescript-chutzpah-appveyor)](https://coveralls.io/github/csMACnz/Coveralls.net-Samples?branch=typescript-chutzpah-appveyor)

This branch demonstrates Typescript + Chutzpah testing for coverage results that can be published using Coveralls.net. This branch is picked up and run by Appveyor using the appveyor.yml file.

### [xUnit + monocov + Travis-CI Branch](https://github.com/csMACnz/Coveralls.net-Samples/tree/xunit-monocov-travisci) ###
[![Build Status](https://travis-ci.org/csMACnz/Coveralls.net-Samples.svg?branch=xunit-monocov-travisci)](https://travis-ci.org/csMACnz/Coveralls.net-Samples)
[![Coverage Status](https://coveralls.io/repos/csMACnz/Coveralls.net-Samples/badge.svg?branch=xunit-monocov-travisci)](https://coveralls.io/github/csMACnz/Coveralls.net-Samples?branch=xunit-monocov-travisci)

This branch uses the xUnit test runner to run the xUnit tests through monocov, and Coveralls.net is run over the results.  This branch is picked up and run by Travis-CI using the travis.yml file.


### [NUnit + monocov + Travis-CI Branch](https://github.com/csMACnz/Coveralls.net-Samples/tree/nunit-monocov-travisci) ###
[![Build Status](https://travis-ci.org/csMACnz/Coveralls.net-Samples.svg?branch=nunit-monocov-travisci)](https://travis-ci.org/csMACnz/Coveralls.net-Samples)
[![Coverage Status](https://coveralls.io/repos/csMACnz/Coveralls.net-Samples/badge.svg?branch=nunit-monocov-travisci)](https://coveralls.io/github/csMACnz/Coveralls.net-Samples?branch=nunit-monocov-travisci)

This branch uses the NUnit test runner to run the NUnit tests through monocov, and Coveralls.net is run over the results.  This branch is picked up and run by Travis-CI using the travis.yml file.


### [xUnit + visual studio code coverage + Appveyor Branch](https://github.com/csMACnz/Coveralls.net-Samples/tree/xunit-dynamiccodecoverage-appveyor) ###
[![Appveyor Build status](https://ci.appveyor.com/api/projects/status/v4m661b28npr789g/branch/xunit-dynamiccodecoverage-appveyor?svg=true)](https://ci.appveyor.com/project/MarkClearwater/coveralls-net-samples/branch/xunit-dynamiccodecoverage-appveyor)
[![Coverage Status](https://coveralls.io/repos/csMACnz/Coveralls.net-Samples/badge.svg?branch=xunit-dynamiccodecoverage-appveyor)](https://coveralls.io/github/csMACnz/Coveralls.net-Samples?branch=xunit-dynamiccodecoverage-appveyor)

This branch uses the xUnit test runner to run the xUnit tests through vstest.console.exe with coverage on, converts to xml using CodeCoverage.exe, and Coveralls.net is run over the results.  This branch is picked up and run by Appveyor using the appveyor.yml file.
