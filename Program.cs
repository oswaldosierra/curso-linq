// Console.WriteLine("Hello, World!");

LinqQueries queries = new();

ImprimirValores(queries.LibrosConMasDe500PGYPublicadosDespuesDe2005());

void ImprimirValores(IEnumerable<Book> listadelibros)
{
  Console.WriteLine("{0, -60} {1, 15} {2, 15}\n", "Titulo", "N. Paginas", "Fecha Publicacion");
  foreach (var book in listadelibros)
  {
    Console.WriteLine("{0, -60} {1, 15} {2, 15}", book.Title, book.PageCount, book.PublishedDate.ToShortDateString());
  }
}

// ImprimirGrupo(queries.LibrosPorAnoDespuesDel200());
// void ImprimirGrupo(IEnumerable<IGrouping<int,Book>> ListadeLibros)
// {
//     foreach(var grupo in ListadeLibros)
//     {
//         Console.WriteLine("");
//         Console.WriteLine($"Grupo: { grupo.Key }");
//         Console.WriteLine("{0,-60} {1, 15} {2, 15}\n", "Titulo", "N. Paginas", "Fecha publicacion");
//         foreach(var item in grupo)
//         {
//             Console.WriteLine("{0,-60} {1, 15} {2, 15}",item.Title,item.PageCount,item.PublishedDate.Date.ToShortDateString()); 
//         }
//     }
// }
// printDictionary(queries.DicionariosDeLibrosPorLetra(), 'A');
// void printDictionary(ILookup<char, Book> listBooks, char letter)
// {
//     char letterUpper = Char.ToUpper(letter);
//     if (listBooks[letterUpper].Count() == 0)
//     {
//         Console.WriteLine($"No hay libros que inicien con la letra '{letterUpper}'");
//     } 
//     else 
//     {
//         Console.WriteLine("{0, -60} {1, 15} {2, 15}\n", "Título", "Nro. Páginas", "Fecha de Publicación");
//         foreach (var book in listBooks[letterUpper])
//         {
//             Console.WriteLine("{0, -60} {1, 15} {2, 15}", book.Title, book.PageCount, book.PublishedDate.ToShortDateString());
//         }
//     }
// }

// Console.WriteLine($"Todos los libros tienen estado?: {queries.TodosLosLibrosTienenStatus()}");
// Console.WriteLine($"Libros Publicados en 2005?: {queries.LibrosPublicadosEn2005()}");
// Console.WriteLine($"Libros con mas de 200 paginas y menos de 500: {queries.LibrosConPagiasEntre200y500()}");
// Console.WriteLine($"Fecha del Libro Mas antiguo: {queries.FechaDePublicacionMenor()}");
// Console.WriteLine($"La mayor cantidad de paginas de un libro es: {queries.LibroConMasPaginas()}");
// Book? Libro = queries.LibroConFechaPublicacionMasReciente();
// Console.WriteLine($"El libro mas reciente: {Libro.Title}, y la fecha de publicacion es {Libro.PublishedDate:d}");
// Console.WriteLine($"LibrosPublicadosDespuesDe2015: {queries.LibrosPublicadosDespuesDe2015()}");
// Console.WriteLine($"PromedioCaracteresTitulo: {queries.PromedioCaracteresTitulo()}");
