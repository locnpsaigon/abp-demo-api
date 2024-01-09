using AbpDemoApi.Samples;
using Xunit;

namespace AbpDemoApi.MongoDB.Domains;

[Collection(MongoTestCollection.Name)]
public class MongoDBSampleDomain_Tests : SampleManager_Tests<AbpDemoApiMongoDbTestModule>
{

}
