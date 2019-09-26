﻿using Microsoft.Spark.Sql;

namespace blog.apachesparkgettingstarted
{
    class Program
    {
        static void Main(string[] args)
        {
            SparkSession spark = SparkSession
                           .Builder()
                           .AppName("My application")
                           .GetOrCreate();

            DataFrame df = spark
                .Read()
                .Option("header", true)
                .Csv("./data/seattle-cultural-space-inventory.csv");

            df
                .Select("Name", "Phone")
                .Filter(df["Phone"].IsNotNull())
                .Show();
        }
    }
}