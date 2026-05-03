using Abc.Data;

namespace Abc.Infra;

public class MoviesRepos(ApplicationDbContext c = null)
    : EfBaseRepo<ApplicationDbContext, Movie>(c), IMoviesRepo {
}
public class CurrenciesRepos(ApplicationDbContext c = null)
    : EfBaseRepo<ApplicationDbContext, Currency>(c), ICurrenciesRepo{
}
public class CountriesRepos(ApplicationDbContext c = null)
    : EfBaseRepo<ApplicationDbContext, Country>(c), ICountriesRepo{
}
public class MoniesRepos(ApplicationDbContext c = null)
    : EfBaseRepo<ApplicationDbContext, Money>(c), IMoniesRepo{
}
public class CountryCurrenciesRepos(ApplicationDbContext c = null)
    : EfBaseRepo<ApplicationDbContext, CountryCurrency>(c), ICountryCurrenciesRepo{}
