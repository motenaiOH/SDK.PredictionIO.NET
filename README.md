SDK.PredictionIO.NET
=========================
SDK.PredictionIO.NET is an open source C# wrapper for the [PredictionIO]. If you are not already familiar 
with PredictionIO, it is an "open source machine learning server for software developers to create predictive features, such as personalization, recommendation and content discovery". It is an amazing machine learning software which stands on the shoulders of giants such as Apache Hadoop and Elasticsearch.

SDK.PredictionIO.NET supports PredictionIO version 0.11.

Quick start
----------
You will need to have access to an instance of PredictionIO, either locally (e.g. via a vagrant VM), or online (e.g. AWS AMI). For installation instructions have a look at the [PredictionIO] website.

After you setup the PredictionIO server, you will first need to create an application based on an algorithm.

Dependencies
------------
The only external dependencies for this project are [RestSharp] and [Newtonsoft.Json], available on nuget via this command:
```
> Install-Package RestSharp
> Install-Package Newtonsoft.Json
```

Changelog
---------
* 1.0: Initial release


[PredictionIO]:http://prediction.io
[RestSharp]:http://restsharp.org
[Newtonsoft.Json]:http://james.newtonking.com/json
