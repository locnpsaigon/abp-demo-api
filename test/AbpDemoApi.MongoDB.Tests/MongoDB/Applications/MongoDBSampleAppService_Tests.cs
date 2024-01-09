using AbpDemoApi.MongoDB;
using AbpDemoApi.Samples;
using Xunit;

namespace AbpDemoApi.MongoDb.Applications;

[Collection(MongoTestCollection.Name)]
public class MongoDBSampleAppService_Tests : SampleAppService_Tests<AbpDemoApiMongoDbTestModule>
{

}
