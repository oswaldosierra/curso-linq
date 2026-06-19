// Console.WriteLine("Hello, World!");

LinqQueries queries = new();

ImprimirValores(queries.TresPrimerosLibrosDeLaColecion());

void ImprimirValores(IEnumerable<Book> listadelibros)
{
  Console.WriteLine("{0, -60} {1, 15} {2, 15}\n", "Titulo", "N. Paginas", "Fecha Publicacion");
  foreach (var book in listadelibros)
  {
    Console.WriteLine("{0, -60} {1, 15} {2, 15}", book.Title, book.PageCount, book.PublishedDate.ToShortDateString());
  }
}

// Console.WriteLine($"Todos los libros tienen estado?: {queries.TodosLosLibrosTienenStatus()}");
// Console.WriteLine($"Libros Publicados en 2005?: {queries.LibrosPublicadosEn2005()}");
// Console.WriteLine($"Libros con mas de 200 paginas y menos de 500: {queries.LibrosConPagiasEntre200y500()}");
// Console.WriteLine($"Fecha del Libro Mas antiguo: {queries.FechaDePublicacionMenor()}");
// Console.WriteLine($"La mayor cantidad de paginas de un libro es: {queries.LibroConMasPaginas()}");