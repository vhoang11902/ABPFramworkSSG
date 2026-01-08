using AbpSolution2.Books;
using Xunit;

namespace AbpSolution2.EntityFrameworkCore.Applications.Books;

[Collection(AbpSolution2TestConsts.CollectionDefinitionName)]
public class EfCoreBookAppService_Tests : BookAppService_Tests<AbpSolution2EntityFrameworkCoreTestModule>
{

}