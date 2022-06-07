﻿using Pulumi;
using Pulumi.AwsNative.S3;
using System.Collections.Generic;

await Deployment.RunAsync(() =>
{
    // Create an AWS resource (S3 Bucket)
    var bucket = new Bucket("my-bucket");

    // Export the name of the bucket
    return new Dictionary<string, object?>
    {
        ["BucketName"] = bucket.Id
    };
});