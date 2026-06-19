using System.Text.Json;

public class LinqQueries
{
  private List<Book> librosCollection = new List<Book>();
  public LinqQueries()
  {
    using (StreamReader reader = new StreamReader("books.json"))
    {
      string json = reader.ReadToEnd();
      this.librosCollection = JsonSerializer.Deserialize<List<Book>>(json, new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
    }
  }

  public IEnumerable<Book> TodaLaColeccion()
  {
    return librosCollection;
  }

  public IEnumerable<Book> LibrosDespuesDel2000()
  {
    // return librosCollection.Where(p => p.PublishedDate.Year >= 2000);
    return from l in librosCollection where l.PublishedDate.Year >= 200 select l;
  }

  public IEnumerable<Book> LibrosMasDe250Paginas()
  {
    // return librosCollection.Where(p => p.PageCount >= 250).Where(p => p.Title.Contains("action", StringComparison.OrdinalIgnoreCase));
    // return from l in librosCollection where l.PageCount >= 250 & l.Title.Contains("Action") select l;
    return librosCollection.Where(p => p.PageCount >= 250 && p.Title.Contains("action", StringComparison.OrdinalIgnoreCase));
  }

  public bool TodosLosLibrosTienenStatus()
  {
    return librosCollection.All(p => p.Status != String.Empty);
  }

  public bool LibrosPublicadosEn2005()
  {
    return librosCollection.Any(p => p.PublishedDate.Year == 2005);
  }

  public IEnumerable<Book> LibrosDePython()
  {
    return librosCollection.Where(p => p.Categories.Contains("Python"));
  }

  public IEnumerable<Book> LibrosDeJavaPorNombres()
  {
    return librosCollection.Where(p => p.Categories.Contains("Java")).OrderBy(p => p.Title);
  }

  public IEnumerable<Book> LibrosConMasDe450Paginas()
  {
    return librosCollection.Where(p => p.PageCount >= 450).OrderByDescending(p => p.PageCount);
  }

  public IEnumerable<Book> Los3LibrosMasRecienteEnJava()
  {
    return librosCollection.Where(p => p.Categories.Contains("Java")).OrderByDescending(p => p.PublishedDate).Take(3);
  }

  public IEnumerable<Book> LibrosConMasDe400Paginas3y4()
  {
    return librosCollection.Where(p => p.PageCount > 400).Skip(2).Take(2);
  }

  public IEnumerable<Book> TresPrimerosLibrosDeLaColecion()
  {
    return librosCollection.Take(3)
    .Select(p => new Book(){ Title = p.Title, PageCount = p.PageCount });
  }

  public int LibrosConPagiasEntre200y500()
  {
    return librosCollection.Count(p => p.PageCount >= 200 && p.PageCount <= 500);
  }

  public DateTime FechaDePublicacionMenor()
  {
    return librosCollection.Min(p => p.PublishedDate);
  }

  public int LibroConMasPaginas()
  {
    return librosCollection.Max(p => p.PageCount);
  }
}