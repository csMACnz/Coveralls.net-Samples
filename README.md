Sample Application
==================

This branch contains some changes that will trigger a pull request (#7), that will still run coverage and publish to [coveralls.io](https://coveralls.io/) since it is in the same repository.

For this to work, you need to log into your repository on AppVeyor, go to the General Settings tab, and turn on `Enable secure variables in Pull Requests from the same repository only` otherwise the secure variables will be unavailable. (You may also need to push a further change to correctly trigger a refreshed build with this setting.)
