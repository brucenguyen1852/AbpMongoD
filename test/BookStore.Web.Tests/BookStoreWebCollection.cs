using BookStore.MongoDB;
using Xunit;

namespace BookStore;

[CollectionDefinition(BookStoreTestConsts.CollectionDefinitionName)]
public class BookStoreWebCollection : BookStoreMongoDbCollectionFixtureBase
{

}
