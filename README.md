Refit Kudu Demo
===============

Sample console application showing the use of Refit to consume the Kudu REST API.

This repository contains the code and presentation from my [Refit](https://github.com/paulcbetts/refit) demo at the [Keyboard Warriors](http://blog.thewcdc.net/kw1/) event in Copenhagen.

The code shows a sample implementation of consuming the [Kudu REST API](https://github.com/projectkudu/kudu/wiki/REST-API) through the use of [Refit](https://github.com/paulcbetts/refit). The console only implements three different commands (scm-info, deployments and extensionsfeed) to show how you could use the attributed interfaces for the REST services. To run the console you'll need a base url for Kudu running on Azure Web Sites (also referred to as the SCM site) and you'll need your publishing username and password to authenticate against the service.

Sample usage: 
KuduConsole.exe -s https://my-azure-site.scm.azurewebsites.net -u myuser -p mypassword -c deployments

The very short presentation ([revealJs slides](https://rawgit.com/sitereactor/Refit-Kudu-Demo/master/Presentation/index.html#/)) on Why and When to use refit is also available in this repository.