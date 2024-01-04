using System.ComponentModel.DataAnnotations.Schema;
using Bookshelf.Infra.Persistence.Entities.Library;

namespace Bookshelf.Infra.Persistence.Entities.Course;

public class CourseE
{
    public long Id { get; set; }
    public string Name { get; set; }
    public string Class { get; set; }
    public string Module { get; set; }
    public string Period { get; set; }
    public bool Active { get; set; }
    
    [ForeignKey("Library")] 
    public long LibraryId { get; set; }
    public LibraryE Library { get; set; }
}