using Riok.Mapperly.Abstractions;
using Volo.Abp.Mapperly;
using AbpSolution2.Books;

namespace AbpSolution2;

[Mapper(RequiredMappingStrategy = RequiredMappingStrategy.Target)]
public partial class AbpSolution2BookToBookDtoMapper : MapperBase<Book, BookDto>
{
    public override partial BookDto Map(Book source);

    public override partial void Map(Book source, BookDto destination);
}

[Mapper(RequiredMappingStrategy = RequiredMappingStrategy.Target)]
public partial class AbpSolution2CreateUpdateBookDtoToBookMapper : MapperBase<CreateUpdateBookDto, Book>
{
    public override partial Book Map(CreateUpdateBookDto source);

    public override partial void Map(CreateUpdateBookDto source, Book destination);
}
