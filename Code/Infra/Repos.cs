using Abc.Data;

namespace Abc.Infra;

public class MoviesRepos(ApplicationDbContext c)
    : EfBaseRepo<ApplicationDbContext, Movie>(c), IMoviesRepo {
}
public class CurrenciesRepos(ApplicationDbContext c)
    : EfBaseRepo<ApplicationDbContext, Currency>(c), ICurrenciesRepo{
}
public class CountriesRepos(ApplicationDbContext c)
    : EfBaseRepo<ApplicationDbContext, Country>(c), ICountriesRepo{
}
public class MoniesRepos(ApplicationDbContext c)
    : EfBaseRepo<ApplicationDbContext, Money>(c), IMoniesRepo{
}
public class CountryCurrenciesRepos(ApplicationDbContext c)
    : EfBaseRepo<ApplicationDbContext, CountryCurrency>(c), ICountryCurrenciesRepo{}
