# blog.apachesparkgettingstarted


_Originally posted on :  [https://samuele.dev](https://samuele.dev)_

## Requirements
- .NET Core 3.0
- Apache Spark 2.3.0

## Run the project

```bash
dotnet build
cd blog.apachesparkgettingstarted/bin/Debug/netcoreapp3.0/
spark-submit --class org.apache.spark.deploy.dotnet.DotnetRunner  --master local microsoft-spark-2.4.x-0.4.0.jar    dotnet blog.apachesparkgettingstarted.dll
```

## Reference dataset

The dataset used in the example is available on [Kaggle - Seattle cultural space inventory](https://www.kaggle.com/city-of-seattle/seattle-cultural-space-inventory).