using AbpSolution2.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace AbpSolution2.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(AbpSolution2EntityFrameworkCoreModule),
    typeof(AbpSolution2ApplicationContractsModule)
)]
public class AbpSolution2DbMigratorModule : AbpModule
{
}
